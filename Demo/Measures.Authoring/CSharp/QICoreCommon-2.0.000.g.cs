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
[CqlLibrary("QICoreCommon", "2.0.000")]
public partial class QICoreCommon_2_0_000 : ILibrary, ISingleton<QICoreCommon_2_0_000>
{
    private QICoreCommon_2_0_000() {}

    public static QICoreCommon_2_0_000 Instance { get; } = new();

    #region Library Members
    public string Name => "QICoreCommon";
    public string Version => "2.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Birthdate")]
    public CqlCode Birthdate(CqlContext context) => 
        new CqlCode("21112-8", "http://loinc.org", default, default);


    [CqlDeclaration("Dead")]
    public CqlCode Dead(CqlContext context) => 
        new CqlCode("419099009", "http://snomed.info/sct", default, default);


    [CqlDeclaration("ER")]
    public CqlCode ER(CqlContext context) => 
        new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);


    [CqlDeclaration("ICU")]
    public CqlCode ICU(CqlContext context) => 
        new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);


    [CqlDeclaration("Billing")]
    public CqlCode Billing(CqlContext context) => 
        new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);


    [CqlDeclaration("ambulatory")]
    public CqlCode ambulatory(CqlContext context) => 
        new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("emergency")]
    public CqlCode emergency(CqlContext context) => 
        new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("field")]
    public CqlCode field(CqlContext context) => 
        new CqlCode("FLD", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("home health")]
    public CqlCode home_health(CqlContext context) => 
        new CqlCode("HH", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("inpatient encounter")]
    public CqlCode inpatient_encounter(CqlContext context) => 
        new CqlCode("IMP", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("inpatient acute")]
    public CqlCode inpatient_acute(CqlContext context) => 
        new CqlCode("ACUTE", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("inpatient non-acute")]
    public CqlCode inpatient_non_acute(CqlContext context) => 
        new CqlCode("NONAC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("observation encounter")]
    public CqlCode observation_encounter(CqlContext context) => 
        new CqlCode("OBSENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("pre-admission")]
    public CqlCode pre_admission(CqlContext context) => 
        new CqlCode("PRENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("short stay")]
    public CqlCode short_stay(CqlContext context) => 
        new CqlCode("SS", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("virtual")]
    public CqlCode @virtual(CqlContext context) => 
        new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("problem-list-item")]
    public CqlCode problem_list_item(CqlContext context) => 
        new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", default, default);


    [CqlDeclaration("encounter-diagnosis")]
    public CqlCode encounter_diagnosis(CqlContext context) => 
        new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", default, default);


    [CqlDeclaration("health-concern")]
    public CqlCode health_concern(CqlContext context) => 
        new CqlCode("health-concern", "http://hl7.org/fhir/us/core/CodeSystem/condition-category", default, default);


    [CqlDeclaration("active")]
    public CqlCode active(CqlContext context) => 
        new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("recurrence")]
    public CqlCode recurrence(CqlContext context) => 
        new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("relapse")]
    public CqlCode relapse(CqlContext context) => 
        new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("inactive")]
    public CqlCode inactive(CqlContext context) => 
        new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("remission")]
    public CqlCode remission(CqlContext context) => 
        new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("resolved")]
    public CqlCode resolved(CqlContext context) => 
        new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("unconfirmed")]
    public CqlCode unconfirmed(CqlContext context) => 
        new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);


    [CqlDeclaration("provisional")]
    public CqlCode provisional(CqlContext context) => 
        new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);


    [CqlDeclaration("differential")]
    public CqlCode differential(CqlContext context) => 
        new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);


    [CqlDeclaration("confirmed")]
    public CqlCode confirmed(CqlContext context) => 
        new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);


    [CqlDeclaration("refuted")]
    public CqlCode refuted(CqlContext context) => 
        new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);


    [CqlDeclaration("entered-in-error")]
    public CqlCode entered_in_error(CqlContext context) => 
        new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);


    [CqlDeclaration("allergy-active")]
    public CqlCode allergy_active(CqlContext context) => 
        new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);


    [CqlDeclaration("allergy-inactive")]
    public CqlCode allergy_inactive(CqlContext context) => 
        new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);


    [CqlDeclaration("allergy-resolved")]
    public CqlCode allergy_resolved(CqlContext context) => 
        new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);


    [CqlDeclaration("allergy-unconfirmed")]
    public CqlCode allergy_unconfirmed(CqlContext context) => 
        new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);


    [CqlDeclaration("allergy-confirmed")]
    public CqlCode allergy_confirmed(CqlContext context) => 
        new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);


    [CqlDeclaration("allergy-refuted")]
    public CqlCode allergy_refuted(CqlContext context) => 
        new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);


    [CqlDeclaration("Inpatient")]
    public CqlCode Inpatient(CqlContext context) => 
        new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);


    [CqlDeclaration("Outpatient")]
    public CqlCode Outpatient(CqlContext context) => 
        new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);


    [CqlDeclaration("Community")]
    public CqlCode Community(CqlContext context) => 
        new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);


    [CqlDeclaration("Discharge")]
    public CqlCode Discharge(CqlContext context) => 
        new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);


    [CqlDeclaration("AD")]
    public CqlCode AD(CqlContext context) => 
        new CqlCode("AD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);


    [CqlDeclaration("DD")]
    public CqlCode DD(CqlContext context) => 
        new CqlCode("DD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);


    [CqlDeclaration("CC")]
    public CqlCode CC(CqlContext context) => 
        new CqlCode("CC", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);


    [CqlDeclaration("CM")]
    public CqlCode CM(CqlContext context) => 
        new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);


    [CqlDeclaration("pre-op")]
    public CqlCode pre_op(CqlContext context) => 
        new CqlCode("pre-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);


    [CqlDeclaration("post-op")]
    public CqlCode post_op(CqlContext context) => 
        new CqlCode("post-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);


    [CqlDeclaration("billing")]
    public CqlCode billing(CqlContext context) => 
        new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);


    [CqlDeclaration("social-history")]
    public CqlCode social_history(CqlContext context) => 
        new CqlCode("social-history", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);


    [CqlDeclaration("vital-signs")]
    public CqlCode vital_signs(CqlContext context) => 
        new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);


    [CqlDeclaration("imaging")]
    public CqlCode imaging(CqlContext context) => 
        new CqlCode("imaging", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);


    [CqlDeclaration("laboratory")]
    public CqlCode laboratory(CqlContext context) => 
        new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);


    [CqlDeclaration("procedure")]
    public CqlCode procedure(CqlContext context) => 
        new CqlCode("procedure", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);


    [CqlDeclaration("survey")]
    public CqlCode survey(CqlContext context) => 
        new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);


    [CqlDeclaration("exam")]
    public CqlCode exam(CqlContext context) => 
        new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);


    [CqlDeclaration("therapy")]
    public CqlCode therapy(CqlContext context) => 
        new CqlCode("therapy", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);


    [CqlDeclaration("activity")]
    public CqlCode activity(CqlContext context) => 
        new CqlCode("activity", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);


    [CqlDeclaration("clinical-test")]
    public CqlCode clinical_test(CqlContext context) => 
        new CqlCode("clinical-test", "http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", default, default);


    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("419099009", "http://snomed.info/sct", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("FLD", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("HH", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("IMP", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("ACUTE", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("NONAC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("OBSENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("PRENC", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("SS", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
            new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("RoleCode")]
    public CqlCode[] RoleCode(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
            new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("Diagnosis Role")]
    public CqlCode[] Diagnosis_Role(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("AD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("DD", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("CC", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("pre-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("post-op", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
            new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("RequestIntent")]
    public CqlCode[] RequestIntent(CqlContext context)
    {
        CqlCode[] a_ = []
;

        return a_;
    }


    [CqlDeclaration("MedicationRequestCategory")]
    public CqlCode[] MedicationRequestCategory(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("inpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
            new CqlCode("outpatient", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
            new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
            new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("ConditionClinicalStatusCodes")]
    public CqlCode[] ConditionClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("ConditionVerificationStatusCodes")]
    public CqlCode[] ConditionVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("AllergyIntoleranceClinicalStatusCodes")]
    public CqlCode[] AllergyIntoleranceClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
            new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
            new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("AllergyIntoleranceVerificationStatusCodes")]
    public CqlCode[] AllergyIntoleranceVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
            new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
            new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("social-history", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("imaging", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("procedure", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("therapy", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("activity", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("USCoreObservationCategoryExtensionCodes")]
    public CqlCode[] USCoreObservationCategoryExtensionCodes(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("clinical-test", "http://hl7.org/fhir/us/core/CodeSystem/us-core-observation-category", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("ConditionCategory")]
    public CqlCode[] ConditionCategory(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("problem-list-item", "http://terminology.hl7.org/CodeSystem/condition-category", default, default),
            new CqlCode("encounter-diagnosis", "http://terminology.hl7.org/CodeSystem/condition-category", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("USCoreConditionCategoryExtensionCodes")]
    public CqlCode[] USCoreConditionCategoryExtensionCodes(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("health-concern", "http://hl7.org/fhir/us/core/CodeSystem/condition-category", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }

    public bool? isActive(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.ClinicalStatus;
        CqlConcept b_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, a_);
        CqlCode c_ = this.active(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        bool? e_ = context.Operators.Equivalent(b_, d_);
        CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, a_);
        CqlCode h_ = this.recurrence(context);
        CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
        bool? j_ = context.Operators.Equivalent(g_, i_);
        bool? k_ = context.Operators.Or(e_, j_);
        CqlConcept m_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, a_);
        CqlCode n_ = this.relapse(context);
        CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
        bool? p_ = context.Operators.Equivalent(m_, o_);
        bool? q_ = context.Operators.Or(k_, p_);

        return q_;
    }

    public bool? hasCategory(CqlContext context, Condition condition, CqlCode category)
    {
        List<CodeableConcept> a_ = condition?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(category);
            bool? i_ = context.Operators.Equivalent(C, h_);

            return i_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? hasCategory(CqlContext context, Observation observation, CqlCode category)
    {
        List<CodeableConcept> a_ = observation?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlConcept h_ = context.Operators.ConvertCodeToConcept(category);
            bool? i_ = context.Operators.Equivalent(C, h_);

            return i_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isProblemListItem(CqlContext context, Condition condition)
    {
        List<CodeableConcept> a_ = condition?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.problem_list_item(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isEncounterDiagnosis(CqlContext context, Condition condition)
    {
        List<CodeableConcept> a_ = condition?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.encounter_diagnosis(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isHealthConcern(CqlContext context, Condition condition)
    {
        List<CodeableConcept> a_ = condition?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.health_concern(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isSocialHistory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.social_history(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isVitalSign(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.vital_signs(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isImaging(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.imaging(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isLaboratory(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.laboratory(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isProcedure(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.procedure(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isSurvey(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.survey(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isExam(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.exam(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isTherapy(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.therapy(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isActivity(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.activity(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isClinicalTest(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.clinical_test(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isCommunity(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> a_ = medicationRequest?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.Community(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? isDischarge(CqlContext context, MedicationRequest medicationRequest)
    {
        List<CodeableConcept> a_ = medicationRequest?.Category;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept C)
        {
            CqlCode h_ = this.Discharge(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            bool? j_ = context.Operators.Equivalent(C, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }

    public bool? doNotPerform(CqlContext context, DeviceRequest deviceRequest)
    {
        bool? a_(Extension E)
        {
            string f_ = E?.Url;
            FhirString g_ = context.Operators.Convert<FhirString>(f_);
            string h_ = g_?.Value;
            bool? i_ = context.Operators.Equal(h_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerform");

            return i_;
        };
        IEnumerable<Extension> b_ = context.Operators.Where<Extension>((deviceRequest is DomainResource
                ? (IEnumerable<Extension>)((deviceRequest as DomainResource).ModifierExtension)
                : default), a_);
        bool? c_(Extension E)
        {
            DataType j_ = E?.Value;
            object k_ = FHIRHelpers_4_3_000.Instance.ToValue(context, j_);

            return k_ as bool?;
        };
        IEnumerable<bool?> d_ = context.Operators.Select<Extension, bool?>(b_, c_);
        bool? e_ = context.Operators.SingletonFrom<bool?>(d_);

        return e_;
    }

    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> b_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return b_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient c_ = this.Patient(context);
                Date d_ = c_?.BirthDateElement;
                string e_ = d_?.Value;
                CqlDate f_ = context.Operators.ConvertStringToDate(e_);
                CqlDate g_ = context.Operators.Add(f_, choice as CqlQuantity);
                Date i_ = c_?.BirthDateElement;
                string j_ = i_?.Value;
                CqlDate k_ = context.Operators.ConvertStringToDate(j_);
                CqlDate l_ = context.Operators.Add(k_, choice as CqlQuantity);
                CqlQuantity m_ = context.Operators.Quantity(1m, "year");
                CqlDate n_ = context.Operators.Add(l_, m_);
                CqlInterval<CqlDate> o_ = context.Operators.Interval(g_, n_, true, false);
                CqlDate p_ = o_?.low;
                CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
                Date s_ = c_?.BirthDateElement;
                string t_ = s_?.Value;
                CqlDate u_ = context.Operators.ConvertStringToDate(t_);
                CqlDate v_ = context.Operators.Add(u_, choice as CqlQuantity);
                Date x_ = c_?.BirthDateElement;
                string y_ = x_?.Value;
                CqlDate z_ = context.Operators.ConvertStringToDate(y_);
                CqlDate aa_ = context.Operators.Add(z_, choice as CqlQuantity);
                CqlDate ac_ = context.Operators.Add(aa_, m_);
                CqlInterval<CqlDate> ad_ = context.Operators.Interval(v_, ac_, true, false);
                CqlDate ae_ = ad_?.high;
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);
                Date ah_ = c_?.BirthDateElement;
                string ai_ = ah_?.Value;
                CqlDate aj_ = context.Operators.ConvertStringToDate(ai_);
                CqlDate ak_ = context.Operators.Add(aj_, choice as CqlQuantity);
                Date am_ = c_?.BirthDateElement;
                string an_ = am_?.Value;
                CqlDate ao_ = context.Operators.ConvertStringToDate(an_);
                CqlDate ap_ = context.Operators.Add(ao_, choice as CqlQuantity);
                CqlDate ar_ = context.Operators.Add(ap_, m_);
                CqlInterval<CqlDate> as_ = context.Operators.Interval(ak_, ar_, true, false);
                bool? at_ = as_?.lowClosed;
                Date av_ = c_?.BirthDateElement;
                string aw_ = av_?.Value;
                CqlDate ax_ = context.Operators.ConvertStringToDate(aw_);
                CqlDate ay_ = context.Operators.Add(ax_, choice as CqlQuantity);
                Date ba_ = c_?.BirthDateElement;
                string bb_ = ba_?.Value;
                CqlDate bc_ = context.Operators.ConvertStringToDate(bb_);
                CqlDate bd_ = context.Operators.Add(bc_, choice as CqlQuantity);
                CqlDate bf_ = context.Operators.Add(bd_, m_);
                CqlInterval<CqlDate> bg_ = context.Operators.Interval(ay_, bf_, true, false);
                bool? bh_ = bg_?.highClosed;
                CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(q_, af_, at_, bh_);

                return bi_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient bj_ = this.Patient(context);
                Date bk_ = bj_?.BirthDateElement;
                string bl_ = bk_?.Value;
                CqlDate bm_ = context.Operators.ConvertStringToDate(bl_);
                object bn_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate bo_ = context.Operators.Add(bm_, bn_ as CqlQuantity);
                Date bq_ = bj_?.BirthDateElement;
                string br_ = bq_?.Value;
                CqlDate bs_ = context.Operators.ConvertStringToDate(br_);
                object bt_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate bu_ = context.Operators.Add(bs_, bt_ as CqlQuantity);
                CqlQuantity bv_ = context.Operators.Quantity(1m, "year");
                CqlDate bw_ = context.Operators.Add(bu_, bv_);
                CqlInterval<CqlDate> bx_ = context.Operators.Interval(bo_, bw_, true, false);
                CqlDate by_ = bx_?.low;
                CqlDateTime bz_ = context.Operators.ConvertDateToDateTime(by_);
                Date cb_ = bj_?.BirthDateElement;
                string cc_ = cb_?.Value;
                CqlDate cd_ = context.Operators.ConvertStringToDate(cc_);
                CqlDate cf_ = context.Operators.Add(cd_, bn_ as CqlQuantity);
                Date ch_ = bj_?.BirthDateElement;
                string ci_ = ch_?.Value;
                CqlDate cj_ = context.Operators.ConvertStringToDate(ci_);
                CqlDate cl_ = context.Operators.Add(cj_, bt_ as CqlQuantity);
                CqlDate cn_ = context.Operators.Add(cl_, bv_);
                CqlInterval<CqlDate> co_ = context.Operators.Interval(cf_, cn_, true, false);
                CqlDate cp_ = co_?.high;
                CqlDateTime cq_ = context.Operators.ConvertDateToDateTime(cp_);
                Date cs_ = bj_?.BirthDateElement;
                string ct_ = cs_?.Value;
                CqlDate cu_ = context.Operators.ConvertStringToDate(ct_);
                CqlDate cw_ = context.Operators.Add(cu_, bn_ as CqlQuantity);
                Date cy_ = bj_?.BirthDateElement;
                string cz_ = cy_?.Value;
                CqlDate da_ = context.Operators.ConvertStringToDate(cz_);
                CqlDate dc_ = context.Operators.Add(da_, bt_ as CqlQuantity);
                CqlDate de_ = context.Operators.Add(dc_, bv_);
                CqlInterval<CqlDate> df_ = context.Operators.Interval(cw_, de_, true, false);
                bool? dg_ = df_?.lowClosed;
                Date di_ = bj_?.BirthDateElement;
                string dj_ = di_?.Value;
                CqlDate dk_ = context.Operators.ConvertStringToDate(dj_);
                CqlDate dm_ = context.Operators.Add(dk_, bn_ as CqlQuantity);
                Date do_ = bj_?.BirthDateElement;
                string dp_ = do_?.Value;
                CqlDate dq_ = context.Operators.ConvertStringToDate(dp_);
                CqlDate ds_ = context.Operators.Add(dq_, bt_ as CqlQuantity);
                CqlDate du_ = context.Operators.Add(ds_, bv_);
                CqlInterval<CqlDate> dv_ = context.Operators.Interval(dm_, du_, true, false);
                bool? dw_ = dv_?.highClosed;
                CqlInterval<CqlDateTime> dx_ = context.Operators.Interval(bz_, cq_, dg_, dw_);

                return dx_;
            }
            else if (choice is Timing)
            {
                object dy_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return dy_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return a_();
    }

    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_()
        {
            if (choice is CqlDateTime)
            {
                CqlInterval<CqlDateTime> b_ = context.Operators.Interval(choice as CqlDateTime, choice as CqlDateTime, true, true);

                return b_;
            }
            else if (choice is CqlInterval<CqlDateTime>)
            {
                return choice as CqlInterval<CqlDateTime>;
            }
            else if (choice is CqlQuantity)
            {
                Patient c_ = this.Patient(context);
                Date d_ = c_?.BirthDateElement;
                string e_ = d_?.Value;
                CqlDate f_ = context.Operators.ConvertStringToDate(e_);
                CqlDate g_ = context.Operators.Add(f_, choice as CqlQuantity);
                Date i_ = c_?.BirthDateElement;
                string j_ = i_?.Value;
                CqlDate k_ = context.Operators.ConvertStringToDate(j_);
                CqlDate l_ = context.Operators.Add(k_, choice as CqlQuantity);
                CqlQuantity m_ = context.Operators.Quantity(1m, "year");
                CqlDate n_ = context.Operators.Add(l_, m_);
                CqlInterval<CqlDate> o_ = context.Operators.Interval(g_, n_, true, false);
                CqlDate p_ = o_?.low;
                CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
                Date s_ = c_?.BirthDateElement;
                string t_ = s_?.Value;
                CqlDate u_ = context.Operators.ConvertStringToDate(t_);
                CqlDate v_ = context.Operators.Add(u_, choice as CqlQuantity);
                Date x_ = c_?.BirthDateElement;
                string y_ = x_?.Value;
                CqlDate z_ = context.Operators.ConvertStringToDate(y_);
                CqlDate aa_ = context.Operators.Add(z_, choice as CqlQuantity);
                CqlDate ac_ = context.Operators.Add(aa_, m_);
                CqlInterval<CqlDate> ad_ = context.Operators.Interval(v_, ac_, true, false);
                CqlDate ae_ = ad_?.high;
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);
                Date ah_ = c_?.BirthDateElement;
                string ai_ = ah_?.Value;
                CqlDate aj_ = context.Operators.ConvertStringToDate(ai_);
                CqlDate ak_ = context.Operators.Add(aj_, choice as CqlQuantity);
                Date am_ = c_?.BirthDateElement;
                string an_ = am_?.Value;
                CqlDate ao_ = context.Operators.ConvertStringToDate(an_);
                CqlDate ap_ = context.Operators.Add(ao_, choice as CqlQuantity);
                CqlDate ar_ = context.Operators.Add(ap_, m_);
                CqlInterval<CqlDate> as_ = context.Operators.Interval(ak_, ar_, true, false);
                bool? at_ = as_?.lowClosed;
                Date av_ = c_?.BirthDateElement;
                string aw_ = av_?.Value;
                CqlDate ax_ = context.Operators.ConvertStringToDate(aw_);
                CqlDate ay_ = context.Operators.Add(ax_, choice as CqlQuantity);
                Date ba_ = c_?.BirthDateElement;
                string bb_ = ba_?.Value;
                CqlDate bc_ = context.Operators.ConvertStringToDate(bb_);
                CqlDate bd_ = context.Operators.Add(bc_, choice as CqlQuantity);
                CqlDate bf_ = context.Operators.Add(bd_, m_);
                CqlInterval<CqlDate> bg_ = context.Operators.Interval(ay_, bf_, true, false);
                bool? bh_ = bg_?.highClosed;
                CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(q_, af_, at_, bh_);

                return bi_;
            }
            else if (choice is CqlInterval<CqlQuantity>)
            {
                Patient bj_ = this.Patient(context);
                Date bk_ = bj_?.BirthDateElement;
                string bl_ = bk_?.Value;
                CqlDate bm_ = context.Operators.ConvertStringToDate(bl_);
                object bn_ = context.Operators.LateBoundProperty<object>(choice, "low");
                CqlDate bo_ = context.Operators.Add(bm_, bn_ as CqlQuantity);
                Date bq_ = bj_?.BirthDateElement;
                string br_ = bq_?.Value;
                CqlDate bs_ = context.Operators.ConvertStringToDate(br_);
                object bt_ = context.Operators.LateBoundProperty<object>(choice, "high");
                CqlDate bu_ = context.Operators.Add(bs_, bt_ as CqlQuantity);
                CqlQuantity bv_ = context.Operators.Quantity(1m, "year");
                CqlDate bw_ = context.Operators.Add(bu_, bv_);
                CqlInterval<CqlDate> bx_ = context.Operators.Interval(bo_, bw_, true, false);
                CqlDate by_ = bx_?.low;
                CqlDateTime bz_ = context.Operators.ConvertDateToDateTime(by_);
                Date cb_ = bj_?.BirthDateElement;
                string cc_ = cb_?.Value;
                CqlDate cd_ = context.Operators.ConvertStringToDate(cc_);
                CqlDate cf_ = context.Operators.Add(cd_, bn_ as CqlQuantity);
                Date ch_ = bj_?.BirthDateElement;
                string ci_ = ch_?.Value;
                CqlDate cj_ = context.Operators.ConvertStringToDate(ci_);
                CqlDate cl_ = context.Operators.Add(cj_, bt_ as CqlQuantity);
                CqlDate cn_ = context.Operators.Add(cl_, bv_);
                CqlInterval<CqlDate> co_ = context.Operators.Interval(cf_, cn_, true, false);
                CqlDate cp_ = co_?.high;
                CqlDateTime cq_ = context.Operators.ConvertDateToDateTime(cp_);
                Date cs_ = bj_?.BirthDateElement;
                string ct_ = cs_?.Value;
                CqlDate cu_ = context.Operators.ConvertStringToDate(ct_);
                CqlDate cw_ = context.Operators.Add(cu_, bn_ as CqlQuantity);
                Date cy_ = bj_?.BirthDateElement;
                string cz_ = cy_?.Value;
                CqlDate da_ = context.Operators.ConvertStringToDate(cz_);
                CqlDate dc_ = context.Operators.Add(da_, bt_ as CqlQuantity);
                CqlDate de_ = context.Operators.Add(dc_, bv_);
                CqlInterval<CqlDate> df_ = context.Operators.Interval(cw_, de_, true, false);
                bool? dg_ = df_?.lowClosed;
                Date di_ = bj_?.BirthDateElement;
                string dj_ = di_?.Value;
                CqlDate dk_ = context.Operators.ConvertStringToDate(dj_);
                CqlDate dm_ = context.Operators.Add(dk_, bn_ as CqlQuantity);
                Date do_ = bj_?.BirthDateElement;
                string dp_ = do_?.Value;
                CqlDate dq_ = context.Operators.ConvertStringToDate(dp_);
                CqlDate ds_ = context.Operators.Add(dq_, bt_ as CqlQuantity);
                CqlDate du_ = context.Operators.Add(ds_, bv_);
                CqlInterval<CqlDate> dv_ = context.Operators.Interval(dm_, du_, true, false);
                bool? dw_ = dv_?.highClosed;
                CqlInterval<CqlDateTime> dx_ = context.Operators.Interval(bz_, cq_, dg_, dw_);

                return dx_;
            }
            else if (choice is Timing)
            {
                object dy_ = context.Operators.Message<object>(null, "NOT_IMPLEMENTED", "Error", "Calculation of an interval from a Timing value is not supported");

                return dy_ as CqlInterval<CqlDateTime>;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return a_();
    }

    public CqlInterval<CqlDateTime> ToAbatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> a_()
        {
            bool b_()
            {
                DataType f_ = condition?.Abatement;
                object g_ = FHIRHelpers_4_3_000.Instance.ToValue(context, f_);
                bool h_ = g_ is CqlDateTime;

                return h_;
            };
            bool c_()
            {
                DataType i_ = condition?.Abatement;
                object j_ = FHIRHelpers_4_3_000.Instance.ToValue(context, i_);
                bool k_ = j_ is CqlQuantity;

                return k_;
            };
            bool d_()
            {
                DataType l_ = condition?.Abatement;
                object m_ = FHIRHelpers_4_3_000.Instance.ToValue(context, l_);
                bool n_ = m_ is CqlInterval<CqlQuantity>;

                return n_;
            };
            bool e_()
            {
                DataType o_ = condition?.Abatement;
                object p_ = FHIRHelpers_4_3_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlInterval<CqlDateTime>;

                return q_;
            };
            if (b_())
            {
                DataType r_ = condition?.Abatement;
                object s_ = FHIRHelpers_4_3_000.Instance.ToValue(context, r_);
                object u_ = FHIRHelpers_4_3_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(s_ as CqlDateTime, u_ as CqlDateTime, true, true);

                return v_;
            }
            else if (c_())
            {
                Patient w_ = this.Patient(context);
                Date x_ = w_?.BirthDateElement;
                string y_ = x_?.Value;
                CqlDate z_ = context.Operators.ConvertStringToDate(y_);
                DataType aa_ = condition?.Abatement;
                object ab_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate ac_ = context.Operators.Add(z_, ab_ as CqlQuantity);
                Date ae_ = w_?.BirthDateElement;
                string af_ = ae_?.Value;
                CqlDate ag_ = context.Operators.ConvertStringToDate(af_);
                object ai_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate aj_ = context.Operators.Add(ag_, ai_ as CqlQuantity);
                CqlQuantity ak_ = context.Operators.Quantity(1m, "year");
                CqlDate al_ = context.Operators.Add(aj_, ak_);
                CqlInterval<CqlDate> am_ = context.Operators.Interval(ac_, al_, true, false);
                CqlDate an_ = am_?.low;
                CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
                Date aq_ = w_?.BirthDateElement;
                string ar_ = aq_?.Value;
                CqlDate as_ = context.Operators.ConvertStringToDate(ar_);
                object au_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate av_ = context.Operators.Add(as_, au_ as CqlQuantity);
                Date ax_ = w_?.BirthDateElement;
                string ay_ = ax_?.Value;
                CqlDate az_ = context.Operators.ConvertStringToDate(ay_);
                object bb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate bc_ = context.Operators.Add(az_, bb_ as CqlQuantity);
                CqlDate be_ = context.Operators.Add(bc_, ak_);
                CqlInterval<CqlDate> bf_ = context.Operators.Interval(av_, be_, true, false);
                CqlDate bg_ = bf_?.high;
                CqlDateTime bh_ = context.Operators.ConvertDateToDateTime(bg_);
                Date bj_ = w_?.BirthDateElement;
                string bk_ = bj_?.Value;
                CqlDate bl_ = context.Operators.ConvertStringToDate(bk_);
                object bn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate bo_ = context.Operators.Add(bl_, bn_ as CqlQuantity);
                Date bq_ = w_?.BirthDateElement;
                string br_ = bq_?.Value;
                CqlDate bs_ = context.Operators.ConvertStringToDate(br_);
                object bu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate bv_ = context.Operators.Add(bs_, bu_ as CqlQuantity);
                CqlDate bx_ = context.Operators.Add(bv_, ak_);
                CqlInterval<CqlDate> by_ = context.Operators.Interval(bo_, bx_, true, false);
                bool? bz_ = by_?.lowClosed;
                Date cb_ = w_?.BirthDateElement;
                string cc_ = cb_?.Value;
                CqlDate cd_ = context.Operators.ConvertStringToDate(cc_);
                object cf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate cg_ = context.Operators.Add(cd_, cf_ as CqlQuantity);
                Date ci_ = w_?.BirthDateElement;
                string cj_ = ci_?.Value;
                CqlDate ck_ = context.Operators.ConvertStringToDate(cj_);
                object cm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate cn_ = context.Operators.Add(ck_, cm_ as CqlQuantity);
                CqlDate cp_ = context.Operators.Add(cn_, ak_);
                CqlInterval<CqlDate> cq_ = context.Operators.Interval(cg_, cp_, true, false);
                bool? cr_ = cq_?.highClosed;
                CqlInterval<CqlDateTime> cs_ = context.Operators.Interval(ao_, bh_, bz_, cr_);

                return cs_;
            }
            else if (d_())
            {
                Patient ct_ = this.Patient(context);
                Date cu_ = ct_?.BirthDateElement;
                string cv_ = cu_?.Value;
                CqlDate cw_ = context.Operators.ConvertStringToDate(cv_);
                DataType cx_ = condition?.Abatement;
                object cy_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object cz_ = context.Operators.LateBoundProperty<object>(cy_, "low");
                CqlDate da_ = context.Operators.Add(cw_, cz_ as CqlQuantity);
                Date dc_ = ct_?.BirthDateElement;
                string dd_ = dc_?.Value;
                CqlDate de_ = context.Operators.ConvertStringToDate(dd_);
                object dg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object dh_ = context.Operators.LateBoundProperty<object>(dg_, "high");
                CqlDate di_ = context.Operators.Add(de_, dh_ as CqlQuantity);
                CqlQuantity dj_ = context.Operators.Quantity(1m, "year");
                CqlDate dk_ = context.Operators.Add(di_, dj_);
                CqlInterval<CqlDate> dl_ = context.Operators.Interval(da_, dk_, true, false);
                CqlDate dm_ = dl_?.low;
                CqlDateTime dn_ = context.Operators.ConvertDateToDateTime(dm_);
                Date dp_ = ct_?.BirthDateElement;
                string dq_ = dp_?.Value;
                CqlDate dr_ = context.Operators.ConvertStringToDate(dq_);
                object dt_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object du_ = context.Operators.LateBoundProperty<object>(dt_, "low");
                CqlDate dv_ = context.Operators.Add(dr_, du_ as CqlQuantity);
                Date dx_ = ct_?.BirthDateElement;
                string dy_ = dx_?.Value;
                CqlDate dz_ = context.Operators.ConvertStringToDate(dy_);
                object eb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object ec_ = context.Operators.LateBoundProperty<object>(eb_, "high");
                CqlDate ed_ = context.Operators.Add(dz_, ec_ as CqlQuantity);
                CqlDate ef_ = context.Operators.Add(ed_, dj_);
                CqlInterval<CqlDate> eg_ = context.Operators.Interval(dv_, ef_, true, false);
                CqlDate eh_ = eg_?.high;
                CqlDateTime ei_ = context.Operators.ConvertDateToDateTime(eh_);
                Date ek_ = ct_?.BirthDateElement;
                string el_ = ek_?.Value;
                CqlDate em_ = context.Operators.ConvertStringToDate(el_);
                object eo_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object ep_ = context.Operators.LateBoundProperty<object>(eo_, "low");
                CqlDate eq_ = context.Operators.Add(em_, ep_ as CqlQuantity);
                Date es_ = ct_?.BirthDateElement;
                string et_ = es_?.Value;
                CqlDate eu_ = context.Operators.ConvertStringToDate(et_);
                object ew_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object ex_ = context.Operators.LateBoundProperty<object>(ew_, "high");
                CqlDate ey_ = context.Operators.Add(eu_, ex_ as CqlQuantity);
                CqlDate fa_ = context.Operators.Add(ey_, dj_);
                CqlInterval<CqlDate> fb_ = context.Operators.Interval(eq_, fa_, true, false);
                bool? fc_ = fb_?.lowClosed;
                Date fe_ = ct_?.BirthDateElement;
                string ff_ = fe_?.Value;
                CqlDate fg_ = context.Operators.ConvertStringToDate(ff_);
                object fi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object fj_ = context.Operators.LateBoundProperty<object>(fi_, "low");
                CqlDate fk_ = context.Operators.Add(fg_, fj_ as CqlQuantity);
                Date fm_ = ct_?.BirthDateElement;
                string fn_ = fm_?.Value;
                CqlDate fo_ = context.Operators.ConvertStringToDate(fn_);
                object fq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object fr_ = context.Operators.LateBoundProperty<object>(fq_, "high");
                CqlDate fs_ = context.Operators.Add(fo_, fr_ as CqlQuantity);
                CqlDate fu_ = context.Operators.Add(fs_, dj_);
                CqlInterval<CqlDate> fv_ = context.Operators.Interval(fk_, fu_, true, false);
                bool? fw_ = fv_?.highClosed;
                CqlInterval<CqlDateTime> fx_ = context.Operators.Interval(dn_, ei_, fc_, fw_);

                return fx_;
            }
            else if (e_())
            {
                DataType fy_ = condition?.Abatement;
                object fz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fy_);
                object ga_ = context.Operators.LateBoundProperty<object>(fz_, "low");
                object gc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fy_);
                object gd_ = context.Operators.LateBoundProperty<object>(gc_, "high");
                CqlInterval<CqlDateTime> ge_ = context.Operators.Interval(ga_ as CqlDateTime, gd_ as CqlDateTime, true, false);

                return ge_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return a_();
    }

    public CqlInterval<CqlDateTime> abatementInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> a_()
        {
            bool b_()
            {
                DataType f_ = condition?.Abatement;
                object g_ = FHIRHelpers_4_3_000.Instance.ToValue(context, f_);
                bool h_ = g_ is CqlDateTime;

                return h_;
            };
            bool c_()
            {
                DataType i_ = condition?.Abatement;
                object j_ = FHIRHelpers_4_3_000.Instance.ToValue(context, i_);
                bool k_ = j_ is CqlQuantity;

                return k_;
            };
            bool d_()
            {
                DataType l_ = condition?.Abatement;
                object m_ = FHIRHelpers_4_3_000.Instance.ToValue(context, l_);
                bool n_ = m_ is CqlInterval<CqlQuantity>;

                return n_;
            };
            bool e_()
            {
                DataType o_ = condition?.Abatement;
                object p_ = FHIRHelpers_4_3_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlInterval<CqlDateTime>;

                return q_;
            };
            if (b_())
            {
                DataType r_ = condition?.Abatement;
                object s_ = FHIRHelpers_4_3_000.Instance.ToValue(context, r_);
                object u_ = FHIRHelpers_4_3_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(s_ as CqlDateTime, u_ as CqlDateTime, true, true);

                return v_;
            }
            else if (c_())
            {
                Patient w_ = this.Patient(context);
                Date x_ = w_?.BirthDateElement;
                string y_ = x_?.Value;
                CqlDate z_ = context.Operators.ConvertStringToDate(y_);
                DataType aa_ = condition?.Abatement;
                object ab_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate ac_ = context.Operators.Add(z_, ab_ as CqlQuantity);
                Date ae_ = w_?.BirthDateElement;
                string af_ = ae_?.Value;
                CqlDate ag_ = context.Operators.ConvertStringToDate(af_);
                object ai_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate aj_ = context.Operators.Add(ag_, ai_ as CqlQuantity);
                CqlQuantity ak_ = context.Operators.Quantity(1m, "year");
                CqlDate al_ = context.Operators.Add(aj_, ak_);
                CqlInterval<CqlDate> am_ = context.Operators.Interval(ac_, al_, true, false);
                CqlDate an_ = am_?.low;
                CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
                Date aq_ = w_?.BirthDateElement;
                string ar_ = aq_?.Value;
                CqlDate as_ = context.Operators.ConvertStringToDate(ar_);
                object au_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate av_ = context.Operators.Add(as_, au_ as CqlQuantity);
                Date ax_ = w_?.BirthDateElement;
                string ay_ = ax_?.Value;
                CqlDate az_ = context.Operators.ConvertStringToDate(ay_);
                object bb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate bc_ = context.Operators.Add(az_, bb_ as CqlQuantity);
                CqlDate be_ = context.Operators.Add(bc_, ak_);
                CqlInterval<CqlDate> bf_ = context.Operators.Interval(av_, be_, true, false);
                CqlDate bg_ = bf_?.high;
                CqlDateTime bh_ = context.Operators.ConvertDateToDateTime(bg_);
                Date bj_ = w_?.BirthDateElement;
                string bk_ = bj_?.Value;
                CqlDate bl_ = context.Operators.ConvertStringToDate(bk_);
                object bn_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate bo_ = context.Operators.Add(bl_, bn_ as CqlQuantity);
                Date bq_ = w_?.BirthDateElement;
                string br_ = bq_?.Value;
                CqlDate bs_ = context.Operators.ConvertStringToDate(br_);
                object bu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate bv_ = context.Operators.Add(bs_, bu_ as CqlQuantity);
                CqlDate bx_ = context.Operators.Add(bv_, ak_);
                CqlInterval<CqlDate> by_ = context.Operators.Interval(bo_, bx_, true, false);
                bool? bz_ = by_?.lowClosed;
                Date cb_ = w_?.BirthDateElement;
                string cc_ = cb_?.Value;
                CqlDate cd_ = context.Operators.ConvertStringToDate(cc_);
                object cf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate cg_ = context.Operators.Add(cd_, cf_ as CqlQuantity);
                Date ci_ = w_?.BirthDateElement;
                string cj_ = ci_?.Value;
                CqlDate ck_ = context.Operators.ConvertStringToDate(cj_);
                object cm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aa_);
                CqlDate cn_ = context.Operators.Add(ck_, cm_ as CqlQuantity);
                CqlDate cp_ = context.Operators.Add(cn_, ak_);
                CqlInterval<CqlDate> cq_ = context.Operators.Interval(cg_, cp_, true, false);
                bool? cr_ = cq_?.highClosed;
                CqlInterval<CqlDateTime> cs_ = context.Operators.Interval(ao_, bh_, bz_, cr_);

                return cs_;
            }
            else if (d_())
            {
                Patient ct_ = this.Patient(context);
                Date cu_ = ct_?.BirthDateElement;
                string cv_ = cu_?.Value;
                CqlDate cw_ = context.Operators.ConvertStringToDate(cv_);
                DataType cx_ = condition?.Abatement;
                object cy_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object cz_ = context.Operators.LateBoundProperty<object>(cy_, "low");
                CqlDate da_ = context.Operators.Add(cw_, cz_ as CqlQuantity);
                Date dc_ = ct_?.BirthDateElement;
                string dd_ = dc_?.Value;
                CqlDate de_ = context.Operators.ConvertStringToDate(dd_);
                object dg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object dh_ = context.Operators.LateBoundProperty<object>(dg_, "high");
                CqlDate di_ = context.Operators.Add(de_, dh_ as CqlQuantity);
                CqlQuantity dj_ = context.Operators.Quantity(1m, "year");
                CqlDate dk_ = context.Operators.Add(di_, dj_);
                CqlInterval<CqlDate> dl_ = context.Operators.Interval(da_, dk_, true, false);
                CqlDate dm_ = dl_?.low;
                CqlDateTime dn_ = context.Operators.ConvertDateToDateTime(dm_);
                Date dp_ = ct_?.BirthDateElement;
                string dq_ = dp_?.Value;
                CqlDate dr_ = context.Operators.ConvertStringToDate(dq_);
                object dt_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object du_ = context.Operators.LateBoundProperty<object>(dt_, "low");
                CqlDate dv_ = context.Operators.Add(dr_, du_ as CqlQuantity);
                Date dx_ = ct_?.BirthDateElement;
                string dy_ = dx_?.Value;
                CqlDate dz_ = context.Operators.ConvertStringToDate(dy_);
                object eb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object ec_ = context.Operators.LateBoundProperty<object>(eb_, "high");
                CqlDate ed_ = context.Operators.Add(dz_, ec_ as CqlQuantity);
                CqlDate ef_ = context.Operators.Add(ed_, dj_);
                CqlInterval<CqlDate> eg_ = context.Operators.Interval(dv_, ef_, true, false);
                CqlDate eh_ = eg_?.high;
                CqlDateTime ei_ = context.Operators.ConvertDateToDateTime(eh_);
                Date ek_ = ct_?.BirthDateElement;
                string el_ = ek_?.Value;
                CqlDate em_ = context.Operators.ConvertStringToDate(el_);
                object eo_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object ep_ = context.Operators.LateBoundProperty<object>(eo_, "low");
                CqlDate eq_ = context.Operators.Add(em_, ep_ as CqlQuantity);
                Date es_ = ct_?.BirthDateElement;
                string et_ = es_?.Value;
                CqlDate eu_ = context.Operators.ConvertStringToDate(et_);
                object ew_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object ex_ = context.Operators.LateBoundProperty<object>(ew_, "high");
                CqlDate ey_ = context.Operators.Add(eu_, ex_ as CqlQuantity);
                CqlDate fa_ = context.Operators.Add(ey_, dj_);
                CqlInterval<CqlDate> fb_ = context.Operators.Interval(eq_, fa_, true, false);
                bool? fc_ = fb_?.lowClosed;
                Date fe_ = ct_?.BirthDateElement;
                string ff_ = fe_?.Value;
                CqlDate fg_ = context.Operators.ConvertStringToDate(ff_);
                object fi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object fj_ = context.Operators.LateBoundProperty<object>(fi_, "low");
                CqlDate fk_ = context.Operators.Add(fg_, fj_ as CqlQuantity);
                Date fm_ = ct_?.BirthDateElement;
                string fn_ = fm_?.Value;
                CqlDate fo_ = context.Operators.ConvertStringToDate(fn_);
                object fq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cx_);
                object fr_ = context.Operators.LateBoundProperty<object>(fq_, "high");
                CqlDate fs_ = context.Operators.Add(fo_, fr_ as CqlQuantity);
                CqlDate fu_ = context.Operators.Add(fs_, dj_);
                CqlInterval<CqlDate> fv_ = context.Operators.Interval(fk_, fu_, true, false);
                bool? fw_ = fv_?.highClosed;
                CqlInterval<CqlDateTime> fx_ = context.Operators.Interval(dn_, ei_, fc_, fw_);

                return fx_;
            }
            else if (e_())
            {
                DataType fy_ = condition?.Abatement;
                object fz_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fy_);
                object ga_ = context.Operators.LateBoundProperty<object>(fz_, "low");
                object gc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fy_);
                object gd_ = context.Operators.LateBoundProperty<object>(gc_, "high");
                CqlInterval<CqlDateTime> ge_ = context.Operators.Interval(ga_ as CqlDateTime, gd_ as CqlDateTime, true, false);

                return ge_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return a_();
    }

    public CqlInterval<CqlDateTime> ToPrevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> a_()
        {
            bool b_()
            {
                CodeableConcept c_ = condition?.ClinicalStatus;
                CqlConcept d_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, c_);
                CqlCode e_ = this.active(context);
                CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
                bool? g_ = context.Operators.Equivalent(d_, f_);
                CqlConcept i_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, c_);
                CqlCode j_ = this.recurrence(context);
                CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
                bool? l_ = context.Operators.Equivalent(i_, k_);
                bool? m_ = context.Operators.Or(g_, l_);
                CqlConcept o_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, c_);
                CqlCode p_ = this.relapse(context);
                CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                bool? r_ = context.Operators.Equivalent(o_, q_);
                bool? s_ = context.Operators.Or(m_, r_);

                return s_ ?? false;
            };
            if (b_())
            {
                DataType t_ = condition?.Onset;
                object u_ = FHIRHelpers_4_3_000.Instance.ToValue(context, t_);
                CqlInterval<CqlDateTime> v_ = this.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlInterval<CqlDateTime> x_ = this.ToAbatementInterval(context, condition);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, true, true);

                return z_;
            }
            else
            {
                CqlInterval<CqlDateTime> aa_ = this.ToAbatementInterval(context, condition);
                CqlDateTime ab_ = context.Operators.End(aa_);
                CqlDateTime[] ac_ = [
                    ab_,
                ];
                CqlInterval<CqlDateTime> ad_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> ag_()
                    {
                        if (abatementDate is null)
                        {
                            DataType ah_ = condition?.Onset;
                            object ai_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ah_);
                            CqlInterval<CqlDateTime> aj_ = this.ToInterval(context, ai_);
                            CqlDateTime ak_ = context.Operators.Start(aj_);
                            CqlInterval<CqlDateTime> al_ = context.Operators.Interval(ak_, abatementDate, true, false);

                            return al_;
                        }
                        else
                        {
                            DataType am_ = condition?.Onset;
                            object an_ = FHIRHelpers_4_3_000.Instance.ToValue(context, am_);
                            CqlInterval<CqlDateTime> ao_ = this.ToInterval(context, an_);
                            CqlDateTime ap_ = context.Operators.Start(ao_);
                            CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(ap_, abatementDate, true, true);

                            return aq_;
                        }
                    };

                    return ag_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> ae_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)ac_, ad_);
                CqlInterval<CqlDateTime> af_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(ae_);

                return af_;
            }
        };

        return a_();
    }

    public CqlInterval<CqlDateTime> prevalenceInterval(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> a_()
        {
            bool b_()
            {
                CodeableConcept c_ = condition?.ClinicalStatus;
                CqlConcept d_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, c_);
                CqlCode e_ = this.active(context);
                CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
                bool? g_ = context.Operators.Equivalent(d_, f_);
                CqlConcept i_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, c_);
                CqlCode j_ = this.recurrence(context);
                CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
                bool? l_ = context.Operators.Equivalent(i_, k_);
                bool? m_ = context.Operators.Or(g_, l_);
                CqlConcept o_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, c_);
                CqlCode p_ = this.relapse(context);
                CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                bool? r_ = context.Operators.Equivalent(o_, q_);
                bool? s_ = context.Operators.Or(m_, r_);

                return s_ ?? false;
            };
            if (b_())
            {
                DataType t_ = condition?.Onset;
                object u_ = FHIRHelpers_4_3_000.Instance.ToValue(context, t_);
                CqlInterval<CqlDateTime> v_ = this.toInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlInterval<CqlDateTime> x_ = this.abatementInterval(context, condition);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, true, true);

                return z_;
            }
            else
            {
                CqlInterval<CqlDateTime> aa_ = this.ToAbatementInterval(context, condition);
                CqlDateTime ab_ = context.Operators.End(aa_);
                CqlDateTime[] ac_ = [
                    ab_,
                ];
                CqlInterval<CqlDateTime> ad_(CqlDateTime abatementDate)
                {
                    CqlInterval<CqlDateTime> ag_()
                    {
                        if (abatementDate is null)
                        {
                            DataType ah_ = condition?.Onset;
                            object ai_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ah_);
                            CqlInterval<CqlDateTime> aj_ = this.ToInterval(context, ai_);
                            CqlDateTime ak_ = context.Operators.Start(aj_);
                            CqlInterval<CqlDateTime> al_ = context.Operators.Interval(ak_, abatementDate, true, false);

                            return al_;
                        }
                        else
                        {
                            DataType am_ = condition?.Onset;
                            object an_ = FHIRHelpers_4_3_000.Instance.ToValue(context, am_);
                            CqlInterval<CqlDateTime> ao_ = this.ToInterval(context, an_);
                            CqlDateTime ap_ = context.Operators.Start(ao_);
                            CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(ap_, abatementDate, true, true);

                            return aq_;
                        }
                    };

                    return ag_();
                };
                IEnumerable<CqlInterval<CqlDateTime>> ae_ = context.Operators.Select<CqlDateTime, CqlInterval<CqlDateTime>>((IEnumerable<CqlDateTime>)ac_, ad_);
                CqlInterval<CqlDateTime> af_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(ae_);

                return af_;
            }
        };

        return a_();
    }

    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> a_ = context.Operators.Split(uri, "/");
        string b_ = context.Operators.Last<string>(a_);

        return b_;
    }

    public string getId(CqlContext context, string uri)
    {
        IEnumerable<string> a_ = context.Operators.Split(uri, "/");
        string b_ = context.Operators.Last<string>(a_);

        return b_;
    }

    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.Start(period);
        CqlDateTime c_ = context.Operators.MinValue<CqlDateTime>();
        bool? d_ = context.Operators.Equal(a_, c_);
        bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
        bool? f_ = context.Operators.Not(e_);

        return f_;
    }

    public bool? hasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.Start(period);
        CqlDateTime c_ = context.Operators.MinValue<CqlDateTime>();
        bool? d_ = context.Operators.Equal(a_, c_);
        bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
        bool? f_ = context.Operators.Not(e_);

        return f_;
    }

    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.End(period);
        CqlDateTime c_ = context.Operators.MaxValue<CqlDateTime>();
        bool? d_ = context.Operators.Equal(a_, c_);
        bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
        bool? f_ = context.Operators.Not(e_);

        return f_;
    }

    public bool? hasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.End(period);
        CqlDateTime c_ = context.Operators.MaxValue<CqlDateTime>();
        bool? d_ = context.Operators.Equal(a_, c_);
        bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
        bool? f_ = context.Operators.Not(e_);

        return f_;
    }

    public CqlDateTime Latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] b_ = [
            a_,
        ];
        CqlDateTime c_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime f_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime g_ = context.Operators.End(period);

                    return g_;
                }
                else
                {
                    CqlDateTime h_ = context.Operators.Start(period);

                    return h_;
                }
            };

            return f_();
        };
        IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

        return e_;
    }

    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] b_ = [
            a_,
        ];
        CqlDateTime c_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime f_()
            {
                if ((this.hasEnd(context, period)) ?? false)
                {
                    CqlDateTime g_ = context.Operators.End(period);

                    return g_;
                }
                else
                {
                    CqlDateTime h_ = context.Operators.Start(period);

                    return h_;
                }
            };

            return f_();
        };
        IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

        return e_;
    }

    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] b_ = [
            a_,
        ];
        CqlDateTime c_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime f_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime g_ = context.Operators.Start(period);

                    return g_;
                }
                else
                {
                    CqlDateTime h_ = context.Operators.End(period);

                    return h_;
                }
            };

            return f_();
        };
        IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

        return e_;
    }

    public CqlDateTime earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_ = this.toInterval(context, choice);
        CqlInterval<CqlDateTime>[] b_ = [
            a_,
        ];
        CqlDateTime c_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime f_()
            {
                if ((this.hasStart(context, period)) ?? false)
                {
                    CqlDateTime g_ = context.Operators.Start(period);

                    return g_;
                }
                else
                {
                    CqlDateTime h_ = context.Operators.End(period);

                    return h_;
                }
            };

            return f_();
        };
        IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

        return e_;
    }

    public IEnumerable<int?> Interval_To_Day_Numbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime a_ = context.Operators.Start(Period);
        CqlDateTime b_ = context.Operators.End(Period);
        int? c_ = context.Operators.DurationBetween(a_, b_, "day");
        CqlInterval<int?> d_ = context.Operators.Interval(1, c_, true, true);
        CqlInterval<int?>[] e_ = [
            d_,
        ];
        IEnumerable<CqlInterval<int?>> f_ = context.Operators.Expand(e_ as IEnumerable<CqlInterval<int?>>, default);
        int? g_(CqlInterval<int?> DayNumber)
        {
            int? i_ = context.Operators.End(DayNumber);

            return i_;
        };
        IEnumerable<int?> h_ = context.Operators.Select<CqlInterval<int?>, int?>(f_, g_);

        return h_;
    }

    public IEnumerable<int?> toDayNumbers(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime a_ = context.Operators.Start(Period);
        CqlDateTime b_ = context.Operators.End(Period);
        int? c_ = context.Operators.DurationBetween(a_, b_, "day");
        CqlInterval<int?> d_ = context.Operators.Interval(1, c_, true, true);
        CqlInterval<int?>[] e_ = [
            d_,
        ];
        IEnumerable<CqlInterval<int?>> f_ = context.Operators.Expand(e_ as IEnumerable<CqlInterval<int?>>, default);
        int? g_(CqlInterval<int?> DayNumber)
        {
            int? i_ = context.Operators.End(DayNumber);

            return i_;
        };
        IEnumerable<int?> h_ = context.Operators.Select<CqlInterval<int?>, int?>(f_, g_);

        return h_;
    }

    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> Days_In_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> a_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? b_(int? DayIndex)
        {
            CqlDateTime d_ = context.Operators.Start(Period);
            CqlQuantity e_ = context.Operators.Quantity(24m, "hours");
            int? f_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity g_ = context.Operators.ConvertIntegerToQuantity(f_);
            CqlQuantity h_ = context.Operators.Multiply(e_, g_);
            CqlDateTime i_ = context.Operators.Add(d_, h_);
            CqlDateTime j_()
            {
                bool m_()
                {
                    CqlDateTime n_ = context.Operators.Start(Period);
                    CqlQuantity o_ = context.Operators.Quantity(24m, "hours");
                    int? p_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity q_ = context.Operators.ConvertIntegerToQuantity(p_);
                    CqlQuantity r_ = context.Operators.Multiply(o_, q_);
                    CqlDateTime s_ = context.Operators.Add(n_, r_);
                    CqlDateTime t_ = context.Operators.End(Period);
                    int? u_ = context.Operators.DurationBetween(s_, t_, "hour");
                    bool? v_ = context.Operators.Less(u_, 24);

                    return v_ ?? false;
                };
                if (m_())
                {
                    CqlDateTime w_ = context.Operators.Start(Period);
                    CqlQuantity x_ = context.Operators.Quantity(24m, "hours");
                    int? y_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity z_ = context.Operators.ConvertIntegerToQuantity(y_);
                    CqlQuantity aa_ = context.Operators.Multiply(x_, z_);
                    CqlDateTime ab_ = context.Operators.Add(w_, aa_);

                    return ab_;
                }
                else
                {
                    CqlDateTime ac_ = context.Operators.Start(Period);
                    CqlQuantity ad_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity ae_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity af_ = context.Operators.Multiply(ad_, ae_);
                    CqlDateTime ag_ = context.Operators.Add(ac_, af_);

                    return ag_;
                }
            };
            CqlInterval<CqlDateTime> k_ = context.Operators.Interval(i_, j_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? l_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, k_);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> c_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(a_, b_);

        return c_;
    }

    public IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> daysInPeriod(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        IEnumerable<int?> a_ = this.Interval_To_Day_Numbers(context, Period);
        (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? b_(int? DayIndex)
        {
            CqlDateTime d_ = context.Operators.Start(Period);
            CqlQuantity e_ = context.Operators.Quantity(24m, "hours");
            int? f_ = context.Operators.Subtract(DayIndex, 1);
            CqlQuantity g_ = context.Operators.ConvertIntegerToQuantity(f_);
            CqlQuantity h_ = context.Operators.Multiply(e_, g_);
            CqlDateTime i_ = context.Operators.Add(d_, h_);
            CqlDateTime j_()
            {
                bool m_()
                {
                    CqlDateTime n_ = context.Operators.Start(Period);
                    CqlQuantity o_ = context.Operators.Quantity(24m, "hours");
                    int? p_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity q_ = context.Operators.ConvertIntegerToQuantity(p_);
                    CqlQuantity r_ = context.Operators.Multiply(o_, q_);
                    CqlDateTime s_ = context.Operators.Add(n_, r_);
                    CqlDateTime t_ = context.Operators.End(Period);
                    int? u_ = context.Operators.DurationBetween(s_, t_, "hour");
                    bool? v_ = context.Operators.Less(u_, 24);

                    return v_ ?? false;
                };
                if (m_())
                {
                    CqlDateTime w_ = context.Operators.Start(Period);
                    CqlQuantity x_ = context.Operators.Quantity(24m, "hours");
                    int? y_ = context.Operators.Subtract(DayIndex, 1);
                    CqlQuantity z_ = context.Operators.ConvertIntegerToQuantity(y_);
                    CqlQuantity aa_ = context.Operators.Multiply(x_, z_);
                    CqlDateTime ab_ = context.Operators.Add(w_, aa_);

                    return ab_;
                }
                else
                {
                    CqlDateTime ac_ = context.Operators.Start(Period);
                    CqlQuantity ad_ = context.Operators.Quantity(24m, "hours");
                    CqlQuantity ae_ = context.Operators.ConvertIntegerToQuantity(DayIndex);
                    CqlQuantity af_ = context.Operators.Multiply(ad_, ae_);
                    CqlDateTime ag_ = context.Operators.Add(ac_, af_);

                    return ag_;
                }
            };
            CqlInterval<CqlDateTime> k_ = context.Operators.Interval(i_, j_(), true, false);
            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? l_ = (CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie, DayIndex, k_);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> c_ = context.Operators.Select<int?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>(a_, b_);

        return c_;
    }

    private static CqlTupleMetadata CqlTupleMetadata_ddJhZGNHefSCOAJJFEIEcXie = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["dayIndex", "dayPeriod"]);

}

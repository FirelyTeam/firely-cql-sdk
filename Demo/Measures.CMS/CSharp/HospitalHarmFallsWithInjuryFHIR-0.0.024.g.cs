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
[CqlLibrary("HospitalHarmFallsWithInjuryFHIR", "0.0.024")]
public partial class HospitalHarmFallsWithInjuryFHIR_0_0_024 : ILibrary, ISingleton<HospitalHarmFallsWithInjuryFHIR_0_0_024>
{
    private HospitalHarmFallsWithInjuryFHIR_0_0_024() {}

    public static HospitalHarmFallsWithInjuryFHIR_0_0_024 Instance { get; } = new();

    #region ILibrary Members
    string ILibrary.Name => "HospitalHarmFallsWithInjuryFHIR";
    string ILibrary.Version => "0.0.024";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, CQMCommon_2_2_000.Instance, CumulativeMedicationDuration_4_1_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Abnormal Weight Loss and Malnutrition")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.177")]
    public CqlValueSet Abnormal_Weight_Loss_and_Malnutrition(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.177", default);


    [CqlDeclaration("Anticoagulants for All Indications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.22")]
    public CqlValueSet Anticoagulants_for_All_Indications(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.22", default);


    [CqlDeclaration("Antidepressants")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.163")]
    public CqlValueSet Antidepressants(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.163", default);


    [CqlDeclaration("Antihypertensives")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.164")]
    public CqlValueSet Antihypertensives(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.164", default);


    [CqlDeclaration("Central Nervous System Depressants")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.134")]
    public CqlValueSet Central_Nervous_System_Depressants(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.134", default);


    [CqlDeclaration("Coagulation Disorders")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.23")]
    public CqlValueSet Coagulation_Disorders(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.23", default);


    [CqlDeclaration("Delirium, Dementia, and Other Psychoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.168")]
    public CqlValueSet Delirium__Dementia__and_Other_Psychoses(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.168", default);


    [CqlDeclaration("Depression")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.169")]
    public CqlValueSet Depression(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.169", default);


    [CqlDeclaration("Diuretics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.170")]
    public CqlValueSet Diuretics(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.170", default);


    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);


    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);


    [CqlDeclaration("Epilepsy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.171")]
    public CqlValueSet Epilepsy(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.171", default);


    [CqlDeclaration("Inpatient Falls")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.171")]
    public CqlValueSet Inpatient_Falls(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.171", default);


    [CqlDeclaration("Leukemia or Lymphoma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.136")]
    public CqlValueSet Leukemia_or_Lymphoma(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.136", default);


    [CqlDeclaration("Liver Disease Moderate to Severe")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.137")]
    public CqlValueSet Liver_Disease_Moderate_to_Severe(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.137", default);


    [CqlDeclaration("Major Injuries")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.174")]
    public CqlValueSet Major_Injuries(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.174", default);


    [CqlDeclaration("Malignant Bone Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.24")]
    public CqlValueSet Malignant_Bone_Disease(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.24", default);


    [CqlDeclaration("Moderate Injuries")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.205")]
    public CqlValueSet Moderate_Injuries(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.205", default);


    [CqlDeclaration("Neurologic Movement and Related Disorders")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.174")]
    public CqlValueSet Neurologic_Movement_and_Related_Disorders(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.174", default);


    [CqlDeclaration("Not Present On Admission or Documentation Insufficient to Determine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198")]
    public CqlValueSet Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", default);


    [CqlDeclaration("Obesity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.162")]
    public CqlValueSet Obesity(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.162", default);


    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);


    [CqlDeclaration("Opioids")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.120")]
    public CqlValueSet Opioids(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.120", default);


    [CqlDeclaration("Osteoporosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1200.147")]
    public CqlValueSet Osteoporosis(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1200.147", default);


    [CqlDeclaration("Peripheral Neuropathy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.175")]
    public CqlValueSet Peripheral_Neuropathy(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.175", default);


    [CqlDeclaration("Present on Admission or Clinically Undetermined")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197")]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", default);


    [CqlDeclaration("Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.176")]
    public CqlValueSet Stroke(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.176", default);


    [CqlDeclaration("Suicide Attempt")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.130")]
    public CqlValueSet Suicide_Attempt(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.130", default);


    [CqlDeclaration("Body mass index (BMI) [Ratio]")]
    public CqlCode Body_mass_index__BMI___Ratio_(CqlContext context) =>
        new CqlCode("39156-5", "http://loinc.org", default, default);


    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("39156-5", "http://loinc.org", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("HospitalHarmFallsWithInjuryFHIR-0.0.024", "Measurement Period", c_);

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
        IEnumerable<Encounter> a_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDate g_ = context.Operators.ConvertStringToDate(f_);
            Period h_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
            bool? m_ = context.Operators.GreaterOrEqual(l_, 18);

            return m_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        return a_;
    }


    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Encounter with a Fall Not Present on Admission")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Not_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Inpatient_Falls(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Encounter with a Fall Event")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Event(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> b_(Encounter InpatientEncounter)
        {
            CqlValueSet d_ = this.Inpatient_Falls(context);
            IEnumerable<AdverseEvent> e_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
            bool? f_(AdverseEvent FallsDocumentation)
            {
                FhirDateTime j_ = FallsDocumentation?.DateElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                FhirDateTime l_ = FallsDocumentation?.RecordedDateElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlInterval<CqlDateTime> n_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? o_ = context.Operators.In<CqlDateTime>(k_ ?? m_, n_, default);

                return o_;
            };
            IEnumerable<AdverseEvent> g_ = context.Operators.Where<AdverseEvent>(e_, f_);
            Encounter h_(AdverseEvent FallsDocumentation) =>
                InpatientEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<AdverseEvent, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Encounter where a Fall Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_a_Fall_Not_Present_on_Admission(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_a_Fall_Event(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Encounter where a Fall and Major Injury Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_and_Major_Injury_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_where_a_Fall_Occurred(context);
        bool? b_(Encounter FallOccurred)
        {
            List<Encounter.DiagnosisComponent> d_ = FallOccurred?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Major_Injuries(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string ad_ = @this?.Url;
                    FhirString ae_ = context.Operators.Convert<FhirString>(ad_);
                    string af_ = FHIRHelpers_4_4_000.Instance.ToString(context, ae_);
                    bool? ag_ = context.Operators.Equal(af_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return ag_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType ah_ = @this?.Value;

                    return ah_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_(Extension @this)
                {
                    string ai_ = @this?.Url;
                    FhirString aj_ = context.Operators.Convert<FhirString>(ai_);
                    string ak_ = FHIRHelpers_4_4_000.Instance.ToString(context, aj_);
                    bool? al_ = context.Operators.Equal(ak_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return al_;
                };
                IEnumerable<Extension> w_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), v_);
                object x_(Extension @this)
                {
                    DataType am_ = @this?.Value;

                    return am_;
                };
                IEnumerable<object> y_ = context.Operators.Select<Extension, object>(w_, x_);
                object z_ = context.Operators.SingletonFrom<object>(y_);
                CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_ as CodeableConcept);
                bool? ab_ = context.Operators.Or(u_, (bool?)(aa_ is null));
                bool? ac_ = context.Operators.And(m_, ab_);

                return ac_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Encounter with a Fall Present on Admission")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Inpatient_Falls(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable All Encounter Diagnoses with Rank and POA Indication")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? b_(Encounter InpatientEncounter)
        {
            Id e_ = InpatientEncounter?.IdElement;
            string f_ = e_?.Value;
            List<Encounter.DiagnosisComponent> g_ = InpatientEncounter?.Diagnosis;
            bool? h_(Encounter.DiagnosisComponent @this)
            {
                ResourceReference u_ = @this?.Condition;
                bool? v_ = context.Operators.Not((bool?)(u_ is null));

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> i_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)g_, h_);
            ResourceReference j_(Encounter.DiagnosisComponent @this)
            {
                ResourceReference w_ = @this?.Condition;

                return w_;
            };
            IEnumerable<ResourceReference> k_ = context.Operators.Select<Encounter.DiagnosisComponent, ResourceReference>(i_, j_);
            bool? m_(Encounter.DiagnosisComponent @this)
            {
                PositiveInt x_ = @this?.RankElement;
                int? y_ = x_?.Value;
                bool? z_ = context.Operators.Not((bool?)(y_ is null));

                return z_;
            };
            IEnumerable<Encounter.DiagnosisComponent> n_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)g_, m_);
            int? o_(Encounter.DiagnosisComponent @this)
            {
                PositiveInt aa_ = @this?.RankElement;
                int? ab_ = aa_?.Value;

                return ab_;
            };
            IEnumerable<int?> p_ = context.Operators.Select<Encounter.DiagnosisComponent, int?>(n_, o_);
            bool? r_(Encounter.DiagnosisComponent Dx)
            {
                bool? ac_(Extension @this)
                {
                    string ak_ = @this?.Url;
                    FhirString al_ = context.Operators.Convert<FhirString>(ak_);
                    string am_ = FHIRHelpers_4_4_000.Instance.ToString(context, al_);
                    bool? an_ = context.Operators.Equal(am_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return an_;
                };
                IEnumerable<Extension> ad_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), ac_);
                object ae_(Extension @this)
                {
                    DataType ao_ = @this?.Value;

                    return ao_;
                };
                IEnumerable<object> af_ = context.Operators.Select<Extension, object>(ad_, ae_);
                object ag_ = context.Operators.SingletonFrom<object>(af_);
                CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ag_ as CodeableConcept);
                CqlValueSet ai_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? aj_ = context.Operators.ConceptInValueSet(ah_, ai_);

                return aj_;
            };
            IEnumerable<Encounter.DiagnosisComponent> s_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)g_, r_);
            (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? t_ = (CqlTupleMetadata_CCJaUjRHWSXeUTcFAfVeVeNaD, f_, k_, p_, s_);

            return t_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>(c_);

        return d_;
    }


    [CqlDeclaration("Risk Variable All Encounter Principal Diagnoses")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> Risk_Variable_All_Encounter_Principal_Diagnoses(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, Encounter encounter, CqlConcept condition)? b_(Encounter InpatientEncounter)
        {
            Condition e_ = CQMCommon_2_2_000.Instance.PrincipalDiagnosis(context, InpatientEncounter);
            CodeableConcept f_ = e_?.Code;
            CqlConcept g_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, f_);
            (CqlTupleMetadata, Encounter encounter, CqlConcept condition)? h_ = (CqlTupleMetadata_CajFQjTXAXITWGJPNIjCafPiF, InpatientEncounter, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlConcept condition)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?>(c_);

        return d_;
    }


    [CqlDeclaration("Risk Variable Body Mass Index (BMI)")]
    public IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI_(CqlContext context)
    {
        CqlCode a_ = this.Body_mass_index__BMI___Ratio_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_(Observation BMI)
        {
            IEnumerable<Encounter> i_ = this.Qualifying_Encounter(context);
            bool? j_(Encounter InpatientEncounter)
            {
                DataType n_ = BMI?.Effective;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.ToInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlInterval<CqlDateTime> r_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, default);
                DataType t_ = BMI?.Value;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                bool? v_ = context.Operators.Not((bool?)(u_ is null));
                bool? w_ = context.Operators.And(s_, v_);
                Code<ObservationStatus> x_ = BMI?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                Code<ObservationStatus> z_ = context.Operators.Convert<Code<ObservationStatus>>(y_);
                string aa_ = context.Operators.Convert<string>(z_);
                string[] ab_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ac_ = context.Operators.In<string>(aa_, ab_ as IEnumerable<string>);
                bool? ad_ = context.Operators.And(w_, ac_);

                return ad_;
            };
            IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
            Observation l_(Encounter InpatientEncounter) =>
                BMI;
            IEnumerable<Observation> m_ = context.Operators.Select<Encounter, Observation>(k_, l_);

            return m_;
        };
        IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);
        CqlQuantity f_(Observation BMI)
        {
            DataType ae_ = BMI?.Value;
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);

            return af_ as CqlQuantity;
        };
        IEnumerable<CqlQuantity> g_ = context.Operators.Select<Observation, CqlQuantity>(e_, f_);
        IEnumerable<CqlQuantity> h_ = context.Operators.Distinct<CqlQuantity>(g_);

        return h_;
    }


    [CqlDeclaration("Risk Variable Encounter with Abnormal Weight Loss or Malnutrition Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Abnormal_Weight_Loss_or_Malnutrition_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Abnormal_Weight_Loss_and_Malnutrition(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Anticoagulant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> b_(Encounter InpatientEncounter)
        {
            CqlValueSet d_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
            bool? i_(MedicationRequest Anticoagulants)
            {
                Code<MedicationRequest.MedicationrequestStatus> m_ = Anticoagulants?.StatusElement;
                MedicationRequest.MedicationrequestStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                bool? p_ = context.Operators.Equal(o_, "active");
                Code<MedicationRequest.MedicationRequestIntent> q_ = Anticoagulants?.IntentElement;
                MedicationRequest.MedicationRequestIntent? r_ = q_?.Value;
                string s_ = context.Operators.Convert<string>(r_);
                bool? t_ = context.Operators.Equal(s_, "order");
                MedicationRequest.MedicationRequestIntent? v_ = q_?.Value;
                string w_ = context.Operators.Convert<string>(v_);
                bool? x_ = context.Operators.Equal(w_, "plan");
                DataType y_ = Anticoagulants?.Reported;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                object aa_ = context.Operators.LateBoundProperty<object>(z_, "reference");
                string ab_ = context.Operators.LateBoundProperty<string>(aa_, "value");
                string ac_ = QICoreCommon_2_1_000.Instance.getId(context, ab_);
                Id ad_()
                {
                    bool ba_()
                    {
                        Patient bb_ = this.Patient(context);
                        bool bc_ = bb_ is Resource;

                        return bc_;
                    };
                    if (ba_())
                    {
                        Patient bd_ = this.Patient(context);

                        return (bd_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string ae_ = (ad_())?.Value;
                bool? af_ = context.Operators.Equal(ac_, ae_);
                bool? ag_ = context.Operators.And(x_, af_);
                bool? ah_ = context.Operators.Or(t_, ag_);
                bool? ai_ = context.Operators.And(p_, ah_);
                bool? aj_ = QICoreCommon_2_1_000.Instance.isCommunity(context, Anticoagulants);
                bool? ak_ = context.Operators.And(ai_, aj_);
                CqlInterval<CqlDate> al_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, Anticoagulants);
                CqlDate am_ = al_?.low;
                CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
                CqlDate ap_ = al_?.high;
                CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
                bool? as_ = al_?.lowClosed;
                bool? au_ = al_?.highClosed;
                CqlInterval<CqlDateTime> av_ = context.Operators.Interval(an_, aq_, as_, au_);
                Period aw_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                bool? ay_ = context.Operators.OverlapsBefore(av_, ax_, default);
                bool? az_ = context.Operators.And(ak_, ay_);

                return az_;
            };
            IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
            Encounter k_(MedicationRequest Anticoagulants) =>
                InpatientEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<MedicationRequest, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Anticoagulant Administration During Encounter")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Administration_During_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> b_(Encounter InpatientEncounter)
        {
            CqlValueSet d_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> g_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> h_ = context.Operators.Union<MedicationAdministration>(e_, g_);
            bool? i_(MedicationAdministration Anticoagulants)
            {
                DataType m_ = Anticoagulants?.Effective;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlInterval<CqlDateTime> q_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, default);
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> s_ = Anticoagulants?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? t_ = s_?.Value;
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> u_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(t_);
                string v_ = context.Operators.Convert<string>(u_);
                string[] w_ = [
                    "in-progress",
                    "completed",
                ];
                bool? x_ = context.Operators.In<string>(v_, w_ as IEnumerable<string>);
                bool? y_ = context.Operators.And(r_, x_);

                return y_;
            };
            IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(h_, i_);
            Encounter k_(MedicationAdministration Anticoagulants) =>
                InpatientEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<MedicationAdministration, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Antidepressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antidepressant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> b_(Encounter InpatientEncounter)
        {
            CqlValueSet d_ = this.Antidepressants(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
            bool? i_(MedicationRequest AntidepressantMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> m_ = AntidepressantMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                bool? p_ = context.Operators.Equal(o_, "active");
                Code<MedicationRequest.MedicationRequestIntent> q_ = AntidepressantMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? r_ = q_?.Value;
                string s_ = context.Operators.Convert<string>(r_);
                bool? t_ = context.Operators.Equal(s_, "order");
                MedicationRequest.MedicationRequestIntent? v_ = q_?.Value;
                string w_ = context.Operators.Convert<string>(v_);
                bool? x_ = context.Operators.Equal(w_, "plan");
                DataType y_ = AntidepressantMed?.Reported;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                object aa_ = context.Operators.LateBoundProperty<object>(z_, "reference");
                string ab_ = context.Operators.LateBoundProperty<string>(aa_, "value");
                string ac_ = QICoreCommon_2_1_000.Instance.getId(context, ab_);
                Id ad_()
                {
                    bool ba_()
                    {
                        Patient bb_ = this.Patient(context);
                        bool bc_ = bb_ is Resource;

                        return bc_;
                    };
                    if (ba_())
                    {
                        Patient bd_ = this.Patient(context);

                        return (bd_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string ae_ = (ad_())?.Value;
                bool? af_ = context.Operators.Equal(ac_, ae_);
                bool? ag_ = context.Operators.And(x_, af_);
                bool? ah_ = context.Operators.Or(t_, ag_);
                bool? ai_ = context.Operators.And(p_, ah_);
                bool? aj_ = QICoreCommon_2_1_000.Instance.isCommunity(context, AntidepressantMed);
                bool? ak_ = context.Operators.And(ai_, aj_);
                CqlInterval<CqlDate> al_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, AntidepressantMed);
                CqlDate am_ = al_?.low;
                CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
                CqlDate ap_ = al_?.high;
                CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
                bool? as_ = al_?.lowClosed;
                bool? au_ = al_?.highClosed;
                CqlInterval<CqlDateTime> av_ = context.Operators.Interval(an_, aq_, as_, au_);
                Period aw_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                bool? ay_ = context.Operators.OverlapsBefore(av_, ax_, default);
                bool? az_ = context.Operators.And(ak_, ay_);

                return az_;
            };
            IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
            Encounter k_(MedicationRequest AntidepressantMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<MedicationRequest, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Antihypertensive Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antihypertensive_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> b_(Encounter InpatientEncounter)
        {
            CqlValueSet d_ = this.Antihypertensives(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
            bool? i_(MedicationRequest BPMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> m_ = BPMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                bool? p_ = context.Operators.Equal(o_, "active");
                Code<MedicationRequest.MedicationRequestIntent> q_ = BPMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? r_ = q_?.Value;
                string s_ = context.Operators.Convert<string>(r_);
                bool? t_ = context.Operators.Equal(s_, "order");
                MedicationRequest.MedicationRequestIntent? v_ = q_?.Value;
                string w_ = context.Operators.Convert<string>(v_);
                bool? x_ = context.Operators.Equal(w_, "plan");
                DataType y_ = BPMed?.Reported;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                object aa_ = context.Operators.LateBoundProperty<object>(z_, "reference");
                string ab_ = context.Operators.LateBoundProperty<string>(aa_, "value");
                string ac_ = QICoreCommon_2_1_000.Instance.getId(context, ab_);
                Id ad_()
                {
                    bool ba_()
                    {
                        Patient bb_ = this.Patient(context);
                        bool bc_ = bb_ is Resource;

                        return bc_;
                    };
                    if (ba_())
                    {
                        Patient bd_ = this.Patient(context);

                        return (bd_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string ae_ = (ad_())?.Value;
                bool? af_ = context.Operators.Equal(ac_, ae_);
                bool? ag_ = context.Operators.And(x_, af_);
                bool? ah_ = context.Operators.Or(t_, ag_);
                bool? ai_ = context.Operators.And(p_, ah_);
                bool? aj_ = QICoreCommon_2_1_000.Instance.isCommunity(context, BPMed);
                bool? ak_ = context.Operators.And(ai_, aj_);
                CqlInterval<CqlDate> al_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, BPMed);
                CqlDate am_ = al_?.low;
                CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
                CqlDate ap_ = al_?.high;
                CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
                bool? as_ = al_?.lowClosed;
                bool? au_ = al_?.highClosed;
                CqlInterval<CqlDateTime> av_ = context.Operators.Interval(an_, aq_, as_, au_);
                Period aw_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                bool? ay_ = context.Operators.OverlapsBefore(av_, ax_, default);
                bool? az_ = context.Operators.And(ak_, ay_);

                return az_;
            };
            IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
            Encounter k_(MedicationRequest BPMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<MedicationRequest, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with CNS Depressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_CNS_Depressant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> b_(Encounter InpatientEncounter)
        {
            CqlValueSet d_ = this.Central_Nervous_System_Depressants(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
            bool? i_(MedicationRequest CNSMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> m_ = CNSMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                bool? p_ = context.Operators.Equal(o_, "active");
                Code<MedicationRequest.MedicationRequestIntent> q_ = CNSMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? r_ = q_?.Value;
                string s_ = context.Operators.Convert<string>(r_);
                bool? t_ = context.Operators.Equal(s_, "order");
                MedicationRequest.MedicationRequestIntent? v_ = q_?.Value;
                string w_ = context.Operators.Convert<string>(v_);
                bool? x_ = context.Operators.Equal(w_, "plan");
                DataType y_ = CNSMed?.Reported;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                object aa_ = context.Operators.LateBoundProperty<object>(z_, "reference");
                string ab_ = context.Operators.LateBoundProperty<string>(aa_, "value");
                string ac_ = QICoreCommon_2_1_000.Instance.getId(context, ab_);
                Id ad_()
                {
                    bool ba_()
                    {
                        Patient bb_ = this.Patient(context);
                        bool bc_ = bb_ is Resource;

                        return bc_;
                    };
                    if (ba_())
                    {
                        Patient bd_ = this.Patient(context);

                        return (bd_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string ae_ = (ad_())?.Value;
                bool? af_ = context.Operators.Equal(ac_, ae_);
                bool? ag_ = context.Operators.And(x_, af_);
                bool? ah_ = context.Operators.Or(t_, ag_);
                bool? ai_ = context.Operators.And(p_, ah_);
                bool? aj_ = QICoreCommon_2_1_000.Instance.isCommunity(context, CNSMed);
                bool? ak_ = context.Operators.And(ai_, aj_);
                CqlInterval<CqlDate> al_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, CNSMed);
                CqlDate am_ = al_?.low;
                CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
                CqlDate ap_ = al_?.high;
                CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
                bool? as_ = al_?.lowClosed;
                bool? au_ = al_?.highClosed;
                CqlInterval<CqlDateTime> av_ = context.Operators.Interval(an_, aq_, as_, au_);
                Period aw_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                bool? ay_ = context.Operators.OverlapsBefore(av_, ax_, default);
                bool? az_ = context.Operators.And(ak_, ay_);

                return az_;
            };
            IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
            Encounter k_(MedicationRequest CNSMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<MedicationRequest, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Coagulation Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Coagulation_Disorder_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Coagulation_Disorders(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Delirium, Dementia or Other Psychosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Delirium__Dementia_or_Other_Psychosis_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Delirium__Dementia__and_Other_Psychoses(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Depression Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Depression_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Depression(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Diuretic Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Diuretic_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> b_(Encounter InpatientEncounter)
        {
            CqlValueSet d_ = this.Diuretics(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
            bool? i_(MedicationRequest DiureticMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> m_ = DiureticMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                bool? p_ = context.Operators.Equal(o_, "active");
                Code<MedicationRequest.MedicationRequestIntent> q_ = DiureticMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? r_ = q_?.Value;
                string s_ = context.Operators.Convert<string>(r_);
                bool? t_ = context.Operators.Equal(s_, "order");
                MedicationRequest.MedicationRequestIntent? v_ = q_?.Value;
                string w_ = context.Operators.Convert<string>(v_);
                bool? x_ = context.Operators.Equal(w_, "plan");
                DataType y_ = DiureticMed?.Reported;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                object aa_ = context.Operators.LateBoundProperty<object>(z_, "reference");
                string ab_ = context.Operators.LateBoundProperty<string>(aa_, "value");
                string ac_ = QICoreCommon_2_1_000.Instance.getId(context, ab_);
                Id ad_()
                {
                    bool ba_()
                    {
                        Patient bb_ = this.Patient(context);
                        bool bc_ = bb_ is Resource;

                        return bc_;
                    };
                    if (ba_())
                    {
                        Patient bd_ = this.Patient(context);

                        return (bd_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string ae_ = (ad_())?.Value;
                bool? af_ = context.Operators.Equal(ac_, ae_);
                bool? ag_ = context.Operators.And(x_, af_);
                bool? ah_ = context.Operators.Or(t_, ag_);
                bool? ai_ = context.Operators.And(p_, ah_);
                bool? aj_ = QICoreCommon_2_1_000.Instance.isCommunity(context, DiureticMed);
                bool? ak_ = context.Operators.And(ai_, aj_);
                CqlInterval<CqlDate> al_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, DiureticMed);
                CqlDate am_ = al_?.low;
                CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
                CqlDate ap_ = al_?.high;
                CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
                bool? as_ = al_?.lowClosed;
                bool? au_ = al_?.highClosed;
                CqlInterval<CqlDateTime> av_ = context.Operators.Interval(an_, aq_, as_, au_);
                Period aw_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                bool? ay_ = context.Operators.OverlapsBefore(av_, ax_, default);
                bool? az_ = context.Operators.And(ak_, ay_);

                return az_;
            };
            IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
            Encounter k_(MedicationRequest DiureticMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<MedicationRequest, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Epilepsy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Epilepsy_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Epilepsy(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with High BMI by Exam")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_High_BMI_by_Exam(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> b_(Encounter InpatientEncounter)
        {
            CqlCode d_ = this.Body_mass_index__BMI___Ratio_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? g_(Observation BMI)
            {
                DataType k_ = BMI?.Effective;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_2_1_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlInterval<CqlDateTime> o_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, default);
                DataType q_ = BMI?.Value;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlQuantity s_ = context.Operators.Quantity(25m, "kg/m2");
                bool? t_ = context.Operators.GreaterOrEqual(r_ as CqlQuantity, s_);
                bool? u_ = context.Operators.And(p_, t_);

                return u_;
            };
            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
            Encounter i_(Observation BMI) =>
                InpatientEncounter;
            IEnumerable<Encounter> j_ = context.Operators.Select<Observation, Encounter>(h_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Leukemia or Lymphoma Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Leukemia_or_Lymphoma_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Leukemia_or_Lymphoma(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Liver Disease Moderate to Severe Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Liver_Disease_Moderate_to_Severe_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Liver_Disease_Moderate_to_Severe(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Low BMI")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Low_BMI(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> b_(Encounter InpatientEncounter)
        {
            CqlCode d_ = this.Body_mass_index__BMI___Ratio_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? g_(Observation BMI)
            {
                DataType k_ = BMI?.Effective;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_2_1_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlInterval<CqlDateTime> o_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, default);
                DataType q_ = BMI?.Value;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlQuantity s_ = context.Operators.Quantity(18.5m, "kg/m2");
                bool? t_ = context.Operators.Less(r_ as CqlQuantity, s_);
                bool? u_ = context.Operators.And(p_, t_);

                return u_;
            };
            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
            Encounter i_(Observation BMI) =>
                InpatientEncounter;
            IEnumerable<Encounter> j_ = context.Operators.Select<Observation, Encounter>(h_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Malignant Bone Disease Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Malignant_Bone_Disease_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Malignant_Bone_Disease(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Neurologic Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Neurologic_Disorder_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Neurologic_Movement_and_Related_Disorders(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Obesity Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Obesity_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Obesity(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Opioid Medication Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Opioid_Medication_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> b_(Encounter InpatientEncounter)
        {
            CqlValueSet d_ = this.Opioids(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
            bool? i_(MedicationRequest OpioidMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> m_ = OpioidMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                bool? p_ = context.Operators.Equal(o_, "active");
                Code<MedicationRequest.MedicationRequestIntent> q_ = OpioidMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? r_ = q_?.Value;
                string s_ = context.Operators.Convert<string>(r_);
                bool? t_ = context.Operators.Equal(s_, "order");
                MedicationRequest.MedicationRequestIntent? v_ = q_?.Value;
                string w_ = context.Operators.Convert<string>(v_);
                bool? x_ = context.Operators.Equal(w_, "plan");
                DataType y_ = OpioidMed?.Reported;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                object aa_ = context.Operators.LateBoundProperty<object>(z_, "reference");
                string ab_ = context.Operators.LateBoundProperty<string>(aa_, "value");
                string ac_ = QICoreCommon_2_1_000.Instance.getId(context, ab_);
                Id ad_()
                {
                    bool ba_()
                    {
                        Patient bb_ = this.Patient(context);
                        bool bc_ = bb_ is Resource;

                        return bc_;
                    };
                    if (ba_())
                    {
                        Patient bd_ = this.Patient(context);

                        return (bd_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string ae_ = (ad_())?.Value;
                bool? af_ = context.Operators.Equal(ac_, ae_);
                bool? ag_ = context.Operators.And(x_, af_);
                bool? ah_ = context.Operators.Or(t_, ag_);
                bool? ai_ = context.Operators.And(p_, ah_);
                bool? aj_ = QICoreCommon_2_1_000.Instance.isCommunity(context, OpioidMed);
                bool? ak_ = context.Operators.And(ai_, aj_);
                CqlInterval<CqlDate> al_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, OpioidMed);
                CqlDate am_ = al_?.low;
                CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
                CqlDate ap_ = al_?.high;
                CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
                bool? as_ = al_?.lowClosed;
                bool? au_ = al_?.highClosed;
                CqlInterval<CqlDateTime> av_ = context.Operators.Interval(an_, aq_, as_, au_);
                Period aw_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                bool? ay_ = context.Operators.OverlapsBefore(av_, ax_, default);
                bool? az_ = context.Operators.And(ak_, ay_);

                return az_;
            };
            IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
            Encounter k_(MedicationRequest OpioidMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> l_ = context.Operators.Select<MedicationRequest, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Osteoporosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Osteoporosis_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Osteoporosis(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Peripheral Neuropathy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Peripheral_Neuropathy_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Peripheral_Neuropathy(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Stroke Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Stroke_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> d_ = InpatientEncounter?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Stroke(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string w_ = @this?.Url;
                    FhirString x_ = context.Operators.Convert<FhirString>(w_);
                    string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                    bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return z_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType aa_ = @this?.Value;

                    return aa_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(m_, u_);

                return v_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Risk Variable Encounter with Suicide Attempt")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Suicide_Attempt(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        bool? b_(Encounter InpatientEncounter)
        {
            IEnumerable<Condition> d_ = CQMCommon_2_2_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
            bool? e_(Condition @this)
            {
                CodeableConcept k_ = @this?.Code;
                CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
                bool? m_ = context.Operators.Not((bool?)(l_ is null));

                return m_;
            };
            IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
            CqlConcept g_(Condition @this)
            {
                CodeableConcept n_ = @this?.Code;
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);

                return o_;
            };
            IEnumerable<CqlConcept> h_ = context.Operators.Select<Condition, CqlConcept>(f_, g_);
            CqlValueSet i_ = this.Suicide_Attempt(context);
            bool? j_ = context.Operators.ConceptsInValueSet(h_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
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


    [CqlDeclaration("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_a_Fall_Present_on_Admission(context);

        return a_;
    }


    [CqlDeclaration("Encounter where a Fall and Moderate Injury Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_and_Moderate_Injury_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_where_a_Fall_Occurred(context);
        bool? b_(Encounter FallOccurred)
        {
            List<Encounter.DiagnosisComponent> d_ = FallOccurred?.Diagnosis;
            bool? e_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference h_ = Dx?.Condition;
                Condition i_ = CQMCommon_2_2_000.Instance.GetCondition(context, h_);
                CodeableConcept j_ = i_?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Moderate_Injuries(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                bool? n_(Extension @this)
                {
                    string ad_ = @this?.Url;
                    FhirString ae_ = context.Operators.Convert<FhirString>(ad_);
                    string af_ = FHIRHelpers_4_4_000.Instance.ToString(context, ae_);
                    bool? ag_ = context.Operators.Equal(af_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return ag_;
                };
                IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), n_);
                object p_(Extension @this)
                {
                    DataType ah_ = @this?.Value;

                    return ah_;
                };
                IEnumerable<object> q_ = context.Operators.Select<Extension, object>(o_, p_);
                object r_ = context.Operators.SingletonFrom<object>(q_);
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                CqlValueSet t_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_(Extension @this)
                {
                    string ai_ = @this?.Url;
                    FhirString aj_ = context.Operators.Convert<FhirString>(ai_);
                    string ak_ = FHIRHelpers_4_4_000.Instance.ToString(context, aj_);
                    bool? al_ = context.Operators.Equal(ak_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return al_;
                };
                IEnumerable<Extension> w_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), v_);
                object x_(Extension @this)
                {
                    DataType am_ = @this?.Value;

                    return am_;
                };
                IEnumerable<object> y_ = context.Operators.Select<Extension, object>(w_, x_);
                object z_ = context.Operators.SingletonFrom<object>(y_);
                CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_ as CodeableConcept);
                bool? ab_ = context.Operators.Or(u_, (bool?)(aa_ is null));
                bool? ac_ = context.Operators.And(m_, ab_);

                return ac_;
            };
            IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
            bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_where_a_Fall_and_Major_Injury_Occurred(context);
        IEnumerable<Encounter> b_ = this.Encounter_where_a_Fall_and_Moderate_Injury_Occurred(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

        return c_;
    }


    public int? Denominator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlInterval<CqlDateTime> a_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
        CqlDateTime b_ = context.Operators.Start(a_);
        CqlDateTime d_ = context.Operators.End(a_);
        int? e_ = context.Operators.DurationBetween(b_, d_, "day");

        return e_;
    }


    public int? Numerator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Encounter> a_ = this.Encounter_where_a_Fall_and_Major_Injury_Occurred(context);
        bool? b_(Encounter FallsEncounter)
        {
            Period e_ = FallsEncounter?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlDateTime g_ = context.Operators.End(f_);
            CqlInterval<CqlDateTime> h_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, default);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        int? d_ = context.Operators.Count<Encounter>(c_);

        return d_;
    }


    private static CqlTupleMetadata CqlTupleMetadata_CajFQjTXAXITWGJPNIjCafPiF = new(
        [typeof(Encounter), typeof(CqlConcept)],
        ["encounter", "condition"]);

    private static CqlTupleMetadata CqlTupleMetadata_CCJaUjRHWSXeUTcFAfVeVeNaD = new(
        [typeof(string), typeof(IEnumerable<ResourceReference>), typeof(IEnumerable<int?>), typeof(IEnumerable<Encounter.DiagnosisComponent>)],
        ["encounterId", "condition", "rank", "POA"]);


}

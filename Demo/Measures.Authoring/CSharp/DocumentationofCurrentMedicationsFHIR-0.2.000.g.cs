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
[CqlLibrary("DocumentationofCurrentMedicationsFHIR", "0.2.000")]
public partial class DocumentationofCurrentMedicationsFHIR_0_2_000 : ILibrary, ISingleton<DocumentationofCurrentMedicationsFHIR_0_2_000>
{
    private DocumentationofCurrentMedicationsFHIR_0_2_000() {}

    public static DocumentationofCurrentMedicationsFHIR_0_2_000 Instance { get; } = new();

    #region Library Members
    public string Name => "DocumentationofCurrentMedicationsFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, QICoreCommon_2_0_000.Instance, SupplementalDataElements_3_4_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Encounter to Document Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834")]
    public CqlValueSet Encounter_to_Document_Medications(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", default);


    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
    public CqlValueSet Medical_Reason(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", default);


    [CqlDeclaration("Documentation of current medications (procedure)")]
    public CqlCode Documentation_of_current_medications__procedure_(CqlContext context) => 
        new CqlCode("428191000124101", "http://snomed.info/sct", default, default);


    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("428191000124101", "http://snomed.info/sct", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("DocumentationofCurrentMedicationsFHIR-0.2.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
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


    [CqlDeclaration("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_to_Document_Medications(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> e_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? f_ = e_?.Value;
            Code<Encounter.EncounterStatus> g_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(f_);
            bool? h_ = context.Operators.Equal(g_, "finished");
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            Period j_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, j_);
            bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, k_, "day");
            bool? m_ = context.Operators.And(h_, l_);

            return m_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }


    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);

        return a_;
    }


    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
            CqlCode d_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? g_(Procedure MedicationsDocumented)
            {
                DataType k_ = MedicationsDocumented?.Performed;
                object l_ = FHIRHelpers_4_3_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.End(m_);
                Period o_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, default);
                Code<EventStatus> r_ = MedicationsDocumented?.StatusElement;
                EventStatus? s_ = r_?.Value;
                string t_ = context.Operators.Convert<string>(s_);
                bool? u_ = context.Operators.Equal(t_, "completed");
                bool? v_ = context.Operators.And(q_, u_);

                return v_;
            };
            IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
            Encounter i_(Procedure MedicationsDocumented) => 
                QualifyingEncounter;
            IEnumerable<Encounter> j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
            CqlCode d_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
            bool? g_(Procedure MedicationsNotDocumented)
            {
                bool? k_(Extension @this)
                {
                    string ae_ = @this?.Url;
                    FhirString af_ = context.Operators.Convert<FhirString>(ae_);
                    string ag_ = FHIRHelpers_4_3_000.Instance.ToString(context, af_);
                    bool? ah_ = context.Operators.Equal(ag_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return ah_;
                };
                IEnumerable<Extension> l_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationsNotDocumented is DomainResource
                        ? (MedicationsNotDocumented as DomainResource).Extension
                        : default), k_);
                DataType m_(Extension @this)
                {
                    DataType ai_ = @this?.Value;

                    return ai_;
                };
                IEnumerable<DataType> n_ = context.Operators.Select<Extension, DataType>(l_, m_);
                DataType o_ = context.Operators.SingletonFrom<DataType>(n_);
                CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
                Period q_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, q_);
                bool? s_ = context.Operators.In<CqlDateTime>(p_, r_, default);
                Code<EventStatus> t_ = MedicationsNotDocumented?.StatusElement;
                EventStatus? u_ = t_?.Value;
                string v_ = context.Operators.Convert<string>(u_);
                bool? w_ = context.Operators.Equal(v_, "not-done");
                bool? x_ = context.Operators.And(s_, w_);
                List<CodeableConcept> y_ = MedicationsNotDocumented?.ReasonCode;
                CqlConcept z_(CodeableConcept @this)
                {
                    CqlConcept aj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                    return aj_;
                };
                IEnumerable<CqlConcept> aa_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)y_, z_);
                CqlValueSet ab_ = this.Medical_Reason(context);
                bool? ac_ = context.Operators.ConceptsInValueSet(aa_, ab_);
                bool? ad_ = context.Operators.And(x_, ac_);

                return ad_;
            };
            IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
            Encounter i_(Procedure MedicationsNotDocumented) => 
                QualifyingEncounter;
            IEnumerable<Encounter> j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }

}

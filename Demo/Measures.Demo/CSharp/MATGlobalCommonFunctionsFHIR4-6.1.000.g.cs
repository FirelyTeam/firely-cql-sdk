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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.8.0")]
[CqlLibrary("MATGlobalCommonFunctionsFHIR4", "6.1.000")]
public partial class MATGlobalCommonFunctionsFHIR4_6_1_000 : ILibrary, ISingleton<MATGlobalCommonFunctionsFHIR4_6_1_000>
{
    private MATGlobalCommonFunctionsFHIR4_6_1_000() {}

    public static MATGlobalCommonFunctionsFHIR4_6_1_000 Instance { get; } = new();

    #region Library Members
    string ILibrary.Name => "MATGlobalCommonFunctionsFHIR4";
    string ILibrary.Version => "6.1.000";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_0_001.Instance];
    #endregion Library Members

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);


    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);


    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);


    [CqlDeclaration("Present on Admission or Clinically Undetermined")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197")]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", default);


    [CqlDeclaration("active")]
    public CqlCode active(CqlContext context) => 
        new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("allergy-active")]
    public CqlCode allergy_active(CqlContext context) => 
        new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);


    [CqlDeclaration("allergy-confirmed")]
    public CqlCode allergy_confirmed(CqlContext context) => 
        new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);


    [CqlDeclaration("allergy-inactive")]
    public CqlCode allergy_inactive(CqlContext context) => 
        new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);


    [CqlDeclaration("allergy-refuted")]
    public CqlCode allergy_refuted(CqlContext context) => 
        new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);


    [CqlDeclaration("allergy-resolved")]
    public CqlCode allergy_resolved(CqlContext context) => 
        new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);


    [CqlDeclaration("allergy-unconfirmed")]
    public CqlCode allergy_unconfirmed(CqlContext context) => 
        new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);


    [CqlDeclaration("Billing")]
    public CqlCode Billing(CqlContext context) => 
        new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);


    [CqlDeclaration("Birthdate")]
    public CqlCode Birthdate(CqlContext context) => 
        new CqlCode("21112-8", "http://loinc.org", default, default);


    [CqlDeclaration("Community")]
    public CqlCode Community(CqlContext context) => 
        new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);


    [CqlDeclaration("confirmed")]
    public CqlCode confirmed(CqlContext context) => 
        new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);


    [CqlDeclaration("Dead")]
    public CqlCode Dead(CqlContext context) => 
        new CqlCode("419099009", "http://snomed.info/sct", default, default);


    [CqlDeclaration("differential")]
    public CqlCode differential(CqlContext context) => 
        new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);


    [CqlDeclaration("Discharge")]
    public CqlCode Discharge(CqlContext context) => 
        new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);


    [CqlDeclaration("entered-in-error")]
    public CqlCode entered_in_error(CqlContext context) => 
        new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);


    [CqlDeclaration("ER")]
    public CqlCode ER(CqlContext context) => 
        new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);


    [CqlDeclaration("ICU")]
    public CqlCode ICU(CqlContext context) => 
        new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);


    [CqlDeclaration("inactive")]
    public CqlCode inactive(CqlContext context) => 
        new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("provisional")]
    public CqlCode provisional(CqlContext context) => 
        new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);


    [CqlDeclaration("recurrence")]
    public CqlCode recurrence(CqlContext context) => 
        new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("refuted")]
    public CqlCode refuted(CqlContext context) => 
        new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);


    [CqlDeclaration("relapse")]
    public CqlCode relapse(CqlContext context) => 
        new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("remission")]
    public CqlCode remission(CqlContext context) => 
        new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("resolved")]
    public CqlCode resolved(CqlContext context) => 
        new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);


    [CqlDeclaration("unconfirmed")]
    public CqlCode unconfirmed(CqlContext context) => 
        new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);


    [CqlDeclaration("ConditionClinicalStatusCodes")]
    public CqlCode[] ConditionClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
            new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
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
            new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
            new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
            new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("Diagnosis Role")]
    public CqlCode[] Diagnosis_Role(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("MedicationRequestCategory")]
    public CqlCode[] MedicationRequestCategory(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
            new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("ConditionVerificationStatusCodes")]
    public CqlCode[] ConditionVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
            new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
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


    [CqlDeclaration("RoleCode")]
    public CqlCode[] RoleCode(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
            new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }

    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime a_ = context.Operators.Start(Value);
        CqlDateTime b_ = context.Operators.End(Value);
        int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");

        return c_;
    }


    [CqlDeclaration("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? c_(Encounter EncounterInpatient)
        {
            Code<Encounter.EncounterStatus> e_ = EncounterInpatient?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "finished");
            Period h_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, h_);
            int? j_ = this.LengthInDays(context, i_);
            bool? k_ = context.Operators.LessOrEqual(j_, 120);
            bool? l_ = context.Operators.And(g_, k_);
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, h_);
            CqlDateTime o_ = context.Operators.End(n_);
            CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
            bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, default);
            bool? r_ = context.Operators.And(l_, q_);

            return r_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }

    public Encounter ED_Visit(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet a_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? c_(Encounter EDVisit)
        {
            Code<Encounter.EncounterStatus> h_ = EDVisit?.StatusElement;
            string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            bool? j_ = context.Operators.Equal(i_, "finished");
            Period k_ = EDVisit?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            Period n_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, n_);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlQuantity q_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime r_ = context.Operators.Subtract(p_, q_);
            CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, n_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlInterval<CqlDateTime> v_ = context.Operators.Interval(r_, u_, true, true);
            bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, default);
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, n_);
            CqlDateTime z_ = context.Operators.Start(y_);
            bool? aa_ = context.Operators.Not((bool?)(z_ is null));
            bool? ab_ = context.Operators.And(w_, aa_);
            bool? ac_ = context.Operators.And(j_, ab_);

            return ac_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        object e_(Encounter @this)
        {
            Period ad_ = @this?.Period;
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ad_);
            CqlDateTime af_ = context.Operators.End(ae_);

            return af_;
        };
        IEnumerable<Encounter> f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter g_ = context.Operators.Last<Encounter>(f_);

        return g_;
    }

    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, Encounter TheEncounter)
    {
        Encounter a_ = this.ED_Visit(context, TheEncounter);
        Encounter[] b_ = [
            a_,
        ];
        CqlInterval<CqlDateTime> c_(Encounter X)
        {
            CqlInterval<CqlDateTime> g_()
            {
                if (X is null)
                {
                    Period h_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, h_);

                    return i_;
                }
                else
                {
                    Period j_ = X?.Period;
                    CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, j_);
                    CqlDateTime l_ = context.Operators.Start(k_);
                    Period m_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, m_);
                    CqlDateTime o_ = context.Operators.End(n_);
                    CqlInterval<CqlDateTime> p_ = context.Operators.Interval(l_, o_, true, true);

                    return p_;
                }
            };

            return g_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)b_, c_);
        IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(d_);
        CqlInterval<CqlDateTime> f_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(e_);

        return f_;
    }

    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(CqlContext context, Encounter TheEncounter)
    {
        Encounter a_ = this.ED_Visit(context, TheEncounter);
        Encounter[] b_ = [
            a_,
        ];
        IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter)
        {
            IEnumerable<Encounter.LocationComponent> g_()
            {
                if (EDEncounter is null)
                {
                    List<Encounter.LocationComponent> h_ = TheEncounter?.Location;

                    return (IEnumerable<Encounter.LocationComponent>)h_;
                }
                else
                {
                    List<Encounter.LocationComponent> i_ = EDEncounter?.Location;
                    List<Encounter.LocationComponent> j_ = TheEncounter?.Location;
                    IEnumerable<Encounter.LocationComponent>[] k_ = [
                        (IEnumerable<Encounter.LocationComponent>)i_,
                        (IEnumerable<Encounter.LocationComponent>)j_,
                    ];
                    IEnumerable<Encounter.LocationComponent> l_ = context.Operators.Flatten<Encounter.LocationComponent>(k_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

                    return l_;
                }
            };

            return g_();
        };
        IEnumerable<IEnumerable<Encounter.LocationComponent>> d_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)b_, c_);
        IEnumerable<IEnumerable<Encounter.LocationComponent>> e_ = context.Operators.Distinct<IEnumerable<Encounter.LocationComponent>>(d_);
        IEnumerable<Encounter.LocationComponent> f_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(e_);

        return f_;
    }

    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> a_ = this.Hospitalization(context, TheEncounter);
        int? b_ = this.LengthInDays(context, a_);

        return b_;
    }

    public CqlDateTime Hospital_Admission_Time(CqlContext context, Encounter TheEncounter)
    {
        CqlInterval<CqlDateTime> a_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime b_ = context.Operators.Start(a_);

        return b_;
    }

    public CqlDateTime Hospital_Discharge_Time(CqlContext context, Encounter TheEncounter)
    {
        Period a_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime> b_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, a_);
        CqlDateTime c_ = context.Operators.End(b_);

        return c_;
    }

    public CqlDateTime Hospital_Arrival_Time(CqlContext context, Encounter TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent> a_ = this.Hospitalization_Locations(context, TheEncounter);
        object b_(Encounter.LocationComponent @this)
        {
            Period h_ = @this?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);

            return j_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent d_ = context.Operators.First<Encounter.LocationComponent>(c_);
        Period e_ = d_?.Period;
        CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, e_);
        CqlDateTime g_ = context.Operators.Start(f_);

        return g_;
    }

    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> b_(Encounter Visit)
        {
            CqlValueSet f_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? h_(Encounter LastED)
            {
                Period ag_ = LastED?.Period;
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ag_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                CqlValueSet aj_ = this.Observation_Services(context);
                IEnumerable<Encounter> ak_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? al_(Encounter LastObs)
                {
                    Period cc_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cc_);
                    CqlDateTime ce_ = context.Operators.End(cd_);
                    Period cf_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cf_);
                    CqlDateTime ch_ = context.Operators.Start(cg_);
                    CqlQuantity ci_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cj_ = context.Operators.Subtract(ch_, ci_);
                    CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cf_);
                    CqlDateTime cm_ = context.Operators.Start(cl_);
                    CqlInterval<CqlDateTime> cn_ = context.Operators.Interval(cj_, cm_, true, true);
                    bool? co_ = context.Operators.In<CqlDateTime>(ce_, cn_, default);
                    CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cf_);
                    CqlDateTime cr_ = context.Operators.Start(cq_);
                    bool? cs_ = context.Operators.Not((bool?)(cr_ is null));
                    bool? ct_ = context.Operators.And(co_, cs_);

                    return ct_;
                };
                IEnumerable<Encounter> am_ = context.Operators.Where<Encounter>(ak_, al_);
                object an_(Encounter @this)
                {
                    Period cu_ = @this?.Period;
                    CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cu_);
                    CqlDateTime cw_ = context.Operators.End(cv_);

                    return cw_;
                };
                IEnumerable<Encounter> ao_ = context.Operators.SortBy<Encounter>(am_, an_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ap_ = context.Operators.Last<Encounter>(ao_);
                Period aq_ = ap_?.Period;
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aq_);
                CqlDateTime as_ = context.Operators.Start(ar_);
                Period at_ = Visit?.Period;
                CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, at_);
                CqlDateTime av_ = context.Operators.Start(au_);
                CqlQuantity aw_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ax_ = context.Operators.Subtract(as_ ?? av_, aw_);
                IEnumerable<Encounter> az_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? ba_(Encounter LastObs)
                {
                    Period cx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cx_);
                    CqlDateTime cz_ = context.Operators.End(cy_);
                    Period da_ = Visit?.Period;
                    CqlInterval<CqlDateTime> db_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, da_);
                    CqlDateTime dc_ = context.Operators.Start(db_);
                    CqlQuantity dd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime de_ = context.Operators.Subtract(dc_, dd_);
                    CqlInterval<CqlDateTime> dg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, da_);
                    CqlDateTime dh_ = context.Operators.Start(dg_);
                    CqlInterval<CqlDateTime> di_ = context.Operators.Interval(de_, dh_, true, true);
                    bool? dj_ = context.Operators.In<CqlDateTime>(cz_, di_, default);
                    CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, da_);
                    CqlDateTime dm_ = context.Operators.Start(dl_);
                    bool? dn_ = context.Operators.Not((bool?)(dm_ is null));
                    bool? do_ = context.Operators.And(dj_, dn_);

                    return do_;
                };
                IEnumerable<Encounter> bb_ = context.Operators.Where<Encounter>(az_, ba_);
                object bc_(Encounter @this)
                {
                    Period dp_ = @this?.Period;
                    CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dp_);
                    CqlDateTime dr_ = context.Operators.End(dq_);

                    return dr_;
                };
                IEnumerable<Encounter> bd_ = context.Operators.SortBy<Encounter>(bb_, bc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter be_ = context.Operators.Last<Encounter>(bd_);
                Period bf_ = be_?.Period;
                CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, at_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(ax_, bh_ ?? bk_, true, true);
                bool? bm_ = context.Operators.In<CqlDateTime>(ai_, bl_, default);
                IEnumerable<Encounter> bo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? bp_(Encounter LastObs)
                {
                    Period ds_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ds_);
                    CqlDateTime du_ = context.Operators.End(dt_);
                    Period dv_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dv_);
                    CqlDateTime dx_ = context.Operators.Start(dw_);
                    CqlQuantity dy_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dz_ = context.Operators.Subtract(dx_, dy_);
                    CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dv_);
                    CqlDateTime ec_ = context.Operators.Start(eb_);
                    CqlInterval<CqlDateTime> ed_ = context.Operators.Interval(dz_, ec_, true, true);
                    bool? ee_ = context.Operators.In<CqlDateTime>(du_, ed_, default);
                    CqlInterval<CqlDateTime> eg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dv_);
                    CqlDateTime eh_ = context.Operators.Start(eg_);
                    bool? ei_ = context.Operators.Not((bool?)(eh_ is null));
                    bool? ej_ = context.Operators.And(ee_, ei_);

                    return ej_;
                };
                IEnumerable<Encounter> bq_ = context.Operators.Where<Encounter>(bo_, bp_);
                object br_(Encounter @this)
                {
                    Period ek_ = @this?.Period;
                    CqlInterval<CqlDateTime> el_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ek_);
                    CqlDateTime em_ = context.Operators.End(el_);

                    return em_;
                };
                IEnumerable<Encounter> bs_ = context.Operators.SortBy<Encounter>(bq_, br_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bt_ = context.Operators.Last<Encounter>(bs_);
                Period bu_ = bt_?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);
                CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, at_);
                CqlDateTime bz_ = context.Operators.Start(by_);
                bool? ca_ = context.Operators.Not((bool?)((bw_ ?? bz_) is null));
                bool? cb_ = context.Operators.And(bm_, ca_);

                return cb_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            object j_(Encounter @this)
            {
                Period en_ = @this?.Period;
                CqlInterval<CqlDateTime> eo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, en_);
                CqlDateTime ep_ = context.Operators.End(eo_);

                return ep_;
            };
            IEnumerable<Encounter> k_ = context.Operators.SortBy<Encounter>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter l_ = context.Operators.Last<Encounter>(k_);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlValueSet p_ = this.Observation_Services(context);
            IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? r_(Encounter LastObs)
            {
                Period eq_ = LastObs?.Period;
                CqlInterval<CqlDateTime> er_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, eq_);
                CqlDateTime es_ = context.Operators.End(er_);
                Period et_ = Visit?.Period;
                CqlInterval<CqlDateTime> eu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, et_);
                CqlDateTime ev_ = context.Operators.Start(eu_);
                CqlQuantity ew_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ex_ = context.Operators.Subtract(ev_, ew_);
                CqlInterval<CqlDateTime> ez_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, et_);
                CqlDateTime fa_ = context.Operators.Start(ez_);
                CqlInterval<CqlDateTime> fb_ = context.Operators.Interval(ex_, fa_, true, true);
                bool? fc_ = context.Operators.In<CqlDateTime>(es_, fb_, default);
                CqlInterval<CqlDateTime> fe_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, et_);
                CqlDateTime ff_ = context.Operators.Start(fe_);
                bool? fg_ = context.Operators.Not((bool?)(ff_ is null));
                bool? fh_ = context.Operators.And(fc_, fg_);

                return fh_;
            };
            IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
            object t_(Encounter @this)
            {
                Period fi_ = @this?.Period;
                CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fi_);
                CqlDateTime fk_ = context.Operators.End(fj_);

                return fk_;
            };
            IEnumerable<Encounter> u_ = context.Operators.SortBy<Encounter>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter v_ = context.Operators.Last<Encounter>(u_);
            Period w_ = v_?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            Period z_ = Visit?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, z_);
            CqlDateTime ae_ = context.Operators.End(ad_);
            CqlInterval<CqlDateTime> af_ = context.Operators.Interval(o_ ?? y_ ?? ab_, ae_, true, true);

            return af_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

        return e_;
    }

    public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_()
        {
            if (choice is FhirDateTime)
            {
                CqlDateTime b_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
                CqlInterval<CqlDateTime> d_ = context.Operators.Interval(b_, b_, true, true);

                return d_;
            }
            else if (choice is Period)
            {
                CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, choice as Period);

                return e_;
            }
            else if (choice is Instant)
            {
                CqlDateTime f_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> h_ = context.Operators.Interval(f_, f_, true, true);

                return h_;
            }
            else if (choice is Age)
            {
                Patient i_ = this.Patient(context);
                Date j_ = i_?.BirthDateElement;
                CqlDate k_ = FHIRHelpers_4_0_001.Instance.ToDate(context, j_);
                CqlQuantity l_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
                CqlDate m_ = context.Operators.Add(k_, l_);
                Date o_ = i_?.BirthDateElement;
                CqlDate p_ = FHIRHelpers_4_0_001.Instance.ToDate(context, o_);
                CqlDate r_ = context.Operators.Add(p_, l_);
                CqlQuantity s_ = context.Operators.Quantity(1m, "year");
                CqlDate t_ = context.Operators.Add(r_, s_);
                CqlInterval<CqlDate> u_ = context.Operators.Interval(m_, t_, true, false);
                CqlDate v_ = u_?.low;
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                Date y_ = i_?.BirthDateElement;
                CqlDate z_ = FHIRHelpers_4_0_001.Instance.ToDate(context, y_);
                CqlDate ab_ = context.Operators.Add(z_, l_);
                Date ad_ = i_?.BirthDateElement;
                CqlDate ae_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ad_);
                CqlDate ag_ = context.Operators.Add(ae_, l_);
                CqlDate ai_ = context.Operators.Add(ag_, s_);
                CqlInterval<CqlDate> aj_ = context.Operators.Interval(ab_, ai_, true, false);
                CqlDate ak_ = aj_?.high;
                CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);
                Date an_ = i_?.BirthDateElement;
                CqlDate ao_ = FHIRHelpers_4_0_001.Instance.ToDate(context, an_);
                CqlDate aq_ = context.Operators.Add(ao_, l_);
                Date as_ = i_?.BirthDateElement;
                CqlDate at_ = FHIRHelpers_4_0_001.Instance.ToDate(context, as_);
                CqlDate av_ = context.Operators.Add(at_, l_);
                CqlDate ax_ = context.Operators.Add(av_, s_);
                CqlInterval<CqlDate> ay_ = context.Operators.Interval(aq_, ax_, true, false);
                bool? az_ = ay_?.lowClosed;
                Date bb_ = i_?.BirthDateElement;
                CqlDate bc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bb_);
                CqlDate be_ = context.Operators.Add(bc_, l_);
                Date bg_ = i_?.BirthDateElement;
                CqlDate bh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bg_);
                CqlDate bj_ = context.Operators.Add(bh_, l_);
                CqlDate bl_ = context.Operators.Add(bj_, s_);
                CqlInterval<CqlDate> bm_ = context.Operators.Interval(be_, bl_, true, false);
                bool? bn_ = bm_?.highClosed;
                CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(w_, al_, az_, bn_);

                return bo_;
            }
            else if (choice is Range)
            {
                Patient bp_ = this.Patient(context);
                Date bq_ = bp_?.BirthDateElement;
                CqlDate br_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bq_);
                Quantity bs_ = (choice as Range)?.Low;
                CqlQuantity bt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bs_);
                CqlDate bu_ = context.Operators.Add(br_, bt_);
                Date bw_ = bp_?.BirthDateElement;
                CqlDate bx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bw_);
                Quantity by_ = (choice as Range)?.High;
                CqlQuantity bz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, by_);
                CqlDate ca_ = context.Operators.Add(bx_, bz_);
                CqlQuantity cb_ = context.Operators.Quantity(1m, "year");
                CqlDate cc_ = context.Operators.Add(ca_, cb_);
                CqlInterval<CqlDate> cd_ = context.Operators.Interval(bu_, cc_, true, false);
                CqlDate ce_ = cd_?.low;
                CqlDateTime cf_ = context.Operators.ConvertDateToDateTime(ce_);
                Date ch_ = bp_?.BirthDateElement;
                CqlDate ci_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ch_);
                CqlQuantity ck_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bs_);
                CqlDate cl_ = context.Operators.Add(ci_, ck_);
                Date cn_ = bp_?.BirthDateElement;
                CqlDate co_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cn_);
                CqlQuantity cq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, by_);
                CqlDate cr_ = context.Operators.Add(co_, cq_);
                CqlDate ct_ = context.Operators.Add(cr_, cb_);
                CqlInterval<CqlDate> cu_ = context.Operators.Interval(cl_, ct_, true, false);
                CqlDate cv_ = cu_?.high;
                CqlDateTime cw_ = context.Operators.ConvertDateToDateTime(cv_);
                Date cy_ = bp_?.BirthDateElement;
                CqlDate cz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cy_);
                CqlQuantity db_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bs_);
                CqlDate dc_ = context.Operators.Add(cz_, db_);
                Date de_ = bp_?.BirthDateElement;
                CqlDate df_ = FHIRHelpers_4_0_001.Instance.ToDate(context, de_);
                CqlQuantity dh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, by_);
                CqlDate di_ = context.Operators.Add(df_, dh_);
                CqlDate dk_ = context.Operators.Add(di_, cb_);
                CqlInterval<CqlDate> dl_ = context.Operators.Interval(dc_, dk_, true, false);
                bool? dm_ = dl_?.lowClosed;
                Date do_ = bp_?.BirthDateElement;
                CqlDate dp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, do_);
                CqlQuantity dr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bs_);
                CqlDate ds_ = context.Operators.Add(dp_, dr_);
                Date du_ = bp_?.BirthDateElement;
                CqlDate dv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, du_);
                CqlQuantity dx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, by_);
                CqlDate dy_ = context.Operators.Add(dv_, dx_);
                CqlDate ea_ = context.Operators.Add(dy_, cb_);
                CqlInterval<CqlDate> eb_ = context.Operators.Interval(ds_, ea_, true, false);
                bool? ec_ = eb_?.highClosed;
                CqlInterval<CqlDateTime> ed_ = context.Operators.Interval(cf_, cw_, dm_, ec_);

                return ed_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> ee_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");

                return ee_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> ef_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return ef_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return a_();
    }

    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> a_()
        {
            bool b_()
            {
                DataType h_ = condition?.Abatement;
                bool i_ = h_ is FhirDateTime;

                return i_;
            };
            bool c_()
            {
                DataType j_ = condition?.Abatement;
                bool k_ = j_ is Period;

                return k_;
            };
            bool d_()
            {
                DataType l_ = condition?.Abatement;
                bool m_ = l_ is FhirString;

                return m_;
            };
            bool e_()
            {
                DataType n_ = condition?.Abatement;
                bool o_ = n_ is Age;

                return o_;
            };
            bool f_()
            {
                DataType p_ = condition?.Abatement;
                bool q_ = p_ is Range;

                return q_;
            };
            bool g_()
            {
                DataType r_ = condition?.Abatement;
                bool s_ = r_ is FhirBoolean;

                return s_;
            };
            if (b_())
            {
                DataType t_ = condition?.Abatement;
                CqlDateTime u_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, t_ as FhirDateTime);
                CqlDateTime w_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, t_ as FhirDateTime);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);

                return x_;
            }
            else if (c_())
            {
                DataType y_ = condition?.Abatement;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, y_ as Period);

                return z_;
            }
            else if (d_())
            {
                CqlInterval<CqlDateTime> aa_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return aa_;
            }
            else if (e_())
            {
                Patient ab_ = this.Patient(context);
                Date ac_ = ab_?.BirthDateElement;
                CqlDate ad_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ac_);
                DataType ae_ = condition?.Abatement;
                CqlQuantity af_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ae_ as Age);
                CqlDate ag_ = context.Operators.Add(ad_, af_);
                Date ai_ = ab_?.BirthDateElement;
                CqlDate aj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ai_);
                CqlQuantity al_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ae_ as Age);
                CqlDate am_ = context.Operators.Add(aj_, al_);
                CqlQuantity an_ = context.Operators.Quantity(1m, "year");
                CqlDate ao_ = context.Operators.Add(am_, an_);
                CqlInterval<CqlDate> ap_ = context.Operators.Interval(ag_, ao_, true, false);
                CqlDate aq_ = ap_?.low;
                CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);
                Date at_ = ab_?.BirthDateElement;
                CqlDate au_ = FHIRHelpers_4_0_001.Instance.ToDate(context, at_);
                CqlQuantity aw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ae_ as Age);
                CqlDate ax_ = context.Operators.Add(au_, aw_);
                Date az_ = ab_?.BirthDateElement;
                CqlDate ba_ = FHIRHelpers_4_0_001.Instance.ToDate(context, az_);
                CqlQuantity bc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ae_ as Age);
                CqlDate bd_ = context.Operators.Add(ba_, bc_);
                CqlDate bf_ = context.Operators.Add(bd_, an_);
                CqlInterval<CqlDate> bg_ = context.Operators.Interval(ax_, bf_, true, false);
                CqlDate bh_ = bg_?.high;
                CqlDateTime bi_ = context.Operators.ConvertDateToDateTime(bh_);
                Date bk_ = ab_?.BirthDateElement;
                CqlDate bl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bk_);
                CqlQuantity bn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ae_ as Age);
                CqlDate bo_ = context.Operators.Add(bl_, bn_);
                Date bq_ = ab_?.BirthDateElement;
                CqlDate br_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bq_);
                CqlQuantity bt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ae_ as Age);
                CqlDate bu_ = context.Operators.Add(br_, bt_);
                CqlDate bw_ = context.Operators.Add(bu_, an_);
                CqlInterval<CqlDate> bx_ = context.Operators.Interval(bo_, bw_, true, false);
                bool? by_ = bx_?.lowClosed;
                Date ca_ = ab_?.BirthDateElement;
                CqlDate cb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ca_);
                CqlQuantity cd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ae_ as Age);
                CqlDate ce_ = context.Operators.Add(cb_, cd_);
                Date cg_ = ab_?.BirthDateElement;
                CqlDate ch_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cg_);
                CqlQuantity cj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ae_ as Age);
                CqlDate ck_ = context.Operators.Add(ch_, cj_);
                CqlDate cm_ = context.Operators.Add(ck_, an_);
                CqlInterval<CqlDate> cn_ = context.Operators.Interval(ce_, cm_, true, false);
                bool? co_ = cn_?.highClosed;
                CqlInterval<CqlDateTime> cp_ = context.Operators.Interval(ar_, bi_, by_, co_);

                return cp_;
            }
            else if (f_())
            {
                Patient cq_ = this.Patient(context);
                Date cr_ = cq_?.BirthDateElement;
                CqlDate cs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cr_);
                DataType ct_ = condition?.Abatement;
                Quantity cu_ = (ct_ as Range)?.Low;
                CqlQuantity cv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cu_);
                CqlDate cw_ = context.Operators.Add(cs_, cv_);
                Date cy_ = cq_?.BirthDateElement;
                CqlDate cz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, cy_);
                Quantity db_ = (ct_ as Range)?.High;
                CqlQuantity dc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, db_);
                CqlDate dd_ = context.Operators.Add(cz_, dc_);
                CqlQuantity de_ = context.Operators.Quantity(1m, "year");
                CqlDate df_ = context.Operators.Add(dd_, de_);
                CqlInterval<CqlDate> dg_ = context.Operators.Interval(cw_, df_, true, false);
                CqlDate dh_ = dg_?.low;
                CqlDateTime di_ = context.Operators.ConvertDateToDateTime(dh_);
                Date dk_ = cq_?.BirthDateElement;
                CqlDate dl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dk_);
                Quantity dn_ = (ct_ as Range)?.Low;
                CqlQuantity do_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, dn_);
                CqlDate dp_ = context.Operators.Add(dl_, do_);
                Date dr_ = cq_?.BirthDateElement;
                CqlDate ds_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dr_);
                Quantity du_ = (ct_ as Range)?.High;
                CqlQuantity dv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, du_);
                CqlDate dw_ = context.Operators.Add(ds_, dv_);
                CqlDate dy_ = context.Operators.Add(dw_, de_);
                CqlInterval<CqlDate> dz_ = context.Operators.Interval(dp_, dy_, true, false);
                CqlDate ea_ = dz_?.high;
                CqlDateTime eb_ = context.Operators.ConvertDateToDateTime(ea_);
                Date ed_ = cq_?.BirthDateElement;
                CqlDate ee_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ed_);
                Quantity eg_ = (ct_ as Range)?.Low;
                CqlQuantity eh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, eg_);
                CqlDate ei_ = context.Operators.Add(ee_, eh_);
                Date ek_ = cq_?.BirthDateElement;
                CqlDate el_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ek_);
                Quantity en_ = (ct_ as Range)?.High;
                CqlQuantity eo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, en_);
                CqlDate ep_ = context.Operators.Add(el_, eo_);
                CqlDate er_ = context.Operators.Add(ep_, de_);
                CqlInterval<CqlDate> es_ = context.Operators.Interval(ei_, er_, true, false);
                bool? et_ = es_?.lowClosed;
                Date ev_ = cq_?.BirthDateElement;
                CqlDate ew_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ev_);
                Quantity ey_ = (ct_ as Range)?.Low;
                CqlQuantity ez_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ey_);
                CqlDate fa_ = context.Operators.Add(ew_, ez_);
                Date fc_ = cq_?.BirthDateElement;
                CqlDate fd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fc_);
                Quantity ff_ = (ct_ as Range)?.High;
                CqlQuantity fg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ff_);
                CqlDate fh_ = context.Operators.Add(fd_, fg_);
                CqlDate fj_ = context.Operators.Add(fh_, de_);
                CqlInterval<CqlDate> fk_ = context.Operators.Interval(fa_, fj_, true, false);
                bool? fl_ = fk_?.highClosed;
                CqlInterval<CqlDateTime> fm_ = context.Operators.Interval(di_, eb_, et_, fl_);

                return fm_;
            }
            else if (g_())
            {
                DataType fn_ = condition?.Onset;
                CqlInterval<CqlDateTime> fo_ = this.Normalize_Interval(context, fn_);
                CqlDateTime fp_ = context.Operators.End(fo_);
                FhirDateTime fq_ = condition?.RecordedDateElement;
                CqlDateTime fr_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, fq_);
                CqlInterval<CqlDateTime> fs_ = context.Operators.Interval(fp_, fr_, true, false);

                return fs_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return a_();
    }

    public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
    {
        CqlInterval<CqlDateTime> a_()
        {
            bool b_()
            {
                CodeableConcept c_ = condition?.ClinicalStatus;
                CqlConcept d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
                CqlCode e_ = this.active(context);
                CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
                bool? g_ = context.Operators.Equivalent(d_, f_);
                CqlConcept i_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
                CqlCode j_ = this.recurrence(context);
                CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
                bool? l_ = context.Operators.Equivalent(i_, k_);
                bool? m_ = context.Operators.Or(g_, l_);
                CqlConcept o_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
                CqlCode p_ = this.relapse(context);
                CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                bool? r_ = context.Operators.Equivalent(o_, q_);
                bool? s_ = context.Operators.Or(m_, r_);

                return s_ ?? false;
            };
            if (b_())
            {
                DataType t_ = condition?.Onset;
                CqlInterval<CqlDateTime> u_ = this.Normalize_Interval(context, t_);
                CqlDateTime v_ = context.Operators.Start(u_);
                CqlInterval<CqlDateTime> w_ = this.Normalize_Abatement(context, condition);
                CqlDateTime x_ = context.Operators.End(w_);
                CqlInterval<CqlDateTime> y_ = context.Operators.Interval(v_, x_, true, true);

                return y_;
            }
            else
            {
                DataType z_ = condition?.Onset;
                CqlInterval<CqlDateTime> aa_ = this.Normalize_Interval(context, z_);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                CqlInterval<CqlDateTime> ac_ = this.Normalize_Abatement(context, condition);
                CqlDateTime ad_ = context.Operators.End(ac_);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(ab_, ad_, true, false);

                return ae_;
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

    public IEnumerable<Condition> EncounterDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
        Condition b_(Encounter.DiagnosisComponent D)
        {
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? f_(Condition C)
            {
                Id i_ = C?.IdElement;
                string j_ = FHIRHelpers_4_0_001.Instance.ToString(context, i_);
                ResourceReference k_ = D?.Condition;
                FhirString l_ = k_?.ReferenceElement;
                string m_ = FHIRHelpers_4_0_001.Instance.ToString(context, l_);
                string n_ = this.GetId(context, m_);
                bool? o_ = context.Operators.Equal(j_, n_);

                return o_;
            };
            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
            Condition h_ = context.Operators.SingletonFrom<Condition>(g_);

            return h_;
        };
        IEnumerable<Condition> c_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        IEnumerable<Condition> d_ = context.Operators.Distinct<Condition>(c_);

        return d_;
    }

    public Condition GetCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> a_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? b_(Condition C)
        {
            Id e_ = C?.IdElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            FhirString g_ = reference?.ReferenceElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            string i_ = this.GetId(context, h_);
            bool? j_ = context.Operators.Equal(f_, i_);

            return j_;
        };
        IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
        Condition d_ = context.Operators.SingletonFrom<Condition>(c_);

        return d_;
    }

    public IEnumerable<Extension> GetExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> a_ = domainResource?.Extension;
        bool? b_(Extension E)
        {
            string g_ = E?.Url;
            FhirUri h_ = context.Operators.Convert<FhirUri>(g_);
            string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            string j_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
            bool? k_ = context.Operators.Equal(i_, j_);

            return k_;
        };
        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
        Extension d_(Extension E) => 
            E;
        IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);
        IEnumerable<Extension> f_ = context.Operators.Distinct<Extension>(e_);

        return f_;
    }

    public IEnumerable<Extension> GetExtensions(CqlContext context, Element element, string url)
    {
        List<Extension> a_ = element?.Extension;
        bool? b_(Extension E)
        {
            string g_ = E?.Url;
            FhirUri h_ = context.Operators.Convert<FhirUri>(g_);
            string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            bool? j_ = context.Operators.Equal(i_, url);

            return j_;
        };
        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
        Extension d_(Extension E) => 
            E;
        IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);
        IEnumerable<Extension> f_ = context.Operators.Distinct<Extension>(e_);

        return f_;
    }

    public Extension GetExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> a_ = this.GetExtensions(context, domainResource, url);
        Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

        return b_;
    }

    public Extension GetExtension(CqlContext context, Element element, string url)
    {
        IEnumerable<Extension> a_ = this.GetExtensions(context, element, url);
        Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

        return b_;
    }

    public CodeableConcept PresentOnAdmissionIndicator(CqlContext context, Element element)
    {
        Extension a_ = this.GetExtension(context, element, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");
        DataType b_ = a_?.Value;

        return b_ as CodeableConcept;
    }

    public Condition PrincipalDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
        bool? b_(Encounter.DiagnosisComponent D)
        {
            PositiveInt j_ = D?.RankElement;
            Integer k_ = context.Operators.Convert<Integer>(j_);
            int? l_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, k_);
            bool? m_ = context.Operators.Equal(l_, 1);

            return m_;
        };
        IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        Encounter.DiagnosisComponent d_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(c_);
        Encounter.DiagnosisComponent[] e_ = [
            d_,
        ];
        Condition f_(Encounter.DiagnosisComponent PD)
        {
            IEnumerable<Condition> n_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? o_(Condition C)
            {
                Id r_ = C?.IdElement;
                string s_ = FHIRHelpers_4_0_001.Instance.ToString(context, r_);
                ResourceReference t_ = PD?.Condition;
                FhirString u_ = t_?.ReferenceElement;
                string v_ = FHIRHelpers_4_0_001.Instance.ToString(context, u_);
                string w_ = this.GetId(context, v_);
                bool? x_ = context.Operators.Equal(s_, w_);

                return x_;
            };
            IEnumerable<Condition> p_ = context.Operators.Where<Condition>(n_, o_);
            Condition q_ = context.Operators.SingletonFrom<Condition>(p_);

            return q_;
        };
        IEnumerable<Condition> g_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)e_, f_);
        IEnumerable<Condition> h_ = context.Operators.Distinct<Condition>(g_);
        Condition i_ = context.Operators.SingletonFrom<Condition>(h_);

        return i_;
    }

    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> a_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));
        bool? b_(Location L)
        {
            Id e_ = L?.IdElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            FhirString g_ = reference?.ReferenceElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            string i_ = this.GetId(context, h_);
            bool? j_ = context.Operators.Equal(f_, i_);

            return j_;
        };
        IEnumerable<Location> c_ = context.Operators.Where<Location>(a_, b_);
        Location d_ = context.Operators.SingletonFrom<Location>(c_);

        return d_;
    }

    public IEnumerable<Extension> GetBaseExtensions(CqlContext context, DomainResource domainResource, string url)
    {
        List<Extension> a_ = domainResource?.Extension;
        bool? b_(Extension E)
        {
            string g_ = E?.Url;
            FhirUri h_ = context.Operators.Convert<FhirUri>(g_);
            string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            string j_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
            bool? k_ = context.Operators.Equal(i_, j_);

            return k_;
        };
        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
        Extension d_(Extension E) => 
            E;
        IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);
        IEnumerable<Extension> f_ = context.Operators.Distinct<Extension>(e_);

        return f_;
    }

    public Extension GetBaseExtension(CqlContext context, DomainResource domainResource, string url)
    {
        IEnumerable<Extension> a_ = this.GetBaseExtensions(context, domainResource, url);
        Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

        return b_;
    }

    public IEnumerable<Extension> BaseExtensions(CqlContext context, Element element, string id)
    {
        List<Extension> a_ = element?.Extension;
        bool? b_(Extension E)
        {
            string g_ = E?.Url;
            FhirUri h_ = context.Operators.Convert<FhirUri>(g_);
            string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            string j_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
            bool? k_ = context.Operators.Equal(i_, j_);

            return k_;
        };
        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
        Extension d_(Extension E) => 
            E;
        IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);
        IEnumerable<Extension> f_ = context.Operators.Distinct<Extension>(e_);

        return f_;
    }

    public Extension BaseExtension(CqlContext context, Element element, string id)
    {
        IEnumerable<Extension> a_ = this.BaseExtensions(context, element, id);
        Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

        return b_;
    }

    public CodeableConcept GetMedicationCode(CqlContext context, MedicationRequest request)
    {
        CodeableConcept a_()
        {
            bool b_()
            {
                DataType c_ = request?.Medication;
                bool d_ = c_ is CodeableConcept;

                return d_;
            };
            if (b_())
            {
                DataType e_ = request?.Medication;

                return e_ as CodeableConcept;
            }
            else
            {
                IEnumerable<Medication> f_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));
                bool? g_(Medication M)
                {
                    Id k_ = M?.IdElement;
                    string l_ = FHIRHelpers_4_0_001.Instance.ToString(context, k_);
                    DataType m_ = request?.Medication;
                    FhirString n_ = (m_ as ResourceReference)?.ReferenceElement;
                    string o_ = FHIRHelpers_4_0_001.Instance.ToString(context, n_);
                    string p_ = this.GetId(context, o_);
                    bool? q_ = context.Operators.Equal(l_, p_);

                    return q_;
                };
                IEnumerable<Medication> h_ = context.Operators.Where<Medication>(f_, g_);
                Medication i_ = context.Operators.SingletonFrom<Medication>(h_);
                CodeableConcept j_ = i_?.Code;

                return j_;
            }
        };

        return a_();
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

    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
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
        CqlInterval<CqlDateTime> a_ = this.Normalize_Interval(context, choice);
        CqlInterval<CqlDateTime>[] b_ = [
            a_,
        ];
        CqlDateTime c_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime g_()
            {
                if ((this.HasEnd(context, period)) ?? false)
                {
                    CqlDateTime h_ = context.Operators.End(period);

                    return h_;
                }
                else
                {
                    CqlDateTime i_ = context.Operators.Start(period);

                    return i_;
                }
            };

            return g_();
        };
        IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        CqlDateTime f_ = context.Operators.SingletonFrom<CqlDateTime>(e_);

        return f_;
    }

    public CqlDateTime Earliest(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_ = this.Normalize_Interval(context, choice);
        CqlInterval<CqlDateTime>[] b_ = [
            a_,
        ];
        CqlDateTime c_(CqlInterval<CqlDateTime> period)
        {
            CqlDateTime g_()
            {
                if ((this.HasStart(context, period)) ?? false)
                {
                    CqlDateTime h_ = context.Operators.Start(period);

                    return h_;
                }
                else
                {
                    CqlDateTime i_ = context.Operators.End(period);

                    return i_;
                }
            };

            return g_();
        };
        IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        CqlDateTime f_ = context.Operators.SingletonFrom<CqlDateTime>(e_);

        return f_;
    }

}

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.10.0")]
[CqlLibrary("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR", "1.4.000")]
public partial class IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000 : ILibrary, ISingleton<IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000>
{
    private IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000() {}

    public static IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    string ILibrary.Name => "IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR";
    string ILibrary.Version => "1.4.000";
    IReadOnlyCollection<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

    #endregion ILibrary Implementation

    #region Definition Methods

    [CqlDeclaration("Active Tuberculosis for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56")]
    public CqlValueSet Active_Tuberculosis_for_Urology_Care(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56", default);


    [CqlDeclaration("BCG Bacillus Calmette Guerin for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52")]
    public CqlValueSet BCG_Bacillus_Calmette_Guerin_for_Urology_Care(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52", default);


    [CqlDeclaration("Bladder Cancer for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45")]
    public CqlValueSet Bladder_Cancer_for_Urology_Care(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45", default);


    [CqlDeclaration("Chemotherapy Agents for Advanced Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60")]
    public CqlValueSet Chemotherapy_Agents_for_Advanced_Cancer(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60", default);


    [CqlDeclaration("Cystectomy for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55")]
    public CqlValueSet Cystectomy_for_Urology_Care(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55", default);


    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
    public CqlValueSet HIV(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", default);


    [CqlDeclaration("Immunocompromised Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940")]
    public CqlValueSet Immunocompromised_Conditions(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940", default);


    [CqlDeclaration("Immunosuppressive Drugs for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32")]
    public CqlValueSet Immunosuppressive_Drugs_for_Urology_Care(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32", default);


    [CqlDeclaration("Mixed histology urothelial cell carcinoma for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39")]
    public CqlValueSet Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Unavailability of Bacillus Calmette Guerin for urology care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44")]
    public CqlValueSet Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44", default);


    [CqlDeclaration("American Joint Committee on Cancer cT1 (qualifier value)")]
    public CqlCode American_Joint_Committee_on_Cancer_cT1__qualifier_value_(CqlContext context) =>
        new CqlCode("1228889001", "http://snomed.info/sct", default, default);


    [CqlDeclaration("American Joint Committee on Cancer cTa (qualifier value)")]
    public CqlCode American_Joint_Committee_on_Cancer_cTa__qualifier_value_(CqlContext context) =>
        new CqlCode("1228883000", "http://snomed.info/sct", default, default);


    [CqlDeclaration("American Joint Committee on Cancer cTis (qualifier value)")]
    public CqlCode American_Joint_Committee_on_Cancer_cTis__qualifier_value_(CqlContext context) =>
        new CqlCode("1228884006", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Carcinoma in situ of bladder")]
    public CqlCode Carcinoma_in_situ_of_bladder(CqlContext context) =>
        new CqlCode("D09.0", "http://hl7.org/fhir/sid/icd-10-cm", default, default);


    [CqlDeclaration("Combined radiotherapy (procedure)")]
    public CqlCode Combined_radiotherapy__procedure_(CqlContext context) =>
        new CqlCode("169331000", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Tumor staging (tumor staging)")]
    public CqlCode Tumor_staging__tumor_staging_(CqlContext context) =>
        new CqlCode("254292007", "http://snomed.info/sct", default, default);


    [CqlDeclaration("virtual")]
    public CqlCode @virtual(CqlContext context) =>
        new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("1228889001", "http://snomed.info/sct", default, default),
            new CqlCode("1228883000", "http://snomed.info/sct", default, default),
            new CqlCode("1228884006", "http://snomed.info/sct", default, default),
            new CqlCode("169331000", "http://snomed.info/sct", default, default),
            new CqlCode("254292007", "http://snomed.info/sct", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("ICD10CM")]
    public CqlCode[] ICD10CM(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("D09.0", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
        ];

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
        object d_ = context.ResolveParameter("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR-1.4.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition Condition)
    {
        bool? a_ = QICoreCommon_2_1_000.Instance.isActive(context, Condition);
        CodeableConcept b_ = Condition?.VerificationStatus;
        CqlConcept c_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, b_);
        CqlCode d_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(c_, e_);
        bool? g_ = context.Operators.And(a_, f_);

        return g_;
    }


    [CqlDeclaration("Bladder Cancer Diagnosis")]
    public IEnumerable<Condition> Bladder_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Bladder_Cancer_for_Urology_Care(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition BladderCancer)
        {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BladderCancer);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            CqlDateTime h_ = context.Operators.End(g_);
            bool? i_ = context.Operators.Before(f_, h_, default);
            bool? j_ = this.isConfirmedActiveDiagnosis(context, BladderCancer);
            bool? k_ = context.Operators.And(i_, j_);

            return k_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

        return d_;
    }


    [CqlDeclaration("First Bladder Cancer Staging Procedure")]
    public Procedure First_Bladder_Cancer_Staging_Procedure(CqlContext context)
    {
        CqlCode a_ = this.Tumor_staging__tumor_staging_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> d_(Procedure BladderCancerStaging)
        {
            IEnumerable<Condition> k_ = this.Bladder_Cancer_Diagnosis(context);
            bool? l_(Condition BladderCancer)
            {
                DataType p_ = BladderCancerStaging?.Performed;
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                CqlInterval<CqlDateTime> r_ = QICoreCommon_2_1_000.Instance.toInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BladderCancer);
                CqlDateTime u_ = context.Operators.Start(t_);
                bool? v_ = context.Operators.SameOrBefore(s_, u_, "day");

                return v_;
            };
            IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
            Procedure n_(Condition BladderCancer) =>
                BladderCancerStaging;
            IEnumerable<Procedure> o_ = context.Operators.Select<Condition, Procedure>(m_, n_);

            return o_;
        };
        IEnumerable<Procedure> e_ = context.Operators.SelectMany<Procedure, Procedure>(c_, d_);
        bool? f_(Procedure BladderCancerStaging)
        {
            Code<EventStatus> w_ = BladderCancerStaging?.StatusElement;
            EventStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            bool? z_ = context.Operators.Equal(y_, "completed");

            return z_;
        };
        IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
        object h_(Procedure @this)
        {
            DataType aa_ = @this?.Performed;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            CqlInterval<CqlDateTime> ac_ = QICoreCommon_2_1_000.Instance.toInterval(context, ab_);
            CqlDateTime ad_ = context.Operators.Start(ac_);

            return ad_;
        };
        IEnumerable<Procedure> i_ = context.Operators.SortBy<Procedure>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
        Procedure j_ = context.Operators.First<Procedure>(i_);

        return j_;
    }


    [CqlDeclaration("July 1 of Year Prior to the Measurement Period")]
    public CqlDateTime July_1_of_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        int? d_ = context.Operators.Subtract(c_, 1);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime f_ = context.Operators.DateTime(d_, 7, 1, 0, 0, 0, 0, e_);

        return f_;
    }


    [CqlDeclaration("June 30 of the Measurement Period")]
    public CqlDateTime June_30_of_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        decimal? d_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime e_ = context.Operators.DateTime(c_, 6, 30, 23, 59, 59, 0, d_);

        return e_;
    }


    [CqlDeclaration("First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period")]
    public Procedure First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(CqlContext context)
    {
        Procedure a_ = this.First_Bladder_Cancer_Staging_Procedure(context);
        Procedure[] b_ = [
            a_,
        ];
        bool? c_(Procedure FirstBladderCancerStaging)
        {
            CqlDateTime f_ = this.July_1_of_Year_Prior_to_the_Measurement_Period(context);
            CqlDateTime g_ = this.June_30_of_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> h_ = context.Operators.Interval(f_, g_, true, true);
            DataType i_ = FirstBladderCancerStaging?.Performed;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlInterval<CqlDateTime> k_ = QICoreCommon_2_1_000.Instance.toInterval(context, j_);
            bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, k_, "day");

            return l_;
        };
        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)b_, c_);
        Procedure e_ = context.Operators.SingletonFrom<Procedure>(d_);

        return e_;
    }


    public IEnumerable<Procedure> getStagingProcedure(CqlContext context, Observation StagingObservation)
    {
        List<ResourceReference> a_ = StagingObservation?.PartOf;
        Procedure b_(ResourceReference StagingReference)
        {
            Procedure e_ = this.First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(context);
            Procedure[] f_ = [
                e_,
            ];
            bool? g_(Procedure FirstBladderCancerStagingMP)
            {
                Id j_ = FirstBladderCancerStagingMP?.IdElement;
                string k_ = j_?.Value;
                FhirString l_ = StagingReference?.ReferenceElement;
                string m_ = l_?.Value;
                string n_ = QICoreCommon_2_1_000.Instance.getId(context, m_);
                bool? o_ = context.Operators.Equal(k_, n_);

                return o_;
            };
            IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)f_, g_);
            Procedure i_ = context.Operators.SingletonFrom<Procedure>(h_);

            return i_;
        };
        IEnumerable<Procedure> c_ = context.Operators.Select<ResourceReference, Procedure>((IEnumerable<ResourceReference>)a_, b_);
        IEnumerable<Procedure> d_ = context.Operators.Distinct<Procedure>(c_);

        return d_;
    }


    [CqlDeclaration("Has Most Recent Bladder Cancer Tumor Staging is Ta HG, Tis, T1")]
    public bool? Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? b_(Observation StagingObservation)
        {
            IEnumerable<Procedure> e_ = this.getStagingProcedure(context, StagingObservation);
            bool? f_ = context.Operators.Not((bool?)(e_ is null));
            DataType g_ = StagingObservation?.Value;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlCode i_ = this.American_Joint_Committee_on_Cancer_cT1__qualifier_value_(context);
            CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
            bool? k_ = context.Operators.Equivalent(h_ as CqlConcept, j_);
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlCode n_ = this.American_Joint_Committee_on_Cancer_cTis__qualifier_value_(context);
            CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
            bool? p_ = context.Operators.Equivalent(m_ as CqlConcept, o_);
            bool? q_ = context.Operators.Or(k_, p_);
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlCode t_ = this.American_Joint_Committee_on_Cancer_cTa__qualifier_value_(context);
            CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
            bool? v_ = context.Operators.Equivalent(s_ as CqlConcept, u_);
            bool? w_ = context.Operators.Or(q_, v_);
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlCode z_ = this.Carcinoma_in_situ_of_bladder(context);
            CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
            bool? ab_ = context.Operators.Equivalent(y_ as CqlConcept, aa_);
            bool? ac_ = context.Operators.Or(w_, ab_);
            bool? ad_ = context.Operators.And(f_, ac_);
            Code<ObservationStatus> ae_ = StagingObservation?.StatusElement;
            ObservationStatus? af_ = ae_?.Value;
            Code<ObservationStatus> ag_ = context.Operators.Convert<Code<ObservationStatus>>(af_);
            string ah_ = context.Operators.Convert<string>(ag_);
            string[] ai_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? aj_ = context.Operators.In<string>(ah_, ai_ as IEnumerable<string>);
            bool? ak_ = context.Operators.And(ad_, aj_);

            return ak_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        bool? d_ = context.Operators.Exists<Observation>(c_);

        return d_;
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
            bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, default);
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


    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? a_ = this.Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(context);
        bool? b_ = this.Has_Qualifying_Encounter(context);
        bool? c_ = context.Operators.And(a_, b_);

        return c_;
    }


    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Acute Tuberculosis Diagnosis")]
    public IEnumerable<Condition> Acute_Tuberculosis_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Active_Tuberculosis_for_Urology_Care(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> c_(Condition ActiveTuberculosis)
        {
            Procedure g_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] h_ = [
                g_,
            ];
            bool? i_(Procedure FirstBladderCancerStaging)
            {
                CqlInterval<CqlDateTime> m_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveTuberculosis);
                DataType n_ = FirstBladderCancerStaging?.Performed;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_);
                bool? q_ = context.Operators.OverlapsAfter(m_, p_, "day");

                return q_;
            };
            IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)h_, i_);
            Condition k_(Procedure FirstBladderCancerStaging) =>
                ActiveTuberculosis;
            IEnumerable<Condition> l_ = context.Operators.Select<Procedure, Condition>(j_, k_);

            return l_;
        };
        IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
        bool? e_(Condition ActiveTuberculosis)
        {
            bool? r_ = this.isConfirmedActiveDiagnosis(context, ActiveTuberculosis);

            return r_;
        };
        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

        return f_;
    }


    [CqlDeclaration("Immunosuppressive Drugs")]
    public IEnumerable<MedicationRequest> Immunosuppressive_Drugs(CqlContext context)
    {
        CqlValueSet a_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_(MedicationRequest ImmunosuppressiveDrugs)
        {
            Procedure j_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] k_ = [
                j_,
            ];
            bool? l_(Procedure FirstBladderCancerStaging)
            {
                List<Dosage> p_ = ImmunosuppressiveDrugs?.DosageInstruction;
                bool? q_(Dosage @this)
                {
                    Timing ba_ = @this?.Timing;
                    bool? bb_ = context.Operators.Not((bool?)(ba_ is null));

                    return bb_;
                };
                IEnumerable<Dosage> r_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)p_, q_);
                Timing s_(Dosage @this)
                {
                    Timing bc_ = @this?.Timing;

                    return bc_;
                };
                IEnumerable<Timing> t_ = context.Operators.Select<Dosage, Timing>(r_, s_);
                CqlDateTime u_(Timing dosageTiming)
                {
                    List<FhirDateTime> bd_ = dosageTiming?.EventElement;
                    IEnumerable<CqlDateTime> be_ = context.Operators.LateBoundProperty<IEnumerable<CqlDateTime>>(bd_, "value");
                    IEnumerable<CqlDateTime> bf_ = context.Operators.ListSort<CqlDateTime>(be_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime bg_ = context.Operators.First<CqlDateTime>(bf_);

                    return bg_;
                };
                IEnumerable<CqlDateTime> v_ = context.Operators.Select<Timing, CqlDateTime>(t_, u_);
                IEnumerable<CqlDateTime> w_ = context.Operators.Distinct<CqlDateTime>(v_);
                IEnumerable<CqlDateTime> x_ = context.Operators.ListSort<CqlDateTime>(w_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime y_ = context.Operators.First<CqlDateTime>(x_);
                CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
                bool? ab_(Dosage @this)
                {
                    Timing bh_ = @this?.Timing;
                    bool? bi_ = context.Operators.Not((bool?)(bh_ is null));

                    return bi_;
                };
                IEnumerable<Dosage> ac_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)p_, ab_);
                Timing ad_(Dosage @this)
                {
                    Timing bj_ = @this?.Timing;

                    return bj_;
                };
                IEnumerable<Timing> ae_ = context.Operators.Select<Dosage, Timing>(ac_, ad_);
                bool? af_(Timing @this)
                {
                    Timing.RepeatComponent bk_ = @this?.Repeat;
                    bool? bl_ = context.Operators.Not((bool?)(bk_ is null));

                    return bl_;
                };
                IEnumerable<Timing> ag_ = context.Operators.Where<Timing>(ae_, af_);
                Timing.RepeatComponent ah_(Timing @this)
                {
                    Timing.RepeatComponent bm_ = @this?.Repeat;

                    return bm_;
                };
                IEnumerable<Timing.RepeatComponent> ai_ = context.Operators.Select<Timing, Timing.RepeatComponent>(ag_, ah_);
                bool? aj_(Timing.RepeatComponent @this)
                {
                    DataType bn_ = @this?.Bounds;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool? bp_ = context.Operators.Not((bool?)(bo_ is null));

                    return bp_;
                };
                IEnumerable<Timing.RepeatComponent> ak_ = context.Operators.Where<Timing.RepeatComponent>(ai_, aj_);
                object al_(Timing.RepeatComponent @this)
                {
                    DataType bq_ = @this?.Bounds;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);

                    return br_;
                };
                IEnumerable<object> am_ = context.Operators.Select<Timing.RepeatComponent, object>(ak_, al_);
                CqlInterval<CqlDateTime> an_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> bs_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return bs_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> ao_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(am_, an_);
                IEnumerable<CqlInterval<CqlDateTime>> ap_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ao_);
                IEnumerable<CqlInterval<CqlDateTime>> aq_ = context.Operators.Collapse(ap_, default);
                object ar_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime bt_ = context.Operators.Start(@this);

                    return bt_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> as_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(aq_, ar_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> at_ = context.Operators.First<CqlInterval<CqlDateTime>>(as_);
                CqlDateTime au_ = context.Operators.Start(z_ ?? at_);
                DataType av_ = FirstBladderCancerStaging?.Performed;
                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                CqlInterval<CqlDateTime> ax_ = QICoreCommon_2_1_000.Instance.toInterval(context, aw_);
                CqlDateTime ay_ = context.Operators.Start(ax_);
                bool? az_ = context.Operators.SameOrBefore(au_, ay_, "day");

                return az_;
            };
            IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)k_, l_);
            MedicationRequest n_(Procedure FirstBladderCancerStaging) =>
                ImmunosuppressiveDrugs;
            IEnumerable<MedicationRequest> o_ = context.Operators.Select<Procedure, MedicationRequest>(m_, n_);

            return o_;
        };
        IEnumerable<MedicationRequest> g_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(e_, f_);
        bool? h_(MedicationRequest ImmunosuppressiveDrugs)
        {
            Code<MedicationRequest.MedicationrequestStatus> bu_ = ImmunosuppressiveDrugs?.StatusElement;
            MedicationRequest.MedicationrequestStatus? bv_ = bu_?.Value;
            string bw_ = context.Operators.Convert<string>(bv_);
            string[] bx_ = [
                "active",
                "completed",
            ];
            bool? by_ = context.Operators.In<string>(bw_, bx_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> bz_ = ImmunosuppressiveDrugs?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ca_ = bz_?.Value;
            string cb_ = context.Operators.Convert<string>(ca_);
            bool? cc_ = context.Operators.Equal(cb_, "order");
            bool? cd_ = context.Operators.And(by_, cc_);

            return cd_;
        };
        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);

        return i_;
    }


    [CqlDeclaration("Cystectomy Done")]
    public IEnumerable<Procedure> Cystectomy_Done(CqlContext context)
    {
        CqlValueSet a_ = this.Cystectomy_for_Urology_Care(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_(Procedure Cystectomy)
        {
            Procedure g_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] h_ = [
                g_,
            ];
            bool? i_(Procedure FirstBladderCancerStaging)
            {
                DataType m_ = Cystectomy?.Performed;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                DataType q_ = FirstBladderCancerStaging?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> s_ = QICoreCommon_2_1_000.Instance.toInterval(context, r_);
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlQuantity u_ = context.Operators.Quantity(6m, "months");
                CqlDateTime v_ = context.Operators.Subtract(t_, u_);
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_2_1_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(v_, z_, true, false);
                bool? ab_ = context.Operators.In<CqlDateTime>(p_, aa_, default);
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_1_000.Instance.toInterval(context, ad_);
                CqlDateTime af_ = context.Operators.Start(ae_);
                bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                bool? ah_ = context.Operators.And(ab_, ag_);

                return ah_;
            };
            IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)h_, i_);
            Procedure k_(Procedure FirstBladderCancerStaging) =>
                Cystectomy;
            IEnumerable<Procedure> l_ = context.Operators.Select<Procedure, Procedure>(j_, k_);

            return l_;
        };
        IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
        bool? e_(Procedure Cystectomy)
        {
            Code<EventStatus> ai_ = Cystectomy?.StatusElement;
            EventStatus? aj_ = ai_?.Value;
            string ak_ = context.Operators.Convert<string>(aj_);
            bool? al_ = context.Operators.Equal(ak_, "completed");

            return al_;
        };
        IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);

        return f_;
    }


    [CqlDeclaration("Has Excluding HIV, Immunocompromised Conditions or Mixed Histology Before Staging")]
    public bool? Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(CqlContext context)
    {
        CqlValueSet a_ = this.HIV(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet c_ = this.Immunocompromised_Conditions(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        CqlValueSet f_ = this.Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
        IEnumerable<Condition> i_(Condition ExclusionDiagnosis)
        {
            Procedure n_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] o_ = [
                n_,
            ];
            bool? p_(Procedure FirstBladderCancerStaging)
            {
                CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime u_ = context.Operators.Start(t_);
                DataType v_ = FirstBladderCancerStaging?.Performed;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                CqlInterval<CqlDateTime> x_ = QICoreCommon_2_1_000.Instance.toInterval(context, w_);
                CqlDateTime y_ = context.Operators.Start(x_);
                bool? z_ = context.Operators.SameOrBefore(u_, y_, "day");

                return z_;
            };
            IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)o_, p_);
            Condition r_(Procedure FirstBladderCancerStaging) =>
                ExclusionDiagnosis;
            IEnumerable<Condition> s_ = context.Operators.Select<Procedure, Condition>(q_, r_);

            return s_;
        };
        IEnumerable<Condition> j_ = context.Operators.SelectMany<Condition, Condition>(h_, i_);
        bool? k_(Condition ExclusionDiagnosis)
        {
            bool? aa_ = this.isConfirmedActiveDiagnosis(context, ExclusionDiagnosis);

            return aa_;
        };
        IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
        bool? m_ = context.Operators.Exists<Condition>(l_);

        return m_;
    }


    [CqlDeclaration("Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging")]
    public bool? Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(CqlContext context)
    {
        CqlValueSet a_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_(MedicationRequest ExclusionMed)
        {
            Procedure s_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] t_ = [
                s_,
            ];
            bool? u_(Procedure FirstBladderCancerStaging)
            {
                List<Dosage> y_ = ExclusionMed?.DosageInstruction;
                bool? z_(Dosage @this)
                {
                    Timing bl_ = @this?.Timing;
                    bool? bm_ = context.Operators.Not((bool?)(bl_ is null));

                    return bm_;
                };
                IEnumerable<Dosage> aa_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)y_, z_);
                Timing ab_(Dosage @this)
                {
                    Timing bn_ = @this?.Timing;

                    return bn_;
                };
                IEnumerable<Timing> ac_ = context.Operators.Select<Dosage, Timing>(aa_, ab_);
                bool? ad_(Timing @this)
                {
                    Timing.RepeatComponent bo_ = @this?.Repeat;
                    bool? bp_ = context.Operators.Not((bool?)(bo_ is null));

                    return bp_;
                };
                IEnumerable<Timing> ae_ = context.Operators.Where<Timing>(ac_, ad_);
                Timing.RepeatComponent af_(Timing @this)
                {
                    Timing.RepeatComponent bq_ = @this?.Repeat;

                    return bq_;
                };
                IEnumerable<Timing.RepeatComponent> ag_ = context.Operators.Select<Timing, Timing.RepeatComponent>(ae_, af_);
                bool? ah_(Timing.RepeatComponent @this)
                {
                    DataType br_ = @this?.Bounds;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    bool? bt_ = context.Operators.Not((bool?)(bs_ is null));

                    return bt_;
                };
                IEnumerable<Timing.RepeatComponent> ai_ = context.Operators.Where<Timing.RepeatComponent>(ag_, ah_);
                object aj_(Timing.RepeatComponent @this)
                {
                    DataType bu_ = @this?.Bounds;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);

                    return bv_;
                };
                IEnumerable<object> ak_ = context.Operators.Select<Timing.RepeatComponent, object>(ai_, aj_);
                CqlInterval<CqlDateTime> al_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> bw_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return bw_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> am_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(ak_, al_);
                IEnumerable<CqlInterval<CqlDateTime>> an_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(am_);
                IEnumerable<CqlInterval<CqlDateTime>> ao_ = context.Operators.Collapse(an_, default);
                object ap_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime bx_ = context.Operators.Start(@this);

                    return bx_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> aq_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(ao_, ap_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> ar_ = context.Operators.First<CqlInterval<CqlDateTime>>(aq_);
                CqlDateTime as_ = context.Operators.Start(ar_);
                DataType at_ = FirstBladderCancerStaging?.Performed;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                CqlInterval<CqlDateTime> av_ = QICoreCommon_2_1_000.Instance.toInterval(context, au_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                CqlQuantity ax_ = context.Operators.Quantity(6m, "months");
                CqlDateTime ay_ = context.Operators.Subtract(aw_, ax_);
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                CqlInterval<CqlDateTime> bb_ = QICoreCommon_2_1_000.Instance.toInterval(context, ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(ay_, bc_, true, false);
                bool? be_ = context.Operators.In<CqlDateTime>(as_, bd_, default);
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                CqlInterval<CqlDateTime> bh_ = QICoreCommon_2_1_000.Instance.toInterval(context, bg_);
                CqlDateTime bi_ = context.Operators.Start(bh_);
                bool? bj_ = context.Operators.Not((bool?)(bi_ is null));
                bool? bk_ = context.Operators.And(be_, bj_);

                return bk_;
            };
            IEnumerable<Procedure> v_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)t_, u_);
            MedicationRequest w_(Procedure FirstBladderCancerStaging) =>
                ExclusionMed;
            IEnumerable<MedicationRequest> x_ = context.Operators.Select<Procedure, MedicationRequest>(v_, w_);

            return x_;
        };
        IEnumerable<MedicationRequest> g_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(e_, f_);
        bool? h_(MedicationRequest ExclusionMed)
        {
            Code<MedicationRequest.MedicationrequestStatus> by_ = ExclusionMed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? bz_ = by_?.Value;
            string ca_ = context.Operators.Convert<string>(bz_);
            string[] cb_ = [
                "active",
                "completed",
            ];
            bool? cc_ = context.Operators.In<string>(ca_, cb_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> cd_ = ExclusionMed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ce_ = cd_?.Value;
            string cf_ = context.Operators.Convert<string>(ce_);
            bool? cg_ = context.Operators.Equal(cf_, "order");
            bool? ch_ = context.Operators.And(cc_, cg_);

            return ch_;
        };
        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        CqlCode j_ = this.Combined_radiotherapy__procedure_(context);
        IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<Procedure> l_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> m_(Procedure ExclusionProcedure)
        {
            Procedure ci_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] cj_ = [
                ci_,
            ];
            bool? ck_(Procedure FirstBladderCancerStaging)
            {
                DataType co_ = ExclusionProcedure?.Performed;
                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                CqlInterval<CqlDateTime> cq_ = QICoreCommon_2_1_000.Instance.toInterval(context, cp_);
                CqlDateTime cr_ = context.Operators.Start(cq_);
                DataType cs_ = FirstBladderCancerStaging?.Performed;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                CqlInterval<CqlDateTime> cu_ = QICoreCommon_2_1_000.Instance.toInterval(context, ct_);
                CqlDateTime cv_ = context.Operators.Start(cu_);
                CqlQuantity cw_ = context.Operators.Quantity(6m, "months");
                CqlDateTime cx_ = context.Operators.Subtract(cv_, cw_);
                object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                CqlInterval<CqlDateTime> da_ = QICoreCommon_2_1_000.Instance.toInterval(context, cz_);
                CqlDateTime db_ = context.Operators.Start(da_);
                CqlInterval<CqlDateTime> dc_ = context.Operators.Interval(cx_, db_, true, false);
                bool? dd_ = context.Operators.In<CqlDateTime>(cr_, dc_, default);
                object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                CqlInterval<CqlDateTime> dg_ = QICoreCommon_2_1_000.Instance.toInterval(context, df_);
                CqlDateTime dh_ = context.Operators.Start(dg_);
                bool? di_ = context.Operators.Not((bool?)(dh_ is null));
                bool? dj_ = context.Operators.And(dd_, di_);

                return dj_;
            };
            IEnumerable<Procedure> cl_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)cj_, ck_);
            Procedure cm_(Procedure FirstBladderCancerStaging) =>
                ExclusionProcedure;
            IEnumerable<Procedure> cn_ = context.Operators.Select<Procedure, Procedure>(cl_, cm_);

            return cn_;
        };
        IEnumerable<Procedure> n_ = context.Operators.SelectMany<Procedure, Procedure>(l_, m_);
        bool? o_(Procedure ExclusionProcedure)
        {
            Code<EventStatus> dk_ = ExclusionProcedure?.StatusElement;
            EventStatus? dl_ = dk_?.Value;
            string dm_ = context.Operators.Convert<string>(dl_);
            bool? dn_ = context.Operators.Equal(dm_, "completed");

            return dn_;
        };
        IEnumerable<Procedure> p_ = context.Operators.Where<Procedure>(n_, o_);
        IEnumerable<object> q_ = context.Operators.Union<object>(i_ as IEnumerable<object>, p_ as IEnumerable<object>);
        bool? r_ = context.Operators.Exists<object>(q_);

        return r_;
    }


    [CqlDeclaration("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Acute_Tuberculosis_Diagnosis(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        IEnumerable<MedicationRequest> c_ = this.Immunosuppressive_Drugs(context);
        bool? d_ = context.Operators.Exists<MedicationRequest>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        IEnumerable<Procedure> f_ = this.Cystectomy_Done(context);
        bool? g_ = context.Operators.Exists<Procedure>(f_);
        bool? h_ = context.Operators.Or(e_, g_);
        bool? i_ = this.Has_Excluding_HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging(context);
        bool? j_ = context.Operators.Or(h_, i_);
        bool? k_ = this.Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(context);
        bool? l_ = context.Operators.Or(j_, k_);

        return l_;
    }


    [CqlDeclaration("Denominator Exception")]
    [CqlTag("commentedOut", "\"BCG Not Available Within 6 Months After Bladder Cancer Staging\"")]
    [CqlTag("commentedOutReason", "Negation issue related to https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455. Due to this being the only logic in this population added 'false' as a placeholder.")]
    public bool? Denominator_Exception(CqlContext context) =>
        false;


    [CqlDeclaration("First BCG Administered")]
    public MedicationAdministration First_BCG_Administered(CqlContext context)
    {
        CqlValueSet a_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
        IEnumerable<MedicationAdministration> f_(MedicationAdministration BCG)
        {
            Procedure m_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] n_ = [
                m_,
            ];
            bool? o_(Procedure FirstBladderCancerStaging)
            {
                DataType s_ = BCG?.Effective;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                CqlInterval<CqlDateTime> u_ = QICoreCommon_2_1_000.Instance.toInterval(context, t_);
                CqlDateTime v_ = context.Operators.Start(u_);
                DataType w_ = FirstBladderCancerStaging?.Performed;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_2_1_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> ac_ = QICoreCommon_2_1_000.Instance.toInterval(context, ab_);
                CqlDateTime ad_ = context.Operators.Start(ac_);
                CqlQuantity ae_ = context.Operators.Quantity(6m, "months");
                CqlDateTime af_ = context.Operators.Add(ad_, ae_);
                CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(z_, af_, false, true);
                bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, default);
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_1_000.Instance.toInterval(context, aj_);
                CqlDateTime al_ = context.Operators.Start(ak_);
                bool? am_ = context.Operators.Not((bool?)(al_ is null));
                bool? an_ = context.Operators.And(ah_, am_);
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_1_000.Instance.toInterval(context, ap_);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                CqlInterval<CqlDateTime> as_ = this.Measurement_Period(context);
                bool? at_ = context.Operators.In<CqlDateTime>(ar_, as_, default);
                bool? au_ = context.Operators.And(an_, at_);

                return au_;
            };
            IEnumerable<Procedure> p_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)n_, o_);
            MedicationAdministration q_(Procedure FirstBladderCancerStaging) =>
                BCG;
            IEnumerable<MedicationAdministration> r_ = context.Operators.Select<Procedure, MedicationAdministration>(p_, q_);

            return r_;
        };
        IEnumerable<MedicationAdministration> g_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(e_, f_);
        bool? h_(MedicationAdministration BCG)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> av_ = BCG?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? aw_ = av_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ax_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(aw_);
            string ay_ = context.Operators.Convert<string>(ax_);
            string[] az_ = [
                "in-progress",
                "completed",
            ];
            bool? ba_ = context.Operators.In<string>(ay_, az_ as IEnumerable<string>);

            return ba_;
        };
        IEnumerable<MedicationAdministration> i_ = context.Operators.Where<MedicationAdministration>(g_, h_);
        object j_(MedicationAdministration @this)
        {
            DataType bb_ = @this?.Effective;
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            CqlInterval<CqlDateTime> bd_ = QICoreCommon_2_1_000.Instance.toInterval(context, bc_);
            CqlDateTime be_ = context.Operators.Start(bd_);

            return be_;
        };
        IEnumerable<MedicationAdministration> k_ = context.Operators.SortBy<MedicationAdministration>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
        MedicationAdministration l_ = context.Operators.First<MedicationAdministration>(k_);

        return l_;
    }


    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        MedicationAdministration a_ = this.First_BCG_Administered(context);
        bool? b_ = context.Operators.Not((bool?)(a_ is null));

        return b_;
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


    [CqlDeclaration("BCG Not Available Within 6 Months After Bladder Cancer Staging")]
    public IEnumerable<MedicationAdministration> BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging(CqlContext context)
    {
        CqlValueSet a_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotadministered"));
        IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotadministered"));
        IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
        IEnumerable<MedicationAdministration> f_(MedicationAdministration BCGNotGiven)
        {
            Procedure j_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] k_ = [
                j_,
            ];
            bool? l_(Procedure FirstBladderCancerStaging)
            {
                bool? p_(Extension @this)
                {
                    string an_ = @this?.Url;
                    FhirString ao_ = context.Operators.Convert<FhirString>(an_);
                    string ap_ = FHIRHelpers_4_4_000.Instance.ToString(context, ao_);
                    bool? aq_ = context.Operators.Equal(ap_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return aq_;
                };
                IEnumerable<Extension> q_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(BCGNotGiven is DomainResource
                        ? (BCGNotGiven as DomainResource).Extension
                        : default), p_);
                DataType r_(Extension @this)
                {
                    DataType ar_ = @this?.Value;

                    return ar_;
                };
                IEnumerable<DataType> s_ = context.Operators.Select<Extension, DataType>(q_, r_);
                DataType t_ = context.Operators.SingletonFrom<DataType>(s_);
                CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
                DataType v_ = FirstBladderCancerStaging?.Performed;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                CqlInterval<CqlDateTime> x_ = QICoreCommon_2_1_000.Instance.toInterval(context, w_);
                CqlDateTime y_ = context.Operators.Start(x_);
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                CqlInterval<CqlDateTime> ab_ = QICoreCommon_2_1_000.Instance.toInterval(context, aa_);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                CqlQuantity ad_ = context.Operators.Quantity(6m, "months");
                CqlDateTime ae_ = context.Operators.Add(ac_, ad_);
                CqlInterval<CqlDateTime> af_ = context.Operators.Interval(y_, ae_, false, true);
                bool? ag_ = context.Operators.In<CqlDateTime>(u_, af_, default);
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                CqlInterval<CqlDateTime> aj_ = QICoreCommon_2_1_000.Instance.toInterval(context, ai_);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                bool? am_ = context.Operators.And(ag_, al_);

                return am_;
            };
            IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)k_, l_);
            MedicationAdministration n_(Procedure FirstBladderCancerStaging) =>
                BCGNotGiven;
            IEnumerable<MedicationAdministration> o_ = context.Operators.Select<Procedure, MedicationAdministration>(m_, n_);

            return o_;
        };
        IEnumerable<MedicationAdministration> g_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(e_, f_);
        bool? h_(MedicationAdministration BCGNotGiven)
        {
            List<CodeableConcept> as_ = BCGNotGiven?.StatusReason;
            CqlConcept at_(CodeableConcept @this)
            {
                CqlConcept ax_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ax_;
            };
            IEnumerable<CqlConcept> au_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)as_, at_);
            CqlValueSet av_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care(context);
            bool? aw_ = context.Operators.ConceptsInValueSet(au_, av_);

            return aw_;
        };
        IEnumerable<MedicationAdministration> i_ = context.Operators.Where<MedicationAdministration>(g_, h_);

        return i_;
    }


    #endregion Definition Methods

}

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.7.0")]
[CqlLibrary("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR", "1.4.000")]
public partial class IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000 : ILibrary, ISingleton<IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000>
{
    private IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000() {}

    public static IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000 Instance { get; } = new();

    #region Library Members
    public string Name => "IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR";
    public string Version => "1.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];
    #endregion Library Members

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
            Procedure d_ = this.First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period(context);
            Procedure[] e_ = [
                d_,
            ];
            bool? f_(Procedure FirstBladderCancerStagingMP)
            {
                Id i_ = FirstBladderCancerStagingMP?.IdElement;
                string j_ = i_?.Value;
                FhirString k_ = StagingReference?.ReferenceElement;
                string l_ = k_?.Value;
                string m_ = QICoreCommon_2_1_000.Instance.getId(context, l_);
                bool? n_ = context.Operators.Equal(j_, m_);

                return n_;
            };
            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)e_, f_);
            Procedure h_ = context.Operators.SingletonFrom<Procedure>(g_);

            return h_;
        };
        IEnumerable<Procedure> c_ = context.Operators.Select<ResourceReference, Procedure>((IEnumerable<ResourceReference>)a_, b_);

        return c_;
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
                    Timing ay_ = @this?.Timing;
                    bool? az_ = context.Operators.Not((bool?)(ay_ is null));

                    return az_;
                };
                IEnumerable<Dosage> r_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)p_, q_);
                Timing s_(Dosage @this)
                {
                    Timing ba_ = @this?.Timing;

                    return ba_;
                };
                IEnumerable<Timing> t_ = context.Operators.Select<Dosage, Timing>(r_, s_);
                CqlDateTime u_(Timing dosageTiming)
                {
                    List<FhirDateTime> bb_ = dosageTiming?.EventElement;
                    IEnumerable<CqlDateTime> bc_ = context.Operators.LateBoundProperty<IEnumerable<CqlDateTime>>(bb_, "value");
                    IEnumerable<CqlDateTime> bd_ = context.Operators.ListSort<CqlDateTime>(bc_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime be_ = context.Operators.First<CqlDateTime>(bd_);

                    return be_;
                };
                IEnumerable<CqlDateTime> v_ = context.Operators.Select<Timing, CqlDateTime>(t_, u_);
                IEnumerable<CqlDateTime> w_ = context.Operators.ListSort<CqlDateTime>(v_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime x_ = context.Operators.First<CqlDateTime>(w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_2_1_000.Instance.toInterval(context, x_ as object);
                bool? aa_(Dosage @this)
                {
                    Timing bf_ = @this?.Timing;
                    bool? bg_ = context.Operators.Not((bool?)(bf_ is null));

                    return bg_;
                };
                IEnumerable<Dosage> ab_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)p_, aa_);
                Timing ac_(Dosage @this)
                {
                    Timing bh_ = @this?.Timing;

                    return bh_;
                };
                IEnumerable<Timing> ad_ = context.Operators.Select<Dosage, Timing>(ab_, ac_);
                bool? ae_(Timing @this)
                {
                    Timing.RepeatComponent bi_ = @this?.Repeat;
                    bool? bj_ = context.Operators.Not((bool?)(bi_ is null));

                    return bj_;
                };
                IEnumerable<Timing> af_ = context.Operators.Where<Timing>(ad_, ae_);
                Timing.RepeatComponent ag_(Timing @this)
                {
                    Timing.RepeatComponent bk_ = @this?.Repeat;

                    return bk_;
                };
                IEnumerable<Timing.RepeatComponent> ah_ = context.Operators.Select<Timing, Timing.RepeatComponent>(af_, ag_);
                bool? ai_(Timing.RepeatComponent @this)
                {
                    DataType bl_ = @this?.Bounds;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool? bn_ = context.Operators.Not((bool?)(bm_ is null));

                    return bn_;
                };
                IEnumerable<Timing.RepeatComponent> aj_ = context.Operators.Where<Timing.RepeatComponent>(ah_, ai_);
                object ak_(Timing.RepeatComponent @this)
                {
                    DataType bo_ = @this?.Bounds;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);

                    return bp_;
                };
                IEnumerable<object> al_ = context.Operators.Select<Timing.RepeatComponent, object>(aj_, ak_);
                CqlInterval<CqlDateTime> am_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> bq_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return bq_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> an_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(al_, am_);
                IEnumerable<CqlInterval<CqlDateTime>> ao_ = context.Operators.Collapse(an_, default);
                object ap_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime br_ = context.Operators.Start(@this);

                    return br_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> aq_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(ao_, ap_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> ar_ = context.Operators.First<CqlInterval<CqlDateTime>>(aq_);
                CqlDateTime as_ = context.Operators.Start(y_ ?? ar_);
                DataType at_ = FirstBladderCancerStaging?.Performed;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                CqlInterval<CqlDateTime> av_ = QICoreCommon_2_1_000.Instance.toInterval(context, au_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                bool? ax_ = context.Operators.SameOrBefore(as_, aw_, "day");

                return ax_;
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
            Code<MedicationRequest.MedicationrequestStatus> bs_ = ImmunosuppressiveDrugs?.StatusElement;
            MedicationRequest.MedicationrequestStatus? bt_ = bs_?.Value;
            string bu_ = context.Operators.Convert<string>(bt_);
            string[] bv_ = [
                "active",
                "completed",
            ];
            bool? bw_ = context.Operators.In<string>(bu_, bv_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> bx_ = ImmunosuppressiveDrugs?.IntentElement;
            MedicationRequest.MedicationRequestIntent? by_ = bx_?.Value;
            string bz_ = context.Operators.Convert<string>(by_);
            bool? ca_ = context.Operators.Equal(bz_, "order");
            bool? cb_ = context.Operators.And(bw_, ca_);

            return cb_;
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
                    Timing bk_ = @this?.Timing;
                    bool? bl_ = context.Operators.Not((bool?)(bk_ is null));

                    return bl_;
                };
                IEnumerable<Dosage> aa_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)y_, z_);
                Timing ab_(Dosage @this)
                {
                    Timing bm_ = @this?.Timing;

                    return bm_;
                };
                IEnumerable<Timing> ac_ = context.Operators.Select<Dosage, Timing>(aa_, ab_);
                bool? ad_(Timing @this)
                {
                    Timing.RepeatComponent bn_ = @this?.Repeat;
                    bool? bo_ = context.Operators.Not((bool?)(bn_ is null));

                    return bo_;
                };
                IEnumerable<Timing> ae_ = context.Operators.Where<Timing>(ac_, ad_);
                Timing.RepeatComponent af_(Timing @this)
                {
                    Timing.RepeatComponent bp_ = @this?.Repeat;

                    return bp_;
                };
                IEnumerable<Timing.RepeatComponent> ag_ = context.Operators.Select<Timing, Timing.RepeatComponent>(ae_, af_);
                bool? ah_(Timing.RepeatComponent @this)
                {
                    DataType bq_ = @this?.Bounds;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool? bs_ = context.Operators.Not((bool?)(br_ is null));

                    return bs_;
                };
                IEnumerable<Timing.RepeatComponent> ai_ = context.Operators.Where<Timing.RepeatComponent>(ag_, ah_);
                object aj_(Timing.RepeatComponent @this)
                {
                    DataType bt_ = @this?.Bounds;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);

                    return bu_;
                };
                IEnumerable<object> ak_ = context.Operators.Select<Timing.RepeatComponent, object>(ai_, aj_);
                CqlInterval<CqlDateTime> al_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> bv_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return bv_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> am_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(ak_, al_);
                IEnumerable<CqlInterval<CqlDateTime>> an_ = context.Operators.Collapse(am_, default);
                object ao_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime bw_ = context.Operators.Start(@this);

                    return bw_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> ap_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(an_, ao_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> aq_ = context.Operators.First<CqlInterval<CqlDateTime>>(ap_);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                DataType as_ = FirstBladderCancerStaging?.Performed;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                CqlInterval<CqlDateTime> au_ = QICoreCommon_2_1_000.Instance.toInterval(context, at_);
                CqlDateTime av_ = context.Operators.Start(au_);
                CqlQuantity aw_ = context.Operators.Quantity(6m, "months");
                CqlDateTime ax_ = context.Operators.Subtract(av_, aw_);
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                CqlInterval<CqlDateTime> ba_ = QICoreCommon_2_1_000.Instance.toInterval(context, az_);
                CqlDateTime bb_ = context.Operators.Start(ba_);
                CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(ax_, bb_, true, false);
                bool? bd_ = context.Operators.In<CqlDateTime>(ar_, bc_, default);
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                CqlInterval<CqlDateTime> bg_ = QICoreCommon_2_1_000.Instance.toInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                bool? bi_ = context.Operators.Not((bool?)(bh_ is null));
                bool? bj_ = context.Operators.And(bd_, bi_);

                return bj_;
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
            Code<MedicationRequest.MedicationrequestStatus> bx_ = ExclusionMed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? by_ = bx_?.Value;
            string bz_ = context.Operators.Convert<string>(by_);
            string[] ca_ = [
                "active",
                "completed",
            ];
            bool? cb_ = context.Operators.In<string>(bz_, ca_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> cc_ = ExclusionMed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? cd_ = cc_?.Value;
            string ce_ = context.Operators.Convert<string>(cd_);
            bool? cf_ = context.Operators.Equal(ce_, "order");
            bool? cg_ = context.Operators.And(cb_, cf_);

            return cg_;
        };
        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        CqlCode j_ = this.Combined_radiotherapy__procedure_(context);
        IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<Procedure> l_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> m_(Procedure ExclusionProcedure)
        {
            Procedure ch_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ci_ = [
                ch_,
            ];
            bool? cj_(Procedure FirstBladderCancerStaging)
            {
                DataType cn_ = ExclusionProcedure?.Performed;
                object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                CqlInterval<CqlDateTime> cp_ = QICoreCommon_2_1_000.Instance.toInterval(context, co_);
                CqlDateTime cq_ = context.Operators.Start(cp_);
                DataType cr_ = FirstBladderCancerStaging?.Performed;
                object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                CqlInterval<CqlDateTime> ct_ = QICoreCommon_2_1_000.Instance.toInterval(context, cs_);
                CqlDateTime cu_ = context.Operators.Start(ct_);
                CqlQuantity cv_ = context.Operators.Quantity(6m, "months");
                CqlDateTime cw_ = context.Operators.Subtract(cu_, cv_);
                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                CqlInterval<CqlDateTime> cz_ = QICoreCommon_2_1_000.Instance.toInterval(context, cy_);
                CqlDateTime da_ = context.Operators.Start(cz_);
                CqlInterval<CqlDateTime> db_ = context.Operators.Interval(cw_, da_, true, false);
                bool? dc_ = context.Operators.In<CqlDateTime>(cq_, db_, default);
                object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                CqlInterval<CqlDateTime> df_ = QICoreCommon_2_1_000.Instance.toInterval(context, de_);
                CqlDateTime dg_ = context.Operators.Start(df_);
                bool? dh_ = context.Operators.Not((bool?)(dg_ is null));
                bool? di_ = context.Operators.And(dc_, dh_);

                return di_;
            };
            IEnumerable<Procedure> ck_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)ci_, cj_);
            Procedure cl_(Procedure FirstBladderCancerStaging) => 
                ExclusionProcedure;
            IEnumerable<Procedure> cm_ = context.Operators.Select<Procedure, Procedure>(ck_, cl_);

            return cm_;
        };
        IEnumerable<Procedure> n_ = context.Operators.SelectMany<Procedure, Procedure>(l_, m_);
        bool? o_(Procedure ExclusionProcedure)
        {
            Code<EventStatus> dj_ = ExclusionProcedure?.StatusElement;
            EventStatus? dk_ = dj_?.Value;
            string dl_ = context.Operators.Convert<string>(dk_);
            bool? dm_ = context.Operators.Equal(dl_, "completed");

            return dm_;
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

}

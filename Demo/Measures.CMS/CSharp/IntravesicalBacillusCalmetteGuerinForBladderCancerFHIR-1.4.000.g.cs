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
[CqlLibrary("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR", "1.4.000")]
public partial class IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000 : ILibrary, ISingleton<IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000>
{
    private IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000() {}

    public static IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR";
    public string Version => "1.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Active Tuberculosis for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56", valueSetVersion: null)]
    public CqlValueSet Active_Tuberculosis_for_Urology_Care(CqlContext _) => _Active_Tuberculosis_for_Urology_Care;
    private static readonly CqlValueSet _Active_Tuberculosis_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56", null);

    [CqlValueSetDefinition("BCG Bacillus Calmette Guerin for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52", valueSetVersion: null)]
    public CqlValueSet BCG_Bacillus_Calmette_Guerin_for_Urology_Care(CqlContext _) => _BCG_Bacillus_Calmette_Guerin_for_Urology_Care;
    private static readonly CqlValueSet _BCG_Bacillus_Calmette_Guerin_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52", null);

    [CqlValueSetDefinition("Bladder Cancer for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45", valueSetVersion: null)]
    public CqlValueSet Bladder_Cancer_for_Urology_Care(CqlContext _) => _Bladder_Cancer_for_Urology_Care;
    private static readonly CqlValueSet _Bladder_Cancer_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45", null);

    [CqlValueSetDefinition("Chemotherapy Agents for Advanced Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60", valueSetVersion: null)]
    public CqlValueSet Chemotherapy_Agents_for_Advanced_Cancer(CqlContext _) => _Chemotherapy_Agents_for_Advanced_Cancer;
    private static readonly CqlValueSet _Chemotherapy_Agents_for_Advanced_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60", null);

    [CqlValueSetDefinition("Cystectomy for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55", valueSetVersion: null)]
    public CqlValueSet Cystectomy_for_Urology_Care(CqlContext _) => _Cystectomy_for_Urology_Care;
    private static readonly CqlValueSet _Cystectomy_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55", null);

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("Immunocompromised Conditions", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940", valueSetVersion: null)]
    public CqlValueSet Immunocompromised_Conditions(CqlContext _) => _Immunocompromised_Conditions;
    private static readonly CqlValueSet _Immunocompromised_Conditions = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940", null);

    [CqlValueSetDefinition("Immunosuppressive Drugs for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32", valueSetVersion: null)]
    public CqlValueSet Immunosuppressive_Drugs_for_Urology_Care(CqlContext _) => _Immunosuppressive_Drugs_for_Urology_Care;
    private static readonly CqlValueSet _Immunosuppressive_Drugs_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32", null);

    [CqlValueSetDefinition("Mixed histology urothelial cell carcinoma for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39", valueSetVersion: null)]
    public CqlValueSet Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care(CqlContext _) => _Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care;
    private static readonly CqlValueSet _Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Unavailability of Bacillus Calmette Guerin for urology care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44", valueSetVersion: null)]
    public CqlValueSet Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care(CqlContext _) => _Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care;
    private static readonly CqlValueSet _Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("American Joint Committee on Cancer cT1 (qualifier value)", codeId: "1228889001", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cT1__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cT1__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cT1__qualifier_value_ = new CqlCode("1228889001", "http://snomed.info/sct");

    [CqlCodeDefinition("American Joint Committee on Cancer cTa (qualifier value)", codeId: "1228883000", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cTa__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cTa__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cTa__qualifier_value_ = new CqlCode("1228883000", "http://snomed.info/sct");

    [CqlCodeDefinition("American Joint Committee on Cancer cTis (qualifier value)", codeId: "1228884006", codeSystem: "http://snomed.info/sct")]
    public CqlCode American_Joint_Committee_on_Cancer_cTis__qualifier_value_(CqlContext _) => _American_Joint_Committee_on_Cancer_cTis__qualifier_value_;
    private static readonly CqlCode _American_Joint_Committee_on_Cancer_cTis__qualifier_value_ = new CqlCode("1228884006", "http://snomed.info/sct");

    [CqlCodeDefinition("Carcinoma in situ of bladder", codeId: "D09.0", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Carcinoma_in_situ_of_bladder(CqlContext _) => _Carcinoma_in_situ_of_bladder;
    private static readonly CqlCode _Carcinoma_in_situ_of_bladder = new CqlCode("D09.0", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Combined radiotherapy (procedure)", codeId: "169331000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Combined_radiotherapy__procedure_(CqlContext _) => _Combined_radiotherapy__procedure_;
    private static readonly CqlCode _Combined_radiotherapy__procedure_ = new CqlCode("169331000", "http://snomed.info/sct");

    [CqlCodeDefinition("Tumor staging (tumor staging)", codeId: "254292007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Tumor_staging__tumor_staging_(CqlContext _) => _Tumor_staging__tumor_staging_;
    private static readonly CqlCode _Tumor_staging__tumor_staging_ = new CqlCode("254292007", "http://snomed.info/sct");

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _American_Joint_Committee_on_Cancer_cT1__qualifier_value_,
          _American_Joint_Committee_on_Cancer_cTa__qualifier_value_,
          _American_Joint_Committee_on_Cancer_cTis__qualifier_value_,
          _Combined_radiotherapy__procedure_,
          _Tumor_staging__tumor_staging_]);

    [CqlCodeSystemDefinition("ICD10CM", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Carcinoma_in_situ_of_bladder]);

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, [
          _virtual]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR-1.4.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
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


    [CqlFunctionDefinition("getStagingProcedure")]
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


    [CqlFunctionDefinition("isConfirmedActiveDiagnosis")]
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


    [CqlExpressionDefinition("Bladder Cancer Diagnosis")]
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


    [CqlExpressionDefinition("First Bladder Cancer Staging Procedure")]
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


    [CqlExpressionDefinition("July 1 of Year Prior to the Measurement Period")]
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


    [CqlExpressionDefinition("June 30 of the Measurement Period")]
    public CqlDateTime June_30_of_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        decimal? d_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime e_ = context.Operators.DateTime(c_, 6, 30, 23, 59, 59, 0, d_);

        return e_;
    }


    [CqlExpressionDefinition("First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period")]
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


    [CqlExpressionDefinition("Has Most Recent Bladder Cancer Tumor Staging is Ta HG, Tis, T1")]
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


    [CqlExpressionDefinition("Has Qualifying Encounter")]
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


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? a_ = this.Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1(context);
        bool? b_ = this.Has_Qualifying_Encounter(context);
        bool? c_ = context.Operators.And(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Acute Tuberculosis Diagnosis")]
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


    [CqlExpressionDefinition("Immunosuppressive Drugs")]
    public IEnumerable<MedicationRequest> Immunosuppressive_Drugs(CqlContext context)
    {
        CqlValueSet a_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> k_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? l_(Medication M)
            {
                object p_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object q_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> r_ = context.Operators.Split((string)q_, "/");
                string s_ = context.Operators.Last<string>(r_);
                bool? t_ = context.Operators.Equal(p_, s_);
                CodeableConcept u_ = M?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                CqlValueSet w_ = this.Immunosuppressive_Drugs_for_Urology_Care(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                bool? y_ = context.Operators.And(t_, x_);

                return y_;
            };
            IEnumerable<Medication> m_ = context.Operators.Where<Medication>(k_, l_);
            MedicationRequest n_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> o_ = context.Operators.Select<Medication, MedicationRequest>(m_, n_);

            return o_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_(MedicationRequest ImmunosuppressiveDrugs)
        {
            Procedure z_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] aa_ = [
                z_,
            ];
            bool? ab_(Procedure FirstBladderCancerStaging)
            {
                List<Dosage> af_ = ImmunosuppressiveDrugs?.DosageInstruction;
                bool? ag_(Dosage @this)
                {
                    Timing bq_ = @this?.Timing;
                    bool? br_ = context.Operators.Not((bool?)(bq_ is null));

                    return br_;
                };
                IEnumerable<Dosage> ah_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)af_, ag_);
                Timing ai_(Dosage @this)
                {
                    Timing bs_ = @this?.Timing;

                    return bs_;
                };
                IEnumerable<Timing> aj_ = context.Operators.Select<Dosage, Timing>(ah_, ai_);
                CqlDateTime ak_(Timing dosageTiming)
                {
                    List<FhirDateTime> bt_ = dosageTiming?.EventElement;
                    string bu_(FhirDateTime @this)
                    {
                        string ca_ = @this?.Value;

                        return ca_;
                    };
                    IEnumerable<string> bv_ = context.Operators.Select<FhirDateTime, string>((IEnumerable<FhirDateTime>)bt_, bu_);
                    CqlDateTime bw_(string @string)
                    {
                        CqlDateTime cb_ = context.Operators.ConvertStringToDateTime(@string);

                        return cb_;
                    };
                    IEnumerable<CqlDateTime> bx_ = context.Operators.Select<string, CqlDateTime>(bv_, bw_);
                    IEnumerable<CqlDateTime> by_ = context.Operators.ListSort<CqlDateTime>(bx_, System.ComponentModel.ListSortDirection.Ascending);
                    CqlDateTime bz_ = context.Operators.First<CqlDateTime>(by_);

                    return bz_;
                };
                IEnumerable<CqlDateTime> al_ = context.Operators.Select<Timing, CqlDateTime>(aj_, ak_);
                IEnumerable<CqlDateTime> am_ = context.Operators.Distinct<CqlDateTime>(al_);
                IEnumerable<CqlDateTime> an_ = context.Operators.ListSort<CqlDateTime>(am_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime ao_ = context.Operators.First<CqlDateTime>(an_);
                CqlInterval<CqlDateTime> ap_ = QICoreCommon_2_1_000.Instance.toInterval(context, ao_ as object);
                bool? ar_(Dosage @this)
                {
                    Timing cc_ = @this?.Timing;
                    bool? cd_ = context.Operators.Not((bool?)(cc_ is null));

                    return cd_;
                };
                IEnumerable<Dosage> as_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)af_, ar_);
                Timing at_(Dosage @this)
                {
                    Timing ce_ = @this?.Timing;

                    return ce_;
                };
                IEnumerable<Timing> au_ = context.Operators.Select<Dosage, Timing>(as_, at_);
                bool? av_(Timing @this)
                {
                    Timing.RepeatComponent cf_ = @this?.Repeat;
                    bool? cg_ = context.Operators.Not((bool?)(cf_ is null));

                    return cg_;
                };
                IEnumerable<Timing> aw_ = context.Operators.Where<Timing>(au_, av_);
                Timing.RepeatComponent ax_(Timing @this)
                {
                    Timing.RepeatComponent ch_ = @this?.Repeat;

                    return ch_;
                };
                IEnumerable<Timing.RepeatComponent> ay_ = context.Operators.Select<Timing, Timing.RepeatComponent>(aw_, ax_);
                bool? az_(Timing.RepeatComponent @this)
                {
                    DataType ci_ = @this?.Bounds;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bool? ck_ = context.Operators.Not((bool?)(cj_ is null));

                    return ck_;
                };
                IEnumerable<Timing.RepeatComponent> ba_ = context.Operators.Where<Timing.RepeatComponent>(ay_, az_);
                object bb_(Timing.RepeatComponent @this)
                {
                    DataType cl_ = @this?.Bounds;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);

                    return cm_;
                };
                IEnumerable<object> bc_ = context.Operators.Select<Timing.RepeatComponent, object>(ba_, bb_);
                CqlInterval<CqlDateTime> bd_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> cn_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return cn_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> be_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bc_, bd_);
                IEnumerable<CqlInterval<CqlDateTime>> bf_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(be_);
                IEnumerable<CqlInterval<CqlDateTime>> bg_ = context.Operators.Collapse(bf_, default);
                object bh_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime co_ = context.Operators.Start(@this);

                    return co_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> bi_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bg_, bh_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> bj_ = context.Operators.First<CqlInterval<CqlDateTime>>(bi_);
                CqlDateTime bk_ = context.Operators.Start(ap_ ?? bj_);
                DataType bl_ = FirstBladderCancerStaging?.Performed;
                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                CqlInterval<CqlDateTime> bn_ = QICoreCommon_2_1_000.Instance.toInterval(context, bm_);
                CqlDateTime bo_ = context.Operators.Start(bn_);
                bool? bp_ = context.Operators.SameOrBefore(bk_, bo_, "day");

                return bp_;
            };
            IEnumerable<Procedure> ac_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)aa_, ab_);
            MedicationRequest ad_(Procedure FirstBladderCancerStaging) =>
                ImmunosuppressiveDrugs;
            IEnumerable<MedicationRequest> ae_ = context.Operators.Select<Procedure, MedicationRequest>(ac_, ad_);

            return ae_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
        bool? i_(MedicationRequest ImmunosuppressiveDrugs)
        {
            Code<MedicationRequest.MedicationrequestStatus> cp_ = ImmunosuppressiveDrugs?.StatusElement;
            MedicationRequest.MedicationrequestStatus? cq_ = cp_?.Value;
            string cr_ = context.Operators.Convert<string>(cq_);
            string[] cs_ = [
                "active",
                "completed",
            ];
            bool? ct_ = context.Operators.In<string>(cr_, cs_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> cu_ = ImmunosuppressiveDrugs?.IntentElement;
            MedicationRequest.MedicationRequestIntent? cv_ = cu_?.Value;
            string cw_ = context.Operators.Convert<string>(cv_);
            bool? cx_ = context.Operators.Equal(cw_, "order");
            bool? cy_ = context.Operators.And(ct_, cx_);

            return cy_;
        };
        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);

        return j_;
    }


    [CqlExpressionDefinition("Cystectomy Done")]
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


    [CqlExpressionDefinition("Has Excluding HIV, Immunocompromised Conditions or Mixed Histology Before Staging")]
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


    [CqlExpressionDefinition("Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging")]
    public bool? Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging(CqlContext context)
    {
        CqlValueSet a_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_(MedicationRequest MR)
        {
            IEnumerable<Medication> t_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? u_(Medication M)
            {
                object y_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object z_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> aa_ = context.Operators.Split((string)z_, "/");
                string ab_ = context.Operators.Last<string>(aa_);
                bool? ac_ = context.Operators.Equal(y_, ab_);
                CodeableConcept ad_ = M?.Code;
                CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ad_);
                CqlValueSet af_ = this.Chemotherapy_Agents_for_Advanced_Cancer(context);
                bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
                bool? ah_ = context.Operators.And(ac_, ag_);

                return ah_;
            };
            IEnumerable<Medication> v_ = context.Operators.Where<Medication>(t_, u_);
            MedicationRequest w_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> x_ = context.Operators.Select<Medication, MedicationRequest>(v_, w_);

            return x_;
        };
        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_(MedicationRequest ExclusionMed)
        {
            Procedure ai_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] aj_ = [
                ai_,
            ];
            bool? ak_(Procedure FirstBladderCancerStaging)
            {
                List<Dosage> ao_ = ExclusionMed?.DosageInstruction;
                bool? ap_(Dosage @this)
                {
                    Timing cb_ = @this?.Timing;
                    bool? cc_ = context.Operators.Not((bool?)(cb_ is null));

                    return cc_;
                };
                IEnumerable<Dosage> aq_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)ao_, ap_);
                Timing ar_(Dosage @this)
                {
                    Timing cd_ = @this?.Timing;

                    return cd_;
                };
                IEnumerable<Timing> as_ = context.Operators.Select<Dosage, Timing>(aq_, ar_);
                bool? at_(Timing @this)
                {
                    Timing.RepeatComponent ce_ = @this?.Repeat;
                    bool? cf_ = context.Operators.Not((bool?)(ce_ is null));

                    return cf_;
                };
                IEnumerable<Timing> au_ = context.Operators.Where<Timing>(as_, at_);
                Timing.RepeatComponent av_(Timing @this)
                {
                    Timing.RepeatComponent cg_ = @this?.Repeat;

                    return cg_;
                };
                IEnumerable<Timing.RepeatComponent> aw_ = context.Operators.Select<Timing, Timing.RepeatComponent>(au_, av_);
                bool? ax_(Timing.RepeatComponent @this)
                {
                    DataType ch_ = @this?.Bounds;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool? cj_ = context.Operators.Not((bool?)(ci_ is null));

                    return cj_;
                };
                IEnumerable<Timing.RepeatComponent> ay_ = context.Operators.Where<Timing.RepeatComponent>(aw_, ax_);
                object az_(Timing.RepeatComponent @this)
                {
                    DataType ck_ = @this?.Bounds;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);

                    return cl_;
                };
                IEnumerable<object> ba_ = context.Operators.Select<Timing.RepeatComponent, object>(ay_, az_);
                CqlInterval<CqlDateTime> bb_(object DoseTime)
                {
                    CqlInterval<CqlDateTime> cm_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                    return cm_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> bc_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(ba_, bb_);
                IEnumerable<CqlInterval<CqlDateTime>> bd_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bc_);
                IEnumerable<CqlInterval<CqlDateTime>> be_ = context.Operators.Collapse(bd_, default);
                object bf_(CqlInterval<CqlDateTime> @this)
                {
                    CqlDateTime cn_ = context.Operators.Start(@this);

                    return cn_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> bg_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(be_, bf_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> bh_ = context.Operators.First<CqlInterval<CqlDateTime>>(bg_);
                CqlDateTime bi_ = context.Operators.Start(bh_);
                DataType bj_ = FirstBladderCancerStaging?.Performed;
                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                CqlInterval<CqlDateTime> bl_ = QICoreCommon_2_1_000.Instance.toInterval(context, bk_);
                CqlDateTime bm_ = context.Operators.Start(bl_);
                CqlQuantity bn_ = context.Operators.Quantity(6m, "months");
                CqlDateTime bo_ = context.Operators.Subtract(bm_, bn_);
                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                CqlInterval<CqlDateTime> br_ = QICoreCommon_2_1_000.Instance.toInterval(context, bq_);
                CqlDateTime bs_ = context.Operators.Start(br_);
                CqlInterval<CqlDateTime> bt_ = context.Operators.Interval(bo_, bs_, true, false);
                bool? bu_ = context.Operators.In<CqlDateTime>(bi_, bt_, default);
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                CqlInterval<CqlDateTime> bx_ = QICoreCommon_2_1_000.Instance.toInterval(context, bw_);
                CqlDateTime by_ = context.Operators.Start(bx_);
                bool? bz_ = context.Operators.Not((bool?)(by_ is null));
                bool? ca_ = context.Operators.And(bu_, bz_);

                return ca_;
            };
            IEnumerable<Procedure> al_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)aj_, ak_);
            MedicationRequest am_(Procedure FirstBladderCancerStaging) =>
                ExclusionMed;
            IEnumerable<MedicationRequest> an_ = context.Operators.Select<Procedure, MedicationRequest>(al_, am_);

            return an_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
        bool? i_(MedicationRequest ExclusionMed)
        {
            Code<MedicationRequest.MedicationrequestStatus> co_ = ExclusionMed?.StatusElement;
            MedicationRequest.MedicationrequestStatus? cp_ = co_?.Value;
            string cq_ = context.Operators.Convert<string>(cp_);
            string[] cr_ = [
                "active",
                "completed",
            ];
            bool? cs_ = context.Operators.In<string>(cq_, cr_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> ct_ = ExclusionMed?.IntentElement;
            MedicationRequest.MedicationRequestIntent? cu_ = ct_?.Value;
            string cv_ = context.Operators.Convert<string>(cu_);
            bool? cw_ = context.Operators.Equal(cv_, "order");
            bool? cx_ = context.Operators.And(cs_, cw_);

            return cx_;
        };
        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
        CqlCode k_ = this.Combined_radiotherapy__procedure_(context);
        IEnumerable<CqlCode> l_ = context.Operators.ToList<CqlCode>(k_);
        IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, l_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> n_(Procedure ExclusionProcedure)
        {
            Procedure cy_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] cz_ = [
                cy_,
            ];
            bool? da_(Procedure FirstBladderCancerStaging)
            {
                DataType de_ = ExclusionProcedure?.Performed;
                object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                CqlInterval<CqlDateTime> dg_ = QICoreCommon_2_1_000.Instance.toInterval(context, df_);
                CqlDateTime dh_ = context.Operators.Start(dg_);
                DataType di_ = FirstBladderCancerStaging?.Performed;
                object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                CqlInterval<CqlDateTime> dk_ = QICoreCommon_2_1_000.Instance.toInterval(context, dj_);
                CqlDateTime dl_ = context.Operators.Start(dk_);
                CqlQuantity dm_ = context.Operators.Quantity(6m, "months");
                CqlDateTime dn_ = context.Operators.Subtract(dl_, dm_);
                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                CqlInterval<CqlDateTime> dq_ = QICoreCommon_2_1_000.Instance.toInterval(context, dp_);
                CqlDateTime dr_ = context.Operators.Start(dq_);
                CqlInterval<CqlDateTime> ds_ = context.Operators.Interval(dn_, dr_, true, false);
                bool? dt_ = context.Operators.In<CqlDateTime>(dh_, ds_, default);
                object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                CqlInterval<CqlDateTime> dw_ = QICoreCommon_2_1_000.Instance.toInterval(context, dv_);
                CqlDateTime dx_ = context.Operators.Start(dw_);
                bool? dy_ = context.Operators.Not((bool?)(dx_ is null));
                bool? dz_ = context.Operators.And(dt_, dy_);

                return dz_;
            };
            IEnumerable<Procedure> db_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)cz_, da_);
            Procedure dc_(Procedure FirstBladderCancerStaging) =>
                ExclusionProcedure;
            IEnumerable<Procedure> dd_ = context.Operators.Select<Procedure, Procedure>(db_, dc_);

            return dd_;
        };
        IEnumerable<Procedure> o_ = context.Operators.SelectMany<Procedure, Procedure>(m_, n_);
        bool? p_(Procedure ExclusionProcedure)
        {
            Code<EventStatus> ea_ = ExclusionProcedure?.StatusElement;
            EventStatus? eb_ = ea_?.Value;
            string ec_ = context.Operators.Convert<string>(eb_);
            bool? ed_ = context.Operators.Equal(ec_, "completed");

            return ed_;
        };
        IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
        IEnumerable<object> r_ = context.Operators.Union<object>(j_ as IEnumerable<object>, q_ as IEnumerable<object>);
        bool? s_ = context.Operators.Exists<object>(r_);

        return s_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
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


    [CqlExpressionDefinition("Denominator Exception")]
    [CqlTag("commentedOut", "\"BCG Not Available Within 6 Months After Bladder Cancer Staging\"")]
    [CqlTag("commentedOutReason", "Negation issue related to https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455. Due to this being the only logic in this population added 'false' as a placeholder.")]
    public bool? Denominator_Exception(CqlContext context) =>
        false;


    [CqlExpressionDefinition("First BCG Administered")]
    public MedicationAdministration First_BCG_Administered(CqlContext context)
    {
        CqlValueSet a_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> c_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> d_(MedicationAdministration MR)
        {
            IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? o_(Medication M)
            {
                object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                string v_ = context.Operators.Last<string>(u_);
                bool? w_ = context.Operators.Equal(s_, v_);
                CodeableConcept x_ = M?.Code;
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                CqlValueSet z_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care(context);
                bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                bool? ab_ = context.Operators.And(w_, aa_);

                return ab_;
            };
            IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
            MedicationAdministration q_(Medication M) =>
                MR;
            IEnumerable<MedicationAdministration> r_ = context.Operators.Select<Medication, MedicationAdministration>(p_, q_);

            return r_;
        };
        IEnumerable<MedicationAdministration> e_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(c_, d_);
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(b_, e_);
        IEnumerable<MedicationAdministration> g_(MedicationAdministration BCG)
        {
            Procedure ac_ = this.First_Bladder_Cancer_Staging_Procedure(context);
            Procedure[] ad_ = [
                ac_,
            ];
            bool? ae_(Procedure FirstBladderCancerStaging)
            {
                DataType ai_ = BCG?.Effective;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_1_000.Instance.toInterval(context, aj_);
                CqlDateTime al_ = context.Operators.Start(ak_);
                DataType am_ = FirstBladderCancerStaging?.Performed;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_1_000.Instance.toInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                CqlInterval<CqlDateTime> as_ = QICoreCommon_2_1_000.Instance.toInterval(context, ar_);
                CqlDateTime at_ = context.Operators.Start(as_);
                CqlQuantity au_ = context.Operators.Quantity(6m, "months");
                CqlDateTime av_ = context.Operators.Add(at_, au_);
                CqlInterval<CqlDateTime> aw_ = context.Operators.Interval(ap_, av_, false, true);
                bool? ax_ = context.Operators.In<CqlDateTime>(al_, aw_, default);
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                CqlInterval<CqlDateTime> ba_ = QICoreCommon_2_1_000.Instance.toInterval(context, az_);
                CqlDateTime bb_ = context.Operators.Start(ba_);
                bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                bool? bd_ = context.Operators.And(ax_, bc_);
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                CqlInterval<CqlDateTime> bg_ = QICoreCommon_2_1_000.Instance.toInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                CqlInterval<CqlDateTime> bi_ = this.Measurement_Period(context);
                bool? bj_ = context.Operators.In<CqlDateTime>(bh_, bi_, default);
                bool? bk_ = context.Operators.And(bd_, bj_);

                return bk_;
            };
            IEnumerable<Procedure> af_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)ad_, ae_);
            MedicationAdministration ag_(Procedure FirstBladderCancerStaging) =>
                BCG;
            IEnumerable<MedicationAdministration> ah_ = context.Operators.Select<Procedure, MedicationAdministration>(af_, ag_);

            return ah_;
        };
        IEnumerable<MedicationAdministration> h_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(f_, g_);
        bool? i_(MedicationAdministration BCG)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bl_ = BCG?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? bm_ = bl_?.Value;
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> bn_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(bm_);
            string bo_ = context.Operators.Convert<string>(bn_);
            string[] bp_ = [
                "in-progress",
                "completed",
            ];
            bool? bq_ = context.Operators.In<string>(bo_, bp_ as IEnumerable<string>);

            return bq_;
        };
        IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(h_, i_);
        object k_(MedicationAdministration @this)
        {
            DataType br_ = @this?.Effective;
            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
            CqlInterval<CqlDateTime> bt_ = QICoreCommon_2_1_000.Instance.toInterval(context, bs_);
            CqlDateTime bu_ = context.Operators.Start(bt_);

            return bu_;
        };
        IEnumerable<MedicationAdministration> l_ = context.Operators.SortBy<MedicationAdministration>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
        MedicationAdministration m_ = context.Operators.First<MedicationAdministration>(l_);

        return m_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        MedicationAdministration a_ = this.First_BCG_Administered(context);
        bool? b_ = context.Operators.Not((bool?)(a_ is null));

        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("BCG Not Available Within 6 Months After Bladder Cancer Staging")]
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
                    FhirUri an_ = @this?.UrlElement;
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


    #endregion Functions and Expressions

}

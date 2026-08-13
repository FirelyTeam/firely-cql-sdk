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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("NCQAPalliativeCare", "1.0.0")]
public partial class NCQAPalliativeCare_1_0_0 : ILibrary, ISingleton<NCQAPalliativeCare_1_0_0>
{
    #region ValueSets (3)

    [CqlValueSetDefinition("Palliative Care Assessment", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Assessment(CqlContext _) => _Palliative_Care_Assessment;
    private static readonly CqlValueSet _Palliative_Care_Assessment = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225", null);

    [CqlValueSetDefinition("Palliative Care Encounter", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext _) => _Palliative_Care_Encounter;
    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450", null);

    [CqlValueSetDefinition("Palliative Care Intervention", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Intervention(CqlContext _) => _Palliative_Care_Intervention;
    private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Encounter for palliative care", codeId: "Z51.5", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Encounter_for_palliative_care(CqlContext _) => _Encounter_for_palliative_care;
    private static readonly CqlCode _Encounter_for_palliative_care = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("ICD-10", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem ICD_10(CqlContext _) => _ICD_10;
    private static readonly CqlCodeSystem _ICD_10 =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Encounter_for_palliative_care]);

    #endregion CodeSystems

    #region Functions and Expressions (1)

    [CqlFunctionDefinition("Palliative Care Overlapping Period")]
    public bool? Palliative_Care_Overlapping_Period(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlValueSet a_ = this.Palliative_Care_Assessment(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation PalliativeAssessment) {
            DataType g_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> h_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, g_);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            CqlDateTime k_ = context.Operators.End(h_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            CqlInterval<CqlDate> m_ = context.Operators.Interval(j_, l_, true, true);
            CqlDateTime n_ = context.Operators.Start(Period);
            CqlDate o_ = context.Operators.DateFrom(n_);
            CqlDateTime p_ = context.Operators.End(Period);
            CqlDate q_ = context.Operators.DateFrom(p_);
            CqlInterval<CqlDate> r_ = context.Operators.Interval(o_, q_, true, true);
            bool? s_ = context.Operators.Overlaps(m_, r_, (string)default);
            return s_;
        }

        bool? d_ = context.Operators.WhereAny<Observation>(b_, c_);
        bool? e_;
        // CQL 'or' (18:3-27:5): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            CqlValueSet t_ = this.Palliative_Care_Encounter(context);
            IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            IEnumerable<Encounter> v_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, u_);

            bool? w_(Encounter PalliativeEncounter) {
                Period y_ = PalliativeEncounter?.Period;
                CqlInterval<CqlDateTime> z_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, y_);
                CqlDateTime aa_ = context.Operators.Start(z_);
                CqlDate ab_ = context.Operators.DateFrom(aa_);
                CqlDateTime ac_ = context.Operators.End(z_);
                CqlDate ad_ = context.Operators.DateFrom(ac_);
                CqlInterval<CqlDate> ae_ = context.Operators.Interval(ab_, ad_, true, true);
                CqlDateTime af_ = context.Operators.Start(Period);
                CqlDate ag_ = context.Operators.DateFrom(af_);
                CqlDateTime ah_ = context.Operators.End(Period);
                CqlDate ai_ = context.Operators.DateFrom(ah_);
                CqlInterval<CqlDate> aj_ = context.Operators.Interval(ag_, ai_, true, true);
                bool? ak_ = context.Operators.Overlaps(ae_, aj_, (string)default);
                return ak_;
            }

            bool? x_ = context.Operators.WhereAny<Encounter>(v_, w_);
            e_ = d_ | x_;
        }
        bool? f_;
        // CQL 'or' (18:3-32:5): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CqlValueSet al_ = this.Palliative_Care_Intervention(context);
            IEnumerable<Procedure> am_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
            IEnumerable<Procedure> an_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, am_);

            bool? ao_(Procedure PalliativeIntervention) {
                DataType aq_ = PalliativeIntervention?.Performed;
                CqlInterval<CqlDateTime> ar_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, aq_);
                CqlDateTime as_ = context.Operators.Start(ar_);
                CqlDate at_ = context.Operators.DateFrom(as_);
                CqlDateTime au_ = context.Operators.End(ar_);
                CqlDate av_ = context.Operators.DateFrom(au_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(at_, av_, true, true);
                CqlDateTime ax_ = context.Operators.Start(Period);
                CqlDate ay_ = context.Operators.DateFrom(ax_);
                CqlDateTime az_ = context.Operators.End(Period);
                CqlDate ba_ = context.Operators.DateFrom(az_);
                CqlInterval<CqlDate> bb_ = context.Operators.Interval(ay_, ba_, true, true);
                bool? bc_ = context.Operators.Overlaps(aw_, bb_, (string)default);
                return bc_;
            }

            bool? ap_ = context.Operators.WhereAny<Procedure>(an_, ao_);
            f_ = e_ | ap_;
        }
        // CQL 'or' (18:3-37:5): right operand skipped when left is true
        if (f_ is true)
        {
            return true;
        }
        else
        {
            CqlCode bd_ = this.Encounter_for_palliative_care(context);
            IEnumerable<CqlCode> be_ = context.Operators.ToList<CqlCode>(bd_);
            IEnumerable<Condition> bf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, be_, "http://hl7.org/fhir/StructureDefinition/Condition"));
            IEnumerable<Condition> bg_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, bf_);

            bool? bh_(Condition PalliativeDiagnosis) {
                CqlInterval<CqlDateTime> bj_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, PalliativeDiagnosis);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlDate bl_ = context.Operators.DateFrom(bk_);
                CqlDateTime bm_ = context.Operators.End(bj_);
                CqlDate bn_ = context.Operators.DateFrom(bm_);
                CqlInterval<CqlDate> bo_ = context.Operators.Interval(bl_, bn_, true, true);
                CqlDateTime bp_ = context.Operators.Start(Period);
                CqlDate bq_ = context.Operators.DateFrom(bp_);
                CqlDateTime br_ = context.Operators.End(Period);
                CqlDate bs_ = context.Operators.DateFrom(br_);
                CqlInterval<CqlDate> bt_ = context.Operators.Interval(bq_, bs_, true, true);
                bool? bu_ = context.Operators.Overlaps(bo_, bt_, (string)default);
                return bu_;
            }

            bool? bi_ = context.Operators.WhereAny<Condition>(bg_, bh_);
            return f_ | bi_;
        }
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private NCQAPalliativeCare_1_0_0() {}

    public static NCQAPalliativeCare_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "NCQAPalliativeCare";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAStatus_1_0_0.Instance];

    #endregion ILibrary Implementation

}

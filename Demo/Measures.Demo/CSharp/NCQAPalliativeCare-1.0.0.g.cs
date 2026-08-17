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
            DataType h_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> i_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlDateTime l_ = context.Operators.End(i_);
            CqlDate m_ = context.Operators.DateFrom(l_);
            CqlInterval<CqlDate> n_ = context.Operators.Interval(k_, m_, true, true);
            CqlDateTime o_ = context.Operators.Start(Period);
            CqlDate p_ = context.Operators.DateFrom(o_);
            CqlDateTime q_ = context.Operators.End(Period);
            CqlDate r_ = context.Operators.DateFrom(q_);
            CqlInterval<CqlDate> s_ = context.Operators.Interval(p_, r_, true, true);
            bool? t_ = context.Operators.Overlaps(n_, s_, (string)default);
            return t_;
        }

        bool? d_ = context.Operators.WhereAny<Observation>(b_, c_);

        CqlBoolean e_() {
            CqlValueSet u_ = this.Palliative_Care_Encounter(context);
            IEnumerable<Encounter> v_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            IEnumerable<Encounter> w_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, v_);

            bool? x_(Encounter PalliativeEncounter) {
                Period z_ = PalliativeEncounter?.Period;
                CqlInterval<CqlDateTime> aa_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, z_);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                CqlDate ac_ = context.Operators.DateFrom(ab_);
                CqlDateTime ad_ = context.Operators.End(aa_);
                CqlDate ae_ = context.Operators.DateFrom(ad_);
                CqlInterval<CqlDate> af_ = context.Operators.Interval(ac_, ae_, true, true);
                CqlDateTime ag_ = context.Operators.Start(Period);
                CqlDate ah_ = context.Operators.DateFrom(ag_);
                CqlDateTime ai_ = context.Operators.End(Period);
                CqlDate aj_ = context.Operators.DateFrom(ai_);
                CqlInterval<CqlDate> ak_ = context.Operators.Interval(ah_, aj_, true, true);
                bool? al_ = context.Operators.Overlaps(af_, ak_, (string)default);
                return al_;
            }

            bool? y_ = context.Operators.WhereAny<Encounter>(w_, x_);
            return y_;
        }


        CqlBoolean f_() {
            CqlValueSet am_ = this.Palliative_Care_Intervention(context);
            IEnumerable<Procedure> an_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
            IEnumerable<Procedure> ao_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, an_);

            bool? ap_(Procedure PalliativeIntervention) {
                DataType ar_ = PalliativeIntervention?.Performed;
                CqlInterval<CqlDateTime> as_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ar_);
                CqlDateTime at_ = context.Operators.Start(as_);
                CqlDate au_ = context.Operators.DateFrom(at_);
                CqlDateTime av_ = context.Operators.End(as_);
                CqlDate aw_ = context.Operators.DateFrom(av_);
                CqlInterval<CqlDate> ax_ = context.Operators.Interval(au_, aw_, true, true);
                CqlDateTime ay_ = context.Operators.Start(Period);
                CqlDate az_ = context.Operators.DateFrom(ay_);
                CqlDateTime ba_ = context.Operators.End(Period);
                CqlDate bb_ = context.Operators.DateFrom(ba_);
                CqlInterval<CqlDate> bc_ = context.Operators.Interval(az_, bb_, true, true);
                bool? bd_ = context.Operators.Overlaps(ax_, bc_, (string)default);
                return bd_;
            }

            bool? aq_ = context.Operators.WhereAny<Procedure>(ao_, ap_);
            return aq_;
        }


        CqlBoolean g_() {
            CqlCode be_ = this.Encounter_for_palliative_care(context);
            IEnumerable<CqlCode> bf_ = context.Operators.ToList<CqlCode>(be_);
            IEnumerable<Condition> bg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, bf_, "http://hl7.org/fhir/StructureDefinition/Condition"));
            IEnumerable<Condition> bh_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, bg_);

            bool? bi_(Condition PalliativeDiagnosis) {
                CqlInterval<CqlDateTime> bk_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, PalliativeDiagnosis);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                CqlDate bm_ = context.Operators.DateFrom(bl_);
                CqlDateTime bn_ = context.Operators.End(bk_);
                CqlDate bo_ = context.Operators.DateFrom(bn_);
                CqlInterval<CqlDate> bp_ = context.Operators.Interval(bm_, bo_, true, true);
                CqlDateTime bq_ = context.Operators.Start(Period);
                CqlDate br_ = context.Operators.DateFrom(bq_);
                CqlDateTime bs_ = context.Operators.End(Period);
                CqlDate bt_ = context.Operators.DateFrom(bs_);
                CqlInterval<CqlDate> bu_ = context.Operators.Interval(br_, bt_, true, true);
                bool? bv_ = context.Operators.Overlaps(bp_, bu_, (string)default);
                return bv_;
            }

            bool? bj_ = context.Operators.WhereAny<Condition>(bh_, bi_);
            return bj_;
        }

        return (bool?)(/* CQL 'or' (18:3-37:5) */ (/* CQL 'or' (18:3-32:5) */ (/* CQL 'or' (18:3-27:5) */ ((CqlBoolean)d_
            || e_())
            || f_())
            || g_()));
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

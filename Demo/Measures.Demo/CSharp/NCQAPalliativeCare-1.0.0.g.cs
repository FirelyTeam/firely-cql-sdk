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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.0.0")]
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
            DataType x_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> y_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            CqlDateTime ab_ = context.Operators.End(y_);
            CqlDate ac_ = context.Operators.DateFrom(ab_);
            CqlInterval<CqlDate> ad_ = context.Operators.Interval(aa_, ac_, true, true);
            CqlDateTime ae_ = context.Operators.Start(Period);
            CqlDate af_ = context.Operators.DateFrom(ae_);
            CqlDateTime ag_ = context.Operators.End(Period);
            CqlDate ah_ = context.Operators.DateFrom(ag_);
            CqlInterval<CqlDate> ai_ = context.Operators.Interval(af_, ah_, true, true);
            bool? aj_ = context.Operators.Overlaps(ad_, ai_, (string)default);
            return aj_;
        }

        bool? d_ = context.Operators.WhereAny<Observation>(b_, c_);
        CqlValueSet e_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> g_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, f_);

        bool? h_(Encounter PalliativeEncounter) {
            Period ak_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> al_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ak_);
            CqlDateTime am_ = context.Operators.Start(al_);
            CqlDate an_ = context.Operators.DateFrom(am_);
            CqlDateTime ao_ = context.Operators.End(al_);
            CqlDate ap_ = context.Operators.DateFrom(ao_);
            CqlInterval<CqlDate> aq_ = context.Operators.Interval(an_, ap_, true, true);
            CqlDateTime ar_ = context.Operators.Start(Period);
            CqlDate as_ = context.Operators.DateFrom(ar_);
            CqlDateTime at_ = context.Operators.End(Period);
            CqlDate au_ = context.Operators.DateFrom(at_);
            CqlInterval<CqlDate> av_ = context.Operators.Interval(as_, au_, true, true);
            bool? aw_ = context.Operators.Overlaps(aq_, av_, (string)default);
            return aw_;
        }

        bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
        bool? j_ = context.Operators.Or(d_, i_);
        CqlValueSet k_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> l_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> m_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, l_);

        bool? n_(Procedure PalliativeIntervention) {
            DataType ax_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> ay_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ax_);
            CqlDateTime az_ = context.Operators.Start(ay_);
            CqlDate ba_ = context.Operators.DateFrom(az_);
            CqlDateTime bb_ = context.Operators.End(ay_);
            CqlDate bc_ = context.Operators.DateFrom(bb_);
            CqlInterval<CqlDate> bd_ = context.Operators.Interval(ba_, bc_, true, true);
            CqlDateTime be_ = context.Operators.Start(Period);
            CqlDate bf_ = context.Operators.DateFrom(be_);
            CqlDateTime bg_ = context.Operators.End(Period);
            CqlDate bh_ = context.Operators.DateFrom(bg_);
            CqlInterval<CqlDate> bi_ = context.Operators.Interval(bf_, bh_, true, true);
            bool? bj_ = context.Operators.Overlaps(bd_, bi_, (string)default);
            return bj_;
        }

        bool? o_ = context.Operators.WhereAny<Procedure>(m_, n_);
        bool? p_ = context.Operators.Or(j_, o_);
        CqlCode q_ = this.Encounter_for_palliative_care(context);
        IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
        IEnumerable<Condition> s_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> t_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, s_);

        bool? u_(Condition PalliativeDiagnosis) {
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

        bool? v_ = context.Operators.WhereAny<Condition>(t_, u_);
        bool? w_ = context.Operators.Or(p_, v_);
        return w_;
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

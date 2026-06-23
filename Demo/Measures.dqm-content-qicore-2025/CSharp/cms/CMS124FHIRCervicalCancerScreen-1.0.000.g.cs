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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
[CqlLibrary("CMS124FHIRCervicalCancerScreen", "1.0.000")]
public partial class CMS124FHIRCervicalCancerScreen_1_0_000 : ILibrary, ISingleton<CMS124FHIRCervicalCancerScreen_1_0_000>
{
    #region ValueSets (10)

    [CqlValueSetDefinition("Congenital or Acquired Absence of Cervix", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", valueSetVersion: null)]
    public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix(CqlContext _) => _Congenital_or_Acquired_Absence_of_Cervix;
    private static readonly CqlValueSet _Congenital_or_Acquired_Absence_of_Cervix = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("HPV Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", valueSetVersion: null)]
    public CqlValueSet HPV_Test(CqlContext _) => _HPV_Test;
    private static readonly CqlValueSet _HPV_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", null);

    [CqlValueSetDefinition("Hysterectomy with No Residual Cervix", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", valueSetVersion: null)]
    public CqlValueSet Hysterectomy_with_No_Residual_Cervix(CqlContext _) => _Hysterectomy_with_No_Residual_Cervix;
    private static readonly CqlValueSet _Hysterectomy_with_No_Residual_Cervix = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Pap Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", valueSetVersion: null)]
    public CqlValueSet Pap_Test(CqlContext _) => _Pap_Test;
    private static readonly CqlValueSet _Pap_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Female (finding)", codeId: "248152002", codeSystem: "http://snomed.info/sct")]
    public CqlCode Female__finding_(CqlContext _) => _Female__finding_;
    private static readonly CqlCode _Female__finding_ = new CqlCode("248152002", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Female__finding_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 1511652639594781759L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS124FHIRCervicalCancerScreen-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (13)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -4895999851045775102L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = -792158103537825060L;

    private IEnumerable<Encounter> Qualifying_Encounters_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        IEnumerable<Encounter> r_ = Status_1_15_000.Instance.isEncounterPerformed(context, q_);

        bool? s_(Encounter ValidEncounters) {
            CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
            Period v_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            bool? x_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(u_, w_, "day");
            return x_;
        }

        IEnumerable<Encounter> t_ = context.Operators.Where<Encounter>(r_, s_);
        return t_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 8256456209375385780L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(24, 64, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);

        List<Extension> k_() {

            bool v_() {
                Patient w_ = this.Patient(context);
                bool x_ = w_ is DomainResource;
                return x_;
            }

            if (v_())
            {
                Patient y_ = this.Patient(context);
                return (y_ as DomainResource).Extension;
            }
            else
            {
                return default;
            };
        }


        bool? l_(Extension @this) {
            FhirUri z_ = @this?.UrlElement;
            string aa_ = FHIRHelpers_4_4_000.Instance.ToString(context, z_);
            bool? ab_ = context.Operators.Equal(aa_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
            return ab_;
        }

        IEnumerable<Extension> m_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(k_()), l_);

        DataType n_(Extension @this) {
            DataType ac_ = @this?.Value;
            return ac_;
        }

        IEnumerable<DataType> o_ = context.Operators.Select<Extension, DataType>(m_, n_);
        DataType p_ = context.Operators.SingletonFrom<DataType>(o_);
        bool? q_ = context.Operators.Equal(p_, "248152002");
        bool? r_ = context.Operators.And(j_, q_);
        IEnumerable<Encounter> s_ = this.Qualifying_Encounters(context);
        bool? t_ = context.Operators.Exists<Encounter>(s_);
        bool? u_ = context.Operators.And(r_, t_);
        return u_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -8321089615732897909L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Absence_of_Cervix, Absence_of_Cervix_Compute);

    private const long _cacheIndex_Absence_of_Cervix = -3917560153211505446L;

    private IEnumerable<object> Absence_of_Cervix_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hysterectomy_with_No_Residual_Cervix(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure NoCervixProcedure) {

            object o_() {

                bool u_() {
                    DataType y_ = NoCervixProcedure?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlDateTime;
                    return aa_;
                }


                bool v_() {
                    DataType ab_ = NoCervixProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    return ad_;
                }


                bool w_() {
                    DataType ae_ = NoCervixProcedure?.Performed;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool ag_ = af_ is CqlQuantity;
                    return ag_;
                }


                bool x_() {
                    DataType ah_ = NoCervixProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlInterval<CqlQuantity>;
                    return aj_;
                }

                if (u_())
                {
                    DataType ak_ = NoCervixProcedure?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    return (al_ as CqlDateTime) as object;
                }
                else if (v_())
                {
                    DataType am_ = NoCervixProcedure?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    return (an_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (w_())
                {
                    DataType ao_ = NoCervixProcedure?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    return (ap_ as CqlQuantity) as object;
                }
                else if (x_())
                {
                    DataType aq_ = NoCervixProcedure?.Performed;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    return (ar_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_());
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            bool? t_ = context.Operators.SameOrBefore(q_, s_, (string)default);
            return t_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        CqlValueSet f_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> j_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition>, i_ as IEnumerable<Condition>);
        IEnumerable<Condition> k_ = Status_1_15_000.Instance.verified(context, j_);

        bool? l_(Condition NoCervixDiagnosis) {
            CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, NoCervixDiagnosis);
            CqlDateTime at_ = context.Operators.Start(as_);
            CqlInterval<CqlDateTime> au_ = this.Measurement_Period(context);
            CqlDateTime av_ = context.Operators.End(au_);
            bool? aw_ = context.Operators.SameOrBefore(at_, av_, (string)default);
            return aw_;
        }

        IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
        IEnumerable<object> n_ = context.Operators.Union<object>(e_ as IEnumerable<object>, m_ as IEnumerable<object>);
        return n_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 8397423169321263989L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        IEnumerable<object> b_ = this.Absence_of_Cervix(context);
        bool? c_ = context.Operators.Exists<object>(b_);
        bool? d_ = context.Operators.Or(a_, c_);
        bool? e_ = PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? f_ = context.Operators.Or(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Cervical_Cytology_Within_3_Years, Cervical_Cytology_Within_3_Years_Compute);

    private const long _cacheIndex_Cervical_Cytology_Within_3_Years = -5531684172433476557L;

    private IEnumerable<Observation> Cervical_Cytology_Within_3_Years_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Pap_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isLaboratoryTestPerformed(context, b_);

        bool? d_(Observation CervicalCytology) {

            object f_() {

                bool t_() {
                    DataType w_ = CervicalCytology?.Effective;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;
                    return y_;
                }


                bool u_() {
                    DataType z_ = CervicalCytology?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                    return ab_;
                }


                bool v_() {
                    DataType ac_ = CervicalCytology?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    return ae_;
                }

                if (t_())
                {
                    DataType af_ = CervicalCytology?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    return (ag_ as CqlDateTime) as object;
                }
                else if (u_())
                {
                    DataType ah_ = CervicalCytology?.Effective;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    return (ai_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (v_())
                {
                    DataType aj_ = CervicalCytology?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    return (ak_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime g_ = QICoreCommon_4_0_000.Instance.latest(context, f_());
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlQuantity j_ = context.Operators.Quantity(2m, "years");
            CqlDateTime k_ = context.Operators.Subtract(i_, j_);
            CqlDateTime m_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime> n_ = context.Operators.Interval(k_, m_, true, true);
            bool? o_ = context.Operators.In<CqlDateTime>(g_, n_, "day");
            DataType p_ = CervicalCytology?.Value;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            bool? r_ = context.Operators.Not((bool?)(q_ is null));
            bool? s_ = context.Operators.And(o_, r_);
            return s_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_HPV_Test_Within_5_Years_for_Women_Age_30_and_Older, HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Compute);

    private const long _cacheIndex_HPV_Test_Within_5_Years_for_Women_Age_30_and_Older = -118581701897792664L;

    private IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.HPV_Test(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isLaboratoryTestPerformed(context, b_);

        bool? d_(Observation HPVTest) {
            Patient f_ = this.Patient(context);
            Date g_ = f_?.BirthDateElement;
            string h_ = g_?.Value;
            CqlDate i_ = context.Operators.ConvertStringToDate(h_);

            object j_() {

                bool ad_() {
                    DataType ag_ = HPVTest?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;
                    return ai_;
                }


                bool ae_() {
                    DataType aj_ = HPVTest?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlInterval<CqlDateTime>;
                    return al_;
                }


                bool af_() {
                    DataType am_ = HPVTest?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlDateTime;
                    return ao_;
                }

                if (ad_())
                {
                    DataType ap_ = HPVTest?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    return (aq_ as CqlDateTime) as object;
                }
                else if (ae_())
                {
                    DataType ar_ = HPVTest?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return (as_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (af_())
                {
                    DataType at_ = HPVTest?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return (au_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.latest(context, j_());
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 30);

            object o_() {

                bool av_() {
                    DataType ay_ = HPVTest?.Effective;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    bool ba_ = az_ is CqlDateTime;
                    return ba_;
                }


                bool aw_() {
                    DataType bb_ = HPVTest?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                    return bd_;
                }


                bool ax_() {
                    DataType be_ = HPVTest?.Effective;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlDateTime;
                    return bg_;
                }

                if (av_())
                {
                    DataType bh_ = HPVTest?.Effective;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    return (bi_ as CqlDateTime) as object;
                }
                else if (aw_())
                {
                    DataType bj_ = HPVTest?.Effective;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    return (bk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ax_())
                {
                    DataType bl_ = HPVTest?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    return (bm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.latest(context, o_());
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            CqlDateTime r_ = context.Operators.Start(q_);
            CqlQuantity s_ = context.Operators.Quantity(4m, "years");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            CqlDateTime v_ = context.Operators.End(q_);
            CqlInterval<CqlDateTime> w_ = context.Operators.Interval(t_, v_, true, true);
            bool? x_ = context.Operators.In<CqlDateTime>(p_, w_, "day");
            bool? y_ = context.Operators.And(n_, x_);
            DataType z_ = HPVTest?.Value;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
            bool? ac_ = context.Operators.And(y_, ab_);
            return ac_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 4895448950099818180L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Cervical_Cytology_Within_3_Years(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        IEnumerable<Observation> c_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
        bool? d_ = context.Operators.Exists<Observation>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        return e_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 7539092227377898168L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 8209766477456432771L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 1758581210130800579L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -3263098327827404872L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS124FHIRCervicalCancerScreen_1_0_000() {}

    public static CMS124FHIRCervicalCancerScreen_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS124FHIRCervicalCancerScreen";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, Hospice_6_18_000.Instance, PalliativeCare_1_18_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

}

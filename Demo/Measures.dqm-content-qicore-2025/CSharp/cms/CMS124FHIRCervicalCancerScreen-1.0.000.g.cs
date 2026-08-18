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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.4.0")]
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
            CqlBoolean x_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(u_, w_, "day");
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
        CqlBoolean j_ = context.Operators.In<int?>(h_, i_, (string)default);

        CqlBoolean k_() {
            List<Extension> m_;
            Patient s_ = this.Patient(context);
            bool t_ = s_ is DomainResource;
            if (t_)
            {
                m_ = (s_ as DomainResource).Extension;
            }
            else
            {
                m_ = default;
            }

            bool? n_(Extension @this) {
                FhirUri u_ = @this?.UrlElement;
                string v_ = FHIRHelpers_4_4_000.Instance.ToString(context, u_);
                CqlBoolean w_ = context.Operators.Equal(v_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                return w_;
            }


            DataType o_(Extension @this) {
                DataType x_ = @this?.Value;
                return x_;
            }

            IEnumerable<DataType> p_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)m_, n_, o_);
            DataType q_ = context.Operators.SingletonFrom<DataType>(p_);
            CqlBoolean r_ = context.Operators.Equal(q_, "248152002");
            return r_;
        }


        CqlBoolean l_() {
            IEnumerable<Encounter> y_ = this.Qualifying_Encounters(context);
            CqlBoolean z_ = context.Operators.Exists<Encounter>(y_);
            return z_;
        }

        return /* CQL 'and' (33:3-37:38) */ (/* CQL 'and' (33:3-36:33) */ (j_
            && k_())
            && l_());
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -8321089615732897909L;

    private bool? Denominator_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Initial_Population(context);
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
            object n_;
            DataType t_ = NoCervixProcedure?.Performed;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            bool v_ = u_ is CqlDateTime;
            if (v_)
            {
                n_ = u_ as CqlDateTime;
            }
            else
            {
                bool w_ = u_ is CqlQuantity;
                if (w_)
                {
                    n_ = u_ as CqlQuantity;
                }
                else
                {
                    bool x_ = u_ is CqlInterval<CqlDateTime>;
                    if (x_)
                    {
                        n_ = u_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool y_ = u_ is CqlInterval<CqlQuantity>;
                        if (y_)
                        {
                            n_ = u_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            n_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
            CqlDateTime p_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlBoolean s_ = context.Operators.SameOrBefore(p_, r_, (string)default);
            return s_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        CqlValueSet f_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> i_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition>, h_ as IEnumerable<Condition>);
        IEnumerable<Condition> j_ = Status_1_15_000.Instance.verified(context, i_);

        bool? k_(Condition NoCervixDiagnosis) {
            CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, NoCervixDiagnosis);
            CqlDateTime aa_ = context.Operators.Start(z_);
            CqlInterval<CqlDateTime> ab_ = this.Measurement_Period(context);
            CqlDateTime ac_ = context.Operators.End(ab_);
            CqlBoolean ad_ = context.Operators.SameOrBefore(aa_, ac_, (string)default);
            return ad_;
        }

        IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
        IEnumerable<object> m_ = context.Operators.Union<object>(e_ as IEnumerable<object>, l_ as IEnumerable<object>);
        return m_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 8397423169321263989L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        CqlBoolean a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);

        CqlBoolean b_() {
            IEnumerable<object> c_ = this.Absence_of_Cervix(context);
            CqlBoolean d_ = context.Operators.Exists<object>(c_);
            return d_;
        }

        return /* CQL 'or' (53:3-55:69) */ (/* CQL 'or' (53:3-54:33) */ (a_
            || b_())
            || PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context));
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
            object f_;
            DataType p_ = CervicalCytology?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            bool r_ = q_ is CqlDateTime;
            if (r_)
            {
                f_ = q_ as CqlDateTime;
            }
            else
            {
                if (r_)
                {
                    f_ = q_ as CqlDateTime;
                }
                else
                {
                    bool s_ = q_ is CqlInterval<CqlDateTime>;
                    if (s_)
                    {
                        f_ = q_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        f_ = null;
                    }
                }
            }
            CqlDateTime g_ = QICoreCommon_4_0_000.Instance.latest(context, f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlQuantity j_ = context.Operators.Quantity(2m, "years");
            CqlDateTime k_ = context.Operators.Subtract(i_, j_);
            CqlDateTime l_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime> m_ = context.Operators.Interval(k_, l_, true, true);
            CqlBoolean n_ = context.Operators.In<CqlDateTime>(g_, m_, "day");

            CqlBoolean o_() {
                DataType t_ = CervicalCytology?.Value;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                return !((bool?)(u_ is null));
            }

            return /* CQL 'and' (73:5-74:44) */ (n_
                && o_());
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
            object j_;
            DataType q_ = HPVTest?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {
                j_ = r_ as CqlDateTime;
            }
            else
            {
                if (s_)
                {
                    j_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlInterval<CqlDateTime>;
                    if (t_)
                    {
                        j_ = r_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        j_ = null;
                    }
                }
            }
            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.latest(context, j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
            CqlBoolean n_ = context.Operators.GreaterOrEqual(m_, 30);

            CqlBoolean o_() {
                object u_;
                DataType ad_ = HPVTest?.Effective;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlDateTime;
                if (af_)
                {
                    u_ = ae_ as CqlDateTime;
                }
                else
                {
                    if (af_)
                    {
                        u_ = ae_ as CqlDateTime;
                    }
                    else
                    {
                        bool ag_ = ae_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            u_ = ae_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            u_ = null;
                        }
                    }
                }
                CqlDateTime v_ = QICoreCommon_4_0_000.Instance.latest(context, u_);
                CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
                CqlDateTime x_ = context.Operators.Start(w_);
                CqlQuantity y_ = context.Operators.Quantity(4m, "years");
                CqlDateTime z_ = context.Operators.Subtract(x_, y_);
                CqlDateTime aa_ = context.Operators.End(w_);
                CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(z_, aa_, true, true);
                CqlBoolean ac_ = context.Operators.In<CqlDateTime>(v_, ab_, "day");
                return ac_;
            }


            CqlBoolean p_() {
                DataType ah_ = HPVTest?.Value;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                return !((bool?)(ai_ is null));
            }

            return /* CQL 'and' (78:5-80:35) */ (/* CQL 'and' (78:11-79:131) */ (n_
                && o_())
                && p_());
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
        CqlBoolean b_ = context.Operators.Exists<Observation>(a_);

        CqlBoolean c_() {
            IEnumerable<Observation> d_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
            CqlBoolean e_ = context.Operators.Exists<Observation>(d_);
            return e_;
        }

        return /* CQL 'or' (58:3-59:66) */ (b_
            || c_());
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

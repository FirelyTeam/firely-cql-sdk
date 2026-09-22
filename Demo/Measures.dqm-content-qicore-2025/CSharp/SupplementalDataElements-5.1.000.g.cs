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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.4.0")]
[CqlLibrary("SupplementalDataElements", "5.1.000")]
public partial class SupplementalDataElements_5_1_000 : ILibrary, ISingleton<SupplementalDataElements_5_1_000>
{
    #region ValueSets (4)

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("Federal Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1021.121", valueSetVersion: null)]
    public CqlValueSet Federal_Administrative_Sex(CqlContext _) => _Federal_Administrative_Sex;
    private static readonly CqlValueSet _Federal_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1021.121", null);

    [CqlValueSetDefinition("Payer Type", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext _) => _Payer_Type;
    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    #endregion ValueSets

    #region Codes (2)

    [CqlCodeDefinition("Male (finding)", codeId: "248153007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Male__finding_(CqlContext _) => _Male__finding_;
    private static readonly CqlCode _Male__finding_ = new CqlCode("248153007", "http://snomed.info/sct");

    [CqlCodeDefinition("Female (finding)", codeId: "248152002", codeSystem: "http://snomed.info/sct")]
    public CqlCode Female__finding_(CqlContext _) => _Female__finding_;
    private static readonly CqlCode _Female__finding_ = new CqlCode("248152002", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Male__finding_,
          _Female__finding_]);

    #endregion CodeSystems

    #region Functions and Expressions (5)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 641761058615526661L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 5036509334694701448L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        List<Extension> b_ = a_?.Extension;

        bool? c_(Extension @this) {
            FhirUri j_ = @this?.UrlElement;
            string k_ = FHIRHelpers_4_4_000.Instance.ToString(context, j_);
            bool? l_ = context.Operators.Equal(k_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");
            return l_;
        }

        IEnumerable<Extension> d_ = context.Operators.Where<Extension>((IEnumerable<Extension>)b_, c_);
        Extension e_ = context.Operators.SingletonFrom<Extension>(d_);
        Extension[] f_ = [
            e_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? g_(Extension E) {
            List<Extension> m_ = E?.Extension;

            bool? n_(Extension @this) {
                FhirUri ae_ = @this?.UrlElement;
                string af_ = FHIRHelpers_4_4_000.Instance.ToString(context, ae_);
                bool? ag_ = context.Operators.Equal(af_, "ombCategory");
                return ag_;
            }


            object o_(Extension @this) {
                DataType ah_ = @this?.Value;
                return ah_;
            }

            IEnumerable<object> p_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, n_, o_);
            object q_ = context.Operators.SingletonFrom<object>(p_);
            CqlCode r_ = FHIRHelpers_4_4_000.Instance.ToCode(context, q_ as Coding);
            CqlCode[] s_ = [
                r_,
            ];

            bool? t_(Extension @this) {
                FhirUri ai_ = @this?.UrlElement;
                string aj_ = FHIRHelpers_4_4_000.Instance.ToString(context, ai_);
                bool? ak_ = context.Operators.Equal(aj_, "detailed");
                return ak_;
            }


            object u_(Extension @this) {
                DataType al_ = @this?.Value;
                return al_;
            }

            IEnumerable<object> v_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, t_, u_);

            CqlCode w_(object @this) {
                CqlCode am_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return am_;
            }

            IEnumerable<CqlCode> x_ = context.Operators.Select<object, CqlCode>(v_, w_);
            IEnumerable<CqlCode> y_ = context.Operators.ValueSetUnion((IEnumerable<CqlCode>)s_, x_);

            bool? z_(Extension @this) {
                FhirUri an_ = @this?.UrlElement;
                string ao_ = FHIRHelpers_4_4_000.Instance.ToString(context, an_);
                bool? ap_ = context.Operators.Equal(ao_, "text");
                return ap_;
            }


            object aa_(Extension @this) {
                DataType aq_ = @this?.Value;
                return aq_ switch
                {
                    Uuid ar_ => ar_.Value,
                    Oid as_ => as_.Value,
                    Markdown at_ => at_.Value,
                    Integer au_ => au_.Value,
                    Instant av_ => context.Operators.Convert<CqlDateTime>(av_.Value),
                    Id aw_ => aw_.Value,
                    Duration ax_ => ax_.ValueElement,
                    Distance ay_ => ay_.ValueElement,
                    FhirDecimal az_ => az_.Value,
                    Date ba_ => context.Operators.ConvertStringToDate(ba_.Value),
                    Count bb_ => bb_.ValueElement,
                    FhirDateTime bc_ => context.Operators.Convert<CqlDateTime>(bc_),
                    Time bd_ => context.Operators.ConvertStringToTime(bd_.Value),
                    Age be_ => be_.ValueElement,
                    FhirUrl bf_ => bf_.Value,
                    FhirUri bg_ => bg_.Value,
                    Base64Binary bh_ => context.Operators.Convert<string>(bh_.Value),
                    FhirBoolean bi_ => bi_.Value,
                    FhirString bj_ => bj_.Value,
                    PositiveInt bk_ => bk_.Value,
                    Code bl_ => bl_.Value,
                    UnsignedInt bm_ => bm_.Value,
                    Canonical bn_ => bn_.Value,
                    Quantity bo_ => bo_.ValueElement,
                    Identifier bp_ => bp_.ValueElement,
                    Money bq_ => bq_.ValueElement,
                    UsageContext br_ => br_.Value,
                    ContactPoint bs_ => bs_.ValueElement,
                    _ => null,
                };
            }

            IEnumerable<object> ab_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, z_, aa_);
            object ac_ = context.Operators.SingletonFrom<object>(ab_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ad_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, y_, (string)ac_);
            return ad_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> h_ = context.Operators.SelectDistinct<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)f_, g_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(h_);
        return i_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 3374191463006709211L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Payer_Type(context);
        IEnumerable<Coverage> b_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));

        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? c_(Coverage Payer) {
            CodeableConcept e_ = Payer?.Type;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            Period g_ = Payer?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? i_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, f_, h_);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> d_ = context.Operators.SelectDistinct<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 8821701969343059556L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        List<Extension> b_ = a_?.Extension;

        bool? c_(Extension @this) {
            FhirUri j_ = @this?.UrlElement;
            string k_ = FHIRHelpers_4_4_000.Instance.ToString(context, j_);
            bool? l_ = context.Operators.Equal(k_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");
            return l_;
        }

        IEnumerable<Extension> d_ = context.Operators.Where<Extension>((IEnumerable<Extension>)b_, c_);
        Extension e_ = context.Operators.SingletonFrom<Extension>(d_);
        Extension[] f_ = [
            e_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? g_(Extension R) {
            List<Extension> m_ = R?.Extension;

            bool? n_(Extension @this) {
                FhirUri ad_ = @this?.UrlElement;
                string ae_ = FHIRHelpers_4_4_000.Instance.ToString(context, ad_);
                bool? af_ = context.Operators.Equal(ae_, "ombCategory");
                return af_;
            }


            object o_(Extension @this) {
                DataType ag_ = @this?.Value;
                return ag_;
            }

            IEnumerable<object> p_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, n_, o_);

            CqlCode q_(object @this) {
                CqlCode ah_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return ah_;
            }

            IEnumerable<CqlCode> r_ = context.Operators.Select<object, CqlCode>(p_, q_);

            bool? s_(Extension @this) {
                FhirUri ai_ = @this?.UrlElement;
                string aj_ = FHIRHelpers_4_4_000.Instance.ToString(context, ai_);
                bool? ak_ = context.Operators.Equal(aj_, "detailed");
                return ak_;
            }


            object t_(Extension @this) {
                DataType al_ = @this?.Value;
                return al_;
            }

            IEnumerable<object> u_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, s_, t_);

            CqlCode v_(object @this) {
                CqlCode am_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return am_;
            }

            IEnumerable<CqlCode> w_ = context.Operators.Select<object, CqlCode>(u_, v_);
            IEnumerable<CqlCode> x_ = context.Operators.ValueSetUnion(r_, w_);

            bool? y_(Extension @this) {
                FhirUri an_ = @this?.UrlElement;
                string ao_ = FHIRHelpers_4_4_000.Instance.ToString(context, an_);
                bool? ap_ = context.Operators.Equal(ao_, "text");
                return ap_;
            }


            object z_(Extension @this) {
                DataType aq_ = @this?.Value;
                return aq_ switch
                {
                    Uuid ar_ => ar_.Value,
                    Oid as_ => as_.Value,
                    Markdown at_ => at_.Value,
                    Integer au_ => au_.Value,
                    Instant av_ => context.Operators.Convert<CqlDateTime>(av_.Value),
                    Id aw_ => aw_.Value,
                    Duration ax_ => ax_.ValueElement,
                    Distance ay_ => ay_.ValueElement,
                    FhirDecimal az_ => az_.Value,
                    Date ba_ => context.Operators.ConvertStringToDate(ba_.Value),
                    Count bb_ => bb_.ValueElement,
                    FhirDateTime bc_ => context.Operators.Convert<CqlDateTime>(bc_),
                    Time bd_ => context.Operators.ConvertStringToTime(bd_.Value),
                    Age be_ => be_.ValueElement,
                    FhirUrl bf_ => bf_.Value,
                    FhirUri bg_ => bg_.Value,
                    Base64Binary bh_ => context.Operators.Convert<string>(bh_.Value),
                    FhirBoolean bi_ => bi_.Value,
                    FhirString bj_ => bj_.Value,
                    PositiveInt bk_ => bk_.Value,
                    Code bl_ => bl_.Value,
                    UnsignedInt bm_ => bm_.Value,
                    Canonical bn_ => bn_.Value,
                    Quantity bo_ => bo_.ValueElement,
                    Identifier bp_ => bp_.ValueElement,
                    Money bq_ => bq_.ValueElement,
                    UsageContext br_ => br_.Value,
                    ContactPoint bs_ => bs_.ValueElement,
                    _ => null,
                };
            }

            IEnumerable<object> aa_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, y_, z_);
            object ab_ = context.Operators.SingletonFrom<object>(aa_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ac_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, x_, (string)ab_);
            return ac_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> h_ = context.Operators.SelectDistinct<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)f_, g_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(h_);
        return i_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -9150227342082415267L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        List<Extension> b_ = a_?.Extension;

        bool? c_(Extension @this) {
            FhirUri h_ = @this?.UrlElement;
            string i_ = FHIRHelpers_4_4_000.Instance.ToString(context, h_);
            bool? j_ = context.Operators.Equal(i_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
            return j_;
        }


        object d_(Extension @this) {
            DataType k_ = @this?.Value;
            return k_ switch
            {
                Uuid l_ => l_.Value,
                Oid m_ => m_.Value,
                Markdown n_ => n_.Value,
                Integer o_ => o_.Value,
                Instant p_ => context.Operators.Convert<CqlDateTime>(p_.Value),
                Id q_ => q_.Value,
                Duration r_ => r_.ValueElement,
                Distance s_ => s_.ValueElement,
                FhirDecimal t_ => t_.Value,
                Date u_ => context.Operators.ConvertStringToDate(u_.Value),
                Count v_ => v_.ValueElement,
                FhirDateTime w_ => context.Operators.Convert<CqlDateTime>(w_),
                Time x_ => context.Operators.ConvertStringToTime(x_.Value),
                Age y_ => y_.ValueElement,
                FhirUrl z_ => z_.Value,
                FhirUri aa_ => aa_.Value,
                Base64Binary ab_ => context.Operators.Convert<string>(ab_.Value),
                FhirBoolean ac_ => ac_.Value,
                FhirString ad_ => ad_.Value,
                PositiveInt ae_ => ae_.Value,
                Code af_ => af_.Value,
                UnsignedInt ag_ => ag_.Value,
                Canonical ah_ => ah_.Value,
                Quantity ai_ => ai_.ValueElement,
                Identifier aj_ => aj_.ValueElement,
                Money ak_ => ak_.ValueElement,
                UsageContext al_ => al_.Value,
                ContactPoint am_ => am_.ValueElement,
                _ => null,
            };
        }

        IEnumerable<object> e_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)b_, c_, d_);
        object f_ = context.Operators.SingletonFrom<object>(e_);
        bool? g_ = context.Operators.Equal(f_, "248153007");
        if (g_ ?? false)
        {
            CqlCode an_ = this.Male__finding_(context);
            return an_;
        }
        else
        {
            Patient ao_ = this.Patient(context);
            List<Extension> ap_ = ao_?.Extension;

            bool? aq_(Extension @this) {
                FhirUri av_ = @this?.UrlElement;
                string aw_ = FHIRHelpers_4_4_000.Instance.ToString(context, av_);
                bool? ax_ = context.Operators.Equal(aw_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                return ax_;
            }


            object ar_(Extension @this) {
                DataType ay_ = @this?.Value;
                return ay_ switch
                {
                    Uuid az_ => az_.Value,
                    Oid ba_ => ba_.Value,
                    Markdown bb_ => bb_.Value,
                    Integer bc_ => bc_.Value,
                    Instant bd_ => context.Operators.Convert<CqlDateTime>(bd_.Value),
                    Id be_ => be_.Value,
                    Duration bf_ => bf_.ValueElement,
                    Distance bg_ => bg_.ValueElement,
                    FhirDecimal bh_ => bh_.Value,
                    Date bi_ => context.Operators.ConvertStringToDate(bi_.Value),
                    Count bj_ => bj_.ValueElement,
                    FhirDateTime bk_ => context.Operators.Convert<CqlDateTime>(bk_),
                    Time bl_ => context.Operators.ConvertStringToTime(bl_.Value),
                    Age bm_ => bm_.ValueElement,
                    FhirUrl bn_ => bn_.Value,
                    FhirUri bo_ => bo_.Value,
                    Base64Binary bp_ => context.Operators.Convert<string>(bp_.Value),
                    FhirBoolean bq_ => bq_.Value,
                    FhirString br_ => br_.Value,
                    PositiveInt bs_ => bs_.Value,
                    Code bt_ => bt_.Value,
                    UnsignedInt bu_ => bu_.Value,
                    Canonical bv_ => bv_.Value,
                    Quantity bw_ => bw_.ValueElement,
                    Identifier bx_ => bx_.ValueElement,
                    Money by_ => by_.ValueElement,
                    UsageContext bz_ => bz_.Value,
                    ContactPoint ca_ => ca_.ValueElement,
                    _ => null,
                };
            }

            IEnumerable<object> as_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)ap_, aq_, ar_);
            object at_ = context.Operators.SingletonFrom<object>(as_);
            bool? au_ = context.Operators.Equal(at_, "248152002");
            if (au_ ?? false)
            {
                CqlCode cb_ = this.Female__finding_(context);
                return cb_;
            }
            else
            {
                return default;
            }
        }
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private SupplementalDataElements_5_1_000() {}

    public static SupplementalDataElements_5_1_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "SupplementalDataElements";
    public string Version => "5.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ = new(
       [typeof(CqlConcept), typeof(CqlInterval<CqlDateTime>)],
       ["code", "period"]);

    private static CqlTupleMetadata CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR = new(
       [typeof(IEnumerable<CqlCode>), typeof(string)],
       ["codes", "display"]);

    #endregion CqlTupleMetadata Properties

}

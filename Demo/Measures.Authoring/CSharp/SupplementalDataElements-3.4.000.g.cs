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
[CqlLibrary("SupplementalDataElements", "3.4.000")]
public partial class SupplementalDataElements_3_4_000 : ILibrary, ISingleton<SupplementalDataElements_3_4_000>
{
    #region ValueSets (4)

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("ONC Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext _) => _ONC_Administrative_Sex;
    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlValueSetDefinition("Payer Type", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext _) => _Payer_Type;
    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    #endregion ValueSets

    #region Functions and Expressions (5)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 4263348478441094468L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -5377255478558118731L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        List<Extension> b_ = a_?.Extension;

        bool? c_(Extension @this) {
            FhirUri j_ = @this?.UrlElement;
            string k_ = FHIRHelpers_4_3_000.Instance.ToString(context, j_);
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
                string af_ = FHIRHelpers_4_3_000.Instance.ToString(context, ae_);
                bool? ag_ = context.Operators.Equal(af_, "ombCategory");
                return ag_;
            }


            object o_(Extension @this) {
                DataType ah_ = @this?.Value;
                return ah_;
            }

            IEnumerable<object> p_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, n_, o_);
            object q_ = context.Operators.SingletonFrom<object>(p_);
            CqlCode r_ = FHIRHelpers_4_3_000.Instance.ToCode(context, q_ as Coding);
            CqlCode[] s_ = [
                r_,
            ];

            bool? t_(Extension @this) {
                FhirUri ai_ = @this?.UrlElement;
                string aj_ = FHIRHelpers_4_3_000.Instance.ToString(context, ai_);
                bool? ak_ = context.Operators.Equal(aj_, "detailed");
                return ak_;
            }


            object u_(Extension @this) {
                DataType al_ = @this?.Value;
                return al_;
            }

            IEnumerable<object> v_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, t_, u_);

            CqlCode w_(object @this) {
                CqlCode am_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);
                return am_;
            }

            IEnumerable<CqlCode> x_ = context.Operators.Select<object, CqlCode>(v_, w_);
            IEnumerable<CqlCode> y_ = context.Operators.ValueSetUnion((IEnumerable<CqlCode>)s_, x_);

            bool? z_(Extension @this) {
                FhirUri an_ = @this?.UrlElement;
                string ao_ = FHIRHelpers_4_3_000.Instance.ToString(context, an_);
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

    private const long _cacheIndex_SDE_Payer = 441587053582915267L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Payer_Type(context);
        IEnumerable<Coverage> b_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));

        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? c_(Coverage Payer) {
            CodeableConcept e_ = Payer?.Type;
            CqlConcept f_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, e_);
            Period g_ = Payer?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, g_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? i_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, f_, h_);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> d_ = context.Operators.SelectDistinct<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 611400612990559444L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        List<Extension> b_ = a_?.Extension;

        bool? c_(Extension @this) {
            FhirUri j_ = @this?.UrlElement;
            string k_ = FHIRHelpers_4_3_000.Instance.ToString(context, j_);
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
                string ae_ = FHIRHelpers_4_3_000.Instance.ToString(context, ad_);
                bool? af_ = context.Operators.Equal(ae_, "ombCategory");
                return af_;
            }


            object o_(Extension @this) {
                DataType ag_ = @this?.Value;
                return ag_;
            }

            IEnumerable<object> p_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, n_, o_);

            CqlCode q_(object @this) {
                CqlCode ah_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);
                return ah_;
            }

            IEnumerable<CqlCode> r_ = context.Operators.Select<object, CqlCode>(p_, q_);

            bool? s_(Extension @this) {
                FhirUri ai_ = @this?.UrlElement;
                string aj_ = FHIRHelpers_4_3_000.Instance.ToString(context, ai_);
                bool? ak_ = context.Operators.Equal(aj_, "detailed");
                return ak_;
            }


            object t_(Extension @this) {
                DataType al_ = @this?.Value;
                return al_;
            }

            IEnumerable<object> u_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, s_, t_);

            CqlCode v_(object @this) {
                CqlCode am_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);
                return am_;
            }

            IEnumerable<CqlCode> w_ = context.Operators.Select<object, CqlCode>(u_, v_);
            IEnumerable<CqlCode> x_ = context.Operators.ValueSetUnion(r_, w_);

            bool? y_(Extension @this) {
                FhirUri an_ = @this?.UrlElement;
                string ao_ = FHIRHelpers_4_3_000.Instance.ToString(context, an_);
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

    private const long _cacheIndex_SDE_Sex = -4862447719526612531L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Code<AdministrativeGender> b_ = a_?.GenderElement;
        AdministrativeGender? c_ = b_?.Value;
        string d_ = context.Operators.Convert<string>(c_);
        bool? e_ = context.Operators.Equal(d_, "male");
        if (e_ ?? false)
        {
            return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", default, "Male");
        }
        else
        {
            Patient f_ = this.Patient(context);
            Code<AdministrativeGender> g_ = f_?.GenderElement;
            AdministrativeGender? h_ = g_?.Value;
            string i_ = context.Operators.Convert<string>(h_);
            bool? j_ = context.Operators.Equal(i_, "female");
            if (j_ ?? false)
            {
                return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", default, "Female");
            }
            else
            {
                return default;
            }
        }
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private SupplementalDataElements_3_4_000() {}

    public static SupplementalDataElements_3_4_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "SupplementalDataElements";
    public string Version => "3.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];

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

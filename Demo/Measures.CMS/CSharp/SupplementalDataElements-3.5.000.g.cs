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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.9.0")]
[CqlLibrary("SupplementalDataElements", "3.5.000")]
public partial class SupplementalDataElements_3_5_000 : ILibrary, ISingleton<SupplementalDataElements_3_5_000>
{
    private SupplementalDataElements_3_5_000() {}

    public static SupplementalDataElements_3_5_000 Instance { get; } = new();

    public string Name => "SupplementalDataElements";
    public string Version => "3.5.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance];

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
    public CqlValueSet Ethnicity(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", default);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
    public CqlValueSet ONC_Administrative_Sex(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", default);

    [CqlDeclaration("Payer Type")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
    public CqlValueSet Payer_Type(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", default);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
    public CqlValueSet Race(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", default);

    [CqlDeclaration("M")]
    public CqlCode M(CqlContext context) =>
        new CqlCode("M", "http://hl7.org/fhir/administrative-gender", default, default);

    [CqlDeclaration("F")]
    public CqlCode F(CqlContext context) =>
        new CqlCode("F", "http://hl7.org/fhir/administrative-gender", default, default);

    [CqlDeclaration("AdministrativeGender")]
    public CqlCode[] AdministrativeGender(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("M", "http://hl7.org/fhir/administrative-gender", default, default),
            new CqlCode("F", "http://hl7.org/fhir/administrative-gender", default, default),
        ];

        return a_;
    }

    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }

    [CqlDeclaration("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        List<Extension> a_()
        {
            bool j_()
            {
                Patient k_ = this.Patient(context);
                bool l_ = k_ is DomainResource;

                return l_;
            };
            if (j_())
            {
                Patient m_ = this.Patient(context);

                return (m_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? b_(Extension @this)
        {
            string n_ = @this?.Url;
            FhirString o_ = context.Operators.Convert<FhirString>(n_);
            string p_ = FHIRHelpers_4_4_000.Instance.ToString(context, o_);
            bool? q_ = context.Operators.Equal(p_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return q_;
        };
        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(a_()), b_);
        Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
        Extension[] e_ = [
            d_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? f_(Extension E)
        {
            bool? r_(Extension @this)
            {
                string am_ = @this?.Url;
                FhirString an_ = context.Operators.Convert<FhirString>(am_);
                string ao_ = FHIRHelpers_4_4_000.Instance.ToString(context, an_);
                bool? ap_ = context.Operators.Equal(ao_, "ombCategory");

                return ap_;
            };
            IEnumerable<Extension> s_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), r_);
            object t_(Extension @this)
            {
                DataType aq_ = @this?.Value;

                return aq_;
            };
            IEnumerable<object> u_ = context.Operators.Select<Extension, object>(s_, t_);
            object v_ = context.Operators.SingletonFrom<object>(u_);
            CqlCode w_ = FHIRHelpers_4_4_000.Instance.ToCode(context, v_ as Coding);
            CqlCode[] x_ = [
                w_,
            ];
            bool? y_(Extension @this)
            {
                string ar_ = @this?.Url;
                FhirString as_ = context.Operators.Convert<FhirString>(ar_);
                string at_ = FHIRHelpers_4_4_000.Instance.ToString(context, as_);
                bool? au_ = context.Operators.Equal(at_, "detailed");

                return au_;
            };
            IEnumerable<Extension> z_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), y_);
            object aa_(Extension @this)
            {
                DataType av_ = @this?.Value;

                return av_;
            };
            IEnumerable<object> ab_ = context.Operators.Select<Extension, object>(z_, aa_);
            CqlCode ac_(object @this)
            {
                CqlCode aw_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return aw_;
            };
            IEnumerable<CqlCode> ad_ = context.Operators.Select<object, CqlCode>(ab_, ac_);
            IEnumerable<CqlCode> ae_ = context.Operators.Union<CqlCode>(x_ as IEnumerable<CqlCode>, ad_);
            bool? af_(Extension @this)
            {
                string ax_ = @this?.Url;
                FhirString ay_ = context.Operators.Convert<FhirString>(ax_);
                string az_ = FHIRHelpers_4_4_000.Instance.ToString(context, ay_);
                bool? ba_ = context.Operators.Equal(az_, "text");

                return ba_;
            };
            IEnumerable<Extension> ag_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                    ? (E as Element).Extension
                    : default), af_);
            DataType ah_(Extension @this)
            {
                DataType bb_ = @this?.Value;

                return bb_;
            };
            IEnumerable<DataType> ai_ = context.Operators.Select<Extension, DataType>(ag_, ah_);
            DataType aj_ = context.Operators.SingletonFrom<DataType>(ai_);
            string ak_ = context.Operators.Convert<string>(aj_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? al_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, ae_, ak_);

            return al_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> g_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(g_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(h_);

        return i_;
    }

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet a_ = this.Payer_Type(context);
        IEnumerable<Coverage> b_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? c_(Coverage Payer)
        {
            CodeableConcept f_ = Payer?.Type;
            CqlConcept g_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, f_);
            Period h_ = Payer?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? j_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, g_, i_);

            return j_;
        };
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> d_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(b_, c_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(d_);

        return e_;
    }

    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        List<Extension> a_()
        {
            bool j_()
            {
                Patient k_ = this.Patient(context);
                bool l_ = k_ is DomainResource;

                return l_;
            };
            if (j_())
            {
                Patient m_ = this.Patient(context);

                return (m_ as DomainResource).Extension;
            }
            else
            {
                return default;
            }
        };
        bool? b_(Extension @this)
        {
            string n_ = @this?.Url;
            FhirString o_ = context.Operators.Convert<FhirString>(n_);
            string p_ = FHIRHelpers_4_4_000.Instance.ToString(context, o_);
            bool? q_ = context.Operators.Equal(p_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return q_;
        };
        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(a_()), b_);
        Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
        Extension[] e_ = [
            d_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? f_(Extension R)
        {
            bool? r_(Extension @this)
            {
                string al_ = @this?.Url;
                FhirString am_ = context.Operators.Convert<FhirString>(al_);
                string an_ = FHIRHelpers_4_4_000.Instance.ToString(context, am_);
                bool? ao_ = context.Operators.Equal(an_, "ombCategory");

                return ao_;
            };
            IEnumerable<Extension> s_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), r_);
            object t_(Extension @this)
            {
                DataType ap_ = @this?.Value;

                return ap_;
            };
            IEnumerable<object> u_ = context.Operators.Select<Extension, object>(s_, t_);
            CqlCode v_(object @this)
            {
                CqlCode aq_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return aq_;
            };
            IEnumerable<CqlCode> w_ = context.Operators.Select<object, CqlCode>(u_, v_);
            bool? x_(Extension @this)
            {
                string ar_ = @this?.Url;
                FhirString as_ = context.Operators.Convert<FhirString>(ar_);
                string at_ = FHIRHelpers_4_4_000.Instance.ToString(context, as_);
                bool? au_ = context.Operators.Equal(at_, "detailed");

                return au_;
            };
            IEnumerable<Extension> y_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), x_);
            object z_(Extension @this)
            {
                DataType av_ = @this?.Value;

                return av_;
            };
            IEnumerable<object> aa_ = context.Operators.Select<Extension, object>(y_, z_);
            CqlCode ab_(object @this)
            {
                CqlCode aw_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);

                return aw_;
            };
            IEnumerable<CqlCode> ac_ = context.Operators.Select<object, CqlCode>(aa_, ab_);
            IEnumerable<CqlCode> ad_ = context.Operators.Union<CqlCode>(w_, ac_);
            bool? ae_(Extension @this)
            {
                string ax_ = @this?.Url;
                FhirString ay_ = context.Operators.Convert<FhirString>(ax_);
                string az_ = FHIRHelpers_4_4_000.Instance.ToString(context, ay_);
                bool? ba_ = context.Operators.Equal(az_, "text");

                return ba_;
            };
            IEnumerable<Extension> af_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                    ? (R as Element).Extension
                    : default), ae_);
            DataType ag_(Extension @this)
            {
                DataType bb_ = @this?.Value;

                return bb_;
            };
            IEnumerable<DataType> ah_ = context.Operators.Select<Extension, DataType>(af_, ag_);
            DataType ai_ = context.Operators.SingletonFrom<DataType>(ah_);
            string aj_ = context.Operators.Convert<string>(ai_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ak_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, ad_, aj_);

            return ak_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> g_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(g_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(h_);

        return i_;
    }

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_()
        {
            bool b_()
            {
                Patient d_ = this.Patient(context);
                Code<AdministrativeGender> e_ = d_?.GenderElement;
                AdministrativeGender? f_ = e_?.Value;
                string g_ = context.Operators.Convert<string>(f_);
                bool? h_ = context.Operators.Equal(g_, "male");

                return h_ ?? false;
            };
            bool c_()
            {
                Patient i_ = this.Patient(context);
                Code<AdministrativeGender> j_ = i_?.GenderElement;
                AdministrativeGender? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "female");

                return m_ ?? false;
            };
            if (b_())
            {
                CqlCode n_ = this.M(context);

                return n_;
            }
            else if (c_())
            {
                CqlCode o_ = this.F(context);

                return o_;
            }
            else
            {
                return default;
            }
        };

        return a_();
    }

    private static CqlTupleMetadata CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ = new(
        [typeof(CqlConcept), typeof(CqlInterval<CqlDateTime>)],
        ["code", "period"]);

    private static CqlTupleMetadata CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR = new(
        [typeof(IEnumerable<CqlCode>), typeof(string)],
        ["codes", "display"]);


}

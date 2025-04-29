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
[CqlLibrary("SupplementalDataElementsFHIR4", "2.0.000")]
public partial class SupplementalDataElementsFHIR4_2_0_000 : ILibrary, ISingleton<SupplementalDataElementsFHIR4_2_0_000>
{
    private SupplementalDataElementsFHIR4_2_0_000() {}

    public static SupplementalDataElementsFHIR4_2_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "SupplementalDataElementsFHIR4";
    public string Version => "2.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("ONC Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext _) => _ONC_Administrative_Sex;
    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlValueSetDefinition("Payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer(CqlContext _) => _Payer;
    private static readonly CqlValueSet _Payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    #endregion ValueSets

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient tl_ = context.Operators.SingletonFrom<Patient>(tk_);

        return tl_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Extension> tm_()
        {
            bool ty_()
            {
                Patient tz_ = this.Patient(context);
                bool ua_ = tz_ is DomainResource;

                return ua_;
            };
            if (ty_())
            {
                Patient ub_ = this.Patient(context);

                return (IEnumerable<Extension>)((ub_ as DomainResource).Extension);
            }
            else
            {
                return default;
            }
        };
        bool? tn_(Extension Extension)
        {
            string uc_ = Extension?.Url;
            FhirUri ud_ = context.Operators.Convert<FhirUri>(uc_);
            string ue_ = FHIRHelpers_4_0_001.Instance.ToString(context, ud_);
            bool? uf_ = context.Operators.Equal(ue_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return uf_;
        };
        IEnumerable<Extension> to_ = context.Operators.Where<Extension>(tm_(), tn_);
        IEnumerable<Extension> tp_(Extension Extension)
        {
            List<Extension> ug_ = Extension?.Extension;

            return (IEnumerable<Extension>)ug_;
        };
        IEnumerable<IEnumerable<Extension>> tq_ = context.Operators.Select<Extension, IEnumerable<Extension>>(to_, tp_);
        IEnumerable<IEnumerable<Extension>> tr_ = context.Operators.Distinct<IEnumerable<Extension>>(tq_);
        IEnumerable<Extension> ts_ = context.Operators.Flatten<Extension>(tr_);
        bool? tt_(Extension E)
        {
            string uh_ = E?.Url;
            FhirUri ui_ = context.Operators.Convert<FhirUri>(uh_);
            string uj_ = FHIRHelpers_4_0_001.Instance.ToString(context, ui_);
            bool? uk_ = context.Operators.Equal(uj_, "ombCategory");
            FhirUri um_ = context.Operators.Convert<FhirUri>(uh_);
            string un_ = FHIRHelpers_4_0_001.Instance.ToString(context, um_);
            bool? uo_ = context.Operators.Equal(un_, "detailed");
            bool? up_ = context.Operators.Or(uk_, uo_);

            return up_;
        };
        IEnumerable<Extension> tu_ = context.Operators.Where<Extension>(ts_, tt_);
        Coding tv_(Extension E)
        {
            DataType uq_ = E?.Value;

            return uq_ as Coding;
        };
        IEnumerable<Coding> tw_ = context.Operators.Select<Extension, Coding>(tu_, tv_);
        IEnumerable<Coding> tx_ = context.Operators.Distinct<Coding>(tw_);

        return tx_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet ur_ = this.Payer(context);
        IEnumerable<Coverage> us_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, ur_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        (CqlTupleMetadata, CodeableConcept code, Period period)? ut_(Coverage Payer)
        {
            CodeableConcept uw_ = Payer?.Type;
            Period ux_ = Payer?.Period;
            (CqlTupleMetadata, CodeableConcept code, Period period)? uy_ = (CqlTupleMetadata_CaKghTfWMNOTHSWhifjFZOVYO, uw_, ux_);

            return uy_;
        };
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> uu_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CodeableConcept code, Period period)?>(us_, ut_);
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> uv_ = context.Operators.Distinct<(CqlTupleMetadata, CodeableConcept code, Period period)?>(uu_);

        return uv_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Extension> uz_()
        {
            bool vl_()
            {
                Patient vm_ = this.Patient(context);
                bool vn_ = vm_ is DomainResource;

                return vn_;
            };
            if (vl_())
            {
                Patient vo_ = this.Patient(context);

                return (IEnumerable<Extension>)((vo_ as DomainResource).Extension);
            }
            else
            {
                return default;
            }
        };
        bool? va_(Extension Extension)
        {
            string vp_ = Extension?.Url;
            FhirUri vq_ = context.Operators.Convert<FhirUri>(vp_);
            string vr_ = FHIRHelpers_4_0_001.Instance.ToString(context, vq_);
            bool? vs_ = context.Operators.Equal(vr_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return vs_;
        };
        IEnumerable<Extension> vb_ = context.Operators.Where<Extension>(uz_(), va_);
        IEnumerable<Extension> vc_(Extension Extension)
        {
            List<Extension> vt_ = Extension?.Extension;

            return (IEnumerable<Extension>)vt_;
        };
        IEnumerable<IEnumerable<Extension>> vd_ = context.Operators.Select<Extension, IEnumerable<Extension>>(vb_, vc_);
        IEnumerable<IEnumerable<Extension>> ve_ = context.Operators.Distinct<IEnumerable<Extension>>(vd_);
        IEnumerable<Extension> vf_ = context.Operators.Flatten<Extension>(ve_);
        bool? vg_(Extension E)
        {
            string vu_ = E?.Url;
            FhirUri vv_ = context.Operators.Convert<FhirUri>(vu_);
            string vw_ = FHIRHelpers_4_0_001.Instance.ToString(context, vv_);
            bool? vx_ = context.Operators.Equal(vw_, "ombCategory");
            FhirUri vz_ = context.Operators.Convert<FhirUri>(vu_);
            string wa_ = FHIRHelpers_4_0_001.Instance.ToString(context, vz_);
            bool? wb_ = context.Operators.Equal(wa_, "detailed");
            bool? wc_ = context.Operators.Or(vx_, wb_);

            return wc_;
        };
        IEnumerable<Extension> vh_ = context.Operators.Where<Extension>(vf_, vg_);
        Coding vi_(Extension E)
        {
            DataType wd_ = E?.Value;

            return wd_ as Coding;
        };
        IEnumerable<Coding> vj_ = context.Operators.Select<Extension, Coding>(vh_, vi_);
        IEnumerable<Coding> vk_ = context.Operators.Distinct<Coding>(vj_);

        return vk_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode we_()
        {
            bool wf_()
            {
                Patient wh_ = this.Patient(context);
                Code<AdministrativeGender> wi_ = wh_?.GenderElement;
                string wj_ = FHIRHelpers_4_0_001.Instance.ToString(context, wi_);
                bool? wk_ = context.Operators.Equal(wj_, "male");

                return wk_ ?? false;
            };
            bool wg_()
            {
                Patient wl_ = this.Patient(context);
                Code<AdministrativeGender> wm_ = wl_?.GenderElement;
                string wn_ = FHIRHelpers_4_0_001.Instance.ToString(context, wm_);
                bool? wo_ = context.Operators.Equal(wn_, "female");

                return wo_ ?? false;
            };
            if (wf_())
            {
                return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Male");
            }
            else if (wg_())
            {
                return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Female");
            }
            else
            {
                return default;
            }
        };

        return we_();
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CaKghTfWMNOTHSWhifjFZOVYO = new(
        [typeof(CodeableConcept), typeof(Period)],
        ["code", "period"]);

    #endregion CqlTupleMetadata Properties

}

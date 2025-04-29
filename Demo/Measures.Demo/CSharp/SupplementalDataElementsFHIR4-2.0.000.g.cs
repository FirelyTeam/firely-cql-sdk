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

    #region ValueSet: Ethnicity
    [CqlValueSetDefinition(
        definitionName: "Ethnicity",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837",
        valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext context) => _Ethnicity;

    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);
    #endregion

    #region ValueSet: ONC Administrative Sex
    [CqlValueSetDefinition(
        definitionName: "ONC Administrative Sex",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1",
        valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext context) => _ONC_Administrative_Sex;

    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);
    #endregion

    #region ValueSet: Payer
    [CqlValueSetDefinition(
        definitionName: "Payer",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591",
        valueSetVersion: null)]
    public CqlValueSet Payer(CqlContext context) => _Payer;

    private static readonly CqlValueSet _Payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);
    #endregion

    #region ValueSet: Race
    [CqlValueSetDefinition(
        definitionName: "Race",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836",
        valueSetVersion: null)]
    public CqlValueSet Race(CqlContext context) => _Race;

    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);
    #endregion

    #endregion ValueSets

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ro_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient rp_ = context.Operators.SingletonFrom<Patient>(ro_);

        return rp_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Extension> rq_()
        {
            bool sc_()
            {
                Patient sd_ = this.Patient(context);
                bool se_ = sd_ is DomainResource;

                return se_;
            };
            if (sc_())
            {
                Patient sf_ = this.Patient(context);

                return (IEnumerable<Extension>)((sf_ as DomainResource).Extension);
            }
            else
            {
                return default;
            }
        };
        bool? rr_(Extension Extension)
        {
            string sg_ = Extension?.Url;
            FhirUri sh_ = context.Operators.Convert<FhirUri>(sg_);
            string si_ = FHIRHelpers_4_0_001.Instance.ToString(context, sh_);
            bool? sj_ = context.Operators.Equal(si_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return sj_;
        };
        IEnumerable<Extension> rs_ = context.Operators.Where<Extension>(rq_(), rr_);
        IEnumerable<Extension> rt_(Extension Extension)
        {
            List<Extension> sk_ = Extension?.Extension;

            return (IEnumerable<Extension>)sk_;
        };
        IEnumerable<IEnumerable<Extension>> ru_ = context.Operators.Select<Extension, IEnumerable<Extension>>(rs_, rt_);
        IEnumerable<IEnumerable<Extension>> rv_ = context.Operators.Distinct<IEnumerable<Extension>>(ru_);
        IEnumerable<Extension> rw_ = context.Operators.Flatten<Extension>(rv_);
        bool? rx_(Extension E)
        {
            string sl_ = E?.Url;
            FhirUri sm_ = context.Operators.Convert<FhirUri>(sl_);
            string sn_ = FHIRHelpers_4_0_001.Instance.ToString(context, sm_);
            bool? so_ = context.Operators.Equal(sn_, "ombCategory");
            FhirUri sq_ = context.Operators.Convert<FhirUri>(sl_);
            string sr_ = FHIRHelpers_4_0_001.Instance.ToString(context, sq_);
            bool? ss_ = context.Operators.Equal(sr_, "detailed");
            bool? st_ = context.Operators.Or(so_, ss_);

            return st_;
        };
        IEnumerable<Extension> ry_ = context.Operators.Where<Extension>(rw_, rx_);
        Coding rz_(Extension E)
        {
            DataType su_ = E?.Value;

            return su_ as Coding;
        };
        IEnumerable<Coding> sa_ = context.Operators.Select<Extension, Coding>(ry_, rz_);
        IEnumerable<Coding> sb_ = context.Operators.Distinct<Coding>(sa_);

        return sb_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet sv_ = this.Payer(context);
        IEnumerable<Coverage> sw_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, sv_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        (CqlTupleMetadata, CodeableConcept code, Period period)? sx_(Coverage Payer)
        {
            CodeableConcept ta_ = Payer?.Type;
            Period tb_ = Payer?.Period;
            (CqlTupleMetadata, CodeableConcept code, Period period)? tc_ = (CqlTupleMetadata_CaKghTfWMNOTHSWhifjFZOVYO, ta_, tb_);

            return tc_;
        };
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> sy_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CodeableConcept code, Period period)?>(sw_, sx_);
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> sz_ = context.Operators.Distinct<(CqlTupleMetadata, CodeableConcept code, Period period)?>(sy_);

        return sz_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Extension> td_()
        {
            bool tp_()
            {
                Patient tq_ = this.Patient(context);
                bool tr_ = tq_ is DomainResource;

                return tr_;
            };
            if (tp_())
            {
                Patient ts_ = this.Patient(context);

                return (IEnumerable<Extension>)((ts_ as DomainResource).Extension);
            }
            else
            {
                return default;
            }
        };
        bool? te_(Extension Extension)
        {
            string tt_ = Extension?.Url;
            FhirUri tu_ = context.Operators.Convert<FhirUri>(tt_);
            string tv_ = FHIRHelpers_4_0_001.Instance.ToString(context, tu_);
            bool? tw_ = context.Operators.Equal(tv_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return tw_;
        };
        IEnumerable<Extension> tf_ = context.Operators.Where<Extension>(td_(), te_);
        IEnumerable<Extension> tg_(Extension Extension)
        {
            List<Extension> tx_ = Extension?.Extension;

            return (IEnumerable<Extension>)tx_;
        };
        IEnumerable<IEnumerable<Extension>> th_ = context.Operators.Select<Extension, IEnumerable<Extension>>(tf_, tg_);
        IEnumerable<IEnumerable<Extension>> ti_ = context.Operators.Distinct<IEnumerable<Extension>>(th_);
        IEnumerable<Extension> tj_ = context.Operators.Flatten<Extension>(ti_);
        bool? tk_(Extension E)
        {
            string ty_ = E?.Url;
            FhirUri tz_ = context.Operators.Convert<FhirUri>(ty_);
            string ua_ = FHIRHelpers_4_0_001.Instance.ToString(context, tz_);
            bool? ub_ = context.Operators.Equal(ua_, "ombCategory");
            FhirUri ud_ = context.Operators.Convert<FhirUri>(ty_);
            string ue_ = FHIRHelpers_4_0_001.Instance.ToString(context, ud_);
            bool? uf_ = context.Operators.Equal(ue_, "detailed");
            bool? ug_ = context.Operators.Or(ub_, uf_);

            return ug_;
        };
        IEnumerable<Extension> tl_ = context.Operators.Where<Extension>(tj_, tk_);
        Coding tm_(Extension E)
        {
            DataType uh_ = E?.Value;

            return uh_ as Coding;
        };
        IEnumerable<Coding> tn_ = context.Operators.Select<Extension, Coding>(tl_, tm_);
        IEnumerable<Coding> to_ = context.Operators.Distinct<Coding>(tn_);

        return to_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ui_()
        {
            bool uj_()
            {
                Patient ul_ = this.Patient(context);
                Code<AdministrativeGender> um_ = ul_?.GenderElement;
                string un_ = FHIRHelpers_4_0_001.Instance.ToString(context, um_);
                bool? uo_ = context.Operators.Equal(un_, "male");

                return uo_ ?? false;
            };
            bool uk_()
            {
                Patient up_ = this.Patient(context);
                Code<AdministrativeGender> uq_ = up_?.GenderElement;
                string ur_ = FHIRHelpers_4_0_001.Instance.ToString(context, uq_);
                bool? us_ = context.Operators.Equal(ur_, "female");

                return us_ ?? false;
            };
            if (uj_())
            {
                return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Male");
            }
            else if (uk_())
            {
                return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Female");
            }
            else
            {
                return default;
            }
        };

        return ui_();
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CaKghTfWMNOTHSWhifjFZOVYO = new(
        [typeof(CodeableConcept), typeof(Period)],
        ["code", "period"]);

    #endregion CqlTupleMetadata Properties

}

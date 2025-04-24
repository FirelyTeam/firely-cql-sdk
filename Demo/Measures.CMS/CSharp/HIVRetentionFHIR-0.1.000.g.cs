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
[CqlLibrary("HIVRetentionFHIR", "0.1.000")]
public partial class HIVRetentionFHIR_0_1_000 : ILibrary, ISingleton<HIVRetentionFHIR_0_1_000>
{
    private HIVRetentionFHIR_0_1_000() {}

    public static HIVRetentionFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HIVRetentionFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, CumulativeMedicationDuration_4_1_000.Instance];

    #endregion ILibrary Implementation

    #region Definition Methods

    [CqlValueSetDeclaration(
        declarationName: "Annual Wellness Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);


    [CqlValueSetDeclaration(
        declarationName: "Face-to-Face Interaction",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048")]
    public CqlValueSet Face_to_Face_Interaction(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", default);


    [CqlValueSetDeclaration(
        declarationName: "HIV",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
    public CqlValueSet HIV(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", default);


    [CqlValueSetDeclaration(
        declarationName: "HIV Viral Load",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002")]
    public CqlValueSet HIV_Viral_Load(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002", default);


    [CqlValueSetDeclaration(
        declarationName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);


    [CqlValueSetDeclaration(
        declarationName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlValueSetDeclaration(
        declarationName: "Outpatient Consultation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
    public CqlValueSet Outpatient_Consultation(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);


    [CqlValueSetDeclaration(
        declarationName: "Preventive Care Services Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);


    [CqlValueSetDeclaration(
        declarationName: "Preventive Care Services Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);


    [CqlValueSetDeclaration(
        declarationName: "Preventive Care Services, Initial Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);


    [CqlValueSetDeclaration(
        declarationName: "Preventive Care, Established Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);


    [CqlValueSetDeclaration(
        declarationName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);


    [CqlValueSetDeclaration(
        declarationName: "Preventive Care Services Other",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150")]
    public CqlValueSet Preventive_Care_Services_Other(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", default);


    [CqlDeclaration("CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] a_ = []
;

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("HIVRetentionFHIR-0.1.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
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
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlDeclaration("Has Active HIV Diagnosis Starts On or Before First 240 Days of Measurement Period")]
    public bool? Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.HIV(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition HIVDx)
        {
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlQuantity j_ = context.Operators.Quantity(240m, "days");
            CqlDateTime k_ = context.Operators.Add(i_, j_);
            bool? l_ = context.Operators.SameOrBefore(g_, k_, "day");
            bool? m_ = QICoreCommon_2_1_000.Instance.isActive(context, HIVDx);
            bool? n_ = context.Operators.And(l_, m_);

            return n_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }


    [CqlDeclaration("Has Qualifying Encounter During First 240 Days of Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
        CqlValueSet x_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet z_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
        IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
        CqlValueSet ad_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> af_ = context.Operators.Union<Encounter>(ac_, ae_);
        bool? ag_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> aj_ = this.Measurement_Period(context);
            CqlDateTime ak_ = context.Operators.Start(aj_);
            CqlDateTime am_ = context.Operators.Start(aj_);
            CqlQuantity an_ = context.Operators.Quantity(240m, "days");
            CqlDateTime ao_ = context.Operators.Add(am_, an_);
            CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(ak_, ao_, true, true);
            Period aq_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aq_);
            bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, ar_, "day");

            return as_;
        };
        IEnumerable<Encounter> ah_ = context.Operators.Where<Encounter>(af_, ag_);
        bool? ai_ = context.Operators.Exists<Encounter>(ah_);

        return ai_;
    }


    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? a_ = this.Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period(context);
        bool? b_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(context);
        bool? c_ = context.Operators.And(a_, b_);

        return c_;
    }


    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Encounter During Measurement Period With HIV")]
    public IEnumerable<Encounter> Encounter_During_Measurement_Period_With_HIV(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
        CqlValueSet x_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet z_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
        IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
        CqlValueSet ad_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter> ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> af_ = context.Operators.Union<Encounter>(ac_, ae_);
        IEnumerable<Encounter> ag_(Encounter ValidEncounter)
        {
            CqlValueSet ai_ = this.HIV(context);
            IEnumerable<Condition> aj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? ak_(Condition HIVDiagnosis)
            {
                CqlInterval<CqlDateTime> ao_ = this.Measurement_Period(context);
                Period ap_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                bool? ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, aq_, "day");
                CqlInterval<CqlDateTime> as_()
                {
                    bool az_()
                    {
                        CqlInterval<CqlDateTime> ba_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                        CqlDateTime bb_ = context.Operators.Start(ba_);

                        return bb_ is null;
                    };
                    if (az_())
                    {
                        return default;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> bc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIVDiagnosis);
                        CqlDateTime bd_ = context.Operators.Start(bc_);
                        CqlDateTime bf_ = context.Operators.Start(bc_);
                        CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(bd_, bf_, true, true);

                        return bg_;
                    }
                };
                CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                bool? av_ = context.Operators.SameOrBefore(as_(), au_, "day");
                bool? aw_ = context.Operators.And(ar_, av_);
                bool? ax_ = QICoreCommon_2_1_000.Instance.isActive(context, HIVDiagnosis);
                bool? ay_ = context.Operators.And(aw_, ax_);

                return ay_;
            };
            IEnumerable<Condition> al_ = context.Operators.Where<Condition>(aj_, ak_);
            Encounter am_(Condition HIVDiagnosis) =>
                ValidEncounter;
            IEnumerable<Encounter> an_ = context.Operators.Select<Condition, Encounter>(al_, am_);

            return an_;
        };
        IEnumerable<Encounter> ah_ = context.Operators.SelectMany<Encounter, Encounter>(af_, ag_);

        return ah_;
    }


    [CqlDeclaration("Has One Encounter With HIV and One Viral Load Test At Least 90 Days Apart")]
    public bool? Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_During_Measurement_Period_With_HIV(context);
        IEnumerable<Encounter> b_(Encounter EncounterWithHIV)
        {
            CqlValueSet e_ = this.HIV_Viral_Load(context);
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? g_(Observation ViralLoadTest)
            {
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                DataType l_ = ViralLoadTest?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_2_1_000.Instance.toInterval(context, m_);
                bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, n_, "day");
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> r_ = QICoreCommon_2_1_000.Instance.toInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                Period t_ = EncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlDateTime v_ = context.Operators.End(u_);
                CqlQuantity w_ = context.Operators.Quantity(90m, "days");
                CqlDateTime x_ = context.Operators.Add(v_, w_);
                bool? y_ = context.Operators.SameOrAfter(s_, x_, "day");
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_1_000.Instance.toInterval(context, ad_);
                CqlDateTime af_ = context.Operators.End(ae_);
                CqlDateTime ah_ = context.Operators.Add(af_, w_);
                bool? ai_ = context.Operators.SameOrAfter(ab_, ah_, "day");
                bool? aj_ = context.Operators.Or(y_, ai_);
                bool? ak_ = context.Operators.And(o_, aj_);

                return ak_;
            };
            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
            Encounter i_(Observation ViralLoadTest) =>
                EncounterWithHIV;
            IEnumerable<Encounter> j_ = context.Operators.Select<Observation, Encounter>(h_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        bool? d_ = context.Operators.Exists<Encounter>(c_);

        return d_;
    }


    [CqlDeclaration("Has Two Encounters With HIV At Least 90 Days Apart")]
    public bool? Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_During_Measurement_Period_With_HIV(context);
        IEnumerable<Encounter> b_(Encounter EncounterWithHIV)
        {
            IEnumerable<Encounter> e_ = this.Encounter_During_Measurement_Period_With_HIV(context);
            bool? f_(Encounter AnotherEncounterWithHIV)
            {
                bool? j_ = context.Operators.Equivalent(EncounterWithHIV, AnotherEncounterWithHIV);
                bool? k_ = context.Operators.Not(j_);
                Period l_ = AnotherEncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                Period o_ = EncounterWithHIV?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime q_ = context.Operators.End(p_);
                CqlQuantity r_ = context.Operators.Quantity(90m, "days");
                CqlDateTime s_ = context.Operators.Add(q_, r_);
                bool? t_ = context.Operators.SameOrAfter(n_, s_, "day");
                bool? u_ = context.Operators.And(k_, t_);

                return u_;
            };
            IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
            Encounter h_(Encounter AnotherEncounterWithHIV) =>
                EncounterWithHIV;
            IEnumerable<Encounter> i_ = context.Operators.Select<Encounter, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        bool? d_ = context.Operators.Exists<Encounter>(c_);

        return d_;
    }


    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? a_ = this.Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart(context);
        bool? b_ = this.Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart(context);
        bool? c_ = context.Operators.Or(a_, b_);

        return c_;
    }


    #endregion Definition Methods

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR = new(
        [typeof(IEnumerable<CqlCode>), typeof(string)],
        ["codes", "display"]);

    #endregion CqlTupleMetadata Properties

}

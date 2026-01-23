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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("SupplementalDataElements", "3.4.000")]
public partial class SupplementalDataElements_3_4_000 : ILibrary, ILibraryInternals, ISingleton<SupplementalDataElements_3_4_000>
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
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute, context) ?? SDE_Ethnicity_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {

        List<Extension> a_() {

            bool j_() {
                Patient k_ = this.Patient(context);
                bool l_ = k_ is DomainResource;
                return l_;
            }

            if (j_())
            {
                Patient m_ = this.Patient(context);
                return (m_ as DomainResource).Extension;
            }
            else
            {
                return default;
            };
        }


        bool? b_(Extension @this) {
            FhirUri n_ = @this?.UrlElement;
            string o_ = FHIRHelpers_4_3_000.Instance.ToString(context, n_);
            bool? p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");
            return p_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(a_()), b_);
        Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
        Extension[] e_ = [
            d_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? f_(Extension E) {

            bool? q_(Extension @this) {
                FhirUri al_ = @this?.UrlElement;
                string am_ = FHIRHelpers_4_3_000.Instance.ToString(context, al_);
                bool? an_ = context.Operators.Equal(am_, "ombCategory");
                return an_;
            }

            IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                ? (E as Element).Extension
                : default), q_);

            object s_(Extension @this) {
                DataType ao_ = @this?.Value;
                return ao_;
            }

            IEnumerable<object> t_ = context.Operators.Select<Extension, object>(r_, s_);
            object u_ = context.Operators.SingletonFrom<object>(t_);
            CqlCode v_ = FHIRHelpers_4_3_000.Instance.ToCode(context, u_ as Coding);
            CqlCode[] w_ = [
                v_,
            ];

            bool? x_(Extension @this) {
                FhirUri ap_ = @this?.UrlElement;
                string aq_ = FHIRHelpers_4_3_000.Instance.ToString(context, ap_);
                bool? ar_ = context.Operators.Equal(aq_, "detailed");
                return ar_;
            }

            IEnumerable<Extension> y_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                ? (E as Element).Extension
                : default), x_);

            object z_(Extension @this) {
                DataType as_ = @this?.Value;
                return as_;
            }

            IEnumerable<object> aa_ = context.Operators.Select<Extension, object>(y_, z_);

            CqlCode ab_(object @this) {
                CqlCode at_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);
                return at_;
            }

            IEnumerable<CqlCode> ac_ = context.Operators.Select<object, CqlCode>(aa_, ab_);
            IEnumerable<CqlCode> ad_ = context.Operators.ValueSetUnion((IEnumerable<CqlCode>)w_, ac_);

            bool? ae_(Extension @this) {
                FhirUri au_ = @this?.UrlElement;
                string av_ = FHIRHelpers_4_3_000.Instance.ToString(context, au_);
                bool? aw_ = context.Operators.Equal(av_, "text");
                return aw_;
            }

            IEnumerable<Extension> af_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                ? (E as Element).Extension
                : default), ae_);

            DataType ag_(Extension @this) {
                DataType ax_ = @this?.Value;
                return ax_;
            }

            IEnumerable<DataType> ah_ = context.Operators.Select<Extension, DataType>(af_, ag_);
            DataType ai_ = context.Operators.SingletonFrom<DataType>(ah_);
            string aj_ = context.Operators.Convert<string>(ai_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ak_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, ad_, aj_);
            return ak_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> g_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(g_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(h_);
        return i_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute, context) ?? SDE_Payer_Compute(context);

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Payer_Type(context);
        IEnumerable<Coverage> b_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));

        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? c_(Coverage Payer) {
            CodeableConcept f_ = Payer?.Type;
            CqlConcept g_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, f_);
            Period h_ = Payer?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, h_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? j_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, g_, i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> d_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(b_, c_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(d_);
        return e_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute, context) ?? SDE_Race_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {

        List<Extension> a_() {

            bool j_() {
                Patient k_ = this.Patient(context);
                bool l_ = k_ is DomainResource;
                return l_;
            }

            if (j_())
            {
                Patient m_ = this.Patient(context);
                return (m_ as DomainResource).Extension;
            }
            else
            {
                return default;
            };
        }


        bool? b_(Extension @this) {
            FhirUri n_ = @this?.UrlElement;
            string o_ = FHIRHelpers_4_3_000.Instance.ToString(context, n_);
            bool? p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");
            return p_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(a_()), b_);
        Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
        Extension[] e_ = [
            d_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? f_(Extension R) {

            bool? q_(Extension @this) {
                FhirUri ak_ = @this?.UrlElement;
                string al_ = FHIRHelpers_4_3_000.Instance.ToString(context, ak_);
                bool? am_ = context.Operators.Equal(al_, "ombCategory");
                return am_;
            }

            IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                ? (R as Element).Extension
                : default), q_);

            object s_(Extension @this) {
                DataType an_ = @this?.Value;
                return an_;
            }

            IEnumerable<object> t_ = context.Operators.Select<Extension, object>(r_, s_);

            CqlCode u_(object @this) {
                CqlCode ao_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);
                return ao_;
            }

            IEnumerable<CqlCode> v_ = context.Operators.Select<object, CqlCode>(t_, u_);

            bool? w_(Extension @this) {
                FhirUri ap_ = @this?.UrlElement;
                string aq_ = FHIRHelpers_4_3_000.Instance.ToString(context, ap_);
                bool? ar_ = context.Operators.Equal(aq_, "detailed");
                return ar_;
            }

            IEnumerable<Extension> x_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                ? (R as Element).Extension
                : default), w_);

            object y_(Extension @this) {
                DataType as_ = @this?.Value;
                return as_;
            }

            IEnumerable<object> z_ = context.Operators.Select<Extension, object>(x_, y_);

            CqlCode aa_(object @this) {
                CqlCode at_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);
                return at_;
            }

            IEnumerable<CqlCode> ab_ = context.Operators.Select<object, CqlCode>(z_, aa_);
            IEnumerable<CqlCode> ac_ = context.Operators.ValueSetUnion(v_, ab_);

            bool? ad_(Extension @this) {
                FhirUri au_ = @this?.UrlElement;
                string av_ = FHIRHelpers_4_3_000.Instance.ToString(context, au_);
                bool? aw_ = context.Operators.Equal(av_, "text");
                return aw_;
            }

            IEnumerable<Extension> ae_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                ? (R as Element).Extension
                : default), ad_);

            DataType af_(Extension @this) {
                DataType ax_ = @this?.Value;
                return ax_;
            }

            IEnumerable<DataType> ag_ = context.Operators.Select<Extension, DataType>(ae_, af_);
            DataType ah_ = context.Operators.SingletonFrom<DataType>(ag_);
            string ai_ = context.Operators.Convert<string>(ah_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? aj_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, ac_, ai_);
            return aj_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> g_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(g_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(h_);
        return i_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute, context) ?? SDE_Sex_Compute(context);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {

        CqlCode a_() {

            bool b_() {
                Patient d_ = this.Patient(context);
                Code<AdministrativeGender> e_ = d_?.GenderElement;
                AdministrativeGender? f_ = e_?.Value;
                string g_ = context.Operators.Convert<string>(f_);
                bool? h_ = context.Operators.Equal(g_, "male");
                return h_ ?? false;
            }


            bool c_() {
                Patient i_ = this.Patient(context);
                Code<AdministrativeGender> j_ = i_?.GenderElement;
                AdministrativeGender? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "female");
                return m_ ?? false;
            }

            if (b_())
            {
                return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", default, "Male");
            }
            else if (c_())
            {
                return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", default, "Female");
            }
            else
            {
                return default;
            };
        }

        return a_();
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (5)

    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    // Reference to the execution cache instance that initialized this library
    private CqlLibrarySetInvocationCache _cache;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="cache">The execution cache instance performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibrarySetInvocationCache cache,
        int startIndex)
    {
        // Skip if already initialized by this cache instance (allows re-initialization with different cache)
        if (_cache == cache)
            return 0;

        _cache = cache;

        var index = startIndex;
        _cacheIndex_Patient = index++;
        _cacheIndex_SDE_Ethnicity = index++;
        _cacheIndex_SDE_Payer = index++;
        _cacheIndex_SDE_Race = index++;
        _cacheIndex_SDE_Sex = index++;
        return index - startIndex;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private SupplementalDataElements_3_4_000() {}

    public static SupplementalDataElements_3_4_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "SupplementalDataElements";
    public string Version => "3.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties (2)

    private static CqlTupleMetadata CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ = new(
       [typeof(CqlConcept), typeof(CqlInterval<CqlDateTime>)],
       ["code", "period"]);

    private static CqlTupleMetadata CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR = new(
       [typeof(IEnumerable<CqlCode>), typeof(string)],
       ["codes", "display"]);

    #endregion CqlTupleMetadata Properties

}

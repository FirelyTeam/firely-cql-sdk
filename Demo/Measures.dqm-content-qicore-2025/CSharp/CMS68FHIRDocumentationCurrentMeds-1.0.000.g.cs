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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS68FHIRDocumentationCurrentMeds", "1.0.000")]
public partial class CMS68FHIRDocumentationCurrentMeds_1_0_000 : ILibrary, ISingleton<CMS68FHIRDocumentationCurrentMeds_1_0_000>
{
    private CMS68FHIRDocumentationCurrentMeds_1_0_000() {}

    public static CMS68FHIRDocumentationCurrentMeds_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS68FHIRDocumentationCurrentMeds";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(object CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is null)
            {
                // No caching, clear out previous values
                CacheVersion = null;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (ReferenceEquals(CacheVersion, cqlContextCacheVersion))
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

    #region ValueSets

    [CqlValueSetDefinition("Encounter to Document Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", valueSetVersion: null)]
    public CqlValueSet Encounter_to_Document_Medications(CqlContext _) => _Encounter_to_Document_Medications;
    private static readonly CqlValueSet _Encounter_to_Document_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Acute health crisis (finding)", codeId: "705016005", codeSystem: "http://snomed.info/sct")]
    public CqlCode Acute_health_crisis__finding_(CqlContext _) => _Acute_health_crisis__finding_;
    private static readonly CqlCode _Acute_health_crisis__finding_ = new CqlCode("705016005", "http://snomed.info/sct");

    [CqlCodeDefinition("Documentation of current medications (procedure)", codeId: "428191000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Documentation_of_current_medications__procedure_(CqlContext _) => _Documentation_of_current_medications__procedure_;
    private static readonly CqlCode _Documentation_of_current_medications__procedure_ = new CqlCode("428191000124101", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Acute_health_crisis__finding_,
          _Documentation_of_current_medications__procedure_]);

    #endregion CodeSystems

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                object a_ = context.ResolveParameter("CMS68FHIRDocumentationCurrentMeds-1.0.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () =>
            {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
                return a_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () =>
            {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
                return a_;
            });


    private Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                return a_;
            });


    private Cached<IEnumerable<Encounter>> _Qualifying_Encounter_During_Day_of_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Qualifying Encounter During Day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Day_of_Measurement_Period(CqlContext context) =>
        _Qualifying_Encounter_During_Day_of_Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Encounter_to_Document_Medications(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? c_(Encounter ValidEncounter) {
                    Code<Encounter.EncounterStatus> e_ = ValidEncounter?.StatusElement;
                    Encounter.EncounterStatus? f_ = e_?.Value;
                    Code<Encounter.EncounterStatus> g_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(f_);
                    bool? h_ = context.Operators.Equal(g_, "finished");
                    CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
                    Period j_ = ValidEncounter?.Period;
                    CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                    bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, k_, "day");
                    bool? m_ = context.Operators.And(h_, l_);
                    return m_;
                }

                IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
                return d_;
            });


    private Cached<IEnumerable<Encounter>> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);
                return a_;
            });


    private Cached<IEnumerable<Encounter>> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Initial_Population(context);
                return a_;
            });


    private Cached<IEnumerable<Encounter>> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);

                IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
                    CqlCode d_ = this.Documentation_of_current_medications__procedure_(context);
                    IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
                    IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                    bool? g_(Procedure MedicationsDocumented) {

                        object k_() {

                            bool z_() {
                                DataType ad_ = MedicationsDocumented?.Performed;
                                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                                bool af_ = ae_ is CqlDateTime;
                                return af_;
                            }


                            bool aa_() {
                                DataType ag_ = MedicationsDocumented?.Performed;
                                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                                bool ai_ = ah_ is CqlInterval<CqlDateTime>;
                                return ai_;
                            }


                            bool ab_() {
                                DataType aj_ = MedicationsDocumented?.Performed;
                                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                bool al_ = ak_ is CqlQuantity;
                                return al_;
                            }


                            bool ac_() {
                                DataType am_ = MedicationsDocumented?.Performed;
                                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                                bool ao_ = an_ is CqlInterval<CqlQuantity>;
                                return ao_;
                            }

                            if (z_())
                            {
                                DataType ap_ = MedicationsDocumented?.Performed;
                                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                                return (aq_ as CqlDateTime) as object;
                            }
                            else if (aa_())
                            {
                                DataType ar_ = MedicationsDocumented?.Performed;
                                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                                return (as_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ab_())
                            {
                                DataType at_ = MedicationsDocumented?.Performed;
                                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                                return (au_ as CqlQuantity) as object;
                            }
                            else if (ac_())
                            {
                                DataType av_ = MedicationsDocumented?.Performed;
                                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                                return (aw_ as CqlInterval<CqlQuantity>) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_());
                        CqlDateTime m_ = context.Operators.Start(l_);
                        Period n_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                        bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, "day");

                        object q_() {

                            bool ax_() {
                                DataType bb_ = MedicationsDocumented?.Performed;
                                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                                bool bd_ = bc_ is CqlDateTime;
                                return bd_;
                            }


                            bool ay_() {
                                DataType be_ = MedicationsDocumented?.Performed;
                                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                                bool bg_ = bf_ is CqlInterval<CqlDateTime>;
                                return bg_;
                            }


                            bool az_() {
                                DataType bh_ = MedicationsDocumented?.Performed;
                                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                                bool bj_ = bi_ is CqlQuantity;
                                return bj_;
                            }


                            bool ba_() {
                                DataType bk_ = MedicationsDocumented?.Performed;
                                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                                bool bm_ = bl_ is CqlInterval<CqlQuantity>;
                                return bm_;
                            }

                            if (ax_())
                            {
                                DataType bn_ = MedicationsDocumented?.Performed;
                                object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                                return (bo_ as CqlDateTime) as object;
                            }
                            else if (ay_())
                            {
                                DataType bp_ = MedicationsDocumented?.Performed;
                                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                                return (bq_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (az_())
                            {
                                DataType br_ = MedicationsDocumented?.Performed;
                                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                                return (bs_ as CqlQuantity) as object;
                            }
                            else if (ba_())
                            {
                                DataType bt_ = MedicationsDocumented?.Performed;
                                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                                return (bu_ as CqlInterval<CqlQuantity>) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_());
                        bool? s_ = QICoreCommon_4_0_000.Instance.hasEnd(context, r_);
                        bool? t_ = context.Operators.And(p_, s_);
                        Code<EventStatus> u_ = MedicationsDocumented?.StatusElement;
                        EventStatus? v_ = u_?.Value;
                        string w_ = context.Operators.Convert<string>(v_);
                        bool? x_ = context.Operators.Equal(w_, "completed");
                        bool? y_ = context.Operators.And(t_, x_);
                        return y_;
                    }

                    IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
                    Encounter i_(Procedure MedicationsDocumented) => QualifyingEncounter;
                    IEnumerable<Encounter> j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);
                    return j_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Denominator_Exceptions_Cached = new();

    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context) =>
        _Denominator_Exceptions_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);

                IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
                    CqlCode d_ = this.Documentation_of_current_medications__procedure_(context);
                    IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
                    IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));

                    bool? g_(Procedure MedicationsNotDocumented) {

                        bool? k_(Extension @this) {
                            FhirUri ag_ = @this?.UrlElement;
                            FhirString ah_ = context.Operators.Convert<FhirString>(ag_);
                            string ai_ = FHIRHelpers_4_4_000.Instance.ToString(context, ah_);
                            bool? aj_ = context.Operators.Equal(ai_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                            return aj_;
                        }

                        IEnumerable<Extension> l_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationsNotDocumented is DomainResource
                            ? (MedicationsNotDocumented as DomainResource).Extension
                            : default), k_);

                        DataType m_(Extension @this) {
                            DataType ak_ = @this?.Value;
                            return ak_;
                        }

                        IEnumerable<DataType> n_ = context.Operators.Select<Extension, DataType>(l_, m_);
                        DataType o_ = context.Operators.SingletonFrom<DataType>(n_);
                        FhirDateTime p_ = context.Operators.Convert<FhirDateTime>(o_);
                        CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                        Period r_ = QualifyingEncounter?.Period;
                        CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                        bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, "day");
                        Code<EventStatus> u_ = MedicationsNotDocumented?.StatusElement;
                        EventStatus? v_ = u_?.Value;
                        string w_ = context.Operators.Convert<string>(v_);
                        bool? x_ = context.Operators.Equal(w_, "not-done");
                        bool? y_ = context.Operators.And(t_, x_);
                        List<CodeableConcept> z_ = MedicationsNotDocumented?.ReasonCode;

                        CqlConcept aa_(CodeableConcept @this) {
                            CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                            return al_;
                        }

                        IEnumerable<CqlConcept> ab_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)z_, aa_);

                        bool? ac_(CqlConcept reasonItem) {
                            CqlCode am_ = this.Acute_health_crisis__finding_(context);
                            CqlConcept an_ = context.Operators.ConvertCodeToConcept(am_);
                            bool? ao_ = context.Operators.Equivalent(reasonItem, an_);
                            return ao_;
                        }

                        IEnumerable<CqlConcept> ad_ = context.Operators.Where<CqlConcept>(ab_, ac_);
                        bool? ae_ = context.Operators.Exists<CqlConcept>(ad_);
                        bool? af_ = context.Operators.And(y_, ae_);
                        return af_;
                    }

                    IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
                    Encounter i_(Procedure MedicationsNotDocumented) => QualifyingEncounter;
                    IEnumerable<Encounter> j_ = context.Operators.Select<Procedure, Encounter>(h_, i_);
                    return j_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    #endregion Functions and Expressions

}

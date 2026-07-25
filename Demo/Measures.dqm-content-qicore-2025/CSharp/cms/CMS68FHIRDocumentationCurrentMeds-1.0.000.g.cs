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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
[CqlLibrary("CMS68FHIRDocumentationCurrentMeds", "1.0.000")]
public partial class CMS68FHIRDocumentationCurrentMeds_1_0_000 : ILibrary, ISingleton<CMS68FHIRDocumentationCurrentMeds_1_0_000>
{
    #region ValueSets (1)

    [CqlValueSetDefinition("Encounter to Document Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", valueSetVersion: null)]
    public CqlValueSet Encounter_to_Document_Medications(CqlContext _) => _Encounter_to_Document_Medications;
    private static readonly CqlValueSet _Encounter_to_Document_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", null);

    #endregion ValueSets

    #region Codes (2)

    [CqlCodeDefinition("Acute health crisis (finding)", codeId: "705016005", codeSystem: "http://snomed.info/sct")]
    public CqlCode Acute_health_crisis__finding_(CqlContext _) => _Acute_health_crisis__finding_;
    private static readonly CqlCode _Acute_health_crisis__finding_ = new CqlCode("705016005", "http://snomed.info/sct");

    [CqlCodeDefinition("Documentation of current medications (procedure)", codeId: "428191000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Documentation_of_current_medications__procedure_(CqlContext _) => _Documentation_of_current_medications__procedure_;
    private static readonly CqlCode _Documentation_of_current_medications__procedure_ = new CqlCode("428191000124101", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Acute_health_crisis__finding_,
          _Documentation_of_current_medications__procedure_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -6600664492601455279L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS68FHIRDocumentationCurrentMeds-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (10)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -6132207338760471640L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 7344199930023601664L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 6516132503073014460L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -9160309994966787356L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -2632116731490712691L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Day_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter_During_Day_of_Measurement_Period, Qualifying_Encounter_During_Day_of_Measurement_Period_Compute);

    private const long _cacheIndex_Qualifying_Encounter_During_Day_of_Measurement_Period = 9160984771370330077L;

    private IEnumerable<Encounter> Qualifying_Encounter_During_Day_of_Measurement_Period_Compute(CqlContext context)
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
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 4978643885832830831L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -5023241684628158028L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -3132146225604902195L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlCode d_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? g_(Procedure MedicationsDocumented) {
                object j_;
                DataType y_ = MedicationsDocumented?.Performed;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    DataType ab_ = MedicationsDocumented?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    j_ = ac_ as CqlDateTime;
                }
                else
                {
                    DataType ad_ = MedicationsDocumented?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlInterval<CqlDateTime>;
                    if (af_)
                    {
                        DataType ag_ = MedicationsDocumented?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        j_ = ah_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ai_ = MedicationsDocumented?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlQuantity;
                        if (ak_)
                        {
                            DataType al_ = MedicationsDocumented?.Performed;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            j_ = am_ as CqlQuantity;
                        }
                        else
                        {
                            DataType an_ = MedicationsDocumented?.Performed;
                            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            bool ap_ = ao_ is CqlInterval<CqlQuantity>;
                            if (ap_)
                            {
                                DataType aq_ = MedicationsDocumented?.Performed;
                                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                                j_ = ar_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                j_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                Period m_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                bool? o_ = context.Operators.In<CqlDateTime>(l_, n_, "day");
                object p_;
                DataType as_ = MedicationsDocumented?.Performed;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                bool au_ = at_ is CqlDateTime;
                if (au_)
                {
                    DataType av_ = MedicationsDocumented?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    p_ = aw_ as CqlDateTime;
                }
                else
                {
                    DataType ax_ = MedicationsDocumented?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlInterval<CqlDateTime>;
                    if (az_)
                    {
                        DataType ba_ = MedicationsDocumented?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        p_ = bb_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bc_ = MedicationsDocumented?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        bool be_ = bd_ is CqlQuantity;
                        if (be_)
                        {
                            DataType bf_ = MedicationsDocumented?.Performed;
                            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                            p_ = bg_ as CqlQuantity;
                        }
                        else
                        {
                            DataType bh_ = MedicationsDocumented?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            bool bj_ = bi_ is CqlInterval<CqlQuantity>;
                            if (bj_)
                            {
                                DataType bk_ = MedicationsDocumented?.Performed;
                                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                                p_ = bl_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                p_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                bool? r_ = QICoreCommon_4_0_000.Instance.hasEnd(context, q_);
                bool? s_ = context.Operators.And(o_, r_);
                Code<EventStatus> t_ = MedicationsDocumented?.StatusElement;
                EventStatus? u_ = t_?.Value;
                string v_ = context.Operators.Convert<string>(u_);
                bool? w_ = context.Operators.Equal(v_, "completed");
                bool? x_ = context.Operators.And(s_, w_);
                return x_;
            }

            IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
            bool? i_ = context.Operators.Exists<Procedure>(h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = 8528606542052243186L;

    private IEnumerable<Encounter> Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Day_of_Measurement_Period(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlCode d_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));

            bool? g_(Procedure MedicationsNotDocumented) {

                bool? j_(Extension @this) {
                    FhirUri af_ = @this?.UrlElement;
                    string ag_ = FHIRHelpers_4_4_000.Instance.ToString(context, af_);
                    bool? ah_ = context.Operators.Equal(ag_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return ah_;
                }

                IEnumerable<Extension> k_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationsNotDocumented is DomainResource
                    ? (MedicationsNotDocumented as DomainResource).Extension
                    : default), j_);

                DataType l_(Extension @this) {
                    DataType ai_ = @this?.Value;
                    return ai_;
                }

                IEnumerable<DataType> m_ = context.Operators.Select<Extension, DataType>(k_, l_);
                DataType n_ = context.Operators.SingletonFrom<DataType>(m_);
                FhirDateTime o_ = context.Operators.Convert<FhirDateTime>(n_);
                CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
                Period q_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                bool? s_ = context.Operators.In<CqlDateTime>(p_, r_, "day");
                Code<EventStatus> t_ = MedicationsNotDocumented?.StatusElement;
                EventStatus? u_ = t_?.Value;
                string v_ = context.Operators.Convert<string>(u_);
                bool? w_ = context.Operators.Equal(v_, "not-done");
                bool? x_ = context.Operators.And(s_, w_);
                List<CodeableConcept> y_ = MedicationsNotDocumented?.ReasonCode;

                CqlConcept z_(CodeableConcept @this) {
                    CqlConcept aj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return aj_;
                }

                IEnumerable<CqlConcept> aa_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)y_, z_);

                bool? ab_(CqlConcept reasonItem) {
                    CqlCode ak_ = this.Acute_health_crisis__finding_(context);
                    CqlConcept al_ = context.Operators.ConvertCodeToConcept(ak_);
                    bool? am_ = context.Operators.Equivalent(reasonItem, al_);
                    return am_;
                }

                IEnumerable<CqlConcept> ac_ = context.Operators.Where<CqlConcept>(aa_, ab_);
                bool? ad_ = context.Operators.Exists<CqlConcept>(ac_);
                bool? ae_ = context.Operators.And(x_, ad_);
                return ae_;
            }

            IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
            bool? i_ = context.Operators.Exists<Procedure>(h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS68FHIRDocumentationCurrentMeds_1_0_000() {}

    public static CMS68FHIRDocumentationCurrentMeds_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS68FHIRDocumentationCurrentMeds";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

}

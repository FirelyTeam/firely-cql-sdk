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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
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
            // CQL 'and' (38:5-39:66): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
                Period j_ = ValidEncounter?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, k_, "day");
                return h_ & l_;
            }
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
                object i_;
                DataType p_ = MedicationsDocumented?.Performed;
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                bool r_ = q_ is CqlDateTime;
                if (r_)
                {
                    DataType s_ = MedicationsDocumented?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    i_ = t_ as CqlDateTime;
                }
                else
                {
                    DataType u_ = MedicationsDocumented?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    bool w_ = v_ is CqlQuantity;
                    if (w_)
                    {
                        DataType x_ = MedicationsDocumented?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        i_ = y_ as CqlQuantity;
                    }
                    else
                    {
                        DataType z_ = MedicationsDocumented?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                        if (ab_)
                        {
                            DataType ac_ = MedicationsDocumented?.Performed;
                            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                            i_ = ad_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ae_ = MedicationsDocumented?.Performed;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            bool ag_ = af_ is CqlInterval<CqlQuantity>;
                            if (ag_)
                            {
                                DataType ah_ = MedicationsDocumented?.Performed;
                                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                                i_ = ai_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                i_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                bool? n_ = context.Operators.In<CqlDateTime>(k_, m_, "day");
                bool? o_;
                // CQL 'and' (47:17-48:69): right operand skipped when left is false
                if (n_ is false)
                {
                    o_ = false;
                }
                else
                {
                    object aj_;
                    DataType am_ = MedicationsDocumented?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlDateTime;
                    if (ao_)
                    {
                        DataType ap_ = MedicationsDocumented?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        aj_ = aq_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ar_ = MedicationsDocumented?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlQuantity;
                        if (at_)
                        {
                            DataType au_ = MedicationsDocumented?.Performed;
                            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                            aj_ = av_ as CqlQuantity;
                        }
                        else
                        {
                            DataType aw_ = MedicationsDocumented?.Performed;
                            object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                            bool ay_ = ax_ is CqlInterval<CqlDateTime>;
                            if (ay_)
                            {
                                DataType az_ = MedicationsDocumented?.Performed;
                                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                                aj_ = ba_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType bb_ = MedicationsDocumented?.Performed;
                                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                                bool bd_ = bc_ is CqlInterval<CqlQuantity>;
                                if (bd_)
                                {
                                    DataType be_ = MedicationsDocumented?.Performed;
                                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                                    aj_ = bf_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    aj_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
                    bool? al_ = QICoreCommon_4_0_000.Instance.hasEnd(context, ak_);
                    o_ = n_ & al_;
                }
                // CQL 'and' (47:17-49:54): right operand skipped when left is false
                if (o_ is false)
                {
                    return false;
                }
                else
                {
                    Code<EventStatus> bg_ = MedicationsDocumented?.StatusElement;
                    EventStatus? bh_ = bg_?.Value;
                    string bi_ = context.Operators.Convert<string>(bh_);
                    bool? bj_ = context.Operators.Equal(bi_, "completed");
                    return o_ & bj_;
                }
            }

            bool? h_ = context.Operators.WhereAny<Procedure>(f_, g_);
            return h_;
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

                bool? i_(Extension @this) {
                    FhirUri s_ = @this?.UrlElement;
                    string t_ = FHIRHelpers_4_4_000.Instance.ToString(context, s_);
                    bool? u_ = context.Operators.Equal(t_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return u_;
                }


                DataType j_(Extension @this) {
                    DataType v_ = @this?.Value;
                    return v_;
                }

                IEnumerable<DataType> k_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(MedicationsNotDocumented is DomainResource
                    ? (MedicationsNotDocumented as DomainResource).Extension
                    : default), i_, j_);
                DataType l_ = context.Operators.SingletonFrom<DataType>(k_);
                FhirDateTime m_ = context.Operators.Convert<FhirDateTime>(l_);
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                Period o_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");
                bool? r_;
                // CQL 'and' (54:17-55:56): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    Code<EventStatus> w_ = MedicationsNotDocumented?.StatusElement;
                    EventStatus? x_ = w_?.Value;
                    string y_ = context.Operators.Convert<string>(x_);
                    bool? z_ = context.Operators.Equal(y_, "not-done");
                    r_ = q_ & z_;
                }
                // CQL 'and' (54:17-58:9): right operand skipped when left is false
                if (r_ is false)
                {
                    return false;
                }
                else
                {
                    List<CodeableConcept> aa_ = MedicationsNotDocumented?.ReasonCode;

                    CqlConcept ab_(CodeableConcept @this) {
                        CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return af_;
                    }


                    bool? ac_(CqlConcept reasonItem) {
                        CqlCode ag_ = this.Acute_health_crisis__finding_(context);
                        CqlConcept ah_ = context.Operators.ConvertCodeToConcept(ag_);
                        bool? ai_ = context.Operators.Equivalent(reasonItem, ah_);
                        return ai_;
                    }

                    IEnumerable<CqlConcept> ad_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)aa_, ab_, ac_);
                    bool? ae_ = context.Operators.Exists<CqlConcept>(ad_);
                    return r_ & ae_;
                }
            }

            bool? h_ = context.Operators.WhereAny<Procedure>(f_, g_);
            return h_;
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

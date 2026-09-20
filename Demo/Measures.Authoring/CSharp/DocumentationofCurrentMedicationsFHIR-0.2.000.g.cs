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
[CqlLibrary("DocumentationofCurrentMedicationsFHIR", "0.2.000")]
public partial class DocumentationofCurrentMedicationsFHIR_0_2_000 : ILibrary, ISingleton<DocumentationofCurrentMedicationsFHIR_0_2_000>
{
    #region ValueSets (2)

    [CqlValueSetDefinition("Encounter to Document Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", valueSetVersion: null)]
    public CqlValueSet Encounter_to_Document_Medications(CqlContext _) => _Encounter_to_Document_Medications;
    private static readonly CqlValueSet _Encounter_to_Document_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Documentation of current medications (procedure)", codeId: "428191000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Documentation_of_current_medications__procedure_(CqlContext _) => _Documentation_of_current_medications__procedure_;
    private static readonly CqlCode _Documentation_of_current_medications__procedure_ = new CqlCode("428191000124101", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Documentation_of_current_medications__procedure_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 8505406452986970707L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("DocumentationofCurrentMedicationsFHIR-0.2.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (10)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 5072840030194729396L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 4563026678285367963L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 8279355005731765954L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 4711905669926677312L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 6205756164416184860L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter_during_day_of_Measurement_Period, Qualifying_Encounter_during_day_of_Measurement_Period_Compute);

    private const long _cacheIndex_Qualifying_Encounter_during_day_of_Measurement_Period = 6785879672609098054L;

    private IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period_Compute(CqlContext context)
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
            CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, j_);
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

    private const long _cacheIndex_Initial_Population = -9015171536804274875L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -159949915446618414L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 8702037301794185401L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlCode d_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? g_(Procedure MedicationsDocumented) {
                DataType i_ = MedicationsDocumented?.Performed;
                object j_ = FHIRHelpers_4_3_000.Instance.ToValue(context, i_);
                CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.End(k_);
                Period m_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
                bool? o_ = context.Operators.In<CqlDateTime>(l_, n_, (string)default);
                Code<EventStatus> p_ = MedicationsDocumented?.StatusElement;
                EventStatus? q_ = p_?.Value;
                string r_ = context.Operators.Convert<string>(q_);
                bool? s_ = context.Operators.Equal(r_, "completed");
                bool? t_ = context.Operators.And(o_, s_);
                return t_;
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

    private const long _cacheIndex_Denominator_Exceptions = -533063676253646471L;

    private IEnumerable<Encounter> Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlCode d_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));

            bool? g_(Procedure MedicationsNotDocumented) {
                List<Extension> i_ = MedicationsNotDocumented?.Extension;

                bool? j_(Extension @this) {
                    FhirUri ac_ = @this?.UrlElement;
                    string ad_ = FHIRHelpers_4_3_000.Instance.ToString(context, ac_);
                    bool? ae_ = context.Operators.Equal(ad_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return ae_;
                }


                object k_(Extension @this) {
                    DataType af_ = @this?.Value;
                    bool ag_ = af_ is Uuid;
                    if (ag_)
                    {
                        string ah_ = (af_ as Uuid)?.Value;
                        return ah_;
                    }
                    else
                    {
                        bool ai_ = af_ is Oid;
                        if (ai_)
                        {
                            string aj_ = (af_ as Oid)?.Value;
                            return aj_;
                        }
                        else
                        {
                            bool ak_ = af_ is Markdown;
                            if (ak_)
                            {
                                string al_ = (af_ as Markdown)?.Value;
                                return al_;
                            }
                            else
                            {
                                bool am_ = af_ is Integer;
                                if (am_)
                                {
                                    int? an_ = (af_ as Integer)?.Value;
                                    return an_;
                                }
                                else
                                {
                                    bool ao_ = af_ is Instant;
                                    if (ao_)
                                    {
                                        DateTimeOffset? ap_ = (af_ as Instant)?.Value;
                                        return ap_;
                                    }
                                    else
                                    {
                                        bool aq_ = af_ is Id;
                                        if (aq_)
                                        {
                                            string ar_ = (af_ as Id)?.Value;
                                            return ar_;
                                        }
                                        else
                                        {
                                            bool as_ = af_ is Duration;
                                            if (as_)
                                            {
                                                FhirDecimal at_ = (af_ as Duration)?.ValueElement;
                                                return at_;
                                            }
                                            else
                                            {
                                                bool au_ = af_ is Distance;
                                                if (au_)
                                                {
                                                    FhirDecimal av_ = (af_ as Distance)?.ValueElement;
                                                    return av_;
                                                }
                                                else
                                                {
                                                    bool aw_ = af_ is FhirDecimal;
                                                    if (aw_)
                                                    {
                                                        decimal? ax_ = (af_ as FhirDecimal)?.Value;
                                                        return ax_;
                                                    }
                                                    else
                                                    {
                                                        bool ay_ = af_ is Date;
                                                        if (ay_)
                                                        {
                                                            string az_ = (af_ as Date)?.Value;
                                                            return az_;
                                                        }
                                                        else
                                                        {
                                                            bool ba_ = af_ is Count;
                                                            if (ba_)
                                                            {
                                                                FhirDecimal bb_ = (af_ as Count)?.ValueElement;
                                                                return bb_;
                                                            }
                                                            else
                                                            {
                                                                bool bc_ = af_ is FhirDateTime;
                                                                if (bc_)
                                                                {
                                                                    string bd_ = context.Operators.Convert<string>(af_ as FhirDateTime);
                                                                    return bd_;
                                                                }
                                                                else
                                                                {
                                                                    bool be_ = af_ is Time;
                                                                    if (be_)
                                                                    {
                                                                        string bf_ = (af_ as Time)?.Value;
                                                                        return bf_;
                                                                    }
                                                                    else
                                                                    {
                                                                        bool bg_ = af_ is Age;
                                                                        if (bg_)
                                                                        {
                                                                            FhirDecimal bh_ = (af_ as Age)?.ValueElement;
                                                                            return bh_;
                                                                        }
                                                                        else
                                                                        {
                                                                            bool bi_ = af_ is FhirUrl;
                                                                            if (bi_)
                                                                            {
                                                                                string bj_ = (af_ as FhirUrl)?.Value;
                                                                                return bj_;
                                                                            }
                                                                            else
                                                                            {
                                                                                bool bk_ = af_ is FhirUri;
                                                                                if (bk_)
                                                                                {
                                                                                    string bl_ = (af_ as FhirUri)?.Value;
                                                                                    return bl_;
                                                                                }
                                                                                else
                                                                                {
                                                                                    bool bm_ = af_ is Base64Binary;
                                                                                    if (bm_)
                                                                                    {
                                                                                        byte[] bn_ = (af_ as Base64Binary)?.Value;
                                                                                        return bn_;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        bool bo_ = af_ is FhirBoolean;
                                                                                        if (bo_)
                                                                                        {
                                                                                            bool? bp_ = (af_ as FhirBoolean)?.Value;
                                                                                            return bp_;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            bool bq_ = af_ is FhirString;
                                                                                            if (bq_)
                                                                                            {
                                                                                                string br_ = (af_ as FhirString)?.Value;
                                                                                                return br_;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                bool bs_ = af_ is PositiveInt;
                                                                                                if (bs_)
                                                                                                {
                                                                                                    int? bt_ = (af_ as PositiveInt)?.Value;
                                                                                                    return bt_;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    bool bu_ = af_ is Code;
                                                                                                    if (bu_)
                                                                                                    {
                                                                                                        string bv_ = (af_ as Code)?.Value;
                                                                                                        return bv_;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        bool bw_ = af_ is UnsignedInt;
                                                                                                        if (bw_)
                                                                                                        {
                                                                                                            int? bx_ = (af_ as UnsignedInt)?.Value;
                                                                                                            return bx_;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            bool by_ = af_ is Canonical;
                                                                                                            if (by_)
                                                                                                            {
                                                                                                                string bz_ = (af_ as Canonical)?.Value;
                                                                                                                return bz_;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                bool ca_ = af_ is Quantity;
                                                                                                                if (ca_)
                                                                                                                {
                                                                                                                    FhirDecimal cb_ = (af_ as Quantity)?.ValueElement;
                                                                                                                    return cb_;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    bool cc_ = af_ is Identifier;
                                                                                                                    if (cc_)
                                                                                                                    {
                                                                                                                        FhirString cd_ = (af_ as Identifier)?.ValueElement;
                                                                                                                        return cd_;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        bool ce_ = af_ is Money;
                                                                                                                        if (ce_)
                                                                                                                        {
                                                                                                                            FhirDecimal cf_ = (af_ as Money)?.ValueElement;
                                                                                                                            return cf_;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            bool cg_ = af_ is UsageContext;
                                                                                                                            if (cg_)
                                                                                                                            {
                                                                                                                                DataType ch_ = (af_ as UsageContext)?.Value;
                                                                                                                                return ch_;
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                bool ci_ = af_ is ContactPoint;
                                                                                                                                if (ci_)
                                                                                                                                {
                                                                                                                                    FhirString cj_ = (af_ as ContactPoint)?.ValueElement;
                                                                                                                                    return cj_;
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    return null;
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                IEnumerable<object> l_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)i_, j_, k_);
                object m_ = context.Operators.SingletonFrom<object>(l_);
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>((FhirDateTime)m_);
                Period o_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, (string)default);
                Code<EventStatus> r_ = MedicationsNotDocumented?.StatusElement;
                EventStatus? s_ = r_?.Value;
                string t_ = context.Operators.Convert<string>(s_);
                bool? u_ = context.Operators.Equal(t_, "not-done");
                bool? v_ = context.Operators.And(q_, u_);
                List<CodeableConcept> w_ = MedicationsNotDocumented?.ReasonCode;

                CqlConcept x_(CodeableConcept @this) {
                    CqlConcept ck_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);
                    return ck_;
                }

                IEnumerable<CqlConcept> y_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)w_, x_);
                CqlValueSet z_ = this.Medical_Reason(context);
                bool? aa_ = context.Operators.ConceptsInValueSet(y_, z_);
                bool? ab_ = context.Operators.And(v_, aa_);
                return ab_;
            }

            bool? h_ = context.Operators.WhereAny<Procedure>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private DocumentationofCurrentMedicationsFHIR_0_2_000() {}

    public static DocumentationofCurrentMedicationsFHIR_0_2_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "DocumentationofCurrentMedicationsFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, QICoreCommon_2_0_000.Instance, SupplementalDataElements_3_4_000.Instance];

    #endregion ILibrary Implementation

}

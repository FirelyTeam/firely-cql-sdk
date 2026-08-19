#nullable enable

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
[CqlLibrary("CMS645FHIRBoneDensityPCADTherapy", "1.0.000")]
public partial class CMS645FHIRBoneDensityPCADTherapy_1_0_000 : ILibrary, ISingleton<CMS645FHIRBoneDensityPCADTherapy_1_0_000>
{
    #region ValueSets (5)

    [CqlValueSetDefinition("Androgen Deprivation Therapy for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.352", valueSetVersion: null)]
    public CqlValueSet Androgen_Deprivation_Therapy_for_Urology_Care(CqlContext _) => _Androgen_Deprivation_Therapy_for_Urology_Care;
    private static readonly CqlValueSet _Androgen_Deprivation_Therapy_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.352", null);

    [CqlValueSetDefinition("DEXA Bone Density for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.359", valueSetVersion: null)]
    public CqlValueSet DEXA_Bone_Density_for_Urology_Care(CqlContext _) => _DEXA_Bone_Density_for_Urology_Care;
    private static readonly CqlValueSet _DEXA_Bone_Density_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.359", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Patient Declined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", valueSetVersion: null)]
    public CqlValueSet Patient_Declined(CqlContext _) => _Patient_Declined;
    private static readonly CqlValueSet _Patient_Declined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", null);

    [CqlValueSetDefinition("Prostate Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", valueSetVersion: null)]
    public CqlValueSet Prostate_Cancer(CqlContext _) => _Prostate_Cancer;
    private static readonly CqlValueSet _Prostate_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Injection of leuprolide acetate for twelve month period (regime/therapy)", codeId: "456381000124102", codeSystem: "http://snomed.info/sct")]
    public CqlCode Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_(CqlContext _) => _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_;
    private static readonly CqlCode _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_ = new CqlCode("456381000124102", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -734786439587116816L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context!.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context!.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context!.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS645FHIRBoneDensityPCADTherapy-1.0.000"!, ("Measurement Period")!, c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (19)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -8229489559334500711L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context!.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context!.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Qualifying_Encounter, Has_Qualifying_Encounter_Compute);

    private const long _cacheIndex_Has_Qualifying_Encounter = 9066402021790216149L;

    private bool? Has_Qualifying_Encounter_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Office_Visit(context);
        IEnumerable<Encounter?>? b_ = context!.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter? OfficeVisit) {
            CqlInterval<CqlDateTime?>? e_ = this.Measurement_Period(context);
            Period? f_ = OfficeVisit?.Period!;
            CqlInterval<CqlDateTime?>? g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            bool? h_ = context!.Operators.IntervalIncludesInterval<CqlDateTime?>(e_, g_, "day");
            Code<Encounter.EncounterStatus>? i_ = OfficeVisit?.StatusElement!;
            Encounter.EncounterStatus? j_ = i_?.Value!;
            Code<Encounter.EncounterStatus>? k_ = context!.Operators.Convert<Code<Encounter.EncounterStatus>?>(j_);
            bool? l_ = context!.Operators.Equal(k_, "finished");
            bool? m_ = context!.Operators.And(h_, l_);
            return m_;
        }

        bool? d_ = context!.Operators.WhereAny<Encounter?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Androgen Deprivation Therapy for Urology Care Medication Active Start Dates")]
    public IEnumerable<CqlDateTime?>? Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates, Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates_Compute);

    private const long _cacheIndex_Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates = 1519890029288935373L;

    private IEnumerable<CqlDateTime?>? Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest?>? a_ = context!.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest? MR) {
            IEnumerable<Medication?>? k_ = context!.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? l_(Medication? M) {
                object? n_ = context!.Operators.LateBoundProperty<object?>(M, "id.value"!);
                object? o_ = context!.Operators.LateBoundProperty<object?>(MR, "medication.reference.value"!);
                IEnumerable<string?>? p_ = context!.Operators.Split(((string?)o_)!, "/"!);
                string? q_ = context!.Operators.Last<string?>(p_!);
                bool? r_ = context!.Operators.Equal(n_, q_);
                CodeableConcept? s_ = M?.Code!;
                CqlConcept? t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlValueSet? u_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
                bool? v_ = context!.Operators.ConceptInValueSet(t_, u_);
                bool? w_ = context!.Operators.And(r_, v_);
                return w_;
            }

            bool? m_ = context!.Operators.WhereAny<Medication?>(k_, l_);
            return m_;
        }

        IEnumerable<MedicationRequest?>? c_ = context!.Operators.Where<MedicationRequest?>(a_, b_);
        CqlValueSet? d_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest?>? e_ = context!.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? f_ = context!.Operators.Union<MedicationRequest?>(c_, e_);

        bool? g_(MedicationRequest? ADTActive) {
            Code<MedicationRequest.MedicationrequestStatus>? x_ = ADTActive?.StatusElement!;
            MedicationRequest.MedicationrequestStatus? y_ = x_?.Value!;
            string? z_ = context!.Operators.Convert<string?>(y_);
            string?[]? aa_ = [
                "active",
                "completed",
            ];
            bool? ab_ = context!.Operators.In<string?>(z_, (IEnumerable<string?>?)aa_);
            Code<MedicationRequest.MedicationRequestIntent>? ac_ = ADTActive?.IntentElement!;
            MedicationRequest.MedicationRequestIntent? ad_ = ac_?.Value!;
            string? ae_ = context!.Operators.Convert<string?>(ad_);
            string?[]? af_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ag_ = context!.Operators.In<string?>(ae_, (IEnumerable<string?>?)af_);
            bool? ah_ = context!.Operators.And(ab_, ag_);
            return ah_;
        }


        CqlDateTime? h_(MedicationRequest? ADTActive) {
            List<Dosage?>? ai_ = ADTActive?.DosageInstruction!;

            bool? aj_(Dosage? @this) {
                Timing? by_ = @this?.Timing!;
                bool? bz_ = context!.Operators.Not((bool?)(by_ is null));
                return bz_;
            }


            Timing? ak_(Dosage? @this) {
                Timing? ca_ = @this?.Timing!;
                return ca_;
            }

            IEnumerable<Timing?>? al_ = context!.Operators.WhereSelect<Dosage?, Timing?>((IEnumerable<Dosage?>?)ai_, aj_, ak_);

            CqlDateTime? am_(Timing? dosageTiming) {
                List<FhirDateTime?>? cb_ = dosageTiming?.EventElement!;

                string? cc_(FhirDateTime? @this) {
                    string? ci_ = @this?.Value!;
                    return ci_;
                }

                IEnumerable<string?>? cd_ = context!.Operators.Select<FhirDateTime?, string?>((IEnumerable<FhirDateTime?>?)cb_, cc_);

                CqlDateTime? ce_(string? @string) {
                    CqlDateTime? cj_ = context!.Operators.ConvertStringToDateTime(@string);
                    return cj_;
                }

                IEnumerable<CqlDateTime?>? cf_ = context!.Operators.Select<string?, CqlDateTime?>(cd_, ce_);
                IEnumerable<CqlDateTime?>? cg_ = context!.Operators.ListSort<CqlDateTime?>(cf_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime? ch_ = context!.Operators.First<CqlDateTime?>(cg_!);
                return ch_;
            }

            IEnumerable<CqlDateTime?>? an_ = context!.Operators.SelectDistinct<Timing?, CqlDateTime?>(al_, am_);
            IEnumerable<CqlDateTime?>? ao_ = context!.Operators.ListSort<CqlDateTime?>(an_, System.ComponentModel.ListSortDirection.Ascending);
            CqlDateTime? ap_ = context!.Operators.First<CqlDateTime?>(ao_!);

            bool? aq_(Dosage? @this) {
                Timing? ck_ = @this?.Timing!;
                bool? cl_ = context!.Operators.Not((bool?)(ck_ is null));
                return cl_;
            }


            Timing? ar_(Dosage? @this) {
                Timing? cm_ = @this?.Timing!;
                return cm_;
            }

            IEnumerable<Timing?>? as_ = context!.Operators.WhereSelect<Dosage?, Timing?>((IEnumerable<Dosage?>?)ai_, aq_, ar_);

            bool? at_(Timing? @this) {
                Timing.RepeatComponent? cn_ = @this?.Repeat!;
                bool? co_ = context!.Operators.Not((bool?)(cn_ is null));
                return co_;
            }


            Timing.RepeatComponent? au_(Timing? @this) {
                Timing.RepeatComponent? cp_ = @this?.Repeat!;
                return cp_;
            }

            IEnumerable<Timing.RepeatComponent?>? av_ = context!.Operators.WhereSelect<Timing?, Timing.RepeatComponent?>(as_, at_, au_);

            bool? aw_(Timing.RepeatComponent? @this) {
                DataType? cq_ = @this?.Bounds!;
                object? cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                bool? cs_ = context!.Operators.Not((bool?)(cr_ is null));
                return cs_;
            }


            object ax_(Timing.RepeatComponent? @this) {
                DataType? ct_ = @this?.Bounds!;
                object? cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                return cu_!;
            }

            IEnumerable<object?>? ay_ = context!.Operators.WhereSelect<Timing.RepeatComponent?, object?>(av_, aw_, ax_);

            CqlInterval<CqlDateTime?>? az_(object? DoseTime) {
                CqlInterval<CqlDateTime?>? cv_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return cv_;
            }

            IEnumerable<CqlInterval<CqlDateTime?>?>? ba_ = context!.Operators.SelectDistinct<object?, CqlInterval<CqlDateTime?>?>(ay_, az_);
            IEnumerable<CqlInterval<CqlDateTime?>?>? bb_ = context!.Operators.Collapse(ba_, (string?)default);

            object bc_(CqlInterval<CqlDateTime?>? @this) {
                CqlDateTime? cw_ = context!.Operators.Start(@this);
                return cw_!;
            }

            IEnumerable<CqlInterval<CqlDateTime?>?>? bd_ = context!.Operators.SortBy<CqlInterval<CqlDateTime?>?>(bb_!, bc_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime?>? be_ = context!.Operators.First<CqlInterval<CqlDateTime?>?>(bd_!);
            CqlDateTime? bf_ = context!.Operators.Start(be_);

            bool? bg_(Dosage? @this) {
                Timing? cx_ = @this?.Timing!;
                bool? cy_ = context!.Operators.Not((bool?)(cx_ is null));
                return cy_;
            }


            Timing? bh_(Dosage? @this) {
                Timing? cz_ = @this?.Timing!;
                return cz_;
            }

            IEnumerable<Timing?>? bi_ = context!.Operators.WhereSelect<Dosage?, Timing?>((IEnumerable<Dosage?>?)ai_, bg_, bh_);

            bool? bj_(Timing? @this) {
                Timing.RepeatComponent? da_ = @this?.Repeat!;
                bool? db_ = context!.Operators.Not((bool?)(da_ is null));
                return db_;
            }


            Timing.RepeatComponent? bk_(Timing? @this) {
                Timing.RepeatComponent? dc_ = @this?.Repeat!;
                return dc_;
            }

            IEnumerable<Timing.RepeatComponent?>? bl_ = context!.Operators.WhereSelect<Timing?, Timing.RepeatComponent?>(bi_, bj_, bk_);

            bool? bm_(Timing.RepeatComponent? @this) {
                DataType? dd_ = @this?.Bounds!;
                object? de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                bool? df_ = context!.Operators.Not((bool?)(de_ is null));
                return df_;
            }


            object bn_(Timing.RepeatComponent? @this) {
                DataType? dg_ = @this?.Bounds!;
                object? dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                return dh_!;
            }

            IEnumerable<object?>? bo_ = context!.Operators.WhereSelect<Timing.RepeatComponent?, object?>(bl_, bm_, bn_);

            CqlInterval<CqlDateTime?>? bp_(object? DoseTime) {
                CqlInterval<CqlDateTime?>? di_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return di_;
            }

            IEnumerable<CqlInterval<CqlDateTime?>?>? bq_ = context!.Operators.SelectDistinct<object?, CqlInterval<CqlDateTime?>?>(bo_, bp_);
            IEnumerable<CqlInterval<CqlDateTime?>?>? br_ = context!.Operators.Collapse(bq_, (string?)default);

            object bs_(CqlInterval<CqlDateTime?>? @this) {
                CqlDateTime? dj_ = context!.Operators.Start(@this);
                return dj_!;
            }

            IEnumerable<CqlInterval<CqlDateTime?>?>? bt_ = context!.Operators.SortBy<CqlInterval<CqlDateTime?>?>(br_!, bs_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime?>? bu_ = context!.Operators.First<CqlInterval<CqlDateTime?>?>(bt_!);
            CqlDateTime? bv_ = context!.Operators.End(bu_);
            CqlDateTime?[]? bw_ = [
                ap_,
                bf_,
                bv_,
            ];
            CqlDateTime? bx_ = context!.Operators.Min<CqlDateTime?>((IEnumerable<CqlDateTime?>?)bw_);
            return bx_;
        }

        IEnumerable<CqlDateTime?>? i_ = context!.Operators.WhereSelect<MedicationRequest?, CqlDateTime?>(f_, g_, h_);
        IEnumerable<CqlDateTime?>? j_ = context!.Operators.Distinct<CqlDateTime?>(i_!);
        return j_;
    }


    [CqlExpressionDefinition("Androgen Deprivation Therapy for Urology Care Medication Order Start Dates")]
    public IEnumerable<CqlDateTime?>? Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates, Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates_Compute);

    private const long _cacheIndex_Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates = -824991662083256949L;

    private IEnumerable<CqlDateTime?>? Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest?>? a_ = context!.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest? MR) {
            IEnumerable<Medication?>? k_ = context!.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? l_(Medication? M) {
                object? n_ = context!.Operators.LateBoundProperty<object?>(M, "id.value"!);
                object? o_ = context!.Operators.LateBoundProperty<object?>(MR, "medication.reference.value"!);
                IEnumerable<string?>? p_ = context!.Operators.Split(((string?)o_)!, "/"!);
                string? q_ = context!.Operators.Last<string?>(p_!);
                bool? r_ = context!.Operators.Equal(n_, q_);
                CodeableConcept? s_ = M?.Code!;
                CqlConcept? t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlValueSet? u_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
                bool? v_ = context!.Operators.ConceptInValueSet(t_, u_);
                bool? w_ = context!.Operators.And(r_, v_);
                return w_;
            }

            bool? m_ = context!.Operators.WhereAny<Medication?>(k_, l_);
            return m_;
        }

        IEnumerable<MedicationRequest?>? c_ = context!.Operators.Where<MedicationRequest?>(a_, b_);
        CqlValueSet? d_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest?>? e_ = context!.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest?>? f_ = context!.Operators.Union<MedicationRequest?>(c_, e_);

        bool? g_(MedicationRequest? ADTOrder) {
            Code<MedicationRequest.MedicationrequestStatus>? x_ = ADTOrder?.StatusElement!;
            MedicationRequest.MedicationrequestStatus? y_ = x_?.Value!;
            string? z_ = context!.Operators.Convert<string?>(y_);
            string?[]? aa_ = [
                "active",
                "completed",
            ];
            bool? ab_ = context!.Operators.In<string?>(z_, (IEnumerable<string?>?)aa_);
            Code<MedicationRequest.MedicationRequestIntent>? ac_ = ADTOrder?.IntentElement!;
            MedicationRequest.MedicationRequestIntent? ad_ = ac_?.Value!;
            string? ae_ = context!.Operators.Convert<string?>(ad_);
            string?[]? af_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ag_ = context!.Operators.In<string?>(ae_, (IEnumerable<string?>?)af_);
            bool? ah_ = context!.Operators.And(ab_, ag_);
            return ah_;
        }


        CqlDateTime? h_(MedicationRequest? ADTOrder) {
            FhirDateTime? ai_ = ADTOrder?.AuthoredOnElement!;
            CqlDateTime? aj_ = context!.Operators.Convert<CqlDateTime?>(ai_);
            List<Dosage?>? ak_ = ADTOrder?.DosageInstruction!;

            bool? al_(Dosage? @this) {
                Timing? bt_ = @this?.Timing!;
                bool? bu_ = context!.Operators.Not((bool?)(bt_ is null));
                return bu_;
            }


            Timing? am_(Dosage? @this) {
                Timing? bv_ = @this?.Timing!;
                return bv_;
            }

            IEnumerable<Timing?>? an_ = context!.Operators.WhereSelect<Dosage?, Timing?>((IEnumerable<Dosage?>?)ak_, al_, am_);

            bool? ao_(Timing? @this) {
                Timing.RepeatComponent? bw_ = @this?.Repeat!;
                bool? bx_ = context!.Operators.Not((bool?)(bw_ is null));
                return bx_;
            }


            Timing.RepeatComponent? ap_(Timing? @this) {
                Timing.RepeatComponent? by_ = @this?.Repeat!;
                return by_;
            }

            IEnumerable<Timing.RepeatComponent?>? aq_ = context!.Operators.WhereSelect<Timing?, Timing.RepeatComponent?>(an_, ao_, ap_);

            bool? ar_(Timing.RepeatComponent? @this) {
                DataType? bz_ = @this?.Bounds!;
                object? ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                bool? cb_ = context!.Operators.Not((bool?)(ca_ is null));
                return cb_;
            }


            object as_(Timing.RepeatComponent? @this) {
                DataType? cc_ = @this?.Bounds!;
                object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                return cd_!;
            }

            IEnumerable<object?>? at_ = context!.Operators.WhereSelect<Timing.RepeatComponent?, object?>(aq_, ar_, as_);

            CqlInterval<CqlDateTime?>? au_(object? DoseTime) {
                CqlInterval<CqlDateTime?>? ce_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return ce_;
            }

            IEnumerable<CqlInterval<CqlDateTime?>?>? av_ = context!.Operators.SelectDistinct<object?, CqlInterval<CqlDateTime?>?>(at_, au_);
            IEnumerable<CqlInterval<CqlDateTime?>?>? aw_ = context!.Operators.Collapse(av_, (string?)default);

            object ax_(CqlInterval<CqlDateTime?>? @this) {
                CqlDateTime? cf_ = context!.Operators.Start(@this);
                return cf_!;
            }

            IEnumerable<CqlInterval<CqlDateTime?>?>? ay_ = context!.Operators.SortBy<CqlInterval<CqlDateTime?>?>(aw_!, ax_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime?>? az_ = context!.Operators.First<CqlInterval<CqlDateTime?>?>(ay_!);
            CqlDateTime? ba_ = context!.Operators.Start(az_);

            bool? bb_(Dosage? @this) {
                Timing? cg_ = @this?.Timing!;
                bool? ch_ = context!.Operators.Not((bool?)(cg_ is null));
                return ch_;
            }


            Timing? bc_(Dosage? @this) {
                Timing? ci_ = @this?.Timing!;
                return ci_;
            }

            IEnumerable<Timing?>? bd_ = context!.Operators.WhereSelect<Dosage?, Timing?>((IEnumerable<Dosage?>?)ak_, bb_, bc_);

            bool? be_(Timing? @this) {
                Timing.RepeatComponent? cj_ = @this?.Repeat!;
                bool? ck_ = context!.Operators.Not((bool?)(cj_ is null));
                return ck_;
            }


            Timing.RepeatComponent? bf_(Timing? @this) {
                Timing.RepeatComponent? cl_ = @this?.Repeat!;
                return cl_;
            }

            IEnumerable<Timing.RepeatComponent?>? bg_ = context!.Operators.WhereSelect<Timing?, Timing.RepeatComponent?>(bd_, be_, bf_);

            bool? bh_(Timing.RepeatComponent? @this) {
                DataType? cm_ = @this?.Bounds!;
                object? cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                bool? co_ = context!.Operators.Not((bool?)(cn_ is null));
                return co_;
            }


            object bi_(Timing.RepeatComponent? @this) {
                DataType? cp_ = @this?.Bounds!;
                object? cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                return cq_!;
            }

            IEnumerable<object?>? bj_ = context!.Operators.WhereSelect<Timing.RepeatComponent?, object?>(bg_, bh_, bi_);

            CqlInterval<CqlDateTime?>? bk_(object? DoseTime) {
                CqlInterval<CqlDateTime?>? cr_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return cr_;
            }

            IEnumerable<CqlInterval<CqlDateTime?>?>? bl_ = context!.Operators.SelectDistinct<object?, CqlInterval<CqlDateTime?>?>(bj_, bk_);
            IEnumerable<CqlInterval<CqlDateTime?>?>? bm_ = context!.Operators.Collapse(bl_, (string?)default);

            object bn_(CqlInterval<CqlDateTime?>? @this) {
                CqlDateTime? cs_ = context!.Operators.Start(@this);
                return cs_!;
            }

            IEnumerable<CqlInterval<CqlDateTime?>?>? bo_ = context!.Operators.SortBy<CqlInterval<CqlDateTime?>?>(bm_!, bn_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime?>? bp_ = context!.Operators.First<CqlInterval<CqlDateTime?>?>(bo_!);
            CqlDateTime? bq_ = context!.Operators.End(bp_);
            CqlDateTime?[]? br_ = [
                aj_,
                ba_,
                bq_,
            ];
            CqlDateTime? bs_ = context!.Operators.Min<CqlDateTime?>((IEnumerable<CqlDateTime?>?)br_);
            return bs_;
        }

        IEnumerable<CqlDateTime?>? i_ = context!.Operators.WhereSelect<MedicationRequest?, CqlDateTime?>(f_, g_, h_);
        IEnumerable<CqlDateTime?>? j_ = context!.Operators.Distinct<CqlDateTime?>(i_!);
        return j_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential")]
    public bool? isVerified(CqlContext context, Condition? condition)
    {
        CodeableConcept? a_ = condition?.VerificationStatus!;
        CqlConcept? b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context!.Operators.Not((bool?)(b_ is null));
        CqlCode? d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept? e_ = context!.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context!.Operators.Equivalent(b_, e_);
        CqlCode? g_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept? h_ = context!.Operators.ConvertCodeToConcept(g_);
        bool? i_ = context!.Operators.Equivalent(b_, h_);
        bool? j_ = context!.Operators.Or(f_, i_);
        CqlCode? k_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept? l_ = context!.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context!.Operators.Equivalent(b_, l_);
        bool? n_ = context!.Operators.Or(j_, m_);
        CqlCode? o_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept? p_ = context!.Operators.ConvertCodeToConcept(o_);
        bool? q_ = context!.Operators.Equivalent(b_, p_);
        bool? r_ = context!.Operators.Or(n_, q_);
        bool? s_ = context!.Operators.Implies(c_, r_);
        return s_;
    }


    [CqlExpressionDefinition("Prostate Cancer Diagnosis")]
    public IEnumerable<Condition?>? Prostate_Cancer_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Prostate_Cancer_Diagnosis, Prostate_Cancer_Diagnosis_Compute);

    private const long _cacheIndex_Prostate_Cancer_Diagnosis = 7940642882909434117L;

    private IEnumerable<Condition?>? Prostate_Cancer_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Prostate_Cancer(context);
        IEnumerable<Condition?>? b_ = context!.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context!.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context!.Operators.Union<Condition?>(b_ as IEnumerable<Condition?>, c_ as IEnumerable<Condition?>);

        bool? e_(Condition? ProstateCancer) {
            CqlInterval<CqlDateTime?>? g_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ProstateCancer);
            CqlInterval<CqlDateTime?>? h_ = this.Measurement_Period(context);
            bool? i_ = context!.Operators.Overlaps(g_!, h_!, "day");
            bool? j_ = this.isVerified(context, ProstateCancer);
            bool? k_ = context!.Operators.And(i_, j_);
            return k_;
        }

        IEnumerable<Condition?>? f_ = context!.Operators.Where<Condition?>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("First ADT in 3 Months Before to 9 Months After Start of Measurement Period")]
    public CqlDateTime? First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period, First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period_Compute);

    private const long _cacheIndex_First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period = 6162761711183070057L;

    private CqlDateTime? First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<CqlDateTime?>? a_ = this.Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates(context);
        IEnumerable<CqlDateTime?>? b_ = this.Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates(context);
        IEnumerable<CqlDateTime?>? c_ = context!.Operators.Union<CqlDateTime?>(a_, b_);

        bool? d_(CqlDateTime? ADTDateTime) {
            IEnumerable<Condition?>? h_ = this.Prostate_Cancer_Diagnosis(context);

            bool? i_(Condition? ProstateCancer) {
                CqlInterval<CqlDateTime?>? k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ProstateCancer);
                bool? l_ = context!.Operators.In<CqlDateTime?>(ADTDateTime, k_, "day");
                CqlInterval<CqlDateTime?>? m_ = this.Measurement_Period(context);
                CqlDateTime? n_ = context!.Operators.Start(m_);
                CqlQuantity? o_ = context!.Operators.Quantity(3m, "months");
                CqlDateTime? p_ = context!.Operators.Subtract(n_, o_);
                CqlQuantity? q_ = context!.Operators.Quantity(9m, "months");
                CqlDateTime? r_ = context!.Operators.Add(n_, q_);
                CqlInterval<CqlDateTime?>? s_ = context!.Operators.Interval(p_, r_, true, true);
                bool? t_ = context!.Operators.In<CqlDateTime?>(ADTDateTime, s_, "day");
                bool? u_ = context!.Operators.And(l_, t_);
                return u_;
            }

            bool? j_ = context!.Operators.WhereAny<Condition?>(h_, i_);
            return j_;
        }

        IEnumerable<CqlDateTime?>? e_ = context!.Operators.Where<CqlDateTime?>(c_, d_);
        IEnumerable<CqlDateTime?>? f_ = context!.Operators.ListSort<CqlDateTime?>(e_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime? g_ = context!.Operators.First<CqlDateTime?>(f_!);
        return g_;
    }


    [CqlExpressionDefinition("Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period")]
    public IEnumerable<ServiceRequest?>? Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period, Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period_Compute);

    private const long _cacheIndex_Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period = -4992427232410550119L;

    private IEnumerable<ServiceRequest?>? Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period_Compute(CqlContext context)
    {
        CqlCode? a_ = this.Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_(context);
        IEnumerable<CqlCode?>? b_ = context!.Operators.ToList<CqlCode?>(a_);
        IEnumerable<ServiceRequest?>? c_ = context!.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? d_(ServiceRequest? OrderTwelveMonthADT) {
            CqlDateTime? f_ = this.First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            CqlDateTime?[]? g_ = [
                f_,
            ];

            bool? h_(CqlDateTime? FirstADTMP) {
                FhirDateTime? j_ = OrderTwelveMonthADT?.AuthoredOnElement!;
                CqlDateTime? k_ = context!.Operators.Convert<CqlDateTime?>(j_);
                bool? l_ = context!.Operators.SameOrAfter(k_, FirstADTMP, "day");
                CqlInterval<CqlDateTime?>? m_ = this.Measurement_Period(context);
                CqlDateTime? n_ = context!.Operators.Start(m_);
                CqlQuantity? o_ = context!.Operators.Quantity(3m, "months");
                CqlDateTime? p_ = context!.Operators.Subtract(n_, o_);
                CqlQuantity? q_ = context!.Operators.Quantity(9m, "months");
                CqlDateTime? r_ = context!.Operators.Add(n_, q_);
                CqlInterval<CqlDateTime?>? s_ = context!.Operators.Interval(p_, r_, true, true);
                bool? t_ = context!.Operators.In<CqlDateTime?>(k_, s_, "day");
                bool? u_ = context!.Operators.And(l_, t_);
                Code<RequestStatus>? v_ = OrderTwelveMonthADT?.StatusElement!;
                RequestStatus? w_ = v_?.Value!;
                Code<RequestStatus>? x_ = context!.Operators.Convert<Code<RequestStatus>?>(w_);
                string? y_ = context!.Operators.Convert<string?>(x_);
                string?[]? z_ = [
                    "active",
                    "completed",
                ];
                bool? aa_ = context!.Operators.In<string?>(y_, (IEnumerable<string?>?)z_);
                bool? ab_ = context!.Operators.And(u_, aa_);
                Code<RequestIntent>? ac_ = OrderTwelveMonthADT?.IntentElement!;
                RequestIntent? ad_ = ac_?.Value!;
                Code<RequestIntent>? ae_ = context!.Operators.Convert<Code<RequestIntent>?>(ad_);
                bool? af_ = context!.Operators.Equal(ae_, "order");
                bool? ag_ = context!.Operators.And(ab_, af_);
                return ag_;
            }

            bool? i_ = context!.Operators.WhereAny<CqlDateTime?>((IEnumerable<CqlDateTime?>?)g_, h_);
            return i_;
        }

        IEnumerable<ServiceRequest?>? e_ = context!.Operators.Where<ServiceRequest?>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 8108627335331730539L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Qualifying_Encounter(context);
        IEnumerable<ServiceRequest?>? b_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
        bool? c_ = context!.Operators.Exists<ServiceRequest?>(b_!);
        bool? d_ = context!.Operators.And(a_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 7675616901970093677L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Has Baseline DEXA Scan Two Years Prior to the Start of or Less than Three Months After the Start of ADT")]
    public bool? Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT, Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT_Compute);

    private const long _cacheIndex_Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT = -2102955111071554229L;

    private bool? Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.DEXA_Bone_Density_for_Urology_Care(context);
        IEnumerable<ServiceRequest?>? b_ = context!.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest? DEXAOrdered) {
            IEnumerable<ServiceRequest?>? n_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? o_(ServiceRequest? OrderTwelveMonthsADT) {
                FhirDateTime? q_ = DEXAOrdered?.AuthoredOnElement!;
                CqlDateTime? r_ = context!.Operators.Convert<CqlDateTime?>(q_);
                FhirDateTime? s_ = OrderTwelveMonthsADT?.AuthoredOnElement!;
                CqlDateTime? t_ = context!.Operators.Convert<CqlDateTime?>(s_);
                CqlQuantity? u_ = context!.Operators.Quantity(3m, "months");
                CqlDateTime? v_ = context!.Operators.Add(t_, u_);
                CqlInterval<CqlDateTime?>? w_ = context!.Operators.Interval(t_, v_, true, true);
                bool? x_ = context!.Operators.In<CqlDateTime?>(r_, w_, "day");
                bool? y_ = context!.Operators.Not((bool?)(t_ is null));
                bool? z_ = context!.Operators.And(x_, y_);
                CqlQuantity? aa_ = context!.Operators.Quantity(2m, "years");
                CqlDateTime? ab_ = context!.Operators.Subtract(t_, aa_);
                CqlInterval<CqlDateTime?>? ac_ = context!.Operators.Interval(ab_, t_, true, false);
                bool? ad_ = context!.Operators.In<CqlDateTime?>(r_, ac_, "day");
                bool? ae_ = context!.Operators.And(ad_, y_);
                bool? af_ = context!.Operators.Or(z_, ae_);
                return af_;
            }

            bool? p_ = context!.Operators.WhereAny<ServiceRequest?>(n_, o_);
            return p_;
        }

        IEnumerable<ServiceRequest?>? d_ = context!.Operators.Where<ServiceRequest?>(b_, c_);

        bool? e_(ServiceRequest? DEXAOrdered) {
            Code<RequestStatus>? ag_ = DEXAOrdered?.StatusElement!;
            RequestStatus? ah_ = ag_?.Value!;
            Code<RequestStatus>? ai_ = context!.Operators.Convert<Code<RequestStatus>?>(ah_);
            string? aj_ = context!.Operators.Convert<string?>(ai_);
            string?[]? ak_ = [
                "active",
                "completed",
            ];
            bool? al_ = context!.Operators.In<string?>(aj_, (IEnumerable<string?>?)ak_);
            Code<RequestIntent>? am_ = DEXAOrdered?.IntentElement!;
            RequestIntent? an_ = am_?.Value!;
            Code<RequestIntent>? ao_ = context!.Operators.Convert<Code<RequestIntent>?>(an_);
            bool? ap_ = context!.Operators.Equal(ao_, "order");
            bool? aq_ = context!.Operators.And(al_, ap_);
            return aq_;
        }

        IEnumerable<ServiceRequest?>? f_ = context!.Operators.Where<ServiceRequest?>(d_, e_);
        IEnumerable<Observation?>? g_ = context!.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? h_(Observation? DEXAPerformed) {
            IEnumerable<ServiceRequest?>? ar_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? as_(ServiceRequest? OrderTwelveMonthsADT) {
                DataType? au_ = DEXAPerformed?.Effective!;
                object? av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                CqlInterval<CqlDateTime?>? aw_ = QICoreCommon_4_0_000.Instance.toInterval(context, av_);
                CqlDateTime? ax_ = context!.Operators.Start(aw_);
                FhirDateTime? ay_ = OrderTwelveMonthsADT?.AuthoredOnElement!;
                CqlDateTime? az_ = context!.Operators.Convert<CqlDateTime?>(ay_);
                CqlQuantity? ba_ = context!.Operators.Quantity(3m, "months");
                CqlDateTime? bb_ = context!.Operators.Add(az_, ba_);
                CqlInterval<CqlDateTime?>? bc_ = context!.Operators.Interval(az_, bb_, true, true);
                bool? bd_ = context!.Operators.In<CqlDateTime?>(ax_, bc_, "day");
                bool? be_ = context!.Operators.Not((bool?)(az_ is null));
                bool? bf_ = context!.Operators.And(bd_, be_);
                CqlDateTime? bg_ = context!.Operators.End(aw_);
                CqlQuantity? bh_ = context!.Operators.Quantity(2m, "years");
                CqlDateTime? bi_ = context!.Operators.Subtract(az_, bh_);
                CqlInterval<CqlDateTime?>? bj_ = context!.Operators.Interval(bi_, az_, true, false);
                bool? bk_ = context!.Operators.In<CqlDateTime?>(bg_, bj_, "day");
                bool? bl_ = context!.Operators.And(bk_, be_);
                bool? bm_ = context!.Operators.Or(bf_, bl_);
                return bm_;
            }

            bool? at_ = context!.Operators.WhereAny<ServiceRequest?>(ar_, as_);
            return at_;
        }

        IEnumerable<Observation?>? i_ = context!.Operators.Where<Observation?>(g_, h_);

        bool? j_(Observation? DEXAPerformed) {
            Code<ObservationStatus>? bn_ = DEXAPerformed?.StatusElement!;
            ObservationStatus? bo_ = bn_?.Value!;
            string? bp_ = context!.Operators.Convert<string?>(bo_);
            string?[]? bq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? br_ = context!.Operators.In<string?>(bp_, (IEnumerable<string?>?)bq_);
            return br_;
        }

        IEnumerable<Observation?>? k_ = context!.Operators.Where<Observation?>(i_, j_);
        IEnumerable<object?>? l_ = context!.Operators.Union<object?>(f_ as IEnumerable<object?>, k_ as IEnumerable<object?>);
        bool? m_ = context!.Operators.Exists<object?>(l_!);
        return m_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 8957501733843970185L;

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT(context);
        return a_;
    }


    [CqlExpressionDefinition("No Bone Density Scan Ordered Due to Patient Refusal")]
    public IEnumerable<ServiceRequest?>? No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal, No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal_Compute);

    private const long _cacheIndex_No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal = 6622458788790457350L;

    private IEnumerable<ServiceRequest?>? No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.DEXA_Bone_Density_for_Urology_Care(context);
        IEnumerable<ServiceRequest?>? b_ = context!.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest?>? c_ = context!.Operators.Union<ServiceRequest?>(b_, b_);

        bool? d_(ServiceRequest? DEXANotOrdered) {
            IEnumerable<ServiceRequest?>? f_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? g_(ServiceRequest? OrderTwelveMonthsADT) {
                FhirDateTime? i_ = DEXANotOrdered?.AuthoredOnElement!;
                CqlDateTime? j_ = context!.Operators.Convert<CqlDateTime?>(i_);
                FhirDateTime? k_ = OrderTwelveMonthsADT?.AuthoredOnElement!;
                CqlDateTime? l_ = context!.Operators.Convert<CqlDateTime?>(k_);
                CqlQuantity? m_ = context!.Operators.Quantity(3m, "months");
                CqlDateTime? n_ = context!.Operators.Add(l_, m_);
                CqlInterval<CqlDateTime?>? o_ = context!.Operators.Interval(l_, n_, true, true);
                bool? p_ = context!.Operators.In<CqlDateTime?>(j_, o_, "day");
                bool? q_ = context!.Operators.Not((bool?)(l_ is null));
                bool? r_ = context!.Operators.And(p_, q_);

                bool? s_(Extension? @this) {
                    FhirUri? aa_ = @this?.UrlElement!;
                    string? ab_ = FHIRHelpers_4_4_000.Instance.ToString(context, aa_);
                    bool? ac_ = context!.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return ac_;
                }


                object t_(Extension? @this) {
                    DataType? ad_ = @this?.Value!;
                    return ad_!;
                }

                IEnumerable<object?>? u_ = context!.Operators.WhereSelect<Extension?, object?>((IEnumerable<Extension?>?)(DEXANotOrdered is DomainResource
                    ? (DEXANotOrdered as DomainResource)!.Extension
                    : default), s_, t_);
                object? v_ = context!.Operators.SingletonFrom<object?>(u_);
                CqlConcept? w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
                CqlValueSet? x_ = this.Patient_Declined(context);
                bool? y_ = context!.Operators.ConceptInValueSet(w_, x_);
                bool? z_ = context!.Operators.And(r_, y_);
                return z_;
            }

            bool? h_ = context!.Operators.WhereAny<ServiceRequest?>(f_, g_);
            return h_;
        }

        IEnumerable<ServiceRequest?>? e_ = context!.Operators.Where<ServiceRequest?>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("No Bone Density Scan Performed Due to Patient Refusal")]
    public IEnumerable<Observation?>? No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal, No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal_Compute);

    private const long _cacheIndex_No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal = -3751061519719478956L;

    private IEnumerable<Observation?>? No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.DEXA_Bone_Density_for_Urology_Care(context);
        IEnumerable<Observation?>? b_ = context!.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
        IEnumerable<Observation?>? c_ = context!.Operators.Union<Observation?>(b_, b_);

        bool? d_(Observation? DEXANotPerformed) {
            IEnumerable<ServiceRequest?>? f_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? g_(ServiceRequest? OrderTwelveMonthsADT) {
                Instant? i_ = DEXANotPerformed?.IssuedElement!;
                DateTimeOffset? j_ = i_?.Value!;
                CqlDateTime? k_ = context!.Operators.Convert<CqlDateTime?>(j_);
                FhirDateTime? l_ = OrderTwelveMonthsADT?.AuthoredOnElement!;
                CqlDateTime? m_ = context!.Operators.Convert<CqlDateTime?>(l_);
                CqlQuantity? n_ = context!.Operators.Quantity(3m, "months");
                CqlDateTime? o_ = context!.Operators.Add(m_, n_);
                CqlInterval<CqlDateTime?>? p_ = context!.Operators.Interval(m_, o_, true, true);
                bool? q_ = context!.Operators.In<CqlDateTime?>(k_, p_, "day");
                bool? r_ = context!.Operators.Not((bool?)(m_ is null));
                bool? s_ = context!.Operators.And(q_, r_);

                bool? t_(Extension? @this) {
                    FhirUri? ab_ = @this?.UrlElement!;
                    string? ac_ = FHIRHelpers_4_4_000.Instance.ToString(context, ab_);
                    bool? ad_ = context!.Operators.Equal(ac_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return ad_;
                }


                object u_(Extension? @this) {
                    DataType? ae_ = @this?.Value!;
                    return ae_!;
                }

                IEnumerable<object?>? v_ = context!.Operators.WhereSelect<Extension?, object?>((IEnumerable<Extension?>?)(DEXANotPerformed is DomainResource
                    ? (DEXANotPerformed as DomainResource)!.Extension
                    : default), t_, u_);
                object? w_ = context!.Operators.SingletonFrom<object?>(v_);
                CqlConcept? x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_ as CodeableConcept);
                CqlValueSet? y_ = this.Patient_Declined(context);
                bool? z_ = context!.Operators.ConceptInValueSet(x_, y_);
                bool? aa_ = context!.Operators.And(s_, z_);
                return aa_;
            }

            bool? h_ = context!.Operators.WhereAny<ServiceRequest?>(f_, g_);
            return h_;
        }

        IEnumerable<Observation?>? e_ = context!.Operators.Where<Observation?>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Denominator Exception")]
    public bool? Denominator_Exception(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exception, Denominator_Exception_Compute);

    private const long _cacheIndex_Denominator_Exception = -7408022328034518701L;

    private bool? Denominator_Exception_Compute(CqlContext context)
    {
        IEnumerable<ServiceRequest?>? a_ = this.No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal(context);
        bool? b_ = context!.Operators.Exists<ServiceRequest?>(a_!);
        IEnumerable<Observation?>? c_ = this.No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal(context);
        bool? d_ = context!.Operators.Exists<Observation?>(c_!);
        bool? e_ = context!.Operators.Or(b_, d_);
        return e_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -897900695652524114L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -7384445363689136194L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -136145099253049696L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 5984134809747202532L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS645FHIRBoneDensityPCADTherapy_1_0_000() {}

    public static CMS645FHIRBoneDensityPCADTherapy_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS645FHIRBoneDensityPCADTherapy";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}

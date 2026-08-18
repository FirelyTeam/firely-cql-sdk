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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
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
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -734786439587116816L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS645FHIRBoneDensityPCADTherapy-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (19)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -8229489559334500711L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Qualifying_Encounter, Has_Qualifying_Encounter_Compute);

    private const long _cacheIndex_Has_Qualifying_Encounter = 9066402021790216149L;

    private bool? Has_Qualifying_Encounter_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter OfficeVisit) {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            Period f_ = OfficeVisit?.Period;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            CqlBoolean h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");
            Code<Encounter.EncounterStatus> i_ = OfficeVisit?.StatusElement;
            Encounter.EncounterStatus? j_ = i_?.Value;
            Code<Encounter.EncounterStatus> k_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(j_);
            CqlBoolean l_ = context.Operators.Equal(k_, "finished");
            CqlBoolean m_ = l_;
            return h_
                /* CQL 'and' (136:7-137:43) */ && m_;
        }

        CqlBoolean d_ = context.Operators.WhereAny<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Androgen Deprivation Therapy for Urology Care Medication Active Start Dates")]
    public IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates, Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates_Compute);

    private const long _cacheIndex_Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates = 1519890029288935373L;

    private IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> k_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? l_(Medication M) {
                object n_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> p_ = context.Operators.Split((string)o_, "/");
                string q_ = context.Operators.Last<string>(p_);
                CqlBoolean r_ = context.Operators.Equal(n_, q_);
                CodeableConcept s_ = M?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlValueSet u_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
                CqlBoolean v_ = context.Operators.ConceptInValueSet(t_, u_);
                CqlBoolean w_ = v_;
                return r_
                    /* CQL 'and' */ && w_;
            }

            CqlBoolean m_ = context.Operators.WhereAny<Medication>(k_, l_);
            return m_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ADTActive) {
            Code<MedicationRequest.MedicationrequestStatus> x_ = ADTActive?.StatusElement;
            MedicationRequest.MedicationrequestStatus? y_ = x_?.Value;
            string z_ = context.Operators.Convert<string>(y_);
            string[] aa_ = [
                "active",
                "completed",
            ];
            CqlBoolean ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
            Code<MedicationRequest.MedicationRequestIntent> ac_ = ADTActive?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ad_ = ac_?.Value;
            string ae_ = context.Operators.Convert<string>(ad_);
            string[] af_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            CqlBoolean ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
            CqlBoolean ah_ = ag_;
            return ab_
                /* CQL 'and' (116:5-117:109) */ && ah_;
        }


        CqlDateTime h_(MedicationRequest ADTActive) {
            List<Dosage> ai_ = ADTActive?.DosageInstruction;

            bool? aj_(Dosage @this) {
                Timing by_ = @this?.Timing;
                return by_ is not null;
            }


            Timing ak_(Dosage @this) {
                Timing bz_ = @this?.Timing;
                return bz_;
            }

            IEnumerable<Timing> al_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ai_, aj_, ak_);

            CqlDateTime am_(Timing dosageTiming) {
                List<FhirDateTime> ca_ = dosageTiming?.EventElement;

                string cb_(FhirDateTime @this) {
                    string ch_ = @this?.Value;
                    return ch_;
                }

                IEnumerable<string> cc_ = context.Operators.Select<FhirDateTime, string>((IEnumerable<FhirDateTime>)ca_, cb_);

                CqlDateTime cd_(string @string) {
                    CqlDateTime ci_ = context.Operators.ConvertStringToDateTime(@string);
                    return ci_;
                }

                IEnumerable<CqlDateTime> ce_ = context.Operators.Select<string, CqlDateTime>(cc_, cd_);
                IEnumerable<CqlDateTime> cf_ = context.Operators.ListSort<CqlDateTime>(ce_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime cg_ = context.Operators.First<CqlDateTime>(cf_);
                return cg_;
            }

            IEnumerable<CqlDateTime> an_ = context.Operators.SelectDistinct<Timing, CqlDateTime>(al_, am_);
            IEnumerable<CqlDateTime> ao_ = context.Operators.ListSort<CqlDateTime>(an_, System.ComponentModel.ListSortDirection.Ascending);
            CqlDateTime ap_ = context.Operators.First<CqlDateTime>(ao_);

            bool? aq_(Dosage @this) {
                Timing cj_ = @this?.Timing;
                return cj_ is not null;
            }


            Timing ar_(Dosage @this) {
                Timing ck_ = @this?.Timing;
                return ck_;
            }

            IEnumerable<Timing> as_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ai_, aq_, ar_);

            bool? at_(Timing @this) {
                Timing.RepeatComponent cl_ = @this?.Repeat;
                return cl_ is not null;
            }


            Timing.RepeatComponent au_(Timing @this) {
                Timing.RepeatComponent cm_ = @this?.Repeat;
                return cm_;
            }

            IEnumerable<Timing.RepeatComponent> av_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(as_, at_, au_);

            bool? aw_(Timing.RepeatComponent @this) {
                DataType cn_ = @this?.Bounds;
                object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                return co_ is not null;
            }


            object ax_(Timing.RepeatComponent @this) {
                DataType cp_ = @this?.Bounds;
                object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                return cq_;
            }

            IEnumerable<object> ay_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(av_, aw_, ax_);

            CqlInterval<CqlDateTime> az_(object DoseTime) {
                CqlInterval<CqlDateTime> cr_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return cr_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> ba_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(ay_, az_);
            IEnumerable<CqlInterval<CqlDateTime>> bb_ = context.Operators.Collapse(ba_, (string)default);

            object bc_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime cs_ = context.Operators.Start(@this);
                return cs_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bd_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bb_, bc_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> be_ = context.Operators.First<CqlInterval<CqlDateTime>>(bd_);
            CqlDateTime bf_ = context.Operators.Start(be_);

            bool? bg_(Dosage @this) {
                Timing ct_ = @this?.Timing;
                return ct_ is not null;
            }


            Timing bh_(Dosage @this) {
                Timing cu_ = @this?.Timing;
                return cu_;
            }

            IEnumerable<Timing> bi_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ai_, bg_, bh_);

            bool? bj_(Timing @this) {
                Timing.RepeatComponent cv_ = @this?.Repeat;
                return cv_ is not null;
            }


            Timing.RepeatComponent bk_(Timing @this) {
                Timing.RepeatComponent cw_ = @this?.Repeat;
                return cw_;
            }

            IEnumerable<Timing.RepeatComponent> bl_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(bi_, bj_, bk_);

            bool? bm_(Timing.RepeatComponent @this) {
                DataType cx_ = @this?.Bounds;
                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                return cy_ is not null;
            }


            object bn_(Timing.RepeatComponent @this) {
                DataType cz_ = @this?.Bounds;
                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                return da_;
            }

            IEnumerable<object> bo_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(bl_, bm_, bn_);

            CqlInterval<CqlDateTime> bp_(object DoseTime) {
                CqlInterval<CqlDateTime> db_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return db_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bq_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(bo_, bp_);
            IEnumerable<CqlInterval<CqlDateTime>> br_ = context.Operators.Collapse(bq_, (string)default);

            object bs_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime dc_ = context.Operators.Start(@this);
                return dc_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bt_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(br_, bs_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bu_ = context.Operators.First<CqlInterval<CqlDateTime>>(bt_);
            CqlDateTime bv_ = context.Operators.End(bu_);
            CqlDateTime[] bw_ = [
                ap_,
                bf_,
                bv_,
            ];
            CqlDateTime bx_ = context.Operators.Min<CqlDateTime>((IEnumerable<CqlDateTime>)bw_);
            return bx_;
        }

        IEnumerable<CqlDateTime> i_ = context.Operators.WhereSelect<MedicationRequest, CqlDateTime>(f_, g_, h_);
        IEnumerable<CqlDateTime> j_ = context.Operators.Distinct<CqlDateTime>(i_);
        return j_;
    }


    [CqlExpressionDefinition("Androgen Deprivation Therapy for Urology Care Medication Order Start Dates")]
    public IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates, Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates_Compute);

    private const long _cacheIndex_Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates = -824991662083256949L;

    private IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> k_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? l_(Medication M) {
                object n_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> p_ = context.Operators.Split((string)o_, "/");
                string q_ = context.Operators.Last<string>(p_);
                CqlBoolean r_ = context.Operators.Equal(n_, q_);
                CodeableConcept s_ = M?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlValueSet u_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
                CqlBoolean v_ = context.Operators.ConceptInValueSet(t_, u_);
                CqlBoolean w_ = v_;
                return r_
                    /* CQL 'and' */ && w_;
            }

            CqlBoolean m_ = context.Operators.WhereAny<Medication>(k_, l_);
            return m_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ADTOrder) {
            Code<MedicationRequest.MedicationrequestStatus> x_ = ADTOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? y_ = x_?.Value;
            string z_ = context.Operators.Convert<string>(y_);
            string[] aa_ = [
                "active",
                "completed",
            ];
            CqlBoolean ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
            Code<MedicationRequest.MedicationRequestIntent> ac_ = ADTOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ad_ = ac_?.Value;
            string ae_ = context.Operators.Convert<string>(ad_);
            string[] af_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            CqlBoolean ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
            CqlBoolean ah_ = ag_;
            return ab_
                /* CQL 'and' (130:5-131:108) */ && ah_;
        }


        CqlDateTime h_(MedicationRequest ADTOrder) {
            FhirDateTime ai_ = ADTOrder?.AuthoredOnElement;
            CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(ai_);
            List<Dosage> ak_ = ADTOrder?.DosageInstruction;

            bool? al_(Dosage @this) {
                Timing bt_ = @this?.Timing;
                return bt_ is not null;
            }


            Timing am_(Dosage @this) {
                Timing bu_ = @this?.Timing;
                return bu_;
            }

            IEnumerable<Timing> an_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ak_, al_, am_);

            bool? ao_(Timing @this) {
                Timing.RepeatComponent bv_ = @this?.Repeat;
                return bv_ is not null;
            }


            Timing.RepeatComponent ap_(Timing @this) {
                Timing.RepeatComponent bw_ = @this?.Repeat;
                return bw_;
            }

            IEnumerable<Timing.RepeatComponent> aq_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(an_, ao_, ap_);

            bool? ar_(Timing.RepeatComponent @this) {
                DataType bx_ = @this?.Bounds;
                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                return by_ is not null;
            }


            object as_(Timing.RepeatComponent @this) {
                DataType bz_ = @this?.Bounds;
                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                return ca_;
            }

            IEnumerable<object> at_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(aq_, ar_, as_);

            CqlInterval<CqlDateTime> au_(object DoseTime) {
                CqlInterval<CqlDateTime> cb_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return cb_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> av_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(at_, au_);
            IEnumerable<CqlInterval<CqlDateTime>> aw_ = context.Operators.Collapse(av_, (string)default);

            object ax_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime cc_ = context.Operators.Start(@this);
                return cc_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> ay_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> az_ = context.Operators.First<CqlInterval<CqlDateTime>>(ay_);
            CqlDateTime ba_ = context.Operators.Start(az_);

            bool? bb_(Dosage @this) {
                Timing cd_ = @this?.Timing;
                return cd_ is not null;
            }


            Timing bc_(Dosage @this) {
                Timing ce_ = @this?.Timing;
                return ce_;
            }

            IEnumerable<Timing> bd_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ak_, bb_, bc_);

            bool? be_(Timing @this) {
                Timing.RepeatComponent cf_ = @this?.Repeat;
                return cf_ is not null;
            }


            Timing.RepeatComponent bf_(Timing @this) {
                Timing.RepeatComponent cg_ = @this?.Repeat;
                return cg_;
            }

            IEnumerable<Timing.RepeatComponent> bg_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(bd_, be_, bf_);

            bool? bh_(Timing.RepeatComponent @this) {
                DataType ch_ = @this?.Bounds;
                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                return ci_ is not null;
            }


            object bi_(Timing.RepeatComponent @this) {
                DataType cj_ = @this?.Bounds;
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                return ck_;
            }

            IEnumerable<object> bj_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(bg_, bh_, bi_);

            CqlInterval<CqlDateTime> bk_(object DoseTime) {
                CqlInterval<CqlDateTime> cl_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return cl_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bl_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(bj_, bk_);
            IEnumerable<CqlInterval<CqlDateTime>> bm_ = context.Operators.Collapse(bl_, (string)default);

            object bn_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime cm_ = context.Operators.Start(@this);
                return cm_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bo_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bm_, bn_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bp_ = context.Operators.First<CqlInterval<CqlDateTime>>(bo_);
            CqlDateTime bq_ = context.Operators.End(bp_);
            CqlDateTime[] br_ = [
                aj_,
                ba_,
                bq_,
            ];
            CqlDateTime bs_ = context.Operators.Min<CqlDateTime>((IEnumerable<CqlDateTime>)br_);
            return bs_;
        }

        IEnumerable<CqlDateTime> i_ = context.Operators.WhereSelect<MedicationRequest, CqlDateTime>(f_, g_, h_);
        IEnumerable<CqlDateTime> j_ = context.Operators.Distinct<CqlDateTime>(i_);
        return j_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode c_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        CqlBoolean e_ = context.Operators.Equivalent(b_, d_);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        CqlBoolean h_ = context.Operators.Equivalent(b_, g_);
        CqlBoolean i_ = h_;
        CqlCode j_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
        CqlBoolean l_ = context.Operators.Equivalent(b_, k_);
        CqlBoolean m_ = l_;
        CqlCode n_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
        CqlBoolean p_ = context.Operators.Equivalent(b_, o_);
        CqlBoolean q_ = p_;
        CqlBoolean r_ = e_
            /* CQL 'or' (152:54-153:66) */ || i_
            /* CQL 'or' (152:54-154:66) */ || m_
            /* CQL 'or' (152:52-156:3) */ || q_;
        return (CqlBoolean)(b_ is null)
            /* CQL 'implies' (152:3-156:3) */ || r_;
    }


    [CqlExpressionDefinition("Prostate Cancer Diagnosis")]
    public IEnumerable<Condition> Prostate_Cancer_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Prostate_Cancer_Diagnosis, Prostate_Cancer_Diagnosis_Compute);

    private const long _cacheIndex_Prostate_Cancer_Diagnosis = 7940642882909434117L;

    private IEnumerable<Condition> Prostate_Cancer_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Prostate_Cancer(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition ProstateCancer) {
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ProstateCancer);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            CqlBoolean i_ = context.Operators.Overlaps(g_, h_, "day");
            return i_
                /* CQL 'and' (143:5-144:39) */ && this.isVerified(context, ProstateCancer);
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("First ADT in 3 Months Before to 9 Months After Start of Measurement Period")]
    public CqlDateTime First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period, First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period_Compute);

    private const long _cacheIndex_First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period = 6162761711183070057L;

    private CqlDateTime First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<CqlDateTime> a_ = this.Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates(context);
        IEnumerable<CqlDateTime> b_ = this.Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates(context);
        IEnumerable<CqlDateTime> c_ = context.Operators.Union<CqlDateTime>(a_, b_);

        bool? d_(CqlDateTime ADTDateTime) {
            IEnumerable<Condition> h_ = this.Prostate_Cancer_Diagnosis(context);

            bool? i_(Condition ProstateCancer) {
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ProstateCancer);
                CqlBoolean l_ = context.Operators.In<CqlDateTime>(ADTDateTime, k_, "day");
                CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(3m, "months");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                CqlQuantity q_ = context.Operators.Quantity(9m, "months");
                CqlDateTime r_ = context.Operators.Add(n_, q_);
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(p_, r_, true, true);
                CqlBoolean t_ = context.Operators.In<CqlDateTime>(ADTDateTime, s_, "day");
                CqlBoolean u_ = t_;
                return l_
                    /* CQL 'and' (82:19-83:132) */ && u_;
            }

            CqlBoolean j_ = context.Operators.WhereAny<Condition>(h_, i_);
            return j_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.Where<CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.ListSort<CqlDateTime>(e_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime g_ = context.Operators.First<CqlDateTime>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period")]
    public IEnumerable<ServiceRequest> Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period, Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period_Compute);

    private const long _cacheIndex_Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period = -4992427232410550119L;

    private IEnumerable<ServiceRequest> Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period_Compute(CqlContext context)
    {
        CqlCode a_ = this.Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<ServiceRequest> c_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? d_(ServiceRequest OrderTwelveMonthADT) {
            CqlDateTime f_ = this.First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            CqlDateTime[] g_ = [
                f_,
            ];

            bool? h_(CqlDateTime FirstADTMP) {
                FhirDateTime j_ = OrderTwelveMonthADT?.AuthoredOnElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                CqlBoolean l_ = context.Operators.SameOrAfter(k_, FirstADTMP, "day");
                CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(3m, "months");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                CqlQuantity q_ = context.Operators.Quantity(9m, "months");
                CqlDateTime r_ = context.Operators.Add(n_, q_);
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(p_, r_, true, true);
                CqlBoolean t_ = context.Operators.In<CqlDateTime>(k_, s_, "day");
                CqlBoolean u_ = t_;
                Code<RequestStatus> v_ = OrderTwelveMonthADT?.StatusElement;
                RequestStatus? w_ = v_?.Value;
                Code<RequestStatus> x_ = context.Operators.Convert<Code<RequestStatus>>(w_);
                string y_ = context.Operators.Convert<string>(x_);
                string[] z_ = [
                    "active",
                    "completed",
                ];
                CqlBoolean aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
                CqlBoolean ab_ = aa_;
                Code<RequestIntent> ac_ = OrderTwelveMonthADT?.IntentElement;
                RequestIntent? ad_ = ac_?.Value;
                Code<RequestIntent> ae_ = context.Operators.Convert<Code<RequestIntent>>(ad_);
                CqlBoolean af_ = context.Operators.Equal(ae_, "order");
                CqlBoolean ag_ = af_;
                return l_
                    /* CQL 'and' (90:17-91:149) */ && u_
                    /* CQL 'and' (90:17-92:67) */ && ab_
                    /* CQL 'and' (90:17-93:48) */ && ag_;
            }

            CqlBoolean i_ = context.Operators.WhereAny<CqlDateTime>((IEnumerable<CqlDateTime>)g_, h_);
            return i_;
        }

        IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 8108627335331730539L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Has_Qualifying_Encounter(context);
        IEnumerable<ServiceRequest> b_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
        CqlBoolean c_ = context.Operators.Exists<ServiceRequest>(b_);
        CqlBoolean d_ = c_;
        return a_
            /* CQL 'and' (25:3-26:108) */ && d_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 7675616901970093677L;

    private bool? Denominator_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Has Baseline DEXA Scan Two Years Prior to the Start of or Less than Three Months After the Start of ADT")]
    public bool? Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT, Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT_Compute);

    private const long _cacheIndex_Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT = -2102955111071554229L;

    private bool? Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.DEXA_Bone_Density_for_Urology_Care(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest DEXAOrdered) {
            IEnumerable<ServiceRequest> n_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? o_(ServiceRequest OrderTwelveMonthsADT) {
                FhirDateTime q_ = DEXAOrdered?.AuthoredOnElement;
                CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
                FhirDateTime s_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(s_);
                CqlQuantity u_ = context.Operators.Quantity(3m, "months");
                CqlDateTime v_ = context.Operators.Add(t_, u_);
                CqlInterval<CqlDateTime> w_ = context.Operators.Interval(t_, v_, true, true);
                CqlBoolean x_ = context.Operators.In<CqlDateTime>(r_, w_, "day");
                CqlBoolean y_ = (CqlBoolean)(t_ is not null);
                CqlQuantity z_ = context.Operators.Quantity(2m, "years");
                CqlDateTime aa_ = context.Operators.Subtract(t_, z_);
                CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(aa_, t_, true, false);
                CqlBoolean ac_ = context.Operators.In<CqlDateTime>(r_, ab_, "day");
                CqlBoolean ad_ = ac_
                    /* CQL 'and' (54:16-54:99) */ && y_;
                return (x_
                    /* CQL 'and' (53:21-53:110) */ && y_)
                    /* CQL 'or' (53:21-54:99) */ || ad_;
            }

            CqlBoolean p_ = context.Operators.WhereAny<ServiceRequest>(n_, o_);
            return p_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        bool? e_(ServiceRequest DEXAOrdered) {
            Code<RequestStatus> ae_ = DEXAOrdered?.StatusElement;
            RequestStatus? af_ = ae_?.Value;
            Code<RequestStatus> ag_ = context.Operators.Convert<Code<RequestStatus>>(af_);
            string ah_ = context.Operators.Convert<string>(ag_);
            string[] ai_ = [
                "active",
                "completed",
            ];
            CqlBoolean aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
            Code<RequestIntent> ak_ = DEXAOrdered?.IntentElement;
            RequestIntent? al_ = ak_?.Value;
            Code<RequestIntent> am_ = context.Operators.Convert<Code<RequestIntent>>(al_);
            CqlBoolean an_ = context.Operators.Equal(am_, "order");
            CqlBoolean ao_ = an_;
            return aj_
                /* CQL 'and' (55:9-56:42) */ && ao_;
        }

        IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? h_(Observation DEXAPerformed) {
            IEnumerable<ServiceRequest> ap_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? aq_(ServiceRequest OrderTwelveMonthsADT) {
                DataType as_ = DEXAPerformed?.Effective;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_);
                CqlDateTime av_ = context.Operators.Start(au_);
                FhirDateTime aw_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime ax_ = context.Operators.Convert<CqlDateTime>(aw_);
                CqlQuantity ay_ = context.Operators.Quantity(3m, "months");
                CqlDateTime az_ = context.Operators.Add(ax_, ay_);
                CqlInterval<CqlDateTime> ba_ = context.Operators.Interval(ax_, az_, true, true);
                CqlBoolean bb_ = context.Operators.In<CqlDateTime>(av_, ba_, "day");
                CqlBoolean bc_ = (CqlBoolean)(ax_ is not null);
                CqlDateTime bd_ = context.Operators.End(au_);
                CqlQuantity be_ = context.Operators.Quantity(2m, "years");
                CqlDateTime bf_ = context.Operators.Subtract(ax_, be_);
                CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(bf_, ax_, true, false);
                CqlBoolean bh_ = context.Operators.In<CqlDateTime>(bd_, bg_, "day");
                CqlBoolean bi_ = bh_
                    /* CQL 'and' (61:18-61:117) */ && bc_;
                return (bb_
                    /* CQL 'and' (60:23-60:128) */ && bc_)
                    /* CQL 'or' (60:23-61:117) */ || bi_;
            }

            CqlBoolean ar_ = context.Operators.WhereAny<ServiceRequest>(ap_, aq_);
            return ar_;
        }

        IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

        bool? j_(Observation DEXAPerformed) {
            Code<ObservationStatus> bj_ = DEXAPerformed?.StatusElement;
            ObservationStatus? bk_ = bj_?.Value;
            string bl_ = context.Operators.Convert<string>(bk_);
            string[] bm_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean bn_ = context.Operators.In<string>(bl_, (IEnumerable<string>)bm_);
            return bn_;
        }

        IEnumerable<Observation> k_ = context.Operators.Where<Observation>(i_, j_);
        IEnumerable<object> l_ = context.Operators.Union<object>(f_ as IEnumerable<object>, k_ as IEnumerable<object>);
        CqlBoolean m_ = context.Operators.Exists<object>(l_);
        return m_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 8957501733843970185L;

    private bool? Numerator_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT(context);
        return a_;
    }


    [CqlExpressionDefinition("No Bone Density Scan Ordered Due to Patient Refusal")]
    public IEnumerable<ServiceRequest> No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal, No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal_Compute);

    private const long _cacheIndex_No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal = 6622458788790457350L;

    private IEnumerable<ServiceRequest> No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.DEXA_Bone_Density_for_Urology_Care(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> c_ = context.Operators.Union<ServiceRequest>(b_, b_);

        bool? d_(ServiceRequest DEXANotOrdered) {
            IEnumerable<ServiceRequest> f_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? g_(ServiceRequest OrderTwelveMonthsADT) {
                FhirDateTime i_ = DEXANotOrdered?.AuthoredOnElement;
                CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                FhirDateTime k_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                CqlQuantity m_ = context.Operators.Quantity(3m, "months");
                CqlDateTime n_ = context.Operators.Add(l_, m_);
                CqlInterval<CqlDateTime> o_ = context.Operators.Interval(l_, n_, true, true);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(j_, o_, "day");
                CqlBoolean q_ = (CqlBoolean)(l_ is not null);

                bool? r_(Extension @this) {
                    FhirUri z_ = @this?.UrlElement;
                    string aa_ = FHIRHelpers_4_4_000.Instance.ToString(context, z_);
                    CqlBoolean ab_ = context.Operators.Equal(aa_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return ab_;
                }


                object s_(Extension @this) {
                    DataType ac_ = @this?.Value;
                    return ac_;
                }

                IEnumerable<object> t_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(DEXANotOrdered is DomainResource
                    ? (DEXANotOrdered as DomainResource).Extension
                    : default), r_, s_);
                object u_ = context.Operators.SingletonFrom<object>(t_);
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_ as CodeableConcept);
                CqlValueSet w_ = this.Patient_Declined(context);
                CqlBoolean x_ = context.Operators.ConceptInValueSet(v_, w_);
                CqlBoolean y_ = x_;
                return p_
                    /* CQL 'and' (69:17-69:109) */ && q_
                    /* CQL 'and' (69:17-70:62) */ && y_;
            }

            CqlBoolean h_ = context.Operators.WhereAny<ServiceRequest>(f_, g_);
            return h_;
        }

        IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("No Bone Density Scan Performed Due to Patient Refusal")]
    public IEnumerable<Observation> No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal, No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal_Compute);

    private const long _cacheIndex_No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal = -3751061519719478956L;

    private IEnumerable<Observation> No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.DEXA_Bone_Density_for_Urology_Care(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
        IEnumerable<Observation> c_ = context.Operators.Union<Observation>(b_, b_);

        bool? d_(Observation DEXANotPerformed) {
            IEnumerable<ServiceRequest> f_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? g_(ServiceRequest OrderTwelveMonthsADT) {
                Instant i_ = DEXANotPerformed?.IssuedElement;
                DateTimeOffset? j_ = i_?.Value;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                FhirDateTime l_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlQuantity n_ = context.Operators.Quantity(3m, "months");
                CqlDateTime o_ = context.Operators.Add(m_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
                CqlBoolean q_ = context.Operators.In<CqlDateTime>(k_, p_, "day");
                CqlBoolean r_ = (CqlBoolean)(m_ is not null);

                bool? s_(Extension @this) {
                    FhirUri aa_ = @this?.UrlElement;
                    string ab_ = FHIRHelpers_4_4_000.Instance.ToString(context, aa_);
                    CqlBoolean ac_ = context.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return ac_;
                }


                object t_(Extension @this) {
                    DataType ad_ = @this?.Value;
                    return ad_;
                }

                IEnumerable<object> u_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(DEXANotPerformed is DomainResource
                    ? (DEXANotPerformed as DomainResource).Extension
                    : default), s_, t_);
                object v_ = context.Operators.SingletonFrom<object>(u_);
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
                CqlValueSet x_ = this.Patient_Declined(context);
                CqlBoolean y_ = context.Operators.ConceptInValueSet(w_, x_);
                CqlBoolean z_ = y_;
                return q_
                    /* CQL 'and' (75:17-75:107) */ && r_
                    /* CQL 'and' (75:17-76:64) */ && z_;
            }

            CqlBoolean h_ = context.Operators.WhereAny<ServiceRequest>(f_, g_);
            return h_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Denominator Exception")]
    public bool? Denominator_Exception(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exception, Denominator_Exception_Compute);

    private const long _cacheIndex_Denominator_Exception = -7408022328034518701L;

    private bool? Denominator_Exception_Compute(CqlContext context)
    {
        IEnumerable<ServiceRequest> a_ = this.No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal(context);
        CqlBoolean b_ = context.Operators.Exists<ServiceRequest>(a_);
        IEnumerable<Observation> c_ = this.No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal(context);
        CqlBoolean d_ = context.Operators.Exists<Observation>(c_);
        CqlBoolean e_ = d_;
        return b_
            /* CQL 'or' (35:3-36:73) */ || e_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -897900695652524114L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -7384445363689136194L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -136145099253049696L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 5984134809747202532L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
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

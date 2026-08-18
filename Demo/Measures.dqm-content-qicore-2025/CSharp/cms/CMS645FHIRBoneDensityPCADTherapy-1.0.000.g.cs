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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.4.0")]
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

            CqlBoolean i_() {
                Code<Encounter.EncounterStatus> j_ = OfficeVisit?.StatusElement;
                Encounter.EncounterStatus? k_ = j_?.Value;
                Code<Encounter.EncounterStatus> l_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(k_);
                CqlBoolean m_ = context.Operators.Equal(l_, "finished");
                return m_;
            }

            return /* CQL 'and' (136:7-137:43) */ (h_
                && i_());
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

                CqlBoolean s_() {
                    CodeableConcept t_ = M?.Code;
                    CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                    CqlValueSet v_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
                    CqlBoolean w_ = context.Operators.ConceptInValueSet(u_, v_);
                    return w_;
                }

                return /* CQL 'and' */ (r_
                    && s_());
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

            CqlBoolean ac_() {
                Code<MedicationRequest.MedicationRequestIntent> ad_ = ADTActive?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                return ah_;
            }

            return /* CQL 'and' (116:5-117:109) */ (ab_
                && ac_());
        }


        CqlDateTime h_(MedicationRequest ADTActive) {
            List<Dosage> ai_ = ADTActive?.DosageInstruction;

            bool? aj_(Dosage @this) {
                Timing by_ = @this?.Timing;
                return !((bool?)(by_ is null));
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
                return !((bool?)(cj_ is null));
            }


            Timing ar_(Dosage @this) {
                Timing ck_ = @this?.Timing;
                return ck_;
            }

            IEnumerable<Timing> as_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ai_, aq_, ar_);

            bool? at_(Timing @this) {
                Timing.RepeatComponent cl_ = @this?.Repeat;
                return !((bool?)(cl_ is null));
            }


            Timing.RepeatComponent au_(Timing @this) {
                Timing.RepeatComponent cm_ = @this?.Repeat;
                return cm_;
            }

            IEnumerable<Timing.RepeatComponent> av_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(as_, at_, au_);

            bool? aw_(Timing.RepeatComponent @this) {
                DataType cn_ = @this?.Bounds;
                object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                return !((bool?)(co_ is null));
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
                return !((bool?)(ct_ is null));
            }


            Timing bh_(Dosage @this) {
                Timing cu_ = @this?.Timing;
                return cu_;
            }

            IEnumerable<Timing> bi_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ai_, bg_, bh_);

            bool? bj_(Timing @this) {
                Timing.RepeatComponent cv_ = @this?.Repeat;
                return !((bool?)(cv_ is null));
            }


            Timing.RepeatComponent bk_(Timing @this) {
                Timing.RepeatComponent cw_ = @this?.Repeat;
                return cw_;
            }

            IEnumerable<Timing.RepeatComponent> bl_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(bi_, bj_, bk_);

            bool? bm_(Timing.RepeatComponent @this) {
                DataType cx_ = @this?.Bounds;
                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                return !((bool?)(cy_ is null));
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

                CqlBoolean s_() {
                    CodeableConcept t_ = M?.Code;
                    CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                    CqlValueSet v_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
                    CqlBoolean w_ = context.Operators.ConceptInValueSet(u_, v_);
                    return w_;
                }

                return /* CQL 'and' */ (r_
                    && s_());
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

            CqlBoolean ac_() {
                Code<MedicationRequest.MedicationRequestIntent> ad_ = ADTOrder?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ae_ = ad_?.Value;
                string af_ = context.Operators.Convert<string>(ae_);
                string[] ag_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                return ah_;
            }

            return /* CQL 'and' (130:5-131:108) */ (ab_
                && ac_());
        }


        CqlDateTime h_(MedicationRequest ADTOrder) {
            FhirDateTime ai_ = ADTOrder?.AuthoredOnElement;
            CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(ai_);
            List<Dosage> ak_ = ADTOrder?.DosageInstruction;

            bool? al_(Dosage @this) {
                Timing bt_ = @this?.Timing;
                return !((bool?)(bt_ is null));
            }


            Timing am_(Dosage @this) {
                Timing bu_ = @this?.Timing;
                return bu_;
            }

            IEnumerable<Timing> an_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ak_, al_, am_);

            bool? ao_(Timing @this) {
                Timing.RepeatComponent bv_ = @this?.Repeat;
                return !((bool?)(bv_ is null));
            }


            Timing.RepeatComponent ap_(Timing @this) {
                Timing.RepeatComponent bw_ = @this?.Repeat;
                return bw_;
            }

            IEnumerable<Timing.RepeatComponent> aq_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(an_, ao_, ap_);

            bool? ar_(Timing.RepeatComponent @this) {
                DataType bx_ = @this?.Bounds;
                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                return !((bool?)(by_ is null));
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
                return !((bool?)(cd_ is null));
            }


            Timing bc_(Dosage @this) {
                Timing ce_ = @this?.Timing;
                return ce_;
            }

            IEnumerable<Timing> bd_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ak_, bb_, bc_);

            bool? be_(Timing @this) {
                Timing.RepeatComponent cf_ = @this?.Repeat;
                return !((bool?)(cf_ is null));
            }


            Timing.RepeatComponent bf_(Timing @this) {
                Timing.RepeatComponent cg_ = @this?.Repeat;
                return cg_;
            }

            IEnumerable<Timing.RepeatComponent> bg_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(bd_, be_, bf_);

            bool? bh_(Timing.RepeatComponent @this) {
                DataType ch_ = @this?.Bounds;
                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                return !((bool?)(ci_ is null));
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

        CqlBoolean c_() {
            CodeableConcept d_ = condition?.VerificationStatus;
            CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, d_);
            CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
            CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
            CqlBoolean h_ = context.Operators.Equivalent(e_, g_);

            CqlBoolean i_() {
                CodeableConcept l_ = condition?.VerificationStatus;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                CqlCode n_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
                CqlBoolean p_ = context.Operators.Equivalent(m_, o_);
                return p_;
            }


            CqlBoolean j_() {
                CodeableConcept q_ = condition?.VerificationStatus;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlCode s_ = QICoreCommon_4_0_000.Instance.provisional(context);
                CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                CqlBoolean u_ = context.Operators.Equivalent(r_, t_);
                return u_;
            }


            CqlBoolean k_() {
                CodeableConcept v_ = condition?.VerificationStatus;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlCode x_ = QICoreCommon_4_0_000.Instance.differential(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                CqlBoolean z_ = context.Operators.Equivalent(w_, y_);
                return z_;
            }

            return /* CQL 'or' (152:52-156:3) */ (/* CQL 'or' (152:54-154:66) */ (/* CQL 'or' (152:54-153:66) */ (h_
                || i_())
                || j_())
                || k_());
        }

        return /* CQL 'implies' (152:3-156:3) */ ((CqlBoolean)(!(!((bool?)(b_ is null))))
            || c_());
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
            return /* CQL 'and' (143:5-144:39) */ (i_
                && this.isVerified(context, ProstateCancer));
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

                CqlBoolean m_() {
                    CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                    CqlDateTime o_ = context.Operators.Start(n_);
                    CqlQuantity p_ = context.Operators.Quantity(3m, "months");
                    CqlDateTime q_ = context.Operators.Subtract(o_, p_);
                    CqlQuantity r_ = context.Operators.Quantity(9m, "months");
                    CqlDateTime s_ = context.Operators.Add(o_, r_);
                    CqlInterval<CqlDateTime> t_ = context.Operators.Interval(q_, s_, true, true);
                    CqlBoolean u_ = context.Operators.In<CqlDateTime>(ADTDateTime, t_, "day");
                    return u_;
                }

                return /* CQL 'and' (82:19-83:132) */ (l_
                    && m_());
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

                CqlBoolean m_() {
                    FhirDateTime p_ = OrderTwelveMonthADT?.AuthoredOnElement;
                    CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                    CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
                    CqlDateTime s_ = context.Operators.Start(r_);
                    CqlQuantity t_ = context.Operators.Quantity(3m, "months");
                    CqlDateTime u_ = context.Operators.Subtract(s_, t_);
                    CqlQuantity v_ = context.Operators.Quantity(9m, "months");
                    CqlDateTime w_ = context.Operators.Add(s_, v_);
                    CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);
                    CqlBoolean y_ = context.Operators.In<CqlDateTime>(q_, x_, "day");
                    return y_;
                }


                CqlBoolean n_() {
                    Code<RequestStatus> z_ = OrderTwelveMonthADT?.StatusElement;
                    RequestStatus? aa_ = z_?.Value;
                    Code<RequestStatus> ab_ = context.Operators.Convert<Code<RequestStatus>>(aa_);
                    string ac_ = context.Operators.Convert<string>(ab_);
                    string[] ad_ = [
                        "active",
                        "completed",
                    ];
                    CqlBoolean ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                    return ae_;
                }


                CqlBoolean o_() {
                    Code<RequestIntent> af_ = OrderTwelveMonthADT?.IntentElement;
                    RequestIntent? ag_ = af_?.Value;
                    Code<RequestIntent> ah_ = context.Operators.Convert<Code<RequestIntent>>(ag_);
                    CqlBoolean ai_ = context.Operators.Equal(ah_, "order");
                    return ai_;
                }

                return /* CQL 'and' (90:17-93:48) */ (/* CQL 'and' (90:17-92:67) */ (/* CQL 'and' (90:17-91:149) */ (l_
                    && m_())
                    && n_())
                    && o_());
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

        CqlBoolean b_() {
            IEnumerable<ServiceRequest> c_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            CqlBoolean d_ = context.Operators.Exists<ServiceRequest>(c_);
            return d_;
        }

        return /* CQL 'and' (25:3-26:108) */ (a_
            && b_());
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

                CqlBoolean y_() {
                    FhirDateTime aa_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                    CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
                    return !((bool?)(ab_ is null));
                }


                CqlBoolean z_() {
                    FhirDateTime ac_ = DEXAOrdered?.AuthoredOnElement;
                    CqlDateTime ad_ = context.Operators.Convert<CqlDateTime>(ac_);
                    FhirDateTime ae_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                    CqlDateTime af_ = context.Operators.Convert<CqlDateTime>(ae_);
                    CqlQuantity ag_ = context.Operators.Quantity(2m, "years");
                    CqlDateTime ah_ = context.Operators.Subtract(af_, ag_);
                    CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ah_, af_, true, false);
                    CqlBoolean aj_ = context.Operators.In<CqlDateTime>(ad_, ai_, "day");

                    CqlBoolean ak_() {
                        FhirDateTime al_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                        CqlDateTime am_ = context.Operators.Convert<CqlDateTime>(al_);
                        return !((bool?)(am_ is null));
                    }

                    return /* CQL 'and' (54:16-54:99) */ (aj_
                        && ak_());
                }

                return /* CQL 'or' (53:21-54:99) */ (/* CQL 'and' (53:21-53:110) */ (x_
                    && y_())
                    || z_());
            }

            CqlBoolean p_ = context.Operators.WhereAny<ServiceRequest>(n_, o_);
            return p_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        bool? e_(ServiceRequest DEXAOrdered) {
            Code<RequestStatus> an_ = DEXAOrdered?.StatusElement;
            RequestStatus? ao_ = an_?.Value;
            Code<RequestStatus> ap_ = context.Operators.Convert<Code<RequestStatus>>(ao_);
            string aq_ = context.Operators.Convert<string>(ap_);
            string[] ar_ = [
                "active",
                "completed",
            ];
            CqlBoolean as_ = context.Operators.In<string>(aq_, (IEnumerable<string>)ar_);

            CqlBoolean at_() {
                Code<RequestIntent> au_ = DEXAOrdered?.IntentElement;
                RequestIntent? av_ = au_?.Value;
                Code<RequestIntent> aw_ = context.Operators.Convert<Code<RequestIntent>>(av_);
                CqlBoolean ax_ = context.Operators.Equal(aw_, "order");
                return ax_;
            }

            return /* CQL 'and' (55:9-56:42) */ (as_
                && at_());
        }

        IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? h_(Observation DEXAPerformed) {
            IEnumerable<ServiceRequest> ay_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? az_(ServiceRequest OrderTwelveMonthsADT) {
                DataType bb_ = DEXAPerformed?.Effective;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
                CqlDateTime be_ = context.Operators.Start(bd_);
                FhirDateTime bf_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlQuantity bh_ = context.Operators.Quantity(3m, "months");
                CqlDateTime bi_ = context.Operators.Add(bg_, bh_);
                CqlInterval<CqlDateTime> bj_ = context.Operators.Interval(bg_, bi_, true, true);
                CqlBoolean bk_ = context.Operators.In<CqlDateTime>(be_, bj_, "day");

                CqlBoolean bl_() {
                    FhirDateTime bn_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                    CqlDateTime bo_ = context.Operators.Convert<CqlDateTime>(bn_);
                    return !((bool?)(bo_ is null));
                }


                CqlBoolean bm_() {
                    DataType bp_ = DEXAPerformed?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    CqlInterval<CqlDateTime> br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_);
                    CqlDateTime bs_ = context.Operators.End(br_);
                    FhirDateTime bt_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                    CqlDateTime bu_ = context.Operators.Convert<CqlDateTime>(bt_);
                    CqlQuantity bv_ = context.Operators.Quantity(2m, "years");
                    CqlDateTime bw_ = context.Operators.Subtract(bu_, bv_);
                    CqlInterval<CqlDateTime> bx_ = context.Operators.Interval(bw_, bu_, true, false);
                    CqlBoolean by_ = context.Operators.In<CqlDateTime>(bs_, bx_, "day");

                    CqlBoolean bz_() {
                        FhirDateTime ca_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                        CqlDateTime cb_ = context.Operators.Convert<CqlDateTime>(ca_);
                        return !((bool?)(cb_ is null));
                    }

                    return /* CQL 'and' (61:18-61:117) */ (by_
                        && bz_());
                }

                return /* CQL 'or' (60:23-61:117) */ (/* CQL 'and' (60:23-60:128) */ (bk_
                    && bl_())
                    || bm_());
            }

            CqlBoolean ba_ = context.Operators.WhereAny<ServiceRequest>(ay_, az_);
            return ba_;
        }

        IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

        bool? j_(Observation DEXAPerformed) {
            Code<ObservationStatus> cc_ = DEXAPerformed?.StatusElement;
            ObservationStatus? cd_ = cc_?.Value;
            string ce_ = context.Operators.Convert<string>(cd_);
            string[] cf_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean cg_ = context.Operators.In<string>(ce_, (IEnumerable<string>)cf_);
            return cg_;
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

                CqlBoolean q_() {
                    FhirDateTime s_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                    CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(s_);
                    return !((bool?)(t_ is null));
                }


                CqlBoolean r_() {

                    bool? u_(Extension @this) {
                        FhirUri ab_ = @this?.UrlElement;
                        string ac_ = FHIRHelpers_4_4_000.Instance.ToString(context, ab_);
                        CqlBoolean ad_ = context.Operators.Equal(ac_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                        return ad_;
                    }


                    object v_(Extension @this) {
                        DataType ae_ = @this?.Value;
                        return ae_;
                    }

                    IEnumerable<object> w_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(DEXANotOrdered is DomainResource
                        ? (DEXANotOrdered as DomainResource).Extension
                        : default), u_, v_);
                    object x_ = context.Operators.SingletonFrom<object>(w_);
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_ as CodeableConcept);
                    CqlValueSet z_ = this.Patient_Declined(context);
                    CqlBoolean aa_ = context.Operators.ConceptInValueSet(y_, z_);
                    return aa_;
                }

                return /* CQL 'and' (69:17-70:62) */ (/* CQL 'and' (69:17-69:109) */ (p_
                    && q_())
                    && r_());
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

                CqlBoolean r_() {
                    FhirDateTime t_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                    CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
                    return !((bool?)(u_ is null));
                }


                CqlBoolean s_() {

                    bool? v_(Extension @this) {
                        FhirUri ac_ = @this?.UrlElement;
                        string ad_ = FHIRHelpers_4_4_000.Instance.ToString(context, ac_);
                        CqlBoolean ae_ = context.Operators.Equal(ad_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                        return ae_;
                    }


                    object w_(Extension @this) {
                        DataType af_ = @this?.Value;
                        return af_;
                    }

                    IEnumerable<object> x_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(DEXANotPerformed is DomainResource
                        ? (DEXANotPerformed as DomainResource).Extension
                        : default), v_, w_);
                    object y_ = context.Operators.SingletonFrom<object>(x_);
                    CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_ as CodeableConcept);
                    CqlValueSet aa_ = this.Patient_Declined(context);
                    CqlBoolean ab_ = context.Operators.ConceptInValueSet(z_, aa_);
                    return ab_;
                }

                return /* CQL 'and' (75:17-76:64) */ (/* CQL 'and' (75:17-75:107) */ (q_
                    && r_())
                    && s_());
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

        CqlBoolean c_() {
            IEnumerable<Observation> d_ = this.No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal(context);
            CqlBoolean e_ = context.Operators.Exists<Observation>(d_);
            return e_;
        }

        return /* CQL 'or' (35:3-36:73) */ (b_
            || c_());
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

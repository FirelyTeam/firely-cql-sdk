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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.3.0")]
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
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");
            Code<Encounter.EncounterStatus> i_ = OfficeVisit?.StatusElement;
            Encounter.EncounterStatus? j_ = i_?.Value;
            Code<Encounter.EncounterStatus> k_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(j_);
            bool? l_ = context.Operators.Equal(k_, "finished");
            bool? m_ = context.Operators.And(h_, l_);
            return m_;
        }

        bool? d_ = context.Operators.WhereAny<Encounter>(b_, c_);
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
                string n_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType o_ = MR?.Medication;
                object p_ = context.Operators.LateBoundProperty<object>(o_, "reference");
                object q_ = context.Operators.LateBoundProperty<object>(p_, "value");
                IEnumerable<string> r_ = context.Operators.Split((string)q_, "/");
                string s_ = context.Operators.Last<string>(r_);
                bool? t_ = context.Operators.Equal(n_, s_);
                CodeableConcept u_ = M?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                CqlValueSet w_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }

            bool? m_ = context.Operators.WhereAny<Medication>(k_, l_);
            return m_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ADTActive) {
            Code<MedicationRequest.MedicationrequestStatus> z_ = ADTActive?.StatusElement;
            MedicationRequest.MedicationrequestStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            string[] ac_ = [
                "active",
                "completed",
            ];
            bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
            Code<MedicationRequest.MedicationRequestIntent> ae_ = ADTActive?.IntentElement;
            MedicationRequest.MedicationRequestIntent? af_ = ae_?.Value;
            string ag_ = context.Operators.Convert<string>(af_);
            string[] ah_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
            bool? aj_ = context.Operators.And(ad_, ai_);
            return aj_;
        }


        CqlDateTime h_(MedicationRequest ADTActive) {
            List<Dosage> ak_ = ADTActive?.DosageInstruction;

            bool? al_(Dosage @this) {
                Timing ca_ = @this?.Timing;
                bool? cb_ = context.Operators.Not((bool?)(ca_ is null));
                return cb_;
            }


            Timing am_(Dosage @this) {
                Timing cc_ = @this?.Timing;
                return cc_;
            }

            IEnumerable<Timing> an_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ak_, al_, am_);

            CqlDateTime ao_(Timing dosageTiming) {
                List<FhirDateTime> cd_ = dosageTiming?.EventElement;

                string ce_(FhirDateTime @this) {
                    string ck_ = @this?.Value;
                    return ck_;
                }

                IEnumerable<string> cf_ = context.Operators.Select<FhirDateTime, string>((IEnumerable<FhirDateTime>)cd_, ce_);

                CqlDateTime cg_(string @string) {
                    CqlDateTime cl_ = context.Operators.ConvertStringToDateTime(@string);
                    return cl_;
                }

                IEnumerable<CqlDateTime> ch_ = context.Operators.Select<string, CqlDateTime>(cf_, cg_);
                IEnumerable<CqlDateTime> ci_ = context.Operators.ListSort<CqlDateTime>(ch_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime cj_ = context.Operators.First<CqlDateTime>(ci_);
                return cj_;
            }

            IEnumerable<CqlDateTime> ap_ = context.Operators.SelectDistinct<Timing, CqlDateTime>(an_, ao_);
            IEnumerable<CqlDateTime> aq_ = context.Operators.ListSort<CqlDateTime>(ap_, System.ComponentModel.ListSortDirection.Ascending);
            CqlDateTime ar_ = context.Operators.First<CqlDateTime>(aq_);

            bool? as_(Dosage @this) {
                Timing cm_ = @this?.Timing;
                bool? cn_ = context.Operators.Not((bool?)(cm_ is null));
                return cn_;
            }


            Timing at_(Dosage @this) {
                Timing co_ = @this?.Timing;
                return co_;
            }

            IEnumerable<Timing> au_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ak_, as_, at_);

            bool? av_(Timing @this) {
                Timing.RepeatComponent cp_ = @this?.Repeat;
                bool? cq_ = context.Operators.Not((bool?)(cp_ is null));
                return cq_;
            }


            Timing.RepeatComponent aw_(Timing @this) {
                Timing.RepeatComponent cr_ = @this?.Repeat;
                return cr_;
            }

            IEnumerable<Timing.RepeatComponent> ax_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(au_, av_, aw_);

            bool? ay_(Timing.RepeatComponent @this) {
                DataType cs_ = @this?.Bounds;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                bool? cu_ = context.Operators.Not((bool?)(ct_ is null));
                return cu_;
            }


            object az_(Timing.RepeatComponent @this) {
                DataType cv_ = @this?.Bounds;
                object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                return cw_;
            }

            IEnumerable<object> ba_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(ax_, ay_, az_);

            CqlInterval<CqlDateTime> bb_(object DoseTime) {
                CqlInterval<CqlDateTime> cx_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return cx_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bc_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(ba_, bb_);
            IEnumerable<CqlInterval<CqlDateTime>> bd_ = context.Operators.Collapse(bc_, (string)default);

            object be_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime cy_ = context.Operators.Start(@this);
                return cy_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bf_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bd_, be_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bg_ = context.Operators.First<CqlInterval<CqlDateTime>>(bf_);
            CqlDateTime bh_ = context.Operators.Start(bg_);

            bool? bi_(Dosage @this) {
                Timing cz_ = @this?.Timing;
                bool? da_ = context.Operators.Not((bool?)(cz_ is null));
                return da_;
            }


            Timing bj_(Dosage @this) {
                Timing db_ = @this?.Timing;
                return db_;
            }

            IEnumerable<Timing> bk_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ak_, bi_, bj_);

            bool? bl_(Timing @this) {
                Timing.RepeatComponent dc_ = @this?.Repeat;
                bool? dd_ = context.Operators.Not((bool?)(dc_ is null));
                return dd_;
            }


            Timing.RepeatComponent bm_(Timing @this) {
                Timing.RepeatComponent de_ = @this?.Repeat;
                return de_;
            }

            IEnumerable<Timing.RepeatComponent> bn_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(bk_, bl_, bm_);

            bool? bo_(Timing.RepeatComponent @this) {
                DataType df_ = @this?.Bounds;
                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                bool? dh_ = context.Operators.Not((bool?)(dg_ is null));
                return dh_;
            }


            object bp_(Timing.RepeatComponent @this) {
                DataType di_ = @this?.Bounds;
                object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                return dj_;
            }

            IEnumerable<object> bq_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(bn_, bo_, bp_);

            CqlInterval<CqlDateTime> br_(object DoseTime) {
                CqlInterval<CqlDateTime> dk_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return dk_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bs_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(bq_, br_);
            IEnumerable<CqlInterval<CqlDateTime>> bt_ = context.Operators.Collapse(bs_, (string)default);

            object bu_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime dl_ = context.Operators.Start(@this);
                return dl_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bv_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bt_, bu_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bw_ = context.Operators.First<CqlInterval<CqlDateTime>>(bv_);
            CqlDateTime bx_ = context.Operators.End(bw_);
            CqlDateTime[] by_ = [
                ar_,
                bh_,
                bx_,
            ];
            CqlDateTime bz_ = context.Operators.Min<CqlDateTime>((IEnumerable<CqlDateTime>)by_);
            return bz_;
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
                string n_ = (M is Resource
                    ? (M as Resource).IdElement
                    : default)?.Value;
                DataType o_ = MR?.Medication;
                object p_ = context.Operators.LateBoundProperty<object>(o_, "reference");
                object q_ = context.Operators.LateBoundProperty<object>(p_, "value");
                IEnumerable<string> r_ = context.Operators.Split((string)q_, "/");
                string s_ = context.Operators.Last<string>(r_);
                bool? t_ = context.Operators.Equal(n_, s_);
                CodeableConcept u_ = M?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                CqlValueSet w_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }

            bool? m_ = context.Operators.WhereAny<Medication>(k_, l_);
            return m_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ADTOrder) {
            Code<MedicationRequest.MedicationrequestStatus> z_ = ADTOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            string[] ac_ = [
                "active",
                "completed",
            ];
            bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
            Code<MedicationRequest.MedicationRequestIntent> ae_ = ADTOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? af_ = ae_?.Value;
            string ag_ = context.Operators.Convert<string>(af_);
            string[] ah_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
            bool? aj_ = context.Operators.And(ad_, ai_);
            return aj_;
        }


        CqlDateTime h_(MedicationRequest ADTOrder) {
            FhirDateTime ak_ = ADTOrder?.AuthoredOnElement;
            CqlDateTime al_ = context.Operators.Convert<CqlDateTime>(ak_);
            List<Dosage> am_ = ADTOrder?.DosageInstruction;

            bool? an_(Dosage @this) {
                Timing bv_ = @this?.Timing;
                bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
                return bw_;
            }


            Timing ao_(Dosage @this) {
                Timing bx_ = @this?.Timing;
                return bx_;
            }

            IEnumerable<Timing> ap_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)am_, an_, ao_);

            bool? aq_(Timing @this) {
                Timing.RepeatComponent by_ = @this?.Repeat;
                bool? bz_ = context.Operators.Not((bool?)(by_ is null));
                return bz_;
            }


            Timing.RepeatComponent ar_(Timing @this) {
                Timing.RepeatComponent ca_ = @this?.Repeat;
                return ca_;
            }

            IEnumerable<Timing.RepeatComponent> as_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(ap_, aq_, ar_);

            bool? at_(Timing.RepeatComponent @this) {
                DataType cb_ = @this?.Bounds;
                object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                bool? cd_ = context.Operators.Not((bool?)(cc_ is null));
                return cd_;
            }


            object au_(Timing.RepeatComponent @this) {
                DataType ce_ = @this?.Bounds;
                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                return cf_;
            }

            IEnumerable<object> av_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(as_, at_, au_);

            CqlInterval<CqlDateTime> aw_(object DoseTime) {
                CqlInterval<CqlDateTime> cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return cg_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> ax_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(av_, aw_);
            IEnumerable<CqlInterval<CqlDateTime>> ay_ = context.Operators.Collapse(ax_, (string)default);

            object az_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime ch_ = context.Operators.Start(@this);
                return ch_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> ba_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(ay_, az_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bb_ = context.Operators.First<CqlInterval<CqlDateTime>>(ba_);
            CqlDateTime bc_ = context.Operators.Start(bb_);

            bool? bd_(Dosage @this) {
                Timing ci_ = @this?.Timing;
                bool? cj_ = context.Operators.Not((bool?)(ci_ is null));
                return cj_;
            }


            Timing be_(Dosage @this) {
                Timing ck_ = @this?.Timing;
                return ck_;
            }

            IEnumerable<Timing> bf_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)am_, bd_, be_);

            bool? bg_(Timing @this) {
                Timing.RepeatComponent cl_ = @this?.Repeat;
                bool? cm_ = context.Operators.Not((bool?)(cl_ is null));
                return cm_;
            }


            Timing.RepeatComponent bh_(Timing @this) {
                Timing.RepeatComponent cn_ = @this?.Repeat;
                return cn_;
            }

            IEnumerable<Timing.RepeatComponent> bi_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(bf_, bg_, bh_);

            bool? bj_(Timing.RepeatComponent @this) {
                DataType co_ = @this?.Bounds;
                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                bool? cq_ = context.Operators.Not((bool?)(cp_ is null));
                return cq_;
            }


            object bk_(Timing.RepeatComponent @this) {
                DataType cr_ = @this?.Bounds;
                object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                return cs_;
            }

            IEnumerable<object> bl_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(bi_, bj_, bk_);

            CqlInterval<CqlDateTime> bm_(object DoseTime) {
                CqlInterval<CqlDateTime> ct_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return ct_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bn_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(bl_, bm_);
            IEnumerable<CqlInterval<CqlDateTime>> bo_ = context.Operators.Collapse(bn_, (string)default);

            object bp_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime cu_ = context.Operators.Start(@this);
                return cu_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bq_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bo_, bp_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> br_ = context.Operators.First<CqlInterval<CqlDateTime>>(bq_);
            CqlDateTime bs_ = context.Operators.End(br_);
            CqlDateTime[] bt_ = [
                al_,
                bc_,
                bs_,
            ];
            CqlDateTime bu_ = context.Operators.Min<CqlDateTime>((IEnumerable<CqlDateTime>)bt_);
            return bu_;
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
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlCode d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(b_, e_);
        CqlCode g_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
        bool? i_ = context.Operators.Equivalent(b_, h_);
        bool? j_ = context.Operators.Or(f_, i_);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(b_, l_);
        bool? n_ = context.Operators.Or(j_, m_);
        CqlCode o_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
        bool? q_ = context.Operators.Equivalent(b_, p_);
        bool? r_ = context.Operators.Or(n_, q_);
        bool? s_ = context.Operators.Implies(c_, r_);
        return s_;
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
            bool? i_ = context.Operators.Overlaps(g_, h_, "day");
            bool? j_ = this.isVerified(context, ProstateCancer);
            bool? k_ = context.Operators.And(i_, j_);
            return k_;
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
                bool? l_ = context.Operators.In<CqlDateTime>(ADTDateTime, k_, "day");
                CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(3m, "months");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                CqlQuantity q_ = context.Operators.Quantity(9m, "months");
                CqlDateTime r_ = context.Operators.Add(n_, q_);
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(p_, r_, true, true);
                bool? t_ = context.Operators.In<CqlDateTime>(ADTDateTime, s_, "day");
                bool? u_ = context.Operators.And(l_, t_);
                return u_;
            }

            bool? j_ = context.Operators.WhereAny<Condition>(h_, i_);
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
                bool? l_ = context.Operators.SameOrAfter(k_, FirstADTMP, "day");
                CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(3m, "months");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                CqlQuantity q_ = context.Operators.Quantity(9m, "months");
                CqlDateTime r_ = context.Operators.Add(n_, q_);
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(p_, r_, true, true);
                bool? t_ = context.Operators.In<CqlDateTime>(k_, s_, "day");
                bool? u_ = context.Operators.And(l_, t_);
                Code<RequestStatus> v_ = OrderTwelveMonthADT?.StatusElement;
                RequestStatus? w_ = v_?.Value;
                Code<RequestStatus> x_ = context.Operators.Convert<Code<RequestStatus>>(w_);
                string y_ = context.Operators.Convert<string>(x_);
                string[] z_ = [
                    "active",
                    "completed",
                ];
                bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
                bool? ab_ = context.Operators.And(u_, aa_);
                Code<RequestIntent> ac_ = OrderTwelveMonthADT?.IntentElement;
                RequestIntent? ad_ = ac_?.Value;
                Code<RequestIntent> ae_ = context.Operators.Convert<Code<RequestIntent>>(ad_);
                bool? af_ = context.Operators.Equal(ae_, "order");
                bool? ag_ = context.Operators.And(ab_, af_);
                return ag_;
            }

            bool? i_ = context.Operators.WhereAny<CqlDateTime>((IEnumerable<CqlDateTime>)g_, h_);
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
        bool? a_ = this.Has_Qualifying_Encounter(context);
        IEnumerable<ServiceRequest> b_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
        bool? c_ = context.Operators.Exists<ServiceRequest>(b_);
        bool? d_ = context.Operators.And(a_, c_);
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
                bool? x_ = context.Operators.In<CqlDateTime>(r_, w_, "day");
                bool? y_ = context.Operators.Not((bool?)(t_ is null));
                bool? z_ = context.Operators.And(x_, y_);
                CqlQuantity aa_ = context.Operators.Quantity(2m, "years");
                CqlDateTime ab_ = context.Operators.Subtract(t_, aa_);
                CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(ab_, t_, true, false);
                bool? ad_ = context.Operators.In<CqlDateTime>(r_, ac_, "day");
                bool? ae_ = context.Operators.And(ad_, y_);
                bool? af_ = context.Operators.Or(z_, ae_);
                return af_;
            }

            bool? p_ = context.Operators.WhereAny<ServiceRequest>(n_, o_);
            return p_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        bool? e_(ServiceRequest DEXAOrdered) {
            Code<RequestStatus> ag_ = DEXAOrdered?.StatusElement;
            RequestStatus? ah_ = ag_?.Value;
            Code<RequestStatus> ai_ = context.Operators.Convert<Code<RequestStatus>>(ah_);
            string aj_ = context.Operators.Convert<string>(ai_);
            string[] ak_ = [
                "active",
                "completed",
            ];
            bool? al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
            Code<RequestIntent> am_ = DEXAOrdered?.IntentElement;
            RequestIntent? an_ = am_?.Value;
            Code<RequestIntent> ao_ = context.Operators.Convert<Code<RequestIntent>>(an_);
            bool? ap_ = context.Operators.Equal(ao_, "order");
            bool? aq_ = context.Operators.And(al_, ap_);
            return aq_;
        }

        IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? h_(Observation DEXAPerformed) {
            IEnumerable<ServiceRequest> ar_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? as_(ServiceRequest OrderTwelveMonthsADT) {
                DataType au_ = DEXAPerformed?.Effective;
                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                CqlInterval<CqlDateTime> aw_ = QICoreCommon_4_0_000.Instance.toInterval(context, av_);
                CqlDateTime ax_ = context.Operators.Start(aw_);
                FhirDateTime ay_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime az_ = context.Operators.Convert<CqlDateTime>(ay_);
                CqlQuantity ba_ = context.Operators.Quantity(3m, "months");
                CqlDateTime bb_ = context.Operators.Add(az_, ba_);
                CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(az_, bb_, true, true);
                bool? bd_ = context.Operators.In<CqlDateTime>(ax_, bc_, "day");
                bool? be_ = context.Operators.Not((bool?)(az_ is null));
                bool? bf_ = context.Operators.And(bd_, be_);
                CqlDateTime bg_ = context.Operators.End(aw_);
                CqlQuantity bh_ = context.Operators.Quantity(2m, "years");
                CqlDateTime bi_ = context.Operators.Subtract(az_, bh_);
                CqlInterval<CqlDateTime> bj_ = context.Operators.Interval(bi_, az_, true, false);
                bool? bk_ = context.Operators.In<CqlDateTime>(bg_, bj_, "day");
                bool? bl_ = context.Operators.And(bk_, be_);
                bool? bm_ = context.Operators.Or(bf_, bl_);
                return bm_;
            }

            bool? at_ = context.Operators.WhereAny<ServiceRequest>(ar_, as_);
            return at_;
        }

        IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

        bool? j_(Observation DEXAPerformed) {
            Code<ObservationStatus> bn_ = DEXAPerformed?.StatusElement;
            ObservationStatus? bo_ = bn_?.Value;
            string bp_ = context.Operators.Convert<string>(bo_);
            string[] bq_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? br_ = context.Operators.In<string>(bp_, (IEnumerable<string>)bq_);
            return br_;
        }

        IEnumerable<Observation> k_ = context.Operators.Where<Observation>(i_, j_);
        IEnumerable<object> l_ = context.Operators.Union<object>(f_ as IEnumerable<object>, k_ as IEnumerable<object>);
        bool? m_ = context.Operators.Exists<object>(l_);
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
                bool? p_ = context.Operators.In<CqlDateTime>(j_, o_, "day");
                bool? q_ = context.Operators.Not((bool?)(l_ is null));
                bool? r_ = context.Operators.And(p_, q_);

                bool? s_(Extension @this) {
                    FhirUri aa_ = @this?.UrlElement;
                    string ab_ = FHIRHelpers_4_4_000.Instance.ToString(context, aa_);
                    bool? ac_ = context.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                    return ac_;
                }


                object t_(Extension @this) {
                    DataType ad_ = @this?.Value;
                    return ad_;
                }

                IEnumerable<object> u_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(DEXANotOrdered is DomainResource
                    ? (DEXANotOrdered as DomainResource).Extension
                    : default), s_, t_);
                object v_ = context.Operators.SingletonFrom<object>(u_);
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
                CqlValueSet x_ = this.Patient_Declined(context);
                bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                bool? z_ = context.Operators.And(r_, y_);
                return z_;
            }

            bool? h_ = context.Operators.WhereAny<ServiceRequest>(f_, g_);
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
                bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, "day");
                bool? r_ = context.Operators.Not((bool?)(m_ is null));
                bool? s_ = context.Operators.And(q_, r_);

                bool? t_(Extension @this) {
                    FhirUri ab_ = @this?.UrlElement;
                    string ac_ = FHIRHelpers_4_4_000.Instance.ToString(context, ab_);
                    bool? ad_ = context.Operators.Equal(ac_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                    return ad_;
                }


                object u_(Extension @this) {
                    DataType ae_ = @this?.Value;
                    return ae_;
                }

                IEnumerable<object> v_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(DEXANotPerformed is DomainResource
                    ? (DEXANotPerformed as DomainResource).Extension
                    : default), t_, u_);
                object w_ = context.Operators.SingletonFrom<object>(v_);
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_ as CodeableConcept);
                CqlValueSet y_ = this.Patient_Declined(context);
                bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                bool? aa_ = context.Operators.And(s_, z_);
                return aa_;
            }

            bool? h_ = context.Operators.WhereAny<ServiceRequest>(f_, g_);
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
        bool? b_ = context.Operators.Exists<ServiceRequest>(a_);
        IEnumerable<Observation> c_ = this.No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal(context);
        bool? d_ = context.Operators.Exists<Observation>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        return e_;
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

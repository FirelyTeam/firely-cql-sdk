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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.2.0")]
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
            // CQL 'and' (136:7-137:43): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                Code<Encounter.EncounterStatus> i_ = OfficeVisit?.StatusElement;
                Encounter.EncounterStatus? j_ = i_?.Value;
                Code<Encounter.EncounterStatus> k_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(j_);
                bool? l_ = context.Operators.Equal(k_, "finished");
                return h_ & l_;
            }
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
                object n_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> p_ = context.Operators.Split((string)o_, "/");
                string q_ = context.Operators.Last<string>(p_);
                bool? r_ = context.Operators.Equal(n_, q_);
                // CQL 'and': right operand skipped when left is false
                if (r_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept s_ = M?.Code;
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                    CqlValueSet u_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
                    bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                    return r_ & v_;
                }
            }

            bool? m_ = context.Operators.WhereAny<Medication>(k_, l_);
            return m_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ADTActive) {
            Code<MedicationRequest.MedicationrequestStatus> w_ = ADTActive?.StatusElement;
            MedicationRequest.MedicationrequestStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            string[] z_ = [
                "active",
                "completed",
            ];
            bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
            // CQL 'and' (116:5-117:109): right operand skipped when left is false
            if (aa_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> ab_ = ADTActive?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                return aa_ & af_;
            }
        }


        CqlDateTime h_(MedicationRequest ADTActive) {
            List<Dosage> ag_ = ADTActive?.DosageInstruction;

            bool? ah_(Dosage @this) {
                Timing bw_ = @this?.Timing;
                return !((bool?)(bw_ is null));
            }


            Timing ai_(Dosage @this) {
                Timing bx_ = @this?.Timing;
                return bx_;
            }

            IEnumerable<Timing> aj_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ag_, ah_, ai_);

            CqlDateTime ak_(Timing dosageTiming) {
                List<FhirDateTime> by_ = dosageTiming?.EventElement;

                string bz_(FhirDateTime @this) {
                    string cf_ = @this?.Value;
                    return cf_;
                }

                IEnumerable<string> ca_ = context.Operators.Select<FhirDateTime, string>((IEnumerable<FhirDateTime>)by_, bz_);

                CqlDateTime cb_(string @string) {
                    CqlDateTime cg_ = context.Operators.ConvertStringToDateTime(@string);
                    return cg_;
                }

                IEnumerable<CqlDateTime> cc_ = context.Operators.Select<string, CqlDateTime>(ca_, cb_);
                IEnumerable<CqlDateTime> cd_ = context.Operators.ListSort<CqlDateTime>(cc_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime ce_ = context.Operators.First<CqlDateTime>(cd_);
                return ce_;
            }

            IEnumerable<CqlDateTime> al_ = context.Operators.SelectDistinct<Timing, CqlDateTime>(aj_, ak_);
            IEnumerable<CqlDateTime> am_ = context.Operators.ListSort<CqlDateTime>(al_, System.ComponentModel.ListSortDirection.Ascending);
            CqlDateTime an_ = context.Operators.First<CqlDateTime>(am_);

            bool? ao_(Dosage @this) {
                Timing ch_ = @this?.Timing;
                return !((bool?)(ch_ is null));
            }


            Timing ap_(Dosage @this) {
                Timing ci_ = @this?.Timing;
                return ci_;
            }

            IEnumerable<Timing> aq_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ag_, ao_, ap_);

            bool? ar_(Timing @this) {
                Timing.RepeatComponent cj_ = @this?.Repeat;
                return !((bool?)(cj_ is null));
            }


            Timing.RepeatComponent as_(Timing @this) {
                Timing.RepeatComponent ck_ = @this?.Repeat;
                return ck_;
            }

            IEnumerable<Timing.RepeatComponent> at_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(aq_, ar_, as_);

            bool? au_(Timing.RepeatComponent @this) {
                DataType cl_ = @this?.Bounds;
                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                return !((bool?)(cm_ is null));
            }


            object av_(Timing.RepeatComponent @this) {
                DataType cn_ = @this?.Bounds;
                object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                return co_;
            }

            IEnumerable<object> aw_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(at_, au_, av_);

            CqlInterval<CqlDateTime> ax_(object DoseTime) {
                CqlInterval<CqlDateTime> cp_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return cp_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> ay_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(aw_, ax_);
            IEnumerable<CqlInterval<CqlDateTime>> az_ = context.Operators.Collapse(ay_, (string)default);

            object ba_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime cq_ = context.Operators.Start(@this);
                return cq_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bb_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(az_, ba_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bc_ = context.Operators.First<CqlInterval<CqlDateTime>>(bb_);
            CqlDateTime bd_ = context.Operators.Start(bc_);

            bool? be_(Dosage @this) {
                Timing cr_ = @this?.Timing;
                return !((bool?)(cr_ is null));
            }


            Timing bf_(Dosage @this) {
                Timing cs_ = @this?.Timing;
                return cs_;
            }

            IEnumerable<Timing> bg_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ag_, be_, bf_);

            bool? bh_(Timing @this) {
                Timing.RepeatComponent ct_ = @this?.Repeat;
                return !((bool?)(ct_ is null));
            }


            Timing.RepeatComponent bi_(Timing @this) {
                Timing.RepeatComponent cu_ = @this?.Repeat;
                return cu_;
            }

            IEnumerable<Timing.RepeatComponent> bj_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(bg_, bh_, bi_);

            bool? bk_(Timing.RepeatComponent @this) {
                DataType cv_ = @this?.Bounds;
                object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                return !((bool?)(cw_ is null));
            }


            object bl_(Timing.RepeatComponent @this) {
                DataType cx_ = @this?.Bounds;
                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                return cy_;
            }

            IEnumerable<object> bm_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(bj_, bk_, bl_);

            CqlInterval<CqlDateTime> bn_(object DoseTime) {
                CqlInterval<CqlDateTime> cz_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return cz_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bo_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(bm_, bn_);
            IEnumerable<CqlInterval<CqlDateTime>> bp_ = context.Operators.Collapse(bo_, (string)default);

            object bq_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime da_ = context.Operators.Start(@this);
                return da_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> br_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bs_ = context.Operators.First<CqlInterval<CqlDateTime>>(br_);
            CqlDateTime bt_ = context.Operators.End(bs_);
            CqlDateTime[] bu_ = [
                an_,
                bd_,
                bt_,
            ];
            CqlDateTime bv_ = context.Operators.Min<CqlDateTime>((IEnumerable<CqlDateTime>)bu_);
            return bv_;
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
                bool? r_ = context.Operators.Equal(n_, q_);
                // CQL 'and': right operand skipped when left is false
                if (r_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept s_ = M?.Code;
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                    CqlValueSet u_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
                    bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                    return r_ & v_;
                }
            }

            bool? m_ = context.Operators.WhereAny<Medication>(k_, l_);
            return m_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Androgen_Deprivation_Therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest ADTOrder) {
            Code<MedicationRequest.MedicationrequestStatus> w_ = ADTOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            string[] z_ = [
                "active",
                "completed",
            ];
            bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
            // CQL 'and' (130:5-131:108): right operand skipped when left is false
            if (aa_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> ab_ = ADTOrder?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                return aa_ & af_;
            }
        }


        CqlDateTime h_(MedicationRequest ADTOrder) {
            FhirDateTime ag_ = ADTOrder?.AuthoredOnElement;
            CqlDateTime ah_ = context.Operators.Convert<CqlDateTime>(ag_);
            List<Dosage> ai_ = ADTOrder?.DosageInstruction;

            bool? aj_(Dosage @this) {
                Timing br_ = @this?.Timing;
                return !((bool?)(br_ is null));
            }


            Timing ak_(Dosage @this) {
                Timing bs_ = @this?.Timing;
                return bs_;
            }

            IEnumerable<Timing> al_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ai_, aj_, ak_);

            bool? am_(Timing @this) {
                Timing.RepeatComponent bt_ = @this?.Repeat;
                return !((bool?)(bt_ is null));
            }


            Timing.RepeatComponent an_(Timing @this) {
                Timing.RepeatComponent bu_ = @this?.Repeat;
                return bu_;
            }

            IEnumerable<Timing.RepeatComponent> ao_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(al_, am_, an_);

            bool? ap_(Timing.RepeatComponent @this) {
                DataType bv_ = @this?.Bounds;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                return !((bool?)(bw_ is null));
            }


            object aq_(Timing.RepeatComponent @this) {
                DataType bx_ = @this?.Bounds;
                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                return by_;
            }

            IEnumerable<object> ar_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(ao_, ap_, aq_);

            CqlInterval<CqlDateTime> as_(object DoseTime) {
                CqlInterval<CqlDateTime> bz_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return bz_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> at_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(ar_, as_);
            IEnumerable<CqlInterval<CqlDateTime>> au_ = context.Operators.Collapse(at_, (string)default);

            object av_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime ca_ = context.Operators.Start(@this);
                return ca_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> aw_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(au_, av_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> ax_ = context.Operators.First<CqlInterval<CqlDateTime>>(aw_);
            CqlDateTime ay_ = context.Operators.Start(ax_);

            bool? az_(Dosage @this) {
                Timing cb_ = @this?.Timing;
                return !((bool?)(cb_ is null));
            }


            Timing ba_(Dosage @this) {
                Timing cc_ = @this?.Timing;
                return cc_;
            }

            IEnumerable<Timing> bb_ = context.Operators.WhereSelect<Dosage, Timing>((IEnumerable<Dosage>)ai_, az_, ba_);

            bool? bc_(Timing @this) {
                Timing.RepeatComponent cd_ = @this?.Repeat;
                return !((bool?)(cd_ is null));
            }


            Timing.RepeatComponent bd_(Timing @this) {
                Timing.RepeatComponent ce_ = @this?.Repeat;
                return ce_;
            }

            IEnumerable<Timing.RepeatComponent> be_ = context.Operators.WhereSelect<Timing, Timing.RepeatComponent>(bb_, bc_, bd_);

            bool? bf_(Timing.RepeatComponent @this) {
                DataType cf_ = @this?.Bounds;
                object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                return !((bool?)(cg_ is null));
            }


            object bg_(Timing.RepeatComponent @this) {
                DataType ch_ = @this?.Bounds;
                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                return ci_;
            }

            IEnumerable<object> bh_ = context.Operators.WhereSelect<Timing.RepeatComponent, object>(be_, bf_, bg_);

            CqlInterval<CqlDateTime> bi_(object DoseTime) {
                CqlInterval<CqlDateTime> cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, DoseTime);
                return cj_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bj_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(bh_, bi_);
            IEnumerable<CqlInterval<CqlDateTime>> bk_ = context.Operators.Collapse(bj_, (string)default);

            object bl_(CqlInterval<CqlDateTime> @this) {
                CqlDateTime ck_ = context.Operators.Start(@this);
                return ck_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> bm_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(bk_, bl_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> bn_ = context.Operators.First<CqlInterval<CqlDateTime>>(bm_);
            CqlDateTime bo_ = context.Operators.End(bn_);
            CqlDateTime[] bp_ = [
                ah_,
                ay_,
                bo_,
            ];
            CqlDateTime bq_ = context.Operators.Min<CqlDateTime>((IEnumerable<CqlDateTime>)bp_);
            return bq_;
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
        bool? e_ = context.Operators.Equivalent(b_, d_);
        bool? f_;
        // CQL 'or' (152:54-153:66): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CodeableConcept j_ = condition?.VerificationStatus;
            CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
            CqlCode l_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
            CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
            bool? n_ = context.Operators.Equivalent(k_, m_);
            f_ = e_ | n_;
        }
        bool? g_;
        // CQL 'or' (152:54-154:66): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CodeableConcept o_ = condition?.VerificationStatus;
            CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
            CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
            CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
            bool? s_ = context.Operators.Equivalent(p_, r_);
            g_ = f_ | s_;
        }
        bool? h_;
        // CQL 'or' (152:52-156:3): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            CodeableConcept t_ = condition?.VerificationStatus;
            CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
            CqlCode v_ = QICoreCommon_4_0_000.Instance.differential(context);
            CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
            bool? x_ = context.Operators.Equivalent(u_, w_);
            h_ = g_ | x_;
        }
        bool? i_ = context.Operators.Implies(!((bool?)(b_ is null)), h_);
        return i_;
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
            // CQL 'and' (143:5-144:39): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                bool? j_ = this.isVerified(context, ProstateCancer);
                return i_ & j_;
            }
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
                // CQL 'and' (82:19-83:132): right operand skipped when left is false
                if (l_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                    CqlDateTime n_ = context.Operators.Start(m_);
                    CqlQuantity o_ = context.Operators.Quantity(3m, "months");
                    CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                    CqlQuantity q_ = context.Operators.Quantity(9m, "months");
                    CqlDateTime r_ = context.Operators.Add(n_, q_);
                    CqlInterval<CqlDateTime> s_ = context.Operators.Interval(p_, r_, true, true);
                    bool? t_ = context.Operators.In<CqlDateTime>(ADTDateTime, s_, "day");
                    return l_ & t_;
                }
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
                bool? m_;
                // CQL 'and' (90:17-91:149): right operand skipped when left is false
                if (l_ is false)
                {
                    m_ = false;
                }
                else
                {
                    FhirDateTime o_ = OrderTwelveMonthADT?.AuthoredOnElement;
                    CqlDateTime p_ = context.Operators.Convert<CqlDateTime>(o_);
                    CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                    CqlDateTime r_ = context.Operators.Start(q_);
                    CqlQuantity s_ = context.Operators.Quantity(3m, "months");
                    CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                    CqlQuantity u_ = context.Operators.Quantity(9m, "months");
                    CqlDateTime v_ = context.Operators.Add(r_, u_);
                    CqlInterval<CqlDateTime> w_ = context.Operators.Interval(t_, v_, true, true);
                    bool? x_ = context.Operators.In<CqlDateTime>(p_, w_, "day");
                    m_ = l_ & x_;
                }
                bool? n_;
                // CQL 'and' (90:17-92:67): right operand skipped when left is false
                if (m_ is false)
                {
                    n_ = false;
                }
                else
                {
                    Code<RequestStatus> y_ = OrderTwelveMonthADT?.StatusElement;
                    RequestStatus? z_ = y_?.Value;
                    Code<RequestStatus> aa_ = context.Operators.Convert<Code<RequestStatus>>(z_);
                    string ab_ = context.Operators.Convert<string>(aa_);
                    string[] ac_ = [
                        "active",
                        "completed",
                    ];
                    bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
                    n_ = m_ & ad_;
                }
                // CQL 'and' (90:17-93:48): right operand skipped when left is false
                if (n_ is false)
                {
                    return false;
                }
                else
                {
                    Code<RequestIntent> ae_ = OrderTwelveMonthADT?.IntentElement;
                    RequestIntent? af_ = ae_?.Value;
                    Code<RequestIntent> ag_ = context.Operators.Convert<Code<RequestIntent>>(af_);
                    bool? ah_ = context.Operators.Equal(ag_, "order");
                    return n_ & ah_;
                }
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
        // CQL 'and' (25:3-26:108): right operand skipped when left is false
        if (a_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<ServiceRequest> b_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? c_ = context.Operators.Exists<ServiceRequest>(b_);
            return a_ & c_;
        }
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
                bool? y_;
                // CQL 'and' (53:21-53:110): right operand skipped when left is false
                if (x_ is false)
                {
                    y_ = false;
                }
                else
                {
                    FhirDateTime z_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                    CqlDateTime aa_ = context.Operators.Convert<CqlDateTime>(z_);
                    y_ = x_ & (!((bool?)(aa_ is null)));
                }
                // CQL 'or' (53:21-54:99): right operand skipped when left is true
                if (y_ is true)
                {
                    return true;
                }
                else
                {
                    FhirDateTime ab_ = DEXAOrdered?.AuthoredOnElement;
                    CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(ab_);
                    FhirDateTime ad_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                    CqlDateTime ae_ = context.Operators.Convert<CqlDateTime>(ad_);
                    CqlQuantity af_ = context.Operators.Quantity(2m, "years");
                    CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                    CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ag_, ae_, true, false);
                    bool? ai_ = context.Operators.In<CqlDateTime>(ac_, ah_, "day");
                    bool? aj_;
                    // CQL 'and' (54:16-54:99): right operand skipped when left is false
                    if (ai_ is false)
                    {
                        aj_ = false;
                    }
                    else
                    {
                        FhirDateTime ak_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                        CqlDateTime al_ = context.Operators.Convert<CqlDateTime>(ak_);
                        aj_ = ai_ & (!((bool?)(al_ is null)));
                    }
                    return y_ | aj_;
                }
            }

            bool? p_ = context.Operators.WhereAny<ServiceRequest>(n_, o_);
            return p_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        bool? e_(ServiceRequest DEXAOrdered) {
            Code<RequestStatus> am_ = DEXAOrdered?.StatusElement;
            RequestStatus? an_ = am_?.Value;
            Code<RequestStatus> ao_ = context.Operators.Convert<Code<RequestStatus>>(an_);
            string ap_ = context.Operators.Convert<string>(ao_);
            string[] aq_ = [
                "active",
                "completed",
            ];
            bool? ar_ = context.Operators.In<string>(ap_, (IEnumerable<string>)aq_);
            // CQL 'and' (55:9-56:42): right operand skipped when left is false
            if (ar_ is false)
            {
                return false;
            }
            else
            {
                Code<RequestIntent> as_ = DEXAOrdered?.IntentElement;
                RequestIntent? at_ = as_?.Value;
                Code<RequestIntent> au_ = context.Operators.Convert<Code<RequestIntent>>(at_);
                bool? av_ = context.Operators.Equal(au_, "order");
                return ar_ & av_;
            }
        }

        IEnumerable<ServiceRequest> f_ = context.Operators.Where<ServiceRequest>(d_, e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? h_(Observation DEXAPerformed) {
            IEnumerable<ServiceRequest> aw_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);

            bool? ax_(ServiceRequest OrderTwelveMonthsADT) {
                DataType az_ = DEXAPerformed?.Effective;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                CqlInterval<CqlDateTime> bb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                FhirDateTime bd_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime be_ = context.Operators.Convert<CqlDateTime>(bd_);
                CqlQuantity bf_ = context.Operators.Quantity(3m, "months");
                CqlDateTime bg_ = context.Operators.Add(be_, bf_);
                CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(be_, bg_, true, true);
                bool? bi_ = context.Operators.In<CqlDateTime>(bc_, bh_, "day");
                bool? bj_;
                // CQL 'and' (60:23-60:128): right operand skipped when left is false
                if (bi_ is false)
                {
                    bj_ = false;
                }
                else
                {
                    FhirDateTime bk_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                    CqlDateTime bl_ = context.Operators.Convert<CqlDateTime>(bk_);
                    bj_ = bi_ & (!((bool?)(bl_ is null)));
                }
                // CQL 'or' (60:23-61:117): right operand skipped when left is true
                if (bj_ is true)
                {
                    return true;
                }
                else
                {
                    DataType bm_ = DEXAPerformed?.Effective;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    CqlInterval<CqlDateTime> bo_ = QICoreCommon_4_0_000.Instance.toInterval(context, bn_);
                    CqlDateTime bp_ = context.Operators.End(bo_);
                    FhirDateTime bq_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                    CqlDateTime br_ = context.Operators.Convert<CqlDateTime>(bq_);
                    CqlQuantity bs_ = context.Operators.Quantity(2m, "years");
                    CqlDateTime bt_ = context.Operators.Subtract(br_, bs_);
                    CqlInterval<CqlDateTime> bu_ = context.Operators.Interval(bt_, br_, true, false);
                    bool? bv_ = context.Operators.In<CqlDateTime>(bp_, bu_, "day");
                    bool? bw_;
                    // CQL 'and' (61:18-61:117): right operand skipped when left is false
                    if (bv_ is false)
                    {
                        bw_ = false;
                    }
                    else
                    {
                        FhirDateTime bx_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                        CqlDateTime by_ = context.Operators.Convert<CqlDateTime>(bx_);
                        bw_ = bv_ & (!((bool?)(by_ is null)));
                    }
                    return bj_ | bw_;
                }
            }

            bool? ay_ = context.Operators.WhereAny<ServiceRequest>(aw_, ax_);
            return ay_;
        }

        IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

        bool? j_(Observation DEXAPerformed) {
            Code<ObservationStatus> bz_ = DEXAPerformed?.StatusElement;
            ObservationStatus? ca_ = bz_?.Value;
            string cb_ = context.Operators.Convert<string>(ca_);
            string[] cc_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? cd_ = context.Operators.In<string>(cb_, (IEnumerable<string>)cc_);
            return cd_;
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
                bool? q_;
                // CQL 'and' (69:17-69:109): right operand skipped when left is false
                if (p_ is false)
                {
                    q_ = false;
                }
                else
                {
                    FhirDateTime r_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                    CqlDateTime s_ = context.Operators.Convert<CqlDateTime>(r_);
                    q_ = p_ & (!((bool?)(s_ is null)));
                }
                // CQL 'and' (69:17-70:62): right operand skipped when left is false
                if (q_ is false)
                {
                    return false;
                }
                else
                {

                    bool? t_(Extension @this) {
                        FhirUri aa_ = @this?.UrlElement;
                        string ab_ = FHIRHelpers_4_4_000.Instance.ToString(context, aa_);
                        bool? ac_ = context.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");
                        return ac_;
                    }


                    object u_(Extension @this) {
                        DataType ad_ = @this?.Value;
                        return ad_;
                    }

                    IEnumerable<object> v_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(DEXANotOrdered is DomainResource
                        ? (DEXANotOrdered as DomainResource).Extension
                        : default), t_, u_);
                    object w_ = context.Operators.SingletonFrom<object>(v_);
                    CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_ as CodeableConcept);
                    CqlValueSet y_ = this.Patient_Declined(context);
                    bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                    return q_ & z_;
                }
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
                bool? r_;
                // CQL 'and' (75:17-75:107): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    FhirDateTime s_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                    CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(s_);
                    r_ = q_ & (!((bool?)(t_ is null)));
                }
                // CQL 'and' (75:17-76:64): right operand skipped when left is false
                if (r_ is false)
                {
                    return false;
                }
                else
                {

                    bool? u_(Extension @this) {
                        FhirUri ab_ = @this?.UrlElement;
                        string ac_ = FHIRHelpers_4_4_000.Instance.ToString(context, ab_);
                        bool? ad_ = context.Operators.Equal(ac_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                        return ad_;
                    }


                    object v_(Extension @this) {
                        DataType ae_ = @this?.Value;
                        return ae_;
                    }

                    IEnumerable<object> w_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(DEXANotPerformed is DomainResource
                        ? (DEXANotPerformed as DomainResource).Extension
                        : default), u_, v_);
                    object x_ = context.Operators.SingletonFrom<object>(w_);
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_ as CodeableConcept);
                    CqlValueSet z_ = this.Patient_Declined(context);
                    bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                    return r_ & aa_;
                }
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
        // CQL 'or' (35:3-36:73): right operand skipped when left is true
        if (b_ is true)
        {
            return true;
        }
        else
        {
            IEnumerable<Observation> c_ = this.No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal(context);
            bool? d_ = context.Operators.Exists<Observation>(c_);
            return b_ | d_;
        }
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

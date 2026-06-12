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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
[CqlLibrary("CMS832FHIRHHAKI", "1.0.000")]
public partial class CMS832FHIRHHAKI_1_0_000 : ILibrary, ISingleton<CMS832FHIRHHAKI_1_0_000>
{
    #region ValueSets (9)

    [CqlValueSetDefinition("Body temperature", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", valueSetVersion: null)]
    public CqlValueSet Body_temperature(CqlContext _) => _Body_temperature;
    private static readonly CqlValueSet _Body_temperature = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", null);

    [CqlValueSetDefinition("Creatinine Mass Per Volume", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.21", valueSetVersion: null)]
    public CqlValueSet Creatinine_Mass_Per_Volume(CqlContext _) => _Creatinine_Mass_Per_Volume;
    private static readonly CqlValueSet _Creatinine_Mass_Per_Volume = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.21", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Glomerular Filtration Rate", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.17.4077.2.2038", valueSetVersion: null)]
    public CqlValueSet Glomerular_Filtration_Rate(CqlContext _) => _Glomerular_Filtration_Rate;
    private static readonly CqlValueSet _Glomerular_Filtration_Rate = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.17.4077.2.2038", null);

    [CqlValueSetDefinition("High Risk Diagnosis for AKI", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.12", valueSetVersion: null)]
    public CqlValueSet High_Risk_Diagnosis_for_AKI(CqlContext _) => _High_Risk_Diagnosis_for_AKI;
    private static readonly CqlValueSet _High_Risk_Diagnosis_for_AKI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.12", null);

    [CqlValueSetDefinition("High Risk Procedures for AKI", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.19", valueSetVersion: null)]
    public CqlValueSet High_Risk_Procedures_for_AKI(CqlContext _) => _High_Risk_Procedures_for_AKI;
    private static readonly CqlValueSet _High_Risk_Procedures_for_AKI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.19", null);

    [CqlValueSetDefinition("Hospital Based Dialysis Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.199", valueSetVersion: null)]
    public CqlValueSet Hospital_Based_Dialysis_Services(CqlContext _) => _Hospital_Based_Dialysis_Services;
    private static readonly CqlValueSet _Hospital_Based_Dialysis_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.199", null);

    [CqlValueSetDefinition("Obstetrics and VTE Obstetrics", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.33", valueSetVersion: null)]
    public CqlValueSet Obstetrics_and_VTE_Obstetrics(CqlContext _) => _Obstetrics_and_VTE_Obstetrics;
    private static readonly CqlValueSet _Obstetrics_and_VTE_Obstetrics = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.33", null);

    [CqlValueSetDefinition("Present on Admission or Clinically Undetermined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext _) => _Present_on_Admission_or_Clinically_Undetermined;
    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    #endregion ValueSets

    #region Codes (5)

    [CqlCodeDefinition("Female (finding)", codeId: "248152002", codeSystem: "http://snomed.info/sct")]
    public CqlCode Female__finding_(CqlContext _) => _Female__finding_;
    private static readonly CqlCode _Female__finding_ = new CqlCode("248152002", "http://snomed.info/sct");

    [CqlCodeDefinition("Male (finding)", codeId: "248153007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Male__finding_(CqlContext _) => _Male__finding_;
    private static readonly CqlCode _Male__finding_ = new CqlCode("248153007", "http://snomed.info/sct");

    [CqlCodeDefinition("Heart rate", codeId: "8867-4", codeSystem: "http://loinc.org")]
    public CqlCode Heart_rate(CqlContext _) => _Heart_rate;
    private static readonly CqlCode _Heart_rate = new CqlCode("8867-4", "http://loinc.org");

    [CqlCodeDefinition("Respiratory rate", codeId: "9279-1", codeSystem: "http://loinc.org")]
    public CqlCode Respiratory_rate(CqlContext _) => _Respiratory_rate;
    private static readonly CqlCode _Respiratory_rate = new CqlCode("9279-1", "http://loinc.org");

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Female__finding_,
          _Male__finding_]);

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Heart_rate,
          _Respiratory_rate,
          _Systolic_blood_pressure]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 8702147356379199569L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS832FHIRHHAKI-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (53)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 1313056991093908395L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 6492615943297325996L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 6458118187901141918L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 382284062271413605L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 464589695817475878L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter With Age 18 And Length Of Stay 48 Hours Or More")]
    public IEnumerable<Encounter> Encounter_With_Age_18_And_Length_Of_Stay_48_Hours_Or_More(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Age_18_And_Length_Of_Stay_48_Hours_Or_More, Encounter_With_Age_18_And_Length_Of_Stay_48_Hours_Or_More_Compute);

    private const long _cacheIndex_Encounter_With_Age_18_And_Length_Of_Stay_48_Hours_Or_More = 7306341055339958480L;

    private IEnumerable<Encounter> Encounter_With_Age_18_And_Length_Of_Stay_48_Hours_Or_More_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter InpatientEncounter) {

            List<Extension> e_() {

                bool au_() {
                    Patient av_ = this.Patient(context);
                    bool aw_ = av_ is DomainResource;
                    return aw_;
                }

                if (au_())
                {
                    Patient ax_ = this.Patient(context);
                    return (ax_ as DomainResource).Extension;
                }
                else
                {
                    return default;
                };
            }


            bool? f_(Extension @this) {
                FhirUri ay_ = @this?.UrlElement;
                string az_ = FHIRHelpers_4_4_000.Instance.ToString(context, ay_);
                bool? ba_ = context.Operators.Equal(az_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                return ba_;
            }

            IEnumerable<Extension> g_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(e_()), f_);

            DataType h_(Extension @this) {
                DataType bb_ = @this?.Value;
                return bb_;
            }

            IEnumerable<DataType> i_ = context.Operators.Select<Extension, DataType>(g_, h_);
            DataType j_ = context.Operators.SingletonFrom<DataType>(i_);
            string k_ = context.Operators.Convert<string>(j_);
            CqlCode l_ = this.Male__finding_(context);
            string m_ = l_?.code;
            CqlCode n_ = this.Female__finding_(context);
            string o_ = n_?.code;
            string[] p_ = [
                m_,
                o_,
            ];
            bool? q_ = context.Operators.In<string>(k_, (IEnumerable<string>)p_);
            Period r_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime t_ = context.Operators.End(s_);
            CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
            bool? v_ = context.Operators.In<CqlDateTime>(t_, u_, "day");
            bool? w_ = context.Operators.And(q_, v_);
            Code<Encounter.EncounterStatus> x_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? y_ = x_?.Value;
            Code<Encounter.EncounterStatus> z_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(y_);
            bool? aa_ = context.Operators.Equal(z_, "finished");
            bool? ab_ = context.Operators.And(w_, aa_);
            Patient ac_ = this.Patient(context);
            Date ad_ = ac_?.BirthDateElement;
            string ae_ = ad_?.Value;
            CqlDate af_ = context.Operators.ConvertStringToDate(ae_);
            CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlDate aj_ = context.Operators.DateFrom(ai_);
            int? ak_ = context.Operators.CalculateAgeAt(af_, aj_, "year");
            bool? al_ = context.Operators.GreaterOrEqual(ak_, 18);
            bool? am_ = context.Operators.And(ab_, al_);
            CqlInterval<CqlDateTime> an_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime ao_ = context.Operators.Start(an_);
            CqlDateTime aq_ = context.Operators.End(an_);
            int? ar_ = context.Operators.DurationBetween(ao_, aq_, "hour");
            bool? as_ = context.Operators.GreaterOrEqual(ar_, 48);
            bool? at_ = context.Operators.And(am_, as_);
            return at_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Inpatient Encounter With Creatinine")]
    public IEnumerable<Encounter> Inpatient_Encounter_With_Creatinine(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounter_With_Creatinine, Inpatient_Encounter_With_Creatinine_Compute);

    private const long _cacheIndex_Inpatient_Encounter_With_Creatinine = -4533029627528705985L;

    private IEnumerable<Encounter> Inpatient_Encounter_With_Creatinine_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Age_18_And_Length_Of_Stay_48_Hours_Or_More(context);
        CqlValueSet b_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);

        (CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)? e_(ValueTuple<Encounter, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)? l_ = (CqlTupleMetadata_BSZZjZXQgCBZNijVbAJbPfNhP, _valueTuple.Item1, _valueTuple.Item2);
            return l_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)?>(d_, e_);

        bool? g_((CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)? tuple_bbcfbwcplsbuhefbwpxpvuequ) {
            DataType m_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            bool? o_ = context.Operators.Not((bool?)((n_ as CqlQuantity) is null));

            object p_() {

                bool ag_() {
                    DataType aj_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlDateTime;
                    return al_;
                }


                bool ah_() {
                    DataType am_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlInterval<CqlDateTime>;
                    return ao_;
                }


                bool ai_() {
                    DataType ap_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlDateTime;
                    return ar_;
                }

                if (ag_())
                {
                    DataType as_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    return (at_ as CqlDateTime) as object;
                }
                else if (ah_())
                {
                    DataType au_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    return (av_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ai_())
                {
                    DataType aw_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return (ax_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_());
            CqlInterval<CqlDateTime> r_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bbcfbwcplsbuhefbwpxpvuequ?.Encounter48Hours);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlQuantity t_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime u_ = context.Operators.Add(s_, t_);
            CqlDateTime w_ = context.Operators.End(r_);
            CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);
            bool? y_ = context.Operators.In<CqlDateTime>(q_, x_, (string)default);
            bool? z_ = context.Operators.And(o_, y_);
            Code<ObservationStatus> aa_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.StatusElement;
            ObservationStatus? ab_ = aa_?.Value;
            string ac_ = context.Operators.Convert<string>(ab_);
            string[] ad_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
            bool? af_ = context.Operators.And(z_, ae_);
            return af_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)? tuple_bbcfbwcplsbuhefbwpxpvuequ) => tuple_bbcfbwcplsbuhefbwpxpvuequ?.Encounter48Hours;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        return k_;
    }


    [CqlExpressionDefinition("Encounter With Creatinine And Without Obstetrical Conditions")]
    public IEnumerable<Encounter> Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Creatinine_And_Without_Obstetrical_Conditions, Encounter_With_Creatinine_And_Without_Obstetrical_Conditions_Compute);

    private const long _cacheIndex_Encounter_With_Creatinine_And_Without_Obstetrical_Conditions = -3904229889472801572L;

    private IEnumerable<Encounter> Encounter_With_Creatinine_And_Without_Obstetrical_Conditions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounter_With_Creatinine(context);

        bool? b_(Encounter EncounterWithCreatinine) {
            List<CodeableConcept> d_ = EncounterWithCreatinine?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return r_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Obstetrics_and_VTE_Obstetrics(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, EncounterWithCreatinine);

            bool? j_(Condition @this) {
                CodeableConcept s_ = @this?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                bool? u_ = context.Operators.Not((bool?)(t_ is null));
                return u_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);

            CqlConcept l_(Condition @this) {
                CodeableConcept v_ = @this?.Code;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                return w_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<Condition, CqlConcept>(k_, l_);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? p_ = context.Operators.Or(h_, o_);
            bool? q_ = context.Operators.Not(p_);
            return q_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 4850351905671002306L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -7644606359869904193L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlFunctionDefinition("creatinineLabTestwithResultwithinFirst48Hours")]
    public IEnumerable<Observation> creatinineLabTestwithResultwithinFirst48Hours(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation CreatinineTest) {
            DataType h_ = CreatinineTest?.Value;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            bool? j_ = context.Operators.Not((bool?)((i_ as CqlQuantity) is null));

            object k_() {

                bool ag_() {
                    DataType aj_ = CreatinineTest?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlDateTime;
                    return al_;
                }


                bool ah_() {
                    DataType am_ = CreatinineTest?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlInterval<CqlDateTime>;
                    return ao_;
                }


                bool ai_() {
                    DataType ap_ = CreatinineTest?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlDateTime;
                    return ar_;
                }

                if (ag_())
                {
                    DataType as_ = CreatinineTest?.Effective;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    return (at_ as CqlDateTime) as object;
                }
                else if (ah_())
                {
                    DataType au_ = CreatinineTest?.Effective;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    return (av_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ai_())
                {
                    DataType aw_ = CreatinineTest?.Effective;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return (ax_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_());
            CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlDateTime p_ = context.Operators.Start(m_);
            CqlQuantity q_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime r_ = context.Operators.Add(p_, q_);
            CqlInterval<CqlDateTime> s_ = context.Operators.Interval(n_, r_, true, true);
            bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, (string)default);
            bool? u_ = context.Operators.And(j_, t_);

            object v_() {

                bool ay_() {
                    DataType bb_ = CreatinineTest?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlDateTime;
                    return bd_;
                }


                bool az_() {
                    DataType be_ = CreatinineTest?.Effective;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlInterval<CqlDateTime>;
                    return bg_;
                }


                bool ba_() {
                    DataType bh_ = CreatinineTest?.Effective;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlDateTime;
                    return bj_;
                }

                if (ay_())
                {
                    DataType bk_ = CreatinineTest?.Effective;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    return (bl_ as CqlDateTime) as object;
                }
                else if (az_())
                {
                    DataType bm_ = CreatinineTest?.Effective;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    return (bn_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ba_())
                {
                    DataType bo_ = CreatinineTest?.Effective;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    return (bp_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime w_ = QICoreCommon_4_0_000.Instance.earliest(context, v_());
            bool? y_ = context.Operators.In<CqlDateTime>(w_, m_, (string)default);
            bool? z_ = context.Operators.And(u_, y_);
            Code<ObservationStatus> aa_ = CreatinineTest?.StatusElement;
            ObservationStatus? ab_ = aa_?.Value;
            string ac_ = context.Operators.Convert<string>(ab_);
            string[] ad_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
            bool? af_ = context.Operators.And(z_, ae_);
            return af_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        Observation e_(Observation CreatinineTest) => CreatinineTest;
        IEnumerable<Observation> f_ = context.Operators.Select<Observation, Observation>(d_, e_);
        IEnumerable<Observation> g_ = context.Operators.Distinct<Observation>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Encounter With Less Than 2 Creatinine Results Within 48 Hours Of Arrival")]
    public IEnumerable<Encounter> Encounter_With_Less_Than_2_Creatinine_Results_Within_48_Hours_Of_Arrival(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Less_Than_2_Creatinine_Results_Within_48_Hours_Of_Arrival, Encounter_With_Less_Than_2_Creatinine_Results_Within_48_Hours_Of_Arrival_Compute);

    private const long _cacheIndex_Encounter_With_Less_Than_2_Creatinine_Results_Within_48_Hours_Of_Arrival = -927583554589844547L;

    private IEnumerable<Encounter> Encounter_With_Less_Than_2_Creatinine_Results_Within_48_Hours_Of_Arrival_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            IEnumerable<Observation> d_ = this.creatinineLabTestwithResultwithinFirst48Hours(context, QualifyingEncounter);
            int? e_ = context.Operators.Count<Observation>(d_);
            bool? f_ = context.Operators.Less(e_, 2);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("maleeGFR")]
    public decimal? maleeGFR(CqlContext context, Encounter QualifyingEncounter)
    {

        decimal? a_() {

            bool b_() {

                List<Extension> c_() {

                    bool l_() {
                        Patient m_ = this.Patient(context);
                        bool n_ = m_ is DomainResource;
                        return n_;
                    }

                    if (l_())
                    {
                        Patient o_ = this.Patient(context);
                        return (o_ as DomainResource).Extension;
                    }
                    else
                    {
                        return default;
                    };
                }


                bool? d_(Extension @this) {
                    FhirUri p_ = @this?.UrlElement;
                    string q_ = FHIRHelpers_4_4_000.Instance.ToString(context, p_);
                    bool? r_ = context.Operators.Equal(q_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                    return r_;
                }

                IEnumerable<Extension> e_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(c_()), d_);

                DataType f_(Extension @this) {
                    DataType s_ = @this?.Value;
                    return s_;
                }

                IEnumerable<DataType> g_ = context.Operators.Select<Extension, DataType>(e_, f_);
                DataType h_ = context.Operators.SingletonFrom<DataType>(g_);
                CqlCode i_ = this.Male__finding_(context);
                string j_ = i_?.code;
                bool? k_ = context.Operators.Equal(h_, j_);
                return k_ ?? false;
            }

            if (b_())
            {
                decimal? t_ = context.Operators.ConvertIntegerToDecimal(142);
                CqlQuantity u_ = this.indexCreatinine(context, QualifyingEncounter);
                decimal? v_ = u_?.value;
                decimal? w_ = context.Operators.Divide(v_, 0.9m);
                decimal? x_ = context.Operators.ConvertIntegerToDecimal(1);
                decimal?[] y_ = [
                    w_,
                    x_,
                ];
                decimal? z_ = context.Operators.Min<decimal?>((IEnumerable<decimal?>)y_);
                decimal? aa_ = context.Operators.Negate(0.302m);
                decimal? ab_ = context.Operators.Power(z_, aa_);
                decimal? ac_ = context.Operators.Multiply(t_, ab_);
                decimal? ae_ = u_?.value;
                decimal? af_ = context.Operators.Divide(ae_, 0.9m);
                decimal?[] ah_ = [
                    af_,
                    x_,
                ];
                decimal? ai_ = context.Operators.Max<decimal?>((IEnumerable<decimal?>)ah_);
                decimal? aj_ = context.Operators.Negate(1.200m);
                decimal? ak_ = context.Operators.Power(ai_, aj_);
                decimal? al_ = context.Operators.Multiply(ac_, ak_);
                Patient am_ = this.Patient(context);
                Date an_ = am_?.BirthDateElement;
                string ao_ = an_?.Value;
                CqlDateTime ap_ = context.Operators.ConvertStringToDateTime(ao_);
                CqlInterval<CqlDateTime> aq_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                int? as_ = context.Operators.CalculateAgeAt(ap_, ar_, "year");
                decimal? at_ = context.Operators.ConvertIntegerToDecimal(as_);
                decimal? au_ = context.Operators.Power(0.9938m, at_);
                decimal? av_ = context.Operators.Multiply(al_, au_);
                return av_;
            }
            else
            {
                return default;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("indexCreatinine")]
    public CqlQuantity indexCreatinine(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlQuantity a_ = this.lowestSerumCreatinineIn24Hours(context, QualifyingEncounter);
        IEnumerable<CqlQuantity> b_ = this.firstSerumCreatinineIn48Hours(context, QualifyingEncounter);
        CqlQuantity c_ = context.Operators.SingletonFrom<CqlQuantity>(b_);
        return a_ ?? c_;
    }


    [CqlFunctionDefinition("lowestSerumCreatinineIn24Hours")]
    public CqlQuantity lowestSerumCreatinineIn24Hours(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_By_Time(context);

        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTestsLow) {
            string i_ = LabTestsLow?.CrEncInPtId;
            string j_ = (QualifyingEncounter is Resource
                ? (QualifyingEncounter as Resource).IdElement
                : default)?.Value;
            bool? k_ = context.Operators.Equal(i_, j_);
            CqlDateTime l_ = LabTestsLow?.CrLabTime;
            CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlDateTime p_ = context.Operators.Start(m_);
            CqlQuantity q_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime r_ = context.Operators.Add(p_, q_);
            CqlInterval<CqlDateTime> s_ = context.Operators.Interval(n_, r_, true, true);
            bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, (string)default);
            bool? u_ = context.Operators.And(k_, t_);
            return u_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity v_ = @this?.CrLabResult;
            bool? w_ = context.Operators.Not((bool?)(v_ is null));
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> e_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(c_, d_);

        CqlQuantity f_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity x_ = @this?.CrLabResult;
            return x_;
        }

        IEnumerable<CqlQuantity> g_ = context.Operators.Select<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(e_, f_);
        CqlQuantity h_ = context.Operators.Min<CqlQuantity>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Qualifying Creatinine Lab Result By Time")]
    public IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> Qualifying_Creatinine_Lab_Result_By_Time(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Creatinine_Lab_Result_By_Time, Qualifying_Creatinine_Lab_Result_By_Time_Compute);

    private const long _cacheIndex_Qualifying_Creatinine_Lab_Result_By_Time = 345877987740715197L;

    private IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> Qualifying_Creatinine_Lab_Result_By_Time_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? e_(ValueTuple<Encounter, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? n_ = (CqlTupleMetadata_GiiGRATBZEQfMLdbZgPRgTeRJ, _valueTuple.Item1, _valueTuple.Item2);
            return n_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?>(d_, e_);

        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? tuple_ccccqpjvqogtctjhtilehkfoj) {

            object o_() {

                bool ao_() {
                    DataType ar_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlDateTime;
                    return at_;
                }


                bool ap_() {
                    DataType au_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    bool aw_ = av_ is CqlInterval<CqlDateTime>;
                    return aw_;
                }


                bool aq_() {
                    DataType ax_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlDateTime;
                    return az_;
                }

                if (ao_())
                {
                    DataType ba_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    return (bb_ as CqlDateTime) as object;
                }
                else if (ap_())
                {
                    DataType bc_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    return (bd_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (aq_())
                {
                    DataType be_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    return (bf_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_());
            CqlInterval<CqlDateTime> q_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter);
            bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, (string)default);
            bool? s_ = QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation);
            bool? t_ = context.Operators.And(r_, s_);
            Code<ObservationStatus> u_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.StatusElement;
            ObservationStatus? v_ = u_?.Value;
            string w_ = context.Operators.Convert<string>(v_);
            string[] x_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
            bool? z_ = context.Operators.And(t_, y_);
            DataType aa_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            string ac_ = (ab_ as CqlQuantity)?.unit;
            bool? ad_ = context.Operators.Equal(ac_, "mg/dL");
            bool? ae_ = context.Operators.And(z_, ad_);
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
            bool? ai_ = context.Operators.And(ae_, ah_);
            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            CqlQuantity al_ = context.Operators.Quantity(0m, "mg/dL");
            bool? am_ = context.Operators.Greater(ak_ as CqlQuantity, al_);
            bool? an_ = context.Operators.And(ai_, am_);
            return an_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?>(f_, g_);

        (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? tuple_ccccqpjvqogtctjhtilehkfoj) {
            Id bg_ = tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter?.IdElement;
            string bh_ = bg_?.Value;
            CqlInterval<CqlDateTime> bi_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter);
            Id bj_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IdElement;
            string bk_ = bj_?.Value;

            object bl_() {
                if ((QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation)) ?? false)
                {
                    return "laboratory" as object;
                }
                else
                {
                    bool? cg_ = QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation);
                    return cg_;
                };
            }

            List<CodeableConcept> bm_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Category;

            CqlConcept bn_(CodeableConcept @this) {
                CqlConcept ch_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ch_;
            }

            IEnumerable<CqlConcept> bo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bm_, bn_);
            Code<ObservationStatus> bp_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.StatusElement;
            ObservationStatus? bq_ = bp_?.Value;
            string br_ = context.Operators.Convert<string>(bq_);
            DataType bs_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
            string bw_ = (bv_ as CqlQuantity)?.unit;
            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
            decimal? bz_ = (by_ as CqlQuantity)?.value;

            object ca_() {

                bool ci_() {
                    DataType cl_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    bool cn_ = cm_ is CqlDateTime;
                    return cn_;
                }


                bool cj_() {
                    DataType co_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                    bool cq_ = cp_ is CqlInterval<CqlDateTime>;
                    return cq_;
                }


                bool ck_() {
                    DataType cr_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    bool ct_ = cs_ is CqlDateTime;
                    return ct_;
                }

                if (ci_())
                {
                    DataType cu_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                    return (cv_ as CqlDateTime) as object;
                }
                else if (cj_())
                {
                    DataType cw_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                    return (cx_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ck_())
                {
                    DataType cy_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    return (cz_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime cb_ = QICoreCommon_4_0_000.Instance.earliest(context, ca_());
            Instant cc_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IssuedElement;
            DateTimeOffset? cd_ = cc_?.Value;
            CqlDateTime ce_ = context.Operators.Convert<CqlDateTime>(cd_);
            (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? cf_ = (CqlTupleMetadata_EROdcjJjSdFbfXChfKbYbOdDN, bh_, bi_, bk_, bl_(), bo_, br_, bt_ as CqlQuantity, bw_, bz_, cb_, ce_);
            return cf_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?, (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(h_, i_);
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> k_ = context.Operators.Distinct<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(j_);

        object l_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime da_ = @this?.CrLabTime;
            return da_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> m_ = context.Operators.SortBy<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);
        return m_;
    }


    [CqlFunctionDefinition("firstSerumCreatinineIn48Hours")]
    public IEnumerable<CqlQuantity> firstSerumCreatinineIn48Hours(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_By_Time(context);

        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests) {
            CqlDateTime g_ = this.earliestSerumCreatinineTimeIn48Hours(context, QualifyingEncounter);
            CqlDateTime h_ = LabTests?.CrLabTime;
            bool? i_ = context.Operators.Equal(g_, h_);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        CqlQuantity d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests) {
            CqlQuantity j_ = LabTests?.CrLabResult;
            return j_ as CqlQuantity;
        }

        IEnumerable<CqlQuantity> e_ = context.Operators.Select<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(c_, d_);
        IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);
        return f_;
    }


    [CqlFunctionDefinition("earliestSerumCreatinineTimeIn48Hours")]
    public CqlDateTime earliestSerumCreatinineTimeIn48Hours(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_By_Time(context);

        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests48) {
            string i_ = LabTests48?.CrEncInPtId;
            string j_ = (QualifyingEncounter is Resource
                ? (QualifyingEncounter as Resource).IdElement
                : default)?.Value;
            bool? k_ = context.Operators.Equal(i_, j_);
            CqlDateTime l_ = LabTests48?.CrLabTime;
            CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlDateTime p_ = context.Operators.Start(m_);
            CqlQuantity q_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime r_ = context.Operators.Add(p_, q_);
            CqlInterval<CqlDateTime> s_ = context.Operators.Interval(n_, r_, true, true);
            bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, (string)default);
            bool? u_ = context.Operators.And(k_, t_);
            return u_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime v_ = @this?.CrLabTime;
            bool? w_ = context.Operators.Not((bool?)(v_ is null));
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> e_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(c_, d_);

        CqlDateTime f_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime x_ = @this?.CrLabTime;
            return x_;
        }

        IEnumerable<CqlDateTime> g_ = context.Operators.Select<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlDateTime>(e_, f_);
        CqlDateTime h_ = context.Operators.Min<CqlDateTime>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Male Encounter With eGFR Less Than 60")]
    public IEnumerable<Encounter> Male_Encounter_With_eGFR_Less_Than_60(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Male_Encounter_With_eGFR_Less_Than_60, Male_Encounter_With_eGFR_Less_Than_60_Compute);

    private const long _cacheIndex_Male_Encounter_With_eGFR_Less_Than_60 = -3663025247698668606L;

    private IEnumerable<Encounter> Male_Encounter_With_eGFR_Less_Than_60_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            decimal? d_ = this.maleeGFR(context, QualifyingEncounter);
            bool? e_ = context.Operators.Not((bool?)(d_ is null));
            decimal? g_ = context.Operators.ConvertIntegerToDecimal(60);
            bool? h_ = context.Operators.Less(d_ as decimal?, g_);
            bool? i_ = context.Operators.And(e_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("femaleeGFR")]
    public decimal? femaleeGFR(CqlContext context, Encounter QualifyingEncounter)
    {

        decimal? a_() {

            bool b_() {

                List<Extension> c_() {

                    bool l_() {
                        Patient m_ = this.Patient(context);
                        bool n_ = m_ is DomainResource;
                        return n_;
                    }

                    if (l_())
                    {
                        Patient o_ = this.Patient(context);
                        return (o_ as DomainResource).Extension;
                    }
                    else
                    {
                        return default;
                    };
                }


                bool? d_(Extension @this) {
                    FhirUri p_ = @this?.UrlElement;
                    string q_ = FHIRHelpers_4_4_000.Instance.ToString(context, p_);
                    bool? r_ = context.Operators.Equal(q_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                    return r_;
                }

                IEnumerable<Extension> e_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(c_()), d_);

                DataType f_(Extension @this) {
                    DataType s_ = @this?.Value;
                    return s_;
                }

                IEnumerable<DataType> g_ = context.Operators.Select<Extension, DataType>(e_, f_);
                DataType h_ = context.Operators.SingletonFrom<DataType>(g_);
                CqlCode i_ = this.Female__finding_(context);
                string j_ = i_?.code;
                bool? k_ = context.Operators.Equal(h_, j_);
                return k_ ?? false;
            }

            if (b_())
            {
                decimal? t_ = context.Operators.ConvertIntegerToDecimal(142);
                CqlQuantity u_ = this.indexCreatinine(context, QualifyingEncounter);
                decimal? v_ = u_?.value;
                decimal? w_ = context.Operators.Divide(v_, 0.7m);
                decimal? x_ = context.Operators.ConvertIntegerToDecimal(1);
                decimal?[] y_ = [
                    w_,
                    x_,
                ];
                decimal? z_ = context.Operators.Min<decimal?>((IEnumerable<decimal?>)y_);
                decimal? aa_ = context.Operators.Negate(0.241m);
                decimal? ab_ = context.Operators.Power(z_, aa_);
                decimal? ac_ = context.Operators.Multiply(t_, ab_);
                decimal? ae_ = u_?.value;
                decimal? af_ = context.Operators.Divide(ae_, 0.7m);
                decimal?[] ah_ = [
                    af_,
                    x_,
                ];
                decimal? ai_ = context.Operators.Max<decimal?>((IEnumerable<decimal?>)ah_);
                decimal? aj_ = context.Operators.Negate(1.200m);
                decimal? ak_ = context.Operators.Power(ai_, aj_);
                decimal? al_ = context.Operators.Multiply(ac_, ak_);
                Patient am_ = this.Patient(context);
                Date an_ = am_?.BirthDateElement;
                string ao_ = an_?.Value;
                CqlDateTime ap_ = context.Operators.ConvertStringToDateTime(ao_);
                CqlInterval<CqlDateTime> aq_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                int? as_ = context.Operators.CalculateAgeAt(ap_, ar_, "year");
                decimal? at_ = context.Operators.ConvertIntegerToDecimal(as_);
                decimal? au_ = context.Operators.Power(0.9938m, at_);
                decimal? av_ = context.Operators.Multiply(al_, au_);
                decimal? aw_ = context.Operators.Multiply(av_, 1.012m);
                return aw_;
            }
            else
            {
                return default;
            };
        }

        return a_();
    }


    [CqlExpressionDefinition("Female Encounter With eGFR Less Than 60")]
    public IEnumerable<Encounter> Female_Encounter_With_eGFR_Less_Than_60(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Female_Encounter_With_eGFR_Less_Than_60, Female_Encounter_With_eGFR_Less_Than_60_Compute);

    private const long _cacheIndex_Female_Encounter_With_eGFR_Less_Than_60 = 291161774982567116L;

    private IEnumerable<Encounter> Female_Encounter_With_eGFR_Less_Than_60_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            decimal? d_ = this.femaleeGFR(context, QualifyingEncounter);
            bool? e_ = context.Operators.Not((bool?)(d_ is null));
            decimal? g_ = context.Operators.ConvertIntegerToDecimal(60);
            bool? h_ = context.Operators.Less(d_ as decimal?, g_);
            bool? i_ = context.Operators.And(e_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Index eGFR Less Than 60 Within First 48 Hours")]
    public IEnumerable<Encounter> Encounter_With_Index_eGFR_Less_Than_60_Within_First_48_Hours(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Index_eGFR_Less_Than_60_Within_First_48_Hours, Encounter_With_Index_eGFR_Less_Than_60_Within_First_48_Hours_Compute);

    private const long _cacheIndex_Encounter_With_Index_eGFR_Less_Than_60_Within_First_48_Hours = -5854325362013741536L;

    private IEnumerable<Encounter> Encounter_With_Index_eGFR_Less_Than_60_Within_First_48_Hours_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Male_Encounter_With_eGFR_Less_Than_60(context);
        IEnumerable<Encounter> b_ = this.Female_Encounter_With_eGFR_Less_Than_60(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("lowestSerumCreatinineResult")]
    public CqlQuantity lowestSerumCreatinineResult(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_By_Time(context);

        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests) {
            string i_ = LabTests?.CrEncInPtId;
            string j_ = (QualifyingEncounter is Resource
                ? (QualifyingEncounter as Resource).IdElement
                : default)?.Value;
            bool? k_ = context.Operators.Equal(i_, j_);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity l_ = @this?.CrLabResult;
            bool? m_ = context.Operators.Not((bool?)(l_ is null));
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> e_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(c_, d_);

        CqlQuantity f_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity n_ = @this?.CrLabResult;
            return n_;
        }

        IEnumerable<CqlQuantity> g_ = context.Operators.Select<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(e_, f_);
        CqlQuantity h_ = context.Operators.Min<CqlQuantity>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Increase Of 0.3 Or More Using Lowest Creatinine Within 24 Hours")]
    public IEnumerable<Encounter> Increase_Of_0_3_Or_More_Using_Lowest_Creatinine_Within_24_Hours(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Increase_Of_0_3_Or_More_Using_Lowest_Creatinine_Within_24_Hours, Increase_Of_0_3_Or_More_Using_Lowest_Creatinine_Within_24_Hours_Compute);

    private const long _cacheIndex_Increase_Of_0_3_Or_More_Using_Lowest_Creatinine_Within_24_Hours = -5166144980564649165L;

    private IEnumerable<Encounter> Increase_Of_0_3_Or_More_Using_Lowest_Creatinine_Within_24_Hours_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> f_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, c_, e_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? g_(ValueTuple<Encounter, Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? n_ = (CqlTupleMetadata_FWVGLDcQEISFGIdVNGEWPHUFV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return n_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?> h_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?>(f_, g_);

        bool? i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen) {
            Code<ObservationStatus> o_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.StatusElement;
            ObservationStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            string[] r_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
            Code<ObservationStatus> t_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.StatusElement;
            ObservationStatus? u_ = t_?.Value;
            string v_ = context.Operators.Convert<string>(u_);
            bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)r_);
            bool? y_ = context.Operators.And(s_, x_);
            DataType z_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Value;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            DataType ab_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlQuantity ad_ = context.Operators.Subtract(aa_ as CqlQuantity, ac_ as CqlQuantity);
            CqlQuantity ae_ = context.Operators.Quantity(0.299m, "mg/dL");
            bool? af_ = context.Operators.Greater(ad_, ae_);
            bool? ag_ = context.Operators.And(y_, af_);
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlQuantity aj_ = this.lowestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            bool? ak_ = context.Operators.Equal(ai_ as CqlQuantity, aj_);
            bool? al_ = context.Operators.And(ag_, ak_);

            object am_() {

                bool ck_() {
                    DataType cn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    bool cp_ = co_ is CqlDateTime;
                    return cp_;
                }


                bool cl_() {
                    DataType cq_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    bool cs_ = cr_ is CqlInterval<CqlDateTime>;
                    return cs_;
                }


                bool cm_() {
                    DataType ct_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    bool cv_ = cu_ is CqlDateTime;
                    return cv_;
                }

                if (ck_())
                {
                    DataType cw_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                    return (cx_ as CqlDateTime) as object;
                }
                else if (cl_())
                {
                    DataType cy_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    return (cz_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cm_())
                {
                    DataType da_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    return (db_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime an_ = QICoreCommon_4_0_000.Instance.earliest(context, am_());

            object ao_() {

                bool dc_() {
                    DataType df_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    bool dh_ = dg_ is CqlDateTime;
                    return dh_;
                }


                bool dd_() {
                    DataType di_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                    bool dk_ = dj_ is CqlInterval<CqlDateTime>;
                    return dk_;
                }


                bool de_() {
                    DataType dl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    bool dn_ = dm_ is CqlDateTime;
                    return dn_;
                }

                if (dc_())
                {
                    DataType do_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                    return (dp_ as CqlDateTime) as object;
                }
                else if (dd_())
                {
                    DataType dq_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                    return (dr_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (de_())
                {
                    DataType ds_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    return (dt_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_());
            CqlQuantity aq_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime ar_ = context.Operators.Subtract(ap_, aq_);

            object as_() {

                bool du_() {
                    DataType dx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    bool dz_ = dy_ is CqlDateTime;
                    return dz_;
                }


                bool dv_() {
                    DataType ea_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                    bool ec_ = eb_ is CqlInterval<CqlDateTime>;
                    return ec_;
                }


                bool dw_() {
                    DataType ed_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                    bool ef_ = ee_ is CqlDateTime;
                    return ef_;
                }

                if (du_())
                {
                    DataType eg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                    return (eh_ as CqlDateTime) as object;
                }
                else if (dv_())
                {
                    DataType ei_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                    return (ej_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dw_())
                {
                    DataType ek_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    return (el_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_());
            CqlInterval<CqlDateTime> au_ = context.Operators.Interval(ar_, at_, true, true);
            bool? av_ = context.Operators.In<CqlDateTime>(an_, au_, (string)default);
            bool? aw_ = context.Operators.And(al_, av_);

            object ax_() {

                bool em_() {
                    DataType ep_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    bool er_ = eq_ is CqlDateTime;
                    return er_;
                }


                bool en_() {
                    DataType es_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                    bool eu_ = et_ is CqlInterval<CqlDateTime>;
                    return eu_;
                }


                bool eo_() {
                    DataType ev_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    bool ex_ = ew_ is CqlDateTime;
                    return ex_;
                }

                if (em_())
                {
                    DataType ey_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                    return (ez_ as CqlDateTime) as object;
                }
                else if (en_())
                {
                    DataType fa_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                    return (fb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (eo_())
                {
                    DataType fc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                    return (fd_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime ay_ = QICoreCommon_4_0_000.Instance.earliest(context, ax_());
            CqlInterval<CqlDateTime> az_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            bool? ba_ = context.Operators.In<CqlDateTime>(ay_, az_, (string)default);
            bool? bb_ = context.Operators.And(aw_, ba_);

            object bc_() {

                bool fe_() {
                    DataType fh_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                    bool fj_ = fi_ is CqlDateTime;
                    return fj_;
                }


                bool ff_() {
                    DataType fk_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                    bool fm_ = fl_ is CqlInterval<CqlDateTime>;
                    return fm_;
                }


                bool fg_() {
                    DataType fn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    bool fp_ = fo_ is CqlDateTime;
                    return fp_;
                }

                if (fe_())
                {
                    DataType fq_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                    return (fr_ as CqlDateTime) as object;
                }
                else if (ff_())
                {
                    DataType fs_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                    return (ft_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fg_())
                {
                    DataType fu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                    return (fv_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_());
            CqlDateTime bf_ = context.Operators.Start(az_);
            CqlDateTime bh_ = context.Operators.Start(az_);
            CqlQuantity bi_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime bj_ = context.Operators.Add(bh_, bi_);
            CqlInterval<CqlDateTime> bk_ = context.Operators.Interval(bf_, bj_, true, true);
            bool? bl_ = context.Operators.In<CqlDateTime>(bd_, bk_, (string)default);
            bool? bm_ = context.Operators.And(bb_, bl_);

            object bn_() {

                bool fw_() {
                    DataType fz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                    bool gb_ = ga_ is CqlDateTime;
                    return gb_;
                }


                bool fx_() {
                    DataType gc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gc_);
                    bool ge_ = gd_ is CqlInterval<CqlDateTime>;
                    return ge_;
                }


                bool fy_() {
                    DataType gf_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gf_);
                    bool gh_ = gg_ is CqlDateTime;
                    return gh_;
                }

                if (fw_())
                {
                    DataType gi_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
                    return (gj_ as CqlDateTime) as object;
                }
                else if (fx_())
                {
                    DataType gk_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gk_);
                    return (gl_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fy_())
                {
                    DataType gm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                    return (gn_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime bo_ = QICoreCommon_4_0_000.Instance.earliest(context, bn_());
            bool? bq_ = context.Operators.In<CqlDateTime>(bo_, az_, (string)default);
            bool? br_ = context.Operators.And(bm_, bq_);

            object bs_() {

                bool go_() {
                    DataType gr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
                    bool gt_ = gs_ is CqlDateTime;
                    return gt_;
                }


                bool gp_() {
                    DataType gu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gu_);
                    bool gw_ = gv_ is CqlInterval<CqlDateTime>;
                    return gw_;
                }


                bool gq_() {
                    DataType gx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                    bool gz_ = gy_ is CqlDateTime;
                    return gz_;
                }

                if (go_())
                {
                    DataType ha_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object hb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ha_);
                    return (hb_ as CqlDateTime) as object;
                }
                else if (gp_())
                {
                    DataType hc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object hd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hc_);
                    return (hd_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gq_())
                {
                    DataType he_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object hf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, he_);
                    return (hf_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime bt_ = QICoreCommon_4_0_000.Instance.earliest(context, bs_());
            CqlDateTime bv_ = context.Operators.Start(az_);
            CqlDateTime bx_ = context.Operators.Start(az_);
            CqlDateTime bz_ = context.Operators.Add(bx_, aq_);
            CqlInterval<CqlDateTime> ca_ = context.Operators.Interval(bv_, bz_, true, true);
            bool? cb_ = context.Operators.In<CqlDateTime>(bt_, ca_, (string)default);
            bool? cc_ = context.Operators.And(br_, cb_);
            Id cd_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
            string ce_ = cd_?.Value;
            Id cf_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
            string cg_ = cf_?.Value;
            bool? ch_ = context.Operators.Equal(ce_, cg_);
            bool? ci_ = context.Operators.Not(ch_);
            bool? cj_ = context.Operators.And(cc_, ci_);
            return cj_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?> j_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?>(h_, i_);
        Encounter k_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen) => tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter;
        IEnumerable<Encounter> l_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?, Encounter>(j_, k_);
        IEnumerable<Encounter> m_ = context.Operators.Distinct<Encounter>(l_);
        return m_;
    }


    [CqlFunctionDefinition("earliestSerumCreatinineResult")]
    public IEnumerable<CqlQuantity> earliestSerumCreatinineResult(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_By_Time(context);

        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests) {
            CqlDateTime g_ = this.earliestSerumCreatinineTime(context, QualifyingEncounter);
            CqlDateTime h_ = LabTests?.CrLabTime;
            bool? i_ = context.Operators.Equal(g_, h_);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        CqlQuantity d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests) {
            CqlQuantity j_ = LabTests?.CrLabResult;
            return j_ as CqlQuantity;
        }

        IEnumerable<CqlQuantity> e_ = context.Operators.Select<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(c_, d_);
        IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);
        return f_;
    }


    [CqlFunctionDefinition("earliestSerumCreatinineTime")]
    public CqlDateTime earliestSerumCreatinineTime(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_By_Time(context);

        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTestsEarly) {
            string i_ = LabTestsEarly?.CrEncInPtId;
            string j_ = (QualifyingEncounter is Resource
                ? (QualifyingEncounter as Resource).IdElement
                : default)?.Value;
            bool? k_ = context.Operators.Equal(i_, j_);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime l_ = @this?.CrLabTime;
            bool? m_ = context.Operators.Not((bool?)(l_ is null));
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> e_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(c_, d_);

        CqlDateTime f_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime n_ = @this?.CrLabTime;
            return n_;
        }

        IEnumerable<CqlDateTime> g_ = context.Operators.Select<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlDateTime>(e_, f_);
        CqlDateTime h_ = context.Operators.Min<CqlDateTime>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Increase Of 0.3 Or More Using First Creatinine Within First 48 Hours")]
    public IEnumerable<Encounter> Increase_Of_0_3_Or_More_Using_First_Creatinine_Within_First_48_Hours(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Increase_Of_0_3_Or_More_Using_First_Creatinine_Within_First_48_Hours, Increase_Of_0_3_Or_More_Using_First_Creatinine_Within_First_48_Hours_Compute);

    private const long _cacheIndex_Increase_Of_0_3_Or_More_Using_First_Creatinine_Within_First_48_Hours = -7920304359911558318L;

    private IEnumerable<Encounter> Increase_Of_0_3_Or_More_Using_First_Creatinine_Within_First_48_Hours_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> f_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, c_, e_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? g_(ValueTuple<Encounter, Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? n_ = (CqlTupleMetadata_FWVGLDcQEISFGIdVNGEWPHUFV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return n_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?> h_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?>(f_, g_);

        bool? i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen) {
            Code<ObservationStatus> o_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.StatusElement;
            ObservationStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            string[] r_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
            Code<ObservationStatus> t_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.StatusElement;
            ObservationStatus? u_ = t_?.Value;
            string v_ = context.Operators.Convert<string>(u_);
            bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)r_);
            bool? y_ = context.Operators.And(s_, x_);
            DataType z_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Value;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            DataType ab_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlQuantity ad_ = context.Operators.Subtract(aa_ as CqlQuantity, ac_ as CqlQuantity);
            CqlQuantity ae_ = context.Operators.Quantity(0.299m, "mg/dL");
            bool? af_ = context.Operators.Greater(ad_, ae_);
            bool? ag_ = context.Operators.And(y_, af_);
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            IEnumerable<CqlQuantity> aj_ = this.earliestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            CqlQuantity ak_ = context.Operators.SingletonFrom<CqlQuantity>(aj_);
            bool? al_ = context.Operators.Equal(ai_ as CqlQuantity, ak_);
            bool? am_ = context.Operators.And(ag_, al_);

            object an_() {

                bool cl_() {
                    DataType co_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                    bool cq_ = cp_ is CqlDateTime;
                    return cq_;
                }


                bool cm_() {
                    DataType cr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    bool ct_ = cs_ is CqlInterval<CqlDateTime>;
                    return ct_;
                }


                bool cn_() {
                    DataType cu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                    bool cw_ = cv_ is CqlDateTime;
                    return cw_;
                }

                if (cl_())
                {
                    DataType cx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    return (cy_ as CqlDateTime) as object;
                }
                else if (cm_())
                {
                    DataType cz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    return (da_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cn_())
                {
                    DataType db_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    return (dc_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_());

            object ap_() {

                bool dd_() {
                    DataType dg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                    bool di_ = dh_ is CqlDateTime;
                    return di_;
                }


                bool de_() {
                    DataType dj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                    bool dl_ = dk_ is CqlInterval<CqlDateTime>;
                    return dl_;
                }


                bool df_() {
                    DataType dm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                    bool do_ = dn_ is CqlDateTime;
                    return do_;
                }

                if (dd_())
                {
                    DataType dp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    return (dq_ as CqlDateTime) as object;
                }
                else if (de_())
                {
                    DataType dr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    return (ds_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (df_())
                {
                    DataType dt_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    return (du_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_());
            CqlQuantity ar_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime as_ = context.Operators.Subtract(aq_, ar_);

            object at_() {

                bool dv_() {
                    DataType dy_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    bool ea_ = dz_ is CqlDateTime;
                    return ea_;
                }


                bool dw_() {
                    DataType eb_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                    bool ed_ = ec_ is CqlInterval<CqlDateTime>;
                    return ed_;
                }


                bool dx_() {
                    DataType ee_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                    bool eg_ = ef_ is CqlDateTime;
                    return eg_;
                }

                if (dv_())
                {
                    DataType eh_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                    return (ei_ as CqlDateTime) as object;
                }
                else if (dw_())
                {
                    DataType ej_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    return (ek_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dx_())
                {
                    DataType el_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    return (em_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime au_ = QICoreCommon_4_0_000.Instance.earliest(context, at_());
            CqlInterval<CqlDateTime> av_ = context.Operators.Interval(as_, au_, true, true);
            bool? aw_ = context.Operators.In<CqlDateTime>(ao_, av_, (string)default);
            bool? ax_ = context.Operators.And(am_, aw_);

            object ay_() {

                bool en_() {
                    DataType eq_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    bool es_ = er_ is CqlDateTime;
                    return es_;
                }


                bool eo_() {
                    DataType et_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    bool ev_ = eu_ is CqlInterval<CqlDateTime>;
                    return ev_;
                }


                bool ep_() {
                    DataType ew_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                    bool ey_ = ex_ is CqlDateTime;
                    return ey_;
                }

                if (en_())
                {
                    DataType ez_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                    return (fa_ as CqlDateTime) as object;
                }
                else if (eo_())
                {
                    DataType fb_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                    return (fc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ep_())
                {
                    DataType fd_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                    return (fe_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime az_ = QICoreCommon_4_0_000.Instance.earliest(context, ay_());
            CqlInterval<CqlDateTime> ba_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            bool? bb_ = context.Operators.In<CqlDateTime>(az_, ba_, (string)default);
            bool? bc_ = context.Operators.And(ax_, bb_);

            object bd_() {

                bool ff_() {
                    DataType fi_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    bool fk_ = fj_ is CqlDateTime;
                    return fk_;
                }


                bool fg_() {
                    DataType fl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    bool fn_ = fm_ is CqlInterval<CqlDateTime>;
                    return fn_;
                }


                bool fh_() {
                    DataType fo_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                    bool fq_ = fp_ is CqlDateTime;
                    return fq_;
                }

                if (ff_())
                {
                    DataType fr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                    return (fs_ as CqlDateTime) as object;
                }
                else if (fg_())
                {
                    DataType ft_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                    return (fu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fh_())
                {
                    DataType fv_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                    return (fw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime be_ = QICoreCommon_4_0_000.Instance.earliest(context, bd_());
            CqlDateTime bg_ = context.Operators.Start(ba_);
            CqlDateTime bi_ = context.Operators.Start(ba_);
            CqlDateTime bk_ = context.Operators.Add(bi_, ar_);
            CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bg_, bk_, true, true);
            bool? bm_ = context.Operators.In<CqlDateTime>(be_, bl_, (string)default);
            bool? bn_ = context.Operators.And(bc_, bm_);

            object bo_() {

                bool fx_() {
                    DataType ga_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
                    bool gc_ = gb_ is CqlDateTime;
                    return gc_;
                }


                bool fy_() {
                    DataType gd_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                    bool gf_ = ge_ is CqlInterval<CqlDateTime>;
                    return gf_;
                }


                bool fz_() {
                    DataType gg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                    bool gi_ = gh_ is CqlDateTime;
                    return gi_;
                }

                if (fx_())
                {
                    DataType gj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                    return (gk_ as CqlDateTime) as object;
                }
                else if (fy_())
                {
                    DataType gl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                    return (gm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fz_())
                {
                    DataType gn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                    return (go_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime bp_ = QICoreCommon_4_0_000.Instance.earliest(context, bo_());
            bool? br_ = context.Operators.In<CqlDateTime>(bp_, ba_, (string)default);
            bool? bs_ = context.Operators.And(bn_, br_);

            object bt_() {

                bool gp_() {
                    DataType gs_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                    bool gu_ = gt_ is CqlDateTime;
                    return gu_;
                }


                bool gq_() {
                    DataType gv_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
                    bool gx_ = gw_ is CqlInterval<CqlDateTime>;
                    return gx_;
                }


                bool gr_() {
                    DataType gy_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object gz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gy_);
                    bool ha_ = gz_ is CqlDateTime;
                    return ha_;
                }

                if (gp_())
                {
                    DataType hb_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object hc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hb_);
                    return (hc_ as CqlDateTime) as object;
                }
                else if (gq_())
                {
                    DataType hd_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object he_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hd_);
                    return (he_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gr_())
                {
                    DataType hf_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object hg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hf_);
                    return (hg_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime bu_ = QICoreCommon_4_0_000.Instance.earliest(context, bt_());
            CqlDateTime bw_ = context.Operators.Start(ba_);
            CqlDateTime by_ = context.Operators.Start(ba_);
            CqlDateTime ca_ = context.Operators.Add(by_, ar_);
            CqlInterval<CqlDateTime> cb_ = context.Operators.Interval(bw_, ca_, true, true);
            bool? cc_ = context.Operators.In<CqlDateTime>(bu_, cb_, (string)default);
            bool? cd_ = context.Operators.And(bs_, cc_);
            Id ce_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
            string cf_ = ce_?.Value;
            Id cg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
            string ch_ = cg_?.Value;
            bool? ci_ = context.Operators.Equal(cf_, ch_);
            bool? cj_ = context.Operators.Not(ci_);
            bool? ck_ = context.Operators.And(cd_, cj_);
            return ck_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?> j_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?>(h_, i_);
        Encounter k_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen) => tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter;
        IEnumerable<Encounter> l_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?, Encounter>(j_, k_);
        IEnumerable<Encounter> m_ = context.Operators.Distinct<Encounter>(l_);
        return m_;
    }


    [CqlExpressionDefinition("Encounter With 0.3 mg dL Or More Increase In Creatinine")]
    public IEnumerable<Encounter> Encounter_With_0_3_mg_dL_Or_More_Increase_In_Creatinine(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_0_3_mg_dL_Or_More_Increase_In_Creatinine, Encounter_With_0_3_mg_dL_Or_More_Increase_In_Creatinine_Compute);

    private const long _cacheIndex_Encounter_With_0_3_mg_dL_Or_More_Increase_In_Creatinine = -5216877179906045513L;

    private IEnumerable<Encounter> Encounter_With_0_3_mg_dL_Or_More_Increase_In_Creatinine_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Increase_Of_0_3_Or_More_Using_Lowest_Creatinine_Within_24_Hours(context);
        IEnumerable<Encounter> b_ = this.Increase_Of_0_3_Or_More_Using_First_Creatinine_Within_First_48_Hours(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Kidney Dialysis Started 48 Hours Or Less After Arrival")]
    public IEnumerable<Encounter> Encounter_With_Kidney_Dialysis_Started_48_Hours_Or_Less_After_Arrival(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Kidney_Dialysis_Started_48_Hours_Or_Less_After_Arrival, Encounter_With_Kidney_Dialysis_Started_48_Hours_Or_Less_After_Arrival_Compute);

    private const long _cacheIndex_Encounter_With_Kidney_Dialysis_Started_48_Hours_Or_Less_After_Arrival = -1682904281216210909L;

    private IEnumerable<Encounter> Encounter_With_Kidney_Dialysis_Started_48_Hours_Or_Less_After_Arrival_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hospital_Based_Dialysis_Services(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Encounter> c_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);
        IEnumerable<ValueTuple<Procedure, Encounter>> d_ = context.Operators.CrossJoin<Procedure, Encounter>(b_, c_);

        (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? e_(ValueTuple<Procedure, Encounter> _valueTuple) {
            (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? l_ = (CqlTupleMetadata_BWWSXdXSFIJQjJNcdEVJKZEGj, _valueTuple.Item1, _valueTuple.Item2);
            return l_;
        }

        IEnumerable<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?> f_ = context.Operators.Select<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?>(d_, e_);

        bool? g_((CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? tuple_bwwsxdxsfijqjjncdevjkzegj) {
            Code<EventStatus> m_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.StatusElement;
            EventStatus? n_ = m_?.Value;
            string o_ = context.Operators.Convert<string>(n_);
            bool? p_ = context.Operators.Equal(o_, "completed");

            object q_() {

                bool ai_() {
                    DataType am_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlDateTime;
                    return ao_;
                }


                bool aj_() {
                    DataType ap_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlInterval<CqlDateTime>;
                    return ar_;
                }


                bool ak_() {
                    DataType as_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlQuantity;
                    return au_;
                }


                bool al_() {
                    DataType av_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    bool ax_ = aw_ is CqlInterval<CqlQuantity>;
                    return ax_;
                }

                if (ai_())
                {
                    DataType ay_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    return (az_ as CqlDateTime) as object;
                }
                else if (aj_())
                {
                    DataType ba_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    return (bb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ak_())
                {
                    DataType bc_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    return (bd_ as CqlQuantity) as object;
                }
                else if (al_())
                {
                    DataType be_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    return (bf_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_());
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlInterval<CqlDateTime> t_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDateTime w_ = context.Operators.Start(t_);
            CqlQuantity x_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime y_ = context.Operators.Add(w_, x_);
            CqlInterval<CqlDateTime> z_ = context.Operators.Interval(u_, y_, true, true);
            bool? aa_ = context.Operators.In<CqlDateTime>(s_, z_, (string)default);
            bool? ab_ = context.Operators.And(p_, aa_);

            object ac_() {

                bool bg_() {
                    DataType bk_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlDateTime;
                    return bm_;
                }


                bool bh_() {
                    DataType bn_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                    return bp_;
                }


                bool bi_() {
                    DataType bq_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool bs_ = br_ is CqlQuantity;
                    return bs_;
                }


                bool bj_() {
                    DataType bt_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    bool bv_ = bu_ is CqlInterval<CqlQuantity>;
                    return bv_;
                }

                if (bg_())
                {
                    DataType bw_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    return (bx_ as CqlDateTime) as object;
                }
                else if (bh_())
                {
                    DataType by_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    return (bz_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bi_())
                {
                    DataType ca_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    return (cb_ as CqlQuantity) as object;
                }
                else if (bj_())
                {
                    DataType cc_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    return (cd_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_());
            CqlDateTime ae_ = context.Operators.Start(ad_);
            bool? ag_ = context.Operators.In<CqlDateTime>(ae_, t_, (string)default);
            bool? ah_ = context.Operators.And(ab_, ag_);
            return ah_;
        }

        IEnumerable<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?> h_ = context.Operators.Where<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? tuple_bwwsxdxsfijqjjncdevjkzegj) => tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        return k_;
    }


    [CqlExpressionDefinition("Serum Creatinine Normal")]
    public CqlQuantity Serum_Creatinine_Normal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Serum_Creatinine_Normal, Serum_Creatinine_Normal_Compute);

    private const long _cacheIndex_Serum_Creatinine_Normal = 1994579657868827614L;

    private CqlQuantity Serum_Creatinine_Normal_Compute(CqlContext context)
    {

        CqlQuantity a_() {

            bool b_() {

                List<Extension> c_() {

                    bool l_() {
                        Patient m_ = this.Patient(context);
                        bool n_ = m_ is DomainResource;
                        return n_;
                    }

                    if (l_())
                    {
                        Patient o_ = this.Patient(context);
                        return (o_ as DomainResource).Extension;
                    }
                    else
                    {
                        return default;
                    };
                }


                bool? d_(Extension @this) {
                    FhirUri p_ = @this?.UrlElement;
                    string q_ = FHIRHelpers_4_4_000.Instance.ToString(context, p_);
                    bool? r_ = context.Operators.Equal(q_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                    return r_;
                }

                IEnumerable<Extension> e_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(c_()), d_);

                DataType f_(Extension @this) {
                    DataType s_ = @this?.Value;
                    return s_;
                }

                IEnumerable<DataType> g_ = context.Operators.Select<Extension, DataType>(e_, f_);
                DataType h_ = context.Operators.SingletonFrom<DataType>(g_);
                CqlCode i_ = this.Female__finding_(context);
                string j_ = i_?.code;
                bool? k_ = context.Operators.Equal(h_, j_);
                return k_ ?? false;
            }

            if (b_())
            {
                CqlQuantity t_ = context.Operators.Quantity(1.02m, "mg/dL");
                return t_;
            }
            else
            {
                CqlQuantity u_ = context.Operators.Quantity(1.18m, "mg/dL");
                return u_;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("highestSerumCreatinineResult")]
    public CqlQuantity highestSerumCreatinineResult(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_By_Time(context);

        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests) {
            string i_ = LabTests?.CrEncInPtId;
            string j_ = (QualifyingEncounter is Resource
                ? (QualifyingEncounter as Resource).IdElement
                : default)?.Value;
            bool? k_ = context.Operators.Equal(i_, j_);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity l_ = @this?.CrLabResult;
            bool? m_ = context.Operators.Not((bool?)(l_ is null));
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> e_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(c_, d_);

        CqlQuantity f_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity n_ = @this?.CrLabResult;
            return n_;
        }

        IEnumerable<CqlQuantity> g_ = context.Operators.Select<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(e_, f_);
        CqlQuantity h_ = context.Operators.Max<CqlQuantity>(g_);
        return h_;
    }


    [CqlFunctionDefinition("oneAndAHalfIncreaseInCreatinine")]
    public CqlQuantity oneAndAHalfIncreaseInCreatinine(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlQuantity a_ = this.highestSerumCreatinineResult(context, QualifyingEncounter);
        CqlQuantity b_ = context.Operators.ConvertDecimalToQuantity(1.5m);
        CqlQuantity c_ = context.Operators.Divide(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With 1.5 Times Serum Creatinine Increase")]
    public IEnumerable<Encounter> Encounter_With_1_5_Times_Serum_Creatinine_Increase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_1_5_Times_Serum_Creatinine_Increase, Encounter_With_1_5_Times_Serum_Creatinine_Increase_Compute);

    private const long _cacheIndex_Encounter_With_1_5_Times_Serum_Creatinine_Increase = -6312891358147650542L;

    private IEnumerable<Encounter> Encounter_With_1_5_Times_Serum_Creatinine_Increase_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> f_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, c_, e_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? g_(ValueTuple<Encounter, Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? n_ = (CqlTupleMetadata_JeYVEdgebecHQGRICIKegVBi, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return n_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?> h_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?>(f_, g_);

        bool? i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_gsqsgqbihalobloqrcccgdeiw) {
            DataType o_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Value;
            object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            CqlQuantity q_ = this.Serum_Creatinine_Normal(context);
            bool? r_ = context.Operators.Greater(p_ as CqlQuantity, q_);
            Code<ObservationStatus> s_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.StatusElement;
            ObservationStatus? t_ = s_?.Value;
            string u_ = context.Operators.Convert<string>(t_);
            string[] v_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? w_ = context.Operators.In<string>(u_, (IEnumerable<string>)v_);
            bool? x_ = context.Operators.And(r_, w_);
            Code<ObservationStatus> y_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.StatusElement;
            ObservationStatus? z_ = y_?.Value;
            string aa_ = context.Operators.Convert<string>(z_);
            bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)v_);
            bool? ad_ = context.Operators.And(x_, ac_);
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            CqlQuantity ag_ = this.highestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            bool? ah_ = context.Operators.Equal(af_ as CqlQuantity, ag_);
            bool? ai_ = context.Operators.And(ad_, ah_);
            DataType aj_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Value;
            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            CqlQuantity al_ = this.lowestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            bool? am_ = context.Operators.Equal(ak_ as CqlQuantity, al_);
            bool? an_ = context.Operators.And(ai_, am_);
            CqlQuantity ao_ = this.oneAndAHalfIncreaseInCreatinine(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            bool? ar_ = context.Operators.GreaterOrEqual(ao_, aq_ as CqlQuantity);
            bool? as_ = context.Operators.And(an_, ar_);

            object at_() {

                bool cf_() {
                    DataType ci_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bool ck_ = cj_ is CqlDateTime;
                    return ck_;
                }


                bool cg_() {
                    DataType cl_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    bool cn_ = cm_ is CqlInterval<CqlDateTime>;
                    return cn_;
                }


                bool ch_() {
                    DataType co_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                    bool cq_ = cp_ is CqlDateTime;
                    return cq_;
                }

                if (cf_())
                {
                    DataType cr_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    return (cs_ as CqlDateTime) as object;
                }
                else if (cg_())
                {
                    DataType ct_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    return (cu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ch_())
                {
                    DataType cv_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    return (cw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime au_ = QICoreCommon_4_0_000.Instance.earliest(context, at_());

            object av_() {

                bool cx_() {
                    DataType da_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    bool dc_ = db_ is CqlDateTime;
                    return dc_;
                }


                bool cy_() {
                    DataType dd_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    bool df_ = de_ is CqlInterval<CqlDateTime>;
                    return df_;
                }


                bool cz_() {
                    DataType dg_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                    bool di_ = dh_ is CqlDateTime;
                    return di_;
                }

                if (cx_())
                {
                    DataType dj_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                    return (dk_ as CqlDateTime) as object;
                }
                else if (cy_())
                {
                    DataType dl_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    return (dm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cz_())
                {
                    DataType dn_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    return (do_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime aw_ = QICoreCommon_4_0_000.Instance.earliest(context, av_());
            CqlQuantity ax_ = context.Operators.Quantity(7m, "days");
            CqlDateTime ay_ = context.Operators.Subtract(aw_, ax_);

            object az_() {

                bool dp_() {
                    DataType ds_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    bool du_ = dt_ is CqlDateTime;
                    return du_;
                }


                bool dq_() {
                    DataType dv_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    bool dx_ = dw_ is CqlInterval<CqlDateTime>;
                    return dx_;
                }


                bool dr_() {
                    DataType dy_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    bool ea_ = dz_ is CqlDateTime;
                    return ea_;
                }

                if (dp_())
                {
                    DataType eb_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                    return (ec_ as CqlDateTime) as object;
                }
                else if (dq_())
                {
                    DataType ed_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                    return (ee_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dr_())
                {
                    DataType ef_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                    return (eg_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime ba_ = QICoreCommon_4_0_000.Instance.earliest(context, az_());
            CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(ay_, ba_, true, false);
            bool? bc_ = context.Operators.In<CqlDateTime>(au_, bb_, (string)default);

            object bd_() {

                bool eh_() {
                    DataType ek_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    bool em_ = el_ is CqlDateTime;
                    return em_;
                }


                bool ei_() {
                    DataType en_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    bool ep_ = eo_ is CqlInterval<CqlDateTime>;
                    return ep_;
                }


                bool ej_() {
                    DataType eq_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    bool es_ = er_ is CqlDateTime;
                    return es_;
                }

                if (eh_())
                {
                    DataType et_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    return (eu_ as CqlDateTime) as object;
                }
                else if (ei_())
                {
                    DataType ev_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    return (ew_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ej_())
                {
                    DataType ex_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    return (ey_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime be_ = QICoreCommon_4_0_000.Instance.earliest(context, bd_());
            bool? bf_ = context.Operators.Not((bool?)(be_ is null));
            bool? bg_ = context.Operators.And(bc_, bf_);
            bool? bh_ = context.Operators.And(as_, bg_);

            object bi_() {

                bool ez_() {
                    DataType fc_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                    bool fe_ = fd_ is CqlDateTime;
                    return fe_;
                }


                bool fa_() {
                    DataType ff_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                    bool fh_ = fg_ is CqlInterval<CqlDateTime>;
                    return fh_;
                }


                bool fb_() {
                    DataType fi_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    bool fk_ = fj_ is CqlDateTime;
                    return fk_;
                }

                if (ez_())
                {
                    DataType fl_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    return (fm_ as CqlDateTime) as object;
                }
                else if (fa_())
                {
                    DataType fn_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    return (fo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fb_())
                {
                    DataType fp_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    return (fq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_());
            CqlInterval<CqlDateTime> bk_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            bool? bl_ = context.Operators.In<CqlDateTime>(bj_, bk_, (string)default);
            bool? bm_ = context.Operators.And(bh_, bl_);

            object bn_() {

                bool fr_() {
                    DataType fu_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                    bool fw_ = fv_ is CqlDateTime;
                    return fw_;
                }


                bool fs_() {
                    DataType fx_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);
                    bool fz_ = fy_ is CqlInterval<CqlDateTime>;
                    return fz_;
                }


                bool ft_() {
                    DataType ga_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
                    bool gc_ = gb_ is CqlDateTime;
                    return gc_;
                }

                if (fr_())
                {
                    DataType gd_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                    return (ge_ as CqlDateTime) as object;
                }
                else if (fs_())
                {
                    DataType gf_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gf_);
                    return (gg_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ft_())
                {
                    DataType gh_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gh_);
                    return (gi_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime bo_ = QICoreCommon_4_0_000.Instance.earliest(context, bn_());
            CqlDateTime bq_ = context.Operators.Start(bk_);
            CqlQuantity br_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime bs_ = context.Operators.Add(bq_, br_);
            CqlDateTime bu_ = context.Operators.Start(bk_);
            CqlQuantity bv_ = context.Operators.Quantity(30m, "days");
            CqlDateTime bw_ = context.Operators.Add(bu_, bv_);
            CqlInterval<CqlDateTime> bx_ = context.Operators.Interval(bs_, bw_, true, true);
            bool? by_ = context.Operators.In<CqlDateTime>(bo_, bx_, (string)default);
            bool? bz_ = context.Operators.And(bm_, by_);

            object ca_() {

                bool gj_() {
                    DataType gm_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                    bool go_ = gn_ is CqlDateTime;
                    return go_;
                }


                bool gk_() {
                    DataType gp_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                    bool gr_ = gq_ is CqlInterval<CqlDateTime>;
                    return gr_;
                }


                bool gl_() {
                    DataType gs_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                    bool gu_ = gt_ is CqlDateTime;
                    return gu_;
                }

                if (gj_())
                {
                    DataType gv_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
                    return (gw_ as CqlDateTime) as object;
                }
                else if (gk_())
                {
                    DataType gx_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                    return (gy_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gl_())
                {
                    DataType gz_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object ha_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gz_);
                    return (ha_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime cb_ = QICoreCommon_4_0_000.Instance.earliest(context, ca_());
            bool? cd_ = context.Operators.In<CqlDateTime>(cb_, bk_, (string)default);
            bool? ce_ = context.Operators.And(bz_, cd_);
            return ce_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?> j_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?>(h_, i_);
        Encounter k_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_gsqsgqbihalobloqrcccgdeiw) => tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter;
        IEnumerable<Encounter> l_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?, Encounter>(j_, k_);
        IEnumerable<Encounter> m_ = context.Operators.Distinct<Encounter>(l_);
        return m_;
    }


    [CqlExpressionDefinition("Encounter With 2 Times Serum Creatinine Increase")]
    public IEnumerable<Encounter> Encounter_With_2_Times_Serum_Creatinine_Increase(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_2_Times_Serum_Creatinine_Increase, Encounter_With_2_Times_Serum_Creatinine_Increase_Compute);

    private const long _cacheIndex_Encounter_With_2_Times_Serum_Creatinine_Increase = 6729776291179105209L;

    private IEnumerable<Encounter> Encounter_With_2_Times_Serum_Creatinine_Increase_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_1_5_Times_Serum_Creatinine_Increase(context);
        CqlValueSet b_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> f_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, c_, e_);

        (CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? g_(ValueTuple<Encounter, Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? n_ = (CqlTupleMetadata_BDjSiZCAhXcVgEETFRJVEHXOR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return n_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?> h_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?>(f_, g_);

        bool? i_((CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_bdjsizcahxcvgeetfrjvehxor) {
            DataType o_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Value;
            object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            CqlQuantity q_ = this.Serum_Creatinine_Normal(context);
            bool? r_ = context.Operators.Greater(p_ as CqlQuantity, q_);
            Code<ObservationStatus> s_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.StatusElement;
            ObservationStatus? t_ = s_?.Value;
            string u_ = context.Operators.Convert<string>(t_);
            string[] v_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? w_ = context.Operators.In<string>(u_, (IEnumerable<string>)v_);
            bool? x_ = context.Operators.And(r_, w_);
            Code<ObservationStatus> y_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.StatusElement;
            ObservationStatus? z_ = y_?.Value;
            string aa_ = context.Operators.Convert<string>(z_);
            bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)v_);
            bool? ad_ = context.Operators.And(x_, ac_);
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            CqlQuantity ag_ = this.highestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            bool? ah_ = context.Operators.Equal(af_ as CqlQuantity, ag_);
            bool? ai_ = context.Operators.And(ad_, ah_);
            DataType aj_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Value;
            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            CqlQuantity al_ = this.lowestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            bool? am_ = context.Operators.Equal(ak_ as CqlQuantity, al_);
            bool? an_ = context.Operators.And(ai_, am_);
            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            bool? as_ = context.Operators.GreaterOrEqual(ap_ as CqlQuantity, ar_ as CqlQuantity);
            bool? at_ = context.Operators.And(an_, as_);

            object au_() {

                bool cg_() {
                    DataType cj_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlDateTime;
                    return cl_;
                }


                bool ch_() {
                    DataType cm_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    bool co_ = cn_ is CqlInterval<CqlDateTime>;
                    return co_;
                }


                bool ci_() {
                    DataType cp_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    bool cr_ = cq_ is CqlDateTime;
                    return cr_;
                }

                if (cg_())
                {
                    DataType cs_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                    return (ct_ as CqlDateTime) as object;
                }
                else if (ch_())
                {
                    DataType cu_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                    return (cv_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ci_())
                {
                    DataType cw_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                    return (cx_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime av_ = QICoreCommon_4_0_000.Instance.earliest(context, au_());

            object aw_() {

                bool cy_() {
                    DataType db_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlDateTime;
                    return dd_;
                }


                bool cz_() {
                    DataType de_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    bool dg_ = df_ is CqlInterval<CqlDateTime>;
                    return dg_;
                }


                bool da_() {
                    DataType dh_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                    bool dj_ = di_ is CqlDateTime;
                    return dj_;
                }

                if (cy_())
                {
                    DataType dk_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                    return (dl_ as CqlDateTime) as object;
                }
                else if (cz_())
                {
                    DataType dm_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                    return (dn_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (da_())
                {
                    DataType do_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                    return (dp_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime ax_ = QICoreCommon_4_0_000.Instance.earliest(context, aw_());
            CqlQuantity ay_ = context.Operators.Quantity(7m, "days");
            CqlDateTime az_ = context.Operators.Subtract(ax_, ay_);

            object ba_() {

                bool dq_() {
                    DataType dt_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    bool dv_ = du_ is CqlDateTime;
                    return dv_;
                }


                bool dr_() {
                    DataType dw_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    bool dy_ = dx_ is CqlInterval<CqlDateTime>;
                    return dy_;
                }


                bool ds_() {
                    DataType dz_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                    bool eb_ = ea_ is CqlDateTime;
                    return eb_;
                }

                if (dq_())
                {
                    DataType ec_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                    return (ed_ as CqlDateTime) as object;
                }
                else if (dr_())
                {
                    DataType ee_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                    return (ef_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ds_())
                {
                    DataType eg_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                    return (eh_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_());
            CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(az_, bb_, true, false);
            bool? bd_ = context.Operators.In<CqlDateTime>(av_, bc_, (string)default);

            object be_() {

                bool ei_() {
                    DataType el_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    bool en_ = em_ is CqlDateTime;
                    return en_;
                }


                bool ej_() {
                    DataType eo_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                    bool eq_ = ep_ is CqlInterval<CqlDateTime>;
                    return eq_;
                }


                bool ek_() {
                    DataType er_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    bool et_ = es_ is CqlDateTime;
                    return et_;
                }

                if (ei_())
                {
                    DataType eu_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                    return (ev_ as CqlDateTime) as object;
                }
                else if (ej_())
                {
                    DataType ew_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                    return (ex_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ek_())
                {
                    DataType ey_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                    return (ez_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_());
            bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
            bool? bh_ = context.Operators.And(bd_, bg_);
            bool? bi_ = context.Operators.And(at_, bh_);

            object bj_() {

                bool fa_() {
                    DataType fd_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                    bool ff_ = fe_ is CqlDateTime;
                    return ff_;
                }


                bool fb_() {
                    DataType fg_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                    bool fi_ = fh_ is CqlInterval<CqlDateTime>;
                    return fi_;
                }


                bool fc_() {
                    DataType fj_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                    bool fl_ = fk_ is CqlDateTime;
                    return fl_;
                }

                if (fa_())
                {
                    DataType fm_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                    return (fn_ as CqlDateTime) as object;
                }
                else if (fb_())
                {
                    DataType fo_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                    return (fp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fc_())
                {
                    DataType fq_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                    return (fr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime bk_ = QICoreCommon_4_0_000.Instance.earliest(context, bj_());
            CqlInterval<CqlDateTime> bl_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            bool? bm_ = context.Operators.In<CqlDateTime>(bk_, bl_, (string)default);
            bool? bn_ = context.Operators.And(bi_, bm_);

            object bo_() {

                bool fs_() {
                    DataType fv_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                    bool fx_ = fw_ is CqlDateTime;
                    return fx_;
                }


                bool ft_() {
                    DataType fy_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                    bool ga_ = fz_ is CqlInterval<CqlDateTime>;
                    return ga_;
                }


                bool fu_() {
                    DataType gb_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
                    bool gd_ = gc_ is CqlDateTime;
                    return gd_;
                }

                if (fs_())
                {
                    DataType ge_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                    return (gf_ as CqlDateTime) as object;
                }
                else if (ft_())
                {
                    DataType gg_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                    return (gh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fu_())
                {
                    DataType gi_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gi_);
                    return (gj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime bp_ = QICoreCommon_4_0_000.Instance.earliest(context, bo_());
            CqlDateTime br_ = context.Operators.Start(bl_);
            CqlQuantity bs_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime bt_ = context.Operators.Add(br_, bs_);
            CqlDateTime bv_ = context.Operators.Start(bl_);
            CqlQuantity bw_ = context.Operators.Quantity(30m, "days");
            CqlDateTime bx_ = context.Operators.Add(bv_, bw_);
            CqlInterval<CqlDateTime> by_ = context.Operators.Interval(bt_, bx_, true, true);
            bool? bz_ = context.Operators.In<CqlDateTime>(bp_, by_, (string)default);
            bool? ca_ = context.Operators.And(bn_, bz_);

            object cb_() {

                bool gk_() {
                    DataType gn_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                    bool gp_ = go_ is CqlDateTime;
                    return gp_;
                }


                bool gl_() {
                    DataType gq_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gq_);
                    bool gs_ = gr_ is CqlInterval<CqlDateTime>;
                    return gs_;
                }


                bool gm_() {
                    DataType gt_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gt_);
                    bool gv_ = gu_ is CqlDateTime;
                    return gv_;
                }

                if (gk_())
                {
                    DataType gw_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gw_);
                    return (gx_ as CqlDateTime) as object;
                }
                else if (gl_())
                {
                    DataType gy_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gy_);
                    return (gz_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gm_())
                {
                    DataType ha_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object hb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ha_);
                    return (hb_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime cc_ = QICoreCommon_4_0_000.Instance.earliest(context, cb_());
            bool? ce_ = context.Operators.In<CqlDateTime>(cc_, bl_, (string)default);
            bool? cf_ = context.Operators.And(ca_, ce_);
            return cf_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?> j_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?>(h_, i_);
        Encounter k_((CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_bdjsizcahxcvgeetfrjvehxor) => tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine;
        IEnumerable<Encounter> l_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?, Encounter>(j_, k_);
        IEnumerable<Encounter> m_ = context.Operators.Distinct<Encounter>(l_);
        return m_;
    }


    [CqlExpressionDefinition("Encounter With Kidney Dialysis Started 48 Hours Or Less After Arrival Without High Creatinine")]
    public IEnumerable<Encounter> Encounter_With_Kidney_Dialysis_Started_48_Hours_Or_Less_After_Arrival_Without_High_Creatinine(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Kidney_Dialysis_Started_48_Hours_Or_Less_After_Arrival_Without_High_Creatinine, Encounter_With_Kidney_Dialysis_Started_48_Hours_Or_Less_After_Arrival_Without_High_Creatinine_Compute);

    private const long _cacheIndex_Encounter_With_Kidney_Dialysis_Started_48_Hours_Or_Less_After_Arrival_Without_High_Creatinine = 4951173981199154811L;

    private IEnumerable<Encounter> Encounter_With_Kidney_Dialysis_Started_48_Hours_Or_Less_After_Arrival_Without_High_Creatinine_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Kidney_Dialysis_Started_48_Hours_Or_Less_After_Arrival(context);

        bool? b_(Encounter EncounterWithKidneyDialysis48HoursOrAfter) {
            IEnumerable<Encounter> d_ = this.Encounter_With_2_Times_Serum_Creatinine_Increase(context);

            bool? e_(Encounter EncounterWithHighCreatinine) {
                Period i_ = EncounterWithHighCreatinine?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                Period k_ = EncounterWithKidneyDialysis48HoursOrAfter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, (string)default);
                return m_;
            }

            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            bool? g_ = context.Operators.Exists<Encounter>(f_);
            bool? h_ = context.Operators.Not(g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With High Risk Diagnosis For AKI")]
    public IEnumerable<Encounter> Encounter_With_High_Risk_Diagnosis_For_AKI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_High_Risk_Diagnosis_For_AKI, Encounter_With_High_Risk_Diagnosis_For_AKI_Compute);

    private const long _cacheIndex_Encounter_With_High_Risk_Diagnosis_For_AKI = 2182905656572145703L;

    private IEnumerable<Encounter> Encounter_With_High_Risk_Diagnosis_For_AKI_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);

        bool? b_(Encounter QualifyingEncounter) {
            List<CodeableConcept> d_ = QualifyingEncounter?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.High_Risk_Diagnosis_for_AKI(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? j_(Condition @this) {
                CodeableConcept r_ = @this?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                bool? t_ = context.Operators.Not((bool?)(s_ is null));
                return t_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);

            CqlConcept l_(Condition @this) {
                CodeableConcept u_ = @this?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                return v_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<Condition, CqlConcept>(k_, l_);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? p_ = context.Operators.Or(h_, o_);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With High Risk Procedures For AKI")]
    public IEnumerable<Encounter> Encounter_With_High_Risk_Procedures_For_AKI(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_High_Risk_Procedures_For_AKI, Encounter_With_High_Risk_Procedures_For_AKI_Compute);

    private const long _cacheIndex_Encounter_With_High_Risk_Procedures_For_AKI = -443404941640326203L;

    private IEnumerable<Encounter> Encounter_With_High_Risk_Procedures_For_AKI_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);

        IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
            CqlValueSet d_ = this.High_Risk_Procedures_for_AKI(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure HighRiskProcedures) {
                Code<EventStatus> j_ = HighRiskProcedures?.StatusElement;
                EventStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "completed");

                object n_() {

                    bool t_() {
                        DataType x_ = HighRiskProcedures?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlDateTime;
                        return z_;
                    }


                    bool u_() {
                        DataType aa_ = HighRiskProcedures?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        return ac_;
                    }


                    bool v_() {
                        DataType ad_ = HighRiskProcedures?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlQuantity;
                        return af_;
                    }


                    bool w_() {
                        DataType ag_ = HighRiskProcedures?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                        return ai_;
                    }

                    if (t_())
                    {
                        DataType aj_ = HighRiskProcedures?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        return (ak_ as CqlDateTime) as object;
                    }
                    else if (u_())
                    {
                        DataType al_ = HighRiskProcedures?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        return (am_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (v_())
                    {
                        DataType an_ = HighRiskProcedures?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        return (ao_ as CqlQuantity) as object;
                    }
                    else if (w_())
                    {
                        DataType ap_ = HighRiskProcedures?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return (aq_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_());
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlInterval<CqlDateTime> q_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, (string)default);
                bool? s_ = context.Operators.And(m_, r_);
                return s_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure HighRiskProcedures) => QualifyingEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusion, Denominator_Exclusion_Compute);

    private const long _cacheIndex_Denominator_Exclusion = -6920362668091830886L;

    private IEnumerable<Encounter> Denominator_Exclusion_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Less_Than_2_Creatinine_Results_Within_48_Hours_Of_Arrival(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Index_eGFR_Less_Than_60_Within_First_48_Hours(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_With_0_3_mg_dL_Or_More_Increase_In_Creatinine(context);
        IEnumerable<Encounter> e_ = this.Encounter_With_Kidney_Dialysis_Started_48_Hours_Or_Less_After_Arrival_Without_High_Creatinine(context);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        IEnumerable<Encounter> h_ = this.Encounter_With_High_Risk_Diagnosis_For_AKI(context);
        IEnumerable<Encounter> i_ = this.Encounter_With_High_Risk_Procedures_For_AKI(context);
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(g_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Encounter With Kidney Dialysis Started More Than 48 Hours After Arrival")]
    public IEnumerable<Encounter> Encounter_With_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival, Encounter_With_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival_Compute);

    private const long _cacheIndex_Encounter_With_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival = -2640674106632919971L;

    private IEnumerable<Encounter> Encounter_With_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hospital_Based_Dialysis_Services(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Encounter> c_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);
        IEnumerable<ValueTuple<Procedure, Encounter>> d_ = context.Operators.CrossJoin<Procedure, Encounter>(b_, c_);

        (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? e_(ValueTuple<Procedure, Encounter> _valueTuple) {
            (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? l_ = (CqlTupleMetadata_BWWSXdXSFIJQjJNcdEVJKZEGj, _valueTuple.Item1, _valueTuple.Item2);
            return l_;
        }

        IEnumerable<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?> f_ = context.Operators.Select<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?>(d_, e_);

        bool? g_((CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? tuple_bwwsxdxsfijqjjncdevjkzegj) {

            object m_() {

                bool ai_() {
                    DataType am_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlDateTime;
                    return ao_;
                }


                bool aj_() {
                    DataType ap_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlInterval<CqlDateTime>;
                    return ar_;
                }


                bool ak_() {
                    DataType as_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlQuantity;
                    return au_;
                }


                bool al_() {
                    DataType av_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    bool ax_ = aw_ is CqlInterval<CqlQuantity>;
                    return ax_;
                }

                if (ai_())
                {
                    DataType ay_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    return (az_ as CqlDateTime) as object;
                }
                else if (aj_())
                {
                    DataType ba_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    return (bb_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ak_())
                {
                    DataType bc_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    return (bd_ as CqlQuantity) as object;
                }
                else if (al_())
                {
                    DataType be_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    return (bf_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_());
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlQuantity r_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime s_ = context.Operators.Add(q_, r_);
            CqlDateTime u_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> v_ = context.Operators.Interval(s_, u_, true, true);
            bool? w_ = context.Operators.In<CqlDateTime>(o_, v_, (string)default);

            object x_() {

                bool bg_() {
                    DataType bk_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlDateTime;
                    return bm_;
                }


                bool bh_() {
                    DataType bn_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                    return bp_;
                }


                bool bi_() {
                    DataType bq_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool bs_ = br_ is CqlQuantity;
                    return bs_;
                }


                bool bj_() {
                    DataType bt_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    bool bv_ = bu_ is CqlInterval<CqlQuantity>;
                    return bv_;
                }

                if (bg_())
                {
                    DataType bw_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    return (bx_ as CqlDateTime) as object;
                }
                else if (bh_())
                {
                    DataType by_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    return (bz_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bi_())
                {
                    DataType ca_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    return (cb_ as CqlQuantity) as object;
                }
                else if (bj_())
                {
                    DataType cc_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    return (cd_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_());
            CqlDateTime z_ = context.Operators.Start(y_);
            bool? ab_ = context.Operators.In<CqlDateTime>(z_, p_, (string)default);
            bool? ac_ = context.Operators.And(w_, ab_);
            Code<EventStatus> ad_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.StatusElement;
            EventStatus? ae_ = ad_?.Value;
            string af_ = context.Operators.Convert<string>(ae_);
            bool? ag_ = context.Operators.Equal(af_, "completed");
            bool? ah_ = context.Operators.And(ac_, ag_);
            return ah_;
        }

        IEnumerable<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?> h_ = context.Operators.Where<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? tuple_bwwsxdxsfijqjjncdevjkzegj) => tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        return k_;
    }


    [CqlExpressionDefinition("Encounter With Kidney Dialysis Started More Than 48 Hours After Arrival Without High Creatinine")]
    public IEnumerable<Encounter> Encounter_With_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival_Without_High_Creatinine(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival_Without_High_Creatinine, Encounter_With_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival_Without_High_Creatinine_Compute);

    private const long _cacheIndex_Encounter_With_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival_Without_High_Creatinine = -4888735935432673347L;

    private IEnumerable<Encounter> Encounter_With_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival_Without_High_Creatinine_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival(context);

        bool? b_(Encounter EncounterWithDialysisAfter48Hours) {
            IEnumerable<Encounter> d_ = this.Encounter_With_2_Times_Serum_Creatinine_Increase(context);

            bool? e_(Encounter EncounterWithHighCreatinine) {
                Period i_ = EncounterWithHighCreatinine?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                Period k_ = EncounterWithDialysisAfter48Hours?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, (string)default);
                return m_;
            }

            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            bool? g_ = context.Operators.Exists<Encounter>(f_);
            bool? h_ = context.Operators.Not(g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 3185117250578503100L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_2_Times_Serum_Creatinine_Increase(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival_Without_High_Creatinine(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Qualifying Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Blood_Pressure_Reading(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Blood_Pressure_Reading, Qualifying_Blood_Pressure_Reading_Compute);

    private const long _cacheIndex_Qualifying_Blood_Pressure_Reading = 5209928719679475424L;

    private IEnumerable<Observation> Qualifying_Blood_Pressure_Reading_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));

        bool? b_(Observation BloodPressure) {
            DataType d_ = BloodPressure?.Effective;
            object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            CqlDateTime f_ = QICoreCommon_4_0_000.Instance.earliest(context, e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            bool? h_ = context.Operators.In<CqlDateTime>(f_, g_, "day");
            return h_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Estimated Glomerular Filtration Rate For Females")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Females(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Females, Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Females_Compute);

    private const long _cacheIndex_Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Females = -223549146266594370L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Females_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);

        (CqlTupleMetadata, string encounterId, decimal? eGFR)? b_(Encounter QualifyingEncounter) {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            decimal? g_ = this.femaleeGFR(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, decimal? eGFR)? h_ = (CqlTupleMetadata_ChQZQhiCBOOJUfBhSOMPAPSKY, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, decimal? eGFR)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, decimal? eGFR)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Risk Variable Estimated Glomerular Filtration Rate For Males")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Males(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Males, Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Males_Compute);

    private const long _cacheIndex_Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Males = -5465086837107700678L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Males_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);

        (CqlTupleMetadata, string encounterId, decimal? eGFR)? b_(Encounter QualifyingEncounter) {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            decimal? g_ = this.maleeGFR(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, decimal? eGFR)? h_ = (CqlTupleMetadata_ChQZQhiCBOOJUfBhSOMPAPSKY, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, decimal? eGFR)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, decimal? eGFR)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Diagnoses With POA Indication")]
    public IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?> Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication, Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication_Compute);

    private const long _cacheIndex_Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication = 8820377778411613437L;

    private IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?> Risk_Variable_All_Encounter_Diagnoses_With_POA_Indication_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);
        IEnumerable<Claim> b_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
        IEnumerable<ValueTuple<Encounter, Claim>> c_ = context.Operators.CrossJoin<Encounter, Claim>(a_, b_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? d_(ValueTuple<Encounter, Claim> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? k_ = (CqlTupleMetadata_CUCPZLPbWZQEUULVJBALOjJbh, _valueTuple.Item1, _valueTuple.Item2);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?> e_ = context.Operators.Select<ValueTuple<Encounter, Claim>, (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?>(c_, d_);

        bool? f_((CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? tuple_epwvnljjfhnvfarkifgamtzks) {
            Code<FinancialResourceStatusCodes> l_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.StatusElement;
            FinancialResourceStatusCodes? m_ = l_?.Value;
            Code<FinancialResourceStatusCodes> n_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(m_);
            bool? o_ = context.Operators.Equal(n_, "active");
            Code<ClaimUseCode> p_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.UseElement;
            ClaimUseCode? q_ = p_?.Value;
            Code<ClaimUseCode> r_ = context.Operators.Convert<Code<ClaimUseCode>>(q_);
            bool? s_ = context.Operators.Equal(r_, "claim");
            bool? t_ = context.Operators.And(o_, s_);
            List<Claim.ItemComponent> u_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Item;

            bool? v_(Claim.ItemComponent ClaimItem) {
                List<ResourceReference> z_ = ClaimItem?.Encounter;
                bool? aa_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)z_, tuple_epwvnljjfhnvfarkifgamtzks?.QualifyingEncounter);
                List<Claim.DiagnosisComponent> ab_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Diagnosis;

                bool? ac_(Claim.DiagnosisComponent Dx) {
                    PositiveInt ag_ = Dx?.SequenceElement;
                    int? ah_ = ag_?.Value;
                    List<Claim.ItemComponent> ai_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Item;

                    bool? aj_(Claim.ItemComponent @this) {
                        List<PositiveInt> au_ = @this?.DiagnosisSequenceElement;

                        int? av_(PositiveInt @this) {
                            int? ay_ = @this?.Value;
                            return ay_;
                        }

                        IEnumerable<int?> aw_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)au_, av_);
                        bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
                        return ax_;
                    }

                    IEnumerable<Claim.ItemComponent> ak_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ai_, aj_);

                    IEnumerable<int?> al_(Claim.ItemComponent @this) {
                        List<PositiveInt> az_ = @this?.DiagnosisSequenceElement;

                        int? ba_(PositiveInt @this) {
                            int? bc_ = @this?.Value;
                            return bc_;
                        }

                        IEnumerable<int?> bb_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)az_, ba_);
                        return bb_;
                    }

                    IEnumerable<IEnumerable<int?>> am_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(ak_, al_);
                    IEnumerable<int?> an_ = context.Operators.Flatten<int?>(am_);
                    bool? ao_ = context.Operators.In<int?>(ah_, an_);
                    CodeableConcept ap_ = Dx?.OnAdmission;
                    CqlConcept aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ap_);
                    CqlValueSet ar_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                    bool? as_ = context.Operators.ConceptInValueSet(aq_, ar_);
                    bool? at_ = context.Operators.And(ao_, as_);
                    return at_;
                }

                IEnumerable<Claim.DiagnosisComponent> ad_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)ab_, ac_);
                bool? ae_ = context.Operators.Exists<Claim.DiagnosisComponent>(ad_);
                bool? af_ = context.Operators.And(aa_, ae_);
                return af_;
            }

            IEnumerable<Claim.ItemComponent> w_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)u_, v_);
            bool? x_ = context.Operators.Exists<Claim.ItemComponent>(w_);
            bool? y_ = context.Operators.And(t_, x_);
            return y_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?> g_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?>(e_, f_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? h_((CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? tuple_epwvnljjfhnvfarkifgamtzks) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? bd_ = (CqlTupleMetadata_CUCPZLPbWZQEUULVJBALOjJbh, tuple_epwvnljjfhnvfarkifgamtzks?.QualifyingEncounter, tuple_epwvnljjfhnvfarkifgamtzks?.clm);
            return bd_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?> i_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?, (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?>(g_, h_);
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?>(i_);
        return j_;
    }


    [CqlFunctionDefinition("firstHeartRate")]
    public CqlQuantity firstHeartRate(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));

        bool? b_(Observation FirstHeartBeats) {
            DataType i_ = FirstHeartBeats?.Effective;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.earliest(context, j_);
            CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, (string)default);
            DataType n_ = FirstHeartBeats?.Value;
            CqlQuantity o_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, n_ as Quantity);
            bool? p_ = context.Operators.Not((bool?)(o_ is null));
            bool? q_ = context.Operators.And(m_, p_);
            return q_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, s_);
            return t_;
        }

        IEnumerable<Observation> e_ = context.Operators.SortBy<Observation>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Observation f_ = context.Operators.First<Observation>(e_);
        DataType g_ = f_?.Value;
        CqlQuantity h_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, g_ as Quantity);
        return h_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Heart Rate In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> Risk_Variable_First_Heart_Rate_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Heart_Rate_In_Encounter, Risk_Variable_First_Heart_Rate_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Heart_Rate_In_Encounter = 8808178017582391608L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> Risk_Variable_First_Heart_Rate_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)? b_(Encounter QualifyingEncounter) {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstHeartRate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)? h_ = (CqlTupleMetadata_FagZCcMXCLUWREPQINNbEKifA, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("firstRespiratoryRate")]
    public CqlQuantity firstRespiratoryRate(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-respiratory-rate"));

        bool? b_(Observation FirstRespiration) {
            DataType i_ = FirstRespiration?.Effective;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.earliest(context, j_);
            CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, (string)default);
            DataType n_ = FirstRespiration?.Value;
            CqlQuantity o_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, n_ as Quantity);
            bool? p_ = context.Operators.Not((bool?)(o_ is null));
            bool? q_ = context.Operators.And(m_, p_);
            return q_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, s_);
            return t_;
        }

        IEnumerable<Observation> e_ = context.Operators.SortBy<Observation>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Observation f_ = context.Operators.First<Observation>(e_);
        DataType g_ = f_?.Value;
        CqlQuantity h_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, g_ as Quantity);
        return h_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Respiratory Rate In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> Risk_Variable_First_Respiratory_Rate_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Respiratory_Rate_In_Encounter, Risk_Variable_First_Respiratory_Rate_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Respiratory_Rate_In_Encounter = -7817746474475188830L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> Risk_Variable_First_Respiratory_Rate_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)? b_(Encounter QualifyingEncounter) {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstRespiratoryRate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)? h_ = (CqlTupleMetadata_BWTiRIaMgaifWSHaCRbRQdjII, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("firstSystolicBloodPressure")]
    public CqlQuantity firstSystolicBloodPressure(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Blood_Pressure_Reading(context);

        bool? b_(Observation SBPReading) {
            DataType h_ = SBPReading?.Effective;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlDateTime j_ = QICoreCommon_4_0_000.Instance.earliest(context, i_);
            CqlInterval<CqlDateTime> k_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, (string)default);
            return l_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        CqlQuantity d_(Observation SBPReading) {
            List<Observation.ComponentComponent> m_ = SBPReading?.Component;

            bool? n_(Observation.ComponentComponent SBPComponent) {
                CodeableConcept t_ = SBPComponent?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                CqlCode v_ = this.Systolic_blood_pressure(context);
                CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
                bool? x_ = context.Operators.Equivalent(u_, w_);
                return x_;
            }

            IEnumerable<Observation.ComponentComponent> o_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)m_, n_);

            CqlQuantity p_(Observation.ComponentComponent SBPComponent) {
                DataType y_ = SBPComponent?.Value;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                return z_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity> q_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(o_, p_);
            IEnumerable<CqlQuantity> r_ = context.Operators.Distinct<CqlQuantity>(q_);
            CqlQuantity s_ = context.Operators.SingletonFrom<CqlQuantity>(r_);
            return s_;
        }

        IEnumerable<CqlQuantity> e_ = context.Operators.Select<Observation, CqlQuantity>(c_, d_);
        IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);
        CqlQuantity g_ = context.Operators.First<CqlQuantity>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Risk Variable First Systolic Blood Pressure In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?> Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter, Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter = -4275283378100321780L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?> Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)? b_(Encounter QualifyingEncounter) {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstSystolicBloodPressure(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)? h_ = (CqlTupleMetadata_BfHgdIQNPeXTfGHcOBiXACaRK, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("firstBodyTemperature")]
    public CqlQuantity firstBodyTemperature(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-body-temperature"));

        bool? b_(Observation FirstTemperature) {
            DataType i_ = FirstTemperature?.Effective;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.earliest(context, j_);
            CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, (string)default);
            DataType n_ = FirstTemperature?.Value;
            CqlQuantity o_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, n_ as Quantity);
            bool? p_ = context.Operators.Not((bool?)(o_ is null));
            bool? q_ = context.Operators.And(m_, p_);
            return q_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, s_);
            return t_;
        }

        IEnumerable<Observation> e_ = context.Operators.SortBy<Observation>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Observation f_ = context.Operators.First<Observation>(e_);
        DataType g_ = f_?.Value;
        CqlQuantity h_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, g_ as Quantity);
        return h_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Temperature In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)?> Risk_Variable_First_Temperature_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Temperature_In_Encounter, Risk_Variable_First_Temperature_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Temperature_In_Encounter = -7632800625997714988L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)?> Risk_Variable_First_Temperature_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)? b_(Encounter QualifyingEncounter) {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.firstBodyTemperature(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)? h_ = (CqlTupleMetadata_HjOGEZILgEFXhMPHLgWdcOTZ, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)?>(c_);
        return d_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS832FHIRHHAKI_1_0_000() {}

    public static CMS832FHIRHHAKI_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS832FHIRHHAKI";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BDjSiZCAhXcVgEETFRJVEHXOR = new(
       [typeof(Encounter), typeof(Observation), typeof(Observation)],
       ["EncounterWithHighCreatinine", "HighCreatinineTest", "LowCreatinineTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_BfHgdIQNPeXTfGHcOBiXACaRK = new(
       [typeof(string), typeof(CqlQuantity)],
       ["encounterId", "firstSystolicBP"]);

    private static CqlTupleMetadata CqlTupleMetadata_BSZZjZXQgCBZNijVbAJbPfNhP = new(
       [typeof(Encounter), typeof(Observation)],
       ["Encounter48Hours", "CreatinineTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_BWTiRIaMgaifWSHaCRbRQdjII = new(
       [typeof(string), typeof(CqlQuantity)],
       ["encounterId", "firstRespiratoryRate"]);

    private static CqlTupleMetadata CqlTupleMetadata_BWWSXdXSFIJQjJNcdEVJKZEGj = new(
       [typeof(Procedure), typeof(Encounter)],
       ["Dialysis", "QualifyingEncounter"]);

    private static CqlTupleMetadata CqlTupleMetadata_ChQZQhiCBOOJUfBhSOMPAPSKY = new(
       [typeof(string), typeof(decimal?)],
       ["encounterId", "eGFR"]);

    private static CqlTupleMetadata CqlTupleMetadata_CUCPZLPbWZQEUULVJBALOjJbh = new(
       [typeof(Encounter), typeof(Claim)],
       ["QualifyingEncounter", "clm"]);

    private static CqlTupleMetadata CqlTupleMetadata_EROdcjJjSdFbfXChfKbYbOdDN = new(
       [typeof(string), typeof(CqlInterval<CqlDateTime>), typeof(string), typeof(object), typeof(IEnumerable<CqlConcept>), typeof(string), typeof(CqlQuantity), typeof(string), typeof(decimal?), typeof(CqlDateTime), typeof(CqlDateTime)],
       ["CrEncInPtId", "CrHospitalization", "CrLabObsId", "CrLabObsCategory", "CrLabObsCategory2", "CrLabObsStatus", "CrLabResult", "CrLabResultUnit", "CrLabResultValue", "CrLabTime", "CrLabTimeIssued"]);

    private static CqlTupleMetadata CqlTupleMetadata_FagZCcMXCLUWREPQINNbEKifA = new(
       [typeof(string), typeof(CqlQuantity)],
       ["encounterId", "firstHeartRate"]);

    private static CqlTupleMetadata CqlTupleMetadata_FWVGLDcQEISFGIdVNGEWPHUFV = new(
       [typeof(Encounter), typeof(Observation), typeof(Observation)],
       ["QualifyingEncounter", "IndexCreatinineLabResult", "SubsequentCreatinineLabResult"]);

    private static CqlTupleMetadata CqlTupleMetadata_GiiGRATBZEQfMLdbZgPRgTeRJ = new(
       [typeof(Encounter), typeof(Observation)],
       ["QualifyingEncounter", "CreatinineTestByTime"]);

    private static CqlTupleMetadata CqlTupleMetadata_HjOGEZILgEFXhMPHLgWdcOTZ = new(
       [typeof(string), typeof(CqlQuantity)],
       ["encounterId", "firstTemperature"]);

    private static CqlTupleMetadata CqlTupleMetadata_JeYVEdgebecHQGRICIKegVBi = new(
       [typeof(Encounter), typeof(Observation), typeof(Observation)],
       ["QualifyingEncounter", "HighCreatinineTest", "LowCreatinineTest"]);

    #endregion CqlTupleMetadata Properties

}

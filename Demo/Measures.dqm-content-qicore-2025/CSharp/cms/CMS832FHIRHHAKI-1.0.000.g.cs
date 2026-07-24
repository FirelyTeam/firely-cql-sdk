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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.4.0")]
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

                bool ar_() {
                    Patient as_ = this.Patient(context);
                    bool at_ = as_ is DomainResource;
                    return at_;
                }

                if (ar_())
                {
                    Patient au_ = this.Patient(context);
                    return (au_ as DomainResource).Extension;
                }
                else
                {
                    return default;
                }
            }


            bool? f_(Extension @this) {
                FhirUri av_ = @this?.UrlElement;
                string aw_ = FHIRHelpers_4_4_000.Instance.ToString(context, av_);
                bool? ax_ = context.Operators.Equal(aw_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                return ax_;
            }

            IEnumerable<Extension> g_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(e_()), f_);

            DataType h_(Extension @this) {
                DataType ay_ = @this?.Value;
                return ay_;
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
            CqlDateTime ag_ = context.Operators.Start(s_);
            CqlDate ah_ = context.Operators.DateFrom(ag_);
            int? ai_ = context.Operators.CalculateAgeAt(af_, ah_, "year");
            bool? aj_ = context.Operators.GreaterOrEqual(ai_, 18);
            bool? ak_ = context.Operators.And(ab_, aj_);
            CqlInterval<CqlDateTime> al_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime am_ = context.Operators.Start(al_);
            CqlDateTime an_ = context.Operators.End(al_);
            int? ao_ = context.Operators.DurationBetween(am_, an_, "hour");
            bool? ap_ = context.Operators.GreaterOrEqual(ao_, 48);
            bool? aq_ = context.Operators.And(ak_, ap_);
            return aq_;
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

                bool af_() {
                    DataType ai_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlDateTime;
                    return ak_;
                }


                bool ag_() {
                    DataType al_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlInterval<CqlDateTime>;
                    return an_;
                }


                bool ah_() {
                    DataType ao_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlDateTime;
                    return aq_;
                }

                if (af_())
                {
                    DataType ar_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return as_ as CqlDateTime;
                }
                else if (ag_())
                {
                    DataType at_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return au_ as CqlInterval<CqlDateTime>;
                }
                else if (ah_())
                {
                    DataType av_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    return aw_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_());
            CqlInterval<CqlDateTime> r_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bbcfbwcplsbuhefbwpxpvuequ?.Encounter48Hours);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlQuantity t_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime u_ = context.Operators.Add(s_, t_);
            CqlDateTime v_ = context.Operators.End(r_);
            CqlInterval<CqlDateTime> w_ = context.Operators.Interval(u_, v_, true, true);
            bool? x_ = context.Operators.In<CqlDateTime>(q_, w_, (string)default);
            bool? y_ = context.Operators.And(o_, x_);
            Code<ObservationStatus> z_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.StatusElement;
            ObservationStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            string[] ac_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
            bool? ae_ = context.Operators.And(y_, ad_);
            return ae_;
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
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Obstetrics_and_VTE_Obstetrics(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, EncounterWithCreatinine);

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
            bool? n_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? o_ = context.Operators.Or(h_, n_);
            bool? p_ = context.Operators.Not(o_);
            return p_;
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

                bool ad_() {
                    DataType ag_ = CreatinineTest?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;
                    return ai_;
                }


                bool ae_() {
                    DataType aj_ = CreatinineTest?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlInterval<CqlDateTime>;
                    return al_;
                }


                bool af_() {
                    DataType am_ = CreatinineTest?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlDateTime;
                    return ao_;
                }

                if (ad_())
                {
                    DataType ap_ = CreatinineTest?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    return aq_ as CqlDateTime;
                }
                else if (ae_())
                {
                    DataType ar_ = CreatinineTest?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return as_ as CqlInterval<CqlDateTime>;
                }
                else if (af_())
                {
                    DataType at_ = CreatinineTest?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return au_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_());
            CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlQuantity o_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime p_ = context.Operators.Add(n_, o_);
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
            bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, (string)default);
            bool? s_ = context.Operators.And(j_, r_);

            object t_() {

                bool av_() {
                    DataType ay_ = CreatinineTest?.Effective;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    bool ba_ = az_ is CqlDateTime;
                    return ba_;
                }


                bool aw_() {
                    DataType bb_ = CreatinineTest?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                    return bd_;
                }


                bool ax_() {
                    DataType be_ = CreatinineTest?.Effective;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlDateTime;
                    return bg_;
                }

                if (av_())
                {
                    DataType bh_ = CreatinineTest?.Effective;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    return bi_ as CqlDateTime;
                }
                else if (aw_())
                {
                    DataType bj_ = CreatinineTest?.Effective;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    return bk_ as CqlInterval<CqlDateTime>;
                }
                else if (ax_())
                {
                    DataType bl_ = CreatinineTest?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    return bm_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_());
            bool? v_ = context.Operators.In<CqlDateTime>(u_, m_, (string)default);
            bool? w_ = context.Operators.And(s_, v_);
            Code<ObservationStatus> x_ = CreatinineTest?.StatusElement;
            ObservationStatus? y_ = x_?.Value;
            string z_ = context.Operators.Convert<string>(y_);
            string[] aa_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
            bool? ac_ = context.Operators.And(w_, ab_);
            return ac_;
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
                    }
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
                decimal? ad_ = context.Operators.Max<decimal?>((IEnumerable<decimal?>)y_);
                decimal? ae_ = context.Operators.Negate(1.200m);
                decimal? af_ = context.Operators.Power(ad_, ae_);
                decimal? ag_ = context.Operators.Multiply(ac_, af_);
                Patient ah_ = this.Patient(context);
                Date ai_ = ah_?.BirthDateElement;
                string aj_ = ai_?.Value;
                CqlDateTime ak_ = context.Operators.ConvertStringToDateTime(aj_);
                CqlInterval<CqlDateTime> al_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlDateTime am_ = context.Operators.Start(al_);
                int? an_ = context.Operators.CalculateAgeAt(ak_, am_, "year");
                decimal? ao_ = context.Operators.ConvertIntegerToDecimal(an_);
                decimal? ap_ = context.Operators.Power(0.9938m, ao_);
                decimal? aq_ = context.Operators.Multiply(ag_, ap_);
                return aq_;
            }
            else
            {
                return default;
            }
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
            CqlQuantity o_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime p_ = context.Operators.Add(n_, o_);
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
            bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, (string)default);
            bool? s_ = context.Operators.And(k_, r_);
            return s_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity t_ = @this?.CrLabResult;
            bool? u_ = context.Operators.Not((bool?)(t_ is null));
            return u_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> e_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(c_, d_);

        CqlQuantity f_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity v_ = @this?.CrLabResult;
            return v_;
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

                bool ak_() {
                    DataType an_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlDateTime;
                    return ap_;
                }


                bool al_() {
                    DataType aq_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlInterval<CqlDateTime>;
                    return as_;
                }


                bool am_() {
                    DataType at_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    bool av_ = au_ is CqlDateTime;
                    return av_;
                }

                if (ak_())
                {
                    DataType aw_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return ax_ as CqlDateTime;
                }
                else if (al_())
                {
                    DataType ay_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    return az_ as CqlInterval<CqlDateTime>;
                }
                else if (am_())
                {
                    DataType ba_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    return bb_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
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
            bool? af_ = context.Operators.Not((bool?)(ab_ is null));
            bool? ag_ = context.Operators.And(ae_, af_);
            CqlQuantity ah_ = context.Operators.Quantity(0m, "mg/dL");
            bool? ai_ = context.Operators.Greater(ab_ as CqlQuantity, ah_);
            bool? aj_ = context.Operators.And(ag_, ai_);
            return aj_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?>(f_, g_);

        (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? tuple_ccccqpjvqogtctjhtilehkfoj) {
            Id bc_ = tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter?.IdElement;
            string bd_ = bc_?.Value;
            CqlInterval<CqlDateTime> be_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter);
            Id bf_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IdElement;
            string bg_ = bf_?.Value;

            object bh_() {
                if ((QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation)) ?? false)
                {
                    return "laboratory";
                }
                else
                {
                    bool? by_ = QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation);
                    return by_;
                }
            }

            List<CodeableConcept> bi_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Category;

            CqlConcept bj_(CodeableConcept @this) {
                CqlConcept bz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bz_;
            }

            IEnumerable<CqlConcept> bk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bi_, bj_);
            Code<ObservationStatus> bl_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.StatusElement;
            ObservationStatus? bm_ = bl_?.Value;
            string bn_ = context.Operators.Convert<string>(bm_);
            DataType bo_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
            object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
            string bq_ = (bp_ as CqlQuantity)?.unit;
            decimal? br_ = (bp_ as CqlQuantity)?.value;

            object bs_() {

                bool ca_() {
                    DataType cd_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlDateTime;
                    return cf_;
                }


                bool cb_() {
                    DataType cg_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    bool ci_ = ch_ is CqlInterval<CqlDateTime>;
                    return ci_;
                }


                bool cc_() {
                    DataType cj_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlDateTime;
                    return cl_;
                }

                if (ca_())
                {
                    DataType cm_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    return cn_ as CqlDateTime;
                }
                else if (cb_())
                {
                    DataType co_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                    return cp_ as CqlInterval<CqlDateTime>;
                }
                else if (cc_())
                {
                    DataType cq_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    return cr_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime bt_ = QICoreCommon_4_0_000.Instance.earliest(context, bs_());
            Instant bu_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IssuedElement;
            DateTimeOffset? bv_ = bu_?.Value;
            CqlDateTime bw_ = context.Operators.Convert<CqlDateTime>(bv_);
            (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? bx_ = (CqlTupleMetadata_EROdcjJjSdFbfXChfKbYbOdDN, bd_, be_, bg_, bh_(), bk_, bn_, bp_ as CqlQuantity, bq_, br_, bt_, bw_);
            return bx_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?, (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(h_, i_);
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> k_ = context.Operators.Distinct<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(j_);

        object l_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime cs_ = @this?.CrLabTime;
            return cs_;
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
            CqlQuantity o_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime p_ = context.Operators.Add(n_, o_);
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
            bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, (string)default);
            bool? s_ = context.Operators.And(k_, r_);
            return s_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime t_ = @this?.CrLabTime;
            bool? u_ = context.Operators.Not((bool?)(t_ is null));
            return u_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> e_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(c_, d_);

        CqlDateTime f_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime v_ = @this?.CrLabTime;
            return v_;
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
            decimal? f_ = context.Operators.ConvertIntegerToDecimal(60);
            bool? g_ = context.Operators.Less(d_ as decimal?, f_);
            bool? h_ = context.Operators.And(e_, g_);
            return h_;
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
                    }
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
                decimal? ad_ = context.Operators.Max<decimal?>((IEnumerable<decimal?>)y_);
                decimal? ae_ = context.Operators.Negate(1.200m);
                decimal? af_ = context.Operators.Power(ad_, ae_);
                decimal? ag_ = context.Operators.Multiply(ac_, af_);
                Patient ah_ = this.Patient(context);
                Date ai_ = ah_?.BirthDateElement;
                string aj_ = ai_?.Value;
                CqlDateTime ak_ = context.Operators.ConvertStringToDateTime(aj_);
                CqlInterval<CqlDateTime> al_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlDateTime am_ = context.Operators.Start(al_);
                int? an_ = context.Operators.CalculateAgeAt(ak_, am_, "year");
                decimal? ao_ = context.Operators.ConvertIntegerToDecimal(an_);
                decimal? ap_ = context.Operators.Power(0.9938m, ao_);
                decimal? aq_ = context.Operators.Multiply(ag_, ap_);
                decimal? ar_ = context.Operators.Multiply(aq_, 1.012m);
                return ar_;
            }
            else
            {
                return default;
            }
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
            decimal? f_ = context.Operators.ConvertIntegerToDecimal(60);
            bool? g_ = context.Operators.Less(d_ as decimal?, f_);
            bool? h_ = context.Operators.And(e_, g_);
            return h_;
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
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, c_, c_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? e_(ValueTuple<Encounter, Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? l_ = (CqlTupleMetadata_FWVGLDcQEISFGIdVNGEWPHUFV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return l_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?>(d_, e_);

        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen) {
            Code<ObservationStatus> m_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.StatusElement;
            ObservationStatus? n_ = m_?.Value;
            string o_ = context.Operators.Convert<string>(n_);
            string[] p_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
            Code<ObservationStatus> r_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.StatusElement;
            ObservationStatus? s_ = r_?.Value;
            string t_ = context.Operators.Convert<string>(s_);
            bool? u_ = context.Operators.In<string>(t_, (IEnumerable<string>)p_);
            bool? v_ = context.Operators.And(q_, u_);
            DataType w_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Value;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            DataType y_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlQuantity aa_ = context.Operators.Subtract(x_ as CqlQuantity, z_ as CqlQuantity);
            CqlQuantity ab_ = context.Operators.Quantity(0.299m, "mg/dL");
            bool? ac_ = context.Operators.Greater(aa_, ab_);
            bool? ad_ = context.Operators.And(v_, ac_);
            CqlQuantity ae_ = this.lowestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            bool? af_ = context.Operators.Equal(z_ as CqlQuantity, ae_);
            bool? ag_ = context.Operators.And(ad_, af_);

            object ah_() {

                bool bw_() {
                    DataType bz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    bool cb_ = ca_ is CqlDateTime;
                    return cb_;
                }


                bool bx_() {
                    DataType cc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                    return ce_;
                }


                bool by_() {
                    DataType cf_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlDateTime;
                    return ch_;
                }

                if (bw_())
                {
                    DataType ci_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    return cj_ as CqlDateTime;
                }
                else if (bx_())
                {
                    DataType ck_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    return cl_ as CqlInterval<CqlDateTime>;
                }
                else if (by_())
                {
                    DataType cm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    return cn_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime ai_ = QICoreCommon_4_0_000.Instance.earliest(context, ah_());

            object aj_() {

                bool co_() {
                    DataType cr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    bool ct_ = cs_ is CqlDateTime;
                    return ct_;
                }


                bool cp_() {
                    DataType cu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                    bool cw_ = cv_ is CqlInterval<CqlDateTime>;
                    return cw_;
                }


                bool cq_() {
                    DataType cx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    bool cz_ = cy_ is CqlDateTime;
                    return cz_;
                }

                if (co_())
                {
                    DataType da_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    return db_ as CqlDateTime;
                }
                else if (cp_())
                {
                    DataType dc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                    return dd_ as CqlInterval<CqlDateTime>;
                }
                else if (cq_())
                {
                    DataType de_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    return df_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime ak_ = QICoreCommon_4_0_000.Instance.earliest(context, aj_());
            CqlQuantity al_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime am_ = context.Operators.Subtract(ak_, al_);

            object an_() {

                bool dg_() {
                    DataType dj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                    bool dl_ = dk_ is CqlDateTime;
                    return dl_;
                }


                bool dh_() {
                    DataType dm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                    bool do_ = dn_ is CqlInterval<CqlDateTime>;
                    return do_;
                }


                bool di_() {
                    DataType dp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    bool dr_ = dq_ is CqlDateTime;
                    return dr_;
                }

                if (dg_())
                {
                    DataType ds_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    return dt_ as CqlDateTime;
                }
                else if (dh_())
                {
                    DataType du_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                    return dv_ as CqlInterval<CqlDateTime>;
                }
                else if (di_())
                {
                    DataType dw_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    return dx_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_());
            CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(am_, ao_, true, true);
            bool? aq_ = context.Operators.In<CqlDateTime>(ai_, ap_, (string)default);
            bool? ar_ = context.Operators.And(ag_, aq_);

            object as_() {

                bool dy_() {
                    DataType eb_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                    bool ed_ = ec_ is CqlDateTime;
                    return ed_;
                }


                bool dz_() {
                    DataType ee_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                    bool eg_ = ef_ is CqlInterval<CqlDateTime>;
                    return eg_;
                }


                bool ea_() {
                    DataType eh_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                    bool ej_ = ei_ is CqlDateTime;
                    return ej_;
                }

                if (dy_())
                {
                    DataType ek_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    return el_ as CqlDateTime;
                }
                else if (dz_())
                {
                    DataType em_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    return en_ as CqlInterval<CqlDateTime>;
                }
                else if (ea_())
                {
                    DataType eo_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                    return ep_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_());
            CqlInterval<CqlDateTime> au_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            bool? av_ = context.Operators.In<CqlDateTime>(at_, au_, (string)default);
            bool? aw_ = context.Operators.And(ar_, av_);

            object ax_() {

                bool eq_() {
                    DataType et_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    bool ev_ = eu_ is CqlDateTime;
                    return ev_;
                }


                bool er_() {
                    DataType ew_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                    bool ey_ = ex_ is CqlInterval<CqlDateTime>;
                    return ey_;
                }


                bool es_() {
                    DataType ez_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                    bool fb_ = fa_ is CqlDateTime;
                    return fb_;
                }

                if (eq_())
                {
                    DataType fc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                    return fd_ as CqlDateTime;
                }
                else if (er_())
                {
                    DataType fe_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    return ff_ as CqlInterval<CqlDateTime>;
                }
                else if (es_())
                {
                    DataType fg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                    return fh_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime ay_ = QICoreCommon_4_0_000.Instance.earliest(context, ax_());
            CqlDateTime az_ = context.Operators.Start(au_);
            CqlQuantity ba_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime bb_ = context.Operators.Add(az_, ba_);
            CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(az_, bb_, true, true);
            bool? bd_ = context.Operators.In<CqlDateTime>(ay_, bc_, (string)default);
            bool? be_ = context.Operators.And(aw_, bd_);

            object bf_() {

                bool fi_() {
                    DataType fl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    bool fn_ = fm_ is CqlDateTime;
                    return fn_;
                }


                bool fj_() {
                    DataType fo_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                    bool fq_ = fp_ is CqlInterval<CqlDateTime>;
                    return fq_;
                }


                bool fk_() {
                    DataType fr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                    bool ft_ = fs_ is CqlDateTime;
                    return ft_;
                }

                if (fi_())
                {
                    DataType fu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                    return fv_ as CqlDateTime;
                }
                else if (fj_())
                {
                    DataType fw_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                    return fx_ as CqlInterval<CqlDateTime>;
                }
                else if (fk_())
                {
                    DataType fy_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                    return fz_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime bg_ = QICoreCommon_4_0_000.Instance.earliest(context, bf_());
            bool? bh_ = context.Operators.In<CqlDateTime>(bg_, au_, (string)default);
            bool? bi_ = context.Operators.And(be_, bh_);

            object bj_() {

                bool ga_() {
                    DataType gd_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                    bool gf_ = ge_ is CqlDateTime;
                    return gf_;
                }


                bool gb_() {
                    DataType gg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                    bool gi_ = gh_ is CqlInterval<CqlDateTime>;
                    return gi_;
                }


                bool gc_() {
                    DataType gj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                    bool gl_ = gk_ is CqlDateTime;
                    return gl_;
                }

                if (ga_())
                {
                    DataType gm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                    return gn_ as CqlDateTime;
                }
                else if (gb_())
                {
                    DataType go_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                    return gp_ as CqlInterval<CqlDateTime>;
                }
                else if (gc_())
                {
                    DataType gq_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gq_);
                    return gr_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime bk_ = QICoreCommon_4_0_000.Instance.earliest(context, bj_());
            CqlDateTime bl_ = context.Operators.Add(az_, al_);
            CqlInterval<CqlDateTime> bm_ = context.Operators.Interval(az_, bl_, true, true);
            bool? bn_ = context.Operators.In<CqlDateTime>(bk_, bm_, (string)default);
            bool? bo_ = context.Operators.And(bi_, bn_);
            Id bp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
            string bq_ = bp_?.Value;
            Id br_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
            string bs_ = br_?.Value;
            bool? bt_ = context.Operators.Equal(bq_, bs_);
            bool? bu_ = context.Operators.Not(bt_);
            bool? bv_ = context.Operators.And(bo_, bu_);
            return bv_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen) => tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        return k_;
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
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, c_, c_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? e_(ValueTuple<Encounter, Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? l_ = (CqlTupleMetadata_FWVGLDcQEISFGIdVNGEWPHUFV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return l_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?>(d_, e_);

        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen) {
            Code<ObservationStatus> m_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.StatusElement;
            ObservationStatus? n_ = m_?.Value;
            string o_ = context.Operators.Convert<string>(n_);
            string[] p_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
            Code<ObservationStatus> r_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.StatusElement;
            ObservationStatus? s_ = r_?.Value;
            string t_ = context.Operators.Convert<string>(s_);
            bool? u_ = context.Operators.In<string>(t_, (IEnumerable<string>)p_);
            bool? v_ = context.Operators.And(q_, u_);
            DataType w_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Value;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            DataType y_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlQuantity aa_ = context.Operators.Subtract(x_ as CqlQuantity, z_ as CqlQuantity);
            CqlQuantity ab_ = context.Operators.Quantity(0.299m, "mg/dL");
            bool? ac_ = context.Operators.Greater(aa_, ab_);
            bool? ad_ = context.Operators.And(v_, ac_);
            IEnumerable<CqlQuantity> ae_ = this.earliestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            CqlQuantity af_ = context.Operators.SingletonFrom<CqlQuantity>(ae_);
            bool? ag_ = context.Operators.Equal(z_ as CqlQuantity, af_);
            bool? ah_ = context.Operators.And(ad_, ag_);

            object ai_() {

                bool bu_() {
                    DataType bx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlDateTime;
                    return bz_;
                }


                bool bv_() {
                    DataType ca_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    bool cc_ = cb_ is CqlInterval<CqlDateTime>;
                    return cc_;
                }


                bool bw_() {
                    DataType cd_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlDateTime;
                    return cf_;
                }

                if (bu_())
                {
                    DataType cg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    return ch_ as CqlDateTime;
                }
                else if (bv_())
                {
                    DataType ci_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    return cj_ as CqlInterval<CqlDateTime>;
                }
                else if (bw_())
                {
                    DataType ck_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    return cl_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_());

            object ak_() {

                bool cm_() {
                    DataType cp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    bool cr_ = cq_ is CqlDateTime;
                    return cr_;
                }


                bool cn_() {
                    DataType cs_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                    bool cu_ = ct_ is CqlInterval<CqlDateTime>;
                    return cu_;
                }


                bool co_() {
                    DataType cv_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    bool cx_ = cw_ is CqlDateTime;
                    return cx_;
                }

                if (cm_())
                {
                    DataType cy_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    return cz_ as CqlDateTime;
                }
                else if (cn_())
                {
                    DataType da_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    return db_ as CqlInterval<CqlDateTime>;
                }
                else if (co_())
                {
                    DataType dc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                    return dd_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime al_ = QICoreCommon_4_0_000.Instance.earliest(context, ak_());
            CqlQuantity am_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime an_ = context.Operators.Subtract(al_, am_);

            object ao_() {

                bool de_() {
                    DataType dh_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                    bool dj_ = di_ is CqlDateTime;
                    return dj_;
                }


                bool df_() {
                    DataType dk_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                    bool dm_ = dl_ is CqlInterval<CqlDateTime>;
                    return dm_;
                }


                bool dg_() {
                    DataType dn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    bool dp_ = do_ is CqlDateTime;
                    return dp_;
                }

                if (de_())
                {
                    DataType dq_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                    return dr_ as CqlDateTime;
                }
                else if (df_())
                {
                    DataType ds_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    return dt_ as CqlInterval<CqlDateTime>;
                }
                else if (dg_())
                {
                    DataType du_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                    return dv_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_());
            CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(an_, ap_, true, true);
            bool? ar_ = context.Operators.In<CqlDateTime>(aj_, aq_, (string)default);
            bool? as_ = context.Operators.And(ah_, ar_);

            object at_() {

                bool dw_() {
                    DataType dz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                    bool eb_ = ea_ is CqlDateTime;
                    return eb_;
                }


                bool dx_() {
                    DataType ec_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                    bool ee_ = ed_ is CqlInterval<CqlDateTime>;
                    return ee_;
                }


                bool dy_() {
                    DataType ef_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                    bool eh_ = eg_ is CqlDateTime;
                    return eh_;
                }

                if (dw_())
                {
                    DataType ei_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                    return ej_ as CqlDateTime;
                }
                else if (dx_())
                {
                    DataType ek_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    return el_ as CqlInterval<CqlDateTime>;
                }
                else if (dy_())
                {
                    DataType em_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    return en_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime au_ = QICoreCommon_4_0_000.Instance.earliest(context, at_());
            CqlInterval<CqlDateTime> av_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            bool? aw_ = context.Operators.In<CqlDateTime>(au_, av_, (string)default);
            bool? ax_ = context.Operators.And(as_, aw_);

            object ay_() {

                bool eo_() {
                    DataType er_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    bool et_ = es_ is CqlDateTime;
                    return et_;
                }


                bool ep_() {
                    DataType eu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                    bool ew_ = ev_ is CqlInterval<CqlDateTime>;
                    return ew_;
                }


                bool eq_() {
                    DataType ex_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    bool ez_ = ey_ is CqlDateTime;
                    return ez_;
                }

                if (eo_())
                {
                    DataType fa_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                    return fb_ as CqlDateTime;
                }
                else if (ep_())
                {
                    DataType fc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                    return fd_ as CqlInterval<CqlDateTime>;
                }
                else if (eq_())
                {
                    DataType fe_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    return ff_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime az_ = QICoreCommon_4_0_000.Instance.earliest(context, ay_());
            CqlDateTime ba_ = context.Operators.Start(av_);
            CqlDateTime bb_ = context.Operators.Add(ba_, am_);
            CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(ba_, bb_, true, true);
            bool? bd_ = context.Operators.In<CqlDateTime>(az_, bc_, (string)default);
            bool? be_ = context.Operators.And(ax_, bd_);

            object bf_() {

                bool fg_() {
                    DataType fj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                    bool fl_ = fk_ is CqlDateTime;
                    return fl_;
                }


                bool fh_() {
                    DataType fm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                    bool fo_ = fn_ is CqlInterval<CqlDateTime>;
                    return fo_;
                }


                bool fi_() {
                    DataType fp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    bool fr_ = fq_ is CqlDateTime;
                    return fr_;
                }

                if (fg_())
                {
                    DataType fs_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                    return ft_ as CqlDateTime;
                }
                else if (fh_())
                {
                    DataType fu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                    return fv_ as CqlInterval<CqlDateTime>;
                }
                else if (fi_())
                {
                    DataType fw_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                    return fx_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime bg_ = QICoreCommon_4_0_000.Instance.earliest(context, bf_());
            bool? bh_ = context.Operators.In<CqlDateTime>(bg_, av_, (string)default);
            bool? bi_ = context.Operators.And(be_, bh_);

            object bj_() {

                bool fy_() {
                    DataType gb_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
                    bool gd_ = gc_ is CqlDateTime;
                    return gd_;
                }


                bool fz_() {
                    DataType ge_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                    bool gg_ = gf_ is CqlInterval<CqlDateTime>;
                    return gg_;
                }


                bool ga_() {
                    DataType gh_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object gi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gh_);
                    bool gj_ = gi_ is CqlDateTime;
                    return gj_;
                }

                if (fy_())
                {
                    DataType gk_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object gl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gk_);
                    return gl_ as CqlDateTime;
                }
                else if (fz_())
                {
                    DataType gm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                    return gn_ as CqlInterval<CqlDateTime>;
                }
                else if (ga_())
                {
                    DataType go_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                    return gp_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime bk_ = QICoreCommon_4_0_000.Instance.earliest(context, bj_());
            bool? bl_ = context.Operators.In<CqlDateTime>(bk_, bc_, (string)default);
            bool? bm_ = context.Operators.And(bi_, bl_);
            Id bn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
            string bo_ = bn_?.Value;
            Id bp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
            string bq_ = bp_?.Value;
            bool? br_ = context.Operators.Equal(bo_, bq_);
            bool? bs_ = context.Operators.Not(br_);
            bool? bt_ = context.Operators.And(bm_, bs_);
            return bt_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen) => tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        return k_;
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

                bool af_() {
                    DataType aj_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlDateTime;
                    return al_;
                }


                bool ag_() {
                    DataType am_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlInterval<CqlDateTime>;
                    return ao_;
                }


                bool ah_() {
                    DataType ap_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlQuantity;
                    return ar_;
                }


                bool ai_() {
                    DataType as_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlInterval<CqlQuantity>;
                    return au_;
                }

                if (af_())
                {
                    DataType av_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    return aw_ as CqlDateTime;
                }
                else if (ag_())
                {
                    DataType ax_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    return ay_ as CqlInterval<CqlDateTime>;
                }
                else if (ah_())
                {
                    DataType az_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    return ba_ as CqlQuantity;
                }
                else if (ai_())
                {
                    DataType bb_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    return bc_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_());
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlInterval<CqlDateTime> t_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlQuantity v_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime w_ = context.Operators.Add(u_, v_);
            CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);
            bool? y_ = context.Operators.In<CqlDateTime>(s_, x_, (string)default);
            bool? z_ = context.Operators.And(p_, y_);

            object aa_() {

                bool bd_() {
                    DataType bh_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlDateTime;
                    return bj_;
                }


                bool be_() {
                    DataType bk_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                    return bm_;
                }


                bool bf_() {
                    DataType bn_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlQuantity;
                    return bp_;
                }


                bool bg_() {
                    DataType bq_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool bs_ = br_ is CqlInterval<CqlQuantity>;
                    return bs_;
                }

                if (bd_())
                {
                    DataType bt_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    return bu_ as CqlDateTime;
                }
                else if (be_())
                {
                    DataType bv_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return bw_ as CqlInterval<CqlDateTime>;
                }
                else if (bf_())
                {
                    DataType bx_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    return by_ as CqlQuantity;
                }
                else if (bg_())
                {
                    DataType bz_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    return ca_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_());
            CqlDateTime ac_ = context.Operators.Start(ab_);
            bool? ad_ = context.Operators.In<CqlDateTime>(ac_, t_, (string)default);
            bool? ae_ = context.Operators.And(z_, ad_);
            return ae_;
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
                    }
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
            }
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
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, c_, c_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? e_(ValueTuple<Encounter, Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? l_ = (CqlTupleMetadata_JeYVEdgebecHQGRICIKegVBi, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return l_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?>(d_, e_);

        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_gsqsgqbihalobloqrcccgdeiw) {
            DataType m_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlQuantity o_ = this.Serum_Creatinine_Normal(context);
            bool? p_ = context.Operators.Greater(n_ as CqlQuantity, o_);
            Code<ObservationStatus> q_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.StatusElement;
            ObservationStatus? r_ = q_?.Value;
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
            bool? v_ = context.Operators.And(p_, u_);
            Code<ObservationStatus> w_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.StatusElement;
            ObservationStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            bool? z_ = context.Operators.In<string>(y_, (IEnumerable<string>)t_);
            bool? aa_ = context.Operators.And(v_, z_);
            CqlQuantity ab_ = this.highestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            bool? ac_ = context.Operators.Equal(n_ as CqlQuantity, ab_);
            bool? ad_ = context.Operators.And(aa_, ac_);
            DataType ae_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Value;
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            CqlQuantity ag_ = this.lowestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            bool? ah_ = context.Operators.Equal(af_ as CqlQuantity, ag_);
            bool? ai_ = context.Operators.And(ad_, ah_);
            CqlQuantity aj_ = this.oneAndAHalfIncreaseInCreatinine(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            bool? ak_ = context.Operators.GreaterOrEqual(aj_, af_ as CqlQuantity);
            bool? al_ = context.Operators.And(ai_, ak_);

            object am_() {

                bool bu_() {
                    DataType bx_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlDateTime;
                    return bz_;
                }


                bool bv_() {
                    DataType ca_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    bool cc_ = cb_ is CqlInterval<CqlDateTime>;
                    return cc_;
                }


                bool bw_() {
                    DataType cd_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlDateTime;
                    return cf_;
                }

                if (bu_())
                {
                    DataType cg_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    return ch_ as CqlDateTime;
                }
                else if (bv_())
                {
                    DataType ci_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    return cj_ as CqlInterval<CqlDateTime>;
                }
                else if (bw_())
                {
                    DataType ck_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    return cl_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime an_ = QICoreCommon_4_0_000.Instance.earliest(context, am_());

            object ao_() {

                bool cm_() {
                    DataType cp_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    bool cr_ = cq_ is CqlDateTime;
                    return cr_;
                }


                bool cn_() {
                    DataType cs_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                    bool cu_ = ct_ is CqlInterval<CqlDateTime>;
                    return cu_;
                }


                bool co_() {
                    DataType cv_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    bool cx_ = cw_ is CqlDateTime;
                    return cx_;
                }

                if (cm_())
                {
                    DataType cy_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    return cz_ as CqlDateTime;
                }
                else if (cn_())
                {
                    DataType da_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    return db_ as CqlInterval<CqlDateTime>;
                }
                else if (co_())
                {
                    DataType dc_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                    return dd_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_());
            CqlQuantity aq_ = context.Operators.Quantity(7m, "days");
            CqlDateTime ar_ = context.Operators.Subtract(ap_, aq_);

            object as_() {

                bool de_() {
                    DataType dh_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                    bool dj_ = di_ is CqlDateTime;
                    return dj_;
                }


                bool df_() {
                    DataType dk_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                    bool dm_ = dl_ is CqlInterval<CqlDateTime>;
                    return dm_;
                }


                bool dg_() {
                    DataType dn_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    bool dp_ = do_ is CqlDateTime;
                    return dp_;
                }

                if (de_())
                {
                    DataType dq_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                    return dr_ as CqlDateTime;
                }
                else if (df_())
                {
                    DataType ds_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    return dt_ as CqlInterval<CqlDateTime>;
                }
                else if (dg_())
                {
                    DataType du_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                    return dv_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_());
            CqlInterval<CqlDateTime> au_ = context.Operators.Interval(ar_, at_, true, false);
            bool? av_ = context.Operators.In<CqlDateTime>(an_, au_, (string)default);

            object aw_() {

                bool dw_() {
                    DataType dz_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                    bool eb_ = ea_ is CqlDateTime;
                    return eb_;
                }


                bool dx_() {
                    DataType ec_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                    bool ee_ = ed_ is CqlInterval<CqlDateTime>;
                    return ee_;
                }


                bool dy_() {
                    DataType ef_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                    bool eh_ = eg_ is CqlDateTime;
                    return eh_;
                }

                if (dw_())
                {
                    DataType ei_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                    return ej_ as CqlDateTime;
                }
                else if (dx_())
                {
                    DataType ek_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    return el_ as CqlInterval<CqlDateTime>;
                }
                else if (dy_())
                {
                    DataType em_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    return en_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime ax_ = QICoreCommon_4_0_000.Instance.earliest(context, aw_());
            bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
            bool? az_ = context.Operators.And(av_, ay_);
            bool? ba_ = context.Operators.And(al_, az_);

            object bb_() {

                bool eo_() {
                    DataType er_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    bool et_ = es_ is CqlDateTime;
                    return et_;
                }


                bool ep_() {
                    DataType eu_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                    bool ew_ = ev_ is CqlInterval<CqlDateTime>;
                    return ew_;
                }


                bool eq_() {
                    DataType ex_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    bool ez_ = ey_ is CqlDateTime;
                    return ez_;
                }

                if (eo_())
                {
                    DataType fa_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                    return fb_ as CqlDateTime;
                }
                else if (ep_())
                {
                    DataType fc_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                    return fd_ as CqlInterval<CqlDateTime>;
                }
                else if (eq_())
                {
                    DataType fe_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    return ff_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime bc_ = QICoreCommon_4_0_000.Instance.earliest(context, bb_());
            CqlInterval<CqlDateTime> bd_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            bool? be_ = context.Operators.In<CqlDateTime>(bc_, bd_, (string)default);
            bool? bf_ = context.Operators.And(ba_, be_);

            object bg_() {

                bool fg_() {
                    DataType fj_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                    bool fl_ = fk_ is CqlDateTime;
                    return fl_;
                }


                bool fh_() {
                    DataType fm_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                    bool fo_ = fn_ is CqlInterval<CqlDateTime>;
                    return fo_;
                }


                bool fi_() {
                    DataType fp_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    bool fr_ = fq_ is CqlDateTime;
                    return fr_;
                }

                if (fg_())
                {
                    DataType fs_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                    return ft_ as CqlDateTime;
                }
                else if (fh_())
                {
                    DataType fu_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                    return fv_ as CqlInterval<CqlDateTime>;
                }
                else if (fi_())
                {
                    DataType fw_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                    return fx_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime bh_ = QICoreCommon_4_0_000.Instance.earliest(context, bg_());
            CqlDateTime bi_ = context.Operators.Start(bd_);
            CqlQuantity bj_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime bk_ = context.Operators.Add(bi_, bj_);
            CqlQuantity bl_ = context.Operators.Quantity(30m, "days");
            CqlDateTime bm_ = context.Operators.Add(bi_, bl_);
            CqlInterval<CqlDateTime> bn_ = context.Operators.Interval(bk_, bm_, true, true);
            bool? bo_ = context.Operators.In<CqlDateTime>(bh_, bn_, (string)default);
            bool? bp_ = context.Operators.And(bf_, bo_);

            object bq_() {

                bool fy_() {
                    DataType gb_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
                    bool gd_ = gc_ is CqlDateTime;
                    return gd_;
                }


                bool fz_() {
                    DataType ge_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                    bool gg_ = gf_ is CqlInterval<CqlDateTime>;
                    return gg_;
                }


                bool ga_() {
                    DataType gh_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gh_);
                    bool gj_ = gi_ is CqlDateTime;
                    return gj_;
                }

                if (fy_())
                {
                    DataType gk_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gk_);
                    return gl_ as CqlDateTime;
                }
                else if (fz_())
                {
                    DataType gm_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                    return gn_ as CqlInterval<CqlDateTime>;
                }
                else if (ga_())
                {
                    DataType go_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                    return gp_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime br_ = QICoreCommon_4_0_000.Instance.earliest(context, bq_());
            bool? bs_ = context.Operators.In<CqlDateTime>(br_, bd_, (string)default);
            bool? bt_ = context.Operators.And(bp_, bs_);
            return bt_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_gsqsgqbihalobloqrcccgdeiw) => tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        return k_;
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
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, c_, c_);

        (CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? e_(ValueTuple<Encounter, Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? l_ = (CqlTupleMetadata_BDjSiZCAhXcVgEETFRJVEHXOR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return l_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?>(d_, e_);

        bool? g_((CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_bdjsizcahxcvgeetfrjvehxor) {
            DataType m_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlQuantity o_ = this.Serum_Creatinine_Normal(context);
            bool? p_ = context.Operators.Greater(n_ as CqlQuantity, o_);
            Code<ObservationStatus> q_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.StatusElement;
            ObservationStatus? r_ = q_?.Value;
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
            bool? v_ = context.Operators.And(p_, u_);
            Code<ObservationStatus> w_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.StatusElement;
            ObservationStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            bool? z_ = context.Operators.In<string>(y_, (IEnumerable<string>)t_);
            bool? aa_ = context.Operators.And(v_, z_);
            CqlQuantity ab_ = this.highestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            bool? ac_ = context.Operators.Equal(n_ as CqlQuantity, ab_);
            bool? ad_ = context.Operators.And(aa_, ac_);
            DataType ae_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Value;
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            CqlQuantity ag_ = this.lowestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            bool? ah_ = context.Operators.Equal(af_ as CqlQuantity, ag_);
            bool? ai_ = context.Operators.And(ad_, ah_);
            bool? aj_ = context.Operators.GreaterOrEqual(n_ as CqlQuantity, af_ as CqlQuantity);
            bool? ak_ = context.Operators.And(ai_, aj_);

            object al_() {

                bool bt_() {
                    DataType bw_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    bool by_ = bx_ is CqlDateTime;
                    return by_;
                }


                bool bu_() {
                    DataType bz_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    bool cb_ = ca_ is CqlInterval<CqlDateTime>;
                    return cb_;
                }


                bool bv_() {
                    DataType cc_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    bool ce_ = cd_ is CqlDateTime;
                    return ce_;
                }

                if (bt_())
                {
                    DataType cf_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    return cg_ as CqlDateTime;
                }
                else if (bu_())
                {
                    DataType ch_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    return ci_ as CqlInterval<CqlDateTime>;
                }
                else if (bv_())
                {
                    DataType cj_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    return ck_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime am_ = QICoreCommon_4_0_000.Instance.earliest(context, al_());

            object an_() {

                bool cl_() {
                    DataType co_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                    bool cq_ = cp_ is CqlDateTime;
                    return cq_;
                }


                bool cm_() {
                    DataType cr_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    bool ct_ = cs_ is CqlInterval<CqlDateTime>;
                    return ct_;
                }


                bool cn_() {
                    DataType cu_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                    bool cw_ = cv_ is CqlDateTime;
                    return cw_;
                }

                if (cl_())
                {
                    DataType cx_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    return cy_ as CqlDateTime;
                }
                else if (cm_())
                {
                    DataType cz_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    return da_ as CqlInterval<CqlDateTime>;
                }
                else if (cn_())
                {
                    DataType db_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    return dc_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_());
            CqlQuantity ap_ = context.Operators.Quantity(7m, "days");
            CqlDateTime aq_ = context.Operators.Subtract(ao_, ap_);

            object ar_() {

                bool dd_() {
                    DataType dg_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                    bool di_ = dh_ is CqlDateTime;
                    return di_;
                }


                bool de_() {
                    DataType dj_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                    bool dl_ = dk_ is CqlInterval<CqlDateTime>;
                    return dl_;
                }


                bool df_() {
                    DataType dm_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                    bool do_ = dn_ is CqlDateTime;
                    return do_;
                }

                if (dd_())
                {
                    DataType dp_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                    return dq_ as CqlDateTime;
                }
                else if (de_())
                {
                    DataType dr_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    return ds_ as CqlInterval<CqlDateTime>;
                }
                else if (df_())
                {
                    DataType dt_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    return du_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime as_ = QICoreCommon_4_0_000.Instance.earliest(context, ar_());
            CqlInterval<CqlDateTime> at_ = context.Operators.Interval(aq_, as_, true, false);
            bool? au_ = context.Operators.In<CqlDateTime>(am_, at_, (string)default);

            object av_() {

                bool dv_() {
                    DataType dy_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    bool ea_ = dz_ is CqlDateTime;
                    return ea_;
                }


                bool dw_() {
                    DataType eb_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                    bool ed_ = ec_ is CqlInterval<CqlDateTime>;
                    return ed_;
                }


                bool dx_() {
                    DataType ee_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                    bool eg_ = ef_ is CqlDateTime;
                    return eg_;
                }

                if (dv_())
                {
                    DataType eh_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                    return ei_ as CqlDateTime;
                }
                else if (dw_())
                {
                    DataType ej_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    return ek_ as CqlInterval<CqlDateTime>;
                }
                else if (dx_())
                {
                    DataType el_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    return em_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime aw_ = QICoreCommon_4_0_000.Instance.earliest(context, av_());
            bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
            bool? ay_ = context.Operators.And(au_, ax_);
            bool? az_ = context.Operators.And(ak_, ay_);

            object ba_() {

                bool en_() {
                    DataType eq_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    bool es_ = er_ is CqlDateTime;
                    return es_;
                }


                bool eo_() {
                    DataType et_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    bool ev_ = eu_ is CqlInterval<CqlDateTime>;
                    return ev_;
                }


                bool ep_() {
                    DataType ew_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                    bool ey_ = ex_ is CqlDateTime;
                    return ey_;
                }

                if (en_())
                {
                    DataType ez_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                    return fa_ as CqlDateTime;
                }
                else if (eo_())
                {
                    DataType fb_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                    return fc_ as CqlInterval<CqlDateTime>;
                }
                else if (ep_())
                {
                    DataType fd_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                    return fe_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_());
            CqlInterval<CqlDateTime> bc_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            bool? bd_ = context.Operators.In<CqlDateTime>(bb_, bc_, (string)default);
            bool? be_ = context.Operators.And(az_, bd_);

            object bf_() {

                bool ff_() {
                    DataType fi_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    bool fk_ = fj_ is CqlDateTime;
                    return fk_;
                }


                bool fg_() {
                    DataType fl_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    bool fn_ = fm_ is CqlInterval<CqlDateTime>;
                    return fn_;
                }


                bool fh_() {
                    DataType fo_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                    bool fq_ = fp_ is CqlDateTime;
                    return fq_;
                }

                if (ff_())
                {
                    DataType fr_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                    return fs_ as CqlDateTime;
                }
                else if (fg_())
                {
                    DataType ft_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                    return fu_ as CqlInterval<CqlDateTime>;
                }
                else if (fh_())
                {
                    DataType fv_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                    return fw_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime bg_ = QICoreCommon_4_0_000.Instance.earliest(context, bf_());
            CqlDateTime bh_ = context.Operators.Start(bc_);
            CqlQuantity bi_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime bj_ = context.Operators.Add(bh_, bi_);
            CqlQuantity bk_ = context.Operators.Quantity(30m, "days");
            CqlDateTime bl_ = context.Operators.Add(bh_, bk_);
            CqlInterval<CqlDateTime> bm_ = context.Operators.Interval(bj_, bl_, true, true);
            bool? bn_ = context.Operators.In<CqlDateTime>(bg_, bm_, (string)default);
            bool? bo_ = context.Operators.And(be_, bn_);

            object bp_() {

                bool fx_() {
                    DataType ga_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
                    bool gc_ = gb_ is CqlDateTime;
                    return gc_;
                }


                bool fy_() {
                    DataType gd_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                    bool gf_ = ge_ is CqlInterval<CqlDateTime>;
                    return gf_;
                }


                bool fz_() {
                    DataType gg_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                    bool gi_ = gh_ is CqlDateTime;
                    return gi_;
                }

                if (fx_())
                {
                    DataType gj_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                    return gk_ as CqlDateTime;
                }
                else if (fy_())
                {
                    DataType gl_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                    return gm_ as CqlInterval<CqlDateTime>;
                }
                else if (fz_())
                {
                    DataType gn_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                    return go_ as CqlDateTime;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime bq_ = QICoreCommon_4_0_000.Instance.earliest(context, bp_());
            bool? br_ = context.Operators.In<CqlDateTime>(bq_, bc_, (string)default);
            bool? bs_ = context.Operators.And(bo_, br_);
            return bs_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_bdjsizcahxcvgeetfrjvehxor) => tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        return k_;
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
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.High_Risk_Diagnosis_for_AKI(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? j_(Condition @this) {
                CodeableConcept q_ = @this?.Code;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                bool? s_ = context.Operators.Not((bool?)(r_ is null));
                return s_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);

            CqlConcept l_(Condition @this) {
                CodeableConcept t_ = @this?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                return u_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<Condition, CqlConcept>(k_, l_);
            bool? n_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? o_ = context.Operators.Or(h_, n_);
            return o_;
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

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet d_ = this.High_Risk_Procedures_for_AKI(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure HighRiskProcedures) {
                Code<EventStatus> i_ = HighRiskProcedures?.StatusElement;
                EventStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                bool? l_ = context.Operators.Equal(k_, "completed");

                object m_() {

                    bool s_() {
                        DataType w_ = HighRiskProcedures?.Performed;
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        bool y_ = x_ is CqlDateTime;
                        return y_;
                    }


                    bool t_() {
                        DataType z_ = HighRiskProcedures?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                        return ab_;
                    }


                    bool u_() {
                        DataType ac_ = HighRiskProcedures?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlQuantity;
                        return ae_;
                    }


                    bool v_() {
                        DataType af_ = HighRiskProcedures?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                        return ah_;
                    }

                    if (s_())
                    {
                        DataType ai_ = HighRiskProcedures?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        return aj_ as CqlDateTime;
                    }
                    else if (t_())
                    {
                        DataType ak_ = HighRiskProcedures?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        return al_ as CqlInterval<CqlDateTime>;
                    }
                    else if (u_())
                    {
                        DataType am_ = HighRiskProcedures?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        return an_ as CqlQuantity;
                    }
                    else if (v_())
                    {
                        DataType ao_ = HighRiskProcedures?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        return ap_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_());
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
                bool? r_ = context.Operators.And(l_, q_);
                return r_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
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

                bool ag_() {
                    DataType ak_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    bool am_ = al_ is CqlDateTime;
                    return am_;
                }


                bool ah_() {
                    DataType an_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                    return ap_;
                }


                bool ai_() {
                    DataType aq_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlQuantity;
                    return as_;
                }


                bool aj_() {
                    DataType at_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    bool av_ = au_ is CqlInterval<CqlQuantity>;
                    return av_;
                }

                if (ag_())
                {
                    DataType aw_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return ax_ as CqlDateTime;
                }
                else if (ah_())
                {
                    DataType ay_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    return az_ as CqlInterval<CqlDateTime>;
                }
                else if (ai_())
                {
                    DataType ba_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    return bb_ as CqlQuantity;
                }
                else if (aj_())
                {
                    DataType bc_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    return bd_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_());
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlQuantity r_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime s_ = context.Operators.Add(q_, r_);
            CqlDateTime t_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> u_ = context.Operators.Interval(s_, t_, true, true);
            bool? v_ = context.Operators.In<CqlDateTime>(o_, u_, (string)default);

            object w_() {

                bool be_() {
                    DataType bi_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlDateTime;
                    return bk_;
                }


                bool bf_() {
                    DataType bl_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlInterval<CqlDateTime>;
                    return bn_;
                }


                bool bg_() {
                    DataType bo_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    bool bq_ = bp_ is CqlQuantity;
                    return bq_;
                }


                bool bh_() {
                    DataType br_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    bool bt_ = bs_ is CqlInterval<CqlQuantity>;
                    return bt_;
                }

                if (be_())
                {
                    DataType bu_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    return bv_ as CqlDateTime;
                }
                else if (bf_())
                {
                    DataType bw_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    return bx_ as CqlInterval<CqlDateTime>;
                }
                else if (bg_())
                {
                    DataType by_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    return bz_ as CqlQuantity;
                }
                else if (bh_())
                {
                    DataType ca_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    return cb_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_());
            CqlDateTime y_ = context.Operators.Start(x_);
            bool? z_ = context.Operators.In<CqlDateTime>(y_, p_, (string)default);
            bool? aa_ = context.Operators.And(v_, z_);
            Code<EventStatus> ab_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.StatusElement;
            EventStatus? ac_ = ab_?.Value;
            string ad_ = context.Operators.Convert<string>(ac_);
            bool? ae_ = context.Operators.Equal(ad_, "completed");
            bool? af_ = context.Operators.And(aa_, ae_);
            return af_;
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

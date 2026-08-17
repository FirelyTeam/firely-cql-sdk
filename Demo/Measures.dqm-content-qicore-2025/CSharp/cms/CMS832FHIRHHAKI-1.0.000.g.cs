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
            List<Extension> e_;
            Patient u_ = this.Patient(context);
            bool v_ = u_ is DomainResource;
            if (v_)
            {
                e_ = (u_ as DomainResource).Extension;
            }
            else
            {
                e_ = default;
            }

            bool? f_(Extension @this) {
                FhirUri w_ = @this?.UrlElement;
                string x_ = FHIRHelpers_4_4_000.Instance.ToString(context, w_);
                bool? y_ = context.Operators.Equal(x_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                return y_;
            }


            DataType g_(Extension @this) {
                DataType z_ = @this?.Value;
                return z_;
            }

            IEnumerable<DataType> h_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)e_, f_, g_);
            DataType i_ = context.Operators.SingletonFrom<DataType>(h_);
            string j_ = context.Operators.Convert<string>(i_);
            CqlCode k_ = this.Male__finding_(context);
            string l_ = k_?.code;
            CqlCode m_ = this.Female__finding_(context);
            string n_ = m_?.code;
            string[] o_ = [
                l_,
                n_,
            ];
            bool? p_ = context.Operators.In<string>(j_, (IEnumerable<string>)o_);

            bool? q_() {
                Period aa_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                CqlDateTime ac_ = context.Operators.End(ab_);
                CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
                bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, "day");
                return (bool?)((CqlBoolean)ae_);
            }


            bool? r_() {
                Code<Encounter.EncounterStatus> af_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? ag_ = af_?.Value;
                Code<Encounter.EncounterStatus> ah_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ag_);
                bool? ai_ = context.Operators.Equal(ah_, "finished");
                return (bool?)((CqlBoolean)ai_);
            }


            bool? s_() {
                Patient aj_ = this.Patient(context);
                Date ak_ = aj_?.BirthDateElement;
                string al_ = ak_?.Value;
                CqlDate am_ = context.Operators.ConvertStringToDate(al_);
                Period an_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                CqlDate aq_ = context.Operators.DateFrom(ap_);
                int? ar_ = context.Operators.CalculateAgeAt(am_, aq_, "year");
                bool? as_ = context.Operators.GreaterOrEqual(ar_, 18);
                return (bool?)((CqlBoolean)as_);
            }


            bool? t_() {
                CqlInterval<CqlDateTime> at_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                CqlDateTime au_ = context.Operators.Start(at_);
                CqlDateTime av_ = context.Operators.End(at_);
                int? aw_ = context.Operators.DurationBetween(au_, av_, "hour");
                bool? ax_ = context.Operators.GreaterOrEqual(aw_, 48);
                return (bool?)((CqlBoolean)ax_);
            }

            return (bool?)(/* CQL 'and' (66:5-70:94) */ (/* CQL 'and' (66:11-69:74) */ (/* CQL 'and' (66:11-68:48) */ (/* CQL 'and' (66:11-67:75) */ ((CqlBoolean)p_
                && (CqlBoolean)q_())
                && (CqlBoolean)r_())
                && (CqlBoolean)s_())
                && (CqlBoolean)t_()));
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
            (CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)? j_ = (CqlTupleMetadata_BSZZjZXQgCBZNijVbAJbPfNhP, _valueTuple.Item1, _valueTuple.Item2);
            return j_;
        }


        bool? f_((CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)? tuple_bbcfbwcplsbuhefbwpxpvuequ) {
            DataType k_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Value;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);

            bool? m_() {
                object o_;
                DataType x_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    o_ = y_ as CqlDateTime;
                }
                else
                {
                    if (z_)
                    {
                        o_ = y_ as CqlDateTime;
                    }
                    else
                    {
                        bool aa_ = y_ is CqlInterval<CqlDateTime>;
                        if (aa_)
                        {
                            o_ = y_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            o_ = null;
                        }
                    }
                }
                CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_);
                CqlInterval<CqlDateTime> q_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bbcfbwcplsbuhefbwpxpvuequ?.Encounter48Hours);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlQuantity s_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime t_ = context.Operators.Add(r_, s_);
                CqlDateTime u_ = context.Operators.End(q_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(t_, u_, true, true);
                bool? w_ = context.Operators.In<CqlDateTime>(p_, v_, (string)default);
                return (bool?)((CqlBoolean)w_);
            }


            bool? n_() {
                Code<ObservationStatus> ab_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                return (bool?)((CqlBoolean)af_);
            }

            return (bool?)(/* CQL 'and' (78:5-80:70) */ (/* CQL 'and' (78:11-79:118) */ ((CqlBoolean)(!((bool?)((l_ as CqlQuantity) is null)))
                && (CqlBoolean)m_())
                && (CqlBoolean)n_()));
        }

        IEnumerable<(CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)?> g_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)?>(d_, e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)? tuple_bbcfbwcplsbuhefbwpxpvuequ) => tuple_bbcfbwcplsbuhefbwpxpvuequ?.Encounter48Hours;
        IEnumerable<Encounter> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)?, Encounter>(g_, h_);
        return i_;
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
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Obstetrics_and_VTE_Obstetrics(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);

            bool? i_() {
                IEnumerable<Condition> k_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, EncounterWithCreatinine);

                bool? l_(Condition @this) {
                    CodeableConcept q_ = @this?.Code;
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                    return !((bool?)(r_ is null));
                }


                CqlConcept m_(Condition @this) {
                    CodeableConcept s_ = @this?.Code;
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                    return t_;
                }

                IEnumerable<CqlConcept> n_ = context.Operators.WhereSelect<Condition, CqlConcept>(k_, l_, m_);
                CqlValueSet o_ = this.Obstetrics_and_VTE_Obstetrics(context);
                bool? p_ = context.Operators.ConceptsInValueSet(n_, o_);
                return (bool?)((CqlBoolean)p_);
            }

            return !((bool?)(/* CQL 'or' (85:15-87:5) */ ((CqlBoolean)h_
                || (CqlBoolean)i_())));
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
            DataType g_ = CreatinineTest?.Value;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);

            bool? i_() {
                object l_;
                DataType t_ = CreatinineTest?.Effective;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                bool v_ = u_ is CqlDateTime;
                if (v_)
                {
                    l_ = u_ as CqlDateTime;
                }
                else
                {
                    if (v_)
                    {
                        l_ = u_ as CqlDateTime;
                    }
                    else
                    {
                        bool w_ = u_ is CqlInterval<CqlDateTime>;
                        if (w_)
                        {
                            l_ = u_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            l_ = null;
                        }
                    }
                }
                CqlDateTime m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_);
                CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlQuantity p_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime q_ = context.Operators.Add(o_, p_);
                CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_, true, true);
                bool? s_ = context.Operators.In<CqlDateTime>(m_, r_, (string)default);
                return (bool?)((CqlBoolean)s_);
            }


            bool? j_() {
                object x_;
                DataType ab_ = CreatinineTest?.Effective;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                bool ad_ = ac_ is CqlDateTime;
                if (ad_)
                {
                    x_ = ac_ as CqlDateTime;
                }
                else
                {
                    if (ad_)
                    {
                        x_ = ac_ as CqlDateTime;
                    }
                    else
                    {
                        bool ae_ = ac_ is CqlInterval<CqlDateTime>;
                        if (ae_)
                        {
                            x_ = ac_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            x_ = null;
                        }
                    }
                }
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                return (bool?)((CqlBoolean)aa_);
            }


            bool? k_() {
                Code<ObservationStatus> af_ = CreatinineTest?.StatusElement;
                ObservationStatus? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                string[] ai_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                return (bool?)((CqlBoolean)aj_);
            }

            return (bool?)(/* CQL 'and' (282:5-285:70) */ (/* CQL 'and' (282:11-284:109) */ (/* CQL 'and' (282:11-283:204) */ ((CqlBoolean)(!((bool?)((h_ as CqlQuantity) is null)))
                && (CqlBoolean)i_())
                && (CqlBoolean)j_())
                && (CqlBoolean)k_()));
        }

        Observation d_(Observation CreatinineTest) => CreatinineTest;
        IEnumerable<Observation> e_ = context.Operators.WhereSelect<Observation, Observation>(b_, c_, d_);
        IEnumerable<Observation> f_ = context.Operators.Distinct<Observation>(e_);
        return f_;
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
        List<Extension> a_;
        Patient i_ = this.Patient(context);
        bool j_ = i_ is DomainResource;
        if (j_)
        {
            a_ = (i_ as DomainResource).Extension;
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension @this) {
            FhirUri k_ = @this?.UrlElement;
            string l_ = FHIRHelpers_4_4_000.Instance.ToString(context, k_);
            bool? m_ = context.Operators.Equal(l_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
            return m_;
        }


        DataType c_(Extension @this) {
            DataType n_ = @this?.Value;
            return n_;
        }

        IEnumerable<DataType> d_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)a_, b_, c_);
        DataType e_ = context.Operators.SingletonFrom<DataType>(d_);
        CqlCode f_ = this.Male__finding_(context);
        string g_ = f_?.code;
        bool? h_ = context.Operators.Equal(e_, g_);
        if (h_ ?? false)
        {
            decimal? o_ = context.Operators.ConvertIntegerToDecimal(142);
            CqlQuantity p_ = this.indexCreatinine(context, QualifyingEncounter);
            decimal? q_ = p_?.value;
            decimal? r_ = context.Operators.Divide(q_, 0.9m);
            decimal? s_ = context.Operators.ConvertIntegerToDecimal(1);
            decimal?[] t_ = [
                r_,
                s_,
            ];
            decimal? u_ = context.Operators.Min<decimal?>((IEnumerable<decimal?>)t_);
            decimal? v_ = context.Operators.Negate(0.302m);
            decimal? w_ = context.Operators.Power(u_, v_);
            decimal? x_ = context.Operators.Multiply(o_, w_);
            decimal? y_ = context.Operators.Max<decimal?>((IEnumerable<decimal?>)t_);
            decimal? z_ = context.Operators.Negate(1.200m);
            decimal? aa_ = context.Operators.Power(y_, z_);
            decimal? ab_ = context.Operators.Multiply(x_, aa_);
            Patient ac_ = this.Patient(context);
            Date ad_ = ac_?.BirthDateElement;
            string ae_ = ad_?.Value;
            CqlDateTime af_ = context.Operators.ConvertStringToDateTime(ae_);
            CqlInterval<CqlDateTime> ag_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime ah_ = context.Operators.Start(ag_);
            int? ai_ = context.Operators.CalculateAgeAt(af_, ah_, "year");
            decimal? aj_ = context.Operators.ConvertIntegerToDecimal(ai_);
            decimal? ak_ = context.Operators.Power(0.9938m, aj_);
            decimal? al_ = context.Operators.Multiply(ab_, ak_);
            return al_;
        }
        else
        {
            return default;
        }
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
            string h_ = LabTestsLow?.CrEncInPtId;
            string i_ = (QualifyingEncounter is Resource
                ? (QualifyingEncounter as Resource).IdElement
                : default)?.Value;
            bool? j_ = context.Operators.Equal(h_, i_);

            bool? k_() {
                CqlDateTime l_ = LabTestsLow?.CrLabTime;
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime p_ = context.Operators.Add(n_, o_);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
                bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, (string)default);
                return (bool?)((CqlBoolean)r_);
            }

            return (bool?)(/* CQL 'and' (303:9-304:188) */ ((CqlBoolean)j_
                && (CqlBoolean)k_()));
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity s_ = @this?.CrLabResult;
            return !((bool?)(s_ is null));
        }


        CqlQuantity e_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity t_ = @this?.CrLabResult;
            return t_;
        }

        IEnumerable<CqlQuantity> f_ = context.Operators.WhereSelect<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(c_, d_, e_);
        CqlQuantity g_ = context.Operators.Min<CqlQuantity>(f_);
        return g_;
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
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? l_ = (CqlTupleMetadata_GiiGRATBZEQfMLdbZgPRgTeRJ, _valueTuple.Item1, _valueTuple.Item2);
            return l_;
        }


        bool? f_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? tuple_ccccqpjvqogtctjhtilehkfoj) {
            object m_;
            DataType u_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            bool w_ = v_ is CqlDateTime;
            if (w_)
            {
                m_ = v_ as CqlDateTime;
            }
            else
            {
                if (w_)
                {
                    m_ = v_ as CqlDateTime;
                }
                else
                {
                    bool x_ = v_ is CqlInterval<CqlDateTime>;
                    if (x_)
                    {
                        m_ = v_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        m_ = null;
                    }
                }
            }
            CqlDateTime n_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
            CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter);
            bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);

            bool? q_() {
                Code<ObservationStatus> y_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.StatusElement;
                ObservationStatus? z_ = y_?.Value;
                string aa_ = context.Operators.Convert<string>(z_);
                string[] ab_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);
                return (bool?)((CqlBoolean)ac_);
            }


            bool? r_() {
                DataType ad_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                string af_ = (ae_ as CqlQuantity)?.unit;
                bool? ag_ = context.Operators.Equal(af_, "mg/dL");
                return (bool?)((CqlBoolean)ag_);
            }


            bool? s_() {
                DataType ah_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                return (bool?)((CqlBoolean)(!((bool?)(ai_ is null))));
            }


            bool? t_() {
                DataType aj_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                CqlQuantity al_ = context.Operators.Quantity(0m, "mg/dL");
                bool? am_ = context.Operators.Greater(ak_ as CqlQuantity, al_);
                return (bool?)((CqlBoolean)am_);
            }

            return (bool?)(/* CQL 'and' (233:5-238:60) */ (/* CQL 'and' (233:11-237:48) */ (/* CQL 'and' (233:11-236:32) */ (/* CQL 'and' (233:11-235:76) */ (/* CQL 'and' (233:11-234:47) */ ((CqlBoolean)p_
                && (CqlBoolean)(QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation)))
                && (CqlBoolean)q_())
                && (CqlBoolean)r_())
                && (CqlBoolean)s_())
                && (CqlBoolean)t_()));
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?> g_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?>(d_, e_, f_);

        (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? h_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? tuple_ccccqpjvqogtctjhtilehkfoj) {
            Id an_ = tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter?.IdElement;
            string ao_ = an_?.Value;
            CqlInterval<CqlDateTime> ap_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter);
            Id aq_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IdElement;
            string ar_ = aq_?.Value;
            object as_;
            if ((QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation)) ?? false)
            {
                as_ = "laboratory";
            }
            else
            {
                bool? bj_ = QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation);
                as_ = bj_;
            }
            List<CodeableConcept> at_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Category;

            CqlConcept au_(CodeableConcept @this) {
                CqlConcept bk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bk_;
            }

            IEnumerable<CqlConcept> av_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)at_, au_);
            Code<ObservationStatus> aw_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.StatusElement;
            ObservationStatus? ax_ = aw_?.Value;
            string ay_ = context.Operators.Convert<string>(ax_);
            DataType az_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
            string bb_ = (ba_ as CqlQuantity)?.unit;
            decimal? bc_ = (ba_ as CqlQuantity)?.value;
            object bd_;
            DataType bl_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
            bool bn_ = bm_ is CqlDateTime;
            if (bn_)
            {
                bd_ = bm_ as CqlDateTime;
            }
            else
            {
                if (bn_)
                {
                    bd_ = bm_ as CqlDateTime;
                }
                else
                {
                    bool bo_ = bm_ is CqlInterval<CqlDateTime>;
                    if (bo_)
                    {
                        bd_ = bm_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bd_ = null;
                    }
                }
            }
            CqlDateTime be_ = QICoreCommon_4_0_000.Instance.earliest(context, bd_);
            Instant bf_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IssuedElement;
            DateTimeOffset? bg_ = bf_?.Value;
            CqlDateTime bh_ = context.Operators.Convert<CqlDateTime>(bg_);
            (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? bi_ = (CqlTupleMetadata_EROdcjJjSdFbfXChfKbYbOdDN, ao_, ap_, ar_, as_, av_, ay_, ba_ as CqlQuantity, bb_, bc_, be_, bh_);
            return bi_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?, (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(g_, h_);

        object j_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime bp_ = @this?.CrLabTime;
            return bp_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> k_ = context.Operators.SortBy<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
        return k_;
    }


    [CqlFunctionDefinition("firstSerumCreatinineIn48Hours")]
    public IEnumerable<CqlQuantity> firstSerumCreatinineIn48Hours(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_By_Time(context);

        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests) {
            CqlDateTime f_ = this.earliestSerumCreatinineTimeIn48Hours(context, QualifyingEncounter);
            CqlDateTime g_ = LabTests?.CrLabTime;
            bool? h_ = context.Operators.Equal(f_, g_);
            return h_;
        }


        CqlQuantity c_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests) {
            CqlQuantity i_ = LabTests?.CrLabResult;
            return i_ as CqlQuantity;
        }

        IEnumerable<CqlQuantity> d_ = context.Operators.WhereSelect<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(a_, b_, c_);
        IEnumerable<CqlQuantity> e_ = context.Operators.Distinct<CqlQuantity>(d_);
        return e_;
    }


    [CqlFunctionDefinition("earliestSerumCreatinineTimeIn48Hours")]
    public CqlDateTime earliestSerumCreatinineTimeIn48Hours(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_By_Time(context);

        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests48) {
            string h_ = LabTests48?.CrEncInPtId;
            string i_ = (QualifyingEncounter is Resource
                ? (QualifyingEncounter as Resource).IdElement
                : default)?.Value;
            bool? j_ = context.Operators.Equal(h_, i_);

            bool? k_() {
                CqlDateTime l_ = LabTests48?.CrLabTime;
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime p_ = context.Operators.Add(n_, o_);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
                bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, (string)default);
                return (bool?)((CqlBoolean)r_);
            }

            return (bool?)(/* CQL 'and' (319:11-320:189) */ ((CqlBoolean)j_
                && (CqlBoolean)k_()));
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime s_ = @this?.CrLabTime;
            return !((bool?)(s_ is null));
        }


        CqlDateTime e_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime t_ = @this?.CrLabTime;
            return t_;
        }

        IEnumerable<CqlDateTime> f_ = context.Operators.WhereSelect<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlDateTime>(c_, d_, e_);
        CqlDateTime g_ = context.Operators.Min<CqlDateTime>(f_);
        return g_;
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

            bool? e_() {
                decimal? f_ = this.maleeGFR(context, QualifyingEncounter);
                decimal? g_ = context.Operators.ConvertIntegerToDecimal(60);
                bool? h_ = context.Operators.Less(f_ as decimal?, g_);
                return (bool?)((CqlBoolean)h_);
            }

            return (bool?)(/* CQL 'and' (104:5-105:60) */ ((CqlBoolean)(!((bool?)(d_ is null)))
                && (CqlBoolean)e_()));
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("femaleeGFR")]
    public decimal? femaleeGFR(CqlContext context, Encounter QualifyingEncounter)
    {
        List<Extension> a_;
        Patient i_ = this.Patient(context);
        bool j_ = i_ is DomainResource;
        if (j_)
        {
            a_ = (i_ as DomainResource).Extension;
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension @this) {
            FhirUri k_ = @this?.UrlElement;
            string l_ = FHIRHelpers_4_4_000.Instance.ToString(context, k_);
            bool? m_ = context.Operators.Equal(l_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
            return m_;
        }


        DataType c_(Extension @this) {
            DataType n_ = @this?.Value;
            return n_;
        }

        IEnumerable<DataType> d_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)a_, b_, c_);
        DataType e_ = context.Operators.SingletonFrom<DataType>(d_);
        CqlCode f_ = this.Female__finding_(context);
        string g_ = f_?.code;
        bool? h_ = context.Operators.Equal(e_, g_);
        if (h_ ?? false)
        {
            decimal? o_ = context.Operators.ConvertIntegerToDecimal(142);
            CqlQuantity p_ = this.indexCreatinine(context, QualifyingEncounter);
            decimal? q_ = p_?.value;
            decimal? r_ = context.Operators.Divide(q_, 0.7m);
            decimal? s_ = context.Operators.ConvertIntegerToDecimal(1);
            decimal?[] t_ = [
                r_,
                s_,
            ];
            decimal? u_ = context.Operators.Min<decimal?>((IEnumerable<decimal?>)t_);
            decimal? v_ = context.Operators.Negate(0.241m);
            decimal? w_ = context.Operators.Power(u_, v_);
            decimal? x_ = context.Operators.Multiply(o_, w_);
            decimal? y_ = context.Operators.Max<decimal?>((IEnumerable<decimal?>)t_);
            decimal? z_ = context.Operators.Negate(1.200m);
            decimal? aa_ = context.Operators.Power(y_, z_);
            decimal? ab_ = context.Operators.Multiply(x_, aa_);
            Patient ac_ = this.Patient(context);
            Date ad_ = ac_?.BirthDateElement;
            string ae_ = ad_?.Value;
            CqlDateTime af_ = context.Operators.ConvertStringToDateTime(ae_);
            CqlInterval<CqlDateTime> ag_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime ah_ = context.Operators.Start(ag_);
            int? ai_ = context.Operators.CalculateAgeAt(af_, ah_, "year");
            decimal? aj_ = context.Operators.ConvertIntegerToDecimal(ai_);
            decimal? ak_ = context.Operators.Power(0.9938m, aj_);
            decimal? al_ = context.Operators.Multiply(ab_, ak_);
            decimal? am_ = context.Operators.Multiply(al_, 1.012m);
            return am_;
        }
        else
        {
            return default;
        }
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

            bool? e_() {
                decimal? f_ = this.femaleeGFR(context, QualifyingEncounter);
                decimal? g_ = context.Operators.ConvertIntegerToDecimal(60);
                bool? h_ = context.Operators.Less(f_ as decimal?, g_);
                return (bool?)((CqlBoolean)h_);
            }

            return (bool?)(/* CQL 'and' (99:5-100:62) */ ((CqlBoolean)(!((bool?)(d_ is null)))
                && (CqlBoolean)e_()));
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
            string h_ = LabTests?.CrEncInPtId;
            string i_ = (QualifyingEncounter is Resource
                ? (QualifyingEncounter as Resource).IdElement
                : default)?.Value;
            bool? j_ = context.Operators.Equal(h_, i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity k_ = @this?.CrLabResult;
            return !((bool?)(k_ is null));
        }


        CqlQuantity e_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity l_ = @this?.CrLabResult;
            return l_;
        }

        IEnumerable<CqlQuantity> f_ = context.Operators.WhereSelect<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(c_, d_, e_);
        CqlQuantity g_ = context.Operators.Min<CqlQuantity>(f_);
        return g_;
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
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? j_ = (CqlTupleMetadata_FWVGLDcQEISFGIdVNGEWPHUFV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? f_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen) {
            Code<ObservationStatus> k_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.StatusElement;
            ObservationStatus? l_ = k_?.Value;
            string m_ = context.Operators.Convert<string>(l_);
            string[] n_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);

            bool? p_() {
                Code<ObservationStatus> y_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.StatusElement;
                ObservationStatus? z_ = y_?.Value;
                string aa_ = context.Operators.Convert<string>(z_);
                string[] ab_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);
                return (bool?)((CqlBoolean)ac_);
            }


            bool? q_() {
                DataType ad_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                DataType af_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                CqlQuantity ah_ = context.Operators.Subtract(ae_ as CqlQuantity, ag_ as CqlQuantity);
                CqlQuantity ai_ = context.Operators.Quantity(0.299m, "mg/dL");
                bool? aj_ = context.Operators.Greater(ah_, ai_);
                return (bool?)((CqlBoolean)aj_);
            }


            bool? r_() {
                DataType ak_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlQuantity am_ = this.lowestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? an_ = context.Operators.Equal(al_ as CqlQuantity, am_);
                return (bool?)((CqlBoolean)an_);
            }


            bool? s_() {
                object ao_;
                DataType ay_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                bool ba_ = az_ is CqlDateTime;
                if (ba_)
                {
                    ao_ = az_ as CqlDateTime;
                }
                else
                {
                    if (ba_)
                    {
                        ao_ = az_ as CqlDateTime;
                    }
                    else
                    {
                        bool bb_ = az_ is CqlInterval<CqlDateTime>;
                        if (bb_)
                        {
                            ao_ = az_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ao_ = null;
                        }
                    }
                }
                CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_);
                object aq_;
                DataType bc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                bool be_ = bd_ is CqlDateTime;
                if (be_)
                {
                    aq_ = bd_ as CqlDateTime;
                }
                else
                {
                    if (be_)
                    {
                        aq_ = bd_ as CqlDateTime;
                    }
                    else
                    {
                        bool bf_ = bd_ is CqlInterval<CqlDateTime>;
                        if (bf_)
                        {
                            aq_ = bd_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            aq_ = null;
                        }
                    }
                }
                CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                CqlQuantity as_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime at_ = context.Operators.Subtract(ar_, as_);
                object au_;
                DataType bg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                bool bi_ = bh_ is CqlDateTime;
                if (bi_)
                {
                    au_ = bh_ as CqlDateTime;
                }
                else
                {
                    if (bi_)
                    {
                        au_ = bh_ as CqlDateTime;
                    }
                    else
                    {
                        bool bj_ = bh_ is CqlInterval<CqlDateTime>;
                        if (bj_)
                        {
                            au_ = bh_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            au_ = null;
                        }
                    }
                }
                CqlDateTime av_ = QICoreCommon_4_0_000.Instance.earliest(context, au_);
                CqlInterval<CqlDateTime> aw_ = context.Operators.Interval(at_, av_, true, true);
                bool? ax_ = context.Operators.In<CqlDateTime>(ap_, aw_, (string)default);
                return (bool?)((CqlBoolean)ax_);
            }


            bool? t_() {
                object bk_;
                DataType bo_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                bool bq_ = bp_ is CqlDateTime;
                if (bq_)
                {
                    bk_ = bp_ as CqlDateTime;
                }
                else
                {
                    if (bq_)
                    {
                        bk_ = bp_ as CqlDateTime;
                    }
                    else
                    {
                        bool br_ = bp_ is CqlInterval<CqlDateTime>;
                        if (br_)
                        {
                            bk_ = bp_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bk_ = null;
                        }
                    }
                }
                CqlDateTime bl_ = QICoreCommon_4_0_000.Instance.earliest(context, bk_);
                CqlInterval<CqlDateTime> bm_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? bn_ = context.Operators.In<CqlDateTime>(bl_, bm_, (string)default);
                return (bool?)((CqlBoolean)bn_);
            }


            bool? u_() {
                object bs_;
                DataType ca_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool cc_ = cb_ is CqlDateTime;
                if (cc_)
                {
                    bs_ = cb_ as CqlDateTime;
                }
                else
                {
                    if (cc_)
                    {
                        bs_ = cb_ as CqlDateTime;
                    }
                    else
                    {
                        bool cd_ = cb_ is CqlInterval<CqlDateTime>;
                        if (cd_)
                        {
                            bs_ = cb_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bs_ = null;
                        }
                    }
                }
                CqlDateTime bt_ = QICoreCommon_4_0_000.Instance.earliest(context, bs_);
                CqlInterval<CqlDateTime> bu_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlDateTime bv_ = context.Operators.Start(bu_);
                CqlQuantity bw_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime bx_ = context.Operators.Add(bv_, bw_);
                CqlInterval<CqlDateTime> by_ = context.Operators.Interval(bv_, bx_, true, true);
                bool? bz_ = context.Operators.In<CqlDateTime>(bt_, by_, (string)default);
                return (bool?)((CqlBoolean)bz_);
            }


            bool? v_() {
                object ce_;
                DataType ci_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                bool ck_ = cj_ is CqlDateTime;
                if (ck_)
                {
                    ce_ = cj_ as CqlDateTime;
                }
                else
                {
                    if (ck_)
                    {
                        ce_ = cj_ as CqlDateTime;
                    }
                    else
                    {
                        bool cl_ = cj_ is CqlInterval<CqlDateTime>;
                        if (cl_)
                        {
                            ce_ = cj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ce_ = null;
                        }
                    }
                }
                CqlDateTime cf_ = QICoreCommon_4_0_000.Instance.earliest(context, ce_);
                CqlInterval<CqlDateTime> cg_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? ch_ = context.Operators.In<CqlDateTime>(cf_, cg_, (string)default);
                return (bool?)((CqlBoolean)ch_);
            }


            bool? w_() {
                object cm_;
                DataType cu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                bool cw_ = cv_ is CqlDateTime;
                if (cw_)
                {
                    cm_ = cv_ as CqlDateTime;
                }
                else
                {
                    if (cw_)
                    {
                        cm_ = cv_ as CqlDateTime;
                    }
                    else
                    {
                        bool cx_ = cv_ is CqlInterval<CqlDateTime>;
                        if (cx_)
                        {
                            cm_ = cv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            cm_ = null;
                        }
                    }
                }
                CqlDateTime cn_ = QICoreCommon_4_0_000.Instance.earliest(context, cm_);
                CqlInterval<CqlDateTime> co_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlDateTime cp_ = context.Operators.Start(co_);
                CqlQuantity cq_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime cr_ = context.Operators.Add(cp_, cq_);
                CqlInterval<CqlDateTime> cs_ = context.Operators.Interval(cp_, cr_, true, true);
                bool? ct_ = context.Operators.In<CqlDateTime>(cn_, cs_, (string)default);
                return (bool?)((CqlBoolean)ct_);
            }


            bool? x_() {
                Id cy_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
                string cz_ = cy_?.Value;
                Id da_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
                string db_ = da_?.Value;
                bool? dc_ = context.Operators.Equal(cz_, db_);
                return (bool?)((CqlBoolean)!dc_);
            }

            return (bool?)(/* CQL 'and' (119:5-128:73) */ (/* CQL 'and' (119:11-127:150) */ (/* CQL 'and' (119:11-126:80) */ (/* CQL 'and' (119:11-125:145) */ (/* CQL 'and' (119:11-124:75) */ (/* CQL 'and' (119:11-123:135) */ (/* CQL 'and' (119:11-122:96) */ (/* CQL 'and' (119:11-121:130) */ (/* CQL 'and' (119:11-120:85) */ ((CqlBoolean)o_
                && (CqlBoolean)p_())
                && (CqlBoolean)q_())
                && (CqlBoolean)r_())
                && (CqlBoolean)s_())
                && (CqlBoolean)t_())
                && (CqlBoolean)u_())
                && (CqlBoolean)v_())
                && (CqlBoolean)w_())
                && (CqlBoolean)x_()));
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?> g_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?>(d_, e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen) => tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter;
        IEnumerable<Encounter> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?, Encounter>(g_, h_);
        return i_;
    }


    [CqlFunctionDefinition("earliestSerumCreatinineResult")]
    public IEnumerable<CqlQuantity> earliestSerumCreatinineResult(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_By_Time(context);

        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests) {
            CqlDateTime f_ = this.earliestSerumCreatinineTime(context, QualifyingEncounter);
            CqlDateTime g_ = LabTests?.CrLabTime;
            bool? h_ = context.Operators.Equal(f_, g_);
            return h_;
        }


        CqlQuantity c_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests) {
            CqlQuantity i_ = LabTests?.CrLabResult;
            return i_ as CqlQuantity;
        }

        IEnumerable<CqlQuantity> d_ = context.Operators.WhereSelect<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(a_, b_, c_);
        IEnumerable<CqlQuantity> e_ = context.Operators.Distinct<CqlQuantity>(d_);
        return e_;
    }


    [CqlFunctionDefinition("earliestSerumCreatinineTime")]
    public CqlDateTime earliestSerumCreatinineTime(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_By_Time(context);

        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTestsEarly) {
            string h_ = LabTestsEarly?.CrEncInPtId;
            string i_ = (QualifyingEncounter is Resource
                ? (QualifyingEncounter as Resource).IdElement
                : default)?.Value;
            bool? j_ = context.Operators.Equal(h_, i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime k_ = @this?.CrLabTime;
            return !((bool?)(k_ is null));
        }


        CqlDateTime e_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime l_ = @this?.CrLabTime;
            return l_;
        }

        IEnumerable<CqlDateTime> f_ = context.Operators.WhereSelect<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlDateTime>(c_, d_, e_);
        CqlDateTime g_ = context.Operators.Min<CqlDateTime>(f_);
        return g_;
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
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? j_ = (CqlTupleMetadata_FWVGLDcQEISFGIdVNGEWPHUFV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? f_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen) {
            Code<ObservationStatus> k_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.StatusElement;
            ObservationStatus? l_ = k_?.Value;
            string m_ = context.Operators.Convert<string>(l_);
            string[] n_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);

            bool? p_() {
                Code<ObservationStatus> y_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.StatusElement;
                ObservationStatus? z_ = y_?.Value;
                string aa_ = context.Operators.Convert<string>(z_);
                string[] ab_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);
                return (bool?)((CqlBoolean)ac_);
            }


            bool? q_() {
                DataType ad_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                DataType af_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                CqlQuantity ah_ = context.Operators.Subtract(ae_ as CqlQuantity, ag_ as CqlQuantity);
                CqlQuantity ai_ = context.Operators.Quantity(0.299m, "mg/dL");
                bool? aj_ = context.Operators.Greater(ah_, ai_);
                return (bool?)((CqlBoolean)aj_);
            }


            bool? r_() {
                DataType ak_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                IEnumerable<CqlQuantity> am_ = this.earliestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlQuantity an_ = context.Operators.SingletonFrom<CqlQuantity>(am_);
                bool? ao_ = context.Operators.Equal(al_ as CqlQuantity, an_);
                return (bool?)((CqlBoolean)ao_);
            }


            bool? s_() {
                object ap_;
                DataType az_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlDateTime;
                if (bb_)
                {
                    ap_ = ba_ as CqlDateTime;
                }
                else
                {
                    if (bb_)
                    {
                        ap_ = ba_ as CqlDateTime;
                    }
                    else
                    {
                        bool bc_ = ba_ is CqlInterval<CqlDateTime>;
                        if (bc_)
                        {
                            ap_ = ba_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ap_ = null;
                        }
                    }
                }
                CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
                object ar_;
                DataType bd_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                bool bf_ = be_ is CqlDateTime;
                if (bf_)
                {
                    ar_ = be_ as CqlDateTime;
                }
                else
                {
                    if (bf_)
                    {
                        ar_ = be_ as CqlDateTime;
                    }
                    else
                    {
                        bool bg_ = be_ is CqlInterval<CqlDateTime>;
                        if (bg_)
                        {
                            ar_ = be_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ar_ = null;
                        }
                    }
                }
                CqlDateTime as_ = QICoreCommon_4_0_000.Instance.earliest(context, ar_);
                CqlQuantity at_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime au_ = context.Operators.Subtract(as_, at_);
                object av_;
                DataType bh_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlDateTime;
                if (bj_)
                {
                    av_ = bi_ as CqlDateTime;
                }
                else
                {
                    if (bj_)
                    {
                        av_ = bi_ as CqlDateTime;
                    }
                    else
                    {
                        bool bk_ = bi_ is CqlInterval<CqlDateTime>;
                        if (bk_)
                        {
                            av_ = bi_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            av_ = null;
                        }
                    }
                }
                CqlDateTime aw_ = QICoreCommon_4_0_000.Instance.earliest(context, av_);
                CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(au_, aw_, true, true);
                bool? ay_ = context.Operators.In<CqlDateTime>(aq_, ax_, (string)default);
                return (bool?)((CqlBoolean)ay_);
            }


            bool? t_() {
                object bl_;
                DataType bp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                bool br_ = bq_ is CqlDateTime;
                if (br_)
                {
                    bl_ = bq_ as CqlDateTime;
                }
                else
                {
                    if (br_)
                    {
                        bl_ = bq_ as CqlDateTime;
                    }
                    else
                    {
                        bool bs_ = bq_ is CqlInterval<CqlDateTime>;
                        if (bs_)
                        {
                            bl_ = bq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bl_ = null;
                        }
                    }
                }
                CqlDateTime bm_ = QICoreCommon_4_0_000.Instance.earliest(context, bl_);
                CqlInterval<CqlDateTime> bn_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? bo_ = context.Operators.In<CqlDateTime>(bm_, bn_, (string)default);
                return (bool?)((CqlBoolean)bo_);
            }


            bool? u_() {
                object bt_;
                DataType cb_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                bool cd_ = cc_ is CqlDateTime;
                if (cd_)
                {
                    bt_ = cc_ as CqlDateTime;
                }
                else
                {
                    if (cd_)
                    {
                        bt_ = cc_ as CqlDateTime;
                    }
                    else
                    {
                        bool ce_ = cc_ is CqlInterval<CqlDateTime>;
                        if (ce_)
                        {
                            bt_ = cc_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bt_ = null;
                        }
                    }
                }
                CqlDateTime bu_ = QICoreCommon_4_0_000.Instance.earliest(context, bt_);
                CqlInterval<CqlDateTime> bv_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlDateTime bw_ = context.Operators.Start(bv_);
                CqlQuantity bx_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime by_ = context.Operators.Add(bw_, bx_);
                CqlInterval<CqlDateTime> bz_ = context.Operators.Interval(bw_, by_, true, true);
                bool? ca_ = context.Operators.In<CqlDateTime>(bu_, bz_, (string)default);
                return (bool?)((CqlBoolean)ca_);
            }


            bool? v_() {
                object cf_;
                DataType cj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                bool cl_ = ck_ is CqlDateTime;
                if (cl_)
                {
                    cf_ = ck_ as CqlDateTime;
                }
                else
                {
                    if (cl_)
                    {
                        cf_ = ck_ as CqlDateTime;
                    }
                    else
                    {
                        bool cm_ = ck_ is CqlInterval<CqlDateTime>;
                        if (cm_)
                        {
                            cf_ = ck_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            cf_ = null;
                        }
                    }
                }
                CqlDateTime cg_ = QICoreCommon_4_0_000.Instance.earliest(context, cf_);
                CqlInterval<CqlDateTime> ch_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? ci_ = context.Operators.In<CqlDateTime>(cg_, ch_, (string)default);
                return (bool?)((CqlBoolean)ci_);
            }


            bool? w_() {
                object cn_;
                DataType cv_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                bool cx_ = cw_ is CqlDateTime;
                if (cx_)
                {
                    cn_ = cw_ as CqlDateTime;
                }
                else
                {
                    if (cx_)
                    {
                        cn_ = cw_ as CqlDateTime;
                    }
                    else
                    {
                        bool cy_ = cw_ is CqlInterval<CqlDateTime>;
                        if (cy_)
                        {
                            cn_ = cw_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            cn_ = null;
                        }
                    }
                }
                CqlDateTime co_ = QICoreCommon_4_0_000.Instance.earliest(context, cn_);
                CqlInterval<CqlDateTime> cp_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlDateTime cq_ = context.Operators.Start(cp_);
                CqlQuantity cr_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime cs_ = context.Operators.Add(cq_, cr_);
                CqlInterval<CqlDateTime> ct_ = context.Operators.Interval(cq_, cs_, true, true);
                bool? cu_ = context.Operators.In<CqlDateTime>(co_, ct_, (string)default);
                return (bool?)((CqlBoolean)cu_);
            }


            bool? x_() {
                Id cz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
                string da_ = cz_?.Value;
                Id db_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
                string dc_ = db_?.Value;
                bool? dd_ = context.Operators.Equal(da_, dc_);
                return (bool?)((CqlBoolean)!dd_);
            }

            return (bool?)(/* CQL 'and' (139:5-148:73) */ (/* CQL 'and' (139:11-147:145) */ (/* CQL 'and' (139:11-146:80) */ (/* CQL 'and' (139:11-145:150) */ (/* CQL 'and' (139:11-144:75) */ (/* CQL 'and' (139:11-143:135) */ (/* CQL 'and' (139:11-142:125) */ (/* CQL 'and' (139:11-141:130) */ (/* CQL 'and' (139:11-140:85) */ ((CqlBoolean)o_
                && (CqlBoolean)p_())
                && (CqlBoolean)q_())
                && (CqlBoolean)r_())
                && (CqlBoolean)s_())
                && (CqlBoolean)t_())
                && (CqlBoolean)u_())
                && (CqlBoolean)v_())
                && (CqlBoolean)w_())
                && (CqlBoolean)x_()));
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?> g_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?>(d_, e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen) => tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter;
        IEnumerable<Encounter> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?, Encounter>(g_, h_);
        return i_;
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
            (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? j_ = (CqlTupleMetadata_BWWSXdXSFIJQjJNcdEVJKZEGj, _valueTuple.Item1, _valueTuple.Item2);
            return j_;
        }


        bool? f_((CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? tuple_bwwsxdxsfijqjjncdevjkzegj) {
            Code<EventStatus> k_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.StatusElement;
            EventStatus? l_ = k_?.Value;
            string m_ = context.Operators.Convert<string>(l_);
            bool? n_ = context.Operators.Equal(m_, "completed");

            bool? o_() {
                object q_;
                DataType z_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                bool ab_ = aa_ is CqlDateTime;
                if (ab_)
                {
                    q_ = aa_ as CqlDateTime;
                }
                else
                {
                    bool ac_ = aa_ is CqlQuantity;
                    if (ac_)
                    {
                        q_ = aa_ as CqlQuantity;
                    }
                    else
                    {
                        bool ad_ = aa_ is CqlInterval<CqlDateTime>;
                        if (ad_)
                        {
                            q_ = aa_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ae_ = aa_ is CqlInterval<CqlQuantity>;
                            if (ae_)
                            {
                                q_ = aa_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                q_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlInterval<CqlDateTime> t_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlQuantity v_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime w_ = context.Operators.Add(u_, v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);
                bool? y_ = context.Operators.In<CqlDateTime>(s_, x_, (string)default);
                return (bool?)((CqlBoolean)y_);
            }


            bool? p_() {
                object af_;
                DataType ak_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool am_ = al_ is CqlDateTime;
                if (am_)
                {
                    af_ = al_ as CqlDateTime;
                }
                else
                {
                    bool an_ = al_ is CqlQuantity;
                    if (an_)
                    {
                        af_ = al_ as CqlQuantity;
                    }
                    else
                    {
                        bool ao_ = al_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            af_ = al_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ap_ = al_ is CqlInterval<CqlQuantity>;
                            if (ap_)
                            {
                                af_ = al_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                af_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                CqlDateTime ah_ = context.Operators.Start(ag_);
                CqlInterval<CqlDateTime> ai_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
                bool? aj_ = context.Operators.In<CqlDateTime>(ah_, ai_, (string)default);
                return (bool?)((CqlBoolean)aj_);
            }

            return (bool?)(/* CQL 'and' (163:5-165:87) */ (/* CQL 'and' (163:11-164:157) */ ((CqlBoolean)n_
                && (CqlBoolean)o_())
                && (CqlBoolean)p_()));
        }

        IEnumerable<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?> g_ = context.Operators.SelectWhere<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?>(d_, e_, f_);
        Encounter h_((CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? tuple_bwwsxdxsfijqjjncdevjkzegj) => tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter;
        IEnumerable<Encounter> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?, Encounter>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Serum Creatinine Normal")]
    public CqlQuantity Serum_Creatinine_Normal(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Serum_Creatinine_Normal, Serum_Creatinine_Normal_Compute);

    private const long _cacheIndex_Serum_Creatinine_Normal = 1994579657868827614L;

    private CqlQuantity Serum_Creatinine_Normal_Compute(CqlContext context)
    {
        List<Extension> a_;
        Patient i_ = this.Patient(context);
        bool j_ = i_ is DomainResource;
        if (j_)
        {
            a_ = (i_ as DomainResource).Extension;
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension @this) {
            FhirUri k_ = @this?.UrlElement;
            string l_ = FHIRHelpers_4_4_000.Instance.ToString(context, k_);
            bool? m_ = context.Operators.Equal(l_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
            return m_;
        }


        DataType c_(Extension @this) {
            DataType n_ = @this?.Value;
            return n_;
        }

        IEnumerable<DataType> d_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)a_, b_, c_);
        DataType e_ = context.Operators.SingletonFrom<DataType>(d_);
        CqlCode f_ = this.Female__finding_(context);
        string g_ = f_?.code;
        bool? h_ = context.Operators.Equal(e_, g_);
        if (h_ ?? false)
        {
            CqlQuantity o_ = context.Operators.Quantity(1.02m, "mg/dL");
            return o_;
        }
        else
        {
            CqlQuantity p_ = context.Operators.Quantity(1.18m, "mg/dL");
            return p_;
        }
    }


    [CqlFunctionDefinition("highestSerumCreatinineResult")]
    public CqlQuantity highestSerumCreatinineResult(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_By_Time(context);

        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests) {
            string h_ = LabTests?.CrEncInPtId;
            string i_ = (QualifyingEncounter is Resource
                ? (QualifyingEncounter as Resource).IdElement
                : default)?.Value;
            bool? j_ = context.Operators.Equal(h_, i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity k_ = @this?.CrLabResult;
            return !((bool?)(k_ is null));
        }


        CqlQuantity e_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity l_ = @this?.CrLabResult;
            return l_;
        }

        IEnumerable<CqlQuantity> f_ = context.Operators.WhereSelect<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(c_, d_, e_);
        CqlQuantity g_ = context.Operators.Max<CqlQuantity>(f_);
        return g_;
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
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? j_ = (CqlTupleMetadata_JeYVEdgebecHQGRICIKegVBi, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? f_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_gsqsgqbihalobloqrcccgdeiw) {
            DataType k_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Value;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            CqlQuantity m_ = this.Serum_Creatinine_Normal(context);
            bool? n_ = context.Operators.Greater(l_ as CqlQuantity, m_);

            bool? o_() {
                Code<ObservationStatus> x_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                return (bool?)((CqlBoolean)ab_);
            }


            bool? p_() {
                Code<ObservationStatus> ac_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.StatusElement;
                ObservationStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                return (bool?)((CqlBoolean)ag_);
            }


            bool? q_() {
                DataType ah_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Value;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlQuantity aj_ = this.highestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                bool? ak_ = context.Operators.Equal(ai_ as CqlQuantity, aj_);
                return (bool?)((CqlBoolean)ak_);
            }


            bool? r_() {
                DataType al_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Value;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                CqlQuantity an_ = this.lowestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                bool? ao_ = context.Operators.Equal(am_ as CqlQuantity, an_);
                return (bool?)((CqlBoolean)ao_);
            }


            bool? s_() {
                CqlQuantity ap_ = this.oneAndAHalfIncreaseInCreatinine(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                DataType aq_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Value;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                bool? as_ = context.Operators.GreaterOrEqual(ap_, ar_ as CqlQuantity);
                return (bool?)((CqlBoolean)as_);
            }


            bool? t_() {
                object at_;
                DataType be_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool bg_ = bf_ is CqlDateTime;
                if (bg_)
                {
                    at_ = bf_ as CqlDateTime;
                }
                else
                {
                    if (bg_)
                    {
                        at_ = bf_ as CqlDateTime;
                    }
                    else
                    {
                        bool bh_ = bf_ is CqlInterval<CqlDateTime>;
                        if (bh_)
                        {
                            at_ = bf_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            at_ = null;
                        }
                    }
                }
                CqlDateTime au_ = QICoreCommon_4_0_000.Instance.earliest(context, at_);
                object av_;
                DataType bi_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool bk_ = bj_ is CqlDateTime;
                if (bk_)
                {
                    av_ = bj_ as CqlDateTime;
                }
                else
                {
                    if (bk_)
                    {
                        av_ = bj_ as CqlDateTime;
                    }
                    else
                    {
                        bool bl_ = bj_ is CqlInterval<CqlDateTime>;
                        if (bl_)
                        {
                            av_ = bj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            av_ = null;
                        }
                    }
                }
                CqlDateTime aw_ = QICoreCommon_4_0_000.Instance.earliest(context, av_);
                CqlQuantity ax_ = context.Operators.Quantity(7m, "days");
                CqlDateTime ay_ = context.Operators.Subtract(aw_, ax_);
                object az_;
                DataType bm_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                bool bo_ = bn_ is CqlDateTime;
                if (bo_)
                {
                    az_ = bn_ as CqlDateTime;
                }
                else
                {
                    if (bo_)
                    {
                        az_ = bn_ as CqlDateTime;
                    }
                    else
                    {
                        bool bp_ = bn_ is CqlInterval<CqlDateTime>;
                        if (bp_)
                        {
                            az_ = bn_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            az_ = null;
                        }
                    }
                }
                CqlDateTime ba_ = QICoreCommon_4_0_000.Instance.earliest(context, az_);
                CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(ay_, ba_, true, false);
                bool? bc_ = context.Operators.In<CqlDateTime>(au_, bb_, (string)default);

                bool? bd_() {
                    object bq_;
                    DataType bs_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    bool bu_ = bt_ is CqlDateTime;
                    if (bu_)
                    {
                        bq_ = bt_ as CqlDateTime;
                    }
                    else
                    {
                        if (bu_)
                        {
                            bq_ = bt_ as CqlDateTime;
                        }
                        else
                        {
                            bool bv_ = bt_ is CqlInterval<CqlDateTime>;
                            if (bv_)
                            {
                                bq_ = bt_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bq_ = null;
                            }
                        }
                    }
                    CqlDateTime br_ = QICoreCommon_4_0_000.Instance.earliest(context, bq_);
                    return (bool?)((CqlBoolean)(!((bool?)(br_ is null))));
                }

                return (bool?)(/* CQL 'and' (269:11-269:76) */ ((CqlBoolean)bc_
                    && (CqlBoolean)bd_()));
            }


            bool? u_() {
                object bw_;
                DataType ca_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool cc_ = cb_ is CqlDateTime;
                if (cc_)
                {
                    bw_ = cb_ as CqlDateTime;
                }
                else
                {
                    if (cc_)
                    {
                        bw_ = cb_ as CqlDateTime;
                    }
                    else
                    {
                        bool cd_ = cb_ is CqlInterval<CqlDateTime>;
                        if (cd_)
                        {
                            bw_ = cb_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bw_ = null;
                        }
                    }
                }
                CqlDateTime bx_ = QICoreCommon_4_0_000.Instance.earliest(context, bw_);
                CqlInterval<CqlDateTime> by_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                bool? bz_ = context.Operators.In<CqlDateTime>(bx_, by_, (string)default);
                return (bool?)((CqlBoolean)bz_);
            }


            bool? v_() {
                object ce_;
                DataType co_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                bool cq_ = cp_ is CqlDateTime;
                if (cq_)
                {
                    ce_ = cp_ as CqlDateTime;
                }
                else
                {
                    if (cq_)
                    {
                        ce_ = cp_ as CqlDateTime;
                    }
                    else
                    {
                        bool cr_ = cp_ is CqlInterval<CqlDateTime>;
                        if (cr_)
                        {
                            ce_ = cp_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ce_ = null;
                        }
                    }
                }
                CqlDateTime cf_ = QICoreCommon_4_0_000.Instance.earliest(context, ce_);
                CqlInterval<CqlDateTime> cg_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                CqlDateTime ch_ = context.Operators.Start(cg_);
                CqlQuantity ci_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime cj_ = context.Operators.Add(ch_, ci_);
                CqlQuantity ck_ = context.Operators.Quantity(30m, "days");
                CqlDateTime cl_ = context.Operators.Add(ch_, ck_);
                CqlInterval<CqlDateTime> cm_ = context.Operators.Interval(cj_, cl_, true, true);
                bool? cn_ = context.Operators.In<CqlDateTime>(cf_, cm_, (string)default);
                return (bool?)((CqlBoolean)cn_);
            }


            bool? w_() {
                object cs_;
                DataType cw_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                bool cy_ = cx_ is CqlDateTime;
                if (cy_)
                {
                    cs_ = cx_ as CqlDateTime;
                }
                else
                {
                    if (cy_)
                    {
                        cs_ = cx_ as CqlDateTime;
                    }
                    else
                    {
                        bool cz_ = cx_ is CqlInterval<CqlDateTime>;
                        if (cz_)
                        {
                            cs_ = cx_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            cs_ = null;
                        }
                    }
                }
                CqlDateTime ct_ = QICoreCommon_4_0_000.Instance.earliest(context, cs_);
                CqlInterval<CqlDateTime> cu_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                bool? cv_ = context.Operators.In<CqlDateTime>(ct_, cu_, (string)default);
                return (bool?)((CqlBoolean)cv_);
            }

            return (bool?)(/* CQL 'and' (263:5-272:69) */ (/* CQL 'and' (263:11-271:149) */ (/* CQL 'and' (263:11-270:68) */ (/* CQL 'and' (263:11-269:76) */ (/* CQL 'and' (263:11-268:94) */ (/* CQL 'and' (263:11-267:89) */ (/* CQL 'and' (263:11-266:91) */ (/* CQL 'and' (263:11-265:74) */ (/* CQL 'and' (263:11-264:73) */ ((CqlBoolean)n_
                && (CqlBoolean)o_())
                && (CqlBoolean)p_())
                && (CqlBoolean)q_())
                && (CqlBoolean)r_())
                && (CqlBoolean)s_())
                && (CqlBoolean)t_())
                && (CqlBoolean)u_())
                && (CqlBoolean)v_())
                && (CqlBoolean)w_()));
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?> g_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?>(d_, e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_gsqsgqbihalobloqrcccgdeiw) => tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter;
        IEnumerable<Encounter> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?, Encounter>(g_, h_);
        return i_;
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
            (CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? j_ = (CqlTupleMetadata_BDjSiZCAhXcVgEETFRJVEHXOR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? f_((CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_bdjsizcahxcvgeetfrjvehxor) {
            DataType k_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Value;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            CqlQuantity m_ = this.Serum_Creatinine_Normal(context);
            bool? n_ = context.Operators.Greater(l_ as CqlQuantity, m_);

            bool? o_() {
                Code<ObservationStatus> x_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                return (bool?)((CqlBoolean)ab_);
            }


            bool? p_() {
                Code<ObservationStatus> ac_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.StatusElement;
                ObservationStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                return (bool?)((CqlBoolean)ag_);
            }


            bool? q_() {
                DataType ah_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Value;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlQuantity aj_ = this.highestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                bool? ak_ = context.Operators.Equal(ai_ as CqlQuantity, aj_);
                return (bool?)((CqlBoolean)ak_);
            }


            bool? r_() {
                DataType al_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Value;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                CqlQuantity an_ = this.lowestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                bool? ao_ = context.Operators.Equal(am_ as CqlQuantity, an_);
                return (bool?)((CqlBoolean)ao_);
            }


            bool? s_() {
                DataType ap_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Value;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                DataType ar_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Value;
                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                bool? at_ = context.Operators.GreaterOrEqual(aq_ as CqlQuantity, as_ as CqlQuantity);
                return (bool?)((CqlBoolean)at_);
            }


            bool? t_() {
                object au_;
                DataType bf_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    au_ = bg_ as CqlDateTime;
                }
                else
                {
                    if (bh_)
                    {
                        au_ = bg_ as CqlDateTime;
                    }
                    else
                    {
                        bool bi_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            au_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            au_ = null;
                        }
                    }
                }
                CqlDateTime av_ = QICoreCommon_4_0_000.Instance.earliest(context, au_);
                object aw_;
                DataType bj_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                bool bl_ = bk_ is CqlDateTime;
                if (bl_)
                {
                    aw_ = bk_ as CqlDateTime;
                }
                else
                {
                    if (bl_)
                    {
                        aw_ = bk_ as CqlDateTime;
                    }
                    else
                    {
                        bool bm_ = bk_ is CqlInterval<CqlDateTime>;
                        if (bm_)
                        {
                            aw_ = bk_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            aw_ = null;
                        }
                    }
                }
                CqlDateTime ax_ = QICoreCommon_4_0_000.Instance.earliest(context, aw_);
                CqlQuantity ay_ = context.Operators.Quantity(7m, "days");
                CqlDateTime az_ = context.Operators.Subtract(ax_, ay_);
                object ba_;
                DataType bn_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                bool bp_ = bo_ is CqlDateTime;
                if (bp_)
                {
                    ba_ = bo_ as CqlDateTime;
                }
                else
                {
                    if (bp_)
                    {
                        ba_ = bo_ as CqlDateTime;
                    }
                    else
                    {
                        bool bq_ = bo_ is CqlInterval<CqlDateTime>;
                        if (bq_)
                        {
                            ba_ = bo_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ba_ = null;
                        }
                    }
                }
                CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);
                CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(az_, bb_, true, false);
                bool? bd_ = context.Operators.In<CqlDateTime>(av_, bc_, (string)default);

                bool? be_() {
                    object br_;
                    DataType bt_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    bool bv_ = bu_ is CqlDateTime;
                    if (bv_)
                    {
                        br_ = bu_ as CqlDateTime;
                    }
                    else
                    {
                        if (bv_)
                        {
                            br_ = bu_ as CqlDateTime;
                        }
                        else
                        {
                            bool bw_ = bu_ is CqlInterval<CqlDateTime>;
                            if (bw_)
                            {
                                br_ = bu_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                br_ = null;
                            }
                        }
                    }
                    CqlDateTime bs_ = QICoreCommon_4_0_000.Instance.earliest(context, br_);
                    return (bool?)((CqlBoolean)(!((bool?)(bs_ is null))));
                }

                return (bool?)(/* CQL 'and' (182:11-182:76) */ ((CqlBoolean)bd_
                    && (CqlBoolean)be_()));
            }


            bool? u_() {
                object bx_;
                DataType cb_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                bool cd_ = cc_ is CqlDateTime;
                if (cd_)
                {
                    bx_ = cc_ as CqlDateTime;
                }
                else
                {
                    if (cd_)
                    {
                        bx_ = cc_ as CqlDateTime;
                    }
                    else
                    {
                        bool ce_ = cc_ is CqlInterval<CqlDateTime>;
                        if (ce_)
                        {
                            bx_ = cc_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bx_ = null;
                        }
                    }
                }
                CqlDateTime by_ = QICoreCommon_4_0_000.Instance.earliest(context, bx_);
                CqlInterval<CqlDateTime> bz_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                bool? ca_ = context.Operators.In<CqlDateTime>(by_, bz_, (string)default);
                return (bool?)((CqlBoolean)ca_);
            }


            bool? v_() {
                object cf_;
                DataType cp_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                bool cr_ = cq_ is CqlDateTime;
                if (cr_)
                {
                    cf_ = cq_ as CqlDateTime;
                }
                else
                {
                    if (cr_)
                    {
                        cf_ = cq_ as CqlDateTime;
                    }
                    else
                    {
                        bool cs_ = cq_ is CqlInterval<CqlDateTime>;
                        if (cs_)
                        {
                            cf_ = cq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            cf_ = null;
                        }
                    }
                }
                CqlDateTime cg_ = QICoreCommon_4_0_000.Instance.earliest(context, cf_);
                CqlInterval<CqlDateTime> ch_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                CqlDateTime ci_ = context.Operators.Start(ch_);
                CqlQuantity cj_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime ck_ = context.Operators.Add(ci_, cj_);
                CqlQuantity cl_ = context.Operators.Quantity(30m, "days");
                CqlDateTime cm_ = context.Operators.Add(ci_, cl_);
                CqlInterval<CqlDateTime> cn_ = context.Operators.Interval(ck_, cm_, true, true);
                bool? co_ = context.Operators.In<CqlDateTime>(cg_, cn_, (string)default);
                return (bool?)((CqlBoolean)co_);
            }


            bool? w_() {
                object ct_;
                DataType cx_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                bool cz_ = cy_ is CqlDateTime;
                if (cz_)
                {
                    ct_ = cy_ as CqlDateTime;
                }
                else
                {
                    if (cz_)
                    {
                        ct_ = cy_ as CqlDateTime;
                    }
                    else
                    {
                        bool da_ = cy_ is CqlInterval<CqlDateTime>;
                        if (da_)
                        {
                            ct_ = cy_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ct_ = null;
                        }
                    }
                }
                CqlDateTime cu_ = QICoreCommon_4_0_000.Instance.earliest(context, ct_);
                CqlInterval<CqlDateTime> cv_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                bool? cw_ = context.Operators.In<CqlDateTime>(cu_, cv_, (string)default);
                return (bool?)((CqlBoolean)cw_);
            }

            return (bool?)(/* CQL 'and' (176:5-185:69) */ (/* CQL 'and' (176:11-184:149) */ (/* CQL 'and' (176:11-183:68) */ (/* CQL 'and' (176:11-182:76) */ (/* CQL 'and' (176:11-181:93) */ (/* CQL 'and' (176:11-180:97) */ (/* CQL 'and' (176:11-179:99) */ (/* CQL 'and' (176:11-178:74) */ (/* CQL 'and' (176:11-177:73) */ ((CqlBoolean)n_
                && (CqlBoolean)o_())
                && (CqlBoolean)p_())
                && (CqlBoolean)q_())
                && (CqlBoolean)r_())
                && (CqlBoolean)s_())
                && (CqlBoolean)t_())
                && (CqlBoolean)u_())
                && (CqlBoolean)v_())
                && (CqlBoolean)w_()));
        }

        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?> g_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?>(d_, e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_bdjsizcahxcvgeetfrjvehxor) => tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine;
        IEnumerable<Encounter> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?, Encounter>(g_, h_);
        return i_;
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
                Period g_ = EncounterWithHighCreatinine?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                Period i_ = EncounterWithKidneyDialysis48HoursOrAfter?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, (string)default);
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            return !f_;
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
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.High_Risk_Diagnosis_for_AKI(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);

            bool? i_() {
                IEnumerable<Condition> k_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

                bool? l_(Condition @this) {
                    CodeableConcept q_ = @this?.Code;
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                    return !((bool?)(r_ is null));
                }


                CqlConcept m_(Condition @this) {
                    CodeableConcept s_ = @this?.Code;
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                    return t_;
                }

                IEnumerable<CqlConcept> n_ = context.Operators.WhereSelect<Condition, CqlConcept>(k_, l_, m_);
                CqlValueSet o_ = this.High_Risk_Diagnosis_for_AKI(context);
                bool? p_ = context.Operators.ConceptsInValueSet(n_, o_);
                return (bool?)((CqlBoolean)p_);
            }

            return (bool?)(/* CQL 'or' (194:5-196:5) */ ((CqlBoolean)h_
                || (CqlBoolean)i_()));
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
                Code<EventStatus> h_ = HighRiskProcedures?.StatusElement;
                EventStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                bool? k_ = context.Operators.Equal(j_, "completed");

                bool? l_() {
                    object m_;
                    DataType r_ = HighRiskProcedures?.Performed;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    bool t_ = s_ is CqlDateTime;
                    if (t_)
                    {
                        m_ = s_ as CqlDateTime;
                    }
                    else
                    {
                        bool u_ = s_ is CqlQuantity;
                        if (u_)
                        {
                            m_ = s_ as CqlQuantity;
                        }
                        else
                        {
                            bool v_ = s_ is CqlInterval<CqlDateTime>;
                            if (v_)
                            {
                                m_ = s_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool w_ = s_ is CqlInterval<CqlQuantity>;
                                if (w_)
                                {
                                    m_ = s_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    m_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                    CqlDateTime o_ = context.Operators.Start(n_);
                    CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                    bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
                    return (bool?)((CqlBoolean)q_);
                }

                return (bool?)(/* CQL 'and' (201:17-202:124) */ ((CqlBoolean)k_
                    && (CqlBoolean)l_()));
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
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
            (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? j_ = (CqlTupleMetadata_BWWSXdXSFIJQjJNcdEVJKZEGj, _valueTuple.Item1, _valueTuple.Item2);
            return j_;
        }


        bool? f_((CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? tuple_bwwsxdxsfijqjjncdevjkzegj) {
            object k_;
            DataType w_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            bool y_ = x_ is CqlDateTime;
            if (y_)
            {
                k_ = x_ as CqlDateTime;
            }
            else
            {
                bool z_ = x_ is CqlQuantity;
                if (z_)
                {
                    k_ = x_ as CqlQuantity;
                }
                else
                {
                    bool aa_ = x_ is CqlInterval<CqlDateTime>;
                    if (aa_)
                    {
                        k_ = x_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ab_ = x_ is CqlInterval<CqlQuantity>;
                        if (ab_)
                        {
                            k_ = x_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            k_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlQuantity p_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime q_ = context.Operators.Add(o_, p_);
            CqlDateTime r_ = context.Operators.End(n_);
            CqlInterval<CqlDateTime> s_ = context.Operators.Interval(q_, r_, true, true);
            bool? t_ = context.Operators.In<CqlDateTime>(m_, s_, (string)default);

            bool? u_() {
                object ac_;
                DataType ah_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool aj_ = ai_ is CqlDateTime;
                if (aj_)
                {
                    ac_ = ai_ as CqlDateTime;
                }
                else
                {
                    bool ak_ = ai_ is CqlQuantity;
                    if (ak_)
                    {
                        ac_ = ai_ as CqlQuantity;
                    }
                    else
                    {
                        bool al_ = ai_ is CqlInterval<CqlDateTime>;
                        if (al_)
                        {
                            ac_ = ai_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool am_ = ai_ is CqlInterval<CqlQuantity>;
                            if (am_)
                            {
                                ac_ = ai_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ac_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlInterval<CqlDateTime> af_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
                bool? ag_ = context.Operators.In<CqlDateTime>(ae_, af_, (string)default);
                return (bool?)((CqlBoolean)ag_);
            }


            bool? v_() {
                Code<EventStatus> an_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.StatusElement;
                EventStatus? ao_ = an_?.Value;
                string ap_ = context.Operators.Convert<string>(ao_);
                bool? aq_ = context.Operators.Equal(ap_, "completed");
                return (bool?)((CqlBoolean)aq_);
            }

            return (bool?)(/* CQL 'and' (216:5-218:39) */ (/* CQL 'and' (216:11-217:87) */ ((CqlBoolean)t_
                && (CqlBoolean)u_())
                && (CqlBoolean)v_()));
        }

        IEnumerable<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?> g_ = context.Operators.SelectWhere<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?>(d_, e_, f_);
        Encounter h_((CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? tuple_bwwsxdxsfijqjjncdevjkzegj) => tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter;
        IEnumerable<Encounter> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?, Encounter>(g_, h_);
        return i_;
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
                Period g_ = EncounterWithHighCreatinine?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                Period i_ = EncounterWithDialysisAfter48Hours?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, (string)default);
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            return !f_;
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
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            decimal? f_ = this.femaleeGFR(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, decimal? eGFR)? g_ = (CqlTupleMetadata_ChQZQhiCBOOJUfBhSOMPAPSKY, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, decimal? eGFR)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Estimated Glomerular Filtration Rate For Males")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Males(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Males, Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Males_Compute);

    private const long _cacheIndex_Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Males = -5465086837107700678L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> Risk_Variable_Estimated_Glomerular_Filtration_Rate_For_Males_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);

        (CqlTupleMetadata, string encounterId, decimal? eGFR)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            decimal? f_ = this.maleeGFR(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, decimal? eGFR)? g_ = (CqlTupleMetadata_ChQZQhiCBOOJUfBhSOMPAPSKY, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, decimal? eGFR)?>(a_, b_);
        return c_;
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
            (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? i_ = (CqlTupleMetadata_CUCPZLPbWZQEUULVJBALOjJbh, _valueTuple.Item1, _valueTuple.Item2);
            return i_;
        }


        bool? e_((CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? tuple_epwvnljjfhnvfarkifgamtzks) {
            Code<FinancialResourceStatusCodes> j_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.StatusElement;
            FinancialResourceStatusCodes? k_ = j_?.Value;
            Code<FinancialResourceStatusCodes> l_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(k_);
            bool? m_ = context.Operators.Equal(l_, "active");

            bool? n_() {
                Code<ClaimUseCode> p_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.UseElement;
                ClaimUseCode? q_ = p_?.Value;
                Code<ClaimUseCode> r_ = context.Operators.Convert<Code<ClaimUseCode>>(q_);
                bool? s_ = context.Operators.Equal(r_, "claim");
                return (bool?)((CqlBoolean)s_);
            }


            bool? o_() {
                List<Claim.ItemComponent> t_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Item;

                bool? u_(Claim.ItemComponent ClaimItem) {
                    List<ResourceReference> w_ = ClaimItem?.Encounter;
                    bool? x_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)w_, tuple_epwvnljjfhnvfarkifgamtzks?.QualifyingEncounter);

                    bool? y_() {
                        List<Claim.DiagnosisComponent> z_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Diagnosis;

                        bool? aa_(Claim.DiagnosisComponent Dx) {
                            PositiveInt ac_ = Dx?.SequenceElement;
                            int? ad_ = ac_?.Value;
                            List<Claim.ItemComponent> ae_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Item;

                            bool? af_(Claim.ItemComponent @this) {
                                List<PositiveInt> al_ = @this?.DiagnosisSequenceElement;

                                int? am_(PositiveInt @this) {
                                    int? ao_ = @this?.Value;
                                    return ao_;
                                }

                                IEnumerable<int?> an_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)al_, am_);
                                return !((bool?)(an_ is null));
                            }


                            IEnumerable<int?> ag_(Claim.ItemComponent @this) {
                                List<PositiveInt> ap_ = @this?.DiagnosisSequenceElement;

                                int? aq_(PositiveInt @this) {
                                    int? as_ = @this?.Value;
                                    return as_;
                                }

                                IEnumerable<int?> ar_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ap_, aq_);
                                return ar_;
                            }

                            IEnumerable<IEnumerable<int?>> ah_ = context.Operators.WhereSelect<Claim.ItemComponent, IEnumerable<int?>>((IEnumerable<Claim.ItemComponent>)ae_, af_, ag_);
                            IEnumerable<int?> ai_ = context.Operators.Flatten<int?>(ah_);
                            bool? aj_ = context.Operators.In<int?>(ad_, ai_);

                            bool? ak_() {
                                CodeableConcept at_ = Dx?.OnAdmission;
                                CqlConcept au_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, at_);
                                CqlValueSet av_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                                bool? aw_ = context.Operators.ConceptInValueSet(au_, av_);
                                return (bool?)((CqlBoolean)aw_);
                            }

                            return (bool?)(/* CQL 'and' (385:17-386:89) */ ((CqlBoolean)aj_
                                && (CqlBoolean)ak_()));
                        }

                        bool? ab_ = context.Operators.WhereAny<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)z_, aa_);
                        return (bool?)((CqlBoolean)ab_);
                    }

                    return (bool?)(/* CQL 'and' (383:11-387:13) */ ((CqlBoolean)x_
                        && (CqlBoolean)y_()));
                }

                bool? v_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)t_, u_);
                return (bool?)((CqlBoolean)v_);
            }

            return (bool?)(/* CQL 'and' (380:5-388:7) */ (/* CQL 'and' (380:11-381:27) */ ((CqlBoolean)m_
                && (CqlBoolean)n_())
                && (CqlBoolean)o_()));
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, Claim>, (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?>(c_, d_, e_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? tuple_epwvnljjfhnvfarkifgamtzks) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? ax_ = (CqlTupleMetadata_CUCPZLPbWZQEUULVJBALOjJbh, tuple_epwvnljjfhnvfarkifgamtzks?.QualifyingEncounter, tuple_epwvnljjfhnvfarkifgamtzks?.clm);
            return ax_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?, (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?>(f_, g_);
        return h_;
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

            bool? n_() {
                DataType o_ = FirstHeartBeats?.Value;
                CqlQuantity p_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, o_ as Quantity);
                return (bool?)((CqlBoolean)(!((bool?)(p_ is null))));
            }

            return (bool?)(/* CQL 'and' (427:7-428:45) */ ((CqlBoolean)m_
                && (CqlBoolean)n_()));
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_);
            return s_;
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
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstHeartRate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)? g_ = (CqlTupleMetadata_FagZCcMXCLUWREPQINNbEKifA, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?>(a_, b_);
        return c_;
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

            bool? n_() {
                DataType o_ = FirstRespiration?.Value;
                CqlQuantity p_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, o_ as Quantity);
                return (bool?)((CqlBoolean)(!((bool?)(p_ is null))));
            }

            return (bool?)(/* CQL 'and' (434:7-435:46) */ ((CqlBoolean)m_
                && (CqlBoolean)n_()));
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_);
            return s_;
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
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstRespiratoryRate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)? g_ = (CqlTupleMetadata_BWTiRIaMgaifWSHaCRbRQdjII, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("firstSystolicBloodPressure")]
    public CqlQuantity firstSystolicBloodPressure(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Blood_Pressure_Reading(context);

        bool? b_(Observation SBPReading) {
            DataType g_ = SBPReading?.Effective;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlDateTime i_ = QICoreCommon_4_0_000.Instance.earliest(context, h_);
            CqlInterval<CqlDateTime> j_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? k_ = context.Operators.In<CqlDateTime>(i_, j_, (string)default);
            return k_;
        }


        CqlQuantity c_(Observation SBPReading) {
            List<Observation.ComponentComponent> l_ = SBPReading?.Component;

            bool? m_(Observation.ComponentComponent SBPComponent) {
                CodeableConcept r_ = SBPComponent?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlCode t_ = this.Systolic_blood_pressure(context);
                CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                bool? v_ = context.Operators.Equivalent(s_, u_);
                return v_;
            }


            CqlQuantity n_(Observation.ComponentComponent SBPComponent) {
                DataType w_ = SBPComponent?.Value;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                return x_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity> o_ = context.Operators.WhereSelect<Observation.ComponentComponent, CqlQuantity>((IEnumerable<Observation.ComponentComponent>)l_, m_, n_);
            IEnumerable<CqlQuantity> p_ = context.Operators.Distinct<CqlQuantity>(o_);
            CqlQuantity q_ = context.Operators.SingletonFrom<CqlQuantity>(p_);
            return q_;
        }

        IEnumerable<CqlQuantity> d_ = context.Operators.WhereSelect<Observation, CqlQuantity>(a_, b_, c_);
        IEnumerable<CqlQuantity> e_ = context.Operators.Distinct<CqlQuantity>(d_);
        CqlQuantity f_ = context.Operators.First<CqlQuantity>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Risk Variable First Systolic Blood Pressure In Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?> Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter, Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter = -4275283378100321780L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?> Risk_Variable_First_Systolic_Blood_Pressure_In_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Creatinine_And_Without_Obstetrical_Conditions(context);

        (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)? b_(Encounter QualifyingEncounter) {
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstSystolicBloodPressure(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)? g_ = (CqlTupleMetadata_BfHgdIQNPeXTfGHcOBiXACaRK, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?>(a_, b_);
        return c_;
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

            bool? n_() {
                DataType o_ = FirstTemperature?.Value;
                CqlQuantity p_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, o_ as Quantity);
                return (bool?)((CqlBoolean)(!((bool?)(p_ is null))));
            }

            return (bool?)(/* CQL 'and' (420:7-421:46) */ ((CqlBoolean)m_
                && (CqlBoolean)n_()));
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType q_ = @this?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_);
            return s_;
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
            Id d_ = QualifyingEncounter?.IdElement;
            string e_ = d_?.Value;
            CqlQuantity f_ = this.firstBodyTemperature(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)? g_ = (CqlTupleMetadata_HjOGEZILgEFXhMPHLgWdcOTZ, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)?>(a_, b_);
        return c_;
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

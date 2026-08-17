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
            Patient t_ = this.Patient(context);
            bool u_ = t_ is DomainResource;
            if (u_)
            {
                e_ = (t_ as DomainResource).Extension;
            }
            else
            {
                e_ = default;
            }

            bool? f_(Extension @this) {
                FhirUri v_ = @this?.UrlElement;
                string w_ = FHIRHelpers_4_4_000.Instance.ToString(context, v_);
                bool? x_ = context.Operators.Equal(w_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                return x_;
            }


            DataType g_(Extension @this) {
                DataType y_ = @this?.Value;
                return y_;
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
            bool? q_;
            // CQL 'and' (66:11-67:75): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                Period z_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                CqlDateTime ab_ = context.Operators.End(aa_);
                CqlInterval<CqlDateTime> ac_ = this.Measurement_Period(context);
                bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, "day");
                q_ = p_ & ad_;
            }
            bool? r_;
            // CQL 'and' (66:11-68:48): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                Code<Encounter.EncounterStatus> ae_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? af_ = ae_?.Value;
                Code<Encounter.EncounterStatus> ag_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(af_);
                bool? ah_ = context.Operators.Equal(ag_, "finished");
                r_ = q_ & ah_;
            }
            bool? s_;
            // CQL 'and' (66:11-69:74): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                Patient ai_ = this.Patient(context);
                Date aj_ = ai_?.BirthDateElement;
                string ak_ = aj_?.Value;
                CqlDate al_ = context.Operators.ConvertStringToDate(ak_);
                Period am_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, am_);
                CqlDateTime ao_ = context.Operators.Start(an_);
                CqlDate ap_ = context.Operators.DateFrom(ao_);
                int? aq_ = context.Operators.CalculateAgeAt(al_, ap_, "year");
                bool? ar_ = context.Operators.GreaterOrEqual(aq_, 18);
                s_ = r_ & ar_;
            }
            // CQL 'and' (66:5-70:94): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                CqlInterval<CqlDateTime> as_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                CqlDateTime at_ = context.Operators.Start(as_);
                CqlDateTime au_ = context.Operators.End(as_);
                int? av_ = context.Operators.DurationBetween(at_, au_, "hour");
                bool? aw_ = context.Operators.GreaterOrEqual(av_, 48);
                return s_ & aw_;
            }
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
            bool? m_ = !((bool?)((l_ as CqlQuantity) is null));
            bool? n_;
            // CQL 'and' (78:11-79:118): right operand skipped when left is false
            if (m_ is false)
            {
                n_ = false;
            }
            else
            {
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
                n_ = m_ & w_;
            }
            // CQL 'and' (78:5-80:70): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                Code<ObservationStatus> ab_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                return n_ & af_;
            }
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
            bool? i_;
            // CQL 'or' (85:15-87:5): right operand skipped when left is true
            if (h_ is true)
            {
                i_ = true;
            }
            else
            {
                IEnumerable<Condition> k_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, EncounterWithCreatinine);

                bool? l_(Condition @this) {
                    CodeableConcept p_ = @this?.Code;
                    CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                    return !((bool?)(q_ is null));
                }


                CqlConcept m_(Condition @this) {
                    CodeableConcept r_ = @this?.Code;
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                    return s_;
                }

                IEnumerable<CqlConcept> n_ = context.Operators.WhereSelect<Condition, CqlConcept>(k_, l_, m_);
                bool? o_ = context.Operators.ConceptsInValueSet(n_, g_);
                i_ = h_ | o_;
            }
            return !i_;
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
            bool? i_ = !((bool?)((h_ as CqlQuantity) is null));
            bool? j_;
            // CQL 'and' (282:11-283:204): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
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
                j_ = i_ & s_;
            }
            bool? k_;
            // CQL 'and' (282:11-284:109): right operand skipped when left is false
            if (j_ is false)
            {
                k_ = false;
            }
            else
            {
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
                k_ = j_ & aa_;
            }
            // CQL 'and' (282:5-285:70): right operand skipped when left is false
            if (k_ is false)
            {
                return false;
            }
            else
            {
                Code<ObservationStatus> af_ = CreatinineTest?.StatusElement;
                ObservationStatus? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                string[] ai_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                return k_ & aj_;
            }
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
            // CQL 'and' (303:9-304:188): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime k_ = LabTestsLow?.CrLabTime;
                CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlQuantity n_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime o_ = context.Operators.Add(m_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
                bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, (string)default);
                return j_ & q_;
            }
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity r_ = @this?.CrLabResult;
            return !((bool?)(r_ is null));
        }


        CqlQuantity e_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity s_ = @this?.CrLabResult;
            return s_;
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
            bool? q_;
            // CQL 'and' (233:11-234:47): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                bool? y_ = QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation);
                q_ = p_ & y_;
            }
            bool? r_;
            // CQL 'and' (233:11-235:76): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                Code<ObservationStatus> z_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.StatusElement;
                ObservationStatus? aa_ = z_?.Value;
                string ab_ = context.Operators.Convert<string>(aa_);
                string[] ac_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
                r_ = q_ & ad_;
            }
            bool? s_;
            // CQL 'and' (233:11-236:32): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                DataType ae_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                string ag_ = (af_ as CqlQuantity)?.unit;
                bool? ah_ = context.Operators.Equal(ag_, "mg/dL");
                s_ = r_ & ah_;
            }
            bool? t_;
            // CQL 'and' (233:11-237:48): right operand skipped when left is false
            if (s_ is false)
            {
                t_ = false;
            }
            else
            {
                DataType ai_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                t_ = s_ & (!((bool?)(aj_ is null)));
            }
            // CQL 'and' (233:5-238:60): right operand skipped when left is false
            if (t_ is false)
            {
                return false;
            }
            else
            {
                DataType ak_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlQuantity am_ = context.Operators.Quantity(0m, "mg/dL");
                bool? an_ = context.Operators.Greater(al_ as CqlQuantity, am_);
                return t_ & an_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?> g_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?>(d_, e_, f_);

        (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? h_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? tuple_ccccqpjvqogtctjhtilehkfoj) {
            Id ao_ = tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter?.IdElement;
            string ap_ = ao_?.Value;
            CqlInterval<CqlDateTime> aq_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter);
            Id ar_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IdElement;
            string as_ = ar_?.Value;
            object at_;
            if ((QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation)) ?? false)
            {
                at_ = "laboratory";
            }
            else
            {
                bool? bk_ = QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation);
                at_ = bk_;
            }
            List<CodeableConcept> au_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Category;

            CqlConcept av_(CodeableConcept @this) {
                CqlConcept bl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bl_;
            }

            IEnumerable<CqlConcept> aw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)au_, av_);
            Code<ObservationStatus> ax_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.StatusElement;
            ObservationStatus? ay_ = ax_?.Value;
            string az_ = context.Operators.Convert<string>(ay_);
            DataType ba_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
            string bc_ = (bb_ as CqlQuantity)?.unit;
            decimal? bd_ = (bb_ as CqlQuantity)?.value;
            object be_;
            DataType bm_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
            object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
            bool bo_ = bn_ is CqlDateTime;
            if (bo_)
            {
                be_ = bn_ as CqlDateTime;
            }
            else
            {
                if (bo_)
                {
                    be_ = bn_ as CqlDateTime;
                }
                else
                {
                    bool bp_ = bn_ is CqlInterval<CqlDateTime>;
                    if (bp_)
                    {
                        be_ = bn_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        be_ = null;
                    }
                }
            }
            CqlDateTime bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_);
            Instant bg_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IssuedElement;
            DateTimeOffset? bh_ = bg_?.Value;
            CqlDateTime bi_ = context.Operators.Convert<CqlDateTime>(bh_);
            (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? bj_ = (CqlTupleMetadata_EROdcjJjSdFbfXChfKbYbOdDN, ap_, aq_, as_, at_, aw_, az_, bb_ as CqlQuantity, bc_, bd_, bf_, bi_);
            return bj_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?, (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(g_, h_);

        object j_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime bq_ = @this?.CrLabTime;
            return bq_;
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
            // CQL 'and' (319:11-320:189): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime k_ = LabTests48?.CrLabTime;
                CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlQuantity n_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime o_ = context.Operators.Add(m_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
                bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, (string)default);
                return j_ & q_;
            }
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime r_ = @this?.CrLabTime;
            return !((bool?)(r_ is null));
        }


        CqlDateTime e_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime s_ = @this?.CrLabTime;
            return s_;
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
            bool? e_ = !((bool?)(d_ is null));
            // CQL 'and' (104:5-105:60): right operand skipped when left is false
            if (e_ is false)
            {
                return false;
            }
            else
            {
                decimal? f_ = context.Operators.ConvertIntegerToDecimal(60);
                bool? g_ = context.Operators.Less(d_ as decimal?, f_);
                return e_ & g_;
            }
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
            bool? e_ = !((bool?)(d_ is null));
            // CQL 'and' (99:5-100:62): right operand skipped when left is false
            if (e_ is false)
            {
                return false;
            }
            else
            {
                decimal? f_ = context.Operators.ConvertIntegerToDecimal(60);
                bool? g_ = context.Operators.Less(d_ as decimal?, f_);
                return e_ & g_;
            }
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
            bool? p_;
            // CQL 'and' (119:11-120:85): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                Code<ObservationStatus> x_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                bool? aa_ = context.Operators.In<string>(z_, (IEnumerable<string>)n_);
                p_ = o_ & aa_;
            }
            bool? q_;
            // CQL 'and' (119:11-121:130): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                DataType ab_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Value;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                DataType ad_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                CqlQuantity af_ = context.Operators.Subtract(ac_ as CqlQuantity, ae_ as CqlQuantity);
                CqlQuantity ag_ = context.Operators.Quantity(0.299m, "mg/dL");
                bool? ah_ = context.Operators.Greater(af_, ag_);
                q_ = p_ & ah_;
            }
            bool? r_;
            // CQL 'and' (119:11-122:96): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                DataType ai_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                CqlQuantity ak_ = this.lowestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? al_ = context.Operators.Equal(aj_ as CqlQuantity, ak_);
                r_ = q_ & al_;
            }
            bool? s_;
            // CQL 'and' (119:11-123:135): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                object am_;
                DataType aw_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool ay_ = ax_ is CqlDateTime;
                if (ay_)
                {
                    am_ = ax_ as CqlDateTime;
                }
                else
                {
                    if (ay_)
                    {
                        am_ = ax_ as CqlDateTime;
                    }
                    else
                    {
                        bool az_ = ax_ is CqlInterval<CqlDateTime>;
                        if (az_)
                        {
                            am_ = ax_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            am_ = null;
                        }
                    }
                }
                CqlDateTime an_ = QICoreCommon_4_0_000.Instance.earliest(context, am_);
                object ao_;
                DataType ba_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                bool bc_ = bb_ is CqlDateTime;
                if (bc_)
                {
                    ao_ = bb_ as CqlDateTime;
                }
                else
                {
                    if (bc_)
                    {
                        ao_ = bb_ as CqlDateTime;
                    }
                    else
                    {
                        bool bd_ = bb_ is CqlInterval<CqlDateTime>;
                        if (bd_)
                        {
                            ao_ = bb_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ao_ = null;
                        }
                    }
                }
                CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_);
                CqlQuantity aq_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime ar_ = context.Operators.Subtract(ap_, aq_);
                object as_;
                DataType be_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool bg_ = bf_ is CqlDateTime;
                if (bg_)
                {
                    as_ = bf_ as CqlDateTime;
                }
                else
                {
                    if (bg_)
                    {
                        as_ = bf_ as CqlDateTime;
                    }
                    else
                    {
                        bool bh_ = bf_ is CqlInterval<CqlDateTime>;
                        if (bh_)
                        {
                            as_ = bf_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            as_ = null;
                        }
                    }
                }
                CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
                CqlInterval<CqlDateTime> au_ = context.Operators.Interval(ar_, at_, true, true);
                bool? av_ = context.Operators.In<CqlDateTime>(an_, au_, (string)default);
                s_ = r_ & av_;
            }
            bool? t_;
            // CQL 'and' (119:11-124:75): right operand skipped when left is false
            if (s_ is false)
            {
                t_ = false;
            }
            else
            {
                object bi_;
                DataType bm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                bool bo_ = bn_ is CqlDateTime;
                if (bo_)
                {
                    bi_ = bn_ as CqlDateTime;
                }
                else
                {
                    if (bo_)
                    {
                        bi_ = bn_ as CqlDateTime;
                    }
                    else
                    {
                        bool bp_ = bn_ is CqlInterval<CqlDateTime>;
                        if (bp_)
                        {
                            bi_ = bn_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bi_ = null;
                        }
                    }
                }
                CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_);
                CqlInterval<CqlDateTime> bk_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? bl_ = context.Operators.In<CqlDateTime>(bj_, bk_, (string)default);
                t_ = s_ & bl_;
            }
            bool? u_;
            // CQL 'and' (119:11-125:145): right operand skipped when left is false
            if (t_ is false)
            {
                u_ = false;
            }
            else
            {
                object bq_;
                DataType by_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bool ca_ = bz_ is CqlDateTime;
                if (ca_)
                {
                    bq_ = bz_ as CqlDateTime;
                }
                else
                {
                    if (ca_)
                    {
                        bq_ = bz_ as CqlDateTime;
                    }
                    else
                    {
                        bool cb_ = bz_ is CqlInterval<CqlDateTime>;
                        if (cb_)
                        {
                            bq_ = bz_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bq_ = null;
                        }
                    }
                }
                CqlDateTime br_ = QICoreCommon_4_0_000.Instance.earliest(context, bq_);
                CqlInterval<CqlDateTime> bs_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlDateTime bt_ = context.Operators.Start(bs_);
                CqlQuantity bu_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime bv_ = context.Operators.Add(bt_, bu_);
                CqlInterval<CqlDateTime> bw_ = context.Operators.Interval(bt_, bv_, true, true);
                bool? bx_ = context.Operators.In<CqlDateTime>(br_, bw_, (string)default);
                u_ = t_ & bx_;
            }
            bool? v_;
            // CQL 'and' (119:11-126:80): right operand skipped when left is false
            if (u_ is false)
            {
                v_ = false;
            }
            else
            {
                object cc_;
                DataType cg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                bool ci_ = ch_ is CqlDateTime;
                if (ci_)
                {
                    cc_ = ch_ as CqlDateTime;
                }
                else
                {
                    if (ci_)
                    {
                        cc_ = ch_ as CqlDateTime;
                    }
                    else
                    {
                        bool cj_ = ch_ is CqlInterval<CqlDateTime>;
                        if (cj_)
                        {
                            cc_ = ch_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            cc_ = null;
                        }
                    }
                }
                CqlDateTime cd_ = QICoreCommon_4_0_000.Instance.earliest(context, cc_);
                CqlInterval<CqlDateTime> ce_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? cf_ = context.Operators.In<CqlDateTime>(cd_, ce_, (string)default);
                v_ = u_ & cf_;
            }
            bool? w_;
            // CQL 'and' (119:11-127:150): right operand skipped when left is false
            if (v_ is false)
            {
                w_ = false;
            }
            else
            {
                object ck_;
                DataType cs_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                bool cu_ = ct_ is CqlDateTime;
                if (cu_)
                {
                    ck_ = ct_ as CqlDateTime;
                }
                else
                {
                    if (cu_)
                    {
                        ck_ = ct_ as CqlDateTime;
                    }
                    else
                    {
                        bool cv_ = ct_ is CqlInterval<CqlDateTime>;
                        if (cv_)
                        {
                            ck_ = ct_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ck_ = null;
                        }
                    }
                }
                CqlDateTime cl_ = QICoreCommon_4_0_000.Instance.earliest(context, ck_);
                CqlInterval<CqlDateTime> cm_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlDateTime cn_ = context.Operators.Start(cm_);
                CqlQuantity co_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime cp_ = context.Operators.Add(cn_, co_);
                CqlInterval<CqlDateTime> cq_ = context.Operators.Interval(cn_, cp_, true, true);
                bool? cr_ = context.Operators.In<CqlDateTime>(cl_, cq_, (string)default);
                w_ = v_ & cr_;
            }
            // CQL 'and' (119:5-128:73): right operand skipped when left is false
            if (w_ is false)
            {
                return false;
            }
            else
            {
                Id cw_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
                string cx_ = cw_?.Value;
                Id cy_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
                string cz_ = cy_?.Value;
                bool? da_ = context.Operators.Equal(cx_, cz_);
                return w_ & !da_;
            }
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
            bool? p_;
            // CQL 'and' (139:11-140:85): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                Code<ObservationStatus> x_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                bool? aa_ = context.Operators.In<string>(z_, (IEnumerable<string>)n_);
                p_ = o_ & aa_;
            }
            bool? q_;
            // CQL 'and' (139:11-141:130): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                DataType ab_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Value;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                DataType ad_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                CqlQuantity af_ = context.Operators.Subtract(ac_ as CqlQuantity, ae_ as CqlQuantity);
                CqlQuantity ag_ = context.Operators.Quantity(0.299m, "mg/dL");
                bool? ah_ = context.Operators.Greater(af_, ag_);
                q_ = p_ & ah_;
            }
            bool? r_;
            // CQL 'and' (139:11-142:125): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                DataType ai_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                IEnumerable<CqlQuantity> ak_ = this.earliestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlQuantity al_ = context.Operators.SingletonFrom<CqlQuantity>(ak_);
                bool? am_ = context.Operators.Equal(aj_ as CqlQuantity, al_);
                r_ = q_ & am_;
            }
            bool? s_;
            // CQL 'and' (139:11-143:135): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                object an_;
                DataType ax_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                bool az_ = ay_ is CqlDateTime;
                if (az_)
                {
                    an_ = ay_ as CqlDateTime;
                }
                else
                {
                    if (az_)
                    {
                        an_ = ay_ as CqlDateTime;
                    }
                    else
                    {
                        bool ba_ = ay_ is CqlInterval<CqlDateTime>;
                        if (ba_)
                        {
                            an_ = ay_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            an_ = null;
                        }
                    }
                }
                CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_);
                object ap_;
                DataType bb_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                bool bd_ = bc_ is CqlDateTime;
                if (bd_)
                {
                    ap_ = bc_ as CqlDateTime;
                }
                else
                {
                    if (bd_)
                    {
                        ap_ = bc_ as CqlDateTime;
                    }
                    else
                    {
                        bool be_ = bc_ is CqlInterval<CqlDateTime>;
                        if (be_)
                        {
                            ap_ = bc_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ap_ = null;
                        }
                    }
                }
                CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
                CqlQuantity ar_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime as_ = context.Operators.Subtract(aq_, ar_);
                object at_;
                DataType bf_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    at_ = bg_ as CqlDateTime;
                }
                else
                {
                    if (bh_)
                    {
                        at_ = bg_ as CqlDateTime;
                    }
                    else
                    {
                        bool bi_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            at_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            at_ = null;
                        }
                    }
                }
                CqlDateTime au_ = QICoreCommon_4_0_000.Instance.earliest(context, at_);
                CqlInterval<CqlDateTime> av_ = context.Operators.Interval(as_, au_, true, true);
                bool? aw_ = context.Operators.In<CqlDateTime>(ao_, av_, (string)default);
                s_ = r_ & aw_;
            }
            bool? t_;
            // CQL 'and' (139:11-144:75): right operand skipped when left is false
            if (s_ is false)
            {
                t_ = false;
            }
            else
            {
                object bj_;
                DataType bn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                bool bp_ = bo_ is CqlDateTime;
                if (bp_)
                {
                    bj_ = bo_ as CqlDateTime;
                }
                else
                {
                    if (bp_)
                    {
                        bj_ = bo_ as CqlDateTime;
                    }
                    else
                    {
                        bool bq_ = bo_ is CqlInterval<CqlDateTime>;
                        if (bq_)
                        {
                            bj_ = bo_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bj_ = null;
                        }
                    }
                }
                CqlDateTime bk_ = QICoreCommon_4_0_000.Instance.earliest(context, bj_);
                CqlInterval<CqlDateTime> bl_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? bm_ = context.Operators.In<CqlDateTime>(bk_, bl_, (string)default);
                t_ = s_ & bm_;
            }
            bool? u_;
            // CQL 'and' (139:11-145:150): right operand skipped when left is false
            if (t_ is false)
            {
                u_ = false;
            }
            else
            {
                object br_;
                DataType bz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                bool cb_ = ca_ is CqlDateTime;
                if (cb_)
                {
                    br_ = ca_ as CqlDateTime;
                }
                else
                {
                    if (cb_)
                    {
                        br_ = ca_ as CqlDateTime;
                    }
                    else
                    {
                        bool cc_ = ca_ is CqlInterval<CqlDateTime>;
                        if (cc_)
                        {
                            br_ = ca_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            br_ = null;
                        }
                    }
                }
                CqlDateTime bs_ = QICoreCommon_4_0_000.Instance.earliest(context, br_);
                CqlInterval<CqlDateTime> bt_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlDateTime bu_ = context.Operators.Start(bt_);
                CqlQuantity bv_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime bw_ = context.Operators.Add(bu_, bv_);
                CqlInterval<CqlDateTime> bx_ = context.Operators.Interval(bu_, bw_, true, true);
                bool? by_ = context.Operators.In<CqlDateTime>(bs_, bx_, (string)default);
                u_ = t_ & by_;
            }
            bool? v_;
            // CQL 'and' (139:11-146:80): right operand skipped when left is false
            if (u_ is false)
            {
                v_ = false;
            }
            else
            {
                object cd_;
                DataType ch_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                bool cj_ = ci_ is CqlDateTime;
                if (cj_)
                {
                    cd_ = ci_ as CqlDateTime;
                }
                else
                {
                    if (cj_)
                    {
                        cd_ = ci_ as CqlDateTime;
                    }
                    else
                    {
                        bool ck_ = ci_ is CqlInterval<CqlDateTime>;
                        if (ck_)
                        {
                            cd_ = ci_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            cd_ = null;
                        }
                    }
                }
                CqlDateTime ce_ = QICoreCommon_4_0_000.Instance.earliest(context, cd_);
                CqlInterval<CqlDateTime> cf_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? cg_ = context.Operators.In<CqlDateTime>(ce_, cf_, (string)default);
                v_ = u_ & cg_;
            }
            bool? w_;
            // CQL 'and' (139:11-147:145): right operand skipped when left is false
            if (v_ is false)
            {
                w_ = false;
            }
            else
            {
                object cl_;
                DataType ct_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                bool cv_ = cu_ is CqlDateTime;
                if (cv_)
                {
                    cl_ = cu_ as CqlDateTime;
                }
                else
                {
                    if (cv_)
                    {
                        cl_ = cu_ as CqlDateTime;
                    }
                    else
                    {
                        bool cw_ = cu_ is CqlInterval<CqlDateTime>;
                        if (cw_)
                        {
                            cl_ = cu_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            cl_ = null;
                        }
                    }
                }
                CqlDateTime cm_ = QICoreCommon_4_0_000.Instance.earliest(context, cl_);
                CqlInterval<CqlDateTime> cn_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlDateTime co_ = context.Operators.Start(cn_);
                CqlQuantity cp_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime cq_ = context.Operators.Add(co_, cp_);
                CqlInterval<CqlDateTime> cr_ = context.Operators.Interval(co_, cq_, true, true);
                bool? cs_ = context.Operators.In<CqlDateTime>(cm_, cr_, (string)default);
                w_ = v_ & cs_;
            }
            // CQL 'and' (139:5-148:73): right operand skipped when left is false
            if (w_ is false)
            {
                return false;
            }
            else
            {
                Id cx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
                string cy_ = cx_?.Value;
                Id cz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
                string da_ = cz_?.Value;
                bool? db_ = context.Operators.Equal(cy_, da_);
                return w_ & !db_;
            }
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
            bool? o_;
            // CQL 'and' (163:11-164:157): right operand skipped when left is false
            if (n_ is false)
            {
                o_ = false;
            }
            else
            {
                object p_;
                DataType y_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    p_ = z_ as CqlDateTime;
                }
                else
                {
                    bool ab_ = z_ is CqlQuantity;
                    if (ab_)
                    {
                        p_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        bool ac_ = z_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            p_ = z_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ad_ = z_ is CqlInterval<CqlQuantity>;
                            if (ad_)
                            {
                                p_ = z_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                p_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlInterval<CqlDateTime> s_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlQuantity u_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime v_ = context.Operators.Add(t_, u_);
                CqlInterval<CqlDateTime> w_ = context.Operators.Interval(t_, v_, true, true);
                bool? x_ = context.Operators.In<CqlDateTime>(r_, w_, (string)default);
                o_ = n_ & x_;
            }
            // CQL 'and' (163:5-165:87): right operand skipped when left is false
            if (o_ is false)
            {
                return false;
            }
            else
            {
                object ae_;
                DataType aj_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                bool al_ = ak_ is CqlDateTime;
                if (al_)
                {
                    ae_ = ak_ as CqlDateTime;
                }
                else
                {
                    bool am_ = ak_ is CqlQuantity;
                    if (am_)
                    {
                        ae_ = ak_ as CqlQuantity;
                    }
                    else
                    {
                        bool an_ = ak_ is CqlInterval<CqlDateTime>;
                        if (an_)
                        {
                            ae_ = ak_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ao_ = ak_ is CqlInterval<CqlQuantity>;
                            if (ao_)
                            {
                                ae_ = ak_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ae_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
                CqlDateTime ag_ = context.Operators.Start(af_);
                CqlInterval<CqlDateTime> ah_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
                bool? ai_ = context.Operators.In<CqlDateTime>(ag_, ah_, (string)default);
                return o_ & ai_;
            }
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
            bool? o_;
            // CQL 'and' (263:11-264:73): right operand skipped when left is false
            if (n_ is false)
            {
                o_ = false;
            }
            else
            {
                Code<ObservationStatus> w_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.StatusElement;
                ObservationStatus? x_ = w_?.Value;
                string y_ = context.Operators.Convert<string>(x_);
                string[] z_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
                o_ = n_ & aa_;
            }
            bool? p_;
            // CQL 'and' (263:11-265:74): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                Code<ObservationStatus> ab_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                p_ = o_ & af_;
            }
            bool? q_;
            // CQL 'and' (263:11-266:91): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                CqlQuantity ag_ = this.highestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                bool? ah_ = context.Operators.Equal(l_ as CqlQuantity, ag_);
                q_ = p_ & ah_;
            }
            bool? r_;
            // CQL 'and' (263:11-267:89): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                DataType ai_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Value;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                CqlQuantity ak_ = this.lowestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                bool? al_ = context.Operators.Equal(aj_ as CqlQuantity, ak_);
                r_ = q_ & al_;
            }
            bool? s_;
            // CQL 'and' (263:11-268:94): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlQuantity am_ = this.oneAndAHalfIncreaseInCreatinine(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                DataType an_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Value;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                bool? ap_ = context.Operators.GreaterOrEqual(am_, ao_ as CqlQuantity);
                s_ = r_ & ap_;
            }
            bool? t_;
            // CQL 'and' (263:11-269:76): right operand skipped when left is false
            if (s_ is false)
            {
                t_ = false;
            }
            else
            {
                object aq_;
                DataType bb_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                bool bd_ = bc_ is CqlDateTime;
                if (bd_)
                {
                    aq_ = bc_ as CqlDateTime;
                }
                else
                {
                    if (bd_)
                    {
                        aq_ = bc_ as CqlDateTime;
                    }
                    else
                    {
                        bool be_ = bc_ is CqlInterval<CqlDateTime>;
                        if (be_)
                        {
                            aq_ = bc_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            aq_ = null;
                        }
                    }
                }
                CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                object as_;
                DataType bf_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    as_ = bg_ as CqlDateTime;
                }
                else
                {
                    if (bh_)
                    {
                        as_ = bg_ as CqlDateTime;
                    }
                    else
                    {
                        bool bi_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            as_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            as_ = null;
                        }
                    }
                }
                CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
                CqlQuantity au_ = context.Operators.Quantity(7m, "days");
                CqlDateTime av_ = context.Operators.Subtract(at_, au_);
                object aw_;
                DataType bj_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
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
                CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(av_, ax_, true, false);
                bool? az_ = context.Operators.In<CqlDateTime>(ar_, ay_, (string)default);
                bool? ba_;
                // CQL 'and' (269:11-269:76): right operand skipped when left is false
                if (az_ is false)
                {
                    ba_ = false;
                }
                else
                {
                    object bn_;
                    DataType bp_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlDateTime;
                    if (br_)
                    {
                        bn_ = bq_ as CqlDateTime;
                    }
                    else
                    {
                        if (br_)
                        {
                            bn_ = bq_ as CqlDateTime;
                        }
                        else
                        {
                            bool bs_ = bq_ is CqlInterval<CqlDateTime>;
                            if (bs_)
                            {
                                bn_ = bq_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bn_ = null;
                            }
                        }
                    }
                    CqlDateTime bo_ = QICoreCommon_4_0_000.Instance.earliest(context, bn_);
                    ba_ = az_ & (!((bool?)(bo_ is null)));
                }
                t_ = s_ & ba_;
            }
            bool? u_;
            // CQL 'and' (263:11-270:68): right operand skipped when left is false
            if (t_ is false)
            {
                u_ = false;
            }
            else
            {
                object bt_;
                DataType bx_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                bool bz_ = by_ is CqlDateTime;
                if (bz_)
                {
                    bt_ = by_ as CqlDateTime;
                }
                else
                {
                    if (bz_)
                    {
                        bt_ = by_ as CqlDateTime;
                    }
                    else
                    {
                        bool ca_ = by_ is CqlInterval<CqlDateTime>;
                        if (ca_)
                        {
                            bt_ = by_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bt_ = null;
                        }
                    }
                }
                CqlDateTime bu_ = QICoreCommon_4_0_000.Instance.earliest(context, bt_);
                CqlInterval<CqlDateTime> bv_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                bool? bw_ = context.Operators.In<CqlDateTime>(bu_, bv_, (string)default);
                u_ = t_ & bw_;
            }
            bool? v_;
            // CQL 'and' (263:11-271:149): right operand skipped when left is false
            if (u_ is false)
            {
                v_ = false;
            }
            else
            {
                object cb_;
                DataType cl_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                bool cn_ = cm_ is CqlDateTime;
                if (cn_)
                {
                    cb_ = cm_ as CqlDateTime;
                }
                else
                {
                    if (cn_)
                    {
                        cb_ = cm_ as CqlDateTime;
                    }
                    else
                    {
                        bool co_ = cm_ is CqlInterval<CqlDateTime>;
                        if (co_)
                        {
                            cb_ = cm_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            cb_ = null;
                        }
                    }
                }
                CqlDateTime cc_ = QICoreCommon_4_0_000.Instance.earliest(context, cb_);
                CqlInterval<CqlDateTime> cd_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                CqlQuantity cf_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime cg_ = context.Operators.Add(ce_, cf_);
                CqlQuantity ch_ = context.Operators.Quantity(30m, "days");
                CqlDateTime ci_ = context.Operators.Add(ce_, ch_);
                CqlInterval<CqlDateTime> cj_ = context.Operators.Interval(cg_, ci_, true, true);
                bool? ck_ = context.Operators.In<CqlDateTime>(cc_, cj_, (string)default);
                v_ = u_ & ck_;
            }
            // CQL 'and' (263:5-272:69): right operand skipped when left is false
            if (v_ is false)
            {
                return false;
            }
            else
            {
                object cp_;
                DataType ct_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                bool cv_ = cu_ is CqlDateTime;
                if (cv_)
                {
                    cp_ = cu_ as CqlDateTime;
                }
                else
                {
                    if (cv_)
                    {
                        cp_ = cu_ as CqlDateTime;
                    }
                    else
                    {
                        bool cw_ = cu_ is CqlInterval<CqlDateTime>;
                        if (cw_)
                        {
                            cp_ = cu_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            cp_ = null;
                        }
                    }
                }
                CqlDateTime cq_ = QICoreCommon_4_0_000.Instance.earliest(context, cp_);
                CqlInterval<CqlDateTime> cr_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                bool? cs_ = context.Operators.In<CqlDateTime>(cq_, cr_, (string)default);
                return v_ & cs_;
            }
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
            bool? o_;
            // CQL 'and' (176:11-177:73): right operand skipped when left is false
            if (n_ is false)
            {
                o_ = false;
            }
            else
            {
                Code<ObservationStatus> w_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.StatusElement;
                ObservationStatus? x_ = w_?.Value;
                string y_ = context.Operators.Convert<string>(x_);
                string[] z_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
                o_ = n_ & aa_;
            }
            bool? p_;
            // CQL 'and' (176:11-178:74): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                Code<ObservationStatus> ab_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.StatusElement;
                ObservationStatus? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                string[] ae_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
                p_ = o_ & af_;
            }
            bool? q_;
            // CQL 'and' (176:11-179:99): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                CqlQuantity ag_ = this.highestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                bool? ah_ = context.Operators.Equal(l_ as CqlQuantity, ag_);
                q_ = p_ & ah_;
            }
            bool? r_;
            // CQL 'and' (176:11-180:97): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                DataType ai_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Value;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                CqlQuantity ak_ = this.lowestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                bool? al_ = context.Operators.Equal(aj_ as CqlQuantity, ak_);
                r_ = q_ & al_;
            }
            bool? s_;
            // CQL 'and' (176:11-181:93): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                DataType am_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Value;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                bool? ao_ = context.Operators.GreaterOrEqual(l_ as CqlQuantity, an_ as CqlQuantity);
                s_ = r_ & ao_;
            }
            bool? t_;
            // CQL 'and' (176:11-182:76): right operand skipped when left is false
            if (s_ is false)
            {
                t_ = false;
            }
            else
            {
                object ap_;
                DataType ba_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                bool bc_ = bb_ is CqlDateTime;
                if (bc_)
                {
                    ap_ = bb_ as CqlDateTime;
                }
                else
                {
                    if (bc_)
                    {
                        ap_ = bb_ as CqlDateTime;
                    }
                    else
                    {
                        bool bd_ = bb_ is CqlInterval<CqlDateTime>;
                        if (bd_)
                        {
                            ap_ = bb_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ap_ = null;
                        }
                    }
                }
                CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
                object ar_;
                DataType be_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool bg_ = bf_ is CqlDateTime;
                if (bg_)
                {
                    ar_ = bf_ as CqlDateTime;
                }
                else
                {
                    if (bg_)
                    {
                        ar_ = bf_ as CqlDateTime;
                    }
                    else
                    {
                        bool bh_ = bf_ is CqlInterval<CqlDateTime>;
                        if (bh_)
                        {
                            ar_ = bf_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ar_ = null;
                        }
                    }
                }
                CqlDateTime as_ = QICoreCommon_4_0_000.Instance.earliest(context, ar_);
                CqlQuantity at_ = context.Operators.Quantity(7m, "days");
                CqlDateTime au_ = context.Operators.Subtract(as_, at_);
                object av_;
                DataType bi_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
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
                CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(au_, aw_, true, false);
                bool? ay_ = context.Operators.In<CqlDateTime>(aq_, ax_, (string)default);
                bool? az_;
                // CQL 'and' (182:11-182:76): right operand skipped when left is false
                if (ay_ is false)
                {
                    az_ = false;
                }
                else
                {
                    object bm_;
                    DataType bo_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    bool bq_ = bp_ is CqlDateTime;
                    if (bq_)
                    {
                        bm_ = bp_ as CqlDateTime;
                    }
                    else
                    {
                        if (bq_)
                        {
                            bm_ = bp_ as CqlDateTime;
                        }
                        else
                        {
                            bool br_ = bp_ is CqlInterval<CqlDateTime>;
                            if (br_)
                            {
                                bm_ = bp_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bm_ = null;
                            }
                        }
                    }
                    CqlDateTime bn_ = QICoreCommon_4_0_000.Instance.earliest(context, bm_);
                    az_ = ay_ & (!((bool?)(bn_ is null)));
                }
                t_ = s_ & az_;
            }
            bool? u_;
            // CQL 'and' (176:11-183:68): right operand skipped when left is false
            if (t_ is false)
            {
                u_ = false;
            }
            else
            {
                object bs_;
                DataType bw_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                bool by_ = bx_ is CqlDateTime;
                if (by_)
                {
                    bs_ = bx_ as CqlDateTime;
                }
                else
                {
                    if (by_)
                    {
                        bs_ = bx_ as CqlDateTime;
                    }
                    else
                    {
                        bool bz_ = bx_ is CqlInterval<CqlDateTime>;
                        if (bz_)
                        {
                            bs_ = bx_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bs_ = null;
                        }
                    }
                }
                CqlDateTime bt_ = QICoreCommon_4_0_000.Instance.earliest(context, bs_);
                CqlInterval<CqlDateTime> bu_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                bool? bv_ = context.Operators.In<CqlDateTime>(bt_, bu_, (string)default);
                u_ = t_ & bv_;
            }
            bool? v_;
            // CQL 'and' (176:11-184:149): right operand skipped when left is false
            if (u_ is false)
            {
                v_ = false;
            }
            else
            {
                object ca_;
                DataType ck_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                bool cm_ = cl_ is CqlDateTime;
                if (cm_)
                {
                    ca_ = cl_ as CqlDateTime;
                }
                else
                {
                    if (cm_)
                    {
                        ca_ = cl_ as CqlDateTime;
                    }
                    else
                    {
                        bool cn_ = cl_ is CqlInterval<CqlDateTime>;
                        if (cn_)
                        {
                            ca_ = cl_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ca_ = null;
                        }
                    }
                }
                CqlDateTime cb_ = QICoreCommon_4_0_000.Instance.earliest(context, ca_);
                CqlInterval<CqlDateTime> cc_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                CqlDateTime cd_ = context.Operators.Start(cc_);
                CqlQuantity ce_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime cf_ = context.Operators.Add(cd_, ce_);
                CqlQuantity cg_ = context.Operators.Quantity(30m, "days");
                CqlDateTime ch_ = context.Operators.Add(cd_, cg_);
                CqlInterval<CqlDateTime> ci_ = context.Operators.Interval(cf_, ch_, true, true);
                bool? cj_ = context.Operators.In<CqlDateTime>(cb_, ci_, (string)default);
                v_ = u_ & cj_;
            }
            // CQL 'and' (176:5-185:69): right operand skipped when left is false
            if (v_ is false)
            {
                return false;
            }
            else
            {
                object co_;
                DataType cs_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                bool cu_ = ct_ is CqlDateTime;
                if (cu_)
                {
                    co_ = ct_ as CqlDateTime;
                }
                else
                {
                    if (cu_)
                    {
                        co_ = ct_ as CqlDateTime;
                    }
                    else
                    {
                        bool cv_ = ct_ is CqlInterval<CqlDateTime>;
                        if (cv_)
                        {
                            co_ = ct_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            co_ = null;
                        }
                    }
                }
                CqlDateTime cp_ = QICoreCommon_4_0_000.Instance.earliest(context, co_);
                CqlInterval<CqlDateTime> cq_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                bool? cr_ = context.Operators.In<CqlDateTime>(cp_, cq_, (string)default);
                return v_ & cr_;
            }
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
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return i_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.High_Risk_Diagnosis_for_AKI(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            // CQL 'or' (194:5-196:5): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Condition> j_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

                bool? k_(Condition @this) {
                    CodeableConcept o_ = @this?.Code;
                    CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                    return !((bool?)(p_ is null));
                }


                CqlConcept l_(Condition @this) {
                    CodeableConcept q_ = @this?.Code;
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                    return r_;
                }

                IEnumerable<CqlConcept> m_ = context.Operators.WhereSelect<Condition, CqlConcept>(j_, k_, l_);
                bool? n_ = context.Operators.ConceptsInValueSet(m_, g_);
                return h_ | n_;
            }
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
                // CQL 'and' (201:17-202:124): right operand skipped when left is false
                if (k_ is false)
                {
                    return false;
                }
                else
                {
                    object l_;
                    DataType q_ = HighRiskProcedures?.Performed;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlDateTime;
                    if (s_)
                    {
                        l_ = r_ as CqlDateTime;
                    }
                    else
                    {
                        bool t_ = r_ is CqlQuantity;
                        if (t_)
                        {
                            l_ = r_ as CqlQuantity;
                        }
                        else
                        {
                            bool u_ = r_ is CqlInterval<CqlDateTime>;
                            if (u_)
                            {
                                l_ = r_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool v_ = r_ is CqlInterval<CqlQuantity>;
                                if (v_)
                                {
                                    l_ = r_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    l_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                    CqlDateTime n_ = context.Operators.Start(m_);
                    CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                    bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
                    return k_ & p_;
                }
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
            DataType v_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            bool x_ = w_ is CqlDateTime;
            if (x_)
            {
                k_ = w_ as CqlDateTime;
            }
            else
            {
                bool y_ = w_ is CqlQuantity;
                if (y_)
                {
                    k_ = w_ as CqlQuantity;
                }
                else
                {
                    bool z_ = w_ is CqlInterval<CqlDateTime>;
                    if (z_)
                    {
                        k_ = w_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool aa_ = w_ is CqlInterval<CqlQuantity>;
                        if (aa_)
                        {
                            k_ = w_ as CqlInterval<CqlQuantity>;
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
            bool? u_;
            // CQL 'and' (216:11-217:87): right operand skipped when left is false
            if (t_ is false)
            {
                u_ = false;
            }
            else
            {
                object ab_;
                DataType af_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool ah_ = ag_ is CqlDateTime;
                if (ah_)
                {
                    ab_ = ag_ as CqlDateTime;
                }
                else
                {
                    bool ai_ = ag_ is CqlQuantity;
                    if (ai_)
                    {
                        ab_ = ag_ as CqlQuantity;
                    }
                    else
                    {
                        bool aj_ = ag_ is CqlInterval<CqlDateTime>;
                        if (aj_)
                        {
                            ab_ = ag_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ak_ = ag_ is CqlInterval<CqlQuantity>;
                            if (ak_)
                            {
                                ab_ = ag_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ab_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_);
                CqlDateTime ad_ = context.Operators.Start(ac_);
                bool? ae_ = context.Operators.In<CqlDateTime>(ad_, n_, (string)default);
                u_ = t_ & ae_;
            }
            // CQL 'and' (216:5-218:39): right operand skipped when left is false
            if (u_ is false)
            {
                return false;
            }
            else
            {
                Code<EventStatus> al_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.StatusElement;
                EventStatus? am_ = al_?.Value;
                string an_ = context.Operators.Convert<string>(am_);
                bool? ao_ = context.Operators.Equal(an_, "completed");
                return u_ & ao_;
            }
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
            bool? n_;
            // CQL 'and' (380:11-381:27): right operand skipped when left is false
            if (m_ is false)
            {
                n_ = false;
            }
            else
            {
                Code<ClaimUseCode> o_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.UseElement;
                ClaimUseCode? p_ = o_?.Value;
                Code<ClaimUseCode> q_ = context.Operators.Convert<Code<ClaimUseCode>>(p_);
                bool? r_ = context.Operators.Equal(q_, "claim");
                n_ = m_ & r_;
            }
            // CQL 'and' (380:5-388:7): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                List<Claim.ItemComponent> s_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Item;

                bool? t_(Claim.ItemComponent ClaimItem) {
                    List<ResourceReference> v_ = ClaimItem?.Encounter;
                    bool? w_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)v_, tuple_epwvnljjfhnvfarkifgamtzks?.QualifyingEncounter);
                    // CQL 'and' (383:11-387:13): right operand skipped when left is false
                    if (w_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        List<Claim.DiagnosisComponent> x_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Diagnosis;

                        bool? y_(Claim.DiagnosisComponent Dx) {
                            PositiveInt aa_ = Dx?.SequenceElement;
                            int? ab_ = aa_?.Value;
                            List<Claim.ItemComponent> ac_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Item;

                            bool? ad_(Claim.ItemComponent @this) {
                                List<PositiveInt> ai_ = @this?.DiagnosisSequenceElement;

                                int? aj_(PositiveInt @this) {
                                    int? al_ = @this?.Value;
                                    return al_;
                                }

                                IEnumerable<int?> ak_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ai_, aj_);
                                return !((bool?)(ak_ is null));
                            }


                            IEnumerable<int?> ae_(Claim.ItemComponent @this) {
                                List<PositiveInt> am_ = @this?.DiagnosisSequenceElement;

                                int? an_(PositiveInt @this) {
                                    int? ap_ = @this?.Value;
                                    return ap_;
                                }

                                IEnumerable<int?> ao_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)am_, an_);
                                return ao_;
                            }

                            IEnumerable<IEnumerable<int?>> af_ = context.Operators.WhereSelect<Claim.ItemComponent, IEnumerable<int?>>((IEnumerable<Claim.ItemComponent>)ac_, ad_, ae_);
                            IEnumerable<int?> ag_ = context.Operators.Flatten<int?>(af_);
                            bool? ah_ = context.Operators.In<int?>(ab_, ag_);
                            // CQL 'and' (385:17-386:89): right operand skipped when left is false
                            if (ah_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                CodeableConcept aq_ = Dx?.OnAdmission;
                                CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aq_);
                                CqlValueSet as_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                                bool? at_ = context.Operators.ConceptInValueSet(ar_, as_);
                                return ah_ & at_;
                            }
                        }

                        bool? z_ = context.Operators.WhereAny<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)x_, y_);
                        return w_ & z_;
                    }
                }

                bool? u_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)s_, t_);
                return n_ & u_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, Claim>, (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?>(c_, d_, e_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? tuple_epwvnljjfhnvfarkifgamtzks) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? au_ = (CqlTupleMetadata_CUCPZLPbWZQEUULVJBALOjJbh, tuple_epwvnljjfhnvfarkifgamtzks?.QualifyingEncounter, tuple_epwvnljjfhnvfarkifgamtzks?.clm);
            return au_;
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
            // CQL 'and' (427:7-428:45): right operand skipped when left is false
            if (m_ is false)
            {
                return false;
            }
            else
            {
                DataType n_ = FirstHeartBeats?.Value;
                CqlQuantity o_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, n_ as Quantity);
                return m_ & (!((bool?)(o_ is null)));
            }
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType p_ = @this?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
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
            // CQL 'and' (434:7-435:46): right operand skipped when left is false
            if (m_ is false)
            {
                return false;
            }
            else
            {
                DataType n_ = FirstRespiration?.Value;
                CqlQuantity o_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, n_ as Quantity);
                return m_ & (!((bool?)(o_ is null)));
            }
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType p_ = @this?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
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
            // CQL 'and' (420:7-421:46): right operand skipped when left is false
            if (m_ is false)
            {
                return false;
            }
            else
            {
                DataType n_ = FirstTemperature?.Value;
                CqlQuantity o_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, n_ as Quantity);
                return m_ & (!((bool?)(o_ is null)));
            }
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        object d_(Observation @this) {
            DataType p_ = @this?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            return r_;
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

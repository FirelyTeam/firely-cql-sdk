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
                Patient v_ = this.Patient(context);
                e_ = (v_ as DomainResource).Extension;
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
            bool? q_;
            // CQL 'and' (66:11-67:75): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                Period aa_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                CqlDateTime ac_ = context.Operators.End(ab_);
                CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
                bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, "day");
                q_ = p_ & ae_;
            }
            bool? r_;
            // CQL 'and' (66:11-68:48): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                Code<Encounter.EncounterStatus> af_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? ag_ = af_?.Value;
                Code<Encounter.EncounterStatus> ah_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ag_);
                bool? ai_ = context.Operators.Equal(ah_, "finished");
                r_ = q_ & ai_;
            }
            bool? s_;
            // CQL 'and' (66:11-69:74): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
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
                s_ = r_ & as_;
            }
            // CQL 'and' (66:5-70:94): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                CqlInterval<CqlDateTime> at_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                CqlDateTime au_ = context.Operators.Start(at_);
                CqlDateTime av_ = context.Operators.End(at_);
                int? aw_ = context.Operators.DurationBetween(au_, av_, "hour");
                bool? ax_ = context.Operators.GreaterOrEqual(aw_, 48);
                return s_ & ax_;
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
                    DataType aa_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    o_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType ac_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        DataType af_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        o_ = ag_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ah_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlInterval<CqlDateTime>;
                        if (aj_)
                        {
                            DataType ak_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                            o_ = al_ as CqlInterval<CqlDateTime>;
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
                Code<ObservationStatus> am_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.StatusElement;
                ObservationStatus? an_ = am_?.Value;
                string ao_ = context.Operators.Convert<string>(an_);
                string[] ap_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aq_ = context.Operators.In<string>(ao_, (IEnumerable<string>)ap_);
                return n_ & aq_;
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
                i_ = h_ | p_;
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
                    DataType w_ = CreatinineTest?.Effective;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    l_ = x_ as CqlDateTime;
                }
                else
                {
                    DataType y_ = CreatinineTest?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlDateTime;
                    if (aa_)
                    {
                        DataType ab_ = CreatinineTest?.Effective;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        l_ = ac_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ad_ = CreatinineTest?.Effective;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlInterval<CqlDateTime>;
                        if (af_)
                        {
                            DataType ag_ = CreatinineTest?.Effective;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            l_ = ah_ as CqlInterval<CqlDateTime>;
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
                object ai_;
                DataType am_ = CreatinineTest?.Effective;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                bool ao_ = an_ is CqlDateTime;
                if (ao_)
                {
                    DataType ap_ = CreatinineTest?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    ai_ = aq_ as CqlDateTime;
                }
                else
                {
                    DataType ar_ = CreatinineTest?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlDateTime;
                    if (at_)
                    {
                        DataType au_ = CreatinineTest?.Effective;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        ai_ = av_ as CqlDateTime;
                    }
                    else
                    {
                        DataType aw_ = CreatinineTest?.Effective;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        bool ay_ = ax_ is CqlInterval<CqlDateTime>;
                        if (ay_)
                        {
                            DataType az_ = CreatinineTest?.Effective;
                            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                            ai_ = ba_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ai_ = null;
                        }
                    }
                }
                CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_);
                CqlInterval<CqlDateTime> ak_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? al_ = context.Operators.In<CqlDateTime>(aj_, ak_, (string)default);
                k_ = j_ & al_;
            }
            // CQL 'and' (282:5-285:70): right operand skipped when left is false
            if (k_ is false)
            {
                return false;
            }
            else
            {
                Code<ObservationStatus> bb_ = CreatinineTest?.StatusElement;
                ObservationStatus? bc_ = bb_?.Value;
                string bd_ = context.Operators.Convert<string>(bc_);
                string[] be_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bf_ = context.Operators.In<string>(bd_, (IEnumerable<string>)be_);
                return k_ & bf_;
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
            Patient k_ = this.Patient(context);
            a_ = (k_ as DomainResource).Extension;
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension @this) {
            FhirUri l_ = @this?.UrlElement;
            string m_ = FHIRHelpers_4_4_000.Instance.ToString(context, l_);
            bool? n_ = context.Operators.Equal(m_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
            return n_;
        }


        DataType c_(Extension @this) {
            DataType o_ = @this?.Value;
            return o_;
        }

        IEnumerable<DataType> d_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)a_, b_, c_);
        DataType e_ = context.Operators.SingletonFrom<DataType>(d_);
        CqlCode f_ = this.Male__finding_(context);
        string g_ = f_?.code;
        bool? h_ = context.Operators.Equal(e_, g_);
        if (h_ ?? false)
        {
            decimal? p_ = context.Operators.ConvertIntegerToDecimal(142);
            CqlQuantity q_ = this.indexCreatinine(context, QualifyingEncounter);
            decimal? r_ = q_?.value;
            decimal? s_ = context.Operators.Divide(r_, 0.9m);
            decimal? t_ = context.Operators.ConvertIntegerToDecimal(1);
            decimal?[] u_ = [
                s_,
                t_,
            ];
            decimal? v_ = context.Operators.Min<decimal?>((IEnumerable<decimal?>)u_);
            decimal? w_ = context.Operators.Negate(0.302m);
            decimal? x_ = context.Operators.Power(v_, w_);
            decimal? y_ = context.Operators.Multiply(p_, x_);
            decimal? z_ = context.Operators.Max<decimal?>((IEnumerable<decimal?>)u_);
            decimal? aa_ = context.Operators.Negate(1.200m);
            decimal? ab_ = context.Operators.Power(z_, aa_);
            decimal? ac_ = context.Operators.Multiply(y_, ab_);
            Patient ad_ = this.Patient(context);
            Date ae_ = ad_?.BirthDateElement;
            string af_ = ae_?.Value;
            CqlDateTime ag_ = context.Operators.ConvertStringToDateTime(af_);
            CqlInterval<CqlDateTime> ah_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            int? aj_ = context.Operators.CalculateAgeAt(ag_, ai_, "year");
            decimal? ak_ = context.Operators.ConvertIntegerToDecimal(aj_);
            decimal? al_ = context.Operators.Power(0.9938m, ak_);
            decimal? am_ = context.Operators.Multiply(ac_, al_);
            return am_;
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
                DataType x_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                m_ = y_ as CqlDateTime;
            }
            else
            {
                DataType z_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                bool ab_ = aa_ is CqlDateTime;
                if (ab_)
                {
                    DataType ac_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    m_ = ad_ as CqlDateTime;
                }
                else
                {
                    DataType ae_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool ag_ = af_ is CqlInterval<CqlDateTime>;
                    if (ag_)
                    {
                        DataType ah_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        m_ = ai_ as CqlInterval<CqlDateTime>;
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
                bool? aj_ = QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation);
                q_ = p_ & aj_;
            }
            bool? r_;
            // CQL 'and' (233:11-235:76): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                Code<ObservationStatus> ak_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.StatusElement;
                ObservationStatus? al_ = ak_?.Value;
                string am_ = context.Operators.Convert<string>(al_);
                string[] an_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ao_ = context.Operators.In<string>(am_, (IEnumerable<string>)an_);
                r_ = q_ & ao_;
            }
            bool? s_;
            // CQL 'and' (233:11-236:32): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                DataType ap_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                string ar_ = (aq_ as CqlQuantity)?.unit;
                bool? as_ = context.Operators.Equal(ar_, "mg/dL");
                s_ = r_ & as_;
            }
            bool? t_;
            // CQL 'and' (233:11-237:48): right operand skipped when left is false
            if (s_ is false)
            {
                t_ = false;
            }
            else
            {
                DataType at_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                t_ = s_ & (!((bool?)(au_ is null)));
            }
            // CQL 'and' (233:5-238:60): right operand skipped when left is false
            if (t_ is false)
            {
                return false;
            }
            else
            {
                DataType av_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                CqlQuantity ax_ = context.Operators.Quantity(0m, "mg/dL");
                bool? ay_ = context.Operators.Greater(aw_ as CqlQuantity, ax_);
                return t_ & ay_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?> g_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?>(d_, e_, f_);

        (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? h_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? tuple_ccccqpjvqogtctjhtilehkfoj) {
            Id az_ = tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter?.IdElement;
            string ba_ = az_?.Value;
            CqlInterval<CqlDateTime> bb_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter);
            Id bc_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IdElement;
            string bd_ = bc_?.Value;
            object be_;
            if ((QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation)) ?? false)
            {
                be_ = "laboratory";
            }
            else
            {
                bool? bv_ = QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation);
                be_ = bv_;
            }
            List<CodeableConcept> bf_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Category;

            CqlConcept bg_(CodeableConcept @this) {
                CqlConcept bw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bw_;
            }

            IEnumerable<CqlConcept> bh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bf_, bg_);
            Code<ObservationStatus> bi_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.StatusElement;
            ObservationStatus? bj_ = bi_?.Value;
            string bk_ = context.Operators.Convert<string>(bj_);
            DataType bl_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
            string bn_ = (bm_ as CqlQuantity)?.unit;
            decimal? bo_ = (bm_ as CqlQuantity)?.value;
            object bp_;
            DataType bx_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
            bool bz_ = by_ is CqlDateTime;
            if (bz_)
            {
                DataType ca_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bp_ = cb_ as CqlDateTime;
            }
            else
            {
                DataType cc_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                bool ce_ = cd_ is CqlDateTime;
                if (ce_)
                {
                    DataType cf_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bp_ = cg_ as CqlDateTime;
                }
                else
                {
                    DataType ch_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlInterval<CqlDateTime>;
                    if (cj_)
                    {
                        DataType ck_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        bp_ = cl_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bp_ = null;
                    }
                }
            }
            CqlDateTime bq_ = QICoreCommon_4_0_000.Instance.earliest(context, bp_);
            Instant br_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IssuedElement;
            DateTimeOffset? bs_ = br_?.Value;
            CqlDateTime bt_ = context.Operators.Convert<CqlDateTime>(bs_);
            (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? bu_ = (CqlTupleMetadata_EROdcjJjSdFbfXChfKbYbOdDN, ba_, bb_, bd_, be_, bh_, bk_, bm_ as CqlQuantity, bn_, bo_, bq_, bt_);
            return bu_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?, (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(g_, h_);

        object j_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime cm_ = @this?.CrLabTime;
            return cm_;
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
                decimal? f_ = this.maleeGFR(context, QualifyingEncounter);
                decimal? g_ = context.Operators.ConvertIntegerToDecimal(60);
                bool? h_ = context.Operators.Less(f_ as decimal?, g_);
                return e_ & h_;
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
            Patient k_ = this.Patient(context);
            a_ = (k_ as DomainResource).Extension;
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension @this) {
            FhirUri l_ = @this?.UrlElement;
            string m_ = FHIRHelpers_4_4_000.Instance.ToString(context, l_);
            bool? n_ = context.Operators.Equal(m_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
            return n_;
        }


        DataType c_(Extension @this) {
            DataType o_ = @this?.Value;
            return o_;
        }

        IEnumerable<DataType> d_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)a_, b_, c_);
        DataType e_ = context.Operators.SingletonFrom<DataType>(d_);
        CqlCode f_ = this.Female__finding_(context);
        string g_ = f_?.code;
        bool? h_ = context.Operators.Equal(e_, g_);
        if (h_ ?? false)
        {
            decimal? p_ = context.Operators.ConvertIntegerToDecimal(142);
            CqlQuantity q_ = this.indexCreatinine(context, QualifyingEncounter);
            decimal? r_ = q_?.value;
            decimal? s_ = context.Operators.Divide(r_, 0.7m);
            decimal? t_ = context.Operators.ConvertIntegerToDecimal(1);
            decimal?[] u_ = [
                s_,
                t_,
            ];
            decimal? v_ = context.Operators.Min<decimal?>((IEnumerable<decimal?>)u_);
            decimal? w_ = context.Operators.Negate(0.241m);
            decimal? x_ = context.Operators.Power(v_, w_);
            decimal? y_ = context.Operators.Multiply(p_, x_);
            decimal? z_ = context.Operators.Max<decimal?>((IEnumerable<decimal?>)u_);
            decimal? aa_ = context.Operators.Negate(1.200m);
            decimal? ab_ = context.Operators.Power(z_, aa_);
            decimal? ac_ = context.Operators.Multiply(y_, ab_);
            Patient ad_ = this.Patient(context);
            Date ae_ = ad_?.BirthDateElement;
            string af_ = ae_?.Value;
            CqlDateTime ag_ = context.Operators.ConvertStringToDateTime(af_);
            CqlInterval<CqlDateTime> ah_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            int? aj_ = context.Operators.CalculateAgeAt(ag_, ai_, "year");
            decimal? ak_ = context.Operators.ConvertIntegerToDecimal(aj_);
            decimal? al_ = context.Operators.Power(0.9938m, ak_);
            decimal? am_ = context.Operators.Multiply(ac_, al_);
            decimal? an_ = context.Operators.Multiply(am_, 1.012m);
            return an_;
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
                decimal? f_ = this.femaleeGFR(context, QualifyingEncounter);
                decimal? g_ = context.Operators.ConvertIntegerToDecimal(60);
                bool? h_ = context.Operators.Less(f_ as decimal?, g_);
                return e_ & h_;
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
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                p_ = o_ & ab_;
            }
            bool? q_;
            // CQL 'and' (119:11-121:130): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                DataType ac_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                DataType ae_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                CqlQuantity ag_ = context.Operators.Subtract(ad_ as CqlQuantity, af_ as CqlQuantity);
                CqlQuantity ah_ = context.Operators.Quantity(0.299m, "mg/dL");
                bool? ai_ = context.Operators.Greater(ag_, ah_);
                q_ = p_ & ai_;
            }
            bool? r_;
            // CQL 'and' (119:11-122:96): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                DataType aj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                CqlQuantity al_ = this.lowestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? am_ = context.Operators.Equal(ak_ as CqlQuantity, al_);
                r_ = q_ & am_;
            }
            bool? s_;
            // CQL 'and' (119:11-123:135): right operand skipped when left is false
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
                    DataType ba_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    an_ = bb_ as CqlDateTime;
                }
                else
                {
                    DataType bc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlDateTime;
                    if (be_)
                    {
                        DataType bf_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        an_ = bg_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bh_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        bool bj_ = bi_ is CqlInterval<CqlDateTime>;
                        if (bj_)
                        {
                            DataType bk_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                            object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                            an_ = bl_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            an_ = null;
                        }
                    }
                }
                CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_);
                object ap_;
                DataType bm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                bool bo_ = bn_ is CqlDateTime;
                if (bo_)
                {
                    DataType bp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    ap_ = bq_ as CqlDateTime;
                }
                else
                {
                    DataType br_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    bool bt_ = bs_ is CqlDateTime;
                    if (bt_)
                    {
                        DataType bu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        ap_ = bv_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bw_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bool by_ = bx_ is CqlInterval<CqlDateTime>;
                        if (by_)
                        {
                            DataType bz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                            ap_ = ca_ as CqlInterval<CqlDateTime>;
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
                DataType cb_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                bool cd_ = cc_ is CqlDateTime;
                if (cd_)
                {
                    DataType ce_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    at_ = cf_ as CqlDateTime;
                }
                else
                {
                    DataType cg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    bool ci_ = ch_ is CqlDateTime;
                    if (ci_)
                    {
                        DataType cj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        at_ = ck_ as CqlDateTime;
                    }
                    else
                    {
                        DataType cl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                        bool cn_ = cm_ is CqlInterval<CqlDateTime>;
                        if (cn_)
                        {
                            DataType co_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                            object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                            at_ = cp_ as CqlInterval<CqlDateTime>;
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
            // CQL 'and' (119:11-124:75): right operand skipped when left is false
            if (s_ is false)
            {
                t_ = false;
            }
            else
            {
                object cq_;
                DataType cu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                bool cw_ = cv_ is CqlDateTime;
                if (cw_)
                {
                    DataType cx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    cq_ = cy_ as CqlDateTime;
                }
                else
                {
                    DataType cz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlDateTime;
                    if (db_)
                    {
                        DataType dc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        cq_ = dd_ as CqlDateTime;
                    }
                    else
                    {
                        DataType de_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlInterval<CqlDateTime>;
                        if (dg_)
                        {
                            DataType dh_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            cq_ = di_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            cq_ = null;
                        }
                    }
                }
                CqlDateTime cr_ = QICoreCommon_4_0_000.Instance.earliest(context, cq_);
                CqlInterval<CqlDateTime> cs_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? ct_ = context.Operators.In<CqlDateTime>(cr_, cs_, (string)default);
                t_ = s_ & ct_;
            }
            bool? u_;
            // CQL 'and' (119:11-125:145): right operand skipped when left is false
            if (t_ is false)
            {
                u_ = false;
            }
            else
            {
                object dj_;
                DataType dr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                bool dt_ = ds_ is CqlDateTime;
                if (dt_)
                {
                    DataType du_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                    dj_ = dv_ as CqlDateTime;
                }
                else
                {
                    DataType dw_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    bool dy_ = dx_ is CqlDateTime;
                    if (dy_)
                    {
                        DataType dz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                        dj_ = ea_ as CqlDateTime;
                    }
                    else
                    {
                        DataType eb_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                        bool ed_ = ec_ is CqlInterval<CqlDateTime>;
                        if (ed_)
                        {
                            DataType ee_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                            object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                            dj_ = ef_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            dj_ = null;
                        }
                    }
                }
                CqlDateTime dk_ = QICoreCommon_4_0_000.Instance.earliest(context, dj_);
                CqlInterval<CqlDateTime> dl_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlDateTime dm_ = context.Operators.Start(dl_);
                CqlQuantity dn_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime do_ = context.Operators.Add(dm_, dn_);
                CqlInterval<CqlDateTime> dp_ = context.Operators.Interval(dm_, do_, true, true);
                bool? dq_ = context.Operators.In<CqlDateTime>(dk_, dp_, (string)default);
                u_ = t_ & dq_;
            }
            bool? v_;
            // CQL 'and' (119:11-126:80): right operand skipped when left is false
            if (u_ is false)
            {
                v_ = false;
            }
            else
            {
                object eg_;
                DataType ek_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                bool em_ = el_ is CqlDateTime;
                if (em_)
                {
                    DataType en_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    eg_ = eo_ as CqlDateTime;
                }
                else
                {
                    DataType ep_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    bool er_ = eq_ is CqlDateTime;
                    if (er_)
                    {
                        DataType es_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        eg_ = et_ as CqlDateTime;
                    }
                    else
                    {
                        DataType eu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                        bool ew_ = ev_ is CqlInterval<CqlDateTime>;
                        if (ew_)
                        {
                            DataType ex_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                            object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                            eg_ = ey_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            eg_ = null;
                        }
                    }
                }
                CqlDateTime eh_ = QICoreCommon_4_0_000.Instance.earliest(context, eg_);
                CqlInterval<CqlDateTime> ei_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? ej_ = context.Operators.In<CqlDateTime>(eh_, ei_, (string)default);
                v_ = u_ & ej_;
            }
            bool? w_;
            // CQL 'and' (119:11-127:150): right operand skipped when left is false
            if (v_ is false)
            {
                w_ = false;
            }
            else
            {
                object ez_;
                DataType fh_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                bool fj_ = fi_ is CqlDateTime;
                if (fj_)
                {
                    DataType fk_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                    ez_ = fl_ as CqlDateTime;
                }
                else
                {
                    DataType fm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                    bool fo_ = fn_ is CqlDateTime;
                    if (fo_)
                    {
                        DataType fp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                        ez_ = fq_ as CqlDateTime;
                    }
                    else
                    {
                        DataType fr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                        bool ft_ = fs_ is CqlInterval<CqlDateTime>;
                        if (ft_)
                        {
                            DataType fu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                            object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                            ez_ = fv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ez_ = null;
                        }
                    }
                }
                CqlDateTime fa_ = QICoreCommon_4_0_000.Instance.earliest(context, ez_);
                CqlInterval<CqlDateTime> fb_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlDateTime fc_ = context.Operators.Start(fb_);
                CqlQuantity fd_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime fe_ = context.Operators.Add(fc_, fd_);
                CqlInterval<CqlDateTime> ff_ = context.Operators.Interval(fc_, fe_, true, true);
                bool? fg_ = context.Operators.In<CqlDateTime>(fa_, ff_, (string)default);
                w_ = v_ & fg_;
            }
            // CQL 'and' (119:5-128:73): right operand skipped when left is false
            if (w_ is false)
            {
                return false;
            }
            else
            {
                Id fw_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
                string fx_ = fw_?.Value;
                Id fy_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
                string fz_ = fy_?.Value;
                bool? ga_ = context.Operators.Equal(fx_, fz_);
                return w_ & !ga_;
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
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                p_ = o_ & ab_;
            }
            bool? q_;
            // CQL 'and' (139:11-141:130): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                DataType ac_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                DataType ae_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                CqlQuantity ag_ = context.Operators.Subtract(ad_ as CqlQuantity, af_ as CqlQuantity);
                CqlQuantity ah_ = context.Operators.Quantity(0.299m, "mg/dL");
                bool? ai_ = context.Operators.Greater(ag_, ah_);
                q_ = p_ & ai_;
            }
            bool? r_;
            // CQL 'and' (139:11-142:125): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                DataType aj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                IEnumerable<CqlQuantity> al_ = this.earliestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlQuantity am_ = context.Operators.SingletonFrom<CqlQuantity>(al_);
                bool? an_ = context.Operators.Equal(ak_ as CqlQuantity, am_);
                r_ = q_ & an_;
            }
            bool? s_;
            // CQL 'and' (139:11-143:135): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                object ao_;
                DataType ay_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                bool ba_ = az_ is CqlDateTime;
                if (ba_)
                {
                    DataType bb_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    ao_ = bc_ as CqlDateTime;
                }
                else
                {
                    DataType bd_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlDateTime;
                    if (bf_)
                    {
                        DataType bg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        ao_ = bh_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bi_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        bool bk_ = bj_ is CqlInterval<CqlDateTime>;
                        if (bk_)
                        {
                            DataType bl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                            ao_ = bm_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ao_ = null;
                        }
                    }
                }
                CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_);
                object aq_;
                DataType bn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                bool bp_ = bo_ is CqlDateTime;
                if (bp_)
                {
                    DataType bq_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    aq_ = br_ as CqlDateTime;
                }
                else
                {
                    DataType bs_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    bool bu_ = bt_ is CqlDateTime;
                    if (bu_)
                    {
                        DataType bv_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        aq_ = bw_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                        bool bz_ = by_ is CqlInterval<CqlDateTime>;
                        if (bz_)
                        {
                            DataType ca_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                            object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                            aq_ = cb_ as CqlInterval<CqlDateTime>;
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
                DataType cc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                bool ce_ = cd_ is CqlDateTime;
                if (ce_)
                {
                    DataType cf_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    au_ = cg_ as CqlDateTime;
                }
                else
                {
                    DataType ch_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlDateTime;
                    if (cj_)
                    {
                        DataType ck_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        au_ = cl_ as CqlDateTime;
                    }
                    else
                    {
                        DataType cm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlInterval<CqlDateTime>;
                        if (co_)
                        {
                            DataType cp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            au_ = cq_ as CqlInterval<CqlDateTime>;
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
                s_ = r_ & ax_;
            }
            bool? t_;
            // CQL 'and' (139:11-144:75): right operand skipped when left is false
            if (s_ is false)
            {
                t_ = false;
            }
            else
            {
                object cr_;
                DataType cv_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                bool cx_ = cw_ is CqlDateTime;
                if (cx_)
                {
                    DataType cy_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    cr_ = cz_ as CqlDateTime;
                }
                else
                {
                    DataType da_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    bool dc_ = db_ is CqlDateTime;
                    if (dc_)
                    {
                        DataType dd_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                        cr_ = de_ as CqlDateTime;
                    }
                    else
                    {
                        DataType df_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                        bool dh_ = dg_ is CqlInterval<CqlDateTime>;
                        if (dh_)
                        {
                            DataType di_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                            object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                            cr_ = dj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            cr_ = null;
                        }
                    }
                }
                CqlDateTime cs_ = QICoreCommon_4_0_000.Instance.earliest(context, cr_);
                CqlInterval<CqlDateTime> ct_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? cu_ = context.Operators.In<CqlDateTime>(cs_, ct_, (string)default);
                t_ = s_ & cu_;
            }
            bool? u_;
            // CQL 'and' (139:11-145:150): right operand skipped when left is false
            if (t_ is false)
            {
                u_ = false;
            }
            else
            {
                object dk_;
                DataType ds_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                bool du_ = dt_ is CqlDateTime;
                if (du_)
                {
                    DataType dv_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    dk_ = dw_ as CqlDateTime;
                }
                else
                {
                    DataType dx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    bool dz_ = dy_ is CqlDateTime;
                    if (dz_)
                    {
                        DataType ea_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        dk_ = eb_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ec_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                        bool ee_ = ed_ is CqlInterval<CqlDateTime>;
                        if (ee_)
                        {
                            DataType ef_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                            object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                            dk_ = eg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            dk_ = null;
                        }
                    }
                }
                CqlDateTime dl_ = QICoreCommon_4_0_000.Instance.earliest(context, dk_);
                CqlInterval<CqlDateTime> dm_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlDateTime dn_ = context.Operators.Start(dm_);
                CqlQuantity do_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime dp_ = context.Operators.Add(dn_, do_);
                CqlInterval<CqlDateTime> dq_ = context.Operators.Interval(dn_, dp_, true, true);
                bool? dr_ = context.Operators.In<CqlDateTime>(dl_, dq_, (string)default);
                u_ = t_ & dr_;
            }
            bool? v_;
            // CQL 'and' (139:11-146:80): right operand skipped when left is false
            if (u_ is false)
            {
                v_ = false;
            }
            else
            {
                object eh_;
                DataType el_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                bool en_ = em_ is CqlDateTime;
                if (en_)
                {
                    DataType eo_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                    eh_ = ep_ as CqlDateTime;
                }
                else
                {
                    DataType eq_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    bool es_ = er_ is CqlDateTime;
                    if (es_)
                    {
                        DataType et_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                        eh_ = eu_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ev_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                        bool ex_ = ew_ is CqlInterval<CqlDateTime>;
                        if (ex_)
                        {
                            DataType ey_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                            object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                            eh_ = ez_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            eh_ = null;
                        }
                    }
                }
                CqlDateTime ei_ = QICoreCommon_4_0_000.Instance.earliest(context, eh_);
                CqlInterval<CqlDateTime> ej_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                bool? ek_ = context.Operators.In<CqlDateTime>(ei_, ej_, (string)default);
                v_ = u_ & ek_;
            }
            bool? w_;
            // CQL 'and' (139:11-147:145): right operand skipped when left is false
            if (v_ is false)
            {
                w_ = false;
            }
            else
            {
                object fa_;
                DataType fi_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                bool fk_ = fj_ is CqlDateTime;
                if (fk_)
                {
                    DataType fl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    fa_ = fm_ as CqlDateTime;
                }
                else
                {
                    DataType fn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    bool fp_ = fo_ is CqlDateTime;
                    if (fp_)
                    {
                        DataType fq_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                        fa_ = fr_ as CqlDateTime;
                    }
                    else
                    {
                        DataType fs_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                        bool fu_ = ft_ is CqlInterval<CqlDateTime>;
                        if (fu_)
                        {
                            DataType fv_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                            object fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                            fa_ = fw_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            fa_ = null;
                        }
                    }
                }
                CqlDateTime fb_ = QICoreCommon_4_0_000.Instance.earliest(context, fa_);
                CqlInterval<CqlDateTime> fc_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
                CqlDateTime fd_ = context.Operators.Start(fc_);
                CqlQuantity fe_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime ff_ = context.Operators.Add(fd_, fe_);
                CqlInterval<CqlDateTime> fg_ = context.Operators.Interval(fd_, ff_, true, true);
                bool? fh_ = context.Operators.In<CqlDateTime>(fb_, fg_, (string)default);
                w_ = v_ & fh_;
            }
            // CQL 'and' (139:5-148:73): right operand skipped when left is false
            if (w_ is false)
            {
                return false;
            }
            else
            {
                Id fx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
                string fy_ = fx_?.Value;
                Id fz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
                string ga_ = fz_?.Value;
                bool? gb_ = context.Operators.Equal(fy_, ga_);
                return w_ & !gb_;
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
                    DataType ab_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    p_ = ac_ as CqlDateTime;
                }
                else
                {
                    DataType ad_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlQuantity;
                    if (af_)
                    {
                        DataType ag_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        p_ = ah_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ai_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                        if (ak_)
                        {
                            DataType al_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            p_ = am_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType an_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            bool ap_ = ao_ is CqlInterval<CqlQuantity>;
                            if (ap_)
                            {
                                DataType aq_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                                p_ = ar_ as CqlInterval<CqlQuantity>;
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
                object as_;
                DataType ax_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                bool az_ = ay_ is CqlDateTime;
                if (az_)
                {
                    DataType ba_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    as_ = bb_ as CqlDateTime;
                }
                else
                {
                    DataType bc_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlQuantity;
                    if (be_)
                    {
                        DataType bf_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        as_ = bg_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bh_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        bool bj_ = bi_ is CqlInterval<CqlDateTime>;
                        if (bj_)
                        {
                            DataType bk_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                            object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                            as_ = bl_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bm_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                            object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                            bool bo_ = bn_ is CqlInterval<CqlQuantity>;
                            if (bo_)
                            {
                                DataType bp_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                                as_ = bq_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                as_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_);
                CqlDateTime au_ = context.Operators.Start(at_);
                CqlInterval<CqlDateTime> av_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
                bool? aw_ = context.Operators.In<CqlDateTime>(au_, av_, (string)default);
                return o_ & aw_;
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
            Patient k_ = this.Patient(context);
            a_ = (k_ as DomainResource).Extension;
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension @this) {
            FhirUri l_ = @this?.UrlElement;
            string m_ = FHIRHelpers_4_4_000.Instance.ToString(context, l_);
            bool? n_ = context.Operators.Equal(m_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
            return n_;
        }


        DataType c_(Extension @this) {
            DataType o_ = @this?.Value;
            return o_;
        }

        IEnumerable<DataType> d_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)a_, b_, c_);
        DataType e_ = context.Operators.SingletonFrom<DataType>(d_);
        CqlCode f_ = this.Female__finding_(context);
        string g_ = f_?.code;
        bool? h_ = context.Operators.Equal(e_, g_);
        if (h_ ?? false)
        {
            CqlQuantity p_ = context.Operators.Quantity(1.02m, "mg/dL");
            return p_;
        }
        else
        {
            CqlQuantity q_ = context.Operators.Quantity(1.18m, "mg/dL");
            return q_;
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
                DataType ag_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Value;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlQuantity ai_ = this.highestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                bool? aj_ = context.Operators.Equal(ah_ as CqlQuantity, ai_);
                q_ = p_ & aj_;
            }
            bool? r_;
            // CQL 'and' (263:11-267:89): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                DataType ak_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Value;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlQuantity am_ = this.lowestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                bool? an_ = context.Operators.Equal(al_ as CqlQuantity, am_);
                r_ = q_ & an_;
            }
            bool? s_;
            // CQL 'and' (263:11-268:94): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlQuantity ao_ = this.oneAndAHalfIncreaseInCreatinine(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                DataType ap_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Value;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                bool? ar_ = context.Operators.GreaterOrEqual(ao_, aq_ as CqlQuantity);
                s_ = r_ & ar_;
            }
            bool? t_;
            // CQL 'and' (263:11-269:76): right operand skipped when left is false
            if (s_ is false)
            {
                t_ = false;
            }
            else
            {
                object as_;
                DataType bd_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                bool bf_ = be_ is CqlDateTime;
                if (bf_)
                {
                    DataType bg_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    as_ = bh_ as CqlDateTime;
                }
                else
                {
                    DataType bi_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlDateTime;
                    if (bk_)
                    {
                        DataType bl_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        as_ = bm_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bn_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                        if (bp_)
                        {
                            DataType bq_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                            object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                            as_ = br_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            as_ = null;
                        }
                    }
                }
                CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
                object au_;
                DataType bs_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlDateTime;
                if (bu_)
                {
                    DataType bv_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    au_ = bw_ as CqlDateTime;
                }
                else
                {
                    DataType bx_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlDateTime;
                    if (bz_)
                    {
                        DataType ca_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        au_ = cb_ as CqlDateTime;
                    }
                    else
                    {
                        DataType cc_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                        if (ce_)
                        {
                            DataType cf_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            au_ = cg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            au_ = null;
                        }
                    }
                }
                CqlDateTime av_ = QICoreCommon_4_0_000.Instance.earliest(context, au_);
                CqlQuantity aw_ = context.Operators.Quantity(7m, "days");
                CqlDateTime ax_ = context.Operators.Subtract(av_, aw_);
                object ay_;
                DataType ch_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                bool cj_ = ci_ is CqlDateTime;
                if (cj_)
                {
                    DataType ck_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    ay_ = cl_ as CqlDateTime;
                }
                else
                {
                    DataType cm_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    bool co_ = cn_ is CqlDateTime;
                    if (co_)
                    {
                        DataType cp_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                        object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                        ay_ = cq_ as CqlDateTime;
                    }
                    else
                    {
                        DataType cr_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                        object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                        bool ct_ = cs_ is CqlInterval<CqlDateTime>;
                        if (ct_)
                        {
                            DataType cu_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                            object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                            ay_ = cv_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ay_ = null;
                        }
                    }
                }
                CqlDateTime az_ = QICoreCommon_4_0_000.Instance.earliest(context, ay_);
                CqlInterval<CqlDateTime> ba_ = context.Operators.Interval(ax_, az_, true, false);
                bool? bb_ = context.Operators.In<CqlDateTime>(at_, ba_, (string)default);
                bool? bc_;
                // CQL 'and' (269:11-269:76): right operand skipped when left is false
                if (bb_ is false)
                {
                    bc_ = false;
                }
                else
                {
                    object cw_;
                    DataType cy_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    bool da_ = cz_ is CqlDateTime;
                    if (da_)
                    {
                        DataType db_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                        object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                        cw_ = dc_ as CqlDateTime;
                    }
                    else
                    {
                        DataType dd_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                        object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                        bool df_ = de_ is CqlDateTime;
                        if (df_)
                        {
                            DataType dg_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                            object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                            cw_ = dh_ as CqlDateTime;
                        }
                        else
                        {
                            DataType di_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                            object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                            bool dk_ = dj_ is CqlInterval<CqlDateTime>;
                            if (dk_)
                            {
                                DataType dl_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                                object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                                cw_ = dm_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                cw_ = null;
                            }
                        }
                    }
                    CqlDateTime cx_ = QICoreCommon_4_0_000.Instance.earliest(context, cw_);
                    bc_ = bb_ & (!((bool?)(cx_ is null)));
                }
                t_ = s_ & bc_;
            }
            bool? u_;
            // CQL 'and' (263:11-270:68): right operand skipped when left is false
            if (t_ is false)
            {
                u_ = false;
            }
            else
            {
                object dn_;
                DataType dr_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                bool dt_ = ds_ is CqlDateTime;
                if (dt_)
                {
                    DataType du_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                    dn_ = dv_ as CqlDateTime;
                }
                else
                {
                    DataType dw_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    bool dy_ = dx_ is CqlDateTime;
                    if (dy_)
                    {
                        DataType dz_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                        object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                        dn_ = ea_ as CqlDateTime;
                    }
                    else
                    {
                        DataType eb_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                        object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                        bool ed_ = ec_ is CqlInterval<CqlDateTime>;
                        if (ed_)
                        {
                            DataType ee_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                            object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                            dn_ = ef_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            dn_ = null;
                        }
                    }
                }
                CqlDateTime do_ = QICoreCommon_4_0_000.Instance.earliest(context, dn_);
                CqlInterval<CqlDateTime> dp_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                bool? dq_ = context.Operators.In<CqlDateTime>(do_, dp_, (string)default);
                u_ = t_ & dq_;
            }
            bool? v_;
            // CQL 'and' (263:11-271:149): right operand skipped when left is false
            if (u_ is false)
            {
                v_ = false;
            }
            else
            {
                object eg_;
                DataType eq_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                bool es_ = er_ is CqlDateTime;
                if (es_)
                {
                    DataType et_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    eg_ = eu_ as CqlDateTime;
                }
                else
                {
                    DataType ev_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    bool ex_ = ew_ is CqlDateTime;
                    if (ex_)
                    {
                        DataType ey_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                        object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                        eg_ = ez_ as CqlDateTime;
                    }
                    else
                    {
                        DataType fa_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                        object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                        bool fc_ = fb_ is CqlInterval<CqlDateTime>;
                        if (fc_)
                        {
                            DataType fd_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                            object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                            eg_ = fe_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            eg_ = null;
                        }
                    }
                }
                CqlDateTime eh_ = QICoreCommon_4_0_000.Instance.earliest(context, eg_);
                CqlInterval<CqlDateTime> ei_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                CqlDateTime ej_ = context.Operators.Start(ei_);
                CqlQuantity ek_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime el_ = context.Operators.Add(ej_, ek_);
                CqlQuantity em_ = context.Operators.Quantity(30m, "days");
                CqlDateTime en_ = context.Operators.Add(ej_, em_);
                CqlInterval<CqlDateTime> eo_ = context.Operators.Interval(el_, en_, true, true);
                bool? ep_ = context.Operators.In<CqlDateTime>(eh_, eo_, (string)default);
                v_ = u_ & ep_;
            }
            // CQL 'and' (263:5-272:69): right operand skipped when left is false
            if (v_ is false)
            {
                return false;
            }
            else
            {
                object ff_;
                DataType fj_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                bool fl_ = fk_ is CqlDateTime;
                if (fl_)
                {
                    DataType fm_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                    ff_ = fn_ as CqlDateTime;
                }
                else
                {
                    DataType fo_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                    bool fq_ = fp_ is CqlDateTime;
                    if (fq_)
                    {
                        DataType fr_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                        object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                        ff_ = fs_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ft_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                        object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                        bool fv_ = fu_ is CqlInterval<CqlDateTime>;
                        if (fv_)
                        {
                            DataType fw_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                            object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                            ff_ = fx_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ff_ = null;
                        }
                    }
                }
                CqlDateTime fg_ = QICoreCommon_4_0_000.Instance.earliest(context, ff_);
                CqlInterval<CqlDateTime> fh_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
                bool? fi_ = context.Operators.In<CqlDateTime>(fg_, fh_, (string)default);
                return v_ & fi_;
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
                DataType ag_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Value;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlQuantity ai_ = this.highestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                bool? aj_ = context.Operators.Equal(ah_ as CqlQuantity, ai_);
                q_ = p_ & aj_;
            }
            bool? r_;
            // CQL 'and' (176:11-180:97): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                DataType ak_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Value;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlQuantity am_ = this.lowestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                bool? an_ = context.Operators.Equal(al_ as CqlQuantity, am_);
                r_ = q_ & an_;
            }
            bool? s_;
            // CQL 'and' (176:11-181:93): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                DataType ao_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Value;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                DataType aq_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Value;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                bool? as_ = context.Operators.GreaterOrEqual(ap_ as CqlQuantity, ar_ as CqlQuantity);
                s_ = r_ & as_;
            }
            bool? t_;
            // CQL 'and' (176:11-182:76): right operand skipped when left is false
            if (s_ is false)
            {
                t_ = false;
            }
            else
            {
                object at_;
                DataType be_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool bg_ = bf_ is CqlDateTime;
                if (bg_)
                {
                    DataType bh_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    at_ = bi_ as CqlDateTime;
                }
                else
                {
                    DataType bj_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlDateTime;
                    if (bl_)
                    {
                        DataType bm_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        at_ = bn_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bo_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        bool bq_ = bp_ is CqlInterval<CqlDateTime>;
                        if (bq_)
                        {
                            DataType br_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                            at_ = bs_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            at_ = null;
                        }
                    }
                }
                CqlDateTime au_ = QICoreCommon_4_0_000.Instance.earliest(context, at_);
                object av_;
                DataType bt_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                bool bv_ = bu_ is CqlDateTime;
                if (bv_)
                {
                    DataType bw_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    av_ = bx_ as CqlDateTime;
                }
                else
                {
                    DataType by_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    bool ca_ = bz_ is CqlDateTime;
                    if (ca_)
                    {
                        DataType cb_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        av_ = cc_ as CqlDateTime;
                    }
                    else
                    {
                        DataType cd_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                        bool cf_ = ce_ is CqlInterval<CqlDateTime>;
                        if (cf_)
                        {
                            DataType cg_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                            object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                            av_ = ch_ as CqlInterval<CqlDateTime>;
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
                DataType ci_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                bool ck_ = cj_ is CqlDateTime;
                if (ck_)
                {
                    DataType cl_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    az_ = cm_ as CqlDateTime;
                }
                else
                {
                    DataType cn_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    bool cp_ = co_ is CqlDateTime;
                    if (cp_)
                    {
                        DataType cq_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                        az_ = cr_ as CqlDateTime;
                    }
                    else
                    {
                        DataType cs_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                        bool cu_ = ct_ is CqlInterval<CqlDateTime>;
                        if (cu_)
                        {
                            DataType cv_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                            az_ = cw_ as CqlInterval<CqlDateTime>;
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
                bool? bd_;
                // CQL 'and' (182:11-182:76): right operand skipped when left is false
                if (bc_ is false)
                {
                    bd_ = false;
                }
                else
                {
                    object cx_;
                    DataType cz_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlDateTime;
                    if (db_)
                    {
                        DataType dc_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        cx_ = dd_ as CqlDateTime;
                    }
                    else
                    {
                        DataType de_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlDateTime;
                        if (dg_)
                        {
                            DataType dh_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            cx_ = di_ as CqlDateTime;
                        }
                        else
                        {
                            DataType dj_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                            object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                            bool dl_ = dk_ is CqlInterval<CqlDateTime>;
                            if (dl_)
                            {
                                DataType dm_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                                cx_ = dn_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                cx_ = null;
                            }
                        }
                    }
                    CqlDateTime cy_ = QICoreCommon_4_0_000.Instance.earliest(context, cx_);
                    bd_ = bc_ & (!((bool?)(cy_ is null)));
                }
                t_ = s_ & bd_;
            }
            bool? u_;
            // CQL 'and' (176:11-183:68): right operand skipped when left is false
            if (t_ is false)
            {
                u_ = false;
            }
            else
            {
                object do_;
                DataType ds_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                bool du_ = dt_ is CqlDateTime;
                if (du_)
                {
                    DataType dv_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    do_ = dw_ as CqlDateTime;
                }
                else
                {
                    DataType dx_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    bool dz_ = dy_ is CqlDateTime;
                    if (dz_)
                    {
                        DataType ea_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        do_ = eb_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ec_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                        object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                        bool ee_ = ed_ is CqlInterval<CqlDateTime>;
                        if (ee_)
                        {
                            DataType ef_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                            object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                            do_ = eg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            do_ = null;
                        }
                    }
                }
                CqlDateTime dp_ = QICoreCommon_4_0_000.Instance.earliest(context, do_);
                CqlInterval<CqlDateTime> dq_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                bool? dr_ = context.Operators.In<CqlDateTime>(dp_, dq_, (string)default);
                u_ = t_ & dr_;
            }
            bool? v_;
            // CQL 'and' (176:11-184:149): right operand skipped when left is false
            if (u_ is false)
            {
                v_ = false;
            }
            else
            {
                object eh_;
                DataType er_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                bool et_ = es_ is CqlDateTime;
                if (et_)
                {
                    DataType eu_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                    eh_ = ev_ as CqlDateTime;
                }
                else
                {
                    DataType ew_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                    bool ey_ = ex_ is CqlDateTime;
                    if (ey_)
                    {
                        DataType ez_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                        eh_ = fa_ as CqlDateTime;
                    }
                    else
                    {
                        DataType fb_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                        bool fd_ = fc_ is CqlInterval<CqlDateTime>;
                        if (fd_)
                        {
                            DataType fe_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                            object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                            eh_ = ff_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            eh_ = null;
                        }
                    }
                }
                CqlDateTime ei_ = QICoreCommon_4_0_000.Instance.earliest(context, eh_);
                CqlInterval<CqlDateTime> ej_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                CqlDateTime ek_ = context.Operators.Start(ej_);
                CqlQuantity el_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime em_ = context.Operators.Add(ek_, el_);
                CqlQuantity en_ = context.Operators.Quantity(30m, "days");
                CqlDateTime eo_ = context.Operators.Add(ek_, en_);
                CqlInterval<CqlDateTime> ep_ = context.Operators.Interval(em_, eo_, true, true);
                bool? eq_ = context.Operators.In<CqlDateTime>(ei_, ep_, (string)default);
                v_ = u_ & eq_;
            }
            // CQL 'and' (176:5-185:69): right operand skipped when left is false
            if (v_ is false)
            {
                return false;
            }
            else
            {
                object fg_;
                DataType fk_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                bool fm_ = fl_ is CqlDateTime;
                if (fm_)
                {
                    DataType fn_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    fg_ = fo_ as CqlDateTime;
                }
                else
                {
                    DataType fp_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    bool fr_ = fq_ is CqlDateTime;
                    if (fr_)
                    {
                        DataType fs_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                        fg_ = ft_ as CqlDateTime;
                    }
                    else
                    {
                        DataType fu_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                        bool fw_ = fv_ is CqlInterval<CqlDateTime>;
                        if (fw_)
                        {
                            DataType fx_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                            object fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);
                            fg_ = fy_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            fg_ = null;
                        }
                    }
                }
                CqlDateTime fh_ = QICoreCommon_4_0_000.Instance.earliest(context, fg_);
                CqlInterval<CqlDateTime> fi_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
                bool? fj_ = context.Operators.In<CqlDateTime>(fh_, fi_, (string)default);
                return v_ & fj_;
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
                    CodeableConcept p_ = @this?.Code;
                    CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                    return !((bool?)(q_ is null));
                }


                CqlConcept l_(Condition @this) {
                    CodeableConcept r_ = @this?.Code;
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                    return s_;
                }

                IEnumerable<CqlConcept> m_ = context.Operators.WhereSelect<Condition, CqlConcept>(j_, k_, l_);
                CqlValueSet n_ = this.High_Risk_Diagnosis_for_AKI(context);
                bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);
                return h_ | o_;
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
                        DataType t_ = HighRiskProcedures?.Performed;
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        l_ = u_ as CqlDateTime;
                    }
                    else
                    {
                        DataType v_ = HighRiskProcedures?.Performed;
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        bool x_ = w_ is CqlQuantity;
                        if (x_)
                        {
                            DataType y_ = HighRiskProcedures?.Performed;
                            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                            l_ = z_ as CqlQuantity;
                        }
                        else
                        {
                            DataType aa_ = HighRiskProcedures?.Performed;
                            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                            bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                            if (ac_)
                            {
                                DataType ad_ = HighRiskProcedures?.Performed;
                                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                                l_ = ae_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType af_ = HighRiskProcedures?.Performed;
                                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                                bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                                if (ah_)
                                {
                                    DataType ai_ = HighRiskProcedures?.Performed;
                                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                    l_ = aj_ as CqlInterval<CqlQuantity>;
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
                DataType y_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                k_ = z_ as CqlDateTime;
            }
            else
            {
                DataType aa_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                bool ac_ = ab_ is CqlQuantity;
                if (ac_)
                {
                    DataType ad_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    k_ = ae_ as CqlQuantity;
                }
                else
                {
                    DataType af_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    bool ah_ = ag_ is CqlInterval<CqlDateTime>;
                    if (ah_)
                    {
                        DataType ai_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        k_ = aj_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ak_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlInterval<CqlQuantity>;
                        if (am_)
                        {
                            DataType an_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            k_ = ao_ as CqlInterval<CqlQuantity>;
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
                object ap_;
                DataType au_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                bool aw_ = av_ is CqlDateTime;
                if (aw_)
                {
                    DataType ax_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    ap_ = ay_ as CqlDateTime;
                }
                else
                {
                    DataType az_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    bool bb_ = ba_ is CqlQuantity;
                    if (bb_)
                    {
                        DataType bc_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        ap_ = bd_ as CqlQuantity;
                    }
                    else
                    {
                        DataType be_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        bool bg_ = bf_ is CqlInterval<CqlDateTime>;
                        if (bg_)
                        {
                            DataType bh_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            ap_ = bi_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType bj_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                            bool bl_ = bk_ is CqlInterval<CqlQuantity>;
                            if (bl_)
                            {
                                DataType bm_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                                ap_ = bn_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                ap_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                CqlInterval<CqlDateTime> as_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
                bool? at_ = context.Operators.In<CqlDateTime>(ar_, as_, (string)default);
                u_ = t_ & at_;
            }
            // CQL 'and' (216:5-218:39): right operand skipped when left is false
            if (u_ is false)
            {
                return false;
            }
            else
            {
                Code<EventStatus> bo_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.StatusElement;
                EventStatus? bp_ = bo_?.Value;
                string bq_ = context.Operators.Convert<string>(bp_);
                bool? br_ = context.Operators.Equal(bq_, "completed");
                return u_ & br_;
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

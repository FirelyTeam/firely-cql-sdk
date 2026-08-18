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
            Patient aq_ = this.Patient(context);
            bool ar_ = aq_ is DomainResource;
            if (ar_)
            {
                e_ = (aq_ as DomainResource).Extension;
            }
            else
            {
                e_ = default;
            }

            bool? f_(Extension @this) {
                FhirUri as_ = @this?.UrlElement;
                string at_ = FHIRHelpers_4_4_000.Instance.ToString(context, as_);
                CqlBoolean au_ = context.Operators.Equal(at_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                return au_;
            }


            DataType g_(Extension @this) {
                DataType av_ = @this?.Value;
                return av_;
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
            CqlBoolean p_ = context.Operators.In<string>(j_, (IEnumerable<string>)o_);
            Period q_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
            CqlDateTime s_ = context.Operators.End(r_);
            CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
            CqlBoolean u_ = context.Operators.In<CqlDateTime>(s_, t_, "day");
            CqlBoolean v_ = u_;
            Code<Encounter.EncounterStatus> w_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? x_ = w_?.Value;
            Code<Encounter.EncounterStatus> y_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(x_);
            CqlBoolean z_ = context.Operators.Equal(y_, "finished");
            CqlBoolean aa_ = z_;
            Patient ab_ = this.Patient(context);
            Date ac_ = ab_?.BirthDateElement;
            string ad_ = ac_?.Value;
            CqlDate ae_ = context.Operators.ConvertStringToDate(ad_);
            CqlDateTime af_ = context.Operators.Start(r_);
            CqlDate ag_ = context.Operators.DateFrom(af_);
            int? ah_ = context.Operators.CalculateAgeAt(ae_, ag_, "year");
            CqlBoolean ai_ = context.Operators.GreaterOrEqual(ah_, 18);
            CqlBoolean aj_ = ai_;
            CqlInterval<CqlDateTime> ak_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime al_ = context.Operators.Start(ak_);
            CqlDateTime am_ = context.Operators.End(ak_);
            int? an_ = context.Operators.DurationBetween(al_, am_, "hour");
            CqlBoolean ao_ = context.Operators.GreaterOrEqual(an_, 48);
            CqlBoolean ap_ = ao_;
            return p_
                /* CQL 'and' (66:11-67:75) */ && v_
                /* CQL 'and' (66:11-68:48) */ && aa_
                /* CQL 'and' (66:11-69:74) */ && aj_
                /* CQL 'and' (66:5-70:94) */ && ap_;
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
            object m_;
            DataType ac_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool ae_ = ad_ is CqlDateTime;
            if (ae_)
            {
                m_ = ad_ as CqlDateTime;
            }
            else
            {
                if (ae_)
                {
                    m_ = ad_ as CqlDateTime;
                }
                else
                {
                    bool af_ = ad_ is CqlInterval<CqlDateTime>;
                    if (af_)
                    {
                        m_ = ad_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        m_ = null;
                    }
                }
            }
            CqlDateTime n_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
            CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bbcfbwcplsbuhefbwpxpvuequ?.Encounter48Hours);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlQuantity q_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime r_ = context.Operators.Add(p_, q_);
            CqlDateTime s_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> t_ = context.Operators.Interval(r_, s_, true, true);
            CqlBoolean u_ = context.Operators.In<CqlDateTime>(n_, t_, (string)default);
            CqlBoolean v_ = u_;
            Code<ObservationStatus> w_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.StatusElement;
            ObservationStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            string[] z_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
            CqlBoolean ab_ = aa_;
            return (CqlBoolean)((l_ as CqlQuantity) is not null)
                /* CQL 'and' (78:11-79:118) */ && v_
                /* CQL 'and' (78:5-80:70) */ && ab_;
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
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Obstetrics_and_VTE_Obstetrics(context);
            CqlBoolean h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, EncounterWithCreatinine);

            bool? j_(Condition @this) {
                CodeableConcept p_ = @this?.Code;
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                return q_ is not null;
            }


            CqlConcept k_(Condition @this) {
                CodeableConcept r_ = @this?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                return s_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.WhereSelect<Condition, CqlConcept>(i_, j_, k_);
            CqlBoolean m_ = context.Operators.ConceptsInValueSet(l_, g_);
            CqlBoolean n_ = m_;
            return !((bool?)(h_
                /* CQL 'or' (85:15-87:5) */ || n_));
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
            object i_;
            DataType ab_ = CreatinineTest?.Effective;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            bool ad_ = ac_ is CqlDateTime;
            if (ad_)
            {
                i_ = ac_ as CqlDateTime;
            }
            else
            {
                if (ad_)
                {
                    i_ = ac_ as CqlDateTime;
                }
                else
                {
                    bool ae_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        i_ = ac_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        i_ = null;
                    }
                }
            }
            CqlDateTime j_ = QICoreCommon_4_0_000.Instance.earliest(context, i_);
            CqlInterval<CqlDateTime> k_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlQuantity m_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime n_ = context.Operators.Add(l_, m_);
            CqlInterval<CqlDateTime> o_ = context.Operators.Interval(l_, n_, true, true);
            CqlBoolean p_ = context.Operators.In<CqlDateTime>(j_, o_, (string)default);
            CqlBoolean q_ = p_;
            object r_;
            DataType af_ = CreatinineTest?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            bool ah_ = ag_ is CqlDateTime;
            if (ah_)
            {
                r_ = ag_ as CqlDateTime;
            }
            else
            {
                if (ah_)
                {
                    r_ = ag_ as CqlDateTime;
                }
                else
                {
                    bool ai_ = ag_ is CqlInterval<CqlDateTime>;
                    if (ai_)
                    {
                        r_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        r_ = null;
                    }
                }
            }
            CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_);
            CqlBoolean t_ = context.Operators.In<CqlDateTime>(s_, k_, (string)default);
            CqlBoolean u_ = t_;
            Code<ObservationStatus> v_ = CreatinineTest?.StatusElement;
            ObservationStatus? w_ = v_?.Value;
            string x_ = context.Operators.Convert<string>(w_);
            string[] y_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
            CqlBoolean aa_ = z_;
            return (CqlBoolean)((h_ as CqlQuantity) is not null)
                /* CQL 'and' (282:11-283:204) */ && q_
                /* CQL 'and' (282:11-284:109) */ && u_
                /* CQL 'and' (282:5-285:70) */ && aa_;
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
            CqlBoolean f_ = context.Operators.Less(e_, 2);
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
            CqlBoolean m_ = context.Operators.Equal(l_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
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
        CqlBoolean h_ = context.Operators.Equal(e_, g_);
        if (h_.IsTrue)
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
            CqlBoolean j_ = context.Operators.Equal(h_, i_);
            CqlDateTime k_ = LabTestsLow?.CrLabTime;
            CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlQuantity n_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime o_ = context.Operators.Add(m_, n_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
            CqlBoolean q_ = context.Operators.In<CqlDateTime>(k_, p_, (string)default);
            CqlBoolean r_ = q_;
            return j_
                /* CQL 'and' (303:9-304:188) */ && r_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity s_ = @this?.CrLabResult;
            return s_ is not null;
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
            DataType af_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            bool ah_ = ag_ is CqlDateTime;
            if (ah_)
            {
                m_ = ag_ as CqlDateTime;
            }
            else
            {
                if (ah_)
                {
                    m_ = ag_ as CqlDateTime;
                }
                else
                {
                    bool ai_ = ag_ is CqlInterval<CqlDateTime>;
                    if (ai_)
                    {
                        m_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        m_ = null;
                    }
                }
            }
            CqlDateTime n_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
            CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter);
            CqlBoolean p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
            Code<ObservationStatus> q_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.StatusElement;
            ObservationStatus? r_ = q_?.Value;
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
            CqlBoolean v_ = u_;
            DataType w_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            string y_ = (x_ as CqlQuantity)?.unit;
            CqlBoolean z_ = context.Operators.Equal(y_, "mg/dL");
            CqlBoolean aa_ = z_;
            CqlBoolean ab_ = (CqlBoolean)(x_ is not null);
            CqlQuantity ac_ = context.Operators.Quantity(0m, "mg/dL");
            CqlBoolean ad_ = context.Operators.Greater(x_ as CqlQuantity, ac_);
            CqlBoolean ae_ = ad_;
            return p_
                /* CQL 'and' (233:11-234:47) */ && QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation)
                /* CQL 'and' (233:11-235:76) */ && v_
                /* CQL 'and' (233:11-236:32) */ && aa_
                /* CQL 'and' (233:11-237:48) */ && ab_
                /* CQL 'and' (233:5-238:60) */ && ae_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?> g_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?>(d_, e_, f_);

        (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? h_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? tuple_ccccqpjvqogtctjhtilehkfoj) {
            Id aj_ = tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter?.IdElement;
            string ak_ = aj_?.Value;
            CqlInterval<CqlDateTime> al_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter);
            Id am_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IdElement;
            string an_ = am_?.Value;
            object ao_;
            if ((QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation)) ?? false)
            {
                ao_ = "laboratory";
            }
            else
            {
                CqlBoolean bf_ = QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation);
                ao_ = (bool?)bf_;
            }
            List<CodeableConcept> ap_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Category;

            CqlConcept aq_(CodeableConcept @this) {
                CqlConcept bg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bg_;
            }

            IEnumerable<CqlConcept> ar_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ap_, aq_);
            Code<ObservationStatus> as_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.StatusElement;
            ObservationStatus? at_ = as_?.Value;
            string au_ = context.Operators.Convert<string>(at_);
            DataType av_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
            object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
            string ax_ = (aw_ as CqlQuantity)?.unit;
            decimal? ay_ = (aw_ as CqlQuantity)?.value;
            object az_;
            DataType bh_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
            bool bj_ = bi_ is CqlDateTime;
            if (bj_)
            {
                az_ = bi_ as CqlDateTime;
            }
            else
            {
                if (bj_)
                {
                    az_ = bi_ as CqlDateTime;
                }
                else
                {
                    bool bk_ = bi_ is CqlInterval<CqlDateTime>;
                    if (bk_)
                    {
                        az_ = bi_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        az_ = null;
                    }
                }
            }
            CqlDateTime ba_ = QICoreCommon_4_0_000.Instance.earliest(context, az_);
            Instant bb_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IssuedElement;
            DateTimeOffset? bc_ = bb_?.Value;
            CqlDateTime bd_ = context.Operators.Convert<CqlDateTime>(bc_);
            (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? be_ = (CqlTupleMetadata_EROdcjJjSdFbfXChfKbYbOdDN, ak_, al_, an_, ao_, ar_, au_, aw_ as CqlQuantity, ax_, ay_, ba_, bd_);
            return be_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?, (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(g_, h_);

        object j_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime bl_ = @this?.CrLabTime;
            return bl_;
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
            CqlBoolean h_ = context.Operators.Equal(f_, g_);
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
            CqlBoolean j_ = context.Operators.Equal(h_, i_);
            CqlDateTime k_ = LabTests48?.CrLabTime;
            CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlQuantity n_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime o_ = context.Operators.Add(m_, n_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
            CqlBoolean q_ = context.Operators.In<CqlDateTime>(k_, p_, (string)default);
            CqlBoolean r_ = q_;
            return j_
                /* CQL 'and' (319:11-320:189) */ && r_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime s_ = @this?.CrLabTime;
            return s_ is not null;
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
            decimal? e_ = context.Operators.ConvertIntegerToDecimal(60);
            CqlBoolean f_ = context.Operators.Less(d_ as decimal?, e_);
            CqlBoolean g_ = f_;
            return (CqlBoolean)(d_ is not null)
                /* CQL 'and' (104:5-105:60) */ && g_;
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
            CqlBoolean m_ = context.Operators.Equal(l_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
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
        CqlBoolean h_ = context.Operators.Equal(e_, g_);
        if (h_.IsTrue)
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
            decimal? e_ = context.Operators.ConvertIntegerToDecimal(60);
            CqlBoolean f_ = context.Operators.Less(d_ as decimal?, e_);
            CqlBoolean g_ = f_;
            return (CqlBoolean)(d_ is not null)
                /* CQL 'and' (99:5-100:62) */ && g_;
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
            CqlBoolean j_ = context.Operators.Equal(h_, i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity k_ = @this?.CrLabResult;
            return k_ is not null;
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
            CqlBoolean o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
            Code<ObservationStatus> p_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.StatusElement;
            ObservationStatus? q_ = p_?.Value;
            string r_ = context.Operators.Convert<string>(q_);
            CqlBoolean s_ = context.Operators.In<string>(r_, (IEnumerable<string>)n_);
            CqlBoolean t_ = s_;
            DataType u_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Value;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            DataType w_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlQuantity y_ = context.Operators.Subtract(v_ as CqlQuantity, x_ as CqlQuantity);
            CqlQuantity z_ = context.Operators.Quantity(0.299m, "mg/dL");
            CqlBoolean aa_ = context.Operators.Greater(y_, z_);
            CqlBoolean ab_ = aa_;
            CqlQuantity ac_ = this.lowestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            CqlBoolean ad_ = context.Operators.Equal(x_ as CqlQuantity, ac_);
            CqlBoolean ae_ = ad_;
            object af_;
            DataType bt_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
            bool bv_ = bu_ is CqlDateTime;
            if (bv_)
            {
                af_ = bu_ as CqlDateTime;
            }
            else
            {
                if (bv_)
                {
                    af_ = bu_ as CqlDateTime;
                }
                else
                {
                    bool bw_ = bu_ is CqlInterval<CqlDateTime>;
                    if (bw_)
                    {
                        af_ = bu_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        af_ = null;
                    }
                }
            }
            CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_);
            object ah_;
            DataType bx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
            bool bz_ = by_ is CqlDateTime;
            if (bz_)
            {
                ah_ = by_ as CqlDateTime;
            }
            else
            {
                if (bz_)
                {
                    ah_ = by_ as CqlDateTime;
                }
                else
                {
                    bool ca_ = by_ is CqlInterval<CqlDateTime>;
                    if (ca_)
                    {
                        ah_ = by_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ah_ = null;
                    }
                }
            }
            CqlDateTime ai_ = QICoreCommon_4_0_000.Instance.earliest(context, ah_);
            CqlQuantity aj_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime ak_ = context.Operators.Subtract(ai_, aj_);
            object al_;
            DataType cb_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
            bool cd_ = cc_ is CqlDateTime;
            if (cd_)
            {
                al_ = cc_ as CqlDateTime;
            }
            else
            {
                if (cd_)
                {
                    al_ = cc_ as CqlDateTime;
                }
                else
                {
                    bool ce_ = cc_ is CqlInterval<CqlDateTime>;
                    if (ce_)
                    {
                        al_ = cc_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        al_ = null;
                    }
                }
            }
            CqlDateTime am_ = QICoreCommon_4_0_000.Instance.earliest(context, al_);
            CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ak_, am_, true, true);
            CqlBoolean ao_ = context.Operators.In<CqlDateTime>(ag_, an_, (string)default);
            CqlBoolean ap_ = ao_;
            object aq_;
            DataType cf_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
            bool ch_ = cg_ is CqlDateTime;
            if (ch_)
            {
                aq_ = cg_ as CqlDateTime;
            }
            else
            {
                if (ch_)
                {
                    aq_ = cg_ as CqlDateTime;
                }
                else
                {
                    bool ci_ = cg_ is CqlInterval<CqlDateTime>;
                    if (ci_)
                    {
                        aq_ = cg_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        aq_ = null;
                    }
                }
            }
            CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
            CqlInterval<CqlDateTime> as_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            CqlBoolean at_ = context.Operators.In<CqlDateTime>(ar_, as_, (string)default);
            CqlBoolean au_ = at_;
            object av_;
            DataType cj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
            bool cl_ = ck_ is CqlDateTime;
            if (cl_)
            {
                av_ = ck_ as CqlDateTime;
            }
            else
            {
                if (cl_)
                {
                    av_ = ck_ as CqlDateTime;
                }
                else
                {
                    bool cm_ = ck_ is CqlInterval<CqlDateTime>;
                    if (cm_)
                    {
                        av_ = ck_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        av_ = null;
                    }
                }
            }
            CqlDateTime aw_ = QICoreCommon_4_0_000.Instance.earliest(context, av_);
            CqlDateTime ax_ = context.Operators.Start(as_);
            CqlQuantity ay_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime az_ = context.Operators.Add(ax_, ay_);
            CqlInterval<CqlDateTime> ba_ = context.Operators.Interval(ax_, az_, true, true);
            CqlBoolean bb_ = context.Operators.In<CqlDateTime>(aw_, ba_, (string)default);
            CqlBoolean bc_ = bb_;
            object bd_;
            DataType cn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
            bool cp_ = co_ is CqlDateTime;
            if (cp_)
            {
                bd_ = co_ as CqlDateTime;
            }
            else
            {
                if (cp_)
                {
                    bd_ = co_ as CqlDateTime;
                }
                else
                {
                    bool cq_ = co_ is CqlInterval<CqlDateTime>;
                    if (cq_)
                    {
                        bd_ = co_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bd_ = null;
                    }
                }
            }
            CqlDateTime be_ = QICoreCommon_4_0_000.Instance.earliest(context, bd_);
            CqlBoolean bf_ = context.Operators.In<CqlDateTime>(be_, as_, (string)default);
            CqlBoolean bg_ = bf_;
            object bh_;
            DataType cr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
            bool ct_ = cs_ is CqlDateTime;
            if (ct_)
            {
                bh_ = cs_ as CqlDateTime;
            }
            else
            {
                if (ct_)
                {
                    bh_ = cs_ as CqlDateTime;
                }
                else
                {
                    bool cu_ = cs_ is CqlInterval<CqlDateTime>;
                    if (cu_)
                    {
                        bh_ = cs_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bh_ = null;
                    }
                }
            }
            CqlDateTime bi_ = QICoreCommon_4_0_000.Instance.earliest(context, bh_);
            CqlDateTime bj_ = context.Operators.Add(ax_, aj_);
            CqlInterval<CqlDateTime> bk_ = context.Operators.Interval(ax_, bj_, true, true);
            CqlBoolean bl_ = context.Operators.In<CqlDateTime>(bi_, bk_, (string)default);
            CqlBoolean bm_ = bl_;
            Id bn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
            string bo_ = bn_?.Value;
            Id bp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
            string bq_ = bp_?.Value;
            CqlBoolean br_ = context.Operators.Equal(bo_, bq_);
            CqlBoolean bs_ = (CqlBoolean)!br_;
            return o_
                /* CQL 'and' (119:11-120:85) */ && t_
                /* CQL 'and' (119:11-121:130) */ && ab_
                /* CQL 'and' (119:11-122:96) */ && ae_
                /* CQL 'and' (119:11-123:135) */ && ap_
                /* CQL 'and' (119:11-124:75) */ && au_
                /* CQL 'and' (119:11-125:145) */ && bc_
                /* CQL 'and' (119:11-126:80) */ && bg_
                /* CQL 'and' (119:11-127:150) */ && bm_
                /* CQL 'and' (119:5-128:73) */ && bs_;
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
            CqlBoolean h_ = context.Operators.Equal(f_, g_);
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
            CqlBoolean j_ = context.Operators.Equal(h_, i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime k_ = @this?.CrLabTime;
            return k_ is not null;
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
            CqlBoolean o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
            Code<ObservationStatus> p_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.StatusElement;
            ObservationStatus? q_ = p_?.Value;
            string r_ = context.Operators.Convert<string>(q_);
            CqlBoolean s_ = context.Operators.In<string>(r_, (IEnumerable<string>)n_);
            CqlBoolean t_ = s_;
            DataType u_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Value;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            DataType w_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlQuantity y_ = context.Operators.Subtract(v_ as CqlQuantity, x_ as CqlQuantity);
            CqlQuantity z_ = context.Operators.Quantity(0.299m, "mg/dL");
            CqlBoolean aa_ = context.Operators.Greater(y_, z_);
            CqlBoolean ab_ = aa_;
            IEnumerable<CqlQuantity> ac_ = this.earliestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            CqlQuantity ad_ = context.Operators.SingletonFrom<CqlQuantity>(ac_);
            CqlBoolean ae_ = context.Operators.Equal(x_ as CqlQuantity, ad_);
            CqlBoolean af_ = ae_;
            object ag_;
            DataType br_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
            bool bt_ = bs_ is CqlDateTime;
            if (bt_)
            {
                ag_ = bs_ as CqlDateTime;
            }
            else
            {
                if (bt_)
                {
                    ag_ = bs_ as CqlDateTime;
                }
                else
                {
                    bool bu_ = bs_ is CqlInterval<CqlDateTime>;
                    if (bu_)
                    {
                        ag_ = bs_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ag_ = null;
                    }
                }
            }
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            object ai_;
            DataType bv_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            bool bx_ = bw_ is CqlDateTime;
            if (bx_)
            {
                ai_ = bw_ as CqlDateTime;
            }
            else
            {
                if (bx_)
                {
                    ai_ = bw_ as CqlDateTime;
                }
                else
                {
                    bool by_ = bw_ is CqlInterval<CqlDateTime>;
                    if (by_)
                    {
                        ai_ = bw_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ai_ = null;
                    }
                }
            }
            CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_);
            CqlQuantity ak_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime al_ = context.Operators.Subtract(aj_, ak_);
            object am_;
            DataType bz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
            bool cb_ = ca_ is CqlDateTime;
            if (cb_)
            {
                am_ = ca_ as CqlDateTime;
            }
            else
            {
                if (cb_)
                {
                    am_ = ca_ as CqlDateTime;
                }
                else
                {
                    bool cc_ = ca_ is CqlInterval<CqlDateTime>;
                    if (cc_)
                    {
                        am_ = ca_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        am_ = null;
                    }
                }
            }
            CqlDateTime an_ = QICoreCommon_4_0_000.Instance.earliest(context, am_);
            CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(al_, an_, true, true);
            CqlBoolean ap_ = context.Operators.In<CqlDateTime>(ah_, ao_, (string)default);
            CqlBoolean aq_ = ap_;
            object ar_;
            DataType cd_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
            object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
            bool cf_ = ce_ is CqlDateTime;
            if (cf_)
            {
                ar_ = ce_ as CqlDateTime;
            }
            else
            {
                if (cf_)
                {
                    ar_ = ce_ as CqlDateTime;
                }
                else
                {
                    bool cg_ = ce_ is CqlInterval<CqlDateTime>;
                    if (cg_)
                    {
                        ar_ = ce_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ar_ = null;
                    }
                }
            }
            CqlDateTime as_ = QICoreCommon_4_0_000.Instance.earliest(context, ar_);
            CqlInterval<CqlDateTime> at_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            CqlBoolean au_ = context.Operators.In<CqlDateTime>(as_, at_, (string)default);
            CqlBoolean av_ = au_;
            object aw_;
            DataType ch_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
            bool cj_ = ci_ is CqlDateTime;
            if (cj_)
            {
                aw_ = ci_ as CqlDateTime;
            }
            else
            {
                if (cj_)
                {
                    aw_ = ci_ as CqlDateTime;
                }
                else
                {
                    bool ck_ = ci_ is CqlInterval<CqlDateTime>;
                    if (ck_)
                    {
                        aw_ = ci_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        aw_ = null;
                    }
                }
            }
            CqlDateTime ax_ = QICoreCommon_4_0_000.Instance.earliest(context, aw_);
            CqlDateTime ay_ = context.Operators.Start(at_);
            CqlDateTime az_ = context.Operators.Add(ay_, ak_);
            CqlInterval<CqlDateTime> ba_ = context.Operators.Interval(ay_, az_, true, true);
            CqlBoolean bb_ = context.Operators.In<CqlDateTime>(ax_, ba_, (string)default);
            CqlBoolean bc_ = bb_;
            object bd_;
            DataType cl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
            bool cn_ = cm_ is CqlDateTime;
            if (cn_)
            {
                bd_ = cm_ as CqlDateTime;
            }
            else
            {
                if (cn_)
                {
                    bd_ = cm_ as CqlDateTime;
                }
                else
                {
                    bool co_ = cm_ is CqlInterval<CqlDateTime>;
                    if (co_)
                    {
                        bd_ = cm_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bd_ = null;
                    }
                }
            }
            CqlDateTime be_ = QICoreCommon_4_0_000.Instance.earliest(context, bd_);
            CqlBoolean bf_ = context.Operators.In<CqlDateTime>(be_, at_, (string)default);
            CqlBoolean bg_ = bf_;
            object bh_;
            DataType cp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
            bool cr_ = cq_ is CqlDateTime;
            if (cr_)
            {
                bh_ = cq_ as CqlDateTime;
            }
            else
            {
                if (cr_)
                {
                    bh_ = cq_ as CqlDateTime;
                }
                else
                {
                    bool cs_ = cq_ is CqlInterval<CqlDateTime>;
                    if (cs_)
                    {
                        bh_ = cq_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bh_ = null;
                    }
                }
            }
            CqlDateTime bi_ = QICoreCommon_4_0_000.Instance.earliest(context, bh_);
            CqlBoolean bj_ = context.Operators.In<CqlDateTime>(bi_, ba_, (string)default);
            CqlBoolean bk_ = bj_;
            Id bl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
            string bm_ = bl_?.Value;
            Id bn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
            string bo_ = bn_?.Value;
            CqlBoolean bp_ = context.Operators.Equal(bm_, bo_);
            CqlBoolean bq_ = (CqlBoolean)!bp_;
            return o_
                /* CQL 'and' (139:11-140:85) */ && t_
                /* CQL 'and' (139:11-141:130) */ && ab_
                /* CQL 'and' (139:11-142:125) */ && af_
                /* CQL 'and' (139:11-143:135) */ && aq_
                /* CQL 'and' (139:11-144:75) */ && av_
                /* CQL 'and' (139:11-145:150) */ && bc_
                /* CQL 'and' (139:11-146:80) */ && bg_
                /* CQL 'and' (139:11-147:145) */ && bk_
                /* CQL 'and' (139:5-148:73) */ && bq_;
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
            CqlBoolean n_ = context.Operators.Equal(m_, "completed");
            object o_;
            DataType ad_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            bool af_ = ae_ is CqlDateTime;
            if (af_)
            {
                o_ = ae_ as CqlDateTime;
            }
            else
            {
                bool ag_ = ae_ is CqlQuantity;
                if (ag_)
                {
                    o_ = ae_ as CqlQuantity;
                }
                else
                {
                    bool ah_ = ae_ is CqlInterval<CqlDateTime>;
                    if (ah_)
                    {
                        o_ = ae_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ai_ = ae_ is CqlInterval<CqlQuantity>;
                        if (ai_)
                        {
                            o_ = ae_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            o_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlInterval<CqlDateTime> r_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlQuantity t_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime u_ = context.Operators.Add(s_, t_);
            CqlInterval<CqlDateTime> v_ = context.Operators.Interval(s_, u_, true, true);
            CqlBoolean w_ = context.Operators.In<CqlDateTime>(q_, v_, (string)default);
            CqlBoolean x_ = w_;
            object y_;
            DataType aj_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            bool al_ = ak_ is CqlDateTime;
            if (al_)
            {
                y_ = ak_ as CqlDateTime;
            }
            else
            {
                bool am_ = ak_ is CqlQuantity;
                if (am_)
                {
                    y_ = ak_ as CqlQuantity;
                }
                else
                {
                    bool an_ = ak_ is CqlInterval<CqlDateTime>;
                    if (an_)
                    {
                        y_ = ak_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ao_ = ak_ is CqlInterval<CqlQuantity>;
                        if (ao_)
                        {
                            y_ = ak_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            y_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            CqlBoolean ab_ = context.Operators.In<CqlDateTime>(aa_, r_, (string)default);
            CqlBoolean ac_ = ab_;
            return n_
                /* CQL 'and' (163:11-164:157) */ && x_
                /* CQL 'and' (163:5-165:87) */ && ac_;
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
            CqlBoolean m_ = context.Operators.Equal(l_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
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
        CqlBoolean h_ = context.Operators.Equal(e_, g_);
        if (h_.IsTrue)
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
            CqlBoolean j_ = context.Operators.Equal(h_, i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity k_ = @this?.CrLabResult;
            return k_ is not null;
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
            CqlBoolean n_ = context.Operators.Greater(l_ as CqlQuantity, m_);
            Code<ObservationStatus> o_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.StatusElement;
            ObservationStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            string[] r_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
            CqlBoolean t_ = s_;
            Code<ObservationStatus> u_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.StatusElement;
            ObservationStatus? v_ = u_?.Value;
            string w_ = context.Operators.Convert<string>(v_);
            CqlBoolean x_ = context.Operators.In<string>(w_, (IEnumerable<string>)r_);
            CqlBoolean y_ = x_;
            CqlQuantity z_ = this.highestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            CqlBoolean aa_ = context.Operators.Equal(l_ as CqlQuantity, z_);
            CqlBoolean ab_ = aa_;
            DataType ac_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlQuantity ae_ = this.lowestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            CqlBoolean af_ = context.Operators.Equal(ad_ as CqlQuantity, ae_);
            CqlBoolean ag_ = af_;
            CqlQuantity ah_ = this.oneAndAHalfIncreaseInCreatinine(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            CqlBoolean ai_ = context.Operators.GreaterOrEqual(ah_, ad_ as CqlQuantity);
            CqlBoolean aj_ = ai_;
            object ak_;
            DataType br_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
            bool bt_ = bs_ is CqlDateTime;
            if (bt_)
            {
                ak_ = bs_ as CqlDateTime;
            }
            else
            {
                if (bt_)
                {
                    ak_ = bs_ as CqlDateTime;
                }
                else
                {
                    bool bu_ = bs_ is CqlInterval<CqlDateTime>;
                    if (bu_)
                    {
                        ak_ = bs_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ak_ = null;
                    }
                }
            }
            CqlDateTime al_ = QICoreCommon_4_0_000.Instance.earliest(context, ak_);
            object am_;
            DataType bv_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            bool bx_ = bw_ is CqlDateTime;
            if (bx_)
            {
                am_ = bw_ as CqlDateTime;
            }
            else
            {
                if (bx_)
                {
                    am_ = bw_ as CqlDateTime;
                }
                else
                {
                    bool by_ = bw_ is CqlInterval<CqlDateTime>;
                    if (by_)
                    {
                        am_ = bw_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        am_ = null;
                    }
                }
            }
            CqlDateTime an_ = QICoreCommon_4_0_000.Instance.earliest(context, am_);
            CqlQuantity ao_ = context.Operators.Quantity(7m, "days");
            CqlDateTime ap_ = context.Operators.Subtract(an_, ao_);
            object aq_;
            DataType bz_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
            bool cb_ = ca_ is CqlDateTime;
            if (cb_)
            {
                aq_ = ca_ as CqlDateTime;
            }
            else
            {
                if (cb_)
                {
                    aq_ = ca_ as CqlDateTime;
                }
                else
                {
                    bool cc_ = ca_ is CqlInterval<CqlDateTime>;
                    if (cc_)
                    {
                        aq_ = ca_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        aq_ = null;
                    }
                }
            }
            CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
            CqlInterval<CqlDateTime> as_ = context.Operators.Interval(ap_, ar_, true, false);
            CqlBoolean at_ = context.Operators.In<CqlDateTime>(al_, as_, (string)default);
            object au_;
            DataType cd_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
            object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
            bool cf_ = ce_ is CqlDateTime;
            if (cf_)
            {
                au_ = ce_ as CqlDateTime;
            }
            else
            {
                if (cf_)
                {
                    au_ = ce_ as CqlDateTime;
                }
                else
                {
                    bool cg_ = ce_ is CqlInterval<CqlDateTime>;
                    if (cg_)
                    {
                        au_ = ce_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        au_ = null;
                    }
                }
            }
            CqlDateTime av_ = QICoreCommon_4_0_000.Instance.earliest(context, au_);
            CqlBoolean aw_ = (CqlBoolean)(av_ is not null);
            CqlBoolean ax_ = at_
                /* CQL 'and' (269:11-269:76) */ && aw_;
            object ay_;
            DataType ch_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
            bool cj_ = ci_ is CqlDateTime;
            if (cj_)
            {
                ay_ = ci_ as CqlDateTime;
            }
            else
            {
                if (cj_)
                {
                    ay_ = ci_ as CqlDateTime;
                }
                else
                {
                    bool ck_ = ci_ is CqlInterval<CqlDateTime>;
                    if (ck_)
                    {
                        ay_ = ci_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ay_ = null;
                    }
                }
            }
            CqlDateTime az_ = QICoreCommon_4_0_000.Instance.earliest(context, ay_);
            CqlInterval<CqlDateTime> ba_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            CqlBoolean bb_ = context.Operators.In<CqlDateTime>(az_, ba_, (string)default);
            CqlBoolean bc_ = bb_;
            object bd_;
            DataType cl_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
            object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
            bool cn_ = cm_ is CqlDateTime;
            if (cn_)
            {
                bd_ = cm_ as CqlDateTime;
            }
            else
            {
                if (cn_)
                {
                    bd_ = cm_ as CqlDateTime;
                }
                else
                {
                    bool co_ = cm_ is CqlInterval<CqlDateTime>;
                    if (co_)
                    {
                        bd_ = cm_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bd_ = null;
                    }
                }
            }
            CqlDateTime be_ = QICoreCommon_4_0_000.Instance.earliest(context, bd_);
            CqlDateTime bf_ = context.Operators.Start(ba_);
            CqlQuantity bg_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime bh_ = context.Operators.Add(bf_, bg_);
            CqlQuantity bi_ = context.Operators.Quantity(30m, "days");
            CqlDateTime bj_ = context.Operators.Add(bf_, bi_);
            CqlInterval<CqlDateTime> bk_ = context.Operators.Interval(bh_, bj_, true, true);
            CqlBoolean bl_ = context.Operators.In<CqlDateTime>(be_, bk_, (string)default);
            CqlBoolean bm_ = bl_;
            object bn_;
            DataType cp_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
            bool cr_ = cq_ is CqlDateTime;
            if (cr_)
            {
                bn_ = cq_ as CqlDateTime;
            }
            else
            {
                if (cr_)
                {
                    bn_ = cq_ as CqlDateTime;
                }
                else
                {
                    bool cs_ = cq_ is CqlInterval<CqlDateTime>;
                    if (cs_)
                    {
                        bn_ = cq_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bn_ = null;
                    }
                }
            }
            CqlDateTime bo_ = QICoreCommon_4_0_000.Instance.earliest(context, bn_);
            CqlBoolean bp_ = context.Operators.In<CqlDateTime>(bo_, ba_, (string)default);
            CqlBoolean bq_ = bp_;
            return n_
                /* CQL 'and' (263:11-264:73) */ && t_
                /* CQL 'and' (263:11-265:74) */ && y_
                /* CQL 'and' (263:11-266:91) */ && ab_
                /* CQL 'and' (263:11-267:89) */ && ag_
                /* CQL 'and' (263:11-268:94) */ && aj_
                /* CQL 'and' (263:11-269:76) */ && ax_
                /* CQL 'and' (263:11-270:68) */ && bc_
                /* CQL 'and' (263:11-271:149) */ && bm_
                /* CQL 'and' (263:5-272:69) */ && bq_;
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
            CqlBoolean n_ = context.Operators.Greater(l_ as CqlQuantity, m_);
            Code<ObservationStatus> o_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.StatusElement;
            ObservationStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            string[] r_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
            CqlBoolean t_ = s_;
            Code<ObservationStatus> u_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.StatusElement;
            ObservationStatus? v_ = u_?.Value;
            string w_ = context.Operators.Convert<string>(v_);
            CqlBoolean x_ = context.Operators.In<string>(w_, (IEnumerable<string>)r_);
            CqlBoolean y_ = x_;
            CqlQuantity z_ = this.highestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            CqlBoolean aa_ = context.Operators.Equal(l_ as CqlQuantity, z_);
            CqlBoolean ab_ = aa_;
            DataType ac_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlQuantity ae_ = this.lowestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            CqlBoolean af_ = context.Operators.Equal(ad_ as CqlQuantity, ae_);
            CqlBoolean ag_ = af_;
            CqlBoolean ah_ = context.Operators.GreaterOrEqual(l_ as CqlQuantity, ad_ as CqlQuantity);
            CqlBoolean ai_ = ah_;
            object aj_;
            DataType bq_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
            object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
            bool bs_ = br_ is CqlDateTime;
            if (bs_)
            {
                aj_ = br_ as CqlDateTime;
            }
            else
            {
                if (bs_)
                {
                    aj_ = br_ as CqlDateTime;
                }
                else
                {
                    bool bt_ = br_ is CqlInterval<CqlDateTime>;
                    if (bt_)
                    {
                        aj_ = br_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        aj_ = null;
                    }
                }
            }
            CqlDateTime ak_ = QICoreCommon_4_0_000.Instance.earliest(context, aj_);
            object al_;
            DataType bu_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
            bool bw_ = bv_ is CqlDateTime;
            if (bw_)
            {
                al_ = bv_ as CqlDateTime;
            }
            else
            {
                if (bw_)
                {
                    al_ = bv_ as CqlDateTime;
                }
                else
                {
                    bool bx_ = bv_ is CqlInterval<CqlDateTime>;
                    if (bx_)
                    {
                        al_ = bv_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        al_ = null;
                    }
                }
            }
            CqlDateTime am_ = QICoreCommon_4_0_000.Instance.earliest(context, al_);
            CqlQuantity an_ = context.Operators.Quantity(7m, "days");
            CqlDateTime ao_ = context.Operators.Subtract(am_, an_);
            object ap_;
            DataType by_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
            object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
            bool ca_ = bz_ is CqlDateTime;
            if (ca_)
            {
                ap_ = bz_ as CqlDateTime;
            }
            else
            {
                if (ca_)
                {
                    ap_ = bz_ as CqlDateTime;
                }
                else
                {
                    bool cb_ = bz_ is CqlInterval<CqlDateTime>;
                    if (cb_)
                    {
                        ap_ = bz_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ap_ = null;
                    }
                }
            }
            CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
            CqlInterval<CqlDateTime> ar_ = context.Operators.Interval(ao_, aq_, true, false);
            CqlBoolean as_ = context.Operators.In<CqlDateTime>(ak_, ar_, (string)default);
            object at_;
            DataType cc_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
            object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
            bool ce_ = cd_ is CqlDateTime;
            if (ce_)
            {
                at_ = cd_ as CqlDateTime;
            }
            else
            {
                if (ce_)
                {
                    at_ = cd_ as CqlDateTime;
                }
                else
                {
                    bool cf_ = cd_ is CqlInterval<CqlDateTime>;
                    if (cf_)
                    {
                        at_ = cd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        at_ = null;
                    }
                }
            }
            CqlDateTime au_ = QICoreCommon_4_0_000.Instance.earliest(context, at_);
            CqlBoolean av_ = (CqlBoolean)(au_ is not null);
            CqlBoolean aw_ = as_
                /* CQL 'and' (182:11-182:76) */ && av_;
            object ax_;
            DataType cg_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
            object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
            bool ci_ = ch_ is CqlDateTime;
            if (ci_)
            {
                ax_ = ch_ as CqlDateTime;
            }
            else
            {
                if (ci_)
                {
                    ax_ = ch_ as CqlDateTime;
                }
                else
                {
                    bool cj_ = ch_ is CqlInterval<CqlDateTime>;
                    if (cj_)
                    {
                        ax_ = ch_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ax_ = null;
                    }
                }
            }
            CqlDateTime ay_ = QICoreCommon_4_0_000.Instance.earliest(context, ax_);
            CqlInterval<CqlDateTime> az_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            CqlBoolean ba_ = context.Operators.In<CqlDateTime>(ay_, az_, (string)default);
            CqlBoolean bb_ = ba_;
            object bc_;
            DataType ck_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
            object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
            bool cm_ = cl_ is CqlDateTime;
            if (cm_)
            {
                bc_ = cl_ as CqlDateTime;
            }
            else
            {
                if (cm_)
                {
                    bc_ = cl_ as CqlDateTime;
                }
                else
                {
                    bool cn_ = cl_ is CqlInterval<CqlDateTime>;
                    if (cn_)
                    {
                        bc_ = cl_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bc_ = null;
                    }
                }
            }
            CqlDateTime bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
            CqlDateTime be_ = context.Operators.Start(az_);
            CqlQuantity bf_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime bg_ = context.Operators.Add(be_, bf_);
            CqlQuantity bh_ = context.Operators.Quantity(30m, "days");
            CqlDateTime bi_ = context.Operators.Add(be_, bh_);
            CqlInterval<CqlDateTime> bj_ = context.Operators.Interval(bg_, bi_, true, true);
            CqlBoolean bk_ = context.Operators.In<CqlDateTime>(bd_, bj_, (string)default);
            CqlBoolean bl_ = bk_;
            object bm_;
            DataType co_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
            object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
            bool cq_ = cp_ is CqlDateTime;
            if (cq_)
            {
                bm_ = cp_ as CqlDateTime;
            }
            else
            {
                if (cq_)
                {
                    bm_ = cp_ as CqlDateTime;
                }
                else
                {
                    bool cr_ = cp_ is CqlInterval<CqlDateTime>;
                    if (cr_)
                    {
                        bm_ = cp_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bm_ = null;
                    }
                }
            }
            CqlDateTime bn_ = QICoreCommon_4_0_000.Instance.earliest(context, bm_);
            CqlBoolean bo_ = context.Operators.In<CqlDateTime>(bn_, az_, (string)default);
            CqlBoolean bp_ = bo_;
            return n_
                /* CQL 'and' (176:11-177:73) */ && t_
                /* CQL 'and' (176:11-178:74) */ && y_
                /* CQL 'and' (176:11-179:99) */ && ab_
                /* CQL 'and' (176:11-180:97) */ && ag_
                /* CQL 'and' (176:11-181:93) */ && ai_
                /* CQL 'and' (176:11-182:76) */ && aw_
                /* CQL 'and' (176:11-183:68) */ && bb_
                /* CQL 'and' (176:11-184:149) */ && bl_
                /* CQL 'and' (176:5-185:69) */ && bp_;
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
                CqlBoolean k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, (string)default);
                return k_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<Encounter>(d_, e_);
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
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.High_Risk_Diagnosis_for_AKI(context);
            CqlBoolean h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? j_(Condition @this) {
                CodeableConcept p_ = @this?.Code;
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                return q_ is not null;
            }


            CqlConcept k_(Condition @this) {
                CodeableConcept r_ = @this?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                return s_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.WhereSelect<Condition, CqlConcept>(i_, j_, k_);
            CqlBoolean m_ = context.Operators.ConceptsInValueSet(l_, g_);
            CqlBoolean n_ = m_;
            return h_
                /* CQL 'or' (194:5-196:5) */ || n_;
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
                CqlBoolean k_ = context.Operators.Equal(j_, "completed");
                object l_;
                DataType r_ = HighRiskProcedures?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                if (t_)
                {
                    l_ = s_ as CqlDateTime;
                }
                else
                {
                    bool u_ = s_ is CqlQuantity;
                    if (u_)
                    {
                        l_ = s_ as CqlQuantity;
                    }
                    else
                    {
                        bool v_ = s_ is CqlInterval<CqlDateTime>;
                        if (v_)
                        {
                            l_ = s_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool w_ = s_ is CqlInterval<CqlQuantity>;
                            if (w_)
                            {
                                l_ = s_ as CqlInterval<CqlQuantity>;
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
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
                CqlBoolean q_ = p_;
                return k_
                    /* CQL 'and' (201:17-202:124) */ && q_;
            }

            CqlBoolean g_ = context.Operators.WhereAny<Procedure>(e_, f_);
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
            DataType ae_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            bool ag_ = af_ is CqlDateTime;
            if (ag_)
            {
                k_ = af_ as CqlDateTime;
            }
            else
            {
                bool ah_ = af_ is CqlQuantity;
                if (ah_)
                {
                    k_ = af_ as CqlQuantity;
                }
                else
                {
                    bool ai_ = af_ is CqlInterval<CqlDateTime>;
                    if (ai_)
                    {
                        k_ = af_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool aj_ = af_ is CqlInterval<CqlQuantity>;
                        if (aj_)
                        {
                            k_ = af_ as CqlInterval<CqlQuantity>;
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
            CqlBoolean t_ = context.Operators.In<CqlDateTime>(m_, s_, (string)default);
            object u_;
            DataType ak_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            bool am_ = al_ is CqlDateTime;
            if (am_)
            {
                u_ = al_ as CqlDateTime;
            }
            else
            {
                bool an_ = al_ is CqlQuantity;
                if (an_)
                {
                    u_ = al_ as CqlQuantity;
                }
                else
                {
                    bool ao_ = al_ is CqlInterval<CqlDateTime>;
                    if (ao_)
                    {
                        u_ = al_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ap_ = al_ is CqlInterval<CqlQuantity>;
                        if (ap_)
                        {
                            u_ = al_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            u_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlBoolean x_ = context.Operators.In<CqlDateTime>(w_, n_, (string)default);
            CqlBoolean y_ = x_;
            Code<EventStatus> z_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.StatusElement;
            EventStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            CqlBoolean ac_ = context.Operators.Equal(ab_, "completed");
            CqlBoolean ad_ = ac_;
            return t_
                /* CQL 'and' (216:11-217:87) */ && y_
                /* CQL 'and' (216:5-218:39) */ && ad_;
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
                CqlBoolean k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, (string)default);
                return k_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<Encounter>(d_, e_);
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
            CqlBoolean h_ = context.Operators.In<CqlDateTime>(f_, g_, "day");
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
            CqlBoolean m_ = context.Operators.Equal(l_, "active");
            Code<ClaimUseCode> n_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.UseElement;
            ClaimUseCode? o_ = n_?.Value;
            Code<ClaimUseCode> p_ = context.Operators.Convert<Code<ClaimUseCode>>(o_);
            CqlBoolean q_ = context.Operators.Equal(p_, "claim");
            CqlBoolean r_ = q_;
            List<Claim.ItemComponent> s_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Item;

            bool? t_(Claim.ItemComponent ClaimItem) {
                List<ResourceReference> w_ = ClaimItem?.Encounter;
                CqlBoolean x_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)w_, tuple_epwvnljjfhnvfarkifgamtzks?.QualifyingEncounter);
                List<Claim.DiagnosisComponent> y_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Diagnosis;

                bool? z_(Claim.DiagnosisComponent Dx) {
                    PositiveInt ac_ = Dx?.SequenceElement;
                    int? ad_ = ac_?.Value;
                    List<Claim.ItemComponent> ae_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Item;

                    bool? af_(Claim.ItemComponent @this) {
                        List<PositiveInt> ap_ = @this?.DiagnosisSequenceElement;

                        int? aq_(PositiveInt @this) {
                            int? as_ = @this?.Value;
                            return as_;
                        }

                        IEnumerable<int?> ar_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ap_, aq_);
                        return ar_ is not null;
                    }


                    IEnumerable<int?> ag_(Claim.ItemComponent @this) {
                        List<PositiveInt> at_ = @this?.DiagnosisSequenceElement;

                        int? au_(PositiveInt @this) {
                            int? aw_ = @this?.Value;
                            return aw_;
                        }

                        IEnumerable<int?> av_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)at_, au_);
                        return av_;
                    }

                    IEnumerable<IEnumerable<int?>> ah_ = context.Operators.WhereSelect<Claim.ItemComponent, IEnumerable<int?>>((IEnumerable<Claim.ItemComponent>)ae_, af_, ag_);
                    IEnumerable<int?> ai_ = context.Operators.Flatten<int?>(ah_);
                    CqlBoolean aj_ = context.Operators.In<int?>(ad_, ai_);
                    CodeableConcept ak_ = Dx?.OnAdmission;
                    CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_);
                    CqlValueSet am_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                    CqlBoolean an_ = context.Operators.ConceptInValueSet(al_, am_);
                    CqlBoolean ao_ = an_;
                    return aj_
                        /* CQL 'and' (385:17-386:89) */ && ao_;
                }

                CqlBoolean aa_ = context.Operators.WhereAny<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)y_, z_);
                CqlBoolean ab_ = aa_;
                return x_
                    /* CQL 'and' (383:11-387:13) */ && ab_;
            }

            CqlBoolean u_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)s_, t_);
            CqlBoolean v_ = u_;
            return m_
                /* CQL 'and' (380:11-381:27) */ && r_
                /* CQL 'and' (380:5-388:7) */ && v_;
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
            CqlBoolean m_ = context.Operators.In<CqlDateTime>(k_, l_, (string)default);
            DataType n_ = FirstHeartBeats?.Value;
            CqlQuantity o_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, n_ as Quantity);
            CqlBoolean p_ = (CqlBoolean)(o_ is not null);
            return m_
                /* CQL 'and' (427:7-428:45) */ && p_;
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
            CqlBoolean m_ = context.Operators.In<CqlDateTime>(k_, l_, (string)default);
            DataType n_ = FirstRespiration?.Value;
            CqlQuantity o_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, n_ as Quantity);
            CqlBoolean p_ = (CqlBoolean)(o_ is not null);
            return m_
                /* CQL 'and' (434:7-435:46) */ && p_;
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
            CqlBoolean k_ = context.Operators.In<CqlDateTime>(i_, j_, (string)default);
            return k_;
        }


        CqlQuantity c_(Observation SBPReading) {
            List<Observation.ComponentComponent> l_ = SBPReading?.Component;

            bool? m_(Observation.ComponentComponent SBPComponent) {
                CodeableConcept r_ = SBPComponent?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlCode t_ = this.Systolic_blood_pressure(context);
                CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                CqlBoolean v_ = context.Operators.Equivalent(s_, u_);
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
            CqlBoolean m_ = context.Operators.In<CqlDateTime>(k_, l_, (string)default);
            DataType n_ = FirstTemperature?.Value;
            CqlQuantity o_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, n_ as Quantity);
            CqlBoolean p_ = (CqlBoolean)(o_ is not null);
            return m_
                /* CQL 'and' (420:7-421:46) */ && p_;
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

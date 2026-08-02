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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.8.0")]
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
                Patient as_ = this.Patient(context);
                e_ = (as_ as DomainResource).Extension;
            }
            else
            {
                e_ = default;
            }

            bool? f_(Extension @this) {
                FhirUri at_ = @this?.UrlElement;
                string au_ = FHIRHelpers_4_4_000.Instance.ToString(context, at_);
                bool? av_ = context.Operators.Equal(au_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                return av_;
            }


            DataType g_(Extension @this) {
                DataType aw_ = @this?.Value;
                return aw_;
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
            Period q_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
            CqlDateTime s_ = context.Operators.End(r_);
            CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
            bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, "day");
            bool? v_ = context.Operators.And(p_, u_);
            Code<Encounter.EncounterStatus> w_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? x_ = w_?.Value;
            Code<Encounter.EncounterStatus> y_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(x_);
            bool? z_ = context.Operators.Equal(y_, "finished");
            bool? aa_ = context.Operators.And(v_, z_);
            Patient ab_ = this.Patient(context);
            Date ac_ = ab_?.BirthDateElement;
            string ad_ = ac_?.Value;
            CqlDate ae_ = context.Operators.ConvertStringToDate(ad_);
            CqlDateTime af_ = context.Operators.Start(r_);
            CqlDate ag_ = context.Operators.DateFrom(af_);
            int? ah_ = context.Operators.CalculateAgeAt(ae_, ag_, "year");
            bool? ai_ = context.Operators.GreaterOrEqual(ah_, 18);
            bool? aj_ = context.Operators.And(aa_, ai_);
            CqlInterval<CqlDateTime> ak_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime al_ = context.Operators.Start(ak_);
            CqlDateTime am_ = context.Operators.End(ak_);
            int? an_ = context.Operators.DurationBetween(al_, am_, "hour");
            bool? ao_ = context.Operators.GreaterOrEqual(an_, 48);
            bool? ap_ = context.Operators.And(aj_, ao_);
            return ap_;
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
            bool? m_ = context.Operators.Not((bool?)((l_ as CqlQuantity) is null));
            object n_;
            DataType ad_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            bool af_ = ae_ is CqlDateTime;
            if (af_)
            {
                DataType ag_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                n_ = ah_ as CqlDateTime;
            }
            else
            {
                DataType ai_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool ak_ = aj_ is CqlDateTime;
                if (ak_)
                {
                    DataType al_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    n_ = am_ as CqlDateTime;
                }
                else
                {
                    DataType an_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                    if (ap_)
                    {
                        DataType aq_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        n_ = ar_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        n_ = null;
                    }
                }
            }
            CqlDateTime o_ = QICoreCommon_4_0_000.Instance.earliest(context, n_);
            CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bbcfbwcplsbuhefbwpxpvuequ?.Encounter48Hours);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlQuantity r_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime s_ = context.Operators.Add(q_, r_);
            CqlDateTime t_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> u_ = context.Operators.Interval(s_, t_, true, true);
            bool? v_ = context.Operators.In<CqlDateTime>(o_, u_, (string)default);
            bool? w_ = context.Operators.And(m_, v_);
            Code<ObservationStatus> x_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.StatusElement;
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
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Obstetrics_and_VTE_Obstetrics(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, EncounterWithCreatinine);

            bool? j_(Condition @this) {
                CodeableConcept q_ = @this?.Code;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                bool? s_ = context.Operators.Not((bool?)(r_ is null));
                return s_;
            }


            CqlConcept k_(Condition @this) {
                CodeableConcept t_ = @this?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                return u_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.WhereSelect<Condition, CqlConcept>(i_, j_, k_);
            bool? m_ = context.Operators.ConceptsInValueSet(l_, g_);
            bool? n_ = context.Operators.Or(h_, m_);
            bool? o_ = context.Operators.Not(n_);
            return o_;
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
            bool? i_ = context.Operators.Not((bool?)((h_ as CqlQuantity) is null));
            object j_;
            DataType ac_ = CreatinineTest?.Effective;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool ae_ = ad_ is CqlDateTime;
            if (ae_)
            {
                DataType af_ = CreatinineTest?.Effective;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                j_ = ag_ as CqlDateTime;
            }
            else
            {
                DataType ah_ = CreatinineTest?.Effective;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool aj_ = ai_ is CqlDateTime;
                if (aj_)
                {
                    DataType ak_ = CreatinineTest?.Effective;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    j_ = al_ as CqlDateTime;
                }
                else
                {
                    DataType am_ = CreatinineTest?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlInterval<CqlDateTime>;
                    if (ao_)
                    {
                        DataType ap_ = CreatinineTest?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        j_ = aq_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        j_ = null;
                    }
                }
            }
            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.earliest(context, j_);
            CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlQuantity n_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime o_ = context.Operators.Add(m_, n_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
            bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, (string)default);
            bool? r_ = context.Operators.And(i_, q_);
            object s_;
            DataType ar_ = CreatinineTest?.Effective;
            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
            bool at_ = as_ is CqlDateTime;
            if (at_)
            {
                DataType au_ = CreatinineTest?.Effective;
                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                s_ = av_ as CqlDateTime;
            }
            else
            {
                DataType aw_ = CreatinineTest?.Effective;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool ay_ = ax_ is CqlDateTime;
                if (ay_)
                {
                    DataType az_ = CreatinineTest?.Effective;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    s_ = ba_ as CqlDateTime;
                }
                else
                {
                    DataType bb_ = CreatinineTest?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                    if (bd_)
                    {
                        DataType be_ = CreatinineTest?.Effective;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        s_ = bf_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        s_ = null;
                    }
                }
            }
            CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, s_);
            bool? u_ = context.Operators.In<CqlDateTime>(t_, l_, (string)default);
            bool? v_ = context.Operators.And(r_, u_);
            Code<ObservationStatus> w_ = CreatinineTest?.StatusElement;
            ObservationStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            string[] z_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
            bool? ab_ = context.Operators.And(v_, aa_);
            return ab_;
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
            CqlDateTime k_ = LabTestsLow?.CrLabTime;
            CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlQuantity n_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime o_ = context.Operators.Add(m_, n_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
            bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, (string)default);
            bool? r_ = context.Operators.And(j_, q_);
            return r_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity s_ = @this?.CrLabResult;
            bool? t_ = context.Operators.Not((bool?)(s_ is null));
            return t_;
        }


        CqlQuantity e_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity u_ = @this?.CrLabResult;
            return u_;
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
            DataType ai_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            bool ak_ = aj_ is CqlDateTime;
            if (ak_)
            {
                DataType al_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                m_ = am_ as CqlDateTime;
            }
            else
            {
                DataType an_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                bool ap_ = ao_ is CqlDateTime;
                if (ap_)
                {
                    DataType aq_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    m_ = ar_ as CqlDateTime;
                }
                else
                {
                    DataType as_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlInterval<CqlDateTime>;
                    if (au_)
                    {
                        DataType av_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        m_ = aw_ as CqlInterval<CqlDateTime>;
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
            bool? q_ = QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation);
            bool? r_ = context.Operators.And(p_, q_);
            Code<ObservationStatus> s_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.StatusElement;
            ObservationStatus? t_ = s_?.Value;
            string u_ = context.Operators.Convert<string>(t_);
            string[] v_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? w_ = context.Operators.In<string>(u_, (IEnumerable<string>)v_);
            bool? x_ = context.Operators.And(r_, w_);
            DataType y_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            string aa_ = (z_ as CqlQuantity)?.unit;
            bool? ab_ = context.Operators.Equal(aa_, "mg/dL");
            bool? ac_ = context.Operators.And(x_, ab_);
            bool? ad_ = context.Operators.Not((bool?)(z_ is null));
            bool? ae_ = context.Operators.And(ac_, ad_);
            CqlQuantity af_ = context.Operators.Quantity(0m, "mg/dL");
            bool? ag_ = context.Operators.Greater(z_ as CqlQuantity, af_);
            bool? ah_ = context.Operators.And(ae_, ag_);
            return ah_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?> g_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?>(d_, e_, f_);

        (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? h_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? tuple_ccccqpjvqogtctjhtilehkfoj) {
            Id ax_ = tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter?.IdElement;
            string ay_ = ax_?.Value;
            CqlInterval<CqlDateTime> az_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter);
            Id ba_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IdElement;
            string bb_ = ba_?.Value;
            object bc_;
            if ((QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation)) ?? false)
            {
                bc_ = "laboratory";
            }
            else
            {
                bool? bt_ = QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as Observation);
                bc_ = bt_;
            }
            List<CodeableConcept> bd_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Category;

            CqlConcept be_(CodeableConcept @this) {
                CqlConcept bu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bu_;
            }

            IEnumerable<CqlConcept> bf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bd_, be_);
            Code<ObservationStatus> bg_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.StatusElement;
            ObservationStatus? bh_ = bg_?.Value;
            string bi_ = context.Operators.Convert<string>(bh_);
            DataType bj_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
            string bl_ = (bk_ as CqlQuantity)?.unit;
            decimal? bm_ = (bk_ as CqlQuantity)?.value;
            object bn_;
            DataType bv_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            bool bx_ = bw_ is CqlDateTime;
            if (bx_)
            {
                DataType by_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bn_ = bz_ as CqlDateTime;
            }
            else
            {
                DataType ca_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool cc_ = cb_ is CqlDateTime;
                if (cc_)
                {
                    DataType cd_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bn_ = ce_ as CqlDateTime;
                }
                else
                {
                    DataType cf_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                    if (ch_)
                    {
                        DataType ci_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        bn_ = cj_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bn_ = null;
                    }
                }
            }
            CqlDateTime bo_ = QICoreCommon_4_0_000.Instance.earliest(context, bn_);
            Instant bp_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IssuedElement;
            DateTimeOffset? bq_ = bp_?.Value;
            CqlDateTime br_ = context.Operators.Convert<CqlDateTime>(bq_);
            (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? bs_ = (CqlTupleMetadata_EROdcjJjSdFbfXChfKbYbOdDN, ay_, az_, bb_, bc_, bf_, bi_, bk_ as CqlQuantity, bl_, bm_, bo_, br_);
            return bs_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?, (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(g_, h_);

        object j_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime ck_ = @this?.CrLabTime;
            return ck_;
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
            CqlDateTime k_ = LabTests48?.CrLabTime;
            CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlQuantity n_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime o_ = context.Operators.Add(m_, n_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
            bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, (string)default);
            bool? r_ = context.Operators.And(j_, q_);
            return r_;
        }

        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);

        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime s_ = @this?.CrLabTime;
            bool? t_ = context.Operators.Not((bool?)(s_ is null));
            return t_;
        }


        CqlDateTime e_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime u_ = @this?.CrLabTime;
            return u_;
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
            bool? l_ = context.Operators.Not((bool?)(k_ is null));
            return l_;
        }


        CqlQuantity e_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity m_ = @this?.CrLabResult;
            return m_;
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
            Code<ObservationStatus> p_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.StatusElement;
            ObservationStatus? q_ = p_?.Value;
            string r_ = context.Operators.Convert<string>(q_);
            bool? s_ = context.Operators.In<string>(r_, (IEnumerable<string>)n_);
            bool? t_ = context.Operators.And(o_, s_);
            DataType u_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Value;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            DataType w_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlQuantity y_ = context.Operators.Subtract(v_ as CqlQuantity, x_ as CqlQuantity);
            CqlQuantity z_ = context.Operators.Quantity(0.299m, "mg/dL");
            bool? aa_ = context.Operators.Greater(y_, z_);
            bool? ab_ = context.Operators.And(t_, aa_);
            CqlQuantity ac_ = this.lowestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            bool? ad_ = context.Operators.Equal(x_ as CqlQuantity, ac_);
            bool? ae_ = context.Operators.And(ab_, ad_);
            object af_;
            DataType bu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
            bool bw_ = bv_ is CqlDateTime;
            if (bw_)
            {
                DataType bx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                af_ = by_ as CqlDateTime;
            }
            else
            {
                DataType bz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                bool cb_ = ca_ is CqlDateTime;
                if (cb_)
                {
                    DataType cc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    af_ = cd_ as CqlDateTime;
                }
                else
                {
                    DataType ce_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    bool cg_ = cf_ is CqlInterval<CqlDateTime>;
                    if (cg_)
                    {
                        DataType ch_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        af_ = ci_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        af_ = null;
                    }
                }
            }
            CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_);
            object ah_;
            DataType cj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
            bool cl_ = ck_ is CqlDateTime;
            if (cl_)
            {
                DataType cm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                ah_ = cn_ as CqlDateTime;
            }
            else
            {
                DataType co_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                bool cq_ = cp_ is CqlDateTime;
                if (cq_)
                {
                    DataType cr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    ah_ = cs_ as CqlDateTime;
                }
                else
                {
                    DataType ct_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    bool cv_ = cu_ is CqlInterval<CqlDateTime>;
                    if (cv_)
                    {
                        DataType cw_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                        ah_ = cx_ as CqlInterval<CqlDateTime>;
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
            DataType cy_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
            bool da_ = cz_ is CqlDateTime;
            if (da_)
            {
                DataType db_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                al_ = dc_ as CqlDateTime;
            }
            else
            {
                DataType dd_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                bool df_ = de_ is CqlDateTime;
                if (df_)
                {
                    DataType dg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                    al_ = dh_ as CqlDateTime;
                }
                else
                {
                    DataType di_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                    bool dk_ = dj_ is CqlInterval<CqlDateTime>;
                    if (dk_)
                    {
                        DataType dl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                        al_ = dm_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        al_ = null;
                    }
                }
            }
            CqlDateTime am_ = QICoreCommon_4_0_000.Instance.earliest(context, al_);
            CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ak_, am_, true, true);
            bool? ao_ = context.Operators.In<CqlDateTime>(ag_, an_, (string)default);
            bool? ap_ = context.Operators.And(ae_, ao_);
            object aq_;
            DataType dn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
            object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
            bool dp_ = do_ is CqlDateTime;
            if (dp_)
            {
                DataType dq_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                aq_ = dr_ as CqlDateTime;
            }
            else
            {
                DataType ds_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                bool du_ = dt_ is CqlDateTime;
                if (du_)
                {
                    DataType dv_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    aq_ = dw_ as CqlDateTime;
                }
                else
                {
                    DataType dx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    bool dz_ = dy_ is CqlInterval<CqlDateTime>;
                    if (dz_)
                    {
                        DataType ea_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        aq_ = eb_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        aq_ = null;
                    }
                }
            }
            CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
            CqlInterval<CqlDateTime> as_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            bool? at_ = context.Operators.In<CqlDateTime>(ar_, as_, (string)default);
            bool? au_ = context.Operators.And(ap_, at_);
            object av_;
            DataType ec_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
            object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
            bool ee_ = ed_ is CqlDateTime;
            if (ee_)
            {
                DataType ef_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                av_ = eg_ as CqlDateTime;
            }
            else
            {
                DataType eh_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                bool ej_ = ei_ is CqlDateTime;
                if (ej_)
                {
                    DataType ek_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    av_ = el_ as CqlDateTime;
                }
                else
                {
                    DataType em_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    bool eo_ = en_ is CqlInterval<CqlDateTime>;
                    if (eo_)
                    {
                        DataType ep_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                        av_ = eq_ as CqlInterval<CqlDateTime>;
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
            bool? bb_ = context.Operators.In<CqlDateTime>(aw_, ba_, (string)default);
            bool? bc_ = context.Operators.And(au_, bb_);
            object bd_;
            DataType er_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
            bool et_ = es_ is CqlDateTime;
            if (et_)
            {
                DataType eu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                bd_ = ev_ as CqlDateTime;
            }
            else
            {
                DataType ew_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                bool ey_ = ex_ is CqlDateTime;
                if (ey_)
                {
                    DataType ez_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                    bd_ = fa_ as CqlDateTime;
                }
                else
                {
                    DataType fb_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                    bool fd_ = fc_ is CqlInterval<CqlDateTime>;
                    if (fd_)
                    {
                        DataType fe_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                        bd_ = ff_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bd_ = null;
                    }
                }
            }
            CqlDateTime be_ = QICoreCommon_4_0_000.Instance.earliest(context, bd_);
            bool? bf_ = context.Operators.In<CqlDateTime>(be_, as_, (string)default);
            bool? bg_ = context.Operators.And(bc_, bf_);
            object bh_;
            DataType fg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
            bool fi_ = fh_ is CqlDateTime;
            if (fi_)
            {
                DataType fj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                bh_ = fk_ as CqlDateTime;
            }
            else
            {
                DataType fl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                bool fn_ = fm_ is CqlDateTime;
                if (fn_)
                {
                    DataType fo_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                    bh_ = fp_ as CqlDateTime;
                }
                else
                {
                    DataType fq_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                    bool fs_ = fr_ is CqlInterval<CqlDateTime>;
                    if (fs_)
                    {
                        DataType ft_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                        bh_ = fu_ as CqlInterval<CqlDateTime>;
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
            bool? bl_ = context.Operators.In<CqlDateTime>(bi_, bk_, (string)default);
            bool? bm_ = context.Operators.And(bg_, bl_);
            Id bn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
            string bo_ = bn_?.Value;
            Id bp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
            string bq_ = bp_?.Value;
            bool? br_ = context.Operators.Equal(bo_, bq_);
            bool? bs_ = context.Operators.Not(br_);
            bool? bt_ = context.Operators.And(bm_, bs_);
            return bt_;
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
            bool? l_ = context.Operators.Not((bool?)(k_ is null));
            return l_;
        }


        CqlDateTime e_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlDateTime m_ = @this?.CrLabTime;
            return m_;
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
            Code<ObservationStatus> p_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.StatusElement;
            ObservationStatus? q_ = p_?.Value;
            string r_ = context.Operators.Convert<string>(q_);
            bool? s_ = context.Operators.In<string>(r_, (IEnumerable<string>)n_);
            bool? t_ = context.Operators.And(o_, s_);
            DataType u_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Value;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            DataType w_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Value;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlQuantity y_ = context.Operators.Subtract(v_ as CqlQuantity, x_ as CqlQuantity);
            CqlQuantity z_ = context.Operators.Quantity(0.299m, "mg/dL");
            bool? aa_ = context.Operators.Greater(y_, z_);
            bool? ab_ = context.Operators.And(t_, aa_);
            IEnumerable<CqlQuantity> ac_ = this.earliestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            CqlQuantity ad_ = context.Operators.SingletonFrom<CqlQuantity>(ac_);
            bool? ae_ = context.Operators.Equal(x_ as CqlQuantity, ad_);
            bool? af_ = context.Operators.And(ab_, ae_);
            object ag_;
            DataType bs_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
            bool bu_ = bt_ is CqlDateTime;
            if (bu_)
            {
                DataType bv_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                ag_ = bw_ as CqlDateTime;
            }
            else
            {
                DataType bx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                bool bz_ = by_ is CqlDateTime;
                if (bz_)
                {
                    DataType ca_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    ag_ = cb_ as CqlDateTime;
                }
                else
                {
                    DataType cc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                    if (ce_)
                    {
                        DataType cf_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        ag_ = cg_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ag_ = null;
                    }
                }
            }
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            object ai_;
            DataType ch_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
            bool cj_ = ci_ is CqlDateTime;
            if (cj_)
            {
                DataType ck_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                ai_ = cl_ as CqlDateTime;
            }
            else
            {
                DataType cm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                bool co_ = cn_ is CqlDateTime;
                if (co_)
                {
                    DataType cp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    ai_ = cq_ as CqlDateTime;
                }
                else
                {
                    DataType cr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    bool ct_ = cs_ is CqlInterval<CqlDateTime>;
                    if (ct_)
                    {
                        DataType cu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                        ai_ = cv_ as CqlInterval<CqlDateTime>;
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
            DataType cw_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
            bool cy_ = cx_ is CqlDateTime;
            if (cy_)
            {
                DataType cz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                am_ = da_ as CqlDateTime;
            }
            else
            {
                DataType db_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                bool dd_ = dc_ is CqlDateTime;
                if (dd_)
                {
                    DataType de_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    am_ = df_ as CqlDateTime;
                }
                else
                {
                    DataType dg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                    bool di_ = dh_ is CqlInterval<CqlDateTime>;
                    if (di_)
                    {
                        DataType dj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        am_ = dk_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        am_ = null;
                    }
                }
            }
            CqlDateTime an_ = QICoreCommon_4_0_000.Instance.earliest(context, am_);
            CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(al_, an_, true, true);
            bool? ap_ = context.Operators.In<CqlDateTime>(ah_, ao_, (string)default);
            bool? aq_ = context.Operators.And(af_, ap_);
            object ar_;
            DataType dl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
            bool dn_ = dm_ is CqlDateTime;
            if (dn_)
            {
                DataType do_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                ar_ = dp_ as CqlDateTime;
            }
            else
            {
                DataType dq_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                bool ds_ = dr_ is CqlDateTime;
                if (ds_)
                {
                    DataType dt_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    ar_ = du_ as CqlDateTime;
                }
                else
                {
                    DataType dv_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    bool dx_ = dw_ is CqlInterval<CqlDateTime>;
                    if (dx_)
                    {
                        DataType dy_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        ar_ = dz_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ar_ = null;
                    }
                }
            }
            CqlDateTime as_ = QICoreCommon_4_0_000.Instance.earliest(context, ar_);
            CqlInterval<CqlDateTime> at_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            bool? au_ = context.Operators.In<CqlDateTime>(as_, at_, (string)default);
            bool? av_ = context.Operators.And(aq_, au_);
            object aw_;
            DataType ea_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
            bool ec_ = eb_ is CqlDateTime;
            if (ec_)
            {
                DataType ed_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                aw_ = ee_ as CqlDateTime;
            }
            else
            {
                DataType ef_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                bool eh_ = eg_ is CqlDateTime;
                if (eh_)
                {
                    DataType ei_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                    aw_ = ej_ as CqlDateTime;
                }
                else
                {
                    DataType ek_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    bool em_ = el_ is CqlInterval<CqlDateTime>;
                    if (em_)
                    {
                        DataType en_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                        aw_ = eo_ as CqlInterval<CqlDateTime>;
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
            bool? bb_ = context.Operators.In<CqlDateTime>(ax_, ba_, (string)default);
            bool? bc_ = context.Operators.And(av_, bb_);
            object bd_;
            DataType ep_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
            object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
            bool er_ = eq_ is CqlDateTime;
            if (er_)
            {
                DataType es_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                bd_ = et_ as CqlDateTime;
            }
            else
            {
                DataType eu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                bool ew_ = ev_ is CqlDateTime;
                if (ew_)
                {
                    DataType ex_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    bd_ = ey_ as CqlDateTime;
                }
                else
                {
                    DataType ez_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                    bool fb_ = fa_ is CqlInterval<CqlDateTime>;
                    if (fb_)
                    {
                        DataType fc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                        object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                        bd_ = fd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bd_ = null;
                    }
                }
            }
            CqlDateTime be_ = QICoreCommon_4_0_000.Instance.earliest(context, bd_);
            bool? bf_ = context.Operators.In<CqlDateTime>(be_, at_, (string)default);
            bool? bg_ = context.Operators.And(bc_, bf_);
            object bh_;
            DataType fe_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
            object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
            bool fg_ = ff_ is CqlDateTime;
            if (fg_)
            {
                DataType fh_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                bh_ = fi_ as CqlDateTime;
            }
            else
            {
                DataType fj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                bool fl_ = fk_ is CqlDateTime;
                if (fl_)
                {
                    DataType fm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                    bh_ = fn_ as CqlDateTime;
                }
                else
                {
                    DataType fo_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                    bool fq_ = fp_ is CqlInterval<CqlDateTime>;
                    if (fq_)
                    {
                        DataType fr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                        object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                        bh_ = fs_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bh_ = null;
                    }
                }
            }
            CqlDateTime bi_ = QICoreCommon_4_0_000.Instance.earliest(context, bh_);
            bool? bj_ = context.Operators.In<CqlDateTime>(bi_, ba_, (string)default);
            bool? bk_ = context.Operators.And(bg_, bj_);
            Id bl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
            string bm_ = bl_?.Value;
            Id bn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
            string bo_ = bn_?.Value;
            bool? bp_ = context.Operators.Equal(bm_, bo_);
            bool? bq_ = context.Operators.Not(bp_);
            bool? br_ = context.Operators.And(bk_, bq_);
            return br_;
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
            object o_;
            DataType ad_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            bool af_ = ae_ is CqlDateTime;
            if (af_)
            {
                DataType ag_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                o_ = ah_ as CqlDateTime;
            }
            else
            {
                DataType ai_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool ak_ = aj_ is CqlQuantity;
                if (ak_)
                {
                    DataType al_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    o_ = am_ as CqlQuantity;
                }
                else
                {
                    DataType an_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                    if (ap_)
                    {
                        DataType aq_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        o_ = ar_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType as_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlInterval<CqlQuantity>;
                        if (au_)
                        {
                            DataType av_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                            object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                            o_ = aw_ as CqlInterval<CqlQuantity>;
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
            bool? w_ = context.Operators.In<CqlDateTime>(q_, v_, (string)default);
            bool? x_ = context.Operators.And(n_, w_);
            object y_;
            DataType ax_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
            bool az_ = ay_ is CqlDateTime;
            if (az_)
            {
                DataType ba_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                y_ = bb_ as CqlDateTime;
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
                    y_ = bg_ as CqlQuantity;
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
                        y_ = bl_ as CqlInterval<CqlDateTime>;
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
                            y_ = bq_ as CqlInterval<CqlQuantity>;
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
            bool? ab_ = context.Operators.In<CqlDateTime>(aa_, r_, (string)default);
            bool? ac_ = context.Operators.And(x_, ab_);
            return ac_;
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
            bool? l_ = context.Operators.Not((bool?)(k_ is null));
            return l_;
        }


        CqlQuantity e_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, IEnumerable<CqlConcept> CrLabObsCategory2, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this) {
            CqlQuantity m_ = @this?.CrLabResult;
            return m_;
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
            Code<ObservationStatus> o_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.StatusElement;
            ObservationStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            string[] r_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
            bool? t_ = context.Operators.And(n_, s_);
            Code<ObservationStatus> u_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.StatusElement;
            ObservationStatus? v_ = u_?.Value;
            string w_ = context.Operators.Convert<string>(v_);
            bool? x_ = context.Operators.In<string>(w_, (IEnumerable<string>)r_);
            bool? y_ = context.Operators.And(t_, x_);
            CqlQuantity z_ = this.highestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            bool? aa_ = context.Operators.Equal(l_ as CqlQuantity, z_);
            bool? ab_ = context.Operators.And(y_, aa_);
            DataType ac_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlQuantity ae_ = this.lowestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            bool? af_ = context.Operators.Equal(ad_ as CqlQuantity, ae_);
            bool? ag_ = context.Operators.And(ab_, af_);
            CqlQuantity ah_ = this.oneAndAHalfIncreaseInCreatinine(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            bool? ai_ = context.Operators.GreaterOrEqual(ah_, ad_ as CqlQuantity);
            bool? aj_ = context.Operators.And(ag_, ai_);
            object ak_;
            DataType bs_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
            bool bu_ = bt_ is CqlDateTime;
            if (bu_)
            {
                DataType bv_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                ak_ = bw_ as CqlDateTime;
            }
            else
            {
                DataType bx_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                bool bz_ = by_ is CqlDateTime;
                if (bz_)
                {
                    DataType ca_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    ak_ = cb_ as CqlDateTime;
                }
                else
                {
                    DataType cc_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                    if (ce_)
                    {
                        DataType cf_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                        ak_ = cg_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ak_ = null;
                    }
                }
            }
            CqlDateTime al_ = QICoreCommon_4_0_000.Instance.earliest(context, ak_);
            object am_;
            DataType ch_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
            bool cj_ = ci_ is CqlDateTime;
            if (cj_)
            {
                DataType ck_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                am_ = cl_ as CqlDateTime;
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
                    am_ = cq_ as CqlDateTime;
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
                        am_ = cv_ as CqlInterval<CqlDateTime>;
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
            DataType cw_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
            object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
            bool cy_ = cx_ is CqlDateTime;
            if (cy_)
            {
                DataType cz_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                aq_ = da_ as CqlDateTime;
            }
            else
            {
                DataType db_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                bool dd_ = dc_ is CqlDateTime;
                if (dd_)
                {
                    DataType de_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    aq_ = df_ as CqlDateTime;
                }
                else
                {
                    DataType dg_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                    bool di_ = dh_ is CqlInterval<CqlDateTime>;
                    if (di_)
                    {
                        DataType dj_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        aq_ = dk_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        aq_ = null;
                    }
                }
            }
            CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
            CqlInterval<CqlDateTime> as_ = context.Operators.Interval(ap_, ar_, true, false);
            bool? at_ = context.Operators.In<CqlDateTime>(al_, as_, (string)default);
            object au_;
            DataType dl_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
            bool dn_ = dm_ is CqlDateTime;
            if (dn_)
            {
                DataType do_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                au_ = dp_ as CqlDateTime;
            }
            else
            {
                DataType dq_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                bool ds_ = dr_ is CqlDateTime;
                if (ds_)
                {
                    DataType dt_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    au_ = du_ as CqlDateTime;
                }
                else
                {
                    DataType dv_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    bool dx_ = dw_ is CqlInterval<CqlDateTime>;
                    if (dx_)
                    {
                        DataType dy_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        au_ = dz_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        au_ = null;
                    }
                }
            }
            CqlDateTime av_ = QICoreCommon_4_0_000.Instance.earliest(context, au_);
            bool? aw_ = context.Operators.Not((bool?)(av_ is null));
            bool? ax_ = context.Operators.And(at_, aw_);
            bool? ay_ = context.Operators.And(aj_, ax_);
            object az_;
            DataType ea_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
            object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
            bool ec_ = eb_ is CqlDateTime;
            if (ec_)
            {
                DataType ed_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                az_ = ee_ as CqlDateTime;
            }
            else
            {
                DataType ef_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                bool eh_ = eg_ is CqlDateTime;
                if (eh_)
                {
                    DataType ei_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                    az_ = ej_ as CqlDateTime;
                }
                else
                {
                    DataType ek_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    bool em_ = el_ is CqlInterval<CqlDateTime>;
                    if (em_)
                    {
                        DataType en_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                        object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                        az_ = eo_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        az_ = null;
                    }
                }
            }
            CqlDateTime ba_ = QICoreCommon_4_0_000.Instance.earliest(context, az_);
            CqlInterval<CqlDateTime> bb_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            bool? bc_ = context.Operators.In<CqlDateTime>(ba_, bb_, (string)default);
            bool? bd_ = context.Operators.And(ay_, bc_);
            object be_;
            DataType ep_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
            object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
            bool er_ = eq_ is CqlDateTime;
            if (er_)
            {
                DataType es_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                be_ = et_ as CqlDateTime;
            }
            else
            {
                DataType eu_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                bool ew_ = ev_ is CqlDateTime;
                if (ew_)
                {
                    DataType ex_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    be_ = ey_ as CqlDateTime;
                }
                else
                {
                    DataType ez_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                    bool fb_ = fa_ is CqlInterval<CqlDateTime>;
                    if (fb_)
                    {
                        DataType fc_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                        object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                        be_ = fd_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        be_ = null;
                    }
                }
            }
            CqlDateTime bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_);
            CqlDateTime bg_ = context.Operators.Start(bb_);
            CqlQuantity bh_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime bi_ = context.Operators.Add(bg_, bh_);
            CqlQuantity bj_ = context.Operators.Quantity(30m, "days");
            CqlDateTime bk_ = context.Operators.Add(bg_, bj_);
            CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bi_, bk_, true, true);
            bool? bm_ = context.Operators.In<CqlDateTime>(bf_, bl_, (string)default);
            bool? bn_ = context.Operators.And(bd_, bm_);
            object bo_;
            DataType fe_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
            object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
            bool fg_ = ff_ is CqlDateTime;
            if (fg_)
            {
                DataType fh_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                bo_ = fi_ as CqlDateTime;
            }
            else
            {
                DataType fj_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                bool fl_ = fk_ is CqlDateTime;
                if (fl_)
                {
                    DataType fm_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                    bo_ = fn_ as CqlDateTime;
                }
                else
                {
                    DataType fo_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                    bool fq_ = fp_ is CqlInterval<CqlDateTime>;
                    if (fq_)
                    {
                        DataType fr_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                        object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                        bo_ = fs_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bo_ = null;
                    }
                }
            }
            CqlDateTime bp_ = QICoreCommon_4_0_000.Instance.earliest(context, bo_);
            bool? bq_ = context.Operators.In<CqlDateTime>(bp_, bb_, (string)default);
            bool? br_ = context.Operators.And(bn_, bq_);
            return br_;
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
            Code<ObservationStatus> o_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.StatusElement;
            ObservationStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            string[] r_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
            bool? t_ = context.Operators.And(n_, s_);
            Code<ObservationStatus> u_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.StatusElement;
            ObservationStatus? v_ = u_?.Value;
            string w_ = context.Operators.Convert<string>(v_);
            bool? x_ = context.Operators.In<string>(w_, (IEnumerable<string>)r_);
            bool? y_ = context.Operators.And(t_, x_);
            CqlQuantity z_ = this.highestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            bool? aa_ = context.Operators.Equal(l_ as CqlQuantity, z_);
            bool? ab_ = context.Operators.And(y_, aa_);
            DataType ac_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlQuantity ae_ = this.lowestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            bool? af_ = context.Operators.Equal(ad_ as CqlQuantity, ae_);
            bool? ag_ = context.Operators.And(ab_, af_);
            bool? ah_ = context.Operators.GreaterOrEqual(l_ as CqlQuantity, ad_ as CqlQuantity);
            bool? ai_ = context.Operators.And(ag_, ah_);
            object aj_;
            DataType br_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
            bool bt_ = bs_ is CqlDateTime;
            if (bt_)
            {
                DataType bu_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                aj_ = bv_ as CqlDateTime;
            }
            else
            {
                DataType bw_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                bool by_ = bx_ is CqlDateTime;
                if (by_)
                {
                    DataType bz_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    aj_ = ca_ as CqlDateTime;
                }
                else
                {
                    DataType cb_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    bool cd_ = cc_ is CqlInterval<CqlDateTime>;
                    if (cd_)
                    {
                        DataType ce_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                        aj_ = cf_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        aj_ = null;
                    }
                }
            }
            CqlDateTime ak_ = QICoreCommon_4_0_000.Instance.earliest(context, aj_);
            object al_;
            DataType cg_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
            object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
            bool ci_ = ch_ is CqlDateTime;
            if (ci_)
            {
                DataType cj_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                al_ = ck_ as CqlDateTime;
            }
            else
            {
                DataType cl_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                bool cn_ = cm_ is CqlDateTime;
                if (cn_)
                {
                    DataType co_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                    al_ = cp_ as CqlDateTime;
                }
                else
                {
                    DataType cq_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    bool cs_ = cr_ is CqlInterval<CqlDateTime>;
                    if (cs_)
                    {
                        DataType ct_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                        al_ = cu_ as CqlInterval<CqlDateTime>;
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
            DataType cv_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
            bool cx_ = cw_ is CqlDateTime;
            if (cx_)
            {
                DataType cy_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                ap_ = cz_ as CqlDateTime;
            }
            else
            {
                DataType da_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                bool dc_ = db_ is CqlDateTime;
                if (dc_)
                {
                    DataType dd_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    ap_ = de_ as CqlDateTime;
                }
                else
                {
                    DataType df_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    bool dh_ = dg_ is CqlInterval<CqlDateTime>;
                    if (dh_)
                    {
                        DataType di_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        ap_ = dj_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ap_ = null;
                    }
                }
            }
            CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
            CqlInterval<CqlDateTime> ar_ = context.Operators.Interval(ao_, aq_, true, false);
            bool? as_ = context.Operators.In<CqlDateTime>(ak_, ar_, (string)default);
            object at_;
            DataType dk_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
            object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
            bool dm_ = dl_ is CqlDateTime;
            if (dm_)
            {
                DataType dn_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                at_ = do_ as CqlDateTime;
            }
            else
            {
                DataType dp_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                bool dr_ = dq_ is CqlDateTime;
                if (dr_)
                {
                    DataType ds_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    at_ = dt_ as CqlDateTime;
                }
                else
                {
                    DataType du_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                    bool dw_ = dv_ is CqlInterval<CqlDateTime>;
                    if (dw_)
                    {
                        DataType dx_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                        at_ = dy_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        at_ = null;
                    }
                }
            }
            CqlDateTime au_ = QICoreCommon_4_0_000.Instance.earliest(context, at_);
            bool? av_ = context.Operators.Not((bool?)(au_ is null));
            bool? aw_ = context.Operators.And(as_, av_);
            bool? ax_ = context.Operators.And(ai_, aw_);
            object ay_;
            DataType dz_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
            object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
            bool eb_ = ea_ is CqlDateTime;
            if (eb_)
            {
                DataType ec_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                ay_ = ed_ as CqlDateTime;
            }
            else
            {
                DataType ee_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                bool eg_ = ef_ is CqlDateTime;
                if (eg_)
                {
                    DataType eh_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                    ay_ = ei_ as CqlDateTime;
                }
                else
                {
                    DataType ej_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    bool el_ = ek_ is CqlInterval<CqlDateTime>;
                    if (el_)
                    {
                        DataType em_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                        object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                        ay_ = en_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ay_ = null;
                    }
                }
            }
            CqlDateTime az_ = QICoreCommon_4_0_000.Instance.earliest(context, ay_);
            CqlInterval<CqlDateTime> ba_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            bool? bb_ = context.Operators.In<CqlDateTime>(az_, ba_, (string)default);
            bool? bc_ = context.Operators.And(ax_, bb_);
            object bd_;
            DataType eo_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
            object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
            bool eq_ = ep_ is CqlDateTime;
            if (eq_)
            {
                DataType er_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                bd_ = es_ as CqlDateTime;
            }
            else
            {
                DataType et_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                bool ev_ = eu_ is CqlDateTime;
                if (ev_)
                {
                    DataType ew_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                    bd_ = ex_ as CqlDateTime;
                }
                else
                {
                    DataType ey_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                    bool fa_ = ez_ is CqlInterval<CqlDateTime>;
                    if (fa_)
                    {
                        DataType fb_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                        bd_ = fc_ as CqlInterval<CqlDateTime>;
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
            bool? bl_ = context.Operators.In<CqlDateTime>(be_, bk_, (string)default);
            bool? bm_ = context.Operators.And(bc_, bl_);
            object bn_;
            DataType fd_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
            object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
            bool ff_ = fe_ is CqlDateTime;
            if (ff_)
            {
                DataType fg_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                bn_ = fh_ as CqlDateTime;
            }
            else
            {
                DataType fi_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                bool fk_ = fj_ is CqlDateTime;
                if (fk_)
                {
                    DataType fl_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    bn_ = fm_ as CqlDateTime;
                }
                else
                {
                    DataType fn_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    bool fp_ = fo_ is CqlInterval<CqlDateTime>;
                    if (fp_)
                    {
                        DataType fq_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                        object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                        bn_ = fr_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bn_ = null;
                    }
                }
            }
            CqlDateTime bo_ = QICoreCommon_4_0_000.Instance.earliest(context, bn_);
            bool? bp_ = context.Operators.In<CqlDateTime>(bo_, ba_, (string)default);
            bool? bq_ = context.Operators.And(bm_, bp_);
            return bq_;
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
                Period h_ = EncounterWithHighCreatinine?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                Period j_ = EncounterWithKidneyDialysis48HoursOrAfter?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, k_, (string)default);
                return l_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            bool? g_ = context.Operators.Not(f_);
            return g_;
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
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);

            bool? j_(Condition @this) {
                CodeableConcept p_ = @this?.Code;
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                bool? r_ = context.Operators.Not((bool?)(q_ is null));
                return r_;
            }


            CqlConcept k_(Condition @this) {
                CodeableConcept s_ = @this?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                return t_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.WhereSelect<Condition, CqlConcept>(i_, j_, k_);
            bool? m_ = context.Operators.ConceptsInValueSet(l_, g_);
            bool? n_ = context.Operators.Or(h_, m_);
            return n_;
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
                object l_;
                DataType r_ = HighRiskProcedures?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                if (t_)
                {
                    DataType u_ = HighRiskProcedures?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    l_ = v_ as CqlDateTime;
                }
                else
                {
                    DataType w_ = HighRiskProcedures?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlQuantity;
                    if (y_)
                    {
                        DataType z_ = HighRiskProcedures?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        l_ = aa_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ab_ = HighRiskProcedures?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                        if (ad_)
                        {
                            DataType ae_ = HighRiskProcedures?.Performed;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            l_ = af_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ag_ = HighRiskProcedures?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                            if (ai_)
                            {
                                DataType aj_ = HighRiskProcedures?.Performed;
                                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                l_ = ak_ as CqlInterval<CqlQuantity>;
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
                bool? q_ = context.Operators.And(k_, p_);
                return q_;
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
            DataType ae_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            bool ag_ = af_ is CqlDateTime;
            if (ag_)
            {
                DataType ah_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                k_ = ai_ as CqlDateTime;
            }
            else
            {
                DataType aj_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                bool al_ = ak_ is CqlQuantity;
                if (al_)
                {
                    DataType am_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    k_ = an_ as CqlQuantity;
                }
                else
                {
                    DataType ao_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlInterval<CqlDateTime>;
                    if (aq_)
                    {
                        DataType ar_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        k_ = as_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType at_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        bool av_ = au_ is CqlInterval<CqlQuantity>;
                        if (av_)
                        {
                            DataType aw_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                            object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                            k_ = ax_ as CqlInterval<CqlQuantity>;
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
            object u_;
            DataType ay_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
            bool ba_ = az_ is CqlDateTime;
            if (ba_)
            {
                DataType bb_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                u_ = bc_ as CqlDateTime;
            }
            else
            {
                DataType bd_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                bool bf_ = be_ is CqlQuantity;
                if (bf_)
                {
                    DataType bg_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    u_ = bh_ as CqlQuantity;
                }
                else
                {
                    DataType bi_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlInterval<CqlDateTime>;
                    if (bk_)
                    {
                        DataType bl_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        u_ = bm_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bn_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        bool bp_ = bo_ is CqlInterval<CqlQuantity>;
                        if (bp_)
                        {
                            DataType bq_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                            object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                            u_ = br_ as CqlInterval<CqlQuantity>;
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
            bool? x_ = context.Operators.In<CqlDateTime>(w_, n_, (string)default);
            bool? y_ = context.Operators.And(t_, x_);
            Code<EventStatus> z_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.StatusElement;
            EventStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            bool? ac_ = context.Operators.Equal(ab_, "completed");
            bool? ad_ = context.Operators.And(y_, ac_);
            return ad_;
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
                Period h_ = EncounterWithHighCreatinine?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                Period j_ = EncounterWithDialysisAfter48Hours?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, k_, (string)default);
                return l_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            bool? g_ = context.Operators.Not(f_);
            return g_;
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
            Code<ClaimUseCode> n_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.UseElement;
            ClaimUseCode? o_ = n_?.Value;
            Code<ClaimUseCode> p_ = context.Operators.Convert<Code<ClaimUseCode>>(o_);
            bool? q_ = context.Operators.Equal(p_, "claim");
            bool? r_ = context.Operators.And(m_, q_);
            List<Claim.ItemComponent> s_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Item;

            bool? t_(Claim.ItemComponent ClaimItem) {
                List<ResourceReference> w_ = ClaimItem?.Encounter;
                bool? x_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)w_, tuple_epwvnljjfhnvfarkifgamtzks?.QualifyingEncounter);
                List<Claim.DiagnosisComponent> y_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Diagnosis;

                bool? z_(Claim.DiagnosisComponent Dx) {
                    PositiveInt ac_ = Dx?.SequenceElement;
                    int? ad_ = ac_?.Value;
                    List<Claim.ItemComponent> ae_ = tuple_epwvnljjfhnvfarkifgamtzks?.clm?.Item;

                    bool? af_(Claim.ItemComponent @this) {
                        List<PositiveInt> ap_ = @this?.DiagnosisSequenceElement;

                        int? aq_(PositiveInt @this) {
                            int? at_ = @this?.Value;
                            return at_;
                        }

                        IEnumerable<int?> ar_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ap_, aq_);
                        bool? as_ = context.Operators.Not((bool?)(ar_ is null));
                        return as_;
                    }


                    IEnumerable<int?> ag_(Claim.ItemComponent @this) {
                        List<PositiveInt> au_ = @this?.DiagnosisSequenceElement;

                        int? av_(PositiveInt @this) {
                            int? ax_ = @this?.Value;
                            return ax_;
                        }

                        IEnumerable<int?> aw_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)au_, av_);
                        return aw_;
                    }

                    IEnumerable<IEnumerable<int?>> ah_ = context.Operators.WhereSelect<Claim.ItemComponent, IEnumerable<int?>>((IEnumerable<Claim.ItemComponent>)ae_, af_, ag_);
                    IEnumerable<int?> ai_ = context.Operators.Flatten<int?>(ah_);
                    bool? aj_ = context.Operators.In<int?>(ad_, ai_);
                    CodeableConcept ak_ = Dx?.OnAdmission;
                    CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_);
                    CqlValueSet am_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                    bool? an_ = context.Operators.ConceptInValueSet(al_, am_);
                    bool? ao_ = context.Operators.And(aj_, an_);
                    return ao_;
                }

                bool? aa_ = context.Operators.WhereAny<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)y_, z_);
                bool? ab_ = context.Operators.And(x_, aa_);
                return ab_;
            }

            bool? u_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)s_, t_);
            bool? v_ = context.Operators.And(r_, u_);
            return v_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, Claim>, (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)?>(c_, d_, e_);

        (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? tuple_epwvnljjfhnvfarkifgamtzks) {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Claim clm)? ay_ = (CqlTupleMetadata_CUCPZLPbWZQEUULVJBALOjJbh, tuple_epwvnljjfhnvfarkifgamtzks?.QualifyingEncounter, tuple_epwvnljjfhnvfarkifgamtzks?.clm);
            return ay_;
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

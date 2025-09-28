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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS832HHAKIFHIR", "0.2.000")]
public partial class CMS832HHAKIFHIR_0_2_000 : ILibrary, ISingleton<CMS832HHAKIFHIR_0_2_000>
{
    private CMS832HHAKIFHIR_0_2_000() {}

    public static CMS832HHAKIFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS832HHAKIFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, CumulativeMedicationDuration_6_0_000.Instance, HospitalHarm_2_5_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Body temperature", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", valueSetVersion: null)]
    public CqlValueSet Body_temperature(CqlContext _) => _Body_temperature;
    private static readonly CqlValueSet _Body_temperature = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", null);

    [CqlValueSetDefinition("Creatinine Mass Per Volume", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.21", valueSetVersion: null)]
    public CqlValueSet Creatinine_Mass_Per_Volume(CqlContext _) => _Creatinine_Mass_Per_Volume;
    private static readonly CqlValueSet _Creatinine_Mass_Per_Volume = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.21", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

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

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("Obstetrics and VTE Obstetrics", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.33", valueSetVersion: null)]
    public CqlValueSet Obstetrics_and_VTE_Obstetrics(CqlContext _) => _Obstetrics_and_VTE_Obstetrics;
    private static readonly CqlValueSet _Obstetrics_and_VTE_Obstetrics = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.33", null);

    [CqlValueSetDefinition("Present on Admission or Clinically Undetermined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext _) => _Present_on_Admission_or_Clinically_Undetermined;
    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    #endregion ValueSets

    #region Codes

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

    #region CodeSystems

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

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS832HHAKIFHIR-0.2.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("Encounter with Age 18 and Length of Stay 48 Hours or More")]
    public IEnumerable<Encounter> Encounter_with_Age_18_and_Length_of_Stay_48_Hours_or_More(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter InpatientEncounter)
        {
            List<Extension> e_()
            {
                bool al_()
                {
                    Patient am_ = this.Patient(context);
                    bool an_ = am_ is DomainResource;

                    return an_;
                };
                if (al_())
                {
                    Patient ao_ = this.Patient(context);

                    return (ao_ as DomainResource).Extension;
                }
                else
                {
                    return default;
                }
            };
            bool? f_(Extension @this)
            {
                string ap_ = @this?.Url;
                FhirString aq_ = context.Operators.Convert<FhirString>(ap_);
                string ar_ = FHIRHelpers_4_4_000.Instance.ToString(context, aq_);
                bool? as_ = context.Operators.Equal(ar_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");

                return as_;
            };
            IEnumerable<Extension> g_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(e_()), f_);
            DataType h_(Extension @this)
            {
                DataType at_ = @this?.Value;

                return at_;
            };
            IEnumerable<DataType> i_ = context.Operators.Select<Extension, DataType>(g_, h_);
            DataType j_ = context.Operators.SingletonFrom<DataType>(i_);
            string k_ = context.Operators.Convert<string>(j_);
            string[] l_ = [
                "248153007",
                "248152002",
            ];
            bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
            Period n_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlDateTime p_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, "day");
            bool? s_ = context.Operators.And(m_, r_);
            Patient t_ = this.Patient(context);
            Date u_ = t_?.BirthDateElement;
            string v_ = u_?.Value;
            CqlDate w_ = context.Operators.ConvertStringToDate(v_);
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            int? ab_ = context.Operators.CalculateAgeAt(w_, aa_, "year");
            bool? ac_ = context.Operators.GreaterOrEqual(ab_, 18);
            bool? ad_ = context.Operators.And(s_, ac_);
            CqlInterval<CqlDateTime> ae_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime af_ = context.Operators.Start(ae_);
            CqlDateTime ah_ = context.Operators.End(ae_);
            int? ai_ = context.Operators.DurationBetween(af_, ah_, "hour");
            bool? aj_ = context.Operators.GreaterOrEqual(ai_, 48);
            bool? ak_ = context.Operators.And(ad_, aj_);

            return ak_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Creatinine")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Creatinine(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Length_of_Stay_48_Hours_or_More(context);
        CqlValueSet b_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
        (CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)? e_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)? l_ = (CqlTupleMetadata_BSZZjZXQgCBZNijVbAJbPfNhP, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)? tuple_bbcfbwcplsbuhefbwpxpvuequ)
        {
            DataType m_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            bool? o_ = context.Operators.Not((bool?)(n_ is null));
            object p_()
            {
                bool ag_()
                {
                    DataType aj_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlDateTime;

                    return al_;
                };
                bool ah_()
                {
                    DataType am_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlInterval<CqlDateTime>;

                    return ao_;
                };
                bool ai_()
                {
                    DataType ap_ = tuple_bbcfbwcplsbuhefbwpxpvuequ?.CreatinineTest?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlDateTime;

                    return ar_;
                };
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
                }
            };
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_());
            CqlInterval<CqlDateTime> r_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bbcfbwcplsbuhefbwpxpvuequ?.Encounter48Hours);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlQuantity t_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime u_ = context.Operators.Add(s_, t_);
            CqlDateTime w_ = context.Operators.End(r_);
            CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);
            bool? y_ = context.Operators.In<CqlDateTime>(q_, x_, default);
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
        };
        IEnumerable<(CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)? tuple_bbcfbwcplsbuhefbwpxpvuequ) =>
            tuple_bbcfbwcplsbuhefbwpxpvuequ?.Encounter48Hours;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter Encounter48Hours, Observation CreatinineTest)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Encounter with Creatinine and without Obstetrical Conditions")]
    public IEnumerable<Encounter> Encounter_with_Creatinine_and_without_Obstetrical_Conditions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounter_with_Creatinine(context);
        bool? b_(Encounter EncounterWithCreatinine)
        {
            IEnumerable<object> d_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, EncounterWithCreatinine);
            bool? e_(object EncounterDiagnosis)
            {
                object i_ = context.Operators.LateBoundProperty<object>(EncounterDiagnosis, "code");
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, i_ as CodeableConcept);
                CqlValueSet k_ = this.Obstetrics_and_VTE_Obstetrics(context);
                bool? l_ = context.Operators.ConceptInValueSet(j_, k_);

                return l_;
            };
            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            bool? g_ = context.Operators.Exists<object>(f_);
            bool? h_ = context.Operators.Not(g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlFunctionDefinition("CreatinineLabTestwithResultwithinFirst48Hours")]
    public IEnumerable<Observation> CreatinineLabTestwithResultwithinFirst48Hours(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        bool? c_(Observation CreatinineTest)
        {
            DataType h_ = CreatinineTest?.Value;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            bool? j_ = context.Operators.Not((bool?)(i_ is null));
            object k_()
            {
                bool ag_()
                {
                    DataType aj_ = CreatinineTest?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlDateTime;

                    return al_;
                };
                bool ah_()
                {
                    DataType am_ = CreatinineTest?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlInterval<CqlDateTime>;

                    return ao_;
                };
                bool ai_()
                {
                    DataType ap_ = CreatinineTest?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlDateTime;

                    return ar_;
                };
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
                }
            };
            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_());
            CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlDateTime p_ = context.Operators.Start(m_);
            CqlQuantity q_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime r_ = context.Operators.Add(p_, q_);
            CqlInterval<CqlDateTime> s_ = context.Operators.Interval(n_, r_, true, true);
            bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, default);
            bool? u_ = context.Operators.And(j_, t_);
            object v_()
            {
                bool ay_()
                {
                    DataType bb_ = CreatinineTest?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlDateTime;

                    return bd_;
                };
                bool az_()
                {
                    DataType be_ = CreatinineTest?.Effective;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlInterval<CqlDateTime>;

                    return bg_;
                };
                bool ba_()
                {
                    DataType bh_ = CreatinineTest?.Effective;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlDateTime;

                    return bj_;
                };
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
                }
            };
            CqlDateTime w_ = QICoreCommon_4_0_000.Instance.earliest(context, v_());
            bool? y_ = context.Operators.In<CqlDateTime>(w_, m_, default);
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
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        Observation e_(Observation CreatinineTest) =>
            CreatinineTest;
        IEnumerable<Observation> f_ = context.Operators.Select<Observation, Observation>(d_, e_);
        IEnumerable<Observation> g_ = context.Operators.Distinct<Observation>(f_);

        return g_;
    }


    [CqlExpressionDefinition("Encounter with Less Than 2 Creatinine Results within 48 Hours of Arrival")]
    public IEnumerable<Encounter> Encounter_with_Less_Than_2_Creatinine_Results_within_48_Hours_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<Observation> d_ = this.CreatinineLabTestwithResultwithinFirst48Hours(context, QualifyingEncounter);
            int? e_ = context.Operators.Count<Observation>(d_);
            bool? f_ = context.Operators.Less(e_, 2);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlFunctionDefinition("MaleeGFR")]
    public decimal? MaleeGFR(CqlContext context, Encounter QualifyingEncounter)
    {
        decimal? a_()
        {
            bool b_()
            {
                List<Extension> c_()
                {
                    bool j_()
                    {
                        Patient k_ = this.Patient(context);
                        bool l_ = k_ is DomainResource;

                        return l_;
                    };
                    if (j_())
                    {
                        Patient m_ = this.Patient(context);

                        return (m_ as DomainResource).Extension;
                    }
                    else
                    {
                        return default;
                    }
                };
                bool? d_(Extension @this)
                {
                    string n_ = @this?.Url;
                    FhirString o_ = context.Operators.Convert<FhirString>(n_);
                    string p_ = FHIRHelpers_4_4_000.Instance.ToString(context, o_);
                    bool? q_ = context.Operators.Equal(p_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");

                    return q_;
                };
                IEnumerable<Extension> e_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(c_()), d_);
                DataType f_(Extension @this)
                {
                    DataType r_ = @this?.Value;

                    return r_;
                };
                IEnumerable<DataType> g_ = context.Operators.Select<Extension, DataType>(e_, f_);
                DataType h_ = context.Operators.SingletonFrom<DataType>(g_);
                bool? i_ = context.Operators.Equal(h_, "248153007");

                return i_ ?? false;
            };
            if (b_())
            {
                decimal? s_ = context.Operators.ConvertIntegerToDecimal(142);
                CqlQuantity t_ = this.IndexCreatinine(context, QualifyingEncounter);
                decimal? u_ = t_?.value;
                decimal? v_ = context.Operators.Divide(u_, 0.9m);
                decimal? w_ = context.Operators.ConvertIntegerToDecimal(1);
                decimal?[] x_ = [
                    v_,
                    w_,
                ];
                decimal? y_ = context.Operators.Min<decimal?>((IEnumerable<decimal?>)x_);
                decimal? z_ = context.Operators.Negate(0.302m);
                decimal? aa_ = context.Operators.Power(y_, z_);
                decimal? ab_ = context.Operators.Multiply(s_, aa_);
                decimal? ad_ = t_?.value;
                decimal? ae_ = context.Operators.Divide(ad_, 0.9m);
                decimal?[] ag_ = [
                    ae_,
                    w_,
                ];
                decimal? ah_ = context.Operators.Max<decimal?>((IEnumerable<decimal?>)ag_);
                decimal? ai_ = context.Operators.Negate(1.200m);
                decimal? aj_ = context.Operators.Power(ah_, ai_);
                decimal? ak_ = context.Operators.Multiply(ab_, aj_);
                Patient al_ = this.Patient(context);
                Date am_ = al_?.BirthDateElement;
                string an_ = am_?.Value;
                CqlDateTime ao_ = context.Operators.ConvertStringToDateTime(an_);
                CqlInterval<CqlDateTime> ap_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlDateTime aq_ = context.Operators.Start(ap_);
                int? ar_ = context.Operators.CalculateAgeAt(ao_, aq_, "year");
                decimal? as_ = context.Operators.ConvertIntegerToDecimal(ar_);
                decimal? at_ = context.Operators.Power(0.9938m, as_);
                decimal? au_ = context.Operators.Multiply(ak_, at_);

                return au_;
            }
            else
            {
                return default;
            }
        };

        return a_();
    }


    [CqlFunctionDefinition("IndexCreatinine")]
    public CqlQuantity IndexCreatinine(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlQuantity a_ = this.LowestSerumCreatinineIn24Hours(context, QualifyingEncounter);
        IEnumerable<CqlQuantity> b_ = this.FirstSerumCreatinineIn48Hours(context, QualifyingEncounter);
        CqlQuantity c_ = context.Operators.SingletonFrom<CqlQuantity>(b_);

        return a_ ?? c_;
    }


    [CqlFunctionDefinition("LowestSerumCreatinineIn24Hours")]
    public CqlQuantity LowestSerumCreatinineIn24Hours(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_by_Time(context);
        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTestsLow)
        {
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
            bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, default);
            bool? u_ = context.Operators.And(k_, t_);

            return u_;
        };
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);
        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this)
        {
            CqlQuantity v_ = @this?.CrLabResult;
            bool? w_ = context.Operators.Not((bool?)(v_ is null));

            return w_;
        };
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> e_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(c_, d_);
        CqlQuantity f_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this)
        {
            CqlQuantity x_ = @this?.CrLabResult;

            return x_;
        };
        IEnumerable<CqlQuantity> g_ = context.Operators.Select<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(e_, f_);
        CqlQuantity h_ = context.Operators.Min<CqlQuantity>(g_);

        return h_;
    }


    [CqlExpressionDefinition("Qualifying Creatinine Lab Result by Time")]
    public IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> Qualifying_Creatinine_Lab_Result_by_Time(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? e_(ValueTuple<Encounter, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? n_ = (CqlTupleMetadata_GiiGRATBZEQfMLdbZgPRgTeRJ, _valueTuple.Item1, _valueTuple.Item2);

            return n_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? tuple_ccccqpjvqogtctjhtilehkfoj)
        {
            object o_()
            {
                bool ao_()
                {
                    DataType ar_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlDateTime;

                    return at_;
                };
                bool ap_()
                {
                    DataType au_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    bool aw_ = av_ is CqlInterval<CqlDateTime>;

                    return aw_;
                };
                bool aq_()
                {
                    DataType ax_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlDateTime;

                    return az_;
                };
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
                }
            };
            CqlDateTime p_ = QICoreCommon_4_0_000.Instance.earliest(context, o_());
            CqlInterval<CqlDateTime> q_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter);
            bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, default);
            bool? s_ = QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as object);
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
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?>(f_, g_);
        (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)? tuple_ccccqpjvqogtctjhtilehkfoj)
        {
            Id bg_ = tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter?.IdElement;
            string bh_ = bg_?.Value;
            CqlInterval<CqlDateTime> bi_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ccccqpjvqogtctjhtilehkfoj?.QualifyingEncounter);
            Id bj_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IdElement;
            string bk_ = bj_?.Value;
            object bl_()
            {
                if ((QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as object)) ?? false)
                {
                    return "laboratory" as object;
                }
                else
                {
                    bool? cd_ = QICoreCommon_4_0_000.Instance.isLaboratory(context, tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime as object);

                    return cd_;
                }
            };
            Code<ObservationStatus> bm_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.StatusElement;
            ObservationStatus? bn_ = bm_?.Value;
            string bo_ = context.Operators.Convert<string>(bn_);
            DataType bp_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Value;
            object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
            string bt_ = (bs_ as CqlQuantity)?.unit;
            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
            decimal? bw_ = (bv_ as CqlQuantity)?.value;
            object bx_()
            {
                bool ce_()
                {
                    DataType ch_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlDateTime;

                    return cj_;
                };
                bool cf_()
                {
                    DataType ck_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    bool cm_ = cl_ is CqlInterval<CqlDateTime>;

                    return cm_;
                };
                bool cg_()
                {
                    DataType cn_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    bool cp_ = co_ is CqlDateTime;

                    return cp_;
                };
                if (ce_())
                {
                    DataType cq_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);

                    return (cr_ as CqlDateTime) as object;
                }
                else if (cf_())
                {
                    DataType cs_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);

                    return (ct_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cg_())
                {
                    DataType cu_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.Effective;
                    object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);

                    return (cv_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime by_ = QICoreCommon_4_0_000.Instance.earliest(context, bx_());
            Instant bz_ = tuple_ccccqpjvqogtctjhtilehkfoj?.CreatinineTestByTime?.IssuedElement;
            DateTimeOffset? ca_ = bz_?.Value;
            CqlDateTime cb_ = context.Operators.Convert<CqlDateTime>(ca_);
            (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? cc_ = (CqlTupleMetadata_XFRBIZcEbIWeUfjZdAFDdJef, bh_, bi_, bk_, bl_(), bo_, bq_ as CqlQuantity, bt_, bw_, by_, cb_);

            return cc_;
        };
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation CreatinineTestByTime)?, (CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(h_, i_);
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> k_ = context.Operators.Distinct<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(j_);
        object l_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this)
        {
            CqlDateTime cw_ = @this?.CrLabTime;

            return cw_;
        };
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> m_ = context.Operators.SortBy<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);

        return m_;
    }


    [CqlFunctionDefinition("FirstSerumCreatinineIn48Hours")]
    public IEnumerable<CqlQuantity> FirstSerumCreatinineIn48Hours(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_by_Time(context);
        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests)
        {
            CqlDateTime g_ = this.EarliestSerumCreatinineTimeIn48Hours(context, QualifyingEncounter);
            CqlDateTime h_ = LabTests?.CrLabTime;
            bool? i_ = context.Operators.Equal(g_, h_);

            return i_;
        };
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);
        CqlQuantity d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests)
        {
            CqlQuantity j_ = LabTests?.CrLabResult;

            return j_ as CqlQuantity;
        };
        IEnumerable<CqlQuantity> e_ = context.Operators.Select<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(c_, d_);
        IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);

        return f_;
    }


    [CqlFunctionDefinition("EarliestSerumCreatinineTimeIn48Hours")]
    public CqlDateTime EarliestSerumCreatinineTimeIn48Hours(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_by_Time(context);
        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests48)
        {
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
            bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, default);
            bool? u_ = context.Operators.And(k_, t_);

            return u_;
        };
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);
        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this)
        {
            CqlDateTime v_ = @this?.CrLabTime;
            bool? w_ = context.Operators.Not((bool?)(v_ is null));

            return w_;
        };
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> e_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(c_, d_);
        CqlDateTime f_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this)
        {
            CqlDateTime x_ = @this?.CrLabTime;

            return x_;
        };
        IEnumerable<CqlDateTime> g_ = context.Operators.Select<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlDateTime>(e_, f_);
        CqlDateTime h_ = context.Operators.Min<CqlDateTime>(g_);

        return h_;
    }


    [CqlExpressionDefinition("Male Encounter with eGFR Less Than 60")]
    public IEnumerable<Encounter> Male_Encounter_with_eGFR_Less_Than_60(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            decimal? d_ = this.MaleeGFR(context, QualifyingEncounter);
            bool? e_ = context.Operators.Not((bool?)(d_ is null));
            decimal? g_ = context.Operators.ConvertIntegerToDecimal(60);
            bool? h_ = context.Operators.Less(d_ as decimal?, g_);
            bool? i_ = context.Operators.And(e_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlFunctionDefinition("FemaleeGFR")]
    public decimal? FemaleeGFR(CqlContext context, Encounter QualifyingEncounter)
    {
        decimal? a_()
        {
            bool b_()
            {
                List<Extension> c_()
                {
                    bool j_()
                    {
                        Patient k_ = this.Patient(context);
                        bool l_ = k_ is DomainResource;

                        return l_;
                    };
                    if (j_())
                    {
                        Patient m_ = this.Patient(context);

                        return (m_ as DomainResource).Extension;
                    }
                    else
                    {
                        return default;
                    }
                };
                bool? d_(Extension @this)
                {
                    string n_ = @this?.Url;
                    FhirString o_ = context.Operators.Convert<FhirString>(n_);
                    string p_ = FHIRHelpers_4_4_000.Instance.ToString(context, o_);
                    bool? q_ = context.Operators.Equal(p_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");

                    return q_;
                };
                IEnumerable<Extension> e_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(c_()), d_);
                DataType f_(Extension @this)
                {
                    DataType r_ = @this?.Value;

                    return r_;
                };
                IEnumerable<DataType> g_ = context.Operators.Select<Extension, DataType>(e_, f_);
                DataType h_ = context.Operators.SingletonFrom<DataType>(g_);
                bool? i_ = context.Operators.Equal(h_, "248152002");

                return i_ ?? false;
            };
            if (b_())
            {
                decimal? s_ = context.Operators.ConvertIntegerToDecimal(142);
                CqlQuantity t_ = this.IndexCreatinine(context, QualifyingEncounter);
                decimal? u_ = t_?.value;
                decimal? v_ = context.Operators.Divide(u_, 0.7m);
                decimal? w_ = context.Operators.ConvertIntegerToDecimal(1);
                decimal?[] x_ = [
                    v_,
                    w_,
                ];
                decimal? y_ = context.Operators.Min<decimal?>((IEnumerable<decimal?>)x_);
                decimal? z_ = context.Operators.Negate(0.241m);
                decimal? aa_ = context.Operators.Power(y_, z_);
                decimal? ab_ = context.Operators.Multiply(s_, aa_);
                decimal? ad_ = t_?.value;
                decimal? ae_ = context.Operators.Divide(ad_, 0.7m);
                decimal?[] ag_ = [
                    ae_,
                    w_,
                ];
                decimal? ah_ = context.Operators.Max<decimal?>((IEnumerable<decimal?>)ag_);
                decimal? ai_ = context.Operators.Negate(1.200m);
                decimal? aj_ = context.Operators.Power(ah_, ai_);
                decimal? ak_ = context.Operators.Multiply(ab_, aj_);
                Patient al_ = this.Patient(context);
                Date am_ = al_?.BirthDateElement;
                string an_ = am_?.Value;
                CqlDateTime ao_ = context.Operators.ConvertStringToDateTime(an_);
                CqlInterval<CqlDateTime> ap_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                CqlDateTime aq_ = context.Operators.Start(ap_);
                int? ar_ = context.Operators.CalculateAgeAt(ao_, aq_, "year");
                decimal? as_ = context.Operators.ConvertIntegerToDecimal(ar_);
                decimal? at_ = context.Operators.Power(0.9938m, as_);
                decimal? au_ = context.Operators.Multiply(ak_, at_);
                decimal? av_ = context.Operators.Multiply(au_, 1.012m);

                return av_;
            }
            else
            {
                return default;
            }
        };

        return a_();
    }


    [CqlExpressionDefinition("Female Encounter with eGFR Less Than 60")]
    public IEnumerable<Encounter> Female_Encounter_with_eGFR_Less_Than_60(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            decimal? d_ = this.FemaleeGFR(context, QualifyingEncounter);
            bool? e_ = context.Operators.Not((bool?)(d_ is null));
            decimal? g_ = context.Operators.ConvertIntegerToDecimal(60);
            bool? h_ = context.Operators.Less(d_ as decimal?, g_);
            bool? i_ = context.Operators.And(e_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with Index eGFR Less Than 60 within First 48 Hours")]
    public IEnumerable<Encounter> Encounter_with_Index_eGFR_Less_Than_60_within_First_48_Hours(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Male_Encounter_with_eGFR_Less_Than_60(context);
        IEnumerable<Encounter> b_ = this.Female_Encounter_with_eGFR_Less_Than_60(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

        return c_;
    }


    [CqlFunctionDefinition("LowestSerumCreatinineResult")]
    public CqlQuantity LowestSerumCreatinineResult(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_by_Time(context);
        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests)
        {
            string i_ = LabTests?.CrEncInPtId;
            string j_ = (QualifyingEncounter is Resource
        ? (QualifyingEncounter as Resource).IdElement
        : default)?.Value;
            bool? k_ = context.Operators.Equal(i_, j_);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);
        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this)
        {
            CqlQuantity l_ = @this?.CrLabResult;
            bool? m_ = context.Operators.Not((bool?)(l_ is null));

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> e_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(c_, d_);
        CqlQuantity f_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this)
        {
            CqlQuantity n_ = @this?.CrLabResult;

            return n_;
        };
        IEnumerable<CqlQuantity> g_ = context.Operators.Select<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(e_, f_);
        CqlQuantity h_ = context.Operators.Min<CqlQuantity>(g_);

        return h_;
    }


    [CqlExpressionDefinition("Increase of 0.3 or More Using Lowest Creatinine within 24 Hours")]
    public IEnumerable<Encounter> Increase_of_0_3_or_More_Using_Lowest_Creatinine_within_24_Hours(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> f_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, c_, e_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? g_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? n_ = (CqlTupleMetadata_FWVGLDcQEISFGIdVNGEWPHUFV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return n_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?> h_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?>(f_, g_);
        bool? i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen)
        {
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
            CqlQuantity aj_ = this.LowestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            bool? ak_ = context.Operators.Equal(ai_ as CqlQuantity, aj_);
            bool? al_ = context.Operators.And(ag_, ak_);
            object am_()
            {
                bool ck_()
                {
                    DataType cn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    bool cp_ = co_ is CqlDateTime;

                    return cp_;
                };
                bool cl_()
                {
                    DataType cq_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    bool cs_ = cr_ is CqlInterval<CqlDateTime>;

                    return cs_;
                };
                bool cm_()
                {
                    DataType ct_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    bool cv_ = cu_ is CqlDateTime;

                    return cv_;
                };
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
                }
            };
            CqlDateTime an_ = QICoreCommon_4_0_000.Instance.earliest(context, am_());
            object ao_()
            {
                bool dc_()
                {
                    DataType df_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    bool dh_ = dg_ is CqlDateTime;

                    return dh_;
                };
                bool dd_()
                {
                    DataType di_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                    bool dk_ = dj_ is CqlInterval<CqlDateTime>;

                    return dk_;
                };
                bool de_()
                {
                    DataType dl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    bool dn_ = dm_ is CqlDateTime;

                    return dn_;
                };
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
                }
            };
            CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_());
            CqlQuantity aq_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime ar_ = context.Operators.Subtract(ap_, aq_);
            object as_()
            {
                bool du_()
                {
                    DataType dx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    bool dz_ = dy_ is CqlDateTime;

                    return dz_;
                };
                bool dv_()
                {
                    DataType ea_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                    bool ec_ = eb_ is CqlInterval<CqlDateTime>;

                    return ec_;
                };
                bool dw_()
                {
                    DataType ed_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                    bool ef_ = ee_ is CqlDateTime;

                    return ef_;
                };
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
                }
            };
            CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_());
            CqlInterval<CqlDateTime> au_ = context.Operators.Interval(ar_, at_, true, true);
            bool? av_ = context.Operators.In<CqlDateTime>(an_, au_, default);
            bool? aw_ = context.Operators.And(al_, av_);
            object ax_()
            {
                bool em_()
                {
                    DataType ep_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    bool er_ = eq_ is CqlDateTime;

                    return er_;
                };
                bool en_()
                {
                    DataType es_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                    bool eu_ = et_ is CqlInterval<CqlDateTime>;

                    return eu_;
                };
                bool eo_()
                {
                    DataType ev_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    bool ex_ = ew_ is CqlDateTime;

                    return ex_;
                };
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
                }
            };
            CqlDateTime ay_ = QICoreCommon_4_0_000.Instance.earliest(context, ax_());
            CqlInterval<CqlDateTime> az_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            bool? ba_ = context.Operators.In<CqlDateTime>(ay_, az_, default);
            bool? bb_ = context.Operators.And(aw_, ba_);
            object bc_()
            {
                bool fe_()
                {
                    DataType fh_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                    bool fj_ = fi_ is CqlDateTime;

                    return fj_;
                };
                bool ff_()
                {
                    DataType fk_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                    bool fm_ = fl_ is CqlInterval<CqlDateTime>;

                    return fm_;
                };
                bool fg_()
                {
                    DataType fn_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                    bool fp_ = fo_ is CqlDateTime;

                    return fp_;
                };
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
                }
            };
            CqlDateTime bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_());
            CqlDateTime bf_ = context.Operators.Start(az_);
            CqlDateTime bh_ = context.Operators.Start(az_);
            CqlQuantity bi_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime bj_ = context.Operators.Add(bh_, bi_);
            CqlInterval<CqlDateTime> bk_ = context.Operators.Interval(bf_, bj_, true, true);
            bool? bl_ = context.Operators.In<CqlDateTime>(bd_, bk_, default);
            bool? bm_ = context.Operators.And(bb_, bl_);
            object bn_()
            {
                bool fw_()
                {
                    DataType fz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                    bool gb_ = ga_ is CqlDateTime;

                    return gb_;
                };
                bool fx_()
                {
                    DataType gc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gc_);
                    bool ge_ = gd_ is CqlInterval<CqlDateTime>;

                    return ge_;
                };
                bool fy_()
                {
                    DataType gf_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gf_);
                    bool gh_ = gg_ is CqlDateTime;

                    return gh_;
                };
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
                }
            };
            CqlDateTime bo_ = QICoreCommon_4_0_000.Instance.earliest(context, bn_());
            bool? bq_ = context.Operators.In<CqlDateTime>(bo_, az_, default);
            bool? br_ = context.Operators.And(bm_, bq_);
            object bs_()
            {
                bool go_()
                {
                    DataType gr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
                    bool gt_ = gs_ is CqlDateTime;

                    return gt_;
                };
                bool gp_()
                {
                    DataType gu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gu_);
                    bool gw_ = gv_ is CqlInterval<CqlDateTime>;

                    return gw_;
                };
                bool gq_()
                {
                    DataType gx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                    bool gz_ = gy_ is CqlDateTime;

                    return gz_;
                };
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
                }
            };
            CqlDateTime bt_ = QICoreCommon_4_0_000.Instance.earliest(context, bs_());
            CqlDateTime bv_ = context.Operators.Start(az_);
            CqlDateTime bx_ = context.Operators.Start(az_);
            CqlDateTime bz_ = context.Operators.Add(bx_, aq_);
            CqlInterval<CqlDateTime> ca_ = context.Operators.Interval(bv_, bz_, true, true);
            bool? cb_ = context.Operators.In<CqlDateTime>(bt_, ca_, default);
            bool? cc_ = context.Operators.And(br_, cb_);
            Id cd_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
            string ce_ = cd_?.Value;
            Id cf_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
            string cg_ = cf_?.Value;
            bool? ch_ = context.Operators.Equal(ce_, cg_);
            bool? ci_ = context.Operators.Not(ch_);
            bool? cj_ = context.Operators.And(cc_, ci_);

            return cj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?> j_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?>(h_, i_);
        Encounter k_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen) =>
            tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter;
        IEnumerable<Encounter> l_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?, Encounter>(j_, k_);
        IEnumerable<Encounter> m_ = context.Operators.Distinct<Encounter>(l_);

        return m_;
    }


    [CqlFunctionDefinition("EarliestSerumCreatinineResult")]
    public IEnumerable<CqlQuantity> EarliestSerumCreatinineResult(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_by_Time(context);
        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests)
        {
            CqlDateTime g_ = this.EarliestSerumCreatinineTime(context, QualifyingEncounter);
            CqlDateTime h_ = LabTests?.CrLabTime;
            bool? i_ = context.Operators.Equal(g_, h_);

            return i_;
        };
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);
        CqlQuantity d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests)
        {
            CqlQuantity j_ = LabTests?.CrLabResult;

            return j_ as CqlQuantity;
        };
        IEnumerable<CqlQuantity> e_ = context.Operators.Select<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(c_, d_);
        IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);

        return f_;
    }


    [CqlFunctionDefinition("EarliestSerumCreatinineTime")]
    public CqlDateTime EarliestSerumCreatinineTime(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_by_Time(context);
        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTestsEarly)
        {
            string i_ = LabTestsEarly?.CrEncInPtId;
            string j_ = (QualifyingEncounter is Resource
        ? (QualifyingEncounter as Resource).IdElement
        : default)?.Value;
            bool? k_ = context.Operators.Equal(i_, j_);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);
        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this)
        {
            CqlDateTime l_ = @this?.CrLabTime;
            bool? m_ = context.Operators.Not((bool?)(l_ is null));

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> e_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(c_, d_);
        CqlDateTime f_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this)
        {
            CqlDateTime n_ = @this?.CrLabTime;

            return n_;
        };
        IEnumerable<CqlDateTime> g_ = context.Operators.Select<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlDateTime>(e_, f_);
        CqlDateTime h_ = context.Operators.Min<CqlDateTime>(g_);

        return h_;
    }


    [CqlExpressionDefinition("Increase of 0.3 or More Using First Creatinine within First 48 Hours")]
    public IEnumerable<Encounter> Increase_of_0_3_or_More_Using_First_Creatinine_within_First_48_Hours(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> f_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, c_, e_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? g_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? n_ = (CqlTupleMetadata_FWVGLDcQEISFGIdVNGEWPHUFV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return n_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?> h_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?>(f_, g_);
        bool? i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen)
        {
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
            IEnumerable<CqlQuantity> aj_ = this.EarliestSerumCreatinineResult(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            CqlQuantity ak_ = context.Operators.SingletonFrom<CqlQuantity>(aj_);
            bool? al_ = context.Operators.Equal(ai_ as CqlQuantity, ak_);
            bool? am_ = context.Operators.And(ag_, al_);
            object an_()
            {
                bool cw_()
                {
                    DataType cz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlDateTime;

                    return db_;
                };
                bool cx_()
                {
                    DataType dc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                    bool de_ = dd_ is CqlInterval<CqlDateTime>;

                    return de_;
                };
                bool cy_()
                {
                    DataType df_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    bool dh_ = dg_ is CqlDateTime;

                    return dh_;
                };
                if (cw_())
                {
                    DataType di_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);

                    return (dj_ as CqlDateTime) as object;
                }
                else if (cx_())
                {
                    DataType dk_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);

                    return (dl_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cy_())
                {
                    DataType dm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);

                    return (dn_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_());
            object ap_()
            {
                bool do_()
                {
                    DataType dr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    bool dt_ = ds_ is CqlDateTime;

                    return dt_;
                };
                bool dp_()
                {
                    DataType du_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                    bool dw_ = dv_ is CqlInterval<CqlDateTime>;

                    return dw_;
                };
                bool dq_()
                {
                    DataType dx_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    bool dz_ = dy_ is CqlDateTime;

                    return dz_;
                };
                if (do_())
                {
                    DataType ea_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);

                    return (eb_ as CqlDateTime) as object;
                }
                else if (dp_())
                {
                    DataType ec_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);

                    return (ed_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dq_())
                {
                    DataType ee_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);

                    return (ef_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_());
            CqlQuantity ar_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime as_ = context.Operators.Subtract(aq_, ar_);
            object at_()
            {
                bool eg_()
                {
                    DataType ej_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    bool el_ = ek_ is CqlDateTime;

                    return el_;
                };
                bool eh_()
                {
                    DataType em_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    bool eo_ = en_ is CqlInterval<CqlDateTime>;

                    return eo_;
                };
                bool ei_()
                {
                    DataType ep_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    bool er_ = eq_ is CqlDateTime;

                    return er_;
                };
                if (eg_())
                {
                    DataType es_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);

                    return (et_ as CqlDateTime) as object;
                }
                else if (eh_())
                {
                    DataType eu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);

                    return (ev_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ei_())
                {
                    DataType ew_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);

                    return (ex_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime au_ = QICoreCommon_4_0_000.Instance.earliest(context, at_());
            CqlInterval<CqlDateTime> av_ = context.Operators.Interval(as_, au_, true, true);
            bool? aw_ = context.Operators.In<CqlDateTime>(ao_, av_, default);
            bool? ax_ = context.Operators.And(am_, aw_);
            object ay_()
            {
                bool ey_()
                {
                    DataType fb_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                    bool fd_ = fc_ is CqlDateTime;

                    return fd_;
                };
                bool ez_()
                {
                    DataType fe_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    bool fg_ = ff_ is CqlInterval<CqlDateTime>;

                    return fg_;
                };
                bool fa_()
                {
                    DataType fh_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                    bool fj_ = fi_ is CqlDateTime;

                    return fj_;
                };
                if (ey_())
                {
                    DataType fk_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);

                    return (fl_ as CqlDateTime) as object;
                }
                else if (ez_())
                {
                    DataType fm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);

                    return (fn_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fa_())
                {
                    DataType fo_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);

                    return (fp_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime az_ = QICoreCommon_4_0_000.Instance.earliest(context, ay_());
            CqlInterval<CqlDateTime> ba_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter);
            bool? bb_ = context.Operators.In<CqlDateTime>(az_, ba_, default);
            bool? bc_ = context.Operators.And(ax_, bb_);
            object bd_()
            {
                bool fq_()
                {
                    DataType ft_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                    bool fv_ = fu_ is CqlDateTime;

                    return fv_;
                };
                bool fr_()
                {
                    DataType fw_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                    bool fy_ = fx_ is CqlInterval<CqlDateTime>;

                    return fy_;
                };
                bool fs_()
                {
                    DataType fz_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                    bool gb_ = ga_ is CqlDateTime;

                    return gb_;
                };
                if (fq_())
                {
                    DataType gc_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gc_);

                    return (gd_ as CqlDateTime) as object;
                }
                else if (fr_())
                {
                    DataType ge_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);

                    return (gf_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (fs_())
                {
                    DataType gg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);

                    return (gh_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime be_ = QICoreCommon_4_0_000.Instance.earliest(context, bd_());
            CqlDateTime bg_ = context.Operators.Start(ba_);
            CqlDateTime bi_ = context.Operators.Start(ba_);
            CqlDateTime bk_ = context.Operators.Add(bi_, ar_);
            CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bg_, bk_, true, true);
            bool? bm_ = context.Operators.In<CqlDateTime>(be_, bl_, default);
            bool? bn_ = context.Operators.And(bc_, bm_);
            object bo_()
            {
                bool gi_()
                {
                    DataType gl_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                    bool gn_ = gm_ is CqlDateTime;

                    return gn_;
                };
                bool gj_()
                {
                    DataType go_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                    bool gq_ = gp_ is CqlInterval<CqlDateTime>;

                    return gq_;
                };
                bool gk_()
                {
                    DataType gr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
                    bool gt_ = gs_ is CqlDateTime;

                    return gt_;
                };
                if (gi_())
                {
                    DataType gu_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gu_);

                    return (gv_ as CqlDateTime) as object;
                }
                else if (gj_())
                {
                    DataType gw_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gw_);

                    return (gx_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gk_())
                {
                    DataType gy_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object gz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gy_);

                    return (gz_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime bp_ = QICoreCommon_4_0_000.Instance.earliest(context, bo_());
            bool? br_ = context.Operators.In<CqlDateTime>(bp_, ba_, default);
            bool? bs_ = context.Operators.And(bn_, br_);
            object bt_()
            {
                bool ha_()
                {
                    DataType hd_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object he_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hd_);
                    bool hf_ = he_ is CqlDateTime;

                    return hf_;
                };
                bool hb_()
                {
                    DataType hg_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object hh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hg_);
                    bool hi_ = hh_ is CqlInterval<CqlDateTime>;

                    return hi_;
                };
                bool hc_()
                {
                    DataType hj_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object hk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hj_);
                    bool hl_ = hk_ is CqlDateTime;

                    return hl_;
                };
                if (ha_())
                {
                    DataType hm_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);

                    return (hn_ as CqlDateTime) as object;
                }
                else if (hb_())
                {
                    DataType ho_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object hp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ho_);

                    return (hp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hc_())
                {
                    DataType hq_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.Effective;
                    object hr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hq_);

                    return (hr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime bu_ = QICoreCommon_4_0_000.Instance.earliest(context, bt_());
            CqlDateTime bw_ = context.Operators.Start(ba_);
            CqlDateTime by_ = context.Operators.Start(ba_);
            CqlDateTime ca_ = context.Operators.Add(by_, ar_);
            CqlInterval<CqlDateTime> cb_ = context.Operators.Interval(bw_, ca_, true, true);
            bool? cc_ = context.Operators.In<CqlDateTime>(bu_, cb_, default);
            bool? cd_ = context.Operators.And(bs_, cc_);
            object ce_()
            {
                bool hs_()
                {
                    DataType hv_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object hw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hv_);
                    bool hx_ = hw_ is CqlDateTime;

                    return hx_;
                };
                bool ht_()
                {
                    DataType hy_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object hz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hy_);
                    bool ia_ = hz_ is CqlInterval<CqlDateTime>;

                    return ia_;
                };
                bool hu_()
                {
                    DataType ib_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ic_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ib_);
                    bool id_ = ic_ is CqlDateTime;

                    return id_;
                };
                if (hs_())
                {
                    DataType ie_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object if_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ie_);

                    return (if_ as CqlDateTime) as object;
                }
                else if (ht_())
                {
                    DataType ig_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ih_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ig_);

                    return (ih_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (hu_())
                {
                    DataType ii_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.Effective;
                    object ij_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ii_);

                    return (ij_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime cf_ = QICoreCommon_4_0_000.Instance.earliest(context, ce_());
            CqlDateTime ch_ = context.Operators.Start(ba_);
            CqlDateTime cj_ = context.Operators.Start(ba_);
            CqlDateTime cl_ = context.Operators.Add(cj_, ar_);
            CqlInterval<CqlDateTime> cm_ = context.Operators.Interval(ch_, cl_, true, true);
            bool? cn_ = context.Operators.In<CqlDateTime>(cf_, cm_, default);
            bool? co_ = context.Operators.And(cd_, cn_);
            Id cp_ = tuple_hsukaxezrzqpeqifkirnhhzen?.IndexCreatinineLabResult?.IdElement;
            string cq_ = cp_?.Value;
            Id cr_ = tuple_hsukaxezrzqpeqifkirnhhzen?.SubsequentCreatinineLabResult?.IdElement;
            string cs_ = cr_?.Value;
            bool? ct_ = context.Operators.Equal(cq_, cs_);
            bool? cu_ = context.Operators.Not(ct_);
            bool? cv_ = context.Operators.And(co_, cu_);

            return cv_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?> j_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?>(h_, i_);
        Encounter k_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)? tuple_hsukaxezrzqpeqifkirnhhzen) =>
            tuple_hsukaxezrzqpeqifkirnhhzen?.QualifyingEncounter;
        IEnumerable<Encounter> l_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation IndexCreatinineLabResult, Observation SubsequentCreatinineLabResult)?, Encounter>(j_, k_);
        IEnumerable<Encounter> m_ = context.Operators.Distinct<Encounter>(l_);

        return m_;
    }


    [CqlExpressionDefinition("Encounter with 0.3 mg dL or More Increase in Creatinine")]
    public IEnumerable<Encounter> Encounter_with_0_3_mg_dL_or_More_Increase_in_Creatinine(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Increase_of_0_3_or_More_Using_Lowest_Creatinine_within_24_Hours(context);
        IEnumerable<Encounter> b_ = this.Increase_of_0_3_or_More_Using_First_Creatinine_within_First_48_Hours(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with Kidney Dialysis Started 48 Hours or Less After Arrival")]
    public IEnumerable<Encounter> Encounter_with_Kidney_Dialysis_Started_48_Hours_or_Less_After_Arrival(CqlContext context)
    {
        CqlValueSet a_ = this.Hospital_Based_Dialysis_Services(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Encounter> c_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        IEnumerable<ValueTuple<Procedure, Encounter>> d_ = context.Operators.CrossJoin<Procedure, Encounter>(b_, c_);
        (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? e_(ValueTuple<Procedure, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? l_ = (CqlTupleMetadata_BWWSXdXSFIJQjJNcdEVJKZEGj, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?> f_ = context.Operators.Select<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? tuple_bwwsxdxsfijqjjncdevjkzegj)
        {
            object m_()
            {
                bool ad_()
                {
                    DataType ah_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlDateTime;

                    return aj_;
                };
                bool ae_()
                {
                    DataType ak_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    bool am_ = al_ is CqlInterval<CqlDateTime>;

                    return am_;
                };
                bool af_()
                {
                    DataType an_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlQuantity;

                    return ap_;
                };
                bool ag_()
                {
                    DataType aq_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlInterval<CqlQuantity>;

                    return as_;
                };
                if (ad_())
                {
                    DataType at_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);

                    return (au_ as CqlDateTime) as object;
                }
                else if (ae_())
                {
                    DataType av_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);

                    return (aw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (af_())
                {
                    DataType ax_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);

                    return (ay_ as CqlQuantity) as object;
                }
                else if (ag_())
                {
                    DataType az_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);

                    return (ba_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_());
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlDateTime s_ = context.Operators.Start(p_);
            CqlQuantity t_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime u_ = context.Operators.Add(s_, t_);
            CqlInterval<CqlDateTime> v_ = context.Operators.Interval(q_, u_, true, true);
            bool? w_ = context.Operators.In<CqlDateTime>(o_, v_, default);
            object x_()
            {
                bool bb_()
                {
                    DataType bf_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlDateTime;

                    return bh_;
                };
                bool bc_()
                {
                    DataType bi_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlInterval<CqlDateTime>;

                    return bk_;
                };
                bool bd_()
                {
                    DataType bl_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlQuantity;

                    return bn_;
                };
                bool be_()
                {
                    DataType bo_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    bool bq_ = bp_ is CqlInterval<CqlQuantity>;

                    return bq_;
                };
                if (bb_())
                {
                    DataType br_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);

                    return (bs_ as CqlDateTime) as object;
                }
                else if (bc_())
                {
                    DataType bt_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);

                    return (bu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bd_())
                {
                    DataType bv_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);

                    return (bw_ as CqlQuantity) as object;
                }
                else if (be_())
                {
                    DataType bx_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);

                    return (by_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_());
            CqlDateTime z_ = context.Operators.Start(y_);
            bool? ab_ = context.Operators.In<CqlDateTime>(z_, p_, default);
            bool? ac_ = context.Operators.And(w_, ab_);

            return ac_;
        };
        IEnumerable<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?> h_ = context.Operators.Where<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? tuple_bwwsxdxsfijqjjncdevjkzegj) =>
            tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Serum Creatinine Normal")]
    public CqlQuantity Serum_Creatinine_Normal(CqlContext context)
    {
        CqlQuantity a_()
        {
            bool b_()
            {
                List<Extension> c_()
                {
                    bool j_()
                    {
                        Patient k_ = this.Patient(context);
                        bool l_ = k_ is DomainResource;

                        return l_;
                    };
                    if (j_())
                    {
                        Patient m_ = this.Patient(context);

                        return (m_ as DomainResource).Extension;
                    }
                    else
                    {
                        return default;
                    }
                };
                bool? d_(Extension @this)
                {
                    string n_ = @this?.Url;
                    FhirString o_ = context.Operators.Convert<FhirString>(n_);
                    string p_ = FHIRHelpers_4_4_000.Instance.ToString(context, o_);
                    bool? q_ = context.Operators.Equal(p_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");

                    return q_;
                };
                IEnumerable<Extension> e_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(c_()), d_);
                DataType f_(Extension @this)
                {
                    DataType r_ = @this?.Value;

                    return r_;
                };
                IEnumerable<DataType> g_ = context.Operators.Select<Extension, DataType>(e_, f_);
                DataType h_ = context.Operators.SingletonFrom<DataType>(g_);
                bool? i_ = context.Operators.Equal(h_, "248152002");

                return i_ ?? false;
            };
            if (b_())
            {
                CqlQuantity s_ = context.Operators.Quantity(1.02m, "mg/dL");

                return s_;
            }
            else
            {
                CqlQuantity t_ = context.Operators.Quantity(1.18m, "mg/dL");

                return t_;
            }
        };

        return a_();
    }


    [CqlFunctionDefinition("HighestSerumCreatinineResult")]
    public CqlQuantity HighestSerumCreatinineResult(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> a_ = this.Qualifying_Creatinine_Lab_Result_by_Time(context);
        bool? b_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? LabTests)
        {
            string i_ = LabTests?.CrEncInPtId;
            string j_ = (QualifyingEncounter is Resource
        ? (QualifyingEncounter as Resource).IdElement
        : default)?.Value;
            bool? k_ = context.Operators.Equal(i_, j_);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> c_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(a_, b_);
        bool? d_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this)
        {
            CqlQuantity l_ = @this?.CrLabResult;
            bool? m_ = context.Operators.Not((bool?)(l_ is null));

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?> e_ = context.Operators.Where<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?>(c_, d_);
        CqlQuantity f_((CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)? @this)
        {
            CqlQuantity n_ = @this?.CrLabResult;

            return n_;
        };
        IEnumerable<CqlQuantity> g_ = context.Operators.Select<(CqlTupleMetadata, string CrEncInPtId, CqlInterval<CqlDateTime> CrHospitalization, string CrLabObsId, object CrLabObsCategory, string CrLabObsStatus, CqlQuantity CrLabResult, string CrLabResultUnit, decimal? CrLabResultValue, CqlDateTime CrLabTime, CqlDateTime CrLabTimeIssued)?, CqlQuantity>(e_, f_);
        CqlQuantity h_ = context.Operators.Max<CqlQuantity>(g_);

        return h_;
    }


    [CqlFunctionDefinition("1.5IncreaseInCreatinine")]
    public CqlQuantity _1_5IncreaseInCreatinine(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlQuantity a_ = this.HighestSerumCreatinineResult(context, QualifyingEncounter);
        CqlQuantity b_ = context.Operators.ConvertDecimalToQuantity(1.5m);
        CqlQuantity c_ = context.Operators.Divide(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with 1.5 Times Serum Creatinine Increase")]
    public IEnumerable<Encounter> Encounter_with_1_5_Times_Serum_Creatinine_Increase(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        CqlValueSet b_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> f_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, c_, e_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? g_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? n_ = (CqlTupleMetadata_JeYVEdgebecHQGRICIKegVBi, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return n_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?> h_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?>(f_, g_);
        bool? i_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_gsqsgqbihalobloqrcccgdeiw)
        {
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
            CqlQuantity ag_ = this.HighestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            bool? ah_ = context.Operators.Equal(af_ as CqlQuantity, ag_);
            bool? ai_ = context.Operators.And(ad_, ah_);
            DataType aj_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Value;
            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            CqlQuantity al_ = this.LowestSerumCreatinineResult(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            bool? am_ = context.Operators.Equal(ak_ as CqlQuantity, al_);
            bool? an_ = context.Operators.And(ai_, am_);
            CqlQuantity ao_ = this._1_5IncreaseInCreatinine(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            bool? ar_ = context.Operators.GreaterOrEqual(ao_, aq_ as CqlQuantity);
            bool? as_ = context.Operators.And(an_, ar_);
            object at_()
            {
                bool cf_()
                {
                    DataType ci_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bool ck_ = cj_ is CqlDateTime;

                    return ck_;
                };
                bool cg_()
                {
                    DataType cl_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    bool cn_ = cm_ is CqlInterval<CqlDateTime>;

                    return cn_;
                };
                bool ch_()
                {
                    DataType co_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                    bool cq_ = cp_ is CqlDateTime;

                    return cq_;
                };
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
                }
            };
            CqlDateTime au_ = QICoreCommon_4_0_000.Instance.earliest(context, at_());
            object av_()
            {
                bool cx_()
                {
                    DataType da_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    bool dc_ = db_ is CqlDateTime;

                    return dc_;
                };
                bool cy_()
                {
                    DataType dd_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    bool df_ = de_ is CqlInterval<CqlDateTime>;

                    return df_;
                };
                bool cz_()
                {
                    DataType dg_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                    bool di_ = dh_ is CqlDateTime;

                    return di_;
                };
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
                }
            };
            CqlDateTime aw_ = QICoreCommon_4_0_000.Instance.earliest(context, av_());
            CqlQuantity ax_ = context.Operators.Quantity(7m, "days");
            CqlDateTime ay_ = context.Operators.Subtract(aw_, ax_);
            object az_()
            {
                bool dp_()
                {
                    DataType ds_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    bool du_ = dt_ is CqlDateTime;

                    return du_;
                };
                bool dq_()
                {
                    DataType dv_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    bool dx_ = dw_ is CqlInterval<CqlDateTime>;

                    return dx_;
                };
                bool dr_()
                {
                    DataType dy_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    bool ea_ = dz_ is CqlDateTime;

                    return ea_;
                };
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
                }
            };
            CqlDateTime ba_ = QICoreCommon_4_0_000.Instance.earliest(context, az_());
            CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(ay_, ba_, true, false);
            bool? bc_ = context.Operators.In<CqlDateTime>(au_, bb_, default);
            object bd_()
            {
                bool eh_()
                {
                    DataType ek_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    bool em_ = el_ is CqlDateTime;

                    return em_;
                };
                bool ei_()
                {
                    DataType en_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    bool ep_ = eo_ is CqlInterval<CqlDateTime>;

                    return ep_;
                };
                bool ej_()
                {
                    DataType eq_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    bool es_ = er_ is CqlDateTime;

                    return es_;
                };
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
                }
            };
            CqlDateTime be_ = QICoreCommon_4_0_000.Instance.earliest(context, bd_());
            bool? bf_ = context.Operators.Not((bool?)(be_ is null));
            bool? bg_ = context.Operators.And(bc_, bf_);
            bool? bh_ = context.Operators.And(as_, bg_);
            object bi_()
            {
                bool ez_()
                {
                    DataType fc_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                    bool fe_ = fd_ is CqlDateTime;

                    return fe_;
                };
                bool fa_()
                {
                    DataType ff_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                    bool fh_ = fg_ is CqlInterval<CqlDateTime>;

                    return fh_;
                };
                bool fb_()
                {
                    DataType fi_ = tuple_gsqsgqbihalobloqrcccgdeiw?.LowCreatinineTest?.Effective;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    bool fk_ = fj_ is CqlDateTime;

                    return fk_;
                };
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
                }
            };
            CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_());
            CqlInterval<CqlDateTime> bk_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter);
            bool? bl_ = context.Operators.In<CqlDateTime>(bj_, bk_, default);
            bool? bm_ = context.Operators.And(bh_, bl_);
            object bn_()
            {
                bool fr_()
                {
                    DataType fu_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                    bool fw_ = fv_ is CqlDateTime;

                    return fw_;
                };
                bool fs_()
                {
                    DataType fx_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);
                    bool fz_ = fy_ is CqlInterval<CqlDateTime>;

                    return fz_;
                };
                bool ft_()
                {
                    DataType ga_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
                    bool gc_ = gb_ is CqlDateTime;

                    return gc_;
                };
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
                }
            };
            CqlDateTime bo_ = QICoreCommon_4_0_000.Instance.earliest(context, bn_());
            CqlDateTime bq_ = context.Operators.Start(bk_);
            CqlQuantity br_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime bs_ = context.Operators.Add(bq_, br_);
            CqlDateTime bu_ = context.Operators.Start(bk_);
            CqlQuantity bv_ = context.Operators.Quantity(30m, "days");
            CqlDateTime bw_ = context.Operators.Add(bu_, bv_);
            CqlInterval<CqlDateTime> bx_ = context.Operators.Interval(bs_, bw_, true, true);
            bool? by_ = context.Operators.In<CqlDateTime>(bo_, bx_, default);
            bool? bz_ = context.Operators.And(bm_, by_);
            object ca_()
            {
                bool gj_()
                {
                    DataType gm_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                    bool go_ = gn_ is CqlDateTime;

                    return go_;
                };
                bool gk_()
                {
                    DataType gp_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                    bool gr_ = gq_ is CqlInterval<CqlDateTime>;

                    return gr_;
                };
                bool gl_()
                {
                    DataType gs_ = tuple_gsqsgqbihalobloqrcccgdeiw?.HighCreatinineTest?.Effective;
                    object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                    bool gu_ = gt_ is CqlDateTime;

                    return gu_;
                };
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
                }
            };
            CqlDateTime cb_ = QICoreCommon_4_0_000.Instance.earliest(context, ca_());
            bool? cd_ = context.Operators.In<CqlDateTime>(cb_, bk_, default);
            bool? ce_ = context.Operators.And(bz_, cd_);

            return ce_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?> j_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?>(h_, i_);
        Encounter k_((CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_gsqsgqbihalobloqrcccgdeiw) =>
            tuple_gsqsgqbihalobloqrcccgdeiw?.QualifyingEncounter;
        IEnumerable<Encounter> l_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Observation HighCreatinineTest, Observation LowCreatinineTest)?, Encounter>(j_, k_);
        IEnumerable<Encounter> m_ = context.Operators.Distinct<Encounter>(l_);

        return m_;
    }


    [CqlExpressionDefinition("Encounter with 2 Times Serum Creatinine Increase")]
    public IEnumerable<Encounter> Encounter_with_2_Times_Serum_Creatinine_Increase(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_1_5_Times_Serum_Creatinine_Increase(context);
        CqlValueSet b_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> f_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, c_, e_);
        (CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? g_(ValueTuple<Encounter, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? n_ = (CqlTupleMetadata_BDjSiZCAhXcVgEETFRJVEHXOR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return n_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?> h_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?>(f_, g_);
        bool? i_((CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_bdjsizcahxcvgeetfrjvehxor)
        {
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
            CqlQuantity ag_ = this.HighestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            bool? ah_ = context.Operators.Equal(af_ as CqlQuantity, ag_);
            bool? ai_ = context.Operators.And(ad_, ah_);
            DataType aj_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Value;
            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            CqlQuantity al_ = this.LowestSerumCreatinineResult(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            bool? am_ = context.Operators.Equal(ak_ as CqlQuantity, al_);
            bool? an_ = context.Operators.And(ai_, am_);
            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            bool? as_ = context.Operators.GreaterOrEqual(ap_ as CqlQuantity, ar_ as CqlQuantity);
            bool? at_ = context.Operators.And(an_, as_);
            object au_()
            {
                bool cg_()
                {
                    DataType cj_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlDateTime;

                    return cl_;
                };
                bool ch_()
                {
                    DataType cm_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    bool co_ = cn_ is CqlInterval<CqlDateTime>;

                    return co_;
                };
                bool ci_()
                {
                    DataType cp_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    bool cr_ = cq_ is CqlDateTime;

                    return cr_;
                };
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
                }
            };
            CqlDateTime av_ = QICoreCommon_4_0_000.Instance.earliest(context, au_());
            object aw_()
            {
                bool cy_()
                {
                    DataType db_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlDateTime;

                    return dd_;
                };
                bool cz_()
                {
                    DataType de_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    bool dg_ = df_ is CqlInterval<CqlDateTime>;

                    return dg_;
                };
                bool da_()
                {
                    DataType dh_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                    bool dj_ = di_ is CqlDateTime;

                    return dj_;
                };
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
                }
            };
            CqlDateTime ax_ = QICoreCommon_4_0_000.Instance.earliest(context, aw_());
            CqlQuantity ay_ = context.Operators.Quantity(7m, "days");
            CqlDateTime az_ = context.Operators.Subtract(ax_, ay_);
            object ba_()
            {
                bool dq_()
                {
                    DataType dt_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    bool dv_ = du_ is CqlDateTime;

                    return dv_;
                };
                bool dr_()
                {
                    DataType dw_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    bool dy_ = dx_ is CqlInterval<CqlDateTime>;

                    return dy_;
                };
                bool ds_()
                {
                    DataType dz_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                    bool eb_ = ea_ is CqlDateTime;

                    return eb_;
                };
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
                }
            };
            CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_());
            CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(az_, bb_, true, false);
            bool? bd_ = context.Operators.In<CqlDateTime>(av_, bc_, default);
            object be_()
            {
                bool ei_()
                {
                    DataType el_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                    bool en_ = em_ is CqlDateTime;

                    return en_;
                };
                bool ej_()
                {
                    DataType eo_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                    bool eq_ = ep_ is CqlInterval<CqlDateTime>;

                    return eq_;
                };
                bool ek_()
                {
                    DataType er_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    bool et_ = es_ is CqlDateTime;

                    return et_;
                };
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
                }
            };
            CqlDateTime bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_());
            bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
            bool? bh_ = context.Operators.And(bd_, bg_);
            bool? bi_ = context.Operators.And(at_, bh_);
            object bj_()
            {
                bool fa_()
                {
                    DataType fd_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                    bool ff_ = fe_ is CqlDateTime;

                    return ff_;
                };
                bool fb_()
                {
                    DataType fg_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                    bool fi_ = fh_ is CqlInterval<CqlDateTime>;

                    return fi_;
                };
                bool fc_()
                {
                    DataType fj_ = tuple_bdjsizcahxcvgeetfrjvehxor?.LowCreatinineTest?.Effective;
                    object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                    bool fl_ = fk_ is CqlDateTime;

                    return fl_;
                };
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
                }
            };
            CqlDateTime bk_ = QICoreCommon_4_0_000.Instance.earliest(context, bj_());
            CqlInterval<CqlDateTime> bl_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine);
            bool? bm_ = context.Operators.In<CqlDateTime>(bk_, bl_, default);
            bool? bn_ = context.Operators.And(bi_, bm_);
            object bo_()
            {
                bool fs_()
                {
                    DataType fv_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                    bool fx_ = fw_ is CqlDateTime;

                    return fx_;
                };
                bool ft_()
                {
                    DataType fy_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                    bool ga_ = fz_ is CqlInterval<CqlDateTime>;

                    return ga_;
                };
                bool fu_()
                {
                    DataType gb_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
                    bool gd_ = gc_ is CqlDateTime;

                    return gd_;
                };
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
                }
            };
            CqlDateTime bp_ = QICoreCommon_4_0_000.Instance.earliest(context, bo_());
            CqlDateTime br_ = context.Operators.Start(bl_);
            CqlQuantity bs_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime bt_ = context.Operators.Add(br_, bs_);
            CqlDateTime bv_ = context.Operators.Start(bl_);
            CqlQuantity bw_ = context.Operators.Quantity(30m, "days");
            CqlDateTime bx_ = context.Operators.Add(bv_, bw_);
            CqlInterval<CqlDateTime> by_ = context.Operators.Interval(bt_, bx_, true, true);
            bool? bz_ = context.Operators.In<CqlDateTime>(bp_, by_, default);
            bool? ca_ = context.Operators.And(bn_, bz_);
            object cb_()
            {
                bool gk_()
                {
                    DataType gn_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                    bool gp_ = go_ is CqlDateTime;

                    return gp_;
                };
                bool gl_()
                {
                    DataType gq_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gq_);
                    bool gs_ = gr_ is CqlInterval<CqlDateTime>;

                    return gs_;
                };
                bool gm_()
                {
                    DataType gt_ = tuple_bdjsizcahxcvgeetfrjvehxor?.HighCreatinineTest?.Effective;
                    object gu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gt_);
                    bool gv_ = gu_ is CqlDateTime;

                    return gv_;
                };
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
                }
            };
            CqlDateTime cc_ = QICoreCommon_4_0_000.Instance.earliest(context, cb_());
            bool? ce_ = context.Operators.In<CqlDateTime>(cc_, bl_, default);
            bool? cf_ = context.Operators.And(ca_, ce_);

            return cf_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?> j_ = context.Operators.Where<(CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?>(h_, i_);
        Encounter k_((CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)? tuple_bdjsizcahxcvgeetfrjvehxor) =>
            tuple_bdjsizcahxcvgeetfrjvehxor?.EncounterWithHighCreatinine;
        IEnumerable<Encounter> l_ = context.Operators.Select<(CqlTupleMetadata, Encounter EncounterWithHighCreatinine, Observation HighCreatinineTest, Observation LowCreatinineTest)?, Encounter>(j_, k_);
        IEnumerable<Encounter> m_ = context.Operators.Distinct<Encounter>(l_);

        return m_;
    }


    [CqlExpressionDefinition("Encounter with Kidney Dialysis Started 48 Hours or Less After Arrival without High Creatinine")]
    public IEnumerable<Encounter> Encounter_with_Kidney_Dialysis_Started_48_Hours_or_Less_After_Arrival_without_High_Creatinine(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Kidney_Dialysis_Started_48_Hours_or_Less_After_Arrival(context);
        bool? b_(Encounter EncounterWithKidneyDialysis48HoursOrAfter)
        {
            IEnumerable<Encounter> d_ = this.Encounter_with_2_Times_Serum_Creatinine_Increase(context);
            bool? e_(Encounter EncounterWithHighCreatinine)
            {
                Period i_ = EncounterWithHighCreatinine?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                Period k_ = EncounterWithKidneyDialysis48HoursOrAfter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, default);

                return m_;
            };
            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            bool? g_ = context.Operators.Exists<Encounter>(f_);
            bool? h_ = context.Operators.Not(g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with High Risk Diagnosis for AKI")]
    public IEnumerable<Encounter> Encounter_with_High_Risk_Diagnosis_for_AKI(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        bool? b_(Encounter QualifyingEncounter)
        {
            IEnumerable<object> d_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, QualifyingEncounter);
            bool? e_(object EncounterDiagnosis)
            {
                object h_ = context.Operators.LateBoundProperty<object>(EncounterDiagnosis, "code");
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_ as CodeableConcept);
                CqlValueSet j_ = this.High_Risk_Diagnosis_for_AKI(context);
                bool? k_ = context.Operators.ConceptInValueSet(i_, j_);

                return k_;
            };
            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            bool? g_ = context.Operators.Exists<object>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter with High Risk Procedures for AKI")]
    public IEnumerable<Encounter> Encounter_with_High_Risk_Procedures_for_AKI(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        IEnumerable<Encounter> b_(Encounter QualifyingEncounter)
        {
            CqlValueSet d_ = this.High_Risk_Procedures_for_AKI(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? f_(Procedure HighRiskProcedures)
            {
                object j_()
                {
                    bool o_()
                    {
                        DataType s_ = HighRiskProcedures?.Performed;
                        object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                        bool u_ = t_ is CqlDateTime;

                        return u_;
                    };
                    bool p_()
                    {
                        DataType v_ = HighRiskProcedures?.Performed;
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        bool x_ = w_ is CqlInterval<CqlDateTime>;

                        return x_;
                    };
                    bool q_()
                    {
                        DataType y_ = HighRiskProcedures?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlQuantity;

                        return aa_;
                    };
                    bool r_()
                    {
                        DataType ab_ = HighRiskProcedures?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlInterval<CqlQuantity>;

                        return ad_;
                    };
                    if (o_())
                    {
                        DataType ae_ = HighRiskProcedures?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);

                        return (af_ as CqlDateTime) as object;
                    }
                    else if (p_())
                    {
                        DataType ag_ = HighRiskProcedures?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);

                        return (ah_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (q_())
                    {
                        DataType ai_ = HighRiskProcedures?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);

                        return (aj_ as CqlQuantity) as object;
                    }
                    else if (r_())
                    {
                        DataType ak_ = HighRiskProcedures?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);

                        return (al_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_());
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
                bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, default);

                return n_;
            };
            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure HighRiskProcedures) =>
                QualifyingEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Less_Than_2_Creatinine_Results_within_48_Hours_of_Arrival(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Index_eGFR_Less_Than_60_within_First_48_Hours(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_with_0_3_mg_dL_or_More_Increase_in_Creatinine(context);
        IEnumerable<Encounter> e_ = this.Encounter_with_Kidney_Dialysis_Started_48_Hours_or_Less_After_Arrival_without_High_Creatinine(context);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        IEnumerable<Encounter> h_ = this.Encounter_with_High_Risk_Diagnosis_for_AKI(context);
        IEnumerable<Encounter> i_ = this.Encounter_with_High_Risk_Procedures_for_AKI(context);
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(g_, j_);

        return k_;
    }


    [CqlExpressionDefinition("Encounter with Kidney Dialysis Started More Than 48 Hours After Arrival")]
    public IEnumerable<Encounter> Encounter_with_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival(CqlContext context)
    {
        CqlValueSet a_ = this.Hospital_Based_Dialysis_Services(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Encounter> c_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        IEnumerable<ValueTuple<Procedure, Encounter>> d_ = context.Operators.CrossJoin<Procedure, Encounter>(b_, c_);
        (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? e_(ValueTuple<Procedure, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? l_ = (CqlTupleMetadata_BWWSXdXSFIJQjJNcdEVJKZEGj, _valueTuple.Item1, _valueTuple.Item2);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?> f_ = context.Operators.Select<ValueTuple<Procedure, Encounter>, (CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? tuple_bwwsxdxsfijqjjncdevjkzegj)
        {
            object m_()
            {
                bool ad_()
                {
                    DataType ah_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlDateTime;

                    return aj_;
                };
                bool ae_()
                {
                    DataType ak_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    bool am_ = al_ is CqlInterval<CqlDateTime>;

                    return am_;
                };
                bool af_()
                {
                    DataType an_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlQuantity;

                    return ap_;
                };
                bool ag_()
                {
                    DataType aq_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlInterval<CqlQuantity>;

                    return as_;
                };
                if (ad_())
                {
                    DataType at_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);

                    return (au_ as CqlDateTime) as object;
                }
                else if (ae_())
                {
                    DataType av_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);

                    return (aw_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (af_())
                {
                    DataType ax_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);

                    return (ay_ as CqlQuantity) as object;
                }
                else if (ag_())
                {
                    DataType az_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);

                    return (ba_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_());
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlQuantity r_ = context.Operators.Quantity(48m, "hours");
            CqlDateTime s_ = context.Operators.Add(q_, r_);
            CqlDateTime u_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> v_ = context.Operators.Interval(s_, u_, true, true);
            bool? w_ = context.Operators.In<CqlDateTime>(o_, v_, default);
            object x_()
            {
                bool bb_()
                {
                    DataType bf_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlDateTime;

                    return bh_;
                };
                bool bc_()
                {
                    DataType bi_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlInterval<CqlDateTime>;

                    return bk_;
                };
                bool bd_()
                {
                    DataType bl_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlQuantity;

                    return bn_;
                };
                bool be_()
                {
                    DataType bo_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    bool bq_ = bp_ is CqlInterval<CqlQuantity>;

                    return bq_;
                };
                if (bb_())
                {
                    DataType br_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);

                    return (bs_ as CqlDateTime) as object;
                }
                else if (bc_())
                {
                    DataType bt_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);

                    return (bu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bd_())
                {
                    DataType bv_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);

                    return (bw_ as CqlQuantity) as object;
                }
                else if (be_())
                {
                    DataType bx_ = tuple_bwwsxdxsfijqjjncdevjkzegj?.Dialysis?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);

                    return (by_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_());
            CqlDateTime z_ = context.Operators.Start(y_);
            bool? ab_ = context.Operators.In<CqlDateTime>(z_, p_, default);
            bool? ac_ = context.Operators.And(w_, ab_);

            return ac_;
        };
        IEnumerable<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?> h_ = context.Operators.Where<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)? tuple_bwwsxdxsfijqjjncdevjkzegj) =>
            tuple_bwwsxdxsfijqjjncdevjkzegj?.QualifyingEncounter;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Procedure Dialysis, Encounter QualifyingEncounter)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);

        return k_;
    }


    [CqlExpressionDefinition("Encounter with Kidney Dialysis Started More Than 48 Hours After Arrival without High Creatinine")]
    public IEnumerable<Encounter> Encounter_with_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival_without_High_Creatinine(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival(context);
        bool? b_(Encounter EncounterWithDialysisAfter48Hours)
        {
            IEnumerable<Encounter> d_ = this.Encounter_with_2_Times_Serum_Creatinine_Increase(context);
            bool? e_(Encounter EncounterWithHighCreatinine)
            {
                Period i_ = EncounterWithHighCreatinine?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                Period k_ = EncounterWithDialysisAfter48Hours?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, default);

                return m_;
            };
            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            bool? g_ = context.Operators.Exists<Encounter>(f_);
            bool? h_ = context.Operators.Not(g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_2_Times_Serum_Creatinine_Increase(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Kidney_Dialysis_Started_More_Than_48_Hours_After_Arrival_without_High_Creatinine(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

        return c_;
    }


    [CqlFunctionDefinition("SerumCreatinineSequencebyTime")]
    public IEnumerable<Observation> SerumCreatinineSequencebyTime(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Creatinine_Mass_Per_Volume(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        bool? c_(Observation CreatinineTestByTime)
        {
            object h_()
            {
                bool x_()
                {
                    DataType aa_ = CreatinineTestByTime?.Effective;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    bool ac_ = ab_ is CqlDateTime;

                    return ac_;
                };
                bool y_()
                {
                    DataType ad_ = CreatinineTestByTime?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlInterval<CqlDateTime>;

                    return af_;
                };
                bool z_()
                {
                    DataType ag_ = CreatinineTestByTime?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;

                    return ai_;
                };
                if (x_())
                {
                    DataType aj_ = CreatinineTestByTime?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);

                    return (ak_ as CqlDateTime) as object;
                }
                else if (y_())
                {
                    DataType al_ = CreatinineTestByTime?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);

                    return (am_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (z_())
                {
                    DataType an_ = CreatinineTestByTime?.Effective;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);

                    return (ao_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime i_ = QICoreCommon_4_0_000.Instance.earliest(context, h_());
            CqlInterval<CqlDateTime> j_ = CQMCommon_4_1_000.Instance.hospitalization(context, QualifyingEncounter);
            bool? k_ = context.Operators.In<CqlDateTime>(i_, j_, default);
            DataType l_ = CreatinineTestByTime?.Value;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            bool? n_ = context.Operators.Not((bool?)(m_ is null));
            bool? o_ = context.Operators.And(k_, n_);
            bool? p_ = QICoreCommon_4_0_000.Instance.isLaboratory(context, CreatinineTestByTime as object);
            bool? q_ = context.Operators.And(o_, p_);
            Code<ObservationStatus> r_ = CreatinineTestByTime?.StatusElement;
            ObservationStatus? s_ = r_?.Value;
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            bool? w_ = context.Operators.And(q_, v_);

            return w_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        Observation e_(Observation CreatinineTestByTime) =>
            CreatinineTestByTime;
        IEnumerable<Observation> f_ = context.Operators.Select<Observation, Observation>(d_, e_);
        IEnumerable<Observation> g_ = context.Operators.Distinct<Observation>(f_);

        return g_;
    }


    [CqlFunctionDefinition("2.0IncreaseInCreatinine")]
    public CqlQuantity _2_0IncreaseInCreatinine(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlQuantity a_ = this.HighestSerumCreatinineResult(context, QualifyingEncounter);
        CqlQuantity b_ = context.Operators.ConvertIntegerToQuantity(2);
        CqlQuantity c_ = context.Operators.Divide(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Estimated Glomerular Filtration Rate for Females")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> Risk_Variable_Estimated_Glomerular_Filtration_Rate_for_Females(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        (CqlTupleMetadata, string encounterId, decimal? eGFR)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            decimal? g_ = this.FemaleeGFR(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, decimal? eGFR)? h_ = (CqlTupleMetadata_ChQZQhiCBOOJUfBhSOMPAPSKY, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, decimal? eGFR)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, decimal? eGFR)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Risk Variable Estimated Glomerular Filtration Rate for Males")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> Risk_Variable_Estimated_Glomerular_Filtration_Rate_for_Males(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        (CqlTupleMetadata, string encounterId, decimal? eGFR)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            decimal? g_ = this.MaleeGFR(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, decimal? eGFR)? h_ = (CqlTupleMetadata_ChQZQhiCBOOJUfBhSOMPAPSKY, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, decimal? eGFR)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, decimal? eGFR)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, decimal? eGFR)?>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Diagnoses with POA Indication")]
    public IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)?> Risk_Variable_All_Encounter_Diagnoses_with_POA_Indication(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        IEnumerable<Claim> b_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
        IEnumerable<ValueTuple<Encounter, Claim>> c_ = context.Operators.CrossJoin<Encounter, Claim>(a_, b_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)? d_(ValueTuple<Encounter, Claim> _valueTuple)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)? k_ = (CqlTupleMetadata_HJXKcBjYOeaJSUHgPLEXXCjGc, _valueTuple.Item1, _valueTuple.Item2);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)?> e_ = context.Operators.Select<ValueTuple<Encounter, Claim>, (CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)?>(c_, d_);
        bool? f_((CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)? tuple_csikdkffnecdbrrkiiwklenqg)
        {
            Code<FinancialResourceStatusCodes> l_ = tuple_csikdkffnecdbrrkiiwklenqg?.claim?.StatusElement;
            FinancialResourceStatusCodes? m_ = l_?.Value;
            Code<FinancialResourceStatusCodes> n_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(m_);
            bool? o_ = context.Operators.Equal(n_, "active");
            Code<ClaimUseCode> p_ = tuple_csikdkffnecdbrrkiiwklenqg?.claim?.UseElement;
            ClaimUseCode? q_ = p_?.Value;
            Code<ClaimUseCode> r_ = context.Operators.Convert<Code<ClaimUseCode>>(q_);
            bool? s_ = context.Operators.Equal(r_, "claim");
            bool? t_ = context.Operators.And(o_, s_);
            List<Claim.ItemComponent> u_ = tuple_csikdkffnecdbrrkiiwklenqg?.claim?.Item;
            bool? v_(Claim.ItemComponent I)
            {
                List<ResourceReference> z_ = I?.Encounter;
                bool? aa_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)z_, tuple_csikdkffnecdbrrkiiwklenqg?.QualifyingEncounter);
                List<Claim.DiagnosisComponent> ab_ = tuple_csikdkffnecdbrrkiiwklenqg?.claim?.Diagnosis;
                bool? ac_(Claim.DiagnosisComponent D)
                {
                    PositiveInt ag_ = D?.SequenceElement;
                    int? ah_ = ag_?.Value;
                    List<Claim.ItemComponent> ai_ = tuple_csikdkffnecdbrrkiiwklenqg?.claim?.Item;
                    bool? aj_(Claim.ItemComponent @this)
                    {
                        List<PositiveInt> au_ = @this?.DiagnosisSequenceElement;
                        int? av_(PositiveInt @this)
                        {
                            int? ay_ = @this?.Value;

                            return ay_;
                        };
                        IEnumerable<int?> aw_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)au_, av_);
                        bool? ax_ = context.Operators.Not((bool?)(aw_ is null));

                        return ax_;
                    };
                    IEnumerable<Claim.ItemComponent> ak_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ai_, aj_);
                    IEnumerable<int?> al_(Claim.ItemComponent @this)
                    {
                        List<PositiveInt> az_ = @this?.DiagnosisSequenceElement;
                        int? ba_(PositiveInt @this)
                        {
                            int? bc_ = @this?.Value;

                            return bc_;
                        };
                        IEnumerable<int?> bb_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)az_, ba_);

                        return bb_;
                    };
                    IEnumerable<IEnumerable<int?>> am_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(ak_, al_);
                    IEnumerable<int?> an_ = context.Operators.Flatten<int?>(am_);
                    bool? ao_ = context.Operators.In<int?>(ah_, an_);
                    CodeableConcept ap_ = D?.OnAdmission;
                    CqlConcept aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ap_);
                    CqlValueSet ar_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                    bool? as_ = context.Operators.ConceptInValueSet(aq_, ar_);
                    bool? at_ = context.Operators.And(ao_, as_);

                    return at_;
                };
                IEnumerable<Claim.DiagnosisComponent> ad_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)ab_, ac_);
                bool? ae_ = context.Operators.Exists<Claim.DiagnosisComponent>(ad_);
                bool? af_ = context.Operators.And(aa_, ae_);

                return af_;
            };
            IEnumerable<Claim.ItemComponent> w_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)u_, v_);
            bool? x_ = context.Operators.Exists<Claim.ItemComponent>(w_);
            bool? y_ = context.Operators.And(t_, x_);

            return y_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)?> g_ = context.Operators.Where<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)?>(e_, f_);
        (CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)? h_((CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)? tuple_csikdkffnecdbrrkiiwklenqg)
        {
            (CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)? bd_ = (CqlTupleMetadata_HJXKcBjYOeaJSUHgPLEXXCjGc, tuple_csikdkffnecdbrrkiiwklenqg?.QualifyingEncounter, tuple_csikdkffnecdbrrkiiwklenqg?.claim);

            return bd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)?> i_ = context.Operators.Select<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)?, (CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)?>(g_, h_);
        IEnumerable<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter QualifyingEncounter, Claim claim)?>(i_);

        return j_;
    }


    [CqlFunctionDefinition("FirstHeartRate")]
    public CqlQuantity FirstHeartRate(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlCode a_ = this.Heart_rate(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate"));
        bool? d_(Observation FirstHeartBeats)
        {
            DataType k_ = FirstHeartBeats?.Effective;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            CqlDateTime m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_);
            CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, default);
            DataType p_ = FirstHeartBeats?.Value;
            CqlQuantity q_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, p_ as Quantity);
            bool? r_ = context.Operators.Not((bool?)(q_ is null));
            bool? s_ = context.Operators.And(o_, r_);

            return s_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        object f_(Observation @this)
        {
            DataType t_ = @this?.Effective;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            CqlDateTime v_ = QICoreCommon_4_0_000.Instance.earliest(context, u_);

            return v_;
        };
        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.First<Observation>(g_);
        DataType i_ = h_?.Value;
        CqlQuantity j_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, i_ as Quantity);

        return j_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Heart Rate in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> Risk_Variable_First_Heart_Rate_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstHeartRate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)? h_ = (CqlTupleMetadata_FagZCcMXCLUWREPQINNbEKifA, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstHeartRate)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstRespiratoryRate")]
    public CqlQuantity FirstRespiratoryRate(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlCode a_ = this.Respiratory_rate(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-respiratory-rate"));
        bool? d_(Observation FirstRespiration)
        {
            DataType k_ = FirstRespiration?.Effective;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            CqlDateTime m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_);
            CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, default);
            DataType p_ = FirstRespiration?.Value;
            CqlQuantity q_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, p_ as Quantity);
            bool? r_ = context.Operators.Not((bool?)(q_ is null));
            bool? s_ = context.Operators.And(o_, r_);

            return s_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        object f_(Observation @this)
        {
            DataType t_ = @this?.Effective;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            CqlDateTime v_ = QICoreCommon_4_0_000.Instance.earliest(context, u_);

            return v_;
        };
        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.First<Observation>(g_);
        DataType i_ = h_?.Value;
        CqlQuantity j_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, i_ as Quantity);

        return j_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Respiratory Rate in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> Risk_Variable_First_Respiratory_Rate_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstRespiratoryRate(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)? h_ = (CqlTupleMetadata_BWTiRIaMgaifWSHaCRbRQdjII, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstRespiratoryRate)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstSystolicBloodPressure")]
    public CqlQuantity FirstSystolicBloodPressure(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Systolic_Blood_Pressure_Reading(context);
        bool? b_(Observation SBPReading)
        {
            DataType h_ = SBPReading?.Effective;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlDateTime j_ = QICoreCommon_4_0_000.Instance.earliest(context, i_);
            CqlInterval<CqlDateTime> k_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, default);

            return l_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        CqlQuantity d_(Observation SBPReading)
        {
            List<Observation.ComponentComponent> m_ = SBPReading?.Component;
            bool? n_(Observation.ComponentComponent SBPComponent)
            {
                CodeableConcept t_ = SBPComponent?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                CqlCode v_ = this.Systolic_blood_pressure(context);
                CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
                bool? x_ = context.Operators.Equivalent(u_, w_);

                return x_;
            };
            IEnumerable<Observation.ComponentComponent> o_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)m_, n_);
            CqlQuantity p_(Observation.ComponentComponent SBPComponent)
            {
                DataType y_ = SBPComponent?.Value;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                return z_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> q_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(o_, p_);
            IEnumerable<CqlQuantity> r_ = context.Operators.Distinct<CqlQuantity>(q_);
            CqlQuantity s_ = context.Operators.SingletonFrom<CqlQuantity>(r_);

            return s_;
        };
        IEnumerable<CqlQuantity> e_ = context.Operators.Select<Observation, CqlQuantity>(c_, d_);
        IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);
        CqlQuantity g_ = context.Operators.First<CqlQuantity>(f_);

        return g_;
    }


    [CqlExpressionDefinition("Qualifying Systolic Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Systolic_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-blood-pressure"));
        bool? b_(Observation BloodPressure)
        {
            DataType d_ = BloodPressure?.Effective;
            object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            CqlDateTime f_ = QICoreCommon_4_0_000.Instance.earliest(context, e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            bool? h_ = context.Operators.In<CqlDateTime>(f_, g_, "day");

            return h_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Risk Variable First Systolic Blood Pressure in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?> Risk_Variable_First_Systolic_Blood_Pressure_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstSystolicBloodPressure(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)? h_ = (CqlTupleMetadata_BfHgdIQNPeXTfGHcOBiXACaRK, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstSystolicBP)?>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstBodyTemperature")]
    public CqlQuantity FirstBodyTemperature(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlValueSet a_ = this.Body_temperature(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-body-temperature"));
        bool? c_(Observation FirstTemperature)
        {
            DataType j_ = FirstTemperature?.Effective;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_);
            CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, default);
            DataType o_ = FirstTemperature?.Value;
            CqlQuantity p_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, o_ as Quantity);
            bool? q_ = context.Operators.Not((bool?)(p_ is null));
            bool? r_ = context.Operators.And(n_, q_);

            return r_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        object e_(Observation @this)
        {
            DataType s_ = @this?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);

            return u_;
        };
        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.First<Observation>(f_);
        DataType h_ = g_?.Value;
        CqlQuantity i_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, h_ as Quantity);

        return i_ as CqlQuantity;
    }


    [CqlExpressionDefinition("Risk Variable First Temperature in Encounter")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)?> Risk_Variable_First_Temperature_in_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Creatinine_and_without_Obstetrical_Conditions(context);
        (CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)? b_(Encounter QualifyingEncounter)
        {
            Id e_ = QualifyingEncounter?.IdElement;
            string f_ = e_?.Value;
            CqlQuantity g_ = this.FirstBodyTemperature(context, QualifyingEncounter);
            (CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)? h_ = (CqlTupleMetadata_HjOGEZILgEFXhMPHLgWdcOTZ, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, CqlQuantity firstTemperature)?>(c_);

        return d_;
    }


    #endregion Functions and Expressions

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

    private static CqlTupleMetadata CqlTupleMetadata_HJXKcBjYOeaJSUHgPLEXXCjGc = new(
      [typeof(Encounter), typeof(Claim)],
      ["QualifyingEncounter", "claim"]);

    private static CqlTupleMetadata CqlTupleMetadata_JeYVEdgebecHQGRICIKegVBi = new(
      [typeof(Encounter), typeof(Observation), typeof(Observation)],
      ["QualifyingEncounter", "HighCreatinineTest", "LowCreatinineTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_XFRBIZcEbIWeUfjZdAFDdJef = new(
      [typeof(string), typeof(CqlInterval<CqlDateTime>), typeof(string), typeof(object), typeof(string), typeof(CqlQuantity), typeof(string), typeof(decimal?), typeof(CqlDateTime), typeof(CqlDateTime)],
      ["CrEncInPtId", "CrHospitalization", "CrLabObsId", "CrLabObsCategory", "CrLabObsStatus", "CrLabResult", "CrLabResultUnit", "CrLabResultValue", "CrLabTime", "CrLabTimeIssued"]);

    #endregion CqlTupleMetadata Properties

}

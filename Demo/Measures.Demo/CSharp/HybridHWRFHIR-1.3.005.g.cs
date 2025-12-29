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
[CqlLibrary("HybridHWRFHIR", "1.3.005")]
public partial class HybridHWRFHIR_1_3_005 : ILibrary, ISingleton<HybridHWRFHIR_1_3_005>
{
    private HybridHWRFHIR_1_3_005() {}

    public static HybridHWRFHIR_1_3_005 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HybridHWRFHIR";
    public string Version => "1.3.005";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Bicarbonate lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", valueSetVersion: null)]
    public CqlValueSet Bicarbonate_lab_test(CqlContext _) => _Bicarbonate_lab_test;
    private static readonly CqlValueSet _Bicarbonate_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);

    [CqlValueSetDefinition("Body temperature", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", valueSetVersion: null)]
    public CqlValueSet Body_temperature(CqlContext _) => _Body_temperature;
    private static readonly CqlValueSet _Body_temperature = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152", null);

    [CqlValueSetDefinition("Body weight", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.159", valueSetVersion: null)]
    public CqlValueSet Body_weight(CqlContext _) => _Body_weight;
    private static readonly CqlValueSet _Body_weight = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.159", null);

    [CqlValueSetDefinition("Creatinine lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", valueSetVersion: null)]
    public CqlValueSet Creatinine_lab_test(CqlContext _) => _Creatinine_lab_test;
    private static readonly CqlValueSet _Creatinine_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("Glucose lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", valueSetVersion: null)]
    public CqlValueSet Glucose_lab_test(CqlContext _) => _Glucose_lab_test;
    private static readonly CqlValueSet _Glucose_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

    [CqlValueSetDefinition("Hematocrit lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", valueSetVersion: null)]
    public CqlValueSet Hematocrit_lab_test(CqlContext _) => _Hematocrit_lab_test;
    private static readonly CqlValueSet _Hematocrit_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

    [CqlValueSetDefinition("Medicare payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", valueSetVersion: null)]
    public CqlValueSet Medicare_payer(CqlContext _) => _Medicare_payer;
    private static readonly CqlValueSet _Medicare_payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("ONC Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext _) => _ONC_Administrative_Sex;
    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlValueSetDefinition("Payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer(CqlContext _) => _Payer;
    private static readonly CqlValueSet _Payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Potassium lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", valueSetVersion: null)]
    public CqlValueSet Potassium_lab_test(CqlContext _) => _Potassium_lab_test;
    private static readonly CqlValueSet _Potassium_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlValueSetDefinition("Sodium lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", valueSetVersion: null)]
    public CqlValueSet Sodium_lab_test(CqlContext _) => _Sodium_lab_test;
    private static readonly CqlValueSet _Sodium_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", null);

    [CqlValueSetDefinition("White blood cells count lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", valueSetVersion: null)]
    public CqlValueSet White_blood_cells_count_lab_test(CqlContext _) => _White_blood_cells_count_lab_test;
    private static readonly CqlValueSet _White_blood_cells_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    [CqlCodeDefinition("Heart rate", codeId: "8867-4", codeSystem: "http://loinc.org")]
    public CqlCode Heart_rate(CqlContext _) => _Heart_rate;
    private static readonly CqlCode _Heart_rate = new CqlCode("8867-4", "http://loinc.org");

    [CqlCodeDefinition("Oxygen saturation in Arterial blood by Pulse oximetry", codeId: "59408-5", codeSystem: "http://loinc.org")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(CqlContext _) => _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry;
    private static readonly CqlCode _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry = new CqlCode("59408-5", "http://loinc.org");

    [CqlCodeDefinition("Respiratory rate", codeId: "9279-1", codeSystem: "http://loinc.org")]
    public CqlCode Respiratory_rate(CqlContext _) => _Respiratory_rate;
    private static readonly CqlCode _Respiratory_rate = new CqlCode("9279-1", "http://loinc.org");

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC:2.69", codeSystemId: "http://loinc.org", codeSystemVersion: "2.69")]
    public CqlCodeSystem LOINC_2_69(CqlContext _) => _LOINC_2_69;
    private static readonly CqlCodeSystem _LOINC_2_69 =
      new CqlCodeSystem("http://loinc.org", "2.69", [
          _Birth_date,
          _Heart_rate,
          _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry,
          _Respiratory_rate,
          _Systolic_blood_pressure]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("HybridHWRFHIR-1.3.005", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlFunctionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];
        CqlInterval<CqlDateTime> b_(Encounter Visit)
        {
            CqlValueSet f_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? h_(Encounter LastED)
            {
                Period ag_ = LastED?.Period;
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ag_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                CqlValueSet aj_ = this.Observation_Services(context);
                IEnumerable<Encounter> ak_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? al_(Encounter LastObs)
                {
                    Period cc_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cc_);
                    CqlDateTime ce_ = context.Operators.End(cd_);
                    Period cf_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cf_);
                    CqlDateTime ch_ = context.Operators.Start(cg_);
                    CqlQuantity ci_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cj_ = context.Operators.Subtract(ch_, ci_);
                    CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cf_);
                    CqlDateTime cm_ = context.Operators.Start(cl_);
                    CqlInterval<CqlDateTime> cn_ = context.Operators.Interval(cj_, cm_, true, true);
                    bool? co_ = context.Operators.In<CqlDateTime>(ce_, cn_, default);
                    CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cf_);
                    CqlDateTime cr_ = context.Operators.Start(cq_);
                    bool? cs_ = context.Operators.Not((bool?)(cr_ is null));
                    bool? ct_ = context.Operators.And(co_, cs_);

                    return ct_;
                };
                IEnumerable<Encounter> am_ = context.Operators.Where<Encounter>(ak_, al_);
                object an_(Encounter @this)
                {
                    Period cu_ = @this?.Period;
                    CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cu_);
                    CqlDateTime cw_ = context.Operators.End(cv_);

                    return cw_;
                };
                IEnumerable<Encounter> ao_ = context.Operators.SortBy<Encounter>(am_, an_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ap_ = context.Operators.Last<Encounter>(ao_);
                Period aq_ = ap_?.Period;
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aq_);
                CqlDateTime as_ = context.Operators.Start(ar_);
                Period at_ = Visit?.Period;
                CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, at_);
                CqlDateTime av_ = context.Operators.Start(au_);
                CqlQuantity aw_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ax_ = context.Operators.Subtract(as_ ?? av_, aw_);
                IEnumerable<Encounter> az_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? ba_(Encounter LastObs)
                {
                    Period cx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, cx_);
                    CqlDateTime cz_ = context.Operators.End(cy_);
                    Period da_ = Visit?.Period;
                    CqlInterval<CqlDateTime> db_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, da_);
                    CqlDateTime dc_ = context.Operators.Start(db_);
                    CqlQuantity dd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime de_ = context.Operators.Subtract(dc_, dd_);
                    CqlInterval<CqlDateTime> dg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, da_);
                    CqlDateTime dh_ = context.Operators.Start(dg_);
                    CqlInterval<CqlDateTime> di_ = context.Operators.Interval(de_, dh_, true, true);
                    bool? dj_ = context.Operators.In<CqlDateTime>(cz_, di_, default);
                    CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, da_);
                    CqlDateTime dm_ = context.Operators.Start(dl_);
                    bool? dn_ = context.Operators.Not((bool?)(dm_ is null));
                    bool? do_ = context.Operators.And(dj_, dn_);

                    return do_;
                };
                IEnumerable<Encounter> bb_ = context.Operators.Where<Encounter>(az_, ba_);
                object bc_(Encounter @this)
                {
                    Period dp_ = @this?.Period;
                    CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dp_);
                    CqlDateTime dr_ = context.Operators.End(dq_);

                    return dr_;
                };
                IEnumerable<Encounter> bd_ = context.Operators.SortBy<Encounter>(bb_, bc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter be_ = context.Operators.Last<Encounter>(bd_);
                Period bf_ = be_?.Period;
                CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, at_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(ax_, bh_ ?? bk_, true, true);
                bool? bm_ = context.Operators.In<CqlDateTime>(ai_, bl_, default);
                IEnumerable<Encounter> bo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? bp_(Encounter LastObs)
                {
                    Period ds_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dt_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ds_);
                    CqlDateTime du_ = context.Operators.End(dt_);
                    Period dv_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dv_);
                    CqlDateTime dx_ = context.Operators.Start(dw_);
                    CqlQuantity dy_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dz_ = context.Operators.Subtract(dx_, dy_);
                    CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dv_);
                    CqlDateTime ec_ = context.Operators.Start(eb_);
                    CqlInterval<CqlDateTime> ed_ = context.Operators.Interval(dz_, ec_, true, true);
                    bool? ee_ = context.Operators.In<CqlDateTime>(du_, ed_, default);
                    CqlInterval<CqlDateTime> eg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, dv_);
                    CqlDateTime eh_ = context.Operators.Start(eg_);
                    bool? ei_ = context.Operators.Not((bool?)(eh_ is null));
                    bool? ej_ = context.Operators.And(ee_, ei_);

                    return ej_;
                };
                IEnumerable<Encounter> bq_ = context.Operators.Where<Encounter>(bo_, bp_);
                object br_(Encounter @this)
                {
                    Period ek_ = @this?.Period;
                    CqlInterval<CqlDateTime> el_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ek_);
                    CqlDateTime em_ = context.Operators.End(el_);

                    return em_;
                };
                IEnumerable<Encounter> bs_ = context.Operators.SortBy<Encounter>(bq_, br_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bt_ = context.Operators.Last<Encounter>(bs_);
                Period bu_ = bt_?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);
                CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, at_);
                CqlDateTime bz_ = context.Operators.Start(by_);
                bool? ca_ = context.Operators.Not((bool?)((bw_ ?? bz_) is null));
                bool? cb_ = context.Operators.And(bm_, ca_);

                return cb_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            object j_(Encounter @this)
            {
                Period en_ = @this?.Period;
                CqlInterval<CqlDateTime> eo_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, en_);
                CqlDateTime ep_ = context.Operators.End(eo_);

                return ep_;
            };
            IEnumerable<Encounter> k_ = context.Operators.SortBy<Encounter>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter l_ = context.Operators.Last<Encounter>(k_);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlValueSet p_ = this.Observation_Services(context);
            IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            bool? r_(Encounter LastObs)
            {
                Period eq_ = LastObs?.Period;
                CqlInterval<CqlDateTime> er_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, eq_);
                CqlDateTime es_ = context.Operators.End(er_);
                Period et_ = Visit?.Period;
                CqlInterval<CqlDateTime> eu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, et_);
                CqlDateTime ev_ = context.Operators.Start(eu_);
                CqlQuantity ew_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ex_ = context.Operators.Subtract(ev_, ew_);
                CqlInterval<CqlDateTime> ez_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, et_);
                CqlDateTime fa_ = context.Operators.Start(ez_);
                CqlInterval<CqlDateTime> fb_ = context.Operators.Interval(ex_, fa_, true, true);
                bool? fc_ = context.Operators.In<CqlDateTime>(es_, fb_, default);
                CqlInterval<CqlDateTime> fe_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, et_);
                CqlDateTime ff_ = context.Operators.Start(fe_);
                bool? fg_ = context.Operators.Not((bool?)(ff_ is null));
                bool? fh_ = context.Operators.And(fc_, fg_);

                return fh_;
            };
            IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
            object t_(Encounter @this)
            {
                Period fi_ = @this?.Period;
                CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fi_);
                CqlDateTime fk_ = context.Operators.End(fj_);

                return fk_;
            };
            IEnumerable<Encounter> u_ = context.Operators.SortBy<Encounter>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter v_ = context.Operators.Last<Encounter>(u_);
            Period w_ = v_?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            Period z_ = Visit?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, z_);
            CqlDateTime ae_ = context.Operators.End(ad_);
            CqlInterval<CqlDateTime> af_ = context.Operators.Interval(o_ ?? y_ ?? ab_, ae_, true, true);

            return af_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

        return e_;
    }


    [CqlFunctionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime a_ = context.Operators.Start(Value);
        CqlDateTime b_ = context.Operators.End(Value);
        int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");

        return c_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet c_ = this.Medicare_payer(context);
        IEnumerable<Coverage> d_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        IEnumerable<ValueTuple<Encounter, Coverage>> e_ = context.Operators.CrossJoin<Encounter, Coverage>(b_, d_);
        (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? f_(ValueTuple<Encounter, Coverage> _valueTuple)
        {
            (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? m_ = (CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND, _valueTuple.Item1, _valueTuple.Item2);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> g_ = context.Operators.Select<ValueTuple<Encounter, Coverage>, (CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(e_, f_);
        bool? h_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend)
        {
            Code<Encounter.EncounterStatus> n_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.StatusElement;
            string o_ = FHIRHelpers_4_0_001.Instance.ToString(context, n_);
            bool? p_ = context.Operators.Equal(o_, "finished");
            CqlInterval<CqlDateTime> q_ = this.HospitalizationWithObservation(context, tuple_efskhgutuclexzenturvljend?.InpatientEncounter);
            int? r_ = this.LengthInDays(context, q_);
            bool? s_ = context.Operators.Less(r_, 365);
            bool? t_ = context.Operators.And(p_, s_);
            Period u_ = tuple_efskhgutuclexzenturvljend?.InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, u_);
            CqlDateTime w_ = context.Operators.End(v_);
            CqlInterval<CqlDateTime> x_ = this.Measurement_Period(context);
            bool? y_ = context.Operators.In<CqlDateTime>(w_, x_, "day");
            bool? z_ = context.Operators.And(t_, y_);
            Patient aa_ = this.Patient(context);
            Date ab_ = aa_?.BirthDateElement;
            string ac_ = ab_?.Value;
            CqlDate ad_ = context.Operators.ConvertStringToDate(ac_);
            CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, u_);
            CqlDateTime ag_ = context.Operators.Start(af_);
            CqlDate ah_ = context.Operators.DateFrom(ag_);
            int? ai_ = context.Operators.CalculateAgeAt(ad_, ah_, "year");
            bool? aj_ = context.Operators.GreaterOrEqual(ai_, 65);
            bool? ak_ = context.Operators.And(z_, aj_);

            return ak_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)? tuple_efskhgutuclexzenturvljend) =>
            tuple_efskhgutuclexzenturvljend?.InpatientEncounter;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientEncounter, Coverage Payer)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);

        return l_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);

        return a_;
    }


    [CqlFunctionDefinition("FirstPhysicalExamWithEncounterId")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterId(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        string b_(Encounter Encounter)
        {
            string e_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string f_ = context.Operators.Concatenate(e_ ?? "", ",");
            Id g_ = Encounter?.IdElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            string i_ = context.Operators.Concatenate(f_ ?? "", h_ ?? "");
            string j_ = context.Operators.Concatenate(i_ ?? "", ",");
            bool? k_(Observation Exam)
            {
                DataType ae_ = Exam?.Effective;
                CqlInterval<CqlDateTime> af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ae_);
                CqlDateTime ag_ = context.Operators.Start(af_);
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                CqlInterval<CqlDateTime> aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ae_);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                Period al_ = Encounter?.Period;
                CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, al_);
                CqlDateTime an_ = context.Operators.Start(am_);
                CqlQuantity ao_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ap_ = context.Operators.Subtract(an_, ao_);
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, al_);
                CqlDateTime as_ = context.Operators.Start(ar_);
                CqlQuantity at_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime au_ = context.Operators.Add(as_, at_);
                CqlInterval<CqlDateTime> av_ = context.Operators.Interval(ap_, au_, true, true);
                bool? aw_ = context.Operators.In<CqlDateTime>(ak_, av_, default);
                bool? ax_ = context.Operators.And(ah_, aw_);
                Code<ObservationStatus> ay_ = Exam?.StatusElement;
                string az_ = FHIRHelpers_4_0_001.Instance.ToString(context, ay_);
                string[] ba_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? bb_ = context.Operators.In<string>(az_, (IEnumerable<string>)ba_);
                bool? bc_ = context.Operators.And(ax_, bb_);
                DataType bd_ = Exam?.Value;
                bool? be_ = context.Operators.Not((bool?)(bd_ is null));
                bool? bf_ = context.Operators.And(bc_, be_);

                return bf_;
            };
            IEnumerable<Observation> l_ = context.Operators.Where<Observation>(ExamList, k_);
            object m_(Observation @this)
            {
                DataType bg_ = @this?.Effective;
                CqlInterval<CqlDateTime> bh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bg_);
                CqlDateTime bi_ = context.Operators.Start(bh_);

                return bi_;
            };
            IEnumerable<Observation> n_ = context.Operators.SortBy<Observation>(l_, m_, System.ComponentModel.ListSortDirection.Ascending);
            Observation o_ = context.Operators.First<Observation>(n_);
            DataType p_ = o_?.Value;
            CqlQuantity q_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, p_ as Quantity);
            string r_ = context.Operators.ConvertQuantityToString(q_);
            string s_ = context.Operators.Concatenate(j_ ?? "", r_ ?? "");
            string t_ = context.Operators.Concatenate(s_ ?? "", ",");
            bool? u_(Observation Exam)
            {
                DataType bj_ = Exam?.Effective;
                CqlInterval<CqlDateTime> bk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bj_);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                bool? bm_ = context.Operators.Not((bool?)(bl_ is null));
                CqlInterval<CqlDateTime> bo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bj_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                Period bq_ = Encounter?.Period;
                CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bq_);
                CqlDateTime bs_ = context.Operators.Start(br_);
                CqlQuantity bt_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bu_ = context.Operators.Subtract(bs_, bt_);
                CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bq_);
                CqlDateTime bx_ = context.Operators.Start(bw_);
                CqlQuantity by_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime bz_ = context.Operators.Add(bx_, by_);
                CqlInterval<CqlDateTime> ca_ = context.Operators.Interval(bu_, bz_, true, true);
                bool? cb_ = context.Operators.In<CqlDateTime>(bp_, ca_, default);
                bool? cc_ = context.Operators.And(bm_, cb_);
                Code<ObservationStatus> cd_ = Exam?.StatusElement;
                string ce_ = FHIRHelpers_4_0_001.Instance.ToString(context, cd_);
                string[] cf_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? cg_ = context.Operators.In<string>(ce_, (IEnumerable<string>)cf_);
                bool? ch_ = context.Operators.And(cc_, cg_);
                DataType ci_ = Exam?.Value;
                bool? cj_ = context.Operators.Not((bool?)(ci_ is null));
                bool? ck_ = context.Operators.And(ch_, cj_);

                return ck_;
            };
            IEnumerable<Observation> v_ = context.Operators.Where<Observation>(ExamList, u_);
            object w_(Observation @this)
            {
                DataType cl_ = @this?.Effective;
                CqlInterval<CqlDateTime> cm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, cl_);
                CqlDateTime cn_ = context.Operators.Start(cm_);

                return cn_;
            };
            IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
            Observation y_ = context.Operators.First<Observation>(x_);
            DataType z_ = y_?.Effective;
            CqlInterval<CqlDateTime> aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            string ac_ = context.Operators.ConvertDateTimeToString(ab_);
            string ad_ = context.Operators.Concatenate(t_ ?? "", ac_ ?? "");

            return ad_;
        };
        IEnumerable<string> c_ = context.Operators.Select<Encounter, string>(a_, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstPhysicalExamWithEncounterIdUsingLabTiming")]
    public IEnumerable<string> FirstPhysicalExamWithEncounterIdUsingLabTiming(CqlContext context, IEnumerable<Observation> ExamList, string CCDE)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        string b_(Encounter Encounter)
        {
            string e_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string f_ = context.Operators.Concatenate(e_ ?? "", ",");
            Id g_ = Encounter?.IdElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            string i_ = context.Operators.Concatenate(f_ ?? "", h_ ?? "");
            string j_ = context.Operators.Concatenate(i_ ?? "", ",");
            bool? k_(Observation Exam)
            {
                DataType ae_ = Exam?.Effective;
                CqlInterval<CqlDateTime> af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ae_);
                CqlDateTime ag_ = context.Operators.Start(af_);
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                CqlInterval<CqlDateTime> aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ae_);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                Period al_ = Encounter?.Period;
                CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, al_);
                CqlDateTime an_ = context.Operators.Start(am_);
                CqlQuantity ao_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ap_ = context.Operators.Subtract(an_, ao_);
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, al_);
                CqlDateTime as_ = context.Operators.Start(ar_);
                CqlDateTime au_ = context.Operators.Add(as_, ao_);
                CqlInterval<CqlDateTime> av_ = context.Operators.Interval(ap_, au_, true, true);
                bool? aw_ = context.Operators.In<CqlDateTime>(ak_, av_, default);
                bool? ax_ = context.Operators.And(ah_, aw_);
                Code<ObservationStatus> ay_ = Exam?.StatusElement;
                string az_ = FHIRHelpers_4_0_001.Instance.ToString(context, ay_);
                string[] ba_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? bb_ = context.Operators.In<string>(az_, (IEnumerable<string>)ba_);
                bool? bc_ = context.Operators.And(ax_, bb_);
                DataType bd_ = Exam?.Value;
                bool? be_ = context.Operators.Not((bool?)(bd_ is null));
                bool? bf_ = context.Operators.And(bc_, be_);

                return bf_;
            };
            IEnumerable<Observation> l_ = context.Operators.Where<Observation>(ExamList, k_);
            object m_(Observation @this)
            {
                DataType bg_ = @this?.Effective;
                CqlInterval<CqlDateTime> bh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bg_);
                CqlDateTime bi_ = context.Operators.Start(bh_);

                return bi_;
            };
            IEnumerable<Observation> n_ = context.Operators.SortBy<Observation>(l_, m_, System.ComponentModel.ListSortDirection.Ascending);
            Observation o_ = context.Operators.First<Observation>(n_);
            DataType p_ = o_?.Value;
            CqlQuantity q_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, p_ as Quantity);
            string r_ = context.Operators.ConvertQuantityToString(q_);
            string s_ = context.Operators.Concatenate(j_ ?? "", r_ ?? "");
            string t_ = context.Operators.Concatenate(s_ ?? "", ",");
            bool? u_(Observation Exam)
            {
                DataType bj_ = Exam?.Effective;
                CqlInterval<CqlDateTime> bk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bj_);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                bool? bm_ = context.Operators.Not((bool?)(bl_ is null));
                CqlInterval<CqlDateTime> bo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bj_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                Period bq_ = Encounter?.Period;
                CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bq_);
                CqlDateTime bs_ = context.Operators.Start(br_);
                CqlQuantity bt_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bu_ = context.Operators.Subtract(bs_, bt_);
                CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bq_);
                CqlDateTime bx_ = context.Operators.Start(bw_);
                CqlDateTime bz_ = context.Operators.Add(bx_, bt_);
                CqlInterval<CqlDateTime> ca_ = context.Operators.Interval(bu_, bz_, true, true);
                bool? cb_ = context.Operators.In<CqlDateTime>(bp_, ca_, default);
                bool? cc_ = context.Operators.And(bm_, cb_);
                Code<ObservationStatus> cd_ = Exam?.StatusElement;
                string ce_ = FHIRHelpers_4_0_001.Instance.ToString(context, cd_);
                string[] cf_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? cg_ = context.Operators.In<string>(ce_, (IEnumerable<string>)cf_);
                bool? ch_ = context.Operators.And(cc_, cg_);
                DataType ci_ = Exam?.Value;
                bool? cj_ = context.Operators.Not((bool?)(ci_ is null));
                bool? ck_ = context.Operators.And(ch_, cj_);

                return ck_;
            };
            IEnumerable<Observation> v_ = context.Operators.Where<Observation>(ExamList, u_);
            object w_(Observation @this)
            {
                DataType cl_ = @this?.Effective;
                CqlInterval<CqlDateTime> cm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, cl_);
                CqlDateTime cn_ = context.Operators.Start(cm_);

                return cn_;
            };
            IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
            Observation y_ = context.Operators.First<Observation>(x_);
            DataType z_ = y_?.Effective;
            CqlInterval<CqlDateTime> aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            string ac_ = context.Operators.ConvertDateTimeToString(ab_);
            string ad_ = context.Operators.Concatenate(t_ ?? "", ac_ ?? "");

            return ad_;
        };
        IEnumerable<string> c_ = context.Operators.Select<Encounter, string>(a_, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);

        return d_;
    }


    [CqlFunctionDefinition("FirstLabTestWithEncounterId")]
    public IEnumerable<string> FirstLabTestWithEncounterId(CqlContext context, IEnumerable<Observation> LabList, string CCDE)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounters(context);
        string b_(Encounter Encounter)
        {
            string e_ = context.Operators.Concatenate("\r\n", CCDE ?? "");
            string f_ = context.Operators.Concatenate(e_ ?? "", ",");
            Id g_ = Encounter?.IdElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            string i_ = context.Operators.Concatenate(f_ ?? "", h_ ?? "");
            string j_ = context.Operators.Concatenate(i_ ?? "", ",");
            bool? k_(Observation Lab)
            {
                Instant ad_ = Lab?.IssuedElement;
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                CqlDateTime ag_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ad_);
                Period ah_ = Encounter?.Period;
                CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.Start(ai_);
                CqlQuantity ak_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime al_ = context.Operators.Subtract(aj_, ak_);
                CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ah_);
                CqlDateTime ao_ = context.Operators.Start(an_);
                CqlDateTime aq_ = context.Operators.Add(ao_, ak_);
                CqlInterval<CqlDateTime> ar_ = context.Operators.Interval(al_, aq_, true, true);
                bool? as_ = context.Operators.In<CqlDateTime>(ag_, ar_, default);
                bool? at_ = context.Operators.And(ae_, as_);
                Code<ObservationStatus> au_ = Lab?.StatusElement;
                string av_ = FHIRHelpers_4_0_001.Instance.ToString(context, au_);
                string[] aw_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? ax_ = context.Operators.In<string>(av_, (IEnumerable<string>)aw_);
                bool? ay_ = context.Operators.And(at_, ax_);
                DataType az_ = Lab?.Value;
                bool? ba_ = context.Operators.Not((bool?)(az_ is null));
                bool? bb_ = context.Operators.And(ay_, ba_);

                return bb_;
            };
            IEnumerable<Observation> l_ = context.Operators.Where<Observation>(LabList, k_);
            object m_(Observation @this)
            {
                Instant bc_ = @this?.IssuedElement;

                return bc_;
            };
            IEnumerable<Observation> n_ = context.Operators.SortBy<Observation>(l_, m_, System.ComponentModel.ListSortDirection.Ascending);
            Observation o_ = context.Operators.First<Observation>(n_);
            DataType p_ = o_?.Value;
            CqlQuantity q_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, p_ as Quantity);
            string r_ = context.Operators.ConvertQuantityToString(q_);
            string s_ = context.Operators.Concatenate(j_ ?? "", r_ ?? "");
            string t_ = context.Operators.Concatenate(s_ ?? "", ",");
            bool? u_(Observation Lab)
            {
                Instant bd_ = Lab?.IssuedElement;
                bool? be_ = context.Operators.Not((bool?)(bd_ is null));
                CqlDateTime bg_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bd_);
                Period bh_ = Encounter?.Period;
                CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bh_);
                CqlDateTime bj_ = context.Operators.Start(bi_);
                CqlQuantity bk_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bl_ = context.Operators.Subtract(bj_, bk_);
                CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bh_);
                CqlDateTime bo_ = context.Operators.Start(bn_);
                CqlDateTime bq_ = context.Operators.Add(bo_, bk_);
                CqlInterval<CqlDateTime> br_ = context.Operators.Interval(bl_, bq_, true, true);
                bool? bs_ = context.Operators.In<CqlDateTime>(bg_, br_, default);
                bool? bt_ = context.Operators.And(be_, bs_);
                Code<ObservationStatus> bu_ = Lab?.StatusElement;
                string bv_ = FHIRHelpers_4_0_001.Instance.ToString(context, bu_);
                string[] bw_ = [
                    "final",
                    "amended",
                    "preliminary",
                ];
                bool? bx_ = context.Operators.In<string>(bv_, (IEnumerable<string>)bw_);
                bool? by_ = context.Operators.And(bt_, bx_);
                DataType bz_ = Lab?.Value;
                bool? ca_ = context.Operators.Not((bool?)(bz_ is null));
                bool? cb_ = context.Operators.And(by_, ca_);

                return cb_;
            };
            IEnumerable<Observation> v_ = context.Operators.Where<Observation>(LabList, u_);
            object w_(Observation @this)
            {
                Instant cc_ = @this?.IssuedElement;

                return cc_;
            };
            IEnumerable<Observation> x_ = context.Operators.SortBy<Observation>(v_, w_, System.ComponentModel.ListSortDirection.Ascending);
            Observation y_ = context.Operators.First<Observation>(x_);
            Instant z_ = y_?.IssuedElement;
            CqlDateTime aa_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, z_);
            string ab_ = context.Operators.ConvertDateTimeToString(aa_);
            string ac_ = context.Operators.Concatenate(t_ ?? "", ab_ ?? "");

            return ac_;
        };
        IEnumerable<string> c_ = context.Operators.Select<Encounter, string>(a_, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Results")]
    public IEnumerable<string> Results(CqlContext context)
    {
        CqlCode a_ = this.Heart_rate(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> d_ = this.FirstPhysicalExamWithEncounterId(context, c_, "FirstHeartRate");
        CqlCode e_ = this.Systolic_blood_pressure(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> h_ = this.FirstPhysicalExamWithEncounterId(context, g_, "FirstSystolicBP");
        CqlCode i_ = this.Respiratory_rate(context);
        IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
        IEnumerable<Observation> k_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> l_ = this.FirstPhysicalExamWithEncounterId(context, k_, "FirstRespRate");
        CqlValueSet m_ = this.Body_temperature(context);
        IEnumerable<Observation> n_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> o_ = this.FirstPhysicalExamWithEncounterId(context, n_, "FirstTemperature");
        CqlCode p_ = this.Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(context);
        IEnumerable<CqlCode> q_ = context.Operators.ToList<CqlCode>(p_);
        IEnumerable<Observation> r_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, q_, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> s_ = this.FirstPhysicalExamWithEncounterId(context, r_, "FirstO2Saturation");
        CqlValueSet t_ = this.Body_weight(context);
        IEnumerable<Observation> u_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> v_ = this.FirstPhysicalExamWithEncounterIdUsingLabTiming(context, u_, "FirstWeight");
        CqlValueSet w_ = this.Hematocrit_lab_test(context);
        IEnumerable<Observation> x_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> y_ = this.FirstLabTestWithEncounterId(context, x_, "FirstHematocrit");
        CqlValueSet z_ = this.White_blood_cells_count_lab_test(context);
        IEnumerable<Observation> aa_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ab_ = this.FirstLabTestWithEncounterId(context, aa_, "FirstWhiteBloodCell");
        CqlValueSet ac_ = this.Potassium_lab_test(context);
        IEnumerable<Observation> ad_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ac_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ae_ = this.FirstLabTestWithEncounterId(context, ad_, "FirstPotassium");
        CqlValueSet af_ = this.Sodium_lab_test(context);
        IEnumerable<Observation> ag_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ah_ = this.FirstLabTestWithEncounterId(context, ag_, "FirstSodium");
        CqlValueSet ai_ = this.Bicarbonate_lab_test(context);
        IEnumerable<Observation> aj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> ak_ = this.FirstLabTestWithEncounterId(context, aj_, "FirstBicarbonate");
        CqlValueSet al_ = this.Creatinine_lab_test(context);
        IEnumerable<Observation> am_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> an_ = this.FirstLabTestWithEncounterId(context, am_, "FirstCreatinine");
        CqlValueSet ao_ = this.Glucose_lab_test(context);
        IEnumerable<Observation> ap_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ao_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        IEnumerable<string> aq_ = this.FirstLabTestWithEncounterId(context, ap_, "FirstGlucose");
        IEnumerable<string>[] ar_ = [
            d_,
            h_,
            l_,
            o_,
            s_,
            v_,
            y_,
            ab_,
            ae_,
            ah_,
            ak_,
            an_,
            aq_,
        ];
        IEnumerable<string> as_ = context.Operators.Flatten<string>((IEnumerable<IEnumerable<string>>)ar_);

        return as_;
    }


    [CqlFunctionDefinition("CalendarAgeInYearsAt")]
    public int? CalendarAgeInYearsAt(CqlContext context, CqlDateTime BirthDateTime, CqlDateTime AsOf)
    {
        CqlDateTime a_ = this.ToDate(context, BirthDateTime);
        CqlDateTime b_ = this.ToDate(context, AsOf);
        int? c_ = context.Operators.DurationBetween(a_, b_, "year");

        return c_;
    }


    [CqlFunctionDefinition("ToDate")]
    public CqlDateTime ToDate(CqlContext context, CqlDateTime Value)
    {
        int? a_ = context.Operators.DateTimeComponentFrom(Value, "year");
        int? b_ = context.Operators.DateTimeComponentFrom(Value, "month");
        int? c_ = context.Operators.DateTimeComponentFrom(Value, "day");
        decimal? d_ = context.Operators.TimezoneOffsetFrom(Value);
        CqlDateTime e_ = context.Operators.DateTime(a_, b_, c_, 0, 0, 0, 0, d_);

        return e_;
    }


    [CqlFunctionDefinition("LengthOfStay")]
    public int? LengthOfStay(CqlContext context, CqlInterval<CqlDateTime> Stay)
    {
        CqlDateTime a_ = context.Operators.Start(Stay);
        CqlDateTime b_ = context.Operators.End(Stay);
        int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");

        return c_;
    }


    [CqlFunctionDefinition("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> a_ = this.HospitalizationWithObservation(context, Encounter);
        int? b_ = this.LengthInDays(context, a_);

        return b_;
    }


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EFSKhGUTUCLEXZENTURVLjeND = new(
      [typeof(Encounter), typeof(Coverage)],
      ["InpatientEncounter", "Payer"]);

    #endregion CqlTupleMetadata Properties

}

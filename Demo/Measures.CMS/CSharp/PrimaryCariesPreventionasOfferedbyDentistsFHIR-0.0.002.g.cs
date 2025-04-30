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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("PrimaryCariesPreventionasOfferedbyDentistsFHIR", "0.0.002")]
public partial class PrimaryCariesPreventionasOfferedbyDentistsFHIR_0_0_002 : ILibrary, ISingleton<PrimaryCariesPreventionasOfferedbyDentistsFHIR_0_0_002>
{
    private PrimaryCariesPreventionasOfferedbyDentistsFHIR_0_0_002() {}

    public static PrimaryCariesPreventionasOfferedbyDentistsFHIR_0_0_002 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "PrimaryCariesPreventionasOfferedbyDentistsFHIR";
    public string Version => "0.0.002";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Clinical Oral Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", valueSetVersion: null)]
    public CqlValueSet Clinical_Oral_Evaluation(CqlContext _) => _Clinical_Oral_Evaluation;
    private static readonly CqlValueSet _Clinical_Oral_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hosice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hosice_Care(CqlContext _) => _Discharged_to_Home_for_Hosice_Care;
    private static readonly CqlValueSet _Discharged_to_Home_for_Hosice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Fluoride Varnish Application for Children", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", valueSetVersion: null)]
    public CqlValueSet Fluoride_Varnish_Application_for_Children(CqlContext _) => _Fluoride_Varnish_Application_for_Children;
    private static readonly CqlValueSet _Fluoride_Varnish_Application_for_Children = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime fzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzza_, true, true);
        object fzzzzzzzzzzzzzzzzzzzzc_ = context.ResolveParameter("PrimaryCariesPreventionasOfferedbyDentistsFHIR-0.0.002", "Measurement Period", fzzzzzzzzzzzzzzzzzzzzb_);

        return (CqlInterval<CqlDateTime>)fzzzzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient fzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Patient>(fzzzzzzzzzzzzzzzzzzzzd_);

        return fzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzf_ = this.Clinical_Oral_Evaluation(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isEncounterPerformed(context, fzzzzzzzzzzzzzzzzzzzzg_);
        bool? fzzzzzzzzzzzzzzzzzzzzi_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            Period fzzzzzzzzzzzzzzzzzzzzl_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzl_);
            bool? fzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzm_, "day");

            return fzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzi_);

        return fzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient fzzzzzzzzzzzzzzzzzzzzo_ = this.Patient(context);
        Date fzzzzzzzzzzzzzzzzzzzzp_ = fzzzzzzzzzzzzzzzzzzzzo_?.BirthDateElement;
        string fzzzzzzzzzzzzzzzzzzzzq_ = fzzzzzzzzzzzzzzzzzzzzp_?.Value;
        CqlDate fzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzzzzzzzzzzq_);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
        CqlDateTime fzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate fzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzt_);
        int? fzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzu_, "year");
        CqlInterval<int?> fzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(1, 20, true, true);
        bool? fzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<int?>(fzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzw_, default);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzy_ = this.Qualifying_Encounters(context);
        bool? fzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzzzzzzzzy_);
        bool? gzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzz_);

        return gzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzzzzzzzzb_ = this.Initial_Population(context);

        return gzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzzzzzzzzc_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return gzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzd_ = this.Fluoride_Varnish_Application_for_Children(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isProcedurePerformed(context, gzzzzzzzzzzzzzzzzzzzze_);
        bool? gzzzzzzzzzzzzzzzzzzzzg_(Procedure FluorideApplication)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzn_ = FluorideApplication?.Performed;
            object gzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            bool? gzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzr_, "day");

            return gzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzzg_);
        CqlDate gzzzzzzzzzzzzzzzzzzzzi_(Procedure FluorideApplication)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzt_ = FluorideApplication?.Performed;
            object gzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzw_);

            return gzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Procedure, CqlDate>(gzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDate>(gzzzzzzzzzzzzzzzzzzzzj_);
        int? gzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Count<CqlDate>(gzzzzzzzzzzzzzzzzzzzzk_);
        bool? gzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzzzzzzzl_, 2);

        return gzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient gzzzzzzzzzzzzzzzzzzzzy_ = this.Patient(context);
        Date gzzzzzzzzzzzzzzzzzzzzz_ = gzzzzzzzzzzzzzzzzzzzzy_?.BirthDateElement;
        string hzzzzzzzzzzzzzzzzzzzza_ = gzzzzzzzzzzzzzzzzzzzzz_?.Value;
        CqlDate hzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzzzzzzzzzza_);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzc_);
        CqlDate hzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzd_);
        int? hzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzze_, "year");
        CqlInterval<int?> hzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(1, 5, true, true);
        bool? hzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<int?>(hzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzg_, default);

        return hzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient hzzzzzzzzzzzzzzzzzzzzi_ = this.Patient(context);
        Date hzzzzzzzzzzzzzzzzzzzzj_ = hzzzzzzzzzzzzzzzzzzzzi_?.BirthDateElement;
        string hzzzzzzzzzzzzzzzzzzzzk_ = hzzzzzzzzzzzzzzzzzzzzj_?.Value;
        CqlDate hzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzzzzzzzzzzk_);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzm_);
        CqlDate hzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzn_);
        int? hzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzo_, "year");
        CqlInterval<int?> hzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(6, 12, true, true);
        bool? hzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<int?>(hzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzq_, default);

        return hzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public bool? Stratification_3(CqlContext context)
    {
        Patient hzzzzzzzzzzzzzzzzzzzzs_ = this.Patient(context);
        Date hzzzzzzzzzzzzzzzzzzzzt_ = hzzzzzzzzzzzzzzzzzzzzs_?.BirthDateElement;
        string hzzzzzzzzzzzzzzzzzzzzu_ = hzzzzzzzzzzzzzzzzzzzzt_?.Value;
        CqlDate hzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzzzzzzzzzzu_);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzw_);
        CqlDate hzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzx_);
        int? hzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzy_, "year");
        CqlInterval<int?> izzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(13, 20, true, true);
        bool? izzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<int?>(hzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzza_, default);

        return izzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Expressions

}

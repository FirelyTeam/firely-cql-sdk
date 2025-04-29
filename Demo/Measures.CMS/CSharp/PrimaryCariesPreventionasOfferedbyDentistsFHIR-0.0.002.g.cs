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
        CqlDateTime lzzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime lzzzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzza_ = context.Operators.Interval(lzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzz_, true, true);
        object mzzzzzzzzzzzzzb_ = context.ResolveParameter("PrimaryCariesPreventionasOfferedbyDentistsFHIR-0.0.002", "Measurement Period", mzzzzzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzzzc_);

        return mzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzze_ = this.Clinical_Oral_Evaluation(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isEncounterPerformed(context, mzzzzzzzzzzzzzf_);
        bool? mzzzzzzzzzzzzzh_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            Period mzzzzzzzzzzzzzk_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzk_);
            bool? mzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzl_, "day");

            return mzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzh_);

        return mzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient mzzzzzzzzzzzzzn_ = this.Patient(context);
        Date mzzzzzzzzzzzzzo_ = mzzzzzzzzzzzzzn_?.BirthDateElement;
        string mzzzzzzzzzzzzzp_ = mzzzzzzzzzzzzzo_?.Value;
        CqlDate mzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(mzzzzzzzzzzzzzp_);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
        CqlDateTime mzzzzzzzzzzzzzs_ = context.Operators.Start(mzzzzzzzzzzzzzr_);
        CqlDate mzzzzzzzzzzzzzt_ = context.Operators.DateFrom(mzzzzzzzzzzzzzs_);
        int? mzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzt_, "year");
        CqlInterval<int?> mzzzzzzzzzzzzzv_ = context.Operators.Interval(1, 20, true, true);
        bool? mzzzzzzzzzzzzzw_ = context.Operators.In<int?>(mzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzv_, default);
        IEnumerable<Encounter> mzzzzzzzzzzzzzx_ = this.Qualifying_Encounters(context);
        bool? mzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzzzx_);
        bool? mzzzzzzzzzzzzzz_ = context.Operators.And(mzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzy_);

        return mzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? nzzzzzzzzzzzzza_ = this.Initial_Population(context);

        return nzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzb_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return nzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzc_ = this.Fluoride_Varnish_Application_for_Children(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> nzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isProcedurePerformed(context, nzzzzzzzzzzzzzd_);
        bool? nzzzzzzzzzzzzzf_(Procedure FluorideApplication)
        {
            DataType nzzzzzzzzzzzzzm_ = FluorideApplication?.Performed;
            object nzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzn_);
            CqlDateTime nzzzzzzzzzzzzzp_ = context.Operators.End(nzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzq_, "day");

            return nzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> nzzzzzzzzzzzzzg_ = context.Operators.Where<Procedure>(nzzzzzzzzzzzzze_, nzzzzzzzzzzzzzf_);
        CqlDate nzzzzzzzzzzzzzh_(Procedure FluorideApplication)
        {
            DataType nzzzzzzzzzzzzzs_ = FluorideApplication?.Performed;
            object nzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzt_);
            CqlDateTime nzzzzzzzzzzzzzv_ = context.Operators.End(nzzzzzzzzzzzzzu_);
            CqlDate nzzzzzzzzzzzzzw_ = context.Operators.DateFrom(nzzzzzzzzzzzzzv_);

            return nzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDate> nzzzzzzzzzzzzzi_ = context.Operators.Select<Procedure, CqlDate>(nzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzh_);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlDate>(nzzzzzzzzzzzzzi_);
        int? nzzzzzzzzzzzzzk_ = context.Operators.Count<CqlDate>(nzzzzzzzzzzzzzj_);
        bool? nzzzzzzzzzzzzzl_ = context.Operators.GreaterOrEqual(nzzzzzzzzzzzzzk_, 2);

        return nzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context)
    {
        Patient nzzzzzzzzzzzzzx_ = this.Patient(context);
        Date nzzzzzzzzzzzzzy_ = nzzzzzzzzzzzzzx_?.BirthDateElement;
        string nzzzzzzzzzzzzzz_ = nzzzzzzzzzzzzzy_?.Value;
        CqlDate ozzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzz_);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzb_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzzzzzzzzzc_ = context.Operators.Start(ozzzzzzzzzzzzzb_);
        CqlDate ozzzzzzzzzzzzzd_ = context.Operators.DateFrom(ozzzzzzzzzzzzzc_);
        int? ozzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzza_, ozzzzzzzzzzzzzd_, "year");
        CqlInterval<int?> ozzzzzzzzzzzzzf_ = context.Operators.Interval(1, 5, true, true);
        bool? ozzzzzzzzzzzzzg_ = context.Operators.In<int?>(ozzzzzzzzzzzzze_, ozzzzzzzzzzzzzf_, default);

        return ozzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context)
    {
        Patient ozzzzzzzzzzzzzh_ = this.Patient(context);
        Date ozzzzzzzzzzzzzi_ = ozzzzzzzzzzzzzh_?.BirthDateElement;
        string ozzzzzzzzzzzzzj_ = ozzzzzzzzzzzzzi_?.Value;
        CqlDate ozzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzzzzj_);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzl_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzzzzzzzzzm_ = context.Operators.Start(ozzzzzzzzzzzzzl_);
        CqlDate ozzzzzzzzzzzzzn_ = context.Operators.DateFrom(ozzzzzzzzzzzzzm_);
        int? ozzzzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzk_, ozzzzzzzzzzzzzn_, "year");
        CqlInterval<int?> ozzzzzzzzzzzzzp_ = context.Operators.Interval(6, 12, true, true);
        bool? ozzzzzzzzzzzzzq_ = context.Operators.In<int?>(ozzzzzzzzzzzzzo_, ozzzzzzzzzzzzzp_, default);

        return ozzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Stratification 3")]
    public bool? Stratification_3(CqlContext context)
    {
        Patient ozzzzzzzzzzzzzr_ = this.Patient(context);
        Date ozzzzzzzzzzzzzs_ = ozzzzzzzzzzzzzr_?.BirthDateElement;
        string ozzzzzzzzzzzzzt_ = ozzzzzzzzzzzzzs_?.Value;
        CqlDate ozzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzzzzt_);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzzzzzzzzzw_ = context.Operators.Start(ozzzzzzzzzzzzzv_);
        CqlDate ozzzzzzzzzzzzzx_ = context.Operators.DateFrom(ozzzzzzzzzzzzzw_);
        int? ozzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzu_, ozzzzzzzzzzzzzx_, "year");
        CqlInterval<int?> ozzzzzzzzzzzzzz_ = context.Operators.Interval(13, 20, true, true);
        bool? pzzzzzzzzzzzzza_ = context.Operators.In<int?>(ozzzzzzzzzzzzzy_, ozzzzzzzzzzzzzz_, default);

        return pzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return pzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> pzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return pzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return pzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return pzzzzzzzzzzzzze_;
    }


    #endregion Expressions

}

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
[CqlLibrary("VTEFHIR4", "4.8.000")]
public partial class VTEFHIR4_4_8_000 : ILibrary, ISingleton<VTEFHIR4_4_8_000>
{
    private VTEFHIR4_4_8_000() {}

    public static VTEFHIR4_4_8_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "VTEFHIR4";
    public string Version => "4.8.000";
    public ILibrary[] Dependencies => [MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Intensive Care Unit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", valueSetVersion: null)]
    public CqlValueSet Intensive_Care_Unit(CqlContext _) => _Intensive_Care_Unit;
    private static readonly CqlValueSet _Intensive_Care_Unit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ezzzzzzzm_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime ezzzzzzzn_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> ezzzzzzzo_ = context.Operators.Interval(ezzzzzzzm_, ezzzzzzzn_, true, false);
        object ezzzzzzzp_ = context.ResolveParameter("VTEFHIR4-4.8.000", "Measurement Period", ezzzzzzzo_);

        return (CqlInterval<CqlDateTime>)ezzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient ezzzzzzzr_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzq_);

        return ezzzzzzzr_;
    }


    [CqlExpressionDefinition("FirstInpatientIntensiveCareUnit")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> ezzzzzzzs_ = Encounter?.Location;
        bool? ezzzzzzzt_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference ezzzzzzzy_ = HospitalLocation?.Location;
            Location ezzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetLocation(context, ezzzzzzzy_);
            List<CodeableConcept> fzzzzzzza_ = ezzzzzzzz_?.Type;
            CqlConcept fzzzzzzzb_(CodeableConcept X)
            {
                CqlConcept fzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return fzzzzzzzl_;
            };
            IEnumerable<CqlConcept> fzzzzzzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)fzzzzzzza_, fzzzzzzzb_);
            CqlValueSet fzzzzzzzd_ = this.Intensive_Care_Unit(context);
            bool? fzzzzzzze_ = context.Operators.ConceptsInValueSet(fzzzzzzzc_, fzzzzzzzd_);
            Period fzzzzzzzf_ = Encounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzf_);
            Period fzzzzzzzh_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzh_);
            bool? fzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzg_, fzzzzzzzi_, default);
            bool? fzzzzzzzk_ = context.Operators.And(fzzzzzzze_, fzzzzzzzj_);

            return fzzzzzzzk_;
        };
        IEnumerable<Encounter.LocationComponent> ezzzzzzzu_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)ezzzzzzzs_, ezzzzzzzt_);
        object ezzzzzzzv_(Encounter.LocationComponent @this)
        {
            Period fzzzzzzzm_ = @this?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzm_);
            CqlDateTime fzzzzzzzo_ = context.Operators.Start(fzzzzzzzn_);

            return fzzzzzzzo_;
        };
        IEnumerable<Encounter.LocationComponent> ezzzzzzzw_ = context.Operators.SortBy<Encounter.LocationComponent>(ezzzzzzzu_, ezzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent ezzzzzzzx_ = context.Operators.First<Encounter.LocationComponent>(ezzzzzzzw_);

        return ezzzzzzzx_;
    }


    [CqlExpressionDefinition("FirstICULocationPeriod")]
    public Period FirstICULocationPeriod(CqlContext context, Encounter Encounter)
    {
        Encounter.LocationComponent fzzzzzzzp_ = this.FirstInpatientIntensiveCareUnit(context, Encounter);
        Period fzzzzzzzq_ = fzzzzzzzp_?.Period;

        return fzzzzzzzq_;
    }


    [CqlExpressionDefinition("StartOfFirstICU")]
    public CqlDateTime StartOfFirstICU(CqlContext context, Encounter Encounter)
    {
        Period fzzzzzzzr_ = this.FirstICULocationPeriod(context, Encounter);
        CqlInterval<CqlDateTime> fzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzr_);
        CqlDateTime fzzzzzzzt_ = context.Operators.Start(fzzzzzzzs_);

        return fzzzzzzzt_;
    }


    [CqlExpressionDefinition("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate fzzzzzzzu_ = context.Operators.DateFrom(StartValue);
        CqlQuantity fzzzzzzzw_ = context.Operators.Quantity(1m, "day");
        CqlDate fzzzzzzzx_ = context.Operators.Add(fzzzzzzzu_, fzzzzzzzw_);
        CqlInterval<CqlDate> fzzzzzzzy_ = context.Operators.Interval(fzzzzzzzu_, fzzzzzzzx_, true, true);

        return fzzzzzzzy_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> fzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, Encounter);
        CqlDateTime gzzzzzzza_ = context.Operators.Start(fzzzzzzzz_);
        CqlDate gzzzzzzzb_ = context.Operators.DateFrom(gzzzzzzza_);
        Period gzzzzzzzc_ = Encounter?.Period;
        CqlInterval<CqlDateTime> gzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, gzzzzzzzc_);
        CqlDateTime gzzzzzzze_ = context.Operators.Start(gzzzzzzzd_);
        CqlDate gzzzzzzzf_ = context.Operators.DateFrom(gzzzzzzze_);
        CqlQuantity gzzzzzzzg_ = context.Operators.Quantity(1m, "day");
        CqlDate gzzzzzzzh_ = context.Operators.Add(gzzzzzzzf_, gzzzzzzzg_);
        CqlInterval<CqlDate> gzzzzzzzi_ = context.Operators.Interval(gzzzzzzzb_, gzzzzzzzh_, true, true);

        return gzzzzzzzi_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> gzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, Encounter);
        CqlDateTime gzzzzzzzk_ = context.Operators.Start(gzzzzzzzj_);
        CqlDate gzzzzzzzl_ = context.Operators.DateFrom(gzzzzzzzk_);
        CqlDateTime gzzzzzzzm_ = this.StartOfFirstICU(context, Encounter);
        CqlDate gzzzzzzzn_ = context.Operators.DateFrom(gzzzzzzzm_);
        CqlQuantity gzzzzzzzo_ = context.Operators.Quantity(1m, "day");
        CqlDate gzzzzzzzp_ = context.Operators.Add(gzzzzzzzn_, gzzzzzzzo_);
        CqlInterval<CqlDate> gzzzzzzzq_ = context.Operators.Interval(gzzzzzzzl_, gzzzzzzzp_, true, true);

        return gzzzzzzzq_;
    }


    #endregion Expressions

}

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
        CqlDateTime gzzzzzzo_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime gzzzzzzp_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> gzzzzzzq_ = context.Operators.Interval(gzzzzzzo_, gzzzzzzp_, true, false);
        object gzzzzzzr_ = context.ResolveParameter("VTEFHIR4-4.8.000", "Measurement Period", gzzzzzzq_);

        return (CqlInterval<CqlDateTime>)gzzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> gzzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient gzzzzzzt_ = context.Operators.SingletonFrom<Patient>(gzzzzzzs_);

        return gzzzzzzt_;
    }


    [CqlExpressionDefinition("FirstInpatientIntensiveCareUnit")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> gzzzzzzu_ = Encounter?.Location;
        bool? gzzzzzzv_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference hzzzzzza_ = HospitalLocation?.Location;
            Location hzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetLocation(context, hzzzzzza_);
            List<CodeableConcept> hzzzzzzc_ = hzzzzzzb_?.Type;
            CqlConcept hzzzzzzd_(CodeableConcept X)
            {
                CqlConcept hzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return hzzzzzzn_;
            };
            IEnumerable<CqlConcept> hzzzzzze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)hzzzzzzc_, hzzzzzzd_);
            CqlValueSet hzzzzzzf_ = this.Intensive_Care_Unit(context);
            bool? hzzzzzzg_ = context.Operators.ConceptsInValueSet(hzzzzzze_, hzzzzzzf_);
            Period hzzzzzzh_ = Encounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzh_);
            Period hzzzzzzj_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> hzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzj_);
            bool? hzzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzzi_, hzzzzzzk_, default);
            bool? hzzzzzzm_ = context.Operators.And(hzzzzzzg_, hzzzzzzl_);

            return hzzzzzzm_;
        };
        IEnumerable<Encounter.LocationComponent> gzzzzzzw_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)gzzzzzzu_, gzzzzzzv_);
        object gzzzzzzx_(Encounter.LocationComponent @this)
        {
            Period hzzzzzzo_ = @this?.Period;
            CqlInterval<CqlDateTime> hzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzo_);
            CqlDateTime hzzzzzzq_ = context.Operators.Start(hzzzzzzp_);

            return hzzzzzzq_;
        };
        IEnumerable<Encounter.LocationComponent> gzzzzzzy_ = context.Operators.SortBy<Encounter.LocationComponent>(gzzzzzzw_, gzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent gzzzzzzz_ = context.Operators.First<Encounter.LocationComponent>(gzzzzzzy_);

        return gzzzzzzz_;
    }


    [CqlExpressionDefinition("FirstICULocationPeriod")]
    public Period FirstICULocationPeriod(CqlContext context, Encounter Encounter)
    {
        Encounter.LocationComponent hzzzzzzr_ = this.FirstInpatientIntensiveCareUnit(context, Encounter);
        Period hzzzzzzs_ = hzzzzzzr_?.Period;

        return hzzzzzzs_;
    }


    [CqlExpressionDefinition("StartOfFirstICU")]
    public CqlDateTime StartOfFirstICU(CqlContext context, Encounter Encounter)
    {
        Period hzzzzzzt_ = this.FirstICULocationPeriod(context, Encounter);
        CqlInterval<CqlDateTime> hzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, hzzzzzzt_);
        CqlDateTime hzzzzzzv_ = context.Operators.Start(hzzzzzzu_);

        return hzzzzzzv_;
    }


    [CqlExpressionDefinition("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate hzzzzzzw_ = context.Operators.DateFrom(StartValue);
        CqlQuantity hzzzzzzy_ = context.Operators.Quantity(1m, "day");
        CqlDate hzzzzzzz_ = context.Operators.Add(hzzzzzzw_, hzzzzzzy_);
        CqlInterval<CqlDate> izzzzzza_ = context.Operators.Interval(hzzzzzzw_, hzzzzzzz_, true, true);

        return izzzzzza_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> izzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, Encounter);
        CqlDateTime izzzzzzc_ = context.Operators.Start(izzzzzzb_);
        CqlDate izzzzzzd_ = context.Operators.DateFrom(izzzzzzc_);
        Period izzzzzze_ = Encounter?.Period;
        CqlInterval<CqlDateTime> izzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, izzzzzze_);
        CqlDateTime izzzzzzg_ = context.Operators.Start(izzzzzzf_);
        CqlDate izzzzzzh_ = context.Operators.DateFrom(izzzzzzg_);
        CqlQuantity izzzzzzi_ = context.Operators.Quantity(1m, "day");
        CqlDate izzzzzzj_ = context.Operators.Add(izzzzzzh_, izzzzzzi_);
        CqlInterval<CqlDate> izzzzzzk_ = context.Operators.Interval(izzzzzzd_, izzzzzzj_, true, true);

        return izzzzzzk_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> izzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, Encounter);
        CqlDateTime izzzzzzm_ = context.Operators.Start(izzzzzzl_);
        CqlDate izzzzzzn_ = context.Operators.DateFrom(izzzzzzm_);
        CqlDateTime izzzzzzo_ = this.StartOfFirstICU(context, Encounter);
        CqlDate izzzzzzp_ = context.Operators.DateFrom(izzzzzzo_);
        CqlQuantity izzzzzzq_ = context.Operators.Quantity(1m, "day");
        CqlDate izzzzzzr_ = context.Operators.Add(izzzzzzp_, izzzzzzq_);
        CqlInterval<CqlDate> izzzzzzs_ = context.Operators.Interval(izzzzzzn_, izzzzzzr_, true, true);

        return izzzzzzs_;
    }


    #endregion Expressions

}

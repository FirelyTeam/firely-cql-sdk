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
        CqlDateTime kzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime kzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzf_, true, false);
        object kzzzzzzzzzzzzzzzzzh_ = context.ResolveParameter("VTEFHIR4-4.8.000", "Measurement Period", kzzzzzzzzzzzzzzzzzg_);

        return (CqlInterval<CqlDateTime>)kzzzzzzzzzzzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> kzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient kzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(kzzzzzzzzzzzzzzzzzi_);

        return kzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("FirstInpatientIntensiveCareUnit")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> kzzzzzzzzzzzzzzzzzk_ = Encounter?.Location;
        bool? kzzzzzzzzzzzzzzzzzl_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference kzzzzzzzzzzzzzzzzzq_ = HospitalLocation?.Location;
            Location kzzzzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetLocation(context, kzzzzzzzzzzzzzzzzzq_);
            List<CodeableConcept> kzzzzzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzzzzzr_?.Type;
            CqlConcept kzzzzzzzzzzzzzzzzzt_(CodeableConcept X)
            {
                CqlConcept lzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return lzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)kzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzt_);
            CqlValueSet kzzzzzzzzzzzzzzzzzv_ = this.Intensive_Care_Unit(context);
            bool? kzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzv_);
            Period kzzzzzzzzzzzzzzzzzx_ = Encounter?.Period;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzx_);
            Period kzzzzzzzzzzzzzzzzzz_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzz_);
            bool? lzzzzzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzza_, default);
            bool? lzzzzzzzzzzzzzzzzzc_ = context.Operators.And(kzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzb_);

            return lzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter.LocationComponent> kzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)kzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzl_);
        object kzzzzzzzzzzzzzzzzzn_(Encounter.LocationComponent @this)
        {
            Period lzzzzzzzzzzzzzzzzze_ = @this?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzze_);
            CqlDateTime lzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzf_);

            return lzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter.LocationComponent> kzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Encounter.LocationComponent>(kzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent kzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Encounter.LocationComponent>(kzzzzzzzzzzzzzzzzzo_);

        return kzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("FirstICULocationPeriod")]
    public Period FirstICULocationPeriod(CqlContext context, Encounter Encounter)
    {
        Encounter.LocationComponent lzzzzzzzzzzzzzzzzzh_ = this.FirstInpatientIntensiveCareUnit(context, Encounter);
        Period lzzzzzzzzzzzzzzzzzi_ = lzzzzzzzzzzzzzzzzzh_?.Period;

        return lzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("StartOfFirstICU")]
    public CqlDateTime StartOfFirstICU(CqlContext context, Encounter Encounter)
    {
        Period lzzzzzzzzzzzzzzzzzj_ = this.FirstICULocationPeriod(context, Encounter);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzj_);
        CqlDateTime lzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzk_);

        return lzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate lzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(StartValue);
        CqlQuantity lzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1m, "day");
        CqlDate lzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzo_);
        CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzp_, true, true);

        return lzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, Encounter);
        CqlDateTime lzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzr_);
        CqlDate lzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzs_);
        Period lzzzzzzzzzzzzzzzzzu_ = Encounter?.Period;
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzu_);
        CqlDateTime lzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzv_);
        CqlDate lzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzw_);
        CqlQuantity lzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1m, "day");
        CqlDate lzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzy_);
        CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzz_, true, true);

        return mzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, Encounter);
        CqlDateTime mzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzb_);
        CqlDate mzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzc_);
        CqlDateTime mzzzzzzzzzzzzzzzzze_ = this.StartOfFirstICU(context, Encounter);
        CqlDate mzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzze_);
        CqlQuantity mzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1m, "day");
        CqlDate mzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzg_);
        CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzh_, true, true);

        return mzzzzzzzzzzzzzzzzzi_;
    }


    #endregion Expressions

}

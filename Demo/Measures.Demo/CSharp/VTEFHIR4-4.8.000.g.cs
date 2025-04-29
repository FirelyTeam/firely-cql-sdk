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

    #region ValueSet: Intensive Care Unit
    [CqlValueSetDefinition(
        definitionName: "Intensive Care Unit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206",
        valueSetVersion: null)]
    public CqlValueSet Intensive_Care_Unit(CqlContext context) => _Intensive_Care_Unit;

    private static readonly CqlValueSet _Intensive_Care_Unit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ezzzzzzzzzzzzb_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime ezzzzzzzzzzzzc_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzd_ = context.Operators.Interval(ezzzzzzzzzzzzb_, ezzzzzzzzzzzzc_, true, false);
        object ezzzzzzzzzzzze_ = context.ResolveParameter("VTEFHIR4-4.8.000", "Measurement Period", ezzzzzzzzzzzzd_);

        return (CqlInterval<CqlDateTime>)ezzzzzzzzzzzze_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzzzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient ezzzzzzzzzzzzg_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzzzzzzf_);

        return ezzzzzzzzzzzzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> ezzzzzzzzzzzzh_ = Encounter?.Location;
        bool? ezzzzzzzzzzzzi_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference ezzzzzzzzzzzzn_ = HospitalLocation?.Location;
            Location ezzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetLocation(context, ezzzzzzzzzzzzn_);
            List<CodeableConcept> ezzzzzzzzzzzzp_ = ezzzzzzzzzzzzo_?.Type;
            CqlConcept ezzzzzzzzzzzzq_(CodeableConcept X)
            {
                CqlConcept fzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return fzzzzzzzzzzzza_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzzzzzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzzzzzzzzzzp_, ezzzzzzzzzzzzq_);
            CqlValueSet ezzzzzzzzzzzzs_ = this.Intensive_Care_Unit(context);
            bool? ezzzzzzzzzzzzt_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzr_, ezzzzzzzzzzzzs_);
            Period ezzzzzzzzzzzzu_ = Encounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzu_);
            Period ezzzzzzzzzzzzw_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ezzzzzzzzzzzzw_);
            bool? ezzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzv_, ezzzzzzzzzzzzx_, default);
            bool? ezzzzzzzzzzzzz_ = context.Operators.And(ezzzzzzzzzzzzt_, ezzzzzzzzzzzzy_);

            return ezzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter.LocationComponent> ezzzzzzzzzzzzj_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)ezzzzzzzzzzzzh_, ezzzzzzzzzzzzi_);
        object ezzzzzzzzzzzzk_(Encounter.LocationComponent @this)
        {
            Period fzzzzzzzzzzzzb_ = @this?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzb_);
            CqlDateTime fzzzzzzzzzzzzd_ = context.Operators.Start(fzzzzzzzzzzzzc_);

            return fzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter.LocationComponent> ezzzzzzzzzzzzl_ = context.Operators.SortBy<Encounter.LocationComponent>(ezzzzzzzzzzzzj_, ezzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent ezzzzzzzzzzzzm_ = context.Operators.First<Encounter.LocationComponent>(ezzzzzzzzzzzzl_);

        return ezzzzzzzzzzzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public Period FirstICULocationPeriod(CqlContext context, Encounter Encounter)
    {
        Encounter.LocationComponent fzzzzzzzzzzzze_ = this.FirstInpatientIntensiveCareUnit(context, Encounter);
        Period fzzzzzzzzzzzzf_ = fzzzzzzzzzzzze_?.Period;

        return fzzzzzzzzzzzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime StartOfFirstICU(CqlContext context, Encounter Encounter)
    {
        Period fzzzzzzzzzzzzg_ = this.FirstICULocationPeriod(context, Encounter);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzg_);
        CqlDateTime fzzzzzzzzzzzzi_ = context.Operators.Start(fzzzzzzzzzzzzh_);

        return fzzzzzzzzzzzzi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate fzzzzzzzzzzzzj_ = context.Operators.DateFrom(StartValue);
        CqlQuantity fzzzzzzzzzzzzl_ = context.Operators.Quantity(1m, "day");
        CqlDate fzzzzzzzzzzzzm_ = context.Operators.Add(fzzzzzzzzzzzzj_, fzzzzzzzzzzzzl_);
        CqlInterval<CqlDate> fzzzzzzzzzzzzn_ = context.Operators.Interval(fzzzzzzzzzzzzj_, fzzzzzzzzzzzzm_, true, true);

        return fzzzzzzzzzzzzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, Encounter);
        CqlDateTime fzzzzzzzzzzzzp_ = context.Operators.Start(fzzzzzzzzzzzzo_);
        CqlDate fzzzzzzzzzzzzq_ = context.Operators.DateFrom(fzzzzzzzzzzzzp_);
        Period fzzzzzzzzzzzzr_ = Encounter?.Period;
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, fzzzzzzzzzzzzr_);
        CqlDateTime fzzzzzzzzzzzzt_ = context.Operators.Start(fzzzzzzzzzzzzs_);
        CqlDate fzzzzzzzzzzzzu_ = context.Operators.DateFrom(fzzzzzzzzzzzzt_);
        CqlQuantity fzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "day");
        CqlDate fzzzzzzzzzzzzw_ = context.Operators.Add(fzzzzzzzzzzzzu_, fzzzzzzzzzzzzv_);
        CqlInterval<CqlDate> fzzzzzzzzzzzzx_ = context.Operators.Interval(fzzzzzzzzzzzzq_, fzzzzzzzzzzzzw_, true, true);

        return fzzzzzzzzzzzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, Encounter);
        CqlDateTime fzzzzzzzzzzzzz_ = context.Operators.Start(fzzzzzzzzzzzzy_);
        CqlDate gzzzzzzzzzzzza_ = context.Operators.DateFrom(fzzzzzzzzzzzzz_);
        CqlDateTime gzzzzzzzzzzzzb_ = this.StartOfFirstICU(context, Encounter);
        CqlDate gzzzzzzzzzzzzc_ = context.Operators.DateFrom(gzzzzzzzzzzzzb_);
        CqlQuantity gzzzzzzzzzzzzd_ = context.Operators.Quantity(1m, "day");
        CqlDate gzzzzzzzzzzzze_ = context.Operators.Add(gzzzzzzzzzzzzc_, gzzzzzzzzzzzzd_);
        CqlInterval<CqlDate> gzzzzzzzzzzzzf_ = context.Operators.Interval(gzzzzzzzzzzzza_, gzzzzzzzzzzzze_, true, true);

        return gzzzzzzzzzzzzf_;
    }


    #endregion Expressions

}

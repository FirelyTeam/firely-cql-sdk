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
        CqlDateTime mzzzzzzzzl_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime mzzzzzzzzm_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> mzzzzzzzzn_ = context.Operators.Interval(mzzzzzzzzl_, mzzzzzzzzm_, true, false);
        object mzzzzzzzzo_ = context.ResolveParameter("VTEFHIR4-4.8.000", "Measurement Period", mzzzzzzzzn_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient mzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzp_);

        return mzzzzzzzzq_;
    }


    [CqlExpressionDefinition("FirstInpatientIntensiveCareUnit")]
    public Encounter.LocationComponent FirstInpatientIntensiveCareUnit(CqlContext context, Encounter Encounter)
    {
        List<Encounter.LocationComponent> mzzzzzzzzr_ = Encounter?.Location;
        bool? mzzzzzzzzs_(Encounter.LocationComponent HospitalLocation)
        {
            ResourceReference mzzzzzzzzx_ = HospitalLocation?.Location;
            Location mzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetLocation(context, mzzzzzzzzx_);
            List<CodeableConcept> mzzzzzzzzz_ = mzzzzzzzzy_?.Type;
            CqlConcept nzzzzzzzza_(CodeableConcept X)
            {
                CqlConcept nzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return nzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> nzzzzzzzzb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)mzzzzzzzzz_, nzzzzzzzza_);
            CqlValueSet nzzzzzzzzc_ = this.Intensive_Care_Unit(context);
            bool? nzzzzzzzzd_ = context.Operators.ConceptsInValueSet(nzzzzzzzzb_, nzzzzzzzzc_);
            Period nzzzzzzzze_ = Encounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzze_);
            Period nzzzzzzzzg_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzg_);
            bool? nzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzf_, nzzzzzzzzh_, default);
            bool? nzzzzzzzzj_ = context.Operators.And(nzzzzzzzzd_, nzzzzzzzzi_);

            return nzzzzzzzzj_;
        };
        IEnumerable<Encounter.LocationComponent> mzzzzzzzzt_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)mzzzzzzzzr_, mzzzzzzzzs_);
        object mzzzzzzzzu_(Encounter.LocationComponent @this)
        {
            Period nzzzzzzzzl_ = @this?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzl_);
            CqlDateTime nzzzzzzzzn_ = context.Operators.Start(nzzzzzzzzm_);

            return nzzzzzzzzn_;
        };
        IEnumerable<Encounter.LocationComponent> mzzzzzzzzv_ = context.Operators.SortBy<Encounter.LocationComponent>(mzzzzzzzzt_, mzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent mzzzzzzzzw_ = context.Operators.First<Encounter.LocationComponent>(mzzzzzzzzv_);

        return mzzzzzzzzw_;
    }


    [CqlExpressionDefinition("FirstICULocationPeriod")]
    public Period FirstICULocationPeriod(CqlContext context, Encounter Encounter)
    {
        Encounter.LocationComponent nzzzzzzzzo_ = this.FirstInpatientIntensiveCareUnit(context, Encounter);
        Period nzzzzzzzzp_ = nzzzzzzzzo_?.Period;

        return nzzzzzzzzp_;
    }


    [CqlExpressionDefinition("StartOfFirstICU")]
    public CqlDateTime StartOfFirstICU(CqlContext context, Encounter Encounter)
    {
        Period nzzzzzzzzq_ = this.FirstICULocationPeriod(context, Encounter);
        CqlInterval<CqlDateTime> nzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, nzzzzzzzzq_);
        CqlDateTime nzzzzzzzzs_ = context.Operators.Start(nzzzzzzzzr_);

        return nzzzzzzzzs_;
    }


    [CqlExpressionDefinition("CalendarDayOfOrDayAfter")]
    public CqlInterval<CqlDate> CalendarDayOfOrDayAfter(CqlContext context, CqlDateTime StartValue)
    {
        CqlDate nzzzzzzzzt_ = context.Operators.DateFrom(StartValue);
        CqlQuantity nzzzzzzzzv_ = context.Operators.Quantity(1m, "day");
        CqlDate nzzzzzzzzw_ = context.Operators.Add(nzzzzzzzzt_, nzzzzzzzzv_);
        CqlInterval<CqlDate> nzzzzzzzzx_ = context.Operators.Interval(nzzzzzzzzt_, nzzzzzzzzw_, true, true);

        return nzzzzzzzzx_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> nzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, Encounter);
        CqlDateTime nzzzzzzzzz_ = context.Operators.Start(nzzzzzzzzy_);
        CqlDate ozzzzzzzza_ = context.Operators.DateFrom(nzzzzzzzzz_);
        Period ozzzzzzzzb_ = Encounter?.Period;
        CqlInterval<CqlDateTime> ozzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ozzzzzzzzb_);
        CqlDateTime ozzzzzzzzd_ = context.Operators.Start(ozzzzzzzzc_);
        CqlDate ozzzzzzzze_ = context.Operators.DateFrom(ozzzzzzzzd_);
        CqlQuantity ozzzzzzzzf_ = context.Operators.Quantity(1m, "day");
        CqlDate ozzzzzzzzg_ = context.Operators.Add(ozzzzzzzze_, ozzzzzzzzf_);
        CqlInterval<CqlDate> ozzzzzzzzh_ = context.Operators.Interval(ozzzzzzzza_, ozzzzzzzzg_, true, true);

        return ozzzzzzzzh_;
    }


    [CqlExpressionDefinition("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
    public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(CqlContext context, Encounter Encounter)
    {
        CqlInterval<CqlDateTime> ozzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, Encounter);
        CqlDateTime ozzzzzzzzj_ = context.Operators.Start(ozzzzzzzzi_);
        CqlDate ozzzzzzzzk_ = context.Operators.DateFrom(ozzzzzzzzj_);
        CqlDateTime ozzzzzzzzl_ = this.StartOfFirstICU(context, Encounter);
        CqlDate ozzzzzzzzm_ = context.Operators.DateFrom(ozzzzzzzzl_);
        CqlQuantity ozzzzzzzzn_ = context.Operators.Quantity(1m, "day");
        CqlDate ozzzzzzzzo_ = context.Operators.Add(ozzzzzzzzm_, ozzzzzzzzn_);
        CqlInterval<CqlDate> ozzzzzzzzp_ = context.Operators.Interval(ozzzzzzzzk_, ozzzzzzzzo_, true, true);

        return ozzzzzzzzp_;
    }


    #endregion Expressions

}

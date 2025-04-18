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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.1.0.0")]
[CqlLibrary("RR23", "1.0.0")]
public partial class RR23_1_0_0 : ILibrary, ISingleton<RR23_1_0_0>
{
    private RR23_1_0_0() {}

    public static RR23_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "RR23";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_1.Instance];

    #endregion ILibrary Implementation

    #region Definition Methods

    [CqlDeclaration("Injury due to falling rock")]
    [CqlValueSet("http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock")]
    public CqlValueSet Injury_due_to_falling_rock(CqlContext context) =>
        new CqlValueSet("http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock", default);


    [CqlDeclaration("Roadrunners Syndrome Indicators")]
    [CqlValueSet("http://moh.alpha.alp/ValueSet/DiagnosisRoadrunnerSyndrome")]
    public CqlValueSet Roadrunners_Syndrome_Indicators(CqlContext context) =>
        new CqlValueSet("http://moh.alpha.alp/ValueSet/DiagnosisRoadrunnerSyndrome", default);


    [CqlDeclaration("Tiny Umbrella")]
    public CqlCode Tiny_Umbrella(CqlContext context) =>
        new CqlCode("U707", "http://acme.org/product-catalog", default, default);


    [CqlDeclaration("entered-in-error")]
    public CqlCode entered_in_error(CqlContext context) =>
        new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);


    [CqlDeclaration("ACME Product Catalog")]
    public CqlCode[] ACME_Product_Catalog(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("U707", "http://acme.org/product-catalog", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("ConditionVerificationStatusCodes")]
    public CqlCode[] ConditionVerificationStatusCodes(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2023, 1, 1, default, default, default, default, default);
        CqlDateTime b_ = context.Operators.DateTime(2023, 12, 31, default, default, default, default, default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("RR23-1.0.0", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        CqlDateTime c_ = context.Operators.Convert<CqlDateTime>(b_);
        CqlInterval<CqlDateTime> d_ = this.Measurement_Period(context);
        CqlDateTime e_ = context.Operators.Start(d_);
        int? f_ = context.Operators.CalculateAgeAt(c_, e_, "year");
        bool? g_ = context.Operators.GreaterOrEqual(f_, 16);
        IEnumerable<Condition> h_ = this.Injury_due_to_falling_rock_within_measurement_period(context);
        bool? i_ = context.Operators.Exists<Condition>(h_);
        bool? j_ = context.Operators.And(g_, i_);

        return j_;
    }


    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<SupplyDelivery> a_ = this.Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock(context);
        bool? b_ = context.Operators.Exists<SupplyDelivery>(a_);

        return b_;
    }


    [CqlDeclaration("Injury due to falling rock within measurement period")]
    public IEnumerable<Condition> Injury_due_to_falling_rock_within_measurement_period(CqlContext context)
    {
        CqlValueSet a_ = this.Injury_due_to_falling_rock(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? c_(Condition C)
        {
            DataType e_ = C?.Onset;
            CqlDateTime f_ = FHIRHelpers_4_0_1.Instance.ToDateTime(context, e_ as FhirDateTime);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            bool? h_ = context.Operators.In<CqlDateTime>(f_, g_, default);

            return h_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

        return d_;
    }


    [CqlDeclaration("Latest injury due to falling rock")]
    public Condition Latest_injury_due_to_falling_rock(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Injury_due_to_falling_rock_within_measurement_period(context);
        object b_(Condition @this)
        {
            DataType e_ = @this?.Onset;
            CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_ as FhirDateTime);

            return f_;
        };
        IEnumerable<Condition> c_ = context.Operators.SortBy<Condition>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        Condition d_ = context.Operators.Last<Condition>(c_);

        return d_;
    }


    [CqlDeclaration("Tiny Umbrella Supply within 7 days after most recent injury due to falling rock")]
    public IEnumerable<SupplyDelivery> Tiny_Umbrella_Supply_within_7_days_after_most_recent_injury_due_to_falling_rock(CqlContext context)
    {
        IEnumerable<SupplyDelivery> a_ = context.Operators.Retrieve<SupplyDelivery>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/SupplyDelivery"));
        bool? b_(SupplyDelivery SD)
        {
            SupplyDelivery.SuppliedItemComponent d_ = SD?.SuppliedItem;
            DataType e_ = d_?.Item;
            CqlCode f_ = this.Tiny_Umbrella(context);
            bool? g_ = context.Operators.Equivalent(e_, f_);
            Condition h_ = this.Latest_injury_due_to_falling_rock(context);
            Condition[] i_ = [
                h_,
            ];
            bool? j_(Condition C)
            {
                DataType o_ = C?.Onset;
                DataType p_ = SD?.Occurrence;
                bool? q_ = context.Operators.Before(o_ as FhirDateTime, p_ as FhirDateTime, default);

                return q_;
            };
            IEnumerable<Condition> k_ = context.Operators.Where<Condition>((IEnumerable<Condition>)i_, j_);
            Condition l_ = context.Operators.SingletonFrom<Condition>(k_);
            bool? m_ = context.Operators.Not((bool?)((l_ as object) is null));
            bool? n_ = context.Operators.And(g_, m_);

            return n_;
        };
        IEnumerable<SupplyDelivery> c_ = context.Operators.Where<SupplyDelivery>(a_, b_);

        return c_;
    }


    #endregion Definition Methods

}

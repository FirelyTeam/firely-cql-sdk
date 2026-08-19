#nullable enable

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("NHSNHelpers", "0.1.000")]
public partial class NHSNHelpers_0_1_000 : ILibrary, ISingleton<NHSNHelpers_0_1_000>
{
    #region Functions and Expressions (5)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 2602634814169307855L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("Normalize Interval")]
    public CqlInterval<CqlDateTime?>? Normalize_Interval(CqlContext context, object? choice)
    {
        if (choice is FhirDateTime)
        {
            CqlDateTime? a_ = FHIRHelpers_4_4_000.Instance.ToDateTime(context, choice as FhirDateTime);
            CqlInterval<CqlDateTime?>? b_ = context.Operators.Interval(a_, a_, true, true);
            return b_;
        }
        else if (choice is Period)
        {
            CqlInterval<CqlDateTime?>? c_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, choice as Period);
            return c_;
        }
        else if (choice is Instant)
        {
            CqlDateTime? d_ = FHIRHelpers_4_4_000.Instance.ToDateTime(context, choice as Instant);
            CqlInterval<CqlDateTime?>? e_ = context.Operators.Interval(d_, d_, true, true);
            return e_;
        }
        else if (choice is Age)
        {
            Patient? f_ = this.Patient(context);
            Date? g_ = f_?.BirthDateElement;
            CqlDate? h_ = FHIRHelpers_4_4_000.Instance.ToDate(context, g_);
            CqlQuantity? i_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, choice as Age);
            CqlDate? j_ = context.Operators.Add(h_, i_);
            CqlDateTime? k_ = context.Operators.ConvertDateToDateTime(j_);
            CqlQuantity? l_ = context.Operators.Quantity(1m, "year");
            CqlDate? m_ = context.Operators.Add(j_, l_);
            CqlDateTime? n_ = context.Operators.ConvertDateToDateTime(m_);
            CqlInterval<CqlDateTime?>? o_ = context.Operators.Interval(k_, n_, true, false);
            return o_;
        }
        else if (choice is Range)
        {
            Patient? p_ = this.Patient(context);
            Date? q_ = p_?.BirthDateElement;
            CqlDate? r_ = FHIRHelpers_4_4_000.Instance.ToDate(context, q_);
            Quantity? s_ = (choice as Range)?.Low;
            CqlQuantity? t_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, s_);
            CqlDate? u_ = context.Operators.Add(r_, t_);
            CqlDateTime? v_ = context.Operators.ConvertDateToDateTime(u_);
            Quantity? w_ = (choice as Range)?.High;
            CqlQuantity? x_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, w_);
            CqlDate? y_ = context.Operators.Add(r_, x_);
            CqlQuantity? z_ = context.Operators.Quantity(1m, "year");
            CqlDate? aa_ = context.Operators.Add(y_, z_);
            CqlDateTime? ab_ = context.Operators.ConvertDateToDateTime(aa_);
            CqlInterval<CqlDateTime?>? ac_ = context.Operators.Interval(v_, ab_, true, false);
            return ac_;
        }
        else if (choice is Timing)
        {
            CqlInterval<CqlDateTime?>? ad_ = context.Operators.Message<CqlInterval<CqlDateTime?>?>((CqlInterval<CqlDateTime>?)(null as CqlInterval<CqlDateTime?>), "1"!, "Error"!, ("Cannot compute a single interval from a Timing type")!);
            return ad_;
        }
        else if (choice is FhirString)
        {
            CqlInterval<CqlDateTime?>? ae_ = context.Operators.Message<CqlInterval<CqlDateTime?>?>((CqlInterval<CqlDateTime>?)(null as CqlInterval<CqlDateTime?>), "1"!, "Error"!, ("Cannot compute an interval from a String value")!);
            return ae_;
        }
        else
        {
            return null as CqlInterval<CqlDateTime?>;
        }
    }


    [CqlFunctionDefinition("ToDateInterval")]
    public CqlInterval<CqlDate?>? ToDateInterval(CqlContext context, Period? period)
    {
        FhirDateTime? a_ = period?.StartElement;
        CqlDateTime? b_ = FHIRHelpers_4_4_000.Instance.ToDateTime(context, a_);
        CqlDate? c_ = context.Operators.DateFrom(b_);
        FhirDateTime? d_ = period?.EndElement;
        CqlDateTime? e_ = FHIRHelpers_4_4_000.Instance.ToDateTime(context, d_);
        CqlDate? f_ = context.Operators.DateFrom(e_);
        CqlInterval<CqlDate?>? g_ = context.Operators.Interval(c_, f_, true, true);
        return g_;
    }


    [CqlFunctionDefinition("GetLocation")]
    public Location? GetLocation(CqlContext context, ResourceReference? reference)
    {
        IEnumerable<Location?>? a_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));

        bool? b_(Location? Locations) {
            Id? e_ = Locations?.IdElement;
            FhirString? f_ = context.Operators.Convert<FhirString?>(e_);
            string? g_ = FHIRHelpers_4_4_000.Instance.ToString(context, f_);
            FhirString? h_ = reference?.ReferenceElement;
            string? i_ = FHIRHelpers_4_4_000.Instance.ToString(context, h_);
            string? j_ = this.GetId(context, i_);
            bool? k_ = context.Operators.Equal(g_, j_);
            return k_;
        }

        IEnumerable<Location?>? c_ = context.Operators.Where<Location?>(a_, b_);
        Location? d_ = context.Operators.SingletonFrom<Location?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("GetId")]
    public string? GetId(CqlContext context, string? uri)
    {
        IEnumerable<string?>? a_ = context.Operators.Split(uri!, "/"!);
        string? b_ = context.Operators.Last<string?>(a_!);
        return b_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private NHSNHelpers_0_1_000() {}

    public static NHSNHelpers_0_1_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "NHSNHelpers";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

}

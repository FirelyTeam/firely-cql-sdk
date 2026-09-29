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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.3.0")]
[CqlLibrary("NHSNHelpers", "0.1.000")]
public partial class NHSNHelpers_0_1_000 : ILibrary, ISingleton<NHSNHelpers_0_1_000>
{
    #region Functions and Expressions (5)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 2602634814169307855L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlFunctionDefinition("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
    {
        if (choice is FhirDateTime a_)
        {
            CqlDateTime h_ = FHIRHelpers_4_4_000.Instance.ToDateTime(context, a_);
            CqlInterval<CqlDateTime> i_ = context.Operators.Interval(h_, h_, true, true);
            return i_;
        }
        else if (choice is Period b_)
        {
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, b_);
            return j_;
        }
        else if (choice is Instant c_)
        {
            CqlDateTime k_ = FHIRHelpers_4_4_000.Instance.ToDateTime(context, c_);
            CqlInterval<CqlDateTime> l_ = context.Operators.Interval(k_, k_, true, true);
            return l_;
        }
        else if (choice is Age d_)
        {
            Patient m_ = this.Patient(context);
            Date n_ = m_?.BirthDateElement;
            CqlDate o_ = FHIRHelpers_4_4_000.Instance.ToDate(context, n_);
            CqlQuantity p_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, d_);
            CqlDate q_ = context.Operators.Add(o_, p_);
            CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
            CqlQuantity s_ = context.Operators.Quantity(1m, "year");
            CqlDate t_ = context.Operators.Add(q_, s_);
            CqlDateTime u_ = context.Operators.ConvertDateToDateTime(t_);
            CqlInterval<CqlDateTime> v_ = context.Operators.Interval(r_, u_, true, false);
            return v_;
        }
        else if (choice is Range e_)
        {
            Patient w_ = this.Patient(context);
            Date x_ = w_?.BirthDateElement;
            CqlDate y_ = FHIRHelpers_4_4_000.Instance.ToDate(context, x_);
            CqlQuantity z_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, e_.Low);
            CqlDate aa_ = context.Operators.Add(y_, z_);
            CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
            CqlQuantity ac_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, e_.High);
            CqlDate ad_ = context.Operators.Add(y_, ac_);
            CqlQuantity ae_ = context.Operators.Quantity(1m, "year");
            CqlDate af_ = context.Operators.Add(ad_, ae_);
            CqlDateTime ag_ = context.Operators.ConvertDateToDateTime(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ab_, ag_, true, false);
            return ah_;
        }
        else if (choice is Timing f_)
        {
            CqlInterval<CqlDateTime> ai_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");
            return ai_;
        }
        else if (choice is FhirString g_)
        {
            CqlInterval<CqlDateTime> aj_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
            return aj_;
        }
        else
        {
            return null as CqlInterval<CqlDateTime>;
        }
    }


    [CqlFunctionDefinition("ToDateInterval")]
    public CqlInterval<CqlDate> ToDateInterval(CqlContext context, Period period)
    {
        FhirDateTime a_ = period?.StartElement;
        CqlDateTime b_ = FHIRHelpers_4_4_000.Instance.ToDateTime(context, a_);
        CqlDate c_ = context.Operators.DateFrom(b_);
        FhirDateTime d_ = period?.EndElement;
        CqlDateTime e_ = FHIRHelpers_4_4_000.Instance.ToDateTime(context, d_);
        CqlDate f_ = context.Operators.DateFrom(e_);
        CqlInterval<CqlDate> g_ = context.Operators.Interval(c_, f_, true, true);
        return g_;
    }


    [CqlFunctionDefinition("GetLocation")]
    public Location GetLocation(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Location> a_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));

        bool? b_(Location Locations) {
            Id e_ = Locations?.IdElement;
            FhirString f_ = context.Operators.Convert<FhirString>(e_);
            string g_ = FHIRHelpers_4_4_000.Instance.ToString(context, f_);
            FhirString h_ = reference?.ReferenceElement;
            string i_ = FHIRHelpers_4_4_000.Instance.ToString(context, h_);
            string j_ = this.GetId(context, i_);
            bool? k_ = context.Operators.Equal(g_, j_);
            return k_;
        }

        IEnumerable<Location> c_ = context.Operators.Where<Location>(a_, b_);
        Location d_ = context.Operators.SingletonFrom<Location>(c_);
        return d_;
    }


    [CqlFunctionDefinition("GetId")]
    public string GetId(CqlContext context, string uri)
    {
        IEnumerable<string> a_ = context.Operators.Split(uri, "/");
        string b_ = context.Operators.Last<string>(a_);
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

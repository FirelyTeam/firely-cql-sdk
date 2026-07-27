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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
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

        CqlInterval<CqlDateTime> a_() {
            if (choice is FhirDateTime)
            {
                CqlDateTime b_ = FHIRHelpers_4_4_000.Instance.ToDateTime(context, choice as FhirDateTime);
                CqlInterval<CqlDateTime> c_ = context.Operators.Interval(b_, b_, true, true);
                return c_;
            }
            else if (choice is Period)
            {
                CqlInterval<CqlDateTime> d_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, choice as Period);
                return d_;
            }
            else if (choice is Instant)
            {
                CqlDateTime e_ = FHIRHelpers_4_4_000.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> f_ = context.Operators.Interval(e_, e_, true, true);
                return f_;
            }
            else if (choice is Age)
            {
                Patient g_ = this.Patient(context);
                Date h_ = g_?.BirthDateElement;
                CqlDate i_ = FHIRHelpers_4_4_000.Instance.ToDate(context, h_);
                CqlQuantity j_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, choice as Age);
                CqlDate k_ = context.Operators.Add(i_, j_);
                CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
                CqlQuantity m_ = context.Operators.Quantity(1m, "year");
                CqlDate n_ = context.Operators.Add(k_, m_);
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(l_, o_, true, false);
                return p_;
            }
            else if (choice is Range)
            {
                Patient q_ = this.Patient(context);
                Date r_ = q_?.BirthDateElement;
                CqlDate s_ = FHIRHelpers_4_4_000.Instance.ToDate(context, r_);
                Quantity t_ = (choice as Range)?.Low;
                CqlQuantity u_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, t_);
                CqlDate v_ = context.Operators.Add(s_, u_);
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                Quantity x_ = (choice as Range)?.High;
                CqlQuantity y_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, x_);
                CqlDate z_ = context.Operators.Add(s_, y_);
                CqlQuantity aa_ = context.Operators.Quantity(1m, "year");
                CqlDate ab_ = context.Operators.Add(z_, aa_);
                CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(ab_);
                CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(w_, ac_, true, false);
                return ad_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> ae_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");
                return ae_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> af_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
                return af_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        }

        return a_();
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

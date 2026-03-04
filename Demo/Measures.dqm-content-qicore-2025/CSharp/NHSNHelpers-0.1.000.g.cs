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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
[CqlLibrary("NHSNHelpers", "0.1.000")]
public partial class NHSNHelpers_0_1_000 : ILibrary, ISingleton<NHSNHelpers_0_1_000>
{
    #region Functions and Expressions (5)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private static readonly long _cacheIndex_Patient = 2602634814169307855L;

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
                CqlInterval<CqlDateTime> d_ = context.Operators.Interval(b_, b_, true, true);
                return d_;
            }
            else if (choice is Period)
            {
                CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, choice as Period);
                return e_;
            }
            else if (choice is Instant)
            {
                CqlDateTime f_ = FHIRHelpers_4_4_000.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> h_ = context.Operators.Interval(f_, f_, true, true);
                return h_;
            }
            else if (choice is Age)
            {
                Patient i_ = this.Patient(context);
                Date j_ = i_?.BirthDateElement;
                CqlDate k_ = FHIRHelpers_4_4_000.Instance.ToDate(context, j_);
                CqlQuantity l_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, choice as Age);
                CqlDate m_ = context.Operators.Add(k_, l_);
                Date o_ = i_?.BirthDateElement;
                CqlDate p_ = FHIRHelpers_4_4_000.Instance.ToDate(context, o_);
                CqlDate r_ = context.Operators.Add(p_, l_);
                CqlQuantity s_ = context.Operators.Quantity(1m, "year");
                CqlDate t_ = context.Operators.Add(r_, s_);
                CqlInterval<CqlDate> u_ = context.Operators.Interval(m_, t_, true, false);
                CqlDate v_ = u_?.low;
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                Date y_ = i_?.BirthDateElement;
                CqlDate z_ = FHIRHelpers_4_4_000.Instance.ToDate(context, y_);
                CqlDate ab_ = context.Operators.Add(z_, l_);
                Date ad_ = i_?.BirthDateElement;
                CqlDate ae_ = FHIRHelpers_4_4_000.Instance.ToDate(context, ad_);
                CqlDate ag_ = context.Operators.Add(ae_, l_);
                CqlDate ai_ = context.Operators.Add(ag_, s_);
                CqlInterval<CqlDate> aj_ = context.Operators.Interval(ab_, ai_, true, false);
                CqlDate ak_ = aj_?.high;
                CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);
                Date an_ = i_?.BirthDateElement;
                CqlDate ao_ = FHIRHelpers_4_4_000.Instance.ToDate(context, an_);
                CqlDate aq_ = context.Operators.Add(ao_, l_);
                Date as_ = i_?.BirthDateElement;
                CqlDate at_ = FHIRHelpers_4_4_000.Instance.ToDate(context, as_);
                CqlDate av_ = context.Operators.Add(at_, l_);
                CqlDate ax_ = context.Operators.Add(av_, s_);
                CqlInterval<CqlDate> ay_ = context.Operators.Interval(aq_, ax_, true, false);
                bool? az_ = ay_?.lowClosed;
                Date bb_ = i_?.BirthDateElement;
                CqlDate bc_ = FHIRHelpers_4_4_000.Instance.ToDate(context, bb_);
                CqlDate be_ = context.Operators.Add(bc_, l_);
                Date bg_ = i_?.BirthDateElement;
                CqlDate bh_ = FHIRHelpers_4_4_000.Instance.ToDate(context, bg_);
                CqlDate bj_ = context.Operators.Add(bh_, l_);
                CqlDate bl_ = context.Operators.Add(bj_, s_);
                CqlInterval<CqlDate> bm_ = context.Operators.Interval(be_, bl_, true, false);
                bool? bn_ = bm_?.highClosed;
                CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(w_, al_, az_, bn_);
                return bo_;
            }
            else if (choice is Range)
            {
                Patient bp_ = this.Patient(context);
                Date bq_ = bp_?.BirthDateElement;
                CqlDate br_ = FHIRHelpers_4_4_000.Instance.ToDate(context, bq_);
                Quantity bs_ = (choice as Range)?.Low;
                CqlQuantity bt_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bs_);
                CqlDate bu_ = context.Operators.Add(br_, bt_);
                Date bw_ = bp_?.BirthDateElement;
                CqlDate bx_ = FHIRHelpers_4_4_000.Instance.ToDate(context, bw_);
                Quantity by_ = (choice as Range)?.High;
                CqlQuantity bz_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, by_);
                CqlDate ca_ = context.Operators.Add(bx_, bz_);
                CqlQuantity cb_ = context.Operators.Quantity(1m, "year");
                CqlDate cc_ = context.Operators.Add(ca_, cb_);
                CqlInterval<CqlDate> cd_ = context.Operators.Interval(bu_, cc_, true, false);
                CqlDate ce_ = cd_?.low;
                CqlDateTime cf_ = context.Operators.ConvertDateToDateTime(ce_);
                Date ch_ = bp_?.BirthDateElement;
                CqlDate ci_ = FHIRHelpers_4_4_000.Instance.ToDate(context, ch_);
                CqlQuantity ck_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bs_);
                CqlDate cl_ = context.Operators.Add(ci_, ck_);
                Date cn_ = bp_?.BirthDateElement;
                CqlDate co_ = FHIRHelpers_4_4_000.Instance.ToDate(context, cn_);
                CqlQuantity cq_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, by_);
                CqlDate cr_ = context.Operators.Add(co_, cq_);
                CqlDate ct_ = context.Operators.Add(cr_, cb_);
                CqlInterval<CqlDate> cu_ = context.Operators.Interval(cl_, ct_, true, false);
                CqlDate cv_ = cu_?.high;
                CqlDateTime cw_ = context.Operators.ConvertDateToDateTime(cv_);
                Date cy_ = bp_?.BirthDateElement;
                CqlDate cz_ = FHIRHelpers_4_4_000.Instance.ToDate(context, cy_);
                CqlQuantity db_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bs_);
                CqlDate dc_ = context.Operators.Add(cz_, db_);
                Date de_ = bp_?.BirthDateElement;
                CqlDate df_ = FHIRHelpers_4_4_000.Instance.ToDate(context, de_);
                CqlQuantity dh_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, by_);
                CqlDate di_ = context.Operators.Add(df_, dh_);
                CqlDate dk_ = context.Operators.Add(di_, cb_);
                CqlInterval<CqlDate> dl_ = context.Operators.Interval(dc_, dk_, true, false);
                bool? dm_ = dl_?.lowClosed;
                Date do_ = bp_?.BirthDateElement;
                CqlDate dp_ = FHIRHelpers_4_4_000.Instance.ToDate(context, do_);
                CqlQuantity dr_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bs_);
                CqlDate ds_ = context.Operators.Add(dp_, dr_);
                Date du_ = bp_?.BirthDateElement;
                CqlDate dv_ = FHIRHelpers_4_4_000.Instance.ToDate(context, du_);
                CqlQuantity dx_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, by_);
                CqlDate dy_ = context.Operators.Add(dv_, dx_);
                CqlDate ea_ = context.Operators.Add(dy_, cb_);
                CqlInterval<CqlDate> eb_ = context.Operators.Interval(ds_, ea_, true, false);
                bool? ec_ = eb_?.highClosed;
                CqlInterval<CqlDateTime> ed_ = context.Operators.Interval(cf_, cw_, dm_, ec_);
                return ed_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> ee_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");
                return ee_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> ef_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");
                return ef_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            };
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

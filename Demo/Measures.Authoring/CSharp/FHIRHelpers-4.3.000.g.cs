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
[CqlLibrary("FHIRHelpers", "4.3.000")]
public partial class FHIRHelpers_4_3_000 : ILibrary, ISingleton<FHIRHelpers_4_3_000>
{
    private FHIRHelpers_4_3_000() {}

    public static FHIRHelpers_4_3_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FHIRHelpers";
    public string Version => "4.3.000";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

    #region Expressions

    [CqlExpressionDefinition("ToInterval")]
    [CqlTag("description", "Converts the given [Period](https://hl7.org/fhir/datatypes.html#Period)\nvalue to a CQL DateTime Interval")]
    [CqlTag("comment", "If the start value of the given period is unspecified, the starting\nboundary of the resulting interval will be open (meaning the start of the interval\nis unknown, as opposed to interpreted as the beginning of time).")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, Period period)
    {
        CqlInterval<CqlDateTime> a_()
        {
            if (period is null)
            {
                return null as CqlInterval<CqlDateTime>;
            }
            else if (period?.StartElement is null)
            {
                FhirDateTime b_ = period?.StartElement;
                CqlDateTime c_ = context.Operators.Convert<CqlDateTime>(b_);
                FhirDateTime d_ = period?.EndElement;
                CqlDateTime e_ = context.Operators.Convert<CqlDateTime>(d_);
                CqlInterval<CqlDateTime> f_ = context.Operators.Interval(c_, e_, false, true);

                return f_;
            }
            else
            {
                FhirDateTime g_ = period?.StartElement;
                CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
                FhirDateTime i_ = period?.EndElement;
                CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                CqlInterval<CqlDateTime> k_ = context.Operators.Interval(h_, j_, true, true);

                return k_;
            }
        };

        return a_();
    }


    [CqlExpressionDefinition("ToInterval")]
    [CqlTag("description", "Converts the given FHIR [Quantity](https://hl7.org/fhir/datatypes.html#Quantity) value to a CQL Interval of Quantity.")]
    [CqlTag("comment", "If the given quantity has a comparator, it is used to construct an interval based on the value of the comparator. If the comparator\nis less than, the resulting interval will start with a null closed boundary and end with an open boundary on the quantity. If the comparator\nis less than or equal, the resulting interval will start with a null closed boundary and end with a closed boundary on the quantity. If the \ncomparator is greater or equal, the resulting interval will start with a closed boundary on the quantity and end with a closed null boundary.\nIf the comparator is greatter than, the resulting interval will start with an open boundary on the quantity and end with a closed null boundary.\nIf no comparator is specified, the resulting interval will start and end with a closed boundary on the quantity.")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Quantity quantity)
    {
        CqlInterval<CqlQuantity> l_()
        {
            if (quantity is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {
                CqlInterval<CqlQuantity> m_()
                {
                    bool n_()
                    {
                        Code<Quantity.QuantityComparator> r_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? s_ = r_?.Value;
                        string t_ = context.Operators.Convert<string>(s_);
                        bool? u_ = context.Operators.Equal(t_, "<");

                        return u_ ?? false;
                    };
                    bool o_()
                    {
                        Code<Quantity.QuantityComparator> v_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? w_ = v_?.Value;
                        string x_ = context.Operators.Convert<string>(w_);
                        bool? y_ = context.Operators.Equal(x_, "<=");

                        return y_ ?? false;
                    };
                    bool p_()
                    {
                        Code<Quantity.QuantityComparator> z_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? aa_ = z_?.Value;
                        string ab_ = context.Operators.Convert<string>(aa_);
                        bool? ac_ = context.Operators.Equal(ab_, ">=");

                        return ac_ ?? false;
                    };
                    bool q_()
                    {
                        Code<Quantity.QuantityComparator> ad_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? ae_ = ad_?.Value;
                        string af_ = context.Operators.Convert<string>(ae_);
                        bool? ag_ = context.Operators.Equal(af_, ">");

                        return ag_ ?? false;
                    };
                    if (n_())
                    {
                        CqlQuantity ah_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> ai_ = context.Operators.Interval(default, ah_, true, false);

                        return ai_;
                    }
                    else if (o_())
                    {
                        CqlQuantity aj_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> ak_ = context.Operators.Interval(default, aj_, true, true);

                        return ak_;
                    }
                    else if (p_())
                    {
                        CqlQuantity al_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> am_ = context.Operators.Interval(al_, default, true, true);

                        return am_;
                    }
                    else if (q_())
                    {
                        CqlQuantity an_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> ao_ = context.Operators.Interval(an_, default, false, true);

                        return ao_;
                    }
                    else
                    {
                        CqlQuantity ap_ = this.ToQuantity(context, quantity);
                        CqlInterval<CqlQuantity> ar_ = context.Operators.Interval(ap_, ap_, true, true);

                        return ar_;
                    }
                };

                return m_();
            }
        };

        return l_();
    }


    [CqlExpressionDefinition("ToInterval")]
    [CqlTag("description", "Converts the given FHIR [Range](https://hl7.org/fhir/datatypes.html#Range) value to a CQL Interval of Quantity")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Range range)
    {
        CqlInterval<CqlQuantity> as_()
        {
            if (range is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {
                Quantity at_ = range?.Low;
                CqlQuantity au_ = this.ToQuantity(context, at_);
                Quantity av_ = range?.High;
                CqlQuantity aw_ = this.ToQuantity(context, av_);
                CqlInterval<CqlQuantity> ax_ = context.Operators.Interval(au_, aw_, true, true);

                return ax_;
            }
        };

        return as_();
    }


    [CqlExpressionDefinition("ToCalendarUnit")]
    [CqlTag("description", "Converts a UCUM definite duration unit to a CQL calendar duration\nunit using conversions specified in the [quantities](https://cql.hl7.org/02-authorsguide.html#quantities) \ntopic of the CQL specification.")]
    [CqlTag("comment", "Note that for durations above days (or weeks), the conversion is understood to be approximate")]
    public string ToCalendarUnit(CqlContext context, string unit)
    {
        string ay_()
        {
            if ((context.Operators.Equal(unit, "ms")) ?? false)
            {
                return "millisecond";
            }
            else if ((context.Operators.Equal(unit, "s")) ?? false)
            {
                return "second";
            }
            else if ((context.Operators.Equal(unit, "min")) ?? false)
            {
                return "minute";
            }
            else if ((context.Operators.Equal(unit, "h")) ?? false)
            {
                return "hour";
            }
            else if ((context.Operators.Equal(unit, "d")) ?? false)
            {
                return "day";
            }
            else if ((context.Operators.Equal(unit, "wk")) ?? false)
            {
                return "week";
            }
            else if ((context.Operators.Equal(unit, "mo")) ?? false)
            {
                return "month";
            }
            else if ((context.Operators.Equal(unit, "a")) ?? false)
            {
                return "year";
            }
            else
            {
                return unit;
            }
        };

        return ay_();
    }


    [CqlExpressionDefinition("ToQuantity")]
    [CqlTag("description", "Converts the given FHIR [Quantity](https://hl7.org/fhir/datatypes.html#Quantity) \nvalue to a CQL Quantity")]
    [CqlTag("comment", "If the given quantity has a comparator specified, a runtime error is raised. If the given quantity\nhas a system other than UCUM (i.e. `http://unitsofmeasure.org`) or CQL calendar units (i.e. `http://hl7.org/fhirpath/CodeSystem/calendar-units`)\nan error is raised. For UCUM to calendar units, the `ToCalendarUnit` function is used.")]
    [CqlTag("seealso", "ToCalendarUnit")]
    public CqlQuantity ToQuantity(CqlContext context, Quantity quantity)
    {
        CqlQuantity az_()
        {
            bool ba_()
            {
                Code<Quantity.QuantityComparator> bc_ = quantity?.ComparatorElement;
                bool? bd_ = context.Operators.Not((bool?)(bc_ is null));

                return bd_ ?? false;
            };
            bool bb_()
            {
                FhirUri be_ = quantity?.SystemElement;
                string bg_ = be_?.Value;
                bool? bh_ = context.Operators.Equal(bg_, "http://unitsofmeasure.org");
                bool? bi_ = context.Operators.Or((bool?)(be_ is null), bh_);
                string bk_ = be_?.Value;
                bool? bl_ = context.Operators.Equal(bk_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
                bool? bm_ = context.Operators.Or(bi_, bl_);

                return bm_ ?? false;
            };
            if (quantity is null)
            {
                return default;
            }
            else if (quantity?.ValueElement is null)
            {
                return default;
            }
            else if (ba_())
            {
                object bn_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.ComparatorQuantityNotSupported", "Error", "FHIR Quantity value has a comparator and cannot be converted to a System.Quantity value.");

                return bn_ as CqlQuantity;
            }
            else if (bb_())
            {
                FhirDecimal bo_ = quantity?.ValueElement;
                decimal? bp_ = bo_?.Value;
                Code bq_ = quantity?.CodeElement;
                string br_ = bq_?.Value;
                FhirString bs_ = quantity?.UnitElement;
                string bt_ = bs_?.Value;
                string bu_ = this.ToCalendarUnit(context, (br_ ?? bt_) ?? "1");

                return new CqlQuantity(bp_, bu_);
            }
            else
            {
                FhirString bv_ = quantity?.UnitElement;
                string bw_ = bv_?.Value;
                string bx_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", bw_ ?? "");
                string by_ = context.Operators.Concatenate(bx_ ?? "", " (");
                FhirUri bz_ = quantity?.SystemElement;
                string ca_ = bz_?.Value;
                string cb_ = context.Operators.Concatenate(by_ ?? "", ca_ ?? "");
                string cc_ = context.Operators.Concatenate(cb_ ?? "", "|");
                Code cd_ = quantity?.CodeElement;
                string ce_ = cd_?.Value;
                string cf_ = context.Operators.Concatenate(cc_ ?? "", ce_ ?? "");
                string cg_ = context.Operators.Concatenate(cf_ ?? "", ")");
                object ch_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", cg_);

                return ch_ as CqlQuantity;
            }
        };

        return az_();
    }


    [CqlExpressionDefinition("ToQuantityIgnoringComparator")]
    [CqlTag("description", "Converts the given FHIR [Quantity](https://hl7.org/fhir/datatypes.html#Quantity) value to a CQL Quantity, ignoring\nthe comparator element. This function should only be used when an application is justified in ignoring the comparator value (i.e. the\ncontext is looking for boundary).")]
    [CqlTag("comment", "If the given quantity has a system other than UCUM (i.e. `http://unitsofmeasure.org`) or CQL calendar units \n(i.e. `http://hl7.org/fhirpath/CodeSystem/calendar-units`) an error is raised. For UCUM to calendar units, the `ToCalendarUnit` function \nis used.")]
    [CqlTag("seealso", "ToCalendarUnit")]
    public CqlQuantity ToQuantityIgnoringComparator(CqlContext context, Quantity quantity)
    {
        CqlQuantity ci_()
        {
            bool cj_()
            {
                FhirUri ck_ = quantity?.SystemElement;
                string cm_ = ck_?.Value;
                bool? cn_ = context.Operators.Equal(cm_, "http://unitsofmeasure.org");
                bool? co_ = context.Operators.Or((bool?)(ck_ is null), cn_);
                string cq_ = ck_?.Value;
                bool? cr_ = context.Operators.Equal(cq_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
                bool? cs_ = context.Operators.Or(co_, cr_);

                return cs_ ?? false;
            };
            if (quantity is null)
            {
                return default;
            }
            else if (quantity?.ValueElement is null)
            {
                return default;
            }
            else if (cj_())
            {
                FhirDecimal ct_ = quantity?.ValueElement;
                decimal? cu_ = ct_?.Value;
                Code cv_ = quantity?.CodeElement;
                string cw_ = cv_?.Value;
                FhirString cx_ = quantity?.UnitElement;
                string cy_ = cx_?.Value;
                string cz_ = this.ToCalendarUnit(context, (cw_ ?? cy_) ?? "1");

                return new CqlQuantity(cu_, cz_);
            }
            else
            {
                FhirString da_ = quantity?.UnitElement;
                string db_ = da_?.Value;
                string dc_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", db_ ?? "");
                string dd_ = context.Operators.Concatenate(dc_ ?? "", " (");
                FhirUri de_ = quantity?.SystemElement;
                string df_ = de_?.Value;
                string dg_ = context.Operators.Concatenate(dd_ ?? "", df_ ?? "");
                string dh_ = context.Operators.Concatenate(dg_ ?? "", "|");
                Code di_ = quantity?.CodeElement;
                string dj_ = di_?.Value;
                string dk_ = context.Operators.Concatenate(dh_ ?? "", dj_ ?? "");
                string dl_ = context.Operators.Concatenate(dk_ ?? "", ")");
                object dm_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", dl_);

                return dm_ as CqlQuantity;
            }
        };

        return ci_();
    }


    [CqlExpressionDefinition("ToRatio")]
    [CqlTag("description", "Converts the given FHIR [Ratio](https://hl7.org/fhir/datatypes.html#Ratio) value to a CQL Ratio.")]
    public CqlRatio ToRatio(CqlContext context, Ratio ratio)
    {
        CqlRatio dn_()
        {
            if (ratio is null)
            {
                return default;
            }
            else
            {
                Quantity do_ = ratio?.Numerator;
                CqlQuantity dp_ = this.ToQuantity(context, do_);
                Quantity dq_ = ratio?.Denominator;
                CqlQuantity dr_ = this.ToQuantity(context, dq_);

                return new CqlRatio(dp_, dr_);
            }
        };

        return dn_();
    }


    [CqlExpressionDefinition("ToCode")]
    [CqlTag("description", "Converts the given FHIR [Coding](https://hl7.org/fhir/datatypes.html#Coding) value to a CQL Code.")]
    public CqlCode ToCode(CqlContext context, Coding coding)
    {
        CqlCode ds_()
        {
            if (coding is null)
            {
                return default;
            }
            else
            {
                Code dt_ = coding?.CodeElement;
                string du_ = dt_?.Value;
                FhirUri dv_ = coding?.SystemElement;
                string dw_ = dv_?.Value;
                FhirString dx_ = coding?.VersionElement;
                string dy_ = dx_?.Value;
                FhirString dz_ = coding?.DisplayElement;
                string ea_ = dz_?.Value;

                return new CqlCode(du_, dw_, dy_, ea_);
            }
        };

        return ds_();
    }


    [CqlExpressionDefinition("ToConcept")]
    [CqlTag("description", "Converts the given FHIR [CodeableConcept](https://hl7.org/fhir/datatypes.html#CodeableConcept) value to a CQL Concept.")]
    public CqlConcept ToConcept(CqlContext context, CodeableConcept concept)
    {
        CqlConcept eb_()
        {
            if (concept is null)
            {
                return default;
            }
            else
            {
                List<Coding> ec_ = concept?.Coding;
                CqlCode ed_(Coding C)
                {
                    CqlCode ei_ = this.ToCode(context, C);

                    return ei_;
                };
                IEnumerable<CqlCode> ee_ = context.Operators.Select<Coding, CqlCode>((IEnumerable<Coding>)ec_, ed_);
                IEnumerable<CqlCode> ef_ = context.Operators.Distinct<CqlCode>(ee_);
                FhirString eg_ = concept?.TextElement;
                string eh_ = eg_?.Value;

                return new CqlConcept(ef_, eh_);
            }
        };

        return eb_();
    }


    [CqlExpressionDefinition("ToValueSet")]
    [CqlTag("description", "Converts the given value (assumed to be a URI) to a CQL [ValueSet](https://cql.hl7.org/09-b-cqlreference.html#valueset)")]
    public CqlValueSet ToValueSet(CqlContext context, string uri) =>
        (uri is null
            ? default
            : new CqlValueSet(uri, default));


    [CqlExpressionDefinition("reference")]
    [CqlTag("description", "Constructs a FHIR [Reference](https://hl7.org/fhir/datatypes.html#Reference) from the given reference (assumed to be a FHIR resource URL)")]
    public ResourceReference reference(CqlContext context, string reference)
    {
        ResourceReference ej_()
        {
            if (reference is null)
            {
                return default;
            }
            else
            {
                ResourceReference ek_ = new ResourceReference
                {
                    ReferenceElement = new FhirString(reference),
                };

                return ek_;
            }
        };

        return ej_();
    }


    #endregion Expressions

    #region Functions

    [CqlFunctionDefinition("reference")]
    public ResourceReference reference(CqlContext context, Resource resource) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.reference is not implemented."));


    #endregion Functions

    #region Expressions

    [CqlExpressionDefinition("ToValue")]
    [CqlTag("description", "Converts the given value to a CQL value using the appropriate accessor or conversion function.")]
    [CqlTag("comment", "TODO: document conversion")]
    public object ToValue(CqlContext context, object value)
    {
        object el_()
        {
            if (value is Base64Binary)
            {
                byte[] em_ = (value as Base64Binary)?.Value;
                string en_ = context.Operators.Convert<string>(em_);

                return en_ as object;
            }
            else if (value is FhirBoolean)
            {
                bool? eo_ = (value as FhirBoolean)?.Value;

                return eo_;
            }
            else if (value is Canonical)
            {
                string ep_ = (value as Canonical)?.Value;

                return ep_ as object;
            }
            else if (value is Code)
            {
                string eq_ = (value as Code)?.Value;

                return eq_ as object;
            }
            else if (value is Date)
            {
                string er_ = (value as Date)?.Value;
                CqlDate es_ = context.Operators.ConvertStringToDate(er_);

                return es_ as object;
            }
            else if (value is FhirDateTime)
            {
                CqlDateTime et_ = context.Operators.Convert<CqlDateTime>(value as FhirDateTime);

                return et_ as object;
            }
            else if (value is FhirDecimal)
            {
                decimal? eu_ = (value as FhirDecimal)?.Value;

                return eu_;
            }
            else if (value is Id)
            {
                string ev_ = (value as Id)?.Value;

                return ev_ as object;
            }
            else if (value is Instant)
            {
                DateTimeOffset? ew_ = (value as Instant)?.Value;
                CqlDateTime ex_ = context.Operators.Convert<CqlDateTime>(ew_);

                return ex_ as object;
            }
            else if (value is Integer)
            {
                int? ey_ = (value as Integer)?.Value;

                return ey_;
            }
            else if (value is Markdown)
            {
                string ez_ = (value as Markdown)?.Value;

                return ez_ as object;
            }
            else if (value is Oid)
            {
                string fa_ = (value as Oid)?.Value;

                return fa_ as object;
            }
            else if (value is Integer)
            {
                int? fb_ = (value as Integer)?.Value;

                return fb_;
            }
            else if (value is FhirString)
            {
                string fc_ = (value as FhirString)?.Value;

                return fc_ as object;
            }
            else if (value is Time)
            {
                string fd_ = (value as Time)?.Value;
                CqlTime fe_ = context.Operators.ConvertStringToTime(fd_);

                return fe_ as object;
            }
            else if (value is Integer)
            {
                int? ff_ = (value as Integer)?.Value;

                return ff_;
            }
            else if (value is FhirUri)
            {
                string fg_ = (value as FhirUri)?.Value;

                return fg_ as object;
            }
            else if (value is FhirUrl)
            {
                string fh_ = (value as FhirUrl)?.Value;

                return fh_ as object;
            }
            else if (value is Uuid)
            {
                string fi_ = (value as Uuid)?.Value;

                return fi_ as object;
            }
            else if (value is Age)
            {
                CqlQuantity fj_ = this.ToQuantity(context, value as Age);

                return fj_ as object;
            }
            else if (value is CodeableConcept)
            {
                CqlConcept fk_ = this.ToConcept(context, value as CodeableConcept);

                return fk_ as object;
            }
            else if (value is Coding)
            {
                CqlCode fl_ = this.ToCode(context, value as Coding);

                return fl_ as object;
            }
            else if (value is Count)
            {
                CqlQuantity fm_ = this.ToQuantity(context, value as Count);

                return fm_ as object;
            }
            else if (value is Distance)
            {
                CqlQuantity fn_ = this.ToQuantity(context, value as Distance);

                return fn_ as object;
            }
            else if (value is Duration)
            {
                CqlQuantity fo_ = this.ToQuantity(context, value as Duration);

                return fo_ as object;
            }
            else if (value is Quantity)
            {
                CqlQuantity fp_ = this.ToQuantity(context, value as Quantity);

                return fp_ as object;
            }
            else if (value is Range)
            {
                CqlInterval<CqlQuantity> fq_ = this.ToInterval(context, value as Range);

                return fq_ as object;
            }
            else if (value is Period)
            {
                CqlInterval<CqlDateTime> fr_ = this.ToInterval(context, value as Period);

                return fr_ as object;
            }
            else if (value is Ratio)
            {
                CqlRatio fs_ = this.ToRatio(context, value as Ratio);

                return fs_ as object;
            }
            else
            {
                return value as object;
            }
        };

        return el_();
    }


    #endregion Expressions

    #region Functions

    [CqlFunctionDefinition("resolve")]
    public Resource resolve(CqlContext context, string reference) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.resolve is not implemented."));


    [CqlFunctionDefinition("resolve")]
    public Resource resolve(CqlContext context, ResourceReference reference) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.resolve is not implemented."));


    [CqlFunctionDefinition("extension")]
    public IEnumerable<Extension> extension(CqlContext context, Element element, string url) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.extension is not implemented."));


    [CqlFunctionDefinition("extension")]
    public IEnumerable<Extension> extension(CqlContext context, DomainResource resource, string url) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.extension is not implemented."));


    [CqlFunctionDefinition("modifierExtension")]
    public IEnumerable<Extension> modifierExtension(CqlContext context, BackboneElement element, string url) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.modifierExtension is not implemented."));


    [CqlFunctionDefinition("modifierExtension")]
    public IEnumerable<Extension> modifierExtension(CqlContext context, DomainResource resource, string url) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.modifierExtension is not implemented."));


    [CqlFunctionDefinition("hasValue")]
    public bool? hasValue(CqlContext context, Element element) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.hasValue is not implemented."));


    [CqlFunctionDefinition("getValue")]
    public object getValue(CqlContext context, Element element) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.getValue is not implemented."));


    [CqlFunctionDefinition("ofType")]
    public IEnumerable<object> ofType(CqlContext context, string identifier) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.ofType is not implemented."));


    [CqlFunctionDefinition("is")]
    public bool? @is(CqlContext context, string identifier) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.is is not implemented."));


    [CqlFunctionDefinition("as")]
    public object @as(CqlContext context, string identifier) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.as is not implemented."));


    [CqlFunctionDefinition("elementDefinition")]
    public ElementDefinition elementDefinition(CqlContext context, Element element) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.elementDefinition is not implemented."));


    [CqlFunctionDefinition("slice")]
    public IEnumerable<Element> slice(CqlContext context, Element element, string url, string name) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.slice is not implemented."));


    [CqlFunctionDefinition("checkModifiers")]
    public Resource checkModifiers(CqlContext context, Resource resource) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));


    [CqlFunctionDefinition("checkModifiers")]
    public Resource checkModifiers(CqlContext context, Resource resource, string modifier) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));


    [CqlFunctionDefinition("checkModifiers")]
    public Element checkModifiers(CqlContext context, Element element) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));


    [CqlFunctionDefinition("checkModifiers")]
    public Element checkModifiers(CqlContext context, Element element, string modifier) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));


    [CqlFunctionDefinition("conformsTo")]
    public bool? conformsTo(CqlContext context, Resource resource, string structure) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.conformsTo is not implemented."));


    [CqlFunctionDefinition("memberOf")]
    public bool? memberOf(CqlContext context, Code code, string valueSet) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));


    [CqlFunctionDefinition("memberOf")]
    public bool? memberOf(CqlContext context, Coding coding, string valueSet) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));


    [CqlFunctionDefinition("memberOf")]
    public bool? memberOf(CqlContext context, CodeableConcept concept, string valueSet) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));


    [CqlFunctionDefinition("subsumes")]
    public bool? subsumes(CqlContext context, Coding coding, Coding subsumedCoding) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumes is not implemented."));


    [CqlFunctionDefinition("subsumes")]
    public bool? subsumes(CqlContext context, CodeableConcept concept, CodeableConcept subsumedConcept) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumes is not implemented."));


    [CqlFunctionDefinition("subsumedBy")]
    public bool? subsumedBy(CqlContext context, Coding coding, Coding subsumingCoding) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumedBy is not implemented."));


    [CqlFunctionDefinition("subsumedBy")]
    public bool? subsumedBy(CqlContext context, CodeableConcept concept, CodeableConcept subsumingConcept) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumedBy is not implemented."));


    [CqlFunctionDefinition("htmlChecks")]
    public bool? htmlChecks(CqlContext context, Element element) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.htmlChecks is not implemented."));


    #endregion Functions

    #region Expressions

    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Account.AccountStatus> value)
    {
        Account.AccountStatus? ft_ = value?.Value;
        string fu_ = context.Operators.Convert<string>(ft_);

        return fu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionCardinalityBehavior> value)
    {
        ActionCardinalityBehavior? fv_ = value?.Value;
        string fw_ = context.Operators.Convert<string>(fv_);

        return fw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionConditionKind> value)
    {
        ActionConditionKind? fx_ = value?.Value;
        string fy_ = context.Operators.Convert<string>(fx_);

        return fy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionGroupingBehavior> value)
    {
        ActionGroupingBehavior? fz_ = value?.Value;
        string ga_ = context.Operators.Convert<string>(fz_);

        return ga_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionParticipantType> value)
    {
        ActionParticipantType? gb_ = value?.Value;
        string gc_ = context.Operators.Convert<string>(gb_);

        return gc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionPrecheckBehavior> value)
    {
        ActionPrecheckBehavior? gd_ = value?.Value;
        string ge_ = context.Operators.Convert<string>(gd_);

        return ge_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionRelationshipType> value)
    {
        ActionRelationshipType? gf_ = value?.Value;
        string gg_ = context.Operators.Convert<string>(gf_);

        return gg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionRequiredBehavior> value)
    {
        ActionRequiredBehavior? gh_ = value?.Value;
        string gi_ = context.Operators.Convert<string>(gh_);

        return gi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionSelectionBehavior> value)
    {
        ActionSelectionBehavior? gj_ = value?.Value;
        string gk_ = context.Operators.Convert<string>(gj_);

        return gk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActivityDefinition.RequestResourceType> value)
    {
        ActivityDefinition.RequestResourceType? gl_ = value?.Value;
        string gm_ = context.Operators.Convert<string>(gl_);

        return gm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Address.AddressType> value)
    {
        Address.AddressType? gn_ = value?.Value;
        string go_ = context.Operators.Convert<string>(gn_);

        return go_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Address.AddressUse> value)
    {
        Address.AddressUse? gp_ = value?.Value;
        string gq_ = context.Operators.Convert<string>(gp_);

        return gq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AdministrativeGender> value)
    {
        AdministrativeGender? gr_ = value?.Value;
        string gs_ = context.Operators.Convert<string>(gr_);

        return gs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AdverseEvent.AdverseEventActuality> value)
    {
        AdverseEvent.AdverseEventActuality? gt_ = value?.Value;
        string gu_ = context.Operators.Convert<string>(gt_);

        return gu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.AggregationMode> value)
    {
        ElementDefinition.AggregationMode? gv_ = value?.Value;
        string gw_ = context.Operators.Convert<string>(gv_);

        return gw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
    {
        AllergyIntolerance.AllergyIntoleranceCategory? gx_ = value?.Value;
        string gy_ = context.Operators.Convert<string>(gx_);

        return gy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
    {
        AllergyIntolerance.AllergyIntoleranceCriticality? gz_ = value?.Value;
        string ha_ = context.Operators.Convert<string>(gz_);

        return ha_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
    {
        AllergyIntolerance.AllergyIntoleranceSeverity? hb_ = value?.Value;
        string hc_ = context.Operators.Convert<string>(hb_);

        return hc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceType> value)
    {
        AllergyIntolerance.AllergyIntoleranceType? hd_ = value?.Value;
        string he_ = context.Operators.Convert<string>(hd_);

        return he_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Appointment.AppointmentStatus> value)
    {
        Appointment.AppointmentStatus? hf_ = value?.Value;
        string hg_ = context.Operators.Convert<string>(hf_);

        return hg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionDirectionType> value)
    {
        TestScript.AssertionDirectionType? hh_ = value?.Value;
        string hi_ = context.Operators.Convert<string>(hh_);

        return hi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionOperatorType> value)
    {
        TestScript.AssertionOperatorType? hj_ = value?.Value;
        string hk_ = context.Operators.Convert<string>(hj_);

        return hk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionResponseTypes> value)
    {
        TestScript.AssertionResponseTypes? hl_ = value?.Value;
        string hm_ = context.Operators.Convert<string>(hl_);

        return hm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAction> value)
    {
        AuditEvent.AuditEventAction? hn_ = value?.Value;
        string ho_ = context.Operators.Convert<string>(hn_);

        return ho_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAgentNetworkType> value)
    {
        AuditEvent.AuditEventAgentNetworkType? hp_ = value?.Value;
        string hq_ = context.Operators.Convert<string>(hp_);

        return hq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventOutcome> value)
    {
        AuditEvent.AuditEventOutcome? hr_ = value?.Value;
        string hs_ = context.Operators.Convert<string>(hr_);

        return hs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BindingStrength> value)
    {
        BindingStrength? ht_ = value?.Value;
        string hu_ = context.Operators.Convert<string>(ht_);

        return hu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? hv_ = value?.Value;
        string hw_ = context.Operators.Convert<string>(hv_);

        return hw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? hx_ = value?.Value;
        string hy_ = context.Operators.Convert<string>(hx_);

        return hy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? hz_ = value?.Value;
        string ia_ = context.Operators.Convert<string>(hz_);

        return ia_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.BundleType> value)
    {
        Bundle.BundleType? ib_ = value?.Value;
        string ic_ = context.Operators.Convert<string>(ib_);

        return ic_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatementKind> value)
    {
        CapabilityStatementKind? id_ = value?.Value;
        string ie_ = context.Operators.Convert<string>(id_);

        return ie_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityKind> value)
    {
        CarePlan.CarePlanActivityKind? if_ = value?.Value;
        string ig_ = context.Operators.Convert<string>(if_);

        return ig_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityStatus> value)
    {
        CarePlan.CarePlanActivityStatus? ih_ = value?.Value;
        string ii_ = context.Operators.Convert<string>(ih_);

        return ii_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanIntent> value)
    {
        CarePlan.CarePlanIntent? ij_ = value?.Value;
        string ik_ = context.Operators.Convert<string>(ij_);

        return ik_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestStatus> value)
    {
        RequestStatus? il_ = value?.Value;
        string im_ = context.Operators.Convert<string>(il_);

        return im_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CareTeam.CareTeamStatus> value)
    {
        CareTeam.CareTeamStatus? in_ = value?.Value;
        string io_ = context.Operators.Convert<string>(in_);

        return io_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CatalogEntry.CatalogEntryRelationType> value)
    {
        CatalogEntry.CatalogEntryRelationType? ip_ = value?.Value;
        string iq_ = context.Operators.Convert<string>(ip_);

        return iq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<InvoicePriceComponentType> value)
    {
        InvoicePriceComponentType? ir_ = value?.Value;
        string is_ = context.Operators.Convert<string>(ir_);

        return is_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ChargeItem.ChargeItemStatus> value)
    {
        ChargeItem.ChargeItemStatus? it_ = value?.Value;
        string iu_ = context.Operators.Convert<string>(it_);

        return iu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FinancialResourceStatusCodes> value)
    {
        FinancialResourceStatusCodes? iv_ = value?.Value;
        string iw_ = context.Operators.Convert<string>(iv_);

        return iw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClinicalImpression.ClinicalImpressionStatus> value)
    {
        ClinicalImpression.ClinicalImpressionStatus? ix_ = value?.Value;
        string iy_ = context.Operators.Convert<string>(ix_);

        return iy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TerminologyCapabilities.CodeSearchSupport> value)
    {
        TerminologyCapabilities.CodeSearchSupport? iz_ = value?.Value;
        string ja_ = context.Operators.Convert<string>(iz_);

        return ja_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystemContentMode> value)
    {
        CodeSystemContentMode? jb_ = value?.Value;
        string jc_ = context.Operators.Convert<string>(jb_);

        return jc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystem.CodeSystemHierarchyMeaning> value)
    {
        CodeSystem.CodeSystemHierarchyMeaning? jd_ = value?.Value;
        string je_ = context.Operators.Convert<string>(jd_);

        return je_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestPriority> value)
    {
        RequestPriority? jf_ = value?.Value;
        string jg_ = context.Operators.Convert<string>(jf_);

        return jg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EventStatus> value)
    {
        EventStatus? jh_ = value?.Value;
        string ji_ = context.Operators.Convert<string>(jh_);

        return ji_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CompartmentType> value)
    {
        CompartmentType? jj_ = value?.Value;
        string jk_ = context.Operators.Convert<string>(jj_);

        return jk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Composition.CompositionAttestationMode> value)
    {
        Composition.CompositionAttestationMode? jl_ = value?.Value;
        string jm_ = context.Operators.Convert<string>(jl_);

        return jm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CompositionStatus> value)
    {
        CompositionStatus? jn_ = value?.Value;
        string jo_ = context.Operators.Convert<string>(jn_);

        return jo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConceptMapEquivalence> value)
    {
        ConceptMapEquivalence? jp_ = value?.Value;
        string jq_ = context.Operators.Convert<string>(jp_);

        return jq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
    {
        ConceptMap.ConceptMapGroupUnmappedMode? jr_ = value?.Value;
        string js_ = context.Operators.Convert<string>(jr_);

        return js_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalDeleteStatus> value)
    {
        CapabilityStatement.ConditionalDeleteStatus? jt_ = value?.Value;
        string ju_ = context.Operators.Convert<string>(jt_);

        return ju_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalReadStatus> value)
    {
        CapabilityStatement.ConditionalReadStatus? jv_ = value?.Value;
        string jw_ = context.Operators.Convert<string>(jv_);

        return jw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentDataMeaning> value)
    {
        Consent.ConsentDataMeaning? jx_ = value?.Value;
        string jy_ = context.Operators.Convert<string>(jx_);

        return jy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentProvisionType> value)
    {
        Consent.ConsentProvisionType? jz_ = value?.Value;
        string ka_ = context.Operators.Convert<string>(jz_);

        return ka_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentState> value)
    {
        Consent.ConsentState? kb_ = value?.Value;
        string kc_ = context.Operators.Convert<string>(kb_);

        return kc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConstraintSeverity> value)
    {
        ConstraintSeverity? kd_ = value?.Value;
        string ke_ = context.Operators.Convert<string>(kd_);

        return ke_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointSystem> value)
    {
        ContactPoint.ContactPointSystem? kf_ = value?.Value;
        string kg_ = context.Operators.Convert<string>(kf_);

        return kg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointUse> value)
    {
        ContactPoint.ContactPointUse? kh_ = value?.Value;
        string ki_ = context.Operators.Convert<string>(kh_);

        return ki_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contract.ContractResourcePublicationStatusCodes> value)
    {
        Contract.ContractResourcePublicationStatusCodes? kj_ = value?.Value;
        string kk_ = context.Operators.Convert<string>(kj_);

        return kk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contract.ContractResourceStatusCodes> value)
    {
        Contract.ContractResourceStatusCodes? kl_ = value?.Value;
        string km_ = context.Operators.Convert<string>(kl_);

        return km_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contributor.ContributorType> value)
    {
        Contributor.ContributorType? kn_ = value?.Value;
        string ko_ = context.Operators.Convert<string>(kn_);

        return ko_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Money.Currencies> value)
    {
        Money.Currencies? kp_ = value?.Value;
        string kq_ = context.Operators.Convert<string>(kp_);

        return kq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DaysOfWeek> value)
    {
        DaysOfWeek? kr_ = value?.Value;
        string ks_ = context.Operators.Convert<string>(kr_);

        return ks_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DetectedIssue.DetectedIssueSeverity> value)
    {
        DetectedIssue.DetectedIssueSeverity? kt_ = value?.Value;
        string ku_ = context.Operators.Convert<string>(kt_);

        return ku_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationStatus> value)
    {
        ObservationStatus? kv_ = value?.Value;
        string kw_ = context.Operators.Convert<string>(kv_);

        return kw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationState> value)
    {
        DeviceMetric.DeviceMetricCalibrationState? kx_ = value?.Value;
        string ky_ = context.Operators.Convert<string>(kx_);

        return ky_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationType> value)
    {
        DeviceMetric.DeviceMetricCalibrationType? kz_ = value?.Value;
        string la_ = context.Operators.Convert<string>(kz_);

        return la_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCategory> value)
    {
        DeviceMetric.DeviceMetricCategory? lb_ = value?.Value;
        string lc_ = context.Operators.Convert<string>(lb_);

        return lc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricColor> value)
    {
        DeviceMetric.DeviceMetricColor? ld_ = value?.Value;
        string le_ = context.Operators.Convert<string>(ld_);

        return le_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricOperationalStatus> value)
    {
        DeviceMetric.DeviceMetricOperationalStatus? lf_ = value?.Value;
        string lg_ = context.Operators.Convert<string>(lf_);

        return lg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceNameType> value)
    {
        DeviceNameType? lh_ = value?.Value;
        string li_ = context.Operators.Convert<string>(lh_);

        return li_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceUseStatement.DeviceUseStatementStatus> value)
    {
        DeviceUseStatement.DeviceUseStatementStatus? lj_ = value?.Value;
        string lk_ = context.Operators.Convert<string>(lj_);

        return lk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DiagnosticReport.DiagnosticReportStatus> value)
    {
        DiagnosticReport.DiagnosticReportStatus? ll_ = value?.Value;
        string lm_ = context.Operators.Convert<string>(ll_);

        return lm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.DiscriminatorType> value)
    {
        ElementDefinition.DiscriminatorType? ln_ = value?.Value;
        string lo_ = context.Operators.Convert<string>(ln_);

        return lo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Composition.V3ConfidentialityClassification> value)
    {
        Composition.V3ConfidentialityClassification? lp_ = value?.Value;
        string lq_ = context.Operators.Convert<string>(lp_);

        return lq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.DocumentMode> value)
    {
        CapabilityStatement.DocumentMode? lr_ = value?.Value;
        string ls_ = context.Operators.Convert<string>(lr_);

        return ls_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DocumentReferenceStatus> value)
    {
        DocumentReferenceStatus? lt_ = value?.Value;
        string lu_ = context.Operators.Convert<string>(lt_);

        return lu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DocumentRelationshipType> value)
    {
        DocumentRelationshipType? lv_ = value?.Value;
        string lw_ = context.Operators.Convert<string>(lv_);

        return lw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
    {
        CoverageEligibilityRequest.EligibilityRequestPurpose? lx_ = value?.Value;
        string ly_ = context.Operators.Convert<string>(lx_);

        return ly_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
    {
        CoverageEligibilityResponse.EligibilityResponsePurpose? lz_ = value?.Value;
        string ma_ = context.Operators.Convert<string>(lz_);

        return ma_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.EnableWhenBehavior> value)
    {
        Questionnaire.EnableWhenBehavior? mb_ = value?.Value;
        string mc_ = context.Operators.Convert<string>(mb_);

        return mc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Encounter.EncounterLocationStatus> value)
    {
        Encounter.EncounterLocationStatus? md_ = value?.Value;
        string me_ = context.Operators.Convert<string>(md_);

        return me_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Encounter.EncounterStatus> value)
    {
        Encounter.EncounterStatus? mf_ = value?.Value;
        string mg_ = context.Operators.Convert<string>(mf_);

        return mg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Endpoint.EndpointStatus> value)
    {
        Endpoint.EndpointStatus? mh_ = value?.Value;
        string mi_ = context.Operators.Convert<string>(mh_);

        return mi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EpisodeOfCare.EpisodeOfCareStatus> value)
    {
        EpisodeOfCare.EpisodeOfCareStatus? mj_ = value?.Value;
        string mk_ = context.Operators.Convert<string>(mj_);

        return mk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.EventCapabilityMode> value)
    {
        CapabilityStatement.EventCapabilityMode? ml_ = value?.Value;
        string mm_ = context.Operators.Convert<string>(ml_);

        return mm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Timing.EventTiming> value)
    {
        Timing.EventTiming? mn_ = value?.Value;
        string mo_ = context.Operators.Convert<string>(mn_);

        return mo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VariableTypeCode> value)
    {
        VariableTypeCode? mp_ = value?.Value;
        string mq_ = context.Operators.Convert<string>(mp_);

        return mq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ExampleScenario.ExampleScenarioActorType> value)
    {
        ExampleScenario.ExampleScenarioActorType? mr_ = value?.Value;
        string ms_ = context.Operators.Convert<string>(mr_);

        return ms_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
    {
        ExplanationOfBenefit.ExplanationOfBenefitStatus? mt_ = value?.Value;
        string mu_ = context.Operators.Convert<string>(mt_);

        return mu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EffectEvidenceSynthesis.ExposureStateCode> value)
    {
        EffectEvidenceSynthesis.ExposureStateCode? mv_ = value?.Value;
        string mw_ = context.Operators.Convert<string>(mv_);

        return mw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.ExtensionContextType> value)
    {
        StructureDefinition.ExtensionContextType? mx_ = value?.Value;
        string my_ = context.Operators.Convert<string>(mx_);

        return my_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRAllTypes> value)
    {
        FHIRAllTypes? mz_ = value?.Value;
        string na_ = context.Operators.Convert<string>(mz_);

        return na_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRDefinedType> value)
    {
        FHIRDefinedType? nb_ = value?.Value;
        string nc_ = context.Operators.Convert<string>(nb_);

        return nc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Device.FHIRDeviceStatus> value)
    {
        Device.FHIRDeviceStatus? nd_ = value?.Value;
        string ne_ = context.Operators.Convert<string>(nd_);

        return ne_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResourceType> value)
    {
        ResourceType? nf_ = value?.Value;
        string ng_ = context.Operators.Convert<string>(nf_);

        return ng_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Substance.FHIRSubstanceStatus> value)
    {
        Substance.FHIRSubstanceStatus? nh_ = value?.Value;
        string ni_ = context.Operators.Convert<string>(nh_);

        return ni_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRVersion> value)
    {
        FHIRVersion? nj_ = value?.Value;
        string nk_ = context.Operators.Convert<string>(nj_);

        return nk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FamilyMemberHistory.FamilyHistoryStatus> value)
    {
        FamilyMemberHistory.FamilyHistoryStatus? nl_ = value?.Value;
        string nm_ = context.Operators.Convert<string>(nl_);

        return nm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FilterOperator> value)
    {
        FilterOperator? nn_ = value?.Value;
        string no_ = context.Operators.Convert<string>(nn_);

        return no_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Flag.FlagStatus> value)
    {
        Flag.FlagStatus? np_ = value?.Value;
        string nq_ = context.Operators.Convert<string>(np_);

        return nq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Goal.GoalLifecycleStatus> value)
    {
        Goal.GoalLifecycleStatus? nr_ = value?.Value;
        string ns_ = context.Operators.Convert<string>(nr_);

        return ns_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentRule> value)
    {
        GraphDefinition.GraphCompartmentRule? nt_ = value?.Value;
        string nu_ = context.Operators.Convert<string>(nt_);

        return nu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentUse> value)
    {
        GraphDefinition.GraphCompartmentUse? nv_ = value?.Value;
        string nw_ = context.Operators.Convert<string>(nv_);

        return nw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GroupMeasureCode> value)
    {
        GroupMeasureCode? nx_ = value?.Value;
        string ny_ = context.Operators.Convert<string>(nx_);

        return ny_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Group.GroupType> value)
    {
        Group.GroupType? nz_ = value?.Value;
        string oa_ = context.Operators.Convert<string>(nz_);

        return oa_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GuidanceResponse.GuidanceResponseStatus> value)
    {
        GuidanceResponse.GuidanceResponseStatus? ob_ = value?.Value;
        string oc_ = context.Operators.Convert<string>(ob_);

        return oc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.GuidePageGeneration> value)
    {
        ImplementationGuide.GuidePageGeneration? od_ = value?.Value;
        string oe_ = context.Operators.Convert<string>(od_);

        return oe_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.GuideParameterCode> value)
    {
        ImplementationGuide.GuideParameterCode? of_ = value?.Value;
        string og_ = context.Operators.Convert<string>(of_);

        return og_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.HTTPVerb> value)
    {
        Bundle.HTTPVerb? oh_ = value?.Value;
        string oi_ = context.Operators.Convert<string>(oh_);

        return oi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Identifier.IdentifierUse> value)
    {
        Identifier.IdentifierUse? oj_ = value?.Value;
        string ok_ = context.Operators.Convert<string>(oj_);

        return ok_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Person.IdentityAssuranceLevel> value)
    {
        Person.IdentityAssuranceLevel? ol_ = value?.Value;
        string om_ = context.Operators.Convert<string>(ol_);

        return om_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImagingStudy.ImagingStudyStatus> value)
    {
        ImagingStudy.ImagingStudyStatus? on_ = value?.Value;
        string oo_ = context.Operators.Convert<string>(on_);

        return oo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
    {
        ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? op_ = value?.Value;
        string oq_ = context.Operators.Convert<string>(op_);

        return oq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Immunization.ImmunizationStatusCodes> value)
    {
        Immunization.ImmunizationStatusCodes? or_ = value?.Value;
        string os_ = context.Operators.Convert<string>(or_);

        return os_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Invoice.InvoiceStatus> value)
    {
        Invoice.InvoiceStatus? ot_ = value?.Value;
        string ou_ = context.Operators.Convert<string>(ot_);

        return ou_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationOutcome.IssueSeverity> value)
    {
        OperationOutcome.IssueSeverity? ov_ = value?.Value;
        string ow_ = context.Operators.Convert<string>(ov_);

        return ow_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationOutcome.IssueType> value)
    {
        OperationOutcome.IssueType? ox_ = value?.Value;
        string oy_ = context.Operators.Convert<string>(ox_);

        return oy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Patient.LinkType> value)
    {
        Patient.LinkType? oz_ = value?.Value;
        string pa_ = context.Operators.Convert<string>(oz_);

        return pa_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Linkage.LinkageType> value)
    {
        Linkage.LinkageType? pb_ = value?.Value;
        string pc_ = context.Operators.Convert<string>(pb_);

        return pc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ListMode> value)
    {
        ListMode? pd_ = value?.Value;
        string pe_ = context.Operators.Convert<string>(pd_);

        return pe_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<List.ListStatus> value)
    {
        List.ListStatus? pf_ = value?.Value;
        string pg_ = context.Operators.Convert<string>(pf_);

        return pg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Location.LocationMode> value)
    {
        Location.LocationMode? ph_ = value?.Value;
        string pi_ = context.Operators.Convert<string>(ph_);

        return pi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Location.LocationStatus> value)
    {
        Location.LocationStatus? pj_ = value?.Value;
        string pk_ = context.Operators.Convert<string>(pj_);

        return pk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportStatus> value)
    {
        MeasureReport.MeasureReportStatus? pl_ = value?.Value;
        string pm_ = context.Operators.Convert<string>(pl_);

        return pm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportType> value)
    {
        MeasureReport.MeasureReportType? pn_ = value?.Value;
        string po_ = context.Operators.Convert<string>(pn_);

        return po_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
    {
        MedicationAdministration.MedicationAdministrationStatusCodes? pp_ = value?.Value;
        string pq_ = context.Operators.Convert<string>(pp_);

        return pq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationDispense.MedicationDispenseStatusCodes> value)
    {
        MedicationDispense.MedicationDispenseStatusCodes? pr_ = value?.Value;
        string ps_ = context.Operators.Convert<string>(pr_);

        return ps_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
    {
        MedicationKnowledge.MedicationKnowledgeStatusCodes? pt_ = value?.Value;
        string pu_ = context.Operators.Convert<string>(pt_);

        return pu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationRequestIntent> value)
    {
        MedicationRequest.MedicationRequestIntent? pv_ = value?.Value;
        string pw_ = context.Operators.Convert<string>(pv_);

        return pw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationrequestStatus> value)
    {
        MedicationRequest.MedicationrequestStatus? px_ = value?.Value;
        string py_ = context.Operators.Convert<string>(px_);

        return py_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationStatement.MedicationStatusCodes> value)
    {
        MedicationStatement.MedicationStatusCodes? pz_ = value?.Value;
        string qa_ = context.Operators.Convert<string>(pz_);

        return qa_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Medication.MedicationStatusCodes> value)
    {
        Medication.MedicationStatusCodes? qb_ = value?.Value;
        string qc_ = context.Operators.Convert<string>(qb_);

        return qc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageDefinition.MessageSignificanceCategory> value)
    {
        MessageDefinition.MessageSignificanceCategory? qd_ = value?.Value;
        string qe_ = context.Operators.Convert<string>(qd_);

        return qe_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageheaderResponseRequest> value)
    {
        MessageheaderResponseRequest? qf_ = value?.Value;
        string qg_ = context.Operators.Convert<string>(qf_);

        return qg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code value)
    {
        string qh_ = value?.Value;

        return qh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<HumanName.NameUse> value)
    {
        HumanName.NameUse? qi_ = value?.Value;
        string qj_ = context.Operators.Convert<string>(qi_);

        return qj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemIdentifierType> value)
    {
        NamingSystem.NamingSystemIdentifierType? qk_ = value?.Value;
        string ql_ = context.Operators.Convert<string>(qk_);

        return ql_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemType> value)
    {
        NamingSystem.NamingSystemType? qm_ = value?.Value;
        string qn_ = context.Operators.Convert<string>(qm_);

        return qn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Narrative.NarrativeStatus> value)
    {
        Narrative.NarrativeStatus? qo_ = value?.Value;
        string qp_ = context.Operators.Convert<string>(qo_);

        return qp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NoteType> value)
    {
        NoteType? qq_ = value?.Value;
        string qr_ = context.Operators.Convert<string>(qq_);

        return qr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestIntent> value)
    {
        RequestIntent? qs_ = value?.Value;
        string qt_ = context.Operators.Convert<string>(qs_);

        return qt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationDataType> value)
    {
        ObservationDefinition.ObservationDataType? qu_ = value?.Value;
        string qv_ = context.Operators.Convert<string>(qu_);

        return qv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationRangeCategory> value)
    {
        ObservationDefinition.ObservationRangeCategory? qw_ = value?.Value;
        string qx_ = context.Operators.Convert<string>(qw_);

        return qx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationDefinition.OperationKind> value)
    {
        OperationDefinition.OperationKind? qy_ = value?.Value;
        string qz_ = context.Operators.Convert<string>(qy_);

        return qz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationParameterUse> value)
    {
        OperationParameterUse? ra_ = value?.Value;
        string rb_ = context.Operators.Convert<string>(ra_);

        return rb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.OrientationType> value)
    {
        MolecularSequence.OrientationType? rc_ = value?.Value;
        string rd_ = context.Operators.Convert<string>(rc_);

        return rd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Appointment.ParticipantRequired> value)
    {
        Appointment.ParticipantRequired? re_ = value?.Value;
        string rf_ = context.Operators.Convert<string>(re_);

        return rf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ParticipationStatus> value)
    {
        ParticipationStatus? rg_ = value?.Value;
        string rh_ = context.Operators.Convert<string>(rg_);

        return rh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.PropertyRepresentation> value)
    {
        ElementDefinition.PropertyRepresentation? ri_ = value?.Value;
        string rj_ = context.Operators.Convert<string>(ri_);

        return rj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystem.PropertyType> value)
    {
        CodeSystem.PropertyType? rk_ = value?.Value;
        string rl_ = context.Operators.Convert<string>(rk_);

        return rl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Provenance.ProvenanceEntityRole> value)
    {
        Provenance.ProvenanceEntityRole? rm_ = value?.Value;
        string rn_ = context.Operators.Convert<string>(rm_);

        return rn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<PublicationStatus> value)
    {
        PublicationStatus? ro_ = value?.Value;
        string rp_ = context.Operators.Convert<string>(ro_);

        return rp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.QualityType> value)
    {
        MolecularSequence.QualityType? rq_ = value?.Value;
        string rr_ = context.Operators.Convert<string>(rq_);

        return rr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Quantity.QuantityComparator> value)
    {
        Quantity.QuantityComparator? rs_ = value?.Value;
        string rt_ = context.Operators.Convert<string>(rs_);

        return rt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemOperator> value)
    {
        Questionnaire.QuestionnaireItemOperator? ru_ = value?.Value;
        string rv_ = context.Operators.Convert<string>(ru_);

        return rv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemType> value)
    {
        Questionnaire.QuestionnaireItemType? rw_ = value?.Value;
        string rx_ = context.Operators.Convert<string>(rw_);

        return rx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
    {
        QuestionnaireResponse.QuestionnaireResponseStatus? ry_ = value?.Value;
        string rz_ = context.Operators.Convert<string>(ry_);

        return rz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ReferenceHandlingPolicy> value)
    {
        CapabilityStatement.ReferenceHandlingPolicy? sa_ = value?.Value;
        string sb_ = context.Operators.Convert<string>(sa_);

        return sb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.ReferenceVersionRules> value)
    {
        ElementDefinition.ReferenceVersionRules? sc_ = value?.Value;
        string sd_ = context.Operators.Convert<string>(sc_);

        return sd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RelatedArtifact.RelatedArtifactType> value)
    {
        RelatedArtifact.RelatedArtifactType? se_ = value?.Value;
        string sf_ = context.Operators.Convert<string>(se_);

        return sf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClaimProcessingCodes> value)
    {
        ClaimProcessingCodes? sg_ = value?.Value;
        string sh_ = context.Operators.Convert<string>(sg_);

        return sh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.RepositoryType> value)
    {
        MolecularSequence.RepositoryType? si_ = value?.Value;
        string sj_ = context.Operators.Convert<string>(si_);

        return sj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchElementDefinition.ResearchElementType> value)
    {
        ResearchElementDefinition.ResearchElementType? sk_ = value?.Value;
        string sl_ = context.Operators.Convert<string>(sk_);

        return sl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchStudy.ResearchStudyStatus> value)
    {
        ResearchStudy.ResearchStudyStatus? sm_ = value?.Value;
        string sn_ = context.Operators.Convert<string>(sm_);

        return sn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchSubject.ResearchSubjectStatus> value)
    {
        ResearchSubject.ResearchSubjectStatus? so_ = value?.Value;
        string sp_ = context.Operators.Convert<string>(so_);

        return sp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ResourceVersionPolicy> value)
    {
        CapabilityStatement.ResourceVersionPolicy? sq_ = value?.Value;
        string sr_ = context.Operators.Convert<string>(sq_);

        return sr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageHeader.ResponseType> value)
    {
        MessageHeader.ResponseType? ss_ = value?.Value;
        string st_ = context.Operators.Convert<string>(ss_);

        return st_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.RestfulCapabilityMode> value)
    {
        CapabilityStatement.RestfulCapabilityMode? su_ = value?.Value;
        string sv_ = context.Operators.Convert<string>(su_);

        return sv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.SPDXLicense> value)
    {
        ImplementationGuide.SPDXLicense? sw_ = value?.Value;
        string sx_ = context.Operators.Convert<string>(sw_);

        return sx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.SearchComparator> value)
    {
        SearchParameter.SearchComparator? sy_ = value?.Value;
        string sz_ = context.Operators.Convert<string>(sy_);

        return sz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.SearchEntryMode> value)
    {
        Bundle.SearchEntryMode? ta_ = value?.Value;
        string tb_ = context.Operators.Convert<string>(ta_);

        return tb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.SearchModifierCode> value)
    {
        SearchParameter.SearchModifierCode? tc_ = value?.Value;
        string td_ = context.Operators.Convert<string>(tc_);

        return td_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParamType> value)
    {
        SearchParamType? te_ = value?.Value;
        string tf_ = context.Operators.Convert<string>(te_);

        return tf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.SequenceType> value)
    {
        MolecularSequence.SequenceType? tg_ = value?.Value;
        string th_ = context.Operators.Convert<string>(tg_);

        return th_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.SlicingRules> value)
    {
        ElementDefinition.SlicingRules? ti_ = value?.Value;
        string tj_ = context.Operators.Convert<string>(ti_);

        return tj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Slot.SlotStatus> value)
    {
        Slot.SlotStatus? tk_ = value?.Value;
        string tl_ = context.Operators.Convert<string>(tk_);

        return tl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DataRequirement.SortDirection> value)
    {
        DataRequirement.SortDirection? tm_ = value?.Value;
        string tn_ = context.Operators.Convert<string>(tm_);

        return tn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SpecimenDefinition.SpecimenContainedPreference> value)
    {
        SpecimenDefinition.SpecimenContainedPreference? to_ = value?.Value;
        string tp_ = context.Operators.Convert<string>(to_);

        return tp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Specimen.SpecimenStatus> value)
    {
        Specimen.SpecimenStatus? tq_ = value?.Value;
        string tr_ = context.Operators.Convert<string>(tq_);

        return tr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VerificationResult.StatusCode> value)
    {
        VerificationResult.StatusCode? ts_ = value?.Value;
        string tt_ = context.Operators.Convert<string>(ts_);

        return tt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.StrandType> value)
    {
        MolecularSequence.StrandType? tu_ = value?.Value;
        string tv_ = context.Operators.Convert<string>(tu_);

        return tv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.StructureDefinitionKind> value)
    {
        StructureDefinition.StructureDefinitionKind? tw_ = value?.Value;
        string tx_ = context.Operators.Convert<string>(tw_);

        return tx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapContextType> value)
    {
        StructureMap.StructureMapContextType? ty_ = value?.Value;
        string tz_ = context.Operators.Convert<string>(ty_);

        return tz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapGroupTypeMode> value)
    {
        StructureMap.StructureMapGroupTypeMode? ua_ = value?.Value;
        string ub_ = context.Operators.Convert<string>(ua_);

        return ub_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapInputMode> value)
    {
        StructureMap.StructureMapInputMode? uc_ = value?.Value;
        string ud_ = context.Operators.Convert<string>(uc_);

        return ud_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapModelMode> value)
    {
        StructureMap.StructureMapModelMode? ue_ = value?.Value;
        string uf_ = context.Operators.Convert<string>(ue_);

        return uf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapSourceListMode> value)
    {
        StructureMap.StructureMapSourceListMode? ug_ = value?.Value;
        string uh_ = context.Operators.Convert<string>(ug_);

        return uh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTargetListMode> value)
    {
        StructureMap.StructureMapTargetListMode? ui_ = value?.Value;
        string uj_ = context.Operators.Convert<string>(ui_);

        return uj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTransform> value)
    {
        StructureMap.StructureMapTransform? uk_ = value?.Value;
        string ul_ = context.Operators.Convert<string>(uk_);

        return ul_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Subscription.SubscriptionChannelType> value)
    {
        Subscription.SubscriptionChannelType? um_ = value?.Value;
        string un_ = context.Operators.Convert<string>(um_);

        return un_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Subscription.SubscriptionStatus> value)
    {
        Subscription.SubscriptionStatus? uo_ = value?.Value;
        string up_ = context.Operators.Convert<string>(uo_);

        return up_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SupplyDelivery.SupplyDeliveryStatus> value)
    {
        SupplyDelivery.SupplyDeliveryStatus? uq_ = value?.Value;
        string ur_ = context.Operators.Convert<string>(uq_);

        return ur_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SupplyRequest.SupplyRequestStatus> value)
    {
        SupplyRequest.SupplyRequestStatus? us_ = value?.Value;
        string ut_ = context.Operators.Convert<string>(us_);

        return ut_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.SystemRestfulInteraction> value)
    {
        CapabilityStatement.SystemRestfulInteraction? uu_ = value?.Value;
        string uv_ = context.Operators.Convert<string>(uu_);

        return uv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Task.TaskIntent> value)
    {
        Task.TaskIntent? uw_ = value?.Value;
        string ux_ = context.Operators.Convert<string>(uw_);

        return ux_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Task.TaskStatus> value)
    {
        Task.TaskStatus? uy_ = value?.Value;
        string uz_ = context.Operators.Convert<string>(uy_);

        return uz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportActionResult> value)
    {
        TestReport.TestReportActionResult? va_ = value?.Value;
        string vb_ = context.Operators.Convert<string>(va_);

        return vb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportParticipantType> value)
    {
        TestReport.TestReportParticipantType? vc_ = value?.Value;
        string vd_ = context.Operators.Convert<string>(vc_);

        return vd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportResult> value)
    {
        TestReport.TestReportResult? ve_ = value?.Value;
        string vf_ = context.Operators.Convert<string>(ve_);

        return vf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportStatus> value)
    {
        TestReport.TestReportStatus? vg_ = value?.Value;
        string vh_ = context.Operators.Convert<string>(vg_);

        return vh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.TestScriptRequestMethodCode> value)
    {
        TestScript.TestScriptRequestMethodCode? vi_ = value?.Value;
        string vj_ = context.Operators.Convert<string>(vi_);

        return vj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TriggerDefinition.TriggerType> value)
    {
        TriggerDefinition.TriggerType? vk_ = value?.Value;
        string vl_ = context.Operators.Convert<string>(vk_);

        return vl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.TypeDerivationRule> value)
    {
        StructureDefinition.TypeDerivationRule? vm_ = value?.Value;
        string vn_ = context.Operators.Convert<string>(vm_);

        return vn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.TypeRestfulInteraction> value)
    {
        CapabilityStatement.TypeRestfulInteraction? vo_ = value?.Value;
        string vp_ = context.Operators.Convert<string>(vo_);

        return vp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Device.UDIEntryType> value)
    {
        Device.UDIEntryType? vq_ = value?.Value;
        string vr_ = context.Operators.Convert<string>(vq_);

        return vr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Timing.UnitsOfTime> value)
    {
        Timing.UnitsOfTime? vs_ = value?.Value;
        string vt_ = context.Operators.Convert<string>(vs_);

        return vt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClaimUseCode> value)
    {
        ClaimUseCode? vu_ = value?.Value;
        string vv_ = context.Operators.Convert<string>(vu_);

        return vv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VisionPrescription.VisionBase> value)
    {
        VisionPrescription.VisionBase? vw_ = value?.Value;
        string vx_ = context.Operators.Convert<string>(vw_);

        return vx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VisionPrescription.VisionEyes> value)
    {
        VisionPrescription.VisionEyes? vy_ = value?.Value;
        string vz_ = context.Operators.Convert<string>(vy_);

        return vz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.XPathUsageType> value)
    {
        SearchParameter.XPathUsageType? wa_ = value?.Value;
        string wb_ = context.Operators.Convert<string>(wa_);

        return wb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Base64Binary value)
    {
        byte[] wc_ = value?.Value;
        string wd_ = context.Operators.Convert<string>(wc_);

        return wd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, FhirString value)
    {
        string we_ = value?.Value;

        return we_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, FhirUri value)
    {
        string wf_ = value?.Value;

        return wf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, XHtml value)
    {
        string wg_ = value?.Value;

        return wg_;
    }


    [CqlExpressionDefinition("ToBoolean")]
    public bool? ToBoolean(CqlContext context, FhirBoolean value)
    {
        bool? wh_ = value?.Value;

        return wh_;
    }


    [CqlExpressionDefinition("ToDate")]
    public CqlDate ToDate(CqlContext context, Date value)
    {
        string wi_ = value?.Value;
        CqlDate wj_ = context.Operators.ConvertStringToDate(wi_);

        return wj_;
    }


    [CqlExpressionDefinition("ToDateTime")]
    public CqlDateTime ToDateTime(CqlContext context, FhirDateTime value)
    {
        CqlDateTime wk_ = context.Operators.Convert<CqlDateTime>(value);

        return wk_;
    }


    [CqlExpressionDefinition("ToDateTime")]
    public CqlDateTime ToDateTime(CqlContext context, Instant value)
    {
        DateTimeOffset? wl_ = value?.Value;
        CqlDateTime wm_ = context.Operators.Convert<CqlDateTime>(wl_);

        return wm_;
    }


    [CqlExpressionDefinition("ToDecimal")]
    public decimal? ToDecimal(CqlContext context, FhirDecimal value)
    {
        decimal? wn_ = value?.Value;

        return wn_;
    }


    [CqlExpressionDefinition("ToInteger")]
    public int? ToInteger(CqlContext context, Integer value)
    {
        int? wo_ = value?.Value;

        return wo_;
    }


    [CqlExpressionDefinition("ToTime")]
    public CqlTime ToTime(CqlContext context, Time value)
    {
        string wp_ = value?.Value;
        CqlTime wq_ = context.Operators.ConvertStringToTime(wp_);

        return wq_;
    }


    #endregion Expressions

}

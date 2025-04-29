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

    // NOT A DEFINITION CqlExpressionDefinition//
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


    // NOT A DEFINITION CqlExpressionDefinition//
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


    // NOT A DEFINITION CqlExpressionDefinition//
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


    // NOT A DEFINITION CqlExpressionDefinition//
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


    // NOT A DEFINITION CqlExpressionDefinition//
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


    // NOT A DEFINITION CqlExpressionDefinition//
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


    // NOT A DEFINITION CqlExpressionDefinition//
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


    // NOT A DEFINITION CqlExpressionDefinition//
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


    // NOT A DEFINITION CqlExpressionDefinition//
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


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Converts the given value (assumed to be a URI) to a CQL [ValueSet](https://cql.hl7.org/09-b-cqlreference.html#valueset)")]
    public CqlValueSet ToValueSet(CqlContext context, string uri)
    {
        CqlValueSet ej_()
        {
            if (uri is null)
            {
                return default;
            }
            else
            {
                CqlValueSet ek_ = new CqlValueSet
                {
                    id = uri,
                };

                return ek_;
            }
        };

        return ej_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Constructs a FHIR [Reference](https://hl7.org/fhir/datatypes.html#Reference) from the given reference (assumed to be a FHIR resource URL)")]
    public ResourceReference reference(CqlContext context, string reference)
    {
        ResourceReference el_()
        {
            if (reference is null)
            {
                return default;
            }
            else
            {
                FhirString em_ = new FhirString
                {
                    Value = reference,
                };
                ResourceReference en_ = new ResourceReference
                {
                    ReferenceElement = em_,
                };

                return en_;
            }
        };

        return el_();
    }


    #endregion Expressions

    #region Functions

    // NOT A DEFINITION CqlFunctionDefinition//
    public ResourceReference reference(CqlContext context, Resource resource) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.reference is not implemented."));


    #endregion Functions

    #region Expressions

    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Converts the given value to a CQL value using the appropriate accessor or conversion function.")]
    [CqlTag("comment", "TODO: document conversion")]
    public object ToValue(CqlContext context, object value)
    {
        object eo_()
        {
            if (value is Base64Binary)
            {
                byte[] ep_ = (value as Base64Binary)?.Value;
                string eq_ = context.Operators.Convert<string>(ep_);

                return eq_ as object;
            }
            else if (value is FhirBoolean)
            {
                bool? er_ = (value as FhirBoolean)?.Value;

                return er_;
            }
            else if (value is Canonical)
            {
                string es_ = (value as Canonical)?.Value;

                return es_ as object;
            }
            else if (value is Code)
            {
                string et_ = (value as Code)?.Value;

                return et_ as object;
            }
            else if (value is Date)
            {
                string eu_ = (value as Date)?.Value;
                CqlDate ev_ = context.Operators.ConvertStringToDate(eu_);

                return ev_ as object;
            }
            else if (value is FhirDateTime)
            {
                CqlDateTime ew_ = context.Operators.Convert<CqlDateTime>(value as FhirDateTime);

                return ew_ as object;
            }
            else if (value is FhirDecimal)
            {
                decimal? ex_ = (value as FhirDecimal)?.Value;

                return ex_;
            }
            else if (value is Id)
            {
                string ey_ = (value as Id)?.Value;

                return ey_ as object;
            }
            else if (value is Instant)
            {
                DateTimeOffset? ez_ = (value as Instant)?.Value;
                CqlDateTime fa_ = context.Operators.Convert<CqlDateTime>(ez_);

                return fa_ as object;
            }
            else if (value is Integer)
            {
                int? fb_ = (value as Integer)?.Value;

                return fb_;
            }
            else if (value is Markdown)
            {
                string fc_ = (value as Markdown)?.Value;

                return fc_ as object;
            }
            else if (value is Oid)
            {
                string fd_ = (value as Oid)?.Value;

                return fd_ as object;
            }
            else if (value is Integer)
            {
                int? fe_ = (value as Integer)?.Value;

                return fe_;
            }
            else if (value is FhirString)
            {
                string ff_ = (value as FhirString)?.Value;

                return ff_ as object;
            }
            else if (value is Time)
            {
                string fg_ = (value as Time)?.Value;
                CqlTime fh_ = context.Operators.ConvertStringToTime(fg_);

                return fh_ as object;
            }
            else if (value is Integer)
            {
                int? fi_ = (value as Integer)?.Value;

                return fi_;
            }
            else if (value is FhirUri)
            {
                string fj_ = (value as FhirUri)?.Value;

                return fj_ as object;
            }
            else if (value is FhirUrl)
            {
                string fk_ = (value as FhirUrl)?.Value;

                return fk_ as object;
            }
            else if (value is Uuid)
            {
                string fl_ = (value as Uuid)?.Value;

                return fl_ as object;
            }
            else if (value is Age)
            {
                CqlQuantity fm_ = this.ToQuantity(context, value as Age);

                return fm_ as object;
            }
            else if (value is CodeableConcept)
            {
                CqlConcept fn_ = this.ToConcept(context, value as CodeableConcept);

                return fn_ as object;
            }
            else if (value is Coding)
            {
                CqlCode fo_ = this.ToCode(context, value as Coding);

                return fo_ as object;
            }
            else if (value is Count)
            {
                CqlQuantity fp_ = this.ToQuantity(context, value as Count);

                return fp_ as object;
            }
            else if (value is Distance)
            {
                CqlQuantity fq_ = this.ToQuantity(context, value as Distance);

                return fq_ as object;
            }
            else if (value is Duration)
            {
                CqlQuantity fr_ = this.ToQuantity(context, value as Duration);

                return fr_ as object;
            }
            else if (value is Quantity)
            {
                CqlQuantity fs_ = this.ToQuantity(context, value as Quantity);

                return fs_ as object;
            }
            else if (value is Range)
            {
                CqlInterval<CqlQuantity> ft_ = this.ToInterval(context, value as Range);

                return ft_ as object;
            }
            else if (value is Period)
            {
                CqlInterval<CqlDateTime> fu_ = this.ToInterval(context, value as Period);

                return fu_ as object;
            }
            else if (value is Ratio)
            {
                CqlRatio fv_ = this.ToRatio(context, value as Ratio);

                return fv_ as object;
            }
            else
            {
                return value as object;
            }
        };

        return eo_();
    }


    #endregion Expressions

    #region Functions

    // NOT A DEFINITION CqlFunctionDefinition//
    public Resource resolve(CqlContext context, string reference) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.resolve is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public Resource resolve(CqlContext context, ResourceReference reference) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.resolve is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public IEnumerable<Extension> extension(CqlContext context, Element element, string url) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.extension is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public IEnumerable<Extension> extension(CqlContext context, DomainResource resource, string url) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.extension is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public IEnumerable<Extension> modifierExtension(CqlContext context, BackboneElement element, string url) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.modifierExtension is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public IEnumerable<Extension> modifierExtension(CqlContext context, DomainResource resource, string url) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.modifierExtension is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public bool? hasValue(CqlContext context, Element element) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.hasValue is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public object getValue(CqlContext context, Element element) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.getValue is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public IEnumerable<object> ofType(CqlContext context, string identifier) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.ofType is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public bool? @is(CqlContext context, string identifier) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.is is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public object @as(CqlContext context, string identifier) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.as is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public ElementDefinition elementDefinition(CqlContext context, Element element) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.elementDefinition is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public IEnumerable<Element> slice(CqlContext context, Element element, string url, string name) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.slice is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public Resource checkModifiers(CqlContext context, Resource resource) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public Resource checkModifiers(CqlContext context, Resource resource, string modifier) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public Element checkModifiers(CqlContext context, Element element) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public Element checkModifiers(CqlContext context, Element element, string modifier) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public bool? conformsTo(CqlContext context, Resource resource, string structure) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.conformsTo is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public bool? memberOf(CqlContext context, Code code, string valueSet) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public bool? memberOf(CqlContext context, Coding coding, string valueSet) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public bool? memberOf(CqlContext context, CodeableConcept concept, string valueSet) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public bool? subsumes(CqlContext context, Coding coding, Coding subsumedCoding) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumes is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public bool? subsumes(CqlContext context, CodeableConcept concept, CodeableConcept subsumedConcept) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumes is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public bool? subsumedBy(CqlContext context, Coding coding, Coding subsumingCoding) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumedBy is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public bool? subsumedBy(CqlContext context, CodeableConcept concept, CodeableConcept subsumingConcept) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumedBy is not implemented."));


    // NOT A DEFINITION CqlFunctionDefinition//
    public bool? htmlChecks(CqlContext context, Element element) =>
        throw (new NotImplementedException("External function FHIRHelpers-4.3.000.htmlChecks is not implemented."));


    #endregion Functions

    #region Expressions

    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Account.AccountStatus> value)
    {
        Account.AccountStatus? fw_ = value?.Value;
        string fx_ = context.Operators.Convert<string>(fw_);

        return fx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionCardinalityBehavior> value)
    {
        ActionCardinalityBehavior? fy_ = value?.Value;
        string fz_ = context.Operators.Convert<string>(fy_);

        return fz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionConditionKind> value)
    {
        ActionConditionKind? ga_ = value?.Value;
        string gb_ = context.Operators.Convert<string>(ga_);

        return gb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionGroupingBehavior> value)
    {
        ActionGroupingBehavior? gc_ = value?.Value;
        string gd_ = context.Operators.Convert<string>(gc_);

        return gd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionParticipantType> value)
    {
        ActionParticipantType? ge_ = value?.Value;
        string gf_ = context.Operators.Convert<string>(ge_);

        return gf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionPrecheckBehavior> value)
    {
        ActionPrecheckBehavior? gg_ = value?.Value;
        string gh_ = context.Operators.Convert<string>(gg_);

        return gh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionRelationshipType> value)
    {
        ActionRelationshipType? gi_ = value?.Value;
        string gj_ = context.Operators.Convert<string>(gi_);

        return gj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionRequiredBehavior> value)
    {
        ActionRequiredBehavior? gk_ = value?.Value;
        string gl_ = context.Operators.Convert<string>(gk_);

        return gl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionSelectionBehavior> value)
    {
        ActionSelectionBehavior? gm_ = value?.Value;
        string gn_ = context.Operators.Convert<string>(gm_);

        return gn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActivityDefinition.RequestResourceType> value)
    {
        ActivityDefinition.RequestResourceType? go_ = value?.Value;
        string gp_ = context.Operators.Convert<string>(go_);

        return gp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Address.AddressType> value)
    {
        Address.AddressType? gq_ = value?.Value;
        string gr_ = context.Operators.Convert<string>(gq_);

        return gr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Address.AddressUse> value)
    {
        Address.AddressUse? gs_ = value?.Value;
        string gt_ = context.Operators.Convert<string>(gs_);

        return gt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AdministrativeGender> value)
    {
        AdministrativeGender? gu_ = value?.Value;
        string gv_ = context.Operators.Convert<string>(gu_);

        return gv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AdverseEvent.AdverseEventActuality> value)
    {
        AdverseEvent.AdverseEventActuality? gw_ = value?.Value;
        string gx_ = context.Operators.Convert<string>(gw_);

        return gx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ElementDefinition.AggregationMode> value)
    {
        ElementDefinition.AggregationMode? gy_ = value?.Value;
        string gz_ = context.Operators.Convert<string>(gy_);

        return gz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
    {
        AllergyIntolerance.AllergyIntoleranceCategory? ha_ = value?.Value;
        string hb_ = context.Operators.Convert<string>(ha_);

        return hb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
    {
        AllergyIntolerance.AllergyIntoleranceCriticality? hc_ = value?.Value;
        string hd_ = context.Operators.Convert<string>(hc_);

        return hd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
    {
        AllergyIntolerance.AllergyIntoleranceSeverity? he_ = value?.Value;
        string hf_ = context.Operators.Convert<string>(he_);

        return hf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceType> value)
    {
        AllergyIntolerance.AllergyIntoleranceType? hg_ = value?.Value;
        string hh_ = context.Operators.Convert<string>(hg_);

        return hh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Appointment.AppointmentStatus> value)
    {
        Appointment.AppointmentStatus? hi_ = value?.Value;
        string hj_ = context.Operators.Convert<string>(hi_);

        return hj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestScript.AssertionDirectionType> value)
    {
        TestScript.AssertionDirectionType? hk_ = value?.Value;
        string hl_ = context.Operators.Convert<string>(hk_);

        return hl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestScript.AssertionOperatorType> value)
    {
        TestScript.AssertionOperatorType? hm_ = value?.Value;
        string hn_ = context.Operators.Convert<string>(hm_);

        return hn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestScript.AssertionResponseTypes> value)
    {
        TestScript.AssertionResponseTypes? ho_ = value?.Value;
        string hp_ = context.Operators.Convert<string>(ho_);

        return hp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAction> value)
    {
        AuditEvent.AuditEventAction? hq_ = value?.Value;
        string hr_ = context.Operators.Convert<string>(hq_);

        return hr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAgentNetworkType> value)
    {
        AuditEvent.AuditEventAgentNetworkType? hs_ = value?.Value;
        string ht_ = context.Operators.Convert<string>(hs_);

        return ht_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventOutcome> value)
    {
        AuditEvent.AuditEventOutcome? hu_ = value?.Value;
        string hv_ = context.Operators.Convert<string>(hu_);

        return hv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<BindingStrength> value)
    {
        BindingStrength? hw_ = value?.Value;
        string hx_ = context.Operators.Convert<string>(hw_);

        return hx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? hy_ = value?.Value;
        string hz_ = context.Operators.Convert<string>(hy_);

        return hz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? ia_ = value?.Value;
        string ib_ = context.Operators.Convert<string>(ia_);

        return ib_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? ic_ = value?.Value;
        string id_ = context.Operators.Convert<string>(ic_);

        return id_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Bundle.BundleType> value)
    {
        Bundle.BundleType? ie_ = value?.Value;
        string if_ = context.Operators.Convert<string>(ie_);

        return if_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatementKind> value)
    {
        CapabilityStatementKind? ig_ = value?.Value;
        string ih_ = context.Operators.Convert<string>(ig_);

        return ih_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityKind> value)
    {
        CarePlan.CarePlanActivityKind? ii_ = value?.Value;
        string ij_ = context.Operators.Convert<string>(ii_);

        return ij_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityStatus> value)
    {
        CarePlan.CarePlanActivityStatus? ik_ = value?.Value;
        string il_ = context.Operators.Convert<string>(ik_);

        return il_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CarePlan.CarePlanIntent> value)
    {
        CarePlan.CarePlanIntent? im_ = value?.Value;
        string in_ = context.Operators.Convert<string>(im_);

        return in_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<RequestStatus> value)
    {
        RequestStatus? io_ = value?.Value;
        string ip_ = context.Operators.Convert<string>(io_);

        return ip_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CareTeam.CareTeamStatus> value)
    {
        CareTeam.CareTeamStatus? iq_ = value?.Value;
        string ir_ = context.Operators.Convert<string>(iq_);

        return ir_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CatalogEntry.CatalogEntryRelationType> value)
    {
        CatalogEntry.CatalogEntryRelationType? is_ = value?.Value;
        string it_ = context.Operators.Convert<string>(is_);

        return it_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<InvoicePriceComponentType> value)
    {
        InvoicePriceComponentType? iu_ = value?.Value;
        string iv_ = context.Operators.Convert<string>(iu_);

        return iv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ChargeItem.ChargeItemStatus> value)
    {
        ChargeItem.ChargeItemStatus? iw_ = value?.Value;
        string ix_ = context.Operators.Convert<string>(iw_);

        return ix_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<FinancialResourceStatusCodes> value)
    {
        FinancialResourceStatusCodes? iy_ = value?.Value;
        string iz_ = context.Operators.Convert<string>(iy_);

        return iz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ClinicalImpression.ClinicalImpressionStatus> value)
    {
        ClinicalImpression.ClinicalImpressionStatus? ja_ = value?.Value;
        string jb_ = context.Operators.Convert<string>(ja_);

        return jb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TerminologyCapabilities.CodeSearchSupport> value)
    {
        TerminologyCapabilities.CodeSearchSupport? jc_ = value?.Value;
        string jd_ = context.Operators.Convert<string>(jc_);

        return jd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CodeSystemContentMode> value)
    {
        CodeSystemContentMode? je_ = value?.Value;
        string jf_ = context.Operators.Convert<string>(je_);

        return jf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CodeSystem.CodeSystemHierarchyMeaning> value)
    {
        CodeSystem.CodeSystemHierarchyMeaning? jg_ = value?.Value;
        string jh_ = context.Operators.Convert<string>(jg_);

        return jh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<RequestPriority> value)
    {
        RequestPriority? ji_ = value?.Value;
        string jj_ = context.Operators.Convert<string>(ji_);

        return jj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<EventStatus> value)
    {
        EventStatus? jk_ = value?.Value;
        string jl_ = context.Operators.Convert<string>(jk_);

        return jl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CompartmentType> value)
    {
        CompartmentType? jm_ = value?.Value;
        string jn_ = context.Operators.Convert<string>(jm_);

        return jn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Composition.CompositionAttestationMode> value)
    {
        Composition.CompositionAttestationMode? jo_ = value?.Value;
        string jp_ = context.Operators.Convert<string>(jo_);

        return jp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CompositionStatus> value)
    {
        CompositionStatus? jq_ = value?.Value;
        string jr_ = context.Operators.Convert<string>(jq_);

        return jr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ConceptMapEquivalence> value)
    {
        ConceptMapEquivalence? js_ = value?.Value;
        string jt_ = context.Operators.Convert<string>(js_);

        return jt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
    {
        ConceptMap.ConceptMapGroupUnmappedMode? ju_ = value?.Value;
        string jv_ = context.Operators.Convert<string>(ju_);

        return jv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalDeleteStatus> value)
    {
        CapabilityStatement.ConditionalDeleteStatus? jw_ = value?.Value;
        string jx_ = context.Operators.Convert<string>(jw_);

        return jx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalReadStatus> value)
    {
        CapabilityStatement.ConditionalReadStatus? jy_ = value?.Value;
        string jz_ = context.Operators.Convert<string>(jy_);

        return jz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Consent.ConsentDataMeaning> value)
    {
        Consent.ConsentDataMeaning? ka_ = value?.Value;
        string kb_ = context.Operators.Convert<string>(ka_);

        return kb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Consent.ConsentProvisionType> value)
    {
        Consent.ConsentProvisionType? kc_ = value?.Value;
        string kd_ = context.Operators.Convert<string>(kc_);

        return kd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Consent.ConsentState> value)
    {
        Consent.ConsentState? ke_ = value?.Value;
        string kf_ = context.Operators.Convert<string>(ke_);

        return kf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ConstraintSeverity> value)
    {
        ConstraintSeverity? kg_ = value?.Value;
        string kh_ = context.Operators.Convert<string>(kg_);

        return kh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointSystem> value)
    {
        ContactPoint.ContactPointSystem? ki_ = value?.Value;
        string kj_ = context.Operators.Convert<string>(ki_);

        return kj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointUse> value)
    {
        ContactPoint.ContactPointUse? kk_ = value?.Value;
        string kl_ = context.Operators.Convert<string>(kk_);

        return kl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Contract.ContractResourcePublicationStatusCodes> value)
    {
        Contract.ContractResourcePublicationStatusCodes? km_ = value?.Value;
        string kn_ = context.Operators.Convert<string>(km_);

        return kn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Contract.ContractResourceStatusCodes> value)
    {
        Contract.ContractResourceStatusCodes? ko_ = value?.Value;
        string kp_ = context.Operators.Convert<string>(ko_);

        return kp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Contributor.ContributorType> value)
    {
        Contributor.ContributorType? kq_ = value?.Value;
        string kr_ = context.Operators.Convert<string>(kq_);

        return kr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Money.Currencies> value)
    {
        Money.Currencies? ks_ = value?.Value;
        string kt_ = context.Operators.Convert<string>(ks_);

        return kt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DaysOfWeek> value)
    {
        DaysOfWeek? ku_ = value?.Value;
        string kv_ = context.Operators.Convert<string>(ku_);

        return kv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DetectedIssue.DetectedIssueSeverity> value)
    {
        DetectedIssue.DetectedIssueSeverity? kw_ = value?.Value;
        string kx_ = context.Operators.Convert<string>(kw_);

        return kx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ObservationStatus> value)
    {
        ObservationStatus? ky_ = value?.Value;
        string kz_ = context.Operators.Convert<string>(ky_);

        return kz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationState> value)
    {
        DeviceMetric.DeviceMetricCalibrationState? la_ = value?.Value;
        string lb_ = context.Operators.Convert<string>(la_);

        return lb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationType> value)
    {
        DeviceMetric.DeviceMetricCalibrationType? lc_ = value?.Value;
        string ld_ = context.Operators.Convert<string>(lc_);

        return ld_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCategory> value)
    {
        DeviceMetric.DeviceMetricCategory? le_ = value?.Value;
        string lf_ = context.Operators.Convert<string>(le_);

        return lf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricColor> value)
    {
        DeviceMetric.DeviceMetricColor? lg_ = value?.Value;
        string lh_ = context.Operators.Convert<string>(lg_);

        return lh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricOperationalStatus> value)
    {
        DeviceMetric.DeviceMetricOperationalStatus? li_ = value?.Value;
        string lj_ = context.Operators.Convert<string>(li_);

        return lj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DeviceNameType> value)
    {
        DeviceNameType? lk_ = value?.Value;
        string ll_ = context.Operators.Convert<string>(lk_);

        return ll_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DeviceUseStatement.DeviceUseStatementStatus> value)
    {
        DeviceUseStatement.DeviceUseStatementStatus? lm_ = value?.Value;
        string ln_ = context.Operators.Convert<string>(lm_);

        return ln_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DiagnosticReport.DiagnosticReportStatus> value)
    {
        DiagnosticReport.DiagnosticReportStatus? lo_ = value?.Value;
        string lp_ = context.Operators.Convert<string>(lo_);

        return lp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ElementDefinition.DiscriminatorType> value)
    {
        ElementDefinition.DiscriminatorType? lq_ = value?.Value;
        string lr_ = context.Operators.Convert<string>(lq_);

        return lr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Composition.V3ConfidentialityClassification> value)
    {
        Composition.V3ConfidentialityClassification? ls_ = value?.Value;
        string lt_ = context.Operators.Convert<string>(ls_);

        return lt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.DocumentMode> value)
    {
        CapabilityStatement.DocumentMode? lu_ = value?.Value;
        string lv_ = context.Operators.Convert<string>(lu_);

        return lv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DocumentReferenceStatus> value)
    {
        DocumentReferenceStatus? lw_ = value?.Value;
        string lx_ = context.Operators.Convert<string>(lw_);

        return lx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DocumentRelationshipType> value)
    {
        DocumentRelationshipType? ly_ = value?.Value;
        string lz_ = context.Operators.Convert<string>(ly_);

        return lz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
    {
        CoverageEligibilityRequest.EligibilityRequestPurpose? ma_ = value?.Value;
        string mb_ = context.Operators.Convert<string>(ma_);

        return mb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
    {
        CoverageEligibilityResponse.EligibilityResponsePurpose? mc_ = value?.Value;
        string md_ = context.Operators.Convert<string>(mc_);

        return md_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Questionnaire.EnableWhenBehavior> value)
    {
        Questionnaire.EnableWhenBehavior? me_ = value?.Value;
        string mf_ = context.Operators.Convert<string>(me_);

        return mf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Encounter.EncounterLocationStatus> value)
    {
        Encounter.EncounterLocationStatus? mg_ = value?.Value;
        string mh_ = context.Operators.Convert<string>(mg_);

        return mh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Encounter.EncounterStatus> value)
    {
        Encounter.EncounterStatus? mi_ = value?.Value;
        string mj_ = context.Operators.Convert<string>(mi_);

        return mj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Endpoint.EndpointStatus> value)
    {
        Endpoint.EndpointStatus? mk_ = value?.Value;
        string ml_ = context.Operators.Convert<string>(mk_);

        return ml_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<EpisodeOfCare.EpisodeOfCareStatus> value)
    {
        EpisodeOfCare.EpisodeOfCareStatus? mm_ = value?.Value;
        string mn_ = context.Operators.Convert<string>(mm_);

        return mn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.EventCapabilityMode> value)
    {
        CapabilityStatement.EventCapabilityMode? mo_ = value?.Value;
        string mp_ = context.Operators.Convert<string>(mo_);

        return mp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Timing.EventTiming> value)
    {
        Timing.EventTiming? mq_ = value?.Value;
        string mr_ = context.Operators.Convert<string>(mq_);

        return mr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<VariableTypeCode> value)
    {
        VariableTypeCode? ms_ = value?.Value;
        string mt_ = context.Operators.Convert<string>(ms_);

        return mt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ExampleScenario.ExampleScenarioActorType> value)
    {
        ExampleScenario.ExampleScenarioActorType? mu_ = value?.Value;
        string mv_ = context.Operators.Convert<string>(mu_);

        return mv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
    {
        ExplanationOfBenefit.ExplanationOfBenefitStatus? mw_ = value?.Value;
        string mx_ = context.Operators.Convert<string>(mw_);

        return mx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<EffectEvidenceSynthesis.ExposureStateCode> value)
    {
        EffectEvidenceSynthesis.ExposureStateCode? my_ = value?.Value;
        string mz_ = context.Operators.Convert<string>(my_);

        return mz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureDefinition.ExtensionContextType> value)
    {
        StructureDefinition.ExtensionContextType? na_ = value?.Value;
        string nb_ = context.Operators.Convert<string>(na_);

        return nb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<FHIRAllTypes> value)
    {
        FHIRAllTypes? nc_ = value?.Value;
        string nd_ = context.Operators.Convert<string>(nc_);

        return nd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<FHIRDefinedType> value)
    {
        FHIRDefinedType? ne_ = value?.Value;
        string nf_ = context.Operators.Convert<string>(ne_);

        return nf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Device.FHIRDeviceStatus> value)
    {
        Device.FHIRDeviceStatus? ng_ = value?.Value;
        string nh_ = context.Operators.Convert<string>(ng_);

        return nh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ResourceType> value)
    {
        ResourceType? ni_ = value?.Value;
        string nj_ = context.Operators.Convert<string>(ni_);

        return nj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Substance.FHIRSubstanceStatus> value)
    {
        Substance.FHIRSubstanceStatus? nk_ = value?.Value;
        string nl_ = context.Operators.Convert<string>(nk_);

        return nl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<FHIRVersion> value)
    {
        FHIRVersion? nm_ = value?.Value;
        string nn_ = context.Operators.Convert<string>(nm_);

        return nn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<FamilyMemberHistory.FamilyHistoryStatus> value)
    {
        FamilyMemberHistory.FamilyHistoryStatus? no_ = value?.Value;
        string np_ = context.Operators.Convert<string>(no_);

        return np_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<FilterOperator> value)
    {
        FilterOperator? nq_ = value?.Value;
        string nr_ = context.Operators.Convert<string>(nq_);

        return nr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Flag.FlagStatus> value)
    {
        Flag.FlagStatus? ns_ = value?.Value;
        string nt_ = context.Operators.Convert<string>(ns_);

        return nt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Goal.GoalLifecycleStatus> value)
    {
        Goal.GoalLifecycleStatus? nu_ = value?.Value;
        string nv_ = context.Operators.Convert<string>(nu_);

        return nv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentRule> value)
    {
        GraphDefinition.GraphCompartmentRule? nw_ = value?.Value;
        string nx_ = context.Operators.Convert<string>(nw_);

        return nx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentUse> value)
    {
        GraphDefinition.GraphCompartmentUse? ny_ = value?.Value;
        string nz_ = context.Operators.Convert<string>(ny_);

        return nz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<GroupMeasureCode> value)
    {
        GroupMeasureCode? oa_ = value?.Value;
        string ob_ = context.Operators.Convert<string>(oa_);

        return ob_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Group.GroupType> value)
    {
        Group.GroupType? oc_ = value?.Value;
        string od_ = context.Operators.Convert<string>(oc_);

        return od_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<GuidanceResponse.GuidanceResponseStatus> value)
    {
        GuidanceResponse.GuidanceResponseStatus? oe_ = value?.Value;
        string of_ = context.Operators.Convert<string>(oe_);

        return of_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ImplementationGuide.GuidePageGeneration> value)
    {
        ImplementationGuide.GuidePageGeneration? og_ = value?.Value;
        string oh_ = context.Operators.Convert<string>(og_);

        return oh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ImplementationGuide.GuideParameterCode> value)
    {
        ImplementationGuide.GuideParameterCode? oi_ = value?.Value;
        string oj_ = context.Operators.Convert<string>(oi_);

        return oj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Bundle.HTTPVerb> value)
    {
        Bundle.HTTPVerb? ok_ = value?.Value;
        string ol_ = context.Operators.Convert<string>(ok_);

        return ol_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Identifier.IdentifierUse> value)
    {
        Identifier.IdentifierUse? om_ = value?.Value;
        string on_ = context.Operators.Convert<string>(om_);

        return on_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Person.IdentityAssuranceLevel> value)
    {
        Person.IdentityAssuranceLevel? oo_ = value?.Value;
        string op_ = context.Operators.Convert<string>(oo_);

        return op_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ImagingStudy.ImagingStudyStatus> value)
    {
        ImagingStudy.ImagingStudyStatus? oq_ = value?.Value;
        string or_ = context.Operators.Convert<string>(oq_);

        return or_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
    {
        ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? os_ = value?.Value;
        string ot_ = context.Operators.Convert<string>(os_);

        return ot_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Immunization.ImmunizationStatusCodes> value)
    {
        Immunization.ImmunizationStatusCodes? ou_ = value?.Value;
        string ov_ = context.Operators.Convert<string>(ou_);

        return ov_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Invoice.InvoiceStatus> value)
    {
        Invoice.InvoiceStatus? ow_ = value?.Value;
        string ox_ = context.Operators.Convert<string>(ow_);

        return ox_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<OperationOutcome.IssueSeverity> value)
    {
        OperationOutcome.IssueSeverity? oy_ = value?.Value;
        string oz_ = context.Operators.Convert<string>(oy_);

        return oz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<OperationOutcome.IssueType> value)
    {
        OperationOutcome.IssueType? pa_ = value?.Value;
        string pb_ = context.Operators.Convert<string>(pa_);

        return pb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Patient.LinkType> value)
    {
        Patient.LinkType? pc_ = value?.Value;
        string pd_ = context.Operators.Convert<string>(pc_);

        return pd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Linkage.LinkageType> value)
    {
        Linkage.LinkageType? pe_ = value?.Value;
        string pf_ = context.Operators.Convert<string>(pe_);

        return pf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ListMode> value)
    {
        ListMode? pg_ = value?.Value;
        string ph_ = context.Operators.Convert<string>(pg_);

        return ph_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<List.ListStatus> value)
    {
        List.ListStatus? pi_ = value?.Value;
        string pj_ = context.Operators.Convert<string>(pi_);

        return pj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Location.LocationMode> value)
    {
        Location.LocationMode? pk_ = value?.Value;
        string pl_ = context.Operators.Convert<string>(pk_);

        return pl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Location.LocationStatus> value)
    {
        Location.LocationStatus? pm_ = value?.Value;
        string pn_ = context.Operators.Convert<string>(pm_);

        return pn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportStatus> value)
    {
        MeasureReport.MeasureReportStatus? po_ = value?.Value;
        string pp_ = context.Operators.Convert<string>(po_);

        return pp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportType> value)
    {
        MeasureReport.MeasureReportType? pq_ = value?.Value;
        string pr_ = context.Operators.Convert<string>(pq_);

        return pr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
    {
        MedicationAdministration.MedicationAdministrationStatusCodes? ps_ = value?.Value;
        string pt_ = context.Operators.Convert<string>(ps_);

        return pt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MedicationDispense.MedicationDispenseStatusCodes> value)
    {
        MedicationDispense.MedicationDispenseStatusCodes? pu_ = value?.Value;
        string pv_ = context.Operators.Convert<string>(pu_);

        return pv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
    {
        MedicationKnowledge.MedicationKnowledgeStatusCodes? pw_ = value?.Value;
        string px_ = context.Operators.Convert<string>(pw_);

        return px_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationRequestIntent> value)
    {
        MedicationRequest.MedicationRequestIntent? py_ = value?.Value;
        string pz_ = context.Operators.Convert<string>(py_);

        return pz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationrequestStatus> value)
    {
        MedicationRequest.MedicationrequestStatus? qa_ = value?.Value;
        string qb_ = context.Operators.Convert<string>(qa_);

        return qb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MedicationStatement.MedicationStatusCodes> value)
    {
        MedicationStatement.MedicationStatusCodes? qc_ = value?.Value;
        string qd_ = context.Operators.Convert<string>(qc_);

        return qd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Medication.MedicationStatusCodes> value)
    {
        Medication.MedicationStatusCodes? qe_ = value?.Value;
        string qf_ = context.Operators.Convert<string>(qe_);

        return qf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MessageDefinition.MessageSignificanceCategory> value)
    {
        MessageDefinition.MessageSignificanceCategory? qg_ = value?.Value;
        string qh_ = context.Operators.Convert<string>(qg_);

        return qh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MessageheaderResponseRequest> value)
    {
        MessageheaderResponseRequest? qi_ = value?.Value;
        string qj_ = context.Operators.Convert<string>(qi_);

        return qj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code value)
    {
        string qk_ = value?.Value;

        return qk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<HumanName.NameUse> value)
    {
        HumanName.NameUse? ql_ = value?.Value;
        string qm_ = context.Operators.Convert<string>(ql_);

        return qm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemIdentifierType> value)
    {
        NamingSystem.NamingSystemIdentifierType? qn_ = value?.Value;
        string qo_ = context.Operators.Convert<string>(qn_);

        return qo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemType> value)
    {
        NamingSystem.NamingSystemType? qp_ = value?.Value;
        string qq_ = context.Operators.Convert<string>(qp_);

        return qq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Narrative.NarrativeStatus> value)
    {
        Narrative.NarrativeStatus? qr_ = value?.Value;
        string qs_ = context.Operators.Convert<string>(qr_);

        return qs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<NoteType> value)
    {
        NoteType? qt_ = value?.Value;
        string qu_ = context.Operators.Convert<string>(qt_);

        return qu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<RequestIntent> value)
    {
        RequestIntent? qv_ = value?.Value;
        string qw_ = context.Operators.Convert<string>(qv_);

        return qw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationDataType> value)
    {
        ObservationDefinition.ObservationDataType? qx_ = value?.Value;
        string qy_ = context.Operators.Convert<string>(qx_);

        return qy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationRangeCategory> value)
    {
        ObservationDefinition.ObservationRangeCategory? qz_ = value?.Value;
        string ra_ = context.Operators.Convert<string>(qz_);

        return ra_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<OperationDefinition.OperationKind> value)
    {
        OperationDefinition.OperationKind? rb_ = value?.Value;
        string rc_ = context.Operators.Convert<string>(rb_);

        return rc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<OperationParameterUse> value)
    {
        OperationParameterUse? rd_ = value?.Value;
        string re_ = context.Operators.Convert<string>(rd_);

        return re_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MolecularSequence.OrientationType> value)
    {
        MolecularSequence.OrientationType? rf_ = value?.Value;
        string rg_ = context.Operators.Convert<string>(rf_);

        return rg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Appointment.ParticipantRequired> value)
    {
        Appointment.ParticipantRequired? rh_ = value?.Value;
        string ri_ = context.Operators.Convert<string>(rh_);

        return ri_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ParticipationStatus> value)
    {
        ParticipationStatus? rj_ = value?.Value;
        string rk_ = context.Operators.Convert<string>(rj_);

        return rk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ElementDefinition.PropertyRepresentation> value)
    {
        ElementDefinition.PropertyRepresentation? rl_ = value?.Value;
        string rm_ = context.Operators.Convert<string>(rl_);

        return rm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CodeSystem.PropertyType> value)
    {
        CodeSystem.PropertyType? rn_ = value?.Value;
        string ro_ = context.Operators.Convert<string>(rn_);

        return ro_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Provenance.ProvenanceEntityRole> value)
    {
        Provenance.ProvenanceEntityRole? rp_ = value?.Value;
        string rq_ = context.Operators.Convert<string>(rp_);

        return rq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<PublicationStatus> value)
    {
        PublicationStatus? rr_ = value?.Value;
        string rs_ = context.Operators.Convert<string>(rr_);

        return rs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MolecularSequence.QualityType> value)
    {
        MolecularSequence.QualityType? rt_ = value?.Value;
        string ru_ = context.Operators.Convert<string>(rt_);

        return ru_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Quantity.QuantityComparator> value)
    {
        Quantity.QuantityComparator? rv_ = value?.Value;
        string rw_ = context.Operators.Convert<string>(rv_);

        return rw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemOperator> value)
    {
        Questionnaire.QuestionnaireItemOperator? rx_ = value?.Value;
        string ry_ = context.Operators.Convert<string>(rx_);

        return ry_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemType> value)
    {
        Questionnaire.QuestionnaireItemType? rz_ = value?.Value;
        string sa_ = context.Operators.Convert<string>(rz_);

        return sa_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
    {
        QuestionnaireResponse.QuestionnaireResponseStatus? sb_ = value?.Value;
        string sc_ = context.Operators.Convert<string>(sb_);

        return sc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.ReferenceHandlingPolicy> value)
    {
        CapabilityStatement.ReferenceHandlingPolicy? sd_ = value?.Value;
        string se_ = context.Operators.Convert<string>(sd_);

        return se_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ElementDefinition.ReferenceVersionRules> value)
    {
        ElementDefinition.ReferenceVersionRules? sf_ = value?.Value;
        string sg_ = context.Operators.Convert<string>(sf_);

        return sg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<RelatedArtifact.RelatedArtifactType> value)
    {
        RelatedArtifact.RelatedArtifactType? sh_ = value?.Value;
        string si_ = context.Operators.Convert<string>(sh_);

        return si_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ClaimProcessingCodes> value)
    {
        ClaimProcessingCodes? sj_ = value?.Value;
        string sk_ = context.Operators.Convert<string>(sj_);

        return sk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MolecularSequence.RepositoryType> value)
    {
        MolecularSequence.RepositoryType? sl_ = value?.Value;
        string sm_ = context.Operators.Convert<string>(sl_);

        return sm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ResearchElementDefinition.ResearchElementType> value)
    {
        ResearchElementDefinition.ResearchElementType? sn_ = value?.Value;
        string so_ = context.Operators.Convert<string>(sn_);

        return so_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ResearchStudy.ResearchStudyStatus> value)
    {
        ResearchStudy.ResearchStudyStatus? sp_ = value?.Value;
        string sq_ = context.Operators.Convert<string>(sp_);

        return sq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ResearchSubject.ResearchSubjectStatus> value)
    {
        ResearchSubject.ResearchSubjectStatus? sr_ = value?.Value;
        string ss_ = context.Operators.Convert<string>(sr_);

        return ss_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.ResourceVersionPolicy> value)
    {
        CapabilityStatement.ResourceVersionPolicy? st_ = value?.Value;
        string su_ = context.Operators.Convert<string>(st_);

        return su_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MessageHeader.ResponseType> value)
    {
        MessageHeader.ResponseType? sv_ = value?.Value;
        string sw_ = context.Operators.Convert<string>(sv_);

        return sw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.RestfulCapabilityMode> value)
    {
        CapabilityStatement.RestfulCapabilityMode? sx_ = value?.Value;
        string sy_ = context.Operators.Convert<string>(sx_);

        return sy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ImplementationGuide.SPDXLicense> value)
    {
        ImplementationGuide.SPDXLicense? sz_ = value?.Value;
        string ta_ = context.Operators.Convert<string>(sz_);

        return ta_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<SearchParameter.SearchComparator> value)
    {
        SearchParameter.SearchComparator? tb_ = value?.Value;
        string tc_ = context.Operators.Convert<string>(tb_);

        return tc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Bundle.SearchEntryMode> value)
    {
        Bundle.SearchEntryMode? td_ = value?.Value;
        string te_ = context.Operators.Convert<string>(td_);

        return te_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<SearchParameter.SearchModifierCode> value)
    {
        SearchParameter.SearchModifierCode? tf_ = value?.Value;
        string tg_ = context.Operators.Convert<string>(tf_);

        return tg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<SearchParamType> value)
    {
        SearchParamType? th_ = value?.Value;
        string ti_ = context.Operators.Convert<string>(th_);

        return ti_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MolecularSequence.SequenceType> value)
    {
        MolecularSequence.SequenceType? tj_ = value?.Value;
        string tk_ = context.Operators.Convert<string>(tj_);

        return tk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ElementDefinition.SlicingRules> value)
    {
        ElementDefinition.SlicingRules? tl_ = value?.Value;
        string tm_ = context.Operators.Convert<string>(tl_);

        return tm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Slot.SlotStatus> value)
    {
        Slot.SlotStatus? tn_ = value?.Value;
        string to_ = context.Operators.Convert<string>(tn_);

        return to_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DataRequirement.SortDirection> value)
    {
        DataRequirement.SortDirection? tp_ = value?.Value;
        string tq_ = context.Operators.Convert<string>(tp_);

        return tq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<SpecimenDefinition.SpecimenContainedPreference> value)
    {
        SpecimenDefinition.SpecimenContainedPreference? tr_ = value?.Value;
        string ts_ = context.Operators.Convert<string>(tr_);

        return ts_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Specimen.SpecimenStatus> value)
    {
        Specimen.SpecimenStatus? tt_ = value?.Value;
        string tu_ = context.Operators.Convert<string>(tt_);

        return tu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<VerificationResult.StatusCode> value)
    {
        VerificationResult.StatusCode? tv_ = value?.Value;
        string tw_ = context.Operators.Convert<string>(tv_);

        return tw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MolecularSequence.StrandType> value)
    {
        MolecularSequence.StrandType? tx_ = value?.Value;
        string ty_ = context.Operators.Convert<string>(tx_);

        return ty_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureDefinition.StructureDefinitionKind> value)
    {
        StructureDefinition.StructureDefinitionKind? tz_ = value?.Value;
        string ua_ = context.Operators.Convert<string>(tz_);

        return ua_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureMap.StructureMapContextType> value)
    {
        StructureMap.StructureMapContextType? ub_ = value?.Value;
        string uc_ = context.Operators.Convert<string>(ub_);

        return uc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureMap.StructureMapGroupTypeMode> value)
    {
        StructureMap.StructureMapGroupTypeMode? ud_ = value?.Value;
        string ue_ = context.Operators.Convert<string>(ud_);

        return ue_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureMap.StructureMapInputMode> value)
    {
        StructureMap.StructureMapInputMode? uf_ = value?.Value;
        string ug_ = context.Operators.Convert<string>(uf_);

        return ug_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureMap.StructureMapModelMode> value)
    {
        StructureMap.StructureMapModelMode? uh_ = value?.Value;
        string ui_ = context.Operators.Convert<string>(uh_);

        return ui_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureMap.StructureMapSourceListMode> value)
    {
        StructureMap.StructureMapSourceListMode? uj_ = value?.Value;
        string uk_ = context.Operators.Convert<string>(uj_);

        return uk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTargetListMode> value)
    {
        StructureMap.StructureMapTargetListMode? ul_ = value?.Value;
        string um_ = context.Operators.Convert<string>(ul_);

        return um_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTransform> value)
    {
        StructureMap.StructureMapTransform? un_ = value?.Value;
        string uo_ = context.Operators.Convert<string>(un_);

        return uo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Subscription.SubscriptionChannelType> value)
    {
        Subscription.SubscriptionChannelType? up_ = value?.Value;
        string uq_ = context.Operators.Convert<string>(up_);

        return uq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Subscription.SubscriptionStatus> value)
    {
        Subscription.SubscriptionStatus? ur_ = value?.Value;
        string us_ = context.Operators.Convert<string>(ur_);

        return us_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<SupplyDelivery.SupplyDeliveryStatus> value)
    {
        SupplyDelivery.SupplyDeliveryStatus? ut_ = value?.Value;
        string uu_ = context.Operators.Convert<string>(ut_);

        return uu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<SupplyRequest.SupplyRequestStatus> value)
    {
        SupplyRequest.SupplyRequestStatus? uv_ = value?.Value;
        string uw_ = context.Operators.Convert<string>(uv_);

        return uw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.SystemRestfulInteraction> value)
    {
        CapabilityStatement.SystemRestfulInteraction? ux_ = value?.Value;
        string uy_ = context.Operators.Convert<string>(ux_);

        return uy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Task.TaskIntent> value)
    {
        Task.TaskIntent? uz_ = value?.Value;
        string va_ = context.Operators.Convert<string>(uz_);

        return va_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Task.TaskStatus> value)
    {
        Task.TaskStatus? vb_ = value?.Value;
        string vc_ = context.Operators.Convert<string>(vb_);

        return vc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestReport.TestReportActionResult> value)
    {
        TestReport.TestReportActionResult? vd_ = value?.Value;
        string ve_ = context.Operators.Convert<string>(vd_);

        return ve_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestReport.TestReportParticipantType> value)
    {
        TestReport.TestReportParticipantType? vf_ = value?.Value;
        string vg_ = context.Operators.Convert<string>(vf_);

        return vg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestReport.TestReportResult> value)
    {
        TestReport.TestReportResult? vh_ = value?.Value;
        string vi_ = context.Operators.Convert<string>(vh_);

        return vi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestReport.TestReportStatus> value)
    {
        TestReport.TestReportStatus? vj_ = value?.Value;
        string vk_ = context.Operators.Convert<string>(vj_);

        return vk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestScript.TestScriptRequestMethodCode> value)
    {
        TestScript.TestScriptRequestMethodCode? vl_ = value?.Value;
        string vm_ = context.Operators.Convert<string>(vl_);

        return vm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TriggerDefinition.TriggerType> value)
    {
        TriggerDefinition.TriggerType? vn_ = value?.Value;
        string vo_ = context.Operators.Convert<string>(vn_);

        return vo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureDefinition.TypeDerivationRule> value)
    {
        StructureDefinition.TypeDerivationRule? vp_ = value?.Value;
        string vq_ = context.Operators.Convert<string>(vp_);

        return vq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.TypeRestfulInteraction> value)
    {
        CapabilityStatement.TypeRestfulInteraction? vr_ = value?.Value;
        string vs_ = context.Operators.Convert<string>(vr_);

        return vs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Device.UDIEntryType> value)
    {
        Device.UDIEntryType? vt_ = value?.Value;
        string vu_ = context.Operators.Convert<string>(vt_);

        return vu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Timing.UnitsOfTime> value)
    {
        Timing.UnitsOfTime? vv_ = value?.Value;
        string vw_ = context.Operators.Convert<string>(vv_);

        return vw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ClaimUseCode> value)
    {
        ClaimUseCode? vx_ = value?.Value;
        string vy_ = context.Operators.Convert<string>(vx_);

        return vy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<VisionPrescription.VisionBase> value)
    {
        VisionPrescription.VisionBase? vz_ = value?.Value;
        string wa_ = context.Operators.Convert<string>(vz_);

        return wa_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<VisionPrescription.VisionEyes> value)
    {
        VisionPrescription.VisionEyes? wb_ = value?.Value;
        string wc_ = context.Operators.Convert<string>(wb_);

        return wc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<SearchParameter.XPathUsageType> value)
    {
        SearchParameter.XPathUsageType? wd_ = value?.Value;
        string we_ = context.Operators.Convert<string>(wd_);

        return we_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Base64Binary value)
    {
        byte[] wf_ = value?.Value;
        string wg_ = context.Operators.Convert<string>(wf_);

        return wg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, FhirString value)
    {
        string wh_ = value?.Value;

        return wh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, FhirUri value)
    {
        string wi_ = value?.Value;

        return wi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, XHtml value)
    {
        string wj_ = value?.Value;

        return wj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? ToBoolean(CqlContext context, FhirBoolean value)
    {
        bool? wk_ = value?.Value;

        return wk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDate ToDate(CqlContext context, Date value)
    {
        string wl_ = value?.Value;
        CqlDate wm_ = context.Operators.ConvertStringToDate(wl_);

        return wm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime ToDateTime(CqlContext context, FhirDateTime value)
    {
        CqlDateTime wn_ = context.Operators.Convert<CqlDateTime>(value);

        return wn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime ToDateTime(CqlContext context, Instant value)
    {
        DateTimeOffset? wo_ = value?.Value;
        CqlDateTime wp_ = context.Operators.Convert<CqlDateTime>(wo_);

        return wp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public decimal? ToDecimal(CqlContext context, FhirDecimal value)
    {
        decimal? wq_ = value?.Value;

        return wq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? ToInteger(CqlContext context, Integer value)
    {
        int? wr_ = value?.Value;

        return wr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlTime ToTime(CqlContext context, Time value)
    {
        string ws_ = value?.Value;
        CqlTime wt_ = context.Operators.ConvertStringToTime(ws_);

        return wt_;
    }


    #endregion Expressions

}

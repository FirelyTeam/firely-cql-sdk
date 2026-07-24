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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.4.0")]
[CqlLibrary("FHIRHelpers", "4.3.000")]
public partial class FHIRHelpers_4_3_000 : ILibrary, ISingleton<FHIRHelpers_4_3_000>
{
    #region Functions and Expressions (263)

    [CqlFunctionDefinition("ToInterval")]
    [CqlTag("description", "Converts the given [Period](https://hl7.org/fhir/datatypes.html#Period)\nvalue to a CQL DateTime Interval")]
    [CqlTag("comment", "If the start value of the given period is unspecified, the starting\nboundary of the resulting interval will be open (meaning the start of the interval\nis unknown, as opposed to interpreted as the beginning of time).")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, Period period)
    {

        CqlInterval<CqlDateTime> a_() {
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
        }

        return a_();
    }


    [CqlFunctionDefinition("ToInterval")]
    [CqlTag("description", "Converts the given FHIR [Quantity](https://hl7.org/fhir/datatypes.html#Quantity) value to a CQL Interval of Quantity.")]
    [CqlTag("comment", "If the given quantity has a comparator, it is used to construct an interval based on the value of the comparator. If the comparator\nis less than, the resulting interval will start with a null closed boundary and end with an open boundary on the quantity. If the comparator\nis less than or equal, the resulting interval will start with a null closed boundary and end with a closed boundary on the quantity. If the \ncomparator is greater or equal, the resulting interval will start with a closed boundary on the quantity and end with a closed null boundary.\nIf the comparator is greatter than, the resulting interval will start with an open boundary on the quantity and end with a closed null boundary.\nIf no comparator is specified, the resulting interval will start and end with a closed boundary on the quantity.")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Quantity quantity)
    {

        CqlInterval<CqlQuantity> a_() {
            if (quantity is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {

                CqlInterval<CqlQuantity> b_() {

                    bool c_() {
                        Code<Quantity.QuantityComparator> g_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? h_ = g_?.Value;
                        string i_ = context.Operators.Convert<string>(h_);
                        bool? j_ = context.Operators.Equal(i_, "<");
                        return j_ ?? false;
                    }


                    bool d_() {
                        Code<Quantity.QuantityComparator> k_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? l_ = k_?.Value;
                        string m_ = context.Operators.Convert<string>(l_);
                        bool? n_ = context.Operators.Equal(m_, "<=");
                        return n_ ?? false;
                    }


                    bool e_() {
                        Code<Quantity.QuantityComparator> o_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? p_ = o_?.Value;
                        string q_ = context.Operators.Convert<string>(p_);
                        bool? r_ = context.Operators.Equal(q_, ">=");
                        return r_ ?? false;
                    }


                    bool f_() {
                        Code<Quantity.QuantityComparator> s_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? t_ = s_?.Value;
                        string u_ = context.Operators.Convert<string>(t_);
                        bool? v_ = context.Operators.Equal(u_, ">");
                        return v_ ?? false;
                    }

                    if (c_())
                    {
                        CqlQuantity w_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> x_ = context.Operators.Interval(default, w_, true, false);
                        return x_;
                    }
                    else if (d_())
                    {
                        CqlQuantity y_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> z_ = context.Operators.Interval(default, y_, true, true);
                        return z_;
                    }
                    else if (e_())
                    {
                        CqlQuantity aa_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> ab_ = context.Operators.Interval(aa_, default, true, true);
                        return ab_;
                    }
                    else if (f_())
                    {
                        CqlQuantity ac_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> ad_ = context.Operators.Interval(ac_, default, false, true);
                        return ad_;
                    }
                    else
                    {
                        CqlQuantity ae_ = this.ToQuantity(context, quantity);
                        CqlInterval<CqlQuantity> af_ = context.Operators.Interval(ae_, ae_, true, true);
                        return af_;
                    }
                }

                return b_();
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("ToInterval")]
    [CqlTag("description", "Converts the given FHIR [Range](https://hl7.org/fhir/datatypes.html#Range) value to a CQL Interval of Quantity")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Range range)
    {

        CqlInterval<CqlQuantity> a_() {
            if (range is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {
                Quantity b_ = range?.Low;
                CqlQuantity c_ = this.ToQuantity(context, b_);
                Quantity d_ = range?.High;
                CqlQuantity e_ = this.ToQuantity(context, d_);
                CqlInterval<CqlQuantity> f_ = context.Operators.Interval(c_, e_, true, true);
                return f_;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("ToCalendarUnit")]
    [CqlTag("description", "Converts a UCUM definite duration unit to a CQL calendar duration\nunit using conversions specified in the [quantities](https://cql.hl7.org/02-authorsguide.html#quantities) \ntopic of the CQL specification.")]
    [CqlTag("comment", "Note that for durations above days (or weeks), the conversion is understood to be approximate")]
    public string ToCalendarUnit(CqlContext context, string unit)
    {

        string a_() {
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
        }

        return a_();
    }


    [CqlFunctionDefinition("ToQuantity")]
    [CqlTag("description", "Converts the given FHIR [Quantity](https://hl7.org/fhir/datatypes.html#Quantity) \nvalue to a CQL Quantity")]
    [CqlTag("comment", "If the given quantity has a comparator specified, a runtime error is raised. If the given quantity\nhas a system other than UCUM (i.e. `http://unitsofmeasure.org`) or CQL calendar units (i.e. `http://hl7.org/fhirpath/CodeSystem/calendar-units`)\nan error is raised. For UCUM to calendar units, the `ToCalendarUnit` function is used.")]
    [CqlTag("seealso", "ToCalendarUnit")]
    public CqlQuantity ToQuantity(CqlContext context, Quantity quantity)
    {

        CqlQuantity a_() {

            bool b_() {
                Code<Quantity.QuantityComparator> d_ = quantity?.ComparatorElement;
                bool? e_ = context.Operators.Not((bool?)(d_ is null));
                return e_ ?? false;
            }


            bool c_() {
                FhirUri f_ = quantity?.SystemElement;
                string g_ = f_?.Value;
                bool? h_ = context.Operators.Equal(g_, "http://unitsofmeasure.org");
                bool? i_ = context.Operators.Or((bool?)(f_ is null), h_);
                bool? j_ = context.Operators.Equal(g_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
                bool? k_ = context.Operators.Or(i_, j_);
                return k_ ?? false;
            }

            if (quantity is null)
            {
                return default;
            }
            else if (quantity?.ValueElement is null)
            {
                return default;
            }
            else if (b_())
            {
                object l_ = context.Operators.Message<object>((object)null, "FHIRHelpers.ToQuantity.ComparatorQuantityNotSupported", "Error", "FHIR Quantity value has a comparator and cannot be converted to a System.Quantity value.");
                return l_ as CqlQuantity;
            }
            else if (c_())
            {
                FhirDecimal m_ = quantity?.ValueElement;
                decimal? n_ = m_?.Value;
                Code o_ = quantity?.CodeElement;
                string p_ = o_?.Value;
                FhirString q_ = quantity?.UnitElement;
                string r_ = q_?.Value;
                string s_ = this.ToCalendarUnit(context, (p_ ?? r_) ?? "1");
                return new CqlQuantity(n_, s_);
            }
            else
            {
                FhirString t_ = quantity?.UnitElement;
                string u_ = t_?.Value;
                string v_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", u_ ?? "");
                string w_ = context.Operators.Concatenate(v_ ?? "", " (");
                FhirUri x_ = quantity?.SystemElement;
                string y_ = x_?.Value;
                string z_ = context.Operators.Concatenate(w_ ?? "", y_ ?? "");
                string aa_ = context.Operators.Concatenate(z_ ?? "", "|");
                Code ab_ = quantity?.CodeElement;
                string ac_ = ab_?.Value;
                string ad_ = context.Operators.Concatenate(aa_ ?? "", ac_ ?? "");
                string ae_ = context.Operators.Concatenate(ad_ ?? "", ")");
                object af_ = context.Operators.Message<object>((object)null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", ae_);
                return af_ as CqlQuantity;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("ToQuantityIgnoringComparator")]
    [CqlTag("description", "Converts the given FHIR [Quantity](https://hl7.org/fhir/datatypes.html#Quantity) value to a CQL Quantity, ignoring\nthe comparator element. This function should only be used when an application is justified in ignoring the comparator value (i.e. the\ncontext is looking for boundary).")]
    [CqlTag("comment", "If the given quantity has a system other than UCUM (i.e. `http://unitsofmeasure.org`) or CQL calendar units \n(i.e. `http://hl7.org/fhirpath/CodeSystem/calendar-units`) an error is raised. For UCUM to calendar units, the `ToCalendarUnit` function \nis used.")]
    [CqlTag("seealso", "ToCalendarUnit")]
    public CqlQuantity ToQuantityIgnoringComparator(CqlContext context, Quantity quantity)
    {

        CqlQuantity a_() {

            bool b_() {
                FhirUri c_ = quantity?.SystemElement;
                string d_ = c_?.Value;
                bool? e_ = context.Operators.Equal(d_, "http://unitsofmeasure.org");
                bool? f_ = context.Operators.Or((bool?)(c_ is null), e_);
                bool? g_ = context.Operators.Equal(d_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
                bool? h_ = context.Operators.Or(f_, g_);
                return h_ ?? false;
            }

            if (quantity is null)
            {
                return default;
            }
            else if (quantity?.ValueElement is null)
            {
                return default;
            }
            else if (b_())
            {
                FhirDecimal i_ = quantity?.ValueElement;
                decimal? j_ = i_?.Value;
                Code k_ = quantity?.CodeElement;
                string l_ = k_?.Value;
                FhirString m_ = quantity?.UnitElement;
                string n_ = m_?.Value;
                string o_ = this.ToCalendarUnit(context, (l_ ?? n_) ?? "1");
                return new CqlQuantity(j_, o_);
            }
            else
            {
                FhirString p_ = quantity?.UnitElement;
                string q_ = p_?.Value;
                string r_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", q_ ?? "");
                string s_ = context.Operators.Concatenate(r_ ?? "", " (");
                FhirUri t_ = quantity?.SystemElement;
                string u_ = t_?.Value;
                string v_ = context.Operators.Concatenate(s_ ?? "", u_ ?? "");
                string w_ = context.Operators.Concatenate(v_ ?? "", "|");
                Code x_ = quantity?.CodeElement;
                string y_ = x_?.Value;
                string z_ = context.Operators.Concatenate(w_ ?? "", y_ ?? "");
                string aa_ = context.Operators.Concatenate(z_ ?? "", ")");
                object ab_ = context.Operators.Message<object>((object)null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", aa_);
                return ab_ as CqlQuantity;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("ToRatio")]
    [CqlTag("description", "Converts the given FHIR [Ratio](https://hl7.org/fhir/datatypes.html#Ratio) value to a CQL Ratio.")]
    public CqlRatio ToRatio(CqlContext context, Ratio ratio)
    {

        CqlRatio a_() {
            if (ratio is null)
            {
                return default;
            }
            else
            {
                Quantity b_ = ratio?.Numerator;
                CqlQuantity c_ = this.ToQuantity(context, b_);
                Quantity d_ = ratio?.Denominator;
                CqlQuantity e_ = this.ToQuantity(context, d_);
                return new CqlRatio(c_, e_);
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("ToCode")]
    [CqlTag("description", "Converts the given FHIR [Coding](https://hl7.org/fhir/datatypes.html#Coding) value to a CQL Code.")]
    public CqlCode ToCode(CqlContext context, Coding coding)
    {

        CqlCode a_() {
            if (coding is null)
            {
                return default;
            }
            else
            {
                Code b_ = coding?.CodeElement;
                string c_ = b_?.Value;
                FhirUri d_ = coding?.SystemElement;
                string e_ = d_?.Value;
                FhirString f_ = coding?.VersionElement;
                string g_ = f_?.Value;
                FhirString h_ = coding?.DisplayElement;
                string i_ = h_?.Value;
                return new CqlCode(c_, e_, g_, i_);
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("ToConcept")]
    [CqlTag("description", "Converts the given FHIR [CodeableConcept](https://hl7.org/fhir/datatypes.html#CodeableConcept) value to a CQL Concept.")]
    public CqlConcept ToConcept(CqlContext context, CodeableConcept concept)
    {

        CqlConcept a_() {
            if (concept is null)
            {
                return default;
            }
            else
            {
                List<Coding> b_ = concept?.Coding;

                CqlCode c_(Coding C) {
                    CqlCode h_ = this.ToCode(context, C);
                    return h_;
                }

                IEnumerable<CqlCode> d_ = context.Operators.Select<Coding, CqlCode>((IEnumerable<Coding>)b_, c_);
                IEnumerable<CqlCode> e_ = context.Operators.Distinct<CqlCode>(d_);
                FhirString f_ = concept?.TextElement;
                string g_ = f_?.Value;
                return new CqlConcept(e_, g_);
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("ToValueSet")]
    [CqlTag("description", "Converts the given value (assumed to be a URI) to a CQL [ValueSet](https://cql.hl7.org/09-b-cqlreference.html#valueset)")]
    public CqlValueSet ToValueSet(CqlContext context, string uri) =>
    (uri is null
        ? default
        : new CqlValueSet(uri, default));


    [CqlFunctionDefinition("reference")]
    [CqlTag("description", "Constructs a FHIR [Reference](https://hl7.org/fhir/datatypes.html#Reference) from the given reference (assumed to be a FHIR resource URL)")]
    public ResourceReference reference(CqlContext context, string reference)
    {

        ResourceReference a_() {
            if (reference is null)
            {
                return default;
            }
            else
            {
                ResourceReference b_ = new ResourceReference
                {
                    ReferenceElement = new FhirString(reference),
                };
                return b_;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("reference")]
    public ResourceReference reference(CqlContext context, Resource resource) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.reference is not implemented."));


    [CqlFunctionDefinition("ToValue")]
    [CqlTag("description", "Converts the given value to a CQL value using the appropriate accessor or conversion function.")]
    [CqlTag("comment", "TODO: document conversion")]
    public object ToValue(CqlContext context, object value)
    {

        object a_() {
            if (value is Base64Binary)
            {
                byte[] b_ = (value as Base64Binary)?.Value;
                string c_ = context.Operators.Convert<string>(b_);
                return c_;
            }
            else if (value is FhirBoolean)
            {
                bool? d_ = (value as FhirBoolean)?.Value;
                return d_;
            }
            else if (value is Canonical)
            {
                string e_ = (value as Canonical)?.Value;
                return e_;
            }
            else if (value is Code)
            {
                string f_ = (value as Code)?.Value;
                return f_;
            }
            else if (value is Date)
            {
                string g_ = (value as Date)?.Value;
                CqlDate h_ = context.Operators.ConvertStringToDate(g_);
                return h_;
            }
            else if (value is FhirDateTime)
            {
                CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(value as FhirDateTime);
                return i_;
            }
            else if (value is FhirDecimal)
            {
                decimal? j_ = (value as FhirDecimal)?.Value;
                return j_;
            }
            else if (value is Id)
            {
                string k_ = (value as Id)?.Value;
                return k_;
            }
            else if (value is Instant)
            {
                DateTimeOffset? l_ = (value as Instant)?.Value;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                return m_;
            }
            else if (value is Integer)
            {
                int? n_ = (value as Integer)?.Value;
                return n_;
            }
            else if (value is Markdown)
            {
                string o_ = (value as Markdown)?.Value;
                return o_;
            }
            else if (value is Oid)
            {
                string p_ = (value as Oid)?.Value;
                return p_;
            }
            else if (value is Integer)
            {
                int? q_ = (value as Integer)?.Value;
                return q_;
            }
            else if (value is FhirString)
            {
                string r_ = (value as FhirString)?.Value;
                return r_;
            }
            else if (value is Time)
            {
                string s_ = (value as Time)?.Value;
                CqlTime t_ = context.Operators.ConvertStringToTime(s_);
                return t_;
            }
            else if (value is Integer)
            {
                int? u_ = (value as Integer)?.Value;
                return u_;
            }
            else if (value is FhirUri)
            {
                string v_ = (value as FhirUri)?.Value;
                return v_;
            }
            else if (value is FhirUrl)
            {
                string w_ = (value as FhirUrl)?.Value;
                return w_;
            }
            else if (value is Uuid)
            {
                string x_ = (value as Uuid)?.Value;
                return x_;
            }
            else if (value is Age)
            {
                CqlQuantity y_ = this.ToQuantity(context, value as Age);
                return y_;
            }
            else if (value is CodeableConcept)
            {
                CqlConcept z_ = this.ToConcept(context, value as CodeableConcept);
                return z_;
            }
            else if (value is Coding)
            {
                CqlCode aa_ = this.ToCode(context, value as Coding);
                return aa_;
            }
            else if (value is Count)
            {
                CqlQuantity ab_ = this.ToQuantity(context, value as Count);
                return ab_;
            }
            else if (value is Distance)
            {
                CqlQuantity ac_ = this.ToQuantity(context, value as Distance);
                return ac_;
            }
            else if (value is Duration)
            {
                CqlQuantity ad_ = this.ToQuantity(context, value as Duration);
                return ad_;
            }
            else if (value is Quantity)
            {
                CqlQuantity ae_ = this.ToQuantity(context, value as Quantity);
                return ae_;
            }
            else if (value is Range)
            {
                CqlInterval<CqlQuantity> af_ = this.ToInterval(context, value as Range);
                return af_;
            }
            else if (value is Period)
            {
                CqlInterval<CqlDateTime> ag_ = this.ToInterval(context, value as Period);
                return ag_;
            }
            else if (value is Ratio)
            {
                CqlRatio ah_ = this.ToRatio(context, value as Ratio);
                return ah_;
            }
            else
            {
                return value;
            }
        }

        return a_();
    }


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


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Account.AccountStatus> value)
    {
        Account.AccountStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionCardinalityBehavior> value)
    {
        ActionCardinalityBehavior? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionConditionKind> value)
    {
        ActionConditionKind? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionGroupingBehavior> value)
    {
        ActionGroupingBehavior? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionParticipantType> value)
    {
        ActionParticipantType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionPrecheckBehavior> value)
    {
        ActionPrecheckBehavior? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionRelationshipType> value)
    {
        ActionRelationshipType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionRequiredBehavior> value)
    {
        ActionRequiredBehavior? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionSelectionBehavior> value)
    {
        ActionSelectionBehavior? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActivityDefinition.RequestResourceType> value)
    {
        ActivityDefinition.RequestResourceType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Address.AddressType> value)
    {
        Address.AddressType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Address.AddressUse> value)
    {
        Address.AddressUse? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AdministrativeGender> value)
    {
        AdministrativeGender? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AdverseEvent.AdverseEventActuality> value)
    {
        AdverseEvent.AdverseEventActuality? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.AggregationMode> value)
    {
        ElementDefinition.AggregationMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
    {
        AllergyIntolerance.AllergyIntoleranceCategory? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
    {
        AllergyIntolerance.AllergyIntoleranceCriticality? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
    {
        AllergyIntolerance.AllergyIntoleranceSeverity? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceType> value)
    {
        AllergyIntolerance.AllergyIntoleranceType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Appointment.AppointmentStatus> value)
    {
        Appointment.AppointmentStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionDirectionType> value)
    {
        TestScript.AssertionDirectionType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionOperatorType> value)
    {
        TestScript.AssertionOperatorType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionResponseTypes> value)
    {
        TestScript.AssertionResponseTypes? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAction> value)
    {
        AuditEvent.AuditEventAction? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAgentNetworkType> value)
    {
        AuditEvent.AuditEventAgentNetworkType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventOutcome> value)
    {
        AuditEvent.AuditEventOutcome? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BindingStrength> value)
    {
        BindingStrength? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.BundleType> value)
    {
        Bundle.BundleType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatementKind> value)
    {
        CapabilityStatementKind? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityKind> value)
    {
        CarePlan.CarePlanActivityKind? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityStatus> value)
    {
        CarePlan.CarePlanActivityStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanIntent> value)
    {
        CarePlan.CarePlanIntent? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestStatus> value)
    {
        RequestStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CareTeam.CareTeamStatus> value)
    {
        CareTeam.CareTeamStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CatalogEntry.CatalogEntryRelationType> value)
    {
        CatalogEntry.CatalogEntryRelationType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<InvoicePriceComponentType> value)
    {
        InvoicePriceComponentType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ChargeItem.ChargeItemStatus> value)
    {
        ChargeItem.ChargeItemStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FinancialResourceStatusCodes> value)
    {
        FinancialResourceStatusCodes? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClinicalImpression.ClinicalImpressionStatus> value)
    {
        ClinicalImpression.ClinicalImpressionStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TerminologyCapabilities.CodeSearchSupport> value)
    {
        TerminologyCapabilities.CodeSearchSupport? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystemContentMode> value)
    {
        CodeSystemContentMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystem.CodeSystemHierarchyMeaning> value)
    {
        CodeSystem.CodeSystemHierarchyMeaning? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestPriority> value)
    {
        RequestPriority? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EventStatus> value)
    {
        EventStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CompartmentType> value)
    {
        CompartmentType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Composition.CompositionAttestationMode> value)
    {
        Composition.CompositionAttestationMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CompositionStatus> value)
    {
        CompositionStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConceptMapEquivalence> value)
    {
        ConceptMapEquivalence? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
    {
        ConceptMap.ConceptMapGroupUnmappedMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalDeleteStatus> value)
    {
        CapabilityStatement.ConditionalDeleteStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalReadStatus> value)
    {
        CapabilityStatement.ConditionalReadStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentDataMeaning> value)
    {
        Consent.ConsentDataMeaning? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentProvisionType> value)
    {
        Consent.ConsentProvisionType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentState> value)
    {
        Consent.ConsentState? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConstraintSeverity> value)
    {
        ConstraintSeverity? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointSystem> value)
    {
        ContactPoint.ContactPointSystem? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointUse> value)
    {
        ContactPoint.ContactPointUse? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contract.ContractResourcePublicationStatusCodes> value)
    {
        Contract.ContractResourcePublicationStatusCodes? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contract.ContractResourceStatusCodes> value)
    {
        Contract.ContractResourceStatusCodes? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contributor.ContributorType> value)
    {
        Contributor.ContributorType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Money.Currencies> value)
    {
        Money.Currencies? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DaysOfWeek> value)
    {
        DaysOfWeek? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DetectedIssue.DetectedIssueSeverity> value)
    {
        DetectedIssue.DetectedIssueSeverity? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationStatus> value)
    {
        ObservationStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationState> value)
    {
        DeviceMetric.DeviceMetricCalibrationState? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationType> value)
    {
        DeviceMetric.DeviceMetricCalibrationType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCategory> value)
    {
        DeviceMetric.DeviceMetricCategory? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricColor> value)
    {
        DeviceMetric.DeviceMetricColor? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricOperationalStatus> value)
    {
        DeviceMetric.DeviceMetricOperationalStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceNameType> value)
    {
        DeviceNameType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceUseStatement.DeviceUseStatementStatus> value)
    {
        DeviceUseStatement.DeviceUseStatementStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DiagnosticReport.DiagnosticReportStatus> value)
    {
        DiagnosticReport.DiagnosticReportStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.DiscriminatorType> value)
    {
        ElementDefinition.DiscriminatorType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Composition.V3ConfidentialityClassification> value)
    {
        Composition.V3ConfidentialityClassification? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.DocumentMode> value)
    {
        CapabilityStatement.DocumentMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DocumentReferenceStatus> value)
    {
        DocumentReferenceStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DocumentRelationshipType> value)
    {
        DocumentRelationshipType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
    {
        CoverageEligibilityRequest.EligibilityRequestPurpose? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
    {
        CoverageEligibilityResponse.EligibilityResponsePurpose? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.EnableWhenBehavior> value)
    {
        Questionnaire.EnableWhenBehavior? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Encounter.EncounterLocationStatus> value)
    {
        Encounter.EncounterLocationStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Encounter.EncounterStatus> value)
    {
        Encounter.EncounterStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Endpoint.EndpointStatus> value)
    {
        Endpoint.EndpointStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EpisodeOfCare.EpisodeOfCareStatus> value)
    {
        EpisodeOfCare.EpisodeOfCareStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.EventCapabilityMode> value)
    {
        CapabilityStatement.EventCapabilityMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Timing.EventTiming> value)
    {
        Timing.EventTiming? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VariableTypeCode> value)
    {
        VariableTypeCode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ExampleScenario.ExampleScenarioActorType> value)
    {
        ExampleScenario.ExampleScenarioActorType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
    {
        ExplanationOfBenefit.ExplanationOfBenefitStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EffectEvidenceSynthesis.ExposureStateCode> value)
    {
        EffectEvidenceSynthesis.ExposureStateCode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.ExtensionContextType> value)
    {
        StructureDefinition.ExtensionContextType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRAllTypes> value)
    {
        FHIRAllTypes? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRDefinedType> value)
    {
        FHIRDefinedType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Device.FHIRDeviceStatus> value)
    {
        Device.FHIRDeviceStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResourceType> value)
    {
        ResourceType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Substance.FHIRSubstanceStatus> value)
    {
        Substance.FHIRSubstanceStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRVersion> value)
    {
        FHIRVersion? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FamilyMemberHistory.FamilyHistoryStatus> value)
    {
        FamilyMemberHistory.FamilyHistoryStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FilterOperator> value)
    {
        FilterOperator? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Flag.FlagStatus> value)
    {
        Flag.FlagStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Goal.GoalLifecycleStatus> value)
    {
        Goal.GoalLifecycleStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentRule> value)
    {
        GraphDefinition.GraphCompartmentRule? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentUse> value)
    {
        GraphDefinition.GraphCompartmentUse? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GroupMeasureCode> value)
    {
        GroupMeasureCode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Group.GroupType> value)
    {
        Group.GroupType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GuidanceResponse.GuidanceResponseStatus> value)
    {
        GuidanceResponse.GuidanceResponseStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.GuidePageGeneration> value)
    {
        ImplementationGuide.GuidePageGeneration? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.GuideParameterCode> value)
    {
        ImplementationGuide.GuideParameterCode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.HTTPVerb> value)
    {
        Bundle.HTTPVerb? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Identifier.IdentifierUse> value)
    {
        Identifier.IdentifierUse? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Person.IdentityAssuranceLevel> value)
    {
        Person.IdentityAssuranceLevel? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImagingStudy.ImagingStudyStatus> value)
    {
        ImagingStudy.ImagingStudyStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
    {
        ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Immunization.ImmunizationStatusCodes> value)
    {
        Immunization.ImmunizationStatusCodes? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Invoice.InvoiceStatus> value)
    {
        Invoice.InvoiceStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationOutcome.IssueSeverity> value)
    {
        OperationOutcome.IssueSeverity? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationOutcome.IssueType> value)
    {
        OperationOutcome.IssueType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Patient.LinkType> value)
    {
        Patient.LinkType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Linkage.LinkageType> value)
    {
        Linkage.LinkageType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ListMode> value)
    {
        ListMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<List.ListStatus> value)
    {
        List.ListStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Location.LocationMode> value)
    {
        Location.LocationMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Location.LocationStatus> value)
    {
        Location.LocationStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportStatus> value)
    {
        MeasureReport.MeasureReportStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportType> value)
    {
        MeasureReport.MeasureReportType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
    {
        MedicationAdministration.MedicationAdministrationStatusCodes? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationDispense.MedicationDispenseStatusCodes> value)
    {
        MedicationDispense.MedicationDispenseStatusCodes? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
    {
        MedicationKnowledge.MedicationKnowledgeStatusCodes? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationRequestIntent> value)
    {
        MedicationRequest.MedicationRequestIntent? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationrequestStatus> value)
    {
        MedicationRequest.MedicationrequestStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationStatement.MedicationStatusCodes> value)
    {
        MedicationStatement.MedicationStatusCodes? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Medication.MedicationStatusCodes> value)
    {
        Medication.MedicationStatusCodes? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageDefinition.MessageSignificanceCategory> value)
    {
        MessageDefinition.MessageSignificanceCategory? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageheaderResponseRequest> value)
    {
        MessageheaderResponseRequest? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code value)
    {
        string a_ = value?.Value;
        return a_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<HumanName.NameUse> value)
    {
        HumanName.NameUse? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemIdentifierType> value)
    {
        NamingSystem.NamingSystemIdentifierType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemType> value)
    {
        NamingSystem.NamingSystemType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Narrative.NarrativeStatus> value)
    {
        Narrative.NarrativeStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NoteType> value)
    {
        NoteType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestIntent> value)
    {
        RequestIntent? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationDataType> value)
    {
        ObservationDefinition.ObservationDataType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationRangeCategory> value)
    {
        ObservationDefinition.ObservationRangeCategory? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationDefinition.OperationKind> value)
    {
        OperationDefinition.OperationKind? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationParameterUse> value)
    {
        OperationParameterUse? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.OrientationType> value)
    {
        MolecularSequence.OrientationType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Appointment.ParticipantRequired> value)
    {
        Appointment.ParticipantRequired? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ParticipationStatus> value)
    {
        ParticipationStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.PropertyRepresentation> value)
    {
        ElementDefinition.PropertyRepresentation? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystem.PropertyType> value)
    {
        CodeSystem.PropertyType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Provenance.ProvenanceEntityRole> value)
    {
        Provenance.ProvenanceEntityRole? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<PublicationStatus> value)
    {
        PublicationStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.QualityType> value)
    {
        MolecularSequence.QualityType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Quantity.QuantityComparator> value)
    {
        Quantity.QuantityComparator? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemOperator> value)
    {
        Questionnaire.QuestionnaireItemOperator? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemType> value)
    {
        Questionnaire.QuestionnaireItemType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
    {
        QuestionnaireResponse.QuestionnaireResponseStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ReferenceHandlingPolicy> value)
    {
        CapabilityStatement.ReferenceHandlingPolicy? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.ReferenceVersionRules> value)
    {
        ElementDefinition.ReferenceVersionRules? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RelatedArtifact.RelatedArtifactType> value)
    {
        RelatedArtifact.RelatedArtifactType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClaimProcessingCodes> value)
    {
        ClaimProcessingCodes? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.RepositoryType> value)
    {
        MolecularSequence.RepositoryType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchElementDefinition.ResearchElementType> value)
    {
        ResearchElementDefinition.ResearchElementType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchStudy.ResearchStudyStatus> value)
    {
        ResearchStudy.ResearchStudyStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchSubject.ResearchSubjectStatus> value)
    {
        ResearchSubject.ResearchSubjectStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ResourceVersionPolicy> value)
    {
        CapabilityStatement.ResourceVersionPolicy? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageHeader.ResponseType> value)
    {
        MessageHeader.ResponseType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.RestfulCapabilityMode> value)
    {
        CapabilityStatement.RestfulCapabilityMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.SPDXLicense> value)
    {
        ImplementationGuide.SPDXLicense? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.SearchComparator> value)
    {
        SearchParameter.SearchComparator? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.SearchEntryMode> value)
    {
        Bundle.SearchEntryMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.SearchModifierCode> value)
    {
        SearchParameter.SearchModifierCode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParamType> value)
    {
        SearchParamType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.SequenceType> value)
    {
        MolecularSequence.SequenceType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.SlicingRules> value)
    {
        ElementDefinition.SlicingRules? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Slot.SlotStatus> value)
    {
        Slot.SlotStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DataRequirement.SortDirection> value)
    {
        DataRequirement.SortDirection? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SpecimenDefinition.SpecimenContainedPreference> value)
    {
        SpecimenDefinition.SpecimenContainedPreference? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Specimen.SpecimenStatus> value)
    {
        Specimen.SpecimenStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VerificationResult.StatusCode> value)
    {
        VerificationResult.StatusCode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.StrandType> value)
    {
        MolecularSequence.StrandType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.StructureDefinitionKind> value)
    {
        StructureDefinition.StructureDefinitionKind? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapContextType> value)
    {
        StructureMap.StructureMapContextType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapGroupTypeMode> value)
    {
        StructureMap.StructureMapGroupTypeMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapInputMode> value)
    {
        StructureMap.StructureMapInputMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapModelMode> value)
    {
        StructureMap.StructureMapModelMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapSourceListMode> value)
    {
        StructureMap.StructureMapSourceListMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTargetListMode> value)
    {
        StructureMap.StructureMapTargetListMode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTransform> value)
    {
        StructureMap.StructureMapTransform? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Subscription.SubscriptionChannelType> value)
    {
        Subscription.SubscriptionChannelType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Subscription.SubscriptionStatus> value)
    {
        Subscription.SubscriptionStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SupplyDelivery.SupplyDeliveryStatus> value)
    {
        SupplyDelivery.SupplyDeliveryStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SupplyRequest.SupplyRequestStatus> value)
    {
        SupplyRequest.SupplyRequestStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.SystemRestfulInteraction> value)
    {
        CapabilityStatement.SystemRestfulInteraction? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Task.TaskIntent> value)
    {
        Task.TaskIntent? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Task.TaskStatus> value)
    {
        Task.TaskStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportActionResult> value)
    {
        TestReport.TestReportActionResult? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportParticipantType> value)
    {
        TestReport.TestReportParticipantType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportResult> value)
    {
        TestReport.TestReportResult? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportStatus> value)
    {
        TestReport.TestReportStatus? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.TestScriptRequestMethodCode> value)
    {
        TestScript.TestScriptRequestMethodCode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TriggerDefinition.TriggerType> value)
    {
        TriggerDefinition.TriggerType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.TypeDerivationRule> value)
    {
        StructureDefinition.TypeDerivationRule? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.TypeRestfulInteraction> value)
    {
        CapabilityStatement.TypeRestfulInteraction? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Device.UDIEntryType> value)
    {
        Device.UDIEntryType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Timing.UnitsOfTime> value)
    {
        Timing.UnitsOfTime? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClaimUseCode> value)
    {
        ClaimUseCode? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VisionPrescription.VisionBase> value)
    {
        VisionPrescription.VisionBase? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VisionPrescription.VisionEyes> value)
    {
        VisionPrescription.VisionEyes? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.XPathUsageType> value)
    {
        SearchParameter.XPathUsageType? a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Base64Binary value)
    {
        byte[] a_ = value?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, FhirString value)
    {
        string a_ = value?.Value;
        return a_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, FhirUri value)
    {
        string a_ = value?.Value;
        return a_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, XHtml value)
    {
        string a_ = value?.Value;
        return a_;
    }


    [CqlFunctionDefinition("ToBoolean")]
    public bool? ToBoolean(CqlContext context, FhirBoolean value)
    {
        bool? a_ = value?.Value;
        return a_;
    }


    [CqlFunctionDefinition("ToDate")]
    public CqlDate ToDate(CqlContext context, Date value)
    {
        string a_ = value?.Value;
        CqlDate b_ = context.Operators.ConvertStringToDate(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToDateTime")]
    public CqlDateTime ToDateTime(CqlContext context, FhirDateTime value)
    {
        CqlDateTime a_ = context.Operators.Convert<CqlDateTime>(value);
        return a_;
    }


    [CqlFunctionDefinition("ToDateTime")]
    public CqlDateTime ToDateTime(CqlContext context, Instant value)
    {
        DateTimeOffset? a_ = value?.Value;
        CqlDateTime b_ = context.Operators.Convert<CqlDateTime>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToDecimal")]
    public decimal? ToDecimal(CqlContext context, FhirDecimal value)
    {
        decimal? a_ = value?.Value;
        return a_;
    }


    [CqlFunctionDefinition("ToInteger")]
    public int? ToInteger(CqlContext context, Integer value)
    {
        int? a_ = value?.Value;
        return a_;
    }


    [CqlFunctionDefinition("ToTime")]
    public CqlTime ToTime(CqlContext context, Time value)
    {
        string a_ = value?.Value;
        CqlTime b_ = context.Operators.ConvertStringToTime(a_);
        return b_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private FHIRHelpers_4_3_000() {}

    public static FHIRHelpers_4_3_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "FHIRHelpers";
    public string Version => "4.3.000";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

}

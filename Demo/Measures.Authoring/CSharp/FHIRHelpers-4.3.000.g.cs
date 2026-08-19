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
[CqlLibrary("FHIRHelpers", "4.3.000")]
public partial class FHIRHelpers_4_3_000 : ILibrary, ISingleton<FHIRHelpers_4_3_000>
{
    #region Functions and Expressions (263)

    [CqlFunctionDefinition("ToInterval")]
    [CqlTag("description", "Converts the given [Period](https://hl7.org/fhir/datatypes.html#Period)\nvalue to a CQL DateTime Interval")]
    [CqlTag("comment", "If the start value of the given period is unspecified, the starting\nboundary of the resulting interval will be open (meaning the start of the interval\nis unknown, as opposed to interpreted as the beginning of time).")]
    public CqlInterval<CqlDateTime?>? ToInterval(CqlContext context, Period? period)
    {
        if (period is null)
        {
            return null as CqlInterval<CqlDateTime?>;
        }
        else if (period?.StartElement is null)
        {
            FhirDateTime? a_ = period?.StartElement!;
            CqlDateTime? b_ = context!.Operators.Convert<CqlDateTime?>(a_);
            FhirDateTime? c_ = period?.EndElement!;
            CqlDateTime? d_ = context!.Operators.Convert<CqlDateTime?>(c_);
            CqlInterval<CqlDateTime?>? e_ = context!.Operators.Interval(b_, d_, false, true);
            return e_;
        }
        else
        {
            FhirDateTime? f_ = period?.StartElement!;
            CqlDateTime? g_ = context!.Operators.Convert<CqlDateTime?>(f_);
            FhirDateTime? h_ = period?.EndElement!;
            CqlDateTime? i_ = context!.Operators.Convert<CqlDateTime?>(h_);
            CqlInterval<CqlDateTime?>? j_ = context!.Operators.Interval(g_, i_, true, true);
            return j_;
        }
    }


    [CqlFunctionDefinition("ToInterval")]
    [CqlTag("description", "Converts the given FHIR [Quantity](https://hl7.org/fhir/datatypes.html#Quantity) value to a CQL Interval of Quantity.")]
    [CqlTag("comment", "If the given quantity has a comparator, it is used to construct an interval based on the value of the comparator. If the comparator\nis less than, the resulting interval will start with a null closed boundary and end with an open boundary on the quantity. If the comparator\nis less than or equal, the resulting interval will start with a null closed boundary and end with a closed boundary on the quantity. If the \ncomparator is greater or equal, the resulting interval will start with a closed boundary on the quantity and end with a closed null boundary.\nIf the comparator is greatter than, the resulting interval will start with an open boundary on the quantity and end with a closed null boundary.\nIf no comparator is specified, the resulting interval will start and end with a closed boundary on the quantity.")]
    public CqlInterval<CqlQuantity?>? ToInterval(CqlContext context, Quantity? quantity)
    {
        if (quantity is null)
        {
            return null as CqlInterval<CqlQuantity?>;
        }
        else
        {
            Code<Quantity.QuantityComparator>? a_ = quantity?.ComparatorElement!;
            Quantity.QuantityComparator? b_ = a_?.Value!;
            string? c_ = context!.Operators.Convert<string?>(b_);
            bool? d_ = context!.Operators.Equal(c_, "<");
            if (d_ ?? false)
            {
                CqlQuantity? e_ = this.ToQuantityIgnoringComparator(context, quantity);
                CqlInterval<CqlQuantity?>? f_ = context!.Operators.Interval(default, e_, true, false);
                return f_;
            }
            else
            {
                Code<Quantity.QuantityComparator>? g_ = quantity?.ComparatorElement!;
                Quantity.QuantityComparator? h_ = g_?.Value!;
                string? i_ = context!.Operators.Convert<string?>(h_);
                bool? j_ = context!.Operators.Equal(i_, "<=");
                if (j_ ?? false)
                {
                    CqlQuantity? k_ = this.ToQuantityIgnoringComparator(context, quantity);
                    CqlInterval<CqlQuantity?>? l_ = context!.Operators.Interval(default, k_, true, true);
                    return l_;
                }
                else
                {
                    Code<Quantity.QuantityComparator>? m_ = quantity?.ComparatorElement!;
                    Quantity.QuantityComparator? n_ = m_?.Value!;
                    string? o_ = context!.Operators.Convert<string?>(n_);
                    bool? p_ = context!.Operators.Equal(o_, ">=");
                    if (p_ ?? false)
                    {
                        CqlQuantity? q_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity?>? r_ = context!.Operators.Interval(q_, default, true, true);
                        return r_;
                    }
                    else
                    {
                        Code<Quantity.QuantityComparator>? s_ = quantity?.ComparatorElement!;
                        Quantity.QuantityComparator? t_ = s_?.Value!;
                        string? u_ = context!.Operators.Convert<string?>(t_);
                        bool? v_ = context!.Operators.Equal(u_, ">");
                        if (v_ ?? false)
                        {
                            CqlQuantity? w_ = this.ToQuantityIgnoringComparator(context, quantity);
                            CqlInterval<CqlQuantity?>? x_ = context!.Operators.Interval(w_, default, false, true);
                            return x_;
                        }
                        else
                        {
                            CqlQuantity? y_ = this.ToQuantity(context, quantity);
                            CqlInterval<CqlQuantity?>? z_ = context!.Operators.Interval(y_, y_, true, true);
                            return z_;
                        }
                    }
                }
            }
        }
    }


    [CqlFunctionDefinition("ToInterval")]
    [CqlTag("description", "Converts the given FHIR [Range](https://hl7.org/fhir/datatypes.html#Range) value to a CQL Interval of Quantity")]
    public CqlInterval<CqlQuantity?>? ToInterval(CqlContext context, Range? range)
    {
        if (range is null)
        {
            return null as CqlInterval<CqlQuantity?>;
        }
        else
        {
            Quantity? a_ = range?.Low!;
            CqlQuantity? b_ = this.ToQuantity(context, a_);
            Quantity? c_ = range?.High!;
            CqlQuantity? d_ = this.ToQuantity(context, c_);
            CqlInterval<CqlQuantity?>? e_ = context!.Operators.Interval(b_, d_, true, true);
            return e_;
        }
    }


    [CqlFunctionDefinition("ToCalendarUnit")]
    [CqlTag("description", "Converts a UCUM definite duration unit to a CQL calendar duration\nunit using conversions specified in the [quantities](https://cql.hl7.org/02-authorsguide.html#quantities) \ntopic of the CQL specification.")]
    [CqlTag("comment", "Note that for durations above days (or weeks), the conversion is understood to be approximate")]
    public string? ToCalendarUnit(CqlContext context, string? unit)
    {
        if ((context!.Operators.Equal(unit, "ms")) ?? false)
        {
            return "millisecond";
        }
        else if ((context!.Operators.Equal(unit, "s")) ?? false)
        {
            return "second";
        }
        else if ((context!.Operators.Equal(unit, "min")) ?? false)
        {
            return "minute";
        }
        else if ((context!.Operators.Equal(unit, "h")) ?? false)
        {
            return "hour";
        }
        else if ((context!.Operators.Equal(unit, "d")) ?? false)
        {
            return "day";
        }
        else if ((context!.Operators.Equal(unit, "wk")) ?? false)
        {
            return "week";
        }
        else if ((context!.Operators.Equal(unit, "mo")) ?? false)
        {
            return "month";
        }
        else if ((context!.Operators.Equal(unit, "a")) ?? false)
        {
            return "year";
        }
        else
        {
            return unit;
        }
    }


    [CqlFunctionDefinition("ToQuantity")]
    [CqlTag("description", "Converts the given FHIR [Quantity](https://hl7.org/fhir/datatypes.html#Quantity) \nvalue to a CQL Quantity")]
    [CqlTag("comment", "If the given quantity has a comparator specified, a runtime error is raised. If the given quantity\nhas a system other than UCUM (i.e. `http://unitsofmeasure.org`) or CQL calendar units (i.e. `http://hl7.org/fhirpath/CodeSystem/calendar-units`)\nan error is raised. For UCUM to calendar units, the `ToCalendarUnit` function is used.")]
    [CqlTag("seealso", "ToCalendarUnit")]
    public CqlQuantity? ToQuantity(CqlContext context, Quantity? quantity)
    {
        if (quantity is null)
        {
            return default;
        }
        else if (quantity?.ValueElement is null)
        {
            return default;
        }
        else
        {
            Code<Quantity.QuantityComparator>? a_ = quantity?.ComparatorElement!;
            bool? b_ = context!.Operators.Not((bool?)(a_ is null));
            if (b_ ?? false)
            {
                object? c_ = context!.Operators.Message<object?>((object?)null, "FHIRHelpers.ToQuantity.ComparatorQuantityNotSupported"!, "Error"!, ("FHIR Quantity value has a comparator and cannot be converted to a System.Quantity value.")!);
                return c_ as CqlQuantity;
            }
            else
            {
                FhirUri? d_ = quantity?.SystemElement!;
                string? e_ = d_?.Value!;
                bool? f_ = context!.Operators.Equal(e_, "http://unitsofmeasure.org");
                bool? g_ = context!.Operators.Or((bool?)(d_ is null), f_);
                bool? h_ = context!.Operators.Equal(e_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
                bool? i_ = context!.Operators.Or(g_, h_);
                if (i_ ?? false)
                {
                    FhirDecimal? j_ = quantity?.ValueElement!;
                    decimal? k_ = j_?.Value!;
                    Code? l_ = quantity?.CodeElement!;
                    string? m_ = l_?.Value!;
                    FhirString? n_ = quantity?.UnitElement!;
                    string? o_ = n_?.Value!;
                    string? p_ = this.ToCalendarUnit(context, (m_ ?? o_) ?? "1");
                    return new CqlQuantity(k_, p_);
                }
                else
                {
                    FhirString? q_ = quantity?.UnitElement!;
                    string? r_ = q_?.Value!;
                    string? s_ = context!.Operators.Concatenate("Invalid FHIR Quantity code: ", r_ ?? "");
                    string? t_ = context!.Operators.Concatenate(s_ ?? "", " (");
                    FhirUri? u_ = quantity?.SystemElement!;
                    string? v_ = u_?.Value!;
                    string? w_ = context!.Operators.Concatenate(t_ ?? "", v_ ?? "");
                    string? x_ = context!.Operators.Concatenate(w_ ?? "", "|");
                    Code? y_ = quantity?.CodeElement!;
                    string? z_ = y_?.Value!;
                    string? aa_ = context!.Operators.Concatenate(x_ ?? "", z_ ?? "");
                    string? ab_ = context!.Operators.Concatenate(aa_ ?? "", ")");
                    object? ac_ = context!.Operators.Message<object?>((object?)null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity"!, "Error"!, ab_!);
                    return ac_ as CqlQuantity;
                }
            }
        }
    }


    [CqlFunctionDefinition("ToQuantityIgnoringComparator")]
    [CqlTag("description", "Converts the given FHIR [Quantity](https://hl7.org/fhir/datatypes.html#Quantity) value to a CQL Quantity, ignoring\nthe comparator element. This function should only be used when an application is justified in ignoring the comparator value (i.e. the\ncontext is looking for boundary).")]
    [CqlTag("comment", "If the given quantity has a system other than UCUM (i.e. `http://unitsofmeasure.org`) or CQL calendar units \n(i.e. `http://hl7.org/fhirpath/CodeSystem/calendar-units`) an error is raised. For UCUM to calendar units, the `ToCalendarUnit` function \nis used.")]
    [CqlTag("seealso", "ToCalendarUnit")]
    public CqlQuantity? ToQuantityIgnoringComparator(CqlContext context, Quantity? quantity)
    {
        if (quantity is null)
        {
            return default;
        }
        else if (quantity?.ValueElement is null)
        {
            return default;
        }
        else
        {
            FhirUri? a_ = quantity?.SystemElement!;
            string? b_ = a_?.Value!;
            bool? c_ = context!.Operators.Equal(b_, "http://unitsofmeasure.org");
            bool? d_ = context!.Operators.Or((bool?)(a_ is null), c_);
            bool? e_ = context!.Operators.Equal(b_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
            bool? f_ = context!.Operators.Or(d_, e_);
            if (f_ ?? false)
            {
                FhirDecimal? g_ = quantity?.ValueElement!;
                decimal? h_ = g_?.Value!;
                Code? i_ = quantity?.CodeElement!;
                string? j_ = i_?.Value!;
                FhirString? k_ = quantity?.UnitElement!;
                string? l_ = k_?.Value!;
                string? m_ = this.ToCalendarUnit(context, (j_ ?? l_) ?? "1");
                return new CqlQuantity(h_, m_);
            }
            else
            {
                FhirString? n_ = quantity?.UnitElement!;
                string? o_ = n_?.Value!;
                string? p_ = context!.Operators.Concatenate("Invalid FHIR Quantity code: ", o_ ?? "");
                string? q_ = context!.Operators.Concatenate(p_ ?? "", " (");
                FhirUri? r_ = quantity?.SystemElement!;
                string? s_ = r_?.Value!;
                string? t_ = context!.Operators.Concatenate(q_ ?? "", s_ ?? "");
                string? u_ = context!.Operators.Concatenate(t_ ?? "", "|");
                Code? v_ = quantity?.CodeElement!;
                string? w_ = v_?.Value!;
                string? x_ = context!.Operators.Concatenate(u_ ?? "", w_ ?? "");
                string? y_ = context!.Operators.Concatenate(x_ ?? "", ")");
                object? z_ = context!.Operators.Message<object?>((object?)null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity"!, "Error"!, y_!);
                return z_ as CqlQuantity;
            }
        }
    }


    [CqlFunctionDefinition("ToRatio")]
    [CqlTag("description", "Converts the given FHIR [Ratio](https://hl7.org/fhir/datatypes.html#Ratio) value to a CQL Ratio.")]
    public CqlRatio? ToRatio(CqlContext context, Ratio? ratio)
    {
        if (ratio is null)
        {
            return default;
        }
        else
        {
            Quantity? a_ = ratio?.Numerator!;
            CqlQuantity? b_ = this.ToQuantity(context, a_);
            Quantity? c_ = ratio?.Denominator!;
            CqlQuantity? d_ = this.ToQuantity(context, c_);
            return new CqlRatio(b_, d_);
        }
    }


    [CqlFunctionDefinition("ToCode")]
    [CqlTag("description", "Converts the given FHIR [Coding](https://hl7.org/fhir/datatypes.html#Coding) value to a CQL Code.")]
    public CqlCode? ToCode(CqlContext context, Coding? coding)
    {
        if (coding is null)
        {
            return default;
        }
        else
        {
            Code? a_ = coding?.CodeElement!;
            string? b_ = a_?.Value!;
            FhirUri? c_ = coding?.SystemElement!;
            string? d_ = c_?.Value!;
            FhirString? e_ = coding?.VersionElement!;
            string? f_ = e_?.Value!;
            FhirString? g_ = coding?.DisplayElement!;
            string? h_ = g_?.Value!;
            return new CqlCode(b_, d_, f_, h_);
        }
    }


    [CqlFunctionDefinition("ToConcept")]
    [CqlTag("description", "Converts the given FHIR [CodeableConcept](https://hl7.org/fhir/datatypes.html#CodeableConcept) value to a CQL Concept.")]
    public CqlConcept? ToConcept(CqlContext context, CodeableConcept? concept)
    {
        if (concept is null)
        {
            return default;
        }
        else
        {
            List<Coding?>? a_ = concept?.Coding!;

            CqlCode? b_(Coding? C) {
                CqlCode? f_ = this.ToCode(context, C);
                return f_;
            }

            IEnumerable<CqlCode?>? c_ = context!.Operators.SelectDistinct<Coding?, CqlCode?>((IEnumerable<Coding?>?)a_, b_);
            FhirString? d_ = concept?.TextElement!;
            string? e_ = d_?.Value!;
            return new CqlConcept(c_!, e_);
        }
    }


    [CqlFunctionDefinition("ToValueSet")]
    [CqlTag("description", "Converts the given value (assumed to be a URI) to a CQL [ValueSet](https://cql.hl7.org/09-b-cqlreference.html#valueset)")]
    public CqlValueSet? ToValueSet(CqlContext context, string? uri) =>
    (uri is null
        ? default
        : new CqlValueSet(uri!, default));


    [CqlFunctionDefinition("reference")]
    [CqlTag("description", "Constructs a FHIR [Reference](https://hl7.org/fhir/datatypes.html#Reference) from the given reference (assumed to be a FHIR resource URL)")]
    public ResourceReference? reference(CqlContext context, string? reference)
    {
        if (reference is null)
        {
            return default;
        }
        else
        {
            ResourceReference? a_ = new ResourceReference
            {
                ReferenceElement = new FhirString(reference),
            };
            return a_;
        }
    }


    [CqlFunctionDefinition("reference")]
    public ResourceReference? reference(CqlContext context, Resource? resource) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.reference is not implemented."));


    [CqlFunctionDefinition("ToValue")]
    [CqlTag("description", "Converts the given value to a CQL value using the appropriate accessor or conversion function.")]
    [CqlTag("comment", "TODO: document conversion")]
    public object? ToValue(CqlContext context, object? value)
    {
        if (value is Base64Binary)
        {
            byte[]? a_ = ((value as Base64Binary)?.Value)!;
            string? b_ = context!.Operators.Convert<string?>(a_);
            return b_;
        }
        else if (value is FhirBoolean)
        {
            bool? c_ = ((value as FhirBoolean)?.Value)!;
            return c_;
        }
        else if (value is Canonical)
        {
            string? d_ = ((value as Canonical)?.Value)!;
            return d_;
        }
        else if (value is Code)
        {
            string? e_ = ((value as Code)?.Value)!;
            return e_;
        }
        else if (value is Date)
        {
            string? f_ = ((value as Date)?.Value)!;
            CqlDate? g_ = context!.Operators.ConvertStringToDate(f_);
            return g_;
        }
        else if (value is FhirDateTime)
        {
            CqlDateTime? h_ = context!.Operators.Convert<CqlDateTime?>(value as FhirDateTime);
            return h_;
        }
        else if (value is FhirDecimal)
        {
            decimal? i_ = ((value as FhirDecimal)?.Value)!;
            return i_;
        }
        else if (value is Id)
        {
            string? j_ = ((value as Id)?.Value)!;
            return j_;
        }
        else if (value is Instant)
        {
            DateTimeOffset? k_ = ((value as Instant)?.Value)!;
            CqlDateTime? l_ = context!.Operators.Convert<CqlDateTime?>(k_);
            return l_;
        }
        else if (value is Integer)
        {
            int? m_ = ((value as Integer)?.Value)!;
            return m_;
        }
        else if (value is Markdown)
        {
            string? n_ = ((value as Markdown)?.Value)!;
            return n_;
        }
        else if (value is Oid)
        {
            string? o_ = ((value as Oid)?.Value)!;
            return o_;
        }
        else if (value is Integer)
        {
            int? p_ = ((value as Integer)?.Value)!;
            return p_;
        }
        else if (value is FhirString)
        {
            string? q_ = ((value as FhirString)?.Value)!;
            return q_;
        }
        else if (value is Time)
        {
            string? r_ = ((value as Time)?.Value)!;
            CqlTime? s_ = context!.Operators.ConvertStringToTime(r_);
            return s_;
        }
        else if (value is Integer)
        {
            int? t_ = ((value as Integer)?.Value)!;
            return t_;
        }
        else if (value is FhirUri)
        {
            string? u_ = ((value as FhirUri)?.Value)!;
            return u_;
        }
        else if (value is FhirUrl)
        {
            string? v_ = ((value as FhirUrl)?.Value)!;
            return v_;
        }
        else if (value is Uuid)
        {
            string? w_ = ((value as Uuid)?.Value)!;
            return w_;
        }
        else if (value is Age)
        {
            CqlQuantity? x_ = this.ToQuantity(context, value as Age);
            return x_;
        }
        else if (value is CodeableConcept)
        {
            CqlConcept? y_ = this.ToConcept(context, value as CodeableConcept);
            return y_;
        }
        else if (value is Coding)
        {
            CqlCode? z_ = this.ToCode(context, value as Coding);
            return z_;
        }
        else if (value is Count)
        {
            CqlQuantity? aa_ = this.ToQuantity(context, value as Count);
            return aa_;
        }
        else if (value is Distance)
        {
            CqlQuantity? ab_ = this.ToQuantity(context, value as Distance);
            return ab_;
        }
        else if (value is Duration)
        {
            CqlQuantity? ac_ = this.ToQuantity(context, value as Duration);
            return ac_;
        }
        else if (value is Quantity)
        {
            CqlQuantity? ad_ = this.ToQuantity(context, value as Quantity);
            return ad_;
        }
        else if (value is Range)
        {
            CqlInterval<CqlQuantity?>? ae_ = this.ToInterval(context, value as Range);
            return ae_;
        }
        else if (value is Period)
        {
            CqlInterval<CqlDateTime?>? af_ = this.ToInterval(context, value as Period);
            return af_;
        }
        else if (value is Ratio)
        {
            CqlRatio? ag_ = this.ToRatio(context, value as Ratio);
            return ag_;
        }
        else
        {
            return value;
        }
    }


    [CqlFunctionDefinition("resolve")]
    public Resource? resolve(CqlContext context, string? reference) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.resolve is not implemented."));


    [CqlFunctionDefinition("resolve")]
    public Resource? resolve(CqlContext context, ResourceReference? reference) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.resolve is not implemented."));


    [CqlFunctionDefinition("extension")]
    public IEnumerable<Extension?>? extension(CqlContext context, Element? element, string? url) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.extension is not implemented."));


    [CqlFunctionDefinition("extension")]
    public IEnumerable<Extension?>? extension(CqlContext context, DomainResource? resource, string? url) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.extension is not implemented."));


    [CqlFunctionDefinition("modifierExtension")]
    public IEnumerable<Extension?>? modifierExtension(CqlContext context, BackboneElement? element, string? url) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.modifierExtension is not implemented."));


    [CqlFunctionDefinition("modifierExtension")]
    public IEnumerable<Extension?>? modifierExtension(CqlContext context, DomainResource? resource, string? url) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.modifierExtension is not implemented."));


    [CqlFunctionDefinition("hasValue")]
    public bool? hasValue(CqlContext context, Element? element) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.hasValue is not implemented."));


    [CqlFunctionDefinition("getValue")]
    public object? getValue(CqlContext context, Element? element) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.getValue is not implemented."));


    [CqlFunctionDefinition("ofType")]
    public IEnumerable<object?>? ofType(CqlContext context, string? identifier) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.ofType is not implemented."));


    [CqlFunctionDefinition("is")]
    public bool? @is(CqlContext context, string? identifier) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.is is not implemented."));


    [CqlFunctionDefinition("as")]
    public object? @as(CqlContext context, string? identifier) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.as is not implemented."));


    [CqlFunctionDefinition("elementDefinition")]
    public ElementDefinition? elementDefinition(CqlContext context, Element? element) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.elementDefinition is not implemented."));


    [CqlFunctionDefinition("slice")]
    public IEnumerable<Element?>? slice(CqlContext context, Element? element, string? url, string? name) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.slice is not implemented."));


    [CqlFunctionDefinition("checkModifiers")]
    public Resource? checkModifiers(CqlContext context, Resource? resource) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));


    [CqlFunctionDefinition("checkModifiers")]
    public Resource? checkModifiers(CqlContext context, Resource? resource, string? modifier) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));


    [CqlFunctionDefinition("checkModifiers")]
    public Element? checkModifiers(CqlContext context, Element? element) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));


    [CqlFunctionDefinition("checkModifiers")]
    public Element? checkModifiers(CqlContext context, Element? element, string? modifier) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));


    [CqlFunctionDefinition("conformsTo")]
    public bool? conformsTo(CqlContext context, Resource? resource, string? structure) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.conformsTo is not implemented."));


    [CqlFunctionDefinition("memberOf")]
    public bool? memberOf(CqlContext context, Code? code, string? valueSet) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));


    [CqlFunctionDefinition("memberOf")]
    public bool? memberOf(CqlContext context, Coding? coding, string? valueSet) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));


    [CqlFunctionDefinition("memberOf")]
    public bool? memberOf(CqlContext context, CodeableConcept? concept, string? valueSet) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));


    [CqlFunctionDefinition("subsumes")]
    public bool? subsumes(CqlContext context, Coding? coding, Coding? subsumedCoding) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumes is not implemented."));


    [CqlFunctionDefinition("subsumes")]
    public bool? subsumes(CqlContext context, CodeableConcept? concept, CodeableConcept? subsumedConcept) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumes is not implemented."));


    [CqlFunctionDefinition("subsumedBy")]
    public bool? subsumedBy(CqlContext context, Coding? coding, Coding? subsumingCoding) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumedBy is not implemented."));


    [CqlFunctionDefinition("subsumedBy")]
    public bool? subsumedBy(CqlContext context, CodeableConcept? concept, CodeableConcept? subsumingConcept) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumedBy is not implemented."));


    [CqlFunctionDefinition("htmlChecks")]
    public bool? htmlChecks(CqlContext context, Element? element) =>
    throw (new NotImplementedException("External function FHIRHelpers-4.3.000.htmlChecks is not implemented."));


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Account.AccountStatus>? value)
    {
        Account.AccountStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ActionCardinalityBehavior>? value)
    {
        ActionCardinalityBehavior? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ActionConditionKind>? value)
    {
        ActionConditionKind? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ActionGroupingBehavior>? value)
    {
        ActionGroupingBehavior? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ActionParticipantType>? value)
    {
        ActionParticipantType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ActionPrecheckBehavior>? value)
    {
        ActionPrecheckBehavior? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ActionRelationshipType>? value)
    {
        ActionRelationshipType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ActionRequiredBehavior>? value)
    {
        ActionRequiredBehavior? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ActionSelectionBehavior>? value)
    {
        ActionSelectionBehavior? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ActivityDefinition.RequestResourceType>? value)
    {
        ActivityDefinition.RequestResourceType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Address.AddressType>? value)
    {
        Address.AddressType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Address.AddressUse>? value)
    {
        Address.AddressUse? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<AdministrativeGender>? value)
    {
        AdministrativeGender? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<AdverseEvent.AdverseEventActuality>? value)
    {
        AdverseEvent.AdverseEventActuality? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ElementDefinition.AggregationMode>? value)
    {
        ElementDefinition.AggregationMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCategory>? value)
    {
        AllergyIntolerance.AllergyIntoleranceCategory? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCriticality>? value)
    {
        AllergyIntolerance.AllergyIntoleranceCriticality? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceSeverity>? value)
    {
        AllergyIntolerance.AllergyIntoleranceSeverity? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceType>? value)
    {
        AllergyIntolerance.AllergyIntoleranceType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Appointment.AppointmentStatus>? value)
    {
        Appointment.AppointmentStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<TestScript.AssertionDirectionType>? value)
    {
        TestScript.AssertionDirectionType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<TestScript.AssertionOperatorType>? value)
    {
        TestScript.AssertionOperatorType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<TestScript.AssertionResponseTypes>? value)
    {
        TestScript.AssertionResponseTypes? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<AuditEvent.AuditEventAction>? value)
    {
        AuditEvent.AuditEventAction? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<AuditEvent.AuditEventAgentNetworkType>? value)
    {
        AuditEvent.AuditEventAgentNetworkType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<AuditEvent.AuditEventOutcome>? value)
    {
        AuditEvent.AuditEventOutcome? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<BindingStrength>? value)
    {
        BindingStrength? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory>? value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus>? value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale>? value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Bundle.BundleType>? value)
    {
        Bundle.BundleType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CapabilityStatementKind>? value)
    {
        CapabilityStatementKind? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CarePlan.CarePlanActivityKind>? value)
    {
        CarePlan.CarePlanActivityKind? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CarePlan.CarePlanActivityStatus>? value)
    {
        CarePlan.CarePlanActivityStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CarePlan.CarePlanIntent>? value)
    {
        CarePlan.CarePlanIntent? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<RequestStatus>? value)
    {
        RequestStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CareTeam.CareTeamStatus>? value)
    {
        CareTeam.CareTeamStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CatalogEntry.CatalogEntryRelationType>? value)
    {
        CatalogEntry.CatalogEntryRelationType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<InvoicePriceComponentType>? value)
    {
        InvoicePriceComponentType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ChargeItem.ChargeItemStatus>? value)
    {
        ChargeItem.ChargeItemStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<FinancialResourceStatusCodes>? value)
    {
        FinancialResourceStatusCodes? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ClinicalImpression.ClinicalImpressionStatus>? value)
    {
        ClinicalImpression.ClinicalImpressionStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<TerminologyCapabilities.CodeSearchSupport>? value)
    {
        TerminologyCapabilities.CodeSearchSupport? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CodeSystemContentMode>? value)
    {
        CodeSystemContentMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CodeSystem.CodeSystemHierarchyMeaning>? value)
    {
        CodeSystem.CodeSystemHierarchyMeaning? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<RequestPriority>? value)
    {
        RequestPriority? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<EventStatus>? value)
    {
        EventStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CompartmentType>? value)
    {
        CompartmentType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Composition.CompositionAttestationMode>? value)
    {
        Composition.CompositionAttestationMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CompositionStatus>? value)
    {
        CompositionStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ConceptMapEquivalence>? value)
    {
        ConceptMapEquivalence? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ConceptMap.ConceptMapGroupUnmappedMode>? value)
    {
        ConceptMap.ConceptMapGroupUnmappedMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CapabilityStatement.ConditionalDeleteStatus>? value)
    {
        CapabilityStatement.ConditionalDeleteStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CapabilityStatement.ConditionalReadStatus>? value)
    {
        CapabilityStatement.ConditionalReadStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Consent.ConsentDataMeaning>? value)
    {
        Consent.ConsentDataMeaning? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Consent.ConsentProvisionType>? value)
    {
        Consent.ConsentProvisionType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Consent.ConsentState>? value)
    {
        Consent.ConsentState? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ConstraintSeverity>? value)
    {
        ConstraintSeverity? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ContactPoint.ContactPointSystem>? value)
    {
        ContactPoint.ContactPointSystem? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ContactPoint.ContactPointUse>? value)
    {
        ContactPoint.ContactPointUse? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Contract.ContractResourcePublicationStatusCodes>? value)
    {
        Contract.ContractResourcePublicationStatusCodes? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Contract.ContractResourceStatusCodes>? value)
    {
        Contract.ContractResourceStatusCodes? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Contributor.ContributorType>? value)
    {
        Contributor.ContributorType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Money.Currencies>? value)
    {
        Money.Currencies? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<DaysOfWeek>? value)
    {
        DaysOfWeek? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<DetectedIssue.DetectedIssueSeverity>? value)
    {
        DetectedIssue.DetectedIssueSeverity? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ObservationStatus>? value)
    {
        ObservationStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationState>? value)
    {
        DeviceMetric.DeviceMetricCalibrationState? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationType>? value)
    {
        DeviceMetric.DeviceMetricCalibrationType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCategory>? value)
    {
        DeviceMetric.DeviceMetricCategory? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<DeviceMetric.DeviceMetricColor>? value)
    {
        DeviceMetric.DeviceMetricColor? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<DeviceMetric.DeviceMetricOperationalStatus>? value)
    {
        DeviceMetric.DeviceMetricOperationalStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<DeviceNameType>? value)
    {
        DeviceNameType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<DeviceUseStatement.DeviceUseStatementStatus>? value)
    {
        DeviceUseStatement.DeviceUseStatementStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<DiagnosticReport.DiagnosticReportStatus>? value)
    {
        DiagnosticReport.DiagnosticReportStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ElementDefinition.DiscriminatorType>? value)
    {
        ElementDefinition.DiscriminatorType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Composition.V3ConfidentialityClassification>? value)
    {
        Composition.V3ConfidentialityClassification? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CapabilityStatement.DocumentMode>? value)
    {
        CapabilityStatement.DocumentMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<DocumentReferenceStatus>? value)
    {
        DocumentReferenceStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<DocumentRelationshipType>? value)
    {
        DocumentRelationshipType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CoverageEligibilityRequest.EligibilityRequestPurpose>? value)
    {
        CoverageEligibilityRequest.EligibilityRequestPurpose? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CoverageEligibilityResponse.EligibilityResponsePurpose>? value)
    {
        CoverageEligibilityResponse.EligibilityResponsePurpose? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Questionnaire.EnableWhenBehavior>? value)
    {
        Questionnaire.EnableWhenBehavior? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Encounter.EncounterLocationStatus>? value)
    {
        Encounter.EncounterLocationStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Encounter.EncounterStatus>? value)
    {
        Encounter.EncounterStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Endpoint.EndpointStatus>? value)
    {
        Endpoint.EndpointStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<EpisodeOfCare.EpisodeOfCareStatus>? value)
    {
        EpisodeOfCare.EpisodeOfCareStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CapabilityStatement.EventCapabilityMode>? value)
    {
        CapabilityStatement.EventCapabilityMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Timing.EventTiming>? value)
    {
        Timing.EventTiming? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<VariableTypeCode>? value)
    {
        VariableTypeCode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ExampleScenario.ExampleScenarioActorType>? value)
    {
        ExampleScenario.ExampleScenarioActorType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ExplanationOfBenefit.ExplanationOfBenefitStatus>? value)
    {
        ExplanationOfBenefit.ExplanationOfBenefitStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<EffectEvidenceSynthesis.ExposureStateCode>? value)
    {
        EffectEvidenceSynthesis.ExposureStateCode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<StructureDefinition.ExtensionContextType>? value)
    {
        StructureDefinition.ExtensionContextType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<FHIRAllTypes>? value)
    {
        FHIRAllTypes? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<FHIRDefinedType>? value)
    {
        FHIRDefinedType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Device.FHIRDeviceStatus>? value)
    {
        Device.FHIRDeviceStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ResourceType>? value)
    {
        ResourceType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Substance.FHIRSubstanceStatus>? value)
    {
        Substance.FHIRSubstanceStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<FHIRVersion>? value)
    {
        FHIRVersion? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<FamilyMemberHistory.FamilyHistoryStatus>? value)
    {
        FamilyMemberHistory.FamilyHistoryStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<FilterOperator>? value)
    {
        FilterOperator? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Flag.FlagStatus>? value)
    {
        Flag.FlagStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Goal.GoalLifecycleStatus>? value)
    {
        Goal.GoalLifecycleStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentRule>? value)
    {
        GraphDefinition.GraphCompartmentRule? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentUse>? value)
    {
        GraphDefinition.GraphCompartmentUse? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<GroupMeasureCode>? value)
    {
        GroupMeasureCode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Group.GroupType>? value)
    {
        Group.GroupType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<GuidanceResponse.GuidanceResponseStatus>? value)
    {
        GuidanceResponse.GuidanceResponseStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ImplementationGuide.GuidePageGeneration>? value)
    {
        ImplementationGuide.GuidePageGeneration? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ImplementationGuide.GuideParameterCode>? value)
    {
        ImplementationGuide.GuideParameterCode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Bundle.HTTPVerb>? value)
    {
        Bundle.HTTPVerb? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Identifier.IdentifierUse>? value)
    {
        Identifier.IdentifierUse? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Person.IdentityAssuranceLevel>? value)
    {
        Person.IdentityAssuranceLevel? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ImagingStudy.ImagingStudyStatus>? value)
    {
        ImagingStudy.ImagingStudyStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes>? value)
    {
        ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Immunization.ImmunizationStatusCodes>? value)
    {
        Immunization.ImmunizationStatusCodes? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Invoice.InvoiceStatus>? value)
    {
        Invoice.InvoiceStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<OperationOutcome.IssueSeverity>? value)
    {
        OperationOutcome.IssueSeverity? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<OperationOutcome.IssueType>? value)
    {
        OperationOutcome.IssueType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Patient.LinkType>? value)
    {
        Patient.LinkType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Linkage.LinkageType>? value)
    {
        Linkage.LinkageType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ListMode>? value)
    {
        ListMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<List.ListStatus>? value)
    {
        List.ListStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Location.LocationMode>? value)
    {
        Location.LocationMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Location.LocationStatus>? value)
    {
        Location.LocationStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MeasureReport.MeasureReportStatus>? value)
    {
        MeasureReport.MeasureReportStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MeasureReport.MeasureReportType>? value)
    {
        MeasureReport.MeasureReportType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MedicationAdministration.MedicationAdministrationStatusCodes>? value)
    {
        MedicationAdministration.MedicationAdministrationStatusCodes? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MedicationDispense.MedicationDispenseStatusCodes>? value)
    {
        MedicationDispense.MedicationDispenseStatusCodes? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MedicationKnowledge.MedicationKnowledgeStatusCodes>? value)
    {
        MedicationKnowledge.MedicationKnowledgeStatusCodes? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MedicationRequest.MedicationRequestIntent>? value)
    {
        MedicationRequest.MedicationRequestIntent? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MedicationRequest.MedicationrequestStatus>? value)
    {
        MedicationRequest.MedicationrequestStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MedicationStatement.MedicationStatusCodes>? value)
    {
        MedicationStatement.MedicationStatusCodes? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Medication.MedicationStatusCodes>? value)
    {
        Medication.MedicationStatusCodes? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MessageDefinition.MessageSignificanceCategory>? value)
    {
        MessageDefinition.MessageSignificanceCategory? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MessageheaderResponseRequest>? value)
    {
        MessageheaderResponseRequest? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code? value)
    {
        string? a_ = value?.Value!;
        return a_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<HumanName.NameUse>? value)
    {
        HumanName.NameUse? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<NamingSystem.NamingSystemIdentifierType>? value)
    {
        NamingSystem.NamingSystemIdentifierType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<NamingSystem.NamingSystemType>? value)
    {
        NamingSystem.NamingSystemType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Narrative.NarrativeStatus>? value)
    {
        Narrative.NarrativeStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<NoteType>? value)
    {
        NoteType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<RequestIntent>? value)
    {
        RequestIntent? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ObservationDefinition.ObservationDataType>? value)
    {
        ObservationDefinition.ObservationDataType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ObservationDefinition.ObservationRangeCategory>? value)
    {
        ObservationDefinition.ObservationRangeCategory? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<OperationDefinition.OperationKind>? value)
    {
        OperationDefinition.OperationKind? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<OperationParameterUse>? value)
    {
        OperationParameterUse? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MolecularSequence.OrientationType>? value)
    {
        MolecularSequence.OrientationType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Appointment.ParticipantRequired>? value)
    {
        Appointment.ParticipantRequired? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ParticipationStatus>? value)
    {
        ParticipationStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ElementDefinition.PropertyRepresentation>? value)
    {
        ElementDefinition.PropertyRepresentation? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CodeSystem.PropertyType>? value)
    {
        CodeSystem.PropertyType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Provenance.ProvenanceEntityRole>? value)
    {
        Provenance.ProvenanceEntityRole? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<PublicationStatus>? value)
    {
        PublicationStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MolecularSequence.QualityType>? value)
    {
        MolecularSequence.QualityType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Quantity.QuantityComparator>? value)
    {
        Quantity.QuantityComparator? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemOperator>? value)
    {
        Questionnaire.QuestionnaireItemOperator? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemType>? value)
    {
        Questionnaire.QuestionnaireItemType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<QuestionnaireResponse.QuestionnaireResponseStatus>? value)
    {
        QuestionnaireResponse.QuestionnaireResponseStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CapabilityStatement.ReferenceHandlingPolicy>? value)
    {
        CapabilityStatement.ReferenceHandlingPolicy? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ElementDefinition.ReferenceVersionRules>? value)
    {
        ElementDefinition.ReferenceVersionRules? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<RelatedArtifact.RelatedArtifactType>? value)
    {
        RelatedArtifact.RelatedArtifactType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ClaimProcessingCodes>? value)
    {
        ClaimProcessingCodes? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MolecularSequence.RepositoryType>? value)
    {
        MolecularSequence.RepositoryType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ResearchElementDefinition.ResearchElementType>? value)
    {
        ResearchElementDefinition.ResearchElementType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ResearchStudy.ResearchStudyStatus>? value)
    {
        ResearchStudy.ResearchStudyStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ResearchSubject.ResearchSubjectStatus>? value)
    {
        ResearchSubject.ResearchSubjectStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CapabilityStatement.ResourceVersionPolicy>? value)
    {
        CapabilityStatement.ResourceVersionPolicy? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MessageHeader.ResponseType>? value)
    {
        MessageHeader.ResponseType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CapabilityStatement.RestfulCapabilityMode>? value)
    {
        CapabilityStatement.RestfulCapabilityMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ImplementationGuide.SPDXLicense>? value)
    {
        ImplementationGuide.SPDXLicense? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<SearchParameter.SearchComparator>? value)
    {
        SearchParameter.SearchComparator? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Bundle.SearchEntryMode>? value)
    {
        Bundle.SearchEntryMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<SearchParameter.SearchModifierCode>? value)
    {
        SearchParameter.SearchModifierCode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<SearchParamType>? value)
    {
        SearchParamType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MolecularSequence.SequenceType>? value)
    {
        MolecularSequence.SequenceType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ElementDefinition.SlicingRules>? value)
    {
        ElementDefinition.SlicingRules? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Slot.SlotStatus>? value)
    {
        Slot.SlotStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<DataRequirement.SortDirection>? value)
    {
        DataRequirement.SortDirection? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<SpecimenDefinition.SpecimenContainedPreference>? value)
    {
        SpecimenDefinition.SpecimenContainedPreference? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Specimen.SpecimenStatus>? value)
    {
        Specimen.SpecimenStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<VerificationResult.StatusCode>? value)
    {
        VerificationResult.StatusCode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<MolecularSequence.StrandType>? value)
    {
        MolecularSequence.StrandType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<StructureDefinition.StructureDefinitionKind>? value)
    {
        StructureDefinition.StructureDefinitionKind? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<StructureMap.StructureMapContextType>? value)
    {
        StructureMap.StructureMapContextType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<StructureMap.StructureMapGroupTypeMode>? value)
    {
        StructureMap.StructureMapGroupTypeMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<StructureMap.StructureMapInputMode>? value)
    {
        StructureMap.StructureMapInputMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<StructureMap.StructureMapModelMode>? value)
    {
        StructureMap.StructureMapModelMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<StructureMap.StructureMapSourceListMode>? value)
    {
        StructureMap.StructureMapSourceListMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<StructureMap.StructureMapTargetListMode>? value)
    {
        StructureMap.StructureMapTargetListMode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<StructureMap.StructureMapTransform>? value)
    {
        StructureMap.StructureMapTransform? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Subscription.SubscriptionChannelType>? value)
    {
        Subscription.SubscriptionChannelType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Subscription.SubscriptionStatus>? value)
    {
        Subscription.SubscriptionStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<SupplyDelivery.SupplyDeliveryStatus>? value)
    {
        SupplyDelivery.SupplyDeliveryStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<SupplyRequest.SupplyRequestStatus>? value)
    {
        SupplyRequest.SupplyRequestStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CapabilityStatement.SystemRestfulInteraction>? value)
    {
        CapabilityStatement.SystemRestfulInteraction? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Task.TaskIntent>? value)
    {
        Task.TaskIntent? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Task.TaskStatus>? value)
    {
        Task.TaskStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<TestReport.TestReportActionResult>? value)
    {
        TestReport.TestReportActionResult? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<TestReport.TestReportParticipantType>? value)
    {
        TestReport.TestReportParticipantType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<TestReport.TestReportResult>? value)
    {
        TestReport.TestReportResult? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<TestReport.TestReportStatus>? value)
    {
        TestReport.TestReportStatus? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<TestScript.TestScriptRequestMethodCode>? value)
    {
        TestScript.TestScriptRequestMethodCode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<TriggerDefinition.TriggerType>? value)
    {
        TriggerDefinition.TriggerType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<StructureDefinition.TypeDerivationRule>? value)
    {
        StructureDefinition.TypeDerivationRule? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<CapabilityStatement.TypeRestfulInteraction>? value)
    {
        CapabilityStatement.TypeRestfulInteraction? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Device.UDIEntryType>? value)
    {
        Device.UDIEntryType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<Timing.UnitsOfTime>? value)
    {
        Timing.UnitsOfTime? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<ClaimUseCode>? value)
    {
        ClaimUseCode? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<VisionPrescription.VisionBase>? value)
    {
        VisionPrescription.VisionBase? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<VisionPrescription.VisionEyes>? value)
    {
        VisionPrescription.VisionEyes? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Code<SearchParameter.XPathUsageType>? value)
    {
        SearchParameter.XPathUsageType? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, Base64Binary? value)
    {
        byte[]? a_ = value?.Value!;
        string? b_ = context!.Operators.Convert<string?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, FhirString? value)
    {
        string? a_ = value?.Value!;
        return a_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, FhirUri? value)
    {
        string? a_ = value?.Value!;
        return a_;
    }


    [CqlFunctionDefinition("ToString")]
    public string? ToString(CqlContext context, XHtml? value)
    {
        string? a_ = value?.Value!;
        return a_;
    }


    [CqlFunctionDefinition("ToBoolean")]
    public bool? ToBoolean(CqlContext context, FhirBoolean? value)
    {
        bool? a_ = value?.Value!;
        return a_;
    }


    [CqlFunctionDefinition("ToDate")]
    public CqlDate? ToDate(CqlContext context, Date? value)
    {
        string? a_ = value?.Value!;
        CqlDate? b_ = context!.Operators.ConvertStringToDate(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToDateTime")]
    public CqlDateTime? ToDateTime(CqlContext context, FhirDateTime? value)
    {
        CqlDateTime? a_ = context!.Operators.Convert<CqlDateTime?>(value);
        return a_;
    }


    [CqlFunctionDefinition("ToDateTime")]
    public CqlDateTime? ToDateTime(CqlContext context, Instant? value)
    {
        DateTimeOffset? a_ = value?.Value!;
        CqlDateTime? b_ = context!.Operators.Convert<CqlDateTime?>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToDecimal")]
    public decimal? ToDecimal(CqlContext context, FhirDecimal? value)
    {
        decimal? a_ = value?.Value!;
        return a_;
    }


    [CqlFunctionDefinition("ToInteger")]
    public int? ToInteger(CqlContext context, Integer? value)
    {
        int? a_ = value?.Value!;
        return a_;
    }


    [CqlFunctionDefinition("ToTime")]
    public CqlTime? ToTime(CqlContext context, Time? value)
    {
        string? a_ = value?.Value!;
        CqlTime? b_ = context!.Operators.ConvertStringToTime(a_);
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

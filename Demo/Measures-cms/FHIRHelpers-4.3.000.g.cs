using System;
using Tuples;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("FHIRHelpers", "4.3.000")]
public class FHIRHelpers_4_3_000
{


    internal CqlContext context;

    #region Cached values


    #endregion
    public FHIRHelpers_4_3_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");


    }
    [CqlDeclaration("ToInterval")]
    [CqlTag("description", "Converts the given [Period](https://hl7.org/fhir/datatypes.html#Period) value to a CQL DateTime Interval")]
    [CqlTag("comment", "If the start value of the given period is unspecified, the starting boundary of the resulting interval will be open (meaning the start of the interval is unknown, as opposed to interpreted as the beginning of time).")]
	public CqlInterval<CqlDateTime> ToInterval(Period period)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if ((period is null))
			{
				CqlInterval<CqlDateTime> b_ = null;

				return b_;
			}
			else if ((period?.StartElement is null))
			{
				var c_ = context.Operators.Convert<CqlDateTime>(period?.StartElement);
				var d_ = context.Operators.Convert<CqlDateTime>(period?.EndElement);
				var e_ = context.Operators.Interval(c_, d_, false, true);

				return e_;
			}
			else
			{
				var f_ = context.Operators.Convert<CqlDateTime>(period?.StartElement);
				var g_ = context.Operators.Convert<CqlDateTime>(period?.EndElement);
				var h_ = context.Operators.Interval(f_, g_, true, true);

				return h_;
			};
		};

		return a_();
	}

    [CqlDeclaration("ToInterval")]
    [CqlTag("description", "Converts the given FHIR [Quantity](https://hl7.org/fhir/datatypes.html#Quantity) value to a CQL Interval of Quantity.")]
    [CqlTag("comment", "If the given quantity has a comparator, it is used to construct an interval based on the value of the comparator. If the comparator is less than, the resulting interval will start with a null closed boundary and end with an open boundary on the quantity. If the comparator is less than or equal, the resulting interval will start with a null closed boundary and end with a closed boundary on the quantity. If the comparator is greater or equal, the resulting interval will start with a closed boundary on the quantity and end with a closed null boundary. If the comparator is greatter than, the resulting interval will start with an open boundary on the quantity and end with a closed null boundary. If no comparator is specified, the resulting interval will start and end with a closed boundary on the quantity.")]
	public CqlInterval<CqlQuantity> ToInterval(Quantity quantity)
	{
		CqlInterval<CqlQuantity> a_()
		{
			if ((quantity is null))
			{
				CqlInterval<CqlQuantity> b_ = null;

				return b_;
			}
			else
			{
				CqlInterval<CqlQuantity> c_()
				{
					bool d_()
					{
						var h_ = context.Operators.Convert<string>(quantity?.ComparatorElement?.Value);
						var i_ = context.Operators.Equal(h_, "<");

						return (i_ ?? false);
					};
					bool e_()
					{
						var j_ = context.Operators.Convert<string>(quantity?.ComparatorElement?.Value);
						var k_ = context.Operators.Equal(j_, "<=");

						return (k_ ?? false);
					};
					bool f_()
					{
						var l_ = context.Operators.Convert<string>(quantity?.ComparatorElement?.Value);
						var m_ = context.Operators.Equal(l_, ">=");

						return (m_ ?? false);
					};
					bool g_()
					{
						var n_ = context.Operators.Convert<string>(quantity?.ComparatorElement?.Value);
						var o_ = context.Operators.Equal(n_, ">");

						return (o_ ?? false);
					};
					if (d_())
					{
						var p_ = this.ToQuantityIgnoringComparator(quantity);
						var q_ = context.Operators.Interval(null, p_, true, false);

						return q_;
					}
					else if (e_())
					{
						var r_ = this.ToQuantityIgnoringComparator(quantity);
						var s_ = context.Operators.Interval(null, r_, true, true);

						return s_;
					}
					else if (f_())
					{
						var t_ = this.ToQuantityIgnoringComparator(quantity);
						var u_ = context.Operators.Interval(t_, null, true, true);

						return u_;
					}
					else if (g_())
					{
						var v_ = this.ToQuantityIgnoringComparator(quantity);
						var w_ = context.Operators.Interval(v_, null, false, true);

						return w_;
					}
					else
					{
						var x_ = this.ToQuantity(quantity);
						var z_ = context.Operators.Interval(x_, x_, true, true);

						return z_;
					};
				};

				return c_();
			};
		};

		return a_();
	}

    [CqlDeclaration("ToInterval")]
    [CqlTag("description", "Converts the given FHIR [Range](https://hl7.org/fhir/datatypes.html#Range) value to a CQL Interval of Quantity")]
	public CqlInterval<CqlQuantity> ToInterval(Range range)
	{
		CqlInterval<CqlQuantity> a_()
		{
			if ((range is null))
			{
				CqlInterval<CqlQuantity> b_ = null;

				return b_;
			}
			else
			{
				var c_ = this.ToQuantity(range?.Low);
				var d_ = this.ToQuantity(range?.High);
				var e_ = context.Operators.Interval(c_, d_, true, true);

				return e_;
			};
		};

		return a_();
	}

    [CqlDeclaration("ToCalendarUnit")]
    [CqlTag("description", "Converts a UCUM definite duration unit to a CQL calendar duration unit using conversions specified in the [quantities](https://cql.hl7.org/02-authorsguide.html#quantities) topic of the CQL specification.")]
    [CqlTag("comment", "Note that for durations above days (or weeks), the conversion is understood to be approximate")]
	public string ToCalendarUnit(string unit)
	{
		string a_()
		{
			if ((context.Operators.Equal(unit, "ms") ?? false))
			{
				return "millisecond";
			}
			else if ((context.Operators.Equal(unit, "s") ?? false))
			{
				return "second";
			}
			else if ((context.Operators.Equal(unit, "min") ?? false))
			{
				return "minute";
			}
			else if ((context.Operators.Equal(unit, "h") ?? false))
			{
				return "hour";
			}
			else if ((context.Operators.Equal(unit, "d") ?? false))
			{
				return "day";
			}
			else if ((context.Operators.Equal(unit, "wk") ?? false))
			{
				return "week";
			}
			else if ((context.Operators.Equal(unit, "mo") ?? false))
			{
				return "month";
			}
			else if ((context.Operators.Equal(unit, "a") ?? false))
			{
				return "year";
			}
			else
			{
				return unit;
			};
		};

		return a_();
	}

    [CqlDeclaration("ToQuantity")]
    [CqlTag("description", "Converts the given FHIR [Quantity](https://hl7.org/fhir/datatypes.html#Quantity) value to a CQL Quantity")]
    [CqlTag("comment", "If the given quantity has a comparator specified, a runtime error is raised. If the given quantity has a system other than UCUM (i.e. `http://unitsofmeasure.org`) or CQL calendar units (i.e. `http://hl7.org/fhirpath/CodeSystem/calendar-units`) an error is raised. For UCUM to calendar units, the `ToCalendarUnit` function is used.")]
    [CqlTag("seealso", "ToCalendarUnit")]
	public CqlQuantity ToQuantity(Quantity quantity)
	{
		CqlQuantity a_()
		{
			bool b_()
			{
				var c_ = context.Operators.Equal(quantity?.SystemElement?.Value, "http://unitsofmeasure.org");
				var d_ = context.Operators.Or((bool?)(quantity?.SystemElement is null), c_);
				var e_ = context.Operators.Equal(quantity?.SystemElement?.Value, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
				var f_ = context.Operators.Or(d_, e_);

				return (f_ ?? false);
			};
			if ((quantity is null))
			{
				return null;
			}
			else if ((quantity?.ValueElement is null))
			{
				return null;
			}
			else if ((context.Operators.Not((bool?)(quantity?.ComparatorElement is null)) ?? false))
			{
				var g_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.ComparatorQuantityNotSupported", "Error", "FHIR Quantity value has a comparator and cannot be converted to a System.Quantity value.");

				return (g_ as CqlQuantity);
			}
			else if (b_())
			{
				var h_ = this.ToCalendarUnit(((quantity?.CodeElement?.Value ?? quantity?.UnitElement?.Value) ?? "1"));

				return new CqlQuantity(quantity?.ValueElement?.Value, h_);
			}
			else
			{
				var i_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", (quantity?.UnitElement?.Value ?? ""));
				var j_ = context.Operators.Concatenate((i_ ?? ""), " (");
				var k_ = context.Operators.Concatenate((j_ ?? ""), (quantity?.SystemElement?.Value ?? ""));
				var l_ = context.Operators.Concatenate((k_ ?? ""), "|");
				var m_ = context.Operators.Concatenate((l_ ?? ""), (quantity?.CodeElement?.Value ?? ""));
				var n_ = context.Operators.Concatenate((m_ ?? ""), ")");
				var o_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", n_);

				return (o_ as CqlQuantity);
			};
		};

		return a_();
	}

    [CqlDeclaration("ToQuantityIgnoringComparator")]
    [CqlTag("description", "Converts the given FHIR [Quantity](https://hl7.org/fhir/datatypes.html#Quantity) value to a CQL Quantity, ignoring the comparator element. This function should only be used when an application is justified in ignoring the comparator value (i.e. the context is looking for boundary).")]
    [CqlTag("comment", "If the given quantity has a system other than UCUM (i.e. `http://unitsofmeasure.org`) or CQL calendar units (i.e. `http://hl7.org/fhirpath/CodeSystem/calendar-units`) an error is raised. For UCUM to calendar units, the `ToCalendarUnit` function is used.")]
    [CqlTag("seealso", "ToCalendarUnit")]
	public CqlQuantity ToQuantityIgnoringComparator(Quantity quantity)
	{
		CqlQuantity a_()
		{
			bool b_()
			{
				var c_ = context.Operators.Equal(quantity?.SystemElement?.Value, "http://unitsofmeasure.org");
				var d_ = context.Operators.Or((bool?)(quantity?.SystemElement is null), c_);
				var e_ = context.Operators.Equal(quantity?.SystemElement?.Value, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
				var f_ = context.Operators.Or(d_, e_);

				return (f_ ?? false);
			};
			if ((quantity is null))
			{
				return null;
			}
			else if ((quantity?.ValueElement is null))
			{
				return null;
			}
			else if (b_())
			{
				var g_ = this.ToCalendarUnit(((quantity?.CodeElement?.Value ?? quantity?.UnitElement?.Value) ?? "1"));

				return new CqlQuantity(quantity?.ValueElement?.Value, g_);
			}
			else
			{
				var h_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", (quantity?.UnitElement?.Value ?? ""));
				var i_ = context.Operators.Concatenate((h_ ?? ""), " (");
				var j_ = context.Operators.Concatenate((i_ ?? ""), (quantity?.SystemElement?.Value ?? ""));
				var k_ = context.Operators.Concatenate((j_ ?? ""), "|");
				var l_ = context.Operators.Concatenate((k_ ?? ""), (quantity?.CodeElement?.Value ?? ""));
				var m_ = context.Operators.Concatenate((l_ ?? ""), ")");
				var n_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", m_);

				return (n_ as CqlQuantity);
			};
		};

		return a_();
	}

    [CqlDeclaration("ToRatio")]
    [CqlTag("description", "Converts the given FHIR [Ratio](https://hl7.org/fhir/datatypes.html#Ratio) value to a CQL Ratio.")]
	public CqlRatio ToRatio(Ratio ratio)
	{
		CqlRatio a_()
		{
			if ((ratio is null))
			{
				return null;
			}
			else
			{
				var b_ = this.ToQuantity(ratio?.Numerator);
				var c_ = this.ToQuantity(ratio?.Denominator);

				return new CqlRatio(b_, c_);
			};
		};

		return a_();
	}

    [CqlDeclaration("ToCode")]
    [CqlTag("description", "Converts the given FHIR [Coding](https://hl7.org/fhir/datatypes.html#Coding) value to a CQL Code.")]
	public CqlCode ToCode(Coding coding) => 
		((coding is null)
			? null
			: (new CqlCode(coding?.CodeElement?.Value, coding?.SystemElement?.Value, coding?.VersionElement?.Value, coding?.DisplayElement?.Value)));

    [CqlDeclaration("ToConcept")]
    [CqlTag("description", "Converts the given FHIR [CodeableConcept](https://hl7.org/fhir/datatypes.html#CodeableConcept) value to a CQL Concept.")]
	public CqlConcept ToConcept(CodeableConcept concept)
	{
		CqlConcept a_()
		{
			if ((concept is null))
			{
				return null;
			}
			else
			{
				CqlCode b_(Coding C)
				{
					var d_ = this.ToCode(C);

					return d_;
				};
				var c_ = context.Operators.Select<Coding, CqlCode>((concept?.Coding as IEnumerable<Coding>), b_);

				return new CqlConcept(c_, concept?.TextElement?.Value);
			};
		};

		return a_();
	}

    [CqlDeclaration("ToValueSet")]
    [CqlTag("description", "Converts the given value (assumed to be a URI) to a CQL [ValueSet](https://cql.hl7.org/09-b-cqlreference.html#valueset)")]
	public CqlValueSet ToValueSet(string uri)
	{
		CqlValueSet a_()
		{
			if ((uri is null))
			{
				return null;
			}
			else
			{
				var b_ = new CqlValueSet
				{
					id = uri,
				};

				return b_;
			};
		};

		return a_();
	}

    [CqlDeclaration("reference")]
    [CqlTag("description", "Constructs a FHIR [Reference](https://hl7.org/fhir/datatypes.html#Reference) from the given reference (assumed to be a FHIR resource URL)")]
	public ResourceReference reference(string reference)
	{
		ResourceReference a_()
		{
			if ((reference is null))
			{
				return null;
			}
			else
			{
				var b_ = new FhirString
				{
					Value = reference,
				};
				var c_ = new ResourceReference
				{
					ReferenceElement = b_,
				};

				return c_;
			};
		};

		return a_();
	}

    [CqlDeclaration("reference")]
	public ResourceReference reference(Resource resource1) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.reference is not implemented."));

    [CqlDeclaration("ToValue")]
    [CqlTag("description", "Converts the given value to a CQL value using the appropriate accessor or conversion function.")]
    [CqlTag("comment", "TODO: document conversion")]
	public object ToValue(object value)
	{
		object a_()
		{
			if (value is Base64Binary)
			{
				var b_ = context.Operators.Convert<string>((value as Base64Binary)?.Value);

				return (b_ as object);
			}
			else if (value is FhirBoolean)
			{
				return (value as FhirBoolean)?.Value;
			}
			else if (value is Canonical)
			{
				return ((value as Canonical)?.Value as object);
			}
			else if (value is Code)
			{
				return ((value as Code)?.Value as object);
			}
			else if (value is Date)
			{
				var c_ = context.Operators.ConvertStringToDate((value as Date)?.Value);

				return (c_ as object);
			}
			else if (value is FhirDateTime)
			{
				var d_ = context.Operators.Convert<CqlDateTime>((value as FhirDateTime));

				return (d_ as object);
			}
			else if (value is FhirDecimal)
			{
				return (value as FhirDecimal)?.Value;
			}
			else if (value is Id)
			{
				return ((value as Id)?.Value as object);
			}
			else if (value is Instant)
			{
				var e_ = context.Operators.Convert<CqlDateTime>((value as Instant)?.Value);

				return (e_ as object);
			}
			else if (value is Integer)
			{
				return (value as Integer)?.Value;
			}
			else if (value is Markdown)
			{
				return ((value as Markdown)?.Value as object);
			}
			else if (value is Oid)
			{
				return ((value as Oid)?.Value as object);
			}
			else if (value is Integer)
			{
				return (value as Integer)?.Value;
			}
			else if (value is FhirString)
			{
				return ((value as FhirString)?.Value as object);
			}
			else if (value is Time)
			{
				var f_ = context.Operators.ConvertStringToTime((value as Time)?.Value);

				return (f_ as object);
			}
			else if (value is Integer)
			{
				return (value as Integer)?.Value;
			}
			else if (value is FhirUri)
			{
				return ((value as FhirUri)?.Value as object);
			}
			else if (value is FhirUrl)
			{
				return ((value as FhirUrl)?.Value as object);
			}
			else if (value is Uuid)
			{
				return ((value as Uuid)?.Value as object);
			}
			else if (value is Age)
			{
				var g_ = this.ToQuantity(((value as Age) as Quantity));

				return (g_ as object);
			}
			else if (value is CodeableConcept)
			{
				var h_ = this.ToConcept((value as CodeableConcept));

				return (h_ as object);
			}
			else if (value is Coding)
			{
				var i_ = this.ToCode((value as Coding));

				return (i_ as object);
			}
			else if (value is Count)
			{
				var j_ = this.ToQuantity(((value as Count) as Quantity));

				return (j_ as object);
			}
			else if (value is Distance)
			{
				var k_ = this.ToQuantity(((value as Distance) as Quantity));

				return (k_ as object);
			}
			else if (value is Duration)
			{
				var l_ = this.ToQuantity(((value as Duration) as Quantity));

				return (l_ as object);
			}
			else if (value is Quantity)
			{
				var m_ = this.ToQuantity((value as Quantity));

				return (m_ as object);
			}
			else if (value is Range)
			{
				var n_ = this.ToInterval((value as Range));

				return (n_ as object);
			}
			else if (value is Period)
			{
				var o_ = this.ToInterval((value as Period));

				return (o_ as object);
			}
			else if (value is Ratio)
			{
				var p_ = this.ToRatio((value as Ratio));

				return (p_ as object);
			}
			else
			{
				return value;
			};
		};

		return a_();
	}

    [CqlDeclaration("resolve")]
	public Resource resolve(string @string1) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.resolve is not implemented."));

    [CqlDeclaration("resolve")]
	public Resource resolve(ResourceReference resourcereference1) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.resolve is not implemented."));

    [CqlDeclaration("extension")]
	public IEnumerable<Extension> extension(Element element1, string @string2) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.extension is not implemented."));

    [CqlDeclaration("extension")]
	public IEnumerable<Extension> extension(DomainResource domainresource1, string @string2) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.extension is not implemented."));

    [CqlDeclaration("modifierExtension")]
	public IEnumerable<Extension> modifierExtension(BackboneElement backboneelement1, string @string2) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.modifierExtension is not implemented."));

    [CqlDeclaration("modifierExtension")]
	public IEnumerable<Extension> modifierExtension(DomainResource domainresource1, string @string2) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.modifierExtension is not implemented."));

    [CqlDeclaration("hasValue")]
	public bool? hasValue(Element element1) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.hasValue is not implemented."));

    [CqlDeclaration("getValue")]
	public object getValue(Element element1) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.getValue is not implemented."));

    [CqlDeclaration("ofType")]
	public IEnumerable<object> ofType(string @string1) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.ofType is not implemented."));

    [CqlDeclaration("is")]
	public bool? @is(string @string1) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.is is not implemented."));

    [CqlDeclaration("as")]
	public object @as(string @string1) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.as is not implemented."));

    [CqlDeclaration("elementDefinition")]
	public ElementDefinition elementDefinition(Element element1) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.elementDefinition is not implemented."));

    [CqlDeclaration("slice")]
	public IEnumerable<Element> slice(Element element1, string @string2, string @string3) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.slice is not implemented."));

    [CqlDeclaration("checkModifiers")]
	public Resource checkModifiers(Resource resource1) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));

    [CqlDeclaration("checkModifiers")]
	public Resource checkModifiers(Resource resource1, string @string2) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));

    [CqlDeclaration("checkModifiers")]
	public Element checkModifiers(Element element1) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));

    [CqlDeclaration("checkModifiers")]
	public Element checkModifiers(Element element1, string @string2) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));

    [CqlDeclaration("conformsTo")]
	public bool? conformsTo(Resource resource1, string @string2) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.conformsTo is not implemented."));

    [CqlDeclaration("memberOf")]
	public bool? memberOf(Code code1, string @string2) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));

    [CqlDeclaration("memberOf")]
	public bool? memberOf(Coding coding1, string @string2) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));

    [CqlDeclaration("memberOf")]
	public bool? memberOf(CodeableConcept codeableconcept1, string @string2) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));

    [CqlDeclaration("subsumes")]
	public bool? subsumes(Coding coding1, Coding coding2) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumes is not implemented."));

    [CqlDeclaration("subsumes")]
	public bool? subsumes(CodeableConcept codeableconcept1, CodeableConcept codeableconcept2) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumes is not implemented."));

    [CqlDeclaration("subsumedBy")]
	public bool? subsumedBy(Coding coding1, Coding coding2) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumedBy is not implemented."));

    [CqlDeclaration("subsumedBy")]
	public bool? subsumedBy(CodeableConcept codeableconcept1, CodeableConcept codeableconcept2) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumedBy is not implemented."));

    [CqlDeclaration("htmlChecks")]
	public bool? htmlChecks(Element element1) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.htmlChecks is not implemented."));

    [CqlDeclaration("ToString")]
	public string ToString(Code<Account.AccountStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionCardinalityBehavior> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionConditionKind> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionGroupingBehavior> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionParticipantType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionPrecheckBehavior> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionRelationshipType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionRequiredBehavior> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionSelectionBehavior> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActivityDefinition.RequestResourceType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Address.AddressType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Address.AddressUse> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AdministrativeGender> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AdverseEvent.AdverseEventActuality> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.AggregationMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AllergyIntolerance.AllergyIntoleranceType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Appointment.AppointmentStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestScript.AssertionDirectionType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestScript.AssertionOperatorType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestScript.AssertionResponseTypes> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AuditEvent.AuditEventAction> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AuditEvent.AuditEventAgentNetworkType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AuditEvent.AuditEventOutcome> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<BindingStrength> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Bundle.BundleType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatementKind> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CarePlan.CarePlanActivityKind> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CarePlan.CarePlanActivityStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CarePlan.CarePlanIntent> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<RequestStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CareTeam.CareTeamStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CatalogEntry.CatalogEntryRelationType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<InvoicePriceComponentType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ChargeItem.ChargeItemStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FinancialResourceStatusCodes> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ClinicalImpression.ClinicalImpressionStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TerminologyCapabilities.CodeSearchSupport> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CodeSystemContentMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CodeSystem.CodeSystemHierarchyMeaning> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<RequestPriority> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<EventStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CompartmentType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Composition.CompositionAttestationMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CompositionStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ConceptMapEquivalence> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.ConditionalDeleteStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.ConditionalReadStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Consent.ConsentDataMeaning> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Consent.ConsentProvisionType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Consent.ConsentState> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ConstraintSeverity> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ContactPoint.ContactPointSystem> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ContactPoint.ContactPointUse> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Contract.ContractResourcePublicationStatusCodes> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Contract.ContractResourceStatusCodes> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Contributor.ContributorType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Money.Currencies> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DaysOfWeek> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DetectedIssue.DetectedIssueSeverity> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ObservationStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricCalibrationState> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricCalibrationType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricCategory> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricColor> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricOperationalStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceNameType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceUseStatement.DeviceUseStatementStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DiagnosticReport.DiagnosticReportStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.DiscriminatorType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Composition.V3ConfidentialityClassification> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.DocumentMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DocumentReferenceStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DocumentRelationshipType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Questionnaire.EnableWhenBehavior> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Encounter.EncounterLocationStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Encounter.EncounterStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Endpoint.EndpointStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<EpisodeOfCare.EpisodeOfCareStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.EventCapabilityMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Timing.EventTiming> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<VariableTypeCode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ExampleScenario.ExampleScenarioActorType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<EffectEvidenceSynthesis.ExposureStateCode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureDefinition.ExtensionContextType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FHIRAllTypes> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FHIRDefinedType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Device.FHIRDeviceStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ResourceType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Substance.FHIRSubstanceStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FHIRVersion> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FamilyMemberHistory.FamilyHistoryStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FilterOperator> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Flag.FlagStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Goal.GoalLifecycleStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<GraphDefinition.GraphCompartmentRule> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<GraphDefinition.GraphCompartmentUse> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<GroupMeasureCode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Group.GroupType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<GuidanceResponse.GuidanceResponseStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImplementationGuide.GuidePageGeneration> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImplementationGuide.GuideParameterCode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Bundle.HTTPVerb> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Identifier.IdentifierUse> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Person.IdentityAssuranceLevel> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImagingStudy.ImagingStudyStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Immunization.ImmunizationStatusCodes> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Invoice.InvoiceStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<OperationOutcome.IssueSeverity> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<OperationOutcome.IssueType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Patient.LinkType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Linkage.LinkageType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ListMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<List.ListStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Location.LocationMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Location.LocationStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MeasureReport.MeasureReportStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MeasureReport.MeasureReportType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationDispense.MedicationDispenseStatusCodes> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationRequest.MedicationRequestIntent> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationRequest.MedicationrequestStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationStatement.MedicationStatusCodes> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Medication.MedicationStatusCodes> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MessageDefinition.MessageSignificanceCategory> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MessageheaderResponseRequest> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(Code<HumanName.NameUse> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<NamingSystem.NamingSystemIdentifierType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<NamingSystem.NamingSystemType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Narrative.NarrativeStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<NoteType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<RequestIntent> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ObservationDefinition.ObservationDataType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ObservationDefinition.ObservationRangeCategory> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<OperationDefinition.OperationKind> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<OperationParameterUse> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.OrientationType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Appointment.ParticipantRequired> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ParticipationStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.PropertyRepresentation> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CodeSystem.PropertyType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Provenance.ProvenanceEntityRole> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<PublicationStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.QualityType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Quantity.QuantityComparator> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Questionnaire.QuestionnaireItemOperator> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Questionnaire.QuestionnaireItemType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.ReferenceHandlingPolicy> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.ReferenceVersionRules> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<RelatedArtifact.RelatedArtifactType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ClaimProcessingCodes> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.RepositoryType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ResearchElementDefinition.ResearchElementType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ResearchStudy.ResearchStudyStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ResearchSubject.ResearchSubjectStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.ResourceVersionPolicy> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MessageHeader.ResponseType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.RestfulCapabilityMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImplementationGuide.SPDXLicense> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SearchParameter.SearchComparator> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Bundle.SearchEntryMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SearchParameter.SearchModifierCode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SearchParamType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.SequenceType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.SlicingRules> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Slot.SlotStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DataRequirement.SortDirection> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SpecimenDefinition.SpecimenContainedPreference> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Specimen.SpecimenStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<VerificationResult.StatusCode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.StrandType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureDefinition.StructureDefinitionKind> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapContextType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapGroupTypeMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapInputMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapModelMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapSourceListMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapTargetListMode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapTransform> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Subscription.SubscriptionChannelType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Subscription.SubscriptionStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SupplyDelivery.SupplyDeliveryStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SupplyRequest.SupplyRequestStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.SystemRestfulInteraction> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Task.TaskIntent> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Task.TaskStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestReport.TestReportActionResult> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestReport.TestReportParticipantType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestReport.TestReportResult> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestReport.TestReportStatus> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestScript.TestScriptRequestMethodCode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TriggerDefinition.TriggerType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureDefinition.TypeDerivationRule> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.TypeRestfulInteraction> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Device.UDIEntryType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Timing.UnitsOfTime> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ClaimUseCode> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<VisionPrescription.VisionBase> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<VisionPrescription.VisionEyes> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SearchParameter.XPathUsageType> value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Base64Binary value)
	{
		var a_ = context.Operators.Convert<string>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(FhirString value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(FhirUri value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(XHtml value) => 
		value?.Value;

    [CqlDeclaration("ToBoolean")]
	public bool? ToBoolean(FhirBoolean value) => 
		value?.Value;

    [CqlDeclaration("ToDate")]
	public CqlDate ToDate(Date value)
	{
		var a_ = context.Operators.ConvertStringToDate(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToDateTime")]
	public CqlDateTime ToDateTime(FhirDateTime value)
	{
		var a_ = context.Operators.Convert<CqlDateTime>(value);

		return a_;
	}

    [CqlDeclaration("ToDateTime")]
	public CqlDateTime ToDateTime(Instant value)
	{
		var a_ = context.Operators.Convert<CqlDateTime>(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToDecimal")]
	public decimal? ToDecimal(FhirDecimal value) => 
		value?.Value;

    [CqlDeclaration("ToInteger")]
	public int? ToInteger(Integer value) => 
		value?.Value;

    [CqlDeclaration("ToTime")]
	public CqlTime ToTime(Time value)
	{
		var a_ = context.Operators.ConvertStringToTime(value?.Value);

		return a_;
	}

}

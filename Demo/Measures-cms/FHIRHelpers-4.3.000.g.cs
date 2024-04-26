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
				CqlDateTime c_ = context.Operators.Convert<CqlDateTime>(period?.StartElement);
				CqlDateTime d_ = context.Operators.Convert<CqlDateTime>(period?.EndElement);
				CqlInterval<CqlDateTime> e_ = context.Operators.Interval(c_, d_, false, true);

				return e_;
			}
			else
			{
				CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(period?.StartElement);
				CqlDateTime g_ = context.Operators.Convert<CqlDateTime>(period?.EndElement);
				CqlInterval<CqlDateTime> h_ = context.Operators.Interval(f_, g_, true, true);

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
					if ((context.Operators.Equal(quantity?.ComparatorElement?.Value, "<") ?? false))
					{
						CqlQuantity d_ = this.ToQuantityIgnoringComparator(quantity);
						CqlInterval<CqlQuantity> e_ = context.Operators.Interval(null, d_, true, false);

						return e_;
					}
					else if ((context.Operators.Equal(quantity?.ComparatorElement?.Value, "<=") ?? false))
					{
						CqlQuantity f_ = this.ToQuantityIgnoringComparator(quantity);
						CqlInterval<CqlQuantity> g_ = context.Operators.Interval(null, f_, true, true);

						return g_;
					}
					else if ((context.Operators.Equal(quantity?.ComparatorElement?.Value, ">=") ?? false))
					{
						CqlQuantity h_ = this.ToQuantityIgnoringComparator(quantity);
						CqlInterval<CqlQuantity> i_ = context.Operators.Interval(h_, null, true, true);

						return i_;
					}
					else if ((context.Operators.Equal(quantity?.ComparatorElement?.Value, ">") ?? false))
					{
						CqlQuantity j_ = this.ToQuantityIgnoringComparator(quantity);
						CqlInterval<CqlQuantity> k_ = context.Operators.Interval(j_, null, false, true);

						return k_;
					}
					else
					{
						CqlQuantity l_ = this.ToQuantity(quantity);
						CqlInterval<CqlQuantity> n_ = context.Operators.Interval(l_, l_, true, true);

						return n_;
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
				CqlQuantity c_ = this.ToQuantity(range?.Low);
				CqlQuantity d_ = this.ToQuantity(range?.High);
				CqlInterval<CqlQuantity> e_ = context.Operators.Interval(c_, d_, true, true);

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
				bool? c_ = context.Operators.Equal(quantity?.SystemElement?.Value, "http://unitsofmeasure.org");
				bool? d_ = context.Operators.Or((bool?)(quantity?.SystemElement is null), c_);
				bool? e_ = context.Operators.Equal(quantity?.SystemElement?.Value, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
				bool? f_ = context.Operators.Or(d_, e_);

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
				object g_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.ComparatorQuantityNotSupported", "Error", "FHIR Quantity value has a comparator and cannot be converted to a System.Quantity value.");

				return (g_ as CqlQuantity);
			}
			else if (b_())
			{
				string h_ = this.ToCalendarUnit(((quantity?.CodeElement?.Value ?? quantity?.UnitElement?.Value) ?? "1"));

				return new CqlQuantity(quantity?.ValueElement?.Value, h_);
			}
			else
			{
				string i_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", (quantity?.UnitElement?.Value ?? ""));
				string j_ = context.Operators.Concatenate((i_ ?? ""), " (");
				string k_ = context.Operators.Concatenate((j_ ?? ""), (quantity?.SystemElement?.Value ?? ""));
				string l_ = context.Operators.Concatenate((k_ ?? ""), "|");
				string m_ = context.Operators.Concatenate((l_ ?? ""), (quantity?.CodeElement?.Value ?? ""));
				string n_ = context.Operators.Concatenate((m_ ?? ""), ")");
				object o_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", n_);

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
				bool? c_ = context.Operators.Equal(quantity?.SystemElement?.Value, "http://unitsofmeasure.org");
				bool? d_ = context.Operators.Or((bool?)(quantity?.SystemElement is null), c_);
				bool? e_ = context.Operators.Equal(quantity?.SystemElement?.Value, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
				bool? f_ = context.Operators.Or(d_, e_);

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
				string g_ = this.ToCalendarUnit(((quantity?.CodeElement?.Value ?? quantity?.UnitElement?.Value) ?? "1"));

				return new CqlQuantity(quantity?.ValueElement?.Value, g_);
			}
			else
			{
				string h_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", (quantity?.UnitElement?.Value ?? ""));
				string i_ = context.Operators.Concatenate((h_ ?? ""), " (");
				string j_ = context.Operators.Concatenate((i_ ?? ""), (quantity?.SystemElement?.Value ?? ""));
				string k_ = context.Operators.Concatenate((j_ ?? ""), "|");
				string l_ = context.Operators.Concatenate((k_ ?? ""), (quantity?.CodeElement?.Value ?? ""));
				string m_ = context.Operators.Concatenate((l_ ?? ""), ")");
				object n_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", m_);

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
				CqlQuantity b_ = this.ToQuantity(ratio?.Numerator);
				CqlQuantity c_ = this.ToQuantity(ratio?.Denominator);

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
					CqlCode d_ = this.ToCode(C);

					return d_;
				};
				IEnumerable<CqlCode> c_ = context.Operators.Select<Coding, CqlCode>((concept?.Coding as IEnumerable<Coding>), b_);

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
				CqlValueSet b_ = new CqlValueSet
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
				FhirString b_ = new FhirString
				{
					Value = reference,
				};
				ResourceReference c_ = new ResourceReference
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
				string b_ = context.Operators.Convert<string>((value as Base64Binary)?.Value);

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
				CqlDate c_ = context.Operators.ConvertStringToDate((value as Date)?.Value);

				return (c_ as object);
			}
			else if (value is FhirDateTime)
			{
				CqlDateTime d_ = context.Operators.Convert<CqlDateTime>((value as FhirDateTime));

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
				CqlDateTime e_ = context.Operators.Convert<CqlDateTime>((value as Instant)?.Value);

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
				CqlTime f_ = context.Operators.ConvertStringToTime((value as Time)?.Value);

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
				CqlQuantity g_ = this.ToQuantity(((value as Age) as Quantity));

				return (g_ as object);
			}
			else if (value is CodeableConcept)
			{
				CqlConcept h_ = this.ToConcept((value as CodeableConcept));

				return (h_ as object);
			}
			else if (value is Coding)
			{
				CqlCode i_ = this.ToCode((value as Coding));

				return (i_ as object);
			}
			else if (value is Count)
			{
				CqlQuantity j_ = this.ToQuantity(((value as Count) as Quantity));

				return (j_ as object);
			}
			else if (value is Distance)
			{
				CqlQuantity k_ = this.ToQuantity(((value as Distance) as Quantity));

				return (k_ as object);
			}
			else if (value is Duration)
			{
				CqlQuantity l_ = this.ToQuantity(((value as Duration) as Quantity));

				return (l_ as object);
			}
			else if (value is Quantity)
			{
				CqlQuantity m_ = this.ToQuantity((value as Quantity));

				return (m_ as object);
			}
			else if (value is Range)
			{
				CqlInterval<CqlQuantity> n_ = this.ToInterval((value as Range));

				return (n_ as object);
			}
			else if (value is Period)
			{
				CqlInterval<CqlDateTime> o_ = this.ToInterval((value as Period));

				return (o_ as object);
			}
			else if (value is Ratio)
			{
				CqlRatio p_ = this.ToRatio((value as Ratio));

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
	public Account.AccountStatus? ToString(Code<Account.AccountStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionCardinalityBehavior? ToString(Code<ActionCardinalityBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionConditionKind? ToString(Code<ActionConditionKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionGroupingBehavior? ToString(Code<ActionGroupingBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionParticipantType? ToString(Code<ActionParticipantType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionPrecheckBehavior? ToString(Code<ActionPrecheckBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionRelationshipType? ToString(Code<ActionRelationshipType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionRequiredBehavior? ToString(Code<ActionRequiredBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActionSelectionBehavior? ToString(Code<ActionSelectionBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ActivityDefinition.RequestResourceType? ToString(Code<ActivityDefinition.RequestResourceType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Address.AddressType? ToString(Code<Address.AddressType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Address.AddressUse? ToString(Code<Address.AddressUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AdministrativeGender? ToString(Code<AdministrativeGender> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AdverseEvent.AdverseEventActuality? ToString(Code<AdverseEvent.AdverseEventActuality> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.AggregationMode? ToString(Code<ElementDefinition.AggregationMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AllergyIntolerance.AllergyIntoleranceCategory? ToString(Code<AllergyIntolerance.AllergyIntoleranceCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AllergyIntolerance.AllergyIntoleranceCriticality? ToString(Code<AllergyIntolerance.AllergyIntoleranceCriticality> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AllergyIntolerance.AllergyIntoleranceSeverity? ToString(Code<AllergyIntolerance.AllergyIntoleranceSeverity> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AllergyIntolerance.AllergyIntoleranceType? ToString(Code<AllergyIntolerance.AllergyIntoleranceType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Appointment.AppointmentStatus? ToString(Code<Appointment.AppointmentStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestScript.AssertionDirectionType? ToString(Code<TestScript.AssertionDirectionType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestScript.AssertionOperatorType? ToString(Code<TestScript.AssertionOperatorType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestScript.AssertionResponseTypes? ToString(Code<TestScript.AssertionResponseTypes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AuditEvent.AuditEventAction? ToString(Code<AuditEvent.AuditEventAction> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AuditEvent.AuditEventAgentNetworkType? ToString(Code<AuditEvent.AuditEventAgentNetworkType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public AuditEvent.AuditEventOutcome? ToString(Code<AuditEvent.AuditEventOutcome> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public BindingStrength? ToString(Code<BindingStrength> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Bundle.BundleType? ToString(Code<Bundle.BundleType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatementKind? ToString(Code<CapabilityStatementKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CarePlan.CarePlanActivityKind? ToString(Code<CarePlan.CarePlanActivityKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CarePlan.CarePlanActivityStatus? ToString(Code<CarePlan.CarePlanActivityStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CarePlan.CarePlanIntent? ToString(Code<CarePlan.CarePlanIntent> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public RequestStatus? ToString(Code<RequestStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CareTeam.CareTeamStatus? ToString(Code<CareTeam.CareTeamStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CatalogEntry.CatalogEntryRelationType? ToString(Code<CatalogEntry.CatalogEntryRelationType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public InvoicePriceComponentType? ToString(Code<InvoicePriceComponentType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ChargeItem.ChargeItemStatus? ToString(Code<ChargeItem.ChargeItemStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FinancialResourceStatusCodes? ToString(Code<FinancialResourceStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ClinicalImpression.ClinicalImpressionStatus? ToString(Code<ClinicalImpression.ClinicalImpressionStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TerminologyCapabilities.CodeSearchSupport? ToString(Code<TerminologyCapabilities.CodeSearchSupport> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CodeSystemContentMode? ToString(Code<CodeSystemContentMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CodeSystem.CodeSystemHierarchyMeaning? ToString(Code<CodeSystem.CodeSystemHierarchyMeaning> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public RequestPriority? ToString(Code<RequestPriority> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public EventStatus? ToString(Code<EventStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CompartmentType? ToString(Code<CompartmentType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Composition.CompositionAttestationMode? ToString(Code<Composition.CompositionAttestationMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CompositionStatus? ToString(Code<CompositionStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ConceptMapEquivalence? ToString(Code<ConceptMapEquivalence> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ConceptMap.ConceptMapGroupUnmappedMode? ToString(Code<ConceptMap.ConceptMapGroupUnmappedMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.ConditionalDeleteStatus? ToString(Code<CapabilityStatement.ConditionalDeleteStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.ConditionalReadStatus? ToString(Code<CapabilityStatement.ConditionalReadStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Consent.ConsentDataMeaning? ToString(Code<Consent.ConsentDataMeaning> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Consent.ConsentProvisionType? ToString(Code<Consent.ConsentProvisionType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Consent.ConsentState? ToString(Code<Consent.ConsentState> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ConstraintSeverity? ToString(Code<ConstraintSeverity> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ContactPoint.ContactPointSystem? ToString(Code<ContactPoint.ContactPointSystem> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ContactPoint.ContactPointUse? ToString(Code<ContactPoint.ContactPointUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Contract.ContractResourcePublicationStatusCodes? ToString(Code<Contract.ContractResourcePublicationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Contract.ContractResourceStatusCodes? ToString(Code<Contract.ContractResourceStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Contributor.ContributorType? ToString(Code<Contributor.ContributorType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Money.Currencies? ToString(Code<Money.Currencies> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DaysOfWeek? ToString(Code<DaysOfWeek> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DetectedIssue.DetectedIssueSeverity? ToString(Code<DetectedIssue.DetectedIssueSeverity> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ObservationStatus? ToString(Code<ObservationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricCalibrationState? ToString(Code<DeviceMetric.DeviceMetricCalibrationState> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricCalibrationType? ToString(Code<DeviceMetric.DeviceMetricCalibrationType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricCategory? ToString(Code<DeviceMetric.DeviceMetricCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricColor? ToString(Code<DeviceMetric.DeviceMetricColor> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceMetric.DeviceMetricOperationalStatus? ToString(Code<DeviceMetric.DeviceMetricOperationalStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceNameType? ToString(Code<DeviceNameType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DeviceUseStatement.DeviceUseStatementStatus? ToString(Code<DeviceUseStatement.DeviceUseStatementStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DiagnosticReport.DiagnosticReportStatus? ToString(Code<DiagnosticReport.DiagnosticReportStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.DiscriminatorType? ToString(Code<ElementDefinition.DiscriminatorType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Composition.V3ConfidentialityClassification? ToString(Code<Composition.V3ConfidentialityClassification> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.DocumentMode? ToString(Code<CapabilityStatement.DocumentMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DocumentReferenceStatus? ToString(Code<DocumentReferenceStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DocumentRelationshipType? ToString(Code<DocumentRelationshipType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CoverageEligibilityRequest.EligibilityRequestPurpose? ToString(Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CoverageEligibilityResponse.EligibilityResponsePurpose? ToString(Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Questionnaire.EnableWhenBehavior? ToString(Code<Questionnaire.EnableWhenBehavior> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Encounter.EncounterLocationStatus? ToString(Code<Encounter.EncounterLocationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Encounter.EncounterStatus? ToString(Code<Encounter.EncounterStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Endpoint.EndpointStatus? ToString(Code<Endpoint.EndpointStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public EpisodeOfCare.EpisodeOfCareStatus? ToString(Code<EpisodeOfCare.EpisodeOfCareStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.EventCapabilityMode? ToString(Code<CapabilityStatement.EventCapabilityMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Timing.EventTiming? ToString(Code<Timing.EventTiming> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public VariableTypeCode? ToString(Code<VariableTypeCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ExampleScenario.ExampleScenarioActorType? ToString(Code<ExampleScenario.ExampleScenarioActorType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ExplanationOfBenefit.ExplanationOfBenefitStatus? ToString(Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public EffectEvidenceSynthesis.ExposureStateCode? ToString(Code<EffectEvidenceSynthesis.ExposureStateCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureDefinition.ExtensionContextType? ToString(Code<StructureDefinition.ExtensionContextType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FHIRAllTypes? ToString(Code<FHIRAllTypes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FHIRDefinedType? ToString(Code<FHIRDefinedType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Device.FHIRDeviceStatus? ToString(Code<Device.FHIRDeviceStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ResourceType? ToString(Code<ResourceType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Substance.FHIRSubstanceStatus? ToString(Code<Substance.FHIRSubstanceStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FHIRVersion? ToString(Code<FHIRVersion> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FamilyMemberHistory.FamilyHistoryStatus? ToString(Code<FamilyMemberHistory.FamilyHistoryStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public FilterOperator? ToString(Code<FilterOperator> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Flag.FlagStatus? ToString(Code<Flag.FlagStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Goal.GoalLifecycleStatus? ToString(Code<Goal.GoalLifecycleStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public GraphDefinition.GraphCompartmentRule? ToString(Code<GraphDefinition.GraphCompartmentRule> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public GraphDefinition.GraphCompartmentUse? ToString(Code<GraphDefinition.GraphCompartmentUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public GroupMeasureCode? ToString(Code<GroupMeasureCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Group.GroupType? ToString(Code<Group.GroupType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public GuidanceResponse.GuidanceResponseStatus? ToString(Code<GuidanceResponse.GuidanceResponseStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImplementationGuide.GuidePageGeneration? ToString(Code<ImplementationGuide.GuidePageGeneration> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImplementationGuide.GuideParameterCode? ToString(Code<ImplementationGuide.GuideParameterCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Bundle.HTTPVerb? ToString(Code<Bundle.HTTPVerb> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Identifier.IdentifierUse? ToString(Code<Identifier.IdentifierUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Person.IdentityAssuranceLevel? ToString(Code<Person.IdentityAssuranceLevel> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImagingStudy.ImagingStudyStatus? ToString(Code<ImagingStudy.ImagingStudyStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? ToString(Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Immunization.ImmunizationStatusCodes? ToString(Code<Immunization.ImmunizationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Invoice.InvoiceStatus? ToString(Code<Invoice.InvoiceStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public OperationOutcome.IssueSeverity? ToString(Code<OperationOutcome.IssueSeverity> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public OperationOutcome.IssueType? ToString(Code<OperationOutcome.IssueType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Patient.LinkType? ToString(Code<Patient.LinkType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Linkage.LinkageType? ToString(Code<Linkage.LinkageType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ListMode? ToString(Code<ListMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public List.ListStatus? ToString(Code<List.ListStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Location.LocationMode? ToString(Code<Location.LocationMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Location.LocationStatus? ToString(Code<Location.LocationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MeasureReport.MeasureReportStatus? ToString(Code<MeasureReport.MeasureReportStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MeasureReport.MeasureReportType? ToString(Code<MeasureReport.MeasureReportType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationAdministration.MedicationAdministrationStatusCodes? ToString(Code<MedicationAdministration.MedicationAdministrationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationDispense.MedicationDispenseStatusCodes? ToString(Code<MedicationDispense.MedicationDispenseStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationKnowledge.MedicationKnowledgeStatusCodes? ToString(Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationRequest.MedicationRequestIntent? ToString(Code<MedicationRequest.MedicationRequestIntent> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationRequest.MedicationrequestStatus? ToString(Code<MedicationRequest.MedicationrequestStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MedicationStatement.MedicationStatusCodes? ToString(Code<MedicationStatement.MedicationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Medication.MedicationStatusCodes? ToString(Code<Medication.MedicationStatusCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MessageDefinition.MessageSignificanceCategory? ToString(Code<MessageDefinition.MessageSignificanceCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MessageheaderResponseRequest? ToString(Code<MessageheaderResponseRequest> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(Code value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public HumanName.NameUse? ToString(Code<HumanName.NameUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public NamingSystem.NamingSystemIdentifierType? ToString(Code<NamingSystem.NamingSystemIdentifierType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public NamingSystem.NamingSystemType? ToString(Code<NamingSystem.NamingSystemType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Narrative.NarrativeStatus? ToString(Code<Narrative.NarrativeStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public NoteType? ToString(Code<NoteType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public RequestIntent? ToString(Code<RequestIntent> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ObservationDefinition.ObservationDataType? ToString(Code<ObservationDefinition.ObservationDataType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ObservationDefinition.ObservationRangeCategory? ToString(Code<ObservationDefinition.ObservationRangeCategory> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public OperationDefinition.OperationKind? ToString(Code<OperationDefinition.OperationKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public OperationParameterUse? ToString(Code<OperationParameterUse> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.OrientationType? ToString(Code<MolecularSequence.OrientationType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Appointment.ParticipantRequired? ToString(Code<Appointment.ParticipantRequired> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ParticipationStatus? ToString(Code<ParticipationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.PropertyRepresentation? ToString(Code<ElementDefinition.PropertyRepresentation> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CodeSystem.PropertyType? ToString(Code<CodeSystem.PropertyType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Provenance.ProvenanceEntityRole? ToString(Code<Provenance.ProvenanceEntityRole> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public PublicationStatus? ToString(Code<PublicationStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.QualityType? ToString(Code<MolecularSequence.QualityType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Quantity.QuantityComparator? ToString(Code<Quantity.QuantityComparator> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Questionnaire.QuestionnaireItemOperator? ToString(Code<Questionnaire.QuestionnaireItemOperator> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Questionnaire.QuestionnaireItemType? ToString(Code<Questionnaire.QuestionnaireItemType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public QuestionnaireResponse.QuestionnaireResponseStatus? ToString(Code<QuestionnaireResponse.QuestionnaireResponseStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.ReferenceHandlingPolicy? ToString(Code<CapabilityStatement.ReferenceHandlingPolicy> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.ReferenceVersionRules? ToString(Code<ElementDefinition.ReferenceVersionRules> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public RelatedArtifact.RelatedArtifactType? ToString(Code<RelatedArtifact.RelatedArtifactType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ClaimProcessingCodes? ToString(Code<ClaimProcessingCodes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.RepositoryType? ToString(Code<MolecularSequence.RepositoryType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ResearchElementDefinition.ResearchElementType? ToString(Code<ResearchElementDefinition.ResearchElementType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ResearchStudy.ResearchStudyStatus? ToString(Code<ResearchStudy.ResearchStudyStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ResearchSubject.ResearchSubjectStatus? ToString(Code<ResearchSubject.ResearchSubjectStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.ResourceVersionPolicy? ToString(Code<CapabilityStatement.ResourceVersionPolicy> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MessageHeader.ResponseType? ToString(Code<MessageHeader.ResponseType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.RestfulCapabilityMode? ToString(Code<CapabilityStatement.RestfulCapabilityMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ImplementationGuide.SPDXLicense? ToString(Code<ImplementationGuide.SPDXLicense> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SearchParameter.SearchComparator? ToString(Code<SearchParameter.SearchComparator> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Bundle.SearchEntryMode? ToString(Code<Bundle.SearchEntryMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SearchParameter.SearchModifierCode? ToString(Code<SearchParameter.SearchModifierCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SearchParamType? ToString(Code<SearchParamType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.SequenceType? ToString(Code<MolecularSequence.SequenceType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ElementDefinition.SlicingRules? ToString(Code<ElementDefinition.SlicingRules> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Slot.SlotStatus? ToString(Code<Slot.SlotStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public DataRequirement.SortDirection? ToString(Code<DataRequirement.SortDirection> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SpecimenDefinition.SpecimenContainedPreference? ToString(Code<SpecimenDefinition.SpecimenContainedPreference> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Specimen.SpecimenStatus? ToString(Code<Specimen.SpecimenStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public VerificationResult.StatusCode? ToString(Code<VerificationResult.StatusCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public MolecularSequence.StrandType? ToString(Code<MolecularSequence.StrandType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureDefinition.StructureDefinitionKind? ToString(Code<StructureDefinition.StructureDefinitionKind> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapContextType? ToString(Code<StructureMap.StructureMapContextType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapGroupTypeMode? ToString(Code<StructureMap.StructureMapGroupTypeMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapInputMode? ToString(Code<StructureMap.StructureMapInputMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapModelMode? ToString(Code<StructureMap.StructureMapModelMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapSourceListMode? ToString(Code<StructureMap.StructureMapSourceListMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapTargetListMode? ToString(Code<StructureMap.StructureMapTargetListMode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureMap.StructureMapTransform? ToString(Code<StructureMap.StructureMapTransform> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Subscription.SubscriptionChannelType? ToString(Code<Subscription.SubscriptionChannelType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Subscription.SubscriptionStatus? ToString(Code<Subscription.SubscriptionStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SupplyDelivery.SupplyDeliveryStatus? ToString(Code<SupplyDelivery.SupplyDeliveryStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SupplyRequest.SupplyRequestStatus? ToString(Code<SupplyRequest.SupplyRequestStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.SystemRestfulInteraction? ToString(Code<CapabilityStatement.SystemRestfulInteraction> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Task.TaskIntent? ToString(Code<Task.TaskIntent> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Task.TaskStatus? ToString(Code<Task.TaskStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestReport.TestReportActionResult? ToString(Code<TestReport.TestReportActionResult> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestReport.TestReportParticipantType? ToString(Code<TestReport.TestReportParticipantType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestReport.TestReportResult? ToString(Code<TestReport.TestReportResult> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestReport.TestReportStatus? ToString(Code<TestReport.TestReportStatus> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TestScript.TestScriptRequestMethodCode? ToString(Code<TestScript.TestScriptRequestMethodCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public TriggerDefinition.TriggerType? ToString(Code<TriggerDefinition.TriggerType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public StructureDefinition.TypeDerivationRule? ToString(Code<StructureDefinition.TypeDerivationRule> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public CapabilityStatement.TypeRestfulInteraction? ToString(Code<CapabilityStatement.TypeRestfulInteraction> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Device.UDIEntryType? ToString(Code<Device.UDIEntryType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public Timing.UnitsOfTime? ToString(Code<Timing.UnitsOfTime> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public ClaimUseCode? ToString(Code<ClaimUseCode> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public VisionPrescription.VisionBase? ToString(Code<VisionPrescription.VisionBase> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public VisionPrescription.VisionEyes? ToString(Code<VisionPrescription.VisionEyes> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public SearchParameter.XPathUsageType? ToString(Code<SearchParameter.XPathUsageType> value) => 
		value?.Value;

    [CqlDeclaration("ToString")]
	public string ToString(Base64Binary value)
	{
		string a_ = context.Operators.Convert<string>(value?.Value);

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
		CqlDate a_ = context.Operators.ConvertStringToDate(value?.Value);

		return a_;
	}

    [CqlDeclaration("ToDateTime")]
	public CqlDateTime ToDateTime(FhirDateTime value)
	{
		CqlDateTime a_ = context.Operators.Convert<CqlDateTime>(value);

		return a_;
	}

    [CqlDeclaration("ToDateTime")]
	public CqlDateTime ToDateTime(Instant value)
	{
		CqlDateTime a_ = context.Operators.Convert<CqlDateTime>(value?.Value);

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
		CqlTime a_ = context.Operators.ConvertStringToTime(value?.Value);

		return a_;
	}

}

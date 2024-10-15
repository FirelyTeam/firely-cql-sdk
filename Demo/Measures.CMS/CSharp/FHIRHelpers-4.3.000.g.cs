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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("FHIRHelpers", "4.3.000")]
public partial class FHIRHelpers_4_3_000 : ILibrary, ISingleton<FHIRHelpers_4_3_000>
{
private FHIRHelpers_4_3_000() {}

public static FHIRHelpers_4_3_000 Instance { get; } = new();

    #region Library Members
    public string Name => "FHIRHelpers";
    public string Version => "4.3.000";
    public ILibrary[] Dependencies => [];
    #endregion Library Members
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

	public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Quantity quantity)
	{
		CqlInterval<CqlQuantity> a_()
		{
			if (quantity is null)
			{
				return null as CqlInterval<CqlQuantity>;
			}
			else
			{
				CqlInterval<CqlQuantity> b_()
				{
					bool c_()
					{
						Code<Quantity.QuantityComparator> g_ = quantity?.ComparatorElement;
						Quantity.QuantityComparator? h_ = g_?.Value;
						string i_ = context.Operators.Convert<string>(h_);
						bool? j_ = context.Operators.Equal(i_, "<");

						return j_ ?? false;
					};
					bool d_()
					{
						Code<Quantity.QuantityComparator> k_ = quantity?.ComparatorElement;
						Quantity.QuantityComparator? l_ = k_?.Value;
						string m_ = context.Operators.Convert<string>(l_);
						bool? n_ = context.Operators.Equal(m_, "<=");

						return n_ ?? false;
					};
					bool e_()
					{
						Code<Quantity.QuantityComparator> o_ = quantity?.ComparatorElement;
						Quantity.QuantityComparator? p_ = o_?.Value;
						string q_ = context.Operators.Convert<string>(p_);
						bool? r_ = context.Operators.Equal(q_, ">=");

						return r_ ?? false;
					};
					bool f_()
					{
						Code<Quantity.QuantityComparator> s_ = quantity?.ComparatorElement;
						Quantity.QuantityComparator? t_ = s_?.Value;
						string u_ = context.Operators.Convert<string>(t_);
						bool? v_ = context.Operators.Equal(u_, ">");

						return v_ ?? false;
					};
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
						CqlInterval<CqlQuantity> ag_ = context.Operators.Interval(ae_, ae_, true, true);

						return ag_;
					}
				};

				return b_();
			}
		};

		return a_();
	}

	public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Range range)
	{
		CqlInterval<CqlQuantity> a_()
		{
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
		};

		return a_();
	}

	public string ToCalendarUnit(CqlContext context, string unit)
	{
		string a_()
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

		return a_();
	}

	public CqlQuantity ToQuantity(CqlContext context, Quantity quantity)
	{
		CqlQuantity a_()
		{
			bool b_()
			{
				Code<Quantity.QuantityComparator> d_ = quantity?.ComparatorElement;
				bool? e_ = context.Operators.Not((bool?)(d_ is null));

				return e_ ?? false;
			};
			bool c_()
			{
				FhirUri f_ = quantity?.SystemElement;
				string h_ = f_?.Value;
				bool? i_ = context.Operators.Equal(h_, "http://unitsofmeasure.org");
				bool? j_ = context.Operators.Or((bool?)(f_ is null), i_);
				string l_ = f_?.Value;
				bool? m_ = context.Operators.Equal(l_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
				bool? n_ = context.Operators.Or(j_, m_);

				return n_ ?? false;
			};
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
				object o_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.ComparatorQuantityNotSupported", "Error", "FHIR Quantity value has a comparator and cannot be converted to a System.Quantity value.");

				return o_ as CqlQuantity;
			}
			else if (c_())
			{
				FhirDecimal p_ = quantity?.ValueElement;
				decimal? q_ = p_?.Value;
				Code r_ = quantity?.CodeElement;
				string s_ = r_?.Value;
				FhirString t_ = quantity?.UnitElement;
				string u_ = t_?.Value;
				string v_ = this.ToCalendarUnit(context, (s_ ?? u_) ?? "1");

				return new CqlQuantity(q_, v_);
			}
			else
			{
				FhirString w_ = quantity?.UnitElement;
				string x_ = w_?.Value;
				string y_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", x_ ?? "");
				string z_ = context.Operators.Concatenate(y_ ?? "", " (");
				FhirUri aa_ = quantity?.SystemElement;
				string ab_ = aa_?.Value;
				string ac_ = context.Operators.Concatenate(z_ ?? "", ab_ ?? "");
				string ad_ = context.Operators.Concatenate(ac_ ?? "", "|");
				Code ae_ = quantity?.CodeElement;
				string af_ = ae_?.Value;
				string ag_ = context.Operators.Concatenate(ad_ ?? "", af_ ?? "");
				string ah_ = context.Operators.Concatenate(ag_ ?? "", ")");
				object ai_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", ah_);

				return ai_ as CqlQuantity;
			}
		};

		return a_();
	}

	public CqlQuantity ToQuantityIgnoringComparator(CqlContext context, Quantity quantity)
	{
		CqlQuantity a_()
		{
			bool b_()
			{
				FhirUri c_ = quantity?.SystemElement;
				string e_ = c_?.Value;
				bool? f_ = context.Operators.Equal(e_, "http://unitsofmeasure.org");
				bool? g_ = context.Operators.Or((bool?)(c_ is null), f_);
				string i_ = c_?.Value;
				bool? j_ = context.Operators.Equal(i_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
				bool? k_ = context.Operators.Or(g_, j_);

				return k_ ?? false;
			};
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
				FhirDecimal l_ = quantity?.ValueElement;
				decimal? m_ = l_?.Value;
				Code n_ = quantity?.CodeElement;
				string o_ = n_?.Value;
				FhirString p_ = quantity?.UnitElement;
				string q_ = p_?.Value;
				string r_ = this.ToCalendarUnit(context, (o_ ?? q_) ?? "1");

				return new CqlQuantity(m_, r_);
			}
			else
			{
				FhirString s_ = quantity?.UnitElement;
				string t_ = s_?.Value;
				string u_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", t_ ?? "");
				string v_ = context.Operators.Concatenate(u_ ?? "", " (");
				FhirUri w_ = quantity?.SystemElement;
				string x_ = w_?.Value;
				string y_ = context.Operators.Concatenate(v_ ?? "", x_ ?? "");
				string z_ = context.Operators.Concatenate(y_ ?? "", "|");
				Code aa_ = quantity?.CodeElement;
				string ab_ = aa_?.Value;
				string ac_ = context.Operators.Concatenate(z_ ?? "", ab_ ?? "");
				string ad_ = context.Operators.Concatenate(ac_ ?? "", ")");
				object ae_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", ad_);

				return ae_ as CqlQuantity;
			}
		};

		return a_();
	}

	public CqlRatio ToRatio(CqlContext context, Ratio ratio)
	{
		CqlRatio a_()
		{
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
		};

		return a_();
	}

	public CqlCode ToCode(CqlContext context, Coding coding)
	{
		CqlCode a_()
		{
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
		};

		return a_();
	}

	public CqlConcept ToConcept(CqlContext context, CodeableConcept concept)
	{
		CqlConcept a_()
		{
			if (concept is null)
			{
				return default;
			}
			else
			{
				List<Coding> b_ = concept?.Coding;
				CqlCode c_(Coding C)
				{
					CqlCode g_ = this.ToCode(context, C);

					return g_;
				};
				IEnumerable<CqlCode> d_ = context.Operators.Select<Coding, CqlCode>((IEnumerable<Coding>)b_, c_);
				FhirString e_ = concept?.TextElement;
				string f_ = e_?.Value;

				return new CqlConcept(d_, f_);
			}
		};

		return a_();
	}

	public CqlValueSet ToValueSet(CqlContext context, string uri)
	{
		CqlValueSet a_()
		{
			if (uri is null)
			{
				return default;
			}
			else
			{
				CqlValueSet b_ = new CqlValueSet
				{
					id = uri,
				};

				return b_;
			}
		};

		return a_();
	}

	public ResourceReference reference(CqlContext context, string reference)
	{
		ResourceReference a_()
		{
			if (reference is null)
			{
				return default;
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
			}
		};

		return a_();
	}

	public ResourceReference reference(CqlContext context, Resource resource) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.reference is not implemented."));

	public object ToValue(CqlContext context, object value)
	{
		object a_()
		{
			if (value is Base64Binary)
			{
				byte[] b_ = (value as Base64Binary)?.Value;
				string c_ = context.Operators.Convert<string>(b_);

				return c_ as object;
			}
			else if (value is FhirBoolean)
			{
				bool? d_ = (value as FhirBoolean)?.Value;

				return d_;
			}
			else if (value is Canonical)
			{
				string e_ = (value as Canonical)?.Value;

				return e_ as object;
			}
			else if (value is Code)
			{
				string f_ = (value as Code)?.Value;

				return f_ as object;
			}
			else if (value is Date)
			{
				string g_ = (value as Date)?.Value;
				CqlDate h_ = context.Operators.ConvertStringToDate(g_);

				return h_ as object;
			}
			else if (value is FhirDateTime)
			{
				CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(value as FhirDateTime);

				return i_ as object;
			}
			else if (value is FhirDecimal)
			{
				decimal? j_ = (value as FhirDecimal)?.Value;

				return j_;
			}
			else if (value is Id)
			{
				string k_ = (value as Id)?.Value;

				return k_ as object;
			}
			else if (value is Instant)
			{
				DateTimeOffset? l_ = (value as Instant)?.Value;
				CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);

				return m_ as object;
			}
			else if (value is Integer)
			{
				int? n_ = (value as Integer)?.Value;

				return n_;
			}
			else if (value is Markdown)
			{
				string o_ = (value as Markdown)?.Value;

				return o_ as object;
			}
			else if (value is Oid)
			{
				string p_ = (value as Oid)?.Value;

				return p_ as object;
			}
			else if (value is Integer)
			{
				int? q_ = (value as Integer)?.Value;

				return q_;
			}
			else if (value is FhirString)
			{
				string r_ = (value as FhirString)?.Value;

				return r_ as object;
			}
			else if (value is Time)
			{
				string s_ = (value as Time)?.Value;
				CqlTime t_ = context.Operators.ConvertStringToTime(s_);

				return t_ as object;
			}
			else if (value is Integer)
			{
				int? u_ = (value as Integer)?.Value;

				return u_;
			}
			else if (value is FhirUri)
			{
				string v_ = (value as FhirUri)?.Value;

				return v_ as object;
			}
			else if (value is FhirUrl)
			{
				string w_ = (value as FhirUrl)?.Value;

				return w_ as object;
			}
			else if (value is Uuid)
			{
				string x_ = (value as Uuid)?.Value;

				return x_ as object;
			}
			else if (value is Age)
			{
				CqlQuantity y_ = this.ToQuantity(context, value as Age);

				return y_ as object;
			}
			else if (value is CodeableConcept)
			{
				CqlConcept z_ = this.ToConcept(context, value as CodeableConcept);

				return z_ as object;
			}
			else if (value is Coding)
			{
				CqlCode aa_ = this.ToCode(context, value as Coding);

				return aa_ as object;
			}
			else if (value is Count)
			{
				CqlQuantity ab_ = this.ToQuantity(context, value as Count);

				return ab_ as object;
			}
			else if (value is Distance)
			{
				CqlQuantity ac_ = this.ToQuantity(context, value as Distance);

				return ac_ as object;
			}
			else if (value is Duration)
			{
				CqlQuantity ad_ = this.ToQuantity(context, value as Duration);

				return ad_ as object;
			}
			else if (value is Quantity)
			{
				CqlQuantity ae_ = this.ToQuantity(context, value as Quantity);

				return ae_ as object;
			}
			else if (value is Range)
			{
				CqlInterval<CqlQuantity> af_ = this.ToInterval(context, value as Range);

				return af_ as object;
			}
			else if (value is Period)
			{
				CqlInterval<CqlDateTime> ag_ = this.ToInterval(context, value as Period);

				return ag_ as object;
			}
			else if (value is Ratio)
			{
				CqlRatio ah_ = this.ToRatio(context, value as Ratio);

				return ah_ as object;
			}
			else
			{
				return value as object;
			}
		};

		return a_();
	}

	public Resource resolve(CqlContext context, string reference) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.resolve is not implemented."));

	public Resource resolve(CqlContext context, ResourceReference reference) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.resolve is not implemented."));

	public IEnumerable<Extension> extension(CqlContext context, Element element, string url) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.extension is not implemented."));

	public IEnumerable<Extension> extension(CqlContext context, DomainResource resource, string url) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.extension is not implemented."));

	public IEnumerable<Extension> modifierExtension(CqlContext context, BackboneElement element, string url) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.modifierExtension is not implemented."));

	public IEnumerable<Extension> modifierExtension(CqlContext context, DomainResource resource, string url) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.modifierExtension is not implemented."));

	public bool? hasValue(CqlContext context, Element element) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.hasValue is not implemented."));

	public object getValue(CqlContext context, Element element) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.getValue is not implemented."));

	public IEnumerable<object> ofType(CqlContext context, string identifier) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.ofType is not implemented."));

	public bool? @is(CqlContext context, string identifier) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.is is not implemented."));

	public object @as(CqlContext context, string identifier) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.as is not implemented."));

	public ElementDefinition elementDefinition(CqlContext context, Element element) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.elementDefinition is not implemented."));

	public IEnumerable<Element> slice(CqlContext context, Element element, string url, string name) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.slice is not implemented."));

	public Resource checkModifiers(CqlContext context, Resource resource) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));

	public Resource checkModifiers(CqlContext context, Resource resource, string modifier) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));

	public Element checkModifiers(CqlContext context, Element element) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));

	public Element checkModifiers(CqlContext context, Element element, string modifier) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.checkModifiers is not implemented."));

	public bool? conformsTo(CqlContext context, Resource resource, string structure) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.conformsTo is not implemented."));

	public bool? memberOf(CqlContext context, Code code, string valueSet) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));

	public bool? memberOf(CqlContext context, Coding coding, string valueSet) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));

	public bool? memberOf(CqlContext context, CodeableConcept concept, string valueSet) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.memberOf is not implemented."));

	public bool? subsumes(CqlContext context, Coding coding, Coding subsumedCoding) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumes is not implemented."));

	public bool? subsumes(CqlContext context, CodeableConcept concept, CodeableConcept subsumedConcept) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumes is not implemented."));

	public bool? subsumedBy(CqlContext context, Coding coding, Coding subsumingCoding) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumedBy is not implemented."));

	public bool? subsumedBy(CqlContext context, CodeableConcept concept, CodeableConcept subsumingConcept) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.subsumedBy is not implemented."));

	public bool? htmlChecks(CqlContext context, Element element) => 
		throw (new NotImplementedException("External function FHIRHelpers-4.3.000.htmlChecks is not implemented."));

	public string ToString(CqlContext context, Code<Account.AccountStatus> value)
	{
		Account.AccountStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ActionCardinalityBehavior> value)
	{
		ActionCardinalityBehavior? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ActionConditionKind> value)
	{
		ActionConditionKind? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ActionGroupingBehavior> value)
	{
		ActionGroupingBehavior? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ActionParticipantType> value)
	{
		ActionParticipantType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ActionPrecheckBehavior> value)
	{
		ActionPrecheckBehavior? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ActionRelationshipType> value)
	{
		ActionRelationshipType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ActionRequiredBehavior> value)
	{
		ActionRequiredBehavior? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ActionSelectionBehavior> value)
	{
		ActionSelectionBehavior? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ActivityDefinition.RequestResourceType> value)
	{
		ActivityDefinition.RequestResourceType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Address.AddressType> value)
	{
		Address.AddressType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Address.AddressUse> value)
	{
		Address.AddressUse? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<AdministrativeGender> value)
	{
		AdministrativeGender? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<AdverseEvent.AdverseEventActuality> value)
	{
		AdverseEvent.AdverseEventActuality? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ElementDefinition.AggregationMode> value)
	{
		ElementDefinition.AggregationMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
	{
		AllergyIntolerance.AllergyIntoleranceCategory? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
	{
		AllergyIntolerance.AllergyIntoleranceCriticality? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
	{
		AllergyIntolerance.AllergyIntoleranceSeverity? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceType> value)
	{
		AllergyIntolerance.AllergyIntoleranceType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Appointment.AppointmentStatus> value)
	{
		Appointment.AppointmentStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<TestScript.AssertionDirectionType> value)
	{
		TestScript.AssertionDirectionType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<TestScript.AssertionOperatorType> value)
	{
		TestScript.AssertionOperatorType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<TestScript.AssertionResponseTypes> value)
	{
		TestScript.AssertionResponseTypes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<AuditEvent.AuditEventAction> value)
	{
		AuditEvent.AuditEventAction? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<AuditEvent.AuditEventAgentNetworkType> value)
	{
		AuditEvent.AuditEventAgentNetworkType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<AuditEvent.AuditEventOutcome> value)
	{
		AuditEvent.AuditEventOutcome? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<BindingStrength> value)
	{
		BindingStrength? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
	{
		BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
	{
		BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
	{
		BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Bundle.BundleType> value)
	{
		Bundle.BundleType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CapabilityStatementKind> value)
	{
		CapabilityStatementKind? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityKind> value)
	{
		CarePlan.CarePlanActivityKind? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityStatus> value)
	{
		CarePlan.CarePlanActivityStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CarePlan.CarePlanIntent> value)
	{
		CarePlan.CarePlanIntent? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<RequestStatus> value)
	{
		RequestStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CareTeam.CareTeamStatus> value)
	{
		CareTeam.CareTeamStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CatalogEntry.CatalogEntryRelationType> value)
	{
		CatalogEntry.CatalogEntryRelationType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<InvoicePriceComponentType> value)
	{
		InvoicePriceComponentType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ChargeItem.ChargeItemStatus> value)
	{
		ChargeItem.ChargeItemStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<FinancialResourceStatusCodes> value)
	{
		FinancialResourceStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ClinicalImpression.ClinicalImpressionStatus> value)
	{
		ClinicalImpression.ClinicalImpressionStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<TerminologyCapabilities.CodeSearchSupport> value)
	{
		TerminologyCapabilities.CodeSearchSupport? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CodeSystemContentMode> value)
	{
		CodeSystemContentMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CodeSystem.CodeSystemHierarchyMeaning> value)
	{
		CodeSystem.CodeSystemHierarchyMeaning? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<RequestPriority> value)
	{
		RequestPriority? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<EventStatus> value)
	{
		EventStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CompartmentType> value)
	{
		CompartmentType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Composition.CompositionAttestationMode> value)
	{
		Composition.CompositionAttestationMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CompositionStatus> value)
	{
		CompositionStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ConceptMapEquivalence> value)
	{
		ConceptMapEquivalence? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
	{
		ConceptMap.ConceptMapGroupUnmappedMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalDeleteStatus> value)
	{
		CapabilityStatement.ConditionalDeleteStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalReadStatus> value)
	{
		CapabilityStatement.ConditionalReadStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Consent.ConsentDataMeaning> value)
	{
		Consent.ConsentDataMeaning? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Consent.ConsentProvisionType> value)
	{
		Consent.ConsentProvisionType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Consent.ConsentState> value)
	{
		Consent.ConsentState? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ConstraintSeverity> value)
	{
		ConstraintSeverity? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ContactPoint.ContactPointSystem> value)
	{
		ContactPoint.ContactPointSystem? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ContactPoint.ContactPointUse> value)
	{
		ContactPoint.ContactPointUse? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Contract.ContractResourcePublicationStatusCodes> value)
	{
		Contract.ContractResourcePublicationStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Contract.ContractResourceStatusCodes> value)
	{
		Contract.ContractResourceStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Contributor.ContributorType> value)
	{
		Contributor.ContributorType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Money.Currencies> value)
	{
		Money.Currencies? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<DaysOfWeek> value)
	{
		DaysOfWeek? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<DetectedIssue.DetectedIssueSeverity> value)
	{
		DetectedIssue.DetectedIssueSeverity? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ObservationStatus> value)
	{
		ObservationStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationState> value)
	{
		DeviceMetric.DeviceMetricCalibrationState? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationType> value)
	{
		DeviceMetric.DeviceMetricCalibrationType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCategory> value)
	{
		DeviceMetric.DeviceMetricCategory? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricColor> value)
	{
		DeviceMetric.DeviceMetricColor? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricOperationalStatus> value)
	{
		DeviceMetric.DeviceMetricOperationalStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<DeviceNameType> value)
	{
		DeviceNameType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<DeviceUseStatement.DeviceUseStatementStatus> value)
	{
		DeviceUseStatement.DeviceUseStatementStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<DiagnosticReport.DiagnosticReportStatus> value)
	{
		DiagnosticReport.DiagnosticReportStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ElementDefinition.DiscriminatorType> value)
	{
		ElementDefinition.DiscriminatorType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Composition.V3ConfidentialityClassification> value)
	{
		Composition.V3ConfidentialityClassification? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CapabilityStatement.DocumentMode> value)
	{
		CapabilityStatement.DocumentMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<DocumentReferenceStatus> value)
	{
		DocumentReferenceStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<DocumentRelationshipType> value)
	{
		DocumentRelationshipType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
	{
		CoverageEligibilityRequest.EligibilityRequestPurpose? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
	{
		CoverageEligibilityResponse.EligibilityResponsePurpose? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Questionnaire.EnableWhenBehavior> value)
	{
		Questionnaire.EnableWhenBehavior? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Encounter.EncounterLocationStatus> value)
	{
		Encounter.EncounterLocationStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Encounter.EncounterStatus> value)
	{
		Encounter.EncounterStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Endpoint.EndpointStatus> value)
	{
		Endpoint.EndpointStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<EpisodeOfCare.EpisodeOfCareStatus> value)
	{
		EpisodeOfCare.EpisodeOfCareStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CapabilityStatement.EventCapabilityMode> value)
	{
		CapabilityStatement.EventCapabilityMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Timing.EventTiming> value)
	{
		Timing.EventTiming? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<VariableTypeCode> value)
	{
		VariableTypeCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ExampleScenario.ExampleScenarioActorType> value)
	{
		ExampleScenario.ExampleScenarioActorType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
	{
		ExplanationOfBenefit.ExplanationOfBenefitStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<EffectEvidenceSynthesis.ExposureStateCode> value)
	{
		EffectEvidenceSynthesis.ExposureStateCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<StructureDefinition.ExtensionContextType> value)
	{
		StructureDefinition.ExtensionContextType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<FHIRAllTypes> value)
	{
		FHIRAllTypes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<FHIRDefinedType> value)
	{
		FHIRDefinedType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Device.FHIRDeviceStatus> value)
	{
		Device.FHIRDeviceStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ResourceType> value)
	{
		ResourceType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Substance.FHIRSubstanceStatus> value)
	{
		Substance.FHIRSubstanceStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<FHIRVersion> value)
	{
		FHIRVersion? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<FamilyMemberHistory.FamilyHistoryStatus> value)
	{
		FamilyMemberHistory.FamilyHistoryStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<FilterOperator> value)
	{
		FilterOperator? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Flag.FlagStatus> value)
	{
		Flag.FlagStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Goal.GoalLifecycleStatus> value)
	{
		Goal.GoalLifecycleStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentRule> value)
	{
		GraphDefinition.GraphCompartmentRule? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentUse> value)
	{
		GraphDefinition.GraphCompartmentUse? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<GroupMeasureCode> value)
	{
		GroupMeasureCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Group.GroupType> value)
	{
		Group.GroupType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<GuidanceResponse.GuidanceResponseStatus> value)
	{
		GuidanceResponse.GuidanceResponseStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ImplementationGuide.GuidePageGeneration> value)
	{
		ImplementationGuide.GuidePageGeneration? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ImplementationGuide.GuideParameterCode> value)
	{
		ImplementationGuide.GuideParameterCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Bundle.HTTPVerb> value)
	{
		Bundle.HTTPVerb? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Identifier.IdentifierUse> value)
	{
		Identifier.IdentifierUse? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Person.IdentityAssuranceLevel> value)
	{
		Person.IdentityAssuranceLevel? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ImagingStudy.ImagingStudyStatus> value)
	{
		ImagingStudy.ImagingStudyStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
	{
		ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Immunization.ImmunizationStatusCodes> value)
	{
		Immunization.ImmunizationStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Invoice.InvoiceStatus> value)
	{
		Invoice.InvoiceStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<OperationOutcome.IssueSeverity> value)
	{
		OperationOutcome.IssueSeverity? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<OperationOutcome.IssueType> value)
	{
		OperationOutcome.IssueType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Patient.LinkType> value)
	{
		Patient.LinkType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Linkage.LinkageType> value)
	{
		Linkage.LinkageType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ListMode> value)
	{
		ListMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<List.ListStatus> value)
	{
		List.ListStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Location.LocationMode> value)
	{
		Location.LocationMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Location.LocationStatus> value)
	{
		Location.LocationStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MeasureReport.MeasureReportStatus> value)
	{
		MeasureReport.MeasureReportStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MeasureReport.MeasureReportType> value)
	{
		MeasureReport.MeasureReportType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
	{
		MedicationAdministration.MedicationAdministrationStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MedicationDispense.MedicationDispenseStatusCodes> value)
	{
		MedicationDispense.MedicationDispenseStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
	{
		MedicationKnowledge.MedicationKnowledgeStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MedicationRequest.MedicationRequestIntent> value)
	{
		MedicationRequest.MedicationRequestIntent? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MedicationRequest.MedicationrequestStatus> value)
	{
		MedicationRequest.MedicationrequestStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MedicationStatement.MedicationStatusCodes> value)
	{
		MedicationStatement.MedicationStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Medication.MedicationStatusCodes> value)
	{
		Medication.MedicationStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MessageDefinition.MessageSignificanceCategory> value)
	{
		MessageDefinition.MessageSignificanceCategory? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MessageheaderResponseRequest> value)
	{
		MessageheaderResponseRequest? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code value)
	{
		string a_ = value?.Value;

		return a_;
	}

	public string ToString(CqlContext context, Code<HumanName.NameUse> value)
	{
		HumanName.NameUse? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<NamingSystem.NamingSystemIdentifierType> value)
	{
		NamingSystem.NamingSystemIdentifierType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<NamingSystem.NamingSystemType> value)
	{
		NamingSystem.NamingSystemType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Narrative.NarrativeStatus> value)
	{
		Narrative.NarrativeStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<NoteType> value)
	{
		NoteType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<RequestIntent> value)
	{
		RequestIntent? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ObservationDefinition.ObservationDataType> value)
	{
		ObservationDefinition.ObservationDataType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ObservationDefinition.ObservationRangeCategory> value)
	{
		ObservationDefinition.ObservationRangeCategory? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<OperationDefinition.OperationKind> value)
	{
		OperationDefinition.OperationKind? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<OperationParameterUse> value)
	{
		OperationParameterUse? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MolecularSequence.OrientationType> value)
	{
		MolecularSequence.OrientationType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Appointment.ParticipantRequired> value)
	{
		Appointment.ParticipantRequired? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ParticipationStatus> value)
	{
		ParticipationStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ElementDefinition.PropertyRepresentation> value)
	{
		ElementDefinition.PropertyRepresentation? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CodeSystem.PropertyType> value)
	{
		CodeSystem.PropertyType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Provenance.ProvenanceEntityRole> value)
	{
		Provenance.ProvenanceEntityRole? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<PublicationStatus> value)
	{
		PublicationStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MolecularSequence.QualityType> value)
	{
		MolecularSequence.QualityType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Quantity.QuantityComparator> value)
	{
		Quantity.QuantityComparator? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemOperator> value)
	{
		Questionnaire.QuestionnaireItemOperator? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemType> value)
	{
		Questionnaire.QuestionnaireItemType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
	{
		QuestionnaireResponse.QuestionnaireResponseStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CapabilityStatement.ReferenceHandlingPolicy> value)
	{
		CapabilityStatement.ReferenceHandlingPolicy? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ElementDefinition.ReferenceVersionRules> value)
	{
		ElementDefinition.ReferenceVersionRules? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<RelatedArtifact.RelatedArtifactType> value)
	{
		RelatedArtifact.RelatedArtifactType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ClaimProcessingCodes> value)
	{
		ClaimProcessingCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MolecularSequence.RepositoryType> value)
	{
		MolecularSequence.RepositoryType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ResearchElementDefinition.ResearchElementType> value)
	{
		ResearchElementDefinition.ResearchElementType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ResearchStudy.ResearchStudyStatus> value)
	{
		ResearchStudy.ResearchStudyStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ResearchSubject.ResearchSubjectStatus> value)
	{
		ResearchSubject.ResearchSubjectStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CapabilityStatement.ResourceVersionPolicy> value)
	{
		CapabilityStatement.ResourceVersionPolicy? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MessageHeader.ResponseType> value)
	{
		MessageHeader.ResponseType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CapabilityStatement.RestfulCapabilityMode> value)
	{
		CapabilityStatement.RestfulCapabilityMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ImplementationGuide.SPDXLicense> value)
	{
		ImplementationGuide.SPDXLicense? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<SearchParameter.SearchComparator> value)
	{
		SearchParameter.SearchComparator? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Bundle.SearchEntryMode> value)
	{
		Bundle.SearchEntryMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<SearchParameter.SearchModifierCode> value)
	{
		SearchParameter.SearchModifierCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<SearchParamType> value)
	{
		SearchParamType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MolecularSequence.SequenceType> value)
	{
		MolecularSequence.SequenceType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ElementDefinition.SlicingRules> value)
	{
		ElementDefinition.SlicingRules? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Slot.SlotStatus> value)
	{
		Slot.SlotStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<DataRequirement.SortDirection> value)
	{
		DataRequirement.SortDirection? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<SpecimenDefinition.SpecimenContainedPreference> value)
	{
		SpecimenDefinition.SpecimenContainedPreference? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Specimen.SpecimenStatus> value)
	{
		Specimen.SpecimenStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<VerificationResult.StatusCode> value)
	{
		VerificationResult.StatusCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<MolecularSequence.StrandType> value)
	{
		MolecularSequence.StrandType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<StructureDefinition.StructureDefinitionKind> value)
	{
		StructureDefinition.StructureDefinitionKind? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<StructureMap.StructureMapContextType> value)
	{
		StructureMap.StructureMapContextType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<StructureMap.StructureMapGroupTypeMode> value)
	{
		StructureMap.StructureMapGroupTypeMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<StructureMap.StructureMapInputMode> value)
	{
		StructureMap.StructureMapInputMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<StructureMap.StructureMapModelMode> value)
	{
		StructureMap.StructureMapModelMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<StructureMap.StructureMapSourceListMode> value)
	{
		StructureMap.StructureMapSourceListMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<StructureMap.StructureMapTargetListMode> value)
	{
		StructureMap.StructureMapTargetListMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<StructureMap.StructureMapTransform> value)
	{
		StructureMap.StructureMapTransform? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Subscription.SubscriptionChannelType> value)
	{
		Subscription.SubscriptionChannelType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Subscription.SubscriptionStatus> value)
	{
		Subscription.SubscriptionStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<SupplyDelivery.SupplyDeliveryStatus> value)
	{
		SupplyDelivery.SupplyDeliveryStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<SupplyRequest.SupplyRequestStatus> value)
	{
		SupplyRequest.SupplyRequestStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CapabilityStatement.SystemRestfulInteraction> value)
	{
		CapabilityStatement.SystemRestfulInteraction? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Task.TaskIntent> value)
	{
		Task.TaskIntent? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Task.TaskStatus> value)
	{
		Task.TaskStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<TestReport.TestReportActionResult> value)
	{
		TestReport.TestReportActionResult? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<TestReport.TestReportParticipantType> value)
	{
		TestReport.TestReportParticipantType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<TestReport.TestReportResult> value)
	{
		TestReport.TestReportResult? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<TestReport.TestReportStatus> value)
	{
		TestReport.TestReportStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<TestScript.TestScriptRequestMethodCode> value)
	{
		TestScript.TestScriptRequestMethodCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<TriggerDefinition.TriggerType> value)
	{
		TriggerDefinition.TriggerType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<StructureDefinition.TypeDerivationRule> value)
	{
		StructureDefinition.TypeDerivationRule? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<CapabilityStatement.TypeRestfulInteraction> value)
	{
		CapabilityStatement.TypeRestfulInteraction? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Device.UDIEntryType> value)
	{
		Device.UDIEntryType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<Timing.UnitsOfTime> value)
	{
		Timing.UnitsOfTime? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<ClaimUseCode> value)
	{
		ClaimUseCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<VisionPrescription.VisionBase> value)
	{
		VisionPrescription.VisionBase? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<VisionPrescription.VisionEyes> value)
	{
		VisionPrescription.VisionEyes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Code<SearchParameter.XPathUsageType> value)
	{
		SearchParameter.XPathUsageType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, Base64Binary value)
	{
		byte[] a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

	public string ToString(CqlContext context, FhirString value)
	{
		string a_ = value?.Value;

		return a_;
	}

	public string ToString(CqlContext context, FhirUri value)
	{
		string a_ = value?.Value;

		return a_;
	}

	public string ToString(CqlContext context, XHtml value)
	{
		string a_ = value?.Value;

		return a_;
	}

	public bool? ToBoolean(CqlContext context, FhirBoolean value)
	{
		bool? a_ = value?.Value;

		return a_;
	}

	public CqlDate ToDate(CqlContext context, Date value)
	{
		string a_ = value?.Value;
		CqlDate b_ = context.Operators.ConvertStringToDate(a_);

		return b_;
	}

	public CqlDateTime ToDateTime(CqlContext context, FhirDateTime value)
	{
		CqlDateTime a_ = context.Operators.Convert<CqlDateTime>(value);

		return a_;
	}

	public CqlDateTime ToDateTime(CqlContext context, Instant value)
	{
		DateTimeOffset? a_ = value?.Value;
		CqlDateTime b_ = context.Operators.Convert<CqlDateTime>(a_);

		return b_;
	}

	public decimal? ToDecimal(CqlContext context, FhirDecimal value)
	{
		decimal? a_ = value?.Value;

		return a_;
	}

	public int? ToInteger(CqlContext context, Integer value)
	{
		int? a_ = value?.Value;

		return a_;
	}

	public CqlTime ToTime(CqlContext context, Time value)
	{
		string a_ = value?.Value;
		CqlTime b_ = context.Operators.ConvertStringToTime(a_);

		return b_;
	}

}

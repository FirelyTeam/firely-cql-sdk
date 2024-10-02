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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("FHIRHelpers", "4.0.1")]
public class FHIRHelpers_4_0_1
{


    internal CqlContext context;

    #region Cached values


    #endregion
    public FHIRHelpers_4_0_1(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");


    }
    [CqlDeclaration("ToInterval")]
	public CqlInterval<CqlDateTime> ToInterval(Period period)
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

    [CqlDeclaration("ToInterval")]
	public CqlInterval<CqlQuantity> ToInterval(Quantity quantity)
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
						CqlQuantity w_ = this.ToQuantityIgnoringComparator(quantity);
						CqlInterval<CqlQuantity> x_ = context.Operators.Interval(default, w_, true, false);

						return x_;
					}
					else if (d_())
					{
						CqlQuantity y_ = this.ToQuantityIgnoringComparator(quantity);
						CqlInterval<CqlQuantity> z_ = context.Operators.Interval(default, y_, true, true);

						return z_;
					}
					else if (e_())
					{
						CqlQuantity aa_ = this.ToQuantityIgnoringComparator(quantity);
						CqlInterval<CqlQuantity> ab_ = context.Operators.Interval(aa_, default, true, true);

						return ab_;
					}
					else if (f_())
					{
						CqlQuantity ac_ = this.ToQuantityIgnoringComparator(quantity);
						CqlInterval<CqlQuantity> ad_ = context.Operators.Interval(ac_, default, false, true);

						return ad_;
					}
					else
					{
						CqlQuantity ae_ = this.ToQuantity(quantity);
						CqlInterval<CqlQuantity> ag_ = context.Operators.Interval(ae_, ae_, true, true);

						return ag_;
					}
				};

				return b_();
			}
		};

		return a_();
	}

    [CqlDeclaration("ToInterval")]
	public CqlInterval<CqlQuantity> ToInterval(Range range)
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
				CqlQuantity c_ = this.ToQuantity(b_);
				Quantity d_ = range?.High;
				CqlQuantity e_ = this.ToQuantity(d_);
				CqlInterval<CqlQuantity> f_ = context.Operators.Interval(c_, e_, true, true);

				return f_;
			}
		};

		return a_();
	}

    [CqlDeclaration("ToCalendarUnit")]
	public string ToCalendarUnit(string unit)
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

    [CqlDeclaration("ToQuantity")]
	public CqlQuantity ToQuantity(Quantity quantity)
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
				string v_ = this.ToCalendarUnit((s_ ?? u_) ?? "1");

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

    [CqlDeclaration("ToQuantityIgnoringComparator")]
	public CqlQuantity ToQuantityIgnoringComparator(Quantity quantity)
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
				string r_ = this.ToCalendarUnit((o_ ?? q_) ?? "1");

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

    [CqlDeclaration("ToRatio")]
	public CqlRatio ToRatio(Ratio ratio)
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
				CqlQuantity c_ = this.ToQuantity(b_);
				Quantity d_ = ratio?.Denominator;
				CqlQuantity e_ = this.ToQuantity(d_);

				return new CqlRatio(c_, e_);
			}
		};

		return a_();
	}

    [CqlDeclaration("ToCode")]
	public CqlCode ToCode(Coding coding)
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

    [CqlDeclaration("ToConcept")]
	public CqlConcept ToConcept(CodeableConcept concept)
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
					CqlCode g_ = this.ToCode(C);

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

    [CqlDeclaration("ToString")]
	public string ToString(Code<Account.AccountStatus> value)
	{
		Account.AccountStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionCardinalityBehavior> value)
	{
		ActionCardinalityBehavior? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionConditionKind> value)
	{
		ActionConditionKind? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionGroupingBehavior> value)
	{
		ActionGroupingBehavior? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionParticipantType> value)
	{
		ActionParticipantType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionPrecheckBehavior> value)
	{
		ActionPrecheckBehavior? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionRelationshipType> value)
	{
		ActionRelationshipType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionRequiredBehavior> value)
	{
		ActionRequiredBehavior? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActionSelectionBehavior> value)
	{
		ActionSelectionBehavior? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ActivityDefinition.RequestResourceType> value)
	{
		ActivityDefinition.RequestResourceType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Address.AddressType> value)
	{
		Address.AddressType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Address.AddressUse> value)
	{
		Address.AddressUse? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AdministrativeGender> value)
	{
		AdministrativeGender? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AdverseEvent.AdverseEventActuality> value)
	{
		AdverseEvent.AdverseEventActuality? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.AggregationMode> value)
	{
		ElementDefinition.AggregationMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
	{
		AllergyIntolerance.AllergyIntoleranceCategory? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
	{
		AllergyIntolerance.AllergyIntoleranceCriticality? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
	{
		AllergyIntolerance.AllergyIntoleranceSeverity? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AllergyIntolerance.AllergyIntoleranceType> value)
	{
		AllergyIntolerance.AllergyIntoleranceType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Appointment.AppointmentStatus> value)
	{
		Appointment.AppointmentStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestScript.AssertionDirectionType> value)
	{
		TestScript.AssertionDirectionType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestScript.AssertionOperatorType> value)
	{
		TestScript.AssertionOperatorType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestScript.AssertionResponseTypes> value)
	{
		TestScript.AssertionResponseTypes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AuditEvent.AuditEventAction> value)
	{
		AuditEvent.AuditEventAction? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AuditEvent.AuditEventAgentNetworkType> value)
	{
		AuditEvent.AuditEventAgentNetworkType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<AuditEvent.AuditEventOutcome> value)
	{
		AuditEvent.AuditEventOutcome? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<BindingStrength> value)
	{
		BindingStrength? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
	{
		BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
	{
		BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
	{
		BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Bundle.BundleType> value)
	{
		Bundle.BundleType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatementKind> value)
	{
		CapabilityStatementKind? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CarePlan.CarePlanActivityKind> value)
	{
		CarePlan.CarePlanActivityKind? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CarePlan.CarePlanActivityStatus> value)
	{
		CarePlan.CarePlanActivityStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CarePlan.CarePlanIntent> value)
	{
		CarePlan.CarePlanIntent? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<RequestStatus> value)
	{
		RequestStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CareTeam.CareTeamStatus> value)
	{
		CareTeam.CareTeamStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CatalogEntry.CatalogEntryRelationType> value)
	{
		CatalogEntry.CatalogEntryRelationType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<InvoicePriceComponentType> value)
	{
		InvoicePriceComponentType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ChargeItem.ChargeItemStatus> value)
	{
		ChargeItem.ChargeItemStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FinancialResourceStatusCodes> value)
	{
		FinancialResourceStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ClinicalImpression.ClinicalImpressionStatus> value)
	{
		ClinicalImpression.ClinicalImpressionStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TerminologyCapabilities.CodeSearchSupport> value)
	{
		TerminologyCapabilities.CodeSearchSupport? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CodeSystemContentMode> value)
	{
		CodeSystemContentMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CodeSystem.CodeSystemHierarchyMeaning> value)
	{
		CodeSystem.CodeSystemHierarchyMeaning? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<RequestPriority> value)
	{
		RequestPriority? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<EventStatus> value)
	{
		EventStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CompartmentType> value)
	{
		CompartmentType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Composition.CompositionAttestationMode> value)
	{
		Composition.CompositionAttestationMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CompositionStatus> value)
	{
		CompositionStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ConceptMapEquivalence> value)
	{
		ConceptMapEquivalence? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
	{
		ConceptMap.ConceptMapGroupUnmappedMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.ConditionalDeleteStatus> value)
	{
		CapabilityStatement.ConditionalDeleteStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.ConditionalReadStatus> value)
	{
		CapabilityStatement.ConditionalReadStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Consent.ConsentDataMeaning> value)
	{
		Consent.ConsentDataMeaning? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Consent.ConsentProvisionType> value)
	{
		Consent.ConsentProvisionType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Consent.ConsentState> value)
	{
		Consent.ConsentState? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ConstraintSeverity> value)
	{
		ConstraintSeverity? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ContactPoint.ContactPointSystem> value)
	{
		ContactPoint.ContactPointSystem? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ContactPoint.ContactPointUse> value)
	{
		ContactPoint.ContactPointUse? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Contract.ContractResourcePublicationStatusCodes> value)
	{
		Contract.ContractResourcePublicationStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Contract.ContractResourceStatusCodes> value)
	{
		Contract.ContractResourceStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Contributor.ContributorType> value)
	{
		Contributor.ContributorType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Money.Currencies> value)
	{
		Money.Currencies? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DaysOfWeek> value)
	{
		DaysOfWeek? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DetectedIssue.DetectedIssueSeverity> value)
	{
		DetectedIssue.DetectedIssueSeverity? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ObservationStatus> value)
	{
		ObservationStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricCalibrationState> value)
	{
		DeviceMetric.DeviceMetricCalibrationState? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricCalibrationType> value)
	{
		DeviceMetric.DeviceMetricCalibrationType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricCategory> value)
	{
		DeviceMetric.DeviceMetricCategory? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricColor> value)
	{
		DeviceMetric.DeviceMetricColor? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceMetric.DeviceMetricOperationalStatus> value)
	{
		DeviceMetric.DeviceMetricOperationalStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceNameType> value)
	{
		DeviceNameType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DeviceUseStatement.DeviceUseStatementStatus> value)
	{
		DeviceUseStatement.DeviceUseStatementStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DiagnosticReport.DiagnosticReportStatus> value)
	{
		DiagnosticReport.DiagnosticReportStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.DiscriminatorType> value)
	{
		ElementDefinition.DiscriminatorType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Composition.V3ConfidentialityClassification> value)
	{
		Composition.V3ConfidentialityClassification? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.DocumentMode> value)
	{
		CapabilityStatement.DocumentMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DocumentReferenceStatus> value)
	{
		DocumentReferenceStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DocumentRelationshipType> value)
	{
		DocumentRelationshipType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
	{
		CoverageEligibilityRequest.EligibilityRequestPurpose? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
	{
		CoverageEligibilityResponse.EligibilityResponsePurpose? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Questionnaire.EnableWhenBehavior> value)
	{
		Questionnaire.EnableWhenBehavior? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Encounter.EncounterLocationStatus> value)
	{
		Encounter.EncounterLocationStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Encounter.EncounterStatus> value)
	{
		Encounter.EncounterStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Endpoint.EndpointStatus> value)
	{
		Endpoint.EndpointStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<EpisodeOfCare.EpisodeOfCareStatus> value)
	{
		EpisodeOfCare.EpisodeOfCareStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.EventCapabilityMode> value)
	{
		CapabilityStatement.EventCapabilityMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Timing.EventTiming> value)
	{
		Timing.EventTiming? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<VariableTypeCode> value)
	{
		VariableTypeCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ExampleScenario.ExampleScenarioActorType> value)
	{
		ExampleScenario.ExampleScenarioActorType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
	{
		ExplanationOfBenefit.ExplanationOfBenefitStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<EffectEvidenceSynthesis.ExposureStateCode> value)
	{
		EffectEvidenceSynthesis.ExposureStateCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureDefinition.ExtensionContextType> value)
	{
		StructureDefinition.ExtensionContextType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FHIRAllTypes> value)
	{
		FHIRAllTypes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FHIRDefinedType> value)
	{
		FHIRDefinedType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Device.FHIRDeviceStatus> value)
	{
		Device.FHIRDeviceStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ResourceType> value)
	{
		ResourceType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Substance.FHIRSubstanceStatus> value)
	{
		Substance.FHIRSubstanceStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FHIRVersion> value)
	{
		FHIRVersion? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FamilyMemberHistory.FamilyHistoryStatus> value)
	{
		FamilyMemberHistory.FamilyHistoryStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<FilterOperator> value)
	{
		FilterOperator? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Flag.FlagStatus> value)
	{
		Flag.FlagStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Goal.GoalLifecycleStatus> value)
	{
		Goal.GoalLifecycleStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<GraphDefinition.GraphCompartmentRule> value)
	{
		GraphDefinition.GraphCompartmentRule? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<GraphDefinition.GraphCompartmentUse> value)
	{
		GraphDefinition.GraphCompartmentUse? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<GroupMeasureCode> value)
	{
		GroupMeasureCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Group.GroupType> value)
	{
		Group.GroupType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<GuidanceResponse.GuidanceResponseStatus> value)
	{
		GuidanceResponse.GuidanceResponseStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImplementationGuide.GuidePageGeneration> value)
	{
		ImplementationGuide.GuidePageGeneration? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImplementationGuide.GuideParameterCode> value)
	{
		ImplementationGuide.GuideParameterCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Bundle.HTTPVerb> value)
	{
		Bundle.HTTPVerb? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Identifier.IdentifierUse> value)
	{
		Identifier.IdentifierUse? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Person.IdentityAssuranceLevel> value)
	{
		Person.IdentityAssuranceLevel? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImagingStudy.ImagingStudyStatus> value)
	{
		ImagingStudy.ImagingStudyStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
	{
		ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Immunization.ImmunizationStatusCodes> value)
	{
		Immunization.ImmunizationStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Invoice.InvoiceStatus> value)
	{
		Invoice.InvoiceStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<OperationOutcome.IssueSeverity> value)
	{
		OperationOutcome.IssueSeverity? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<OperationOutcome.IssueType> value)
	{
		OperationOutcome.IssueType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Patient.LinkType> value)
	{
		Patient.LinkType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Linkage.LinkageType> value)
	{
		Linkage.LinkageType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ListMode> value)
	{
		ListMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<List.ListStatus> value)
	{
		List.ListStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Location.LocationMode> value)
	{
		Location.LocationMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Location.LocationStatus> value)
	{
		Location.LocationStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MeasureReport.MeasureReportStatus> value)
	{
		MeasureReport.MeasureReportStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MeasureReport.MeasureReportType> value)
	{
		MeasureReport.MeasureReportType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
	{
		MedicationAdministration.MedicationAdministrationStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationDispense.MedicationDispenseStatusCodes> value)
	{
		MedicationDispense.MedicationDispenseStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
	{
		MedicationKnowledge.MedicationKnowledgeStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationRequest.MedicationRequestIntent> value)
	{
		MedicationRequest.MedicationRequestIntent? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationRequest.MedicationrequestStatus> value)
	{
		MedicationRequest.MedicationrequestStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MedicationStatement.MedicationStatusCodes> value)
	{
		MedicationStatement.MedicationStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Medication.MedicationStatusCodes> value)
	{
		Medication.MedicationStatusCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MessageDefinition.MessageSignificanceCategory> value)
	{
		MessageDefinition.MessageSignificanceCategory? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MessageheaderResponseRequest> value)
	{
		MessageheaderResponseRequest? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code value)
	{
		string a_ = value?.Value;

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<HumanName.NameUse> value)
	{
		HumanName.NameUse? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<NamingSystem.NamingSystemIdentifierType> value)
	{
		NamingSystem.NamingSystemIdentifierType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<NamingSystem.NamingSystemType> value)
	{
		NamingSystem.NamingSystemType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Narrative.NarrativeStatus> value)
	{
		Narrative.NarrativeStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<NoteType> value)
	{
		NoteType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<RequestIntent> value)
	{
		RequestIntent? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ObservationDefinition.ObservationDataType> value)
	{
		ObservationDefinition.ObservationDataType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ObservationDefinition.ObservationRangeCategory> value)
	{
		ObservationDefinition.ObservationRangeCategory? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<OperationDefinition.OperationKind> value)
	{
		OperationDefinition.OperationKind? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<OperationParameterUse> value)
	{
		OperationParameterUse? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.OrientationType> value)
	{
		MolecularSequence.OrientationType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Appointment.ParticipantRequired> value)
	{
		Appointment.ParticipantRequired? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ParticipationStatus> value)
	{
		ParticipationStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.PropertyRepresentation> value)
	{
		ElementDefinition.PropertyRepresentation? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CodeSystem.PropertyType> value)
	{
		CodeSystem.PropertyType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Provenance.ProvenanceEntityRole> value)
	{
		Provenance.ProvenanceEntityRole? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<PublicationStatus> value)
	{
		PublicationStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.QualityType> value)
	{
		MolecularSequence.QualityType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Quantity.QuantityComparator> value)
	{
		Quantity.QuantityComparator? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Questionnaire.QuestionnaireItemOperator> value)
	{
		Questionnaire.QuestionnaireItemOperator? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Questionnaire.QuestionnaireItemType> value)
	{
		Questionnaire.QuestionnaireItemType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
	{
		QuestionnaireResponse.QuestionnaireResponseStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.ReferenceHandlingPolicy> value)
	{
		CapabilityStatement.ReferenceHandlingPolicy? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.ReferenceVersionRules> value)
	{
		ElementDefinition.ReferenceVersionRules? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<RelatedArtifact.RelatedArtifactType> value)
	{
		RelatedArtifact.RelatedArtifactType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ClaimProcessingCodes> value)
	{
		ClaimProcessingCodes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.RepositoryType> value)
	{
		MolecularSequence.RepositoryType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ResearchElementDefinition.ResearchElementType> value)
	{
		ResearchElementDefinition.ResearchElementType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ResearchStudy.ResearchStudyStatus> value)
	{
		ResearchStudy.ResearchStudyStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ResearchSubject.ResearchSubjectStatus> value)
	{
		ResearchSubject.ResearchSubjectStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.ResourceVersionPolicy> value)
	{
		CapabilityStatement.ResourceVersionPolicy? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MessageHeader.ResponseType> value)
	{
		MessageHeader.ResponseType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.RestfulCapabilityMode> value)
	{
		CapabilityStatement.RestfulCapabilityMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ImplementationGuide.SPDXLicense> value)
	{
		ImplementationGuide.SPDXLicense? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SearchParameter.SearchComparator> value)
	{
		SearchParameter.SearchComparator? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Bundle.SearchEntryMode> value)
	{
		Bundle.SearchEntryMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SearchParameter.SearchModifierCode> value)
	{
		SearchParameter.SearchModifierCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SearchParamType> value)
	{
		SearchParamType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.SequenceType> value)
	{
		MolecularSequence.SequenceType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ElementDefinition.SlicingRules> value)
	{
		ElementDefinition.SlicingRules? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Slot.SlotStatus> value)
	{
		Slot.SlotStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<DataRequirement.SortDirection> value)
	{
		DataRequirement.SortDirection? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SpecimenDefinition.SpecimenContainedPreference> value)
	{
		SpecimenDefinition.SpecimenContainedPreference? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Specimen.SpecimenStatus> value)
	{
		Specimen.SpecimenStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<VerificationResult.StatusCode> value)
	{
		VerificationResult.StatusCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<MolecularSequence.StrandType> value)
	{
		MolecularSequence.StrandType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureDefinition.StructureDefinitionKind> value)
	{
		StructureDefinition.StructureDefinitionKind? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapContextType> value)
	{
		StructureMap.StructureMapContextType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapGroupTypeMode> value)
	{
		StructureMap.StructureMapGroupTypeMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapInputMode> value)
	{
		StructureMap.StructureMapInputMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapModelMode> value)
	{
		StructureMap.StructureMapModelMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapSourceListMode> value)
	{
		StructureMap.StructureMapSourceListMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapTargetListMode> value)
	{
		StructureMap.StructureMapTargetListMode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureMap.StructureMapTransform> value)
	{
		StructureMap.StructureMapTransform? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Subscription.SubscriptionChannelType> value)
	{
		Subscription.SubscriptionChannelType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Subscription.SubscriptionStatus> value)
	{
		Subscription.SubscriptionStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SupplyDelivery.SupplyDeliveryStatus> value)
	{
		SupplyDelivery.SupplyDeliveryStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SupplyRequest.SupplyRequestStatus> value)
	{
		SupplyRequest.SupplyRequestStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.SystemRestfulInteraction> value)
	{
		CapabilityStatement.SystemRestfulInteraction? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Task.TaskIntent> value)
	{
		Task.TaskIntent? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Task.TaskStatus> value)
	{
		Task.TaskStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestReport.TestReportActionResult> value)
	{
		TestReport.TestReportActionResult? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestReport.TestReportParticipantType> value)
	{
		TestReport.TestReportParticipantType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestReport.TestReportResult> value)
	{
		TestReport.TestReportResult? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestReport.TestReportStatus> value)
	{
		TestReport.TestReportStatus? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TestScript.TestScriptRequestMethodCode> value)
	{
		TestScript.TestScriptRequestMethodCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<TriggerDefinition.TriggerType> value)
	{
		TriggerDefinition.TriggerType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<StructureDefinition.TypeDerivationRule> value)
	{
		StructureDefinition.TypeDerivationRule? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<CapabilityStatement.TypeRestfulInteraction> value)
	{
		CapabilityStatement.TypeRestfulInteraction? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Device.UDIEntryType> value)
	{
		Device.UDIEntryType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<Timing.UnitsOfTime> value)
	{
		Timing.UnitsOfTime? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<ClaimUseCode> value)
	{
		ClaimUseCode? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<VisionPrescription.VisionBase> value)
	{
		VisionPrescription.VisionBase? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<VisionPrescription.VisionEyes> value)
	{
		VisionPrescription.VisionEyes? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Code<SearchParameter.XPathUsageType> value)
	{
		SearchParameter.XPathUsageType? a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(Base64Binary value)
	{
		byte[] a_ = value?.Value;
		string b_ = context.Operators.Convert<string>(a_);

		return b_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(FhirString value)
	{
		string a_ = value?.Value;

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(FhirUri value)
	{
		string a_ = value?.Value;

		return a_;
	}

    [CqlDeclaration("ToString")]
	public string ToString(XHtml value)
	{
		string a_ = value?.Value;

		return a_;
	}

    [CqlDeclaration("ToBoolean")]
	public bool? ToBoolean(FhirBoolean value)
	{
		bool? a_ = value?.Value;

		return a_;
	}

    [CqlDeclaration("ToDate")]
	public CqlDate ToDate(Date value)
	{
		string a_ = value?.Value;
		CqlDate b_ = context.Operators.ConvertStringToDate(a_);

		return b_;
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
		DateTimeOffset? a_ = value?.Value;
		CqlDateTime b_ = context.Operators.Convert<CqlDateTime>(a_);

		return b_;
	}

    [CqlDeclaration("ToDecimal")]
	public decimal? ToDecimal(FhirDecimal value)
	{
		decimal? a_ = value?.Value;

		return a_;
	}

    [CqlDeclaration("ToInteger")]
	public int? ToInteger(Integer value)
	{
		int? a_ = value?.Value;

		return a_;
	}

    [CqlDeclaration("ToTime")]
	public CqlTime ToTime(Time value)
	{
		string a_ = value?.Value;
		CqlTime b_ = context.Operators.ConvertStringToTime(a_);

		return b_;
	}

}

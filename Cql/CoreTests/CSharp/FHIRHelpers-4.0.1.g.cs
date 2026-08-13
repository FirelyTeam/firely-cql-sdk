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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.2.0")]
[CqlLibrary("FHIRHelpers", "4.0.1")]
public partial class FHIRHelpers_4_0_1 : ILibrary, ISingleton<FHIRHelpers_4_0_1>
{
    #region Functions and Expressions (233)

    [CqlFunctionDefinition("ToInterval")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, Period period)
    {
        if (period is null)
        {
            return null as CqlInterval<CqlDateTime>;
        }
        else if (period?.StartElement is null)
        {
            FhirDateTime a_ = period?.StartElement;
            CqlDateTime b_ = context.Operators.Convert<CqlDateTime>(a_);
            FhirDateTime c_ = period?.EndElement;
            CqlDateTime d_ = context.Operators.Convert<CqlDateTime>(c_);
            CqlInterval<CqlDateTime> e_ = context.Operators.Interval(b_, d_, false, true);
            return e_;
        }
        else
        {
            FhirDateTime f_ = period?.StartElement;
            CqlDateTime g_ = context.Operators.Convert<CqlDateTime>(f_);
            FhirDateTime h_ = period?.EndElement;
            CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
            CqlInterval<CqlDateTime> j_ = context.Operators.Interval(g_, i_, true, true);
            return j_;
        }
    }


    [CqlFunctionDefinition("ToInterval")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Quantity quantity)
    {
        if (quantity is null)
        {
            return null as CqlInterval<CqlQuantity>;
        }
        else
        {
            Code<Quantity.QuantityComparator> a_ = quantity?.ComparatorElement;
            Quantity.QuantityComparator? b_ = a_?.Value;
            string c_ = context.Operators.Convert<string>(b_);
            bool? d_ = context.Operators.Equal(c_, "<");
            if (d_ ?? false)
            {
                CqlQuantity e_ = this.ToQuantityIgnoringComparator(context, quantity);
                CqlInterval<CqlQuantity> f_ = context.Operators.Interval(default, e_, true, false);
                return f_;
            }
            else
            {
                Code<Quantity.QuantityComparator> g_ = quantity?.ComparatorElement;
                Quantity.QuantityComparator? h_ = g_?.Value;
                string i_ = context.Operators.Convert<string>(h_);
                bool? j_ = context.Operators.Equal(i_, "<=");
                if (j_ ?? false)
                {
                    CqlQuantity k_ = this.ToQuantityIgnoringComparator(context, quantity);
                    CqlInterval<CqlQuantity> l_ = context.Operators.Interval(default, k_, true, true);
                    return l_;
                }
                else
                {
                    Code<Quantity.QuantityComparator> m_ = quantity?.ComparatorElement;
                    Quantity.QuantityComparator? n_ = m_?.Value;
                    string o_ = context.Operators.Convert<string>(n_);
                    bool? p_ = context.Operators.Equal(o_, ">=");
                    if (p_ ?? false)
                    {
                        CqlQuantity q_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> r_ = context.Operators.Interval(q_, default, true, true);
                        return r_;
                    }
                    else
                    {
                        Code<Quantity.QuantityComparator> s_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? t_ = s_?.Value;
                        string u_ = context.Operators.Convert<string>(t_);
                        bool? v_ = context.Operators.Equal(u_, ">");
                        if (v_ ?? false)
                        {
                            CqlQuantity w_ = this.ToQuantityIgnoringComparator(context, quantity);
                            CqlInterval<CqlQuantity> x_ = context.Operators.Interval(w_, default, false, true);
                            return x_;
                        }
                        else
                        {
                            CqlQuantity y_ = this.ToQuantity(context, quantity);
                            CqlInterval<CqlQuantity> z_ = context.Operators.Interval(y_, y_, true, true);
                            return z_;
                        }
                    }
                }
            }
        }
    }


    [CqlFunctionDefinition("ToInterval")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Range range)
    {
        if (range is null)
        {
            return null as CqlInterval<CqlQuantity>;
        }
        else
        {
            Quantity a_ = range?.Low;
            CqlQuantity b_ = this.ToQuantity(context, a_);
            Quantity c_ = range?.High;
            CqlQuantity d_ = this.ToQuantity(context, c_);
            CqlInterval<CqlQuantity> e_ = context.Operators.Interval(b_, d_, true, true);
            return e_;
        }
    }


    [CqlFunctionDefinition("ToCalendarUnit")]
    public string ToCalendarUnit(CqlContext context, string unit)
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
    }


    [CqlFunctionDefinition("ToQuantity")]
    public CqlQuantity ToQuantity(CqlContext context, Quantity quantity)
    {
        if (quantity is null)
        {
            return default;
        }
        else if (quantity?.ValueElement is null)
        {
            return default;
        }
        else if ((!((bool?)(quantity?.ComparatorElement is null))) ?? false)
        {
            object a_ = context.Operators.Message<object>((object)null, "FHIRHelpers.ToQuantity.ComparatorQuantityNotSupported", "Error", "FHIR Quantity value has a comparator and cannot be converted to a System.Quantity value.");
            return a_ as CqlQuantity;
        }
        else
        {
            FhirUri b_ = quantity?.SystemElement;
            bool? c_ = (bool?)(b_ is null);
            bool? d_;
            // CQL 'or' (35:14-35:91): right operand skipped when left is true
            if (c_ is true)
            {
                d_ = true;
            }
            else
            {
                FhirUri f_ = quantity?.SystemElement;
                string g_ = f_?.Value;
                bool? h_ = context.Operators.Equal(g_, "http://unitsofmeasure.org");
                d_ = c_ | h_;
            }
            bool? e_;
            // CQL 'or' (35:14-36:92): right operand skipped when left is true
            if (d_ is true)
            {
                e_ = true;
            }
            else
            {
                FhirUri i_ = quantity?.SystemElement;
                string j_ = i_?.Value;
                bool? k_ = context.Operators.Equal(j_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
                e_ = d_ | k_;
            }
            if (e_ ?? false)
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
                object ae_ = context.Operators.Message<object>((object)null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", ad_);
                return ae_ as CqlQuantity;
            }
        }
    }


    [CqlFunctionDefinition("ToQuantityIgnoringComparator")]
    public CqlQuantity ToQuantityIgnoringComparator(CqlContext context, Quantity quantity)
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
            FhirUri a_ = quantity?.SystemElement;
            bool? b_ = (bool?)(a_ is null);
            bool? c_;
            // CQL 'or' (46:14-46:91): right operand skipped when left is true
            if (b_ is true)
            {
                c_ = true;
            }
            else
            {
                FhirUri e_ = quantity?.SystemElement;
                string f_ = e_?.Value;
                bool? g_ = context.Operators.Equal(f_, "http://unitsofmeasure.org");
                c_ = b_ | g_;
            }
            bool? d_;
            // CQL 'or' (46:14-47:92): right operand skipped when left is true
            if (c_ is true)
            {
                d_ = true;
            }
            else
            {
                FhirUri h_ = quantity?.SystemElement;
                string i_ = h_?.Value;
                bool? j_ = context.Operators.Equal(i_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
                d_ = c_ | j_;
            }
            if (d_ ?? false)
            {
                FhirDecimal k_ = quantity?.ValueElement;
                decimal? l_ = k_?.Value;
                Code m_ = quantity?.CodeElement;
                string n_ = m_?.Value;
                FhirString o_ = quantity?.UnitElement;
                string p_ = o_?.Value;
                string q_ = this.ToCalendarUnit(context, (n_ ?? p_) ?? "1");
                return new CqlQuantity(l_, q_);
            }
            else
            {
                FhirString r_ = quantity?.UnitElement;
                string s_ = r_?.Value;
                string t_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", s_ ?? "");
                string u_ = context.Operators.Concatenate(t_ ?? "", " (");
                FhirUri v_ = quantity?.SystemElement;
                string w_ = v_?.Value;
                string x_ = context.Operators.Concatenate(u_ ?? "", w_ ?? "");
                string y_ = context.Operators.Concatenate(x_ ?? "", "|");
                Code z_ = quantity?.CodeElement;
                string aa_ = z_?.Value;
                string ab_ = context.Operators.Concatenate(y_ ?? "", aa_ ?? "");
                string ac_ = context.Operators.Concatenate(ab_ ?? "", ")");
                object ad_ = context.Operators.Message<object>((object)null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", ac_);
                return ad_ as CqlQuantity;
            }
        }
    }


    [CqlFunctionDefinition("ToRatio")]
    public CqlRatio ToRatio(CqlContext context, Ratio ratio)
    {
        if (ratio is null)
        {
            return default;
        }
        else
        {
            Quantity a_ = ratio?.Numerator;
            CqlQuantity b_ = this.ToQuantity(context, a_);
            Quantity c_ = ratio?.Denominator;
            CqlQuantity d_ = this.ToQuantity(context, c_);
            return new CqlRatio(b_, d_);
        }
    }


    [CqlFunctionDefinition("ToCode")]
    public CqlCode ToCode(CqlContext context, Coding coding)
    {
        if (coding is null)
        {
            return default;
        }
        else
        {
            Code a_ = coding?.CodeElement;
            string b_ = a_?.Value;
            FhirUri c_ = coding?.SystemElement;
            string d_ = c_?.Value;
            FhirString e_ = coding?.VersionElement;
            string f_ = e_?.Value;
            FhirString g_ = coding?.DisplayElement;
            string h_ = g_?.Value;
            return new CqlCode(b_, d_, f_, h_);
        }
    }


    [CqlFunctionDefinition("ToConcept")]
    public CqlConcept ToConcept(CqlContext context, CodeableConcept concept)
    {
        if (concept is null)
        {
            return default;
        }
        else
        {
            List<Coding> a_ = concept?.Coding;

            CqlCode b_(Coding C) {
                CqlCode f_ = this.ToCode(context, C);
                return f_;
            }

            IEnumerable<CqlCode> c_ = context.Operators.SelectDistinct<Coding, CqlCode>((IEnumerable<Coding>)a_, b_);
            FhirString d_ = concept?.TextElement;
            string e_ = d_?.Value;
            return new CqlConcept(c_, e_);
        }
    }


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

    private FHIRHelpers_4_0_1() {}

    public static FHIRHelpers_4_0_1 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "FHIRHelpers";
    public string Version => "4.0.1";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

}

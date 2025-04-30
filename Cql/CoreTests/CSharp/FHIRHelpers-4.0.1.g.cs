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
[CqlLibrary("FHIRHelpers", "4.0.1")]
public partial class FHIRHelpers_4_0_1 : ILibrary, ISingleton<FHIRHelpers_4_0_1>
{
    private FHIRHelpers_4_0_1() {}

    public static FHIRHelpers_4_0_1 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FHIRHelpers";
    public string Version => "4.0.1";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

    #region Expressions

    [CqlExpressionDefinition("ToInterval")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, Period period)
    {
        CqlInterval<CqlDateTime> ah_()
        {
            if (period is null)
            {
                return null as CqlInterval<CqlDateTime>;
            }
            else if (period?.StartElement is null)
            {
                FhirDateTime ai_ = period?.StartElement;
                CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(ai_);
                FhirDateTime ak_ = period?.EndElement;
                CqlDateTime al_ = context.Operators.Convert<CqlDateTime>(ak_);
                CqlInterval<CqlDateTime> am_ = context.Operators.Interval(aj_, al_, false, true);

                return am_;
            }
            else
            {
                FhirDateTime an_ = period?.StartElement;
                CqlDateTime ao_ = context.Operators.Convert<CqlDateTime>(an_);
                FhirDateTime ap_ = period?.EndElement;
                CqlDateTime aq_ = context.Operators.Convert<CqlDateTime>(ap_);
                CqlInterval<CqlDateTime> ar_ = context.Operators.Interval(ao_, aq_, true, true);

                return ar_;
            }
        };

        return ah_();
    }


    [CqlExpressionDefinition("ToInterval")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Quantity quantity)
    {
        CqlInterval<CqlQuantity> as_()
        {
            if (quantity is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {
                CqlInterval<CqlQuantity> at_()
                {
                    bool au_()
                    {
                        Code<Quantity.QuantityComparator> ay_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? az_ = ay_?.Value;
                        string ba_ = context.Operators.Convert<string>(az_);
                        bool? bb_ = context.Operators.Equal(ba_, "<");

                        return bb_ ?? false;
                    };
                    bool av_()
                    {
                        Code<Quantity.QuantityComparator> bc_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? bd_ = bc_?.Value;
                        string be_ = context.Operators.Convert<string>(bd_);
                        bool? bf_ = context.Operators.Equal(be_, "<=");

                        return bf_ ?? false;
                    };
                    bool aw_()
                    {
                        Code<Quantity.QuantityComparator> bg_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? bh_ = bg_?.Value;
                        string bi_ = context.Operators.Convert<string>(bh_);
                        bool? bj_ = context.Operators.Equal(bi_, ">=");

                        return bj_ ?? false;
                    };
                    bool ax_()
                    {
                        Code<Quantity.QuantityComparator> bk_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? bl_ = bk_?.Value;
                        string bm_ = context.Operators.Convert<string>(bl_);
                        bool? bn_ = context.Operators.Equal(bm_, ">");

                        return bn_ ?? false;
                    };
                    if (au_())
                    {
                        CqlQuantity bo_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> bp_ = context.Operators.Interval(default, bo_, true, false);

                        return bp_;
                    }
                    else if (av_())
                    {
                        CqlQuantity bq_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> br_ = context.Operators.Interval(default, bq_, true, true);

                        return br_;
                    }
                    else if (aw_())
                    {
                        CqlQuantity bs_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> bt_ = context.Operators.Interval(bs_, default, true, true);

                        return bt_;
                    }
                    else if (ax_())
                    {
                        CqlQuantity bu_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> bv_ = context.Operators.Interval(bu_, default, false, true);

                        return bv_;
                    }
                    else
                    {
                        CqlQuantity bw_ = this.ToQuantity(context, quantity);
                        CqlInterval<CqlQuantity> by_ = context.Operators.Interval(bw_, bw_, true, true);

                        return by_;
                    }
                };

                return at_();
            }
        };

        return as_();
    }


    [CqlExpressionDefinition("ToInterval")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Range range)
    {
        CqlInterval<CqlQuantity> bz_()
        {
            if (range is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {
                Quantity ca_ = range?.Low;
                CqlQuantity cb_ = this.ToQuantity(context, ca_);
                Quantity cc_ = range?.High;
                CqlQuantity cd_ = this.ToQuantity(context, cc_);
                CqlInterval<CqlQuantity> ce_ = context.Operators.Interval(cb_, cd_, true, true);

                return ce_;
            }
        };

        return bz_();
    }


    [CqlExpressionDefinition("ToCalendarUnit")]
    public string ToCalendarUnit(CqlContext context, string unit)
    {
        string cf_()
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

        return cf_();
    }


    [CqlExpressionDefinition("ToQuantity")]
    public CqlQuantity ToQuantity(CqlContext context, Quantity quantity)
    {
        CqlQuantity cg_()
        {
            bool ch_()
            {
                Code<Quantity.QuantityComparator> cj_ = quantity?.ComparatorElement;
                bool? ck_ = context.Operators.Not((bool?)(cj_ is null));

                return ck_ ?? false;
            };
            bool ci_()
            {
                FhirUri cl_ = quantity?.SystemElement;
                string cn_ = cl_?.Value;
                bool? co_ = context.Operators.Equal(cn_, "http://unitsofmeasure.org");
                bool? cp_ = context.Operators.Or((bool?)(cl_ is null), co_);
                string cr_ = cl_?.Value;
                bool? cs_ = context.Operators.Equal(cr_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
                bool? ct_ = context.Operators.Or(cp_, cs_);

                return ct_ ?? false;
            };
            if (quantity is null)
            {
                return default;
            }
            else if (quantity?.ValueElement is null)
            {
                return default;
            }
            else if (ch_())
            {
                object cu_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.ComparatorQuantityNotSupported", "Error", "FHIR Quantity value has a comparator and cannot be converted to a System.Quantity value.");

                return cu_ as CqlQuantity;
            }
            else if (ci_())
            {
                FhirDecimal cv_ = quantity?.ValueElement;
                decimal? cw_ = cv_?.Value;
                Code cx_ = quantity?.CodeElement;
                string cy_ = cx_?.Value;
                FhirString cz_ = quantity?.UnitElement;
                string da_ = cz_?.Value;
                string db_ = this.ToCalendarUnit(context, (cy_ ?? da_) ?? "1");

                return new CqlQuantity(cw_, db_);
            }
            else
            {
                FhirString dc_ = quantity?.UnitElement;
                string dd_ = dc_?.Value;
                string de_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", dd_ ?? "");
                string df_ = context.Operators.Concatenate(de_ ?? "", " (");
                FhirUri dg_ = quantity?.SystemElement;
                string dh_ = dg_?.Value;
                string di_ = context.Operators.Concatenate(df_ ?? "", dh_ ?? "");
                string dj_ = context.Operators.Concatenate(di_ ?? "", "|");
                Code dk_ = quantity?.CodeElement;
                string dl_ = dk_?.Value;
                string dm_ = context.Operators.Concatenate(dj_ ?? "", dl_ ?? "");
                string dn_ = context.Operators.Concatenate(dm_ ?? "", ")");
                object do_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", dn_);

                return do_ as CqlQuantity;
            }
        };

        return cg_();
    }


    [CqlExpressionDefinition("ToQuantityIgnoringComparator")]
    public CqlQuantity ToQuantityIgnoringComparator(CqlContext context, Quantity quantity)
    {
        CqlQuantity dp_()
        {
            bool dq_()
            {
                FhirUri dr_ = quantity?.SystemElement;
                string dt_ = dr_?.Value;
                bool? du_ = context.Operators.Equal(dt_, "http://unitsofmeasure.org");
                bool? dv_ = context.Operators.Or((bool?)(dr_ is null), du_);
                string dx_ = dr_?.Value;
                bool? dy_ = context.Operators.Equal(dx_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
                bool? dz_ = context.Operators.Or(dv_, dy_);

                return dz_ ?? false;
            };
            if (quantity is null)
            {
                return default;
            }
            else if (quantity?.ValueElement is null)
            {
                return default;
            }
            else if (dq_())
            {
                FhirDecimal ea_ = quantity?.ValueElement;
                decimal? eb_ = ea_?.Value;
                Code ec_ = quantity?.CodeElement;
                string ed_ = ec_?.Value;
                FhirString ee_ = quantity?.UnitElement;
                string ef_ = ee_?.Value;
                string eg_ = this.ToCalendarUnit(context, (ed_ ?? ef_) ?? "1");

                return new CqlQuantity(eb_, eg_);
            }
            else
            {
                FhirString eh_ = quantity?.UnitElement;
                string ei_ = eh_?.Value;
                string ej_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", ei_ ?? "");
                string ek_ = context.Operators.Concatenate(ej_ ?? "", " (");
                FhirUri el_ = quantity?.SystemElement;
                string em_ = el_?.Value;
                string en_ = context.Operators.Concatenate(ek_ ?? "", em_ ?? "");
                string eo_ = context.Operators.Concatenate(en_ ?? "", "|");
                Code ep_ = quantity?.CodeElement;
                string eq_ = ep_?.Value;
                string er_ = context.Operators.Concatenate(eo_ ?? "", eq_ ?? "");
                string es_ = context.Operators.Concatenate(er_ ?? "", ")");
                object et_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", es_);

                return et_ as CqlQuantity;
            }
        };

        return dp_();
    }


    [CqlExpressionDefinition("ToRatio")]
    public CqlRatio ToRatio(CqlContext context, Ratio ratio)
    {
        CqlRatio eu_()
        {
            if (ratio is null)
            {
                return default;
            }
            else
            {
                Quantity ev_ = ratio?.Numerator;
                CqlQuantity ew_ = this.ToQuantity(context, ev_);
                Quantity ex_ = ratio?.Denominator;
                CqlQuantity ey_ = this.ToQuantity(context, ex_);

                return new CqlRatio(ew_, ey_);
            }
        };

        return eu_();
    }


    [CqlExpressionDefinition("ToCode")]
    public CqlCode ToCode(CqlContext context, Coding coding)
    {
        CqlCode ez_()
        {
            if (coding is null)
            {
                return default;
            }
            else
            {
                Code fa_ = coding?.CodeElement;
                string fb_ = fa_?.Value;
                FhirUri fc_ = coding?.SystemElement;
                string fd_ = fc_?.Value;
                FhirString fe_ = coding?.VersionElement;
                string ff_ = fe_?.Value;
                FhirString fg_ = coding?.DisplayElement;
                string fh_ = fg_?.Value;

                return new CqlCode(fb_, fd_, ff_, fh_);
            }
        };

        return ez_();
    }


    [CqlExpressionDefinition("ToConcept")]
    public CqlConcept ToConcept(CqlContext context, CodeableConcept concept)
    {
        CqlConcept fi_()
        {
            if (concept is null)
            {
                return default;
            }
            else
            {
                List<Coding> fj_ = concept?.Coding;
                CqlCode fk_(Coding C)
                {
                    CqlCode fp_ = this.ToCode(context, C);

                    return fp_;
                };
                IEnumerable<CqlCode> fl_ = context.Operators.Select<Coding, CqlCode>((IEnumerable<Coding>)fj_, fk_);
                IEnumerable<CqlCode> fm_ = context.Operators.Distinct<CqlCode>(fl_);
                FhirString fn_ = concept?.TextElement;
                string fo_ = fn_?.Value;

                return new CqlConcept(fm_, fo_);
            }
        };

        return fi_();
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Account.AccountStatus> value)
    {
        Account.AccountStatus? fq_ = value?.Value;
        string fr_ = context.Operators.Convert<string>(fq_);

        return fr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionCardinalityBehavior> value)
    {
        ActionCardinalityBehavior? fs_ = value?.Value;
        string ft_ = context.Operators.Convert<string>(fs_);

        return ft_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionConditionKind> value)
    {
        ActionConditionKind? fu_ = value?.Value;
        string fv_ = context.Operators.Convert<string>(fu_);

        return fv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionGroupingBehavior> value)
    {
        ActionGroupingBehavior? fw_ = value?.Value;
        string fx_ = context.Operators.Convert<string>(fw_);

        return fx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionParticipantType> value)
    {
        ActionParticipantType? fy_ = value?.Value;
        string fz_ = context.Operators.Convert<string>(fy_);

        return fz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionPrecheckBehavior> value)
    {
        ActionPrecheckBehavior? ga_ = value?.Value;
        string gb_ = context.Operators.Convert<string>(ga_);

        return gb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionRelationshipType> value)
    {
        ActionRelationshipType? gc_ = value?.Value;
        string gd_ = context.Operators.Convert<string>(gc_);

        return gd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionRequiredBehavior> value)
    {
        ActionRequiredBehavior? ge_ = value?.Value;
        string gf_ = context.Operators.Convert<string>(ge_);

        return gf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionSelectionBehavior> value)
    {
        ActionSelectionBehavior? gg_ = value?.Value;
        string gh_ = context.Operators.Convert<string>(gg_);

        return gh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActivityDefinition.RequestResourceType> value)
    {
        ActivityDefinition.RequestResourceType? gi_ = value?.Value;
        string gj_ = context.Operators.Convert<string>(gi_);

        return gj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Address.AddressType> value)
    {
        Address.AddressType? gk_ = value?.Value;
        string gl_ = context.Operators.Convert<string>(gk_);

        return gl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Address.AddressUse> value)
    {
        Address.AddressUse? gm_ = value?.Value;
        string gn_ = context.Operators.Convert<string>(gm_);

        return gn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AdministrativeGender> value)
    {
        AdministrativeGender? go_ = value?.Value;
        string gp_ = context.Operators.Convert<string>(go_);

        return gp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AdverseEvent.AdverseEventActuality> value)
    {
        AdverseEvent.AdverseEventActuality? gq_ = value?.Value;
        string gr_ = context.Operators.Convert<string>(gq_);

        return gr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.AggregationMode> value)
    {
        ElementDefinition.AggregationMode? gs_ = value?.Value;
        string gt_ = context.Operators.Convert<string>(gs_);

        return gt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
    {
        AllergyIntolerance.AllergyIntoleranceCategory? gu_ = value?.Value;
        string gv_ = context.Operators.Convert<string>(gu_);

        return gv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
    {
        AllergyIntolerance.AllergyIntoleranceCriticality? gw_ = value?.Value;
        string gx_ = context.Operators.Convert<string>(gw_);

        return gx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
    {
        AllergyIntolerance.AllergyIntoleranceSeverity? gy_ = value?.Value;
        string gz_ = context.Operators.Convert<string>(gy_);

        return gz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceType> value)
    {
        AllergyIntolerance.AllergyIntoleranceType? ha_ = value?.Value;
        string hb_ = context.Operators.Convert<string>(ha_);

        return hb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Appointment.AppointmentStatus> value)
    {
        Appointment.AppointmentStatus? hc_ = value?.Value;
        string hd_ = context.Operators.Convert<string>(hc_);

        return hd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionDirectionType> value)
    {
        TestScript.AssertionDirectionType? he_ = value?.Value;
        string hf_ = context.Operators.Convert<string>(he_);

        return hf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionOperatorType> value)
    {
        TestScript.AssertionOperatorType? hg_ = value?.Value;
        string hh_ = context.Operators.Convert<string>(hg_);

        return hh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionResponseTypes> value)
    {
        TestScript.AssertionResponseTypes? hi_ = value?.Value;
        string hj_ = context.Operators.Convert<string>(hi_);

        return hj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAction> value)
    {
        AuditEvent.AuditEventAction? hk_ = value?.Value;
        string hl_ = context.Operators.Convert<string>(hk_);

        return hl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAgentNetworkType> value)
    {
        AuditEvent.AuditEventAgentNetworkType? hm_ = value?.Value;
        string hn_ = context.Operators.Convert<string>(hm_);

        return hn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventOutcome> value)
    {
        AuditEvent.AuditEventOutcome? ho_ = value?.Value;
        string hp_ = context.Operators.Convert<string>(ho_);

        return hp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BindingStrength> value)
    {
        BindingStrength? hq_ = value?.Value;
        string hr_ = context.Operators.Convert<string>(hq_);

        return hr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? hs_ = value?.Value;
        string ht_ = context.Operators.Convert<string>(hs_);

        return ht_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? hu_ = value?.Value;
        string hv_ = context.Operators.Convert<string>(hu_);

        return hv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? hw_ = value?.Value;
        string hx_ = context.Operators.Convert<string>(hw_);

        return hx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.BundleType> value)
    {
        Bundle.BundleType? hy_ = value?.Value;
        string hz_ = context.Operators.Convert<string>(hy_);

        return hz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatementKind> value)
    {
        CapabilityStatementKind? ia_ = value?.Value;
        string ib_ = context.Operators.Convert<string>(ia_);

        return ib_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityKind> value)
    {
        CarePlan.CarePlanActivityKind? ic_ = value?.Value;
        string id_ = context.Operators.Convert<string>(ic_);

        return id_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityStatus> value)
    {
        CarePlan.CarePlanActivityStatus? ie_ = value?.Value;
        string if_ = context.Operators.Convert<string>(ie_);

        return if_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanIntent> value)
    {
        CarePlan.CarePlanIntent? ig_ = value?.Value;
        string ih_ = context.Operators.Convert<string>(ig_);

        return ih_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestStatus> value)
    {
        RequestStatus? ii_ = value?.Value;
        string ij_ = context.Operators.Convert<string>(ii_);

        return ij_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CareTeam.CareTeamStatus> value)
    {
        CareTeam.CareTeamStatus? ik_ = value?.Value;
        string il_ = context.Operators.Convert<string>(ik_);

        return il_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CatalogEntry.CatalogEntryRelationType> value)
    {
        CatalogEntry.CatalogEntryRelationType? im_ = value?.Value;
        string in_ = context.Operators.Convert<string>(im_);

        return in_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<InvoicePriceComponentType> value)
    {
        InvoicePriceComponentType? io_ = value?.Value;
        string ip_ = context.Operators.Convert<string>(io_);

        return ip_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ChargeItem.ChargeItemStatus> value)
    {
        ChargeItem.ChargeItemStatus? iq_ = value?.Value;
        string ir_ = context.Operators.Convert<string>(iq_);

        return ir_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FinancialResourceStatusCodes> value)
    {
        FinancialResourceStatusCodes? is_ = value?.Value;
        string it_ = context.Operators.Convert<string>(is_);

        return it_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClinicalImpression.ClinicalImpressionStatus> value)
    {
        ClinicalImpression.ClinicalImpressionStatus? iu_ = value?.Value;
        string iv_ = context.Operators.Convert<string>(iu_);

        return iv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TerminologyCapabilities.CodeSearchSupport> value)
    {
        TerminologyCapabilities.CodeSearchSupport? iw_ = value?.Value;
        string ix_ = context.Operators.Convert<string>(iw_);

        return ix_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystemContentMode> value)
    {
        CodeSystemContentMode? iy_ = value?.Value;
        string iz_ = context.Operators.Convert<string>(iy_);

        return iz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystem.CodeSystemHierarchyMeaning> value)
    {
        CodeSystem.CodeSystemHierarchyMeaning? ja_ = value?.Value;
        string jb_ = context.Operators.Convert<string>(ja_);

        return jb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestPriority> value)
    {
        RequestPriority? jc_ = value?.Value;
        string jd_ = context.Operators.Convert<string>(jc_);

        return jd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EventStatus> value)
    {
        EventStatus? je_ = value?.Value;
        string jf_ = context.Operators.Convert<string>(je_);

        return jf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CompartmentType> value)
    {
        CompartmentType? jg_ = value?.Value;
        string jh_ = context.Operators.Convert<string>(jg_);

        return jh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Composition.CompositionAttestationMode> value)
    {
        Composition.CompositionAttestationMode? ji_ = value?.Value;
        string jj_ = context.Operators.Convert<string>(ji_);

        return jj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CompositionStatus> value)
    {
        CompositionStatus? jk_ = value?.Value;
        string jl_ = context.Operators.Convert<string>(jk_);

        return jl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConceptMapEquivalence> value)
    {
        ConceptMapEquivalence? jm_ = value?.Value;
        string jn_ = context.Operators.Convert<string>(jm_);

        return jn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
    {
        ConceptMap.ConceptMapGroupUnmappedMode? jo_ = value?.Value;
        string jp_ = context.Operators.Convert<string>(jo_);

        return jp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalDeleteStatus> value)
    {
        CapabilityStatement.ConditionalDeleteStatus? jq_ = value?.Value;
        string jr_ = context.Operators.Convert<string>(jq_);

        return jr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalReadStatus> value)
    {
        CapabilityStatement.ConditionalReadStatus? js_ = value?.Value;
        string jt_ = context.Operators.Convert<string>(js_);

        return jt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentDataMeaning> value)
    {
        Consent.ConsentDataMeaning? ju_ = value?.Value;
        string jv_ = context.Operators.Convert<string>(ju_);

        return jv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentProvisionType> value)
    {
        Consent.ConsentProvisionType? jw_ = value?.Value;
        string jx_ = context.Operators.Convert<string>(jw_);

        return jx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentState> value)
    {
        Consent.ConsentState? jy_ = value?.Value;
        string jz_ = context.Operators.Convert<string>(jy_);

        return jz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConstraintSeverity> value)
    {
        ConstraintSeverity? ka_ = value?.Value;
        string kb_ = context.Operators.Convert<string>(ka_);

        return kb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointSystem> value)
    {
        ContactPoint.ContactPointSystem? kc_ = value?.Value;
        string kd_ = context.Operators.Convert<string>(kc_);

        return kd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointUse> value)
    {
        ContactPoint.ContactPointUse? ke_ = value?.Value;
        string kf_ = context.Operators.Convert<string>(ke_);

        return kf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contract.ContractResourcePublicationStatusCodes> value)
    {
        Contract.ContractResourcePublicationStatusCodes? kg_ = value?.Value;
        string kh_ = context.Operators.Convert<string>(kg_);

        return kh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contract.ContractResourceStatusCodes> value)
    {
        Contract.ContractResourceStatusCodes? ki_ = value?.Value;
        string kj_ = context.Operators.Convert<string>(ki_);

        return kj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contributor.ContributorType> value)
    {
        Contributor.ContributorType? kk_ = value?.Value;
        string kl_ = context.Operators.Convert<string>(kk_);

        return kl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Money.Currencies> value)
    {
        Money.Currencies? km_ = value?.Value;
        string kn_ = context.Operators.Convert<string>(km_);

        return kn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DaysOfWeek> value)
    {
        DaysOfWeek? ko_ = value?.Value;
        string kp_ = context.Operators.Convert<string>(ko_);

        return kp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DetectedIssue.DetectedIssueSeverity> value)
    {
        DetectedIssue.DetectedIssueSeverity? kq_ = value?.Value;
        string kr_ = context.Operators.Convert<string>(kq_);

        return kr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationStatus> value)
    {
        ObservationStatus? ks_ = value?.Value;
        string kt_ = context.Operators.Convert<string>(ks_);

        return kt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationState> value)
    {
        DeviceMetric.DeviceMetricCalibrationState? ku_ = value?.Value;
        string kv_ = context.Operators.Convert<string>(ku_);

        return kv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationType> value)
    {
        DeviceMetric.DeviceMetricCalibrationType? kw_ = value?.Value;
        string kx_ = context.Operators.Convert<string>(kw_);

        return kx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCategory> value)
    {
        DeviceMetric.DeviceMetricCategory? ky_ = value?.Value;
        string kz_ = context.Operators.Convert<string>(ky_);

        return kz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricColor> value)
    {
        DeviceMetric.DeviceMetricColor? la_ = value?.Value;
        string lb_ = context.Operators.Convert<string>(la_);

        return lb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricOperationalStatus> value)
    {
        DeviceMetric.DeviceMetricOperationalStatus? lc_ = value?.Value;
        string ld_ = context.Operators.Convert<string>(lc_);

        return ld_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceNameType> value)
    {
        DeviceNameType? le_ = value?.Value;
        string lf_ = context.Operators.Convert<string>(le_);

        return lf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceUseStatement.DeviceUseStatementStatus> value)
    {
        DeviceUseStatement.DeviceUseStatementStatus? lg_ = value?.Value;
        string lh_ = context.Operators.Convert<string>(lg_);

        return lh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DiagnosticReport.DiagnosticReportStatus> value)
    {
        DiagnosticReport.DiagnosticReportStatus? li_ = value?.Value;
        string lj_ = context.Operators.Convert<string>(li_);

        return lj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.DiscriminatorType> value)
    {
        ElementDefinition.DiscriminatorType? lk_ = value?.Value;
        string ll_ = context.Operators.Convert<string>(lk_);

        return ll_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Composition.V3ConfidentialityClassification> value)
    {
        Composition.V3ConfidentialityClassification? lm_ = value?.Value;
        string ln_ = context.Operators.Convert<string>(lm_);

        return ln_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.DocumentMode> value)
    {
        CapabilityStatement.DocumentMode? lo_ = value?.Value;
        string lp_ = context.Operators.Convert<string>(lo_);

        return lp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DocumentReferenceStatus> value)
    {
        DocumentReferenceStatus? lq_ = value?.Value;
        string lr_ = context.Operators.Convert<string>(lq_);

        return lr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DocumentRelationshipType> value)
    {
        DocumentRelationshipType? ls_ = value?.Value;
        string lt_ = context.Operators.Convert<string>(ls_);

        return lt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
    {
        CoverageEligibilityRequest.EligibilityRequestPurpose? lu_ = value?.Value;
        string lv_ = context.Operators.Convert<string>(lu_);

        return lv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
    {
        CoverageEligibilityResponse.EligibilityResponsePurpose? lw_ = value?.Value;
        string lx_ = context.Operators.Convert<string>(lw_);

        return lx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.EnableWhenBehavior> value)
    {
        Questionnaire.EnableWhenBehavior? ly_ = value?.Value;
        string lz_ = context.Operators.Convert<string>(ly_);

        return lz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Encounter.EncounterLocationStatus> value)
    {
        Encounter.EncounterLocationStatus? ma_ = value?.Value;
        string mb_ = context.Operators.Convert<string>(ma_);

        return mb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Encounter.EncounterStatus> value)
    {
        Encounter.EncounterStatus? mc_ = value?.Value;
        string md_ = context.Operators.Convert<string>(mc_);

        return md_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Endpoint.EndpointStatus> value)
    {
        Endpoint.EndpointStatus? me_ = value?.Value;
        string mf_ = context.Operators.Convert<string>(me_);

        return mf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EpisodeOfCare.EpisodeOfCareStatus> value)
    {
        EpisodeOfCare.EpisodeOfCareStatus? mg_ = value?.Value;
        string mh_ = context.Operators.Convert<string>(mg_);

        return mh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.EventCapabilityMode> value)
    {
        CapabilityStatement.EventCapabilityMode? mi_ = value?.Value;
        string mj_ = context.Operators.Convert<string>(mi_);

        return mj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Timing.EventTiming> value)
    {
        Timing.EventTiming? mk_ = value?.Value;
        string ml_ = context.Operators.Convert<string>(mk_);

        return ml_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VariableTypeCode> value)
    {
        VariableTypeCode? mm_ = value?.Value;
        string mn_ = context.Operators.Convert<string>(mm_);

        return mn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ExampleScenario.ExampleScenarioActorType> value)
    {
        ExampleScenario.ExampleScenarioActorType? mo_ = value?.Value;
        string mp_ = context.Operators.Convert<string>(mo_);

        return mp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
    {
        ExplanationOfBenefit.ExplanationOfBenefitStatus? mq_ = value?.Value;
        string mr_ = context.Operators.Convert<string>(mq_);

        return mr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EffectEvidenceSynthesis.ExposureStateCode> value)
    {
        EffectEvidenceSynthesis.ExposureStateCode? ms_ = value?.Value;
        string mt_ = context.Operators.Convert<string>(ms_);

        return mt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.ExtensionContextType> value)
    {
        StructureDefinition.ExtensionContextType? mu_ = value?.Value;
        string mv_ = context.Operators.Convert<string>(mu_);

        return mv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRAllTypes> value)
    {
        FHIRAllTypes? mw_ = value?.Value;
        string mx_ = context.Operators.Convert<string>(mw_);

        return mx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRDefinedType> value)
    {
        FHIRDefinedType? my_ = value?.Value;
        string mz_ = context.Operators.Convert<string>(my_);

        return mz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Device.FHIRDeviceStatus> value)
    {
        Device.FHIRDeviceStatus? na_ = value?.Value;
        string nb_ = context.Operators.Convert<string>(na_);

        return nb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResourceType> value)
    {
        ResourceType? nc_ = value?.Value;
        string nd_ = context.Operators.Convert<string>(nc_);

        return nd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Substance.FHIRSubstanceStatus> value)
    {
        Substance.FHIRSubstanceStatus? ne_ = value?.Value;
        string nf_ = context.Operators.Convert<string>(ne_);

        return nf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRVersion> value)
    {
        FHIRVersion? ng_ = value?.Value;
        string nh_ = context.Operators.Convert<string>(ng_);

        return nh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FamilyMemberHistory.FamilyHistoryStatus> value)
    {
        FamilyMemberHistory.FamilyHistoryStatus? ni_ = value?.Value;
        string nj_ = context.Operators.Convert<string>(ni_);

        return nj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FilterOperator> value)
    {
        FilterOperator? nk_ = value?.Value;
        string nl_ = context.Operators.Convert<string>(nk_);

        return nl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Flag.FlagStatus> value)
    {
        Flag.FlagStatus? nm_ = value?.Value;
        string nn_ = context.Operators.Convert<string>(nm_);

        return nn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Goal.GoalLifecycleStatus> value)
    {
        Goal.GoalLifecycleStatus? no_ = value?.Value;
        string np_ = context.Operators.Convert<string>(no_);

        return np_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentRule> value)
    {
        GraphDefinition.GraphCompartmentRule? nq_ = value?.Value;
        string nr_ = context.Operators.Convert<string>(nq_);

        return nr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentUse> value)
    {
        GraphDefinition.GraphCompartmentUse? ns_ = value?.Value;
        string nt_ = context.Operators.Convert<string>(ns_);

        return nt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GroupMeasureCode> value)
    {
        GroupMeasureCode? nu_ = value?.Value;
        string nv_ = context.Operators.Convert<string>(nu_);

        return nv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Group.GroupType> value)
    {
        Group.GroupType? nw_ = value?.Value;
        string nx_ = context.Operators.Convert<string>(nw_);

        return nx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GuidanceResponse.GuidanceResponseStatus> value)
    {
        GuidanceResponse.GuidanceResponseStatus? ny_ = value?.Value;
        string nz_ = context.Operators.Convert<string>(ny_);

        return nz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.GuidePageGeneration> value)
    {
        ImplementationGuide.GuidePageGeneration? oa_ = value?.Value;
        string ob_ = context.Operators.Convert<string>(oa_);

        return ob_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.GuideParameterCode> value)
    {
        ImplementationGuide.GuideParameterCode? oc_ = value?.Value;
        string od_ = context.Operators.Convert<string>(oc_);

        return od_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.HTTPVerb> value)
    {
        Bundle.HTTPVerb? oe_ = value?.Value;
        string of_ = context.Operators.Convert<string>(oe_);

        return of_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Identifier.IdentifierUse> value)
    {
        Identifier.IdentifierUse? og_ = value?.Value;
        string oh_ = context.Operators.Convert<string>(og_);

        return oh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Person.IdentityAssuranceLevel> value)
    {
        Person.IdentityAssuranceLevel? oi_ = value?.Value;
        string oj_ = context.Operators.Convert<string>(oi_);

        return oj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImagingStudy.ImagingStudyStatus> value)
    {
        ImagingStudy.ImagingStudyStatus? ok_ = value?.Value;
        string ol_ = context.Operators.Convert<string>(ok_);

        return ol_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
    {
        ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? om_ = value?.Value;
        string on_ = context.Operators.Convert<string>(om_);

        return on_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Immunization.ImmunizationStatusCodes> value)
    {
        Immunization.ImmunizationStatusCodes? oo_ = value?.Value;
        string op_ = context.Operators.Convert<string>(oo_);

        return op_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Invoice.InvoiceStatus> value)
    {
        Invoice.InvoiceStatus? oq_ = value?.Value;
        string or_ = context.Operators.Convert<string>(oq_);

        return or_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationOutcome.IssueSeverity> value)
    {
        OperationOutcome.IssueSeverity? os_ = value?.Value;
        string ot_ = context.Operators.Convert<string>(os_);

        return ot_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationOutcome.IssueType> value)
    {
        OperationOutcome.IssueType? ou_ = value?.Value;
        string ov_ = context.Operators.Convert<string>(ou_);

        return ov_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Patient.LinkType> value)
    {
        Patient.LinkType? ow_ = value?.Value;
        string ox_ = context.Operators.Convert<string>(ow_);

        return ox_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Linkage.LinkageType> value)
    {
        Linkage.LinkageType? oy_ = value?.Value;
        string oz_ = context.Operators.Convert<string>(oy_);

        return oz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ListMode> value)
    {
        ListMode? pa_ = value?.Value;
        string pb_ = context.Operators.Convert<string>(pa_);

        return pb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<List.ListStatus> value)
    {
        List.ListStatus? pc_ = value?.Value;
        string pd_ = context.Operators.Convert<string>(pc_);

        return pd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Location.LocationMode> value)
    {
        Location.LocationMode? pe_ = value?.Value;
        string pf_ = context.Operators.Convert<string>(pe_);

        return pf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Location.LocationStatus> value)
    {
        Location.LocationStatus? pg_ = value?.Value;
        string ph_ = context.Operators.Convert<string>(pg_);

        return ph_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportStatus> value)
    {
        MeasureReport.MeasureReportStatus? pi_ = value?.Value;
        string pj_ = context.Operators.Convert<string>(pi_);

        return pj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportType> value)
    {
        MeasureReport.MeasureReportType? pk_ = value?.Value;
        string pl_ = context.Operators.Convert<string>(pk_);

        return pl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
    {
        MedicationAdministration.MedicationAdministrationStatusCodes? pm_ = value?.Value;
        string pn_ = context.Operators.Convert<string>(pm_);

        return pn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationDispense.MedicationDispenseStatusCodes> value)
    {
        MedicationDispense.MedicationDispenseStatusCodes? po_ = value?.Value;
        string pp_ = context.Operators.Convert<string>(po_);

        return pp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
    {
        MedicationKnowledge.MedicationKnowledgeStatusCodes? pq_ = value?.Value;
        string pr_ = context.Operators.Convert<string>(pq_);

        return pr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationRequestIntent> value)
    {
        MedicationRequest.MedicationRequestIntent? ps_ = value?.Value;
        string pt_ = context.Operators.Convert<string>(ps_);

        return pt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationrequestStatus> value)
    {
        MedicationRequest.MedicationrequestStatus? pu_ = value?.Value;
        string pv_ = context.Operators.Convert<string>(pu_);

        return pv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationStatement.MedicationStatusCodes> value)
    {
        MedicationStatement.MedicationStatusCodes? pw_ = value?.Value;
        string px_ = context.Operators.Convert<string>(pw_);

        return px_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Medication.MedicationStatusCodes> value)
    {
        Medication.MedicationStatusCodes? py_ = value?.Value;
        string pz_ = context.Operators.Convert<string>(py_);

        return pz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageDefinition.MessageSignificanceCategory> value)
    {
        MessageDefinition.MessageSignificanceCategory? qa_ = value?.Value;
        string qb_ = context.Operators.Convert<string>(qa_);

        return qb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageheaderResponseRequest> value)
    {
        MessageheaderResponseRequest? qc_ = value?.Value;
        string qd_ = context.Operators.Convert<string>(qc_);

        return qd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code value)
    {
        string qe_ = value?.Value;

        return qe_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<HumanName.NameUse> value)
    {
        HumanName.NameUse? qf_ = value?.Value;
        string qg_ = context.Operators.Convert<string>(qf_);

        return qg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemIdentifierType> value)
    {
        NamingSystem.NamingSystemIdentifierType? qh_ = value?.Value;
        string qi_ = context.Operators.Convert<string>(qh_);

        return qi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemType> value)
    {
        NamingSystem.NamingSystemType? qj_ = value?.Value;
        string qk_ = context.Operators.Convert<string>(qj_);

        return qk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Narrative.NarrativeStatus> value)
    {
        Narrative.NarrativeStatus? ql_ = value?.Value;
        string qm_ = context.Operators.Convert<string>(ql_);

        return qm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NoteType> value)
    {
        NoteType? qn_ = value?.Value;
        string qo_ = context.Operators.Convert<string>(qn_);

        return qo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestIntent> value)
    {
        RequestIntent? qp_ = value?.Value;
        string qq_ = context.Operators.Convert<string>(qp_);

        return qq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationDataType> value)
    {
        ObservationDefinition.ObservationDataType? qr_ = value?.Value;
        string qs_ = context.Operators.Convert<string>(qr_);

        return qs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationRangeCategory> value)
    {
        ObservationDefinition.ObservationRangeCategory? qt_ = value?.Value;
        string qu_ = context.Operators.Convert<string>(qt_);

        return qu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationDefinition.OperationKind> value)
    {
        OperationDefinition.OperationKind? qv_ = value?.Value;
        string qw_ = context.Operators.Convert<string>(qv_);

        return qw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationParameterUse> value)
    {
        OperationParameterUse? qx_ = value?.Value;
        string qy_ = context.Operators.Convert<string>(qx_);

        return qy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.OrientationType> value)
    {
        MolecularSequence.OrientationType? qz_ = value?.Value;
        string ra_ = context.Operators.Convert<string>(qz_);

        return ra_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Appointment.ParticipantRequired> value)
    {
        Appointment.ParticipantRequired? rb_ = value?.Value;
        string rc_ = context.Operators.Convert<string>(rb_);

        return rc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ParticipationStatus> value)
    {
        ParticipationStatus? rd_ = value?.Value;
        string re_ = context.Operators.Convert<string>(rd_);

        return re_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.PropertyRepresentation> value)
    {
        ElementDefinition.PropertyRepresentation? rf_ = value?.Value;
        string rg_ = context.Operators.Convert<string>(rf_);

        return rg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystem.PropertyType> value)
    {
        CodeSystem.PropertyType? rh_ = value?.Value;
        string ri_ = context.Operators.Convert<string>(rh_);

        return ri_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Provenance.ProvenanceEntityRole> value)
    {
        Provenance.ProvenanceEntityRole? rj_ = value?.Value;
        string rk_ = context.Operators.Convert<string>(rj_);

        return rk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<PublicationStatus> value)
    {
        PublicationStatus? rl_ = value?.Value;
        string rm_ = context.Operators.Convert<string>(rl_);

        return rm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.QualityType> value)
    {
        MolecularSequence.QualityType? rn_ = value?.Value;
        string ro_ = context.Operators.Convert<string>(rn_);

        return ro_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Quantity.QuantityComparator> value)
    {
        Quantity.QuantityComparator? rp_ = value?.Value;
        string rq_ = context.Operators.Convert<string>(rp_);

        return rq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemOperator> value)
    {
        Questionnaire.QuestionnaireItemOperator? rr_ = value?.Value;
        string rs_ = context.Operators.Convert<string>(rr_);

        return rs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemType> value)
    {
        Questionnaire.QuestionnaireItemType? rt_ = value?.Value;
        string ru_ = context.Operators.Convert<string>(rt_);

        return ru_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
    {
        QuestionnaireResponse.QuestionnaireResponseStatus? rv_ = value?.Value;
        string rw_ = context.Operators.Convert<string>(rv_);

        return rw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ReferenceHandlingPolicy> value)
    {
        CapabilityStatement.ReferenceHandlingPolicy? rx_ = value?.Value;
        string ry_ = context.Operators.Convert<string>(rx_);

        return ry_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.ReferenceVersionRules> value)
    {
        ElementDefinition.ReferenceVersionRules? rz_ = value?.Value;
        string sa_ = context.Operators.Convert<string>(rz_);

        return sa_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RelatedArtifact.RelatedArtifactType> value)
    {
        RelatedArtifact.RelatedArtifactType? sb_ = value?.Value;
        string sc_ = context.Operators.Convert<string>(sb_);

        return sc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClaimProcessingCodes> value)
    {
        ClaimProcessingCodes? sd_ = value?.Value;
        string se_ = context.Operators.Convert<string>(sd_);

        return se_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.RepositoryType> value)
    {
        MolecularSequence.RepositoryType? sf_ = value?.Value;
        string sg_ = context.Operators.Convert<string>(sf_);

        return sg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchElementDefinition.ResearchElementType> value)
    {
        ResearchElementDefinition.ResearchElementType? sh_ = value?.Value;
        string si_ = context.Operators.Convert<string>(sh_);

        return si_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchStudy.ResearchStudyStatus> value)
    {
        ResearchStudy.ResearchStudyStatus? sj_ = value?.Value;
        string sk_ = context.Operators.Convert<string>(sj_);

        return sk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchSubject.ResearchSubjectStatus> value)
    {
        ResearchSubject.ResearchSubjectStatus? sl_ = value?.Value;
        string sm_ = context.Operators.Convert<string>(sl_);

        return sm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ResourceVersionPolicy> value)
    {
        CapabilityStatement.ResourceVersionPolicy? sn_ = value?.Value;
        string so_ = context.Operators.Convert<string>(sn_);

        return so_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageHeader.ResponseType> value)
    {
        MessageHeader.ResponseType? sp_ = value?.Value;
        string sq_ = context.Operators.Convert<string>(sp_);

        return sq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.RestfulCapabilityMode> value)
    {
        CapabilityStatement.RestfulCapabilityMode? sr_ = value?.Value;
        string ss_ = context.Operators.Convert<string>(sr_);

        return ss_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.SPDXLicense> value)
    {
        ImplementationGuide.SPDXLicense? st_ = value?.Value;
        string su_ = context.Operators.Convert<string>(st_);

        return su_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.SearchComparator> value)
    {
        SearchParameter.SearchComparator? sv_ = value?.Value;
        string sw_ = context.Operators.Convert<string>(sv_);

        return sw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.SearchEntryMode> value)
    {
        Bundle.SearchEntryMode? sx_ = value?.Value;
        string sy_ = context.Operators.Convert<string>(sx_);

        return sy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.SearchModifierCode> value)
    {
        SearchParameter.SearchModifierCode? sz_ = value?.Value;
        string ta_ = context.Operators.Convert<string>(sz_);

        return ta_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParamType> value)
    {
        SearchParamType? tb_ = value?.Value;
        string tc_ = context.Operators.Convert<string>(tb_);

        return tc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.SequenceType> value)
    {
        MolecularSequence.SequenceType? td_ = value?.Value;
        string te_ = context.Operators.Convert<string>(td_);

        return te_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.SlicingRules> value)
    {
        ElementDefinition.SlicingRules? tf_ = value?.Value;
        string tg_ = context.Operators.Convert<string>(tf_);

        return tg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Slot.SlotStatus> value)
    {
        Slot.SlotStatus? th_ = value?.Value;
        string ti_ = context.Operators.Convert<string>(th_);

        return ti_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DataRequirement.SortDirection> value)
    {
        DataRequirement.SortDirection? tj_ = value?.Value;
        string tk_ = context.Operators.Convert<string>(tj_);

        return tk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SpecimenDefinition.SpecimenContainedPreference> value)
    {
        SpecimenDefinition.SpecimenContainedPreference? tl_ = value?.Value;
        string tm_ = context.Operators.Convert<string>(tl_);

        return tm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Specimen.SpecimenStatus> value)
    {
        Specimen.SpecimenStatus? tn_ = value?.Value;
        string to_ = context.Operators.Convert<string>(tn_);

        return to_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VerificationResult.StatusCode> value)
    {
        VerificationResult.StatusCode? tp_ = value?.Value;
        string tq_ = context.Operators.Convert<string>(tp_);

        return tq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.StrandType> value)
    {
        MolecularSequence.StrandType? tr_ = value?.Value;
        string ts_ = context.Operators.Convert<string>(tr_);

        return ts_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.StructureDefinitionKind> value)
    {
        StructureDefinition.StructureDefinitionKind? tt_ = value?.Value;
        string tu_ = context.Operators.Convert<string>(tt_);

        return tu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapContextType> value)
    {
        StructureMap.StructureMapContextType? tv_ = value?.Value;
        string tw_ = context.Operators.Convert<string>(tv_);

        return tw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapGroupTypeMode> value)
    {
        StructureMap.StructureMapGroupTypeMode? tx_ = value?.Value;
        string ty_ = context.Operators.Convert<string>(tx_);

        return ty_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapInputMode> value)
    {
        StructureMap.StructureMapInputMode? tz_ = value?.Value;
        string ua_ = context.Operators.Convert<string>(tz_);

        return ua_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapModelMode> value)
    {
        StructureMap.StructureMapModelMode? ub_ = value?.Value;
        string uc_ = context.Operators.Convert<string>(ub_);

        return uc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapSourceListMode> value)
    {
        StructureMap.StructureMapSourceListMode? ud_ = value?.Value;
        string ue_ = context.Operators.Convert<string>(ud_);

        return ue_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTargetListMode> value)
    {
        StructureMap.StructureMapTargetListMode? uf_ = value?.Value;
        string ug_ = context.Operators.Convert<string>(uf_);

        return ug_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTransform> value)
    {
        StructureMap.StructureMapTransform? uh_ = value?.Value;
        string ui_ = context.Operators.Convert<string>(uh_);

        return ui_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Subscription.SubscriptionChannelType> value)
    {
        Subscription.SubscriptionChannelType? uj_ = value?.Value;
        string uk_ = context.Operators.Convert<string>(uj_);

        return uk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Subscription.SubscriptionStatus> value)
    {
        Subscription.SubscriptionStatus? ul_ = value?.Value;
        string um_ = context.Operators.Convert<string>(ul_);

        return um_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SupplyDelivery.SupplyDeliveryStatus> value)
    {
        SupplyDelivery.SupplyDeliveryStatus? un_ = value?.Value;
        string uo_ = context.Operators.Convert<string>(un_);

        return uo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SupplyRequest.SupplyRequestStatus> value)
    {
        SupplyRequest.SupplyRequestStatus? up_ = value?.Value;
        string uq_ = context.Operators.Convert<string>(up_);

        return uq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.SystemRestfulInteraction> value)
    {
        CapabilityStatement.SystemRestfulInteraction? ur_ = value?.Value;
        string us_ = context.Operators.Convert<string>(ur_);

        return us_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Task.TaskIntent> value)
    {
        Task.TaskIntent? ut_ = value?.Value;
        string uu_ = context.Operators.Convert<string>(ut_);

        return uu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Task.TaskStatus> value)
    {
        Task.TaskStatus? uv_ = value?.Value;
        string uw_ = context.Operators.Convert<string>(uv_);

        return uw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportActionResult> value)
    {
        TestReport.TestReportActionResult? ux_ = value?.Value;
        string uy_ = context.Operators.Convert<string>(ux_);

        return uy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportParticipantType> value)
    {
        TestReport.TestReportParticipantType? uz_ = value?.Value;
        string va_ = context.Operators.Convert<string>(uz_);

        return va_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportResult> value)
    {
        TestReport.TestReportResult? vb_ = value?.Value;
        string vc_ = context.Operators.Convert<string>(vb_);

        return vc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportStatus> value)
    {
        TestReport.TestReportStatus? vd_ = value?.Value;
        string ve_ = context.Operators.Convert<string>(vd_);

        return ve_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.TestScriptRequestMethodCode> value)
    {
        TestScript.TestScriptRequestMethodCode? vf_ = value?.Value;
        string vg_ = context.Operators.Convert<string>(vf_);

        return vg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TriggerDefinition.TriggerType> value)
    {
        TriggerDefinition.TriggerType? vh_ = value?.Value;
        string vi_ = context.Operators.Convert<string>(vh_);

        return vi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.TypeDerivationRule> value)
    {
        StructureDefinition.TypeDerivationRule? vj_ = value?.Value;
        string vk_ = context.Operators.Convert<string>(vj_);

        return vk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.TypeRestfulInteraction> value)
    {
        CapabilityStatement.TypeRestfulInteraction? vl_ = value?.Value;
        string vm_ = context.Operators.Convert<string>(vl_);

        return vm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Device.UDIEntryType> value)
    {
        Device.UDIEntryType? vn_ = value?.Value;
        string vo_ = context.Operators.Convert<string>(vn_);

        return vo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Timing.UnitsOfTime> value)
    {
        Timing.UnitsOfTime? vp_ = value?.Value;
        string vq_ = context.Operators.Convert<string>(vp_);

        return vq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClaimUseCode> value)
    {
        ClaimUseCode? vr_ = value?.Value;
        string vs_ = context.Operators.Convert<string>(vr_);

        return vs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VisionPrescription.VisionBase> value)
    {
        VisionPrescription.VisionBase? vt_ = value?.Value;
        string vu_ = context.Operators.Convert<string>(vt_);

        return vu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VisionPrescription.VisionEyes> value)
    {
        VisionPrescription.VisionEyes? vv_ = value?.Value;
        string vw_ = context.Operators.Convert<string>(vv_);

        return vw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.XPathUsageType> value)
    {
        SearchParameter.XPathUsageType? vx_ = value?.Value;
        string vy_ = context.Operators.Convert<string>(vx_);

        return vy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Base64Binary value)
    {
        byte[] vz_ = value?.Value;
        string wa_ = context.Operators.Convert<string>(vz_);

        return wa_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, FhirString value)
    {
        string wb_ = value?.Value;

        return wb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, FhirUri value)
    {
        string wc_ = value?.Value;

        return wc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, XHtml value)
    {
        string wd_ = value?.Value;

        return wd_;
    }


    [CqlExpressionDefinition("ToBoolean")]
    public bool? ToBoolean(CqlContext context, FhirBoolean value)
    {
        bool? we_ = value?.Value;

        return we_;
    }


    [CqlExpressionDefinition("ToDate")]
    public CqlDate ToDate(CqlContext context, Date value)
    {
        string wf_ = value?.Value;
        CqlDate wg_ = context.Operators.ConvertStringToDate(wf_);

        return wg_;
    }


    [CqlExpressionDefinition("ToDateTime")]
    public CqlDateTime ToDateTime(CqlContext context, FhirDateTime value)
    {
        CqlDateTime wh_ = context.Operators.Convert<CqlDateTime>(value);

        return wh_;
    }


    [CqlExpressionDefinition("ToDateTime")]
    public CqlDateTime ToDateTime(CqlContext context, Instant value)
    {
        DateTimeOffset? wi_ = value?.Value;
        CqlDateTime wj_ = context.Operators.Convert<CqlDateTime>(wi_);

        return wj_;
    }


    [CqlExpressionDefinition("ToDecimal")]
    public decimal? ToDecimal(CqlContext context, FhirDecimal value)
    {
        decimal? wk_ = value?.Value;

        return wk_;
    }


    [CqlExpressionDefinition("ToInteger")]
    public int? ToInteger(CqlContext context, Integer value)
    {
        int? wl_ = value?.Value;

        return wl_;
    }


    [CqlExpressionDefinition("ToTime")]
    public CqlTime ToTime(CqlContext context, Time value)
    {
        string wm_ = value?.Value;
        CqlTime wn_ = context.Operators.ConvertStringToTime(wm_);

        return wn_;
    }


    #endregion Expressions

}

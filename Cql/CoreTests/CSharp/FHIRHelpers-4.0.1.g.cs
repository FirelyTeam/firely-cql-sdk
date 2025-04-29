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
        CqlInterval<CqlDateTime> b_()
        {
            if (period is null)
            {
                return null as CqlInterval<CqlDateTime>;
            }
            else if (period?.StartElement is null)
            {
                FhirDateTime c_ = period?.StartElement;
                CqlDateTime d_ = context.Operators.Convert<CqlDateTime>(c_);
                FhirDateTime e_ = period?.EndElement;
                CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(e_);
                CqlInterval<CqlDateTime> g_ = context.Operators.Interval(d_, f_, false, true);

                return g_;
            }
            else
            {
                FhirDateTime h_ = period?.StartElement;
                CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
                FhirDateTime j_ = period?.EndElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                CqlInterval<CqlDateTime> l_ = context.Operators.Interval(i_, k_, true, true);

                return l_;
            }
        };

        return b_();
    }


    [CqlExpressionDefinition("ToInterval")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Quantity quantity)
    {
        CqlInterval<CqlQuantity> m_()
        {
            if (quantity is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {
                CqlInterval<CqlQuantity> n_()
                {
                    bool o_()
                    {
                        Code<Quantity.QuantityComparator> s_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? t_ = s_?.Value;
                        string u_ = context.Operators.Convert<string>(t_);
                        bool? v_ = context.Operators.Equal(u_, "<");

                        return v_ ?? false;
                    };
                    bool p_()
                    {
                        Code<Quantity.QuantityComparator> w_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? x_ = w_?.Value;
                        string y_ = context.Operators.Convert<string>(x_);
                        bool? z_ = context.Operators.Equal(y_, "<=");

                        return z_ ?? false;
                    };
                    bool q_()
                    {
                        Code<Quantity.QuantityComparator> aa_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? ab_ = aa_?.Value;
                        string ac_ = context.Operators.Convert<string>(ab_);
                        bool? ad_ = context.Operators.Equal(ac_, ">=");

                        return ad_ ?? false;
                    };
                    bool r_()
                    {
                        Code<Quantity.QuantityComparator> ae_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? af_ = ae_?.Value;
                        string ag_ = context.Operators.Convert<string>(af_);
                        bool? ah_ = context.Operators.Equal(ag_, ">");

                        return ah_ ?? false;
                    };
                    if (o_())
                    {
                        CqlQuantity ai_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> aj_ = context.Operators.Interval(default, ai_, true, false);

                        return aj_;
                    }
                    else if (p_())
                    {
                        CqlQuantity ak_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> al_ = context.Operators.Interval(default, ak_, true, true);

                        return al_;
                    }
                    else if (q_())
                    {
                        CqlQuantity am_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> an_ = context.Operators.Interval(am_, default, true, true);

                        return an_;
                    }
                    else if (r_())
                    {
                        CqlQuantity ao_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> ap_ = context.Operators.Interval(ao_, default, false, true);

                        return ap_;
                    }
                    else
                    {
                        CqlQuantity aq_ = this.ToQuantity(context, quantity);
                        CqlInterval<CqlQuantity> as_ = context.Operators.Interval(aq_, aq_, true, true);

                        return as_;
                    }
                };

                return n_();
            }
        };

        return m_();
    }


    [CqlExpressionDefinition("ToInterval")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Range range)
    {
        CqlInterval<CqlQuantity> at_()
        {
            if (range is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {
                Quantity au_ = range?.Low;
                CqlQuantity av_ = this.ToQuantity(context, au_);
                Quantity aw_ = range?.High;
                CqlQuantity ax_ = this.ToQuantity(context, aw_);
                CqlInterval<CqlQuantity> ay_ = context.Operators.Interval(av_, ax_, true, true);

                return ay_;
            }
        };

        return at_();
    }


    [CqlExpressionDefinition("ToCalendarUnit")]
    public string ToCalendarUnit(CqlContext context, string unit)
    {
        string az_()
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

        return az_();
    }


    [CqlExpressionDefinition("ToQuantity")]
    public CqlQuantity ToQuantity(CqlContext context, Quantity quantity)
    {
        CqlQuantity ba_()
        {
            bool bb_()
            {
                Code<Quantity.QuantityComparator> bd_ = quantity?.ComparatorElement;
                bool? be_ = context.Operators.Not((bool?)(bd_ is null));

                return be_ ?? false;
            };
            bool bc_()
            {
                FhirUri bf_ = quantity?.SystemElement;
                string bh_ = bf_?.Value;
                bool? bi_ = context.Operators.Equal(bh_, "http://unitsofmeasure.org");
                bool? bj_ = context.Operators.Or((bool?)(bf_ is null), bi_);
                string bl_ = bf_?.Value;
                bool? bm_ = context.Operators.Equal(bl_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
                bool? bn_ = context.Operators.Or(bj_, bm_);

                return bn_ ?? false;
            };
            if (quantity is null)
            {
                return default;
            }
            else if (quantity?.ValueElement is null)
            {
                return default;
            }
            else if (bb_())
            {
                object bo_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.ComparatorQuantityNotSupported", "Error", "FHIR Quantity value has a comparator and cannot be converted to a System.Quantity value.");

                return bo_ as CqlQuantity;
            }
            else if (bc_())
            {
                FhirDecimal bp_ = quantity?.ValueElement;
                decimal? bq_ = bp_?.Value;
                Code br_ = quantity?.CodeElement;
                string bs_ = br_?.Value;
                FhirString bt_ = quantity?.UnitElement;
                string bu_ = bt_?.Value;
                string bv_ = this.ToCalendarUnit(context, (bs_ ?? bu_) ?? "1");

                return new CqlQuantity(bq_, bv_);
            }
            else
            {
                FhirString bw_ = quantity?.UnitElement;
                string bx_ = bw_?.Value;
                string by_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", bx_ ?? "");
                string bz_ = context.Operators.Concatenate(by_ ?? "", " (");
                FhirUri ca_ = quantity?.SystemElement;
                string cb_ = ca_?.Value;
                string cc_ = context.Operators.Concatenate(bz_ ?? "", cb_ ?? "");
                string cd_ = context.Operators.Concatenate(cc_ ?? "", "|");
                Code ce_ = quantity?.CodeElement;
                string cf_ = ce_?.Value;
                string cg_ = context.Operators.Concatenate(cd_ ?? "", cf_ ?? "");
                string ch_ = context.Operators.Concatenate(cg_ ?? "", ")");
                object ci_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", ch_);

                return ci_ as CqlQuantity;
            }
        };

        return ba_();
    }


    [CqlExpressionDefinition("ToQuantityIgnoringComparator")]
    public CqlQuantity ToQuantityIgnoringComparator(CqlContext context, Quantity quantity)
    {
        CqlQuantity cj_()
        {
            bool ck_()
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
            else if (ck_())
            {
                FhirDecimal cu_ = quantity?.ValueElement;
                decimal? cv_ = cu_?.Value;
                Code cw_ = quantity?.CodeElement;
                string cx_ = cw_?.Value;
                FhirString cy_ = quantity?.UnitElement;
                string cz_ = cy_?.Value;
                string da_ = this.ToCalendarUnit(context, (cx_ ?? cz_) ?? "1");

                return new CqlQuantity(cv_, da_);
            }
            else
            {
                FhirString db_ = quantity?.UnitElement;
                string dc_ = db_?.Value;
                string dd_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", dc_ ?? "");
                string de_ = context.Operators.Concatenate(dd_ ?? "", " (");
                FhirUri df_ = quantity?.SystemElement;
                string dg_ = df_?.Value;
                string dh_ = context.Operators.Concatenate(de_ ?? "", dg_ ?? "");
                string di_ = context.Operators.Concatenate(dh_ ?? "", "|");
                Code dj_ = quantity?.CodeElement;
                string dk_ = dj_?.Value;
                string dl_ = context.Operators.Concatenate(di_ ?? "", dk_ ?? "");
                string dm_ = context.Operators.Concatenate(dl_ ?? "", ")");
                object dn_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", dm_);

                return dn_ as CqlQuantity;
            }
        };

        return cj_();
    }


    [CqlExpressionDefinition("ToRatio")]
    public CqlRatio ToRatio(CqlContext context, Ratio ratio)
    {
        CqlRatio do_()
        {
            if (ratio is null)
            {
                return default;
            }
            else
            {
                Quantity dp_ = ratio?.Numerator;
                CqlQuantity dq_ = this.ToQuantity(context, dp_);
                Quantity dr_ = ratio?.Denominator;
                CqlQuantity ds_ = this.ToQuantity(context, dr_);

                return new CqlRatio(dq_, ds_);
            }
        };

        return do_();
    }


    [CqlExpressionDefinition("ToCode")]
    public CqlCode ToCode(CqlContext context, Coding coding)
    {
        CqlCode dt_()
        {
            if (coding is null)
            {
                return default;
            }
            else
            {
                Code du_ = coding?.CodeElement;
                string dv_ = du_?.Value;
                FhirUri dw_ = coding?.SystemElement;
                string dx_ = dw_?.Value;
                FhirString dy_ = coding?.VersionElement;
                string dz_ = dy_?.Value;
                FhirString ea_ = coding?.DisplayElement;
                string eb_ = ea_?.Value;

                return new CqlCode(dv_, dx_, dz_, eb_);
            }
        };

        return dt_();
    }


    [CqlExpressionDefinition("ToConcept")]
    public CqlConcept ToConcept(CqlContext context, CodeableConcept concept)
    {
        CqlConcept ec_()
        {
            if (concept is null)
            {
                return default;
            }
            else
            {
                List<Coding> ed_ = concept?.Coding;
                CqlCode ee_(Coding C)
                {
                    CqlCode ej_ = this.ToCode(context, C);

                    return ej_;
                };
                IEnumerable<CqlCode> ef_ = context.Operators.Select<Coding, CqlCode>((IEnumerable<Coding>)ed_, ee_);
                IEnumerable<CqlCode> eg_ = context.Operators.Distinct<CqlCode>(ef_);
                FhirString eh_ = concept?.TextElement;
                string ei_ = eh_?.Value;

                return new CqlConcept(eg_, ei_);
            }
        };

        return ec_();
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Account.AccountStatus> value)
    {
        Account.AccountStatus? ek_ = value?.Value;
        string el_ = context.Operators.Convert<string>(ek_);

        return el_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionCardinalityBehavior> value)
    {
        ActionCardinalityBehavior? em_ = value?.Value;
        string en_ = context.Operators.Convert<string>(em_);

        return en_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionConditionKind> value)
    {
        ActionConditionKind? eo_ = value?.Value;
        string ep_ = context.Operators.Convert<string>(eo_);

        return ep_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionGroupingBehavior> value)
    {
        ActionGroupingBehavior? eq_ = value?.Value;
        string er_ = context.Operators.Convert<string>(eq_);

        return er_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionParticipantType> value)
    {
        ActionParticipantType? es_ = value?.Value;
        string et_ = context.Operators.Convert<string>(es_);

        return et_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionPrecheckBehavior> value)
    {
        ActionPrecheckBehavior? eu_ = value?.Value;
        string ev_ = context.Operators.Convert<string>(eu_);

        return ev_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionRelationshipType> value)
    {
        ActionRelationshipType? ew_ = value?.Value;
        string ex_ = context.Operators.Convert<string>(ew_);

        return ex_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionRequiredBehavior> value)
    {
        ActionRequiredBehavior? ey_ = value?.Value;
        string ez_ = context.Operators.Convert<string>(ey_);

        return ez_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionSelectionBehavior> value)
    {
        ActionSelectionBehavior? fa_ = value?.Value;
        string fb_ = context.Operators.Convert<string>(fa_);

        return fb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActivityDefinition.RequestResourceType> value)
    {
        ActivityDefinition.RequestResourceType? fc_ = value?.Value;
        string fd_ = context.Operators.Convert<string>(fc_);

        return fd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Address.AddressType> value)
    {
        Address.AddressType? fe_ = value?.Value;
        string ff_ = context.Operators.Convert<string>(fe_);

        return ff_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Address.AddressUse> value)
    {
        Address.AddressUse? fg_ = value?.Value;
        string fh_ = context.Operators.Convert<string>(fg_);

        return fh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AdministrativeGender> value)
    {
        AdministrativeGender? fi_ = value?.Value;
        string fj_ = context.Operators.Convert<string>(fi_);

        return fj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AdverseEvent.AdverseEventActuality> value)
    {
        AdverseEvent.AdverseEventActuality? fk_ = value?.Value;
        string fl_ = context.Operators.Convert<string>(fk_);

        return fl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.AggregationMode> value)
    {
        ElementDefinition.AggregationMode? fm_ = value?.Value;
        string fn_ = context.Operators.Convert<string>(fm_);

        return fn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
    {
        AllergyIntolerance.AllergyIntoleranceCategory? fo_ = value?.Value;
        string fp_ = context.Operators.Convert<string>(fo_);

        return fp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
    {
        AllergyIntolerance.AllergyIntoleranceCriticality? fq_ = value?.Value;
        string fr_ = context.Operators.Convert<string>(fq_);

        return fr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
    {
        AllergyIntolerance.AllergyIntoleranceSeverity? fs_ = value?.Value;
        string ft_ = context.Operators.Convert<string>(fs_);

        return ft_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceType> value)
    {
        AllergyIntolerance.AllergyIntoleranceType? fu_ = value?.Value;
        string fv_ = context.Operators.Convert<string>(fu_);

        return fv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Appointment.AppointmentStatus> value)
    {
        Appointment.AppointmentStatus? fw_ = value?.Value;
        string fx_ = context.Operators.Convert<string>(fw_);

        return fx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionDirectionType> value)
    {
        TestScript.AssertionDirectionType? fy_ = value?.Value;
        string fz_ = context.Operators.Convert<string>(fy_);

        return fz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionOperatorType> value)
    {
        TestScript.AssertionOperatorType? ga_ = value?.Value;
        string gb_ = context.Operators.Convert<string>(ga_);

        return gb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionResponseTypes> value)
    {
        TestScript.AssertionResponseTypes? gc_ = value?.Value;
        string gd_ = context.Operators.Convert<string>(gc_);

        return gd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAction> value)
    {
        AuditEvent.AuditEventAction? ge_ = value?.Value;
        string gf_ = context.Operators.Convert<string>(ge_);

        return gf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAgentNetworkType> value)
    {
        AuditEvent.AuditEventAgentNetworkType? gg_ = value?.Value;
        string gh_ = context.Operators.Convert<string>(gg_);

        return gh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventOutcome> value)
    {
        AuditEvent.AuditEventOutcome? gi_ = value?.Value;
        string gj_ = context.Operators.Convert<string>(gi_);

        return gj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BindingStrength> value)
    {
        BindingStrength? gk_ = value?.Value;
        string gl_ = context.Operators.Convert<string>(gk_);

        return gl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? gm_ = value?.Value;
        string gn_ = context.Operators.Convert<string>(gm_);

        return gn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? go_ = value?.Value;
        string gp_ = context.Operators.Convert<string>(go_);

        return gp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? gq_ = value?.Value;
        string gr_ = context.Operators.Convert<string>(gq_);

        return gr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.BundleType> value)
    {
        Bundle.BundleType? gs_ = value?.Value;
        string gt_ = context.Operators.Convert<string>(gs_);

        return gt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatementKind> value)
    {
        CapabilityStatementKind? gu_ = value?.Value;
        string gv_ = context.Operators.Convert<string>(gu_);

        return gv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityKind> value)
    {
        CarePlan.CarePlanActivityKind? gw_ = value?.Value;
        string gx_ = context.Operators.Convert<string>(gw_);

        return gx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityStatus> value)
    {
        CarePlan.CarePlanActivityStatus? gy_ = value?.Value;
        string gz_ = context.Operators.Convert<string>(gy_);

        return gz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanIntent> value)
    {
        CarePlan.CarePlanIntent? ha_ = value?.Value;
        string hb_ = context.Operators.Convert<string>(ha_);

        return hb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestStatus> value)
    {
        RequestStatus? hc_ = value?.Value;
        string hd_ = context.Operators.Convert<string>(hc_);

        return hd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CareTeam.CareTeamStatus> value)
    {
        CareTeam.CareTeamStatus? he_ = value?.Value;
        string hf_ = context.Operators.Convert<string>(he_);

        return hf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CatalogEntry.CatalogEntryRelationType> value)
    {
        CatalogEntry.CatalogEntryRelationType? hg_ = value?.Value;
        string hh_ = context.Operators.Convert<string>(hg_);

        return hh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<InvoicePriceComponentType> value)
    {
        InvoicePriceComponentType? hi_ = value?.Value;
        string hj_ = context.Operators.Convert<string>(hi_);

        return hj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ChargeItem.ChargeItemStatus> value)
    {
        ChargeItem.ChargeItemStatus? hk_ = value?.Value;
        string hl_ = context.Operators.Convert<string>(hk_);

        return hl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FinancialResourceStatusCodes> value)
    {
        FinancialResourceStatusCodes? hm_ = value?.Value;
        string hn_ = context.Operators.Convert<string>(hm_);

        return hn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClinicalImpression.ClinicalImpressionStatus> value)
    {
        ClinicalImpression.ClinicalImpressionStatus? ho_ = value?.Value;
        string hp_ = context.Operators.Convert<string>(ho_);

        return hp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TerminologyCapabilities.CodeSearchSupport> value)
    {
        TerminologyCapabilities.CodeSearchSupport? hq_ = value?.Value;
        string hr_ = context.Operators.Convert<string>(hq_);

        return hr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystemContentMode> value)
    {
        CodeSystemContentMode? hs_ = value?.Value;
        string ht_ = context.Operators.Convert<string>(hs_);

        return ht_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystem.CodeSystemHierarchyMeaning> value)
    {
        CodeSystem.CodeSystemHierarchyMeaning? hu_ = value?.Value;
        string hv_ = context.Operators.Convert<string>(hu_);

        return hv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestPriority> value)
    {
        RequestPriority? hw_ = value?.Value;
        string hx_ = context.Operators.Convert<string>(hw_);

        return hx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EventStatus> value)
    {
        EventStatus? hy_ = value?.Value;
        string hz_ = context.Operators.Convert<string>(hy_);

        return hz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CompartmentType> value)
    {
        CompartmentType? ia_ = value?.Value;
        string ib_ = context.Operators.Convert<string>(ia_);

        return ib_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Composition.CompositionAttestationMode> value)
    {
        Composition.CompositionAttestationMode? ic_ = value?.Value;
        string id_ = context.Operators.Convert<string>(ic_);

        return id_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CompositionStatus> value)
    {
        CompositionStatus? ie_ = value?.Value;
        string if_ = context.Operators.Convert<string>(ie_);

        return if_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConceptMapEquivalence> value)
    {
        ConceptMapEquivalence? ig_ = value?.Value;
        string ih_ = context.Operators.Convert<string>(ig_);

        return ih_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
    {
        ConceptMap.ConceptMapGroupUnmappedMode? ii_ = value?.Value;
        string ij_ = context.Operators.Convert<string>(ii_);

        return ij_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalDeleteStatus> value)
    {
        CapabilityStatement.ConditionalDeleteStatus? ik_ = value?.Value;
        string il_ = context.Operators.Convert<string>(ik_);

        return il_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalReadStatus> value)
    {
        CapabilityStatement.ConditionalReadStatus? im_ = value?.Value;
        string in_ = context.Operators.Convert<string>(im_);

        return in_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentDataMeaning> value)
    {
        Consent.ConsentDataMeaning? io_ = value?.Value;
        string ip_ = context.Operators.Convert<string>(io_);

        return ip_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentProvisionType> value)
    {
        Consent.ConsentProvisionType? iq_ = value?.Value;
        string ir_ = context.Operators.Convert<string>(iq_);

        return ir_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentState> value)
    {
        Consent.ConsentState? is_ = value?.Value;
        string it_ = context.Operators.Convert<string>(is_);

        return it_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConstraintSeverity> value)
    {
        ConstraintSeverity? iu_ = value?.Value;
        string iv_ = context.Operators.Convert<string>(iu_);

        return iv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointSystem> value)
    {
        ContactPoint.ContactPointSystem? iw_ = value?.Value;
        string ix_ = context.Operators.Convert<string>(iw_);

        return ix_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointUse> value)
    {
        ContactPoint.ContactPointUse? iy_ = value?.Value;
        string iz_ = context.Operators.Convert<string>(iy_);

        return iz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contract.ContractResourcePublicationStatusCodes> value)
    {
        Contract.ContractResourcePublicationStatusCodes? ja_ = value?.Value;
        string jb_ = context.Operators.Convert<string>(ja_);

        return jb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contract.ContractResourceStatusCodes> value)
    {
        Contract.ContractResourceStatusCodes? jc_ = value?.Value;
        string jd_ = context.Operators.Convert<string>(jc_);

        return jd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contributor.ContributorType> value)
    {
        Contributor.ContributorType? je_ = value?.Value;
        string jf_ = context.Operators.Convert<string>(je_);

        return jf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Money.Currencies> value)
    {
        Money.Currencies? jg_ = value?.Value;
        string jh_ = context.Operators.Convert<string>(jg_);

        return jh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DaysOfWeek> value)
    {
        DaysOfWeek? ji_ = value?.Value;
        string jj_ = context.Operators.Convert<string>(ji_);

        return jj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DetectedIssue.DetectedIssueSeverity> value)
    {
        DetectedIssue.DetectedIssueSeverity? jk_ = value?.Value;
        string jl_ = context.Operators.Convert<string>(jk_);

        return jl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationStatus> value)
    {
        ObservationStatus? jm_ = value?.Value;
        string jn_ = context.Operators.Convert<string>(jm_);

        return jn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationState> value)
    {
        DeviceMetric.DeviceMetricCalibrationState? jo_ = value?.Value;
        string jp_ = context.Operators.Convert<string>(jo_);

        return jp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationType> value)
    {
        DeviceMetric.DeviceMetricCalibrationType? jq_ = value?.Value;
        string jr_ = context.Operators.Convert<string>(jq_);

        return jr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCategory> value)
    {
        DeviceMetric.DeviceMetricCategory? js_ = value?.Value;
        string jt_ = context.Operators.Convert<string>(js_);

        return jt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricColor> value)
    {
        DeviceMetric.DeviceMetricColor? ju_ = value?.Value;
        string jv_ = context.Operators.Convert<string>(ju_);

        return jv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricOperationalStatus> value)
    {
        DeviceMetric.DeviceMetricOperationalStatus? jw_ = value?.Value;
        string jx_ = context.Operators.Convert<string>(jw_);

        return jx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceNameType> value)
    {
        DeviceNameType? jy_ = value?.Value;
        string jz_ = context.Operators.Convert<string>(jy_);

        return jz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceUseStatement.DeviceUseStatementStatus> value)
    {
        DeviceUseStatement.DeviceUseStatementStatus? ka_ = value?.Value;
        string kb_ = context.Operators.Convert<string>(ka_);

        return kb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DiagnosticReport.DiagnosticReportStatus> value)
    {
        DiagnosticReport.DiagnosticReportStatus? kc_ = value?.Value;
        string kd_ = context.Operators.Convert<string>(kc_);

        return kd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.DiscriminatorType> value)
    {
        ElementDefinition.DiscriminatorType? ke_ = value?.Value;
        string kf_ = context.Operators.Convert<string>(ke_);

        return kf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Composition.V3ConfidentialityClassification> value)
    {
        Composition.V3ConfidentialityClassification? kg_ = value?.Value;
        string kh_ = context.Operators.Convert<string>(kg_);

        return kh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.DocumentMode> value)
    {
        CapabilityStatement.DocumentMode? ki_ = value?.Value;
        string kj_ = context.Operators.Convert<string>(ki_);

        return kj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DocumentReferenceStatus> value)
    {
        DocumentReferenceStatus? kk_ = value?.Value;
        string kl_ = context.Operators.Convert<string>(kk_);

        return kl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DocumentRelationshipType> value)
    {
        DocumentRelationshipType? km_ = value?.Value;
        string kn_ = context.Operators.Convert<string>(km_);

        return kn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
    {
        CoverageEligibilityRequest.EligibilityRequestPurpose? ko_ = value?.Value;
        string kp_ = context.Operators.Convert<string>(ko_);

        return kp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
    {
        CoverageEligibilityResponse.EligibilityResponsePurpose? kq_ = value?.Value;
        string kr_ = context.Operators.Convert<string>(kq_);

        return kr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.EnableWhenBehavior> value)
    {
        Questionnaire.EnableWhenBehavior? ks_ = value?.Value;
        string kt_ = context.Operators.Convert<string>(ks_);

        return kt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Encounter.EncounterLocationStatus> value)
    {
        Encounter.EncounterLocationStatus? ku_ = value?.Value;
        string kv_ = context.Operators.Convert<string>(ku_);

        return kv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Encounter.EncounterStatus> value)
    {
        Encounter.EncounterStatus? kw_ = value?.Value;
        string kx_ = context.Operators.Convert<string>(kw_);

        return kx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Endpoint.EndpointStatus> value)
    {
        Endpoint.EndpointStatus? ky_ = value?.Value;
        string kz_ = context.Operators.Convert<string>(ky_);

        return kz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EpisodeOfCare.EpisodeOfCareStatus> value)
    {
        EpisodeOfCare.EpisodeOfCareStatus? la_ = value?.Value;
        string lb_ = context.Operators.Convert<string>(la_);

        return lb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.EventCapabilityMode> value)
    {
        CapabilityStatement.EventCapabilityMode? lc_ = value?.Value;
        string ld_ = context.Operators.Convert<string>(lc_);

        return ld_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Timing.EventTiming> value)
    {
        Timing.EventTiming? le_ = value?.Value;
        string lf_ = context.Operators.Convert<string>(le_);

        return lf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VariableTypeCode> value)
    {
        VariableTypeCode? lg_ = value?.Value;
        string lh_ = context.Operators.Convert<string>(lg_);

        return lh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ExampleScenario.ExampleScenarioActorType> value)
    {
        ExampleScenario.ExampleScenarioActorType? li_ = value?.Value;
        string lj_ = context.Operators.Convert<string>(li_);

        return lj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
    {
        ExplanationOfBenefit.ExplanationOfBenefitStatus? lk_ = value?.Value;
        string ll_ = context.Operators.Convert<string>(lk_);

        return ll_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EffectEvidenceSynthesis.ExposureStateCode> value)
    {
        EffectEvidenceSynthesis.ExposureStateCode? lm_ = value?.Value;
        string ln_ = context.Operators.Convert<string>(lm_);

        return ln_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.ExtensionContextType> value)
    {
        StructureDefinition.ExtensionContextType? lo_ = value?.Value;
        string lp_ = context.Operators.Convert<string>(lo_);

        return lp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRAllTypes> value)
    {
        FHIRAllTypes? lq_ = value?.Value;
        string lr_ = context.Operators.Convert<string>(lq_);

        return lr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRDefinedType> value)
    {
        FHIRDefinedType? ls_ = value?.Value;
        string lt_ = context.Operators.Convert<string>(ls_);

        return lt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Device.FHIRDeviceStatus> value)
    {
        Device.FHIRDeviceStatus? lu_ = value?.Value;
        string lv_ = context.Operators.Convert<string>(lu_);

        return lv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResourceType> value)
    {
        ResourceType? lw_ = value?.Value;
        string lx_ = context.Operators.Convert<string>(lw_);

        return lx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Substance.FHIRSubstanceStatus> value)
    {
        Substance.FHIRSubstanceStatus? ly_ = value?.Value;
        string lz_ = context.Operators.Convert<string>(ly_);

        return lz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRVersion> value)
    {
        FHIRVersion? ma_ = value?.Value;
        string mb_ = context.Operators.Convert<string>(ma_);

        return mb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FamilyMemberHistory.FamilyHistoryStatus> value)
    {
        FamilyMemberHistory.FamilyHistoryStatus? mc_ = value?.Value;
        string md_ = context.Operators.Convert<string>(mc_);

        return md_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FilterOperator> value)
    {
        FilterOperator? me_ = value?.Value;
        string mf_ = context.Operators.Convert<string>(me_);

        return mf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Flag.FlagStatus> value)
    {
        Flag.FlagStatus? mg_ = value?.Value;
        string mh_ = context.Operators.Convert<string>(mg_);

        return mh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Goal.GoalLifecycleStatus> value)
    {
        Goal.GoalLifecycleStatus? mi_ = value?.Value;
        string mj_ = context.Operators.Convert<string>(mi_);

        return mj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentRule> value)
    {
        GraphDefinition.GraphCompartmentRule? mk_ = value?.Value;
        string ml_ = context.Operators.Convert<string>(mk_);

        return ml_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentUse> value)
    {
        GraphDefinition.GraphCompartmentUse? mm_ = value?.Value;
        string mn_ = context.Operators.Convert<string>(mm_);

        return mn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GroupMeasureCode> value)
    {
        GroupMeasureCode? mo_ = value?.Value;
        string mp_ = context.Operators.Convert<string>(mo_);

        return mp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Group.GroupType> value)
    {
        Group.GroupType? mq_ = value?.Value;
        string mr_ = context.Operators.Convert<string>(mq_);

        return mr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GuidanceResponse.GuidanceResponseStatus> value)
    {
        GuidanceResponse.GuidanceResponseStatus? ms_ = value?.Value;
        string mt_ = context.Operators.Convert<string>(ms_);

        return mt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.GuidePageGeneration> value)
    {
        ImplementationGuide.GuidePageGeneration? mu_ = value?.Value;
        string mv_ = context.Operators.Convert<string>(mu_);

        return mv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.GuideParameterCode> value)
    {
        ImplementationGuide.GuideParameterCode? mw_ = value?.Value;
        string mx_ = context.Operators.Convert<string>(mw_);

        return mx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.HTTPVerb> value)
    {
        Bundle.HTTPVerb? my_ = value?.Value;
        string mz_ = context.Operators.Convert<string>(my_);

        return mz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Identifier.IdentifierUse> value)
    {
        Identifier.IdentifierUse? na_ = value?.Value;
        string nb_ = context.Operators.Convert<string>(na_);

        return nb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Person.IdentityAssuranceLevel> value)
    {
        Person.IdentityAssuranceLevel? nc_ = value?.Value;
        string nd_ = context.Operators.Convert<string>(nc_);

        return nd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImagingStudy.ImagingStudyStatus> value)
    {
        ImagingStudy.ImagingStudyStatus? ne_ = value?.Value;
        string nf_ = context.Operators.Convert<string>(ne_);

        return nf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
    {
        ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? ng_ = value?.Value;
        string nh_ = context.Operators.Convert<string>(ng_);

        return nh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Immunization.ImmunizationStatusCodes> value)
    {
        Immunization.ImmunizationStatusCodes? ni_ = value?.Value;
        string nj_ = context.Operators.Convert<string>(ni_);

        return nj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Invoice.InvoiceStatus> value)
    {
        Invoice.InvoiceStatus? nk_ = value?.Value;
        string nl_ = context.Operators.Convert<string>(nk_);

        return nl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationOutcome.IssueSeverity> value)
    {
        OperationOutcome.IssueSeverity? nm_ = value?.Value;
        string nn_ = context.Operators.Convert<string>(nm_);

        return nn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationOutcome.IssueType> value)
    {
        OperationOutcome.IssueType? no_ = value?.Value;
        string np_ = context.Operators.Convert<string>(no_);

        return np_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Patient.LinkType> value)
    {
        Patient.LinkType? nq_ = value?.Value;
        string nr_ = context.Operators.Convert<string>(nq_);

        return nr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Linkage.LinkageType> value)
    {
        Linkage.LinkageType? ns_ = value?.Value;
        string nt_ = context.Operators.Convert<string>(ns_);

        return nt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ListMode> value)
    {
        ListMode? nu_ = value?.Value;
        string nv_ = context.Operators.Convert<string>(nu_);

        return nv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<List.ListStatus> value)
    {
        List.ListStatus? nw_ = value?.Value;
        string nx_ = context.Operators.Convert<string>(nw_);

        return nx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Location.LocationMode> value)
    {
        Location.LocationMode? ny_ = value?.Value;
        string nz_ = context.Operators.Convert<string>(ny_);

        return nz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Location.LocationStatus> value)
    {
        Location.LocationStatus? oa_ = value?.Value;
        string ob_ = context.Operators.Convert<string>(oa_);

        return ob_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportStatus> value)
    {
        MeasureReport.MeasureReportStatus? oc_ = value?.Value;
        string od_ = context.Operators.Convert<string>(oc_);

        return od_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportType> value)
    {
        MeasureReport.MeasureReportType? oe_ = value?.Value;
        string of_ = context.Operators.Convert<string>(oe_);

        return of_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
    {
        MedicationAdministration.MedicationAdministrationStatusCodes? og_ = value?.Value;
        string oh_ = context.Operators.Convert<string>(og_);

        return oh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationDispense.MedicationDispenseStatusCodes> value)
    {
        MedicationDispense.MedicationDispenseStatusCodes? oi_ = value?.Value;
        string oj_ = context.Operators.Convert<string>(oi_);

        return oj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
    {
        MedicationKnowledge.MedicationKnowledgeStatusCodes? ok_ = value?.Value;
        string ol_ = context.Operators.Convert<string>(ok_);

        return ol_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationRequestIntent> value)
    {
        MedicationRequest.MedicationRequestIntent? om_ = value?.Value;
        string on_ = context.Operators.Convert<string>(om_);

        return on_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationrequestStatus> value)
    {
        MedicationRequest.MedicationrequestStatus? oo_ = value?.Value;
        string op_ = context.Operators.Convert<string>(oo_);

        return op_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationStatement.MedicationStatusCodes> value)
    {
        MedicationStatement.MedicationStatusCodes? oq_ = value?.Value;
        string or_ = context.Operators.Convert<string>(oq_);

        return or_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Medication.MedicationStatusCodes> value)
    {
        Medication.MedicationStatusCodes? os_ = value?.Value;
        string ot_ = context.Operators.Convert<string>(os_);

        return ot_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageDefinition.MessageSignificanceCategory> value)
    {
        MessageDefinition.MessageSignificanceCategory? ou_ = value?.Value;
        string ov_ = context.Operators.Convert<string>(ou_);

        return ov_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageheaderResponseRequest> value)
    {
        MessageheaderResponseRequest? ow_ = value?.Value;
        string ox_ = context.Operators.Convert<string>(ow_);

        return ox_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code value)
    {
        string oy_ = value?.Value;

        return oy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<HumanName.NameUse> value)
    {
        HumanName.NameUse? oz_ = value?.Value;
        string pa_ = context.Operators.Convert<string>(oz_);

        return pa_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemIdentifierType> value)
    {
        NamingSystem.NamingSystemIdentifierType? pb_ = value?.Value;
        string pc_ = context.Operators.Convert<string>(pb_);

        return pc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemType> value)
    {
        NamingSystem.NamingSystemType? pd_ = value?.Value;
        string pe_ = context.Operators.Convert<string>(pd_);

        return pe_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Narrative.NarrativeStatus> value)
    {
        Narrative.NarrativeStatus? pf_ = value?.Value;
        string pg_ = context.Operators.Convert<string>(pf_);

        return pg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NoteType> value)
    {
        NoteType? ph_ = value?.Value;
        string pi_ = context.Operators.Convert<string>(ph_);

        return pi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestIntent> value)
    {
        RequestIntent? pj_ = value?.Value;
        string pk_ = context.Operators.Convert<string>(pj_);

        return pk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationDataType> value)
    {
        ObservationDefinition.ObservationDataType? pl_ = value?.Value;
        string pm_ = context.Operators.Convert<string>(pl_);

        return pm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationRangeCategory> value)
    {
        ObservationDefinition.ObservationRangeCategory? pn_ = value?.Value;
        string po_ = context.Operators.Convert<string>(pn_);

        return po_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationDefinition.OperationKind> value)
    {
        OperationDefinition.OperationKind? pp_ = value?.Value;
        string pq_ = context.Operators.Convert<string>(pp_);

        return pq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationParameterUse> value)
    {
        OperationParameterUse? pr_ = value?.Value;
        string ps_ = context.Operators.Convert<string>(pr_);

        return ps_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.OrientationType> value)
    {
        MolecularSequence.OrientationType? pt_ = value?.Value;
        string pu_ = context.Operators.Convert<string>(pt_);

        return pu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Appointment.ParticipantRequired> value)
    {
        Appointment.ParticipantRequired? pv_ = value?.Value;
        string pw_ = context.Operators.Convert<string>(pv_);

        return pw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ParticipationStatus> value)
    {
        ParticipationStatus? px_ = value?.Value;
        string py_ = context.Operators.Convert<string>(px_);

        return py_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.PropertyRepresentation> value)
    {
        ElementDefinition.PropertyRepresentation? pz_ = value?.Value;
        string qa_ = context.Operators.Convert<string>(pz_);

        return qa_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystem.PropertyType> value)
    {
        CodeSystem.PropertyType? qb_ = value?.Value;
        string qc_ = context.Operators.Convert<string>(qb_);

        return qc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Provenance.ProvenanceEntityRole> value)
    {
        Provenance.ProvenanceEntityRole? qd_ = value?.Value;
        string qe_ = context.Operators.Convert<string>(qd_);

        return qe_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<PublicationStatus> value)
    {
        PublicationStatus? qf_ = value?.Value;
        string qg_ = context.Operators.Convert<string>(qf_);

        return qg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.QualityType> value)
    {
        MolecularSequence.QualityType? qh_ = value?.Value;
        string qi_ = context.Operators.Convert<string>(qh_);

        return qi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Quantity.QuantityComparator> value)
    {
        Quantity.QuantityComparator? qj_ = value?.Value;
        string qk_ = context.Operators.Convert<string>(qj_);

        return qk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemOperator> value)
    {
        Questionnaire.QuestionnaireItemOperator? ql_ = value?.Value;
        string qm_ = context.Operators.Convert<string>(ql_);

        return qm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemType> value)
    {
        Questionnaire.QuestionnaireItemType? qn_ = value?.Value;
        string qo_ = context.Operators.Convert<string>(qn_);

        return qo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
    {
        QuestionnaireResponse.QuestionnaireResponseStatus? qp_ = value?.Value;
        string qq_ = context.Operators.Convert<string>(qp_);

        return qq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ReferenceHandlingPolicy> value)
    {
        CapabilityStatement.ReferenceHandlingPolicy? qr_ = value?.Value;
        string qs_ = context.Operators.Convert<string>(qr_);

        return qs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.ReferenceVersionRules> value)
    {
        ElementDefinition.ReferenceVersionRules? qt_ = value?.Value;
        string qu_ = context.Operators.Convert<string>(qt_);

        return qu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RelatedArtifact.RelatedArtifactType> value)
    {
        RelatedArtifact.RelatedArtifactType? qv_ = value?.Value;
        string qw_ = context.Operators.Convert<string>(qv_);

        return qw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClaimProcessingCodes> value)
    {
        ClaimProcessingCodes? qx_ = value?.Value;
        string qy_ = context.Operators.Convert<string>(qx_);

        return qy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.RepositoryType> value)
    {
        MolecularSequence.RepositoryType? qz_ = value?.Value;
        string ra_ = context.Operators.Convert<string>(qz_);

        return ra_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchElementDefinition.ResearchElementType> value)
    {
        ResearchElementDefinition.ResearchElementType? rb_ = value?.Value;
        string rc_ = context.Operators.Convert<string>(rb_);

        return rc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchStudy.ResearchStudyStatus> value)
    {
        ResearchStudy.ResearchStudyStatus? rd_ = value?.Value;
        string re_ = context.Operators.Convert<string>(rd_);

        return re_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchSubject.ResearchSubjectStatus> value)
    {
        ResearchSubject.ResearchSubjectStatus? rf_ = value?.Value;
        string rg_ = context.Operators.Convert<string>(rf_);

        return rg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ResourceVersionPolicy> value)
    {
        CapabilityStatement.ResourceVersionPolicy? rh_ = value?.Value;
        string ri_ = context.Operators.Convert<string>(rh_);

        return ri_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageHeader.ResponseType> value)
    {
        MessageHeader.ResponseType? rj_ = value?.Value;
        string rk_ = context.Operators.Convert<string>(rj_);

        return rk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.RestfulCapabilityMode> value)
    {
        CapabilityStatement.RestfulCapabilityMode? rl_ = value?.Value;
        string rm_ = context.Operators.Convert<string>(rl_);

        return rm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.SPDXLicense> value)
    {
        ImplementationGuide.SPDXLicense? rn_ = value?.Value;
        string ro_ = context.Operators.Convert<string>(rn_);

        return ro_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.SearchComparator> value)
    {
        SearchParameter.SearchComparator? rp_ = value?.Value;
        string rq_ = context.Operators.Convert<string>(rp_);

        return rq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.SearchEntryMode> value)
    {
        Bundle.SearchEntryMode? rr_ = value?.Value;
        string rs_ = context.Operators.Convert<string>(rr_);

        return rs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.SearchModifierCode> value)
    {
        SearchParameter.SearchModifierCode? rt_ = value?.Value;
        string ru_ = context.Operators.Convert<string>(rt_);

        return ru_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParamType> value)
    {
        SearchParamType? rv_ = value?.Value;
        string rw_ = context.Operators.Convert<string>(rv_);

        return rw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.SequenceType> value)
    {
        MolecularSequence.SequenceType? rx_ = value?.Value;
        string ry_ = context.Operators.Convert<string>(rx_);

        return ry_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.SlicingRules> value)
    {
        ElementDefinition.SlicingRules? rz_ = value?.Value;
        string sa_ = context.Operators.Convert<string>(rz_);

        return sa_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Slot.SlotStatus> value)
    {
        Slot.SlotStatus? sb_ = value?.Value;
        string sc_ = context.Operators.Convert<string>(sb_);

        return sc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DataRequirement.SortDirection> value)
    {
        DataRequirement.SortDirection? sd_ = value?.Value;
        string se_ = context.Operators.Convert<string>(sd_);

        return se_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SpecimenDefinition.SpecimenContainedPreference> value)
    {
        SpecimenDefinition.SpecimenContainedPreference? sf_ = value?.Value;
        string sg_ = context.Operators.Convert<string>(sf_);

        return sg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Specimen.SpecimenStatus> value)
    {
        Specimen.SpecimenStatus? sh_ = value?.Value;
        string si_ = context.Operators.Convert<string>(sh_);

        return si_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VerificationResult.StatusCode> value)
    {
        VerificationResult.StatusCode? sj_ = value?.Value;
        string sk_ = context.Operators.Convert<string>(sj_);

        return sk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.StrandType> value)
    {
        MolecularSequence.StrandType? sl_ = value?.Value;
        string sm_ = context.Operators.Convert<string>(sl_);

        return sm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.StructureDefinitionKind> value)
    {
        StructureDefinition.StructureDefinitionKind? sn_ = value?.Value;
        string so_ = context.Operators.Convert<string>(sn_);

        return so_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapContextType> value)
    {
        StructureMap.StructureMapContextType? sp_ = value?.Value;
        string sq_ = context.Operators.Convert<string>(sp_);

        return sq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapGroupTypeMode> value)
    {
        StructureMap.StructureMapGroupTypeMode? sr_ = value?.Value;
        string ss_ = context.Operators.Convert<string>(sr_);

        return ss_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapInputMode> value)
    {
        StructureMap.StructureMapInputMode? st_ = value?.Value;
        string su_ = context.Operators.Convert<string>(st_);

        return su_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapModelMode> value)
    {
        StructureMap.StructureMapModelMode? sv_ = value?.Value;
        string sw_ = context.Operators.Convert<string>(sv_);

        return sw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapSourceListMode> value)
    {
        StructureMap.StructureMapSourceListMode? sx_ = value?.Value;
        string sy_ = context.Operators.Convert<string>(sx_);

        return sy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTargetListMode> value)
    {
        StructureMap.StructureMapTargetListMode? sz_ = value?.Value;
        string ta_ = context.Operators.Convert<string>(sz_);

        return ta_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTransform> value)
    {
        StructureMap.StructureMapTransform? tb_ = value?.Value;
        string tc_ = context.Operators.Convert<string>(tb_);

        return tc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Subscription.SubscriptionChannelType> value)
    {
        Subscription.SubscriptionChannelType? td_ = value?.Value;
        string te_ = context.Operators.Convert<string>(td_);

        return te_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Subscription.SubscriptionStatus> value)
    {
        Subscription.SubscriptionStatus? tf_ = value?.Value;
        string tg_ = context.Operators.Convert<string>(tf_);

        return tg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SupplyDelivery.SupplyDeliveryStatus> value)
    {
        SupplyDelivery.SupplyDeliveryStatus? th_ = value?.Value;
        string ti_ = context.Operators.Convert<string>(th_);

        return ti_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SupplyRequest.SupplyRequestStatus> value)
    {
        SupplyRequest.SupplyRequestStatus? tj_ = value?.Value;
        string tk_ = context.Operators.Convert<string>(tj_);

        return tk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.SystemRestfulInteraction> value)
    {
        CapabilityStatement.SystemRestfulInteraction? tl_ = value?.Value;
        string tm_ = context.Operators.Convert<string>(tl_);

        return tm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Task.TaskIntent> value)
    {
        Task.TaskIntent? tn_ = value?.Value;
        string to_ = context.Operators.Convert<string>(tn_);

        return to_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Task.TaskStatus> value)
    {
        Task.TaskStatus? tp_ = value?.Value;
        string tq_ = context.Operators.Convert<string>(tp_);

        return tq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportActionResult> value)
    {
        TestReport.TestReportActionResult? tr_ = value?.Value;
        string ts_ = context.Operators.Convert<string>(tr_);

        return ts_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportParticipantType> value)
    {
        TestReport.TestReportParticipantType? tt_ = value?.Value;
        string tu_ = context.Operators.Convert<string>(tt_);

        return tu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportResult> value)
    {
        TestReport.TestReportResult? tv_ = value?.Value;
        string tw_ = context.Operators.Convert<string>(tv_);

        return tw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportStatus> value)
    {
        TestReport.TestReportStatus? tx_ = value?.Value;
        string ty_ = context.Operators.Convert<string>(tx_);

        return ty_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.TestScriptRequestMethodCode> value)
    {
        TestScript.TestScriptRequestMethodCode? tz_ = value?.Value;
        string ua_ = context.Operators.Convert<string>(tz_);

        return ua_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TriggerDefinition.TriggerType> value)
    {
        TriggerDefinition.TriggerType? ub_ = value?.Value;
        string uc_ = context.Operators.Convert<string>(ub_);

        return uc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.TypeDerivationRule> value)
    {
        StructureDefinition.TypeDerivationRule? ud_ = value?.Value;
        string ue_ = context.Operators.Convert<string>(ud_);

        return ue_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.TypeRestfulInteraction> value)
    {
        CapabilityStatement.TypeRestfulInteraction? uf_ = value?.Value;
        string ug_ = context.Operators.Convert<string>(uf_);

        return ug_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Device.UDIEntryType> value)
    {
        Device.UDIEntryType? uh_ = value?.Value;
        string ui_ = context.Operators.Convert<string>(uh_);

        return ui_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Timing.UnitsOfTime> value)
    {
        Timing.UnitsOfTime? uj_ = value?.Value;
        string uk_ = context.Operators.Convert<string>(uj_);

        return uk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClaimUseCode> value)
    {
        ClaimUseCode? ul_ = value?.Value;
        string um_ = context.Operators.Convert<string>(ul_);

        return um_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VisionPrescription.VisionBase> value)
    {
        VisionPrescription.VisionBase? un_ = value?.Value;
        string uo_ = context.Operators.Convert<string>(un_);

        return uo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VisionPrescription.VisionEyes> value)
    {
        VisionPrescription.VisionEyes? up_ = value?.Value;
        string uq_ = context.Operators.Convert<string>(up_);

        return uq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.XPathUsageType> value)
    {
        SearchParameter.XPathUsageType? ur_ = value?.Value;
        string us_ = context.Operators.Convert<string>(ur_);

        return us_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Base64Binary value)
    {
        byte[] ut_ = value?.Value;
        string uu_ = context.Operators.Convert<string>(ut_);

        return uu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, FhirString value)
    {
        string uv_ = value?.Value;

        return uv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, FhirUri value)
    {
        string uw_ = value?.Value;

        return uw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, XHtml value)
    {
        string ux_ = value?.Value;

        return ux_;
    }


    [CqlExpressionDefinition("ToBoolean")]
    public bool? ToBoolean(CqlContext context, FhirBoolean value)
    {
        bool? uy_ = value?.Value;

        return uy_;
    }


    [CqlExpressionDefinition("ToDate")]
    public CqlDate ToDate(CqlContext context, Date value)
    {
        string uz_ = value?.Value;
        CqlDate va_ = context.Operators.ConvertStringToDate(uz_);

        return va_;
    }


    [CqlExpressionDefinition("ToDateTime")]
    public CqlDateTime ToDateTime(CqlContext context, FhirDateTime value)
    {
        CqlDateTime vb_ = context.Operators.Convert<CqlDateTime>(value);

        return vb_;
    }


    [CqlExpressionDefinition("ToDateTime")]
    public CqlDateTime ToDateTime(CqlContext context, Instant value)
    {
        DateTimeOffset? vc_ = value?.Value;
        CqlDateTime vd_ = context.Operators.Convert<CqlDateTime>(vc_);

        return vd_;
    }


    [CqlExpressionDefinition("ToDecimal")]
    public decimal? ToDecimal(CqlContext context, FhirDecimal value)
    {
        decimal? ve_ = value?.Value;

        return ve_;
    }


    [CqlExpressionDefinition("ToInteger")]
    public int? ToInteger(CqlContext context, Integer value)
    {
        int? vf_ = value?.Value;

        return vf_;
    }


    [CqlExpressionDefinition("ToTime")]
    public CqlTime ToTime(CqlContext context, Time value)
    {
        string vg_ = value?.Value;
        CqlTime vh_ = context.Operators.ConvertStringToTime(vg_);

        return vh_;
    }


    #endregion Expressions

}

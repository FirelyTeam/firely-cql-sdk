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

    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, Period period)
    {
        CqlInterval<CqlDateTime> c_()
        {
            if (period is null)
            {
                return null as CqlInterval<CqlDateTime>;
            }
            else if (period?.StartElement is null)
            {
                FhirDateTime d_ = period?.StartElement;
                CqlDateTime e_ = context.Operators.Convert<CqlDateTime>(d_);
                FhirDateTime f_ = period?.EndElement;
                CqlDateTime g_ = context.Operators.Convert<CqlDateTime>(f_);
                CqlInterval<CqlDateTime> h_ = context.Operators.Interval(e_, g_, false, true);

                return h_;
            }
            else
            {
                FhirDateTime i_ = period?.StartElement;
                CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                FhirDateTime k_ = period?.EndElement;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                CqlInterval<CqlDateTime> m_ = context.Operators.Interval(j_, l_, true, true);

                return m_;
            }
        };

        return c_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Quantity quantity)
    {
        CqlInterval<CqlQuantity> n_()
        {
            if (quantity is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {
                CqlInterval<CqlQuantity> o_()
                {
                    bool p_()
                    {
                        Code<Quantity.QuantityComparator> t_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? u_ = t_?.Value;
                        string v_ = context.Operators.Convert<string>(u_);
                        bool? w_ = context.Operators.Equal(v_, "<");

                        return w_ ?? false;
                    };
                    bool q_()
                    {
                        Code<Quantity.QuantityComparator> x_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? y_ = x_?.Value;
                        string z_ = context.Operators.Convert<string>(y_);
                        bool? aa_ = context.Operators.Equal(z_, "<=");

                        return aa_ ?? false;
                    };
                    bool r_()
                    {
                        Code<Quantity.QuantityComparator> ab_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? ac_ = ab_?.Value;
                        string ad_ = context.Operators.Convert<string>(ac_);
                        bool? ae_ = context.Operators.Equal(ad_, ">=");

                        return ae_ ?? false;
                    };
                    bool s_()
                    {
                        Code<Quantity.QuantityComparator> af_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? ag_ = af_?.Value;
                        string ah_ = context.Operators.Convert<string>(ag_);
                        bool? ai_ = context.Operators.Equal(ah_, ">");

                        return ai_ ?? false;
                    };
                    if (p_())
                    {
                        CqlQuantity aj_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> ak_ = context.Operators.Interval(default, aj_, true, false);

                        return ak_;
                    }
                    else if (q_())
                    {
                        CqlQuantity al_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> am_ = context.Operators.Interval(default, al_, true, true);

                        return am_;
                    }
                    else if (r_())
                    {
                        CqlQuantity an_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> ao_ = context.Operators.Interval(an_, default, true, true);

                        return ao_;
                    }
                    else if (s_())
                    {
                        CqlQuantity ap_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> aq_ = context.Operators.Interval(ap_, default, false, true);

                        return aq_;
                    }
                    else
                    {
                        CqlQuantity ar_ = this.ToQuantity(context, quantity);
                        CqlInterval<CqlQuantity> at_ = context.Operators.Interval(ar_, ar_, true, true);

                        return at_;
                    }
                };

                return o_();
            }
        };

        return n_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Range range)
    {
        CqlInterval<CqlQuantity> au_()
        {
            if (range is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {
                Quantity av_ = range?.Low;
                CqlQuantity aw_ = this.ToQuantity(context, av_);
                Quantity ax_ = range?.High;
                CqlQuantity ay_ = this.ToQuantity(context, ax_);
                CqlInterval<CqlQuantity> az_ = context.Operators.Interval(aw_, ay_, true, true);

                return az_;
            }
        };

        return au_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToCalendarUnit(CqlContext context, string unit)
    {
        string ba_()
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

        return ba_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlQuantity ToQuantity(CqlContext context, Quantity quantity)
    {
        CqlQuantity bb_()
        {
            bool bc_()
            {
                Code<Quantity.QuantityComparator> be_ = quantity?.ComparatorElement;
                bool? bf_ = context.Operators.Not((bool?)(be_ is null));

                return bf_ ?? false;
            };
            bool bd_()
            {
                FhirUri bg_ = quantity?.SystemElement;
                string bi_ = bg_?.Value;
                bool? bj_ = context.Operators.Equal(bi_, "http://unitsofmeasure.org");
                bool? bk_ = context.Operators.Or((bool?)(bg_ is null), bj_);
                string bm_ = bg_?.Value;
                bool? bn_ = context.Operators.Equal(bm_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
                bool? bo_ = context.Operators.Or(bk_, bn_);

                return bo_ ?? false;
            };
            if (quantity is null)
            {
                return default;
            }
            else if (quantity?.ValueElement is null)
            {
                return default;
            }
            else if (bc_())
            {
                object bp_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.ComparatorQuantityNotSupported", "Error", "FHIR Quantity value has a comparator and cannot be converted to a System.Quantity value.");

                return bp_ as CqlQuantity;
            }
            else if (bd_())
            {
                FhirDecimal bq_ = quantity?.ValueElement;
                decimal? br_ = bq_?.Value;
                Code bs_ = quantity?.CodeElement;
                string bt_ = bs_?.Value;
                FhirString bu_ = quantity?.UnitElement;
                string bv_ = bu_?.Value;
                string bw_ = this.ToCalendarUnit(context, (bt_ ?? bv_) ?? "1");

                return new CqlQuantity(br_, bw_);
            }
            else
            {
                FhirString bx_ = quantity?.UnitElement;
                string by_ = bx_?.Value;
                string bz_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", by_ ?? "");
                string ca_ = context.Operators.Concatenate(bz_ ?? "", " (");
                FhirUri cb_ = quantity?.SystemElement;
                string cc_ = cb_?.Value;
                string cd_ = context.Operators.Concatenate(ca_ ?? "", cc_ ?? "");
                string ce_ = context.Operators.Concatenate(cd_ ?? "", "|");
                Code cf_ = quantity?.CodeElement;
                string cg_ = cf_?.Value;
                string ch_ = context.Operators.Concatenate(ce_ ?? "", cg_ ?? "");
                string ci_ = context.Operators.Concatenate(ch_ ?? "", ")");
                object cj_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", ci_);

                return cj_ as CqlQuantity;
            }
        };

        return bb_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlQuantity ToQuantityIgnoringComparator(CqlContext context, Quantity quantity)
    {
        CqlQuantity ck_()
        {
            bool cl_()
            {
                FhirUri cm_ = quantity?.SystemElement;
                string co_ = cm_?.Value;
                bool? cp_ = context.Operators.Equal(co_, "http://unitsofmeasure.org");
                bool? cq_ = context.Operators.Or((bool?)(cm_ is null), cp_);
                string cs_ = cm_?.Value;
                bool? ct_ = context.Operators.Equal(cs_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
                bool? cu_ = context.Operators.Or(cq_, ct_);

                return cu_ ?? false;
            };
            if (quantity is null)
            {
                return default;
            }
            else if (quantity?.ValueElement is null)
            {
                return default;
            }
            else if (cl_())
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

        return ck_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlRatio ToRatio(CqlContext context, Ratio ratio)
    {
        CqlRatio dp_()
        {
            if (ratio is null)
            {
                return default;
            }
            else
            {
                Quantity dq_ = ratio?.Numerator;
                CqlQuantity dr_ = this.ToQuantity(context, dq_);
                Quantity ds_ = ratio?.Denominator;
                CqlQuantity dt_ = this.ToQuantity(context, ds_);

                return new CqlRatio(dr_, dt_);
            }
        };

        return dp_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlCode ToCode(CqlContext context, Coding coding)
    {
        CqlCode du_()
        {
            if (coding is null)
            {
                return default;
            }
            else
            {
                Code dv_ = coding?.CodeElement;
                string dw_ = dv_?.Value;
                FhirUri dx_ = coding?.SystemElement;
                string dy_ = dx_?.Value;
                FhirString dz_ = coding?.VersionElement;
                string ea_ = dz_?.Value;
                FhirString eb_ = coding?.DisplayElement;
                string ec_ = eb_?.Value;

                return new CqlCode(dw_, dy_, ea_, ec_);
            }
        };

        return du_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlConcept ToConcept(CqlContext context, CodeableConcept concept)
    {
        CqlConcept ed_()
        {
            if (concept is null)
            {
                return default;
            }
            else
            {
                List<Coding> ee_ = concept?.Coding;
                CqlCode ef_(Coding C)
                {
                    CqlCode ek_ = this.ToCode(context, C);

                    return ek_;
                };
                IEnumerable<CqlCode> eg_ = context.Operators.Select<Coding, CqlCode>((IEnumerable<Coding>)ee_, ef_);
                IEnumerable<CqlCode> eh_ = context.Operators.Distinct<CqlCode>(eg_);
                FhirString ei_ = concept?.TextElement;
                string ej_ = ei_?.Value;

                return new CqlConcept(eh_, ej_);
            }
        };

        return ed_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Account.AccountStatus> value)
    {
        Account.AccountStatus? el_ = value?.Value;
        string em_ = context.Operators.Convert<string>(el_);

        return em_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionCardinalityBehavior> value)
    {
        ActionCardinalityBehavior? en_ = value?.Value;
        string eo_ = context.Operators.Convert<string>(en_);

        return eo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionConditionKind> value)
    {
        ActionConditionKind? ep_ = value?.Value;
        string eq_ = context.Operators.Convert<string>(ep_);

        return eq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionGroupingBehavior> value)
    {
        ActionGroupingBehavior? er_ = value?.Value;
        string es_ = context.Operators.Convert<string>(er_);

        return es_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionParticipantType> value)
    {
        ActionParticipantType? et_ = value?.Value;
        string eu_ = context.Operators.Convert<string>(et_);

        return eu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionPrecheckBehavior> value)
    {
        ActionPrecheckBehavior? ev_ = value?.Value;
        string ew_ = context.Operators.Convert<string>(ev_);

        return ew_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionRelationshipType> value)
    {
        ActionRelationshipType? ex_ = value?.Value;
        string ey_ = context.Operators.Convert<string>(ex_);

        return ey_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionRequiredBehavior> value)
    {
        ActionRequiredBehavior? ez_ = value?.Value;
        string fa_ = context.Operators.Convert<string>(ez_);

        return fa_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActionSelectionBehavior> value)
    {
        ActionSelectionBehavior? fb_ = value?.Value;
        string fc_ = context.Operators.Convert<string>(fb_);

        return fc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ActivityDefinition.RequestResourceType> value)
    {
        ActivityDefinition.RequestResourceType? fd_ = value?.Value;
        string fe_ = context.Operators.Convert<string>(fd_);

        return fe_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Address.AddressType> value)
    {
        Address.AddressType? ff_ = value?.Value;
        string fg_ = context.Operators.Convert<string>(ff_);

        return fg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Address.AddressUse> value)
    {
        Address.AddressUse? fh_ = value?.Value;
        string fi_ = context.Operators.Convert<string>(fh_);

        return fi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AdministrativeGender> value)
    {
        AdministrativeGender? fj_ = value?.Value;
        string fk_ = context.Operators.Convert<string>(fj_);

        return fk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AdverseEvent.AdverseEventActuality> value)
    {
        AdverseEvent.AdverseEventActuality? fl_ = value?.Value;
        string fm_ = context.Operators.Convert<string>(fl_);

        return fm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ElementDefinition.AggregationMode> value)
    {
        ElementDefinition.AggregationMode? fn_ = value?.Value;
        string fo_ = context.Operators.Convert<string>(fn_);

        return fo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
    {
        AllergyIntolerance.AllergyIntoleranceCategory? fp_ = value?.Value;
        string fq_ = context.Operators.Convert<string>(fp_);

        return fq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
    {
        AllergyIntolerance.AllergyIntoleranceCriticality? fr_ = value?.Value;
        string fs_ = context.Operators.Convert<string>(fr_);

        return fs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
    {
        AllergyIntolerance.AllergyIntoleranceSeverity? ft_ = value?.Value;
        string fu_ = context.Operators.Convert<string>(ft_);

        return fu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceType> value)
    {
        AllergyIntolerance.AllergyIntoleranceType? fv_ = value?.Value;
        string fw_ = context.Operators.Convert<string>(fv_);

        return fw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Appointment.AppointmentStatus> value)
    {
        Appointment.AppointmentStatus? fx_ = value?.Value;
        string fy_ = context.Operators.Convert<string>(fx_);

        return fy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestScript.AssertionDirectionType> value)
    {
        TestScript.AssertionDirectionType? fz_ = value?.Value;
        string ga_ = context.Operators.Convert<string>(fz_);

        return ga_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestScript.AssertionOperatorType> value)
    {
        TestScript.AssertionOperatorType? gb_ = value?.Value;
        string gc_ = context.Operators.Convert<string>(gb_);

        return gc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestScript.AssertionResponseTypes> value)
    {
        TestScript.AssertionResponseTypes? gd_ = value?.Value;
        string ge_ = context.Operators.Convert<string>(gd_);

        return ge_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAction> value)
    {
        AuditEvent.AuditEventAction? gf_ = value?.Value;
        string gg_ = context.Operators.Convert<string>(gf_);

        return gg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAgentNetworkType> value)
    {
        AuditEvent.AuditEventAgentNetworkType? gh_ = value?.Value;
        string gi_ = context.Operators.Convert<string>(gh_);

        return gi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventOutcome> value)
    {
        AuditEvent.AuditEventOutcome? gj_ = value?.Value;
        string gk_ = context.Operators.Convert<string>(gj_);

        return gk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<BindingStrength> value)
    {
        BindingStrength? gl_ = value?.Value;
        string gm_ = context.Operators.Convert<string>(gl_);

        return gm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? gn_ = value?.Value;
        string go_ = context.Operators.Convert<string>(gn_);

        return go_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? gp_ = value?.Value;
        string gq_ = context.Operators.Convert<string>(gp_);

        return gq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? gr_ = value?.Value;
        string gs_ = context.Operators.Convert<string>(gr_);

        return gs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Bundle.BundleType> value)
    {
        Bundle.BundleType? gt_ = value?.Value;
        string gu_ = context.Operators.Convert<string>(gt_);

        return gu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatementKind> value)
    {
        CapabilityStatementKind? gv_ = value?.Value;
        string gw_ = context.Operators.Convert<string>(gv_);

        return gw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityKind> value)
    {
        CarePlan.CarePlanActivityKind? gx_ = value?.Value;
        string gy_ = context.Operators.Convert<string>(gx_);

        return gy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityStatus> value)
    {
        CarePlan.CarePlanActivityStatus? gz_ = value?.Value;
        string ha_ = context.Operators.Convert<string>(gz_);

        return ha_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CarePlan.CarePlanIntent> value)
    {
        CarePlan.CarePlanIntent? hb_ = value?.Value;
        string hc_ = context.Operators.Convert<string>(hb_);

        return hc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<RequestStatus> value)
    {
        RequestStatus? hd_ = value?.Value;
        string he_ = context.Operators.Convert<string>(hd_);

        return he_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CareTeam.CareTeamStatus> value)
    {
        CareTeam.CareTeamStatus? hf_ = value?.Value;
        string hg_ = context.Operators.Convert<string>(hf_);

        return hg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CatalogEntry.CatalogEntryRelationType> value)
    {
        CatalogEntry.CatalogEntryRelationType? hh_ = value?.Value;
        string hi_ = context.Operators.Convert<string>(hh_);

        return hi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<InvoicePriceComponentType> value)
    {
        InvoicePriceComponentType? hj_ = value?.Value;
        string hk_ = context.Operators.Convert<string>(hj_);

        return hk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ChargeItem.ChargeItemStatus> value)
    {
        ChargeItem.ChargeItemStatus? hl_ = value?.Value;
        string hm_ = context.Operators.Convert<string>(hl_);

        return hm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<FinancialResourceStatusCodes> value)
    {
        FinancialResourceStatusCodes? hn_ = value?.Value;
        string ho_ = context.Operators.Convert<string>(hn_);

        return ho_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ClinicalImpression.ClinicalImpressionStatus> value)
    {
        ClinicalImpression.ClinicalImpressionStatus? hp_ = value?.Value;
        string hq_ = context.Operators.Convert<string>(hp_);

        return hq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TerminologyCapabilities.CodeSearchSupport> value)
    {
        TerminologyCapabilities.CodeSearchSupport? hr_ = value?.Value;
        string hs_ = context.Operators.Convert<string>(hr_);

        return hs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CodeSystemContentMode> value)
    {
        CodeSystemContentMode? ht_ = value?.Value;
        string hu_ = context.Operators.Convert<string>(ht_);

        return hu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CodeSystem.CodeSystemHierarchyMeaning> value)
    {
        CodeSystem.CodeSystemHierarchyMeaning? hv_ = value?.Value;
        string hw_ = context.Operators.Convert<string>(hv_);

        return hw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<RequestPriority> value)
    {
        RequestPriority? hx_ = value?.Value;
        string hy_ = context.Operators.Convert<string>(hx_);

        return hy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<EventStatus> value)
    {
        EventStatus? hz_ = value?.Value;
        string ia_ = context.Operators.Convert<string>(hz_);

        return ia_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CompartmentType> value)
    {
        CompartmentType? ib_ = value?.Value;
        string ic_ = context.Operators.Convert<string>(ib_);

        return ic_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Composition.CompositionAttestationMode> value)
    {
        Composition.CompositionAttestationMode? id_ = value?.Value;
        string ie_ = context.Operators.Convert<string>(id_);

        return ie_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CompositionStatus> value)
    {
        CompositionStatus? if_ = value?.Value;
        string ig_ = context.Operators.Convert<string>(if_);

        return ig_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ConceptMapEquivalence> value)
    {
        ConceptMapEquivalence? ih_ = value?.Value;
        string ii_ = context.Operators.Convert<string>(ih_);

        return ii_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
    {
        ConceptMap.ConceptMapGroupUnmappedMode? ij_ = value?.Value;
        string ik_ = context.Operators.Convert<string>(ij_);

        return ik_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalDeleteStatus> value)
    {
        CapabilityStatement.ConditionalDeleteStatus? il_ = value?.Value;
        string im_ = context.Operators.Convert<string>(il_);

        return im_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalReadStatus> value)
    {
        CapabilityStatement.ConditionalReadStatus? in_ = value?.Value;
        string io_ = context.Operators.Convert<string>(in_);

        return io_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Consent.ConsentDataMeaning> value)
    {
        Consent.ConsentDataMeaning? ip_ = value?.Value;
        string iq_ = context.Operators.Convert<string>(ip_);

        return iq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Consent.ConsentProvisionType> value)
    {
        Consent.ConsentProvisionType? ir_ = value?.Value;
        string is_ = context.Operators.Convert<string>(ir_);

        return is_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Consent.ConsentState> value)
    {
        Consent.ConsentState? it_ = value?.Value;
        string iu_ = context.Operators.Convert<string>(it_);

        return iu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ConstraintSeverity> value)
    {
        ConstraintSeverity? iv_ = value?.Value;
        string iw_ = context.Operators.Convert<string>(iv_);

        return iw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointSystem> value)
    {
        ContactPoint.ContactPointSystem? ix_ = value?.Value;
        string iy_ = context.Operators.Convert<string>(ix_);

        return iy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointUse> value)
    {
        ContactPoint.ContactPointUse? iz_ = value?.Value;
        string ja_ = context.Operators.Convert<string>(iz_);

        return ja_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Contract.ContractResourcePublicationStatusCodes> value)
    {
        Contract.ContractResourcePublicationStatusCodes? jb_ = value?.Value;
        string jc_ = context.Operators.Convert<string>(jb_);

        return jc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Contract.ContractResourceStatusCodes> value)
    {
        Contract.ContractResourceStatusCodes? jd_ = value?.Value;
        string je_ = context.Operators.Convert<string>(jd_);

        return je_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Contributor.ContributorType> value)
    {
        Contributor.ContributorType? jf_ = value?.Value;
        string jg_ = context.Operators.Convert<string>(jf_);

        return jg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Money.Currencies> value)
    {
        Money.Currencies? jh_ = value?.Value;
        string ji_ = context.Operators.Convert<string>(jh_);

        return ji_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DaysOfWeek> value)
    {
        DaysOfWeek? jj_ = value?.Value;
        string jk_ = context.Operators.Convert<string>(jj_);

        return jk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DetectedIssue.DetectedIssueSeverity> value)
    {
        DetectedIssue.DetectedIssueSeverity? jl_ = value?.Value;
        string jm_ = context.Operators.Convert<string>(jl_);

        return jm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ObservationStatus> value)
    {
        ObservationStatus? jn_ = value?.Value;
        string jo_ = context.Operators.Convert<string>(jn_);

        return jo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationState> value)
    {
        DeviceMetric.DeviceMetricCalibrationState? jp_ = value?.Value;
        string jq_ = context.Operators.Convert<string>(jp_);

        return jq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationType> value)
    {
        DeviceMetric.DeviceMetricCalibrationType? jr_ = value?.Value;
        string js_ = context.Operators.Convert<string>(jr_);

        return js_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCategory> value)
    {
        DeviceMetric.DeviceMetricCategory? jt_ = value?.Value;
        string ju_ = context.Operators.Convert<string>(jt_);

        return ju_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricColor> value)
    {
        DeviceMetric.DeviceMetricColor? jv_ = value?.Value;
        string jw_ = context.Operators.Convert<string>(jv_);

        return jw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricOperationalStatus> value)
    {
        DeviceMetric.DeviceMetricOperationalStatus? jx_ = value?.Value;
        string jy_ = context.Operators.Convert<string>(jx_);

        return jy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DeviceNameType> value)
    {
        DeviceNameType? jz_ = value?.Value;
        string ka_ = context.Operators.Convert<string>(jz_);

        return ka_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DeviceUseStatement.DeviceUseStatementStatus> value)
    {
        DeviceUseStatement.DeviceUseStatementStatus? kb_ = value?.Value;
        string kc_ = context.Operators.Convert<string>(kb_);

        return kc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DiagnosticReport.DiagnosticReportStatus> value)
    {
        DiagnosticReport.DiagnosticReportStatus? kd_ = value?.Value;
        string ke_ = context.Operators.Convert<string>(kd_);

        return ke_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ElementDefinition.DiscriminatorType> value)
    {
        ElementDefinition.DiscriminatorType? kf_ = value?.Value;
        string kg_ = context.Operators.Convert<string>(kf_);

        return kg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Composition.V3ConfidentialityClassification> value)
    {
        Composition.V3ConfidentialityClassification? kh_ = value?.Value;
        string ki_ = context.Operators.Convert<string>(kh_);

        return ki_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.DocumentMode> value)
    {
        CapabilityStatement.DocumentMode? kj_ = value?.Value;
        string kk_ = context.Operators.Convert<string>(kj_);

        return kk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DocumentReferenceStatus> value)
    {
        DocumentReferenceStatus? kl_ = value?.Value;
        string km_ = context.Operators.Convert<string>(kl_);

        return km_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DocumentRelationshipType> value)
    {
        DocumentRelationshipType? kn_ = value?.Value;
        string ko_ = context.Operators.Convert<string>(kn_);

        return ko_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
    {
        CoverageEligibilityRequest.EligibilityRequestPurpose? kp_ = value?.Value;
        string kq_ = context.Operators.Convert<string>(kp_);

        return kq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
    {
        CoverageEligibilityResponse.EligibilityResponsePurpose? kr_ = value?.Value;
        string ks_ = context.Operators.Convert<string>(kr_);

        return ks_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Questionnaire.EnableWhenBehavior> value)
    {
        Questionnaire.EnableWhenBehavior? kt_ = value?.Value;
        string ku_ = context.Operators.Convert<string>(kt_);

        return ku_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Encounter.EncounterLocationStatus> value)
    {
        Encounter.EncounterLocationStatus? kv_ = value?.Value;
        string kw_ = context.Operators.Convert<string>(kv_);

        return kw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Encounter.EncounterStatus> value)
    {
        Encounter.EncounterStatus? kx_ = value?.Value;
        string ky_ = context.Operators.Convert<string>(kx_);

        return ky_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Endpoint.EndpointStatus> value)
    {
        Endpoint.EndpointStatus? kz_ = value?.Value;
        string la_ = context.Operators.Convert<string>(kz_);

        return la_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<EpisodeOfCare.EpisodeOfCareStatus> value)
    {
        EpisodeOfCare.EpisodeOfCareStatus? lb_ = value?.Value;
        string lc_ = context.Operators.Convert<string>(lb_);

        return lc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.EventCapabilityMode> value)
    {
        CapabilityStatement.EventCapabilityMode? ld_ = value?.Value;
        string le_ = context.Operators.Convert<string>(ld_);

        return le_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Timing.EventTiming> value)
    {
        Timing.EventTiming? lf_ = value?.Value;
        string lg_ = context.Operators.Convert<string>(lf_);

        return lg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<VariableTypeCode> value)
    {
        VariableTypeCode? lh_ = value?.Value;
        string li_ = context.Operators.Convert<string>(lh_);

        return li_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ExampleScenario.ExampleScenarioActorType> value)
    {
        ExampleScenario.ExampleScenarioActorType? lj_ = value?.Value;
        string lk_ = context.Operators.Convert<string>(lj_);

        return lk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
    {
        ExplanationOfBenefit.ExplanationOfBenefitStatus? ll_ = value?.Value;
        string lm_ = context.Operators.Convert<string>(ll_);

        return lm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<EffectEvidenceSynthesis.ExposureStateCode> value)
    {
        EffectEvidenceSynthesis.ExposureStateCode? ln_ = value?.Value;
        string lo_ = context.Operators.Convert<string>(ln_);

        return lo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureDefinition.ExtensionContextType> value)
    {
        StructureDefinition.ExtensionContextType? lp_ = value?.Value;
        string lq_ = context.Operators.Convert<string>(lp_);

        return lq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<FHIRAllTypes> value)
    {
        FHIRAllTypes? lr_ = value?.Value;
        string ls_ = context.Operators.Convert<string>(lr_);

        return ls_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<FHIRDefinedType> value)
    {
        FHIRDefinedType? lt_ = value?.Value;
        string lu_ = context.Operators.Convert<string>(lt_);

        return lu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Device.FHIRDeviceStatus> value)
    {
        Device.FHIRDeviceStatus? lv_ = value?.Value;
        string lw_ = context.Operators.Convert<string>(lv_);

        return lw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ResourceType> value)
    {
        ResourceType? lx_ = value?.Value;
        string ly_ = context.Operators.Convert<string>(lx_);

        return ly_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Substance.FHIRSubstanceStatus> value)
    {
        Substance.FHIRSubstanceStatus? lz_ = value?.Value;
        string ma_ = context.Operators.Convert<string>(lz_);

        return ma_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<FHIRVersion> value)
    {
        FHIRVersion? mb_ = value?.Value;
        string mc_ = context.Operators.Convert<string>(mb_);

        return mc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<FamilyMemberHistory.FamilyHistoryStatus> value)
    {
        FamilyMemberHistory.FamilyHistoryStatus? md_ = value?.Value;
        string me_ = context.Operators.Convert<string>(md_);

        return me_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<FilterOperator> value)
    {
        FilterOperator? mf_ = value?.Value;
        string mg_ = context.Operators.Convert<string>(mf_);

        return mg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Flag.FlagStatus> value)
    {
        Flag.FlagStatus? mh_ = value?.Value;
        string mi_ = context.Operators.Convert<string>(mh_);

        return mi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Goal.GoalLifecycleStatus> value)
    {
        Goal.GoalLifecycleStatus? mj_ = value?.Value;
        string mk_ = context.Operators.Convert<string>(mj_);

        return mk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentRule> value)
    {
        GraphDefinition.GraphCompartmentRule? ml_ = value?.Value;
        string mm_ = context.Operators.Convert<string>(ml_);

        return mm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentUse> value)
    {
        GraphDefinition.GraphCompartmentUse? mn_ = value?.Value;
        string mo_ = context.Operators.Convert<string>(mn_);

        return mo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<GroupMeasureCode> value)
    {
        GroupMeasureCode? mp_ = value?.Value;
        string mq_ = context.Operators.Convert<string>(mp_);

        return mq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Group.GroupType> value)
    {
        Group.GroupType? mr_ = value?.Value;
        string ms_ = context.Operators.Convert<string>(mr_);

        return ms_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<GuidanceResponse.GuidanceResponseStatus> value)
    {
        GuidanceResponse.GuidanceResponseStatus? mt_ = value?.Value;
        string mu_ = context.Operators.Convert<string>(mt_);

        return mu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ImplementationGuide.GuidePageGeneration> value)
    {
        ImplementationGuide.GuidePageGeneration? mv_ = value?.Value;
        string mw_ = context.Operators.Convert<string>(mv_);

        return mw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ImplementationGuide.GuideParameterCode> value)
    {
        ImplementationGuide.GuideParameterCode? mx_ = value?.Value;
        string my_ = context.Operators.Convert<string>(mx_);

        return my_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Bundle.HTTPVerb> value)
    {
        Bundle.HTTPVerb? mz_ = value?.Value;
        string na_ = context.Operators.Convert<string>(mz_);

        return na_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Identifier.IdentifierUse> value)
    {
        Identifier.IdentifierUse? nb_ = value?.Value;
        string nc_ = context.Operators.Convert<string>(nb_);

        return nc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Person.IdentityAssuranceLevel> value)
    {
        Person.IdentityAssuranceLevel? nd_ = value?.Value;
        string ne_ = context.Operators.Convert<string>(nd_);

        return ne_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ImagingStudy.ImagingStudyStatus> value)
    {
        ImagingStudy.ImagingStudyStatus? nf_ = value?.Value;
        string ng_ = context.Operators.Convert<string>(nf_);

        return ng_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
    {
        ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? nh_ = value?.Value;
        string ni_ = context.Operators.Convert<string>(nh_);

        return ni_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Immunization.ImmunizationStatusCodes> value)
    {
        Immunization.ImmunizationStatusCodes? nj_ = value?.Value;
        string nk_ = context.Operators.Convert<string>(nj_);

        return nk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Invoice.InvoiceStatus> value)
    {
        Invoice.InvoiceStatus? nl_ = value?.Value;
        string nm_ = context.Operators.Convert<string>(nl_);

        return nm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<OperationOutcome.IssueSeverity> value)
    {
        OperationOutcome.IssueSeverity? nn_ = value?.Value;
        string no_ = context.Operators.Convert<string>(nn_);

        return no_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<OperationOutcome.IssueType> value)
    {
        OperationOutcome.IssueType? np_ = value?.Value;
        string nq_ = context.Operators.Convert<string>(np_);

        return nq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Patient.LinkType> value)
    {
        Patient.LinkType? nr_ = value?.Value;
        string ns_ = context.Operators.Convert<string>(nr_);

        return ns_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Linkage.LinkageType> value)
    {
        Linkage.LinkageType? nt_ = value?.Value;
        string nu_ = context.Operators.Convert<string>(nt_);

        return nu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ListMode> value)
    {
        ListMode? nv_ = value?.Value;
        string nw_ = context.Operators.Convert<string>(nv_);

        return nw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<List.ListStatus> value)
    {
        List.ListStatus? nx_ = value?.Value;
        string ny_ = context.Operators.Convert<string>(nx_);

        return ny_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Location.LocationMode> value)
    {
        Location.LocationMode? nz_ = value?.Value;
        string oa_ = context.Operators.Convert<string>(nz_);

        return oa_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Location.LocationStatus> value)
    {
        Location.LocationStatus? ob_ = value?.Value;
        string oc_ = context.Operators.Convert<string>(ob_);

        return oc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportStatus> value)
    {
        MeasureReport.MeasureReportStatus? od_ = value?.Value;
        string oe_ = context.Operators.Convert<string>(od_);

        return oe_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportType> value)
    {
        MeasureReport.MeasureReportType? of_ = value?.Value;
        string og_ = context.Operators.Convert<string>(of_);

        return og_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
    {
        MedicationAdministration.MedicationAdministrationStatusCodes? oh_ = value?.Value;
        string oi_ = context.Operators.Convert<string>(oh_);

        return oi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MedicationDispense.MedicationDispenseStatusCodes> value)
    {
        MedicationDispense.MedicationDispenseStatusCodes? oj_ = value?.Value;
        string ok_ = context.Operators.Convert<string>(oj_);

        return ok_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
    {
        MedicationKnowledge.MedicationKnowledgeStatusCodes? ol_ = value?.Value;
        string om_ = context.Operators.Convert<string>(ol_);

        return om_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationRequestIntent> value)
    {
        MedicationRequest.MedicationRequestIntent? on_ = value?.Value;
        string oo_ = context.Operators.Convert<string>(on_);

        return oo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationrequestStatus> value)
    {
        MedicationRequest.MedicationrequestStatus? op_ = value?.Value;
        string oq_ = context.Operators.Convert<string>(op_);

        return oq_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MedicationStatement.MedicationStatusCodes> value)
    {
        MedicationStatement.MedicationStatusCodes? or_ = value?.Value;
        string os_ = context.Operators.Convert<string>(or_);

        return os_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Medication.MedicationStatusCodes> value)
    {
        Medication.MedicationStatusCodes? ot_ = value?.Value;
        string ou_ = context.Operators.Convert<string>(ot_);

        return ou_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MessageDefinition.MessageSignificanceCategory> value)
    {
        MessageDefinition.MessageSignificanceCategory? ov_ = value?.Value;
        string ow_ = context.Operators.Convert<string>(ov_);

        return ow_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MessageheaderResponseRequest> value)
    {
        MessageheaderResponseRequest? ox_ = value?.Value;
        string oy_ = context.Operators.Convert<string>(ox_);

        return oy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code value)
    {
        string oz_ = value?.Value;

        return oz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<HumanName.NameUse> value)
    {
        HumanName.NameUse? pa_ = value?.Value;
        string pb_ = context.Operators.Convert<string>(pa_);

        return pb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemIdentifierType> value)
    {
        NamingSystem.NamingSystemIdentifierType? pc_ = value?.Value;
        string pd_ = context.Operators.Convert<string>(pc_);

        return pd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemType> value)
    {
        NamingSystem.NamingSystemType? pe_ = value?.Value;
        string pf_ = context.Operators.Convert<string>(pe_);

        return pf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Narrative.NarrativeStatus> value)
    {
        Narrative.NarrativeStatus? pg_ = value?.Value;
        string ph_ = context.Operators.Convert<string>(pg_);

        return ph_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<NoteType> value)
    {
        NoteType? pi_ = value?.Value;
        string pj_ = context.Operators.Convert<string>(pi_);

        return pj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<RequestIntent> value)
    {
        RequestIntent? pk_ = value?.Value;
        string pl_ = context.Operators.Convert<string>(pk_);

        return pl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationDataType> value)
    {
        ObservationDefinition.ObservationDataType? pm_ = value?.Value;
        string pn_ = context.Operators.Convert<string>(pm_);

        return pn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationRangeCategory> value)
    {
        ObservationDefinition.ObservationRangeCategory? po_ = value?.Value;
        string pp_ = context.Operators.Convert<string>(po_);

        return pp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<OperationDefinition.OperationKind> value)
    {
        OperationDefinition.OperationKind? pq_ = value?.Value;
        string pr_ = context.Operators.Convert<string>(pq_);

        return pr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<OperationParameterUse> value)
    {
        OperationParameterUse? ps_ = value?.Value;
        string pt_ = context.Operators.Convert<string>(ps_);

        return pt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MolecularSequence.OrientationType> value)
    {
        MolecularSequence.OrientationType? pu_ = value?.Value;
        string pv_ = context.Operators.Convert<string>(pu_);

        return pv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Appointment.ParticipantRequired> value)
    {
        Appointment.ParticipantRequired? pw_ = value?.Value;
        string px_ = context.Operators.Convert<string>(pw_);

        return px_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ParticipationStatus> value)
    {
        ParticipationStatus? py_ = value?.Value;
        string pz_ = context.Operators.Convert<string>(py_);

        return pz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ElementDefinition.PropertyRepresentation> value)
    {
        ElementDefinition.PropertyRepresentation? qa_ = value?.Value;
        string qb_ = context.Operators.Convert<string>(qa_);

        return qb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CodeSystem.PropertyType> value)
    {
        CodeSystem.PropertyType? qc_ = value?.Value;
        string qd_ = context.Operators.Convert<string>(qc_);

        return qd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Provenance.ProvenanceEntityRole> value)
    {
        Provenance.ProvenanceEntityRole? qe_ = value?.Value;
        string qf_ = context.Operators.Convert<string>(qe_);

        return qf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<PublicationStatus> value)
    {
        PublicationStatus? qg_ = value?.Value;
        string qh_ = context.Operators.Convert<string>(qg_);

        return qh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MolecularSequence.QualityType> value)
    {
        MolecularSequence.QualityType? qi_ = value?.Value;
        string qj_ = context.Operators.Convert<string>(qi_);

        return qj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Quantity.QuantityComparator> value)
    {
        Quantity.QuantityComparator? qk_ = value?.Value;
        string ql_ = context.Operators.Convert<string>(qk_);

        return ql_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemOperator> value)
    {
        Questionnaire.QuestionnaireItemOperator? qm_ = value?.Value;
        string qn_ = context.Operators.Convert<string>(qm_);

        return qn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemType> value)
    {
        Questionnaire.QuestionnaireItemType? qo_ = value?.Value;
        string qp_ = context.Operators.Convert<string>(qo_);

        return qp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
    {
        QuestionnaireResponse.QuestionnaireResponseStatus? qq_ = value?.Value;
        string qr_ = context.Operators.Convert<string>(qq_);

        return qr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.ReferenceHandlingPolicy> value)
    {
        CapabilityStatement.ReferenceHandlingPolicy? qs_ = value?.Value;
        string qt_ = context.Operators.Convert<string>(qs_);

        return qt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ElementDefinition.ReferenceVersionRules> value)
    {
        ElementDefinition.ReferenceVersionRules? qu_ = value?.Value;
        string qv_ = context.Operators.Convert<string>(qu_);

        return qv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<RelatedArtifact.RelatedArtifactType> value)
    {
        RelatedArtifact.RelatedArtifactType? qw_ = value?.Value;
        string qx_ = context.Operators.Convert<string>(qw_);

        return qx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ClaimProcessingCodes> value)
    {
        ClaimProcessingCodes? qy_ = value?.Value;
        string qz_ = context.Operators.Convert<string>(qy_);

        return qz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MolecularSequence.RepositoryType> value)
    {
        MolecularSequence.RepositoryType? ra_ = value?.Value;
        string rb_ = context.Operators.Convert<string>(ra_);

        return rb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ResearchElementDefinition.ResearchElementType> value)
    {
        ResearchElementDefinition.ResearchElementType? rc_ = value?.Value;
        string rd_ = context.Operators.Convert<string>(rc_);

        return rd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ResearchStudy.ResearchStudyStatus> value)
    {
        ResearchStudy.ResearchStudyStatus? re_ = value?.Value;
        string rf_ = context.Operators.Convert<string>(re_);

        return rf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ResearchSubject.ResearchSubjectStatus> value)
    {
        ResearchSubject.ResearchSubjectStatus? rg_ = value?.Value;
        string rh_ = context.Operators.Convert<string>(rg_);

        return rh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.ResourceVersionPolicy> value)
    {
        CapabilityStatement.ResourceVersionPolicy? ri_ = value?.Value;
        string rj_ = context.Operators.Convert<string>(ri_);

        return rj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MessageHeader.ResponseType> value)
    {
        MessageHeader.ResponseType? rk_ = value?.Value;
        string rl_ = context.Operators.Convert<string>(rk_);

        return rl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.RestfulCapabilityMode> value)
    {
        CapabilityStatement.RestfulCapabilityMode? rm_ = value?.Value;
        string rn_ = context.Operators.Convert<string>(rm_);

        return rn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ImplementationGuide.SPDXLicense> value)
    {
        ImplementationGuide.SPDXLicense? ro_ = value?.Value;
        string rp_ = context.Operators.Convert<string>(ro_);

        return rp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<SearchParameter.SearchComparator> value)
    {
        SearchParameter.SearchComparator? rq_ = value?.Value;
        string rr_ = context.Operators.Convert<string>(rq_);

        return rr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Bundle.SearchEntryMode> value)
    {
        Bundle.SearchEntryMode? rs_ = value?.Value;
        string rt_ = context.Operators.Convert<string>(rs_);

        return rt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<SearchParameter.SearchModifierCode> value)
    {
        SearchParameter.SearchModifierCode? ru_ = value?.Value;
        string rv_ = context.Operators.Convert<string>(ru_);

        return rv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<SearchParamType> value)
    {
        SearchParamType? rw_ = value?.Value;
        string rx_ = context.Operators.Convert<string>(rw_);

        return rx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MolecularSequence.SequenceType> value)
    {
        MolecularSequence.SequenceType? ry_ = value?.Value;
        string rz_ = context.Operators.Convert<string>(ry_);

        return rz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ElementDefinition.SlicingRules> value)
    {
        ElementDefinition.SlicingRules? sa_ = value?.Value;
        string sb_ = context.Operators.Convert<string>(sa_);

        return sb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Slot.SlotStatus> value)
    {
        Slot.SlotStatus? sc_ = value?.Value;
        string sd_ = context.Operators.Convert<string>(sc_);

        return sd_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<DataRequirement.SortDirection> value)
    {
        DataRequirement.SortDirection? se_ = value?.Value;
        string sf_ = context.Operators.Convert<string>(se_);

        return sf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<SpecimenDefinition.SpecimenContainedPreference> value)
    {
        SpecimenDefinition.SpecimenContainedPreference? sg_ = value?.Value;
        string sh_ = context.Operators.Convert<string>(sg_);

        return sh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Specimen.SpecimenStatus> value)
    {
        Specimen.SpecimenStatus? si_ = value?.Value;
        string sj_ = context.Operators.Convert<string>(si_);

        return sj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<VerificationResult.StatusCode> value)
    {
        VerificationResult.StatusCode? sk_ = value?.Value;
        string sl_ = context.Operators.Convert<string>(sk_);

        return sl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<MolecularSequence.StrandType> value)
    {
        MolecularSequence.StrandType? sm_ = value?.Value;
        string sn_ = context.Operators.Convert<string>(sm_);

        return sn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureDefinition.StructureDefinitionKind> value)
    {
        StructureDefinition.StructureDefinitionKind? so_ = value?.Value;
        string sp_ = context.Operators.Convert<string>(so_);

        return sp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureMap.StructureMapContextType> value)
    {
        StructureMap.StructureMapContextType? sq_ = value?.Value;
        string sr_ = context.Operators.Convert<string>(sq_);

        return sr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureMap.StructureMapGroupTypeMode> value)
    {
        StructureMap.StructureMapGroupTypeMode? ss_ = value?.Value;
        string st_ = context.Operators.Convert<string>(ss_);

        return st_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureMap.StructureMapInputMode> value)
    {
        StructureMap.StructureMapInputMode? su_ = value?.Value;
        string sv_ = context.Operators.Convert<string>(su_);

        return sv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureMap.StructureMapModelMode> value)
    {
        StructureMap.StructureMapModelMode? sw_ = value?.Value;
        string sx_ = context.Operators.Convert<string>(sw_);

        return sx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureMap.StructureMapSourceListMode> value)
    {
        StructureMap.StructureMapSourceListMode? sy_ = value?.Value;
        string sz_ = context.Operators.Convert<string>(sy_);

        return sz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTargetListMode> value)
    {
        StructureMap.StructureMapTargetListMode? ta_ = value?.Value;
        string tb_ = context.Operators.Convert<string>(ta_);

        return tb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTransform> value)
    {
        StructureMap.StructureMapTransform? tc_ = value?.Value;
        string td_ = context.Operators.Convert<string>(tc_);

        return td_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Subscription.SubscriptionChannelType> value)
    {
        Subscription.SubscriptionChannelType? te_ = value?.Value;
        string tf_ = context.Operators.Convert<string>(te_);

        return tf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Subscription.SubscriptionStatus> value)
    {
        Subscription.SubscriptionStatus? tg_ = value?.Value;
        string th_ = context.Operators.Convert<string>(tg_);

        return th_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<SupplyDelivery.SupplyDeliveryStatus> value)
    {
        SupplyDelivery.SupplyDeliveryStatus? ti_ = value?.Value;
        string tj_ = context.Operators.Convert<string>(ti_);

        return tj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<SupplyRequest.SupplyRequestStatus> value)
    {
        SupplyRequest.SupplyRequestStatus? tk_ = value?.Value;
        string tl_ = context.Operators.Convert<string>(tk_);

        return tl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.SystemRestfulInteraction> value)
    {
        CapabilityStatement.SystemRestfulInteraction? tm_ = value?.Value;
        string tn_ = context.Operators.Convert<string>(tm_);

        return tn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Task.TaskIntent> value)
    {
        Task.TaskIntent? to_ = value?.Value;
        string tp_ = context.Operators.Convert<string>(to_);

        return tp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Task.TaskStatus> value)
    {
        Task.TaskStatus? tq_ = value?.Value;
        string tr_ = context.Operators.Convert<string>(tq_);

        return tr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestReport.TestReportActionResult> value)
    {
        TestReport.TestReportActionResult? ts_ = value?.Value;
        string tt_ = context.Operators.Convert<string>(ts_);

        return tt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestReport.TestReportParticipantType> value)
    {
        TestReport.TestReportParticipantType? tu_ = value?.Value;
        string tv_ = context.Operators.Convert<string>(tu_);

        return tv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestReport.TestReportResult> value)
    {
        TestReport.TestReportResult? tw_ = value?.Value;
        string tx_ = context.Operators.Convert<string>(tw_);

        return tx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestReport.TestReportStatus> value)
    {
        TestReport.TestReportStatus? ty_ = value?.Value;
        string tz_ = context.Operators.Convert<string>(ty_);

        return tz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TestScript.TestScriptRequestMethodCode> value)
    {
        TestScript.TestScriptRequestMethodCode? ua_ = value?.Value;
        string ub_ = context.Operators.Convert<string>(ua_);

        return ub_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<TriggerDefinition.TriggerType> value)
    {
        TriggerDefinition.TriggerType? uc_ = value?.Value;
        string ud_ = context.Operators.Convert<string>(uc_);

        return ud_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<StructureDefinition.TypeDerivationRule> value)
    {
        StructureDefinition.TypeDerivationRule? ue_ = value?.Value;
        string uf_ = context.Operators.Convert<string>(ue_);

        return uf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<CapabilityStatement.TypeRestfulInteraction> value)
    {
        CapabilityStatement.TypeRestfulInteraction? ug_ = value?.Value;
        string uh_ = context.Operators.Convert<string>(ug_);

        return uh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Device.UDIEntryType> value)
    {
        Device.UDIEntryType? ui_ = value?.Value;
        string uj_ = context.Operators.Convert<string>(ui_);

        return uj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<Timing.UnitsOfTime> value)
    {
        Timing.UnitsOfTime? uk_ = value?.Value;
        string ul_ = context.Operators.Convert<string>(uk_);

        return ul_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<ClaimUseCode> value)
    {
        ClaimUseCode? um_ = value?.Value;
        string un_ = context.Operators.Convert<string>(um_);

        return un_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<VisionPrescription.VisionBase> value)
    {
        VisionPrescription.VisionBase? uo_ = value?.Value;
        string up_ = context.Operators.Convert<string>(uo_);

        return up_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<VisionPrescription.VisionEyes> value)
    {
        VisionPrescription.VisionEyes? uq_ = value?.Value;
        string ur_ = context.Operators.Convert<string>(uq_);

        return ur_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Code<SearchParameter.XPathUsageType> value)
    {
        SearchParameter.XPathUsageType? us_ = value?.Value;
        string ut_ = context.Operators.Convert<string>(us_);

        return ut_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, Base64Binary value)
    {
        byte[] uu_ = value?.Value;
        string uv_ = context.Operators.Convert<string>(uu_);

        return uv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, FhirString value)
    {
        string uw_ = value?.Value;

        return uw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, FhirUri value)
    {
        string ux_ = value?.Value;

        return ux_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string ToString(CqlContext context, XHtml value)
    {
        string uy_ = value?.Value;

        return uy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? ToBoolean(CqlContext context, FhirBoolean value)
    {
        bool? uz_ = value?.Value;

        return uz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDate ToDate(CqlContext context, Date value)
    {
        string va_ = value?.Value;
        CqlDate vb_ = context.Operators.ConvertStringToDate(va_);

        return vb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime ToDateTime(CqlContext context, FhirDateTime value)
    {
        CqlDateTime vc_ = context.Operators.Convert<CqlDateTime>(value);

        return vc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime ToDateTime(CqlContext context, Instant value)
    {
        DateTimeOffset? vd_ = value?.Value;
        CqlDateTime ve_ = context.Operators.Convert<CqlDateTime>(vd_);

        return ve_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public decimal? ToDecimal(CqlContext context, FhirDecimal value)
    {
        decimal? vf_ = value?.Value;

        return vf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public int? ToInteger(CqlContext context, Integer value)
    {
        int? vg_ = value?.Value;

        return vg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlTime ToTime(CqlContext context, Time value)
    {
        string vh_ = value?.Value;
        CqlTime vi_ = context.Operators.ConvertStringToTime(vh_);

        return vi_;
    }


    #endregion Expressions

}

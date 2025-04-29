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


    [CqlExpressionDefinition("ToInterval")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Quantity quantity)
    {
        CqlInterval<CqlQuantity> l_()
        {
            if (quantity is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {
                CqlInterval<CqlQuantity> m_()
                {
                    bool n_()
                    {
                        Code<Quantity.QuantityComparator> r_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? s_ = r_?.Value;
                        string t_ = context.Operators.Convert<string>(s_);
                        bool? u_ = context.Operators.Equal(t_, "<");

                        return u_ ?? false;
                    };
                    bool o_()
                    {
                        Code<Quantity.QuantityComparator> v_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? w_ = v_?.Value;
                        string x_ = context.Operators.Convert<string>(w_);
                        bool? y_ = context.Operators.Equal(x_, "<=");

                        return y_ ?? false;
                    };
                    bool p_()
                    {
                        Code<Quantity.QuantityComparator> z_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? aa_ = z_?.Value;
                        string ab_ = context.Operators.Convert<string>(aa_);
                        bool? ac_ = context.Operators.Equal(ab_, ">=");

                        return ac_ ?? false;
                    };
                    bool q_()
                    {
                        Code<Quantity.QuantityComparator> ad_ = quantity?.ComparatorElement;
                        Quantity.QuantityComparator? ae_ = ad_?.Value;
                        string af_ = context.Operators.Convert<string>(ae_);
                        bool? ag_ = context.Operators.Equal(af_, ">");

                        return ag_ ?? false;
                    };
                    if (n_())
                    {
                        CqlQuantity ah_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> ai_ = context.Operators.Interval(default, ah_, true, false);

                        return ai_;
                    }
                    else if (o_())
                    {
                        CqlQuantity aj_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> ak_ = context.Operators.Interval(default, aj_, true, true);

                        return ak_;
                    }
                    else if (p_())
                    {
                        CqlQuantity al_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> am_ = context.Operators.Interval(al_, default, true, true);

                        return am_;
                    }
                    else if (q_())
                    {
                        CqlQuantity an_ = this.ToQuantityIgnoringComparator(context, quantity);
                        CqlInterval<CqlQuantity> ao_ = context.Operators.Interval(an_, default, false, true);

                        return ao_;
                    }
                    else
                    {
                        CqlQuantity ap_ = this.ToQuantity(context, quantity);
                        CqlInterval<CqlQuantity> ar_ = context.Operators.Interval(ap_, ap_, true, true);

                        return ar_;
                    }
                };

                return m_();
            }
        };

        return l_();
    }


    [CqlExpressionDefinition("ToInterval")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Range range)
    {
        CqlInterval<CqlQuantity> as_()
        {
            if (range is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {
                Quantity at_ = range?.Low;
                CqlQuantity au_ = this.ToQuantity(context, at_);
                Quantity av_ = range?.High;
                CqlQuantity aw_ = this.ToQuantity(context, av_);
                CqlInterval<CqlQuantity> ax_ = context.Operators.Interval(au_, aw_, true, true);

                return ax_;
            }
        };

        return as_();
    }


    [CqlExpressionDefinition("ToCalendarUnit")]
    public string ToCalendarUnit(CqlContext context, string unit)
    {
        string ay_()
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

        return ay_();
    }


    [CqlExpressionDefinition("ToQuantity")]
    public CqlQuantity ToQuantity(CqlContext context, Quantity quantity)
    {
        CqlQuantity az_()
        {
            bool ba_()
            {
                Code<Quantity.QuantityComparator> bc_ = quantity?.ComparatorElement;
                bool? bd_ = context.Operators.Not((bool?)(bc_ is null));

                return bd_ ?? false;
            };
            bool bb_()
            {
                FhirUri be_ = quantity?.SystemElement;
                string bg_ = be_?.Value;
                bool? bh_ = context.Operators.Equal(bg_, "http://unitsofmeasure.org");
                bool? bi_ = context.Operators.Or((bool?)(be_ is null), bh_);
                string bk_ = be_?.Value;
                bool? bl_ = context.Operators.Equal(bk_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
                bool? bm_ = context.Operators.Or(bi_, bl_);

                return bm_ ?? false;
            };
            if (quantity is null)
            {
                return default;
            }
            else if (quantity?.ValueElement is null)
            {
                return default;
            }
            else if (ba_())
            {
                object bn_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.ComparatorQuantityNotSupported", "Error", "FHIR Quantity value has a comparator and cannot be converted to a System.Quantity value.");

                return bn_ as CqlQuantity;
            }
            else if (bb_())
            {
                FhirDecimal bo_ = quantity?.ValueElement;
                decimal? bp_ = bo_?.Value;
                Code bq_ = quantity?.CodeElement;
                string br_ = bq_?.Value;
                FhirString bs_ = quantity?.UnitElement;
                string bt_ = bs_?.Value;
                string bu_ = this.ToCalendarUnit(context, (br_ ?? bt_) ?? "1");

                return new CqlQuantity(bp_, bu_);
            }
            else
            {
                FhirString bv_ = quantity?.UnitElement;
                string bw_ = bv_?.Value;
                string bx_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", bw_ ?? "");
                string by_ = context.Operators.Concatenate(bx_ ?? "", " (");
                FhirUri bz_ = quantity?.SystemElement;
                string ca_ = bz_?.Value;
                string cb_ = context.Operators.Concatenate(by_ ?? "", ca_ ?? "");
                string cc_ = context.Operators.Concatenate(cb_ ?? "", "|");
                Code cd_ = quantity?.CodeElement;
                string ce_ = cd_?.Value;
                string cf_ = context.Operators.Concatenate(cc_ ?? "", ce_ ?? "");
                string cg_ = context.Operators.Concatenate(cf_ ?? "", ")");
                object ch_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", cg_);

                return ch_ as CqlQuantity;
            }
        };

        return az_();
    }


    [CqlExpressionDefinition("ToQuantityIgnoringComparator")]
    public CqlQuantity ToQuantityIgnoringComparator(CqlContext context, Quantity quantity)
    {
        CqlQuantity ci_()
        {
            bool cj_()
            {
                FhirUri ck_ = quantity?.SystemElement;
                string cm_ = ck_?.Value;
                bool? cn_ = context.Operators.Equal(cm_, "http://unitsofmeasure.org");
                bool? co_ = context.Operators.Or((bool?)(ck_ is null), cn_);
                string cq_ = ck_?.Value;
                bool? cr_ = context.Operators.Equal(cq_, "http://hl7.org/fhirpath/CodeSystem/calendar-units");
                bool? cs_ = context.Operators.Or(co_, cr_);

                return cs_ ?? false;
            };
            if (quantity is null)
            {
                return default;
            }
            else if (quantity?.ValueElement is null)
            {
                return default;
            }
            else if (cj_())
            {
                FhirDecimal ct_ = quantity?.ValueElement;
                decimal? cu_ = ct_?.Value;
                Code cv_ = quantity?.CodeElement;
                string cw_ = cv_?.Value;
                FhirString cx_ = quantity?.UnitElement;
                string cy_ = cx_?.Value;
                string cz_ = this.ToCalendarUnit(context, (cw_ ?? cy_) ?? "1");

                return new CqlQuantity(cu_, cz_);
            }
            else
            {
                FhirString da_ = quantity?.UnitElement;
                string db_ = da_?.Value;
                string dc_ = context.Operators.Concatenate("Invalid FHIR Quantity code: ", db_ ?? "");
                string dd_ = context.Operators.Concatenate(dc_ ?? "", " (");
                FhirUri de_ = quantity?.SystemElement;
                string df_ = de_?.Value;
                string dg_ = context.Operators.Concatenate(dd_ ?? "", df_ ?? "");
                string dh_ = context.Operators.Concatenate(dg_ ?? "", "|");
                Code di_ = quantity?.CodeElement;
                string dj_ = di_?.Value;
                string dk_ = context.Operators.Concatenate(dh_ ?? "", dj_ ?? "");
                string dl_ = context.Operators.Concatenate(dk_ ?? "", ")");
                object dm_ = context.Operators.Message<object>(null, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity", "Error", dl_);

                return dm_ as CqlQuantity;
            }
        };

        return ci_();
    }


    [CqlExpressionDefinition("ToRatio")]
    public CqlRatio ToRatio(CqlContext context, Ratio ratio)
    {
        CqlRatio dn_()
        {
            if (ratio is null)
            {
                return default;
            }
            else
            {
                Quantity do_ = ratio?.Numerator;
                CqlQuantity dp_ = this.ToQuantity(context, do_);
                Quantity dq_ = ratio?.Denominator;
                CqlQuantity dr_ = this.ToQuantity(context, dq_);

                return new CqlRatio(dp_, dr_);
            }
        };

        return dn_();
    }


    [CqlExpressionDefinition("ToCode")]
    public CqlCode ToCode(CqlContext context, Coding coding)
    {
        CqlCode ds_()
        {
            if (coding is null)
            {
                return default;
            }
            else
            {
                Code dt_ = coding?.CodeElement;
                string du_ = dt_?.Value;
                FhirUri dv_ = coding?.SystemElement;
                string dw_ = dv_?.Value;
                FhirString dx_ = coding?.VersionElement;
                string dy_ = dx_?.Value;
                FhirString dz_ = coding?.DisplayElement;
                string ea_ = dz_?.Value;

                return new CqlCode(du_, dw_, dy_, ea_);
            }
        };

        return ds_();
    }


    [CqlExpressionDefinition("ToConcept")]
    public CqlConcept ToConcept(CqlContext context, CodeableConcept concept)
    {
        CqlConcept eb_()
        {
            if (concept is null)
            {
                return default;
            }
            else
            {
                List<Coding> ec_ = concept?.Coding;
                CqlCode ed_(Coding C)
                {
                    CqlCode ei_ = this.ToCode(context, C);

                    return ei_;
                };
                IEnumerable<CqlCode> ee_ = context.Operators.Select<Coding, CqlCode>((IEnumerable<Coding>)ec_, ed_);
                IEnumerable<CqlCode> ef_ = context.Operators.Distinct<CqlCode>(ee_);
                FhirString eg_ = concept?.TextElement;
                string eh_ = eg_?.Value;

                return new CqlConcept(ef_, eh_);
            }
        };

        return eb_();
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Account.AccountStatus> value)
    {
        Account.AccountStatus? ej_ = value?.Value;
        string ek_ = context.Operators.Convert<string>(ej_);

        return ek_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionCardinalityBehavior> value)
    {
        ActionCardinalityBehavior? el_ = value?.Value;
        string em_ = context.Operators.Convert<string>(el_);

        return em_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionConditionKind> value)
    {
        ActionConditionKind? en_ = value?.Value;
        string eo_ = context.Operators.Convert<string>(en_);

        return eo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionGroupingBehavior> value)
    {
        ActionGroupingBehavior? ep_ = value?.Value;
        string eq_ = context.Operators.Convert<string>(ep_);

        return eq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionParticipantType> value)
    {
        ActionParticipantType? er_ = value?.Value;
        string es_ = context.Operators.Convert<string>(er_);

        return es_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionPrecheckBehavior> value)
    {
        ActionPrecheckBehavior? et_ = value?.Value;
        string eu_ = context.Operators.Convert<string>(et_);

        return eu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionRelationshipType> value)
    {
        ActionRelationshipType? ev_ = value?.Value;
        string ew_ = context.Operators.Convert<string>(ev_);

        return ew_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionRequiredBehavior> value)
    {
        ActionRequiredBehavior? ex_ = value?.Value;
        string ey_ = context.Operators.Convert<string>(ex_);

        return ey_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionSelectionBehavior> value)
    {
        ActionSelectionBehavior? ez_ = value?.Value;
        string fa_ = context.Operators.Convert<string>(ez_);

        return fa_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActivityDefinition.RequestResourceType> value)
    {
        ActivityDefinition.RequestResourceType? fb_ = value?.Value;
        string fc_ = context.Operators.Convert<string>(fb_);

        return fc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Address.AddressType> value)
    {
        Address.AddressType? fd_ = value?.Value;
        string fe_ = context.Operators.Convert<string>(fd_);

        return fe_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Address.AddressUse> value)
    {
        Address.AddressUse? ff_ = value?.Value;
        string fg_ = context.Operators.Convert<string>(ff_);

        return fg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AdministrativeGender> value)
    {
        AdministrativeGender? fh_ = value?.Value;
        string fi_ = context.Operators.Convert<string>(fh_);

        return fi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AdverseEvent.AdverseEventActuality> value)
    {
        AdverseEvent.AdverseEventActuality? fj_ = value?.Value;
        string fk_ = context.Operators.Convert<string>(fj_);

        return fk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.AggregationMode> value)
    {
        ElementDefinition.AggregationMode? fl_ = value?.Value;
        string fm_ = context.Operators.Convert<string>(fl_);

        return fm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
    {
        AllergyIntolerance.AllergyIntoleranceCategory? fn_ = value?.Value;
        string fo_ = context.Operators.Convert<string>(fn_);

        return fo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
    {
        AllergyIntolerance.AllergyIntoleranceCriticality? fp_ = value?.Value;
        string fq_ = context.Operators.Convert<string>(fp_);

        return fq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
    {
        AllergyIntolerance.AllergyIntoleranceSeverity? fr_ = value?.Value;
        string fs_ = context.Operators.Convert<string>(fr_);

        return fs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceType> value)
    {
        AllergyIntolerance.AllergyIntoleranceType? ft_ = value?.Value;
        string fu_ = context.Operators.Convert<string>(ft_);

        return fu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Appointment.AppointmentStatus> value)
    {
        Appointment.AppointmentStatus? fv_ = value?.Value;
        string fw_ = context.Operators.Convert<string>(fv_);

        return fw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionDirectionType> value)
    {
        TestScript.AssertionDirectionType? fx_ = value?.Value;
        string fy_ = context.Operators.Convert<string>(fx_);

        return fy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionOperatorType> value)
    {
        TestScript.AssertionOperatorType? fz_ = value?.Value;
        string ga_ = context.Operators.Convert<string>(fz_);

        return ga_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionResponseTypes> value)
    {
        TestScript.AssertionResponseTypes? gb_ = value?.Value;
        string gc_ = context.Operators.Convert<string>(gb_);

        return gc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAction> value)
    {
        AuditEvent.AuditEventAction? gd_ = value?.Value;
        string ge_ = context.Operators.Convert<string>(gd_);

        return ge_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAgentNetworkType> value)
    {
        AuditEvent.AuditEventAgentNetworkType? gf_ = value?.Value;
        string gg_ = context.Operators.Convert<string>(gf_);

        return gg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventOutcome> value)
    {
        AuditEvent.AuditEventOutcome? gh_ = value?.Value;
        string gi_ = context.Operators.Convert<string>(gh_);

        return gi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BindingStrength> value)
    {
        BindingStrength? gj_ = value?.Value;
        string gk_ = context.Operators.Convert<string>(gj_);

        return gk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? gl_ = value?.Value;
        string gm_ = context.Operators.Convert<string>(gl_);

        return gm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? gn_ = value?.Value;
        string go_ = context.Operators.Convert<string>(gn_);

        return go_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? gp_ = value?.Value;
        string gq_ = context.Operators.Convert<string>(gp_);

        return gq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.BundleType> value)
    {
        Bundle.BundleType? gr_ = value?.Value;
        string gs_ = context.Operators.Convert<string>(gr_);

        return gs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatementKind> value)
    {
        CapabilityStatementKind? gt_ = value?.Value;
        string gu_ = context.Operators.Convert<string>(gt_);

        return gu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityKind> value)
    {
        CarePlan.CarePlanActivityKind? gv_ = value?.Value;
        string gw_ = context.Operators.Convert<string>(gv_);

        return gw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityStatus> value)
    {
        CarePlan.CarePlanActivityStatus? gx_ = value?.Value;
        string gy_ = context.Operators.Convert<string>(gx_);

        return gy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanIntent> value)
    {
        CarePlan.CarePlanIntent? gz_ = value?.Value;
        string ha_ = context.Operators.Convert<string>(gz_);

        return ha_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestStatus> value)
    {
        RequestStatus? hb_ = value?.Value;
        string hc_ = context.Operators.Convert<string>(hb_);

        return hc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CareTeam.CareTeamStatus> value)
    {
        CareTeam.CareTeamStatus? hd_ = value?.Value;
        string he_ = context.Operators.Convert<string>(hd_);

        return he_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CatalogEntry.CatalogEntryRelationType> value)
    {
        CatalogEntry.CatalogEntryRelationType? hf_ = value?.Value;
        string hg_ = context.Operators.Convert<string>(hf_);

        return hg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<InvoicePriceComponentType> value)
    {
        InvoicePriceComponentType? hh_ = value?.Value;
        string hi_ = context.Operators.Convert<string>(hh_);

        return hi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ChargeItem.ChargeItemStatus> value)
    {
        ChargeItem.ChargeItemStatus? hj_ = value?.Value;
        string hk_ = context.Operators.Convert<string>(hj_);

        return hk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FinancialResourceStatusCodes> value)
    {
        FinancialResourceStatusCodes? hl_ = value?.Value;
        string hm_ = context.Operators.Convert<string>(hl_);

        return hm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClinicalImpression.ClinicalImpressionStatus> value)
    {
        ClinicalImpression.ClinicalImpressionStatus? hn_ = value?.Value;
        string ho_ = context.Operators.Convert<string>(hn_);

        return ho_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TerminologyCapabilities.CodeSearchSupport> value)
    {
        TerminologyCapabilities.CodeSearchSupport? hp_ = value?.Value;
        string hq_ = context.Operators.Convert<string>(hp_);

        return hq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystemContentMode> value)
    {
        CodeSystemContentMode? hr_ = value?.Value;
        string hs_ = context.Operators.Convert<string>(hr_);

        return hs_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystem.CodeSystemHierarchyMeaning> value)
    {
        CodeSystem.CodeSystemHierarchyMeaning? ht_ = value?.Value;
        string hu_ = context.Operators.Convert<string>(ht_);

        return hu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestPriority> value)
    {
        RequestPriority? hv_ = value?.Value;
        string hw_ = context.Operators.Convert<string>(hv_);

        return hw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EventStatus> value)
    {
        EventStatus? hx_ = value?.Value;
        string hy_ = context.Operators.Convert<string>(hx_);

        return hy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CompartmentType> value)
    {
        CompartmentType? hz_ = value?.Value;
        string ia_ = context.Operators.Convert<string>(hz_);

        return ia_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Composition.CompositionAttestationMode> value)
    {
        Composition.CompositionAttestationMode? ib_ = value?.Value;
        string ic_ = context.Operators.Convert<string>(ib_);

        return ic_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CompositionStatus> value)
    {
        CompositionStatus? id_ = value?.Value;
        string ie_ = context.Operators.Convert<string>(id_);

        return ie_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConceptMapEquivalence> value)
    {
        ConceptMapEquivalence? if_ = value?.Value;
        string ig_ = context.Operators.Convert<string>(if_);

        return ig_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
    {
        ConceptMap.ConceptMapGroupUnmappedMode? ih_ = value?.Value;
        string ii_ = context.Operators.Convert<string>(ih_);

        return ii_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalDeleteStatus> value)
    {
        CapabilityStatement.ConditionalDeleteStatus? ij_ = value?.Value;
        string ik_ = context.Operators.Convert<string>(ij_);

        return ik_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalReadStatus> value)
    {
        CapabilityStatement.ConditionalReadStatus? il_ = value?.Value;
        string im_ = context.Operators.Convert<string>(il_);

        return im_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentDataMeaning> value)
    {
        Consent.ConsentDataMeaning? in_ = value?.Value;
        string io_ = context.Operators.Convert<string>(in_);

        return io_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentProvisionType> value)
    {
        Consent.ConsentProvisionType? ip_ = value?.Value;
        string iq_ = context.Operators.Convert<string>(ip_);

        return iq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentState> value)
    {
        Consent.ConsentState? ir_ = value?.Value;
        string is_ = context.Operators.Convert<string>(ir_);

        return is_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConstraintSeverity> value)
    {
        ConstraintSeverity? it_ = value?.Value;
        string iu_ = context.Operators.Convert<string>(it_);

        return iu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointSystem> value)
    {
        ContactPoint.ContactPointSystem? iv_ = value?.Value;
        string iw_ = context.Operators.Convert<string>(iv_);

        return iw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointUse> value)
    {
        ContactPoint.ContactPointUse? ix_ = value?.Value;
        string iy_ = context.Operators.Convert<string>(ix_);

        return iy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contract.ContractResourcePublicationStatusCodes> value)
    {
        Contract.ContractResourcePublicationStatusCodes? iz_ = value?.Value;
        string ja_ = context.Operators.Convert<string>(iz_);

        return ja_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contract.ContractResourceStatusCodes> value)
    {
        Contract.ContractResourceStatusCodes? jb_ = value?.Value;
        string jc_ = context.Operators.Convert<string>(jb_);

        return jc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contributor.ContributorType> value)
    {
        Contributor.ContributorType? jd_ = value?.Value;
        string je_ = context.Operators.Convert<string>(jd_);

        return je_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Money.Currencies> value)
    {
        Money.Currencies? jf_ = value?.Value;
        string jg_ = context.Operators.Convert<string>(jf_);

        return jg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DaysOfWeek> value)
    {
        DaysOfWeek? jh_ = value?.Value;
        string ji_ = context.Operators.Convert<string>(jh_);

        return ji_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DetectedIssue.DetectedIssueSeverity> value)
    {
        DetectedIssue.DetectedIssueSeverity? jj_ = value?.Value;
        string jk_ = context.Operators.Convert<string>(jj_);

        return jk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationStatus> value)
    {
        ObservationStatus? jl_ = value?.Value;
        string jm_ = context.Operators.Convert<string>(jl_);

        return jm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationState> value)
    {
        DeviceMetric.DeviceMetricCalibrationState? jn_ = value?.Value;
        string jo_ = context.Operators.Convert<string>(jn_);

        return jo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationType> value)
    {
        DeviceMetric.DeviceMetricCalibrationType? jp_ = value?.Value;
        string jq_ = context.Operators.Convert<string>(jp_);

        return jq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCategory> value)
    {
        DeviceMetric.DeviceMetricCategory? jr_ = value?.Value;
        string js_ = context.Operators.Convert<string>(jr_);

        return js_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricColor> value)
    {
        DeviceMetric.DeviceMetricColor? jt_ = value?.Value;
        string ju_ = context.Operators.Convert<string>(jt_);

        return ju_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricOperationalStatus> value)
    {
        DeviceMetric.DeviceMetricOperationalStatus? jv_ = value?.Value;
        string jw_ = context.Operators.Convert<string>(jv_);

        return jw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceNameType> value)
    {
        DeviceNameType? jx_ = value?.Value;
        string jy_ = context.Operators.Convert<string>(jx_);

        return jy_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceUseStatement.DeviceUseStatementStatus> value)
    {
        DeviceUseStatement.DeviceUseStatementStatus? jz_ = value?.Value;
        string ka_ = context.Operators.Convert<string>(jz_);

        return ka_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DiagnosticReport.DiagnosticReportStatus> value)
    {
        DiagnosticReport.DiagnosticReportStatus? kb_ = value?.Value;
        string kc_ = context.Operators.Convert<string>(kb_);

        return kc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.DiscriminatorType> value)
    {
        ElementDefinition.DiscriminatorType? kd_ = value?.Value;
        string ke_ = context.Operators.Convert<string>(kd_);

        return ke_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Composition.V3ConfidentialityClassification> value)
    {
        Composition.V3ConfidentialityClassification? kf_ = value?.Value;
        string kg_ = context.Operators.Convert<string>(kf_);

        return kg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.DocumentMode> value)
    {
        CapabilityStatement.DocumentMode? kh_ = value?.Value;
        string ki_ = context.Operators.Convert<string>(kh_);

        return ki_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DocumentReferenceStatus> value)
    {
        DocumentReferenceStatus? kj_ = value?.Value;
        string kk_ = context.Operators.Convert<string>(kj_);

        return kk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DocumentRelationshipType> value)
    {
        DocumentRelationshipType? kl_ = value?.Value;
        string km_ = context.Operators.Convert<string>(kl_);

        return km_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
    {
        CoverageEligibilityRequest.EligibilityRequestPurpose? kn_ = value?.Value;
        string ko_ = context.Operators.Convert<string>(kn_);

        return ko_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
    {
        CoverageEligibilityResponse.EligibilityResponsePurpose? kp_ = value?.Value;
        string kq_ = context.Operators.Convert<string>(kp_);

        return kq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.EnableWhenBehavior> value)
    {
        Questionnaire.EnableWhenBehavior? kr_ = value?.Value;
        string ks_ = context.Operators.Convert<string>(kr_);

        return ks_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Encounter.EncounterLocationStatus> value)
    {
        Encounter.EncounterLocationStatus? kt_ = value?.Value;
        string ku_ = context.Operators.Convert<string>(kt_);

        return ku_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Encounter.EncounterStatus> value)
    {
        Encounter.EncounterStatus? kv_ = value?.Value;
        string kw_ = context.Operators.Convert<string>(kv_);

        return kw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Endpoint.EndpointStatus> value)
    {
        Endpoint.EndpointStatus? kx_ = value?.Value;
        string ky_ = context.Operators.Convert<string>(kx_);

        return ky_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EpisodeOfCare.EpisodeOfCareStatus> value)
    {
        EpisodeOfCare.EpisodeOfCareStatus? kz_ = value?.Value;
        string la_ = context.Operators.Convert<string>(kz_);

        return la_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.EventCapabilityMode> value)
    {
        CapabilityStatement.EventCapabilityMode? lb_ = value?.Value;
        string lc_ = context.Operators.Convert<string>(lb_);

        return lc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Timing.EventTiming> value)
    {
        Timing.EventTiming? ld_ = value?.Value;
        string le_ = context.Operators.Convert<string>(ld_);

        return le_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VariableTypeCode> value)
    {
        VariableTypeCode? lf_ = value?.Value;
        string lg_ = context.Operators.Convert<string>(lf_);

        return lg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ExampleScenario.ExampleScenarioActorType> value)
    {
        ExampleScenario.ExampleScenarioActorType? lh_ = value?.Value;
        string li_ = context.Operators.Convert<string>(lh_);

        return li_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
    {
        ExplanationOfBenefit.ExplanationOfBenefitStatus? lj_ = value?.Value;
        string lk_ = context.Operators.Convert<string>(lj_);

        return lk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EffectEvidenceSynthesis.ExposureStateCode> value)
    {
        EffectEvidenceSynthesis.ExposureStateCode? ll_ = value?.Value;
        string lm_ = context.Operators.Convert<string>(ll_);

        return lm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.ExtensionContextType> value)
    {
        StructureDefinition.ExtensionContextType? ln_ = value?.Value;
        string lo_ = context.Operators.Convert<string>(ln_);

        return lo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRAllTypes> value)
    {
        FHIRAllTypes? lp_ = value?.Value;
        string lq_ = context.Operators.Convert<string>(lp_);

        return lq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRDefinedType> value)
    {
        FHIRDefinedType? lr_ = value?.Value;
        string ls_ = context.Operators.Convert<string>(lr_);

        return ls_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Device.FHIRDeviceStatus> value)
    {
        Device.FHIRDeviceStatus? lt_ = value?.Value;
        string lu_ = context.Operators.Convert<string>(lt_);

        return lu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResourceType> value)
    {
        ResourceType? lv_ = value?.Value;
        string lw_ = context.Operators.Convert<string>(lv_);

        return lw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Substance.FHIRSubstanceStatus> value)
    {
        Substance.FHIRSubstanceStatus? lx_ = value?.Value;
        string ly_ = context.Operators.Convert<string>(lx_);

        return ly_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRVersion> value)
    {
        FHIRVersion? lz_ = value?.Value;
        string ma_ = context.Operators.Convert<string>(lz_);

        return ma_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FamilyMemberHistory.FamilyHistoryStatus> value)
    {
        FamilyMemberHistory.FamilyHistoryStatus? mb_ = value?.Value;
        string mc_ = context.Operators.Convert<string>(mb_);

        return mc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FilterOperator> value)
    {
        FilterOperator? md_ = value?.Value;
        string me_ = context.Operators.Convert<string>(md_);

        return me_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Flag.FlagStatus> value)
    {
        Flag.FlagStatus? mf_ = value?.Value;
        string mg_ = context.Operators.Convert<string>(mf_);

        return mg_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Goal.GoalLifecycleStatus> value)
    {
        Goal.GoalLifecycleStatus? mh_ = value?.Value;
        string mi_ = context.Operators.Convert<string>(mh_);

        return mi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentRule> value)
    {
        GraphDefinition.GraphCompartmentRule? mj_ = value?.Value;
        string mk_ = context.Operators.Convert<string>(mj_);

        return mk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentUse> value)
    {
        GraphDefinition.GraphCompartmentUse? ml_ = value?.Value;
        string mm_ = context.Operators.Convert<string>(ml_);

        return mm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GroupMeasureCode> value)
    {
        GroupMeasureCode? mn_ = value?.Value;
        string mo_ = context.Operators.Convert<string>(mn_);

        return mo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Group.GroupType> value)
    {
        Group.GroupType? mp_ = value?.Value;
        string mq_ = context.Operators.Convert<string>(mp_);

        return mq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GuidanceResponse.GuidanceResponseStatus> value)
    {
        GuidanceResponse.GuidanceResponseStatus? mr_ = value?.Value;
        string ms_ = context.Operators.Convert<string>(mr_);

        return ms_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.GuidePageGeneration> value)
    {
        ImplementationGuide.GuidePageGeneration? mt_ = value?.Value;
        string mu_ = context.Operators.Convert<string>(mt_);

        return mu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.GuideParameterCode> value)
    {
        ImplementationGuide.GuideParameterCode? mv_ = value?.Value;
        string mw_ = context.Operators.Convert<string>(mv_);

        return mw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.HTTPVerb> value)
    {
        Bundle.HTTPVerb? mx_ = value?.Value;
        string my_ = context.Operators.Convert<string>(mx_);

        return my_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Identifier.IdentifierUse> value)
    {
        Identifier.IdentifierUse? mz_ = value?.Value;
        string na_ = context.Operators.Convert<string>(mz_);

        return na_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Person.IdentityAssuranceLevel> value)
    {
        Person.IdentityAssuranceLevel? nb_ = value?.Value;
        string nc_ = context.Operators.Convert<string>(nb_);

        return nc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImagingStudy.ImagingStudyStatus> value)
    {
        ImagingStudy.ImagingStudyStatus? nd_ = value?.Value;
        string ne_ = context.Operators.Convert<string>(nd_);

        return ne_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
    {
        ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? nf_ = value?.Value;
        string ng_ = context.Operators.Convert<string>(nf_);

        return ng_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Immunization.ImmunizationStatusCodes> value)
    {
        Immunization.ImmunizationStatusCodes? nh_ = value?.Value;
        string ni_ = context.Operators.Convert<string>(nh_);

        return ni_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Invoice.InvoiceStatus> value)
    {
        Invoice.InvoiceStatus? nj_ = value?.Value;
        string nk_ = context.Operators.Convert<string>(nj_);

        return nk_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationOutcome.IssueSeverity> value)
    {
        OperationOutcome.IssueSeverity? nl_ = value?.Value;
        string nm_ = context.Operators.Convert<string>(nl_);

        return nm_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationOutcome.IssueType> value)
    {
        OperationOutcome.IssueType? nn_ = value?.Value;
        string no_ = context.Operators.Convert<string>(nn_);

        return no_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Patient.LinkType> value)
    {
        Patient.LinkType? np_ = value?.Value;
        string nq_ = context.Operators.Convert<string>(np_);

        return nq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Linkage.LinkageType> value)
    {
        Linkage.LinkageType? nr_ = value?.Value;
        string ns_ = context.Operators.Convert<string>(nr_);

        return ns_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ListMode> value)
    {
        ListMode? nt_ = value?.Value;
        string nu_ = context.Operators.Convert<string>(nt_);

        return nu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<List.ListStatus> value)
    {
        List.ListStatus? nv_ = value?.Value;
        string nw_ = context.Operators.Convert<string>(nv_);

        return nw_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Location.LocationMode> value)
    {
        Location.LocationMode? nx_ = value?.Value;
        string ny_ = context.Operators.Convert<string>(nx_);

        return ny_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Location.LocationStatus> value)
    {
        Location.LocationStatus? nz_ = value?.Value;
        string oa_ = context.Operators.Convert<string>(nz_);

        return oa_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportStatus> value)
    {
        MeasureReport.MeasureReportStatus? ob_ = value?.Value;
        string oc_ = context.Operators.Convert<string>(ob_);

        return oc_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportType> value)
    {
        MeasureReport.MeasureReportType? od_ = value?.Value;
        string oe_ = context.Operators.Convert<string>(od_);

        return oe_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
    {
        MedicationAdministration.MedicationAdministrationStatusCodes? of_ = value?.Value;
        string og_ = context.Operators.Convert<string>(of_);

        return og_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationDispense.MedicationDispenseStatusCodes> value)
    {
        MedicationDispense.MedicationDispenseStatusCodes? oh_ = value?.Value;
        string oi_ = context.Operators.Convert<string>(oh_);

        return oi_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
    {
        MedicationKnowledge.MedicationKnowledgeStatusCodes? oj_ = value?.Value;
        string ok_ = context.Operators.Convert<string>(oj_);

        return ok_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationRequestIntent> value)
    {
        MedicationRequest.MedicationRequestIntent? ol_ = value?.Value;
        string om_ = context.Operators.Convert<string>(ol_);

        return om_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationrequestStatus> value)
    {
        MedicationRequest.MedicationrequestStatus? on_ = value?.Value;
        string oo_ = context.Operators.Convert<string>(on_);

        return oo_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationStatement.MedicationStatusCodes> value)
    {
        MedicationStatement.MedicationStatusCodes? op_ = value?.Value;
        string oq_ = context.Operators.Convert<string>(op_);

        return oq_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Medication.MedicationStatusCodes> value)
    {
        Medication.MedicationStatusCodes? or_ = value?.Value;
        string os_ = context.Operators.Convert<string>(or_);

        return os_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageDefinition.MessageSignificanceCategory> value)
    {
        MessageDefinition.MessageSignificanceCategory? ot_ = value?.Value;
        string ou_ = context.Operators.Convert<string>(ot_);

        return ou_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageheaderResponseRequest> value)
    {
        MessageheaderResponseRequest? ov_ = value?.Value;
        string ow_ = context.Operators.Convert<string>(ov_);

        return ow_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code value)
    {
        string ox_ = value?.Value;

        return ox_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<HumanName.NameUse> value)
    {
        HumanName.NameUse? oy_ = value?.Value;
        string oz_ = context.Operators.Convert<string>(oy_);

        return oz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemIdentifierType> value)
    {
        NamingSystem.NamingSystemIdentifierType? pa_ = value?.Value;
        string pb_ = context.Operators.Convert<string>(pa_);

        return pb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemType> value)
    {
        NamingSystem.NamingSystemType? pc_ = value?.Value;
        string pd_ = context.Operators.Convert<string>(pc_);

        return pd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Narrative.NarrativeStatus> value)
    {
        Narrative.NarrativeStatus? pe_ = value?.Value;
        string pf_ = context.Operators.Convert<string>(pe_);

        return pf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NoteType> value)
    {
        NoteType? pg_ = value?.Value;
        string ph_ = context.Operators.Convert<string>(pg_);

        return ph_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestIntent> value)
    {
        RequestIntent? pi_ = value?.Value;
        string pj_ = context.Operators.Convert<string>(pi_);

        return pj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationDataType> value)
    {
        ObservationDefinition.ObservationDataType? pk_ = value?.Value;
        string pl_ = context.Operators.Convert<string>(pk_);

        return pl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationRangeCategory> value)
    {
        ObservationDefinition.ObservationRangeCategory? pm_ = value?.Value;
        string pn_ = context.Operators.Convert<string>(pm_);

        return pn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationDefinition.OperationKind> value)
    {
        OperationDefinition.OperationKind? po_ = value?.Value;
        string pp_ = context.Operators.Convert<string>(po_);

        return pp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationParameterUse> value)
    {
        OperationParameterUse? pq_ = value?.Value;
        string pr_ = context.Operators.Convert<string>(pq_);

        return pr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.OrientationType> value)
    {
        MolecularSequence.OrientationType? ps_ = value?.Value;
        string pt_ = context.Operators.Convert<string>(ps_);

        return pt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Appointment.ParticipantRequired> value)
    {
        Appointment.ParticipantRequired? pu_ = value?.Value;
        string pv_ = context.Operators.Convert<string>(pu_);

        return pv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ParticipationStatus> value)
    {
        ParticipationStatus? pw_ = value?.Value;
        string px_ = context.Operators.Convert<string>(pw_);

        return px_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.PropertyRepresentation> value)
    {
        ElementDefinition.PropertyRepresentation? py_ = value?.Value;
        string pz_ = context.Operators.Convert<string>(py_);

        return pz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystem.PropertyType> value)
    {
        CodeSystem.PropertyType? qa_ = value?.Value;
        string qb_ = context.Operators.Convert<string>(qa_);

        return qb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Provenance.ProvenanceEntityRole> value)
    {
        Provenance.ProvenanceEntityRole? qc_ = value?.Value;
        string qd_ = context.Operators.Convert<string>(qc_);

        return qd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<PublicationStatus> value)
    {
        PublicationStatus? qe_ = value?.Value;
        string qf_ = context.Operators.Convert<string>(qe_);

        return qf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.QualityType> value)
    {
        MolecularSequence.QualityType? qg_ = value?.Value;
        string qh_ = context.Operators.Convert<string>(qg_);

        return qh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Quantity.QuantityComparator> value)
    {
        Quantity.QuantityComparator? qi_ = value?.Value;
        string qj_ = context.Operators.Convert<string>(qi_);

        return qj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemOperator> value)
    {
        Questionnaire.QuestionnaireItemOperator? qk_ = value?.Value;
        string ql_ = context.Operators.Convert<string>(qk_);

        return ql_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemType> value)
    {
        Questionnaire.QuestionnaireItemType? qm_ = value?.Value;
        string qn_ = context.Operators.Convert<string>(qm_);

        return qn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
    {
        QuestionnaireResponse.QuestionnaireResponseStatus? qo_ = value?.Value;
        string qp_ = context.Operators.Convert<string>(qo_);

        return qp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ReferenceHandlingPolicy> value)
    {
        CapabilityStatement.ReferenceHandlingPolicy? qq_ = value?.Value;
        string qr_ = context.Operators.Convert<string>(qq_);

        return qr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.ReferenceVersionRules> value)
    {
        ElementDefinition.ReferenceVersionRules? qs_ = value?.Value;
        string qt_ = context.Operators.Convert<string>(qs_);

        return qt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RelatedArtifact.RelatedArtifactType> value)
    {
        RelatedArtifact.RelatedArtifactType? qu_ = value?.Value;
        string qv_ = context.Operators.Convert<string>(qu_);

        return qv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClaimProcessingCodes> value)
    {
        ClaimProcessingCodes? qw_ = value?.Value;
        string qx_ = context.Operators.Convert<string>(qw_);

        return qx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.RepositoryType> value)
    {
        MolecularSequence.RepositoryType? qy_ = value?.Value;
        string qz_ = context.Operators.Convert<string>(qy_);

        return qz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchElementDefinition.ResearchElementType> value)
    {
        ResearchElementDefinition.ResearchElementType? ra_ = value?.Value;
        string rb_ = context.Operators.Convert<string>(ra_);

        return rb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchStudy.ResearchStudyStatus> value)
    {
        ResearchStudy.ResearchStudyStatus? rc_ = value?.Value;
        string rd_ = context.Operators.Convert<string>(rc_);

        return rd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchSubject.ResearchSubjectStatus> value)
    {
        ResearchSubject.ResearchSubjectStatus? re_ = value?.Value;
        string rf_ = context.Operators.Convert<string>(re_);

        return rf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ResourceVersionPolicy> value)
    {
        CapabilityStatement.ResourceVersionPolicy? rg_ = value?.Value;
        string rh_ = context.Operators.Convert<string>(rg_);

        return rh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageHeader.ResponseType> value)
    {
        MessageHeader.ResponseType? ri_ = value?.Value;
        string rj_ = context.Operators.Convert<string>(ri_);

        return rj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.RestfulCapabilityMode> value)
    {
        CapabilityStatement.RestfulCapabilityMode? rk_ = value?.Value;
        string rl_ = context.Operators.Convert<string>(rk_);

        return rl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.SPDXLicense> value)
    {
        ImplementationGuide.SPDXLicense? rm_ = value?.Value;
        string rn_ = context.Operators.Convert<string>(rm_);

        return rn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.SearchComparator> value)
    {
        SearchParameter.SearchComparator? ro_ = value?.Value;
        string rp_ = context.Operators.Convert<string>(ro_);

        return rp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.SearchEntryMode> value)
    {
        Bundle.SearchEntryMode? rq_ = value?.Value;
        string rr_ = context.Operators.Convert<string>(rq_);

        return rr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.SearchModifierCode> value)
    {
        SearchParameter.SearchModifierCode? rs_ = value?.Value;
        string rt_ = context.Operators.Convert<string>(rs_);

        return rt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParamType> value)
    {
        SearchParamType? ru_ = value?.Value;
        string rv_ = context.Operators.Convert<string>(ru_);

        return rv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.SequenceType> value)
    {
        MolecularSequence.SequenceType? rw_ = value?.Value;
        string rx_ = context.Operators.Convert<string>(rw_);

        return rx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.SlicingRules> value)
    {
        ElementDefinition.SlicingRules? ry_ = value?.Value;
        string rz_ = context.Operators.Convert<string>(ry_);

        return rz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Slot.SlotStatus> value)
    {
        Slot.SlotStatus? sa_ = value?.Value;
        string sb_ = context.Operators.Convert<string>(sa_);

        return sb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DataRequirement.SortDirection> value)
    {
        DataRequirement.SortDirection? sc_ = value?.Value;
        string sd_ = context.Operators.Convert<string>(sc_);

        return sd_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SpecimenDefinition.SpecimenContainedPreference> value)
    {
        SpecimenDefinition.SpecimenContainedPreference? se_ = value?.Value;
        string sf_ = context.Operators.Convert<string>(se_);

        return sf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Specimen.SpecimenStatus> value)
    {
        Specimen.SpecimenStatus? sg_ = value?.Value;
        string sh_ = context.Operators.Convert<string>(sg_);

        return sh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VerificationResult.StatusCode> value)
    {
        VerificationResult.StatusCode? si_ = value?.Value;
        string sj_ = context.Operators.Convert<string>(si_);

        return sj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.StrandType> value)
    {
        MolecularSequence.StrandType? sk_ = value?.Value;
        string sl_ = context.Operators.Convert<string>(sk_);

        return sl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.StructureDefinitionKind> value)
    {
        StructureDefinition.StructureDefinitionKind? sm_ = value?.Value;
        string sn_ = context.Operators.Convert<string>(sm_);

        return sn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapContextType> value)
    {
        StructureMap.StructureMapContextType? so_ = value?.Value;
        string sp_ = context.Operators.Convert<string>(so_);

        return sp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapGroupTypeMode> value)
    {
        StructureMap.StructureMapGroupTypeMode? sq_ = value?.Value;
        string sr_ = context.Operators.Convert<string>(sq_);

        return sr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapInputMode> value)
    {
        StructureMap.StructureMapInputMode? ss_ = value?.Value;
        string st_ = context.Operators.Convert<string>(ss_);

        return st_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapModelMode> value)
    {
        StructureMap.StructureMapModelMode? su_ = value?.Value;
        string sv_ = context.Operators.Convert<string>(su_);

        return sv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapSourceListMode> value)
    {
        StructureMap.StructureMapSourceListMode? sw_ = value?.Value;
        string sx_ = context.Operators.Convert<string>(sw_);

        return sx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTargetListMode> value)
    {
        StructureMap.StructureMapTargetListMode? sy_ = value?.Value;
        string sz_ = context.Operators.Convert<string>(sy_);

        return sz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTransform> value)
    {
        StructureMap.StructureMapTransform? ta_ = value?.Value;
        string tb_ = context.Operators.Convert<string>(ta_);

        return tb_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Subscription.SubscriptionChannelType> value)
    {
        Subscription.SubscriptionChannelType? tc_ = value?.Value;
        string td_ = context.Operators.Convert<string>(tc_);

        return td_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Subscription.SubscriptionStatus> value)
    {
        Subscription.SubscriptionStatus? te_ = value?.Value;
        string tf_ = context.Operators.Convert<string>(te_);

        return tf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SupplyDelivery.SupplyDeliveryStatus> value)
    {
        SupplyDelivery.SupplyDeliveryStatus? tg_ = value?.Value;
        string th_ = context.Operators.Convert<string>(tg_);

        return th_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SupplyRequest.SupplyRequestStatus> value)
    {
        SupplyRequest.SupplyRequestStatus? ti_ = value?.Value;
        string tj_ = context.Operators.Convert<string>(ti_);

        return tj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.SystemRestfulInteraction> value)
    {
        CapabilityStatement.SystemRestfulInteraction? tk_ = value?.Value;
        string tl_ = context.Operators.Convert<string>(tk_);

        return tl_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Task.TaskIntent> value)
    {
        Task.TaskIntent? tm_ = value?.Value;
        string tn_ = context.Operators.Convert<string>(tm_);

        return tn_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Task.TaskStatus> value)
    {
        Task.TaskStatus? to_ = value?.Value;
        string tp_ = context.Operators.Convert<string>(to_);

        return tp_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportActionResult> value)
    {
        TestReport.TestReportActionResult? tq_ = value?.Value;
        string tr_ = context.Operators.Convert<string>(tq_);

        return tr_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportParticipantType> value)
    {
        TestReport.TestReportParticipantType? ts_ = value?.Value;
        string tt_ = context.Operators.Convert<string>(ts_);

        return tt_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportResult> value)
    {
        TestReport.TestReportResult? tu_ = value?.Value;
        string tv_ = context.Operators.Convert<string>(tu_);

        return tv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportStatus> value)
    {
        TestReport.TestReportStatus? tw_ = value?.Value;
        string tx_ = context.Operators.Convert<string>(tw_);

        return tx_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.TestScriptRequestMethodCode> value)
    {
        TestScript.TestScriptRequestMethodCode? ty_ = value?.Value;
        string tz_ = context.Operators.Convert<string>(ty_);

        return tz_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TriggerDefinition.TriggerType> value)
    {
        TriggerDefinition.TriggerType? ua_ = value?.Value;
        string ub_ = context.Operators.Convert<string>(ua_);

        return ub_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.TypeDerivationRule> value)
    {
        StructureDefinition.TypeDerivationRule? uc_ = value?.Value;
        string ud_ = context.Operators.Convert<string>(uc_);

        return ud_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.TypeRestfulInteraction> value)
    {
        CapabilityStatement.TypeRestfulInteraction? ue_ = value?.Value;
        string uf_ = context.Operators.Convert<string>(ue_);

        return uf_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Device.UDIEntryType> value)
    {
        Device.UDIEntryType? ug_ = value?.Value;
        string uh_ = context.Operators.Convert<string>(ug_);

        return uh_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Timing.UnitsOfTime> value)
    {
        Timing.UnitsOfTime? ui_ = value?.Value;
        string uj_ = context.Operators.Convert<string>(ui_);

        return uj_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClaimUseCode> value)
    {
        ClaimUseCode? uk_ = value?.Value;
        string ul_ = context.Operators.Convert<string>(uk_);

        return ul_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VisionPrescription.VisionBase> value)
    {
        VisionPrescription.VisionBase? um_ = value?.Value;
        string un_ = context.Operators.Convert<string>(um_);

        return un_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VisionPrescription.VisionEyes> value)
    {
        VisionPrescription.VisionEyes? uo_ = value?.Value;
        string up_ = context.Operators.Convert<string>(uo_);

        return up_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.XPathUsageType> value)
    {
        SearchParameter.XPathUsageType? uq_ = value?.Value;
        string ur_ = context.Operators.Convert<string>(uq_);

        return ur_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, Base64Binary value)
    {
        byte[] us_ = value?.Value;
        string ut_ = context.Operators.Convert<string>(us_);

        return ut_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, FhirString value)
    {
        string uu_ = value?.Value;

        return uu_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, FhirUri value)
    {
        string uv_ = value?.Value;

        return uv_;
    }


    [CqlExpressionDefinition("ToString")]
    public string ToString(CqlContext context, XHtml value)
    {
        string uw_ = value?.Value;

        return uw_;
    }


    [CqlExpressionDefinition("ToBoolean")]
    public bool? ToBoolean(CqlContext context, FhirBoolean value)
    {
        bool? ux_ = value?.Value;

        return ux_;
    }


    [CqlExpressionDefinition("ToDate")]
    public CqlDate ToDate(CqlContext context, Date value)
    {
        string uy_ = value?.Value;
        CqlDate uz_ = context.Operators.ConvertStringToDate(uy_);

        return uz_;
    }


    [CqlExpressionDefinition("ToDateTime")]
    public CqlDateTime ToDateTime(CqlContext context, FhirDateTime value)
    {
        CqlDateTime va_ = context.Operators.Convert<CqlDateTime>(value);

        return va_;
    }


    [CqlExpressionDefinition("ToDateTime")]
    public CqlDateTime ToDateTime(CqlContext context, Instant value)
    {
        DateTimeOffset? vb_ = value?.Value;
        CqlDateTime vc_ = context.Operators.Convert<CqlDateTime>(vb_);

        return vc_;
    }


    [CqlExpressionDefinition("ToDecimal")]
    public decimal? ToDecimal(CqlContext context, FhirDecimal value)
    {
        decimal? vd_ = value?.Value;

        return vd_;
    }


    [CqlExpressionDefinition("ToInteger")]
    public int? ToInteger(CqlContext context, Integer value)
    {
        int? ve_ = value?.Value;

        return ve_;
    }


    [CqlExpressionDefinition("ToTime")]
    public CqlTime ToTime(CqlContext context, Time value)
    {
        string vf_ = value?.Value;
        CqlTime vg_ = context.Operators.ConvertStringToTime(vf_);

        return vg_;
    }


    #endregion Expressions

}

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "4.1.0.0")]
[CqlLibrary("FHIRHelpers", "4.0.1")]
public partial class FHIRHelpers_4_0_1 : ILibrary, ISingleton<FHIRHelpers_4_0_1>
{
    #region Functions and Expressions

    [CqlFunctionDefinition("ToInterval")]
    public CqlInterval<CqlDateTime> ToInterval(CqlContext context, Period period)
    {

        CqlInterval<CqlDateTime> a_() {
            if ((period /* CQL: 14:44-14:49 */) is null)
            {
                return null as CqlInterval<CqlDateTime>;
            }
            else if (((period /* CQL: 14:44-14:49 */)?.StartElement /* CQL: 11:12-11:25 */) is null)
            {
                FhirDateTime b_ = (period /* CQL: 14:44-14:49 */)?.StartElement /* CQL: 12:22-12:35 */;
                CqlDateTime c_ = context.Operators.Convert<CqlDateTime>(b_);
                FhirDateTime d_ = (period /* CQL: 14:44-14:49 */)?.EndElement /* CQL: 12:44-12:55 */;
                CqlDateTime e_ = context.Operators.Convert<CqlDateTime>(d_);
                CqlInterval<CqlDateTime> f_ = context.Operators.Interval(c_, e_, false, true);
                return f_;
            }
            else
            {
                FhirDateTime g_ = (period /* CQL: 14:44-14:49 */)?.StartElement /* CQL: 14:22-14:35 */;
                CqlDateTime h_ = context.Operators.Convert<CqlDateTime>(g_);
                FhirDateTime i_ = (period /* CQL: 14:44-14:49 */)?.EndElement /* CQL: 14:44-14:55 */;
                CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                CqlInterval<CqlDateTime> k_ = context.Operators.Interval(h_, j_, true, true);
                return k_;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("ToInterval")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Quantity quantity)
    {

        CqlInterval<CqlQuantity> a_() {
            if ((quantity /* CQL: 73:50-73:57 */) is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {

                CqlInterval<CqlQuantity> b_() {

                    bool c_() {
                        Code<Quantity.QuantityComparator> g_ = (quantity /* CQL: 73:50-73:57 */)?.ComparatorElement /* CQL: 55:14-55:32 */;
                        Quantity.QuantityComparator? h_ = g_?.Value;
                        string i_ = context.Operators.Convert<string>(h_);
                        bool? j_ = context.Operators.Equal(i_, "<" /* CQL: 56:18-56:20 */);
                        return j_ ?? false;
                    }


                    bool d_() {
                        Code<Quantity.QuantityComparator> k_ = (quantity /* CQL: 73:50-73:57 */)?.ComparatorElement /* CQL: 55:14-55:32 */;
                        Quantity.QuantityComparator? l_ = k_?.Value;
                        string m_ = context.Operators.Convert<string>(l_);
                        bool? n_ = context.Operators.Equal(m_, "<=" /* CQL: 61:18-61:21 */);
                        return n_ ?? false;
                    }


                    bool e_() {
                        Code<Quantity.QuantityComparator> o_ = (quantity /* CQL: 73:50-73:57 */)?.ComparatorElement /* CQL: 55:14-55:32 */;
                        Quantity.QuantityComparator? p_ = o_?.Value;
                        string q_ = context.Operators.Convert<string>(p_);
                        bool? r_ = context.Operators.Equal(q_, ">=" /* CQL: 66:18-66:21 */);
                        return r_ ?? false;
                    }


                    bool f_() {
                        Code<Quantity.QuantityComparator> s_ = (quantity /* CQL: 73:50-73:57 */)?.ComparatorElement /* CQL: 55:14-55:32 */;
                        Quantity.QuantityComparator? t_ = s_?.Value;
                        string u_ = context.Operators.Convert<string>(t_);
                        bool? v_ = context.Operators.Equal(u_, ">" /* CQL: 71:18-71:20 */);
                        return v_ ?? false;
                    }

                    if (c_())
                    {
                        CqlQuantity w_ = this.ToQuantityIgnoringComparator(context, quantity /* CQL: 73:50-73:57 */) /* CQL: 59:21-59:58 */;
                        CqlInterval<CqlQuantity> x_ = context.Operators.Interval(default, w_, true, false);
                        return x_;
                    }
                    else if (d_())
                    {
                        CqlQuantity y_ = this.ToQuantityIgnoringComparator(context, quantity /* CQL: 73:50-73:57 */) /* CQL: 64:21-64:58 */;
                        CqlInterval<CqlQuantity> z_ = context.Operators.Interval(default, y_, true, true);
                        return z_;
                    }
                    else if (e_())
                    {
                        CqlQuantity aa_ = this.ToQuantityIgnoringComparator(context, quantity /* CQL: 73:50-73:57 */) /* CQL: 68:21-68:58 */;
                        CqlInterval<CqlQuantity> ab_ = context.Operators.Interval(aa_, default, true, true);
                        return ab_;
                    }
                    else if (f_())
                    {
                        CqlQuantity ac_ = this.ToQuantityIgnoringComparator(context, quantity /* CQL: 73:50-73:57 */) /* CQL: 73:21-73:58 */;
                        CqlInterval<CqlQuantity> ad_ = context.Operators.Interval(ac_, default, false, true);
                        return ad_;
                    }
                    else
                    {
                        CqlQuantity ae_ = this.ToQuantity(context, quantity /* CQL: 73:50-73:57 */) /* CQL: 77:26-77:45 */;
                        CqlInterval<CqlQuantity> ag_ = context.Operators.Interval(ae_, ae_, true, true);
                        return ag_;
                    };
                }

                return b_();
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("ToInterval")]
    public CqlInterval<CqlQuantity> ToInterval(CqlContext context, Range range)
    {

        CqlInterval<CqlQuantity> a_() {
            if ((range /* CQL: 90:52-90:56 */) is null)
            {
                return null as CqlInterval<CqlQuantity>;
            }
            else
            {
                Quantity b_ = (range /* CQL: 90:52-90:56 */)?.Low /* CQL: 90:29-90:37 */;
                CqlQuantity c_ = this.ToQuantity(context, b_);
                Quantity d_ = (range /* CQL: 90:52-90:56 */)?.High /* CQL: 90:52-90:61 */;
                CqlQuantity e_ = this.ToQuantity(context, d_);
                CqlInterval<CqlQuantity> f_ = context.Operators.Interval(c_, e_, true, true);
                return f_;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("ToCalendarUnit")]
    public string ToCalendarUnit(CqlContext context, string unit)
    {

        string a_() {
            if ((context.Operators.Equal(unit /* CQL: 17:10-17:13 */, "ms" /* CQL: 18:14-18:17 */)) ?? false)
            {
                return "millisecond" /* CQL: 18:24-18:36 */;
            }
            else if ((context.Operators.Equal(unit /* CQL: 17:10-17:13 */, "s" /* CQL: 19:14-19:16 */)) ?? false)
            {
                return "second" /* CQL: 19:23-19:30 */;
            }
            else if ((context.Operators.Equal(unit /* CQL: 17:10-17:13 */, "min" /* CQL: 20:14-20:18 */)) ?? false)
            {
                return "minute" /* CQL: 20:25-20:32 */;
            }
            else if ((context.Operators.Equal(unit /* CQL: 17:10-17:13 */, "h" /* CQL: 21:14-21:16 */)) ?? false)
            {
                return "hour" /* CQL: 21:23-21:28 */;
            }
            else if ((context.Operators.Equal(unit /* CQL: 17:10-17:13 */, "d" /* CQL: 22:14-22:16 */)) ?? false)
            {
                return "day" /* CQL: 22:23-22:27 */;
            }
            else if ((context.Operators.Equal(unit /* CQL: 17:10-17:13 */, "wk" /* CQL: 23:14-23:17 */)) ?? false)
            {
                return "week" /* CQL: 23:24-23:29 */;
            }
            else if ((context.Operators.Equal(unit /* CQL: 17:10-17:13 */, "mo" /* CQL: 24:14-24:17 */)) ?? false)
            {
                return "month" /* CQL: 24:24-24:30 */;
            }
            else if ((context.Operators.Equal(unit /* CQL: 17:10-17:13 */, "a" /* CQL: 25:14-25:16 */)) ?? false)
            {
                return "year" /* CQL: 25:23-25:28 */;
            }
            else
            {
                return unit /* CQL: 17:10-17:13 */;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("ToQuantity")]
    public CqlQuantity ToQuantity(CqlContext context, Quantity quantity)
    {

        CqlQuantity a_() {

            bool b_() {
                Code<Quantity.QuantityComparator> d_ = (quantity /* CQL: 37:111-37:118 */)?.ComparatorElement /* CQL: 33:14-33:32 */;
                bool? e_ = context.Operators.Not((bool?)(d_ is null));
                return e_ ?? false;
            }


            bool c_() {
                FhirUri f_ = (quantity /* CQL: 37:111-37:118 */)?.SystemElement /* CQL: 35:14-35:28 */;
                string h_ = f_?.Value;
                bool? i_ = context.Operators.Equal(h_, "http://unitsofmeasure.org" /* CQL: 35:65-35:91 */);
                bool? j_ = context.Operators.Or((bool?)(f_ is null), i_);
                string l_ = f_?.Value;
                bool? m_ = context.Operators.Equal(l_, "http://hl7.org/fhirpath/CodeSystem/calendar-units" /* CQL: 36:42-36:92 */);
                bool? n_ = context.Operators.Or(j_, m_);
                return n_ ?? false;
            }

            if ((quantity /* CQL: 37:111-37:118 */) is null)
            {
                return default;
            }
            else if (((quantity /* CQL: 37:111-37:118 */)?.ValueElement /* CQL: 32:14-32:27 */) is null)
            {
                return default;
            }
            else if (b_())
            {
                object o_ = context.Operators.Message<object>(null /* CQL: 105:9-105:12 */, "FHIRHelpers.ToQuantity.ComparatorQuantityNotSupported" /* CQL: 34:33-34:87 */, "Error" /* CQL: 34:90-34:96 */, "FHIR Quantity value has a comparator and cannot be converted to a System.Quantity value." /* CQL: 34:99-34:188 */) /* CQL: 34:13-34:189 */;
                return o_ as CqlQuantity;
            }
            else if (c_())
            {
                FhirDecimal p_ = (quantity /* CQL: 37:111-37:118 */)?.ValueElement /* CQL: 37:38-37:51 */;
                decimal? q_ = p_?.Value;
                Code r_ = (quantity /* CQL: 37:111-37:118 */)?.CodeElement /* CQL: 37:90-37:102 */;
                string s_ = r_?.Value;
                FhirString t_ = (quantity /* CQL: 37:111-37:118 */)?.UnitElement /* CQL: 37:111-37:123 */;
                string u_ = t_?.Value;
                string v_ = this.ToCalendarUnit(context, (s_ ?? u_) ?? "1" /* CQL: 37:132-37:134 */);
                return new CqlQuantity(q_, v_);
            }
            else
            {
                FhirString w_ = (quantity /* CQL: 37:111-37:118 */)?.UnitElement /* CQL: 39:121-39:133 */;
                string x_ = w_?.Value;
                string y_ = context.Operators.Concatenate("Invalid FHIR Quantity code: " /* CQL: 39:88-39:117 */, x_ ?? "");
                string z_ = context.Operators.Concatenate(y_ ?? "", " (" /* CQL: 39:143-39:146 */);
                FhirUri aa_ = (quantity /* CQL: 37:111-37:118 */)?.SystemElement /* CQL: 39:150-39:164 */;
                string ab_ = aa_?.Value;
                string ac_ = context.Operators.Concatenate(z_ ?? "", ab_ ?? "");
                string ad_ = context.Operators.Concatenate(ac_ ?? "", "|" /* CQL: 39:174-39:176 */);
                Code ae_ = (quantity /* CQL: 37:111-37:118 */)?.CodeElement /* CQL: 39:180-39:192 */;
                string af_ = ae_?.Value;
                string ag_ = context.Operators.Concatenate(ad_ ?? "", af_ ?? "");
                string ah_ = context.Operators.Concatenate(ag_ ?? "", ")" /* CQL: 39:202-39:204 */);
                object ai_ = context.Operators.Message<object>(null /* CQL: 105:9-105:12 */, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity" /* CQL: 39:33-39:76 */, "Error" /* CQL: 39:79-39:85 */, ah_);
                return ai_ as CqlQuantity;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("ToQuantityIgnoringComparator")]
    public CqlQuantity ToQuantityIgnoringComparator(CqlContext context, Quantity quantity)
    {

        CqlQuantity a_() {

            bool b_() {
                FhirUri c_ = (quantity /* CQL: 48:111-48:118 */)?.SystemElement /* CQL: 46:14-46:28 */;
                string e_ = c_?.Value;
                bool? f_ = context.Operators.Equal(e_, "http://unitsofmeasure.org" /* CQL: 46:65-46:91 */);
                bool? g_ = context.Operators.Or((bool?)(c_ is null), f_);
                string i_ = c_?.Value;
                bool? j_ = context.Operators.Equal(i_, "http://hl7.org/fhirpath/CodeSystem/calendar-units" /* CQL: 47:42-47:92 */);
                bool? k_ = context.Operators.Or(g_, j_);
                return k_ ?? false;
            }

            if ((quantity /* CQL: 48:111-48:118 */) is null)
            {
                return default;
            }
            else if (((quantity /* CQL: 48:111-48:118 */)?.ValueElement /* CQL: 45:14-45:27 */) is null)
            {
                return default;
            }
            else if (b_())
            {
                FhirDecimal l_ = (quantity /* CQL: 48:111-48:118 */)?.ValueElement /* CQL: 48:38-48:51 */;
                decimal? m_ = l_?.Value;
                Code n_ = (quantity /* CQL: 48:111-48:118 */)?.CodeElement /* CQL: 48:90-48:102 */;
                string o_ = n_?.Value;
                FhirString p_ = (quantity /* CQL: 48:111-48:118 */)?.UnitElement /* CQL: 48:111-48:123 */;
                string q_ = p_?.Value;
                string r_ = this.ToCalendarUnit(context, (o_ ?? q_) ?? "1" /* CQL: 48:132-48:134 */);
                return new CqlQuantity(m_, r_);
            }
            else
            {
                FhirString s_ = (quantity /* CQL: 48:111-48:118 */)?.UnitElement /* CQL: 50:121-50:133 */;
                string t_ = s_?.Value;
                string u_ = context.Operators.Concatenate("Invalid FHIR Quantity code: " /* CQL: 50:88-50:117 */, t_ ?? "");
                string v_ = context.Operators.Concatenate(u_ ?? "", " (" /* CQL: 50:143-50:146 */);
                FhirUri w_ = (quantity /* CQL: 48:111-48:118 */)?.SystemElement /* CQL: 50:150-50:164 */;
                string x_ = w_?.Value;
                string y_ = context.Operators.Concatenate(v_ ?? "", x_ ?? "");
                string z_ = context.Operators.Concatenate(y_ ?? "", "|" /* CQL: 50:174-50:176 */);
                Code aa_ = (quantity /* CQL: 48:111-48:118 */)?.CodeElement /* CQL: 50:180-50:192 */;
                string ab_ = aa_?.Value;
                string ac_ = context.Operators.Concatenate(z_ ?? "", ab_ ?? "");
                string ad_ = context.Operators.Concatenate(ac_ ?? "", ")" /* CQL: 50:202-50:204 */);
                object ae_ = context.Operators.Message<object>(null /* CQL: 105:9-105:12 */, "FHIRHelpers.ToQuantity.InvalidFHIRQuantity" /* CQL: 50:33-50:76 */, "Error" /* CQL: 50:79-50:85 */, ad_);
                return ae_ as CqlQuantity;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("ToRatio")]
    public CqlRatio ToRatio(CqlContext context, Ratio ratio)
    {

        CqlRatio a_() {
            if ((ratio /* CQL: 84:88-84:92 */) is null)
            {
                return default;
            }
            else
            {
                Quantity b_ = (ratio /* CQL: 84:88-84:92 */)?.Numerator /* CQL: 84:46-84:60 */;
                CqlQuantity c_ = this.ToQuantity(context, b_);
                Quantity d_ = (ratio /* CQL: 84:88-84:92 */)?.Denominator /* CQL: 84:88-84:104 */;
                CqlQuantity e_ = this.ToQuantity(context, d_);
                return new CqlRatio(c_, e_);
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("ToCode")]
    public CqlCode ToCode(CqlContext context, Coding coding)
    {

        CqlCode a_() {
            if ((coding /* CQL: 100:20-100:25 */) is null)
            {
                return default;
            }
            else
            {
                Code b_ = (coding /* CQL: 100:20-100:25 */)?.CodeElement /* CQL: 97:17-97:27 */;
                string c_ = b_?.Value;
                FhirUri d_ = (coding /* CQL: 100:20-100:25 */)?.SystemElement /* CQL: 98:19-98:31 */;
                string e_ = d_?.Value;
                FhirString f_ = (coding /* CQL: 100:20-100:25 */)?.VersionElement /* CQL: 99:20-99:33 */;
                string g_ = f_?.Value;
                FhirString h_ = (coding /* CQL: 100:20-100:25 */)?.DisplayElement /* CQL: 100:20-100:33 */;
                string i_ = h_?.Value;
                return new CqlCode(c_, e_, g_, i_);
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("ToConcept")]
    public CqlConcept ToConcept(CqlContext context, CodeableConcept concept)
    {

        CqlConcept a_() {
            if ((concept /* CQL: 109:22-109:28 */) is null)
            {
                return default;
            }
            else
            {
                List<Coding> b_ = (concept /* CQL: 109:22-109:28 */)?.Coding;

                CqlCode c_(Coding C) {
                    CqlCode h_ = this.ToCode(context, C /* CQL: 108:51 */) /* CQL: 108:44-108:52 */;
                    return h_;
                }

                IEnumerable<CqlCode> d_ = context.Operators.Select<Coding, CqlCode>((IEnumerable<Coding>)b_, c_);
                IEnumerable<CqlCode> e_ = context.Operators.Distinct<CqlCode>(d_);
                FhirString f_ = (concept /* CQL: 109:22-109:28 */)?.TextElement /* CQL: 109:22-109:33 */;
                string g_ = f_?.Value;
                return new CqlConcept(e_, g_);
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Account.AccountStatus> value)
    {
        Account.AccountStatus? a_ = (value /* CQL: 113:48-113:52 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionCardinalityBehavior> value)
    {
        ActionCardinalityBehavior? a_ = (value /* CQL: 114:60-114:64 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionConditionKind> value)
    {
        ActionConditionKind? a_ = (value /* CQL: 115:54-115:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionGroupingBehavior> value)
    {
        ActionGroupingBehavior? a_ = (value /* CQL: 116:57-116:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionParticipantType> value)
    {
        ActionParticipantType? a_ = (value /* CQL: 117:56-117:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionPrecheckBehavior> value)
    {
        ActionPrecheckBehavior? a_ = (value /* CQL: 118:57-118:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionRelationshipType> value)
    {
        ActionRelationshipType? a_ = (value /* CQL: 119:57-119:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionRequiredBehavior> value)
    {
        ActionRequiredBehavior? a_ = (value /* CQL: 120:57-120:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActionSelectionBehavior> value)
    {
        ActionSelectionBehavior? a_ = (value /* CQL: 121:58-121:62 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ActivityDefinition.RequestResourceType> value)
    {
        ActivityDefinition.RequestResourceType? a_ = (value /* CQL: 122:57-122:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Address.AddressType> value)
    {
        Address.AddressType? a_ = (value /* CQL: 124:46-124:50 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Address.AddressUse> value)
    {
        Address.AddressUse? a_ = (value /* CQL: 125:45-125:49 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AdministrativeGender> value)
    {
        AdministrativeGender? a_ = (value /* CQL: 126:55-126:59 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AdverseEvent.AdverseEventActuality> value)
    {
        AdverseEvent.AdverseEventActuality? a_ = (value /* CQL: 127:56-127:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.AggregationMode> value)
    {
        ElementDefinition.AggregationMode? a_ = (value /* CQL: 128:50-128:54 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCategory> value)
    {
        AllergyIntolerance.AllergyIntoleranceCategory? a_ = (value /* CQL: 129:61-129:65 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceCriticality> value)
    {
        AllergyIntolerance.AllergyIntoleranceCriticality? a_ = (value /* CQL: 130:64-130:68 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceSeverity> value)
    {
        AllergyIntolerance.AllergyIntoleranceSeverity? a_ = (value /* CQL: 131:61-131:65 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AllergyIntolerance.AllergyIntoleranceType> value)
    {
        AllergyIntolerance.AllergyIntoleranceType? a_ = (value /* CQL: 132:57-132:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Appointment.AppointmentStatus> value)
    {
        Appointment.AppointmentStatus? a_ = (value /* CQL: 133:52-133:56 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionDirectionType> value)
    {
        TestScript.AssertionDirectionType? a_ = (value /* CQL: 134:57-134:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionOperatorType> value)
    {
        TestScript.AssertionOperatorType? a_ = (value /* CQL: 135:56-135:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.AssertionResponseTypes> value)
    {
        TestScript.AssertionResponseTypes? a_ = (value /* CQL: 136:57-136:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAction> value)
    {
        AuditEvent.AuditEventAction? a_ = (value /* CQL: 137:51-137:55 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventAgentNetworkType> value)
    {
        AuditEvent.AuditEventAgentNetworkType? a_ = (value /* CQL: 138:61-138:65 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<AuditEvent.AuditEventOutcome> value)
    {
        AuditEvent.AuditEventOutcome? a_ = (value /* CQL: 139:52-139:56 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BindingStrength> value)
    {
        BindingStrength? a_ = (value /* CQL: 140:50-140:54 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductCategory> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductCategory? a_ = (value /* CQL: 141:69-141:73 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStatus> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStatus? a_ = (value /* CQL: 142:67-142:71 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale> value)
    {
        BiologicallyDerivedProduct.BiologicallyDerivedProductStorageScale? a_ = (value /* CQL: 143:73-143:77 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.BundleType> value)
    {
        Bundle.BundleType? a_ = (value /* CQL: 144:45-144:49 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatementKind> value)
    {
        CapabilityStatementKind? a_ = (value /* CQL: 145:58-145:62 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityKind> value)
    {
        CarePlan.CarePlanActivityKind? a_ = (value /* CQL: 146:55-146:59 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanActivityStatus> value)
    {
        CarePlan.CarePlanActivityStatus? a_ = (value /* CQL: 147:57-147:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CarePlan.CarePlanIntent> value)
    {
        CarePlan.CarePlanIntent? a_ = (value /* CQL: 148:49-148:53 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestStatus> value)
    {
        RequestStatus? a_ = (value /* CQL: 149:49-149:53 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CareTeam.CareTeamStatus> value)
    {
        CareTeam.CareTeamStatus? a_ = (value /* CQL: 150:49-150:53 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CatalogEntry.CatalogEntryRelationType> value)
    {
        CatalogEntry.CatalogEntryRelationType? a_ = (value /* CQL: 151:59-151:63 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<InvoicePriceComponentType> value)
    {
        InvoicePriceComponentType? a_ = (value /* CQL: 152:73-152:77 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ChargeItem.ChargeItemStatus> value)
    {
        ChargeItem.ChargeItemStatus? a_ = (value /* CQL: 153:51-153:55 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FinancialResourceStatusCodes> value)
    {
        FinancialResourceStatusCodes? a_ = (value /* CQL: 154:54-154:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClinicalImpression.ClinicalImpressionStatus> value)
    {
        ClinicalImpression.ClinicalImpressionStatus? a_ = (value /* CQL: 156:59-156:63 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TerminologyCapabilities.CodeSearchSupport> value)
    {
        TerminologyCapabilities.CodeSearchSupport? a_ = (value /* CQL: 157:52-157:56 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystemContentMode> value)
    {
        CodeSystemContentMode? a_ = (value /* CQL: 158:56-158:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystem.CodeSystemHierarchyMeaning> value)
    {
        CodeSystem.CodeSystemHierarchyMeaning? a_ = (value /* CQL: 159:61-159:65 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestPriority> value)
    {
        RequestPriority? a_ = (value /* CQL: 160:56-160:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EventStatus> value)
    {
        EventStatus? a_ = (value /* CQL: 162:54-162:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CompartmentType> value)
    {
        CompartmentType? a_ = (value /* CQL: 163:50-163:54 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Composition.CompositionAttestationMode> value)
    {
        Composition.CompositionAttestationMode? a_ = (value /* CQL: 165:61-165:65 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CompositionStatus> value)
    {
        CompositionStatus? a_ = (value /* CQL: 166:52-166:56 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConceptMapEquivalence> value)
    {
        ConceptMapEquivalence? a_ = (value /* CQL: 167:56-167:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConceptMap.ConceptMapGroupUnmappedMode> value)
    {
        ConceptMap.ConceptMapGroupUnmappedMode? a_ = (value /* CQL: 168:62-168:66 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalDeleteStatus> value)
    {
        CapabilityStatement.ConditionalDeleteStatus? a_ = (value /* CQL: 169:58-169:62 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ConditionalReadStatus> value)
    {
        CapabilityStatement.ConditionalReadStatus? a_ = (value /* CQL: 170:56-170:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentDataMeaning> value)
    {
        Consent.ConsentDataMeaning? a_ = (value /* CQL: 171:53-171:57 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentProvisionType> value)
    {
        Consent.ConsentProvisionType? a_ = (value /* CQL: 172:55-172:59 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Consent.ConsentState> value)
    {
        Consent.ConsentState? a_ = (value /* CQL: 173:47-173:51 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ConstraintSeverity> value)
    {
        ConstraintSeverity? a_ = (value /* CQL: 174:53-174:57 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointSystem> value)
    {
        ContactPoint.ContactPointSystem? a_ = (value /* CQL: 175:53-175:57 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ContactPoint.ContactPointUse> value)
    {
        ContactPoint.ContactPointUse? a_ = (value /* CQL: 176:50-176:54 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contract.ContractResourcePublicationStatusCodes> value)
    {
        Contract.ContractResourcePublicationStatusCodes? a_ = (value /* CQL: 177:60-177:64 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contract.ContractResourceStatusCodes> value)
    {
        Contract.ContractResourceStatusCodes? a_ = (value /* CQL: 178:49-178:53 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Contributor.ContributorType> value)
    {
        Contributor.ContributorType? a_ = (value /* CQL: 179:50-179:54 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Money.Currencies> value)
    {
        Money.Currencies? a_ = (value /* CQL: 181:47-181:51 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DaysOfWeek> value)
    {
        DaysOfWeek? a_ = (value /* CQL: 182:44-182:48 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DetectedIssue.DetectedIssueSeverity> value)
    {
        DetectedIssue.DetectedIssueSeverity? a_ = (value /* CQL: 184:56-184:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationStatus> value)
    {
        ObservationStatus? a_ = (value /* CQL: 185:54-185:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationState> value)
    {
        DeviceMetric.DeviceMetricCalibrationState? a_ = (value /* CQL: 186:63-186:67 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCalibrationType> value)
    {
        DeviceMetric.DeviceMetricCalibrationType? a_ = (value /* CQL: 187:62-187:66 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricCategory> value)
    {
        DeviceMetric.DeviceMetricCategory? a_ = (value /* CQL: 188:55-188:59 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricColor> value)
    {
        DeviceMetric.DeviceMetricColor? a_ = (value /* CQL: 189:52-189:56 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceMetric.DeviceMetricOperationalStatus> value)
    {
        DeviceMetric.DeviceMetricOperationalStatus? a_ = (value /* CQL: 190:64-190:68 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceNameType> value)
    {
        DeviceNameType? a_ = (value /* CQL: 191:49-191:53 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DeviceUseStatement.DeviceUseStatementStatus> value)
    {
        DeviceUseStatement.DeviceUseStatementStatus? a_ = (value /* CQL: 193:59-193:63 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DiagnosticReport.DiagnosticReportStatus> value)
    {
        DiagnosticReport.DiagnosticReportStatus? a_ = (value /* CQL: 194:57-194:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.DiscriminatorType> value)
    {
        ElementDefinition.DiscriminatorType? a_ = (value /* CQL: 195:52-195:56 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Composition.V3ConfidentialityClassification> value)
    {
        Composition.V3ConfidentialityClassification? a_ = (value /* CQL: 196:58-196:62 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.DocumentMode> value)
    {
        CapabilityStatement.DocumentMode? a_ = (value /* CQL: 197:47-197:51 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DocumentReferenceStatus> value)
    {
        DocumentReferenceStatus? a_ = (value /* CQL: 198:58-198:62 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DocumentRelationshipType> value)
    {
        DocumentRelationshipType? a_ = (value /* CQL: 199:59-199:63 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CoverageEligibilityRequest.EligibilityRequestPurpose> value)
    {
        CoverageEligibilityRequest.EligibilityRequestPurpose? a_ = (value /* CQL: 200:60-200:64 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CoverageEligibilityResponse.EligibilityResponsePurpose> value)
    {
        CoverageEligibilityResponse.EligibilityResponsePurpose? a_ = (value /* CQL: 202:61-202:65 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.EnableWhenBehavior> value)
    {
        Questionnaire.EnableWhenBehavior? a_ = (value /* CQL: 204:53-204:57 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Encounter.EncounterLocationStatus> value)
    {
        Encounter.EncounterLocationStatus? a_ = (value /* CQL: 205:58-205:62 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Encounter.EncounterStatus> value)
    {
        Encounter.EncounterStatus? a_ = (value /* CQL: 206:50-206:54 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Endpoint.EndpointStatus> value)
    {
        Endpoint.EndpointStatus? a_ = (value /* CQL: 207:49-207:53 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EpisodeOfCare.EpisodeOfCareStatus> value)
    {
        EpisodeOfCare.EpisodeOfCareStatus? a_ = (value /* CQL: 210:54-210:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.EventCapabilityMode> value)
    {
        CapabilityStatement.EventCapabilityMode? a_ = (value /* CQL: 211:54-211:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Timing.EventTiming> value)
    {
        Timing.EventTiming? a_ = (value /* CQL: 212:46-212:50 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VariableTypeCode> value)
    {
        VariableTypeCode? a_ = (value /* CQL: 213:55-213:59 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ExampleScenario.ExampleScenarioActorType> value)
    {
        ExampleScenario.ExampleScenarioActorType? a_ = (value /* CQL: 214:59-214:63 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ExplanationOfBenefit.ExplanationOfBenefitStatus> value)
    {
        ExplanationOfBenefit.ExplanationOfBenefitStatus? a_ = (value /* CQL: 215:61-215:65 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<EffectEvidenceSynthesis.ExposureStateCode> value)
    {
        EffectEvidenceSynthesis.ExposureStateCode? a_ = (value /* CQL: 216:48-216:52 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.ExtensionContextType> value)
    {
        StructureDefinition.ExtensionContextType? a_ = (value /* CQL: 217:55-217:59 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRAllTypes> value)
    {
        FHIRAllTypes? a_ = (value /* CQL: 218:47-218:51 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRDefinedType> value)
    {
        FHIRDefinedType? a_ = (value /* CQL: 219:50-219:54 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Device.FHIRDeviceStatus> value)
    {
        Device.FHIRDeviceStatus? a_ = (value /* CQL: 220:51-220:55 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResourceType> value)
    {
        ResourceType? a_ = (value /* CQL: 221:51-221:55 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Substance.FHIRSubstanceStatus> value)
    {
        Substance.FHIRSubstanceStatus? a_ = (value /* CQL: 222:54-222:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FHIRVersion> value)
    {
        FHIRVersion? a_ = (value /* CQL: 223:46-223:50 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FamilyMemberHistory.FamilyHistoryStatus> value)
    {
        FamilyMemberHistory.FamilyHistoryStatus? a_ = (value /* CQL: 224:54-224:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<FilterOperator> value)
    {
        FilterOperator? a_ = (value /* CQL: 225:49-225:53 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Flag.FlagStatus> value)
    {
        Flag.FlagStatus? a_ = (value /* CQL: 226:45-226:49 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Goal.GoalLifecycleStatus> value)
    {
        Goal.GoalLifecycleStatus? a_ = (value /* CQL: 227:54-227:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentRule> value)
    {
        GraphDefinition.GraphCompartmentRule? a_ = (value /* CQL: 228:55-228:59 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GraphDefinition.GraphCompartmentUse> value)
    {
        GraphDefinition.GraphCompartmentUse? a_ = (value /* CQL: 229:54-229:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GroupMeasureCode> value)
    {
        GroupMeasureCode? a_ = (value /* CQL: 230:47-230:51 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Group.GroupType> value)
    {
        Group.GroupType? a_ = (value /* CQL: 231:44-231:48 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<GuidanceResponse.GuidanceResponseStatus> value)
    {
        GuidanceResponse.GuidanceResponseStatus? a_ = (value /* CQL: 232:57-232:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.GuidePageGeneration> value)
    {
        ImplementationGuide.GuidePageGeneration? a_ = (value /* CQL: 233:54-233:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.GuideParameterCode> value)
    {
        ImplementationGuide.GuideParameterCode? a_ = (value /* CQL: 234:53-234:57 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.HTTPVerb> value)
    {
        Bundle.HTTPVerb? a_ = (value /* CQL: 235:43-235:47 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Identifier.IdentifierUse> value)
    {
        Identifier.IdentifierUse? a_ = (value /* CQL: 236:48-236:52 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Person.IdentityAssuranceLevel> value)
    {
        Person.IdentityAssuranceLevel? a_ = (value /* CQL: 237:57-237:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImagingStudy.ImagingStudyStatus> value)
    {
        ImagingStudy.ImagingStudyStatus? a_ = (value /* CQL: 238:53-238:57 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> value)
    {
        ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? a_ = (value /* CQL: 239:63-239:67 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Immunization.ImmunizationStatusCodes> value)
    {
        Immunization.ImmunizationStatusCodes? a_ = (value /* CQL: 240:53-240:57 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Invoice.InvoiceStatus> value)
    {
        Invoice.InvoiceStatus? a_ = (value /* CQL: 242:48-242:52 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationOutcome.IssueSeverity> value)
    {
        OperationOutcome.IssueSeverity? a_ = (value /* CQL: 243:48-243:52 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationOutcome.IssueType> value)
    {
        OperationOutcome.IssueType? a_ = (value /* CQL: 244:44-244:48 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Patient.LinkType> value)
    {
        Patient.LinkType? a_ = (value /* CQL: 245:43-245:47 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Linkage.LinkageType> value)
    {
        Linkage.LinkageType? a_ = (value /* CQL: 246:46-246:50 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ListMode> value)
    {
        ListMode? a_ = (value /* CQL: 247:43-247:47 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<List.ListStatus> value)
    {
        List.ListStatus? a_ = (value /* CQL: 248:45-248:49 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Location.LocationMode> value)
    {
        Location.LocationMode? a_ = (value /* CQL: 249:47-249:51 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Location.LocationStatus> value)
    {
        Location.LocationStatus? a_ = (value /* CQL: 250:49-250:53 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportStatus> value)
    {
        MeasureReport.MeasureReportStatus? a_ = (value /* CQL: 251:54-251:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MeasureReport.MeasureReportType> value)
    {
        MeasureReport.MeasureReportType? a_ = (value /* CQL: 252:52-252:56 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationAdministration.MedicationAdministrationStatusCodes> value)
    {
        MedicationAdministration.MedicationAdministrationStatusCodes? a_ = (value /* CQL: 254:65-254:69 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationDispense.MedicationDispenseStatusCodes> value)
    {
        MedicationDispense.MedicationDispenseStatusCodes? a_ = (value /* CQL: 255:59-255:63 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationKnowledge.MedicationKnowledgeStatusCodes> value)
    {
        MedicationKnowledge.MedicationKnowledgeStatusCodes? a_ = (value /* CQL: 256:60-256:64 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationRequestIntent> value)
    {
        MedicationRequest.MedicationRequestIntent? a_ = (value /* CQL: 257:58-257:62 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationRequest.MedicationrequestStatus> value)
    {
        MedicationRequest.MedicationrequestStatus? a_ = (value /* CQL: 259:58-259:62 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MedicationStatement.MedicationStatusCodes> value)
    {
        MedicationStatement.MedicationStatusCodes? a_ = (value /* CQL: 260:60-260:64 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Medication.MedicationStatusCodes> value)
    {
        Medication.MedicationStatusCodes? a_ = (value /* CQL: 261:51-261:55 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageDefinition.MessageSignificanceCategory> value)
    {
        MessageDefinition.MessageSignificanceCategory? a_ = (value /* CQL: 262:62-262:66 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageheaderResponseRequest> value)
    {
        MessageheaderResponseRequest? a_ = (value /* CQL: 263:65-263:69 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code value)
    {
        string a_ = (value /* CQL: 264:43-264:47 */)?.Value /* CQL: 264:43-264:53 */;
        return a_ /* CQL: 264:43-264:53 */;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<HumanName.NameUse> value)
    {
        HumanName.NameUse? a_ = (value /* CQL: 265:42-265:46 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemIdentifierType> value)
    {
        NamingSystem.NamingSystemIdentifierType? a_ = (value /* CQL: 266:61-266:65 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NamingSystem.NamingSystemType> value)
    {
        NamingSystem.NamingSystemType? a_ = (value /* CQL: 267:51-267:55 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Narrative.NarrativeStatus> value)
    {
        Narrative.NarrativeStatus? a_ = (value /* CQL: 268:50-268:54 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<NoteType> value)
    {
        NoteType? a_ = (value /* CQL: 269:43-269:47 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RequestIntent> value)
    {
        RequestIntent? a_ = (value /* CQL: 270:56-270:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationDataType> value)
    {
        ObservationDefinition.ObservationDataType? a_ = (value /* CQL: 272:54-272:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ObservationDefinition.ObservationRangeCategory> value)
    {
        ObservationDefinition.ObservationRangeCategory? a_ = (value /* CQL: 273:59-273:63 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationDefinition.OperationKind> value)
    {
        OperationDefinition.OperationKind? a_ = (value /* CQL: 275:48-275:52 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<OperationParameterUse> value)
    {
        OperationParameterUse? a_ = (value /* CQL: 276:56-276:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.OrientationType> value)
    {
        MolecularSequence.OrientationType? a_ = (value /* CQL: 277:50-277:54 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Appointment.ParticipantRequired> value)
    {
        Appointment.ParticipantRequired? a_ = (value /* CQL: 279:54-279:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ParticipationStatus> value)
    {
        ParticipationStatus? a_ = (value /* CQL: 280:52-280:56 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.PropertyRepresentation> value)
    {
        ElementDefinition.PropertyRepresentation? a_ = (value /* CQL: 285:57-285:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CodeSystem.PropertyType> value)
    {
        CodeSystem.PropertyType? a_ = (value /* CQL: 286:47-286:51 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Provenance.ProvenanceEntityRole> value)
    {
        Provenance.ProvenanceEntityRole? a_ = (value /* CQL: 287:55-287:59 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<PublicationStatus> value)
    {
        PublicationStatus? a_ = (value /* CQL: 288:52-288:56 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.QualityType> value)
    {
        MolecularSequence.QualityType? a_ = (value /* CQL: 289:46-289:50 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Quantity.QuantityComparator> value)
    {
        Quantity.QuantityComparator? a_ = (value /* CQL: 290:53-290:57 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemOperator> value)
    {
        Questionnaire.QuestionnaireItemOperator? a_ = (value /* CQL: 291:60-291:64 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Questionnaire.QuestionnaireItemType> value)
    {
        Questionnaire.QuestionnaireItemType? a_ = (value /* CQL: 292:56-292:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<QuestionnaireResponse.QuestionnaireResponseStatus> value)
    {
        QuestionnaireResponse.QuestionnaireResponseStatus? a_ = (value /* CQL: 293:62-293:66 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ReferenceHandlingPolicy> value)
    {
        CapabilityStatement.ReferenceHandlingPolicy? a_ = (value /* CQL: 294:58-294:62 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.ReferenceVersionRules> value)
    {
        ElementDefinition.ReferenceVersionRules? a_ = (value /* CQL: 295:56-295:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<RelatedArtifact.RelatedArtifactType> value)
    {
        RelatedArtifact.RelatedArtifactType? a_ = (value /* CQL: 297:54-297:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClaimProcessingCodes> value)
    {
        ClaimProcessingCodes? a_ = (value /* CQL: 298:52-298:56 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.RepositoryType> value)
    {
        MolecularSequence.RepositoryType? a_ = (value /* CQL: 299:49-299:53 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchElementDefinition.ResearchElementType> value)
    {
        ResearchElementDefinition.ResearchElementType? a_ = (value /* CQL: 303:54-303:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchStudy.ResearchStudyStatus> value)
    {
        ResearchStudy.ResearchStudyStatus? a_ = (value /* CQL: 304:54-304:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ResearchSubject.ResearchSubjectStatus> value)
    {
        ResearchSubject.ResearchSubjectStatus? a_ = (value /* CQL: 305:56-305:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.ResourceVersionPolicy> value)
    {
        CapabilityStatement.ResourceVersionPolicy? a_ = (value /* CQL: 307:56-307:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MessageHeader.ResponseType> value)
    {
        MessageHeader.ResponseType? a_ = (value /* CQL: 308:47-308:51 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.RestfulCapabilityMode> value)
    {
        CapabilityStatement.RestfulCapabilityMode? a_ = (value /* CQL: 309:56-309:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ImplementationGuide.SPDXLicense> value)
    {
        ImplementationGuide.SPDXLicense? a_ = (value /* CQL: 311:46-311:50 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.SearchComparator> value)
    {
        SearchParameter.SearchComparator? a_ = (value /* CQL: 312:51-312:55 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Bundle.SearchEntryMode> value)
    {
        Bundle.SearchEntryMode? a_ = (value /* CQL: 313:50-313:54 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.SearchModifierCode> value)
    {
        SearchParameter.SearchModifierCode? a_ = (value /* CQL: 314:53-314:57 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParamType> value)
    {
        SearchParamType? a_ = (value /* CQL: 315:50-315:54 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.SequenceType> value)
    {
        MolecularSequence.SequenceType? a_ = (value /* CQL: 317:47-317:51 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ElementDefinition.SlicingRules> value)
    {
        ElementDefinition.SlicingRules? a_ = (value /* CQL: 321:47-321:51 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Slot.SlotStatus> value)
    {
        Slot.SlotStatus? a_ = (value /* CQL: 322:45-322:49 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<DataRequirement.SortDirection> value)
    {
        DataRequirement.SortDirection? a_ = (value /* CQL: 323:48-323:52 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SpecimenDefinition.SpecimenContainedPreference> value)
    {
        SpecimenDefinition.SpecimenContainedPreference? a_ = (value /* CQL: 324:62-324:66 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Specimen.SpecimenStatus> value)
    {
        Specimen.SpecimenStatus? a_ = (value /* CQL: 325:49-325:53 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VerificationResult.StatusCode> value)
    {
        VerificationResult.StatusCode? a_ = (value /* CQL: 326:41-326:45 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<MolecularSequence.StrandType> value)
    {
        MolecularSequence.StrandType? a_ = (value /* CQL: 327:45-327:49 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.StructureDefinitionKind> value)
    {
        StructureDefinition.StructureDefinitionKind? a_ = (value /* CQL: 328:58-328:62 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapContextType> value)
    {
        StructureMap.StructureMapContextType? a_ = (value /* CQL: 329:58-329:62 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapGroupTypeMode> value)
    {
        StructureMap.StructureMapGroupTypeMode? a_ = (value /* CQL: 330:60-330:64 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapInputMode> value)
    {
        StructureMap.StructureMapInputMode? a_ = (value /* CQL: 331:56-331:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapModelMode> value)
    {
        StructureMap.StructureMapModelMode? a_ = (value /* CQL: 332:56-332:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapSourceListMode> value)
    {
        StructureMap.StructureMapSourceListMode? a_ = (value /* CQL: 333:61-333:65 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTargetListMode> value)
    {
        StructureMap.StructureMapTargetListMode? a_ = (value /* CQL: 334:61-334:65 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureMap.StructureMapTransform> value)
    {
        StructureMap.StructureMapTransform? a_ = (value /* CQL: 335:56-335:60 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Subscription.SubscriptionChannelType> value)
    {
        Subscription.SubscriptionChannelType? a_ = (value /* CQL: 336:58-336:62 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Subscription.SubscriptionStatus> value)
    {
        Subscription.SubscriptionStatus? a_ = (value /* CQL: 337:53-337:57 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SupplyDelivery.SupplyDeliveryStatus> value)
    {
        SupplyDelivery.SupplyDeliveryStatus? a_ = (value /* CQL: 338:55-338:59 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SupplyRequest.SupplyRequestStatus> value)
    {
        SupplyRequest.SupplyRequestStatus? a_ = (value /* CQL: 339:54-339:58 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.SystemRestfulInteraction> value)
    {
        CapabilityStatement.SystemRestfulInteraction? a_ = (value /* CQL: 340:59-340:63 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Task.TaskIntent> value)
    {
        Task.TaskIntent? a_ = (value /* CQL: 341:45-341:49 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Task.TaskStatus> value)
    {
        Task.TaskStatus? a_ = (value /* CQL: 343:45-343:49 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportActionResult> value)
    {
        TestReport.TestReportActionResult? a_ = (value /* CQL: 344:57-344:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportParticipantType> value)
    {
        TestReport.TestReportParticipantType? a_ = (value /* CQL: 345:60-345:64 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportResult> value)
    {
        TestReport.TestReportResult? a_ = (value /* CQL: 346:51-346:55 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestReport.TestReportStatus> value)
    {
        TestReport.TestReportStatus? a_ = (value /* CQL: 347:51-347:55 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TestScript.TestScriptRequestMethodCode> value)
    {
        TestScript.TestScriptRequestMethodCode? a_ = (value /* CQL: 348:62-348:66 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<TriggerDefinition.TriggerType> value)
    {
        TriggerDefinition.TriggerType? a_ = (value /* CQL: 349:46-349:50 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<StructureDefinition.TypeDerivationRule> value)
    {
        StructureDefinition.TypeDerivationRule? a_ = (value /* CQL: 350:53-350:57 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<CapabilityStatement.TypeRestfulInteraction> value)
    {
        CapabilityStatement.TypeRestfulInteraction? a_ = (value /* CQL: 351:57-351:61 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Device.UDIEntryType> value)
    {
        Device.UDIEntryType? a_ = (value /* CQL: 352:47-352:51 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<Timing.UnitsOfTime> value)
    {
        Timing.UnitsOfTime? a_ = (value /* CQL: 353:46-353:50 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<ClaimUseCode> value)
    {
        ClaimUseCode? a_ = (value /* CQL: 354:38-354:42 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VisionPrescription.VisionBase> value)
    {
        VisionPrescription.VisionBase? a_ = (value /* CQL: 356:45-356:49 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<VisionPrescription.VisionEyes> value)
    {
        VisionPrescription.VisionEyes? a_ = (value /* CQL: 357:45-357:49 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Code<SearchParameter.XPathUsageType> value)
    {
        SearchParameter.XPathUsageType? a_ = (value /* CQL: 359:49-359:53 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, Base64Binary value)
    {
        byte[] a_ = (value /* CQL: 360:47-360:51 */)?.Value;
        string b_ = context.Operators.Convert<string>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, FhirString value)
    {
        string a_ = (value /* CQL: 367:41-367:45 */)?.Value /* CQL: 367:41-367:51 */;
        return a_ /* CQL: 367:41-367:51 */;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, FhirUri value)
    {
        string a_ = (value /* CQL: 369:38-369:42 */)?.Value /* CQL: 369:38-369:48 */;
        return a_ /* CQL: 369:38-369:48 */;
    }


    [CqlFunctionDefinition("ToString")]
    public string ToString(CqlContext context, XHtml value)
    {
        string a_ = (value /* CQL: 370:40-370:44 */)?.Value /* CQL: 370:40-370:50 */;
        return a_ /* CQL: 370:40-370:50 */;
    }


    [CqlFunctionDefinition("ToBoolean")]
    public bool? ToBoolean(CqlContext context, FhirBoolean value)
    {
        bool? a_ = (value /* CQL: 361:43-361:47 */)?.Value /* CQL: 361:43-361:53 */;
        return a_ /* CQL: 361:43-361:53 */;
    }


    [CqlFunctionDefinition("ToDate")]
    public CqlDate ToDate(CqlContext context, Date value)
    {
        string a_ = (value /* CQL: 362:37-362:41 */)?.Value;
        CqlDate b_ = context.Operators.ConvertStringToDate(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToDateTime")]
    public CqlDateTime ToDateTime(CqlContext context, FhirDateTime value)
    {
        CqlDateTime a_ = context.Operators.Convert<CqlDateTime>(value /* CQL: 363:45-363:49 */);
        return a_;
    }


    [CqlFunctionDefinition("ToDateTime")]
    public CqlDateTime ToDateTime(CqlContext context, Instant value)
    {
        DateTimeOffset? a_ = (value /* CQL: 365:44-365:48 */)?.Value;
        CqlDateTime b_ = context.Operators.Convert<CqlDateTime>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToDecimal")]
    public decimal? ToDecimal(CqlContext context, FhirDecimal value)
    {
        decimal? a_ = (value /* CQL: 364:43-364:47 */)?.Value /* CQL: 364:43-364:53 */;
        return a_ /* CQL: 364:43-364:53 */;
    }


    [CqlFunctionDefinition("ToInteger")]
    public int? ToInteger(CqlContext context, Integer value)
    {
        int? a_ = (value /* CQL: 366:43-366:47 */)?.Value /* CQL: 366:43-366:53 */;
        return a_ /* CQL: 366:43-366:53 */;
    }


    [CqlFunctionDefinition("ToTime")]
    public CqlTime ToTime(CqlContext context, Time value)
    {
        string a_ = (value /* CQL: 368:37-368:41 */)?.Value;
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

    #region Nested Type - Cached<T>

    private struct Cached<T>(long CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is 0)
            {
                // No caching, clear out previous values
                CacheVersion = 0;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (CacheVersion == cqlContextCacheVersion)
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

}

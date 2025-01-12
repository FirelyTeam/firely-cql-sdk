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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.9.0")]
[CqlLibrary("CumulativeMedicationDuration", "4.1.000")]
public partial class CumulativeMedicationDuration_4_1_000 : ILibrary, ISingleton<CumulativeMedicationDuration_4_1_000>
{
    private CumulativeMedicationDuration_4_1_000() {}

    public static CumulativeMedicationDuration_4_1_000 Instance { get; } = new();

    #region ILibrary Members
    string ILibrary.Name => "CumulativeMedicationDuration";
    string ILibrary.Version => "4.1.000";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance];
    #endregion Library Members

    [CqlDeclaration("HS")]
    public CqlCode HS(CqlContext context) =>
        new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);


    [CqlDeclaration("WAKE")]
    public CqlCode WAKE(CqlContext context) =>
        new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);


    [CqlDeclaration("C")]
    public CqlCode C(CqlContext context) =>
        new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);


    [CqlDeclaration("CM")]
    public CqlCode CM(CqlContext context) =>
        new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);


    [CqlDeclaration("CD")]
    public CqlCode CD(CqlContext context) =>
        new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);


    [CqlDeclaration("CV")]
    public CqlCode CV(CqlContext context) =>
        new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);


    [CqlDeclaration("AC")]
    public CqlCode AC(CqlContext context) =>
        new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);


    [CqlDeclaration("ACM")]
    public CqlCode ACM(CqlContext context) =>
        new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);


    [CqlDeclaration("ACD")]
    public CqlCode ACD(CqlContext context) =>
        new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);


    [CqlDeclaration("ACV")]
    public CqlCode ACV(CqlContext context) =>
        new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);


    [CqlDeclaration("PC")]
    public CqlCode PC(CqlContext context) =>
        new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);


    [CqlDeclaration("PCM")]
    public CqlCode PCM(CqlContext context) =>
        new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);


    [CqlDeclaration("PCD")]
    public CqlCode PCD(CqlContext context) =>
        new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);


    [CqlDeclaration("PCV")]
    public CqlCode PCV(CqlContext context) =>
        new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default);


    [CqlDeclaration("MORN")]
    public CqlCode MORN(CqlContext context) =>
        new CqlCode("MORN", "http://hl7.org/fhir/event-timing", default, default);


    [CqlDeclaration("MORN.early")]
    public CqlCode MORN_early(CqlContext context) =>
        new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", default, default);


    [CqlDeclaration("MORN.late")]
    public CqlCode MORN_late(CqlContext context) =>
        new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", default, default);


    [CqlDeclaration("NOON")]
    public CqlCode NOON(CqlContext context) =>
        new CqlCode("NOON", "http://hl7.org/fhir/event-timing", default, default);


    [CqlDeclaration("AFT")]
    public CqlCode AFT(CqlContext context) =>
        new CqlCode("AFT", "http://hl7.org/fhir/event-timing", default, default);


    [CqlDeclaration("AFT.early")]
    public CqlCode AFT_early(CqlContext context) =>
        new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", default, default);


    [CqlDeclaration("AFT.late")]
    public CqlCode AFT_late(CqlContext context) =>
        new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", default, default);


    [CqlDeclaration("EVE")]
    public CqlCode EVE(CqlContext context) =>
        new CqlCode("EVE", "http://hl7.org/fhir/event-timing", default, default);


    [CqlDeclaration("EVE.early")]
    public CqlCode EVE_early(CqlContext context) =>
        new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", default, default);


    [CqlDeclaration("EVE.late")]
    public CqlCode EVE_late(CqlContext context) =>
        new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", default, default);


    [CqlDeclaration("NIGHT")]
    public CqlCode NIGHT(CqlContext context) =>
        new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", default, default);


    [CqlDeclaration("PHS")]
    public CqlCode PHS(CqlContext context) =>
        new CqlCode("PHS", "http://hl7.org/fhir/event-timing", default, default);


    [CqlDeclaration("Every eight hours (qualifier value)")]
    public CqlCode Every_eight_hours__qualifier_value_(CqlContext context) =>
        new CqlCode("307469008", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Every eight to twelve hours (qualifier value)")]
    public CqlCode Every_eight_to_twelve_hours__qualifier_value_(CqlContext context) =>
        new CqlCode("396140003", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Every forty eight hours (qualifier value)")]
    public CqlCode Every_forty_eight_hours__qualifier_value_(CqlContext context) =>
        new CqlCode("396131002", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Every forty hours (qualifier value)")]
    public CqlCode Every_forty_hours__qualifier_value_(CqlContext context) =>
        new CqlCode("396130001", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Every four hours (qualifier value)")]
    public CqlCode Every_four_hours__qualifier_value_(CqlContext context) =>
        new CqlCode("225756002", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Every seventy two hours (qualifier value)")]
    public CqlCode Every_seventy_two_hours__qualifier_value_(CqlContext context) =>
        new CqlCode("396143001", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Every six hours (qualifier value)")]
    public CqlCode Every_six_hours__qualifier_value_(CqlContext context) =>
        new CqlCode("307468000", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Every six to eight hours (qualifier value)")]
    public CqlCode Every_six_to_eight_hours__qualifier_value_(CqlContext context) =>
        new CqlCode("396139000", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Every thirty six hours (qualifier value)")]
    public CqlCode Every_thirty_six_hours__qualifier_value_(CqlContext context) =>
        new CqlCode("396126004", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Every three to four hours (qualifier value)")]
    public CqlCode Every_three_to_four_hours__qualifier_value_(CqlContext context) =>
        new CqlCode("225754004", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Every three to six hours (qualifier value)")]
    public CqlCode Every_three_to_six_hours__qualifier_value_(CqlContext context) =>
        new CqlCode("396127008", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Every twelve hours (qualifier value)")]
    public CqlCode Every_twelve_hours__qualifier_value_(CqlContext context) =>
        new CqlCode("307470009", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Every twenty four hours (qualifier value)")]
    public CqlCode Every_twenty_four_hours__qualifier_value_(CqlContext context) =>
        new CqlCode("396125000", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Every two to four hours (qualifier value)")]
    public CqlCode Every_two_to_four_hours__qualifier_value_(CqlContext context) =>
        new CqlCode("225752000", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Four times daily (qualifier value)")]
    public CqlCode Four_times_daily__qualifier_value_(CqlContext context) =>
        new CqlCode("307439001", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Once daily (qualifier value)")]
    public CqlCode Once_daily__qualifier_value_(CqlContext context) =>
        new CqlCode("229797004", "http://snomed.info/sct", default, default);


    [CqlDeclaration("One to four times a day (qualifier value)")]
    public CqlCode One_to_four_times_a_day__qualifier_value_(CqlContext context) =>
        new CqlCode("396109005", "http://snomed.info/sct", default, default);


    [CqlDeclaration("One to three times a day (qualifier value)")]
    public CqlCode One_to_three_times_a_day__qualifier_value_(CqlContext context) =>
        new CqlCode("396108002", "http://snomed.info/sct", default, default);


    [CqlDeclaration("One to two times a day (qualifier value)")]
    public CqlCode One_to_two_times_a_day__qualifier_value_(CqlContext context) =>
        new CqlCode("396107007", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Three times daily (qualifier value)")]
    public CqlCode Three_times_daily__qualifier_value_(CqlContext context) =>
        new CqlCode("229798009", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Twice a day (qualifier value)")]
    public CqlCode Twice_a_day__qualifier_value_(CqlContext context) =>
        new CqlCode("229799001", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Two to four times a day (qualifier value)")]
    public CqlCode Two_to_four_times_a_day__qualifier_value_(CqlContext context) =>
        new CqlCode("396111001", "http://snomed.info/sct", default, default);


    [CqlDeclaration("V3TimingEvent")]
    public CqlCode[] V3TimingEvent(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
            new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("EventTiming")]
    public CqlCode[] EventTiming(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("MORN", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("NOON", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("AFT", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("EVE", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", default, default),
            new CqlCode("PHS", "http://hl7.org/fhir/event-timing", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("ErrorLevel")]
    public string ErrorLevel(CqlContext context)
    {
        object a_ = context.ResolveParameter("CumulativeMedicationDuration-4.1.000", "ErrorLevel", "Warning");

        return (string)a_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        decimal? a_()
        {
            bool b_()
            {
                string w_ = period?.unit;
                bool? x_ = context.Operators.Equal(w_, "h");

                return x_ ?? false;
            };
            bool c_()
            {
                string y_ = period?.unit;
                bool? z_ = context.Operators.Equal(y_, "min");

                return z_ ?? false;
            };
            bool d_()
            {
                string aa_ = period?.unit;
                bool? ab_ = context.Operators.Equal(aa_, "s");

                return ab_ ?? false;
            };
            bool e_()
            {
                string ac_ = period?.unit;
                bool? ad_ = context.Operators.Equal(ac_, "d");

                return ad_ ?? false;
            };
            bool f_()
            {
                string ae_ = period?.unit;
                bool? af_ = context.Operators.Equal(ae_, "wk");

                return af_ ?? false;
            };
            bool g_()
            {
                string ag_ = period?.unit;
                bool? ah_ = context.Operators.Equal(ag_, "mo");

                return ah_ ?? false;
            };
            bool h_()
            {
                string ai_ = period?.unit;
                bool? aj_ = context.Operators.Equal(ai_, "a");

                return aj_ ?? false;
            };
            bool i_()
            {
                string ak_ = period?.unit;
                bool? al_ = context.Operators.Equal(ak_, "hour");

                return al_ ?? false;
            };
            bool j_()
            {
                string am_ = period?.unit;
                bool? an_ = context.Operators.Equal(am_, "minute");

                return an_ ?? false;
            };
            bool k_()
            {
                string ao_ = period?.unit;
                bool? ap_ = context.Operators.Equal(ao_, "second");

                return ap_ ?? false;
            };
            bool l_()
            {
                string aq_ = period?.unit;
                bool? ar_ = context.Operators.Equal(aq_, "day");

                return ar_ ?? false;
            };
            bool m_()
            {
                string as_ = period?.unit;
                bool? at_ = context.Operators.Equal(as_, "week");

                return at_ ?? false;
            };
            bool n_()
            {
                string au_ = period?.unit;
                bool? av_ = context.Operators.Equal(au_, "month");

                return av_ ?? false;
            };
            bool o_()
            {
                string aw_ = period?.unit;
                bool? ax_ = context.Operators.Equal(aw_, "year");

                return ax_ ?? false;
            };
            bool p_()
            {
                string ay_ = period?.unit;
                bool? az_ = context.Operators.Equal(ay_, "hours");

                return az_ ?? false;
            };
            bool q_()
            {
                string ba_ = period?.unit;
                bool? bb_ = context.Operators.Equal(ba_, "minutes");

                return bb_ ?? false;
            };
            bool r_()
            {
                string bc_ = period?.unit;
                bool? bd_ = context.Operators.Equal(bc_, "seconds");

                return bd_ ?? false;
            };
            bool s_()
            {
                string be_ = period?.unit;
                bool? bf_ = context.Operators.Equal(be_, "days");

                return bf_ ?? false;
            };
            bool t_()
            {
                string bg_ = period?.unit;
                bool? bh_ = context.Operators.Equal(bg_, "weeks");

                return bh_ ?? false;
            };
            bool u_()
            {
                string bi_ = period?.unit;
                bool? bj_ = context.Operators.Equal(bi_, "months");

                return bj_ ?? false;
            };
            bool v_()
            {
                string bk_ = period?.unit;
                bool? bl_ = context.Operators.Equal(bk_, "years");

                return bl_ ?? false;
            };
            if (b_())
            {
                decimal? bm_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? bn_ = period?.value;
                decimal? bo_ = context.Operators.Divide(24.0m, bn_);
                decimal? bp_ = context.Operators.Multiply(bm_, bo_);

                return bp_;
            }
            else if (c_())
            {
                decimal? bq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? br_ = period?.value;
                decimal? bs_ = context.Operators.Divide(24.0m, br_);
                decimal? bt_ = context.Operators.Multiply(bq_, bs_);
                decimal? bu_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? bv_ = context.Operators.Multiply(bt_, bu_);

                return bv_;
            }
            else if (d_())
            {
                decimal? bw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? bx_ = period?.value;
                decimal? by_ = context.Operators.Divide(24.0m, bx_);
                decimal? bz_ = context.Operators.Multiply(bw_, by_);
                decimal? ca_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? cb_ = context.Operators.Multiply(bz_, ca_);
                decimal? cd_ = context.Operators.Multiply(cb_, ca_);

                return cd_;
            }
            else if (e_())
            {
                decimal? ce_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cf_ = period?.value;
                decimal? cg_ = context.Operators.Divide(24.0m, cf_);
                decimal? ch_ = context.Operators.Multiply(ce_, cg_);
                decimal? ci_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? cj_ = context.Operators.Divide(ch_, ci_);

                return cj_;
            }
            else if (f_())
            {
                decimal? ck_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cl_ = period?.value;
                decimal? cm_ = context.Operators.Divide(24.0m, cl_);
                decimal? cn_ = context.Operators.Multiply(ck_, cm_);
                int? co_ = context.Operators.Multiply(24, 7);
                decimal? cp_ = context.Operators.ConvertIntegerToDecimal(co_);
                decimal? cq_ = context.Operators.Divide(cn_, cp_);

                return cq_;
            }
            else if (g_())
            {
                decimal? cr_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cs_ = period?.value;
                decimal? ct_ = context.Operators.Divide(24.0m, cs_);
                decimal? cu_ = context.Operators.Multiply(cr_, ct_);
                int? cv_ = context.Operators.Multiply(24, 30);
                decimal? cw_ = context.Operators.ConvertIntegerToDecimal(cv_);
                decimal? cx_ = context.Operators.Divide(cu_, cw_);

                return cx_;
            }
            else if (h_())
            {
                decimal? cy_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cz_ = period?.value;
                decimal? da_ = context.Operators.Divide(24.0m, cz_);
                decimal? db_ = context.Operators.Multiply(cy_, da_);
                int? dc_ = context.Operators.Multiply(24, 365);
                decimal? dd_ = context.Operators.ConvertIntegerToDecimal(dc_);
                decimal? de_ = context.Operators.Divide(db_, dd_);

                return de_;
            }
            else if (i_())
            {
                decimal? df_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dg_ = period?.value;
                decimal? dh_ = context.Operators.Divide(24.0m, dg_);
                decimal? di_ = context.Operators.Multiply(df_, dh_);

                return di_;
            }
            else if (j_())
            {
                decimal? dj_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dk_ = period?.value;
                decimal? dl_ = context.Operators.Divide(24.0m, dk_);
                decimal? dm_ = context.Operators.Multiply(dj_, dl_);
                decimal? dn_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? do_ = context.Operators.Multiply(dm_, dn_);

                return do_;
            }
            else if (k_())
            {
                decimal? dp_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dq_ = period?.value;
                decimal? dr_ = context.Operators.Divide(24.0m, dq_);
                decimal? ds_ = context.Operators.Multiply(dp_, dr_);
                decimal? dt_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? du_ = context.Operators.Multiply(ds_, dt_);
                decimal? dw_ = context.Operators.Multiply(du_, dt_);

                return dw_;
            }
            else if (l_())
            {
                decimal? dx_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dy_ = period?.value;
                decimal? dz_ = context.Operators.Divide(24.0m, dy_);
                decimal? ea_ = context.Operators.Multiply(dx_, dz_);
                decimal? eb_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? ec_ = context.Operators.Divide(ea_, eb_);

                return ec_;
            }
            else if (m_())
            {
                decimal? ed_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ee_ = period?.value;
                decimal? ef_ = context.Operators.Divide(24.0m, ee_);
                decimal? eg_ = context.Operators.Multiply(ed_, ef_);
                int? eh_ = context.Operators.Multiply(24, 7);
                decimal? ei_ = context.Operators.ConvertIntegerToDecimal(eh_);
                decimal? ej_ = context.Operators.Divide(eg_, ei_);

                return ej_;
            }
            else if (n_())
            {
                decimal? ek_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? el_ = period?.value;
                decimal? em_ = context.Operators.Divide(24.0m, el_);
                decimal? en_ = context.Operators.Multiply(ek_, em_);
                int? eo_ = context.Operators.Multiply(24, 30);
                decimal? ep_ = context.Operators.ConvertIntegerToDecimal(eo_);
                decimal? eq_ = context.Operators.Divide(en_, ep_);

                return eq_;
            }
            else if (o_())
            {
                decimal? er_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? es_ = period?.value;
                decimal? et_ = context.Operators.Divide(24.0m, es_);
                decimal? eu_ = context.Operators.Multiply(er_, et_);
                int? ev_ = context.Operators.Multiply(24, 365);
                decimal? ew_ = context.Operators.ConvertIntegerToDecimal(ev_);
                decimal? ex_ = context.Operators.Divide(eu_, ew_);

                return ex_;
            }
            else if (p_())
            {
                decimal? ey_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ez_ = period?.value;
                decimal? fa_ = context.Operators.Divide(24.0m, ez_);
                decimal? fb_ = context.Operators.Multiply(ey_, fa_);

                return fb_;
            }
            else if (q_())
            {
                decimal? fc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fd_ = period?.value;
                decimal? fe_ = context.Operators.Divide(24.0m, fd_);
                decimal? ff_ = context.Operators.Multiply(fc_, fe_);
                decimal? fg_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? fh_ = context.Operators.Multiply(ff_, fg_);

                return fh_;
            }
            else if (r_())
            {
                decimal? fi_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fj_ = period?.value;
                decimal? fk_ = context.Operators.Divide(24.0m, fj_);
                decimal? fl_ = context.Operators.Multiply(fi_, fk_);
                decimal? fm_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? fn_ = context.Operators.Multiply(fl_, fm_);
                decimal? fp_ = context.Operators.Multiply(fn_, fm_);

                return fp_;
            }
            else if (s_())
            {
                decimal? fq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fr_ = period?.value;
                decimal? fs_ = context.Operators.Divide(24.0m, fr_);
                decimal? ft_ = context.Operators.Multiply(fq_, fs_);
                decimal? fu_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? fv_ = context.Operators.Divide(ft_, fu_);

                return fv_;
            }
            else if (t_())
            {
                decimal? fw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fx_ = period?.value;
                decimal? fy_ = context.Operators.Divide(24.0m, fx_);
                decimal? fz_ = context.Operators.Multiply(fw_, fy_);
                int? ga_ = context.Operators.Multiply(24, 7);
                decimal? gb_ = context.Operators.ConvertIntegerToDecimal(ga_);
                decimal? gc_ = context.Operators.Divide(fz_, gb_);

                return gc_;
            }
            else if (u_())
            {
                decimal? gd_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ge_ = period?.value;
                decimal? gf_ = context.Operators.Divide(24.0m, ge_);
                decimal? gg_ = context.Operators.Multiply(gd_, gf_);
                int? gh_ = context.Operators.Multiply(24, 30);
                decimal? gi_ = context.Operators.ConvertIntegerToDecimal(gh_);
                decimal? gj_ = context.Operators.Divide(gg_, gi_);

                return gj_;
            }
            else if (v_())
            {
                decimal? gk_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gl_ = period?.value;
                decimal? gm_ = context.Operators.Divide(24.0m, gl_);
                decimal? gn_ = context.Operators.Multiply(gk_, gm_);
                int? go_ = context.Operators.Multiply(24, 365);
                decimal? gp_ = context.Operators.ConvertIntegerToDecimal(go_);
                decimal? gq_ = context.Operators.Divide(gn_, gp_);

                return gq_;
            }
            else
            {
                string gr_ = this.ErrorLevel(context);
                string gs_ = period?.unit;
                string gt_ = context.Operators.Concatenate("Unknown unit ", gs_ ?? "");
                object gu_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", gr_, gt_);

                return gu_ as decimal?;
            }
        };

        return a_();
    }


    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        decimal? a_()
        {
            bool b_()
            {
                CqlCode aw_ = this.HS(context);
                bool? ax_ = context.Operators.Equivalent(frequency, aw_);

                return ax_ ?? false;
            };
            bool c_()
            {
                CqlCode ay_ = this.WAKE(context);
                bool? az_ = context.Operators.Equivalent(frequency, ay_);

                return az_ ?? false;
            };
            bool d_()
            {
                CqlCode ba_ = this.C(context);
                bool? bb_ = context.Operators.Equivalent(frequency, ba_);

                return bb_ ?? false;
            };
            bool e_()
            {
                CqlCode bc_ = this.CM(context);
                bool? bd_ = context.Operators.Equivalent(frequency, bc_);

                return bd_ ?? false;
            };
            bool f_()
            {
                CqlCode be_ = this.CD(context);
                bool? bf_ = context.Operators.Equivalent(frequency, be_);

                return bf_ ?? false;
            };
            bool g_()
            {
                CqlCode bg_ = this.CV(context);
                bool? bh_ = context.Operators.Equivalent(frequency, bg_);

                return bh_ ?? false;
            };
            bool h_()
            {
                CqlCode bi_ = this.AC(context);
                bool? bj_ = context.Operators.Equivalent(frequency, bi_);

                return bj_ ?? false;
            };
            bool i_()
            {
                CqlCode bk_ = this.ACM(context);
                bool? bl_ = context.Operators.Equivalent(frequency, bk_);

                return bl_ ?? false;
            };
            bool j_()
            {
                CqlCode bm_ = this.ACD(context);
                bool? bn_ = context.Operators.Equivalent(frequency, bm_);

                return bn_ ?? false;
            };
            bool k_()
            {
                CqlCode bo_ = this.ACV(context);
                bool? bp_ = context.Operators.Equivalent(frequency, bo_);

                return bp_ ?? false;
            };
            bool l_()
            {
                CqlCode bq_ = this.PC(context);
                bool? br_ = context.Operators.Equivalent(frequency, bq_);

                return br_ ?? false;
            };
            bool m_()
            {
                CqlCode bs_ = this.PCM(context);
                bool? bt_ = context.Operators.Equivalent(frequency, bs_);

                return bt_ ?? false;
            };
            bool n_()
            {
                CqlCode bu_ = this.PCD(context);
                bool? bv_ = context.Operators.Equivalent(frequency, bu_);

                return bv_ ?? false;
            };
            bool o_()
            {
                CqlCode bw_ = this.PCV(context);
                bool? bx_ = context.Operators.Equivalent(frequency, bw_);

                return bx_ ?? false;
            };
            bool p_()
            {
                CqlCode by_ = this.MORN(context);
                bool? bz_ = context.Operators.Equivalent(frequency, by_);

                return bz_ ?? false;
            };
            bool q_()
            {
                CqlCode ca_ = this.MORN_early(context);
                bool? cb_ = context.Operators.Equivalent(frequency, ca_);

                return cb_ ?? false;
            };
            bool r_()
            {
                CqlCode cc_ = this.MORN_late(context);
                bool? cd_ = context.Operators.Equivalent(frequency, cc_);

                return cd_ ?? false;
            };
            bool s_()
            {
                CqlCode ce_ = this.NOON(context);
                bool? cf_ = context.Operators.Equivalent(frequency, ce_);

                return cf_ ?? false;
            };
            bool t_()
            {
                CqlCode cg_ = this.AFT(context);
                bool? ch_ = context.Operators.Equivalent(frequency, cg_);

                return ch_ ?? false;
            };
            bool u_()
            {
                CqlCode ci_ = this.AFT_early(context);
                bool? cj_ = context.Operators.Equivalent(frequency, ci_);

                return cj_ ?? false;
            };
            bool v_()
            {
                CqlCode ck_ = this.AFT_late(context);
                bool? cl_ = context.Operators.Equivalent(frequency, ck_);

                return cl_ ?? false;
            };
            bool w_()
            {
                CqlCode cm_ = this.EVE(context);
                bool? cn_ = context.Operators.Equivalent(frequency, cm_);

                return cn_ ?? false;
            };
            bool x_()
            {
                CqlCode co_ = this.EVE_early(context);
                bool? cp_ = context.Operators.Equivalent(frequency, co_);

                return cp_ ?? false;
            };
            bool y_()
            {
                CqlCode cq_ = this.EVE_late(context);
                bool? cr_ = context.Operators.Equivalent(frequency, cq_);

                return cr_ ?? false;
            };
            bool z_()
            {
                CqlCode cs_ = this.NIGHT(context);
                bool? ct_ = context.Operators.Equivalent(frequency, cs_);

                return ct_ ?? false;
            };
            bool aa_()
            {
                CqlCode cu_ = this.PHS(context);
                bool? cv_ = context.Operators.Equivalent(frequency, cu_);

                return cv_ ?? false;
            };
            bool ab_()
            {
                CqlCode cw_ = this.Once_daily__qualifier_value_(context);
                bool? cx_ = context.Operators.Equivalent(frequency, cw_);

                return cx_ ?? false;
            };
            bool ac_()
            {
                CqlCode cy_ = this.Twice_a_day__qualifier_value_(context);
                bool? cz_ = context.Operators.Equivalent(frequency, cy_);

                return cz_ ?? false;
            };
            bool ad_()
            {
                CqlCode da_ = this.Three_times_daily__qualifier_value_(context);
                bool? db_ = context.Operators.Equivalent(frequency, da_);

                return db_ ?? false;
            };
            bool ae_()
            {
                CqlCode dc_ = this.Four_times_daily__qualifier_value_(context);
                bool? dd_ = context.Operators.Equivalent(frequency, dc_);

                return dd_ ?? false;
            };
            bool af_()
            {
                CqlCode de_ = this.Every_twenty_four_hours__qualifier_value_(context);
                bool? df_ = context.Operators.Equivalent(frequency, de_);

                return df_ ?? false;
            };
            bool ag_()
            {
                CqlCode dg_ = this.Every_twelve_hours__qualifier_value_(context);
                bool? dh_ = context.Operators.Equivalent(frequency, dg_);

                return dh_ ?? false;
            };
            bool ah_()
            {
                CqlCode di_ = this.Every_thirty_six_hours__qualifier_value_(context);
                bool? dj_ = context.Operators.Equivalent(frequency, di_);

                return dj_ ?? false;
            };
            bool ai_()
            {
                CqlCode dk_ = this.Every_eight_hours__qualifier_value_(context);
                bool? dl_ = context.Operators.Equivalent(frequency, dk_);

                return dl_ ?? false;
            };
            bool aj_()
            {
                CqlCode dm_ = this.Every_four_hours__qualifier_value_(context);
                bool? dn_ = context.Operators.Equivalent(frequency, dm_);

                return dn_ ?? false;
            };
            bool ak_()
            {
                CqlCode do_ = this.Every_six_hours__qualifier_value_(context);
                bool? dp_ = context.Operators.Equivalent(frequency, do_);

                return dp_ ?? false;
            };
            bool al_()
            {
                CqlCode dq_ = this.Every_seventy_two_hours__qualifier_value_(context);
                bool? dr_ = context.Operators.Equivalent(frequency, dq_);

                return dr_ ?? false;
            };
            bool am_()
            {
                CqlCode ds_ = this.Every_forty_eight_hours__qualifier_value_(context);
                bool? dt_ = context.Operators.Equivalent(frequency, ds_);

                return dt_ ?? false;
            };
            bool an_()
            {
                CqlCode du_ = this.Every_eight_to_twelve_hours__qualifier_value_(context);
                bool? dv_ = context.Operators.Equivalent(frequency, du_);

                return dv_ ?? false;
            };
            bool ao_()
            {
                CqlCode dw_ = this.Every_six_to_eight_hours__qualifier_value_(context);
                bool? dx_ = context.Operators.Equivalent(frequency, dw_);

                return dx_ ?? false;
            };
            bool ap_()
            {
                CqlCode dy_ = this.Every_three_to_four_hours__qualifier_value_(context);
                bool? dz_ = context.Operators.Equivalent(frequency, dy_);

                return dz_ ?? false;
            };
            bool aq_()
            {
                CqlCode ea_ = this.Every_three_to_six_hours__qualifier_value_(context);
                bool? eb_ = context.Operators.Equivalent(frequency, ea_);

                return eb_ ?? false;
            };
            bool ar_()
            {
                CqlCode ec_ = this.Every_two_to_four_hours__qualifier_value_(context);
                bool? ed_ = context.Operators.Equivalent(frequency, ec_);

                return ed_ ?? false;
            };
            bool as_()
            {
                CqlCode ee_ = this.One_to_four_times_a_day__qualifier_value_(context);
                bool? ef_ = context.Operators.Equivalent(frequency, ee_);

                return ef_ ?? false;
            };
            bool at_()
            {
                CqlCode eg_ = this.One_to_three_times_a_day__qualifier_value_(context);
                bool? eh_ = context.Operators.Equivalent(frequency, eg_);

                return eh_ ?? false;
            };
            bool au_()
            {
                CqlCode ei_ = this.One_to_two_times_a_day__qualifier_value_(context);
                bool? ej_ = context.Operators.Equivalent(frequency, ei_);

                return ej_ ?? false;
            };
            bool av_()
            {
                CqlCode ek_ = this.Two_to_four_times_a_day__qualifier_value_(context);
                bool? el_ = context.Operators.Equivalent(frequency, ek_);

                return el_ ?? false;
            };
            if (b_())
            {
                decimal? em_ = context.Operators.ConvertIntegerToDecimal(1);

                return em_;
            }
            else if (c_())
            {
                decimal? en_ = context.Operators.ConvertIntegerToDecimal(1);

                return en_;
            }
            else if (d_())
            {
                decimal? eo_ = context.Operators.ConvertIntegerToDecimal(3);

                return eo_;
            }
            else if (e_())
            {
                decimal? ep_ = context.Operators.ConvertIntegerToDecimal(1);

                return ep_;
            }
            else if (f_())
            {
                decimal? eq_ = context.Operators.ConvertIntegerToDecimal(1);

                return eq_;
            }
            else if (g_())
            {
                decimal? er_ = context.Operators.ConvertIntegerToDecimal(1);

                return er_;
            }
            else if (h_())
            {
                decimal? es_ = context.Operators.ConvertIntegerToDecimal(3);

                return es_;
            }
            else if (i_())
            {
                decimal? et_ = context.Operators.ConvertIntegerToDecimal(1);

                return et_;
            }
            else if (j_())
            {
                decimal? eu_ = context.Operators.ConvertIntegerToDecimal(1);

                return eu_;
            }
            else if (k_())
            {
                decimal? ev_ = context.Operators.ConvertIntegerToDecimal(1);

                return ev_;
            }
            else if (l_())
            {
                decimal? ew_ = context.Operators.ConvertIntegerToDecimal(3);

                return ew_;
            }
            else if (m_())
            {
                decimal? ex_ = context.Operators.ConvertIntegerToDecimal(1);

                return ex_;
            }
            else if (n_())
            {
                decimal? ey_ = context.Operators.ConvertIntegerToDecimal(1);

                return ey_;
            }
            else if (o_())
            {
                decimal? ez_ = context.Operators.ConvertIntegerToDecimal(1);

                return ez_;
            }
            else if (p_())
            {
                decimal? fa_ = context.Operators.ConvertIntegerToDecimal(1);

                return fa_;
            }
            else if (q_())
            {
                decimal? fb_ = context.Operators.ConvertIntegerToDecimal(1);

                return fb_;
            }
            else if (r_())
            {
                decimal? fc_ = context.Operators.ConvertIntegerToDecimal(1);

                return fc_;
            }
            else if (s_())
            {
                decimal? fd_ = context.Operators.ConvertIntegerToDecimal(1);

                return fd_;
            }
            else if (t_())
            {
                decimal? fe_ = context.Operators.ConvertIntegerToDecimal(1);

                return fe_;
            }
            else if (u_())
            {
                decimal? ff_ = context.Operators.ConvertIntegerToDecimal(1);

                return ff_;
            }
            else if (v_())
            {
                decimal? fg_ = context.Operators.ConvertIntegerToDecimal(1);

                return fg_;
            }
            else if (w_())
            {
                decimal? fh_ = context.Operators.ConvertIntegerToDecimal(1);

                return fh_;
            }
            else if (x_())
            {
                decimal? fi_ = context.Operators.ConvertIntegerToDecimal(1);

                return fi_;
            }
            else if (y_())
            {
                decimal? fj_ = context.Operators.ConvertIntegerToDecimal(1);

                return fj_;
            }
            else if (z_())
            {
                decimal? fk_ = context.Operators.ConvertIntegerToDecimal(1);

                return fk_;
            }
            else if (aa_())
            {
                decimal? fl_ = context.Operators.ConvertIntegerToDecimal(1);

                return fl_;
            }
            else if (ab_())
            {
                return 1.0m;
            }
            else if (ac_())
            {
                return 2.0m;
            }
            else if (ad_())
            {
                return 3.0m;
            }
            else if (ae_())
            {
                return 4.0m;
            }
            else if (af_())
            {
                return 1.0m;
            }
            else if (ag_())
            {
                return 2.0m;
            }
            else if (ah_())
            {
                return 0.67m;
            }
            else if (ai_())
            {
                return 3.0m;
            }
            else if (aj_())
            {
                return 6.0m;
            }
            else if (ak_())
            {
                return 4.0m;
            }
            else if (al_())
            {
                return 0.33m;
            }
            else if (am_())
            {
                return 0.5m;
            }
            else if (an_())
            {
                return 3.0m;
            }
            else if (ao_())
            {
                return 4.0m;
            }
            else if (ap_())
            {
                return 8.0m;
            }
            else if (aq_())
            {
                return 8.0m;
            }
            else if (ar_())
            {
                return 12.0m;
            }
            else if (as_())
            {
                return 4.0m;
            }
            else if (at_())
            {
                return 3.0m;
            }
            else if (au_())
            {
                return 2.0m;
            }
            else if (av_())
            {
                return 4.0m;
            }
            else
            {
                string fm_ = this.ErrorLevel(context);
                string fn_ = frequency?.code;
                string fo_ = context.Operators.Concatenate("Unknown frequency code ", fn_ ?? "");
                object fp_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", fm_, fo_);

                return fp_ as decimal?;
            }
        };

        return a_();
    }


    public CqlQuantity Quantity(CqlContext context, decimal? value, string unit) =>
        ((context.Operators.Not((bool?)(value is null))) ?? false
            ? new CqlQuantity(value, unit)
            : default);


    public CqlInterval<CqlDate> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] a_ = [
            Request,
        ];
        CqlInterval<CqlDate> b_(MedicationRequest R)
        {
            CqlInterval<CqlDate> f_()
            {
                bool g_()
                {
                    List<Dosage> i_ = R?.DosageInstruction;
                    Dosage j_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing k_ = j_?.Timing;
                    Timing.RepeatComponent l_ = k_?.Repeat;
                    DataType m_ = l_?.Bounds;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    CqlDateTime o_ = context.Operators.Start(n_ as CqlInterval<CqlDateTime>);
                    CqlDate p_ = context.Operators.DateFrom(o_);
                    FhirDateTime q_ = R?.AuthoredOnElement;
                    CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
                    CqlDate s_ = context.Operators.DateFrom(r_);
                    MedicationRequest.DispenseRequestComponent t_ = R?.DispenseRequest;
                    Period u_ = t_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                    CqlDateTime w_ = context.Operators.Start(v_);
                    CqlDate x_ = context.Operators.DateFrom(w_);
                    bool? y_ = context.Operators.Not((bool?)(((p_ ?? s_) ?? x_) is null));
                    Duration aa_ = t_?.ExpectedSupplyDuration;
                    CqlQuantity ab_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aa_);
                    CqlQuantity ac_ = context.Operators.ConvertQuantity(ab_, "d");
                    decimal? ad_ = ac_?.value;
                    Quantity af_ = t_?.Quantity;
                    CqlQuantity ag_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, af_);
                    decimal? ah_ = ag_?.value;
                    Dosage aj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    List<Dosage.DoseAndRateComponent> ak_ = aj_?.DoseAndRate;
                    Dosage.DoseAndRateComponent al_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ak_);
                    DataType am_ = al_?.Dose;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    CqlQuantity ao_ = context.Operators.End(an_ as CqlInterval<CqlQuantity>);
                    Dosage aq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    List<Dosage.DoseAndRateComponent> ar_ = aq_?.DoseAndRate;
                    Dosage.DoseAndRateComponent as_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ar_);
                    DataType at_ = as_?.Dose;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    decimal? av_ = (ao_ ?? au_ as CqlQuantity)?.value;
                    Dosage ax_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing ay_ = ax_?.Timing;
                    Timing.RepeatComponent az_ = ay_?.Repeat;
                    PositiveInt ba_ = az_?.FrequencyMaxElement;
                    int? bb_ = ba_?.Value;
                    Dosage bd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing be_ = bd_?.Timing;
                    Timing.RepeatComponent bf_ = be_?.Repeat;
                    PositiveInt bg_ = bf_?.FrequencyElement;
                    int? bh_ = bg_?.Value;
                    Dosage bj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing bk_ = bj_?.Timing;
                    Timing.RepeatComponent bl_ = bk_?.Repeat;
                    FhirDecimal bm_ = bl_?.PeriodElement;
                    decimal? bn_ = bm_?.Value;
                    Dosage bp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing bq_ = bp_?.Timing;
                    Timing.RepeatComponent br_ = bq_?.Repeat;
                    Code<Timing.UnitsOfTime> bs_ = br_?.PeriodUnitElement;
                    Timing.UnitsOfTime? bt_ = bs_?.Value;
                    string bu_ = context.Operators.Convert<string>(bt_);
                    CqlQuantity bv_ = this.Quantity(context, bn_, bu_);
                    decimal? bw_ = this.ToDaily(context, bb_ ?? bh_, bv_);
                    Dosage by_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing bz_ = by_?.Timing;
                    Timing.RepeatComponent ca_ = bz_?.Repeat;
                    List<Time> cb_ = ca_?.TimeOfDayElement;
                    IEnumerable<CqlTime> cc_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(cb_, "value");
                    int? cd_ = context.Operators.Count<CqlTime>(cc_);
                    decimal? ce_ = context.Operators.ConvertIntegerToDecimal(cd_);
                    decimal? cf_ = context.Operators.Multiply(av_, (bw_ ?? ce_) ?? 1.0m);
                    decimal? cg_ = context.Operators.Divide(ah_, cf_);
                    UnsignedInt ci_ = t_?.NumberOfRepeatsAllowedElement;
                    int? cj_ = ci_?.Value;
                    int? ck_ = context.Operators.Add(1, cj_ ?? 0);
                    decimal? cl_ = context.Operators.ConvertIntegerToDecimal(ck_);
                    decimal? cm_ = context.Operators.Multiply(ad_ ?? cg_, cl_);
                    bool? cn_ = context.Operators.Not((bool?)(cm_ is null));
                    bool? co_ = context.Operators.And(y_, cn_);

                    return co_ ?? false;
                };
                bool h_()
                {
                    List<Dosage> cp_ = R?.DosageInstruction;
                    Dosage cq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    Timing cr_ = cq_?.Timing;
                    Timing.RepeatComponent cs_ = cr_?.Repeat;
                    DataType ct_ = cs_?.Bounds;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    CqlDateTime cv_ = context.Operators.Start(cu_ as CqlInterval<CqlDateTime>);
                    CqlDate cw_ = context.Operators.DateFrom(cv_);
                    FhirDateTime cx_ = R?.AuthoredOnElement;
                    CqlDateTime cy_ = context.Operators.Convert<CqlDateTime>(cx_);
                    CqlDate cz_ = context.Operators.DateFrom(cy_);
                    MedicationRequest.DispenseRequestComponent da_ = R?.DispenseRequest;
                    Period db_ = da_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> dc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, db_);
                    CqlDateTime dd_ = context.Operators.Start(dc_);
                    CqlDate de_ = context.Operators.DateFrom(dd_);
                    bool? df_ = context.Operators.Not((bool?)(((cw_ ?? cz_) ?? de_) is null));
                    Dosage dh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    Timing di_ = dh_?.Timing;
                    Timing.RepeatComponent dj_ = di_?.Repeat;
                    DataType dk_ = dj_?.Bounds;
                    object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                    CqlDateTime dm_ = (dl_ as CqlInterval<CqlDateTime>)?.high;
                    bool? dn_ = context.Operators.Not((bool?)(dm_ is null));
                    bool? do_ = context.Operators.And(df_, dn_);

                    return do_ ?? false;
                };
                if (g_())
                {
                    List<Dosage> dp_ = R?.DosageInstruction;
                    Dosage dq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    Timing dr_ = dq_?.Timing;
                    Timing.RepeatComponent ds_ = dr_?.Repeat;
                    DataType dt_ = ds_?.Bounds;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    CqlDateTime dv_ = context.Operators.Start(du_ as CqlInterval<CqlDateTime>);
                    CqlDate dw_ = context.Operators.DateFrom(dv_);
                    FhirDateTime dx_ = R?.AuthoredOnElement;
                    CqlDateTime dy_ = context.Operators.Convert<CqlDateTime>(dx_);
                    CqlDate dz_ = context.Operators.DateFrom(dy_);
                    MedicationRequest.DispenseRequestComponent ea_ = R?.DispenseRequest;
                    Period eb_ = ea_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eb_);
                    CqlDateTime ed_ = context.Operators.Start(ec_);
                    CqlDate ee_ = context.Operators.DateFrom(ed_);
                    Dosage eg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    Timing eh_ = eg_?.Timing;
                    Timing.RepeatComponent ei_ = eh_?.Repeat;
                    DataType ej_ = ei_?.Bounds;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    CqlDateTime el_ = context.Operators.Start(ek_ as CqlInterval<CqlDateTime>);
                    CqlDate em_ = context.Operators.DateFrom(el_);
                    CqlDateTime eo_ = context.Operators.Convert<CqlDateTime>(dx_);
                    CqlDate ep_ = context.Operators.DateFrom(eo_);
                    Period er_ = ea_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> es_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, er_);
                    CqlDateTime et_ = context.Operators.Start(es_);
                    CqlDate eu_ = context.Operators.DateFrom(et_);
                    Duration ew_ = ea_?.ExpectedSupplyDuration;
                    CqlQuantity ex_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ew_);
                    CqlQuantity ey_ = context.Operators.ConvertQuantity(ex_, "d");
                    decimal? ez_ = ey_?.value;
                    Quantity fb_ = ea_?.Quantity;
                    CqlQuantity fc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, fb_);
                    decimal? fd_ = fc_?.value;
                    Dosage ff_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    List<Dosage.DoseAndRateComponent> fg_ = ff_?.DoseAndRate;
                    Dosage.DoseAndRateComponent fh_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)fg_);
                    DataType fi_ = fh_?.Dose;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    CqlQuantity fk_ = context.Operators.End(fj_ as CqlInterval<CqlQuantity>);
                    Dosage fm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    List<Dosage.DoseAndRateComponent> fn_ = fm_?.DoseAndRate;
                    Dosage.DoseAndRateComponent fo_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)fn_);
                    DataType fp_ = fo_?.Dose;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    decimal? fr_ = (fk_ ?? fq_ as CqlQuantity)?.value;
                    Dosage ft_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    Timing fu_ = ft_?.Timing;
                    Timing.RepeatComponent fv_ = fu_?.Repeat;
                    PositiveInt fw_ = fv_?.FrequencyMaxElement;
                    int? fx_ = fw_?.Value;
                    Dosage fz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    Timing ga_ = fz_?.Timing;
                    Timing.RepeatComponent gb_ = ga_?.Repeat;
                    PositiveInt gc_ = gb_?.FrequencyElement;
                    int? gd_ = gc_?.Value;
                    Dosage gf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    Timing gg_ = gf_?.Timing;
                    Timing.RepeatComponent gh_ = gg_?.Repeat;
                    FhirDecimal gi_ = gh_?.PeriodElement;
                    decimal? gj_ = gi_?.Value;
                    Dosage gl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    Timing gm_ = gl_?.Timing;
                    Timing.RepeatComponent gn_ = gm_?.Repeat;
                    Code<Timing.UnitsOfTime> go_ = gn_?.PeriodUnitElement;
                    Timing.UnitsOfTime? gp_ = go_?.Value;
                    string gq_ = context.Operators.Convert<string>(gp_);
                    CqlQuantity gr_ = this.Quantity(context, gj_, gq_);
                    decimal? gs_ = this.ToDaily(context, fx_ ?? gd_, gr_);
                    Dosage gu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    Timing gv_ = gu_?.Timing;
                    Timing.RepeatComponent gw_ = gv_?.Repeat;
                    List<Time> gx_ = gw_?.TimeOfDayElement;
                    IEnumerable<CqlTime> gy_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(gx_, "value");
                    int? gz_ = context.Operators.Count<CqlTime>(gy_);
                    decimal? ha_ = context.Operators.ConvertIntegerToDecimal(gz_);
                    decimal? hb_ = context.Operators.Multiply(fr_, (gs_ ?? ha_) ?? 1.0m);
                    decimal? hc_ = context.Operators.Divide(fd_, hb_);
                    UnsignedInt he_ = ea_?.NumberOfRepeatsAllowedElement;
                    int? hf_ = he_?.Value;
                    int? hg_ = context.Operators.Add(1, hf_ ?? 0);
                    decimal? hh_ = context.Operators.ConvertIntegerToDecimal(hg_);
                    decimal? hi_ = context.Operators.Multiply(ez_ ?? hc_, hh_);
                    decimal? hj_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? hk_ = context.Operators.Subtract(hi_, hj_);
                    CqlQuantity hl_ = this.Quantity(context, hk_, "day");
                    CqlDate hm_ = context.Operators.Add((em_ ?? ep_) ?? eu_, hl_);
                    CqlInterval<CqlDate> hn_ = context.Operators.Interval((dw_ ?? dz_) ?? ee_, hm_, true, true);

                    return hn_;
                }
                else if (h_())
                {
                    List<Dosage> ho_ = R?.DosageInstruction;
                    Dosage hp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ho_);
                    Timing hq_ = hp_?.Timing;
                    Timing.RepeatComponent hr_ = hq_?.Repeat;
                    DataType hs_ = hr_?.Bounds;
                    object ht_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hs_);
                    CqlDateTime hu_ = context.Operators.Start(ht_ as CqlInterval<CqlDateTime>);
                    CqlDate hv_ = context.Operators.DateFrom(hu_);
                    FhirDateTime hw_ = R?.AuthoredOnElement;
                    CqlDateTime hx_ = context.Operators.Convert<CqlDateTime>(hw_);
                    CqlDate hy_ = context.Operators.DateFrom(hx_);
                    MedicationRequest.DispenseRequestComponent hz_ = R?.DispenseRequest;
                    Period ia_ = hz_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ib_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ia_);
                    CqlDateTime ic_ = context.Operators.Start(ib_);
                    CqlDate id_ = context.Operators.DateFrom(ic_);
                    Dosage if_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ho_);
                    Timing ig_ = if_?.Timing;
                    Timing.RepeatComponent ih_ = ig_?.Repeat;
                    DataType ii_ = ih_?.Bounds;
                    object ij_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ii_);
                    CqlDateTime ik_ = context.Operators.End(ij_ as CqlInterval<CqlDateTime>);
                    CqlDate il_ = context.Operators.DateFrom(ik_);
                    CqlInterval<CqlDate> im_ = context.Operators.Interval((hv_ ?? hy_) ?? id_, il_, true, true);

                    return im_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return f_();
        };
        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);
        CqlInterval<CqlDate> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(d_);

        return e_;
    }


    public CqlInterval<CqlDate> medicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] a_ = [
            Request,
        ];
        CqlInterval<CqlDate> b_(MedicationRequest R)
        {
            CqlInterval<CqlDate> f_()
            {
                bool g_()
                {
                    List<Dosage> i_ = R?.DosageInstruction;
                    Dosage j_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing k_ = j_?.Timing;
                    Timing.RepeatComponent l_ = k_?.Repeat;
                    DataType m_ = l_?.Bounds;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    CqlDateTime o_ = context.Operators.Start(n_ as CqlInterval<CqlDateTime>);
                    CqlDate p_ = context.Operators.DateFrom(o_);
                    FhirDateTime q_ = R?.AuthoredOnElement;
                    CqlDateTime r_ = context.Operators.Convert<CqlDateTime>(q_);
                    CqlDate s_ = context.Operators.DateFrom(r_);
                    MedicationRequest.DispenseRequestComponent t_ = R?.DispenseRequest;
                    Period u_ = t_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                    CqlDateTime w_ = context.Operators.Start(v_);
                    CqlDate x_ = context.Operators.DateFrom(w_);
                    bool? y_ = context.Operators.Not((bool?)(((p_ ?? s_) ?? x_) is null));
                    Duration aa_ = t_?.ExpectedSupplyDuration;
                    CqlQuantity ab_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aa_);
                    CqlQuantity ac_ = context.Operators.ConvertQuantity(ab_, "d");
                    decimal? ad_ = ac_?.value;
                    Quantity af_ = t_?.Quantity;
                    CqlQuantity ag_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, af_);
                    decimal? ah_ = ag_?.value;
                    Dosage aj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    List<Dosage.DoseAndRateComponent> ak_ = aj_?.DoseAndRate;
                    Dosage.DoseAndRateComponent al_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ak_);
                    DataType am_ = al_?.Dose;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    CqlQuantity ao_ = context.Operators.End(an_ as CqlInterval<CqlQuantity>);
                    Dosage aq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    List<Dosage.DoseAndRateComponent> ar_ = aq_?.DoseAndRate;
                    Dosage.DoseAndRateComponent as_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ar_);
                    DataType at_ = as_?.Dose;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    decimal? av_ = (ao_ ?? au_ as CqlQuantity)?.value;
                    Dosage ax_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing ay_ = ax_?.Timing;
                    Timing.RepeatComponent az_ = ay_?.Repeat;
                    PositiveInt ba_ = az_?.FrequencyMaxElement;
                    int? bb_ = ba_?.Value;
                    Dosage bd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing be_ = bd_?.Timing;
                    Timing.RepeatComponent bf_ = be_?.Repeat;
                    PositiveInt bg_ = bf_?.FrequencyElement;
                    int? bh_ = bg_?.Value;
                    Dosage bj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing bk_ = bj_?.Timing;
                    Timing.RepeatComponent bl_ = bk_?.Repeat;
                    FhirDecimal bm_ = bl_?.PeriodElement;
                    decimal? bn_ = bm_?.Value;
                    Dosage bp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing bq_ = bp_?.Timing;
                    Timing.RepeatComponent br_ = bq_?.Repeat;
                    Code<Timing.UnitsOfTime> bs_ = br_?.PeriodUnitElement;
                    Timing.UnitsOfTime? bt_ = bs_?.Value;
                    string bu_ = context.Operators.Convert<string>(bt_);
                    CqlQuantity bv_ = this.Quantity(context, bn_, bu_);
                    decimal? bw_ = this.ToDaily(context, bb_ ?? bh_, bv_);
                    Dosage by_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)i_);
                    Timing bz_ = by_?.Timing;
                    Timing.RepeatComponent ca_ = bz_?.Repeat;
                    List<Time> cb_ = ca_?.TimeOfDayElement;
                    IEnumerable<CqlTime> cc_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(cb_, "value");
                    int? cd_ = context.Operators.Count<CqlTime>(cc_);
                    decimal? ce_ = context.Operators.ConvertIntegerToDecimal(cd_);
                    decimal? cf_ = context.Operators.Multiply(av_, (bw_ ?? ce_) ?? 1.0m);
                    decimal? cg_ = context.Operators.Divide(ah_, cf_);
                    UnsignedInt ci_ = t_?.NumberOfRepeatsAllowedElement;
                    int? cj_ = ci_?.Value;
                    int? ck_ = context.Operators.Add(1, cj_ ?? 0);
                    decimal? cl_ = context.Operators.ConvertIntegerToDecimal(ck_);
                    decimal? cm_ = context.Operators.Multiply(ad_ ?? cg_, cl_);
                    bool? cn_ = context.Operators.Not((bool?)(cm_ is null));
                    bool? co_ = context.Operators.And(y_, cn_);

                    return co_ ?? false;
                };
                bool h_()
                {
                    List<Dosage> cp_ = R?.DosageInstruction;
                    Dosage cq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    Timing cr_ = cq_?.Timing;
                    Timing.RepeatComponent cs_ = cr_?.Repeat;
                    DataType ct_ = cs_?.Bounds;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    CqlDateTime cv_ = context.Operators.Start(cu_ as CqlInterval<CqlDateTime>);
                    CqlDate cw_ = context.Operators.DateFrom(cv_);
                    FhirDateTime cx_ = R?.AuthoredOnElement;
                    CqlDateTime cy_ = context.Operators.Convert<CqlDateTime>(cx_);
                    CqlDate cz_ = context.Operators.DateFrom(cy_);
                    MedicationRequest.DispenseRequestComponent da_ = R?.DispenseRequest;
                    Period db_ = da_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> dc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, db_);
                    CqlDateTime dd_ = context.Operators.Start(dc_);
                    CqlDate de_ = context.Operators.DateFrom(dd_);
                    bool? df_ = context.Operators.Not((bool?)(((cw_ ?? cz_) ?? de_) is null));
                    Dosage dh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    Timing di_ = dh_?.Timing;
                    Timing.RepeatComponent dj_ = di_?.Repeat;
                    DataType dk_ = dj_?.Bounds;
                    object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                    CqlDateTime dm_ = (dl_ as CqlInterval<CqlDateTime>)?.high;
                    bool? dn_ = context.Operators.Not((bool?)(dm_ is null));
                    bool? do_ = context.Operators.And(df_, dn_);

                    return do_ ?? false;
                };
                if (g_())
                {
                    List<Dosage> dp_ = R?.DosageInstruction;
                    Dosage dq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    Timing dr_ = dq_?.Timing;
                    Timing.RepeatComponent ds_ = dr_?.Repeat;
                    DataType dt_ = ds_?.Bounds;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    CqlDateTime dv_ = context.Operators.Start(du_ as CqlInterval<CqlDateTime>);
                    CqlDate dw_ = context.Operators.DateFrom(dv_);
                    FhirDateTime dx_ = R?.AuthoredOnElement;
                    CqlDateTime dy_ = context.Operators.Convert<CqlDateTime>(dx_);
                    CqlDate dz_ = context.Operators.DateFrom(dy_);
                    MedicationRequest.DispenseRequestComponent ea_ = R?.DispenseRequest;
                    Period eb_ = ea_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eb_);
                    CqlDateTime ed_ = context.Operators.Start(ec_);
                    CqlDate ee_ = context.Operators.DateFrom(ed_);
                    Dosage eg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    Timing eh_ = eg_?.Timing;
                    Timing.RepeatComponent ei_ = eh_?.Repeat;
                    DataType ej_ = ei_?.Bounds;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    CqlDateTime el_ = context.Operators.Start(ek_ as CqlInterval<CqlDateTime>);
                    CqlDate em_ = context.Operators.DateFrom(el_);
                    CqlDateTime eo_ = context.Operators.Convert<CqlDateTime>(dx_);
                    CqlDate ep_ = context.Operators.DateFrom(eo_);
                    Period er_ = ea_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> es_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, er_);
                    CqlDateTime et_ = context.Operators.Start(es_);
                    CqlDate eu_ = context.Operators.DateFrom(et_);
                    Duration ew_ = ea_?.ExpectedSupplyDuration;
                    CqlQuantity ex_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ew_);
                    CqlQuantity ey_ = context.Operators.ConvertQuantity(ex_, "d");
                    decimal? ez_ = ey_?.value;
                    Quantity fb_ = ea_?.Quantity;
                    CqlQuantity fc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, fb_);
                    decimal? fd_ = fc_?.value;
                    Dosage ff_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    List<Dosage.DoseAndRateComponent> fg_ = ff_?.DoseAndRate;
                    Dosage.DoseAndRateComponent fh_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)fg_);
                    DataType fi_ = fh_?.Dose;
                    object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                    CqlQuantity fk_ = context.Operators.End(fj_ as CqlInterval<CqlQuantity>);
                    Dosage fm_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    List<Dosage.DoseAndRateComponent> fn_ = fm_?.DoseAndRate;
                    Dosage.DoseAndRateComponent fo_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)fn_);
                    DataType fp_ = fo_?.Dose;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                    decimal? fr_ = (fk_ ?? fq_ as CqlQuantity)?.value;
                    Dosage ft_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    Timing fu_ = ft_?.Timing;
                    Timing.RepeatComponent fv_ = fu_?.Repeat;
                    PositiveInt fw_ = fv_?.FrequencyMaxElement;
                    int? fx_ = fw_?.Value;
                    Dosage fz_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    Timing ga_ = fz_?.Timing;
                    Timing.RepeatComponent gb_ = ga_?.Repeat;
                    PositiveInt gc_ = gb_?.FrequencyElement;
                    int? gd_ = gc_?.Value;
                    Dosage gf_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    Timing gg_ = gf_?.Timing;
                    Timing.RepeatComponent gh_ = gg_?.Repeat;
                    FhirDecimal gi_ = gh_?.PeriodElement;
                    decimal? gj_ = gi_?.Value;
                    Dosage gl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    Timing gm_ = gl_?.Timing;
                    Timing.RepeatComponent gn_ = gm_?.Repeat;
                    Code<Timing.UnitsOfTime> go_ = gn_?.PeriodUnitElement;
                    Timing.UnitsOfTime? gp_ = go_?.Value;
                    string gq_ = context.Operators.Convert<string>(gp_);
                    CqlQuantity gr_ = this.Quantity(context, gj_, gq_);
                    decimal? gs_ = this.ToDaily(context, fx_ ?? gd_, gr_);
                    Dosage gu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)dp_);
                    Timing gv_ = gu_?.Timing;
                    Timing.RepeatComponent gw_ = gv_?.Repeat;
                    List<Time> gx_ = gw_?.TimeOfDayElement;
                    IEnumerable<CqlTime> gy_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(gx_, "value");
                    int? gz_ = context.Operators.Count<CqlTime>(gy_);
                    decimal? ha_ = context.Operators.ConvertIntegerToDecimal(gz_);
                    decimal? hb_ = context.Operators.Multiply(fr_, (gs_ ?? ha_) ?? 1.0m);
                    decimal? hc_ = context.Operators.Divide(fd_, hb_);
                    UnsignedInt he_ = ea_?.NumberOfRepeatsAllowedElement;
                    int? hf_ = he_?.Value;
                    int? hg_ = context.Operators.Add(1, hf_ ?? 0);
                    decimal? hh_ = context.Operators.ConvertIntegerToDecimal(hg_);
                    decimal? hi_ = context.Operators.Multiply(ez_ ?? hc_, hh_);
                    decimal? hj_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? hk_ = context.Operators.Subtract(hi_, hj_);
                    CqlQuantity hl_ = this.Quantity(context, hk_, "day");
                    CqlDate hm_ = context.Operators.Add((em_ ?? ep_) ?? eu_, hl_);
                    CqlInterval<CqlDate> hn_ = context.Operators.Interval((dw_ ?? dz_) ?? ee_, hm_, true, true);

                    return hn_;
                }
                else if (h_())
                {
                    List<Dosage> ho_ = R?.DosageInstruction;
                    Dosage hp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ho_);
                    Timing hq_ = hp_?.Timing;
                    Timing.RepeatComponent hr_ = hq_?.Repeat;
                    DataType hs_ = hr_?.Bounds;
                    object ht_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hs_);
                    CqlDateTime hu_ = context.Operators.Start(ht_ as CqlInterval<CqlDateTime>);
                    CqlDate hv_ = context.Operators.DateFrom(hu_);
                    FhirDateTime hw_ = R?.AuthoredOnElement;
                    CqlDateTime hx_ = context.Operators.Convert<CqlDateTime>(hw_);
                    CqlDate hy_ = context.Operators.DateFrom(hx_);
                    MedicationRequest.DispenseRequestComponent hz_ = R?.DispenseRequest;
                    Period ia_ = hz_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ib_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ia_);
                    CqlDateTime ic_ = context.Operators.Start(ib_);
                    CqlDate id_ = context.Operators.DateFrom(ic_);
                    Dosage if_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ho_);
                    Timing ig_ = if_?.Timing;
                    Timing.RepeatComponent ih_ = ig_?.Repeat;
                    DataType ii_ = ih_?.Bounds;
                    object ij_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ii_);
                    CqlDateTime ik_ = context.Operators.End(ij_ as CqlInterval<CqlDateTime>);
                    CqlDate il_ = context.Operators.DateFrom(ik_);
                    CqlInterval<CqlDate> im_ = context.Operators.Interval((hv_ ?? hy_) ?? id_, il_, true, true);

                    return im_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return f_();
        };
        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);
        CqlInterval<CqlDate> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(d_);

        return e_;
    }


    public CqlInterval<CqlDate> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] a_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> b_(MedicationDispense D)
        {
            CqlInterval<CqlDate> f_()
            {
                bool g_()
                {
                    FhirDateTime h_ = D?.WhenHandedOverElement;
                    CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
                    CqlDate j_ = context.Operators.DateFrom(i_);
                    FhirDateTime k_ = D?.WhenPreparedElement;
                    CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                    CqlDate m_ = context.Operators.DateFrom(l_);
                    bool? n_ = context.Operators.Not((bool?)((j_ ?? m_) is null));
                    Quantity o_ = D?.DaysSupply;
                    CqlQuantity p_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, o_);
                    CqlQuantity q_ = context.Operators.ConvertQuantity(p_, "d");
                    decimal? r_ = q_?.value;
                    Quantity s_ = D?.Quantity;
                    CqlQuantity t_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, s_);
                    decimal? u_ = t_?.value;
                    List<Dosage> v_ = D?.DosageInstruction;
                    Dosage w_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    List<Dosage.DoseAndRateComponent> x_ = w_?.DoseAndRate;
                    Dosage.DoseAndRateComponent y_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)x_);
                    DataType z_ = y_?.Dose;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    CqlQuantity ab_ = context.Operators.End(aa_ as CqlInterval<CqlQuantity>);
                    Dosage ad_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    List<Dosage.DoseAndRateComponent> ae_ = ad_?.DoseAndRate;
                    Dosage.DoseAndRateComponent af_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ae_);
                    DataType ag_ = af_?.Dose;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    decimal? ai_ = (ab_ ?? ah_ as CqlQuantity)?.value;
                    Dosage ak_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing al_ = ak_?.Timing;
                    Timing.RepeatComponent am_ = al_?.Repeat;
                    PositiveInt an_ = am_?.FrequencyMaxElement;
                    int? ao_ = an_?.Value;
                    Dosage aq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing ar_ = aq_?.Timing;
                    Timing.RepeatComponent as_ = ar_?.Repeat;
                    PositiveInt at_ = as_?.FrequencyElement;
                    int? au_ = at_?.Value;
                    Dosage aw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing ax_ = aw_?.Timing;
                    Timing.RepeatComponent ay_ = ax_?.Repeat;
                    FhirDecimal az_ = ay_?.PeriodElement;
                    decimal? ba_ = az_?.Value;
                    Dosage bc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing bd_ = bc_?.Timing;
                    Timing.RepeatComponent be_ = bd_?.Repeat;
                    Code<Timing.UnitsOfTime> bf_ = be_?.PeriodUnitElement;
                    Timing.UnitsOfTime? bg_ = bf_?.Value;
                    string bh_ = context.Operators.Convert<string>(bg_);
                    CqlQuantity bi_ = this.Quantity(context, ba_, bh_);
                    decimal? bj_ = this.ToDaily(context, ao_ ?? au_, bi_);
                    Dosage bl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing bm_ = bl_?.Timing;
                    Timing.RepeatComponent bn_ = bm_?.Repeat;
                    List<Time> bo_ = bn_?.TimeOfDayElement;
                    IEnumerable<CqlTime> bp_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(bo_, "value");
                    int? bq_ = context.Operators.Count<CqlTime>(bp_);
                    decimal? br_ = context.Operators.ConvertIntegerToDecimal(bq_);
                    decimal? bs_ = context.Operators.Multiply(ai_, (bj_ ?? br_) ?? 1.0m);
                    decimal? bt_ = context.Operators.Divide(u_, bs_);
                    bool? bu_ = context.Operators.Not((bool?)((r_ ?? bt_) is null));
                    bool? bv_ = context.Operators.And(n_, bu_);

                    return bv_ ?? false;
                };
                if (g_())
                {
                    FhirDateTime bw_ = D?.WhenHandedOverElement;
                    CqlDateTime bx_ = context.Operators.Convert<CqlDateTime>(bw_);
                    CqlDate by_ = context.Operators.DateFrom(bx_);
                    FhirDateTime bz_ = D?.WhenPreparedElement;
                    CqlDateTime ca_ = context.Operators.Convert<CqlDateTime>(bz_);
                    CqlDate cb_ = context.Operators.DateFrom(ca_);
                    CqlDateTime cd_ = context.Operators.Convert<CqlDateTime>(bw_);
                    CqlDate ce_ = context.Operators.DateFrom(cd_);
                    CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(bz_);
                    CqlDate ch_ = context.Operators.DateFrom(cg_);
                    Quantity ci_ = D?.DaysSupply;
                    CqlQuantity cj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ci_);
                    CqlQuantity ck_ = context.Operators.ConvertQuantity(cj_, "d");
                    decimal? cl_ = ck_?.value;
                    Quantity cm_ = D?.Quantity;
                    CqlQuantity cn_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, cm_);
                    decimal? co_ = cn_?.value;
                    List<Dosage> cp_ = D?.DosageInstruction;
                    Dosage cq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    List<Dosage.DoseAndRateComponent> cr_ = cq_?.DoseAndRate;
                    Dosage.DoseAndRateComponent cs_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)cr_);
                    DataType ct_ = cs_?.Dose;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    CqlQuantity cv_ = context.Operators.End(cu_ as CqlInterval<CqlQuantity>);
                    Dosage cx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    List<Dosage.DoseAndRateComponent> cy_ = cx_?.DoseAndRate;
                    Dosage.DoseAndRateComponent cz_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)cy_);
                    DataType da_ = cz_?.Dose;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    decimal? dc_ = (cv_ ?? db_ as CqlQuantity)?.value;
                    Dosage de_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    Timing df_ = de_?.Timing;
                    Timing.RepeatComponent dg_ = df_?.Repeat;
                    PositiveInt dh_ = dg_?.FrequencyMaxElement;
                    int? di_ = dh_?.Value;
                    Dosage dk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    Timing dl_ = dk_?.Timing;
                    Timing.RepeatComponent dm_ = dl_?.Repeat;
                    PositiveInt dn_ = dm_?.FrequencyElement;
                    int? do_ = dn_?.Value;
                    Dosage dq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    Timing dr_ = dq_?.Timing;
                    Timing.RepeatComponent ds_ = dr_?.Repeat;
                    FhirDecimal dt_ = ds_?.PeriodElement;
                    decimal? du_ = dt_?.Value;
                    Dosage dw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    Timing dx_ = dw_?.Timing;
                    Timing.RepeatComponent dy_ = dx_?.Repeat;
                    Code<Timing.UnitsOfTime> dz_ = dy_?.PeriodUnitElement;
                    Timing.UnitsOfTime? ea_ = dz_?.Value;
                    string eb_ = context.Operators.Convert<string>(ea_);
                    CqlQuantity ec_ = this.Quantity(context, du_, eb_);
                    decimal? ed_ = this.ToDaily(context, di_ ?? do_, ec_);
                    Dosage ef_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    Timing eg_ = ef_?.Timing;
                    Timing.RepeatComponent eh_ = eg_?.Repeat;
                    List<Time> ei_ = eh_?.TimeOfDayElement;
                    IEnumerable<CqlTime> ej_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(ei_, "value");
                    int? ek_ = context.Operators.Count<CqlTime>(ej_);
                    decimal? el_ = context.Operators.ConvertIntegerToDecimal(ek_);
                    decimal? em_ = context.Operators.Multiply(dc_, (ed_ ?? el_) ?? 1.0m);
                    decimal? en_ = context.Operators.Divide(co_, em_);
                    decimal? eo_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? ep_ = context.Operators.Subtract(cl_ ?? en_, eo_);
                    CqlQuantity eq_ = this.Quantity(context, ep_, "day");
                    CqlDate er_ = context.Operators.Add(ce_ ?? ch_, eq_);
                    CqlInterval<CqlDate> es_ = context.Operators.Interval(by_ ?? cb_, er_, true, true);

                    return es_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return f_();
        };
        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);
        CqlInterval<CqlDate> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(d_);

        return e_;
    }


    public CqlInterval<CqlDate> medicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] a_ = [
            Dispense,
        ];
        CqlInterval<CqlDate> b_(MedicationDispense D)
        {
            CqlInterval<CqlDate> f_()
            {
                bool g_()
                {
                    FhirDateTime h_ = D?.WhenHandedOverElement;
                    CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
                    CqlDate j_ = context.Operators.DateFrom(i_);
                    FhirDateTime k_ = D?.WhenPreparedElement;
                    CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                    CqlDate m_ = context.Operators.DateFrom(l_);
                    bool? n_ = context.Operators.Not((bool?)((j_ ?? m_) is null));
                    Quantity o_ = D?.DaysSupply;
                    CqlQuantity p_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, o_);
                    CqlQuantity q_ = context.Operators.ConvertQuantity(p_, "d");
                    decimal? r_ = q_?.value;
                    Quantity s_ = D?.Quantity;
                    CqlQuantity t_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, s_);
                    decimal? u_ = t_?.value;
                    List<Dosage> v_ = D?.DosageInstruction;
                    Dosage w_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    List<Dosage.DoseAndRateComponent> x_ = w_?.DoseAndRate;
                    Dosage.DoseAndRateComponent y_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)x_);
                    DataType z_ = y_?.Dose;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    CqlQuantity ab_ = context.Operators.End(aa_ as CqlInterval<CqlQuantity>);
                    Dosage ad_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    List<Dosage.DoseAndRateComponent> ae_ = ad_?.DoseAndRate;
                    Dosage.DoseAndRateComponent af_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ae_);
                    DataType ag_ = af_?.Dose;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    decimal? ai_ = (ab_ ?? ah_ as CqlQuantity)?.value;
                    Dosage ak_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing al_ = ak_?.Timing;
                    Timing.RepeatComponent am_ = al_?.Repeat;
                    PositiveInt an_ = am_?.FrequencyMaxElement;
                    int? ao_ = an_?.Value;
                    Dosage aq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing ar_ = aq_?.Timing;
                    Timing.RepeatComponent as_ = ar_?.Repeat;
                    PositiveInt at_ = as_?.FrequencyElement;
                    int? au_ = at_?.Value;
                    Dosage aw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing ax_ = aw_?.Timing;
                    Timing.RepeatComponent ay_ = ax_?.Repeat;
                    FhirDecimal az_ = ay_?.PeriodElement;
                    decimal? ba_ = az_?.Value;
                    Dosage bc_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing bd_ = bc_?.Timing;
                    Timing.RepeatComponent be_ = bd_?.Repeat;
                    Code<Timing.UnitsOfTime> bf_ = be_?.PeriodUnitElement;
                    Timing.UnitsOfTime? bg_ = bf_?.Value;
                    string bh_ = context.Operators.Convert<string>(bg_);
                    CqlQuantity bi_ = this.Quantity(context, ba_, bh_);
                    decimal? bj_ = this.ToDaily(context, ao_ ?? au_, bi_);
                    Dosage bl_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)v_);
                    Timing bm_ = bl_?.Timing;
                    Timing.RepeatComponent bn_ = bm_?.Repeat;
                    List<Time> bo_ = bn_?.TimeOfDayElement;
                    IEnumerable<CqlTime> bp_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(bo_, "value");
                    int? bq_ = context.Operators.Count<CqlTime>(bp_);
                    decimal? br_ = context.Operators.ConvertIntegerToDecimal(bq_);
                    decimal? bs_ = context.Operators.Multiply(ai_, (bj_ ?? br_) ?? 1.0m);
                    decimal? bt_ = context.Operators.Divide(u_, bs_);
                    bool? bu_ = context.Operators.Not((bool?)((r_ ?? bt_) is null));
                    bool? bv_ = context.Operators.And(n_, bu_);

                    return bv_ ?? false;
                };
                if (g_())
                {
                    FhirDateTime bw_ = D?.WhenHandedOverElement;
                    CqlDateTime bx_ = context.Operators.Convert<CqlDateTime>(bw_);
                    CqlDate by_ = context.Operators.DateFrom(bx_);
                    FhirDateTime bz_ = D?.WhenPreparedElement;
                    CqlDateTime ca_ = context.Operators.Convert<CqlDateTime>(bz_);
                    CqlDate cb_ = context.Operators.DateFrom(ca_);
                    CqlDateTime cd_ = context.Operators.Convert<CqlDateTime>(bw_);
                    CqlDate ce_ = context.Operators.DateFrom(cd_);
                    CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(bz_);
                    CqlDate ch_ = context.Operators.DateFrom(cg_);
                    Quantity ci_ = D?.DaysSupply;
                    CqlQuantity cj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ci_);
                    CqlQuantity ck_ = context.Operators.ConvertQuantity(cj_, "d");
                    decimal? cl_ = ck_?.value;
                    Quantity cm_ = D?.Quantity;
                    CqlQuantity cn_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, cm_);
                    decimal? co_ = cn_?.value;
                    List<Dosage> cp_ = D?.DosageInstruction;
                    Dosage cq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    List<Dosage.DoseAndRateComponent> cr_ = cq_?.DoseAndRate;
                    Dosage.DoseAndRateComponent cs_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)cr_);
                    DataType ct_ = cs_?.Dose;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    CqlQuantity cv_ = context.Operators.End(cu_ as CqlInterval<CqlQuantity>);
                    Dosage cx_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    List<Dosage.DoseAndRateComponent> cy_ = cx_?.DoseAndRate;
                    Dosage.DoseAndRateComponent cz_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)cy_);
                    DataType da_ = cz_?.Dose;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    decimal? dc_ = (cv_ ?? db_ as CqlQuantity)?.value;
                    Dosage de_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    Timing df_ = de_?.Timing;
                    Timing.RepeatComponent dg_ = df_?.Repeat;
                    PositiveInt dh_ = dg_?.FrequencyMaxElement;
                    int? di_ = dh_?.Value;
                    Dosage dk_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    Timing dl_ = dk_?.Timing;
                    Timing.RepeatComponent dm_ = dl_?.Repeat;
                    PositiveInt dn_ = dm_?.FrequencyElement;
                    int? do_ = dn_?.Value;
                    Dosage dq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    Timing dr_ = dq_?.Timing;
                    Timing.RepeatComponent ds_ = dr_?.Repeat;
                    FhirDecimal dt_ = ds_?.PeriodElement;
                    decimal? du_ = dt_?.Value;
                    Dosage dw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    Timing dx_ = dw_?.Timing;
                    Timing.RepeatComponent dy_ = dx_?.Repeat;
                    Code<Timing.UnitsOfTime> dz_ = dy_?.PeriodUnitElement;
                    Timing.UnitsOfTime? ea_ = dz_?.Value;
                    string eb_ = context.Operators.Convert<string>(ea_);
                    CqlQuantity ec_ = this.Quantity(context, du_, eb_);
                    decimal? ed_ = this.ToDaily(context, di_ ?? do_, ec_);
                    Dosage ef_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)cp_);
                    Timing eg_ = ef_?.Timing;
                    Timing.RepeatComponent eh_ = eg_?.Repeat;
                    List<Time> ei_ = eh_?.TimeOfDayElement;
                    IEnumerable<CqlTime> ej_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(ei_, "value");
                    int? ek_ = context.Operators.Count<CqlTime>(ej_);
                    decimal? el_ = context.Operators.ConvertIntegerToDecimal(ek_);
                    decimal? em_ = context.Operators.Multiply(dc_, (ed_ ?? el_) ?? 1.0m);
                    decimal? en_ = context.Operators.Divide(co_, em_);
                    decimal? eo_ = context.Operators.ConvertIntegerToDecimal(1);
                    decimal? ep_ = context.Operators.Subtract(cl_ ?? en_, eo_);
                    CqlQuantity eq_ = this.Quantity(context, ep_, "day");
                    CqlDate er_ = context.Operators.Add(ce_ ?? ch_, eq_);
                    CqlInterval<CqlDate> es_ = context.Operators.Interval(by_ ?? cb_, er_, true, true);

                    return es_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return f_();
        };
        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);
        CqlInterval<CqlDate> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(d_);

        return e_;
    }


    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity a_ = context.Operators.Quantity(14m, "days");

        return a_;
    }


    public CqlInterval<CqlDate> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] a_ = [
            Administration,
        ];
        CqlInterval<CqlDate> b_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> f_()
            {
                bool g_()
                {
                    DataType h_ = Administration?.Effective;
                    object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                    CqlDateTime j_ = context.Operators.Start(i_ as CqlInterval<CqlDateTime>);
                    CqlDate k_ = context.Operators.DateFrom(j_);
                    bool? l_ = context.Operators.Not((bool?)(k_ is null));
                    DataType m_ = Administration?.Medication;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    CqlQuantity o_ = this.TherapeuticDuration(context, n_ as CqlConcept);
                    bool? p_ = context.Operators.Not((bool?)(o_ is null));
                    bool? q_ = context.Operators.And(l_, p_);

                    return q_ ?? false;
                };
                if (g_())
                {
                    DataType r_ = Administration?.Effective;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = context.Operators.Start(s_ as CqlInterval<CqlDateTime>);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime x_ = context.Operators.Start(w_ as CqlInterval<CqlDateTime>);
                    CqlDate y_ = context.Operators.DateFrom(x_);
                    DataType z_ = Administration?.Medication;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    CqlQuantity ab_ = this.TherapeuticDuration(context, aa_ as CqlConcept);
                    CqlDate ac_ = context.Operators.Add(y_, ab_);
                    CqlQuantity ad_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate ae_ = context.Operators.Subtract(ac_, ad_);
                    CqlInterval<CqlDate> af_ = context.Operators.Interval(u_, ae_, true, true);

                    return af_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return f_();
        };
        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);
        CqlInterval<CqlDate> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(d_);

        return e_;
    }


    public CqlInterval<CqlDate> medicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] a_ = [
            Administration,
        ];
        CqlInterval<CqlDate> b_(MedicationAdministration M)
        {
            CqlInterval<CqlDate> f_()
            {
                bool g_()
                {
                    DataType h_ = Administration?.Effective;
                    object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                    CqlDateTime j_ = context.Operators.Start(i_ as CqlInterval<CqlDateTime>);
                    CqlDate k_ = context.Operators.DateFrom(j_);
                    bool? l_ = context.Operators.Not((bool?)(k_ is null));
                    DataType m_ = Administration?.Medication;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    CqlQuantity o_ = this.TherapeuticDuration(context, n_ as CqlConcept);
                    bool? p_ = context.Operators.Not((bool?)(o_ is null));
                    bool? q_ = context.Operators.And(l_, p_);

                    return q_ ?? false;
                };
                if (g_())
                {
                    DataType r_ = Administration?.Effective;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime t_ = context.Operators.Start(s_ as CqlInterval<CqlDateTime>);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlDateTime x_ = context.Operators.Start(w_ as CqlInterval<CqlDateTime>);
                    CqlDate y_ = context.Operators.DateFrom(x_);
                    DataType z_ = Administration?.Medication;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    CqlQuantity ab_ = this.TherapeuticDuration(context, aa_ as CqlConcept);
                    CqlDate ac_ = context.Operators.Add(y_, ab_);
                    CqlQuantity ad_ = context.Operators.ConvertIntegerToQuantity(1);
                    CqlDate ae_ = context.Operators.Subtract(ac_, ad_);
                    CqlInterval<CqlDate> af_ = context.Operators.Interval(u_, ae_, true, true);

                    return af_;
                }
                else
                {
                    return null as CqlInterval<CqlDate>;
                }
            };

            return f_();
        };
        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);
        CqlInterval<CqlDate> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(d_);

        return e_;
    }


    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? a_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> b_ = context.Operators.Collapse(Intervals, "day");
                int? c_(CqlInterval<CqlDate> X)
                {
                    CqlDate f_ = context.Operators.Start(X);
                    CqlDate g_ = context.Operators.End(X);
                    int? h_ = context.Operators.DifferenceBetween(f_, g_, "day");
                    int? i_ = context.Operators.Add(h_, 1);

                    return i_;
                };
                IEnumerable<int?> d_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(b_, c_);
                int? e_ = context.Operators.Sum(d_);

                return e_;
            }
            else
            {
                return default;
            }
        };

        return a_();
    }


    public int? cumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        int? a_()
        {
            if ((context.Operators.Not((bool?)(Intervals is null))) ?? false)
            {
                IEnumerable<CqlInterval<CqlDate>> b_ = context.Operators.Collapse(Intervals, "day");
                int? c_(CqlInterval<CqlDate> X)
                {
                    CqlDate f_ = context.Operators.Start(X);
                    CqlDate g_ = context.Operators.End(X);
                    int? h_ = context.Operators.DifferenceBetween(f_, g_, "day");
                    int? i_ = context.Operators.Add(h_, 1);

                    return i_;
                };
                IEnumerable<int?> d_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(b_, c_);
                int? e_ = context.Operators.Sum(d_);

                return e_;
            }
            else
            {
                return default;
            }
        };

        return a_();
    }


    public IEnumerable<CqlInterval<CqlDate>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> a_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] c_ = [
                I,
            ];
            CqlInterval<CqlDate> d_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> j_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate k_ = context.Operators.End(j_);
                CqlQuantity l_ = context.Operators.Quantity(1m, "day");
                CqlDate m_ = context.Operators.Add(k_, l_);
                CqlDate n_ = context.Operators.Start(X);
                CqlDate[] o_ = [
                    m_,
                    n_,
                ];
                CqlDate p_ = context.Operators.Max<CqlDate>(o_ as IEnumerable<CqlDate>);
                CqlDate r_ = context.Operators.End(j_);
                CqlDate t_ = context.Operators.Add(r_, l_);
                CqlDate[] v_ = [
                    t_,
                    n_,
                ];
                CqlDate w_ = context.Operators.Max<CqlDate>(v_ as IEnumerable<CqlDate>);
                CqlDate y_ = context.Operators.End(X);
                int? z_ = context.Operators.DurationBetween(n_, y_, "day");
                decimal? aa_ = context.Operators.ConvertIntegerToDecimal(z_ ?? 0);
                CqlQuantity ab_ = this.Quantity(context, aa_, "day");
                CqlDate ac_ = context.Operators.Add(w_, ab_);
                CqlInterval<CqlDate> ad_ = context.Operators.Interval(p_, ac_, true, true);

                return ad_;
            };
            IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)c_, d_);
            IEnumerable<CqlInterval<CqlDate>> f_ = context.Operators.Distinct<CqlInterval<CqlDate>>(e_);
            CqlInterval<CqlDate> g_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(f_);
            CqlInterval<CqlDate>[] h_ = [
                g_,
            ];
            IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.Union<CqlInterval<CqlDate>>(R, h_ as IEnumerable<CqlInterval<CqlDate>>);

            return i_;
        };
        IEnumerable<CqlInterval<CqlDate>> b_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, a_, null as IEnumerable<CqlInterval<CqlDate>>);

        return b_;
    }


    public IEnumerable<CqlInterval<CqlDate>> rolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> a_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
        {
            CqlInterval<CqlDate>[] c_ = [
                I,
            ];
            CqlInterval<CqlDate> d_(CqlInterval<CqlDate> X)
            {
                CqlInterval<CqlDate> j_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
                CqlDate k_ = context.Operators.End(j_);
                CqlQuantity l_ = context.Operators.Quantity(1m, "day");
                CqlDate m_ = context.Operators.Add(k_, l_);
                CqlDate n_ = context.Operators.Start(X);
                CqlDate[] o_ = [
                    m_,
                    n_,
                ];
                CqlDate p_ = context.Operators.Max<CqlDate>(o_ as IEnumerable<CqlDate>);
                CqlDate r_ = context.Operators.End(j_);
                CqlDate t_ = context.Operators.Add(r_, l_);
                CqlDate[] v_ = [
                    t_,
                    n_,
                ];
                CqlDate w_ = context.Operators.Max<CqlDate>(v_ as IEnumerable<CqlDate>);
                CqlDate y_ = context.Operators.End(X);
                int? z_ = context.Operators.DurationBetween(n_, y_, "day");
                decimal? aa_ = context.Operators.ConvertIntegerToDecimal(z_ ?? 0);
                CqlQuantity ab_ = this.Quantity(context, aa_, "day");
                CqlDate ac_ = context.Operators.Add(w_, ab_);
                CqlInterval<CqlDate> ad_ = context.Operators.Interval(p_, ac_, true, true);

                return ad_;
            };
            IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)c_, d_);
            IEnumerable<CqlInterval<CqlDate>> f_ = context.Operators.Distinct<CqlInterval<CqlDate>>(e_);
            CqlInterval<CqlDate> g_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(f_);
            CqlInterval<CqlDate>[] h_ = [
                g_,
            ];
            IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.Union<CqlInterval<CqlDate>>(R, h_ as IEnumerable<CqlInterval<CqlDate>>);

            return i_;
        };
        IEnumerable<CqlInterval<CqlDate>> b_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, a_, null as IEnumerable<CqlInterval<CqlDate>>);

        return b_;
    }


    public CqlInterval<CqlDate> MedicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> a_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> b_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);

                return b_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> c_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);

                return c_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return a_();
    }


    public CqlInterval<CqlDate> medicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDate> a_()
        {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDate> b_ = this.medicationRequestPeriod(context, medication as MedicationRequest);

                return b_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDate> c_ = this.medicationDispensePeriod(context, medication as MedicationDispense);

                return c_;
            }
            else
            {
                return null as CqlInterval<CqlDate>;
            }
        };

        return a_();
    }


    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? a_(object M)
        {
            bool n_ = M is MedicationRequest;

            return n_ as bool?;
        };
        IEnumerable<object> b_ = context.Operators.Where<object>(Medications, a_);
        CqlInterval<CqlDate> c_(object M)
        {
            CqlInterval<CqlDate> o_ = this.MedicationRequestPeriod(context, M as MedicationRequest);

            return o_;
        };
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Select<object, CqlInterval<CqlDate>>(b_, c_);
        IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.Distinct<CqlInterval<CqlDate>>(d_);
        bool? f_(object M)
        {
            bool p_ = M is MedicationDispense;

            return p_ as bool?;
        };
        IEnumerable<object> g_ = context.Operators.Where<object>(Medications, f_);
        CqlInterval<CqlDate> h_(object M)
        {
            CqlInterval<CqlDate> q_ = this.MedicationDispensePeriod(context, M as MedicationDispense);

            return q_;
        };
        IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.Select<object, CqlInterval<CqlDate>>(g_, h_);
        IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.Distinct<CqlInterval<CqlDate>>(i_);
        IEnumerable<CqlInterval<CqlDate>> k_ = this.RolloutIntervals(context, j_);
        IEnumerable<CqlInterval<CqlDate>> l_ = context.Operators.Union<CqlInterval<CqlDate>>(e_, k_);
        int? m_ = this.CumulativeDuration(context, l_);

        return m_;
    }


    public int? cumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? a_(object M)
        {
            bool n_ = M is MedicationRequest;

            return n_ as bool?;
        };
        IEnumerable<object> b_ = context.Operators.Where<object>(Medications, a_);
        CqlInterval<CqlDate> c_(object M)
        {
            CqlInterval<CqlDate> o_ = this.medicationRequestPeriod(context, M as MedicationRequest);

            return o_;
        };
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Select<object, CqlInterval<CqlDate>>(b_, c_);
        IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.Distinct<CqlInterval<CqlDate>>(d_);
        bool? f_(object M)
        {
            bool p_ = M is MedicationDispense;

            return p_ as bool?;
        };
        IEnumerable<object> g_ = context.Operators.Where<object>(Medications, f_);
        CqlInterval<CqlDate> h_(object M)
        {
            CqlInterval<CqlDate> q_ = this.medicationDispensePeriod(context, M as MedicationDispense);

            return q_;
        };
        IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.Select<object, CqlInterval<CqlDate>>(g_, h_);
        IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.Distinct<CqlInterval<CqlDate>>(i_);
        IEnumerable<CqlInterval<CqlDate>> k_ = this.rolloutIntervals(context, j_);
        IEnumerable<CqlInterval<CqlDate>> l_ = context.Operators.Union<CqlInterval<CqlDate>>(e_, k_);
        int? m_ = this.cumulativeDuration(context, l_);

        return m_;
    }


}

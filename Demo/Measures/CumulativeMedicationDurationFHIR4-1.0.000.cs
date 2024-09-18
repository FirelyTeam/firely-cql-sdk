using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("CumulativeMedicationDurationFHIR4", "1.0.000")]
public class CumulativeMedicationDurationFHIR4_1_0_000
{

    public static CumulativeMedicationDurationFHIR4_1_0_000 Instance { get; }  = new();

    [CqlDeclaration("AC")]
	public CqlCode AC(CqlContext context) => 
		new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("ACD")]
	public CqlCode ACD(CqlContext context) => 
		new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("ACM")]
	public CqlCode ACM(CqlContext context) => 
		new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("ACV")]
	public CqlCode ACV(CqlContext context) => 
		new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("AFT")]
	public CqlCode AFT(CqlContext context) => 
		new CqlCode("AFT", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("AFT.early")]
	public CqlCode AFT_early(CqlContext context) => 
		new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("AFT.late")]
	public CqlCode AFT_late(CqlContext context) => 
		new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("C")]
	public CqlCode C(CqlContext context) => 
		new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("CD")]
	public CqlCode CD(CqlContext context) => 
		new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("CM")]
	public CqlCode CM(CqlContext context) => 
		new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("CV")]
	public CqlCode CV(CqlContext context) => 
		new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("EVE")]
	public CqlCode EVE(CqlContext context) => 
		new CqlCode("EVE", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("EVE.early")]
	public CqlCode EVE_early(CqlContext context) => 
		new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("EVE.late")]
	public CqlCode EVE_late(CqlContext context) => 
		new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("HS")]
	public CqlCode HS(CqlContext context) => 
		new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("MORN")]
	public CqlCode MORN(CqlContext context) => 
		new CqlCode("MORN", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("MORN.early")]
	public CqlCode MORN_early(CqlContext context) => 
		new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("MORN.late")]
	public CqlCode MORN_late(CqlContext context) => 
		new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("NIGHT")]
	public CqlCode NIGHT(CqlContext context) => 
		new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("NOON")]
	public CqlCode NOON(CqlContext context) => 
		new CqlCode("NOON", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("PC")]
	public CqlCode PC(CqlContext context) => 
		new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PCD")]
	public CqlCode PCD(CqlContext context) => 
		new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PCM")]
	public CqlCode PCM(CqlContext context) => 
		new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PCV")]
	public CqlCode PCV(CqlContext context) => 
		new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PHS")]
	public CqlCode PHS(CqlContext context) => 
		new CqlCode("PHS", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("WAKE")]
	public CqlCode WAKE(CqlContext context) => 
		new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("V3TimingEvent")]
	public CqlCode[] V3TimingEvent(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
		};

		return a_;
	}

    [CqlDeclaration("EventTiming")]
	public CqlCode[] EventTiming(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("AFT", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("EVE", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("MORN", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("NOON", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("PHS", "http://hl7.org/fhir/event-timing", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ErrorLevel")]
	public string ErrorLevel(CqlContext context)
	{
		var a_ = context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", "Warning");

		return (string)a_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("ToDaily")]
	public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
	{
		decimal? a_()
		{
			if ((context.Operators.Equal(period?.unit, "h") ?? false))
			{
				var b_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var c_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var d_ = context.Operators.Multiply(b_, c_);

				return d_;
			}
			else if ((context.Operators.Equal(period?.unit, "min") ?? false))
			{
				var e_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var f_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var g_ = context.Operators.Multiply(e_, f_);
				var h_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var i_ = context.Operators.Multiply(g_, h_);

				return i_;
			}
			else if ((context.Operators.Equal(period?.unit, "s") ?? false))
			{
				var j_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var k_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var l_ = context.Operators.Multiply(j_, k_);
				var m_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var n_ = context.Operators.Multiply(l_, m_);
				var p_ = context.Operators.Multiply(n_, m_);

				return p_;
			}
			else if ((context.Operators.Equal(period?.unit, "d") ?? false))
			{
				var q_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var r_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var s_ = context.Operators.Multiply(q_, r_);
				var t_ = context.Operators.ConvertIntegerToDecimal((int?)24);
				var u_ = context.Operators.Divide(s_, t_);

				return u_;
			}
			else if ((context.Operators.Equal(period?.unit, "wk") ?? false))
			{
				var v_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var w_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var x_ = context.Operators.Multiply(v_, w_);
				var y_ = context.Operators.Multiply((int?)24, (int?)7);
				var z_ = context.Operators.ConvertIntegerToDecimal(y_);
				var aa_ = context.Operators.Divide(x_, z_);

				return aa_;
			}
			else if ((context.Operators.Equal(period?.unit, "mo") ?? false))
			{
				var ab_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ac_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var ad_ = context.Operators.Multiply(ab_, ac_);
				var ae_ = context.Operators.Multiply((int?)24, (int?)30);
				var af_ = context.Operators.ConvertIntegerToDecimal(ae_);
				var ag_ = context.Operators.Divide(ad_, af_);

				return ag_;
			}
			else if ((context.Operators.Equal(period?.unit, "a") ?? false))
			{
				var ah_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ai_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var aj_ = context.Operators.Multiply(ah_, ai_);
				var ak_ = context.Operators.Multiply((int?)24, (int?)365);
				var al_ = context.Operators.ConvertIntegerToDecimal(ak_);
				var am_ = context.Operators.Divide(aj_, al_);

				return am_;
			}
			else if ((context.Operators.Equal(period?.unit, "hour") ?? false))
			{
				var an_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ao_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var ap_ = context.Operators.Multiply(an_, ao_);

				return ap_;
			}
			else if ((context.Operators.Equal(period?.unit, "minute") ?? false))
			{
				var aq_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ar_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var as_ = context.Operators.Multiply(aq_, ar_);
				var at_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var au_ = context.Operators.Multiply(as_, at_);

				return au_;
			}
			else if ((context.Operators.Equal(period?.unit, "second") ?? false))
			{
				var av_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var aw_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var ax_ = context.Operators.Multiply(av_, aw_);
				var ay_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var az_ = context.Operators.Multiply(ax_, ay_);
				var bb_ = context.Operators.Multiply(az_, ay_);

				return bb_;
			}
			else if ((context.Operators.Equal(period?.unit, "day") ?? false))
			{
				var bc_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bd_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var be_ = context.Operators.Multiply(bc_, bd_);
				var bf_ = context.Operators.ConvertIntegerToDecimal((int?)24);
				var bg_ = context.Operators.Divide(be_, bf_);

				return bg_;
			}
			else if ((context.Operators.Equal(period?.unit, "week") ?? false))
			{
				var bh_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bi_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var bj_ = context.Operators.Multiply(bh_, bi_);
				var bk_ = context.Operators.Multiply((int?)24, (int?)7);
				var bl_ = context.Operators.ConvertIntegerToDecimal(bk_);
				var bm_ = context.Operators.Divide(bj_, bl_);

				return bm_;
			}
			else if ((context.Operators.Equal(period?.unit, "month") ?? false))
			{
				var bn_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bo_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var bp_ = context.Operators.Multiply(bn_, bo_);
				var bq_ = context.Operators.Multiply((int?)24, (int?)30);
				var br_ = context.Operators.ConvertIntegerToDecimal(bq_);
				var bs_ = context.Operators.Divide(bp_, br_);

				return bs_;
			}
			else if ((context.Operators.Equal(period?.unit, "year") ?? false))
			{
				var bt_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bu_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var bv_ = context.Operators.Multiply(bt_, bu_);
				var bw_ = context.Operators.Multiply((int?)24, (int?)365);
				var bx_ = context.Operators.ConvertIntegerToDecimal(bw_);
				var by_ = context.Operators.Divide(bv_, bx_);

				return by_;
			}
			else if ((context.Operators.Equal(period?.unit, "hours") ?? false))
			{
				var bz_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ca_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var cb_ = context.Operators.Multiply(bz_, ca_);

				return cb_;
			}
			else if ((context.Operators.Equal(period?.unit, "minutes") ?? false))
			{
				var cc_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cd_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var ce_ = context.Operators.Multiply(cc_, cd_);
				var cf_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var cg_ = context.Operators.Multiply(ce_, cf_);

				return cg_;
			}
			else if ((context.Operators.Equal(period?.unit, "seconds") ?? false))
			{
				var ch_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ci_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var cj_ = context.Operators.Multiply(ch_, ci_);
				var ck_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var cl_ = context.Operators.Multiply(cj_, ck_);
				var cn_ = context.Operators.Multiply(cl_, ck_);

				return cn_;
			}
			else if ((context.Operators.Equal(period?.unit, "days") ?? false))
			{
				var co_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cp_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var cq_ = context.Operators.Multiply(co_, cp_);
				var cr_ = context.Operators.ConvertIntegerToDecimal((int?)24);
				var cs_ = context.Operators.Divide(cq_, cr_);

				return cs_;
			}
			else if ((context.Operators.Equal(period?.unit, "weeks") ?? false))
			{
				var ct_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cu_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var cv_ = context.Operators.Multiply(ct_, cu_);
				var cw_ = context.Operators.Multiply((int?)24, (int?)7);
				var cx_ = context.Operators.ConvertIntegerToDecimal(cw_);
				var cy_ = context.Operators.Divide(cv_, cx_);

				return cy_;
			}
			else if ((context.Operators.Equal(period?.unit, "months") ?? false))
			{
				var cz_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var da_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var db_ = context.Operators.Multiply(cz_, da_);
				var dc_ = context.Operators.Multiply((int?)24, (int?)30);
				var dd_ = context.Operators.ConvertIntegerToDecimal(dc_);
				var de_ = context.Operators.Divide(db_, dd_);

				return de_;
			}
			else if ((context.Operators.Equal(period?.unit, "years") ?? false))
			{
				var df_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var dg_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var dh_ = context.Operators.Multiply(df_, dg_);
				var di_ = context.Operators.Multiply((int?)24, (int?)365);
				var dj_ = context.Operators.ConvertIntegerToDecimal(di_);
				var dk_ = context.Operators.Divide(dh_, dj_);

				return dk_;
			}
			else
			{
				var dl_ = this.ErrorLevel(context);
				var dm_ = context.Operators.Concatenate("Unknown unit ", (period?.unit ?? ""));
				var dn_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", dl_, dm_);

				return (decimal?)dn_;
			};
		};

		return a_();
	}

    [CqlDeclaration("ToDaily")]
	public decimal? ToDaily(CqlContext context, CqlCode frequency)
	{
		decimal? a_()
		{
			if ((context.Operators.Equal(frequency, this.C(context)) ?? false))
			{
				return (decimal?)3.0m;
			}
			else
			{
				var b_ = this.ErrorLevel(context);
				var c_ = context.Operators.Concatenate("Unknown frequency code ", (frequency?.code ?? ""));
				var d_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", b_, c_);

				return (decimal?)d_;
			};
		};

		return a_();
	}

    [CqlDeclaration("MedicationRequestPeriod")]
	public CqlInterval<CqlDateTime> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
	{
		var a_ = new MedicationRequest[]
		{
			Request,
		};
		CqlInterval<CqlDateTime> b_(MedicationRequest R)
		{
			CqlInterval<CqlDateTime> e_()
			{
				if ((context.Operators.Not(context.Operators.Or((bool?)(context.Operators.End(FHIRHelpers_4_0_001.Instance.ToInterval(context, ((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as Period))) is null), context.Operators.Equal(context.Operators.End(FHIRHelpers_4_0_001.Instance.ToInterval(context, ((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as Period))), context.Operators.Maximum<CqlDateTime>()))) ?? false))
				{
					var f_ = context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
					var g_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, (f_?.Timing?.Repeat?.Bounds as Period));
					var h_ = context.Operators.Start(g_);
					var i_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, R?.DispenseRequest?.ValidityPeriod);
					var j_ = context.Operators.Start(i_);
					var k_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, R?.AuthoredOnElement);
					var m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, (f_?.Timing?.Repeat?.Bounds as Period));
					var n_ = context.Operators.End(m_);
					var o_ = context.Operators.Interval(((h_ ?? j_) ?? k_), n_, true, true);

					return o_;
				}
				else
				{
					var p_ = context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
					var q_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, (p_?.Timing?.Repeat?.Bounds as Period));
					var r_ = context.Operators.Start(q_);
					var s_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, R?.DispenseRequest?.ValidityPeriod);
					var t_ = context.Operators.Start(s_);
					var u_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, R?.AuthoredOnElement);
					var w_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, (p_?.Timing?.Repeat?.Bounds as Period));
					var x_ = context.Operators.Start(w_);
					var z_ = context.Operators.Start(s_);
					var ab_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, R?.DispenseRequest?.ExpectedSupplyDuration);
					var ac_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, R?.DispenseRequest?.Quantity);
					var ae_ = context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>((p_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					var af_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, (ae_?.Dose as Range));
					var ag_ = context.Operators.End(af_);
					var ai_ = context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>((p_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					var aj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (ai_?.Dose as Quantity));
					var al_ = context.Operators.Convert<Integer>(p_?.Timing?.Repeat?.FrequencyMaxElement);
					var an_ = context.Operators.Convert<Integer>(p_?.Timing?.Repeat?.FrequencyElement);
					var ao_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, (al_ ?? an_));
					var aq_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, p_?.Timing?.Repeat?.PeriodElement);
					var as_ = context.Operators.Convert<string>(p_?.Timing?.Repeat?.PeriodUnitElement?.Value);
					var at_ = this.ToDaily(context, ao_, new CqlQuantity(aq_, as_));
					var av_ = context.Operators.CountOrNull<Time>((p_?.Timing?.Repeat?.TimeOfDayElement as IEnumerable<Time>));
					var aw_ = context.Operators.ConvertIntegerToDecimal(av_);
					var ax_ = context.Operators.ConvertDecimalToQuantity(((at_ ?? aw_) ?? (decimal?)1.0m));
					var ay_ = context.Operators.Multiply((ag_ ?? aj_), ax_);
					var az_ = context.Operators.Divide(ac_, ay_);
					var ba_ = context.Operators.Convert<Integer>(R?.DispenseRequest?.NumberOfRepeatsAllowedElement);
					var bb_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ba_);
					var bc_ = context.Operators.Add((int?)1, (bb_ ?? (int?)0));
					var bd_ = context.Operators.ConvertIntegerToQuantity(bc_);
					var be_ = context.Operators.Multiply((ab_ ?? az_), bd_);
					var bf_ = context.Operators.Add(((x_ ?? z_) ?? u_), be_);
					var bg_ = context.Operators.Interval(((r_ ?? t_) ?? u_), bf_, true, true);

					return bg_;
				};
			};

			return e_();
		};
		var c_ = context.Operators.SelectOrNull<MedicationRequest, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("MedicationDispensePeriod")]
	public CqlInterval<CqlDateTime> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
	{
		var a_ = new MedicationDispense[]
		{
			Dispense,
		};
		CqlInterval<CqlDateTime> b_(MedicationDispense D)
		{
			var e_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, (D?.WhenHandedOverElement ?? D?.WhenPreparedElement));
			var g_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, D?.DaysSupply);
			var h_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, D?.Quantity);
			var i_ = context.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>));
			var j_ = context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>((i_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
			var k_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, (j_?.Dose as Range));
			var l_ = context.Operators.End(k_);
			var n_ = context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>((i_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
			var o_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, (n_?.Dose as Quantity));
			var q_ = context.Operators.Convert<Integer>(i_?.Timing?.Repeat?.FrequencyMaxElement);
			var s_ = context.Operators.Convert<Integer>(i_?.Timing?.Repeat?.FrequencyElement);
			var t_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, (q_ ?? s_));
			var v_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, i_?.Timing?.Repeat?.PeriodElement);
			var x_ = context.Operators.Convert<string>(i_?.Timing?.Repeat?.PeriodUnitElement?.Value);
			var y_ = this.ToDaily(context, t_, new CqlQuantity(v_, x_));
			var aa_ = context.Operators.CountOrNull<Time>((i_?.Timing?.Repeat?.TimeOfDayElement as IEnumerable<Time>));
			var ab_ = context.Operators.ConvertIntegerToDecimal(aa_);
			var ac_ = context.Operators.ConvertDecimalToQuantity(((y_ ?? ab_) ?? (decimal?)1.0m));
			var ad_ = context.Operators.Multiply((l_ ?? o_), ac_);
			var ae_ = context.Operators.Divide(h_, ad_);
			var af_ = context.Operators.Add(e_, (g_ ?? ae_));
			var ag_ = context.Operators.Interval(e_, af_, true, true);

			return ag_;
		};
		var c_ = context.Operators.SelectOrNull<MedicationDispense, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("TherapeuticDuration")]
	public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
	{
		var a_ = context.Operators.Quantity(14m, "days");

		return a_;
	}

    [CqlDeclaration("MedicationAdministrationPeriod")]
	public CqlInterval<CqlDateTime> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
	{
		var a_ = new MedicationAdministration[]
		{
			Administration,
		};
		CqlInterval<CqlDateTime> b_(MedicationAdministration M)
		{
			CqlInterval<CqlDateTime> e_()
			{
				if ((context.Operators.And(context.Operators.Not((bool?)(context.Operators.Start(FHIRHelpers_4_0_001.Instance.ToInterval(context, (Administration?.Effective as Period))) is null)), context.Operators.Not((bool?)(this.TherapeuticDuration(context, FHIRHelpers_4_0_001.Instance.ToConcept(context, (Administration?.Medication as CodeableConcept))) is null))) ?? false))
				{
					var f_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, (Administration?.Effective as Period));
					var g_ = context.Operators.Start(f_);
					var i_ = context.Operators.Start(f_);
					var j_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, (Administration?.Medication as CodeableConcept));
					var k_ = this.TherapeuticDuration(context, j_);
					var l_ = context.Operators.Add(i_, k_);
					var m_ = context.Operators.Interval(g_, l_, true, true);

					return m_;
				}
				else
				{
					CqlInterval<CqlDateTime> n_ = null;

					return (n_ as CqlInterval<CqlDateTime>);
				};
			};

			return e_();
		};
		var c_ = context.Operators.SelectOrNull<MedicationAdministration, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("CumulativeDuration")]
	public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> Intervals)
	{
		var a_ = context.Operators.Collapse(Intervals, "day");
		int? b_(CqlInterval<CqlDateTime> X)
		{
			var e_ = context.Operators.Start(X);
			var f_ = context.Operators.End(X);
			var g_ = context.Operators.DifferenceBetween(e_, f_, "day");

			return g_;
		};
		var c_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, int?>(a_, b_);
		var d_ = context.Operators.Sum(c_);

		return d_;
	}

    [CqlDeclaration("RolloutIntervals")]
	public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_ = null;
		IEnumerable<CqlInterval<CqlDateTime>> b_(IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I)
		{
			var d_ = new CqlInterval<CqlDateTime>[]
			{
				I,
			};
			CqlInterval<CqlDateTime> e_(CqlInterval<CqlDateTime> X)
			{
				var j_ = context.Operators.LastOfList<CqlInterval<CqlDateTime>>(R);
				var k_ = context.Operators.End(j_);
				var l_ = context.Operators.Quantity(1m, "day");
				var m_ = context.Operators.Add(k_, l_);
				var n_ = context.Operators.Start(X);
				var o_ = new CqlDateTime[]
				{
					m_,
					n_,
				};
				var p_ = context.Operators.MaxOrNull<CqlDateTime>((o_ as IEnumerable<CqlDateTime>));
				var r_ = context.Operators.End(j_);
				var t_ = context.Operators.Add(r_, l_);
				var v_ = new CqlDateTime[]
				{
					t_,
					n_,
				};
				var w_ = context.Operators.MaxOrNull<CqlDateTime>((v_ as IEnumerable<CqlDateTime>));
				var y_ = context.Operators.End(X);
				var z_ = context.Operators.DurationBetween(n_, y_, "day");
				var aa_ = context.Operators.ConvertIntegerToDecimal((z_ ?? (int?)0));
				var ab_ = context.Operators.Add(w_, new CqlQuantity(aa_, "day"));
				var ac_ = context.Operators.Interval(p_, ab_, true, true);

				return ac_;
			};
			var f_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, e_);
			var g_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(f_);
			var h_ = new CqlInterval<CqlDateTime>[]
			{
				g_,
			};
			var i_ = context.Operators.ListUnion<CqlInterval<CqlDateTime>>(R, (h_ as IEnumerable<CqlInterval<CqlDateTime>>));

			return i_;
		};
		var c_ = context.Operators.AggregateOrNull<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, (a_ as IEnumerable<CqlInterval<CqlDateTime>>), b_);

		return c_;
	}

    [CqlDeclaration("MedicationPeriod")]
	public CqlInterval<CqlDateTime> MedicationPeriod(CqlContext context, object medication)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (medication is MedicationRequest)
			{
				var b_ = this.MedicationRequestPeriod(context, (medication as MedicationRequest));

				return b_;
			}
			else if (medication is MedicationDispense)
			{
				var c_ = this.MedicationDispensePeriod(context, (medication as MedicationDispense));

				return c_;
			}
			else if (medication is MedicationAdministration)
			{
				var d_ = this.MedicationAdministrationPeriod(context, (medication as MedicationAdministration));

				return d_;
			}
			else
			{
				CqlInterval<CqlDateTime> e_ = null;

				return (e_ as CqlInterval<CqlDateTime>);
			};
		};

		return a_();
	}

    [CqlDeclaration("CumulativeMedicationDuration")]
	public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
	{
		bool? a_(object M)
		{
			var l_ = M is MedicationRequest;

			return (l_ as bool?);
		};
		var b_ = context.Operators.WhereOrNull<object>(Medications, a_);
		CqlInterval<CqlDateTime> c_(object M)
		{
			var m_ = this.MedicationPeriod(context, M);

			return m_;
		};
		var d_ = context.Operators.SelectOrNull<object, CqlInterval<CqlDateTime>>(b_, c_);
		bool? e_(object M)
		{
			var n_ = M is MedicationDispense;
			var o_ = M is MedicationAdministration;
			var p_ = context.Operators.Or((n_ as bool?), (o_ as bool?));

			return p_;
		};
		var f_ = context.Operators.WhereOrNull<object>(Medications, e_);
		CqlInterval<CqlDateTime> g_(object M)
		{
			var q_ = this.MedicationPeriod(context, M);

			return q_;
		};
		var h_ = context.Operators.SelectOrNull<object, CqlInterval<CqlDateTime>>(f_, g_);
		var i_ = this.RolloutIntervals(context, h_);
		var j_ = context.Operators.ListUnion<CqlInterval<CqlDateTime>>(d_, i_);
		var k_ = this.CumulativeDuration(context, j_);

		return k_;
	}

}
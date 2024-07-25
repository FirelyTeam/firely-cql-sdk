using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("NCQAClaims", "1.0.0")]
public class NCQAClaims_1_0_0
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Inpatient_Stay;
    internal Lazy<CqlValueSet> __Nonacute_Inpatient_Stay;

    #endregion
    public NCQAClaims_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        NCQAFHIRBase_1_0_0 = new NCQAFHIRBase_1_0_0(context);
        NCQATerminology_1_0_0 = new NCQATerminology_1_0_0(context);

        __Inpatient_Stay = new Lazy<CqlValueSet>(this.Inpatient_Stay_Value);
        __Nonacute_Inpatient_Stay = new Lazy<CqlValueSet>(this.Nonacute_Inpatient_Stay_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public NCQAFHIRBase_1_0_0 NCQAFHIRBase_1_0_0 { get; }
    public NCQATerminology_1_0_0 NCQATerminology_1_0_0 { get; }

    #endregion

	private CqlValueSet Inpatient_Stay_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395", null);

    [CqlDeclaration("Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395")]
	public CqlValueSet Inpatient_Stay() => 
		__Inpatient_Stay.Value;

	private CqlValueSet Nonacute_Inpatient_Stay_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398", null);

    [CqlDeclaration("Nonacute Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398")]
	public CqlValueSet Nonacute_Inpatient_Stay() => 
		__Nonacute_Inpatient_Stay.Value;

    [CqlDeclaration("Professional or Institutional Claims")]
	public IEnumerable<Claim> Professional_or_Institutional_Claims(IEnumerable<Claim> claim)
	{
		bool? a_(Claim MedicalClaim)
		{
			var c_ = MedicalClaim.Type;
			var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var e_ = d_.codes;
			var f_ = NCQATerminology_1_0_0.Professional();
			var g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);
			var i_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var j_ = i_.codes;
			var k_ = NCQATerminology_1_0_0.Institutional();
			var l_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)j_, k_);
			var m_ = context.Operators.Or(g_, l_);

			return m_;
		};
		var b_ = context.Operators.Where<Claim>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Pharmacy Claims")]
	public IEnumerable<Claim> Pharmacy_Claims(IEnumerable<Claim> claim)
	{
		bool? a_(Claim PharmacyClaim)
		{
			var c_ = PharmacyClaim.Type;
			var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var e_ = d_.codes;
			var f_ = NCQATerminology_1_0_0.Pharmacy();
			var g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);

			return g_;
		};
		var b_ = context.Operators.Where<Claim>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Professional or Institutional Claims Response")]
	public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse MedicalResponse)
		{
			var c_ = MedicalResponse.Type;
			var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var e_ = d_.codes;
			var f_ = NCQATerminology_1_0_0.Professional();
			var g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);
			var i_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var j_ = i_.codes;
			var k_ = NCQATerminology_1_0_0.Institutional();
			var l_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)j_, k_);
			var m_ = context.Operators.Or(g_, l_);

			return m_;
		};
		var b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);

		return b_;
	}

    [CqlDeclaration("Pharmacy Claims Response")]
	public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse PharmacyResponse)
		{
			var c_ = PharmacyResponse.Type;
			var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var e_ = d_.codes;
			var f_ = NCQATerminology_1_0_0.Pharmacy();
			var g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);

			return g_;
		};
		var b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);

		return b_;
	}

    [CqlDeclaration("Medical Claims With Procedure and POS")]
	public IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_and_POS(IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p)
		{
			var k_ = p.code;

			return k_;
		};
		var c_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, b_);
		string d_(CqlCode pos)
		{
			var l_ = pos.code;

			return l_;
		};
		var e_ = context.Operators.Select<CqlCode, string>(posCodes, d_);
		var f_ = (a_, c_, e_);
		var g_ = new (IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[]
		{
			f_,
		};
		IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_((IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithPosCode)
		{
			var m_ = ClaimWithPosCode?.MedicalClaim;
			(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? n_(Claim ClaimofInterest)
			{
				IEnumerable<Claim.ItemComponent> r_()
				{
					if ((ClaimofInterest is null))
					{
						return (null as IEnumerable<Claim.ItemComponent>);
					}
					else
					{
						var x_ = ClaimofInterest.Item;
						bool? y_(Claim.ItemComponent ItemOnLine)
						{
							var aa_ = ItemOnLine.ProductOrService;
							var ab_ = FHIRHelpers_4_0_001.ToConcept(aa_);
							var ac_ = ab_.codes;
							bool? ad_(CqlCode LineCode)
							{
								var an_ = LineCode.code;
								var ao_ = ClaimWithPosCode?.ProceduresAsStrings;
								var ap_ = context.Operators.In<string>(an_, ao_);

								return ap_;
							};
							var ae_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)ac_, ad_);
							var af_ = context.Operators.Exists<CqlCode>(ae_);
							var ag_ = ItemOnLine.Location;
							var ah_ = FHIRHelpers_4_0_001.ToConcept((ag_ as CodeableConcept));
							var ai_ = ah_.codes;
							bool? aj_(CqlCode PosCode)
							{
								var aq_ = PosCode.code;
								var ar_ = ClaimWithPosCode?.POSAsString;
								var as_ = context.Operators.In<string>(aq_, ar_);

								return as_;
							};
							var ak_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)ai_, aj_);
							var al_ = context.Operators.Exists<CqlCode>(ak_);
							var am_ = context.Operators.And(af_, al_);

							return am_;
						};
						var z_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)x_, y_);

						return z_;
					}
				};
				var s_ = (ClaimofInterest, r_());
				var t_ = new (Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[]
				{
					s_,
				};
				(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? u_((Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
				{
					(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? at_()
					{
						bool au_()
						{
							var av_ = LineItemDefinition?.LineItems;
							var aw_ = context.Operators.Exists<Claim.ItemComponent>(av_);

							return (aw_ ?? false);
						};
						if (au_())
						{
							var ax_ = LineItemDefinition?.Claim;
							var ay_ = LineItemDefinition?.LineItems;
							bool? az_(Claim.ItemComponent @this)
							{
								var bg_ = @this.Serviced;
								var bh_ = context.Operators.Not((bool?)(bg_ is null));

								return bh_;
							};
							var ba_ = context.Operators.Where<Claim.ItemComponent>(ay_, az_);
							DataType bb_(Claim.ItemComponent @this)
							{
								var bi_ = @this.Serviced;

								return bi_;
							};
							var bc_ = context.Operators.Select<Claim.ItemComponent, DataType>(ba_, bb_);
							CqlInterval<CqlDateTime> bd_(object NormalDate)
							{
								var bj_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return bj_;
							};
							var be_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>((IEnumerable<object>)bc_, bd_);
							var bf_ = (ax_, be_);

							return bf_;
						}
						else
						{
							return (null as (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?);
						}
					};

					return at_();
				};
				var v_ = context.Operators.Select<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)t_), u_);
				var w_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(v_);

				return w_;
			};
			var o_ = context.Operators.Select<Claim, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(m_, n_);
			bool? p_((Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
			{
				var bk_ = context.Operators.Not((bool?)(FinalList is null));

				return bk_;
			};
			var q_ = context.Operators.Where<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(o_, p_);

			return q_;
		};
		var i_ = context.Operators.Select<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(((IEnumerable<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)g_), h_);
		var j_ = context.Operators.SingletonFrom<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Procedure in Header or on Line Item")]
	public IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p)
		{
			var i_ = p.code;

			return i_;
		};
		var c_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, b_);
		var d_ = (a_, c_);
		var e_ = new (IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[]
		{
			d_,
		};
		IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_((IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithProcedure)
		{
			var j_ = ClaimWithProcedure?.MedicalClaim;
			(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? k_(Claim ClaimofInterest)
			{
				IEnumerable<Claim.ItemComponent> o_()
				{
					if ((ClaimofInterest is null))
					{
						return (null as IEnumerable<Claim.ItemComponent>);
					}
					else
					{
						var u_ = ClaimofInterest.Item;
						bool? v_(Claim.ItemComponent ItemOnLine)
						{
							var x_ = ItemOnLine.ProductOrService;
							var y_ = FHIRHelpers_4_0_001.ToConcept(x_);
							var z_ = y_.codes;
							bool? aa_(CqlCode LineCode)
							{
								var ar_ = LineCode.code;
								var as_ = ClaimWithProcedure?.ProceduresAsStrings;
								var at_ = context.Operators.In<string>(ar_, as_);

								return at_;
							};
							var ab_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)z_, aa_);
							var ac_ = context.Operators.Exists<CqlCode>(ab_);
							var ad_ = ClaimofInterest.Procedure;
							bool? ae_(Claim.ProcedureComponent @this)
							{
								var au_ = @this.Procedure;
								var av_ = context.Operators.Not((bool?)(au_ is null));

								return av_;
							};
							var af_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)ad_, ae_);
							DataType ag_(Claim.ProcedureComponent @this)
							{
								var aw_ = @this.Procedure;

								return aw_;
							};
							var ah_ = context.Operators.Select<Claim.ProcedureComponent, DataType>(af_, ag_);
							bool? ai_(object @this)
							{
								var ax_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								var ay_ = context.Operators.Not((bool?)(ax_ is null));

								return ay_;
							};
							var aj_ = context.Operators.Where<object>((IEnumerable<object>)ah_, ai_);
							object ak_(object @this)
							{
								var az_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return az_;
							};
							var al_ = context.Operators.Select<object, object>(aj_, ak_);
							var am_ = context.Operators.FlattenLateBoundList(al_);
							bool? an_(object HeaderCode)
							{
								var ba_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
								var bb_ = ba_.Value;
								var bc_ = ClaimWithProcedure?.ProceduresAsStrings;
								var bd_ = context.Operators.In<string>(bb_, bc_);

								return bd_;
							};
							var ao_ = context.Operators.Where<object>(am_, an_);
							var ap_ = context.Operators.Exists<object>(ao_);
							var aq_ = context.Operators.Or(ac_, ap_);

							return aq_;
						};
						var w_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)u_, v_);

						return w_;
					}
				};
				var p_ = (ClaimofInterest, o_());
				var q_ = new (Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[]
				{
					p_,
				};
				(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? r_((Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
				{
					(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? be_()
					{
						bool bf_()
						{
							var bg_ = LineItemDefinition?.LineItems;
							var bh_ = context.Operators.Exists<Claim.ItemComponent>(bg_);

							return (bh_ ?? false);
						};
						if (bf_())
						{
							var bi_ = LineItemDefinition?.Claim;
							var bj_ = LineItemDefinition?.LineItems;
							bool? bk_(Claim.ItemComponent @this)
							{
								var br_ = @this.Serviced;
								var bs_ = context.Operators.Not((bool?)(br_ is null));

								return bs_;
							};
							var bl_ = context.Operators.Where<Claim.ItemComponent>(bj_, bk_);
							DataType bm_(Claim.ItemComponent @this)
							{
								var bt_ = @this.Serviced;

								return bt_;
							};
							var bn_ = context.Operators.Select<Claim.ItemComponent, DataType>(bl_, bm_);
							CqlInterval<CqlDateTime> bo_(object NormalDate)
							{
								var bu_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return bu_;
							};
							var bp_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>((IEnumerable<object>)bn_, bo_);
							var bq_ = (bi_, bp_);

							return bq_;
						}
						else
						{
							return (null as (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?);
						}
					};

					return be_();
				};
				var s_ = context.Operators.Select<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)q_), r_);
				var t_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(s_);

				return t_;
			};
			var l_ = context.Operators.Select<Claim, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(j_, k_);
			bool? m_((Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
			{
				var bv_ = context.Operators.Not((bool?)(FinalList is null));

				return bv_;
			};
			var n_ = context.Operators.Where<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(l_, m_);

			return n_;
		};
		var g_ = context.Operators.Select<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(((IEnumerable<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)e_), f_);
		var h_ = context.Operators.SingletonFrom<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis")]
	public (IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Medical_Claims_With_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var i_ = d.code;

			return i_;
		};
		var c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		var d_ = (a_, c_);
		var e_ = new (IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[]
		{
			d_,
		};
		(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_((IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
		{
			IEnumerable<Claim> j_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					return (null as IEnumerable<Claim>);
				}
				else
				{
					var p_ = ClaimWithDiagnosis?.MedicalClaim;
					bool? q_(Claim DiagnosisLine)
					{
						var s_ = DiagnosisLine.Diagnosis;
						bool? t_(Claim.DiagnosisComponent @this)
						{
							var af_ = @this.Diagnosis;
							var ag_ = context.Operators.Not((bool?)(af_ is null));

							return ag_;
						};
						var u_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)s_, t_);
						DataType v_(Claim.DiagnosisComponent @this)
						{
							var ah_ = @this.Diagnosis;

							return ah_;
						};
						var w_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(u_, v_);
						bool? x_(object @this)
						{
							var ai_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							var aj_ = context.Operators.Not((bool?)(ai_ is null));

							return aj_;
						};
						var y_ = context.Operators.Where<object>((IEnumerable<object>)w_, x_);
						object z_(object @this)
						{
							var ak_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return ak_;
						};
						var aa_ = context.Operators.Select<object, object>(y_, z_);
						var ab_ = context.Operators.FlattenLateBoundList(aa_);
						bool? ac_(object HeaderCode)
						{
							var al_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
							var am_ = al_.Value;
							var an_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
							var ao_ = context.Operators.In<string>(am_, an_);

							return ao_;
						};
						var ad_ = context.Operators.Where<object>(ab_, ac_);
						var ae_ = context.Operators.Exists<object>(ad_);

						return ae_;
					};
					var r_ = context.Operators.Where<Claim>(p_, q_);

					return r_;
				}
			};
			var k_ = (j_(), default(nint));
			var l_ = new (IEnumerable<Claim> DiagnosisItems, nint _)?[]
			{
				k_,
			};
			(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_((IEnumerable<Claim> DiagnosisItems, nint _)? HeaderDefinition)
			{
				(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ap_()
				{
					bool au_()
					{
						var av_ = HeaderDefinition?.DiagnosisItems;
						var aw_ = context.Operators.Exists<Claim>(av_);

						return (aw_ ?? false);
					};
					if (au_())
					{
						var ax_ = HeaderDefinition?.DiagnosisItems;
						bool? az_(Claim @this)
						{
							var bh_ = @this.Item;
							var bi_ = context.Operators.Not((bool?)(bh_ is null));

							return bi_;
						};
						var ba_ = context.Operators.Where<Claim>(ax_, az_);
						List<Claim.ItemComponent> bb_(Claim @this)
						{
							var bj_ = @this.Item;

							return bj_;
						};
						var bc_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ba_, bb_);
						var bd_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)bc_);
						CqlInterval<CqlDateTime> be_(Claim.ItemComponent NormalDate)
						{
							var bk_ = NormalDate.Serviced;
							var bl_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bk_);

							return bl_;
						};
						var bf_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bd_, be_);
						var bg_ = (ax_, bf_);

						return bg_;
					}
					else
					{
						return (null as (IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?);
					}
				};
				var aq_ = new (IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[]
				{
					ap_(),
				};
				bool? ar_((IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
				{
					var bm_ = context.Operators.Not((bool?)(FinalList is null));

					return bm_;
				};
				var as_ = context.Operators.Where<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)aq_), ar_);
				var at_ = context.Operators.SingletonFrom<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(as_);

				return at_;
			};
			var n_ = context.Operators.Select<(IEnumerable<Claim> DiagnosisItems, nint _)?, (IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<Claim> DiagnosisItems, nint _)?>)l_), m_);
			var o_ = context.Operators.SingletonFrom<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(n_);

			return o_;
		};
		var g_ = context.Operators.Select<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, (IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)e_), f_);
		var h_ = context.Operators.SingletonFrom<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(g_);

		return h_;
	}

    [CqlDeclaration("Pharmacy Claim With Medication")]
	public IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> Pharmacy_Claim_With_Medication(IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
	{
		var a_ = this.Pharmacy_Claims(claim);
		string b_(CqlCode p)
		{
			var i_ = p.code;

			return i_;
		};
		var c_ = context.Operators.Select<CqlCode, string>(MedicationCodes, b_);
		var d_ = (a_, c_);
		var e_ = new (IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?[]
		{
			d_,
		};
		IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> f_((IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? ClaimWithMedication)
		{
			var j_ = ClaimWithMedication?.PharmacyClaim;
			(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? k_(Claim Pharmacy)
			{
				var o_ = Pharmacy.Item;
				bool? p_(Claim.ItemComponent ItemOnLine)
				{
					var w_ = ItemOnLine.ProductOrService;
					var x_ = FHIRHelpers_4_0_001.ToConcept(w_);
					var y_ = x_.codes;
					bool? z_(CqlCode LineCode)
					{
						var ac_ = LineCode.code;
						var ad_ = ClaimWithMedication?.MedicationsAsStrings;
						var ae_ = context.Operators.In<string>(ac_, ad_);

						return ae_;
					};
					var aa_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)y_, z_);
					var ab_ = context.Operators.Exists<CqlCode>(aa_);

					return ab_;
				};
				var q_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)o_, p_);
				var r_ = (Pharmacy, q_);
				var s_ = new (Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[]
				{
					r_,
				};
				(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? t_((Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
				{
					var af_ = LineItemDefinition?.Claim;
					var ag_ = new Claim[]
					{
						af_,
					};
					(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? ah_(Claim ClaimLines)
					{
						var ak_ = ClaimLines.Item;
						bool? al_(Claim.ItemComponent i)
						{
							var au_ = i.ProductOrService;
							var av_ = FHIRHelpers_4_0_001.ToConcept(au_);
							var aw_ = av_.codes;
							bool? ax_(CqlCode LineCode)
							{
								var ba_ = LineCode.code;
								var bb_ = ClaimWithMedication?.MedicationsAsStrings;
								var bc_ = context.Operators.In<string>(ba_, bb_);

								return bc_;
							};
							var ay_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)aw_, ax_);
							var az_ = context.Operators.Exists<CqlCode>(ay_);

							return az_;
						};
						var am_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ak_, al_);
						(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)? an_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDateTime> bd_()
							{
								bool bf_()
								{
									var bg_ = i.Quantity;
									var bh_ = context.Operators.Not((bool?)(bg_ is null));

									return (bh_ ?? false);
								};
								if (bf_())
								{
									CqlInterval<CqlDateTime> bi_()
									{
										bool bj_()
										{
											var bk_ = i.Serviced;
											var bl_ = bk_ is Period;

											return bl_;
										};
										if (bj_())
										{
											var bm_ = i.Serviced;
											var bn_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bm_);
											var bo_ = context.Operators.Start(bn_);
											var bq_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bm_);
											var br_ = context.Operators.Start(bq_);
											var bs_ = i.Quantity;
											var bt_ = bs_.ValueElement;
											var bu_ = FHIRHelpers_4_0_001.ToDecimal(bt_);
											var bv_ = context.Operators.Add(br_, new CqlQuantity(bu_, "day"));
											var bw_ = context.Operators.Quantity(1m, "day");
											var bx_ = context.Operators.Subtract(bv_, bw_);
											var by_ = context.Operators.Interval(bo_, bx_, true, true);

											return by_;
										}
										else
										{
											var bz_ = i.Serviced;
											var ca_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var cc_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var cd_ = i.Quantity;
											var ce_ = cd_.ValueElement;
											var cf_ = FHIRHelpers_4_0_001.ToDecimal(ce_);
											var cg_ = context.Operators.Add(cc_, new CqlQuantity(cf_, "day"));
											var ch_ = context.Operators.Quantity(1m, "day");
											var ci_ = context.Operators.Subtract(cg_, ch_);
											var cj_ = context.Operators.Interval(ca_, ci_, true, true);
											var ck_ = cj_.low;
											var cl_ = context.Operators.ConvertDateToDateTime(ck_);
											var cn_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var cp_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var cr_ = cd_.ValueElement;
											var cs_ = FHIRHelpers_4_0_001.ToDecimal(cr_);
											var ct_ = context.Operators.Add(cp_, new CqlQuantity(cs_, "day"));
											var cv_ = context.Operators.Subtract(ct_, ch_);
											var cw_ = context.Operators.Interval(cn_, cv_, true, true);
											var cx_ = cw_.high;
											var cy_ = context.Operators.ConvertDateToDateTime(cx_);
											var da_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var dc_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var de_ = cd_.ValueElement;
											var df_ = FHIRHelpers_4_0_001.ToDecimal(de_);
											var dg_ = context.Operators.Add(dc_, new CqlQuantity(df_, "day"));
											var di_ = context.Operators.Subtract(dg_, ch_);
											var dj_ = context.Operators.Interval(da_, di_, true, true);
											var dk_ = dj_.lowClosed;
											var dm_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var do_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var dq_ = cd_.ValueElement;
											var dr_ = FHIRHelpers_4_0_001.ToDecimal(dq_);
											var ds_ = context.Operators.Add(do_, new CqlQuantity(dr_, "day"));
											var du_ = context.Operators.Subtract(ds_, ch_);
											var dv_ = context.Operators.Interval(dm_, du_, true, true);
											var dw_ = dv_.highClosed;
											var dx_ = context.Operators.Interval(cl_, cy_, dk_, dw_);

											return dx_;
										}
									};

									return bi_();
								}
								else
								{
									return (null as CqlInterval<CqlDateTime>);
								}
							};
							var be_ = (bd_(), default(nint));

							return be_;
						};
						var ao_ = context.Operators.Select<Claim.ItemComponent, (CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?>(am_, an_);
						var ap_ = (ao_, default(nint));
						var aq_ = new (IEnumerable<(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?> CoveredDays, nint _)?[]
						{
							ap_,
						};
						(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? ar_((IEnumerable<(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?> CoveredDays, nint _)? ItemCalculation)
						{
							(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? dy_()
							{
								bool dz_()
								{
									var ea_ = LineItemDefinition?.LineItems;
									var eb_ = context.Operators.Exists<Claim.ItemComponent>(ea_);

									return (eb_ ?? false);
								};
								if (dz_())
								{
									var ec_ = LineItemDefinition?.Claim;
									var ed_ = LineItemDefinition?.LineItems;
									bool? ef_(Claim.ItemComponent @this)
									{
										var ep_ = @this.Serviced;
										var eq_ = context.Operators.Not((bool?)(ep_ is null));

										return eq_;
									};
									var eg_ = context.Operators.Where<Claim.ItemComponent>(ed_, ef_);
									DataType eh_(Claim.ItemComponent @this)
									{
										var er_ = @this.Serviced;

										return er_;
									};
									var ei_ = context.Operators.Select<Claim.ItemComponent, DataType>(eg_, eh_);
									CqlInterval<CqlDateTime> ej_(object NormalDate)
									{
										var es_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

										return es_;
									};
									var ek_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>((IEnumerable<object>)ei_, ej_);
									var el_ = ItemCalculation?.CoveredDays;
									CqlInterval<CqlDateTime> em_((CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)? d)
									{
										var et_ = d?.DaysSupplyInterval;

										return et_;
									};
									var en_ = context.Operators.Select<(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?, CqlInterval<CqlDateTime>>(el_, em_);
									var eo_ = (ec_, ed_, ek_, en_);

									return eo_;
								}
								else
								{
									return (null as (Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?);
								}
							};

							return dy_();
						};
						var as_ = context.Operators.Select<(IEnumerable<(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?> CoveredDays, nint _)?, (Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(((IEnumerable<(IEnumerable<(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?> CoveredDays, nint _)?>)aq_), ar_);
						var at_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(as_);

						return at_;
					};
					var ai_ = context.Operators.Select<Claim, (Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<Claim>)ag_, ah_);
					var aj_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(ai_);

					return aj_;
				};
				var u_ = context.Operators.Select<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(((IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)s_), t_);
				var v_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(u_);

				return v_;
			};
			var l_ = context.Operators.Select<Claim, (Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(j_, k_);
			bool? m_((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? FinalList)
			{
				var eu_ = context.Operators.Not((bool?)(FinalList is null));

				return eu_;
			};
			var n_ = context.Operators.Where<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(l_, m_);

			return n_;
		};
		var g_ = context.Operators.Select<(IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?, IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>(((IEnumerable<(IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?>)e_), f_);
		var h_ = context.Operators.SingletonFrom<IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis and Procedure")]
	public IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var k_ = d.code;

			return k_;
		};
		var c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p)
		{
			var l_ = p.code;

			return l_;
		};
		var e_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, d_);
		var f_ = (a_, c_, e_);
		var g_ = new (IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[]
		{
			f_,
		};
		IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_((IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithDiagnosis)
		{
			IEnumerable<Claim> m_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					return (null as IEnumerable<Claim>);
				}
				else
				{
					var s_ = ClaimWithDiagnosis?.MedicalClaim;
					bool? t_(Claim DiagnosisLine)
					{
						var v_ = DiagnosisLine.Diagnosis;
						bool? w_(Claim.DiagnosisComponent @this)
						{
							var ai_ = @this.Diagnosis;
							var aj_ = context.Operators.Not((bool?)(ai_ is null));

							return aj_;
						};
						var x_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)v_, w_);
						DataType y_(Claim.DiagnosisComponent @this)
						{
							var ak_ = @this.Diagnosis;

							return ak_;
						};
						var z_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(x_, y_);
						bool? aa_(object @this)
						{
							var al_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							var am_ = context.Operators.Not((bool?)(al_ is null));

							return am_;
						};
						var ab_ = context.Operators.Where<object>((IEnumerable<object>)z_, aa_);
						object ac_(object @this)
						{
							var an_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return an_;
						};
						var ad_ = context.Operators.Select<object, object>(ab_, ac_);
						var ae_ = context.Operators.FlattenLateBoundList(ad_);
						bool? af_(object HeaderCode)
						{
							var ao_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
							var ap_ = ao_.Value;
							var aq_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
							var ar_ = context.Operators.In<string>(ap_, aq_);

							return ar_;
						};
						var ag_ = context.Operators.Where<object>(ae_, af_);
						var ah_ = context.Operators.Exists<object>(ag_);

						return ah_;
					};
					var u_ = context.Operators.Where<Claim>(s_, t_);

					return u_;
				}
			};
			var n_ = (m_(), default(nint));
			var o_ = new (IEnumerable<Claim> DiagnosisItems, nint _)?[]
			{
				n_,
			};
			IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> p_((IEnumerable<Claim> DiagnosisItems, nint _)? ClaimWithProcedure)
			{
				var as_ = ClaimWithProcedure?.DiagnosisItems;
				(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? at_(Claim ClaimofInterest)
				{
					Claim ax_()
					{
						if ((ClaimofInterest is null))
						{
							return null;
						}
						else
						{
							var bd_ = new Claim[]
							{
								ClaimofInterest,
							};
							bool? be_(Claim ItemOnLine)
							{
								var bh_ = ItemOnLine.Procedure;
								bool? bi_(Claim.ProcedureComponent @this)
								{
									var ci_ = @this.Procedure;
									var cj_ = context.Operators.Not((bool?)(ci_ is null));

									return cj_;
								};
								var bj_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)bh_, bi_);
								DataType bk_(Claim.ProcedureComponent @this)
								{
									var ck_ = @this.Procedure;

									return ck_;
								};
								var bl_ = context.Operators.Select<Claim.ProcedureComponent, DataType>(bj_, bk_);
								bool? bm_(object @this)
								{
									var cl_ = context.Operators.LateBoundProperty<object>(@this, "coding");
									var cm_ = context.Operators.Not((bool?)(cl_ is null));

									return cm_;
								};
								var bn_ = context.Operators.Where<object>((IEnumerable<object>)bl_, bm_);
								object bo_(object @this)
								{
									var cn_ = context.Operators.LateBoundProperty<object>(@this, "coding");

									return cn_;
								};
								var bp_ = context.Operators.Select<object, object>(bn_, bo_);
								var bq_ = context.Operators.FlattenLateBoundList(bp_);
								bool? br_(object ProcedureHeaderCode)
								{
									var co_ = context.Operators.LateBoundProperty<Code>(ProcedureHeaderCode, "code");
									var cp_ = co_.Value;
									var cq_ = ClaimWithDiagnosis?.ProceduresAsStrings;
									var cr_ = context.Operators.In<string>(cp_, cq_);

									return cr_;
								};
								var bs_ = context.Operators.Where<object>(bq_, br_);
								var bt_ = context.Operators.Exists<object>(bs_);
								var bu_ = ItemOnLine.Item;
								bool? bv_(Claim.ItemComponent @this)
								{
									var cs_ = @this.ProductOrService;
									var ct_ = context.Operators.Not((bool?)(cs_ is null));

									return ct_;
								};
								var bw_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bu_, bv_);
								CodeableConcept bx_(Claim.ItemComponent @this)
								{
									var cu_ = @this.ProductOrService;

									return cu_;
								};
								var by_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(bw_, bx_);
								bool? bz_(CodeableConcept @this)
								{
									var cv_ = @this.Coding;
									var cw_ = context.Operators.Not((bool?)(cv_ is null));

									return cw_;
								};
								var ca_ = context.Operators.Where<CodeableConcept>(by_, bz_);
								List<Coding> cb_(CodeableConcept @this)
								{
									var cx_ = @this.Coding;

									return cx_;
								};
								var cc_ = context.Operators.Select<CodeableConcept, List<Coding>>(ca_, cb_);
								var cd_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)cc_);
								bool? ce_(Coding LineCode)
								{
									var cy_ = LineCode.CodeElement;
									var cz_ = cy_.Value;
									var da_ = ClaimWithDiagnosis?.ProceduresAsStrings;
									var db_ = context.Operators.In<string>(cz_, da_);

									return db_;
								};
								var cf_ = context.Operators.Where<Coding>(cd_, ce_);
								var cg_ = context.Operators.Exists<Coding>(cf_);
								var ch_ = context.Operators.Or(bt_, cg_);

								return ch_;
							};
							var bf_ = context.Operators.Where<Claim>((IEnumerable<Claim>)bd_, be_);
							var bg_ = context.Operators.SingletonFrom<Claim>(bf_);

							return bg_;
						}
					};
					var ay_ = (ax_(), default(nint));
					var az_ = new (Claim ProcedureItems, nint _)?[]
					{
						ay_,
					};
					(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ba_((Claim ProcedureItems, nint _)? HeaderDefinition)
					{
						(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dc_()
						{
							bool dd_()
							{
								var de_ = HeaderDefinition?.ProcedureItems;
								var df_ = context.Operators.Not((bool?)(de_ is null));

								return (df_ ?? false);
							};
							if (dd_())
							{
								var dg_ = HeaderDefinition?.ProcedureItems;
								var di_ = dg_.Item;
								CqlInterval<CqlDateTime> dj_(Claim.ItemComponent NormalDate)
								{
									var dm_ = NormalDate.Serviced;
									var dn_ = NCQAFHIRBase_1_0_0.Normalize_Interval(dm_);

									return dn_;
								};
								var dk_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)di_, dj_);
								var dl_ = (dg_, dk_);

								return dl_;
							}
							else
							{
								return (null as (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?);
							}
						};

						return dc_();
					};
					var bb_ = context.Operators.Select<(Claim ProcedureItems, nint _)?, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(Claim ProcedureItems, nint _)?>)az_), ba_);
					var bc_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bb_);

					return bc_;
				};
				var au_ = context.Operators.Select<Claim, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(as_, at_);
				bool? av_((Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
				{
					var do_ = context.Operators.Not((bool?)(FinalList is null));

					return do_;
				};
				var aw_ = context.Operators.Where<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(au_, av_);

				return aw_;
			};
			var q_ = context.Operators.Select<(IEnumerable<Claim> DiagnosisItems, nint _)?, IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(((IEnumerable<(IEnumerable<Claim> DiagnosisItems, nint _)?>)o_), p_);
			var r_ = context.Operators.SingletonFrom<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(q_);

			return r_;
		};
		var i_ = context.Operators.Select<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(((IEnumerable<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)g_), h_);
		var j_ = context.Operators.SingletonFrom<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis and Procedure")]
	public IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var k_ = d.code;

			return k_;
		};
		var c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p)
		{
			var l_ = p.code;

			return l_;
		};
		var e_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, d_);
		var f_ = (a_, c_, e_);
		var g_ = new (IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[]
		{
			f_,
		};
		IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_((IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithProcedure)
		{
			var m_ = ClaimWithProcedure?.MedicalClaim;
			(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? n_(Claim ClaimofInterest)
			{
				Claim r_()
				{
					if ((ClaimofInterest is null))
					{
						return null;
					}
					else
					{
						var x_ = new Claim[]
						{
							ClaimofInterest,
						};
						bool? y_(Claim ItemOnLine)
						{
							var ab_ = ItemOnLine.Item;
							bool? ac_(Claim.ItemComponent @this)
							{
								var bc_ = @this.ProductOrService;
								var bd_ = context.Operators.Not((bool?)(bc_ is null));

								return bd_;
							};
							var ad_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ab_, ac_);
							CodeableConcept ae_(Claim.ItemComponent @this)
							{
								var be_ = @this.ProductOrService;

								return be_;
							};
							var af_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(ad_, ae_);
							bool? ag_(CodeableConcept @this)
							{
								var bf_ = @this.Coding;
								var bg_ = context.Operators.Not((bool?)(bf_ is null));

								return bg_;
							};
							var ah_ = context.Operators.Where<CodeableConcept>(af_, ag_);
							List<Coding> ai_(CodeableConcept @this)
							{
								var bh_ = @this.Coding;

								return bh_;
							};
							var aj_ = context.Operators.Select<CodeableConcept, List<Coding>>(ah_, ai_);
							var ak_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)aj_);
							bool? al_(Coding LineCode)
							{
								var bi_ = LineCode.CodeElement;
								var bj_ = bi_.Value;
								var bk_ = ClaimWithProcedure?.ProceduresAsStrings;
								var bl_ = context.Operators.In<string>(bj_, bk_);

								return bl_;
							};
							var am_ = context.Operators.Where<Coding>(ak_, al_);
							var an_ = context.Operators.Exists<Coding>(am_);
							var ao_ = ItemOnLine.Procedure;
							bool? ap_(Claim.ProcedureComponent @this)
							{
								var bm_ = @this.Procedure;
								var bn_ = context.Operators.Not((bool?)(bm_ is null));

								return bn_;
							};
							var aq_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)ao_, ap_);
							DataType ar_(Claim.ProcedureComponent @this)
							{
								var bo_ = @this.Procedure;

								return bo_;
							};
							var as_ = context.Operators.Select<Claim.ProcedureComponent, DataType>(aq_, ar_);
							bool? at_(object @this)
							{
								var bp_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								var bq_ = context.Operators.Not((bool?)(bp_ is null));

								return bq_;
							};
							var au_ = context.Operators.Where<object>((IEnumerable<object>)as_, at_);
							object av_(object @this)
							{
								var br_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return br_;
							};
							var aw_ = context.Operators.Select<object, object>(au_, av_);
							var ax_ = context.Operators.FlattenLateBoundList(aw_);
							bool? ay_(object HeaderCode)
							{
								var bs_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
								var bt_ = bs_.Value;
								var bu_ = ClaimWithProcedure?.ProceduresAsStrings;
								var bv_ = context.Operators.In<string>(bt_, bu_);

								return bv_;
							};
							var az_ = context.Operators.Where<object>(ax_, ay_);
							var ba_ = context.Operators.Exists<object>(az_);
							var bb_ = context.Operators.Or(an_, ba_);

							return bb_;
						};
						var z_ = context.Operators.Where<Claim>((IEnumerable<Claim>)x_, y_);
						var aa_ = context.Operators.SingletonFrom<Claim>(z_);

						return aa_;
					}
				};
				var s_ = (ClaimofInterest, r_());
				var t_ = new (Claim Claim, Claim ProcedureItems)?[]
				{
					s_,
				};
				(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? u_((Claim Claim, Claim ProcedureItems)? DiagnosisCheck)
				{
					var bw_ = DiagnosisCheck?.ProcedureItems;
					var bx_ = new Claim[]
					{
						bw_,
					};
					(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? by_(Claim ClaimforDiagnosis)
					{
						var cb_ = ClaimforDiagnosis.Item;
						Claim cc_()
						{
							if ((ClaimforDiagnosis is null))
							{
								return null;
							}
							else
							{
								var ci_ = new Claim[]
								{
									ClaimforDiagnosis,
								};
								bool? cj_(Claim RightClaim)
								{
									var cm_ = RightClaim.Diagnosis;
									bool? cn_(Claim.DiagnosisComponent RightDiagnosis)
									{
										var cq_ = RightDiagnosis.SequenceElement;
										var cr_ = context.Operators.Convert<Integer>(cq_);
										var cs_ = FHIRHelpers_4_0_001.ToInteger(cr_);
										var ct_ = context.Operators.Equal(cs_, 1);
										var cu_ = RightDiagnosis.Diagnosis;
										var cv_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(cu_, "coding");
										bool? cw_(Coding DiagnosisCode)
										{
											var da_ = DiagnosisCode.CodeElement;
											var db_ = da_.Value;
											var dc_ = ClaimWithProcedure?.DiagnosesAsStrings;
											var dd_ = context.Operators.In<string>(db_, dc_);

											return dd_;
										};
										var cx_ = context.Operators.Where<Coding>(cv_, cw_);
										var cy_ = context.Operators.Exists<Coding>(cx_);
										var cz_ = context.Operators.And(ct_, cy_);

										return cz_;
									};
									var co_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)cm_, cn_);
									var cp_ = context.Operators.Exists<Claim.DiagnosisComponent>(co_);

									return cp_;
								};
								var ck_ = context.Operators.Where<Claim>((IEnumerable<Claim>)ci_, cj_);
								var cl_ = context.Operators.SingletonFrom<Claim>(ck_);

								return cl_;
							}
						};
						var cd_ = ((IEnumerable<Claim.ItemComponent>)cb_, cc_());
						var ce_ = new (IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?[]
						{
							cd_,
						};
						(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cf_((IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? LineItemDefinition)
						{
							(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? de_()
							{
								bool df_()
								{
									var dg_ = context.Operators.Not((bool?)(LineItemDefinition is null));
									var dh_ = LineItemDefinition?.LineItems;
									var di_ = context.Operators.Not((bool?)(dh_ is null));
									var dj_ = context.Operators.And(dg_, di_);

									return (dj_ ?? false);
								};
								if (df_())
								{
									var dk_ = LineItemDefinition?.LineItems;
									var dm_ = dk_.Item;
									CqlInterval<CqlDateTime> dn_(Claim.ItemComponent NormalDate)
									{
										var dq_ = NormalDate.Serviced;
										var dr_ = NCQAFHIRBase_1_0_0.Normalize_Interval(dq_);

										return dr_;
									};
									var do_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)dm_, dn_);
									var dp_ = (dk_, do_);

									return dp_;
								}
								else
								{
									return (null as (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?);
								}
							};

							return de_();
						};
						var cg_ = context.Operators.Select<(IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?>)ce_), cf_);
						var ch_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(cg_);

						return ch_;
					};
					var bz_ = context.Operators.Select<Claim, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<Claim>)bx_, by_);
					var ca_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bz_);

					return ca_;
				};
				var v_ = context.Operators.Select<(Claim Claim, Claim ProcedureItems)?, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(Claim Claim, Claim ProcedureItems)?>)t_), u_);
				var w_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(v_);

				return w_;
			};
			var o_ = context.Operators.Select<Claim, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(m_, n_);
			bool? p_((Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
			{
				var ds_ = context.Operators.Not((bool?)(FinalList is null));

				return ds_;
			};
			var q_ = context.Operators.Where<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(o_, p_);

			return q_;
		};
		var i_ = context.Operators.Select<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(((IEnumerable<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)g_), h_);
		var j_ = context.Operators.SingletonFrom<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis")]
	public IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var i_ = d.code;

			return i_;
		};
		var c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		var d_ = (a_, c_);
		var e_ = new (IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[]
		{
			d_,
		};
		IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_((IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
		{
			IEnumerable<Claim> j_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					return (null as IEnumerable<Claim>);
				}
				else
				{
					var p_ = ClaimWithDiagnosis?.MedicalClaim;
					bool? q_(Claim RightClaim)
					{
						var s_ = RightClaim.Diagnosis;
						bool? t_(Claim.DiagnosisComponent RightDiagnosis)
						{
							var w_ = RightDiagnosis.SequenceElement;
							var x_ = context.Operators.Convert<Integer>(w_);
							var y_ = FHIRHelpers_4_0_001.ToInteger(x_);
							var z_ = context.Operators.Equal(y_, 1);
							var aa_ = RightDiagnosis.Diagnosis;
							var ab_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(aa_, "coding");
							bool? ac_(Coding DiagnosisCode)
							{
								var ag_ = DiagnosisCode.CodeElement;
								var ah_ = ag_.Value;
								var ai_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
								var aj_ = context.Operators.In<string>(ah_, ai_);

								return aj_;
							};
							var ad_ = context.Operators.Where<Coding>(ab_, ac_);
							var ae_ = context.Operators.Exists<Coding>(ad_);
							var af_ = context.Operators.And(z_, ae_);

							return af_;
						};
						var u_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)s_, t_);
						var v_ = context.Operators.Exists<Claim.DiagnosisComponent>(u_);

						return v_;
					};
					var r_ = context.Operators.Where<Claim>(p_, q_);

					return r_;
				}
			};
			var k_ = (j_(), default(nint));
			var l_ = new (IEnumerable<Claim> LineItems, nint _)?[]
			{
				k_,
			};
			IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> m_((IEnumerable<Claim> LineItems, nint _)? LineItemDefinition)
			{
				var ak_ = LineItemDefinition?.LineItems;
				(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? al_(Claim ClaimWithDiagnosis)
				{
					(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ap_()
					{
						if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null)) ?? false))
						{
							var aq_ = LineItemDefinition?.LineItems;
							bool? as_(Claim @this)
							{
								var ba_ = @this.Item;
								var bb_ = context.Operators.Not((bool?)(ba_ is null));

								return bb_;
							};
							var at_ = context.Operators.Where<Claim>(aq_, as_);
							List<Claim.ItemComponent> au_(Claim @this)
							{
								var bc_ = @this.Item;

								return bc_;
							};
							var av_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(at_, au_);
							var aw_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)av_);
							CqlInterval<CqlDateTime> ax_(Claim.ItemComponent NormalDate)
							{
								var bd_ = NormalDate.Serviced;
								var be_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bd_);

								return be_;
							};
							var ay_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(aw_, ax_);
							var az_ = (aq_, ay_);

							return az_;
						}
						else
						{
							return (null as (IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?);
						}
					};

					return ap_();
				};
				var am_ = context.Operators.Select<Claim, (IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ak_, al_);
				bool? an_((IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
				{
					var bf_ = context.Operators.Not((bool?)(FinalList is null));

					return bf_;
				};
				var ao_ = context.Operators.Where<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(am_, an_);

				return ao_;
			};
			var n_ = context.Operators.Select<(IEnumerable<Claim> LineItems, nint _)?, IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(((IEnumerable<(IEnumerable<Claim> LineItems, nint _)?>)l_), m_);
			var o_ = context.Operators.SingletonFrom<IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(n_);

			return o_;
		};
		var g_ = context.Operators.Select<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(((IEnumerable<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)e_), f_);
		var h_ = context.Operators.SingletonFrom<IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(g_);

		return h_;
	}

    [CqlDeclaration("Get All Professional and Institutional Claims and Claim Responses")]
	public (IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		var a_ = this.Professional_or_Institutional_Claims_Response(claimResponse);
		var b_ = this.Professional_or_Institutional_Claims(claim);
		var c_ = (a_, b_);

		return c_;
	}

    [CqlDeclaration("Get All Paid Claim Reponses")]
	public IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> Get_All_Paid_Claim_Reponses(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse ResponseItem)
		{
			var h_ = ResponseItem.OutcomeElement;
			var i_ = FHIRHelpers_4_0_001.ToString(h_);
			var j_ = new string[]
			{
				"complete",
				"partial",
			};
			var k_ = context.Operators.In<string>(i_, (j_ as IEnumerable<string>));

			return k_;
		};
		var b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);
		var c_ = (b_, default(nint));
		var d_ = new (IEnumerable<ClaimResponse> PaidResponse, nint _)?[]
		{
			c_,
		};
		IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> e_((IEnumerable<ClaimResponse> PaidResponse, nint _)? ClaimResponse)
		{
			var l_ = ClaimResponse?.PaidResponse;
			(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? m_(ClaimResponse ClmResp)
			{
				var o_ = ClmResp.Request;
				var p_ = o_.ReferenceElement;
				var q_ = FHIRHelpers_4_0_001.ToString(p_);
				var r_ = NCQAFHIRBase_1_0_0.GetId(q_);
				var s_ = ClmResp.Item;
				bool? t_(ClaimResponse.ItemComponent ResponseItem)
				{
					var w_ = ResponseItem.Adjudication;
					bool? x_(ClaimResponse.AdjudicationComponent @this)
					{
						var as_ = @this.Category;
						var at_ = context.Operators.Not((bool?)(as_ is null));

						return at_;
					};
					var y_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)w_, x_);
					CodeableConcept z_(ClaimResponse.AdjudicationComponent @this)
					{
						var au_ = @this.Category;

						return au_;
					};
					var aa_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, CodeableConcept>(y_, z_);
					bool? ab_(CodeableConcept @this)
					{
						var av_ = @this.Coding;
						var aw_ = context.Operators.Not((bool?)(av_ is null));

						return aw_;
					};
					var ac_ = context.Operators.Where<CodeableConcept>(aa_, ab_);
					List<Coding> ad_(CodeableConcept @this)
					{
						var ax_ = @this.Coding;

						return ax_;
					};
					var ae_ = context.Operators.Select<CodeableConcept, List<Coding>>(ac_, ad_);
					var af_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ae_);
					bool? ag_(Coding CategoryItem)
					{
						var ay_ = CategoryItem.CodeElement;
						var az_ = ay_.Value;
						var ba_ = context.Operators.Equal(az_, "benefit");

						return ba_;
					};
					var ah_ = context.Operators.Where<Coding>(af_, ag_);
					var ai_ = context.Operators.Exists<Coding>(ah_);
					bool? ak_(ClaimResponse.AdjudicationComponent @this)
					{
						var bb_ = @this.Amount;
						var bc_ = context.Operators.Not((bool?)(bb_ is null));

						return bc_;
					};
					var al_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)w_, ak_);
					Money am_(ClaimResponse.AdjudicationComponent @this)
					{
						var bd_ = @this.Amount;

						return bd_;
					};
					var an_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, Money>(al_, am_);
					bool? ao_(Money DollarAmount)
					{
						var be_ = DollarAmount.ValueElement;
						var bf_ = FHIRHelpers_4_0_001.ToDecimal(be_);
						var bg_ = context.Operators.ConvertIntegerToDecimal(0);
						var bh_ = context.Operators.Greater(bf_, bg_);

						return bh_;
					};
					var ap_ = context.Operators.Where<Money>(an_, ao_);
					var aq_ = context.Operators.Exists<Money>(ap_);
					var ar_ = context.Operators.And(ai_, aq_);

					return ar_;
				};
				var u_ = context.Operators.Where<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)s_, t_);
				var v_ = (ClmResp, r_, u_);

				return v_;
			};
			var n_ = context.Operators.Select<ClaimResponse, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(l_, m_);

			return n_;
		};
		var f_ = context.Operators.Select<(IEnumerable<ClaimResponse> PaidResponse, nint _)?, IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(((IEnumerable<(IEnumerable<ClaimResponse> PaidResponse, nint _)?>)d_), e_);
		var g_ = context.Operators.SingletonFrom<IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(f_);

		return g_;
	}

    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
	public IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_and_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			var e_ = AllClaims.Item;
			bool? f_(Claim.ItemComponent @this)
			{
				var af_ = @this.ProductOrService;
				var ag_ = context.Operators.Not((bool?)(af_ is null));

				return ag_;
			};
			var g_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)e_, f_);
			CodeableConcept h_(Claim.ItemComponent @this)
			{
				var ah_ = @this.ProductOrService;

				return ah_;
			};
			var i_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(g_, h_);
			bool? j_(CodeableConcept @this)
			{
				var ai_ = @this.Coding;
				var aj_ = context.Operators.Not((bool?)(ai_ is null));

				return aj_;
			};
			var k_ = context.Operators.Where<CodeableConcept>(i_, j_);
			List<Coding> l_(CodeableConcept @this)
			{
				var ak_ = @this.Coding;

				return ak_;
			};
			var m_ = context.Operators.Select<CodeableConcept, List<Coding>>(k_, l_);
			var n_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)m_);
			bool? o_(Coding ProductOrServiceCode)
			{
				var al_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var am_ = context.Operators.In<CqlCode>(al_, ProductOrServiceValueSet);

				return am_;
			};
			var p_ = context.Operators.Where<Coding>(n_, o_);
			var q_ = context.Operators.Exists<Coding>(p_);
			var r_ = AllClaims.Diagnosis;
			bool? s_(Claim.DiagnosisComponent @this)
			{
				var an_ = @this.Diagnosis;
				var ao_ = context.Operators.Not((bool?)(an_ is null));

				return ao_;
			};
			var t_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)r_, s_);
			DataType u_(Claim.DiagnosisComponent @this)
			{
				var ap_ = @this.Diagnosis;

				return ap_;
			};
			var v_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(t_, u_);
			bool? w_(object @this)
			{
				var aq_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				var ar_ = context.Operators.Not((bool?)(aq_ is null));

				return ar_;
			};
			var x_ = context.Operators.Where<object>((IEnumerable<object>)v_, w_);
			object y_(object @this)
			{
				var as_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return as_;
			};
			var z_ = context.Operators.Select<object, object>(x_, y_);
			var aa_ = context.Operators.FlattenLateBoundList(z_);
			bool? ab_(object DiagnosisCode)
			{
				var at_ = FHIRHelpers_4_0_001.ToCode((Coding)DiagnosisCode);
				var au_ = context.Operators.In<CqlCode>(at_, DiagnosisValueSet);

				return au_;
			};
			var ac_ = context.Operators.Where<object>(aa_, ab_);
			var ad_ = context.Operators.Exists<object>(ac_);
			var ae_ = context.Operators.And(q_, ad_);

			return ae_;
		};
		var b_ = context.Operators.Where<Claim>(claim, a_);
		(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? c_(Claim ProcedureClaims)
		{
			var av_ = ProcedureClaims.IdElement;
			var aw_ = ProcedureClaims.Item;
			bool? ax_(Claim.ItemComponent ResponseItem)
			{
				var ba_ = ResponseItem.ProductOrService;
				var bb_ = ba_.Coding;
				bool? bc_(Coding ProductOrServiceCode)
				{
					var bf_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var bg_ = context.Operators.In<CqlCode>(bf_, ProductOrServiceValueSet);

					return bg_;
				};
				var bd_ = context.Operators.Where<Coding>((IEnumerable<Coding>)bb_, bc_);
				var be_ = context.Operators.Exists<Coding>(bd_);

				return be_;
			};
			var ay_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)aw_, ax_);
			var az_ = (ProcedureClaims, av_, ay_);

			return az_;
		};
		var d_ = context.Operators.Select<Claim, (Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services and Conditions")]
	public (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_and_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		var c_ = (a_, b_);
		var d_ = new (IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[]
		{
			c_,
		};
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_((IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
		{
			var h_ = ClaimAndResponse?.MedicalClaim;
			((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? i_((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
			{
				var p_ = medClaim?.LineItems;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					var t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> u_((ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
					{
						var x_ = pClaim?.LineItems;
						bool? y_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							Id ac_()
							{
								bool aq_()
								{
									var ar_ = medClaim?.ClaimofInterest;
									var as_ = ar_ is Resource;

									return as_;
								};
								if (aq_())
								{
									var at_ = medClaim?.ClaimofInterest;

									return (at_ as Resource).IdElement;
								}
								else
								{
									return null;
								}
							};
							var ad_ = FHIRHelpers_4_0_001.ToString(ac_());
							var ae_ = pClaim?.Response;
							var af_ = ae_.Request;
							var ag_ = af_.ReferenceElement;
							var ah_ = FHIRHelpers_4_0_001.ToString(ag_);
							var ai_ = NCQAFHIRBase_1_0_0.GetId(ah_);
							var aj_ = context.Operators.Equal(ad_, ai_);
							var ak_ = medClaimLineItem.SequenceElement;
							var al_ = context.Operators.Convert<Integer>(ak_);
							var am_ = pClaimLineItem.ItemSequenceElement;
							var an_ = context.Operators.Convert<Integer>(am_);
							var ao_ = context.Operators.Equal(al_, an_);
							var ap_ = context.Operators.And(aj_, ao_);

							return ap_;
						};
						var z_ = context.Operators.Where<ClaimResponse.ItemComponent>(x_, y_);
						(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var ab_ = context.Operators.Select<ClaimResponse.ItemComponent, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(z_, aa_);

						return ab_;
					};
					var v_ = context.Operators.SelectMany<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
					var w_ = context.Operators.Exists<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(v_);

					return w_;
				};
				var r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
				var s_ = (medClaim, r_);

				return s_;
			};
			var j_ = context.Operators.Select<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, ((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(h_, i_);
			var k_ = (j_, default(nint));
			var l_ = new (IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?[]
			{
				k_,
			};
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_((IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)? ClaimWithPaidResponse)
			{
				(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? au_()
				{
					bool az_()
					{
						var ba_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bb_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var bh_ = @this?.ClaimItem;
							var bi_ = context.Operators.Not((bool?)(bh_ is null));

							return bi_;
						};
						var bc_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ba_, bb_);
						IEnumerable<Claim.ItemComponent> bd_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var bj_ = @this?.ClaimItem;

							return bj_;
						};
						var be_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
						var bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
						var bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);

						return (bg_ ?? false);
					};
					if (az_())
					{
						var bk_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bl_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var by_ = @this?.PaidClaim;
							var bz_ = context.Operators.Not((bool?)(by_ is null));

							return bz_;
						};
						var bm_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bl_);
						(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var ca_ = @this?.PaidClaim;

							return ca_;
						};
						var bo_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bm_, bn_);
						bool? bq_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var cb_ = @this?.ClaimItem;
							var cc_ = context.Operators.Not((bool?)(cb_ is null));

							return cc_;
						};
						var br_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bq_);
						IEnumerable<Claim.ItemComponent> bs_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var cd_ = @this?.ClaimItem;

							return cd_;
						};
						var bt_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(br_, bs_);
						var bu_ = context.Operators.Flatten<Claim.ItemComponent>(bt_);
						CqlInterval<CqlDateTime> bv_(Claim.ItemComponent PaidItem)
						{
							var ce_ = PaidItem.Serviced;
							var cf_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ce_);

							return cf_;
						};
						var bw_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bu_, bv_);
						var bx_ = (bo_, bw_);

						return bx_;
					}
					else
					{
						return (null as (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?);
					}
				};
				var av_ = new (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[]
				{
					au_(),
				};
				bool? aw_((IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
				{
					var cg_ = context.Operators.Not((bool?)(FinalList is null));

					return cg_;
				};
				var ax_ = context.Operators.Where<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)av_), aw_);
				var ay_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ax_);

				return ay_;
			};
			var n_ = context.Operators.Select<(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?>)l_), m_);
			var o_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(n_);

			return o_;
		};
		var f_ = context.Operators.Select<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_), e_);
		var g_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Service and Condition")]
	public (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Service_and_Condition(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new (IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[]
		{
			a_,
		};
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
		{
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? j_()
			{
				bool k_()
				{
					var l_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					var m_ = MedicalClaimAndResponse?.MedicalClaim;
					var n_ = context.Operators.And((bool?)(l_ is null), (bool?)(m_ is null));

					return (n_ ?? false);
				};
				if (k_())
				{
					return (null as (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?);
				}
				else
				{
					var o_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					var p_ = MedicalClaimAndResponse?.MedicalClaim;
					var q_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(o_, p_, ProductOrServiceValueSet, DiagnosisValueSet);

					return q_;
				}
			};

			return j_();
		};
		var d_ = context.Operators.Select<(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_), c_);
		var e_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);
		var f_ = new (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[]
		{
			e_,
		};
		bool? g_((IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
		{
			var r_ = context.Operators.Not((bool?)(FinalList is null));

			return r_;
		};
		var h_ = context.Operators.Where<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)f_), g_);
		var i_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(h_);

		return i_;
	}

    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
	public IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_or_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			var e_ = AllClaims.Item;
			bool? f_(Claim.ItemComponent @this)
			{
				var af_ = @this.ProductOrService;
				var ag_ = context.Operators.Not((bool?)(af_ is null));

				return ag_;
			};
			var g_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)e_, f_);
			CodeableConcept h_(Claim.ItemComponent @this)
			{
				var ah_ = @this.ProductOrService;

				return ah_;
			};
			var i_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(g_, h_);
			bool? j_(CodeableConcept @this)
			{
				var ai_ = @this.Coding;
				var aj_ = context.Operators.Not((bool?)(ai_ is null));

				return aj_;
			};
			var k_ = context.Operators.Where<CodeableConcept>(i_, j_);
			List<Coding> l_(CodeableConcept @this)
			{
				var ak_ = @this.Coding;

				return ak_;
			};
			var m_ = context.Operators.Select<CodeableConcept, List<Coding>>(k_, l_);
			var n_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)m_);
			bool? o_(Coding ProductOrServiceCode)
			{
				var al_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var am_ = context.Operators.In<CqlCode>(al_, ProductOrServiceValueSet);

				return am_;
			};
			var p_ = context.Operators.Where<Coding>(n_, o_);
			var q_ = context.Operators.Exists<Coding>(p_);
			var r_ = AllClaims.Diagnosis;
			bool? s_(Claim.DiagnosisComponent @this)
			{
				var an_ = @this.Diagnosis;
				var ao_ = context.Operators.Not((bool?)(an_ is null));

				return ao_;
			};
			var t_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)r_, s_);
			DataType u_(Claim.DiagnosisComponent @this)
			{
				var ap_ = @this.Diagnosis;

				return ap_;
			};
			var v_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(t_, u_);
			bool? w_(object @this)
			{
				var aq_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				var ar_ = context.Operators.Not((bool?)(aq_ is null));

				return ar_;
			};
			var x_ = context.Operators.Where<object>((IEnumerable<object>)v_, w_);
			object y_(object @this)
			{
				var as_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return as_;
			};
			var z_ = context.Operators.Select<object, object>(x_, y_);
			var aa_ = context.Operators.FlattenLateBoundList(z_);
			bool? ab_(object DiagnosisCode)
			{
				var at_ = FHIRHelpers_4_0_001.ToCode((Coding)DiagnosisCode);
				var au_ = context.Operators.In<CqlCode>(at_, DiagnosisValueSet);

				return au_;
			};
			var ac_ = context.Operators.Where<object>(aa_, ab_);
			var ad_ = context.Operators.Exists<object>(ac_);
			var ae_ = context.Operators.Or(q_, ad_);

			return ae_;
		};
		var b_ = context.Operators.Where<Claim>(claim, a_);
		(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? c_(Claim ProcedureClaims)
		{
			(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? av_()
			{
				bool aw_()
				{
					var ax_ = ProcedureClaims.Item;
					bool? ay_(Claim.ItemComponent ResponseItem)
					{
						var bb_ = ResponseItem.ProductOrService;
						var bc_ = bb_.Coding;
						bool? bd_(Coding ProductOrServiceCode)
						{
							var bg_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
							var bh_ = context.Operators.In<CqlCode>(bg_, ProductOrServiceValueSet);

							return bh_;
						};
						var be_ = context.Operators.Where<Coding>((IEnumerable<Coding>)bc_, bd_);
						var bf_ = context.Operators.Exists<Coding>(be_);

						return bf_;
					};
					var az_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ax_, ay_);
					var ba_ = context.Operators.Exists<Claim.ItemComponent>(az_);

					return (ba_ ?? false);
				};
				if (aw_())
				{
					var bi_ = ProcedureClaims.IdElement;
					var bj_ = ProcedureClaims.Item;
					bool? bk_(Claim.ItemComponent ResponseItem)
					{
						var bn_ = ResponseItem.ProductOrService;
						var bo_ = bn_.Coding;
						bool? bp_(Coding ProductOrServiceCode)
						{
							var bs_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
							var bt_ = context.Operators.In<CqlCode>(bs_, ProductOrServiceValueSet);

							return bt_;
						};
						var bq_ = context.Operators.Where<Coding>((IEnumerable<Coding>)bo_, bp_);
						var br_ = context.Operators.Exists<Coding>(bq_);

						return br_;
					};
					var bl_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bj_, bk_);
					var bm_ = (ProcedureClaims, bi_, bl_);

					return bm_;
				}
				else
				{
					var bu_ = ProcedureClaims.IdElement;
					var bv_ = ProcedureClaims.Item;
					bool? bw_(Claim.ItemComponent ResponseItem)
					{
						var bz_ = ResponseItem.SequenceElement;
						var ca_ = context.Operators.Convert<Integer>(bz_);
						var cb_ = ca_.Value;
						var cc_ = context.Operators.Equal(cb_, 1);

						return cc_;
					};
					var bx_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bv_, bw_);
					var by_ = (ProcedureClaims, bu_, bx_);

					return by_;
				}
			};

			return av_();
		};
		var d_ = context.Operators.Select<Claim, (Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services or Conditions")]
	public (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		var c_ = (a_, b_);
		var d_ = new (IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[]
		{
			c_,
		};
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_((IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
		{
			var h_ = ClaimAndResponse?.MedicalClaim;
			((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? i_((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
			{
				var p_ = medClaim?.LineItems;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					var t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> u_((ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
					{
						var x_ = pClaim?.LineItems;
						bool? y_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							Id ac_()
							{
								bool aq_()
								{
									var ar_ = medClaim?.ClaimofInterest;
									var as_ = ar_ is Resource;

									return as_;
								};
								if (aq_())
								{
									var at_ = medClaim?.ClaimofInterest;

									return (at_ as Resource).IdElement;
								}
								else
								{
									return null;
								}
							};
							var ad_ = FHIRHelpers_4_0_001.ToString(ac_());
							var ae_ = pClaim?.Response;
							var af_ = ae_.Request;
							var ag_ = af_.ReferenceElement;
							var ah_ = FHIRHelpers_4_0_001.ToString(ag_);
							var ai_ = NCQAFHIRBase_1_0_0.GetId(ah_);
							var aj_ = context.Operators.Equal(ad_, ai_);
							var ak_ = medClaimLineItem.SequenceElement;
							var al_ = context.Operators.Convert<Integer>(ak_);
							var am_ = pClaimLineItem.ItemSequenceElement;
							var an_ = context.Operators.Convert<Integer>(am_);
							var ao_ = context.Operators.Equal(al_, an_);
							var ap_ = context.Operators.And(aj_, ao_);

							return ap_;
						};
						var z_ = context.Operators.Where<ClaimResponse.ItemComponent>(x_, y_);
						(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var ab_ = context.Operators.Select<ClaimResponse.ItemComponent, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(z_, aa_);

						return ab_;
					};
					var v_ = context.Operators.SelectMany<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
					var w_ = context.Operators.Exists<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(v_);

					return w_;
				};
				var r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
				var s_ = (medClaim, r_);

				return s_;
			};
			var j_ = context.Operators.Select<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, ((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(h_, i_);
			var k_ = (j_, default(nint));
			var l_ = new (IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?[]
			{
				k_,
			};
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_((IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)? ClaimWithPaidResponse)
			{
				(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? au_()
				{
					bool az_()
					{
						var ba_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bb_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var bh_ = @this?.ClaimItem;
							var bi_ = context.Operators.Not((bool?)(bh_ is null));

							return bi_;
						};
						var bc_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ba_, bb_);
						IEnumerable<Claim.ItemComponent> bd_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var bj_ = @this?.ClaimItem;

							return bj_;
						};
						var be_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
						var bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
						var bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);

						return (bg_ ?? false);
					};
					if (az_())
					{
						var bk_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bl_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var by_ = @this?.PaidClaim;
							var bz_ = context.Operators.Not((bool?)(by_ is null));

							return bz_;
						};
						var bm_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bl_);
						(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var ca_ = @this?.PaidClaim;

							return ca_;
						};
						var bo_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bm_, bn_);
						bool? bq_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var cb_ = @this?.ClaimItem;
							var cc_ = context.Operators.Not((bool?)(cb_ is null));

							return cc_;
						};
						var br_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bq_);
						IEnumerable<Claim.ItemComponent> bs_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var cd_ = @this?.ClaimItem;

							return cd_;
						};
						var bt_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(br_, bs_);
						var bu_ = context.Operators.Flatten<Claim.ItemComponent>(bt_);
						CqlInterval<CqlDateTime> bv_(Claim.ItemComponent PaidItem)
						{
							var ce_ = PaidItem.Serviced;
							var cf_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ce_);

							return cf_;
						};
						var bw_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bu_, bv_);
						var bx_ = (bo_, bw_);

						return bx_;
					}
					else
					{
						return (null as (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?);
					}
				};
				var av_ = new (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[]
				{
					au_(),
				};
				bool? aw_((IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
				{
					var cg_ = context.Operators.Not((bool?)(FinalList is null));

					return cg_;
				};
				var ax_ = context.Operators.Where<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)av_), aw_);
				var ay_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ax_);

				return ay_;
			};
			var n_ = context.Operators.Select<(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?>)l_), m_);
			var o_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(n_);

			return o_;
		};
		var f_ = context.Operators.Select<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_), e_);
		var g_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services or Conditions")]
	public (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new (IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[]
		{
			a_,
		};
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
		{
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_()
			{
				bool g_()
				{
					var h_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					var i_ = MedicalClaimAndResponse?.MedicalClaim;
					var j_ = context.Operators.And((bool?)(h_ is null), (bool?)(i_ is null));

					return (j_ ?? false);
				};
				if (g_())
				{
					return (null as (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?);
				}
				else
				{
					var k_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					var l_ = MedicalClaimAndResponse?.MedicalClaim;
					var m_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(k_, l_, ProductOrServiceValueSet, DiagnosisValueSet);

					return m_;
				}
			};

			return f_();
		};
		var d_ = context.Operators.Select<(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_), c_);
		var e_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);

		return e_;
	}

    [CqlDeclaration("Get All Claims With Procedure Only")]
	public IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_Only(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			var e_ = AllClaims.Item;
			bool? f_(Claim.ItemComponent @this)
			{
				var r_ = @this.ProductOrService;
				var s_ = context.Operators.Not((bool?)(r_ is null));

				return s_;
			};
			var g_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)e_, f_);
			CodeableConcept h_(Claim.ItemComponent @this)
			{
				var t_ = @this.ProductOrService;

				return t_;
			};
			var i_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(g_, h_);
			bool? j_(CodeableConcept @this)
			{
				var u_ = @this.Coding;
				var v_ = context.Operators.Not((bool?)(u_ is null));

				return v_;
			};
			var k_ = context.Operators.Where<CodeableConcept>(i_, j_);
			List<Coding> l_(CodeableConcept @this)
			{
				var w_ = @this.Coding;

				return w_;
			};
			var m_ = context.Operators.Select<CodeableConcept, List<Coding>>(k_, l_);
			var n_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)m_);
			bool? o_(Coding ProductOrServiceCode)
			{
				var x_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var y_ = context.Operators.In<CqlCode>(x_, ProductOrServiceValueSet);

				return y_;
			};
			var p_ = context.Operators.Where<Coding>(n_, o_);
			var q_ = context.Operators.Exists<Coding>(p_);

			return q_;
		};
		var b_ = context.Operators.Where<Claim>(claim, a_);
		(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? c_(Claim AllClaims)
		{
			var z_ = AllClaims.IdElement;
			var aa_ = AllClaims.Item;
			bool? ab_(Claim.ItemComponent ResponseItem)
			{
				var ae_ = ResponseItem.ProductOrService;
				var af_ = ae_.Coding;
				bool? ag_(Coding ProductOrServiceCode)
				{
					var aj_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var ak_ = context.Operators.In<CqlCode>(aj_, ProductOrServiceValueSet);

					return ak_;
				};
				var ah_ = context.Operators.Where<Coding>((IEnumerable<Coding>)af_, ag_);
				var ai_ = context.Operators.Exists<Coding>(ah_);

				return ai_;
			};
			var ac_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)aa_, ab_);
			var ad_ = (AllClaims, z_, ac_);

			return ad_;
		};
		var d_ = context.Operators.Select<Claim, (Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services Only")]
	public (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_Only(claim, ProductOrServiceValueSet);
		var c_ = (a_, b_);
		var d_ = new (IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[]
		{
			c_,
		};
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_((IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
		{
			var h_ = ClaimAndResponse?.MedicalClaim;
			((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? i_((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
			{
				var p_ = medClaim?.LineItems;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					var t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> u_((ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
					{
						var x_ = pClaim?.LineItems;
						bool? y_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							Id ac_()
							{
								bool aq_()
								{
									var ar_ = medClaim?.ClaimofInterest;
									var as_ = ar_ is Resource;

									return as_;
								};
								if (aq_())
								{
									var at_ = medClaim?.ClaimofInterest;

									return (at_ as Resource).IdElement;
								}
								else
								{
									return null;
								}
							};
							var ad_ = FHIRHelpers_4_0_001.ToString(ac_());
							var ae_ = pClaim?.Response;
							var af_ = ae_.Request;
							var ag_ = af_.ReferenceElement;
							var ah_ = FHIRHelpers_4_0_001.ToString(ag_);
							var ai_ = NCQAFHIRBase_1_0_0.GetId(ah_);
							var aj_ = context.Operators.Equal(ad_, ai_);
							var ak_ = medClaimLineItem.SequenceElement;
							var al_ = context.Operators.Convert<Integer>(ak_);
							var am_ = pClaimLineItem.ItemSequenceElement;
							var an_ = context.Operators.Convert<Integer>(am_);
							var ao_ = context.Operators.Equal(al_, an_);
							var ap_ = context.Operators.And(aj_, ao_);

							return ap_;
						};
						var z_ = context.Operators.Where<ClaimResponse.ItemComponent>(x_, y_);
						(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var ab_ = context.Operators.Select<ClaimResponse.ItemComponent, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(z_, aa_);

						return ab_;
					};
					var v_ = context.Operators.SelectMany<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
					var w_ = context.Operators.Exists<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(v_);

					return w_;
				};
				var r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
				var s_ = (medClaim, r_);

				return s_;
			};
			var j_ = context.Operators.Select<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, ((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(h_, i_);
			var k_ = (j_, default(nint));
			var l_ = new (IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?[]
			{
				k_,
			};
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_((IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)? ClaimWithPaidResponse)
			{
				(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? au_()
				{
					bool az_()
					{
						var ba_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bb_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var bh_ = @this?.ClaimItem;
							var bi_ = context.Operators.Not((bool?)(bh_ is null));

							return bi_;
						};
						var bc_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ba_, bb_);
						IEnumerable<Claim.ItemComponent> bd_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var bj_ = @this?.ClaimItem;

							return bj_;
						};
						var be_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
						var bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
						var bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);

						return (bg_ ?? false);
					};
					if (az_())
					{
						var bk_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bl_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var by_ = @this?.PaidClaim;
							var bz_ = context.Operators.Not((bool?)(by_ is null));

							return bz_;
						};
						var bm_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bl_);
						(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var ca_ = @this?.PaidClaim;

							return ca_;
						};
						var bo_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bm_, bn_);
						bool? bq_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var cb_ = @this?.ClaimItem;
							var cc_ = context.Operators.Not((bool?)(cb_ is null));

							return cc_;
						};
						var br_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bq_);
						IEnumerable<Claim.ItemComponent> bs_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var cd_ = @this?.ClaimItem;

							return cd_;
						};
						var bt_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(br_, bs_);
						var bu_ = context.Operators.Flatten<Claim.ItemComponent>(bt_);
						CqlInterval<CqlDateTime> bv_(Claim.ItemComponent PaidItem)
						{
							var ce_ = PaidItem.Serviced;
							var cf_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ce_);

							return cf_;
						};
						var bw_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bu_, bv_);
						var bx_ = (bo_, bw_);

						return bx_;
					}
					else
					{
						return (null as (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?);
					}
				};
				var av_ = new (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[]
				{
					au_(),
				};
				bool? aw_((IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
				{
					var cg_ = context.Operators.Not((bool?)(FinalList is null));

					return cg_;
				};
				var ax_ = context.Operators.Where<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)av_), aw_);
				var ay_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ax_);

				return ay_;
			};
			var n_ = context.Operators.Select<(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?>)l_), m_);
			var o_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(n_);

			return o_;
		};
		var f_ = context.Operators.Select<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_), e_);
		var g_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services Only")]
	public (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new (IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[]
		{
			a_,
		};
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
		{
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_()
			{
				bool g_()
				{
					var h_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					var i_ = MedicalClaimAndResponse?.MedicalClaim;
					var j_ = context.Operators.And((bool?)(h_ is null), (bool?)(i_ is null));

					return (j_ ?? false);
				};
				if (g_())
				{
					return (null as (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?);
				}
				else
				{
					var k_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					var l_ = MedicalClaimAndResponse?.MedicalClaim;
					var m_ = this.Get_Corresponding_Claim_for_Services_Only(k_, l_, ProductOrServiceValueSet);

					return m_;
				}
			};

			return f_();
		};
		var d_ = context.Operators.Select<(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(((IEnumerable<(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_), c_);
		var e_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);

		return e_;
	}

    [CqlDeclaration("Get All Pharmacy Claims and Claim Responses")]
	public (IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? Get_All_Pharmacy_Claims_and_Claim_Responses(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		var a_ = this.Pharmacy_Claims_Response(claimResponse);
		var b_ = this.Pharmacy_Claims(claim);
		var c_ = (a_, b_);

		return c_;
	}

    [CqlDeclaration("Get Corresponding Claim for Pharmacy Services")]
	public (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Corresponding_Claim_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Pharmacy_Claim_With_Medication(claim, ProductOrServiceValueSet);
		var c_ = (a_, b_);
		var d_ = new (IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?[]
		{
			c_,
		};
		(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? e_((IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? ClaimAndResponse)
		{
			var h_ = ClaimAndResponse?.MedicalClaim;
			((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? i_((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? medClaim)
			{
				var p_ = medClaim?.LineItem;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					var t_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> u_((ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
					{
						var x_ = pClaim?.LineItems;
						bool? y_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							Id ac_()
							{
								bool aq_()
								{
									var ar_ = medClaim?.Claim;
									var as_ = ar_ is Resource;

									return as_;
								};
								if (aq_())
								{
									var at_ = medClaim?.Claim;

									return (at_ as Resource).IdElement;
								}
								else
								{
									return null;
								}
							};
							var ad_ = FHIRHelpers_4_0_001.ToString(ac_());
							var ae_ = pClaim?.Response;
							var af_ = ae_.Request;
							var ag_ = af_.ReferenceElement;
							var ah_ = FHIRHelpers_4_0_001.ToString(ag_);
							var ai_ = NCQAFHIRBase_1_0_0.GetId(ah_);
							var aj_ = context.Operators.Equal(ad_, ai_);
							var ak_ = medClaimLineItem.SequenceElement;
							var al_ = context.Operators.Convert<Integer>(ak_);
							var am_ = pClaimLineItem.ItemSequenceElement;
							var an_ = context.Operators.Convert<Integer>(am_);
							var ao_ = context.Operators.Equal(al_, an_);
							var ap_ = context.Operators.And(aj_, ao_);

							return ap_;
						};
						var z_ = context.Operators.Where<ClaimResponse.ItemComponent>(x_, y_);
						(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var ab_ = context.Operators.Select<ClaimResponse.ItemComponent, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(z_, aa_);

						return ab_;
					};
					var v_ = context.Operators.SelectMany<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
					var w_ = context.Operators.Exists<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(v_);

					return w_;
				};
				var r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
				var s_ = (medClaim, r_);

				return s_;
			};
			var j_ = context.Operators.Select<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?, ((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(h_, i_);
			var k_ = (j_, default(nint));
			var l_ = new (IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?[]
			{
				k_,
			};
			(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? m_((IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)? ClaimWithPaidResponse)
			{
				(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? au_()
				{
					bool az_()
					{
						var ba_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bb_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var bh_ = @this?.ClaimItem;
							var bi_ = context.Operators.Not((bool?)(bh_ is null));

							return bi_;
						};
						var bc_ = context.Operators.Where<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ba_, bb_);
						IEnumerable<Claim.ItemComponent> bd_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var bj_ = @this?.ClaimItem;

							return bj_;
						};
						var be_ = context.Operators.Select<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
						var bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
						var bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);

						return (bg_ ?? false);
					};
					if (az_())
					{
						var bk_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bl_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var cg_ = @this?.PaidClaim;
							var ch_ = context.Operators.Not((bool?)(cg_ is null));

							return ch_;
						};
						var bm_ = context.Operators.Where<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bl_);
						(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? bn_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var ci_ = @this?.PaidClaim;

							return ci_;
						};
						var bo_ = context.Operators.Select<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(bm_, bn_);
						bool? bq_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var cj_ = @this?.ClaimItem;
							var ck_ = context.Operators.Not((bool?)(cj_ is null));

							return ck_;
						};
						var br_ = context.Operators.Where<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bq_);
						IEnumerable<Claim.ItemComponent> bs_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var cl_ = @this?.ClaimItem;

							return cl_;
						};
						var bt_ = context.Operators.Select<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(br_, bs_);
						var bu_ = context.Operators.Flatten<Claim.ItemComponent>(bt_);
						CqlInterval<CqlDateTime> bv_(Claim.ItemComponent PaidItem)
						{
							var cm_ = PaidItem.Serviced;
							var cn_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cm_);

							return cn_;
						};
						var bw_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bu_, bv_);
						bool? by_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var co_ = @this?.ClaimItem;
							var cp_ = context.Operators.Not((bool?)(co_ is null));

							return cp_;
						};
						var bz_ = context.Operators.Where<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, by_);
						IEnumerable<Claim.ItemComponent> ca_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							var cq_ = @this?.ClaimItem;

							return cq_;
						};
						var cb_ = context.Operators.Select<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bz_, ca_);
						var cc_ = context.Operators.Flatten<Claim.ItemComponent>(cb_);
						CqlInterval<CqlDate> cd_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDate> cr_()
							{
								bool cs_()
								{
									var ct_ = i.Quantity;
									var cu_ = context.Operators.Not((bool?)(ct_ is null));

									return (cu_ ?? false);
								};
								if (cs_())
								{
									var cv_ = i.Serviced;
									var cw_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cv_);
									var cx_ = context.Operators.Start(cw_);
									var cy_ = context.Operators.ConvertDateTimeToDate(cx_);
									var da_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cv_);
									var db_ = context.Operators.Start(da_);
									var dc_ = i.Quantity;
									var dd_ = dc_.ValueElement;
									var de_ = FHIRHelpers_4_0_001.ToDecimal(dd_);
									var df_ = context.Operators.Add(db_, new CqlQuantity(de_, "day"));
									var dg_ = context.Operators.Quantity(1m, "day");
									var dh_ = context.Operators.Subtract(df_, dg_);
									var di_ = context.Operators.ConvertDateTimeToDate(dh_);
									var dj_ = context.Operators.Interval(cy_, di_, true, true);

									return dj_;
								}
								else
								{
									return (null as CqlInterval<CqlDate>);
								}
							};

							return cr_();
						};
						var ce_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDate>>(cc_, cd_);
						var cf_ = (bo_, bw_, ce_);

						return cf_;
					}
					else
					{
						return (null as (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?);
					}
				};
				var av_ = new (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?[]
				{
					au_(),
				};
				bool? aw_((IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? FinalList)
				{
					var dk_ = context.Operators.Not((bool?)(FinalList is null));

					return dk_;
				};
				var ax_ = context.Operators.Where<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(((IEnumerable<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>)av_), aw_);
				var ay_ = context.Operators.SingletonFrom<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(ax_);

				return ay_;
			};
			var n_ = context.Operators.Select<(IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?, (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(((IEnumerable<(IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?>)l_), m_);
			var o_ = context.Operators.SingletonFrom<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(n_);

			return o_;
		};
		var f_ = context.Operators.Select<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?, (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(((IEnumerable<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?>)d_), e_);
		var g_ = context.Operators.SingletonFrom<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Pharmacy Services")]
	public (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Paid_Claims_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new (IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?[]
		{
			a_,
		};
		(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? c_((IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? PharmacyClaimAndResponse)
		{
			(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? f_()
			{
				bool g_()
				{
					var h_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
					var i_ = PharmacyClaimAndResponse?.PharmacyClaim;
					var j_ = context.Operators.And((bool?)(h_ is null), (bool?)(i_ is null));

					return (j_ ?? false);
				};
				if (g_())
				{
					return (null as (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?);
				}
				else
				{
					var k_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
					var l_ = PharmacyClaimAndResponse?.PharmacyClaim;
					var m_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(k_, l_, ProductOrServiceValueSet);

					return m_;
				}
			};

			return f_();
		};
		var d_ = context.Operators.Select<(IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?, (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(((IEnumerable<(IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?>)b_), c_);
		var e_ = context.Operators.SingletonFrom<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(d_);

		return e_;
	}

    [CqlDeclaration("Get Claim With Corresponding Claim Response")]
	public IEnumerable<(IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> Get_Claim_With_Corresponding_Claim_Response(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		(IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? a_(Claim Claim)
		{
			bool? c_(ClaimResponse CR)
			{
				var h_ = Claim.IdElement;
				var i_ = FHIRHelpers_4_0_001.ToString(h_);
				var j_ = CR.Request;
				var k_ = j_.ReferenceElement;
				var l_ = FHIRHelpers_4_0_001.ToString(k_);
				var m_ = NCQAFHIRBase_1_0_0.GetId(l_);
				var n_ = context.Operators.Equal(i_, m_);

				return n_;
			};
			var d_ = context.Operators.Where<ClaimResponse>(claimResponse, c_);
			bool? e_(Claim C)
			{
				var o_ = Claim.IdElement;
				var p_ = FHIRHelpers_4_0_001.ToString(o_);
				bool? q_(ClaimResponse CR)
				{
					var ae_ = Claim.IdElement;
					var af_ = FHIRHelpers_4_0_001.ToString(ae_);
					var ag_ = CR.Request;
					var ah_ = ag_.ReferenceElement;
					var ai_ = FHIRHelpers_4_0_001.ToString(ah_);
					var aj_ = NCQAFHIRBase_1_0_0.GetId(ai_);
					var ak_ = context.Operators.Equal(af_, aj_);

					return ak_;
				};
				var r_ = context.Operators.Where<ClaimResponse>(claimResponse, q_);
				bool? s_(ClaimResponse @this)
				{
					var al_ = @this.Request;
					var am_ = context.Operators.Not((bool?)(al_ is null));

					return am_;
				};
				var t_ = context.Operators.Where<ClaimResponse>(r_, s_);
				ResourceReference u_(ClaimResponse @this)
				{
					var an_ = @this.Request;

					return an_;
				};
				var v_ = context.Operators.Select<ClaimResponse, ResourceReference>(t_, u_);
				bool? w_(ResourceReference @this)
				{
					var ao_ = @this.ReferenceElement;
					var ap_ = context.Operators.Not((bool?)(ao_ is null));

					return ap_;
				};
				var x_ = context.Operators.Where<ResourceReference>(v_, w_);
				FhirString y_(ResourceReference @this)
				{
					var aq_ = @this.ReferenceElement;

					return aq_;
				};
				var z_ = context.Operators.Select<ResourceReference, FhirString>(x_, y_);
				var aa_ = context.Operators.SingletonFrom<FhirString>(z_);
				var ab_ = FHIRHelpers_4_0_001.ToString(aa_);
				var ac_ = NCQAFHIRBase_1_0_0.GetId(ab_);
				var ad_ = context.Operators.Equal(p_, ac_);

				return ad_;
			};
			var f_ = context.Operators.Where<Claim>(claim, e_);
			var g_ = (d_, f_);

			return g_;
		};
		var b_ = context.Operators.Select<Claim, (IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Medical Claims With Nonacute or Acute Inpatient Discharge")]
	public (IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(IEnumerable<Claim> claim)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		var b_ = (a_, default(nint));
		var c_ = new (IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[]
		{
			b_,
		};
		(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? d_((IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithInpatientStay)
		{
			IEnumerable<Claim> g_()
			{
				if ((ClaimWithInpatientStay?.MedicalClaim is null))
				{
					return (null as IEnumerable<Claim>);
				}
				else
				{
					var n_ = ClaimWithInpatientStay?.MedicalClaim;
					bool? o_(Claim c)
					{
						var q_ = c.Item;
						bool? r_(Claim.ItemComponent i)
						{
							var u_ = i.Revenue;
							var v_ = FHIRHelpers_4_0_001.ToConcept(u_);
							var w_ = v_.codes;
							bool? x_(CqlCode rev)
							{
								var aa_ = rev.code;
								var ab_ = this.Inpatient_Stay();
								var ac_ = context.Operators.StringInValueSet(aa_, ab_);

								return ac_;
							};
							var y_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)w_, x_);
							var z_ = context.Operators.Exists<CqlCode>(y_);

							return z_;
						};
						var s_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)q_, r_);
						var t_ = context.Operators.Exists<Claim.ItemComponent>(s_);

						return t_;
					};
					var p_ = context.Operators.Where<Claim>(n_, o_);

					return p_;
				}
			};
			IEnumerable<Claim> h_()
			{
				if ((ClaimWithInpatientStay?.MedicalClaim is null))
				{
					return (null as IEnumerable<Claim>);
				}
				else
				{
					var ad_ = ClaimWithInpatientStay?.MedicalClaim;
					bool? ae_(Claim c)
					{
						var ag_ = c.Item;
						bool? ah_(Claim.ItemComponent i)
						{
							var aq_ = i.Revenue;
							var ar_ = FHIRHelpers_4_0_001.ToConcept(aq_);
							var as_ = ar_.codes;
							bool? at_(CqlCode rev)
							{
								var aw_ = rev.code;
								var ax_ = this.Nonacute_Inpatient_Stay();
								var ay_ = context.Operators.StringInValueSet(aw_, ax_);

								return ay_;
							};
							var au_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)as_, at_);
							var av_ = context.Operators.Exists<CqlCode>(au_);

							return av_;
						};
						var ai_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ag_, ah_);
						var aj_ = context.Operators.Exists<Claim.ItemComponent>(ai_);
						var ak_ = c.SubType;
						var al_ = ak_.Coding;
						bool? am_(Coding tob)
						{
							var az_ = tob.CodeElement;
							var ba_ = az_.Value;
							var bb_ = this.Nonacute_Inpatient_Stay();
							var bc_ = context.Operators.StringInValueSet(ba_, bb_);

							return bc_;
						};
						var an_ = context.Operators.Where<Coding>((IEnumerable<Coding>)al_, am_);
						var ao_ = context.Operators.Exists<Coding>(an_);
						var ap_ = context.Operators.Or(aj_, ao_);

						return ap_;
					};
					var af_ = context.Operators.Where<Claim>(ad_, ae_);

					return af_;
				}
			};
			var i_ = (g_(), h_());
			var j_ = new (IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?[]
			{
				i_,
			};
			(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? k_((IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? LineItemDefinition)
			{
				var bd_ = LineItemDefinition?.InpatientStayLineItems;
				var be_ = LineItemDefinition?.NonacuteInpatientLineItems;
				IEnumerable<Claim> bf_(Claim nonAcuteInpatientStay)
				{
					var bn_ = LineItemDefinition?.InpatientStayLineItems;
					bool? bo_(Claim inpatientStay)
					{
						var bs_ = nonAcuteInpatientStay.IdElement;
						var bt_ = inpatientStay.IdElement;
						var bu_ = context.Operators.Equal(bs_, bt_);

						return bu_;
					};
					var bp_ = context.Operators.Where<Claim>(bn_, bo_);
					Claim bq_(Claim inpatientStay) => 
						nonAcuteInpatientStay;
					var br_ = context.Operators.Select<Claim, Claim>(bp_, bq_);

					return br_;
				};
				var bg_ = context.Operators.SelectMany<Claim, Claim>(be_, bf_);
				IEnumerable<Claim> bj_(Claim inpatientStay)
				{
					var bv_ = LineItemDefinition?.NonacuteInpatientLineItems;
					bool? bw_(Claim nonAcuteInpatientStay)
					{
						var ca_ = inpatientStay.IdElement;
						var cb_ = nonAcuteInpatientStay.IdElement;
						var cc_ = context.Operators.Equal(ca_, cb_);

						return cc_;
					};
					var bx_ = context.Operators.Where<Claim>(bv_, bw_);
					Claim by_(Claim nonAcuteInpatientStay) => 
						inpatientStay;
					var bz_ = context.Operators.Select<Claim, Claim>(bx_, by_);

					return bz_;
				};
				var bk_ = context.Operators.SelectMany<Claim, Claim>(bd_, bj_);
				var bl_ = context.Operators.Except<Claim>(bd_, bk_);
				var bm_ = (bd_, bg_, bl_);

				return bm_;
			};
			var l_ = context.Operators.Select<(IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?, (IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(((IEnumerable<(IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?>)j_), k_);
			var m_ = context.Operators.SingletonFrom<(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(l_);

			return m_;
		};
		var e_ = context.Operators.Select<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, (IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(((IEnumerable<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)c_), d_);
		var f_ = context.Operators.SingletonFrom<(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(e_);

		return f_;
	}

    [CqlDeclaration("Get Prescriber NPI from Claims")]
	public (int? IdentifierCount, nint _)? Get_Prescriber_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? a_(Claim C)
		{
			var h_ = C.CareTeam;
			bool? i_(Claim.CareTeamComponent ct)
			{
				var y_ = ct.SequenceElement;
				var z_ = context.Operators.Convert<Integer>(y_);
				var aa_ = FHIRHelpers_4_0_001.ToInteger(z_);
				var ab_ = context.Operators.Equal(aa_, 1);

				return ab_;
			};
			var j_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)h_, i_);
			bool? k_(Claim.CareTeamComponent @this)
			{
				var ac_ = @this.Provider;
				var ad_ = context.Operators.Not((bool?)(ac_ is null));

				return ad_;
			};
			var l_ = context.Operators.Where<Claim.CareTeamComponent>(j_, k_);
			ResourceReference m_(Claim.CareTeamComponent @this)
			{
				var ae_ = @this.Provider;

				return ae_;
			};
			var n_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(l_, m_);
			bool? p_(Claim.CareTeamComponent ct)
			{
				var af_ = ct.SequenceElement;
				var ag_ = context.Operators.Convert<Integer>(af_);
				var ah_ = FHIRHelpers_4_0_001.ToInteger(ag_);
				var ai_ = context.Operators.Equal(ah_, 1);

				return ai_;
			};
			var q_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)h_, p_);
			bool? r_(Claim.CareTeamComponent @this)
			{
				var aj_ = @this.Provider;
				var ak_ = context.Operators.Not((bool?)(aj_ is null));

				return ak_;
			};
			var s_ = context.Operators.Where<Claim.CareTeamComponent>(q_, r_);
			ResourceReference t_(Claim.CareTeamComponent @this)
			{
				var al_ = @this.Provider;

				return al_;
			};
			var u_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(s_, t_);
			string v_(ResourceReference p)
			{
				var am_ = p.ReferenceElement;
				var an_ = new FhirString[]
				{
					am_,
				};
				string ao_(FhirString r)
				{
					var ar_ = FHIRHelpers_4_0_001.ToString(r);
					var as_ = NCQAFHIRBase_1_0_0.GetId(ar_);

					return as_;
				};
				var ap_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)an_, ao_);
				var aq_ = context.Operators.SingletonFrom<string>(ap_);

				return aq_;
			};
			var w_ = context.Operators.Select<ResourceReference, string>(u_, v_);
			var x_ = (C, n_, w_);

			return x_;
		};
		var b_ = context.Operators.Select<Claim, (Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(claim, a_);
		var c_ = (b_, default(nint));
		var d_ = new (IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams, nint _)?[]
		{
			c_,
		};
		(int? IdentifierCount, nint _)? e_((IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams, nint _)? ClaimProperties)
		{
			var at_ = context.Operators.RetrieveByValueSet<Practitioner>(null, null);
			bool? au_(Practitioner p)
			{
				var bb_ = p.IdElement;
				var bc_ = FHIRHelpers_4_0_001.ToString(bb_);
				var bd_ = ClaimProperties?.CareTeams;
				bool? be_((Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
				{
					var bk_ = @this?.CareTeamsProviderID;
					var bl_ = context.Operators.Not((bool?)(bk_ is null));

					return bl_;
				};
				var bf_ = context.Operators.Where<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(bd_, be_);
				IEnumerable<string> bg_((Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
				{
					var bm_ = @this?.CareTeamsProviderID;

					return bm_;
				};
				var bh_ = context.Operators.Select<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, IEnumerable<string>>(bf_, bg_);
				var bi_ = context.Operators.Flatten<string>(bh_);
				var bj_ = context.Operators.In<string>(bc_, bi_);

				return bj_;
			};
			var av_ = context.Operators.Where<Practitioner>(at_, au_);
			var aw_ = (av_, default(nint));
			var ax_ = new (IEnumerable<Practitioner> Practitioners, nint _)?[]
			{
				aw_,
			};
			(int? IdentifierCount, nint _)? ay_((IEnumerable<Practitioner> Practitioners, nint _)? PractitionerMatch)
			{
				var bn_ = PractitionerMatch?.Practitioners;
				bool? bo_(Practitioner P)
				{
					var bx_ = context.Operators.Not((bool?)(P is null));

					return bx_;
				};
				var bp_ = context.Operators.Where<Practitioner>(bn_, bo_);
				(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? bq_(Practitioner P)
				{
					var by_ = P.Identifier;
					bool? bz_(Identifier l)
					{
						var cj_ = l.SystemElement;
						var ck_ = cj_.Value;
						var cl_ = context.Operators.Equal(ck_, "http://hl7.org/fhir/sid/us-npi");
						var cm_ = l.Type;
						var cn_ = FHIRHelpers_4_0_001.ToConcept(cm_);
						var co_ = NCQATerminology_1_0_0.Provider_number();
						var cp_ = context.Operators.ConvertCodeToConcept(co_);
						var cq_ = context.Operators.Equivalent(cn_, cp_);
						var cr_ = context.Operators.And(cl_, cq_);
						var cs_ = l.ValueElement;
						var ct_ = cs_.Value;
						var cu_ = context.Operators.Not((bool?)(ct_ is null));
						var cv_ = context.Operators.And(cr_, cu_);

						return cv_;
					};
					var ca_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)by_, bz_);
					FhirString cb_(Identifier l)
					{
						var cw_ = l.ValueElement;

						return cw_;
					};
					var cc_ = context.Operators.Select<Identifier, FhirString>(ca_, cb_);
					bool? ce_(Identifier l)
					{
						var cx_ = l.SystemElement;
						var cy_ = cx_.Value;
						var cz_ = context.Operators.Equal(cy_, "http://hl7.org/fhir/sid/us-npi");
						var da_ = l.Type;
						var db_ = FHIRHelpers_4_0_001.ToConcept(da_);
						var dc_ = NCQATerminology_1_0_0.Provider_number();
						var dd_ = context.Operators.ConvertCodeToConcept(dc_);
						var de_ = context.Operators.Equivalent(db_, dd_);
						var df_ = context.Operators.And(cz_, de_);
						var dg_ = l.ValueElement;
						var dh_ = dg_.Value;
						var di_ = context.Operators.And(df_, (bool?)(dh_ is null));

						return di_;
					};
					var cf_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)by_, ce_);
					Identifier cg_(Identifier l) => 
						l;
					var ch_ = context.Operators.Select<Identifier, Identifier>(cf_, cg_);
					var ci_ = (cc_, ch_);

					return ci_;
				};
				var br_ = context.Operators.Select<Practitioner, (IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(bp_, bq_);
				var bs_ = (br_, default(nint));
				var bt_ = new (IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)?[]
				{
					bs_,
				};
				(int? IdentifierCount, nint _)? bu_((IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)? GetIdentifiers)
				{
					int? dj_()
					{
						bool dl_()
						{
							var dm_ = ClaimProperties?.CareTeams;
							bool? dn_((Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
							{
								var ds_ = @this?.SingleCareTeam;
								var dt_ = context.Operators.Not((bool?)(ds_ is null));

								return dt_;
							};
							var do_ = context.Operators.Where<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(dm_, dn_);
							Claim dp_((Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
							{
								var du_ = @this?.SingleCareTeam;

								return du_;
							};
							var dq_ = context.Operators.Select<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(do_, dp_);
							var dr_ = context.Operators.Exists<Claim>(dq_);

							return (dr_ ?? false);
						};
						if (dl_())
						{
							var dv_ = ClaimProperties?.CareTeams;
							bool? dw_((Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
							{
								var er_ = @this?.SingleCareTeam;
								var es_ = context.Operators.Not((bool?)(er_ is null));

								return es_;
							};
							var dx_ = context.Operators.Where<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(dv_, dw_);
							Claim dy_((Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
							{
								var et_ = @this?.SingleCareTeam;

								return et_;
							};
							var dz_ = context.Operators.Select<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(dx_, dy_);
							bool? ea_(Claim X)
							{
								var eu_ = X.CareTeam;

								return (bool?)((IEnumerable<Claim.CareTeamComponent>)eu_ is null);
							};
							var eb_ = context.Operators.Where<Claim>(dz_, ea_);
							var ec_ = context.Operators.Count<Claim>(eb_);
							var ed_ = GetIdentifiers?.IdentifierTuple;
							IEnumerable<FhirString> ee_((IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
							{
								var ev_ = X?.AllIdentifiers;

								return ev_;
							};
							var ef_ = context.Operators.Select<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(ed_, ee_);
							var eg_ = context.Operators.Flatten<FhirString>(ef_);
							FhirString eh_(FhirString X) => 
								X;
							var ei_ = context.Operators.Select<FhirString, FhirString>(eg_, eh_);
							var ej_ = context.Operators.Count<FhirString>(ei_);
							var ek_ = context.Operators.Add(ec_, ej_);
							IEnumerable<Identifier> em_((IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
							{
								var ew_ = X?.NullIdentifiers;

								return ew_;
							};
							var en_ = context.Operators.Select<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(ed_, em_);
							var eo_ = context.Operators.Flatten<Identifier>(en_);
							var ep_ = context.Operators.Count<Identifier>(eo_);
							var eq_ = context.Operators.Add(ek_, ep_);

							return eq_;
						}
						else
						{
							return 0;
						}
					};
					var dk_ = (dj_(), default(nint));

					return dk_;
				};
				var bv_ = context.Operators.Select<(IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)?, (int? IdentifierCount, nint _)?>(((IEnumerable<(IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)?>)bt_), bu_);
				var bw_ = context.Operators.SingletonFrom<(int? IdentifierCount, nint _)?>(bv_);

				return bw_;
			};
			var az_ = context.Operators.Select<(IEnumerable<Practitioner> Practitioners, nint _)?, (int? IdentifierCount, nint _)?>(((IEnumerable<(IEnumerable<Practitioner> Practitioners, nint _)?>)ax_), ay_);
			var ba_ = context.Operators.SingletonFrom<(int? IdentifierCount, nint _)?>(az_);

			return ba_;
		};
		var f_ = context.Operators.Select<(IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams, nint _)?, (int? IdentifierCount, nint _)?>(((IEnumerable<(IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams, nint _)?>)d_), e_);
		var g_ = context.Operators.SingletonFrom<(int? IdentifierCount, nint _)?>(f_);

		return g_;
	}

    [CqlDeclaration("Get Pharmacy NPI from Claims")]
	public (int? IdentifierCount, nint _)? Get_Pharmacy_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? a_(Claim C)
		{
			var h_ = C.Item;
			bool? j_(Claim.ItemComponent i)
			{
				var ab_ = i.SequenceElement;
				var ac_ = context.Operators.Convert<Integer>(ab_);
				var ad_ = FHIRHelpers_4_0_001.ToInteger(ac_);
				var ae_ = context.Operators.Equal(ad_, 1);

				return ae_;
			};
			var k_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)h_, j_);
			bool? l_(Claim.ItemComponent @this)
			{
				var af_ = @this.Location;
				var ag_ = context.Operators.Not((bool?)(af_ is null));

				return ag_;
			};
			var m_ = context.Operators.Where<Claim.ItemComponent>(k_, l_);
			DataType n_(Claim.ItemComponent @this)
			{
				var ah_ = @this.Location;

				return ah_;
			};
			var o_ = context.Operators.Select<Claim.ItemComponent, DataType>(m_, n_);
			ResourceReference p_(object l) => 
				(l as ResourceReference);
			var q_ = context.Operators.Select<object, ResourceReference>((IEnumerable<object>)o_, p_);
			bool? s_(Claim.ItemComponent i)
			{
				var ai_ = i.SequenceElement;
				var aj_ = context.Operators.Convert<Integer>(ai_);
				var ak_ = FHIRHelpers_4_0_001.ToInteger(aj_);
				var al_ = context.Operators.Equal(ak_, 1);

				return al_;
			};
			var t_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)h_, s_);
			bool? u_(Claim.ItemComponent @this)
			{
				var am_ = @this.Location;
				var an_ = context.Operators.Not((bool?)(am_ is null));

				return an_;
			};
			var v_ = context.Operators.Where<Claim.ItemComponent>(t_, u_);
			DataType w_(Claim.ItemComponent @this)
			{
				var ao_ = @this.Location;

				return ao_;
			};
			var x_ = context.Operators.Select<Claim.ItemComponent, DataType>(v_, w_);
			string y_(object l)
			{
				var ap_ = (l as ResourceReference).ReferenceElement;
				var aq_ = new FhirString[]
				{
					ap_,
				};
				string ar_(FhirString r)
				{
					var au_ = FHIRHelpers_4_0_001.ToString(r);
					var av_ = NCQAFHIRBase_1_0_0.GetId(au_);

					return av_;
				};
				var as_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)aq_, ar_);
				var at_ = context.Operators.SingletonFrom<string>(as_);

				return at_;
			};
			var z_ = context.Operators.Select<object, string>((IEnumerable<object>)x_, y_);
			var aa_ = ((IEnumerable<Claim.ItemComponent>)h_, q_, z_);

			return aa_;
		};
		var b_ = context.Operators.Select<Claim, (IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(claim, a_);
		var c_ = (b_, default(nint));
		var d_ = new (IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences, nint _)?[]
		{
			c_,
		};
		(int? IdentifierCount, nint _)? e_((IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences, nint _)? ClaimProperties)
		{
			var aw_ = context.Operators.RetrieveByValueSet<Location>(null, null);
			bool? ax_(Location l)
			{
				var be_ = l.IdElement;
				var bf_ = FHIRHelpers_4_0_001.ToString(be_);
				var bg_ = ClaimProperties?.ItemsLocationReferences;
				bool? bh_((IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
				{
					var bn_ = @this?.ItemLocationID;
					var bo_ = context.Operators.Not((bool?)(bn_ is null));

					return bo_;
				};
				var bi_ = context.Operators.Where<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(bg_, bh_);
				IEnumerable<string> bj_((IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
				{
					var bp_ = @this?.ItemLocationID;

					return bp_;
				};
				var bk_ = context.Operators.Select<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<string>>(bi_, bj_);
				var bl_ = context.Operators.Flatten<string>(bk_);
				var bm_ = context.Operators.In<string>(bf_, bl_);

				return bm_;
			};
			var ay_ = context.Operators.Where<Location>(aw_, ax_);
			var az_ = (ay_, default(nint));
			var ba_ = new (IEnumerable<Location> CorrespondingLocations, nint _)?[]
			{
				az_,
			};
			(int? IdentifierCount, nint _)? bb_((IEnumerable<Location> CorrespondingLocations, nint _)? GetLocation)
			{
				var bq_ = GetLocation?.CorrespondingLocations;
				bool? br_(Location C)
				{
					var ca_ = context.Operators.Not((bool?)(C is null));

					return ca_;
				};
				var bs_ = context.Operators.Where<Location>(bq_, br_);
				(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? bt_(Location C)
				{
					var cb_ = C.Identifier;
					bool? cc_(Identifier l)
					{
						var cm_ = l.SystemElement;
						var cn_ = cm_.Value;
						var co_ = context.Operators.Equal(cn_, "http://hl7.org/fhir/sid/us-npi");
						var cp_ = l.Type;
						var cq_ = FHIRHelpers_4_0_001.ToConcept(cp_);
						var cr_ = NCQATerminology_1_0_0.Provider_number();
						var cs_ = context.Operators.ConvertCodeToConcept(cr_);
						var ct_ = context.Operators.Equivalent(cq_, cs_);
						var cu_ = context.Operators.And(co_, ct_);
						var cv_ = l.ValueElement;
						var cw_ = cv_.Value;
						var cx_ = context.Operators.Not((bool?)(cw_ is null));
						var cy_ = context.Operators.And(cu_, cx_);

						return cy_;
					};
					var cd_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)cb_, cc_);
					FhirString ce_(Identifier l)
					{
						var cz_ = l.ValueElement;

						return cz_;
					};
					var cf_ = context.Operators.Select<Identifier, FhirString>(cd_, ce_);
					bool? ch_(Identifier l)
					{
						var da_ = l.SystemElement;
						var db_ = da_.Value;
						var dc_ = context.Operators.Equal(db_, "http://hl7.org/fhir/sid/us-npi");
						var dd_ = l.Type;
						var de_ = FHIRHelpers_4_0_001.ToConcept(dd_);
						var df_ = NCQATerminology_1_0_0.Provider_number();
						var dg_ = context.Operators.ConvertCodeToConcept(df_);
						var dh_ = context.Operators.Equivalent(de_, dg_);
						var di_ = context.Operators.And(dc_, dh_);
						var dj_ = l.ValueElement;
						var dk_ = dj_.Value;
						var dl_ = context.Operators.And(di_, (bool?)(dk_ is null));

						return dl_;
					};
					var ci_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)cb_, ch_);
					Identifier cj_(Identifier l) => 
						l;
					var ck_ = context.Operators.Select<Identifier, Identifier>(ci_, cj_);
					var cl_ = (cf_, ck_);

					return cl_;
				};
				var bu_ = context.Operators.Select<Location, (IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(bs_, bt_);
				var bv_ = (bu_, default(nint));
				var bw_ = new (IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)?[]
				{
					bv_,
				};
				(int? IdentifierCount, nint _)? bx_((IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)? GetIdentifiers)
				{
					int? dm_()
					{
						bool do_()
						{
							var dp_ = ClaimProperties?.ItemsLocationReferences;
							bool? dq_((IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
							{
								var dw_ = @this?.SingleItem;
								var dx_ = context.Operators.Not((bool?)(dw_ is null));

								return dx_;
							};
							var dr_ = context.Operators.Where<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(dp_, dq_);
							IEnumerable<Claim.ItemComponent> ds_((IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
							{
								var dy_ = @this?.SingleItem;

								return dy_;
							};
							var dt_ = context.Operators.Select<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<Claim.ItemComponent>>(dr_, ds_);
							var du_ = context.Operators.Flatten<Claim.ItemComponent>(dt_);
							var dv_ = context.Operators.Exists<Claim.ItemComponent>(du_);

							return (dv_ ?? false);
						};
						if (do_())
						{
							var dz_ = ClaimProperties?.ItemsLocationReferences;
							bool? ea_((IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
							{
								var ew_ = @this?.ItemLocation;
								var ex_ = context.Operators.Not((bool?)(ew_ is null));

								return ex_;
							};
							var eb_ = context.Operators.Where<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(dz_, ea_);
							IEnumerable<ResourceReference> ec_((IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
							{
								var ey_ = @this?.ItemLocation;

								return ey_;
							};
							var ed_ = context.Operators.Select<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<ResourceReference>>(eb_, ec_);
							var ee_ = context.Operators.Flatten<ResourceReference>(ed_);
							bool? ef_(ResourceReference X)
							{
								var ez_ = X.ReferenceElement;
								var fa_ = ez_.Value;

								return (bool?)(fa_ is null);
							};
							var eg_ = context.Operators.Where<ResourceReference>(ee_, ef_);
							var eh_ = context.Operators.Count<ResourceReference>(eg_);
							var ei_ = GetIdentifiers?.IdentifierTuple;
							IEnumerable<FhirString> ej_((IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
							{
								var fb_ = X?.AllIdentifiers;

								return fb_;
							};
							var ek_ = context.Operators.Select<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(ei_, ej_);
							var el_ = context.Operators.Flatten<FhirString>(ek_);
							FhirString em_(FhirString X) => 
								X;
							var en_ = context.Operators.Select<FhirString, FhirString>(el_, em_);
							var eo_ = context.Operators.Count<FhirString>(en_);
							var ep_ = context.Operators.Add(eh_, eo_);
							IEnumerable<Identifier> er_((IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
							{
								var fc_ = X?.NullIdentifiers;

								return fc_;
							};
							var es_ = context.Operators.Select<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(ei_, er_);
							var et_ = context.Operators.Flatten<Identifier>(es_);
							var eu_ = context.Operators.Count<Identifier>(et_);
							var ev_ = context.Operators.Add(ep_, eu_);

							return ev_;
						}
						else
						{
							return 0;
						}
					};
					var dn_ = (dm_(), default(nint));

					return dn_;
				};
				var by_ = context.Operators.Select<(IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)?, (int? IdentifierCount, nint _)?>(((IEnumerable<(IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)?>)bw_), bx_);
				var bz_ = context.Operators.SingletonFrom<(int? IdentifierCount, nint _)?>(by_);

				return bz_;
			};
			var bc_ = context.Operators.Select<(IEnumerable<Location> CorrespondingLocations, nint _)?, (int? IdentifierCount, nint _)?>(((IEnumerable<(IEnumerable<Location> CorrespondingLocations, nint _)?>)ba_), bb_);
			var bd_ = context.Operators.SingletonFrom<(int? IdentifierCount, nint _)?>(bc_);

			return bd_;
		};
		var f_ = context.Operators.Select<(IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences, nint _)?, (int? IdentifierCount, nint _)?>(((IEnumerable<(IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences, nint _)?>)d_), e_);
		var g_ = context.Operators.SingletonFrom<(int? IdentifierCount, nint _)?>(f_);

		return g_;
	}

}

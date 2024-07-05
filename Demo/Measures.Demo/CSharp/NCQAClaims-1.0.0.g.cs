using System;
using Tuples;
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
			var c_ = MedicalClaim?.Type;
			var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var e_ = d_?.codes;
			var f_ = NCQATerminology_1_0_0.Professional();
			var g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);
			var i_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var j_ = i_?.codes;
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
			var c_ = PharmacyClaim?.Type;
			var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var e_ = d_?.codes;
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
			var c_ = MedicalResponse?.Type;
			var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var e_ = d_?.codes;
			var f_ = NCQATerminology_1_0_0.Professional();
			var g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);
			var i_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var j_ = i_?.codes;
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
			var c_ = PharmacyResponse?.Type;
			var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var e_ = d_?.codes;
			var f_ = NCQATerminology_1_0_0.Pharmacy();
			var g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);

			return g_;
		};
		var b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);

		return b_;
	}

    [CqlDeclaration("Medical Claims With Procedure and POS")]
	public IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd> Medical_Claims_With_Procedure_and_POS(IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p)
		{
			var k_ = p?.code;

			return k_;
		};
		var c_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, b_);
		string d_(CqlCode pos)
		{
			var l_ = pos?.code;

			return l_;
		};
		var e_ = context.Operators.Select<CqlCode, string>(posCodes, d_);
		var f_ = new Tuple_FXYEMgTMOeKcIebiZCTUajHVX
		{
			MedicalClaim = a_,
			ProceduresAsStrings = c_,
			POSAsString = e_,
		};
		var g_ = new Tuple_FXYEMgTMOeKcIebiZCTUajHVX[]
		{
			f_,
		};
		IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd> h_(Tuple_FXYEMgTMOeKcIebiZCTUajHVX ClaimWithPosCode)
		{
			var m_ = ClaimWithPosCode?.MedicalClaim;
			Tuple_GDUUTAIXZafehWFjcGfNKBcTd n_(Claim ClaimofInterest)
			{
				IEnumerable<Claim.ItemComponent> r_()
				{
					if ((ClaimofInterest is null))
					{
						return (null as IEnumerable<Claim.ItemComponent>);
					}
					else
					{
						var x_ = ClaimofInterest?.Item;
						bool? y_(Claim.ItemComponent ItemOnLine)
						{
							var aa_ = ItemOnLine?.ProductOrService;
							var ab_ = FHIRHelpers_4_0_001.ToConcept(aa_);
							var ac_ = ab_?.codes;
							bool? ad_(CqlCode LineCode)
							{
								var an_ = LineCode?.code;
								var ao_ = ClaimWithPosCode?.ProceduresAsStrings;
								var ap_ = context.Operators.In<string>(an_, ao_);

								return ap_;
							};
							var ae_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)ac_, ad_);
							var af_ = context.Operators.Exists<CqlCode>(ae_);
							var ag_ = ItemOnLine?.Location;
							var ah_ = FHIRHelpers_4_0_001.ToConcept((ag_ as CodeableConcept));
							var ai_ = ah_?.codes;
							bool? aj_(CqlCode PosCode)
							{
								var aq_ = PosCode?.code;
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
				var s_ = new Tuple_HSdidNdfHCNCFSUTgBiYLcgXP
				{
					Claim = ClaimofInterest,
					LineItems = r_(),
				};
				var t_ = new Tuple_HSdidNdfHCNCFSUTgBiYLcgXP[]
				{
					s_,
				};
				Tuple_GDUUTAIXZafehWFjcGfNKBcTd u_(Tuple_HSdidNdfHCNCFSUTgBiYLcgXP LineItemDefinition)
				{
					Tuple_GDUUTAIXZafehWFjcGfNKBcTd at_()
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
								var bg_ = @this?.Serviced;
								var bh_ = context.Operators.Not((bool?)(bg_ is null));

								return bh_;
							};
							var ba_ = context.Operators.Where<Claim.ItemComponent>(ay_, az_);
							DataType bb_(Claim.ItemComponent @this)
							{
								var bi_ = @this?.Serviced;

								return bi_;
							};
							var bc_ = context.Operators.Select<Claim.ItemComponent, DataType>(ba_, bb_);
							CqlInterval<CqlDateTime> bd_(object NormalDate)
							{
								var bj_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return bj_;
							};
							var be_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>((IEnumerable<object>)bc_, bd_);
							var bf_ = new Tuple_GDUUTAIXZafehWFjcGfNKBcTd
							{
								Claim = ax_,
								ServicePeriod = be_,
							};

							return bf_;
						}
						else
						{
							return (null as Tuple_GDUUTAIXZafehWFjcGfNKBcTd);
						}
					};

					return at_();
				};
				var v_ = context.Operators.Select<Tuple_HSdidNdfHCNCFSUTgBiYLcgXP, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>((IEnumerable<Tuple_HSdidNdfHCNCFSUTgBiYLcgXP>)t_, u_);
				var w_ = context.Operators.SingletonFrom<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(v_);

				return w_;
			};
			var o_ = context.Operators.Select<Claim, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(m_, n_);
			bool? p_(Tuple_GDUUTAIXZafehWFjcGfNKBcTd FinalList)
			{
				var bk_ = context.Operators.Not((bool?)(FinalList is null));

				return bk_;
			};
			var q_ = context.Operators.Where<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(o_, p_);

			return q_;
		};
		var i_ = context.Operators.Select<Tuple_FXYEMgTMOeKcIebiZCTUajHVX, IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>((IEnumerable<Tuple_FXYEMgTMOeKcIebiZCTUajHVX>)g_, h_);
		var j_ = context.Operators.SingletonFrom<IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Procedure in Header or on Line Item")]
	public IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p)
		{
			var i_ = p?.code;

			return i_;
		};
		var c_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, b_);
		var d_ = new Tuple_FXYEMgTMOeKcIebiZCTUajHVX
		{
			MedicalClaim = a_,
			ProceduresAsStrings = c_,
		};
		var e_ = new Tuple_FXYEMgTMOeKcIebiZCTUajHVX[]
		{
			d_,
		};
		IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd> f_(Tuple_FXYEMgTMOeKcIebiZCTUajHVX ClaimWithProcedure)
		{
			var j_ = ClaimWithProcedure?.MedicalClaim;
			Tuple_GDUUTAIXZafehWFjcGfNKBcTd k_(Claim ClaimofInterest)
			{
				IEnumerable<Claim.ItemComponent> o_()
				{
					if ((ClaimofInterest is null))
					{
						return (null as IEnumerable<Claim.ItemComponent>);
					}
					else
					{
						var u_ = ClaimofInterest?.Item;
						bool? v_(Claim.ItemComponent ItemOnLine)
						{
							var x_ = ItemOnLine?.ProductOrService;
							var y_ = FHIRHelpers_4_0_001.ToConcept(x_);
							var z_ = y_?.codes;
							bool? aa_(CqlCode LineCode)
							{
								var at_ = LineCode?.code;
								var au_ = ClaimWithProcedure?.ProceduresAsStrings;
								var av_ = context.Operators.In<string>(at_, au_);

								return av_;
							};
							var ab_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)z_, aa_);
							var ac_ = context.Operators.Exists<CqlCode>(ab_);
							var ad_ = ClaimofInterest?.Procedure;
							bool? ae_(Claim.ProcedureComponent @this)
							{
								var aw_ = @this?.Procedure;
								var ax_ = context.Operators.Not((bool?)(aw_ is null));

								return ax_;
							};
							var af_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)ad_, ae_);
							DataType ag_(Claim.ProcedureComponent @this)
							{
								var ay_ = @this?.Procedure;

								return ay_;
							};
							var ah_ = context.Operators.Select<Claim.ProcedureComponent, DataType>(af_, ag_);
							bool? ai_(object @this)
							{
								var az_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								var ba_ = context.Operators.Not((bool?)(az_ is null));

								return ba_;
							};
							var aj_ = context.Operators.Where<object>((IEnumerable<object>)ah_, ai_);
							object ak_(object @this)
							{
								var bb_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return bb_;
							};
							var al_ = context.Operators.Select<object, object>(aj_, ak_);
							var am_ = context.Operators.FlattenLateBoundList(al_);
							Coding an_(object @object) => 
								(Coding)@object;
							var ao_ = context.Operators.Select<object, Coding>(am_, an_);
							bool? ap_(Coding HeaderCode)
							{
								var bc_ = HeaderCode?.CodeElement;
								var bd_ = bc_?.Value;
								var be_ = ClaimWithProcedure?.ProceduresAsStrings;
								var bf_ = context.Operators.In<string>(bd_, be_);

								return bf_;
							};
							var aq_ = context.Operators.Where<Coding>(ao_, ap_);
							var ar_ = context.Operators.Exists<Coding>(aq_);
							var as_ = context.Operators.Or(ac_, ar_);

							return as_;
						};
						var w_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)u_, v_);

						return w_;
					}
				};
				var p_ = new Tuple_HSdidNdfHCNCFSUTgBiYLcgXP
				{
					Claim = ClaimofInterest,
					LineItems = o_(),
				};
				var q_ = new Tuple_HSdidNdfHCNCFSUTgBiYLcgXP[]
				{
					p_,
				};
				Tuple_GDUUTAIXZafehWFjcGfNKBcTd r_(Tuple_HSdidNdfHCNCFSUTgBiYLcgXP LineItemDefinition)
				{
					Tuple_GDUUTAIXZafehWFjcGfNKBcTd bg_()
					{
						bool bh_()
						{
							var bi_ = LineItemDefinition?.LineItems;
							var bj_ = context.Operators.Exists<Claim.ItemComponent>(bi_);

							return (bj_ ?? false);
						};
						if (bh_())
						{
							var bk_ = LineItemDefinition?.Claim;
							var bl_ = LineItemDefinition?.LineItems;
							bool? bm_(Claim.ItemComponent @this)
							{
								var bt_ = @this?.Serviced;
								var bu_ = context.Operators.Not((bool?)(bt_ is null));

								return bu_;
							};
							var bn_ = context.Operators.Where<Claim.ItemComponent>(bl_, bm_);
							DataType bo_(Claim.ItemComponent @this)
							{
								var bv_ = @this?.Serviced;

								return bv_;
							};
							var bp_ = context.Operators.Select<Claim.ItemComponent, DataType>(bn_, bo_);
							CqlInterval<CqlDateTime> bq_(object NormalDate)
							{
								var bw_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return bw_;
							};
							var br_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>((IEnumerable<object>)bp_, bq_);
							var bs_ = new Tuple_GDUUTAIXZafehWFjcGfNKBcTd
							{
								Claim = bk_,
								ServicePeriod = br_,
							};

							return bs_;
						}
						else
						{
							return (null as Tuple_GDUUTAIXZafehWFjcGfNKBcTd);
						}
					};

					return bg_();
				};
				var s_ = context.Operators.Select<Tuple_HSdidNdfHCNCFSUTgBiYLcgXP, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>((IEnumerable<Tuple_HSdidNdfHCNCFSUTgBiYLcgXP>)q_, r_);
				var t_ = context.Operators.SingletonFrom<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(s_);

				return t_;
			};
			var l_ = context.Operators.Select<Claim, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(j_, k_);
			bool? m_(Tuple_GDUUTAIXZafehWFjcGfNKBcTd FinalList)
			{
				var bx_ = context.Operators.Not((bool?)(FinalList is null));

				return bx_;
			};
			var n_ = context.Operators.Where<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(l_, m_);

			return n_;
		};
		var g_ = context.Operators.Select<Tuple_FXYEMgTMOeKcIebiZCTUajHVX, IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>((IEnumerable<Tuple_FXYEMgTMOeKcIebiZCTUajHVX>)e_, f_);
		var h_ = context.Operators.SingletonFrom<IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis")]
	public Tuple_CWDDWHRXGADEbdaKXCdKbgEfg Medical_Claims_With_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var i_ = d?.code;

			return i_;
		};
		var c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		var d_ = new Tuple_DKCCfPXSWPMBNeFXdjEFGiRcF
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
		};
		var e_ = new Tuple_DKCCfPXSWPMBNeFXdjEFGiRcF[]
		{
			d_,
		};
		Tuple_CWDDWHRXGADEbdaKXCdKbgEfg f_(Tuple_DKCCfPXSWPMBNeFXdjEFGiRcF ClaimWithDiagnosis)
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
						var s_ = DiagnosisLine?.Diagnosis;
						bool? t_(Claim.DiagnosisComponent @this)
						{
							var ah_ = @this?.Diagnosis;
							var ai_ = context.Operators.Not((bool?)(ah_ is null));

							return ai_;
						};
						var u_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)s_, t_);
						DataType v_(Claim.DiagnosisComponent @this)
						{
							var aj_ = @this?.Diagnosis;

							return aj_;
						};
						var w_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(u_, v_);
						bool? x_(object @this)
						{
							var ak_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							var al_ = context.Operators.Not((bool?)(ak_ is null));

							return al_;
						};
						var y_ = context.Operators.Where<object>((IEnumerable<object>)w_, x_);
						object z_(object @this)
						{
							var am_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return am_;
						};
						var aa_ = context.Operators.Select<object, object>(y_, z_);
						var ab_ = context.Operators.FlattenLateBoundList(aa_);
						Coding ac_(object @object) => 
							(Coding)@object;
						var ad_ = context.Operators.Select<object, Coding>(ab_, ac_);
						bool? ae_(Coding HeaderCode)
						{
							var an_ = HeaderCode?.CodeElement;
							var ao_ = an_?.Value;
							var ap_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
							var aq_ = context.Operators.In<string>(ao_, ap_);

							return aq_;
						};
						var af_ = context.Operators.Where<Coding>(ad_, ae_);
						var ag_ = context.Operators.Exists<Coding>(af_);

						return ag_;
					};
					var r_ = context.Operators.Where<Claim>(p_, q_);

					return r_;
				}
			};
			var k_ = new Tuple_GDVcejYEWXWNHUIODacaMaBhV
			{
				DiagnosisItems = j_(),
			};
			var l_ = new Tuple_GDVcejYEWXWNHUIODacaMaBhV[]
			{
				k_,
			};
			Tuple_CWDDWHRXGADEbdaKXCdKbgEfg m_(Tuple_GDVcejYEWXWNHUIODacaMaBhV HeaderDefinition)
			{
				Tuple_CWDDWHRXGADEbdaKXCdKbgEfg ar_()
				{
					bool aw_()
					{
						var ax_ = HeaderDefinition?.DiagnosisItems;
						var ay_ = context.Operators.Exists<Claim>(ax_);

						return (ay_ ?? false);
					};
					if (aw_())
					{
						var az_ = HeaderDefinition?.DiagnosisItems;
						bool? bb_(Claim @this)
						{
							var bj_ = @this?.Item;
							var bk_ = context.Operators.Not((bool?)(bj_ is null));

							return bk_;
						};
						var bc_ = context.Operators.Where<Claim>(az_, bb_);
						List<Claim.ItemComponent> bd_(Claim @this)
						{
							var bl_ = @this?.Item;

							return bl_;
						};
						var be_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(bc_, bd_);
						var bf_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)be_);
						CqlInterval<CqlDateTime> bg_(Claim.ItemComponent NormalDate)
						{
							var bm_ = NormalDate?.Serviced;
							var bn_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bm_);

							return bn_;
						};
						var bh_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bf_, bg_);
						var bi_ = new Tuple_CWDDWHRXGADEbdaKXCdKbgEfg
						{
							Claim = az_,
							ServicePeriod = bh_,
						};

						return bi_;
					}
					else
					{
						return (null as Tuple_CWDDWHRXGADEbdaKXCdKbgEfg);
					}
				};
				var as_ = new Tuple_CWDDWHRXGADEbdaKXCdKbgEfg[]
				{
					ar_(),
				};
				bool? at_(Tuple_CWDDWHRXGADEbdaKXCdKbgEfg FinalList)
				{
					var bo_ = context.Operators.Not((bool?)(FinalList is null));

					return bo_;
				};
				var au_ = context.Operators.Where<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>((IEnumerable<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>)as_, at_);
				var av_ = context.Operators.SingletonFrom<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>(au_);

				return av_;
			};
			var n_ = context.Operators.Select<Tuple_GDVcejYEWXWNHUIODacaMaBhV, Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>((IEnumerable<Tuple_GDVcejYEWXWNHUIODacaMaBhV>)l_, m_);
			var o_ = context.Operators.SingletonFrom<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>(n_);

			return o_;
		};
		var g_ = context.Operators.Select<Tuple_DKCCfPXSWPMBNeFXdjEFGiRcF, Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>((IEnumerable<Tuple_DKCCfPXSWPMBNeFXdjEFGiRcF>)e_, f_);
		var h_ = context.Operators.SingletonFrom<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>(g_);

		return h_;
	}

    [CqlDeclaration("Pharmacy Claim With Medication")]
	public IEnumerable<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY> Pharmacy_Claim_With_Medication(IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
	{
		var a_ = this.Pharmacy_Claims(claim);
		string b_(CqlCode p)
		{
			var i_ = p?.code;

			return i_;
		};
		var c_ = context.Operators.Select<CqlCode, string>(MedicationCodes, b_);
		var d_ = new Tuple_FKhUcAPjDECbaDReYbaiLXOHd
		{
			PharmacyClaim = a_,
			MedicationsAsStrings = c_,
		};
		var e_ = new Tuple_FKhUcAPjDECbaDReYbaiLXOHd[]
		{
			d_,
		};
		IEnumerable<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY> f_(Tuple_FKhUcAPjDECbaDReYbaiLXOHd ClaimWithMedication)
		{
			var j_ = ClaimWithMedication?.PharmacyClaim;
			Tuple_GGLURZZjYLMjhaMLVbjKOcMAY k_(Claim Pharmacy)
			{
				var o_ = Pharmacy?.Item;
				bool? p_(Claim.ItemComponent ItemOnLine)
				{
					var w_ = ItemOnLine?.ProductOrService;
					var x_ = FHIRHelpers_4_0_001.ToConcept(w_);
					var y_ = x_?.codes;
					bool? z_(CqlCode LineCode)
					{
						var ac_ = LineCode?.code;
						var ad_ = ClaimWithMedication?.MedicationsAsStrings;
						var ae_ = context.Operators.In<string>(ac_, ad_);

						return ae_;
					};
					var aa_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)y_, z_);
					var ab_ = context.Operators.Exists<CqlCode>(aa_);

					return ab_;
				};
				var q_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)o_, p_);
				var r_ = new Tuple_HSdidNdfHCNCFSUTgBiYLcgXP
				{
					Claim = Pharmacy,
					LineItems = q_,
				};
				var s_ = new Tuple_HSdidNdfHCNCFSUTgBiYLcgXP[]
				{
					r_,
				};
				Tuple_GGLURZZjYLMjhaMLVbjKOcMAY t_(Tuple_HSdidNdfHCNCFSUTgBiYLcgXP LineItemDefinition)
				{
					var af_ = LineItemDefinition?.Claim;
					var ag_ = new Claim[]
					{
						af_,
					};
					Tuple_GGLURZZjYLMjhaMLVbjKOcMAY ah_(Claim ClaimLines)
					{
						var ak_ = ClaimLines?.Item;
						bool? al_(Claim.ItemComponent i)
						{
							var au_ = i?.ProductOrService;
							var av_ = FHIRHelpers_4_0_001.ToConcept(au_);
							var aw_ = av_?.codes;
							bool? ax_(CqlCode LineCode)
							{
								var ba_ = LineCode?.code;
								var bb_ = ClaimWithMedication?.MedicationsAsStrings;
								var bc_ = context.Operators.In<string>(ba_, bb_);

								return bc_;
							};
							var ay_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)aw_, ax_);
							var az_ = context.Operators.Exists<CqlCode>(ay_);

							return az_;
						};
						var am_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ak_, al_);
						Tuple_HDUYFgZGRCJCdTeEcMSVCMQNN an_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDateTime> bd_()
							{
								bool bf_()
								{
									var bg_ = i?.Quantity;
									var bh_ = context.Operators.Not((bool?)(bg_ is null));

									return (bh_ ?? false);
								};
								if (bf_())
								{
									CqlInterval<CqlDateTime> bi_()
									{
										bool bj_()
										{
											var bk_ = i?.Serviced;
											var bl_ = bk_ is Period;

											return bl_;
										};
										if (bj_())
										{
											var bm_ = i?.Serviced;
											var bn_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bm_);
											var bo_ = context.Operators.Start(bn_);
											var bq_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bm_);
											var br_ = context.Operators.Start(bq_);
											var bs_ = i?.Quantity;
											var bt_ = bs_?.ValueElement;
											var bu_ = FHIRHelpers_4_0_001.ToDecimal(bt_);
											var bv_ = context.Operators.Add(br_, new CqlQuantity(bu_, "day"));
											var bw_ = context.Operators.Quantity(1m, "day");
											var bx_ = context.Operators.Subtract(bv_, bw_);
											var by_ = context.Operators.Interval(bo_, bx_, true, true);

											return by_;
										}
										else
										{
											var bz_ = i?.Serviced;
											var ca_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var cc_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var cd_ = i?.Quantity;
											var ce_ = cd_?.ValueElement;
											var cf_ = FHIRHelpers_4_0_001.ToDecimal(ce_);
											var cg_ = context.Operators.Add(cc_, new CqlQuantity(cf_, "day"));
											var ch_ = context.Operators.Quantity(1m, "day");
											var ci_ = context.Operators.Subtract(cg_, ch_);
											var cj_ = context.Operators.Interval(ca_, ci_, true, true);
											var ck_ = cj_?.low;
											var cl_ = context.Operators.ConvertDateToDateTime(ck_);
											var cn_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var cp_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var cr_ = cd_?.ValueElement;
											var cs_ = FHIRHelpers_4_0_001.ToDecimal(cr_);
											var ct_ = context.Operators.Add(cp_, new CqlQuantity(cs_, "day"));
											var cv_ = context.Operators.Subtract(ct_, ch_);
											var cw_ = context.Operators.Interval(cn_, cv_, true, true);
											var cx_ = cw_?.high;
											var cy_ = context.Operators.ConvertDateToDateTime(cx_);
											var da_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var dc_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var de_ = cd_?.ValueElement;
											var df_ = FHIRHelpers_4_0_001.ToDecimal(de_);
											var dg_ = context.Operators.Add(dc_, new CqlQuantity(df_, "day"));
											var di_ = context.Operators.Subtract(dg_, ch_);
											var dj_ = context.Operators.Interval(da_, di_, true, true);
											var dk_ = dj_?.lowClosed;
											var dm_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var do_ = FHIRHelpers_4_0_001.ToDate((bz_ as Date));
											var dq_ = cd_?.ValueElement;
											var dr_ = FHIRHelpers_4_0_001.ToDecimal(dq_);
											var ds_ = context.Operators.Add(do_, new CqlQuantity(dr_, "day"));
											var du_ = context.Operators.Subtract(ds_, ch_);
											var dv_ = context.Operators.Interval(dm_, du_, true, true);
											var dw_ = dv_?.highClosed;
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
							var be_ = new Tuple_HDUYFgZGRCJCdTeEcMSVCMQNN
							{
								DaysSupplyInterval = bd_(),
							};

							return be_;
						};
						var ao_ = context.Operators.Select<Claim.ItemComponent, Tuple_HDUYFgZGRCJCdTeEcMSVCMQNN>(am_, an_);
						var ap_ = new Tuple_fQfNOLePNSNdOZROKRAfMQPE
						{
							CoveredDays = ao_,
						};
						var aq_ = new Tuple_fQfNOLePNSNdOZROKRAfMQPE[]
						{
							ap_,
						};
						Tuple_GGLURZZjYLMjhaMLVbjKOcMAY ar_(Tuple_fQfNOLePNSNdOZROKRAfMQPE ItemCalculation)
						{
							Tuple_GGLURZZjYLMjhaMLVbjKOcMAY dy_()
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
										var ep_ = @this?.Serviced;
										var eq_ = context.Operators.Not((bool?)(ep_ is null));

										return eq_;
									};
									var eg_ = context.Operators.Where<Claim.ItemComponent>(ed_, ef_);
									DataType eh_(Claim.ItemComponent @this)
									{
										var er_ = @this?.Serviced;

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
									CqlInterval<CqlDateTime> em_(Tuple_HDUYFgZGRCJCdTeEcMSVCMQNN d)
									{
										var et_ = d?.DaysSupplyInterval;

										return et_;
									};
									var en_ = context.Operators.Select<Tuple_HDUYFgZGRCJCdTeEcMSVCMQNN, CqlInterval<CqlDateTime>>(el_, em_);
									var eo_ = new Tuple_GGLURZZjYLMjhaMLVbjKOcMAY
									{
										Claim = ec_,
										LineItem = ed_,
										ServicePeriod = ek_,
										CoveredDays = en_,
									};

									return eo_;
								}
								else
								{
									return (null as Tuple_GGLURZZjYLMjhaMLVbjKOcMAY);
								}
							};

							return dy_();
						};
						var as_ = context.Operators.Select<Tuple_fQfNOLePNSNdOZROKRAfMQPE, Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>((IEnumerable<Tuple_fQfNOLePNSNdOZROKRAfMQPE>)aq_, ar_);
						var at_ = context.Operators.SingletonFrom<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(as_);

						return at_;
					};
					var ai_ = context.Operators.Select<Claim, Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>((IEnumerable<Claim>)ag_, ah_);
					var aj_ = context.Operators.SingletonFrom<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(ai_);

					return aj_;
				};
				var u_ = context.Operators.Select<Tuple_HSdidNdfHCNCFSUTgBiYLcgXP, Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>((IEnumerable<Tuple_HSdidNdfHCNCFSUTgBiYLcgXP>)s_, t_);
				var v_ = context.Operators.SingletonFrom<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(u_);

				return v_;
			};
			var l_ = context.Operators.Select<Claim, Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(j_, k_);
			bool? m_(Tuple_GGLURZZjYLMjhaMLVbjKOcMAY FinalList)
			{
				var eu_ = context.Operators.Not((bool?)(FinalList is null));

				return eu_;
			};
			var n_ = context.Operators.Where<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(l_, m_);

			return n_;
		};
		var g_ = context.Operators.Select<Tuple_FKhUcAPjDECbaDReYbaiLXOHd, IEnumerable<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>>((IEnumerable<Tuple_FKhUcAPjDECbaDReYbaiLXOHd>)e_, f_);
		var h_ = context.Operators.SingletonFrom<IEnumerable<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis and Procedure")]
	public IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd> Medical_Claims_With_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var k_ = d?.code;

			return k_;
		};
		var c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p)
		{
			var l_ = p?.code;

			return l_;
		};
		var e_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, d_);
		var f_ = new Tuple_YMFSFZNbUOGiNXDVNeBOchca
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
			ProceduresAsStrings = e_,
		};
		var g_ = new Tuple_YMFSFZNbUOGiNXDVNeBOchca[]
		{
			f_,
		};
		IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd> h_(Tuple_YMFSFZNbUOGiNXDVNeBOchca ClaimWithDiagnosis)
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
						var v_ = DiagnosisLine?.Diagnosis;
						bool? w_(Claim.DiagnosisComponent @this)
						{
							var ak_ = @this?.Diagnosis;
							var al_ = context.Operators.Not((bool?)(ak_ is null));

							return al_;
						};
						var x_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)v_, w_);
						DataType y_(Claim.DiagnosisComponent @this)
						{
							var am_ = @this?.Diagnosis;

							return am_;
						};
						var z_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(x_, y_);
						bool? aa_(object @this)
						{
							var an_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							var ao_ = context.Operators.Not((bool?)(an_ is null));

							return ao_;
						};
						var ab_ = context.Operators.Where<object>((IEnumerable<object>)z_, aa_);
						object ac_(object @this)
						{
							var ap_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return ap_;
						};
						var ad_ = context.Operators.Select<object, object>(ab_, ac_);
						var ae_ = context.Operators.FlattenLateBoundList(ad_);
						Coding af_(object @object) => 
							(Coding)@object;
						var ag_ = context.Operators.Select<object, Coding>(ae_, af_);
						bool? ah_(Coding HeaderCode)
						{
							var aq_ = HeaderCode?.CodeElement;
							var ar_ = aq_?.Value;
							var as_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
							var at_ = context.Operators.In<string>(ar_, as_);

							return at_;
						};
						var ai_ = context.Operators.Where<Coding>(ag_, ah_);
						var aj_ = context.Operators.Exists<Coding>(ai_);

						return aj_;
					};
					var u_ = context.Operators.Where<Claim>(s_, t_);

					return u_;
				}
			};
			var n_ = new Tuple_GDVcejYEWXWNHUIODacaMaBhV
			{
				DiagnosisItems = m_(),
			};
			var o_ = new Tuple_GDVcejYEWXWNHUIODacaMaBhV[]
			{
				n_,
			};
			IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd> p_(Tuple_GDVcejYEWXWNHUIODacaMaBhV ClaimWithProcedure)
			{
				var au_ = ClaimWithProcedure?.DiagnosisItems;
				Tuple_GDUUTAIXZafehWFjcGfNKBcTd av_(Claim ClaimofInterest)
				{
					Claim az_()
					{
						if ((ClaimofInterest is null))
						{
							return null;
						}
						else
						{
							var bf_ = new Claim[]
							{
								ClaimofInterest,
							};
							bool? bg_(Claim ItemOnLine)
							{
								var bj_ = ItemOnLine?.Procedure;
								bool? bk_(Claim.ProcedureComponent @this)
								{
									var cm_ = @this?.Procedure;
									var cn_ = context.Operators.Not((bool?)(cm_ is null));

									return cn_;
								};
								var bl_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)bj_, bk_);
								DataType bm_(Claim.ProcedureComponent @this)
								{
									var co_ = @this?.Procedure;

									return co_;
								};
								var bn_ = context.Operators.Select<Claim.ProcedureComponent, DataType>(bl_, bm_);
								bool? bo_(object @this)
								{
									var cp_ = context.Operators.LateBoundProperty<object>(@this, "coding");
									var cq_ = context.Operators.Not((bool?)(cp_ is null));

									return cq_;
								};
								var bp_ = context.Operators.Where<object>((IEnumerable<object>)bn_, bo_);
								object bq_(object @this)
								{
									var cr_ = context.Operators.LateBoundProperty<object>(@this, "coding");

									return cr_;
								};
								var br_ = context.Operators.Select<object, object>(bp_, bq_);
								var bs_ = context.Operators.FlattenLateBoundList(br_);
								Coding bt_(object @object) => 
									(Coding)@object;
								var bu_ = context.Operators.Select<object, Coding>(bs_, bt_);
								bool? bv_(Coding ProcedureHeaderCode)
								{
									var cs_ = ProcedureHeaderCode?.CodeElement;
									var ct_ = cs_?.Value;
									var cu_ = ClaimWithDiagnosis?.ProceduresAsStrings;
									var cv_ = context.Operators.In<string>(ct_, cu_);

									return cv_;
								};
								var bw_ = context.Operators.Where<Coding>(bu_, bv_);
								var bx_ = context.Operators.Exists<Coding>(bw_);
								var by_ = ItemOnLine?.Item;
								bool? bz_(Claim.ItemComponent @this)
								{
									var cw_ = @this?.ProductOrService;
									var cx_ = context.Operators.Not((bool?)(cw_ is null));

									return cx_;
								};
								var ca_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)by_, bz_);
								CodeableConcept cb_(Claim.ItemComponent @this)
								{
									var cy_ = @this?.ProductOrService;

									return cy_;
								};
								var cc_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(ca_, cb_);
								bool? cd_(CodeableConcept @this)
								{
									var cz_ = @this?.Coding;
									var da_ = context.Operators.Not((bool?)(cz_ is null));

									return da_;
								};
								var ce_ = context.Operators.Where<CodeableConcept>(cc_, cd_);
								List<Coding> cf_(CodeableConcept @this)
								{
									var db_ = @this?.Coding;

									return db_;
								};
								var cg_ = context.Operators.Select<CodeableConcept, List<Coding>>(ce_, cf_);
								var ch_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)cg_);
								bool? ci_(Coding LineCode)
								{
									var dc_ = LineCode?.CodeElement;
									var dd_ = dc_?.Value;
									var de_ = ClaimWithDiagnosis?.ProceduresAsStrings;
									var df_ = context.Operators.In<string>(dd_, de_);

									return df_;
								};
								var cj_ = context.Operators.Where<Coding>(ch_, ci_);
								var ck_ = context.Operators.Exists<Coding>(cj_);
								var cl_ = context.Operators.Or(bx_, ck_);

								return cl_;
							};
							var bh_ = context.Operators.Where<Claim>((IEnumerable<Claim>)bf_, bg_);
							var bi_ = context.Operators.SingletonFrom<Claim>(bh_);

							return bi_;
						}
					};
					var ba_ = new Tuple_CXESjjTOQIGKICAEMDgcfPdJG
					{
						ProcedureItems = az_(),
					};
					var bb_ = new Tuple_CXESjjTOQIGKICAEMDgcfPdJG[]
					{
						ba_,
					};
					Tuple_GDUUTAIXZafehWFjcGfNKBcTd bc_(Tuple_CXESjjTOQIGKICAEMDgcfPdJG HeaderDefinition)
					{
						Tuple_GDUUTAIXZafehWFjcGfNKBcTd dg_()
						{
							bool dh_()
							{
								var di_ = HeaderDefinition?.ProcedureItems;
								var dj_ = context.Operators.Not((bool?)(di_ is null));

								return (dj_ ?? false);
							};
							if (dh_())
							{
								var dk_ = HeaderDefinition?.ProcedureItems;
								var dm_ = dk_?.Item;
								CqlInterval<CqlDateTime> dn_(Claim.ItemComponent NormalDate)
								{
									var dq_ = NormalDate?.Serviced;
									var dr_ = NCQAFHIRBase_1_0_0.Normalize_Interval(dq_);

									return dr_;
								};
								var do_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)dm_, dn_);
								var dp_ = new Tuple_GDUUTAIXZafehWFjcGfNKBcTd
								{
									Claim = dk_,
									ServicePeriod = do_,
								};

								return dp_;
							}
							else
							{
								return (null as Tuple_GDUUTAIXZafehWFjcGfNKBcTd);
							}
						};

						return dg_();
					};
					var bd_ = context.Operators.Select<Tuple_CXESjjTOQIGKICAEMDgcfPdJG, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>((IEnumerable<Tuple_CXESjjTOQIGKICAEMDgcfPdJG>)bb_, bc_);
					var be_ = context.Operators.SingletonFrom<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(bd_);

					return be_;
				};
				var aw_ = context.Operators.Select<Claim, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(au_, av_);
				bool? ax_(Tuple_GDUUTAIXZafehWFjcGfNKBcTd FinalList)
				{
					var ds_ = context.Operators.Not((bool?)(FinalList is null));

					return ds_;
				};
				var ay_ = context.Operators.Where<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(aw_, ax_);

				return ay_;
			};
			var q_ = context.Operators.Select<Tuple_GDVcejYEWXWNHUIODacaMaBhV, IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>((IEnumerable<Tuple_GDVcejYEWXWNHUIODacaMaBhV>)o_, p_);
			var r_ = context.Operators.SingletonFrom<IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(q_);

			return r_;
		};
		var i_ = context.Operators.Select<Tuple_YMFSFZNbUOGiNXDVNeBOchca, IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>((IEnumerable<Tuple_YMFSFZNbUOGiNXDVNeBOchca>)g_, h_);
		var j_ = context.Operators.SingletonFrom<IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis and Procedure")]
	public IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd> Medical_Claims_With_Principal_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var k_ = d?.code;

			return k_;
		};
		var c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p)
		{
			var l_ = p?.code;

			return l_;
		};
		var e_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, d_);
		var f_ = new Tuple_YMFSFZNbUOGiNXDVNeBOchca
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
			ProceduresAsStrings = e_,
		};
		var g_ = new Tuple_YMFSFZNbUOGiNXDVNeBOchca[]
		{
			f_,
		};
		IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd> h_(Tuple_YMFSFZNbUOGiNXDVNeBOchca ClaimWithProcedure)
		{
			var m_ = ClaimWithProcedure?.MedicalClaim;
			Tuple_GDUUTAIXZafehWFjcGfNKBcTd n_(Claim ClaimofInterest)
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
							var ab_ = ItemOnLine?.Item;
							bool? ac_(Claim.ItemComponent @this)
							{
								var be_ = @this?.ProductOrService;
								var bf_ = context.Operators.Not((bool?)(be_ is null));

								return bf_;
							};
							var ad_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ab_, ac_);
							CodeableConcept ae_(Claim.ItemComponent @this)
							{
								var bg_ = @this?.ProductOrService;

								return bg_;
							};
							var af_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(ad_, ae_);
							bool? ag_(CodeableConcept @this)
							{
								var bh_ = @this?.Coding;
								var bi_ = context.Operators.Not((bool?)(bh_ is null));

								return bi_;
							};
							var ah_ = context.Operators.Where<CodeableConcept>(af_, ag_);
							List<Coding> ai_(CodeableConcept @this)
							{
								var bj_ = @this?.Coding;

								return bj_;
							};
							var aj_ = context.Operators.Select<CodeableConcept, List<Coding>>(ah_, ai_);
							var ak_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)aj_);
							bool? al_(Coding LineCode)
							{
								var bk_ = LineCode?.CodeElement;
								var bl_ = bk_?.Value;
								var bm_ = ClaimWithProcedure?.ProceduresAsStrings;
								var bn_ = context.Operators.In<string>(bl_, bm_);

								return bn_;
							};
							var am_ = context.Operators.Where<Coding>(ak_, al_);
							var an_ = context.Operators.Exists<Coding>(am_);
							var ao_ = ItemOnLine?.Procedure;
							bool? ap_(Claim.ProcedureComponent @this)
							{
								var bo_ = @this?.Procedure;
								var bp_ = context.Operators.Not((bool?)(bo_ is null));

								return bp_;
							};
							var aq_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)ao_, ap_);
							DataType ar_(Claim.ProcedureComponent @this)
							{
								var bq_ = @this?.Procedure;

								return bq_;
							};
							var as_ = context.Operators.Select<Claim.ProcedureComponent, DataType>(aq_, ar_);
							bool? at_(object @this)
							{
								var br_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								var bs_ = context.Operators.Not((bool?)(br_ is null));

								return bs_;
							};
							var au_ = context.Operators.Where<object>((IEnumerable<object>)as_, at_);
							object av_(object @this)
							{
								var bt_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return bt_;
							};
							var aw_ = context.Operators.Select<object, object>(au_, av_);
							var ax_ = context.Operators.FlattenLateBoundList(aw_);
							Coding ay_(object @object) => 
								(Coding)@object;
							var az_ = context.Operators.Select<object, Coding>(ax_, ay_);
							bool? ba_(Coding HeaderCode)
							{
								var bu_ = HeaderCode?.CodeElement;
								var bv_ = bu_?.Value;
								var bw_ = ClaimWithProcedure?.ProceduresAsStrings;
								var bx_ = context.Operators.In<string>(bv_, bw_);

								return bx_;
							};
							var bb_ = context.Operators.Where<Coding>(az_, ba_);
							var bc_ = context.Operators.Exists<Coding>(bb_);
							var bd_ = context.Operators.Or(an_, bc_);

							return bd_;
						};
						var z_ = context.Operators.Where<Claim>((IEnumerable<Claim>)x_, y_);
						var aa_ = context.Operators.SingletonFrom<Claim>(z_);

						return aa_;
					}
				};
				var s_ = new Tuple_FYaKYiIDIQCIRBfhZCGRDYQLX
				{
					Claim = ClaimofInterest,
					ProcedureItems = r_(),
				};
				var t_ = new Tuple_FYaKYiIDIQCIRBfhZCGRDYQLX[]
				{
					s_,
				};
				Tuple_GDUUTAIXZafehWFjcGfNKBcTd u_(Tuple_FYaKYiIDIQCIRBfhZCGRDYQLX DiagnosisCheck)
				{
					var by_ = DiagnosisCheck?.ProcedureItems;
					var bz_ = new Claim[]
					{
						by_,
					};
					Tuple_GDUUTAIXZafehWFjcGfNKBcTd ca_(Claim ClaimforDiagnosis)
					{
						var cd_ = ClaimforDiagnosis?.Item;
						Claim ce_()
						{
							if ((ClaimforDiagnosis is null))
							{
								return null;
							}
							else
							{
								var ck_ = new Claim[]
								{
									ClaimforDiagnosis,
								};
								bool? cl_(Claim RightClaim)
								{
									var co_ = RightClaim?.Diagnosis;
									bool? cp_(Claim.DiagnosisComponent RightDiagnosis)
									{
										var cs_ = RightDiagnosis?.SequenceElement;
										var ct_ = context.Operators.Convert<Integer>(cs_);
										var cu_ = FHIRHelpers_4_0_001.ToInteger(ct_);
										var cv_ = context.Operators.Equal(cu_, 1);
										var cw_ = RightDiagnosis?.Diagnosis;
										var cx_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(cw_, "coding");
										bool? cy_(Coding DiagnosisCode)
										{
											var dc_ = DiagnosisCode?.CodeElement;
											var dd_ = dc_?.Value;
											var de_ = ClaimWithProcedure?.DiagnosesAsStrings;
											var df_ = context.Operators.In<string>(dd_, de_);

											return df_;
										};
										var cz_ = context.Operators.Where<Coding>(cx_, cy_);
										var da_ = context.Operators.Exists<Coding>(cz_);
										var db_ = context.Operators.And(cv_, da_);

										return db_;
									};
									var cq_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)co_, cp_);
									var cr_ = context.Operators.Exists<Claim.DiagnosisComponent>(cq_);

									return cr_;
								};
								var cm_ = context.Operators.Where<Claim>((IEnumerable<Claim>)ck_, cl_);
								var cn_ = context.Operators.SingletonFrom<Claim>(cm_);

								return cn_;
							}
						};
						var cf_ = new Tuple_GQgIaRFaPGOSKbMdfSGVEWcNA
						{
							Procedure = (IEnumerable<Claim.ItemComponent>)cd_,
							LineItems = ce_(),
						};
						var cg_ = new Tuple_GQgIaRFaPGOSKbMdfSGVEWcNA[]
						{
							cf_,
						};
						Tuple_GDUUTAIXZafehWFjcGfNKBcTd ch_(Tuple_GQgIaRFaPGOSKbMdfSGVEWcNA LineItemDefinition)
						{
							Tuple_GDUUTAIXZafehWFjcGfNKBcTd dg_()
							{
								bool dh_()
								{
									var di_ = context.Operators.Not((bool?)(LineItemDefinition is null));
									var dj_ = LineItemDefinition?.LineItems;
									var dk_ = context.Operators.Not((bool?)(dj_ is null));
									var dl_ = context.Operators.And(di_, dk_);

									return (dl_ ?? false);
								};
								if (dh_())
								{
									var dm_ = LineItemDefinition?.LineItems;
									var do_ = dm_?.Item;
									CqlInterval<CqlDateTime> dp_(Claim.ItemComponent NormalDate)
									{
										var ds_ = NormalDate?.Serviced;
										var dt_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ds_);

										return dt_;
									};
									var dq_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)do_, dp_);
									var dr_ = new Tuple_GDUUTAIXZafehWFjcGfNKBcTd
									{
										Claim = dm_,
										ServicePeriod = dq_,
									};

									return dr_;
								}
								else
								{
									return (null as Tuple_GDUUTAIXZafehWFjcGfNKBcTd);
								}
							};

							return dg_();
						};
						var ci_ = context.Operators.Select<Tuple_GQgIaRFaPGOSKbMdfSGVEWcNA, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>((IEnumerable<Tuple_GQgIaRFaPGOSKbMdfSGVEWcNA>)cg_, ch_);
						var cj_ = context.Operators.SingletonFrom<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(ci_);

						return cj_;
					};
					var cb_ = context.Operators.Select<Claim, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>((IEnumerable<Claim>)bz_, ca_);
					var cc_ = context.Operators.SingletonFrom<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(cb_);

					return cc_;
				};
				var v_ = context.Operators.Select<Tuple_FYaKYiIDIQCIRBfhZCGRDYQLX, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>((IEnumerable<Tuple_FYaKYiIDIQCIRBfhZCGRDYQLX>)t_, u_);
				var w_ = context.Operators.SingletonFrom<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(v_);

				return w_;
			};
			var o_ = context.Operators.Select<Claim, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(m_, n_);
			bool? p_(Tuple_GDUUTAIXZafehWFjcGfNKBcTd FinalList)
			{
				var du_ = context.Operators.Not((bool?)(FinalList is null));

				return du_;
			};
			var q_ = context.Operators.Where<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(o_, p_);

			return q_;
		};
		var i_ = context.Operators.Select<Tuple_YMFSFZNbUOGiNXDVNeBOchca, IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>((IEnumerable<Tuple_YMFSFZNbUOGiNXDVNeBOchca>)g_, h_);
		var j_ = context.Operators.SingletonFrom<IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis")]
	public IEnumerable<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg> Medical_Claims_With_Principal_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var i_ = d?.code;

			return i_;
		};
		var c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		var d_ = new Tuple_DKCCfPXSWPMBNeFXdjEFGiRcF
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
		};
		var e_ = new Tuple_DKCCfPXSWPMBNeFXdjEFGiRcF[]
		{
			d_,
		};
		IEnumerable<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg> f_(Tuple_DKCCfPXSWPMBNeFXdjEFGiRcF ClaimWithDiagnosis)
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
						var s_ = RightClaim?.Diagnosis;
						bool? t_(Claim.DiagnosisComponent RightDiagnosis)
						{
							var w_ = RightDiagnosis?.SequenceElement;
							var x_ = context.Operators.Convert<Integer>(w_);
							var y_ = FHIRHelpers_4_0_001.ToInteger(x_);
							var z_ = context.Operators.Equal(y_, 1);
							var aa_ = RightDiagnosis?.Diagnosis;
							var ab_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(aa_, "coding");
							bool? ac_(Coding DiagnosisCode)
							{
								var ag_ = DiagnosisCode?.CodeElement;
								var ah_ = ag_?.Value;
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
			var k_ = new Tuple_DBEDLLOihLKGPWLHVWXRKfGdL
			{
				LineItems = j_(),
			};
			var l_ = new Tuple_DBEDLLOihLKGPWLHVWXRKfGdL[]
			{
				k_,
			};
			IEnumerable<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg> m_(Tuple_DBEDLLOihLKGPWLHVWXRKfGdL LineItemDefinition)
			{
				var ak_ = LineItemDefinition?.LineItems;
				Tuple_CWDDWHRXGADEbdaKXCdKbgEfg al_(Claim ClaimWithDiagnosis)
				{
					Tuple_CWDDWHRXGADEbdaKXCdKbgEfg ap_()
					{
						if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null)) ?? false))
						{
							var aq_ = LineItemDefinition?.LineItems;
							bool? as_(Claim @this)
							{
								var ba_ = @this?.Item;
								var bb_ = context.Operators.Not((bool?)(ba_ is null));

								return bb_;
							};
							var at_ = context.Operators.Where<Claim>(aq_, as_);
							List<Claim.ItemComponent> au_(Claim @this)
							{
								var bc_ = @this?.Item;

								return bc_;
							};
							var av_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(at_, au_);
							var aw_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)av_);
							CqlInterval<CqlDateTime> ax_(Claim.ItemComponent NormalDate)
							{
								var bd_ = NormalDate?.Serviced;
								var be_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bd_);

								return be_;
							};
							var ay_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(aw_, ax_);
							var az_ = new Tuple_CWDDWHRXGADEbdaKXCdKbgEfg
							{
								Claim = aq_,
								ServicePeriod = ay_,
							};

							return az_;
						}
						else
						{
							return (null as Tuple_CWDDWHRXGADEbdaKXCdKbgEfg);
						}
					};

					return ap_();
				};
				var am_ = context.Operators.Select<Claim, Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>(ak_, al_);
				bool? an_(Tuple_CWDDWHRXGADEbdaKXCdKbgEfg FinalList)
				{
					var bf_ = context.Operators.Not((bool?)(FinalList is null));

					return bf_;
				};
				var ao_ = context.Operators.Where<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>(am_, an_);

				return ao_;
			};
			var n_ = context.Operators.Select<Tuple_DBEDLLOihLKGPWLHVWXRKfGdL, IEnumerable<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>>((IEnumerable<Tuple_DBEDLLOihLKGPWLHVWXRKfGdL>)l_, m_);
			var o_ = context.Operators.SingletonFrom<IEnumerable<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>>(n_);

			return o_;
		};
		var g_ = context.Operators.Select<Tuple_DKCCfPXSWPMBNeFXdjEFGiRcF, IEnumerable<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>>((IEnumerable<Tuple_DKCCfPXSWPMBNeFXdjEFGiRcF>)e_, f_);
		var h_ = context.Operators.SingletonFrom<IEnumerable<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>>(g_);

		return h_;
	}

    [CqlDeclaration("Get All Professional and Institutional Claims and Claim Responses")]
	public Tuple_BPLeiOPPLaJQZIggaPXFWcaBO Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		var a_ = this.Professional_or_Institutional_Claims_Response(claimResponse);
		var b_ = this.Professional_or_Institutional_Claims(claim);
		var c_ = new Tuple_BPLeiOPPLaJQZIggaPXFWcaBO
		{
			MedicalClaimResponse = a_,
			MedicalClaim = b_,
		};

		return c_;
	}

    [CqlDeclaration("Get All Paid Claim Reponses")]
	public IEnumerable<Tuple_BYXPfHJAafYUZgPBifWFNjLXc> Get_All_Paid_Claim_Reponses(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse ResponseItem)
		{
			var h_ = ResponseItem?.OutcomeElement;
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
		var c_ = new Tuple_DbDPVOODdCjASWRZfBTBPUJKR
		{
			PaidResponse = b_,
		};
		var d_ = new Tuple_DbDPVOODdCjASWRZfBTBPUJKR[]
		{
			c_,
		};
		IEnumerable<Tuple_BYXPfHJAafYUZgPBifWFNjLXc> e_(Tuple_DbDPVOODdCjASWRZfBTBPUJKR ClaimResponse)
		{
			var l_ = ClaimResponse?.PaidResponse;
			Tuple_BYXPfHJAafYUZgPBifWFNjLXc m_(ClaimResponse ClmResp)
			{
				var o_ = ClmResp?.Request;
				var p_ = o_?.ReferenceElement;
				var q_ = FHIRHelpers_4_0_001.ToString(p_);
				var r_ = NCQAFHIRBase_1_0_0.GetId(q_);
				var s_ = ClmResp?.Item;
				bool? t_(ClaimResponse.ItemComponent ResponseItem)
				{
					var w_ = ResponseItem?.Adjudication;
					bool? x_(ClaimResponse.AdjudicationComponent @this)
					{
						var as_ = @this?.Category;
						var at_ = context.Operators.Not((bool?)(as_ is null));

						return at_;
					};
					var y_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)w_, x_);
					CodeableConcept z_(ClaimResponse.AdjudicationComponent @this)
					{
						var au_ = @this?.Category;

						return au_;
					};
					var aa_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, CodeableConcept>(y_, z_);
					bool? ab_(CodeableConcept @this)
					{
						var av_ = @this?.Coding;
						var aw_ = context.Operators.Not((bool?)(av_ is null));

						return aw_;
					};
					var ac_ = context.Operators.Where<CodeableConcept>(aa_, ab_);
					List<Coding> ad_(CodeableConcept @this)
					{
						var ax_ = @this?.Coding;

						return ax_;
					};
					var ae_ = context.Operators.Select<CodeableConcept, List<Coding>>(ac_, ad_);
					var af_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ae_);
					bool? ag_(Coding CategoryItem)
					{
						var ay_ = CategoryItem?.CodeElement;
						var az_ = ay_?.Value;
						var ba_ = context.Operators.Equal(az_, "benefit");

						return ba_;
					};
					var ah_ = context.Operators.Where<Coding>(af_, ag_);
					var ai_ = context.Operators.Exists<Coding>(ah_);
					bool? ak_(ClaimResponse.AdjudicationComponent @this)
					{
						var bb_ = @this?.Amount;
						var bc_ = context.Operators.Not((bool?)(bb_ is null));

						return bc_;
					};
					var al_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)w_, ak_);
					Money am_(ClaimResponse.AdjudicationComponent @this)
					{
						var bd_ = @this?.Amount;

						return bd_;
					};
					var an_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, Money>(al_, am_);
					bool? ao_(Money DollarAmount)
					{
						var be_ = DollarAmount?.ValueElement;
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
				var v_ = new Tuple_BYXPfHJAafYUZgPBifWFNjLXc
				{
					Response = ClmResp,
					ResponseID = r_,
					LineItems = u_,
				};

				return v_;
			};
			var n_ = context.Operators.Select<ClaimResponse, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(l_, m_);

			return n_;
		};
		var f_ = context.Operators.Select<Tuple_DbDPVOODdCjASWRZfBTBPUJKR, IEnumerable<Tuple_BYXPfHJAafYUZgPBifWFNjLXc>>((IEnumerable<Tuple_DbDPVOODdCjASWRZfBTBPUJKR>)d_, e_);
		var g_ = context.Operators.SingletonFrom<IEnumerable<Tuple_BYXPfHJAafYUZgPBifWFNjLXc>>(f_);

		return g_;
	}

    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
	public IEnumerable<Tuple_EFDOJaOgOPCDJDhPijASNAPMd> Get_All_Claims_With_Procedure_and_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			var e_ = AllClaims?.Item;
			bool? f_(Claim.ItemComponent @this)
			{
				var ah_ = @this?.ProductOrService;
				var ai_ = context.Operators.Not((bool?)(ah_ is null));

				return ai_;
			};
			var g_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)e_, f_);
			CodeableConcept h_(Claim.ItemComponent @this)
			{
				var aj_ = @this?.ProductOrService;

				return aj_;
			};
			var i_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(g_, h_);
			bool? j_(CodeableConcept @this)
			{
				var ak_ = @this?.Coding;
				var al_ = context.Operators.Not((bool?)(ak_ is null));

				return al_;
			};
			var k_ = context.Operators.Where<CodeableConcept>(i_, j_);
			List<Coding> l_(CodeableConcept @this)
			{
				var am_ = @this?.Coding;

				return am_;
			};
			var m_ = context.Operators.Select<CodeableConcept, List<Coding>>(k_, l_);
			var n_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)m_);
			bool? o_(Coding ProductOrServiceCode)
			{
				var an_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var ao_ = context.Operators.In<CqlCode>(an_, ProductOrServiceValueSet);

				return ao_;
			};
			var p_ = context.Operators.Where<Coding>(n_, o_);
			var q_ = context.Operators.Exists<Coding>(p_);
			var r_ = AllClaims?.Diagnosis;
			bool? s_(Claim.DiagnosisComponent @this)
			{
				var ap_ = @this?.Diagnosis;
				var aq_ = context.Operators.Not((bool?)(ap_ is null));

				return aq_;
			};
			var t_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)r_, s_);
			DataType u_(Claim.DiagnosisComponent @this)
			{
				var ar_ = @this?.Diagnosis;

				return ar_;
			};
			var v_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(t_, u_);
			bool? w_(object @this)
			{
				var as_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				var at_ = context.Operators.Not((bool?)(as_ is null));

				return at_;
			};
			var x_ = context.Operators.Where<object>((IEnumerable<object>)v_, w_);
			object y_(object @this)
			{
				var au_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return au_;
			};
			var z_ = context.Operators.Select<object, object>(x_, y_);
			var aa_ = context.Operators.FlattenLateBoundList(z_);
			Coding ab_(object @object) => 
				(Coding)@object;
			var ac_ = context.Operators.Select<object, Coding>(aa_, ab_);
			bool? ad_(Coding DiagnosisCode)
			{
				var av_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
				var aw_ = context.Operators.In<CqlCode>(av_, DiagnosisValueSet);

				return aw_;
			};
			var ae_ = context.Operators.Where<Coding>(ac_, ad_);
			var af_ = context.Operators.Exists<Coding>(ae_);
			var ag_ = context.Operators.And(q_, af_);

			return ag_;
		};
		var b_ = context.Operators.Where<Claim>(claim, a_);
		Tuple_EFDOJaOgOPCDJDhPijASNAPMd c_(Claim ProcedureClaims)
		{
			var ax_ = ProcedureClaims?.IdElement;
			var ay_ = ProcedureClaims?.Item;
			bool? az_(Claim.ItemComponent ResponseItem)
			{
				var bc_ = ResponseItem?.ProductOrService;
				var bd_ = bc_?.Coding;
				bool? be_(Coding ProductOrServiceCode)
				{
					var bh_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var bi_ = context.Operators.In<CqlCode>(bh_, ProductOrServiceValueSet);

					return bi_;
				};
				var bf_ = context.Operators.Where<Coding>((IEnumerable<Coding>)bd_, be_);
				var bg_ = context.Operators.Exists<Coding>(bf_);

				return bg_;
			};
			var ba_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ay_, az_);
			var bb_ = new Tuple_EFDOJaOgOPCDJDhPijASNAPMd
			{
				ClaimofInterest = ProcedureClaims,
				ClaimID = ax_,
				LineItems = ba_,
			};

			return bb_;
		};
		var d_ = context.Operators.Select<Claim, Tuple_EFDOJaOgOPCDJDhPijASNAPMd>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services and Conditions")]
	public Tuple_FCOUVKRRWVHcKiBDUdGgLciKR Get_Corresponding_Claim_for_Services_and_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		var c_ = new Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE
		{
			PaidMedicalClaimResponse = a_,
			MedicalClaim = b_,
		};
		var d_ = new Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE[]
		{
			c_,
		};
		Tuple_FCOUVKRRWVHcKiBDUdGgLciKR e_(Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE ClaimAndResponse)
		{
			var h_ = ClaimAndResponse?.MedicalClaim;
			Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT i_(Tuple_EFDOJaOgOPCDJDhPijASNAPMd medClaim)
			{
				var p_ = medClaim?.LineItems;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					var t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<Tuple_BYXPfHJAafYUZgPBifWFNjLXc> u_(Tuple_BYXPfHJAafYUZgPBifWFNjLXc pClaim)
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
							var af_ = ae_?.Request;
							var ag_ = af_?.ReferenceElement;
							var ah_ = FHIRHelpers_4_0_001.ToString(ag_);
							var ai_ = NCQAFHIRBase_1_0_0.GetId(ah_);
							var aj_ = context.Operators.Equal(ad_, ai_);
							var ak_ = medClaimLineItem?.SequenceElement;
							var al_ = context.Operators.Convert<Integer>(ak_);
							var am_ = pClaimLineItem?.ItemSequenceElement;
							var an_ = context.Operators.Convert<Integer>(am_);
							var ao_ = context.Operators.Equal(al_, an_);
							var ap_ = context.Operators.And(aj_, ao_);

							return ap_;
						};
						var z_ = context.Operators.Where<ClaimResponse.ItemComponent>(x_, y_);
						Tuple_BYXPfHJAafYUZgPBifWFNjLXc aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var ab_ = context.Operators.Select<ClaimResponse.ItemComponent, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(z_, aa_);

						return ab_;
					};
					var v_ = context.Operators.SelectMany<Tuple_BYXPfHJAafYUZgPBifWFNjLXc, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(t_, u_);
					var w_ = context.Operators.Exists<Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(v_);

					return w_;
				};
				var r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
				var s_ = new Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT
				{
					PaidClaim = medClaim,
					ClaimItem = r_,
				};

				return s_;
			};
			var j_ = context.Operators.Select<Tuple_EFDOJaOgOPCDJDhPijASNAPMd, Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(h_, i_);
			var k_ = new Tuple_GUibhjYMgjAQISFDJORUOccJC
			{
				AggregateClaim = j_,
			};
			var l_ = new Tuple_GUibhjYMgjAQISFDJORUOccJC[]
			{
				k_,
			};
			Tuple_FCOUVKRRWVHcKiBDUdGgLciKR m_(Tuple_GUibhjYMgjAQISFDJORUOccJC ClaimWithPaidResponse)
			{
				Tuple_FCOUVKRRWVHcKiBDUdGgLciKR au_()
				{
					bool az_()
					{
						var ba_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bb_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var bh_ = @this?.ClaimItem;
							var bi_ = context.Operators.Not((bool?)(bh_ is null));

							return bi_;
						};
						var bc_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ba_, bb_);
						IEnumerable<Claim.ItemComponent> bd_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var bj_ = @this?.ClaimItem;

							return bj_;
						};
						var be_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
						var bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
						var bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);

						return (bg_ ?? false);
					};
					if (az_())
					{
						var bk_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bl_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var by_ = @this?.PaidClaim;
							var bz_ = context.Operators.Not((bool?)(by_ is null));

							return bz_;
						};
						var bm_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(bk_, bl_);
						Tuple_EFDOJaOgOPCDJDhPijASNAPMd bn_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var ca_ = @this?.PaidClaim;

							return ca_;
						};
						var bo_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, Tuple_EFDOJaOgOPCDJDhPijASNAPMd>(bm_, bn_);
						bool? bq_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var cb_ = @this?.ClaimItem;
							var cc_ = context.Operators.Not((bool?)(cb_ is null));

							return cc_;
						};
						var br_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(bk_, bq_);
						IEnumerable<Claim.ItemComponent> bs_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var cd_ = @this?.ClaimItem;

							return cd_;
						};
						var bt_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, IEnumerable<Claim.ItemComponent>>(br_, bs_);
						var bu_ = context.Operators.Flatten<Claim.ItemComponent>(bt_);
						CqlInterval<CqlDateTime> bv_(Claim.ItemComponent PaidItem)
						{
							var ce_ = PaidItem?.Serviced;
							var cf_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ce_);

							return cf_;
						};
						var bw_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bu_, bv_);
						var bx_ = new Tuple_FCOUVKRRWVHcKiBDUdGgLciKR
						{
							originalClaim = bo_,
							ServicePeriod = bw_,
						};

						return bx_;
					}
					else
					{
						return (null as Tuple_FCOUVKRRWVHcKiBDUdGgLciKR);
					}
				};
				var av_ = new Tuple_FCOUVKRRWVHcKiBDUdGgLciKR[]
				{
					au_(),
				};
				bool? aw_(Tuple_FCOUVKRRWVHcKiBDUdGgLciKR FinalList)
				{
					var cg_ = context.Operators.Not((bool?)(FinalList is null));

					return cg_;
				};
				var ax_ = context.Operators.Where<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>((IEnumerable<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>)av_, aw_);
				var ay_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(ax_);

				return ay_;
			};
			var n_ = context.Operators.Select<Tuple_GUibhjYMgjAQISFDJORUOccJC, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>((IEnumerable<Tuple_GUibhjYMgjAQISFDJORUOccJC>)l_, m_);
			var o_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(n_);

			return o_;
		};
		var f_ = context.Operators.Select<Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>((IEnumerable<Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE>)d_, e_);
		var g_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Service and Condition")]
	public Tuple_FCOUVKRRWVHcKiBDUdGgLciKR Get_Paid_Claims_for_Provided_Service_and_Condition(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuple_BPLeiOPPLaJQZIggaPXFWcaBO[]
		{
			a_,
		};
		Tuple_FCOUVKRRWVHcKiBDUdGgLciKR c_(Tuple_BPLeiOPPLaJQZIggaPXFWcaBO MedicalClaimAndResponse)
		{
			Tuple_FCOUVKRRWVHcKiBDUdGgLciKR j_()
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
					return (null as Tuple_FCOUVKRRWVHcKiBDUdGgLciKR);
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
		var d_ = context.Operators.Select<Tuple_BPLeiOPPLaJQZIggaPXFWcaBO, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>((IEnumerable<Tuple_BPLeiOPPLaJQZIggaPXFWcaBO>)b_, c_);
		var e_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(d_);
		var f_ = new Tuple_FCOUVKRRWVHcKiBDUdGgLciKR[]
		{
			e_,
		};
		bool? g_(Tuple_FCOUVKRRWVHcKiBDUdGgLciKR FinalList)
		{
			var r_ = context.Operators.Not((bool?)(FinalList is null));

			return r_;
		};
		var h_ = context.Operators.Where<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>((IEnumerable<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>)f_, g_);
		var i_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(h_);

		return i_;
	}

    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
	public IEnumerable<Tuple_EFDOJaOgOPCDJDhPijASNAPMd> Get_All_Claims_With_Procedure_or_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			var e_ = AllClaims?.Item;
			bool? f_(Claim.ItemComponent @this)
			{
				var ah_ = @this?.ProductOrService;
				var ai_ = context.Operators.Not((bool?)(ah_ is null));

				return ai_;
			};
			var g_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)e_, f_);
			CodeableConcept h_(Claim.ItemComponent @this)
			{
				var aj_ = @this?.ProductOrService;

				return aj_;
			};
			var i_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(g_, h_);
			bool? j_(CodeableConcept @this)
			{
				var ak_ = @this?.Coding;
				var al_ = context.Operators.Not((bool?)(ak_ is null));

				return al_;
			};
			var k_ = context.Operators.Where<CodeableConcept>(i_, j_);
			List<Coding> l_(CodeableConcept @this)
			{
				var am_ = @this?.Coding;

				return am_;
			};
			var m_ = context.Operators.Select<CodeableConcept, List<Coding>>(k_, l_);
			var n_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)m_);
			bool? o_(Coding ProductOrServiceCode)
			{
				var an_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var ao_ = context.Operators.In<CqlCode>(an_, ProductOrServiceValueSet);

				return ao_;
			};
			var p_ = context.Operators.Where<Coding>(n_, o_);
			var q_ = context.Operators.Exists<Coding>(p_);
			var r_ = AllClaims?.Diagnosis;
			bool? s_(Claim.DiagnosisComponent @this)
			{
				var ap_ = @this?.Diagnosis;
				var aq_ = context.Operators.Not((bool?)(ap_ is null));

				return aq_;
			};
			var t_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)r_, s_);
			DataType u_(Claim.DiagnosisComponent @this)
			{
				var ar_ = @this?.Diagnosis;

				return ar_;
			};
			var v_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(t_, u_);
			bool? w_(object @this)
			{
				var as_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				var at_ = context.Operators.Not((bool?)(as_ is null));

				return at_;
			};
			var x_ = context.Operators.Where<object>((IEnumerable<object>)v_, w_);
			object y_(object @this)
			{
				var au_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return au_;
			};
			var z_ = context.Operators.Select<object, object>(x_, y_);
			var aa_ = context.Operators.FlattenLateBoundList(z_);
			Coding ab_(object @object) => 
				(Coding)@object;
			var ac_ = context.Operators.Select<object, Coding>(aa_, ab_);
			bool? ad_(Coding DiagnosisCode)
			{
				var av_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
				var aw_ = context.Operators.In<CqlCode>(av_, DiagnosisValueSet);

				return aw_;
			};
			var ae_ = context.Operators.Where<Coding>(ac_, ad_);
			var af_ = context.Operators.Exists<Coding>(ae_);
			var ag_ = context.Operators.Or(q_, af_);

			return ag_;
		};
		var b_ = context.Operators.Where<Claim>(claim, a_);
		Tuple_EFDOJaOgOPCDJDhPijASNAPMd c_(Claim ProcedureClaims)
		{
			Tuple_EFDOJaOgOPCDJDhPijASNAPMd ax_()
			{
				bool ay_()
				{
					var az_ = ProcedureClaims?.Item;
					bool? ba_(Claim.ItemComponent ResponseItem)
					{
						var bd_ = ResponseItem?.ProductOrService;
						var be_ = bd_?.Coding;
						bool? bf_(Coding ProductOrServiceCode)
						{
							var bi_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
							var bj_ = context.Operators.In<CqlCode>(bi_, ProductOrServiceValueSet);

							return bj_;
						};
						var bg_ = context.Operators.Where<Coding>((IEnumerable<Coding>)be_, bf_);
						var bh_ = context.Operators.Exists<Coding>(bg_);

						return bh_;
					};
					var bb_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)az_, ba_);
					var bc_ = context.Operators.Exists<Claim.ItemComponent>(bb_);

					return (bc_ ?? false);
				};
				if (ay_())
				{
					var bk_ = ProcedureClaims?.IdElement;
					var bl_ = ProcedureClaims?.Item;
					bool? bm_(Claim.ItemComponent ResponseItem)
					{
						var bp_ = ResponseItem?.ProductOrService;
						var bq_ = bp_?.Coding;
						bool? br_(Coding ProductOrServiceCode)
						{
							var bu_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
							var bv_ = context.Operators.In<CqlCode>(bu_, ProductOrServiceValueSet);

							return bv_;
						};
						var bs_ = context.Operators.Where<Coding>((IEnumerable<Coding>)bq_, br_);
						var bt_ = context.Operators.Exists<Coding>(bs_);

						return bt_;
					};
					var bn_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bl_, bm_);
					var bo_ = new Tuple_EFDOJaOgOPCDJDhPijASNAPMd
					{
						ClaimofInterest = ProcedureClaims,
						ClaimID = bk_,
						LineItems = bn_,
					};

					return bo_;
				}
				else
				{
					var bw_ = ProcedureClaims?.IdElement;
					var bx_ = ProcedureClaims?.Item;
					bool? by_(Claim.ItemComponent ResponseItem)
					{
						var cb_ = ResponseItem?.SequenceElement;
						var cc_ = context.Operators.Convert<Integer>(cb_);
						var cd_ = cc_?.Value;
						var ce_ = context.Operators.Equal(cd_, 1);

						return ce_;
					};
					var bz_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bx_, by_);
					var ca_ = new Tuple_EFDOJaOgOPCDJDhPijASNAPMd
					{
						ClaimofInterest = ProcedureClaims,
						ClaimID = bw_,
						LineItems = bz_,
					};

					return ca_;
				}
			};

			return ax_();
		};
		var d_ = context.Operators.Select<Claim, Tuple_EFDOJaOgOPCDJDhPijASNAPMd>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services or Conditions")]
	public Tuple_FCOUVKRRWVHcKiBDUdGgLciKR Get_Corresponding_Claim_for_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		var c_ = new Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE
		{
			PaidMedicalClaimResponse = a_,
			MedicalClaim = b_,
		};
		var d_ = new Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE[]
		{
			c_,
		};
		Tuple_FCOUVKRRWVHcKiBDUdGgLciKR e_(Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE ClaimAndResponse)
		{
			var h_ = ClaimAndResponse?.MedicalClaim;
			Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT i_(Tuple_EFDOJaOgOPCDJDhPijASNAPMd medClaim)
			{
				var p_ = medClaim?.LineItems;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					var t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<Tuple_BYXPfHJAafYUZgPBifWFNjLXc> u_(Tuple_BYXPfHJAafYUZgPBifWFNjLXc pClaim)
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
							var af_ = ae_?.Request;
							var ag_ = af_?.ReferenceElement;
							var ah_ = FHIRHelpers_4_0_001.ToString(ag_);
							var ai_ = NCQAFHIRBase_1_0_0.GetId(ah_);
							var aj_ = context.Operators.Equal(ad_, ai_);
							var ak_ = medClaimLineItem?.SequenceElement;
							var al_ = context.Operators.Convert<Integer>(ak_);
							var am_ = pClaimLineItem?.ItemSequenceElement;
							var an_ = context.Operators.Convert<Integer>(am_);
							var ao_ = context.Operators.Equal(al_, an_);
							var ap_ = context.Operators.And(aj_, ao_);

							return ap_;
						};
						var z_ = context.Operators.Where<ClaimResponse.ItemComponent>(x_, y_);
						Tuple_BYXPfHJAafYUZgPBifWFNjLXc aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var ab_ = context.Operators.Select<ClaimResponse.ItemComponent, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(z_, aa_);

						return ab_;
					};
					var v_ = context.Operators.SelectMany<Tuple_BYXPfHJAafYUZgPBifWFNjLXc, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(t_, u_);
					var w_ = context.Operators.Exists<Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(v_);

					return w_;
				};
				var r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
				var s_ = new Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT
				{
					PaidClaim = medClaim,
					ClaimItem = r_,
				};

				return s_;
			};
			var j_ = context.Operators.Select<Tuple_EFDOJaOgOPCDJDhPijASNAPMd, Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(h_, i_);
			var k_ = new Tuple_GUibhjYMgjAQISFDJORUOccJC
			{
				AggregateClaim = j_,
			};
			var l_ = new Tuple_GUibhjYMgjAQISFDJORUOccJC[]
			{
				k_,
			};
			Tuple_FCOUVKRRWVHcKiBDUdGgLciKR m_(Tuple_GUibhjYMgjAQISFDJORUOccJC ClaimWithPaidResponse)
			{
				Tuple_FCOUVKRRWVHcKiBDUdGgLciKR au_()
				{
					bool az_()
					{
						var ba_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bb_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var bh_ = @this?.ClaimItem;
							var bi_ = context.Operators.Not((bool?)(bh_ is null));

							return bi_;
						};
						var bc_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ba_, bb_);
						IEnumerable<Claim.ItemComponent> bd_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var bj_ = @this?.ClaimItem;

							return bj_;
						};
						var be_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
						var bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
						var bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);

						return (bg_ ?? false);
					};
					if (az_())
					{
						var bk_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bl_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var by_ = @this?.PaidClaim;
							var bz_ = context.Operators.Not((bool?)(by_ is null));

							return bz_;
						};
						var bm_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(bk_, bl_);
						Tuple_EFDOJaOgOPCDJDhPijASNAPMd bn_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var ca_ = @this?.PaidClaim;

							return ca_;
						};
						var bo_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, Tuple_EFDOJaOgOPCDJDhPijASNAPMd>(bm_, bn_);
						bool? bq_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var cb_ = @this?.ClaimItem;
							var cc_ = context.Operators.Not((bool?)(cb_ is null));

							return cc_;
						};
						var br_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(bk_, bq_);
						IEnumerable<Claim.ItemComponent> bs_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var cd_ = @this?.ClaimItem;

							return cd_;
						};
						var bt_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, IEnumerable<Claim.ItemComponent>>(br_, bs_);
						var bu_ = context.Operators.Flatten<Claim.ItemComponent>(bt_);
						CqlInterval<CqlDateTime> bv_(Claim.ItemComponent PaidItem)
						{
							var ce_ = PaidItem?.Serviced;
							var cf_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ce_);

							return cf_;
						};
						var bw_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bu_, bv_);
						var bx_ = new Tuple_FCOUVKRRWVHcKiBDUdGgLciKR
						{
							originalClaim = bo_,
							ServicePeriod = bw_,
						};

						return bx_;
					}
					else
					{
						return (null as Tuple_FCOUVKRRWVHcKiBDUdGgLciKR);
					}
				};
				var av_ = new Tuple_FCOUVKRRWVHcKiBDUdGgLciKR[]
				{
					au_(),
				};
				bool? aw_(Tuple_FCOUVKRRWVHcKiBDUdGgLciKR FinalList)
				{
					var cg_ = context.Operators.Not((bool?)(FinalList is null));

					return cg_;
				};
				var ax_ = context.Operators.Where<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>((IEnumerable<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>)av_, aw_);
				var ay_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(ax_);

				return ay_;
			};
			var n_ = context.Operators.Select<Tuple_GUibhjYMgjAQISFDJORUOccJC, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>((IEnumerable<Tuple_GUibhjYMgjAQISFDJORUOccJC>)l_, m_);
			var o_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(n_);

			return o_;
		};
		var f_ = context.Operators.Select<Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>((IEnumerable<Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE>)d_, e_);
		var g_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services or Conditions")]
	public Tuple_FCOUVKRRWVHcKiBDUdGgLciKR Get_Paid_Claims_for_Provided_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuple_BPLeiOPPLaJQZIggaPXFWcaBO[]
		{
			a_,
		};
		Tuple_FCOUVKRRWVHcKiBDUdGgLciKR c_(Tuple_BPLeiOPPLaJQZIggaPXFWcaBO MedicalClaimAndResponse)
		{
			Tuple_FCOUVKRRWVHcKiBDUdGgLciKR f_()
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
					return (null as Tuple_FCOUVKRRWVHcKiBDUdGgLciKR);
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
		var d_ = context.Operators.Select<Tuple_BPLeiOPPLaJQZIggaPXFWcaBO, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>((IEnumerable<Tuple_BPLeiOPPLaJQZIggaPXFWcaBO>)b_, c_);
		var e_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(d_);

		return e_;
	}

    [CqlDeclaration("Get All Claims With Procedure Only")]
	public IEnumerable<Tuple_EFDOJaOgOPCDJDhPijASNAPMd> Get_All_Claims_With_Procedure_Only(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			var e_ = AllClaims?.Item;
			bool? f_(Claim.ItemComponent @this)
			{
				var r_ = @this?.ProductOrService;
				var s_ = context.Operators.Not((bool?)(r_ is null));

				return s_;
			};
			var g_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)e_, f_);
			CodeableConcept h_(Claim.ItemComponent @this)
			{
				var t_ = @this?.ProductOrService;

				return t_;
			};
			var i_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(g_, h_);
			bool? j_(CodeableConcept @this)
			{
				var u_ = @this?.Coding;
				var v_ = context.Operators.Not((bool?)(u_ is null));

				return v_;
			};
			var k_ = context.Operators.Where<CodeableConcept>(i_, j_);
			List<Coding> l_(CodeableConcept @this)
			{
				var w_ = @this?.Coding;

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
		Tuple_EFDOJaOgOPCDJDhPijASNAPMd c_(Claim AllClaims)
		{
			var z_ = AllClaims?.IdElement;
			var aa_ = AllClaims?.Item;
			bool? ab_(Claim.ItemComponent ResponseItem)
			{
				var ae_ = ResponseItem?.ProductOrService;
				var af_ = ae_?.Coding;
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
			var ad_ = new Tuple_EFDOJaOgOPCDJDhPijASNAPMd
			{
				ClaimofInterest = AllClaims,
				ClaimID = z_,
				LineItems = ac_,
			};

			return ad_;
		};
		var d_ = context.Operators.Select<Claim, Tuple_EFDOJaOgOPCDJDhPijASNAPMd>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services Only")]
	public Tuple_FCOUVKRRWVHcKiBDUdGgLciKR Get_Corresponding_Claim_for_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_Only(claim, ProductOrServiceValueSet);
		var c_ = new Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE
		{
			PaidMedicalClaimResponse = a_,
			MedicalClaim = b_,
		};
		var d_ = new Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE[]
		{
			c_,
		};
		Tuple_FCOUVKRRWVHcKiBDUdGgLciKR e_(Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE ClaimAndResponse)
		{
			var h_ = ClaimAndResponse?.MedicalClaim;
			Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT i_(Tuple_EFDOJaOgOPCDJDhPijASNAPMd medClaim)
			{
				var p_ = medClaim?.LineItems;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					var t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<Tuple_BYXPfHJAafYUZgPBifWFNjLXc> u_(Tuple_BYXPfHJAafYUZgPBifWFNjLXc pClaim)
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
							var af_ = ae_?.Request;
							var ag_ = af_?.ReferenceElement;
							var ah_ = FHIRHelpers_4_0_001.ToString(ag_);
							var ai_ = NCQAFHIRBase_1_0_0.GetId(ah_);
							var aj_ = context.Operators.Equal(ad_, ai_);
							var ak_ = medClaimLineItem?.SequenceElement;
							var al_ = context.Operators.Convert<Integer>(ak_);
							var am_ = pClaimLineItem?.ItemSequenceElement;
							var an_ = context.Operators.Convert<Integer>(am_);
							var ao_ = context.Operators.Equal(al_, an_);
							var ap_ = context.Operators.And(aj_, ao_);

							return ap_;
						};
						var z_ = context.Operators.Where<ClaimResponse.ItemComponent>(x_, y_);
						Tuple_BYXPfHJAafYUZgPBifWFNjLXc aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var ab_ = context.Operators.Select<ClaimResponse.ItemComponent, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(z_, aa_);

						return ab_;
					};
					var v_ = context.Operators.SelectMany<Tuple_BYXPfHJAafYUZgPBifWFNjLXc, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(t_, u_);
					var w_ = context.Operators.Exists<Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(v_);

					return w_;
				};
				var r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
				var s_ = new Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT
				{
					PaidClaim = medClaim,
					ClaimItem = r_,
				};

				return s_;
			};
			var j_ = context.Operators.Select<Tuple_EFDOJaOgOPCDJDhPijASNAPMd, Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(h_, i_);
			var k_ = new Tuple_GUibhjYMgjAQISFDJORUOccJC
			{
				AggregateClaim = j_,
			};
			var l_ = new Tuple_GUibhjYMgjAQISFDJORUOccJC[]
			{
				k_,
			};
			Tuple_FCOUVKRRWVHcKiBDUdGgLciKR m_(Tuple_GUibhjYMgjAQISFDJORUOccJC ClaimWithPaidResponse)
			{
				Tuple_FCOUVKRRWVHcKiBDUdGgLciKR au_()
				{
					bool az_()
					{
						var ba_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bb_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var bh_ = @this?.ClaimItem;
							var bi_ = context.Operators.Not((bool?)(bh_ is null));

							return bi_;
						};
						var bc_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ba_, bb_);
						IEnumerable<Claim.ItemComponent> bd_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var bj_ = @this?.ClaimItem;

							return bj_;
						};
						var be_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
						var bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
						var bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);

						return (bg_ ?? false);
					};
					if (az_())
					{
						var bk_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bl_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var by_ = @this?.PaidClaim;
							var bz_ = context.Operators.Not((bool?)(by_ is null));

							return bz_;
						};
						var bm_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(bk_, bl_);
						Tuple_EFDOJaOgOPCDJDhPijASNAPMd bn_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var ca_ = @this?.PaidClaim;

							return ca_;
						};
						var bo_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, Tuple_EFDOJaOgOPCDJDhPijASNAPMd>(bm_, bn_);
						bool? bq_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var cb_ = @this?.ClaimItem;
							var cc_ = context.Operators.Not((bool?)(cb_ is null));

							return cc_;
						};
						var br_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(bk_, bq_);
						IEnumerable<Claim.ItemComponent> bs_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var cd_ = @this?.ClaimItem;

							return cd_;
						};
						var bt_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, IEnumerable<Claim.ItemComponent>>(br_, bs_);
						var bu_ = context.Operators.Flatten<Claim.ItemComponent>(bt_);
						CqlInterval<CqlDateTime> bv_(Claim.ItemComponent PaidItem)
						{
							var ce_ = PaidItem?.Serviced;
							var cf_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ce_);

							return cf_;
						};
						var bw_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bu_, bv_);
						var bx_ = new Tuple_FCOUVKRRWVHcKiBDUdGgLciKR
						{
							originalClaim = bo_,
							ServicePeriod = bw_,
						};

						return bx_;
					}
					else
					{
						return (null as Tuple_FCOUVKRRWVHcKiBDUdGgLciKR);
					}
				};
				var av_ = new Tuple_FCOUVKRRWVHcKiBDUdGgLciKR[]
				{
					au_(),
				};
				bool? aw_(Tuple_FCOUVKRRWVHcKiBDUdGgLciKR FinalList)
				{
					var cg_ = context.Operators.Not((bool?)(FinalList is null));

					return cg_;
				};
				var ax_ = context.Operators.Where<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>((IEnumerable<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>)av_, aw_);
				var ay_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(ax_);

				return ay_;
			};
			var n_ = context.Operators.Select<Tuple_GUibhjYMgjAQISFDJORUOccJC, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>((IEnumerable<Tuple_GUibhjYMgjAQISFDJORUOccJC>)l_, m_);
			var o_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(n_);

			return o_;
		};
		var f_ = context.Operators.Select<Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>((IEnumerable<Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE>)d_, e_);
		var g_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services Only")]
	public Tuple_FCOUVKRRWVHcKiBDUdGgLciKR Get_Paid_Claims_for_Provided_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuple_BPLeiOPPLaJQZIggaPXFWcaBO[]
		{
			a_,
		};
		Tuple_FCOUVKRRWVHcKiBDUdGgLciKR c_(Tuple_BPLeiOPPLaJQZIggaPXFWcaBO MedicalClaimAndResponse)
		{
			Tuple_FCOUVKRRWVHcKiBDUdGgLciKR f_()
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
					return (null as Tuple_FCOUVKRRWVHcKiBDUdGgLciKR);
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
		var d_ = context.Operators.Select<Tuple_BPLeiOPPLaJQZIggaPXFWcaBO, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>((IEnumerable<Tuple_BPLeiOPPLaJQZIggaPXFWcaBO>)b_, c_);
		var e_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(d_);

		return e_;
	}

    [CqlDeclaration("Get All Pharmacy Claims and Claim Responses")]
	public Tuple_EGPWWEihGWWSCCiZLgdcFLIcD Get_All_Pharmacy_Claims_and_Claim_Responses(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		var a_ = this.Pharmacy_Claims_Response(claimResponse);
		var b_ = this.Pharmacy_Claims(claim);
		var c_ = new Tuple_EGPWWEihGWWSCCiZLgdcFLIcD
		{
			PharmacyClaimResponse = a_,
			PharmacyClaim = b_,
		};

		return c_;
	}

    [CqlDeclaration("Get Corresponding Claim for Pharmacy Services")]
	public Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV Get_Corresponding_Claim_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Pharmacy_Claim_With_Medication(claim, ProductOrServiceValueSet);
		var c_ = new Tuple_ETbUUAbGJFCcYLGFaEAgMaiBj
		{
			PaidPharmacyClaimResponse = a_,
			MedicalClaim = b_,
		};
		var d_ = new Tuple_ETbUUAbGJFCcYLGFaEAgMaiBj[]
		{
			c_,
		};
		Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV e_(Tuple_ETbUUAbGJFCcYLGFaEAgMaiBj ClaimAndResponse)
		{
			var h_ = ClaimAndResponse?.MedicalClaim;
			Tuple_FNLZPXZWGLChDNZjQJNigGGGN i_(Tuple_GGLURZZjYLMjhaMLVbjKOcMAY medClaim)
			{
				var p_ = medClaim?.LineItem;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					var t_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
					IEnumerable<Tuple_BYXPfHJAafYUZgPBifWFNjLXc> u_(Tuple_BYXPfHJAafYUZgPBifWFNjLXc pClaim)
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
							var af_ = ae_?.Request;
							var ag_ = af_?.ReferenceElement;
							var ah_ = FHIRHelpers_4_0_001.ToString(ag_);
							var ai_ = NCQAFHIRBase_1_0_0.GetId(ah_);
							var aj_ = context.Operators.Equal(ad_, ai_);
							var ak_ = medClaimLineItem?.SequenceElement;
							var al_ = context.Operators.Convert<Integer>(ak_);
							var am_ = pClaimLineItem?.ItemSequenceElement;
							var an_ = context.Operators.Convert<Integer>(am_);
							var ao_ = context.Operators.Equal(al_, an_);
							var ap_ = context.Operators.And(aj_, ao_);

							return ap_;
						};
						var z_ = context.Operators.Where<ClaimResponse.ItemComponent>(x_, y_);
						Tuple_BYXPfHJAafYUZgPBifWFNjLXc aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var ab_ = context.Operators.Select<ClaimResponse.ItemComponent, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(z_, aa_);

						return ab_;
					};
					var v_ = context.Operators.SelectMany<Tuple_BYXPfHJAafYUZgPBifWFNjLXc, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(t_, u_);
					var w_ = context.Operators.Exists<Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(v_);

					return w_;
				};
				var r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
				var s_ = new Tuple_FNLZPXZWGLChDNZjQJNigGGGN
				{
					PaidClaim = medClaim,
					ClaimItem = r_,
				};

				return s_;
			};
			var j_ = context.Operators.Select<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY, Tuple_FNLZPXZWGLChDNZjQJNigGGGN>(h_, i_);
			var k_ = new Tuple_EMbbXAAHNDcXYSgLIhAhQCWON
			{
				AggregateClaim = j_,
			};
			var l_ = new Tuple_EMbbXAAHNDcXYSgLIhAhQCWON[]
			{
				k_,
			};
			Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV m_(Tuple_EMbbXAAHNDcXYSgLIhAhQCWON ClaimWithPaidResponse)
			{
				Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV au_()
				{
					bool az_()
					{
						var ba_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bb_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this)
						{
							var bh_ = @this?.ClaimItem;
							var bi_ = context.Operators.Not((bool?)(bh_ is null));

							return bi_;
						};
						var bc_ = context.Operators.Where<Tuple_FNLZPXZWGLChDNZjQJNigGGGN>(ba_, bb_);
						IEnumerable<Claim.ItemComponent> bd_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this)
						{
							var bj_ = @this?.ClaimItem;

							return bj_;
						};
						var be_ = context.Operators.Select<Tuple_FNLZPXZWGLChDNZjQJNigGGGN, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
						var bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
						var bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);

						return (bg_ ?? false);
					};
					if (az_())
					{
						var bk_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bl_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this)
						{
							var cg_ = @this?.PaidClaim;
							var ch_ = context.Operators.Not((bool?)(cg_ is null));

							return ch_;
						};
						var bm_ = context.Operators.Where<Tuple_FNLZPXZWGLChDNZjQJNigGGGN>(bk_, bl_);
						Tuple_GGLURZZjYLMjhaMLVbjKOcMAY bn_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this)
						{
							var ci_ = @this?.PaidClaim;

							return ci_;
						};
						var bo_ = context.Operators.Select<Tuple_FNLZPXZWGLChDNZjQJNigGGGN, Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(bm_, bn_);
						bool? bq_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this)
						{
							var cj_ = @this?.ClaimItem;
							var ck_ = context.Operators.Not((bool?)(cj_ is null));

							return ck_;
						};
						var br_ = context.Operators.Where<Tuple_FNLZPXZWGLChDNZjQJNigGGGN>(bk_, bq_);
						IEnumerable<Claim.ItemComponent> bs_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this)
						{
							var cl_ = @this?.ClaimItem;

							return cl_;
						};
						var bt_ = context.Operators.Select<Tuple_FNLZPXZWGLChDNZjQJNigGGGN, IEnumerable<Claim.ItemComponent>>(br_, bs_);
						var bu_ = context.Operators.Flatten<Claim.ItemComponent>(bt_);
						CqlInterval<CqlDateTime> bv_(Claim.ItemComponent PaidItem)
						{
							var cm_ = PaidItem?.Serviced;
							var cn_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cm_);

							return cn_;
						};
						var bw_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bu_, bv_);
						bool? by_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this)
						{
							var co_ = @this?.ClaimItem;
							var cp_ = context.Operators.Not((bool?)(co_ is null));

							return cp_;
						};
						var bz_ = context.Operators.Where<Tuple_FNLZPXZWGLChDNZjQJNigGGGN>(bk_, by_);
						IEnumerable<Claim.ItemComponent> ca_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this)
						{
							var cq_ = @this?.ClaimItem;

							return cq_;
						};
						var cb_ = context.Operators.Select<Tuple_FNLZPXZWGLChDNZjQJNigGGGN, IEnumerable<Claim.ItemComponent>>(bz_, ca_);
						var cc_ = context.Operators.Flatten<Claim.ItemComponent>(cb_);
						CqlInterval<CqlDate> cd_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDate> cr_()
							{
								bool cs_()
								{
									var ct_ = i?.Quantity;
									var cu_ = context.Operators.Not((bool?)(ct_ is null));

									return (cu_ ?? false);
								};
								if (cs_())
								{
									var cv_ = i?.Serviced;
									var cw_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cv_);
									var cx_ = context.Operators.Start(cw_);
									var cy_ = context.Operators.ConvertDateTimeToDate(cx_);
									var da_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cv_);
									var db_ = context.Operators.Start(da_);
									var dc_ = i?.Quantity;
									var dd_ = dc_?.ValueElement;
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
						var cf_ = new Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV
						{
							originalClaim = bo_,
							ServicePeriod = bw_,
							CoveredDays = ce_,
						};

						return cf_;
					}
					else
					{
						return (null as Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV);
					}
				};
				var av_ = new Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV[]
				{
					au_(),
				};
				bool? aw_(Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV FinalList)
				{
					var dk_ = context.Operators.Not((bool?)(FinalList is null));

					return dk_;
				};
				var ax_ = context.Operators.Where<Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>((IEnumerable<Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>)av_, aw_);
				var ay_ = context.Operators.SingletonFrom<Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>(ax_);

				return ay_;
			};
			var n_ = context.Operators.Select<Tuple_EMbbXAAHNDcXYSgLIhAhQCWON, Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>((IEnumerable<Tuple_EMbbXAAHNDcXYSgLIhAhQCWON>)l_, m_);
			var o_ = context.Operators.SingletonFrom<Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>(n_);

			return o_;
		};
		var f_ = context.Operators.Select<Tuple_ETbUUAbGJFCcYLGFaEAgMaiBj, Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>((IEnumerable<Tuple_ETbUUAbGJFCcYLGFaEAgMaiBj>)d_, e_);
		var g_ = context.Operators.SingletonFrom<Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Pharmacy Services")]
	public Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV Get_Paid_Claims_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuple_EGPWWEihGWWSCCiZLgdcFLIcD[]
		{
			a_,
		};
		Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV c_(Tuple_EGPWWEihGWWSCCiZLgdcFLIcD PharmacyClaimAndResponse)
		{
			Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV f_()
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
					return (null as Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV);
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
		var d_ = context.Operators.Select<Tuple_EGPWWEihGWWSCCiZLgdcFLIcD, Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>((IEnumerable<Tuple_EGPWWEihGWWSCCiZLgdcFLIcD>)b_, c_);
		var e_ = context.Operators.SingletonFrom<Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>(d_);

		return e_;
	}

    [CqlDeclaration("Get Claim With Corresponding Claim Response")]
	public IEnumerable<Tuple_CZThYJbgajVLdhIZdgZiXBFQK> Get_Claim_With_Corresponding_Claim_Response(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		Tuple_CZThYJbgajVLdhIZdgZiXBFQK a_(Claim Claim)
		{
			bool? c_(ClaimResponse CR)
			{
				var h_ = Claim?.IdElement;
				var i_ = FHIRHelpers_4_0_001.ToString(h_);
				var j_ = CR?.Request;
				var k_ = j_?.ReferenceElement;
				var l_ = FHIRHelpers_4_0_001.ToString(k_);
				var m_ = NCQAFHIRBase_1_0_0.GetId(l_);
				var n_ = context.Operators.Equal(i_, m_);

				return n_;
			};
			var d_ = context.Operators.Where<ClaimResponse>(claimResponse, c_);
			bool? e_(Claim C)
			{
				var o_ = Claim?.IdElement;
				var p_ = FHIRHelpers_4_0_001.ToString(o_);
				bool? q_(ClaimResponse CR)
				{
					var ae_ = Claim?.IdElement;
					var af_ = FHIRHelpers_4_0_001.ToString(ae_);
					var ag_ = CR?.Request;
					var ah_ = ag_?.ReferenceElement;
					var ai_ = FHIRHelpers_4_0_001.ToString(ah_);
					var aj_ = NCQAFHIRBase_1_0_0.GetId(ai_);
					var ak_ = context.Operators.Equal(af_, aj_);

					return ak_;
				};
				var r_ = context.Operators.Where<ClaimResponse>(claimResponse, q_);
				bool? s_(ClaimResponse @this)
				{
					var al_ = @this?.Request;
					var am_ = context.Operators.Not((bool?)(al_ is null));

					return am_;
				};
				var t_ = context.Operators.Where<ClaimResponse>(r_, s_);
				ResourceReference u_(ClaimResponse @this)
				{
					var an_ = @this?.Request;

					return an_;
				};
				var v_ = context.Operators.Select<ClaimResponse, ResourceReference>(t_, u_);
				bool? w_(ResourceReference @this)
				{
					var ao_ = @this?.ReferenceElement;
					var ap_ = context.Operators.Not((bool?)(ao_ is null));

					return ap_;
				};
				var x_ = context.Operators.Where<ResourceReference>(v_, w_);
				FhirString y_(ResourceReference @this)
				{
					var aq_ = @this?.ReferenceElement;

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
			var g_ = new Tuple_CZThYJbgajVLdhIZdgZiXBFQK
			{
				ClaimResponse = d_,
				OriginalClaim = f_,
			};

			return g_;
		};
		var b_ = context.Operators.Select<Claim, Tuple_CZThYJbgajVLdhIZdgZiXBFQK>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Medical Claims With Nonacute or Acute Inpatient Discharge")]
	public Tuple_eaabEEMNTgcTCVVWQFDOgRNO Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(IEnumerable<Claim> claim)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		var b_ = new Tuple_FXYEMgTMOeKcIebiZCTUajHVX
		{
			MedicalClaim = a_,
		};
		var c_ = new Tuple_FXYEMgTMOeKcIebiZCTUajHVX[]
		{
			b_,
		};
		Tuple_eaabEEMNTgcTCVVWQFDOgRNO d_(Tuple_FXYEMgTMOeKcIebiZCTUajHVX ClaimWithInpatientStay)
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
						var q_ = c?.Item;
						bool? r_(Claim.ItemComponent i)
						{
							var u_ = i?.Revenue;
							var v_ = FHIRHelpers_4_0_001.ToConcept(u_);
							var w_ = v_?.codes;
							bool? x_(CqlCode rev)
							{
								var aa_ = rev?.code;
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
						var ag_ = c?.Item;
						bool? ah_(Claim.ItemComponent i)
						{
							var aq_ = i?.Revenue;
							var ar_ = FHIRHelpers_4_0_001.ToConcept(aq_);
							var as_ = ar_?.codes;
							bool? at_(CqlCode rev)
							{
								var aw_ = rev?.code;
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
						var ak_ = c?.SubType;
						var al_ = ak_?.Coding;
						bool? am_(Coding tob)
						{
							var az_ = tob?.CodeElement;
							var ba_ = az_?.Value;
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
			var i_ = new Tuple_GFUjSKcYaHagAZIhSUhffHjHP
			{
				InpatientStayLineItems = g_(),
				NonacuteInpatientLineItems = h_(),
			};
			var j_ = new Tuple_GFUjSKcYaHagAZIhSUhffHjHP[]
			{
				i_,
			};
			Tuple_eaabEEMNTgcTCVVWQFDOgRNO k_(Tuple_GFUjSKcYaHagAZIhSUhffHjHP LineItemDefinition)
			{
				var bd_ = LineItemDefinition?.InpatientStayLineItems;
				var be_ = LineItemDefinition?.NonacuteInpatientLineItems;
				IEnumerable<Claim> bf_(Claim nonAcuteInpatientStay)
				{
					var bn_ = LineItemDefinition?.InpatientStayLineItems;
					bool? bo_(Claim inpatientStay)
					{
						var bs_ = nonAcuteInpatientStay?.IdElement;
						var bt_ = inpatientStay?.IdElement;
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
						var ca_ = inpatientStay?.IdElement;
						var cb_ = nonAcuteInpatientStay?.IdElement;
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
				var bm_ = new Tuple_eaabEEMNTgcTCVVWQFDOgRNO
				{
					InpatientDischarge = bd_,
					NonacuteInpatientDischarge = bg_,
					AcuteInpatientDischarge = bl_,
				};

				return bm_;
			};
			var l_ = context.Operators.Select<Tuple_GFUjSKcYaHagAZIhSUhffHjHP, Tuple_eaabEEMNTgcTCVVWQFDOgRNO>((IEnumerable<Tuple_GFUjSKcYaHagAZIhSUhffHjHP>)j_, k_);
			var m_ = context.Operators.SingletonFrom<Tuple_eaabEEMNTgcTCVVWQFDOgRNO>(l_);

			return m_;
		};
		var e_ = context.Operators.Select<Tuple_FXYEMgTMOeKcIebiZCTUajHVX, Tuple_eaabEEMNTgcTCVVWQFDOgRNO>((IEnumerable<Tuple_FXYEMgTMOeKcIebiZCTUajHVX>)c_, d_);
		var f_ = context.Operators.SingletonFrom<Tuple_eaabEEMNTgcTCVVWQFDOgRNO>(e_);

		return f_;
	}

    [CqlDeclaration("Get Prescriber NPI from Claims")]
	public Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS Get_Prescriber_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		Tuple_CGBhZZbICOjJSOiHTigebRWSH a_(Claim C)
		{
			var h_ = C?.CareTeam;
			bool? i_(Claim.CareTeamComponent ct)
			{
				var y_ = ct?.SequenceElement;
				var z_ = context.Operators.Convert<Integer>(y_);
				var aa_ = FHIRHelpers_4_0_001.ToInteger(z_);
				var ab_ = context.Operators.Equal(aa_, 1);

				return ab_;
			};
			var j_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)h_, i_);
			bool? k_(Claim.CareTeamComponent @this)
			{
				var ac_ = @this?.Provider;
				var ad_ = context.Operators.Not((bool?)(ac_ is null));

				return ad_;
			};
			var l_ = context.Operators.Where<Claim.CareTeamComponent>(j_, k_);
			ResourceReference m_(Claim.CareTeamComponent @this)
			{
				var ae_ = @this?.Provider;

				return ae_;
			};
			var n_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(l_, m_);
			bool? p_(Claim.CareTeamComponent ct)
			{
				var af_ = ct?.SequenceElement;
				var ag_ = context.Operators.Convert<Integer>(af_);
				var ah_ = FHIRHelpers_4_0_001.ToInteger(ag_);
				var ai_ = context.Operators.Equal(ah_, 1);

				return ai_;
			};
			var q_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)h_, p_);
			bool? r_(Claim.CareTeamComponent @this)
			{
				var aj_ = @this?.Provider;
				var ak_ = context.Operators.Not((bool?)(aj_ is null));

				return ak_;
			};
			var s_ = context.Operators.Where<Claim.CareTeamComponent>(q_, r_);
			ResourceReference t_(Claim.CareTeamComponent @this)
			{
				var al_ = @this?.Provider;

				return al_;
			};
			var u_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(s_, t_);
			string v_(ResourceReference p)
			{
				var am_ = p?.ReferenceElement;
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
			var x_ = new Tuple_CGBhZZbICOjJSOiHTigebRWSH
			{
				SingleCareTeam = C,
				CareTeamsProvider = n_,
				CareTeamsProviderID = w_,
			};

			return x_;
		};
		var b_ = context.Operators.Select<Claim, Tuple_CGBhZZbICOjJSOiHTigebRWSH>(claim, a_);
		var c_ = new Tuple_HFNJUcNhcbGBLBgHAJMMSPfQH
		{
			CareTeams = b_,
		};
		var d_ = new Tuple_HFNJUcNhcbGBLBgHAJMMSPfQH[]
		{
			c_,
		};
		Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS e_(Tuple_HFNJUcNhcbGBLBgHAJMMSPfQH ClaimProperties)
		{
			var at_ = context.Operators.RetrieveByValueSet<Practitioner>(null, null);
			bool? au_(Practitioner p)
			{
				var bb_ = p?.IdElement;
				var bc_ = FHIRHelpers_4_0_001.ToString(bb_);
				var bd_ = ClaimProperties?.CareTeams;
				bool? be_(Tuple_CGBhZZbICOjJSOiHTigebRWSH @this)
				{
					var bk_ = @this?.CareTeamsProviderID;
					var bl_ = context.Operators.Not((bool?)(bk_ is null));

					return bl_;
				};
				var bf_ = context.Operators.Where<Tuple_CGBhZZbICOjJSOiHTigebRWSH>(bd_, be_);
				IEnumerable<string> bg_(Tuple_CGBhZZbICOjJSOiHTigebRWSH @this)
				{
					var bm_ = @this?.CareTeamsProviderID;

					return bm_;
				};
				var bh_ = context.Operators.Select<Tuple_CGBhZZbICOjJSOiHTigebRWSH, IEnumerable<string>>(bf_, bg_);
				var bi_ = context.Operators.Flatten<string>(bh_);
				var bj_ = context.Operators.In<string>(bc_, bi_);

				return bj_;
			};
			var av_ = context.Operators.Where<Practitioner>(at_, au_);
			var aw_ = new Tuple_FPVdJEEOUKFVhQPTfKhShUNO
			{
				Practitioners = av_,
			};
			var ax_ = new Tuple_FPVdJEEOUKFVhQPTfKhShUNO[]
			{
				aw_,
			};
			Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS ay_(Tuple_FPVdJEEOUKFVhQPTfKhShUNO PractitionerMatch)
			{
				var bn_ = PractitionerMatch?.Practitioners;
				bool? bo_(Practitioner P)
				{
					var bx_ = context.Operators.Not((bool?)(P is null));

					return bx_;
				};
				var bp_ = context.Operators.Where<Practitioner>(bn_, bo_);
				Tuple_EheHUARRFfQdCcHKeSEhfYZMj bq_(Practitioner P)
				{
					var by_ = P?.Identifier;
					bool? bz_(Identifier l)
					{
						var cj_ = l?.SystemElement;
						var ck_ = cj_?.Value;
						var cl_ = context.Operators.Equal(ck_, "http://hl7.org/fhir/sid/us-npi");
						var cm_ = l?.Type;
						var cn_ = FHIRHelpers_4_0_001.ToConcept(cm_);
						var co_ = NCQATerminology_1_0_0.Provider_number();
						var cp_ = context.Operators.ConvertCodeToConcept(co_);
						var cq_ = context.Operators.Equivalent(cn_, cp_);
						var cr_ = context.Operators.And(cl_, cq_);
						var cs_ = l?.ValueElement;
						var ct_ = cs_?.Value;
						var cu_ = context.Operators.Not((bool?)(ct_ is null));
						var cv_ = context.Operators.And(cr_, cu_);

						return cv_;
					};
					var ca_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)by_, bz_);
					FhirString cb_(Identifier l)
					{
						var cw_ = l?.ValueElement;

						return cw_;
					};
					var cc_ = context.Operators.Select<Identifier, FhirString>(ca_, cb_);
					bool? ce_(Identifier l)
					{
						var cx_ = l?.SystemElement;
						var cy_ = cx_?.Value;
						var cz_ = context.Operators.Equal(cy_, "http://hl7.org/fhir/sid/us-npi");
						var da_ = l?.Type;
						var db_ = FHIRHelpers_4_0_001.ToConcept(da_);
						var dc_ = NCQATerminology_1_0_0.Provider_number();
						var dd_ = context.Operators.ConvertCodeToConcept(dc_);
						var de_ = context.Operators.Equivalent(db_, dd_);
						var df_ = context.Operators.And(cz_, de_);
						var dg_ = l?.ValueElement;
						var dh_ = dg_?.Value;
						var di_ = context.Operators.And(df_, (bool?)(dh_ is null));

						return di_;
					};
					var cf_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)by_, ce_);
					Identifier cg_(Identifier l) => 
						l;
					var ch_ = context.Operators.Select<Identifier, Identifier>(cf_, cg_);
					var ci_ = new Tuple_EheHUARRFfQdCcHKeSEhfYZMj
					{
						AllIdentifiers = cc_,
						NullIdentifiers = ch_,
					};

					return ci_;
				};
				var br_ = context.Operators.Select<Practitioner, Tuple_EheHUARRFfQdCcHKeSEhfYZMj>(bp_, bq_);
				var bs_ = new Tuple_EZUSISLPSZWTXahaQjXaSAJBE
				{
					IdentifierTuple = br_,
				};
				var bt_ = new Tuple_EZUSISLPSZWTXahaQjXaSAJBE[]
				{
					bs_,
				};
				Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS bu_(Tuple_EZUSISLPSZWTXahaQjXaSAJBE GetIdentifiers)
				{
					int? dj_()
					{
						bool dl_()
						{
							var dm_ = ClaimProperties?.CareTeams;
							bool? dn_(Tuple_CGBhZZbICOjJSOiHTigebRWSH @this)
							{
								var ds_ = @this?.SingleCareTeam;
								var dt_ = context.Operators.Not((bool?)(ds_ is null));

								return dt_;
							};
							var do_ = context.Operators.Where<Tuple_CGBhZZbICOjJSOiHTigebRWSH>(dm_, dn_);
							Claim dp_(Tuple_CGBhZZbICOjJSOiHTigebRWSH @this)
							{
								var du_ = @this?.SingleCareTeam;

								return du_;
							};
							var dq_ = context.Operators.Select<Tuple_CGBhZZbICOjJSOiHTigebRWSH, Claim>(do_, dp_);
							var dr_ = context.Operators.Exists<Claim>(dq_);

							return (dr_ ?? false);
						};
						if (dl_())
						{
							var dv_ = ClaimProperties?.CareTeams;
							bool? dw_(Tuple_CGBhZZbICOjJSOiHTigebRWSH @this)
							{
								var er_ = @this?.SingleCareTeam;
								var es_ = context.Operators.Not((bool?)(er_ is null));

								return es_;
							};
							var dx_ = context.Operators.Where<Tuple_CGBhZZbICOjJSOiHTigebRWSH>(dv_, dw_);
							Claim dy_(Tuple_CGBhZZbICOjJSOiHTigebRWSH @this)
							{
								var et_ = @this?.SingleCareTeam;

								return et_;
							};
							var dz_ = context.Operators.Select<Tuple_CGBhZZbICOjJSOiHTigebRWSH, Claim>(dx_, dy_);
							bool? ea_(Claim X)
							{
								var eu_ = X?.CareTeam;

								return (bool?)((IEnumerable<Claim.CareTeamComponent>)eu_ is null);
							};
							var eb_ = context.Operators.Where<Claim>(dz_, ea_);
							var ec_ = context.Operators.Count<Claim>(eb_);
							var ed_ = GetIdentifiers?.IdentifierTuple;
							IEnumerable<FhirString> ee_(Tuple_EheHUARRFfQdCcHKeSEhfYZMj X)
							{
								var ev_ = X?.AllIdentifiers;

								return ev_;
							};
							var ef_ = context.Operators.Select<Tuple_EheHUARRFfQdCcHKeSEhfYZMj, IEnumerable<FhirString>>(ed_, ee_);
							var eg_ = context.Operators.Flatten<FhirString>(ef_);
							FhirString eh_(FhirString X) => 
								X;
							var ei_ = context.Operators.Select<FhirString, FhirString>(eg_, eh_);
							var ej_ = context.Operators.Count<FhirString>(ei_);
							var ek_ = context.Operators.Add(ec_, ej_);
							IEnumerable<Identifier> em_(Tuple_EheHUARRFfQdCcHKeSEhfYZMj X)
							{
								var ew_ = X?.NullIdentifiers;

								return ew_;
							};
							var en_ = context.Operators.Select<Tuple_EheHUARRFfQdCcHKeSEhfYZMj, IEnumerable<Identifier>>(ed_, em_);
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
					var dk_ = new Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS
					{
						IdentifierCount = dj_(),
					};

					return dk_;
				};
				var bv_ = context.Operators.Select<Tuple_EZUSISLPSZWTXahaQjXaSAJBE, Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>((IEnumerable<Tuple_EZUSISLPSZWTXahaQjXaSAJBE>)bt_, bu_);
				var bw_ = context.Operators.SingletonFrom<Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(bv_);

				return bw_;
			};
			var az_ = context.Operators.Select<Tuple_FPVdJEEOUKFVhQPTfKhShUNO, Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>((IEnumerable<Tuple_FPVdJEEOUKFVhQPTfKhShUNO>)ax_, ay_);
			var ba_ = context.Operators.SingletonFrom<Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(az_);

			return ba_;
		};
		var f_ = context.Operators.Select<Tuple_HFNJUcNhcbGBLBgHAJMMSPfQH, Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>((IEnumerable<Tuple_HFNJUcNhcbGBLBgHAJMMSPfQH>)d_, e_);
		var g_ = context.Operators.SingletonFrom<Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(f_);

		return g_;
	}

    [CqlDeclaration("Get Pharmacy NPI from Claims")]
	public Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS Get_Pharmacy_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		Tuple_GJMDOdSNREDHVIihMZIJLUYXV a_(Claim C)
		{
			var h_ = C?.Item;
			bool? j_(Claim.ItemComponent i)
			{
				var ab_ = i?.SequenceElement;
				var ac_ = context.Operators.Convert<Integer>(ab_);
				var ad_ = FHIRHelpers_4_0_001.ToInteger(ac_);
				var ae_ = context.Operators.Equal(ad_, 1);

				return ae_;
			};
			var k_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)h_, j_);
			bool? l_(Claim.ItemComponent @this)
			{
				var af_ = @this?.Location;
				var ag_ = context.Operators.Not((bool?)(af_ is null));

				return ag_;
			};
			var m_ = context.Operators.Where<Claim.ItemComponent>(k_, l_);
			DataType n_(Claim.ItemComponent @this)
			{
				var ah_ = @this?.Location;

				return ah_;
			};
			var o_ = context.Operators.Select<Claim.ItemComponent, DataType>(m_, n_);
			ResourceReference p_(object l) => 
				(l as ResourceReference);
			var q_ = context.Operators.Select<object, ResourceReference>((IEnumerable<object>)o_, p_);
			bool? s_(Claim.ItemComponent i)
			{
				var ai_ = i?.SequenceElement;
				var aj_ = context.Operators.Convert<Integer>(ai_);
				var ak_ = FHIRHelpers_4_0_001.ToInteger(aj_);
				var al_ = context.Operators.Equal(ak_, 1);

				return al_;
			};
			var t_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)h_, s_);
			bool? u_(Claim.ItemComponent @this)
			{
				var am_ = @this?.Location;
				var an_ = context.Operators.Not((bool?)(am_ is null));

				return an_;
			};
			var v_ = context.Operators.Where<Claim.ItemComponent>(t_, u_);
			DataType w_(Claim.ItemComponent @this)
			{
				var ao_ = @this?.Location;

				return ao_;
			};
			var x_ = context.Operators.Select<Claim.ItemComponent, DataType>(v_, w_);
			string y_(object l)
			{
				var ap_ = (l as ResourceReference)?.ReferenceElement;
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
			var aa_ = new Tuple_GJMDOdSNREDHVIihMZIJLUYXV
			{
				SingleItem = (IEnumerable<Claim.ItemComponent>)h_,
				ItemLocation = q_,
				ItemLocationID = z_,
			};

			return aa_;
		};
		var b_ = context.Operators.Select<Claim, Tuple_GJMDOdSNREDHVIihMZIJLUYXV>(claim, a_);
		var c_ = new Tuple_ESTVjUCCVhLEXJGPZBeEcQDHX
		{
			ItemsLocationReferences = b_,
		};
		var d_ = new Tuple_ESTVjUCCVhLEXJGPZBeEcQDHX[]
		{
			c_,
		};
		Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS e_(Tuple_ESTVjUCCVhLEXJGPZBeEcQDHX ClaimProperties)
		{
			var aw_ = context.Operators.RetrieveByValueSet<Location>(null, null);
			bool? ax_(Location l)
			{
				var be_ = l?.IdElement;
				var bf_ = FHIRHelpers_4_0_001.ToString(be_);
				var bg_ = ClaimProperties?.ItemsLocationReferences;
				bool? bh_(Tuple_GJMDOdSNREDHVIihMZIJLUYXV @this)
				{
					var bn_ = @this?.ItemLocationID;
					var bo_ = context.Operators.Not((bool?)(bn_ is null));

					return bo_;
				};
				var bi_ = context.Operators.Where<Tuple_GJMDOdSNREDHVIihMZIJLUYXV>(bg_, bh_);
				IEnumerable<string> bj_(Tuple_GJMDOdSNREDHVIihMZIJLUYXV @this)
				{
					var bp_ = @this?.ItemLocationID;

					return bp_;
				};
				var bk_ = context.Operators.Select<Tuple_GJMDOdSNREDHVIihMZIJLUYXV, IEnumerable<string>>(bi_, bj_);
				var bl_ = context.Operators.Flatten<string>(bk_);
				var bm_ = context.Operators.In<string>(bf_, bl_);

				return bm_;
			};
			var ay_ = context.Operators.Where<Location>(aw_, ax_);
			var az_ = new Tuple_GWYcfjEGjPEdPbTNdfROfTUAf
			{
				CorrespondingLocations = ay_,
			};
			var ba_ = new Tuple_GWYcfjEGjPEdPbTNdfROfTUAf[]
			{
				az_,
			};
			Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS bb_(Tuple_GWYcfjEGjPEdPbTNdfROfTUAf GetLocation)
			{
				var bq_ = GetLocation?.CorrespondingLocations;
				bool? br_(Location C)
				{
					var ca_ = context.Operators.Not((bool?)(C is null));

					return ca_;
				};
				var bs_ = context.Operators.Where<Location>(bq_, br_);
				Tuple_EheHUARRFfQdCcHKeSEhfYZMj bt_(Location C)
				{
					var cb_ = C?.Identifier;
					bool? cc_(Identifier l)
					{
						var cm_ = l?.SystemElement;
						var cn_ = cm_?.Value;
						var co_ = context.Operators.Equal(cn_, "http://hl7.org/fhir/sid/us-npi");
						var cp_ = l?.Type;
						var cq_ = FHIRHelpers_4_0_001.ToConcept(cp_);
						var cr_ = NCQATerminology_1_0_0.Provider_number();
						var cs_ = context.Operators.ConvertCodeToConcept(cr_);
						var ct_ = context.Operators.Equivalent(cq_, cs_);
						var cu_ = context.Operators.And(co_, ct_);
						var cv_ = l?.ValueElement;
						var cw_ = cv_?.Value;
						var cx_ = context.Operators.Not((bool?)(cw_ is null));
						var cy_ = context.Operators.And(cu_, cx_);

						return cy_;
					};
					var cd_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)cb_, cc_);
					FhirString ce_(Identifier l)
					{
						var cz_ = l?.ValueElement;

						return cz_;
					};
					var cf_ = context.Operators.Select<Identifier, FhirString>(cd_, ce_);
					bool? ch_(Identifier l)
					{
						var da_ = l?.SystemElement;
						var db_ = da_?.Value;
						var dc_ = context.Operators.Equal(db_, "http://hl7.org/fhir/sid/us-npi");
						var dd_ = l?.Type;
						var de_ = FHIRHelpers_4_0_001.ToConcept(dd_);
						var df_ = NCQATerminology_1_0_0.Provider_number();
						var dg_ = context.Operators.ConvertCodeToConcept(df_);
						var dh_ = context.Operators.Equivalent(de_, dg_);
						var di_ = context.Operators.And(dc_, dh_);
						var dj_ = l?.ValueElement;
						var dk_ = dj_?.Value;
						var dl_ = context.Operators.And(di_, (bool?)(dk_ is null));

						return dl_;
					};
					var ci_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)cb_, ch_);
					Identifier cj_(Identifier l) => 
						l;
					var ck_ = context.Operators.Select<Identifier, Identifier>(ci_, cj_);
					var cl_ = new Tuple_EheHUARRFfQdCcHKeSEhfYZMj
					{
						AllIdentifiers = cf_,
						NullIdentifiers = ck_,
					};

					return cl_;
				};
				var bu_ = context.Operators.Select<Location, Tuple_EheHUARRFfQdCcHKeSEhfYZMj>(bs_, bt_);
				var bv_ = new Tuple_EZUSISLPSZWTXahaQjXaSAJBE
				{
					IdentifierTuple = bu_,
				};
				var bw_ = new Tuple_EZUSISLPSZWTXahaQjXaSAJBE[]
				{
					bv_,
				};
				Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS bx_(Tuple_EZUSISLPSZWTXahaQjXaSAJBE GetIdentifiers)
				{
					int? dm_()
					{
						bool do_()
						{
							var dp_ = ClaimProperties?.ItemsLocationReferences;
							bool? dq_(Tuple_GJMDOdSNREDHVIihMZIJLUYXV @this)
							{
								var dw_ = @this?.SingleItem;
								var dx_ = context.Operators.Not((bool?)(dw_ is null));

								return dx_;
							};
							var dr_ = context.Operators.Where<Tuple_GJMDOdSNREDHVIihMZIJLUYXV>(dp_, dq_);
							IEnumerable<Claim.ItemComponent> ds_(Tuple_GJMDOdSNREDHVIihMZIJLUYXV @this)
							{
								var dy_ = @this?.SingleItem;

								return dy_;
							};
							var dt_ = context.Operators.Select<Tuple_GJMDOdSNREDHVIihMZIJLUYXV, IEnumerable<Claim.ItemComponent>>(dr_, ds_);
							var du_ = context.Operators.Flatten<Claim.ItemComponent>(dt_);
							var dv_ = context.Operators.Exists<Claim.ItemComponent>(du_);

							return (dv_ ?? false);
						};
						if (do_())
						{
							var dz_ = ClaimProperties?.ItemsLocationReferences;
							bool? ea_(Tuple_GJMDOdSNREDHVIihMZIJLUYXV @this)
							{
								var ew_ = @this?.ItemLocation;
								var ex_ = context.Operators.Not((bool?)(ew_ is null));

								return ex_;
							};
							var eb_ = context.Operators.Where<Tuple_GJMDOdSNREDHVIihMZIJLUYXV>(dz_, ea_);
							IEnumerable<ResourceReference> ec_(Tuple_GJMDOdSNREDHVIihMZIJLUYXV @this)
							{
								var ey_ = @this?.ItemLocation;

								return ey_;
							};
							var ed_ = context.Operators.Select<Tuple_GJMDOdSNREDHVIihMZIJLUYXV, IEnumerable<ResourceReference>>(eb_, ec_);
							var ee_ = context.Operators.Flatten<ResourceReference>(ed_);
							bool? ef_(ResourceReference X)
							{
								var ez_ = X?.ReferenceElement;
								var fa_ = ez_?.Value;

								return (bool?)(fa_ is null);
							};
							var eg_ = context.Operators.Where<ResourceReference>(ee_, ef_);
							var eh_ = context.Operators.Count<ResourceReference>(eg_);
							var ei_ = GetIdentifiers?.IdentifierTuple;
							IEnumerable<FhirString> ej_(Tuple_EheHUARRFfQdCcHKeSEhfYZMj X)
							{
								var fb_ = X?.AllIdentifiers;

								return fb_;
							};
							var ek_ = context.Operators.Select<Tuple_EheHUARRFfQdCcHKeSEhfYZMj, IEnumerable<FhirString>>(ei_, ej_);
							var el_ = context.Operators.Flatten<FhirString>(ek_);
							FhirString em_(FhirString X) => 
								X;
							var en_ = context.Operators.Select<FhirString, FhirString>(el_, em_);
							var eo_ = context.Operators.Count<FhirString>(en_);
							var ep_ = context.Operators.Add(eh_, eo_);
							IEnumerable<Identifier> er_(Tuple_EheHUARRFfQdCcHKeSEhfYZMj X)
							{
								var fc_ = X?.NullIdentifiers;

								return fc_;
							};
							var es_ = context.Operators.Select<Tuple_EheHUARRFfQdCcHKeSEhfYZMj, IEnumerable<Identifier>>(ei_, er_);
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
					var dn_ = new Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS
					{
						IdentifierCount = dm_(),
					};

					return dn_;
				};
				var by_ = context.Operators.Select<Tuple_EZUSISLPSZWTXahaQjXaSAJBE, Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>((IEnumerable<Tuple_EZUSISLPSZWTXahaQjXaSAJBE>)bw_, bx_);
				var bz_ = context.Operators.SingletonFrom<Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(by_);

				return bz_;
			};
			var bc_ = context.Operators.Select<Tuple_GWYcfjEGjPEdPbTNdfROfTUAf, Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>((IEnumerable<Tuple_GWYcfjEGjPEdPbTNdfROfTUAf>)ba_, bb_);
			var bd_ = context.Operators.SingletonFrom<Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(bc_);

			return bd_;
		};
		var f_ = context.Operators.Select<Tuple_ESTVjUCCVhLEXJGPZBeEcQDHX, Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>((IEnumerable<Tuple_ESTVjUCCVhLEXJGPZBeEcQDHX>)d_, e_);
		var g_ = context.Operators.SingletonFrom<Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(f_);

		return g_;
	}

}

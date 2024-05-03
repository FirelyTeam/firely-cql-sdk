﻿using System;
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
			var c_ = FHIRHelpers_4_0_001.ToConcept(MedicalClaim?.Type);
			var d_ = NCQATerminology_1_0_0.Professional();
			var e_ = context.Operators.ListContains<CqlCode>((IEnumerable<CqlCode>)c_?.codes, d_);
			var g_ = NCQATerminology_1_0_0.Institutional();
			var h_ = context.Operators.ListContains<CqlCode>((IEnumerable<CqlCode>)c_?.codes, g_);
			var i_ = context.Operators.Or(e_, h_);

			return i_;
		};
		var b_ = context.Operators.Where<Claim>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Pharmacy Claims")]
	public IEnumerable<Claim> Pharmacy_Claims(IEnumerable<Claim> claim)
	{
		bool? a_(Claim PharmacyClaim)
		{
			var c_ = FHIRHelpers_4_0_001.ToConcept(PharmacyClaim?.Type);
			var d_ = NCQATerminology_1_0_0.Pharmacy();
			var e_ = context.Operators.ListContains<CqlCode>((IEnumerable<CqlCode>)c_?.codes, d_);

			return e_;
		};
		var b_ = context.Operators.Where<Claim>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Professional or Institutional Claims Response")]
	public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse MedicalResponse)
		{
			var c_ = FHIRHelpers_4_0_001.ToConcept(MedicalResponse?.Type);
			var d_ = NCQATerminology_1_0_0.Professional();
			var e_ = context.Operators.ListContains<CqlCode>((IEnumerable<CqlCode>)c_?.codes, d_);
			var g_ = NCQATerminology_1_0_0.Institutional();
			var h_ = context.Operators.ListContains<CqlCode>((IEnumerable<CqlCode>)c_?.codes, g_);
			var i_ = context.Operators.Or(e_, h_);

			return i_;
		};
		var b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);

		return b_;
	}

    [CqlDeclaration("Pharmacy Claims Response")]
	public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse PharmacyResponse)
		{
			var c_ = FHIRHelpers_4_0_001.ToConcept(PharmacyResponse?.Type);
			var d_ = NCQATerminology_1_0_0.Pharmacy();
			var e_ = context.Operators.ListContains<CqlCode>((IEnumerable<CqlCode>)c_?.codes, d_);

			return e_;
		};
		var b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);

		return b_;
	}

    [CqlDeclaration("Medical Claims With Procedure and POS")]
	public IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd> Medical_Claims_With_Procedure_and_POS(IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p) => 
			p?.code;
		var c_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, b_);
		string d_(CqlCode pos) => 
			pos?.code;
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
			Tuple_GDUUTAIXZafehWFjcGfNKBcTd k_(Claim ClaimofInterest)
			{
				IEnumerable<Claim.ItemComponent> o_()
				{
					if ((ClaimofInterest is null))
					{
						return null;
					}
					else
					{
						bool? u_(Claim.ItemComponent ItemOnLine)
						{
							var w_ = FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService);
							bool? x_(CqlCode LineCode)
							{
								var af_ = context.Operators.In<string>(LineCode?.code, ClaimWithPosCode?.ProceduresAsStrings);

								return af_;
							};
							var y_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)w_?.codes, x_);
							var z_ = context.Operators.Exists<CqlCode>(y_);
							var aa_ = FHIRHelpers_4_0_001.ToConcept((ItemOnLine?.Location as CodeableConcept));
							bool? ab_(CqlCode PosCode)
							{
								var ag_ = context.Operators.In<string>(PosCode?.code, ClaimWithPosCode?.POSAsString);

								return ag_;
							};
							var ac_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)aa_?.codes, ab_);
							var ad_ = context.Operators.Exists<CqlCode>(ac_);
							var ae_ = context.Operators.And(z_, ad_);

							return ae_;
						};
						var v_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ClaimofInterest?.Item, u_);

						return v_;
					};
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
					Tuple_GDUUTAIXZafehWFjcGfNKBcTd ah_()
					{
						if ((context.Operators.Exists<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
						{
							bool? ai_(Claim.ItemComponent @this)
							{
								var ap_ = context.Operators.Not((bool?)(@this?.Serviced is null));

								return ap_;
							};
							var aj_ = context.Operators.Where<Claim.ItemComponent>(LineItemDefinition?.LineItems, ai_);
							DataType ak_(Claim.ItemComponent @this) => 
								@this?.Serviced;
							var al_ = context.Operators.Select<Claim.ItemComponent, DataType>(aj_, ak_);
							CqlInterval<CqlDateTime> am_(DataType NormalDate)
							{
								var aq_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return aq_;
							};
							var an_ = context.Operators.Select<DataType, CqlInterval<CqlDateTime>>(al_, am_);
							var ao_ = new Tuple_GDUUTAIXZafehWFjcGfNKBcTd
							{
								Claim = LineItemDefinition?.Claim,
								ServicePeriod = an_,
							};

							return ao_;
						}
						else
						{
							return null;
						};
					};

					return ah_();
				};
				var s_ = context.Operators.Select<Tuple_HSdidNdfHCNCFSUTgBiYLcgXP, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(q_, r_);
				var t_ = context.Operators.SingletonFrom<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(s_);

				return t_;
			};
			var l_ = context.Operators.Select<Claim, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(ClaimWithPosCode?.MedicalClaim, k_);
			bool? m_(Tuple_GDUUTAIXZafehWFjcGfNKBcTd FinalList)
			{
				var ar_ = context.Operators.Not((bool?)(FinalList is null));

				return ar_;
			};
			var n_ = context.Operators.Where<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(l_, m_);

			return n_;
		};
		var i_ = context.Operators.Select<Tuple_FXYEMgTMOeKcIebiZCTUajHVX, IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(g_, h_);
		var j_ = context.Operators.SingletonFrom<IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Procedure in Header or on Line Item")]
	public IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p) => 
			p?.code;
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
			Tuple_GDUUTAIXZafehWFjcGfNKBcTd i_(Claim ClaimofInterest)
			{
				IEnumerable<Claim.ItemComponent> m_()
				{
					if ((ClaimofInterest is null))
					{
						return null;
					}
					else
					{
						bool? s_(Claim.ItemComponent ItemOnLine)
						{
							var u_ = FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService);
							bool? v_(CqlCode LineCode)
							{
								var al_ = context.Operators.In<string>(LineCode?.code, ClaimWithProcedure?.ProceduresAsStrings);

								return al_;
							};
							var w_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)u_?.codes, v_);
							var x_ = context.Operators.Exists<CqlCode>(w_);
							bool? y_(Claim.ProcedureComponent @this)
							{
								var am_ = context.Operators.Not((bool?)(@this?.Procedure is null));

								return am_;
							};
							var z_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)ClaimofInterest?.Procedure, y_);
							DataType aa_(Claim.ProcedureComponent @this) => 
								@this?.Procedure;
							var ab_ = context.Operators.Select<Claim.ProcedureComponent, DataType>(z_, aa_);
							bool? ac_(DataType @this)
							{
								var an_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								var ao_ = context.Operators.Not((bool?)(an_ is null));

								return ao_;
							};
							var ad_ = context.Operators.Where<DataType>(ab_, ac_);
							object ae_(DataType @this)
							{
								var ap_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return ap_;
							};
							var af_ = context.Operators.Select<DataType, object>(ad_, ae_);
							var ag_ = context.Operators.FlattenLateBoundList(af_);
							bool? ah_(object HeaderCode)
							{
								var aq_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
								var ar_ = context.Operators.In<string>(aq_?.Value, ClaimWithProcedure?.ProceduresAsStrings);

								return ar_;
							};
							var ai_ = context.Operators.Where<object>(ag_, ah_);
							var aj_ = context.Operators.Exists<object>(ai_);
							var ak_ = context.Operators.Or(x_, aj_);

							return ak_;
						};
						var t_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ClaimofInterest?.Item, s_);

						return t_;
					};
				};
				var n_ = new Tuple_HSdidNdfHCNCFSUTgBiYLcgXP
				{
					Claim = ClaimofInterest,
					LineItems = m_(),
				};
				var o_ = new Tuple_HSdidNdfHCNCFSUTgBiYLcgXP[]
				{
					n_,
				};
				Tuple_GDUUTAIXZafehWFjcGfNKBcTd p_(Tuple_HSdidNdfHCNCFSUTgBiYLcgXP LineItemDefinition)
				{
					Tuple_GDUUTAIXZafehWFjcGfNKBcTd as_()
					{
						if ((context.Operators.Exists<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
						{
							bool? at_(Claim.ItemComponent @this)
							{
								var ba_ = context.Operators.Not((bool?)(@this?.Serviced is null));

								return ba_;
							};
							var au_ = context.Operators.Where<Claim.ItemComponent>(LineItemDefinition?.LineItems, at_);
							DataType av_(Claim.ItemComponent @this) => 
								@this?.Serviced;
							var aw_ = context.Operators.Select<Claim.ItemComponent, DataType>(au_, av_);
							CqlInterval<CqlDateTime> ax_(DataType NormalDate)
							{
								var bb_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return bb_;
							};
							var ay_ = context.Operators.Select<DataType, CqlInterval<CqlDateTime>>(aw_, ax_);
							var az_ = new Tuple_GDUUTAIXZafehWFjcGfNKBcTd
							{
								Claim = LineItemDefinition?.Claim,
								ServicePeriod = ay_,
							};

							return az_;
						}
						else
						{
							return null;
						};
					};

					return as_();
				};
				var q_ = context.Operators.Select<Tuple_HSdidNdfHCNCFSUTgBiYLcgXP, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(o_, p_);
				var r_ = context.Operators.SingletonFrom<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(q_);

				return r_;
			};
			var j_ = context.Operators.Select<Claim, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(ClaimWithProcedure?.MedicalClaim, i_);
			bool? k_(Tuple_GDUUTAIXZafehWFjcGfNKBcTd FinalList)
			{
				var bc_ = context.Operators.Not((bool?)(FinalList is null));

				return bc_;
			};
			var l_ = context.Operators.Where<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(j_, k_);

			return l_;
		};
		var g_ = context.Operators.Select<Tuple_FXYEMgTMOeKcIebiZCTUajHVX, IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(e_, f_);
		var h_ = context.Operators.SingletonFrom<IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis")]
	public Tuple_CWDDWHRXGADEbdaKXCdKbgEfg Medical_Claims_With_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d) => 
			d?.code;
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
			IEnumerable<Claim> i_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					return null;
				}
				else
				{
					bool? o_(Claim DiagnosisLine)
					{
						bool? q_(Claim.DiagnosisComponent @this)
						{
							var ac_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

							return ac_;
						};
						var r_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)DiagnosisLine?.Diagnosis, q_);
						DataType s_(Claim.DiagnosisComponent @this) => 
							@this?.Diagnosis;
						var t_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(r_, s_);
						bool? u_(DataType @this)
						{
							var ad_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							var ae_ = context.Operators.Not((bool?)(ad_ is null));

							return ae_;
						};
						var v_ = context.Operators.Where<DataType>(t_, u_);
						object w_(DataType @this)
						{
							var af_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return af_;
						};
						var x_ = context.Operators.Select<DataType, object>(v_, w_);
						var y_ = context.Operators.FlattenLateBoundList(x_);
						bool? z_(object HeaderCode)
						{
							var ag_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
							var ah_ = context.Operators.In<string>(ag_?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings);

							return ah_;
						};
						var aa_ = context.Operators.Where<object>(y_, z_);
						var ab_ = context.Operators.Exists<object>(aa_);

						return ab_;
					};
					var p_ = context.Operators.Where<Claim>(ClaimWithDiagnosis?.MedicalClaim, o_);

					return p_;
				};
			};
			var j_ = new Tuple_GDVcejYEWXWNHUIODacaMaBhV
			{
				DiagnosisItems = i_(),
			};
			var k_ = new Tuple_GDVcejYEWXWNHUIODacaMaBhV[]
			{
				j_,
			};
			Tuple_CWDDWHRXGADEbdaKXCdKbgEfg l_(Tuple_GDVcejYEWXWNHUIODacaMaBhV HeaderDefinition)
			{
				Tuple_CWDDWHRXGADEbdaKXCdKbgEfg ai_()
				{
					if ((context.Operators.Exists<Claim>(HeaderDefinition?.DiagnosisItems) ?? false))
					{
						bool? an_(Claim @this)
						{
							var av_ = context.Operators.Not((bool?)(@this?.Item is null));

							return av_;
						};
						var ao_ = context.Operators.Where<Claim>(HeaderDefinition?.DiagnosisItems, an_);
						List<Claim.ItemComponent> ap_(Claim @this) => 
							@this?.Item;
						var aq_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ao_, ap_);
						var ar_ = context.Operators.Flatten<Claim.ItemComponent>(aq_);
						CqlInterval<CqlDateTime> as_(Claim.ItemComponent NormalDate)
						{
							var aw_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced);

							return aw_;
						};
						var at_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(ar_, as_);
						var au_ = new Tuple_CWDDWHRXGADEbdaKXCdKbgEfg
						{
							Claim = HeaderDefinition?.DiagnosisItems,
							ServicePeriod = at_,
						};

						return au_;
					}
					else
					{
						return null;
					};
				};
				var aj_ = new Tuple_CWDDWHRXGADEbdaKXCdKbgEfg[]
				{
					ai_(),
				};
				bool? ak_(Tuple_CWDDWHRXGADEbdaKXCdKbgEfg FinalList)
				{
					var ax_ = context.Operators.Not((bool?)(FinalList is null));

					return ax_;
				};
				var al_ = context.Operators.Where<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>(aj_, ak_);
				var am_ = context.Operators.SingletonFrom<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>(al_);

				return am_;
			};
			var m_ = context.Operators.Select<Tuple_GDVcejYEWXWNHUIODacaMaBhV, Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>(k_, l_);
			var n_ = context.Operators.SingletonFrom<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>(m_);

			return n_;
		};
		var g_ = context.Operators.Select<Tuple_DKCCfPXSWPMBNeFXdjEFGiRcF, Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>(e_, f_);
		var h_ = context.Operators.SingletonFrom<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>(g_);

		return h_;
	}

    [CqlDeclaration("Pharmacy Claim With Medication")]
	public IEnumerable<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY> Pharmacy_Claim_With_Medication(IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
	{
		var a_ = this.Pharmacy_Claims(claim);
		string b_(CqlCode p) => 
			p?.code;
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
			Tuple_GGLURZZjYLMjhaMLVbjKOcMAY i_(Claim Pharmacy)
			{
				bool? m_(Claim.ItemComponent ItemOnLine)
				{
					var t_ = FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService);
					bool? u_(CqlCode LineCode)
					{
						var x_ = context.Operators.In<string>(LineCode?.code, ClaimWithMedication?.MedicationsAsStrings);

						return x_;
					};
					var v_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)t_?.codes, u_);
					var w_ = context.Operators.Exists<CqlCode>(v_);

					return w_;
				};
				var n_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)Pharmacy?.Item, m_);
				var o_ = new Tuple_HSdidNdfHCNCFSUTgBiYLcgXP
				{
					Claim = Pharmacy,
					LineItems = n_,
				};
				var p_ = new Tuple_HSdidNdfHCNCFSUTgBiYLcgXP[]
				{
					o_,
				};
				Tuple_GGLURZZjYLMjhaMLVbjKOcMAY q_(Tuple_HSdidNdfHCNCFSUTgBiYLcgXP LineItemDefinition)
				{
					var y_ = new Claim[]
					{
						LineItemDefinition?.Claim,
					};
					Tuple_GGLURZZjYLMjhaMLVbjKOcMAY z_(Claim ClaimLines)
					{
						bool? ac_(Claim.ItemComponent i)
						{
							var al_ = FHIRHelpers_4_0_001.ToConcept(i?.ProductOrService);
							bool? am_(CqlCode LineCode)
							{
								var ap_ = context.Operators.In<string>(LineCode?.code, ClaimWithMedication?.MedicationsAsStrings);

								return ap_;
							};
							var an_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)al_?.codes, am_);
							var ao_ = context.Operators.Exists<CqlCode>(an_);

							return ao_;
						};
						var ad_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ClaimLines?.Item, ac_);
						Tuple_HDUYFgZGRCJCdTeEcMSVCMQNN ae_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDateTime> aq_()
							{
								if ((context.Operators.Not((bool?)(i?.Quantity is null)) ?? false))
								{
									CqlInterval<CqlDateTime> as_()
									{
										if (i?.Serviced is Period)
										{
											var at_ = NCQAFHIRBase_1_0_0.Normalize_Interval(i?.Serviced);
											var au_ = context.Operators.Start(at_);
											var aw_ = context.Operators.Start(at_);
											var ax_ = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement);
											var ay_ = context.Operators.Add(aw_, new CqlQuantity(ax_, "day"));
											var az_ = context.Operators.Quantity(1m, "day");
											var ba_ = context.Operators.Subtract(ay_, az_);
											var bb_ = context.Operators.Interval(au_, ba_, true, true);

											return bb_;
										}
										else
										{
											var bc_ = FHIRHelpers_4_0_001.ToDate((i?.Serviced as Date));
											var be_ = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement);
											var bf_ = context.Operators.Add(bc_, new CqlQuantity(be_, "day"));
											var bg_ = context.Operators.Quantity(1m, "day");
											var bh_ = context.Operators.Subtract(bf_, bg_);
											var bi_ = context.Operators.Interval(bc_, bh_, true, true);
											var bj_ = context.Operators.ConvertDateToDateTime(bi_?.low);
											var bn_ = context.Operators.Add(bc_, new CqlQuantity(be_, "day"));
											var bp_ = context.Operators.Subtract(bn_, bg_);
											var bq_ = context.Operators.Interval(bc_, bp_, true, true);
											var br_ = context.Operators.ConvertDateToDateTime(bq_?.high);
											var bv_ = context.Operators.Add(bc_, new CqlQuantity(be_, "day"));
											var bx_ = context.Operators.Subtract(bv_, bg_);
											var by_ = context.Operators.Interval(bc_, bx_, true, true);
											var cc_ = context.Operators.Add(bc_, new CqlQuantity(be_, "day"));
											var ce_ = context.Operators.Subtract(cc_, bg_);
											var cf_ = context.Operators.Interval(bc_, ce_, true, true);
											var cg_ = context.Operators.Interval(bj_, br_, by_?.lowClosed, cf_?.highClosed);

											return cg_;
										};
									};

									return as_();
								}
								else
								{
									return null;
								};
							};
							var ar_ = new Tuple_HDUYFgZGRCJCdTeEcMSVCMQNN
							{
								DaysSupplyInterval = aq_(),
							};

							return ar_;
						};
						var af_ = context.Operators.Select<Claim.ItemComponent, Tuple_HDUYFgZGRCJCdTeEcMSVCMQNN>(ad_, ae_);
						var ag_ = new Tuple_fQfNOLePNSNdOZROKRAfMQPE
						{
							CoveredDays = af_,
						};
						var ah_ = new Tuple_fQfNOLePNSNdOZROKRAfMQPE[]
						{
							ag_,
						};
						Tuple_GGLURZZjYLMjhaMLVbjKOcMAY ai_(Tuple_fQfNOLePNSNdOZROKRAfMQPE ItemCalculation)
						{
							Tuple_GGLURZZjYLMjhaMLVbjKOcMAY ch_()
							{
								if ((context.Operators.Exists<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
								{
									bool? ci_(Claim.ItemComponent @this)
									{
										var cr_ = context.Operators.Not((bool?)(@this?.Serviced is null));

										return cr_;
									};
									var cj_ = context.Operators.Where<Claim.ItemComponent>(LineItemDefinition?.LineItems, ci_);
									DataType ck_(Claim.ItemComponent @this) => 
										@this?.Serviced;
									var cl_ = context.Operators.Select<Claim.ItemComponent, DataType>(cj_, ck_);
									CqlInterval<CqlDateTime> cm_(DataType NormalDate)
									{
										var cs_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

										return cs_;
									};
									var cn_ = context.Operators.Select<DataType, CqlInterval<CqlDateTime>>(cl_, cm_);
									CqlInterval<CqlDateTime> co_(Tuple_HDUYFgZGRCJCdTeEcMSVCMQNN d) => 
										d?.DaysSupplyInterval;
									var cp_ = context.Operators.Select<Tuple_HDUYFgZGRCJCdTeEcMSVCMQNN, CqlInterval<CqlDateTime>>(ItemCalculation?.CoveredDays, co_);
									var cq_ = new Tuple_GGLURZZjYLMjhaMLVbjKOcMAY
									{
										Claim = LineItemDefinition?.Claim,
										LineItem = LineItemDefinition?.LineItems,
										ServicePeriod = cn_,
										CoveredDays = cp_,
									};

									return cq_;
								}
								else
								{
									return null;
								};
							};

							return ch_();
						};
						var aj_ = context.Operators.Select<Tuple_fQfNOLePNSNdOZROKRAfMQPE, Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(ah_, ai_);
						var ak_ = context.Operators.SingletonFrom<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(aj_);

						return ak_;
					};
					var aa_ = context.Operators.Select<Claim, Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(y_, z_);
					var ab_ = context.Operators.SingletonFrom<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(aa_);

					return ab_;
				};
				var r_ = context.Operators.Select<Tuple_HSdidNdfHCNCFSUTgBiYLcgXP, Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(p_, q_);
				var s_ = context.Operators.SingletonFrom<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(r_);

				return s_;
			};
			var j_ = context.Operators.Select<Claim, Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(ClaimWithMedication?.PharmacyClaim, i_);
			bool? k_(Tuple_GGLURZZjYLMjhaMLVbjKOcMAY FinalList)
			{
				var ct_ = context.Operators.Not((bool?)(FinalList is null));

				return ct_;
			};
			var l_ = context.Operators.Where<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(j_, k_);

			return l_;
		};
		var g_ = context.Operators.Select<Tuple_FKhUcAPjDECbaDReYbaiLXOHd, IEnumerable<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>>(e_, f_);
		var h_ = context.Operators.SingletonFrom<IEnumerable<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis and Procedure")]
	public IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd> Medical_Claims_With_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d) => 
			d?.code;
		var c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p) => 
			p?.code;
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
			IEnumerable<Claim> k_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					return null;
				}
				else
				{
					bool? q_(Claim DiagnosisLine)
					{
						bool? s_(Claim.DiagnosisComponent @this)
						{
							var ae_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

							return ae_;
						};
						var t_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)DiagnosisLine?.Diagnosis, s_);
						DataType u_(Claim.DiagnosisComponent @this) => 
							@this?.Diagnosis;
						var v_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(t_, u_);
						bool? w_(DataType @this)
						{
							var af_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							var ag_ = context.Operators.Not((bool?)(af_ is null));

							return ag_;
						};
						var x_ = context.Operators.Where<DataType>(v_, w_);
						object y_(DataType @this)
						{
							var ah_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return ah_;
						};
						var z_ = context.Operators.Select<DataType, object>(x_, y_);
						var aa_ = context.Operators.FlattenLateBoundList(z_);
						bool? ab_(object HeaderCode)
						{
							var ai_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
							var aj_ = context.Operators.In<string>(ai_?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings);

							return aj_;
						};
						var ac_ = context.Operators.Where<object>(aa_, ab_);
						var ad_ = context.Operators.Exists<object>(ac_);

						return ad_;
					};
					var r_ = context.Operators.Where<Claim>(ClaimWithDiagnosis?.MedicalClaim, q_);

					return r_;
				};
			};
			var l_ = new Tuple_GDVcejYEWXWNHUIODacaMaBhV
			{
				DiagnosisItems = k_(),
			};
			var m_ = new Tuple_GDVcejYEWXWNHUIODacaMaBhV[]
			{
				l_,
			};
			IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd> n_(Tuple_GDVcejYEWXWNHUIODacaMaBhV ClaimWithProcedure)
			{
				Tuple_GDUUTAIXZafehWFjcGfNKBcTd ak_(Claim ClaimofInterest)
				{
					Claim ao_()
					{
						if ((ClaimofInterest is null))
						{
							return null;
						}
						else
						{
							var au_ = new Claim[]
							{
								ClaimofInterest,
							};
							bool? av_(Claim ItemOnLine)
							{
								bool? ay_(Claim.ProcedureComponent @this)
								{
									var bx_ = context.Operators.Not((bool?)(@this?.Procedure is null));

									return bx_;
								};
								var az_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)ItemOnLine?.Procedure, ay_);
								DataType ba_(Claim.ProcedureComponent @this) => 
									@this?.Procedure;
								var bb_ = context.Operators.Select<Claim.ProcedureComponent, DataType>(az_, ba_);
								bool? bc_(DataType @this)
								{
									var by_ = context.Operators.LateBoundProperty<object>(@this, "coding");
									var bz_ = context.Operators.Not((bool?)(by_ is null));

									return bz_;
								};
								var bd_ = context.Operators.Where<DataType>(bb_, bc_);
								object be_(DataType @this)
								{
									var ca_ = context.Operators.LateBoundProperty<object>(@this, "coding");

									return ca_;
								};
								var bf_ = context.Operators.Select<DataType, object>(bd_, be_);
								var bg_ = context.Operators.FlattenLateBoundList(bf_);
								bool? bh_(object ProcedureHeaderCode)
								{
									var cb_ = context.Operators.LateBoundProperty<Code>(ProcedureHeaderCode, "code");
									var cc_ = context.Operators.In<string>(cb_?.Value, ClaimWithDiagnosis?.ProceduresAsStrings);

									return cc_;
								};
								var bi_ = context.Operators.Where<object>(bg_, bh_);
								var bj_ = context.Operators.Exists<object>(bi_);
								bool? bk_(Claim.ItemComponent @this)
								{
									var cd_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

									return cd_;
								};
								var bl_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ItemOnLine?.Item, bk_);
								CodeableConcept bm_(Claim.ItemComponent @this) => 
									@this?.ProductOrService;
								var bn_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(bl_, bm_);
								bool? bo_(CodeableConcept @this)
								{
									var ce_ = context.Operators.Not((bool?)(@this?.Coding is null));

									return ce_;
								};
								var bp_ = context.Operators.Where<CodeableConcept>(bn_, bo_);
								List<Coding> bq_(CodeableConcept @this) => 
									@this?.Coding;
								var br_ = context.Operators.Select<CodeableConcept, List<Coding>>(bp_, bq_);
								var bs_ = context.Operators.Flatten<Coding>(br_);
								bool? bt_(Coding LineCode)
								{
									var cf_ = context.Operators.In<string>(LineCode?.CodeElement?.Value, ClaimWithDiagnosis?.ProceduresAsStrings);

									return cf_;
								};
								var bu_ = context.Operators.Where<Coding>(bs_, bt_);
								var bv_ = context.Operators.Exists<Coding>(bu_);
								var bw_ = context.Operators.Or(bj_, bv_);

								return bw_;
							};
							var aw_ = context.Operators.Where<Claim>(au_, av_);
							var ax_ = context.Operators.SingletonFrom<Claim>(aw_);

							return ax_;
						};
					};
					var ap_ = new Tuple_CXESjjTOQIGKICAEMDgcfPdJG
					{
						ProcedureItems = ao_(),
					};
					var aq_ = new Tuple_CXESjjTOQIGKICAEMDgcfPdJG[]
					{
						ap_,
					};
					Tuple_GDUUTAIXZafehWFjcGfNKBcTd ar_(Tuple_CXESjjTOQIGKICAEMDgcfPdJG HeaderDefinition)
					{
						Tuple_GDUUTAIXZafehWFjcGfNKBcTd cg_()
						{
							if ((context.Operators.Not((bool?)(HeaderDefinition?.ProcedureItems is null)) ?? false))
							{
								CqlInterval<CqlDateTime> ch_(Claim.ItemComponent NormalDate)
								{
									var ck_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced);

									return ck_;
								};
								var ci_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)HeaderDefinition?.ProcedureItems?.Item, ch_);
								var cj_ = new Tuple_GDUUTAIXZafehWFjcGfNKBcTd
								{
									Claim = HeaderDefinition?.ProcedureItems,
									ServicePeriod = ci_,
								};

								return cj_;
							}
							else
							{
								return null;
							};
						};

						return cg_();
					};
					var as_ = context.Operators.Select<Tuple_CXESjjTOQIGKICAEMDgcfPdJG, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(aq_, ar_);
					var at_ = context.Operators.SingletonFrom<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(as_);

					return at_;
				};
				var al_ = context.Operators.Select<Claim, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(ClaimWithProcedure?.DiagnosisItems, ak_);
				bool? am_(Tuple_GDUUTAIXZafehWFjcGfNKBcTd FinalList)
				{
					var cl_ = context.Operators.Not((bool?)(FinalList is null));

					return cl_;
				};
				var an_ = context.Operators.Where<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(al_, am_);

				return an_;
			};
			var o_ = context.Operators.Select<Tuple_GDVcejYEWXWNHUIODacaMaBhV, IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(m_, n_);
			var p_ = context.Operators.SingletonFrom<IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(o_);

			return p_;
		};
		var i_ = context.Operators.Select<Tuple_YMFSFZNbUOGiNXDVNeBOchca, IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(g_, h_);
		var j_ = context.Operators.SingletonFrom<IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis and Procedure")]
	public IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd> Medical_Claims_With_Principal_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d) => 
			d?.code;
		var c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p) => 
			p?.code;
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
			Tuple_GDUUTAIXZafehWFjcGfNKBcTd k_(Claim ClaimofInterest)
			{
				Claim o_()
				{
					if ((ClaimofInterest is null))
					{
						return null;
					}
					else
					{
						var u_ = new Claim[]
						{
							ClaimofInterest,
						};
						bool? v_(Claim ItemOnLine)
						{
							bool? y_(Claim.ItemComponent @this)
							{
								var ax_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

								return ax_;
							};
							var z_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ItemOnLine?.Item, y_);
							CodeableConcept aa_(Claim.ItemComponent @this) => 
								@this?.ProductOrService;
							var ab_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(z_, aa_);
							bool? ac_(CodeableConcept @this)
							{
								var ay_ = context.Operators.Not((bool?)(@this?.Coding is null));

								return ay_;
							};
							var ad_ = context.Operators.Where<CodeableConcept>(ab_, ac_);
							List<Coding> ae_(CodeableConcept @this) => 
								@this?.Coding;
							var af_ = context.Operators.Select<CodeableConcept, List<Coding>>(ad_, ae_);
							var ag_ = context.Operators.Flatten<Coding>(af_);
							bool? ah_(Coding LineCode)
							{
								var az_ = context.Operators.In<string>(LineCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings);

								return az_;
							};
							var ai_ = context.Operators.Where<Coding>(ag_, ah_);
							var aj_ = context.Operators.Exists<Coding>(ai_);
							bool? ak_(Claim.ProcedureComponent @this)
							{
								var ba_ = context.Operators.Not((bool?)(@this?.Procedure is null));

								return ba_;
							};
							var al_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)ItemOnLine?.Procedure, ak_);
							DataType am_(Claim.ProcedureComponent @this) => 
								@this?.Procedure;
							var an_ = context.Operators.Select<Claim.ProcedureComponent, DataType>(al_, am_);
							bool? ao_(DataType @this)
							{
								var bb_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								var bc_ = context.Operators.Not((bool?)(bb_ is null));

								return bc_;
							};
							var ap_ = context.Operators.Where<DataType>(an_, ao_);
							object aq_(DataType @this)
							{
								var bd_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return bd_;
							};
							var ar_ = context.Operators.Select<DataType, object>(ap_, aq_);
							var as_ = context.Operators.FlattenLateBoundList(ar_);
							bool? at_(object HeaderCode)
							{
								var be_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
								var bf_ = context.Operators.In<string>(be_?.Value, ClaimWithProcedure?.ProceduresAsStrings);

								return bf_;
							};
							var au_ = context.Operators.Where<object>(as_, at_);
							var av_ = context.Operators.Exists<object>(au_);
							var aw_ = context.Operators.Or(aj_, av_);

							return aw_;
						};
						var w_ = context.Operators.Where<Claim>(u_, v_);
						var x_ = context.Operators.SingletonFrom<Claim>(w_);

						return x_;
					};
				};
				var p_ = new Tuple_FYaKYiIDIQCIRBfhZCGRDYQLX
				{
					Claim = ClaimofInterest,
					ProcedureItems = o_(),
				};
				var q_ = new Tuple_FYaKYiIDIQCIRBfhZCGRDYQLX[]
				{
					p_,
				};
				Tuple_GDUUTAIXZafehWFjcGfNKBcTd r_(Tuple_FYaKYiIDIQCIRBfhZCGRDYQLX DiagnosisCheck)
				{
					var bg_ = new Claim[]
					{
						DiagnosisCheck?.ProcedureItems,
					};
					Tuple_GDUUTAIXZafehWFjcGfNKBcTd bh_(Claim ClaimforDiagnosis)
					{
						Claim bk_()
						{
							if ((ClaimforDiagnosis is null))
							{
								return null;
							}
							else
							{
								var bq_ = new Claim[]
								{
									ClaimforDiagnosis,
								};
								bool? br_(Claim RightClaim)
								{
									bool? bu_(Claim.DiagnosisComponent RightDiagnosis)
									{
										var bx_ = context.Operators.Convert<Integer>(RightDiagnosis?.SequenceElement);
										var by_ = FHIRHelpers_4_0_001.ToInteger(bx_);
										var bz_ = context.Operators.Equal(by_, 1);
										var ca_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(RightDiagnosis?.Diagnosis, "coding");
										bool? cb_(Coding DiagnosisCode)
										{
											var cf_ = context.Operators.In<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithProcedure?.DiagnosesAsStrings);

											return cf_;
										};
										var cc_ = context.Operators.Where<Coding>(ca_, cb_);
										var cd_ = context.Operators.Exists<Coding>(cc_);
										var ce_ = context.Operators.And(bz_, cd_);

										return ce_;
									};
									var bv_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)RightClaim?.Diagnosis, bu_);
									var bw_ = context.Operators.Exists<Claim.DiagnosisComponent>(bv_);

									return bw_;
								};
								var bs_ = context.Operators.Where<Claim>(bq_, br_);
								var bt_ = context.Operators.SingletonFrom<Claim>(bs_);

								return bt_;
							};
						};
						var bl_ = new Tuple_GQgIaRFaPGOSKbMdfSGVEWcNA
						{
							Procedure = (IEnumerable<Claim.ItemComponent>)ClaimforDiagnosis?.Item,
							LineItems = bk_(),
						};
						var bm_ = new Tuple_GQgIaRFaPGOSKbMdfSGVEWcNA[]
						{
							bl_,
						};
						Tuple_GDUUTAIXZafehWFjcGfNKBcTd bn_(Tuple_GQgIaRFaPGOSKbMdfSGVEWcNA LineItemDefinition)
						{
							Tuple_GDUUTAIXZafehWFjcGfNKBcTd cg_()
							{
								bool ch_()
								{
									var ci_ = context.Operators.Not((bool?)(LineItemDefinition is null));
									var cj_ = context.Operators.Not((bool?)(LineItemDefinition?.LineItems is null));
									var ck_ = context.Operators.And(ci_, cj_);

									return (ck_ ?? false);
								};
								if (ch_())
								{
									CqlInterval<CqlDateTime> cl_(Claim.ItemComponent NormalDate)
									{
										var co_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced);

										return co_;
									};
									var cm_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)LineItemDefinition?.LineItems?.Item, cl_);
									var cn_ = new Tuple_GDUUTAIXZafehWFjcGfNKBcTd
									{
										Claim = LineItemDefinition?.LineItems,
										ServicePeriod = cm_,
									};

									return cn_;
								}
								else
								{
									return null;
								};
							};

							return cg_();
						};
						var bo_ = context.Operators.Select<Tuple_GQgIaRFaPGOSKbMdfSGVEWcNA, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(bm_, bn_);
						var bp_ = context.Operators.SingletonFrom<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(bo_);

						return bp_;
					};
					var bi_ = context.Operators.Select<Claim, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(bg_, bh_);
					var bj_ = context.Operators.SingletonFrom<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(bi_);

					return bj_;
				};
				var s_ = context.Operators.Select<Tuple_FYaKYiIDIQCIRBfhZCGRDYQLX, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(q_, r_);
				var t_ = context.Operators.SingletonFrom<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(s_);

				return t_;
			};
			var l_ = context.Operators.Select<Claim, Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(ClaimWithProcedure?.MedicalClaim, k_);
			bool? m_(Tuple_GDUUTAIXZafehWFjcGfNKBcTd FinalList)
			{
				var cp_ = context.Operators.Not((bool?)(FinalList is null));

				return cp_;
			};
			var n_ = context.Operators.Where<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>(l_, m_);

			return n_;
		};
		var i_ = context.Operators.Select<Tuple_YMFSFZNbUOGiNXDVNeBOchca, IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(g_, h_);
		var j_ = context.Operators.SingletonFrom<IEnumerable<Tuple_GDUUTAIXZafehWFjcGfNKBcTd>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis")]
	public IEnumerable<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg> Medical_Claims_With_Principal_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d) => 
			d?.code;
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
			IEnumerable<Claim> i_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					return null;
				}
				else
				{
					bool? o_(Claim RightClaim)
					{
						bool? q_(Claim.DiagnosisComponent RightDiagnosis)
						{
							var t_ = context.Operators.Convert<Integer>(RightDiagnosis?.SequenceElement);
							var u_ = FHIRHelpers_4_0_001.ToInteger(t_);
							var v_ = context.Operators.Equal(u_, 1);
							var w_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(RightDiagnosis?.Diagnosis, "coding");
							bool? x_(Coding DiagnosisCode)
							{
								var ab_ = context.Operators.In<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings);

								return ab_;
							};
							var y_ = context.Operators.Where<Coding>(w_, x_);
							var z_ = context.Operators.Exists<Coding>(y_);
							var aa_ = context.Operators.And(v_, z_);

							return aa_;
						};
						var r_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)RightClaim?.Diagnosis, q_);
						var s_ = context.Operators.Exists<Claim.DiagnosisComponent>(r_);

						return s_;
					};
					var p_ = context.Operators.Where<Claim>(ClaimWithDiagnosis?.MedicalClaim, o_);

					return p_;
				};
			};
			var j_ = new Tuple_DBEDLLOihLKGPWLHVWXRKfGdL
			{
				LineItems = i_(),
			};
			var k_ = new Tuple_DBEDLLOihLKGPWLHVWXRKfGdL[]
			{
				j_,
			};
			IEnumerable<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg> l_(Tuple_DBEDLLOihLKGPWLHVWXRKfGdL LineItemDefinition)
			{
				Tuple_CWDDWHRXGADEbdaKXCdKbgEfg ac_(Claim ClaimWithDiagnosis)
				{
					Tuple_CWDDWHRXGADEbdaKXCdKbgEfg ag_()
					{
						if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null)) ?? false))
						{
							bool? ah_(Claim @this)
							{
								var ap_ = context.Operators.Not((bool?)(@this?.Item is null));

								return ap_;
							};
							var ai_ = context.Operators.Where<Claim>(LineItemDefinition?.LineItems, ah_);
							List<Claim.ItemComponent> aj_(Claim @this) => 
								@this?.Item;
							var ak_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ai_, aj_);
							var al_ = context.Operators.Flatten<Claim.ItemComponent>(ak_);
							CqlInterval<CqlDateTime> am_(Claim.ItemComponent NormalDate)
							{
								var aq_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced);

								return aq_;
							};
							var an_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(al_, am_);
							var ao_ = new Tuple_CWDDWHRXGADEbdaKXCdKbgEfg
							{
								Claim = LineItemDefinition?.LineItems,
								ServicePeriod = an_,
							};

							return ao_;
						}
						else
						{
							return null;
						};
					};

					return ag_();
				};
				var ad_ = context.Operators.Select<Claim, Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>(LineItemDefinition?.LineItems, ac_);
				bool? ae_(Tuple_CWDDWHRXGADEbdaKXCdKbgEfg FinalList)
				{
					var ar_ = context.Operators.Not((bool?)(FinalList is null));

					return ar_;
				};
				var af_ = context.Operators.Where<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>(ad_, ae_);

				return af_;
			};
			var m_ = context.Operators.Select<Tuple_DBEDLLOihLKGPWLHVWXRKfGdL, IEnumerable<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>>(k_, l_);
			var n_ = context.Operators.SingletonFrom<IEnumerable<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>>(m_);

			return n_;
		};
		var g_ = context.Operators.Select<Tuple_DKCCfPXSWPMBNeFXdjEFGiRcF, IEnumerable<Tuple_CWDDWHRXGADEbdaKXCdKbgEfg>>(e_, f_);
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
			var h_ = FHIRHelpers_4_0_001.ToString(ResponseItem?.OutcomeElement);
			var i_ = new string[]
			{
				"complete",
				"partial",
			};
			var j_ = context.Operators.In<string>(h_, (i_ as IEnumerable<string>));

			return j_;
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
			Tuple_BYXPfHJAafYUZgPBifWFNjLXc k_(ClaimResponse ClmResp)
			{
				var m_ = FHIRHelpers_4_0_001.ToString(ClmResp?.Request?.ReferenceElement);
				var n_ = NCQAFHIRBase_1_0_0.GetId(m_);
				bool? o_(ClaimResponse.ItemComponent ResponseItem)
				{
					bool? r_(ClaimResponse.AdjudicationComponent @this)
					{
						var al_ = context.Operators.Not((bool?)(@this?.Category is null));

						return al_;
					};
					var s_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>(ResponseItem?.Adjudication, r_);
					CodeableConcept t_(ClaimResponse.AdjudicationComponent @this) => 
						@this?.Category;
					var u_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, CodeableConcept>(s_, t_);
					bool? v_(CodeableConcept @this)
					{
						var am_ = context.Operators.Not((bool?)(@this?.Coding is null));

						return am_;
					};
					var w_ = context.Operators.Where<CodeableConcept>(u_, v_);
					List<Coding> x_(CodeableConcept @this) => 
						@this?.Coding;
					var y_ = context.Operators.Select<CodeableConcept, List<Coding>>(w_, x_);
					var z_ = context.Operators.Flatten<Coding>(y_);
					bool? aa_(Coding CategoryItem)
					{
						var an_ = context.Operators.Equal(CategoryItem?.CodeElement?.Value, "benefit");

						return an_;
					};
					var ab_ = context.Operators.Where<Coding>(z_, aa_);
					var ac_ = context.Operators.Exists<Coding>(ab_);
					bool? ad_(ClaimResponse.AdjudicationComponent @this)
					{
						var ao_ = context.Operators.Not((bool?)(@this?.Amount is null));

						return ao_;
					};
					var ae_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>(ResponseItem?.Adjudication, ad_);
					Money af_(ClaimResponse.AdjudicationComponent @this) => 
						@this?.Amount;
					var ag_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, Money>(ae_, af_);
					bool? ah_(Money DollarAmount)
					{
						var ap_ = FHIRHelpers_4_0_001.ToDecimal(DollarAmount?.ValueElement);
						var aq_ = context.Operators.ConvertIntegerToDecimal(0);
						var ar_ = context.Operators.Greater(ap_, aq_);

						return ar_;
					};
					var ai_ = context.Operators.Where<Money>(ag_, ah_);
					var aj_ = context.Operators.Exists<Money>(ai_);
					var ak_ = context.Operators.And(ac_, aj_);

					return ak_;
				};
				var p_ = context.Operators.Where<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)ClmResp?.Item, o_);
				var q_ = new Tuple_BYXPfHJAafYUZgPBifWFNjLXc
				{
					Response = ClmResp,
					ResponseID = n_,
					LineItems = p_,
				};

				return q_;
			};
			var l_ = context.Operators.Select<ClaimResponse, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(ClaimResponse?.PaidResponse, k_);

			return l_;
		};
		var f_ = context.Operators.Select<Tuple_DbDPVOODdCjASWRZfBTBPUJKR, IEnumerable<Tuple_BYXPfHJAafYUZgPBifWFNjLXc>>(d_, e_);
		var g_ = context.Operators.SingletonFrom<IEnumerable<Tuple_BYXPfHJAafYUZgPBifWFNjLXc>>(f_);

		return g_;
	}

    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
	public IEnumerable<Tuple_EFDOJaOgOPCDJDhPijASNAPMd> Get_All_Claims_With_Procedure_and_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			bool? e_(Claim.ItemComponent @this)
			{
				var ad_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

				return ad_;
			};
			var f_ = context.Operators.Where<Claim.ItemComponent>(AllClaims?.Item, e_);
			CodeableConcept g_(Claim.ItemComponent @this) => 
				@this?.ProductOrService;
			var h_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(f_, g_);
			bool? i_(CodeableConcept @this)
			{
				var ae_ = context.Operators.Not((bool?)(@this?.Coding is null));

				return ae_;
			};
			var j_ = context.Operators.Where<CodeableConcept>(h_, i_);
			List<Coding> k_(CodeableConcept @this) => 
				@this?.Coding;
			var l_ = context.Operators.Select<CodeableConcept, List<Coding>>(j_, k_);
			var m_ = context.Operators.Flatten<Coding>(l_);
			bool? n_(Coding ProductOrServiceCode)
			{
				var af_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var ag_ = context.Operators.In<CqlCode>(af_, ProductOrServiceValueSet);

				return ag_;
			};
			var o_ = context.Operators.Where<Coding>(m_, n_);
			var p_ = context.Operators.Exists<Coding>(o_);
			bool? q_(Claim.DiagnosisComponent @this)
			{
				var ah_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

				return ah_;
			};
			var r_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)AllClaims?.Diagnosis, q_);
			DataType s_(Claim.DiagnosisComponent @this) => 
				@this?.Diagnosis;
			var t_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(r_, s_);
			bool? u_(DataType @this)
			{
				var ai_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				var aj_ = context.Operators.Not((bool?)(ai_ is null));

				return aj_;
			};
			var v_ = context.Operators.Where<DataType>(t_, u_);
			object w_(DataType @this)
			{
				var ak_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return ak_;
			};
			var x_ = context.Operators.Select<DataType, object>(v_, w_);
			var y_ = context.Operators.FlattenLateBoundList(x_);
			bool? z_(object DiagnosisCode)
			{
				var al_ = FHIRHelpers_4_0_001.ToCode((Coding)DiagnosisCode);
				var am_ = context.Operators.In<CqlCode>(al_, DiagnosisValueSet);

				return am_;
			};
			var aa_ = context.Operators.Where<object>(y_, z_);
			var ab_ = context.Operators.Exists<object>(aa_);
			var ac_ = context.Operators.And(p_, ab_);

			return ac_;
		};
		var b_ = context.Operators.Where<Claim>(claim, a_);
		Tuple_EFDOJaOgOPCDJDhPijASNAPMd c_(Claim ProcedureClaims)
		{
			bool? an_(Claim.ItemComponent ResponseItem)
			{
				bool? aq_(Coding ProductOrServiceCode)
				{
					var at_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var au_ = context.Operators.In<CqlCode>(at_, ProductOrServiceValueSet);

					return au_;
				};
				var ar_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ResponseItem?.ProductOrService?.Coding, aq_);
				var as_ = context.Operators.Exists<Coding>(ar_);

				return as_;
			};
			var ao_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ProcedureClaims?.Item, an_);
			var ap_ = new Tuple_EFDOJaOgOPCDJDhPijASNAPMd
			{
				ClaimofInterest = ProcedureClaims,
				ClaimID = ProcedureClaims?.IdElement,
				LineItems = ao_,
			};

			return ap_;
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
			Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT h_(Tuple_EFDOJaOgOPCDJDhPijASNAPMd medClaim)
			{
				bool? o_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<Tuple_BYXPfHJAafYUZgPBifWFNjLXc> r_(Tuple_BYXPfHJAafYUZgPBifWFNjLXc pClaim)
					{
						bool? u_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var y_ = FHIRHelpers_4_0_001.ToString(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: null));
							var z_ = FHIRHelpers_4_0_001.ToString(pClaim?.Response?.Request?.ReferenceElement);
							var aa_ = NCQAFHIRBase_1_0_0.GetId(z_);
							var ab_ = context.Operators.Equal(y_, aa_);
							var ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							var ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							var ae_ = context.Operators.Equal(ac_, ad_);
							var af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						var v_ = context.Operators.Where<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuple_BYXPfHJAafYUZgPBifWFNjLXc w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var x_ = context.Operators.Select<ClaimResponse.ItemComponent, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(v_, w_);

						return x_;
					};
					var s_ = context.Operators.SelectMany<Tuple_BYXPfHJAafYUZgPBifWFNjLXc, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(ClaimAndResponse?.PaidMedicalClaimResponse, r_);
					var t_ = context.Operators.Exists<Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(s_);

					return t_;
				};
				var p_ = context.Operators.Where<Claim.ItemComponent>(medClaim?.LineItems, o_);
				var q_ = new Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			var i_ = context.Operators.Select<Tuple_EFDOJaOgOPCDJDhPijASNAPMd, Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ClaimAndResponse?.MedicalClaim, h_);
			var j_ = new Tuple_GUibhjYMgjAQISFDJORUOccJC
			{
				AggregateClaim = i_,
			};
			var k_ = new Tuple_GUibhjYMgjAQISFDJORUOccJC[]
			{
				j_,
			};
			Tuple_FCOUVKRRWVHcKiBDUdGgLciKR l_(Tuple_GUibhjYMgjAQISFDJORUOccJC ClaimWithPaidResponse)
			{
				Tuple_FCOUVKRRWVHcKiBDUdGgLciKR ag_()
				{
					bool al_()
					{
						bool? am_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var as_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return as_;
						};
						var an_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ClaimWithPaidResponse?.AggregateClaim, am_);
						IEnumerable<Claim.ItemComponent> ao_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this) => 
							@this?.ClaimItem;
						var ap_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, IEnumerable<Claim.ItemComponent>>(an_, ao_);
						var aq_ = context.Operators.Flatten<Claim.ItemComponent>(ap_);
						var ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);

						return (ar_ ?? false);
					};
					if (al_())
					{
						bool? at_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var bf_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return bf_;
						};
						var au_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ClaimWithPaidResponse?.AggregateClaim, at_);
						Tuple_EFDOJaOgOPCDJDhPijASNAPMd av_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this) => 
							@this?.PaidClaim;
						var aw_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, Tuple_EFDOJaOgOPCDJDhPijASNAPMd>(au_, av_);
						bool? ax_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var bg_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bg_;
						};
						var ay_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ClaimWithPaidResponse?.AggregateClaim, ax_);
						IEnumerable<Claim.ItemComponent> az_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this) => 
							@this?.ClaimItem;
						var ba_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, IEnumerable<Claim.ItemComponent>>(ay_, az_);
						var bb_ = context.Operators.Flatten<Claim.ItemComponent>(ba_);
						CqlInterval<CqlDateTime> bc_(Claim.ItemComponent PaidItem)
						{
							var bh_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced);

							return bh_;
						};
						var bd_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, bc_);
						var be_ = new Tuple_FCOUVKRRWVHcKiBDUdGgLciKR
						{
							originalClaim = aw_,
							ServicePeriod = bd_,
						};

						return be_;
					}
					else
					{
						return null;
					};
				};
				var ah_ = new Tuple_FCOUVKRRWVHcKiBDUdGgLciKR[]
				{
					ag_(),
				};
				bool? ai_(Tuple_FCOUVKRRWVHcKiBDUdGgLciKR FinalList)
				{
					var bi_ = context.Operators.Not((bool?)(FinalList is null));

					return bi_;
				};
				var aj_ = context.Operators.Where<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(ah_, ai_);
				var ak_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(aj_);

				return ak_;
			};
			var m_ = context.Operators.Select<Tuple_GUibhjYMgjAQISFDJORUOccJC, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(k_, l_);
			var n_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(m_);

			return n_;
		};
		var f_ = context.Operators.Select<Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(d_, e_);
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
				if ((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
				{
					return null;
				}
				else
				{
					var k_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet);

					return k_;
				};
			};

			return j_();
		};
		var d_ = context.Operators.Select<Tuple_BPLeiOPPLaJQZIggaPXFWcaBO, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(b_, c_);
		var e_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(d_);
		var f_ = new Tuple_FCOUVKRRWVHcKiBDUdGgLciKR[]
		{
			e_,
		};
		bool? g_(Tuple_FCOUVKRRWVHcKiBDUdGgLciKR FinalList)
		{
			var l_ = context.Operators.Not((bool?)(FinalList is null));

			return l_;
		};
		var h_ = context.Operators.Where<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(f_, g_);
		var i_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(h_);

		return i_;
	}

    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
	public IEnumerable<Tuple_EFDOJaOgOPCDJDhPijASNAPMd> Get_All_Claims_With_Procedure_or_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			bool? e_(Claim.ItemComponent @this)
			{
				var ad_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

				return ad_;
			};
			var f_ = context.Operators.Where<Claim.ItemComponent>(AllClaims?.Item, e_);
			CodeableConcept g_(Claim.ItemComponent @this) => 
				@this?.ProductOrService;
			var h_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(f_, g_);
			bool? i_(CodeableConcept @this)
			{
				var ae_ = context.Operators.Not((bool?)(@this?.Coding is null));

				return ae_;
			};
			var j_ = context.Operators.Where<CodeableConcept>(h_, i_);
			List<Coding> k_(CodeableConcept @this) => 
				@this?.Coding;
			var l_ = context.Operators.Select<CodeableConcept, List<Coding>>(j_, k_);
			var m_ = context.Operators.Flatten<Coding>(l_);
			bool? n_(Coding ProductOrServiceCode)
			{
				var af_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var ag_ = context.Operators.In<CqlCode>(af_, ProductOrServiceValueSet);

				return ag_;
			};
			var o_ = context.Operators.Where<Coding>(m_, n_);
			var p_ = context.Operators.Exists<Coding>(o_);
			bool? q_(Claim.DiagnosisComponent @this)
			{
				var ah_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

				return ah_;
			};
			var r_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)AllClaims?.Diagnosis, q_);
			DataType s_(Claim.DiagnosisComponent @this) => 
				@this?.Diagnosis;
			var t_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(r_, s_);
			bool? u_(DataType @this)
			{
				var ai_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				var aj_ = context.Operators.Not((bool?)(ai_ is null));

				return aj_;
			};
			var v_ = context.Operators.Where<DataType>(t_, u_);
			object w_(DataType @this)
			{
				var ak_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return ak_;
			};
			var x_ = context.Operators.Select<DataType, object>(v_, w_);
			var y_ = context.Operators.FlattenLateBoundList(x_);
			bool? z_(object DiagnosisCode)
			{
				var al_ = FHIRHelpers_4_0_001.ToCode((Coding)DiagnosisCode);
				var am_ = context.Operators.In<CqlCode>(al_, DiagnosisValueSet);

				return am_;
			};
			var aa_ = context.Operators.Where<object>(y_, z_);
			var ab_ = context.Operators.Exists<object>(aa_);
			var ac_ = context.Operators.Or(p_, ab_);

			return ac_;
		};
		var b_ = context.Operators.Where<Claim>(claim, a_);
		Tuple_EFDOJaOgOPCDJDhPijASNAPMd c_(Claim ProcedureClaims)
		{
			Tuple_EFDOJaOgOPCDJDhPijASNAPMd an_()
			{
				bool ao_()
				{
					bool? ap_(Claim.ItemComponent ResponseItem)
					{
						bool? as_(Coding ProductOrServiceCode)
						{
							var av_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
							var aw_ = context.Operators.In<CqlCode>(av_, ProductOrServiceValueSet);

							return aw_;
						};
						var at_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ResponseItem?.ProductOrService?.Coding, as_);
						var au_ = context.Operators.Exists<Coding>(at_);

						return au_;
					};
					var aq_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ProcedureClaims?.Item, ap_);
					var ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);

					return (ar_ ?? false);
				};
				if (ao_())
				{
					bool? ax_(Claim.ItemComponent ResponseItem)
					{
						bool? ba_(Coding ProductOrServiceCode)
						{
							var bd_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
							var be_ = context.Operators.In<CqlCode>(bd_, ProductOrServiceValueSet);

							return be_;
						};
						var bb_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ResponseItem?.ProductOrService?.Coding, ba_);
						var bc_ = context.Operators.Exists<Coding>(bb_);

						return bc_;
					};
					var ay_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ProcedureClaims?.Item, ax_);
					var az_ = new Tuple_EFDOJaOgOPCDJDhPijASNAPMd
					{
						ClaimofInterest = ProcedureClaims,
						ClaimID = ProcedureClaims?.IdElement,
						LineItems = ay_,
					};

					return az_;
				}
				else
				{
					bool? bf_(Claim.ItemComponent ResponseItem)
					{
						var bi_ = context.Operators.Convert<Integer>(ResponseItem?.SequenceElement);
						var bj_ = context.Operators.Equal(bi_?.Value, 1);

						return bj_;
					};
					var bg_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ProcedureClaims?.Item, bf_);
					var bh_ = new Tuple_EFDOJaOgOPCDJDhPijASNAPMd
					{
						ClaimofInterest = ProcedureClaims,
						ClaimID = ProcedureClaims?.IdElement,
						LineItems = bg_,
					};

					return bh_;
				};
			};

			return an_();
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
			Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT h_(Tuple_EFDOJaOgOPCDJDhPijASNAPMd medClaim)
			{
				bool? o_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<Tuple_BYXPfHJAafYUZgPBifWFNjLXc> r_(Tuple_BYXPfHJAafYUZgPBifWFNjLXc pClaim)
					{
						bool? u_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var y_ = FHIRHelpers_4_0_001.ToString(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: null));
							var z_ = FHIRHelpers_4_0_001.ToString(pClaim?.Response?.Request?.ReferenceElement);
							var aa_ = NCQAFHIRBase_1_0_0.GetId(z_);
							var ab_ = context.Operators.Equal(y_, aa_);
							var ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							var ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							var ae_ = context.Operators.Equal(ac_, ad_);
							var af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						var v_ = context.Operators.Where<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuple_BYXPfHJAafYUZgPBifWFNjLXc w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var x_ = context.Operators.Select<ClaimResponse.ItemComponent, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(v_, w_);

						return x_;
					};
					var s_ = context.Operators.SelectMany<Tuple_BYXPfHJAafYUZgPBifWFNjLXc, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(ClaimAndResponse?.PaidMedicalClaimResponse, r_);
					var t_ = context.Operators.Exists<Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(s_);

					return t_;
				};
				var p_ = context.Operators.Where<Claim.ItemComponent>(medClaim?.LineItems, o_);
				var q_ = new Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			var i_ = context.Operators.Select<Tuple_EFDOJaOgOPCDJDhPijASNAPMd, Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ClaimAndResponse?.MedicalClaim, h_);
			var j_ = new Tuple_GUibhjYMgjAQISFDJORUOccJC
			{
				AggregateClaim = i_,
			};
			var k_ = new Tuple_GUibhjYMgjAQISFDJORUOccJC[]
			{
				j_,
			};
			Tuple_FCOUVKRRWVHcKiBDUdGgLciKR l_(Tuple_GUibhjYMgjAQISFDJORUOccJC ClaimWithPaidResponse)
			{
				Tuple_FCOUVKRRWVHcKiBDUdGgLciKR ag_()
				{
					bool al_()
					{
						bool? am_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var as_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return as_;
						};
						var an_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ClaimWithPaidResponse?.AggregateClaim, am_);
						IEnumerable<Claim.ItemComponent> ao_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this) => 
							@this?.ClaimItem;
						var ap_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, IEnumerable<Claim.ItemComponent>>(an_, ao_);
						var aq_ = context.Operators.Flatten<Claim.ItemComponent>(ap_);
						var ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);

						return (ar_ ?? false);
					};
					if (al_())
					{
						bool? at_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var bf_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return bf_;
						};
						var au_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ClaimWithPaidResponse?.AggregateClaim, at_);
						Tuple_EFDOJaOgOPCDJDhPijASNAPMd av_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this) => 
							@this?.PaidClaim;
						var aw_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, Tuple_EFDOJaOgOPCDJDhPijASNAPMd>(au_, av_);
						bool? ax_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var bg_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bg_;
						};
						var ay_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ClaimWithPaidResponse?.AggregateClaim, ax_);
						IEnumerable<Claim.ItemComponent> az_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this) => 
							@this?.ClaimItem;
						var ba_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, IEnumerable<Claim.ItemComponent>>(ay_, az_);
						var bb_ = context.Operators.Flatten<Claim.ItemComponent>(ba_);
						CqlInterval<CqlDateTime> bc_(Claim.ItemComponent PaidItem)
						{
							var bh_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced);

							return bh_;
						};
						var bd_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, bc_);
						var be_ = new Tuple_FCOUVKRRWVHcKiBDUdGgLciKR
						{
							originalClaim = aw_,
							ServicePeriod = bd_,
						};

						return be_;
					}
					else
					{
						return null;
					};
				};
				var ah_ = new Tuple_FCOUVKRRWVHcKiBDUdGgLciKR[]
				{
					ag_(),
				};
				bool? ai_(Tuple_FCOUVKRRWVHcKiBDUdGgLciKR FinalList)
				{
					var bi_ = context.Operators.Not((bool?)(FinalList is null));

					return bi_;
				};
				var aj_ = context.Operators.Where<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(ah_, ai_);
				var ak_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(aj_);

				return ak_;
			};
			var m_ = context.Operators.Select<Tuple_GUibhjYMgjAQISFDJORUOccJC, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(k_, l_);
			var n_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(m_);

			return n_;
		};
		var f_ = context.Operators.Select<Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(d_, e_);
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
				if ((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
				{
					return null;
				}
				else
				{
					var g_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet);

					return g_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.Select<Tuple_BPLeiOPPLaJQZIggaPXFWcaBO, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(b_, c_);
		var e_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(d_);

		return e_;
	}

    [CqlDeclaration("Get All Claims With Procedure Only")]
	public IEnumerable<Tuple_EFDOJaOgOPCDJDhPijASNAPMd> Get_All_Claims_With_Procedure_Only(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			bool? e_(Claim.ItemComponent @this)
			{
				var q_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

				return q_;
			};
			var f_ = context.Operators.Where<Claim.ItemComponent>(AllClaims?.Item, e_);
			CodeableConcept g_(Claim.ItemComponent @this) => 
				@this?.ProductOrService;
			var h_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(f_, g_);
			bool? i_(CodeableConcept @this)
			{
				var r_ = context.Operators.Not((bool?)(@this?.Coding is null));

				return r_;
			};
			var j_ = context.Operators.Where<CodeableConcept>(h_, i_);
			List<Coding> k_(CodeableConcept @this) => 
				@this?.Coding;
			var l_ = context.Operators.Select<CodeableConcept, List<Coding>>(j_, k_);
			var m_ = context.Operators.Flatten<Coding>(l_);
			bool? n_(Coding ProductOrServiceCode)
			{
				var s_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var t_ = context.Operators.In<CqlCode>(s_, ProductOrServiceValueSet);

				return t_;
			};
			var o_ = context.Operators.Where<Coding>(m_, n_);
			var p_ = context.Operators.Exists<Coding>(o_);

			return p_;
		};
		var b_ = context.Operators.Where<Claim>(claim, a_);
		Tuple_EFDOJaOgOPCDJDhPijASNAPMd c_(Claim AllClaims)
		{
			bool? u_(Claim.ItemComponent ResponseItem)
			{
				bool? x_(Coding ProductOrServiceCode)
				{
					var aa_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var ab_ = context.Operators.In<CqlCode>(aa_, ProductOrServiceValueSet);

					return ab_;
				};
				var y_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ResponseItem?.ProductOrService?.Coding, x_);
				var z_ = context.Operators.Exists<Coding>(y_);

				return z_;
			};
			var v_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)AllClaims?.Item, u_);
			var w_ = new Tuple_EFDOJaOgOPCDJDhPijASNAPMd
			{
				ClaimofInterest = AllClaims,
				ClaimID = AllClaims?.IdElement,
				LineItems = v_,
			};

			return w_;
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
			Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT h_(Tuple_EFDOJaOgOPCDJDhPijASNAPMd medClaim)
			{
				bool? o_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<Tuple_BYXPfHJAafYUZgPBifWFNjLXc> r_(Tuple_BYXPfHJAafYUZgPBifWFNjLXc pClaim)
					{
						bool? u_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var y_ = FHIRHelpers_4_0_001.ToString(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: null));
							var z_ = FHIRHelpers_4_0_001.ToString(pClaim?.Response?.Request?.ReferenceElement);
							var aa_ = NCQAFHIRBase_1_0_0.GetId(z_);
							var ab_ = context.Operators.Equal(y_, aa_);
							var ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							var ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							var ae_ = context.Operators.Equal(ac_, ad_);
							var af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						var v_ = context.Operators.Where<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuple_BYXPfHJAafYUZgPBifWFNjLXc w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var x_ = context.Operators.Select<ClaimResponse.ItemComponent, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(v_, w_);

						return x_;
					};
					var s_ = context.Operators.SelectMany<Tuple_BYXPfHJAafYUZgPBifWFNjLXc, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(ClaimAndResponse?.PaidMedicalClaimResponse, r_);
					var t_ = context.Operators.Exists<Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(s_);

					return t_;
				};
				var p_ = context.Operators.Where<Claim.ItemComponent>(medClaim?.LineItems, o_);
				var q_ = new Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			var i_ = context.Operators.Select<Tuple_EFDOJaOgOPCDJDhPijASNAPMd, Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ClaimAndResponse?.MedicalClaim, h_);
			var j_ = new Tuple_GUibhjYMgjAQISFDJORUOccJC
			{
				AggregateClaim = i_,
			};
			var k_ = new Tuple_GUibhjYMgjAQISFDJORUOccJC[]
			{
				j_,
			};
			Tuple_FCOUVKRRWVHcKiBDUdGgLciKR l_(Tuple_GUibhjYMgjAQISFDJORUOccJC ClaimWithPaidResponse)
			{
				Tuple_FCOUVKRRWVHcKiBDUdGgLciKR ag_()
				{
					bool al_()
					{
						bool? am_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var as_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return as_;
						};
						var an_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ClaimWithPaidResponse?.AggregateClaim, am_);
						IEnumerable<Claim.ItemComponent> ao_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this) => 
							@this?.ClaimItem;
						var ap_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, IEnumerable<Claim.ItemComponent>>(an_, ao_);
						var aq_ = context.Operators.Flatten<Claim.ItemComponent>(ap_);
						var ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);

						return (ar_ ?? false);
					};
					if (al_())
					{
						bool? at_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var bf_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return bf_;
						};
						var au_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ClaimWithPaidResponse?.AggregateClaim, at_);
						Tuple_EFDOJaOgOPCDJDhPijASNAPMd av_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this) => 
							@this?.PaidClaim;
						var aw_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, Tuple_EFDOJaOgOPCDJDhPijASNAPMd>(au_, av_);
						bool? ax_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this)
						{
							var bg_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bg_;
						};
						var ay_ = context.Operators.Where<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT>(ClaimWithPaidResponse?.AggregateClaim, ax_);
						IEnumerable<Claim.ItemComponent> az_(Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT @this) => 
							@this?.ClaimItem;
						var ba_ = context.Operators.Select<Tuple_EZGbLgjaMDjCRGbAgCTPUZZcT, IEnumerable<Claim.ItemComponent>>(ay_, az_);
						var bb_ = context.Operators.Flatten<Claim.ItemComponent>(ba_);
						CqlInterval<CqlDateTime> bc_(Claim.ItemComponent PaidItem)
						{
							var bh_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced);

							return bh_;
						};
						var bd_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, bc_);
						var be_ = new Tuple_FCOUVKRRWVHcKiBDUdGgLciKR
						{
							originalClaim = aw_,
							ServicePeriod = bd_,
						};

						return be_;
					}
					else
					{
						return null;
					};
				};
				var ah_ = new Tuple_FCOUVKRRWVHcKiBDUdGgLciKR[]
				{
					ag_(),
				};
				bool? ai_(Tuple_FCOUVKRRWVHcKiBDUdGgLciKR FinalList)
				{
					var bi_ = context.Operators.Not((bool?)(FinalList is null));

					return bi_;
				};
				var aj_ = context.Operators.Where<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(ah_, ai_);
				var ak_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(aj_);

				return ak_;
			};
			var m_ = context.Operators.Select<Tuple_GUibhjYMgjAQISFDJORUOccJC, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(k_, l_);
			var n_ = context.Operators.SingletonFrom<Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(m_);

			return n_;
		};
		var f_ = context.Operators.Select<Tuple_GJOKWWTjFYRgcgdOSKQMPiKIE, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(d_, e_);
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
				if ((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
				{
					return null;
				}
				else
				{
					var g_ = this.Get_Corresponding_Claim_for_Services_Only(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet);

					return g_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.Select<Tuple_BPLeiOPPLaJQZIggaPXFWcaBO, Tuple_FCOUVKRRWVHcKiBDUdGgLciKR>(b_, c_);
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
			Tuple_FNLZPXZWGLChDNZjQJNigGGGN h_(Tuple_GGLURZZjYLMjhaMLVbjKOcMAY medClaim)
			{
				bool? o_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<Tuple_BYXPfHJAafYUZgPBifWFNjLXc> r_(Tuple_BYXPfHJAafYUZgPBifWFNjLXc pClaim)
					{
						bool? u_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var y_ = FHIRHelpers_4_0_001.ToString(((medClaim?.Claim is Resource)
									? ((medClaim?.Claim as Resource).IdElement)
									: null));
							var z_ = FHIRHelpers_4_0_001.ToString(pClaim?.Response?.Request?.ReferenceElement);
							var aa_ = NCQAFHIRBase_1_0_0.GetId(z_);
							var ab_ = context.Operators.Equal(y_, aa_);
							var ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							var ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							var ae_ = context.Operators.Equal(ac_, ad_);
							var af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						var v_ = context.Operators.Where<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuple_BYXPfHJAafYUZgPBifWFNjLXc w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var x_ = context.Operators.Select<ClaimResponse.ItemComponent, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(v_, w_);

						return x_;
					};
					var s_ = context.Operators.SelectMany<Tuple_BYXPfHJAafYUZgPBifWFNjLXc, Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(ClaimAndResponse?.PaidPharmacyClaimResponse, r_);
					var t_ = context.Operators.Exists<Tuple_BYXPfHJAafYUZgPBifWFNjLXc>(s_);

					return t_;
				};
				var p_ = context.Operators.Where<Claim.ItemComponent>(medClaim?.LineItem, o_);
				var q_ = new Tuple_FNLZPXZWGLChDNZjQJNigGGGN
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			var i_ = context.Operators.Select<Tuple_GGLURZZjYLMjhaMLVbjKOcMAY, Tuple_FNLZPXZWGLChDNZjQJNigGGGN>(ClaimAndResponse?.MedicalClaim, h_);
			var j_ = new Tuple_EMbbXAAHNDcXYSgLIhAhQCWON
			{
				AggregateClaim = i_,
			};
			var k_ = new Tuple_EMbbXAAHNDcXYSgLIhAhQCWON[]
			{
				j_,
			};
			Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV l_(Tuple_EMbbXAAHNDcXYSgLIhAhQCWON ClaimWithPaidResponse)
			{
				Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV ag_()
				{
					bool al_()
					{
						bool? am_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this)
						{
							var as_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return as_;
						};
						var an_ = context.Operators.Where<Tuple_FNLZPXZWGLChDNZjQJNigGGGN>(ClaimWithPaidResponse?.AggregateClaim, am_);
						IEnumerable<Claim.ItemComponent> ao_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this) => 
							@this?.ClaimItem;
						var ap_ = context.Operators.Select<Tuple_FNLZPXZWGLChDNZjQJNigGGGN, IEnumerable<Claim.ItemComponent>>(an_, ao_);
						var aq_ = context.Operators.Flatten<Claim.ItemComponent>(ap_);
						var ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);

						return (ar_ ?? false);
					};
					if (al_())
					{
						bool? at_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this)
						{
							var bm_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return bm_;
						};
						var au_ = context.Operators.Where<Tuple_FNLZPXZWGLChDNZjQJNigGGGN>(ClaimWithPaidResponse?.AggregateClaim, at_);
						Tuple_GGLURZZjYLMjhaMLVbjKOcMAY av_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this) => 
							@this?.PaidClaim;
						var aw_ = context.Operators.Select<Tuple_FNLZPXZWGLChDNZjQJNigGGGN, Tuple_GGLURZZjYLMjhaMLVbjKOcMAY>(au_, av_);
						bool? ax_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this)
						{
							var bn_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bn_;
						};
						var ay_ = context.Operators.Where<Tuple_FNLZPXZWGLChDNZjQJNigGGGN>(ClaimWithPaidResponse?.AggregateClaim, ax_);
						IEnumerable<Claim.ItemComponent> az_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this) => 
							@this?.ClaimItem;
						var ba_ = context.Operators.Select<Tuple_FNLZPXZWGLChDNZjQJNigGGGN, IEnumerable<Claim.ItemComponent>>(ay_, az_);
						var bb_ = context.Operators.Flatten<Claim.ItemComponent>(ba_);
						CqlInterval<CqlDateTime> bc_(Claim.ItemComponent PaidItem)
						{
							var bo_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced);

							return bo_;
						};
						var bd_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, bc_);
						bool? be_(Tuple_FNLZPXZWGLChDNZjQJNigGGGN @this)
						{
							var bp_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bp_;
						};
						var bf_ = context.Operators.Where<Tuple_FNLZPXZWGLChDNZjQJNigGGGN>(ClaimWithPaidResponse?.AggregateClaim, be_);
						var bh_ = context.Operators.Select<Tuple_FNLZPXZWGLChDNZjQJNigGGGN, IEnumerable<Claim.ItemComponent>>(bf_, az_);
						var bi_ = context.Operators.Flatten<Claim.ItemComponent>(bh_);
						CqlInterval<CqlDate> bj_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDate> bq_()
							{
								if ((context.Operators.Not((bool?)(i?.Quantity is null)) ?? false))
								{
									var br_ = NCQAFHIRBase_1_0_0.Normalize_Interval(i?.Serviced);
									var bs_ = context.Operators.Start(br_);
									var bt_ = context.Operators.ConvertDateTimeToDate(bs_);
									var bv_ = context.Operators.Start(br_);
									var bw_ = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement);
									var bx_ = context.Operators.Add(bv_, new CqlQuantity(bw_, "day"));
									var by_ = context.Operators.Quantity(1m, "day");
									var bz_ = context.Operators.Subtract(bx_, by_);
									var ca_ = context.Operators.ConvertDateTimeToDate(bz_);
									var cb_ = context.Operators.Interval(bt_, ca_, true, true);

									return cb_;
								}
								else
								{
									return null;
								};
							};

							return bq_();
						};
						var bk_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDate>>(bi_, bj_);
						var bl_ = new Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV
						{
							originalClaim = aw_,
							ServicePeriod = bd_,
							CoveredDays = bk_,
						};

						return bl_;
					}
					else
					{
						return null;
					};
				};
				var ah_ = new Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV[]
				{
					ag_(),
				};
				bool? ai_(Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV FinalList)
				{
					var cc_ = context.Operators.Not((bool?)(FinalList is null));

					return cc_;
				};
				var aj_ = context.Operators.Where<Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>(ah_, ai_);
				var ak_ = context.Operators.SingletonFrom<Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>(aj_);

				return ak_;
			};
			var m_ = context.Operators.Select<Tuple_EMbbXAAHNDcXYSgLIhAhQCWON, Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>(k_, l_);
			var n_ = context.Operators.SingletonFrom<Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>(m_);

			return n_;
		};
		var f_ = context.Operators.Select<Tuple_ETbUUAbGJFCcYLGFaEAgMaiBj, Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>(d_, e_);
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
				if ((context.Operators.And((bool?)(PharmacyClaimAndResponse?.PharmacyClaimResponse is null), (bool?)(PharmacyClaimAndResponse?.PharmacyClaim is null)) ?? false))
				{
					return null;
				}
				else
				{
					var g_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(PharmacyClaimAndResponse?.PharmacyClaimResponse, PharmacyClaimAndResponse?.PharmacyClaim, ProductOrServiceValueSet);

					return g_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.Select<Tuple_EGPWWEihGWWSCCiZLgdcFLIcD, Tuple_BLVTIIcLeMgJUGiVJJYUcPQPV>(b_, c_);
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
				var h_ = FHIRHelpers_4_0_001.ToString(Claim?.IdElement);
				var i_ = FHIRHelpers_4_0_001.ToString(CR?.Request?.ReferenceElement);
				var j_ = NCQAFHIRBase_1_0_0.GetId(i_);
				var k_ = context.Operators.Equal(h_, j_);

				return k_;
			};
			var d_ = context.Operators.Where<ClaimResponse>(claimResponse, c_);
			bool? e_(Claim C)
			{
				var l_ = FHIRHelpers_4_0_001.ToString(Claim?.IdElement);
				bool? m_(ClaimResponse CR)
				{
					var aa_ = FHIRHelpers_4_0_001.ToString(Claim?.IdElement);
					var ab_ = FHIRHelpers_4_0_001.ToString(CR?.Request?.ReferenceElement);
					var ac_ = NCQAFHIRBase_1_0_0.GetId(ab_);
					var ad_ = context.Operators.Equal(aa_, ac_);

					return ad_;
				};
				var n_ = context.Operators.Where<ClaimResponse>(claimResponse, m_);
				bool? o_(ClaimResponse @this)
				{
					var ae_ = context.Operators.Not((bool?)(@this?.Request is null));

					return ae_;
				};
				var p_ = context.Operators.Where<ClaimResponse>(n_, o_);
				ResourceReference q_(ClaimResponse @this) => 
					@this?.Request;
				var r_ = context.Operators.Select<ClaimResponse, ResourceReference>(p_, q_);
				bool? s_(ResourceReference @this)
				{
					var af_ = context.Operators.Not((bool?)(@this?.ReferenceElement is null));

					return af_;
				};
				var t_ = context.Operators.Where<ResourceReference>(r_, s_);
				FhirString u_(ResourceReference @this) => 
					@this?.ReferenceElement;
				var v_ = context.Operators.Select<ResourceReference, FhirString>(t_, u_);
				var w_ = context.Operators.SingletonFrom<FhirString>(v_);
				var x_ = FHIRHelpers_4_0_001.ToString(w_);
				var y_ = NCQAFHIRBase_1_0_0.GetId(x_);
				var z_ = context.Operators.Equal(l_, y_);

				return z_;
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
					return null;
				}
				else
				{
					bool? n_(Claim c)
					{
						bool? p_(Claim.ItemComponent i)
						{
							var s_ = FHIRHelpers_4_0_001.ToConcept(i?.Revenue);
							bool? t_(CqlCode rev)
							{
								var w_ = this.Inpatient_Stay();
								var x_ = context.Operators.StringInValueSet(rev?.code, w_);

								return x_;
							};
							var u_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)s_?.codes, t_);
							var v_ = context.Operators.Exists<CqlCode>(u_);

							return v_;
						};
						var q_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)c?.Item, p_);
						var r_ = context.Operators.Exists<Claim.ItemComponent>(q_);

						return r_;
					};
					var o_ = context.Operators.Where<Claim>(ClaimWithInpatientStay?.MedicalClaim, n_);

					return o_;
				};
			};
			IEnumerable<Claim> h_()
			{
				if ((ClaimWithInpatientStay?.MedicalClaim is null))
				{
					return null;
				}
				else
				{
					bool? y_(Claim c)
					{
						bool? aa_(Claim.ItemComponent i)
						{
							var ah_ = FHIRHelpers_4_0_001.ToConcept(i?.Revenue);
							bool? ai_(CqlCode rev)
							{
								var al_ = this.Nonacute_Inpatient_Stay();
								var am_ = context.Operators.StringInValueSet(rev?.code, al_);

								return am_;
							};
							var aj_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)ah_?.codes, ai_);
							var ak_ = context.Operators.Exists<CqlCode>(aj_);

							return ak_;
						};
						var ab_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)c?.Item, aa_);
						var ac_ = context.Operators.Exists<Claim.ItemComponent>(ab_);
						bool? ad_(Coding tob)
						{
							var an_ = this.Nonacute_Inpatient_Stay();
							var ao_ = context.Operators.StringInValueSet(tob?.CodeElement?.Value, an_);

							return ao_;
						};
						var ae_ = context.Operators.Where<Coding>((IEnumerable<Coding>)c?.SubType?.Coding, ad_);
						var af_ = context.Operators.Exists<Coding>(ae_);
						var ag_ = context.Operators.Or(ac_, af_);

						return ag_;
					};
					var z_ = context.Operators.Where<Claim>(ClaimWithInpatientStay?.MedicalClaim, y_);

					return z_;
				};
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
				IEnumerable<Claim> ap_(Claim nonAcuteInpatientStay)
				{
					bool? av_(Claim inpatientStay)
					{
						var az_ = context.Operators.Equal(nonAcuteInpatientStay?.IdElement, inpatientStay?.IdElement);

						return az_;
					};
					var aw_ = context.Operators.Where<Claim>(LineItemDefinition?.InpatientStayLineItems, av_);
					Claim ax_(Claim inpatientStay) => 
						nonAcuteInpatientStay;
					var ay_ = context.Operators.Select<Claim, Claim>(aw_, ax_);

					return ay_;
				};
				var aq_ = context.Operators.SelectMany<Claim, Claim>(LineItemDefinition?.NonacuteInpatientLineItems, ap_);
				IEnumerable<Claim> ar_(Claim inpatientStay)
				{
					bool? ba_(Claim nonAcuteInpatientStay)
					{
						var be_ = context.Operators.Equal(inpatientStay?.IdElement, nonAcuteInpatientStay?.IdElement);

						return be_;
					};
					var bb_ = context.Operators.Where<Claim>(LineItemDefinition?.NonacuteInpatientLineItems, ba_);
					Claim bc_(Claim nonAcuteInpatientStay) => 
						inpatientStay;
					var bd_ = context.Operators.Select<Claim, Claim>(bb_, bc_);

					return bd_;
				};
				var as_ = context.Operators.SelectMany<Claim, Claim>(LineItemDefinition?.InpatientStayLineItems, ar_);
				var at_ = context.Operators.ListExcept<Claim>(LineItemDefinition?.InpatientStayLineItems, as_);
				var au_ = new Tuple_eaabEEMNTgcTCVVWQFDOgRNO
				{
					InpatientDischarge = LineItemDefinition?.InpatientStayLineItems,
					NonacuteInpatientDischarge = aq_,
					AcuteInpatientDischarge = at_,
				};

				return au_;
			};
			var l_ = context.Operators.Select<Tuple_GFUjSKcYaHagAZIhSUhffHjHP, Tuple_eaabEEMNTgcTCVVWQFDOgRNO>(j_, k_);
			var m_ = context.Operators.SingletonFrom<Tuple_eaabEEMNTgcTCVVWQFDOgRNO>(l_);

			return m_;
		};
		var e_ = context.Operators.Select<Tuple_FXYEMgTMOeKcIebiZCTUajHVX, Tuple_eaabEEMNTgcTCVVWQFDOgRNO>(c_, d_);
		var f_ = context.Operators.SingletonFrom<Tuple_eaabEEMNTgcTCVVWQFDOgRNO>(e_);

		return f_;
	}

    [CqlDeclaration("Get Prescriber NPI from Claims")]
	public Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS Get_Prescriber_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		Tuple_CGBhZZbICOjJSOiHTigebRWSH a_(Claim C)
		{
			bool? h_(Claim.CareTeamComponent ct)
			{
				var w_ = context.Operators.Convert<Integer>(ct?.SequenceElement);
				var x_ = FHIRHelpers_4_0_001.ToInteger(w_);
				var y_ = context.Operators.Equal(x_, 1);

				return y_;
			};
			var i_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)C?.CareTeam, h_);
			bool? j_(Claim.CareTeamComponent @this)
			{
				var z_ = context.Operators.Not((bool?)(@this?.Provider is null));

				return z_;
			};
			var k_ = context.Operators.Where<Claim.CareTeamComponent>(i_, j_);
			ResourceReference l_(Claim.CareTeamComponent @this) => 
				@this?.Provider;
			var m_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(k_, l_);
			bool? n_(Claim.CareTeamComponent ct)
			{
				var aa_ = context.Operators.Convert<Integer>(ct?.SequenceElement);
				var ab_ = FHIRHelpers_4_0_001.ToInteger(aa_);
				var ac_ = context.Operators.Equal(ab_, 1);

				return ac_;
			};
			var o_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)C?.CareTeam, n_);
			bool? p_(Claim.CareTeamComponent @this)
			{
				var ad_ = context.Operators.Not((bool?)(@this?.Provider is null));

				return ad_;
			};
			var q_ = context.Operators.Where<Claim.CareTeamComponent>(o_, p_);
			var s_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(q_, l_);
			string t_(ResourceReference p)
			{
				var ae_ = new FhirString[]
				{
					p?.ReferenceElement,
				};
				string af_(FhirString r)
				{
					var ai_ = FHIRHelpers_4_0_001.ToString(r);
					var aj_ = NCQAFHIRBase_1_0_0.GetId(ai_);

					return aj_;
				};
				var ag_ = context.Operators.Select<FhirString, string>(ae_, af_);
				var ah_ = context.Operators.SingletonFrom<string>(ag_);

				return ah_;
			};
			var u_ = context.Operators.Select<ResourceReference, string>(s_, t_);
			var v_ = new Tuple_CGBhZZbICOjJSOiHTigebRWSH
			{
				SingleCareTeam = C,
				CareTeamsProvider = m_,
				CareTeamsProviderID = u_,
			};

			return v_;
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
			var ak_ = context.Operators.RetrieveByValueSet<Practitioner>(null, null);
			bool? al_(Practitioner p)
			{
				var as_ = FHIRHelpers_4_0_001.ToString(p?.IdElement);
				bool? at_(Tuple_CGBhZZbICOjJSOiHTigebRWSH @this)
				{
					var az_ = context.Operators.Not((bool?)(@this?.CareTeamsProviderID is null));

					return az_;
				};
				var au_ = context.Operators.Where<Tuple_CGBhZZbICOjJSOiHTigebRWSH>(ClaimProperties?.CareTeams, at_);
				IEnumerable<string> av_(Tuple_CGBhZZbICOjJSOiHTigebRWSH @this) => 
					@this?.CareTeamsProviderID;
				var aw_ = context.Operators.Select<Tuple_CGBhZZbICOjJSOiHTigebRWSH, IEnumerable<string>>(au_, av_);
				var ax_ = context.Operators.Flatten<string>(aw_);
				var ay_ = context.Operators.In<string>(as_, ax_);

				return ay_;
			};
			var am_ = context.Operators.Where<Practitioner>(ak_, al_);
			var an_ = new Tuple_FPVdJEEOUKFVhQPTfKhShUNO
			{
				Practitioners = am_,
			};
			var ao_ = new Tuple_FPVdJEEOUKFVhQPTfKhShUNO[]
			{
				an_,
			};
			Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS ap_(Tuple_FPVdJEEOUKFVhQPTfKhShUNO PractitionerMatch)
			{
				bool? ba_(Practitioner P)
				{
					var bj_ = context.Operators.Not((bool?)(P is null));

					return bj_;
				};
				var bb_ = context.Operators.Where<Practitioner>(PractitionerMatch?.Practitioners, ba_);
				Tuple_EheHUARRFfQdCcHKeSEhfYZMj bc_(Practitioner P)
				{
					bool? bk_(Identifier l)
					{
						var bt_ = context.Operators.Equal(l?.SystemElement?.Value, "http://hl7.org/fhir/sid/us-npi");
						var bu_ = FHIRHelpers_4_0_001.ToConcept(l?.Type);
						var bv_ = NCQATerminology_1_0_0.Provider_number();
						var bw_ = context.Operators.ConvertCodeToConcept(bv_);
						var bx_ = context.Operators.Equivalent(bu_, bw_);
						var by_ = context.Operators.And(bt_, bx_);
						var bz_ = context.Operators.Not((bool?)(l?.ValueElement?.Value is null));
						var ca_ = context.Operators.And(by_, bz_);

						return ca_;
					};
					var bl_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)P?.Identifier, bk_);
					FhirString bm_(Identifier l) => 
						l?.ValueElement;
					var bn_ = context.Operators.Select<Identifier, FhirString>(bl_, bm_);
					bool? bo_(Identifier l)
					{
						var cb_ = context.Operators.Equal(l?.SystemElement?.Value, "http://hl7.org/fhir/sid/us-npi");
						var cc_ = FHIRHelpers_4_0_001.ToConcept(l?.Type);
						var cd_ = NCQATerminology_1_0_0.Provider_number();
						var ce_ = context.Operators.ConvertCodeToConcept(cd_);
						var cf_ = context.Operators.Equivalent(cc_, ce_);
						var cg_ = context.Operators.And(cb_, cf_);
						var ch_ = context.Operators.And(cg_, (bool?)(l?.ValueElement?.Value is null));

						return ch_;
					};
					var bp_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)P?.Identifier, bo_);
					Identifier bq_(Identifier l) => 
						l;
					var br_ = context.Operators.Select<Identifier, Identifier>(bp_, bq_);
					var bs_ = new Tuple_EheHUARRFfQdCcHKeSEhfYZMj
					{
						AllIdentifiers = bn_,
						NullIdentifiers = br_,
					};

					return bs_;
				};
				var bd_ = context.Operators.Select<Practitioner, Tuple_EheHUARRFfQdCcHKeSEhfYZMj>(bb_, bc_);
				var be_ = new Tuple_EZUSISLPSZWTXahaQjXaSAJBE
				{
					IdentifierTuple = bd_,
				};
				var bf_ = new Tuple_EZUSISLPSZWTXahaQjXaSAJBE[]
				{
					be_,
				};
				Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS bg_(Tuple_EZUSISLPSZWTXahaQjXaSAJBE GetIdentifiers)
				{
					int? ci_()
					{
						bool ck_()
						{
							bool? cl_(Tuple_CGBhZZbICOjJSOiHTigebRWSH @this)
							{
								var cq_ = context.Operators.Not((bool?)(@this?.SingleCareTeam is null));

								return cq_;
							};
							var cm_ = context.Operators.Where<Tuple_CGBhZZbICOjJSOiHTigebRWSH>(ClaimProperties?.CareTeams, cl_);
							Claim cn_(Tuple_CGBhZZbICOjJSOiHTigebRWSH @this) => 
								@this?.SingleCareTeam;
							var co_ = context.Operators.Select<Tuple_CGBhZZbICOjJSOiHTigebRWSH, Claim>(cm_, cn_);
							var cp_ = context.Operators.Exists<Claim>(co_);

							return (cp_ ?? false);
						};
						if (ck_())
						{
							bool? cr_(Tuple_CGBhZZbICOjJSOiHTigebRWSH @this)
							{
								var dk_ = context.Operators.Not((bool?)(@this?.SingleCareTeam is null));

								return dk_;
							};
							var cs_ = context.Operators.Where<Tuple_CGBhZZbICOjJSOiHTigebRWSH>(ClaimProperties?.CareTeams, cr_);
							Claim ct_(Tuple_CGBhZZbICOjJSOiHTigebRWSH @this) => 
								@this?.SingleCareTeam;
							var cu_ = context.Operators.Select<Tuple_CGBhZZbICOjJSOiHTigebRWSH, Claim>(cs_, ct_);
							bool? cv_(Claim X) => 
								(bool?)((IEnumerable<Claim.CareTeamComponent>)X?.CareTeam is null);
							var cw_ = context.Operators.Where<Claim>(cu_, cv_);
							var cx_ = context.Operators.Count<Claim>(cw_);
							IEnumerable<FhirString> cy_(Tuple_EheHUARRFfQdCcHKeSEhfYZMj X) => 
								X?.AllIdentifiers;
							var cz_ = context.Operators.Select<Tuple_EheHUARRFfQdCcHKeSEhfYZMj, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, cy_);
							var da_ = context.Operators.Flatten<FhirString>(cz_);
							FhirString db_(FhirString X) => 
								X;
							var dc_ = context.Operators.Select<FhirString, FhirString>(da_, db_);
							var dd_ = context.Operators.Count<FhirString>(dc_);
							var de_ = context.Operators.Add(cx_, dd_);
							IEnumerable<Identifier> df_(Tuple_EheHUARRFfQdCcHKeSEhfYZMj X) => 
								X?.NullIdentifiers;
							var dg_ = context.Operators.Select<Tuple_EheHUARRFfQdCcHKeSEhfYZMj, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, df_);
							var dh_ = context.Operators.Flatten<Identifier>(dg_);
							var di_ = context.Operators.Count<Identifier>(dh_);
							var dj_ = context.Operators.Add(de_, di_);

							return dj_;
						}
						else
						{
							return 0;
						};
					};
					var cj_ = new Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS
					{
						IdentifierCount = ci_(),
					};

					return cj_;
				};
				var bh_ = context.Operators.Select<Tuple_EZUSISLPSZWTXahaQjXaSAJBE, Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(bf_, bg_);
				var bi_ = context.Operators.SingletonFrom<Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(bh_);

				return bi_;
			};
			var aq_ = context.Operators.Select<Tuple_FPVdJEEOUKFVhQPTfKhShUNO, Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(ao_, ap_);
			var ar_ = context.Operators.SingletonFrom<Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(aq_);

			return ar_;
		};
		var f_ = context.Operators.Select<Tuple_HFNJUcNhcbGBLBgHAJMMSPfQH, Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(d_, e_);
		var g_ = context.Operators.SingletonFrom<Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(f_);

		return g_;
	}

    [CqlDeclaration("Get Pharmacy NPI from Claims")]
	public Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS Get_Pharmacy_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		Tuple_GJMDOdSNREDHVIihMZIJLUYXV a_(Claim C)
		{
			bool? h_(Claim.ItemComponent i)
			{
				var y_ = context.Operators.Convert<Integer>(i?.SequenceElement);
				var z_ = FHIRHelpers_4_0_001.ToInteger(y_);
				var aa_ = context.Operators.Equal(z_, 1);

				return aa_;
			};
			var i_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)C?.Item, h_);
			bool? j_(Claim.ItemComponent @this)
			{
				var ab_ = context.Operators.Not((bool?)(@this?.Location is null));

				return ab_;
			};
			var k_ = context.Operators.Where<Claim.ItemComponent>(i_, j_);
			DataType l_(Claim.ItemComponent @this) => 
				@this?.Location;
			var m_ = context.Operators.Select<Claim.ItemComponent, DataType>(k_, l_);
			ResourceReference n_(DataType l) => 
				(l as ResourceReference);
			var o_ = context.Operators.Select<DataType, ResourceReference>(m_, n_);
			bool? p_(Claim.ItemComponent i)
			{
				var ac_ = context.Operators.Convert<Integer>(i?.SequenceElement);
				var ad_ = FHIRHelpers_4_0_001.ToInteger(ac_);
				var ae_ = context.Operators.Equal(ad_, 1);

				return ae_;
			};
			var q_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)C?.Item, p_);
			bool? r_(Claim.ItemComponent @this)
			{
				var af_ = context.Operators.Not((bool?)(@this?.Location is null));

				return af_;
			};
			var s_ = context.Operators.Where<Claim.ItemComponent>(q_, r_);
			var u_ = context.Operators.Select<Claim.ItemComponent, DataType>(s_, l_);
			string v_(DataType l)
			{
				var ag_ = new FhirString[]
				{
					(l as ResourceReference)?.ReferenceElement,
				};
				string ah_(FhirString r)
				{
					var ak_ = FHIRHelpers_4_0_001.ToString(r);
					var al_ = NCQAFHIRBase_1_0_0.GetId(ak_);

					return al_;
				};
				var ai_ = context.Operators.Select<FhirString, string>(ag_, ah_);
				var aj_ = context.Operators.SingletonFrom<string>(ai_);

				return aj_;
			};
			var w_ = context.Operators.Select<DataType, string>(u_, v_);
			var x_ = new Tuple_GJMDOdSNREDHVIihMZIJLUYXV
			{
				SingleItem = (IEnumerable<Claim.ItemComponent>)C?.Item,
				ItemLocation = o_,
				ItemLocationID = w_,
			};

			return x_;
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
			var am_ = context.Operators.RetrieveByValueSet<Location>(null, null);
			bool? an_(Location l)
			{
				var au_ = FHIRHelpers_4_0_001.ToString(l?.IdElement);
				bool? av_(Tuple_GJMDOdSNREDHVIihMZIJLUYXV @this)
				{
					var bb_ = context.Operators.Not((bool?)(@this?.ItemLocationID is null));

					return bb_;
				};
				var aw_ = context.Operators.Where<Tuple_GJMDOdSNREDHVIihMZIJLUYXV>(ClaimProperties?.ItemsLocationReferences, av_);
				IEnumerable<string> ax_(Tuple_GJMDOdSNREDHVIihMZIJLUYXV @this) => 
					@this?.ItemLocationID;
				var ay_ = context.Operators.Select<Tuple_GJMDOdSNREDHVIihMZIJLUYXV, IEnumerable<string>>(aw_, ax_);
				var az_ = context.Operators.Flatten<string>(ay_);
				var ba_ = context.Operators.In<string>(au_, az_);

				return ba_;
			};
			var ao_ = context.Operators.Where<Location>(am_, an_);
			var ap_ = new Tuple_GWYcfjEGjPEdPbTNdfROfTUAf
			{
				CorrespondingLocations = ao_,
			};
			var aq_ = new Tuple_GWYcfjEGjPEdPbTNdfROfTUAf[]
			{
				ap_,
			};
			Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS ar_(Tuple_GWYcfjEGjPEdPbTNdfROfTUAf GetLocation)
			{
				bool? bc_(Location C)
				{
					var bl_ = context.Operators.Not((bool?)(C is null));

					return bl_;
				};
				var bd_ = context.Operators.Where<Location>(GetLocation?.CorrespondingLocations, bc_);
				Tuple_EheHUARRFfQdCcHKeSEhfYZMj be_(Location C)
				{
					bool? bm_(Identifier l)
					{
						var bv_ = context.Operators.Equal(l?.SystemElement?.Value, "http://hl7.org/fhir/sid/us-npi");
						var bw_ = FHIRHelpers_4_0_001.ToConcept(l?.Type);
						var bx_ = NCQATerminology_1_0_0.Provider_number();
						var by_ = context.Operators.ConvertCodeToConcept(bx_);
						var bz_ = context.Operators.Equivalent(bw_, by_);
						var ca_ = context.Operators.And(bv_, bz_);
						var cb_ = context.Operators.Not((bool?)(l?.ValueElement?.Value is null));
						var cc_ = context.Operators.And(ca_, cb_);

						return cc_;
					};
					var bn_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)C?.Identifier, bm_);
					FhirString bo_(Identifier l) => 
						l?.ValueElement;
					var bp_ = context.Operators.Select<Identifier, FhirString>(bn_, bo_);
					bool? bq_(Identifier l)
					{
						var cd_ = context.Operators.Equal(l?.SystemElement?.Value, "http://hl7.org/fhir/sid/us-npi");
						var ce_ = FHIRHelpers_4_0_001.ToConcept(l?.Type);
						var cf_ = NCQATerminology_1_0_0.Provider_number();
						var cg_ = context.Operators.ConvertCodeToConcept(cf_);
						var ch_ = context.Operators.Equivalent(ce_, cg_);
						var ci_ = context.Operators.And(cd_, ch_);
						var cj_ = context.Operators.And(ci_, (bool?)(l?.ValueElement?.Value is null));

						return cj_;
					};
					var br_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)C?.Identifier, bq_);
					Identifier bs_(Identifier l) => 
						l;
					var bt_ = context.Operators.Select<Identifier, Identifier>(br_, bs_);
					var bu_ = new Tuple_EheHUARRFfQdCcHKeSEhfYZMj
					{
						AllIdentifiers = bp_,
						NullIdentifiers = bt_,
					};

					return bu_;
				};
				var bf_ = context.Operators.Select<Location, Tuple_EheHUARRFfQdCcHKeSEhfYZMj>(bd_, be_);
				var bg_ = new Tuple_EZUSISLPSZWTXahaQjXaSAJBE
				{
					IdentifierTuple = bf_,
				};
				var bh_ = new Tuple_EZUSISLPSZWTXahaQjXaSAJBE[]
				{
					bg_,
				};
				Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS bi_(Tuple_EZUSISLPSZWTXahaQjXaSAJBE GetIdentifiers)
				{
					int? ck_()
					{
						bool cm_()
						{
							bool? cn_(Tuple_GJMDOdSNREDHVIihMZIJLUYXV @this)
							{
								var ct_ = context.Operators.Not((bool?)(@this?.SingleItem is null));

								return ct_;
							};
							var co_ = context.Operators.Where<Tuple_GJMDOdSNREDHVIihMZIJLUYXV>(ClaimProperties?.ItemsLocationReferences, cn_);
							IEnumerable<Claim.ItemComponent> cp_(Tuple_GJMDOdSNREDHVIihMZIJLUYXV @this) => 
								@this?.SingleItem;
							var cq_ = context.Operators.Select<Tuple_GJMDOdSNREDHVIihMZIJLUYXV, IEnumerable<Claim.ItemComponent>>(co_, cp_);
							var cr_ = context.Operators.Flatten<Claim.ItemComponent>(cq_);
							var cs_ = context.Operators.Exists<Claim.ItemComponent>(cr_);

							return (cs_ ?? false);
						};
						if (cm_())
						{
							bool? cu_(Tuple_GJMDOdSNREDHVIihMZIJLUYXV @this)
							{
								var do_ = context.Operators.Not((bool?)(@this?.ItemLocation is null));

								return do_;
							};
							var cv_ = context.Operators.Where<Tuple_GJMDOdSNREDHVIihMZIJLUYXV>(ClaimProperties?.ItemsLocationReferences, cu_);
							IEnumerable<ResourceReference> cw_(Tuple_GJMDOdSNREDHVIihMZIJLUYXV @this) => 
								@this?.ItemLocation;
							var cx_ = context.Operators.Select<Tuple_GJMDOdSNREDHVIihMZIJLUYXV, IEnumerable<ResourceReference>>(cv_, cw_);
							var cy_ = context.Operators.Flatten<ResourceReference>(cx_);
							bool? cz_(ResourceReference X) => 
								(bool?)(X?.ReferenceElement?.Value is null);
							var da_ = context.Operators.Where<ResourceReference>(cy_, cz_);
							var db_ = context.Operators.Count<ResourceReference>(da_);
							IEnumerable<FhirString> dc_(Tuple_EheHUARRFfQdCcHKeSEhfYZMj X) => 
								X?.AllIdentifiers;
							var dd_ = context.Operators.Select<Tuple_EheHUARRFfQdCcHKeSEhfYZMj, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, dc_);
							var de_ = context.Operators.Flatten<FhirString>(dd_);
							FhirString df_(FhirString X) => 
								X;
							var dg_ = context.Operators.Select<FhirString, FhirString>(de_, df_);
							var dh_ = context.Operators.Count<FhirString>(dg_);
							var di_ = context.Operators.Add(db_, dh_);
							IEnumerable<Identifier> dj_(Tuple_EheHUARRFfQdCcHKeSEhfYZMj X) => 
								X?.NullIdentifiers;
							var dk_ = context.Operators.Select<Tuple_EheHUARRFfQdCcHKeSEhfYZMj, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, dj_);
							var dl_ = context.Operators.Flatten<Identifier>(dk_);
							var dm_ = context.Operators.Count<Identifier>(dl_);
							var dn_ = context.Operators.Add(di_, dm_);

							return dn_;
						}
						else
						{
							return 0;
						};
					};
					var cl_ = new Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS
					{
						IdentifierCount = ck_(),
					};

					return cl_;
				};
				var bj_ = context.Operators.Select<Tuple_EZUSISLPSZWTXahaQjXaSAJBE, Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(bh_, bi_);
				var bk_ = context.Operators.SingletonFrom<Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(bj_);

				return bk_;
			};
			var as_ = context.Operators.Select<Tuple_GWYcfjEGjPEdPbTNdfROfTUAf, Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(aq_, ar_);
			var at_ = context.Operators.SingletonFrom<Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(as_);

			return at_;
		};
		var f_ = context.Operators.Select<Tuple_ESTVjUCCVhLEXJGPZBeEcQDHX, Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(d_, e_);
		var g_ = context.Operators.SingletonFrom<Tuple_FBUdWLSDMgYFFiVXYhKEiUNQS>(f_);

		return g_;
	}

}

using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
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
		var a_ = context.Operators;
		bool? b_(Claim MedicalClaim)
		{
			var d_ = context.Operators;
			var f_ = MedicalClaim?.Type;
			var g_ = FHIRHelpers_4_0_001.ToConcept(f_);
			var h_ = g_?.codes;
			var i_ = NCQATerminology_1_0_0.Professional();
			var j_ = d_.ListContains<CqlCode>((h_ as IEnumerable<CqlCode>), i_);
			var m_ = FHIRHelpers_4_0_001.ToConcept(f_);
			var n_ = m_?.codes;
			var o_ = NCQATerminology_1_0_0.Institutional();
			var p_ = d_.ListContains<CqlCode>((n_ as IEnumerable<CqlCode>), o_);
			var q_ = d_.Or(j_, p_);

			return q_;
		};
		var c_ = a_.WhereOrNull<Claim>(claim, b_);

		return c_;
	}

    [CqlDeclaration("Pharmacy Claims")]
	public IEnumerable<Claim> Pharmacy_Claims(IEnumerable<Claim> claim)
	{
		var a_ = context.Operators;
		bool? b_(Claim PharmacyClaim)
		{
			var d_ = context.Operators;
			var e_ = PharmacyClaim?.Type;
			var f_ = FHIRHelpers_4_0_001.ToConcept(e_);
			var g_ = f_?.codes;
			var h_ = NCQATerminology_1_0_0.Pharmacy();
			var i_ = d_.ListContains<CqlCode>((g_ as IEnumerable<CqlCode>), h_);

			return i_;
		};
		var c_ = a_.WhereOrNull<Claim>(claim, b_);

		return c_;
	}

    [CqlDeclaration("Professional or Institutional Claims Response")]
	public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		var a_ = context.Operators;
		bool? b_(ClaimResponse MedicalResponse)
		{
			var d_ = context.Operators;
			var f_ = MedicalResponse?.Type;
			var g_ = FHIRHelpers_4_0_001.ToConcept(f_);
			var h_ = g_?.codes;
			var i_ = NCQATerminology_1_0_0.Professional();
			var j_ = d_.ListContains<CqlCode>((h_ as IEnumerable<CqlCode>), i_);
			var m_ = FHIRHelpers_4_0_001.ToConcept(f_);
			var n_ = m_?.codes;
			var o_ = NCQATerminology_1_0_0.Institutional();
			var p_ = d_.ListContains<CqlCode>((n_ as IEnumerable<CqlCode>), o_);
			var q_ = d_.Or(j_, p_);

			return q_;
		};
		var c_ = a_.WhereOrNull<ClaimResponse>(claimResponse, b_);

		return c_;
	}

    [CqlDeclaration("Pharmacy Claims Response")]
	public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		var a_ = context.Operators;
		bool? b_(ClaimResponse PharmacyResponse)
		{
			var d_ = context.Operators;
			var e_ = PharmacyResponse?.Type;
			var f_ = FHIRHelpers_4_0_001.ToConcept(e_);
			var g_ = f_?.codes;
			var h_ = NCQATerminology_1_0_0.Pharmacy();
			var i_ = d_.ListContains<CqlCode>((g_ as IEnumerable<CqlCode>), h_);

			return i_;
		};
		var c_ = a_.WhereOrNull<ClaimResponse>(claimResponse, b_);

		return c_;
	}

    [CqlDeclaration("Medical Claims With Procedure and POS")]
	public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_and_POS(IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = context.Operators;
		var c_ = this.Professional_or_Institutional_Claims(claim);
		string e_(CqlCode p)
		{
			var o_ = p?.code;

			return o_;
		};
		var f_ = a_.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, e_);
		string h_(CqlCode pos)
		{
			var p_ = pos?.code;

			return p_;
		};
		var i_ = a_.SelectOrNull<CqlCode, string>(posCodes, h_);
		var j_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = c_,
			ProceduresAsStrings = f_,
			POSAsString = i_,
		};
		var k_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			j_,
		};
		IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> l_(Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithPosCode)
		{
			var q_ = context.Operators;
			var s_ = ClaimWithPosCode?.MedicalClaim;
			Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA t_(Claim ClaimofInterest)
			{
				var x_ = context.Operators;
				IEnumerable<Claim.ItemComponent> z_()
				{
					if ((ClaimofInterest is null))
					{
						IEnumerable<Claim.ItemComponent> af_ = null;

						return (af_ as IEnumerable<Claim.ItemComponent>);
					}
					else
					{
						var ag_ = context.Operators;
						var ah_ = ClaimofInterest?.Item;
						bool? ai_(Claim.ItemComponent ItemOnLine)
						{
							var ak_ = context.Operators;
							var an_ = ItemOnLine?.ProductOrService;
							var ao_ = FHIRHelpers_4_0_001.ToConcept(an_);
							var ap_ = ao_?.codes;
							bool? aq_(CqlCode LineCode)
							{
								var bc_ = context.Operators;
								var bd_ = LineCode?.code;
								var be_ = ClaimWithPosCode?.ProceduresAsStrings;
								var bf_ = bc_.InList<string>(bd_, be_);

								return bf_;
							};
							var ar_ = ak_.WhereOrNull<CqlCode>((ap_ as IEnumerable<CqlCode>), aq_);
							var as_ = ak_.ExistsInList<CqlCode>(ar_);
							var av_ = ItemOnLine?.Location;
							var aw_ = FHIRHelpers_4_0_001.ToConcept((av_ as CodeableConcept));
							var ax_ = aw_?.codes;
							bool? ay_(CqlCode PosCode)
							{
								var bg_ = context.Operators;
								var bh_ = PosCode?.code;
								var bi_ = ClaimWithPosCode?.POSAsString;
								var bj_ = bg_.InList<string>(bh_, bi_);

								return bj_;
							};
							var az_ = ak_.WhereOrNull<CqlCode>((ax_ as IEnumerable<CqlCode>), ay_);
							var ba_ = ak_.ExistsInList<CqlCode>(az_);
							var bb_ = ak_.And(as_, ba_);

							return bb_;
						};
						var aj_ = ag_.WhereOrNull<Claim.ItemComponent>((ah_ as IEnumerable<Claim.ItemComponent>), ai_);

						return aj_;
					};
				};
				var aa_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = ClaimofInterest,
					LineItems = z_(),
				};
				var ab_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					aa_,
				};
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ac_(Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition)
				{
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bk_()
					{
						if ((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
						{
							var bl_ = LineItemDefinition?.Claim;
							var bm_ = context.Operators;
							var bp_ = LineItemDefinition?.LineItems;
							bool? bq_(Claim.ItemComponent @this)
							{
								var bx_ = context.Operators;
								var by_ = @this?.Serviced;
								var bz_ = bx_.Not((bool?)(by_ is null));

								return bz_;
							};
							var br_ = bm_.WhereOrNull<Claim.ItemComponent>(bp_, bq_);
							DataType bs_(Claim.ItemComponent @this)
							{
								var ca_ = @this?.Serviced;

								return ca_;
							};
							var bt_ = bm_.SelectOrNull<Claim.ItemComponent, DataType>(br_, bs_);
							CqlInterval<CqlDateTime> bu_(DataType NormalDate)
							{
								var cb_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return cb_;
							};
							var bv_ = bm_.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(bt_, bu_);
							var bw_ = new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = bl_,
								ServicePeriod = bv_,
							};

							return bw_;
						}
						else
						{
							Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA cc_ = null;

							return (cc_ as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
						};
					};

					return bk_();
				};
				var ad_ = x_.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ab_, ac_);
				var ae_ = x_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ad_);

				return ae_;
			};
			var u_ = q_.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(s_, t_);
			bool? v_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var cd_ = context.Operators;
				var ce_ = cd_.Not((bool?)(FinalList is null));

				return ce_;
			};
			var w_ = q_.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(u_, v_);

			return w_;
		};
		var m_ = a_.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(k_, l_);
		var n_ = a_.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(m_);

		return n_;
	}

    [CqlDeclaration("Medical Claims With Procedure in Header or on Line Item")]
	public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = context.Operators;
		var c_ = this.Professional_or_Institutional_Claims(claim);
		string e_(CqlCode p)
		{
			var l_ = p?.code;

			return l_;
		};
		var f_ = a_.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, e_);
		var g_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = c_,
			ProceduresAsStrings = f_,
		};
		var h_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			g_,
		};
		IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> i_(Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithProcedure)
		{
			var m_ = context.Operators;
			var o_ = ClaimWithProcedure?.MedicalClaim;
			Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA p_(Claim ClaimofInterest)
			{
				var t_ = context.Operators;
				IEnumerable<Claim.ItemComponent> v_()
				{
					if ((ClaimofInterest is null))
					{
						IEnumerable<Claim.ItemComponent> ab_ = null;

						return (ab_ as IEnumerable<Claim.ItemComponent>);
					}
					else
					{
						var ac_ = context.Operators;
						var ad_ = ClaimofInterest?.Item;
						bool? ae_(Claim.ItemComponent ItemOnLine)
						{
							var ag_ = context.Operators;
							var aj_ = ItemOnLine?.ProductOrService;
							var ak_ = FHIRHelpers_4_0_001.ToConcept(aj_);
							var al_ = ak_?.codes;
							bool? am_(CqlCode LineCode)
							{
								var bn_ = context.Operators;
								var bo_ = LineCode?.code;
								var bp_ = ClaimWithProcedure?.ProceduresAsStrings;
								var bq_ = bn_.InList<string>(bo_, bp_);

								return bq_;
							};
							var an_ = ag_.WhereOrNull<CqlCode>((al_ as IEnumerable<CqlCode>), am_);
							var ao_ = ag_.ExistsInList<CqlCode>(an_);
							var ax_ = ClaimofInterest?.Procedure;
							bool? ay_(Claim.ProcedureComponent @this)
							{
								var br_ = context.Operators;
								var bs_ = @this?.Procedure;
								var bt_ = br_.Not((bool?)(bs_ is null));

								return bt_;
							};
							var az_ = ag_.WhereOrNull<Claim.ProcedureComponent>((ax_ as IEnumerable<Claim.ProcedureComponent>), ay_);
							DataType ba_(Claim.ProcedureComponent @this)
							{
								var bu_ = @this?.Procedure;

								return bu_;
							};
							var bb_ = ag_.SelectOrNull<Claim.ProcedureComponent, DataType>(az_, ba_);
							bool? bc_(DataType @this)
							{
								var bv_ = context.Operators;
								var bx_ = bv_.LateBoundProperty<object>(@this, "coding");
								var by_ = bv_.Not((bool?)(bx_ is null));

								return by_;
							};
							var bd_ = ag_.WhereOrNull<DataType>(bb_, bc_);
							object be_(DataType @this)
							{
								var bz_ = context.Operators;
								var ca_ = bz_.LateBoundProperty<object>(@this, "coding");

								return ca_;
							};
							var bf_ = ag_.SelectOrNull<DataType, object>(bd_, be_);
							var bg_ = ag_.FlattenLateBoundList(bf_);
							Coding bh_(object @object) => 
								(@object as Coding);
							var bi_ = ag_.SelectOrNull<object, Coding>(bg_, bh_);
							bool? bj_(Coding HeaderCode)
							{
								var cb_ = context.Operators;
								var cc_ = HeaderCode?.CodeElement;
								var cd_ = cc_?.Value;
								var ce_ = ClaimWithProcedure?.ProceduresAsStrings;
								var cf_ = cb_.InList<string>(cd_, ce_);

								return cf_;
							};
							var bk_ = ag_.WhereOrNull<Coding>(bi_, bj_);
							var bl_ = ag_.ExistsInList<Coding>(bk_);
							var bm_ = ag_.Or(ao_, bl_);

							return bm_;
						};
						var af_ = ac_.WhereOrNull<Claim.ItemComponent>((ad_ as IEnumerable<Claim.ItemComponent>), ae_);

						return af_;
					};
				};
				var w_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = ClaimofInterest,
					LineItems = v_(),
				};
				var x_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					w_,
				};
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA y_(Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition)
				{
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA cg_()
					{
						if ((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
						{
							var ch_ = LineItemDefinition?.Claim;
							var ci_ = context.Operators;
							var cl_ = LineItemDefinition?.LineItems;
							bool? cm_(Claim.ItemComponent @this)
							{
								var ct_ = context.Operators;
								var cu_ = @this?.Serviced;
								var cv_ = ct_.Not((bool?)(cu_ is null));

								return cv_;
							};
							var cn_ = ci_.WhereOrNull<Claim.ItemComponent>(cl_, cm_);
							DataType co_(Claim.ItemComponent @this)
							{
								var cw_ = @this?.Serviced;

								return cw_;
							};
							var cp_ = ci_.SelectOrNull<Claim.ItemComponent, DataType>(cn_, co_);
							CqlInterval<CqlDateTime> cq_(DataType NormalDate)
							{
								var cx_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return cx_;
							};
							var cr_ = ci_.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(cp_, cq_);
							var cs_ = new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = ch_,
								ServicePeriod = cr_,
							};

							return cs_;
						}
						else
						{
							Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA cy_ = null;

							return (cy_ as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
						};
					};

					return cg_();
				};
				var z_ = t_.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(x_, y_);
				var aa_ = t_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(z_);

				return aa_;
			};
			var q_ = m_.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(o_, p_);
			bool? r_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var cz_ = context.Operators;
				var da_ = cz_.Not((bool?)(FinalList is null));

				return da_;
			};
			var s_ = m_.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_, r_);

			return s_;
		};
		var j_ = a_.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(h_, i_);
		var k_ = a_.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(j_);

		return k_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis")]
	public Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI Medical_Claims_With_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = context.Operators;
		var c_ = this.Professional_or_Institutional_Claims(claim);
		string e_(CqlCode d)
		{
			var l_ = d?.code;

			return l_;
		};
		var f_ = a_.SelectOrNull<CqlCode, string>(DiagnosisValueSet, e_);
		var g_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = c_,
			DiagnosesAsStrings = f_,
		};
		var h_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			g_,
		};
		Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI i_(Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis)
		{
			var m_ = context.Operators;
			IEnumerable<Claim> o_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					IEnumerable<Claim> u_ = null;

					return (u_ as IEnumerable<Claim>);
				}
				else
				{
					var v_ = context.Operators;
					var w_ = ClaimWithDiagnosis?.MedicalClaim;
					bool? x_(Claim DiagnosisLine)
					{
						var z_ = context.Operators;
						var ah_ = DiagnosisLine?.Diagnosis;
						bool? ai_(Claim.DiagnosisComponent @this)
						{
							var aw_ = context.Operators;
							var ax_ = @this?.Diagnosis;
							var ay_ = aw_.Not((bool?)(ax_ is null));

							return ay_;
						};
						var aj_ = z_.WhereOrNull<Claim.DiagnosisComponent>((ah_ as IEnumerable<Claim.DiagnosisComponent>), ai_);
						DataType ak_(Claim.DiagnosisComponent @this)
						{
							var az_ = @this?.Diagnosis;

							return az_;
						};
						var al_ = z_.SelectOrNull<Claim.DiagnosisComponent, DataType>(aj_, ak_);
						bool? am_(DataType @this)
						{
							var ba_ = context.Operators;
							var bc_ = ba_.LateBoundProperty<object>(@this, "coding");
							var bd_ = ba_.Not((bool?)(bc_ is null));

							return bd_;
						};
						var an_ = z_.WhereOrNull<DataType>(al_, am_);
						object ao_(DataType @this)
						{
							var be_ = context.Operators;
							var bf_ = be_.LateBoundProperty<object>(@this, "coding");

							return bf_;
						};
						var ap_ = z_.SelectOrNull<DataType, object>(an_, ao_);
						var aq_ = z_.FlattenLateBoundList(ap_);
						Coding ar_(object @object) => 
							(@object as Coding);
						var as_ = z_.SelectOrNull<object, Coding>(aq_, ar_);
						bool? at_(Coding HeaderCode)
						{
							var bg_ = context.Operators;
							var bh_ = HeaderCode?.CodeElement;
							var bi_ = bh_?.Value;
							var bj_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
							var bk_ = bg_.InList<string>(bi_, bj_);

							return bk_;
						};
						var au_ = z_.WhereOrNull<Coding>(as_, at_);
						var av_ = z_.ExistsInList<Coding>(au_);

						return av_;
					};
					var y_ = v_.WhereOrNull<Claim>(w_, x_);

					return y_;
				};
			};
			var p_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = o_(),
			};
			var q_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				p_,
			};
			Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI r_(Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg HeaderDefinition)
			{
				var bl_ = context.Operators;
				Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI bn_()
				{
					if ((context.Operators.ExistsInList<Claim>(HeaderDefinition?.DiagnosisItems) ?? false))
					{
						var bs_ = HeaderDefinition?.DiagnosisItems;
						var bt_ = context.Operators;
						bool? by_(Claim @this)
						{
							var cg_ = context.Operators;
							var ch_ = @this?.Item;
							var ci_ = cg_.Not((bool?)(ch_ is null));

							return ci_;
						};
						var bz_ = bt_.WhereOrNull<Claim>(bs_, by_);
						List<Claim.ItemComponent> ca_(Claim @this)
						{
							var cj_ = @this?.Item;

							return cj_;
						};
						var cb_ = bt_.SelectOrNull<Claim, List<Claim.ItemComponent>>(bz_, ca_);
						var cc_ = bt_.FlattenList<Claim.ItemComponent>(cb_);
						CqlInterval<CqlDateTime> cd_(Claim.ItemComponent NormalDate)
						{
							var ck_ = NormalDate?.Serviced;
							var cl_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ck_);

							return cl_;
						};
						var ce_ = bt_.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(cc_, cd_);
						var cf_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = bs_,
							ServicePeriod = ce_,
						};

						return cf_;
					}
					else
					{
						Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI cm_ = null;

						return (cm_ as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI);
					};
				};
				var bo_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI[]
				{
					bn_(),
				};
				bool? bp_(Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList)
				{
					var cn_ = context.Operators;
					var co_ = cn_.Not((bool?)(FinalList is null));

					return co_;
				};
				var bq_ = bl_.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(bo_, bp_);
				var br_ = bl_.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(bq_);

				return br_;
			};
			var s_ = m_.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(q_, r_);
			var t_ = m_.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(s_);

			return t_;
		};
		var j_ = a_.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(h_, i_);
		var k_ = a_.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(j_);

		return k_;
	}

    [CqlDeclaration("Pharmacy Claim With Medication")]
	public IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> Pharmacy_Claim_With_Medication(IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
	{
		var a_ = context.Operators;
		var c_ = this.Pharmacy_Claims(claim);
		string e_(CqlCode p)
		{
			var l_ = p?.code;

			return l_;
		};
		var f_ = a_.SelectOrNull<CqlCode, string>(MedicationCodes, e_);
		var g_ = new Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY
		{
			PharmacyClaim = c_,
			MedicationsAsStrings = f_,
		};
		var h_ = new Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY[]
		{
			g_,
		};
		IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> i_(Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY ClaimWithMedication)
		{
			var m_ = context.Operators;
			var o_ = ClaimWithMedication?.PharmacyClaim;
			Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC p_(Claim Pharmacy)
			{
				var t_ = context.Operators;
				var w_ = Pharmacy?.Item;
				bool? x_(Claim.ItemComponent ItemOnLine)
				{
					var ae_ = context.Operators;
					var ag_ = ItemOnLine?.ProductOrService;
					var ah_ = FHIRHelpers_4_0_001.ToConcept(ag_);
					var ai_ = ah_?.codes;
					bool? aj_(CqlCode LineCode)
					{
						var am_ = context.Operators;
						var an_ = LineCode?.code;
						var ao_ = ClaimWithMedication?.MedicationsAsStrings;
						var ap_ = am_.InList<string>(an_, ao_);

						return ap_;
					};
					var ak_ = ae_.WhereOrNull<CqlCode>((ai_ as IEnumerable<CqlCode>), aj_);
					var al_ = ae_.ExistsInList<CqlCode>(ak_);

					return al_;
				};
				var y_ = t_.WhereOrNull<Claim.ItemComponent>((w_ as IEnumerable<Claim.ItemComponent>), x_);
				var z_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = Pharmacy,
					LineItems = y_,
				};
				var aa_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					z_,
				};
				Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC ab_(Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition)
				{
					var aq_ = context.Operators;
					var as_ = LineItemDefinition?.Claim;
					var at_ = new Claim[]
					{
						as_,
					};
					Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC au_(Claim ClaimLines)
					{
						var ax_ = context.Operators;
						var bb_ = ClaimLines?.Item;
						bool? bc_(Claim.ItemComponent i)
						{
							var bl_ = context.Operators;
							var bn_ = i?.ProductOrService;
							var bo_ = FHIRHelpers_4_0_001.ToConcept(bn_);
							var bp_ = bo_?.codes;
							bool? bq_(CqlCode LineCode)
							{
								var bt_ = context.Operators;
								var bu_ = LineCode?.code;
								var bv_ = ClaimWithMedication?.MedicationsAsStrings;
								var bw_ = bt_.InList<string>(bu_, bv_);

								return bw_;
							};
							var br_ = bl_.WhereOrNull<CqlCode>((bp_ as IEnumerable<CqlCode>), bq_);
							var bs_ = bl_.ExistsInList<CqlCode>(br_);

							return bs_;
						};
						var bd_ = ax_.WhereOrNull<Claim.ItemComponent>((bb_ as IEnumerable<Claim.ItemComponent>), bc_);
						Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP be_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDateTime> bx_()
							{
								if ((context.Operators.Not((bool?)(i?.Quantity is null)) ?? false))
								{
									CqlInterval<CqlDateTime> bz_()
									{
										if (i?.Serviced is Period)
										{
											var ca_ = context.Operators;
											var cc_ = i?.Serviced;
											var cd_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cc_);
											var ce_ = ca_.Start(cd_);
											var cj_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cc_);
											var ck_ = ca_.Start(cj_);
											var cl_ = i?.Quantity;
											var cm_ = cl_?.ValueElement;
											var cn_ = FHIRHelpers_4_0_001.ToDecimal(cm_);
											var co_ = new CqlQuantity
											{
												value = cn_,
												unit = "day",
											};
											var cp_ = ca_.Add(ck_, co_);
											var cr_ = ca_.Quantity(1m, "day");
											var cs_ = ca_.Subtract(cp_, cr_);
											var ct_ = ca_.Interval(ce_, cs_, true, true);

											return ct_;
										}
										else
										{
											var cu_ = context.Operators;
											var cx_ = i?.Serviced;
											var cy_ = FHIRHelpers_4_0_001.ToDate((cx_ as Date));
											var dc_ = FHIRHelpers_4_0_001.ToDate((cx_ as Date));
											var dd_ = i?.Quantity;
											var de_ = dd_?.ValueElement;
											var df_ = FHIRHelpers_4_0_001.ToDecimal(de_);
											var dg_ = new CqlQuantity
											{
												value = df_,
												unit = "day",
											};
											var dh_ = cu_.Add(dc_, dg_);
											var dj_ = cu_.Quantity(1m, "day");
											var dk_ = cu_.Subtract(dh_, dj_);
											var dl_ = cu_.Interval(cy_, dk_, true, true);
											var dm_ = dl_?.low;
											var dn_ = cu_.ConvertDateToDateTime(dm_);
											var dr_ = FHIRHelpers_4_0_001.ToDate((cx_ as Date));
											var dv_ = FHIRHelpers_4_0_001.ToDate((cx_ as Date));
											var dx_ = dd_?.ValueElement;
											var dy_ = FHIRHelpers_4_0_001.ToDecimal(dx_);
											var dz_ = new CqlQuantity
											{
												value = dy_,
												unit = "day",
											};
											var ea_ = cu_.Add(dv_, dz_);
											var ec_ = cu_.Quantity(1m, "day");
											var ed_ = cu_.Subtract(ea_, ec_);
											var ee_ = cu_.Interval(dr_, ed_, true, true);
											var ef_ = ee_?.high;
											var eg_ = cu_.ConvertDateToDateTime(ef_);
											var ej_ = FHIRHelpers_4_0_001.ToDate((cx_ as Date));
											var en_ = FHIRHelpers_4_0_001.ToDate((cx_ as Date));
											var ep_ = dd_?.ValueElement;
											var eq_ = FHIRHelpers_4_0_001.ToDecimal(ep_);
											var er_ = new CqlQuantity
											{
												value = eq_,
												unit = "day",
											};
											var es_ = cu_.Add(en_, er_);
											var eu_ = cu_.Quantity(1m, "day");
											var ev_ = cu_.Subtract(es_, eu_);
											var ew_ = cu_.Interval(ej_, ev_, true, true);
											var ex_ = ew_?.lowClosed;
											var fa_ = FHIRHelpers_4_0_001.ToDate((cx_ as Date));
											var fe_ = FHIRHelpers_4_0_001.ToDate((cx_ as Date));
											var fg_ = dd_?.ValueElement;
											var fh_ = FHIRHelpers_4_0_001.ToDecimal(fg_);
											var fi_ = new CqlQuantity
											{
												value = fh_,
												unit = "day",
											};
											var fj_ = cu_.Add(fe_, fi_);
											var fl_ = cu_.Quantity(1m, "day");
											var fm_ = cu_.Subtract(fj_, fl_);
											var fn_ = cu_.Interval(fa_, fm_, true, true);
											var fo_ = fn_?.highClosed;
											var fp_ = cu_.Interval(dn_, eg_, ex_, fo_);

											return fp_;
										};
									};

									return bz_();
								}
								else
								{
									CqlInterval<CqlDateTime> fq_ = null;

									return (fq_ as CqlInterval<CqlDateTime>);
								};
							};
							var by_ = new Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP
							{
								DaysSupplyInterval = bx_(),
							};

							return by_;
						};
						var bf_ = ax_.SelectOrNull<Claim.ItemComponent, Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP>(bd_, be_);
						var bg_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU
						{
							CoveredDays = bf_,
						};
						var bh_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU[]
						{
							bg_,
						};
						Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC bi_(Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU ItemCalculation)
						{
							Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC fr_()
							{
								if ((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
								{
									var fs_ = LineItemDefinition?.Claim;
									var ft_ = LineItemDefinition?.LineItems;
									var fu_ = context.Operators;
									bool? fy_(Claim.ItemComponent @this)
									{
										var gj_ = context.Operators;
										var gk_ = @this?.Serviced;
										var gl_ = gj_.Not((bool?)(gk_ is null));

										return gl_;
									};
									var fz_ = fu_.WhereOrNull<Claim.ItemComponent>(ft_, fy_);
									DataType ga_(Claim.ItemComponent @this)
									{
										var gm_ = @this?.Serviced;

										return gm_;
									};
									var gb_ = fu_.SelectOrNull<Claim.ItemComponent, DataType>(fz_, ga_);
									CqlInterval<CqlDateTime> gc_(DataType NormalDate)
									{
										var gn_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

										return gn_;
									};
									var gd_ = fu_.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(gb_, gc_);
									var gf_ = ItemCalculation?.CoveredDays;
									CqlInterval<CqlDateTime> gg_(Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP d)
									{
										var go_ = d?.DaysSupplyInterval;

										return go_;
									};
									var gh_ = fu_.SelectOrNull<Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP, CqlInterval<CqlDateTime>>(gf_, gg_);
									var gi_ = new Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC
									{
										Claim = fs_,
										LineItem = ft_,
										ServicePeriod = gd_,
										CoveredDays = gh_,
									};

									return gi_;
								}
								else
								{
									Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC gp_ = null;

									return (gp_ as Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC);
								};
							};

							return fr_();
						};
						var bj_ = ax_.SelectOrNull<Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(bh_, bi_);
						var bk_ = ax_.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(bj_);

						return bk_;
					};
					var av_ = aq_.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(at_, au_);
					var aw_ = aq_.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(av_);

					return aw_;
				};
				var ac_ = t_.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(aa_, ab_);
				var ad_ = t_.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ac_);

				return ad_;
			};
			var q_ = m_.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(o_, p_);
			bool? r_(Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC FinalList)
			{
				var gq_ = context.Operators;
				var gr_ = gq_.Not((bool?)(FinalList is null));

				return gr_;
			};
			var s_ = m_.WhereOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(q_, r_);

			return s_;
		};
		var j_ = a_.SelectOrNull<Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY, IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(h_, i_);
		var k_ = a_.SingleOrNull<IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(j_);

		return k_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis and Procedure")]
	public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = context.Operators;
		var c_ = this.Professional_or_Institutional_Claims(claim);
		string e_(CqlCode d)
		{
			var o_ = d?.code;

			return o_;
		};
		var f_ = a_.SelectOrNull<CqlCode, string>(DiagnosisValueSet, e_);
		string h_(CqlCode p)
		{
			var p_ = p?.code;

			return p_;
		};
		var i_ = a_.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, h_);
		var j_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = c_,
			DiagnosesAsStrings = f_,
			ProceduresAsStrings = i_,
		};
		var k_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
		{
			j_,
		};
		IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> l_(Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithDiagnosis)
		{
			var q_ = context.Operators;
			IEnumerable<Claim> s_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					IEnumerable<Claim> y_ = null;

					return (y_ as IEnumerable<Claim>);
				}
				else
				{
					var z_ = context.Operators;
					var aa_ = ClaimWithDiagnosis?.MedicalClaim;
					bool? ab_(Claim DiagnosisLine)
					{
						var ad_ = context.Operators;
						var al_ = DiagnosisLine?.Diagnosis;
						bool? am_(Claim.DiagnosisComponent @this)
						{
							var ba_ = context.Operators;
							var bb_ = @this?.Diagnosis;
							var bc_ = ba_.Not((bool?)(bb_ is null));

							return bc_;
						};
						var an_ = ad_.WhereOrNull<Claim.DiagnosisComponent>((al_ as IEnumerable<Claim.DiagnosisComponent>), am_);
						DataType ao_(Claim.DiagnosisComponent @this)
						{
							var bd_ = @this?.Diagnosis;

							return bd_;
						};
						var ap_ = ad_.SelectOrNull<Claim.DiagnosisComponent, DataType>(an_, ao_);
						bool? aq_(DataType @this)
						{
							var be_ = context.Operators;
							var bg_ = be_.LateBoundProperty<object>(@this, "coding");
							var bh_ = be_.Not((bool?)(bg_ is null));

							return bh_;
						};
						var ar_ = ad_.WhereOrNull<DataType>(ap_, aq_);
						object as_(DataType @this)
						{
							var bi_ = context.Operators;
							var bj_ = bi_.LateBoundProperty<object>(@this, "coding");

							return bj_;
						};
						var at_ = ad_.SelectOrNull<DataType, object>(ar_, as_);
						var au_ = ad_.FlattenLateBoundList(at_);
						Coding av_(object @object) => 
							(@object as Coding);
						var aw_ = ad_.SelectOrNull<object, Coding>(au_, av_);
						bool? ax_(Coding HeaderCode)
						{
							var bk_ = context.Operators;
							var bl_ = HeaderCode?.CodeElement;
							var bm_ = bl_?.Value;
							var bn_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
							var bo_ = bk_.InList<string>(bm_, bn_);

							return bo_;
						};
						var ay_ = ad_.WhereOrNull<Coding>(aw_, ax_);
						var az_ = ad_.ExistsInList<Coding>(ay_);

						return az_;
					};
					var ac_ = z_.WhereOrNull<Claim>(aa_, ab_);

					return ac_;
				};
			};
			var t_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = s_(),
			};
			var u_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				t_,
			};
			IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> v_(Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg ClaimWithProcedure)
			{
				var bp_ = context.Operators;
				var br_ = ClaimWithProcedure?.DiagnosisItems;
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bs_(Claim ClaimofInterest)
				{
					var bw_ = context.Operators;
					Claim by_()
					{
						if ((ClaimofInterest is null))
						{
							return null;
						}
						else
						{
							var ce_ = context.Operators;
							var cg_ = new Claim[]
							{
								ClaimofInterest,
							};
							bool? ch_(Claim ItemOnLine)
							{
								var ck_ = context.Operators;
								var ct_ = ItemOnLine?.Procedure;
								bool? cu_(Claim.ProcedureComponent @this)
								{
									var ed_ = context.Operators;
									var ee_ = @this?.Procedure;
									var ef_ = ed_.Not((bool?)(ee_ is null));

									return ef_;
								};
								var cv_ = ck_.WhereOrNull<Claim.ProcedureComponent>((ct_ as IEnumerable<Claim.ProcedureComponent>), cu_);
								DataType cw_(Claim.ProcedureComponent @this)
								{
									var eg_ = @this?.Procedure;

									return eg_;
								};
								var cx_ = ck_.SelectOrNull<Claim.ProcedureComponent, DataType>(cv_, cw_);
								bool? cy_(DataType @this)
								{
									var eh_ = context.Operators;
									var ej_ = eh_.LateBoundProperty<object>(@this, "coding");
									var ek_ = eh_.Not((bool?)(ej_ is null));

									return ek_;
								};
								var cz_ = ck_.WhereOrNull<DataType>(cx_, cy_);
								object da_(DataType @this)
								{
									var el_ = context.Operators;
									var em_ = el_.LateBoundProperty<object>(@this, "coding");

									return em_;
								};
								var db_ = ck_.SelectOrNull<DataType, object>(cz_, da_);
								var dc_ = ck_.FlattenLateBoundList(db_);
								Coding dd_(object @object) => 
									(@object as Coding);
								var de_ = ck_.SelectOrNull<object, Coding>(dc_, dd_);
								bool? df_(Coding ProcedureHeaderCode)
								{
									var en_ = context.Operators;
									var eo_ = ProcedureHeaderCode?.CodeElement;
									var ep_ = eo_?.Value;
									var eq_ = ClaimWithDiagnosis?.ProceduresAsStrings;
									var er_ = en_.InList<string>(ep_, eq_);

									return er_;
								};
								var dg_ = ck_.WhereOrNull<Coding>(de_, df_);
								var dh_ = ck_.ExistsInList<Coding>(dg_);
								var dp_ = ItemOnLine?.Item;
								bool? dq_(Claim.ItemComponent @this)
								{
									var es_ = context.Operators;
									var et_ = @this?.ProductOrService;
									var eu_ = es_.Not((bool?)(et_ is null));

									return eu_;
								};
								var dr_ = ck_.WhereOrNull<Claim.ItemComponent>((dp_ as IEnumerable<Claim.ItemComponent>), dq_);
								CodeableConcept ds_(Claim.ItemComponent @this)
								{
									var ev_ = @this?.ProductOrService;

									return ev_;
								};
								var dt_ = ck_.SelectOrNull<Claim.ItemComponent, CodeableConcept>(dr_, ds_);
								bool? du_(CodeableConcept @this)
								{
									var ew_ = context.Operators;
									var ex_ = @this?.Coding;
									var ey_ = ew_.Not((bool?)(ex_ is null));

									return ey_;
								};
								var dv_ = ck_.WhereOrNull<CodeableConcept>(dt_, du_);
								List<Coding> dw_(CodeableConcept @this)
								{
									var ez_ = @this?.Coding;

									return ez_;
								};
								var dx_ = ck_.SelectOrNull<CodeableConcept, List<Coding>>(dv_, dw_);
								var dy_ = ck_.FlattenList<Coding>(dx_);
								bool? dz_(Coding LineCode)
								{
									var fa_ = context.Operators;
									var fb_ = LineCode?.CodeElement;
									var fc_ = fb_?.Value;
									var fd_ = ClaimWithDiagnosis?.ProceduresAsStrings;
									var fe_ = fa_.InList<string>(fc_, fd_);

									return fe_;
								};
								var ea_ = ck_.WhereOrNull<Coding>(dy_, dz_);
								var eb_ = ck_.ExistsInList<Coding>(ea_);
								var ec_ = ck_.Or(dh_, eb_);

								return ec_;
							};
							var ci_ = ce_.WhereOrNull<Claim>(cg_, ch_);
							var cj_ = ce_.SingleOrNull<Claim>(ci_);

							return cj_;
						};
					};
					var bz_ = new Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU
					{
						ProcedureItems = by_(),
					};
					var ca_ = new Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU[]
					{
						bz_,
					};
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA cb_(Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU HeaderDefinition)
					{
						Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ff_()
						{
							if ((context.Operators.Not((bool?)(HeaderDefinition?.ProcedureItems is null)) ?? false))
							{
								var fg_ = HeaderDefinition?.ProcedureItems;
								var fh_ = context.Operators;
								var fj_ = fg_?.Item;
								CqlInterval<CqlDateTime> fk_(Claim.ItemComponent NormalDate)
								{
									var fn_ = NormalDate?.Serviced;
									var fo_ = NCQAFHIRBase_1_0_0.Normalize_Interval(fn_);

									return fo_;
								};
								var fl_ = fh_.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((fj_ as IEnumerable<Claim.ItemComponent>), fk_);
								var fm_ = new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
								{
									Claim = fg_,
									ServicePeriod = fl_,
								};

								return fm_;
							}
							else
							{
								Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA fp_ = null;

								return (fp_ as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
							};
						};

						return ff_();
					};
					var cc_ = bw_.SelectOrNull<Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ca_, cb_);
					var cd_ = bw_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(cc_);

					return cd_;
				};
				var bt_ = bp_.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(br_, bs_);
				bool? bu_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
				{
					var fq_ = context.Operators;
					var fr_ = fq_.Not((bool?)(FinalList is null));

					return fr_;
				};
				var bv_ = bp_.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bt_, bu_);

				return bv_;
			};
			var w_ = q_.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(u_, v_);
			var x_ = q_.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(w_);

			return x_;
		};
		var m_ = a_.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(k_, l_);
		var n_ = a_.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(m_);

		return n_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis and Procedure")]
	public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Principal_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = context.Operators;
		var c_ = this.Professional_or_Institutional_Claims(claim);
		string e_(CqlCode d)
		{
			var o_ = d?.code;

			return o_;
		};
		var f_ = a_.SelectOrNull<CqlCode, string>(DiagnosisValueSet, e_);
		string h_(CqlCode p)
		{
			var p_ = p?.code;

			return p_;
		};
		var i_ = a_.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, h_);
		var j_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = c_,
			DiagnosesAsStrings = f_,
			ProceduresAsStrings = i_,
		};
		var k_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
		{
			j_,
		};
		IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> l_(Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithProcedure)
		{
			var q_ = context.Operators;
			var s_ = ClaimWithProcedure?.MedicalClaim;
			Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA t_(Claim ClaimofInterest)
			{
				var x_ = context.Operators;
				Claim z_()
				{
					if ((ClaimofInterest is null))
					{
						return null;
					}
					else
					{
						var af_ = context.Operators;
						var ah_ = new Claim[]
						{
							ClaimofInterest,
						};
						bool? ai_(Claim ItemOnLine)
						{
							var al_ = context.Operators;
							var at_ = ItemOnLine?.Item;
							bool? au_(Claim.ItemComponent @this)
							{
								var ce_ = context.Operators;
								var cf_ = @this?.ProductOrService;
								var cg_ = ce_.Not((bool?)(cf_ is null));

								return cg_;
							};
							var av_ = al_.WhereOrNull<Claim.ItemComponent>((at_ as IEnumerable<Claim.ItemComponent>), au_);
							CodeableConcept aw_(Claim.ItemComponent @this)
							{
								var ch_ = @this?.ProductOrService;

								return ch_;
							};
							var ax_ = al_.SelectOrNull<Claim.ItemComponent, CodeableConcept>(av_, aw_);
							bool? ay_(CodeableConcept @this)
							{
								var ci_ = context.Operators;
								var cj_ = @this?.Coding;
								var ck_ = ci_.Not((bool?)(cj_ is null));

								return ck_;
							};
							var az_ = al_.WhereOrNull<CodeableConcept>(ax_, ay_);
							List<Coding> ba_(CodeableConcept @this)
							{
								var cl_ = @this?.Coding;

								return cl_;
							};
							var bb_ = al_.SelectOrNull<CodeableConcept, List<Coding>>(az_, ba_);
							var bc_ = al_.FlattenList<Coding>(bb_);
							bool? bd_(Coding LineCode)
							{
								var cm_ = context.Operators;
								var cn_ = LineCode?.CodeElement;
								var co_ = cn_?.Value;
								var cp_ = ClaimWithProcedure?.ProceduresAsStrings;
								var cq_ = cm_.InList<string>(co_, cp_);

								return cq_;
							};
							var be_ = al_.WhereOrNull<Coding>(bc_, bd_);
							var bf_ = al_.ExistsInList<Coding>(be_);
							var bo_ = ItemOnLine?.Procedure;
							bool? bp_(Claim.ProcedureComponent @this)
							{
								var cr_ = context.Operators;
								var cs_ = @this?.Procedure;
								var ct_ = cr_.Not((bool?)(cs_ is null));

								return ct_;
							};
							var bq_ = al_.WhereOrNull<Claim.ProcedureComponent>((bo_ as IEnumerable<Claim.ProcedureComponent>), bp_);
							DataType br_(Claim.ProcedureComponent @this)
							{
								var cu_ = @this?.Procedure;

								return cu_;
							};
							var bs_ = al_.SelectOrNull<Claim.ProcedureComponent, DataType>(bq_, br_);
							bool? bt_(DataType @this)
							{
								var cv_ = context.Operators;
								var cx_ = cv_.LateBoundProperty<object>(@this, "coding");
								var cy_ = cv_.Not((bool?)(cx_ is null));

								return cy_;
							};
							var bu_ = al_.WhereOrNull<DataType>(bs_, bt_);
							object bv_(DataType @this)
							{
								var cz_ = context.Operators;
								var da_ = cz_.LateBoundProperty<object>(@this, "coding");

								return da_;
							};
							var bw_ = al_.SelectOrNull<DataType, object>(bu_, bv_);
							var bx_ = al_.FlattenLateBoundList(bw_);
							Coding by_(object @object) => 
								(@object as Coding);
							var bz_ = al_.SelectOrNull<object, Coding>(bx_, by_);
							bool? ca_(Coding HeaderCode)
							{
								var db_ = context.Operators;
								var dc_ = HeaderCode?.CodeElement;
								var dd_ = dc_?.Value;
								var de_ = ClaimWithProcedure?.ProceduresAsStrings;
								var df_ = db_.InList<string>(dd_, de_);

								return df_;
							};
							var cb_ = al_.WhereOrNull<Coding>(bz_, ca_);
							var cc_ = al_.ExistsInList<Coding>(cb_);
							var cd_ = al_.Or(bf_, cc_);

							return cd_;
						};
						var aj_ = af_.WhereOrNull<Claim>(ah_, ai_);
						var ak_ = af_.SingleOrNull<Claim>(aj_);

						return ak_;
					};
				};
				var aa_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB
				{
					Claim = ClaimofInterest,
					ProcedureItems = z_(),
				};
				var ab_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB[]
				{
					aa_,
				};
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ac_(Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB DiagnosisCheck)
				{
					var dg_ = context.Operators;
					var di_ = DiagnosisCheck?.ProcedureItems;
					var dj_ = new Claim[]
					{
						di_,
					};
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA dk_(Claim ClaimforDiagnosis)
					{
						var dn_ = context.Operators;
						var dp_ = ClaimforDiagnosis?.Item;
						Claim dq_()
						{
							if ((ClaimforDiagnosis is null))
							{
								return null;
							}
							else
							{
								var dw_ = context.Operators;
								var dy_ = new Claim[]
								{
									ClaimforDiagnosis,
								};
								bool? dz_(Claim RightClaim)
								{
									var ec_ = context.Operators;
									var ee_ = RightClaim?.Diagnosis;
									bool? ef_(Claim.DiagnosisComponent RightDiagnosis)
									{
										var ei_ = context.Operators;
										var el_ = ei_.TypeConverter;
										var em_ = RightDiagnosis?.SequenceElement;
										var en_ = el_.Convert<Integer>(em_);
										var eo_ = FHIRHelpers_4_0_001.ToInteger(en_);
										var ep_ = ei_.Equal(eo_, (int?)1);
										var et_ = RightDiagnosis?.Diagnosis;
										var eu_ = ei_.LateBoundProperty<IEnumerable<Coding>>(et_, "coding");
										bool? ev_(Coding DiagnosisCode)
										{
											var ez_ = context.Operators;
											var fa_ = DiagnosisCode?.CodeElement;
											var fb_ = fa_?.Value;
											var fc_ = ClaimWithProcedure?.DiagnosesAsStrings;
											var fd_ = ez_.InList<string>(fb_, fc_);

											return fd_;
										};
										var ew_ = ei_.WhereOrNull<Coding>(eu_, ev_);
										var ex_ = ei_.ExistsInList<Coding>(ew_);
										var ey_ = ei_.And(ep_, ex_);

										return ey_;
									};
									var eg_ = ec_.WhereOrNull<Claim.DiagnosisComponent>((ee_ as IEnumerable<Claim.DiagnosisComponent>), ef_);
									var eh_ = ec_.ExistsInList<Claim.DiagnosisComponent>(eg_);

									return eh_;
								};
								var ea_ = dw_.WhereOrNull<Claim>(dy_, dz_);
								var eb_ = dw_.SingleOrNull<Claim>(ea_);

								return eb_;
							};
						};
						var dr_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI
						{
							Procedure = (dp_ as IEnumerable<Claim.ItemComponent>),
							LineItems = dq_(),
						};
						var ds_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI[]
						{
							dr_,
						};
						Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA dt_(Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI LineItemDefinition)
						{
							Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA fe_()
							{
								if ((context.Operators.And(context.Operators.Not((bool?)(LineItemDefinition is null)), context.Operators.Not((bool?)(LineItemDefinition?.LineItems is null))) ?? false))
								{
									var ff_ = LineItemDefinition?.LineItems;
									var fg_ = context.Operators;
									var fi_ = ff_?.Item;
									CqlInterval<CqlDateTime> fj_(Claim.ItemComponent NormalDate)
									{
										var fm_ = NormalDate?.Serviced;
										var fn_ = NCQAFHIRBase_1_0_0.Normalize_Interval(fm_);

										return fn_;
									};
									var fk_ = fg_.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((fi_ as IEnumerable<Claim.ItemComponent>), fj_);
									var fl_ = new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
									{
										Claim = ff_,
										ServicePeriod = fk_,
									};

									return fl_;
								}
								else
								{
									Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA fo_ = null;

									return (fo_ as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
								};
							};

							return fe_();
						};
						var du_ = dn_.SelectOrNull<Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ds_, dt_);
						var dv_ = dn_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(du_);

						return dv_;
					};
					var dl_ = dg_.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(dj_, dk_);
					var dm_ = dg_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(dl_);

					return dm_;
				};
				var ad_ = x_.SelectOrNull<Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ab_, ac_);
				var ae_ = x_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ad_);

				return ae_;
			};
			var u_ = q_.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(s_, t_);
			bool? v_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var fp_ = context.Operators;
				var fq_ = fp_.Not((bool?)(FinalList is null));

				return fq_;
			};
			var w_ = q_.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(u_, v_);

			return w_;
		};
		var m_ = a_.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(k_, l_);
		var n_ = a_.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(m_);

		return n_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis")]
	public IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> Medical_Claims_With_Principal_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = context.Operators;
		var c_ = this.Professional_or_Institutional_Claims(claim);
		string e_(CqlCode d)
		{
			var l_ = d?.code;

			return l_;
		};
		var f_ = a_.SelectOrNull<CqlCode, string>(DiagnosisValueSet, e_);
		var g_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = c_,
			DiagnosesAsStrings = f_,
		};
		var h_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			g_,
		};
		IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> i_(Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis)
		{
			var m_ = context.Operators;
			IEnumerable<Claim> o_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					IEnumerable<Claim> u_ = null;

					return (u_ as IEnumerable<Claim>);
				}
				else
				{
					var v_ = context.Operators;
					var w_ = ClaimWithDiagnosis?.MedicalClaim;
					bool? x_(Claim RightClaim)
					{
						var z_ = context.Operators;
						var ab_ = RightClaim?.Diagnosis;
						bool? ac_(Claim.DiagnosisComponent RightDiagnosis)
						{
							var af_ = context.Operators;
							var ai_ = af_.TypeConverter;
							var aj_ = RightDiagnosis?.SequenceElement;
							var ak_ = ai_.Convert<Integer>(aj_);
							var al_ = FHIRHelpers_4_0_001.ToInteger(ak_);
							var am_ = af_.Equal(al_, (int?)1);
							var aq_ = RightDiagnosis?.Diagnosis;
							var ar_ = af_.LateBoundProperty<IEnumerable<Coding>>(aq_, "coding");
							bool? as_(Coding DiagnosisCode)
							{
								var aw_ = context.Operators;
								var ax_ = DiagnosisCode?.CodeElement;
								var ay_ = ax_?.Value;
								var az_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
								var ba_ = aw_.InList<string>(ay_, az_);

								return ba_;
							};
							var at_ = af_.WhereOrNull<Coding>(ar_, as_);
							var au_ = af_.ExistsInList<Coding>(at_);
							var av_ = af_.And(am_, au_);

							return av_;
						};
						var ad_ = z_.WhereOrNull<Claim.DiagnosisComponent>((ab_ as IEnumerable<Claim.DiagnosisComponent>), ac_);
						var ae_ = z_.ExistsInList<Claim.DiagnosisComponent>(ad_);

						return ae_;
					};
					var y_ = v_.WhereOrNull<Claim>(w_, x_);

					return y_;
				};
			};
			var p_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN
			{
				LineItems = o_(),
			};
			var q_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN[]
			{
				p_,
			};
			IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> r_(Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN LineItemDefinition)
			{
				var bb_ = context.Operators;
				var bd_ = LineItemDefinition?.LineItems;
				Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI be_(Claim ClaimWithDiagnosis)
				{
					Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI bi_()
					{
						if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null)) ?? false))
						{
							var bj_ = LineItemDefinition?.LineItems;
							var bk_ = context.Operators;
							bool? bp_(Claim @this)
							{
								var bx_ = context.Operators;
								var by_ = @this?.Item;
								var bz_ = bx_.Not((bool?)(by_ is null));

								return bz_;
							};
							var bq_ = bk_.WhereOrNull<Claim>(bj_, bp_);
							List<Claim.ItemComponent> br_(Claim @this)
							{
								var ca_ = @this?.Item;

								return ca_;
							};
							var bs_ = bk_.SelectOrNull<Claim, List<Claim.ItemComponent>>(bq_, br_);
							var bt_ = bk_.FlattenList<Claim.ItemComponent>(bs_);
							CqlInterval<CqlDateTime> bu_(Claim.ItemComponent NormalDate)
							{
								var cb_ = NormalDate?.Serviced;
								var cc_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cb_);

								return cc_;
							};
							var bv_ = bk_.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bt_, bu_);
							var bw_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
							{
								Claim = bj_,
								ServicePeriod = bv_,
							};

							return bw_;
						}
						else
						{
							Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI cd_ = null;

							return (cd_ as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI);
						};
					};

					return bi_();
				};
				var bf_ = bb_.SelectOrNull<Claim, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(bd_, be_);
				bool? bg_(Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList)
				{
					var ce_ = context.Operators;
					var cf_ = ce_.Not((bool?)(FinalList is null));

					return cf_;
				};
				var bh_ = bb_.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(bf_, bg_);

				return bh_;
			};
			var s_ = m_.SelectOrNull<Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(q_, r_);
			var t_ = m_.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(s_);

			return t_;
		};
		var j_ = a_.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(h_, i_);
		var k_ = a_.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(j_);

		return k_;
	}

    [CqlDeclaration("Get All Professional and Institutional Claims and Claim Responses")]
	public Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		var a_ = this.Professional_or_Institutional_Claims_Response(claimResponse);
		var b_ = this.Professional_or_Institutional_Claims(claim);
		var c_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM
		{
			MedicalClaimResponse = a_,
			MedicalClaim = b_,
		};

		return c_;
	}

    [CqlDeclaration("Get All Paid Claim Reponses")]
	public IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> Get_All_Paid_Claim_Reponses(IEnumerable<ClaimResponse> claimResponse)
	{
		var a_ = context.Operators;
		bool? d_(ClaimResponse ResponseItem)
		{
			var k_ = context.Operators;
			var l_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var m_ = l_.Operators;
			var n_ = m_.TypeConverter;
			var o_ = ResponseItem?.OutcomeElement;
			var p_ = n_.Convert<string>(o_);
			var q_ = new string[]
			{
				"complete",
				"partial",
			};
			var r_ = k_.InList<string>(p_, (q_ as IEnumerable<string>));

			return r_;
		};
		var e_ = a_.WhereOrNull<ClaimResponse>(claimResponse, d_);
		var f_ = new Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD
		{
			PaidResponse = e_,
		};
		var g_ = new Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD[]
		{
			f_,
		};
		IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> h_(Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD ClaimResponse)
		{
			var s_ = context.Operators;
			var t_ = ClaimResponse?.PaidResponse;
			Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL u_(ClaimResponse ClmResp)
			{
				var w_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var x_ = w_.Operators;
				var y_ = x_.TypeConverter;
				var z_ = ClmResp?.Request;
				var aa_ = z_?.ReferenceElement;
				var ab_ = y_.Convert<string>(aa_);
				var ac_ = NCQAFHIRBase_1_0_0.GetId(ab_);
				var ad_ = context.Operators;
				var ae_ = ClmResp?.Item;
				bool? af_(ClaimResponse.ItemComponent ResponseItem)
				{
					var ai_ = context.Operators;
					var aq_ = ResponseItem?.Adjudication;
					bool? ar_(ClaimResponse.AdjudicationComponent @this)
					{
						var bq_ = context.Operators;
						var br_ = @this?.Category;
						var bs_ = bq_.Not((bool?)(br_ is null));

						return bs_;
					};
					var as_ = ai_.WhereOrNull<ClaimResponse.AdjudicationComponent>(aq_, ar_);
					CodeableConcept at_(ClaimResponse.AdjudicationComponent @this)
					{
						var bt_ = @this?.Category;

						return bt_;
					};
					var au_ = ai_.SelectOrNull<ClaimResponse.AdjudicationComponent, CodeableConcept>(as_, at_);
					bool? av_(CodeableConcept @this)
					{
						var bu_ = context.Operators;
						var bv_ = @this?.Coding;
						var bw_ = bu_.Not((bool?)(bv_ is null));

						return bw_;
					};
					var aw_ = ai_.WhereOrNull<CodeableConcept>(au_, av_);
					List<Coding> ax_(CodeableConcept @this)
					{
						var bx_ = @this?.Coding;

						return bx_;
					};
					var ay_ = ai_.SelectOrNull<CodeableConcept, List<Coding>>(aw_, ax_);
					var az_ = ai_.FlattenList<Coding>(ay_);
					bool? ba_(Coding CategoryItem)
					{
						var by_ = context.Operators;
						var bz_ = CategoryItem?.CodeElement;
						var ca_ = bz_?.Value;
						var cb_ = by_.Equal(ca_, "benefit");

						return cb_;
					};
					var bb_ = ai_.WhereOrNull<Coding>(az_, ba_);
					var bc_ = ai_.ExistsInList<Coding>(bb_);
					bool? bi_(ClaimResponse.AdjudicationComponent @this)
					{
						var cc_ = context.Operators;
						var cd_ = @this?.Amount;
						var ce_ = cc_.Not((bool?)(cd_ is null));

						return ce_;
					};
					var bj_ = ai_.WhereOrNull<ClaimResponse.AdjudicationComponent>(aq_, bi_);
					Money bk_(ClaimResponse.AdjudicationComponent @this)
					{
						var cf_ = @this?.Amount;

						return cf_;
					};
					var bl_ = ai_.SelectOrNull<ClaimResponse.AdjudicationComponent, Money>(bj_, bk_);
					bool? bm_(Money DollarAmount)
					{
						var cg_ = context.Operators;
						var ch_ = DollarAmount?.ValueElement;
						var ci_ = FHIRHelpers_4_0_001.ToDecimal(ch_);
						var ck_ = cg_.ConvertIntegerToDecimal((int?)0);
						var cl_ = cg_.Greater(ci_, ck_);

						return cl_;
					};
					var bn_ = ai_.WhereOrNull<Money>(bl_, bm_);
					var bo_ = ai_.ExistsInList<Money>(bn_);
					var bp_ = ai_.And(bc_, bo_);

					return bp_;
				};
				var ag_ = ad_.WhereOrNull<ClaimResponse.ItemComponent>((ae_ as IEnumerable<ClaimResponse.ItemComponent>), af_);
				var ah_ = new Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL
				{
					Response = ClmResp,
					ResponseID = ac_,
					LineItems = ag_,
				};

				return ah_;
			};
			var v_ = s_.SelectOrNull<ClaimResponse, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(t_, u_);

			return v_;
		};
		var i_ = a_.SelectOrNull<Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD, IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(g_, h_);
		var j_ = a_.SingleOrNull<IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(i_);

		return j_;
	}

    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
	public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_and_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = context.Operators;
		bool? c_(Claim AllClaims)
		{
			var g_ = context.Operators;
			var o_ = AllClaims?.Item;
			bool? p_(Claim.ItemComponent @this)
			{
				var az_ = context.Operators;
				var ba_ = @this?.ProductOrService;
				var bb_ = az_.Not((bool?)(ba_ is null));

				return bb_;
			};
			var q_ = g_.WhereOrNull<Claim.ItemComponent>(o_, p_);
			CodeableConcept r_(Claim.ItemComponent @this)
			{
				var bc_ = @this?.ProductOrService;

				return bc_;
			};
			var s_ = g_.SelectOrNull<Claim.ItemComponent, CodeableConcept>(q_, r_);
			bool? t_(CodeableConcept @this)
			{
				var bd_ = context.Operators;
				var be_ = @this?.Coding;
				var bf_ = bd_.Not((bool?)(be_ is null));

				return bf_;
			};
			var u_ = g_.WhereOrNull<CodeableConcept>(s_, t_);
			List<Coding> v_(CodeableConcept @this)
			{
				var bg_ = @this?.Coding;

				return bg_;
			};
			var w_ = g_.SelectOrNull<CodeableConcept, List<Coding>>(u_, v_);
			var x_ = g_.FlattenList<Coding>(w_);
			bool? y_(Coding ProductOrServiceCode)
			{
				var bh_ = context.Operators;
				var bi_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var bj_ = bh_.CodeInList(bi_, ProductOrServiceValueSet);

				return bj_;
			};
			var z_ = g_.WhereOrNull<Coding>(x_, y_);
			var aa_ = g_.ExistsInList<Coding>(z_);
			var aj_ = AllClaims?.Diagnosis;
			bool? ak_(Claim.DiagnosisComponent @this)
			{
				var bk_ = context.Operators;
				var bl_ = @this?.Diagnosis;
				var bm_ = bk_.Not((bool?)(bl_ is null));

				return bm_;
			};
			var al_ = g_.WhereOrNull<Claim.DiagnosisComponent>((aj_ as IEnumerable<Claim.DiagnosisComponent>), ak_);
			DataType am_(Claim.DiagnosisComponent @this)
			{
				var bn_ = @this?.Diagnosis;

				return bn_;
			};
			var an_ = g_.SelectOrNull<Claim.DiagnosisComponent, DataType>(al_, am_);
			bool? ao_(DataType @this)
			{
				var bo_ = context.Operators;
				var bq_ = bo_.LateBoundProperty<object>(@this, "coding");
				var br_ = bo_.Not((bool?)(bq_ is null));

				return br_;
			};
			var ap_ = g_.WhereOrNull<DataType>(an_, ao_);
			object aq_(DataType @this)
			{
				var bs_ = context.Operators;
				var bt_ = bs_.LateBoundProperty<object>(@this, "coding");

				return bt_;
			};
			var ar_ = g_.SelectOrNull<DataType, object>(ap_, aq_);
			var as_ = g_.FlattenLateBoundList(ar_);
			Coding at_(object @object) => 
				(@object as Coding);
			var au_ = g_.SelectOrNull<object, Coding>(as_, at_);
			bool? av_(Coding DiagnosisCode)
			{
				var bu_ = context.Operators;
				var bv_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
				var bw_ = bu_.CodeInList(bv_, DiagnosisValueSet);

				return bw_;
			};
			var aw_ = g_.WhereOrNull<Coding>(au_, av_);
			var ax_ = g_.ExistsInList<Coding>(aw_);
			var ay_ = g_.And(aa_, ax_);

			return ay_;
		};
		var d_ = a_.WhereOrNull<Claim>(claim, c_);
		Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM e_(Claim ProcedureClaims)
		{
			var bx_ = ProcedureClaims?.IdElement;
			var by_ = context.Operators;
			var bz_ = ProcedureClaims?.Item;
			bool? ca_(Claim.ItemComponent ResponseItem)
			{
				var cd_ = context.Operators;
				var cf_ = ResponseItem?.ProductOrService;
				var cg_ = cf_?.Coding;
				bool? ch_(Coding ProductOrServiceCode)
				{
					var ck_ = context.Operators;
					var cl_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var cm_ = ck_.CodeInList(cl_, ProductOrServiceValueSet);

					return cm_;
				};
				var ci_ = cd_.WhereOrNull<Coding>((cg_ as IEnumerable<Coding>), ch_);
				var cj_ = cd_.ExistsInList<Coding>(ci_);

				return cj_;
			};
			var cb_ = by_.WhereOrNull<Claim.ItemComponent>((bz_ as IEnumerable<Claim.ItemComponent>), ca_);
			var cc_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = ProcedureClaims,
				ClaimID = bx_,
				LineItems = cb_,
			};

			return cc_;
		};
		var f_ = a_.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services and Conditions")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_and_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = context.Operators;
		var c_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var d_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		var e_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = c_,
			MedicalClaim = d_,
		};
		var f_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			e_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO g_(Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse)
		{
			var j_ = context.Operators;
			var m_ = ClaimAndResponse?.MedicalClaim;
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg n_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				var u_ = context.Operators;
				var v_ = medClaim?.LineItems;
				bool? w_(Claim.ItemComponent medClaimLineItem)
				{
					var z_ = context.Operators;
					var ab_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> ac_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var af_ = context.Operators;
						var ah_ = pClaim?.LineItems;
						bool? ai_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var am_ = context.Operators;
							var ao_ = context.Deeper(new CallStackEntry("ToString", null, null));
							var ap_ = ao_.Operators;
							var aq_ = ap_.TypeConverter;
							Id ar_()
							{
								if (medClaim?.ClaimofInterest is Resource)
								{
									var bn_ = medClaim?.ClaimofInterest;
									var bo_ = (bn_ as Resource).IdElement;

									return bo_;
								}
								else
								{
									return null;
								};
							};
							var as_ = aq_.Convert<string>(ar_());
							var au_ = ao_.Operators;
							var av_ = au_.TypeConverter;
							var aw_ = pClaim?.Response;
							var ax_ = aw_?.Request;
							var ay_ = ax_?.ReferenceElement;
							var az_ = av_.Convert<string>(ay_);
							var ba_ = NCQAFHIRBase_1_0_0.GetId(az_);
							var bb_ = am_.Equal(as_, ba_);
							var be_ = am_.TypeConverter;
							var bf_ = medClaimLineItem?.SequenceElement;
							var bg_ = be_.Convert<Integer>(bf_);
							var bi_ = am_.TypeConverter;
							var bj_ = pClaimLineItem?.ItemSequenceElement;
							var bk_ = bi_.Convert<Integer>(bj_);
							var bl_ = am_.Equal(bg_, bk_);
							var bm_ = am_.And(bb_, bl_);

							return bm_;
						};
						var aj_ = af_.WhereOrNull<ClaimResponse.ItemComponent>(ah_, ai_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL ak_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var al_ = af_.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(aj_, ak_);

						return al_;
					};
					var ad_ = z_.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ab_, ac_);
					var ae_ = z_.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ad_);

					return ae_;
				};
				var x_ = u_.WhereOrNull<Claim.ItemComponent>(v_, w_);
				var y_ = new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = x_,
				};

				return y_;
			};
			var o_ = j_.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(m_, n_);
			var p_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = o_,
			};
			var q_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				p_,
			};
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO r_(Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				var bp_ = context.Operators;
				Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO br_()
				{
					if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
											context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
										@this?.ClaimItem))) ?? false))
					{
						var bw_ = context.Operators;
						var by_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bz_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var cq_ = context.Operators;
							var cr_ = @this?.PaidClaim;
							var cs_ = cq_.Not((bool?)(cr_ is null));

							return cs_;
						};
						var ca_ = bw_.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(by_, bz_);
						Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM cb_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var ct_ = @this?.PaidClaim;

							return ct_;
						};
						var cc_ = bw_.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(ca_, cb_);
						bool? ci_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var cu_ = context.Operators;
							var cv_ = @this?.ClaimItem;
							var cw_ = cu_.Not((bool?)(cv_ is null));

							return cw_;
						};
						var cj_ = bw_.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(by_, ci_);
						IEnumerable<Claim.ItemComponent> ck_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var cx_ = @this?.ClaimItem;

							return cx_;
						};
						var cl_ = bw_.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(cj_, ck_);
						var cm_ = bw_.FlattenList<Claim.ItemComponent>(cl_);
						CqlInterval<CqlDateTime> cn_(Claim.ItemComponent PaidItem)
						{
							var cy_ = PaidItem?.Serviced;
							var cz_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cy_);

							return cz_;
						};
						var co_ = bw_.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(cm_, cn_);
						var cp_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = cc_,
							ServicePeriod = co_,
						};

						return cp_;
					}
					else
					{
						Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO da_ = null;

						return (da_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
					};
				};
				var bs_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					br_(),
				};
				bool? bt_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var db_ = context.Operators;
					var dc_ = db_.Not((bool?)(FinalList is null));

					return dc_;
				};
				var bu_ = bp_.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bs_, bt_);
				var bv_ = bp_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bu_);

				return bv_;
			};
			var s_ = j_.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(q_, r_);
			var t_ = j_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(s_);

			return t_;
		};
		var h_ = a_.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_, g_);
		var i_ = a_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(h_);

		return i_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Service and Condition")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Service_and_Condition(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = context.Operators;
		var e_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var f_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			e_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO g_(Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse)
		{
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO n_()
			{
				if ((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
				{
					Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO o_ = null;

					return (o_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
				}
				else
				{
					var p_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					var q_ = MedicalClaimAndResponse?.MedicalClaim;
					var r_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(p_, q_, ProductOrServiceValueSet, DiagnosisValueSet);

					return r_;
				};
			};

			return n_();
		};
		var h_ = a_.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_, g_);
		var i_ = a_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(h_);
		var j_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
		{
			i_,
		};
		bool? k_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
		{
			var s_ = context.Operators;
			var t_ = s_.Not((bool?)(FinalList is null));

			return t_;
		};
		var l_ = a_.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(j_, k_);
		var m_ = a_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(l_);

		return m_;
	}

    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
	public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_or_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = context.Operators;
		bool? c_(Claim AllClaims)
		{
			var g_ = context.Operators;
			var o_ = AllClaims?.Item;
			bool? p_(Claim.ItemComponent @this)
			{
				var az_ = context.Operators;
				var ba_ = @this?.ProductOrService;
				var bb_ = az_.Not((bool?)(ba_ is null));

				return bb_;
			};
			var q_ = g_.WhereOrNull<Claim.ItemComponent>(o_, p_);
			CodeableConcept r_(Claim.ItemComponent @this)
			{
				var bc_ = @this?.ProductOrService;

				return bc_;
			};
			var s_ = g_.SelectOrNull<Claim.ItemComponent, CodeableConcept>(q_, r_);
			bool? t_(CodeableConcept @this)
			{
				var bd_ = context.Operators;
				var be_ = @this?.Coding;
				var bf_ = bd_.Not((bool?)(be_ is null));

				return bf_;
			};
			var u_ = g_.WhereOrNull<CodeableConcept>(s_, t_);
			List<Coding> v_(CodeableConcept @this)
			{
				var bg_ = @this?.Coding;

				return bg_;
			};
			var w_ = g_.SelectOrNull<CodeableConcept, List<Coding>>(u_, v_);
			var x_ = g_.FlattenList<Coding>(w_);
			bool? y_(Coding ProductOrServiceCode)
			{
				var bh_ = context.Operators;
				var bi_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var bj_ = bh_.CodeInList(bi_, ProductOrServiceValueSet);

				return bj_;
			};
			var z_ = g_.WhereOrNull<Coding>(x_, y_);
			var aa_ = g_.ExistsInList<Coding>(z_);
			var aj_ = AllClaims?.Diagnosis;
			bool? ak_(Claim.DiagnosisComponent @this)
			{
				var bk_ = context.Operators;
				var bl_ = @this?.Diagnosis;
				var bm_ = bk_.Not((bool?)(bl_ is null));

				return bm_;
			};
			var al_ = g_.WhereOrNull<Claim.DiagnosisComponent>((aj_ as IEnumerable<Claim.DiagnosisComponent>), ak_);
			DataType am_(Claim.DiagnosisComponent @this)
			{
				var bn_ = @this?.Diagnosis;

				return bn_;
			};
			var an_ = g_.SelectOrNull<Claim.DiagnosisComponent, DataType>(al_, am_);
			bool? ao_(DataType @this)
			{
				var bo_ = context.Operators;
				var bq_ = bo_.LateBoundProperty<object>(@this, "coding");
				var br_ = bo_.Not((bool?)(bq_ is null));

				return br_;
			};
			var ap_ = g_.WhereOrNull<DataType>(an_, ao_);
			object aq_(DataType @this)
			{
				var bs_ = context.Operators;
				var bt_ = bs_.LateBoundProperty<object>(@this, "coding");

				return bt_;
			};
			var ar_ = g_.SelectOrNull<DataType, object>(ap_, aq_);
			var as_ = g_.FlattenLateBoundList(ar_);
			Coding at_(object @object) => 
				(@object as Coding);
			var au_ = g_.SelectOrNull<object, Coding>(as_, at_);
			bool? av_(Coding DiagnosisCode)
			{
				var bu_ = context.Operators;
				var bv_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
				var bw_ = bu_.CodeInList(bv_, DiagnosisValueSet);

				return bw_;
			};
			var aw_ = g_.WhereOrNull<Coding>(au_, av_);
			var ax_ = g_.ExistsInList<Coding>(aw_);
			var ay_ = g_.Or(aa_, ax_);

			return ay_;
		};
		var d_ = a_.WhereOrNull<Claim>(claim, c_);
		Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM e_(Claim ProcedureClaims)
		{
			Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM bx_()
			{
				if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => 
								context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), (Coding ProductOrServiceCode) => 
											context.Operators.CodeInList(FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode), ProductOrServiceValueSet))))) ?? false))
				{
					var by_ = ProcedureClaims?.IdElement;
					var bz_ = context.Operators;
					var ca_ = ProcedureClaims?.Item;
					bool? cb_(Claim.ItemComponent ResponseItem)
					{
						var ce_ = context.Operators;
						var cg_ = ResponseItem?.ProductOrService;
						var ch_ = cg_?.Coding;
						bool? ci_(Coding ProductOrServiceCode)
						{
							var cl_ = context.Operators;
							var cm_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
							var cn_ = cl_.CodeInList(cm_, ProductOrServiceValueSet);

							return cn_;
						};
						var cj_ = ce_.WhereOrNull<Coding>((ch_ as IEnumerable<Coding>), ci_);
						var ck_ = ce_.ExistsInList<Coding>(cj_);

						return ck_;
					};
					var cc_ = bz_.WhereOrNull<Claim.ItemComponent>((ca_ as IEnumerable<Claim.ItemComponent>), cb_);
					var cd_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
					{
						ClaimofInterest = ProcedureClaims,
						ClaimID = by_,
						LineItems = cc_,
					};

					return cd_;
				}
				else
				{
					var co_ = ProcedureClaims?.IdElement;
					var cp_ = context.Operators;
					var cq_ = ProcedureClaims?.Item;
					bool? cr_(Claim.ItemComponent ResponseItem)
					{
						var cu_ = context.Operators;
						var cw_ = cu_.TypeConverter;
						var cx_ = ResponseItem?.SequenceElement;
						var cy_ = cw_.Convert<Integer>(cx_);
						var cz_ = cy_?.Value;
						var da_ = cu_.Equal(cz_, (int?)1);

						return da_;
					};
					var cs_ = cp_.WhereOrNull<Claim.ItemComponent>((cq_ as IEnumerable<Claim.ItemComponent>), cr_);
					var ct_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
					{
						ClaimofInterest = ProcedureClaims,
						ClaimID = co_,
						LineItems = cs_,
					};

					return ct_;
				};
			};

			return bx_();
		};
		var f_ = a_.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services or Conditions")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = context.Operators;
		var c_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var d_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		var e_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = c_,
			MedicalClaim = d_,
		};
		var f_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			e_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO g_(Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse)
		{
			var j_ = context.Operators;
			var m_ = ClaimAndResponse?.MedicalClaim;
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg n_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				var u_ = context.Operators;
				var v_ = medClaim?.LineItems;
				bool? w_(Claim.ItemComponent medClaimLineItem)
				{
					var z_ = context.Operators;
					var ab_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> ac_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var af_ = context.Operators;
						var ah_ = pClaim?.LineItems;
						bool? ai_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var am_ = context.Operators;
							var ao_ = context.Deeper(new CallStackEntry("ToString", null, null));
							var ap_ = ao_.Operators;
							var aq_ = ap_.TypeConverter;
							Id ar_()
							{
								if (medClaim?.ClaimofInterest is Resource)
								{
									var bn_ = medClaim?.ClaimofInterest;
									var bo_ = (bn_ as Resource).IdElement;

									return bo_;
								}
								else
								{
									return null;
								};
							};
							var as_ = aq_.Convert<string>(ar_());
							var au_ = ao_.Operators;
							var av_ = au_.TypeConverter;
							var aw_ = pClaim?.Response;
							var ax_ = aw_?.Request;
							var ay_ = ax_?.ReferenceElement;
							var az_ = av_.Convert<string>(ay_);
							var ba_ = NCQAFHIRBase_1_0_0.GetId(az_);
							var bb_ = am_.Equal(as_, ba_);
							var be_ = am_.TypeConverter;
							var bf_ = medClaimLineItem?.SequenceElement;
							var bg_ = be_.Convert<Integer>(bf_);
							var bi_ = am_.TypeConverter;
							var bj_ = pClaimLineItem?.ItemSequenceElement;
							var bk_ = bi_.Convert<Integer>(bj_);
							var bl_ = am_.Equal(bg_, bk_);
							var bm_ = am_.And(bb_, bl_);

							return bm_;
						};
						var aj_ = af_.WhereOrNull<ClaimResponse.ItemComponent>(ah_, ai_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL ak_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var al_ = af_.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(aj_, ak_);

						return al_;
					};
					var ad_ = z_.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ab_, ac_);
					var ae_ = z_.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ad_);

					return ae_;
				};
				var x_ = u_.WhereOrNull<Claim.ItemComponent>(v_, w_);
				var y_ = new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = x_,
				};

				return y_;
			};
			var o_ = j_.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(m_, n_);
			var p_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = o_,
			};
			var q_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				p_,
			};
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO r_(Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				var bp_ = context.Operators;
				Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO br_()
				{
					if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
											context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
										@this?.ClaimItem))) ?? false))
					{
						var bw_ = context.Operators;
						var by_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bz_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var cq_ = context.Operators;
							var cr_ = @this?.PaidClaim;
							var cs_ = cq_.Not((bool?)(cr_ is null));

							return cs_;
						};
						var ca_ = bw_.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(by_, bz_);
						Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM cb_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var ct_ = @this?.PaidClaim;

							return ct_;
						};
						var cc_ = bw_.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(ca_, cb_);
						bool? ci_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var cu_ = context.Operators;
							var cv_ = @this?.ClaimItem;
							var cw_ = cu_.Not((bool?)(cv_ is null));

							return cw_;
						};
						var cj_ = bw_.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(by_, ci_);
						IEnumerable<Claim.ItemComponent> ck_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var cx_ = @this?.ClaimItem;

							return cx_;
						};
						var cl_ = bw_.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(cj_, ck_);
						var cm_ = bw_.FlattenList<Claim.ItemComponent>(cl_);
						CqlInterval<CqlDateTime> cn_(Claim.ItemComponent PaidItem)
						{
							var cy_ = PaidItem?.Serviced;
							var cz_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cy_);

							return cz_;
						};
						var co_ = bw_.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(cm_, cn_);
						var cp_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = cc_,
							ServicePeriod = co_,
						};

						return cp_;
					}
					else
					{
						Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO da_ = null;

						return (da_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
					};
				};
				var bs_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					br_(),
				};
				bool? bt_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var db_ = context.Operators;
					var dc_ = db_.Not((bool?)(FinalList is null));

					return dc_;
				};
				var bu_ = bp_.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bs_, bt_);
				var bv_ = bp_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bu_);

				return bv_;
			};
			var s_ = j_.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(q_, r_);
			var t_ = j_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(s_);

			return t_;
		};
		var h_ = a_.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_, g_);
		var i_ = a_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(h_);

		return i_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services or Conditions")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = context.Operators;
		var c_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var d_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			c_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO e_(Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse)
		{
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO h_()
			{
				if ((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
				{
					Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO i_ = null;

					return (i_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
				}
				else
				{
					var j_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					var k_ = MedicalClaimAndResponse?.MedicalClaim;
					var l_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(j_, k_, ProductOrServiceValueSet, DiagnosisValueSet);

					return l_;
				};
			};

			return h_();
		};
		var f_ = a_.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var g_ = a_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);

		return g_;
	}

    [CqlDeclaration("Get All Claims With Procedure Only")]
	public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_Only(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = context.Operators;
		bool? c_(Claim AllClaims)
		{
			var g_ = context.Operators;
			var n_ = AllClaims?.Item;
			bool? o_(Claim.ItemComponent @this)
			{
				var aa_ = context.Operators;
				var ab_ = @this?.ProductOrService;
				var ac_ = aa_.Not((bool?)(ab_ is null));

				return ac_;
			};
			var p_ = g_.WhereOrNull<Claim.ItemComponent>(n_, o_);
			CodeableConcept q_(Claim.ItemComponent @this)
			{
				var ad_ = @this?.ProductOrService;

				return ad_;
			};
			var r_ = g_.SelectOrNull<Claim.ItemComponent, CodeableConcept>(p_, q_);
			bool? s_(CodeableConcept @this)
			{
				var ae_ = context.Operators;
				var af_ = @this?.Coding;
				var ag_ = ae_.Not((bool?)(af_ is null));

				return ag_;
			};
			var t_ = g_.WhereOrNull<CodeableConcept>(r_, s_);
			List<Coding> u_(CodeableConcept @this)
			{
				var ah_ = @this?.Coding;

				return ah_;
			};
			var v_ = g_.SelectOrNull<CodeableConcept, List<Coding>>(t_, u_);
			var w_ = g_.FlattenList<Coding>(v_);
			bool? x_(Coding ProductOrServiceCode)
			{
				var ai_ = context.Operators;
				var aj_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var ak_ = ai_.CodeInList(aj_, ProductOrServiceValueSet);

				return ak_;
			};
			var y_ = g_.WhereOrNull<Coding>(w_, x_);
			var z_ = g_.ExistsInList<Coding>(y_);

			return z_;
		};
		var d_ = a_.WhereOrNull<Claim>(claim, c_);
		Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM e_(Claim AllClaims)
		{
			var al_ = AllClaims?.IdElement;
			var am_ = context.Operators;
			var an_ = AllClaims?.Item;
			bool? ao_(Claim.ItemComponent ResponseItem)
			{
				var ar_ = context.Operators;
				var at_ = ResponseItem?.ProductOrService;
				var au_ = at_?.Coding;
				bool? av_(Coding ProductOrServiceCode)
				{
					var ay_ = context.Operators;
					var az_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var ba_ = ay_.CodeInList(az_, ProductOrServiceValueSet);

					return ba_;
				};
				var aw_ = ar_.WhereOrNull<Coding>((au_ as IEnumerable<Coding>), av_);
				var ax_ = ar_.ExistsInList<Coding>(aw_);

				return ax_;
			};
			var ap_ = am_.WhereOrNull<Claim.ItemComponent>((an_ as IEnumerable<Claim.ItemComponent>), ao_);
			var aq_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = AllClaims,
				ClaimID = al_,
				LineItems = ap_,
			};

			return aq_;
		};
		var f_ = a_.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services Only")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = context.Operators;
		var c_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var d_ = this.Get_All_Claims_With_Procedure_Only(claim, ProductOrServiceValueSet);
		var e_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = c_,
			MedicalClaim = d_,
		};
		var f_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			e_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO g_(Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse)
		{
			var j_ = context.Operators;
			var m_ = ClaimAndResponse?.MedicalClaim;
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg n_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				var u_ = context.Operators;
				var v_ = medClaim?.LineItems;
				bool? w_(Claim.ItemComponent medClaimLineItem)
				{
					var z_ = context.Operators;
					var ab_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> ac_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var af_ = context.Operators;
						var ah_ = pClaim?.LineItems;
						bool? ai_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var am_ = context.Operators;
							var ao_ = context.Deeper(new CallStackEntry("ToString", null, null));
							var ap_ = ao_.Operators;
							var aq_ = ap_.TypeConverter;
							Id ar_()
							{
								if (medClaim?.ClaimofInterest is Resource)
								{
									var bn_ = medClaim?.ClaimofInterest;
									var bo_ = (bn_ as Resource).IdElement;

									return bo_;
								}
								else
								{
									return null;
								};
							};
							var as_ = aq_.Convert<string>(ar_());
							var au_ = ao_.Operators;
							var av_ = au_.TypeConverter;
							var aw_ = pClaim?.Response;
							var ax_ = aw_?.Request;
							var ay_ = ax_?.ReferenceElement;
							var az_ = av_.Convert<string>(ay_);
							var ba_ = NCQAFHIRBase_1_0_0.GetId(az_);
							var bb_ = am_.Equal(as_, ba_);
							var be_ = am_.TypeConverter;
							var bf_ = medClaimLineItem?.SequenceElement;
							var bg_ = be_.Convert<Integer>(bf_);
							var bi_ = am_.TypeConverter;
							var bj_ = pClaimLineItem?.ItemSequenceElement;
							var bk_ = bi_.Convert<Integer>(bj_);
							var bl_ = am_.Equal(bg_, bk_);
							var bm_ = am_.And(bb_, bl_);

							return bm_;
						};
						var aj_ = af_.WhereOrNull<ClaimResponse.ItemComponent>(ah_, ai_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL ak_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var al_ = af_.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(aj_, ak_);

						return al_;
					};
					var ad_ = z_.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ab_, ac_);
					var ae_ = z_.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ad_);

					return ae_;
				};
				var x_ = u_.WhereOrNull<Claim.ItemComponent>(v_, w_);
				var y_ = new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = x_,
				};

				return y_;
			};
			var o_ = j_.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(m_, n_);
			var p_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = o_,
			};
			var q_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				p_,
			};
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO r_(Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				var bp_ = context.Operators;
				Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO br_()
				{
					if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
											context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
										@this?.ClaimItem))) ?? false))
					{
						var bw_ = context.Operators;
						var by_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bz_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var cq_ = context.Operators;
							var cr_ = @this?.PaidClaim;
							var cs_ = cq_.Not((bool?)(cr_ is null));

							return cs_;
						};
						var ca_ = bw_.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(by_, bz_);
						Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM cb_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var ct_ = @this?.PaidClaim;

							return ct_;
						};
						var cc_ = bw_.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(ca_, cb_);
						bool? ci_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var cu_ = context.Operators;
							var cv_ = @this?.ClaimItem;
							var cw_ = cu_.Not((bool?)(cv_ is null));

							return cw_;
						};
						var cj_ = bw_.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(by_, ci_);
						IEnumerable<Claim.ItemComponent> ck_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var cx_ = @this?.ClaimItem;

							return cx_;
						};
						var cl_ = bw_.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(cj_, ck_);
						var cm_ = bw_.FlattenList<Claim.ItemComponent>(cl_);
						CqlInterval<CqlDateTime> cn_(Claim.ItemComponent PaidItem)
						{
							var cy_ = PaidItem?.Serviced;
							var cz_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cy_);

							return cz_;
						};
						var co_ = bw_.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(cm_, cn_);
						var cp_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = cc_,
							ServicePeriod = co_,
						};

						return cp_;
					}
					else
					{
						Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO da_ = null;

						return (da_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
					};
				};
				var bs_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					br_(),
				};
				bool? bt_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var db_ = context.Operators;
					var dc_ = db_.Not((bool?)(FinalList is null));

					return dc_;
				};
				var bu_ = bp_.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bs_, bt_);
				var bv_ = bp_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bu_);

				return bv_;
			};
			var s_ = j_.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(q_, r_);
			var t_ = j_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(s_);

			return t_;
		};
		var h_ = a_.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_, g_);
		var i_ = a_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(h_);

		return i_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services Only")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = context.Operators;
		var c_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var d_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			c_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO e_(Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse)
		{
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO h_()
			{
				if ((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
				{
					Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO i_ = null;

					return (i_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
				}
				else
				{
					var j_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					var k_ = MedicalClaimAndResponse?.MedicalClaim;
					var l_ = this.Get_Corresponding_Claim_for_Services_Only(j_, k_, ProductOrServiceValueSet);

					return l_;
				};
			};

			return h_();
		};
		var f_ = a_.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var g_ = a_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);

		return g_;
	}

    [CqlDeclaration("Get All Pharmacy Claims and Claim Responses")]
	public Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR Get_All_Pharmacy_Claims_and_Claim_Responses(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		var a_ = this.Pharmacy_Claims_Response(claimResponse);
		var b_ = this.Pharmacy_Claims(claim);
		var c_ = new Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR
		{
			PharmacyClaimResponse = a_,
			PharmacyClaim = b_,
		};

		return c_;
	}

    [CqlDeclaration("Get Corresponding Claim for Pharmacy Services")]
	public Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO Get_Corresponding_Claim_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = context.Operators;
		var c_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var d_ = this.Pharmacy_Claim_With_Medication(claim, ProductOrServiceValueSet);
		var e_ = new Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB
		{
			PaidPharmacyClaimResponse = c_,
			MedicalClaim = d_,
		};
		var f_ = new Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB[]
		{
			e_,
		};
		Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO g_(Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB ClaimAndResponse)
		{
			var j_ = context.Operators;
			var m_ = ClaimAndResponse?.MedicalClaim;
			Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT n_(Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC medClaim)
			{
				var u_ = context.Operators;
				var v_ = medClaim?.LineItem;
				bool? w_(Claim.ItemComponent medClaimLineItem)
				{
					var z_ = context.Operators;
					var ab_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> ac_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var af_ = context.Operators;
						var ah_ = pClaim?.LineItems;
						bool? ai_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var am_ = context.Operators;
							var ao_ = context.Deeper(new CallStackEntry("ToString", null, null));
							var ap_ = ao_.Operators;
							var aq_ = ap_.TypeConverter;
							Id ar_()
							{
								if (medClaim?.Claim is Resource)
								{
									var bn_ = medClaim?.Claim;
									var bo_ = (bn_ as Resource).IdElement;

									return bo_;
								}
								else
								{
									return null;
								};
							};
							var as_ = aq_.Convert<string>(ar_());
							var au_ = ao_.Operators;
							var av_ = au_.TypeConverter;
							var aw_ = pClaim?.Response;
							var ax_ = aw_?.Request;
							var ay_ = ax_?.ReferenceElement;
							var az_ = av_.Convert<string>(ay_);
							var ba_ = NCQAFHIRBase_1_0_0.GetId(az_);
							var bb_ = am_.Equal(as_, ba_);
							var be_ = am_.TypeConverter;
							var bf_ = medClaimLineItem?.SequenceElement;
							var bg_ = be_.Convert<Integer>(bf_);
							var bi_ = am_.TypeConverter;
							var bj_ = pClaimLineItem?.ItemSequenceElement;
							var bk_ = bi_.Convert<Integer>(bj_);
							var bl_ = am_.Equal(bg_, bk_);
							var bm_ = am_.And(bb_, bl_);

							return bm_;
						};
						var aj_ = af_.WhereOrNull<ClaimResponse.ItemComponent>(ah_, ai_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL ak_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var al_ = af_.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(aj_, ak_);

						return al_;
					};
					var ad_ = z_.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ab_, ac_);
					var ae_ = z_.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ad_);

					return ae_;
				};
				var x_ = u_.WhereOrNull<Claim.ItemComponent>(v_, w_);
				var y_ = new Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT
				{
					PaidClaim = medClaim,
					ClaimItem = x_,
				};

				return y_;
			};
			var o_ = j_.SelectOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC, Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(m_, n_);
			var p_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB
			{
				AggregateClaim = o_,
			};
			var q_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB[]
			{
				p_,
			};
			Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO r_(Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB ClaimWithPaidResponse)
			{
				var bp_ = context.Operators;
				Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO br_()
				{
					if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => 
											context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => 
										@this?.ClaimItem))) ?? false))
					{
						var bw_ = context.Operators;
						var by_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bz_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var dc_ = context.Operators;
							var dd_ = @this?.PaidClaim;
							var de_ = dc_.Not((bool?)(dd_ is null));

							return de_;
						};
						var ca_ = bw_.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(by_, bz_);
						Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC cb_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var df_ = @this?.PaidClaim;

							return df_;
						};
						var cc_ = bw_.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ca_, cb_);
						bool? ci_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var dg_ = context.Operators;
							var dh_ = @this?.ClaimItem;
							var di_ = dg_.Not((bool?)(dh_ is null));

							return di_;
						};
						var cj_ = bw_.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(by_, ci_);
						IEnumerable<Claim.ItemComponent> ck_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var dj_ = @this?.ClaimItem;

							return dj_;
						};
						var cl_ = bw_.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(cj_, ck_);
						var cm_ = bw_.FlattenList<Claim.ItemComponent>(cl_);
						CqlInterval<CqlDateTime> cn_(Claim.ItemComponent PaidItem)
						{
							var dk_ = PaidItem?.Serviced;
							var dl_ = NCQAFHIRBase_1_0_0.Normalize_Interval(dk_);

							return dl_;
						};
						var co_ = bw_.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(cm_, cn_);
						bool? cu_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var dm_ = context.Operators;
							var dn_ = @this?.ClaimItem;
							var do_ = dm_.Not((bool?)(dn_ is null));

							return do_;
						};
						var cv_ = bw_.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(by_, cu_);
						IEnumerable<Claim.ItemComponent> cw_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var dp_ = @this?.ClaimItem;

							return dp_;
						};
						var cx_ = bw_.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(cv_, cw_);
						var cy_ = bw_.FlattenList<Claim.ItemComponent>(cx_);
						CqlInterval<CqlDate> cz_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDate> dq_()
							{
								if ((context.Operators.Not((bool?)(i?.Quantity is null)) ?? false))
								{
									var dr_ = context.Operators;
									var du_ = i?.Serviced;
									var dv_ = NCQAFHIRBase_1_0_0.Normalize_Interval(du_);
									var dw_ = dr_.Start(dv_);
									var dx_ = dr_.ConvertDateTimeToDate(dw_);
									var ed_ = NCQAFHIRBase_1_0_0.Normalize_Interval(du_);
									var ee_ = dr_.Start(ed_);
									var ef_ = i?.Quantity;
									var eg_ = ef_?.ValueElement;
									var eh_ = FHIRHelpers_4_0_001.ToDecimal(eg_);
									var ei_ = new CqlQuantity
									{
										value = eh_,
										unit = "day",
									};
									var ej_ = dr_.Add(ee_, ei_);
									var el_ = dr_.Quantity(1m, "day");
									var em_ = dr_.Subtract(ej_, el_);
									var en_ = dr_.ConvertDateTimeToDate(em_);
									var eo_ = dr_.Interval(dx_, en_, true, true);

									return eo_;
								}
								else
								{
									CqlInterval<CqlDate> ep_ = null;

									return (ep_ as CqlInterval<CqlDate>);
								};
							};

							return dq_();
						};
						var da_ = bw_.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDate>>(cy_, cz_);
						var db_ = new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO
						{
							originalClaim = cc_,
							ServicePeriod = co_,
							CoveredDays = da_,
						};

						return db_;
					}
					else
					{
						Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO eq_ = null;

						return (eq_ as Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO);
					};
				};
				var bs_ = new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO[]
				{
					br_(),
				};
				bool? bt_(Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO FinalList)
				{
					var er_ = context.Operators;
					var es_ = er_.Not((bool?)(FinalList is null));

					return es_;
				};
				var bu_ = bp_.WhereOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(bs_, bt_);
				var bv_ = bp_.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(bu_);

				return bv_;
			};
			var s_ = j_.SelectOrNull<Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(q_, r_);
			var t_ = j_.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(s_);

			return t_;
		};
		var h_ = a_.SelectOrNull<Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(f_, g_);
		var i_ = a_.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(h_);

		return i_;
	}

    [CqlDeclaration("Get Paid Claims for Pharmacy Services")]
	public Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO Get_Paid_Claims_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = context.Operators;
		var c_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(claimResponse, claim);
		var d_ = new Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR[]
		{
			c_,
		};
		Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO e_(Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR PharmacyClaimAndResponse)
		{
			Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO h_()
			{
				if ((context.Operators.And((bool?)(PharmacyClaimAndResponse?.PharmacyClaimResponse is null), (bool?)(PharmacyClaimAndResponse?.PharmacyClaim is null)) ?? false))
				{
					Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO i_ = null;

					return (i_ as Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO);
				}
				else
				{
					var j_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
					var k_ = PharmacyClaimAndResponse?.PharmacyClaim;
					var l_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(j_, k_, ProductOrServiceValueSet);

					return l_;
				};
			};

			return h_();
		};
		var f_ = a_.SelectOrNull<Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(d_, e_);
		var g_ = a_.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Claim With Corresponding Claim Response")]
	public IEnumerable<Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI> Get_Claim_With_Corresponding_Claim_Response(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		var a_ = context.Operators;
		Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI b_(Claim Claim)
		{
			var d_ = context.Operators;
			bool? e_(ClaimResponse CR)
			{
				var k_ = context.Operators;
				var l_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var m_ = l_.Operators;
				var n_ = m_.TypeConverter;
				var o_ = Claim?.IdElement;
				var p_ = n_.Convert<string>(o_);
				var r_ = l_.Operators;
				var s_ = r_.TypeConverter;
				var t_ = CR?.Request;
				var u_ = t_?.ReferenceElement;
				var v_ = s_.Convert<string>(u_);
				var w_ = NCQAFHIRBase_1_0_0.GetId(v_);
				var x_ = k_.Equal(p_, w_);

				return x_;
			};
			var f_ = d_.WhereOrNull<ClaimResponse>(claimResponse, e_);
			bool? h_(Claim C)
			{
				var y_ = context.Operators;
				var z_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var aa_ = z_.Operators;
				var ab_ = aa_.TypeConverter;
				var ac_ = Claim?.IdElement;
				var ad_ = ab_.Convert<string>(ac_);
				var af_ = z_.Operators;
				var ag_ = af_.TypeConverter;
				bool? an_(ClaimResponse CR)
				{
					var bb_ = context.Operators;
					var bc_ = context.Deeper(new CallStackEntry("ToString", null, null));
					var bd_ = bc_.Operators;
					var be_ = bd_.TypeConverter;
					var bf_ = Claim?.IdElement;
					var bg_ = be_.Convert<string>(bf_);
					var bi_ = bc_.Operators;
					var bj_ = bi_.TypeConverter;
					var bk_ = CR?.Request;
					var bl_ = bk_?.ReferenceElement;
					var bm_ = bj_.Convert<string>(bl_);
					var bn_ = NCQAFHIRBase_1_0_0.GetId(bm_);
					var bo_ = bb_.Equal(bg_, bn_);

					return bo_;
				};
				var ao_ = y_.WhereOrNull<ClaimResponse>(claimResponse, an_);
				bool? ap_(ClaimResponse @this)
				{
					var bp_ = context.Operators;
					var bq_ = @this?.Request;
					var br_ = bp_.Not((bool?)(bq_ is null));

					return br_;
				};
				var aq_ = y_.WhereOrNull<ClaimResponse>(ao_, ap_);
				ResourceReference ar_(ClaimResponse @this)
				{
					var bs_ = @this?.Request;

					return bs_;
				};
				var as_ = y_.SelectOrNull<ClaimResponse, ResourceReference>(aq_, ar_);
				bool? at_(ResourceReference @this)
				{
					var bt_ = context.Operators;
					var bu_ = @this?.ReferenceElement;
					var bv_ = bt_.Not((bool?)(bu_ is null));

					return bv_;
				};
				var au_ = y_.WhereOrNull<ResourceReference>(as_, at_);
				FhirString av_(ResourceReference @this)
				{
					var bw_ = @this?.ReferenceElement;

					return bw_;
				};
				var aw_ = y_.SelectOrNull<ResourceReference, FhirString>(au_, av_);
				var ax_ = y_.SingleOrNull<FhirString>(aw_);
				var ay_ = ag_.Convert<string>(ax_);
				var az_ = NCQAFHIRBase_1_0_0.GetId(ay_);
				var ba_ = y_.Equal(ad_, az_);

				return ba_;
			};
			var i_ = d_.WhereOrNull<Claim>(claim, h_);
			var j_ = new Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI
			{
				ClaimResponse = f_,
				OriginalClaim = i_,
			};

			return j_;
		};
		var c_ = a_.SelectOrNull<Claim, Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI>(claim, b_);

		return c_;
	}

    [CqlDeclaration("Medical Claims With Nonacute or Acute Inpatient Discharge")]
	public Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(IEnumerable<Claim> claim)
	{
		var a_ = context.Operators;
		var c_ = this.Professional_or_Institutional_Claims(claim);
		var d_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = c_,
		};
		var e_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			d_,
		};
		Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE f_(Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithInpatientStay)
		{
			var i_ = context.Operators;
			IEnumerable<Claim> k_()
			{
				if ((ClaimWithInpatientStay?.MedicalClaim is null))
				{
					IEnumerable<Claim> r_ = null;

					return (r_ as IEnumerable<Claim>);
				}
				else
				{
					var s_ = context.Operators;
					var t_ = ClaimWithInpatientStay?.MedicalClaim;
					bool? u_(Claim c)
					{
						var w_ = context.Operators;
						var y_ = c?.Item;
						bool? z_(Claim.ItemComponent i)
						{
							var ac_ = context.Operators;
							var ae_ = i?.Revenue;
							var af_ = FHIRHelpers_4_0_001.ToConcept(ae_);
							var ag_ = af_?.codes;
							bool? ah_(CqlCode rev)
							{
								var ak_ = context.Operators;
								var al_ = rev?.code;
								var am_ = this.Inpatient_Stay();
								var an_ = ak_.StringInValueSet(al_, am_);

								return an_;
							};
							var ai_ = ac_.WhereOrNull<CqlCode>((ag_ as IEnumerable<CqlCode>), ah_);
							var aj_ = ac_.ExistsInList<CqlCode>(ai_);

							return aj_;
						};
						var aa_ = w_.WhereOrNull<Claim.ItemComponent>((y_ as IEnumerable<Claim.ItemComponent>), z_);
						var ab_ = w_.ExistsInList<Claim.ItemComponent>(aa_);

						return ab_;
					};
					var v_ = s_.WhereOrNull<Claim>(t_, u_);

					return v_;
				};
			};
			IEnumerable<Claim> l_()
			{
				if ((ClaimWithInpatientStay?.MedicalClaim is null))
				{
					IEnumerable<Claim> ao_ = null;

					return (ao_ as IEnumerable<Claim>);
				}
				else
				{
					var ap_ = context.Operators;
					var aq_ = ClaimWithInpatientStay?.MedicalClaim;
					bool? ar_(Claim c)
					{
						var at_ = context.Operators;
						var aw_ = c?.Item;
						bool? ax_(Claim.ItemComponent i)
						{
							var bi_ = context.Operators;
							var bk_ = i?.Revenue;
							var bl_ = FHIRHelpers_4_0_001.ToConcept(bk_);
							var bm_ = bl_?.codes;
							bool? bn_(CqlCode rev)
							{
								var bq_ = context.Operators;
								var br_ = rev?.code;
								var bs_ = this.Nonacute_Inpatient_Stay();
								var bt_ = bq_.StringInValueSet(br_, bs_);

								return bt_;
							};
							var bo_ = bi_.WhereOrNull<CqlCode>((bm_ as IEnumerable<CqlCode>), bn_);
							var bp_ = bi_.ExistsInList<CqlCode>(bo_);

							return bp_;
						};
						var ay_ = at_.WhereOrNull<Claim.ItemComponent>((aw_ as IEnumerable<Claim.ItemComponent>), ax_);
						var az_ = at_.ExistsInList<Claim.ItemComponent>(ay_);
						var bc_ = c?.SubType;
						var bd_ = bc_?.Coding;
						bool? be_(Coding tob)
						{
							var bu_ = context.Operators;
							var bv_ = tob?.CodeElement;
							var bw_ = bv_?.Value;
							var bx_ = this.Nonacute_Inpatient_Stay();
							var by_ = bu_.StringInValueSet(bw_, bx_);

							return by_;
						};
						var bf_ = at_.WhereOrNull<Coding>((bd_ as IEnumerable<Coding>), be_);
						var bg_ = at_.ExistsInList<Coding>(bf_);
						var bh_ = at_.Or(az_, bg_);

						return bh_;
					};
					var as_ = ap_.WhereOrNull<Claim>(aq_, ar_);

					return as_;
				};
			};
			var m_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb
			{
				InpatientStayLineItems = k_(),
				NonacuteInpatientLineItems = l_(),
			};
			var n_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb[]
			{
				m_,
			};
			Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE o_(Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb LineItemDefinition)
			{
				var bz_ = LineItemDefinition?.InpatientStayLineItems;
				var ca_ = context.Operators;
				var cb_ = LineItemDefinition?.NonacuteInpatientLineItems;
				IEnumerable<Claim> cc_(Claim nonAcuteInpatientStay)
				{
					var cm_ = context.Operators;
					var co_ = LineItemDefinition?.InpatientStayLineItems;
					bool? cp_(Claim inpatientStay)
					{
						var ct_ = context.Operators;
						var cu_ = nonAcuteInpatientStay?.IdElement;
						var cv_ = inpatientStay?.IdElement;
						var cw_ = ct_.Equal(cu_, cv_);

						return cw_;
					};
					var cq_ = cm_.WhereOrNull<Claim>(co_, cp_);
					Claim cr_(Claim inpatientStay) => 
						nonAcuteInpatientStay;
					var cs_ = cm_.SelectOrNull<Claim, Claim>(cq_, cr_);

					return cs_;
				};
				var cd_ = ca_.SelectManyOrNull<Claim, Claim>(cb_, cc_);
				IEnumerable<Claim> ci_(Claim inpatientStay)
				{
					var cx_ = context.Operators;
					var cz_ = LineItemDefinition?.NonacuteInpatientLineItems;
					bool? da_(Claim nonAcuteInpatientStay)
					{
						var de_ = context.Operators;
						var df_ = inpatientStay?.IdElement;
						var dg_ = nonAcuteInpatientStay?.IdElement;
						var dh_ = de_.Equal(df_, dg_);

						return dh_;
					};
					var db_ = cx_.WhereOrNull<Claim>(cz_, da_);
					Claim dc_(Claim nonAcuteInpatientStay) => 
						inpatientStay;
					var dd_ = cx_.SelectOrNull<Claim, Claim>(db_, dc_);

					return dd_;
				};
				var cj_ = ca_.SelectManyOrNull<Claim, Claim>(bz_, ci_);
				var ck_ = ca_.ListExcept<Claim>(bz_, cj_);
				var cl_ = new Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE
				{
					InpatientDischarge = bz_,
					NonacuteInpatientDischarge = cd_,
					AcuteInpatientDischarge = ck_,
				};

				return cl_;
			};
			var p_ = i_.SelectOrNull<Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb, Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(n_, o_);
			var q_ = i_.SingleOrNull<Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(p_);

			return q_;
		};
		var g_ = a_.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(e_, f_);
		var h_ = a_.SingleOrNull<Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(g_);

		return h_;
	}

    [CqlDeclaration("Get Prescriber NPI from Claims")]
	public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Prescriber_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		var a_ = context.Operators;
		Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS d_(Claim C)
		{
			var k_ = context.Operators;
			var n_ = C?.CareTeam;
			bool? o_(Claim.CareTeamComponent ct)
			{
				var ai_ = context.Operators;
				var ak_ = ai_.TypeConverter;
				var al_ = ct?.SequenceElement;
				var am_ = ak_.Convert<Integer>(al_);
				var an_ = FHIRHelpers_4_0_001.ToInteger(am_);
				var ao_ = ai_.Equal(an_, (int?)1);

				return ao_;
			};
			var p_ = k_.WhereOrNull<Claim.CareTeamComponent>((n_ as IEnumerable<Claim.CareTeamComponent>), o_);
			bool? q_(Claim.CareTeamComponent @this)
			{
				var ap_ = context.Operators;
				var aq_ = @this?.Provider;
				var ar_ = ap_.Not((bool?)(aq_ is null));

				return ar_;
			};
			var r_ = k_.WhereOrNull<Claim.CareTeamComponent>(p_, q_);
			ResourceReference s_(Claim.CareTeamComponent @this)
			{
				var as_ = @this?.Provider;

				return as_;
			};
			var t_ = k_.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(r_, s_);
			bool? z_(Claim.CareTeamComponent ct)
			{
				var at_ = context.Operators;
				var av_ = at_.TypeConverter;
				var aw_ = ct?.SequenceElement;
				var ax_ = av_.Convert<Integer>(aw_);
				var ay_ = FHIRHelpers_4_0_001.ToInteger(ax_);
				var az_ = at_.Equal(ay_, (int?)1);

				return az_;
			};
			var aa_ = k_.WhereOrNull<Claim.CareTeamComponent>((n_ as IEnumerable<Claim.CareTeamComponent>), z_);
			bool? ab_(Claim.CareTeamComponent @this)
			{
				var ba_ = context.Operators;
				var bb_ = @this?.Provider;
				var bc_ = ba_.Not((bool?)(bb_ is null));

				return bc_;
			};
			var ac_ = k_.WhereOrNull<Claim.CareTeamComponent>(aa_, ab_);
			ResourceReference ad_(Claim.CareTeamComponent @this)
			{
				var bd_ = @this?.Provider;

				return bd_;
			};
			var ae_ = k_.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(ac_, ad_);
			string af_(ResourceReference p)
			{
				var be_ = context.Operators;
				var bg_ = p?.ReferenceElement;
				var bh_ = new FhirString[]
				{
					bg_,
				};
				string bi_(FhirString r)
				{
					var bl_ = context.Deeper(new CallStackEntry("ToString", null, null));
					var bm_ = bl_.Operators;
					var bn_ = bm_.TypeConverter;
					var bo_ = bn_.Convert<string>(r);
					var bp_ = NCQAFHIRBase_1_0_0.GetId(bo_);

					return bp_;
				};
				var bj_ = be_.SelectOrNull<FhirString, string>(bh_, bi_);
				var bk_ = be_.SingleOrNull<string>(bj_);

				return bk_;
			};
			var ag_ = k_.SelectOrNull<ResourceReference, string>(ae_, af_);
			var ah_ = new Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS
			{
				SingleCareTeam = C,
				CareTeamsProvider = t_,
				CareTeamsProviderID = ag_,
			};

			return ah_;
		};
		var e_ = a_.SelectOrNull<Claim, Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(claim, d_);
		var f_ = new Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR
		{
			CareTeams = e_,
		};
		var g_ = new Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR[]
		{
			f_,
		};
		Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY h_(Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR ClaimProperties)
		{
			var bq_ = context.Operators;
			var bt_ = context.DataRetriever;
			var bu_ = bt_.RetrieveByValueSet<Practitioner>(null, null);
			bool? bv_(Practitioner p)
			{
				var cc_ = context.Operators;
				var cd_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var ce_ = cd_.Operators;
				var cf_ = ce_.TypeConverter;
				var cg_ = p?.IdElement;
				var ch_ = cf_.Convert<string>(cg_);
				var cl_ = ClaimProperties?.CareTeams;
				bool? cm_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
				{
					var cs_ = context.Operators;
					var ct_ = @this?.CareTeamsProviderID;
					var cu_ = cs_.Not((bool?)(ct_ is null));

					return cu_;
				};
				var cn_ = cc_.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(cl_, cm_);
				IEnumerable<string> co_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
				{
					var cv_ = @this?.CareTeamsProviderID;

					return cv_;
				};
				var cp_ = cc_.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, IEnumerable<string>>(cn_, co_);
				var cq_ = cc_.FlattenList<string>(cp_);
				var cr_ = cc_.InList<string>(ch_, cq_);

				return cr_;
			};
			var bw_ = bq_.WhereOrNull<Practitioner>(bu_, bv_);
			var bx_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe
			{
				Practitioners = bw_,
			};
			var by_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe[]
			{
				bx_,
			};
			Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY bz_(Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe PractitionerMatch)
			{
				var cw_ = context.Operators;
				var da_ = PractitionerMatch?.Practitioners;
				bool? db_(Practitioner P)
				{
					var dk_ = context.Operators;
					var dl_ = dk_.Not((bool?)(P is null));

					return dl_;
				};
				var dc_ = cw_.WhereOrNull<Practitioner>(da_, db_);
				Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR dd_(Practitioner P)
				{
					var dm_ = context.Operators;
					var do_ = P?.Identifier;
					bool? dp_(Identifier l)
					{
						var eb_ = context.Operators;
						var ee_ = l?.SystemElement;
						var ef_ = ee_?.Value;
						var eg_ = eb_.Equal(ef_, "http://hl7.org/fhir/sid/us-npi");
						var ei_ = l?.Type;
						var ej_ = FHIRHelpers_4_0_001.ToConcept(ei_);
						var el_ = NCQATerminology_1_0_0.Provider_number();
						var em_ = eb_.ConvertCodeToConcept(el_);
						var en_ = eb_.Equivalent(ej_, em_);
						var eo_ = eb_.And(eg_, en_);
						var eq_ = l?.ValueElement;
						var er_ = eq_?.Value;
						var es_ = eb_.Not((bool?)(er_ is null));
						var et_ = eb_.And(eo_, es_);

						return et_;
					};
					var dq_ = dm_.WhereOrNull<Identifier>((do_ as IEnumerable<Identifier>), dp_);
					FhirString dr_(Identifier l)
					{
						var eu_ = l?.ValueElement;

						return eu_;
					};
					var ds_ = dm_.SelectOrNull<Identifier, FhirString>(dq_, dr_);
					bool? dw_(Identifier l)
					{
						var ev_ = context.Operators;
						var ey_ = l?.SystemElement;
						var ez_ = ey_?.Value;
						var fa_ = ev_.Equal(ez_, "http://hl7.org/fhir/sid/us-npi");
						var fc_ = l?.Type;
						var fd_ = FHIRHelpers_4_0_001.ToConcept(fc_);
						var ff_ = NCQATerminology_1_0_0.Provider_number();
						var fg_ = ev_.ConvertCodeToConcept(ff_);
						var fh_ = ev_.Equivalent(fd_, fg_);
						var fi_ = ev_.And(fa_, fh_);
						var fj_ = l?.ValueElement;
						var fk_ = fj_?.Value;
						var fl_ = ev_.And(fi_, (bool?)(fk_ is null));

						return fl_;
					};
					var dx_ = dm_.WhereOrNull<Identifier>((do_ as IEnumerable<Identifier>), dw_);
					Identifier dy_(Identifier l) => 
						l;
					var dz_ = dm_.SelectOrNull<Identifier, Identifier>(dx_, dy_);
					var ea_ = new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = ds_,
						NullIdentifiers = dz_,
					};

					return ea_;
				};
				var de_ = cw_.SelectOrNull<Practitioner, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(dc_, dd_);
				var df_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = de_,
				};
				var dg_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					df_,
				};
				Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY dh_(Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers)
				{
					int? fm_()
					{
						if ((context.Operators.ExistsInList<Claim>(context.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => 
											context.Operators.Not((bool?)(@this?.SingleCareTeam is null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => 
										@this?.SingleCareTeam)) ?? false))
						{
							var fo_ = context.Operators;
							var fu_ = ClaimProperties?.CareTeams;
							bool? fv_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
							{
								var gx_ = context.Operators;
								var gy_ = @this?.SingleCareTeam;
								var gz_ = gx_.Not((bool?)(gy_ is null));

								return gz_;
							};
							var fw_ = fo_.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(fu_, fv_);
							Claim fx_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
							{
								var ha_ = @this?.SingleCareTeam;

								return ha_;
							};
							var fy_ = fo_.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(fw_, fx_);
							bool? fz_(Claim X)
							{
								var hb_ = X?.CareTeam;

								return (bool?)((hb_ as IEnumerable<Claim.CareTeamComponent>) is null);
							};
							var ga_ = fo_.WhereOrNull<Claim>(fy_, fz_);
							var gb_ = fo_.CountOrNull<Claim>(ga_);
							var gg_ = GetIdentifiers?.IdentifierTuple;
							IEnumerable<FhirString> gh_(Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X)
							{
								var hc_ = X?.AllIdentifiers;

								return hc_;
							};
							var gi_ = fo_.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(gg_, gh_);
							var gj_ = fo_.FlattenList<FhirString>(gi_);
							FhirString gk_(FhirString X) => 
								X;
							var gl_ = fo_.SelectOrNull<FhirString, FhirString>(gj_, gk_);
							var gm_ = fo_.CountOrNull<FhirString>(gl_);
							var gn_ = fo_.Add(gb_, gm_);
							IEnumerable<Identifier> gs_(Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X)
							{
								var hd_ = X?.NullIdentifiers;

								return hd_;
							};
							var gt_ = fo_.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(gg_, gs_);
							var gu_ = fo_.FlattenList<Identifier>(gt_);
							var gv_ = fo_.CountOrNull<Identifier>(gu_);
							var gw_ = fo_.Add(gn_, gv_);

							return gw_;
						}
						else
						{
							return (int?)0;
						};
					};
					var fn_ = new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = fm_(),
					};

					return fn_;
				};
				var di_ = cw_.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dg_, dh_);
				var dj_ = cw_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(di_);

				return dj_;
			};
			var ca_ = bq_.SelectOrNull<Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(by_, bz_);
			var cb_ = bq_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ca_);

			return cb_;
		};
		var i_ = a_.SelectOrNull<Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(g_, h_);
		var j_ = a_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(i_);

		return j_;
	}

    [CqlDeclaration("Get Pharmacy NPI from Claims")]
	public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Pharmacy_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		var a_ = context.Operators;
		Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI d_(Claim C)
		{
			var k_ = C?.Item;
			var l_ = context.Operators;
			bool? q_(Claim.ItemComponent i)
			{
				var am_ = context.Operators;
				var ao_ = am_.TypeConverter;
				var ap_ = i?.SequenceElement;
				var aq_ = ao_.Convert<Integer>(ap_);
				var ar_ = FHIRHelpers_4_0_001.ToInteger(aq_);
				var as_ = am_.Equal(ar_, (int?)1);

				return as_;
			};
			var r_ = l_.WhereOrNull<Claim.ItemComponent>((k_ as IEnumerable<Claim.ItemComponent>), q_);
			bool? s_(Claim.ItemComponent @this)
			{
				var at_ = context.Operators;
				var au_ = @this?.Location;
				var av_ = at_.Not((bool?)(au_ is null));

				return av_;
			};
			var t_ = l_.WhereOrNull<Claim.ItemComponent>(r_, s_);
			DataType u_(Claim.ItemComponent @this)
			{
				var aw_ = @this?.Location;

				return aw_;
			};
			var v_ = l_.SelectOrNull<Claim.ItemComponent, DataType>(t_, u_);
			ResourceReference w_(DataType l) => 
				(l as ResourceReference);
			var x_ = l_.SelectOrNull<DataType, ResourceReference>(v_, w_);
			bool? ad_(Claim.ItemComponent i)
			{
				var ax_ = context.Operators;
				var az_ = ax_.TypeConverter;
				var ba_ = i?.SequenceElement;
				var bb_ = az_.Convert<Integer>(ba_);
				var bc_ = FHIRHelpers_4_0_001.ToInteger(bb_);
				var bd_ = ax_.Equal(bc_, (int?)1);

				return bd_;
			};
			var ae_ = l_.WhereOrNull<Claim.ItemComponent>((k_ as IEnumerable<Claim.ItemComponent>), ad_);
			bool? af_(Claim.ItemComponent @this)
			{
				var be_ = context.Operators;
				var bf_ = @this?.Location;
				var bg_ = be_.Not((bool?)(bf_ is null));

				return bg_;
			};
			var ag_ = l_.WhereOrNull<Claim.ItemComponent>(ae_, af_);
			DataType ah_(Claim.ItemComponent @this)
			{
				var bh_ = @this?.Location;

				return bh_;
			};
			var ai_ = l_.SelectOrNull<Claim.ItemComponent, DataType>(ag_, ah_);
			string aj_(DataType l)
			{
				var bi_ = context.Operators;
				var bk_ = (l as ResourceReference)?.ReferenceElement;
				var bl_ = new FhirString[]
				{
					bk_,
				};
				string bm_(FhirString r)
				{
					var bp_ = context.Deeper(new CallStackEntry("ToString", null, null));
					var bq_ = bp_.Operators;
					var br_ = bq_.TypeConverter;
					var bs_ = br_.Convert<string>(r);
					var bt_ = NCQAFHIRBase_1_0_0.GetId(bs_);

					return bt_;
				};
				var bn_ = bi_.SelectOrNull<FhirString, string>(bl_, bm_);
				var bo_ = bi_.SingleOrNull<string>(bn_);

				return bo_;
			};
			var ak_ = l_.SelectOrNull<DataType, string>(ai_, aj_);
			var al_ = new Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI
			{
				SingleItem = (k_ as IEnumerable<Claim.ItemComponent>),
				ItemLocation = x_,
				ItemLocationID = ak_,
			};

			return al_;
		};
		var e_ = a_.SelectOrNull<Claim, Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(claim, d_);
		var f_ = new Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa
		{
			ItemsLocationReferences = e_,
		};
		var g_ = new Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa[]
		{
			f_,
		};
		Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY h_(Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa ClaimProperties)
		{
			var bu_ = context.Operators;
			var bx_ = context.DataRetriever;
			var by_ = bx_.RetrieveByValueSet<Location>(null, null);
			bool? bz_(Location l)
			{
				var cg_ = context.Operators;
				var ch_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var ci_ = ch_.Operators;
				var cj_ = ci_.TypeConverter;
				var ck_ = l?.IdElement;
				var cl_ = cj_.Convert<string>(ck_);
				var cp_ = ClaimProperties?.ItemsLocationReferences;
				bool? cq_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
				{
					var cw_ = context.Operators;
					var cx_ = @this?.ItemLocationID;
					var cy_ = cw_.Not((bool?)(cx_ is null));

					return cy_;
				};
				var cr_ = cg_.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(cp_, cq_);
				IEnumerable<string> cs_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
				{
					var cz_ = @this?.ItemLocationID;

					return cz_;
				};
				var ct_ = cg_.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<string>>(cr_, cs_);
				var cu_ = cg_.FlattenList<string>(ct_);
				var cv_ = cg_.InList<string>(cl_, cu_);

				return cv_;
			};
			var ca_ = bu_.WhereOrNull<Location>(by_, bz_);
			var cb_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP
			{
				CorrespondingLocations = ca_,
			};
			var cc_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP[]
			{
				cb_,
			};
			Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY cd_(Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP GetLocation)
			{
				var da_ = context.Operators;
				var de_ = GetLocation?.CorrespondingLocations;
				bool? df_(Location C)
				{
					var do_ = context.Operators;
					var dp_ = do_.Not((bool?)(C is null));

					return dp_;
				};
				var dg_ = da_.WhereOrNull<Location>(de_, df_);
				Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR dh_(Location C)
				{
					var dq_ = context.Operators;
					var ds_ = C?.Identifier;
					bool? dt_(Identifier l)
					{
						var ef_ = context.Operators;
						var ei_ = l?.SystemElement;
						var ej_ = ei_?.Value;
						var ek_ = ef_.Equal(ej_, "http://hl7.org/fhir/sid/us-npi");
						var em_ = l?.Type;
						var en_ = FHIRHelpers_4_0_001.ToConcept(em_);
						var ep_ = NCQATerminology_1_0_0.Provider_number();
						var eq_ = ef_.ConvertCodeToConcept(ep_);
						var er_ = ef_.Equivalent(en_, eq_);
						var es_ = ef_.And(ek_, er_);
						var eu_ = l?.ValueElement;
						var ev_ = eu_?.Value;
						var ew_ = ef_.Not((bool?)(ev_ is null));
						var ex_ = ef_.And(es_, ew_);

						return ex_;
					};
					var du_ = dq_.WhereOrNull<Identifier>((ds_ as IEnumerable<Identifier>), dt_);
					FhirString dv_(Identifier l)
					{
						var ey_ = l?.ValueElement;

						return ey_;
					};
					var dw_ = dq_.SelectOrNull<Identifier, FhirString>(du_, dv_);
					bool? ea_(Identifier l)
					{
						var ez_ = context.Operators;
						var fc_ = l?.SystemElement;
						var fd_ = fc_?.Value;
						var fe_ = ez_.Equal(fd_, "http://hl7.org/fhir/sid/us-npi");
						var fg_ = l?.Type;
						var fh_ = FHIRHelpers_4_0_001.ToConcept(fg_);
						var fj_ = NCQATerminology_1_0_0.Provider_number();
						var fk_ = ez_.ConvertCodeToConcept(fj_);
						var fl_ = ez_.Equivalent(fh_, fk_);
						var fm_ = ez_.And(fe_, fl_);
						var fn_ = l?.ValueElement;
						var fo_ = fn_?.Value;
						var fp_ = ez_.And(fm_, (bool?)(fo_ is null));

						return fp_;
					};
					var eb_ = dq_.WhereOrNull<Identifier>((ds_ as IEnumerable<Identifier>), ea_);
					Identifier ec_(Identifier l) => 
						l;
					var ed_ = dq_.SelectOrNull<Identifier, Identifier>(eb_, ec_);
					var ee_ = new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = dw_,
						NullIdentifiers = ed_,
					};

					return ee_;
				};
				var di_ = da_.SelectOrNull<Location, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(dg_, dh_);
				var dj_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = di_,
				};
				var dk_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					dj_,
				};
				Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY dl_(Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers)
				{
					int? fq_()
					{
						if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => 
												context.Operators.Not((bool?)(@this?.SingleItem is null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => 
											@this?.SingleItem))) ?? false))
						{
							var fs_ = context.Operators;
							var fz_ = ClaimProperties?.ItemsLocationReferences;
							bool? ga_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
							{
								var hd_ = context.Operators;
								var he_ = @this?.ItemLocation;
								var hf_ = hd_.Not((bool?)(he_ is null));

								return hf_;
							};
							var gb_ = fs_.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(fz_, ga_);
							IEnumerable<ResourceReference> gc_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
							{
								var hg_ = @this?.ItemLocation;

								return hg_;
							};
							var gd_ = fs_.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<ResourceReference>>(gb_, gc_);
							var ge_ = fs_.FlattenList<ResourceReference>(gd_);
							bool? gf_(ResourceReference X)
							{
								var hh_ = X?.ReferenceElement;
								var hi_ = hh_?.Value;

								return (bool?)(hi_ is null);
							};
							var gg_ = fs_.WhereOrNull<ResourceReference>(ge_, gf_);
							var gh_ = fs_.CountOrNull<ResourceReference>(gg_);
							var gm_ = GetIdentifiers?.IdentifierTuple;
							IEnumerable<FhirString> gn_(Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X)
							{
								var hj_ = X?.AllIdentifiers;

								return hj_;
							};
							var go_ = fs_.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(gm_, gn_);
							var gp_ = fs_.FlattenList<FhirString>(go_);
							FhirString gq_(FhirString X) => 
								X;
							var gr_ = fs_.SelectOrNull<FhirString, FhirString>(gp_, gq_);
							var gs_ = fs_.CountOrNull<FhirString>(gr_);
							var gt_ = fs_.Add(gh_, gs_);
							IEnumerable<Identifier> gy_(Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X)
							{
								var hk_ = X?.NullIdentifiers;

								return hk_;
							};
							var gz_ = fs_.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(gm_, gy_);
							var ha_ = fs_.FlattenList<Identifier>(gz_);
							var hb_ = fs_.CountOrNull<Identifier>(ha_);
							var hc_ = fs_.Add(gt_, hb_);

							return hc_;
						}
						else
						{
							return (int?)0;
						};
					};
					var fr_ = new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = fq_(),
					};

					return fr_;
				};
				var dm_ = da_.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dk_, dl_);
				var dn_ = da_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dm_);

				return dn_;
			};
			var ce_ = bu_.SelectOrNull<Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cc_, cd_);
			var cf_ = bu_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ce_);

			return cf_;
		};
		var i_ = a_.SelectOrNull<Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(g_, h_);
		var j_ = a_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(i_);

		return j_;
	}

}
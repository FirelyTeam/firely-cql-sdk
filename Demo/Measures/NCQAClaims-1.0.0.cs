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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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
			var g_ = context.Operators.ListContains<CqlCode>((e_ as IEnumerable<CqlCode>), f_);
			var i_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var j_ = i_?.codes;
			var k_ = NCQATerminology_1_0_0.Institutional();
			var l_ = context.Operators.ListContains<CqlCode>((j_ as IEnumerable<CqlCode>), k_);
			var m_ = context.Operators.Or(g_, l_);

			return m_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);

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
			var g_ = context.Operators.ListContains<CqlCode>((e_ as IEnumerable<CqlCode>), f_);

			return g_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);

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
			var g_ = context.Operators.ListContains<CqlCode>((e_ as IEnumerable<CqlCode>), f_);
			var i_ = FHIRHelpers_4_0_001.ToConcept(c_);
			var j_ = i_?.codes;
			var k_ = NCQATerminology_1_0_0.Institutional();
			var l_ = context.Operators.ListContains<CqlCode>((j_ as IEnumerable<CqlCode>), k_);
			var m_ = context.Operators.Or(g_, l_);

			return m_;
		};
		var b_ = context.Operators.WhereOrNull<ClaimResponse>(claimResponse, a_);

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
			var g_ = context.Operators.ListContains<CqlCode>((e_ as IEnumerable<CqlCode>), f_);

			return g_;
		};
		var b_ = context.Operators.WhereOrNull<ClaimResponse>(claimResponse, a_);

		return b_;
	}

    [CqlDeclaration("Medical Claims With Procedure and POS")]
	public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_and_POS(IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p)
		{
			var k_ = p?.code;

			return k_;
		};
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, b_);
		string d_(CqlCode pos)
		{
			var l_ = pos?.code;

			return l_;
		};
		var e_ = context.Operators.SelectOrNull<CqlCode, string>(posCodes, d_);
		var f_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = a_,
			ProceduresAsStrings = c_,
			POSAsString = e_,
		};
		var g_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			f_,
		};
		IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> h_(Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithPosCode)
		{
			var m_ = ClaimWithPosCode?.MedicalClaim;
			Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA n_(Claim ClaimofInterest)
			{
				IEnumerable<Claim.ItemComponent> r_()
				{
					if ((ClaimofInterest is null))
					{
						IEnumerable<Claim.ItemComponent> x_ = null;

						return (x_ as IEnumerable<Claim.ItemComponent>);
					}
					else
					{
						var y_ = ClaimofInterest?.Item;
						bool? z_(Claim.ItemComponent ItemOnLine)
						{
							var ab_ = ItemOnLine?.ProductOrService;
							var ac_ = FHIRHelpers_4_0_001.ToConcept(ab_);
							var ad_ = ac_?.codes;
							bool? ae_(CqlCode LineCode)
							{
								var ao_ = LineCode?.code;
								var ap_ = ClaimWithPosCode?.ProceduresAsStrings;
								var aq_ = context.Operators.InList<string>(ao_, ap_);

								return aq_;
							};
							var af_ = context.Operators.WhereOrNull<CqlCode>((ad_ as IEnumerable<CqlCode>), ae_);
							var ag_ = context.Operators.ExistsInList<CqlCode>(af_);
							var ah_ = ItemOnLine?.Location;
							var ai_ = FHIRHelpers_4_0_001.ToConcept((ah_ as CodeableConcept));
							var aj_ = ai_?.codes;
							bool? ak_(CqlCode PosCode)
							{
								var ar_ = PosCode?.code;
								var as_ = ClaimWithPosCode?.POSAsString;
								var at_ = context.Operators.InList<string>(ar_, as_);

								return at_;
							};
							var al_ = context.Operators.WhereOrNull<CqlCode>((aj_ as IEnumerable<CqlCode>), ak_);
							var am_ = context.Operators.ExistsInList<CqlCode>(al_);
							var an_ = context.Operators.And(ag_, am_);

							return an_;
						};
						var aa_ = context.Operators.WhereOrNull<Claim.ItemComponent>((y_ as IEnumerable<Claim.ItemComponent>), z_);

						return aa_;
					};
				};
				var s_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = ClaimofInterest,
					LineItems = r_(),
				};
				var t_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					s_,
				};
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA u_(Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition)
				{
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA au_()
					{
						if ((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
						{
							var av_ = LineItemDefinition?.Claim;
							var aw_ = LineItemDefinition?.LineItems;
							bool? ax_(Claim.ItemComponent @this)
							{
								var be_ = @this?.Serviced;
								var bf_ = context.Operators.Not((bool?)(be_ is null));

								return bf_;
							};
							var ay_ = context.Operators.WhereOrNull<Claim.ItemComponent>(aw_, ax_);
							DataType az_(Claim.ItemComponent @this)
							{
								var bg_ = @this?.Serviced;

								return bg_;
							};
							var ba_ = context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(ay_, az_);
							CqlInterval<CqlDateTime> bb_(DataType NormalDate)
							{
								var bh_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return bh_;
							};
							var bc_ = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(ba_, bb_);
							var bd_ = new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = av_,
								ServicePeriod = bc_,
							};

							return bd_;
						}
						else
						{
							Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bi_ = null;

							return (bi_ as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
						};
					};

					return au_();
				};
				var v_ = context.Operators.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(t_, u_);
				var w_ = context.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(v_);

				return w_;
			};
			var o_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(m_, n_);
			bool? p_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var bj_ = context.Operators.Not((bool?)(FinalList is null));

				return bj_;
			};
			var q_ = context.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(o_, p_);

			return q_;
		};
		var i_ = context.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);
		var j_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Procedure in Header or on Line Item")]
	public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p)
		{
			var i_ = p?.code;

			return i_;
		};
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, b_);
		var d_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = a_,
			ProceduresAsStrings = c_,
		};
		var e_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			d_,
		};
		IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> f_(Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithProcedure)
		{
			var j_ = ClaimWithProcedure?.MedicalClaim;
			Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA k_(Claim ClaimofInterest)
			{
				IEnumerable<Claim.ItemComponent> o_()
				{
					if ((ClaimofInterest is null))
					{
						IEnumerable<Claim.ItemComponent> u_ = null;

						return (u_ as IEnumerable<Claim.ItemComponent>);
					}
					else
					{
						var v_ = ClaimofInterest?.Item;
						bool? w_(Claim.ItemComponent ItemOnLine)
						{
							var y_ = ItemOnLine?.ProductOrService;
							var z_ = FHIRHelpers_4_0_001.ToConcept(y_);
							var aa_ = z_?.codes;
							bool? ab_(CqlCode LineCode)
							{
								var au_ = LineCode?.code;
								var av_ = ClaimWithProcedure?.ProceduresAsStrings;
								var aw_ = context.Operators.InList<string>(au_, av_);

								return aw_;
							};
							var ac_ = context.Operators.WhereOrNull<CqlCode>((aa_ as IEnumerable<CqlCode>), ab_);
							var ad_ = context.Operators.ExistsInList<CqlCode>(ac_);
							var ae_ = ClaimofInterest?.Procedure;
							bool? af_(Claim.ProcedureComponent @this)
							{
								var ax_ = @this?.Procedure;
								var ay_ = context.Operators.Not((bool?)(ax_ is null));

								return ay_;
							};
							var ag_ = context.Operators.WhereOrNull<Claim.ProcedureComponent>((ae_ as IEnumerable<Claim.ProcedureComponent>), af_);
							DataType ah_(Claim.ProcedureComponent @this)
							{
								var az_ = @this?.Procedure;

								return az_;
							};
							var ai_ = context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(ag_, ah_);
							bool? aj_(DataType @this)
							{
								var ba_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								var bb_ = context.Operators.Not((bool?)(ba_ is null));

								return bb_;
							};
							var ak_ = context.Operators.WhereOrNull<DataType>(ai_, aj_);
							object al_(DataType @this)
							{
								var bc_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return bc_;
							};
							var am_ = context.Operators.SelectOrNull<DataType, object>(ak_, al_);
							var an_ = context.Operators.FlattenLateBoundList(am_);
							Coding ao_(object @object) => 
								(@object as Coding);
							var ap_ = context.Operators.SelectOrNull<object, Coding>(an_, ao_);
							bool? aq_(Coding HeaderCode)
							{
								var bd_ = HeaderCode?.CodeElement;
								var be_ = bd_?.Value;
								var bf_ = ClaimWithProcedure?.ProceduresAsStrings;
								var bg_ = context.Operators.InList<string>(be_, bf_);

								return bg_;
							};
							var ar_ = context.Operators.WhereOrNull<Coding>(ap_, aq_);
							var as_ = context.Operators.ExistsInList<Coding>(ar_);
							var at_ = context.Operators.Or(ad_, as_);

							return at_;
						};
						var x_ = context.Operators.WhereOrNull<Claim.ItemComponent>((v_ as IEnumerable<Claim.ItemComponent>), w_);

						return x_;
					};
				};
				var p_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = ClaimofInterest,
					LineItems = o_(),
				};
				var q_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					p_,
				};
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA r_(Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition)
				{
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bh_()
					{
						if ((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
						{
							var bi_ = LineItemDefinition?.Claim;
							var bj_ = LineItemDefinition?.LineItems;
							bool? bk_(Claim.ItemComponent @this)
							{
								var br_ = @this?.Serviced;
								var bs_ = context.Operators.Not((bool?)(br_ is null));

								return bs_;
							};
							var bl_ = context.Operators.WhereOrNull<Claim.ItemComponent>(bj_, bk_);
							DataType bm_(Claim.ItemComponent @this)
							{
								var bt_ = @this?.Serviced;

								return bt_;
							};
							var bn_ = context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(bl_, bm_);
							CqlInterval<CqlDateTime> bo_(DataType NormalDate)
							{
								var bu_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return bu_;
							};
							var bp_ = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(bn_, bo_);
							var bq_ = new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = bi_,
								ServicePeriod = bp_,
							};

							return bq_;
						}
						else
						{
							Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bv_ = null;

							return (bv_ as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
						};
					};

					return bh_();
				};
				var s_ = context.Operators.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_, r_);
				var t_ = context.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(s_);

				return t_;
			};
			var l_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(j_, k_);
			bool? m_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var bw_ = context.Operators.Not((bool?)(FinalList is null));

				return bw_;
			};
			var n_ = context.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(l_, m_);

			return n_;
		};
		var g_ = context.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(e_, f_);
		var h_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis")]
	public Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI Medical_Claims_With_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var i_ = d?.code;

			return i_;
		};
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		var d_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
		};
		var e_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			d_,
		};
		Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI f_(Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis)
		{
			IEnumerable<Claim> j_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					IEnumerable<Claim> p_ = null;

					return (p_ as IEnumerable<Claim>);
				}
				else
				{
					var q_ = ClaimWithDiagnosis?.MedicalClaim;
					bool? r_(Claim DiagnosisLine)
					{
						var t_ = DiagnosisLine?.Diagnosis;
						bool? u_(Claim.DiagnosisComponent @this)
						{
							var ai_ = @this?.Diagnosis;
							var aj_ = context.Operators.Not((bool?)(ai_ is null));

							return aj_;
						};
						var v_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((t_ as IEnumerable<Claim.DiagnosisComponent>), u_);
						DataType w_(Claim.DiagnosisComponent @this)
						{
							var ak_ = @this?.Diagnosis;

							return ak_;
						};
						var x_ = context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(v_, w_);
						bool? y_(DataType @this)
						{
							var al_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							var am_ = context.Operators.Not((bool?)(al_ is null));

							return am_;
						};
						var z_ = context.Operators.WhereOrNull<DataType>(x_, y_);
						object aa_(DataType @this)
						{
							var an_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return an_;
						};
						var ab_ = context.Operators.SelectOrNull<DataType, object>(z_, aa_);
						var ac_ = context.Operators.FlattenLateBoundList(ab_);
						Coding ad_(object @object) => 
							(@object as Coding);
						var ae_ = context.Operators.SelectOrNull<object, Coding>(ac_, ad_);
						bool? af_(Coding HeaderCode)
						{
							var ao_ = HeaderCode?.CodeElement;
							var ap_ = ao_?.Value;
							var aq_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
							var ar_ = context.Operators.InList<string>(ap_, aq_);

							return ar_;
						};
						var ag_ = context.Operators.WhereOrNull<Coding>(ae_, af_);
						var ah_ = context.Operators.ExistsInList<Coding>(ag_);

						return ah_;
					};
					var s_ = context.Operators.WhereOrNull<Claim>(q_, r_);

					return s_;
				};
			};
			var k_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = j_(),
			};
			var l_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				k_,
			};
			Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI m_(Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg HeaderDefinition)
			{
				Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI as_()
				{
					if ((context.Operators.ExistsInList<Claim>(HeaderDefinition?.DiagnosisItems) ?? false))
					{
						var ax_ = HeaderDefinition?.DiagnosisItems;
						bool? az_(Claim @this)
						{
							var bh_ = @this?.Item;
							var bi_ = context.Operators.Not((bool?)(bh_ is null));

							return bi_;
						};
						var ba_ = context.Operators.WhereOrNull<Claim>(ax_, az_);
						List<Claim.ItemComponent> bb_(Claim @this)
						{
							var bj_ = @this?.Item;

							return bj_;
						};
						var bc_ = context.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(ba_, bb_);
						var bd_ = context.Operators.FlattenList<Claim.ItemComponent>(bc_);
						CqlInterval<CqlDateTime> be_(Claim.ItemComponent NormalDate)
						{
							var bk_ = NormalDate?.Serviced;
							var bl_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bk_);

							return bl_;
						};
						var bf_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bd_, be_);
						var bg_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = ax_,
							ServicePeriod = bf_,
						};

						return bg_;
					}
					else
					{
						Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI bm_ = null;

						return (bm_ as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI);
					};
				};
				var at_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI[]
				{
					as_(),
				};
				bool? au_(Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList)
				{
					var bn_ = context.Operators.Not((bool?)(FinalList is null));

					return bn_;
				};
				var av_ = context.Operators.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(at_, au_);
				var aw_ = context.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(av_);

				return aw_;
			};
			var n_ = context.Operators.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(l_, m_);
			var o_ = context.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(n_);

			return o_;
		};
		var g_ = context.Operators.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(e_, f_);
		var h_ = context.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(g_);

		return h_;
	}

    [CqlDeclaration("Pharmacy Claim With Medication")]
	public IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> Pharmacy_Claim_With_Medication(IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
	{
		var a_ = this.Pharmacy_Claims(claim);
		string b_(CqlCode p)
		{
			var i_ = p?.code;

			return i_;
		};
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(MedicationCodes, b_);
		var d_ = new Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY
		{
			PharmacyClaim = a_,
			MedicationsAsStrings = c_,
		};
		var e_ = new Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY[]
		{
			d_,
		};
		IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> f_(Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY ClaimWithMedication)
		{
			var j_ = ClaimWithMedication?.PharmacyClaim;
			Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC k_(Claim Pharmacy)
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
						var ae_ = context.Operators.InList<string>(ac_, ad_);

						return ae_;
					};
					var aa_ = context.Operators.WhereOrNull<CqlCode>((y_ as IEnumerable<CqlCode>), z_);
					var ab_ = context.Operators.ExistsInList<CqlCode>(aa_);

					return ab_;
				};
				var q_ = context.Operators.WhereOrNull<Claim.ItemComponent>((o_ as IEnumerable<Claim.ItemComponent>), p_);
				var r_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = Pharmacy,
					LineItems = q_,
				};
				var s_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					r_,
				};
				Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC t_(Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition)
				{
					var af_ = LineItemDefinition?.Claim;
					var ag_ = new Claim[]
					{
						af_,
					};
					Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC ah_(Claim ClaimLines)
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
								var bc_ = context.Operators.InList<string>(ba_, bb_);

								return bc_;
							};
							var ay_ = context.Operators.WhereOrNull<CqlCode>((aw_ as IEnumerable<CqlCode>), ax_);
							var az_ = context.Operators.ExistsInList<CqlCode>(ay_);

							return az_;
						};
						var am_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ak_ as IEnumerable<Claim.ItemComponent>), al_);
						Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP an_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDateTime> bd_()
							{
								if ((context.Operators.Not((bool?)(i?.Quantity is null)) ?? false))
								{
									CqlInterval<CqlDateTime> bf_()
									{
										if (i?.Serviced is Period)
										{
											var bg_ = i?.Serviced;
											var bh_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bg_);
											var bi_ = context.Operators.Start(bh_);
											var bk_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bg_);
											var bl_ = context.Operators.Start(bk_);
											var bm_ = context.Operators.Add(bl_, new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement), "day"));
											var bn_ = context.Operators.Quantity(1m, "day");
											var bo_ = context.Operators.Subtract(bm_, bn_);
											var bp_ = context.Operators.Interval(bi_, bo_, true, true);

											return bp_;
										}
										else
										{
											var bq_ = i?.Serviced;
											var br_ = FHIRHelpers_4_0_001.ToDate((bq_ as Date));
											var bt_ = FHIRHelpers_4_0_001.ToDate((bq_ as Date));
											var bu_ = context.Operators.Add(bt_, new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement), "day"));
											var bv_ = context.Operators.Quantity(1m, "day");
											var bw_ = context.Operators.Subtract(bu_, bv_);
											var bx_ = context.Operators.Interval(br_, bw_, true, true);
											var by_ = bx_?.low;
											var bz_ = context.Operators.ConvertDateToDateTime(by_);
											var cb_ = FHIRHelpers_4_0_001.ToDate((bq_ as Date));
											var cd_ = FHIRHelpers_4_0_001.ToDate((bq_ as Date));
											var ce_ = context.Operators.Add(cd_, new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement), "day"));
											var cg_ = context.Operators.Subtract(ce_, bv_);
											var ch_ = context.Operators.Interval(cb_, cg_, true, true);
											var ci_ = ch_?.high;
											var cj_ = context.Operators.ConvertDateToDateTime(ci_);
											var cl_ = FHIRHelpers_4_0_001.ToDate((bq_ as Date));
											var cn_ = FHIRHelpers_4_0_001.ToDate((bq_ as Date));
											var co_ = context.Operators.Add(cn_, new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement), "day"));
											var cq_ = context.Operators.Subtract(co_, bv_);
											var cr_ = context.Operators.Interval(cl_, cq_, true, true);
											var cs_ = cr_?.lowClosed;
											var cu_ = FHIRHelpers_4_0_001.ToDate((bq_ as Date));
											var cw_ = FHIRHelpers_4_0_001.ToDate((bq_ as Date));
											var cx_ = context.Operators.Add(cw_, new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement), "day"));
											var cz_ = context.Operators.Subtract(cx_, bv_);
											var da_ = context.Operators.Interval(cu_, cz_, true, true);
											var db_ = da_?.highClosed;
											var dc_ = context.Operators.Interval(bz_, cj_, cs_, db_);

											return dc_;
										};
									};

									return bf_();
								}
								else
								{
									CqlInterval<CqlDateTime> dd_ = null;

									return (dd_ as CqlInterval<CqlDateTime>);
								};
							};
							var be_ = new Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP
							{
								DaysSupplyInterval = bd_(),
							};

							return be_;
						};
						var ao_ = context.Operators.SelectOrNull<Claim.ItemComponent, Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP>(am_, an_);
						var ap_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU
						{
							CoveredDays = ao_,
						};
						var aq_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU[]
						{
							ap_,
						};
						Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC ar_(Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU ItemCalculation)
						{
							Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC de_()
							{
								if ((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
								{
									var df_ = LineItemDefinition?.Claim;
									var dg_ = LineItemDefinition?.LineItems;
									bool? di_(Claim.ItemComponent @this)
									{
										var ds_ = @this?.Serviced;
										var dt_ = context.Operators.Not((bool?)(ds_ is null));

										return dt_;
									};
									var dj_ = context.Operators.WhereOrNull<Claim.ItemComponent>(dg_, di_);
									DataType dk_(Claim.ItemComponent @this)
									{
										var du_ = @this?.Serviced;

										return du_;
									};
									var dl_ = context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(dj_, dk_);
									CqlInterval<CqlDateTime> dm_(DataType NormalDate)
									{
										var dv_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

										return dv_;
									};
									var dn_ = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(dl_, dm_);
									var do_ = ItemCalculation?.CoveredDays;
									CqlInterval<CqlDateTime> dp_(Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP d)
									{
										var dw_ = d?.DaysSupplyInterval;

										return dw_;
									};
									var dq_ = context.Operators.SelectOrNull<Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP, CqlInterval<CqlDateTime>>(do_, dp_);
									var dr_ = new Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC
									{
										Claim = df_,
										LineItem = dg_,
										ServicePeriod = dn_,
										CoveredDays = dq_,
									};

									return dr_;
								}
								else
								{
									Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC dx_ = null;

									return (dx_ as Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC);
								};
							};

							return de_();
						};
						var as_ = context.Operators.SelectOrNull<Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(aq_, ar_);
						var at_ = context.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(as_);

						return at_;
					};
					var ai_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ag_, ah_);
					var aj_ = context.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ai_);

					return aj_;
				};
				var u_ = context.Operators.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(s_, t_);
				var v_ = context.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(u_);

				return v_;
			};
			var l_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(j_, k_);
			bool? m_(Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC FinalList)
			{
				var dy_ = context.Operators.Not((bool?)(FinalList is null));

				return dy_;
			};
			var n_ = context.Operators.WhereOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(l_, m_);

			return n_;
		};
		var g_ = context.Operators.SelectOrNull<Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY, IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(e_, f_);
		var h_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis and Procedure")]
	public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var k_ = d?.code;

			return k_;
		};
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p)
		{
			var l_ = p?.code;

			return l_;
		};
		var e_ = context.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, d_);
		var f_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
			ProceduresAsStrings = e_,
		};
		var g_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
		{
			f_,
		};
		IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> h_(Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithDiagnosis)
		{
			IEnumerable<Claim> m_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					IEnumerable<Claim> s_ = null;

					return (s_ as IEnumerable<Claim>);
				}
				else
				{
					var t_ = ClaimWithDiagnosis?.MedicalClaim;
					bool? u_(Claim DiagnosisLine)
					{
						var w_ = DiagnosisLine?.Diagnosis;
						bool? x_(Claim.DiagnosisComponent @this)
						{
							var al_ = @this?.Diagnosis;
							var am_ = context.Operators.Not((bool?)(al_ is null));

							return am_;
						};
						var y_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((w_ as IEnumerable<Claim.DiagnosisComponent>), x_);
						DataType z_(Claim.DiagnosisComponent @this)
						{
							var an_ = @this?.Diagnosis;

							return an_;
						};
						var aa_ = context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(y_, z_);
						bool? ab_(DataType @this)
						{
							var ao_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							var ap_ = context.Operators.Not((bool?)(ao_ is null));

							return ap_;
						};
						var ac_ = context.Operators.WhereOrNull<DataType>(aa_, ab_);
						object ad_(DataType @this)
						{
							var aq_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return aq_;
						};
						var ae_ = context.Operators.SelectOrNull<DataType, object>(ac_, ad_);
						var af_ = context.Operators.FlattenLateBoundList(ae_);
						Coding ag_(object @object) => 
							(@object as Coding);
						var ah_ = context.Operators.SelectOrNull<object, Coding>(af_, ag_);
						bool? ai_(Coding HeaderCode)
						{
							var ar_ = HeaderCode?.CodeElement;
							var as_ = ar_?.Value;
							var at_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
							var au_ = context.Operators.InList<string>(as_, at_);

							return au_;
						};
						var aj_ = context.Operators.WhereOrNull<Coding>(ah_, ai_);
						var ak_ = context.Operators.ExistsInList<Coding>(aj_);

						return ak_;
					};
					var v_ = context.Operators.WhereOrNull<Claim>(t_, u_);

					return v_;
				};
			};
			var n_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = m_(),
			};
			var o_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				n_,
			};
			IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> p_(Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg ClaimWithProcedure)
			{
				var av_ = ClaimWithProcedure?.DiagnosisItems;
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA aw_(Claim ClaimofInterest)
				{
					Claim ba_()
					{
						if ((ClaimofInterest is null))
						{
							return null;
						}
						else
						{
							var bg_ = new Claim[]
							{
								ClaimofInterest,
							};
							bool? bh_(Claim ItemOnLine)
							{
								var bk_ = ItemOnLine?.Procedure;
								bool? bl_(Claim.ProcedureComponent @this)
								{
									var cn_ = @this?.Procedure;
									var co_ = context.Operators.Not((bool?)(cn_ is null));

									return co_;
								};
								var bm_ = context.Operators.WhereOrNull<Claim.ProcedureComponent>((bk_ as IEnumerable<Claim.ProcedureComponent>), bl_);
								DataType bn_(Claim.ProcedureComponent @this)
								{
									var cp_ = @this?.Procedure;

									return cp_;
								};
								var bo_ = context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(bm_, bn_);
								bool? bp_(DataType @this)
								{
									var cq_ = context.Operators.LateBoundProperty<object>(@this, "coding");
									var cr_ = context.Operators.Not((bool?)(cq_ is null));

									return cr_;
								};
								var bq_ = context.Operators.WhereOrNull<DataType>(bo_, bp_);
								object br_(DataType @this)
								{
									var cs_ = context.Operators.LateBoundProperty<object>(@this, "coding");

									return cs_;
								};
								var bs_ = context.Operators.SelectOrNull<DataType, object>(bq_, br_);
								var bt_ = context.Operators.FlattenLateBoundList(bs_);
								Coding bu_(object @object) => 
									(@object as Coding);
								var bv_ = context.Operators.SelectOrNull<object, Coding>(bt_, bu_);
								bool? bw_(Coding ProcedureHeaderCode)
								{
									var ct_ = ProcedureHeaderCode?.CodeElement;
									var cu_ = ct_?.Value;
									var cv_ = ClaimWithDiagnosis?.ProceduresAsStrings;
									var cw_ = context.Operators.InList<string>(cu_, cv_);

									return cw_;
								};
								var bx_ = context.Operators.WhereOrNull<Coding>(bv_, bw_);
								var by_ = context.Operators.ExistsInList<Coding>(bx_);
								var bz_ = ItemOnLine?.Item;
								bool? ca_(Claim.ItemComponent @this)
								{
									var cx_ = @this?.ProductOrService;
									var cy_ = context.Operators.Not((bool?)(cx_ is null));

									return cy_;
								};
								var cb_ = context.Operators.WhereOrNull<Claim.ItemComponent>((bz_ as IEnumerable<Claim.ItemComponent>), ca_);
								CodeableConcept cc_(Claim.ItemComponent @this)
								{
									var cz_ = @this?.ProductOrService;

									return cz_;
								};
								var cd_ = context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(cb_, cc_);
								bool? ce_(CodeableConcept @this)
								{
									var da_ = @this?.Coding;
									var db_ = context.Operators.Not((bool?)(da_ is null));

									return db_;
								};
								var cf_ = context.Operators.WhereOrNull<CodeableConcept>(cd_, ce_);
								List<Coding> cg_(CodeableConcept @this)
								{
									var dc_ = @this?.Coding;

									return dc_;
								};
								var ch_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(cf_, cg_);
								var ci_ = context.Operators.FlattenList<Coding>(ch_);
								bool? cj_(Coding LineCode)
								{
									var dd_ = LineCode?.CodeElement;
									var de_ = dd_?.Value;
									var df_ = ClaimWithDiagnosis?.ProceduresAsStrings;
									var dg_ = context.Operators.InList<string>(de_, df_);

									return dg_;
								};
								var ck_ = context.Operators.WhereOrNull<Coding>(ci_, cj_);
								var cl_ = context.Operators.ExistsInList<Coding>(ck_);
								var cm_ = context.Operators.Or(by_, cl_);

								return cm_;
							};
							var bi_ = context.Operators.WhereOrNull<Claim>(bg_, bh_);
							var bj_ = context.Operators.SingleOrNull<Claim>(bi_);

							return bj_;
						};
					};
					var bb_ = new Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU
					{
						ProcedureItems = ba_(),
					};
					var bc_ = new Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU[]
					{
						bb_,
					};
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bd_(Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU HeaderDefinition)
					{
						Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA dh_()
						{
							if ((context.Operators.Not((bool?)(HeaderDefinition?.ProcedureItems is null)) ?? false))
							{
								var di_ = HeaderDefinition?.ProcedureItems;
								var dk_ = di_?.Item;
								CqlInterval<CqlDateTime> dl_(Claim.ItemComponent NormalDate)
								{
									var do_ = NormalDate?.Serviced;
									var dp_ = NCQAFHIRBase_1_0_0.Normalize_Interval(do_);

									return dp_;
								};
								var dm_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((dk_ as IEnumerable<Claim.ItemComponent>), dl_);
								var dn_ = new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
								{
									Claim = di_,
									ServicePeriod = dm_,
								};

								return dn_;
							}
							else
							{
								Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA dq_ = null;

								return (dq_ as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
							};
						};

						return dh_();
					};
					var be_ = context.Operators.SelectOrNull<Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bc_, bd_);
					var bf_ = context.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(be_);

					return bf_;
				};
				var ax_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(av_, aw_);
				bool? ay_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
				{
					var dr_ = context.Operators.Not((bool?)(FinalList is null));

					return dr_;
				};
				var az_ = context.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ax_, ay_);

				return az_;
			};
			var q_ = context.Operators.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(o_, p_);
			var r_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(q_);

			return r_;
		};
		var i_ = context.Operators.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);
		var j_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis and Procedure")]
	public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Principal_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var k_ = d?.code;

			return k_;
		};
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p)
		{
			var l_ = p?.code;

			return l_;
		};
		var e_ = context.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, d_);
		var f_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
			ProceduresAsStrings = e_,
		};
		var g_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
		{
			f_,
		};
		IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> h_(Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithProcedure)
		{
			var m_ = ClaimWithProcedure?.MedicalClaim;
			Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA n_(Claim ClaimofInterest)
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
							var ad_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ab_ as IEnumerable<Claim.ItemComponent>), ac_);
							CodeableConcept ae_(Claim.ItemComponent @this)
							{
								var bg_ = @this?.ProductOrService;

								return bg_;
							};
							var af_ = context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(ad_, ae_);
							bool? ag_(CodeableConcept @this)
							{
								var bh_ = @this?.Coding;
								var bi_ = context.Operators.Not((bool?)(bh_ is null));

								return bi_;
							};
							var ah_ = context.Operators.WhereOrNull<CodeableConcept>(af_, ag_);
							List<Coding> ai_(CodeableConcept @this)
							{
								var bj_ = @this?.Coding;

								return bj_;
							};
							var aj_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(ah_, ai_);
							var ak_ = context.Operators.FlattenList<Coding>(aj_);
							bool? al_(Coding LineCode)
							{
								var bk_ = LineCode?.CodeElement;
								var bl_ = bk_?.Value;
								var bm_ = ClaimWithProcedure?.ProceduresAsStrings;
								var bn_ = context.Operators.InList<string>(bl_, bm_);

								return bn_;
							};
							var am_ = context.Operators.WhereOrNull<Coding>(ak_, al_);
							var an_ = context.Operators.ExistsInList<Coding>(am_);
							var ao_ = ItemOnLine?.Procedure;
							bool? ap_(Claim.ProcedureComponent @this)
							{
								var bo_ = @this?.Procedure;
								var bp_ = context.Operators.Not((bool?)(bo_ is null));

								return bp_;
							};
							var aq_ = context.Operators.WhereOrNull<Claim.ProcedureComponent>((ao_ as IEnumerable<Claim.ProcedureComponent>), ap_);
							DataType ar_(Claim.ProcedureComponent @this)
							{
								var bq_ = @this?.Procedure;

								return bq_;
							};
							var as_ = context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(aq_, ar_);
							bool? at_(DataType @this)
							{
								var br_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								var bs_ = context.Operators.Not((bool?)(br_ is null));

								return bs_;
							};
							var au_ = context.Operators.WhereOrNull<DataType>(as_, at_);
							object av_(DataType @this)
							{
								var bt_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return bt_;
							};
							var aw_ = context.Operators.SelectOrNull<DataType, object>(au_, av_);
							var ax_ = context.Operators.FlattenLateBoundList(aw_);
							Coding ay_(object @object) => 
								(@object as Coding);
							var az_ = context.Operators.SelectOrNull<object, Coding>(ax_, ay_);
							bool? ba_(Coding HeaderCode)
							{
								var bu_ = HeaderCode?.CodeElement;
								var bv_ = bu_?.Value;
								var bw_ = ClaimWithProcedure?.ProceduresAsStrings;
								var bx_ = context.Operators.InList<string>(bv_, bw_);

								return bx_;
							};
							var bb_ = context.Operators.WhereOrNull<Coding>(az_, ba_);
							var bc_ = context.Operators.ExistsInList<Coding>(bb_);
							var bd_ = context.Operators.Or(an_, bc_);

							return bd_;
						};
						var z_ = context.Operators.WhereOrNull<Claim>(x_, y_);
						var aa_ = context.Operators.SingleOrNull<Claim>(z_);

						return aa_;
					};
				};
				var s_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB
				{
					Claim = ClaimofInterest,
					ProcedureItems = r_(),
				};
				var t_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB[]
				{
					s_,
				};
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA u_(Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB DiagnosisCheck)
				{
					var by_ = DiagnosisCheck?.ProcedureItems;
					var bz_ = new Claim[]
					{
						by_,
					};
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ca_(Claim ClaimforDiagnosis)
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
										var cv_ = context.Operators.Equal(cu_, (int?)1);
										var cw_ = RightDiagnosis?.Diagnosis;
										var cx_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(cw_, "coding");
										bool? cy_(Coding DiagnosisCode)
										{
											var dc_ = DiagnosisCode?.CodeElement;
											var dd_ = dc_?.Value;
											var de_ = ClaimWithProcedure?.DiagnosesAsStrings;
											var df_ = context.Operators.InList<string>(dd_, de_);

											return df_;
										};
										var cz_ = context.Operators.WhereOrNull<Coding>(cx_, cy_);
										var da_ = context.Operators.ExistsInList<Coding>(cz_);
										var db_ = context.Operators.And(cv_, da_);

										return db_;
									};
									var cq_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((co_ as IEnumerable<Claim.DiagnosisComponent>), cp_);
									var cr_ = context.Operators.ExistsInList<Claim.DiagnosisComponent>(cq_);

									return cr_;
								};
								var cm_ = context.Operators.WhereOrNull<Claim>(ck_, cl_);
								var cn_ = context.Operators.SingleOrNull<Claim>(cm_);

								return cn_;
							};
						};
						var cf_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI
						{
							Procedure = (cd_ as IEnumerable<Claim.ItemComponent>),
							LineItems = ce_(),
						};
						var cg_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI[]
						{
							cf_,
						};
						Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ch_(Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI LineItemDefinition)
						{
							Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA dg_()
							{
								if ((context.Operators.And(context.Operators.Not((bool?)(LineItemDefinition is null)), context.Operators.Not((bool?)(LineItemDefinition?.LineItems is null))) ?? false))
								{
									var dh_ = LineItemDefinition?.LineItems;
									var dj_ = dh_?.Item;
									CqlInterval<CqlDateTime> dk_(Claim.ItemComponent NormalDate)
									{
										var dn_ = NormalDate?.Serviced;
										var do_ = NCQAFHIRBase_1_0_0.Normalize_Interval(dn_);

										return do_;
									};
									var dl_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((dj_ as IEnumerable<Claim.ItemComponent>), dk_);
									var dm_ = new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
									{
										Claim = dh_,
										ServicePeriod = dl_,
									};

									return dm_;
								}
								else
								{
									Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA dp_ = null;

									return (dp_ as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
								};
							};

							return dg_();
						};
						var ci_ = context.Operators.SelectOrNull<Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(cg_, ch_);
						var cj_ = context.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ci_);

						return cj_;
					};
					var cb_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bz_, ca_);
					var cc_ = context.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(cb_);

					return cc_;
				};
				var v_ = context.Operators.SelectOrNull<Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(t_, u_);
				var w_ = context.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(v_);

				return w_;
			};
			var o_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(m_, n_);
			bool? p_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var dq_ = context.Operators.Not((bool?)(FinalList is null));

				return dq_;
			};
			var q_ = context.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(o_, p_);

			return q_;
		};
		var i_ = context.Operators.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);
		var j_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis")]
	public IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> Medical_Claims_With_Principal_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var i_ = d?.code;

			return i_;
		};
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		var d_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
		};
		var e_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			d_,
		};
		IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> f_(Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis)
		{
			IEnumerable<Claim> j_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					IEnumerable<Claim> p_ = null;

					return (p_ as IEnumerable<Claim>);
				}
				else
				{
					var q_ = ClaimWithDiagnosis?.MedicalClaim;
					bool? r_(Claim RightClaim)
					{
						var t_ = RightClaim?.Diagnosis;
						bool? u_(Claim.DiagnosisComponent RightDiagnosis)
						{
							var x_ = RightDiagnosis?.SequenceElement;
							var y_ = context.Operators.Convert<Integer>(x_);
							var z_ = FHIRHelpers_4_0_001.ToInteger(y_);
							var aa_ = context.Operators.Equal(z_, (int?)1);
							var ab_ = RightDiagnosis?.Diagnosis;
							var ac_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(ab_, "coding");
							bool? ad_(Coding DiagnosisCode)
							{
								var ah_ = DiagnosisCode?.CodeElement;
								var ai_ = ah_?.Value;
								var aj_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
								var ak_ = context.Operators.InList<string>(ai_, aj_);

								return ak_;
							};
							var ae_ = context.Operators.WhereOrNull<Coding>(ac_, ad_);
							var af_ = context.Operators.ExistsInList<Coding>(ae_);
							var ag_ = context.Operators.And(aa_, af_);

							return ag_;
						};
						var v_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((t_ as IEnumerable<Claim.DiagnosisComponent>), u_);
						var w_ = context.Operators.ExistsInList<Claim.DiagnosisComponent>(v_);

						return w_;
					};
					var s_ = context.Operators.WhereOrNull<Claim>(q_, r_);

					return s_;
				};
			};
			var k_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN
			{
				LineItems = j_(),
			};
			var l_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN[]
			{
				k_,
			};
			IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> m_(Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN LineItemDefinition)
			{
				var al_ = LineItemDefinition?.LineItems;
				Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI am_(Claim ClaimWithDiagnosis)
				{
					Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI aq_()
					{
						if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null)) ?? false))
						{
							var ar_ = LineItemDefinition?.LineItems;
							bool? at_(Claim @this)
							{
								var bb_ = @this?.Item;
								var bc_ = context.Operators.Not((bool?)(bb_ is null));

								return bc_;
							};
							var au_ = context.Operators.WhereOrNull<Claim>(ar_, at_);
							List<Claim.ItemComponent> av_(Claim @this)
							{
								var bd_ = @this?.Item;

								return bd_;
							};
							var aw_ = context.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(au_, av_);
							var ax_ = context.Operators.FlattenList<Claim.ItemComponent>(aw_);
							CqlInterval<CqlDateTime> ay_(Claim.ItemComponent NormalDate)
							{
								var be_ = NormalDate?.Serviced;
								var bf_ = NCQAFHIRBase_1_0_0.Normalize_Interval(be_);

								return bf_;
							};
							var az_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(ax_, ay_);
							var ba_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
							{
								Claim = ar_,
								ServicePeriod = az_,
							};

							return ba_;
						}
						else
						{
							Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI bg_ = null;

							return (bg_ as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI);
						};
					};

					return aq_();
				};
				var an_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(al_, am_);
				bool? ao_(Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList)
				{
					var bh_ = context.Operators.Not((bool?)(FinalList is null));

					return bh_;
				};
				var ap_ = context.Operators.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(an_, ao_);

				return ap_;
			};
			var n_ = context.Operators.SelectOrNull<Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(l_, m_);
			var o_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(n_);

			return o_;
		};
		var g_ = context.Operators.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(e_, f_);
		var h_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(g_);

		return h_;
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
		bool? a_(ClaimResponse ResponseItem)
		{
			var h_ = ResponseItem?.OutcomeElement;
			var i_ = context.Operators.Convert<string>(h_);
			var j_ = new string[]
			{
				"complete",
				"partial",
			};
			var k_ = context.Operators.InList<string>(i_, (j_ as IEnumerable<string>));

			return k_;
		};
		var b_ = context.Operators.WhereOrNull<ClaimResponse>(claimResponse, a_);
		var c_ = new Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD
		{
			PaidResponse = b_,
		};
		var d_ = new Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD[]
		{
			c_,
		};
		IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> e_(Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD ClaimResponse)
		{
			var l_ = ClaimResponse?.PaidResponse;
			Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL m_(ClaimResponse ClmResp)
			{
				var o_ = ClmResp?.Request;
				var p_ = o_?.ReferenceElement;
				var q_ = context.Operators.Convert<string>(p_);
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
					var y_ = context.Operators.WhereOrNull<ClaimResponse.AdjudicationComponent>(w_, x_);
					CodeableConcept z_(ClaimResponse.AdjudicationComponent @this)
					{
						var au_ = @this?.Category;

						return au_;
					};
					var aa_ = context.Operators.SelectOrNull<ClaimResponse.AdjudicationComponent, CodeableConcept>(y_, z_);
					bool? ab_(CodeableConcept @this)
					{
						var av_ = @this?.Coding;
						var aw_ = context.Operators.Not((bool?)(av_ is null));

						return aw_;
					};
					var ac_ = context.Operators.WhereOrNull<CodeableConcept>(aa_, ab_);
					List<Coding> ad_(CodeableConcept @this)
					{
						var ax_ = @this?.Coding;

						return ax_;
					};
					var ae_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(ac_, ad_);
					var af_ = context.Operators.FlattenList<Coding>(ae_);
					bool? ag_(Coding CategoryItem)
					{
						var ay_ = CategoryItem?.CodeElement;
						var az_ = ay_?.Value;
						var ba_ = context.Operators.Equal(az_, "benefit");

						return ba_;
					};
					var ah_ = context.Operators.WhereOrNull<Coding>(af_, ag_);
					var ai_ = context.Operators.ExistsInList<Coding>(ah_);
					bool? ak_(ClaimResponse.AdjudicationComponent @this)
					{
						var bb_ = @this?.Amount;
						var bc_ = context.Operators.Not((bool?)(bb_ is null));

						return bc_;
					};
					var al_ = context.Operators.WhereOrNull<ClaimResponse.AdjudicationComponent>(w_, ak_);
					Money am_(ClaimResponse.AdjudicationComponent @this)
					{
						var bd_ = @this?.Amount;

						return bd_;
					};
					var an_ = context.Operators.SelectOrNull<ClaimResponse.AdjudicationComponent, Money>(al_, am_);
					bool? ao_(Money DollarAmount)
					{
						var be_ = DollarAmount?.ValueElement;
						var bf_ = FHIRHelpers_4_0_001.ToDecimal(be_);
						var bg_ = context.Operators.ConvertIntegerToDecimal((int?)0);
						var bh_ = context.Operators.Greater(bf_, bg_);

						return bh_;
					};
					var ap_ = context.Operators.WhereOrNull<Money>(an_, ao_);
					var aq_ = context.Operators.ExistsInList<Money>(ap_);
					var ar_ = context.Operators.And(ai_, aq_);

					return ar_;
				};
				var u_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>((s_ as IEnumerable<ClaimResponse.ItemComponent>), t_);
				var v_ = new Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL
				{
					Response = ClmResp,
					ResponseID = r_,
					LineItems = u_,
				};

				return v_;
			};
			var n_ = context.Operators.SelectOrNull<ClaimResponse, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(l_, m_);

			return n_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD, IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(d_, e_);
		var g_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(f_);

		return g_;
	}

    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
	public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_and_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
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
			var g_ = context.Operators.WhereOrNull<Claim.ItemComponent>(e_, f_);
			CodeableConcept h_(Claim.ItemComponent @this)
			{
				var aj_ = @this?.ProductOrService;

				return aj_;
			};
			var i_ = context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(g_, h_);
			bool? j_(CodeableConcept @this)
			{
				var ak_ = @this?.Coding;
				var al_ = context.Operators.Not((bool?)(ak_ is null));

				return al_;
			};
			var k_ = context.Operators.WhereOrNull<CodeableConcept>(i_, j_);
			List<Coding> l_(CodeableConcept @this)
			{
				var am_ = @this?.Coding;

				return am_;
			};
			var m_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(k_, l_);
			var n_ = context.Operators.FlattenList<Coding>(m_);
			bool? o_(Coding ProductOrServiceCode)
			{
				var an_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var ao_ = context.Operators.CodeInList(an_, ProductOrServiceValueSet);

				return ao_;
			};
			var p_ = context.Operators.WhereOrNull<Coding>(n_, o_);
			var q_ = context.Operators.ExistsInList<Coding>(p_);
			var r_ = AllClaims?.Diagnosis;
			bool? s_(Claim.DiagnosisComponent @this)
			{
				var ap_ = @this?.Diagnosis;
				var aq_ = context.Operators.Not((bool?)(ap_ is null));

				return aq_;
			};
			var t_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((r_ as IEnumerable<Claim.DiagnosisComponent>), s_);
			DataType u_(Claim.DiagnosisComponent @this)
			{
				var ar_ = @this?.Diagnosis;

				return ar_;
			};
			var v_ = context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(t_, u_);
			bool? w_(DataType @this)
			{
				var as_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				var at_ = context.Operators.Not((bool?)(as_ is null));

				return at_;
			};
			var x_ = context.Operators.WhereOrNull<DataType>(v_, w_);
			object y_(DataType @this)
			{
				var au_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return au_;
			};
			var z_ = context.Operators.SelectOrNull<DataType, object>(x_, y_);
			var aa_ = context.Operators.FlattenLateBoundList(z_);
			Coding ab_(object @object) => 
				(@object as Coding);
			var ac_ = context.Operators.SelectOrNull<object, Coding>(aa_, ab_);
			bool? ad_(Coding DiagnosisCode)
			{
				var av_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
				var aw_ = context.Operators.CodeInList(av_, DiagnosisValueSet);

				return aw_;
			};
			var ae_ = context.Operators.WhereOrNull<Coding>(ac_, ad_);
			var af_ = context.Operators.ExistsInList<Coding>(ae_);
			var ag_ = context.Operators.And(q_, af_);

			return ag_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);
		Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM c_(Claim ProcedureClaims)
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
					var bi_ = context.Operators.CodeInList(bh_, ProductOrServiceValueSet);

					return bi_;
				};
				var bf_ = context.Operators.WhereOrNull<Coding>((bd_ as IEnumerable<Coding>), be_);
				var bg_ = context.Operators.ExistsInList<Coding>(bf_);

				return bg_;
			};
			var ba_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ay_ as IEnumerable<Claim.ItemComponent>), az_);
			var bb_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = ProcedureClaims,
				ClaimID = ax_,
				LineItems = ba_,
			};

			return bb_;
		};
		var d_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services and Conditions")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_and_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		var c_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = a_,
			MedicalClaim = b_,
		};
		var d_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			c_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO e_(Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse)
		{
			var h_ = ClaimAndResponse?.MedicalClaim;
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg i_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				var p_ = medClaim?.LineItems;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					var t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> u_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var x_ = pClaim?.LineItems;
						bool? y_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							Id ac_()
							{
								if (medClaim?.ClaimofInterest is Resource)
								{
									var aq_ = medClaim?.ClaimofInterest;

									return (aq_ as Resource).IdElement;
								}
								else
								{
									return null;
								};
							};
							var ad_ = context.Operators.Convert<string>(ac_());
							var ae_ = pClaim?.Response;
							var af_ = ae_?.Request;
							var ag_ = af_?.ReferenceElement;
							var ah_ = context.Operators.Convert<string>(ag_);
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
						var z_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>(x_, y_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var ab_ = context.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, aa_);

						return ab_;
					};
					var v_ = context.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(t_, u_);
					var w_ = context.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_);

					return w_;
				};
				var r_ = context.Operators.WhereOrNull<Claim.ItemComponent>(p_, q_);
				var s_ = new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = r_,
				};

				return s_;
			};
			var j_ = context.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(h_, i_);
			var k_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = j_,
			};
			var l_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				k_,
			};
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO m_(Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO ar_()
				{
					if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
											context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
										@this?.ClaimItem))) ?? false))
					{
						var aw_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? ax_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bk_ = @this?.PaidClaim;
							var bl_ = context.Operators.Not((bool?)(bk_ is null));

							return bl_;
						};
						var ay_ = context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(aw_, ax_);
						Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM az_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bm_ = @this?.PaidClaim;

							return bm_;
						};
						var ba_ = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(ay_, az_);
						bool? bc_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bn_ = @this?.ClaimItem;
							var bo_ = context.Operators.Not((bool?)(bn_ is null));

							return bo_;
						};
						var bd_ = context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(aw_, bc_);
						IEnumerable<Claim.ItemComponent> be_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bp_ = @this?.ClaimItem;

							return bp_;
						};
						var bf_ = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(bd_, be_);
						var bg_ = context.Operators.FlattenList<Claim.ItemComponent>(bf_);
						CqlInterval<CqlDateTime> bh_(Claim.ItemComponent PaidItem)
						{
							var bq_ = PaidItem?.Serviced;
							var br_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bq_);

							return br_;
						};
						var bi_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bg_, bh_);
						var bj_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = ba_,
							ServicePeriod = bi_,
						};

						return bj_;
					}
					else
					{
						Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO bs_ = null;

						return (bs_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
					};
				};
				var as_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ar_(),
				};
				bool? at_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bt_ = context.Operators.Not((bool?)(FinalList is null));

					return bt_;
				};
				var au_ = context.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(as_, at_);
				var av_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(au_);

				return av_;
			};
			var n_ = context.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(l_, m_);
			var o_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(n_);

			return o_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var g_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Service and Condition")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Service_and_Condition(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			a_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO c_(Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse)
		{
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO j_()
			{
				if ((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
				{
					Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO k_ = null;

					return (k_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
				}
				else
				{
					var l_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					var m_ = MedicalClaimAndResponse?.MedicalClaim;
					var n_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(l_, m_, ProductOrServiceValueSet, DiagnosisValueSet);

					return n_;
				};
			};

			return j_();
		};
		var d_ = context.Operators.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		var e_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);
		var f_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
		{
			e_,
		};
		bool? g_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
		{
			var o_ = context.Operators.Not((bool?)(FinalList is null));

			return o_;
		};
		var h_ = context.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_, g_);
		var i_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(h_);

		return i_;
	}

    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
	public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_or_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
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
			var g_ = context.Operators.WhereOrNull<Claim.ItemComponent>(e_, f_);
			CodeableConcept h_(Claim.ItemComponent @this)
			{
				var aj_ = @this?.ProductOrService;

				return aj_;
			};
			var i_ = context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(g_, h_);
			bool? j_(CodeableConcept @this)
			{
				var ak_ = @this?.Coding;
				var al_ = context.Operators.Not((bool?)(ak_ is null));

				return al_;
			};
			var k_ = context.Operators.WhereOrNull<CodeableConcept>(i_, j_);
			List<Coding> l_(CodeableConcept @this)
			{
				var am_ = @this?.Coding;

				return am_;
			};
			var m_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(k_, l_);
			var n_ = context.Operators.FlattenList<Coding>(m_);
			bool? o_(Coding ProductOrServiceCode)
			{
				var an_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var ao_ = context.Operators.CodeInList(an_, ProductOrServiceValueSet);

				return ao_;
			};
			var p_ = context.Operators.WhereOrNull<Coding>(n_, o_);
			var q_ = context.Operators.ExistsInList<Coding>(p_);
			var r_ = AllClaims?.Diagnosis;
			bool? s_(Claim.DiagnosisComponent @this)
			{
				var ap_ = @this?.Diagnosis;
				var aq_ = context.Operators.Not((bool?)(ap_ is null));

				return aq_;
			};
			var t_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((r_ as IEnumerable<Claim.DiagnosisComponent>), s_);
			DataType u_(Claim.DiagnosisComponent @this)
			{
				var ar_ = @this?.Diagnosis;

				return ar_;
			};
			var v_ = context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(t_, u_);
			bool? w_(DataType @this)
			{
				var as_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				var at_ = context.Operators.Not((bool?)(as_ is null));

				return at_;
			};
			var x_ = context.Operators.WhereOrNull<DataType>(v_, w_);
			object y_(DataType @this)
			{
				var au_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return au_;
			};
			var z_ = context.Operators.SelectOrNull<DataType, object>(x_, y_);
			var aa_ = context.Operators.FlattenLateBoundList(z_);
			Coding ab_(object @object) => 
				(@object as Coding);
			var ac_ = context.Operators.SelectOrNull<object, Coding>(aa_, ab_);
			bool? ad_(Coding DiagnosisCode)
			{
				var av_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
				var aw_ = context.Operators.CodeInList(av_, DiagnosisValueSet);

				return aw_;
			};
			var ae_ = context.Operators.WhereOrNull<Coding>(ac_, ad_);
			var af_ = context.Operators.ExistsInList<Coding>(ae_);
			var ag_ = context.Operators.Or(q_, af_);

			return ag_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);
		Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM c_(Claim ProcedureClaims)
		{
			Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM ax_()
			{
				if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => 
								context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), (Coding ProductOrServiceCode) => 
											context.Operators.CodeInList(FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode), ProductOrServiceValueSet))))) ?? false))
				{
					var ay_ = ProcedureClaims?.IdElement;
					var az_ = ProcedureClaims?.Item;
					bool? ba_(Claim.ItemComponent ResponseItem)
					{
						var bd_ = ResponseItem?.ProductOrService;
						var be_ = bd_?.Coding;
						bool? bf_(Coding ProductOrServiceCode)
						{
							var bi_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
							var bj_ = context.Operators.CodeInList(bi_, ProductOrServiceValueSet);

							return bj_;
						};
						var bg_ = context.Operators.WhereOrNull<Coding>((be_ as IEnumerable<Coding>), bf_);
						var bh_ = context.Operators.ExistsInList<Coding>(bg_);

						return bh_;
					};
					var bb_ = context.Operators.WhereOrNull<Claim.ItemComponent>((az_ as IEnumerable<Claim.ItemComponent>), ba_);
					var bc_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
					{
						ClaimofInterest = ProcedureClaims,
						ClaimID = ay_,
						LineItems = bb_,
					};

					return bc_;
				}
				else
				{
					var bk_ = ProcedureClaims?.IdElement;
					var bl_ = ProcedureClaims?.Item;
					bool? bm_(Claim.ItemComponent ResponseItem)
					{
						var bp_ = ResponseItem?.SequenceElement;
						var bq_ = context.Operators.Convert<Integer>(bp_);
						var br_ = bq_?.Value;
						var bs_ = context.Operators.Equal(br_, (int?)1);

						return bs_;
					};
					var bn_ = context.Operators.WhereOrNull<Claim.ItemComponent>((bl_ as IEnumerable<Claim.ItemComponent>), bm_);
					var bo_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
					{
						ClaimofInterest = ProcedureClaims,
						ClaimID = bk_,
						LineItems = bn_,
					};

					return bo_;
				};
			};

			return ax_();
		};
		var d_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services or Conditions")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		var c_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = a_,
			MedicalClaim = b_,
		};
		var d_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			c_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO e_(Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse)
		{
			var h_ = ClaimAndResponse?.MedicalClaim;
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg i_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				var p_ = medClaim?.LineItems;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					var t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> u_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var x_ = pClaim?.LineItems;
						bool? y_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							Id ac_()
							{
								if (medClaim?.ClaimofInterest is Resource)
								{
									var aq_ = medClaim?.ClaimofInterest;

									return (aq_ as Resource).IdElement;
								}
								else
								{
									return null;
								};
							};
							var ad_ = context.Operators.Convert<string>(ac_());
							var ae_ = pClaim?.Response;
							var af_ = ae_?.Request;
							var ag_ = af_?.ReferenceElement;
							var ah_ = context.Operators.Convert<string>(ag_);
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
						var z_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>(x_, y_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var ab_ = context.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, aa_);

						return ab_;
					};
					var v_ = context.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(t_, u_);
					var w_ = context.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_);

					return w_;
				};
				var r_ = context.Operators.WhereOrNull<Claim.ItemComponent>(p_, q_);
				var s_ = new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = r_,
				};

				return s_;
			};
			var j_ = context.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(h_, i_);
			var k_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = j_,
			};
			var l_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				k_,
			};
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO m_(Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO ar_()
				{
					if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
											context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
										@this?.ClaimItem))) ?? false))
					{
						var aw_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? ax_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bk_ = @this?.PaidClaim;
							var bl_ = context.Operators.Not((bool?)(bk_ is null));

							return bl_;
						};
						var ay_ = context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(aw_, ax_);
						Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM az_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bm_ = @this?.PaidClaim;

							return bm_;
						};
						var ba_ = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(ay_, az_);
						bool? bc_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bn_ = @this?.ClaimItem;
							var bo_ = context.Operators.Not((bool?)(bn_ is null));

							return bo_;
						};
						var bd_ = context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(aw_, bc_);
						IEnumerable<Claim.ItemComponent> be_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bp_ = @this?.ClaimItem;

							return bp_;
						};
						var bf_ = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(bd_, be_);
						var bg_ = context.Operators.FlattenList<Claim.ItemComponent>(bf_);
						CqlInterval<CqlDateTime> bh_(Claim.ItemComponent PaidItem)
						{
							var bq_ = PaidItem?.Serviced;
							var br_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bq_);

							return br_;
						};
						var bi_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bg_, bh_);
						var bj_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = ba_,
							ServicePeriod = bi_,
						};

						return bj_;
					}
					else
					{
						Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO bs_ = null;

						return (bs_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
					};
				};
				var as_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ar_(),
				};
				bool? at_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bt_ = context.Operators.Not((bool?)(FinalList is null));

					return bt_;
				};
				var au_ = context.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(as_, at_);
				var av_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(au_);

				return av_;
			};
			var n_ = context.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(l_, m_);
			var o_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(n_);

			return o_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var g_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services or Conditions")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			a_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO c_(Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse)
		{
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO f_()
			{
				if ((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
				{
					Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO g_ = null;

					return (g_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
				}
				else
				{
					var h_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					var i_ = MedicalClaimAndResponse?.MedicalClaim;
					var j_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(h_, i_, ProductOrServiceValueSet, DiagnosisValueSet);

					return j_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		var e_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);

		return e_;
	}

    [CqlDeclaration("Get All Claims With Procedure Only")]
	public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_Only(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
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
			var g_ = context.Operators.WhereOrNull<Claim.ItemComponent>(e_, f_);
			CodeableConcept h_(Claim.ItemComponent @this)
			{
				var t_ = @this?.ProductOrService;

				return t_;
			};
			var i_ = context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(g_, h_);
			bool? j_(CodeableConcept @this)
			{
				var u_ = @this?.Coding;
				var v_ = context.Operators.Not((bool?)(u_ is null));

				return v_;
			};
			var k_ = context.Operators.WhereOrNull<CodeableConcept>(i_, j_);
			List<Coding> l_(CodeableConcept @this)
			{
				var w_ = @this?.Coding;

				return w_;
			};
			var m_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(k_, l_);
			var n_ = context.Operators.FlattenList<Coding>(m_);
			bool? o_(Coding ProductOrServiceCode)
			{
				var x_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var y_ = context.Operators.CodeInList(x_, ProductOrServiceValueSet);

				return y_;
			};
			var p_ = context.Operators.WhereOrNull<Coding>(n_, o_);
			var q_ = context.Operators.ExistsInList<Coding>(p_);

			return q_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);
		Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM c_(Claim AllClaims)
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
					var ak_ = context.Operators.CodeInList(aj_, ProductOrServiceValueSet);

					return ak_;
				};
				var ah_ = context.Operators.WhereOrNull<Coding>((af_ as IEnumerable<Coding>), ag_);
				var ai_ = context.Operators.ExistsInList<Coding>(ah_);

				return ai_;
			};
			var ac_ = context.Operators.WhereOrNull<Claim.ItemComponent>((aa_ as IEnumerable<Claim.ItemComponent>), ab_);
			var ad_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = AllClaims,
				ClaimID = z_,
				LineItems = ac_,
			};

			return ad_;
		};
		var d_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services Only")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_Only(claim, ProductOrServiceValueSet);
		var c_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = a_,
			MedicalClaim = b_,
		};
		var d_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			c_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO e_(Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse)
		{
			var h_ = ClaimAndResponse?.MedicalClaim;
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg i_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				var p_ = medClaim?.LineItems;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					var t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> u_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var x_ = pClaim?.LineItems;
						bool? y_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							Id ac_()
							{
								if (medClaim?.ClaimofInterest is Resource)
								{
									var aq_ = medClaim?.ClaimofInterest;

									return (aq_ as Resource).IdElement;
								}
								else
								{
									return null;
								};
							};
							var ad_ = context.Operators.Convert<string>(ac_());
							var ae_ = pClaim?.Response;
							var af_ = ae_?.Request;
							var ag_ = af_?.ReferenceElement;
							var ah_ = context.Operators.Convert<string>(ag_);
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
						var z_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>(x_, y_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var ab_ = context.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, aa_);

						return ab_;
					};
					var v_ = context.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(t_, u_);
					var w_ = context.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_);

					return w_;
				};
				var r_ = context.Operators.WhereOrNull<Claim.ItemComponent>(p_, q_);
				var s_ = new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = r_,
				};

				return s_;
			};
			var j_ = context.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(h_, i_);
			var k_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = j_,
			};
			var l_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				k_,
			};
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO m_(Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO ar_()
				{
					if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
											context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
										@this?.ClaimItem))) ?? false))
					{
						var aw_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? ax_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bk_ = @this?.PaidClaim;
							var bl_ = context.Operators.Not((bool?)(bk_ is null));

							return bl_;
						};
						var ay_ = context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(aw_, ax_);
						Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM az_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bm_ = @this?.PaidClaim;

							return bm_;
						};
						var ba_ = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(ay_, az_);
						bool? bc_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bn_ = @this?.ClaimItem;
							var bo_ = context.Operators.Not((bool?)(bn_ is null));

							return bo_;
						};
						var bd_ = context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(aw_, bc_);
						IEnumerable<Claim.ItemComponent> be_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bp_ = @this?.ClaimItem;

							return bp_;
						};
						var bf_ = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(bd_, be_);
						var bg_ = context.Operators.FlattenList<Claim.ItemComponent>(bf_);
						CqlInterval<CqlDateTime> bh_(Claim.ItemComponent PaidItem)
						{
							var bq_ = PaidItem?.Serviced;
							var br_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bq_);

							return br_;
						};
						var bi_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bg_, bh_);
						var bj_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = ba_,
							ServicePeriod = bi_,
						};

						return bj_;
					}
					else
					{
						Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO bs_ = null;

						return (bs_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
					};
				};
				var as_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ar_(),
				};
				bool? at_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bt_ = context.Operators.Not((bool?)(FinalList is null));

					return bt_;
				};
				var au_ = context.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(as_, at_);
				var av_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(au_);

				return av_;
			};
			var n_ = context.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(l_, m_);
			var o_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(n_);

			return o_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var g_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services Only")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			a_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO c_(Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse)
		{
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO f_()
			{
				if ((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
				{
					Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO g_ = null;

					return (g_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
				}
				else
				{
					var h_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					var i_ = MedicalClaimAndResponse?.MedicalClaim;
					var j_ = this.Get_Corresponding_Claim_for_Services_Only(h_, i_, ProductOrServiceValueSet);

					return j_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		var e_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);

		return e_;
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
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Pharmacy_Claim_With_Medication(claim, ProductOrServiceValueSet);
		var c_ = new Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB
		{
			PaidPharmacyClaimResponse = a_,
			MedicalClaim = b_,
		};
		var d_ = new Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB[]
		{
			c_,
		};
		Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO e_(Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB ClaimAndResponse)
		{
			var h_ = ClaimAndResponse?.MedicalClaim;
			Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT i_(Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC medClaim)
			{
				var p_ = medClaim?.LineItem;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					var t_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> u_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var x_ = pClaim?.LineItems;
						bool? y_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							Id ac_()
							{
								if (medClaim?.Claim is Resource)
								{
									var aq_ = medClaim?.Claim;

									return (aq_ as Resource).IdElement;
								}
								else
								{
									return null;
								};
							};
							var ad_ = context.Operators.Convert<string>(ac_());
							var ae_ = pClaim?.Response;
							var af_ = ae_?.Request;
							var ag_ = af_?.ReferenceElement;
							var ah_ = context.Operators.Convert<string>(ag_);
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
						var z_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>(x_, y_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var ab_ = context.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, aa_);

						return ab_;
					};
					var v_ = context.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(t_, u_);
					var w_ = context.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_);

					return w_;
				};
				var r_ = context.Operators.WhereOrNull<Claim.ItemComponent>(p_, q_);
				var s_ = new Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT
				{
					PaidClaim = medClaim,
					ClaimItem = r_,
				};

				return s_;
			};
			var j_ = context.Operators.SelectOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC, Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(h_, i_);
			var k_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB
			{
				AggregateClaim = j_,
			};
			var l_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB[]
			{
				k_,
			};
			Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO m_(Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB ClaimWithPaidResponse)
			{
				Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO ar_()
				{
					if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => 
											context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => 
										@this?.ClaimItem))) ?? false))
					{
						var aw_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? ax_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var bs_ = @this?.PaidClaim;
							var bt_ = context.Operators.Not((bool?)(bs_ is null));

							return bt_;
						};
						var ay_ = context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(aw_, ax_);
						Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC az_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var bu_ = @this?.PaidClaim;

							return bu_;
						};
						var ba_ = context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ay_, az_);
						bool? bc_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var bv_ = @this?.ClaimItem;
							var bw_ = context.Operators.Not((bool?)(bv_ is null));

							return bw_;
						};
						var bd_ = context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(aw_, bc_);
						IEnumerable<Claim.ItemComponent> be_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var bx_ = @this?.ClaimItem;

							return bx_;
						};
						var bf_ = context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(bd_, be_);
						var bg_ = context.Operators.FlattenList<Claim.ItemComponent>(bf_);
						CqlInterval<CqlDateTime> bh_(Claim.ItemComponent PaidItem)
						{
							var by_ = PaidItem?.Serviced;
							var bz_ = NCQAFHIRBase_1_0_0.Normalize_Interval(by_);

							return bz_;
						};
						var bi_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bg_, bh_);
						bool? bk_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var ca_ = @this?.ClaimItem;
							var cb_ = context.Operators.Not((bool?)(ca_ is null));

							return cb_;
						};
						var bl_ = context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(aw_, bk_);
						IEnumerable<Claim.ItemComponent> bm_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var cc_ = @this?.ClaimItem;

							return cc_;
						};
						var bn_ = context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(bl_, bm_);
						var bo_ = context.Operators.FlattenList<Claim.ItemComponent>(bn_);
						CqlInterval<CqlDate> bp_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDate> cd_()
							{
								if ((context.Operators.Not((bool?)(i?.Quantity is null)) ?? false))
								{
									var ce_ = i?.Serviced;
									var cf_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ce_);
									var cg_ = context.Operators.Start(cf_);
									var ch_ = context.Operators.ConvertDateTimeToDate(cg_);
									var cj_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ce_);
									var ck_ = context.Operators.Start(cj_);
									var cl_ = context.Operators.Add(ck_, new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement), "day"));
									var cm_ = context.Operators.Quantity(1m, "day");
									var cn_ = context.Operators.Subtract(cl_, cm_);
									var co_ = context.Operators.ConvertDateTimeToDate(cn_);
									var cp_ = context.Operators.Interval(ch_, co_, true, true);

									return cp_;
								}
								else
								{
									CqlInterval<CqlDate> cq_ = null;

									return (cq_ as CqlInterval<CqlDate>);
								};
							};

							return cd_();
						};
						var bq_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDate>>(bo_, bp_);
						var br_ = new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO
						{
							originalClaim = ba_,
							ServicePeriod = bi_,
							CoveredDays = bq_,
						};

						return br_;
					}
					else
					{
						Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO cr_ = null;

						return (cr_ as Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO);
					};
				};
				var as_ = new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO[]
				{
					ar_(),
				};
				bool? at_(Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO FinalList)
				{
					var cs_ = context.Operators.Not((bool?)(FinalList is null));

					return cs_;
				};
				var au_ = context.Operators.WhereOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(as_, at_);
				var av_ = context.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(au_);

				return av_;
			};
			var n_ = context.Operators.SelectOrNull<Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(l_, m_);
			var o_ = context.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(n_);

			return o_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(d_, e_);
		var g_ = context.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Pharmacy Services")]
	public Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO Get_Paid_Claims_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR[]
		{
			a_,
		};
		Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO c_(Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR PharmacyClaimAndResponse)
		{
			Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO f_()
			{
				if ((context.Operators.And((bool?)(PharmacyClaimAndResponse?.PharmacyClaimResponse is null), (bool?)(PharmacyClaimAndResponse?.PharmacyClaim is null)) ?? false))
				{
					Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO g_ = null;

					return (g_ as Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO);
				}
				else
				{
					var h_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
					var i_ = PharmacyClaimAndResponse?.PharmacyClaim;
					var j_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(h_, i_, ProductOrServiceValueSet);

					return j_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(b_, c_);
		var e_ = context.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(d_);

		return e_;
	}

    [CqlDeclaration("Get Claim With Corresponding Claim Response")]
	public IEnumerable<Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI> Get_Claim_With_Corresponding_Claim_Response(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI a_(Claim Claim)
		{
			bool? c_(ClaimResponse CR)
			{
				var h_ = Claim?.IdElement;
				var i_ = context.Operators.Convert<string>(h_);
				var j_ = CR?.Request;
				var k_ = j_?.ReferenceElement;
				var l_ = context.Operators.Convert<string>(k_);
				var m_ = NCQAFHIRBase_1_0_0.GetId(l_);
				var n_ = context.Operators.Equal(i_, m_);

				return n_;
			};
			var d_ = context.Operators.WhereOrNull<ClaimResponse>(claimResponse, c_);
			bool? e_(Claim C)
			{
				var o_ = Claim?.IdElement;
				var p_ = context.Operators.Convert<string>(o_);
				bool? q_(ClaimResponse CR)
				{
					var ae_ = Claim?.IdElement;
					var af_ = context.Operators.Convert<string>(ae_);
					var ag_ = CR?.Request;
					var ah_ = ag_?.ReferenceElement;
					var ai_ = context.Operators.Convert<string>(ah_);
					var aj_ = NCQAFHIRBase_1_0_0.GetId(ai_);
					var ak_ = context.Operators.Equal(af_, aj_);

					return ak_;
				};
				var r_ = context.Operators.WhereOrNull<ClaimResponse>(claimResponse, q_);
				bool? s_(ClaimResponse @this)
				{
					var al_ = @this?.Request;
					var am_ = context.Operators.Not((bool?)(al_ is null));

					return am_;
				};
				var t_ = context.Operators.WhereOrNull<ClaimResponse>(r_, s_);
				ResourceReference u_(ClaimResponse @this)
				{
					var an_ = @this?.Request;

					return an_;
				};
				var v_ = context.Operators.SelectOrNull<ClaimResponse, ResourceReference>(t_, u_);
				bool? w_(ResourceReference @this)
				{
					var ao_ = @this?.ReferenceElement;
					var ap_ = context.Operators.Not((bool?)(ao_ is null));

					return ap_;
				};
				var x_ = context.Operators.WhereOrNull<ResourceReference>(v_, w_);
				FhirString y_(ResourceReference @this)
				{
					var aq_ = @this?.ReferenceElement;

					return aq_;
				};
				var z_ = context.Operators.SelectOrNull<ResourceReference, FhirString>(x_, y_);
				var aa_ = context.Operators.SingleOrNull<FhirString>(z_);
				var ab_ = context.Operators.Convert<string>(aa_);
				var ac_ = NCQAFHIRBase_1_0_0.GetId(ab_);
				var ad_ = context.Operators.Equal(p_, ac_);

				return ad_;
			};
			var f_ = context.Operators.WhereOrNull<Claim>(claim, e_);
			var g_ = new Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI
			{
				ClaimResponse = d_,
				OriginalClaim = f_,
			};

			return g_;
		};
		var b_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Medical Claims With Nonacute or Acute Inpatient Discharge")]
	public Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(IEnumerable<Claim> claim)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		var b_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = a_,
		};
		var c_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			b_,
		};
		Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE d_(Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithInpatientStay)
		{
			IEnumerable<Claim> g_()
			{
				if ((ClaimWithInpatientStay?.MedicalClaim is null))
				{
					IEnumerable<Claim> n_ = null;

					return (n_ as IEnumerable<Claim>);
				}
				else
				{
					var o_ = ClaimWithInpatientStay?.MedicalClaim;
					bool? p_(Claim c)
					{
						var r_ = c?.Item;
						bool? s_(Claim.ItemComponent i)
						{
							var v_ = i?.Revenue;
							var w_ = FHIRHelpers_4_0_001.ToConcept(v_);
							var x_ = w_?.codes;
							bool? y_(CqlCode rev)
							{
								var ab_ = rev?.code;
								var ac_ = this.Inpatient_Stay();
								var ad_ = context.Operators.StringInValueSet(ab_, ac_);

								return ad_;
							};
							var z_ = context.Operators.WhereOrNull<CqlCode>((x_ as IEnumerable<CqlCode>), y_);
							var aa_ = context.Operators.ExistsInList<CqlCode>(z_);

							return aa_;
						};
						var t_ = context.Operators.WhereOrNull<Claim.ItemComponent>((r_ as IEnumerable<Claim.ItemComponent>), s_);
						var u_ = context.Operators.ExistsInList<Claim.ItemComponent>(t_);

						return u_;
					};
					var q_ = context.Operators.WhereOrNull<Claim>(o_, p_);

					return q_;
				};
			};
			IEnumerable<Claim> h_()
			{
				if ((ClaimWithInpatientStay?.MedicalClaim is null))
				{
					IEnumerable<Claim> ae_ = null;

					return (ae_ as IEnumerable<Claim>);
				}
				else
				{
					var af_ = ClaimWithInpatientStay?.MedicalClaim;
					bool? ag_(Claim c)
					{
						var ai_ = c?.Item;
						bool? aj_(Claim.ItemComponent i)
						{
							var as_ = i?.Revenue;
							var at_ = FHIRHelpers_4_0_001.ToConcept(as_);
							var au_ = at_?.codes;
							bool? av_(CqlCode rev)
							{
								var ay_ = rev?.code;
								var az_ = this.Nonacute_Inpatient_Stay();
								var ba_ = context.Operators.StringInValueSet(ay_, az_);

								return ba_;
							};
							var aw_ = context.Operators.WhereOrNull<CqlCode>((au_ as IEnumerable<CqlCode>), av_);
							var ax_ = context.Operators.ExistsInList<CqlCode>(aw_);

							return ax_;
						};
						var ak_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ai_ as IEnumerable<Claim.ItemComponent>), aj_);
						var al_ = context.Operators.ExistsInList<Claim.ItemComponent>(ak_);
						var am_ = c?.SubType;
						var an_ = am_?.Coding;
						bool? ao_(Coding tob)
						{
							var bb_ = tob?.CodeElement;
							var bc_ = bb_?.Value;
							var bd_ = this.Nonacute_Inpatient_Stay();
							var be_ = context.Operators.StringInValueSet(bc_, bd_);

							return be_;
						};
						var ap_ = context.Operators.WhereOrNull<Coding>((an_ as IEnumerable<Coding>), ao_);
						var aq_ = context.Operators.ExistsInList<Coding>(ap_);
						var ar_ = context.Operators.Or(al_, aq_);

						return ar_;
					};
					var ah_ = context.Operators.WhereOrNull<Claim>(af_, ag_);

					return ah_;
				};
			};
			var i_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb
			{
				InpatientStayLineItems = g_(),
				NonacuteInpatientLineItems = h_(),
			};
			var j_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb[]
			{
				i_,
			};
			Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE k_(Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb LineItemDefinition)
			{
				var bf_ = LineItemDefinition?.InpatientStayLineItems;
				var bg_ = LineItemDefinition?.NonacuteInpatientLineItems;
				IEnumerable<Claim> bh_(Claim nonAcuteInpatientStay)
				{
					var bp_ = LineItemDefinition?.InpatientStayLineItems;
					bool? bq_(Claim inpatientStay)
					{
						var bu_ = nonAcuteInpatientStay?.IdElement;
						var bv_ = inpatientStay?.IdElement;
						var bw_ = context.Operators.Equal(bu_, bv_);

						return bw_;
					};
					var br_ = context.Operators.WhereOrNull<Claim>(bp_, bq_);
					Claim bs_(Claim inpatientStay) => 
						nonAcuteInpatientStay;
					var bt_ = context.Operators.SelectOrNull<Claim, Claim>(br_, bs_);

					return bt_;
				};
				var bi_ = context.Operators.SelectManyOrNull<Claim, Claim>(bg_, bh_);
				IEnumerable<Claim> bl_(Claim inpatientStay)
				{
					var bx_ = LineItemDefinition?.NonacuteInpatientLineItems;
					bool? by_(Claim nonAcuteInpatientStay)
					{
						var cc_ = inpatientStay?.IdElement;
						var cd_ = nonAcuteInpatientStay?.IdElement;
						var ce_ = context.Operators.Equal(cc_, cd_);

						return ce_;
					};
					var bz_ = context.Operators.WhereOrNull<Claim>(bx_, by_);
					Claim ca_(Claim nonAcuteInpatientStay) => 
						inpatientStay;
					var cb_ = context.Operators.SelectOrNull<Claim, Claim>(bz_, ca_);

					return cb_;
				};
				var bm_ = context.Operators.SelectManyOrNull<Claim, Claim>(bf_, bl_);
				var bn_ = context.Operators.ListExcept<Claim>(bf_, bm_);
				var bo_ = new Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE
				{
					InpatientDischarge = bf_,
					NonacuteInpatientDischarge = bi_,
					AcuteInpatientDischarge = bn_,
				};

				return bo_;
			};
			var l_ = context.Operators.SelectOrNull<Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb, Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(j_, k_);
			var m_ = context.Operators.SingleOrNull<Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(l_);

			return m_;
		};
		var e_ = context.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(c_, d_);
		var f_ = context.Operators.SingleOrNull<Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(e_);

		return f_;
	}

    [CqlDeclaration("Get Prescriber NPI from Claims")]
	public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Prescriber_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS a_(Claim C)
		{
			var h_ = C?.CareTeam;
			bool? i_(Claim.CareTeamComponent ct)
			{
				var y_ = ct?.SequenceElement;
				var z_ = context.Operators.Convert<Integer>(y_);
				var aa_ = FHIRHelpers_4_0_001.ToInteger(z_);
				var ab_ = context.Operators.Equal(aa_, (int?)1);

				return ab_;
			};
			var j_ = context.Operators.WhereOrNull<Claim.CareTeamComponent>((h_ as IEnumerable<Claim.CareTeamComponent>), i_);
			bool? k_(Claim.CareTeamComponent @this)
			{
				var ac_ = @this?.Provider;
				var ad_ = context.Operators.Not((bool?)(ac_ is null));

				return ad_;
			};
			var l_ = context.Operators.WhereOrNull<Claim.CareTeamComponent>(j_, k_);
			ResourceReference m_(Claim.CareTeamComponent @this)
			{
				var ae_ = @this?.Provider;

				return ae_;
			};
			var n_ = context.Operators.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(l_, m_);
			bool? p_(Claim.CareTeamComponent ct)
			{
				var af_ = ct?.SequenceElement;
				var ag_ = context.Operators.Convert<Integer>(af_);
				var ah_ = FHIRHelpers_4_0_001.ToInteger(ag_);
				var ai_ = context.Operators.Equal(ah_, (int?)1);

				return ai_;
			};
			var q_ = context.Operators.WhereOrNull<Claim.CareTeamComponent>((h_ as IEnumerable<Claim.CareTeamComponent>), p_);
			bool? r_(Claim.CareTeamComponent @this)
			{
				var aj_ = @this?.Provider;
				var ak_ = context.Operators.Not((bool?)(aj_ is null));

				return ak_;
			};
			var s_ = context.Operators.WhereOrNull<Claim.CareTeamComponent>(q_, r_);
			ResourceReference t_(Claim.CareTeamComponent @this)
			{
				var al_ = @this?.Provider;

				return al_;
			};
			var u_ = context.Operators.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(s_, t_);
			string v_(ResourceReference p)
			{
				var am_ = p?.ReferenceElement;
				var an_ = new FhirString[]
				{
					am_,
				};
				string ao_(FhirString r)
				{
					var ar_ = context.Operators.Convert<string>(r);
					var as_ = NCQAFHIRBase_1_0_0.GetId(ar_);

					return as_;
				};
				var ap_ = context.Operators.SelectOrNull<FhirString, string>(an_, ao_);
				var aq_ = context.Operators.SingleOrNull<string>(ap_);

				return aq_;
			};
			var w_ = context.Operators.SelectOrNull<ResourceReference, string>(u_, v_);
			var x_ = new Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS
			{
				SingleCareTeam = C,
				CareTeamsProvider = n_,
				CareTeamsProviderID = w_,
			};

			return x_;
		};
		var b_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(claim, a_);
		var c_ = new Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR
		{
			CareTeams = b_,
		};
		var d_ = new Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR[]
		{
			c_,
		};
		Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY e_(Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR ClaimProperties)
		{
			var at_ = context.Operators.RetrieveByValueSet<Practitioner>(null, null);
			bool? au_(Practitioner p)
			{
				var bb_ = p?.IdElement;
				var bc_ = context.Operators.Convert<string>(bb_);
				var bd_ = ClaimProperties?.CareTeams;
				bool? be_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
				{
					var bk_ = @this?.CareTeamsProviderID;
					var bl_ = context.Operators.Not((bool?)(bk_ is null));

					return bl_;
				};
				var bf_ = context.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(bd_, be_);
				IEnumerable<string> bg_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
				{
					var bm_ = @this?.CareTeamsProviderID;

					return bm_;
				};
				var bh_ = context.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, IEnumerable<string>>(bf_, bg_);
				var bi_ = context.Operators.FlattenList<string>(bh_);
				var bj_ = context.Operators.InList<string>(bc_, bi_);

				return bj_;
			};
			var av_ = context.Operators.WhereOrNull<Practitioner>(at_, au_);
			var aw_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe
			{
				Practitioners = av_,
			};
			var ax_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe[]
			{
				aw_,
			};
			Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY ay_(Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe PractitionerMatch)
			{
				var bn_ = PractitionerMatch?.Practitioners;
				bool? bo_(Practitioner P)
				{
					var bx_ = context.Operators.Not((bool?)(P is null));

					return bx_;
				};
				var bp_ = context.Operators.WhereOrNull<Practitioner>(bn_, bo_);
				Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR bq_(Practitioner P)
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
					var ca_ = context.Operators.WhereOrNull<Identifier>((by_ as IEnumerable<Identifier>), bz_);
					FhirString cb_(Identifier l)
					{
						var cw_ = l?.ValueElement;

						return cw_;
					};
					var cc_ = context.Operators.SelectOrNull<Identifier, FhirString>(ca_, cb_);
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
					var cf_ = context.Operators.WhereOrNull<Identifier>((by_ as IEnumerable<Identifier>), ce_);
					Identifier cg_(Identifier l) => 
						l;
					var ch_ = context.Operators.SelectOrNull<Identifier, Identifier>(cf_, cg_);
					var ci_ = new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = cc_,
						NullIdentifiers = ch_,
					};

					return ci_;
				};
				var br_ = context.Operators.SelectOrNull<Practitioner, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(bp_, bq_);
				var bs_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = br_,
				};
				var bt_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					bs_,
				};
				Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY bu_(Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers)
				{
					int? dj_()
					{
						if ((context.Operators.ExistsInList<Claim>(context.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => 
											context.Operators.Not((bool?)(@this?.SingleCareTeam is null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => 
										@this?.SingleCareTeam)) ?? false))
						{
							var dl_ = ClaimProperties?.CareTeams;
							bool? dm_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
							{
								var eh_ = @this?.SingleCareTeam;
								var ei_ = context.Operators.Not((bool?)(eh_ is null));

								return ei_;
							};
							var dn_ = context.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(dl_, dm_);
							Claim do_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
							{
								var ej_ = @this?.SingleCareTeam;

								return ej_;
							};
							var dp_ = context.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(dn_, do_);
							bool? dq_(Claim X)
							{
								var ek_ = X?.CareTeam;

								return (bool?)((ek_ as IEnumerable<Claim.CareTeamComponent>) is null);
							};
							var dr_ = context.Operators.WhereOrNull<Claim>(dp_, dq_);
							var ds_ = context.Operators.CountOrNull<Claim>(dr_);
							var dt_ = GetIdentifiers?.IdentifierTuple;
							IEnumerable<FhirString> du_(Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X)
							{
								var el_ = X?.AllIdentifiers;

								return el_;
							};
							var dv_ = context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(dt_, du_);
							var dw_ = context.Operators.FlattenList<FhirString>(dv_);
							FhirString dx_(FhirString X) => 
								X;
							var dy_ = context.Operators.SelectOrNull<FhirString, FhirString>(dw_, dx_);
							var dz_ = context.Operators.CountOrNull<FhirString>(dy_);
							var ea_ = context.Operators.Add(ds_, dz_);
							IEnumerable<Identifier> ec_(Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X)
							{
								var em_ = X?.NullIdentifiers;

								return em_;
							};
							var ed_ = context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(dt_, ec_);
							var ee_ = context.Operators.FlattenList<Identifier>(ed_);
							var ef_ = context.Operators.CountOrNull<Identifier>(ee_);
							var eg_ = context.Operators.Add(ea_, ef_);

							return eg_;
						}
						else
						{
							return (int?)0;
						};
					};
					var dk_ = new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = dj_(),
					};

					return dk_;
				};
				var bv_ = context.Operators.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bt_, bu_);
				var bw_ = context.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bv_);

				return bw_;
			};
			var az_ = context.Operators.SelectOrNull<Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ax_, ay_);
			var ba_ = context.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(az_);

			return ba_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(d_, e_);
		var g_ = context.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(f_);

		return g_;
	}

    [CqlDeclaration("Get Pharmacy NPI from Claims")]
	public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Pharmacy_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI a_(Claim C)
		{
			var h_ = C?.Item;
			bool? j_(Claim.ItemComponent i)
			{
				var ab_ = i?.SequenceElement;
				var ac_ = context.Operators.Convert<Integer>(ab_);
				var ad_ = FHIRHelpers_4_0_001.ToInteger(ac_);
				var ae_ = context.Operators.Equal(ad_, (int?)1);

				return ae_;
			};
			var k_ = context.Operators.WhereOrNull<Claim.ItemComponent>((h_ as IEnumerable<Claim.ItemComponent>), j_);
			bool? l_(Claim.ItemComponent @this)
			{
				var af_ = @this?.Location;
				var ag_ = context.Operators.Not((bool?)(af_ is null));

				return ag_;
			};
			var m_ = context.Operators.WhereOrNull<Claim.ItemComponent>(k_, l_);
			DataType n_(Claim.ItemComponent @this)
			{
				var ah_ = @this?.Location;

				return ah_;
			};
			var o_ = context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(m_, n_);
			ResourceReference p_(DataType l) => 
				(l as ResourceReference);
			var q_ = context.Operators.SelectOrNull<DataType, ResourceReference>(o_, p_);
			bool? s_(Claim.ItemComponent i)
			{
				var ai_ = i?.SequenceElement;
				var aj_ = context.Operators.Convert<Integer>(ai_);
				var ak_ = FHIRHelpers_4_0_001.ToInteger(aj_);
				var al_ = context.Operators.Equal(ak_, (int?)1);

				return al_;
			};
			var t_ = context.Operators.WhereOrNull<Claim.ItemComponent>((h_ as IEnumerable<Claim.ItemComponent>), s_);
			bool? u_(Claim.ItemComponent @this)
			{
				var am_ = @this?.Location;
				var an_ = context.Operators.Not((bool?)(am_ is null));

				return an_;
			};
			var v_ = context.Operators.WhereOrNull<Claim.ItemComponent>(t_, u_);
			DataType w_(Claim.ItemComponent @this)
			{
				var ao_ = @this?.Location;

				return ao_;
			};
			var x_ = context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(v_, w_);
			string y_(DataType l)
			{
				var ap_ = (l as ResourceReference)?.ReferenceElement;
				var aq_ = new FhirString[]
				{
					ap_,
				};
				string ar_(FhirString r)
				{
					var au_ = context.Operators.Convert<string>(r);
					var av_ = NCQAFHIRBase_1_0_0.GetId(au_);

					return av_;
				};
				var as_ = context.Operators.SelectOrNull<FhirString, string>(aq_, ar_);
				var at_ = context.Operators.SingleOrNull<string>(as_);

				return at_;
			};
			var z_ = context.Operators.SelectOrNull<DataType, string>(x_, y_);
			var aa_ = new Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI
			{
				SingleItem = (h_ as IEnumerable<Claim.ItemComponent>),
				ItemLocation = q_,
				ItemLocationID = z_,
			};

			return aa_;
		};
		var b_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(claim, a_);
		var c_ = new Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa
		{
			ItemsLocationReferences = b_,
		};
		var d_ = new Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa[]
		{
			c_,
		};
		Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY e_(Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa ClaimProperties)
		{
			var aw_ = context.Operators.RetrieveByValueSet<Location>(null, null);
			bool? ax_(Location l)
			{
				var be_ = l?.IdElement;
				var bf_ = context.Operators.Convert<string>(be_);
				var bg_ = ClaimProperties?.ItemsLocationReferences;
				bool? bh_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
				{
					var bn_ = @this?.ItemLocationID;
					var bo_ = context.Operators.Not((bool?)(bn_ is null));

					return bo_;
				};
				var bi_ = context.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(bg_, bh_);
				IEnumerable<string> bj_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
				{
					var bp_ = @this?.ItemLocationID;

					return bp_;
				};
				var bk_ = context.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<string>>(bi_, bj_);
				var bl_ = context.Operators.FlattenList<string>(bk_);
				var bm_ = context.Operators.InList<string>(bf_, bl_);

				return bm_;
			};
			var ay_ = context.Operators.WhereOrNull<Location>(aw_, ax_);
			var az_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP
			{
				CorrespondingLocations = ay_,
			};
			var ba_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP[]
			{
				az_,
			};
			Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY bb_(Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP GetLocation)
			{
				var bq_ = GetLocation?.CorrespondingLocations;
				bool? br_(Location C)
				{
					var ca_ = context.Operators.Not((bool?)(C is null));

					return ca_;
				};
				var bs_ = context.Operators.WhereOrNull<Location>(bq_, br_);
				Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR bt_(Location C)
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
					var cd_ = context.Operators.WhereOrNull<Identifier>((cb_ as IEnumerable<Identifier>), cc_);
					FhirString ce_(Identifier l)
					{
						var cz_ = l?.ValueElement;

						return cz_;
					};
					var cf_ = context.Operators.SelectOrNull<Identifier, FhirString>(cd_, ce_);
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
					var ci_ = context.Operators.WhereOrNull<Identifier>((cb_ as IEnumerable<Identifier>), ch_);
					Identifier cj_(Identifier l) => 
						l;
					var ck_ = context.Operators.SelectOrNull<Identifier, Identifier>(ci_, cj_);
					var cl_ = new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = cf_,
						NullIdentifiers = ck_,
					};

					return cl_;
				};
				var bu_ = context.Operators.SelectOrNull<Location, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(bs_, bt_);
				var bv_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = bu_,
				};
				var bw_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					bv_,
				};
				Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY bx_(Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers)
				{
					int? dm_()
					{
						if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => 
												context.Operators.Not((bool?)(@this?.SingleItem is null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => 
											@this?.SingleItem))) ?? false))
						{
							var do_ = ClaimProperties?.ItemsLocationReferences;
							bool? dp_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
							{
								var el_ = @this?.ItemLocation;
								var em_ = context.Operators.Not((bool?)(el_ is null));

								return em_;
							};
							var dq_ = context.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(do_, dp_);
							IEnumerable<ResourceReference> dr_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
							{
								var en_ = @this?.ItemLocation;

								return en_;
							};
							var ds_ = context.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<ResourceReference>>(dq_, dr_);
							var dt_ = context.Operators.FlattenList<ResourceReference>(ds_);
							bool? du_(ResourceReference X)
							{
								var eo_ = X?.ReferenceElement;
								var ep_ = eo_?.Value;

								return (bool?)(ep_ is null);
							};
							var dv_ = context.Operators.WhereOrNull<ResourceReference>(dt_, du_);
							var dw_ = context.Operators.CountOrNull<ResourceReference>(dv_);
							var dx_ = GetIdentifiers?.IdentifierTuple;
							IEnumerable<FhirString> dy_(Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X)
							{
								var eq_ = X?.AllIdentifiers;

								return eq_;
							};
							var dz_ = context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(dx_, dy_);
							var ea_ = context.Operators.FlattenList<FhirString>(dz_);
							FhirString eb_(FhirString X) => 
								X;
							var ec_ = context.Operators.SelectOrNull<FhirString, FhirString>(ea_, eb_);
							var ed_ = context.Operators.CountOrNull<FhirString>(ec_);
							var ee_ = context.Operators.Add(dw_, ed_);
							IEnumerable<Identifier> eg_(Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X)
							{
								var er_ = X?.NullIdentifiers;

								return er_;
							};
							var eh_ = context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(dx_, eg_);
							var ei_ = context.Operators.FlattenList<Identifier>(eh_);
							var ej_ = context.Operators.CountOrNull<Identifier>(ei_);
							var ek_ = context.Operators.Add(ee_, ej_);

							return ek_;
						}
						else
						{
							return (int?)0;
						};
					};
					var dn_ = new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = dm_(),
					};

					return dn_;
				};
				var by_ = context.Operators.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bw_, bx_);
				var bz_ = context.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(by_);

				return bz_;
			};
			var bc_ = context.Operators.SelectOrNull<Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ba_, bb_);
			var bd_ = context.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bc_);

			return bd_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(d_, e_);
		var g_ = context.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(f_);

		return g_;
	}

}
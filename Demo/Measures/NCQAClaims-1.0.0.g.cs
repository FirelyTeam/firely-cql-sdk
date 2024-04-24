using System;
using Tuples;
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
			var e_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), d_);
			var g_ = NCQATerminology_1_0_0.Institutional();
			var h_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), g_);
			var i_ = context.Operators.Or(e_, h_);

			return i_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Pharmacy Claims")]
	public IEnumerable<Claim> Pharmacy_Claims(IEnumerable<Claim> claim)
	{
		bool? a_(Claim PharmacyClaim)
		{
			var c_ = FHIRHelpers_4_0_001.ToConcept(PharmacyClaim?.Type);
			var d_ = NCQATerminology_1_0_0.Pharmacy();
			var e_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), d_);

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Professional or Institutional Claims Response")]
	public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse MedicalResponse)
		{
			var c_ = FHIRHelpers_4_0_001.ToConcept(MedicalResponse?.Type);
			var d_ = NCQATerminology_1_0_0.Professional();
			var e_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), d_);
			var g_ = NCQATerminology_1_0_0.Institutional();
			var h_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), g_);
			var i_ = context.Operators.Or(e_, h_);

			return i_;
		};
		var b_ = context.Operators.WhereOrNull<ClaimResponse>(claimResponse, a_);

		return b_;
	}

    [CqlDeclaration("Pharmacy Claims Response")]
	public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse PharmacyResponse)
		{
			var c_ = FHIRHelpers_4_0_001.ToConcept(PharmacyResponse?.Type);
			var d_ = NCQATerminology_1_0_0.Pharmacy();
			var e_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), d_);

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<ClaimResponse>(claimResponse, a_);

		return b_;
	}

    [CqlDeclaration("Medical Claims With Procedure and POS")]
	public IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_and_POS(IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p) => 
			p?.code;
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, b_);
		string d_(CqlCode pos) => 
			pos?.code;
		var e_ = context.Operators.SelectOrNull<CqlCode, string>(posCodes, d_);
		var f_ = new Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = a_,
			ProceduresAsStrings = c_,
			POSAsString = e_,
		};
		var g_ = new Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			f_,
		};
		IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> h_(Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithPosCode)
		{
			Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA k_(Claim ClaimofInterest)
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
						bool? v_(Claim.ItemComponent ItemOnLine)
						{
							var x_ = FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService);
							bool? y_(CqlCode LineCode)
							{
								var ag_ = context.Operators.In<string>(LineCode?.code, ClaimWithPosCode?.ProceduresAsStrings);

								return ag_;
							};
							var z_ = context.Operators.WhereOrNull<CqlCode>((x_?.codes as IEnumerable<CqlCode>), y_);
							var aa_ = context.Operators.Exists<CqlCode>(z_);
							var ab_ = FHIRHelpers_4_0_001.ToConcept((ItemOnLine?.Location as CodeableConcept));
							bool? ac_(CqlCode PosCode)
							{
								var ah_ = context.Operators.In<string>(PosCode?.code, ClaimWithPosCode?.POSAsString);

								return ah_;
							};
							var ad_ = context.Operators.WhereOrNull<CqlCode>((ab_?.codes as IEnumerable<CqlCode>), ac_);
							var ae_ = context.Operators.Exists<CqlCode>(ad_);
							var af_ = context.Operators.And(aa_, ae_);

							return af_;
						};
						var w_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ClaimofInterest?.Item as IEnumerable<Claim.ItemComponent>), v_);

						return w_;
					};
				};
				var p_ = new Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = ClaimofInterest,
					LineItems = o_(),
				};
				var q_ = new Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					p_,
				};
				Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA r_(Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition)
				{
					Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ai_()
					{
						if ((context.Operators.Exists<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
						{
							bool? aj_(Claim.ItemComponent @this)
							{
								var aq_ = context.Operators.Not((bool?)(@this?.Serviced is null));

								return aq_;
							};
							var ak_ = context.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, aj_);
							DataType al_(Claim.ItemComponent @this) => 
								@this?.Serviced;
							var am_ = context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(ak_, al_);
							CqlInterval<CqlDateTime> an_(DataType NormalDate)
							{
								var ar_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return ar_;
							};
							var ao_ = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(am_, an_);
							var ap_ = new Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = LineItemDefinition?.Claim,
								ServicePeriod = ao_,
							};

							return ap_;
						}
						else
						{
							Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA as_ = null;

							return (as_ as Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
						};
					};

					return ai_();
				};
				var s_ = context.Operators.SelectOrNull<Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_, r_);
				var t_ = context.Operators.SingletonFrom<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(s_);

				return t_;
			};
			var l_ = context.Operators.SelectOrNull<Claim, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ClaimWithPosCode?.MedicalClaim, k_);
			bool? m_(Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var at_ = context.Operators.Not((bool?)(FinalList is null));

				return at_;
			};
			var n_ = context.Operators.WhereOrNull<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(l_, m_);

			return n_;
		};
		var i_ = context.Operators.SelectOrNull<Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);
		var j_ = context.Operators.SingletonFrom<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Procedure in Header or on Line Item")]
	public IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p) => 
			p?.code;
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, b_);
		var d_ = new Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = a_,
			ProceduresAsStrings = c_,
		};
		var e_ = new Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			d_,
		};
		IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> f_(Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithProcedure)
		{
			Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA i_(Claim ClaimofInterest)
			{
				IEnumerable<Claim.ItemComponent> m_()
				{
					if ((ClaimofInterest is null))
					{
						IEnumerable<Claim.ItemComponent> s_ = null;

						return (s_ as IEnumerable<Claim.ItemComponent>);
					}
					else
					{
						bool? t_(Claim.ItemComponent ItemOnLine)
						{
							var v_ = FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService);
							bool? w_(CqlCode LineCode)
							{
								var am_ = context.Operators.In<string>(LineCode?.code, ClaimWithProcedure?.ProceduresAsStrings);

								return am_;
							};
							var x_ = context.Operators.WhereOrNull<CqlCode>((v_?.codes as IEnumerable<CqlCode>), w_);
							var y_ = context.Operators.Exists<CqlCode>(x_);
							bool? z_(Claim.ProcedureComponent @this)
							{
								var an_ = context.Operators.Not((bool?)(@this?.Procedure is null));

								return an_;
							};
							var aa_ = context.Operators.WhereOrNull<Claim.ProcedureComponent>((ClaimofInterest?.Procedure as IEnumerable<Claim.ProcedureComponent>), z_);
							DataType ab_(Claim.ProcedureComponent @this) => 
								@this?.Procedure;
							var ac_ = context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(aa_, ab_);
							bool? ad_(DataType @this)
							{
								var ao_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								var ap_ = context.Operators.Not((bool?)(ao_ is null));

								return ap_;
							};
							var ae_ = context.Operators.WhereOrNull<DataType>(ac_, ad_);
							object af_(DataType @this)
							{
								var aq_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return aq_;
							};
							var ag_ = context.Operators.SelectOrNull<DataType, object>(ae_, af_);
							var ah_ = context.Operators.FlattenLateBoundList(ag_);
							bool? ai_(object HeaderCode)
							{
								var ar_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
								var as_ = context.Operators.In<string>(ar_?.Value, ClaimWithProcedure?.ProceduresAsStrings);

								return as_;
							};
							var aj_ = context.Operators.WhereOrNull<object>(ah_, ai_);
							var ak_ = context.Operators.Exists<object>(aj_);
							var al_ = context.Operators.Or(y_, ak_);

							return al_;
						};
						var u_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ClaimofInterest?.Item as IEnumerable<Claim.ItemComponent>), t_);

						return u_;
					};
				};
				var n_ = new Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = ClaimofInterest,
					LineItems = m_(),
				};
				var o_ = new Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					n_,
				};
				Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA p_(Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition)
				{
					Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA at_()
					{
						if ((context.Operators.Exists<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
						{
							bool? au_(Claim.ItemComponent @this)
							{
								var bb_ = context.Operators.Not((bool?)(@this?.Serviced is null));

								return bb_;
							};
							var av_ = context.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, au_);
							DataType aw_(Claim.ItemComponent @this) => 
								@this?.Serviced;
							var ax_ = context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(av_, aw_);
							CqlInterval<CqlDateTime> ay_(DataType NormalDate)
							{
								var bc_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return bc_;
							};
							var az_ = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(ax_, ay_);
							var ba_ = new Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = LineItemDefinition?.Claim,
								ServicePeriod = az_,
							};

							return ba_;
						}
						else
						{
							Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bd_ = null;

							return (bd_ as Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
						};
					};

					return at_();
				};
				var q_ = context.Operators.SelectOrNull<Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(o_, p_);
				var r_ = context.Operators.SingletonFrom<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_);

				return r_;
			};
			var j_ = context.Operators.SelectOrNull<Claim, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ClaimWithProcedure?.MedicalClaim, i_);
			bool? k_(Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var be_ = context.Operators.Not((bool?)(FinalList is null));

				return be_;
			};
			var l_ = context.Operators.WhereOrNull<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(j_, k_);

			return l_;
		};
		var g_ = context.Operators.SelectOrNull<Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(e_, f_);
		var h_ = context.Operators.SingletonFrom<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis")]
	public Tuple_HLLRUdKceDPKeIXGFiiNKjMKI Medical_Claims_With_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d) => 
			d?.code;
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		var d_ = new Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
		};
		var e_ = new Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			d_,
		};
		Tuple_HLLRUdKceDPKeIXGFiiNKjMKI f_(Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis)
		{
			IEnumerable<Claim> i_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					IEnumerable<Claim> o_ = null;

					return (o_ as IEnumerable<Claim>);
				}
				else
				{
					bool? p_(Claim DiagnosisLine)
					{
						bool? r_(Claim.DiagnosisComponent @this)
						{
							var ad_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

							return ad_;
						};
						var s_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), r_);
						DataType t_(Claim.DiagnosisComponent @this) => 
							@this?.Diagnosis;
						var u_ = context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(s_, t_);
						bool? v_(DataType @this)
						{
							var ae_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							var af_ = context.Operators.Not((bool?)(ae_ is null));

							return af_;
						};
						var w_ = context.Operators.WhereOrNull<DataType>(u_, v_);
						object x_(DataType @this)
						{
							var ag_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return ag_;
						};
						var y_ = context.Operators.SelectOrNull<DataType, object>(w_, x_);
						var z_ = context.Operators.FlattenLateBoundList(y_);
						bool? aa_(object HeaderCode)
						{
							var ah_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
							var ai_ = context.Operators.In<string>(ah_?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings);

							return ai_;
						};
						var ab_ = context.Operators.WhereOrNull<object>(z_, aa_);
						var ac_ = context.Operators.Exists<object>(ab_);

						return ac_;
					};
					var q_ = context.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, p_);

					return q_;
				};
			};
			var j_ = new Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = i_(),
			};
			var k_ = new Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				j_,
			};
			Tuple_HLLRUdKceDPKeIXGFiiNKjMKI l_(Tuple_FcALBBGFXRhKjhIaDWMVWUhJg HeaderDefinition)
			{
				Tuple_HLLRUdKceDPKeIXGFiiNKjMKI aj_()
				{
					if ((context.Operators.Exists<Claim>(HeaderDefinition?.DiagnosisItems) ?? false))
					{
						bool? ao_(Claim @this)
						{
							var aw_ = context.Operators.Not((bool?)(@this?.Item is null));

							return aw_;
						};
						var ap_ = context.Operators.WhereOrNull<Claim>(HeaderDefinition?.DiagnosisItems, ao_);
						List<Claim.ItemComponent> aq_(Claim @this) => 
							@this?.Item;
						var ar_ = context.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(ap_, aq_);
						var as_ = context.Operators.FlattenList<Claim.ItemComponent>(ar_);
						CqlInterval<CqlDateTime> at_(Claim.ItemComponent NormalDate)
						{
							var ax_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced);

							return ax_;
						};
						var au_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(as_, at_);
						var av_ = new Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = HeaderDefinition?.DiagnosisItems,
							ServicePeriod = au_,
						};

						return av_;
					}
					else
					{
						Tuple_HLLRUdKceDPKeIXGFiiNKjMKI ay_ = null;

						return (ay_ as Tuple_HLLRUdKceDPKeIXGFiiNKjMKI);
					};
				};
				var ak_ = new Tuple_HLLRUdKceDPKeIXGFiiNKjMKI[]
				{
					aj_(),
				};
				bool? al_(Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList)
				{
					var az_ = context.Operators.Not((bool?)(FinalList is null));

					return az_;
				};
				var am_ = context.Operators.WhereOrNull<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(ak_, al_);
				var an_ = context.Operators.SingletonFrom<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(am_);

				return an_;
			};
			var m_ = context.Operators.SelectOrNull<Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(k_, l_);
			var n_ = context.Operators.SingletonFrom<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(m_);

			return n_;
		};
		var g_ = context.Operators.SelectOrNull<Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(e_, f_);
		var h_ = context.Operators.SingletonFrom<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(g_);

		return h_;
	}

    [CqlDeclaration("Pharmacy Claim With Medication")]
	public IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> Pharmacy_Claim_With_Medication(IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
	{
		var a_ = this.Pharmacy_Claims(claim);
		string b_(CqlCode p) => 
			p?.code;
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(MedicationCodes, b_);
		var d_ = new Tuple_BAGeQidBiLhNHVFiERZPAUdCY
		{
			PharmacyClaim = a_,
			MedicationsAsStrings = c_,
		};
		var e_ = new Tuple_BAGeQidBiLhNHVFiERZPAUdCY[]
		{
			d_,
		};
		IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> f_(Tuple_BAGeQidBiLhNHVFiERZPAUdCY ClaimWithMedication)
		{
			Tuple_FOLKddIQBPRMYYfjeMUjEIBhC i_(Claim Pharmacy)
			{
				bool? m_(Claim.ItemComponent ItemOnLine)
				{
					var t_ = FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService);
					bool? u_(CqlCode LineCode)
					{
						var x_ = context.Operators.In<string>(LineCode?.code, ClaimWithMedication?.MedicationsAsStrings);

						return x_;
					};
					var v_ = context.Operators.WhereOrNull<CqlCode>((t_?.codes as IEnumerable<CqlCode>), u_);
					var w_ = context.Operators.Exists<CqlCode>(v_);

					return w_;
				};
				var n_ = context.Operators.WhereOrNull<Claim.ItemComponent>((Pharmacy?.Item as IEnumerable<Claim.ItemComponent>), m_);
				var o_ = new Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = Pharmacy,
					LineItems = n_,
				};
				var p_ = new Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					o_,
				};
				Tuple_FOLKddIQBPRMYYfjeMUjEIBhC q_(Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition)
				{
					var y_ = new Claim[]
					{
						LineItemDefinition?.Claim,
					};
					Tuple_FOLKddIQBPRMYYfjeMUjEIBhC z_(Claim ClaimLines)
					{
						bool? ac_(Claim.ItemComponent i)
						{
							var al_ = FHIRHelpers_4_0_001.ToConcept(i?.ProductOrService);
							bool? am_(CqlCode LineCode)
							{
								var ap_ = context.Operators.In<string>(LineCode?.code, ClaimWithMedication?.MedicationsAsStrings);

								return ap_;
							};
							var an_ = context.Operators.WhereOrNull<CqlCode>((al_?.codes as IEnumerable<CqlCode>), am_);
							var ao_ = context.Operators.Exists<CqlCode>(an_);

							return ao_;
						};
						var ad_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ClaimLines?.Item as IEnumerable<Claim.ItemComponent>), ac_);
						Tuple_DadNQNcGichTGjKhdjJicQeTP ae_(Claim.ItemComponent i)
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
											var az_ = context.Operators.Quantity((decimal?)1m, "day");
											var ba_ = context.Operators.Subtract(ay_, az_);
											var bb_ = context.Operators.Interval(au_, ba_, (bool?)true, (bool?)true);

											return bb_;
										}
										else
										{
											var bc_ = FHIRHelpers_4_0_001.ToDate((i?.Serviced as Date));
											var be_ = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement);
											var bf_ = context.Operators.Add(bc_, new CqlQuantity(be_, "day"));
											var bg_ = context.Operators.Quantity((decimal?)1m, "day");
											var bh_ = context.Operators.Subtract(bf_, bg_);
											var bi_ = context.Operators.Interval(bc_, bh_, (bool?)true, (bool?)true);
											var bj_ = context.Operators.ConvertDateToDateTime(bi_?.low);
											var bn_ = context.Operators.Add(bc_, new CqlQuantity(be_, "day"));
											var bp_ = context.Operators.Subtract(bn_, bg_);
											var bq_ = context.Operators.Interval(bc_, bp_, (bool?)true, (bool?)true);
											var br_ = context.Operators.ConvertDateToDateTime(bq_?.high);
											var bv_ = context.Operators.Add(bc_, new CqlQuantity(be_, "day"));
											var bx_ = context.Operators.Subtract(bv_, bg_);
											var by_ = context.Operators.Interval(bc_, bx_, (bool?)true, (bool?)true);
											var cc_ = context.Operators.Add(bc_, new CqlQuantity(be_, "day"));
											var ce_ = context.Operators.Subtract(cc_, bg_);
											var cf_ = context.Operators.Interval(bc_, ce_, (bool?)true, (bool?)true);
											var cg_ = context.Operators.Interval(bj_, br_, by_?.lowClosed, cf_?.highClosed);

											return cg_;
										};
									};

									return as_();
								}
								else
								{
									CqlInterval<CqlDateTime> ch_ = null;

									return (ch_ as CqlInterval<CqlDateTime>);
								};
							};
							var ar_ = new Tuple_DadNQNcGichTGjKhdjJicQeTP
							{
								DaysSupplyInterval = aq_(),
							};

							return ar_;
						};
						var af_ = context.Operators.SelectOrNull<Claim.ItemComponent, Tuple_DadNQNcGichTGjKhdjJicQeTP>(ad_, ae_);
						var ag_ = new Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU
						{
							CoveredDays = af_,
						};
						var ah_ = new Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU[]
						{
							ag_,
						};
						Tuple_FOLKddIQBPRMYYfjeMUjEIBhC ai_(Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU ItemCalculation)
						{
							Tuple_FOLKddIQBPRMYYfjeMUjEIBhC ci_()
							{
								if ((context.Operators.Exists<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
								{
									bool? cj_(Claim.ItemComponent @this)
									{
										var cs_ = context.Operators.Not((bool?)(@this?.Serviced is null));

										return cs_;
									};
									var ck_ = context.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, cj_);
									DataType cl_(Claim.ItemComponent @this) => 
										@this?.Serviced;
									var cm_ = context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(ck_, cl_);
									CqlInterval<CqlDateTime> cn_(DataType NormalDate)
									{
										var ct_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

										return ct_;
									};
									var co_ = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(cm_, cn_);
									CqlInterval<CqlDateTime> cp_(Tuple_DadNQNcGichTGjKhdjJicQeTP d) => 
										d?.DaysSupplyInterval;
									var cq_ = context.Operators.SelectOrNull<Tuple_DadNQNcGichTGjKhdjJicQeTP, CqlInterval<CqlDateTime>>(ItemCalculation?.CoveredDays, cp_);
									var cr_ = new Tuple_FOLKddIQBPRMYYfjeMUjEIBhC
									{
										Claim = LineItemDefinition?.Claim,
										LineItem = LineItemDefinition?.LineItems,
										ServicePeriod = co_,
										CoveredDays = cq_,
									};

									return cr_;
								}
								else
								{
									Tuple_FOLKddIQBPRMYYfjeMUjEIBhC cu_ = null;

									return (cu_ as Tuple_FOLKddIQBPRMYYfjeMUjEIBhC);
								};
							};

							return ci_();
						};
						var aj_ = context.Operators.SelectOrNull<Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU, Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ah_, ai_);
						var ak_ = context.Operators.SingletonFrom<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(aj_);

						return ak_;
					};
					var aa_ = context.Operators.SelectOrNull<Claim, Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(y_, z_);
					var ab_ = context.Operators.SingletonFrom<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(aa_);

					return ab_;
				};
				var r_ = context.Operators.SelectOrNull<Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(p_, q_);
				var s_ = context.Operators.SingletonFrom<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(r_);

				return s_;
			};
			var j_ = context.Operators.SelectOrNull<Claim, Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ClaimWithMedication?.PharmacyClaim, i_);
			bool? k_(Tuple_FOLKddIQBPRMYYfjeMUjEIBhC FinalList)
			{
				var cv_ = context.Operators.Not((bool?)(FinalList is null));

				return cv_;
			};
			var l_ = context.Operators.WhereOrNull<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(j_, k_);

			return l_;
		};
		var g_ = context.Operators.SelectOrNull<Tuple_BAGeQidBiLhNHVFiERZPAUdCY, IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(e_, f_);
		var h_ = context.Operators.SingletonFrom<IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis and Procedure")]
	public IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d) => 
			d?.code;
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p) => 
			p?.code;
		var e_ = context.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, d_);
		var f_ = new Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
			ProceduresAsStrings = e_,
		};
		var g_ = new Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
		{
			f_,
		};
		IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> h_(Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithDiagnosis)
		{
			IEnumerable<Claim> k_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					IEnumerable<Claim> q_ = null;

					return (q_ as IEnumerable<Claim>);
				}
				else
				{
					bool? r_(Claim DiagnosisLine)
					{
						bool? t_(Claim.DiagnosisComponent @this)
						{
							var af_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

							return af_;
						};
						var u_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), t_);
						DataType v_(Claim.DiagnosisComponent @this) => 
							@this?.Diagnosis;
						var w_ = context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(u_, v_);
						bool? x_(DataType @this)
						{
							var ag_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							var ah_ = context.Operators.Not((bool?)(ag_ is null));

							return ah_;
						};
						var y_ = context.Operators.WhereOrNull<DataType>(w_, x_);
						object z_(DataType @this)
						{
							var ai_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return ai_;
						};
						var aa_ = context.Operators.SelectOrNull<DataType, object>(y_, z_);
						var ab_ = context.Operators.FlattenLateBoundList(aa_);
						bool? ac_(object HeaderCode)
						{
							var aj_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
							var ak_ = context.Operators.In<string>(aj_?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings);

							return ak_;
						};
						var ad_ = context.Operators.WhereOrNull<object>(ab_, ac_);
						var ae_ = context.Operators.Exists<object>(ad_);

						return ae_;
					};
					var s_ = context.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, r_);

					return s_;
				};
			};
			var l_ = new Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = k_(),
			};
			var m_ = new Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				l_,
			};
			IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> n_(Tuple_FcALBBGFXRhKjhIaDWMVWUhJg ClaimWithProcedure)
			{
				Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA al_(Claim ClaimofInterest)
				{
					Claim ap_()
					{
						if ((ClaimofInterest is null))
						{
							return null;
						}
						else
						{
							var av_ = new Claim[]
							{
								ClaimofInterest,
							};
							bool? aw_(Claim ItemOnLine)
							{
								bool? az_(Claim.ProcedureComponent @this)
								{
									var by_ = context.Operators.Not((bool?)(@this?.Procedure is null));

									return by_;
								};
								var ba_ = context.Operators.WhereOrNull<Claim.ProcedureComponent>((ItemOnLine?.Procedure as IEnumerable<Claim.ProcedureComponent>), az_);
								DataType bb_(Claim.ProcedureComponent @this) => 
									@this?.Procedure;
								var bc_ = context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(ba_, bb_);
								bool? bd_(DataType @this)
								{
									var bz_ = context.Operators.LateBoundProperty<object>(@this, "coding");
									var ca_ = context.Operators.Not((bool?)(bz_ is null));

									return ca_;
								};
								var be_ = context.Operators.WhereOrNull<DataType>(bc_, bd_);
								object bf_(DataType @this)
								{
									var cb_ = context.Operators.LateBoundProperty<object>(@this, "coding");

									return cb_;
								};
								var bg_ = context.Operators.SelectOrNull<DataType, object>(be_, bf_);
								var bh_ = context.Operators.FlattenLateBoundList(bg_);
								bool? bi_(object ProcedureHeaderCode)
								{
									var cc_ = context.Operators.LateBoundProperty<Code>(ProcedureHeaderCode, "code");
									var cd_ = context.Operators.In<string>(cc_?.Value, ClaimWithDiagnosis?.ProceduresAsStrings);

									return cd_;
								};
								var bj_ = context.Operators.WhereOrNull<object>(bh_, bi_);
								var bk_ = context.Operators.Exists<object>(bj_);
								bool? bl_(Claim.ItemComponent @this)
								{
									var ce_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

									return ce_;
								};
								var bm_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ItemOnLine?.Item as IEnumerable<Claim.ItemComponent>), bl_);
								CodeableConcept bn_(Claim.ItemComponent @this) => 
									@this?.ProductOrService;
								var bo_ = context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(bm_, bn_);
								bool? bp_(CodeableConcept @this)
								{
									var cf_ = context.Operators.Not((bool?)(@this?.Coding is null));

									return cf_;
								};
								var bq_ = context.Operators.WhereOrNull<CodeableConcept>(bo_, bp_);
								List<Coding> br_(CodeableConcept @this) => 
									@this?.Coding;
								var bs_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(bq_, br_);
								var bt_ = context.Operators.FlattenList<Coding>(bs_);
								bool? bu_(Coding LineCode)
								{
									var cg_ = context.Operators.In<string>(LineCode?.CodeElement?.Value, ClaimWithDiagnosis?.ProceduresAsStrings);

									return cg_;
								};
								var bv_ = context.Operators.WhereOrNull<Coding>(bt_, bu_);
								var bw_ = context.Operators.Exists<Coding>(bv_);
								var bx_ = context.Operators.Or(bk_, bw_);

								return bx_;
							};
							var ax_ = context.Operators.WhereOrNull<Claim>(av_, aw_);
							var ay_ = context.Operators.SingletonFrom<Claim>(ax_);

							return ay_;
						};
					};
					var aq_ = new Tuple_DQefEeUREeePUGdeeZLYSgFcU
					{
						ProcedureItems = ap_(),
					};
					var ar_ = new Tuple_DQefEeUREeePUGdeeZLYSgFcU[]
					{
						aq_,
					};
					Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA as_(Tuple_DQefEeUREeePUGdeeZLYSgFcU HeaderDefinition)
					{
						Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ch_()
						{
							if ((context.Operators.Not((bool?)(HeaderDefinition?.ProcedureItems is null)) ?? false))
							{
								CqlInterval<CqlDateTime> ci_(Claim.ItemComponent NormalDate)
								{
									var cl_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced);

									return cl_;
								};
								var cj_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((HeaderDefinition?.ProcedureItems?.Item as IEnumerable<Claim.ItemComponent>), ci_);
								var ck_ = new Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
								{
									Claim = HeaderDefinition?.ProcedureItems,
									ServicePeriod = cj_,
								};

								return ck_;
							}
							else
							{
								Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA cm_ = null;

								return (cm_ as Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
							};
						};

						return ch_();
					};
					var at_ = context.Operators.SelectOrNull<Tuple_DQefEeUREeePUGdeeZLYSgFcU, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ar_, as_);
					var au_ = context.Operators.SingletonFrom<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(at_);

					return au_;
				};
				var am_ = context.Operators.SelectOrNull<Claim, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ClaimWithProcedure?.DiagnosisItems, al_);
				bool? an_(Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
				{
					var cn_ = context.Operators.Not((bool?)(FinalList is null));

					return cn_;
				};
				var ao_ = context.Operators.WhereOrNull<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(am_, an_);

				return ao_;
			};
			var o_ = context.Operators.SelectOrNull<Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(m_, n_);
			var p_ = context.Operators.SingletonFrom<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(o_);

			return p_;
		};
		var i_ = context.Operators.SelectOrNull<Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);
		var j_ = context.Operators.SingletonFrom<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis and Procedure")]
	public IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Principal_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d) => 
			d?.code;
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p) => 
			p?.code;
		var e_ = context.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, d_);
		var f_ = new Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
			ProceduresAsStrings = e_,
		};
		var g_ = new Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
		{
			f_,
		};
		IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> h_(Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithProcedure)
		{
			Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA k_(Claim ClaimofInterest)
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
							var z_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ItemOnLine?.Item as IEnumerable<Claim.ItemComponent>), y_);
							CodeableConcept aa_(Claim.ItemComponent @this) => 
								@this?.ProductOrService;
							var ab_ = context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(z_, aa_);
							bool? ac_(CodeableConcept @this)
							{
								var ay_ = context.Operators.Not((bool?)(@this?.Coding is null));

								return ay_;
							};
							var ad_ = context.Operators.WhereOrNull<CodeableConcept>(ab_, ac_);
							List<Coding> ae_(CodeableConcept @this) => 
								@this?.Coding;
							var af_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(ad_, ae_);
							var ag_ = context.Operators.FlattenList<Coding>(af_);
							bool? ah_(Coding LineCode)
							{
								var az_ = context.Operators.In<string>(LineCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings);

								return az_;
							};
							var ai_ = context.Operators.WhereOrNull<Coding>(ag_, ah_);
							var aj_ = context.Operators.Exists<Coding>(ai_);
							bool? ak_(Claim.ProcedureComponent @this)
							{
								var ba_ = context.Operators.Not((bool?)(@this?.Procedure is null));

								return ba_;
							};
							var al_ = context.Operators.WhereOrNull<Claim.ProcedureComponent>((ItemOnLine?.Procedure as IEnumerable<Claim.ProcedureComponent>), ak_);
							DataType am_(Claim.ProcedureComponent @this) => 
								@this?.Procedure;
							var an_ = context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(al_, am_);
							bool? ao_(DataType @this)
							{
								var bb_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								var bc_ = context.Operators.Not((bool?)(bb_ is null));

								return bc_;
							};
							var ap_ = context.Operators.WhereOrNull<DataType>(an_, ao_);
							object aq_(DataType @this)
							{
								var bd_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return bd_;
							};
							var ar_ = context.Operators.SelectOrNull<DataType, object>(ap_, aq_);
							var as_ = context.Operators.FlattenLateBoundList(ar_);
							bool? at_(object HeaderCode)
							{
								var be_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
								var bf_ = context.Operators.In<string>(be_?.Value, ClaimWithProcedure?.ProceduresAsStrings);

								return bf_;
							};
							var au_ = context.Operators.WhereOrNull<object>(as_, at_);
							var av_ = context.Operators.Exists<object>(au_);
							var aw_ = context.Operators.Or(aj_, av_);

							return aw_;
						};
						var w_ = context.Operators.WhereOrNull<Claim>(u_, v_);
						var x_ = context.Operators.SingletonFrom<Claim>(w_);

						return x_;
					};
				};
				var p_ = new Tuple_CIIbRNfJieBVcNIWHEUWMVhOB
				{
					Claim = ClaimofInterest,
					ProcedureItems = o_(),
				};
				var q_ = new Tuple_CIIbRNfJieBVcNIWHEUWMVhOB[]
				{
					p_,
				};
				Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA r_(Tuple_CIIbRNfJieBVcNIWHEUWMVhOB DiagnosisCheck)
				{
					var bg_ = new Claim[]
					{
						DiagnosisCheck?.ProcedureItems,
					};
					Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bh_(Claim ClaimforDiagnosis)
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
										var bz_ = context.Operators.Equal(by_, (int?)1);
										var ca_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(RightDiagnosis?.Diagnosis, "coding");
										bool? cb_(Coding DiagnosisCode)
										{
											var cf_ = context.Operators.In<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithProcedure?.DiagnosesAsStrings);

											return cf_;
										};
										var cc_ = context.Operators.WhereOrNull<Coding>(ca_, cb_);
										var cd_ = context.Operators.Exists<Coding>(cc_);
										var ce_ = context.Operators.And(bz_, cd_);

										return ce_;
									};
									var bv_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), bu_);
									var bw_ = context.Operators.Exists<Claim.DiagnosisComponent>(bv_);

									return bw_;
								};
								var bs_ = context.Operators.WhereOrNull<Claim>(bq_, br_);
								var bt_ = context.Operators.SingletonFrom<Claim>(bs_);

								return bt_;
							};
						};
						var bl_ = new Tuple_iUHcMLYFdMEcPJJeOVJdQjbI
						{
							Procedure = (ClaimforDiagnosis?.Item as IEnumerable<Claim.ItemComponent>),
							LineItems = bk_(),
						};
						var bm_ = new Tuple_iUHcMLYFdMEcPJJeOVJdQjbI[]
						{
							bl_,
						};
						Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bn_(Tuple_iUHcMLYFdMEcPJJeOVJdQjbI LineItemDefinition)
						{
							Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA cg_()
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
									var cm_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((LineItemDefinition?.LineItems?.Item as IEnumerable<Claim.ItemComponent>), cl_);
									var cn_ = new Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
									{
										Claim = LineItemDefinition?.LineItems,
										ServicePeriod = cm_,
									};

									return cn_;
								}
								else
								{
									Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA cp_ = null;

									return (cp_ as Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
								};
							};

							return cg_();
						};
						var bo_ = context.Operators.SelectOrNull<Tuple_iUHcMLYFdMEcPJJeOVJdQjbI, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bm_, bn_);
						var bp_ = context.Operators.SingletonFrom<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bo_);

						return bp_;
					};
					var bi_ = context.Operators.SelectOrNull<Claim, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bg_, bh_);
					var bj_ = context.Operators.SingletonFrom<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bi_);

					return bj_;
				};
				var s_ = context.Operators.SelectOrNull<Tuple_CIIbRNfJieBVcNIWHEUWMVhOB, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_, r_);
				var t_ = context.Operators.SingletonFrom<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(s_);

				return t_;
			};
			var l_ = context.Operators.SelectOrNull<Claim, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ClaimWithProcedure?.MedicalClaim, k_);
			bool? m_(Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var cq_ = context.Operators.Not((bool?)(FinalList is null));

				return cq_;
			};
			var n_ = context.Operators.WhereOrNull<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(l_, m_);

			return n_;
		};
		var i_ = context.Operators.SelectOrNull<Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);
		var j_ = context.Operators.SingletonFrom<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis")]
	public IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> Medical_Claims_With_Principal_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d) => 
			d?.code;
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		var d_ = new Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
		};
		var e_ = new Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			d_,
		};
		IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> f_(Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis)
		{
			IEnumerable<Claim> i_()
			{
				if ((ClaimWithDiagnosis?.MedicalClaim is null))
				{
					IEnumerable<Claim> o_ = null;

					return (o_ as IEnumerable<Claim>);
				}
				else
				{
					bool? p_(Claim RightClaim)
					{
						bool? r_(Claim.DiagnosisComponent RightDiagnosis)
						{
							var u_ = context.Operators.Convert<Integer>(RightDiagnosis?.SequenceElement);
							var v_ = FHIRHelpers_4_0_001.ToInteger(u_);
							var w_ = context.Operators.Equal(v_, (int?)1);
							var x_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(RightDiagnosis?.Diagnosis, "coding");
							bool? y_(Coding DiagnosisCode)
							{
								var ac_ = context.Operators.In<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings);

								return ac_;
							};
							var z_ = context.Operators.WhereOrNull<Coding>(x_, y_);
							var aa_ = context.Operators.Exists<Coding>(z_);
							var ab_ = context.Operators.And(w_, aa_);

							return ab_;
						};
						var s_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), r_);
						var t_ = context.Operators.Exists<Claim.DiagnosisComponent>(s_);

						return t_;
					};
					var q_ = context.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, p_);

					return q_;
				};
			};
			var j_ = new Tuple_FADJTWQjaQgiVVcFZjGXbPFbN
			{
				LineItems = i_(),
			};
			var k_ = new Tuple_FADJTWQjaQgiVVcFZjGXbPFbN[]
			{
				j_,
			};
			IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> l_(Tuple_FADJTWQjaQgiVVcFZjGXbPFbN LineItemDefinition)
			{
				Tuple_HLLRUdKceDPKeIXGFiiNKjMKI ad_(Claim ClaimWithDiagnosis)
				{
					Tuple_HLLRUdKceDPKeIXGFiiNKjMKI ah_()
					{
						if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null)) ?? false))
						{
							bool? ai_(Claim @this)
							{
								var aq_ = context.Operators.Not((bool?)(@this?.Item is null));

								return aq_;
							};
							var aj_ = context.Operators.WhereOrNull<Claim>(LineItemDefinition?.LineItems, ai_);
							List<Claim.ItemComponent> ak_(Claim @this) => 
								@this?.Item;
							var al_ = context.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(aj_, ak_);
							var am_ = context.Operators.FlattenList<Claim.ItemComponent>(al_);
							CqlInterval<CqlDateTime> an_(Claim.ItemComponent NormalDate)
							{
								var ar_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced);

								return ar_;
							};
							var ao_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(am_, an_);
							var ap_ = new Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
							{
								Claim = LineItemDefinition?.LineItems,
								ServicePeriod = ao_,
							};

							return ap_;
						}
						else
						{
							Tuple_HLLRUdKceDPKeIXGFiiNKjMKI as_ = null;

							return (as_ as Tuple_HLLRUdKceDPKeIXGFiiNKjMKI);
						};
					};

					return ah_();
				};
				var ae_ = context.Operators.SelectOrNull<Claim, Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(LineItemDefinition?.LineItems, ad_);
				bool? af_(Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList)
				{
					var at_ = context.Operators.Not((bool?)(FinalList is null));

					return at_;
				};
				var ag_ = context.Operators.WhereOrNull<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(ae_, af_);

				return ag_;
			};
			var m_ = context.Operators.SelectOrNull<Tuple_FADJTWQjaQgiVVcFZjGXbPFbN, IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(k_, l_);
			var n_ = context.Operators.SingletonFrom<IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(m_);

			return n_;
		};
		var g_ = context.Operators.SelectOrNull<Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(e_, f_);
		var h_ = context.Operators.SingletonFrom<IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(g_);

		return h_;
	}

    [CqlDeclaration("Get All Professional and Institutional Claims and Claim Responses")]
	public Tuple_GjTATZbNccdVYWChGHHdRUXSM Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		var a_ = this.Professional_or_Institutional_Claims_Response(claimResponse);
		var b_ = this.Professional_or_Institutional_Claims(claim);
		var c_ = new Tuple_GjTATZbNccdVYWChGHHdRUXSM
		{
			MedicalClaimResponse = a_,
			MedicalClaim = b_,
		};

		return c_;
	}

    [CqlDeclaration("Get All Paid Claim Reponses")]
	public IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> Get_All_Paid_Claim_Reponses(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse ResponseItem)
		{
			var h_ = context.Operators.Convert<string>(ResponseItem?.OutcomeElement);
			var i_ = new string[]
			{
				"complete",
				"partial",
			};
			var j_ = context.Operators.In<string>(h_, (i_ as IEnumerable<string>));

			return j_;
		};
		var b_ = context.Operators.WhereOrNull<ClaimResponse>(claimResponse, a_);
		var c_ = new Tuple_GRhdjhBUGcJfFRBeODDiYLCdD
		{
			PaidResponse = b_,
		};
		var d_ = new Tuple_GRhdjhBUGcJfFRBeODDiYLCdD[]
		{
			c_,
		};
		IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> e_(Tuple_GRhdjhBUGcJfFRBeODDiYLCdD ClaimResponse)
		{
			Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL k_(ClaimResponse ClmResp)
			{
				var m_ = context.Operators.Convert<string>(ClmResp?.Request?.ReferenceElement);
				var n_ = NCQAFHIRBase_1_0_0.GetId(m_);
				bool? o_(ClaimResponse.ItemComponent ResponseItem)
				{
					bool? r_(ClaimResponse.AdjudicationComponent @this)
					{
						var al_ = context.Operators.Not((bool?)(@this?.Category is null));

						return al_;
					};
					var s_ = context.Operators.WhereOrNull<ClaimResponse.AdjudicationComponent>(ResponseItem?.Adjudication, r_);
					CodeableConcept t_(ClaimResponse.AdjudicationComponent @this) => 
						@this?.Category;
					var u_ = context.Operators.SelectOrNull<ClaimResponse.AdjudicationComponent, CodeableConcept>(s_, t_);
					bool? v_(CodeableConcept @this)
					{
						var am_ = context.Operators.Not((bool?)(@this?.Coding is null));

						return am_;
					};
					var w_ = context.Operators.WhereOrNull<CodeableConcept>(u_, v_);
					List<Coding> x_(CodeableConcept @this) => 
						@this?.Coding;
					var y_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(w_, x_);
					var z_ = context.Operators.FlattenList<Coding>(y_);
					bool? aa_(Coding CategoryItem)
					{
						var an_ = context.Operators.Equal(CategoryItem?.CodeElement?.Value, "benefit");

						return an_;
					};
					var ab_ = context.Operators.WhereOrNull<Coding>(z_, aa_);
					var ac_ = context.Operators.Exists<Coding>(ab_);
					bool? ad_(ClaimResponse.AdjudicationComponent @this)
					{
						var ao_ = context.Operators.Not((bool?)(@this?.Amount is null));

						return ao_;
					};
					var ae_ = context.Operators.WhereOrNull<ClaimResponse.AdjudicationComponent>(ResponseItem?.Adjudication, ad_);
					Money af_(ClaimResponse.AdjudicationComponent @this) => 
						@this?.Amount;
					var ag_ = context.Operators.SelectOrNull<ClaimResponse.AdjudicationComponent, Money>(ae_, af_);
					bool? ah_(Money DollarAmount)
					{
						var ap_ = FHIRHelpers_4_0_001.ToDecimal(DollarAmount?.ValueElement);
						var aq_ = context.Operators.ConvertIntegerToDecimal((int?)0);
						var ar_ = context.Operators.Greater(ap_, aq_);

						return ar_;
					};
					var ai_ = context.Operators.WhereOrNull<Money>(ag_, ah_);
					var aj_ = context.Operators.Exists<Money>(ai_);
					var ak_ = context.Operators.And(ac_, aj_);

					return ak_;
				};
				var p_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>((ClmResp?.Item as IEnumerable<ClaimResponse.ItemComponent>), o_);
				var q_ = new Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL
				{
					Response = ClmResp,
					ResponseID = n_,
					LineItems = p_,
				};

				return q_;
			};
			var l_ = context.Operators.SelectOrNull<ClaimResponse, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimResponse?.PaidResponse, k_);

			return l_;
		};
		var f_ = context.Operators.SelectOrNull<Tuple_GRhdjhBUGcJfFRBeODDiYLCdD, IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(d_, e_);
		var g_ = context.Operators.SingletonFrom<IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(f_);

		return g_;
	}

    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
	public IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_and_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			bool? e_(Claim.ItemComponent @this)
			{
				var ad_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

				return ad_;
			};
			var f_ = context.Operators.WhereOrNull<Claim.ItemComponent>(AllClaims?.Item, e_);
			CodeableConcept g_(Claim.ItemComponent @this) => 
				@this?.ProductOrService;
			var h_ = context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(f_, g_);
			bool? i_(CodeableConcept @this)
			{
				var ae_ = context.Operators.Not((bool?)(@this?.Coding is null));

				return ae_;
			};
			var j_ = context.Operators.WhereOrNull<CodeableConcept>(h_, i_);
			List<Coding> k_(CodeableConcept @this) => 
				@this?.Coding;
			var l_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(j_, k_);
			var m_ = context.Operators.FlattenList<Coding>(l_);
			bool? n_(Coding ProductOrServiceCode)
			{
				var af_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var ag_ = context.Operators.In<CqlCode>(af_, ProductOrServiceValueSet);

				return ag_;
			};
			var o_ = context.Operators.WhereOrNull<Coding>(m_, n_);
			var p_ = context.Operators.Exists<Coding>(o_);
			bool? q_(Claim.DiagnosisComponent @this)
			{
				var ah_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

				return ah_;
			};
			var r_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((AllClaims?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), q_);
			DataType s_(Claim.DiagnosisComponent @this) => 
				@this?.Diagnosis;
			var t_ = context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(r_, s_);
			bool? u_(DataType @this)
			{
				var ai_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				var aj_ = context.Operators.Not((bool?)(ai_ is null));

				return aj_;
			};
			var v_ = context.Operators.WhereOrNull<DataType>(t_, u_);
			object w_(DataType @this)
			{
				var ak_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return ak_;
			};
			var x_ = context.Operators.SelectOrNull<DataType, object>(v_, w_);
			var y_ = context.Operators.FlattenLateBoundList(x_);
			bool? z_(object DiagnosisCode)
			{
				var al_ = FHIRHelpers_4_0_001.ToCode((DiagnosisCode as Coding));
				var am_ = context.Operators.In<CqlCode>(al_, DiagnosisValueSet);

				return am_;
			};
			var aa_ = context.Operators.WhereOrNull<object>(y_, z_);
			var ab_ = context.Operators.Exists<object>(aa_);
			var ac_ = context.Operators.And(p_, ab_);

			return ac_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);
		Tuple_DXaYeZVOEAELKIhLMVHZBeASM c_(Claim ProcedureClaims)
		{
			bool? an_(Claim.ItemComponent ResponseItem)
			{
				bool? aq_(Coding ProductOrServiceCode)
				{
					var at_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var au_ = context.Operators.In<CqlCode>(at_, ProductOrServiceValueSet);

					return au_;
				};
				var ar_ = context.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), aq_);
				var as_ = context.Operators.Exists<Coding>(ar_);

				return as_;
			};
			var ao_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), an_);
			var ap_ = new Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = ProcedureClaims,
				ClaimID = ProcedureClaims?.IdElement,
				LineItems = ao_,
			};

			return ap_;
		};
		var d_ = context.Operators.SelectOrNull<Claim, Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services and Conditions")]
	public Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_and_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		var c_ = new Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = a_,
			MedicalClaim = b_,
		};
		var d_ = new Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			c_,
		};
		Tuple_FbAEUOYETObSHBafYbFNIeSNO e_(Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse)
		{
			Tuple_CAKcSTUVVXcPjYRXATiiRAEMg h_(Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				bool? o_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> r_(Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						bool? u_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var y_ = context.Operators.Convert<string>(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: null));
							var z_ = context.Operators.Convert<string>(pClaim?.Response?.Request?.ReferenceElement);
							var aa_ = NCQAFHIRBase_1_0_0.GetId(z_);
							var ab_ = context.Operators.Equal(y_, aa_);
							var ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							var ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							var ae_ = context.Operators.Equal(ac_, ad_);
							var af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						var v_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var x_ = context.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_, w_);

						return x_;
					};
					var s_ = context.Operators.SelectManyOrNull<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimAndResponse?.PaidMedicalClaimResponse, r_);
					var t_ = context.Operators.Exists<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(s_);

					return t_;
				};
				var p_ = context.Operators.WhereOrNull<Claim.ItemComponent>(medClaim?.LineItems, o_);
				var q_ = new Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			var i_ = context.Operators.SelectOrNull<Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimAndResponse?.MedicalClaim, h_);
			var j_ = new Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = i_,
			};
			var k_ = new Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				j_,
			};
			Tuple_FbAEUOYETObSHBafYbFNIeSNO l_(Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				Tuple_FbAEUOYETObSHBafYbFNIeSNO ag_()
				{
					bool al_()
					{
						bool? am_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var as_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return as_;
						};
						var an_ = context.Operators.WhereOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, am_);
						IEnumerable<Claim.ItemComponent> ao_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						var ap_ = context.Operators.SelectOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(an_, ao_);
						var aq_ = context.Operators.FlattenList<Claim.ItemComponent>(ap_);
						var ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);

						return (ar_ ?? false);
					};
					if (al_())
					{
						bool? at_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bf_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return bf_;
						};
						var au_ = context.Operators.WhereOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, at_);
						Tuple_DXaYeZVOEAELKIhLMVHZBeASM av_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.PaidClaim;
						var aw_ = context.Operators.SelectOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(au_, av_);
						bool? ax_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bg_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bg_;
						};
						var ay_ = context.Operators.WhereOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, ax_);
						IEnumerable<Claim.ItemComponent> az_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						var ba_ = context.Operators.SelectOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(ay_, az_);
						var bb_ = context.Operators.FlattenList<Claim.ItemComponent>(ba_);
						CqlInterval<CqlDateTime> bc_(Claim.ItemComponent PaidItem)
						{
							var bh_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced);

							return bh_;
						};
						var bd_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, bc_);
						var be_ = new Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = aw_,
							ServicePeriod = bd_,
						};

						return be_;
					}
					else
					{
						Tuple_FbAEUOYETObSHBafYbFNIeSNO bi_ = null;

						return (bi_ as Tuple_FbAEUOYETObSHBafYbFNIeSNO);
					};
				};
				var ah_ = new Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ag_(),
				};
				bool? ai_(Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bj_ = context.Operators.Not((bool?)(FinalList is null));

					return bj_;
				};
				var aj_ = context.Operators.WhereOrNull<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ah_, ai_);
				var ak_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_);

				return ak_;
			};
			var m_ = context.Operators.SelectOrNull<Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(k_, l_);
			var n_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(m_);

			return n_;
		};
		var f_ = context.Operators.SelectOrNull<Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var g_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Service and Condition")]
	public Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Service_and_Condition(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			a_,
		};
		Tuple_FbAEUOYETObSHBafYbFNIeSNO c_(Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse)
		{
			Tuple_FbAEUOYETObSHBafYbFNIeSNO j_()
			{
				if ((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
				{
					Tuple_FbAEUOYETObSHBafYbFNIeSNO k_ = null;

					return (k_ as Tuple_FbAEUOYETObSHBafYbFNIeSNO);
				}
				else
				{
					var l_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet);

					return l_;
				};
			};

			return j_();
		};
		var d_ = context.Operators.SelectOrNull<Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		var e_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);
		var f_ = new Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
		{
			e_,
		};
		bool? g_(Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
		{
			var m_ = context.Operators.Not((bool?)(FinalList is null));

			return m_;
		};
		var h_ = context.Operators.WhereOrNull<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_, g_);
		var i_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(h_);

		return i_;
	}

    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
	public IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_or_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			bool? e_(Claim.ItemComponent @this)
			{
				var ad_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

				return ad_;
			};
			var f_ = context.Operators.WhereOrNull<Claim.ItemComponent>(AllClaims?.Item, e_);
			CodeableConcept g_(Claim.ItemComponent @this) => 
				@this?.ProductOrService;
			var h_ = context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(f_, g_);
			bool? i_(CodeableConcept @this)
			{
				var ae_ = context.Operators.Not((bool?)(@this?.Coding is null));

				return ae_;
			};
			var j_ = context.Operators.WhereOrNull<CodeableConcept>(h_, i_);
			List<Coding> k_(CodeableConcept @this) => 
				@this?.Coding;
			var l_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(j_, k_);
			var m_ = context.Operators.FlattenList<Coding>(l_);
			bool? n_(Coding ProductOrServiceCode)
			{
				var af_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var ag_ = context.Operators.In<CqlCode>(af_, ProductOrServiceValueSet);

				return ag_;
			};
			var o_ = context.Operators.WhereOrNull<Coding>(m_, n_);
			var p_ = context.Operators.Exists<Coding>(o_);
			bool? q_(Claim.DiagnosisComponent @this)
			{
				var ah_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

				return ah_;
			};
			var r_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((AllClaims?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), q_);
			DataType s_(Claim.DiagnosisComponent @this) => 
				@this?.Diagnosis;
			var t_ = context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(r_, s_);
			bool? u_(DataType @this)
			{
				var ai_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				var aj_ = context.Operators.Not((bool?)(ai_ is null));

				return aj_;
			};
			var v_ = context.Operators.WhereOrNull<DataType>(t_, u_);
			object w_(DataType @this)
			{
				var ak_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return ak_;
			};
			var x_ = context.Operators.SelectOrNull<DataType, object>(v_, w_);
			var y_ = context.Operators.FlattenLateBoundList(x_);
			bool? z_(object DiagnosisCode)
			{
				var al_ = FHIRHelpers_4_0_001.ToCode((DiagnosisCode as Coding));
				var am_ = context.Operators.In<CqlCode>(al_, DiagnosisValueSet);

				return am_;
			};
			var aa_ = context.Operators.WhereOrNull<object>(y_, z_);
			var ab_ = context.Operators.Exists<object>(aa_);
			var ac_ = context.Operators.Or(p_, ab_);

			return ac_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);
		Tuple_DXaYeZVOEAELKIhLMVHZBeASM c_(Claim ProcedureClaims)
		{
			Tuple_DXaYeZVOEAELKIhLMVHZBeASM an_()
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
						var at_ = context.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), as_);
						var au_ = context.Operators.Exists<Coding>(at_);

						return au_;
					};
					var aq_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), ap_);
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
						var bb_ = context.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), ba_);
						var bc_ = context.Operators.Exists<Coding>(bb_);

						return bc_;
					};
					var ay_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), ax_);
					var az_ = new Tuple_DXaYeZVOEAELKIhLMVHZBeASM
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
						var bj_ = context.Operators.Equal(bi_?.Value, (int?)1);

						return bj_;
					};
					var bg_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), bf_);
					var bh_ = new Tuple_DXaYeZVOEAELKIhLMVHZBeASM
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
		var d_ = context.Operators.SelectOrNull<Claim, Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services or Conditions")]
	public Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		var c_ = new Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = a_,
			MedicalClaim = b_,
		};
		var d_ = new Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			c_,
		};
		Tuple_FbAEUOYETObSHBafYbFNIeSNO e_(Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse)
		{
			Tuple_CAKcSTUVVXcPjYRXATiiRAEMg h_(Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				bool? o_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> r_(Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						bool? u_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var y_ = context.Operators.Convert<string>(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: null));
							var z_ = context.Operators.Convert<string>(pClaim?.Response?.Request?.ReferenceElement);
							var aa_ = NCQAFHIRBase_1_0_0.GetId(z_);
							var ab_ = context.Operators.Equal(y_, aa_);
							var ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							var ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							var ae_ = context.Operators.Equal(ac_, ad_);
							var af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						var v_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var x_ = context.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_, w_);

						return x_;
					};
					var s_ = context.Operators.SelectManyOrNull<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimAndResponse?.PaidMedicalClaimResponse, r_);
					var t_ = context.Operators.Exists<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(s_);

					return t_;
				};
				var p_ = context.Operators.WhereOrNull<Claim.ItemComponent>(medClaim?.LineItems, o_);
				var q_ = new Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			var i_ = context.Operators.SelectOrNull<Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimAndResponse?.MedicalClaim, h_);
			var j_ = new Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = i_,
			};
			var k_ = new Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				j_,
			};
			Tuple_FbAEUOYETObSHBafYbFNIeSNO l_(Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				Tuple_FbAEUOYETObSHBafYbFNIeSNO ag_()
				{
					bool al_()
					{
						bool? am_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var as_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return as_;
						};
						var an_ = context.Operators.WhereOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, am_);
						IEnumerable<Claim.ItemComponent> ao_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						var ap_ = context.Operators.SelectOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(an_, ao_);
						var aq_ = context.Operators.FlattenList<Claim.ItemComponent>(ap_);
						var ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);

						return (ar_ ?? false);
					};
					if (al_())
					{
						bool? at_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bf_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return bf_;
						};
						var au_ = context.Operators.WhereOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, at_);
						Tuple_DXaYeZVOEAELKIhLMVHZBeASM av_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.PaidClaim;
						var aw_ = context.Operators.SelectOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(au_, av_);
						bool? ax_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bg_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bg_;
						};
						var ay_ = context.Operators.WhereOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, ax_);
						IEnumerable<Claim.ItemComponent> az_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						var ba_ = context.Operators.SelectOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(ay_, az_);
						var bb_ = context.Operators.FlattenList<Claim.ItemComponent>(ba_);
						CqlInterval<CqlDateTime> bc_(Claim.ItemComponent PaidItem)
						{
							var bh_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced);

							return bh_;
						};
						var bd_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, bc_);
						var be_ = new Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = aw_,
							ServicePeriod = bd_,
						};

						return be_;
					}
					else
					{
						Tuple_FbAEUOYETObSHBafYbFNIeSNO bi_ = null;

						return (bi_ as Tuple_FbAEUOYETObSHBafYbFNIeSNO);
					};
				};
				var ah_ = new Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ag_(),
				};
				bool? ai_(Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bj_ = context.Operators.Not((bool?)(FinalList is null));

					return bj_;
				};
				var aj_ = context.Operators.WhereOrNull<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ah_, ai_);
				var ak_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_);

				return ak_;
			};
			var m_ = context.Operators.SelectOrNull<Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(k_, l_);
			var n_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(m_);

			return n_;
		};
		var f_ = context.Operators.SelectOrNull<Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var g_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services or Conditions")]
	public Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			a_,
		};
		Tuple_FbAEUOYETObSHBafYbFNIeSNO c_(Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse)
		{
			Tuple_FbAEUOYETObSHBafYbFNIeSNO f_()
			{
				if ((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
				{
					Tuple_FbAEUOYETObSHBafYbFNIeSNO g_ = null;

					return (g_ as Tuple_FbAEUOYETObSHBafYbFNIeSNO);
				}
				else
				{
					var h_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet);

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		var e_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);

		return e_;
	}

    [CqlDeclaration("Get All Claims With Procedure Only")]
	public IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_Only(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			bool? e_(Claim.ItemComponent @this)
			{
				var q_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

				return q_;
			};
			var f_ = context.Operators.WhereOrNull<Claim.ItemComponent>(AllClaims?.Item, e_);
			CodeableConcept g_(Claim.ItemComponent @this) => 
				@this?.ProductOrService;
			var h_ = context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(f_, g_);
			bool? i_(CodeableConcept @this)
			{
				var r_ = context.Operators.Not((bool?)(@this?.Coding is null));

				return r_;
			};
			var j_ = context.Operators.WhereOrNull<CodeableConcept>(h_, i_);
			List<Coding> k_(CodeableConcept @this) => 
				@this?.Coding;
			var l_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(j_, k_);
			var m_ = context.Operators.FlattenList<Coding>(l_);
			bool? n_(Coding ProductOrServiceCode)
			{
				var s_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var t_ = context.Operators.In<CqlCode>(s_, ProductOrServiceValueSet);

				return t_;
			};
			var o_ = context.Operators.WhereOrNull<Coding>(m_, n_);
			var p_ = context.Operators.Exists<Coding>(o_);

			return p_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);
		Tuple_DXaYeZVOEAELKIhLMVHZBeASM c_(Claim AllClaims)
		{
			bool? u_(Claim.ItemComponent ResponseItem)
			{
				bool? x_(Coding ProductOrServiceCode)
				{
					var aa_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var ab_ = context.Operators.In<CqlCode>(aa_, ProductOrServiceValueSet);

					return ab_;
				};
				var y_ = context.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), x_);
				var z_ = context.Operators.Exists<Coding>(y_);

				return z_;
			};
			var v_ = context.Operators.WhereOrNull<Claim.ItemComponent>((AllClaims?.Item as IEnumerable<Claim.ItemComponent>), u_);
			var w_ = new Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = AllClaims,
				ClaimID = AllClaims?.IdElement,
				LineItems = v_,
			};

			return w_;
		};
		var d_ = context.Operators.SelectOrNull<Claim, Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services Only")]
	public Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_Only(claim, ProductOrServiceValueSet);
		var c_ = new Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = a_,
			MedicalClaim = b_,
		};
		var d_ = new Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			c_,
		};
		Tuple_FbAEUOYETObSHBafYbFNIeSNO e_(Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse)
		{
			Tuple_CAKcSTUVVXcPjYRXATiiRAEMg h_(Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				bool? o_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> r_(Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						bool? u_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var y_ = context.Operators.Convert<string>(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: null));
							var z_ = context.Operators.Convert<string>(pClaim?.Response?.Request?.ReferenceElement);
							var aa_ = NCQAFHIRBase_1_0_0.GetId(z_);
							var ab_ = context.Operators.Equal(y_, aa_);
							var ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							var ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							var ae_ = context.Operators.Equal(ac_, ad_);
							var af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						var v_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var x_ = context.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_, w_);

						return x_;
					};
					var s_ = context.Operators.SelectManyOrNull<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimAndResponse?.PaidMedicalClaimResponse, r_);
					var t_ = context.Operators.Exists<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(s_);

					return t_;
				};
				var p_ = context.Operators.WhereOrNull<Claim.ItemComponent>(medClaim?.LineItems, o_);
				var q_ = new Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			var i_ = context.Operators.SelectOrNull<Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimAndResponse?.MedicalClaim, h_);
			var j_ = new Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = i_,
			};
			var k_ = new Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				j_,
			};
			Tuple_FbAEUOYETObSHBafYbFNIeSNO l_(Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				Tuple_FbAEUOYETObSHBafYbFNIeSNO ag_()
				{
					bool al_()
					{
						bool? am_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var as_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return as_;
						};
						var an_ = context.Operators.WhereOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, am_);
						IEnumerable<Claim.ItemComponent> ao_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						var ap_ = context.Operators.SelectOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(an_, ao_);
						var aq_ = context.Operators.FlattenList<Claim.ItemComponent>(ap_);
						var ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);

						return (ar_ ?? false);
					};
					if (al_())
					{
						bool? at_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bf_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return bf_;
						};
						var au_ = context.Operators.WhereOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, at_);
						Tuple_DXaYeZVOEAELKIhLMVHZBeASM av_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.PaidClaim;
						var aw_ = context.Operators.SelectOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(au_, av_);
						bool? ax_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var bg_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bg_;
						};
						var ay_ = context.Operators.WhereOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, ax_);
						IEnumerable<Claim.ItemComponent> az_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						var ba_ = context.Operators.SelectOrNull<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(ay_, az_);
						var bb_ = context.Operators.FlattenList<Claim.ItemComponent>(ba_);
						CqlInterval<CqlDateTime> bc_(Claim.ItemComponent PaidItem)
						{
							var bh_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced);

							return bh_;
						};
						var bd_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, bc_);
						var be_ = new Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = aw_,
							ServicePeriod = bd_,
						};

						return be_;
					}
					else
					{
						Tuple_FbAEUOYETObSHBafYbFNIeSNO bi_ = null;

						return (bi_ as Tuple_FbAEUOYETObSHBafYbFNIeSNO);
					};
				};
				var ah_ = new Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ag_(),
				};
				bool? ai_(Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bj_ = context.Operators.Not((bool?)(FinalList is null));

					return bj_;
				};
				var aj_ = context.Operators.WhereOrNull<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ah_, ai_);
				var ak_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_);

				return ak_;
			};
			var m_ = context.Operators.SelectOrNull<Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(k_, l_);
			var n_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(m_);

			return n_;
		};
		var f_ = context.Operators.SelectOrNull<Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var g_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services Only")]
	public Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			a_,
		};
		Tuple_FbAEUOYETObSHBafYbFNIeSNO c_(Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse)
		{
			Tuple_FbAEUOYETObSHBafYbFNIeSNO f_()
			{
				if ((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
				{
					Tuple_FbAEUOYETObSHBafYbFNIeSNO g_ = null;

					return (g_ as Tuple_FbAEUOYETObSHBafYbFNIeSNO);
				}
				else
				{
					var h_ = this.Get_Corresponding_Claim_for_Services_Only(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet);

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		var e_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);

		return e_;
	}

    [CqlDeclaration("Get All Pharmacy Claims and Claim Responses")]
	public Tuple_ENRfaLDabXeaNdJYVdOfebBTR Get_All_Pharmacy_Claims_and_Claim_Responses(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		var a_ = this.Pharmacy_Claims_Response(claimResponse);
		var b_ = this.Pharmacy_Claims(claim);
		var c_ = new Tuple_ENRfaLDabXeaNdJYVdOfebBTR
		{
			PharmacyClaimResponse = a_,
			PharmacyClaim = b_,
		};

		return c_;
	}

    [CqlDeclaration("Get Corresponding Claim for Pharmacy Services")]
	public Tuple_BOANHMYNiCIfFjRZRMEXCcXTO Get_Corresponding_Claim_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var b_ = this.Pharmacy_Claim_With_Medication(claim, ProductOrServiceValueSet);
		var c_ = new Tuple_EDASHZgEHSQJbecPJIZegfOIB
		{
			PaidPharmacyClaimResponse = a_,
			MedicalClaim = b_,
		};
		var d_ = new Tuple_EDASHZgEHSQJbecPJIZegfOIB[]
		{
			c_,
		};
		Tuple_BOANHMYNiCIfFjRZRMEXCcXTO e_(Tuple_EDASHZgEHSQJbecPJIZegfOIB ClaimAndResponse)
		{
			Tuple_DgRFfDaEDhBINgYbMaeRWZWVT h_(Tuple_FOLKddIQBPRMYYfjeMUjEIBhC medClaim)
			{
				bool? o_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> r_(Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						bool? u_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var y_ = context.Operators.Convert<string>(((medClaim?.Claim is Resource)
									? ((medClaim?.Claim as Resource).IdElement)
									: null));
							var z_ = context.Operators.Convert<string>(pClaim?.Response?.Request?.ReferenceElement);
							var aa_ = NCQAFHIRBase_1_0_0.GetId(z_);
							var ab_ = context.Operators.Equal(y_, aa_);
							var ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							var ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							var ae_ = context.Operators.Equal(ac_, ad_);
							var af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						var v_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var x_ = context.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_, w_);

						return x_;
					};
					var s_ = context.Operators.SelectManyOrNull<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimAndResponse?.PaidPharmacyClaimResponse, r_);
					var t_ = context.Operators.Exists<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(s_);

					return t_;
				};
				var p_ = context.Operators.WhereOrNull<Claim.ItemComponent>(medClaim?.LineItem, o_);
				var q_ = new Tuple_DgRFfDaEDhBINgYbMaeRWZWVT
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			var i_ = context.Operators.SelectOrNull<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC, Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimAndResponse?.MedicalClaim, h_);
			var j_ = new Tuple_DOALBUVOFWRHAUjdPUNBfNdUB
			{
				AggregateClaim = i_,
			};
			var k_ = new Tuple_DOALBUVOFWRHAUjdPUNBfNdUB[]
			{
				j_,
			};
			Tuple_BOANHMYNiCIfFjRZRMEXCcXTO l_(Tuple_DOALBUVOFWRHAUjdPUNBfNdUB ClaimWithPaidResponse)
			{
				Tuple_BOANHMYNiCIfFjRZRMEXCcXTO ag_()
				{
					bool al_()
					{
						bool? am_(Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var as_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return as_;
						};
						var an_ = context.Operators.WhereOrNull<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, am_);
						IEnumerable<Claim.ItemComponent> ao_(Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => 
							@this?.ClaimItem;
						var ap_ = context.Operators.SelectOrNull<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(an_, ao_);
						var aq_ = context.Operators.FlattenList<Claim.ItemComponent>(ap_);
						var ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);

						return (ar_ ?? false);
					};
					if (al_())
					{
						bool? at_(Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var bm_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return bm_;
						};
						var au_ = context.Operators.WhereOrNull<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, at_);
						Tuple_FOLKddIQBPRMYYfjeMUjEIBhC av_(Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => 
							@this?.PaidClaim;
						var aw_ = context.Operators.SelectOrNull<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(au_, av_);
						bool? ax_(Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var bn_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bn_;
						};
						var ay_ = context.Operators.WhereOrNull<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, ax_);
						IEnumerable<Claim.ItemComponent> az_(Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => 
							@this?.ClaimItem;
						var ba_ = context.Operators.SelectOrNull<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(ay_, az_);
						var bb_ = context.Operators.FlattenList<Claim.ItemComponent>(ba_);
						CqlInterval<CqlDateTime> bc_(Claim.ItemComponent PaidItem)
						{
							var bo_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced);

							return bo_;
						};
						var bd_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, bc_);
						bool? be_(Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var bp_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bp_;
						};
						var bf_ = context.Operators.WhereOrNull<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, be_);
						var bh_ = context.Operators.SelectOrNull<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(bf_, az_);
						var bi_ = context.Operators.FlattenList<Claim.ItemComponent>(bh_);
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
									var by_ = context.Operators.Quantity((decimal?)1m, "day");
									var bz_ = context.Operators.Subtract(bx_, by_);
									var ca_ = context.Operators.ConvertDateTimeToDate(bz_);
									var cb_ = context.Operators.Interval(bt_, ca_, (bool?)true, (bool?)true);

									return cb_;
								}
								else
								{
									CqlInterval<CqlDate> cc_ = null;

									return (cc_ as CqlInterval<CqlDate>);
								};
							};

							return bq_();
						};
						var bk_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDate>>(bi_, bj_);
						var bl_ = new Tuple_BOANHMYNiCIfFjRZRMEXCcXTO
						{
							originalClaim = aw_,
							ServicePeriod = bd_,
							CoveredDays = bk_,
						};

						return bl_;
					}
					else
					{
						Tuple_BOANHMYNiCIfFjRZRMEXCcXTO cd_ = null;

						return (cd_ as Tuple_BOANHMYNiCIfFjRZRMEXCcXTO);
					};
				};
				var ah_ = new Tuple_BOANHMYNiCIfFjRZRMEXCcXTO[]
				{
					ag_(),
				};
				bool? ai_(Tuple_BOANHMYNiCIfFjRZRMEXCcXTO FinalList)
				{
					var ce_ = context.Operators.Not((bool?)(FinalList is null));

					return ce_;
				};
				var aj_ = context.Operators.WhereOrNull<Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(ah_, ai_);
				var ak_ = context.Operators.SingletonFrom<Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(aj_);

				return ak_;
			};
			var m_ = context.Operators.SelectOrNull<Tuple_DOALBUVOFWRHAUjdPUNBfNdUB, Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(k_, l_);
			var n_ = context.Operators.SingletonFrom<Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(m_);

			return n_;
		};
		var f_ = context.Operators.SelectOrNull<Tuple_EDASHZgEHSQJbecPJIZegfOIB, Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(d_, e_);
		var g_ = context.Operators.SingletonFrom<Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Pharmacy Services")]
	public Tuple_BOANHMYNiCIfFjRZRMEXCcXTO Get_Paid_Claims_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuple_ENRfaLDabXeaNdJYVdOfebBTR[]
		{
			a_,
		};
		Tuple_BOANHMYNiCIfFjRZRMEXCcXTO c_(Tuple_ENRfaLDabXeaNdJYVdOfebBTR PharmacyClaimAndResponse)
		{
			Tuple_BOANHMYNiCIfFjRZRMEXCcXTO f_()
			{
				if ((context.Operators.And((bool?)(PharmacyClaimAndResponse?.PharmacyClaimResponse is null), (bool?)(PharmacyClaimAndResponse?.PharmacyClaim is null)) ?? false))
				{
					Tuple_BOANHMYNiCIfFjRZRMEXCcXTO g_ = null;

					return (g_ as Tuple_BOANHMYNiCIfFjRZRMEXCcXTO);
				}
				else
				{
					var h_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(PharmacyClaimAndResponse?.PharmacyClaimResponse, PharmacyClaimAndResponse?.PharmacyClaim, ProductOrServiceValueSet);

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Tuple_ENRfaLDabXeaNdJYVdOfebBTR, Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(b_, c_);
		var e_ = context.Operators.SingletonFrom<Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(d_);

		return e_;
	}

    [CqlDeclaration("Get Claim With Corresponding Claim Response")]
	public IEnumerable<Tuple_HQUdYchKGNXjEWMCbcWSEKdVI> Get_Claim_With_Corresponding_Claim_Response(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		Tuple_HQUdYchKGNXjEWMCbcWSEKdVI a_(Claim Claim)
		{
			bool? c_(ClaimResponse CR)
			{
				var h_ = context.Operators.Convert<string>(Claim?.IdElement);
				var i_ = context.Operators.Convert<string>(CR?.Request?.ReferenceElement);
				var j_ = NCQAFHIRBase_1_0_0.GetId(i_);
				var k_ = context.Operators.Equal(h_, j_);

				return k_;
			};
			var d_ = context.Operators.WhereOrNull<ClaimResponse>(claimResponse, c_);
			bool? e_(Claim C)
			{
				var l_ = context.Operators.Convert<string>(Claim?.IdElement);
				bool? m_(ClaimResponse CR)
				{
					var aa_ = context.Operators.Convert<string>(Claim?.IdElement);
					var ab_ = context.Operators.Convert<string>(CR?.Request?.ReferenceElement);
					var ac_ = NCQAFHIRBase_1_0_0.GetId(ab_);
					var ad_ = context.Operators.Equal(aa_, ac_);

					return ad_;
				};
				var n_ = context.Operators.WhereOrNull<ClaimResponse>(claimResponse, m_);
				bool? o_(ClaimResponse @this)
				{
					var ae_ = context.Operators.Not((bool?)(@this?.Request is null));

					return ae_;
				};
				var p_ = context.Operators.WhereOrNull<ClaimResponse>(n_, o_);
				ResourceReference q_(ClaimResponse @this) => 
					@this?.Request;
				var r_ = context.Operators.SelectOrNull<ClaimResponse, ResourceReference>(p_, q_);
				bool? s_(ResourceReference @this)
				{
					var af_ = context.Operators.Not((bool?)(@this?.ReferenceElement is null));

					return af_;
				};
				var t_ = context.Operators.WhereOrNull<ResourceReference>(r_, s_);
				FhirString u_(ResourceReference @this) => 
					@this?.ReferenceElement;
				var v_ = context.Operators.SelectOrNull<ResourceReference, FhirString>(t_, u_);
				var w_ = context.Operators.SingletonFrom<FhirString>(v_);
				var x_ = context.Operators.Convert<string>(w_);
				var y_ = NCQAFHIRBase_1_0_0.GetId(x_);
				var z_ = context.Operators.Equal(l_, y_);

				return z_;
			};
			var f_ = context.Operators.WhereOrNull<Claim>(claim, e_);
			var g_ = new Tuple_HQUdYchKGNXjEWMCbcWSEKdVI
			{
				ClaimResponse = d_,
				OriginalClaim = f_,
			};

			return g_;
		};
		var b_ = context.Operators.SelectOrNull<Claim, Tuple_HQUdYchKGNXjEWMCbcWSEKdVI>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Medical Claims With Nonacute or Acute Inpatient Discharge")]
	public Tuple_CYfZbbEjJgLODachBhLiZaXQE Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(IEnumerable<Claim> claim)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		var b_ = new Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = a_,
		};
		var c_ = new Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			b_,
		};
		Tuple_CYfZbbEjJgLODachBhLiZaXQE d_(Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithInpatientStay)
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
					bool? o_(Claim c)
					{
						bool? q_(Claim.ItemComponent i)
						{
							var t_ = FHIRHelpers_4_0_001.ToConcept(i?.Revenue);
							bool? u_(CqlCode rev)
							{
								var x_ = this.Inpatient_Stay();
								var y_ = context.Operators.StringInValueSet(rev?.code, x_);

								return y_;
							};
							var v_ = context.Operators.WhereOrNull<CqlCode>((t_?.codes as IEnumerable<CqlCode>), u_);
							var w_ = context.Operators.Exists<CqlCode>(v_);

							return w_;
						};
						var r_ = context.Operators.WhereOrNull<Claim.ItemComponent>((c?.Item as IEnumerable<Claim.ItemComponent>), q_);
						var s_ = context.Operators.Exists<Claim.ItemComponent>(r_);

						return s_;
					};
					var p_ = context.Operators.WhereOrNull<Claim>(ClaimWithInpatientStay?.MedicalClaim, o_);

					return p_;
				};
			};
			IEnumerable<Claim> h_()
			{
				if ((ClaimWithInpatientStay?.MedicalClaim is null))
				{
					IEnumerable<Claim> z_ = null;

					return (z_ as IEnumerable<Claim>);
				}
				else
				{
					bool? aa_(Claim c)
					{
						bool? ac_(Claim.ItemComponent i)
						{
							var aj_ = FHIRHelpers_4_0_001.ToConcept(i?.Revenue);
							bool? ak_(CqlCode rev)
							{
								var an_ = this.Nonacute_Inpatient_Stay();
								var ao_ = context.Operators.StringInValueSet(rev?.code, an_);

								return ao_;
							};
							var al_ = context.Operators.WhereOrNull<CqlCode>((aj_?.codes as IEnumerable<CqlCode>), ak_);
							var am_ = context.Operators.Exists<CqlCode>(al_);

							return am_;
						};
						var ad_ = context.Operators.WhereOrNull<Claim.ItemComponent>((c?.Item as IEnumerable<Claim.ItemComponent>), ac_);
						var ae_ = context.Operators.Exists<Claim.ItemComponent>(ad_);
						bool? af_(Coding tob)
						{
							var ap_ = this.Nonacute_Inpatient_Stay();
							var aq_ = context.Operators.StringInValueSet(tob?.CodeElement?.Value, ap_);

							return aq_;
						};
						var ag_ = context.Operators.WhereOrNull<Coding>((c?.SubType?.Coding as IEnumerable<Coding>), af_);
						var ah_ = context.Operators.Exists<Coding>(ag_);
						var ai_ = context.Operators.Or(ae_, ah_);

						return ai_;
					};
					var ab_ = context.Operators.WhereOrNull<Claim>(ClaimWithInpatientStay?.MedicalClaim, aa_);

					return ab_;
				};
			};
			var i_ = new Tuple_BcRbRSiZXcAFIKNCdPcQULMGb
			{
				InpatientStayLineItems = g_(),
				NonacuteInpatientLineItems = h_(),
			};
			var j_ = new Tuple_BcRbRSiZXcAFIKNCdPcQULMGb[]
			{
				i_,
			};
			Tuple_CYfZbbEjJgLODachBhLiZaXQE k_(Tuple_BcRbRSiZXcAFIKNCdPcQULMGb LineItemDefinition)
			{
				IEnumerable<Claim> ar_(Claim nonAcuteInpatientStay)
				{
					bool? ax_(Claim inpatientStay)
					{
						var bb_ = context.Operators.Equal(nonAcuteInpatientStay?.IdElement, inpatientStay?.IdElement);

						return bb_;
					};
					var ay_ = context.Operators.WhereOrNull<Claim>(LineItemDefinition?.InpatientStayLineItems, ax_);
					Claim az_(Claim inpatientStay) => 
						nonAcuteInpatientStay;
					var ba_ = context.Operators.SelectOrNull<Claim, Claim>(ay_, az_);

					return ba_;
				};
				var as_ = context.Operators.SelectManyOrNull<Claim, Claim>(LineItemDefinition?.NonacuteInpatientLineItems, ar_);
				IEnumerable<Claim> at_(Claim inpatientStay)
				{
					bool? bc_(Claim nonAcuteInpatientStay)
					{
						var bg_ = context.Operators.Equal(inpatientStay?.IdElement, nonAcuteInpatientStay?.IdElement);

						return bg_;
					};
					var bd_ = context.Operators.WhereOrNull<Claim>(LineItemDefinition?.NonacuteInpatientLineItems, bc_);
					Claim be_(Claim nonAcuteInpatientStay) => 
						inpatientStay;
					var bf_ = context.Operators.SelectOrNull<Claim, Claim>(bd_, be_);

					return bf_;
				};
				var au_ = context.Operators.SelectManyOrNull<Claim, Claim>(LineItemDefinition?.InpatientStayLineItems, at_);
				var av_ = context.Operators.ListExcept<Claim>(LineItemDefinition?.InpatientStayLineItems, au_);
				var aw_ = new Tuple_CYfZbbEjJgLODachBhLiZaXQE
				{
					InpatientDischarge = LineItemDefinition?.InpatientStayLineItems,
					NonacuteInpatientDischarge = as_,
					AcuteInpatientDischarge = av_,
				};

				return aw_;
			};
			var l_ = context.Operators.SelectOrNull<Tuple_BcRbRSiZXcAFIKNCdPcQULMGb, Tuple_CYfZbbEjJgLODachBhLiZaXQE>(j_, k_);
			var m_ = context.Operators.SingletonFrom<Tuple_CYfZbbEjJgLODachBhLiZaXQE>(l_);

			return m_;
		};
		var e_ = context.Operators.SelectOrNull<Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, Tuple_CYfZbbEjJgLODachBhLiZaXQE>(c_, d_);
		var f_ = context.Operators.SingletonFrom<Tuple_CYfZbbEjJgLODachBhLiZaXQE>(e_);

		return f_;
	}

    [CqlDeclaration("Get Prescriber NPI from Claims")]
	public Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Prescriber_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		Tuple_GIfhUVACThMQNGPGjYhYHEfGS a_(Claim C)
		{
			bool? h_(Claim.CareTeamComponent ct)
			{
				var w_ = context.Operators.Convert<Integer>(ct?.SequenceElement);
				var x_ = FHIRHelpers_4_0_001.ToInteger(w_);
				var y_ = context.Operators.Equal(x_, (int?)1);

				return y_;
			};
			var i_ = context.Operators.WhereOrNull<Claim.CareTeamComponent>((C?.CareTeam as IEnumerable<Claim.CareTeamComponent>), h_);
			bool? j_(Claim.CareTeamComponent @this)
			{
				var z_ = context.Operators.Not((bool?)(@this?.Provider is null));

				return z_;
			};
			var k_ = context.Operators.WhereOrNull<Claim.CareTeamComponent>(i_, j_);
			ResourceReference l_(Claim.CareTeamComponent @this) => 
				@this?.Provider;
			var m_ = context.Operators.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(k_, l_);
			bool? n_(Claim.CareTeamComponent ct)
			{
				var aa_ = context.Operators.Convert<Integer>(ct?.SequenceElement);
				var ab_ = FHIRHelpers_4_0_001.ToInteger(aa_);
				var ac_ = context.Operators.Equal(ab_, (int?)1);

				return ac_;
			};
			var o_ = context.Operators.WhereOrNull<Claim.CareTeamComponent>((C?.CareTeam as IEnumerable<Claim.CareTeamComponent>), n_);
			bool? p_(Claim.CareTeamComponent @this)
			{
				var ad_ = context.Operators.Not((bool?)(@this?.Provider is null));

				return ad_;
			};
			var q_ = context.Operators.WhereOrNull<Claim.CareTeamComponent>(o_, p_);
			var s_ = context.Operators.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(q_, l_);
			string t_(ResourceReference p)
			{
				var ae_ = new FhirString[]
				{
					p?.ReferenceElement,
				};
				string af_(FhirString r)
				{
					var ai_ = context.Operators.Convert<string>(r);
					var aj_ = NCQAFHIRBase_1_0_0.GetId(ai_);

					return aj_;
				};
				var ag_ = context.Operators.SelectOrNull<FhirString, string>(ae_, af_);
				var ah_ = context.Operators.SingletonFrom<string>(ag_);

				return ah_;
			};
			var u_ = context.Operators.SelectOrNull<ResourceReference, string>(s_, t_);
			var v_ = new Tuple_GIfhUVACThMQNGPGjYhYHEfGS
			{
				SingleCareTeam = C,
				CareTeamsProvider = m_,
				CareTeamsProviderID = u_,
			};

			return v_;
		};
		var b_ = context.Operators.SelectOrNull<Claim, Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(claim, a_);
		var c_ = new Tuple_GMJgYefQcULgUcRJJAbTfRThR
		{
			CareTeams = b_,
		};
		var d_ = new Tuple_GMJgYefQcULgUcRJJAbTfRThR[]
		{
			c_,
		};
		Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY e_(Tuple_GMJgYefQcULgUcRJJAbTfRThR ClaimProperties)
		{
			var ak_ = context.Operators.RetrieveByValueSet<Practitioner>(null, null);
			bool? al_(Practitioner p)
			{
				var as_ = context.Operators.Convert<string>(p?.IdElement);
				bool? at_(Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
				{
					var az_ = context.Operators.Not((bool?)(@this?.CareTeamsProviderID is null));

					return az_;
				};
				var au_ = context.Operators.WhereOrNull<Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, at_);
				IEnumerable<string> av_(Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => 
					@this?.CareTeamsProviderID;
				var aw_ = context.Operators.SelectOrNull<Tuple_GIfhUVACThMQNGPGjYhYHEfGS, IEnumerable<string>>(au_, av_);
				var ax_ = context.Operators.FlattenList<string>(aw_);
				var ay_ = context.Operators.In<string>(as_, ax_);

				return ay_;
			};
			var am_ = context.Operators.WhereOrNull<Practitioner>(ak_, al_);
			var an_ = new Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe
			{
				Practitioners = am_,
			};
			var ao_ = new Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe[]
			{
				an_,
			};
			Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY ap_(Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe PractitionerMatch)
			{
				bool? ba_(Practitioner P)
				{
					var bj_ = context.Operators.Not((bool?)(P is null));

					return bj_;
				};
				var bb_ = context.Operators.WhereOrNull<Practitioner>(PractitionerMatch?.Practitioners, ba_);
				Tuple_FNLPNAPOaaMjChWUXdhfgcWIR bc_(Practitioner P)
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
					var bl_ = context.Operators.WhereOrNull<Identifier>((P?.Identifier as IEnumerable<Identifier>), bk_);
					FhirString bm_(Identifier l) => 
						l?.ValueElement;
					var bn_ = context.Operators.SelectOrNull<Identifier, FhirString>(bl_, bm_);
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
					var bp_ = context.Operators.WhereOrNull<Identifier>((P?.Identifier as IEnumerable<Identifier>), bo_);
					Identifier bq_(Identifier l) => 
						l;
					var br_ = context.Operators.SelectOrNull<Identifier, Identifier>(bp_, bq_);
					var bs_ = new Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = bn_,
						NullIdentifiers = br_,
					};

					return bs_;
				};
				var bd_ = context.Operators.SelectOrNull<Practitioner, Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(bb_, bc_);
				var be_ = new Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = bd_,
				};
				var bf_ = new Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					be_,
				};
				Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY bg_(Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers)
				{
					int? ci_()
					{
						bool ck_()
						{
							bool? cl_(Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
							{
								var cq_ = context.Operators.Not((bool?)(@this?.SingleCareTeam is null));

								return cq_;
							};
							var cm_ = context.Operators.WhereOrNull<Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, cl_);
							Claim cn_(Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => 
								@this?.SingleCareTeam;
							var co_ = context.Operators.SelectOrNull<Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(cm_, cn_);
							var cp_ = context.Operators.Exists<Claim>(co_);

							return (cp_ ?? false);
						};
						if (ck_())
						{
							bool? cr_(Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
							{
								var dk_ = context.Operators.Not((bool?)(@this?.SingleCareTeam is null));

								return dk_;
							};
							var cs_ = context.Operators.WhereOrNull<Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, cr_);
							Claim ct_(Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => 
								@this?.SingleCareTeam;
							var cu_ = context.Operators.SelectOrNull<Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(cs_, ct_);
							bool? cv_(Claim X) => 
								(bool?)((X?.CareTeam as IEnumerable<Claim.CareTeamComponent>) is null);
							var cw_ = context.Operators.WhereOrNull<Claim>(cu_, cv_);
							var cx_ = context.Operators.Count<Claim>(cw_);
							IEnumerable<FhirString> cy_(Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => 
								X?.AllIdentifiers;
							var cz_ = context.Operators.SelectOrNull<Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, cy_);
							var da_ = context.Operators.FlattenList<FhirString>(cz_);
							FhirString db_(FhirString X) => 
								X;
							var dc_ = context.Operators.SelectOrNull<FhirString, FhirString>(da_, db_);
							var dd_ = context.Operators.Count<FhirString>(dc_);
							var de_ = context.Operators.Add(cx_, dd_);
							IEnumerable<Identifier> df_(Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => 
								X?.NullIdentifiers;
							var dg_ = context.Operators.SelectOrNull<Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, df_);
							var dh_ = context.Operators.FlattenList<Identifier>(dg_);
							var di_ = context.Operators.Count<Identifier>(dh_);
							var dj_ = context.Operators.Add(de_, di_);

							return dj_;
						}
						else
						{
							return (int?)0;
						};
					};
					var cj_ = new Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = ci_(),
					};

					return cj_;
				};
				var bh_ = context.Operators.SelectOrNull<Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bf_, bg_);
				var bi_ = context.Operators.SingletonFrom<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bh_);

				return bi_;
			};
			var aq_ = context.Operators.SelectOrNull<Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe, Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ao_, ap_);
			var ar_ = context.Operators.SingletonFrom<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(aq_);

			return ar_;
		};
		var f_ = context.Operators.SelectOrNull<Tuple_GMJgYefQcULgUcRJJAbTfRThR, Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(d_, e_);
		var g_ = context.Operators.SingletonFrom<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(f_);

		return g_;
	}

    [CqlDeclaration("Get Pharmacy NPI from Claims")]
	public Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Pharmacy_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		Tuple_FPCXihcEeChSjIUJHVXRcEXMI a_(Claim C)
		{
			bool? h_(Claim.ItemComponent i)
			{
				var y_ = context.Operators.Convert<Integer>(i?.SequenceElement);
				var z_ = FHIRHelpers_4_0_001.ToInteger(y_);
				var aa_ = context.Operators.Equal(z_, (int?)1);

				return aa_;
			};
			var i_ = context.Operators.WhereOrNull<Claim.ItemComponent>((C?.Item as IEnumerable<Claim.ItemComponent>), h_);
			bool? j_(Claim.ItemComponent @this)
			{
				var ab_ = context.Operators.Not((bool?)(@this?.Location is null));

				return ab_;
			};
			var k_ = context.Operators.WhereOrNull<Claim.ItemComponent>(i_, j_);
			DataType l_(Claim.ItemComponent @this) => 
				@this?.Location;
			var m_ = context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(k_, l_);
			ResourceReference n_(DataType l) => 
				(l as ResourceReference);
			var o_ = context.Operators.SelectOrNull<DataType, ResourceReference>(m_, n_);
			bool? p_(Claim.ItemComponent i)
			{
				var ac_ = context.Operators.Convert<Integer>(i?.SequenceElement);
				var ad_ = FHIRHelpers_4_0_001.ToInteger(ac_);
				var ae_ = context.Operators.Equal(ad_, (int?)1);

				return ae_;
			};
			var q_ = context.Operators.WhereOrNull<Claim.ItemComponent>((C?.Item as IEnumerable<Claim.ItemComponent>), p_);
			bool? r_(Claim.ItemComponent @this)
			{
				var af_ = context.Operators.Not((bool?)(@this?.Location is null));

				return af_;
			};
			var s_ = context.Operators.WhereOrNull<Claim.ItemComponent>(q_, r_);
			var u_ = context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(s_, l_);
			string v_(DataType l)
			{
				var ag_ = new FhirString[]
				{
					(l as ResourceReference)?.ReferenceElement,
				};
				string ah_(FhirString r)
				{
					var ak_ = context.Operators.Convert<string>(r);
					var al_ = NCQAFHIRBase_1_0_0.GetId(ak_);

					return al_;
				};
				var ai_ = context.Operators.SelectOrNull<FhirString, string>(ag_, ah_);
				var aj_ = context.Operators.SingletonFrom<string>(ai_);

				return aj_;
			};
			var w_ = context.Operators.SelectOrNull<DataType, string>(u_, v_);
			var x_ = new Tuple_FPCXihcEeChSjIUJHVXRcEXMI
			{
				SingleItem = (C?.Item as IEnumerable<Claim.ItemComponent>),
				ItemLocation = o_,
				ItemLocationID = w_,
			};

			return x_;
		};
		var b_ = context.Operators.SelectOrNull<Claim, Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(claim, a_);
		var c_ = new Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa
		{
			ItemsLocationReferences = b_,
		};
		var d_ = new Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa[]
		{
			c_,
		};
		Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY e_(Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa ClaimProperties)
		{
			var am_ = context.Operators.RetrieveByValueSet<Location>(null, null);
			bool? an_(Location l)
			{
				var au_ = context.Operators.Convert<string>(l?.IdElement);
				bool? av_(Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
				{
					var bb_ = context.Operators.Not((bool?)(@this?.ItemLocationID is null));

					return bb_;
				};
				var aw_ = context.Operators.WhereOrNull<Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, av_);
				IEnumerable<string> ax_(Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => 
					@this?.ItemLocationID;
				var ay_ = context.Operators.SelectOrNull<Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<string>>(aw_, ax_);
				var az_ = context.Operators.FlattenList<string>(ay_);
				var ba_ = context.Operators.In<string>(au_, az_);

				return ba_;
			};
			var ao_ = context.Operators.WhereOrNull<Location>(am_, an_);
			var ap_ = new Tuple_CZQfDISCFaOQaLKEbbAcDRfcP
			{
				CorrespondingLocations = ao_,
			};
			var aq_ = new Tuple_CZQfDISCFaOQaLKEbbAcDRfcP[]
			{
				ap_,
			};
			Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY ar_(Tuple_CZQfDISCFaOQaLKEbbAcDRfcP GetLocation)
			{
				bool? bc_(Location C)
				{
					var bl_ = context.Operators.Not((bool?)(C is null));

					return bl_;
				};
				var bd_ = context.Operators.WhereOrNull<Location>(GetLocation?.CorrespondingLocations, bc_);
				Tuple_FNLPNAPOaaMjChWUXdhfgcWIR be_(Location C)
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
					var bn_ = context.Operators.WhereOrNull<Identifier>((C?.Identifier as IEnumerable<Identifier>), bm_);
					FhirString bo_(Identifier l) => 
						l?.ValueElement;
					var bp_ = context.Operators.SelectOrNull<Identifier, FhirString>(bn_, bo_);
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
					var br_ = context.Operators.WhereOrNull<Identifier>((C?.Identifier as IEnumerable<Identifier>), bq_);
					Identifier bs_(Identifier l) => 
						l;
					var bt_ = context.Operators.SelectOrNull<Identifier, Identifier>(br_, bs_);
					var bu_ = new Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = bp_,
						NullIdentifiers = bt_,
					};

					return bu_;
				};
				var bf_ = context.Operators.SelectOrNull<Location, Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(bd_, be_);
				var bg_ = new Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = bf_,
				};
				var bh_ = new Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					bg_,
				};
				Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY bi_(Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers)
				{
					int? ck_()
					{
						bool cm_()
						{
							bool? cn_(Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
							{
								var ct_ = context.Operators.Not((bool?)(@this?.SingleItem is null));

								return ct_;
							};
							var co_ = context.Operators.WhereOrNull<Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, cn_);
							IEnumerable<Claim.ItemComponent> cp_(Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => 
								@this?.SingleItem;
							var cq_ = context.Operators.SelectOrNull<Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<Claim.ItemComponent>>(co_, cp_);
							var cr_ = context.Operators.FlattenList<Claim.ItemComponent>(cq_);
							var cs_ = context.Operators.Exists<Claim.ItemComponent>(cr_);

							return (cs_ ?? false);
						};
						if (cm_())
						{
							bool? cu_(Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
							{
								var do_ = context.Operators.Not((bool?)(@this?.ItemLocation is null));

								return do_;
							};
							var cv_ = context.Operators.WhereOrNull<Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, cu_);
							IEnumerable<ResourceReference> cw_(Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => 
								@this?.ItemLocation;
							var cx_ = context.Operators.SelectOrNull<Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<ResourceReference>>(cv_, cw_);
							var cy_ = context.Operators.FlattenList<ResourceReference>(cx_);
							bool? cz_(ResourceReference X) => 
								(bool?)(X?.ReferenceElement?.Value is null);
							var da_ = context.Operators.WhereOrNull<ResourceReference>(cy_, cz_);
							var db_ = context.Operators.Count<ResourceReference>(da_);
							IEnumerable<FhirString> dc_(Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => 
								X?.AllIdentifiers;
							var dd_ = context.Operators.SelectOrNull<Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, dc_);
							var de_ = context.Operators.FlattenList<FhirString>(dd_);
							FhirString df_(FhirString X) => 
								X;
							var dg_ = context.Operators.SelectOrNull<FhirString, FhirString>(de_, df_);
							var dh_ = context.Operators.Count<FhirString>(dg_);
							var di_ = context.Operators.Add(db_, dh_);
							IEnumerable<Identifier> dj_(Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => 
								X?.NullIdentifiers;
							var dk_ = context.Operators.SelectOrNull<Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, dj_);
							var dl_ = context.Operators.FlattenList<Identifier>(dk_);
							var dm_ = context.Operators.Count<Identifier>(dl_);
							var dn_ = context.Operators.Add(di_, dm_);

							return dn_;
						}
						else
						{
							return (int?)0;
						};
					};
					var cl_ = new Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = ck_(),
					};

					return cl_;
				};
				var bj_ = context.Operators.SelectOrNull<Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bh_, bi_);
				var bk_ = context.Operators.SingletonFrom<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bj_);

				return bk_;
			};
			var as_ = context.Operators.SelectOrNull<Tuple_CZQfDISCFaOQaLKEbbAcDRfcP, Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(aq_, ar_);
			var at_ = context.Operators.SingletonFrom<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(as_);

			return at_;
		};
		var f_ = context.Operators.SelectOrNull<Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa, Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(d_, e_);
		var g_ = context.Operators.SingletonFrom<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(f_);

		return g_;
	}

}

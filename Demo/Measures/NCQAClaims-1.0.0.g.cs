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
			CqlConcept c_ = FHIRHelpers_4_0_001.ToConcept(MedicalClaim?.Type);
			CqlCode d_ = NCQATerminology_1_0_0.Professional();
			bool? e_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), d_);
			CqlCode g_ = NCQATerminology_1_0_0.Institutional();
			bool? h_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), g_);
			bool? i_ = context.Operators.Or(e_, h_);

			return i_;
		};
		IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Pharmacy Claims")]
	public IEnumerable<Claim> Pharmacy_Claims(IEnumerable<Claim> claim)
	{
		bool? a_(Claim PharmacyClaim)
		{
			CqlConcept c_ = FHIRHelpers_4_0_001.ToConcept(PharmacyClaim?.Type);
			CqlCode d_ = NCQATerminology_1_0_0.Pharmacy();
			bool? e_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), d_);

			return e_;
		};
		IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Professional or Institutional Claims Response")]
	public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse MedicalResponse)
		{
			CqlConcept c_ = FHIRHelpers_4_0_001.ToConcept(MedicalResponse?.Type);
			CqlCode d_ = NCQATerminology_1_0_0.Professional();
			bool? e_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), d_);
			CqlCode g_ = NCQATerminology_1_0_0.Institutional();
			bool? h_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), g_);
			bool? i_ = context.Operators.Or(e_, h_);

			return i_;
		};
		IEnumerable<ClaimResponse> b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);

		return b_;
	}

    [CqlDeclaration("Pharmacy Claims Response")]
	public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse PharmacyResponse)
		{
			CqlConcept c_ = FHIRHelpers_4_0_001.ToConcept(PharmacyResponse?.Type);
			CqlCode d_ = NCQATerminology_1_0_0.Pharmacy();
			bool? e_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), d_);

			return e_;
		};
		IEnumerable<ClaimResponse> b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);

		return b_;
	}

    [CqlDeclaration("Medical Claims With Procedure and POS")]
	public IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_and_POS(IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p) => 
			p?.code;
		IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, b_);
		string d_(CqlCode pos) => 
			pos?.code;
		IEnumerable<string> e_ = context.Operators.Select<CqlCode, string>(posCodes, d_);
		Tuple_EWMRhBHgcOUGZLgIBDbjPHISO f_ = new Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = a_,
			ProceduresAsStrings = c_,
			POSAsString = e_,
		};
		Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[] g_ = new Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
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

						return u_;
					}
					else
					{
						bool? v_(Claim.ItemComponent ItemOnLine)
						{
							CqlConcept x_ = FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService);
							bool? y_(CqlCode LineCode)
							{
								bool? ag_ = context.Operators.In<string>(LineCode?.code, ClaimWithPosCode?.ProceduresAsStrings);

								return ag_;
							};
							IEnumerable<CqlCode> z_ = context.Operators.Where<CqlCode>((x_?.codes as IEnumerable<CqlCode>), y_);
							bool? aa_ = context.Operators.Exists<CqlCode>(z_);
							CqlConcept ab_ = FHIRHelpers_4_0_001.ToConcept((ItemOnLine?.Location as CodeableConcept));
							bool? ac_(CqlCode PosCode)
							{
								bool? ah_ = context.Operators.In<string>(PosCode?.code, ClaimWithPosCode?.POSAsString);

								return ah_;
							};
							IEnumerable<CqlCode> ad_ = context.Operators.Where<CqlCode>((ab_?.codes as IEnumerable<CqlCode>), ac_);
							bool? ae_ = context.Operators.Exists<CqlCode>(ad_);
							bool? af_ = context.Operators.And(aa_, ae_);

							return af_;
						};
						IEnumerable<Claim.ItemComponent> w_ = context.Operators.Where<Claim.ItemComponent>((ClaimofInterest?.Item as IEnumerable<Claim.ItemComponent>), v_);

						return w_;
					};
				};
				Tuple_CNibCQZPIWCUUGeAXcXWGiTgj p_ = new Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = ClaimofInterest,
					LineItems = o_(),
				};
				Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[] q_ = new Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
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
								bool? aq_ = context.Operators.Not((bool?)(@this?.Serviced is null));

								return aq_;
							};
							IEnumerable<Claim.ItemComponent> ak_ = context.Operators.Where<Claim.ItemComponent>(LineItemDefinition?.LineItems, aj_);
							DataType al_(Claim.ItemComponent @this) => 
								@this?.Serviced;
							IEnumerable<DataType> am_ = context.Operators.Select<Claim.ItemComponent, DataType>(ak_, al_);
							CqlInterval<CqlDateTime> an_(DataType NormalDate)
							{
								CqlInterval<CqlDateTime> ar_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return ar_;
							};
							IEnumerable<CqlInterval<CqlDateTime>> ao_ = context.Operators.Select<DataType, CqlInterval<CqlDateTime>>(am_, an_);
							Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ap_ = new Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = LineItemDefinition?.Claim,
								ServicePeriod = ao_,
							};

							return ap_;
						}
						else
						{
							Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA as_ = null;

							return as_;
						};
					};

					return ai_();
				};
				IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> s_ = context.Operators.Select<Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_, r_);
				Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA t_ = context.Operators.SingletonFrom<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(s_);

				return t_;
			};
			IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> l_ = context.Operators.Select<Claim, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ClaimWithPosCode?.MedicalClaim, k_);
			bool? m_(Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				bool? at_ = context.Operators.Not((bool?)(FinalList is null));

				return at_;
			};
			IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> n_ = context.Operators.Where<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(l_, m_);

			return n_;
		};
		IEnumerable<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>> i_ = context.Operators.Select<Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);
		IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> j_ = context.Operators.SingletonFrom<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Procedure in Header or on Line Item")]
	public IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p) => 
			p?.code;
		IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, b_);
		Tuple_EWMRhBHgcOUGZLgIBDbjPHISO d_ = new Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = a_,
			ProceduresAsStrings = c_,
		};
		Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[] e_ = new Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
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

						return s_;
					}
					else
					{
						bool? t_(Claim.ItemComponent ItemOnLine)
						{
							CqlConcept v_ = FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService);
							bool? w_(CqlCode LineCode)
							{
								bool? am_ = context.Operators.In<string>(LineCode?.code, ClaimWithProcedure?.ProceduresAsStrings);

								return am_;
							};
							IEnumerable<CqlCode> x_ = context.Operators.Where<CqlCode>((v_?.codes as IEnumerable<CqlCode>), w_);
							bool? y_ = context.Operators.Exists<CqlCode>(x_);
							bool? z_(Claim.ProcedureComponent @this)
							{
								bool? an_ = context.Operators.Not((bool?)(@this?.Procedure is null));

								return an_;
							};
							IEnumerable<Claim.ProcedureComponent> aa_ = context.Operators.Where<Claim.ProcedureComponent>((ClaimofInterest?.Procedure as IEnumerable<Claim.ProcedureComponent>), z_);
							DataType ab_(Claim.ProcedureComponent @this) => 
								@this?.Procedure;
							IEnumerable<DataType> ac_ = context.Operators.Select<Claim.ProcedureComponent, DataType>(aa_, ab_);
							bool? ad_(DataType @this)
							{
								object ao_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								bool? ap_ = context.Operators.Not((bool?)(ao_ is null));

								return ap_;
							};
							IEnumerable<DataType> ae_ = context.Operators.Where<DataType>(ac_, ad_);
							object af_(DataType @this)
							{
								object aq_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return aq_;
							};
							IEnumerable<object> ag_ = context.Operators.Select<DataType, object>(ae_, af_);
							IEnumerable<object> ah_ = context.Operators.FlattenLateBoundList(ag_);
							bool? ai_(object HeaderCode)
							{
								Code ar_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
								bool? as_ = context.Operators.In<string>(ar_?.Value, ClaimWithProcedure?.ProceduresAsStrings);

								return as_;
							};
							IEnumerable<object> aj_ = context.Operators.Where<object>(ah_, ai_);
							bool? ak_ = context.Operators.Exists<object>(aj_);
							bool? al_ = context.Operators.Or(y_, ak_);

							return al_;
						};
						IEnumerable<Claim.ItemComponent> u_ = context.Operators.Where<Claim.ItemComponent>((ClaimofInterest?.Item as IEnumerable<Claim.ItemComponent>), t_);

						return u_;
					};
				};
				Tuple_CNibCQZPIWCUUGeAXcXWGiTgj n_ = new Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = ClaimofInterest,
					LineItems = m_(),
				};
				Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[] o_ = new Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
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
								bool? bb_ = context.Operators.Not((bool?)(@this?.Serviced is null));

								return bb_;
							};
							IEnumerable<Claim.ItemComponent> av_ = context.Operators.Where<Claim.ItemComponent>(LineItemDefinition?.LineItems, au_);
							DataType aw_(Claim.ItemComponent @this) => 
								@this?.Serviced;
							IEnumerable<DataType> ax_ = context.Operators.Select<Claim.ItemComponent, DataType>(av_, aw_);
							CqlInterval<CqlDateTime> ay_(DataType NormalDate)
							{
								CqlInterval<CqlDateTime> bc_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return bc_;
							};
							IEnumerable<CqlInterval<CqlDateTime>> az_ = context.Operators.Select<DataType, CqlInterval<CqlDateTime>>(ax_, ay_);
							Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ba_ = new Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = LineItemDefinition?.Claim,
								ServicePeriod = az_,
							};

							return ba_;
						}
						else
						{
							Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bd_ = null;

							return bd_;
						};
					};

					return at_();
				};
				IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> q_ = context.Operators.Select<Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(o_, p_);
				Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA r_ = context.Operators.SingletonFrom<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_);

				return r_;
			};
			IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> j_ = context.Operators.Select<Claim, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ClaimWithProcedure?.MedicalClaim, i_);
			bool? k_(Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				bool? be_ = context.Operators.Not((bool?)(FinalList is null));

				return be_;
			};
			IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> l_ = context.Operators.Where<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(j_, k_);

			return l_;
		};
		IEnumerable<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>> g_ = context.Operators.Select<Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(e_, f_);
		IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> h_ = context.Operators.SingletonFrom<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis")]
	public Tuple_HLLRUdKceDPKeIXGFiiNKjMKI Medical_Claims_With_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d) => 
			d?.code;
		IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX d_ = new Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
		};
		Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[] e_ = new Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
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

					return o_;
				}
				else
				{
					bool? p_(Claim DiagnosisLine)
					{
						bool? r_(Claim.DiagnosisComponent @this)
						{
							bool? ad_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

							return ad_;
						};
						IEnumerable<Claim.DiagnosisComponent> s_ = context.Operators.Where<Claim.DiagnosisComponent>((DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), r_);
						DataType t_(Claim.DiagnosisComponent @this) => 
							@this?.Diagnosis;
						IEnumerable<DataType> u_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(s_, t_);
						bool? v_(DataType @this)
						{
							object ae_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							bool? af_ = context.Operators.Not((bool?)(ae_ is null));

							return af_;
						};
						IEnumerable<DataType> w_ = context.Operators.Where<DataType>(u_, v_);
						object x_(DataType @this)
						{
							object ag_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return ag_;
						};
						IEnumerable<object> y_ = context.Operators.Select<DataType, object>(w_, x_);
						IEnumerable<object> z_ = context.Operators.FlattenLateBoundList(y_);
						bool? aa_(object HeaderCode)
						{
							Code ah_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
							bool? ai_ = context.Operators.In<string>(ah_?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings);

							return ai_;
						};
						IEnumerable<object> ab_ = context.Operators.Where<object>(z_, aa_);
						bool? ac_ = context.Operators.Exists<object>(ab_);

						return ac_;
					};
					IEnumerable<Claim> q_ = context.Operators.Where<Claim>(ClaimWithDiagnosis?.MedicalClaim, p_);

					return q_;
				};
			};
			Tuple_FcALBBGFXRhKjhIaDWMVWUhJg j_ = new Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = i_(),
			};
			Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[] k_ = new Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
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
							bool? aw_ = context.Operators.Not((bool?)(@this?.Item is null));

							return aw_;
						};
						IEnumerable<Claim> ap_ = context.Operators.Where<Claim>(HeaderDefinition?.DiagnosisItems, ao_);
						List<Claim.ItemComponent> aq_(Claim @this) => 
							@this?.Item;
						IEnumerable<List<Claim.ItemComponent>> ar_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ap_, aq_);
						IEnumerable<Claim.ItemComponent> as_ = context.Operators.Flatten<Claim.ItemComponent>(ar_);
						CqlInterval<CqlDateTime> at_(Claim.ItemComponent NormalDate)
						{
							CqlInterval<CqlDateTime> ax_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced);

							return ax_;
						};
						IEnumerable<CqlInterval<CqlDateTime>> au_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(as_, at_);
						Tuple_HLLRUdKceDPKeIXGFiiNKjMKI av_ = new Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = HeaderDefinition?.DiagnosisItems,
							ServicePeriod = au_,
						};

						return av_;
					}
					else
					{
						Tuple_HLLRUdKceDPKeIXGFiiNKjMKI ay_ = null;

						return ay_;
					};
				};
				Tuple_HLLRUdKceDPKeIXGFiiNKjMKI[] ak_ = new Tuple_HLLRUdKceDPKeIXGFiiNKjMKI[]
				{
					aj_(),
				};
				bool? al_(Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList)
				{
					bool? az_ = context.Operators.Not((bool?)(FinalList is null));

					return az_;
				};
				IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> am_ = context.Operators.Where<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(ak_, al_);
				Tuple_HLLRUdKceDPKeIXGFiiNKjMKI an_ = context.Operators.SingletonFrom<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(am_);

				return an_;
			};
			IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> m_ = context.Operators.Select<Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(k_, l_);
			Tuple_HLLRUdKceDPKeIXGFiiNKjMKI n_ = context.Operators.SingletonFrom<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(m_);

			return n_;
		};
		IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> g_ = context.Operators.Select<Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(e_, f_);
		Tuple_HLLRUdKceDPKeIXGFiiNKjMKI h_ = context.Operators.SingletonFrom<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(g_);

		return h_;
	}

    [CqlDeclaration("Pharmacy Claim With Medication")]
	public IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> Pharmacy_Claim_With_Medication(IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
	{
		IEnumerable<Claim> a_ = this.Pharmacy_Claims(claim);
		string b_(CqlCode p) => 
			p?.code;
		IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(MedicationCodes, b_);
		Tuple_BAGeQidBiLhNHVFiERZPAUdCY d_ = new Tuple_BAGeQidBiLhNHVFiERZPAUdCY
		{
			PharmacyClaim = a_,
			MedicationsAsStrings = c_,
		};
		Tuple_BAGeQidBiLhNHVFiERZPAUdCY[] e_ = new Tuple_BAGeQidBiLhNHVFiERZPAUdCY[]
		{
			d_,
		};
		IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> f_(Tuple_BAGeQidBiLhNHVFiERZPAUdCY ClaimWithMedication)
		{
			Tuple_FOLKddIQBPRMYYfjeMUjEIBhC i_(Claim Pharmacy)
			{
				bool? m_(Claim.ItemComponent ItemOnLine)
				{
					CqlConcept t_ = FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService);
					bool? u_(CqlCode LineCode)
					{
						bool? x_ = context.Operators.In<string>(LineCode?.code, ClaimWithMedication?.MedicationsAsStrings);

						return x_;
					};
					IEnumerable<CqlCode> v_ = context.Operators.Where<CqlCode>((t_?.codes as IEnumerable<CqlCode>), u_);
					bool? w_ = context.Operators.Exists<CqlCode>(v_);

					return w_;
				};
				IEnumerable<Claim.ItemComponent> n_ = context.Operators.Where<Claim.ItemComponent>((Pharmacy?.Item as IEnumerable<Claim.ItemComponent>), m_);
				Tuple_CNibCQZPIWCUUGeAXcXWGiTgj o_ = new Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = Pharmacy,
					LineItems = n_,
				};
				Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[] p_ = new Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					o_,
				};
				Tuple_FOLKddIQBPRMYYfjeMUjEIBhC q_(Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition)
				{
					Claim[] y_ = new Claim[]
					{
						LineItemDefinition?.Claim,
					};
					Tuple_FOLKddIQBPRMYYfjeMUjEIBhC z_(Claim ClaimLines)
					{
						bool? ac_(Claim.ItemComponent i)
						{
							CqlConcept al_ = FHIRHelpers_4_0_001.ToConcept(i?.ProductOrService);
							bool? am_(CqlCode LineCode)
							{
								bool? ap_ = context.Operators.In<string>(LineCode?.code, ClaimWithMedication?.MedicationsAsStrings);

								return ap_;
							};
							IEnumerable<CqlCode> an_ = context.Operators.Where<CqlCode>((al_?.codes as IEnumerable<CqlCode>), am_);
							bool? ao_ = context.Operators.Exists<CqlCode>(an_);

							return ao_;
						};
						IEnumerable<Claim.ItemComponent> ad_ = context.Operators.Where<Claim.ItemComponent>((ClaimLines?.Item as IEnumerable<Claim.ItemComponent>), ac_);
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
											CqlInterval<CqlDateTime> at_ = NCQAFHIRBase_1_0_0.Normalize_Interval(i?.Serviced);
											CqlDateTime au_ = context.Operators.Start(at_);
											CqlDateTime aw_ = context.Operators.Start(at_);
											decimal? ax_ = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement);
											CqlDateTime ay_ = context.Operators.Add(aw_, new CqlQuantity(ax_, "day"));
											CqlQuantity az_ = context.Operators.Quantity(1m, "day");
											CqlDateTime ba_ = context.Operators.Subtract(ay_, az_);
											CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(au_, ba_, true, true);

											return bb_;
										}
										else
										{
											CqlDate bc_ = FHIRHelpers_4_0_001.ToDate((i?.Serviced as Date));
											decimal? be_ = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement);
											CqlDate bf_ = context.Operators.Add(bc_, new CqlQuantity(be_, "day"));
											CqlQuantity bg_ = context.Operators.Quantity(1m, "day");
											CqlDate bh_ = context.Operators.Subtract(bf_, bg_);
											CqlInterval<CqlDate> bi_ = context.Operators.Interval(bc_, bh_, true, true);
											CqlDateTime bj_ = context.Operators.ConvertDateToDateTime(bi_?.low);
											CqlDate bn_ = context.Operators.Add(bc_, new CqlQuantity(be_, "day"));
											CqlDate bp_ = context.Operators.Subtract(bn_, bg_);
											CqlInterval<CqlDate> bq_ = context.Operators.Interval(bc_, bp_, true, true);
											CqlDateTime br_ = context.Operators.ConvertDateToDateTime(bq_?.high);
											CqlDate bv_ = context.Operators.Add(bc_, new CqlQuantity(be_, "day"));
											CqlDate bx_ = context.Operators.Subtract(bv_, bg_);
											CqlInterval<CqlDate> by_ = context.Operators.Interval(bc_, bx_, true, true);
											CqlDate cc_ = context.Operators.Add(bc_, new CqlQuantity(be_, "day"));
											CqlDate ce_ = context.Operators.Subtract(cc_, bg_);
											CqlInterval<CqlDate> cf_ = context.Operators.Interval(bc_, ce_, true, true);
											CqlInterval<CqlDateTime> cg_ = context.Operators.Interval(bj_, br_, by_?.lowClosed, cf_?.highClosed);

											return cg_;
										};
									};

									return as_();
								}
								else
								{
									CqlInterval<CqlDateTime> ch_ = null;

									return ch_;
								};
							};
							Tuple_DadNQNcGichTGjKhdjJicQeTP ar_ = new Tuple_DadNQNcGichTGjKhdjJicQeTP
							{
								DaysSupplyInterval = aq_(),
							};

							return ar_;
						};
						IEnumerable<Tuple_DadNQNcGichTGjKhdjJicQeTP> af_ = context.Operators.Select<Claim.ItemComponent, Tuple_DadNQNcGichTGjKhdjJicQeTP>(ad_, ae_);
						Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU ag_ = new Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU
						{
							CoveredDays = af_,
						};
						Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU[] ah_ = new Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU[]
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
										bool? cs_ = context.Operators.Not((bool?)(@this?.Serviced is null));

										return cs_;
									};
									IEnumerable<Claim.ItemComponent> ck_ = context.Operators.Where<Claim.ItemComponent>(LineItemDefinition?.LineItems, cj_);
									DataType cl_(Claim.ItemComponent @this) => 
										@this?.Serviced;
									IEnumerable<DataType> cm_ = context.Operators.Select<Claim.ItemComponent, DataType>(ck_, cl_);
									CqlInterval<CqlDateTime> cn_(DataType NormalDate)
									{
										CqlInterval<CqlDateTime> ct_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

										return ct_;
									};
									IEnumerable<CqlInterval<CqlDateTime>> co_ = context.Operators.Select<DataType, CqlInterval<CqlDateTime>>(cm_, cn_);
									CqlInterval<CqlDateTime> cp_(Tuple_DadNQNcGichTGjKhdjJicQeTP d) => 
										d?.DaysSupplyInterval;
									IEnumerable<CqlInterval<CqlDateTime>> cq_ = context.Operators.Select<Tuple_DadNQNcGichTGjKhdjJicQeTP, CqlInterval<CqlDateTime>>(ItemCalculation?.CoveredDays, cp_);
									Tuple_FOLKddIQBPRMYYfjeMUjEIBhC cr_ = new Tuple_FOLKddIQBPRMYYfjeMUjEIBhC
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

									return cu_;
								};
							};

							return ci_();
						};
						IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> aj_ = context.Operators.Select<Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU, Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ah_, ai_);
						Tuple_FOLKddIQBPRMYYfjeMUjEIBhC ak_ = context.Operators.SingletonFrom<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(aj_);

						return ak_;
					};
					IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> aa_ = context.Operators.Select<Claim, Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(y_, z_);
					Tuple_FOLKddIQBPRMYYfjeMUjEIBhC ab_ = context.Operators.SingletonFrom<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(aa_);

					return ab_;
				};
				IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> r_ = context.Operators.Select<Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(p_, q_);
				Tuple_FOLKddIQBPRMYYfjeMUjEIBhC s_ = context.Operators.SingletonFrom<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(r_);

				return s_;
			};
			IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> j_ = context.Operators.Select<Claim, Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ClaimWithMedication?.PharmacyClaim, i_);
			bool? k_(Tuple_FOLKddIQBPRMYYfjeMUjEIBhC FinalList)
			{
				bool? cv_ = context.Operators.Not((bool?)(FinalList is null));

				return cv_;
			};
			IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> l_ = context.Operators.Where<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(j_, k_);

			return l_;
		};
		IEnumerable<IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>> g_ = context.Operators.Select<Tuple_BAGeQidBiLhNHVFiERZPAUdCY, IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(e_, f_);
		IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> h_ = context.Operators.SingletonFrom<IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis and Procedure")]
	public IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d) => 
			d?.code;
		IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p) => 
			p?.code;
		IEnumerable<string> e_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, d_);
		Tuple_EUYHPiEZNTBOHPgZNKhGAORRb f_ = new Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
			ProceduresAsStrings = e_,
		};
		Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[] g_ = new Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
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

					return q_;
				}
				else
				{
					bool? r_(Claim DiagnosisLine)
					{
						bool? t_(Claim.DiagnosisComponent @this)
						{
							bool? af_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

							return af_;
						};
						IEnumerable<Claim.DiagnosisComponent> u_ = context.Operators.Where<Claim.DiagnosisComponent>((DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), t_);
						DataType v_(Claim.DiagnosisComponent @this) => 
							@this?.Diagnosis;
						IEnumerable<DataType> w_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(u_, v_);
						bool? x_(DataType @this)
						{
							object ag_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							bool? ah_ = context.Operators.Not((bool?)(ag_ is null));

							return ah_;
						};
						IEnumerable<DataType> y_ = context.Operators.Where<DataType>(w_, x_);
						object z_(DataType @this)
						{
							object ai_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return ai_;
						};
						IEnumerable<object> aa_ = context.Operators.Select<DataType, object>(y_, z_);
						IEnumerable<object> ab_ = context.Operators.FlattenLateBoundList(aa_);
						bool? ac_(object HeaderCode)
						{
							Code aj_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
							bool? ak_ = context.Operators.In<string>(aj_?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings);

							return ak_;
						};
						IEnumerable<object> ad_ = context.Operators.Where<object>(ab_, ac_);
						bool? ae_ = context.Operators.Exists<object>(ad_);

						return ae_;
					};
					IEnumerable<Claim> s_ = context.Operators.Where<Claim>(ClaimWithDiagnosis?.MedicalClaim, r_);

					return s_;
				};
			};
			Tuple_FcALBBGFXRhKjhIaDWMVWUhJg l_ = new Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = k_(),
			};
			Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[] m_ = new Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
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
							Claim[] av_ = new Claim[]
							{
								ClaimofInterest,
							};
							bool? aw_(Claim ItemOnLine)
							{
								bool? az_(Claim.ProcedureComponent @this)
								{
									bool? by_ = context.Operators.Not((bool?)(@this?.Procedure is null));

									return by_;
								};
								IEnumerable<Claim.ProcedureComponent> ba_ = context.Operators.Where<Claim.ProcedureComponent>((ItemOnLine?.Procedure as IEnumerable<Claim.ProcedureComponent>), az_);
								DataType bb_(Claim.ProcedureComponent @this) => 
									@this?.Procedure;
								IEnumerable<DataType> bc_ = context.Operators.Select<Claim.ProcedureComponent, DataType>(ba_, bb_);
								bool? bd_(DataType @this)
								{
									object bz_ = context.Operators.LateBoundProperty<object>(@this, "coding");
									bool? ca_ = context.Operators.Not((bool?)(bz_ is null));

									return ca_;
								};
								IEnumerable<DataType> be_ = context.Operators.Where<DataType>(bc_, bd_);
								object bf_(DataType @this)
								{
									object cb_ = context.Operators.LateBoundProperty<object>(@this, "coding");

									return cb_;
								};
								IEnumerable<object> bg_ = context.Operators.Select<DataType, object>(be_, bf_);
								IEnumerable<object> bh_ = context.Operators.FlattenLateBoundList(bg_);
								bool? bi_(object ProcedureHeaderCode)
								{
									Code cc_ = context.Operators.LateBoundProperty<Code>(ProcedureHeaderCode, "code");
									bool? cd_ = context.Operators.In<string>(cc_?.Value, ClaimWithDiagnosis?.ProceduresAsStrings);

									return cd_;
								};
								IEnumerable<object> bj_ = context.Operators.Where<object>(bh_, bi_);
								bool? bk_ = context.Operators.Exists<object>(bj_);
								bool? bl_(Claim.ItemComponent @this)
								{
									bool? ce_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

									return ce_;
								};
								IEnumerable<Claim.ItemComponent> bm_ = context.Operators.Where<Claim.ItemComponent>((ItemOnLine?.Item as IEnumerable<Claim.ItemComponent>), bl_);
								CodeableConcept bn_(Claim.ItemComponent @this) => 
									@this?.ProductOrService;
								IEnumerable<CodeableConcept> bo_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(bm_, bn_);
								bool? bp_(CodeableConcept @this)
								{
									bool? cf_ = context.Operators.Not((bool?)(@this?.Coding is null));

									return cf_;
								};
								IEnumerable<CodeableConcept> bq_ = context.Operators.Where<CodeableConcept>(bo_, bp_);
								List<Coding> br_(CodeableConcept @this) => 
									@this?.Coding;
								IEnumerable<List<Coding>> bs_ = context.Operators.Select<CodeableConcept, List<Coding>>(bq_, br_);
								IEnumerable<Coding> bt_ = context.Operators.Flatten<Coding>(bs_);
								bool? bu_(Coding LineCode)
								{
									bool? cg_ = context.Operators.In<string>(LineCode?.CodeElement?.Value, ClaimWithDiagnosis?.ProceduresAsStrings);

									return cg_;
								};
								IEnumerable<Coding> bv_ = context.Operators.Where<Coding>(bt_, bu_);
								bool? bw_ = context.Operators.Exists<Coding>(bv_);
								bool? bx_ = context.Operators.Or(bk_, bw_);

								return bx_;
							};
							IEnumerable<Claim> ax_ = context.Operators.Where<Claim>(av_, aw_);
							Claim ay_ = context.Operators.SingletonFrom<Claim>(ax_);

							return ay_;
						};
					};
					Tuple_DQefEeUREeePUGdeeZLYSgFcU aq_ = new Tuple_DQefEeUREeePUGdeeZLYSgFcU
					{
						ProcedureItems = ap_(),
					};
					Tuple_DQefEeUREeePUGdeeZLYSgFcU[] ar_ = new Tuple_DQefEeUREeePUGdeeZLYSgFcU[]
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
									CqlInterval<CqlDateTime> cl_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced);

									return cl_;
								};
								IEnumerable<CqlInterval<CqlDateTime>> cj_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((HeaderDefinition?.ProcedureItems?.Item as IEnumerable<Claim.ItemComponent>), ci_);
								Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ck_ = new Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
								{
									Claim = HeaderDefinition?.ProcedureItems,
									ServicePeriod = cj_,
								};

								return ck_;
							}
							else
							{
								Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA cm_ = null;

								return cm_;
							};
						};

						return ch_();
					};
					IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> at_ = context.Operators.Select<Tuple_DQefEeUREeePUGdeeZLYSgFcU, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ar_, as_);
					Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA au_ = context.Operators.SingletonFrom<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(at_);

					return au_;
				};
				IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> am_ = context.Operators.Select<Claim, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ClaimWithProcedure?.DiagnosisItems, al_);
				bool? an_(Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
				{
					bool? cn_ = context.Operators.Not((bool?)(FinalList is null));

					return cn_;
				};
				IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> ao_ = context.Operators.Where<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(am_, an_);

				return ao_;
			};
			IEnumerable<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>> o_ = context.Operators.Select<Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(m_, n_);
			IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> p_ = context.Operators.SingletonFrom<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(o_);

			return p_;
		};
		IEnumerable<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>> i_ = context.Operators.Select<Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);
		IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> j_ = context.Operators.SingletonFrom<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis and Procedure")]
	public IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Principal_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d) => 
			d?.code;
		IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p) => 
			p?.code;
		IEnumerable<string> e_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, d_);
		Tuple_EUYHPiEZNTBOHPgZNKhGAORRb f_ = new Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
			ProceduresAsStrings = e_,
		};
		Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[] g_ = new Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
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
						Claim[] u_ = new Claim[]
						{
							ClaimofInterest,
						};
						bool? v_(Claim ItemOnLine)
						{
							bool? y_(Claim.ItemComponent @this)
							{
								bool? ax_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

								return ax_;
							};
							IEnumerable<Claim.ItemComponent> z_ = context.Operators.Where<Claim.ItemComponent>((ItemOnLine?.Item as IEnumerable<Claim.ItemComponent>), y_);
							CodeableConcept aa_(Claim.ItemComponent @this) => 
								@this?.ProductOrService;
							IEnumerable<CodeableConcept> ab_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(z_, aa_);
							bool? ac_(CodeableConcept @this)
							{
								bool? ay_ = context.Operators.Not((bool?)(@this?.Coding is null));

								return ay_;
							};
							IEnumerable<CodeableConcept> ad_ = context.Operators.Where<CodeableConcept>(ab_, ac_);
							List<Coding> ae_(CodeableConcept @this) => 
								@this?.Coding;
							IEnumerable<List<Coding>> af_ = context.Operators.Select<CodeableConcept, List<Coding>>(ad_, ae_);
							IEnumerable<Coding> ag_ = context.Operators.Flatten<Coding>(af_);
							bool? ah_(Coding LineCode)
							{
								bool? az_ = context.Operators.In<string>(LineCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings);

								return az_;
							};
							IEnumerable<Coding> ai_ = context.Operators.Where<Coding>(ag_, ah_);
							bool? aj_ = context.Operators.Exists<Coding>(ai_);
							bool? ak_(Claim.ProcedureComponent @this)
							{
								bool? ba_ = context.Operators.Not((bool?)(@this?.Procedure is null));

								return ba_;
							};
							IEnumerable<Claim.ProcedureComponent> al_ = context.Operators.Where<Claim.ProcedureComponent>((ItemOnLine?.Procedure as IEnumerable<Claim.ProcedureComponent>), ak_);
							DataType am_(Claim.ProcedureComponent @this) => 
								@this?.Procedure;
							IEnumerable<DataType> an_ = context.Operators.Select<Claim.ProcedureComponent, DataType>(al_, am_);
							bool? ao_(DataType @this)
							{
								object bb_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								bool? bc_ = context.Operators.Not((bool?)(bb_ is null));

								return bc_;
							};
							IEnumerable<DataType> ap_ = context.Operators.Where<DataType>(an_, ao_);
							object aq_(DataType @this)
							{
								object bd_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return bd_;
							};
							IEnumerable<object> ar_ = context.Operators.Select<DataType, object>(ap_, aq_);
							IEnumerable<object> as_ = context.Operators.FlattenLateBoundList(ar_);
							bool? at_(object HeaderCode)
							{
								Code be_ = context.Operators.LateBoundProperty<Code>(HeaderCode, "code");
								bool? bf_ = context.Operators.In<string>(be_?.Value, ClaimWithProcedure?.ProceduresAsStrings);

								return bf_;
							};
							IEnumerable<object> au_ = context.Operators.Where<object>(as_, at_);
							bool? av_ = context.Operators.Exists<object>(au_);
							bool? aw_ = context.Operators.Or(aj_, av_);

							return aw_;
						};
						IEnumerable<Claim> w_ = context.Operators.Where<Claim>(u_, v_);
						Claim x_ = context.Operators.SingletonFrom<Claim>(w_);

						return x_;
					};
				};
				Tuple_CIIbRNfJieBVcNIWHEUWMVhOB p_ = new Tuple_CIIbRNfJieBVcNIWHEUWMVhOB
				{
					Claim = ClaimofInterest,
					ProcedureItems = o_(),
				};
				Tuple_CIIbRNfJieBVcNIWHEUWMVhOB[] q_ = new Tuple_CIIbRNfJieBVcNIWHEUWMVhOB[]
				{
					p_,
				};
				Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA r_(Tuple_CIIbRNfJieBVcNIWHEUWMVhOB DiagnosisCheck)
				{
					Claim[] bg_ = new Claim[]
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
								Claim[] bq_ = new Claim[]
								{
									ClaimforDiagnosis,
								};
								bool? br_(Claim RightClaim)
								{
									bool? bu_(Claim.DiagnosisComponent RightDiagnosis)
									{
										Integer bx_ = context.Operators.Convert<Integer>(RightDiagnosis?.SequenceElement);
										int? by_ = FHIRHelpers_4_0_001.ToInteger(bx_);
										bool? bz_ = context.Operators.Equal(by_, 1);
										IEnumerable<Coding> ca_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(RightDiagnosis?.Diagnosis, "coding");
										bool? cb_(Coding DiagnosisCode)
										{
											bool? cf_ = context.Operators.In<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithProcedure?.DiagnosesAsStrings);

											return cf_;
										};
										IEnumerable<Coding> cc_ = context.Operators.Where<Coding>(ca_, cb_);
										bool? cd_ = context.Operators.Exists<Coding>(cc_);
										bool? ce_ = context.Operators.And(bz_, cd_);

										return ce_;
									};
									IEnumerable<Claim.DiagnosisComponent> bv_ = context.Operators.Where<Claim.DiagnosisComponent>((RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), bu_);
									bool? bw_ = context.Operators.Exists<Claim.DiagnosisComponent>(bv_);

									return bw_;
								};
								IEnumerable<Claim> bs_ = context.Operators.Where<Claim>(bq_, br_);
								Claim bt_ = context.Operators.SingletonFrom<Claim>(bs_);

								return bt_;
							};
						};
						Tuple_iUHcMLYFdMEcPJJeOVJdQjbI bl_ = new Tuple_iUHcMLYFdMEcPJJeOVJdQjbI
						{
							Procedure = (ClaimforDiagnosis?.Item as IEnumerable<Claim.ItemComponent>),
							LineItems = bk_(),
						};
						Tuple_iUHcMLYFdMEcPJJeOVJdQjbI[] bm_ = new Tuple_iUHcMLYFdMEcPJJeOVJdQjbI[]
						{
							bl_,
						};
						Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bn_(Tuple_iUHcMLYFdMEcPJJeOVJdQjbI LineItemDefinition)
						{
							Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA cg_()
							{
								bool ch_()
								{
									bool? ci_ = context.Operators.Not((bool?)(LineItemDefinition is null));
									bool? cj_ = context.Operators.Not((bool?)(LineItemDefinition?.LineItems is null));
									bool? ck_ = context.Operators.And(ci_, cj_);

									return (ck_ ?? false);
								};
								if (ch_())
								{
									CqlInterval<CqlDateTime> cl_(Claim.ItemComponent NormalDate)
									{
										CqlInterval<CqlDateTime> co_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced);

										return co_;
									};
									IEnumerable<CqlInterval<CqlDateTime>> cm_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((LineItemDefinition?.LineItems?.Item as IEnumerable<Claim.ItemComponent>), cl_);
									Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA cn_ = new Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
									{
										Claim = LineItemDefinition?.LineItems,
										ServicePeriod = cm_,
									};

									return cn_;
								}
								else
								{
									Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA cp_ = null;

									return cp_;
								};
							};

							return cg_();
						};
						IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> bo_ = context.Operators.Select<Tuple_iUHcMLYFdMEcPJJeOVJdQjbI, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bm_, bn_);
						Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bp_ = context.Operators.SingletonFrom<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bo_);

						return bp_;
					};
					IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> bi_ = context.Operators.Select<Claim, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bg_, bh_);
					Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bj_ = context.Operators.SingletonFrom<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bi_);

					return bj_;
				};
				IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> s_ = context.Operators.Select<Tuple_CIIbRNfJieBVcNIWHEUWMVhOB, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_, r_);
				Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA t_ = context.Operators.SingletonFrom<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(s_);

				return t_;
			};
			IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> l_ = context.Operators.Select<Claim, Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ClaimWithProcedure?.MedicalClaim, k_);
			bool? m_(Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				bool? cq_ = context.Operators.Not((bool?)(FinalList is null));

				return cq_;
			};
			IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> n_ = context.Operators.Where<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(l_, m_);

			return n_;
		};
		IEnumerable<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>> i_ = context.Operators.Select<Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);
		IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> j_ = context.Operators.SingletonFrom<IEnumerable<Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis")]
	public IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> Medical_Claims_With_Principal_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d) => 
			d?.code;
		IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX d_ = new Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
		};
		Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[] e_ = new Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
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

					return o_;
				}
				else
				{
					bool? p_(Claim RightClaim)
					{
						bool? r_(Claim.DiagnosisComponent RightDiagnosis)
						{
							Integer u_ = context.Operators.Convert<Integer>(RightDiagnosis?.SequenceElement);
							int? v_ = FHIRHelpers_4_0_001.ToInteger(u_);
							bool? w_ = context.Operators.Equal(v_, 1);
							IEnumerable<Coding> x_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(RightDiagnosis?.Diagnosis, "coding");
							bool? y_(Coding DiagnosisCode)
							{
								bool? ac_ = context.Operators.In<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings);

								return ac_;
							};
							IEnumerable<Coding> z_ = context.Operators.Where<Coding>(x_, y_);
							bool? aa_ = context.Operators.Exists<Coding>(z_);
							bool? ab_ = context.Operators.And(w_, aa_);

							return ab_;
						};
						IEnumerable<Claim.DiagnosisComponent> s_ = context.Operators.Where<Claim.DiagnosisComponent>((RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), r_);
						bool? t_ = context.Operators.Exists<Claim.DiagnosisComponent>(s_);

						return t_;
					};
					IEnumerable<Claim> q_ = context.Operators.Where<Claim>(ClaimWithDiagnosis?.MedicalClaim, p_);

					return q_;
				};
			};
			Tuple_FADJTWQjaQgiVVcFZjGXbPFbN j_ = new Tuple_FADJTWQjaQgiVVcFZjGXbPFbN
			{
				LineItems = i_(),
			};
			Tuple_FADJTWQjaQgiVVcFZjGXbPFbN[] k_ = new Tuple_FADJTWQjaQgiVVcFZjGXbPFbN[]
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
								bool? aq_ = context.Operators.Not((bool?)(@this?.Item is null));

								return aq_;
							};
							IEnumerable<Claim> aj_ = context.Operators.Where<Claim>(LineItemDefinition?.LineItems, ai_);
							List<Claim.ItemComponent> ak_(Claim @this) => 
								@this?.Item;
							IEnumerable<List<Claim.ItemComponent>> al_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(aj_, ak_);
							IEnumerable<Claim.ItemComponent> am_ = context.Operators.Flatten<Claim.ItemComponent>(al_);
							CqlInterval<CqlDateTime> an_(Claim.ItemComponent NormalDate)
							{
								CqlInterval<CqlDateTime> ar_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced);

								return ar_;
							};
							IEnumerable<CqlInterval<CqlDateTime>> ao_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(am_, an_);
							Tuple_HLLRUdKceDPKeIXGFiiNKjMKI ap_ = new Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
							{
								Claim = LineItemDefinition?.LineItems,
								ServicePeriod = ao_,
							};

							return ap_;
						}
						else
						{
							Tuple_HLLRUdKceDPKeIXGFiiNKjMKI as_ = null;

							return as_;
						};
					};

					return ah_();
				};
				IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> ae_ = context.Operators.Select<Claim, Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(LineItemDefinition?.LineItems, ad_);
				bool? af_(Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList)
				{
					bool? at_ = context.Operators.Not((bool?)(FinalList is null));

					return at_;
				};
				IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> ag_ = context.Operators.Where<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(ae_, af_);

				return ag_;
			};
			IEnumerable<IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>> m_ = context.Operators.Select<Tuple_FADJTWQjaQgiVVcFZjGXbPFbN, IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(k_, l_);
			IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> n_ = context.Operators.SingletonFrom<IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(m_);

			return n_;
		};
		IEnumerable<IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>> g_ = context.Operators.Select<Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(e_, f_);
		IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> h_ = context.Operators.SingletonFrom<IEnumerable<Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(g_);

		return h_;
	}

    [CqlDeclaration("Get All Professional and Institutional Claims and Claim Responses")]
	public Tuple_GjTATZbNccdVYWChGHHdRUXSM Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		IEnumerable<ClaimResponse> a_ = this.Professional_or_Institutional_Claims_Response(claimResponse);
		IEnumerable<Claim> b_ = this.Professional_or_Institutional_Claims(claim);
		Tuple_GjTATZbNccdVYWChGHHdRUXSM c_ = new Tuple_GjTATZbNccdVYWChGHHdRUXSM
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
			string h_ = context.Operators.Convert<string>(ResponseItem?.OutcomeElement);
			string[] i_ = new string[]
			{
				"complete",
				"partial",
			};
			bool? j_ = context.Operators.In<string>(h_, (i_ as IEnumerable<string>));

			return j_;
		};
		IEnumerable<ClaimResponse> b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);
		Tuple_GRhdjhBUGcJfFRBeODDiYLCdD c_ = new Tuple_GRhdjhBUGcJfFRBeODDiYLCdD
		{
			PaidResponse = b_,
		};
		Tuple_GRhdjhBUGcJfFRBeODDiYLCdD[] d_ = new Tuple_GRhdjhBUGcJfFRBeODDiYLCdD[]
		{
			c_,
		};
		IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> e_(Tuple_GRhdjhBUGcJfFRBeODDiYLCdD ClaimResponse)
		{
			Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL k_(ClaimResponse ClmResp)
			{
				string m_ = context.Operators.Convert<string>(ClmResp?.Request?.ReferenceElement);
				string n_ = NCQAFHIRBase_1_0_0.GetId(m_);
				bool? o_(ClaimResponse.ItemComponent ResponseItem)
				{
					bool? r_(ClaimResponse.AdjudicationComponent @this)
					{
						bool? al_ = context.Operators.Not((bool?)(@this?.Category is null));

						return al_;
					};
					IEnumerable<ClaimResponse.AdjudicationComponent> s_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>(ResponseItem?.Adjudication, r_);
					CodeableConcept t_(ClaimResponse.AdjudicationComponent @this) => 
						@this?.Category;
					IEnumerable<CodeableConcept> u_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, CodeableConcept>(s_, t_);
					bool? v_(CodeableConcept @this)
					{
						bool? am_ = context.Operators.Not((bool?)(@this?.Coding is null));

						return am_;
					};
					IEnumerable<CodeableConcept> w_ = context.Operators.Where<CodeableConcept>(u_, v_);
					List<Coding> x_(CodeableConcept @this) => 
						@this?.Coding;
					IEnumerable<List<Coding>> y_ = context.Operators.Select<CodeableConcept, List<Coding>>(w_, x_);
					IEnumerable<Coding> z_ = context.Operators.Flatten<Coding>(y_);
					bool? aa_(Coding CategoryItem)
					{
						bool? an_ = context.Operators.Equal(CategoryItem?.CodeElement?.Value, "benefit");

						return an_;
					};
					IEnumerable<Coding> ab_ = context.Operators.Where<Coding>(z_, aa_);
					bool? ac_ = context.Operators.Exists<Coding>(ab_);
					bool? ad_(ClaimResponse.AdjudicationComponent @this)
					{
						bool? ao_ = context.Operators.Not((bool?)(@this?.Amount is null));

						return ao_;
					};
					IEnumerable<ClaimResponse.AdjudicationComponent> ae_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>(ResponseItem?.Adjudication, ad_);
					Money af_(ClaimResponse.AdjudicationComponent @this) => 
						@this?.Amount;
					IEnumerable<Money> ag_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, Money>(ae_, af_);
					bool? ah_(Money DollarAmount)
					{
						decimal? ap_ = FHIRHelpers_4_0_001.ToDecimal(DollarAmount?.ValueElement);
						decimal? aq_ = context.Operators.ConvertIntegerToDecimal(0);
						bool? ar_ = context.Operators.Greater(ap_, aq_);

						return ar_;
					};
					IEnumerable<Money> ai_ = context.Operators.Where<Money>(ag_, ah_);
					bool? aj_ = context.Operators.Exists<Money>(ai_);
					bool? ak_ = context.Operators.And(ac_, aj_);

					return ak_;
				};
				IEnumerable<ClaimResponse.ItemComponent> p_ = context.Operators.Where<ClaimResponse.ItemComponent>((ClmResp?.Item as IEnumerable<ClaimResponse.ItemComponent>), o_);
				Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL q_ = new Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL
				{
					Response = ClmResp,
					ResponseID = n_,
					LineItems = p_,
				};

				return q_;
			};
			IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> l_ = context.Operators.Select<ClaimResponse, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimResponse?.PaidResponse, k_);

			return l_;
		};
		IEnumerable<IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>> f_ = context.Operators.Select<Tuple_GRhdjhBUGcJfFRBeODDiYLCdD, IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(d_, e_);
		IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> g_ = context.Operators.SingletonFrom<IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(f_);

		return g_;
	}

    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
	public IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_and_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			bool? e_(Claim.ItemComponent @this)
			{
				bool? ad_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

				return ad_;
			};
			IEnumerable<Claim.ItemComponent> f_ = context.Operators.Where<Claim.ItemComponent>(AllClaims?.Item, e_);
			CodeableConcept g_(Claim.ItemComponent @this) => 
				@this?.ProductOrService;
			IEnumerable<CodeableConcept> h_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(f_, g_);
			bool? i_(CodeableConcept @this)
			{
				bool? ae_ = context.Operators.Not((bool?)(@this?.Coding is null));

				return ae_;
			};
			IEnumerable<CodeableConcept> j_ = context.Operators.Where<CodeableConcept>(h_, i_);
			List<Coding> k_(CodeableConcept @this) => 
				@this?.Coding;
			IEnumerable<List<Coding>> l_ = context.Operators.Select<CodeableConcept, List<Coding>>(j_, k_);
			IEnumerable<Coding> m_ = context.Operators.Flatten<Coding>(l_);
			bool? n_(Coding ProductOrServiceCode)
			{
				CqlCode af_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				bool? ag_ = context.Operators.In<CqlCode>(af_, ProductOrServiceValueSet);

				return ag_;
			};
			IEnumerable<Coding> o_ = context.Operators.Where<Coding>(m_, n_);
			bool? p_ = context.Operators.Exists<Coding>(o_);
			bool? q_(Claim.DiagnosisComponent @this)
			{
				bool? ah_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

				return ah_;
			};
			IEnumerable<Claim.DiagnosisComponent> r_ = context.Operators.Where<Claim.DiagnosisComponent>((AllClaims?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), q_);
			DataType s_(Claim.DiagnosisComponent @this) => 
				@this?.Diagnosis;
			IEnumerable<DataType> t_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(r_, s_);
			bool? u_(DataType @this)
			{
				object ai_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				bool? aj_ = context.Operators.Not((bool?)(ai_ is null));

				return aj_;
			};
			IEnumerable<DataType> v_ = context.Operators.Where<DataType>(t_, u_);
			object w_(DataType @this)
			{
				object ak_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return ak_;
			};
			IEnumerable<object> x_ = context.Operators.Select<DataType, object>(v_, w_);
			IEnumerable<object> y_ = context.Operators.FlattenLateBoundList(x_);
			bool? z_(object DiagnosisCode)
			{
				CqlCode al_ = FHIRHelpers_4_0_001.ToCode((DiagnosisCode as Coding));
				bool? am_ = context.Operators.In<CqlCode>(al_, DiagnosisValueSet);

				return am_;
			};
			IEnumerable<object> aa_ = context.Operators.Where<object>(y_, z_);
			bool? ab_ = context.Operators.Exists<object>(aa_);
			bool? ac_ = context.Operators.And(p_, ab_);

			return ac_;
		};
		IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);
		Tuple_DXaYeZVOEAELKIhLMVHZBeASM c_(Claim ProcedureClaims)
		{
			bool? an_(Claim.ItemComponent ResponseItem)
			{
				bool? aq_(Coding ProductOrServiceCode)
				{
					CqlCode at_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					bool? au_ = context.Operators.In<CqlCode>(at_, ProductOrServiceValueSet);

					return au_;
				};
				IEnumerable<Coding> ar_ = context.Operators.Where<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), aq_);
				bool? as_ = context.Operators.Exists<Coding>(ar_);

				return as_;
			};
			IEnumerable<Claim.ItemComponent> ao_ = context.Operators.Where<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), an_);
			Tuple_DXaYeZVOEAELKIhLMVHZBeASM ap_ = new Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = ProcedureClaims,
				ClaimID = ProcedureClaims?.IdElement,
				LineItems = ao_,
			};

			return ap_;
		};
		IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> d_ = context.Operators.Select<Claim, Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services and Conditions")]
	public Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_and_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> b_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ c_ = new Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = a_,
			MedicalClaim = b_,
		};
		Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[] d_ = new Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
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
							string y_ = context.Operators.Convert<string>(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: null));
							string z_ = context.Operators.Convert<string>(pClaim?.Response?.Request?.ReferenceElement);
							string aa_ = NCQAFHIRBase_1_0_0.GetId(z_);
							bool? ab_ = context.Operators.Equal(y_, aa_);
							Integer ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							Integer ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							bool? ae_ = context.Operators.Equal(ac_, ad_);
							bool? af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						IEnumerable<ClaimResponse.ItemComponent> v_ = context.Operators.Where<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> x_ = context.Operators.Select<ClaimResponse.ItemComponent, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_, w_);

						return x_;
					};
					IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> s_ = context.Operators.SelectMany<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimAndResponse?.PaidMedicalClaimResponse, r_);
					bool? t_ = context.Operators.Exists<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(s_);

					return t_;
				};
				IEnumerable<Claim.ItemComponent> p_ = context.Operators.Where<Claim.ItemComponent>(medClaim?.LineItems, o_);
				Tuple_CAKcSTUVVXcPjYRXATiiRAEMg q_ = new Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			IEnumerable<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> i_ = context.Operators.Select<Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimAndResponse?.MedicalClaim, h_);
			Tuple_CTafBejCOJKDPBQMRaUKGZGDD j_ = new Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = i_,
			};
			Tuple_CTafBejCOJKDPBQMRaUKGZGDD[] k_ = new Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
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
							bool? as_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return as_;
						};
						IEnumerable<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> an_ = context.Operators.Where<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, am_);
						IEnumerable<Claim.ItemComponent> ao_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						IEnumerable<IEnumerable<Claim.ItemComponent>> ap_ = context.Operators.Select<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(an_, ao_);
						IEnumerable<Claim.ItemComponent> aq_ = context.Operators.Flatten<Claim.ItemComponent>(ap_);
						bool? ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);

						return (ar_ ?? false);
					};
					if (al_())
					{
						bool? at_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							bool? bf_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return bf_;
						};
						IEnumerable<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> au_ = context.Operators.Where<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, at_);
						Tuple_DXaYeZVOEAELKIhLMVHZBeASM av_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.PaidClaim;
						IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> aw_ = context.Operators.Select<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(au_, av_);
						bool? ax_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							bool? bg_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bg_;
						};
						IEnumerable<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> ay_ = context.Operators.Where<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, ax_);
						IEnumerable<Claim.ItemComponent> az_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						IEnumerable<IEnumerable<Claim.ItemComponent>> ba_ = context.Operators.Select<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(ay_, az_);
						IEnumerable<Claim.ItemComponent> bb_ = context.Operators.Flatten<Claim.ItemComponent>(ba_);
						CqlInterval<CqlDateTime> bc_(Claim.ItemComponent PaidItem)
						{
							CqlInterval<CqlDateTime> bh_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced);

							return bh_;
						};
						IEnumerable<CqlInterval<CqlDateTime>> bd_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, bc_);
						Tuple_FbAEUOYETObSHBafYbFNIeSNO be_ = new Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = aw_,
							ServicePeriod = bd_,
						};

						return be_;
					}
					else
					{
						Tuple_FbAEUOYETObSHBafYbFNIeSNO bi_ = null;

						return bi_;
					};
				};
				Tuple_FbAEUOYETObSHBafYbFNIeSNO[] ah_ = new Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ag_(),
				};
				bool? ai_(Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					bool? bj_ = context.Operators.Not((bool?)(FinalList is null));

					return bj_;
				};
				IEnumerable<Tuple_FbAEUOYETObSHBafYbFNIeSNO> aj_ = context.Operators.Where<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ah_, ai_);
				Tuple_FbAEUOYETObSHBafYbFNIeSNO ak_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_);

				return ak_;
			};
			IEnumerable<Tuple_FbAEUOYETObSHBafYbFNIeSNO> m_ = context.Operators.Select<Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(k_, l_);
			Tuple_FbAEUOYETObSHBafYbFNIeSNO n_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(m_);

			return n_;
		};
		IEnumerable<Tuple_FbAEUOYETObSHBafYbFNIeSNO> f_ = context.Operators.Select<Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		Tuple_FbAEUOYETObSHBafYbFNIeSNO g_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Service and Condition")]
	public Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Service_and_Condition(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		Tuple_GjTATZbNccdVYWChGHHdRUXSM a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		Tuple_GjTATZbNccdVYWChGHHdRUXSM[] b_ = new Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
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

					return k_;
				}
				else
				{
					Tuple_FbAEUOYETObSHBafYbFNIeSNO l_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet);

					return l_;
				};
			};

			return j_();
		};
		IEnumerable<Tuple_FbAEUOYETObSHBafYbFNIeSNO> d_ = context.Operators.Select<Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		Tuple_FbAEUOYETObSHBafYbFNIeSNO e_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);
		Tuple_FbAEUOYETObSHBafYbFNIeSNO[] f_ = new Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
		{
			e_,
		};
		bool? g_(Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
		{
			bool? m_ = context.Operators.Not((bool?)(FinalList is null));

			return m_;
		};
		IEnumerable<Tuple_FbAEUOYETObSHBafYbFNIeSNO> h_ = context.Operators.Where<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_, g_);
		Tuple_FbAEUOYETObSHBafYbFNIeSNO i_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(h_);

		return i_;
	}

    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
	public IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_or_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			bool? e_(Claim.ItemComponent @this)
			{
				bool? ad_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

				return ad_;
			};
			IEnumerable<Claim.ItemComponent> f_ = context.Operators.Where<Claim.ItemComponent>(AllClaims?.Item, e_);
			CodeableConcept g_(Claim.ItemComponent @this) => 
				@this?.ProductOrService;
			IEnumerable<CodeableConcept> h_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(f_, g_);
			bool? i_(CodeableConcept @this)
			{
				bool? ae_ = context.Operators.Not((bool?)(@this?.Coding is null));

				return ae_;
			};
			IEnumerable<CodeableConcept> j_ = context.Operators.Where<CodeableConcept>(h_, i_);
			List<Coding> k_(CodeableConcept @this) => 
				@this?.Coding;
			IEnumerable<List<Coding>> l_ = context.Operators.Select<CodeableConcept, List<Coding>>(j_, k_);
			IEnumerable<Coding> m_ = context.Operators.Flatten<Coding>(l_);
			bool? n_(Coding ProductOrServiceCode)
			{
				CqlCode af_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				bool? ag_ = context.Operators.In<CqlCode>(af_, ProductOrServiceValueSet);

				return ag_;
			};
			IEnumerable<Coding> o_ = context.Operators.Where<Coding>(m_, n_);
			bool? p_ = context.Operators.Exists<Coding>(o_);
			bool? q_(Claim.DiagnosisComponent @this)
			{
				bool? ah_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

				return ah_;
			};
			IEnumerable<Claim.DiagnosisComponent> r_ = context.Operators.Where<Claim.DiagnosisComponent>((AllClaims?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), q_);
			DataType s_(Claim.DiagnosisComponent @this) => 
				@this?.Diagnosis;
			IEnumerable<DataType> t_ = context.Operators.Select<Claim.DiagnosisComponent, DataType>(r_, s_);
			bool? u_(DataType @this)
			{
				object ai_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				bool? aj_ = context.Operators.Not((bool?)(ai_ is null));

				return aj_;
			};
			IEnumerable<DataType> v_ = context.Operators.Where<DataType>(t_, u_);
			object w_(DataType @this)
			{
				object ak_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return ak_;
			};
			IEnumerable<object> x_ = context.Operators.Select<DataType, object>(v_, w_);
			IEnumerable<object> y_ = context.Operators.FlattenLateBoundList(x_);
			bool? z_(object DiagnosisCode)
			{
				CqlCode al_ = FHIRHelpers_4_0_001.ToCode((DiagnosisCode as Coding));
				bool? am_ = context.Operators.In<CqlCode>(al_, DiagnosisValueSet);

				return am_;
			};
			IEnumerable<object> aa_ = context.Operators.Where<object>(y_, z_);
			bool? ab_ = context.Operators.Exists<object>(aa_);
			bool? ac_ = context.Operators.Or(p_, ab_);

			return ac_;
		};
		IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);
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
							CqlCode av_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
							bool? aw_ = context.Operators.In<CqlCode>(av_, ProductOrServiceValueSet);

							return aw_;
						};
						IEnumerable<Coding> at_ = context.Operators.Where<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), as_);
						bool? au_ = context.Operators.Exists<Coding>(at_);

						return au_;
					};
					IEnumerable<Claim.ItemComponent> aq_ = context.Operators.Where<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), ap_);
					bool? ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);

					return (ar_ ?? false);
				};
				if (ao_())
				{
					bool? ax_(Claim.ItemComponent ResponseItem)
					{
						bool? ba_(Coding ProductOrServiceCode)
						{
							CqlCode bd_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
							bool? be_ = context.Operators.In<CqlCode>(bd_, ProductOrServiceValueSet);

							return be_;
						};
						IEnumerable<Coding> bb_ = context.Operators.Where<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), ba_);
						bool? bc_ = context.Operators.Exists<Coding>(bb_);

						return bc_;
					};
					IEnumerable<Claim.ItemComponent> ay_ = context.Operators.Where<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), ax_);
					Tuple_DXaYeZVOEAELKIhLMVHZBeASM az_ = new Tuple_DXaYeZVOEAELKIhLMVHZBeASM
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
						Integer bi_ = context.Operators.Convert<Integer>(ResponseItem?.SequenceElement);
						bool? bj_ = context.Operators.Equal(bi_?.Value, 1);

						return bj_;
					};
					IEnumerable<Claim.ItemComponent> bg_ = context.Operators.Where<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), bf_);
					Tuple_DXaYeZVOEAELKIhLMVHZBeASM bh_ = new Tuple_DXaYeZVOEAELKIhLMVHZBeASM
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
		IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> d_ = context.Operators.Select<Claim, Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services or Conditions")]
	public Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> b_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ c_ = new Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = a_,
			MedicalClaim = b_,
		};
		Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[] d_ = new Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
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
							string y_ = context.Operators.Convert<string>(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: null));
							string z_ = context.Operators.Convert<string>(pClaim?.Response?.Request?.ReferenceElement);
							string aa_ = NCQAFHIRBase_1_0_0.GetId(z_);
							bool? ab_ = context.Operators.Equal(y_, aa_);
							Integer ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							Integer ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							bool? ae_ = context.Operators.Equal(ac_, ad_);
							bool? af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						IEnumerable<ClaimResponse.ItemComponent> v_ = context.Operators.Where<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> x_ = context.Operators.Select<ClaimResponse.ItemComponent, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_, w_);

						return x_;
					};
					IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> s_ = context.Operators.SelectMany<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimAndResponse?.PaidMedicalClaimResponse, r_);
					bool? t_ = context.Operators.Exists<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(s_);

					return t_;
				};
				IEnumerable<Claim.ItemComponent> p_ = context.Operators.Where<Claim.ItemComponent>(medClaim?.LineItems, o_);
				Tuple_CAKcSTUVVXcPjYRXATiiRAEMg q_ = new Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			IEnumerable<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> i_ = context.Operators.Select<Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimAndResponse?.MedicalClaim, h_);
			Tuple_CTafBejCOJKDPBQMRaUKGZGDD j_ = new Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = i_,
			};
			Tuple_CTafBejCOJKDPBQMRaUKGZGDD[] k_ = new Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
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
							bool? as_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return as_;
						};
						IEnumerable<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> an_ = context.Operators.Where<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, am_);
						IEnumerable<Claim.ItemComponent> ao_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						IEnumerable<IEnumerable<Claim.ItemComponent>> ap_ = context.Operators.Select<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(an_, ao_);
						IEnumerable<Claim.ItemComponent> aq_ = context.Operators.Flatten<Claim.ItemComponent>(ap_);
						bool? ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);

						return (ar_ ?? false);
					};
					if (al_())
					{
						bool? at_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							bool? bf_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return bf_;
						};
						IEnumerable<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> au_ = context.Operators.Where<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, at_);
						Tuple_DXaYeZVOEAELKIhLMVHZBeASM av_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.PaidClaim;
						IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> aw_ = context.Operators.Select<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(au_, av_);
						bool? ax_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							bool? bg_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bg_;
						};
						IEnumerable<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> ay_ = context.Operators.Where<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, ax_);
						IEnumerable<Claim.ItemComponent> az_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						IEnumerable<IEnumerable<Claim.ItemComponent>> ba_ = context.Operators.Select<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(ay_, az_);
						IEnumerable<Claim.ItemComponent> bb_ = context.Operators.Flatten<Claim.ItemComponent>(ba_);
						CqlInterval<CqlDateTime> bc_(Claim.ItemComponent PaidItem)
						{
							CqlInterval<CqlDateTime> bh_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced);

							return bh_;
						};
						IEnumerable<CqlInterval<CqlDateTime>> bd_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, bc_);
						Tuple_FbAEUOYETObSHBafYbFNIeSNO be_ = new Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = aw_,
							ServicePeriod = bd_,
						};

						return be_;
					}
					else
					{
						Tuple_FbAEUOYETObSHBafYbFNIeSNO bi_ = null;

						return bi_;
					};
				};
				Tuple_FbAEUOYETObSHBafYbFNIeSNO[] ah_ = new Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ag_(),
				};
				bool? ai_(Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					bool? bj_ = context.Operators.Not((bool?)(FinalList is null));

					return bj_;
				};
				IEnumerable<Tuple_FbAEUOYETObSHBafYbFNIeSNO> aj_ = context.Operators.Where<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ah_, ai_);
				Tuple_FbAEUOYETObSHBafYbFNIeSNO ak_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_);

				return ak_;
			};
			IEnumerable<Tuple_FbAEUOYETObSHBafYbFNIeSNO> m_ = context.Operators.Select<Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(k_, l_);
			Tuple_FbAEUOYETObSHBafYbFNIeSNO n_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(m_);

			return n_;
		};
		IEnumerable<Tuple_FbAEUOYETObSHBafYbFNIeSNO> f_ = context.Operators.Select<Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		Tuple_FbAEUOYETObSHBafYbFNIeSNO g_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services or Conditions")]
	public Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		Tuple_GjTATZbNccdVYWChGHHdRUXSM a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		Tuple_GjTATZbNccdVYWChGHHdRUXSM[] b_ = new Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
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

					return g_;
				}
				else
				{
					Tuple_FbAEUOYETObSHBafYbFNIeSNO h_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet);

					return h_;
				};
			};

			return f_();
		};
		IEnumerable<Tuple_FbAEUOYETObSHBafYbFNIeSNO> d_ = context.Operators.Select<Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		Tuple_FbAEUOYETObSHBafYbFNIeSNO e_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);

		return e_;
	}

    [CqlDeclaration("Get All Claims With Procedure Only")]
	public IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_Only(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			bool? e_(Claim.ItemComponent @this)
			{
				bool? q_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

				return q_;
			};
			IEnumerable<Claim.ItemComponent> f_ = context.Operators.Where<Claim.ItemComponent>(AllClaims?.Item, e_);
			CodeableConcept g_(Claim.ItemComponent @this) => 
				@this?.ProductOrService;
			IEnumerable<CodeableConcept> h_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(f_, g_);
			bool? i_(CodeableConcept @this)
			{
				bool? r_ = context.Operators.Not((bool?)(@this?.Coding is null));

				return r_;
			};
			IEnumerable<CodeableConcept> j_ = context.Operators.Where<CodeableConcept>(h_, i_);
			List<Coding> k_(CodeableConcept @this) => 
				@this?.Coding;
			IEnumerable<List<Coding>> l_ = context.Operators.Select<CodeableConcept, List<Coding>>(j_, k_);
			IEnumerable<Coding> m_ = context.Operators.Flatten<Coding>(l_);
			bool? n_(Coding ProductOrServiceCode)
			{
				CqlCode s_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				bool? t_ = context.Operators.In<CqlCode>(s_, ProductOrServiceValueSet);

				return t_;
			};
			IEnumerable<Coding> o_ = context.Operators.Where<Coding>(m_, n_);
			bool? p_ = context.Operators.Exists<Coding>(o_);

			return p_;
		};
		IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);
		Tuple_DXaYeZVOEAELKIhLMVHZBeASM c_(Claim AllClaims)
		{
			bool? u_(Claim.ItemComponent ResponseItem)
			{
				bool? x_(Coding ProductOrServiceCode)
				{
					CqlCode aa_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					bool? ab_ = context.Operators.In<CqlCode>(aa_, ProductOrServiceValueSet);

					return ab_;
				};
				IEnumerable<Coding> y_ = context.Operators.Where<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), x_);
				bool? z_ = context.Operators.Exists<Coding>(y_);

				return z_;
			};
			IEnumerable<Claim.ItemComponent> v_ = context.Operators.Where<Claim.ItemComponent>((AllClaims?.Item as IEnumerable<Claim.ItemComponent>), u_);
			Tuple_DXaYeZVOEAELKIhLMVHZBeASM w_ = new Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = AllClaims,
				ClaimID = AllClaims?.IdElement,
				LineItems = v_,
			};

			return w_;
		};
		IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> d_ = context.Operators.Select<Claim, Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services Only")]
	public Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> b_ = this.Get_All_Claims_With_Procedure_Only(claim, ProductOrServiceValueSet);
		Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ c_ = new Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = a_,
			MedicalClaim = b_,
		};
		Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[] d_ = new Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
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
							string y_ = context.Operators.Convert<string>(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: null));
							string z_ = context.Operators.Convert<string>(pClaim?.Response?.Request?.ReferenceElement);
							string aa_ = NCQAFHIRBase_1_0_0.GetId(z_);
							bool? ab_ = context.Operators.Equal(y_, aa_);
							Integer ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							Integer ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							bool? ae_ = context.Operators.Equal(ac_, ad_);
							bool? af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						IEnumerable<ClaimResponse.ItemComponent> v_ = context.Operators.Where<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> x_ = context.Operators.Select<ClaimResponse.ItemComponent, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_, w_);

						return x_;
					};
					IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> s_ = context.Operators.SelectMany<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimAndResponse?.PaidMedicalClaimResponse, r_);
					bool? t_ = context.Operators.Exists<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(s_);

					return t_;
				};
				IEnumerable<Claim.ItemComponent> p_ = context.Operators.Where<Claim.ItemComponent>(medClaim?.LineItems, o_);
				Tuple_CAKcSTUVVXcPjYRXATiiRAEMg q_ = new Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			IEnumerable<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> i_ = context.Operators.Select<Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimAndResponse?.MedicalClaim, h_);
			Tuple_CTafBejCOJKDPBQMRaUKGZGDD j_ = new Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = i_,
			};
			Tuple_CTafBejCOJKDPBQMRaUKGZGDD[] k_ = new Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
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
							bool? as_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return as_;
						};
						IEnumerable<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> an_ = context.Operators.Where<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, am_);
						IEnumerable<Claim.ItemComponent> ao_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						IEnumerable<IEnumerable<Claim.ItemComponent>> ap_ = context.Operators.Select<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(an_, ao_);
						IEnumerable<Claim.ItemComponent> aq_ = context.Operators.Flatten<Claim.ItemComponent>(ap_);
						bool? ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);

						return (ar_ ?? false);
					};
					if (al_())
					{
						bool? at_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							bool? bf_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return bf_;
						};
						IEnumerable<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> au_ = context.Operators.Where<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, at_);
						Tuple_DXaYeZVOEAELKIhLMVHZBeASM av_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.PaidClaim;
						IEnumerable<Tuple_DXaYeZVOEAELKIhLMVHZBeASM> aw_ = context.Operators.Select<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(au_, av_);
						bool? ax_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							bool? bg_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bg_;
						};
						IEnumerable<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> ay_ = context.Operators.Where<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, ax_);
						IEnumerable<Claim.ItemComponent> az_(Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						IEnumerable<IEnumerable<Claim.ItemComponent>> ba_ = context.Operators.Select<Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(ay_, az_);
						IEnumerable<Claim.ItemComponent> bb_ = context.Operators.Flatten<Claim.ItemComponent>(ba_);
						CqlInterval<CqlDateTime> bc_(Claim.ItemComponent PaidItem)
						{
							CqlInterval<CqlDateTime> bh_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced);

							return bh_;
						};
						IEnumerable<CqlInterval<CqlDateTime>> bd_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, bc_);
						Tuple_FbAEUOYETObSHBafYbFNIeSNO be_ = new Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = aw_,
							ServicePeriod = bd_,
						};

						return be_;
					}
					else
					{
						Tuple_FbAEUOYETObSHBafYbFNIeSNO bi_ = null;

						return bi_;
					};
				};
				Tuple_FbAEUOYETObSHBafYbFNIeSNO[] ah_ = new Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ag_(),
				};
				bool? ai_(Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					bool? bj_ = context.Operators.Not((bool?)(FinalList is null));

					return bj_;
				};
				IEnumerable<Tuple_FbAEUOYETObSHBafYbFNIeSNO> aj_ = context.Operators.Where<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ah_, ai_);
				Tuple_FbAEUOYETObSHBafYbFNIeSNO ak_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_);

				return ak_;
			};
			IEnumerable<Tuple_FbAEUOYETObSHBafYbFNIeSNO> m_ = context.Operators.Select<Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(k_, l_);
			Tuple_FbAEUOYETObSHBafYbFNIeSNO n_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(m_);

			return n_;
		};
		IEnumerable<Tuple_FbAEUOYETObSHBafYbFNIeSNO> f_ = context.Operators.Select<Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		Tuple_FbAEUOYETObSHBafYbFNIeSNO g_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services Only")]
	public Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		Tuple_GjTATZbNccdVYWChGHHdRUXSM a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		Tuple_GjTATZbNccdVYWChGHHdRUXSM[] b_ = new Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
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

					return g_;
				}
				else
				{
					Tuple_FbAEUOYETObSHBafYbFNIeSNO h_ = this.Get_Corresponding_Claim_for_Services_Only(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet);

					return h_;
				};
			};

			return f_();
		};
		IEnumerable<Tuple_FbAEUOYETObSHBafYbFNIeSNO> d_ = context.Operators.Select<Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		Tuple_FbAEUOYETObSHBafYbFNIeSNO e_ = context.Operators.SingletonFrom<Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);

		return e_;
	}

    [CqlDeclaration("Get All Pharmacy Claims and Claim Responses")]
	public Tuple_ENRfaLDabXeaNdJYVdOfebBTR Get_All_Pharmacy_Claims_and_Claim_Responses(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		IEnumerable<ClaimResponse> a_ = this.Pharmacy_Claims_Response(claimResponse);
		IEnumerable<Claim> b_ = this.Pharmacy_Claims(claim);
		Tuple_ENRfaLDabXeaNdJYVdOfebBTR c_ = new Tuple_ENRfaLDabXeaNdJYVdOfebBTR
		{
			PharmacyClaimResponse = a_,
			PharmacyClaim = b_,
		};

		return c_;
	}

    [CqlDeclaration("Get Corresponding Claim for Pharmacy Services")]
	public Tuple_BOANHMYNiCIfFjRZRMEXCcXTO Get_Corresponding_Claim_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> b_ = this.Pharmacy_Claim_With_Medication(claim, ProductOrServiceValueSet);
		Tuple_EDASHZgEHSQJbecPJIZegfOIB c_ = new Tuple_EDASHZgEHSQJbecPJIZegfOIB
		{
			PaidPharmacyClaimResponse = a_,
			MedicalClaim = b_,
		};
		Tuple_EDASHZgEHSQJbecPJIZegfOIB[] d_ = new Tuple_EDASHZgEHSQJbecPJIZegfOIB[]
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
							string y_ = context.Operators.Convert<string>(((medClaim?.Claim is Resource)
									? ((medClaim?.Claim as Resource).IdElement)
									: null));
							string z_ = context.Operators.Convert<string>(pClaim?.Response?.Request?.ReferenceElement);
							string aa_ = NCQAFHIRBase_1_0_0.GetId(z_);
							bool? ab_ = context.Operators.Equal(y_, aa_);
							Integer ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							Integer ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							bool? ae_ = context.Operators.Equal(ac_, ad_);
							bool? af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						IEnumerable<ClaimResponse.ItemComponent> v_ = context.Operators.Where<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> x_ = context.Operators.Select<ClaimResponse.ItemComponent, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_, w_);

						return x_;
					};
					IEnumerable<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> s_ = context.Operators.SelectMany<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimAndResponse?.PaidPharmacyClaimResponse, r_);
					bool? t_ = context.Operators.Exists<Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(s_);

					return t_;
				};
				IEnumerable<Claim.ItemComponent> p_ = context.Operators.Where<Claim.ItemComponent>(medClaim?.LineItem, o_);
				Tuple_DgRFfDaEDhBINgYbMaeRWZWVT q_ = new Tuple_DgRFfDaEDhBINgYbMaeRWZWVT
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			IEnumerable<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT> i_ = context.Operators.Select<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC, Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimAndResponse?.MedicalClaim, h_);
			Tuple_DOALBUVOFWRHAUjdPUNBfNdUB j_ = new Tuple_DOALBUVOFWRHAUjdPUNBfNdUB
			{
				AggregateClaim = i_,
			};
			Tuple_DOALBUVOFWRHAUjdPUNBfNdUB[] k_ = new Tuple_DOALBUVOFWRHAUjdPUNBfNdUB[]
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
							bool? as_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return as_;
						};
						IEnumerable<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT> an_ = context.Operators.Where<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, am_);
						IEnumerable<Claim.ItemComponent> ao_(Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => 
							@this?.ClaimItem;
						IEnumerable<IEnumerable<Claim.ItemComponent>> ap_ = context.Operators.Select<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(an_, ao_);
						IEnumerable<Claim.ItemComponent> aq_ = context.Operators.Flatten<Claim.ItemComponent>(ap_);
						bool? ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);

						return (ar_ ?? false);
					};
					if (al_())
					{
						bool? at_(Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							bool? bm_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return bm_;
						};
						IEnumerable<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT> au_ = context.Operators.Where<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, at_);
						Tuple_FOLKddIQBPRMYYfjeMUjEIBhC av_(Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => 
							@this?.PaidClaim;
						IEnumerable<Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> aw_ = context.Operators.Select<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(au_, av_);
						bool? ax_(Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							bool? bn_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bn_;
						};
						IEnumerable<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT> ay_ = context.Operators.Where<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, ax_);
						IEnumerable<Claim.ItemComponent> az_(Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => 
							@this?.ClaimItem;
						IEnumerable<IEnumerable<Claim.ItemComponent>> ba_ = context.Operators.Select<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(ay_, az_);
						IEnumerable<Claim.ItemComponent> bb_ = context.Operators.Flatten<Claim.ItemComponent>(ba_);
						CqlInterval<CqlDateTime> bc_(Claim.ItemComponent PaidItem)
						{
							CqlInterval<CqlDateTime> bo_ = NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced);

							return bo_;
						};
						IEnumerable<CqlInterval<CqlDateTime>> bd_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, bc_);
						bool? be_(Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							bool? bp_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bp_;
						};
						IEnumerable<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT> bf_ = context.Operators.Where<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, be_);
						IEnumerable<IEnumerable<Claim.ItemComponent>> bh_ = context.Operators.Select<Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(bf_, az_);
						IEnumerable<Claim.ItemComponent> bi_ = context.Operators.Flatten<Claim.ItemComponent>(bh_);
						CqlInterval<CqlDate> bj_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDate> bq_()
							{
								if ((context.Operators.Not((bool?)(i?.Quantity is null)) ?? false))
								{
									CqlInterval<CqlDateTime> br_ = NCQAFHIRBase_1_0_0.Normalize_Interval(i?.Serviced);
									CqlDateTime bs_ = context.Operators.Start(br_);
									CqlDate bt_ = context.Operators.ConvertDateTimeToDate(bs_);
									CqlDateTime bv_ = context.Operators.Start(br_);
									decimal? bw_ = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement);
									CqlDateTime bx_ = context.Operators.Add(bv_, new CqlQuantity(bw_, "day"));
									CqlQuantity by_ = context.Operators.Quantity(1m, "day");
									CqlDateTime bz_ = context.Operators.Subtract(bx_, by_);
									CqlDate ca_ = context.Operators.ConvertDateTimeToDate(bz_);
									CqlInterval<CqlDate> cb_ = context.Operators.Interval(bt_, ca_, true, true);

									return cb_;
								}
								else
								{
									CqlInterval<CqlDate> cc_ = null;

									return cc_;
								};
							};

							return bq_();
						};
						IEnumerable<CqlInterval<CqlDate>> bk_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDate>>(bi_, bj_);
						Tuple_BOANHMYNiCIfFjRZRMEXCcXTO bl_ = new Tuple_BOANHMYNiCIfFjRZRMEXCcXTO
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

						return cd_;
					};
				};
				Tuple_BOANHMYNiCIfFjRZRMEXCcXTO[] ah_ = new Tuple_BOANHMYNiCIfFjRZRMEXCcXTO[]
				{
					ag_(),
				};
				bool? ai_(Tuple_BOANHMYNiCIfFjRZRMEXCcXTO FinalList)
				{
					bool? ce_ = context.Operators.Not((bool?)(FinalList is null));

					return ce_;
				};
				IEnumerable<Tuple_BOANHMYNiCIfFjRZRMEXCcXTO> aj_ = context.Operators.Where<Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(ah_, ai_);
				Tuple_BOANHMYNiCIfFjRZRMEXCcXTO ak_ = context.Operators.SingletonFrom<Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(aj_);

				return ak_;
			};
			IEnumerable<Tuple_BOANHMYNiCIfFjRZRMEXCcXTO> m_ = context.Operators.Select<Tuple_DOALBUVOFWRHAUjdPUNBfNdUB, Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(k_, l_);
			Tuple_BOANHMYNiCIfFjRZRMEXCcXTO n_ = context.Operators.SingletonFrom<Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(m_);

			return n_;
		};
		IEnumerable<Tuple_BOANHMYNiCIfFjRZRMEXCcXTO> f_ = context.Operators.Select<Tuple_EDASHZgEHSQJbecPJIZegfOIB, Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(d_, e_);
		Tuple_BOANHMYNiCIfFjRZRMEXCcXTO g_ = context.Operators.SingletonFrom<Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Pharmacy Services")]
	public Tuple_BOANHMYNiCIfFjRZRMEXCcXTO Get_Paid_Claims_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		Tuple_ENRfaLDabXeaNdJYVdOfebBTR a_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(claimResponse, claim);
		Tuple_ENRfaLDabXeaNdJYVdOfebBTR[] b_ = new Tuple_ENRfaLDabXeaNdJYVdOfebBTR[]
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

					return g_;
				}
				else
				{
					Tuple_BOANHMYNiCIfFjRZRMEXCcXTO h_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(PharmacyClaimAndResponse?.PharmacyClaimResponse, PharmacyClaimAndResponse?.PharmacyClaim, ProductOrServiceValueSet);

					return h_;
				};
			};

			return f_();
		};
		IEnumerable<Tuple_BOANHMYNiCIfFjRZRMEXCcXTO> d_ = context.Operators.Select<Tuple_ENRfaLDabXeaNdJYVdOfebBTR, Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(b_, c_);
		Tuple_BOANHMYNiCIfFjRZRMEXCcXTO e_ = context.Operators.SingletonFrom<Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(d_);

		return e_;
	}

    [CqlDeclaration("Get Claim With Corresponding Claim Response")]
	public IEnumerable<Tuple_HQUdYchKGNXjEWMCbcWSEKdVI> Get_Claim_With_Corresponding_Claim_Response(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		Tuple_HQUdYchKGNXjEWMCbcWSEKdVI a_(Claim Claim)
		{
			bool? c_(ClaimResponse CR)
			{
				string h_ = context.Operators.Convert<string>(Claim?.IdElement);
				string i_ = context.Operators.Convert<string>(CR?.Request?.ReferenceElement);
				string j_ = NCQAFHIRBase_1_0_0.GetId(i_);
				bool? k_ = context.Operators.Equal(h_, j_);

				return k_;
			};
			IEnumerable<ClaimResponse> d_ = context.Operators.Where<ClaimResponse>(claimResponse, c_);
			bool? e_(Claim C)
			{
				string l_ = context.Operators.Convert<string>(Claim?.IdElement);
				bool? m_(ClaimResponse CR)
				{
					string aa_ = context.Operators.Convert<string>(Claim?.IdElement);
					string ab_ = context.Operators.Convert<string>(CR?.Request?.ReferenceElement);
					string ac_ = NCQAFHIRBase_1_0_0.GetId(ab_);
					bool? ad_ = context.Operators.Equal(aa_, ac_);

					return ad_;
				};
				IEnumerable<ClaimResponse> n_ = context.Operators.Where<ClaimResponse>(claimResponse, m_);
				bool? o_(ClaimResponse @this)
				{
					bool? ae_ = context.Operators.Not((bool?)(@this?.Request is null));

					return ae_;
				};
				IEnumerable<ClaimResponse> p_ = context.Operators.Where<ClaimResponse>(n_, o_);
				ResourceReference q_(ClaimResponse @this) => 
					@this?.Request;
				IEnumerable<ResourceReference> r_ = context.Operators.Select<ClaimResponse, ResourceReference>(p_, q_);
				bool? s_(ResourceReference @this)
				{
					bool? af_ = context.Operators.Not((bool?)(@this?.ReferenceElement is null));

					return af_;
				};
				IEnumerable<ResourceReference> t_ = context.Operators.Where<ResourceReference>(r_, s_);
				FhirString u_(ResourceReference @this) => 
					@this?.ReferenceElement;
				IEnumerable<FhirString> v_ = context.Operators.Select<ResourceReference, FhirString>(t_, u_);
				FhirString w_ = context.Operators.SingletonFrom<FhirString>(v_);
				string x_ = context.Operators.Convert<string>(w_);
				string y_ = NCQAFHIRBase_1_0_0.GetId(x_);
				bool? z_ = context.Operators.Equal(l_, y_);

				return z_;
			};
			IEnumerable<Claim> f_ = context.Operators.Where<Claim>(claim, e_);
			Tuple_HQUdYchKGNXjEWMCbcWSEKdVI g_ = new Tuple_HQUdYchKGNXjEWMCbcWSEKdVI
			{
				ClaimResponse = d_,
				OriginalClaim = f_,
			};

			return g_;
		};
		IEnumerable<Tuple_HQUdYchKGNXjEWMCbcWSEKdVI> b_ = context.Operators.Select<Claim, Tuple_HQUdYchKGNXjEWMCbcWSEKdVI>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Medical Claims With Nonacute or Acute Inpatient Discharge")]
	public Tuple_CYfZbbEjJgLODachBhLiZaXQE Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(IEnumerable<Claim> claim)
	{
		IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(claim);
		Tuple_EWMRhBHgcOUGZLgIBDbjPHISO b_ = new Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = a_,
		};
		Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[] c_ = new Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
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

					return n_;
				}
				else
				{
					bool? o_(Claim c)
					{
						bool? q_(Claim.ItemComponent i)
						{
							CqlConcept t_ = FHIRHelpers_4_0_001.ToConcept(i?.Revenue);
							bool? u_(CqlCode rev)
							{
								CqlValueSet x_ = this.Inpatient_Stay();
								bool? y_ = context.Operators.StringInValueSet(rev?.code, x_);

								return y_;
							};
							IEnumerable<CqlCode> v_ = context.Operators.Where<CqlCode>((t_?.codes as IEnumerable<CqlCode>), u_);
							bool? w_ = context.Operators.Exists<CqlCode>(v_);

							return w_;
						};
						IEnumerable<Claim.ItemComponent> r_ = context.Operators.Where<Claim.ItemComponent>((c?.Item as IEnumerable<Claim.ItemComponent>), q_);
						bool? s_ = context.Operators.Exists<Claim.ItemComponent>(r_);

						return s_;
					};
					IEnumerable<Claim> p_ = context.Operators.Where<Claim>(ClaimWithInpatientStay?.MedicalClaim, o_);

					return p_;
				};
			};
			IEnumerable<Claim> h_()
			{
				if ((ClaimWithInpatientStay?.MedicalClaim is null))
				{
					IEnumerable<Claim> z_ = null;

					return z_;
				}
				else
				{
					bool? aa_(Claim c)
					{
						bool? ac_(Claim.ItemComponent i)
						{
							CqlConcept aj_ = FHIRHelpers_4_0_001.ToConcept(i?.Revenue);
							bool? ak_(CqlCode rev)
							{
								CqlValueSet an_ = this.Nonacute_Inpatient_Stay();
								bool? ao_ = context.Operators.StringInValueSet(rev?.code, an_);

								return ao_;
							};
							IEnumerable<CqlCode> al_ = context.Operators.Where<CqlCode>((aj_?.codes as IEnumerable<CqlCode>), ak_);
							bool? am_ = context.Operators.Exists<CqlCode>(al_);

							return am_;
						};
						IEnumerable<Claim.ItemComponent> ad_ = context.Operators.Where<Claim.ItemComponent>((c?.Item as IEnumerable<Claim.ItemComponent>), ac_);
						bool? ae_ = context.Operators.Exists<Claim.ItemComponent>(ad_);
						bool? af_(Coding tob)
						{
							CqlValueSet ap_ = this.Nonacute_Inpatient_Stay();
							bool? aq_ = context.Operators.StringInValueSet(tob?.CodeElement?.Value, ap_);

							return aq_;
						};
						IEnumerable<Coding> ag_ = context.Operators.Where<Coding>((c?.SubType?.Coding as IEnumerable<Coding>), af_);
						bool? ah_ = context.Operators.Exists<Coding>(ag_);
						bool? ai_ = context.Operators.Or(ae_, ah_);

						return ai_;
					};
					IEnumerable<Claim> ab_ = context.Operators.Where<Claim>(ClaimWithInpatientStay?.MedicalClaim, aa_);

					return ab_;
				};
			};
			Tuple_BcRbRSiZXcAFIKNCdPcQULMGb i_ = new Tuple_BcRbRSiZXcAFIKNCdPcQULMGb
			{
				InpatientStayLineItems = g_(),
				NonacuteInpatientLineItems = h_(),
			};
			Tuple_BcRbRSiZXcAFIKNCdPcQULMGb[] j_ = new Tuple_BcRbRSiZXcAFIKNCdPcQULMGb[]
			{
				i_,
			};
			Tuple_CYfZbbEjJgLODachBhLiZaXQE k_(Tuple_BcRbRSiZXcAFIKNCdPcQULMGb LineItemDefinition)
			{
				IEnumerable<Claim> ar_(Claim nonAcuteInpatientStay)
				{
					bool? ax_(Claim inpatientStay)
					{
						bool? bb_ = context.Operators.Equal(nonAcuteInpatientStay?.IdElement, inpatientStay?.IdElement);

						return bb_;
					};
					IEnumerable<Claim> ay_ = context.Operators.Where<Claim>(LineItemDefinition?.InpatientStayLineItems, ax_);
					Claim az_(Claim inpatientStay) => 
						nonAcuteInpatientStay;
					IEnumerable<Claim> ba_ = context.Operators.Select<Claim, Claim>(ay_, az_);

					return ba_;
				};
				IEnumerable<Claim> as_ = context.Operators.SelectMany<Claim, Claim>(LineItemDefinition?.NonacuteInpatientLineItems, ar_);
				IEnumerable<Claim> at_(Claim inpatientStay)
				{
					bool? bc_(Claim nonAcuteInpatientStay)
					{
						bool? bg_ = context.Operators.Equal(inpatientStay?.IdElement, nonAcuteInpatientStay?.IdElement);

						return bg_;
					};
					IEnumerable<Claim> bd_ = context.Operators.Where<Claim>(LineItemDefinition?.NonacuteInpatientLineItems, bc_);
					Claim be_(Claim nonAcuteInpatientStay) => 
						inpatientStay;
					IEnumerable<Claim> bf_ = context.Operators.Select<Claim, Claim>(bd_, be_);

					return bf_;
				};
				IEnumerable<Claim> au_ = context.Operators.SelectMany<Claim, Claim>(LineItemDefinition?.InpatientStayLineItems, at_);
				IEnumerable<Claim> av_ = context.Operators.ListExcept<Claim>(LineItemDefinition?.InpatientStayLineItems, au_);
				Tuple_CYfZbbEjJgLODachBhLiZaXQE aw_ = new Tuple_CYfZbbEjJgLODachBhLiZaXQE
				{
					InpatientDischarge = LineItemDefinition?.InpatientStayLineItems,
					NonacuteInpatientDischarge = as_,
					AcuteInpatientDischarge = av_,
				};

				return aw_;
			};
			IEnumerable<Tuple_CYfZbbEjJgLODachBhLiZaXQE> l_ = context.Operators.Select<Tuple_BcRbRSiZXcAFIKNCdPcQULMGb, Tuple_CYfZbbEjJgLODachBhLiZaXQE>(j_, k_);
			Tuple_CYfZbbEjJgLODachBhLiZaXQE m_ = context.Operators.SingletonFrom<Tuple_CYfZbbEjJgLODachBhLiZaXQE>(l_);

			return m_;
		};
		IEnumerable<Tuple_CYfZbbEjJgLODachBhLiZaXQE> e_ = context.Operators.Select<Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, Tuple_CYfZbbEjJgLODachBhLiZaXQE>(c_, d_);
		Tuple_CYfZbbEjJgLODachBhLiZaXQE f_ = context.Operators.SingletonFrom<Tuple_CYfZbbEjJgLODachBhLiZaXQE>(e_);

		return f_;
	}

    [CqlDeclaration("Get Prescriber NPI from Claims")]
	public Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Prescriber_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		Tuple_GIfhUVACThMQNGPGjYhYHEfGS a_(Claim C)
		{
			bool? h_(Claim.CareTeamComponent ct)
			{
				Integer w_ = context.Operators.Convert<Integer>(ct?.SequenceElement);
				int? x_ = FHIRHelpers_4_0_001.ToInteger(w_);
				bool? y_ = context.Operators.Equal(x_, 1);

				return y_;
			};
			IEnumerable<Claim.CareTeamComponent> i_ = context.Operators.Where<Claim.CareTeamComponent>((C?.CareTeam as IEnumerable<Claim.CareTeamComponent>), h_);
			bool? j_(Claim.CareTeamComponent @this)
			{
				bool? z_ = context.Operators.Not((bool?)(@this?.Provider is null));

				return z_;
			};
			IEnumerable<Claim.CareTeamComponent> k_ = context.Operators.Where<Claim.CareTeamComponent>(i_, j_);
			ResourceReference l_(Claim.CareTeamComponent @this) => 
				@this?.Provider;
			IEnumerable<ResourceReference> m_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(k_, l_);
			bool? n_(Claim.CareTeamComponent ct)
			{
				Integer aa_ = context.Operators.Convert<Integer>(ct?.SequenceElement);
				int? ab_ = FHIRHelpers_4_0_001.ToInteger(aa_);
				bool? ac_ = context.Operators.Equal(ab_, 1);

				return ac_;
			};
			IEnumerable<Claim.CareTeamComponent> o_ = context.Operators.Where<Claim.CareTeamComponent>((C?.CareTeam as IEnumerable<Claim.CareTeamComponent>), n_);
			bool? p_(Claim.CareTeamComponent @this)
			{
				bool? ad_ = context.Operators.Not((bool?)(@this?.Provider is null));

				return ad_;
			};
			IEnumerable<Claim.CareTeamComponent> q_ = context.Operators.Where<Claim.CareTeamComponent>(o_, p_);
			IEnumerable<ResourceReference> s_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(q_, l_);
			string t_(ResourceReference p)
			{
				FhirString[] ae_ = new FhirString[]
				{
					p?.ReferenceElement,
				};
				string af_(FhirString r)
				{
					string ai_ = context.Operators.Convert<string>(r);
					string aj_ = NCQAFHIRBase_1_0_0.GetId(ai_);

					return aj_;
				};
				IEnumerable<string> ag_ = context.Operators.Select<FhirString, string>(ae_, af_);
				string ah_ = context.Operators.SingletonFrom<string>(ag_);

				return ah_;
			};
			IEnumerable<string> u_ = context.Operators.Select<ResourceReference, string>(s_, t_);
			Tuple_GIfhUVACThMQNGPGjYhYHEfGS v_ = new Tuple_GIfhUVACThMQNGPGjYhYHEfGS
			{
				SingleCareTeam = C,
				CareTeamsProvider = m_,
				CareTeamsProviderID = u_,
			};

			return v_;
		};
		IEnumerable<Tuple_GIfhUVACThMQNGPGjYhYHEfGS> b_ = context.Operators.Select<Claim, Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(claim, a_);
		Tuple_GMJgYefQcULgUcRJJAbTfRThR c_ = new Tuple_GMJgYefQcULgUcRJJAbTfRThR
		{
			CareTeams = b_,
		};
		Tuple_GMJgYefQcULgUcRJJAbTfRThR[] d_ = new Tuple_GMJgYefQcULgUcRJJAbTfRThR[]
		{
			c_,
		};
		Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY e_(Tuple_GMJgYefQcULgUcRJJAbTfRThR ClaimProperties)
		{
			IEnumerable<Practitioner> ak_ = context.Operators.RetrieveByValueSet<Practitioner>(null, null);
			bool? al_(Practitioner p)
			{
				string as_ = context.Operators.Convert<string>(p?.IdElement);
				bool? at_(Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
				{
					bool? az_ = context.Operators.Not((bool?)(@this?.CareTeamsProviderID is null));

					return az_;
				};
				IEnumerable<Tuple_GIfhUVACThMQNGPGjYhYHEfGS> au_ = context.Operators.Where<Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, at_);
				IEnumerable<string> av_(Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => 
					@this?.CareTeamsProviderID;
				IEnumerable<IEnumerable<string>> aw_ = context.Operators.Select<Tuple_GIfhUVACThMQNGPGjYhYHEfGS, IEnumerable<string>>(au_, av_);
				IEnumerable<string> ax_ = context.Operators.Flatten<string>(aw_);
				bool? ay_ = context.Operators.In<string>(as_, ax_);

				return ay_;
			};
			IEnumerable<Practitioner> am_ = context.Operators.Where<Practitioner>(ak_, al_);
			Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe an_ = new Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe
			{
				Practitioners = am_,
			};
			Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe[] ao_ = new Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe[]
			{
				an_,
			};
			Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY ap_(Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe PractitionerMatch)
			{
				bool? ba_(Practitioner P)
				{
					bool? bj_ = context.Operators.Not((bool?)(P is null));

					return bj_;
				};
				IEnumerable<Practitioner> bb_ = context.Operators.Where<Practitioner>(PractitionerMatch?.Practitioners, ba_);
				Tuple_FNLPNAPOaaMjChWUXdhfgcWIR bc_(Practitioner P)
				{
					bool? bk_(Identifier l)
					{
						bool? bt_ = context.Operators.Equal(l?.SystemElement?.Value, "http://hl7.org/fhir/sid/us-npi");
						CqlConcept bu_ = FHIRHelpers_4_0_001.ToConcept(l?.Type);
						CqlCode bv_ = NCQATerminology_1_0_0.Provider_number();
						CqlConcept bw_ = context.Operators.ConvertCodeToConcept(bv_);
						bool? bx_ = context.Operators.Equivalent(bu_, bw_);
						bool? by_ = context.Operators.And(bt_, bx_);
						bool? bz_ = context.Operators.Not((bool?)(l?.ValueElement?.Value is null));
						bool? ca_ = context.Operators.And(by_, bz_);

						return ca_;
					};
					IEnumerable<Identifier> bl_ = context.Operators.Where<Identifier>((P?.Identifier as IEnumerable<Identifier>), bk_);
					FhirString bm_(Identifier l) => 
						l?.ValueElement;
					IEnumerable<FhirString> bn_ = context.Operators.Select<Identifier, FhirString>(bl_, bm_);
					bool? bo_(Identifier l)
					{
						bool? cb_ = context.Operators.Equal(l?.SystemElement?.Value, "http://hl7.org/fhir/sid/us-npi");
						CqlConcept cc_ = FHIRHelpers_4_0_001.ToConcept(l?.Type);
						CqlCode cd_ = NCQATerminology_1_0_0.Provider_number();
						CqlConcept ce_ = context.Operators.ConvertCodeToConcept(cd_);
						bool? cf_ = context.Operators.Equivalent(cc_, ce_);
						bool? cg_ = context.Operators.And(cb_, cf_);
						bool? ch_ = context.Operators.And(cg_, (bool?)(l?.ValueElement?.Value is null));

						return ch_;
					};
					IEnumerable<Identifier> bp_ = context.Operators.Where<Identifier>((P?.Identifier as IEnumerable<Identifier>), bo_);
					Identifier bq_(Identifier l) => 
						l;
					IEnumerable<Identifier> br_ = context.Operators.Select<Identifier, Identifier>(bp_, bq_);
					Tuple_FNLPNAPOaaMjChWUXdhfgcWIR bs_ = new Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = bn_,
						NullIdentifiers = br_,
					};

					return bs_;
				};
				IEnumerable<Tuple_FNLPNAPOaaMjChWUXdhfgcWIR> bd_ = context.Operators.Select<Practitioner, Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(bb_, bc_);
				Tuple_QDOjYOQaAUWAWKDPBcQCSKDH be_ = new Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = bd_,
				};
				Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[] bf_ = new Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
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
								bool? cq_ = context.Operators.Not((bool?)(@this?.SingleCareTeam is null));

								return cq_;
							};
							IEnumerable<Tuple_GIfhUVACThMQNGPGjYhYHEfGS> cm_ = context.Operators.Where<Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, cl_);
							Claim cn_(Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => 
								@this?.SingleCareTeam;
							IEnumerable<Claim> co_ = context.Operators.Select<Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(cm_, cn_);
							bool? cp_ = context.Operators.Exists<Claim>(co_);

							return (cp_ ?? false);
						};
						if (ck_())
						{
							bool? cr_(Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
							{
								bool? dk_ = context.Operators.Not((bool?)(@this?.SingleCareTeam is null));

								return dk_;
							};
							IEnumerable<Tuple_GIfhUVACThMQNGPGjYhYHEfGS> cs_ = context.Operators.Where<Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, cr_);
							Claim ct_(Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => 
								@this?.SingleCareTeam;
							IEnumerable<Claim> cu_ = context.Operators.Select<Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(cs_, ct_);
							bool? cv_(Claim X) => 
								(bool?)((X?.CareTeam as IEnumerable<Claim.CareTeamComponent>) is null);
							IEnumerable<Claim> cw_ = context.Operators.Where<Claim>(cu_, cv_);
							int? cx_ = context.Operators.Count<Claim>(cw_);
							IEnumerable<FhirString> cy_(Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => 
								X?.AllIdentifiers;
							IEnumerable<IEnumerable<FhirString>> cz_ = context.Operators.Select<Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, cy_);
							IEnumerable<FhirString> da_ = context.Operators.Flatten<FhirString>(cz_);
							FhirString db_(FhirString X) => 
								X;
							IEnumerable<FhirString> dc_ = context.Operators.Select<FhirString, FhirString>(da_, db_);
							int? dd_ = context.Operators.Count<FhirString>(dc_);
							int? de_ = context.Operators.Add(cx_, dd_);
							IEnumerable<Identifier> df_(Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => 
								X?.NullIdentifiers;
							IEnumerable<IEnumerable<Identifier>> dg_ = context.Operators.Select<Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, df_);
							IEnumerable<Identifier> dh_ = context.Operators.Flatten<Identifier>(dg_);
							int? di_ = context.Operators.Count<Identifier>(dh_);
							int? dj_ = context.Operators.Add(de_, di_);

							return dj_;
						}
						else
						{
							return 0;
						};
					};
					Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY cj_ = new Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = ci_(),
					};

					return cj_;
				};
				IEnumerable<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY> bh_ = context.Operators.Select<Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bf_, bg_);
				Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY bi_ = context.Operators.SingletonFrom<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bh_);

				return bi_;
			};
			IEnumerable<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY> aq_ = context.Operators.Select<Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe, Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ao_, ap_);
			Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY ar_ = context.Operators.SingletonFrom<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(aq_);

			return ar_;
		};
		IEnumerable<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY> f_ = context.Operators.Select<Tuple_GMJgYefQcULgUcRJJAbTfRThR, Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(d_, e_);
		Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY g_ = context.Operators.SingletonFrom<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(f_);

		return g_;
	}

    [CqlDeclaration("Get Pharmacy NPI from Claims")]
	public Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Pharmacy_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		Tuple_FPCXihcEeChSjIUJHVXRcEXMI a_(Claim C)
		{
			bool? h_(Claim.ItemComponent i)
			{
				Integer y_ = context.Operators.Convert<Integer>(i?.SequenceElement);
				int? z_ = FHIRHelpers_4_0_001.ToInteger(y_);
				bool? aa_ = context.Operators.Equal(z_, 1);

				return aa_;
			};
			IEnumerable<Claim.ItemComponent> i_ = context.Operators.Where<Claim.ItemComponent>((C?.Item as IEnumerable<Claim.ItemComponent>), h_);
			bool? j_(Claim.ItemComponent @this)
			{
				bool? ab_ = context.Operators.Not((bool?)(@this?.Location is null));

				return ab_;
			};
			IEnumerable<Claim.ItemComponent> k_ = context.Operators.Where<Claim.ItemComponent>(i_, j_);
			DataType l_(Claim.ItemComponent @this) => 
				@this?.Location;
			IEnumerable<DataType> m_ = context.Operators.Select<Claim.ItemComponent, DataType>(k_, l_);
			ResourceReference n_(DataType l) => 
				(l as ResourceReference);
			IEnumerable<ResourceReference> o_ = context.Operators.Select<DataType, ResourceReference>(m_, n_);
			bool? p_(Claim.ItemComponent i)
			{
				Integer ac_ = context.Operators.Convert<Integer>(i?.SequenceElement);
				int? ad_ = FHIRHelpers_4_0_001.ToInteger(ac_);
				bool? ae_ = context.Operators.Equal(ad_, 1);

				return ae_;
			};
			IEnumerable<Claim.ItemComponent> q_ = context.Operators.Where<Claim.ItemComponent>((C?.Item as IEnumerable<Claim.ItemComponent>), p_);
			bool? r_(Claim.ItemComponent @this)
			{
				bool? af_ = context.Operators.Not((bool?)(@this?.Location is null));

				return af_;
			};
			IEnumerable<Claim.ItemComponent> s_ = context.Operators.Where<Claim.ItemComponent>(q_, r_);
			IEnumerable<DataType> u_ = context.Operators.Select<Claim.ItemComponent, DataType>(s_, l_);
			string v_(DataType l)
			{
				FhirString[] ag_ = new FhirString[]
				{
					(l as ResourceReference)?.ReferenceElement,
				};
				string ah_(FhirString r)
				{
					string ak_ = context.Operators.Convert<string>(r);
					string al_ = NCQAFHIRBase_1_0_0.GetId(ak_);

					return al_;
				};
				IEnumerable<string> ai_ = context.Operators.Select<FhirString, string>(ag_, ah_);
				string aj_ = context.Operators.SingletonFrom<string>(ai_);

				return aj_;
			};
			IEnumerable<string> w_ = context.Operators.Select<DataType, string>(u_, v_);
			Tuple_FPCXihcEeChSjIUJHVXRcEXMI x_ = new Tuple_FPCXihcEeChSjIUJHVXRcEXMI
			{
				SingleItem = (C?.Item as IEnumerable<Claim.ItemComponent>),
				ItemLocation = o_,
				ItemLocationID = w_,
			};

			return x_;
		};
		IEnumerable<Tuple_FPCXihcEeChSjIUJHVXRcEXMI> b_ = context.Operators.Select<Claim, Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(claim, a_);
		Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa c_ = new Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa
		{
			ItemsLocationReferences = b_,
		};
		Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa[] d_ = new Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa[]
		{
			c_,
		};
		Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY e_(Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa ClaimProperties)
		{
			IEnumerable<Location> am_ = context.Operators.RetrieveByValueSet<Location>(null, null);
			bool? an_(Location l)
			{
				string au_ = context.Operators.Convert<string>(l?.IdElement);
				bool? av_(Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
				{
					bool? bb_ = context.Operators.Not((bool?)(@this?.ItemLocationID is null));

					return bb_;
				};
				IEnumerable<Tuple_FPCXihcEeChSjIUJHVXRcEXMI> aw_ = context.Operators.Where<Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, av_);
				IEnumerable<string> ax_(Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => 
					@this?.ItemLocationID;
				IEnumerable<IEnumerable<string>> ay_ = context.Operators.Select<Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<string>>(aw_, ax_);
				IEnumerable<string> az_ = context.Operators.Flatten<string>(ay_);
				bool? ba_ = context.Operators.In<string>(au_, az_);

				return ba_;
			};
			IEnumerable<Location> ao_ = context.Operators.Where<Location>(am_, an_);
			Tuple_CZQfDISCFaOQaLKEbbAcDRfcP ap_ = new Tuple_CZQfDISCFaOQaLKEbbAcDRfcP
			{
				CorrespondingLocations = ao_,
			};
			Tuple_CZQfDISCFaOQaLKEbbAcDRfcP[] aq_ = new Tuple_CZQfDISCFaOQaLKEbbAcDRfcP[]
			{
				ap_,
			};
			Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY ar_(Tuple_CZQfDISCFaOQaLKEbbAcDRfcP GetLocation)
			{
				bool? bc_(Location C)
				{
					bool? bl_ = context.Operators.Not((bool?)(C is null));

					return bl_;
				};
				IEnumerable<Location> bd_ = context.Operators.Where<Location>(GetLocation?.CorrespondingLocations, bc_);
				Tuple_FNLPNAPOaaMjChWUXdhfgcWIR be_(Location C)
				{
					bool? bm_(Identifier l)
					{
						bool? bv_ = context.Operators.Equal(l?.SystemElement?.Value, "http://hl7.org/fhir/sid/us-npi");
						CqlConcept bw_ = FHIRHelpers_4_0_001.ToConcept(l?.Type);
						CqlCode bx_ = NCQATerminology_1_0_0.Provider_number();
						CqlConcept by_ = context.Operators.ConvertCodeToConcept(bx_);
						bool? bz_ = context.Operators.Equivalent(bw_, by_);
						bool? ca_ = context.Operators.And(bv_, bz_);
						bool? cb_ = context.Operators.Not((bool?)(l?.ValueElement?.Value is null));
						bool? cc_ = context.Operators.And(ca_, cb_);

						return cc_;
					};
					IEnumerable<Identifier> bn_ = context.Operators.Where<Identifier>((C?.Identifier as IEnumerable<Identifier>), bm_);
					FhirString bo_(Identifier l) => 
						l?.ValueElement;
					IEnumerable<FhirString> bp_ = context.Operators.Select<Identifier, FhirString>(bn_, bo_);
					bool? bq_(Identifier l)
					{
						bool? cd_ = context.Operators.Equal(l?.SystemElement?.Value, "http://hl7.org/fhir/sid/us-npi");
						CqlConcept ce_ = FHIRHelpers_4_0_001.ToConcept(l?.Type);
						CqlCode cf_ = NCQATerminology_1_0_0.Provider_number();
						CqlConcept cg_ = context.Operators.ConvertCodeToConcept(cf_);
						bool? ch_ = context.Operators.Equivalent(ce_, cg_);
						bool? ci_ = context.Operators.And(cd_, ch_);
						bool? cj_ = context.Operators.And(ci_, (bool?)(l?.ValueElement?.Value is null));

						return cj_;
					};
					IEnumerable<Identifier> br_ = context.Operators.Where<Identifier>((C?.Identifier as IEnumerable<Identifier>), bq_);
					Identifier bs_(Identifier l) => 
						l;
					IEnumerable<Identifier> bt_ = context.Operators.Select<Identifier, Identifier>(br_, bs_);
					Tuple_FNLPNAPOaaMjChWUXdhfgcWIR bu_ = new Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = bp_,
						NullIdentifiers = bt_,
					};

					return bu_;
				};
				IEnumerable<Tuple_FNLPNAPOaaMjChWUXdhfgcWIR> bf_ = context.Operators.Select<Location, Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(bd_, be_);
				Tuple_QDOjYOQaAUWAWKDPBcQCSKDH bg_ = new Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = bf_,
				};
				Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[] bh_ = new Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
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
								bool? ct_ = context.Operators.Not((bool?)(@this?.SingleItem is null));

								return ct_;
							};
							IEnumerable<Tuple_FPCXihcEeChSjIUJHVXRcEXMI> co_ = context.Operators.Where<Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, cn_);
							IEnumerable<Claim.ItemComponent> cp_(Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => 
								@this?.SingleItem;
							IEnumerable<IEnumerable<Claim.ItemComponent>> cq_ = context.Operators.Select<Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<Claim.ItemComponent>>(co_, cp_);
							IEnumerable<Claim.ItemComponent> cr_ = context.Operators.Flatten<Claim.ItemComponent>(cq_);
							bool? cs_ = context.Operators.Exists<Claim.ItemComponent>(cr_);

							return (cs_ ?? false);
						};
						if (cm_())
						{
							bool? cu_(Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
							{
								bool? do_ = context.Operators.Not((bool?)(@this?.ItemLocation is null));

								return do_;
							};
							IEnumerable<Tuple_FPCXihcEeChSjIUJHVXRcEXMI> cv_ = context.Operators.Where<Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, cu_);
							IEnumerable<ResourceReference> cw_(Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => 
								@this?.ItemLocation;
							IEnumerable<IEnumerable<ResourceReference>> cx_ = context.Operators.Select<Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<ResourceReference>>(cv_, cw_);
							IEnumerable<ResourceReference> cy_ = context.Operators.Flatten<ResourceReference>(cx_);
							bool? cz_(ResourceReference X) => 
								(bool?)(X?.ReferenceElement?.Value is null);
							IEnumerable<ResourceReference> da_ = context.Operators.Where<ResourceReference>(cy_, cz_);
							int? db_ = context.Operators.Count<ResourceReference>(da_);
							IEnumerable<FhirString> dc_(Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => 
								X?.AllIdentifiers;
							IEnumerable<IEnumerable<FhirString>> dd_ = context.Operators.Select<Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, dc_);
							IEnumerable<FhirString> de_ = context.Operators.Flatten<FhirString>(dd_);
							FhirString df_(FhirString X) => 
								X;
							IEnumerable<FhirString> dg_ = context.Operators.Select<FhirString, FhirString>(de_, df_);
							int? dh_ = context.Operators.Count<FhirString>(dg_);
							int? di_ = context.Operators.Add(db_, dh_);
							IEnumerable<Identifier> dj_(Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => 
								X?.NullIdentifiers;
							IEnumerable<IEnumerable<Identifier>> dk_ = context.Operators.Select<Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, dj_);
							IEnumerable<Identifier> dl_ = context.Operators.Flatten<Identifier>(dk_);
							int? dm_ = context.Operators.Count<Identifier>(dl_);
							int? dn_ = context.Operators.Add(di_, dm_);

							return dn_;
						}
						else
						{
							return 0;
						};
					};
					Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY cl_ = new Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = ck_(),
					};

					return cl_;
				};
				IEnumerable<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY> bj_ = context.Operators.Select<Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bh_, bi_);
				Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY bk_ = context.Operators.SingletonFrom<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bj_);

				return bk_;
			};
			IEnumerable<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY> as_ = context.Operators.Select<Tuple_CZQfDISCFaOQaLKEbbAcDRfcP, Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(aq_, ar_);
			Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY at_ = context.Operators.SingletonFrom<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(as_);

			return at_;
		};
		IEnumerable<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY> f_ = context.Operators.Select<Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa, Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(d_, e_);
		Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY g_ = context.Operators.SingletonFrom<Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(f_);

		return g_;
	}

}

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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395", default);

    [CqlDeclaration("Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395")]
	public CqlValueSet Inpatient_Stay() => 
		__Inpatient_Stay.Value;

	private CqlValueSet Nonacute_Inpatient_Stay_Value() => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398", default);

    [CqlDeclaration("Nonacute Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398")]
	public CqlValueSet Nonacute_Inpatient_Stay() => 
		__Nonacute_Inpatient_Stay.Value;

    [CqlDeclaration("Professional or Institutional Claims")]
	public IEnumerable<Claim> Professional_or_Institutional_Claims(IEnumerable<Claim> claim)
	{
		bool? a_(Claim MedicalClaim)
		{
			CodeableConcept c_ = MedicalClaim?.Type;
			CqlConcept d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			CqlCode[] e_ = d_?.codes;
			CqlCode f_ = NCQATerminology_1_0_0.Professional();
			bool? g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);
			CqlConcept i_ = FHIRHelpers_4_0_001.ToConcept(c_);
			CqlCode[] j_ = i_?.codes;
			CqlCode k_ = NCQATerminology_1_0_0.Institutional();
			bool? l_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)j_, k_);
			bool? m_ = context.Operators.Or(g_, l_);

			return m_;
		};
		IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Pharmacy Claims")]
	public IEnumerable<Claim> Pharmacy_Claims(IEnumerable<Claim> claim)
	{
		bool? a_(Claim PharmacyClaim)
		{
			CodeableConcept c_ = PharmacyClaim?.Type;
			CqlConcept d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			CqlCode[] e_ = d_?.codes;
			CqlCode f_ = NCQATerminology_1_0_0.Pharmacy();
			bool? g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);

			return g_;
		};
		IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Professional or Institutional Claims Response")]
	public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse MedicalResponse)
		{
			CodeableConcept c_ = MedicalResponse?.Type;
			CqlConcept d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			CqlCode[] e_ = d_?.codes;
			CqlCode f_ = NCQATerminology_1_0_0.Professional();
			bool? g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);
			CqlConcept i_ = FHIRHelpers_4_0_001.ToConcept(c_);
			CqlCode[] j_ = i_?.codes;
			CqlCode k_ = NCQATerminology_1_0_0.Institutional();
			bool? l_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)j_, k_);
			bool? m_ = context.Operators.Or(g_, l_);

			return m_;
		};
		IEnumerable<ClaimResponse> b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);

		return b_;
	}

    [CqlDeclaration("Pharmacy Claims Response")]
	public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse PharmacyResponse)
		{
			CodeableConcept c_ = PharmacyResponse?.Type;
			CqlConcept d_ = FHIRHelpers_4_0_001.ToConcept(c_);
			CqlCode[] e_ = d_?.codes;
			CqlCode f_ = NCQATerminology_1_0_0.Pharmacy();
			bool? g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);

			return g_;
		};
		IEnumerable<ClaimResponse> b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);

		return b_;
	}

    [CqlDeclaration("Medical Claims With Procedure and POS")]
	public IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_and_POS(IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p)
		{
			string k_ = p?.code;

			return k_;
		};
		IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, b_);
		string d_(CqlCode pos)
		{
			string l_ = pos?.code;

			return l_;
		};
		IEnumerable<string> e_ = context.Operators.Select<CqlCode, string>(posCodes, d_);
		(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? f_ = (a_, c_, e_);
		(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] g_ = [
			f_,
		];
		IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_((IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithPosCode)
		{
			IEnumerable<Claim> m_ = ClaimWithPosCode?.MedicalClaim;
			(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? n_(Claim ClaimofInterest)
			{
				IEnumerable<Claim.ItemComponent> r_()
				{
					if (ClaimofInterest is null)
					{
						return null as IEnumerable<Claim.ItemComponent>;
					}
					else
					{
						List<Claim.ItemComponent> x_ = ClaimofInterest?.Item;
						bool? y_(Claim.ItemComponent ItemOnLine)
						{
							CodeableConcept aa_ = ItemOnLine?.ProductOrService;
							CqlConcept ab_ = FHIRHelpers_4_0_001.ToConcept(aa_);
							CqlCode[] ac_ = ab_?.codes;
							bool? ad_(CqlCode LineCode)
							{
								string an_ = LineCode?.code;
								IEnumerable<string> ao_ = ClaimWithPosCode?.ProceduresAsStrings;
								bool? ap_ = context.Operators.In<string>(an_, ao_);

								return ap_;
							};
							IEnumerable<CqlCode> ae_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)ac_, ad_);
							bool? af_ = context.Operators.Exists<CqlCode>(ae_);
							DataType ag_ = ItemOnLine?.Location;
							CqlConcept ah_ = FHIRHelpers_4_0_001.ToConcept(ag_ as CodeableConcept);
							CqlCode[] ai_ = ah_?.codes;
							bool? aj_(CqlCode PosCode)
							{
								string aq_ = PosCode?.code;
								IEnumerable<string> ar_ = ClaimWithPosCode?.POSAsString;
								bool? as_ = context.Operators.In<string>(aq_, ar_);

								return as_;
							};
							IEnumerable<CqlCode> ak_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)ai_, aj_);
							bool? al_ = context.Operators.Exists<CqlCode>(ak_);
							bool? am_ = context.Operators.And(af_, al_);

							return am_;
						};
						IEnumerable<Claim.ItemComponent> z_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)x_, y_);

						return z_;
					}
				};
				(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? s_ = (ClaimofInterest, r_());
				(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] t_ = [
					s_,
				];
				(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? u_((Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
				{
					(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? at_()
					{
						bool au_()
						{
							IEnumerable<Claim.ItemComponent> av_ = LineItemDefinition?.LineItems;
							bool? aw_ = context.Operators.Exists<Claim.ItemComponent>(av_);

							return aw_ ?? false;
						};
						if (au_())
						{
							Claim ax_ = LineItemDefinition?.Claim;
							IEnumerable<Claim.ItemComponent> ay_ = LineItemDefinition?.LineItems;
							bool? az_(Claim.ItemComponent @this)
							{
								DataType bg_ = @this?.Serviced;
								bool? bh_ = context.Operators.Not((bool?)(bg_ is null));

								return bh_;
							};
							IEnumerable<Claim.ItemComponent> ba_ = context.Operators.Where<Claim.ItemComponent>(ay_, az_);
							object bb_(Claim.ItemComponent @this)
							{
								DataType bi_ = @this?.Serviced;

								return bi_;
							};
							IEnumerable<object> bc_ = context.Operators.Select<Claim.ItemComponent, object>(ba_, bb_);
							CqlInterval<CqlDateTime> bd_(object NormalDate)
							{
								CqlInterval<CqlDateTime> bj_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return bj_;
							};
							IEnumerable<CqlInterval<CqlDateTime>> be_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bc_, bd_);
							(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bf_ = (ax_, be_);

							return bf_;
						}
						else
						{
							return null as (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
						}
					};

					return at_();
				};
				IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> v_ = context.Operators.Select<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)t_, u_);
				(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? w_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(v_);

				return w_;
			};
			IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> o_ = context.Operators.Select<Claim, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(m_, n_);
			bool? p_((Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
			{
				bool? bk_ = context.Operators.Not((bool?)(FinalList is null));

				return bk_;
			};
			IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> q_ = context.Operators.Where<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(o_, p_);

			return q_;
		};
		IEnumerable<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> i_ = context.Operators.Select<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)g_, h_);
		IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_ = context.Operators.SingletonFrom<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Procedure in Header or on Line Item")]
	public IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p)
		{
			string i_ = p?.code;

			return i_;
		};
		IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, b_);
		(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? d_ = (a_, c_, default);
		(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] e_ = [
			d_,
		];
		IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_((IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithProcedure)
		{
			IEnumerable<Claim> j_ = ClaimWithProcedure?.MedicalClaim;
			(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? k_(Claim ClaimofInterest)
			{
				IEnumerable<Claim.ItemComponent> o_()
				{
					if (ClaimofInterest is null)
					{
						return null as IEnumerable<Claim.ItemComponent>;
					}
					else
					{
						List<Claim.ItemComponent> u_ = ClaimofInterest?.Item;
						bool? v_(Claim.ItemComponent ItemOnLine)
						{
							CodeableConcept x_ = ItemOnLine?.ProductOrService;
							CqlConcept y_ = FHIRHelpers_4_0_001.ToConcept(x_);
							CqlCode[] z_ = y_?.codes;
							bool? aa_(CqlCode LineCode)
							{
								string at_ = LineCode?.code;
								IEnumerable<string> au_ = ClaimWithProcedure?.ProceduresAsStrings;
								bool? av_ = context.Operators.In<string>(at_, au_);

								return av_;
							};
							IEnumerable<CqlCode> ab_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)z_, aa_);
							bool? ac_ = context.Operators.Exists<CqlCode>(ab_);
							List<Claim.ProcedureComponent> ad_ = ClaimofInterest?.Procedure;
							bool? ae_(Claim.ProcedureComponent @this)
							{
								DataType aw_ = @this?.Procedure;
								bool? ax_ = context.Operators.Not((bool?)(aw_ is null));

								return ax_;
							};
							IEnumerable<Claim.ProcedureComponent> af_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)ad_, ae_);
							object ag_(Claim.ProcedureComponent @this)
							{
								DataType ay_ = @this?.Procedure;

								return ay_;
							};
							IEnumerable<object> ah_ = context.Operators.Select<Claim.ProcedureComponent, object>(af_, ag_);
							bool? ai_(object @this)
							{
								object az_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								bool? ba_ = context.Operators.Not((bool?)(az_ is null));

								return ba_;
							};
							IEnumerable<object> aj_ = context.Operators.Where<object>(ah_, ai_);
							object ak_(object @this)
							{
								object bb_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return bb_;
							};
							IEnumerable<object> al_ = context.Operators.Select<object, object>(aj_, ak_);
							IEnumerable<object> am_ = context.Operators.FlattenLateBoundList(al_);
							Coding an_(object @object) => 
								(Coding)@object;
							IEnumerable<Coding> ao_ = context.Operators.Select<object, Coding>(am_, an_);
							bool? ap_(Coding HeaderCode)
							{
								Code bc_ = HeaderCode?.CodeElement;
								string bd_ = bc_?.Value;
								IEnumerable<string> be_ = ClaimWithProcedure?.ProceduresAsStrings;
								bool? bf_ = context.Operators.In<string>(bd_, be_);

								return bf_;
							};
							IEnumerable<Coding> aq_ = context.Operators.Where<Coding>(ao_, ap_);
							bool? ar_ = context.Operators.Exists<Coding>(aq_);
							bool? as_ = context.Operators.Or(ac_, ar_);

							return as_;
						};
						IEnumerable<Claim.ItemComponent> w_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)u_, v_);

						return w_;
					}
				};
				(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? p_ = (ClaimofInterest, o_());
				(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] q_ = [
					p_,
				];
				(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? r_((Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
				{
					(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bg_()
					{
						bool bh_()
						{
							IEnumerable<Claim.ItemComponent> bi_ = LineItemDefinition?.LineItems;
							bool? bj_ = context.Operators.Exists<Claim.ItemComponent>(bi_);

							return bj_ ?? false;
						};
						if (bh_())
						{
							Claim bk_ = LineItemDefinition?.Claim;
							IEnumerable<Claim.ItemComponent> bl_ = LineItemDefinition?.LineItems;
							bool? bm_(Claim.ItemComponent @this)
							{
								DataType bt_ = @this?.Serviced;
								bool? bu_ = context.Operators.Not((bool?)(bt_ is null));

								return bu_;
							};
							IEnumerable<Claim.ItemComponent> bn_ = context.Operators.Where<Claim.ItemComponent>(bl_, bm_);
							object bo_(Claim.ItemComponent @this)
							{
								DataType bv_ = @this?.Serviced;

								return bv_;
							};
							IEnumerable<object> bp_ = context.Operators.Select<Claim.ItemComponent, object>(bn_, bo_);
							CqlInterval<CqlDateTime> bq_(object NormalDate)
							{
								CqlInterval<CqlDateTime> bw_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

								return bw_;
							};
							IEnumerable<CqlInterval<CqlDateTime>> br_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bp_, bq_);
							(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bs_ = (bk_, br_);

							return bs_;
						}
						else
						{
							return null as (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
						}
					};

					return bg_();
				};
				IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> s_ = context.Operators.Select<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)q_, r_);
				(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? t_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(s_);

				return t_;
			};
			IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> l_ = context.Operators.Select<Claim, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(j_, k_);
			bool? m_((Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
			{
				bool? bx_ = context.Operators.Not((bool?)(FinalList is null));

				return bx_;
			};
			IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> n_ = context.Operators.Where<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(l_, m_);

			return n_;
		};
		IEnumerable<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> g_ = context.Operators.Select<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)e_, f_);
		IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_ = context.Operators.SingletonFrom<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis")]
	public (IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Medical_Claims_With_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			string i_ = d?.code;

			return i_;
		};
		IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? d_ = (a_, c_);
		(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] e_ = [
			d_,
		];
		(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_((IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
		{
			IEnumerable<Claim> j_()
			{
				if (ClaimWithDiagnosis?.MedicalClaim is null)
				{
					return null as IEnumerable<Claim>;
				}
				else
				{
					IEnumerable<Claim> p_ = ClaimWithDiagnosis?.MedicalClaim;
					bool? q_(Claim DiagnosisLine)
					{
						List<Claim.DiagnosisComponent> s_ = DiagnosisLine?.Diagnosis;
						bool? t_(Claim.DiagnosisComponent @this)
						{
							DataType ah_ = @this?.Diagnosis;
							bool? ai_ = context.Operators.Not((bool?)(ah_ is null));

							return ai_;
						};
						IEnumerable<Claim.DiagnosisComponent> u_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)s_, t_);
						object v_(Claim.DiagnosisComponent @this)
						{
							DataType aj_ = @this?.Diagnosis;

							return aj_;
						};
						IEnumerable<object> w_ = context.Operators.Select<Claim.DiagnosisComponent, object>(u_, v_);
						bool? x_(object @this)
						{
							object ak_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							bool? al_ = context.Operators.Not((bool?)(ak_ is null));

							return al_;
						};
						IEnumerable<object> y_ = context.Operators.Where<object>(w_, x_);
						object z_(object @this)
						{
							object am_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return am_;
						};
						IEnumerable<object> aa_ = context.Operators.Select<object, object>(y_, z_);
						IEnumerable<object> ab_ = context.Operators.FlattenLateBoundList(aa_);
						Coding ac_(object @object) => 
							(Coding)@object;
						IEnumerable<Coding> ad_ = context.Operators.Select<object, Coding>(ab_, ac_);
						bool? ae_(Coding HeaderCode)
						{
							Code an_ = HeaderCode?.CodeElement;
							string ao_ = an_?.Value;
							IEnumerable<string> ap_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
							bool? aq_ = context.Operators.In<string>(ao_, ap_);

							return aq_;
						};
						IEnumerable<Coding> af_ = context.Operators.Where<Coding>(ad_, ae_);
						bool? ag_ = context.Operators.Exists<Coding>(af_);

						return ag_;
					};
					IEnumerable<Claim> r_ = context.Operators.Where<Claim>(p_, q_);

					return r_;
				}
			};
			(IEnumerable<Claim> DiagnosisItems, nint _)? k_ = (j_(), default);
			(IEnumerable<Claim> DiagnosisItems, nint _)?[] l_ = [
				k_,
			];
			(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_((IEnumerable<Claim> DiagnosisItems, nint _)? HeaderDefinition)
			{
				(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ar_()
				{
					bool aw_()
					{
						IEnumerable<Claim> ax_ = HeaderDefinition?.DiagnosisItems;
						bool? ay_ = context.Operators.Exists<Claim>(ax_);

						return ay_ ?? false;
					};
					if (aw_())
					{
						IEnumerable<Claim> az_ = HeaderDefinition?.DiagnosisItems;
						bool? bb_(Claim @this)
						{
							List<Claim.ItemComponent> bj_ = @this?.Item;
							bool? bk_ = context.Operators.Not((bool?)(bj_ is null));

							return bk_;
						};
						IEnumerable<Claim> bc_ = context.Operators.Where<Claim>(az_, bb_);
						List<Claim.ItemComponent> bd_(Claim @this)
						{
							List<Claim.ItemComponent> bl_ = @this?.Item;

							return bl_;
						};
						IEnumerable<List<Claim.ItemComponent>> be_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(bc_, bd_);
						IEnumerable<Claim.ItemComponent> bf_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)be_);
						CqlInterval<CqlDateTime> bg_(Claim.ItemComponent NormalDate)
						{
							DataType bm_ = NormalDate?.Serviced;
							CqlInterval<CqlDateTime> bn_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bm_);

							return bn_;
						};
						IEnumerable<CqlInterval<CqlDateTime>> bh_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bf_, bg_);
						(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bi_ = (az_, bh_);

						return bi_;
					}
					else
					{
						return null as (IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
					}
				};
				(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] as_ = [
					ar_(),
				];
				bool? at_((IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
				{
					bool? bo_ = context.Operators.Not((bool?)(FinalList is null));

					return bo_;
				};
				IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> au_ = context.Operators.Where<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)as_, at_);
				(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? av_ = context.Operators.SingletonFrom<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(au_);

				return av_;
			};
			IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> n_ = context.Operators.Select<(IEnumerable<Claim> DiagnosisItems, nint _)?, (IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<Claim> DiagnosisItems, nint _)?>)l_, m_);
			(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_ = context.Operators.SingletonFrom<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(n_);

			return o_;
		};
		IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> g_ = context.Operators.Select<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, (IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)e_, f_);
		(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? h_ = context.Operators.SingletonFrom<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(g_);

		return h_;
	}

    [CqlDeclaration("Pharmacy Claim With Medication")]
	public IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> Pharmacy_Claim_With_Medication(IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
	{
		IEnumerable<Claim> a_ = this.Pharmacy_Claims(claim);
		string b_(CqlCode p)
		{
			string i_ = p?.code;

			return i_;
		};
		IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(MedicationCodes, b_);
		(IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? d_ = (a_, c_);
		(IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?[] e_ = [
			d_,
		];
		IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> f_((IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? ClaimWithMedication)
		{
			IEnumerable<Claim> j_ = ClaimWithMedication?.PharmacyClaim;
			(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? k_(Claim Pharmacy)
			{
				List<Claim.ItemComponent> o_ = Pharmacy?.Item;
				bool? p_(Claim.ItemComponent ItemOnLine)
				{
					CodeableConcept w_ = ItemOnLine?.ProductOrService;
					CqlConcept x_ = FHIRHelpers_4_0_001.ToConcept(w_);
					CqlCode[] y_ = x_?.codes;
					bool? z_(CqlCode LineCode)
					{
						string ac_ = LineCode?.code;
						IEnumerable<string> ad_ = ClaimWithMedication?.MedicationsAsStrings;
						bool? ae_ = context.Operators.In<string>(ac_, ad_);

						return ae_;
					};
					IEnumerable<CqlCode> aa_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)y_, z_);
					bool? ab_ = context.Operators.Exists<CqlCode>(aa_);

					return ab_;
				};
				IEnumerable<Claim.ItemComponent> q_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)o_, p_);
				(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? r_ = (Pharmacy, q_);
				(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] s_ = [
					r_,
				];
				(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? t_((Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
				{
					Claim af_ = LineItemDefinition?.Claim;
					Claim[] ag_ = [
						af_,
					];
					(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? ah_(Claim ClaimLines)
					{
						List<Claim.ItemComponent> ak_ = ClaimLines?.Item;
						bool? al_(Claim.ItemComponent i)
						{
							CodeableConcept au_ = i?.ProductOrService;
							CqlConcept av_ = FHIRHelpers_4_0_001.ToConcept(au_);
							CqlCode[] aw_ = av_?.codes;
							bool? ax_(CqlCode LineCode)
							{
								string ba_ = LineCode?.code;
								IEnumerable<string> bb_ = ClaimWithMedication?.MedicationsAsStrings;
								bool? bc_ = context.Operators.In<string>(ba_, bb_);

								return bc_;
							};
							IEnumerable<CqlCode> ay_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)aw_, ax_);
							bool? az_ = context.Operators.Exists<CqlCode>(ay_);

							return az_;
						};
						IEnumerable<Claim.ItemComponent> am_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ak_, al_);
						(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)? an_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDateTime> bd_()
							{
								bool bf_()
								{
									Quantity bg_ = i?.Quantity;
									bool? bh_ = context.Operators.Not((bool?)(bg_ is null));

									return bh_ ?? false;
								};
								if (bf_())
								{
									CqlInterval<CqlDateTime> bi_()
									{
										bool bj_()
										{
											DataType bk_ = i?.Serviced;
											bool bl_ = bk_ is Period;

											return bl_;
										};
										if (bj_())
										{
											DataType bm_ = i?.Serviced;
											CqlInterval<CqlDateTime> bn_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bm_);
											CqlDateTime bo_ = context.Operators.Start(bn_);
											CqlInterval<CqlDateTime> bq_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bm_);
											CqlDateTime br_ = context.Operators.Start(bq_);
											Quantity bs_ = i?.Quantity;
											FhirDecimal bt_ = bs_?.ValueElement;
											decimal? bu_ = FHIRHelpers_4_0_001.ToDecimal(bt_);
											CqlDateTime bv_ = context.Operators.Add(br_, new CqlQuantity(bu_, "day"));
											CqlQuantity bw_ = context.Operators.Quantity(1m, "day");
											CqlDateTime bx_ = context.Operators.Subtract(bv_, bw_);
											CqlInterval<CqlDateTime> by_ = context.Operators.Interval(bo_, bx_, true, true);

											return by_;
										}
										else
										{
											DataType bz_ = i?.Serviced;
											CqlDate ca_ = FHIRHelpers_4_0_001.ToDate(bz_ as Date);
											CqlDate cc_ = FHIRHelpers_4_0_001.ToDate(bz_ as Date);
											Quantity cd_ = i?.Quantity;
											FhirDecimal ce_ = cd_?.ValueElement;
											decimal? cf_ = FHIRHelpers_4_0_001.ToDecimal(ce_);
											CqlDate cg_ = context.Operators.Add(cc_, new CqlQuantity(cf_, "day"));
											CqlQuantity ch_ = context.Operators.Quantity(1m, "day");
											CqlDate ci_ = context.Operators.Subtract(cg_, ch_);
											CqlInterval<CqlDate> cj_ = context.Operators.Interval(ca_, ci_, true, true);
											CqlDate ck_ = cj_?.low;
											CqlDateTime cl_ = context.Operators.ConvertDateToDateTime(ck_);
											CqlDate cn_ = FHIRHelpers_4_0_001.ToDate(bz_ as Date);
											CqlDate cp_ = FHIRHelpers_4_0_001.ToDate(bz_ as Date);
											FhirDecimal cr_ = cd_?.ValueElement;
											decimal? cs_ = FHIRHelpers_4_0_001.ToDecimal(cr_);
											CqlDate ct_ = context.Operators.Add(cp_, new CqlQuantity(cs_, "day"));
											CqlDate cv_ = context.Operators.Subtract(ct_, ch_);
											CqlInterval<CqlDate> cw_ = context.Operators.Interval(cn_, cv_, true, true);
											CqlDate cx_ = cw_?.high;
											CqlDateTime cy_ = context.Operators.ConvertDateToDateTime(cx_);
											CqlDate da_ = FHIRHelpers_4_0_001.ToDate(bz_ as Date);
											CqlDate dc_ = FHIRHelpers_4_0_001.ToDate(bz_ as Date);
											FhirDecimal de_ = cd_?.ValueElement;
											decimal? df_ = FHIRHelpers_4_0_001.ToDecimal(de_);
											CqlDate dg_ = context.Operators.Add(dc_, new CqlQuantity(df_, "day"));
											CqlDate di_ = context.Operators.Subtract(dg_, ch_);
											CqlInterval<CqlDate> dj_ = context.Operators.Interval(da_, di_, true, true);
											bool? dk_ = dj_?.lowClosed;
											CqlDate dm_ = FHIRHelpers_4_0_001.ToDate(bz_ as Date);
											CqlDate do_ = FHIRHelpers_4_0_001.ToDate(bz_ as Date);
											FhirDecimal dq_ = cd_?.ValueElement;
											decimal? dr_ = FHIRHelpers_4_0_001.ToDecimal(dq_);
											CqlDate ds_ = context.Operators.Add(do_, new CqlQuantity(dr_, "day"));
											CqlDate du_ = context.Operators.Subtract(ds_, ch_);
											CqlInterval<CqlDate> dv_ = context.Operators.Interval(dm_, du_, true, true);
											bool? dw_ = dv_?.highClosed;
											CqlInterval<CqlDateTime> dx_ = context.Operators.Interval(cl_, cy_, dk_, dw_);

											return dx_;
										}
									};

									return bi_();
								}
								else
								{
									return null as CqlInterval<CqlDateTime>;
								}
							};
							(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)? be_ = (bd_(), default);

							return be_;
						};
						IEnumerable<(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?> ao_ = context.Operators.Select<Claim.ItemComponent, (CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?>(am_, an_);
						(IEnumerable<(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?> CoveredDays, nint _)? ap_ = (ao_, default);
						(IEnumerable<(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?> CoveredDays, nint _)?[] aq_ = [
							ap_,
						];
						(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? ar_((IEnumerable<(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?> CoveredDays, nint _)? ItemCalculation)
						{
							(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? dy_()
							{
								bool dz_()
								{
									IEnumerable<Claim.ItemComponent> ea_ = LineItemDefinition?.LineItems;
									bool? eb_ = context.Operators.Exists<Claim.ItemComponent>(ea_);

									return eb_ ?? false;
								};
								if (dz_())
								{
									Claim ec_ = LineItemDefinition?.Claim;
									IEnumerable<Claim.ItemComponent> ed_ = LineItemDefinition?.LineItems;
									bool? ef_(Claim.ItemComponent @this)
									{
										DataType ep_ = @this?.Serviced;
										bool? eq_ = context.Operators.Not((bool?)(ep_ is null));

										return eq_;
									};
									IEnumerable<Claim.ItemComponent> eg_ = context.Operators.Where<Claim.ItemComponent>(ed_, ef_);
									object eh_(Claim.ItemComponent @this)
									{
										DataType er_ = @this?.Serviced;

										return er_;
									};
									IEnumerable<object> ei_ = context.Operators.Select<Claim.ItemComponent, object>(eg_, eh_);
									CqlInterval<CqlDateTime> ej_(object NormalDate)
									{
										CqlInterval<CqlDateTime> es_ = NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate);

										return es_;
									};
									IEnumerable<CqlInterval<CqlDateTime>> ek_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(ei_, ej_);
									IEnumerable<(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?> el_ = ItemCalculation?.CoveredDays;
									CqlInterval<CqlDateTime> em_((CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)? d)
									{
										CqlInterval<CqlDateTime> et_ = d?.DaysSupplyInterval;

										return et_;
									};
									IEnumerable<CqlInterval<CqlDateTime>> en_ = context.Operators.Select<(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?, CqlInterval<CqlDateTime>>(el_, em_);
									(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? eo_ = (ec_, ed_, ek_, en_);

									return eo_;
								}
								else
								{
									return null as (Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?;
								}
							};

							return dy_();
						};
						IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> as_ = context.Operators.Select<(IEnumerable<(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?> CoveredDays, nint _)?, (Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(IEnumerable<(CqlInterval<CqlDateTime> DaysSupplyInterval, nint _)?> CoveredDays, nint _)?>)aq_, ar_);
						(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? at_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(as_);

						return at_;
					};
					IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> ai_ = context.Operators.Select<Claim, (Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<Claim>)ag_, ah_);
					(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? aj_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(ai_);

					return aj_;
				};
				IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> u_ = context.Operators.Select<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)s_, t_);
				(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? v_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(u_);

				return v_;
			};
			IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> l_ = context.Operators.Select<Claim, (Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(j_, k_);
			bool? m_((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? FinalList)
			{
				bool? eu_ = context.Operators.Not((bool?)(FinalList is null));

				return eu_;
			};
			IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> n_ = context.Operators.Where<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(l_, m_);

			return n_;
		};
		IEnumerable<IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>> g_ = context.Operators.Select<(IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?, IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>((IEnumerable<(IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?>)e_, f_);
		IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> h_ = context.Operators.SingletonFrom<IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis and Procedure")]
	public IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			string k_ = d?.code;

			return k_;
		};
		IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p)
		{
			string l_ = p?.code;

			return l_;
		};
		IEnumerable<string> e_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, d_);
		(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? f_ = (a_, c_, e_);
		(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] g_ = [
			f_,
		];
		IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_((IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithDiagnosis)
		{
			IEnumerable<Claim> m_()
			{
				if (ClaimWithDiagnosis?.MedicalClaim is null)
				{
					return null as IEnumerable<Claim>;
				}
				else
				{
					IEnumerable<Claim> s_ = ClaimWithDiagnosis?.MedicalClaim;
					bool? t_(Claim DiagnosisLine)
					{
						List<Claim.DiagnosisComponent> v_ = DiagnosisLine?.Diagnosis;
						bool? w_(Claim.DiagnosisComponent @this)
						{
							DataType ak_ = @this?.Diagnosis;
							bool? al_ = context.Operators.Not((bool?)(ak_ is null));

							return al_;
						};
						IEnumerable<Claim.DiagnosisComponent> x_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)v_, w_);
						object y_(Claim.DiagnosisComponent @this)
						{
							DataType am_ = @this?.Diagnosis;

							return am_;
						};
						IEnumerable<object> z_ = context.Operators.Select<Claim.DiagnosisComponent, object>(x_, y_);
						bool? aa_(object @this)
						{
							object an_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							bool? ao_ = context.Operators.Not((bool?)(an_ is null));

							return ao_;
						};
						IEnumerable<object> ab_ = context.Operators.Where<object>(z_, aa_);
						object ac_(object @this)
						{
							object ap_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return ap_;
						};
						IEnumerable<object> ad_ = context.Operators.Select<object, object>(ab_, ac_);
						IEnumerable<object> ae_ = context.Operators.FlattenLateBoundList(ad_);
						Coding af_(object @object) => 
							(Coding)@object;
						IEnumerable<Coding> ag_ = context.Operators.Select<object, Coding>(ae_, af_);
						bool? ah_(Coding HeaderCode)
						{
							Code aq_ = HeaderCode?.CodeElement;
							string ar_ = aq_?.Value;
							IEnumerable<string> as_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
							bool? at_ = context.Operators.In<string>(ar_, as_);

							return at_;
						};
						IEnumerable<Coding> ai_ = context.Operators.Where<Coding>(ag_, ah_);
						bool? aj_ = context.Operators.Exists<Coding>(ai_);

						return aj_;
					};
					IEnumerable<Claim> u_ = context.Operators.Where<Claim>(s_, t_);

					return u_;
				}
			};
			(IEnumerable<Claim> DiagnosisItems, nint _)? n_ = (m_(), default);
			(IEnumerable<Claim> DiagnosisItems, nint _)?[] o_ = [
				n_,
			];
			IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> p_((IEnumerable<Claim> DiagnosisItems, nint _)? ClaimWithProcedure)
			{
				IEnumerable<Claim> au_ = ClaimWithProcedure?.DiagnosisItems;
				(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? av_(Claim ClaimofInterest)
				{
					Claim az_()
					{
						if (ClaimofInterest is null)
						{
							return default;
						}
						else
						{
							Claim[] bf_ = [
								ClaimofInterest,
							];
							bool? bg_(Claim ItemOnLine)
							{
								List<Claim.ProcedureComponent> bj_ = ItemOnLine?.Procedure;
								bool? bk_(Claim.ProcedureComponent @this)
								{
									DataType cm_ = @this?.Procedure;
									bool? cn_ = context.Operators.Not((bool?)(cm_ is null));

									return cn_;
								};
								IEnumerable<Claim.ProcedureComponent> bl_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)bj_, bk_);
								object bm_(Claim.ProcedureComponent @this)
								{
									DataType co_ = @this?.Procedure;

									return co_;
								};
								IEnumerable<object> bn_ = context.Operators.Select<Claim.ProcedureComponent, object>(bl_, bm_);
								bool? bo_(object @this)
								{
									object cp_ = context.Operators.LateBoundProperty<object>(@this, "coding");
									bool? cq_ = context.Operators.Not((bool?)(cp_ is null));

									return cq_;
								};
								IEnumerable<object> bp_ = context.Operators.Where<object>(bn_, bo_);
								object bq_(object @this)
								{
									object cr_ = context.Operators.LateBoundProperty<object>(@this, "coding");

									return cr_;
								};
								IEnumerable<object> br_ = context.Operators.Select<object, object>(bp_, bq_);
								IEnumerable<object> bs_ = context.Operators.FlattenLateBoundList(br_);
								Coding bt_(object @object) => 
									(Coding)@object;
								IEnumerable<Coding> bu_ = context.Operators.Select<object, Coding>(bs_, bt_);
								bool? bv_(Coding ProcedureHeaderCode)
								{
									Code cs_ = ProcedureHeaderCode?.CodeElement;
									string ct_ = cs_?.Value;
									IEnumerable<string> cu_ = ClaimWithDiagnosis?.ProceduresAsStrings;
									bool? cv_ = context.Operators.In<string>(ct_, cu_);

									return cv_;
								};
								IEnumerable<Coding> bw_ = context.Operators.Where<Coding>(bu_, bv_);
								bool? bx_ = context.Operators.Exists<Coding>(bw_);
								List<Claim.ItemComponent> by_ = ItemOnLine?.Item;
								bool? bz_(Claim.ItemComponent @this)
								{
									CodeableConcept cw_ = @this?.ProductOrService;
									bool? cx_ = context.Operators.Not((bool?)(cw_ is null));

									return cx_;
								};
								IEnumerable<Claim.ItemComponent> ca_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)by_, bz_);
								CodeableConcept cb_(Claim.ItemComponent @this)
								{
									CodeableConcept cy_ = @this?.ProductOrService;

									return cy_;
								};
								IEnumerable<CodeableConcept> cc_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(ca_, cb_);
								bool? cd_(CodeableConcept @this)
								{
									List<Coding> cz_ = @this?.Coding;
									bool? da_ = context.Operators.Not((bool?)(cz_ is null));

									return da_;
								};
								IEnumerable<CodeableConcept> ce_ = context.Operators.Where<CodeableConcept>(cc_, cd_);
								List<Coding> cf_(CodeableConcept @this)
								{
									List<Coding> db_ = @this?.Coding;

									return db_;
								};
								IEnumerable<List<Coding>> cg_ = context.Operators.Select<CodeableConcept, List<Coding>>(ce_, cf_);
								IEnumerable<Coding> ch_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)cg_);
								bool? ci_(Coding LineCode)
								{
									Code dc_ = LineCode?.CodeElement;
									string dd_ = dc_?.Value;
									IEnumerable<string> de_ = ClaimWithDiagnosis?.ProceduresAsStrings;
									bool? df_ = context.Operators.In<string>(dd_, de_);

									return df_;
								};
								IEnumerable<Coding> cj_ = context.Operators.Where<Coding>(ch_, ci_);
								bool? ck_ = context.Operators.Exists<Coding>(cj_);
								bool? cl_ = context.Operators.Or(bx_, ck_);

								return cl_;
							};
							IEnumerable<Claim> bh_ = context.Operators.Where<Claim>((IEnumerable<Claim>)bf_, bg_);
							Claim bi_ = context.Operators.SingletonFrom<Claim>(bh_);

							return bi_;
						}
					};
					(Claim ProcedureItems, nint _)? ba_ = (az_(), default);
					(Claim ProcedureItems, nint _)?[] bb_ = [
						ba_,
					];
					(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bc_((Claim ProcedureItems, nint _)? HeaderDefinition)
					{
						(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dg_()
						{
							bool dh_()
							{
								Claim di_ = HeaderDefinition?.ProcedureItems;
								bool? dj_ = context.Operators.Not((bool?)(di_ is null));

								return dj_ ?? false;
							};
							if (dh_())
							{
								Claim dk_ = HeaderDefinition?.ProcedureItems;
								List<Claim.ItemComponent> dm_ = dk_?.Item;
								CqlInterval<CqlDateTime> dn_(Claim.ItemComponent NormalDate)
								{
									DataType dq_ = NormalDate?.Serviced;
									CqlInterval<CqlDateTime> dr_ = NCQAFHIRBase_1_0_0.Normalize_Interval(dq_);

									return dr_;
								};
								IEnumerable<CqlInterval<CqlDateTime>> do_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)dm_, dn_);
								(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dp_ = (dk_, do_);

								return dp_;
							}
							else
							{
								return null as (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
							}
						};

						return dg_();
					};
					IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bd_ = context.Operators.Select<(Claim ProcedureItems, nint _)?, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(Claim ProcedureItems, nint _)?>)bb_, bc_);
					(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? be_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bd_);

					return be_;
				};
				IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> aw_ = context.Operators.Select<Claim, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(au_, av_);
				bool? ax_((Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
				{
					bool? ds_ = context.Operators.Not((bool?)(FinalList is null));

					return ds_;
				};
				IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ay_ = context.Operators.Where<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(aw_, ax_);

				return ay_;
			};
			IEnumerable<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> q_ = context.Operators.Select<(IEnumerable<Claim> DiagnosisItems, nint _)?, IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(IEnumerable<Claim> DiagnosisItems, nint _)?>)o_, p_);
			IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> r_ = context.Operators.SingletonFrom<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(q_);

			return r_;
		};
		IEnumerable<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> i_ = context.Operators.Select<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)g_, h_);
		IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_ = context.Operators.SingletonFrom<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis and Procedure")]
	public IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			string k_ = d?.code;

			return k_;
		};
		IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p)
		{
			string l_ = p?.code;

			return l_;
		};
		IEnumerable<string> e_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, d_);
		(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? f_ = (a_, c_, e_);
		(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] g_ = [
			f_,
		];
		IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_((IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithProcedure)
		{
			IEnumerable<Claim> m_ = ClaimWithProcedure?.MedicalClaim;
			(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? n_(Claim ClaimofInterest)
			{
				Claim r_()
				{
					if (ClaimofInterest is null)
					{
						return default;
					}
					else
					{
						Claim[] x_ = [
							ClaimofInterest,
						];
						bool? y_(Claim ItemOnLine)
						{
							List<Claim.ItemComponent> ab_ = ItemOnLine?.Item;
							bool? ac_(Claim.ItemComponent @this)
							{
								CodeableConcept be_ = @this?.ProductOrService;
								bool? bf_ = context.Operators.Not((bool?)(be_ is null));

								return bf_;
							};
							IEnumerable<Claim.ItemComponent> ad_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ab_, ac_);
							CodeableConcept ae_(Claim.ItemComponent @this)
							{
								CodeableConcept bg_ = @this?.ProductOrService;

								return bg_;
							};
							IEnumerable<CodeableConcept> af_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(ad_, ae_);
							bool? ag_(CodeableConcept @this)
							{
								List<Coding> bh_ = @this?.Coding;
								bool? bi_ = context.Operators.Not((bool?)(bh_ is null));

								return bi_;
							};
							IEnumerable<CodeableConcept> ah_ = context.Operators.Where<CodeableConcept>(af_, ag_);
							List<Coding> ai_(CodeableConcept @this)
							{
								List<Coding> bj_ = @this?.Coding;

								return bj_;
							};
							IEnumerable<List<Coding>> aj_ = context.Operators.Select<CodeableConcept, List<Coding>>(ah_, ai_);
							IEnumerable<Coding> ak_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)aj_);
							bool? al_(Coding LineCode)
							{
								Code bk_ = LineCode?.CodeElement;
								string bl_ = bk_?.Value;
								IEnumerable<string> bm_ = ClaimWithProcedure?.ProceduresAsStrings;
								bool? bn_ = context.Operators.In<string>(bl_, bm_);

								return bn_;
							};
							IEnumerable<Coding> am_ = context.Operators.Where<Coding>(ak_, al_);
							bool? an_ = context.Operators.Exists<Coding>(am_);
							List<Claim.ProcedureComponent> ao_ = ItemOnLine?.Procedure;
							bool? ap_(Claim.ProcedureComponent @this)
							{
								DataType bo_ = @this?.Procedure;
								bool? bp_ = context.Operators.Not((bool?)(bo_ is null));

								return bp_;
							};
							IEnumerable<Claim.ProcedureComponent> aq_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)ao_, ap_);
							object ar_(Claim.ProcedureComponent @this)
							{
								DataType bq_ = @this?.Procedure;

								return bq_;
							};
							IEnumerable<object> as_ = context.Operators.Select<Claim.ProcedureComponent, object>(aq_, ar_);
							bool? at_(object @this)
							{
								object br_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								bool? bs_ = context.Operators.Not((bool?)(br_ is null));

								return bs_;
							};
							IEnumerable<object> au_ = context.Operators.Where<object>(as_, at_);
							object av_(object @this)
							{
								object bt_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return bt_;
							};
							IEnumerable<object> aw_ = context.Operators.Select<object, object>(au_, av_);
							IEnumerable<object> ax_ = context.Operators.FlattenLateBoundList(aw_);
							Coding ay_(object @object) => 
								(Coding)@object;
							IEnumerable<Coding> az_ = context.Operators.Select<object, Coding>(ax_, ay_);
							bool? ba_(Coding HeaderCode)
							{
								Code bu_ = HeaderCode?.CodeElement;
								string bv_ = bu_?.Value;
								IEnumerable<string> bw_ = ClaimWithProcedure?.ProceduresAsStrings;
								bool? bx_ = context.Operators.In<string>(bv_, bw_);

								return bx_;
							};
							IEnumerable<Coding> bb_ = context.Operators.Where<Coding>(az_, ba_);
							bool? bc_ = context.Operators.Exists<Coding>(bb_);
							bool? bd_ = context.Operators.Or(an_, bc_);

							return bd_;
						};
						IEnumerable<Claim> z_ = context.Operators.Where<Claim>((IEnumerable<Claim>)x_, y_);
						Claim aa_ = context.Operators.SingletonFrom<Claim>(z_);

						return aa_;
					}
				};
				(Claim Claim, Claim ProcedureItems)? s_ = (ClaimofInterest, r_());
				(Claim Claim, Claim ProcedureItems)?[] t_ = [
					s_,
				];
				(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? u_((Claim Claim, Claim ProcedureItems)? DiagnosisCheck)
				{
					Claim by_ = DiagnosisCheck?.ProcedureItems;
					Claim[] bz_ = [
						by_,
					];
					(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ca_(Claim ClaimforDiagnosis)
					{
						List<Claim.ItemComponent> cd_ = ClaimforDiagnosis?.Item;
						Claim ce_()
						{
							if (ClaimforDiagnosis is null)
							{
								return default;
							}
							else
							{
								Claim[] ck_ = [
									ClaimforDiagnosis,
								];
								bool? cl_(Claim RightClaim)
								{
									List<Claim.DiagnosisComponent> co_ = RightClaim?.Diagnosis;
									bool? cp_(Claim.DiagnosisComponent RightDiagnosis)
									{
										PositiveInt cs_ = RightDiagnosis?.SequenceElement;
										Integer ct_ = context.Operators.Convert<Integer>(cs_);
										int? cu_ = FHIRHelpers_4_0_001.ToInteger(ct_);
										bool? cv_ = context.Operators.Equal(cu_, 1);
										DataType cw_ = RightDiagnosis?.Diagnosis;
										IEnumerable<Coding> cx_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(cw_, "coding");
										bool? cy_(Coding DiagnosisCode)
										{
											Code dc_ = DiagnosisCode?.CodeElement;
											string dd_ = dc_?.Value;
											IEnumerable<string> de_ = ClaimWithProcedure?.DiagnosesAsStrings;
											bool? df_ = context.Operators.In<string>(dd_, de_);

											return df_;
										};
										IEnumerable<Coding> cz_ = context.Operators.Where<Coding>(cx_, cy_);
										bool? da_ = context.Operators.Exists<Coding>(cz_);
										bool? db_ = context.Operators.And(cv_, da_);

										return db_;
									};
									IEnumerable<Claim.DiagnosisComponent> cq_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)co_, cp_);
									bool? cr_ = context.Operators.Exists<Claim.DiagnosisComponent>(cq_);

									return cr_;
								};
								IEnumerable<Claim> cm_ = context.Operators.Where<Claim>((IEnumerable<Claim>)ck_, cl_);
								Claim cn_ = context.Operators.SingletonFrom<Claim>(cm_);

								return cn_;
							}
						};
						(IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? cf_ = ((IEnumerable<Claim.ItemComponent>)cd_, ce_());
						(IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?[] cg_ = [
							cf_,
						];
						(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ch_((IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? LineItemDefinition)
						{
							(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dg_()
							{
								bool dh_()
								{
									bool? di_ = context.Operators.Not((bool?)(LineItemDefinition is null));
									Claim dj_ = LineItemDefinition?.LineItems;
									bool? dk_ = context.Operators.Not((bool?)(dj_ is null));
									bool? dl_ = context.Operators.And(di_, dk_);

									return dl_ ?? false;
								};
								if (dh_())
								{
									Claim dm_ = LineItemDefinition?.LineItems;
									List<Claim.ItemComponent> do_ = dm_?.Item;
									CqlInterval<CqlDateTime> dp_(Claim.ItemComponent NormalDate)
									{
										DataType ds_ = NormalDate?.Serviced;
										CqlInterval<CqlDateTime> dt_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ds_);

										return dt_;
									};
									IEnumerable<CqlInterval<CqlDateTime>> dq_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)do_, dp_);
									(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dr_ = (dm_, dq_);

									return dr_;
								}
								else
								{
									return null as (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
								}
							};

							return dg_();
						};
						IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ci_ = context.Operators.Select<(IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?>)cg_, ch_);
						(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cj_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ci_);

						return cj_;
					};
					IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> cb_ = context.Operators.Select<Claim, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<Claim>)bz_, ca_);
					(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cc_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(cb_);

					return cc_;
				};
				IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> v_ = context.Operators.Select<(Claim Claim, Claim ProcedureItems)?, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(Claim Claim, Claim ProcedureItems)?>)t_, u_);
				(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? w_ = context.Operators.SingletonFrom<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(v_);

				return w_;
			};
			IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> o_ = context.Operators.Select<Claim, (Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(m_, n_);
			bool? p_((Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
			{
				bool? du_ = context.Operators.Not((bool?)(FinalList is null));

				return du_;
			};
			IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> q_ = context.Operators.Where<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(o_, p_);

			return q_;
		};
		IEnumerable<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> i_ = context.Operators.Select<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)g_, h_);
		IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_ = context.Operators.SingletonFrom<IEnumerable<(Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis")]
	public IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			string i_ = d?.code;

			return i_;
		};
		IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
		(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? d_ = (a_, c_);
		(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] e_ = [
			d_,
		];
		IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_((IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
		{
			IEnumerable<Claim> j_()
			{
				if (ClaimWithDiagnosis?.MedicalClaim is null)
				{
					return null as IEnumerable<Claim>;
				}
				else
				{
					IEnumerable<Claim> p_ = ClaimWithDiagnosis?.MedicalClaim;
					bool? q_(Claim RightClaim)
					{
						List<Claim.DiagnosisComponent> s_ = RightClaim?.Diagnosis;
						bool? t_(Claim.DiagnosisComponent RightDiagnosis)
						{
							PositiveInt w_ = RightDiagnosis?.SequenceElement;
							Integer x_ = context.Operators.Convert<Integer>(w_);
							int? y_ = FHIRHelpers_4_0_001.ToInteger(x_);
							bool? z_ = context.Operators.Equal(y_, 1);
							DataType aa_ = RightDiagnosis?.Diagnosis;
							IEnumerable<Coding> ab_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(aa_, "coding");
							bool? ac_(Coding DiagnosisCode)
							{
								Code ag_ = DiagnosisCode?.CodeElement;
								string ah_ = ag_?.Value;
								IEnumerable<string> ai_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
								bool? aj_ = context.Operators.In<string>(ah_, ai_);

								return aj_;
							};
							IEnumerable<Coding> ad_ = context.Operators.Where<Coding>(ab_, ac_);
							bool? ae_ = context.Operators.Exists<Coding>(ad_);
							bool? af_ = context.Operators.And(z_, ae_);

							return af_;
						};
						IEnumerable<Claim.DiagnosisComponent> u_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)s_, t_);
						bool? v_ = context.Operators.Exists<Claim.DiagnosisComponent>(u_);

						return v_;
					};
					IEnumerable<Claim> r_ = context.Operators.Where<Claim>(p_, q_);

					return r_;
				}
			};
			(IEnumerable<Claim> LineItems, nint _)? k_ = (j_(), default);
			(IEnumerable<Claim> LineItems, nint _)?[] l_ = [
				k_,
			];
			IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> m_((IEnumerable<Claim> LineItems, nint _)? LineItemDefinition)
			{
				IEnumerable<Claim> ak_ = LineItemDefinition?.LineItems;
				(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? al_(Claim ClaimWithDiagnosis)
				{
					(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ap_()
					{
						if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null))) ?? false)
						{
							IEnumerable<Claim> aq_ = LineItemDefinition?.LineItems;
							bool? as_(Claim @this)
							{
								List<Claim.ItemComponent> ba_ = @this?.Item;
								bool? bb_ = context.Operators.Not((bool?)(ba_ is null));

								return bb_;
							};
							IEnumerable<Claim> at_ = context.Operators.Where<Claim>(aq_, as_);
							List<Claim.ItemComponent> au_(Claim @this)
							{
								List<Claim.ItemComponent> bc_ = @this?.Item;

								return bc_;
							};
							IEnumerable<List<Claim.ItemComponent>> av_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(at_, au_);
							IEnumerable<Claim.ItemComponent> aw_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)av_);
							CqlInterval<CqlDateTime> ax_(Claim.ItemComponent NormalDate)
							{
								DataType bd_ = NormalDate?.Serviced;
								CqlInterval<CqlDateTime> be_ = NCQAFHIRBase_1_0_0.Normalize_Interval(bd_);

								return be_;
							};
							IEnumerable<CqlInterval<CqlDateTime>> ay_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(aw_, ax_);
							(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? az_ = (aq_, ay_);

							return az_;
						}
						else
						{
							return null as (IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
						}
					};

					return ap_();
				};
				IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> am_ = context.Operators.Select<Claim, (IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ak_, al_);
				bool? an_((IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
				{
					bool? bf_ = context.Operators.Not((bool?)(FinalList is null));

					return bf_;
				};
				IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ao_ = context.Operators.Where<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(am_, an_);

				return ao_;
			};
			IEnumerable<IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> n_ = context.Operators.Select<(IEnumerable<Claim> LineItems, nint _)?, IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(IEnumerable<Claim> LineItems, nint _)?>)l_, m_);
			IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> o_ = context.Operators.SingletonFrom<IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(n_);

			return o_;
		};
		IEnumerable<IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> g_ = context.Operators.Select<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)e_, f_);
		IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_ = context.Operators.SingletonFrom<IEnumerable<(IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(g_);

		return h_;
	}

    [CqlDeclaration("Get All Professional and Institutional Claims and Claim Responses")]
	public (IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		IEnumerable<ClaimResponse> a_ = this.Professional_or_Institutional_Claims_Response(claimResponse);
		IEnumerable<Claim> b_ = this.Professional_or_Institutional_Claims(claim);
		(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? c_ = (a_, b_);

		return c_;
	}

    [CqlDeclaration("Get All Paid Claim Reponses")]
	public IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> Get_All_Paid_Claim_Reponses(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse ResponseItem)
		{
			Code<ClaimProcessingCodes> h_ = ResponseItem?.OutcomeElement;
			string i_ = FHIRHelpers_4_0_001.ToString(h_);
			string[] j_ = [
				"complete",
				"partial",
			];
			bool? k_ = context.Operators.In<string>(i_, j_ as IEnumerable<string>);

			return k_;
		};
		IEnumerable<ClaimResponse> b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);
		(IEnumerable<ClaimResponse> PaidResponse, nint _)? c_ = (b_, default);
		(IEnumerable<ClaimResponse> PaidResponse, nint _)?[] d_ = [
			c_,
		];
		IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> e_((IEnumerable<ClaimResponse> PaidResponse, nint _)? ClaimResponse)
		{
			IEnumerable<ClaimResponse> l_ = ClaimResponse?.PaidResponse;
			(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? m_(ClaimResponse ClmResp)
			{
				ResourceReference o_ = ClmResp?.Request;
				FhirString p_ = o_?.ReferenceElement;
				string q_ = FHIRHelpers_4_0_001.ToString(p_);
				string r_ = NCQAFHIRBase_1_0_0.GetId(q_);
				List<ClaimResponse.ItemComponent> s_ = ClmResp?.Item;
				bool? t_(ClaimResponse.ItemComponent ResponseItem)
				{
					List<ClaimResponse.AdjudicationComponent> w_ = ResponseItem?.Adjudication;
					bool? x_(ClaimResponse.AdjudicationComponent @this)
					{
						CodeableConcept as_ = @this?.Category;
						bool? at_ = context.Operators.Not((bool?)(as_ is null));

						return at_;
					};
					IEnumerable<ClaimResponse.AdjudicationComponent> y_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)w_, x_);
					CodeableConcept z_(ClaimResponse.AdjudicationComponent @this)
					{
						CodeableConcept au_ = @this?.Category;

						return au_;
					};
					IEnumerable<CodeableConcept> aa_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, CodeableConcept>(y_, z_);
					bool? ab_(CodeableConcept @this)
					{
						List<Coding> av_ = @this?.Coding;
						bool? aw_ = context.Operators.Not((bool?)(av_ is null));

						return aw_;
					};
					IEnumerable<CodeableConcept> ac_ = context.Operators.Where<CodeableConcept>(aa_, ab_);
					List<Coding> ad_(CodeableConcept @this)
					{
						List<Coding> ax_ = @this?.Coding;

						return ax_;
					};
					IEnumerable<List<Coding>> ae_ = context.Operators.Select<CodeableConcept, List<Coding>>(ac_, ad_);
					IEnumerable<Coding> af_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ae_);
					bool? ag_(Coding CategoryItem)
					{
						Code ay_ = CategoryItem?.CodeElement;
						string az_ = ay_?.Value;
						bool? ba_ = context.Operators.Equal(az_, "benefit");

						return ba_;
					};
					IEnumerable<Coding> ah_ = context.Operators.Where<Coding>(af_, ag_);
					bool? ai_ = context.Operators.Exists<Coding>(ah_);
					bool? ak_(ClaimResponse.AdjudicationComponent @this)
					{
						Money bb_ = @this?.Amount;
						bool? bc_ = context.Operators.Not((bool?)(bb_ is null));

						return bc_;
					};
					IEnumerable<ClaimResponse.AdjudicationComponent> al_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)w_, ak_);
					Money am_(ClaimResponse.AdjudicationComponent @this)
					{
						Money bd_ = @this?.Amount;

						return bd_;
					};
					IEnumerable<Money> an_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, Money>(al_, am_);
					bool? ao_(Money DollarAmount)
					{
						FhirDecimal be_ = DollarAmount?.ValueElement;
						decimal? bf_ = FHIRHelpers_4_0_001.ToDecimal(be_);
						decimal? bg_ = context.Operators.ConvertIntegerToDecimal(0);
						bool? bh_ = context.Operators.Greater(bf_, bg_);

						return bh_;
					};
					IEnumerable<Money> ap_ = context.Operators.Where<Money>(an_, ao_);
					bool? aq_ = context.Operators.Exists<Money>(ap_);
					bool? ar_ = context.Operators.And(ai_, aq_);

					return ar_;
				};
				IEnumerable<ClaimResponse.ItemComponent> u_ = context.Operators.Where<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)s_, t_);
				(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? v_ = (ClmResp, r_, u_);

				return v_;
			};
			IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> n_ = context.Operators.Select<ClaimResponse, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(l_, m_);

			return n_;
		};
		IEnumerable<IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> f_ = context.Operators.Select<(IEnumerable<ClaimResponse> PaidResponse, nint _)?, IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>((IEnumerable<(IEnumerable<ClaimResponse> PaidResponse, nint _)?>)d_, e_);
		IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> g_ = context.Operators.SingletonFrom<IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(f_);

		return g_;
	}

    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
	public IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_and_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			List<Claim.ItemComponent> e_ = AllClaims?.Item;
			bool? f_(Claim.ItemComponent @this)
			{
				CodeableConcept ah_ = @this?.ProductOrService;
				bool? ai_ = context.Operators.Not((bool?)(ah_ is null));

				return ai_;
			};
			IEnumerable<Claim.ItemComponent> g_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)e_, f_);
			CodeableConcept h_(Claim.ItemComponent @this)
			{
				CodeableConcept aj_ = @this?.ProductOrService;

				return aj_;
			};
			IEnumerable<CodeableConcept> i_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(g_, h_);
			bool? j_(CodeableConcept @this)
			{
				List<Coding> ak_ = @this?.Coding;
				bool? al_ = context.Operators.Not((bool?)(ak_ is null));

				return al_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>(i_, j_);
			List<Coding> l_(CodeableConcept @this)
			{
				List<Coding> am_ = @this?.Coding;

				return am_;
			};
			IEnumerable<List<Coding>> m_ = context.Operators.Select<CodeableConcept, List<Coding>>(k_, l_);
			IEnumerable<Coding> n_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)m_);
			bool? o_(Coding ProductOrServiceCode)
			{
				CqlCode an_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				bool? ao_ = context.Operators.In<CqlCode>(an_, ProductOrServiceValueSet);

				return ao_;
			};
			IEnumerable<Coding> p_ = context.Operators.Where<Coding>(n_, o_);
			bool? q_ = context.Operators.Exists<Coding>(p_);
			List<Claim.DiagnosisComponent> r_ = AllClaims?.Diagnosis;
			bool? s_(Claim.DiagnosisComponent @this)
			{
				DataType ap_ = @this?.Diagnosis;
				bool? aq_ = context.Operators.Not((bool?)(ap_ is null));

				return aq_;
			};
			IEnumerable<Claim.DiagnosisComponent> t_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)r_, s_);
			object u_(Claim.DiagnosisComponent @this)
			{
				DataType ar_ = @this?.Diagnosis;

				return ar_;
			};
			IEnumerable<object> v_ = context.Operators.Select<Claim.DiagnosisComponent, object>(t_, u_);
			bool? w_(object @this)
			{
				object as_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				bool? at_ = context.Operators.Not((bool?)(as_ is null));

				return at_;
			};
			IEnumerable<object> x_ = context.Operators.Where<object>(v_, w_);
			object y_(object @this)
			{
				object au_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return au_;
			};
			IEnumerable<object> z_ = context.Operators.Select<object, object>(x_, y_);
			IEnumerable<object> aa_ = context.Operators.FlattenLateBoundList(z_);
			Coding ab_(object @object) => 
				(Coding)@object;
			IEnumerable<Coding> ac_ = context.Operators.Select<object, Coding>(aa_, ab_);
			bool? ad_(Coding DiagnosisCode)
			{
				CqlCode av_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
				bool? aw_ = context.Operators.In<CqlCode>(av_, DiagnosisValueSet);

				return aw_;
			};
			IEnumerable<Coding> ae_ = context.Operators.Where<Coding>(ac_, ad_);
			bool? af_ = context.Operators.Exists<Coding>(ae_);
			bool? ag_ = context.Operators.And(q_, af_);

			return ag_;
		};
		IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);
		(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? c_(Claim ProcedureClaims)
		{
			Id ax_ = ProcedureClaims?.IdElement;
			List<Claim.ItemComponent> ay_ = ProcedureClaims?.Item;
			bool? az_(Claim.ItemComponent ResponseItem)
			{
				CodeableConcept bc_ = ResponseItem?.ProductOrService;
				List<Coding> bd_ = bc_?.Coding;
				bool? be_(Coding ProductOrServiceCode)
				{
					CqlCode bh_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					bool? bi_ = context.Operators.In<CqlCode>(bh_, ProductOrServiceValueSet);

					return bi_;
				};
				IEnumerable<Coding> bf_ = context.Operators.Where<Coding>((IEnumerable<Coding>)bd_, be_);
				bool? bg_ = context.Operators.Exists<Coding>(bf_);

				return bg_;
			};
			IEnumerable<Claim.ItemComponent> ba_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ay_, az_);
			(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bb_ = (ProcedureClaims, ax_, ba_);

			return bb_;
		};
		IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> d_ = context.Operators.Select<Claim, (Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services and Conditions")]
	public (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_and_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> b_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? c_ = (a_, b_);
		(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] d_ = [
			c_,
		];
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_((IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
		{
			IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> h_ = ClaimAndResponse?.MedicalClaim;
			((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? i_((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
			{
				IEnumerable<Claim.ItemComponent> p_ = medClaim?.LineItems;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> u_((ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
					{
						IEnumerable<ClaimResponse.ItemComponent> x_ = pClaim?.LineItems;
						bool? y_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							Id ac_()
							{
								bool aq_()
								{
									Claim ar_ = medClaim?.ClaimofInterest;
									bool as_ = ar_ is Resource;

									return as_;
								};
								if (aq_())
								{
									Claim at_ = medClaim?.ClaimofInterest;

									return (at_ as Resource).IdElement;
								}
								else
								{
									return default;
								}
							};
							string ad_ = FHIRHelpers_4_0_001.ToString(ac_());
							ClaimResponse ae_ = pClaim?.Response;
							ResourceReference af_ = ae_?.Request;
							FhirString ag_ = af_?.ReferenceElement;
							string ah_ = FHIRHelpers_4_0_001.ToString(ag_);
							string ai_ = NCQAFHIRBase_1_0_0.GetId(ah_);
							bool? aj_ = context.Operators.Equal(ad_, ai_);
							PositiveInt ak_ = medClaimLineItem?.SequenceElement;
							Integer al_ = context.Operators.Convert<Integer>(ak_);
							PositiveInt am_ = pClaimLineItem?.ItemSequenceElement;
							Integer an_ = context.Operators.Convert<Integer>(am_);
							bool? ao_ = context.Operators.Equal(al_, an_);
							bool? ap_ = context.Operators.And(aj_, ao_);

							return ap_;
						};
						IEnumerable<ClaimResponse.ItemComponent> z_ = context.Operators.Where<ClaimResponse.ItemComponent>(x_, y_);
						(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ab_ = context.Operators.Select<ClaimResponse.ItemComponent, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(z_, aa_);

						return ab_;
					};
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> v_ = context.Operators.SelectMany<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
					bool? w_ = context.Operators.Exists<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(v_);

					return w_;
				};
				IEnumerable<Claim.ItemComponent> r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
				((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? s_ = (medClaim, r_);

				return s_;
			};
			IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> j_ = context.Operators.Select<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, ((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(h_, i_);
			(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)? k_ = (j_, default);
			(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?[] l_ = [
				k_,
			];
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_((IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)? ClaimWithPaidResponse)
			{
				(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? au_()
				{
					bool az_()
					{
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ba_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bb_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> bh_ = @this?.ClaimItem;
							bool? bi_ = context.Operators.Not((bool?)(bh_ is null));

							return bi_;
						};
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bc_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ba_, bb_);
						IEnumerable<Claim.ItemComponent> bd_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> bj_ = @this?.ClaimItem;

							return bj_;
						};
						IEnumerable<IEnumerable<Claim.ItemComponent>> be_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
						IEnumerable<Claim.ItemComponent> bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
						bool? bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);

						return bg_ ?? false;
					};
					if (az_())
					{
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bk_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bl_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? by_ = @this?.PaidClaim;
							bool? bz_ = context.Operators.Not((bool?)(by_ is null));

							return bz_;
						};
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bm_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bl_);
						(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ca_ = @this?.PaidClaim;

							return ca_;
						};
						IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> bo_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bm_, bn_);
						bool? bq_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> cb_ = @this?.ClaimItem;
							bool? cc_ = context.Operators.Not((bool?)(cb_ is null));

							return cc_;
						};
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> br_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bq_);
						IEnumerable<Claim.ItemComponent> bs_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> cd_ = @this?.ClaimItem;

							return cd_;
						};
						IEnumerable<IEnumerable<Claim.ItemComponent>> bt_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(br_, bs_);
						IEnumerable<Claim.ItemComponent> bu_ = context.Operators.Flatten<Claim.ItemComponent>(bt_);
						CqlInterval<CqlDateTime> bv_(Claim.ItemComponent PaidItem)
						{
							DataType ce_ = PaidItem?.Serviced;
							CqlInterval<CqlDateTime> cf_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ce_);

							return cf_;
						};
						IEnumerable<CqlInterval<CqlDateTime>> bw_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bu_, bv_);
						(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bx_ = (bo_, bw_);

						return bx_;
					}
					else
					{
						return null as (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
					}
				};
				(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] av_ = [
					au_(),
				];
				bool? aw_((IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
				{
					bool? cg_ = context.Operators.Not((bool?)(FinalList is null));

					return cg_;
				};
				IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ax_ = context.Operators.Where<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)av_, aw_);
				(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ay_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ax_);

				return ay_;
			};
			IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> n_ = context.Operators.Select<(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?>)l_, m_);
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(n_);

			return o_;
		};
		IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_ = context.Operators.Select<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_, e_);
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? g_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Service and Condition")]
	public (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Service_and_Condition(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] b_ = [
			a_,
		];
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
		{
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? j_()
			{
				bool k_()
				{
					IEnumerable<ClaimResponse> l_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					IEnumerable<Claim> m_ = MedicalClaimAndResponse?.MedicalClaim;
					bool? n_ = context.Operators.And((bool?)(l_ is null), (bool?)(m_ is null));

					return n_ ?? false;
				};
				if (k_())
				{
					return null as (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
				}
				else
				{
					IEnumerable<ClaimResponse> o_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					IEnumerable<Claim> p_ = MedicalClaimAndResponse?.MedicalClaim;
					(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? q_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(o_, p_, ProductOrServiceValueSet, DiagnosisValueSet);

					return q_;
				}
			};

			return j_();
		};
		IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> d_ = context.Operators.Select<(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_, c_);
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] f_ = [
			e_,
		];
		bool? g_((IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
		{
			bool? r_ = context.Operators.Not((bool?)(FinalList is null));

			return r_;
		};
		IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_ = context.Operators.Where<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)f_, g_);
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? i_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(h_);

		return i_;
	}

    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
	public IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_or_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			List<Claim.ItemComponent> e_ = AllClaims?.Item;
			bool? f_(Claim.ItemComponent @this)
			{
				CodeableConcept ah_ = @this?.ProductOrService;
				bool? ai_ = context.Operators.Not((bool?)(ah_ is null));

				return ai_;
			};
			IEnumerable<Claim.ItemComponent> g_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)e_, f_);
			CodeableConcept h_(Claim.ItemComponent @this)
			{
				CodeableConcept aj_ = @this?.ProductOrService;

				return aj_;
			};
			IEnumerable<CodeableConcept> i_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(g_, h_);
			bool? j_(CodeableConcept @this)
			{
				List<Coding> ak_ = @this?.Coding;
				bool? al_ = context.Operators.Not((bool?)(ak_ is null));

				return al_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>(i_, j_);
			List<Coding> l_(CodeableConcept @this)
			{
				List<Coding> am_ = @this?.Coding;

				return am_;
			};
			IEnumerable<List<Coding>> m_ = context.Operators.Select<CodeableConcept, List<Coding>>(k_, l_);
			IEnumerable<Coding> n_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)m_);
			bool? o_(Coding ProductOrServiceCode)
			{
				CqlCode an_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				bool? ao_ = context.Operators.In<CqlCode>(an_, ProductOrServiceValueSet);

				return ao_;
			};
			IEnumerable<Coding> p_ = context.Operators.Where<Coding>(n_, o_);
			bool? q_ = context.Operators.Exists<Coding>(p_);
			List<Claim.DiagnosisComponent> r_ = AllClaims?.Diagnosis;
			bool? s_(Claim.DiagnosisComponent @this)
			{
				DataType ap_ = @this?.Diagnosis;
				bool? aq_ = context.Operators.Not((bool?)(ap_ is null));

				return aq_;
			};
			IEnumerable<Claim.DiagnosisComponent> t_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)r_, s_);
			object u_(Claim.DiagnosisComponent @this)
			{
				DataType ar_ = @this?.Diagnosis;

				return ar_;
			};
			IEnumerable<object> v_ = context.Operators.Select<Claim.DiagnosisComponent, object>(t_, u_);
			bool? w_(object @this)
			{
				object as_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				bool? at_ = context.Operators.Not((bool?)(as_ is null));

				return at_;
			};
			IEnumerable<object> x_ = context.Operators.Where<object>(v_, w_);
			object y_(object @this)
			{
				object au_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return au_;
			};
			IEnumerable<object> z_ = context.Operators.Select<object, object>(x_, y_);
			IEnumerable<object> aa_ = context.Operators.FlattenLateBoundList(z_);
			Coding ab_(object @object) => 
				(Coding)@object;
			IEnumerable<Coding> ac_ = context.Operators.Select<object, Coding>(aa_, ab_);
			bool? ad_(Coding DiagnosisCode)
			{
				CqlCode av_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
				bool? aw_ = context.Operators.In<CqlCode>(av_, DiagnosisValueSet);

				return aw_;
			};
			IEnumerable<Coding> ae_ = context.Operators.Where<Coding>(ac_, ad_);
			bool? af_ = context.Operators.Exists<Coding>(ae_);
			bool? ag_ = context.Operators.Or(q_, af_);

			return ag_;
		};
		IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);
		(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? c_(Claim ProcedureClaims)
		{
			(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ax_()
			{
				bool ay_()
				{
					List<Claim.ItemComponent> az_ = ProcedureClaims?.Item;
					bool? ba_(Claim.ItemComponent ResponseItem)
					{
						CodeableConcept bd_ = ResponseItem?.ProductOrService;
						List<Coding> be_ = bd_?.Coding;
						bool? bf_(Coding ProductOrServiceCode)
						{
							CqlCode bi_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
							bool? bj_ = context.Operators.In<CqlCode>(bi_, ProductOrServiceValueSet);

							return bj_;
						};
						IEnumerable<Coding> bg_ = context.Operators.Where<Coding>((IEnumerable<Coding>)be_, bf_);
						bool? bh_ = context.Operators.Exists<Coding>(bg_);

						return bh_;
					};
					IEnumerable<Claim.ItemComponent> bb_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)az_, ba_);
					bool? bc_ = context.Operators.Exists<Claim.ItemComponent>(bb_);

					return bc_ ?? false;
				};
				if (ay_())
				{
					Id bk_ = ProcedureClaims?.IdElement;
					List<Claim.ItemComponent> bl_ = ProcedureClaims?.Item;
					bool? bm_(Claim.ItemComponent ResponseItem)
					{
						CodeableConcept bp_ = ResponseItem?.ProductOrService;
						List<Coding> bq_ = bp_?.Coding;
						bool? br_(Coding ProductOrServiceCode)
						{
							CqlCode bu_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
							bool? bv_ = context.Operators.In<CqlCode>(bu_, ProductOrServiceValueSet);

							return bv_;
						};
						IEnumerable<Coding> bs_ = context.Operators.Where<Coding>((IEnumerable<Coding>)bq_, br_);
						bool? bt_ = context.Operators.Exists<Coding>(bs_);

						return bt_;
					};
					IEnumerable<Claim.ItemComponent> bn_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bl_, bm_);
					(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bo_ = (ProcedureClaims, bk_, bn_);

					return bo_;
				}
				else
				{
					Id bw_ = ProcedureClaims?.IdElement;
					List<Claim.ItemComponent> bx_ = ProcedureClaims?.Item;
					bool? by_(Claim.ItemComponent ResponseItem)
					{
						PositiveInt cb_ = ResponseItem?.SequenceElement;
						Integer cc_ = context.Operators.Convert<Integer>(cb_);
						int? cd_ = cc_?.Value;
						bool? ce_ = context.Operators.Equal(cd_, 1);

						return ce_;
					};
					IEnumerable<Claim.ItemComponent> bz_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bx_, by_);
					(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ca_ = (ProcedureClaims, bw_, bz_);

					return ca_;
				}
			};

			return ax_();
		};
		IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> d_ = context.Operators.Select<Claim, (Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services or Conditions")]
	public (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> b_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? c_ = (a_, b_);
		(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] d_ = [
			c_,
		];
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_((IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
		{
			IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> h_ = ClaimAndResponse?.MedicalClaim;
			((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? i_((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
			{
				IEnumerable<Claim.ItemComponent> p_ = medClaim?.LineItems;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> u_((ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
					{
						IEnumerable<ClaimResponse.ItemComponent> x_ = pClaim?.LineItems;
						bool? y_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							Id ac_()
							{
								bool aq_()
								{
									Claim ar_ = medClaim?.ClaimofInterest;
									bool as_ = ar_ is Resource;

									return as_;
								};
								if (aq_())
								{
									Claim at_ = medClaim?.ClaimofInterest;

									return (at_ as Resource).IdElement;
								}
								else
								{
									return default;
								}
							};
							string ad_ = FHIRHelpers_4_0_001.ToString(ac_());
							ClaimResponse ae_ = pClaim?.Response;
							ResourceReference af_ = ae_?.Request;
							FhirString ag_ = af_?.ReferenceElement;
							string ah_ = FHIRHelpers_4_0_001.ToString(ag_);
							string ai_ = NCQAFHIRBase_1_0_0.GetId(ah_);
							bool? aj_ = context.Operators.Equal(ad_, ai_);
							PositiveInt ak_ = medClaimLineItem?.SequenceElement;
							Integer al_ = context.Operators.Convert<Integer>(ak_);
							PositiveInt am_ = pClaimLineItem?.ItemSequenceElement;
							Integer an_ = context.Operators.Convert<Integer>(am_);
							bool? ao_ = context.Operators.Equal(al_, an_);
							bool? ap_ = context.Operators.And(aj_, ao_);

							return ap_;
						};
						IEnumerable<ClaimResponse.ItemComponent> z_ = context.Operators.Where<ClaimResponse.ItemComponent>(x_, y_);
						(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ab_ = context.Operators.Select<ClaimResponse.ItemComponent, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(z_, aa_);

						return ab_;
					};
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> v_ = context.Operators.SelectMany<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
					bool? w_ = context.Operators.Exists<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(v_);

					return w_;
				};
				IEnumerable<Claim.ItemComponent> r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
				((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? s_ = (medClaim, r_);

				return s_;
			};
			IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> j_ = context.Operators.Select<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, ((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(h_, i_);
			(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)? k_ = (j_, default);
			(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?[] l_ = [
				k_,
			];
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_((IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)? ClaimWithPaidResponse)
			{
				(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? au_()
				{
					bool az_()
					{
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ba_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bb_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> bh_ = @this?.ClaimItem;
							bool? bi_ = context.Operators.Not((bool?)(bh_ is null));

							return bi_;
						};
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bc_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ba_, bb_);
						IEnumerable<Claim.ItemComponent> bd_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> bj_ = @this?.ClaimItem;

							return bj_;
						};
						IEnumerable<IEnumerable<Claim.ItemComponent>> be_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
						IEnumerable<Claim.ItemComponent> bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
						bool? bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);

						return bg_ ?? false;
					};
					if (az_())
					{
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bk_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bl_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? by_ = @this?.PaidClaim;
							bool? bz_ = context.Operators.Not((bool?)(by_ is null));

							return bz_;
						};
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bm_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bl_);
						(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ca_ = @this?.PaidClaim;

							return ca_;
						};
						IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> bo_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bm_, bn_);
						bool? bq_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> cb_ = @this?.ClaimItem;
							bool? cc_ = context.Operators.Not((bool?)(cb_ is null));

							return cc_;
						};
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> br_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bq_);
						IEnumerable<Claim.ItemComponent> bs_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> cd_ = @this?.ClaimItem;

							return cd_;
						};
						IEnumerable<IEnumerable<Claim.ItemComponent>> bt_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(br_, bs_);
						IEnumerable<Claim.ItemComponent> bu_ = context.Operators.Flatten<Claim.ItemComponent>(bt_);
						CqlInterval<CqlDateTime> bv_(Claim.ItemComponent PaidItem)
						{
							DataType ce_ = PaidItem?.Serviced;
							CqlInterval<CqlDateTime> cf_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ce_);

							return cf_;
						};
						IEnumerable<CqlInterval<CqlDateTime>> bw_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bu_, bv_);
						(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bx_ = (bo_, bw_);

						return bx_;
					}
					else
					{
						return null as (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
					}
				};
				(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] av_ = [
					au_(),
				];
				bool? aw_((IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
				{
					bool? cg_ = context.Operators.Not((bool?)(FinalList is null));

					return cg_;
				};
				IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ax_ = context.Operators.Where<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)av_, aw_);
				(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ay_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ax_);

				return ay_;
			};
			IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> n_ = context.Operators.Select<(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?>)l_, m_);
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(n_);

			return o_;
		};
		IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_ = context.Operators.Select<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_, e_);
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? g_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services or Conditions")]
	public (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] b_ = [
			a_,
		];
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
		{
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_()
			{
				bool g_()
				{
					IEnumerable<ClaimResponse> h_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					IEnumerable<Claim> i_ = MedicalClaimAndResponse?.MedicalClaim;
					bool? j_ = context.Operators.And((bool?)(h_ is null), (bool?)(i_ is null));

					return j_ ?? false;
				};
				if (g_())
				{
					return null as (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
				}
				else
				{
					IEnumerable<ClaimResponse> k_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					IEnumerable<Claim> l_ = MedicalClaimAndResponse?.MedicalClaim;
					(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(k_, l_, ProductOrServiceValueSet, DiagnosisValueSet);

					return m_;
				}
			};

			return f_();
		};
		IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> d_ = context.Operators.Select<(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_, c_);
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);

		return e_;
	}

    [CqlDeclaration("Get All Claims With Procedure Only")]
	public IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_Only(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			List<Claim.ItemComponent> e_ = AllClaims?.Item;
			bool? f_(Claim.ItemComponent @this)
			{
				CodeableConcept r_ = @this?.ProductOrService;
				bool? s_ = context.Operators.Not((bool?)(r_ is null));

				return s_;
			};
			IEnumerable<Claim.ItemComponent> g_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)e_, f_);
			CodeableConcept h_(Claim.ItemComponent @this)
			{
				CodeableConcept t_ = @this?.ProductOrService;

				return t_;
			};
			IEnumerable<CodeableConcept> i_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(g_, h_);
			bool? j_(CodeableConcept @this)
			{
				List<Coding> u_ = @this?.Coding;
				bool? v_ = context.Operators.Not((bool?)(u_ is null));

				return v_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>(i_, j_);
			List<Coding> l_(CodeableConcept @this)
			{
				List<Coding> w_ = @this?.Coding;

				return w_;
			};
			IEnumerable<List<Coding>> m_ = context.Operators.Select<CodeableConcept, List<Coding>>(k_, l_);
			IEnumerable<Coding> n_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)m_);
			bool? o_(Coding ProductOrServiceCode)
			{
				CqlCode x_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				bool? y_ = context.Operators.In<CqlCode>(x_, ProductOrServiceValueSet);

				return y_;
			};
			IEnumerable<Coding> p_ = context.Operators.Where<Coding>(n_, o_);
			bool? q_ = context.Operators.Exists<Coding>(p_);

			return q_;
		};
		IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);
		(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? c_(Claim AllClaims)
		{
			Id z_ = AllClaims?.IdElement;
			List<Claim.ItemComponent> aa_ = AllClaims?.Item;
			bool? ab_(Claim.ItemComponent ResponseItem)
			{
				CodeableConcept ae_ = ResponseItem?.ProductOrService;
				List<Coding> af_ = ae_?.Coding;
				bool? ag_(Coding ProductOrServiceCode)
				{
					CqlCode aj_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					bool? ak_ = context.Operators.In<CqlCode>(aj_, ProductOrServiceValueSet);

					return ak_;
				};
				IEnumerable<Coding> ah_ = context.Operators.Where<Coding>((IEnumerable<Coding>)af_, ag_);
				bool? ai_ = context.Operators.Exists<Coding>(ah_);

				return ai_;
			};
			IEnumerable<Claim.ItemComponent> ac_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)aa_, ab_);
			(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ad_ = (AllClaims, z_, ac_);

			return ad_;
		};
		IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> d_ = context.Operators.Select<Claim, (Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services Only")]
	public (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> b_ = this.Get_All_Claims_With_Procedure_Only(claim, ProductOrServiceValueSet);
		(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? c_ = (a_, b_);
		(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] d_ = [
			c_,
		];
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_((IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
		{
			IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> h_ = ClaimAndResponse?.MedicalClaim;
			((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? i_((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
			{
				IEnumerable<Claim.ItemComponent> p_ = medClaim?.LineItems;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> u_((ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
					{
						IEnumerable<ClaimResponse.ItemComponent> x_ = pClaim?.LineItems;
						bool? y_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							Id ac_()
							{
								bool aq_()
								{
									Claim ar_ = medClaim?.ClaimofInterest;
									bool as_ = ar_ is Resource;

									return as_;
								};
								if (aq_())
								{
									Claim at_ = medClaim?.ClaimofInterest;

									return (at_ as Resource).IdElement;
								}
								else
								{
									return default;
								}
							};
							string ad_ = FHIRHelpers_4_0_001.ToString(ac_());
							ClaimResponse ae_ = pClaim?.Response;
							ResourceReference af_ = ae_?.Request;
							FhirString ag_ = af_?.ReferenceElement;
							string ah_ = FHIRHelpers_4_0_001.ToString(ag_);
							string ai_ = NCQAFHIRBase_1_0_0.GetId(ah_);
							bool? aj_ = context.Operators.Equal(ad_, ai_);
							PositiveInt ak_ = medClaimLineItem?.SequenceElement;
							Integer al_ = context.Operators.Convert<Integer>(ak_);
							PositiveInt am_ = pClaimLineItem?.ItemSequenceElement;
							Integer an_ = context.Operators.Convert<Integer>(am_);
							bool? ao_ = context.Operators.Equal(al_, an_);
							bool? ap_ = context.Operators.And(aj_, ao_);

							return ap_;
						};
						IEnumerable<ClaimResponse.ItemComponent> z_ = context.Operators.Where<ClaimResponse.ItemComponent>(x_, y_);
						(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ab_ = context.Operators.Select<ClaimResponse.ItemComponent, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(z_, aa_);

						return ab_;
					};
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> v_ = context.Operators.SelectMany<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
					bool? w_ = context.Operators.Exists<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(v_);

					return w_;
				};
				IEnumerable<Claim.ItemComponent> r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
				((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? s_ = (medClaim, r_);

				return s_;
			};
			IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> j_ = context.Operators.Select<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, ((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(h_, i_);
			(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)? k_ = (j_, default);
			(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?[] l_ = [
				k_,
			];
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_((IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)? ClaimWithPaidResponse)
			{
				(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? au_()
				{
					bool az_()
					{
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ba_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bb_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> bh_ = @this?.ClaimItem;
							bool? bi_ = context.Operators.Not((bool?)(bh_ is null));

							return bi_;
						};
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bc_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ba_, bb_);
						IEnumerable<Claim.ItemComponent> bd_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> bj_ = @this?.ClaimItem;

							return bj_;
						};
						IEnumerable<IEnumerable<Claim.ItemComponent>> be_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
						IEnumerable<Claim.ItemComponent> bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
						bool? bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);

						return bg_ ?? false;
					};
					if (az_())
					{
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bk_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bl_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? by_ = @this?.PaidClaim;
							bool? bz_ = context.Operators.Not((bool?)(by_ is null));

							return bz_;
						};
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bm_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bl_);
						(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ca_ = @this?.PaidClaim;

							return ca_;
						};
						IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> bo_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bm_, bn_);
						bool? bq_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> cb_ = @this?.ClaimItem;
							bool? cc_ = context.Operators.Not((bool?)(cb_ is null));

							return cc_;
						};
						IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> br_ = context.Operators.Where<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bq_);
						IEnumerable<Claim.ItemComponent> bs_(((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> cd_ = @this?.ClaimItem;

							return cd_;
						};
						IEnumerable<IEnumerable<Claim.ItemComponent>> bt_ = context.Operators.Select<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(br_, bs_);
						IEnumerable<Claim.ItemComponent> bu_ = context.Operators.Flatten<Claim.ItemComponent>(bt_);
						CqlInterval<CqlDateTime> bv_(Claim.ItemComponent PaidItem)
						{
							DataType ce_ = PaidItem?.Serviced;
							CqlInterval<CqlDateTime> cf_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ce_);

							return cf_;
						};
						IEnumerable<CqlInterval<CqlDateTime>> bw_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bu_, bv_);
						(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bx_ = (bo_, bw_);

						return bx_;
					}
					else
					{
						return null as (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
					}
				};
				(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] av_ = [
					au_(),
				];
				bool? aw_((IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
				{
					bool? cg_ = context.Operators.Not((bool?)(FinalList is null));

					return cg_;
				};
				IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ax_ = context.Operators.Where<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)av_, aw_);
				(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ay_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ax_);

				return ay_;
			};
			IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> n_ = context.Operators.Select<(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<((Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?>)l_, m_);
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(n_);

			return o_;
		};
		IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_ = context.Operators.Select<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_, e_);
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? g_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services Only")]
	public (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] b_ = [
			a_,
		];
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
		{
			(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_()
			{
				bool g_()
				{
					IEnumerable<ClaimResponse> h_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					IEnumerable<Claim> i_ = MedicalClaimAndResponse?.MedicalClaim;
					bool? j_ = context.Operators.And((bool?)(h_ is null), (bool?)(i_ is null));

					return j_ ?? false;
				};
				if (g_())
				{
					return null as (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
				}
				else
				{
					IEnumerable<ClaimResponse> k_ = MedicalClaimAndResponse?.MedicalClaimResponse;
					IEnumerable<Claim> l_ = MedicalClaimAndResponse?.MedicalClaim;
					(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_ = this.Get_Corresponding_Claim_for_Services_Only(k_, l_, ProductOrServiceValueSet);

					return m_;
				}
			};

			return f_();
		};
		IEnumerable<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> d_ = context.Operators.Select<(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_, c_);
		(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_ = context.Operators.SingletonFrom<(IEnumerable<(Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);

		return e_;
	}

    [CqlDeclaration("Get All Pharmacy Claims and Claim Responses")]
	public (IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? Get_All_Pharmacy_Claims_and_Claim_Responses(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		IEnumerable<ClaimResponse> a_ = this.Pharmacy_Claims_Response(claimResponse);
		IEnumerable<Claim> b_ = this.Pharmacy_Claims(claim);
		(IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? c_ = (a_, b_);

		return c_;
	}

    [CqlDeclaration("Get Corresponding Claim for Pharmacy Services")]
	public (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Corresponding_Claim_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> a_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> b_ = this.Pharmacy_Claim_With_Medication(claim, ProductOrServiceValueSet);
		(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? c_ = (a_, b_);
		(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?[] d_ = [
			c_,
		];
		(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? e_((IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? ClaimAndResponse)
		{
			IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> h_ = ClaimAndResponse?.MedicalClaim;
			((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? i_((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? medClaim)
			{
				IEnumerable<Claim.ItemComponent> p_ = medClaim?.LineItem;
				bool? q_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> t_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> u_((ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
					{
						IEnumerable<ClaimResponse.ItemComponent> x_ = pClaim?.LineItems;
						bool? y_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							Id ac_()
							{
								bool aq_()
								{
									Claim ar_ = medClaim?.Claim;
									bool as_ = ar_ is Resource;

									return as_;
								};
								if (aq_())
								{
									Claim at_ = medClaim?.Claim;

									return (at_ as Resource).IdElement;
								}
								else
								{
									return default;
								}
							};
							string ad_ = FHIRHelpers_4_0_001.ToString(ac_());
							ClaimResponse ae_ = pClaim?.Response;
							ResourceReference af_ = ae_?.Request;
							FhirString ag_ = af_?.ReferenceElement;
							string ah_ = FHIRHelpers_4_0_001.ToString(ag_);
							string ai_ = NCQAFHIRBase_1_0_0.GetId(ah_);
							bool? aj_ = context.Operators.Equal(ad_, ai_);
							PositiveInt ak_ = medClaimLineItem?.SequenceElement;
							Integer al_ = context.Operators.Convert<Integer>(ak_);
							PositiveInt am_ = pClaimLineItem?.ItemSequenceElement;
							Integer an_ = context.Operators.Convert<Integer>(am_);
							bool? ao_ = context.Operators.Equal(al_, an_);
							bool? ap_ = context.Operators.And(aj_, ao_);

							return ap_;
						};
						IEnumerable<ClaimResponse.ItemComponent> z_ = context.Operators.Where<ClaimResponse.ItemComponent>(x_, y_);
						(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? aa_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ab_ = context.Operators.Select<ClaimResponse.ItemComponent, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(z_, aa_);

						return ab_;
					};
					IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> v_ = context.Operators.SelectMany<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
					bool? w_ = context.Operators.Exists<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(v_);

					return w_;
				};
				IEnumerable<Claim.ItemComponent> r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
				((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? s_ = (medClaim, r_);

				return s_;
			};
			IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> j_ = context.Operators.Select<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?, ((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(h_, i_);
			(IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)? k_ = (j_, default);
			(IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?[] l_ = [
				k_,
			];
			(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? m_((IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)? ClaimWithPaidResponse)
			{
				(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? au_()
				{
					bool az_()
					{
						IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ba_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bb_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> bh_ = @this?.ClaimItem;
							bool? bi_ = context.Operators.Not((bool?)(bh_ is null));

							return bi_;
						};
						IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bc_ = context.Operators.Where<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ba_, bb_);
						IEnumerable<Claim.ItemComponent> bd_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> bj_ = @this?.ClaimItem;

							return bj_;
						};
						IEnumerable<IEnumerable<Claim.ItemComponent>> be_ = context.Operators.Select<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
						IEnumerable<Claim.ItemComponent> bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
						bool? bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);

						return bg_ ?? false;
					};
					if (az_())
					{
						IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bk_ = ClaimWithPaidResponse?.AggregateClaim;
						bool? bl_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? cg_ = @this?.PaidClaim;
							bool? ch_ = context.Operators.Not((bool?)(cg_ is null));

							return ch_;
						};
						IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bm_ = context.Operators.Where<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bl_);
						(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? bn_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? ci_ = @this?.PaidClaim;

							return ci_;
						};
						IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> bo_ = context.Operators.Select<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(bm_, bn_);
						bool? bq_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> cj_ = @this?.ClaimItem;
							bool? ck_ = context.Operators.Not((bool?)(cj_ is null));

							return ck_;
						};
						IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> br_ = context.Operators.Where<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bq_);
						IEnumerable<Claim.ItemComponent> bs_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> cl_ = @this?.ClaimItem;

							return cl_;
						};
						IEnumerable<IEnumerable<Claim.ItemComponent>> bt_ = context.Operators.Select<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(br_, bs_);
						IEnumerable<Claim.ItemComponent> bu_ = context.Operators.Flatten<Claim.ItemComponent>(bt_);
						CqlInterval<CqlDateTime> bv_(Claim.ItemComponent PaidItem)
						{
							DataType cm_ = PaidItem?.Serviced;
							CqlInterval<CqlDateTime> cn_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cm_);

							return cn_;
						};
						IEnumerable<CqlInterval<CqlDateTime>> bw_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bu_, bv_);
						bool? by_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> co_ = @this?.ClaimItem;
							bool? cp_ = context.Operators.Not((bool?)(co_ is null));

							return cp_;
						};
						IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bz_ = context.Operators.Where<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, by_);
						IEnumerable<Claim.ItemComponent> ca_(((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
						{
							IEnumerable<Claim.ItemComponent> cq_ = @this?.ClaimItem;

							return cq_;
						};
						IEnumerable<IEnumerable<Claim.ItemComponent>> cb_ = context.Operators.Select<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bz_, ca_);
						IEnumerable<Claim.ItemComponent> cc_ = context.Operators.Flatten<Claim.ItemComponent>(cb_);
						CqlInterval<CqlDate> cd_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDate> cr_()
							{
								bool cs_()
								{
									Quantity ct_ = i?.Quantity;
									bool? cu_ = context.Operators.Not((bool?)(ct_ is null));

									return cu_ ?? false;
								};
								if (cs_())
								{
									DataType cv_ = i?.Serviced;
									CqlInterval<CqlDateTime> cw_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cv_);
									CqlDateTime cx_ = context.Operators.Start(cw_);
									CqlDate cy_ = context.Operators.ConvertDateTimeToDate(cx_);
									CqlInterval<CqlDateTime> da_ = NCQAFHIRBase_1_0_0.Normalize_Interval(cv_);
									CqlDateTime db_ = context.Operators.Start(da_);
									Quantity dc_ = i?.Quantity;
									FhirDecimal dd_ = dc_?.ValueElement;
									decimal? de_ = FHIRHelpers_4_0_001.ToDecimal(dd_);
									CqlDateTime df_ = context.Operators.Add(db_, new CqlQuantity(de_, "day"));
									CqlQuantity dg_ = context.Operators.Quantity(1m, "day");
									CqlDateTime dh_ = context.Operators.Subtract(df_, dg_);
									CqlDate di_ = context.Operators.ConvertDateTimeToDate(dh_);
									CqlInterval<CqlDate> dj_ = context.Operators.Interval(cy_, di_, true, true);

									return dj_;
								}
								else
								{
									return null as CqlInterval<CqlDate>;
								}
							};

							return cr_();
						};
						IEnumerable<CqlInterval<CqlDate>> ce_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDate>>(cc_, cd_);
						(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? cf_ = (bo_, bw_, ce_);

						return cf_;
					}
					else
					{
						return null as (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
					}
				};
				(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?[] av_ = [
					au_(),
				];
				bool? aw_((IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? FinalList)
				{
					bool? dk_ = context.Operators.Not((bool?)(FinalList is null));

					return dk_;
				};
				IEnumerable<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> ax_ = context.Operators.Where<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>)av_, aw_);
				(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? ay_ = context.Operators.SingletonFrom<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(ax_);

				return ay_;
			};
			IEnumerable<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> n_ = context.Operators.Select<(IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?, (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(IEnumerable<((Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim, nint _)?>)l_, m_);
			(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? o_ = context.Operators.SingletonFrom<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(n_);

			return o_;
		};
		IEnumerable<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> f_ = context.Operators.Select<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?, (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(IEnumerable<(ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?>)d_, e_);
		(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? g_ = context.Operators.SingletonFrom<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Pharmacy Services")]
	public (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Paid_Claims_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		(IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? a_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(claimResponse, claim);
		(IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?[] b_ = [
			a_,
		];
		(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? c_((IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? PharmacyClaimAndResponse)
		{
			(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? f_()
			{
				bool g_()
				{
					IEnumerable<ClaimResponse> h_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
					IEnumerable<Claim> i_ = PharmacyClaimAndResponse?.PharmacyClaim;
					bool? j_ = context.Operators.And((bool?)(h_ is null), (bool?)(i_ is null));

					return j_ ?? false;
				};
				if (g_())
				{
					return null as (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
				}
				else
				{
					IEnumerable<ClaimResponse> k_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
					IEnumerable<Claim> l_ = PharmacyClaimAndResponse?.PharmacyClaim;
					(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? m_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(k_, l_, ProductOrServiceValueSet);

					return m_;
				}
			};

			return f_();
		};
		IEnumerable<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> d_ = context.Operators.Select<(IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?, (IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?>)b_, c_);
		(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? e_ = context.Operators.SingletonFrom<(IEnumerable<(Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(d_);

		return e_;
	}

    [CqlDeclaration("Get Claim With Corresponding Claim Response")]
	public IEnumerable<(IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> Get_Claim_With_Corresponding_Claim_Response(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		(IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? a_(Claim Claim)
		{
			bool? c_(ClaimResponse CR)
			{
				Id h_ = Claim?.IdElement;
				string i_ = FHIRHelpers_4_0_001.ToString(h_);
				ResourceReference j_ = CR?.Request;
				FhirString k_ = j_?.ReferenceElement;
				string l_ = FHIRHelpers_4_0_001.ToString(k_);
				string m_ = NCQAFHIRBase_1_0_0.GetId(l_);
				bool? n_ = context.Operators.Equal(i_, m_);

				return n_;
			};
			IEnumerable<ClaimResponse> d_ = context.Operators.Where<ClaimResponse>(claimResponse, c_);
			bool? e_(Claim C)
			{
				Id o_ = Claim?.IdElement;
				string p_ = FHIRHelpers_4_0_001.ToString(o_);
				bool? q_(ClaimResponse CR)
				{
					Id ae_ = Claim?.IdElement;
					string af_ = FHIRHelpers_4_0_001.ToString(ae_);
					ResourceReference ag_ = CR?.Request;
					FhirString ah_ = ag_?.ReferenceElement;
					string ai_ = FHIRHelpers_4_0_001.ToString(ah_);
					string aj_ = NCQAFHIRBase_1_0_0.GetId(ai_);
					bool? ak_ = context.Operators.Equal(af_, aj_);

					return ak_;
				};
				IEnumerable<ClaimResponse> r_ = context.Operators.Where<ClaimResponse>(claimResponse, q_);
				bool? s_(ClaimResponse @this)
				{
					ResourceReference al_ = @this?.Request;
					bool? am_ = context.Operators.Not((bool?)(al_ is null));

					return am_;
				};
				IEnumerable<ClaimResponse> t_ = context.Operators.Where<ClaimResponse>(r_, s_);
				ResourceReference u_(ClaimResponse @this)
				{
					ResourceReference an_ = @this?.Request;

					return an_;
				};
				IEnumerable<ResourceReference> v_ = context.Operators.Select<ClaimResponse, ResourceReference>(t_, u_);
				bool? w_(ResourceReference @this)
				{
					FhirString ao_ = @this?.ReferenceElement;
					bool? ap_ = context.Operators.Not((bool?)(ao_ is null));

					return ap_;
				};
				IEnumerable<ResourceReference> x_ = context.Operators.Where<ResourceReference>(v_, w_);
				FhirString y_(ResourceReference @this)
				{
					FhirString aq_ = @this?.ReferenceElement;

					return aq_;
				};
				IEnumerable<FhirString> z_ = context.Operators.Select<ResourceReference, FhirString>(x_, y_);
				FhirString aa_ = context.Operators.SingletonFrom<FhirString>(z_);
				string ab_ = FHIRHelpers_4_0_001.ToString(aa_);
				string ac_ = NCQAFHIRBase_1_0_0.GetId(ab_);
				bool? ad_ = context.Operators.Equal(p_, ac_);

				return ad_;
			};
			IEnumerable<Claim> f_ = context.Operators.Where<Claim>(claim, e_);
			(IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? g_ = (d_, f_);

			return g_;
		};
		IEnumerable<(IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> b_ = context.Operators.Select<Claim, (IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Medical Claims With Nonacute or Acute Inpatient Discharge")]
	public (IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(IEnumerable<Claim> claim)
	{
		IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(claim);
		(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? b_ = (a_, default, default);
		(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] c_ = [
			b_,
		];
		(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? d_((IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithInpatientStay)
		{
			IEnumerable<Claim> g_()
			{
				if (ClaimWithInpatientStay?.MedicalClaim is null)
				{
					return null as IEnumerable<Claim>;
				}
				else
				{
					IEnumerable<Claim> n_ = ClaimWithInpatientStay?.MedicalClaim;
					bool? o_(Claim c)
					{
						List<Claim.ItemComponent> q_ = c?.Item;
						bool? r_(Claim.ItemComponent i)
						{
							CodeableConcept u_ = i?.Revenue;
							CqlConcept v_ = FHIRHelpers_4_0_001.ToConcept(u_);
							CqlCode[] w_ = v_?.codes;
							bool? x_(CqlCode rev)
							{
								string aa_ = rev?.code;
								CqlValueSet ab_ = this.Inpatient_Stay();
								bool? ac_ = context.Operators.StringInValueSet(aa_, ab_);

								return ac_;
							};
							IEnumerable<CqlCode> y_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)w_, x_);
							bool? z_ = context.Operators.Exists<CqlCode>(y_);

							return z_;
						};
						IEnumerable<Claim.ItemComponent> s_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)q_, r_);
						bool? t_ = context.Operators.Exists<Claim.ItemComponent>(s_);

						return t_;
					};
					IEnumerable<Claim> p_ = context.Operators.Where<Claim>(n_, o_);

					return p_;
				}
			};
			IEnumerable<Claim> h_()
			{
				if (ClaimWithInpatientStay?.MedicalClaim is null)
				{
					return null as IEnumerable<Claim>;
				}
				else
				{
					IEnumerable<Claim> ad_ = ClaimWithInpatientStay?.MedicalClaim;
					bool? ae_(Claim c)
					{
						List<Claim.ItemComponent> ag_ = c?.Item;
						bool? ah_(Claim.ItemComponent i)
						{
							CodeableConcept aq_ = i?.Revenue;
							CqlConcept ar_ = FHIRHelpers_4_0_001.ToConcept(aq_);
							CqlCode[] as_ = ar_?.codes;
							bool? at_(CqlCode rev)
							{
								string aw_ = rev?.code;
								CqlValueSet ax_ = this.Nonacute_Inpatient_Stay();
								bool? ay_ = context.Operators.StringInValueSet(aw_, ax_);

								return ay_;
							};
							IEnumerable<CqlCode> au_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)as_, at_);
							bool? av_ = context.Operators.Exists<CqlCode>(au_);

							return av_;
						};
						IEnumerable<Claim.ItemComponent> ai_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ag_, ah_);
						bool? aj_ = context.Operators.Exists<Claim.ItemComponent>(ai_);
						CodeableConcept ak_ = c?.SubType;
						List<Coding> al_ = ak_?.Coding;
						bool? am_(Coding tob)
						{
							Code az_ = tob?.CodeElement;
							string ba_ = az_?.Value;
							CqlValueSet bb_ = this.Nonacute_Inpatient_Stay();
							bool? bc_ = context.Operators.StringInValueSet(ba_, bb_);

							return bc_;
						};
						IEnumerable<Coding> an_ = context.Operators.Where<Coding>((IEnumerable<Coding>)al_, am_);
						bool? ao_ = context.Operators.Exists<Coding>(an_);
						bool? ap_ = context.Operators.Or(aj_, ao_);

						return ap_;
					};
					IEnumerable<Claim> af_ = context.Operators.Where<Claim>(ad_, ae_);

					return af_;
				}
			};
			(IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? i_ = (g_(), h_());
			(IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?[] j_ = [
				i_,
			];
			(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? k_((IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? LineItemDefinition)
			{
				IEnumerable<Claim> bd_ = LineItemDefinition?.InpatientStayLineItems;
				IEnumerable<Claim> be_ = LineItemDefinition?.NonacuteInpatientLineItems;
				IEnumerable<Claim> bf_(Claim nonAcuteInpatientStay)
				{
					IEnumerable<Claim> bn_ = LineItemDefinition?.InpatientStayLineItems;
					bool? bo_(Claim inpatientStay)
					{
						Id bs_ = nonAcuteInpatientStay?.IdElement;
						Id bt_ = inpatientStay?.IdElement;
						bool? bu_ = context.Operators.Equal(bs_, bt_);

						return bu_;
					};
					IEnumerable<Claim> bp_ = context.Operators.Where<Claim>(bn_, bo_);
					Claim bq_(Claim inpatientStay) => 
						nonAcuteInpatientStay;
					IEnumerable<Claim> br_ = context.Operators.Select<Claim, Claim>(bp_, bq_);

					return br_;
				};
				IEnumerable<Claim> bg_ = context.Operators.SelectMany<Claim, Claim>(be_, bf_);
				IEnumerable<Claim> bj_(Claim inpatientStay)
				{
					IEnumerable<Claim> bv_ = LineItemDefinition?.NonacuteInpatientLineItems;
					bool? bw_(Claim nonAcuteInpatientStay)
					{
						Id ca_ = inpatientStay?.IdElement;
						Id cb_ = nonAcuteInpatientStay?.IdElement;
						bool? cc_ = context.Operators.Equal(ca_, cb_);

						return cc_;
					};
					IEnumerable<Claim> bx_ = context.Operators.Where<Claim>(bv_, bw_);
					Claim by_(Claim nonAcuteInpatientStay) => 
						inpatientStay;
					IEnumerable<Claim> bz_ = context.Operators.Select<Claim, Claim>(bx_, by_);

					return bz_;
				};
				IEnumerable<Claim> bk_ = context.Operators.SelectMany<Claim, Claim>(bd_, bj_);
				IEnumerable<Claim> bl_ = context.Operators.Except<Claim>(bd_, bk_);
				(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? bm_ = (bd_, bg_, bl_);

				return bm_;
			};
			IEnumerable<(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> l_ = context.Operators.Select<(IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?, (IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?>)j_, k_);
			(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? m_ = context.Operators.SingletonFrom<(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(l_);

			return m_;
		};
		IEnumerable<(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> e_ = context.Operators.Select<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, (IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)c_, d_);
		(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? f_ = context.Operators.SingletonFrom<(IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(e_);

		return f_;
	}

    [CqlDeclaration("Get Prescriber NPI from Claims")]
	public (int? IdentifierCount, nint _)? Get_Prescriber_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? a_(Claim C)
		{
			List<Claim.CareTeamComponent> h_ = C?.CareTeam;
			bool? i_(Claim.CareTeamComponent ct)
			{
				PositiveInt y_ = ct?.SequenceElement;
				Integer z_ = context.Operators.Convert<Integer>(y_);
				int? aa_ = FHIRHelpers_4_0_001.ToInteger(z_);
				bool? ab_ = context.Operators.Equal(aa_, 1);

				return ab_;
			};
			IEnumerable<Claim.CareTeamComponent> j_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)h_, i_);
			bool? k_(Claim.CareTeamComponent @this)
			{
				ResourceReference ac_ = @this?.Provider;
				bool? ad_ = context.Operators.Not((bool?)(ac_ is null));

				return ad_;
			};
			IEnumerable<Claim.CareTeamComponent> l_ = context.Operators.Where<Claim.CareTeamComponent>(j_, k_);
			ResourceReference m_(Claim.CareTeamComponent @this)
			{
				ResourceReference ae_ = @this?.Provider;

				return ae_;
			};
			IEnumerable<ResourceReference> n_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(l_, m_);
			bool? p_(Claim.CareTeamComponent ct)
			{
				PositiveInt af_ = ct?.SequenceElement;
				Integer ag_ = context.Operators.Convert<Integer>(af_);
				int? ah_ = FHIRHelpers_4_0_001.ToInteger(ag_);
				bool? ai_ = context.Operators.Equal(ah_, 1);

				return ai_;
			};
			IEnumerable<Claim.CareTeamComponent> q_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)h_, p_);
			bool? r_(Claim.CareTeamComponent @this)
			{
				ResourceReference aj_ = @this?.Provider;
				bool? ak_ = context.Operators.Not((bool?)(aj_ is null));

				return ak_;
			};
			IEnumerable<Claim.CareTeamComponent> s_ = context.Operators.Where<Claim.CareTeamComponent>(q_, r_);
			ResourceReference t_(Claim.CareTeamComponent @this)
			{
				ResourceReference al_ = @this?.Provider;

				return al_;
			};
			IEnumerable<ResourceReference> u_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(s_, t_);
			string v_(ResourceReference p)
			{
				FhirString am_ = p?.ReferenceElement;
				FhirString[] an_ = [
					am_,
				];
				string ao_(FhirString r)
				{
					string ar_ = FHIRHelpers_4_0_001.ToString(r);
					string as_ = NCQAFHIRBase_1_0_0.GetId(ar_);

					return as_;
				};
				IEnumerable<string> ap_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)an_, ao_);
				string aq_ = context.Operators.SingletonFrom<string>(ap_);

				return aq_;
			};
			IEnumerable<string> w_ = context.Operators.Select<ResourceReference, string>(u_, v_);
			(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? x_ = (C, n_, w_);

			return x_;
		};
		IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> b_ = context.Operators.Select<Claim, (Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(claim, a_);
		(IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams, nint _)? c_ = (b_, default);
		(IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams, nint _)?[] d_ = [
			c_,
		];
		(int? IdentifierCount, nint _)? e_((IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams, nint _)? ClaimProperties)
		{
			IEnumerable<Practitioner> at_ = context.Operators.Retrieve<Practitioner>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Practitioner"));
			bool? au_(Practitioner p)
			{
				Id bb_ = p?.IdElement;
				string bc_ = FHIRHelpers_4_0_001.ToString(bb_);
				IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> bd_ = ClaimProperties?.CareTeams;
				bool? be_((Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
				{
					IEnumerable<string> bk_ = @this?.CareTeamsProviderID;
					bool? bl_ = context.Operators.Not((bool?)(bk_ is null));

					return bl_;
				};
				IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> bf_ = context.Operators.Where<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(bd_, be_);
				IEnumerable<string> bg_((Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
				{
					IEnumerable<string> bm_ = @this?.CareTeamsProviderID;

					return bm_;
				};
				IEnumerable<IEnumerable<string>> bh_ = context.Operators.Select<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, IEnumerable<string>>(bf_, bg_);
				IEnumerable<string> bi_ = context.Operators.Flatten<string>(bh_);
				bool? bj_ = context.Operators.In<string>(bc_, bi_);

				return bj_;
			};
			IEnumerable<Practitioner> av_ = context.Operators.Where<Practitioner>(at_, au_);
			(IEnumerable<Practitioner> Practitioners, nint _)? aw_ = (av_, default);
			(IEnumerable<Practitioner> Practitioners, nint _)?[] ax_ = [
				aw_,
			];
			(int? IdentifierCount, nint _)? ay_((IEnumerable<Practitioner> Practitioners, nint _)? PractitionerMatch)
			{
				IEnumerable<Practitioner> bn_ = PractitionerMatch?.Practitioners;
				bool? bo_(Practitioner P)
				{
					bool? bx_ = context.Operators.Not((bool?)(P is null));

					return bx_;
				};
				IEnumerable<Practitioner> bp_ = context.Operators.Where<Practitioner>(bn_, bo_);
				(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? bq_(Practitioner P)
				{
					List<Identifier> by_ = P?.Identifier;
					bool? bz_(Identifier l)
					{
						FhirUri cj_ = l?.SystemElement;
						string ck_ = cj_?.Value;
						bool? cl_ = context.Operators.Equal(ck_, "http://hl7.org/fhir/sid/us-npi");
						CodeableConcept cm_ = l?.Type;
						CqlConcept cn_ = FHIRHelpers_4_0_001.ToConcept(cm_);
						CqlCode co_ = NCQATerminology_1_0_0.Provider_number();
						CqlConcept cp_ = context.Operators.ConvertCodeToConcept(co_);
						bool? cq_ = context.Operators.Equivalent(cn_, cp_);
						bool? cr_ = context.Operators.And(cl_, cq_);
						FhirString cs_ = l?.ValueElement;
						string ct_ = cs_?.Value;
						bool? cu_ = context.Operators.Not((bool?)(ct_ is null));
						bool? cv_ = context.Operators.And(cr_, cu_);

						return cv_;
					};
					IEnumerable<Identifier> ca_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)by_, bz_);
					FhirString cb_(Identifier l)
					{
						FhirString cw_ = l?.ValueElement;

						return cw_;
					};
					IEnumerable<FhirString> cc_ = context.Operators.Select<Identifier, FhirString>(ca_, cb_);
					bool? ce_(Identifier l)
					{
						FhirUri cx_ = l?.SystemElement;
						string cy_ = cx_?.Value;
						bool? cz_ = context.Operators.Equal(cy_, "http://hl7.org/fhir/sid/us-npi");
						CodeableConcept da_ = l?.Type;
						CqlConcept db_ = FHIRHelpers_4_0_001.ToConcept(da_);
						CqlCode dc_ = NCQATerminology_1_0_0.Provider_number();
						CqlConcept dd_ = context.Operators.ConvertCodeToConcept(dc_);
						bool? de_ = context.Operators.Equivalent(db_, dd_);
						bool? df_ = context.Operators.And(cz_, de_);
						FhirString dg_ = l?.ValueElement;
						string dh_ = dg_?.Value;
						bool? di_ = context.Operators.And(df_, (bool?)(dh_ is null));

						return di_;
					};
					IEnumerable<Identifier> cf_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)by_, ce_);
					Identifier cg_(Identifier l) => 
						l;
					IEnumerable<Identifier> ch_ = context.Operators.Select<Identifier, Identifier>(cf_, cg_);
					(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? ci_ = (cc_, ch_);

					return ci_;
				};
				IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> br_ = context.Operators.Select<Practitioner, (IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(bp_, bq_);
				(IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)? bs_ = (br_, default);
				(IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)?[] bt_ = [
					bs_,
				];
				(int? IdentifierCount, nint _)? bu_((IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)? GetIdentifiers)
				{
					int? dj_()
					{
						bool dl_()
						{
							IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> dm_ = ClaimProperties?.CareTeams;
							bool? dn_((Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
							{
								Claim ds_ = @this?.SingleCareTeam;
								bool? dt_ = context.Operators.Not((bool?)(ds_ is null));

								return dt_;
							};
							IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> do_ = context.Operators.Where<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(dm_, dn_);
							Claim dp_((Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
							{
								Claim du_ = @this?.SingleCareTeam;

								return du_;
							};
							IEnumerable<Claim> dq_ = context.Operators.Select<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(do_, dp_);
							bool? dr_ = context.Operators.Exists<Claim>(dq_);

							return dr_ ?? false;
						};
						if (dl_())
						{
							IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> dv_ = ClaimProperties?.CareTeams;
							bool? dw_((Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
							{
								Claim er_ = @this?.SingleCareTeam;
								bool? es_ = context.Operators.Not((bool?)(er_ is null));

								return es_;
							};
							IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> dx_ = context.Operators.Where<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(dv_, dw_);
							Claim dy_((Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
							{
								Claim et_ = @this?.SingleCareTeam;

								return et_;
							};
							IEnumerable<Claim> dz_ = context.Operators.Select<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(dx_, dy_);
							bool? ea_(Claim X)
							{
								List<Claim.CareTeamComponent> eu_ = X?.CareTeam;

								return (bool?)(((IEnumerable<Claim.CareTeamComponent>)eu_) is null);
							};
							IEnumerable<Claim> eb_ = context.Operators.Where<Claim>(dz_, ea_);
							int? ec_ = context.Operators.Count<Claim>(eb_);
							IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> ed_ = GetIdentifiers?.IdentifierTuple;
							IEnumerable<FhirString> ee_((IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
							{
								IEnumerable<FhirString> ev_ = X?.AllIdentifiers;

								return ev_;
							};
							IEnumerable<IEnumerable<FhirString>> ef_ = context.Operators.Select<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(ed_, ee_);
							IEnumerable<FhirString> eg_ = context.Operators.Flatten<FhirString>(ef_);
							FhirString eh_(FhirString X) => 
								X;
							IEnumerable<FhirString> ei_ = context.Operators.Select<FhirString, FhirString>(eg_, eh_);
							int? ej_ = context.Operators.Count<FhirString>(ei_);
							int? ek_ = context.Operators.Add(ec_, ej_);
							IEnumerable<Identifier> em_((IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
							{
								IEnumerable<Identifier> ew_ = X?.NullIdentifiers;

								return ew_;
							};
							IEnumerable<IEnumerable<Identifier>> en_ = context.Operators.Select<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(ed_, em_);
							IEnumerable<Identifier> eo_ = context.Operators.Flatten<Identifier>(en_);
							int? ep_ = context.Operators.Count<Identifier>(eo_);
							int? eq_ = context.Operators.Add(ek_, ep_);

							return eq_;
						}
						else
						{
							return 0;
						}
					};
					(int? IdentifierCount, nint _)? dk_ = (dj_(), default);

					return dk_;
				};
				IEnumerable<(int? IdentifierCount, nint _)?> bv_ = context.Operators.Select<(IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)?, (int? IdentifierCount, nint _)?>((IEnumerable<(IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)?>)bt_, bu_);
				(int? IdentifierCount, nint _)? bw_ = context.Operators.SingletonFrom<(int? IdentifierCount, nint _)?>(bv_);

				return bw_;
			};
			IEnumerable<(int? IdentifierCount, nint _)?> az_ = context.Operators.Select<(IEnumerable<Practitioner> Practitioners, nint _)?, (int? IdentifierCount, nint _)?>((IEnumerable<(IEnumerable<Practitioner> Practitioners, nint _)?>)ax_, ay_);
			(int? IdentifierCount, nint _)? ba_ = context.Operators.SingletonFrom<(int? IdentifierCount, nint _)?>(az_);

			return ba_;
		};
		IEnumerable<(int? IdentifierCount, nint _)?> f_ = context.Operators.Select<(IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams, nint _)?, (int? IdentifierCount, nint _)?>((IEnumerable<(IEnumerable<(Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams, nint _)?>)d_, e_);
		(int? IdentifierCount, nint _)? g_ = context.Operators.SingletonFrom<(int? IdentifierCount, nint _)?>(f_);

		return g_;
	}

    [CqlDeclaration("Get Pharmacy NPI from Claims")]
	public (int? IdentifierCount, nint _)? Get_Pharmacy_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? a_(Claim C)
		{
			List<Claim.ItemComponent> h_ = C?.Item;
			bool? j_(Claim.ItemComponent i)
			{
				PositiveInt ab_ = i?.SequenceElement;
				Integer ac_ = context.Operators.Convert<Integer>(ab_);
				int? ad_ = FHIRHelpers_4_0_001.ToInteger(ac_);
				bool? ae_ = context.Operators.Equal(ad_, 1);

				return ae_;
			};
			IEnumerable<Claim.ItemComponent> k_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)h_, j_);
			bool? l_(Claim.ItemComponent @this)
			{
				DataType af_ = @this?.Location;
				bool? ag_ = context.Operators.Not((bool?)(af_ is null));

				return ag_;
			};
			IEnumerable<Claim.ItemComponent> m_ = context.Operators.Where<Claim.ItemComponent>(k_, l_);
			object n_(Claim.ItemComponent @this)
			{
				DataType ah_ = @this?.Location;

				return ah_;
			};
			IEnumerable<object> o_ = context.Operators.Select<Claim.ItemComponent, object>(m_, n_);
			ResourceReference p_(object l) => 
				l as ResourceReference;
			IEnumerable<ResourceReference> q_ = context.Operators.Select<object, ResourceReference>(o_, p_);
			bool? s_(Claim.ItemComponent i)
			{
				PositiveInt ai_ = i?.SequenceElement;
				Integer aj_ = context.Operators.Convert<Integer>(ai_);
				int? ak_ = FHIRHelpers_4_0_001.ToInteger(aj_);
				bool? al_ = context.Operators.Equal(ak_, 1);

				return al_;
			};
			IEnumerable<Claim.ItemComponent> t_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)h_, s_);
			bool? u_(Claim.ItemComponent @this)
			{
				DataType am_ = @this?.Location;
				bool? an_ = context.Operators.Not((bool?)(am_ is null));

				return an_;
			};
			IEnumerable<Claim.ItemComponent> v_ = context.Operators.Where<Claim.ItemComponent>(t_, u_);
			object w_(Claim.ItemComponent @this)
			{
				DataType ao_ = @this?.Location;

				return ao_;
			};
			IEnumerable<object> x_ = context.Operators.Select<Claim.ItemComponent, object>(v_, w_);
			string y_(object l)
			{
				FhirString ap_ = (l as ResourceReference)?.ReferenceElement;
				FhirString[] aq_ = [
					ap_,
				];
				string ar_(FhirString r)
				{
					string au_ = FHIRHelpers_4_0_001.ToString(r);
					string av_ = NCQAFHIRBase_1_0_0.GetId(au_);

					return av_;
				};
				IEnumerable<string> as_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)aq_, ar_);
				string at_ = context.Operators.SingletonFrom<string>(as_);

				return at_;
			};
			IEnumerable<string> z_ = context.Operators.Select<object, string>(x_, y_);
			(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? aa_ = ((IEnumerable<Claim.ItemComponent>)h_, q_, z_);

			return aa_;
		};
		IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> b_ = context.Operators.Select<Claim, (IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(claim, a_);
		(IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences, nint _)? c_ = (b_, default);
		(IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences, nint _)?[] d_ = [
			c_,
		];
		(int? IdentifierCount, nint _)? e_((IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences, nint _)? ClaimProperties)
		{
			IEnumerable<Location> aw_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));
			bool? ax_(Location l)
			{
				Id be_ = l?.IdElement;
				string bf_ = FHIRHelpers_4_0_001.ToString(be_);
				IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> bg_ = ClaimProperties?.ItemsLocationReferences;
				bool? bh_((IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
				{
					IEnumerable<string> bn_ = @this?.ItemLocationID;
					bool? bo_ = context.Operators.Not((bool?)(bn_ is null));

					return bo_;
				};
				IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> bi_ = context.Operators.Where<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(bg_, bh_);
				IEnumerable<string> bj_((IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
				{
					IEnumerable<string> bp_ = @this?.ItemLocationID;

					return bp_;
				};
				IEnumerable<IEnumerable<string>> bk_ = context.Operators.Select<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<string>>(bi_, bj_);
				IEnumerable<string> bl_ = context.Operators.Flatten<string>(bk_);
				bool? bm_ = context.Operators.In<string>(bf_, bl_);

				return bm_;
			};
			IEnumerable<Location> ay_ = context.Operators.Where<Location>(aw_, ax_);
			(IEnumerable<Location> CorrespondingLocations, nint _)? az_ = (ay_, default);
			(IEnumerable<Location> CorrespondingLocations, nint _)?[] ba_ = [
				az_,
			];
			(int? IdentifierCount, nint _)? bb_((IEnumerable<Location> CorrespondingLocations, nint _)? GetLocation)
			{
				IEnumerable<Location> bq_ = GetLocation?.CorrespondingLocations;
				bool? br_(Location C)
				{
					bool? ca_ = context.Operators.Not((bool?)(C is null));

					return ca_;
				};
				IEnumerable<Location> bs_ = context.Operators.Where<Location>(bq_, br_);
				(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? bt_(Location C)
				{
					List<Identifier> cb_ = C?.Identifier;
					bool? cc_(Identifier l)
					{
						FhirUri cm_ = l?.SystemElement;
						string cn_ = cm_?.Value;
						bool? co_ = context.Operators.Equal(cn_, "http://hl7.org/fhir/sid/us-npi");
						CodeableConcept cp_ = l?.Type;
						CqlConcept cq_ = FHIRHelpers_4_0_001.ToConcept(cp_);
						CqlCode cr_ = NCQATerminology_1_0_0.Provider_number();
						CqlConcept cs_ = context.Operators.ConvertCodeToConcept(cr_);
						bool? ct_ = context.Operators.Equivalent(cq_, cs_);
						bool? cu_ = context.Operators.And(co_, ct_);
						FhirString cv_ = l?.ValueElement;
						string cw_ = cv_?.Value;
						bool? cx_ = context.Operators.Not((bool?)(cw_ is null));
						bool? cy_ = context.Operators.And(cu_, cx_);

						return cy_;
					};
					IEnumerable<Identifier> cd_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)cb_, cc_);
					FhirString ce_(Identifier l)
					{
						FhirString cz_ = l?.ValueElement;

						return cz_;
					};
					IEnumerable<FhirString> cf_ = context.Operators.Select<Identifier, FhirString>(cd_, ce_);
					bool? ch_(Identifier l)
					{
						FhirUri da_ = l?.SystemElement;
						string db_ = da_?.Value;
						bool? dc_ = context.Operators.Equal(db_, "http://hl7.org/fhir/sid/us-npi");
						CodeableConcept dd_ = l?.Type;
						CqlConcept de_ = FHIRHelpers_4_0_001.ToConcept(dd_);
						CqlCode df_ = NCQATerminology_1_0_0.Provider_number();
						CqlConcept dg_ = context.Operators.ConvertCodeToConcept(df_);
						bool? dh_ = context.Operators.Equivalent(de_, dg_);
						bool? di_ = context.Operators.And(dc_, dh_);
						FhirString dj_ = l?.ValueElement;
						string dk_ = dj_?.Value;
						bool? dl_ = context.Operators.And(di_, (bool?)(dk_ is null));

						return dl_;
					};
					IEnumerable<Identifier> ci_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)cb_, ch_);
					Identifier cj_(Identifier l) => 
						l;
					IEnumerable<Identifier> ck_ = context.Operators.Select<Identifier, Identifier>(ci_, cj_);
					(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? cl_ = (cf_, ck_);

					return cl_;
				};
				IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> bu_ = context.Operators.Select<Location, (IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(bs_, bt_);
				(IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)? bv_ = (bu_, default);
				(IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)?[] bw_ = [
					bv_,
				];
				(int? IdentifierCount, nint _)? bx_((IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)? GetIdentifiers)
				{
					int? dm_()
					{
						bool do_()
						{
							IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> dp_ = ClaimProperties?.ItemsLocationReferences;
							bool? dq_((IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
							{
								IEnumerable<Claim.ItemComponent> dw_ = @this?.SingleItem;
								bool? dx_ = context.Operators.Not((bool?)(dw_ is null));

								return dx_;
							};
							IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> dr_ = context.Operators.Where<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(dp_, dq_);
							IEnumerable<Claim.ItemComponent> ds_((IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
							{
								IEnumerable<Claim.ItemComponent> dy_ = @this?.SingleItem;

								return dy_;
							};
							IEnumerable<IEnumerable<Claim.ItemComponent>> dt_ = context.Operators.Select<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<Claim.ItemComponent>>(dr_, ds_);
							IEnumerable<Claim.ItemComponent> du_ = context.Operators.Flatten<Claim.ItemComponent>(dt_);
							bool? dv_ = context.Operators.Exists<Claim.ItemComponent>(du_);

							return dv_ ?? false;
						};
						if (do_())
						{
							IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> dz_ = ClaimProperties?.ItemsLocationReferences;
							bool? ea_((IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
							{
								IEnumerable<ResourceReference> ew_ = @this?.ItemLocation;
								bool? ex_ = context.Operators.Not((bool?)(ew_ is null));

								return ex_;
							};
							IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> eb_ = context.Operators.Where<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(dz_, ea_);
							IEnumerable<ResourceReference> ec_((IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
							{
								IEnumerable<ResourceReference> ey_ = @this?.ItemLocation;

								return ey_;
							};
							IEnumerable<IEnumerable<ResourceReference>> ed_ = context.Operators.Select<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<ResourceReference>>(eb_, ec_);
							IEnumerable<ResourceReference> ee_ = context.Operators.Flatten<ResourceReference>(ed_);
							bool? ef_(ResourceReference X)
							{
								FhirString ez_ = X?.ReferenceElement;
								string fa_ = ez_?.Value;

								return (bool?)(fa_ is null);
							};
							IEnumerable<ResourceReference> eg_ = context.Operators.Where<ResourceReference>(ee_, ef_);
							int? eh_ = context.Operators.Count<ResourceReference>(eg_);
							IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> ei_ = GetIdentifiers?.IdentifierTuple;
							IEnumerable<FhirString> ej_((IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
							{
								IEnumerable<FhirString> fb_ = X?.AllIdentifiers;

								return fb_;
							};
							IEnumerable<IEnumerable<FhirString>> ek_ = context.Operators.Select<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(ei_, ej_);
							IEnumerable<FhirString> el_ = context.Operators.Flatten<FhirString>(ek_);
							FhirString em_(FhirString X) => 
								X;
							IEnumerable<FhirString> en_ = context.Operators.Select<FhirString, FhirString>(el_, em_);
							int? eo_ = context.Operators.Count<FhirString>(en_);
							int? ep_ = context.Operators.Add(eh_, eo_);
							IEnumerable<Identifier> er_((IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
							{
								IEnumerable<Identifier> fc_ = X?.NullIdentifiers;

								return fc_;
							};
							IEnumerable<IEnumerable<Identifier>> es_ = context.Operators.Select<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(ei_, er_);
							IEnumerable<Identifier> et_ = context.Operators.Flatten<Identifier>(es_);
							int? eu_ = context.Operators.Count<Identifier>(et_);
							int? ev_ = context.Operators.Add(ep_, eu_);

							return ev_;
						}
						else
						{
							return 0;
						}
					};
					(int? IdentifierCount, nint _)? dn_ = (dm_(), default);

					return dn_;
				};
				IEnumerable<(int? IdentifierCount, nint _)?> by_ = context.Operators.Select<(IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)?, (int? IdentifierCount, nint _)?>((IEnumerable<(IEnumerable<(IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple, nint _)?>)bw_, bx_);
				(int? IdentifierCount, nint _)? bz_ = context.Operators.SingletonFrom<(int? IdentifierCount, nint _)?>(by_);

				return bz_;
			};
			IEnumerable<(int? IdentifierCount, nint _)?> bc_ = context.Operators.Select<(IEnumerable<Location> CorrespondingLocations, nint _)?, (int? IdentifierCount, nint _)?>((IEnumerable<(IEnumerable<Location> CorrespondingLocations, nint _)?>)ba_, bb_);
			(int? IdentifierCount, nint _)? bd_ = context.Operators.SingletonFrom<(int? IdentifierCount, nint _)?>(bc_);

			return bd_;
		};
		IEnumerable<(int? IdentifierCount, nint _)?> f_ = context.Operators.Select<(IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences, nint _)?, (int? IdentifierCount, nint _)?>((IEnumerable<(IEnumerable<(IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences, nint _)?>)d_, e_);
		(int? IdentifierCount, nint _)? g_ = context.Operators.SingletonFrom<(int? IdentifierCount, nint _)?>(f_);

		return g_;
	}

}

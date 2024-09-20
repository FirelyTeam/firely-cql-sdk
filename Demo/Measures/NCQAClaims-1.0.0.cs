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
[CqlLibrary("NCQAClaims", "1.0.0")]
public class NCQAClaims_1_0_0
{

    public static NCQAClaims_1_0_0 Instance { get; }  = new();

    [CqlDeclaration("Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395")]
	public CqlValueSet Inpatient_Stay(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395", null);

    [CqlDeclaration("Nonacute Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398")]
	public CqlValueSet Nonacute_Inpatient_Stay(CqlContext context) => 
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398", null);

    [CqlDeclaration("Professional or Institutional Claims")]
	public IEnumerable<Claim> Professional_or_Institutional_Claims(CqlContext context, IEnumerable<Claim> claim)
	{
		bool? a_(Claim MedicalClaim)
		{
			var c_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, MedicalClaim?.Type);
			var d_ = NCQATerminology_1_0_0.Instance.Professional(context);
			var e_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), d_);
			var g_ = NCQATerminology_1_0_0.Instance.Institutional(context);
			var h_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), g_);
			var i_ = context.Operators.Or(e_, h_);

			return i_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Pharmacy Claims")]
	public IEnumerable<Claim> Pharmacy_Claims(CqlContext context, IEnumerable<Claim> claim)
	{
		bool? a_(Claim PharmacyClaim)
		{
			var c_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, PharmacyClaim?.Type);
			var d_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
			var e_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), d_);

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);

		return b_;
	}

    [CqlDeclaration("Professional or Institutional Claims Response")]
	public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse MedicalResponse)
		{
			var c_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, MedicalResponse?.Type);
			var d_ = NCQATerminology_1_0_0.Instance.Professional(context);
			var e_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), d_);
			var g_ = NCQATerminology_1_0_0.Instance.Institutional(context);
			var h_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), g_);
			var i_ = context.Operators.Or(e_, h_);

			return i_;
		};
		var b_ = context.Operators.WhereOrNull<ClaimResponse>(claimResponse, a_);

		return b_;
	}

    [CqlDeclaration("Pharmacy Claims Response")]
	public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse PharmacyResponse)
		{
			var c_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, PharmacyResponse?.Type);
			var d_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
			var e_ = context.Operators.ListContains<CqlCode>((c_?.codes as IEnumerable<CqlCode>), d_);

			return e_;
		};
		var b_ = context.Operators.WhereOrNull<ClaimResponse>(claimResponse, a_);

		return b_;
	}

    [CqlDeclaration("Medical Claims With Procedure and POS")]
	public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_and_POS(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(context, claim);
		string b_(CqlCode p) => 
			p?.code;
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, b_);
		string d_(CqlCode pos) => 
			pos?.code;
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
						bool? v_(Claim.ItemComponent ItemOnLine)
						{
							var x_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ItemOnLine?.ProductOrService);
							bool? y_(CqlCode LineCode)
							{
								var ag_ = context.Operators.InList<string>(LineCode?.code, ClaimWithPosCode?.ProceduresAsStrings);

								return ag_;
							};
							var z_ = context.Operators.WhereOrNull<CqlCode>((x_?.codes as IEnumerable<CqlCode>), y_);
							var aa_ = context.Operators.ExistsInList<CqlCode>(z_);
							var ab_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, (ItemOnLine?.Location as CodeableConcept));
							bool? ac_(CqlCode PosCode)
							{
								var ah_ = context.Operators.InList<string>(PosCode?.code, ClaimWithPosCode?.POSAsString);

								return ah_;
							};
							var ad_ = context.Operators.WhereOrNull<CqlCode>((ab_?.codes as IEnumerable<CqlCode>), ac_);
							var ae_ = context.Operators.ExistsInList<CqlCode>(ad_);
							var af_ = context.Operators.And(aa_, ae_);

							return af_;
						};
						var w_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ClaimofInterest?.Item as IEnumerable<Claim.ItemComponent>), v_);

						return w_;
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
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ai_()
					{
						if ((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
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
								var ar_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

								return ar_;
							};
							var ao_ = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(am_, an_);
							var ap_ = new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = LineItemDefinition?.Claim,
								ServicePeriod = ao_,
							};

							return ap_;
						}
						else
						{
							Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA as_ = null;

							return (as_ as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
						};
					};

					return ai_();
				};
				var s_ = context.Operators.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_, r_);
				var t_ = context.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(s_);

				return t_;
			};
			var l_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ClaimWithPosCode?.MedicalClaim, k_);
			bool? m_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var at_ = context.Operators.Not((bool?)(FinalList is null));

				return at_;
			};
			var n_ = context.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(l_, m_);

			return n_;
		};
		var i_ = context.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);
		var j_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Procedure in Header or on Line Item")]
	public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(context, claim);
		string b_(CqlCode p) => 
			p?.code;
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
			Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA i_(Claim ClaimofInterest)
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
							var v_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ItemOnLine?.ProductOrService);
							bool? w_(CqlCode LineCode)
							{
								var ao_ = context.Operators.InList<string>(LineCode?.code, ClaimWithProcedure?.ProceduresAsStrings);

								return ao_;
							};
							var x_ = context.Operators.WhereOrNull<CqlCode>((v_?.codes as IEnumerable<CqlCode>), w_);
							var y_ = context.Operators.ExistsInList<CqlCode>(x_);
							bool? z_(Claim.ProcedureComponent @this)
							{
								var ap_ = context.Operators.Not((bool?)(@this?.Procedure is null));

								return ap_;
							};
							var aa_ = context.Operators.WhereOrNull<Claim.ProcedureComponent>((ClaimofInterest?.Procedure as IEnumerable<Claim.ProcedureComponent>), z_);
							DataType ab_(Claim.ProcedureComponent @this) => 
								@this?.Procedure;
							var ac_ = context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(aa_, ab_);
							bool? ad_(DataType @this)
							{
								var aq_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								var ar_ = context.Operators.Not((bool?)(aq_ is null));

								return ar_;
							};
							var ae_ = context.Operators.WhereOrNull<DataType>(ac_, ad_);
							object af_(DataType @this)
							{
								var as_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return as_;
							};
							var ag_ = context.Operators.SelectOrNull<DataType, object>(ae_, af_);
							var ah_ = context.Operators.FlattenLateBoundList(ag_);
							Coding ai_(object @object) => 
								(@object as Coding);
							var aj_ = context.Operators.SelectOrNull<object, Coding>(ah_, ai_);
							bool? ak_(Coding HeaderCode)
							{
								var at_ = context.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings);

								return at_;
							};
							var al_ = context.Operators.WhereOrNull<Coding>(aj_, ak_);
							var am_ = context.Operators.ExistsInList<Coding>(al_);
							var an_ = context.Operators.Or(y_, am_);

							return an_;
						};
						var u_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ClaimofInterest?.Item as IEnumerable<Claim.ItemComponent>), t_);

						return u_;
					};
				};
				var n_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = ClaimofInterest,
					LineItems = m_(),
				};
				var o_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					n_,
				};
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA p_(Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition)
				{
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA au_()
					{
						if ((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
						{
							bool? av_(Claim.ItemComponent @this)
							{
								var bc_ = context.Operators.Not((bool?)(@this?.Serviced is null));

								return bc_;
							};
							var aw_ = context.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, av_);
							DataType ax_(Claim.ItemComponent @this) => 
								@this?.Serviced;
							var ay_ = context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(aw_, ax_);
							CqlInterval<CqlDateTime> az_(DataType NormalDate)
							{
								var bd_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

								return bd_;
							};
							var ba_ = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(ay_, az_);
							var bb_ = new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = LineItemDefinition?.Claim,
								ServicePeriod = ba_,
							};

							return bb_;
						}
						else
						{
							Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA be_ = null;

							return (be_ as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
						};
					};

					return au_();
				};
				var q_ = context.Operators.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(o_, p_);
				var r_ = context.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_);

				return r_;
			};
			var j_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ClaimWithProcedure?.MedicalClaim, i_);
			bool? k_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var bf_ = context.Operators.Not((bool?)(FinalList is null));

				return bf_;
			};
			var l_ = context.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(j_, k_);

			return l_;
		};
		var g_ = context.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(e_, f_);
		var h_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis")]
	public Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI Medical_Claims_With_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(context, claim);
		string b_(CqlCode d) => 
			d?.code;
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
							var af_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

							return af_;
						};
						var s_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), r_);
						DataType t_(Claim.DiagnosisComponent @this) => 
							@this?.Diagnosis;
						var u_ = context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(s_, t_);
						bool? v_(DataType @this)
						{
							var ag_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							var ah_ = context.Operators.Not((bool?)(ag_ is null));

							return ah_;
						};
						var w_ = context.Operators.WhereOrNull<DataType>(u_, v_);
						object x_(DataType @this)
						{
							var ai_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return ai_;
						};
						var y_ = context.Operators.SelectOrNull<DataType, object>(w_, x_);
						var z_ = context.Operators.FlattenLateBoundList(y_);
						Coding aa_(object @object) => 
							(@object as Coding);
						var ab_ = context.Operators.SelectOrNull<object, Coding>(z_, aa_);
						bool? ac_(Coding HeaderCode)
						{
							var aj_ = context.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings);

							return aj_;
						};
						var ad_ = context.Operators.WhereOrNull<Coding>(ab_, ac_);
						var ae_ = context.Operators.ExistsInList<Coding>(ad_);

						return ae_;
					};
					var q_ = context.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, p_);

					return q_;
				};
			};
			var j_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = i_(),
			};
			var k_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				j_,
			};
			Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI l_(Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg HeaderDefinition)
			{
				Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI ak_()
				{
					if ((context.Operators.ExistsInList<Claim>(HeaderDefinition?.DiagnosisItems) ?? false))
					{
						bool? ap_(Claim @this)
						{
							var ax_ = context.Operators.Not((bool?)(@this?.Item is null));

							return ax_;
						};
						var aq_ = context.Operators.WhereOrNull<Claim>(HeaderDefinition?.DiagnosisItems, ap_);
						List<Claim.ItemComponent> ar_(Claim @this) => 
							@this?.Item;
						var as_ = context.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(aq_, ar_);
						var at_ = context.Operators.FlattenList<Claim.ItemComponent>(as_);
						CqlInterval<CqlDateTime> au_(Claim.ItemComponent NormalDate)
						{
							var ay_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate?.Serviced);

							return ay_;
						};
						var av_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(at_, au_);
						var aw_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = HeaderDefinition?.DiagnosisItems,
							ServicePeriod = av_,
						};

						return aw_;
					}
					else
					{
						Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI az_ = null;

						return (az_ as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI);
					};
				};
				var al_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI[]
				{
					ak_(),
				};
				bool? am_(Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList)
				{
					var ba_ = context.Operators.Not((bool?)(FinalList is null));

					return ba_;
				};
				var an_ = context.Operators.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(al_, am_);
				var ao_ = context.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(an_);

				return ao_;
			};
			var m_ = context.Operators.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(k_, l_);
			var n_ = context.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(m_);

			return n_;
		};
		var g_ = context.Operators.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(e_, f_);
		var h_ = context.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(g_);

		return h_;
	}

    [CqlDeclaration("Pharmacy Claim With Medication")]
	public IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> Pharmacy_Claim_With_Medication(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
	{
		var a_ = this.Pharmacy_Claims(context, claim);
		string b_(CqlCode p) => 
			p?.code;
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
			Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC i_(Claim Pharmacy)
			{
				bool? m_(Claim.ItemComponent ItemOnLine)
				{
					var t_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ItemOnLine?.ProductOrService);
					bool? u_(CqlCode LineCode)
					{
						var x_ = context.Operators.InList<string>(LineCode?.code, ClaimWithMedication?.MedicationsAsStrings);

						return x_;
					};
					var v_ = context.Operators.WhereOrNull<CqlCode>((t_?.codes as IEnumerable<CqlCode>), u_);
					var w_ = context.Operators.ExistsInList<CqlCode>(v_);

					return w_;
				};
				var n_ = context.Operators.WhereOrNull<Claim.ItemComponent>((Pharmacy?.Item as IEnumerable<Claim.ItemComponent>), m_);
				var o_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = Pharmacy,
					LineItems = n_,
				};
				var p_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					o_,
				};
				Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC q_(Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition)
				{
					var y_ = new Claim[]
					{
						LineItemDefinition?.Claim,
					};
					Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC z_(Claim ClaimLines)
					{
						bool? ac_(Claim.ItemComponent i)
						{
							var al_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, i?.ProductOrService);
							bool? am_(CqlCode LineCode)
							{
								var ap_ = context.Operators.InList<string>(LineCode?.code, ClaimWithMedication?.MedicationsAsStrings);

								return ap_;
							};
							var an_ = context.Operators.WhereOrNull<CqlCode>((al_?.codes as IEnumerable<CqlCode>), am_);
							var ao_ = context.Operators.ExistsInList<CqlCode>(an_);

							return ao_;
						};
						var ad_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ClaimLines?.Item as IEnumerable<Claim.ItemComponent>), ac_);
						Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP ae_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDateTime> aq_()
							{
								if ((context.Operators.Not((bool?)(i?.Quantity is null)) ?? false))
								{
									CqlInterval<CqlDateTime> as_()
									{
										if (i?.Serviced is Period)
										{
											var at_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, i?.Serviced);
											var au_ = context.Operators.Start(at_);
											var aw_ = context.Operators.Start(at_);
											var ax_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, i?.Quantity?.ValueElement);
											var ay_ = context.Operators.Add(aw_, new CqlQuantity(ax_, "day"));
											var az_ = context.Operators.Quantity(1m, "day");
											var ba_ = context.Operators.Subtract(ay_, az_);
											var bb_ = context.Operators.Interval(au_, ba_, true, true);

											return bb_;
										}
										else
										{
											var bc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, (i?.Serviced as Date));
											var be_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, i?.Quantity?.ValueElement);
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
									CqlInterval<CqlDateTime> ch_ = null;

									return (ch_ as CqlInterval<CqlDateTime>);
								};
							};
							var ar_ = new Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP
							{
								DaysSupplyInterval = aq_(),
							};

							return ar_;
						};
						var af_ = context.Operators.SelectOrNull<Claim.ItemComponent, Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP>(ad_, ae_);
						var ag_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU
						{
							CoveredDays = af_,
						};
						var ah_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU[]
						{
							ag_,
						};
						Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC ai_(Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU ItemCalculation)
						{
							Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC ci_()
							{
								if ((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
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
										var ct_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

										return ct_;
									};
									var co_ = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(cm_, cn_);
									CqlInterval<CqlDateTime> cp_(Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP d) => 
										d?.DaysSupplyInterval;
									var cq_ = context.Operators.SelectOrNull<Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP, CqlInterval<CqlDateTime>>(ItemCalculation?.CoveredDays, cp_);
									var cr_ = new Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC
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
									Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC cu_ = null;

									return (cu_ as Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC);
								};
							};

							return ci_();
						};
						var aj_ = context.Operators.SelectOrNull<Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ah_, ai_);
						var ak_ = context.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(aj_);

						return ak_;
					};
					var aa_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(y_, z_);
					var ab_ = context.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(aa_);

					return ab_;
				};
				var r_ = context.Operators.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(p_, q_);
				var s_ = context.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(r_);

				return s_;
			};
			var j_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ClaimWithMedication?.PharmacyClaim, i_);
			bool? k_(Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC FinalList)
			{
				var cv_ = context.Operators.Not((bool?)(FinalList is null));

				return cv_;
			};
			var l_ = context.Operators.WhereOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(j_, k_);

			return l_;
		};
		var g_ = context.Operators.SelectOrNull<Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY, IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(e_, f_);
		var h_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(g_);

		return h_;
	}

    [CqlDeclaration("Medical Claims With Diagnosis and Procedure")]
	public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(context, claim);
		string b_(CqlCode d) => 
			d?.code;
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p) => 
			p?.code;
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
							var ah_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

							return ah_;
						};
						var u_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), t_);
						DataType v_(Claim.DiagnosisComponent @this) => 
							@this?.Diagnosis;
						var w_ = context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(u_, v_);
						bool? x_(DataType @this)
						{
							var ai_ = context.Operators.LateBoundProperty<object>(@this, "coding");
							var aj_ = context.Operators.Not((bool?)(ai_ is null));

							return aj_;
						};
						var y_ = context.Operators.WhereOrNull<DataType>(w_, x_);
						object z_(DataType @this)
						{
							var ak_ = context.Operators.LateBoundProperty<object>(@this, "coding");

							return ak_;
						};
						var aa_ = context.Operators.SelectOrNull<DataType, object>(y_, z_);
						var ab_ = context.Operators.FlattenLateBoundList(aa_);
						Coding ac_(object @object) => 
							(@object as Coding);
						var ad_ = context.Operators.SelectOrNull<object, Coding>(ab_, ac_);
						bool? ae_(Coding HeaderCode)
						{
							var al_ = context.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings);

							return al_;
						};
						var af_ = context.Operators.WhereOrNull<Coding>(ad_, ae_);
						var ag_ = context.Operators.ExistsInList<Coding>(af_);

						return ag_;
					};
					var s_ = context.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, r_);

					return s_;
				};
			};
			var l_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = k_(),
			};
			var m_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				l_,
			};
			IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> n_(Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg ClaimWithProcedure)
			{
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA am_(Claim ClaimofInterest)
				{
					Claim aq_()
					{
						if ((ClaimofInterest is null))
						{
							return null;
						}
						else
						{
							var aw_ = new Claim[]
							{
								ClaimofInterest,
							};
							bool? ax_(Claim ItemOnLine)
							{
								bool? ba_(Claim.ProcedureComponent @this)
								{
									var cb_ = context.Operators.Not((bool?)(@this?.Procedure is null));

									return cb_;
								};
								var bb_ = context.Operators.WhereOrNull<Claim.ProcedureComponent>((ItemOnLine?.Procedure as IEnumerable<Claim.ProcedureComponent>), ba_);
								DataType bc_(Claim.ProcedureComponent @this) => 
									@this?.Procedure;
								var bd_ = context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(bb_, bc_);
								bool? be_(DataType @this)
								{
									var cc_ = context.Operators.LateBoundProperty<object>(@this, "coding");
									var cd_ = context.Operators.Not((bool?)(cc_ is null));

									return cd_;
								};
								var bf_ = context.Operators.WhereOrNull<DataType>(bd_, be_);
								object bg_(DataType @this)
								{
									var ce_ = context.Operators.LateBoundProperty<object>(@this, "coding");

									return ce_;
								};
								var bh_ = context.Operators.SelectOrNull<DataType, object>(bf_, bg_);
								var bi_ = context.Operators.FlattenLateBoundList(bh_);
								Coding bj_(object @object) => 
									(@object as Coding);
								var bk_ = context.Operators.SelectOrNull<object, Coding>(bi_, bj_);
								bool? bl_(Coding ProcedureHeaderCode)
								{
									var cf_ = context.Operators.InList<string>(ProcedureHeaderCode?.CodeElement?.Value, ClaimWithDiagnosis?.ProceduresAsStrings);

									return cf_;
								};
								var bm_ = context.Operators.WhereOrNull<Coding>(bk_, bl_);
								var bn_ = context.Operators.ExistsInList<Coding>(bm_);
								bool? bo_(Claim.ItemComponent @this)
								{
									var cg_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

									return cg_;
								};
								var bp_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ItemOnLine?.Item as IEnumerable<Claim.ItemComponent>), bo_);
								CodeableConcept bq_(Claim.ItemComponent @this) => 
									@this?.ProductOrService;
								var br_ = context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(bp_, bq_);
								bool? bs_(CodeableConcept @this)
								{
									var ch_ = context.Operators.Not((bool?)(@this?.Coding is null));

									return ch_;
								};
								var bt_ = context.Operators.WhereOrNull<CodeableConcept>(br_, bs_);
								List<Coding> bu_(CodeableConcept @this) => 
									@this?.Coding;
								var bv_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(bt_, bu_);
								var bw_ = context.Operators.FlattenList<Coding>(bv_);
								bool? bx_(Coding LineCode)
								{
									var ci_ = context.Operators.InList<string>(LineCode?.CodeElement?.Value, ClaimWithDiagnosis?.ProceduresAsStrings);

									return ci_;
								};
								var by_ = context.Operators.WhereOrNull<Coding>(bw_, bx_);
								var bz_ = context.Operators.ExistsInList<Coding>(by_);
								var ca_ = context.Operators.Or(bn_, bz_);

								return ca_;
							};
							var ay_ = context.Operators.WhereOrNull<Claim>(aw_, ax_);
							var az_ = context.Operators.SingleOrNull<Claim>(ay_);

							return az_;
						};
					};
					var ar_ = new Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU
					{
						ProcedureItems = aq_(),
					};
					var as_ = new Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU[]
					{
						ar_,
					};
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA at_(Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU HeaderDefinition)
					{
						Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA cj_()
						{
							if ((context.Operators.Not((bool?)(HeaderDefinition?.ProcedureItems is null)) ?? false))
							{
								CqlInterval<CqlDateTime> ck_(Claim.ItemComponent NormalDate)
								{
									var cn_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate?.Serviced);

									return cn_;
								};
								var cl_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((HeaderDefinition?.ProcedureItems?.Item as IEnumerable<Claim.ItemComponent>), ck_);
								var cm_ = new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
								{
									Claim = HeaderDefinition?.ProcedureItems,
									ServicePeriod = cl_,
								};

								return cm_;
							}
							else
							{
								Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA co_ = null;

								return (co_ as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
							};
						};

						return cj_();
					};
					var au_ = context.Operators.SelectOrNull<Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(as_, at_);
					var av_ = context.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(au_);

					return av_;
				};
				var an_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ClaimWithProcedure?.DiagnosisItems, am_);
				bool? ao_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
				{
					var cp_ = context.Operators.Not((bool?)(FinalList is null));

					return cp_;
				};
				var ap_ = context.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(an_, ao_);

				return ap_;
			};
			var o_ = context.Operators.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(m_, n_);
			var p_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(o_);

			return p_;
		};
		var i_ = context.Operators.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);
		var j_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis and Procedure")]
	public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Principal_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(context, claim);
		string b_(CqlCode d) => 
			d?.code;
		var c_ = context.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		string d_(CqlCode p) => 
			p?.code;
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
			Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA k_(Claim ClaimofInterest)
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
								var az_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

								return az_;
							};
							var z_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ItemOnLine?.Item as IEnumerable<Claim.ItemComponent>), y_);
							CodeableConcept aa_(Claim.ItemComponent @this) => 
								@this?.ProductOrService;
							var ab_ = context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(z_, aa_);
							bool? ac_(CodeableConcept @this)
							{
								var ba_ = context.Operators.Not((bool?)(@this?.Coding is null));

								return ba_;
							};
							var ad_ = context.Operators.WhereOrNull<CodeableConcept>(ab_, ac_);
							List<Coding> ae_(CodeableConcept @this) => 
								@this?.Coding;
							var af_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(ad_, ae_);
							var ag_ = context.Operators.FlattenList<Coding>(af_);
							bool? ah_(Coding LineCode)
							{
								var bb_ = context.Operators.InList<string>(LineCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings);

								return bb_;
							};
							var ai_ = context.Operators.WhereOrNull<Coding>(ag_, ah_);
							var aj_ = context.Operators.ExistsInList<Coding>(ai_);
							bool? ak_(Claim.ProcedureComponent @this)
							{
								var bc_ = context.Operators.Not((bool?)(@this?.Procedure is null));

								return bc_;
							};
							var al_ = context.Operators.WhereOrNull<Claim.ProcedureComponent>((ItemOnLine?.Procedure as IEnumerable<Claim.ProcedureComponent>), ak_);
							DataType am_(Claim.ProcedureComponent @this) => 
								@this?.Procedure;
							var an_ = context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(al_, am_);
							bool? ao_(DataType @this)
							{
								var bd_ = context.Operators.LateBoundProperty<object>(@this, "coding");
								var be_ = context.Operators.Not((bool?)(bd_ is null));

								return be_;
							};
							var ap_ = context.Operators.WhereOrNull<DataType>(an_, ao_);
							object aq_(DataType @this)
							{
								var bf_ = context.Operators.LateBoundProperty<object>(@this, "coding");

								return bf_;
							};
							var ar_ = context.Operators.SelectOrNull<DataType, object>(ap_, aq_);
							var as_ = context.Operators.FlattenLateBoundList(ar_);
							Coding at_(object @object) => 
								(@object as Coding);
							var au_ = context.Operators.SelectOrNull<object, Coding>(as_, at_);
							bool? av_(Coding HeaderCode)
							{
								var bg_ = context.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings);

								return bg_;
							};
							var aw_ = context.Operators.WhereOrNull<Coding>(au_, av_);
							var ax_ = context.Operators.ExistsInList<Coding>(aw_);
							var ay_ = context.Operators.Or(aj_, ax_);

							return ay_;
						};
						var w_ = context.Operators.WhereOrNull<Claim>(u_, v_);
						var x_ = context.Operators.SingleOrNull<Claim>(w_);

						return x_;
					};
				};
				var p_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB
				{
					Claim = ClaimofInterest,
					ProcedureItems = o_(),
				};
				var q_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB[]
				{
					p_,
				};
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA r_(Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB DiagnosisCheck)
				{
					var bh_ = new Claim[]
					{
						DiagnosisCheck?.ProcedureItems,
					};
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bi_(Claim ClaimforDiagnosis)
					{
						Claim bl_()
						{
							if ((ClaimforDiagnosis is null))
							{
								return null;
							}
							else
							{
								var br_ = new Claim[]
								{
									ClaimforDiagnosis,
								};
								bool? bs_(Claim RightClaim)
								{
									bool? bv_(Claim.DiagnosisComponent RightDiagnosis)
									{
										var by_ = context.Operators.Convert<Integer>(RightDiagnosis?.SequenceElement);
										var bz_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, by_);
										var ca_ = context.Operators.Equal(bz_, (int?)1);
										var cb_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(RightDiagnosis?.Diagnosis, "coding");
										bool? cc_(Coding DiagnosisCode)
										{
											var cg_ = context.Operators.InList<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithProcedure?.DiagnosesAsStrings);

											return cg_;
										};
										var cd_ = context.Operators.WhereOrNull<Coding>(cb_, cc_);
										var ce_ = context.Operators.ExistsInList<Coding>(cd_);
										var cf_ = context.Operators.And(ca_, ce_);

										return cf_;
									};
									var bw_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), bv_);
									var bx_ = context.Operators.ExistsInList<Claim.DiagnosisComponent>(bw_);

									return bx_;
								};
								var bt_ = context.Operators.WhereOrNull<Claim>(br_, bs_);
								var bu_ = context.Operators.SingleOrNull<Claim>(bt_);

								return bu_;
							};
						};
						var bm_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI
						{
							Procedure = (ClaimforDiagnosis?.Item as IEnumerable<Claim.ItemComponent>),
							LineItems = bl_(),
						};
						var bn_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI[]
						{
							bm_,
						};
						Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA bo_(Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI LineItemDefinition)
						{
							Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ch_()
							{
								if ((context.Operators.And(context.Operators.Not((bool?)(LineItemDefinition is null)), context.Operators.Not((bool?)(LineItemDefinition?.LineItems is null))) ?? false))
								{
									CqlInterval<CqlDateTime> ci_(Claim.ItemComponent NormalDate)
									{
										var cl_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate?.Serviced);

										return cl_;
									};
									var cj_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((LineItemDefinition?.LineItems?.Item as IEnumerable<Claim.ItemComponent>), ci_);
									var ck_ = new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
									{
										Claim = LineItemDefinition?.LineItems,
										ServicePeriod = cj_,
									};

									return ck_;
								}
								else
								{
									Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA cm_ = null;

									return (cm_ as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA);
								};
							};

							return ch_();
						};
						var bp_ = context.Operators.SelectOrNull<Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bn_, bo_);
						var bq_ = context.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bp_);

						return bq_;
					};
					var bj_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bh_, bi_);
					var bk_ = context.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bj_);

					return bk_;
				};
				var s_ = context.Operators.SelectOrNull<Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_, r_);
				var t_ = context.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(s_);

				return t_;
			};
			var l_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ClaimWithProcedure?.MedicalClaim, k_);
			bool? m_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var cn_ = context.Operators.Not((bool?)(FinalList is null));

				return cn_;
			};
			var n_ = context.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(l_, m_);

			return n_;
		};
		var i_ = context.Operators.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);
		var j_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);

		return j_;
	}

    [CqlDeclaration("Medical Claims With Principal Diagnosis")]
	public IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> Medical_Claims_With_Principal_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(context, claim);
		string b_(CqlCode d) => 
			d?.code;
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
							var v_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, u_);
							var w_ = context.Operators.Equal(v_, (int?)1);
							var x_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(RightDiagnosis?.Diagnosis, "coding");
							bool? y_(Coding DiagnosisCode)
							{
								var ac_ = context.Operators.InList<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings);

								return ac_;
							};
							var z_ = context.Operators.WhereOrNull<Coding>(x_, y_);
							var aa_ = context.Operators.ExistsInList<Coding>(z_);
							var ab_ = context.Operators.And(w_, aa_);

							return ab_;
						};
						var s_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), r_);
						var t_ = context.Operators.ExistsInList<Claim.DiagnosisComponent>(s_);

						return t_;
					};
					var q_ = context.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, p_);

					return q_;
				};
			};
			var j_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN
			{
				LineItems = i_(),
			};
			var k_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN[]
			{
				j_,
			};
			IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> l_(Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN LineItemDefinition)
			{
				Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI ad_(Claim ClaimWithDiagnosis)
				{
					Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI ah_()
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
								var ar_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate?.Serviced);

								return ar_;
							};
							var ao_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(am_, an_);
							var ap_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
							{
								Claim = LineItemDefinition?.LineItems,
								ServicePeriod = ao_,
							};

							return ap_;
						}
						else
						{
							Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI as_ = null;

							return (as_ as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI);
						};
					};

					return ah_();
				};
				var ae_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(LineItemDefinition?.LineItems, ad_);
				bool? af_(Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList)
				{
					var at_ = context.Operators.Not((bool?)(FinalList is null));

					return at_;
				};
				var ag_ = context.Operators.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(ae_, af_);

				return ag_;
			};
			var m_ = context.Operators.SelectOrNull<Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(k_, l_);
			var n_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(m_);

			return n_;
		};
		var g_ = context.Operators.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(e_, f_);
		var h_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(g_);

		return h_;
	}

    [CqlDeclaration("Get All Professional and Institutional Claims and Claim Responses")]
	public Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		var a_ = this.Professional_or_Institutional_Claims_Response(context, claimResponse);
		var b_ = this.Professional_or_Institutional_Claims(context, claim);
		var c_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM
		{
			MedicalClaimResponse = a_,
			MedicalClaim = b_,
		};

		return c_;
	}

    [CqlDeclaration("Get All Paid Claim Reponses")]
	public IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> Get_All_Paid_Claim_Reponses(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse ResponseItem)
		{
			var h_ = context.Operators.Convert<string>(ResponseItem?.OutcomeElement);
			var i_ = new string[]
			{
				"complete",
				"partial",
			};
			var j_ = context.Operators.InList<string>(h_, (i_ as IEnumerable<string>));

			return j_;
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
			Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL k_(ClaimResponse ClmResp)
			{
				var m_ = context.Operators.Convert<string>(ClmResp?.Request?.ReferenceElement);
				var n_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, m_);
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
					var ac_ = context.Operators.ExistsInList<Coding>(ab_);
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
						var ap_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, DollarAmount?.ValueElement);
						var aq_ = context.Operators.ConvertIntegerToDecimal((int?)0);
						var ar_ = context.Operators.Greater(ap_, aq_);

						return ar_;
					};
					var ai_ = context.Operators.WhereOrNull<Money>(ag_, ah_);
					var aj_ = context.Operators.ExistsInList<Money>(ai_);
					var ak_ = context.Operators.And(ac_, aj_);

					return ak_;
				};
				var p_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>((ClmResp?.Item as IEnumerable<ClaimResponse.ItemComponent>), o_);
				var q_ = new Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL
				{
					Response = ClmResp,
					ResponseID = n_,
					LineItems = p_,
				};

				return q_;
			};
			var l_ = context.Operators.SelectOrNull<ClaimResponse, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimResponse?.PaidResponse, k_);

			return l_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD, IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(d_, e_);
		var g_ = context.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(f_);

		return g_;
	}

    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
	public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_and_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			bool? e_(Claim.ItemComponent @this)
			{
				var af_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

				return af_;
			};
			var f_ = context.Operators.WhereOrNull<Claim.ItemComponent>(AllClaims?.Item, e_);
			CodeableConcept g_(Claim.ItemComponent @this) => 
				@this?.ProductOrService;
			var h_ = context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(f_, g_);
			bool? i_(CodeableConcept @this)
			{
				var ag_ = context.Operators.Not((bool?)(@this?.Coding is null));

				return ag_;
			};
			var j_ = context.Operators.WhereOrNull<CodeableConcept>(h_, i_);
			List<Coding> k_(CodeableConcept @this) => 
				@this?.Coding;
			var l_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(j_, k_);
			var m_ = context.Operators.FlattenList<Coding>(l_);
			bool? n_(Coding ProductOrServiceCode)
			{
				var ah_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
				var ai_ = context.Operators.CodeInList(ah_, ProductOrServiceValueSet);

				return ai_;
			};
			var o_ = context.Operators.WhereOrNull<Coding>(m_, n_);
			var p_ = context.Operators.ExistsInList<Coding>(o_);
			bool? q_(Claim.DiagnosisComponent @this)
			{
				var aj_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

				return aj_;
			};
			var r_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((AllClaims?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), q_);
			DataType s_(Claim.DiagnosisComponent @this) => 
				@this?.Diagnosis;
			var t_ = context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(r_, s_);
			bool? u_(DataType @this)
			{
				var ak_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				var al_ = context.Operators.Not((bool?)(ak_ is null));

				return al_;
			};
			var v_ = context.Operators.WhereOrNull<DataType>(t_, u_);
			object w_(DataType @this)
			{
				var am_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return am_;
			};
			var x_ = context.Operators.SelectOrNull<DataType, object>(v_, w_);
			var y_ = context.Operators.FlattenLateBoundList(x_);
			Coding z_(object @object) => 
				(@object as Coding);
			var aa_ = context.Operators.SelectOrNull<object, Coding>(y_, z_);
			bool? ab_(Coding DiagnosisCode)
			{
				var an_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
				var ao_ = context.Operators.CodeInList(an_, DiagnosisValueSet);

				return ao_;
			};
			var ac_ = context.Operators.WhereOrNull<Coding>(aa_, ab_);
			var ad_ = context.Operators.ExistsInList<Coding>(ac_);
			var ae_ = context.Operators.And(p_, ad_);

			return ae_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);
		Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM c_(Claim ProcedureClaims)
		{
			bool? ap_(Claim.ItemComponent ResponseItem)
			{
				bool? as_(Coding ProductOrServiceCode)
				{
					var av_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
					var aw_ = context.Operators.CodeInList(av_, ProductOrServiceValueSet);

					return aw_;
				};
				var at_ = context.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), as_);
				var au_ = context.Operators.ExistsInList<Coding>(at_);

				return au_;
			};
			var aq_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), ap_);
			var ar_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = ProcedureClaims,
				ClaimID = ProcedureClaims?.IdElement,
				LineItems = aq_,
			};

			return ar_;
		};
		var d_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services and Conditions")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_and_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
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
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg h_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				bool? o_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> r_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						bool? u_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var y_ = context.Operators.Convert<string>(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: null));
							var z_ = context.Operators.Convert<string>(pClaim?.Response?.Request?.ReferenceElement);
							var aa_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, z_);
							var ab_ = context.Operators.Equal(y_, aa_);
							var ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							var ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							var ae_ = context.Operators.Equal(ac_, ad_);
							var af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						var v_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var x_ = context.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_, w_);

						return x_;
					};
					var s_ = context.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimAndResponse?.PaidMedicalClaimResponse, r_);
					var t_ = context.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(s_);

					return t_;
				};
				var p_ = context.Operators.WhereOrNull<Claim.ItemComponent>(medClaim?.LineItems, o_);
				var q_ = new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			var i_ = context.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimAndResponse?.MedicalClaim, h_);
			var j_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = i_,
			};
			var k_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				j_,
			};
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO l_(Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO ag_()
				{
					if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
											context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
										@this?.ClaimItem))) ?? false))
					{
						bool? al_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var ax_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return ax_;
						};
						var am_ = context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, al_);
						Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM an_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.PaidClaim;
						var ao_ = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(am_, an_);
						bool? ap_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var ay_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return ay_;
						};
						var aq_ = context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, ap_);
						IEnumerable<Claim.ItemComponent> ar_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						var as_ = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(aq_, ar_);
						var at_ = context.Operators.FlattenList<Claim.ItemComponent>(as_);
						CqlInterval<CqlDateTime> au_(Claim.ItemComponent PaidItem)
						{
							var az_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, PaidItem?.Serviced);

							return az_;
						};
						var av_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(at_, au_);
						var aw_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = ao_,
							ServicePeriod = av_,
						};

						return aw_;
					}
					else
					{
						Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO ba_ = null;

						return (ba_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
					};
				};
				var ah_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ag_(),
				};
				bool? ai_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bb_ = context.Operators.Not((bool?)(FinalList is null));

					return bb_;
				};
				var aj_ = context.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ah_, ai_);
				var ak_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_);

				return ak_;
			};
			var m_ = context.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(k_, l_);
			var n_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(m_);

			return n_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var g_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Service and Condition")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Service_and_Condition(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
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
					var l_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(context, MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet);

					return l_;
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
			var m_ = context.Operators.Not((bool?)(FinalList is null));

			return m_;
		};
		var h_ = context.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_, g_);
		var i_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(h_);

		return i_;
	}

    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
	public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_or_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			bool? e_(Claim.ItemComponent @this)
			{
				var af_ = context.Operators.Not((bool?)(@this?.ProductOrService is null));

				return af_;
			};
			var f_ = context.Operators.WhereOrNull<Claim.ItemComponent>(AllClaims?.Item, e_);
			CodeableConcept g_(Claim.ItemComponent @this) => 
				@this?.ProductOrService;
			var h_ = context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(f_, g_);
			bool? i_(CodeableConcept @this)
			{
				var ag_ = context.Operators.Not((bool?)(@this?.Coding is null));

				return ag_;
			};
			var j_ = context.Operators.WhereOrNull<CodeableConcept>(h_, i_);
			List<Coding> k_(CodeableConcept @this) => 
				@this?.Coding;
			var l_ = context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(j_, k_);
			var m_ = context.Operators.FlattenList<Coding>(l_);
			bool? n_(Coding ProductOrServiceCode)
			{
				var ah_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
				var ai_ = context.Operators.CodeInList(ah_, ProductOrServiceValueSet);

				return ai_;
			};
			var o_ = context.Operators.WhereOrNull<Coding>(m_, n_);
			var p_ = context.Operators.ExistsInList<Coding>(o_);
			bool? q_(Claim.DiagnosisComponent @this)
			{
				var aj_ = context.Operators.Not((bool?)(@this?.Diagnosis is null));

				return aj_;
			};
			var r_ = context.Operators.WhereOrNull<Claim.DiagnosisComponent>((AllClaims?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), q_);
			DataType s_(Claim.DiagnosisComponent @this) => 
				@this?.Diagnosis;
			var t_ = context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(r_, s_);
			bool? u_(DataType @this)
			{
				var ak_ = context.Operators.LateBoundProperty<object>(@this, "coding");
				var al_ = context.Operators.Not((bool?)(ak_ is null));

				return al_;
			};
			var v_ = context.Operators.WhereOrNull<DataType>(t_, u_);
			object w_(DataType @this)
			{
				var am_ = context.Operators.LateBoundProperty<object>(@this, "coding");

				return am_;
			};
			var x_ = context.Operators.SelectOrNull<DataType, object>(v_, w_);
			var y_ = context.Operators.FlattenLateBoundList(x_);
			Coding z_(object @object) => 
				(@object as Coding);
			var aa_ = context.Operators.SelectOrNull<object, Coding>(y_, z_);
			bool? ab_(Coding DiagnosisCode)
			{
				var an_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
				var ao_ = context.Operators.CodeInList(an_, DiagnosisValueSet);

				return ao_;
			};
			var ac_ = context.Operators.WhereOrNull<Coding>(aa_, ab_);
			var ad_ = context.Operators.ExistsInList<Coding>(ac_);
			var ae_ = context.Operators.Or(p_, ad_);

			return ae_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);
		Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM c_(Claim ProcedureClaims)
		{
			Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM ap_()
			{
				if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => 
								context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), (Coding ProductOrServiceCode) => 
											context.Operators.CodeInList(FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode), ProductOrServiceValueSet))))) ?? false))
				{
					bool? aq_(Claim.ItemComponent ResponseItem)
					{
						bool? at_(Coding ProductOrServiceCode)
						{
							var aw_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
							var ax_ = context.Operators.CodeInList(aw_, ProductOrServiceValueSet);

							return ax_;
						};
						var au_ = context.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), at_);
						var av_ = context.Operators.ExistsInList<Coding>(au_);

						return av_;
					};
					var ar_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), aq_);
					var as_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
					{
						ClaimofInterest = ProcedureClaims,
						ClaimID = ProcedureClaims?.IdElement,
						LineItems = ar_,
					};

					return as_;
				}
				else
				{
					bool? ay_(Claim.ItemComponent ResponseItem)
					{
						var bb_ = context.Operators.Convert<Integer>(ResponseItem?.SequenceElement);
						var bc_ = context.Operators.Equal(bb_?.Value, (int?)1);

						return bc_;
					};
					var az_ = context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), ay_);
					var ba_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
					{
						ClaimofInterest = ProcedureClaims,
						ClaimID = ProcedureClaims?.IdElement,
						LineItems = az_,
					};

					return ba_;
				};
			};

			return ap_();
		};
		var d_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services or Conditions")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
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
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg h_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				bool? o_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> r_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						bool? u_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var y_ = context.Operators.Convert<string>(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: null));
							var z_ = context.Operators.Convert<string>(pClaim?.Response?.Request?.ReferenceElement);
							var aa_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, z_);
							var ab_ = context.Operators.Equal(y_, aa_);
							var ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							var ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							var ae_ = context.Operators.Equal(ac_, ad_);
							var af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						var v_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var x_ = context.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_, w_);

						return x_;
					};
					var s_ = context.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimAndResponse?.PaidMedicalClaimResponse, r_);
					var t_ = context.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(s_);

					return t_;
				};
				var p_ = context.Operators.WhereOrNull<Claim.ItemComponent>(medClaim?.LineItems, o_);
				var q_ = new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			var i_ = context.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimAndResponse?.MedicalClaim, h_);
			var j_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = i_,
			};
			var k_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				j_,
			};
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO l_(Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO ag_()
				{
					if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
											context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
										@this?.ClaimItem))) ?? false))
					{
						bool? al_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var ax_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return ax_;
						};
						var am_ = context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, al_);
						Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM an_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.PaidClaim;
						var ao_ = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(am_, an_);
						bool? ap_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var ay_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return ay_;
						};
						var aq_ = context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, ap_);
						IEnumerable<Claim.ItemComponent> ar_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						var as_ = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(aq_, ar_);
						var at_ = context.Operators.FlattenList<Claim.ItemComponent>(as_);
						CqlInterval<CqlDateTime> au_(Claim.ItemComponent PaidItem)
						{
							var az_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, PaidItem?.Serviced);

							return az_;
						};
						var av_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(at_, au_);
						var aw_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = ao_,
							ServicePeriod = av_,
						};

						return aw_;
					}
					else
					{
						Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO ba_ = null;

						return (ba_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
					};
				};
				var ah_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ag_(),
				};
				bool? ai_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bb_ = context.Operators.Not((bool?)(FinalList is null));

					return bb_;
				};
				var aj_ = context.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ah_, ai_);
				var ak_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_);

				return ak_;
			};
			var m_ = context.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(k_, l_);
			var n_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(m_);

			return n_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var g_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services or Conditions")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
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
					var h_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(context, MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet);

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		var e_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);

		return e_;
	}

    [CqlDeclaration("Get All Claims With Procedure Only")]
	public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_Only(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
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
				var s_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
				var t_ = context.Operators.CodeInList(s_, ProductOrServiceValueSet);

				return t_;
			};
			var o_ = context.Operators.WhereOrNull<Coding>(m_, n_);
			var p_ = context.Operators.ExistsInList<Coding>(o_);

			return p_;
		};
		var b_ = context.Operators.WhereOrNull<Claim>(claim, a_);
		Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM c_(Claim AllClaims)
		{
			bool? u_(Claim.ItemComponent ResponseItem)
			{
				bool? x_(Coding ProductOrServiceCode)
				{
					var aa_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
					var ab_ = context.Operators.CodeInList(aa_, ProductOrServiceValueSet);

					return ab_;
				};
				var y_ = context.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), x_);
				var z_ = context.Operators.ExistsInList<Coding>(y_);

				return z_;
			};
			var v_ = context.Operators.WhereOrNull<Claim.ItemComponent>((AllClaims?.Item as IEnumerable<Claim.ItemComponent>), u_);
			var w_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = AllClaims,
				ClaimID = AllClaims?.IdElement,
				LineItems = v_,
			};

			return w_;
		};
		var d_ = context.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Get Corresponding Claim for Services Only")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
		var b_ = this.Get_All_Claims_With_Procedure_Only(context, claim, ProductOrServiceValueSet);
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
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg h_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				bool? o_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> r_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						bool? u_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var y_ = context.Operators.Convert<string>(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: null));
							var z_ = context.Operators.Convert<string>(pClaim?.Response?.Request?.ReferenceElement);
							var aa_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, z_);
							var ab_ = context.Operators.Equal(y_, aa_);
							var ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							var ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							var ae_ = context.Operators.Equal(ac_, ad_);
							var af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						var v_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var x_ = context.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_, w_);

						return x_;
					};
					var s_ = context.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimAndResponse?.PaidMedicalClaimResponse, r_);
					var t_ = context.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(s_);

					return t_;
				};
				var p_ = context.Operators.WhereOrNull<Claim.ItemComponent>(medClaim?.LineItems, o_);
				var q_ = new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			var i_ = context.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimAndResponse?.MedicalClaim, h_);
			var j_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = i_,
			};
			var k_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				j_,
			};
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO l_(Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO ag_()
				{
					if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
											context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
										@this?.ClaimItem))) ?? false))
					{
						bool? al_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var ax_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return ax_;
						};
						var am_ = context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, al_);
						Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM an_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.PaidClaim;
						var ao_ = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(am_, an_);
						bool? ap_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this)
						{
							var ay_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return ay_;
						};
						var aq_ = context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, ap_);
						IEnumerable<Claim.ItemComponent> ar_(Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => 
							@this?.ClaimItem;
						var as_ = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(aq_, ar_);
						var at_ = context.Operators.FlattenList<Claim.ItemComponent>(as_);
						CqlInterval<CqlDateTime> au_(Claim.ItemComponent PaidItem)
						{
							var az_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, PaidItem?.Serviced);

							return az_;
						};
						var av_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(at_, au_);
						var aw_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = ao_,
							ServicePeriod = av_,
						};

						return aw_;
					}
					else
					{
						Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO ba_ = null;

						return (ba_ as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO);
					};
				};
				var ah_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ag_(),
				};
				bool? ai_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bb_ = context.Operators.Not((bool?)(FinalList is null));

					return bb_;
				};
				var aj_ = context.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ah_, ai_);
				var ak_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_);

				return ak_;
			};
			var m_ = context.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(k_, l_);
			var n_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(m_);

			return n_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var g_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Provided Services Only")]
	public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
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
					var h_ = this.Get_Corresponding_Claim_for_Services_Only(context, MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet);

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		var e_ = context.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);

		return e_;
	}

    [CqlDeclaration("Get All Pharmacy Claims and Claim Responses")]
	public Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR Get_All_Pharmacy_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		var a_ = this.Pharmacy_Claims_Response(context, claimResponse);
		var b_ = this.Pharmacy_Claims(context, claim);
		var c_ = new Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR
		{
			PharmacyClaimResponse = a_,
			PharmacyClaim = b_,
		};

		return c_;
	}

    [CqlDeclaration("Get Corresponding Claim for Pharmacy Services")]
	public Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO Get_Corresponding_Claim_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
		var b_ = this.Pharmacy_Claim_With_Medication(context, claim, ProductOrServiceValueSet);
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
			Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT h_(Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC medClaim)
			{
				bool? o_(Claim.ItemComponent medClaimLineItem)
				{
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> r_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						bool? u_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var y_ = context.Operators.Convert<string>(((medClaim?.Claim is Resource)
									? ((medClaim?.Claim as Resource).IdElement)
									: null));
							var z_ = context.Operators.Convert<string>(pClaim?.Response?.Request?.ReferenceElement);
							var aa_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, z_);
							var ab_ = context.Operators.Equal(y_, aa_);
							var ac_ = context.Operators.Convert<Integer>(medClaimLineItem?.SequenceElement);
							var ad_ = context.Operators.Convert<Integer>(pClaimLineItem?.ItemSequenceElement);
							var ae_ = context.Operators.Equal(ac_, ad_);
							var af_ = context.Operators.And(ab_, ae_);

							return af_;
						};
						var v_ = context.Operators.WhereOrNull<ClaimResponse.ItemComponent>(pClaim?.LineItems, u_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL w_(ClaimResponse.ItemComponent pClaimLineItem) => 
							pClaim;
						var x_ = context.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_, w_);

						return x_;
					};
					var s_ = context.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ClaimAndResponse?.PaidPharmacyClaimResponse, r_);
					var t_ = context.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(s_);

					return t_;
				};
				var p_ = context.Operators.WhereOrNull<Claim.ItemComponent>(medClaim?.LineItem, o_);
				var q_ = new Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT
				{
					PaidClaim = medClaim,
					ClaimItem = p_,
				};

				return q_;
			};
			var i_ = context.Operators.SelectOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC, Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimAndResponse?.MedicalClaim, h_);
			var j_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB
			{
				AggregateClaim = i_,
			};
			var k_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB[]
			{
				j_,
			};
			Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO l_(Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB ClaimWithPaidResponse)
			{
				Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO ag_()
				{
					if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => 
											context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => 
										@this?.ClaimItem))) ?? false))
					{
						bool? al_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var be_ = context.Operators.Not((bool?)(@this?.PaidClaim is null));

							return be_;
						};
						var am_ = context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, al_);
						Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC an_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => 
							@this?.PaidClaim;
						var ao_ = context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(am_, an_);
						bool? ap_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var bf_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bf_;
						};
						var aq_ = context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, ap_);
						IEnumerable<Claim.ItemComponent> ar_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => 
							@this?.ClaimItem;
						var as_ = context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(aq_, ar_);
						var at_ = context.Operators.FlattenList<Claim.ItemComponent>(as_);
						CqlInterval<CqlDateTime> au_(Claim.ItemComponent PaidItem)
						{
							var bg_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, PaidItem?.Serviced);

							return bg_;
						};
						var av_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(at_, au_);
						bool? aw_(Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this)
						{
							var bh_ = context.Operators.Not((bool?)(@this?.ClaimItem is null));

							return bh_;
						};
						var ax_ = context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, aw_);
						var az_ = context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(ax_, ar_);
						var ba_ = context.Operators.FlattenList<Claim.ItemComponent>(az_);
						CqlInterval<CqlDate> bb_(Claim.ItemComponent i)
						{
							CqlInterval<CqlDate> bi_()
							{
								if ((context.Operators.Not((bool?)(i?.Quantity is null)) ?? false))
								{
									var bj_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, i?.Serviced);
									var bk_ = context.Operators.Start(bj_);
									var bl_ = context.Operators.ConvertDateTimeToDate(bk_);
									var bn_ = context.Operators.Start(bj_);
									var bo_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, i?.Quantity?.ValueElement);
									var bp_ = context.Operators.Add(bn_, new CqlQuantity(bo_, "day"));
									var bq_ = context.Operators.Quantity(1m, "day");
									var br_ = context.Operators.Subtract(bp_, bq_);
									var bs_ = context.Operators.ConvertDateTimeToDate(br_);
									var bt_ = context.Operators.Interval(bl_, bs_, true, true);

									return bt_;
								}
								else
								{
									CqlInterval<CqlDate> bu_ = null;

									return (bu_ as CqlInterval<CqlDate>);
								};
							};

							return bi_();
						};
						var bc_ = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDate>>(ba_, bb_);
						var bd_ = new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO
						{
							originalClaim = ao_,
							ServicePeriod = av_,
							CoveredDays = bc_,
						};

						return bd_;
					}
					else
					{
						Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO bv_ = null;

						return (bv_ as Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO);
					};
				};
				var ah_ = new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO[]
				{
					ag_(),
				};
				bool? ai_(Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO FinalList)
				{
					var bw_ = context.Operators.Not((bool?)(FinalList is null));

					return bw_;
				};
				var aj_ = context.Operators.WhereOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(ah_, ai_);
				var ak_ = context.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(aj_);

				return ak_;
			};
			var m_ = context.Operators.SelectOrNull<Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(k_, l_);
			var n_ = context.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(m_);

			return n_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(d_, e_);
		var g_ = context.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(f_);

		return g_;
	}

    [CqlDeclaration("Get Paid Claims for Pharmacy Services")]
	public Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO Get_Paid_Claims_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(context, claimResponse, claim);
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
					var h_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(context, PharmacyClaimAndResponse?.PharmacyClaimResponse, PharmacyClaimAndResponse?.PharmacyClaim, ProductOrServiceValueSet);

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(b_, c_);
		var e_ = context.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(d_);

		return e_;
	}

    [CqlDeclaration("Get Claim With Corresponding Claim Response")]
	public IEnumerable<Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI> Get_Claim_With_Corresponding_Claim_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI a_(Claim Claim)
		{
			bool? c_(ClaimResponse CR)
			{
				var h_ = context.Operators.Convert<string>(Claim?.IdElement);
				var i_ = context.Operators.Convert<string>(CR?.Request?.ReferenceElement);
				var j_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, i_);
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
					var ac_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ab_);
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
				var w_ = context.Operators.SingleOrNull<FhirString>(v_);
				var x_ = context.Operators.Convert<string>(w_);
				var y_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, x_);
				var z_ = context.Operators.Equal(l_, y_);

				return z_;
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
	public Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(CqlContext context, IEnumerable<Claim> claim)
	{
		var a_ = this.Professional_or_Institutional_Claims(context, claim);
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
					bool? o_(Claim c)
					{
						bool? q_(Claim.ItemComponent i)
						{
							var t_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, i?.Revenue);
							bool? u_(CqlCode rev)
							{
								var x_ = this.Inpatient_Stay(context);
								var y_ = context.Operators.StringInValueSet(rev?.code, x_);

								return y_;
							};
							var v_ = context.Operators.WhereOrNull<CqlCode>((t_?.codes as IEnumerable<CqlCode>), u_);
							var w_ = context.Operators.ExistsInList<CqlCode>(v_);

							return w_;
						};
						var r_ = context.Operators.WhereOrNull<Claim.ItemComponent>((c?.Item as IEnumerable<Claim.ItemComponent>), q_);
						var s_ = context.Operators.ExistsInList<Claim.ItemComponent>(r_);

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
							var aj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, i?.Revenue);
							bool? ak_(CqlCode rev)
							{
								var an_ = this.Nonacute_Inpatient_Stay(context);
								var ao_ = context.Operators.StringInValueSet(rev?.code, an_);

								return ao_;
							};
							var al_ = context.Operators.WhereOrNull<CqlCode>((aj_?.codes as IEnumerable<CqlCode>), ak_);
							var am_ = context.Operators.ExistsInList<CqlCode>(al_);

							return am_;
						};
						var ad_ = context.Operators.WhereOrNull<Claim.ItemComponent>((c?.Item as IEnumerable<Claim.ItemComponent>), ac_);
						var ae_ = context.Operators.ExistsInList<Claim.ItemComponent>(ad_);
						bool? af_(Coding tob)
						{
							var ap_ = this.Nonacute_Inpatient_Stay(context);
							var aq_ = context.Operators.StringInValueSet(tob?.CodeElement?.Value, ap_);

							return aq_;
						};
						var ag_ = context.Operators.WhereOrNull<Coding>((c?.SubType?.Coding as IEnumerable<Coding>), af_);
						var ah_ = context.Operators.ExistsInList<Coding>(ag_);
						var ai_ = context.Operators.Or(ae_, ah_);

						return ai_;
					};
					var ab_ = context.Operators.WhereOrNull<Claim>(ClaimWithInpatientStay?.MedicalClaim, aa_);

					return ab_;
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
				var aw_ = new Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE
				{
					InpatientDischarge = LineItemDefinition?.InpatientStayLineItems,
					NonacuteInpatientDischarge = as_,
					AcuteInpatientDischarge = av_,
				};

				return aw_;
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
	public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Prescriber_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
	{
		Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS a_(Claim C)
		{
			bool? h_(Claim.CareTeamComponent ct)
			{
				var w_ = context.Operators.Convert<Integer>(ct?.SequenceElement);
				var x_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, w_);
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
				var ab_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, aa_);
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
					var aj_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ai_);

					return aj_;
				};
				var ag_ = context.Operators.SelectOrNull<FhirString, string>(ae_, af_);
				var ah_ = context.Operators.SingleOrNull<string>(ag_);

				return ah_;
			};
			var u_ = context.Operators.SelectOrNull<ResourceReference, string>(s_, t_);
			var v_ = new Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS
			{
				SingleCareTeam = C,
				CareTeamsProvider = m_,
				CareTeamsProviderID = u_,
			};

			return v_;
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
			var ak_ = context.Operators.RetrieveByValueSet<Practitioner>(null, null);
			bool? al_(Practitioner p)
			{
				var as_ = context.Operators.Convert<string>(p?.IdElement);
				bool? at_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
				{
					var az_ = context.Operators.Not((bool?)(@this?.CareTeamsProviderID is null));

					return az_;
				};
				var au_ = context.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, at_);
				IEnumerable<string> av_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => 
					@this?.CareTeamsProviderID;
				var aw_ = context.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, IEnumerable<string>>(au_, av_);
				var ax_ = context.Operators.FlattenList<string>(aw_);
				var ay_ = context.Operators.InList<string>(as_, ax_);

				return ay_;
			};
			var am_ = context.Operators.WhereOrNull<Practitioner>(ak_, al_);
			var an_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe
			{
				Practitioners = am_,
			};
			var ao_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe[]
			{
				an_,
			};
			Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY ap_(Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe PractitionerMatch)
			{
				bool? ba_(Practitioner P)
				{
					var bj_ = context.Operators.Not((bool?)(P is null));

					return bj_;
				};
				var bb_ = context.Operators.WhereOrNull<Practitioner>(PractitionerMatch?.Practitioners, ba_);
				Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR bc_(Practitioner P)
				{
					bool? bk_(Identifier l)
					{
						var bt_ = context.Operators.Equal(l?.SystemElement?.Value, "http://hl7.org/fhir/sid/us-npi");
						var bu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, l?.Type);
						var bv_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
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
						var cc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, l?.Type);
						var cd_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
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
					var bs_ = new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = bn_,
						NullIdentifiers = br_,
					};

					return bs_;
				};
				var bd_ = context.Operators.SelectOrNull<Practitioner, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(bb_, bc_);
				var be_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = bd_,
				};
				var bf_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					be_,
				};
				Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY bg_(Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers)
				{
					int? ci_()
					{
						if ((context.Operators.ExistsInList<Claim>(context.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => 
											context.Operators.Not((bool?)(@this?.SingleCareTeam is null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => 
										@this?.SingleCareTeam)) ?? false))
						{
							bool? ck_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
							{
								var dd_ = context.Operators.Not((bool?)(@this?.SingleCareTeam is null));

								return dd_;
							};
							var cl_ = context.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, ck_);
							Claim cm_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => 
								@this?.SingleCareTeam;
							var cn_ = context.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(cl_, cm_);
							bool? co_(Claim X) => 
								(bool?)((X?.CareTeam as IEnumerable<Claim.CareTeamComponent>) is null);
							var cp_ = context.Operators.WhereOrNull<Claim>(cn_, co_);
							var cq_ = context.Operators.CountOrNull<Claim>(cp_);
							IEnumerable<FhirString> cr_(Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => 
								X?.AllIdentifiers;
							var cs_ = context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, cr_);
							var ct_ = context.Operators.FlattenList<FhirString>(cs_);
							FhirString cu_(FhirString X) => 
								X;
							var cv_ = context.Operators.SelectOrNull<FhirString, FhirString>(ct_, cu_);
							var cw_ = context.Operators.CountOrNull<FhirString>(cv_);
							var cx_ = context.Operators.Add(cq_, cw_);
							IEnumerable<Identifier> cy_(Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => 
								X?.NullIdentifiers;
							var cz_ = context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, cy_);
							var da_ = context.Operators.FlattenList<Identifier>(cz_);
							var db_ = context.Operators.CountOrNull<Identifier>(da_);
							var dc_ = context.Operators.Add(cx_, db_);

							return dc_;
						}
						else
						{
							return (int?)0;
						};
					};
					var cj_ = new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = ci_(),
					};

					return cj_;
				};
				var bh_ = context.Operators.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bf_, bg_);
				var bi_ = context.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bh_);

				return bi_;
			};
			var aq_ = context.Operators.SelectOrNull<Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ao_, ap_);
			var ar_ = context.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(aq_);

			return ar_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(d_, e_);
		var g_ = context.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(f_);

		return g_;
	}

    [CqlDeclaration("Get Pharmacy NPI from Claims")]
	public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Pharmacy_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
	{
		Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI a_(Claim C)
		{
			bool? h_(Claim.ItemComponent i)
			{
				var y_ = context.Operators.Convert<Integer>(i?.SequenceElement);
				var z_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, y_);
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
				var ad_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ac_);
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
					var al_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ak_);

					return al_;
				};
				var ai_ = context.Operators.SelectOrNull<FhirString, string>(ag_, ah_);
				var aj_ = context.Operators.SingleOrNull<string>(ai_);

				return aj_;
			};
			var w_ = context.Operators.SelectOrNull<DataType, string>(u_, v_);
			var x_ = new Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI
			{
				SingleItem = (C?.Item as IEnumerable<Claim.ItemComponent>),
				ItemLocation = o_,
				ItemLocationID = w_,
			};

			return x_;
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
			var am_ = context.Operators.RetrieveByValueSet<Location>(null, null);
			bool? an_(Location l)
			{
				var au_ = context.Operators.Convert<string>(l?.IdElement);
				bool? av_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
				{
					var bb_ = context.Operators.Not((bool?)(@this?.ItemLocationID is null));

					return bb_;
				};
				var aw_ = context.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, av_);
				IEnumerable<string> ax_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => 
					@this?.ItemLocationID;
				var ay_ = context.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<string>>(aw_, ax_);
				var az_ = context.Operators.FlattenList<string>(ay_);
				var ba_ = context.Operators.InList<string>(au_, az_);

				return ba_;
			};
			var ao_ = context.Operators.WhereOrNull<Location>(am_, an_);
			var ap_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP
			{
				CorrespondingLocations = ao_,
			};
			var aq_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP[]
			{
				ap_,
			};
			Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY ar_(Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP GetLocation)
			{
				bool? bc_(Location C)
				{
					var bl_ = context.Operators.Not((bool?)(C is null));

					return bl_;
				};
				var bd_ = context.Operators.WhereOrNull<Location>(GetLocation?.CorrespondingLocations, bc_);
				Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR be_(Location C)
				{
					bool? bm_(Identifier l)
					{
						var bv_ = context.Operators.Equal(l?.SystemElement?.Value, "http://hl7.org/fhir/sid/us-npi");
						var bw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, l?.Type);
						var bx_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
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
						var ce_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, l?.Type);
						var cf_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
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
					var bu_ = new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = bp_,
						NullIdentifiers = bt_,
					};

					return bu_;
				};
				var bf_ = context.Operators.SelectOrNull<Location, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(bd_, be_);
				var bg_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = bf_,
				};
				var bh_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					bg_,
				};
				Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY bi_(Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers)
				{
					int? ck_()
					{
						if ((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => 
												context.Operators.Not((bool?)(@this?.SingleItem is null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => 
											@this?.SingleItem))) ?? false))
						{
							bool? cm_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
							{
								var dg_ = context.Operators.Not((bool?)(@this?.ItemLocation is null));

								return dg_;
							};
							var cn_ = context.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, cm_);
							IEnumerable<ResourceReference> co_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => 
								@this?.ItemLocation;
							var cp_ = context.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<ResourceReference>>(cn_, co_);
							var cq_ = context.Operators.FlattenList<ResourceReference>(cp_);
							bool? cr_(ResourceReference X) => 
								(bool?)(X?.ReferenceElement?.Value is null);
							var cs_ = context.Operators.WhereOrNull<ResourceReference>(cq_, cr_);
							var ct_ = context.Operators.CountOrNull<ResourceReference>(cs_);
							IEnumerable<FhirString> cu_(Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => 
								X?.AllIdentifiers;
							var cv_ = context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, cu_);
							var cw_ = context.Operators.FlattenList<FhirString>(cv_);
							FhirString cx_(FhirString X) => 
								X;
							var cy_ = context.Operators.SelectOrNull<FhirString, FhirString>(cw_, cx_);
							var cz_ = context.Operators.CountOrNull<FhirString>(cy_);
							var da_ = context.Operators.Add(ct_, cz_);
							IEnumerable<Identifier> db_(Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => 
								X?.NullIdentifiers;
							var dc_ = context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, db_);
							var dd_ = context.Operators.FlattenList<Identifier>(dc_);
							var de_ = context.Operators.CountOrNull<Identifier>(dd_);
							var df_ = context.Operators.Add(da_, de_);

							return df_;
						}
						else
						{
							return (int?)0;
						};
					};
					var cl_ = new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = ck_(),
					};

					return cl_;
				};
				var bj_ = context.Operators.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bh_, bi_);
				var bk_ = context.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bj_);

				return bk_;
			};
			var as_ = context.Operators.SelectOrNull<Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(aq_, ar_);
			var at_ = context.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(as_);

			return at_;
		};
		var f_ = context.Operators.SelectOrNull<Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(d_, e_);
		var g_ = context.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(f_);

		return g_;
	}

}
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
    public CqlValueSet Inpatient_Stay() => __Inpatient_Stay.Value;

    private CqlValueSet Nonacute_Inpatient_Stay_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398", null);

    [CqlDeclaration("Nonacute Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398")]
    public CqlValueSet Nonacute_Inpatient_Stay() => __Nonacute_Inpatient_Stay.Value;

    [CqlDeclaration("Professional or Institutional Claims")]
    public IEnumerable<Claim> Professional_or_Institutional_Claims(IEnumerable<Claim> claim)
	{
		bool? a_(Claim MedicalClaim)
		{
			var d_ = MedicalClaim.Type;
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var f_ = e_.codes;
			var g_ = NCQATerminology_1_0_0.Professional();
			var h_ = context.Operators;
			var i_ = h_.ListContains<CqlCode>((f_ as IEnumerable<CqlCode>), g_);
			var k_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var l_ = k_.codes;
			var m_ = NCQATerminology_1_0_0.Institutional();
			var o_ = h_.ListContains<CqlCode>((l_ as IEnumerable<CqlCode>), m_);
			var q_ = h_.Or(i_, o_);

			return q_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Claim>(claim, a_);

		return c_;
	}


    [CqlDeclaration("Pharmacy Claims")]
    public IEnumerable<Claim> Pharmacy_Claims(IEnumerable<Claim> claim)
	{
		bool? a_(Claim PharmacyClaim)
		{
			var d_ = PharmacyClaim.Type;
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var f_ = e_.codes;
			var g_ = NCQATerminology_1_0_0.Pharmacy();
			var h_ = context.Operators;
			var i_ = h_.ListContains<CqlCode>((f_ as IEnumerable<CqlCode>), g_);

			return i_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Claim>(claim, a_);

		return c_;
	}


    [CqlDeclaration("Professional or Institutional Claims Response")]
    public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse MedicalResponse)
		{
			var d_ = MedicalResponse.Type;
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var f_ = e_.codes;
			var g_ = NCQATerminology_1_0_0.Professional();
			var h_ = context.Operators;
			var i_ = h_.ListContains<CqlCode>((f_ as IEnumerable<CqlCode>), g_);
			var k_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var l_ = k_.codes;
			var m_ = NCQATerminology_1_0_0.Institutional();
			var o_ = h_.ListContains<CqlCode>((l_ as IEnumerable<CqlCode>), m_);
			var q_ = h_.Or(i_, o_);

			return q_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<ClaimResponse>(claimResponse, a_);

		return c_;
	}


    [CqlDeclaration("Pharmacy Claims Response")]
    public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		bool? a_(ClaimResponse PharmacyResponse)
		{
			var d_ = PharmacyResponse.Type;
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var f_ = e_.codes;
			var g_ = NCQATerminology_1_0_0.Pharmacy();
			var h_ = context.Operators;
			var i_ = h_.ListContains<CqlCode>((f_ as IEnumerable<CqlCode>), g_);

			return i_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<ClaimResponse>(claimResponse, a_);

		return c_;
	}


    [CqlDeclaration("Medical Claims With Procedure and POS")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_and_POS(IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p)
		{
			var o_ = p.code;

			return o_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, b_);
		string e_(CqlCode pos)
		{
			var p_ = pos.code;

			return p_;
		};
		var g_ = c_.SelectOrNull<CqlCode, string>(posCodes, e_);
		var h_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = a_,
			ProceduresAsStrings = d_,
			POSAsString = g_,
		};
		var i_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			h_,
		};
		IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> j_(Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithPosCode)
		{
			var q_ = ClaimWithPosCode.MedicalClaim;
			Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA r_(Claim ClaimofInterest)
			{
				var x_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = ClaimofInterest,
					LineItems = (((ClaimofInterest == null))
						? ((null as IEnumerable<Claim.ItemComponent>))
						: (context.Operators.WhereOrNull<Claim.ItemComponent>((ClaimofInterest.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ItemOnLine) => context.Operators.And(context.Operators.ExistsInList<CqlCode>(context.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(ItemOnLine.ProductOrService).codes as IEnumerable<CqlCode>), (CqlCode LineCode) => context.Operators.InList<string>(LineCode.code, ClaimWithPosCode.ProceduresAsStrings))), context.Operators.ExistsInList<CqlCode>(context.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept((ItemOnLine.Location as CodeableConcept)).codes as IEnumerable<CqlCode>), (CqlCode PosCode) => context.Operators.InList<string>(PosCode.code, ClaimWithPosCode.POSAsString)))))))
,
				};
				var y_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					x_,
				};
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA z_(Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition) => (((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition.LineItems) ?? false))
					? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
						{
							Claim = LineItemDefinition.Claim,
							ServicePeriod = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition.LineItems, (Claim.ItemComponent @this) => context.Operators.Not((bool?)(@this.Serviced == null))), (Claim.ItemComponent @this) => @this.Serviced), (DataType NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
						})
					: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)))
;
				var aa_ = context.Operators;
				var ab_ = aa_.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(y_, z_);
				var ad_ = aa_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ab_);

				return ad_;
			};
			var s_ = context.Operators;
			var t_ = s_.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_, r_);
			bool? u_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var ae_ = (FinalList == null);
				var af_ = context.Operators;
				var ag_ = af_.Not((bool?)ae_);

				return ag_;
			};
			var w_ = s_.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(t_, u_);

			return w_;
		};
		var l_ = c_.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_, j_);
		var n_ = c_.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(l_);

		return n_;
	}


    [CqlDeclaration("Medical Claims With Procedure in Header or on Line Item")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode p)
		{
			var l_ = p.code;

			return l_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, b_);
		var e_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = a_,
			ProceduresAsStrings = d_,
		};
		var f_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			e_,
		};
		IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> g_(Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithProcedure)
		{
			var m_ = ClaimWithProcedure.MedicalClaim;
			Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA n_(Claim ClaimofInterest)
			{
				var t_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = ClaimofInterest,
					LineItems = (((ClaimofInterest == null))
						? ((null as IEnumerable<Claim.ItemComponent>))
						: (context.Operators.WhereOrNull<Claim.ItemComponent>((ClaimofInterest.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ItemOnLine) => context.Operators.Or(context.Operators.ExistsInList<CqlCode>(context.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(ItemOnLine.ProductOrService).codes as IEnumerable<CqlCode>), (CqlCode LineCode) => context.Operators.InList<string>(LineCode.code, ClaimWithProcedure.ProceduresAsStrings))), context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.SelectOrNull<object, Coding>(context.Operators.FlattenLateBoundList(context.Operators.SelectOrNull<DataType, object>(context.Operators.WhereOrNull<DataType>(context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(context.Operators.WhereOrNull<Claim.ProcedureComponent>((ClaimofInterest.Procedure as IEnumerable<Claim.ProcedureComponent>), (Claim.ProcedureComponent @this) => context.Operators.Not((bool?)(@this.Procedure == null))), (Claim.ProcedureComponent @this) => @this.Procedure), (DataType @this) => context.Operators.Not((bool?)(context.Operators.LateBoundProperty<object>(@this, "coding") == null))), (DataType @this) => context.Operators.LateBoundProperty<object>(@this, "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context.Operators.InList<string>(HeaderCode.CodeElement.Value, ClaimWithProcedure.ProceduresAsStrings)))))))
,
				};
				var u_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					t_,
				};
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA v_(Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition) => (((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition.LineItems) ?? false))
					? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
						{
							Claim = LineItemDefinition.Claim,
							ServicePeriod = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition.LineItems, (Claim.ItemComponent @this) => context.Operators.Not((bool?)(@this.Serviced == null))), (Claim.ItemComponent @this) => @this.Serviced), (DataType NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
						})
					: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)))
;
				var w_ = context.Operators;
				var x_ = w_.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(u_, v_);
				var z_ = w_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(x_);

				return z_;
			};
			var o_ = context.Operators;
			var p_ = o_.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(m_, n_);
			bool? q_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var aa_ = (FinalList == null);
				var ab_ = context.Operators;
				var ac_ = ab_.Not((bool?)aa_);

				return ac_;
			};
			var s_ = o_.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(p_, q_);

			return s_;
		};
		var i_ = c_.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(f_, g_);
		var k_ = c_.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);

		return k_;
	}


    [CqlDeclaration("Medical Claims With Diagnosis")]
    public Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI Medical_Claims_With_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var l_ = d.code;

			return l_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		var e_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = d_,
		};
		var f_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			e_,
		};
		Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI g_(Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis)
		{
			var m_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = (((ClaimWithDiagnosis.MedicalClaim == null))
					? ((null as IEnumerable<Claim>))
					: (context.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis.MedicalClaim, (Claim DiagnosisLine) => context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.SelectOrNull<object, Coding>(context.Operators.FlattenLateBoundList(context.Operators.SelectOrNull<DataType, object>(context.Operators.WhereOrNull<DataType>(context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(context.Operators.WhereOrNull<Claim.DiagnosisComponent>((DiagnosisLine.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent @this) => context.Operators.Not((bool?)(@this.Diagnosis == null))), (Claim.DiagnosisComponent @this) => @this.Diagnosis), (DataType @this) => context.Operators.Not((bool?)(context.Operators.LateBoundProperty<object>(@this, "coding") == null))), (DataType @this) => context.Operators.LateBoundProperty<object>(@this, "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context.Operators.InList<string>(HeaderCode.CodeElement.Value, ClaimWithDiagnosis.DiagnosesAsStrings))))))
,
			};
			var n_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				m_,
			};
			Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI o_(Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg HeaderDefinition)
			{
				var t_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI[]
				{
(((context.Operators.ExistsInList<Claim>(HeaderDefinition.DiagnosisItems) ?? false))
						? (new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
							{
								Claim = HeaderDefinition.DiagnosisItems,
								ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(context.Operators.WhereOrNull<Claim>(HeaderDefinition.DiagnosisItems, (Claim @this) => context.Operators.Not((bool?)(@this.Item == null))), (Claim @this) => @this.Item)), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate.Serviced)),
							})
						: ((null as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI)))
,
				};
				bool? u_(Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList)
				{
					var z_ = (FinalList == null);
					var aa_ = context.Operators;
					var ab_ = aa_.Not((bool?)z_);

					return ab_;
				};
				var v_ = context.Operators;
				var w_ = v_.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(t_, u_);
				var y_ = v_.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(w_);

				return y_;
			};
			var p_ = context.Operators;
			var q_ = p_.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(n_, o_);
			var s_ = p_.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(q_);

			return s_;
		};
		var i_ = c_.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(f_, g_);
		var k_ = c_.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(i_);

		return k_;
	}


    [CqlDeclaration("Pharmacy Claim With Medication")]
    public IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> Pharmacy_Claim_With_Medication(IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
	{
		var a_ = this.Pharmacy_Claims(claim);
		string b_(CqlCode p)
		{
			var l_ = p.code;

			return l_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlCode, string>(MedicationCodes, b_);
		var e_ = new Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY
		{
			PharmacyClaim = a_,
			MedicationsAsStrings = d_,
		};
		var f_ = new Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY[]
		{
			e_,
		};
		IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> g_(Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY ClaimWithMedication)
		{
			var m_ = ClaimWithMedication.PharmacyClaim;
			Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC n_(Claim Pharmacy)
			{
				var t_ = Pharmacy.Item;
				bool? u_(Claim.ItemComponent ItemOnLine)
				{
					var ae_ = ItemOnLine.ProductOrService;
					var af_ = FHIRHelpers_4_0_001.ToConcept(ae_);
					var ag_ = af_.codes;
					bool? ah_(CqlCode LineCode)
					{
						var am_ = LineCode.code;
						var an_ = ClaimWithMedication.MedicationsAsStrings;
						var ao_ = context.Operators;
						var ap_ = ao_.InList<string>(am_, an_);

						return ap_;
					};
					var ai_ = context.Operators;
					var aj_ = ai_.WhereOrNull<CqlCode>((ag_ as IEnumerable<CqlCode>), ah_);
					var al_ = ai_.ExistsInList<CqlCode>(aj_);

					return al_;
				};
				var v_ = context.Operators;
				var w_ = v_.WhereOrNull<Claim.ItemComponent>((t_ as IEnumerable<Claim.ItemComponent>), u_);
				var x_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = Pharmacy,
					LineItems = w_,
				};
				var y_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					x_,
				};
				Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC z_(Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition)
				{
					var aq_ = LineItemDefinition.Claim;
					var ar_ = new Claim[]
					{
						aq_,
					};
					Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC as_(Claim ClaimLines)
					{
						var ax_ = ClaimLines.Item;
						bool? ay_(Claim.ItemComponent i)
						{
							var bl_ = i.ProductOrService;
							var bm_ = FHIRHelpers_4_0_001.ToConcept(bl_);
							var bn_ = bm_.codes;
							bool? bo_(CqlCode LineCode)
							{
								var bt_ = LineCode.code;
								var bu_ = ClaimWithMedication.MedicationsAsStrings;
								var bv_ = context.Operators;
								var bw_ = bv_.InList<string>(bt_, bu_);

								return bw_;
							};
							var bp_ = context.Operators;
							var bq_ = bp_.WhereOrNull<CqlCode>((bn_ as IEnumerable<CqlCode>), bo_);
							var bs_ = bp_.ExistsInList<CqlCode>(bq_);

							return bs_;
						};
						var az_ = context.Operators;
						var ba_ = az_.WhereOrNull<Claim.ItemComponent>((ax_ as IEnumerable<Claim.ItemComponent>), ay_);
						Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP bb_(Claim.ItemComponent i)
						{
							var bx_ = new Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP
							{
								DaysSupplyInterval = (((context.Operators.Not((bool?)(i.Quantity == null)) ?? false))
									? (((((i.Serviced is Period as bool?) ?? false))
											? (context.Operators.Interval(context.Operators.Start(NCQAFHIRBase_1_0_0.Normalize_Interval(i.Serviced)), context.Operators.Subtract(context.Operators.Add(context.Operators.Start(NCQAFHIRBase_1_0_0.Normalize_Interval(i.Serviced)), new CqlQuantity
															{
																value = FHIRHelpers_4_0_001.ToDecimal(i.Quantity.ValueElement),
																unit = "day",
															}), context.Operators.Quantity(1m, "day")), true, true))
											: (context.Operators.Interval(context.Operators.ConvertDateToDateTime(context.Operators.Interval(FHIRHelpers_4_0_001.ToDate((i.Serviced as Date)), context.Operators.Subtract(context.Operators.Add(FHIRHelpers_4_0_001.ToDate((i.Serviced as Date)), new CqlQuantity
			{
				value = FHIRHelpers_4_0_001.ToDecimal(i.Quantity.ValueElement),
				unit = "day",
			}), context.Operators.Quantity(1m, "day")), true, true).low), context.Operators.ConvertDateToDateTime(context.Operators.Interval(FHIRHelpers_4_0_001.ToDate((i.Serviced as Date)), context.Operators.Subtract(context.Operators.Add(FHIRHelpers_4_0_001.ToDate((i.Serviced as Date)), new CqlQuantity
			{
				value = FHIRHelpers_4_0_001.ToDecimal(i.Quantity.ValueElement),
				unit = "day",
			}), context.Operators.Quantity(1m, "day")), true, true).high), context.Operators.Interval(FHIRHelpers_4_0_001.ToDate((i.Serviced as Date)), context.Operators.Subtract(context.Operators.Add(FHIRHelpers_4_0_001.ToDate((i.Serviced as Date)), new CqlQuantity
			{
				value = FHIRHelpers_4_0_001.ToDecimal(i.Quantity.ValueElement),
				unit = "day",
			}), context.Operators.Quantity(1m, "day")), true, true).lowClosed, context.Operators.Interval(FHIRHelpers_4_0_001.ToDate((i.Serviced as Date)), context.Operators.Subtract(context.Operators.Add(FHIRHelpers_4_0_001.ToDate((i.Serviced as Date)), new CqlQuantity
			{
				value = FHIRHelpers_4_0_001.ToDecimal(i.Quantity.ValueElement),
				unit = "day",
			}), context.Operators.Quantity(1m, "day")), true, true).highClosed)))
)
									: ((null as CqlInterval<CqlDateTime>)))
,
							};

							return bx_;
						};
						var bd_ = az_.SelectOrNull<Claim.ItemComponent, Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP>(ba_, bb_);
						var be_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU
						{
							CoveredDays = bd_,
						};
						var bf_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU[]
						{
							be_,
						};
						Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC bg_(Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU ItemCalculation) => (((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition.LineItems) ?? false))
							? (new Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC
								{
									Claim = LineItemDefinition.Claim,
									LineItem = LineItemDefinition.LineItems,
									ServicePeriod = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition.LineItems, (Claim.ItemComponent @this) => context.Operators.Not((bool?)(@this.Serviced == null))), (Claim.ItemComponent @this) => @this.Serviced), (DataType NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
									CoveredDays = context.Operators.SelectOrNull<Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP, CqlInterval<CqlDateTime>>(ItemCalculation.CoveredDays, (Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP d) => d.DaysSupplyInterval),
								})
							: ((null as Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC)))
;
						var bi_ = az_.SelectOrNull<Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(bf_, bg_);
						var bk_ = az_.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(bi_);

						return bk_;
					};
					var at_ = context.Operators;
					var au_ = at_.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ar_, as_);
					var aw_ = at_.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(au_);

					return aw_;
				};
				var ab_ = v_.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(y_, z_);
				var ad_ = v_.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ab_);

				return ad_;
			};
			var o_ = context.Operators;
			var p_ = o_.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(m_, n_);
			bool? q_(Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC FinalList)
			{
				var by_ = (FinalList == null);
				var bz_ = context.Operators;
				var ca_ = bz_.Not((bool?)by_);

				return ca_;
			};
			var s_ = o_.WhereOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(p_, q_);

			return s_;
		};
		var i_ = c_.SelectOrNull<Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY, IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(f_, g_);
		var k_ = c_.SingleOrNull<IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(i_);

		return k_;
	}


    [CqlDeclaration("Medical Claims With Diagnosis and Procedure")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var o_ = d.code;

			return o_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		string e_(CqlCode p)
		{
			var p_ = p.code;

			return p_;
		};
		var g_ = c_.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, e_);
		var h_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = d_,
			ProceduresAsStrings = g_,
		};
		var i_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
		{
			h_,
		};
		IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> j_(Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithDiagnosis)
		{
			var q_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = (((ClaimWithDiagnosis.MedicalClaim == null))
					? ((null as IEnumerable<Claim>))
					: (context.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis.MedicalClaim, (Claim DiagnosisLine) => context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.SelectOrNull<object, Coding>(context.Operators.FlattenLateBoundList(context.Operators.SelectOrNull<DataType, object>(context.Operators.WhereOrNull<DataType>(context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(context.Operators.WhereOrNull<Claim.DiagnosisComponent>((DiagnosisLine.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent @this) => context.Operators.Not((bool?)(@this.Diagnosis == null))), (Claim.DiagnosisComponent @this) => @this.Diagnosis), (DataType @this) => context.Operators.Not((bool?)(context.Operators.LateBoundProperty<object>(@this, "coding") == null))), (DataType @this) => context.Operators.LateBoundProperty<object>(@this, "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context.Operators.InList<string>(HeaderCode.CodeElement.Value, ClaimWithDiagnosis.DiagnosesAsStrings))))))
,
			};
			var r_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				q_,
			};
			IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> s_(Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg ClaimWithProcedure)
			{
				var x_ = ClaimWithProcedure.DiagnosisItems;
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA y_(Claim ClaimofInterest)
				{
					var ae_ = new Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU
					{
						ProcedureItems = (((ClaimofInterest == null))
							? (null)
							: (context.Operators.SingleOrNull<Claim>(context.Operators.WhereOrNull<Claim>(new Claim[]
										{
											ClaimofInterest,
										}, (Claim ItemOnLine) => context.Operators.Or(context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.SelectOrNull<object, Coding>(context.Operators.FlattenLateBoundList(context.Operators.SelectOrNull<DataType, object>(context.Operators.WhereOrNull<DataType>(context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(context.Operators.WhereOrNull<Claim.ProcedureComponent>((ItemOnLine.Procedure as IEnumerable<Claim.ProcedureComponent>), (Claim.ProcedureComponent @this) => context.Operators.Not((bool?)(@this.Procedure == null))), (Claim.ProcedureComponent @this) => @this.Procedure), (DataType @this) => context.Operators.Not((bool?)(context.Operators.LateBoundProperty<object>(@this, "coding") == null))), (DataType @this) => context.Operators.LateBoundProperty<object>(@this, "coding"))), (object @object) => (@object as Coding)), (Coding ProcedureHeaderCode) => context.Operators.InList<string>(ProcedureHeaderCode.CodeElement.Value, ClaimWithDiagnosis.ProceduresAsStrings))), context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.FlattenList<Coding>(context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(context.Operators.WhereOrNull<CodeableConcept>(context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(context.Operators.WhereOrNull<Claim.ItemComponent>((ItemOnLine.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent @this) => context.Operators.Not((bool?)(@this.ProductOrService == null))), (Claim.ItemComponent @this) => @this.ProductOrService), (CodeableConcept @this) => context.Operators.Not((bool?)(@this.Coding == null))), (CodeableConcept @this) => @this.Coding)), (Coding LineCode) => context.Operators.InList<string>(LineCode.CodeElement.Value, ClaimWithDiagnosis.ProceduresAsStrings))))))))
,
					};
					var af_ = new Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU[]
					{
						ae_,
					};
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ag_(Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU HeaderDefinition) => (((context.Operators.Not((bool?)(HeaderDefinition.ProcedureItems == null)) ?? false))
						? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = HeaderDefinition.ProcedureItems,
								ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((HeaderDefinition.ProcedureItems.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate.Serviced)),
							})
						: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)))
;
					var ah_ = context.Operators;
					var ai_ = ah_.SelectOrNull<Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(af_, ag_);
					var ak_ = ah_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ai_);

					return ak_;
				};
				var z_ = context.Operators;
				var aa_ = z_.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(x_, y_);
				bool? ab_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
				{
					var al_ = (FinalList == null);
					var am_ = context.Operators;
					var an_ = am_.Not((bool?)al_);

					return an_;
				};
				var ad_ = z_.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(aa_, ab_);

				return ad_;
			};
			var t_ = context.Operators;
			var u_ = t_.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(r_, s_);
			var w_ = t_.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(u_);

			return w_;
		};
		var l_ = c_.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_, j_);
		var n_ = c_.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(l_);

		return n_;
	}


    [CqlDeclaration("Medical Claims With Principal Diagnosis and Procedure")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Principal_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var o_ = d.code;

			return o_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		string e_(CqlCode p)
		{
			var p_ = p.code;

			return p_;
		};
		var g_ = c_.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, e_);
		var h_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = d_,
			ProceduresAsStrings = g_,
		};
		var i_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
		{
			h_,
		};
		IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> j_(Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithProcedure)
		{
			var q_ = ClaimWithProcedure.MedicalClaim;
			Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA r_(Claim ClaimofInterest)
			{
				var x_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB
				{
					Claim = ClaimofInterest,
					ProcedureItems = (((ClaimofInterest == null))
						? (null)
						: (context.Operators.SingleOrNull<Claim>(context.Operators.WhereOrNull<Claim>(new Claim[]
									{
										ClaimofInterest,
									}, (Claim ItemOnLine) => context.Operators.Or(context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.FlattenList<Coding>(context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(context.Operators.WhereOrNull<CodeableConcept>(context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(context.Operators.WhereOrNull<Claim.ItemComponent>((ItemOnLine.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent @this) => context.Operators.Not((bool?)(@this.ProductOrService == null))), (Claim.ItemComponent @this) => @this.ProductOrService), (CodeableConcept @this) => context.Operators.Not((bool?)(@this.Coding == null))), (CodeableConcept @this) => @this.Coding)), (Coding LineCode) => context.Operators.InList<string>(LineCode.CodeElement.Value, ClaimWithProcedure.ProceduresAsStrings))), context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.SelectOrNull<object, Coding>(context.Operators.FlattenLateBoundList(context.Operators.SelectOrNull<DataType, object>(context.Operators.WhereOrNull<DataType>(context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(context.Operators.WhereOrNull<Claim.ProcedureComponent>((ItemOnLine.Procedure as IEnumerable<Claim.ProcedureComponent>), (Claim.ProcedureComponent @this) => context.Operators.Not((bool?)(@this.Procedure == null))), (Claim.ProcedureComponent @this) => @this.Procedure), (DataType @this) => context.Operators.Not((bool?)(context.Operators.LateBoundProperty<object>(@this, "coding") == null))), (DataType @this) => context.Operators.LateBoundProperty<object>(@this, "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context.Operators.InList<string>(HeaderCode.CodeElement.Value, ClaimWithProcedure.ProceduresAsStrings))))))))
,
				};
				var y_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB[]
				{
					x_,
				};
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA z_(Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB DiagnosisCheck)
				{
					var ae_ = DiagnosisCheck.ProcedureItems;
					var af_ = new Claim[]
					{
						ae_,
					};
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ag_(Claim ClaimforDiagnosis)
					{
						var al_ = ClaimforDiagnosis.Item;
						var am_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI
						{
							Procedure = (al_ as IEnumerable<Claim.ItemComponent>),
							LineItems = (((ClaimforDiagnosis == null))
								? (null)
								: (context.Operators.SingleOrNull<Claim>(context.Operators.WhereOrNull<Claim>(new Claim[]
											{
												ClaimforDiagnosis,
											}, (Claim RightClaim) => context.Operators.ExistsInList<Claim.DiagnosisComponent>(context.Operators.WhereOrNull<Claim.DiagnosisComponent>((RightClaim.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent RightDiagnosis) => context.Operators.And(context.Operators.Equal(FHIRHelpers_4_0_001.ToInteger(context.Operators.TypeConverter.Convert<Integer>(RightDiagnosis.SequenceElement)), (int?)1), context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.LateBoundProperty<IEnumerable<Coding>>(RightDiagnosis.Diagnosis, "coding"), (Coding DiagnosisCode) => context.Operators.InList<string>(DiagnosisCode.CodeElement.Value, ClaimWithProcedure.DiagnosesAsStrings))))))))))
,
						};
						var an_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI[]
						{
							am_,
						};
						Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ao_(Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI LineItemDefinition) => (((context.Operators.And(context.Operators.Not((bool?)(LineItemDefinition == null)), context.Operators.Not((bool?)(LineItemDefinition.LineItems == null))) ?? false))
							? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
								{
									Claim = LineItemDefinition.LineItems,
									ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((LineItemDefinition.LineItems.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate.Serviced)),
								})
							: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)))
;
						var ap_ = context.Operators;
						var aq_ = ap_.SelectOrNull<Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(an_, ao_);
						var as_ = ap_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(aq_);

						return as_;
					};
					var ah_ = context.Operators;
					var ai_ = ah_.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(af_, ag_);
					var ak_ = ah_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ai_);

					return ak_;
				};
				var aa_ = context.Operators;
				var ab_ = aa_.SelectOrNull<Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(y_, z_);
				var ad_ = aa_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ab_);

				return ad_;
			};
			var s_ = context.Operators;
			var t_ = s_.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_, r_);
			bool? u_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var at_ = (FinalList == null);
				var au_ = context.Operators;
				var av_ = au_.Not((bool?)at_);

				return av_;
			};
			var w_ = s_.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(t_, u_);

			return w_;
		};
		var l_ = c_.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_, j_);
		var n_ = c_.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(l_);

		return n_;
	}


    [CqlDeclaration("Medical Claims With Principal Diagnosis")]
    public IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> Medical_Claims_With_Principal_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		string b_(CqlCode d)
		{
			var l_ = d.code;

			return l_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		var e_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = d_,
		};
		var f_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			e_,
		};
		IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> g_(Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis)
		{
			var m_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN
			{
				LineItems = (((ClaimWithDiagnosis.MedicalClaim == null))
					? ((null as IEnumerable<Claim>))
					: (context.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis.MedicalClaim, (Claim RightClaim) => context.Operators.ExistsInList<Claim.DiagnosisComponent>(context.Operators.WhereOrNull<Claim.DiagnosisComponent>((RightClaim.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent RightDiagnosis) => context.Operators.And(context.Operators.Equal(FHIRHelpers_4_0_001.ToInteger(context.Operators.TypeConverter.Convert<Integer>(RightDiagnosis.SequenceElement)), (int?)1), context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.LateBoundProperty<IEnumerable<Coding>>(RightDiagnosis.Diagnosis, "coding"), (Coding DiagnosisCode) => context.Operators.InList<string>(DiagnosisCode.CodeElement.Value, ClaimWithDiagnosis.DiagnosesAsStrings)))))))))
,
			};
			var n_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN[]
			{
				m_,
			};
			IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> o_(Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN LineItemDefinition)
			{
				var t_ = LineItemDefinition.LineItems;
				Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI u_(Claim ClaimWithDiagnosis) => (((context.Operators.Not((bool?)(ClaimWithDiagnosis == null)) ?? false))
					? (new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = LineItemDefinition.LineItems,
							ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(context.Operators.WhereOrNull<Claim>(LineItemDefinition.LineItems, (Claim @this) => context.Operators.Not((bool?)(@this.Item == null))), (Claim @this) => @this.Item)), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate.Serviced)),
						})
					: ((null as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI)))
;
				var v_ = context.Operators;
				var w_ = v_.SelectOrNull<Claim, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(t_, u_);
				bool? x_(Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList)
				{
					var aa_ = (FinalList == null);
					var ab_ = context.Operators;
					var ac_ = ab_.Not((bool?)aa_);

					return ac_;
				};
				var z_ = v_.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(w_, x_);

				return z_;
			};
			var p_ = context.Operators;
			var q_ = p_.SelectOrNull<Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(n_, o_);
			var s_ = p_.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(q_);

			return s_;
		};
		var i_ = c_.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(f_, g_);
		var k_ = c_.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(i_);

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
		bool? a_(ClaimResponse ResponseItem)
		{
			var k_ = ResponseItem.OutcomeElement;
			var l_ = new CallStackEntry("ToString", null, null);
			var m_ = context.Deeper(l_);
			var n_ = m_.Operators;
			var o_ = n_.TypeConverter;
			var p_ = o_.Convert<string>(k_);
			var q_ = new string[]
			{
				"complete",
				"partial",
			};
			var r_ = context.Operators;
			var s_ = r_.InList<string>(p_, (q_ as IEnumerable<string>));

			return s_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<ClaimResponse>(claimResponse, a_);
		var d_ = new Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD
		{
			PaidResponse = c_,
		};
		var e_ = new Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD[]
		{
			d_,
		};
		IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> f_(Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD ClaimResponse)
		{
			var t_ = ClaimResponse.PaidResponse;
			Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL u_(ClaimResponse ClmResp)
			{
				var x_ = ClmResp.Request;
				var y_ = x_.ReferenceElement;
				var z_ = new CallStackEntry("ToString", null, null);
				var aa_ = context.Deeper(z_);
				var ab_ = aa_.Operators;
				var ac_ = ab_.TypeConverter;
				var ad_ = ac_.Convert<string>(y_);
				var ae_ = NCQAFHIRBase_1_0_0.GetId(ad_);
				var af_ = ClmResp.Item;
				bool? ag_(ClaimResponse.ItemComponent ResponseItem)
				{
					var ak_ = ResponseItem.Adjudication;
					bool? al_(ClaimResponse.AdjudicationComponent @this)
					{
						var bs_ = @this.Category;
						var bt_ = (bs_ == null);
						var bu_ = context.Operators;
						var bv_ = bu_.Not((bool?)bt_);

						return bv_;
					};
					var am_ = context.Operators;
					var an_ = am_.WhereOrNull<ClaimResponse.AdjudicationComponent>(ak_, al_);
					CodeableConcept ao_(ClaimResponse.AdjudicationComponent @this)
					{
						var bw_ = @this.Category;

						return bw_;
					};
					var aq_ = am_.SelectOrNull<ClaimResponse.AdjudicationComponent, CodeableConcept>(an_, ao_);
					bool? ar_(CodeableConcept @this)
					{
						var bx_ = @this.Coding;
						var by_ = (bx_ == null);
						var bz_ = context.Operators;
						var ca_ = bz_.Not((bool?)by_);

						return ca_;
					};
					var at_ = am_.WhereOrNull<CodeableConcept>(aq_, ar_);
					List<Coding> au_(CodeableConcept @this)
					{
						var cb_ = @this.Coding;

						return cb_;
					};
					var aw_ = am_.SelectOrNull<CodeableConcept, List<Coding>>(at_, au_);
					var ay_ = am_.FlattenList<Coding>(aw_);
					bool? az_(Coding CategoryItem)
					{
						var cc_ = CategoryItem.CodeElement;
						var cd_ = cc_.Value;
						var ce_ = context.Operators;
						var cf_ = ce_.Equal(cd_, "benefit");

						return cf_;
					};
					var bb_ = am_.WhereOrNull<Coding>(ay_, az_);
					var bd_ = am_.ExistsInList<Coding>(bb_);
					bool? bf_(ClaimResponse.AdjudicationComponent @this)
					{
						var cg_ = @this.Amount;
						var ch_ = (cg_ == null);
						var ci_ = context.Operators;
						var cj_ = ci_.Not((bool?)ch_);

						return cj_;
					};
					var bh_ = am_.WhereOrNull<ClaimResponse.AdjudicationComponent>(ak_, bf_);
					Money bi_(ClaimResponse.AdjudicationComponent @this)
					{
						var ck_ = @this.Amount;

						return ck_;
					};
					var bk_ = am_.SelectOrNull<ClaimResponse.AdjudicationComponent, Money>(bh_, bi_);
					bool? bl_(Money DollarAmount)
					{
						var cl_ = DollarAmount.ValueElement;
						var cm_ = FHIRHelpers_4_0_001.ToDecimal(cl_);
						var cn_ = context.Operators;
						var co_ = cn_.ConvertIntegerToDecimal((int?)0);
						var cq_ = cn_.Greater(cm_, co_);

						return cq_;
					};
					var bn_ = am_.WhereOrNull<Money>(bk_, bl_);
					var bp_ = am_.ExistsInList<Money>(bn_);
					var br_ = am_.And(bd_, bp_);

					return br_;
				};
				var ah_ = context.Operators;
				var ai_ = ah_.WhereOrNull<ClaimResponse.ItemComponent>((af_ as IEnumerable<ClaimResponse.ItemComponent>), ag_);
				var aj_ = new Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL
				{
					Response = ClmResp,
					ResponseID = ae_,
					LineItems = ai_,
				};

				return aj_;
			};
			var v_ = context.Operators;
			var w_ = v_.SelectOrNull<ClaimResponse, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(t_, u_);

			return w_;
		};
		var h_ = b_.SelectOrNull<Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD, IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(e_, f_);
		var j_ = b_.SingleOrNull<IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(h_);

		return j_;
	}


    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_and_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			var g_ = AllClaims.Item;
			bool? h_(Claim.ItemComponent @this)
			{
				var az_ = @this.ProductOrService;
				var ba_ = (az_ == null);
				var bb_ = context.Operators;
				var bc_ = bb_.Not((bool?)ba_);

				return bc_;
			};
			var i_ = context.Operators;
			var j_ = i_.WhereOrNull<Claim.ItemComponent>(g_, h_);
			CodeableConcept k_(Claim.ItemComponent @this)
			{
				var bd_ = @this.ProductOrService;

				return bd_;
			};
			var m_ = i_.SelectOrNull<Claim.ItemComponent, CodeableConcept>(j_, k_);
			bool? n_(CodeableConcept @this)
			{
				var be_ = @this.Coding;
				var bf_ = (be_ == null);
				var bg_ = context.Operators;
				var bh_ = bg_.Not((bool?)bf_);

				return bh_;
			};
			var p_ = i_.WhereOrNull<CodeableConcept>(m_, n_);
			List<Coding> q_(CodeableConcept @this)
			{
				var bi_ = @this.Coding;

				return bi_;
			};
			var s_ = i_.SelectOrNull<CodeableConcept, List<Coding>>(p_, q_);
			var u_ = i_.FlattenList<Coding>(s_);
			bool? v_(Coding ProductOrServiceCode)
			{
				var bj_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var bk_ = context.Operators;
				var bl_ = bk_.CodeInList(bj_, ProductOrServiceValueSet);

				return bl_;
			};
			var x_ = i_.WhereOrNull<Coding>(u_, v_);
			var z_ = i_.ExistsInList<Coding>(x_);
			var aa_ = AllClaims.Diagnosis;
			bool? ab_(Claim.DiagnosisComponent @this)
			{
				var bm_ = @this.Diagnosis;
				var bn_ = (bm_ == null);
				var bo_ = context.Operators;
				var bp_ = bo_.Not((bool?)bn_);

				return bp_;
			};
			var ad_ = i_.WhereOrNull<Claim.DiagnosisComponent>((aa_ as IEnumerable<Claim.DiagnosisComponent>), ab_);
			DataType ae_(Claim.DiagnosisComponent @this)
			{
				var bq_ = @this.Diagnosis;

				return bq_;
			};
			var ag_ = i_.SelectOrNull<Claim.DiagnosisComponent, DataType>(ad_, ae_);
			bool? ah_(DataType @this)
			{
				var br_ = context.Operators;
				var bs_ = br_.LateBoundProperty<object>(@this, "coding");
				var bt_ = (bs_ == null);
				var bv_ = br_.Not((bool?)bt_);

				return bv_;
			};
			var aj_ = i_.WhereOrNull<DataType>(ag_, ah_);
			object ak_(DataType @this)
			{
				var bw_ = context.Operators;
				var bx_ = bw_.LateBoundProperty<object>(@this, "coding");

				return bx_;
			};
			var am_ = i_.SelectOrNull<DataType, object>(aj_, ak_);
			var ao_ = i_.FlattenLateBoundList(am_);
			Coding ap_(object @object) => (@object as Coding);
			var ar_ = i_.SelectOrNull<object, Coding>(ao_, ap_);
			bool? as_(Coding DiagnosisCode)
			{
				var by_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
				var bz_ = context.Operators;
				var ca_ = bz_.CodeInList(by_, DiagnosisValueSet);

				return ca_;
			};
			var au_ = i_.WhereOrNull<Coding>(ar_, as_);
			var aw_ = i_.ExistsInList<Coding>(au_);
			var ay_ = i_.And(z_, aw_);

			return ay_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Claim>(claim, a_);
		Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM d_(Claim ProcedureClaims)
		{
			var cb_ = ProcedureClaims.IdElement;
			var cc_ = ProcedureClaims.Item;
			bool? cd_(Claim.ItemComponent ResponseItem)
			{
				var ch_ = ResponseItem.ProductOrService;
				var ci_ = ch_.Coding;
				bool? cj_(Coding ProductOrServiceCode)
				{
					var co_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var cp_ = context.Operators;
					var cq_ = cp_.CodeInList(co_, ProductOrServiceValueSet);

					return cq_;
				};
				var ck_ = context.Operators;
				var cl_ = ck_.WhereOrNull<Coding>((ci_ as IEnumerable<Coding>), cj_);
				var cn_ = ck_.ExistsInList<Coding>(cl_);

				return cn_;
			};
			var ce_ = context.Operators;
			var cf_ = ce_.WhereOrNull<Claim.ItemComponent>((cc_ as IEnumerable<Claim.ItemComponent>), cd_);
			var cg_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = ProcedureClaims,
				ClaimID = cb_,
				LineItems = cf_,
			};

			return cg_;
		};
		var f_ = b_.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(c_, d_);

		return f_;
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
			var j_ = ClaimAndResponse.MedicalClaim;
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg k_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				var u_ = medClaim.LineItems;
				bool? v_(Claim.ItemComponent medClaimLineItem)
				{
					var z_ = ClaimAndResponse.PaidMedicalClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> aa_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var af_ = pClaim.LineItems;
						bool? ag_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var am_ = new CallStackEntry("ToString", null, null);
							var an_ = context.Deeper(am_);
							var ao_ = an_.Operators;
							var ap_ = ao_.TypeConverter;
							var aq_ = ap_.Convert<string>(((medClaim.ClaimofInterest is Resource)
									? ((medClaim.ClaimofInterest as Resource).IdElement)
									: (null))
);
							var ar_ = pClaim.Response;
							var as_ = ar_.Request;
							var at_ = as_.ReferenceElement;
							var av_ = context.Deeper(am_);
							var aw_ = av_.Operators;
							var ax_ = aw_.TypeConverter;
							var ay_ = ax_.Convert<string>(at_);
							var az_ = NCQAFHIRBase_1_0_0.GetId(ay_);
							var ba_ = context.Operators;
							var bb_ = ba_.Equal(aq_, az_);
							var bc_ = medClaimLineItem.SequenceElement;
							var be_ = ba_.TypeConverter;
							var bf_ = be_.Convert<Integer>(bc_);
							var bg_ = pClaimLineItem.ItemSequenceElement;
							var bi_ = ba_.TypeConverter;
							var bj_ = bi_.Convert<Integer>(bg_);
							var bl_ = ba_.Equal(bf_, bj_);
							var bn_ = ba_.And(bb_, bl_);

							return bn_;
						};
						var ah_ = context.Operators;
						var ai_ = ah_.WhereOrNull<ClaimResponse.ItemComponent>(af_, ag_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL aj_(ClaimResponse.ItemComponent pClaimLineItem) => pClaim;
						var al_ = ah_.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ai_, aj_);

						return al_;
					};
					var ab_ = context.Operators;
					var ac_ = ab_.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, aa_);
					var ae_ = ab_.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ac_);

					return ae_;
				};
				var w_ = context.Operators;
				var x_ = w_.WhereOrNull<Claim.ItemComponent>(u_, v_);
				var y_ = new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = x_,
				};

				return y_;
			};
			var l_ = context.Operators;
			var m_ = l_.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(j_, k_);
			var n_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = m_,
			};
			var o_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				n_,
			};
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO p_(Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				var bo_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
(((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this.ClaimItem))) ?? false))
						? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
							{
								originalClaim = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this.PaidClaim == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this.PaidClaim),
								ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem.Serviced)),
							})
						: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
,
				};
				bool? bp_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bu_ = (FinalList == null);
					var bv_ = context.Operators;
					var bw_ = bv_.Not((bool?)bu_);

					return bw_;
				};
				var bq_ = context.Operators;
				var br_ = bq_.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bo_, bp_);
				var bt_ = bq_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(br_);

				return bt_;
			};
			var r_ = l_.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(o_, p_);
			var t_ = l_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(r_);

			return t_;
		};
		var f_ = context.Operators;
		var g_ = f_.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var i_ = f_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(g_);

		return i_;
	}


    [CqlDeclaration("Get Paid Claims for Provided Service and Condition")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Service_and_Condition(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			a_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO c_(Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse) => (((context.Operators.And((bool?)(MedicalClaimAndResponse.MedicalClaimResponse == null), (bool?)(MedicalClaimAndResponse.MedicalClaim == null)) ?? false))
			? ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))
			: (this.Get_Corresponding_Claim_for_Services_and_Conditions(MedicalClaimAndResponse.MedicalClaimResponse, MedicalClaimAndResponse.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet)))
;
		var d_ = context.Operators;
		var e_ = d_.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		var g_ = d_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(e_);
		var h_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
		{
			g_,
		};
		bool? i_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
		{
			var n_ = (FinalList == null);
			var o_ = context.Operators;
			var p_ = o_.Not((bool?)n_);

			return p_;
		};
		var k_ = d_.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(h_, i_);
		var m_ = d_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(k_);

		return m_;
	}


    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_or_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			var g_ = AllClaims.Item;
			bool? h_(Claim.ItemComponent @this)
			{
				var az_ = @this.ProductOrService;
				var ba_ = (az_ == null);
				var bb_ = context.Operators;
				var bc_ = bb_.Not((bool?)ba_);

				return bc_;
			};
			var i_ = context.Operators;
			var j_ = i_.WhereOrNull<Claim.ItemComponent>(g_, h_);
			CodeableConcept k_(Claim.ItemComponent @this)
			{
				var bd_ = @this.ProductOrService;

				return bd_;
			};
			var m_ = i_.SelectOrNull<Claim.ItemComponent, CodeableConcept>(j_, k_);
			bool? n_(CodeableConcept @this)
			{
				var be_ = @this.Coding;
				var bf_ = (be_ == null);
				var bg_ = context.Operators;
				var bh_ = bg_.Not((bool?)bf_);

				return bh_;
			};
			var p_ = i_.WhereOrNull<CodeableConcept>(m_, n_);
			List<Coding> q_(CodeableConcept @this)
			{
				var bi_ = @this.Coding;

				return bi_;
			};
			var s_ = i_.SelectOrNull<CodeableConcept, List<Coding>>(p_, q_);
			var u_ = i_.FlattenList<Coding>(s_);
			bool? v_(Coding ProductOrServiceCode)
			{
				var bj_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var bk_ = context.Operators;
				var bl_ = bk_.CodeInList(bj_, ProductOrServiceValueSet);

				return bl_;
			};
			var x_ = i_.WhereOrNull<Coding>(u_, v_);
			var z_ = i_.ExistsInList<Coding>(x_);
			var aa_ = AllClaims.Diagnosis;
			bool? ab_(Claim.DiagnosisComponent @this)
			{
				var bm_ = @this.Diagnosis;
				var bn_ = (bm_ == null);
				var bo_ = context.Operators;
				var bp_ = bo_.Not((bool?)bn_);

				return bp_;
			};
			var ad_ = i_.WhereOrNull<Claim.DiagnosisComponent>((aa_ as IEnumerable<Claim.DiagnosisComponent>), ab_);
			DataType ae_(Claim.DiagnosisComponent @this)
			{
				var bq_ = @this.Diagnosis;

				return bq_;
			};
			var ag_ = i_.SelectOrNull<Claim.DiagnosisComponent, DataType>(ad_, ae_);
			bool? ah_(DataType @this)
			{
				var br_ = context.Operators;
				var bs_ = br_.LateBoundProperty<object>(@this, "coding");
				var bt_ = (bs_ == null);
				var bv_ = br_.Not((bool?)bt_);

				return bv_;
			};
			var aj_ = i_.WhereOrNull<DataType>(ag_, ah_);
			object ak_(DataType @this)
			{
				var bw_ = context.Operators;
				var bx_ = bw_.LateBoundProperty<object>(@this, "coding");

				return bx_;
			};
			var am_ = i_.SelectOrNull<DataType, object>(aj_, ak_);
			var ao_ = i_.FlattenLateBoundList(am_);
			Coding ap_(object @object) => (@object as Coding);
			var ar_ = i_.SelectOrNull<object, Coding>(ao_, ap_);
			bool? as_(Coding DiagnosisCode)
			{
				var by_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
				var bz_ = context.Operators;
				var ca_ = bz_.CodeInList(by_, DiagnosisValueSet);

				return ca_;
			};
			var au_ = i_.WhereOrNull<Coding>(ar_, as_);
			var aw_ = i_.ExistsInList<Coding>(au_);
			var ay_ = i_.Or(z_, aw_);

			return ay_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Claim>(claim, a_);
		Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM d_(Claim ProcedureClaims) => (((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>((ResponseItem.ProductOrService.Coding as IEnumerable<Coding>), (Coding ProductOrServiceCode) => context.Operators.CodeInList(FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode), ProductOrServiceValueSet))))) ?? false))
			? (new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
				{
					ClaimofInterest = ProcedureClaims,
					ClaimID = ProcedureClaims.IdElement,
					LineItems = context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>((ResponseItem.ProductOrService.Coding as IEnumerable<Coding>), (Coding ProductOrServiceCode) => context.Operators.CodeInList(FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode), ProductOrServiceValueSet)))),
				})
			: (new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
				{
					ClaimofInterest = ProcedureClaims,
					ClaimID = ProcedureClaims.IdElement,
					LineItems = context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => context.Operators.Equal(context.Operators.TypeConverter.Convert<Integer>(ResponseItem.SequenceElement).Value, (int?)1)),
				}))
;
		var f_ = b_.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(c_, d_);

		return f_;
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
			var j_ = ClaimAndResponse.MedicalClaim;
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg k_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				var u_ = medClaim.LineItems;
				bool? v_(Claim.ItemComponent medClaimLineItem)
				{
					var z_ = ClaimAndResponse.PaidMedicalClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> aa_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var af_ = pClaim.LineItems;
						bool? ag_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var am_ = new CallStackEntry("ToString", null, null);
							var an_ = context.Deeper(am_);
							var ao_ = an_.Operators;
							var ap_ = ao_.TypeConverter;
							var aq_ = ap_.Convert<string>(((medClaim.ClaimofInterest is Resource)
									? ((medClaim.ClaimofInterest as Resource).IdElement)
									: (null))
);
							var ar_ = pClaim.Response;
							var as_ = ar_.Request;
							var at_ = as_.ReferenceElement;
							var av_ = context.Deeper(am_);
							var aw_ = av_.Operators;
							var ax_ = aw_.TypeConverter;
							var ay_ = ax_.Convert<string>(at_);
							var az_ = NCQAFHIRBase_1_0_0.GetId(ay_);
							var ba_ = context.Operators;
							var bb_ = ba_.Equal(aq_, az_);
							var bc_ = medClaimLineItem.SequenceElement;
							var be_ = ba_.TypeConverter;
							var bf_ = be_.Convert<Integer>(bc_);
							var bg_ = pClaimLineItem.ItemSequenceElement;
							var bi_ = ba_.TypeConverter;
							var bj_ = bi_.Convert<Integer>(bg_);
							var bl_ = ba_.Equal(bf_, bj_);
							var bn_ = ba_.And(bb_, bl_);

							return bn_;
						};
						var ah_ = context.Operators;
						var ai_ = ah_.WhereOrNull<ClaimResponse.ItemComponent>(af_, ag_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL aj_(ClaimResponse.ItemComponent pClaimLineItem) => pClaim;
						var al_ = ah_.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ai_, aj_);

						return al_;
					};
					var ab_ = context.Operators;
					var ac_ = ab_.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, aa_);
					var ae_ = ab_.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ac_);

					return ae_;
				};
				var w_ = context.Operators;
				var x_ = w_.WhereOrNull<Claim.ItemComponent>(u_, v_);
				var y_ = new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = x_,
				};

				return y_;
			};
			var l_ = context.Operators;
			var m_ = l_.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(j_, k_);
			var n_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = m_,
			};
			var o_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				n_,
			};
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO p_(Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				var bo_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
(((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this.ClaimItem))) ?? false))
						? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
							{
								originalClaim = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this.PaidClaim == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this.PaidClaim),
								ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem.Serviced)),
							})
						: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
,
				};
				bool? bp_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bu_ = (FinalList == null);
					var bv_ = context.Operators;
					var bw_ = bv_.Not((bool?)bu_);

					return bw_;
				};
				var bq_ = context.Operators;
				var br_ = bq_.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bo_, bp_);
				var bt_ = bq_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(br_);

				return bt_;
			};
			var r_ = l_.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(o_, p_);
			var t_ = l_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(r_);

			return t_;
		};
		var f_ = context.Operators;
		var g_ = f_.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var i_ = f_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(g_);

		return i_;
	}


    [CqlDeclaration("Get Paid Claims for Provided Services or Conditions")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			a_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO c_(Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse) => (((context.Operators.And((bool?)(MedicalClaimAndResponse.MedicalClaimResponse == null), (bool?)(MedicalClaimAndResponse.MedicalClaim == null)) ?? false))
			? ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))
			: (this.Get_Corresponding_Claim_for_Services_or_Conditions(MedicalClaimAndResponse.MedicalClaimResponse, MedicalClaimAndResponse.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet)))
;
		var d_ = context.Operators;
		var e_ = d_.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		var g_ = d_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(e_);

		return g_;
	}


    [CqlDeclaration("Get All Claims With Procedure Only")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_Only(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		bool? a_(Claim AllClaims)
		{
			var g_ = AllClaims.Item;
			bool? h_(Claim.ItemComponent @this)
			{
				var aa_ = @this.ProductOrService;
				var ab_ = (aa_ == null);
				var ac_ = context.Operators;
				var ad_ = ac_.Not((bool?)ab_);

				return ad_;
			};
			var i_ = context.Operators;
			var j_ = i_.WhereOrNull<Claim.ItemComponent>(g_, h_);
			CodeableConcept k_(Claim.ItemComponent @this)
			{
				var ae_ = @this.ProductOrService;

				return ae_;
			};
			var m_ = i_.SelectOrNull<Claim.ItemComponent, CodeableConcept>(j_, k_);
			bool? n_(CodeableConcept @this)
			{
				var af_ = @this.Coding;
				var ag_ = (af_ == null);
				var ah_ = context.Operators;
				var ai_ = ah_.Not((bool?)ag_);

				return ai_;
			};
			var p_ = i_.WhereOrNull<CodeableConcept>(m_, n_);
			List<Coding> q_(CodeableConcept @this)
			{
				var aj_ = @this.Coding;

				return aj_;
			};
			var s_ = i_.SelectOrNull<CodeableConcept, List<Coding>>(p_, q_);
			var u_ = i_.FlattenList<Coding>(s_);
			bool? v_(Coding ProductOrServiceCode)
			{
				var ak_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var al_ = context.Operators;
				var am_ = al_.CodeInList(ak_, ProductOrServiceValueSet);

				return am_;
			};
			var x_ = i_.WhereOrNull<Coding>(u_, v_);
			var z_ = i_.ExistsInList<Coding>(x_);

			return z_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Claim>(claim, a_);
		Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM d_(Claim AllClaims)
		{
			var an_ = AllClaims.IdElement;
			var ao_ = AllClaims.Item;
			bool? ap_(Claim.ItemComponent ResponseItem)
			{
				var at_ = ResponseItem.ProductOrService;
				var au_ = at_.Coding;
				bool? av_(Coding ProductOrServiceCode)
				{
					var ba_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var bb_ = context.Operators;
					var bc_ = bb_.CodeInList(ba_, ProductOrServiceValueSet);

					return bc_;
				};
				var aw_ = context.Operators;
				var ax_ = aw_.WhereOrNull<Coding>((au_ as IEnumerable<Coding>), av_);
				var az_ = aw_.ExistsInList<Coding>(ax_);

				return az_;
			};
			var aq_ = context.Operators;
			var ar_ = aq_.WhereOrNull<Claim.ItemComponent>((ao_ as IEnumerable<Claim.ItemComponent>), ap_);
			var as_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = AllClaims,
				ClaimID = an_,
				LineItems = ar_,
			};

			return as_;
		};
		var f_ = b_.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(c_, d_);

		return f_;
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
			var j_ = ClaimAndResponse.MedicalClaim;
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg k_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				var u_ = medClaim.LineItems;
				bool? v_(Claim.ItemComponent medClaimLineItem)
				{
					var z_ = ClaimAndResponse.PaidMedicalClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> aa_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var af_ = pClaim.LineItems;
						bool? ag_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var am_ = new CallStackEntry("ToString", null, null);
							var an_ = context.Deeper(am_);
							var ao_ = an_.Operators;
							var ap_ = ao_.TypeConverter;
							var aq_ = ap_.Convert<string>(((medClaim.ClaimofInterest is Resource)
									? ((medClaim.ClaimofInterest as Resource).IdElement)
									: (null))
);
							var ar_ = pClaim.Response;
							var as_ = ar_.Request;
							var at_ = as_.ReferenceElement;
							var av_ = context.Deeper(am_);
							var aw_ = av_.Operators;
							var ax_ = aw_.TypeConverter;
							var ay_ = ax_.Convert<string>(at_);
							var az_ = NCQAFHIRBase_1_0_0.GetId(ay_);
							var ba_ = context.Operators;
							var bb_ = ba_.Equal(aq_, az_);
							var bc_ = medClaimLineItem.SequenceElement;
							var be_ = ba_.TypeConverter;
							var bf_ = be_.Convert<Integer>(bc_);
							var bg_ = pClaimLineItem.ItemSequenceElement;
							var bi_ = ba_.TypeConverter;
							var bj_ = bi_.Convert<Integer>(bg_);
							var bl_ = ba_.Equal(bf_, bj_);
							var bn_ = ba_.And(bb_, bl_);

							return bn_;
						};
						var ah_ = context.Operators;
						var ai_ = ah_.WhereOrNull<ClaimResponse.ItemComponent>(af_, ag_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL aj_(ClaimResponse.ItemComponent pClaimLineItem) => pClaim;
						var al_ = ah_.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ai_, aj_);

						return al_;
					};
					var ab_ = context.Operators;
					var ac_ = ab_.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, aa_);
					var ae_ = ab_.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ac_);

					return ae_;
				};
				var w_ = context.Operators;
				var x_ = w_.WhereOrNull<Claim.ItemComponent>(u_, v_);
				var y_ = new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = medClaim,
					ClaimItem = x_,
				};

				return y_;
			};
			var l_ = context.Operators;
			var m_ = l_.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(j_, k_);
			var n_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = m_,
			};
			var o_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				n_,
			};
			Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO p_(Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse)
			{
				var bo_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
(((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this.ClaimItem))) ?? false))
						? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
							{
								originalClaim = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this.PaidClaim == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this.PaidClaim),
								ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem.Serviced)),
							})
						: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
,
				};
				bool? bp_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bu_ = (FinalList == null);
					var bv_ = context.Operators;
					var bw_ = bv_.Not((bool?)bu_);

					return bw_;
				};
				var bq_ = context.Operators;
				var br_ = bq_.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bo_, bp_);
				var bt_ = bq_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(br_);

				return bt_;
			};
			var r_ = l_.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(o_, p_);
			var t_ = l_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(r_);

			return t_;
		};
		var f_ = context.Operators;
		var g_ = f_.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var i_ = f_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(g_);

		return i_;
	}


    [CqlDeclaration("Get Paid Claims for Provided Services Only")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			a_,
		};
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO c_(Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse) => (((context.Operators.And((bool?)(MedicalClaimAndResponse.MedicalClaimResponse == null), (bool?)(MedicalClaimAndResponse.MedicalClaim == null)) ?? false))
			? ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))
			: (this.Get_Corresponding_Claim_for_Services_Only(MedicalClaimAndResponse.MedicalClaimResponse, MedicalClaimAndResponse.MedicalClaim, ProductOrServiceValueSet)))
;
		var d_ = context.Operators;
		var e_ = d_.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		var g_ = d_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(e_);

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
			var j_ = ClaimAndResponse.MedicalClaim;
			Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT k_(Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC medClaim)
			{
				var u_ = medClaim.LineItem;
				bool? v_(Claim.ItemComponent medClaimLineItem)
				{
					var z_ = ClaimAndResponse.PaidPharmacyClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> aa_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var af_ = pClaim.LineItems;
						bool? ag_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var am_ = new CallStackEntry("ToString", null, null);
							var an_ = context.Deeper(am_);
							var ao_ = an_.Operators;
							var ap_ = ao_.TypeConverter;
							var aq_ = ap_.Convert<string>(((medClaim.Claim is Resource)
									? ((medClaim.Claim as Resource).IdElement)
									: (null))
);
							var ar_ = pClaim.Response;
							var as_ = ar_.Request;
							var at_ = as_.ReferenceElement;
							var av_ = context.Deeper(am_);
							var aw_ = av_.Operators;
							var ax_ = aw_.TypeConverter;
							var ay_ = ax_.Convert<string>(at_);
							var az_ = NCQAFHIRBase_1_0_0.GetId(ay_);
							var ba_ = context.Operators;
							var bb_ = ba_.Equal(aq_, az_);
							var bc_ = medClaimLineItem.SequenceElement;
							var be_ = ba_.TypeConverter;
							var bf_ = be_.Convert<Integer>(bc_);
							var bg_ = pClaimLineItem.ItemSequenceElement;
							var bi_ = ba_.TypeConverter;
							var bj_ = bi_.Convert<Integer>(bg_);
							var bl_ = ba_.Equal(bf_, bj_);
							var bn_ = ba_.And(bb_, bl_);

							return bn_;
						};
						var ah_ = context.Operators;
						var ai_ = ah_.WhereOrNull<ClaimResponse.ItemComponent>(af_, ag_);
						Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL aj_(ClaimResponse.ItemComponent pClaimLineItem) => pClaim;
						var al_ = ah_.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ai_, aj_);

						return al_;
					};
					var ab_ = context.Operators;
					var ac_ = ab_.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, aa_);
					var ae_ = ab_.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ac_);

					return ae_;
				};
				var w_ = context.Operators;
				var x_ = w_.WhereOrNull<Claim.ItemComponent>(u_, v_);
				var y_ = new Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT
				{
					PaidClaim = medClaim,
					ClaimItem = x_,
				};

				return y_;
			};
			var l_ = context.Operators;
			var m_ = l_.SelectOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC, Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(j_, k_);
			var n_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB
			{
				AggregateClaim = m_,
			};
			var o_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB[]
			{
				n_,
			};
			Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO p_(Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB ClaimWithPaidResponse)
			{
				var bo_ = new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO[]
				{
(((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => context.Operators.Not((bool?)(@this.ClaimItem == null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => @this.ClaimItem))) ?? false))
						? (new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO
							{
								originalClaim = context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => context.Operators.Not((bool?)(@this.PaidClaim == null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => @this.PaidClaim),
								ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => context.Operators.Not((bool?)(@this.ClaimItem == null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => @this.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem.Serviced)),
								CoveredDays = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDate>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => context.Operators.Not((bool?)(@this.ClaimItem == null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => @this.ClaimItem)), (Claim.ItemComponent i) => (((context.Operators.Not((bool?)(i.Quantity == null)) ?? false))
										? (context.Operators.Interval(context.Operators.ConvertDateTimeToDate(context.Operators.Start(NCQAFHIRBase_1_0_0.Normalize_Interval(i.Serviced))), context.Operators.ConvertDateTimeToDate(context.Operators.Subtract(context.Operators.Add(context.Operators.Start(NCQAFHIRBase_1_0_0.Normalize_Interval(i.Serviced)), new CqlQuantity
															{
																value = FHIRHelpers_4_0_001.ToDecimal(i.Quantity.ValueElement),
																unit = "day",
															}), context.Operators.Quantity(1m, "day"))), true, true))
										: ((null as CqlInterval<CqlDate>)))
),
							})
						: ((null as Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO)))
,
				};
				bool? bp_(Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO FinalList)
				{
					var bu_ = (FinalList == null);
					var bv_ = context.Operators;
					var bw_ = bv_.Not((bool?)bu_);

					return bw_;
				};
				var bq_ = context.Operators;
				var br_ = bq_.WhereOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(bo_, bp_);
				var bt_ = bq_.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(br_);

				return bt_;
			};
			var r_ = l_.SelectOrNull<Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(o_, p_);
			var t_ = l_.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(r_);

			return t_;
		};
		var f_ = context.Operators;
		var g_ = f_.SelectOrNull<Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(d_, e_);
		var i_ = f_.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(g_);

		return i_;
	}


    [CqlDeclaration("Get Paid Claims for Pharmacy Services")]
    public Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO Get_Paid_Claims_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR[]
		{
			a_,
		};
		Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO c_(Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR PharmacyClaimAndResponse) => (((context.Operators.And((bool?)(PharmacyClaimAndResponse.PharmacyClaimResponse == null), (bool?)(PharmacyClaimAndResponse.PharmacyClaim == null)) ?? false))
			? ((null as Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO))
			: (this.Get_Corresponding_Claim_for_Pharmacy_Services(PharmacyClaimAndResponse.PharmacyClaimResponse, PharmacyClaimAndResponse.PharmacyClaim, ProductOrServiceValueSet)))
;
		var d_ = context.Operators;
		var e_ = d_.SelectOrNull<Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(b_, c_);
		var g_ = d_.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(e_);

		return g_;
	}


    [CqlDeclaration("Get Claim With Corresponding Claim Response")]
    public IEnumerable<Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI> Get_Claim_With_Corresponding_Claim_Response(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI a_(Claim Claim)
		{
			bool? d_(ClaimResponse CR)
			{
				var k_ = Claim.IdElement;
				var l_ = new CallStackEntry("ToString", null, null);
				var m_ = context.Deeper(l_);
				var n_ = m_.Operators;
				var o_ = n_.TypeConverter;
				var p_ = o_.Convert<string>(k_);
				var q_ = CR.Request;
				var r_ = q_.ReferenceElement;
				var t_ = context.Deeper(l_);
				var u_ = t_.Operators;
				var v_ = u_.TypeConverter;
				var w_ = v_.Convert<string>(r_);
				var x_ = NCQAFHIRBase_1_0_0.GetId(w_);
				var y_ = context.Operators;
				var z_ = y_.Equal(p_, x_);

				return z_;
			};
			var e_ = context.Operators;
			var f_ = e_.WhereOrNull<ClaimResponse>(claimResponse, d_);
			bool? g_(Claim C)
			{
				var aa_ = Claim.IdElement;
				var ab_ = new CallStackEntry("ToString", null, null);
				var ac_ = context.Deeper(ab_);
				var ad_ = ac_.Operators;
				var ae_ = ad_.TypeConverter;
				var af_ = ae_.Convert<string>(aa_);
				bool? ag_(ClaimResponse CR)
				{
					var bf_ = Claim.IdElement;
					var bg_ = new CallStackEntry("ToString", null, null);
					var bh_ = context.Deeper(bg_);
					var bi_ = bh_.Operators;
					var bj_ = bi_.TypeConverter;
					var bk_ = bj_.Convert<string>(bf_);
					var bl_ = CR.Request;
					var bm_ = bl_.ReferenceElement;
					var bo_ = context.Deeper(bg_);
					var bp_ = bo_.Operators;
					var bq_ = bp_.TypeConverter;
					var br_ = bq_.Convert<string>(bm_);
					var bs_ = NCQAFHIRBase_1_0_0.GetId(br_);
					var bt_ = context.Operators;
					var bu_ = bt_.Equal(bk_, bs_);

					return bu_;
				};
				var ah_ = context.Operators;
				var ai_ = ah_.WhereOrNull<ClaimResponse>(claimResponse, ag_);
				bool? aj_(ClaimResponse @this)
				{
					var bv_ = @this.Request;
					var bw_ = (bv_ == null);
					var bx_ = context.Operators;
					var by_ = bx_.Not((bool?)bw_);

					return by_;
				};
				var al_ = ah_.WhereOrNull<ClaimResponse>(ai_, aj_);
				ResourceReference am_(ClaimResponse @this)
				{
					var bz_ = @this.Request;

					return bz_;
				};
				var ao_ = ah_.SelectOrNull<ClaimResponse, ResourceReference>(al_, am_);
				bool? ap_(ResourceReference @this)
				{
					var ca_ = @this.ReferenceElement;
					var cb_ = (ca_ == null);
					var cc_ = context.Operators;
					var cd_ = cc_.Not((bool?)cb_);

					return cd_;
				};
				var ar_ = ah_.WhereOrNull<ResourceReference>(ao_, ap_);
				FhirString as_(ResourceReference @this)
				{
					var ce_ = @this.ReferenceElement;

					return ce_;
				};
				var au_ = ah_.SelectOrNull<ResourceReference, FhirString>(ar_, as_);
				var aw_ = ah_.SingleOrNull<FhirString>(au_);
				var ay_ = context.Deeper(ab_);
				var az_ = ay_.Operators;
				var ba_ = az_.TypeConverter;
				var bb_ = ba_.Convert<string>(aw_);
				var bc_ = NCQAFHIRBase_1_0_0.GetId(bb_);
				var be_ = ah_.Equal(af_, bc_);

				return be_;
			};
			var i_ = e_.WhereOrNull<Claim>(claim, g_);
			var j_ = new Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI
			{
				ClaimResponse = f_,
				OriginalClaim = i_,
			};

			return j_;
		};
		var b_ = context.Operators;
		var c_ = b_.SelectOrNull<Claim, Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI>(claim, a_);

		return c_;
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
			var i_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb
			{
				InpatientStayLineItems = (((ClaimWithInpatientStay.MedicalClaim == null))
					? ((null as IEnumerable<Claim>))
					: (context.Operators.WhereOrNull<Claim>(ClaimWithInpatientStay.MedicalClaim, (Claim c) => context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.WhereOrNull<Claim.ItemComponent>((c.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent i) => context.Operators.ExistsInList<CqlCode>(context.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(i.Revenue).codes as IEnumerable<CqlCode>), (CqlCode rev) => context.Operators.StringInValueSet(rev.code, this.Inpatient_Stay()))))))))
,
				NonacuteInpatientLineItems = (((ClaimWithInpatientStay.MedicalClaim == null))
					? ((null as IEnumerable<Claim>))
					: (context.Operators.WhereOrNull<Claim>(ClaimWithInpatientStay.MedicalClaim, (Claim c) => context.Operators.Or(context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.WhereOrNull<Claim.ItemComponent>((c.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent i) => context.Operators.ExistsInList<CqlCode>(context.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(i.Revenue).codes as IEnumerable<CqlCode>), (CqlCode rev) => context.Operators.StringInValueSet(rev.code, this.Nonacute_Inpatient_Stay()))))), context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>((c.SubType.Coding as IEnumerable<Coding>), (Coding tob) => context.Operators.StringInValueSet(tob.CodeElement.Value, this.Nonacute_Inpatient_Stay())))))))
,
			};
			var j_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb[]
			{
				i_,
			};
			Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE k_(Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb LineItemDefinition)
			{
				var p_ = LineItemDefinition.InpatientStayLineItems;
				var q_ = LineItemDefinition.NonacuteInpatientLineItems;
				IEnumerable<Claim> r_(Claim nonAcuteInpatientStay)
				{
					var ac_ = LineItemDefinition.InpatientStayLineItems;
					bool? ad_(Claim inpatientStay)
					{
						var aj_ = nonAcuteInpatientStay.IdElement;
						var ak_ = inpatientStay.IdElement;
						var al_ = context.Operators;
						var am_ = al_.Equal(aj_, ak_);

						return am_;
					};
					var ae_ = context.Operators;
					var af_ = ae_.WhereOrNull<Claim>(ac_, ad_);
					Claim ag_(Claim inpatientStay) => nonAcuteInpatientStay;
					var ai_ = ae_.SelectOrNull<Claim, Claim>(af_, ag_);

					return ai_;
				};
				var s_ = context.Operators;
				var t_ = s_.SelectManyOrNull<Claim, Claim>(q_, r_);
				IEnumerable<Claim> w_(Claim inpatientStay)
				{
					var an_ = LineItemDefinition.NonacuteInpatientLineItems;
					bool? ao_(Claim nonAcuteInpatientStay)
					{
						var au_ = inpatientStay.IdElement;
						var av_ = nonAcuteInpatientStay.IdElement;
						var aw_ = context.Operators;
						var ax_ = aw_.Equal(au_, av_);

						return ax_;
					};
					var ap_ = context.Operators;
					var aq_ = ap_.WhereOrNull<Claim>(an_, ao_);
					Claim ar_(Claim nonAcuteInpatientStay) => inpatientStay;
					var at_ = ap_.SelectOrNull<Claim, Claim>(aq_, ar_);

					return at_;
				};
				var y_ = s_.SelectManyOrNull<Claim, Claim>(p_, w_);
				var aa_ = s_.ListExcept<Claim>(p_, y_);
				var ab_ = new Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE
				{
					InpatientDischarge = p_,
					NonacuteInpatientDischarge = t_,
					AcuteInpatientDischarge = aa_,
				};

				return ab_;
			};
			var l_ = context.Operators;
			var m_ = l_.SelectOrNull<Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb, Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(j_, k_);
			var o_ = l_.SingleOrNull<Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(m_);

			return o_;
		};
		var e_ = context.Operators;
		var f_ = e_.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(c_, d_);
		var h_ = e_.SingleOrNull<Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(f_);

		return h_;
	}


    [CqlDeclaration("Get Prescriber NPI from Claims")]
    public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Prescriber_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS a_(Claim C)
		{
			var k_ = C.CareTeam;
			bool? l_(Claim.CareTeamComponent ct)
			{
				var ai_ = ct.SequenceElement;
				var aj_ = context.Operators;
				var ak_ = aj_.TypeConverter;
				var al_ = ak_.Convert<Integer>(ai_);
				var am_ = FHIRHelpers_4_0_001.ToInteger(al_);
				var ao_ = aj_.Equal(am_, (int?)1);

				return ao_;
			};
			var m_ = context.Operators;
			var n_ = m_.WhereOrNull<Claim.CareTeamComponent>((k_ as IEnumerable<Claim.CareTeamComponent>), l_);
			bool? o_(Claim.CareTeamComponent @this)
			{
				var ap_ = @this.Provider;
				var aq_ = (ap_ == null);
				var ar_ = context.Operators;
				var as_ = ar_.Not((bool?)aq_);

				return as_;
			};
			var q_ = m_.WhereOrNull<Claim.CareTeamComponent>(n_, o_);
			ResourceReference r_(Claim.CareTeamComponent @this)
			{
				var at_ = @this.Provider;

				return at_;
			};
			var t_ = m_.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(q_, r_);
			bool? v_(Claim.CareTeamComponent ct)
			{
				var au_ = ct.SequenceElement;
				var av_ = context.Operators;
				var aw_ = av_.TypeConverter;
				var ax_ = aw_.Convert<Integer>(au_);
				var ay_ = FHIRHelpers_4_0_001.ToInteger(ax_);
				var ba_ = av_.Equal(ay_, (int?)1);

				return ba_;
			};
			var x_ = m_.WhereOrNull<Claim.CareTeamComponent>((k_ as IEnumerable<Claim.CareTeamComponent>), v_);
			bool? y_(Claim.CareTeamComponent @this)
			{
				var bb_ = @this.Provider;
				var bc_ = (bb_ == null);
				var bd_ = context.Operators;
				var be_ = bd_.Not((bool?)bc_);

				return be_;
			};
			var aa_ = m_.WhereOrNull<Claim.CareTeamComponent>(x_, y_);
			ResourceReference ab_(Claim.CareTeamComponent @this)
			{
				var bf_ = @this.Provider;

				return bf_;
			};
			var ad_ = m_.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(aa_, ab_);
			string ae_(ResourceReference p)
			{
				var bg_ = p.ReferenceElement;
				var bh_ = new FhirString[]
				{
					bg_,
				};
				string bi_(FhirString r)
				{
					var bn_ = new CallStackEntry("ToString", null, null);
					var bo_ = context.Deeper(bn_);
					var bp_ = bo_.Operators;
					var bq_ = bp_.TypeConverter;
					var br_ = bq_.Convert<string>(r);
					var bs_ = NCQAFHIRBase_1_0_0.GetId(br_);

					return bs_;
				};
				var bj_ = context.Operators;
				var bk_ = bj_.SelectOrNull<FhirString, string>(bh_, bi_);
				var bm_ = bj_.SingleOrNull<string>(bk_);

				return bm_;
			};
			var ag_ = m_.SelectOrNull<ResourceReference, string>(ad_, ae_);
			var ah_ = new Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS
			{
				SingleCareTeam = C,
				CareTeamsProvider = t_,
				CareTeamsProviderID = ag_,
			};

			return ah_;
		};
		var b_ = context.Operators;
		var c_ = b_.SelectOrNull<Claim, Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(claim, a_);
		var d_ = new Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR
		{
			CareTeams = c_,
		};
		var e_ = new Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR[]
		{
			d_,
		};
		Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY f_(Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR ClaimProperties)
		{
			var bt_ = context.DataRetriever;
			var bu_ = bt_.RetrieveByValueSet<Practitioner>(null, null);
			bool? bv_(Practitioner p)
			{
				var cf_ = p.IdElement;
				var cg_ = new CallStackEntry("ToString", null, null);
				var ch_ = context.Deeper(cg_);
				var ci_ = ch_.Operators;
				var cj_ = ci_.TypeConverter;
				var ck_ = cj_.Convert<string>(cf_);
				var cl_ = ClaimProperties.CareTeams;
				bool? cm_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
				{
					var cw_ = @this.CareTeamsProviderID;
					var cx_ = (cw_ == null);
					var cy_ = context.Operators;
					var cz_ = cy_.Not((bool?)cx_);

					return cz_;
				};
				var cn_ = context.Operators;
				var co_ = cn_.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(cl_, cm_);
				IEnumerable<string> cp_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
				{
					var da_ = @this.CareTeamsProviderID;

					return da_;
				};
				var cr_ = cn_.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, IEnumerable<string>>(co_, cp_);
				var ct_ = cn_.FlattenList<string>(cr_);
				var cv_ = cn_.InList<string>(ck_, ct_);

				return cv_;
			};
			var bw_ = context.Operators;
			var bx_ = bw_.WhereOrNull<Practitioner>(bu_, bv_);
			var by_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe
			{
				Practitioners = bx_,
			};
			var bz_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe[]
			{
				by_,
			};
			Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY ca_(Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe PractitionerMatch)
			{
				var db_ = PractitionerMatch.Practitioners;
				bool? dc_(Practitioner P)
				{
					var dp_ = (P == null);
					var dq_ = context.Operators;
					var dr_ = dq_.Not((bool?)dp_);

					return dr_;
				};
				var dd_ = context.Operators;
				var de_ = dd_.WhereOrNull<Practitioner>(db_, dc_);
				Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR df_(Practitioner P)
				{
					var ds_ = P.Identifier;
					bool? dt_(Identifier l)
					{
						var eh_ = l.SystemElement;
						var ei_ = eh_.Value;
						var ej_ = context.Operators;
						var ek_ = ej_.Equal(ei_, "http://hl7.org/fhir/sid/us-npi");
						var el_ = l.Type;
						var em_ = FHIRHelpers_4_0_001.ToConcept(el_);
						var en_ = NCQATerminology_1_0_0.Provider_number();
						var ep_ = ej_.ConvertCodeToConcept(en_);
						var er_ = ej_.Equivalent(em_, ep_);
						var et_ = ej_.And(ek_, er_);
						var eu_ = l.ValueElement;
						var ev_ = eu_.Value;
						var ew_ = (ev_ == null);
						var ey_ = ej_.Not((bool?)ew_);
						var fa_ = ej_.And(et_, ey_);

						return fa_;
					};
					var du_ = context.Operators;
					var dv_ = du_.WhereOrNull<Identifier>((ds_ as IEnumerable<Identifier>), dt_);
					FhirString dw_(Identifier l)
					{
						var fb_ = l.ValueElement;

						return fb_;
					};
					var dy_ = du_.SelectOrNull<Identifier, FhirString>(dv_, dw_);
					bool? ea_(Identifier l)
					{
						var fc_ = l.SystemElement;
						var fd_ = fc_.Value;
						var fe_ = context.Operators;
						var ff_ = fe_.Equal(fd_, "http://hl7.org/fhir/sid/us-npi");
						var fg_ = l.Type;
						var fh_ = FHIRHelpers_4_0_001.ToConcept(fg_);
						var fi_ = NCQATerminology_1_0_0.Provider_number();
						var fk_ = fe_.ConvertCodeToConcept(fi_);
						var fm_ = fe_.Equivalent(fh_, fk_);
						var fo_ = fe_.And(ff_, fm_);
						var fp_ = l.ValueElement;
						var fq_ = fp_.Value;
						var fr_ = (fq_ == null);
						var ft_ = fe_.And(fo_, (bool?)fr_);

						return ft_;
					};
					var ec_ = du_.WhereOrNull<Identifier>((ds_ as IEnumerable<Identifier>), ea_);
					Identifier ed_(Identifier l) => l;
					var ef_ = du_.SelectOrNull<Identifier, Identifier>(ec_, ed_);
					var eg_ = new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = dy_,
						NullIdentifiers = ef_,
					};

					return eg_;
				};
				var dh_ = dd_.SelectOrNull<Practitioner, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(de_, df_);
				var di_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = dh_,
				};
				var dj_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					di_,
				};
				Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY dk_(Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers)
				{
					var fu_ = new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = (((context.Operators.ExistsInList<Claim>(context.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => context.Operators.Not((bool?)(@this.SingleCareTeam == null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this.SingleCareTeam)) ?? false))
							? (context.Operators.Add(context.Operators.Add(context.Operators.CountOrNull<Claim>(context.Operators.WhereOrNull<Claim>(context.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => context.Operators.Not((bool?)(@this.SingleCareTeam == null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this.SingleCareTeam), (Claim X) => (bool?)((X.CareTeam as IEnumerable<Claim.CareTeamComponent>) == null))), context.Operators.CountOrNull<FhirString>(context.Operators.SelectOrNull<FhirString, FhirString>(context.Operators.FlattenList<FhirString>(context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X.AllIdentifiers)), (FhirString X) => X))), context.Operators.CountOrNull<Identifier>(context.Operators.FlattenList<Identifier>(context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X.NullIdentifiers)))))
							: ((int?)0))
,
					};

					return fu_;
				};
				var dm_ = dd_.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dj_, dk_);
				var do_ = dd_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dm_);

				return do_;
			};
			var cc_ = bw_.SelectOrNull<Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bz_, ca_);
			var ce_ = bw_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cc_);

			return ce_;
		};
		var h_ = b_.SelectOrNull<Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(e_, f_);
		var j_ = b_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(h_);

		return j_;
	}


    [CqlDeclaration("Get Pharmacy NPI from Claims")]
    public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Pharmacy_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI a_(Claim C)
		{
			var k_ = C.Item;
			bool? m_(Claim.ItemComponent i)
			{
				var am_ = i.SequenceElement;
				var an_ = context.Operators;
				var ao_ = an_.TypeConverter;
				var ap_ = ao_.Convert<Integer>(am_);
				var aq_ = FHIRHelpers_4_0_001.ToInteger(ap_);
				var as_ = an_.Equal(aq_, (int?)1);

				return as_;
			};
			var n_ = context.Operators;
			var o_ = n_.WhereOrNull<Claim.ItemComponent>((k_ as IEnumerable<Claim.ItemComponent>), m_);
			bool? p_(Claim.ItemComponent @this)
			{
				var at_ = @this.Location;
				var au_ = (at_ == null);
				var av_ = context.Operators;
				var aw_ = av_.Not((bool?)au_);

				return aw_;
			};
			var r_ = n_.WhereOrNull<Claim.ItemComponent>(o_, p_);
			DataType s_(Claim.ItemComponent @this)
			{
				var ax_ = @this.Location;

				return ax_;
			};
			var u_ = n_.SelectOrNull<Claim.ItemComponent, DataType>(r_, s_);
			ResourceReference v_(DataType l) => (l as ResourceReference);
			var x_ = n_.SelectOrNull<DataType, ResourceReference>(u_, v_);
			bool? z_(Claim.ItemComponent i)
			{
				var ay_ = i.SequenceElement;
				var az_ = context.Operators;
				var ba_ = az_.TypeConverter;
				var bb_ = ba_.Convert<Integer>(ay_);
				var bc_ = FHIRHelpers_4_0_001.ToInteger(bb_);
				var be_ = az_.Equal(bc_, (int?)1);

				return be_;
			};
			var ab_ = n_.WhereOrNull<Claim.ItemComponent>((k_ as IEnumerable<Claim.ItemComponent>), z_);
			bool? ac_(Claim.ItemComponent @this)
			{
				var bf_ = @this.Location;
				var bg_ = (bf_ == null);
				var bh_ = context.Operators;
				var bi_ = bh_.Not((bool?)bg_);

				return bi_;
			};
			var ae_ = n_.WhereOrNull<Claim.ItemComponent>(ab_, ac_);
			DataType af_(Claim.ItemComponent @this)
			{
				var bj_ = @this.Location;

				return bj_;
			};
			var ah_ = n_.SelectOrNull<Claim.ItemComponent, DataType>(ae_, af_);
			string ai_(DataType l)
			{
				var bk_ = (l as ResourceReference).ReferenceElement;
				var bl_ = new FhirString[]
				{
					bk_,
				};
				string bm_(FhirString r)
				{
					var br_ = new CallStackEntry("ToString", null, null);
					var bs_ = context.Deeper(br_);
					var bt_ = bs_.Operators;
					var bu_ = bt_.TypeConverter;
					var bv_ = bu_.Convert<string>(r);
					var bw_ = NCQAFHIRBase_1_0_0.GetId(bv_);

					return bw_;
				};
				var bn_ = context.Operators;
				var bo_ = bn_.SelectOrNull<FhirString, string>(bl_, bm_);
				var bq_ = bn_.SingleOrNull<string>(bo_);

				return bq_;
			};
			var ak_ = n_.SelectOrNull<DataType, string>(ah_, ai_);
			var al_ = new Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI
			{
				SingleItem = (k_ as IEnumerable<Claim.ItemComponent>),
				ItemLocation = x_,
				ItemLocationID = ak_,
			};

			return al_;
		};
		var b_ = context.Operators;
		var c_ = b_.SelectOrNull<Claim, Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(claim, a_);
		var d_ = new Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa
		{
			ItemsLocationReferences = c_,
		};
		var e_ = new Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa[]
		{
			d_,
		};
		Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY f_(Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa ClaimProperties)
		{
			var bx_ = context.DataRetriever;
			var by_ = bx_.RetrieveByValueSet<Location>(null, null);
			bool? bz_(Location l)
			{
				var cj_ = l.IdElement;
				var ck_ = new CallStackEntry("ToString", null, null);
				var cl_ = context.Deeper(ck_);
				var cm_ = cl_.Operators;
				var cn_ = cm_.TypeConverter;
				var co_ = cn_.Convert<string>(cj_);
				var cp_ = ClaimProperties.ItemsLocationReferences;
				bool? cq_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
				{
					var da_ = @this.ItemLocationID;
					var db_ = (da_ == null);
					var dc_ = context.Operators;
					var dd_ = dc_.Not((bool?)db_);

					return dd_;
				};
				var cr_ = context.Operators;
				var cs_ = cr_.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(cp_, cq_);
				IEnumerable<string> ct_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
				{
					var de_ = @this.ItemLocationID;

					return de_;
				};
				var cv_ = cr_.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<string>>(cs_, ct_);
				var cx_ = cr_.FlattenList<string>(cv_);
				var cz_ = cr_.InList<string>(co_, cx_);

				return cz_;
			};
			var ca_ = context.Operators;
			var cb_ = ca_.WhereOrNull<Location>(by_, bz_);
			var cc_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP
			{
				CorrespondingLocations = cb_,
			};
			var cd_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP[]
			{
				cc_,
			};
			Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY ce_(Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP GetLocation)
			{
				var df_ = GetLocation.CorrespondingLocations;
				bool? dg_(Location C)
				{
					var dt_ = (C == null);
					var du_ = context.Operators;
					var dv_ = du_.Not((bool?)dt_);

					return dv_;
				};
				var dh_ = context.Operators;
				var di_ = dh_.WhereOrNull<Location>(df_, dg_);
				Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR dj_(Location C)
				{
					var dw_ = C.Identifier;
					bool? dx_(Identifier l)
					{
						var el_ = l.SystemElement;
						var em_ = el_.Value;
						var en_ = context.Operators;
						var eo_ = en_.Equal(em_, "http://hl7.org/fhir/sid/us-npi");
						var ep_ = l.Type;
						var eq_ = FHIRHelpers_4_0_001.ToConcept(ep_);
						var er_ = NCQATerminology_1_0_0.Provider_number();
						var et_ = en_.ConvertCodeToConcept(er_);
						var ev_ = en_.Equivalent(eq_, et_);
						var ex_ = en_.And(eo_, ev_);
						var ey_ = l.ValueElement;
						var ez_ = ey_.Value;
						var fa_ = (ez_ == null);
						var fc_ = en_.Not((bool?)fa_);
						var fe_ = en_.And(ex_, fc_);

						return fe_;
					};
					var dy_ = context.Operators;
					var dz_ = dy_.WhereOrNull<Identifier>((dw_ as IEnumerable<Identifier>), dx_);
					FhirString ea_(Identifier l)
					{
						var ff_ = l.ValueElement;

						return ff_;
					};
					var ec_ = dy_.SelectOrNull<Identifier, FhirString>(dz_, ea_);
					bool? ee_(Identifier l)
					{
						var fg_ = l.SystemElement;
						var fh_ = fg_.Value;
						var fi_ = context.Operators;
						var fj_ = fi_.Equal(fh_, "http://hl7.org/fhir/sid/us-npi");
						var fk_ = l.Type;
						var fl_ = FHIRHelpers_4_0_001.ToConcept(fk_);
						var fm_ = NCQATerminology_1_0_0.Provider_number();
						var fo_ = fi_.ConvertCodeToConcept(fm_);
						var fq_ = fi_.Equivalent(fl_, fo_);
						var fs_ = fi_.And(fj_, fq_);
						var ft_ = l.ValueElement;
						var fu_ = ft_.Value;
						var fv_ = (fu_ == null);
						var fx_ = fi_.And(fs_, (bool?)fv_);

						return fx_;
					};
					var eg_ = dy_.WhereOrNull<Identifier>((dw_ as IEnumerable<Identifier>), ee_);
					Identifier eh_(Identifier l) => l;
					var ej_ = dy_.SelectOrNull<Identifier, Identifier>(eg_, eh_);
					var ek_ = new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = ec_,
						NullIdentifiers = ej_,
					};

					return ek_;
				};
				var dl_ = dh_.SelectOrNull<Location, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(di_, dj_);
				var dm_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = dl_,
				};
				var dn_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					dm_,
				};
				Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY do_(Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers)
				{
					var fy_ = new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = (((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => context.Operators.Not((bool?)(@this.SingleItem == null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this.SingleItem))) ?? false))
							? (context.Operators.Add(context.Operators.Add(context.Operators.CountOrNull<ResourceReference>(context.Operators.WhereOrNull<ResourceReference>(context.Operators.FlattenList<ResourceReference>(context.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<ResourceReference>>(context.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => context.Operators.Not((bool?)(@this.ItemLocation == null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this.ItemLocation)), (ResourceReference X) => (bool?)(X.ReferenceElement.Value == null))), context.Operators.CountOrNull<FhirString>(context.Operators.SelectOrNull<FhirString, FhirString>(context.Operators.FlattenList<FhirString>(context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X.AllIdentifiers)), (FhirString X) => X))), context.Operators.CountOrNull<Identifier>(context.Operators.FlattenList<Identifier>(context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X.NullIdentifiers)))))
							: ((int?)0))
,
					};

					return fy_;
				};
				var dq_ = dh_.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dn_, do_);
				var ds_ = dh_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dq_);

				return ds_;
			};
			var cg_ = ca_.SelectOrNull<Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cd_, ce_);
			var ci_ = ca_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cg_);

			return ci_;
		};
		var h_ = b_.SelectOrNull<Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(e_, f_);
		var j_ = b_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(h_);

		return j_;
	}


}
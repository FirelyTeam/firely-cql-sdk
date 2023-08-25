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

    private CqlValueSet Inpatient_Stay_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395", null);

		return a_;
	}

    [CqlDeclaration("Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395")]
    public CqlValueSet Inpatient_Stay() => __Inpatient_Stay.Value;

    private CqlValueSet Nonacute_Inpatient_Stay_Value()
	{
		var a_ = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398", null);

		return a_;
	}

    [CqlDeclaration("Nonacute Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398")]
    public CqlValueSet Nonacute_Inpatient_Stay() => __Nonacute_Inpatient_Stay.Value;

    [CqlDeclaration("Professional or Institutional Claims")]
    public IEnumerable<Claim> Professional_or_Institutional_Claims(IEnumerable<Claim> claim)
	{
		var a_ = (Claim MedicalClaim) =>
		{
			var d_ = MedicalClaim.Type;
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var f_ = e_.codes;
			var g_ = (f_ as IEnumerable<CqlCode>);
			var h_ = NCQATerminology_1_0_0.Professional();
			var i_ = context.Operators;
			var j_ = i_.ListContains<CqlCode>(g_, h_);
			var l_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var m_ = l_.codes;
			var n_ = (m_ as IEnumerable<CqlCode>);
			var o_ = NCQATerminology_1_0_0.Institutional();
			var q_ = i_.ListContains<CqlCode>(n_, o_);
			var s_ = i_.Or(j_, q_);

			return s_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Claim>(claim, a_);

		return c_;
	}


    [CqlDeclaration("Pharmacy Claims")]
    public IEnumerable<Claim> Pharmacy_Claims(IEnumerable<Claim> claim)
	{
		var a_ = (Claim PharmacyClaim) =>
		{
			var d_ = PharmacyClaim.Type;
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var f_ = e_.codes;
			var g_ = (f_ as IEnumerable<CqlCode>);
			var h_ = NCQATerminology_1_0_0.Pharmacy();
			var i_ = context.Operators;
			var j_ = i_.ListContains<CqlCode>(g_, h_);

			return j_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Claim>(claim, a_);

		return c_;
	}


    [CqlDeclaration("Professional or Institutional Claims Response")]
    public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		var a_ = (ClaimResponse MedicalResponse) =>
		{
			var d_ = MedicalResponse.Type;
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var f_ = e_.codes;
			var g_ = (f_ as IEnumerable<CqlCode>);
			var h_ = NCQATerminology_1_0_0.Professional();
			var i_ = context.Operators;
			var j_ = i_.ListContains<CqlCode>(g_, h_);
			var l_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var m_ = l_.codes;
			var n_ = (m_ as IEnumerable<CqlCode>);
			var o_ = NCQATerminology_1_0_0.Institutional();
			var q_ = i_.ListContains<CqlCode>(n_, o_);
			var s_ = i_.Or(j_, q_);

			return s_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<ClaimResponse>(claimResponse, a_);

		return c_;
	}


    [CqlDeclaration("Pharmacy Claims Response")]
    public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		var a_ = (ClaimResponse PharmacyResponse) =>
		{
			var d_ = PharmacyResponse.Type;
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var f_ = e_.codes;
			var g_ = (f_ as IEnumerable<CqlCode>);
			var h_ = NCQATerminology_1_0_0.Pharmacy();
			var i_ = context.Operators;
			var j_ = i_.ListContains<CqlCode>(g_, h_);

			return j_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<ClaimResponse>(claimResponse, a_);

		return c_;
	}


    [CqlDeclaration("Medical Claims With Procedure and POS")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_and_POS(IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		var b_ = (CqlCode p) =>
		{
			var o_ = p.code;

			return o_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, b_);
		var e_ = (CqlCode pos) =>
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
		var j_ = (Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithPosCode) =>
		{
			var q_ = ClaimWithPosCode.MedicalClaim;
			var r_ = (Claim ClaimofInterest) =>
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
				var z_ = (Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition) => (((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition.LineItems) ?? false))
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
			var u_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
			{
				var ae_ = (FinalList == null);
				var af_ = (bool?)ae_;
				var ag_ = context.Operators;
				var ah_ = ag_.Not(af_);

				return ah_;
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
		var b_ = (CqlCode p) =>
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
		var g_ = (Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithProcedure) =>
		{
			var m_ = ClaimWithProcedure.MedicalClaim;
			var n_ = (Claim ClaimofInterest) =>
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
				var v_ = (Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition) => (((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition.LineItems) ?? false))
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
			var q_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
			{
				var aa_ = (FinalList == null);
				var ab_ = (bool?)aa_;
				var ac_ = context.Operators;
				var ad_ = ac_.Not(ab_);

				return ad_;
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
		var b_ = (CqlCode d) =>
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
		var g_ = (Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis) =>
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
			var o_ = (Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg HeaderDefinition) =>
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
				var u_ = (Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList) =>
				{
					var z_ = (FinalList == null);
					var aa_ = (bool?)z_;
					var ab_ = context.Operators;
					var ac_ = ab_.Not(aa_);

					return ac_;
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
		var b_ = (CqlCode p) =>
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
		var g_ = (Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY ClaimWithMedication) =>
		{
			var m_ = ClaimWithMedication.PharmacyClaim;
			var n_ = (Claim Pharmacy) =>
			{
				var t_ = Pharmacy.Item;
				var u_ = (t_ as IEnumerable<Claim.ItemComponent>);
				var v_ = (Claim.ItemComponent ItemOnLine) =>
				{
					var af_ = ItemOnLine.ProductOrService;
					var ag_ = FHIRHelpers_4_0_001.ToConcept(af_);
					var ah_ = ag_.codes;
					var ai_ = (ah_ as IEnumerable<CqlCode>);
					var aj_ = (CqlCode LineCode) =>
					{
						var ao_ = LineCode.code;
						var ap_ = ClaimWithMedication.MedicationsAsStrings;
						var aq_ = context.Operators;
						var ar_ = aq_.InList<string>(ao_, ap_);

						return ar_;
					};
					var ak_ = context.Operators;
					var al_ = ak_.WhereOrNull<CqlCode>(ai_, aj_);
					var an_ = ak_.ExistsInList<CqlCode>(al_);

					return an_;
				};
				var w_ = context.Operators;
				var x_ = w_.WhereOrNull<Claim.ItemComponent>(u_, v_);
				var y_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = Pharmacy,
					LineItems = x_,
				};
				var z_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					y_,
				};
				var aa_ = (Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition) =>
				{
					var as_ = LineItemDefinition.Claim;
					var at_ = new Claim[]
					{
						as_,
					};
					var au_ = (Claim ClaimLines) =>
					{
						var az_ = ClaimLines.Item;
						var ba_ = (az_ as IEnumerable<Claim.ItemComponent>);
						var bb_ = (Claim.ItemComponent i) =>
						{
							var bo_ = i.ProductOrService;
							var bp_ = FHIRHelpers_4_0_001.ToConcept(bo_);
							var bq_ = bp_.codes;
							var br_ = (bq_ as IEnumerable<CqlCode>);
							var bs_ = (CqlCode LineCode) =>
							{
								var bx_ = LineCode.code;
								var by_ = ClaimWithMedication.MedicationsAsStrings;
								var bz_ = context.Operators;
								var ca_ = bz_.InList<string>(bx_, by_);

								return ca_;
							};
							var bt_ = context.Operators;
							var bu_ = bt_.WhereOrNull<CqlCode>(br_, bs_);
							var bw_ = bt_.ExistsInList<CqlCode>(bu_);

							return bw_;
						};
						var bc_ = context.Operators;
						var bd_ = bc_.WhereOrNull<Claim.ItemComponent>(ba_, bb_);
						var be_ = (Claim.ItemComponent i) =>
						{
							var cb_ = new Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP
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

							return cb_;
						};
						var bg_ = bc_.SelectOrNull<Claim.ItemComponent, Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP>(bd_, be_);
						var bh_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU
						{
							CoveredDays = bg_,
						};
						var bi_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU[]
						{
							bh_,
						};
						var bj_ = (Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU ItemCalculation) => (((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition.LineItems) ?? false))
							? (new Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC
								{
									Claim = LineItemDefinition.Claim,
									LineItem = LineItemDefinition.LineItems,
									ServicePeriod = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition.LineItems, (Claim.ItemComponent @this) => context.Operators.Not((bool?)(@this.Serviced == null))), (Claim.ItemComponent @this) => @this.Serviced), (DataType NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
									CoveredDays = context.Operators.SelectOrNull<Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP, CqlInterval<CqlDateTime>>(ItemCalculation.CoveredDays, (Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP d) => d.DaysSupplyInterval),
								})
							: ((null as Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC)))
;
						var bl_ = bc_.SelectOrNull<Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(bi_, bj_);
						var bn_ = bc_.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(bl_);

						return bn_;
					};
					var av_ = context.Operators;
					var aw_ = av_.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(at_, au_);
					var ay_ = av_.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(aw_);

					return ay_;
				};
				var ac_ = w_.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(z_, aa_);
				var ae_ = w_.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ac_);

				return ae_;
			};
			var o_ = context.Operators;
			var p_ = o_.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(m_, n_);
			var q_ = (Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC FinalList) =>
			{
				var cc_ = (FinalList == null);
				var cd_ = (bool?)cc_;
				var ce_ = context.Operators;
				var cf_ = ce_.Not(cd_);

				return cf_;
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
		var b_ = (CqlCode d) =>
		{
			var o_ = d.code;

			return o_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		var e_ = (CqlCode p) =>
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
		var j_ = (Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithDiagnosis) =>
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
			var s_ = (Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg ClaimWithProcedure) =>
			{
				var x_ = ClaimWithProcedure.DiagnosisItems;
				var y_ = (Claim ClaimofInterest) =>
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
					var ag_ = (Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU HeaderDefinition) => (((context.Operators.Not((bool?)(HeaderDefinition.ProcedureItems == null)) ?? false))
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
				var ab_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
				{
					var al_ = (FinalList == null);
					var am_ = (bool?)al_;
					var an_ = context.Operators;
					var ao_ = an_.Not(am_);

					return ao_;
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
		var b_ = (CqlCode d) =>
		{
			var o_ = d.code;

			return o_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		var e_ = (CqlCode p) =>
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
		var j_ = (Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithProcedure) =>
		{
			var q_ = ClaimWithProcedure.MedicalClaim;
			var r_ = (Claim ClaimofInterest) =>
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
				var z_ = (Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB DiagnosisCheck) =>
				{
					var ae_ = DiagnosisCheck.ProcedureItems;
					var af_ = new Claim[]
					{
						ae_,
					};
					var ag_ = (Claim ClaimforDiagnosis) =>
					{
						var al_ = ClaimforDiagnosis.Item;
						var am_ = (al_ as IEnumerable<Claim.ItemComponent>);
						var an_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI
						{
							Procedure = am_,
							LineItems = (((ClaimforDiagnosis == null))
								? (null)
								: (context.Operators.SingleOrNull<Claim>(context.Operators.WhereOrNull<Claim>(new Claim[]
											{
												ClaimforDiagnosis,
											}, (Claim RightClaim) => context.Operators.ExistsInList<Claim.DiagnosisComponent>(context.Operators.WhereOrNull<Claim.DiagnosisComponent>((RightClaim.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent RightDiagnosis) => context.Operators.And(context.Operators.Equal(FHIRHelpers_4_0_001.ToInteger(context.Operators.TypeConverter.Convert<Integer>(RightDiagnosis.SequenceElement)), (int?)1), context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.LateBoundProperty<IEnumerable<Coding>>(RightDiagnosis.Diagnosis, "coding"), (Coding DiagnosisCode) => context.Operators.InList<string>(DiagnosisCode.CodeElement.Value, ClaimWithProcedure.DiagnosesAsStrings))))))))))
,
						};
						var ao_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI[]
						{
							an_,
						};
						var ap_ = (Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI LineItemDefinition) => (((context.Operators.And(context.Operators.Not((bool?)(LineItemDefinition == null)), context.Operators.Not((bool?)(LineItemDefinition.LineItems == null))) ?? false))
							? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
								{
									Claim = LineItemDefinition.LineItems,
									ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((LineItemDefinition.LineItems.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate.Serviced)),
								})
							: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)))
;
						var aq_ = context.Operators;
						var ar_ = aq_.SelectOrNull<Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ao_, ap_);
						var at_ = aq_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ar_);

						return at_;
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
			var u_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
			{
				var au_ = (FinalList == null);
				var av_ = (bool?)au_;
				var aw_ = context.Operators;
				var ax_ = aw_.Not(av_);

				return ax_;
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
		var b_ = (CqlCode d) =>
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
		var g_ = (Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis) =>
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
			var o_ = (Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN LineItemDefinition) =>
			{
				var t_ = LineItemDefinition.LineItems;
				var u_ = (Claim ClaimWithDiagnosis) => (((context.Operators.Not((bool?)(ClaimWithDiagnosis == null)) ?? false))
					? (new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = LineItemDefinition.LineItems,
							ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(context.Operators.WhereOrNull<Claim>(LineItemDefinition.LineItems, (Claim @this) => context.Operators.Not((bool?)(@this.Item == null))), (Claim @this) => @this.Item)), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate.Serviced)),
						})
					: ((null as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI)))
;
				var v_ = context.Operators;
				var w_ = v_.SelectOrNull<Claim, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(t_, u_);
				var x_ = (Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList) =>
				{
					var aa_ = (FinalList == null);
					var ab_ = (bool?)aa_;
					var ac_ = context.Operators;
					var ad_ = ac_.Not(ab_);

					return ad_;
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
		var a_ = (ClaimResponse ResponseItem) =>
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
			var r_ = (q_ as IEnumerable<string>);
			var s_ = context.Operators;
			var t_ = s_.InList<string>(p_, r_);

			return t_;
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
		var f_ = (Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD ClaimResponse) =>
		{
			var u_ = ClaimResponse.PaidResponse;
			var v_ = (ClaimResponse ClmResp) =>
			{
				var y_ = ClmResp.Request;
				var z_ = y_.ReferenceElement;
				var aa_ = new CallStackEntry("ToString", null, null);
				var ab_ = context.Deeper(aa_);
				var ac_ = ab_.Operators;
				var ad_ = ac_.TypeConverter;
				var ae_ = ad_.Convert<string>(z_);
				var af_ = NCQAFHIRBase_1_0_0.GetId(ae_);
				var ag_ = ClmResp.Item;
				var ah_ = (ag_ as IEnumerable<ClaimResponse.ItemComponent>);
				var ai_ = (ClaimResponse.ItemComponent ResponseItem) =>
				{
					var am_ = ResponseItem.Adjudication;
					var an_ = (ClaimResponse.AdjudicationComponent @this) =>
					{
						var bu_ = @this.Category;
						var bv_ = (bu_ == null);
						var bw_ = (bool?)bv_;
						var bx_ = context.Operators;
						var by_ = bx_.Not(bw_);

						return by_;
					};
					var ao_ = context.Operators;
					var ap_ = ao_.WhereOrNull<ClaimResponse.AdjudicationComponent>(am_, an_);
					var aq_ = (ClaimResponse.AdjudicationComponent @this) =>
					{
						var bz_ = @this.Category;

						return bz_;
					};
					var as_ = ao_.SelectOrNull<ClaimResponse.AdjudicationComponent, CodeableConcept>(ap_, aq_);
					var at_ = (CodeableConcept @this) =>
					{
						var ca_ = @this.Coding;
						var cb_ = (ca_ == null);
						var cc_ = (bool?)cb_;
						var cd_ = context.Operators;
						var ce_ = cd_.Not(cc_);

						return ce_;
					};
					var av_ = ao_.WhereOrNull<CodeableConcept>(as_, at_);
					var aw_ = (CodeableConcept @this) =>
					{
						var cf_ = @this.Coding;

						return cf_;
					};
					var ay_ = ao_.SelectOrNull<CodeableConcept, List<Coding>>(av_, aw_);
					var ba_ = ao_.FlattenList<Coding>(ay_);
					var bb_ = (Coding CategoryItem) =>
					{
						var cg_ = CategoryItem.CodeElement;
						var ch_ = cg_.Value;
						var ci_ = context.Operators;
						var cj_ = ci_.Equal(ch_, "benefit");

						return cj_;
					};
					var bd_ = ao_.WhereOrNull<Coding>(ba_, bb_);
					var bf_ = ao_.ExistsInList<Coding>(bd_);
					var bh_ = (ClaimResponse.AdjudicationComponent @this) =>
					{
						var ck_ = @this.Amount;
						var cl_ = (ck_ == null);
						var cm_ = (bool?)cl_;
						var cn_ = context.Operators;
						var co_ = cn_.Not(cm_);

						return co_;
					};
					var bj_ = ao_.WhereOrNull<ClaimResponse.AdjudicationComponent>(am_, bh_);
					var bk_ = (ClaimResponse.AdjudicationComponent @this) =>
					{
						var cp_ = @this.Amount;

						return cp_;
					};
					var bm_ = ao_.SelectOrNull<ClaimResponse.AdjudicationComponent, Money>(bj_, bk_);
					var bn_ = (Money DollarAmount) =>
					{
						var cq_ = DollarAmount.ValueElement;
						var cr_ = FHIRHelpers_4_0_001.ToDecimal(cq_);
						var cs_ = cr_;
						var ct_ = (int?)0;
						var cu_ = context.Operators;
						var cv_ = cu_.ConvertIntegerToDecimal(ct_);
						var cw_ = cv_;
						var cy_ = cu_.Greater(cs_, cw_);

						return cy_;
					};
					var bp_ = ao_.WhereOrNull<Money>(bm_, bn_);
					var br_ = ao_.ExistsInList<Money>(bp_);
					var bt_ = ao_.And(bf_, br_);

					return bt_;
				};
				var aj_ = context.Operators;
				var ak_ = aj_.WhereOrNull<ClaimResponse.ItemComponent>(ah_, ai_);
				var al_ = new Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL
				{
					Response = ClmResp,
					ResponseID = af_,
					LineItems = ak_,
				};

				return al_;
			};
			var w_ = context.Operators;
			var x_ = w_.SelectOrNull<ClaimResponse, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(u_, v_);

			return x_;
		};
		var h_ = b_.SelectOrNull<Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD, IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(e_, f_);
		var j_ = b_.SingleOrNull<IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(h_);

		return j_;
	}


    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_and_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = (Claim AllClaims) =>
		{
			var g_ = AllClaims.Item;
			var h_ = (Claim.ItemComponent @this) =>
			{
				var ba_ = @this.ProductOrService;
				var bb_ = (ba_ == null);
				var bc_ = (bool?)bb_;
				var bd_ = context.Operators;
				var be_ = bd_.Not(bc_);

				return be_;
			};
			var i_ = context.Operators;
			var j_ = i_.WhereOrNull<Claim.ItemComponent>(g_, h_);
			var k_ = (Claim.ItemComponent @this) =>
			{
				var bf_ = @this.ProductOrService;

				return bf_;
			};
			var m_ = i_.SelectOrNull<Claim.ItemComponent, CodeableConcept>(j_, k_);
			var n_ = (CodeableConcept @this) =>
			{
				var bg_ = @this.Coding;
				var bh_ = (bg_ == null);
				var bi_ = (bool?)bh_;
				var bj_ = context.Operators;
				var bk_ = bj_.Not(bi_);

				return bk_;
			};
			var p_ = i_.WhereOrNull<CodeableConcept>(m_, n_);
			var q_ = (CodeableConcept @this) =>
			{
				var bl_ = @this.Coding;

				return bl_;
			};
			var s_ = i_.SelectOrNull<CodeableConcept, List<Coding>>(p_, q_);
			var u_ = i_.FlattenList<Coding>(s_);
			var v_ = (Coding ProductOrServiceCode) =>
			{
				var bm_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var bn_ = context.Operators;
				var bo_ = bn_.CodeInList(bm_, ProductOrServiceValueSet);

				return bo_;
			};
			var x_ = i_.WhereOrNull<Coding>(u_, v_);
			var z_ = i_.ExistsInList<Coding>(x_);
			var aa_ = AllClaims.Diagnosis;
			var ab_ = (aa_ as IEnumerable<Claim.DiagnosisComponent>);
			var ac_ = (Claim.DiagnosisComponent @this) =>
			{
				var bp_ = @this.Diagnosis;
				var bq_ = (bp_ == null);
				var br_ = (bool?)bq_;
				var bs_ = context.Operators;
				var bt_ = bs_.Not(br_);

				return bt_;
			};
			var ae_ = i_.WhereOrNull<Claim.DiagnosisComponent>(ab_, ac_);
			var af_ = (Claim.DiagnosisComponent @this) =>
			{
				var bu_ = @this.Diagnosis;

				return bu_;
			};
			var ah_ = i_.SelectOrNull<Claim.DiagnosisComponent, DataType>(ae_, af_);
			var ai_ = (DataType @this) =>
			{
				var bv_ = context.Operators;
				var bw_ = bv_.LateBoundProperty<object>(@this, "coding");
				var bx_ = (bw_ == null);
				var by_ = (bool?)bx_;
				var ca_ = bv_.Not(by_);

				return ca_;
			};
			var ak_ = i_.WhereOrNull<DataType>(ah_, ai_);
			var al_ = (DataType @this) =>
			{
				var cb_ = context.Operators;
				var cc_ = cb_.LateBoundProperty<object>(@this, "coding");

				return cc_;
			};
			var an_ = i_.SelectOrNull<DataType, object>(ak_, al_);
			var ap_ = i_.FlattenLateBoundList(an_);
			var aq_ = (object @object) =>
			{
				var cd_ = (@object as Coding);

				return cd_;
			};
			var as_ = i_.SelectOrNull<object, Coding>(ap_, aq_);
			var at_ = (Coding DiagnosisCode) =>
			{
				var ce_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
				var cf_ = context.Operators;
				var cg_ = cf_.CodeInList(ce_, DiagnosisValueSet);

				return cg_;
			};
			var av_ = i_.WhereOrNull<Coding>(as_, at_);
			var ax_ = i_.ExistsInList<Coding>(av_);
			var az_ = i_.And(z_, ax_);

			return az_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Claim>(claim, a_);
		var d_ = (Claim ProcedureClaims) =>
		{
			var ch_ = ProcedureClaims.IdElement;
			var ci_ = ProcedureClaims.Item;
			var cj_ = (ci_ as IEnumerable<Claim.ItemComponent>);
			var ck_ = (Claim.ItemComponent ResponseItem) =>
			{
				var co_ = ResponseItem.ProductOrService;
				var cp_ = co_.Coding;
				var cq_ = (cp_ as IEnumerable<Coding>);
				var cr_ = (Coding ProductOrServiceCode) =>
				{
					var cw_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var cx_ = context.Operators;
					var cy_ = cx_.CodeInList(cw_, ProductOrServiceValueSet);

					return cy_;
				};
				var cs_ = context.Operators;
				var ct_ = cs_.WhereOrNull<Coding>(cq_, cr_);
				var cv_ = cs_.ExistsInList<Coding>(ct_);

				return cv_;
			};
			var cl_ = context.Operators;
			var cm_ = cl_.WhereOrNull<Claim.ItemComponent>(cj_, ck_);
			var cn_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = ProcedureClaims,
				ClaimID = ch_,
				LineItems = cm_,
			};

			return cn_;
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
		var e_ = (Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse) =>
		{
			var j_ = ClaimAndResponse.MedicalClaim;
			var k_ = (Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim) =>
			{
				var u_ = medClaim.LineItems;
				var v_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var z_ = ClaimAndResponse.PaidMedicalClaimResponse;
					var aa_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var af_ = pClaim.LineItems;
						var ag_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
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
						var aj_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;
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
			var p_ = (Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse) =>
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
				var bp_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
				{
					var bu_ = (FinalList == null);
					var bv_ = (bool?)bu_;
					var bw_ = context.Operators;
					var bx_ = bw_.Not(bv_);

					return bx_;
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
		var c_ = (Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse) => (((context.Operators.And((bool?)(MedicalClaimAndResponse.MedicalClaimResponse == null), (bool?)(MedicalClaimAndResponse.MedicalClaim == null)) ?? false))
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
		var i_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
		{
			var n_ = (FinalList == null);
			var o_ = (bool?)n_;
			var p_ = context.Operators;
			var q_ = p_.Not(o_);

			return q_;
		};
		var k_ = d_.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(h_, i_);
		var m_ = d_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(k_);

		return m_;
	}


    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_or_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = (Claim AllClaims) =>
		{
			var g_ = AllClaims.Item;
			var h_ = (Claim.ItemComponent @this) =>
			{
				var ba_ = @this.ProductOrService;
				var bb_ = (ba_ == null);
				var bc_ = (bool?)bb_;
				var bd_ = context.Operators;
				var be_ = bd_.Not(bc_);

				return be_;
			};
			var i_ = context.Operators;
			var j_ = i_.WhereOrNull<Claim.ItemComponent>(g_, h_);
			var k_ = (Claim.ItemComponent @this) =>
			{
				var bf_ = @this.ProductOrService;

				return bf_;
			};
			var m_ = i_.SelectOrNull<Claim.ItemComponent, CodeableConcept>(j_, k_);
			var n_ = (CodeableConcept @this) =>
			{
				var bg_ = @this.Coding;
				var bh_ = (bg_ == null);
				var bi_ = (bool?)bh_;
				var bj_ = context.Operators;
				var bk_ = bj_.Not(bi_);

				return bk_;
			};
			var p_ = i_.WhereOrNull<CodeableConcept>(m_, n_);
			var q_ = (CodeableConcept @this) =>
			{
				var bl_ = @this.Coding;

				return bl_;
			};
			var s_ = i_.SelectOrNull<CodeableConcept, List<Coding>>(p_, q_);
			var u_ = i_.FlattenList<Coding>(s_);
			var v_ = (Coding ProductOrServiceCode) =>
			{
				var bm_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var bn_ = context.Operators;
				var bo_ = bn_.CodeInList(bm_, ProductOrServiceValueSet);

				return bo_;
			};
			var x_ = i_.WhereOrNull<Coding>(u_, v_);
			var z_ = i_.ExistsInList<Coding>(x_);
			var aa_ = AllClaims.Diagnosis;
			var ab_ = (aa_ as IEnumerable<Claim.DiagnosisComponent>);
			var ac_ = (Claim.DiagnosisComponent @this) =>
			{
				var bp_ = @this.Diagnosis;
				var bq_ = (bp_ == null);
				var br_ = (bool?)bq_;
				var bs_ = context.Operators;
				var bt_ = bs_.Not(br_);

				return bt_;
			};
			var ae_ = i_.WhereOrNull<Claim.DiagnosisComponent>(ab_, ac_);
			var af_ = (Claim.DiagnosisComponent @this) =>
			{
				var bu_ = @this.Diagnosis;

				return bu_;
			};
			var ah_ = i_.SelectOrNull<Claim.DiagnosisComponent, DataType>(ae_, af_);
			var ai_ = (DataType @this) =>
			{
				var bv_ = context.Operators;
				var bw_ = bv_.LateBoundProperty<object>(@this, "coding");
				var bx_ = (bw_ == null);
				var by_ = (bool?)bx_;
				var ca_ = bv_.Not(by_);

				return ca_;
			};
			var ak_ = i_.WhereOrNull<DataType>(ah_, ai_);
			var al_ = (DataType @this) =>
			{
				var cb_ = context.Operators;
				var cc_ = cb_.LateBoundProperty<object>(@this, "coding");

				return cc_;
			};
			var an_ = i_.SelectOrNull<DataType, object>(ak_, al_);
			var ap_ = i_.FlattenLateBoundList(an_);
			var aq_ = (object @object) =>
			{
				var cd_ = (@object as Coding);

				return cd_;
			};
			var as_ = i_.SelectOrNull<object, Coding>(ap_, aq_);
			var at_ = (Coding DiagnosisCode) =>
			{
				var ce_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
				var cf_ = context.Operators;
				var cg_ = cf_.CodeInList(ce_, DiagnosisValueSet);

				return cg_;
			};
			var av_ = i_.WhereOrNull<Coding>(as_, at_);
			var ax_ = i_.ExistsInList<Coding>(av_);
			var az_ = i_.Or(z_, ax_);

			return az_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Claim>(claim, a_);
		var d_ = (Claim ProcedureClaims) => (((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>((ResponseItem.ProductOrService.Coding as IEnumerable<Coding>), (Coding ProductOrServiceCode) => context.Operators.CodeInList(FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode), ProductOrServiceValueSet))))) ?? false))
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
		var e_ = (Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse) =>
		{
			var j_ = ClaimAndResponse.MedicalClaim;
			var k_ = (Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim) =>
			{
				var u_ = medClaim.LineItems;
				var v_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var z_ = ClaimAndResponse.PaidMedicalClaimResponse;
					var aa_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var af_ = pClaim.LineItems;
						var ag_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
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
						var aj_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;
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
			var p_ = (Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse) =>
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
				var bp_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
				{
					var bu_ = (FinalList == null);
					var bv_ = (bool?)bu_;
					var bw_ = context.Operators;
					var bx_ = bw_.Not(bv_);

					return bx_;
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
		var c_ = (Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse) => (((context.Operators.And((bool?)(MedicalClaimAndResponse.MedicalClaimResponse == null), (bool?)(MedicalClaimAndResponse.MedicalClaim == null)) ?? false))
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
		var a_ = (Claim AllClaims) =>
		{
			var g_ = AllClaims.Item;
			var h_ = (Claim.ItemComponent @this) =>
			{
				var aa_ = @this.ProductOrService;
				var ab_ = (aa_ == null);
				var ac_ = (bool?)ab_;
				var ad_ = context.Operators;
				var ae_ = ad_.Not(ac_);

				return ae_;
			};
			var i_ = context.Operators;
			var j_ = i_.WhereOrNull<Claim.ItemComponent>(g_, h_);
			var k_ = (Claim.ItemComponent @this) =>
			{
				var af_ = @this.ProductOrService;

				return af_;
			};
			var m_ = i_.SelectOrNull<Claim.ItemComponent, CodeableConcept>(j_, k_);
			var n_ = (CodeableConcept @this) =>
			{
				var ag_ = @this.Coding;
				var ah_ = (ag_ == null);
				var ai_ = (bool?)ah_;
				var aj_ = context.Operators;
				var ak_ = aj_.Not(ai_);

				return ak_;
			};
			var p_ = i_.WhereOrNull<CodeableConcept>(m_, n_);
			var q_ = (CodeableConcept @this) =>
			{
				var al_ = @this.Coding;

				return al_;
			};
			var s_ = i_.SelectOrNull<CodeableConcept, List<Coding>>(p_, q_);
			var u_ = i_.FlattenList<Coding>(s_);
			var v_ = (Coding ProductOrServiceCode) =>
			{
				var am_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var an_ = context.Operators;
				var ao_ = an_.CodeInList(am_, ProductOrServiceValueSet);

				return ao_;
			};
			var x_ = i_.WhereOrNull<Coding>(u_, v_);
			var z_ = i_.ExistsInList<Coding>(x_);

			return z_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Claim>(claim, a_);
		var d_ = (Claim AllClaims) =>
		{
			var ap_ = AllClaims.IdElement;
			var aq_ = AllClaims.Item;
			var ar_ = (aq_ as IEnumerable<Claim.ItemComponent>);
			var as_ = (Claim.ItemComponent ResponseItem) =>
			{
				var aw_ = ResponseItem.ProductOrService;
				var ax_ = aw_.Coding;
				var ay_ = (ax_ as IEnumerable<Coding>);
				var az_ = (Coding ProductOrServiceCode) =>
				{
					var be_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var bf_ = context.Operators;
					var bg_ = bf_.CodeInList(be_, ProductOrServiceValueSet);

					return bg_;
				};
				var ba_ = context.Operators;
				var bb_ = ba_.WhereOrNull<Coding>(ay_, az_);
				var bd_ = ba_.ExistsInList<Coding>(bb_);

				return bd_;
			};
			var at_ = context.Operators;
			var au_ = at_.WhereOrNull<Claim.ItemComponent>(ar_, as_);
			var av_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = AllClaims,
				ClaimID = ap_,
				LineItems = au_,
			};

			return av_;
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
		var e_ = (Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse) =>
		{
			var j_ = ClaimAndResponse.MedicalClaim;
			var k_ = (Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim) =>
			{
				var u_ = medClaim.LineItems;
				var v_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var z_ = ClaimAndResponse.PaidMedicalClaimResponse;
					var aa_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var af_ = pClaim.LineItems;
						var ag_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
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
						var aj_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;
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
			var p_ = (Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse) =>
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
				var bp_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
				{
					var bu_ = (FinalList == null);
					var bv_ = (bool?)bu_;
					var bw_ = context.Operators;
					var bx_ = bw_.Not(bv_);

					return bx_;
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
		var c_ = (Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse) => (((context.Operators.And((bool?)(MedicalClaimAndResponse.MedicalClaimResponse == null), (bool?)(MedicalClaimAndResponse.MedicalClaim == null)) ?? false))
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
		var e_ = (Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB ClaimAndResponse) =>
		{
			var j_ = ClaimAndResponse.MedicalClaim;
			var k_ = (Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC medClaim) =>
			{
				var u_ = medClaim.LineItem;
				var v_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var z_ = ClaimAndResponse.PaidPharmacyClaimResponse;
					var aa_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var af_ = pClaim.LineItems;
						var ag_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
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
						var aj_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;
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
			var p_ = (Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB ClaimWithPaidResponse) =>
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
				var bp_ = (Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO FinalList) =>
				{
					var bu_ = (FinalList == null);
					var bv_ = (bool?)bu_;
					var bw_ = context.Operators;
					var bx_ = bw_.Not(bv_);

					return bx_;
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
		var c_ = (Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR PharmacyClaimAndResponse) => (((context.Operators.And((bool?)(PharmacyClaimAndResponse.PharmacyClaimResponse == null), (bool?)(PharmacyClaimAndResponse.PharmacyClaim == null)) ?? false))
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
		var a_ = (Claim Claim) =>
		{
			var d_ = (ClaimResponse CR) =>
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
			var g_ = (Claim C) =>
			{
				var aa_ = Claim.IdElement;
				var ab_ = new CallStackEntry("ToString", null, null);
				var ac_ = context.Deeper(ab_);
				var ad_ = ac_.Operators;
				var ae_ = ad_.TypeConverter;
				var af_ = ae_.Convert<string>(aa_);
				var ag_ = (ClaimResponse CR) =>
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
				var aj_ = (ClaimResponse @this) =>
				{
					var bv_ = @this.Request;
					var bw_ = (bv_ == null);
					var bx_ = (bool?)bw_;
					var by_ = context.Operators;
					var bz_ = by_.Not(bx_);

					return bz_;
				};
				var al_ = ah_.WhereOrNull<ClaimResponse>(ai_, aj_);
				var am_ = (ClaimResponse @this) =>
				{
					var ca_ = @this.Request;

					return ca_;
				};
				var ao_ = ah_.SelectOrNull<ClaimResponse, ResourceReference>(al_, am_);
				var ap_ = (ResourceReference @this) =>
				{
					var cb_ = @this.ReferenceElement;
					var cc_ = (cb_ == null);
					var cd_ = (bool?)cc_;
					var ce_ = context.Operators;
					var cf_ = ce_.Not(cd_);

					return cf_;
				};
				var ar_ = ah_.WhereOrNull<ResourceReference>(ao_, ap_);
				var as_ = (ResourceReference @this) =>
				{
					var cg_ = @this.ReferenceElement;

					return cg_;
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
		var d_ = (Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithInpatientStay) =>
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
			var k_ = (Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb LineItemDefinition) =>
			{
				var p_ = LineItemDefinition.InpatientStayLineItems;
				var q_ = LineItemDefinition.NonacuteInpatientLineItems;
				var r_ = (Claim nonAcuteInpatientStay) =>
				{
					var ac_ = LineItemDefinition.InpatientStayLineItems;
					var ad_ = (Claim inpatientStay) =>
					{
						var aj_ = nonAcuteInpatientStay.IdElement;
						var ak_ = inpatientStay.IdElement;
						var al_ = context.Operators;
						var am_ = al_.Equal(aj_, ak_);

						return am_;
					};
					var ae_ = context.Operators;
					var af_ = ae_.WhereOrNull<Claim>(ac_, ad_);
					var ag_ = (Claim inpatientStay) => nonAcuteInpatientStay;
					var ai_ = ae_.SelectOrNull<Claim, Claim>(af_, ag_);

					return ai_;
				};
				var s_ = context.Operators;
				var t_ = s_.SelectManyOrNull<Claim, Claim>(q_, r_);
				var w_ = (Claim inpatientStay) =>
				{
					var an_ = LineItemDefinition.NonacuteInpatientLineItems;
					var ao_ = (Claim nonAcuteInpatientStay) =>
					{
						var au_ = inpatientStay.IdElement;
						var av_ = nonAcuteInpatientStay.IdElement;
						var aw_ = context.Operators;
						var ax_ = aw_.Equal(au_, av_);

						return ax_;
					};
					var ap_ = context.Operators;
					var aq_ = ap_.WhereOrNull<Claim>(an_, ao_);
					var ar_ = (Claim nonAcuteInpatientStay) => inpatientStay;
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
		var a_ = (Claim C) =>
		{
			var k_ = C.CareTeam;
			var l_ = (k_ as IEnumerable<Claim.CareTeamComponent>);
			var m_ = (Claim.CareTeamComponent ct) =>
			{
				var ak_ = ct.SequenceElement;
				var al_ = context.Operators;
				var am_ = al_.TypeConverter;
				var an_ = am_.Convert<Integer>(ak_);
				var ao_ = FHIRHelpers_4_0_001.ToInteger(an_);
				var ap_ = ao_;
				var aq_ = (int?)1;
				var ar_ = aq_;
				var at_ = al_.Equal(ap_, ar_);

				return at_;
			};
			var n_ = context.Operators;
			var o_ = n_.WhereOrNull<Claim.CareTeamComponent>(l_, m_);
			var p_ = (Claim.CareTeamComponent @this) =>
			{
				var au_ = @this.Provider;
				var av_ = (au_ == null);
				var aw_ = (bool?)av_;
				var ax_ = context.Operators;
				var ay_ = ax_.Not(aw_);

				return ay_;
			};
			var r_ = n_.WhereOrNull<Claim.CareTeamComponent>(o_, p_);
			var s_ = (Claim.CareTeamComponent @this) =>
			{
				var az_ = @this.Provider;

				return az_;
			};
			var u_ = n_.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(r_, s_);
			var w_ = (k_ as IEnumerable<Claim.CareTeamComponent>);
			var x_ = (Claim.CareTeamComponent ct) =>
			{
				var ba_ = ct.SequenceElement;
				var bb_ = context.Operators;
				var bc_ = bb_.TypeConverter;
				var bd_ = bc_.Convert<Integer>(ba_);
				var be_ = FHIRHelpers_4_0_001.ToInteger(bd_);
				var bf_ = be_;
				var bg_ = (int?)1;
				var bh_ = bg_;
				var bj_ = bb_.Equal(bf_, bh_);

				return bj_;
			};
			var z_ = n_.WhereOrNull<Claim.CareTeamComponent>(w_, x_);
			var aa_ = (Claim.CareTeamComponent @this) =>
			{
				var bk_ = @this.Provider;
				var bl_ = (bk_ == null);
				var bm_ = (bool?)bl_;
				var bn_ = context.Operators;
				var bo_ = bn_.Not(bm_);

				return bo_;
			};
			var ac_ = n_.WhereOrNull<Claim.CareTeamComponent>(z_, aa_);
			var ad_ = (Claim.CareTeamComponent @this) =>
			{
				var bp_ = @this.Provider;

				return bp_;
			};
			var af_ = n_.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(ac_, ad_);
			var ag_ = (ResourceReference p) =>
			{
				var bq_ = p.ReferenceElement;
				var br_ = new FhirString[]
				{
					bq_,
				};
				var bs_ = (FhirString r) =>
				{
					var bx_ = new CallStackEntry("ToString", null, null);
					var by_ = context.Deeper(bx_);
					var bz_ = by_.Operators;
					var ca_ = bz_.TypeConverter;
					var cb_ = ca_.Convert<string>(r);
					var cc_ = NCQAFHIRBase_1_0_0.GetId(cb_);

					return cc_;
				};
				var bt_ = context.Operators;
				var bu_ = bt_.SelectOrNull<FhirString, string>(br_, bs_);
				var bw_ = bt_.SingleOrNull<string>(bu_);

				return bw_;
			};
			var ai_ = n_.SelectOrNull<ResourceReference, string>(af_, ag_);
			var aj_ = new Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS
			{
				SingleCareTeam = C,
				CareTeamsProvider = u_,
				CareTeamsProviderID = ai_,
			};

			return aj_;
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
		var f_ = (Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR ClaimProperties) =>
		{
			var cd_ = context.DataRetriever;
			var ce_ = cd_.RetrieveByValueSet<Practitioner>(null, null);
			var cf_ = (Practitioner p) =>
			{
				var cp_ = p.IdElement;
				var cq_ = new CallStackEntry("ToString", null, null);
				var cr_ = context.Deeper(cq_);
				var cs_ = cr_.Operators;
				var ct_ = cs_.TypeConverter;
				var cu_ = ct_.Convert<string>(cp_);
				var cv_ = ClaimProperties.CareTeams;
				var cw_ = (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) =>
				{
					var dg_ = @this.CareTeamsProviderID;
					var dh_ = (dg_ == null);
					var di_ = (bool?)dh_;
					var dj_ = context.Operators;
					var dk_ = dj_.Not(di_);

					return dk_;
				};
				var cx_ = context.Operators;
				var cy_ = cx_.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(cv_, cw_);
				var cz_ = (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) =>
				{
					var dl_ = @this.CareTeamsProviderID;

					return dl_;
				};
				var db_ = cx_.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, IEnumerable<string>>(cy_, cz_);
				var dd_ = cx_.FlattenList<string>(db_);
				var df_ = cx_.InList<string>(cu_, dd_);

				return df_;
			};
			var cg_ = context.Operators;
			var ch_ = cg_.WhereOrNull<Practitioner>(ce_, cf_);
			var ci_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe
			{
				Practitioners = ch_,
			};
			var cj_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe[]
			{
				ci_,
			};
			var ck_ = (Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe PractitionerMatch) =>
			{
				var dm_ = PractitionerMatch.Practitioners;
				var dn_ = (Practitioner P) =>
				{
					var ea_ = (P == null);
					var eb_ = (bool?)ea_;
					var ec_ = context.Operators;
					var ed_ = ec_.Not(eb_);

					return ed_;
				};
				var do_ = context.Operators;
				var dp_ = do_.WhereOrNull<Practitioner>(dm_, dn_);
				var dq_ = (Practitioner P) =>
				{
					var ee_ = P.Identifier;
					var ef_ = (ee_ as IEnumerable<Identifier>);
					var eg_ = (Identifier l) =>
					{
						var ev_ = l.SystemElement;
						var ew_ = ev_.Value;
						var ex_ = context.Operators;
						var ey_ = ex_.Equal(ew_, "http://hl7.org/fhir/sid/us-npi");
						var ez_ = l.Type;
						var fa_ = FHIRHelpers_4_0_001.ToConcept(ez_);
						var fb_ = NCQATerminology_1_0_0.Provider_number();
						var fd_ = ex_.ConvertCodeToConcept(fb_);
						var ff_ = ex_.Equivalent(fa_, fd_);
						var fh_ = ex_.And(ey_, ff_);
						var fi_ = l.ValueElement;
						var fj_ = fi_.Value;
						var fk_ = (fj_ == null);
						var fl_ = (bool?)fk_;
						var fn_ = ex_.Not(fl_);
						var fp_ = ex_.And(fh_, fn_);

						return fp_;
					};
					var eh_ = context.Operators;
					var ei_ = eh_.WhereOrNull<Identifier>(ef_, eg_);
					var ej_ = (Identifier l) =>
					{
						var fq_ = l.ValueElement;

						return fq_;
					};
					var el_ = eh_.SelectOrNull<Identifier, FhirString>(ei_, ej_);
					var en_ = (ee_ as IEnumerable<Identifier>);
					var eo_ = (Identifier l) =>
					{
						var fr_ = l.SystemElement;
						var fs_ = fr_.Value;
						var ft_ = context.Operators;
						var fu_ = ft_.Equal(fs_, "http://hl7.org/fhir/sid/us-npi");
						var fv_ = l.Type;
						var fw_ = FHIRHelpers_4_0_001.ToConcept(fv_);
						var fx_ = NCQATerminology_1_0_0.Provider_number();
						var fz_ = ft_.ConvertCodeToConcept(fx_);
						var gb_ = ft_.Equivalent(fw_, fz_);
						var gd_ = ft_.And(fu_, gb_);
						var ge_ = l.ValueElement;
						var gf_ = ge_.Value;
						var gg_ = (gf_ == null);
						var gh_ = (bool?)gg_;
						var gj_ = ft_.And(gd_, gh_);

						return gj_;
					};
					var eq_ = eh_.WhereOrNull<Identifier>(en_, eo_);
					var er_ = (Identifier l) => l;
					var et_ = eh_.SelectOrNull<Identifier, Identifier>(eq_, er_);
					var eu_ = new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = el_,
						NullIdentifiers = et_,
					};

					return eu_;
				};
				var ds_ = do_.SelectOrNull<Practitioner, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(dp_, dq_);
				var dt_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = ds_,
				};
				var du_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					dt_,
				};
				var dv_ = (Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers) =>
				{
					var gk_ = new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = (((context.Operators.ExistsInList<Claim>(context.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => context.Operators.Not((bool?)(@this.SingleCareTeam == null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this.SingleCareTeam)) ?? false))
							? (context.Operators.Add(context.Operators.Add(context.Operators.CountOrNull<Claim>(context.Operators.WhereOrNull<Claim>(context.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => context.Operators.Not((bool?)(@this.SingleCareTeam == null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this.SingleCareTeam), (Claim X) => (bool?)((X.CareTeam as IEnumerable<Claim.CareTeamComponent>) == null))), context.Operators.CountOrNull<FhirString>(context.Operators.SelectOrNull<FhirString, FhirString>(context.Operators.FlattenList<FhirString>(context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X.AllIdentifiers)), (FhirString X) => X))), context.Operators.CountOrNull<Identifier>(context.Operators.FlattenList<Identifier>(context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X.NullIdentifiers)))))
							: ((int?)0))
,
					};

					return gk_;
				};
				var dx_ = do_.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(du_, dv_);
				var dz_ = do_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dx_);

				return dz_;
			};
			var cm_ = cg_.SelectOrNull<Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cj_, ck_);
			var co_ = cg_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cm_);

			return co_;
		};
		var h_ = b_.SelectOrNull<Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(e_, f_);
		var j_ = b_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(h_);

		return j_;
	}


    [CqlDeclaration("Get Pharmacy NPI from Claims")]
    public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Pharmacy_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		var a_ = (Claim C) =>
		{
			var k_ = C.Item;
			var l_ = (k_ as IEnumerable<Claim.ItemComponent>);
			var n_ = (k_ as IEnumerable<Claim.ItemComponent>);
			var o_ = (Claim.ItemComponent i) =>
			{
				var ap_ = i.SequenceElement;
				var aq_ = context.Operators;
				var ar_ = aq_.TypeConverter;
				var as_ = ar_.Convert<Integer>(ap_);
				var at_ = FHIRHelpers_4_0_001.ToInteger(as_);
				var au_ = at_;
				var av_ = (int?)1;
				var aw_ = av_;
				var ay_ = aq_.Equal(au_, aw_);

				return ay_;
			};
			var p_ = context.Operators;
			var q_ = p_.WhereOrNull<Claim.ItemComponent>(n_, o_);
			var r_ = (Claim.ItemComponent @this) =>
			{
				var az_ = @this.Location;
				var ba_ = (az_ == null);
				var bb_ = (bool?)ba_;
				var bc_ = context.Operators;
				var bd_ = bc_.Not(bb_);

				return bd_;
			};
			var t_ = p_.WhereOrNull<Claim.ItemComponent>(q_, r_);
			var u_ = (Claim.ItemComponent @this) =>
			{
				var be_ = @this.Location;

				return be_;
			};
			var w_ = p_.SelectOrNull<Claim.ItemComponent, DataType>(t_, u_);
			var x_ = (DataType l) =>
			{
				var bf_ = (l as ResourceReference);

				return bf_;
			};
			var z_ = p_.SelectOrNull<DataType, ResourceReference>(w_, x_);
			var ab_ = (k_ as IEnumerable<Claim.ItemComponent>);
			var ac_ = (Claim.ItemComponent i) =>
			{
				var bg_ = i.SequenceElement;
				var bh_ = context.Operators;
				var bi_ = bh_.TypeConverter;
				var bj_ = bi_.Convert<Integer>(bg_);
				var bk_ = FHIRHelpers_4_0_001.ToInteger(bj_);
				var bl_ = bk_;
				var bm_ = (int?)1;
				var bn_ = bm_;
				var bp_ = bh_.Equal(bl_, bn_);

				return bp_;
			};
			var ae_ = p_.WhereOrNull<Claim.ItemComponent>(ab_, ac_);
			var af_ = (Claim.ItemComponent @this) =>
			{
				var bq_ = @this.Location;
				var br_ = (bq_ == null);
				var bs_ = (bool?)br_;
				var bt_ = context.Operators;
				var bu_ = bt_.Not(bs_);

				return bu_;
			};
			var ah_ = p_.WhereOrNull<Claim.ItemComponent>(ae_, af_);
			var ai_ = (Claim.ItemComponent @this) =>
			{
				var bv_ = @this.Location;

				return bv_;
			};
			var ak_ = p_.SelectOrNull<Claim.ItemComponent, DataType>(ah_, ai_);
			var al_ = (DataType l) =>
			{
				var bw_ = (l as ResourceReference);
				var bx_ = bw_.ReferenceElement;
				var by_ = new FhirString[]
				{
					bx_,
				};
				var bz_ = (FhirString r) =>
				{
					var ce_ = new CallStackEntry("ToString", null, null);
					var cf_ = context.Deeper(ce_);
					var cg_ = cf_.Operators;
					var ch_ = cg_.TypeConverter;
					var ci_ = ch_.Convert<string>(r);
					var cj_ = NCQAFHIRBase_1_0_0.GetId(ci_);

					return cj_;
				};
				var ca_ = context.Operators;
				var cb_ = ca_.SelectOrNull<FhirString, string>(by_, bz_);
				var cd_ = ca_.SingleOrNull<string>(cb_);

				return cd_;
			};
			var an_ = p_.SelectOrNull<DataType, string>(ak_, al_);
			var ao_ = new Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI
			{
				SingleItem = l_,
				ItemLocation = z_,
				ItemLocationID = an_,
			};

			return ao_;
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
		var f_ = (Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa ClaimProperties) =>
		{
			var ck_ = context.DataRetriever;
			var cl_ = ck_.RetrieveByValueSet<Location>(null, null);
			var cm_ = (Location l) =>
			{
				var cw_ = l.IdElement;
				var cx_ = new CallStackEntry("ToString", null, null);
				var cy_ = context.Deeper(cx_);
				var cz_ = cy_.Operators;
				var da_ = cz_.TypeConverter;
				var db_ = da_.Convert<string>(cw_);
				var dc_ = ClaimProperties.ItemsLocationReferences;
				var dd_ = (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) =>
				{
					var dn_ = @this.ItemLocationID;
					var do_ = (dn_ == null);
					var dp_ = (bool?)do_;
					var dq_ = context.Operators;
					var dr_ = dq_.Not(dp_);

					return dr_;
				};
				var de_ = context.Operators;
				var df_ = de_.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(dc_, dd_);
				var dg_ = (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) =>
				{
					var ds_ = @this.ItemLocationID;

					return ds_;
				};
				var di_ = de_.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<string>>(df_, dg_);
				var dk_ = de_.FlattenList<string>(di_);
				var dm_ = de_.InList<string>(db_, dk_);

				return dm_;
			};
			var cn_ = context.Operators;
			var co_ = cn_.WhereOrNull<Location>(cl_, cm_);
			var cp_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP
			{
				CorrespondingLocations = co_,
			};
			var cq_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP[]
			{
				cp_,
			};
			var cr_ = (Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP GetLocation) =>
			{
				var dt_ = GetLocation.CorrespondingLocations;
				var du_ = (Location C) =>
				{
					var eh_ = (C == null);
					var ei_ = (bool?)eh_;
					var ej_ = context.Operators;
					var ek_ = ej_.Not(ei_);

					return ek_;
				};
				var dv_ = context.Operators;
				var dw_ = dv_.WhereOrNull<Location>(dt_, du_);
				var dx_ = (Location C) =>
				{
					var el_ = C.Identifier;
					var em_ = (el_ as IEnumerable<Identifier>);
					var en_ = (Identifier l) =>
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
						var fs_ = (bool?)fr_;
						var fu_ = fe_.Not(fs_);
						var fw_ = fe_.And(fo_, fu_);

						return fw_;
					};
					var eo_ = context.Operators;
					var ep_ = eo_.WhereOrNull<Identifier>(em_, en_);
					var eq_ = (Identifier l) =>
					{
						var fx_ = l.ValueElement;

						return fx_;
					};
					var es_ = eo_.SelectOrNull<Identifier, FhirString>(ep_, eq_);
					var eu_ = (el_ as IEnumerable<Identifier>);
					var ev_ = (Identifier l) =>
					{
						var fy_ = l.SystemElement;
						var fz_ = fy_.Value;
						var ga_ = context.Operators;
						var gb_ = ga_.Equal(fz_, "http://hl7.org/fhir/sid/us-npi");
						var gc_ = l.Type;
						var gd_ = FHIRHelpers_4_0_001.ToConcept(gc_);
						var ge_ = NCQATerminology_1_0_0.Provider_number();
						var gg_ = ga_.ConvertCodeToConcept(ge_);
						var gi_ = ga_.Equivalent(gd_, gg_);
						var gk_ = ga_.And(gb_, gi_);
						var gl_ = l.ValueElement;
						var gm_ = gl_.Value;
						var gn_ = (gm_ == null);
						var go_ = (bool?)gn_;
						var gq_ = ga_.And(gk_, go_);

						return gq_;
					};
					var ex_ = eo_.WhereOrNull<Identifier>(eu_, ev_);
					var ey_ = (Identifier l) => l;
					var fa_ = eo_.SelectOrNull<Identifier, Identifier>(ex_, ey_);
					var fb_ = new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = es_,
						NullIdentifiers = fa_,
					};

					return fb_;
				};
				var dz_ = dv_.SelectOrNull<Location, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(dw_, dx_);
				var ea_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = dz_,
				};
				var eb_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					ea_,
				};
				var ec_ = (Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers) =>
				{
					var gr_ = new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = (((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => context.Operators.Not((bool?)(@this.SingleItem == null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this.SingleItem))) ?? false))
							? (context.Operators.Add(context.Operators.Add(context.Operators.CountOrNull<ResourceReference>(context.Operators.WhereOrNull<ResourceReference>(context.Operators.FlattenList<ResourceReference>(context.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<ResourceReference>>(context.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => context.Operators.Not((bool?)(@this.ItemLocation == null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this.ItemLocation)), (ResourceReference X) => (bool?)(X.ReferenceElement.Value == null))), context.Operators.CountOrNull<FhirString>(context.Operators.SelectOrNull<FhirString, FhirString>(context.Operators.FlattenList<FhirString>(context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X.AllIdentifiers)), (FhirString X) => X))), context.Operators.CountOrNull<Identifier>(context.Operators.FlattenList<Identifier>(context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X.NullIdentifiers)))))
							: ((int?)0))
,
					};

					return gr_;
				};
				var ee_ = dv_.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(eb_, ec_);
				var eg_ = dv_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ee_);

				return eg_;
			};
			var ct_ = cn_.SelectOrNull<Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cq_, cr_);
			var cv_ = cn_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ct_);

			return cv_;
		};
		var h_ = b_.SelectOrNull<Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(e_, f_);
		var j_ = b_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(h_);

		return j_;
	}


}
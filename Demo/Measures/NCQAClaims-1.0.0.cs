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
		var k_ = (Claim MedicalClaim) =>
		{
			var a_ = MedicalClaim?.Type;
			var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
			var c_ = (b_?.codes as IEnumerable<CqlCode>);
			var d_ = NCQATerminology_1_0_0.Professional();
			var e_ = context?.Operators.ListContains<CqlCode>(c_, d_);
			var f_ = MedicalClaim?.Type;
			var g_ = FHIRHelpers_4_0_001.ToConcept(f_);
			var h_ = (g_?.codes as IEnumerable<CqlCode>);
			var i_ = NCQATerminology_1_0_0.Institutional();
			var j_ = context?.Operators.ListContains<CqlCode>(h_, i_);

			return context?.Operators.Or(e_, j_);
		};

		return context?.Operators.WhereOrNull<Claim>(claim, k_);
	}


    [CqlDeclaration("Pharmacy Claims")]
    public IEnumerable<Claim> Pharmacy_Claims(IEnumerable<Claim> claim)
	{
		var e_ = (Claim PharmacyClaim) =>
		{
			var a_ = PharmacyClaim?.Type;
			var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
			var c_ = (b_?.codes as IEnumerable<CqlCode>);
			var d_ = NCQATerminology_1_0_0.Pharmacy();

			return context?.Operators.ListContains<CqlCode>(c_, d_);
		};

		return context?.Operators.WhereOrNull<Claim>(claim, e_);
	}


    [CqlDeclaration("Professional or Institutional Claims Response")]
    public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		var k_ = (ClaimResponse MedicalResponse) =>
		{
			var a_ = MedicalResponse?.Type;
			var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
			var c_ = (b_?.codes as IEnumerable<CqlCode>);
			var d_ = NCQATerminology_1_0_0.Professional();
			var e_ = context?.Operators.ListContains<CqlCode>(c_, d_);
			var f_ = MedicalResponse?.Type;
			var g_ = FHIRHelpers_4_0_001.ToConcept(f_);
			var h_ = (g_?.codes as IEnumerable<CqlCode>);
			var i_ = NCQATerminology_1_0_0.Institutional();
			var j_ = context?.Operators.ListContains<CqlCode>(h_, i_);

			return context?.Operators.Or(e_, j_);
		};

		return context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, k_);
	}


    [CqlDeclaration("Pharmacy Claims Response")]
    public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		var e_ = (ClaimResponse PharmacyResponse) =>
		{
			var a_ = PharmacyResponse?.Type;
			var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
			var c_ = (b_?.codes as IEnumerable<CqlCode>);
			var d_ = NCQATerminology_1_0_0.Pharmacy();

			return context?.Operators.ListContains<CqlCode>(c_, d_);
		};

		return context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, e_);
	}


    [CqlDeclaration("Medical Claims With Procedure and POS")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_and_POS(IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var l_ = this.Professional_or_Institutional_Claims(claim);
		var m_ = (CqlCode p) => p?.code;
		var n_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, m_);
		var o_ = (CqlCode pos) => pos?.code;
		var p_ = context?.Operators.SelectOrNull<CqlCode, string>(posCodes, o_);
		var q_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = l_,
			ProceduresAsStrings = n_,
			POSAsString = p_,
		};
		var r_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			q_,
		};
		var s_ = (Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithPosCode) =>
		{
			var h_ = ClaimWithPosCode?.MedicalClaim;
			var i_ = (Claim ClaimofInterest) =>
			{
				var a_ = ClaimofInterest;
				var b_ = (((ClaimofInterest == null))
					? ((null as IEnumerable<Claim.ItemComponent>))
					: (context?.Operators.WhereOrNull<Claim.ItemComponent>((ClaimofInterest?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ItemOnLine) => context?.Operators.And(context?.Operators.ExistsInList<CqlCode>(context?.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService)?.codes as IEnumerable<CqlCode>), (CqlCode LineCode) => context?.Operators.InList<string>(LineCode?.code, ClaimWithPosCode?.ProceduresAsStrings))), context?.Operators.ExistsInList<CqlCode>(context?.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(((ItemOnLine?.Location as object) as CodeableConcept))?.codes as IEnumerable<CqlCode>), (CqlCode PosCode) => context?.Operators.InList<string>(PosCode?.code, ClaimWithPosCode?.POSAsString)))))))
;
				var c_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = a_,
					LineItems = b_,
				};
				var d_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					c_,
				};
				var e_ = (Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition) => (((context?.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
					? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
						{
							Claim = LineItemDefinition?.Claim,
							ServicePeriod = context?.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context?.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, (Claim.ItemComponent @this) => context?.Operators.Not((bool?)(@this?.Serviced == null))), (Claim.ItemComponent @this) => @this?.Serviced), (DataType NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
						})
					: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)))
;
				var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(d_, e_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(f_);
			};
			var j_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(h_, i_);
			var k_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
			{
				var g_ = (bool?)(FinalList == null);

				return context?.Operators.Not(g_);
			};

			return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(j_, k_);
		};
		var t_ = context?.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(r_, s_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(t_);
	}


    [CqlDeclaration("Medical Claims With Procedure in Header or on Line Item")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var l_ = this.Professional_or_Institutional_Claims(claim);
		var m_ = (CqlCode p) => p?.code;
		var n_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, m_);
		var o_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = l_,
			ProceduresAsStrings = n_,
		};
		var p_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			o_,
		};
		var q_ = (Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithProcedure) =>
		{
			var h_ = ClaimWithProcedure?.MedicalClaim;
			var i_ = (Claim ClaimofInterest) =>
			{
				var a_ = ClaimofInterest;
				var b_ = (((ClaimofInterest == null))
					? ((null as IEnumerable<Claim.ItemComponent>))
					: (context?.Operators.WhereOrNull<Claim.ItemComponent>((ClaimofInterest?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ItemOnLine) => context?.Operators.Or(context?.Operators.ExistsInList<CqlCode>(context?.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService)?.codes as IEnumerable<CqlCode>), (CqlCode LineCode) => context?.Operators.InList<string>(LineCode?.code, ClaimWithProcedure?.ProceduresAsStrings))), context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.SelectOrNull<object, Coding>(context?.Operators.FlattenLateBoundList(context?.Operators.SelectOrNull<DataType, object>(context?.Operators.WhereOrNull<DataType>(context?.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(context?.Operators.WhereOrNull<Claim.ProcedureComponent>((ClaimofInterest?.Procedure as IEnumerable<Claim.ProcedureComponent>), (Claim.ProcedureComponent @this) => context?.Operators.Not((bool?)(@this?.Procedure == null))), (Claim.ProcedureComponent @this) => @this?.Procedure), (DataType @this) => context?.Operators.Not((bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null))), (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context?.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings)))))))
;
				var c_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = a_,
					LineItems = b_,
				};
				var d_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					c_,
				};
				var e_ = (Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition) => (((context?.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
					? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
						{
							Claim = LineItemDefinition?.Claim,
							ServicePeriod = context?.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context?.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, (Claim.ItemComponent @this) => context?.Operators.Not((bool?)(@this?.Serviced == null))), (Claim.ItemComponent @this) => @this?.Serviced), (DataType NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
						})
					: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)))
;
				var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(d_, e_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(f_);
			};
			var j_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(h_, i_);
			var k_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
			{
				var g_ = (bool?)(FinalList == null);

				return context?.Operators.Not(g_);
			};

			return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(j_, k_);
		};
		var r_ = context?.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(p_, q_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(r_);
	}


    [CqlDeclaration("Medical Claims With Diagnosis")]
    public Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI Medical_Claims_With_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var k_ = this.Professional_or_Institutional_Claims(claim);
		var l_ = (CqlCode d) => d?.code;
		var m_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, l_);
		var n_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = k_,
			DiagnosesAsStrings = m_,
		};
		var o_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			n_,
		};
		var p_ = (Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis) =>
		{
			var f_ = (((ClaimWithDiagnosis?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, (Claim DiagnosisLine) => context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.SelectOrNull<object, Coding>(context?.Operators.FlattenLateBoundList(context?.Operators.SelectOrNull<DataType, object>(context?.Operators.WhereOrNull<DataType>(context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(context?.Operators.WhereOrNull<Claim.DiagnosisComponent>((DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent @this) => context?.Operators.Not((bool?)(@this?.Diagnosis == null))), (Claim.DiagnosisComponent @this) => @this?.Diagnosis), (DataType @this) => context?.Operators.Not((bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null))), (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context?.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings))))))
;
			var g_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = f_,
			};
			var h_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				g_,
			};
			var i_ = (Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg HeaderDefinition) =>
			{
				var b_ = (((context?.Operators.ExistsInList<Claim>(HeaderDefinition?.DiagnosisItems) ?? false))
					? (new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = HeaderDefinition?.DiagnosisItems,
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Claim>(HeaderDefinition?.DiagnosisItems, (Claim @this) => context?.Operators.Not((bool?)(@this?.Item == null))), (Claim @this) => @this?.Item)), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval((NormalDate?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI)))
;
				var c_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI[]
				{
					b_,
				};
				var d_ = (Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList) =>
				{
					var a_ = (bool?)(FinalList == null);

					return context?.Operators.Not(a_);
				};
				var e_ = context?.Operators.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(c_, d_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(e_);
			};
			var j_ = context?.Operators.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(h_, i_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(j_);
		};
		var q_ = context?.Operators.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(o_, p_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(q_);
	}


    [CqlDeclaration("Pharmacy Claim With Medication")]
    public IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> Pharmacy_Claim_With_Medication(IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
	{
		var ap_ = this.Pharmacy_Claims(claim);
		var aq_ = (CqlCode p) => p?.code;
		var ar_ = context?.Operators.SelectOrNull<CqlCode, string>(MedicationCodes, aq_);
		var as_ = new Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY
		{
			PharmacyClaim = ap_,
			MedicationsAsStrings = ar_,
		};
		var at_ = new Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY[]
		{
			as_,
		};
		var au_ = (Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY ClaimWithMedication) =>
		{
			var al_ = ClaimWithMedication?.PharmacyClaim;
			var am_ = (Claim Pharmacy) =>
			{
				var ac_ = Pharmacy;
				var ad_ = (Pharmacy?.Item as IEnumerable<Claim.ItemComponent>);
				var ae_ = (Claim.ItemComponent ItemOnLine) =>
				{
					var c_ = ItemOnLine?.ProductOrService;
					var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
					var e_ = (d_?.codes as IEnumerable<CqlCode>);
					var f_ = (CqlCode LineCode) =>
					{
						var a_ = LineCode?.code;
						var b_ = ClaimWithMedication?.MedicationsAsStrings;

						return context?.Operators.InList<string>(a_, b_);
					};
					var g_ = context?.Operators.WhereOrNull<CqlCode>(e_, f_);

					return context?.Operators.ExistsInList<CqlCode>(g_);
				};
				var af_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ad_, ae_);
				var ag_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = ac_,
					LineItems = af_,
				};
				var ah_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					ag_,
				};
				var ai_ = (Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition) =>
				{
					var y_ = LineItemDefinition?.Claim;
					var z_ = new Claim[]
					{
						y_,
					};
					var aa_ = (Claim ClaimLines) =>
					{
						var p_ = (ClaimLines?.Item as IEnumerable<Claim.ItemComponent>);
						var q_ = (Claim.ItemComponent i) =>
						{
							var j_ = i?.ProductOrService;
							var k_ = FHIRHelpers_4_0_001.ToConcept(j_);
							var l_ = (k_?.codes as IEnumerable<CqlCode>);
							var m_ = (CqlCode LineCode) =>
							{
								var h_ = LineCode?.code;
								var i_ = ClaimWithMedication?.MedicationsAsStrings;

								return context?.Operators.InList<string>(h_, i_);
							};
							var n_ = context?.Operators.WhereOrNull<CqlCode>(l_, m_);

							return context?.Operators.ExistsInList<CqlCode>(n_);
						};
						var r_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(p_, q_);
						var s_ = (Claim.ItemComponent i) =>
						{
							var o_ = (((context?.Operators.Not((bool?)(i?.Quantity == null)) ?? false))
								? ((((((i?.Serviced as object) is Period as bool?) ?? false))
										? (context?.Operators.Interval(context?.Operators.Start(NCQAFHIRBase_1_0_0.Normalize_Interval((i?.Serviced as object))), context?.Operators.Subtract(context?.Operators.Add(context?.Operators.Start(NCQAFHIRBase_1_0_0.Normalize_Interval((i?.Serviced as object))), new CqlQuantity
														{
															value = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement),
															unit = "day",
														}), context?.Operators.Quantity(1m, "day")), true, true))
										: (context?.Operators.Interval(context?.Operators.ConvertDateToDateTime(context?.Operators.Interval(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), context?.Operators.Subtract(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), new CqlQuantity
			{
				value = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement),
				unit = "day",
			}), context?.Operators.Quantity(1m, "day")), true, true)?.low), context?.Operators.ConvertDateToDateTime(context?.Operators.Interval(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), context?.Operators.Subtract(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), new CqlQuantity
			{
				value = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement),
				unit = "day",
			}), context?.Operators.Quantity(1m, "day")), true, true)?.high), context?.Operators.Interval(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), context?.Operators.Subtract(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), new CqlQuantity
			{
				value = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement),
				unit = "day",
			}), context?.Operators.Quantity(1m, "day")), true, true)?.lowClosed, context?.Operators.Interval(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), context?.Operators.Subtract(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), new CqlQuantity
			{
				value = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement),
				unit = "day",
			}), context?.Operators.Quantity(1m, "day")), true, true)?.highClosed)))
)
								: ((null as CqlInterval<CqlDateTime>)))
;

							return new Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP
							{
								DaysSupplyInterval = o_,
							};
						};
						var t_ = context?.Operators.SelectOrNull<Claim.ItemComponent, Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP>(r_, s_);
						var u_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU
						{
							CoveredDays = t_,
						};
						var v_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU[]
						{
							u_,
						};
						var w_ = (Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU ItemCalculation) => (((context?.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
							? (new Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC
								{
									Claim = LineItemDefinition?.Claim,
									LineItem = LineItemDefinition?.LineItems,
									ServicePeriod = context?.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context?.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, (Claim.ItemComponent @this) => context?.Operators.Not((bool?)(@this?.Serviced == null))), (Claim.ItemComponent @this) => @this?.Serviced), (DataType NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
									CoveredDays = context?.Operators.SelectOrNull<Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP, CqlInterval<CqlDateTime>>(ItemCalculation?.CoveredDays, (Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP d) => d?.DaysSupplyInterval),
								})
							: ((null as Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC)))
;
						var x_ = context?.Operators.SelectOrNull<Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(v_, w_);

						return context?.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(x_);
					};
					var ab_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(z_, aa_);

					return context?.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ab_);
				};
				var aj_ = context?.Operators.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ah_, ai_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(aj_);
			};
			var an_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(al_, am_);
			var ao_ = (Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC FinalList) =>
			{
				var ak_ = (bool?)(FinalList == null);

				return context?.Operators.Not(ak_);
			};

			return context?.Operators.WhereOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(an_, ao_);
		};
		var av_ = context?.Operators.SelectOrNull<Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY, IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(at_, au_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(av_);
	}


    [CqlDeclaration("Medical Claims With Diagnosis and Procedure")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var p_ = this.Professional_or_Institutional_Claims(claim);
		var q_ = (CqlCode d) => d?.code;
		var r_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, q_);
		var s_ = (CqlCode p) => p?.code;
		var t_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, s_);
		var u_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = p_,
			DiagnosesAsStrings = r_,
			ProceduresAsStrings = t_,
		};
		var v_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
		{
			u_,
		};
		var w_ = (Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithDiagnosis) =>
		{
			var k_ = (((ClaimWithDiagnosis?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, (Claim DiagnosisLine) => context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.SelectOrNull<object, Coding>(context?.Operators.FlattenLateBoundList(context?.Operators.SelectOrNull<DataType, object>(context?.Operators.WhereOrNull<DataType>(context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(context?.Operators.WhereOrNull<Claim.DiagnosisComponent>((DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent @this) => context?.Operators.Not((bool?)(@this?.Diagnosis == null))), (Claim.DiagnosisComponent @this) => @this?.Diagnosis), (DataType @this) => context?.Operators.Not((bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null))), (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context?.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings))))))
;
			var l_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = k_,
			};
			var m_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				l_,
			};
			var n_ = (Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg ClaimWithProcedure) =>
			{
				var g_ = ClaimWithProcedure?.DiagnosisItems;
				var h_ = (Claim ClaimofInterest) =>
				{
					var a_ = (((ClaimofInterest == null))
						? (null)
						: (context?.Operators.SingleOrNull<Claim>(context?.Operators.WhereOrNull<Claim>(new Claim[]
									{
										ClaimofInterest,
									}, (Claim ItemOnLine) => context?.Operators.Or(context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.SelectOrNull<object, Coding>(context?.Operators.FlattenLateBoundList(context?.Operators.SelectOrNull<DataType, object>(context?.Operators.WhereOrNull<DataType>(context?.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(context?.Operators.WhereOrNull<Claim.ProcedureComponent>((ItemOnLine?.Procedure as IEnumerable<Claim.ProcedureComponent>), (Claim.ProcedureComponent @this) => context?.Operators.Not((bool?)(@this?.Procedure == null))), (Claim.ProcedureComponent @this) => @this?.Procedure), (DataType @this) => context?.Operators.Not((bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null))), (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding"))), (object @object) => (@object as Coding)), (Coding ProcedureHeaderCode) => context?.Operators.InList<string>(ProcedureHeaderCode?.CodeElement?.Value, ClaimWithDiagnosis?.ProceduresAsStrings))), context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.FlattenList<Coding>(context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(context?.Operators.WhereOrNull<CodeableConcept>(context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(context?.Operators.WhereOrNull<Claim.ItemComponent>((ItemOnLine?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent @this) => context?.Operators.Not((bool?)(@this?.ProductOrService == null))), (Claim.ItemComponent @this) => @this?.ProductOrService), (CodeableConcept @this) => context?.Operators.Not((bool?)(@this?.Coding == null))), (CodeableConcept @this) => @this?.Coding)), (Coding LineCode) => context?.Operators.InList<string>(LineCode?.CodeElement?.Value, ClaimWithDiagnosis?.ProceduresAsStrings))))))))
;
					var b_ = new Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU
					{
						ProcedureItems = a_,
					};
					var c_ = new Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU[]
					{
						b_,
					};
					var d_ = (Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU HeaderDefinition) => (((context?.Operators.Not((bool?)(HeaderDefinition?.ProcedureItems == null)) ?? false))
						? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = HeaderDefinition?.ProcedureItems,
								ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((HeaderDefinition?.ProcedureItems?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval((NormalDate?.Serviced as object))),
							})
						: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)))
;
					var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(c_, d_);

					return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(e_);
				};
				var i_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(g_, h_);
				var j_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
				{
					var f_ = (bool?)(FinalList == null);

					return context?.Operators.Not(f_);
				};

				return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(i_, j_);
			};
			var o_ = context?.Operators.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(m_, n_);

			return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(o_);
		};
		var x_ = context?.Operators.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(v_, w_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(x_);
	}


    [CqlDeclaration("Medical Claims With Principal Diagnosis and Procedure")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Principal_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var v_ = this.Professional_or_Institutional_Claims(claim);
		var w_ = (CqlCode d) => d?.code;
		var x_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, w_);
		var y_ = (CqlCode p) => p?.code;
		var z_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, y_);
		var aa_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = v_,
			DiagnosesAsStrings = x_,
			ProceduresAsStrings = z_,
		};
		var ab_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
		{
			aa_,
		};
		var ac_ = (Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithProcedure) =>
		{
			var r_ = ClaimWithProcedure?.MedicalClaim;
			var s_ = (Claim ClaimofInterest) =>
			{
				var k_ = ClaimofInterest;
				var l_ = (((ClaimofInterest == null))
					? (null)
					: (context?.Operators.SingleOrNull<Claim>(context?.Operators.WhereOrNull<Claim>(new Claim[]
								{
									ClaimofInterest,
								}, (Claim ItemOnLine) => context?.Operators.Or(context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.FlattenList<Coding>(context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(context?.Operators.WhereOrNull<CodeableConcept>(context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(context?.Operators.WhereOrNull<Claim.ItemComponent>((ItemOnLine?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent @this) => context?.Operators.Not((bool?)(@this?.ProductOrService == null))), (Claim.ItemComponent @this) => @this?.ProductOrService), (CodeableConcept @this) => context?.Operators.Not((bool?)(@this?.Coding == null))), (CodeableConcept @this) => @this?.Coding)), (Coding LineCode) => context?.Operators.InList<string>(LineCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings))), context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.SelectOrNull<object, Coding>(context?.Operators.FlattenLateBoundList(context?.Operators.SelectOrNull<DataType, object>(context?.Operators.WhereOrNull<DataType>(context?.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(context?.Operators.WhereOrNull<Claim.ProcedureComponent>((ItemOnLine?.Procedure as IEnumerable<Claim.ProcedureComponent>), (Claim.ProcedureComponent @this) => context?.Operators.Not((bool?)(@this?.Procedure == null))), (Claim.ProcedureComponent @this) => @this?.Procedure), (DataType @this) => context?.Operators.Not((bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null))), (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context?.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings))))))))
;
				var m_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB
				{
					Claim = k_,
					ProcedureItems = l_,
				};
				var n_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB[]
				{
					m_,
				};
				var o_ = (Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB DiagnosisCheck) =>
				{
					var g_ = DiagnosisCheck?.ProcedureItems;
					var h_ = new Claim[]
					{
						g_,
					};
					var i_ = (Claim ClaimforDiagnosis) =>
					{
						var a_ = (ClaimforDiagnosis?.Item as IEnumerable<Claim.ItemComponent>);
						var b_ = (((ClaimforDiagnosis == null))
							? (null)
							: (context?.Operators.SingleOrNull<Claim>(context?.Operators.WhereOrNull<Claim>(new Claim[]
										{
											ClaimforDiagnosis,
										}, (Claim RightClaim) => context?.Operators.ExistsInList<Claim.DiagnosisComponent>(context?.Operators.WhereOrNull<Claim.DiagnosisComponent>((RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent RightDiagnosis) => context?.Operators.And(context?.Operators.Equal((FHIRHelpers_4_0_001.ToInteger(context?.Operators?.TypeConverter.Convert<Integer>((RightDiagnosis?.SequenceElement as object))) as object), ((int?)1 as object)), context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.LateBoundProperty<IEnumerable<Coding>>((RightDiagnosis?.Diagnosis as object), "coding"), (Coding DiagnosisCode) => context?.Operators.InList<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithProcedure?.DiagnosesAsStrings))))))))))
;
						var c_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI
						{
							Procedure = a_,
							LineItems = b_,
						};
						var d_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI[]
						{
							c_,
						};
						var e_ = (Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI LineItemDefinition) => (((context?.Operators.And(context?.Operators.Not((bool?)(LineItemDefinition == null)), context?.Operators.Not((bool?)(LineItemDefinition?.LineItems == null))) ?? false))
							? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
								{
									Claim = LineItemDefinition?.LineItems,
									ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((LineItemDefinition?.LineItems?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval((NormalDate?.Serviced as object))),
								})
							: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)))
;
						var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(d_, e_);

						return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(f_);
					};
					var j_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(h_, i_);

					return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(j_);
				};
				var p_ = context?.Operators.SelectOrNull<Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(n_, o_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(p_);
			};
			var t_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(r_, s_);
			var u_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
			{
				var q_ = (bool?)(FinalList == null);

				return context?.Operators.Not(q_);
			};

			return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(t_, u_);
		};
		var ad_ = context?.Operators.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(ab_, ac_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(ad_);
	}


    [CqlDeclaration("Medical Claims With Principal Diagnosis")]
    public IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> Medical_Claims_With_Principal_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var k_ = this.Professional_or_Institutional_Claims(claim);
		var l_ = (CqlCode d) => d?.code;
		var m_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, l_);
		var n_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = k_,
			DiagnosesAsStrings = m_,
		};
		var o_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			n_,
		};
		var p_ = (Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis) =>
		{
			var f_ = (((ClaimWithDiagnosis?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, (Claim RightClaim) => context?.Operators.ExistsInList<Claim.DiagnosisComponent>(context?.Operators.WhereOrNull<Claim.DiagnosisComponent>((RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent RightDiagnosis) => context?.Operators.And(context?.Operators.Equal((FHIRHelpers_4_0_001.ToInteger(context?.Operators?.TypeConverter.Convert<Integer>((RightDiagnosis?.SequenceElement as object))) as object), ((int?)1 as object)), context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.LateBoundProperty<IEnumerable<Coding>>((RightDiagnosis?.Diagnosis as object), "coding"), (Coding DiagnosisCode) => context?.Operators.InList<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings)))))))))
;
			var g_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN
			{
				LineItems = f_,
			};
			var h_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN[]
			{
				g_,
			};
			var i_ = (Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN LineItemDefinition) =>
			{
				var b_ = LineItemDefinition?.LineItems;
				var c_ = (Claim ClaimWithDiagnosis) => (((context?.Operators.Not((bool?)(ClaimWithDiagnosis == null)) ?? false))
					? (new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = LineItemDefinition?.LineItems,
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Claim>(LineItemDefinition?.LineItems, (Claim @this) => context?.Operators.Not((bool?)(@this?.Item == null))), (Claim @this) => @this?.Item)), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval((NormalDate?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI)))
;
				var d_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(b_, c_);
				var e_ = (Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList) =>
				{
					var a_ = (bool?)(FinalList == null);

					return context?.Operators.Not(a_);
				};

				return context?.Operators.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(d_, e_);
			};
			var j_ = context?.Operators.SelectOrNull<Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(h_, i_);

			return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(j_);
		};
		var q_ = context?.Operators.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(o_, p_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(q_);
	}


    [CqlDeclaration("Get All Professional and Institutional Claims and Claim Responses")]
    public Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		var a_ = this.Professional_or_Institutional_Claims_Response(claimResponse);
		var b_ = this.Professional_or_Institutional_Claims(claim);

		return new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM
		{
			MedicalClaimResponse = a_,
			MedicalClaim = b_,
		};
	}


    [CqlDeclaration("Get All Paid Claim Reponses")]
    public IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> Get_All_Paid_Claim_Reponses(IEnumerable<ClaimResponse> claimResponse)
	{
		var as_ = (ClaimResponse ResponseItem) =>
		{
			var a_ = (ResponseItem?.OutcomeElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "complete";
			var d_ = "partial";
			var e_ = new string[]
			{
				c_,
				d_,
			};
			var f_ = (e_ as IEnumerable<string>);

			return context?.Operators.InList<string>(b_, f_);
		};
		var at_ = context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, as_);
		var au_ = new Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD
		{
			PaidResponse = at_,
		};
		var av_ = new Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD[]
		{
			au_,
		};
		var aw_ = (Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD ClaimResponse) =>
		{
			var aq_ = ClaimResponse?.PaidResponse;
			var ar_ = (ClaimResponse ClmResp) =>
			{
				var aj_ = ClmResp;
				var ak_ = (ClmResp?.Request?.ReferenceElement as object);
				var al_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(ak_);
				var am_ = NCQAFHIRBase_1_0_0.GetId(al_);
				var an_ = (ClmResp?.Item as IEnumerable<ClaimResponse.ItemComponent>);
				var ao_ = (ClaimResponse.ItemComponent ResponseItem) =>
				{
					var o_ = ResponseItem?.Adjudication;
					var p_ = (ClaimResponse.AdjudicationComponent @this) =>
					{
						var g_ = (bool?)(@this?.Category == null);

						return context?.Operators.Not(g_);
					};
					var q_ = context?.Operators.WhereOrNull<ClaimResponse.AdjudicationComponent>(o_, p_);
					var r_ = (ClaimResponse.AdjudicationComponent @this) => @this?.Category;
					var s_ = context?.Operators.SelectOrNull<ClaimResponse.AdjudicationComponent, CodeableConcept>(q_, r_);
					var t_ = (CodeableConcept @this) =>
					{
						var h_ = (bool?)(@this?.Coding == null);

						return context?.Operators.Not(h_);
					};
					var u_ = context?.Operators.WhereOrNull<CodeableConcept>(s_, t_);
					var v_ = (CodeableConcept @this) => @this?.Coding;
					var w_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(u_, v_);
					var x_ = context?.Operators.FlattenList<Coding>(w_);
					var y_ = (Coding CategoryItem) =>
					{
						var i_ = (CategoryItem?.CodeElement?.Value as object);

						return context?.Operators.Equal(i_, ("benefit" as object));
					};
					var z_ = context?.Operators.WhereOrNull<Coding>(x_, y_);
					var aa_ = context?.Operators.ExistsInList<Coding>(z_);
					var ab_ = ResponseItem?.Adjudication;
					var ac_ = (ClaimResponse.AdjudicationComponent @this) =>
					{
						var j_ = (bool?)(@this?.Amount == null);

						return context?.Operators.Not(j_);
					};
					var ad_ = context?.Operators.WhereOrNull<ClaimResponse.AdjudicationComponent>(ab_, ac_);
					var ae_ = (ClaimResponse.AdjudicationComponent @this) => @this?.Amount;
					var af_ = context?.Operators.SelectOrNull<ClaimResponse.AdjudicationComponent, Money>(ad_, ae_);
					var ag_ = (Money DollarAmount) =>
					{
						var k_ = DollarAmount?.ValueElement;
						var l_ = FHIRHelpers_4_0_001.ToDecimal(k_);
						var m_ = (l_ as object);
						var n_ = (context?.Operators.ConvertIntegerToDecimal((int?)0) as object);

						return context?.Operators.Greater(m_, n_);
					};
					var ah_ = context?.Operators.WhereOrNull<Money>(af_, ag_);
					var ai_ = context?.Operators.ExistsInList<Money>(ah_);

					return context?.Operators.And(aa_, ai_);
				};
				var ap_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(an_, ao_);

				return new Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL
				{
					Response = aj_,
					ResponseID = am_,
					LineItems = ap_,
				};
			};

			return context?.Operators.SelectOrNull<ClaimResponse, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(aq_, ar_);
		};
		var ax_ = context?.Operators.SelectOrNull<Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD, IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(av_, aw_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(ax_);
	}


    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_and_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var ar_ = (Claim AllClaims) =>
		{
			var g_ = AllClaims?.Item;
			var h_ = (Claim.ItemComponent @this) =>
			{
				var a_ = (bool?)(@this?.ProductOrService == null);

				return context?.Operators.Not(a_);
			};
			var i_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(g_, h_);
			var j_ = (Claim.ItemComponent @this) => @this?.ProductOrService;
			var k_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(i_, j_);
			var l_ = (CodeableConcept @this) =>
			{
				var b_ = (bool?)(@this?.Coding == null);

				return context?.Operators.Not(b_);
			};
			var m_ = context?.Operators.WhereOrNull<CodeableConcept>(k_, l_);
			var n_ = (CodeableConcept @this) => @this?.Coding;
			var o_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(m_, n_);
			var p_ = context?.Operators.FlattenList<Coding>(o_);
			var q_ = (Coding ProductOrServiceCode) =>
			{
				var c_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

				return context?.Operators.CodeInList(c_, ProductOrServiceValueSet);
			};
			var r_ = context?.Operators.WhereOrNull<Coding>(p_, q_);
			var s_ = context?.Operators.ExistsInList<Coding>(r_);
			var t_ = (AllClaims?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>);
			var u_ = (Claim.DiagnosisComponent @this) =>
			{
				var d_ = (bool?)(@this?.Diagnosis == null);

				return context?.Operators.Not(d_);
			};
			var v_ = context?.Operators.WhereOrNull<Claim.DiagnosisComponent>(t_, u_);
			var w_ = (Claim.DiagnosisComponent @this) => @this?.Diagnosis;
			var x_ = context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(v_, w_);
			var y_ = (DataType @this) =>
			{
				var e_ = (bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null);

				return context?.Operators.Not(e_);
			};
			var z_ = context?.Operators.WhereOrNull<DataType>(x_, y_);
			var aa_ = (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding");
			var ab_ = context?.Operators.SelectOrNull<DataType, object>(z_, aa_);
			var ac_ = context?.Operators.FlattenLateBoundList(ab_);
			var ad_ = (object @object) => (@object as Coding);
			var ae_ = context?.Operators.SelectOrNull<object, Coding>(ac_, ad_);
			var af_ = (Coding DiagnosisCode) =>
			{
				var f_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);

				return context?.Operators.CodeInList(f_, DiagnosisValueSet);
			};
			var ag_ = context?.Operators.WhereOrNull<Coding>(ae_, af_);
			var ah_ = context?.Operators.ExistsInList<Coding>(ag_);

			return context?.Operators.And(s_, ah_);
		};
		var as_ = context?.Operators.WhereOrNull<Claim>(claim, ar_);
		var at_ = (Claim ProcedureClaims) =>
		{
			var am_ = ProcedureClaims;
			var an_ = ProcedureClaims?.IdElement;
			var ao_ = (ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>);
			var ap_ = (Claim.ItemComponent ResponseItem) =>
			{
				var aj_ = (ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>);
				var ak_ = (Coding ProductOrServiceCode) =>
				{
					var ai_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

					return context?.Operators.CodeInList(ai_, ProductOrServiceValueSet);
				};
				var al_ = context?.Operators.WhereOrNull<Coding>(aj_, ak_);

				return context?.Operators.ExistsInList<Coding>(al_);
			};
			var aq_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ao_, ap_);

			return new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = am_,
				ClaimID = an_,
				LineItems = aq_,
			};
		};

		return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(as_, at_);
	}


    [CqlDeclaration("Get Corresponding Claim for Services and Conditions")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_and_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var am_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var an_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		var ao_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = am_,
			MedicalClaim = an_,
		};
		var ap_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			ao_,
		};
		var aq_ = (Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse) =>
		{
			var af_ = ClaimAndResponse?.MedicalClaim;
			var ag_ = (Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim) =>
			{
				var w_ = medClaim;
				var x_ = medClaim?.LineItems;
				var y_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					var u_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var p_ = pClaim?.LineItems;
						var q_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
						{
							var a_ = (((medClaim?.ClaimofInterest is Resource)
								? ((medClaim?.ClaimofInterest as Resource)?.IdElement)
								: (null))
 as object);
							var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
							var c_ = (b_ as object);
							var d_ = (pClaim?.Response?.Request?.ReferenceElement as object);
							var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
							var f_ = NCQAFHIRBase_1_0_0.GetId(e_);
							var g_ = (f_ as object);
							var h_ = context?.Operators.Equal(c_, g_);
							var i_ = (medClaimLineItem?.SequenceElement as object);
							var j_ = context?.Operators?.TypeConverter.Convert<Integer>(i_);
							var k_ = (j_ as object);
							var l_ = (pClaimLineItem?.ItemSequenceElement as object);
							var m_ = context?.Operators?.TypeConverter.Convert<Integer>(l_);
							var n_ = (m_ as object);
							var o_ = context?.Operators.Equal(k_, n_);

							return context?.Operators.And(h_, o_);
						};
						var r_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(p_, q_);
						var s_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;

						return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(r_, s_);
					};
					var v_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(t_, u_);

					return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_);
				};
				var z_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(x_, y_);

				return new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = w_,
					ClaimItem = z_,
				};
			};
			var ah_ = context?.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(af_, ag_);
			var ai_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = ah_,
			};
			var aj_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				ai_,
			};
			var ak_ = (Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse) =>
			{
				var ab_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem))) ?? false))
					? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.PaidClaim == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.PaidClaim),
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval((PaidItem?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
;
				var ac_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ab_,
				};
				var ad_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
				{
					var aa_ = (bool?)(FinalList == null);

					return context?.Operators.Not(aa_);
				};
				var ae_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ac_, ad_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ae_);
			};
			var al_ = context?.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_, ak_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(al_);
		};
		var ar_ = context?.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ap_, aq_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ar_);
	}


    [CqlDeclaration("Get Paid Claims for Provided Service and Condition")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Service_and_Condition(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var b_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var c_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			b_,
		};
		var d_ = (Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse) => (((context?.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse == null), (bool?)(MedicalClaimAndResponse?.MedicalClaim == null)) ?? false))
			? ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))
			: (this.Get_Corresponding_Claim_for_Services_and_Conditions(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet)))
;
		var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(c_, d_);
		var f_ = context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(e_);
		var g_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
		{
			f_,
		};
		var h_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
		{
			var a_ = (bool?)(FinalList == null);

			return context?.Operators.Not(a_);
		};
		var i_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(g_, h_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(i_);
	}


    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_or_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var ai_ = (Claim AllClaims) =>
		{
			var g_ = AllClaims?.Item;
			var h_ = (Claim.ItemComponent @this) =>
			{
				var a_ = (bool?)(@this?.ProductOrService == null);

				return context?.Operators.Not(a_);
			};
			var i_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(g_, h_);
			var j_ = (Claim.ItemComponent @this) => @this?.ProductOrService;
			var k_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(i_, j_);
			var l_ = (CodeableConcept @this) =>
			{
				var b_ = (bool?)(@this?.Coding == null);

				return context?.Operators.Not(b_);
			};
			var m_ = context?.Operators.WhereOrNull<CodeableConcept>(k_, l_);
			var n_ = (CodeableConcept @this) => @this?.Coding;
			var o_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(m_, n_);
			var p_ = context?.Operators.FlattenList<Coding>(o_);
			var q_ = (Coding ProductOrServiceCode) =>
			{
				var c_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

				return context?.Operators.CodeInList(c_, ProductOrServiceValueSet);
			};
			var r_ = context?.Operators.WhereOrNull<Coding>(p_, q_);
			var s_ = context?.Operators.ExistsInList<Coding>(r_);
			var t_ = (AllClaims?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>);
			var u_ = (Claim.DiagnosisComponent @this) =>
			{
				var d_ = (bool?)(@this?.Diagnosis == null);

				return context?.Operators.Not(d_);
			};
			var v_ = context?.Operators.WhereOrNull<Claim.DiagnosisComponent>(t_, u_);
			var w_ = (Claim.DiagnosisComponent @this) => @this?.Diagnosis;
			var x_ = context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(v_, w_);
			var y_ = (DataType @this) =>
			{
				var e_ = (bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null);

				return context?.Operators.Not(e_);
			};
			var z_ = context?.Operators.WhereOrNull<DataType>(x_, y_);
			var aa_ = (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding");
			var ab_ = context?.Operators.SelectOrNull<DataType, object>(z_, aa_);
			var ac_ = context?.Operators.FlattenLateBoundList(ab_);
			var ad_ = (object @object) => (@object as Coding);
			var ae_ = context?.Operators.SelectOrNull<object, Coding>(ac_, ad_);
			var af_ = (Coding DiagnosisCode) =>
			{
				var f_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);

				return context?.Operators.CodeInList(f_, DiagnosisValueSet);
			};
			var ag_ = context?.Operators.WhereOrNull<Coding>(ae_, af_);
			var ah_ = context?.Operators.ExistsInList<Coding>(ag_);

			return context?.Operators.Or(s_, ah_);
		};
		var aj_ = context?.Operators.WhereOrNull<Claim>(claim, ai_);
		var ak_ = (Claim ProcedureClaims) => (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), (Coding ProductOrServiceCode) => context?.Operators.CodeInList(FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode), ProductOrServiceValueSet))))) ?? false))
			? (new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
				{
					ClaimofInterest = ProcedureClaims,
					ClaimID = ProcedureClaims?.IdElement,
					LineItems = context?.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), (Coding ProductOrServiceCode) => context?.Operators.CodeInList(FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode), ProductOrServiceValueSet)))),
				})
			: (new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
				{
					ClaimofInterest = ProcedureClaims,
					ClaimID = ProcedureClaims?.IdElement,
					LineItems = context?.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => context?.Operators.Equal((context?.Operators?.TypeConverter.Convert<Integer>((ResponseItem?.SequenceElement as object))?.Value as object), ((int?)1 as object))),
				}))
;

		return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(aj_, ak_);
	}


    [CqlDeclaration("Get Corresponding Claim for Services or Conditions")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var am_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var an_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		var ao_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = am_,
			MedicalClaim = an_,
		};
		var ap_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			ao_,
		};
		var aq_ = (Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse) =>
		{
			var af_ = ClaimAndResponse?.MedicalClaim;
			var ag_ = (Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim) =>
			{
				var w_ = medClaim;
				var x_ = medClaim?.LineItems;
				var y_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					var u_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var p_ = pClaim?.LineItems;
						var q_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
						{
							var a_ = (((medClaim?.ClaimofInterest is Resource)
								? ((medClaim?.ClaimofInterest as Resource)?.IdElement)
								: (null))
 as object);
							var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
							var c_ = (b_ as object);
							var d_ = (pClaim?.Response?.Request?.ReferenceElement as object);
							var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
							var f_ = NCQAFHIRBase_1_0_0.GetId(e_);
							var g_ = (f_ as object);
							var h_ = context?.Operators.Equal(c_, g_);
							var i_ = (medClaimLineItem?.SequenceElement as object);
							var j_ = context?.Operators?.TypeConverter.Convert<Integer>(i_);
							var k_ = (j_ as object);
							var l_ = (pClaimLineItem?.ItemSequenceElement as object);
							var m_ = context?.Operators?.TypeConverter.Convert<Integer>(l_);
							var n_ = (m_ as object);
							var o_ = context?.Operators.Equal(k_, n_);

							return context?.Operators.And(h_, o_);
						};
						var r_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(p_, q_);
						var s_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;

						return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(r_, s_);
					};
					var v_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(t_, u_);

					return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_);
				};
				var z_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(x_, y_);

				return new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = w_,
					ClaimItem = z_,
				};
			};
			var ah_ = context?.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(af_, ag_);
			var ai_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = ah_,
			};
			var aj_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				ai_,
			};
			var ak_ = (Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse) =>
			{
				var ab_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem))) ?? false))
					? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.PaidClaim == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.PaidClaim),
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval((PaidItem?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
;
				var ac_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ab_,
				};
				var ad_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
				{
					var aa_ = (bool?)(FinalList == null);

					return context?.Operators.Not(aa_);
				};
				var ae_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ac_, ad_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ae_);
			};
			var al_ = context?.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_, ak_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(al_);
		};
		var ar_ = context?.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ap_, aq_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ar_);
	}


    [CqlDeclaration("Get Paid Claims for Provided Services or Conditions")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			a_,
		};
		var c_ = (Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse) => (((context?.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse == null), (bool?)(MedicalClaimAndResponse?.MedicalClaim == null)) ?? false))
			? ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))
			: (this.Get_Corresponding_Claim_for_Services_or_Conditions(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet)))
;
		var d_ = context?.Operators.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);
	}


    [CqlDeclaration("Get All Claims With Procedure Only")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_Only(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var y_ = (Claim AllClaims) =>
		{
			var d_ = AllClaims?.Item;
			var e_ = (Claim.ItemComponent @this) =>
			{
				var a_ = (bool?)(@this?.ProductOrService == null);

				return context?.Operators.Not(a_);
			};
			var f_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(d_, e_);
			var g_ = (Claim.ItemComponent @this) => @this?.ProductOrService;
			var h_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(f_, g_);
			var i_ = (CodeableConcept @this) =>
			{
				var b_ = (bool?)(@this?.Coding == null);

				return context?.Operators.Not(b_);
			};
			var j_ = context?.Operators.WhereOrNull<CodeableConcept>(h_, i_);
			var k_ = (CodeableConcept @this) => @this?.Coding;
			var l_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(j_, k_);
			var m_ = context?.Operators.FlattenList<Coding>(l_);
			var n_ = (Coding ProductOrServiceCode) =>
			{
				var c_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

				return context?.Operators.CodeInList(c_, ProductOrServiceValueSet);
			};
			var o_ = context?.Operators.WhereOrNull<Coding>(m_, n_);

			return context?.Operators.ExistsInList<Coding>(o_);
		};
		var z_ = context?.Operators.WhereOrNull<Claim>(claim, y_);
		var aa_ = (Claim AllClaims) =>
		{
			var t_ = AllClaims;
			var u_ = AllClaims?.IdElement;
			var v_ = (AllClaims?.Item as IEnumerable<Claim.ItemComponent>);
			var w_ = (Claim.ItemComponent ResponseItem) =>
			{
				var q_ = (ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>);
				var r_ = (Coding ProductOrServiceCode) =>
				{
					var p_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

					return context?.Operators.CodeInList(p_, ProductOrServiceValueSet);
				};
				var s_ = context?.Operators.WhereOrNull<Coding>(q_, r_);

				return context?.Operators.ExistsInList<Coding>(s_);
			};
			var x_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(v_, w_);

			return new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = t_,
				ClaimID = u_,
				LineItems = x_,
			};
		};

		return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(z_, aa_);
	}


    [CqlDeclaration("Get Corresponding Claim for Services Only")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var am_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var an_ = this.Get_All_Claims_With_Procedure_Only(claim, ProductOrServiceValueSet);
		var ao_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = am_,
			MedicalClaim = an_,
		};
		var ap_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			ao_,
		};
		var aq_ = (Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse) =>
		{
			var af_ = ClaimAndResponse?.MedicalClaim;
			var ag_ = (Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim) =>
			{
				var w_ = medClaim;
				var x_ = medClaim?.LineItems;
				var y_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var t_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					var u_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var p_ = pClaim?.LineItems;
						var q_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
						{
							var a_ = (((medClaim?.ClaimofInterest is Resource)
								? ((medClaim?.ClaimofInterest as Resource)?.IdElement)
								: (null))
 as object);
							var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
							var c_ = (b_ as object);
							var d_ = (pClaim?.Response?.Request?.ReferenceElement as object);
							var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
							var f_ = NCQAFHIRBase_1_0_0.GetId(e_);
							var g_ = (f_ as object);
							var h_ = context?.Operators.Equal(c_, g_);
							var i_ = (medClaimLineItem?.SequenceElement as object);
							var j_ = context?.Operators?.TypeConverter.Convert<Integer>(i_);
							var k_ = (j_ as object);
							var l_ = (pClaimLineItem?.ItemSequenceElement as object);
							var m_ = context?.Operators?.TypeConverter.Convert<Integer>(l_);
							var n_ = (m_ as object);
							var o_ = context?.Operators.Equal(k_, n_);

							return context?.Operators.And(h_, o_);
						};
						var r_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(p_, q_);
						var s_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;

						return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(r_, s_);
					};
					var v_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(t_, u_);

					return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_);
				};
				var z_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(x_, y_);

				return new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = w_,
					ClaimItem = z_,
				};
			};
			var ah_ = context?.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(af_, ag_);
			var ai_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = ah_,
			};
			var aj_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				ai_,
			};
			var ak_ = (Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse) =>
			{
				var ab_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem))) ?? false))
					? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.PaidClaim == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.PaidClaim),
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval((PaidItem?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
;
				var ac_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ab_,
				};
				var ad_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
				{
					var aa_ = (bool?)(FinalList == null);

					return context?.Operators.Not(aa_);
				};
				var ae_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ac_, ad_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ae_);
			};
			var al_ = context?.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_, ak_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(al_);
		};
		var ar_ = context?.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ap_, aq_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ar_);
	}


    [CqlDeclaration("Get Paid Claims for Provided Services Only")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			a_,
		};
		var c_ = (Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse) => (((context?.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse == null), (bool?)(MedicalClaimAndResponse?.MedicalClaim == null)) ?? false))
			? ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))
			: (this.Get_Corresponding_Claim_for_Services_Only(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet)))
;
		var d_ = context?.Operators.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);
	}


    [CqlDeclaration("Get All Pharmacy Claims and Claim Responses")]
    public Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR Get_All_Pharmacy_Claims_and_Claim_Responses(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		var a_ = this.Pharmacy_Claims_Response(claimResponse);
		var b_ = this.Pharmacy_Claims(claim);

		return new Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR
		{
			PharmacyClaimResponse = a_,
			PharmacyClaim = b_,
		};
	}


    [CqlDeclaration("Get Corresponding Claim for Pharmacy Services")]
    public Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO Get_Corresponding_Claim_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var am_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var an_ = this.Pharmacy_Claim_With_Medication(claim, ProductOrServiceValueSet);
		var ao_ = new Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB
		{
			PaidPharmacyClaimResponse = am_,
			MedicalClaim = an_,
		};
		var ap_ = new Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB[]
		{
			ao_,
		};
		var aq_ = (Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB ClaimAndResponse) =>
		{
			var af_ = ClaimAndResponse?.MedicalClaim;
			var ag_ = (Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC medClaim) =>
			{
				var w_ = medClaim;
				var x_ = medClaim?.LineItem;
				var y_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var t_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
					var u_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var p_ = pClaim?.LineItems;
						var q_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
						{
							var a_ = (((medClaim?.Claim is Resource)
								? ((medClaim?.Claim as Resource)?.IdElement)
								: (null))
 as object);
							var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
							var c_ = (b_ as object);
							var d_ = (pClaim?.Response?.Request?.ReferenceElement as object);
							var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
							var f_ = NCQAFHIRBase_1_0_0.GetId(e_);
							var g_ = (f_ as object);
							var h_ = context?.Operators.Equal(c_, g_);
							var i_ = (medClaimLineItem?.SequenceElement as object);
							var j_ = context?.Operators?.TypeConverter.Convert<Integer>(i_);
							var k_ = (j_ as object);
							var l_ = (pClaimLineItem?.ItemSequenceElement as object);
							var m_ = context?.Operators?.TypeConverter.Convert<Integer>(l_);
							var n_ = (m_ as object);
							var o_ = context?.Operators.Equal(k_, n_);

							return context?.Operators.And(h_, o_);
						};
						var r_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(p_, q_);
						var s_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;

						return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(r_, s_);
					};
					var v_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(t_, u_);

					return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(v_);
				};
				var z_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(x_, y_);

				return new Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT
				{
					PaidClaim = w_,
					ClaimItem = z_,
				};
			};
			var ah_ = context?.Operators.SelectOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC, Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(af_, ag_);
			var ai_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB
			{
				AggregateClaim = ah_,
			};
			var aj_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB[]
			{
				ai_,
			};
			var ak_ = (Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB ClaimWithPaidResponse) =>
			{
				var ab_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => @this?.ClaimItem))) ?? false))
					? (new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO
						{
							originalClaim = context?.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(context?.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => context?.Operators.Not((bool?)(@this?.PaidClaim == null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => @this?.PaidClaim),
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => @this?.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval((PaidItem?.Serviced as object))),
							CoveredDays = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDate>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => @this?.ClaimItem)), (Claim.ItemComponent i) => (((context?.Operators.Not((bool?)(i?.Quantity == null)) ?? false))
									? (context?.Operators.Interval(context?.Operators.ConvertDateTimeToDate(context?.Operators.Start(NCQAFHIRBase_1_0_0.Normalize_Interval((i?.Serviced as object)))), context?.Operators.ConvertDateTimeToDate(context?.Operators.Subtract(context?.Operators.Add(context?.Operators.Start(NCQAFHIRBase_1_0_0.Normalize_Interval((i?.Serviced as object))), new CqlQuantity
														{
															value = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement),
															unit = "day",
														}), context?.Operators.Quantity(1m, "day"))), true, true))
									: ((null as CqlInterval<CqlDate>)))
),
						})
					: ((null as Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO)))
;
				var ac_ = new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO[]
				{
					ab_,
				};
				var ad_ = (Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO FinalList) =>
				{
					var aa_ = (bool?)(FinalList == null);

					return context?.Operators.Not(aa_);
				};
				var ae_ = context?.Operators.WhereOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(ac_, ad_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(ae_);
			};
			var al_ = context?.Operators.SelectOrNull<Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(aj_, ak_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(al_);
		};
		var ar_ = context?.Operators.SelectOrNull<Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(ap_, aq_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(ar_);
	}


    [CqlDeclaration("Get Paid Claims for Pharmacy Services")]
    public Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO Get_Paid_Claims_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR[]
		{
			a_,
		};
		var c_ = (Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR PharmacyClaimAndResponse) => (((context?.Operators.And((bool?)(PharmacyClaimAndResponse?.PharmacyClaimResponse == null), (bool?)(PharmacyClaimAndResponse?.PharmacyClaim == null)) ?? false))
			? ((null as Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO))
			: (this.Get_Corresponding_Claim_for_Pharmacy_Services(PharmacyClaimAndResponse?.PharmacyClaimResponse, PharmacyClaimAndResponse?.PharmacyClaim, ProductOrServiceValueSet)))
;
		var d_ = context?.Operators.SelectOrNull<Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(b_, c_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(d_);
	}


    [CqlDeclaration("Get Claim With Corresponding Claim Response")]
    public IEnumerable<Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI> Get_Claim_With_Corresponding_Claim_Response(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
	{
		var am_ = (Claim Claim) =>
		{
			var ai_ = (ClaimResponse CR) =>
			{
				var a_ = (Claim?.IdElement as object);
				var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
				var c_ = (b_ as object);
				var d_ = (CR?.Request?.ReferenceElement as object);
				var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
				var f_ = NCQAFHIRBase_1_0_0.GetId(e_);
				var g_ = (f_ as object);

				return context?.Operators.Equal(c_, g_);
			};
			var aj_ = context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, ai_);
			var ak_ = (Claim C) =>
			{
				var q_ = (Claim?.IdElement as object);
				var r_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(q_);
				var s_ = (r_ as object);
				var t_ = (ClaimResponse CR) =>
				{
					var h_ = (Claim?.IdElement as object);
					var i_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(h_);
					var j_ = (i_ as object);
					var k_ = (CR?.Request?.ReferenceElement as object);
					var l_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(k_);
					var m_ = NCQAFHIRBase_1_0_0.GetId(l_);
					var n_ = (m_ as object);

					return context?.Operators.Equal(j_, n_);
				};
				var u_ = context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, t_);
				var v_ = (ClaimResponse @this) =>
				{
					var o_ = (bool?)(@this?.Request == null);

					return context?.Operators.Not(o_);
				};
				var w_ = context?.Operators.WhereOrNull<ClaimResponse>(u_, v_);
				var x_ = (ClaimResponse @this) => @this?.Request;
				var y_ = context?.Operators.SelectOrNull<ClaimResponse, ResourceReference>(w_, x_);
				var z_ = (ResourceReference @this) =>
				{
					var p_ = (bool?)(@this?.ReferenceElement == null);

					return context?.Operators.Not(p_);
				};
				var aa_ = context?.Operators.WhereOrNull<ResourceReference>(y_, z_);
				var ab_ = (ResourceReference @this) => @this?.ReferenceElement;
				var ac_ = context?.Operators.SelectOrNull<ResourceReference, FhirString>(aa_, ab_);
				var ad_ = context?.Operators.SingleOrNull<FhirString>(ac_);
				var ae_ = (ad_ as object);
				var af_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(ae_);
				var ag_ = NCQAFHIRBase_1_0_0.GetId(af_);
				var ah_ = (ag_ as object);

				return context?.Operators.Equal(s_, ah_);
			};
			var al_ = context?.Operators.WhereOrNull<Claim>(claim, ak_);

			return new Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI
			{
				ClaimResponse = aj_,
				OriginalClaim = al_,
			};
		};

		return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI>(claim, am_);
	}


    [CqlDeclaration("Medical Claims With Nonacute or Acute Inpatient Discharge")]
    public Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(IEnumerable<Claim> claim)
	{
		var ab_ = this.Professional_or_Institutional_Claims(claim);
		var ac_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = ab_,
		};
		var ad_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			ac_,
		};
		var ae_ = (Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithInpatientStay) =>
		{
			var v_ = (((ClaimWithInpatientStay?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithInpatientStay?.MedicalClaim, (Claim c) => context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.WhereOrNull<Claim.ItemComponent>((c?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent i) => context?.Operators.ExistsInList<CqlCode>(context?.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(i?.Revenue)?.codes as IEnumerable<CqlCode>), (CqlCode rev) => context?.Operators.StringInValueSet(rev?.code, this.Inpatient_Stay()))))))))
;
			var w_ = (((ClaimWithInpatientStay?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithInpatientStay?.MedicalClaim, (Claim c) => context?.Operators.Or(context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.WhereOrNull<Claim.ItemComponent>((c?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent i) => context?.Operators.ExistsInList<CqlCode>(context?.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(i?.Revenue)?.codes as IEnumerable<CqlCode>), (CqlCode rev) => context?.Operators.StringInValueSet(rev?.code, this.Nonacute_Inpatient_Stay()))))), context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>((c?.SubType?.Coding as IEnumerable<Coding>), (Coding tob) => context?.Operators.StringInValueSet(tob?.CodeElement?.Value, this.Nonacute_Inpatient_Stay())))))))
;
			var x_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb
			{
				InpatientStayLineItems = v_,
				NonacuteInpatientLineItems = w_,
			};
			var y_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb[]
			{
				x_,
			};
			var z_ = (Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb LineItemDefinition) =>
			{
				var m_ = LineItemDefinition?.InpatientStayLineItems;
				var n_ = LineItemDefinition?.NonacuteInpatientLineItems;
				var o_ = (Claim nonAcuteInpatientStay) =>
				{
					var c_ = LineItemDefinition?.InpatientStayLineItems;
					var d_ = (Claim inpatientStay) =>
					{
						var a_ = (nonAcuteInpatientStay?.IdElement as object);
						var b_ = (inpatientStay?.IdElement as object);

						return context?.Operators.Equal(a_, b_);
					};
					var e_ = context?.Operators.WhereOrNull<Claim>(c_, d_);
					var f_ = (Claim inpatientStay) => nonAcuteInpatientStay;

					return context?.Operators.SelectOrNull<Claim, Claim>(e_, f_);
				};
				var p_ = context?.Operators.SelectManyOrNull<Claim, Claim>(n_, o_);
				var q_ = LineItemDefinition?.InpatientStayLineItems;
				var r_ = LineItemDefinition?.InpatientStayLineItems;
				var s_ = (Claim inpatientStay) =>
				{
					var i_ = LineItemDefinition?.NonacuteInpatientLineItems;
					var j_ = (Claim nonAcuteInpatientStay) =>
					{
						var g_ = (inpatientStay?.IdElement as object);
						var h_ = (nonAcuteInpatientStay?.IdElement as object);

						return context?.Operators.Equal(g_, h_);
					};
					var k_ = context?.Operators.WhereOrNull<Claim>(i_, j_);
					var l_ = (Claim nonAcuteInpatientStay) => inpatientStay;

					return context?.Operators.SelectOrNull<Claim, Claim>(k_, l_);
				};
				var t_ = context?.Operators.SelectManyOrNull<Claim, Claim>(r_, s_);
				var u_ = context?.Operators.ListExcept<Claim>(q_, t_);

				return new Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE
				{
					InpatientDischarge = m_,
					NonacuteInpatientDischarge = p_,
					AcuteInpatientDischarge = u_,
				};
			};
			var aa_ = context?.Operators.SelectOrNull<Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb, Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(y_, z_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(aa_);
		};
		var af_ = context?.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(ad_, ae_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(af_);
	}


    [CqlDeclaration("Get Prescriber NPI from Claims")]
    public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Prescriber_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		var cq_ = (Claim C) =>
		{
			var r_ = C;
			var s_ = (C?.CareTeam as IEnumerable<Claim.CareTeamComponent>);
			var t_ = (Claim.CareTeamComponent ct) =>
			{
				var a_ = (ct?.SequenceElement as object);
				var b_ = context?.Operators?.TypeConverter.Convert<Integer>(a_);
				var c_ = FHIRHelpers_4_0_001.ToInteger(b_);
				var d_ = (c_ as object);
				var e_ = ((int?)1 as object);

				return context?.Operators.Equal(d_, e_);
			};
			var u_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(s_, t_);
			var v_ = (Claim.CareTeamComponent @this) =>
			{
				var f_ = (bool?)(@this?.Provider == null);

				return context?.Operators.Not(f_);
			};
			var w_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(u_, v_);
			var x_ = (Claim.CareTeamComponent @this) => @this?.Provider;
			var y_ = context?.Operators.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(w_, x_);
			var z_ = (C?.CareTeam as IEnumerable<Claim.CareTeamComponent>);
			var aa_ = (Claim.CareTeamComponent ct) =>
			{
				var g_ = (ct?.SequenceElement as object);
				var h_ = context?.Operators?.TypeConverter.Convert<Integer>(g_);
				var i_ = FHIRHelpers_4_0_001.ToInteger(h_);
				var j_ = (i_ as object);
				var k_ = ((int?)1 as object);

				return context?.Operators.Equal(j_, k_);
			};
			var ab_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(z_, aa_);
			var ac_ = (Claim.CareTeamComponent @this) =>
			{
				var l_ = (bool?)(@this?.Provider == null);

				return context?.Operators.Not(l_);
			};
			var ad_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(ab_, ac_);
			var ae_ = (Claim.CareTeamComponent @this) => @this?.Provider;
			var af_ = context?.Operators.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(ad_, ae_);
			var ag_ = (ResourceReference p) =>
			{
				var n_ = p?.ReferenceElement;
				var o_ = new FhirString[]
				{
					n_,
				};
				var p_ = (FhirString r) =>
				{
					var m_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>((r as object));

					return NCQAFHIRBase_1_0_0.GetId(m_);
				};
				var q_ = context?.Operators.SelectOrNull<FhirString, string>(o_, p_);

				return context?.Operators.SingleOrNull<string>(q_);
			};
			var ah_ = context?.Operators.SelectOrNull<ResourceReference, string>(af_, ag_);

			return new Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS
			{
				SingleCareTeam = r_,
				CareTeamsProvider = y_,
				CareTeamsProviderID = ah_,
			};
		};
		var cr_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(claim, cq_);
		var cs_ = new Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR
		{
			CareTeams = cr_,
		};
		var ct_ = new Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR[]
		{
			cs_,
		};
		var cu_ = (Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR ClaimProperties) =>
		{
			var cj_ = context?.DataRetriever.RetrieveByValueSet<Practitioner>(null, null);
			var ck_ = (Practitioner p) =>
			{
				var aj_ = (p?.IdElement as object);
				var ak_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(aj_);
				var al_ = ClaimProperties?.CareTeams;
				var am_ = (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) =>
				{
					var ai_ = (bool?)(@this?.CareTeamsProviderID == null);

					return context?.Operators.Not(ai_);
				};
				var an_ = context?.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(al_, am_);
				var ao_ = (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this?.CareTeamsProviderID;
				var ap_ = context?.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, IEnumerable<string>>(an_, ao_);
				var aq_ = context?.Operators.FlattenList<string>(ap_);

				return context?.Operators.InList<string>(ak_, aq_);
			};
			var cl_ = context?.Operators.WhereOrNull<Practitioner>(cj_, ck_);
			var cm_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe
			{
				Practitioners = cl_,
			};
			var cn_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe[]
			{
				cm_,
			};
			var co_ = (Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe PractitionerMatch) =>
			{
				var ca_ = PractitionerMatch?.Practitioners;
				var cb_ = (Practitioner P) =>
				{
					var ar_ = (bool?)(P == null);

					return context?.Operators.Not(ar_);
				};
				var cc_ = context?.Operators.WhereOrNull<Practitioner>(ca_, cb_);
				var cd_ = (Practitioner P) =>
				{
					var bp_ = (P?.Identifier as IEnumerable<Identifier>);
					var bq_ = (Identifier l) =>
					{
						var as_ = (l?.SystemElement?.Value as object);
						var at_ = context?.Operators.Equal(as_, ("http://hl7.org/fhir/sid/us-npi" as object));
						var au_ = l?.Type;
						var av_ = FHIRHelpers_4_0_001.ToConcept(au_);
						var aw_ = (av_ as object);
						var ax_ = NCQATerminology_1_0_0.Provider_number();
						var ay_ = context?.Operators.ConvertCodeToConcept(ax_);
						var az_ = (ay_ as object);
						var ba_ = context?.Operators.Equivalent(aw_, az_);
						var bb_ = context?.Operators.And(at_, ba_);
						var bc_ = (bool?)(l?.ValueElement?.Value == null);
						var bd_ = context?.Operators.Not(bc_);

						return context?.Operators.And(bb_, bd_);
					};
					var br_ = context?.Operators.WhereOrNull<Identifier>(bp_, bq_);
					var bs_ = (Identifier l) => l?.ValueElement;
					var bt_ = context?.Operators.SelectOrNull<Identifier, FhirString>(br_, bs_);
					var bu_ = (P?.Identifier as IEnumerable<Identifier>);
					var bv_ = (Identifier l) =>
					{
						var be_ = (l?.SystemElement?.Value as object);
						var bf_ = context?.Operators.Equal(be_, ("http://hl7.org/fhir/sid/us-npi" as object));
						var bg_ = l?.Type;
						var bh_ = FHIRHelpers_4_0_001.ToConcept(bg_);
						var bi_ = (bh_ as object);
						var bj_ = NCQATerminology_1_0_0.Provider_number();
						var bk_ = context?.Operators.ConvertCodeToConcept(bj_);
						var bl_ = (bk_ as object);
						var bm_ = context?.Operators.Equivalent(bi_, bl_);
						var bn_ = context?.Operators.And(bf_, bm_);
						var bo_ = (bool?)(l?.ValueElement?.Value == null);

						return context?.Operators.And(bn_, bo_);
					};
					var bw_ = context?.Operators.WhereOrNull<Identifier>(bu_, bv_);
					var bx_ = (Identifier l) => l;
					var by_ = context?.Operators.SelectOrNull<Identifier, Identifier>(bw_, bx_);

					return new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = bt_,
						NullIdentifiers = by_,
					};
				};
				var ce_ = context?.Operators.SelectOrNull<Practitioner, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(cc_, cd_);
				var cf_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = ce_,
				};
				var cg_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					cf_,
				};
				var ch_ = (Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers) =>
				{
					var bz_ = (((context?.Operators.ExistsInList<Claim>(context?.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context?.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => context?.Operators.Not((bool?)(@this?.SingleCareTeam == null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this?.SingleCareTeam)) ?? false))
						? (context?.Operators.Add(context?.Operators.Add(context?.Operators.CountOrNull<Claim>(context?.Operators.WhereOrNull<Claim>(context?.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context?.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => context?.Operators.Not((bool?)(@this?.SingleCareTeam == null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this?.SingleCareTeam), (Claim X) => (bool?)((X?.CareTeam as IEnumerable<Claim.CareTeamComponent>) == null))), context?.Operators.CountOrNull<FhirString>(context?.Operators.SelectOrNull<FhirString, FhirString>(context?.Operators.FlattenList<FhirString>(context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.AllIdentifiers)), (FhirString X) => X))), context?.Operators.CountOrNull<Identifier>(context?.Operators.FlattenList<Identifier>(context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.NullIdentifiers)))))
						: ((int?)0))
;

					return new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = bz_,
					};
				};
				var ci_ = context?.Operators.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cg_, ch_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ci_);
			};
			var cp_ = context?.Operators.SelectOrNull<Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cn_, co_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cp_);
		};
		var cv_ = context?.Operators.SelectOrNull<Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ct_, cu_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cv_);
	}


    [CqlDeclaration("Get Pharmacy NPI from Claims")]
    public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Pharmacy_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		var cs_ = (Claim C) =>
		{
			var r_ = (C?.Item as IEnumerable<Claim.ItemComponent>);
			var s_ = (C?.Item as IEnumerable<Claim.ItemComponent>);
			var t_ = (Claim.ItemComponent i) =>
			{
				var a_ = (i?.SequenceElement as object);
				var b_ = context?.Operators?.TypeConverter.Convert<Integer>(a_);
				var c_ = FHIRHelpers_4_0_001.ToInteger(b_);
				var d_ = (c_ as object);
				var e_ = ((int?)1 as object);

				return context?.Operators.Equal(d_, e_);
			};
			var u_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(s_, t_);
			var v_ = (Claim.ItemComponent @this) =>
			{
				var f_ = (bool?)(@this?.Location == null);

				return context?.Operators.Not(f_);
			};
			var w_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(u_, v_);
			var x_ = (Claim.ItemComponent @this) => @this?.Location;
			var y_ = context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(w_, x_);
			var z_ = (DataType l) => (l as ResourceReference);
			var aa_ = context?.Operators.SelectOrNull<DataType, ResourceReference>(y_, z_);
			var ab_ = (C?.Item as IEnumerable<Claim.ItemComponent>);
			var ac_ = (Claim.ItemComponent i) =>
			{
				var g_ = (i?.SequenceElement as object);
				var h_ = context?.Operators?.TypeConverter.Convert<Integer>(g_);
				var i_ = FHIRHelpers_4_0_001.ToInteger(h_);
				var j_ = (i_ as object);
				var k_ = ((int?)1 as object);

				return context?.Operators.Equal(j_, k_);
			};
			var ad_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ab_, ac_);
			var ae_ = (Claim.ItemComponent @this) =>
			{
				var l_ = (bool?)(@this?.Location == null);

				return context?.Operators.Not(l_);
			};
			var af_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ad_, ae_);
			var ag_ = (Claim.ItemComponent @this) => @this?.Location;
			var ah_ = context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(af_, ag_);
			var ai_ = (DataType l) =>
			{
				var n_ = (l as ResourceReference)?.ReferenceElement;
				var o_ = new FhirString[]
				{
					n_,
				};
				var p_ = (FhirString r) =>
				{
					var m_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>((r as object));

					return NCQAFHIRBase_1_0_0.GetId(m_);
				};
				var q_ = context?.Operators.SelectOrNull<FhirString, string>(o_, p_);

				return context?.Operators.SingleOrNull<string>(q_);
			};
			var aj_ = context?.Operators.SelectOrNull<DataType, string>(ah_, ai_);

			return new Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI
			{
				SingleItem = r_,
				ItemLocation = aa_,
				ItemLocationID = aj_,
			};
		};
		var ct_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(claim, cs_);
		var cu_ = new Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa
		{
			ItemsLocationReferences = ct_,
		};
		var cv_ = new Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa[]
		{
			cu_,
		};
		var cw_ = (Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa ClaimProperties) =>
		{
			var cl_ = context?.DataRetriever.RetrieveByValueSet<Location>(null, null);
			var cm_ = (Location l) =>
			{
				var al_ = (l?.IdElement as object);
				var am_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(al_);
				var an_ = ClaimProperties?.ItemsLocationReferences;
				var ao_ = (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) =>
				{
					var ak_ = (bool?)(@this?.ItemLocationID == null);

					return context?.Operators.Not(ak_);
				};
				var ap_ = context?.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(an_, ao_);
				var aq_ = (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this?.ItemLocationID;
				var ar_ = context?.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<string>>(ap_, aq_);
				var as_ = context?.Operators.FlattenList<string>(ar_);

				return context?.Operators.InList<string>(am_, as_);
			};
			var cn_ = context?.Operators.WhereOrNull<Location>(cl_, cm_);
			var co_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP
			{
				CorrespondingLocations = cn_,
			};
			var cp_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP[]
			{
				co_,
			};
			var cq_ = (Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP GetLocation) =>
			{
				var cc_ = GetLocation?.CorrespondingLocations;
				var cd_ = (Location C) =>
				{
					var at_ = (bool?)(C == null);

					return context?.Operators.Not(at_);
				};
				var ce_ = context?.Operators.WhereOrNull<Location>(cc_, cd_);
				var cf_ = (Location C) =>
				{
					var br_ = (C?.Identifier as IEnumerable<Identifier>);
					var bs_ = (Identifier l) =>
					{
						var au_ = (l?.SystemElement?.Value as object);
						var av_ = context?.Operators.Equal(au_, ("http://hl7.org/fhir/sid/us-npi" as object));
						var aw_ = l?.Type;
						var ax_ = FHIRHelpers_4_0_001.ToConcept(aw_);
						var ay_ = (ax_ as object);
						var az_ = NCQATerminology_1_0_0.Provider_number();
						var ba_ = context?.Operators.ConvertCodeToConcept(az_);
						var bb_ = (ba_ as object);
						var bc_ = context?.Operators.Equivalent(ay_, bb_);
						var bd_ = context?.Operators.And(av_, bc_);
						var be_ = (bool?)(l?.ValueElement?.Value == null);
						var bf_ = context?.Operators.Not(be_);

						return context?.Operators.And(bd_, bf_);
					};
					var bt_ = context?.Operators.WhereOrNull<Identifier>(br_, bs_);
					var bu_ = (Identifier l) => l?.ValueElement;
					var bv_ = context?.Operators.SelectOrNull<Identifier, FhirString>(bt_, bu_);
					var bw_ = (C?.Identifier as IEnumerable<Identifier>);
					var bx_ = (Identifier l) =>
					{
						var bg_ = (l?.SystemElement?.Value as object);
						var bh_ = context?.Operators.Equal(bg_, ("http://hl7.org/fhir/sid/us-npi" as object));
						var bi_ = l?.Type;
						var bj_ = FHIRHelpers_4_0_001.ToConcept(bi_);
						var bk_ = (bj_ as object);
						var bl_ = NCQATerminology_1_0_0.Provider_number();
						var bm_ = context?.Operators.ConvertCodeToConcept(bl_);
						var bn_ = (bm_ as object);
						var bo_ = context?.Operators.Equivalent(bk_, bn_);
						var bp_ = context?.Operators.And(bh_, bo_);
						var bq_ = (bool?)(l?.ValueElement?.Value == null);

						return context?.Operators.And(bp_, bq_);
					};
					var by_ = context?.Operators.WhereOrNull<Identifier>(bw_, bx_);
					var bz_ = (Identifier l) => l;
					var ca_ = context?.Operators.SelectOrNull<Identifier, Identifier>(by_, bz_);

					return new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = bv_,
						NullIdentifiers = ca_,
					};
				};
				var cg_ = context?.Operators.SelectOrNull<Location, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(ce_, cf_);
				var ch_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = cg_,
				};
				var ci_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					ch_,
				};
				var cj_ = (Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers) =>
				{
					var cb_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => context?.Operators.Not((bool?)(@this?.SingleItem == null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this?.SingleItem))) ?? false))
						? (context?.Operators.Add(context?.Operators.Add(context?.Operators.CountOrNull<ResourceReference>(context?.Operators.WhereOrNull<ResourceReference>(context?.Operators.FlattenList<ResourceReference>(context?.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<ResourceReference>>(context?.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => context?.Operators.Not((bool?)(@this?.ItemLocation == null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this?.ItemLocation)), (ResourceReference X) => (bool?)(X?.ReferenceElement?.Value == null))), context?.Operators.CountOrNull<FhirString>(context?.Operators.SelectOrNull<FhirString, FhirString>(context?.Operators.FlattenList<FhirString>(context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.AllIdentifiers)), (FhirString X) => X))), context?.Operators.CountOrNull<Identifier>(context?.Operators.FlattenList<Identifier>(context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.NullIdentifiers)))))
						: ((int?)0))
;

					return new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = cb_,
					};
				};
				var ck_ = context?.Operators.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ci_, cj_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ck_);
			};
			var cr_ = context?.Operators.SelectOrNull<Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cp_, cq_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cr_);
		};
		var cx_ = context?.Operators.SelectOrNull<Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cv_, cw_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cx_);
	}


}
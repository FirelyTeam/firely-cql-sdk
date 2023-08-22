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
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395", 
			null);

    [CqlDeclaration("Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395")]
    public CqlValueSet Inpatient_Stay() => __Inpatient_Stay.Value;

    private CqlValueSet Nonacute_Inpatient_Stay_Value() =>
		new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398", 
			null);

    [CqlDeclaration("Nonacute Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398")]
    public CqlValueSet Nonacute_Inpatient_Stay() => __Nonacute_Inpatient_Stay.Value;

    [CqlDeclaration("Professional or Institutional Claims")]
    public IEnumerable<Claim> Professional_or_Institutional_Claims(IEnumerable<Claim> claim)
	{
		var a_ = (Claim MedicalClaim) =>
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

		return context?.Operators.WhereOrNull<Claim>(claim, a_);
	}


    [CqlDeclaration("Pharmacy Claims")]
    public IEnumerable<Claim> Pharmacy_Claims(IEnumerable<Claim> claim)
	{
		var a_ = (Claim PharmacyClaim) =>
		{
			var a_ = PharmacyClaim?.Type;
			var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
			var c_ = (b_?.codes as IEnumerable<CqlCode>);
			var d_ = NCQATerminology_1_0_0.Pharmacy();

			return context?.Operators.ListContains<CqlCode>(c_, d_);
		};

		return context?.Operators.WhereOrNull<Claim>(claim, a_);
	}


    [CqlDeclaration("Professional or Institutional Claims Response")]
    public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		var a_ = (ClaimResponse MedicalResponse) =>
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

		return context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, a_);
	}


    [CqlDeclaration("Pharmacy Claims Response")]
    public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		var a_ = (ClaimResponse PharmacyResponse) =>
		{
			var a_ = PharmacyResponse?.Type;
			var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
			var c_ = (b_?.codes as IEnumerable<CqlCode>);
			var d_ = NCQATerminology_1_0_0.Pharmacy();

			return context?.Operators.ListContains<CqlCode>(c_, d_);
		};

		return context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, a_);
	}


    [CqlDeclaration("Medical Claims With Procedure and POS")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_and_POS(IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		var b_ = (CqlCode p) => p?.code;
		var c_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, b_);
		var d_ = (CqlCode pos) => pos?.code;
		var e_ = context?.Operators.SelectOrNull<CqlCode, string>(posCodes, d_);
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
		var h_ = (Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithPosCode) =>
		{
			var a_ = ClaimWithPosCode?.MedicalClaim;
			var b_ = (Claim ClaimofInterest) =>
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
			var c_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(a_, b_);
			var d_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
			{
				var a_ = (bool?)(FinalList == null);

				return context?.Operators.Not(a_);
			};

			return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(c_, d_);
		};
		var i_ = context?.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);
	}


    [CqlDeclaration("Medical Claims With Procedure in Header or on Line Item")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		var b_ = (CqlCode p) => p?.code;
		var c_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, b_);
		var d_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = a_,
			ProceduresAsStrings = c_,
		};
		var e_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			d_,
		};
		var f_ = (Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithProcedure) =>
		{
			var a_ = ClaimWithProcedure?.MedicalClaim;
			var b_ = (Claim ClaimofInterest) =>
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
			var c_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(a_, b_);
			var d_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
			{
				var a_ = (bool?)(FinalList == null);

				return context?.Operators.Not(a_);
			};

			return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(c_, d_);
		};
		var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(e_, f_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_);
	}


    [CqlDeclaration("Medical Claims With Diagnosis")]
    public Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI Medical_Claims_With_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		var b_ = (CqlCode d) => d?.code;
		var c_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		var d_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
		};
		var e_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			d_,
		};
		var f_ = (Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis) =>
		{
			var a_ = (((ClaimWithDiagnosis?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, (Claim DiagnosisLine) => context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.SelectOrNull<object, Coding>(context?.Operators.FlattenLateBoundList(context?.Operators.SelectOrNull<DataType, object>(context?.Operators.WhereOrNull<DataType>(context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(context?.Operators.WhereOrNull<Claim.DiagnosisComponent>((DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent @this) => context?.Operators.Not((bool?)(@this?.Diagnosis == null))), (Claim.DiagnosisComponent @this) => @this?.Diagnosis), (DataType @this) => context?.Operators.Not((bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null))), (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context?.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings))))))
;
			var b_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = a_,
			};
			var c_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				b_,
			};
			var d_ = (Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg HeaderDefinition) =>
			{
				var a_ = (((context?.Operators.ExistsInList<Claim>(HeaderDefinition?.DiagnosisItems) ?? false))
					? (new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = HeaderDefinition?.DiagnosisItems,
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Claim>(HeaderDefinition?.DiagnosisItems, (Claim @this) => context?.Operators.Not((bool?)(@this?.Item == null))), (Claim @this) => @this?.Item)), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval((NormalDate?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI)))
;
				var b_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI[]
				{
					a_,
				};
				var c_ = (Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList) =>
				{
					var a_ = (bool?)(FinalList == null);

					return context?.Operators.Not(a_);
				};
				var d_ = context?.Operators.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(b_, c_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(d_);
			};
			var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(c_, d_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(e_);
		};
		var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(e_, f_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(g_);
	}


    [CqlDeclaration("Pharmacy Claim With Medication")]
    public IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> Pharmacy_Claim_With_Medication(IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
	{
		var a_ = this.Pharmacy_Claims(claim);
		var b_ = (CqlCode p) => p?.code;
		var c_ = context?.Operators.SelectOrNull<CqlCode, string>(MedicationCodes, b_);
		var d_ = new Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY
		{
			PharmacyClaim = a_,
			MedicationsAsStrings = c_,
		};
		var e_ = new Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY[]
		{
			d_,
		};
		var f_ = (Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY ClaimWithMedication) =>
		{
			var a_ = ClaimWithMedication?.PharmacyClaim;
			var b_ = (Claim Pharmacy) =>
			{
				var a_ = Pharmacy;
				var b_ = (Pharmacy?.Item as IEnumerable<Claim.ItemComponent>);
				var c_ = (Claim.ItemComponent ItemOnLine) =>
				{
					var a_ = ItemOnLine?.ProductOrService;
					var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
					var c_ = (b_?.codes as IEnumerable<CqlCode>);
					var d_ = (CqlCode LineCode) =>
					{
						var a_ = LineCode?.code;
						var b_ = ClaimWithMedication?.MedicationsAsStrings;

						return context?.Operators.InList<string>(a_, b_);
					};
					var e_ = context?.Operators.WhereOrNull<CqlCode>(c_, d_);

					return context?.Operators.ExistsInList<CqlCode>(e_);
				};
				var d_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(b_, c_);
				var e_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = a_,
					LineItems = d_,
				};
				var f_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					e_,
				};
				var g_ = (Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition) =>
				{
					var a_ = LineItemDefinition?.Claim;
					var b_ = new Claim[]
					{
						a_,
					};
					var c_ = (Claim ClaimLines) =>
					{
						var a_ = (ClaimLines?.Item as IEnumerable<Claim.ItemComponent>);
						var b_ = (Claim.ItemComponent i) =>
						{
							var a_ = i?.ProductOrService;
							var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
							var c_ = (b_?.codes as IEnumerable<CqlCode>);
							var d_ = (CqlCode LineCode) =>
							{
								var a_ = LineCode?.code;
								var b_ = ClaimWithMedication?.MedicationsAsStrings;

								return context?.Operators.InList<string>(a_, b_);
							};
							var e_ = context?.Operators.WhereOrNull<CqlCode>(c_, d_);

							return context?.Operators.ExistsInList<CqlCode>(e_);
						};
						var c_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(a_, b_);
						var d_ = (Claim.ItemComponent i) =>
						{
							var a_ = (((context?.Operators.Not((bool?)(i?.Quantity == null)) ?? false))
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
								DaysSupplyInterval = a_,
							};
						};
						var e_ = context?.Operators.SelectOrNull<Claim.ItemComponent, Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP>(c_, d_);
						var f_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU
						{
							CoveredDays = e_,
						};
						var g_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU[]
						{
							f_,
						};
						var h_ = (Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU ItemCalculation) => (((context?.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
							? (new Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC
								{
									Claim = LineItemDefinition?.Claim,
									LineItem = LineItemDefinition?.LineItems,
									ServicePeriod = context?.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context?.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, (Claim.ItemComponent @this) => context?.Operators.Not((bool?)(@this?.Serviced == null))), (Claim.ItemComponent @this) => @this?.Serviced), (DataType NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
									CoveredDays = context?.Operators.SelectOrNull<Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP, CqlInterval<CqlDateTime>>(ItemCalculation?.CoveredDays, (Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP d) => d?.DaysSupplyInterval),
								})
							: ((null as Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC)))
;
						var i_ = context?.Operators.SelectOrNull<Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(g_, h_);

						return context?.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(i_);
					};
					var d_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(b_, c_);

					return context?.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(d_);
				};
				var h_ = context?.Operators.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(f_, g_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(h_);
			};
			var c_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(a_, b_);
			var d_ = (Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC FinalList) =>
			{
				var a_ = (bool?)(FinalList == null);

				return context?.Operators.Not(a_);
			};

			return context?.Operators.WhereOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(c_, d_);
		};
		var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY, IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(e_, f_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(g_);
	}


    [CqlDeclaration("Medical Claims With Diagnosis and Procedure")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		var b_ = (CqlCode d) => d?.code;
		var c_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		var d_ = (CqlCode p) => p?.code;
		var e_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, d_);
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
		var h_ = (Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithDiagnosis) =>
		{
			var a_ = (((ClaimWithDiagnosis?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, (Claim DiagnosisLine) => context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.SelectOrNull<object, Coding>(context?.Operators.FlattenLateBoundList(context?.Operators.SelectOrNull<DataType, object>(context?.Operators.WhereOrNull<DataType>(context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(context?.Operators.WhereOrNull<Claim.DiagnosisComponent>((DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent @this) => context?.Operators.Not((bool?)(@this?.Diagnosis == null))), (Claim.DiagnosisComponent @this) => @this?.Diagnosis), (DataType @this) => context?.Operators.Not((bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null))), (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context?.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings))))))
;
			var b_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = a_,
			};
			var c_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				b_,
			};
			var d_ = (Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg ClaimWithProcedure) =>
			{
				var a_ = ClaimWithProcedure?.DiagnosisItems;
				var b_ = (Claim ClaimofInterest) =>
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
				var c_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(a_, b_);
				var d_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
				{
					var a_ = (bool?)(FinalList == null);

					return context?.Operators.Not(a_);
				};

				return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(c_, d_);
			};
			var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(c_, d_);

			return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(e_);
		};
		var i_ = context?.Operators.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);
	}


    [CqlDeclaration("Medical Claims With Principal Diagnosis and Procedure")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Principal_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		var b_ = (CqlCode d) => d?.code;
		var c_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		var d_ = (CqlCode p) => p?.code;
		var e_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, d_);
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
		var h_ = (Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithProcedure) =>
		{
			var a_ = ClaimWithProcedure?.MedicalClaim;
			var b_ = (Claim ClaimofInterest) =>
			{
				var a_ = ClaimofInterest;
				var b_ = (((ClaimofInterest == null))
					? (null)
					: (context?.Operators.SingleOrNull<Claim>(context?.Operators.WhereOrNull<Claim>(new Claim[]
								{
									ClaimofInterest,
								}, (Claim ItemOnLine) => context?.Operators.Or(context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.FlattenList<Coding>(context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(context?.Operators.WhereOrNull<CodeableConcept>(context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(context?.Operators.WhereOrNull<Claim.ItemComponent>((ItemOnLine?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent @this) => context?.Operators.Not((bool?)(@this?.ProductOrService == null))), (Claim.ItemComponent @this) => @this?.ProductOrService), (CodeableConcept @this) => context?.Operators.Not((bool?)(@this?.Coding == null))), (CodeableConcept @this) => @this?.Coding)), (Coding LineCode) => context?.Operators.InList<string>(LineCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings))), context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.SelectOrNull<object, Coding>(context?.Operators.FlattenLateBoundList(context?.Operators.SelectOrNull<DataType, object>(context?.Operators.WhereOrNull<DataType>(context?.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(context?.Operators.WhereOrNull<Claim.ProcedureComponent>((ItemOnLine?.Procedure as IEnumerable<Claim.ProcedureComponent>), (Claim.ProcedureComponent @this) => context?.Operators.Not((bool?)(@this?.Procedure == null))), (Claim.ProcedureComponent @this) => @this?.Procedure), (DataType @this) => context?.Operators.Not((bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null))), (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context?.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings))))))))
;
				var c_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB
				{
					Claim = a_,
					ProcedureItems = b_,
				};
				var d_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB[]
				{
					c_,
				};
				var e_ = (Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB DiagnosisCheck) =>
				{
					var a_ = DiagnosisCheck?.ProcedureItems;
					var b_ = new Claim[]
					{
						a_,
					};
					var c_ = (Claim ClaimforDiagnosis) =>
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
					var d_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(b_, c_);

					return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(d_);
				};
				var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(d_, e_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(f_);
			};
			var c_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(a_, b_);
			var d_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
			{
				var a_ = (bool?)(FinalList == null);

				return context?.Operators.Not(a_);
			};

			return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(c_, d_);
		};
		var i_ = context?.Operators.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(g_, h_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(i_);
	}


    [CqlDeclaration("Medical Claims With Principal Diagnosis")]
    public IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> Medical_Claims_With_Principal_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Professional_or_Institutional_Claims(claim);
		var b_ = (CqlCode d) => d?.code;
		var c_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		var d_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = a_,
			DiagnosesAsStrings = c_,
		};
		var e_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			d_,
		};
		var f_ = (Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis) =>
		{
			var a_ = (((ClaimWithDiagnosis?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, (Claim RightClaim) => context?.Operators.ExistsInList<Claim.DiagnosisComponent>(context?.Operators.WhereOrNull<Claim.DiagnosisComponent>((RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent RightDiagnosis) => context?.Operators.And(context?.Operators.Equal((FHIRHelpers_4_0_001.ToInteger(context?.Operators?.TypeConverter.Convert<Integer>((RightDiagnosis?.SequenceElement as object))) as object), ((int?)1 as object)), context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.LateBoundProperty<IEnumerable<Coding>>((RightDiagnosis?.Diagnosis as object), "coding"), (Coding DiagnosisCode) => context?.Operators.InList<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings)))))))))
;
			var b_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN
			{
				LineItems = a_,
			};
			var c_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN[]
			{
				b_,
			};
			var d_ = (Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN LineItemDefinition) =>
			{
				var a_ = LineItemDefinition?.LineItems;
				var b_ = (Claim ClaimWithDiagnosis) => (((context?.Operators.Not((bool?)(ClaimWithDiagnosis == null)) ?? false))
					? (new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = LineItemDefinition?.LineItems,
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Claim>(LineItemDefinition?.LineItems, (Claim @this) => context?.Operators.Not((bool?)(@this?.Item == null))), (Claim @this) => @this?.Item)), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval((NormalDate?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI)))
;
				var c_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(a_, b_);
				var d_ = (Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList) =>
				{
					var a_ = (bool?)(FinalList == null);

					return context?.Operators.Not(a_);
				};

				return context?.Operators.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(c_, d_);
			};
			var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(c_, d_);

			return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(e_);
		};
		var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(e_, f_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(g_);
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
		var a_ = (ClaimResponse ResponseItem) =>
		{
			var a_ = (ResponseItem?.OutcomeElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
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
		var b_ = context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, a_);
		var c_ = new Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD
		{
			PaidResponse = b_,
		};
		var d_ = new Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD[]
		{
			c_,
		};
		var e_ = (Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD ClaimResponse) =>
		{
			var a_ = ClaimResponse?.PaidResponse;
			var b_ = (ClaimResponse ClmResp) =>
			{
				var a_ = ClmResp;
				var b_ = (ClmResp?.Request?.ReferenceElement as object);
				var c_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(b_);
				var d_ = NCQAFHIRBase_1_0_0.GetId(c_);
				var e_ = (ClmResp?.Item as IEnumerable<ClaimResponse.ItemComponent>);
				var f_ = (ClaimResponse.ItemComponent ResponseItem) =>
				{
					var a_ = ResponseItem?.Adjudication;
					var b_ = (ClaimResponse.AdjudicationComponent @this) =>
					{
						var a_ = (bool?)(@this?.Category == null);

						return context?.Operators.Not(a_);
					};
					var c_ = context?.Operators.WhereOrNull<ClaimResponse.AdjudicationComponent>(a_, b_);
					var d_ = (ClaimResponse.AdjudicationComponent @this) => @this?.Category;
					var e_ = context?.Operators.SelectOrNull<ClaimResponse.AdjudicationComponent, CodeableConcept>(c_, d_);
					var f_ = (CodeableConcept @this) =>
					{
						var a_ = (bool?)(@this?.Coding == null);

						return context?.Operators.Not(a_);
					};
					var g_ = context?.Operators.WhereOrNull<CodeableConcept>(e_, f_);
					var h_ = (CodeableConcept @this) => @this?.Coding;
					var i_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(g_, h_);
					var j_ = context?.Operators.FlattenList<Coding>(i_);
					var k_ = (Coding CategoryItem) =>
					{
						var a_ = (CategoryItem?.CodeElement?.Value as object);

						return context?.Operators.Equal(a_, ("benefit" as object));
					};
					var l_ = context?.Operators.WhereOrNull<Coding>(j_, k_);
					var m_ = context?.Operators.ExistsInList<Coding>(l_);
					var n_ = ResponseItem?.Adjudication;
					var o_ = (ClaimResponse.AdjudicationComponent @this) =>
					{
						var a_ = (bool?)(@this?.Amount == null);

						return context?.Operators.Not(a_);
					};
					var p_ = context?.Operators.WhereOrNull<ClaimResponse.AdjudicationComponent>(n_, o_);
					var q_ = (ClaimResponse.AdjudicationComponent @this) => @this?.Amount;
					var r_ = context?.Operators.SelectOrNull<ClaimResponse.AdjudicationComponent, Money>(p_, q_);
					var s_ = (Money DollarAmount) =>
					{
						var a_ = DollarAmount?.ValueElement;
						var b_ = FHIRHelpers_4_0_001.ToDecimal(a_);
						var c_ = (b_ as object);
						var d_ = (context?.Operators.ConvertIntegerToDecimal((int?)0) as object);

						return context?.Operators.Greater(c_, d_);
					};
					var t_ = context?.Operators.WhereOrNull<Money>(r_, s_);
					var u_ = context?.Operators.ExistsInList<Money>(t_);

					return context?.Operators.And(m_, u_);
				};
				var g_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(e_, f_);

				return new Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL
				{
					Response = a_,
					ResponseID = d_,
					LineItems = g_,
				};
			};

			return context?.Operators.SelectOrNull<ClaimResponse, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(a_, b_);
		};
		var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD, IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(d_, e_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(f_);
	}


    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_and_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = (Claim AllClaims) =>
		{
			var a_ = AllClaims?.Item;
			var b_ = (Claim.ItemComponent @this) =>
			{
				var a_ = (bool?)(@this?.ProductOrService == null);

				return context?.Operators.Not(a_);
			};
			var c_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(a_, b_);
			var d_ = (Claim.ItemComponent @this) => @this?.ProductOrService;
			var e_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(c_, d_);
			var f_ = (CodeableConcept @this) =>
			{
				var a_ = (bool?)(@this?.Coding == null);

				return context?.Operators.Not(a_);
			};
			var g_ = context?.Operators.WhereOrNull<CodeableConcept>(e_, f_);
			var h_ = (CodeableConcept @this) => @this?.Coding;
			var i_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(g_, h_);
			var j_ = context?.Operators.FlattenList<Coding>(i_);
			var k_ = (Coding ProductOrServiceCode) =>
			{
				var a_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

				return context?.Operators.CodeInList(a_, ProductOrServiceValueSet);
			};
			var l_ = context?.Operators.WhereOrNull<Coding>(j_, k_);
			var m_ = context?.Operators.ExistsInList<Coding>(l_);
			var n_ = (AllClaims?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>);
			var o_ = (Claim.DiagnosisComponent @this) =>
			{
				var a_ = (bool?)(@this?.Diagnosis == null);

				return context?.Operators.Not(a_);
			};
			var p_ = context?.Operators.WhereOrNull<Claim.DiagnosisComponent>(n_, o_);
			var q_ = (Claim.DiagnosisComponent @this) => @this?.Diagnosis;
			var r_ = context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(p_, q_);
			var s_ = (DataType @this) =>
			{
				var a_ = (bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null);

				return context?.Operators.Not(a_);
			};
			var t_ = context?.Operators.WhereOrNull<DataType>(r_, s_);
			var u_ = (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding");
			var v_ = context?.Operators.SelectOrNull<DataType, object>(t_, u_);
			var w_ = context?.Operators.FlattenLateBoundList(v_);
			var x_ = (object @object) => (@object as Coding);
			var y_ = context?.Operators.SelectOrNull<object, Coding>(w_, x_);
			var z_ = (Coding DiagnosisCode) =>
			{
				var a_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);

				return context?.Operators.CodeInList(a_, DiagnosisValueSet);
			};
			var aa_ = context?.Operators.WhereOrNull<Coding>(y_, z_);
			var ab_ = context?.Operators.ExistsInList<Coding>(aa_);

			return context?.Operators.And(m_, ab_);
		};
		var b_ = context?.Operators.WhereOrNull<Claim>(claim, a_);
		var c_ = (Claim ProcedureClaims) =>
		{
			var a_ = ProcedureClaims;
			var b_ = ProcedureClaims?.IdElement;
			var c_ = (ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>);
			var d_ = (Claim.ItemComponent ResponseItem) =>
			{
				var a_ = (ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>);
				var b_ = (Coding ProductOrServiceCode) =>
				{
					var a_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

					return context?.Operators.CodeInList(a_, ProductOrServiceValueSet);
				};
				var c_ = context?.Operators.WhereOrNull<Coding>(a_, b_);

				return context?.Operators.ExistsInList<Coding>(c_);
			};
			var e_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(c_, d_);

			return new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = a_,
				ClaimID = b_,
				LineItems = e_,
			};
		};

		return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);
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
			var a_ = ClaimAndResponse?.MedicalClaim;
			var b_ = (Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim) =>
			{
				var a_ = medClaim;
				var b_ = medClaim?.LineItems;
				var c_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var a_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					var b_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var a_ = pClaim?.LineItems;
						var b_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
						{
							var a_ = (((medClaim?.ClaimofInterest is Resource)
								? ((medClaim?.ClaimofInterest as Resource)?.IdElement)
								: (null))
 as object);
							var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
							var c_ = (b_ as object);
							var d_ = (pClaim?.Response?.Request?.ReferenceElement as object);
							var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
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
						var c_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(a_, b_);
						var d_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;

						return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(c_, d_);
					};
					var c_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(a_, b_);

					return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(c_);
				};
				var d_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(b_, c_);

				return new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = a_,
					ClaimItem = d_,
				};
			};
			var c_ = context?.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(a_, b_);
			var d_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = c_,
			};
			var e_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				d_,
			};
			var f_ = (Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse) =>
			{
				var a_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem))) ?? false))
					? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.PaidClaim == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.PaidClaim),
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval((PaidItem?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
;
				var b_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					a_,
				};
				var c_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
				{
					var a_ = (bool?)(FinalList == null);

					return context?.Operators.Not(a_);
				};
				var d_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);
			};
			var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(e_, f_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(g_);
		};
		var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);
	}


    [CqlDeclaration("Get Paid Claims for Provided Service and Condition")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Service_and_Condition(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var b_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			a_,
		};
		var c_ = (Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse) => (((context?.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse == null), (bool?)(MedicalClaimAndResponse?.MedicalClaim == null)) ?? false))
			? ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))
			: (this.Get_Corresponding_Claim_for_Services_and_Conditions(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet)))
;
		var d_ = context?.Operators.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		var e_ = context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);
		var f_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
		{
			e_,
		};
		var g_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
		{
			var a_ = (bool?)(FinalList == null);

			return context?.Operators.Not(a_);
		};
		var h_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_, g_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(h_);
	}


    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_or_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var a_ = (Claim AllClaims) =>
		{
			var a_ = AllClaims?.Item;
			var b_ = (Claim.ItemComponent @this) =>
			{
				var a_ = (bool?)(@this?.ProductOrService == null);

				return context?.Operators.Not(a_);
			};
			var c_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(a_, b_);
			var d_ = (Claim.ItemComponent @this) => @this?.ProductOrService;
			var e_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(c_, d_);
			var f_ = (CodeableConcept @this) =>
			{
				var a_ = (bool?)(@this?.Coding == null);

				return context?.Operators.Not(a_);
			};
			var g_ = context?.Operators.WhereOrNull<CodeableConcept>(e_, f_);
			var h_ = (CodeableConcept @this) => @this?.Coding;
			var i_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(g_, h_);
			var j_ = context?.Operators.FlattenList<Coding>(i_);
			var k_ = (Coding ProductOrServiceCode) =>
			{
				var a_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

				return context?.Operators.CodeInList(a_, ProductOrServiceValueSet);
			};
			var l_ = context?.Operators.WhereOrNull<Coding>(j_, k_);
			var m_ = context?.Operators.ExistsInList<Coding>(l_);
			var n_ = (AllClaims?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>);
			var o_ = (Claim.DiagnosisComponent @this) =>
			{
				var a_ = (bool?)(@this?.Diagnosis == null);

				return context?.Operators.Not(a_);
			};
			var p_ = context?.Operators.WhereOrNull<Claim.DiagnosisComponent>(n_, o_);
			var q_ = (Claim.DiagnosisComponent @this) => @this?.Diagnosis;
			var r_ = context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(p_, q_);
			var s_ = (DataType @this) =>
			{
				var a_ = (bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null);

				return context?.Operators.Not(a_);
			};
			var t_ = context?.Operators.WhereOrNull<DataType>(r_, s_);
			var u_ = (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding");
			var v_ = context?.Operators.SelectOrNull<DataType, object>(t_, u_);
			var w_ = context?.Operators.FlattenLateBoundList(v_);
			var x_ = (object @object) => (@object as Coding);
			var y_ = context?.Operators.SelectOrNull<object, Coding>(w_, x_);
			var z_ = (Coding DiagnosisCode) =>
			{
				var a_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);

				return context?.Operators.CodeInList(a_, DiagnosisValueSet);
			};
			var aa_ = context?.Operators.WhereOrNull<Coding>(y_, z_);
			var ab_ = context?.Operators.ExistsInList<Coding>(aa_);

			return context?.Operators.Or(m_, ab_);
		};
		var b_ = context?.Operators.WhereOrNull<Claim>(claim, a_);
		var c_ = (Claim ProcedureClaims) => (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), (Coding ProductOrServiceCode) => context?.Operators.CodeInList(FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode), ProductOrServiceValueSet))))) ?? false))
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

		return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);
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
			var a_ = ClaimAndResponse?.MedicalClaim;
			var b_ = (Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim) =>
			{
				var a_ = medClaim;
				var b_ = medClaim?.LineItems;
				var c_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var a_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					var b_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var a_ = pClaim?.LineItems;
						var b_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
						{
							var a_ = (((medClaim?.ClaimofInterest is Resource)
								? ((medClaim?.ClaimofInterest as Resource)?.IdElement)
								: (null))
 as object);
							var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
							var c_ = (b_ as object);
							var d_ = (pClaim?.Response?.Request?.ReferenceElement as object);
							var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
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
						var c_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(a_, b_);
						var d_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;

						return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(c_, d_);
					};
					var c_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(a_, b_);

					return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(c_);
				};
				var d_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(b_, c_);

				return new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = a_,
					ClaimItem = d_,
				};
			};
			var c_ = context?.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(a_, b_);
			var d_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = c_,
			};
			var e_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				d_,
			};
			var f_ = (Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse) =>
			{
				var a_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem))) ?? false))
					? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.PaidClaim == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.PaidClaim),
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval((PaidItem?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
;
				var b_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					a_,
				};
				var c_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
				{
					var a_ = (bool?)(FinalList == null);

					return context?.Operators.Not(a_);
				};
				var d_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);
			};
			var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(e_, f_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(g_);
		};
		var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);
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
		var a_ = (Claim AllClaims) =>
		{
			var a_ = AllClaims?.Item;
			var b_ = (Claim.ItemComponent @this) =>
			{
				var a_ = (bool?)(@this?.ProductOrService == null);

				return context?.Operators.Not(a_);
			};
			var c_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(a_, b_);
			var d_ = (Claim.ItemComponent @this) => @this?.ProductOrService;
			var e_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(c_, d_);
			var f_ = (CodeableConcept @this) =>
			{
				var a_ = (bool?)(@this?.Coding == null);

				return context?.Operators.Not(a_);
			};
			var g_ = context?.Operators.WhereOrNull<CodeableConcept>(e_, f_);
			var h_ = (CodeableConcept @this) => @this?.Coding;
			var i_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(g_, h_);
			var j_ = context?.Operators.FlattenList<Coding>(i_);
			var k_ = (Coding ProductOrServiceCode) =>
			{
				var a_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

				return context?.Operators.CodeInList(a_, ProductOrServiceValueSet);
			};
			var l_ = context?.Operators.WhereOrNull<Coding>(j_, k_);

			return context?.Operators.ExistsInList<Coding>(l_);
		};
		var b_ = context?.Operators.WhereOrNull<Claim>(claim, a_);
		var c_ = (Claim AllClaims) =>
		{
			var a_ = AllClaims;
			var b_ = AllClaims?.IdElement;
			var c_ = (AllClaims?.Item as IEnumerable<Claim.ItemComponent>);
			var d_ = (Claim.ItemComponent ResponseItem) =>
			{
				var a_ = (ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>);
				var b_ = (Coding ProductOrServiceCode) =>
				{
					var a_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

					return context?.Operators.CodeInList(a_, ProductOrServiceValueSet);
				};
				var c_ = context?.Operators.WhereOrNull<Coding>(a_, b_);

				return context?.Operators.ExistsInList<Coding>(c_);
			};
			var e_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(c_, d_);

			return new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = a_,
				ClaimID = b_,
				LineItems = e_,
			};
		};

		return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(b_, c_);
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
			var a_ = ClaimAndResponse?.MedicalClaim;
			var b_ = (Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim) =>
			{
				var a_ = medClaim;
				var b_ = medClaim?.LineItems;
				var c_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var a_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					var b_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var a_ = pClaim?.LineItems;
						var b_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
						{
							var a_ = (((medClaim?.ClaimofInterest is Resource)
								? ((medClaim?.ClaimofInterest as Resource)?.IdElement)
								: (null))
 as object);
							var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
							var c_ = (b_ as object);
							var d_ = (pClaim?.Response?.Request?.ReferenceElement as object);
							var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
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
						var c_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(a_, b_);
						var d_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;

						return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(c_, d_);
					};
					var c_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(a_, b_);

					return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(c_);
				};
				var d_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(b_, c_);

				return new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = a_,
					ClaimItem = d_,
				};
			};
			var c_ = context?.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(a_, b_);
			var d_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = c_,
			};
			var e_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				d_,
			};
			var f_ = (Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse) =>
			{
				var a_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem))) ?? false))
					? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.PaidClaim == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.PaidClaim),
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval((PaidItem?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
;
				var b_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					a_,
				};
				var c_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
				{
					var a_ = (bool?)(FinalList == null);

					return context?.Operators.Not(a_);
				};
				var d_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);
			};
			var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(e_, f_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(g_);
		};
		var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);
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
			var a_ = ClaimAndResponse?.MedicalClaim;
			var b_ = (Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC medClaim) =>
			{
				var a_ = medClaim;
				var b_ = medClaim?.LineItem;
				var c_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var a_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
					var b_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var a_ = pClaim?.LineItems;
						var b_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
						{
							var a_ = (((medClaim?.Claim is Resource)
								? ((medClaim?.Claim as Resource)?.IdElement)
								: (null))
 as object);
							var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
							var c_ = (b_ as object);
							var d_ = (pClaim?.Response?.Request?.ReferenceElement as object);
							var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
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
						var c_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(a_, b_);
						var d_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;

						return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(c_, d_);
					};
					var c_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(a_, b_);

					return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(c_);
				};
				var d_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(b_, c_);

				return new Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT
				{
					PaidClaim = a_,
					ClaimItem = d_,
				};
			};
			var c_ = context?.Operators.SelectOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC, Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(a_, b_);
			var d_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB
			{
				AggregateClaim = c_,
			};
			var e_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB[]
			{
				d_,
			};
			var f_ = (Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB ClaimWithPaidResponse) =>
			{
				var a_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => @this?.ClaimItem))) ?? false))
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
				var b_ = new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO[]
				{
					a_,
				};
				var c_ = (Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO FinalList) =>
				{
					var a_ = (bool?)(FinalList == null);

					return context?.Operators.Not(a_);
				};
				var d_ = context?.Operators.WhereOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(b_, c_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(d_);
			};
			var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(e_, f_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(g_);
		};
		var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(d_, e_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(f_);
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
		var a_ = (Claim Claim) =>
		{
			var a_ = (ClaimResponse CR) =>
			{
				var a_ = (Claim?.IdElement as object);
				var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
				var c_ = (b_ as object);
				var d_ = (CR?.Request?.ReferenceElement as object);
				var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
				var f_ = NCQAFHIRBase_1_0_0.GetId(e_);
				var g_ = (f_ as object);

				return context?.Operators.Equal(c_, g_);
			};
			var b_ = context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, a_);
			var c_ = (Claim C) =>
			{
				var a_ = (Claim?.IdElement as object);
				var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
				var c_ = (b_ as object);
				var d_ = (ClaimResponse CR) =>
				{
					var a_ = (Claim?.IdElement as object);
					var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
					var c_ = (b_ as object);
					var d_ = (CR?.Request?.ReferenceElement as object);
					var e_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(d_);
					var f_ = NCQAFHIRBase_1_0_0.GetId(e_);
					var g_ = (f_ as object);

					return context?.Operators.Equal(c_, g_);
				};
				var e_ = context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, d_);
				var f_ = (ClaimResponse @this) =>
				{
					var a_ = (bool?)(@this?.Request == null);

					return context?.Operators.Not(a_);
				};
				var g_ = context?.Operators.WhereOrNull<ClaimResponse>(e_, f_);
				var h_ = (ClaimResponse @this) => @this?.Request;
				var i_ = context?.Operators.SelectOrNull<ClaimResponse, ResourceReference>(g_, h_);
				var j_ = (ResourceReference @this) =>
				{
					var a_ = (bool?)(@this?.ReferenceElement == null);

					return context?.Operators.Not(a_);
				};
				var k_ = context?.Operators.WhereOrNull<ResourceReference>(i_, j_);
				var l_ = (ResourceReference @this) => @this?.ReferenceElement;
				var m_ = context?.Operators.SelectOrNull<ResourceReference, FhirString>(k_, l_);
				var n_ = context?.Operators.SingleOrNull<FhirString>(m_);
				var o_ = (n_ as object);
				var p_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(o_);
				var q_ = NCQAFHIRBase_1_0_0.GetId(p_);
				var r_ = (q_ as object);

				return context?.Operators.Equal(c_, r_);
			};
			var d_ = context?.Operators.WhereOrNull<Claim>(claim, c_);

			return new Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI
			{
				ClaimResponse = b_,
				OriginalClaim = d_,
			};
		};

		return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI>(claim, a_);
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
			var a_ = (((ClaimWithInpatientStay?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithInpatientStay?.MedicalClaim, (Claim c) => context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.WhereOrNull<Claim.ItemComponent>((c?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent i) => context?.Operators.ExistsInList<CqlCode>(context?.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(i?.Revenue)?.codes as IEnumerable<CqlCode>), (CqlCode rev) => context?.Operators.StringInValueSet(rev?.code, this.Inpatient_Stay()))))))))
;
			var b_ = (((ClaimWithInpatientStay?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithInpatientStay?.MedicalClaim, (Claim c) => context?.Operators.Or(context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.WhereOrNull<Claim.ItemComponent>((c?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent i) => context?.Operators.ExistsInList<CqlCode>(context?.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(i?.Revenue)?.codes as IEnumerable<CqlCode>), (CqlCode rev) => context?.Operators.StringInValueSet(rev?.code, this.Nonacute_Inpatient_Stay()))))), context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>((c?.SubType?.Coding as IEnumerable<Coding>), (Coding tob) => context?.Operators.StringInValueSet(tob?.CodeElement?.Value, this.Nonacute_Inpatient_Stay())))))))
;
			var c_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb
			{
				InpatientStayLineItems = a_,
				NonacuteInpatientLineItems = b_,
			};
			var d_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb[]
			{
				c_,
			};
			var e_ = (Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb LineItemDefinition) =>
			{
				var a_ = LineItemDefinition?.InpatientStayLineItems;
				var b_ = LineItemDefinition?.NonacuteInpatientLineItems;
				var c_ = (Claim nonAcuteInpatientStay) =>
				{
					var a_ = LineItemDefinition?.InpatientStayLineItems;
					var b_ = (Claim inpatientStay) =>
					{
						var a_ = (nonAcuteInpatientStay?.IdElement as object);
						var b_ = (inpatientStay?.IdElement as object);

						return context?.Operators.Equal(a_, b_);
					};
					var c_ = context?.Operators.WhereOrNull<Claim>(a_, b_);
					var d_ = (Claim inpatientStay) => nonAcuteInpatientStay;

					return context?.Operators.SelectOrNull<Claim, Claim>(c_, d_);
				};
				var d_ = context?.Operators.SelectManyOrNull<Claim, Claim>(b_, c_);
				var e_ = LineItemDefinition?.InpatientStayLineItems;
				var f_ = LineItemDefinition?.InpatientStayLineItems;
				var g_ = (Claim inpatientStay) =>
				{
					var a_ = LineItemDefinition?.NonacuteInpatientLineItems;
					var b_ = (Claim nonAcuteInpatientStay) =>
					{
						var a_ = (inpatientStay?.IdElement as object);
						var b_ = (nonAcuteInpatientStay?.IdElement as object);

						return context?.Operators.Equal(a_, b_);
					};
					var c_ = context?.Operators.WhereOrNull<Claim>(a_, b_);
					var d_ = (Claim nonAcuteInpatientStay) => inpatientStay;

					return context?.Operators.SelectOrNull<Claim, Claim>(c_, d_);
				};
				var h_ = context?.Operators.SelectManyOrNull<Claim, Claim>(f_, g_);
				var i_ = context?.Operators.ListExcept<Claim>(e_, h_);

				return new Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE
				{
					InpatientDischarge = a_,
					NonacuteInpatientDischarge = d_,
					AcuteInpatientDischarge = i_,
				};
			};
			var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb, Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(d_, e_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(f_);
		};
		var e_ = context?.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(c_, d_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(e_);
	}


    [CqlDeclaration("Get Prescriber NPI from Claims")]
    public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Prescriber_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		var a_ = (Claim C) =>
		{
			var a_ = C;
			var b_ = (C?.CareTeam as IEnumerable<Claim.CareTeamComponent>);
			var c_ = (Claim.CareTeamComponent ct) =>
			{
				var a_ = (ct?.SequenceElement as object);
				var b_ = context?.Operators?.TypeConverter.Convert<Integer>(a_);
				var c_ = FHIRHelpers_4_0_001.ToInteger(b_);
				var d_ = (c_ as object);
				var e_ = ((int?)1 as object);

				return context?.Operators.Equal(d_, e_);
			};
			var d_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(b_, c_);
			var e_ = (Claim.CareTeamComponent @this) =>
			{
				var a_ = (bool?)(@this?.Provider == null);

				return context?.Operators.Not(a_);
			};
			var f_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(d_, e_);
			var g_ = (Claim.CareTeamComponent @this) => @this?.Provider;
			var h_ = context?.Operators.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(f_, g_);
			var i_ = (C?.CareTeam as IEnumerable<Claim.CareTeamComponent>);
			var j_ = (Claim.CareTeamComponent ct) =>
			{
				var a_ = (ct?.SequenceElement as object);
				var b_ = context?.Operators?.TypeConverter.Convert<Integer>(a_);
				var c_ = FHIRHelpers_4_0_001.ToInteger(b_);
				var d_ = (c_ as object);
				var e_ = ((int?)1 as object);

				return context?.Operators.Equal(d_, e_);
			};
			var k_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(i_, j_);
			var l_ = (Claim.CareTeamComponent @this) =>
			{
				var a_ = (bool?)(@this?.Provider == null);

				return context?.Operators.Not(a_);
			};
			var m_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(k_, l_);
			var n_ = (Claim.CareTeamComponent @this) => @this?.Provider;
			var o_ = context?.Operators.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(m_, n_);
			var p_ = (ResourceReference p) =>
			{
				var a_ = p?.ReferenceElement;
				var b_ = new FhirString[]
				{
					a_,
				};
				var c_ = (FhirString r) =>
				{
					var a_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>((r as object));

					return NCQAFHIRBase_1_0_0.GetId(a_);
				};
				var d_ = context?.Operators.SelectOrNull<FhirString, string>(b_, c_);

				return context?.Operators.SingleOrNull<string>(d_);
			};
			var q_ = context?.Operators.SelectOrNull<ResourceReference, string>(o_, p_);

			return new Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS
			{
				SingleCareTeam = a_,
				CareTeamsProvider = h_,
				CareTeamsProviderID = q_,
			};
		};
		var b_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(claim, a_);
		var c_ = new Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR
		{
			CareTeams = b_,
		};
		var d_ = new Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR[]
		{
			c_,
		};
		var e_ = (Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR ClaimProperties) =>
		{
			var a_ = context?.DataRetriever.RetrieveByValueSet<Practitioner>(null, null);
			var b_ = (Practitioner p) =>
			{
				var a_ = (p?.IdElement as object);
				var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
				var c_ = ClaimProperties?.CareTeams;
				var d_ = (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) =>
				{
					var a_ = (bool?)(@this?.CareTeamsProviderID == null);

					return context?.Operators.Not(a_);
				};
				var e_ = context?.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(c_, d_);
				var f_ = (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this?.CareTeamsProviderID;
				var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, IEnumerable<string>>(e_, f_);
				var h_ = context?.Operators.FlattenList<string>(g_);

				return context?.Operators.InList<string>(b_, h_);
			};
			var c_ = context?.Operators.WhereOrNull<Practitioner>(a_, b_);
			var d_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe
			{
				Practitioners = c_,
			};
			var e_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe[]
			{
				d_,
			};
			var f_ = (Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe PractitionerMatch) =>
			{
				var a_ = PractitionerMatch?.Practitioners;
				var b_ = (Practitioner P) =>
				{
					var a_ = (bool?)(P == null);

					return context?.Operators.Not(a_);
				};
				var c_ = context?.Operators.WhereOrNull<Practitioner>(a_, b_);
				var d_ = (Practitioner P) =>
				{
					var a_ = (P?.Identifier as IEnumerable<Identifier>);
					var b_ = (Identifier l) =>
					{
						var a_ = (l?.SystemElement?.Value as object);
						var b_ = context?.Operators.Equal(a_, ("http://hl7.org/fhir/sid/us-npi" as object));
						var c_ = l?.Type;
						var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
						var e_ = (d_ as object);
						var f_ = NCQATerminology_1_0_0.Provider_number();
						var g_ = context?.Operators.ConvertCodeToConcept(f_);
						var h_ = (g_ as object);
						var i_ = context?.Operators.Equivalent(e_, h_);
						var j_ = context?.Operators.And(b_, i_);
						var k_ = (bool?)(l?.ValueElement?.Value == null);
						var l_ = context?.Operators.Not(k_);

						return context?.Operators.And(j_, l_);
					};
					var c_ = context?.Operators.WhereOrNull<Identifier>(a_, b_);
					var d_ = (Identifier l) => l?.ValueElement;
					var e_ = context?.Operators.SelectOrNull<Identifier, FhirString>(c_, d_);
					var f_ = (P?.Identifier as IEnumerable<Identifier>);
					var g_ = (Identifier l) =>
					{
						var a_ = (l?.SystemElement?.Value as object);
						var b_ = context?.Operators.Equal(a_, ("http://hl7.org/fhir/sid/us-npi" as object));
						var c_ = l?.Type;
						var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
						var e_ = (d_ as object);
						var f_ = NCQATerminology_1_0_0.Provider_number();
						var g_ = context?.Operators.ConvertCodeToConcept(f_);
						var h_ = (g_ as object);
						var i_ = context?.Operators.Equivalent(e_, h_);
						var j_ = context?.Operators.And(b_, i_);
						var k_ = (bool?)(l?.ValueElement?.Value == null);

						return context?.Operators.And(j_, k_);
					};
					var h_ = context?.Operators.WhereOrNull<Identifier>(f_, g_);
					var i_ = (Identifier l) => l;
					var j_ = context?.Operators.SelectOrNull<Identifier, Identifier>(h_, i_);

					return new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = e_,
						NullIdentifiers = j_,
					};
				};
				var e_ = context?.Operators.SelectOrNull<Practitioner, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(c_, d_);
				var f_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = e_,
				};
				var g_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					f_,
				};
				var h_ = (Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers) =>
				{
					var a_ = (((context?.Operators.ExistsInList<Claim>(context?.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context?.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => context?.Operators.Not((bool?)(@this?.SingleCareTeam == null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this?.SingleCareTeam)) ?? false))
						? (context?.Operators.Add(context?.Operators.Add(context?.Operators.CountOrNull<Claim>(context?.Operators.WhereOrNull<Claim>(context?.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context?.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => context?.Operators.Not((bool?)(@this?.SingleCareTeam == null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this?.SingleCareTeam), (Claim X) => (bool?)((X?.CareTeam as IEnumerable<Claim.CareTeamComponent>) == null))), context?.Operators.CountOrNull<FhirString>(context?.Operators.SelectOrNull<FhirString, FhirString>(context?.Operators.FlattenList<FhirString>(context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.AllIdentifiers)), (FhirString X) => X))), context?.Operators.CountOrNull<Identifier>(context?.Operators.FlattenList<Identifier>(context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.NullIdentifiers)))))
						: ((int?)0))
;

					return new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = a_,
					};
				};
				var i_ = context?.Operators.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(g_, h_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(i_);
			};
			var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(e_, f_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(g_);
		};
		var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(d_, e_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(f_);
	}


    [CqlDeclaration("Get Pharmacy NPI from Claims")]
    public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Pharmacy_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		var a_ = (Claim C) =>
		{
			var a_ = (C?.Item as IEnumerable<Claim.ItemComponent>);
			var b_ = (C?.Item as IEnumerable<Claim.ItemComponent>);
			var c_ = (Claim.ItemComponent i) =>
			{
				var a_ = (i?.SequenceElement as object);
				var b_ = context?.Operators?.TypeConverter.Convert<Integer>(a_);
				var c_ = FHIRHelpers_4_0_001.ToInteger(b_);
				var d_ = (c_ as object);
				var e_ = ((int?)1 as object);

				return context?.Operators.Equal(d_, e_);
			};
			var d_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(b_, c_);
			var e_ = (Claim.ItemComponent @this) =>
			{
				var a_ = (bool?)(@this?.Location == null);

				return context?.Operators.Not(a_);
			};
			var f_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(d_, e_);
			var g_ = (Claim.ItemComponent @this) => @this?.Location;
			var h_ = context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(f_, g_);
			var i_ = (DataType l) => (l as ResourceReference);
			var j_ = context?.Operators.SelectOrNull<DataType, ResourceReference>(h_, i_);
			var k_ = (C?.Item as IEnumerable<Claim.ItemComponent>);
			var l_ = (Claim.ItemComponent i) =>
			{
				var a_ = (i?.SequenceElement as object);
				var b_ = context?.Operators?.TypeConverter.Convert<Integer>(a_);
				var c_ = FHIRHelpers_4_0_001.ToInteger(b_);
				var d_ = (c_ as object);
				var e_ = ((int?)1 as object);

				return context?.Operators.Equal(d_, e_);
			};
			var m_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(k_, l_);
			var n_ = (Claim.ItemComponent @this) =>
			{
				var a_ = (bool?)(@this?.Location == null);

				return context?.Operators.Not(a_);
			};
			var o_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(m_, n_);
			var p_ = (Claim.ItemComponent @this) => @this?.Location;
			var q_ = context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(o_, p_);
			var r_ = (DataType l) =>
			{
				var a_ = (l as ResourceReference)?.ReferenceElement;
				var b_ = new FhirString[]
				{
					a_,
				};
				var c_ = (FhirString r) =>
				{
					var a_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>((r as object));

					return NCQAFHIRBase_1_0_0.GetId(a_);
				};
				var d_ = context?.Operators.SelectOrNull<FhirString, string>(b_, c_);

				return context?.Operators.SingleOrNull<string>(d_);
			};
			var s_ = context?.Operators.SelectOrNull<DataType, string>(q_, r_);

			return new Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI
			{
				SingleItem = a_,
				ItemLocation = j_,
				ItemLocationID = s_,
			};
		};
		var b_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(claim, a_);
		var c_ = new Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa
		{
			ItemsLocationReferences = b_,
		};
		var d_ = new Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa[]
		{
			c_,
		};
		var e_ = (Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa ClaimProperties) =>
		{
			var a_ = context?.DataRetriever.RetrieveByValueSet<Location>(null, null);
			var b_ = (Location l) =>
			{
				var a_ = (l?.IdElement as object);
				var b_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(a_);
				var c_ = ClaimProperties?.ItemsLocationReferences;
				var d_ = (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) =>
				{
					var a_ = (bool?)(@this?.ItemLocationID == null);

					return context?.Operators.Not(a_);
				};
				var e_ = context?.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(c_, d_);
				var f_ = (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this?.ItemLocationID;
				var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<string>>(e_, f_);
				var h_ = context?.Operators.FlattenList<string>(g_);

				return context?.Operators.InList<string>(b_, h_);
			};
			var c_ = context?.Operators.WhereOrNull<Location>(a_, b_);
			var d_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP
			{
				CorrespondingLocations = c_,
			};
			var e_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP[]
			{
				d_,
			};
			var f_ = (Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP GetLocation) =>
			{
				var a_ = GetLocation?.CorrespondingLocations;
				var b_ = (Location C) =>
				{
					var a_ = (bool?)(C == null);

					return context?.Operators.Not(a_);
				};
				var c_ = context?.Operators.WhereOrNull<Location>(a_, b_);
				var d_ = (Location C) =>
				{
					var a_ = (C?.Identifier as IEnumerable<Identifier>);
					var b_ = (Identifier l) =>
					{
						var a_ = (l?.SystemElement?.Value as object);
						var b_ = context?.Operators.Equal(a_, ("http://hl7.org/fhir/sid/us-npi" as object));
						var c_ = l?.Type;
						var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
						var e_ = (d_ as object);
						var f_ = NCQATerminology_1_0_0.Provider_number();
						var g_ = context?.Operators.ConvertCodeToConcept(f_);
						var h_ = (g_ as object);
						var i_ = context?.Operators.Equivalent(e_, h_);
						var j_ = context?.Operators.And(b_, i_);
						var k_ = (bool?)(l?.ValueElement?.Value == null);
						var l_ = context?.Operators.Not(k_);

						return context?.Operators.And(j_, l_);
					};
					var c_ = context?.Operators.WhereOrNull<Identifier>(a_, b_);
					var d_ = (Identifier l) => l?.ValueElement;
					var e_ = context?.Operators.SelectOrNull<Identifier, FhirString>(c_, d_);
					var f_ = (C?.Identifier as IEnumerable<Identifier>);
					var g_ = (Identifier l) =>
					{
						var a_ = (l?.SystemElement?.Value as object);
						var b_ = context?.Operators.Equal(a_, ("http://hl7.org/fhir/sid/us-npi" as object));
						var c_ = l?.Type;
						var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
						var e_ = (d_ as object);
						var f_ = NCQATerminology_1_0_0.Provider_number();
						var g_ = context?.Operators.ConvertCodeToConcept(f_);
						var h_ = (g_ as object);
						var i_ = context?.Operators.Equivalent(e_, h_);
						var j_ = context?.Operators.And(b_, i_);
						var k_ = (bool?)(l?.ValueElement?.Value == null);

						return context?.Operators.And(j_, k_);
					};
					var h_ = context?.Operators.WhereOrNull<Identifier>(f_, g_);
					var i_ = (Identifier l) => l;
					var j_ = context?.Operators.SelectOrNull<Identifier, Identifier>(h_, i_);

					return new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = e_,
						NullIdentifiers = j_,
					};
				};
				var e_ = context?.Operators.SelectOrNull<Location, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(c_, d_);
				var f_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = e_,
				};
				var g_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					f_,
				};
				var h_ = (Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers) =>
				{
					var a_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => context?.Operators.Not((bool?)(@this?.SingleItem == null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this?.SingleItem))) ?? false))
						? (context?.Operators.Add(context?.Operators.Add(context?.Operators.CountOrNull<ResourceReference>(context?.Operators.WhereOrNull<ResourceReference>(context?.Operators.FlattenList<ResourceReference>(context?.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<ResourceReference>>(context?.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => context?.Operators.Not((bool?)(@this?.ItemLocation == null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this?.ItemLocation)), (ResourceReference X) => (bool?)(X?.ReferenceElement?.Value == null))), context?.Operators.CountOrNull<FhirString>(context?.Operators.SelectOrNull<FhirString, FhirString>(context?.Operators.FlattenList<FhirString>(context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.AllIdentifiers)), (FhirString X) => X))), context?.Operators.CountOrNull<Identifier>(context?.Operators.FlattenList<Identifier>(context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.NullIdentifiers)))))
						: ((int?)0))
;

					return new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = a_,
					};
				};
				var i_ = context?.Operators.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(g_, h_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(i_);
			};
			var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(e_, f_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(g_);
		};
		var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(d_, e_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(f_);
	}


}
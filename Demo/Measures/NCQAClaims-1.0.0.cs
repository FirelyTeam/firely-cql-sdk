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
		var m_ = (Claim MedicalClaim) =>
		{
			var a_ = MedicalClaim?.Type;
			var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
			var c_ = b_?.codes;
			var d_ = (c_ as IEnumerable<CqlCode>);
			var e_ = NCQATerminology_1_0_0.Professional();
			var f_ = context?.Operators.ListContains<CqlCode>(d_, e_);
			var g_ = MedicalClaim?.Type;
			var h_ = FHIRHelpers_4_0_001.ToConcept(g_);
			var i_ = h_?.codes;
			var j_ = (i_ as IEnumerable<CqlCode>);
			var k_ = NCQATerminology_1_0_0.Institutional();
			var l_ = context?.Operators.ListContains<CqlCode>(j_, k_);

			return context?.Operators.Or(f_, l_);
		};

		return context?.Operators.WhereOrNull<Claim>(claim, m_);
	}


    [CqlDeclaration("Pharmacy Claims")]
    public IEnumerable<Claim> Pharmacy_Claims(IEnumerable<Claim> claim)
	{
		var f_ = (Claim PharmacyClaim) =>
		{
			var a_ = PharmacyClaim?.Type;
			var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
			var c_ = b_?.codes;
			var d_ = (c_ as IEnumerable<CqlCode>);
			var e_ = NCQATerminology_1_0_0.Pharmacy();

			return context?.Operators.ListContains<CqlCode>(d_, e_);
		};

		return context?.Operators.WhereOrNull<Claim>(claim, f_);
	}


    [CqlDeclaration("Professional or Institutional Claims Response")]
    public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		var m_ = (ClaimResponse MedicalResponse) =>
		{
			var a_ = MedicalResponse?.Type;
			var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
			var c_ = b_?.codes;
			var d_ = (c_ as IEnumerable<CqlCode>);
			var e_ = NCQATerminology_1_0_0.Professional();
			var f_ = context?.Operators.ListContains<CqlCode>(d_, e_);
			var g_ = MedicalResponse?.Type;
			var h_ = FHIRHelpers_4_0_001.ToConcept(g_);
			var i_ = h_?.codes;
			var j_ = (i_ as IEnumerable<CqlCode>);
			var k_ = NCQATerminology_1_0_0.Institutional();
			var l_ = context?.Operators.ListContains<CqlCode>(j_, k_);

			return context?.Operators.Or(f_, l_);
		};

		return context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, m_);
	}


    [CqlDeclaration("Pharmacy Claims Response")]
    public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
	{
		var f_ = (ClaimResponse PharmacyResponse) =>
		{
			var a_ = PharmacyResponse?.Type;
			var b_ = FHIRHelpers_4_0_001.ToConcept(a_);
			var c_ = b_?.codes;
			var d_ = (c_ as IEnumerable<CqlCode>);
			var e_ = NCQATerminology_1_0_0.Pharmacy();

			return context?.Operators.ListContains<CqlCode>(d_, e_);
		};

		return context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, f_);
	}


    [CqlDeclaration("Medical Claims With Procedure and POS")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_and_POS(IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var m_ = this.Professional_or_Institutional_Claims(claim);
		var n_ = (CqlCode p) => p?.code;
		var o_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, n_);
		var p_ = (CqlCode pos) => pos?.code;
		var q_ = context?.Operators.SelectOrNull<CqlCode, string>(posCodes, p_);
		var r_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = m_,
			ProceduresAsStrings = o_,
			POSAsString = q_,
		};
		var s_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			r_,
		};
		var t_ = (Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithPosCode) =>
		{
			var i_ = ClaimWithPosCode?.MedicalClaim;
			var j_ = (Claim ClaimofInterest) =>
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
			var k_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(i_, j_);
			var l_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
			{
				var g_ = (FinalList == null);
				var h_ = (bool?)g_;

				return context?.Operators.Not(h_);
			};

			return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(k_, l_);
		};
		var u_ = context?.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(s_, t_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(u_);
	}


    [CqlDeclaration("Medical Claims With Procedure in Header or on Line Item")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var m_ = this.Professional_or_Institutional_Claims(claim);
		var n_ = (CqlCode p) => p?.code;
		var o_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, n_);
		var p_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = m_,
			ProceduresAsStrings = o_,
		};
		var q_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			p_,
		};
		var r_ = (Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithProcedure) =>
		{
			var i_ = ClaimWithProcedure?.MedicalClaim;
			var j_ = (Claim ClaimofInterest) =>
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
			var k_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(i_, j_);
			var l_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
			{
				var g_ = (FinalList == null);
				var h_ = (bool?)g_;

				return context?.Operators.Not(h_);
			};

			return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(k_, l_);
		};
		var s_ = context?.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(q_, r_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(s_);
	}


    [CqlDeclaration("Medical Claims With Diagnosis")]
    public Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI Medical_Claims_With_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var l_ = this.Professional_or_Institutional_Claims(claim);
		var m_ = (CqlCode d) => d?.code;
		var n_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, m_);
		var o_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = l_,
			DiagnosesAsStrings = n_,
		};
		var p_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			o_,
		};
		var q_ = (Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis) =>
		{
			var g_ = (((ClaimWithDiagnosis?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, (Claim DiagnosisLine) => context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.SelectOrNull<object, Coding>(context?.Operators.FlattenLateBoundList(context?.Operators.SelectOrNull<DataType, object>(context?.Operators.WhereOrNull<DataType>(context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(context?.Operators.WhereOrNull<Claim.DiagnosisComponent>((DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent @this) => context?.Operators.Not((bool?)(@this?.Diagnosis == null))), (Claim.DiagnosisComponent @this) => @this?.Diagnosis), (DataType @this) => context?.Operators.Not((bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null))), (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context?.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings))))))
;
			var h_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = g_,
			};
			var i_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				h_,
			};
			var j_ = (Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg HeaderDefinition) =>
			{
				var c_ = (((context?.Operators.ExistsInList<Claim>(HeaderDefinition?.DiagnosisItems) ?? false))
					? (new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = HeaderDefinition?.DiagnosisItems,
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Claim>(HeaderDefinition?.DiagnosisItems, (Claim @this) => context?.Operators.Not((bool?)(@this?.Item == null))), (Claim @this) => @this?.Item)), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval((NormalDate?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI)))
;
				var d_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI[]
				{
					c_,
				};
				var e_ = (Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList) =>
				{
					var a_ = (FinalList == null);
					var b_ = (bool?)a_;

					return context?.Operators.Not(b_);
				};
				var f_ = context?.Operators.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(d_, e_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(f_);
			};
			var k_ = context?.Operators.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(i_, j_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(k_);
		};
		var r_ = context?.Operators.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(p_, q_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(r_);
	}


    [CqlDeclaration("Pharmacy Claim With Medication")]
    public IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> Pharmacy_Claim_With_Medication(IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
	{
		var au_ = this.Pharmacy_Claims(claim);
		var av_ = (CqlCode p) => p?.code;
		var aw_ = context?.Operators.SelectOrNull<CqlCode, string>(MedicationCodes, av_);
		var ax_ = new Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY
		{
			PharmacyClaim = au_,
			MedicationsAsStrings = aw_,
		};
		var ay_ = new Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY[]
		{
			ax_,
		};
		var az_ = (Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY ClaimWithMedication) =>
		{
			var aq_ = ClaimWithMedication?.PharmacyClaim;
			var ar_ = (Claim Pharmacy) =>
			{
				var af_ = Pharmacy;
				var ag_ = Pharmacy?.Item;
				var ah_ = (ag_ as IEnumerable<Claim.ItemComponent>);
				var ai_ = (Claim.ItemComponent ItemOnLine) =>
				{
					var c_ = ItemOnLine?.ProductOrService;
					var d_ = FHIRHelpers_4_0_001.ToConcept(c_);
					var e_ = d_?.codes;
					var f_ = (e_ as IEnumerable<CqlCode>);
					var g_ = (CqlCode LineCode) =>
					{
						var a_ = LineCode?.code;
						var b_ = ClaimWithMedication?.MedicationsAsStrings;

						return context?.Operators.InList<string>(a_, b_);
					};
					var h_ = context?.Operators.WhereOrNull<CqlCode>(f_, g_);

					return context?.Operators.ExistsInList<CqlCode>(h_);
				};
				var aj_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ah_, ai_);
				var ak_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = af_,
					LineItems = aj_,
				};
				var al_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					ak_,
				};
				var am_ = (Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition) =>
				{
					var ab_ = LineItemDefinition?.Claim;
					var ac_ = new Claim[]
					{
						ab_,
					};
					var ad_ = (Claim ClaimLines) =>
					{
						var r_ = ClaimLines?.Item;
						var s_ = (r_ as IEnumerable<Claim.ItemComponent>);
						var t_ = (Claim.ItemComponent i) =>
						{
							var k_ = i?.ProductOrService;
							var l_ = FHIRHelpers_4_0_001.ToConcept(k_);
							var m_ = l_?.codes;
							var n_ = (m_ as IEnumerable<CqlCode>);
							var o_ = (CqlCode LineCode) =>
							{
								var i_ = LineCode?.code;
								var j_ = ClaimWithMedication?.MedicationsAsStrings;

								return context?.Operators.InList<string>(i_, j_);
							};
							var p_ = context?.Operators.WhereOrNull<CqlCode>(n_, o_);

							return context?.Operators.ExistsInList<CqlCode>(p_);
						};
						var u_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(s_, t_);
						var v_ = (Claim.ItemComponent i) =>
						{
							var q_ = (((context?.Operators.Not((bool?)(i?.Quantity == null)) ?? false))
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
								DaysSupplyInterval = q_,
							};
						};
						var w_ = context?.Operators.SelectOrNull<Claim.ItemComponent, Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP>(u_, v_);
						var x_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU
						{
							CoveredDays = w_,
						};
						var y_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU[]
						{
							x_,
						};
						var z_ = (Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU ItemCalculation) => (((context?.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
							? (new Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC
								{
									Claim = LineItemDefinition?.Claim,
									LineItem = LineItemDefinition?.LineItems,
									ServicePeriod = context?.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context?.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, (Claim.ItemComponent @this) => context?.Operators.Not((bool?)(@this?.Serviced == null))), (Claim.ItemComponent @this) => @this?.Serviced), (DataType NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
									CoveredDays = context?.Operators.SelectOrNull<Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP, CqlInterval<CqlDateTime>>(ItemCalculation?.CoveredDays, (Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP d) => d?.DaysSupplyInterval),
								})
							: ((null as Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC)))
;
						var aa_ = context?.Operators.SelectOrNull<Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(y_, z_);

						return context?.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(aa_);
					};
					var ae_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ac_, ad_);

					return context?.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(ae_);
				};
				var an_ = context?.Operators.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(al_, am_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(an_);
			};
			var as_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(aq_, ar_);
			var at_ = (Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC FinalList) =>
			{
				var ao_ = (FinalList == null);
				var ap_ = (bool?)ao_;

				return context?.Operators.Not(ap_);
			};

			return context?.Operators.WhereOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(as_, at_);
		};
		var ba_ = context?.Operators.SelectOrNull<Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY, IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(ay_, az_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(ba_);
	}


    [CqlDeclaration("Medical Claims With Diagnosis and Procedure")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var q_ = this.Professional_or_Institutional_Claims(claim);
		var r_ = (CqlCode d) => d?.code;
		var s_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, r_);
		var t_ = (CqlCode p) => p?.code;
		var u_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, t_);
		var v_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = q_,
			DiagnosesAsStrings = s_,
			ProceduresAsStrings = u_,
		};
		var w_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
		{
			v_,
		};
		var x_ = (Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithDiagnosis) =>
		{
			var l_ = (((ClaimWithDiagnosis?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, (Claim DiagnosisLine) => context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.SelectOrNull<object, Coding>(context?.Operators.FlattenLateBoundList(context?.Operators.SelectOrNull<DataType, object>(context?.Operators.WhereOrNull<DataType>(context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(context?.Operators.WhereOrNull<Claim.DiagnosisComponent>((DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent @this) => context?.Operators.Not((bool?)(@this?.Diagnosis == null))), (Claim.DiagnosisComponent @this) => @this?.Diagnosis), (DataType @this) => context?.Operators.Not((bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null))), (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context?.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings))))))
;
			var m_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = l_,
			};
			var n_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				m_,
			};
			var o_ = (Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg ClaimWithProcedure) =>
			{
				var h_ = ClaimWithProcedure?.DiagnosisItems;
				var i_ = (Claim ClaimofInterest) =>
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
				var j_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(h_, i_);
				var k_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
				{
					var f_ = (FinalList == null);
					var g_ = (bool?)f_;

					return context?.Operators.Not(g_);
				};

				return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(j_, k_);
			};
			var p_ = context?.Operators.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(n_, o_);

			return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(p_);
		};
		var y_ = context?.Operators.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(w_, x_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(y_);
	}


    [CqlDeclaration("Medical Claims With Principal Diagnosis and Procedure")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Principal_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var x_ = this.Professional_or_Institutional_Claims(claim);
		var y_ = (CqlCode d) => d?.code;
		var z_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, y_);
		var aa_ = (CqlCode p) => p?.code;
		var ab_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, aa_);
		var ac_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = x_,
			DiagnosesAsStrings = z_,
			ProceduresAsStrings = ab_,
		};
		var ad_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
		{
			ac_,
		};
		var ae_ = (Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb ClaimWithProcedure) =>
		{
			var t_ = ClaimWithProcedure?.MedicalClaim;
			var u_ = (Claim ClaimofInterest) =>
			{
				var l_ = ClaimofInterest;
				var m_ = (((ClaimofInterest == null))
					? (null)
					: (context?.Operators.SingleOrNull<Claim>(context?.Operators.WhereOrNull<Claim>(new Claim[]
								{
									ClaimofInterest,
								}, (Claim ItemOnLine) => context?.Operators.Or(context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.FlattenList<Coding>(context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(context?.Operators.WhereOrNull<CodeableConcept>(context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(context?.Operators.WhereOrNull<Claim.ItemComponent>((ItemOnLine?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent @this) => context?.Operators.Not((bool?)(@this?.ProductOrService == null))), (Claim.ItemComponent @this) => @this?.ProductOrService), (CodeableConcept @this) => context?.Operators.Not((bool?)(@this?.Coding == null))), (CodeableConcept @this) => @this?.Coding)), (Coding LineCode) => context?.Operators.InList<string>(LineCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings))), context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.SelectOrNull<object, Coding>(context?.Operators.FlattenLateBoundList(context?.Operators.SelectOrNull<DataType, object>(context?.Operators.WhereOrNull<DataType>(context?.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(context?.Operators.WhereOrNull<Claim.ProcedureComponent>((ItemOnLine?.Procedure as IEnumerable<Claim.ProcedureComponent>), (Claim.ProcedureComponent @this) => context?.Operators.Not((bool?)(@this?.Procedure == null))), (Claim.ProcedureComponent @this) => @this?.Procedure), (DataType @this) => context?.Operators.Not((bool?)(context?.Operators.LateBoundProperty<object>((@this as object), "coding") == null))), (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context?.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings))))))))
;
				var n_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB
				{
					Claim = l_,
					ProcedureItems = m_,
				};
				var o_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB[]
				{
					n_,
				};
				var p_ = (Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB DiagnosisCheck) =>
				{
					var h_ = DiagnosisCheck?.ProcedureItems;
					var i_ = new Claim[]
					{
						h_,
					};
					var j_ = (Claim ClaimforDiagnosis) =>
					{
						var a_ = ClaimforDiagnosis?.Item;
						var b_ = (a_ as IEnumerable<Claim.ItemComponent>);
						var c_ = (((ClaimforDiagnosis == null))
							? (null)
							: (context?.Operators.SingleOrNull<Claim>(context?.Operators.WhereOrNull<Claim>(new Claim[]
										{
											ClaimforDiagnosis,
										}, (Claim RightClaim) => context?.Operators.ExistsInList<Claim.DiagnosisComponent>(context?.Operators.WhereOrNull<Claim.DiagnosisComponent>((RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent RightDiagnosis) => context?.Operators.And(context?.Operators.Equal(FHIRHelpers_4_0_001.ToInteger(context?.Operators?.TypeConverter.Convert<Integer>((RightDiagnosis?.SequenceElement as object))), (int?)1), context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.LateBoundProperty<IEnumerable<Coding>>((RightDiagnosis?.Diagnosis as object), "coding"), (Coding DiagnosisCode) => context?.Operators.InList<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithProcedure?.DiagnosesAsStrings))))))))))
;
						var d_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI
						{
							Procedure = b_,
							LineItems = c_,
						};
						var e_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI[]
						{
							d_,
						};
						var f_ = (Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI LineItemDefinition) => (((context?.Operators.And(context?.Operators.Not((bool?)(LineItemDefinition == null)), context?.Operators.Not((bool?)(LineItemDefinition?.LineItems == null))) ?? false))
							? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
								{
									Claim = LineItemDefinition?.LineItems,
									ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((LineItemDefinition?.LineItems?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval((NormalDate?.Serviced as object))),
								})
							: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)))
;
						var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(e_, f_);

						return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(g_);
					};
					var k_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(i_, j_);

					return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(k_);
				};
				var q_ = context?.Operators.SelectOrNull<Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(o_, p_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_);
			};
			var v_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(t_, u_);
			var w_ = (Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList) =>
			{
				var r_ = (FinalList == null);
				var s_ = (bool?)r_;

				return context?.Operators.Not(s_);
			};

			return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(v_, w_);
		};
		var af_ = context?.Operators.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(ad_, ae_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(af_);
	}


    [CqlDeclaration("Medical Claims With Principal Diagnosis")]
    public IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> Medical_Claims_With_Principal_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var l_ = this.Professional_or_Institutional_Claims(claim);
		var m_ = (CqlCode d) => d?.code;
		var n_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, m_);
		var o_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = l_,
			DiagnosesAsStrings = n_,
		};
		var p_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			o_,
		};
		var q_ = (Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX ClaimWithDiagnosis) =>
		{
			var g_ = (((ClaimWithDiagnosis?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, (Claim RightClaim) => context?.Operators.ExistsInList<Claim.DiagnosisComponent>(context?.Operators.WhereOrNull<Claim.DiagnosisComponent>((RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent RightDiagnosis) => context?.Operators.And(context?.Operators.Equal(FHIRHelpers_4_0_001.ToInteger(context?.Operators?.TypeConverter.Convert<Integer>((RightDiagnosis?.SequenceElement as object))), (int?)1), context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>(context?.Operators.LateBoundProperty<IEnumerable<Coding>>((RightDiagnosis?.Diagnosis as object), "coding"), (Coding DiagnosisCode) => context?.Operators.InList<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings)))))))))
;
			var h_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN
			{
				LineItems = g_,
			};
			var i_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN[]
			{
				h_,
			};
			var j_ = (Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN LineItemDefinition) =>
			{
				var c_ = LineItemDefinition?.LineItems;
				var d_ = (Claim ClaimWithDiagnosis) => (((context?.Operators.Not((bool?)(ClaimWithDiagnosis == null)) ?? false))
					? (new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = LineItemDefinition?.LineItems,
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Claim>(LineItemDefinition?.LineItems, (Claim @this) => context?.Operators.Not((bool?)(@this?.Item == null))), (Claim @this) => @this?.Item)), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval((NormalDate?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI)))
;
				var e_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(c_, d_);
				var f_ = (Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList) =>
				{
					var a_ = (FinalList == null);
					var b_ = (bool?)a_;

					return context?.Operators.Not(b_);
				};

				return context?.Operators.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(e_, f_);
			};
			var k_ = context?.Operators.SelectOrNull<Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(i_, j_);

			return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(k_);
		};
		var r_ = context?.Operators.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(p_, q_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(r_);
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
		var bf_ = (ClaimResponse ResponseItem) =>
		{
			var a_ = ResponseItem?.OutcomeElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = "complete";
			var e_ = "partial";
			var f_ = new string[]
			{
				d_,
				e_,
			};
			var g_ = (f_ as IEnumerable<string>);

			return context?.Operators.InList<string>(c_, g_);
		};
		var bg_ = context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, bf_);
		var bh_ = new Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD
		{
			PaidResponse = bg_,
		};
		var bi_ = new Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD[]
		{
			bh_,
		};
		var bj_ = (Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD ClaimResponse) =>
		{
			var bd_ = ClaimResponse?.PaidResponse;
			var be_ = (ClaimResponse ClmResp) =>
			{
				var at_ = ClmResp;
				var au_ = ClmResp?.Request;
				var av_ = au_?.ReferenceElement;
				var aw_ = (av_ as object);
				var ax_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(aw_);
				var ay_ = NCQAFHIRBase_1_0_0.GetId(ax_);
				var az_ = ClmResp?.Item;
				var ba_ = (az_ as IEnumerable<ClaimResponse.ItemComponent>);
				var bb_ = (ClaimResponse.ItemComponent ResponseItem) =>
				{
					var y_ = ResponseItem?.Adjudication;
					var z_ = (ClaimResponse.AdjudicationComponent @this) =>
					{
						var h_ = @this?.Category;
						var i_ = (h_ == null);
						var j_ = (bool?)i_;

						return context?.Operators.Not(j_);
					};
					var aa_ = context?.Operators.WhereOrNull<ClaimResponse.AdjudicationComponent>(y_, z_);
					var ab_ = (ClaimResponse.AdjudicationComponent @this) => @this?.Category;
					var ac_ = context?.Operators.SelectOrNull<ClaimResponse.AdjudicationComponent, CodeableConcept>(aa_, ab_);
					var ad_ = (CodeableConcept @this) =>
					{
						var k_ = @this?.Coding;
						var l_ = (k_ == null);
						var m_ = (bool?)l_;

						return context?.Operators.Not(m_);
					};
					var ae_ = context?.Operators.WhereOrNull<CodeableConcept>(ac_, ad_);
					var af_ = (CodeableConcept @this) => @this?.Coding;
					var ag_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(ae_, af_);
					var ah_ = context?.Operators.FlattenList<Coding>(ag_);
					var ai_ = (Coding CategoryItem) =>
					{
						var n_ = CategoryItem?.CodeElement;
						var o_ = n_?.Value;
						var p_ = (o_ as object);

						return context?.Operators.Equal(p_, ("benefit" as object));
					};
					var aj_ = context?.Operators.WhereOrNull<Coding>(ah_, ai_);
					var ak_ = context?.Operators.ExistsInList<Coding>(aj_);
					var al_ = ResponseItem?.Adjudication;
					var am_ = (ClaimResponse.AdjudicationComponent @this) =>
					{
						var q_ = @this?.Amount;
						var r_ = (q_ == null);
						var s_ = (bool?)r_;

						return context?.Operators.Not(s_);
					};
					var an_ = context?.Operators.WhereOrNull<ClaimResponse.AdjudicationComponent>(al_, am_);
					var ao_ = (ClaimResponse.AdjudicationComponent @this) => @this?.Amount;
					var ap_ = context?.Operators.SelectOrNull<ClaimResponse.AdjudicationComponent, Money>(an_, ao_);
					var aq_ = (Money DollarAmount) =>
					{
						var t_ = DollarAmount?.ValueElement;
						var u_ = FHIRHelpers_4_0_001.ToDecimal(t_);
						var v_ = u_;
						var w_ = context?.Operators.ConvertIntegerToDecimal((int?)0);
						var x_ = w_;

						return context?.Operators.Greater(v_, x_);
					};
					var ar_ = context?.Operators.WhereOrNull<Money>(ap_, aq_);
					var as_ = context?.Operators.ExistsInList<Money>(ar_);

					return context?.Operators.And(ak_, as_);
				};
				var bc_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(ba_, bb_);

				return new Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL
				{
					Response = at_,
					ResponseID = ay_,
					LineItems = bc_,
				};
			};

			return context?.Operators.SelectOrNull<ClaimResponse, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(bd_, be_);
		};
		var bk_ = context?.Operators.SelectOrNull<Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD, IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(bi_, bj_);

		return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(bk_);
	}


    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_and_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var bd_ = (Claim AllClaims) =>
		{
			var o_ = AllClaims?.Item;
			var p_ = (Claim.ItemComponent @this) =>
			{
				var a_ = @this?.ProductOrService;
				var b_ = (a_ == null);
				var c_ = (bool?)b_;

				return context?.Operators.Not(c_);
			};
			var q_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(o_, p_);
			var r_ = (Claim.ItemComponent @this) => @this?.ProductOrService;
			var s_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(q_, r_);
			var t_ = (CodeableConcept @this) =>
			{
				var d_ = @this?.Coding;
				var e_ = (d_ == null);
				var f_ = (bool?)e_;

				return context?.Operators.Not(f_);
			};
			var u_ = context?.Operators.WhereOrNull<CodeableConcept>(s_, t_);
			var v_ = (CodeableConcept @this) => @this?.Coding;
			var w_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(u_, v_);
			var x_ = context?.Operators.FlattenList<Coding>(w_);
			var y_ = (Coding ProductOrServiceCode) =>
			{
				var g_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

				return context?.Operators.CodeInList(g_, ProductOrServiceValueSet);
			};
			var z_ = context?.Operators.WhereOrNull<Coding>(x_, y_);
			var aa_ = context?.Operators.ExistsInList<Coding>(z_);
			var ab_ = AllClaims?.Diagnosis;
			var ac_ = (ab_ as IEnumerable<Claim.DiagnosisComponent>);
			var ad_ = (Claim.DiagnosisComponent @this) =>
			{
				var h_ = @this?.Diagnosis;
				var i_ = (h_ == null);
				var j_ = (bool?)i_;

				return context?.Operators.Not(j_);
			};
			var ae_ = context?.Operators.WhereOrNull<Claim.DiagnosisComponent>(ac_, ad_);
			var af_ = (Claim.DiagnosisComponent @this) => @this?.Diagnosis;
			var ag_ = context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(ae_, af_);
			var ah_ = (DataType @this) =>
			{
				var k_ = context?.Operators.LateBoundProperty<object>((@this as object), "coding");
				var l_ = (k_ == null);
				var m_ = (bool?)l_;

				return context?.Operators.Not(m_);
			};
			var ai_ = context?.Operators.WhereOrNull<DataType>(ag_, ah_);
			var aj_ = (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding");
			var ak_ = context?.Operators.SelectOrNull<DataType, object>(ai_, aj_);
			var al_ = context?.Operators.FlattenLateBoundList(ak_);
			var am_ = (object @object) => (@object as Coding);
			var an_ = context?.Operators.SelectOrNull<object, Coding>(al_, am_);
			var ao_ = (Coding DiagnosisCode) =>
			{
				var n_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);

				return context?.Operators.CodeInList(n_, DiagnosisValueSet);
			};
			var ap_ = context?.Operators.WhereOrNull<Coding>(an_, ao_);
			var aq_ = context?.Operators.ExistsInList<Coding>(ap_);

			return context?.Operators.And(aa_, aq_);
		};
		var be_ = context?.Operators.WhereOrNull<Claim>(claim, bd_);
		var bf_ = (Claim ProcedureClaims) =>
		{
			var ax_ = ProcedureClaims;
			var ay_ = ProcedureClaims?.IdElement;
			var az_ = ProcedureClaims?.Item;
			var ba_ = (az_ as IEnumerable<Claim.ItemComponent>);
			var bb_ = (Claim.ItemComponent ResponseItem) =>
			{
				var as_ = ResponseItem?.ProductOrService;
				var at_ = as_?.Coding;
				var au_ = (at_ as IEnumerable<Coding>);
				var av_ = (Coding ProductOrServiceCode) =>
				{
					var ar_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

					return context?.Operators.CodeInList(ar_, ProductOrServiceValueSet);
				};
				var aw_ = context?.Operators.WhereOrNull<Coding>(au_, av_);

				return context?.Operators.ExistsInList<Coding>(aw_);
			};
			var bc_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ba_, bb_);

			return new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = ax_,
				ClaimID = ay_,
				LineItems = bc_,
			};
		};

		return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(be_, bf_);
	}


    [CqlDeclaration("Get Corresponding Claim for Services and Conditions")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_and_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var at_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var au_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		var av_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = at_,
			MedicalClaim = au_,
		};
		var aw_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			av_,
		};
		var ax_ = (Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse) =>
		{
			var am_ = ClaimAndResponse?.MedicalClaim;
			var an_ = (Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim) =>
			{
				var ac_ = medClaim;
				var ad_ = medClaim?.LineItems;
				var ae_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var z_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					var aa_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var v_ = pClaim?.LineItems;
						var w_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
						{
							var a_ = ((medClaim?.ClaimofInterest is Resource)
								? ((medClaim?.ClaimofInterest as Resource)?.IdElement)
								: (null))
;
							var b_ = (a_ as object);
							var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
							var d_ = (c_ as object);
							var e_ = pClaim?.Response;
							var f_ = e_?.Request;
							var g_ = f_?.ReferenceElement;
							var h_ = (g_ as object);
							var i_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(h_);
							var j_ = NCQAFHIRBase_1_0_0.GetId(i_);
							var k_ = (j_ as object);
							var l_ = context?.Operators.Equal(d_, k_);
							var m_ = medClaimLineItem?.SequenceElement;
							var n_ = (m_ as object);
							var o_ = context?.Operators?.TypeConverter.Convert<Integer>(n_);
							var p_ = (o_ as object);
							var q_ = pClaimLineItem?.ItemSequenceElement;
							var r_ = (q_ as object);
							var s_ = context?.Operators?.TypeConverter.Convert<Integer>(r_);
							var t_ = (s_ as object);
							var u_ = context?.Operators.Equal(p_, t_);

							return context?.Operators.And(l_, u_);
						};
						var x_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(v_, w_);
						var y_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;

						return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(x_, y_);
					};
					var ab_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, aa_);

					return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ab_);
				};
				var af_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ad_, ae_);

				return new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = ac_,
					ClaimItem = af_,
				};
			};
			var ao_ = context?.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(am_, an_);
			var ap_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = ao_,
			};
			var aq_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				ap_,
			};
			var ar_ = (Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse) =>
			{
				var ai_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem))) ?? false))
					? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.PaidClaim == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.PaidClaim),
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval((PaidItem?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
;
				var aj_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ai_,
				};
				var ak_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
				{
					var ag_ = (FinalList == null);
					var ah_ = (bool?)ag_;

					return context?.Operators.Not(ah_);
				};
				var al_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_, ak_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(al_);
			};
			var as_ = context?.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aq_, ar_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(as_);
		};
		var ay_ = context?.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aw_, ax_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ay_);
	}


    [CqlDeclaration("Get Paid Claims for Provided Service and Condition")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Service_and_Condition(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var c_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, claim);
		var d_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			c_,
		};
		var e_ = (Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse) => (((context?.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse == null), (bool?)(MedicalClaimAndResponse?.MedicalClaim == null)) ?? false))
			? ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))
			: (this.Get_Corresponding_Claim_for_Services_and_Conditions(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet)))
;
		var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_, e_);
		var g_ = context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);
		var h_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
		{
			g_,
		};
		var i_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
		{
			var a_ = (FinalList == null);
			var b_ = (bool?)a_;

			return context?.Operators.Not(b_);
		};
		var j_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(h_, i_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(j_);
	}


    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_or_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var ar_ = (Claim AllClaims) =>
		{
			var o_ = AllClaims?.Item;
			var p_ = (Claim.ItemComponent @this) =>
			{
				var a_ = @this?.ProductOrService;
				var b_ = (a_ == null);
				var c_ = (bool?)b_;

				return context?.Operators.Not(c_);
			};
			var q_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(o_, p_);
			var r_ = (Claim.ItemComponent @this) => @this?.ProductOrService;
			var s_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(q_, r_);
			var t_ = (CodeableConcept @this) =>
			{
				var d_ = @this?.Coding;
				var e_ = (d_ == null);
				var f_ = (bool?)e_;

				return context?.Operators.Not(f_);
			};
			var u_ = context?.Operators.WhereOrNull<CodeableConcept>(s_, t_);
			var v_ = (CodeableConcept @this) => @this?.Coding;
			var w_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(u_, v_);
			var x_ = context?.Operators.FlattenList<Coding>(w_);
			var y_ = (Coding ProductOrServiceCode) =>
			{
				var g_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

				return context?.Operators.CodeInList(g_, ProductOrServiceValueSet);
			};
			var z_ = context?.Operators.WhereOrNull<Coding>(x_, y_);
			var aa_ = context?.Operators.ExistsInList<Coding>(z_);
			var ab_ = AllClaims?.Diagnosis;
			var ac_ = (ab_ as IEnumerable<Claim.DiagnosisComponent>);
			var ad_ = (Claim.DiagnosisComponent @this) =>
			{
				var h_ = @this?.Diagnosis;
				var i_ = (h_ == null);
				var j_ = (bool?)i_;

				return context?.Operators.Not(j_);
			};
			var ae_ = context?.Operators.WhereOrNull<Claim.DiagnosisComponent>(ac_, ad_);
			var af_ = (Claim.DiagnosisComponent @this) => @this?.Diagnosis;
			var ag_ = context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(ae_, af_);
			var ah_ = (DataType @this) =>
			{
				var k_ = context?.Operators.LateBoundProperty<object>((@this as object), "coding");
				var l_ = (k_ == null);
				var m_ = (bool?)l_;

				return context?.Operators.Not(m_);
			};
			var ai_ = context?.Operators.WhereOrNull<DataType>(ag_, ah_);
			var aj_ = (DataType @this) => context?.Operators.LateBoundProperty<object>((@this as object), "coding");
			var ak_ = context?.Operators.SelectOrNull<DataType, object>(ai_, aj_);
			var al_ = context?.Operators.FlattenLateBoundList(ak_);
			var am_ = (object @object) => (@object as Coding);
			var an_ = context?.Operators.SelectOrNull<object, Coding>(al_, am_);
			var ao_ = (Coding DiagnosisCode) =>
			{
				var n_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);

				return context?.Operators.CodeInList(n_, DiagnosisValueSet);
			};
			var ap_ = context?.Operators.WhereOrNull<Coding>(an_, ao_);
			var aq_ = context?.Operators.ExistsInList<Coding>(ap_);

			return context?.Operators.Or(aa_, aq_);
		};
		var as_ = context?.Operators.WhereOrNull<Claim>(claim, ar_);
		var at_ = (Claim ProcedureClaims) => (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), (Coding ProductOrServiceCode) => context?.Operators.CodeInList(FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode), ProductOrServiceValueSet))))) ?? false))
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
					LineItems = context?.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => context?.Operators.Equal(context?.Operators?.TypeConverter.Convert<Integer>((ResponseItem?.SequenceElement as object))?.Value, (int?)1)),
				}))
;

		return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(as_, at_);
	}


    [CqlDeclaration("Get Corresponding Claim for Services or Conditions")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
	{
		var at_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var au_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(claim, ProductOrServiceValueSet, DiagnosisValueSet);
		var av_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = at_,
			MedicalClaim = au_,
		};
		var aw_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			av_,
		};
		var ax_ = (Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse) =>
		{
			var am_ = ClaimAndResponse?.MedicalClaim;
			var an_ = (Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim) =>
			{
				var ac_ = medClaim;
				var ad_ = medClaim?.LineItems;
				var ae_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var z_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					var aa_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var v_ = pClaim?.LineItems;
						var w_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
						{
							var a_ = ((medClaim?.ClaimofInterest is Resource)
								? ((medClaim?.ClaimofInterest as Resource)?.IdElement)
								: (null))
;
							var b_ = (a_ as object);
							var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
							var d_ = (c_ as object);
							var e_ = pClaim?.Response;
							var f_ = e_?.Request;
							var g_ = f_?.ReferenceElement;
							var h_ = (g_ as object);
							var i_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(h_);
							var j_ = NCQAFHIRBase_1_0_0.GetId(i_);
							var k_ = (j_ as object);
							var l_ = context?.Operators.Equal(d_, k_);
							var m_ = medClaimLineItem?.SequenceElement;
							var n_ = (m_ as object);
							var o_ = context?.Operators?.TypeConverter.Convert<Integer>(n_);
							var p_ = (o_ as object);
							var q_ = pClaimLineItem?.ItemSequenceElement;
							var r_ = (q_ as object);
							var s_ = context?.Operators?.TypeConverter.Convert<Integer>(r_);
							var t_ = (s_ as object);
							var u_ = context?.Operators.Equal(p_, t_);

							return context?.Operators.And(l_, u_);
						};
						var x_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(v_, w_);
						var y_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;

						return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(x_, y_);
					};
					var ab_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, aa_);

					return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ab_);
				};
				var af_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ad_, ae_);

				return new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = ac_,
					ClaimItem = af_,
				};
			};
			var ao_ = context?.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(am_, an_);
			var ap_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = ao_,
			};
			var aq_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				ap_,
			};
			var ar_ = (Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse) =>
			{
				var ai_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem))) ?? false))
					? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.PaidClaim == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.PaidClaim),
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval((PaidItem?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
;
				var aj_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ai_,
				};
				var ak_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
				{
					var ag_ = (FinalList == null);
					var ah_ = (bool?)ag_;

					return context?.Operators.Not(ah_);
				};
				var al_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_, ak_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(al_);
			};
			var as_ = context?.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aq_, ar_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(as_);
		};
		var ay_ = context?.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aw_, ax_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ay_);
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
		var af_ = (Claim AllClaims) =>
		{
			var h_ = AllClaims?.Item;
			var i_ = (Claim.ItemComponent @this) =>
			{
				var a_ = @this?.ProductOrService;
				var b_ = (a_ == null);
				var c_ = (bool?)b_;

				return context?.Operators.Not(c_);
			};
			var j_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(h_, i_);
			var k_ = (Claim.ItemComponent @this) => @this?.ProductOrService;
			var l_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(j_, k_);
			var m_ = (CodeableConcept @this) =>
			{
				var d_ = @this?.Coding;
				var e_ = (d_ == null);
				var f_ = (bool?)e_;

				return context?.Operators.Not(f_);
			};
			var n_ = context?.Operators.WhereOrNull<CodeableConcept>(l_, m_);
			var o_ = (CodeableConcept @this) => @this?.Coding;
			var p_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(n_, o_);
			var q_ = context?.Operators.FlattenList<Coding>(p_);
			var r_ = (Coding ProductOrServiceCode) =>
			{
				var g_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

				return context?.Operators.CodeInList(g_, ProductOrServiceValueSet);
			};
			var s_ = context?.Operators.WhereOrNull<Coding>(q_, r_);

			return context?.Operators.ExistsInList<Coding>(s_);
		};
		var ag_ = context?.Operators.WhereOrNull<Claim>(claim, af_);
		var ah_ = (Claim AllClaims) =>
		{
			var z_ = AllClaims;
			var aa_ = AllClaims?.IdElement;
			var ab_ = AllClaims?.Item;
			var ac_ = (ab_ as IEnumerable<Claim.ItemComponent>);
			var ad_ = (Claim.ItemComponent ResponseItem) =>
			{
				var u_ = ResponseItem?.ProductOrService;
				var v_ = u_?.Coding;
				var w_ = (v_ as IEnumerable<Coding>);
				var x_ = (Coding ProductOrServiceCode) =>
				{
					var t_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);

					return context?.Operators.CodeInList(t_, ProductOrServiceValueSet);
				};
				var y_ = context?.Operators.WhereOrNull<Coding>(w_, x_);

				return context?.Operators.ExistsInList<Coding>(y_);
			};
			var ae_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ac_, ad_);

			return new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = z_,
				ClaimID = aa_,
				LineItems = ae_,
			};
		};

		return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(ag_, ah_);
	}


    [CqlDeclaration("Get Corresponding Claim for Services Only")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
	{
		var at_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var au_ = this.Get_All_Claims_With_Procedure_Only(claim, ProductOrServiceValueSet);
		var av_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = at_,
			MedicalClaim = au_,
		};
		var aw_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			av_,
		};
		var ax_ = (Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ ClaimAndResponse) =>
		{
			var am_ = ClaimAndResponse?.MedicalClaim;
			var an_ = (Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim) =>
			{
				var ac_ = medClaim;
				var ad_ = medClaim?.LineItems;
				var ae_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var z_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					var aa_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var v_ = pClaim?.LineItems;
						var w_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
						{
							var a_ = ((medClaim?.ClaimofInterest is Resource)
								? ((medClaim?.ClaimofInterest as Resource)?.IdElement)
								: (null))
;
							var b_ = (a_ as object);
							var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
							var d_ = (c_ as object);
							var e_ = pClaim?.Response;
							var f_ = e_?.Request;
							var g_ = f_?.ReferenceElement;
							var h_ = (g_ as object);
							var i_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(h_);
							var j_ = NCQAFHIRBase_1_0_0.GetId(i_);
							var k_ = (j_ as object);
							var l_ = context?.Operators.Equal(d_, k_);
							var m_ = medClaimLineItem?.SequenceElement;
							var n_ = (m_ as object);
							var o_ = context?.Operators?.TypeConverter.Convert<Integer>(n_);
							var p_ = (o_ as object);
							var q_ = pClaimLineItem?.ItemSequenceElement;
							var r_ = (q_ as object);
							var s_ = context?.Operators?.TypeConverter.Convert<Integer>(r_);
							var t_ = (s_ as object);
							var u_ = context?.Operators.Equal(p_, t_);

							return context?.Operators.And(l_, u_);
						};
						var x_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(v_, w_);
						var y_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;

						return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(x_, y_);
					};
					var ab_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, aa_);

					return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ab_);
				};
				var af_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ad_, ae_);

				return new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = ac_,
					ClaimItem = af_,
				};
			};
			var ao_ = context?.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(am_, an_);
			var ap_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = ao_,
			};
			var aq_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				ap_,
			};
			var ar_ = (Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD ClaimWithPaidResponse) =>
			{
				var ai_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem))) ?? false))
					? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.PaidClaim == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.PaidClaim),
							ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval((PaidItem?.Serviced as object))),
						})
					: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
;
				var aj_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ai_,
				};
				var ak_ = (Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList) =>
				{
					var ag_ = (FinalList == null);
					var ah_ = (bool?)ag_;

					return context?.Operators.Not(ah_);
				};
				var al_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aj_, ak_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(al_);
			};
			var as_ = context?.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aq_, ar_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(as_);
		};
		var ay_ = context?.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(aw_, ax_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(ay_);
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
		var at_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
		var au_ = this.Pharmacy_Claim_With_Medication(claim, ProductOrServiceValueSet);
		var av_ = new Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB
		{
			PaidPharmacyClaimResponse = at_,
			MedicalClaim = au_,
		};
		var aw_ = new Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB[]
		{
			av_,
		};
		var ax_ = (Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB ClaimAndResponse) =>
		{
			var am_ = ClaimAndResponse?.MedicalClaim;
			var an_ = (Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC medClaim) =>
			{
				var ac_ = medClaim;
				var ad_ = medClaim?.LineItem;
				var ae_ = (Claim.ItemComponent medClaimLineItem) =>
				{
					var z_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
					var aa_ = (Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim) =>
					{
						var v_ = pClaim?.LineItems;
						var w_ = (ClaimResponse.ItemComponent pClaimLineItem) =>
						{
							var a_ = ((medClaim?.Claim is Resource)
								? ((medClaim?.Claim as Resource)?.IdElement)
								: (null))
;
							var b_ = (a_ as object);
							var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
							var d_ = (c_ as object);
							var e_ = pClaim?.Response;
							var f_ = e_?.Request;
							var g_ = f_?.ReferenceElement;
							var h_ = (g_ as object);
							var i_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(h_);
							var j_ = NCQAFHIRBase_1_0_0.GetId(i_);
							var k_ = (j_ as object);
							var l_ = context?.Operators.Equal(d_, k_);
							var m_ = medClaimLineItem?.SequenceElement;
							var n_ = (m_ as object);
							var o_ = context?.Operators?.TypeConverter.Convert<Integer>(n_);
							var p_ = (o_ as object);
							var q_ = pClaimLineItem?.ItemSequenceElement;
							var r_ = (q_ as object);
							var s_ = context?.Operators?.TypeConverter.Convert<Integer>(r_);
							var t_ = (s_ as object);
							var u_ = context?.Operators.Equal(p_, t_);

							return context?.Operators.And(l_, u_);
						};
						var x_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(v_, w_);
						var y_ = (ClaimResponse.ItemComponent pClaimLineItem) => pClaim;

						return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(x_, y_);
					};
					var ab_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, aa_);

					return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ab_);
				};
				var af_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ad_, ae_);

				return new Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT
				{
					PaidClaim = ac_,
					ClaimItem = af_,
				};
			};
			var ao_ = context?.Operators.SelectOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC, Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(am_, an_);
			var ap_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB
			{
				AggregateClaim = ao_,
			};
			var aq_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB[]
			{
				ap_,
			};
			var ar_ = (Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB ClaimWithPaidResponse) =>
			{
				var ai_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => context?.Operators.Not((bool?)(@this?.ClaimItem == null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => @this?.ClaimItem))) ?? false))
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
				var aj_ = new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO[]
				{
					ai_,
				};
				var ak_ = (Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO FinalList) =>
				{
					var ag_ = (FinalList == null);
					var ah_ = (bool?)ag_;

					return context?.Operators.Not(ah_);
				};
				var al_ = context?.Operators.WhereOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(aj_, ak_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(al_);
			};
			var as_ = context?.Operators.SelectOrNull<Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(aq_, ar_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(as_);
		};
		var ay_ = context?.Operators.SelectOrNull<Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(aw_, ax_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(ay_);
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
		var ax_ = (Claim Claim) =>
		{
			var at_ = (ClaimResponse CR) =>
			{
				var a_ = Claim?.IdElement;
				var b_ = (a_ as object);
				var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
				var d_ = (c_ as object);
				var e_ = CR?.Request;
				var f_ = e_?.ReferenceElement;
				var g_ = (f_ as object);
				var h_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(g_);
				var i_ = NCQAFHIRBase_1_0_0.GetId(h_);
				var j_ = (i_ as object);

				return context?.Operators.Equal(d_, j_);
			};
			var au_ = context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, at_);
			var av_ = (Claim C) =>
			{
				var aa_ = Claim?.IdElement;
				var ab_ = (aa_ as object);
				var ac_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(ab_);
				var ad_ = (ac_ as object);
				var ae_ = (ClaimResponse CR) =>
				{
					var k_ = Claim?.IdElement;
					var l_ = (k_ as object);
					var m_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(l_);
					var n_ = (m_ as object);
					var o_ = CR?.Request;
					var p_ = o_?.ReferenceElement;
					var q_ = (p_ as object);
					var r_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(q_);
					var s_ = NCQAFHIRBase_1_0_0.GetId(r_);
					var t_ = (s_ as object);

					return context?.Operators.Equal(n_, t_);
				};
				var af_ = context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, ae_);
				var ag_ = (ClaimResponse @this) =>
				{
					var u_ = @this?.Request;
					var v_ = (u_ == null);
					var w_ = (bool?)v_;

					return context?.Operators.Not(w_);
				};
				var ah_ = context?.Operators.WhereOrNull<ClaimResponse>(af_, ag_);
				var ai_ = (ClaimResponse @this) => @this?.Request;
				var aj_ = context?.Operators.SelectOrNull<ClaimResponse, ResourceReference>(ah_, ai_);
				var ak_ = (ResourceReference @this) =>
				{
					var x_ = @this?.ReferenceElement;
					var y_ = (x_ == null);
					var z_ = (bool?)y_;

					return context?.Operators.Not(z_);
				};
				var al_ = context?.Operators.WhereOrNull<ResourceReference>(aj_, ak_);
				var am_ = (ResourceReference @this) => @this?.ReferenceElement;
				var an_ = context?.Operators.SelectOrNull<ResourceReference, FhirString>(al_, am_);
				var ao_ = context?.Operators.SingleOrNull<FhirString>(an_);
				var ap_ = (ao_ as object);
				var aq_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(ap_);
				var ar_ = NCQAFHIRBase_1_0_0.GetId(aq_);
				var as_ = (ar_ as object);

				return context?.Operators.Equal(ad_, as_);
			};
			var aw_ = context?.Operators.WhereOrNull<Claim>(claim, av_);

			return new Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI
			{
				ClaimResponse = au_,
				OriginalClaim = aw_,
			};
		};

		return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI>(claim, ax_);
	}


    [CqlDeclaration("Medical Claims With Nonacute or Acute Inpatient Discharge")]
    public Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(IEnumerable<Claim> claim)
	{
		var af_ = this.Professional_or_Institutional_Claims(claim);
		var ag_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = af_,
		};
		var ah_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			ag_,
		};
		var ai_ = (Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO ClaimWithInpatientStay) =>
		{
			var z_ = (((ClaimWithInpatientStay?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithInpatientStay?.MedicalClaim, (Claim c) => context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.WhereOrNull<Claim.ItemComponent>((c?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent i) => context?.Operators.ExistsInList<CqlCode>(context?.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(i?.Revenue)?.codes as IEnumerable<CqlCode>), (CqlCode rev) => context?.Operators.StringInValueSet(rev?.code, this.Inpatient_Stay()))))))))
;
			var aa_ = (((ClaimWithInpatientStay?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(ClaimWithInpatientStay?.MedicalClaim, (Claim c) => context?.Operators.Or(context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.WhereOrNull<Claim.ItemComponent>((c?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent i) => context?.Operators.ExistsInList<CqlCode>(context?.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(i?.Revenue)?.codes as IEnumerable<CqlCode>), (CqlCode rev) => context?.Operators.StringInValueSet(rev?.code, this.Nonacute_Inpatient_Stay()))))), context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>((c?.SubType?.Coding as IEnumerable<Coding>), (Coding tob) => context?.Operators.StringInValueSet(tob?.CodeElement?.Value, this.Nonacute_Inpatient_Stay())))))))
;
			var ab_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb
			{
				InpatientStayLineItems = z_,
				NonacuteInpatientLineItems = aa_,
			};
			var ac_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb[]
			{
				ab_,
			};
			var ad_ = (Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb LineItemDefinition) =>
			{
				var q_ = LineItemDefinition?.InpatientStayLineItems;
				var r_ = LineItemDefinition?.NonacuteInpatientLineItems;
				var s_ = (Claim nonAcuteInpatientStay) =>
				{
					var e_ = LineItemDefinition?.InpatientStayLineItems;
					var f_ = (Claim inpatientStay) =>
					{
						var a_ = nonAcuteInpatientStay?.IdElement;
						var b_ = (a_ as object);
						var c_ = inpatientStay?.IdElement;
						var d_ = (c_ as object);

						return context?.Operators.Equal(b_, d_);
					};
					var g_ = context?.Operators.WhereOrNull<Claim>(e_, f_);
					var h_ = (Claim inpatientStay) => nonAcuteInpatientStay;

					return context?.Operators.SelectOrNull<Claim, Claim>(g_, h_);
				};
				var t_ = context?.Operators.SelectManyOrNull<Claim, Claim>(r_, s_);
				var u_ = LineItemDefinition?.InpatientStayLineItems;
				var v_ = LineItemDefinition?.InpatientStayLineItems;
				var w_ = (Claim inpatientStay) =>
				{
					var m_ = LineItemDefinition?.NonacuteInpatientLineItems;
					var n_ = (Claim nonAcuteInpatientStay) =>
					{
						var i_ = inpatientStay?.IdElement;
						var j_ = (i_ as object);
						var k_ = nonAcuteInpatientStay?.IdElement;
						var l_ = (k_ as object);

						return context?.Operators.Equal(j_, l_);
					};
					var o_ = context?.Operators.WhereOrNull<Claim>(m_, n_);
					var p_ = (Claim nonAcuteInpatientStay) => inpatientStay;

					return context?.Operators.SelectOrNull<Claim, Claim>(o_, p_);
				};
				var x_ = context?.Operators.SelectManyOrNull<Claim, Claim>(v_, w_);
				var y_ = context?.Operators.ListExcept<Claim>(u_, x_);

				return new Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE
				{
					InpatientDischarge = q_,
					NonacuteInpatientDischarge = t_,
					AcuteInpatientDischarge = y_,
				};
			};
			var ae_ = context?.Operators.SelectOrNull<Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb, Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(ac_, ad_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(ae_);
		};
		var aj_ = context?.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(ah_, ai_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(aj_);
	}


    [CqlDeclaration("Get Prescriber NPI from Claims")]
    public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Prescriber_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		var dq_ = (Claim C) =>
		{
			var z_ = C;
			var aa_ = C?.CareTeam;
			var ab_ = (aa_ as IEnumerable<Claim.CareTeamComponent>);
			var ac_ = (Claim.CareTeamComponent ct) =>
			{
				var a_ = ct?.SequenceElement;
				var b_ = (a_ as object);
				var c_ = context?.Operators?.TypeConverter.Convert<Integer>(b_);
				var d_ = FHIRHelpers_4_0_001.ToInteger(c_);
				var e_ = d_;
				var f_ = (int?)1;
				var g_ = f_;

				return context?.Operators.Equal(e_, g_);
			};
			var ad_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(ab_, ac_);
			var ae_ = (Claim.CareTeamComponent @this) =>
			{
				var h_ = @this?.Provider;
				var i_ = (h_ == null);
				var j_ = (bool?)i_;

				return context?.Operators.Not(j_);
			};
			var af_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(ad_, ae_);
			var ag_ = (Claim.CareTeamComponent @this) => @this?.Provider;
			var ah_ = context?.Operators.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(af_, ag_);
			var ai_ = C?.CareTeam;
			var aj_ = (ai_ as IEnumerable<Claim.CareTeamComponent>);
			var ak_ = (Claim.CareTeamComponent ct) =>
			{
				var k_ = ct?.SequenceElement;
				var l_ = (k_ as object);
				var m_ = context?.Operators?.TypeConverter.Convert<Integer>(l_);
				var n_ = FHIRHelpers_4_0_001.ToInteger(m_);
				var o_ = n_;
				var p_ = (int?)1;
				var q_ = p_;

				return context?.Operators.Equal(o_, q_);
			};
			var al_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(aj_, ak_);
			var am_ = (Claim.CareTeamComponent @this) =>
			{
				var r_ = @this?.Provider;
				var s_ = (r_ == null);
				var t_ = (bool?)s_;

				return context?.Operators.Not(t_);
			};
			var an_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(al_, am_);
			var ao_ = (Claim.CareTeamComponent @this) => @this?.Provider;
			var ap_ = context?.Operators.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(an_, ao_);
			var aq_ = (ResourceReference p) =>
			{
				var v_ = p?.ReferenceElement;
				var w_ = new FhirString[]
				{
					v_,
				};
				var x_ = (FhirString r) =>
				{
					var u_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>((r as object));

					return NCQAFHIRBase_1_0_0.GetId(u_);
				};
				var y_ = context?.Operators.SelectOrNull<FhirString, string>(w_, x_);

				return context?.Operators.SingleOrNull<string>(y_);
			};
			var ar_ = context?.Operators.SelectOrNull<ResourceReference, string>(ap_, aq_);

			return new Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS
			{
				SingleCareTeam = z_,
				CareTeamsProvider = ah_,
				CareTeamsProviderID = ar_,
			};
		};
		var dr_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(claim, dq_);
		var ds_ = new Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR
		{
			CareTeams = dr_,
		};
		var dt_ = new Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR[]
		{
			ds_,
		};
		var du_ = (Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR ClaimProperties) =>
		{
			var dj_ = context?.DataRetriever.RetrieveByValueSet<Practitioner>(null, null);
			var dk_ = (Practitioner p) =>
			{
				var av_ = p?.IdElement;
				var aw_ = (av_ as object);
				var ax_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(aw_);
				var ay_ = ClaimProperties?.CareTeams;
				var az_ = (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) =>
				{
					var as_ = @this?.CareTeamsProviderID;
					var at_ = (as_ == null);
					var au_ = (bool?)at_;

					return context?.Operators.Not(au_);
				};
				var ba_ = context?.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ay_, az_);
				var bb_ = (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this?.CareTeamsProviderID;
				var bc_ = context?.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, IEnumerable<string>>(ba_, bb_);
				var bd_ = context?.Operators.FlattenList<string>(bc_);

				return context?.Operators.InList<string>(ax_, bd_);
			};
			var dl_ = context?.Operators.WhereOrNull<Practitioner>(dj_, dk_);
			var dm_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe
			{
				Practitioners = dl_,
			};
			var dn_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe[]
			{
				dm_,
			};
			var do_ = (Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe PractitionerMatch) =>
			{
				var da_ = PractitionerMatch?.Practitioners;
				var db_ = (Practitioner P) =>
				{
					var be_ = (P == null);
					var bf_ = (bool?)be_;

					return context?.Operators.Not(bf_);
				};
				var dc_ = context?.Operators.WhereOrNull<Practitioner>(da_, db_);
				var dd_ = (Practitioner P) =>
				{
					var cn_ = P?.Identifier;
					var co_ = (cn_ as IEnumerable<Identifier>);
					var cp_ = (Identifier l) =>
					{
						var bg_ = l?.SystemElement;
						var bh_ = bg_?.Value;
						var bi_ = (bh_ as object);
						var bj_ = context?.Operators.Equal(bi_, ("http://hl7.org/fhir/sid/us-npi" as object));
						var bk_ = l?.Type;
						var bl_ = FHIRHelpers_4_0_001.ToConcept(bk_);
						var bm_ = (bl_ as object);
						var bn_ = NCQATerminology_1_0_0.Provider_number();
						var bo_ = context?.Operators.ConvertCodeToConcept(bn_);
						var bp_ = (bo_ as object);
						var bq_ = context?.Operators.Equivalent(bm_, bp_);
						var br_ = context?.Operators.And(bj_, bq_);
						var bs_ = l?.ValueElement;
						var bt_ = bs_?.Value;
						var bu_ = (bt_ == null);
						var bv_ = (bool?)bu_;
						var bw_ = context?.Operators.Not(bv_);

						return context?.Operators.And(br_, bw_);
					};
					var cq_ = context?.Operators.WhereOrNull<Identifier>(co_, cp_);
					var cr_ = (Identifier l) => l?.ValueElement;
					var cs_ = context?.Operators.SelectOrNull<Identifier, FhirString>(cq_, cr_);
					var ct_ = P?.Identifier;
					var cu_ = (ct_ as IEnumerable<Identifier>);
					var cv_ = (Identifier l) =>
					{
						var bx_ = l?.SystemElement;
						var by_ = bx_?.Value;
						var bz_ = (by_ as object);
						var ca_ = context?.Operators.Equal(bz_, ("http://hl7.org/fhir/sid/us-npi" as object));
						var cb_ = l?.Type;
						var cc_ = FHIRHelpers_4_0_001.ToConcept(cb_);
						var cd_ = (cc_ as object);
						var ce_ = NCQATerminology_1_0_0.Provider_number();
						var cf_ = context?.Operators.ConvertCodeToConcept(ce_);
						var cg_ = (cf_ as object);
						var ch_ = context?.Operators.Equivalent(cd_, cg_);
						var ci_ = context?.Operators.And(ca_, ch_);
						var cj_ = l?.ValueElement;
						var ck_ = cj_?.Value;
						var cl_ = (ck_ == null);
						var cm_ = (bool?)cl_;

						return context?.Operators.And(ci_, cm_);
					};
					var cw_ = context?.Operators.WhereOrNull<Identifier>(cu_, cv_);
					var cx_ = (Identifier l) => l;
					var cy_ = context?.Operators.SelectOrNull<Identifier, Identifier>(cw_, cx_);

					return new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = cs_,
						NullIdentifiers = cy_,
					};
				};
				var de_ = context?.Operators.SelectOrNull<Practitioner, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(dc_, dd_);
				var df_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = de_,
				};
				var dg_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					df_,
				};
				var dh_ = (Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers) =>
				{
					var cz_ = (((context?.Operators.ExistsInList<Claim>(context?.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context?.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => context?.Operators.Not((bool?)(@this?.SingleCareTeam == null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this?.SingleCareTeam)) ?? false))
						? (context?.Operators.Add(context?.Operators.Add(context?.Operators.CountOrNull<Claim>(context?.Operators.WhereOrNull<Claim>(context?.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context?.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => context?.Operators.Not((bool?)(@this?.SingleCareTeam == null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this?.SingleCareTeam), (Claim X) => (bool?)((X?.CareTeam as IEnumerable<Claim.CareTeamComponent>) == null))), context?.Operators.CountOrNull<FhirString>(context?.Operators.SelectOrNull<FhirString, FhirString>(context?.Operators.FlattenList<FhirString>(context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.AllIdentifiers)), (FhirString X) => X))), context?.Operators.CountOrNull<Identifier>(context?.Operators.FlattenList<Identifier>(context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.NullIdentifiers)))))
						: ((int?)0))
;

					return new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = cz_,
					};
				};
				var di_ = context?.Operators.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dg_, dh_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(di_);
			};
			var dp_ = context?.Operators.SelectOrNull<Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dn_, do_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dp_);
		};
		var dv_ = context?.Operators.SelectOrNull<Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dt_, du_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dv_);
	}


    [CqlDeclaration("Get Pharmacy NPI from Claims")]
    public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Pharmacy_NPI_from_Claims(IEnumerable<Claim> claim)
	{
		var dt_ = (Claim C) =>
		{
			var z_ = C?.Item;
			var aa_ = (z_ as IEnumerable<Claim.ItemComponent>);
			var ab_ = C?.Item;
			var ac_ = (ab_ as IEnumerable<Claim.ItemComponent>);
			var ad_ = (Claim.ItemComponent i) =>
			{
				var a_ = i?.SequenceElement;
				var b_ = (a_ as object);
				var c_ = context?.Operators?.TypeConverter.Convert<Integer>(b_);
				var d_ = FHIRHelpers_4_0_001.ToInteger(c_);
				var e_ = d_;
				var f_ = (int?)1;
				var g_ = f_;

				return context?.Operators.Equal(e_, g_);
			};
			var ae_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ac_, ad_);
			var af_ = (Claim.ItemComponent @this) =>
			{
				var h_ = @this?.Location;
				var i_ = (h_ == null);
				var j_ = (bool?)i_;

				return context?.Operators.Not(j_);
			};
			var ag_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ae_, af_);
			var ah_ = (Claim.ItemComponent @this) => @this?.Location;
			var ai_ = context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(ag_, ah_);
			var aj_ = (DataType l) => (l as ResourceReference);
			var ak_ = context?.Operators.SelectOrNull<DataType, ResourceReference>(ai_, aj_);
			var al_ = C?.Item;
			var am_ = (al_ as IEnumerable<Claim.ItemComponent>);
			var an_ = (Claim.ItemComponent i) =>
			{
				var k_ = i?.SequenceElement;
				var l_ = (k_ as object);
				var m_ = context?.Operators?.TypeConverter.Convert<Integer>(l_);
				var n_ = FHIRHelpers_4_0_001.ToInteger(m_);
				var o_ = n_;
				var p_ = (int?)1;
				var q_ = p_;

				return context?.Operators.Equal(o_, q_);
			};
			var ao_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(am_, an_);
			var ap_ = (Claim.ItemComponent @this) =>
			{
				var r_ = @this?.Location;
				var s_ = (r_ == null);
				var t_ = (bool?)s_;

				return context?.Operators.Not(t_);
			};
			var aq_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ao_, ap_);
			var ar_ = (Claim.ItemComponent @this) => @this?.Location;
			var as_ = context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(aq_, ar_);
			var at_ = (DataType l) =>
			{
				var v_ = (l as ResourceReference)?.ReferenceElement;
				var w_ = new FhirString[]
				{
					v_,
				};
				var x_ = (FhirString r) =>
				{
					var u_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>((r as object));

					return NCQAFHIRBase_1_0_0.GetId(u_);
				};
				var y_ = context?.Operators.SelectOrNull<FhirString, string>(w_, x_);

				return context?.Operators.SingleOrNull<string>(y_);
			};
			var au_ = context?.Operators.SelectOrNull<DataType, string>(as_, at_);

			return new Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI
			{
				SingleItem = aa_,
				ItemLocation = ak_,
				ItemLocationID = au_,
			};
		};
		var du_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(claim, dt_);
		var dv_ = new Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa
		{
			ItemsLocationReferences = du_,
		};
		var dw_ = new Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa[]
		{
			dv_,
		};
		var dx_ = (Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa ClaimProperties) =>
		{
			var dm_ = context?.DataRetriever.RetrieveByValueSet<Location>(null, null);
			var dn_ = (Location l) =>
			{
				var ay_ = l?.IdElement;
				var az_ = (ay_ as object);
				var ba_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(az_);
				var bb_ = ClaimProperties?.ItemsLocationReferences;
				var bc_ = (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) =>
				{
					var av_ = @this?.ItemLocationID;
					var aw_ = (av_ == null);
					var ax_ = (bool?)aw_;

					return context?.Operators.Not(ax_);
				};
				var bd_ = context?.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(bb_, bc_);
				var be_ = (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this?.ItemLocationID;
				var bf_ = context?.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<string>>(bd_, be_);
				var bg_ = context?.Operators.FlattenList<string>(bf_);

				return context?.Operators.InList<string>(ba_, bg_);
			};
			var do_ = context?.Operators.WhereOrNull<Location>(dm_, dn_);
			var dp_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP
			{
				CorrespondingLocations = do_,
			};
			var dq_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP[]
			{
				dp_,
			};
			var dr_ = (Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP GetLocation) =>
			{
				var dd_ = GetLocation?.CorrespondingLocations;
				var de_ = (Location C) =>
				{
					var bh_ = (C == null);
					var bi_ = (bool?)bh_;

					return context?.Operators.Not(bi_);
				};
				var df_ = context?.Operators.WhereOrNull<Location>(dd_, de_);
				var dg_ = (Location C) =>
				{
					var cq_ = C?.Identifier;
					var cr_ = (cq_ as IEnumerable<Identifier>);
					var cs_ = (Identifier l) =>
					{
						var bj_ = l?.SystemElement;
						var bk_ = bj_?.Value;
						var bl_ = (bk_ as object);
						var bm_ = context?.Operators.Equal(bl_, ("http://hl7.org/fhir/sid/us-npi" as object));
						var bn_ = l?.Type;
						var bo_ = FHIRHelpers_4_0_001.ToConcept(bn_);
						var bp_ = (bo_ as object);
						var bq_ = NCQATerminology_1_0_0.Provider_number();
						var br_ = context?.Operators.ConvertCodeToConcept(bq_);
						var bs_ = (br_ as object);
						var bt_ = context?.Operators.Equivalent(bp_, bs_);
						var bu_ = context?.Operators.And(bm_, bt_);
						var bv_ = l?.ValueElement;
						var bw_ = bv_?.Value;
						var bx_ = (bw_ == null);
						var by_ = (bool?)bx_;
						var bz_ = context?.Operators.Not(by_);

						return context?.Operators.And(bu_, bz_);
					};
					var ct_ = context?.Operators.WhereOrNull<Identifier>(cr_, cs_);
					var cu_ = (Identifier l) => l?.ValueElement;
					var cv_ = context?.Operators.SelectOrNull<Identifier, FhirString>(ct_, cu_);
					var cw_ = C?.Identifier;
					var cx_ = (cw_ as IEnumerable<Identifier>);
					var cy_ = (Identifier l) =>
					{
						var ca_ = l?.SystemElement;
						var cb_ = ca_?.Value;
						var cc_ = (cb_ as object);
						var cd_ = context?.Operators.Equal(cc_, ("http://hl7.org/fhir/sid/us-npi" as object));
						var ce_ = l?.Type;
						var cf_ = FHIRHelpers_4_0_001.ToConcept(ce_);
						var cg_ = (cf_ as object);
						var ch_ = NCQATerminology_1_0_0.Provider_number();
						var ci_ = context?.Operators.ConvertCodeToConcept(ch_);
						var cj_ = (ci_ as object);
						var ck_ = context?.Operators.Equivalent(cg_, cj_);
						var cl_ = context?.Operators.And(cd_, ck_);
						var cm_ = l?.ValueElement;
						var cn_ = cm_?.Value;
						var co_ = (cn_ == null);
						var cp_ = (bool?)co_;

						return context?.Operators.And(cl_, cp_);
					};
					var cz_ = context?.Operators.WhereOrNull<Identifier>(cx_, cy_);
					var da_ = (Identifier l) => l;
					var db_ = context?.Operators.SelectOrNull<Identifier, Identifier>(cz_, da_);

					return new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = cv_,
						NullIdentifiers = db_,
					};
				};
				var dh_ = context?.Operators.SelectOrNull<Location, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(df_, dg_);
				var di_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = dh_,
				};
				var dj_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					di_,
				};
				var dk_ = (Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers) =>
				{
					var dc_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => context?.Operators.Not((bool?)(@this?.SingleItem == null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this?.SingleItem))) ?? false))
						? (context?.Operators.Add(context?.Operators.Add(context?.Operators.CountOrNull<ResourceReference>(context?.Operators.WhereOrNull<ResourceReference>(context?.Operators.FlattenList<ResourceReference>(context?.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<ResourceReference>>(context?.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => context?.Operators.Not((bool?)(@this?.ItemLocation == null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this?.ItemLocation)), (ResourceReference X) => (bool?)(X?.ReferenceElement?.Value == null))), context?.Operators.CountOrNull<FhirString>(context?.Operators.SelectOrNull<FhirString, FhirString>(context?.Operators.FlattenList<FhirString>(context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.AllIdentifiers)), (FhirString X) => X))), context?.Operators.CountOrNull<Identifier>(context?.Operators.FlattenList<Identifier>(context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.NullIdentifiers)))))
						: ((int?)0))
;

					return new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = dc_,
					};
				};
				var dl_ = context?.Operators.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dj_, dk_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dl_);
			};
			var ds_ = context?.Operators.SelectOrNull<Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dq_, dr_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ds_);
		};
		var dy_ = context?.Operators.SelectOrNull<Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dw_, dx_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dy_);
	}


}
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
			var d_ = MedicalClaim?.Type;
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var f_ = e_?.codes;
			var g_ = NCQATerminology_1_0_0.Professional();
			var h_ = context.Operators;
			var i_ = h_.ListContains<CqlCode>((f_ as IEnumerable<CqlCode>), g_);
			var k_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var l_ = k_?.codes;
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
			var d_ = PharmacyClaim?.Type;
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var f_ = e_?.codes;
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
			var d_ = MedicalResponse?.Type;
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var f_ = e_?.codes;
			var g_ = NCQATerminology_1_0_0.Professional();
			var h_ = context.Operators;
			var i_ = h_.ListContains<CqlCode>((f_ as IEnumerable<CqlCode>), g_);
			var k_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var l_ = k_?.codes;
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
			var d_ = PharmacyResponse?.Type;
			var e_ = FHIRHelpers_4_0_001.ToConcept(d_);
			var f_ = e_?.codes;
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
			var o_ = p?.code;

			return o_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, b_);
		string e_(CqlCode pos)
		{
			var p_ = pos?.code;

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
			var q_ = ClaimWithPosCode?.MedicalClaim;
			Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA r_(Claim ClaimofInterest)
			{
				var x_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = ClaimofInterest,
					LineItems = (((ClaimofInterest is null))
						? ((null as IEnumerable<Claim.ItemComponent>))
						: (context.Operators.WhereOrNull<Claim.ItemComponent>((ClaimofInterest?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ItemOnLine) => context.Operators.And(context.Operators.ExistsInList<CqlCode>(context.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService)?.codes as IEnumerable<CqlCode>), (CqlCode LineCode) => context.Operators.InList<string>(LineCode?.code, ClaimWithPosCode?.ProceduresAsStrings))), context.Operators.ExistsInList<CqlCode>(context.Operators.WhereOrNull<CqlCode>(((FHIRHelpers_4_0_001.ToConcept((ItemOnLine?.Location as CodeableConcept)))?.codes as IEnumerable<CqlCode>), (CqlCode PosCode) => context.Operators.InList<string>(PosCode?.code, ClaimWithPosCode?.POSAsString))))))),
				};
				var y_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					x_,
				};
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA z_(Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition) => (((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
					? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
						{
							Claim = LineItemDefinition?.Claim,
							ServicePeriod = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, (Claim.ItemComponent @this) => context.Operators.Not((bool?)(@this?.Serviced is null))), (Claim.ItemComponent @this) => @this?.Serviced), (DataType NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
						})
					: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)));
				var aa_ = context.Operators;
				var ab_ = aa_.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(y_, z_);
				var ad_ = aa_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ab_);

				return ad_;
			};
			var s_ = context.Operators;
			var t_ = s_.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(q_, r_);
			bool? u_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var ae_ = context.Operators;
				var af_ = ae_.Not((bool?)(FinalList is null));

				return af_;
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
			var l_ = p?.code;

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
			var m_ = ClaimWithProcedure?.MedicalClaim;
			Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA n_(Claim ClaimofInterest)
			{
				var t_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = ClaimofInterest,
					LineItems = (((ClaimofInterest is null))
						? ((null as IEnumerable<Claim.ItemComponent>))
						: (context.Operators.WhereOrNull<Claim.ItemComponent>((ClaimofInterest?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ItemOnLine) => context.Operators.Or(context.Operators.ExistsInList<CqlCode>(context.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService)?.codes as IEnumerable<CqlCode>), (CqlCode LineCode) => context.Operators.InList<string>(LineCode?.code, ClaimWithProcedure?.ProceduresAsStrings))), context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.SelectOrNull<object, Coding>(context.Operators.FlattenLateBoundList(context.Operators.SelectOrNull<DataType, object>(context.Operators.WhereOrNull<DataType>(context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(context.Operators.WhereOrNull<Claim.ProcedureComponent>((ClaimofInterest?.Procedure as IEnumerable<Claim.ProcedureComponent>), (Claim.ProcedureComponent @this) => context.Operators.Not((bool?)(@this?.Procedure is null))), (Claim.ProcedureComponent @this) => @this?.Procedure), (DataType @this) => context.Operators.Not((bool?)(context.Operators.LateBoundProperty<object>(@this, "coding") is null))), (DataType @this) => context.Operators.LateBoundProperty<object>(@this, "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings))))))),
				};
				var u_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					t_,
				};
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA v_(Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj LineItemDefinition) => (((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
					? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
						{
							Claim = LineItemDefinition?.Claim,
							ServicePeriod = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, (Claim.ItemComponent @this) => context.Operators.Not((bool?)(@this?.Serviced is null))), (Claim.ItemComponent @this) => @this?.Serviced), (DataType NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
						})
					: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)));
				var w_ = context.Operators;
				var x_ = w_.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(u_, v_);
				var z_ = w_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(x_);

				return z_;
			};
			var o_ = context.Operators;
			var p_ = o_.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(m_, n_);
			bool? q_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
			{
				var aa_ = context.Operators;
				var ab_ = aa_.Not((bool?)(FinalList is null));

				return ab_;
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
			var l_ = d?.code;

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
				DiagnosisItems = (((ClaimWithDiagnosis?.MedicalClaim is null))
					? ((null as IEnumerable<Claim>))
					: (context.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, (Claim DiagnosisLine) => context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.SelectOrNull<object, Coding>(context.Operators.FlattenLateBoundList(context.Operators.SelectOrNull<DataType, object>(context.Operators.WhereOrNull<DataType>(context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(context.Operators.WhereOrNull<Claim.DiagnosisComponent>((DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent @this) => context.Operators.Not((bool?)(@this?.Diagnosis is null))), (Claim.DiagnosisComponent @this) => @this?.Diagnosis), (DataType @this) => context.Operators.Not((bool?)(context.Operators.LateBoundProperty<object>(@this, "coding") is null))), (DataType @this) => context.Operators.LateBoundProperty<object>(@this, "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings)))))),
			};
			var n_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				m_,
			};
			Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI o_(Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg HeaderDefinition)
			{
				var t_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI[]
				{
(((context.Operators.ExistsInList<Claim>(HeaderDefinition?.DiagnosisItems) ?? false))
						? (new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
							{
								Claim = HeaderDefinition?.DiagnosisItems,
								ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(context.Operators.WhereOrNull<Claim>(HeaderDefinition?.DiagnosisItems, (Claim @this) => context.Operators.Not((bool?)(@this?.Item is null))), (Claim @this) => @this?.Item)), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced)),
							})
						: ((null as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI))),
				};
				bool? u_(Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList)
				{
					var z_ = context.Operators;
					var aa_ = z_.Not((bool?)(FinalList is null));

					return aa_;
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
			var l_ = p?.code;

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
			var m_ = ClaimWithMedication?.PharmacyClaim;
			Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC n_(Claim Pharmacy)
			{
				var t_ = Pharmacy?.Item;
				bool? u_(Claim.ItemComponent ItemOnLine)
				{
					var ae_ = ItemOnLine?.ProductOrService;
					var af_ = FHIRHelpers_4_0_001.ToConcept(ae_);
					var ag_ = af_?.codes;
					bool? ah_(CqlCode LineCode)
					{
						var am_ = LineCode?.code;
						var an_ = ClaimWithMedication?.MedicationsAsStrings;
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
					var aq_ = LineItemDefinition?.Claim;
					var ar_ = new Claim[]
					{
						aq_,
					};
					Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC as_(Claim ClaimLines)
					{
						var ax_ = ClaimLines?.Item;
						bool? ay_(Claim.ItemComponent i)
						{
							var bl_ = i?.ProductOrService;
							var bm_ = FHIRHelpers_4_0_001.ToConcept(bl_);
							var bn_ = bm_?.codes;
							bool? bo_(CqlCode LineCode)
							{
								var bt_ = LineCode?.code;
								var bu_ = ClaimWithMedication?.MedicationsAsStrings;
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
								DaysSupplyInterval = (((context.Operators.Not((bool?)(i?.Quantity is null)) ?? false))
									? (((((i?.Serviced is Period as bool?) ?? false))
											? (context.Operators.Interval(context.Operators.Start(NCQAFHIRBase_1_0_0.Normalize_Interval(i?.Serviced)), context.Operators.Subtract(context.Operators.Add(context.Operators.Start(NCQAFHIRBase_1_0_0.Normalize_Interval(i?.Serviced)), new CqlQuantity
															{
																value = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement),
																unit = "day",
															}), context.Operators.Quantity(1m, "day")), true, true))
											: (context.Operators.Interval(context.Operators.ConvertDateToDateTime((context.Operators.Interval(FHIRHelpers_4_0_001.ToDate((i?.Serviced as Date)), context.Operators.Subtract(context.Operators.Add(FHIRHelpers_4_0_001.ToDate((i?.Serviced as Date)), new CqlQuantity
			{
				value = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement),
				unit = "day",
			}), context.Operators.Quantity(1m, "day")), true, true))?.low), context.Operators.ConvertDateToDateTime((context.Operators.Interval(FHIRHelpers_4_0_001.ToDate((i?.Serviced as Date)), context.Operators.Subtract(context.Operators.Add(FHIRHelpers_4_0_001.ToDate((i?.Serviced as Date)), new CqlQuantity
			{
				value = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement),
				unit = "day",
			}), context.Operators.Quantity(1m, "day")), true, true))?.high), (context.Operators.Interval(FHIRHelpers_4_0_001.ToDate((i?.Serviced as Date)), context.Operators.Subtract(context.Operators.Add(FHIRHelpers_4_0_001.ToDate((i?.Serviced as Date)), new CqlQuantity
			{
				value = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement),
				unit = "day",
			}), context.Operators.Quantity(1m, "day")), true, true))?.lowClosed, (context.Operators.Interval(FHIRHelpers_4_0_001.ToDate((i?.Serviced as Date)), context.Operators.Subtract(context.Operators.Add(FHIRHelpers_4_0_001.ToDate((i?.Serviced as Date)), new CqlQuantity
			{
				value = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement),
				unit = "day",
			}), context.Operators.Quantity(1m, "day")), true, true))?.highClosed))))
									: ((null as CqlInterval<CqlDateTime>))),
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
						Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC bg_(Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU ItemCalculation) => (((context.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
							? (new Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC
								{
									Claim = LineItemDefinition?.Claim,
									LineItem = LineItemDefinition?.LineItems,
									ServicePeriod = context.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, (Claim.ItemComponent @this) => context.Operators.Not((bool?)(@this?.Serviced is null))), (Claim.ItemComponent @this) => @this?.Serviced), (DataType NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
									CoveredDays = context.Operators.SelectOrNull<Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP, CqlInterval<CqlDateTime>>(ItemCalculation?.CoveredDays, (Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP d) => d?.DaysSupplyInterval),
								})
							: ((null as Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC)));
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
				var by_ = context.Operators;
				var bz_ = by_.Not((bool?)(FinalList is null));

				return bz_;
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
			var o_ = d?.code;

			return o_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		string e_(CqlCode p)
		{
			var p_ = p?.code;

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
				DiagnosisItems = (((ClaimWithDiagnosis?.MedicalClaim is null))
					? ((null as IEnumerable<Claim>))
					: (context.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, (Claim DiagnosisLine) => context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.SelectOrNull<object, Coding>(context.Operators.FlattenLateBoundList(context.Operators.SelectOrNull<DataType, object>(context.Operators.WhereOrNull<DataType>(context.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(context.Operators.WhereOrNull<Claim.DiagnosisComponent>((DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent @this) => context.Operators.Not((bool?)(@this?.Diagnosis is null))), (Claim.DiagnosisComponent @this) => @this?.Diagnosis), (DataType @this) => context.Operators.Not((bool?)(context.Operators.LateBoundProperty<object>(@this, "coding") is null))), (DataType @this) => context.Operators.LateBoundProperty<object>(@this, "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings)))))),
			};
			var r_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				q_,
			};
			IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> s_(Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg ClaimWithProcedure)
			{
				var x_ = ClaimWithProcedure?.DiagnosisItems;
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA y_(Claim ClaimofInterest)
				{
					var ae_ = new Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU
					{
						ProcedureItems = (((ClaimofInterest is null))
							? (null)
							: (context.Operators.SingleOrNull<Claim>(context.Operators.WhereOrNull<Claim>(new Claim[]
										{
											ClaimofInterest,
										}, (Claim ItemOnLine) => context.Operators.Or(context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.SelectOrNull<object, Coding>(context.Operators.FlattenLateBoundList(context.Operators.SelectOrNull<DataType, object>(context.Operators.WhereOrNull<DataType>(context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(context.Operators.WhereOrNull<Claim.ProcedureComponent>((ItemOnLine?.Procedure as IEnumerable<Claim.ProcedureComponent>), (Claim.ProcedureComponent @this) => context.Operators.Not((bool?)(@this?.Procedure is null))), (Claim.ProcedureComponent @this) => @this?.Procedure), (DataType @this) => context.Operators.Not((bool?)(context.Operators.LateBoundProperty<object>(@this, "coding") is null))), (DataType @this) => context.Operators.LateBoundProperty<object>(@this, "coding"))), (object @object) => (@object as Coding)), (Coding ProcedureHeaderCode) => context.Operators.InList<string>(ProcedureHeaderCode?.CodeElement?.Value, ClaimWithDiagnosis?.ProceduresAsStrings))), context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.FlattenList<Coding>(context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(context.Operators.WhereOrNull<CodeableConcept>(context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(context.Operators.WhereOrNull<Claim.ItemComponent>((ItemOnLine?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent @this) => context.Operators.Not((bool?)(@this?.ProductOrService is null))), (Claim.ItemComponent @this) => @this?.ProductOrService), (CodeableConcept @this) => context.Operators.Not((bool?)(@this?.Coding is null))), (CodeableConcept @this) => @this?.Coding)), (Coding LineCode) => context.Operators.InList<string>(LineCode?.CodeElement?.Value, ClaimWithDiagnosis?.ProceduresAsStrings)))))))),
					};
					var af_ = new Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU[]
					{
						ae_,
					};
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ag_(Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU HeaderDefinition) => (((context.Operators.Not((bool?)(HeaderDefinition?.ProcedureItems is null)) ?? false))
						? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = HeaderDefinition?.ProcedureItems,
								ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((HeaderDefinition?.ProcedureItems?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced)),
							})
						: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)));
					var ah_ = context.Operators;
					var ai_ = ah_.SelectOrNull<Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(af_, ag_);
					var ak_ = ah_.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ai_);

					return ak_;
				};
				var z_ = context.Operators;
				var aa_ = z_.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(x_, y_);
				bool? ab_(Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA FinalList)
				{
					var al_ = context.Operators;
					var am_ = al_.Not((bool?)(FinalList is null));

					return am_;
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
			var o_ = d?.code;

			return o_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<CqlCode, string>(DiagnosisValueSet, b_);
		string e_(CqlCode p)
		{
			var p_ = p?.code;

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
			var q_ = ClaimWithProcedure?.MedicalClaim;
			Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA r_(Claim ClaimofInterest)
			{
				var x_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB
				{
					Claim = ClaimofInterest,
					ProcedureItems = (((ClaimofInterest is null))
						? (null)
						: (context.Operators.SingleOrNull<Claim>(context.Operators.WhereOrNull<Claim>(new Claim[]
									{
										ClaimofInterest,
									}, (Claim ItemOnLine) => context.Operators.Or(context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.FlattenList<Coding>(context.Operators.SelectOrNull<CodeableConcept, List<Coding>>(context.Operators.WhereOrNull<CodeableConcept>(context.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(context.Operators.WhereOrNull<Claim.ItemComponent>((ItemOnLine?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent @this) => context.Operators.Not((bool?)(@this?.ProductOrService is null))), (Claim.ItemComponent @this) => @this?.ProductOrService), (CodeableConcept @this) => context.Operators.Not((bool?)(@this?.Coding is null))), (CodeableConcept @this) => @this?.Coding)), (Coding LineCode) => context.Operators.InList<string>(LineCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings))), context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.SelectOrNull<object, Coding>(context.Operators.FlattenLateBoundList(context.Operators.SelectOrNull<DataType, object>(context.Operators.WhereOrNull<DataType>(context.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(context.Operators.WhereOrNull<Claim.ProcedureComponent>((ItemOnLine?.Procedure as IEnumerable<Claim.ProcedureComponent>), (Claim.ProcedureComponent @this) => context.Operators.Not((bool?)(@this?.Procedure is null))), (Claim.ProcedureComponent @this) => @this?.Procedure), (DataType @this) => context.Operators.Not((bool?)(context.Operators.LateBoundProperty<object>(@this, "coding") is null))), (DataType @this) => context.Operators.LateBoundProperty<object>(@this, "coding"))), (object @object) => (@object as Coding)), (Coding HeaderCode) => context.Operators.InList<string>(HeaderCode?.CodeElement?.Value, ClaimWithProcedure?.ProceduresAsStrings)))))))),
				};
				var y_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB[]
				{
					x_,
				};
				Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA z_(Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB DiagnosisCheck)
				{
					var ae_ = DiagnosisCheck?.ProcedureItems;
					var af_ = new Claim[]
					{
						ae_,
					};
					Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ag_(Claim ClaimforDiagnosis)
					{
						var al_ = ClaimforDiagnosis?.Item;
						var am_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI
						{
							Procedure = (al_ as IEnumerable<Claim.ItemComponent>),
							LineItems = (((ClaimforDiagnosis is null))
								? (null)
								: (context.Operators.SingleOrNull<Claim>(context.Operators.WhereOrNull<Claim>(new Claim[]
											{
												ClaimforDiagnosis,
											}, (Claim RightClaim) => context.Operators.ExistsInList<Claim.DiagnosisComponent>(context.Operators.WhereOrNull<Claim.DiagnosisComponent>((RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent RightDiagnosis) => context.Operators.And(context.Operators.Equal(FHIRHelpers_4_0_001.ToInteger(context.Operators.TypeConverter.Convert<Integer>(RightDiagnosis?.SequenceElement)), (int?)1), context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.LateBoundProperty<IEnumerable<Coding>>(RightDiagnosis?.Diagnosis, "coding"), (Coding DiagnosisCode) => context.Operators.InList<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithProcedure?.DiagnosesAsStrings)))))))))),
						};
						var an_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI[]
						{
							am_,
						};
						Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA ao_(Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI LineItemDefinition) => (((context.Operators.And(context.Operators.Not((bool?)(LineItemDefinition is null)), context.Operators.Not((bool?)(LineItemDefinition?.LineItems is null))) ?? false))
							? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
								{
									Claim = LineItemDefinition?.LineItems,
									ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((LineItemDefinition?.LineItems?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced)),
								})
							: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)));
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
				var at_ = context.Operators;
				var au_ = at_.Not((bool?)(FinalList is null));

				return au_;
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
			var l_ = d?.code;

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
				LineItems = (((ClaimWithDiagnosis?.MedicalClaim is null))
					? ((null as IEnumerable<Claim>))
					: (context.Operators.WhereOrNull<Claim>(ClaimWithDiagnosis?.MedicalClaim, (Claim RightClaim) => context.Operators.ExistsInList<Claim.DiagnosisComponent>(context.Operators.WhereOrNull<Claim.DiagnosisComponent>((RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>), (Claim.DiagnosisComponent RightDiagnosis) => context.Operators.And(context.Operators.Equal(FHIRHelpers_4_0_001.ToInteger(context.Operators.TypeConverter.Convert<Integer>(RightDiagnosis?.SequenceElement)), (int?)1), context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>(context.Operators.LateBoundProperty<IEnumerable<Coding>>(RightDiagnosis?.Diagnosis, "coding"), (Coding DiagnosisCode) => context.Operators.InList<string>(DiagnosisCode?.CodeElement?.Value, ClaimWithDiagnosis?.DiagnosesAsStrings))))))))),
			};
			var n_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN[]
			{
				m_,
			};
			IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> o_(Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN LineItemDefinition)
			{
				var t_ = LineItemDefinition?.LineItems;
				Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI u_(Claim ClaimWithDiagnosis) => (((context.Operators.Not((bool?)(ClaimWithDiagnosis is null)) ?? false))
					? (new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = LineItemDefinition?.LineItems,
							ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(context.Operators.WhereOrNull<Claim>(LineItemDefinition?.LineItems, (Claim @this) => context.Operators.Not((bool?)(@this?.Item is null))), (Claim @this) => @this?.Item)), (Claim.ItemComponent NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate?.Serviced)),
						})
					: ((null as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI)));
				var v_ = context.Operators;
				var w_ = v_.SelectOrNull<Claim, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(t_, u_);
				bool? x_(Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI FinalList)
				{
					var aa_ = context.Operators;
					var ab_ = aa_.Not((bool?)(FinalList is null));

					return ab_;
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
			var k_ = ResponseItem?.OutcomeElement;
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
			var t_ = ClaimResponse?.PaidResponse;
			Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL u_(ClaimResponse ClmResp)
			{
				var x_ = ClmResp?.Request;
				var y_ = x_?.ReferenceElement;
				var z_ = new CallStackEntry("ToString", null, null);
				var aa_ = context.Deeper(z_);
				var ab_ = aa_.Operators;
				var ac_ = ab_.TypeConverter;
				var ad_ = ac_.Convert<string>(y_);
				var ae_ = NCQAFHIRBase_1_0_0.GetId(ad_);
				var af_ = ClmResp?.Item;
				bool? ag_(ClaimResponse.ItemComponent ResponseItem)
				{
					var ak_ = ResponseItem?.Adjudication;
					bool? al_(ClaimResponse.AdjudicationComponent @this)
					{
						var bs_ = @this?.Category;
						var bt_ = context.Operators;
						var bu_ = bt_.Not((bool?)(bs_ is null));

						return bu_;
					};
					var am_ = context.Operators;
					var an_ = am_.WhereOrNull<ClaimResponse.AdjudicationComponent>(ak_, al_);
					CodeableConcept ao_(ClaimResponse.AdjudicationComponent @this)
					{
						var bv_ = @this?.Category;

						return bv_;
					};
					var aq_ = am_.SelectOrNull<ClaimResponse.AdjudicationComponent, CodeableConcept>(an_, ao_);
					bool? ar_(CodeableConcept @this)
					{
						var bw_ = @this?.Coding;
						var bx_ = context.Operators;
						var by_ = bx_.Not((bool?)(bw_ is null));

						return by_;
					};
					var at_ = am_.WhereOrNull<CodeableConcept>(aq_, ar_);
					List<Coding> au_(CodeableConcept @this)
					{
						var bz_ = @this?.Coding;

						return bz_;
					};
					var aw_ = am_.SelectOrNull<CodeableConcept, List<Coding>>(at_, au_);
					var ay_ = am_.FlattenList<Coding>(aw_);
					bool? az_(Coding CategoryItem)
					{
						var ca_ = CategoryItem?.CodeElement;
						var cb_ = ca_?.Value;
						var cc_ = context.Operators;
						var cd_ = cc_.Equal(cb_, "benefit");

						return cd_;
					};
					var bb_ = am_.WhereOrNull<Coding>(ay_, az_);
					var bd_ = am_.ExistsInList<Coding>(bb_);
					bool? bf_(ClaimResponse.AdjudicationComponent @this)
					{
						var ce_ = @this?.Amount;
						var cf_ = context.Operators;
						var cg_ = cf_.Not((bool?)(ce_ is null));

						return cg_;
					};
					var bh_ = am_.WhereOrNull<ClaimResponse.AdjudicationComponent>(ak_, bf_);
					Money bi_(ClaimResponse.AdjudicationComponent @this)
					{
						var ch_ = @this?.Amount;

						return ch_;
					};
					var bk_ = am_.SelectOrNull<ClaimResponse.AdjudicationComponent, Money>(bh_, bi_);
					bool? bl_(Money DollarAmount)
					{
						var ci_ = DollarAmount?.ValueElement;
						var cj_ = FHIRHelpers_4_0_001.ToDecimal(ci_);
						var ck_ = context.Operators;
						var cl_ = ck_.ConvertIntegerToDecimal((int?)0);
						var cn_ = ck_.Greater(cj_, cl_);

						return cn_;
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
			var g_ = AllClaims?.Item;
			bool? h_(Claim.ItemComponent @this)
			{
				var az_ = @this?.ProductOrService;
				var ba_ = context.Operators;
				var bb_ = ba_.Not((bool?)(az_ is null));

				return bb_;
			};
			var i_ = context.Operators;
			var j_ = i_.WhereOrNull<Claim.ItemComponent>(g_, h_);
			CodeableConcept k_(Claim.ItemComponent @this)
			{
				var bc_ = @this?.ProductOrService;

				return bc_;
			};
			var m_ = i_.SelectOrNull<Claim.ItemComponent, CodeableConcept>(j_, k_);
			bool? n_(CodeableConcept @this)
			{
				var bd_ = @this?.Coding;
				var be_ = context.Operators;
				var bf_ = be_.Not((bool?)(bd_ is null));

				return bf_;
			};
			var p_ = i_.WhereOrNull<CodeableConcept>(m_, n_);
			List<Coding> q_(CodeableConcept @this)
			{
				var bg_ = @this?.Coding;

				return bg_;
			};
			var s_ = i_.SelectOrNull<CodeableConcept, List<Coding>>(p_, q_);
			var u_ = i_.FlattenList<Coding>(s_);
			bool? v_(Coding ProductOrServiceCode)
			{
				var bh_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var bi_ = context.Operators;
				var bj_ = bi_.CodeInList(bh_, ProductOrServiceValueSet);

				return bj_;
			};
			var x_ = i_.WhereOrNull<Coding>(u_, v_);
			var z_ = i_.ExistsInList<Coding>(x_);
			var aa_ = AllClaims?.Diagnosis;
			bool? ab_(Claim.DiagnosisComponent @this)
			{
				var bk_ = @this?.Diagnosis;
				var bl_ = context.Operators;
				var bm_ = bl_.Not((bool?)(bk_ is null));

				return bm_;
			};
			var ad_ = i_.WhereOrNull<Claim.DiagnosisComponent>((aa_ as IEnumerable<Claim.DiagnosisComponent>), ab_);
			DataType ae_(Claim.DiagnosisComponent @this)
			{
				var bn_ = @this?.Diagnosis;

				return bn_;
			};
			var ag_ = i_.SelectOrNull<Claim.DiagnosisComponent, DataType>(ad_, ae_);
			bool? ah_(DataType @this)
			{
				var bo_ = context.Operators;
				var bp_ = bo_.LateBoundProperty<object>(@this, "coding");
				var br_ = bo_.Not((bool?)(bp_ is null));

				return br_;
			};
			var aj_ = i_.WhereOrNull<DataType>(ag_, ah_);
			object ak_(DataType @this)
			{
				var bs_ = context.Operators;
				var bt_ = bs_.LateBoundProperty<object>(@this, "coding");

				return bt_;
			};
			var am_ = i_.SelectOrNull<DataType, object>(aj_, ak_);
			var ao_ = i_.FlattenLateBoundList(am_);
			Coding ap_(object @object) => (@object as Coding);
			var ar_ = i_.SelectOrNull<object, Coding>(ao_, ap_);
			bool? as_(Coding DiagnosisCode)
			{
				var bu_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
				var bv_ = context.Operators;
				var bw_ = bv_.CodeInList(bu_, DiagnosisValueSet);

				return bw_;
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
			var bx_ = ProcedureClaims?.IdElement;
			var by_ = ProcedureClaims?.Item;
			bool? bz_(Claim.ItemComponent ResponseItem)
			{
				var cd_ = ResponseItem?.ProductOrService;
				var ce_ = cd_?.Coding;
				bool? cf_(Coding ProductOrServiceCode)
				{
					var ck_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var cl_ = context.Operators;
					var cm_ = cl_.CodeInList(ck_, ProductOrServiceValueSet);

					return cm_;
				};
				var cg_ = context.Operators;
				var ch_ = cg_.WhereOrNull<Coding>((ce_ as IEnumerable<Coding>), cf_);
				var cj_ = cg_.ExistsInList<Coding>(ch_);

				return cj_;
			};
			var ca_ = context.Operators;
			var cb_ = ca_.WhereOrNull<Claim.ItemComponent>((by_ as IEnumerable<Claim.ItemComponent>), bz_);
			var cc_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = ProcedureClaims,
				ClaimID = bx_,
				LineItems = cb_,
			};

			return cc_;
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
			var j_ = ClaimAndResponse?.MedicalClaim;
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg k_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				var u_ = medClaim?.LineItems;
				bool? v_(Claim.ItemComponent medClaimLineItem)
				{
					var z_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> aa_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var af_ = pClaim?.LineItems;
						bool? ag_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var am_ = new CallStackEntry("ToString", null, null);
							var an_ = context.Deeper(am_);
							var ao_ = an_.Operators;
							var ap_ = ao_.TypeConverter;
							var aq_ = ap_.Convert<string>(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: (null)));
							var ar_ = pClaim?.Response;
							var as_ = ar_?.Request;
							var at_ = as_?.ReferenceElement;
							var av_ = context.Deeper(am_);
							var aw_ = av_.Operators;
							var ax_ = aw_.TypeConverter;
							var ay_ = ax_.Convert<string>(at_);
							var az_ = NCQAFHIRBase_1_0_0.GetId(ay_);
							var ba_ = context.Operators;
							var bb_ = ba_.Equal(aq_, az_);
							var bc_ = medClaimLineItem?.SequenceElement;
							var be_ = ba_.TypeConverter;
							var bf_ = be_.Convert<Integer>(bc_);
							var bg_ = pClaimLineItem?.ItemSequenceElement;
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
(((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem))) ?? false))
						? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
							{
								originalClaim = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this?.PaidClaim is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.PaidClaim),
								ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced)),
							})
						: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))),
				};
				bool? bp_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bu_ = context.Operators;
					var bv_ = bu_.Not((bool?)(FinalList is null));

					return bv_;
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
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO c_(Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse) => (((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
			? ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))
			: (this.Get_Corresponding_Claim_for_Services_and_Conditions(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet)));
		var d_ = context.Operators;
		var e_ = d_.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(b_, c_);
		var g_ = d_.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(e_);
		var h_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
		{
			g_,
		};
		bool? i_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
		{
			var n_ = context.Operators;
			var o_ = n_.Not((bool?)(FinalList is null));

			return o_;
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
			var g_ = AllClaims?.Item;
			bool? h_(Claim.ItemComponent @this)
			{
				var az_ = @this?.ProductOrService;
				var ba_ = context.Operators;
				var bb_ = ba_.Not((bool?)(az_ is null));

				return bb_;
			};
			var i_ = context.Operators;
			var j_ = i_.WhereOrNull<Claim.ItemComponent>(g_, h_);
			CodeableConcept k_(Claim.ItemComponent @this)
			{
				var bc_ = @this?.ProductOrService;

				return bc_;
			};
			var m_ = i_.SelectOrNull<Claim.ItemComponent, CodeableConcept>(j_, k_);
			bool? n_(CodeableConcept @this)
			{
				var bd_ = @this?.Coding;
				var be_ = context.Operators;
				var bf_ = be_.Not((bool?)(bd_ is null));

				return bf_;
			};
			var p_ = i_.WhereOrNull<CodeableConcept>(m_, n_);
			List<Coding> q_(CodeableConcept @this)
			{
				var bg_ = @this?.Coding;

				return bg_;
			};
			var s_ = i_.SelectOrNull<CodeableConcept, List<Coding>>(p_, q_);
			var u_ = i_.FlattenList<Coding>(s_);
			bool? v_(Coding ProductOrServiceCode)
			{
				var bh_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var bi_ = context.Operators;
				var bj_ = bi_.CodeInList(bh_, ProductOrServiceValueSet);

				return bj_;
			};
			var x_ = i_.WhereOrNull<Coding>(u_, v_);
			var z_ = i_.ExistsInList<Coding>(x_);
			var aa_ = AllClaims?.Diagnosis;
			bool? ab_(Claim.DiagnosisComponent @this)
			{
				var bk_ = @this?.Diagnosis;
				var bl_ = context.Operators;
				var bm_ = bl_.Not((bool?)(bk_ is null));

				return bm_;
			};
			var ad_ = i_.WhereOrNull<Claim.DiagnosisComponent>((aa_ as IEnumerable<Claim.DiagnosisComponent>), ab_);
			DataType ae_(Claim.DiagnosisComponent @this)
			{
				var bn_ = @this?.Diagnosis;

				return bn_;
			};
			var ag_ = i_.SelectOrNull<Claim.DiagnosisComponent, DataType>(ad_, ae_);
			bool? ah_(DataType @this)
			{
				var bo_ = context.Operators;
				var bp_ = bo_.LateBoundProperty<object>(@this, "coding");
				var br_ = bo_.Not((bool?)(bp_ is null));

				return br_;
			};
			var aj_ = i_.WhereOrNull<DataType>(ag_, ah_);
			object ak_(DataType @this)
			{
				var bs_ = context.Operators;
				var bt_ = bs_.LateBoundProperty<object>(@this, "coding");

				return bt_;
			};
			var am_ = i_.SelectOrNull<DataType, object>(aj_, ak_);
			var ao_ = i_.FlattenLateBoundList(am_);
			Coding ap_(object @object) => (@object as Coding);
			var ar_ = i_.SelectOrNull<object, Coding>(ao_, ap_);
			bool? as_(Coding DiagnosisCode)
			{
				var bu_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
				var bv_ = context.Operators;
				var bw_ = bv_.CodeInList(bu_, DiagnosisValueSet);

				return bw_;
			};
			var au_ = i_.WhereOrNull<Coding>(ar_, as_);
			var aw_ = i_.ExistsInList<Coding>(au_);
			var ay_ = i_.Or(z_, aw_);

			return ay_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Claim>(claim, a_);
		Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM d_(Claim ProcedureClaims) => (((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), (Coding ProductOrServiceCode) => context.Operators.CodeInList(FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode), ProductOrServiceValueSet))))) ?? false))
			? (new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
				{
					ClaimofInterest = ProcedureClaims,
					ClaimID = ProcedureClaims?.IdElement,
					LineItems = context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), (Coding ProductOrServiceCode) => context.Operators.CodeInList(FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode), ProductOrServiceValueSet)))),
				})
			: (new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
				{
					ClaimofInterest = ProcedureClaims,
					ClaimID = ProcedureClaims?.IdElement,
					LineItems = context.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent ResponseItem) => context.Operators.Equal(context.Operators.TypeConverter.Convert<Integer>(ResponseItem?.SequenceElement)?.Value, (int?)1)),
				}));
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
			var j_ = ClaimAndResponse?.MedicalClaim;
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg k_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				var u_ = medClaim?.LineItems;
				bool? v_(Claim.ItemComponent medClaimLineItem)
				{
					var z_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> aa_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var af_ = pClaim?.LineItems;
						bool? ag_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var am_ = new CallStackEntry("ToString", null, null);
							var an_ = context.Deeper(am_);
							var ao_ = an_.Operators;
							var ap_ = ao_.TypeConverter;
							var aq_ = ap_.Convert<string>(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: (null)));
							var ar_ = pClaim?.Response;
							var as_ = ar_?.Request;
							var at_ = as_?.ReferenceElement;
							var av_ = context.Deeper(am_);
							var aw_ = av_.Operators;
							var ax_ = aw_.TypeConverter;
							var ay_ = ax_.Convert<string>(at_);
							var az_ = NCQAFHIRBase_1_0_0.GetId(ay_);
							var ba_ = context.Operators;
							var bb_ = ba_.Equal(aq_, az_);
							var bc_ = medClaimLineItem?.SequenceElement;
							var be_ = ba_.TypeConverter;
							var bf_ = be_.Convert<Integer>(bc_);
							var bg_ = pClaimLineItem?.ItemSequenceElement;
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
(((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem))) ?? false))
						? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
							{
								originalClaim = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this?.PaidClaim is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.PaidClaim),
								ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced)),
							})
						: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))),
				};
				bool? bp_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bu_ = context.Operators;
					var bv_ = bu_.Not((bool?)(FinalList is null));

					return bv_;
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
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO c_(Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse) => (((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
			? ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))
			: (this.Get_Corresponding_Claim_for_Services_or_Conditions(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet, DiagnosisValueSet)));
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
			var g_ = AllClaims?.Item;
			bool? h_(Claim.ItemComponent @this)
			{
				var aa_ = @this?.ProductOrService;
				var ab_ = context.Operators;
				var ac_ = ab_.Not((bool?)(aa_ is null));

				return ac_;
			};
			var i_ = context.Operators;
			var j_ = i_.WhereOrNull<Claim.ItemComponent>(g_, h_);
			CodeableConcept k_(Claim.ItemComponent @this)
			{
				var ad_ = @this?.ProductOrService;

				return ad_;
			};
			var m_ = i_.SelectOrNull<Claim.ItemComponent, CodeableConcept>(j_, k_);
			bool? n_(CodeableConcept @this)
			{
				var ae_ = @this?.Coding;
				var af_ = context.Operators;
				var ag_ = af_.Not((bool?)(ae_ is null));

				return ag_;
			};
			var p_ = i_.WhereOrNull<CodeableConcept>(m_, n_);
			List<Coding> q_(CodeableConcept @this)
			{
				var ah_ = @this?.Coding;

				return ah_;
			};
			var s_ = i_.SelectOrNull<CodeableConcept, List<Coding>>(p_, q_);
			var u_ = i_.FlattenList<Coding>(s_);
			bool? v_(Coding ProductOrServiceCode)
			{
				var ai_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
				var aj_ = context.Operators;
				var ak_ = aj_.CodeInList(ai_, ProductOrServiceValueSet);

				return ak_;
			};
			var x_ = i_.WhereOrNull<Coding>(u_, v_);
			var z_ = i_.ExistsInList<Coding>(x_);

			return z_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Claim>(claim, a_);
		Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM d_(Claim AllClaims)
		{
			var al_ = AllClaims?.IdElement;
			var am_ = AllClaims?.Item;
			bool? an_(Claim.ItemComponent ResponseItem)
			{
				var ar_ = ResponseItem?.ProductOrService;
				var as_ = ar_?.Coding;
				bool? at_(Coding ProductOrServiceCode)
				{
					var ay_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
					var az_ = context.Operators;
					var ba_ = az_.CodeInList(ay_, ProductOrServiceValueSet);

					return ba_;
				};
				var au_ = context.Operators;
				var av_ = au_.WhereOrNull<Coding>((as_ as IEnumerable<Coding>), at_);
				var ax_ = au_.ExistsInList<Coding>(av_);

				return ax_;
			};
			var ao_ = context.Operators;
			var ap_ = ao_.WhereOrNull<Claim.ItemComponent>((am_ as IEnumerable<Claim.ItemComponent>), an_);
			var aq_ = new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = AllClaims,
				ClaimID = al_,
				LineItems = ap_,
			};

			return aq_;
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
			var j_ = ClaimAndResponse?.MedicalClaim;
			Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg k_(Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM medClaim)
			{
				var u_ = medClaim?.LineItems;
				bool? v_(Claim.ItemComponent medClaimLineItem)
				{
					var z_ = ClaimAndResponse?.PaidMedicalClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> aa_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var af_ = pClaim?.LineItems;
						bool? ag_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var am_ = new CallStackEntry("ToString", null, null);
							var an_ = context.Deeper(am_);
							var ao_ = an_.Operators;
							var ap_ = ao_.TypeConverter;
							var aq_ = ap_.Convert<string>(((medClaim?.ClaimofInterest is Resource)
									? ((medClaim?.ClaimofInterest as Resource).IdElement)
									: (null)));
							var ar_ = pClaim?.Response;
							var as_ = ar_?.Request;
							var at_ = as_?.ReferenceElement;
							var av_ = context.Deeper(am_);
							var aw_ = av_.Operators;
							var ax_ = aw_.TypeConverter;
							var ay_ = ax_.Convert<string>(at_);
							var az_ = NCQAFHIRBase_1_0_0.GetId(ay_);
							var ba_ = context.Operators;
							var bb_ = ba_.Equal(aq_, az_);
							var bc_ = medClaimLineItem?.SequenceElement;
							var be_ = ba_.TypeConverter;
							var bf_ = be_.Convert<Integer>(bc_);
							var bg_ = pClaimLineItem?.ItemSequenceElement;
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
(((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem))) ?? false))
						? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
							{
								originalClaim = context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this?.PaidClaim is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.PaidClaim),
								ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg @this) => @this?.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced)),
							})
						: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))),
				};
				bool? bp_(Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO FinalList)
				{
					var bu_ = context.Operators;
					var bv_ = bu_.Not((bool?)(FinalList is null));

					return bv_;
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
		Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO c_(Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM MedicalClaimAndResponse) => (((context.Operators.And((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse is null), (bool?)(MedicalClaimAndResponse?.MedicalClaim is null)) ?? false))
			? ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))
			: (this.Get_Corresponding_Claim_for_Services_Only(MedicalClaimAndResponse?.MedicalClaimResponse, MedicalClaimAndResponse?.MedicalClaim, ProductOrServiceValueSet)));
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
			var j_ = ClaimAndResponse?.MedicalClaim;
			Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT k_(Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC medClaim)
			{
				var u_ = medClaim?.LineItem;
				bool? v_(Claim.ItemComponent medClaimLineItem)
				{
					var z_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
					IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> aa_(Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL pClaim)
					{
						var af_ = pClaim?.LineItems;
						bool? ag_(ClaimResponse.ItemComponent pClaimLineItem)
						{
							var am_ = new CallStackEntry("ToString", null, null);
							var an_ = context.Deeper(am_);
							var ao_ = an_.Operators;
							var ap_ = ao_.TypeConverter;
							var aq_ = ap_.Convert<string>(((medClaim?.Claim is Resource)
									? ((medClaim?.Claim as Resource).IdElement)
									: (null)));
							var ar_ = pClaim?.Response;
							var as_ = ar_?.Request;
							var at_ = as_?.ReferenceElement;
							var av_ = context.Deeper(am_);
							var aw_ = av_.Operators;
							var ax_ = aw_.TypeConverter;
							var ay_ = ax_.Convert<string>(at_);
							var az_ = NCQAFHIRBase_1_0_0.GetId(ay_);
							var ba_ = context.Operators;
							var bb_ = ba_.Equal(aq_, az_);
							var bc_ = medClaimLineItem?.SequenceElement;
							var be_ = ba_.TypeConverter;
							var bf_ = be_.Convert<Integer>(bc_);
							var bg_ = pClaimLineItem?.ItemSequenceElement;
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
(((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => @this?.ClaimItem))) ?? false))
						? (new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO
							{
								originalClaim = context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => context.Operators.Not((bool?)(@this?.PaidClaim is null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => @this?.PaidClaim),
								ServicePeriod = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => @this?.ClaimItem)), (Claim.ItemComponent PaidItem) => NCQAFHIRBase_1_0_0.Normalize_Interval(PaidItem?.Serviced)),
								CoveredDays = context.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDate>>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ClaimWithPaidResponse?.AggregateClaim, (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => context.Operators.Not((bool?)(@this?.ClaimItem is null))), (Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT @this) => @this?.ClaimItem)), (Claim.ItemComponent i) => (((context.Operators.Not((bool?)(i?.Quantity is null)) ?? false))
										? (context.Operators.Interval(context.Operators.ConvertDateTimeToDate(context.Operators.Start(NCQAFHIRBase_1_0_0.Normalize_Interval(i?.Serviced))), context.Operators.ConvertDateTimeToDate(context.Operators.Subtract(context.Operators.Add(context.Operators.Start(NCQAFHIRBase_1_0_0.Normalize_Interval(i?.Serviced)), new CqlQuantity
															{
																value = FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement),
																unit = "day",
															}), context.Operators.Quantity(1m, "day"))), true, true))
										: ((null as CqlInterval<CqlDate>)))),
							})
						: ((null as Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO))),
				};
				bool? bp_(Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO FinalList)
				{
					var bu_ = context.Operators;
					var bv_ = bu_.Not((bool?)(FinalList is null));

					return bv_;
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
		Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO c_(Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR PharmacyClaimAndResponse) => (((context.Operators.And((bool?)(PharmacyClaimAndResponse?.PharmacyClaimResponse is null), (bool?)(PharmacyClaimAndResponse?.PharmacyClaim is null)) ?? false))
			? ((null as Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO))
			: (this.Get_Corresponding_Claim_for_Pharmacy_Services(PharmacyClaimAndResponse?.PharmacyClaimResponse, PharmacyClaimAndResponse?.PharmacyClaim, ProductOrServiceValueSet)));
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
				var k_ = Claim?.IdElement;
				var l_ = new CallStackEntry("ToString", null, null);
				var m_ = context.Deeper(l_);
				var n_ = m_.Operators;
				var o_ = n_.TypeConverter;
				var p_ = o_.Convert<string>(k_);
				var q_ = CR?.Request;
				var r_ = q_?.ReferenceElement;
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
				var aa_ = Claim?.IdElement;
				var ab_ = new CallStackEntry("ToString", null, null);
				var ac_ = context.Deeper(ab_);
				var ad_ = ac_.Operators;
				var ae_ = ad_.TypeConverter;
				var af_ = ae_.Convert<string>(aa_);
				bool? ag_(ClaimResponse CR)
				{
					var bf_ = Claim?.IdElement;
					var bg_ = new CallStackEntry("ToString", null, null);
					var bh_ = context.Deeper(bg_);
					var bi_ = bh_.Operators;
					var bj_ = bi_.TypeConverter;
					var bk_ = bj_.Convert<string>(bf_);
					var bl_ = CR?.Request;
					var bm_ = bl_?.ReferenceElement;
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
					var bv_ = @this?.Request;
					var bw_ = context.Operators;
					var bx_ = bw_.Not((bool?)(bv_ is null));

					return bx_;
				};
				var al_ = ah_.WhereOrNull<ClaimResponse>(ai_, aj_);
				ResourceReference am_(ClaimResponse @this)
				{
					var by_ = @this?.Request;

					return by_;
				};
				var ao_ = ah_.SelectOrNull<ClaimResponse, ResourceReference>(al_, am_);
				bool? ap_(ResourceReference @this)
				{
					var bz_ = @this?.ReferenceElement;
					var ca_ = context.Operators;
					var cb_ = ca_.Not((bool?)(bz_ is null));

					return cb_;
				};
				var ar_ = ah_.WhereOrNull<ResourceReference>(ao_, ap_);
				FhirString as_(ResourceReference @this)
				{
					var cc_ = @this?.ReferenceElement;

					return cc_;
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
				InpatientStayLineItems = (((ClaimWithInpatientStay?.MedicalClaim is null))
					? ((null as IEnumerable<Claim>))
					: (context.Operators.WhereOrNull<Claim>(ClaimWithInpatientStay?.MedicalClaim, (Claim c) => context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.WhereOrNull<Claim.ItemComponent>((c?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent i) => context.Operators.ExistsInList<CqlCode>(context.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(i?.Revenue)?.codes as IEnumerable<CqlCode>), (CqlCode rev) => context.Operators.StringInValueSet(rev?.code, this.Inpatient_Stay())))))))),
				NonacuteInpatientLineItems = (((ClaimWithInpatientStay?.MedicalClaim is null))
					? ((null as IEnumerable<Claim>))
					: (context.Operators.WhereOrNull<Claim>(ClaimWithInpatientStay?.MedicalClaim, (Claim c) => context.Operators.Or(context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.WhereOrNull<Claim.ItemComponent>((c?.Item as IEnumerable<Claim.ItemComponent>), (Claim.ItemComponent i) => context.Operators.ExistsInList<CqlCode>(context.Operators.WhereOrNull<CqlCode>((FHIRHelpers_4_0_001.ToConcept(i?.Revenue)?.codes as IEnumerable<CqlCode>), (CqlCode rev) => context.Operators.StringInValueSet(rev?.code, this.Nonacute_Inpatient_Stay()))))), context.Operators.ExistsInList<Coding>(context.Operators.WhereOrNull<Coding>((c?.SubType?.Coding as IEnumerable<Coding>), (Coding tob) => context.Operators.StringInValueSet(tob?.CodeElement?.Value, this.Nonacute_Inpatient_Stay()))))))),
			};
			var j_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb[]
			{
				i_,
			};
			Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE k_(Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb LineItemDefinition)
			{
				var p_ = LineItemDefinition?.InpatientStayLineItems;
				var q_ = LineItemDefinition?.NonacuteInpatientLineItems;
				IEnumerable<Claim> r_(Claim nonAcuteInpatientStay)
				{
					var ac_ = LineItemDefinition?.InpatientStayLineItems;
					bool? ad_(Claim inpatientStay)
					{
						var aj_ = nonAcuteInpatientStay?.IdElement;
						var ak_ = inpatientStay?.IdElement;
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
					var an_ = LineItemDefinition?.NonacuteInpatientLineItems;
					bool? ao_(Claim nonAcuteInpatientStay)
					{
						var au_ = inpatientStay?.IdElement;
						var av_ = nonAcuteInpatientStay?.IdElement;
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
			var k_ = C?.CareTeam;
			bool? l_(Claim.CareTeamComponent ct)
			{
				var ai_ = ct?.SequenceElement;
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
				var ap_ = @this?.Provider;
				var aq_ = context.Operators;
				var ar_ = aq_.Not((bool?)(ap_ is null));

				return ar_;
			};
			var q_ = m_.WhereOrNull<Claim.CareTeamComponent>(n_, o_);
			ResourceReference r_(Claim.CareTeamComponent @this)
			{
				var as_ = @this?.Provider;

				return as_;
			};
			var t_ = m_.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(q_, r_);
			bool? v_(Claim.CareTeamComponent ct)
			{
				var at_ = ct?.SequenceElement;
				var au_ = context.Operators;
				var av_ = au_.TypeConverter;
				var aw_ = av_.Convert<Integer>(at_);
				var ax_ = FHIRHelpers_4_0_001.ToInteger(aw_);
				var az_ = au_.Equal(ax_, (int?)1);

				return az_;
			};
			var x_ = m_.WhereOrNull<Claim.CareTeamComponent>((k_ as IEnumerable<Claim.CareTeamComponent>), v_);
			bool? y_(Claim.CareTeamComponent @this)
			{
				var ba_ = @this?.Provider;
				var bb_ = context.Operators;
				var bc_ = bb_.Not((bool?)(ba_ is null));

				return bc_;
			};
			var aa_ = m_.WhereOrNull<Claim.CareTeamComponent>(x_, y_);
			ResourceReference ab_(Claim.CareTeamComponent @this)
			{
				var bd_ = @this?.Provider;

				return bd_;
			};
			var ad_ = m_.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(aa_, ab_);
			string ae_(ResourceReference p)
			{
				var be_ = p?.ReferenceElement;
				var bf_ = new FhirString[]
				{
					be_,
				};
				string bg_(FhirString r)
				{
					var bl_ = new CallStackEntry("ToString", null, null);
					var bm_ = context.Deeper(bl_);
					var bn_ = bm_.Operators;
					var bo_ = bn_.TypeConverter;
					var bp_ = bo_.Convert<string>(r);
					var bq_ = NCQAFHIRBase_1_0_0.GetId(bp_);

					return bq_;
				};
				var bh_ = context.Operators;
				var bi_ = bh_.SelectOrNull<FhirString, string>(bf_, bg_);
				var bk_ = bh_.SingleOrNull<string>(bi_);

				return bk_;
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
			var br_ = context.DataRetriever;
			var bs_ = br_.RetrieveByValueSet<Practitioner>(null, null);
			bool? bt_(Practitioner p)
			{
				var cd_ = p?.IdElement;
				var ce_ = new CallStackEntry("ToString", null, null);
				var cf_ = context.Deeper(ce_);
				var cg_ = cf_.Operators;
				var ch_ = cg_.TypeConverter;
				var ci_ = ch_.Convert<string>(cd_);
				var cj_ = ClaimProperties?.CareTeams;
				bool? ck_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
				{
					var cu_ = @this?.CareTeamsProviderID;
					var cv_ = context.Operators;
					var cw_ = cv_.Not((bool?)(cu_ is null));

					return cw_;
				};
				var cl_ = context.Operators;
				var cm_ = cl_.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(cj_, ck_);
				IEnumerable<string> cn_(Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this)
				{
					var cx_ = @this?.CareTeamsProviderID;

					return cx_;
				};
				var cp_ = cl_.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, IEnumerable<string>>(cm_, cn_);
				var cr_ = cl_.FlattenList<string>(cp_);
				var ct_ = cl_.InList<string>(ci_, cr_);

				return ct_;
			};
			var bu_ = context.Operators;
			var bv_ = bu_.WhereOrNull<Practitioner>(bs_, bt_);
			var bw_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe
			{
				Practitioners = bv_,
			};
			var bx_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe[]
			{
				bw_,
			};
			Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY by_(Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe PractitionerMatch)
			{
				var cy_ = PractitionerMatch?.Practitioners;
				bool? cz_(Practitioner P)
				{
					var dm_ = context.Operators;
					var dn_ = dm_.Not((bool?)(P is null));

					return dn_;
				};
				var da_ = context.Operators;
				var db_ = da_.WhereOrNull<Practitioner>(cy_, cz_);
				Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR dc_(Practitioner P)
				{
					var do_ = P?.Identifier;
					bool? dp_(Identifier l)
					{
						var ed_ = l?.SystemElement;
						var ee_ = ed_?.Value;
						var ef_ = context.Operators;
						var eg_ = ef_.Equal(ee_, "http://hl7.org/fhir/sid/us-npi");
						var eh_ = l?.Type;
						var ei_ = FHIRHelpers_4_0_001.ToConcept(eh_);
						var ej_ = NCQATerminology_1_0_0.Provider_number();
						var el_ = ef_.ConvertCodeToConcept(ej_);
						var en_ = ef_.Equivalent(ei_, el_);
						var ep_ = ef_.And(eg_, en_);
						var eq_ = l?.ValueElement;
						var er_ = eq_?.Value;
						var et_ = ef_.Not((bool?)(er_ is null));
						var ev_ = ef_.And(ep_, et_);

						return ev_;
					};
					var dq_ = context.Operators;
					var dr_ = dq_.WhereOrNull<Identifier>((do_ as IEnumerable<Identifier>), dp_);
					FhirString ds_(Identifier l)
					{
						var ew_ = l?.ValueElement;

						return ew_;
					};
					var du_ = dq_.SelectOrNull<Identifier, FhirString>(dr_, ds_);
					bool? dw_(Identifier l)
					{
						var ex_ = l?.SystemElement;
						var ey_ = ex_?.Value;
						var ez_ = context.Operators;
						var fa_ = ez_.Equal(ey_, "http://hl7.org/fhir/sid/us-npi");
						var fb_ = l?.Type;
						var fc_ = FHIRHelpers_4_0_001.ToConcept(fb_);
						var fd_ = NCQATerminology_1_0_0.Provider_number();
						var ff_ = ez_.ConvertCodeToConcept(fd_);
						var fh_ = ez_.Equivalent(fc_, ff_);
						var fj_ = ez_.And(fa_, fh_);
						var fk_ = l?.ValueElement;
						var fl_ = fk_?.Value;
						var fn_ = ez_.And(fj_, (bool?)(fl_ is null));

						return fn_;
					};
					var dy_ = dq_.WhereOrNull<Identifier>((do_ as IEnumerable<Identifier>), dw_);
					Identifier dz_(Identifier l) => l;
					var eb_ = dq_.SelectOrNull<Identifier, Identifier>(dy_, dz_);
					var ec_ = new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = du_,
						NullIdentifiers = eb_,
					};

					return ec_;
				};
				var de_ = da_.SelectOrNull<Practitioner, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(db_, dc_);
				var df_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = de_,
				};
				var dg_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					df_,
				};
				Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY dh_(Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers)
				{
					var fo_ = new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = (((context.Operators.ExistsInList<Claim>(context.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => context.Operators.Not((bool?)(@this?.SingleCareTeam is null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this?.SingleCareTeam)) ?? false))
							? (context.Operators.Add(context.Operators.Add(context.Operators.CountOrNull<Claim>(context.Operators.WhereOrNull<Claim>(context.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(context.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ClaimProperties?.CareTeams, (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => context.Operators.Not((bool?)(@this?.SingleCareTeam is null))), (Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS @this) => @this?.SingleCareTeam), (Claim X) => (bool?)((X?.CareTeam as IEnumerable<Claim.CareTeamComponent>) is null))), context.Operators.CountOrNull<FhirString>(context.Operators.SelectOrNull<FhirString, FhirString>(context.Operators.FlattenList<FhirString>(context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.AllIdentifiers)), (FhirString X) => X))), context.Operators.CountOrNull<Identifier>(context.Operators.FlattenList<Identifier>(context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.NullIdentifiers)))))
							: ((int?)0)),
					};

					return fo_;
				};
				var dj_ = da_.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dg_, dh_);
				var dl_ = da_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dj_);

				return dl_;
			};
			var ca_ = bu_.SelectOrNull<Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bx_, by_);
			var cc_ = bu_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ca_);

			return cc_;
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
			var k_ = C?.Item;
			bool? m_(Claim.ItemComponent i)
			{
				var am_ = i?.SequenceElement;
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
				var at_ = @this?.Location;
				var au_ = context.Operators;
				var av_ = au_.Not((bool?)(at_ is null));

				return av_;
			};
			var r_ = n_.WhereOrNull<Claim.ItemComponent>(o_, p_);
			DataType s_(Claim.ItemComponent @this)
			{
				var aw_ = @this?.Location;

				return aw_;
			};
			var u_ = n_.SelectOrNull<Claim.ItemComponent, DataType>(r_, s_);
			ResourceReference v_(DataType l) => (l as ResourceReference);
			var x_ = n_.SelectOrNull<DataType, ResourceReference>(u_, v_);
			bool? z_(Claim.ItemComponent i)
			{
				var ax_ = i?.SequenceElement;
				var ay_ = context.Operators;
				var az_ = ay_.TypeConverter;
				var ba_ = az_.Convert<Integer>(ax_);
				var bb_ = FHIRHelpers_4_0_001.ToInteger(ba_);
				var bd_ = ay_.Equal(bb_, (int?)1);

				return bd_;
			};
			var ab_ = n_.WhereOrNull<Claim.ItemComponent>((k_ as IEnumerable<Claim.ItemComponent>), z_);
			bool? ac_(Claim.ItemComponent @this)
			{
				var be_ = @this?.Location;
				var bf_ = context.Operators;
				var bg_ = bf_.Not((bool?)(be_ is null));

				return bg_;
			};
			var ae_ = n_.WhereOrNull<Claim.ItemComponent>(ab_, ac_);
			DataType af_(Claim.ItemComponent @this)
			{
				var bh_ = @this?.Location;

				return bh_;
			};
			var ah_ = n_.SelectOrNull<Claim.ItemComponent, DataType>(ae_, af_);
			string ai_(DataType l)
			{
				var bi_ = (l as ResourceReference)?.ReferenceElement;
				var bj_ = new FhirString[]
				{
					bi_,
				};
				string bk_(FhirString r)
				{
					var bp_ = new CallStackEntry("ToString", null, null);
					var bq_ = context.Deeper(bp_);
					var br_ = bq_.Operators;
					var bs_ = br_.TypeConverter;
					var bt_ = bs_.Convert<string>(r);
					var bu_ = NCQAFHIRBase_1_0_0.GetId(bt_);

					return bu_;
				};
				var bl_ = context.Operators;
				var bm_ = bl_.SelectOrNull<FhirString, string>(bj_, bk_);
				var bo_ = bl_.SingleOrNull<string>(bm_);

				return bo_;
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
			var bv_ = context.DataRetriever;
			var bw_ = bv_.RetrieveByValueSet<Location>(null, null);
			bool? bx_(Location l)
			{
				var ch_ = l?.IdElement;
				var ci_ = new CallStackEntry("ToString", null, null);
				var cj_ = context.Deeper(ci_);
				var ck_ = cj_.Operators;
				var cl_ = ck_.TypeConverter;
				var cm_ = cl_.Convert<string>(ch_);
				var cn_ = ClaimProperties?.ItemsLocationReferences;
				bool? co_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
				{
					var cy_ = @this?.ItemLocationID;
					var cz_ = context.Operators;
					var da_ = cz_.Not((bool?)(cy_ is null));

					return da_;
				};
				var cp_ = context.Operators;
				var cq_ = cp_.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(cn_, co_);
				IEnumerable<string> cr_(Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this)
				{
					var db_ = @this?.ItemLocationID;

					return db_;
				};
				var ct_ = cp_.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<string>>(cq_, cr_);
				var cv_ = cp_.FlattenList<string>(ct_);
				var cx_ = cp_.InList<string>(cm_, cv_);

				return cx_;
			};
			var by_ = context.Operators;
			var bz_ = by_.WhereOrNull<Location>(bw_, bx_);
			var ca_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP
			{
				CorrespondingLocations = bz_,
			};
			var cb_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP[]
			{
				ca_,
			};
			Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY cc_(Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP GetLocation)
			{
				var dc_ = GetLocation?.CorrespondingLocations;
				bool? dd_(Location C)
				{
					var dq_ = context.Operators;
					var dr_ = dq_.Not((bool?)(C is null));

					return dr_;
				};
				var de_ = context.Operators;
				var df_ = de_.WhereOrNull<Location>(dc_, dd_);
				Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR dg_(Location C)
				{
					var ds_ = C?.Identifier;
					bool? dt_(Identifier l)
					{
						var eh_ = l?.SystemElement;
						var ei_ = eh_?.Value;
						var ej_ = context.Operators;
						var ek_ = ej_.Equal(ei_, "http://hl7.org/fhir/sid/us-npi");
						var el_ = l?.Type;
						var em_ = FHIRHelpers_4_0_001.ToConcept(el_);
						var en_ = NCQATerminology_1_0_0.Provider_number();
						var ep_ = ej_.ConvertCodeToConcept(en_);
						var er_ = ej_.Equivalent(em_, ep_);
						var et_ = ej_.And(ek_, er_);
						var eu_ = l?.ValueElement;
						var ev_ = eu_?.Value;
						var ex_ = ej_.Not((bool?)(ev_ is null));
						var ez_ = ej_.And(et_, ex_);

						return ez_;
					};
					var du_ = context.Operators;
					var dv_ = du_.WhereOrNull<Identifier>((ds_ as IEnumerable<Identifier>), dt_);
					FhirString dw_(Identifier l)
					{
						var fa_ = l?.ValueElement;

						return fa_;
					};
					var dy_ = du_.SelectOrNull<Identifier, FhirString>(dv_, dw_);
					bool? ea_(Identifier l)
					{
						var fb_ = l?.SystemElement;
						var fc_ = fb_?.Value;
						var fd_ = context.Operators;
						var fe_ = fd_.Equal(fc_, "http://hl7.org/fhir/sid/us-npi");
						var ff_ = l?.Type;
						var fg_ = FHIRHelpers_4_0_001.ToConcept(ff_);
						var fh_ = NCQATerminology_1_0_0.Provider_number();
						var fj_ = fd_.ConvertCodeToConcept(fh_);
						var fl_ = fd_.Equivalent(fg_, fj_);
						var fn_ = fd_.And(fe_, fl_);
						var fo_ = l?.ValueElement;
						var fp_ = fo_?.Value;
						var fr_ = fd_.And(fn_, (bool?)(fp_ is null));

						return fr_;
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
				var di_ = de_.SelectOrNull<Location, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(df_, dg_);
				var dj_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = di_,
				};
				var dk_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					dj_,
				};
				Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY dl_(Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH GetIdentifiers)
				{
					var fs_ = new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = (((context.Operators.ExistsInList<Claim.ItemComponent>(context.Operators.FlattenList<Claim.ItemComponent>(context.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<Claim.ItemComponent>>(context.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => context.Operators.Not((bool?)(@this?.SingleItem is null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this?.SingleItem))) ?? false))
							? (context.Operators.Add(context.Operators.Add(context.Operators.CountOrNull<ResourceReference>(context.Operators.WhereOrNull<ResourceReference>(context.Operators.FlattenList<ResourceReference>(context.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<ResourceReference>>(context.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(ClaimProperties?.ItemsLocationReferences, (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => context.Operators.Not((bool?)(@this?.ItemLocation is null))), (Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI @this) => @this?.ItemLocation)), (ResourceReference X) => (bool?)(X?.ReferenceElement?.Value is null))), context.Operators.CountOrNull<FhirString>(context.Operators.SelectOrNull<FhirString, FhirString>(context.Operators.FlattenList<FhirString>(context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.AllIdentifiers)), (FhirString X) => X))), context.Operators.CountOrNull<Identifier>(context.Operators.FlattenList<Identifier>(context.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(GetIdentifiers?.IdentifierTuple, (Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR X) => X?.NullIdentifiers)))))
							: ((int?)0)),
					};

					return fs_;
				};
				var dn_ = de_.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dk_, dl_);
				var dp_ = de_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dn_);

				return dp_;
			};
			var ce_ = by_.SelectOrNull<Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(cb_, cc_);
			var cg_ = by_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ce_);

			return cg_;
		};
		var h_ = b_.SelectOrNull<Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(e_, f_);
		var j_ = b_.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(h_);

		return j_;
	}


}
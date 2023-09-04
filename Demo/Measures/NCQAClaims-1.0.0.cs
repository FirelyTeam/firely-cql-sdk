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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395", 
			null);
    }

    [CqlDeclaration("Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395")]
    public CqlValueSet Inpatient_Stay() => __Inpatient_Stay.Value;

    private CqlValueSet Nonacute_Inpatient_Stay_Value()
    {
        return new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398", 
			null);
    }

    [CqlDeclaration("Nonacute Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398")]
    public CqlValueSet Nonacute_Inpatient_Stay() => __Nonacute_Inpatient_Stay.Value;

    [CqlDeclaration("Professional or Institutional Claims")]
    public IEnumerable<Claim> Professional_or_Institutional_Claims(IEnumerable<Claim> claim)
    {
        Func<Claim,bool?> g_ = (MedicalClaim) => 
        {
            var a_ = (FHIRHelpers_4_0_001.ToConcept(MedicalClaim?.Type)?.codes as IEnumerable<CqlCode>);
            var b_ = NCQATerminology_1_0_0.Professional();
            var c_ = context?.Operators.ListContains<CqlCode>(a_, 
				b_);
            var e_ = NCQATerminology_1_0_0.Institutional();
            var f_ = context?.Operators.ListContains<CqlCode>(a_, 
				e_);
            return context?.Operators.Or(c_, 
				f_);
        };
        return context?.Operators.WhereOrNull<Claim>(claim, 
			g_);
    }

    [CqlDeclaration("Pharmacy Claims")]
    public IEnumerable<Claim> Pharmacy_Claims(IEnumerable<Claim> claim)
    {
        Func<Claim,bool?> c_ = (PharmacyClaim) => 
        {
            var a_ = (FHIRHelpers_4_0_001.ToConcept(PharmacyClaim?.Type)?.codes as IEnumerable<CqlCode>);
            var b_ = NCQATerminology_1_0_0.Pharmacy();
            return context?.Operators.ListContains<CqlCode>(a_, 
				b_);
        };
        return context?.Operators.WhereOrNull<Claim>(claim, 
			c_);
    }

    [CqlDeclaration("Professional or Institutional Claims Response")]
    public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
    {
        Func<ClaimResponse,bool?> g_ = (MedicalResponse) => 
        {
            var a_ = (FHIRHelpers_4_0_001.ToConcept(MedicalResponse?.Type)?.codes as IEnumerable<CqlCode>);
            var b_ = NCQATerminology_1_0_0.Professional();
            var c_ = context?.Operators.ListContains<CqlCode>(a_, 
				b_);
            var e_ = NCQATerminology_1_0_0.Institutional();
            var f_ = context?.Operators.ListContains<CqlCode>(a_, 
				e_);
            return context?.Operators.Or(c_, 
				f_);
        };
        return context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, 
			g_);
    }

    [CqlDeclaration("Pharmacy Claims Response")]
    public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(IEnumerable<ClaimResponse> claimResponse)
    {
        Func<ClaimResponse,bool?> c_ = (PharmacyResponse) => 
        {
            var a_ = (FHIRHelpers_4_0_001.ToConcept(PharmacyResponse?.Type)?.codes as IEnumerable<CqlCode>);
            var b_ = NCQATerminology_1_0_0.Pharmacy();
            return context?.Operators.ListContains<CqlCode>(a_, 
				b_);
        };
        return context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, 
			c_);
    }

    [CqlDeclaration("Medical Claims With Procedure and POS")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_and_POS(IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        var c_ = this.Professional_or_Institutional_Claims(claim);
        Func<CqlCode,string> e_ = (p) => 
        {
            return p?.code;
        };
        var d_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, 
			e_);
        Func<CqlCode,string> g_ = (pos) => 
        {
            return pos?.code;
        };
        var f_ = context?.Operators.SelectOrNull<CqlCode, string>(posCodes, 
			g_);
        var b_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = c_,
			ProceduresAsStrings = d_,
			POSAsString = f_,
		};
        var a_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			b_,
		};
        Func<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO,IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>> ag_ = (ClaimWithPosCode) => 
        {
            var h_ = ClaimWithPosCode?.MedicalClaim;
            Func<Claim,Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> ac_ = (ClaimofInterest) => 
            {
                var k_ = ClaimofInterest;
                var m_ = (ClaimofInterest?.Item as IEnumerable<Claim.ItemComponent>);
                Func<Claim.ItemComponent,bool?> z_ = (ItemOnLine) => 
                {
                    var n_ = (FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService)?.codes as IEnumerable<CqlCode>);
                    Func<CqlCode,bool?> q_ = (LineCode) => 
                    {
                        var o_ = LineCode?.code;
                        var p_ = ClaimWithPosCode?.ProceduresAsStrings;
                        return context?.Operators.InList<string>(o_, 
							p_);
                    };
                    var r_ = context?.Operators.WhereOrNull<CqlCode>(n_, 
						q_);
                    var s_ = context?.Operators.ExistsInList<CqlCode>(r_);
                    var t_ = ((FHIRHelpers_4_0_001.ToConcept(((ItemOnLine?.Location as object) as CodeableConcept)))?.codes as IEnumerable<CqlCode>);
                    Func<CqlCode,bool?> w_ = (PosCode) => 
                    {
                        var u_ = PosCode?.code;
                        var v_ = ClaimWithPosCode?.POSAsString;
                        return context?.Operators.InList<string>(u_, 
							v_);
                    };
                    var x_ = context?.Operators.WhereOrNull<CqlCode>(t_, 
						w_);
                    var y_ = context?.Operators.ExistsInList<CqlCode>(x_);
                    return context?.Operators.And(s_, 
						y_);
                };
                var l_ = (((ClaimofInterest == null))
					? ((null as IEnumerable<Claim.ItemComponent>))
					: (context?.Operators.WhereOrNull<Claim.ItemComponent>(m_, 
							z_)))
;
                var j_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = k_,
					LineItems = l_,
				};
                var i_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					j_,
				};
                Func<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj,Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> aa_ = (LineItemDefinition) => (((context?.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
						? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = LineItemDefinition?.Claim,
								ServicePeriod = context?.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context?.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, 
											(@this) => context?.Operators.Not(((bool?)(@this?.Serviced == null)))), 
										(@this) => @this?.Serviced), 
									(NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
							})
						: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)))
;
                var ab_ = context?.Operators.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(i_, 
					aa_);
                return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ab_);
            };
            var ad_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(h_, 
				ac_);
            Func<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA,bool?> af_ = (FinalList) => 
            {
                bool? ae_ = ((bool?)(FinalList == null));
                return context?.Operators.Not(ae_);
            };
            return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ad_, 
				af_);
        };
        var ah_ = context?.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(a_, 
			ag_);
        return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(ah_);
    }

    [CqlDeclaration("Medical Claims With Procedure in Header or on Line Item")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        var c_ = this.Professional_or_Institutional_Claims(claim);
        Func<CqlCode,string> e_ = (p) => 
        {
            return p?.code;
        };
        var d_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, 
			e_);
        var b_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = c_,
			ProceduresAsStrings = d_,
		};
        var a_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			b_,
		};
        Func<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO,IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>> at_ = (ClaimWithProcedure) => 
        {
            var f_ = ClaimWithProcedure?.MedicalClaim;
            Func<Claim,Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> ap_ = (ClaimofInterest) => 
            {
                var i_ = ClaimofInterest;
                var k_ = (ClaimofInterest?.Item as IEnumerable<Claim.ItemComponent>);
                Func<Claim.ItemComponent,bool?> am_ = (ItemOnLine) => 
                {
                    var l_ = (FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService)?.codes as IEnumerable<CqlCode>);
                    Func<CqlCode,bool?> o_ = (LineCode) => 
                    {
                        var m_ = LineCode?.code;
                        var n_ = ClaimWithProcedure?.ProceduresAsStrings;
                        return context?.Operators.InList<string>(m_, 
							n_);
                    };
                    var p_ = context?.Operators.WhereOrNull<CqlCode>(l_, 
						o_);
                    var q_ = context?.Operators.ExistsInList<CqlCode>(p_);
                    var r_ = (ClaimofInterest?.Procedure as IEnumerable<Claim.ProcedureComponent>);
                    Func<Claim.ProcedureComponent,bool?> t_ = (@this) => 
                    {
                        bool? s_ = ((bool?)(@this?.Procedure == null));
                        return context?.Operators.Not(s_);
                    };
                    var u_ = context?.Operators.WhereOrNull<Claim.ProcedureComponent>(r_, 
						t_);
                    Func<Claim.ProcedureComponent,DataType> v_ = (@this) => 
                    {
                        return @this?.Procedure;
                    };
                    var w_ = context?.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(u_, 
						v_);
                    Func<DataType,bool?> z_ = (@this) => 
                    {
                        var y_ = (@this as object);
                        bool? x_ = ((bool?)(context?.Operators.LateBoundProperty<object>(y_, 
							"coding") == null));
                        return context?.Operators.Not(x_);
                    };
                    var aa_ = context?.Operators.WhereOrNull<DataType>(w_, 
						z_);
                    Func<DataType,object> ac_ = (@this) => 
                    {
                        var ab_ = (@this as object);
                        return context?.Operators.LateBoundProperty<object>(ab_, 
							"coding");
                    };
                    var ad_ = context?.Operators.SelectOrNull<DataType, object>(aa_, 
						ac_);
                    var ae_ = context?.Operators.FlattenLateBoundList(ad_);
                    Func<object,Coding> af_ = (@object) => (@object as Coding);
                    var ag_ = context?.Operators.SelectOrNull<object, Coding>(ae_, 
						af_);
                    Func<Coding,bool?> aj_ = (HeaderCode) => 
                    {
                        var ah_ = HeaderCode?.CodeElement?.Value;
                        var ai_ = ClaimWithProcedure?.ProceduresAsStrings;
                        return context?.Operators.InList<string>(ah_, 
							ai_);
                    };
                    var ak_ = context?.Operators.WhereOrNull<Coding>(ag_, 
						aj_);
                    var al_ = context?.Operators.ExistsInList<Coding>(ak_);
                    return context?.Operators.Or(q_, 
						al_);
                };
                var j_ = (((ClaimofInterest == null))
					? ((null as IEnumerable<Claim.ItemComponent>))
					: (context?.Operators.WhereOrNull<Claim.ItemComponent>(k_, 
							am_)))
;
                var h_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = i_,
					LineItems = j_,
				};
                var g_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					h_,
				};
                Func<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj,Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> an_ = (LineItemDefinition) => (((context?.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
						? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
							{
								Claim = LineItemDefinition?.Claim,
								ServicePeriod = context?.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context?.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, 
											(@this) => context?.Operators.Not(((bool?)(@this?.Serviced == null)))), 
										(@this) => @this?.Serviced), 
									(NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
							})
						: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)))
;
                var ao_ = context?.Operators.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(g_, 
					an_);
                return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ao_);
            };
            var aq_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(f_, 
				ap_);
            Func<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA,bool?> as_ = (FinalList) => 
            {
                bool? ar_ = ((bool?)(FinalList == null));
                return context?.Operators.Not(ar_);
            };
            return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(aq_, 
				as_);
        };
        var au_ = context?.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(a_, 
			at_);
        return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(au_);
    }

    [CqlDeclaration("Medical Claims With Diagnosis")]
    public Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI Medical_Claims_With_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        var c_ = this.Professional_or_Institutional_Claims(claim);
        Func<CqlCode,string> e_ = (d) => 
        {
            return d?.code;
        };
        var d_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, 
			e_);
        var b_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = c_,
			DiagnosesAsStrings = d_,
		};
        var a_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			b_,
		};
        Func<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX,Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> ax_ = (ClaimWithDiagnosis) => 
        {
            var i_ = ClaimWithDiagnosis?.MedicalClaim;
            Func<Claim,bool?> ad_ = (DiagnosisLine) => 
            {
                var j_ = (DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>);
                Func<Claim.DiagnosisComponent,bool?> l_ = (@this) => 
                {
                    bool? k_ = ((bool?)(@this?.Diagnosis == null));
                    return context?.Operators.Not(k_);
                };
                var m_ = context?.Operators.WhereOrNull<Claim.DiagnosisComponent>(j_, 
					l_);
                Func<Claim.DiagnosisComponent,DataType> n_ = (@this) => 
                {
                    return @this?.Diagnosis;
                };
                var o_ = context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(m_, 
					n_);
                Func<DataType,bool?> r_ = (@this) => 
                {
                    var q_ = (@this as object);
                    bool? p_ = ((bool?)(context?.Operators.LateBoundProperty<object>(q_, 
						"coding") == null));
                    return context?.Operators.Not(p_);
                };
                var s_ = context?.Operators.WhereOrNull<DataType>(o_, 
					r_);
                Func<DataType,object> u_ = (@this) => 
                {
                    var t_ = (@this as object);
                    return context?.Operators.LateBoundProperty<object>(t_, 
						"coding");
                };
                var v_ = context?.Operators.SelectOrNull<DataType, object>(s_, 
					u_);
                var w_ = context?.Operators.FlattenLateBoundList(v_);
                Func<object,Coding> x_ = (@object) => (@object as Coding);
                var y_ = context?.Operators.SelectOrNull<object, Coding>(w_, 
					x_);
                Func<Coding,bool?> ab_ = (HeaderCode) => 
                {
                    var z_ = HeaderCode?.CodeElement?.Value;
                    var aa_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                    return context?.Operators.InList<string>(z_, 
						aa_);
                };
                var ac_ = context?.Operators.WhereOrNull<Coding>(y_, 
					ab_);
                return context?.Operators.ExistsInList<Coding>(ac_);
            };
            var h_ = (((ClaimWithDiagnosis?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(i_, 
						ad_)))
;
            var g_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = h_,
			};
            var f_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				g_,
			};
            Func<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg,Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> av_ = (HeaderDefinition) => 
            {
                var ag_ = HeaderDefinition?.DiagnosisItems;
                Func<Claim,bool?> al_ = (@this) => 
                {
                    bool? ak_ = ((bool?)(@this?.Item == null));
                    return context?.Operators.Not(ak_);
                };
                var am_ = context?.Operators.WhereOrNull<Claim>(ag_, 
					al_);
                Func<Claim,List<Claim.ItemComponent>> an_ = (@this) => 
                {
                    return @this?.Item;
                };
                var ao_ = context?.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(am_, 
					an_);
                var ap_ = context?.Operators.FlattenList<Claim.ItemComponent>(ao_);
                Func<Claim.ItemComponent,CqlInterval<CqlDateTime>> ar_ = (NormalDate) => 
                {
                    var aq_ = (NormalDate?.Serviced as object);
                    return NCQAFHIRBase_1_0_0.Normalize_Interval(aq_);
                };
                var ai_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(ap_, 
					ar_);
                var af_ = (((context?.Operators.ExistsInList<Claim>(ag_) ?? false))
					? (new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
						{
							Claim = ag_,
							ServicePeriod = ai_,
						})
					: ((null as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI)))
;
                var ae_ = new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI[]
				{
					af_,
				};
                Func<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI,bool?> at_ = (FinalList) => 
                {
                    bool? as_ = ((bool?)(FinalList == null));
                    return context?.Operators.Not(as_);
                };
                var au_ = context?.Operators.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(ae_, 
					at_);
                return context?.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(au_);
            };
            var aw_ = context?.Operators.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(f_, 
				av_);
            return context?.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(aw_);
        };
        var ay_ = context?.Operators.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(a_, 
			ax_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(ay_);
    }

    [CqlDeclaration("Pharmacy Claim With Medication")]
    public IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> Pharmacy_Claim_With_Medication(IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
    {
        var c_ = this.Pharmacy_Claims(claim);
        Func<CqlCode,string> e_ = (p) => 
        {
            return p?.code;
        };
        var d_ = context?.Operators.SelectOrNull<CqlCode, string>(MedicationCodes, 
			e_);
        var b_ = new Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY
		{
			PharmacyClaim = c_,
			MedicationsAsStrings = d_,
		};
        var a_ = new Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY[]
		{
			b_,
		};
        Func<Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY,IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>> bi_ = (ClaimWithMedication) => 
        {
            var f_ = ClaimWithMedication?.PharmacyClaim;
            Func<Claim,Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> be_ = (Pharmacy) => 
            {
                var i_ = Pharmacy;
                var k_ = (Pharmacy?.Item as IEnumerable<Claim.ItemComponent>);
                Func<Claim.ItemComponent,bool?> q_ = (ItemOnLine) => 
                {
                    var l_ = (FHIRHelpers_4_0_001.ToConcept(ItemOnLine?.ProductOrService)?.codes as IEnumerable<CqlCode>);
                    Func<CqlCode,bool?> o_ = (LineCode) => 
                    {
                        var m_ = LineCode?.code;
                        var n_ = ClaimWithMedication?.MedicationsAsStrings;
                        return context?.Operators.InList<string>(m_, 
							n_);
                    };
                    var p_ = context?.Operators.WhereOrNull<CqlCode>(l_, 
						o_);
                    return context?.Operators.ExistsInList<CqlCode>(p_);
                };
                var j_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(k_, 
					q_);
                var h_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj
				{
					Claim = i_,
					LineItems = j_,
				};
                var g_ = new Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj[]
				{
					h_,
				};
                Func<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj,Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> bc_ = (LineItemDefinition) => 
                {
                    var s_ = LineItemDefinition?.Claim;
                    var r_ = new Claim[]
					{
						s_,
					};
                    Func<Claim,Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> ba_ = (ClaimLines) => 
                    {
                        var w_ = (ClaimLines?.Item as IEnumerable<Claim.ItemComponent>);
                        Func<Claim.ItemComponent,bool?> ac_ = (i) => 
                        {
                            var x_ = (FHIRHelpers_4_0_001.ToConcept(i?.ProductOrService)?.codes as IEnumerable<CqlCode>);
                            Func<CqlCode,bool?> aa_ = (LineCode) => 
                            {
                                var y_ = LineCode?.code;
                                var z_ = ClaimWithMedication?.MedicationsAsStrings;
                                return context?.Operators.InList<string>(y_, 
									z_);
                            };
                            var ab_ = context?.Operators.WhereOrNull<CqlCode>(x_, 
								aa_);
                            return context?.Operators.ExistsInList<CqlCode>(ab_);
                        };
                        var ad_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(w_, 
							ac_);
                        Func<Claim.ItemComponent,Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP> ax_ = (i) => 
                        {
                            bool? af_ = ((bool?)(i?.Quantity == null));
                            var ag_ = (i?.Serviced as object);
                            var ah_ = NCQAFHIRBase_1_0_0.Normalize_Interval(ag_);
                            var ai_ = context?.Operators.Start(ah_);
                            var an_ = i?.Quantity?.ValueElement;
                            var am_ = new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal(an_), 
								"day");
                            var ao_ = context?.Operators.Add(ai_, 
								am_);
                            var ap_ = context?.Operators.Quantity(1m, 
								"day");
                            var aq_ = context?.Operators.Subtract(ao_, 
								ap_);
                            var ar_ = (context?.Operators.Interval(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), 
									context?.Operators.Subtract(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), 
											new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement), 
												"day")), 
										context?.Operators.Quantity(1m, 
											"day")), 
									true, 
									true))?.low;
                            var as_ = context?.Operators.ConvertDateToDateTime(ar_);
                            var at_ = (context?.Operators.Interval(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), 
									context?.Operators.Subtract(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), 
											new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement), 
												"day")), 
										context?.Operators.Quantity(1m, 
											"day")), 
									true, 
									true))?.high;
                            var au_ = context?.Operators.ConvertDateToDateTime(at_);
                            var av_ = (context?.Operators.Interval(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), 
									context?.Operators.Subtract(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), 
											new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement), 
												"day")), 
										context?.Operators.Quantity(1m, 
											"day")), 
									true, 
									true))?.lowClosed;
                            var aw_ = (context?.Operators.Interval(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), 
									context?.Operators.Subtract(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(((i?.Serviced as object) as Date)), 
											new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement), 
												"day")), 
										context?.Operators.Quantity(1m, 
											"day")), 
									true, 
									true))?.highClosed;
                            var ae_ = (((context?.Operators.Not(af_) ?? false))
								? ((((((i?.Serviced as object) is Period as bool?) ?? false))
										? (context?.Operators.Interval(ai_, 
												aq_, 
												true, 
												true))
										: (context?.Operators.Interval(as_, 
												au_, 
												av_, 
												aw_)))
)
								: ((null as CqlInterval<CqlDateTime>)))
;
                            return new Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP
							{
								DaysSupplyInterval = ae_,
							};
                        };
                        var v_ = context?.Operators.SelectOrNull<Claim.ItemComponent, Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP>(ad_, 
							ax_);
                        var u_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU
						{
							CoveredDays = v_,
						};
                        var t_ = new Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU[]
						{
							u_,
						};
                        Func<Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU,Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> ay_ = (ItemCalculation) => (((context?.Operators.ExistsInList<Claim.ItemComponent>(LineItemDefinition?.LineItems) ?? false))
								? (new Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC
									{
										Claim = LineItemDefinition?.Claim,
										LineItem = LineItemDefinition?.LineItems,
										ServicePeriod = context?.Operators.SelectOrNull<DataType, CqlInterval<CqlDateTime>>(context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(context?.Operators.WhereOrNull<Claim.ItemComponent>(LineItemDefinition?.LineItems, 
													(@this) => context?.Operators.Not(((bool?)(@this?.Serviced == null)))), 
												(@this) => @this?.Serviced), 
											(NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval(NormalDate)),
										CoveredDays = context?.Operators.SelectOrNull<Tuples.Tuple_DadNQNcGichTGjKhdjJicQeTP, CqlInterval<CqlDateTime>>(ItemCalculation?.CoveredDays, 
											(d) => d?.DaysSupplyInterval),
									})
								: ((null as Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC)))
;
                        var az_ = context?.Operators.SelectOrNull<Tuples.Tuple_BYGeMjQEUUIJcKZHQOCRZhZCU, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(t_, 
							ay_);
                        return context?.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(az_);
                    };
                    var bb_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(r_, 
						ba_);
                    return context?.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(bb_);
                };
                var bd_ = context?.Operators.SelectOrNull<Tuples.Tuple_CNibCQZPIWCUUGeAXcXWGiTgj, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(g_, 
					bc_);
                return context?.Operators.SingleOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(bd_);
            };
            var bf_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(f_, 
				be_);
            Func<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC,bool?> bh_ = (FinalList) => 
            {
                bool? bg_ = ((bool?)(FinalList == null));
                return context?.Operators.Not(bg_);
            };
            return context?.Operators.WhereOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(bf_, 
				bh_);
        };
        var bj_ = context?.Operators.SelectOrNull<Tuples.Tuple_BAGeQidBiLhNHVFiERZPAUdCY, IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(a_, 
			bi_);
        return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>>(bj_);
    }

    [CqlDeclaration("Medical Claims With Diagnosis and Procedure")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        var c_ = this.Professional_or_Institutional_Claims(claim);
        Func<CqlCode,string> e_ = (d) => 
        {
            return d?.code;
        };
        var d_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, 
			e_);
        Func<CqlCode,string> g_ = (p) => 
        {
            return p?.code;
        };
        var f_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, 
			g_);
        var b_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = c_,
			DiagnosesAsStrings = d_,
			ProceduresAsStrings = f_,
		};
        var a_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
		{
			b_,
		};
        Func<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb,IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>> ci_ = (ClaimWithDiagnosis) => 
        {
            var k_ = ClaimWithDiagnosis?.MedicalClaim;
            Func<Claim,bool?> af_ = (DiagnosisLine) => 
            {
                var l_ = (DiagnosisLine?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>);
                Func<Claim.DiagnosisComponent,bool?> n_ = (@this) => 
                {
                    bool? m_ = ((bool?)(@this?.Diagnosis == null));
                    return context?.Operators.Not(m_);
                };
                var o_ = context?.Operators.WhereOrNull<Claim.DiagnosisComponent>(l_, 
					n_);
                Func<Claim.DiagnosisComponent,DataType> p_ = (@this) => 
                {
                    return @this?.Diagnosis;
                };
                var q_ = context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(o_, 
					p_);
                Func<DataType,bool?> t_ = (@this) => 
                {
                    var s_ = (@this as object);
                    bool? r_ = ((bool?)(context?.Operators.LateBoundProperty<object>(s_, 
						"coding") == null));
                    return context?.Operators.Not(r_);
                };
                var u_ = context?.Operators.WhereOrNull<DataType>(q_, 
					t_);
                Func<DataType,object> w_ = (@this) => 
                {
                    var v_ = (@this as object);
                    return context?.Operators.LateBoundProperty<object>(v_, 
						"coding");
                };
                var x_ = context?.Operators.SelectOrNull<DataType, object>(u_, 
					w_);
                var y_ = context?.Operators.FlattenLateBoundList(x_);
                Func<object,Coding> z_ = (@object) => (@object as Coding);
                var aa_ = context?.Operators.SelectOrNull<object, Coding>(y_, 
					z_);
                Func<Coding,bool?> ad_ = (HeaderCode) => 
                {
                    var ab_ = HeaderCode?.CodeElement?.Value;
                    var ac_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                    return context?.Operators.InList<string>(ab_, 
						ac_);
                };
                var ae_ = context?.Operators.WhereOrNull<Coding>(aa_, 
					ad_);
                return context?.Operators.ExistsInList<Coding>(ae_);
            };
            var j_ = (((ClaimWithDiagnosis?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(k_, 
						af_)))
;
            var i_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg
			{
				DiagnosisItems = j_,
			};
            var h_ = new Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg[]
			{
				i_,
			};
            Func<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg,IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>> cg_ = (ClaimWithProcedure) => 
            {
                var ag_ = ClaimWithProcedure?.DiagnosisItems;
                Func<Claim,Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> cc_ = (ClaimofInterest) => 
                {
                    var al_ = ClaimofInterest;
                    var ak_ = new Claim[]
					{
						al_,
					};
                    Func<Claim,bool?> by_ = (ItemOnLine) => 
                    {
                        var am_ = (ItemOnLine?.Procedure as IEnumerable<Claim.ProcedureComponent>);
                        Func<Claim.ProcedureComponent,bool?> ao_ = (@this) => 
                        {
                            bool? an_ = ((bool?)(@this?.Procedure == null));
                            return context?.Operators.Not(an_);
                        };
                        var ap_ = context?.Operators.WhereOrNull<Claim.ProcedureComponent>(am_, 
							ao_);
                        Func<Claim.ProcedureComponent,DataType> aq_ = (@this) => 
                        {
                            return @this?.Procedure;
                        };
                        var ar_ = context?.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(ap_, 
							aq_);
                        Func<DataType,bool?> au_ = (@this) => 
                        {
                            var at_ = (@this as object);
                            bool? as_ = ((bool?)(context?.Operators.LateBoundProperty<object>(at_, 
								"coding") == null));
                            return context?.Operators.Not(as_);
                        };
                        var av_ = context?.Operators.WhereOrNull<DataType>(ar_, 
							au_);
                        Func<DataType,object> ax_ = (@this) => 
                        {
                            var aw_ = (@this as object);
                            return context?.Operators.LateBoundProperty<object>(aw_, 
								"coding");
                        };
                        var ay_ = context?.Operators.SelectOrNull<DataType, object>(av_, 
							ax_);
                        var az_ = context?.Operators.FlattenLateBoundList(ay_);
                        Func<object,Coding> ba_ = (@object) => (@object as Coding);
                        var bb_ = context?.Operators.SelectOrNull<object, Coding>(az_, 
							ba_);
                        Func<Coding,bool?> be_ = (ProcedureHeaderCode) => 
                        {
                            var bc_ = ProcedureHeaderCode?.CodeElement?.Value;
                            var bd_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                            return context?.Operators.InList<string>(bc_, 
								bd_);
                        };
                        var bf_ = context?.Operators.WhereOrNull<Coding>(bb_, 
							be_);
                        var bg_ = context?.Operators.ExistsInList<Coding>(bf_);
                        var bh_ = (ItemOnLine?.Item as IEnumerable<Claim.ItemComponent>);
                        Func<Claim.ItemComponent,bool?> bj_ = (@this) => 
                        {
                            bool? bi_ = ((bool?)(@this?.ProductOrService == null));
                            return context?.Operators.Not(bi_);
                        };
                        var bk_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(bh_, 
							bj_);
                        Func<Claim.ItemComponent,CodeableConcept> bl_ = (@this) => 
                        {
                            return @this?.ProductOrService;
                        };
                        var bm_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(bk_, 
							bl_);
                        Func<CodeableConcept,bool?> bo_ = (@this) => 
                        {
                            bool? bn_ = ((bool?)(@this?.Coding == null));
                            return context?.Operators.Not(bn_);
                        };
                        var bp_ = context?.Operators.WhereOrNull<CodeableConcept>(bm_, 
							bo_);
                        Func<CodeableConcept,List<Coding>> bq_ = (@this) => 
                        {
                            return @this?.Coding;
                        };
                        var br_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(bp_, 
							bq_);
                        var bs_ = context?.Operators.FlattenList<Coding>(br_);
                        Func<Coding,bool?> bv_ = (LineCode) => 
                        {
                            var bt_ = LineCode?.CodeElement?.Value;
                            var bu_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                            return context?.Operators.InList<string>(bt_, 
								bu_);
                        };
                        var bw_ = context?.Operators.WhereOrNull<Coding>(bs_, 
							bv_);
                        var bx_ = context?.Operators.ExistsInList<Coding>(bw_);
                        return context?.Operators.Or(bg_, 
							bx_);
                    };
                    var bz_ = context?.Operators.WhereOrNull<Claim>(ak_, 
						by_);
                    var aj_ = (((ClaimofInterest == null))
						? (null)
						: (context?.Operators.SingleOrNull<Claim>(bz_)))
;
                    var ai_ = new Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU
					{
						ProcedureItems = aj_,
					};
                    var ah_ = new Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU[]
					{
						ai_,
					};
                    Func<Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU,Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> ca_ = (HeaderDefinition) => (((context?.Operators.Not(((bool?)(HeaderDefinition?.ProcedureItems == null))) ?? false))
							? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
								{
									Claim = HeaderDefinition?.ProcedureItems,
									ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((HeaderDefinition?.ProcedureItems?.Item as IEnumerable<Claim.ItemComponent>), 
										(NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval((NormalDate?.Serviced as object))),
								})
							: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)))
;
                    var cb_ = context?.Operators.SelectOrNull<Tuples.Tuple_DQefEeUREeePUGdeeZLYSgFcU, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ah_, 
						ca_);
                    return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(cb_);
                };
                var cd_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ag_, 
					cc_);
                Func<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA,bool?> cf_ = (FinalList) => 
                {
                    bool? ce_ = ((bool?)(FinalList == null));
                    return context?.Operators.Not(ce_);
                };
                return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(cd_, 
					cf_);
            };
            var ch_ = context?.Operators.SelectOrNull<Tuples.Tuple_FcALBBGFXRhKjhIaDWMVWUhJg, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(h_, 
				cg_);
            return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(ch_);
        };
        var cj_ = context?.Operators.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(a_, 
			ci_);
        return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(cj_);
    }

    [CqlDeclaration("Medical Claims With Principal Diagnosis and Procedure")]
    public IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> Medical_Claims_With_Principal_Diagnosis_and_Procedure(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        var c_ = this.Professional_or_Institutional_Claims(claim);
        Func<CqlCode,string> e_ = (d) => 
        {
            return d?.code;
        };
        var d_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, 
			e_);
        Func<CqlCode,string> g_ = (p) => 
        {
            return p?.code;
        };
        var f_ = context?.Operators.SelectOrNull<CqlCode, string>(ProductOrServiceValueSet, 
			g_);
        var b_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb
		{
			MedicalClaim = c_,
			DiagnosesAsStrings = d_,
			ProceduresAsStrings = f_,
		};
        var a_ = new Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb[]
		{
			b_,
		};
        Func<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb,IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>> cl_ = (ClaimWithProcedure) => 
        {
            var h_ = ClaimWithProcedure?.MedicalClaim;
            Func<Claim,Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> ch_ = (ClaimofInterest) => 
            {
                var k_ = ClaimofInterest;
                var m_ = new Claim[]
				{
					k_,
				};
                Func<Claim,bool?> ba_ = (ItemOnLine) => 
                {
                    var o_ = (ItemOnLine?.Item as IEnumerable<Claim.ItemComponent>);
                    Func<Claim.ItemComponent,bool?> q_ = (@this) => 
                    {
                        bool? p_ = ((bool?)(@this?.ProductOrService == null));
                        return context?.Operators.Not(p_);
                    };
                    var r_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(o_, 
						q_);
                    Func<Claim.ItemComponent,CodeableConcept> s_ = (@this) => 
                    {
                        return @this?.ProductOrService;
                    };
                    var t_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(r_, 
						s_);
                    Func<CodeableConcept,bool?> v_ = (@this) => 
                    {
                        bool? u_ = ((bool?)(@this?.Coding == null));
                        return context?.Operators.Not(u_);
                    };
                    var w_ = context?.Operators.WhereOrNull<CodeableConcept>(t_, 
						v_);
                    Func<CodeableConcept,List<Coding>> x_ = (@this) => 
                    {
                        return @this?.Coding;
                    };
                    var y_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(w_, 
						x_);
                    var z_ = context?.Operators.FlattenList<Coding>(y_);
                    Func<Coding,bool?> ac_ = (LineCode) => 
                    {
                        var aa_ = LineCode?.CodeElement?.Value;
                        var ab_ = ClaimWithProcedure?.ProceduresAsStrings;
                        return context?.Operators.InList<string>(aa_, 
							ab_);
                    };
                    var ad_ = context?.Operators.WhereOrNull<Coding>(z_, 
						ac_);
                    var ae_ = context?.Operators.ExistsInList<Coding>(ad_);
                    var af_ = (ItemOnLine?.Procedure as IEnumerable<Claim.ProcedureComponent>);
                    Func<Claim.ProcedureComponent,bool?> ah_ = (@this) => 
                    {
                        bool? ag_ = ((bool?)(@this?.Procedure == null));
                        return context?.Operators.Not(ag_);
                    };
                    var ai_ = context?.Operators.WhereOrNull<Claim.ProcedureComponent>(af_, 
						ah_);
                    Func<Claim.ProcedureComponent,DataType> aj_ = (@this) => 
                    {
                        return @this?.Procedure;
                    };
                    var ak_ = context?.Operators.SelectOrNull<Claim.ProcedureComponent, DataType>(ai_, 
						aj_);
                    Func<DataType,bool?> an_ = (@this) => 
                    {
                        var am_ = (@this as object);
                        bool? al_ = ((bool?)(context?.Operators.LateBoundProperty<object>(am_, 
							"coding") == null));
                        return context?.Operators.Not(al_);
                    };
                    var ao_ = context?.Operators.WhereOrNull<DataType>(ak_, 
						an_);
                    Func<DataType,object> aq_ = (@this) => 
                    {
                        var ap_ = (@this as object);
                        return context?.Operators.LateBoundProperty<object>(ap_, 
							"coding");
                    };
                    var ar_ = context?.Operators.SelectOrNull<DataType, object>(ao_, 
						aq_);
                    var as_ = context?.Operators.FlattenLateBoundList(ar_);
                    Func<object,Coding> at_ = (@object) => (@object as Coding);
                    var au_ = context?.Operators.SelectOrNull<object, Coding>(as_, 
						at_);
                    Func<Coding,bool?> ax_ = (HeaderCode) => 
                    {
                        var av_ = HeaderCode?.CodeElement?.Value;
                        var aw_ = ClaimWithProcedure?.ProceduresAsStrings;
                        return context?.Operators.InList<string>(av_, 
							aw_);
                    };
                    var ay_ = context?.Operators.WhereOrNull<Coding>(au_, 
						ax_);
                    var az_ = context?.Operators.ExistsInList<Coding>(ay_);
                    return context?.Operators.Or(ae_, 
						az_);
                };
                var bb_ = context?.Operators.WhereOrNull<Claim>(m_, 
					ba_);
                var l_ = (((ClaimofInterest == null))
					? (null)
					: (context?.Operators.SingleOrNull<Claim>(bb_)))
;
                var j_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB
				{
					Claim = k_,
					ProcedureItems = l_,
				};
                var i_ = new Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB[]
				{
					j_,
				};
                Func<Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB,Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> cf_ = (DiagnosisCheck) => 
                {
                    var bd_ = DiagnosisCheck?.ProcedureItems;
                    var bc_ = new Claim[]
					{
						bd_,
					};
                    Func<Claim,Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> cd_ = (ClaimforDiagnosis) => 
                    {
                        var bg_ = (ClaimforDiagnosis?.Item as IEnumerable<Claim.ItemComponent>);
                        var bj_ = ClaimforDiagnosis;
                        var bi_ = new Claim[]
						{
							bj_,
						};
                        Func<Claim,bool?> bz_ = (RightClaim) => 
                        {
                            var bk_ = (RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>);
                            Func<Claim.DiagnosisComponent,bool?> bx_ = (RightDiagnosis) => 
                            {
                                var bm_ = (RightDiagnosis?.SequenceElement as object);
                                var bn_ = context?.Operators.Convert<Integer>(bm_);
                                var bl_ = (FHIRHelpers_4_0_001.ToInteger(bn_) as object);
                                var bo_ = (((int?)1) as object);
                                var bp_ = context?.Operators.Equal(bl_, 
									bo_);
                                var bq_ = (RightDiagnosis?.Diagnosis as object);
                                var br_ = context?.Operators.LateBoundProperty<IEnumerable<Coding>>(bq_, 
									"coding");
                                Func<Coding,bool?> bu_ = (DiagnosisCode) => 
                                {
                                    var bs_ = DiagnosisCode?.CodeElement?.Value;
                                    var bt_ = ClaimWithProcedure?.DiagnosesAsStrings;
                                    return context?.Operators.InList<string>(bs_, 
										bt_);
                                };
                                var bv_ = context?.Operators.WhereOrNull<Coding>(br_, 
									bu_);
                                var bw_ = context?.Operators.ExistsInList<Coding>(bv_);
                                return context?.Operators.And(bp_, 
									bw_);
                            };
                            var by_ = context?.Operators.WhereOrNull<Claim.DiagnosisComponent>(bk_, 
								bx_);
                            return context?.Operators.ExistsInList<Claim.DiagnosisComponent>(by_);
                        };
                        var ca_ = context?.Operators.WhereOrNull<Claim>(bi_, 
							bz_);
                        var bh_ = (((ClaimforDiagnosis == null))
							? (null)
							: (context?.Operators.SingleOrNull<Claim>(ca_)))
;
                        var bf_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI
						{
							Procedure = bg_,
							LineItems = bh_,
						};
                        var be_ = new Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI[]
						{
							bf_,
						};
                        Func<Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI,Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA> cb_ = (LineItemDefinition) => (((context?.Operators.And(context?.Operators.Not(((bool?)(LineItemDefinition == null))), 
								context?.Operators.Not(((bool?)(LineItemDefinition?.LineItems == null)))) ?? false))
								? (new Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA
									{
										Claim = LineItemDefinition?.LineItems,
										ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>((LineItemDefinition?.LineItems?.Item as IEnumerable<Claim.ItemComponent>), 
											(NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval((NormalDate?.Serviced as object))),
									})
								: ((null as Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA)))
;
                        var cc_ = context?.Operators.SelectOrNull<Tuples.Tuple_iUHcMLYFdMEcPJJeOVJdQjbI, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(be_, 
							cb_);
                        return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(cc_);
                    };
                    var ce_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(bc_, 
						cd_);
                    return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ce_);
                };
                var cg_ = context?.Operators.SelectOrNull<Tuples.Tuple_CIIbRNfJieBVcNIWHEUWMVhOB, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(i_, 
					cf_);
                return context?.Operators.SingleOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(cg_);
            };
            var ci_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(h_, 
				ch_);
            Func<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA,bool?> ck_ = (FinalList) => 
            {
                bool? cj_ = ((bool?)(FinalList == null));
                return context?.Operators.Not(cj_);
            };
            return context?.Operators.WhereOrNull<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>(ci_, 
				ck_);
        };
        var cm_ = context?.Operators.SelectOrNull<Tuples.Tuple_EUYHPiEZNTBOHPgZNKhGAORRb, IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(a_, 
			cl_);
        return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_DTeHhjMPXBSEFRBcdiBHhKQDA>>(cm_);
    }

    [CqlDeclaration("Medical Claims With Principal Diagnosis")]
    public IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> Medical_Claims_With_Principal_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        var c_ = this.Professional_or_Institutional_Claims(claim);
        Func<CqlCode,string> e_ = (d) => 
        {
            return d?.code;
        };
        var d_ = context?.Operators.SelectOrNull<CqlCode, string>(DiagnosisValueSet, 
			e_);
        var b_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX
		{
			MedicalClaim = c_,
			DiagnosesAsStrings = d_,
		};
        var a_ = new Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX[]
		{
			b_,
		};
        Func<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX,IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>> ag_ = (ClaimWithDiagnosis) => 
        {
            var i_ = ClaimWithDiagnosis?.MedicalClaim;
            Func<Claim,bool?> y_ = (RightClaim) => 
            {
                var j_ = (RightClaim?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>);
                Func<Claim.DiagnosisComponent,bool?> w_ = (RightDiagnosis) => 
                {
                    var l_ = (RightDiagnosis?.SequenceElement as object);
                    var m_ = context?.Operators.Convert<Integer>(l_);
                    var k_ = (FHIRHelpers_4_0_001.ToInteger(m_) as object);
                    var n_ = (((int?)1) as object);
                    var o_ = context?.Operators.Equal(k_, 
						n_);
                    var p_ = (RightDiagnosis?.Diagnosis as object);
                    var q_ = context?.Operators.LateBoundProperty<IEnumerable<Coding>>(p_, 
						"coding");
                    Func<Coding,bool?> t_ = (DiagnosisCode) => 
                    {
                        var r_ = DiagnosisCode?.CodeElement?.Value;
                        var s_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                        return context?.Operators.InList<string>(r_, 
							s_);
                    };
                    var u_ = context?.Operators.WhereOrNull<Coding>(q_, 
						t_);
                    var v_ = context?.Operators.ExistsInList<Coding>(u_);
                    return context?.Operators.And(o_, 
						v_);
                };
                var x_ = context?.Operators.WhereOrNull<Claim.DiagnosisComponent>(j_, 
					w_);
                return context?.Operators.ExistsInList<Claim.DiagnosisComponent>(x_);
            };
            var h_ = (((ClaimWithDiagnosis?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(i_, 
						y_)))
;
            var g_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN
			{
				LineItems = h_,
			};
            var f_ = new Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN[]
			{
				g_,
			};
            Func<Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN,IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>> ae_ = (LineItemDefinition) => 
            {
                var z_ = LineItemDefinition?.LineItems;
                Func<Claim,Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI> aa_ = (ClaimWithDiagnosis) => (((context?.Operators.Not(((bool?)(ClaimWithDiagnosis == null))) ?? false))
						? (new Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI
							{
								Claim = LineItemDefinition?.LineItems,
								ServicePeriod = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(context?.Operators.FlattenList<Claim.ItemComponent>(context?.Operators.SelectOrNull<Claim, List<Claim.ItemComponent>>(context?.Operators.WhereOrNull<Claim>(LineItemDefinition?.LineItems, 
												(@this) => context?.Operators.Not(((bool?)(@this?.Item == null)))), 
											(@this) => @this?.Item)), 
									(NormalDate) => NCQAFHIRBase_1_0_0.Normalize_Interval((NormalDate?.Serviced as object))),
							})
						: ((null as Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI)))
;
                var ab_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(z_, 
					aa_);
                Func<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI,bool?> ad_ = (FinalList) => 
                {
                    bool? ac_ = ((bool?)(FinalList == null));
                    return context?.Operators.Not(ac_);
                };
                return context?.Operators.WhereOrNull<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>(ab_, 
					ad_);
            };
            var af_ = context?.Operators.SelectOrNull<Tuples.Tuple_FADJTWQjaQgiVVcFZjGXbPFbN, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(f_, 
				ae_);
            return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(af_);
        };
        var ah_ = context?.Operators.SelectOrNull<Tuples.Tuple_HGJgSEUEXcXLiIPXgcJWiVdUX, IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(a_, 
			ag_);
        return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_HLLRUdKceDPKeIXGFiiNKjMKI>>(ah_);
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
        Func<ClaimResponse,bool?> i_ = (ResponseItem) => 
        {
            var d_ = (ResponseItem?.OutcomeElement as object);
            var e_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(d_);
            var g_ = "complete";
            var h_ = "partial";
            var f_ = (new string[]
			{
				g_,
				h_,
			} as IEnumerable<string>);
            return context?.Operators.InList<string>(e_, 
				f_);
        };
        var c_ = context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, 
			i_);
        var b_ = new Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD
		{
			PaidResponse = c_,
		};
        var a_ = new Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD[]
		{
			b_,
		};
        Func<Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD,IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>> av_ = (ClaimResponse) => 
        {
            var j_ = ClaimResponse?.PaidResponse;
            Func<ClaimResponse,Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> au_ = (ClmResp) => 
            {
                var k_ = ClmResp;
                var m_ = (ClmResp?.Request?.ReferenceElement as object);
                var n_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(m_);
                var l_ = NCQAFHIRBase_1_0_0.GetId(n_);
                var p_ = (ClmResp?.Item as IEnumerable<ClaimResponse.ItemComponent>);
                Func<ClaimResponse.ItemComponent,bool?> at_ = (ResponseItem) => 
                {
                    var q_ = ResponseItem?.Adjudication;
                    Func<ClaimResponse.AdjudicationComponent,bool?> s_ = (@this) => 
                    {
                        bool? r_ = ((bool?)(@this?.Category == null));
                        return context?.Operators.Not(r_);
                    };
                    var t_ = context?.Operators.WhereOrNull<ClaimResponse.AdjudicationComponent>(q_, 
						s_);
                    Func<ClaimResponse.AdjudicationComponent,CodeableConcept> u_ = (@this) => 
                    {
                        return @this?.Category;
                    };
                    var v_ = context?.Operators.SelectOrNull<ClaimResponse.AdjudicationComponent, CodeableConcept>(t_, 
						u_);
                    Func<CodeableConcept,bool?> x_ = (@this) => 
                    {
                        bool? w_ = ((bool?)(@this?.Coding == null));
                        return context?.Operators.Not(w_);
                    };
                    var y_ = context?.Operators.WhereOrNull<CodeableConcept>(v_, 
						x_);
                    Func<CodeableConcept,List<Coding>> z_ = (@this) => 
                    {
                        return @this?.Coding;
                    };
                    var aa_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(y_, 
						z_);
                    var ab_ = context?.Operators.FlattenList<Coding>(aa_);
                    Func<Coding,bool?> ae_ = (CategoryItem) => 
                    {
                        var ac_ = (CategoryItem?.CodeElement?.Value as object);
                        var ad_ = ("benefit" as object);
                        return context?.Operators.Equal(ac_, 
							ad_);
                    };
                    var af_ = context?.Operators.WhereOrNull<Coding>(ab_, 
						ae_);
                    var ag_ = context?.Operators.ExistsInList<Coding>(af_);
                    Func<ClaimResponse.AdjudicationComponent,bool?> aj_ = (@this) => 
                    {
                        bool? ai_ = ((bool?)(@this?.Amount == null));
                        return context?.Operators.Not(ai_);
                    };
                    var ak_ = context?.Operators.WhereOrNull<ClaimResponse.AdjudicationComponent>(q_, 
						aj_);
                    Func<ClaimResponse.AdjudicationComponent,Money> al_ = (@this) => 
                    {
                        return @this?.Amount;
                    };
                    var am_ = context?.Operators.SelectOrNull<ClaimResponse.AdjudicationComponent, Money>(ak_, 
						al_);
                    Func<Money,bool?> aq_ = (DollarAmount) => 
                    {
                        var ao_ = DollarAmount?.ValueElement;
                        var an_ = (FHIRHelpers_4_0_001.ToDecimal(ao_) as object);
                        var ap_ = (context?.Operators.ConvertIntegerToDecimal(((int?)0)) as object);
                        return context?.Operators.Greater(an_, 
							ap_);
                    };
                    var ar_ = context?.Operators.WhereOrNull<Money>(am_, 
						aq_);
                    var as_ = context?.Operators.ExistsInList<Money>(ar_);
                    return context?.Operators.And(ag_, 
						as_);
                };
                var o_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(p_, 
					at_);
                return new Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL
				{
					Response = k_,
					ResponseID = l_,
					LineItems = o_,
				};
            };
            return context?.Operators.SelectOrNull<ClaimResponse, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(j_, 
				au_);
        };
        var aw_ = context?.Operators.SelectOrNull<Tuples.Tuple_GRhdjhBUGcJfFRBeODDiYLCdD, IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(a_, 
			av_);
        return context?.Operators.SingleOrNull<IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>>(aw_);
    }

    [CqlDeclaration("Get All Claims With Procedure and Diagnosis")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_and_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        Func<Claim,bool?> ak_ = (AllClaims) => 
        {
            var a_ = AllClaims?.Item;
            Func<Claim.ItemComponent,bool?> c_ = (@this) => 
            {
                bool? b_ = ((bool?)(@this?.ProductOrService == null));
                return context?.Operators.Not(b_);
            };
            var d_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(a_, 
				c_);
            Func<Claim.ItemComponent,CodeableConcept> e_ = (@this) => 
            {
                return @this?.ProductOrService;
            };
            var f_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(d_, 
				e_);
            Func<CodeableConcept,bool?> h_ = (@this) => 
            {
                bool? g_ = ((bool?)(@this?.Coding == null));
                return context?.Operators.Not(g_);
            };
            var i_ = context?.Operators.WhereOrNull<CodeableConcept>(f_, 
				h_);
            Func<CodeableConcept,List<Coding>> j_ = (@this) => 
            {
                return @this?.Coding;
            };
            var k_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(i_, 
				j_);
            var l_ = context?.Operators.FlattenList<Coding>(k_);
            Func<Coding,bool?> n_ = (ProductOrServiceCode) => 
            {
                var m_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
                return context?.Operators.CodeInList(m_, 
					ProductOrServiceValueSet);
            };
            var o_ = context?.Operators.WhereOrNull<Coding>(l_, 
				n_);
            var p_ = context?.Operators.ExistsInList<Coding>(o_);
            var q_ = (AllClaims?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>);
            Func<Claim.DiagnosisComponent,bool?> s_ = (@this) => 
            {
                bool? r_ = ((bool?)(@this?.Diagnosis == null));
                return context?.Operators.Not(r_);
            };
            var t_ = context?.Operators.WhereOrNull<Claim.DiagnosisComponent>(q_, 
				s_);
            Func<Claim.DiagnosisComponent,DataType> u_ = (@this) => 
            {
                return @this?.Diagnosis;
            };
            var v_ = context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(t_, 
				u_);
            Func<DataType,bool?> y_ = (@this) => 
            {
                var x_ = (@this as object);
                bool? w_ = ((bool?)(context?.Operators.LateBoundProperty<object>(x_, 
					"coding") == null));
                return context?.Operators.Not(w_);
            };
            var z_ = context?.Operators.WhereOrNull<DataType>(v_, 
				y_);
            Func<DataType,object> ab_ = (@this) => 
            {
                var aa_ = (@this as object);
                return context?.Operators.LateBoundProperty<object>(aa_, 
					"coding");
            };
            var ac_ = context?.Operators.SelectOrNull<DataType, object>(z_, 
				ab_);
            var ad_ = context?.Operators.FlattenLateBoundList(ac_);
            Func<object,Coding> ae_ = (@object) => (@object as Coding);
            var af_ = context?.Operators.SelectOrNull<object, Coding>(ad_, 
				ae_);
            Func<Coding,bool?> ah_ = (DiagnosisCode) => 
            {
                var ag_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
                return context?.Operators.CodeInList(ag_, 
					DiagnosisValueSet);
            };
            var ai_ = context?.Operators.WhereOrNull<Coding>(af_, 
				ah_);
            var aj_ = context?.Operators.ExistsInList<Coding>(ai_);
            return context?.Operators.And(p_, 
				aj_);
        };
        var al_ = context?.Operators.WhereOrNull<Claim>(claim, 
			ak_);
        Func<Claim,Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> av_ = (ProcedureClaims) => 
        {
            var am_ = ProcedureClaims;
            var an_ = ProcedureClaims?.IdElement;
            var ap_ = (ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>);
            Func<Claim.ItemComponent,bool?> au_ = (ResponseItem) => 
            {
                var aq_ = (ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>);
                Func<Coding,bool?> as_ = (ProductOrServiceCode) => 
                {
                    var ar_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
                    return context?.Operators.CodeInList(ar_, 
						ProductOrServiceValueSet);
                };
                var at_ = context?.Operators.WhereOrNull<Coding>(aq_, 
					as_);
                return context?.Operators.ExistsInList<Coding>(at_);
            };
            var ao_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(ap_, 
				au_);
            return new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = am_,
				ClaimID = an_,
				LineItems = ao_,
			};
        };
        return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(al_, 
			av_);
    }

    [CqlDeclaration("Get Corresponding Claim for Services and Conditions")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_and_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        var c_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
        var d_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(claim, 
			ProductOrServiceValueSet, 
			DiagnosisValueSet);
        var b_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = c_,
			MedicalClaim = d_,
		};
        var a_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			b_,
		};
        Func<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ,Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO> bj_ = (ClaimAndResponse) => 
        {
            var h_ = ClaimAndResponse?.MedicalClaim;
            Func<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM,Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> ae_ = (medClaim) => 
            {
                var i_ = medClaim;
                var k_ = medClaim?.LineItems;
                Func<Claim.ItemComponent,bool?> ad_ = (medClaimLineItem) => 
                {
                    var l_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    Func<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL,IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>> ab_ = (pClaim) => 
                    {
                        var m_ = pClaim?.LineItems;
                        Func<ClaimResponse.ItemComponent,bool?> y_ = (pClaimLineItem) => 
                        {
                            var o_ = (((medClaim?.ClaimofInterest is Resource)
								? ((medClaim?.ClaimofInterest as Resource)?.IdElement)
								: (null))
 as object);
                            var n_ = ((context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(o_) as object);
                            var q_ = (pClaim?.Response?.Request?.ReferenceElement as object);
                            var r_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(q_);
                            var p_ = (NCQAFHIRBase_1_0_0.GetId(r_) as object);
                            var s_ = context?.Operators.Equal(n_, 
								p_);
                            var u_ = (medClaimLineItem?.SequenceElement as object);
                            var t_ = (context?.Operators.Convert<Integer>(u_) as object);
                            var w_ = (pClaimLineItem?.ItemSequenceElement as object);
                            var v_ = (context?.Operators.Convert<Integer>(w_) as object);
                            var x_ = context?.Operators.Equal(t_, 
								v_);
                            return context?.Operators.And(s_, 
								x_);
                        };
                        var z_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(m_, 
							y_);
                        Func<ClaimResponse.ItemComponent,Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> aa_ = (pClaimLineItem) => pClaim;
                        return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, 
							aa_);
                    };
                    var ac_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(l_, 
						ab_);
                    return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ac_);
                };
                var j_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(k_, 
					ad_);
                return new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = i_,
					ClaimItem = j_,
				};
            };
            var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(h_, 
				ae_);
            var f_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = g_,
			};
            var e_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				f_,
			};
            Func<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD,Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO> bh_ = (ClaimWithPaidResponse) => 
            {
                var ah_ = ClaimWithPaidResponse?.AggregateClaim;
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,bool?> aj_ = (@this) => 
                {
                    bool? ai_ = ((bool?)(@this?.ClaimItem == null));
                    return context?.Operators.Not(ai_);
                };
                var ak_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ah_, 
					aj_);
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,IEnumerable<Claim.ItemComponent>> al_ = (@this) => 
                {
                    return @this?.ClaimItem;
                };
                var am_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(ak_, 
					al_);
                var an_ = context?.Operators.FlattenList<Claim.ItemComponent>(am_);
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,bool?> ar_ = (@this) => 
                {
                    bool? aq_ = ((bool?)(@this?.PaidClaim == null));
                    return context?.Operators.Not(aq_);
                };
                var as_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ah_, 
					ar_);
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> at_ = (@this) => 
                {
                    return @this?.PaidClaim;
                };
                var ao_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(as_, 
					at_);
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,bool?> ax_ = (@this) => 
                {
                    bool? aw_ = ((bool?)(@this?.ClaimItem == null));
                    return context?.Operators.Not(aw_);
                };
                var ay_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ah_, 
					ax_);
                var ba_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(ay_, 
					al_);
                var bb_ = context?.Operators.FlattenList<Claim.ItemComponent>(ba_);
                Func<Claim.ItemComponent,CqlInterval<CqlDateTime>> bd_ = (PaidItem) => 
                {
                    var bc_ = (PaidItem?.Serviced as object);
                    return NCQAFHIRBase_1_0_0.Normalize_Interval(bc_);
                };
                var au_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, 
					bd_);
                var ag_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(an_) ?? false))
					? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = ao_,
							ServicePeriod = au_,
						})
					: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
;
                var af_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ag_,
				};
                Func<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO,bool?> bf_ = (FinalList) => 
                {
                    bool? be_ = ((bool?)(FinalList == null));
                    return context?.Operators.Not(be_);
                };
                var bg_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(af_, 
					bf_);
                return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bg_);
            };
            var bi_ = context?.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(e_, 
				bh_);
            return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bi_);
        };
        var bk_ = context?.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(a_, 
			bj_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bk_);
    }

    [CqlDeclaration("Get Paid Claims for Provided Service and Condition")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Service_and_Condition(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        var d_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, 
			claim);
        var c_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			d_,
		};
        Func<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM,Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO> e_ = (MedicalClaimAndResponse) => (((context?.Operators.And(((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse == null)), 
((bool?)(MedicalClaimAndResponse?.MedicalClaim == null))) ?? false))
				? ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))
				: (this.Get_Corresponding_Claim_for_Services_and_Conditions(MedicalClaimAndResponse?.MedicalClaimResponse, 
MedicalClaimAndResponse?.MedicalClaim, 
						ProductOrServiceValueSet, 
						DiagnosisValueSet)))
;
        var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(c_, 
			e_);
        var b_ = context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(f_);
        var a_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
		{
			b_,
		};
        Func<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO,bool?> h_ = (FinalList) => 
        {
            bool? g_ = ((bool?)(FinalList == null));
            return context?.Operators.Not(g_);
        };
        var i_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(a_, 
			h_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(i_);
    }

    [CqlDeclaration("Get All Claims With Procedure or Diagnosis")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_or_Diagnosis(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        Func<Claim,bool?> ak_ = (AllClaims) => 
        {
            var a_ = AllClaims?.Item;
            Func<Claim.ItemComponent,bool?> c_ = (@this) => 
            {
                bool? b_ = ((bool?)(@this?.ProductOrService == null));
                return context?.Operators.Not(b_);
            };
            var d_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(a_, 
				c_);
            Func<Claim.ItemComponent,CodeableConcept> e_ = (@this) => 
            {
                return @this?.ProductOrService;
            };
            var f_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(d_, 
				e_);
            Func<CodeableConcept,bool?> h_ = (@this) => 
            {
                bool? g_ = ((bool?)(@this?.Coding == null));
                return context?.Operators.Not(g_);
            };
            var i_ = context?.Operators.WhereOrNull<CodeableConcept>(f_, 
				h_);
            Func<CodeableConcept,List<Coding>> j_ = (@this) => 
            {
                return @this?.Coding;
            };
            var k_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(i_, 
				j_);
            var l_ = context?.Operators.FlattenList<Coding>(k_);
            Func<Coding,bool?> n_ = (ProductOrServiceCode) => 
            {
                var m_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
                return context?.Operators.CodeInList(m_, 
					ProductOrServiceValueSet);
            };
            var o_ = context?.Operators.WhereOrNull<Coding>(l_, 
				n_);
            var p_ = context?.Operators.ExistsInList<Coding>(o_);
            var q_ = (AllClaims?.Diagnosis as IEnumerable<Claim.DiagnosisComponent>);
            Func<Claim.DiagnosisComponent,bool?> s_ = (@this) => 
            {
                bool? r_ = ((bool?)(@this?.Diagnosis == null));
                return context?.Operators.Not(r_);
            };
            var t_ = context?.Operators.WhereOrNull<Claim.DiagnosisComponent>(q_, 
				s_);
            Func<Claim.DiagnosisComponent,DataType> u_ = (@this) => 
            {
                return @this?.Diagnosis;
            };
            var v_ = context?.Operators.SelectOrNull<Claim.DiagnosisComponent, DataType>(t_, 
				u_);
            Func<DataType,bool?> y_ = (@this) => 
            {
                var x_ = (@this as object);
                bool? w_ = ((bool?)(context?.Operators.LateBoundProperty<object>(x_, 
					"coding") == null));
                return context?.Operators.Not(w_);
            };
            var z_ = context?.Operators.WhereOrNull<DataType>(v_, 
				y_);
            Func<DataType,object> ab_ = (@this) => 
            {
                var aa_ = (@this as object);
                return context?.Operators.LateBoundProperty<object>(aa_, 
					"coding");
            };
            var ac_ = context?.Operators.SelectOrNull<DataType, object>(z_, 
				ab_);
            var ad_ = context?.Operators.FlattenLateBoundList(ac_);
            Func<object,Coding> ae_ = (@object) => (@object as Coding);
            var af_ = context?.Operators.SelectOrNull<object, Coding>(ad_, 
				ae_);
            Func<Coding,bool?> ah_ = (DiagnosisCode) => 
            {
                var ag_ = FHIRHelpers_4_0_001.ToCode(DiagnosisCode);
                return context?.Operators.CodeInList(ag_, 
					DiagnosisValueSet);
            };
            var ai_ = context?.Operators.WhereOrNull<Coding>(af_, 
				ah_);
            var aj_ = context?.Operators.ExistsInList<Coding>(ai_);
            return context?.Operators.Or(p_, 
				aj_);
        };
        var al_ = context?.Operators.WhereOrNull<Claim>(claim, 
			ak_);
        Func<Claim,Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> am_ = (ProcedureClaims) => (((context?.Operators.ExistsInList<Claim.ItemComponent>(context?.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), 
					(ResponseItem) => context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), 
								(ProductOrServiceCode) => context?.Operators.CodeInList(FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode), 
										ProductOrServiceValueSet))))) ?? false))
				? (new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
					{
						ClaimofInterest = ProcedureClaims,
						ClaimID = ProcedureClaims?.IdElement,
						LineItems = context?.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), 
							(ResponseItem) => context?.Operators.ExistsInList<Coding>(context?.Operators.WhereOrNull<Coding>((ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>), 
										(ProductOrServiceCode) => context?.Operators.CodeInList(FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode), 
												ProductOrServiceValueSet)))),
					})
				: (new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
					{
						ClaimofInterest = ProcedureClaims,
						ClaimID = ProcedureClaims?.IdElement,
						LineItems = context?.Operators.WhereOrNull<Claim.ItemComponent>((ProcedureClaims?.Item as IEnumerable<Claim.ItemComponent>), 
							(ResponseItem) => context?.Operators.Equal(((context?.Operators.Convert<Integer>((ResponseItem?.SequenceElement as object)))?.Value as object), 
(((int?)1) as object))),
					}))
;
        return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(al_, 
			am_);
    }

    [CqlDeclaration("Get Corresponding Claim for Services or Conditions")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        var c_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
        var d_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(claim, 
			ProductOrServiceValueSet, 
			DiagnosisValueSet);
        var b_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = c_,
			MedicalClaim = d_,
		};
        var a_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			b_,
		};
        Func<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ,Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO> bj_ = (ClaimAndResponse) => 
        {
            var h_ = ClaimAndResponse?.MedicalClaim;
            Func<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM,Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> ae_ = (medClaim) => 
            {
                var i_ = medClaim;
                var k_ = medClaim?.LineItems;
                Func<Claim.ItemComponent,bool?> ad_ = (medClaimLineItem) => 
                {
                    var l_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    Func<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL,IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>> ab_ = (pClaim) => 
                    {
                        var m_ = pClaim?.LineItems;
                        Func<ClaimResponse.ItemComponent,bool?> y_ = (pClaimLineItem) => 
                        {
                            var o_ = (((medClaim?.ClaimofInterest is Resource)
								? ((medClaim?.ClaimofInterest as Resource)?.IdElement)
								: (null))
 as object);
                            var n_ = ((context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(o_) as object);
                            var q_ = (pClaim?.Response?.Request?.ReferenceElement as object);
                            var r_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(q_);
                            var p_ = (NCQAFHIRBase_1_0_0.GetId(r_) as object);
                            var s_ = context?.Operators.Equal(n_, 
								p_);
                            var u_ = (medClaimLineItem?.SequenceElement as object);
                            var t_ = (context?.Operators.Convert<Integer>(u_) as object);
                            var w_ = (pClaimLineItem?.ItemSequenceElement as object);
                            var v_ = (context?.Operators.Convert<Integer>(w_) as object);
                            var x_ = context?.Operators.Equal(t_, 
								v_);
                            return context?.Operators.And(s_, 
								x_);
                        };
                        var z_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(m_, 
							y_);
                        Func<ClaimResponse.ItemComponent,Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> aa_ = (pClaimLineItem) => pClaim;
                        return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, 
							aa_);
                    };
                    var ac_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(l_, 
						ab_);
                    return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ac_);
                };
                var j_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(k_, 
					ad_);
                return new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = i_,
					ClaimItem = j_,
				};
            };
            var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(h_, 
				ae_);
            var f_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = g_,
			};
            var e_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				f_,
			};
            Func<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD,Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO> bh_ = (ClaimWithPaidResponse) => 
            {
                var ah_ = ClaimWithPaidResponse?.AggregateClaim;
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,bool?> aj_ = (@this) => 
                {
                    bool? ai_ = ((bool?)(@this?.ClaimItem == null));
                    return context?.Operators.Not(ai_);
                };
                var ak_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ah_, 
					aj_);
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,IEnumerable<Claim.ItemComponent>> al_ = (@this) => 
                {
                    return @this?.ClaimItem;
                };
                var am_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(ak_, 
					al_);
                var an_ = context?.Operators.FlattenList<Claim.ItemComponent>(am_);
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,bool?> ar_ = (@this) => 
                {
                    bool? aq_ = ((bool?)(@this?.PaidClaim == null));
                    return context?.Operators.Not(aq_);
                };
                var as_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ah_, 
					ar_);
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> at_ = (@this) => 
                {
                    return @this?.PaidClaim;
                };
                var ao_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(as_, 
					at_);
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,bool?> ax_ = (@this) => 
                {
                    bool? aw_ = ((bool?)(@this?.ClaimItem == null));
                    return context?.Operators.Not(aw_);
                };
                var ay_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ah_, 
					ax_);
                var ba_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(ay_, 
					al_);
                var bb_ = context?.Operators.FlattenList<Claim.ItemComponent>(ba_);
                Func<Claim.ItemComponent,CqlInterval<CqlDateTime>> bd_ = (PaidItem) => 
                {
                    var bc_ = (PaidItem?.Serviced as object);
                    return NCQAFHIRBase_1_0_0.Normalize_Interval(bc_);
                };
                var au_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, 
					bd_);
                var ag_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(an_) ?? false))
					? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = ao_,
							ServicePeriod = au_,
						})
					: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
;
                var af_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ag_,
				};
                Func<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO,bool?> bf_ = (FinalList) => 
                {
                    bool? be_ = ((bool?)(FinalList == null));
                    return context?.Operators.Not(be_);
                };
                var bg_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(af_, 
					bf_);
                return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bg_);
            };
            var bi_ = context?.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(e_, 
				bh_);
            return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bi_);
        };
        var bk_ = context?.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(a_, 
			bj_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bk_);
    }

    [CqlDeclaration("Get Paid Claims for Provided Services or Conditions")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_or_Conditions(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        var b_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, 
			claim);
        var a_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			b_,
		};
        Func<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM,Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO> c_ = (MedicalClaimAndResponse) => (((context?.Operators.And(((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse == null)), 
((bool?)(MedicalClaimAndResponse?.MedicalClaim == null))) ?? false))
				? ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))
				: (this.Get_Corresponding_Claim_for_Services_or_Conditions(MedicalClaimAndResponse?.MedicalClaimResponse, 
MedicalClaimAndResponse?.MedicalClaim, 
						ProductOrServiceValueSet, 
						DiagnosisValueSet)))
;
        var d_ = context?.Operators.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(a_, 
			c_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(d_);
    }

    [CqlDeclaration("Get All Claims With Procedure Only")]
    public IEnumerable<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> Get_All_Claims_With_Procedure_Only(IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        Func<Claim,bool?> p_ = (AllClaims) => 
        {
            var a_ = AllClaims?.Item;
            Func<Claim.ItemComponent,bool?> c_ = (@this) => 
            {
                bool? b_ = ((bool?)(@this?.ProductOrService == null));
                return context?.Operators.Not(b_);
            };
            var d_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(a_, 
				c_);
            Func<Claim.ItemComponent,CodeableConcept> e_ = (@this) => 
            {
                return @this?.ProductOrService;
            };
            var f_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CodeableConcept>(d_, 
				e_);
            Func<CodeableConcept,bool?> h_ = (@this) => 
            {
                bool? g_ = ((bool?)(@this?.Coding == null));
                return context?.Operators.Not(g_);
            };
            var i_ = context?.Operators.WhereOrNull<CodeableConcept>(f_, 
				h_);
            Func<CodeableConcept,List<Coding>> j_ = (@this) => 
            {
                return @this?.Coding;
            };
            var k_ = context?.Operators.SelectOrNull<CodeableConcept, List<Coding>>(i_, 
				j_);
            var l_ = context?.Operators.FlattenList<Coding>(k_);
            Func<Coding,bool?> n_ = (ProductOrServiceCode) => 
            {
                var m_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
                return context?.Operators.CodeInList(m_, 
					ProductOrServiceValueSet);
            };
            var o_ = context?.Operators.WhereOrNull<Coding>(l_, 
				n_);
            return context?.Operators.ExistsInList<Coding>(o_);
        };
        var q_ = context?.Operators.WhereOrNull<Claim>(claim, 
			p_);
        Func<Claim,Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> aa_ = (AllClaims) => 
        {
            var r_ = AllClaims;
            var s_ = AllClaims?.IdElement;
            var u_ = (AllClaims?.Item as IEnumerable<Claim.ItemComponent>);
            Func<Claim.ItemComponent,bool?> z_ = (ResponseItem) => 
            {
                var v_ = (ResponseItem?.ProductOrService?.Coding as IEnumerable<Coding>);
                Func<Coding,bool?> x_ = (ProductOrServiceCode) => 
                {
                    var w_ = FHIRHelpers_4_0_001.ToCode(ProductOrServiceCode);
                    return context?.Operators.CodeInList(w_, 
						ProductOrServiceValueSet);
                };
                var y_ = context?.Operators.WhereOrNull<Coding>(v_, 
					x_);
                return context?.Operators.ExistsInList<Coding>(y_);
            };
            var t_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(u_, 
				z_);
            return new Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM
			{
				ClaimofInterest = r_,
				ClaimID = s_,
				LineItems = t_,
			};
        };
        return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(q_, 
			aa_);
    }

    [CqlDeclaration("Get Corresponding Claim for Services Only")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Corresponding_Claim_for_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        var c_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
        var d_ = this.Get_All_Claims_With_Procedure_Only(claim, 
			ProductOrServiceValueSet);
        var b_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ
		{
			PaidMedicalClaimResponse = c_,
			MedicalClaim = d_,
		};
        var a_ = new Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ[]
		{
			b_,
		};
        Func<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ,Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO> bj_ = (ClaimAndResponse) => 
        {
            var h_ = ClaimAndResponse?.MedicalClaim;
            Func<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM,Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg> ae_ = (medClaim) => 
            {
                var i_ = medClaim;
                var k_ = medClaim?.LineItems;
                Func<Claim.ItemComponent,bool?> ad_ = (medClaimLineItem) => 
                {
                    var l_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    Func<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL,IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>> ab_ = (pClaim) => 
                    {
                        var m_ = pClaim?.LineItems;
                        Func<ClaimResponse.ItemComponent,bool?> y_ = (pClaimLineItem) => 
                        {
                            var o_ = (((medClaim?.ClaimofInterest is Resource)
								? ((medClaim?.ClaimofInterest as Resource)?.IdElement)
								: (null))
 as object);
                            var n_ = ((context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(o_) as object);
                            var q_ = (pClaim?.Response?.Request?.ReferenceElement as object);
                            var r_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(q_);
                            var p_ = (NCQAFHIRBase_1_0_0.GetId(r_) as object);
                            var s_ = context?.Operators.Equal(n_, 
								p_);
                            var u_ = (medClaimLineItem?.SequenceElement as object);
                            var t_ = (context?.Operators.Convert<Integer>(u_) as object);
                            var w_ = (pClaimLineItem?.ItemSequenceElement as object);
                            var v_ = (context?.Operators.Convert<Integer>(w_) as object);
                            var x_ = context?.Operators.Equal(t_, 
								v_);
                            return context?.Operators.And(s_, 
								x_);
                        };
                        var z_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(m_, 
							y_);
                        Func<ClaimResponse.ItemComponent,Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> aa_ = (pClaimLineItem) => pClaim;
                        return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, 
							aa_);
                    };
                    var ac_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(l_, 
						ab_);
                    return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ac_);
                };
                var j_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(k_, 
					ad_);
                return new Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg
				{
					PaidClaim = i_,
					ClaimItem = j_,
				};
            };
            var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM, Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(h_, 
				ae_);
            var f_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD
			{
				AggregateClaim = g_,
			};
            var e_ = new Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD[]
			{
				f_,
			};
            Func<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD,Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO> bh_ = (ClaimWithPaidResponse) => 
            {
                var ah_ = ClaimWithPaidResponse?.AggregateClaim;
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,bool?> aj_ = (@this) => 
                {
                    bool? ai_ = ((bool?)(@this?.ClaimItem == null));
                    return context?.Operators.Not(ai_);
                };
                var ak_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ah_, 
					aj_);
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,IEnumerable<Claim.ItemComponent>> al_ = (@this) => 
                {
                    return @this?.ClaimItem;
                };
                var am_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(ak_, 
					al_);
                var an_ = context?.Operators.FlattenList<Claim.ItemComponent>(am_);
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,bool?> ar_ = (@this) => 
                {
                    bool? aq_ = ((bool?)(@this?.PaidClaim == null));
                    return context?.Operators.Not(aq_);
                };
                var as_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ah_, 
					ar_);
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM> at_ = (@this) => 
                {
                    return @this?.PaidClaim;
                };
                var ao_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, Tuples.Tuple_DXaYeZVOEAELKIhLMVHZBeASM>(as_, 
					at_);
                Func<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg,bool?> ax_ = (@this) => 
                {
                    bool? aw_ = ((bool?)(@this?.ClaimItem == null));
                    return context?.Operators.Not(aw_);
                };
                var ay_ = context?.Operators.WhereOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg>(ah_, 
					ax_);
                var ba_ = context?.Operators.SelectOrNull<Tuples.Tuple_CAKcSTUVVXcPjYRXATiiRAEMg, IEnumerable<Claim.ItemComponent>>(ay_, 
					al_);
                var bb_ = context?.Operators.FlattenList<Claim.ItemComponent>(ba_);
                Func<Claim.ItemComponent,CqlInterval<CqlDateTime>> bd_ = (PaidItem) => 
                {
                    var bc_ = (PaidItem?.Serviced as object);
                    return NCQAFHIRBase_1_0_0.Normalize_Interval(bc_);
                };
                var au_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, 
					bd_);
                var ag_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(an_) ?? false))
					? (new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO
						{
							originalClaim = ao_,
							ServicePeriod = au_,
						})
					: ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO)))
;
                var af_ = new Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO[]
				{
					ag_,
				};
                Func<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO,bool?> bf_ = (FinalList) => 
                {
                    bool? be_ = ((bool?)(FinalList == null));
                    return context?.Operators.Not(be_);
                };
                var bg_ = context?.Operators.WhereOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(af_, 
					bf_);
                return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bg_);
            };
            var bi_ = context?.Operators.SelectOrNull<Tuples.Tuple_CTafBejCOJKDPBQMRaUKGZGDD, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(e_, 
				bh_);
            return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bi_);
        };
        var bk_ = context?.Operators.SelectOrNull<Tuples.Tuple_ELXXNjRZXJcQDXjEEQXFeNQKZ, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(a_, 
			bj_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(bk_);
    }

    [CqlDeclaration("Get Paid Claims for Provided Services Only")]
    public Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO Get_Paid_Claims_for_Provided_Services_Only(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        var b_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(claimResponse, 
			claim);
        var a_ = new Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM[]
		{
			b_,
		};
        Func<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM,Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO> c_ = (MedicalClaimAndResponse) => (((context?.Operators.And(((bool?)(MedicalClaimAndResponse?.MedicalClaimResponse == null)), 
((bool?)(MedicalClaimAndResponse?.MedicalClaim == null))) ?? false))
				? ((null as Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO))
				: (this.Get_Corresponding_Claim_for_Services_Only(MedicalClaimAndResponse?.MedicalClaimResponse, 
MedicalClaimAndResponse?.MedicalClaim, 
						ProductOrServiceValueSet)))
;
        var d_ = context?.Operators.SelectOrNull<Tuples.Tuple_GjTATZbNccdVYWChGHHdRUXSM, Tuples.Tuple_FbAEUOYETObSHBafYbFNIeSNO>(a_, 
			c_);
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
        var c_ = this.Get_All_Paid_Claim_Reponses(claimResponse);
        var d_ = this.Pharmacy_Claim_With_Medication(claim, 
			ProductOrServiceValueSet);
        var b_ = new Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB
		{
			PaidPharmacyClaimResponse = c_,
			MedicalClaim = d_,
		};
        var a_ = new Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB[]
		{
			b_,
		};
        Func<Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB,Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO> bs_ = (ClaimAndResponse) => 
        {
            var h_ = ClaimAndResponse?.MedicalClaim;
            Func<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC,Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT> ae_ = (medClaim) => 
            {
                var i_ = medClaim;
                var k_ = medClaim?.LineItem;
                Func<Claim.ItemComponent,bool?> ad_ = (medClaimLineItem) => 
                {
                    var l_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
                    Func<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL,IEnumerable<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>> ab_ = (pClaim) => 
                    {
                        var m_ = pClaim?.LineItems;
                        Func<ClaimResponse.ItemComponent,bool?> y_ = (pClaimLineItem) => 
                        {
                            var o_ = (((medClaim?.Claim is Resource)
								? ((medClaim?.Claim as Resource)?.IdElement)
								: (null))
 as object);
                            var n_ = ((context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(o_) as object);
                            var q_ = (pClaim?.Response?.Request?.ReferenceElement as object);
                            var r_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(q_);
                            var p_ = (NCQAFHIRBase_1_0_0.GetId(r_) as object);
                            var s_ = context?.Operators.Equal(n_, 
								p_);
                            var u_ = (medClaimLineItem?.SequenceElement as object);
                            var t_ = (context?.Operators.Convert<Integer>(u_) as object);
                            var w_ = (pClaimLineItem?.ItemSequenceElement as object);
                            var v_ = (context?.Operators.Convert<Integer>(w_) as object);
                            var x_ = context?.Operators.Equal(t_, 
								v_);
                            return context?.Operators.And(s_, 
								x_);
                        };
                        var z_ = context?.Operators.WhereOrNull<ClaimResponse.ItemComponent>(m_, 
							y_);
                        Func<ClaimResponse.ItemComponent,Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL> aa_ = (pClaimLineItem) => pClaim;
                        return context?.Operators.SelectOrNull<ClaimResponse.ItemComponent, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(z_, 
							aa_);
                    };
                    var ac_ = context?.Operators.SelectManyOrNull<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL, Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(l_, 
						ab_);
                    return context?.Operators.ExistsInList<Tuples.Tuple_EbJRLQXEhRCeIIZLcXEYbTEDL>(ac_);
                };
                var j_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(k_, 
					ad_);
                return new Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT
				{
					PaidClaim = i_,
					ClaimItem = j_,
				};
            };
            var g_ = context?.Operators.SelectOrNull<Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC, Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(h_, 
				ae_);
            var f_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB
			{
				AggregateClaim = g_,
			};
            var e_ = new Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB[]
			{
				f_,
			};
            Func<Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB,Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO> bq_ = (ClaimWithPaidResponse) => 
            {
                var ah_ = ClaimWithPaidResponse?.AggregateClaim;
                Func<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT,bool?> aj_ = (@this) => 
                {
                    bool? ai_ = ((bool?)(@this?.ClaimItem == null));
                    return context?.Operators.Not(ai_);
                };
                var ak_ = context?.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ah_, 
					aj_);
                Func<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT,IEnumerable<Claim.ItemComponent>> al_ = (@this) => 
                {
                    return @this?.ClaimItem;
                };
                var am_ = context?.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(ak_, 
					al_);
                var an_ = context?.Operators.FlattenList<Claim.ItemComponent>(am_);
                Func<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT,bool?> ar_ = (@this) => 
                {
                    bool? aq_ = ((bool?)(@this?.PaidClaim == null));
                    return context?.Operators.Not(aq_);
                };
                var as_ = context?.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ah_, 
					ar_);
                Func<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT,Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC> at_ = (@this) => 
                {
                    return @this?.PaidClaim;
                };
                var ao_ = context?.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, Tuples.Tuple_FOLKddIQBPRMYYfjeMUjEIBhC>(as_, 
					at_);
                Func<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT,bool?> ax_ = (@this) => 
                {
                    bool? aw_ = ((bool?)(@this?.ClaimItem == null));
                    return context?.Operators.Not(aw_);
                };
                var ay_ = context?.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ah_, 
					ax_);
                var ba_ = context?.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(ay_, 
					al_);
                var bb_ = context?.Operators.FlattenList<Claim.ItemComponent>(ba_);
                Func<Claim.ItemComponent,CqlInterval<CqlDateTime>> bd_ = (PaidItem) => 
                {
                    var bc_ = (PaidItem?.Serviced as object);
                    return NCQAFHIRBase_1_0_0.Normalize_Interval(bc_);
                };
                var au_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bb_, 
					bd_);
                Func<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT,bool?> bh_ = (@this) => 
                {
                    bool? bg_ = ((bool?)(@this?.ClaimItem == null));
                    return context?.Operators.Not(bg_);
                };
                var bi_ = context?.Operators.WhereOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT>(ah_, 
					bh_);
                var bk_ = context?.Operators.SelectOrNull<Tuples.Tuple_DgRFfDaEDhBINgYbMaeRWZWVT, IEnumerable<Claim.ItemComponent>>(bi_, 
					al_);
                var bl_ = context?.Operators.FlattenList<Claim.ItemComponent>(bk_);
                Func<Claim.ItemComponent,CqlInterval<CqlDate>> bm_ = (i) => (((context?.Operators.Not(((bool?)(i?.Quantity == null))) ?? false))
						? (context?.Operators.Interval(context?.Operators.ConvertDateTimeToDate(context?.Operators.Start(NCQAFHIRBase_1_0_0.Normalize_Interval((i?.Serviced as object)))), 
								context?.Operators.ConvertDateTimeToDate(context?.Operators.Subtract(context?.Operators.Add(context?.Operators.Start(NCQAFHIRBase_1_0_0.Normalize_Interval((i?.Serviced as object))), 
											new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal(i?.Quantity?.ValueElement), 
												"day")), 
										context?.Operators.Quantity(1m, 
											"day"))), 
								true, 
								true))
						: ((null as CqlInterval<CqlDate>)))
;
                var be_ = context?.Operators.SelectOrNull<Claim.ItemComponent, CqlInterval<CqlDate>>(bl_, 
					bm_);
                var ag_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(an_) ?? false))
					? (new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO
						{
							originalClaim = ao_,
							ServicePeriod = au_,
							CoveredDays = be_,
						})
					: ((null as Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO)))
;
                var af_ = new Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO[]
				{
					ag_,
				};
                Func<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO,bool?> bo_ = (FinalList) => 
                {
                    bool? bn_ = ((bool?)(FinalList == null));
                    return context?.Operators.Not(bn_);
                };
                var bp_ = context?.Operators.WhereOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(af_, 
					bo_);
                return context?.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(bp_);
            };
            var br_ = context?.Operators.SelectOrNull<Tuples.Tuple_DOALBUVOFWRHAUjdPUNBfNdUB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(e_, 
				bq_);
            return context?.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(br_);
        };
        var bt_ = context?.Operators.SelectOrNull<Tuples.Tuple_EDASHZgEHSQJbecPJIZegfOIB, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(a_, 
			bs_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(bt_);
    }

    [CqlDeclaration("Get Paid Claims for Pharmacy Services")]
    public Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO Get_Paid_Claims_for_Pharmacy_Services(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        var b_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(claimResponse, 
			claim);
        var a_ = new Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR[]
		{
			b_,
		};
        Func<Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR,Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO> c_ = (PharmacyClaimAndResponse) => (((context?.Operators.And(((bool?)(PharmacyClaimAndResponse?.PharmacyClaimResponse == null)), 
((bool?)(PharmacyClaimAndResponse?.PharmacyClaim == null))) ?? false))
				? ((null as Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO))
				: (this.Get_Corresponding_Claim_for_Pharmacy_Services(PharmacyClaimAndResponse?.PharmacyClaimResponse, 
PharmacyClaimAndResponse?.PharmacyClaim, 
						ProductOrServiceValueSet)))
;
        var d_ = context?.Operators.SelectOrNull<Tuples.Tuple_ENRfaLDabXeaNdJYVdOfebBTR, Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(a_, 
			c_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_BOANHMYNiCIfFjRZRMEXCcXTO>(d_);
    }

    [CqlDeclaration("Get Claim With Corresponding Claim Response")]
    public IEnumerable<Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI> Get_Claim_With_Corresponding_Claim_Response(IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        Func<Claim,Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI> af_ = (Claim) => 
        {
            Func<ClaimResponse,bool?> g_ = (CR) => 
            {
                var c_ = (Claim?.IdElement as object);
                var b_ = ((context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(c_) as object);
                var e_ = (CR?.Request?.ReferenceElement as object);
                var f_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(e_);
                var d_ = (NCQAFHIRBase_1_0_0.GetId(f_) as object);
                return context?.Operators.Equal(b_, 
					d_);
            };
            var a_ = context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, 
				g_);
            Func<Claim,bool?> ae_ = (C) => 
            {
                var j_ = (Claim?.IdElement as object);
                var i_ = ((context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(j_) as object);
                Func<ClaimResponse,bool?> r_ = (CR) => 
                {
                    var n_ = (Claim?.IdElement as object);
                    var m_ = ((context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(n_) as object);
                    var p_ = (CR?.Request?.ReferenceElement as object);
                    var q_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(p_);
                    var o_ = (NCQAFHIRBase_1_0_0.GetId(q_) as object);
                    return context?.Operators.Equal(m_, 
						o_);
                };
                var s_ = context?.Operators.WhereOrNull<ClaimResponse>(claimResponse, 
					r_);
                Func<ClaimResponse,bool?> u_ = (@this) => 
                {
                    bool? t_ = ((bool?)(@this?.Request == null));
                    return context?.Operators.Not(t_);
                };
                var v_ = context?.Operators.WhereOrNull<ClaimResponse>(s_, 
					u_);
                Func<ClaimResponse,ResourceReference> w_ = (@this) => 
                {
                    return @this?.Request;
                };
                var x_ = context?.Operators.SelectOrNull<ClaimResponse, ResourceReference>(v_, 
					w_);
                Func<ResourceReference,bool?> z_ = (@this) => 
                {
                    bool? y_ = ((bool?)(@this?.ReferenceElement == null));
                    return context?.Operators.Not(y_);
                };
                var aa_ = context?.Operators.WhereOrNull<ResourceReference>(x_, 
					z_);
                Func<ResourceReference,FhirString> ab_ = (@this) => 
                {
                    return @this?.ReferenceElement;
                };
                var ac_ = context?.Operators.SelectOrNull<ResourceReference, FhirString>(aa_, 
					ab_);
                var l_ = (context?.Operators.SingleOrNull<FhirString>(ac_) as object);
                var ad_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(l_);
                var k_ = (NCQAFHIRBase_1_0_0.GetId(ad_) as object);
                return context?.Operators.Equal(i_, 
					k_);
            };
            var h_ = context?.Operators.WhereOrNull<Claim>(claim, 
				ae_);
            return new Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI
			{
				ClaimResponse = a_,
				OriginalClaim = h_,
			};
        };
        return context?.Operators.SelectOrNull<Claim, Tuples.Tuple_HQUdYchKGNXjEWMCbcWSEKdVI>(claim, 
			af_);
    }

    [CqlDeclaration("Medical Claims With Nonacute or Acute Inpatient Discharge")]
    public Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(IEnumerable<Claim> claim)
    {
        var c_ = this.Professional_or_Institutional_Claims(claim);
        var b_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO
		{
			MedicalClaim = c_,
		};
        var a_ = new Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO[]
		{
			b_,
		};
        Func<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO,Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE> bf_ = (ClaimWithInpatientStay) => 
        {
            var g_ = ClaimWithInpatientStay?.MedicalClaim;
            Func<Claim,bool?> p_ = (c) => 
            {
                var h_ = (c?.Item as IEnumerable<Claim.ItemComponent>);
                Func<Claim.ItemComponent,bool?> n_ = (i) => 
                {
                    var i_ = (FHIRHelpers_4_0_001.ToConcept(i?.Revenue)?.codes as IEnumerable<CqlCode>);
                    Func<CqlCode,bool?> l_ = (rev) => 
                    {
                        var j_ = rev?.code;
                        var k_ = this.Inpatient_Stay();
                        return context?.Operators.StringInValueSet(j_, 
							k_);
                    };
                    var m_ = context?.Operators.WhereOrNull<CqlCode>(i_, 
						l_);
                    return context?.Operators.ExistsInList<CqlCode>(m_);
                };
                var o_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(h_, 
					n_);
                return context?.Operators.ExistsInList<Claim.ItemComponent>(o_);
            };
            var f_ = (((ClaimWithInpatientStay?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(g_, 
						p_)))
;
            Func<Claim,bool?> ah_ = (c) => 
            {
                var s_ = (c?.Item as IEnumerable<Claim.ItemComponent>);
                Func<Claim.ItemComponent,bool?> y_ = (i) => 
                {
                    var t_ = (FHIRHelpers_4_0_001.ToConcept(i?.Revenue)?.codes as IEnumerable<CqlCode>);
                    Func<CqlCode,bool?> w_ = (rev) => 
                    {
                        var u_ = rev?.code;
                        var v_ = this.Nonacute_Inpatient_Stay();
                        return context?.Operators.StringInValueSet(u_, 
							v_);
                    };
                    var x_ = context?.Operators.WhereOrNull<CqlCode>(t_, 
						w_);
                    return context?.Operators.ExistsInList<CqlCode>(x_);
                };
                var z_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(s_, 
					y_);
                var aa_ = context?.Operators.ExistsInList<Claim.ItemComponent>(z_);
                var ab_ = (c?.SubType?.Coding as IEnumerable<Coding>);
                Func<Coding,bool?> ae_ = (tob) => 
                {
                    var ac_ = tob?.CodeElement?.Value;
                    var ad_ = this.Nonacute_Inpatient_Stay();
                    return context?.Operators.StringInValueSet(ac_, 
						ad_);
                };
                var af_ = context?.Operators.WhereOrNull<Coding>(ab_, 
					ae_);
                var ag_ = context?.Operators.ExistsInList<Coding>(af_);
                return context?.Operators.Or(aa_, 
					ag_);
            };
            var q_ = (((ClaimWithInpatientStay?.MedicalClaim == null))
				? ((null as IEnumerable<Claim>))
				: (context?.Operators.WhereOrNull<Claim>(g_, 
						ah_)))
;
            var e_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb
			{
				InpatientStayLineItems = f_,
				NonacuteInpatientLineItems = q_,
			};
            var d_ = new Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb[]
			{
				e_,
			};
            Func<Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb,Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE> bd_ = (LineItemDefinition) => 
            {
                var ai_ = LineItemDefinition?.InpatientStayLineItems;
                var ak_ = LineItemDefinition?.NonacuteInpatientLineItems;
                Func<Claim,IEnumerable<Claim>> ar_ = (nonAcuteInpatientStay) => 
                {
                    var al_ = LineItemDefinition?.InpatientStayLineItems;
                    Func<Claim,bool?> ao_ = (inpatientStay) => 
                    {
                        var am_ = (nonAcuteInpatientStay?.IdElement as object);
                        var an_ = (inpatientStay?.IdElement as object);
                        return context?.Operators.Equal(am_, 
							an_);
                    };
                    var ap_ = context?.Operators.WhereOrNull<Claim>(al_, 
						ao_);
                    Func<Claim,Claim> aq_ = (inpatientStay) => nonAcuteInpatientStay;
                    return context?.Operators.SelectOrNull<Claim, Claim>(ap_, 
						aq_);
                };
                var aj_ = context?.Operators.SelectManyOrNull<Claim, Claim>(ak_, 
					ar_);
                Func<Claim,IEnumerable<Claim>> bb_ = (inpatientStay) => 
                {
                    var av_ = LineItemDefinition?.NonacuteInpatientLineItems;
                    Func<Claim,bool?> ay_ = (nonAcuteInpatientStay) => 
                    {
                        var aw_ = (inpatientStay?.IdElement as object);
                        var ax_ = (nonAcuteInpatientStay?.IdElement as object);
                        return context?.Operators.Equal(aw_, 
							ax_);
                    };
                    var az_ = context?.Operators.WhereOrNull<Claim>(av_, 
						ay_);
                    Func<Claim,Claim> ba_ = (nonAcuteInpatientStay) => inpatientStay;
                    return context?.Operators.SelectOrNull<Claim, Claim>(az_, 
						ba_);
                };
                var bc_ = context?.Operators.SelectManyOrNull<Claim, Claim>(ai_, 
					bb_);
                var as_ = context?.Operators.ListExcept<Claim>(ai_, 
					bc_);
                return new Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE
				{
					InpatientDischarge = ai_,
					NonacuteInpatientDischarge = aj_,
					AcuteInpatientDischarge = as_,
				};
            };
            var be_ = context?.Operators.SelectOrNull<Tuples.Tuple_BcRbRSiZXcAFIKNCdPcQULMGb, Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(d_, 
				bd_);
            return context?.Operators.SingleOrNull<Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(be_);
        };
        var bg_ = context?.Operators.SelectOrNull<Tuples.Tuple_EWMRhBHgcOUGZLgIBDbjPHISO, Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(a_, 
			bf_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_CYfZbbEjJgLODachBhLiZaXQE>(bg_);
    }

    [CqlDeclaration("Get Prescriber NPI from Claims")]
    public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Prescriber_NPI_from_Claims(IEnumerable<Claim> claim)
    {
        Func<Claim,Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS> ak_ = (C) => 
        {
            var d_ = C;
            var f_ = (C?.CareTeam as IEnumerable<Claim.CareTeamComponent>);
            Func<Claim.CareTeamComponent,bool?> k_ = (ct) => 
            {
                var h_ = (ct?.SequenceElement as object);
                var i_ = context?.Operators.Convert<Integer>(h_);
                var g_ = (FHIRHelpers_4_0_001.ToInteger(i_) as object);
                var j_ = (((int?)1) as object);
                return context?.Operators.Equal(g_, 
					j_);
            };
            var l_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(f_, 
				k_);
            Func<Claim.CareTeamComponent,bool?> n_ = (@this) => 
            {
                bool? m_ = ((bool?)(@this?.Provider == null));
                return context?.Operators.Not(m_);
            };
            var o_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(l_, 
				n_);
            Func<Claim.CareTeamComponent,ResourceReference> p_ = (@this) => 
            {
                return @this?.Provider;
            };
            var e_ = context?.Operators.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(o_, 
				p_);
            Func<Claim.CareTeamComponent,bool?> w_ = (ct) => 
            {
                var t_ = (ct?.SequenceElement as object);
                var u_ = context?.Operators.Convert<Integer>(t_);
                var s_ = (FHIRHelpers_4_0_001.ToInteger(u_) as object);
                var v_ = (((int?)1) as object);
                return context?.Operators.Equal(s_, 
					v_);
            };
            var x_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(f_, 
				w_);
            Func<Claim.CareTeamComponent,bool?> z_ = (@this) => 
            {
                bool? y_ = ((bool?)(@this?.Provider == null));
                return context?.Operators.Not(y_);
            };
            var aa_ = context?.Operators.WhereOrNull<Claim.CareTeamComponent>(x_, 
				z_);
            var ac_ = context?.Operators.SelectOrNull<Claim.CareTeamComponent, ResourceReference>(aa_, 
				p_);
            Func<ResourceReference,string> aj_ = (p) => 
            {
                var ae_ = p?.ReferenceElement;
                var ad_ = new FhirString[]
				{
					ae_,
				};
                Func<FhirString,string> ah_ = (r) => 
                {
                    var af_ = (r as object);
                    var ag_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(af_);
                    return NCQAFHIRBase_1_0_0.GetId(ag_);
                };
                var ai_ = context?.Operators.SelectOrNull<FhirString, string>(ad_, 
					ah_);
                return context?.Operators.SingleOrNull<string>(ai_);
            };
            var q_ = context?.Operators.SelectOrNull<ResourceReference, string>(ac_, 
				aj_);
            return new Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS
			{
				SingleCareTeam = d_,
				CareTeamsProvider = e_,
				CareTeamsProviderID = q_,
			};
        };
        var c_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(claim, 
			ak_);
        var b_ = new Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR
		{
			CareTeams = c_,
		};
        var a_ = new Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR[]
		{
			b_,
		};
        Func<Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR,Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY> dt_ = (ClaimProperties) => 
        {
            var ao_ = context?.Operators.RetrieveByValueSet<Practitioner>(null, 
				null);
            Func<Practitioner,bool?> ay_ = (p) => 
            {
                var ap_ = (p?.IdElement as object);
                var aq_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(ap_);
                var ar_ = ClaimProperties?.CareTeams;
                Func<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS,bool?> at_ = (@this) => 
                {
                    bool? as_ = ((bool?)(@this?.CareTeamsProviderID == null));
                    return context?.Operators.Not(as_);
                };
                var au_ = context?.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(ar_, 
					at_);
                Func<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS,IEnumerable<string>> av_ = (@this) => 
                {
                    return @this?.CareTeamsProviderID;
                };
                var aw_ = context?.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, IEnumerable<string>>(au_, 
					av_);
                var ax_ = context?.Operators.FlattenList<string>(aw_);
                return context?.Operators.InList<string>(aq_, 
					ax_);
            };
            var an_ = context?.Operators.WhereOrNull<Practitioner>(ao_, 
				ay_);
            var am_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe
			{
				Practitioners = an_,
			};
            var al_ = new Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe[]
			{
				am_,
			};
            Func<Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe,Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY> dr_ = (PractitionerMatch) => 
            {
                var bc_ = PractitionerMatch?.Practitioners;
                Func<Practitioner,bool?> be_ = (P) => 
                {
                    bool? bd_ = ((bool?)(P == null));
                    return context?.Operators.Not(bd_);
                };
                var bf_ = context?.Operators.WhereOrNull<Practitioner>(bc_, 
					be_);
                Func<Practitioner,Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR> cl_ = (P) => 
                {
                    var bh_ = (P?.Identifier as IEnumerable<Identifier>);
                    Func<Identifier,bool?> bt_ = (l) => 
                    {
                        var bi_ = (l?.SystemElement?.Value as object);
                        var bj_ = ("http://hl7.org/fhir/sid/us-npi" as object);
                        var bk_ = context?.Operators.Equal(bi_, 
							bj_);
                        var bm_ = l?.Type;
                        var bl_ = (FHIRHelpers_4_0_001.ToConcept(bm_) as object);
                        var bo_ = NCQATerminology_1_0_0.Provider_number();
                        var bn_ = (context?.Operators.ConvertCodeToConcept(bo_) as object);
                        var bp_ = context?.Operators.Equivalent(bl_, 
							bn_);
                        var bq_ = context?.Operators.And(bk_, 
							bp_);
                        bool? br_ = ((bool?)(l?.ValueElement?.Value == null));
                        var bs_ = context?.Operators.Not(br_);
                        return context?.Operators.And(bq_, 
							bs_);
                    };
                    var bu_ = context?.Operators.WhereOrNull<Identifier>(bh_, 
						bt_);
                    Func<Identifier,FhirString> bv_ = (l) => 
                    {
                        return l?.ValueElement;
                    };
                    var bg_ = context?.Operators.SelectOrNull<Identifier, FhirString>(bu_, 
						bv_);
                    Func<Identifier,bool?> ci_ = (l) => 
                    {
                        var by_ = (l?.SystemElement?.Value as object);
                        var bz_ = ("http://hl7.org/fhir/sid/us-npi" as object);
                        var ca_ = context?.Operators.Equal(by_, 
							bz_);
                        var cc_ = l?.Type;
                        var cb_ = (FHIRHelpers_4_0_001.ToConcept(cc_) as object);
                        var ce_ = NCQATerminology_1_0_0.Provider_number();
                        var cd_ = (context?.Operators.ConvertCodeToConcept(ce_) as object);
                        var cf_ = context?.Operators.Equivalent(cb_, 
							cd_);
                        var cg_ = context?.Operators.And(ca_, 
							cf_);
                        bool? ch_ = ((bool?)(l?.ValueElement?.Value == null));
                        return context?.Operators.And(cg_, 
							ch_);
                    };
                    var cj_ = context?.Operators.WhereOrNull<Identifier>(bh_, 
						ci_);
                    Func<Identifier,Identifier> ck_ = (l) => l;
                    var bw_ = context?.Operators.SelectOrNull<Identifier, Identifier>(cj_, 
						ck_);
                    return new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = bg_,
						NullIdentifiers = bw_,
					};
                };
                var bb_ = context?.Operators.SelectOrNull<Practitioner, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(bf_, 
					cl_);
                var ba_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = bb_,
				};
                var az_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					ba_,
				};
                Func<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH,Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY> dp_ = (GetIdentifiers) => 
                {
                    var cn_ = ClaimProperties?.CareTeams;
                    Func<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS,bool?> cp_ = (@this) => 
                    {
                        bool? co_ = ((bool?)(@this?.SingleCareTeam == null));
                        return context?.Operators.Not(co_);
                    };
                    var cq_ = context?.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(cn_, 
						cp_);
                    Func<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS,Claim> cr_ = (@this) => 
                    {
                        return @this?.SingleCareTeam;
                    };
                    var cs_ = context?.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(cq_, 
						cr_);
                    Func<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS,bool?> cv_ = (@this) => 
                    {
                        bool? cu_ = ((bool?)(@this?.SingleCareTeam == null));
                        return context?.Operators.Not(cu_);
                    };
                    var cw_ = context?.Operators.WhereOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS>(cn_, 
						cv_);
                    var cy_ = context?.Operators.SelectOrNull<Tuples.Tuple_GIfhUVACThMQNGPGjYhYHEfGS, Claim>(cw_, 
						cr_);
                    Func<Claim,bool?> cz_ = (X) => ((bool?)((X?.CareTeam as IEnumerable<Claim.CareTeamComponent>) == null));
                    var da_ = context?.Operators.WhereOrNull<Claim>(cy_, 
						cz_);
                    var db_ = context?.Operators.CountOrNull<Claim>(da_);
                    var dc_ = GetIdentifiers?.IdentifierTuple;
                    Func<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR,IEnumerable<FhirString>> dd_ = (X) => 
                    {
                        return X?.AllIdentifiers;
                    };
                    var de_ = context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(dc_, 
						dd_);
                    var df_ = context?.Operators.FlattenList<FhirString>(de_);
                    Func<FhirString,FhirString> dg_ = (X) => X;
                    var dh_ = context?.Operators.SelectOrNull<FhirString, FhirString>(df_, 
						dg_);
                    var di_ = context?.Operators.CountOrNull<FhirString>(dh_);
                    var dj_ = context?.Operators.Add(db_, 
						di_);
                    Func<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR,IEnumerable<Identifier>> dl_ = (X) => 
                    {
                        return X?.NullIdentifiers;
                    };
                    var dm_ = context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(dc_, 
						dl_);
                    var dn_ = context?.Operators.FlattenList<Identifier>(dm_);
                    var do_ = context?.Operators.CountOrNull<Identifier>(dn_);
                    var cm_ = (((context?.Operators.ExistsInList<Claim>(cs_) ?? false))
						? (context?.Operators.Add(dj_, 
								do_))
						: (((int?)0)))
;
                    return new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = cm_,
					};
                };
                var dq_ = context?.Operators.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(az_, 
					dp_);
                return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dq_);
            };
            var ds_ = context?.Operators.SelectOrNull<Tuples.Tuple_DIQeTbDBBRFOAGiGbFgLLFZOe, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(al_, 
				dr_);
            return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(ds_);
        };
        var du_ = context?.Operators.SelectOrNull<Tuples.Tuple_GMJgYefQcULgUcRJJAbTfRThR, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(a_, 
			dt_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(du_);
    }

    [CqlDeclaration("Get Pharmacy NPI from Claims")]
    public Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY Get_Pharmacy_NPI_from_Claims(IEnumerable<Claim> claim)
    {
        Func<Claim,Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI> am_ = (C) => 
        {
            var d_ = (C?.Item as IEnumerable<Claim.ItemComponent>);
            Func<Claim.ItemComponent,bool?> k_ = (i) => 
            {
                var h_ = (i?.SequenceElement as object);
                var i_ = context?.Operators.Convert<Integer>(h_);
                var g_ = (FHIRHelpers_4_0_001.ToInteger(i_) as object);
                var j_ = (((int?)1) as object);
                return context?.Operators.Equal(g_, 
					j_);
            };
            var l_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(d_, 
				k_);
            Func<Claim.ItemComponent,bool?> n_ = (@this) => 
            {
                bool? m_ = ((bool?)(@this?.Location == null));
                return context?.Operators.Not(m_);
            };
            var o_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(l_, 
				n_);
            Func<Claim.ItemComponent,DataType> p_ = (@this) => 
            {
                return @this?.Location;
            };
            var q_ = context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(o_, 
				p_);
            Func<DataType,ResourceReference> r_ = (l) => (l as ResourceReference);
            var e_ = context?.Operators.SelectOrNull<DataType, ResourceReference>(q_, 
				r_);
            Func<Claim.ItemComponent,bool?> y_ = (i) => 
            {
                var v_ = (i?.SequenceElement as object);
                var w_ = context?.Operators.Convert<Integer>(v_);
                var u_ = (FHIRHelpers_4_0_001.ToInteger(w_) as object);
                var x_ = (((int?)1) as object);
                return context?.Operators.Equal(u_, 
					x_);
            };
            var z_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(d_, 
				y_);
            Func<Claim.ItemComponent,bool?> ab_ = (@this) => 
            {
                bool? aa_ = ((bool?)(@this?.Location == null));
                return context?.Operators.Not(aa_);
            };
            var ac_ = context?.Operators.WhereOrNull<Claim.ItemComponent>(z_, 
				ab_);
            var ae_ = context?.Operators.SelectOrNull<Claim.ItemComponent, DataType>(ac_, 
				p_);
            Func<DataType,string> al_ = (l) => 
            {
                var ag_ = ((l as ResourceReference))?.ReferenceElement;
                var af_ = new FhirString[]
				{
					ag_,
				};
                Func<FhirString,string> aj_ = (r) => 
                {
                    var ah_ = (r as object);
                    var ai_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(ah_);
                    return NCQAFHIRBase_1_0_0.GetId(ai_);
                };
                var ak_ = context?.Operators.SelectOrNull<FhirString, string>(af_, 
					aj_);
                return context?.Operators.SingleOrNull<string>(ak_);
            };
            var s_ = context?.Operators.SelectOrNull<DataType, string>(ae_, 
				al_);
            return new Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI
			{
				SingleItem = d_,
				ItemLocation = e_,
				ItemLocationID = s_,
			};
        };
        var c_ = context?.Operators.SelectOrNull<Claim, Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(claim, 
			am_);
        var b_ = new Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa
		{
			ItemsLocationReferences = c_,
		};
        var a_ = new Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa[]
		{
			b_,
		};
        Func<Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa,Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY> dx_ = (ClaimProperties) => 
        {
            var aq_ = context?.Operators.RetrieveByValueSet<Location>(null, 
				null);
            Func<Location,bool?> ba_ = (l) => 
            {
                var ar_ = (l?.IdElement as object);
                var as_ = (context.OnFunctionCalled(new FunctionCallEvent("ToString", 
		null, 
		null))?.Operators).Convert<string>(ar_);
                var at_ = ClaimProperties?.ItemsLocationReferences;
                Func<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI,bool?> av_ = (@this) => 
                {
                    bool? au_ = ((bool?)(@this?.ItemLocationID == null));
                    return context?.Operators.Not(au_);
                };
                var aw_ = context?.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(at_, 
					av_);
                Func<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI,IEnumerable<string>> ax_ = (@this) => 
                {
                    return @this?.ItemLocationID;
                };
                var ay_ = context?.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<string>>(aw_, 
					ax_);
                var az_ = context?.Operators.FlattenList<string>(ay_);
                return context?.Operators.InList<string>(as_, 
					az_);
            };
            var ap_ = context?.Operators.WhereOrNull<Location>(aq_, 
				ba_);
            var ao_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP
			{
				CorrespondingLocations = ap_,
			};
            var an_ = new Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP[]
			{
				ao_,
			};
            Func<Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP,Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY> dv_ = (GetLocation) => 
            {
                var be_ = GetLocation?.CorrespondingLocations;
                Func<Location,bool?> bg_ = (C) => 
                {
                    bool? bf_ = ((bool?)(C == null));
                    return context?.Operators.Not(bf_);
                };
                var bh_ = context?.Operators.WhereOrNull<Location>(be_, 
					bg_);
                Func<Location,Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR> cn_ = (C) => 
                {
                    var bj_ = (C?.Identifier as IEnumerable<Identifier>);
                    Func<Identifier,bool?> bv_ = (l) => 
                    {
                        var bk_ = (l?.SystemElement?.Value as object);
                        var bl_ = ("http://hl7.org/fhir/sid/us-npi" as object);
                        var bm_ = context?.Operators.Equal(bk_, 
							bl_);
                        var bo_ = l?.Type;
                        var bn_ = (FHIRHelpers_4_0_001.ToConcept(bo_) as object);
                        var bq_ = NCQATerminology_1_0_0.Provider_number();
                        var bp_ = (context?.Operators.ConvertCodeToConcept(bq_) as object);
                        var br_ = context?.Operators.Equivalent(bn_, 
							bp_);
                        var bs_ = context?.Operators.And(bm_, 
							br_);
                        bool? bt_ = ((bool?)(l?.ValueElement?.Value == null));
                        var bu_ = context?.Operators.Not(bt_);
                        return context?.Operators.And(bs_, 
							bu_);
                    };
                    var bw_ = context?.Operators.WhereOrNull<Identifier>(bj_, 
						bv_);
                    Func<Identifier,FhirString> bx_ = (l) => 
                    {
                        return l?.ValueElement;
                    };
                    var bi_ = context?.Operators.SelectOrNull<Identifier, FhirString>(bw_, 
						bx_);
                    Func<Identifier,bool?> ck_ = (l) => 
                    {
                        var ca_ = (l?.SystemElement?.Value as object);
                        var cb_ = ("http://hl7.org/fhir/sid/us-npi" as object);
                        var cc_ = context?.Operators.Equal(ca_, 
							cb_);
                        var ce_ = l?.Type;
                        var cd_ = (FHIRHelpers_4_0_001.ToConcept(ce_) as object);
                        var cg_ = NCQATerminology_1_0_0.Provider_number();
                        var cf_ = (context?.Operators.ConvertCodeToConcept(cg_) as object);
                        var ch_ = context?.Operators.Equivalent(cd_, 
							cf_);
                        var ci_ = context?.Operators.And(cc_, 
							ch_);
                        bool? cj_ = ((bool?)(l?.ValueElement?.Value == null));
                        return context?.Operators.And(ci_, 
							cj_);
                    };
                    var cl_ = context?.Operators.WhereOrNull<Identifier>(bj_, 
						ck_);
                    Func<Identifier,Identifier> cm_ = (l) => l;
                    var by_ = context?.Operators.SelectOrNull<Identifier, Identifier>(cl_, 
						cm_);
                    return new Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR
					{
						AllIdentifiers = bi_,
						NullIdentifiers = by_,
					};
                };
                var bd_ = context?.Operators.SelectOrNull<Location, Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR>(bh_, 
					cn_);
                var bc_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH
				{
					IdentifierTuple = bd_,
				};
                var bb_ = new Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH[]
				{
					bc_,
				};
                Func<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH,Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY> dt_ = (GetIdentifiers) => 
                {
                    var cp_ = ClaimProperties?.ItemsLocationReferences;
                    Func<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI,bool?> cr_ = (@this) => 
                    {
                        bool? cq_ = ((bool?)(@this?.SingleItem == null));
                        return context?.Operators.Not(cq_);
                    };
                    var cs_ = context?.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(cp_, 
						cr_);
                    Func<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI,IEnumerable<Claim.ItemComponent>> ct_ = (@this) => 
                    {
                        return @this?.SingleItem;
                    };
                    var cu_ = context?.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<Claim.ItemComponent>>(cs_, 
						ct_);
                    var cv_ = context?.Operators.FlattenList<Claim.ItemComponent>(cu_);
                    Func<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI,bool?> cy_ = (@this) => 
                    {
                        bool? cx_ = ((bool?)(@this?.ItemLocation == null));
                        return context?.Operators.Not(cx_);
                    };
                    var cz_ = context?.Operators.WhereOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI>(cp_, 
						cy_);
                    Func<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI,IEnumerable<ResourceReference>> da_ = (@this) => 
                    {
                        return @this?.ItemLocation;
                    };
                    var db_ = context?.Operators.SelectOrNull<Tuples.Tuple_FPCXihcEeChSjIUJHVXRcEXMI, IEnumerable<ResourceReference>>(cz_, 
						da_);
                    var dc_ = context?.Operators.FlattenList<ResourceReference>(db_);
                    Func<ResourceReference,bool?> dd_ = (X) => ((bool?)(X?.ReferenceElement?.Value == null));
                    var de_ = context?.Operators.WhereOrNull<ResourceReference>(dc_, 
						dd_);
                    var df_ = context?.Operators.CountOrNull<ResourceReference>(de_);
                    var dg_ = GetIdentifiers?.IdentifierTuple;
                    Func<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR,IEnumerable<FhirString>> dh_ = (X) => 
                    {
                        return X?.AllIdentifiers;
                    };
                    var di_ = context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<FhirString>>(dg_, 
						dh_);
                    var dj_ = context?.Operators.FlattenList<FhirString>(di_);
                    Func<FhirString,FhirString> dk_ = (X) => X;
                    var dl_ = context?.Operators.SelectOrNull<FhirString, FhirString>(dj_, 
						dk_);
                    var dm_ = context?.Operators.CountOrNull<FhirString>(dl_);
                    var dn_ = context?.Operators.Add(df_, 
						dm_);
                    Func<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR,IEnumerable<Identifier>> dp_ = (X) => 
                    {
                        return X?.NullIdentifiers;
                    };
                    var dq_ = context?.Operators.SelectOrNull<Tuples.Tuple_FNLPNAPOaaMjChWUXdhfgcWIR, IEnumerable<Identifier>>(dg_, 
						dp_);
                    var dr_ = context?.Operators.FlattenList<Identifier>(dq_);
                    var ds_ = context?.Operators.CountOrNull<Identifier>(dr_);
                    var co_ = (((context?.Operators.ExistsInList<Claim.ItemComponent>(cv_) ?? false))
						? (context?.Operators.Add(dn_, 
								ds_))
						: (((int?)0)))
;
                    return new Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY
					{
						IdentifierCount = co_,
					};
                };
                var du_ = context?.Operators.SelectOrNull<Tuples.Tuple_QDOjYOQaAUWAWKDPBcQCSKDH, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(bb_, 
					dt_);
                return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(du_);
            };
            var dw_ = context?.Operators.SelectOrNull<Tuples.Tuple_CZQfDISCFaOQaLKEbbAcDRfcP, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(an_, 
				dv_);
            return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dw_);
        };
        var dy_ = context?.Operators.SelectOrNull<Tuples.Tuple_FbiEbRAPBSZAgWUQOLFeLJQTa, Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(a_, 
			dx_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_CEXhgaFKbhdeeAYTYBhHTGXUY>(dy_);
    }

}
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
[CqlLibrary("SupplementalDataElements", "3.4.000")]
public class SupplementalDataElements_3_4_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Ethnicity;
    internal Lazy<CqlValueSet> __ONC_Administrative_Sex;
    internal Lazy<CqlValueSet> __Payer_Type;
    internal Lazy<CqlValueSet> __Race;
    internal Lazy<Patient> __Patient;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public SupplementalDataElements_3_4_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);

        __Ethnicity = new Lazy<CqlValueSet>(this.Ethnicity_Value);
        __ONC_Administrative_Sex = new Lazy<CqlValueSet>(this.ONC_Administrative_Sex_Value);
        __Payer_Type = new Lazy<CqlValueSet>(this.Payer_Type_Value);
        __Race = new Lazy<CqlValueSet>(this.Race_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }

    #endregion

	private CqlValueSet Ethnicity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public CqlValueSet Ethnicity() => 
		__Ethnicity.Value;

	private CqlValueSet ONC_Administrative_Sex_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public CqlValueSet ONC_Administrative_Sex() => 
		__ONC_Administrative_Sex.Value;

	private CqlValueSet Payer_Type_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlDeclaration("Payer Type")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public CqlValueSet Payer_Type() => 
		__Payer_Type.Value;

	private CqlValueSet Race_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public CqlValueSet Race() => 
		__Race.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		List<Extension> a_()
		{
			if (this.Patient() is DomainResource)
			{
				var i_ = this.Patient();

				return (i_ as DomainResource).Extension;
			}
			else
			{
				return null;
			};
		};
		bool? b_(Extension @this)
		{
			var j_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Extension>(a_(), b_);
		var d_ = context.Operators.SingleOrNull<Extension>(c_);
		var e_ = new Extension[]
		{
			d_,
		};
		Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB f_(Extension E)
		{
			bool? k_(Extension @this)
			{
				var af_ = context.Operators.Equal(@this?.Url, "ombCategory");

				return af_;
			};
			var l_ = context.Operators.WhereOrNull<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), k_);
			DataType m_(Extension @this) => 
				@this?.Value;
			var n_ = context.Operators.SelectOrNull<Extension, DataType>(l_, m_);
			var o_ = context.Operators.SingleOrNull<DataType>(n_);
			var p_ = FHIRHelpers_4_3_000.ToCode(o_);
			var q_ = new CqlCode[]
			{
				p_,
			};
			bool? r_(Extension @this)
			{
				var ag_ = context.Operators.Equal(@this?.Url, "detailed");

				return ag_;
			};
			var s_ = context.Operators.WhereOrNull<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), r_);
			var u_ = context.Operators.SelectOrNull<Extension, DataType>(s_, m_);
			CqlCode v_(DataType @this)
			{
				var ah_ = FHIRHelpers_4_3_000.ToCode(@this);

				return ah_;
			};
			var w_ = context.Operators.SelectOrNull<DataType, CqlCode>(u_, v_);
			var x_ = context.Operators.ValueSetUnion((q_ as IEnumerable<CqlCode>), w_);
			bool? y_(Extension @this)
			{
				var ai_ = context.Operators.Equal(@this?.Url, "text");

				return ai_;
			};
			var z_ = context.Operators.WhereOrNull<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), y_);
			var ab_ = context.Operators.SelectOrNull<Extension, DataType>(z_, m_);
			var ac_ = context.Operators.SingleOrNull<DataType>(ab_);
			var ad_ = context.Operators.Convert<string>(ac_);
			var ae_ = new Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB
			{
				codes = x_,
				display = ad_,
			};

			return ae_;
		};
		var g_ = context.Operators.SelectOrNull<Extension, Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(e_, f_);
		var h_ = context.Operators.SingleOrNull<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = this.Payer_Type();
		var b_ = context.Operators.RetrieveByValueSet<Coverage>(a_, null);
		Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX c_(Coverage Payer)
		{
			var e_ = FHIRHelpers_4_3_000.ToConcept(Payer?.Type);
			var f_ = FHIRHelpers_4_3_000.ToInterval(Payer?.Period);
			var g_ = new Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX
			{
				code = e_,
				period = f_,
			};

			return g_;
		};
		var d_ = context.Operators.SelectOrNull<Coverage, Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>(b_, c_);

		return d_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		List<Extension> a_()
		{
			if (this.Patient() is DomainResource)
			{
				var i_ = this.Patient();

				return (i_ as DomainResource).Extension;
			}
			else
			{
				return null;
			};
		};
		bool? b_(Extension @this)
		{
			var j_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Extension>(a_(), b_);
		var d_ = context.Operators.SingleOrNull<Extension>(c_);
		var e_ = new Extension[]
		{
			d_,
		};
		Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB f_(Extension R)
		{
			bool? k_(Extension @this)
			{
				var ae_ = context.Operators.Equal(@this?.Url, "ombCategory");

				return ae_;
			};
			var l_ = context.Operators.WhereOrNull<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), k_);
			DataType m_(Extension @this) => 
				@this?.Value;
			var n_ = context.Operators.SelectOrNull<Extension, DataType>(l_, m_);
			CqlCode o_(DataType @this)
			{
				var af_ = FHIRHelpers_4_3_000.ToCode(@this);

				return af_;
			};
			var p_ = context.Operators.SelectOrNull<DataType, CqlCode>(n_, o_);
			bool? q_(Extension @this)
			{
				var ag_ = context.Operators.Equal(@this?.Url, "detailed");

				return ag_;
			};
			var r_ = context.Operators.WhereOrNull<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), q_);
			var t_ = context.Operators.SelectOrNull<Extension, DataType>(r_, m_);
			CqlCode u_(DataType @this)
			{
				var ah_ = FHIRHelpers_4_3_000.ToCode(@this);

				return ah_;
			};
			var v_ = context.Operators.SelectOrNull<DataType, CqlCode>(t_, u_);
			var w_ = context.Operators.ValueSetUnion(p_, v_);
			bool? x_(Extension @this)
			{
				var ai_ = context.Operators.Equal(@this?.Url, "text");

				return ai_;
			};
			var y_ = context.Operators.WhereOrNull<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), x_);
			var aa_ = context.Operators.SelectOrNull<Extension, DataType>(y_, m_);
			var ab_ = context.Operators.SingleOrNull<DataType>(aa_);
			var ac_ = context.Operators.Convert<string>(ab_);
			var ad_ = new Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB
			{
				codes = w_,
				display = ac_,
			};

			return ad_;
		};
		var g_ = context.Operators.SelectOrNull<Extension, Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(e_, f_);
		var h_ = context.Operators.SingleOrNull<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_()
		{
			if ((context.Operators.EnumEqualsString(this.Patient()?.GenderElement?.Value, "male") ?? false))
			{
				string b_ = null;

				return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", b_, "Male");
			}
			else if ((context.Operators.EnumEqualsString(this.Patient()?.GenderElement?.Value, "female") ?? false))
			{
				string c_ = null;

				return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", c_, "Female");
			}
			else
			{
				return null;
			};
		};

		return a_();
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
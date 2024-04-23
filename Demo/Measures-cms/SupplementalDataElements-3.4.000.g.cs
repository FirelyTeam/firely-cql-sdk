using System;
using Tuples;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		List<Extension> a_()
		{
			bool i_()
			{
				var j_ = this.Patient();
				var k_ = j_ is DomainResource;

				return k_;
			};
			if (i_())
			{
				var l_ = this.Patient();

				return (l_ as DomainResource).Extension;
			}
			else
			{
				return null;
			};
		};
		bool? b_(Extension @this)
		{
			var m_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return m_;
		};
		var c_ = context.Operators.WhereOrNull<Extension>(a_(), b_);
		var d_ = context.Operators.SingletonFrom<Extension>(c_);
		var e_ = new Extension[]
		{
			d_,
		};
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB f_(Extension E)
		{
			bool? n_(Extension @this)
			{
				var ai_ = context.Operators.Equal(@this?.Url, "ombCategory");

				return ai_;
			};
			var o_ = context.Operators.WhereOrNull<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), n_);
			DataType p_(Extension @this) => 
				@this?.Value;
			var q_ = context.Operators.SelectOrNull<Extension, DataType>(o_, p_);
			var r_ = context.Operators.SingletonFrom<DataType>(q_);
			var s_ = context.Operators.Convert<Coding>(r_);
			var t_ = FHIRHelpers_4_3_000.ToCode(s_);
			var u_ = new CqlCode[]
			{
				t_,
			};
			bool? v_(Extension @this)
			{
				var aj_ = context.Operators.Equal(@this?.Url, "detailed");

				return aj_;
			};
			var w_ = context.Operators.WhereOrNull<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), v_);
			var y_ = context.Operators.SelectOrNull<Extension, DataType>(w_, p_);
			CqlCode z_(DataType @this)
			{
				var ak_ = context.Operators.Convert<Coding>(@this);
				var al_ = FHIRHelpers_4_3_000.ToCode(ak_);

				return al_;
			};
			var aa_ = context.Operators.SelectOrNull<DataType, CqlCode>(y_, z_);
			var ab_ = context.Operators.ValueSetUnion((u_ as IEnumerable<CqlCode>), aa_);
			bool? ac_(Extension @this)
			{
				var am_ = context.Operators.Equal(@this?.Url, "text");

				return am_;
			};
			var ad_ = context.Operators.WhereOrNull<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), ac_);
			object ae_(Extension @this) => 
				@this?.Value;
			var af_ = context.Operators.SelectOrNull<Extension, object>(ad_, ae_);
			var ag_ = context.Operators.SingletonFrom<object>(af_);
			var ah_ = new Tuple_DMgHTLENEHBHWJISQgKZGZVMB
			{
				codes = ab_,
				display = (ag_ as string),
			};

			return ah_;
		};
		var g_ = context.Operators.SelectOrNull<Extension, Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(e_, f_);
		var h_ = context.Operators.SingletonFrom<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = this.Payer_Type();
		var b_ = context.Operators.RetrieveByValueSet<Coverage>(a_, null);
		Tuple_GDKRbfOIHhLGieQSVDEMIaDPX c_(Coverage Payer)
		{
			var e_ = FHIRHelpers_4_3_000.ToConcept(Payer?.Type);
			var f_ = FHIRHelpers_4_3_000.ToInterval(Payer?.Period);
			var g_ = new Tuple_GDKRbfOIHhLGieQSVDEMIaDPX
			{
				code = e_,
				period = f_,
			};

			return g_;
		};
		var d_ = context.Operators.SelectOrNull<Coverage, Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>(b_, c_);

		return d_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		List<Extension> a_()
		{
			bool i_()
			{
				var j_ = this.Patient();
				var k_ = j_ is DomainResource;

				return k_;
			};
			if (i_())
			{
				var l_ = this.Patient();

				return (l_ as DomainResource).Extension;
			}
			else
			{
				return null;
			};
		};
		bool? b_(Extension @this)
		{
			var m_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return m_;
		};
		var c_ = context.Operators.WhereOrNull<Extension>(a_(), b_);
		var d_ = context.Operators.SingletonFrom<Extension>(c_);
		var e_ = new Extension[]
		{
			d_,
		};
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB f_(Extension R)
		{
			bool? n_(Extension @this)
			{
				var ag_ = context.Operators.Equal(@this?.Url, "ombCategory");

				return ag_;
			};
			var o_ = context.Operators.WhereOrNull<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), n_);
			DataType p_(Extension @this) => 
				@this?.Value;
			var q_ = context.Operators.SelectOrNull<Extension, DataType>(o_, p_);
			CqlCode r_(DataType @this)
			{
				var ah_ = context.Operators.Convert<Coding>(@this);
				var ai_ = FHIRHelpers_4_3_000.ToCode(ah_);

				return ai_;
			};
			var s_ = context.Operators.SelectOrNull<DataType, CqlCode>(q_, r_);
			bool? t_(Extension @this)
			{
				var aj_ = context.Operators.Equal(@this?.Url, "detailed");

				return aj_;
			};
			var u_ = context.Operators.WhereOrNull<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), t_);
			var w_ = context.Operators.SelectOrNull<Extension, DataType>(u_, p_);
			CqlCode x_(DataType @this)
			{
				var ak_ = context.Operators.Convert<Coding>(@this);
				var al_ = FHIRHelpers_4_3_000.ToCode(ak_);

				return al_;
			};
			var y_ = context.Operators.SelectOrNull<DataType, CqlCode>(w_, x_);
			var z_ = context.Operators.ValueSetUnion(s_, y_);
			bool? aa_(Extension @this)
			{
				var am_ = context.Operators.Equal(@this?.Url, "text");

				return am_;
			};
			var ab_ = context.Operators.WhereOrNull<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), aa_);
			object ac_(Extension @this) => 
				@this?.Value;
			var ad_ = context.Operators.SelectOrNull<Extension, object>(ab_, ac_);
			var ae_ = context.Operators.SingletonFrom<object>(ad_);
			var af_ = new Tuple_DMgHTLENEHBHWJISQgKZGZVMB
			{
				codes = z_,
				display = (ae_ as string),
			};

			return af_;
		};
		var g_ = context.Operators.SelectOrNull<Extension, Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(e_, f_);
		var h_ = context.Operators.SingletonFrom<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_()
		{
			bool b_()
			{
				var d_ = this.Patient();
				var e_ = context.Operators.Convert<string>(d_?.GenderElement?.Value);
				var f_ = context.Operators.Equal(e_, "male");

				return (f_ ?? false);
			};
			bool c_()
			{
				var g_ = this.Patient();
				var h_ = context.Operators.Convert<string>(g_?.GenderElement?.Value);
				var i_ = context.Operators.Equal(h_, "female");

				return (i_ ?? false);
			};
			if (b_())
			{
				string j_ = null;

				return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", j_, "Male");
			}
			else if (c_())
			{
				string k_ = null;

				return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", k_, "Female");
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

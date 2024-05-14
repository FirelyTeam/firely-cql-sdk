using System;
using Tuples;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
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
    internal Lazy<Tuple_FCiIaGHASIIbfXNJKRgLLXbgj> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_COIQfKYbbjLZSGAMXWaFObiSa>> __SDE_Payer;
    internal Lazy<Tuple_FCiIaGHASIIbfXNJKRgLLXbgj> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_FCiIaGHASIIbfXNJKRgLLXbgj>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_COIQfKYbbjLZSGAMXWaFObiSa>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_FCiIaGHASIIbfXNJKRgLLXbgj>(this.SDE_Race_Value);
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

	private Tuple_FCiIaGHASIIbfXNJKRgLLXbgj SDE_Ethnicity_Value()
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
			var m_ = context.Operators.Convert<FhirUri>(@this?.Url);
			var n_ = FHIRHelpers_4_3_000.ToString(m_);
			var o_ = context.Operators.Equal(n_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return o_;
		};
		var c_ = context.Operators.Where<Extension>(a_(), b_);
		var d_ = context.Operators.SingletonFrom<Extension>(c_);
		var e_ = new Extension[]
		{
			d_,
		};
		Tuple_FCiIaGHASIIbfXNJKRgLLXbgj f_(Extension E)
		{
			bool? p_(Extension @this)
			{
				var al_ = context.Operators.Convert<FhirUri>(@this?.Url);
				var am_ = FHIRHelpers_4_3_000.ToString(al_);
				var an_ = context.Operators.Equal(am_, "ombCategory");

				return an_;
			};
			var q_ = context.Operators.Where<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), p_);
			DataType r_(Extension @this) => 
				@this?.Value;
			var s_ = context.Operators.Select<Extension, DataType>(q_, r_);
			var t_ = context.Operators.SingletonFrom<DataType>(s_);
			var u_ = context.Operators.Convert<Coding>(t_);
			var v_ = FHIRHelpers_4_3_000.ToCode(u_);
			var w_ = new CqlCode[]
			{
				v_,
			};
			bool? x_(Extension @this)
			{
				var ao_ = context.Operators.Convert<FhirUri>(@this?.Url);
				var ap_ = FHIRHelpers_4_3_000.ToString(ao_);
				var aq_ = context.Operators.Equal(ap_, "detailed");

				return aq_;
			};
			var y_ = context.Operators.Where<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), x_);
			var aa_ = context.Operators.Select<Extension, DataType>(y_, r_);
			CqlCode ab_(DataType @this)
			{
				var ar_ = context.Operators.Convert<Coding>(@this);
				var as_ = FHIRHelpers_4_3_000.ToCode(ar_);

				return as_;
			};
			var ac_ = context.Operators.Select<DataType, CqlCode>(aa_, ab_);
			var ad_ = context.Operators.ValueSetUnion((w_ as IEnumerable<CqlCode>), ac_);
			bool? ae_(Extension @this)
			{
				var at_ = context.Operators.Convert<FhirUri>(@this?.Url);
				var au_ = FHIRHelpers_4_3_000.ToString(at_);
				var av_ = context.Operators.Equal(au_, "text");

				return av_;
			};
			var af_ = context.Operators.Where<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), ae_);
			var ah_ = context.Operators.Select<Extension, DataType>(af_, r_);
			var ai_ = context.Operators.SingletonFrom<DataType>(ah_);
			var aj_ = context.Operators.Convert<string>(ai_);
			var ak_ = new Tuple_FCiIaGHASIIbfXNJKRgLLXbgj
			{
				codes = ad_,
				display = aj_,
			};

			return ak_;
		};
		var g_ = context.Operators.Select<Extension, Tuple_FCiIaGHASIIbfXNJKRgLLXbgj>(e_, f_);
		var h_ = context.Operators.SingletonFrom<Tuple_FCiIaGHASIIbfXNJKRgLLXbgj>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_FCiIaGHASIIbfXNJKRgLLXbgj SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_COIQfKYbbjLZSGAMXWaFObiSa> SDE_Payer_Value()
	{
		var a_ = this.Payer_Type();
		var b_ = context.Operators.RetrieveByValueSet<Coverage>(a_, null);
		Tuple_COIQfKYbbjLZSGAMXWaFObiSa c_(Coverage Payer)
		{
			var e_ = FHIRHelpers_4_3_000.ToConcept(Payer?.Type);
			var f_ = FHIRHelpers_4_3_000.ToInterval(Payer?.Period);
			var g_ = new Tuple_COIQfKYbbjLZSGAMXWaFObiSa
			{
				code = e_,
				period = f_,
			};

			return g_;
		};
		var d_ = context.Operators.Select<Coverage, Tuple_COIQfKYbbjLZSGAMXWaFObiSa>(b_, c_);

		return d_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_COIQfKYbbjLZSGAMXWaFObiSa> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_FCiIaGHASIIbfXNJKRgLLXbgj SDE_Race_Value()
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
			var m_ = context.Operators.Convert<FhirUri>(@this?.Url);
			var n_ = FHIRHelpers_4_3_000.ToString(m_);
			var o_ = context.Operators.Equal(n_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return o_;
		};
		var c_ = context.Operators.Where<Extension>(a_(), b_);
		var d_ = context.Operators.SingletonFrom<Extension>(c_);
		var e_ = new Extension[]
		{
			d_,
		};
		Tuple_FCiIaGHASIIbfXNJKRgLLXbgj f_(Extension R)
		{
			bool? p_(Extension @this)
			{
				var aj_ = context.Operators.Convert<FhirUri>(@this?.Url);
				var ak_ = FHIRHelpers_4_3_000.ToString(aj_);
				var al_ = context.Operators.Equal(ak_, "ombCategory");

				return al_;
			};
			var q_ = context.Operators.Where<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), p_);
			DataType r_(Extension @this) => 
				@this?.Value;
			var s_ = context.Operators.Select<Extension, DataType>(q_, r_);
			CqlCode t_(DataType @this)
			{
				var am_ = context.Operators.Convert<Coding>(@this);
				var an_ = FHIRHelpers_4_3_000.ToCode(am_);

				return an_;
			};
			var u_ = context.Operators.Select<DataType, CqlCode>(s_, t_);
			bool? v_(Extension @this)
			{
				var ao_ = context.Operators.Convert<FhirUri>(@this?.Url);
				var ap_ = FHIRHelpers_4_3_000.ToString(ao_);
				var aq_ = context.Operators.Equal(ap_, "detailed");

				return aq_;
			};
			var w_ = context.Operators.Where<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), v_);
			var y_ = context.Operators.Select<Extension, DataType>(w_, r_);
			CqlCode z_(DataType @this)
			{
				var ar_ = context.Operators.Convert<Coding>(@this);
				var as_ = FHIRHelpers_4_3_000.ToCode(ar_);

				return as_;
			};
			var aa_ = context.Operators.Select<DataType, CqlCode>(y_, z_);
			var ab_ = context.Operators.ValueSetUnion(u_, aa_);
			bool? ac_(Extension @this)
			{
				var at_ = context.Operators.Convert<FhirUri>(@this?.Url);
				var au_ = FHIRHelpers_4_3_000.ToString(at_);
				var av_ = context.Operators.Equal(au_, "text");

				return av_;
			};
			var ad_ = context.Operators.Where<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), ac_);
			var af_ = context.Operators.Select<Extension, DataType>(ad_, r_);
			var ag_ = context.Operators.SingletonFrom<DataType>(af_);
			var ah_ = context.Operators.Convert<string>(ag_);
			var ai_ = new Tuple_FCiIaGHASIIbfXNJKRgLLXbgj
			{
				codes = ab_,
				display = ah_,
			};

			return ai_;
		};
		var g_ = context.Operators.Select<Extension, Tuple_FCiIaGHASIIbfXNJKRgLLXbgj>(e_, f_);
		var h_ = context.Operators.SingletonFrom<Tuple_FCiIaGHASIIbfXNJKRgLLXbgj>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_FCiIaGHASIIbfXNJKRgLLXbgj SDE_Race() => 
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

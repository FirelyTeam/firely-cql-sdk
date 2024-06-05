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
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
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

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
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
			}
		};
		bool? b_(Extension @this)
		{
			var m_ = @this?.Url;
			var n_ = context.Operators.Convert<FhirUri>(m_);
			var o_ = FHIRHelpers_4_3_000.ToString(n_);
			var p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return p_;
		};
		var c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_(), b_);
		var d_ = context.Operators.SingletonFrom<Extension>(c_);
		var e_ = new Extension[]
		{
			d_,
		};
		Tuple_HPcCiDPXQfZTXIORThMLfTQDR f_(Extension E)
		{
			bool? q_(Extension @this)
			{
				var am_ = @this?.Url;
				var an_ = context.Operators.Convert<FhirUri>(am_);
				var ao_ = FHIRHelpers_4_3_000.ToString(an_);
				var ap_ = context.Operators.Equal(ao_, "ombCategory");

				return ap_;
			};
			var r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((E is Element)
					? ((E as Element).Extension)
					: null), q_);
			DataType s_(Extension @this)
			{
				var aq_ = @this?.Value;

				return aq_;
			};
			var t_ = context.Operators.Select<Extension, DataType>(r_, s_);
			var u_ = context.Operators.SingletonFrom<DataType>(t_);
			var v_ = context.Operators.Convert<Coding>(u_);
			var w_ = FHIRHelpers_4_3_000.ToCode(v_);
			var x_ = new CqlCode[]
			{
				w_,
			};
			bool? y_(Extension @this)
			{
				var ar_ = @this?.Url;
				var as_ = context.Operators.Convert<FhirUri>(ar_);
				var at_ = FHIRHelpers_4_3_000.ToString(as_);
				var au_ = context.Operators.Equal(at_, "detailed");

				return au_;
			};
			var z_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((E is Element)
					? ((E as Element).Extension)
					: null), y_);
			DataType aa_(Extension @this)
			{
				var av_ = @this?.Value;

				return av_;
			};
			var ab_ = context.Operators.Select<Extension, DataType>(z_, aa_);
			CqlCode ac_(DataType @this)
			{
				var aw_ = context.Operators.Convert<Coding>(@this);
				var ax_ = FHIRHelpers_4_3_000.ToCode(aw_);

				return ax_;
			};
			var ad_ = context.Operators.Select<DataType, CqlCode>(ab_, ac_);
			var ae_ = context.Operators.Union<CqlCode>((x_ as IEnumerable<CqlCode>), ad_);
			bool? af_(Extension @this)
			{
				var ay_ = @this?.Url;
				var az_ = context.Operators.Convert<FhirUri>(ay_);
				var ba_ = FHIRHelpers_4_3_000.ToString(az_);
				var bb_ = context.Operators.Equal(ba_, "text");

				return bb_;
			};
			var ag_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((E is Element)
					? ((E as Element).Extension)
					: null), af_);
			DataType ah_(Extension @this)
			{
				var bc_ = @this?.Value;

				return bc_;
			};
			var ai_ = context.Operators.Select<Extension, DataType>(ag_, ah_);
			var aj_ = context.Operators.SingletonFrom<DataType>(ai_);
			var ak_ = context.Operators.Convert<string>(aj_);
			var al_ = new Tuple_HPcCiDPXQfZTXIORThMLfTQDR
			{
				codes = ae_,
				display = ak_,
			};

			return al_;
		};
		var g_ = context.Operators.Select<Extension, Tuple_HPcCiDPXQfZTXIORThMLfTQDR>((IEnumerable<Extension>)e_, f_);
		var h_ = context.Operators.SingletonFrom<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		var a_ = this.Payer_Type();
		var b_ = context.Operators.RetrieveByValueSet<Coverage>(a_, null);
		Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ c_(Coverage Payer)
		{
			var e_ = Payer?.Type;
			var f_ = FHIRHelpers_4_3_000.ToConcept(e_);
			var g_ = Payer?.Period;
			var h_ = FHIRHelpers_4_3_000.ToInterval(g_);
			var i_ = new Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ
			{
				code = f_,
				period = h_,
			};

			return i_;
		};
		var d_ = context.Operators.Select<Coverage, Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>(b_, c_);

		return d_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
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
			}
		};
		bool? b_(Extension @this)
		{
			var m_ = @this?.Url;
			var n_ = context.Operators.Convert<FhirUri>(m_);
			var o_ = FHIRHelpers_4_3_000.ToString(n_);
			var p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return p_;
		};
		var c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_(), b_);
		var d_ = context.Operators.SingletonFrom<Extension>(c_);
		var e_ = new Extension[]
		{
			d_,
		};
		Tuple_HPcCiDPXQfZTXIORThMLfTQDR f_(Extension R)
		{
			bool? q_(Extension @this)
			{
				var ak_ = @this?.Url;
				var al_ = context.Operators.Convert<FhirUri>(ak_);
				var am_ = FHIRHelpers_4_3_000.ToString(al_);
				var an_ = context.Operators.Equal(am_, "ombCategory");

				return an_;
			};
			var r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((R is Element)
					? ((R as Element).Extension)
					: null), q_);
			DataType s_(Extension @this)
			{
				var ao_ = @this?.Value;

				return ao_;
			};
			var t_ = context.Operators.Select<Extension, DataType>(r_, s_);
			CqlCode u_(DataType @this)
			{
				var ap_ = context.Operators.Convert<Coding>(@this);
				var aq_ = FHIRHelpers_4_3_000.ToCode(ap_);

				return aq_;
			};
			var v_ = context.Operators.Select<DataType, CqlCode>(t_, u_);
			bool? w_(Extension @this)
			{
				var ar_ = @this?.Url;
				var as_ = context.Operators.Convert<FhirUri>(ar_);
				var at_ = FHIRHelpers_4_3_000.ToString(as_);
				var au_ = context.Operators.Equal(at_, "detailed");

				return au_;
			};
			var x_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((R is Element)
					? ((R as Element).Extension)
					: null), w_);
			DataType y_(Extension @this)
			{
				var av_ = @this?.Value;

				return av_;
			};
			var z_ = context.Operators.Select<Extension, DataType>(x_, y_);
			CqlCode aa_(DataType @this)
			{
				var aw_ = context.Operators.Convert<Coding>(@this);
				var ax_ = FHIRHelpers_4_3_000.ToCode(aw_);

				return ax_;
			};
			var ab_ = context.Operators.Select<DataType, CqlCode>(z_, aa_);
			var ac_ = context.Operators.Union<CqlCode>(v_, ab_);
			bool? ad_(Extension @this)
			{
				var ay_ = @this?.Url;
				var az_ = context.Operators.Convert<FhirUri>(ay_);
				var ba_ = FHIRHelpers_4_3_000.ToString(az_);
				var bb_ = context.Operators.Equal(ba_, "text");

				return bb_;
			};
			var ae_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((R is Element)
					? ((R as Element).Extension)
					: null), ad_);
			DataType af_(Extension @this)
			{
				var bc_ = @this?.Value;

				return bc_;
			};
			var ag_ = context.Operators.Select<Extension, DataType>(ae_, af_);
			var ah_ = context.Operators.SingletonFrom<DataType>(ag_);
			var ai_ = context.Operators.Convert<string>(ah_);
			var aj_ = new Tuple_HPcCiDPXQfZTXIORThMLfTQDR
			{
				codes = ac_,
				display = ai_,
			};

			return aj_;
		};
		var g_ = context.Operators.Select<Extension, Tuple_HPcCiDPXQfZTXIORThMLfTQDR>((IEnumerable<Extension>)e_, f_);
		var h_ = context.Operators.SingletonFrom<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_()
		{
			bool b_()
			{
				var d_ = this.Patient();
				var e_ = d_?.GenderElement;
				var f_ = e_?.Value;
				var g_ = context.Operators.Convert<string>(f_);
				var h_ = context.Operators.Equal(g_, "male");

				return (h_ ?? false);
			};
			bool c_()
			{
				var i_ = this.Patient();
				var j_ = i_?.GenderElement;
				var k_ = j_?.Value;
				var l_ = context.Operators.Convert<string>(k_);
				var m_ = context.Operators.Equal(l_, "female");

				return (m_ ?? false);
			};
			if (b_())
			{
				return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Male");
			}
			else if (c_())
			{
				return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Female");
			}
			else
			{
				return null;
			}
		};

		return a_();
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}

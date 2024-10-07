using System;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("SupplementalDataElementsFHIR4", "2.0.000")]
public partial class SupplementalDataElementsFHIR4_2_0_000 : ISingleton<SupplementalDataElementsFHIR4_2_0_000>
{
    private SupplementalDataElementsFHIR4_2_0_000() {}

    public static SupplementalDataElementsFHIR4_2_0_000 Instance { get; } = new();


    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public CqlValueSet Ethnicity(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", default);


    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public CqlValueSet ONC_Administrative_Sex(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", default);


    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public CqlValueSet Payer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", default);


    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public CqlValueSet Race(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", default);


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
	{
		IEnumerable<Extension> a_()
		{
			bool k_()
			{
				Patient l_ = this.Patient(context);
				bool m_ = l_ is DomainResource;

				return m_;
			};
			if (k_())
			{
				Patient n_ = this.Patient(context);

				return (IEnumerable<Extension>)((n_ as DomainResource).Extension);
			}
			else
			{
				return default;
			}
		};
		bool? b_(Extension Extension)
		{
			string o_ = Extension?.Url;
			FhirUri p_ = context.Operators.Convert<FhirUri>(o_);
			string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
			bool? r_ = context.Operators.Equal(q_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return r_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>(a_(), b_);
		IEnumerable<Extension> d_(Extension Extension)
		{
			List<Extension> s_ = Extension?.Extension;

			return (IEnumerable<Extension>)s_;
		};
		IEnumerable<IEnumerable<Extension>> e_ = context.Operators.Select<Extension, IEnumerable<Extension>>(c_, d_);
		IEnumerable<Extension> f_ = context.Operators.Flatten<Extension>(e_);
		bool? g_(Extension E)
		{
			string t_ = E?.Url;
			FhirUri u_ = context.Operators.Convert<FhirUri>(t_);
			string v_ = FHIRHelpers_4_0_001.Instance.ToString(context, u_);
			bool? w_ = context.Operators.Equal(v_, "ombCategory");
			FhirUri y_ = context.Operators.Convert<FhirUri>(t_);
			string z_ = FHIRHelpers_4_0_001.Instance.ToString(context, y_);
			bool? aa_ = context.Operators.Equal(z_, "detailed");
			bool? ab_ = context.Operators.Or(w_, aa_);

			return ab_;
		};
		IEnumerable<Extension> h_ = context.Operators.Where<Extension>(f_, g_);
		Coding i_(Extension E)
		{
			DataType ac_ = E?.Value;

			return ac_ as Coding;
		};
		IEnumerable<Coding> j_ = context.Operators.Select<Extension, Coding>(h_, i_);

		return j_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
	{
		CqlValueSet a_ = this.Payer(context);
		IEnumerable<Coverage> b_ = context.Operators.RetrieveByValueSet<Coverage>(a_, default);
		(CodeableConcept code, Period period)? c_(Coverage Payer)
		{
			CodeableConcept e_ = Payer?.Type;
			Period f_ = Payer?.Period;
			(CodeableConcept code, Period period)? g_ = (e_, f_);

			return g_;
		};
		IEnumerable<(CodeableConcept code, Period period)?> d_ = context.Operators.Select<Coverage, (CodeableConcept code, Period period)?>(b_, c_);

		return d_;
	}


    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race(CqlContext context)
	{
		IEnumerable<Extension> a_()
		{
			bool k_()
			{
				Patient l_ = this.Patient(context);
				bool m_ = l_ is DomainResource;

				return m_;
			};
			if (k_())
			{
				Patient n_ = this.Patient(context);

				return (IEnumerable<Extension>)((n_ as DomainResource).Extension);
			}
			else
			{
				return default;
			}
		};
		bool? b_(Extension Extension)
		{
			string o_ = Extension?.Url;
			FhirUri p_ = context.Operators.Convert<FhirUri>(o_);
			string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
			bool? r_ = context.Operators.Equal(q_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return r_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>(a_(), b_);
		IEnumerable<Extension> d_(Extension Extension)
		{
			List<Extension> s_ = Extension?.Extension;

			return (IEnumerable<Extension>)s_;
		};
		IEnumerable<IEnumerable<Extension>> e_ = context.Operators.Select<Extension, IEnumerable<Extension>>(c_, d_);
		IEnumerable<Extension> f_ = context.Operators.Flatten<Extension>(e_);
		bool? g_(Extension E)
		{
			string t_ = E?.Url;
			FhirUri u_ = context.Operators.Convert<FhirUri>(t_);
			string v_ = FHIRHelpers_4_0_001.Instance.ToString(context, u_);
			bool? w_ = context.Operators.Equal(v_, "ombCategory");
			FhirUri y_ = context.Operators.Convert<FhirUri>(t_);
			string z_ = FHIRHelpers_4_0_001.Instance.ToString(context, y_);
			bool? aa_ = context.Operators.Equal(z_, "detailed");
			bool? ab_ = context.Operators.Or(w_, aa_);

			return ab_;
		};
		IEnumerable<Extension> h_ = context.Operators.Where<Extension>(f_, g_);
		Coding i_(Extension E)
		{
			DataType ac_ = E?.Value;

			return ac_ as Coding;
		};
		IEnumerable<Coding> j_ = context.Operators.Select<Extension, Coding>(h_, i_);

		return j_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_()
		{
			bool b_()
			{
				Patient d_ = this.Patient(context);
				Code<AdministrativeGender> e_ = d_?.GenderElement;
				string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
				bool? g_ = context.Operators.Equal(f_, "male");

				return g_ ?? false;
			};
			bool c_()
			{
				Patient h_ = this.Patient(context);
				Code<AdministrativeGender> i_ = h_?.GenderElement;
				string j_ = FHIRHelpers_4_0_001.Instance.ToString(context, i_);
				bool? k_ = context.Operators.Equal(j_, "female");

				return k_ ?? false;
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
				return default;
			}
		};

		return a_();
	}

}

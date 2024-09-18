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
[CqlLibrary("SupplementalDataElementsFHIR4", "2.0.000")]
public class SupplementalDataElementsFHIR4_2_0_000
{

    public static SupplementalDataElementsFHIR4_2_0_000 Instance { get; }  = new();

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public CqlValueSet Ethnicity(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public CqlValueSet ONC_Administrative_Sex(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public CqlValueSet Payer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public CqlValueSet Race(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
	{
		IEnumerable<Extension> a_()
		{
			if (this.Patient(context) is DomainResource)
			{
				var k_ = this.Patient(context);

				return ((k_ as DomainResource).Extension as IEnumerable<Extension>);
			}
			else
			{
				return (null as IEnumerable<Extension>);
			};
		};
		bool? b_(Extension Extension)
		{
			var l_ = context.Operators.Convert<FhirUri>(Extension?.Url);
			var m_ = context.Operators.Convert<string>(l_);
			var n_ = context.Operators.Equal(m_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return n_;
		};
		var c_ = context.Operators.WhereOrNull<Extension>(a_(), b_);
		IEnumerable<Extension> d_(Extension Extension) => 
			(Extension?.Extension as IEnumerable<Extension>);
		var e_ = context.Operators.SelectOrNull<Extension, IEnumerable<Extension>>(c_, d_);
		var f_ = context.Operators.FlattenList<Extension>(e_);
		bool? g_(Extension E)
		{
			var o_ = context.Operators.Convert<FhirUri>(E?.Url);
			var p_ = context.Operators.Convert<string>(o_);
			var q_ = context.Operators.Equal(p_, "ombCategory");
			var s_ = context.Operators.Convert<string>(o_);
			var t_ = context.Operators.Equal(s_, "detailed");
			var u_ = context.Operators.Or(q_, t_);

			return u_;
		};
		var h_ = context.Operators.WhereOrNull<Extension>(f_, g_);
		Coding i_(Extension E) => 
			(E?.Value as Coding);
		var j_ = context.Operators.SelectOrNull<Extension, Coding>(h_, i_);

		return j_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer(CqlContext context)
	{
		var a_ = this.Payer(context);
		var b_ = context.Operators.RetrieveByValueSet<Coverage>(a_, null);
		Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG c_(Coverage Payer)
		{
			var e_ = new Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG
			{
				code = Payer?.Type,
				period = Payer?.Period,
			};

			return e_;
		};
		var d_ = context.Operators.SelectOrNull<Coverage, Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>(b_, c_);

		return d_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race(CqlContext context)
	{
		IEnumerable<Extension> a_()
		{
			if (this.Patient(context) is DomainResource)
			{
				var k_ = this.Patient(context);

				return ((k_ as DomainResource).Extension as IEnumerable<Extension>);
			}
			else
			{
				return (null as IEnumerable<Extension>);
			};
		};
		bool? b_(Extension Extension)
		{
			var l_ = context.Operators.Convert<FhirUri>(Extension?.Url);
			var m_ = context.Operators.Convert<string>(l_);
			var n_ = context.Operators.Equal(m_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return n_;
		};
		var c_ = context.Operators.WhereOrNull<Extension>(a_(), b_);
		IEnumerable<Extension> d_(Extension Extension) => 
			(Extension?.Extension as IEnumerable<Extension>);
		var e_ = context.Operators.SelectOrNull<Extension, IEnumerable<Extension>>(c_, d_);
		var f_ = context.Operators.FlattenList<Extension>(e_);
		bool? g_(Extension E)
		{
			var o_ = context.Operators.Convert<FhirUri>(E?.Url);
			var p_ = context.Operators.Convert<string>(o_);
			var q_ = context.Operators.Equal(p_, "ombCategory");
			var s_ = context.Operators.Convert<string>(o_);
			var t_ = context.Operators.Equal(s_, "detailed");
			var u_ = context.Operators.Or(q_, t_);

			return u_;
		};
		var h_ = context.Operators.WhereOrNull<Extension>(f_, g_);
		Coding i_(Extension E) => 
			(E?.Value as Coding);
		var j_ = context.Operators.SelectOrNull<Extension, Coding>(h_, i_);

		return j_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_()
		{
			if ((context.Operators.Equal(context.Operators.Convert<string>(this.Patient(context)?.GenderElement), "male") ?? false))
			{
				string b_ = null;

				return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", b_, "Male");
			}
			else if ((context.Operators.Equal(context.Operators.Convert<string>(this.Patient(context)?.GenderElement), "female") ?? false))
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

}
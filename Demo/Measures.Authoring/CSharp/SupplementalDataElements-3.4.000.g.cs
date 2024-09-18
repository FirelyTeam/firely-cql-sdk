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

#pragma warning disable CS9113 // Parameter is unread.

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("SupplementalDataElements", "3.4.000")]
public partial class SupplementalDataElements_3_4_000(
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000)
{

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public  CqlValueSet Ethnicity(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", default);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public  CqlValueSet ONC_Administrative_Sex(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", default);

    [CqlDeclaration("Payer Type")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public  CqlValueSet Payer_Type(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", default);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public  CqlValueSet Race(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", default);

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public  (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		List<Extension> a_()
		{
			bool i_()
			{
				Patient j_ = this.Patient(context);
				bool k_ = j_ is DomainResource;

				return k_;
			};
			if (i_())
			{
				Patient l_ = this.Patient(context);

				return (l_ as DomainResource).Extension;
			}
			else
			{
				return default;
			}
		};
		bool? b_(Extension @this)
		{
			string m_ = @this?.Url;
			FhirString n_ = context.Operators.Convert<FhirString>(m_);
			string o_ = fhirHelpers_4_3_000.ToString(context, n_);
			bool? p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return p_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(a_()), b_);
		Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
		Extension[] e_ = [
			d_,
		];
		(IEnumerable<CqlCode> codes, string display)? f_(Extension E)
		{
			bool? q_(Extension @this)
			{
				string al_ = @this?.Url;
				FhirString am_ = context.Operators.Convert<FhirString>(al_);
				string an_ = fhirHelpers_4_3_000.ToString(context, am_);
				bool? ao_ = context.Operators.Equal(an_, "ombCategory");

				return ao_;
			};
			IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
					? (E as Element).Extension
					: default), q_);
			object s_(Extension @this)
			{
				DataType ap_ = @this?.Value;

				return ap_;
			};
			IEnumerable<object> t_ = context.Operators.Select<Extension, object>(r_, s_);
			object u_ = context.Operators.SingletonFrom<object>(t_);
			CqlCode v_ = fhirHelpers_4_3_000.ToCode(context, u_ as Coding);
			CqlCode[] w_ = [
				v_,
			];
			bool? x_(Extension @this)
			{
				string aq_ = @this?.Url;
				FhirString ar_ = context.Operators.Convert<FhirString>(aq_);
				string as_ = fhirHelpers_4_3_000.ToString(context, ar_);
				bool? at_ = context.Operators.Equal(as_, "detailed");

				return at_;
			};
			IEnumerable<Extension> y_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
					? (E as Element).Extension
					: default), x_);
			object z_(Extension @this)
			{
				DataType au_ = @this?.Value;

				return au_;
			};
			IEnumerable<object> aa_ = context.Operators.Select<Extension, object>(y_, z_);
			CqlCode ab_(object @this)
			{
				CqlCode av_ = fhirHelpers_4_3_000.ToCode(context, @this as Coding);

				return av_;
			};
			IEnumerable<CqlCode> ac_ = context.Operators.Select<object, CqlCode>(aa_, ab_);
			IEnumerable<CqlCode> ad_ = context.Operators.Union<CqlCode>(w_ as IEnumerable<CqlCode>, ac_);
			bool? ae_(Extension @this)
			{
				string aw_ = @this?.Url;
				FhirString ax_ = context.Operators.Convert<FhirString>(aw_);
				string ay_ = fhirHelpers_4_3_000.ToString(context, ax_);
				bool? az_ = context.Operators.Equal(ay_, "text");

				return az_;
			};
			IEnumerable<Extension> af_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
					? (E as Element).Extension
					: default), ae_);
			DataType ag_(Extension @this)
			{
				DataType ba_ = @this?.Value;

				return ba_;
			};
			IEnumerable<DataType> ah_ = context.Operators.Select<Extension, DataType>(af_, ag_);
			DataType ai_ = context.Operators.SingletonFrom<DataType>(ah_);
			string aj_ = context.Operators.Convert<string>(ai_);
			(IEnumerable<CqlCode> codes, string display)? ak_ = (ad_, aj_);

			return ak_;
		};
		IEnumerable<(IEnumerable<CqlCode> codes, string display)?> g_ = context.Operators.Select<Extension, (IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
		(IEnumerable<CqlCode> codes, string display)? h_ = context.Operators.SingletonFrom<(IEnumerable<CqlCode> codes, string display)?>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Payer")]
	public  IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		CqlValueSet a_ = this.Payer_Type(context);
		IEnumerable<Coverage> b_ = context.Operators.RetrieveByValueSet<Coverage>(a_, default);
		(CqlConcept code, CqlInterval<CqlDateTime> period)? c_(Coverage Payer)
		{
			CodeableConcept e_ = Payer?.Type;
			CqlConcept f_ = fhirHelpers_4_3_000.ToConcept(context, e_);
			Period g_ = Payer?.Period;
			CqlInterval<CqlDateTime> h_ = fhirHelpers_4_3_000.ToInterval(context, g_);
			(CqlConcept code, CqlInterval<CqlDateTime> period)? i_ = (f_, h_);

			return i_;
		};
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> d_ = context.Operators.Select<Coverage, (CqlConcept code, CqlInterval<CqlDateTime> period)?>(b_, c_);

		return d_;
	}

    [CqlDeclaration("SDE Race")]
	public  (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		List<Extension> a_()
		{
			bool i_()
			{
				Patient j_ = this.Patient(context);
				bool k_ = j_ is DomainResource;

				return k_;
			};
			if (i_())
			{
				Patient l_ = this.Patient(context);

				return (l_ as DomainResource).Extension;
			}
			else
			{
				return default;
			}
		};
		bool? b_(Extension @this)
		{
			string m_ = @this?.Url;
			FhirString n_ = context.Operators.Convert<FhirString>(m_);
			string o_ = fhirHelpers_4_3_000.ToString(context, n_);
			bool? p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return p_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(a_()), b_);
		Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
		Extension[] e_ = [
			d_,
		];
		(IEnumerable<CqlCode> codes, string display)? f_(Extension R)
		{
			bool? q_(Extension @this)
			{
				string ak_ = @this?.Url;
				FhirString al_ = context.Operators.Convert<FhirString>(ak_);
				string am_ = fhirHelpers_4_3_000.ToString(context, al_);
				bool? an_ = context.Operators.Equal(am_, "ombCategory");

				return an_;
			};
			IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
					? (R as Element).Extension
					: default), q_);
			object s_(Extension @this)
			{
				DataType ao_ = @this?.Value;

				return ao_;
			};
			IEnumerable<object> t_ = context.Operators.Select<Extension, object>(r_, s_);
			CqlCode u_(object @this)
			{
				CqlCode ap_ = fhirHelpers_4_3_000.ToCode(context, @this as Coding);

				return ap_;
			};
			IEnumerable<CqlCode> v_ = context.Operators.Select<object, CqlCode>(t_, u_);
			bool? w_(Extension @this)
			{
				string aq_ = @this?.Url;
				FhirString ar_ = context.Operators.Convert<FhirString>(aq_);
				string as_ = fhirHelpers_4_3_000.ToString(context, ar_);
				bool? at_ = context.Operators.Equal(as_, "detailed");

				return at_;
			};
			IEnumerable<Extension> x_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
					? (R as Element).Extension
					: default), w_);
			object y_(Extension @this)
			{
				DataType au_ = @this?.Value;

				return au_;
			};
			IEnumerable<object> z_ = context.Operators.Select<Extension, object>(x_, y_);
			CqlCode aa_(object @this)
			{
				CqlCode av_ = fhirHelpers_4_3_000.ToCode(context, @this as Coding);

				return av_;
			};
			IEnumerable<CqlCode> ab_ = context.Operators.Select<object, CqlCode>(z_, aa_);
			IEnumerable<CqlCode> ac_ = context.Operators.Union<CqlCode>(v_, ab_);
			bool? ad_(Extension @this)
			{
				string aw_ = @this?.Url;
				FhirString ax_ = context.Operators.Convert<FhirString>(aw_);
				string ay_ = fhirHelpers_4_3_000.ToString(context, ax_);
				bool? az_ = context.Operators.Equal(ay_, "text");

				return az_;
			};
			IEnumerable<Extension> ae_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
					? (R as Element).Extension
					: default), ad_);
			DataType af_(Extension @this)
			{
				DataType ba_ = @this?.Value;

				return ba_;
			};
			IEnumerable<DataType> ag_ = context.Operators.Select<Extension, DataType>(ae_, af_);
			DataType ah_ = context.Operators.SingletonFrom<DataType>(ag_);
			string ai_ = context.Operators.Convert<string>(ah_);
			(IEnumerable<CqlCode> codes, string display)? aj_ = (ac_, ai_);

			return aj_;
		};
		IEnumerable<(IEnumerable<CqlCode> codes, string display)?> g_ = context.Operators.Select<Extension, (IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
		(IEnumerable<CqlCode> codes, string display)? h_ = context.Operators.SingletonFrom<(IEnumerable<CqlCode> codes, string display)?>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Sex")]
	public  CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_()
		{
			bool b_()
			{
				Patient d_ = this.Patient(context);
				Code<AdministrativeGender> e_ = d_?.GenderElement;
				AdministrativeGender? f_ = e_?.Value;
				string g_ = context.Operators.Convert<string>(f_);
				bool? h_ = context.Operators.Equal(g_, "male");

				return h_ ?? false;
			};
			bool c_()
			{
				Patient i_ = this.Patient(context);
				Code<AdministrativeGender> j_ = i_?.GenderElement;
				AdministrativeGender? k_ = j_?.Value;
				string l_ = context.Operators.Convert<string>(k_);
				bool? m_ = context.Operators.Equal(l_, "female");

				return m_ ?? false;
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

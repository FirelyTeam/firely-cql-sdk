using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("ParametersExample", "0.0.1")]
public partial class ParametersExample_0_0_1 : ILibrary, ISingleton<ParametersExample_0_0_1>
{
    private ParametersExample_0_0_1() {}

    public static ParametersExample_0_0_1 Instance { get; } = new();

    #region Library Members
    public string Name => "ParametersExample";
    public string Version => "0.0.1";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Marital Status")]
    [CqlValueSet("http://hl7.org/fhir/ValueSet/marital-status")]
    public CqlValueSet Marital_Status(CqlContext context) => 
        new CqlValueSet("http://hl7.org/fhir/ValueSet/marital-status", default);


    [CqlDeclaration("AgeThreshold")]
    public int? AgeThreshold(CqlContext context)
    {
        object a_ = context.ResolveParameter("ParametersExample-0.0.1", "AgeThreshold", 30);

        return (int?)a_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("CurrentDate")]
    public CqlDate CurrentDate(CqlContext context)
    {
        CqlDate a_ = context.Operators.Today();

        return a_;
    }


    [CqlDeclaration("Patient Filter")]
    public Patient Patient_Filter(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Patient[] b_ = [
            a_,
        ];
        bool? c_(Patient P)
        {
            Code<AdministrativeGender> f_ = P?.GenderElement;
            string g_ = FHIRHelpers_4_3_000.Instance.ToString(context, f_);
            bool? h_ = context.Operators.Equal(g_, "male");
            FhirBoolean i_ = P?.ActiveElement;
            bool? j_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, i_);
            bool? k_ = context.Operators.IsTrue(j_);
            bool? l_ = context.Operators.And(h_, k_);
            DataType m_ = P?.Deceased;
            bool? n_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, m_ as FhirBoolean);
            bool? o_ = context.Operators.Not(n_);
            bool? p_ = context.Operators.And(l_, o_);
            CodeableConcept q_ = P?.MaritalStatus;
            CqlConcept r_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, q_);
            CqlValueSet s_ = this.Marital_Status(context);
            bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
            bool? u_ = context.Operators.And(p_, t_);

            return u_;
        };
        IEnumerable<Patient> d_ = context.Operators.Where<Patient>((IEnumerable<Patient>)b_, c_);
        Patient e_ = context.Operators.SingletonFrom<Patient>(d_);

        return e_;
    }


    [CqlDeclaration("Patient Birthdate")]
    public Date Patient_Birthdate(CqlContext context)
    {
        Patient a_ = this.Patient_Filter(context);
        Date b_ = a_?.BirthDateElement;

        return b_;
    }


    [CqlDeclaration("Patient Age in Years")]
    public int? Patient_Age_in_Years(CqlContext context)
    {
        Date a_ = this.Patient_Birthdate(context);
        CqlDate b_ = FHIRHelpers_4_3_000.Instance.ToDate(context, a_);
        CqlDate c_ = this.CurrentDate(context);
        int? d_ = context.Operators.DurationBetween(b_, c_, "year");

        return d_;
    }


    [CqlDeclaration("Patient Older Than AgeThreshold")]
    public bool? Patient_Older_Than_AgeThreshold(CqlContext context)
    {
        int? a_ = this.Patient_Age_in_Years(context);
        int? b_ = this.AgeThreshold(context);
        bool? c_ = context.Operators.Greater(a_, b_);

        return c_;
    }

}

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.1.0")]
[CqlLibrary("ParametersExample", "0.0.1")]
public partial class ParametersExample_0_0_1 : ILibrary, ISingleton<ParametersExample_0_0_1>
{
    #region ValueSets (1)

    [CqlValueSetDefinition("Marital Status", valueSetId: "http://hl7.org/fhir/ValueSet/marital-status", valueSetVersion: null)]
    public CqlValueSet Marital_Status(CqlContext _) => _Marital_Status;
    private static readonly CqlValueSet _Marital_Status = new CqlValueSet("http://hl7.org/fhir/ValueSet/marital-status", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("AgeThreshold")]
    public int? AgeThreshold(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_AgeThreshold, AgeThreshold_Compute);

    private const long _cacheIndex_AgeThreshold = 24614955827976076L;

    private int? AgeThreshold_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("ParametersExample-0.0.1", "AgeThreshold", 30);
        return (int?)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (6)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -2419106794441990221L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("CurrentDate")]
    public CqlDate CurrentDate(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_CurrentDate, CurrentDate_Compute);

    private const long _cacheIndex_CurrentDate = 1522499957662536051L;

    private CqlDate CurrentDate_Compute(CqlContext context)
    {
        CqlDate a_ = context.Operators.Today();
        return a_;
    }


    [CqlExpressionDefinition("Patient Filter")]
    public Patient Patient_Filter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient_Filter, Patient_Filter_Compute);

    private const long _cacheIndex_Patient_Filter = 7766613094596543236L;

    private Patient Patient_Filter_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Patient[] b_ = [
            a_,
        ];

        bool? c_(Patient P) {
            Code<AdministrativeGender> f_ = P?.GenderElement;
            string g_ = FHIRHelpers_4_3_000.Instance.ToString(context, f_);
            bool? h_ = context.Operators.Equal(g_, "male");

            CqlBoolean i_() {
                FhirBoolean l_ = P?.ActiveElement;
                bool? m_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, l_);
                return (bool?)(/* CQL 'is true' (19:11-19:26) */ m_ is true);
            }


            CqlBoolean j_() {
                DataType n_ = P?.Deceased;
                bool? o_ = FHIRHelpers_4_3_000.Instance.ToBoolean(context, n_ as FhirBoolean);
                return !o_;
            }


            CqlBoolean k_() {
                CodeableConcept p_ = P?.MaritalStatus;
                CqlConcept q_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, p_);
                CqlValueSet r_ = this.Marital_Status(context);
                bool? s_ = context.Operators.ConceptInValueSet(q_, r_);
                return s_;
            }

            return /* CQL 'and' (18:5-21:45) */ (/* CQL 'and' (18:11-20:25) */ (/* CQL 'and' (18:11-19:26) */ ((CqlBoolean)h_
                && i_())
                && j_())
                && k_());
        }

        IEnumerable<Patient> d_ = context.Operators.Where<Patient>((IEnumerable<Patient>)b_, c_);
        Patient e_ = context.Operators.SingletonFrom<Patient>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Patient Birthdate")]
    public Date Patient_Birthdate(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient_Birthdate, Patient_Birthdate_Compute);

    private const long _cacheIndex_Patient_Birthdate = -274790349316496141L;

    private Date Patient_Birthdate_Compute(CqlContext context)
    {
        Patient a_ = this.Patient_Filter(context);
        Date b_ = a_?.BirthDateElement;
        return b_;
    }


    [CqlExpressionDefinition("Patient Age in Years")]
    public int? Patient_Age_in_Years(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient_Age_in_Years, Patient_Age_in_Years_Compute);

    private const long _cacheIndex_Patient_Age_in_Years = 5272699714539778757L;

    private int? Patient_Age_in_Years_Compute(CqlContext context)
    {
        Date a_ = this.Patient_Birthdate(context);
        CqlDate b_ = FHIRHelpers_4_3_000.Instance.ToDate(context, a_);
        CqlDate c_ = this.CurrentDate(context);
        int? d_ = context.Operators.DurationBetween(b_, c_, "year");
        return d_;
    }


    [CqlExpressionDefinition("Patient Older Than AgeThreshold")]
    public bool? Patient_Older_Than_AgeThreshold(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient_Older_Than_AgeThreshold, Patient_Older_Than_AgeThreshold_Compute);

    private const long _cacheIndex_Patient_Older_Than_AgeThreshold = -6736663683244303383L;

    private bool? Patient_Older_Than_AgeThreshold_Compute(CqlContext context)
    {
        int? a_ = this.Patient_Age_in_Years(context);
        int? b_ = this.AgeThreshold(context);
        bool? c_ = context.Operators.Greater(a_, b_);
        return c_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private ParametersExample_0_0_1() {}

    public static ParametersExample_0_0_1 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "ParametersExample";
    public string Version => "0.0.1";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];

    #endregion ILibrary Implementation

}

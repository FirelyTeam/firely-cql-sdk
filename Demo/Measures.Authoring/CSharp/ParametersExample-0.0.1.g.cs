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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("ParametersExample", "0.0.1")]
public partial class ParametersExample_0_0_1 : ILibrary, ILibraryInternals, ISingleton<ParametersExample_0_0_1>
{
    #region ValueSets (1)

    [CqlValueSetDefinition("Marital Status", valueSetId: "http://hl7.org/fhir/ValueSet/marital-status", valueSetVersion: null)]
    public CqlValueSet Marital_Status(CqlContext _) => _Marital_Status;
    private static readonly CqlValueSet _Marital_Status = new CqlValueSet("http://hl7.org/fhir/ValueSet/marital-status", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("AgeThreshold")]
    public int? AgeThreshold(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_AgeThreshold, AgeThreshold_Compute);

    private int? AgeThreshold_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("ParametersExample-0.0.1", "AgeThreshold", 30);
        return (int?)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (6)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("CurrentDate")]
    public CqlDate CurrentDate(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_CurrentDate, CurrentDate_Compute);

    private CqlDate CurrentDate_Compute(CqlContext context)
    {
        CqlDate a_ = context.Operators.Today();
        return a_;
    }


    [CqlExpressionDefinition("Patient Filter")]
    public Patient Patient_Filter(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Patient_Filter, Patient_Filter_Compute);

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
        }

        IEnumerable<Patient> d_ = context.Operators.Where<Patient>((IEnumerable<Patient>)b_, c_);
        Patient e_ = context.Operators.SingletonFrom<Patient>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Patient Birthdate")]
    public Date Patient_Birthdate(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Patient_Birthdate, Patient_Birthdate_Compute);

    private Date Patient_Birthdate_Compute(CqlContext context)
    {
        Patient a_ = this.Patient_Filter(context);
        Date b_ = a_?.BirthDateElement;
        return b_;
    }


    [CqlExpressionDefinition("Patient Age in Years")]
    public int? Patient_Age_in_Years(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Patient_Age_in_Years, Patient_Age_in_Years_Compute);

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
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Patient_Older_Than_AgeThreshold, Patient_Older_Than_AgeThreshold_Compute);

    private bool? Patient_Older_Than_AgeThreshold_Compute(CqlContext context)
    {
        int? a_ = this.Patient_Age_in_Years(context);
        int? b_ = this.AgeThreshold(context);
        bool? c_ = context.Operators.Greater(a_, b_);
        return c_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (7)

    private int _cacheIndex_AgeThreshold = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_CurrentDate = -1;
    private int _cacheIndex_Patient_Filter = -1;
    private int _cacheIndex_Patient_Birthdate = -1;
    private int _cacheIndex_Patient_Age_in_Years = -1;
    private int _cacheIndex_Patient_Older_Than_AgeThreshold = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_AgeThreshold = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_CurrentDate = index++;
        _cacheIndex_Patient_Filter = index++;
        _cacheIndex_Patient_Birthdate = index++;
        _cacheIndex_Patient_Age_in_Years = index++;
        _cacheIndex_Patient_Older_Than_AgeThreshold = index++;
        return index - startIndex;
    }

    #endregion ILibraryInternals Implementation

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

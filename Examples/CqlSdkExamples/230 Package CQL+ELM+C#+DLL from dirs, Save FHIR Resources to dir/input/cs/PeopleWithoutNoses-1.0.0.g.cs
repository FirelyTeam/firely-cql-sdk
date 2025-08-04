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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("PeopleWithoutNoses", "1.0.0")]
public partial class PeopleWithoutNoses_1_0_0 : ILibrary, ISingleton<PeopleWithoutNoses_1_0_0>
{
    private PeopleWithoutNoses_1_0_0() {}

    public static PeopleWithoutNoses_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "PeopleWithoutNoses";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region Codes

    [CqlCodeDefinition("Absent nose", codeId: "249300009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Absent_nose(CqlContext _) => _Absent_nose;
    private static readonly CqlCode _Absent_nose = new CqlCode("249300009", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMED", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMED(CqlContext _) => _SNOMED;
    private static readonly CqlCodeSystem _SNOMED =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Absent_nose]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("PeopleWithoutNoses-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Absent Nose Condition")]
    public IEnumerable<Condition> Absent_Nose_Condition(CqlContext context)
    {
        IEnumerable<Condition> a_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? b_(Condition C)
        {
            CodeableConcept d_ = C?.Code;
            List<Coding> e_ = d_?.Coding;
            bool? f_(Coding coding)
            {
                CqlCode n_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
                CqlCode o_ = this.Absent_nose(context);
                bool? p_ = context.Operators.Equivalent(n_, o_);

                return p_;
            };
            IEnumerable<Coding> g_ = context.Operators.Where<Coding>((IEnumerable<Coding>)e_, f_);
            bool? h_ = context.Operators.Exists<Coding>(g_);
            DataType i_ = C?.Onset;
            CqlDateTime j_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, i_ as FhirDateTime);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, default);
            bool? m_ = context.Operators.And(h_, l_);

            return m_;
        };
        IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Initial population")]
    public bool? Initial_population(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Absent_Nose_Condition(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);

        return b_;
    }


    #endregion Expressions

}

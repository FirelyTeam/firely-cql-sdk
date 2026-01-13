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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.0.0.0")]
[CqlLibrary("NCQAHospice", "1.0.0")]
public partial class NCQAHospice_1_0_0 : ILibrary, ISingleton<NCQAHospice_1_0_0>
{
    #region ValueSets

    [CqlValueSetDefinition("Hospice Encounter", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1761", valueSetVersion: null)]
    public CqlValueSet Hospice_Encounter(CqlContext _) => _Hospice_Encounter;
    private static readonly CqlValueSet _Hospice_Encounter = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1761", null);

    [CqlValueSetDefinition("Hospice Intervention", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762", valueSetVersion: null)]
    public CqlValueSet Hospice_Intervention(CqlContext _) => _Hospice_Intervention;
    private static readonly CqlValueSet _Hospice_Intervention = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1762", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(-3851945183777304699L, () => {
            object a_ = context.ResolveParameter("NCQAHospice-1.0.0", "Measurement Period", null);
            return (CqlInterval<CqlDateTime>)a_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(-8768318097955700668L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlExpressionDefinition("Hospice Intervention or Encounter")]
    public bool? Hospice_Intervention_or_Encounter(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(4411369996558005077L, () => {
            CqlValueSet a_ = this.Hospice_Intervention(context);
            IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
            IEnumerable<Procedure> c_ = NCQAStatus_1_0_0.Instance.Completed_or_Ongoing_Procedure(context, b_);

            bool? d_(Procedure HospiceInt) {
                DataType n_ = HospiceInt?.Performed;
                CqlInterval<CqlDateTime> o_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, n_);
                CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                bool? q_ = context.Operators.Overlaps(o_, p_, default);
                return q_;
            }

            IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
            bool? f_ = context.Operators.Exists<Procedure>(e_);
            CqlValueSet g_ = this.Hospice_Encounter(context);
            IEnumerable<Encounter> h_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            IEnumerable<Encounter> i_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, h_);

            bool? j_(Encounter HospiceEnc) {
                Period r_ = HospiceEnc?.Period;
                CqlInterval<CqlDateTime> s_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, r_ as object);
                CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                bool? u_ = context.Operators.Overlaps(s_, t_, default);
                return u_;
            }

            IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            bool? m_ = context.Operators.Or(f_, l_);
            return m_;
        });


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private NCQAHospice_1_0_0() {}

    public static NCQAHospice_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "NCQAHospice";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAStatus_1_0_0.Instance];

    #endregion ILibrary Implementation

}

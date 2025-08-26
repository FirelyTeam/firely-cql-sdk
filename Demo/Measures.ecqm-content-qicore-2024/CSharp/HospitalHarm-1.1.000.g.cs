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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("HospitalHarm", "1.1.000")]
public partial class HospitalHarm_1_1_000 : ILibrary, ISingleton<HospitalHarm_1_1_000>
{
    private HospitalHarm_1_1_000() {}

    public static HospitalHarm_1_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HospitalHarm";
    public string Version => "1.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, CQMCommon_2_2_000.Instance];

    #endregion ILibrary Implementation

    #region Functions and Expressions

    [CqlFunctionDefinition("diagnosisPresentOnAdmission")]
    public CqlConcept diagnosisPresentOnAdmission(CqlContext context, Encounter enc)
    {
        List<Encounter.DiagnosisComponent> a_ = enc?.Diagnosis;
        bool? b_(Encounter.DiagnosisComponent @this)
        {
            bool? l_ = context.Operators.Not((bool?)((@this is Element
                    ? (@this as Element).Extension
                    : default) is null));

            return l_;
        };
        IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        List<Extension> d_(Encounter.DiagnosisComponent @this) =>
            (@this is Element
                ? (@this as Element).Extension
                : default);
        IEnumerable<List<Extension>> e_ = context.Operators.Select<Encounter.DiagnosisComponent, List<Extension>>(c_, d_);
        IEnumerable<Extension> f_ = context.Operators.Flatten<Extension>((IEnumerable<IEnumerable<Extension>>)e_);
        bool? g_(Extension E)
        {
            string m_ = E?.Url;
            FhirString n_ = context.Operators.Convert<FhirString>(m_);
            string o_ = n_?.Value;
            bool? p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

            return p_;
        };
        IEnumerable<Extension> h_ = context.Operators.Where<Extension>(f_, g_);
        Extension i_ = context.Operators.SingletonFrom<Extension>(h_);
        DataType j_ = i_?.Value;
        object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);

        return k_ as CqlConcept;
    }


    [CqlFunctionDefinition("procedureRank")]
    public (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? procedureRank(CqlContext context, Encounter theEncounter)
    {
        bool? a_(Extension E)
        {
            string i_ = E?.Url;
            FhirString j_ = context.Operators.Convert<FhirString>(i_);
            string k_ = j_?.Value;
            bool? l_ = context.Operators.Equal(k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-procedure");

            return l_;
        };
        IEnumerable<Extension> b_ = context.Operators.Where<Extension>((theEncounter is DomainResource
                ? (IEnumerable<Extension>)((theEncounter as DomainResource).Extension)
                : default), a_);
        Extension c_ = context.Operators.SingletonFrom<Extension>(b_);
        Extension[] d_ = [
            c_,
        ];
        (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? e_(Extension encext)
        {
            List<Extension> m_ = encext?.Extension;
            bool? n_(Extension E)
            {
                string t_ = E?.Url;
                FhirString u_ = context.Operators.Convert<FhirString>(t_);
                string v_ = u_?.Value;
                bool? w_ = context.Operators.Equal(v_, "rank");

                return w_;
            };
            IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)m_, n_);
            int? p_(Extension E)
            {
                DataType x_ = E?.Value;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);

                return y_ as int?;
            };
            IEnumerable<int?> q_ = context.Operators.Select<Extension, int?>(o_, p_);
            IEnumerable<int?> r_ = context.Operators.Distinct<int?>(q_);
            (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? s_ = (CqlTupleMetadata_CCJaUjRHWSXeUTcFAfVeVeNaD, default, default, r_, default);

            return s_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> f_ = context.Operators.Select<Extension, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>((IEnumerable<Extension>)d_, e_);
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>(f_);
        (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? h_ = context.Operators.SingletonFrom<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>(g_);

        return h_;
    }


    [CqlFunctionDefinition("startsDuringHospitalization")]
    public bool? startsDuringHospitalization(CqlContext context, object choice, Encounter enc)
    {
        bool? a_()
        {
            if (choice is Procedure)
            {
                DataType b_ = (choice as Procedure)?.Performed;
                object c_ = FHIRHelpers_4_4_000.Instance.ToValue(context, b_);
                CqlInterval<CqlDateTime> d_ = QICoreCommon_2_1_000.Instance.ToInterval(context, c_);
                CqlDateTime e_ = context.Operators.Start(d_);
                CqlInterval<CqlDateTime> f_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
                bool? g_ = context.Operators.In<CqlDateTime>(e_, f_, default);

                return g_;
            }
            else if (choice is Observation)
            {
                DataType h_ = (choice as Observation)?.Effective;
                object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                CqlInterval<CqlDateTime> j_ = QICoreCommon_2_1_000.Instance.ToInterval(context, i_);
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlInterval<CqlDateTime> l_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
                bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, default);

                return m_;
            }
            else
            {
                return false;
            }
        };

        return a_();
    }


    [CqlFunctionDefinition("isDuringHospitalization")]
    public bool? isDuringHospitalization(CqlContext context, object choice, Encounter enc)
    {
        bool? a_()
        {
            if (choice is Procedure)
            {
                CqlInterval<CqlDateTime> b_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
                DataType c_ = (choice as Procedure)?.Performed;
                object d_ = FHIRHelpers_4_4_000.Instance.ToValue(context, c_);
                CqlInterval<CqlDateTime> e_ = QICoreCommon_2_1_000.Instance.ToInterval(context, d_);
                bool? f_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(b_, e_, default);

                return f_;
            }
            else if (choice is Observation)
            {
                CqlInterval<CqlDateTime> g_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
                DataType h_ = (choice as Observation)?.Effective;
                object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                CqlInterval<CqlDateTime> j_ = QICoreCommon_2_1_000.Instance.ToInterval(context, i_);
                bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, default);

                return k_;
            }
            else
            {
                return false;
            }
        };

        return a_();
    }


    [CqlFunctionDefinition("interval")]
    public CqlInterval<CqlDateTime> interval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_()
        {
            if (choice is Procedure)
            {
                DataType b_ = (choice as Procedure)?.Performed;
                object c_ = FHIRHelpers_4_4_000.Instance.ToValue(context, b_);
                CqlInterval<CqlDateTime> d_ = QICoreCommon_2_1_000.Instance.ToInterval(context, c_);

                return d_;
            }
            else if (choice is Observation)
            {
                DataType e_ = (choice as Observation)?.Effective;
                object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
                CqlInterval<CqlDateTime> g_ = QICoreCommon_2_1_000.Instance.ToInterval(context, f_);

                return g_;
            }
            else if (choice is Encounter)
            {
                Period h_ = (choice as Encounter)?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlInterval<CqlDateTime> j_ = QICoreCommon_2_1_000.Instance.ToInterval(context, i_ as object);

                return j_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return a_();
    }


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CCJaUjRHWSXeUTcFAfVeVeNaD = new(
      [typeof(string), typeof(IEnumerable<ResourceReference>), typeof(IEnumerable<int?>), typeof(IEnumerable<Encounter.DiagnosisComponent>)],
      ["encounterId", "condition", "rank", "POA"]);

    #endregion CqlTupleMetadata Properties

}

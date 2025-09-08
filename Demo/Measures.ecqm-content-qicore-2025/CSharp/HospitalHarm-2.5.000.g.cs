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
[CqlLibrary("HospitalHarm", "2.5.000")]
public partial class HospitalHarm_2_5_000 : ILibrary, ISingleton<HospitalHarm_2_5_000>
{
    private HospitalHarm_2_5_000() {}

    public static HospitalHarm_2_5_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HospitalHarm";
    public string Version => "2.5.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, CQMCommon_4_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Present on Admission or Clinically Undetermined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext _) => _Present_on_Admission_or_Clinically_Undetermined;
    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    [CqlValueSetDefinition("Not Present On Admission or Documentation Insufficient to Determine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", valueSetVersion: null)]
    public CqlValueSet Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(CqlContext _) => _Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine;
    private static readonly CqlValueSet _Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Principal Diagnosis", codeId: "principal", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype")]
    public CqlCode Principal_Diagnosis(CqlContext _) => _Principal_Diagnosis;
    private static readonly CqlCode _Principal_Diagnosis = new CqlCode("principal", "http://terminology.hl7.org/CodeSystem/ex-diagnosistype");

    [CqlCodeDefinition("Primary Procedure", codeId: "primary", codeSystem: "http://terminology.hl7.org/CodeSystem/ex-procedure-type")]
    public CqlCode Primary_Procedure(CqlContext _) => _Primary_Procedure;
    private static readonly CqlCode _Primary_Procedure = new CqlCode("primary", "http://terminology.hl7.org/CodeSystem/ex-procedure-type");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("Diagnosis Type", codeSystemId: "http://terminology.hl7.org/CodeSystem/ex-diagnosistype", codeSystemVersion: null)]
    public CqlCodeSystem Diagnosis_Type(CqlContext _) => _Diagnosis_Type;
    private static readonly CqlCodeSystem _Diagnosis_Type =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/ex-diagnosistype", null, [
          _Principal_Diagnosis]);

    [CqlCodeSystemDefinition("Procedure Type", codeSystemId: "http://terminology.hl7.org/CodeSystem/ex-procedure-type", codeSystemVersion: null)]
    public CqlCodeSystem Procedure_Type(CqlContext _) => _Procedure_Type;
    private static readonly CqlCodeSystem _Procedure_Type =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/ex-procedure-type", null, [
          _Primary_Procedure]);

    #endregion CodeSystems

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlFunctionDefinition("diagnosisOnAdmission")]
    public CqlConcept diagnosisOnAdmission(CqlContext context, Claim claim)
    {
        List<Claim.DiagnosisComponent> a_ = claim?.Diagnosis;
        bool? b_(Claim.DiagnosisComponent @this)
        {
            CodeableConcept g_ = @this?.OnAdmission;
            CqlConcept h_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, g_);
            bool? i_ = context.Operators.Not((bool?)(h_ is null));

            return i_;
        };
        IEnumerable<Claim.DiagnosisComponent> c_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)a_, b_);
        CqlConcept d_(Claim.DiagnosisComponent @this)
        {
            CodeableConcept j_ = @this?.OnAdmission;
            CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);

            return k_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Select<Claim.DiagnosisComponent, CqlConcept>(c_, d_);
        CqlConcept f_ = context.Operators.SingletonFrom<CqlConcept>(e_);

        return f_ as CqlConcept;
    }


    [CqlFunctionDefinition("claimDiagnoses")]
    public IEnumerable<Claim.DiagnosisComponent> claimDiagnoses(CqlContext context, Encounter encounter)
    {
        Encounter[] a_ = [
            encounter,
        ];
        IEnumerable<Claim.DiagnosisComponent> b_(Encounter E)
        {
            IEnumerable<Claim> f_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
            bool? g_(Claim C)
            {
                Code<FinancialResourceStatusCodes> p_ = C?.StatusElement;
                FinancialResourceStatusCodes? q_ = p_?.Value;
                Code<FinancialResourceStatusCodes> r_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(q_);
                bool? s_ = context.Operators.Equal(r_, "active");
                Code<ClaimUseCode> t_ = C?.UseElement;
                ClaimUseCode? u_ = t_?.Value;
                Code<ClaimUseCode> v_ = context.Operators.Convert<Code<ClaimUseCode>>(u_);
                bool? w_ = context.Operators.Equal(v_, "claim");
                bool? x_ = context.Operators.And(s_, w_);
                List<Claim.ItemComponent> y_ = C?.Item;
                bool? z_(Claim.ItemComponent I)
                {
                    List<ResourceReference> ad_ = I?.Encounter;
                    bool? ae_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ad_, E);

                    return ae_;
                };
                IEnumerable<Claim.ItemComponent> aa_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)y_, z_);
                bool? ab_ = context.Operators.Exists<Claim.ItemComponent>(aa_);
                bool? ac_ = context.Operators.And(x_, ab_);

                return ac_;
            };
            IEnumerable<Claim> h_ = context.Operators.Where<Claim>(f_, g_);
            bool? i_(Claim @this)
            {
                List<Claim.DiagnosisComponent> af_ = @this?.Diagnosis;
                bool? ag_ = context.Operators.Not((bool?)(af_ is null));

                return ag_;
            };
            IEnumerable<Claim> j_ = context.Operators.Where<Claim>(h_, i_);
            List<Claim.DiagnosisComponent> k_(Claim @this)
            {
                List<Claim.DiagnosisComponent> ah_ = @this?.Diagnosis;

                return ah_;
            };
            IEnumerable<List<Claim.DiagnosisComponent>> l_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(j_, k_);
            IEnumerable<Claim.DiagnosisComponent> m_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)l_);
            bool? n_(Claim.DiagnosisComponent D)
            {
                PositiveInt ai_ = D?.SequenceElement;
                int? aj_ = ai_?.Value;
                IEnumerable<Claim> ak_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
                bool? al_(Claim C)
                {
                    Code<FinancialResourceStatusCodes> ba_ = C?.StatusElement;
                    FinancialResourceStatusCodes? bb_ = ba_?.Value;
                    Code<FinancialResourceStatusCodes> bc_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bb_);
                    bool? bd_ = context.Operators.Equal(bc_, "active");
                    Code<ClaimUseCode> be_ = C?.UseElement;
                    ClaimUseCode? bf_ = be_?.Value;
                    Code<ClaimUseCode> bg_ = context.Operators.Convert<Code<ClaimUseCode>>(bf_);
                    bool? bh_ = context.Operators.Equal(bg_, "claim");
                    bool? bi_ = context.Operators.And(bd_, bh_);
                    List<Claim.ItemComponent> bj_ = C?.Item;
                    bool? bk_(Claim.ItemComponent I)
                    {
                        List<ResourceReference> bo_ = I?.Encounter;
                        bool? bp_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bo_, E);

                        return bp_;
                    };
                    IEnumerable<Claim.ItemComponent> bl_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bj_, bk_);
                    bool? bm_ = context.Operators.Exists<Claim.ItemComponent>(bl_);
                    bool? bn_ = context.Operators.And(bi_, bm_);

                    return bn_;
                };
                IEnumerable<Claim> am_ = context.Operators.Where<Claim>(ak_, al_);
                bool? an_(Claim @this)
                {
                    List<Claim.ItemComponent> bq_ = @this?.Item;
                    bool? br_ = context.Operators.Not((bool?)(bq_ is null));

                    return br_;
                };
                IEnumerable<Claim> ao_ = context.Operators.Where<Claim>(am_, an_);
                List<Claim.ItemComponent> ap_(Claim @this)
                {
                    List<Claim.ItemComponent> bs_ = @this?.Item;

                    return bs_;
                };
                IEnumerable<List<Claim.ItemComponent>> aq_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ao_, ap_);
                IEnumerable<Claim.ItemComponent> ar_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)aq_);
                bool? as_(Claim.ItemComponent I)
                {
                    List<ResourceReference> bt_ = I?.Encounter;
                    bool? bu_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bt_, E);

                    return bu_;
                };
                IEnumerable<Claim.ItemComponent> at_ = context.Operators.Where<Claim.ItemComponent>(ar_, as_);
                bool? au_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> bv_ = @this?.DiagnosisSequenceElement;
                    int? bw_(PositiveInt @this)
                    {
                        int? bz_ = @this?.Value;

                        return bz_;
                    };
                    IEnumerable<int?> bx_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bv_, bw_);
                    bool? by_ = context.Operators.Not((bool?)(bx_ is null));

                    return by_;
                };
                IEnumerable<Claim.ItemComponent> av_ = context.Operators.Where<Claim.ItemComponent>(at_, au_);
                IEnumerable<int?> aw_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> ca_ = @this?.DiagnosisSequenceElement;
                    int? cb_(PositiveInt @this)
                    {
                        int? cd_ = @this?.Value;

                        return cd_;
                    };
                    IEnumerable<int?> cc_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ca_, cb_);

                    return cc_;
                };
                IEnumerable<IEnumerable<int?>> ax_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(av_, aw_);
                IEnumerable<int?> ay_ = context.Operators.Flatten<int?>(ax_);
                bool? az_ = context.Operators.In<int?>(aj_, ay_);

                return az_;
            };
            IEnumerable<Claim.DiagnosisComponent> o_ = context.Operators.Where<Claim.DiagnosisComponent>(m_, n_);

            return o_;
        };
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> c_ = context.Operators.Select<Encounter, IEnumerable<Claim.DiagnosisComponent>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> d_ = context.Operators.Distinct<IEnumerable<Claim.DiagnosisComponent>>(c_);
        IEnumerable<Claim.DiagnosisComponent> e_ = context.Operators.Flatten<Claim.DiagnosisComponent>(d_);

        return e_;
    }


    [CqlFunctionDefinition("claimDiagnosesWithPOA")]
    public IEnumerable<Claim.DiagnosisComponent> claimDiagnosesWithPOA(CqlContext context, Encounter encounter)
    {
        Encounter[] a_ = [
            encounter,
        ];
        IEnumerable<Claim.DiagnosisComponent> b_(Encounter E)
        {
            IEnumerable<Claim> f_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
            bool? g_(Claim C)
            {
                Code<FinancialResourceStatusCodes> p_ = C?.StatusElement;
                FinancialResourceStatusCodes? q_ = p_?.Value;
                Code<FinancialResourceStatusCodes> r_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(q_);
                bool? s_ = context.Operators.Equal(r_, "active");
                Code<ClaimUseCode> t_ = C?.UseElement;
                ClaimUseCode? u_ = t_?.Value;
                Code<ClaimUseCode> v_ = context.Operators.Convert<Code<ClaimUseCode>>(u_);
                bool? w_ = context.Operators.Equal(v_, "claim");
                bool? x_ = context.Operators.And(s_, w_);
                List<Claim.ItemComponent> y_ = C?.Item;
                bool? z_(Claim.ItemComponent I)
                {
                    List<ResourceReference> ad_ = I?.Encounter;
                    bool? ae_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ad_, E);

                    return ae_;
                };
                IEnumerable<Claim.ItemComponent> aa_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)y_, z_);
                bool? ab_ = context.Operators.Exists<Claim.ItemComponent>(aa_);
                bool? ac_ = context.Operators.And(x_, ab_);

                return ac_;
            };
            IEnumerable<Claim> h_ = context.Operators.Where<Claim>(f_, g_);
            bool? i_(Claim @this)
            {
                List<Claim.DiagnosisComponent> af_ = @this?.Diagnosis;
                bool? ag_ = context.Operators.Not((bool?)(af_ is null));

                return ag_;
            };
            IEnumerable<Claim> j_ = context.Operators.Where<Claim>(h_, i_);
            List<Claim.DiagnosisComponent> k_(Claim @this)
            {
                List<Claim.DiagnosisComponent> ah_ = @this?.Diagnosis;

                return ah_;
            };
            IEnumerable<List<Claim.DiagnosisComponent>> l_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(j_, k_);
            IEnumerable<Claim.DiagnosisComponent> m_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)l_);
            bool? n_(Claim.DiagnosisComponent D)
            {
                PositiveInt ai_ = D?.SequenceElement;
                int? aj_ = ai_?.Value;
                IEnumerable<Claim> ak_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
                bool? al_(Claim C)
                {
                    Code<FinancialResourceStatusCodes> be_ = C?.StatusElement;
                    FinancialResourceStatusCodes? bf_ = be_?.Value;
                    Code<FinancialResourceStatusCodes> bg_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bf_);
                    bool? bh_ = context.Operators.Equal(bg_, "active");
                    Code<ClaimUseCode> bi_ = C?.UseElement;
                    ClaimUseCode? bj_ = bi_?.Value;
                    Code<ClaimUseCode> bk_ = context.Operators.Convert<Code<ClaimUseCode>>(bj_);
                    bool? bl_ = context.Operators.Equal(bk_, "claim");
                    bool? bm_ = context.Operators.And(bh_, bl_);
                    List<Claim.ItemComponent> bn_ = C?.Item;
                    bool? bo_(Claim.ItemComponent I)
                    {
                        List<ResourceReference> bs_ = I?.Encounter;
                        bool? bt_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bs_, E);

                        return bt_;
                    };
                    IEnumerable<Claim.ItemComponent> bp_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bn_, bo_);
                    bool? bq_ = context.Operators.Exists<Claim.ItemComponent>(bp_);
                    bool? br_ = context.Operators.And(bm_, bq_);

                    return br_;
                };
                IEnumerable<Claim> am_ = context.Operators.Where<Claim>(ak_, al_);
                bool? an_(Claim @this)
                {
                    List<Claim.ItemComponent> bu_ = @this?.Item;
                    bool? bv_ = context.Operators.Not((bool?)(bu_ is null));

                    return bv_;
                };
                IEnumerable<Claim> ao_ = context.Operators.Where<Claim>(am_, an_);
                List<Claim.ItemComponent> ap_(Claim @this)
                {
                    List<Claim.ItemComponent> bw_ = @this?.Item;

                    return bw_;
                };
                IEnumerable<List<Claim.ItemComponent>> aq_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ao_, ap_);
                IEnumerable<Claim.ItemComponent> ar_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)aq_);
                bool? as_(Claim.ItemComponent I)
                {
                    List<ResourceReference> bx_ = I?.Encounter;
                    bool? by_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bx_, E);

                    return by_;
                };
                IEnumerable<Claim.ItemComponent> at_ = context.Operators.Where<Claim.ItemComponent>(ar_, as_);
                bool? au_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> bz_ = @this?.DiagnosisSequenceElement;
                    int? ca_(PositiveInt @this)
                    {
                        int? cd_ = @this?.Value;

                        return cd_;
                    };
                    IEnumerable<int?> cb_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bz_, ca_);
                    bool? cc_ = context.Operators.Not((bool?)(cb_ is null));

                    return cc_;
                };
                IEnumerable<Claim.ItemComponent> av_ = context.Operators.Where<Claim.ItemComponent>(at_, au_);
                IEnumerable<int?> aw_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> ce_ = @this?.DiagnosisSequenceElement;
                    int? cf_(PositiveInt @this)
                    {
                        int? ch_ = @this?.Value;

                        return ch_;
                    };
                    IEnumerable<int?> cg_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ce_, cf_);

                    return cg_;
                };
                IEnumerable<IEnumerable<int?>> ax_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(av_, aw_);
                IEnumerable<int?> ay_ = context.Operators.Flatten<int?>(ax_);
                bool? az_ = context.Operators.In<int?>(aj_, ay_);
                CodeableConcept ba_ = D?.OnAdmission;
                CqlConcept bb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ba_);
                bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                bool? bd_ = context.Operators.And(az_, bc_);

                return bd_;
            };
            IEnumerable<Claim.DiagnosisComponent> o_ = context.Operators.Where<Claim.DiagnosisComponent>(m_, n_);

            return o_;
        };
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> c_ = context.Operators.Select<Encounter, IEnumerable<Claim.DiagnosisComponent>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> d_ = context.Operators.Distinct<IEnumerable<Claim.DiagnosisComponent>>(c_);
        IEnumerable<Claim.DiagnosisComponent> e_ = context.Operators.Flatten<Claim.DiagnosisComponent>(d_);

        return e_;
    }


    [CqlFunctionDefinition("claimProcedures")]
    public IEnumerable<Claim.ProcedureComponent> claimProcedures(CqlContext context, Encounter encounter)
    {
        Encounter[] a_ = [
            encounter,
        ];
        IEnumerable<Claim.ProcedureComponent> b_(Encounter E)
        {
            IEnumerable<Claim> f_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
            bool? g_(Claim C)
            {
                Code<FinancialResourceStatusCodes> p_ = C?.StatusElement;
                FinancialResourceStatusCodes? q_ = p_?.Value;
                Code<FinancialResourceStatusCodes> r_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(q_);
                bool? s_ = context.Operators.Equal(r_, "active");
                Code<ClaimUseCode> t_ = C?.UseElement;
                ClaimUseCode? u_ = t_?.Value;
                Code<ClaimUseCode> v_ = context.Operators.Convert<Code<ClaimUseCode>>(u_);
                bool? w_ = context.Operators.Equal(v_, "claim");
                bool? x_ = context.Operators.And(s_, w_);
                List<Claim.ItemComponent> y_ = C?.Item;
                bool? z_(Claim.ItemComponent I)
                {
                    List<ResourceReference> ad_ = I?.Encounter;
                    bool? ae_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ad_, E);

                    return ae_;
                };
                IEnumerable<Claim.ItemComponent> aa_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)y_, z_);
                bool? ab_ = context.Operators.Exists<Claim.ItemComponent>(aa_);
                bool? ac_ = context.Operators.And(x_, ab_);

                return ac_;
            };
            IEnumerable<Claim> h_ = context.Operators.Where<Claim>(f_, g_);
            bool? i_(Claim @this)
            {
                List<Claim.ProcedureComponent> af_ = @this?.Procedure;
                bool? ag_ = context.Operators.Not((bool?)(af_ is null));

                return ag_;
            };
            IEnumerable<Claim> j_ = context.Operators.Where<Claim>(h_, i_);
            List<Claim.ProcedureComponent> k_(Claim @this)
            {
                List<Claim.ProcedureComponent> ah_ = @this?.Procedure;

                return ah_;
            };
            IEnumerable<List<Claim.ProcedureComponent>> l_ = context.Operators.Select<Claim, List<Claim.ProcedureComponent>>(j_, k_);
            IEnumerable<Claim.ProcedureComponent> m_ = context.Operators.Flatten<Claim.ProcedureComponent>((IEnumerable<IEnumerable<Claim.ProcedureComponent>>)l_);
            bool? n_(Claim.ProcedureComponent P)
            {
                PositiveInt ai_ = P?.SequenceElement;
                int? aj_ = ai_?.Value;
                IEnumerable<Claim> ak_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
                bool? al_(Claim C)
                {
                    Code<FinancialResourceStatusCodes> ba_ = C?.StatusElement;
                    FinancialResourceStatusCodes? bb_ = ba_?.Value;
                    Code<FinancialResourceStatusCodes> bc_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bb_);
                    bool? bd_ = context.Operators.Equal(bc_, "active");
                    Code<ClaimUseCode> be_ = C?.UseElement;
                    ClaimUseCode? bf_ = be_?.Value;
                    Code<ClaimUseCode> bg_ = context.Operators.Convert<Code<ClaimUseCode>>(bf_);
                    bool? bh_ = context.Operators.Equal(bg_, "claim");
                    bool? bi_ = context.Operators.And(bd_, bh_);
                    List<Claim.ItemComponent> bj_ = C?.Item;
                    bool? bk_(Claim.ItemComponent I)
                    {
                        List<ResourceReference> bo_ = I?.Encounter;
                        bool? bp_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bo_, E);

                        return bp_;
                    };
                    IEnumerable<Claim.ItemComponent> bl_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bj_, bk_);
                    bool? bm_ = context.Operators.Exists<Claim.ItemComponent>(bl_);
                    bool? bn_ = context.Operators.And(bi_, bm_);

                    return bn_;
                };
                IEnumerable<Claim> am_ = context.Operators.Where<Claim>(ak_, al_);
                bool? an_(Claim @this)
                {
                    List<Claim.ItemComponent> bq_ = @this?.Item;
                    bool? br_ = context.Operators.Not((bool?)(bq_ is null));

                    return br_;
                };
                IEnumerable<Claim> ao_ = context.Operators.Where<Claim>(am_, an_);
                List<Claim.ItemComponent> ap_(Claim @this)
                {
                    List<Claim.ItemComponent> bs_ = @this?.Item;

                    return bs_;
                };
                IEnumerable<List<Claim.ItemComponent>> aq_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ao_, ap_);
                IEnumerable<Claim.ItemComponent> ar_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)aq_);
                bool? as_(Claim.ItemComponent I)
                {
                    List<ResourceReference> bt_ = I?.Encounter;
                    bool? bu_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bt_, E);

                    return bu_;
                };
                IEnumerable<Claim.ItemComponent> at_ = context.Operators.Where<Claim.ItemComponent>(ar_, as_);
                bool? au_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> bv_ = @this?.ProcedureSequenceElement;
                    int? bw_(PositiveInt @this)
                    {
                        int? bz_ = @this?.Value;

                        return bz_;
                    };
                    IEnumerable<int?> bx_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)bv_, bw_);
                    bool? by_ = context.Operators.Not((bool?)(bx_ is null));

                    return by_;
                };
                IEnumerable<Claim.ItemComponent> av_ = context.Operators.Where<Claim.ItemComponent>(at_, au_);
                IEnumerable<int?> aw_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> ca_ = @this?.ProcedureSequenceElement;
                    int? cb_(PositiveInt @this)
                    {
                        int? cd_ = @this?.Value;

                        return cd_;
                    };
                    IEnumerable<int?> cc_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ca_, cb_);

                    return cc_;
                };
                IEnumerable<IEnumerable<int?>> ax_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(av_, aw_);
                IEnumerable<int?> ay_ = context.Operators.Flatten<int?>(ax_);
                bool? az_ = context.Operators.In<int?>(aj_, ay_);

                return az_;
            };
            IEnumerable<Claim.ProcedureComponent> o_ = context.Operators.Where<Claim.ProcedureComponent>(m_, n_);

            return o_;
        };
        IEnumerable<IEnumerable<Claim.ProcedureComponent>> c_ = context.Operators.Select<Encounter, IEnumerable<Claim.ProcedureComponent>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<IEnumerable<Claim.ProcedureComponent>> d_ = context.Operators.Distinct<IEnumerable<Claim.ProcedureComponent>>(c_);
        IEnumerable<Claim.ProcedureComponent> e_ = context.Operators.Flatten<Claim.ProcedureComponent>(d_);

        return e_;
    }


    [CqlFunctionDefinition("hasPrincipalDiagnosis")]
    public bool? hasPrincipalDiagnosis(CqlContext context, Encounter encounter)
    {
        Encounter[] a_ = [
            encounter,
        ];
        IEnumerable<Claim.DiagnosisComponent> b_(Encounter E)
        {
            IEnumerable<Claim> g_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
            bool? h_(Claim C)
            {
                Code<FinancialResourceStatusCodes> q_ = C?.StatusElement;
                FinancialResourceStatusCodes? r_ = q_?.Value;
                Code<FinancialResourceStatusCodes> s_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(r_);
                bool? t_ = context.Operators.Equal(s_, "active");
                Code<ClaimUseCode> u_ = C?.UseElement;
                ClaimUseCode? v_ = u_?.Value;
                Code<ClaimUseCode> w_ = context.Operators.Convert<Code<ClaimUseCode>>(v_);
                bool? x_ = context.Operators.Equal(w_, "claim");
                bool? y_ = context.Operators.And(t_, x_);
                List<Claim.ItemComponent> z_ = C?.Item;
                bool? aa_(Claim.ItemComponent I)
                {
                    List<ResourceReference> ae_ = I?.Encounter;
                    bool? af_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ae_, E);

                    return af_;
                };
                IEnumerable<Claim.ItemComponent> ab_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)z_, aa_);
                bool? ac_ = context.Operators.Exists<Claim.ItemComponent>(ab_);
                bool? ad_ = context.Operators.And(y_, ac_);

                return ad_;
            };
            IEnumerable<Claim> i_ = context.Operators.Where<Claim>(g_, h_);
            bool? j_(Claim @this)
            {
                List<Claim.DiagnosisComponent> ag_ = @this?.Diagnosis;
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));

                return ah_;
            };
            IEnumerable<Claim> k_ = context.Operators.Where<Claim>(i_, j_);
            List<Claim.DiagnosisComponent> l_(Claim @this)
            {
                List<Claim.DiagnosisComponent> ai_ = @this?.Diagnosis;

                return ai_;
            };
            IEnumerable<List<Claim.DiagnosisComponent>> m_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(k_, l_);
            IEnumerable<Claim.DiagnosisComponent> n_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)m_);
            bool? o_(Claim.DiagnosisComponent D)
            {
                PositiveInt aj_ = D?.SequenceElement;
                int? ak_ = aj_?.Value;
                IEnumerable<Claim> al_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
                bool? am_(Claim C)
                {
                    Code<FinancialResourceStatusCodes> bh_ = C?.StatusElement;
                    FinancialResourceStatusCodes? bi_ = bh_?.Value;
                    Code<FinancialResourceStatusCodes> bj_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bi_);
                    bool? bk_ = context.Operators.Equal(bj_, "active");
                    Code<ClaimUseCode> bl_ = C?.UseElement;
                    ClaimUseCode? bm_ = bl_?.Value;
                    Code<ClaimUseCode> bn_ = context.Operators.Convert<Code<ClaimUseCode>>(bm_);
                    bool? bo_ = context.Operators.Equal(bn_, "claim");
                    bool? bp_ = context.Operators.And(bk_, bo_);
                    List<Claim.ItemComponent> bq_ = C?.Item;
                    bool? br_(Claim.ItemComponent I)
                    {
                        List<ResourceReference> bv_ = I?.Encounter;
                        bool? bw_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bv_, E);

                        return bw_;
                    };
                    IEnumerable<Claim.ItemComponent> bs_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bq_, br_);
                    bool? bt_ = context.Operators.Exists<Claim.ItemComponent>(bs_);
                    bool? bu_ = context.Operators.And(bp_, bt_);

                    return bu_;
                };
                IEnumerable<Claim> an_ = context.Operators.Where<Claim>(al_, am_);
                bool? ao_(Claim @this)
                {
                    List<Claim.ItemComponent> bx_ = @this?.Item;
                    bool? by_ = context.Operators.Not((bool?)(bx_ is null));

                    return by_;
                };
                IEnumerable<Claim> ap_ = context.Operators.Where<Claim>(an_, ao_);
                List<Claim.ItemComponent> aq_(Claim @this)
                {
                    List<Claim.ItemComponent> bz_ = @this?.Item;

                    return bz_;
                };
                IEnumerable<List<Claim.ItemComponent>> ar_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ap_, aq_);
                IEnumerable<Claim.ItemComponent> as_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)ar_);
                bool? at_(Claim.ItemComponent I)
                {
                    List<ResourceReference> ca_ = I?.Encounter;
                    bool? cb_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ca_, E);

                    return cb_;
                };
                IEnumerable<Claim.ItemComponent> au_ = context.Operators.Where<Claim.ItemComponent>(as_, at_);
                bool? av_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> cc_ = @this?.DiagnosisSequenceElement;
                    int? cd_(PositiveInt @this)
                    {
                        int? cg_ = @this?.Value;

                        return cg_;
                    };
                    IEnumerable<int?> ce_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)cc_, cd_);
                    bool? cf_ = context.Operators.Not((bool?)(ce_ is null));

                    return cf_;
                };
                IEnumerable<Claim.ItemComponent> aw_ = context.Operators.Where<Claim.ItemComponent>(au_, av_);
                IEnumerable<int?> ax_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> ch_ = @this?.DiagnosisSequenceElement;
                    int? ci_(PositiveInt @this)
                    {
                        int? ck_ = @this?.Value;

                        return ck_;
                    };
                    IEnumerable<int?> cj_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ch_, ci_);

                    return cj_;
                };
                IEnumerable<IEnumerable<int?>> ay_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(aw_, ax_);
                IEnumerable<int?> az_ = context.Operators.Flatten<int?>(ay_);
                bool? ba_ = context.Operators.In<int?>(ak_, az_);
                List<CodeableConcept> bb_ = D?.Type;
                CqlConcept bc_(CodeableConcept @this)
                {
                    CqlConcept cl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return cl_;
                };
                IEnumerable<CqlConcept> bd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bb_, bc_);
                CqlCode be_ = this.Principal_Diagnosis(context);
                bool? bf_ = QICoreCommon_4_0_000.Instance.includesCode(context, bd_, be_);
                bool? bg_ = context.Operators.And(ba_, bf_);

                return bg_;
            };
            IEnumerable<Claim.DiagnosisComponent> p_ = context.Operators.Where<Claim.DiagnosisComponent>(n_, o_);

            return p_;
        };
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> c_ = context.Operators.Select<Encounter, IEnumerable<Claim.DiagnosisComponent>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> d_ = context.Operators.Distinct<IEnumerable<Claim.DiagnosisComponent>>(c_);
        IEnumerable<Claim.DiagnosisComponent> e_ = context.Operators.Flatten<Claim.DiagnosisComponent>(d_);
        bool? f_ = context.Operators.Exists<Claim.DiagnosisComponent>(e_);

        return f_;
    }


    [CqlFunctionDefinition("hasPrincipalDiagnosisIn")]
    public bool? hasPrincipalDiagnosisIn(CqlContext context, Encounter encounter, CqlValueSet diagnosisValueSet)
    {
        Encounter[] a_ = [
            encounter,
        ];
        IEnumerable<Claim.DiagnosisComponent> b_(Encounter E)
        {
            IEnumerable<Claim> g_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
            bool? h_(Claim C)
            {
                Code<FinancialResourceStatusCodes> q_ = C?.StatusElement;
                FinancialResourceStatusCodes? r_ = q_?.Value;
                Code<FinancialResourceStatusCodes> s_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(r_);
                bool? t_ = context.Operators.Equal(s_, "active");
                Code<ClaimUseCode> u_ = C?.UseElement;
                ClaimUseCode? v_ = u_?.Value;
                Code<ClaimUseCode> w_ = context.Operators.Convert<Code<ClaimUseCode>>(v_);
                bool? x_ = context.Operators.Equal(w_, "claim");
                bool? y_ = context.Operators.And(t_, x_);
                List<Claim.ItemComponent> z_ = C?.Item;
                bool? aa_(Claim.ItemComponent I)
                {
                    List<ResourceReference> ae_ = I?.Encounter;
                    bool? af_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ae_, E);

                    return af_;
                };
                IEnumerable<Claim.ItemComponent> ab_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)z_, aa_);
                bool? ac_ = context.Operators.Exists<Claim.ItemComponent>(ab_);
                bool? ad_ = context.Operators.And(y_, ac_);

                return ad_;
            };
            IEnumerable<Claim> i_ = context.Operators.Where<Claim>(g_, h_);
            bool? j_(Claim @this)
            {
                List<Claim.DiagnosisComponent> ag_ = @this?.Diagnosis;
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));

                return ah_;
            };
            IEnumerable<Claim> k_ = context.Operators.Where<Claim>(i_, j_);
            List<Claim.DiagnosisComponent> l_(Claim @this)
            {
                List<Claim.DiagnosisComponent> ai_ = @this?.Diagnosis;

                return ai_;
            };
            IEnumerable<List<Claim.DiagnosisComponent>> m_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(k_, l_);
            IEnumerable<Claim.DiagnosisComponent> n_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)m_);
            bool? o_(Claim.DiagnosisComponent D)
            {
                PositiveInt aj_ = D?.SequenceElement;
                int? ak_ = aj_?.Value;
                IEnumerable<Claim> al_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
                bool? am_(Claim C)
                {
                    Code<FinancialResourceStatusCodes> bl_ = C?.StatusElement;
                    FinancialResourceStatusCodes? bm_ = bl_?.Value;
                    Code<FinancialResourceStatusCodes> bn_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bm_);
                    bool? bo_ = context.Operators.Equal(bn_, "active");
                    Code<ClaimUseCode> bp_ = C?.UseElement;
                    ClaimUseCode? bq_ = bp_?.Value;
                    Code<ClaimUseCode> br_ = context.Operators.Convert<Code<ClaimUseCode>>(bq_);
                    bool? bs_ = context.Operators.Equal(br_, "claim");
                    bool? bt_ = context.Operators.And(bo_, bs_);
                    List<Claim.ItemComponent> bu_ = C?.Item;
                    bool? bv_(Claim.ItemComponent I)
                    {
                        List<ResourceReference> bz_ = I?.Encounter;
                        bool? ca_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bz_, E);

                        return ca_;
                    };
                    IEnumerable<Claim.ItemComponent> bw_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bu_, bv_);
                    bool? bx_ = context.Operators.Exists<Claim.ItemComponent>(bw_);
                    bool? by_ = context.Operators.And(bt_, bx_);

                    return by_;
                };
                IEnumerable<Claim> an_ = context.Operators.Where<Claim>(al_, am_);
                bool? ao_(Claim @this)
                {
                    List<Claim.ItemComponent> cb_ = @this?.Item;
                    bool? cc_ = context.Operators.Not((bool?)(cb_ is null));

                    return cc_;
                };
                IEnumerable<Claim> ap_ = context.Operators.Where<Claim>(an_, ao_);
                List<Claim.ItemComponent> aq_(Claim @this)
                {
                    List<Claim.ItemComponent> cd_ = @this?.Item;

                    return cd_;
                };
                IEnumerable<List<Claim.ItemComponent>> ar_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ap_, aq_);
                IEnumerable<Claim.ItemComponent> as_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)ar_);
                bool? at_(Claim.ItemComponent I)
                {
                    List<ResourceReference> ce_ = I?.Encounter;
                    bool? cf_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ce_, E);

                    return cf_;
                };
                IEnumerable<Claim.ItemComponent> au_ = context.Operators.Where<Claim.ItemComponent>(as_, at_);
                bool? av_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> cg_ = @this?.DiagnosisSequenceElement;
                    int? ch_(PositiveInt @this)
                    {
                        int? ck_ = @this?.Value;

                        return ck_;
                    };
                    IEnumerable<int?> ci_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)cg_, ch_);
                    bool? cj_ = context.Operators.Not((bool?)(ci_ is null));

                    return cj_;
                };
                IEnumerable<Claim.ItemComponent> aw_ = context.Operators.Where<Claim.ItemComponent>(au_, av_);
                IEnumerable<int?> ax_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> cl_ = @this?.DiagnosisSequenceElement;
                    int? cm_(PositiveInt @this)
                    {
                        int? co_ = @this?.Value;

                        return co_;
                    };
                    IEnumerable<int?> cn_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)cl_, cm_);

                    return cn_;
                };
                IEnumerable<IEnumerable<int?>> ay_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(aw_, ax_);
                IEnumerable<int?> az_ = context.Operators.Flatten<int?>(ay_);
                bool? ba_ = context.Operators.In<int?>(ak_, az_);
                List<CodeableConcept> bb_ = D?.Type;
                CqlConcept bc_(CodeableConcept @this)
                {
                    CqlConcept cp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return cp_;
                };
                IEnumerable<CqlConcept> bd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bb_, bc_);
                CqlCode be_ = this.Principal_Diagnosis(context);
                bool? bf_ = QICoreCommon_4_0_000.Instance.includesCode(context, bd_, be_);
                bool? bg_ = context.Operators.And(ba_, bf_);
                DataType bh_ = D?.Diagnosis;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool? bj_ = context.Operators.ConceptInValueSet(bi_ as CqlConcept, diagnosisValueSet);
                bool? bk_ = context.Operators.And(bg_, bj_);

                return bk_;
            };
            IEnumerable<Claim.DiagnosisComponent> p_ = context.Operators.Where<Claim.DiagnosisComponent>(n_, o_);

            return p_;
        };
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> c_ = context.Operators.Select<Encounter, IEnumerable<Claim.DiagnosisComponent>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> d_ = context.Operators.Distinct<IEnumerable<Claim.DiagnosisComponent>>(c_);
        IEnumerable<Claim.DiagnosisComponent> e_ = context.Operators.Flatten<Claim.DiagnosisComponent>(d_);
        bool? f_ = context.Operators.Exists<Claim.DiagnosisComponent>(e_);

        return f_;
    }


    [CqlFunctionDefinition("hasDiagnosisPresentOnAdmission")]
    public bool? hasDiagnosisPresentOnAdmission(CqlContext context, Encounter encounter, CqlValueSet diagnosisValueSet)
    {
        Encounter[] a_ = [
            encounter,
        ];
        IEnumerable<Claim.DiagnosisComponent> b_(Encounter E)
        {
            IEnumerable<Claim> g_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
            bool? h_(Claim C)
            {
                Code<FinancialResourceStatusCodes> q_ = C?.StatusElement;
                FinancialResourceStatusCodes? r_ = q_?.Value;
                Code<FinancialResourceStatusCodes> s_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(r_);
                bool? t_ = context.Operators.Equal(s_, "active");
                Code<ClaimUseCode> u_ = C?.UseElement;
                ClaimUseCode? v_ = u_?.Value;
                Code<ClaimUseCode> w_ = context.Operators.Convert<Code<ClaimUseCode>>(v_);
                bool? x_ = context.Operators.Equal(w_, "claim");
                bool? y_ = context.Operators.And(t_, x_);
                List<Claim.ItemComponent> z_ = C?.Item;
                bool? aa_(Claim.ItemComponent I)
                {
                    List<ResourceReference> ae_ = I?.Encounter;
                    bool? af_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ae_, E);

                    return af_;
                };
                IEnumerable<Claim.ItemComponent> ab_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)z_, aa_);
                bool? ac_ = context.Operators.Exists<Claim.ItemComponent>(ab_);
                bool? ad_ = context.Operators.And(y_, ac_);

                return ad_;
            };
            IEnumerable<Claim> i_ = context.Operators.Where<Claim>(g_, h_);
            bool? j_(Claim @this)
            {
                List<Claim.DiagnosisComponent> ag_ = @this?.Diagnosis;
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));

                return ah_;
            };
            IEnumerable<Claim> k_ = context.Operators.Where<Claim>(i_, j_);
            List<Claim.DiagnosisComponent> l_(Claim @this)
            {
                List<Claim.DiagnosisComponent> ai_ = @this?.Diagnosis;

                return ai_;
            };
            IEnumerable<List<Claim.DiagnosisComponent>> m_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(k_, l_);
            IEnumerable<Claim.DiagnosisComponent> n_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)m_);
            bool? o_(Claim.DiagnosisComponent D)
            {
                PositiveInt aj_ = D?.SequenceElement;
                int? ak_ = aj_?.Value;
                IEnumerable<Claim> al_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
                bool? am_(Claim C)
                {
                    Code<FinancialResourceStatusCodes> bk_ = C?.StatusElement;
                    FinancialResourceStatusCodes? bl_ = bk_?.Value;
                    Code<FinancialResourceStatusCodes> bm_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bl_);
                    bool? bn_ = context.Operators.Equal(bm_, "active");
                    Code<ClaimUseCode> bo_ = C?.UseElement;
                    ClaimUseCode? bp_ = bo_?.Value;
                    Code<ClaimUseCode> bq_ = context.Operators.Convert<Code<ClaimUseCode>>(bp_);
                    bool? br_ = context.Operators.Equal(bq_, "claim");
                    bool? bs_ = context.Operators.And(bn_, br_);
                    List<Claim.ItemComponent> bt_ = C?.Item;
                    bool? bu_(Claim.ItemComponent I)
                    {
                        List<ResourceReference> by_ = I?.Encounter;
                        bool? bz_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)by_, E);

                        return bz_;
                    };
                    IEnumerable<Claim.ItemComponent> bv_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bt_, bu_);
                    bool? bw_ = context.Operators.Exists<Claim.ItemComponent>(bv_);
                    bool? bx_ = context.Operators.And(bs_, bw_);

                    return bx_;
                };
                IEnumerable<Claim> an_ = context.Operators.Where<Claim>(al_, am_);
                bool? ao_(Claim @this)
                {
                    List<Claim.ItemComponent> ca_ = @this?.Item;
                    bool? cb_ = context.Operators.Not((bool?)(ca_ is null));

                    return cb_;
                };
                IEnumerable<Claim> ap_ = context.Operators.Where<Claim>(an_, ao_);
                List<Claim.ItemComponent> aq_(Claim @this)
                {
                    List<Claim.ItemComponent> cc_ = @this?.Item;

                    return cc_;
                };
                IEnumerable<List<Claim.ItemComponent>> ar_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ap_, aq_);
                IEnumerable<Claim.ItemComponent> as_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)ar_);
                bool? at_(Claim.ItemComponent I)
                {
                    List<ResourceReference> cd_ = I?.Encounter;
                    bool? ce_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)cd_, E);

                    return ce_;
                };
                IEnumerable<Claim.ItemComponent> au_ = context.Operators.Where<Claim.ItemComponent>(as_, at_);
                bool? av_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> cf_ = @this?.DiagnosisSequenceElement;
                    int? cg_(PositiveInt @this)
                    {
                        int? cj_ = @this?.Value;

                        return cj_;
                    };
                    IEnumerable<int?> ch_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)cf_, cg_);
                    bool? ci_ = context.Operators.Not((bool?)(ch_ is null));

                    return ci_;
                };
                IEnumerable<Claim.ItemComponent> aw_ = context.Operators.Where<Claim.ItemComponent>(au_, av_);
                IEnumerable<int?> ax_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> ck_ = @this?.DiagnosisSequenceElement;
                    int? cl_(PositiveInt @this)
                    {
                        int? cn_ = @this?.Value;

                        return cn_;
                    };
                    IEnumerable<int?> cm_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ck_, cl_);

                    return cm_;
                };
                IEnumerable<IEnumerable<int?>> ay_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(aw_, ax_);
                IEnumerable<int?> az_ = context.Operators.Flatten<int?>(ay_);
                bool? ba_ = context.Operators.In<int?>(ak_, az_);
                CodeableConcept bb_ = D?.OnAdmission;
                CqlConcept bc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bb_);
                CqlValueSet bd_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? be_ = context.Operators.ConceptInValueSet(bc_, bd_);
                bool? bf_ = context.Operators.And(ba_, be_);
                DataType bg_ = D?.Diagnosis;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                bool? bi_ = context.Operators.ConceptInValueSet(bh_ as CqlConcept, diagnosisValueSet);
                bool? bj_ = context.Operators.And(bf_, bi_);

                return bj_;
            };
            IEnumerable<Claim.DiagnosisComponent> p_ = context.Operators.Where<Claim.DiagnosisComponent>(n_, o_);

            return p_;
        };
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> c_ = context.Operators.Select<Encounter, IEnumerable<Claim.DiagnosisComponent>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> d_ = context.Operators.Distinct<IEnumerable<Claim.DiagnosisComponent>>(c_);
        IEnumerable<Claim.DiagnosisComponent> e_ = context.Operators.Flatten<Claim.DiagnosisComponent>(d_);
        bool? f_ = context.Operators.Exists<Claim.DiagnosisComponent>(e_);

        return f_;
    }


    [CqlFunctionDefinition("hasDiagnosisNotPresentOnAdmission")]
    public bool? hasDiagnosisNotPresentOnAdmission(CqlContext context, Encounter encounter, CqlValueSet diagnosisValueSet)
    {
        Encounter[] a_ = [
            encounter,
        ];
        IEnumerable<Claim.DiagnosisComponent> b_(Encounter E)
        {
            IEnumerable<Claim> g_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
            bool? h_(Claim C)
            {
                Code<FinancialResourceStatusCodes> q_ = C?.StatusElement;
                FinancialResourceStatusCodes? r_ = q_?.Value;
                Code<FinancialResourceStatusCodes> s_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(r_);
                bool? t_ = context.Operators.Equal(s_, "active");
                Code<ClaimUseCode> u_ = C?.UseElement;
                ClaimUseCode? v_ = u_?.Value;
                Code<ClaimUseCode> w_ = context.Operators.Convert<Code<ClaimUseCode>>(v_);
                bool? x_ = context.Operators.Equal(w_, "claim");
                bool? y_ = context.Operators.And(t_, x_);
                List<Claim.ItemComponent> z_ = C?.Item;
                bool? aa_(Claim.ItemComponent I)
                {
                    List<ResourceReference> ae_ = I?.Encounter;
                    bool? af_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ae_, E);

                    return af_;
                };
                IEnumerable<Claim.ItemComponent> ab_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)z_, aa_);
                bool? ac_ = context.Operators.Exists<Claim.ItemComponent>(ab_);
                bool? ad_ = context.Operators.And(y_, ac_);

                return ad_;
            };
            IEnumerable<Claim> i_ = context.Operators.Where<Claim>(g_, h_);
            bool? j_(Claim @this)
            {
                List<Claim.DiagnosisComponent> ag_ = @this?.Diagnosis;
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));

                return ah_;
            };
            IEnumerable<Claim> k_ = context.Operators.Where<Claim>(i_, j_);
            List<Claim.DiagnosisComponent> l_(Claim @this)
            {
                List<Claim.DiagnosisComponent> ai_ = @this?.Diagnosis;

                return ai_;
            };
            IEnumerable<List<Claim.DiagnosisComponent>> m_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(k_, l_);
            IEnumerable<Claim.DiagnosisComponent> n_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)m_);
            bool? o_(Claim.DiagnosisComponent D)
            {
                PositiveInt aj_ = D?.SequenceElement;
                int? ak_ = aj_?.Value;
                IEnumerable<Claim> al_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
                bool? am_(Claim C)
                {
                    Code<FinancialResourceStatusCodes> bk_ = C?.StatusElement;
                    FinancialResourceStatusCodes? bl_ = bk_?.Value;
                    Code<FinancialResourceStatusCodes> bm_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bl_);
                    bool? bn_ = context.Operators.Equal(bm_, "active");
                    Code<ClaimUseCode> bo_ = C?.UseElement;
                    ClaimUseCode? bp_ = bo_?.Value;
                    Code<ClaimUseCode> bq_ = context.Operators.Convert<Code<ClaimUseCode>>(bp_);
                    bool? br_ = context.Operators.Equal(bq_, "claim");
                    bool? bs_ = context.Operators.And(bn_, br_);
                    List<Claim.ItemComponent> bt_ = C?.Item;
                    bool? bu_(Claim.ItemComponent I)
                    {
                        List<ResourceReference> by_ = I?.Encounter;
                        bool? bz_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)by_, E);

                        return bz_;
                    };
                    IEnumerable<Claim.ItemComponent> bv_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bt_, bu_);
                    bool? bw_ = context.Operators.Exists<Claim.ItemComponent>(bv_);
                    bool? bx_ = context.Operators.And(bs_, bw_);

                    return bx_;
                };
                IEnumerable<Claim> an_ = context.Operators.Where<Claim>(al_, am_);
                bool? ao_(Claim @this)
                {
                    List<Claim.ItemComponent> ca_ = @this?.Item;
                    bool? cb_ = context.Operators.Not((bool?)(ca_ is null));

                    return cb_;
                };
                IEnumerable<Claim> ap_ = context.Operators.Where<Claim>(an_, ao_);
                List<Claim.ItemComponent> aq_(Claim @this)
                {
                    List<Claim.ItemComponent> cc_ = @this?.Item;

                    return cc_;
                };
                IEnumerable<List<Claim.ItemComponent>> ar_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ap_, aq_);
                IEnumerable<Claim.ItemComponent> as_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)ar_);
                bool? at_(Claim.ItemComponent I)
                {
                    List<ResourceReference> cd_ = I?.Encounter;
                    bool? ce_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)cd_, E);

                    return ce_;
                };
                IEnumerable<Claim.ItemComponent> au_ = context.Operators.Where<Claim.ItemComponent>(as_, at_);
                bool? av_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> cf_ = @this?.DiagnosisSequenceElement;
                    int? cg_(PositiveInt @this)
                    {
                        int? cj_ = @this?.Value;

                        return cj_;
                    };
                    IEnumerable<int?> ch_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)cf_, cg_);
                    bool? ci_ = context.Operators.Not((bool?)(ch_ is null));

                    return ci_;
                };
                IEnumerable<Claim.ItemComponent> aw_ = context.Operators.Where<Claim.ItemComponent>(au_, av_);
                IEnumerable<int?> ax_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> ck_ = @this?.DiagnosisSequenceElement;
                    int? cl_(PositiveInt @this)
                    {
                        int? cn_ = @this?.Value;

                        return cn_;
                    };
                    IEnumerable<int?> cm_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)ck_, cl_);

                    return cm_;
                };
                IEnumerable<IEnumerable<int?>> ay_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(aw_, ax_);
                IEnumerable<int?> az_ = context.Operators.Flatten<int?>(ay_);
                bool? ba_ = context.Operators.In<int?>(ak_, az_);
                CodeableConcept bb_ = D?.OnAdmission;
                CqlConcept bc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bb_);
                CqlValueSet bd_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? be_ = context.Operators.ConceptInValueSet(bc_, bd_);
                bool? bf_ = context.Operators.And(ba_, be_);
                DataType bg_ = D?.Diagnosis;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                bool? bi_ = context.Operators.ConceptInValueSet(bh_ as CqlConcept, diagnosisValueSet);
                bool? bj_ = context.Operators.And(bf_, bi_);

                return bj_;
            };
            IEnumerable<Claim.DiagnosisComponent> p_ = context.Operators.Where<Claim.DiagnosisComponent>(n_, o_);

            return p_;
        };
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> c_ = context.Operators.Select<Encounter, IEnumerable<Claim.DiagnosisComponent>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> d_ = context.Operators.Distinct<IEnumerable<Claim.DiagnosisComponent>>(c_);
        IEnumerable<Claim.DiagnosisComponent> e_ = context.Operators.Flatten<Claim.DiagnosisComponent>(d_);
        bool? f_ = context.Operators.Exists<Claim.DiagnosisComponent>(e_);

        return f_;
    }


    [CqlFunctionDefinition("hasDiagnosisNotPresentOnAdmission")]
    public bool? hasDiagnosisNotPresentOnAdmission(CqlContext context, Encounter encounter)
    {
        Encounter[] a_ = [
            encounter,
        ];
        IEnumerable<Claim.DiagnosisComponent> b_(Encounter E)
        {
            IEnumerable<Claim> g_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
            bool? h_(Claim C)
            {
                Code<FinancialResourceStatusCodes> q_ = C?.StatusElement;
                FinancialResourceStatusCodes? r_ = q_?.Value;
                Code<FinancialResourceStatusCodes> s_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(r_);
                bool? t_ = context.Operators.Equal(s_, "active");
                Code<ClaimUseCode> u_ = C?.UseElement;
                ClaimUseCode? v_ = u_?.Value;
                Code<ClaimUseCode> w_ = context.Operators.Convert<Code<ClaimUseCode>>(v_);
                bool? x_ = context.Operators.Equal(w_, "claim");
                bool? y_ = context.Operators.And(t_, x_);
                List<Claim.ItemComponent> z_ = C?.Item;
                bool? aa_(Claim.ItemComponent I)
                {
                    List<ResourceReference> ae_ = I?.Encounter;
                    bool? af_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ae_, E);

                    return af_;
                };
                IEnumerable<Claim.ItemComponent> ab_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)z_, aa_);
                bool? ac_ = context.Operators.Exists<Claim.ItemComponent>(ab_);
                bool? ad_ = context.Operators.And(y_, ac_);

                return ad_;
            };
            IEnumerable<Claim> i_ = context.Operators.Where<Claim>(g_, h_);
            bool? j_(Claim @this)
            {
                List<Claim.DiagnosisComponent> ag_ = @this?.Diagnosis;
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));

                return ah_;
            };
            IEnumerable<Claim> k_ = context.Operators.Where<Claim>(i_, j_);
            List<Claim.DiagnosisComponent> l_(Claim @this)
            {
                List<Claim.DiagnosisComponent> ai_ = @this?.Diagnosis;

                return ai_;
            };
            IEnumerable<List<Claim.DiagnosisComponent>> m_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(k_, l_);
            IEnumerable<Claim.DiagnosisComponent> n_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)m_);
            bool? o_(Claim.DiagnosisComponent D)
            {
                PositiveInt aj_ = D?.SequenceElement;
                int? ak_ = aj_?.Value;
                IEnumerable<Claim> al_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
                bool? am_(Claim C)
                {
                    Code<FinancialResourceStatusCodes> bg_ = C?.StatusElement;
                    FinancialResourceStatusCodes? bh_ = bg_?.Value;
                    Code<FinancialResourceStatusCodes> bi_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bh_);
                    bool? bj_ = context.Operators.Equal(bi_, "active");
                    Code<ClaimUseCode> bk_ = C?.UseElement;
                    ClaimUseCode? bl_ = bk_?.Value;
                    Code<ClaimUseCode> bm_ = context.Operators.Convert<Code<ClaimUseCode>>(bl_);
                    bool? bn_ = context.Operators.Equal(bm_, "claim");
                    bool? bo_ = context.Operators.And(bj_, bn_);
                    List<Claim.ItemComponent> bp_ = C?.Item;
                    bool? bq_(Claim.ItemComponent I)
                    {
                        List<ResourceReference> bu_ = I?.Encounter;
                        bool? bv_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bu_, E);

                        return bv_;
                    };
                    IEnumerable<Claim.ItemComponent> br_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bp_, bq_);
                    bool? bs_ = context.Operators.Exists<Claim.ItemComponent>(br_);
                    bool? bt_ = context.Operators.And(bo_, bs_);

                    return bt_;
                };
                IEnumerable<Claim> an_ = context.Operators.Where<Claim>(al_, am_);
                bool? ao_(Claim @this)
                {
                    List<Claim.ItemComponent> bw_ = @this?.Item;
                    bool? bx_ = context.Operators.Not((bool?)(bw_ is null));

                    return bx_;
                };
                IEnumerable<Claim> ap_ = context.Operators.Where<Claim>(an_, ao_);
                List<Claim.ItemComponent> aq_(Claim @this)
                {
                    List<Claim.ItemComponent> by_ = @this?.Item;

                    return by_;
                };
                IEnumerable<List<Claim.ItemComponent>> ar_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ap_, aq_);
                IEnumerable<Claim.ItemComponent> as_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)ar_);
                bool? at_(Claim.ItemComponent I)
                {
                    List<ResourceReference> bz_ = I?.Encounter;
                    bool? ca_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bz_, E);

                    return ca_;
                };
                IEnumerable<Claim.ItemComponent> au_ = context.Operators.Where<Claim.ItemComponent>(as_, at_);
                bool? av_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> cb_ = @this?.DiagnosisSequenceElement;
                    int? cc_(PositiveInt @this)
                    {
                        int? cf_ = @this?.Value;

                        return cf_;
                    };
                    IEnumerable<int?> cd_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)cb_, cc_);
                    bool? ce_ = context.Operators.Not((bool?)(cd_ is null));

                    return ce_;
                };
                IEnumerable<Claim.ItemComponent> aw_ = context.Operators.Where<Claim.ItemComponent>(au_, av_);
                IEnumerable<int?> ax_(Claim.ItemComponent @this)
                {
                    List<PositiveInt> cg_ = @this?.DiagnosisSequenceElement;
                    int? ch_(PositiveInt @this)
                    {
                        int? cj_ = @this?.Value;

                        return cj_;
                    };
                    IEnumerable<int?> ci_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)cg_, ch_);

                    return ci_;
                };
                IEnumerable<IEnumerable<int?>> ay_ = context.Operators.Select<Claim.ItemComponent, IEnumerable<int?>>(aw_, ax_);
                IEnumerable<int?> az_ = context.Operators.Flatten<int?>(ay_);
                bool? ba_ = context.Operators.In<int?>(ak_, az_);
                CodeableConcept bb_ = D?.OnAdmission;
                CqlConcept bc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bb_);
                CqlValueSet bd_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? be_ = context.Operators.ConceptInValueSet(bc_, bd_);
                bool? bf_ = context.Operators.And(ba_, be_);

                return bf_;
            };
            IEnumerable<Claim.DiagnosisComponent> p_ = context.Operators.Where<Claim.DiagnosisComponent>(n_, o_);

            return p_;
        };
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> c_ = context.Operators.Select<Encounter, IEnumerable<Claim.DiagnosisComponent>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> d_ = context.Operators.Distinct<IEnumerable<Claim.DiagnosisComponent>>(c_);
        IEnumerable<Claim.DiagnosisComponent> e_ = context.Operators.Flatten<Claim.DiagnosisComponent>(d_);
        bool? f_ = context.Operators.Exists<Claim.DiagnosisComponent>(e_);

        return f_;
    }


    [CqlFunctionDefinition("hasDiagnosisIn")]
    public bool? hasDiagnosisIn(CqlContext context, Claim claim, CqlValueSet vset)
    {
        List<Claim.DiagnosisComponent> a_ = claim?.Diagnosis;
        bool? b_(Claim.DiagnosisComponent @this)
        {
            DataType i_ = @this?.Diagnosis;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            bool? k_ = context.Operators.Not((bool?)(j_ is null));

            return k_;
        };
        IEnumerable<Claim.DiagnosisComponent> c_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)a_, b_);
        object d_(Claim.DiagnosisComponent @this)
        {
            DataType l_ = @this?.Diagnosis;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);

            return m_;
        };
        IEnumerable<object> e_ = context.Operators.Select<Claim.DiagnosisComponent, object>(c_, d_);
        bool? f_(object D)
        {
            bool? n_ = context.Operators.ConceptInValueSet(D as CqlConcept, vset);

            return n_;
        };
        IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
        bool? h_ = context.Operators.Exists<object>(g_);

        return h_;
    }


    [CqlFunctionDefinition("hasDiagnosisIn")]
    public bool? hasDiagnosisIn(CqlContext context, Encounter enc, CqlValueSet vset)
    {
        CqlConcept a_ = this.getDiagnosisCode(context, enc);
        bool? b_ = context.Operators.ConceptInValueSet(a_, vset);

        return b_;
    }


    [CqlFunctionDefinition("getDiagnosisCondition")]
    public IEnumerable<object> getDiagnosisCondition(CqlContext context, ResourceReference reference)
    {
        IEnumerable<Condition> a_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        bool? b_(Condition C)
        {
            Id l_ = C?.IdElement;
            string m_ = l_?.Value;
            bool? n_ = QICoreCommon_4_0_000.Instance.references(context, reference, m_);

            return n_;
        };
        IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        bool? e_(Condition D)
        {
            Id o_ = D?.IdElement;
            string p_ = o_?.Value;
            bool? q_ = QICoreCommon_4_0_000.Instance.references(context, reference, p_);

            return q_;
        };
        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        IEnumerable<object> g_ = context.Operators.Union<object>(c_ as IEnumerable<object>, f_ as IEnumerable<object>);
        IEnumerable<Procedure> h_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? i_(Procedure P)
        {
            Id r_ = P?.IdElement;
            string s_ = r_?.Value;
            bool? t_ = QICoreCommon_4_0_000.Instance.references(context, reference, s_);

            return t_;
        };
        IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
        IEnumerable<object> k_ = context.Operators.Union<object>(g_ as IEnumerable<object>, j_ as IEnumerable<object>);

        return k_;
    }


    [CqlFunctionDefinition("getDiagnosis")]
    public Encounter.DiagnosisComponent getDiagnosis(CqlContext context, Encounter enc)
    {
        List<Encounter.DiagnosisComponent> a_ = enc?.Diagnosis;
        bool? b_(Encounter.DiagnosisComponent diag)
        {
            ResourceReference e_ = diag?.Condition;
            IEnumerable<object> f_ = this.getDiagnosisCondition(context, e_);
            bool? g_ = context.Operators.Not((bool?)(f_ is null));

            return g_;
        };
        IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        Encounter.DiagnosisComponent d_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(c_);

        return d_;
    }


    [CqlFunctionDefinition("getDiagnosisCode")]
    public CqlConcept getDiagnosisCode(CqlContext context, Encounter enc)
    {
        Encounter.DiagnosisComponent a_ = this.getDiagnosis(context, enc);
        ResourceReference b_ = a_?.Condition;
        IEnumerable<object> c_ = this.getDiagnosisCondition(context, b_);
        bool? d_(object @this)
        {
            object i_ = context.Operators.LateBoundProperty<object>(@this, "code");
            CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, i_ as CodeableConcept);
            bool? k_ = context.Operators.Not((bool?)(j_ is null));

            return k_;
        };
        IEnumerable<object> e_ = context.Operators.Where<object>(c_, d_);
        CqlConcept f_(object @this)
        {
            object l_ = context.Operators.LateBoundProperty<object>(@this, "code");
            CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_ as CodeableConcept);

            return m_;
        };
        IEnumerable<CqlConcept> g_ = context.Operators.Select<object, CqlConcept>(e_, f_);
        CqlConcept h_ = context.Operators.SingletonFrom<CqlConcept>(g_);

        return h_;
    }


    [CqlFunctionDefinition("isIn")]
    public bool? isIn(CqlContext context, Procedure proc, CqlValueSet vset)
    {
        CodeableConcept a_ = proc?.Code;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? f_ = context.Operators.ConceptInValueSet(e_ as CqlConcept, vset);
        bool? g_ = context.Operators.And(c_, f_);

        return g_;
    }


    [CqlFunctionDefinition("isIn")]
    public bool? isIn(CqlContext context, Encounter enc, CqlValueSet vset)
    {
        List<CodeableConcept> a_ = enc?.Type;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept aType)
        {
            bool? h_ = context.Operators.ConceptInValueSet(aType as CqlConcept, vset);

            return h_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }


    [CqlFunctionDefinition("isIn")]
    public bool? isIn(CqlContext context, Observation obs, CqlValueSet vset)
    {
        DataType a_ = obs?.Value;
        object b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        bool? f_ = context.Operators.ConceptInValueSet(e_ as CqlConcept, vset);
        bool? g_ = context.Operators.And(c_, f_);

        return g_;
    }


    [CqlFunctionDefinition("isIn")]
    public bool? isIn(CqlContext context, Location loc, CqlValueSet vset)
    {
        List<CodeableConcept> a_ = loc?.Type;
        CqlConcept b_(CodeableConcept @this)
        {
            CqlConcept g_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

            return g_;
        };
        IEnumerable<CqlConcept> c_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_(CqlConcept aType)
        {
            bool? h_ = context.Operators.Not((bool?)(aType is null));
            bool? i_ = context.Operators.ConceptInValueSet(aType as CqlConcept, vset);
            bool? j_ = context.Operators.And(h_, i_);

            return j_;
        };
        IEnumerable<CqlConcept> e_ = context.Operators.Where<CqlConcept>(c_, d_);
        bool? f_ = context.Operators.Exists<CqlConcept>(e_);

        return f_;
    }


    [CqlFunctionDefinition("isIn")]
    public object isIn(CqlContext context, object choice, CqlValueSet vset)
    {
        object a_()
        {
            if (choice is Procedure)
            {
                string b_ = (choice as Procedure is Resource
        ? ((choice as Procedure) as Resource).IdElement
        : default)?.Value;
                bool? c_ = this.isIn(context, choice as Procedure, vset);
                (CqlTupleMetadata, string ID, bool? isInValueSet)? d_ = (CqlTupleMetadata_CLGZATEYYPDcCgNVCgHQMUiKY, b_, c_);

                return d_ as object;
            }
            else if (choice is Observation)
            {
                string e_ = (choice as Observation is Resource
        ? ((choice as Observation) as Resource).IdElement
        : default)?.Value;
                bool? f_ = this.isIn(context, choice as Observation, vset);
                (CqlTupleMetadata, string ID, bool? isInValueSet)? g_ = (CqlTupleMetadata_CLGZATEYYPDcCgNVCgHQMUiKY, e_, f_);

                return g_ as object;
            }
            else if (choice is Encounter)
            {
                string h_ = (choice as Encounter is Resource
        ? ((choice as Encounter) as Resource).IdElement
        : default)?.Value;
                bool? i_ = this.isIn(context, choice as Encounter, vset);
                (CqlTupleMetadata, string ID, bool? isInValueSet)? j_ = (CqlTupleMetadata_CLGZATEYYPDcCgNVCgHQMUiKY, h_, i_);

                return j_ as object;
            }
            else if (choice is Location)
            {
                string k_ = (choice as Location is Resource
        ? ((choice as Location) as Resource).IdElement
        : default)?.Value;
                bool? l_ = this.isIn(context, choice as Location, vset);
                (CqlTupleMetadata, string ID, bool? isInValueSet)? m_ = (CqlTupleMetadata_CLGZATEYYPDcCgNVCgHQMUiKY, k_, l_);

                return m_ as object;
            }
            else
            {
                return false;
            }
        };

        return a_();
    }


    [CqlFunctionDefinition("rank")]
    public int? rank(CqlContext context, Procedure targetProcedure, Encounter parentEncounter)
    {
        Procedure[] a_ = [
            targetProcedure,
        ];
        IEnumerable<int?> b_(Procedure P)
        {
            IEnumerable<Claim> g_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));
            bool? h_(Claim C)
            {
                Code<FinancialResourceStatusCodes> u_ = C?.StatusElement;
                FinancialResourceStatusCodes? v_ = u_?.Value;
                Code<FinancialResourceStatusCodes> w_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(v_);
                bool? x_ = context.Operators.Equal(w_, "active");
                Code<ClaimUseCode> y_ = C?.UseElement;
                ClaimUseCode? z_ = y_?.Value;
                Code<ClaimUseCode> aa_ = context.Operators.Convert<Code<ClaimUseCode>>(z_);
                bool? ab_ = context.Operators.Equal(aa_, "claim");
                bool? ac_ = context.Operators.And(x_, ab_);
                List<Claim.ItemComponent> ad_ = C?.Item;
                bool? ae_(Claim.ItemComponent I)
                {
                    List<ResourceReference> ai_ = I?.Encounter;
                    bool? aj_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ai_, parentEncounter);

                    return aj_;
                };
                IEnumerable<Claim.ItemComponent> af_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ad_, ae_);
                bool? ag_ = context.Operators.Exists<Claim.ItemComponent>(af_);
                bool? ah_ = context.Operators.And(ac_, ag_);

                return ah_;
            };
            IEnumerable<Claim> i_ = context.Operators.Where<Claim>(g_, h_);
            bool? j_(Claim @this)
            {
                List<Claim.ProcedureComponent> ak_ = @this?.Procedure;
                bool? al_ = context.Operators.Not((bool?)(ak_ is null));

                return al_;
            };
            IEnumerable<Claim> k_ = context.Operators.Where<Claim>(i_, j_);
            List<Claim.ProcedureComponent> l_(Claim @this)
            {
                List<Claim.ProcedureComponent> am_ = @this?.Procedure;

                return am_;
            };
            IEnumerable<List<Claim.ProcedureComponent>> m_ = context.Operators.Select<Claim, List<Claim.ProcedureComponent>>(k_, l_);
            IEnumerable<Claim.ProcedureComponent> n_ = context.Operators.Flatten<Claim.ProcedureComponent>((IEnumerable<IEnumerable<Claim.ProcedureComponent>>)m_);
            bool? o_(Claim.ProcedureComponent proc)
            {
                DataType an_ = proc?.Procedure;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                bool? ap_ = QICoreCommon_4_0_000.Instance.references(context, ao_ as ResourceReference, P);

                return ap_;
            };
            IEnumerable<Claim.ProcedureComponent> p_ = context.Operators.Where<Claim.ProcedureComponent>(n_, o_);
            bool? q_(Claim.ProcedureComponent @this)
            {
                PositiveInt aq_ = @this?.SequenceElement;
                int? ar_ = aq_?.Value;
                bool? as_ = context.Operators.Not((bool?)(ar_ is null));

                return as_;
            };
            IEnumerable<Claim.ProcedureComponent> r_ = context.Operators.Where<Claim.ProcedureComponent>(p_, q_);
            int? s_(Claim.ProcedureComponent @this)
            {
                PositiveInt at_ = @this?.SequenceElement;
                int? au_ = at_?.Value;

                return au_;
            };
            IEnumerable<int?> t_ = context.Operators.Select<Claim.ProcedureComponent, int?>(r_, s_);

            return t_;
        };
        IEnumerable<IEnumerable<int?>> c_ = context.Operators.Select<Procedure, IEnumerable<int?>>((IEnumerable<Procedure>)a_, b_);
        IEnumerable<IEnumerable<int?>> d_ = context.Operators.Distinct<IEnumerable<int?>>(c_);
        IEnumerable<int?> e_ = context.Operators.Flatten<int?>(d_);
        int? f_ = context.Operators.SingletonFrom<int?>(e_);

        return f_;
    }


    [CqlFunctionDefinition("startsDuringHospitalization")]
    public bool? startsDuringHospitalization(CqlContext context, object choice, Encounter enc)
    {
        bool? a_()
        {
            if (choice is Procedure)
            {
                object b_()
                {
                    bool g_()
                    {
                        DataType k_ = (choice as Procedure)?.Performed;
                        object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                        bool m_ = l_ is CqlDateTime;

                        return m_;
                    };
                    bool h_()
                    {
                        DataType n_ = (choice as Procedure)?.Performed;
                        object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                        bool p_ = o_ is CqlInterval<CqlDateTime>;

                        return p_;
                    };
                    bool i_()
                    {
                        DataType q_ = (choice as Procedure)?.Performed;
                        object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                        bool s_ = r_ is CqlQuantity;

                        return s_;
                    };
                    bool j_()
                    {
                        DataType t_ = (choice as Procedure)?.Performed;
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        bool v_ = u_ is CqlInterval<CqlQuantity>;

                        return v_;
                    };
                    if (g_())
                    {
                        DataType w_ = (choice as Procedure)?.Performed;
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);

                        return (x_ as CqlDateTime) as object;
                    }
                    else if (h_())
                    {
                        DataType y_ = (choice as Procedure)?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);

                        return (z_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (i_())
                    {
                        DataType aa_ = (choice as Procedure)?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);

                        return (ab_ as CqlQuantity) as object;
                    }
                    else if (j_())
                    {
                        DataType ac_ = (choice as Procedure)?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);

                        return (ad_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> c_ = QICoreCommon_4_0_000.Instance.ToInterval(context, b_());
                CqlDateTime d_ = context.Operators.Start(c_);
                CqlInterval<CqlDateTime> e_ = CQMCommon_4_1_000.Instance.HospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
                bool? f_ = context.Operators.In<CqlDateTime>(d_, e_, default);

                return f_;
            }
            else if (choice is Observation)
            {
                DataType ae_ = (choice as Observation)?.Effective;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.ToInterval(context, af_);
                CqlDateTime ah_ = context.Operators.Start(ag_);
                CqlInterval<CqlDateTime> ai_ = CQMCommon_4_1_000.Instance.HospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
                bool? aj_ = context.Operators.In<CqlDateTime>(ah_, ai_, default);

                return aj_;
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
                CqlInterval<CqlDateTime> b_ = CQMCommon_4_1_000.Instance.HospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
                object c_()
                {
                    bool f_()
                    {
                        DataType j_ = (choice as Procedure)?.Performed;
                        object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                        bool l_ = k_ is CqlDateTime;

                        return l_;
                    };
                    bool g_()
                    {
                        DataType m_ = (choice as Procedure)?.Performed;
                        object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                        bool o_ = n_ is CqlInterval<CqlDateTime>;

                        return o_;
                    };
                    bool h_()
                    {
                        DataType p_ = (choice as Procedure)?.Performed;
                        object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                        bool r_ = q_ is CqlQuantity;

                        return r_;
                    };
                    bool i_()
                    {
                        DataType s_ = (choice as Procedure)?.Performed;
                        object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                        bool u_ = t_ is CqlInterval<CqlQuantity>;

                        return u_;
                    };
                    if (f_())
                    {
                        DataType v_ = (choice as Procedure)?.Performed;
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);

                        return (w_ as CqlDateTime) as object;
                    }
                    else if (g_())
                    {
                        DataType x_ = (choice as Procedure)?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);

                        return (y_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (h_())
                    {
                        DataType z_ = (choice as Procedure)?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);

                        return (aa_ as CqlQuantity) as object;
                    }
                    else if (i_())
                    {
                        DataType ab_ = (choice as Procedure)?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);

                        return (ac_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> d_ = QICoreCommon_4_0_000.Instance.ToInterval(context, c_());
                bool? e_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(b_, d_, default);

                return e_;
            }
            else if (choice is Observation)
            {
                CqlInterval<CqlDateTime> ad_ = CQMCommon_4_1_000.Instance.HospitalizationWithObservationAndOutpatientSurgeryService(context, enc);
                DataType ae_ = (choice as Observation)?.Effective;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.ToInterval(context, af_);
                bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ad_, ag_, default);

                return ah_;
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
                object b_()
                {
                    bool d_()
                    {
                        DataType h_ = (choice as Procedure)?.Performed;
                        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                        bool j_ = i_ is CqlDateTime;

                        return j_;
                    };
                    bool e_()
                    {
                        DataType k_ = (choice as Procedure)?.Performed;
                        object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                        bool m_ = l_ is CqlInterval<CqlDateTime>;

                        return m_;
                    };
                    bool f_()
                    {
                        DataType n_ = (choice as Procedure)?.Performed;
                        object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                        bool p_ = o_ is CqlQuantity;

                        return p_;
                    };
                    bool g_()
                    {
                        DataType q_ = (choice as Procedure)?.Performed;
                        object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                        bool s_ = r_ is CqlInterval<CqlQuantity>;

                        return s_;
                    };
                    if (d_())
                    {
                        DataType t_ = (choice as Procedure)?.Performed;
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);

                        return (u_ as CqlDateTime) as object;
                    }
                    else if (e_())
                    {
                        DataType v_ = (choice as Procedure)?.Performed;
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);

                        return (w_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (f_())
                    {
                        DataType x_ = (choice as Procedure)?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);

                        return (y_ as CqlQuantity) as object;
                    }
                    else if (g_())
                    {
                        DataType z_ = (choice as Procedure)?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);

                        return (aa_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> c_ = QICoreCommon_4_0_000.Instance.ToInterval(context, b_());

                return c_;
            }
            else if (choice is Observation)
            {
                DataType ab_ = (choice as Observation)?.Effective;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.ToInterval(context, ac_);

                return ad_;
            }
            else if (choice is Encounter)
            {
                Period ae_ = (choice as Encounter)?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.ToInterval(context, af_ as object);

                return ag_;
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

    private static CqlTupleMetadata CqlTupleMetadata_CLGZATEYYPDcCgNVCgHQMUiKY = new(
      [typeof(string), typeof(bool?)],
      ["ID", "isInValueSet"]);

    #endregion CqlTupleMetadata Properties

}

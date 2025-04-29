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
[CqlLibrary("NCQAStatus", "1.0.0")]
public partial class NCQAStatus_1_0_0 : ILibrary, ISingleton<NCQAStatus_1_0_0>
{
    private NCQAStatus_1_0_0() {}

    public static NCQAStatus_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "NCQAStatus";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQATerminology_1_0_0.Instance];

    #endregion ILibrary Implementation

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ro_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient rp_ = context.Operators.SingletonFrom<Patient>(ro_);

        return rp_;
    }


    [CqlExpressionDefinition("Active Allergy")]
    public IEnumerable<AllergyIntolerance> Active_Allergy(CqlContext context, IEnumerable<AllergyIntolerance> Allergy)
    {
        bool? rq_(AllergyIntolerance A)
        {
            CodeableConcept rs_ = A?.ClinicalStatus;
            CqlConcept rt_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, rs_);
            CqlCode ru_ = NCQATerminology_1_0_0.Instance.allergy_active(context);
            CqlConcept rv_ = context.Operators.ConvertCodeToConcept(ru_);
            bool? rw_ = context.Operators.Equal(rt_, rv_);

            return rw_;
        };
        IEnumerable<AllergyIntolerance> rr_ = context.Operators.Where<AllergyIntolerance>(Allergy, rq_);

        return rr_;
    }


    [CqlExpressionDefinition("Active Condition")]
    public IEnumerable<Condition> Active_Condition(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? rx_(Condition C)
        {
            CodeableConcept rz_ = C?.ClinicalStatus;
            CqlConcept sa_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, rz_);
            CqlCode sb_ = NCQATerminology_1_0_0.Instance.active(context);
            CqlConcept sc_ = context.Operators.ConvertCodeToConcept(sb_);
            bool? sd_ = context.Operators.Equal(sa_, sc_);

            return sd_;
        };
        IEnumerable<Condition> ry_ = context.Operators.Where<Condition>(Condition, rx_);

        return ry_;
    }


    [CqlExpressionDefinition("Finished Encounter")]
    public IEnumerable<Encounter> Finished_Encounter(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? se_(Encounter E)
        {
            Code<Encounter.EncounterStatus> sg_ = E?.StatusElement;
            string sh_ = FHIRHelpers_4_0_001.Instance.ToString(context, sg_);
            bool? si_ = context.Operators.Equal(sh_, "finished");

            return si_;
        };
        IEnumerable<Encounter> sf_ = context.Operators.Where<Encounter>(Enc, se_);

        return sf_;
    }


    [CqlExpressionDefinition("Completed Immunization")]
    public IEnumerable<Immunization> Completed_Immunization(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? sj_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> sl_ = I?.StatusElement;
            string sm_ = FHIRHelpers_4_0_001.Instance.ToString(context, sl_);
            bool? sn_ = context.Operators.Equal(sm_, "completed");

            return sn_;
        };
        IEnumerable<Immunization> sk_ = context.Operators.Where<Immunization>(Immunization, sj_);

        return sk_;
    }


    [CqlExpressionDefinition("Dispensed Medication")]
    public IEnumerable<MedicationDispense> Dispensed_Medication(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? so_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> sq_ = M?.StatusElement;
            string sr_ = FHIRHelpers_4_0_001.Instance.ToString(context, sq_);
            bool? ss_ = context.Operators.Equal(sr_, "completed");

            return ss_;
        };
        IEnumerable<MedicationDispense> sp_ = context.Operators.Where<MedicationDispense>(Med, so_);

        return sp_;
    }


    [CqlExpressionDefinition("Active Medication")]
    public IEnumerable<MedicationRequest> Active_Medication(CqlContext context, IEnumerable<MedicationRequest> Med)
    {
        bool? st_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> sv_ = M?.StatusElement;
            string sw_ = FHIRHelpers_4_0_001.Instance.ToString(context, sv_);
            string[] sx_ = [
                "completed",
            ];
            bool? sy_ = context.Operators.In<string>(sw_, sx_ as IEnumerable<string>);

            return sy_;
        };
        IEnumerable<MedicationRequest> su_ = context.Operators.Where<MedicationRequest>(Med, st_);

        return su_;
    }


    [CqlExpressionDefinition("Completed Procedure")]
    public IEnumerable<Procedure> Completed_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? sz_(Procedure P)
        {
            Code<EventStatus> tb_ = P?.StatusElement;
            string tc_ = FHIRHelpers_4_0_001.Instance.ToString(context, tb_);
            bool? td_ = context.Operators.Equal(tc_, "completed");

            return td_;
        };
        IEnumerable<Procedure> ta_ = context.Operators.Where<Procedure>(Proc, sz_);

        return ta_;
    }


    [CqlExpressionDefinition("Completed or Ongoing Procedure")]
    public IEnumerable<Procedure> Completed_or_Ongoing_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? te_(Procedure P)
        {
            Code<EventStatus> tg_ = P?.StatusElement;
            string th_ = FHIRHelpers_4_0_001.Instance.ToString(context, tg_);
            string[] ti_ = [
                "completed",
                "in-progress",
            ];
            bool? tj_ = context.Operators.In<string>(th_, ti_ as IEnumerable<string>);

            return tj_;
        };
        IEnumerable<Procedure> tf_ = context.Operators.Where<Procedure>(Proc, te_);

        return tf_;
    }


    #endregion Expressions

}

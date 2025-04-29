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

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient vzzzzk_ = context.Operators.SingletonFrom<Patient>(vzzzzj_);

        return vzzzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<AllergyIntolerance> Active_Allergy(CqlContext context, IEnumerable<AllergyIntolerance> Allergy)
    {
        bool? vzzzzl_(AllergyIntolerance A)
        {
            CodeableConcept vzzzzn_ = A?.ClinicalStatus;
            CqlConcept vzzzzo_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, vzzzzn_);
            CqlCode vzzzzp_ = NCQATerminology_1_0_0.Instance.allergy_active(context);
            CqlConcept vzzzzq_ = context.Operators.ConvertCodeToConcept(vzzzzp_);
            bool? vzzzzr_ = context.Operators.Equal(vzzzzo_, vzzzzq_);

            return vzzzzr_;
        };
        IEnumerable<AllergyIntolerance> vzzzzm_ = context.Operators.Where<AllergyIntolerance>(Allergy, vzzzzl_);

        return vzzzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Condition> Active_Condition(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? vzzzzs_(Condition C)
        {
            CodeableConcept vzzzzu_ = C?.ClinicalStatus;
            CqlConcept vzzzzv_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, vzzzzu_);
            CqlCode vzzzzw_ = NCQATerminology_1_0_0.Instance.active(context);
            CqlConcept vzzzzx_ = context.Operators.ConvertCodeToConcept(vzzzzw_);
            bool? vzzzzy_ = context.Operators.Equal(vzzzzv_, vzzzzx_);

            return vzzzzy_;
        };
        IEnumerable<Condition> vzzzzt_ = context.Operators.Where<Condition>(Condition, vzzzzs_);

        return vzzzzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Encounter> Finished_Encounter(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? vzzzzz_(Encounter E)
        {
            Code<Encounter.EncounterStatus> wzzzzb_ = E?.StatusElement;
            string wzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzb_);
            bool? wzzzzd_ = context.Operators.Equal(wzzzzc_, "finished");

            return wzzzzd_;
        };
        IEnumerable<Encounter> wzzzza_ = context.Operators.Where<Encounter>(Enc, vzzzzz_);

        return wzzzza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Immunization> Completed_Immunization(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? wzzzze_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> wzzzzg_ = I?.StatusElement;
            string wzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzg_);
            bool? wzzzzi_ = context.Operators.Equal(wzzzzh_, "completed");

            return wzzzzi_;
        };
        IEnumerable<Immunization> wzzzzf_ = context.Operators.Where<Immunization>(Immunization, wzzzze_);

        return wzzzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<MedicationDispense> Dispensed_Medication(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? wzzzzj_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> wzzzzl_ = M?.StatusElement;
            string wzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzl_);
            bool? wzzzzn_ = context.Operators.Equal(wzzzzm_, "completed");

            return wzzzzn_;
        };
        IEnumerable<MedicationDispense> wzzzzk_ = context.Operators.Where<MedicationDispense>(Med, wzzzzj_);

        return wzzzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<MedicationRequest> Active_Medication(CqlContext context, IEnumerable<MedicationRequest> Med)
    {
        bool? wzzzzo_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> wzzzzq_ = M?.StatusElement;
            string wzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzq_);
            string[] wzzzzs_ = [
                "completed",
            ];
            bool? wzzzzt_ = context.Operators.In<string>(wzzzzr_, wzzzzs_ as IEnumerable<string>);

            return wzzzzt_;
        };
        IEnumerable<MedicationRequest> wzzzzp_ = context.Operators.Where<MedicationRequest>(Med, wzzzzo_);

        return wzzzzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Procedure> Completed_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? wzzzzu_(Procedure P)
        {
            Code<EventStatus> wzzzzw_ = P?.StatusElement;
            string wzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzw_);
            bool? wzzzzy_ = context.Operators.Equal(wzzzzx_, "completed");

            return wzzzzy_;
        };
        IEnumerable<Procedure> wzzzzv_ = context.Operators.Where<Procedure>(Proc, wzzzzu_);

        return wzzzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Procedure> Completed_or_Ongoing_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? wzzzzz_(Procedure P)
        {
            Code<EventStatus> xzzzzb_ = P?.StatusElement;
            string xzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzb_);
            string[] xzzzzd_ = [
                "completed",
                "in-progress",
            ];
            bool? xzzzze_ = context.Operators.In<string>(xzzzzc_, xzzzzd_ as IEnumerable<string>);

            return xzzzze_;
        };
        IEnumerable<Procedure> xzzzza_ = context.Operators.Where<Procedure>(Proc, wzzzzz_);

        return xzzzza_;
    }


    #endregion Expressions

}

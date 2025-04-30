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
        IEnumerable<Patient> tzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient tzzzzj_ = context.Operators.SingletonFrom<Patient>(tzzzzi_);

        return tzzzzj_;
    }


    [CqlExpressionDefinition("Active Allergy")]
    public IEnumerable<AllergyIntolerance> Active_Allergy(CqlContext context, IEnumerable<AllergyIntolerance> Allergy)
    {
        bool? tzzzzk_(AllergyIntolerance A)
        {
            CodeableConcept tzzzzm_ = A?.ClinicalStatus;
            CqlConcept tzzzzn_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, tzzzzm_);
            CqlCode tzzzzo_ = NCQATerminology_1_0_0.Instance.allergy_active(context);
            CqlConcept tzzzzp_ = context.Operators.ConvertCodeToConcept(tzzzzo_);
            bool? tzzzzq_ = context.Operators.Equal(tzzzzn_, tzzzzp_);

            return tzzzzq_;
        };
        IEnumerable<AllergyIntolerance> tzzzzl_ = context.Operators.Where<AllergyIntolerance>(Allergy, tzzzzk_);

        return tzzzzl_;
    }


    [CqlExpressionDefinition("Active Condition")]
    public IEnumerable<Condition> Active_Condition(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? tzzzzr_(Condition C)
        {
            CodeableConcept tzzzzt_ = C?.ClinicalStatus;
            CqlConcept tzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, tzzzzt_);
            CqlCode tzzzzv_ = NCQATerminology_1_0_0.Instance.active(context);
            CqlConcept tzzzzw_ = context.Operators.ConvertCodeToConcept(tzzzzv_);
            bool? tzzzzx_ = context.Operators.Equal(tzzzzu_, tzzzzw_);

            return tzzzzx_;
        };
        IEnumerable<Condition> tzzzzs_ = context.Operators.Where<Condition>(Condition, tzzzzr_);

        return tzzzzs_;
    }


    [CqlExpressionDefinition("Finished Encounter")]
    public IEnumerable<Encounter> Finished_Encounter(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? tzzzzy_(Encounter E)
        {
            Code<Encounter.EncounterStatus> uzzzza_ = E?.StatusElement;
            string uzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzza_);
            bool? uzzzzc_ = context.Operators.Equal(uzzzzb_, "finished");

            return uzzzzc_;
        };
        IEnumerable<Encounter> tzzzzz_ = context.Operators.Where<Encounter>(Enc, tzzzzy_);

        return tzzzzz_;
    }


    [CqlExpressionDefinition("Completed Immunization")]
    public IEnumerable<Immunization> Completed_Immunization(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? uzzzzd_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> uzzzzf_ = I?.StatusElement;
            string uzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzf_);
            bool? uzzzzh_ = context.Operators.Equal(uzzzzg_, "completed");

            return uzzzzh_;
        };
        IEnumerable<Immunization> uzzzze_ = context.Operators.Where<Immunization>(Immunization, uzzzzd_);

        return uzzzze_;
    }


    [CqlExpressionDefinition("Dispensed Medication")]
    public IEnumerable<MedicationDispense> Dispensed_Medication(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? uzzzzi_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> uzzzzk_ = M?.StatusElement;
            string uzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzk_);
            bool? uzzzzm_ = context.Operators.Equal(uzzzzl_, "completed");

            return uzzzzm_;
        };
        IEnumerable<MedicationDispense> uzzzzj_ = context.Operators.Where<MedicationDispense>(Med, uzzzzi_);

        return uzzzzj_;
    }


    [CqlExpressionDefinition("Active Medication")]
    public IEnumerable<MedicationRequest> Active_Medication(CqlContext context, IEnumerable<MedicationRequest> Med)
    {
        bool? uzzzzn_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> uzzzzp_ = M?.StatusElement;
            string uzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzp_);
            string[] uzzzzr_ = [
                "completed",
            ];
            bool? uzzzzs_ = context.Operators.In<string>(uzzzzq_, uzzzzr_ as IEnumerable<string>);

            return uzzzzs_;
        };
        IEnumerable<MedicationRequest> uzzzzo_ = context.Operators.Where<MedicationRequest>(Med, uzzzzn_);

        return uzzzzo_;
    }


    [CqlExpressionDefinition("Completed Procedure")]
    public IEnumerable<Procedure> Completed_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? uzzzzt_(Procedure P)
        {
            Code<EventStatus> uzzzzv_ = P?.StatusElement;
            string uzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzv_);
            bool? uzzzzx_ = context.Operators.Equal(uzzzzw_, "completed");

            return uzzzzx_;
        };
        IEnumerable<Procedure> uzzzzu_ = context.Operators.Where<Procedure>(Proc, uzzzzt_);

        return uzzzzu_;
    }


    [CqlExpressionDefinition("Completed or Ongoing Procedure")]
    public IEnumerable<Procedure> Completed_or_Ongoing_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? uzzzzy_(Procedure P)
        {
            Code<EventStatus> vzzzza_ = P?.StatusElement;
            string vzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzza_);
            string[] vzzzzc_ = [
                "completed",
                "in-progress",
            ];
            bool? vzzzzd_ = context.Operators.In<string>(vzzzzb_, vzzzzc_ as IEnumerable<string>);

            return vzzzzd_;
        };
        IEnumerable<Procedure> uzzzzz_ = context.Operators.Where<Procedure>(Proc, uzzzzy_);

        return uzzzzz_;
    }


    #endregion Expressions

}

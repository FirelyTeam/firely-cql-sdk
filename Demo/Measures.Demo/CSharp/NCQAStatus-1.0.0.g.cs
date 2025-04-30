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
        IEnumerable<Patient> pzzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient pzzzn_ = context.Operators.SingletonFrom<Patient>(pzzzm_);

        return pzzzn_;
    }


    [CqlExpressionDefinition("Active Allergy")]
    public IEnumerable<AllergyIntolerance> Active_Allergy(CqlContext context, IEnumerable<AllergyIntolerance> Allergy)
    {
        bool? pzzzo_(AllergyIntolerance A)
        {
            CodeableConcept pzzzq_ = A?.ClinicalStatus;
            CqlConcept pzzzr_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, pzzzq_);
            CqlCode pzzzs_ = NCQATerminology_1_0_0.Instance.allergy_active(context);
            CqlConcept pzzzt_ = context.Operators.ConvertCodeToConcept(pzzzs_);
            bool? pzzzu_ = context.Operators.Equal(pzzzr_, pzzzt_);

            return pzzzu_;
        };
        IEnumerable<AllergyIntolerance> pzzzp_ = context.Operators.Where<AllergyIntolerance>(Allergy, pzzzo_);

        return pzzzp_;
    }


    [CqlExpressionDefinition("Active Condition")]
    public IEnumerable<Condition> Active_Condition(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? pzzzv_(Condition C)
        {
            CodeableConcept pzzzx_ = C?.ClinicalStatus;
            CqlConcept pzzzy_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, pzzzx_);
            CqlCode pzzzz_ = NCQATerminology_1_0_0.Instance.active(context);
            CqlConcept qzzza_ = context.Operators.ConvertCodeToConcept(pzzzz_);
            bool? qzzzb_ = context.Operators.Equal(pzzzy_, qzzza_);

            return qzzzb_;
        };
        IEnumerable<Condition> pzzzw_ = context.Operators.Where<Condition>(Condition, pzzzv_);

        return pzzzw_;
    }


    [CqlExpressionDefinition("Finished Encounter")]
    public IEnumerable<Encounter> Finished_Encounter(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? qzzzc_(Encounter E)
        {
            Code<Encounter.EncounterStatus> qzzze_ = E?.StatusElement;
            string qzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzze_);
            bool? qzzzg_ = context.Operators.Equal(qzzzf_, "finished");

            return qzzzg_;
        };
        IEnumerable<Encounter> qzzzd_ = context.Operators.Where<Encounter>(Enc, qzzzc_);

        return qzzzd_;
    }


    [CqlExpressionDefinition("Completed Immunization")]
    public IEnumerable<Immunization> Completed_Immunization(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? qzzzh_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> qzzzj_ = I?.StatusElement;
            string qzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzj_);
            bool? qzzzl_ = context.Operators.Equal(qzzzk_, "completed");

            return qzzzl_;
        };
        IEnumerable<Immunization> qzzzi_ = context.Operators.Where<Immunization>(Immunization, qzzzh_);

        return qzzzi_;
    }


    [CqlExpressionDefinition("Dispensed Medication")]
    public IEnumerable<MedicationDispense> Dispensed_Medication(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? qzzzm_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> qzzzo_ = M?.StatusElement;
            string qzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzo_);
            bool? qzzzq_ = context.Operators.Equal(qzzzp_, "completed");

            return qzzzq_;
        };
        IEnumerable<MedicationDispense> qzzzn_ = context.Operators.Where<MedicationDispense>(Med, qzzzm_);

        return qzzzn_;
    }


    [CqlExpressionDefinition("Active Medication")]
    public IEnumerable<MedicationRequest> Active_Medication(CqlContext context, IEnumerable<MedicationRequest> Med)
    {
        bool? qzzzr_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> qzzzt_ = M?.StatusElement;
            string qzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzt_);
            string[] qzzzv_ = [
                "completed",
            ];
            bool? qzzzw_ = context.Operators.In<string>(qzzzu_, qzzzv_ as IEnumerable<string>);

            return qzzzw_;
        };
        IEnumerable<MedicationRequest> qzzzs_ = context.Operators.Where<MedicationRequest>(Med, qzzzr_);

        return qzzzs_;
    }


    [CqlExpressionDefinition("Completed Procedure")]
    public IEnumerable<Procedure> Completed_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? qzzzx_(Procedure P)
        {
            Code<EventStatus> qzzzz_ = P?.StatusElement;
            string rzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzz_);
            bool? rzzzb_ = context.Operators.Equal(rzzza_, "completed");

            return rzzzb_;
        };
        IEnumerable<Procedure> qzzzy_ = context.Operators.Where<Procedure>(Proc, qzzzx_);

        return qzzzy_;
    }


    [CqlExpressionDefinition("Completed or Ongoing Procedure")]
    public IEnumerable<Procedure> Completed_or_Ongoing_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? rzzzc_(Procedure P)
        {
            Code<EventStatus> rzzze_ = P?.StatusElement;
            string rzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzze_);
            string[] rzzzg_ = [
                "completed",
                "in-progress",
            ];
            bool? rzzzh_ = context.Operators.In<string>(rzzzf_, rzzzg_ as IEnumerable<string>);

            return rzzzh_;
        };
        IEnumerable<Procedure> rzzzd_ = context.Operators.Where<Procedure>(Proc, rzzzc_);

        return rzzzd_;
    }


    #endregion Expressions

}

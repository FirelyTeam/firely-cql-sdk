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
        IEnumerable<Patient> rzzzzzw_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient rzzzzzx_ = context.Operators.SingletonFrom<Patient>(rzzzzzw_);

        return rzzzzzx_;
    }


    [CqlExpressionDefinition("Active Allergy")]
    public IEnumerable<AllergyIntolerance> Active_Allergy(CqlContext context, IEnumerable<AllergyIntolerance> Allergy)
    {
        bool? rzzzzzy_(AllergyIntolerance A)
        {
            CodeableConcept szzzzza_ = A?.ClinicalStatus;
            CqlConcept szzzzzb_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, szzzzza_);
            CqlCode szzzzzc_ = NCQATerminology_1_0_0.Instance.allergy_active(context);
            CqlConcept szzzzzd_ = context.Operators.ConvertCodeToConcept(szzzzzc_);
            bool? szzzzze_ = context.Operators.Equal(szzzzzb_, szzzzzd_);

            return szzzzze_;
        };
        IEnumerable<AllergyIntolerance> rzzzzzz_ = context.Operators.Where<AllergyIntolerance>(Allergy, rzzzzzy_);

        return rzzzzzz_;
    }


    [CqlExpressionDefinition("Active Condition")]
    public IEnumerable<Condition> Active_Condition(CqlContext context, IEnumerable<Condition> Condition)
    {
        bool? szzzzzf_(Condition C)
        {
            CodeableConcept szzzzzh_ = C?.ClinicalStatus;
            CqlConcept szzzzzi_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, szzzzzh_);
            CqlCode szzzzzj_ = NCQATerminology_1_0_0.Instance.active(context);
            CqlConcept szzzzzk_ = context.Operators.ConvertCodeToConcept(szzzzzj_);
            bool? szzzzzl_ = context.Operators.Equal(szzzzzi_, szzzzzk_);

            return szzzzzl_;
        };
        IEnumerable<Condition> szzzzzg_ = context.Operators.Where<Condition>(Condition, szzzzzf_);

        return szzzzzg_;
    }


    [CqlExpressionDefinition("Finished Encounter")]
    public IEnumerable<Encounter> Finished_Encounter(CqlContext context, IEnumerable<Encounter> Enc)
    {
        bool? szzzzzm_(Encounter E)
        {
            Code<Encounter.EncounterStatus> szzzzzo_ = E?.StatusElement;
            string szzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzo_);
            bool? szzzzzq_ = context.Operators.Equal(szzzzzp_, "finished");

            return szzzzzq_;
        };
        IEnumerable<Encounter> szzzzzn_ = context.Operators.Where<Encounter>(Enc, szzzzzm_);

        return szzzzzn_;
    }


    [CqlExpressionDefinition("Completed Immunization")]
    public IEnumerable<Immunization> Completed_Immunization(CqlContext context, IEnumerable<Immunization> Immunization)
    {
        bool? szzzzzr_(Immunization I)
        {
            Code<Immunization.ImmunizationStatusCodes> szzzzzt_ = I?.StatusElement;
            string szzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzt_);
            bool? szzzzzv_ = context.Operators.Equal(szzzzzu_, "completed");

            return szzzzzv_;
        };
        IEnumerable<Immunization> szzzzzs_ = context.Operators.Where<Immunization>(Immunization, szzzzzr_);

        return szzzzzs_;
    }


    [CqlExpressionDefinition("Dispensed Medication")]
    public IEnumerable<MedicationDispense> Dispensed_Medication(CqlContext context, IEnumerable<MedicationDispense> Med)
    {
        bool? szzzzzw_(MedicationDispense M)
        {
            Code<MedicationDispense.MedicationDispenseStatusCodes> szzzzzy_ = M?.StatusElement;
            string szzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzy_);
            bool? tzzzzza_ = context.Operators.Equal(szzzzzz_, "completed");

            return tzzzzza_;
        };
        IEnumerable<MedicationDispense> szzzzzx_ = context.Operators.Where<MedicationDispense>(Med, szzzzzw_);

        return szzzzzx_;
    }


    [CqlExpressionDefinition("Active Medication")]
    public IEnumerable<MedicationRequest> Active_Medication(CqlContext context, IEnumerable<MedicationRequest> Med)
    {
        bool? tzzzzzb_(MedicationRequest M)
        {
            Code<MedicationRequest.MedicationrequestStatus> tzzzzzd_ = M?.StatusElement;
            string tzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzd_);
            string[] tzzzzzf_ = [
                "completed",
            ];
            bool? tzzzzzg_ = context.Operators.In<string>(tzzzzze_, tzzzzzf_ as IEnumerable<string>);

            return tzzzzzg_;
        };
        IEnumerable<MedicationRequest> tzzzzzc_ = context.Operators.Where<MedicationRequest>(Med, tzzzzzb_);

        return tzzzzzc_;
    }


    [CqlExpressionDefinition("Completed Procedure")]
    public IEnumerable<Procedure> Completed_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? tzzzzzh_(Procedure P)
        {
            Code<EventStatus> tzzzzzj_ = P?.StatusElement;
            string tzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzj_);
            bool? tzzzzzl_ = context.Operators.Equal(tzzzzzk_, "completed");

            return tzzzzzl_;
        };
        IEnumerable<Procedure> tzzzzzi_ = context.Operators.Where<Procedure>(Proc, tzzzzzh_);

        return tzzzzzi_;
    }


    [CqlExpressionDefinition("Completed or Ongoing Procedure")]
    public IEnumerable<Procedure> Completed_or_Ongoing_Procedure(CqlContext context, IEnumerable<Procedure> Proc)
    {
        bool? tzzzzzm_(Procedure P)
        {
            Code<EventStatus> tzzzzzo_ = P?.StatusElement;
            string tzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzo_);
            string[] tzzzzzq_ = [
                "completed",
                "in-progress",
            ];
            bool? tzzzzzr_ = context.Operators.In<string>(tzzzzzp_, tzzzzzq_ as IEnumerable<string>);

            return tzzzzzr_;
        };
        IEnumerable<Procedure> tzzzzzn_ = context.Operators.Where<Procedure>(Proc, tzzzzzm_);

        return tzzzzzn_;
    }


    #endregion Expressions

}

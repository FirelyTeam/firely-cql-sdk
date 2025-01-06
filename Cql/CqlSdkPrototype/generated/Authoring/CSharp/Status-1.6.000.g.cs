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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.8.0")]
[CqlLibrary("Status", "1.6.000")]
public partial class Status_1_6_000 : ILibrary, ISingleton<Status_1_6_000>
{
    private Status_1_6_000() {}

    public static Status_1_6_000 Instance { get; } = new();

    #region Library Members
    string ILibrary.Name => "Status";
    string ILibrary.Version => "1.6.000";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_3_000.Instance];
    #endregion Library Members

    [CqlDeclaration("laboratory")]
    public CqlCode laboratory(CqlContext context) =>
        new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);



    [CqlDeclaration("exam")]
    public CqlCode exam(CqlContext context) =>
        new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);



    [CqlDeclaration("survey")]
    public CqlCode survey(CqlContext context) =>
        new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);



    [CqlDeclaration("vital-signs")]
    public CqlCode vital_signs(CqlContext context) =>
        new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);



    [CqlDeclaration("active")]
    public CqlCode active(CqlContext context) =>
        new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);



    [CqlDeclaration("ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
            new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
        ];

        return a_;
    }



    [CqlDeclaration("ConditionClinicalStatusCodes")]
    public CqlCode[] ConditionClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
        ];

        return a_;
    }


    public IEnumerable<object> Final_Survey_Observation(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> isAssessmentPerformed(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> Active_Condition(CqlContext context, IEnumerable<object> Condition) =>
        Condition;


    public IEnumerable<object> isActiveOnly(CqlContext context, IEnumerable<object> Condition) =>
        Condition;


    public IEnumerable<object> Completed_or_Ongoing_Device_Request(CqlContext context, IEnumerable<object> DeviceRequest) =>
        DeviceRequest;


    public IEnumerable<object> isDeviceOrder(CqlContext context, IEnumerable<object> DeviceRequest) =>
        DeviceRequest;


    public IEnumerable<object> Completed_or_Ongoing_Service_Request(CqlContext context, IEnumerable<object> ServiceRequest) =>
        ServiceRequest;


    public IEnumerable<object> isDiagnosticStudyOrder(CqlContext context, IEnumerable<object> ServiceRequest) =>
        ServiceRequest;


    public IEnumerable<object> isInterventionOrder(CqlContext context, IEnumerable<object> ServiceRequest) =>
        ServiceRequest;


    public IEnumerable<object> isLaboratoryTestOrder(CqlContext context, IEnumerable<object> ServiceRequest) =>
        ServiceRequest;


    public IEnumerable<object> Final_Observation(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> isDiagnosticStudyPerformed(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> Finished_Encounter(CqlContext context, IEnumerable<object> Enc) =>
        Enc;


    public IEnumerable<object> isEncounterPerformed(CqlContext context, IEnumerable<object> Enc) =>
        Enc;


    public IEnumerable<object> Completed_Immunization(CqlContext context, IEnumerable<object> Immunization) =>
        Immunization;


    public IEnumerable<object> isImmunizationAdministered(CqlContext context, IEnumerable<object> Immunization) =>
        Immunization;


    public IEnumerable<object> Completed_Procedure(CqlContext context, IEnumerable<object> Proc) =>
        Proc;


    public IEnumerable<object> isInterventionPerformed(CqlContext context, IEnumerable<object> Proc) =>
        Proc;


    public IEnumerable<object> isProcedurePerformed(CqlContext context, IEnumerable<object> Proc) =>
        Proc;


    public IEnumerable<object> Final_Lab_Observation(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> isLaboratoryTestPerformed(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> Active_Medication(CqlContext context, IEnumerable<object> MedicationRequest) =>
        MedicationRequest;


    public IEnumerable<object> isMedicationActive(CqlContext context, IEnumerable<object> MedicationRequest) =>
        MedicationRequest;


    public IEnumerable<object> Dispensed_Medication(CqlContext context, IEnumerable<object> Med) =>
        Med;


    public IEnumerable<object> isMedicationDispensed(CqlContext context, IEnumerable<object> Med) =>
        Med;


    public IEnumerable<object> Active_or_Completed_Medication_Request(CqlContext context, IEnumerable<object> MedicationRequest) =>
        MedicationRequest;


    public IEnumerable<object> isMedicationOrder(CqlContext context, IEnumerable<object> MedicationRequest) =>
        MedicationRequest;


    public IEnumerable<object> Final_Exam_Observation(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> isPhysicalExamPerformed(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> BloodPressure(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> BodyHeight(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> BodyWeight(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> BMI(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> isObservationBP(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> isObservationBodyHeight(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> isObservationBodyWeight(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> isObservationBMI(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> Initial_or_Final_Observation(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


    public IEnumerable<object> isSymptom(CqlContext context, IEnumerable<object> Obs) =>
        Obs;


}
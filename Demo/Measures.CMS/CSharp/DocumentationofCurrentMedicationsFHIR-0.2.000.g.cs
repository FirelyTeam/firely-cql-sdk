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
[CqlLibrary("DocumentationofCurrentMedicationsFHIR", "0.2.000")]
public partial class DocumentationofCurrentMedicationsFHIR_0_2_000 : ILibrary, ISingleton<DocumentationofCurrentMedicationsFHIR_0_2_000>
{
    private DocumentationofCurrentMedicationsFHIR_0_2_000() {}

    public static DocumentationofCurrentMedicationsFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DocumentationofCurrentMedicationsFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Encounter to Document Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", valueSetVersion: null)]
    public CqlValueSet Encounter_to_Document_Medications(CqlContext _) => _Encounter_to_Document_Medications;
    private static readonly CqlValueSet _Encounter_to_Document_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Documentation of current medications (procedure)", codeId: "428191000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Documentation_of_current_medications__procedure_(CqlContext _) => _Documentation_of_current_medications__procedure_;
    private static readonly CqlCode _Documentation_of_current_medications__procedure_ = new CqlCode("428191000124101", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null,
          _Documentation_of_current_medications__procedure_);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzn_, true, true);
        object wzzzzzzzzzzzzzzzzzzzzzp_ = context.ResolveParameter("DocumentationofCurrentMedicationsFHIR-0.2.000", "Measurement Period", wzzzzzzzzzzzzzzzzzzzzzo_);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzzzzzzzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzzzzzzzzzzzzzq_);

        return wzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return wzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> wzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return wzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return wzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return wzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzw_ = this.Encounter_to_Document_Medications(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? wzzzzzzzzzzzzzzzzzzzzzy_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> xzzzzzzzzzzzzzzzzzzzzza_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? xzzzzzzzzzzzzzzzzzzzzzb_ = xzzzzzzzzzzzzzzzzzzzzza_?.Value;
            Code<Encounter.EncounterStatus> xzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(xzzzzzzzzzzzzzzzzzzzzzb_);
            bool? xzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzc_, "finished");
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            Period xzzzzzzzzzzzzzzzzzzzzzf_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzf_);
            bool? xzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzg_, "day");
            bool? xzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzh_);

            return xzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzy_);

        return wzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzj_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);

        return xzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzk_ = this.Initial_Population(context);

        return xzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzl_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzm_(Encounter QualifyingEncounter)
        {
            CqlCode xzzzzzzzzzzzzzzzzzzzzzo_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzzzzzzo_);
            IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? xzzzzzzzzzzzzzzzzzzzzzr_(Procedure MedicationsDocumented)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzv_ = MedicationsDocumented?.Performed;
                object xzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzx_);
                Period xzzzzzzzzzzzzzzzzzzzzzz_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzz_);
                bool? yzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzza_, default);
                Code<EventStatus> yzzzzzzzzzzzzzzzzzzzzzc_ = MedicationsDocumented?.StatusElement;
                EventStatus? yzzzzzzzzzzzzzzzzzzzzzd_ = yzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                string yzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzd_);
                bool? yzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzzze_, "completed");
                bool? yzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzf_);

                return yzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(xzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter xzzzzzzzzzzzzzzzzzzzzzt_(Procedure MedicationsDocumented) =>
                QualifyingEncounter;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Procedure, Encounter>(xzzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzzt_);

            return xzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(xzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzm_);

        return xzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzi_(Encounter QualifyingEncounter)
        {
            CqlCode yzzzzzzzzzzzzzzzzzzzzzk_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzzzzzzk_);
            IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
            bool? yzzzzzzzzzzzzzzzzzzzzzn_(Procedure MedicationsNotDocumented)
            {
                bool? yzzzzzzzzzzzzzzzzzzzzzr_(Extension @this)
                {
                    string zzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Url;
                    FhirString zzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<FhirString>(zzzzzzzzzzzzzzzzzzzzzzl_);
                    string zzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzzzzzzzzzzm_);
                    bool? zzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return zzzzzzzzzzzzzzzzzzzzzzo_;
                };
                IEnumerable<Extension> yzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationsNotDocumented is DomainResource
                        ? (MedicationsNotDocumented as DomainResource).Extension
                        : default), yzzzzzzzzzzzzzzzzzzzzzr_);
                DataType yzzzzzzzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Value;

                    return zzzzzzzzzzzzzzzzzzzzzzp_;
                };
                IEnumerable<DataType> yzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Extension, DataType>(yzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzt_);
                DataType yzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<DataType>(yzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzv_);
                Period yzzzzzzzzzzzzzzzzzzzzzx_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzx_);
                bool? yzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzy_, default);
                Code<EventStatus> zzzzzzzzzzzzzzzzzzzzzza_ = MedicationsNotDocumented?.StatusElement;
                EventStatus? zzzzzzzzzzzzzzzzzzzzzzb_ = zzzzzzzzzzzzzzzzzzzzzza_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzb_);
                bool? zzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzzc_, "not-done");
                bool? zzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzd_);
                List<CodeableConcept> zzzzzzzzzzzzzzzzzzzzzzf_ = MedicationsNotDocumented?.ReasonCode;
                CqlConcept zzzzzzzzzzzzzzzzzzzzzzg_(CodeableConcept @this)
                {
                    CqlConcept zzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return zzzzzzzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzg_);
                CqlValueSet zzzzzzzzzzzzzzzzzzzzzzi_ = this.Medical_Reason(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzi_);
                bool? zzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzj_);

                return zzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzn_);
            Encounter yzzzzzzzzzzzzzzzzzzzzzp_(Procedure MedicationsNotDocumented) =>
                QualifyingEncounter;
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Procedure, Encounter>(yzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzp_);

            return yzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzi_);

        return yzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Expressions

}

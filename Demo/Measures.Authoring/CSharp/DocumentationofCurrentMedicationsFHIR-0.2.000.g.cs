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
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, QICoreCommon_2_0_000.Instance, SupplementalDataElements_3_4_000.Instance];

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
    private static readonly CqlCode _Documentation_of_current_medications__procedure_ = new CqlCode("428191000124101", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime izzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime izzzs_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> izzzt_ = context.Operators.Interval(izzzr_, izzzs_, true, false);
        object izzzu_ = context.ResolveParameter("DocumentationofCurrentMedicationsFHIR-0.2.000", "Measurement Period", izzzt_);

        return (CqlInterval<CqlDateTime>)izzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzw_ = context.Operators.SingletonFrom<Patient>(izzzv_);

        return izzzw_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzx_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

        return izzzx_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzy_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

        return izzzy_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzz_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

        return izzzz_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode jzzza_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

        return jzzza_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet jzzzb_ = this.Encounter_to_Document_Medications(context);
        IEnumerable<Encounter> jzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? jzzzd_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> jzzzf_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? jzzzg_ = jzzzf_?.Value;
            Code<Encounter.EncounterStatus> jzzzh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzg_);
            bool? jzzzi_ = context.Operators.Equal(jzzzh_, "finished");
            CqlInterval<CqlDateTime> jzzzj_ = this.Measurement_Period(context);
            Period jzzzk_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, jzzzk_);
            bool? jzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzj_, jzzzl_, "day");
            bool? jzzzn_ = context.Operators.And(jzzzi_, jzzzm_);

            return jzzzn_;
        };
        IEnumerable<Encounter> jzzze_ = context.Operators.Where<Encounter>(jzzzc_, jzzzd_);

        return jzzze_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> jzzzo_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);

        return jzzzo_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> jzzzp_ = this.Initial_Population(context);

        return jzzzp_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> jzzzq_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        IEnumerable<Encounter> jzzzr_(Encounter QualifyingEncounter)
        {
            CqlCode jzzzt_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> jzzzu_ = context.Operators.ToList<CqlCode>(jzzzt_);
            IEnumerable<Procedure> jzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, jzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? jzzzw_(Procedure MedicationsDocumented)
            {
                DataType kzzza_ = MedicationsDocumented?.Performed;
                object kzzzb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, kzzza_);
                CqlInterval<CqlDateTime> kzzzc_ = QICoreCommon_2_0_000.Instance.toInterval(context, kzzzb_);
                CqlDateTime kzzzd_ = context.Operators.End(kzzzc_);
                Period kzzze_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzf_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, kzzze_);
                bool? kzzzg_ = context.Operators.In<CqlDateTime>(kzzzd_, kzzzf_, default);
                Code<EventStatus> kzzzh_ = MedicationsDocumented?.StatusElement;
                EventStatus? kzzzi_ = kzzzh_?.Value;
                string kzzzj_ = context.Operators.Convert<string>(kzzzi_);
                bool? kzzzk_ = context.Operators.Equal(kzzzj_, "completed");
                bool? kzzzl_ = context.Operators.And(kzzzg_, kzzzk_);

                return kzzzl_;
            };
            IEnumerable<Procedure> jzzzx_ = context.Operators.Where<Procedure>(jzzzv_, jzzzw_);
            Encounter jzzzy_(Procedure MedicationsDocumented) =>
                QualifyingEncounter;
            IEnumerable<Encounter> jzzzz_ = context.Operators.Select<Procedure, Encounter>(jzzzx_, jzzzy_);

            return jzzzz_;
        };
        IEnumerable<Encounter> jzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzq_, jzzzr_);

        return jzzzs_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> kzzzm_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        IEnumerable<Encounter> kzzzn_(Encounter QualifyingEncounter)
        {
            CqlCode kzzzp_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> kzzzq_ = context.Operators.ToList<CqlCode>(kzzzp_);
            IEnumerable<Procedure> kzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, kzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
            bool? kzzzs_(Procedure MedicationsNotDocumented)
            {
                bool? kzzzw_(Extension @this)
                {
                    string lzzzq_ = @this?.Url;
                    FhirString lzzzr_ = context.Operators.Convert<FhirString>(lzzzq_);
                    string lzzzs_ = FHIRHelpers_4_3_000.Instance.ToString(context, lzzzr_);
                    bool? lzzzt_ = context.Operators.Equal(lzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return lzzzt_;
                };
                IEnumerable<Extension> kzzzx_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationsNotDocumented is DomainResource
                        ? (MedicationsNotDocumented as DomainResource).Extension
                        : default), kzzzw_);
                DataType kzzzy_(Extension @this)
                {
                    DataType lzzzu_ = @this?.Value;

                    return lzzzu_;
                };
                IEnumerable<DataType> kzzzz_ = context.Operators.Select<Extension, DataType>(kzzzx_, kzzzy_);
                DataType lzzza_ = context.Operators.SingletonFrom<DataType>(kzzzz_);
                CqlDateTime lzzzb_ = context.Operators.Convert<CqlDateTime>(lzzza_);
                Period lzzzc_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzd_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, lzzzc_);
                bool? lzzze_ = context.Operators.In<CqlDateTime>(lzzzb_, lzzzd_, default);
                Code<EventStatus> lzzzf_ = MedicationsNotDocumented?.StatusElement;
                EventStatus? lzzzg_ = lzzzf_?.Value;
                string lzzzh_ = context.Operators.Convert<string>(lzzzg_);
                bool? lzzzi_ = context.Operators.Equal(lzzzh_, "not-done");
                bool? lzzzj_ = context.Operators.And(lzzze_, lzzzi_);
                List<CodeableConcept> lzzzk_ = MedicationsNotDocumented?.ReasonCode;
                CqlConcept lzzzl_(CodeableConcept @this)
                {
                    CqlConcept lzzzv_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                    return lzzzv_;
                };
                IEnumerable<CqlConcept> lzzzm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)lzzzk_, lzzzl_);
                CqlValueSet lzzzn_ = this.Medical_Reason(context);
                bool? lzzzo_ = context.Operators.ConceptsInValueSet(lzzzm_, lzzzn_);
                bool? lzzzp_ = context.Operators.And(lzzzj_, lzzzo_);

                return lzzzp_;
            };
            IEnumerable<Procedure> kzzzt_ = context.Operators.Where<Procedure>(kzzzr_, kzzzs_);
            Encounter kzzzu_(Procedure MedicationsNotDocumented) =>
                QualifyingEncounter;
            IEnumerable<Encounter> kzzzv_ = context.Operators.Select<Procedure, Encounter>(kzzzt_, kzzzu_);

            return kzzzv_;
        };
        IEnumerable<Encounter> kzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzm_, kzzzn_);

        return kzzzo_;
    }


    #endregion Expressions

}

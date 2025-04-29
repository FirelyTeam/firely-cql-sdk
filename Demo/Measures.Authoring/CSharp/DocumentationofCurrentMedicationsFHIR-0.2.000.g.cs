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

    #region ValueSet: Encounter to Document Medications
    [CqlValueSetDefinition(
        definitionName: "Encounter to Document Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834",
        valueSetVersion: null)]
    public CqlValueSet Encounter_to_Document_Medications(CqlContext context) => _Encounter_to_Document_Medications;

    private static readonly CqlValueSet _Encounter_to_Document_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834", null);
    #endregion

    #region ValueSet: Medical Reason
    [CqlValueSetDefinition(
        definitionName: "Medical Reason",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007",
        valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext context) => _Medical_Reason;

    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Documentation of current medications (procedure)
    [CqlCodeDefinition(
        definitionName: "Documentation of current medications (procedure)",
        codeId: "428191000124101",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Documentation_of_current_medications__procedure_(CqlContext context) => _Documentation_of_current_medications__procedure_;

    private static readonly CqlCode _Documentation_of_current_medications__procedure_ = new CqlCode("428191000124101", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] jzzzj_ = [
            new CqlCode("428191000124101", "http://snomed.info/sct", default, default),
        ];

        return jzzzj_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime jzzzk_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime jzzzl_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> jzzzm_ = context.Operators.Interval(jzzzk_, jzzzl_, true, false);
        object jzzzn_ = context.ResolveParameter("DocumentationofCurrentMedicationsFHIR-0.2.000", "Measurement Period", jzzzm_);

        return (CqlInterval<CqlDateTime>)jzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient jzzzp_ = context.Operators.SingletonFrom<Patient>(jzzzo_);

        return jzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzq_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

        return jzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> jzzzr_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

        return jzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzs_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

        return jzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode jzzzt_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

        return jzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet jzzzu_ = this.Encounter_to_Document_Medications(context);
        IEnumerable<Encounter> jzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? jzzzw_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> jzzzy_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? jzzzz_ = jzzzy_?.Value;
            Code<Encounter.EncounterStatus> kzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jzzzz_);
            bool? kzzzb_ = context.Operators.Equal(kzzza_, "finished");
            CqlInterval<CqlDateTime> kzzzc_ = this.Measurement_Period(context);
            Period kzzzd_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> kzzze_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, kzzzd_);
            bool? kzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzc_, kzzze_, "day");
            bool? kzzzg_ = context.Operators.And(kzzzb_, kzzzf_);

            return kzzzg_;
        };
        IEnumerable<Encounter> jzzzx_ = context.Operators.Where<Encounter>(jzzzv_, jzzzw_);

        return jzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> kzzzh_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);

        return kzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> kzzzi_ = this.Initial_Population(context);

        return kzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> kzzzj_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        IEnumerable<Encounter> kzzzk_(Encounter QualifyingEncounter)
        {
            CqlCode kzzzm_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> kzzzn_ = context.Operators.ToList<CqlCode>(kzzzm_);
            IEnumerable<Procedure> kzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, kzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? kzzzp_(Procedure MedicationsDocumented)
            {
                DataType kzzzt_ = MedicationsDocumented?.Performed;
                object kzzzu_ = FHIRHelpers_4_3_000.Instance.ToValue(context, kzzzt_);
                CqlInterval<CqlDateTime> kzzzv_ = QICoreCommon_2_0_000.Instance.toInterval(context, kzzzu_);
                CqlDateTime kzzzw_ = context.Operators.End(kzzzv_);
                Period kzzzx_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzy_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, kzzzx_);
                bool? kzzzz_ = context.Operators.In<CqlDateTime>(kzzzw_, kzzzy_, default);
                Code<EventStatus> lzzza_ = MedicationsDocumented?.StatusElement;
                EventStatus? lzzzb_ = lzzza_?.Value;
                string lzzzc_ = context.Operators.Convert<string>(lzzzb_);
                bool? lzzzd_ = context.Operators.Equal(lzzzc_, "completed");
                bool? lzzze_ = context.Operators.And(kzzzz_, lzzzd_);

                return lzzze_;
            };
            IEnumerable<Procedure> kzzzq_ = context.Operators.Where<Procedure>(kzzzo_, kzzzp_);
            Encounter kzzzr_(Procedure MedicationsDocumented) =>
                QualifyingEncounter;
            IEnumerable<Encounter> kzzzs_ = context.Operators.Select<Procedure, Encounter>(kzzzq_, kzzzr_);

            return kzzzs_;
        };
        IEnumerable<Encounter> kzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzj_, kzzzk_);

        return kzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> lzzzf_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        IEnumerable<Encounter> lzzzg_(Encounter QualifyingEncounter)
        {
            CqlCode lzzzi_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> lzzzj_ = context.Operators.ToList<CqlCode>(lzzzi_);
            IEnumerable<Procedure> lzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, lzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
            bool? lzzzl_(Procedure MedicationsNotDocumented)
            {
                bool? lzzzp_(Extension @this)
                {
                    string mzzzj_ = @this?.Url;
                    FhirString mzzzk_ = context.Operators.Convert<FhirString>(mzzzj_);
                    string mzzzl_ = FHIRHelpers_4_3_000.Instance.ToString(context, mzzzk_);
                    bool? mzzzm_ = context.Operators.Equal(mzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return mzzzm_;
                };
                IEnumerable<Extension> lzzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationsNotDocumented is DomainResource
                        ? (MedicationsNotDocumented as DomainResource).Extension
                        : default), lzzzp_);
                DataType lzzzr_(Extension @this)
                {
                    DataType mzzzn_ = @this?.Value;

                    return mzzzn_;
                };
                IEnumerable<DataType> lzzzs_ = context.Operators.Select<Extension, DataType>(lzzzq_, lzzzr_);
                DataType lzzzt_ = context.Operators.SingletonFrom<DataType>(lzzzs_);
                CqlDateTime lzzzu_ = context.Operators.Convert<CqlDateTime>(lzzzt_);
                Period lzzzv_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzw_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, lzzzv_);
                bool? lzzzx_ = context.Operators.In<CqlDateTime>(lzzzu_, lzzzw_, default);
                Code<EventStatus> lzzzy_ = MedicationsNotDocumented?.StatusElement;
                EventStatus? lzzzz_ = lzzzy_?.Value;
                string mzzza_ = context.Operators.Convert<string>(lzzzz_);
                bool? mzzzb_ = context.Operators.Equal(mzzza_, "not-done");
                bool? mzzzc_ = context.Operators.And(lzzzx_, mzzzb_);
                List<CodeableConcept> mzzzd_ = MedicationsNotDocumented?.ReasonCode;
                CqlConcept mzzze_(CodeableConcept @this)
                {
                    CqlConcept mzzzo_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                    return mzzzo_;
                };
                IEnumerable<CqlConcept> mzzzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)mzzzd_, mzzze_);
                CqlValueSet mzzzg_ = this.Medical_Reason(context);
                bool? mzzzh_ = context.Operators.ConceptsInValueSet(mzzzf_, mzzzg_);
                bool? mzzzi_ = context.Operators.And(mzzzc_, mzzzh_);

                return mzzzi_;
            };
            IEnumerable<Procedure> lzzzm_ = context.Operators.Where<Procedure>(lzzzk_, lzzzl_);
            Encounter lzzzn_(Procedure MedicationsNotDocumented) =>
                QualifyingEncounter;
            IEnumerable<Encounter> lzzzo_ = context.Operators.Select<Procedure, Encounter>(lzzzm_, lzzzn_);

            return lzzzo_;
        };
        IEnumerable<Encounter> lzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzf_, lzzzg_);

        return lzzzh_;
    }


    #endregion Expressions

}

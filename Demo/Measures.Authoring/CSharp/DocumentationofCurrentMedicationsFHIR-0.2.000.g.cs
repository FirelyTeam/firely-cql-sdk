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
        CqlDateTime rzza_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime rzzb_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> rzzc_ = context.Operators.Interval(rzza_, rzzb_, true, false);
        object rzzd_ = context.ResolveParameter("DocumentationofCurrentMedicationsFHIR-0.2.000", "Measurement Period", rzzc_);

        return (CqlInterval<CqlDateTime>)rzzd_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient rzzf_ = context.Operators.SingletonFrom<Patient>(rzze_);

        return rzzf_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzg_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

        return rzzg_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> rzzh_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

        return rzzh_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzi_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

        return rzzi_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzj_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

        return rzzj_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet rzzk_ = this.Encounter_to_Document_Medications(context);
        IEnumerable<Encounter> rzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? rzzm_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> rzzo_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? rzzp_ = rzzo_?.Value;
            Code<Encounter.EncounterStatus> rzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzp_);
            bool? rzzr_ = context.Operators.Equal(rzzq_, "finished");
            CqlInterval<CqlDateTime> rzzs_ = this.Measurement_Period(context);
            Period rzzt_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> rzzu_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, rzzt_);
            bool? rzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzs_, rzzu_, "day");
            bool? rzzw_ = context.Operators.And(rzzr_, rzzv_);

            return rzzw_;
        };
        IEnumerable<Encounter> rzzn_ = context.Operators.Where<Encounter>(rzzl_, rzzm_);

        return rzzn_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> rzzx_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);

        return rzzx_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> rzzy_ = this.Initial_Population(context);

        return rzzy_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> rzzz_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        IEnumerable<Encounter> szza_(Encounter QualifyingEncounter)
        {
            CqlCode szzc_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> szzd_ = context.Operators.ToList<CqlCode>(szzc_);
            IEnumerable<Procedure> szze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, szzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? szzf_(Procedure MedicationsDocumented)
            {
                DataType szzj_ = MedicationsDocumented?.Performed;
                object szzk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szzj_);
                CqlInterval<CqlDateTime> szzl_ = QICoreCommon_2_0_000.Instance.toInterval(context, szzk_);
                CqlDateTime szzm_ = context.Operators.End(szzl_);
                Period szzn_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> szzo_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, szzn_);
                bool? szzp_ = context.Operators.In<CqlDateTime>(szzm_, szzo_, default);
                Code<EventStatus> szzq_ = MedicationsDocumented?.StatusElement;
                EventStatus? szzr_ = szzq_?.Value;
                string szzs_ = context.Operators.Convert<string>(szzr_);
                bool? szzt_ = context.Operators.Equal(szzs_, "completed");
                bool? szzu_ = context.Operators.And(szzp_, szzt_);

                return szzu_;
            };
            IEnumerable<Procedure> szzg_ = context.Operators.Where<Procedure>(szze_, szzf_);
            Encounter szzh_(Procedure MedicationsDocumented) =>
                QualifyingEncounter;
            IEnumerable<Encounter> szzi_ = context.Operators.Select<Procedure, Encounter>(szzg_, szzh_);

            return szzi_;
        };
        IEnumerable<Encounter> szzb_ = context.Operators.SelectMany<Encounter, Encounter>(rzzz_, szza_);

        return szzb_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> szzv_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        IEnumerable<Encounter> szzw_(Encounter QualifyingEncounter)
        {
            CqlCode szzy_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> szzz_ = context.Operators.ToList<CqlCode>(szzy_);
            IEnumerable<Procedure> tzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, szzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
            bool? tzzb_(Procedure MedicationsNotDocumented)
            {
                bool? tzzf_(Extension @this)
                {
                    string tzzz_ = @this?.Url;
                    FhirString uzza_ = context.Operators.Convert<FhirString>(tzzz_);
                    string uzzb_ = FHIRHelpers_4_3_000.Instance.ToString(context, uzza_);
                    bool? uzzc_ = context.Operators.Equal(uzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return uzzc_;
                };
                IEnumerable<Extension> tzzg_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationsNotDocumented is DomainResource
                        ? (MedicationsNotDocumented as DomainResource).Extension
                        : default), tzzf_);
                DataType tzzh_(Extension @this)
                {
                    DataType uzzd_ = @this?.Value;

                    return uzzd_;
                };
                IEnumerable<DataType> tzzi_ = context.Operators.Select<Extension, DataType>(tzzg_, tzzh_);
                DataType tzzj_ = context.Operators.SingletonFrom<DataType>(tzzi_);
                CqlDateTime tzzk_ = context.Operators.Convert<CqlDateTime>(tzzj_);
                Period tzzl_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> tzzm_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, tzzl_);
                bool? tzzn_ = context.Operators.In<CqlDateTime>(tzzk_, tzzm_, default);
                Code<EventStatus> tzzo_ = MedicationsNotDocumented?.StatusElement;
                EventStatus? tzzp_ = tzzo_?.Value;
                string tzzq_ = context.Operators.Convert<string>(tzzp_);
                bool? tzzr_ = context.Operators.Equal(tzzq_, "not-done");
                bool? tzzs_ = context.Operators.And(tzzn_, tzzr_);
                List<CodeableConcept> tzzt_ = MedicationsNotDocumented?.ReasonCode;
                CqlConcept tzzu_(CodeableConcept @this)
                {
                    CqlConcept uzze_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                    return uzze_;
                };
                IEnumerable<CqlConcept> tzzv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)tzzt_, tzzu_);
                CqlValueSet tzzw_ = this.Medical_Reason(context);
                bool? tzzx_ = context.Operators.ConceptsInValueSet(tzzv_, tzzw_);
                bool? tzzy_ = context.Operators.And(tzzs_, tzzx_);

                return tzzy_;
            };
            IEnumerable<Procedure> tzzc_ = context.Operators.Where<Procedure>(tzza_, tzzb_);
            Encounter tzzd_(Procedure MedicationsNotDocumented) =>
                QualifyingEncounter;
            IEnumerable<Encounter> tzze_ = context.Operators.Select<Procedure, Encounter>(tzzc_, tzzd_);

            return tzze_;
        };
        IEnumerable<Encounter> szzx_ = context.Operators.SelectMany<Encounter, Encounter>(szzv_, szzw_);

        return szzx_;
    }


    #endregion Expressions

}

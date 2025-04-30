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
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Documentation_of_current_medications__procedure_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime qzzz_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime rzza_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> rzzb_ = context.Operators.Interval(qzzz_, rzza_, true, false);
        object rzzc_ = context.ResolveParameter("DocumentationofCurrentMedicationsFHIR-0.2.000", "Measurement Period", rzzb_);

        return (CqlInterval<CqlDateTime>)rzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient rzze_ = context.Operators.SingletonFrom<Patient>(rzzd_);

        return rzze_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzf_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

        return rzzf_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> rzzg_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

        return rzzg_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzh_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

        return rzzh_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzi_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

        return rzzi_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet rzzj_ = this.Encounter_to_Document_Medications(context);
        IEnumerable<Encounter> rzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? rzzl_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> rzzn_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? rzzo_ = rzzn_?.Value;
            Code<Encounter.EncounterStatus> rzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzo_);
            bool? rzzq_ = context.Operators.Equal(rzzp_, "finished");
            CqlInterval<CqlDateTime> rzzr_ = this.Measurement_Period(context);
            Period rzzs_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> rzzt_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, rzzs_);
            bool? rzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzr_, rzzt_, "day");
            bool? rzzv_ = context.Operators.And(rzzq_, rzzu_);

            return rzzv_;
        };
        IEnumerable<Encounter> rzzm_ = context.Operators.Where<Encounter>(rzzk_, rzzl_);

        return rzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> rzzw_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);

        return rzzw_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> rzzx_ = this.Initial_Population(context);

        return rzzx_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> rzzy_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        IEnumerable<Encounter> rzzz_(Encounter QualifyingEncounter)
        {
            CqlCode szzb_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> szzc_ = context.Operators.ToList<CqlCode>(szzb_);
            IEnumerable<Procedure> szzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, szzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? szze_(Procedure MedicationsDocumented)
            {
                DataType szzi_ = MedicationsDocumented?.Performed;
                object szzj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, szzi_);
                CqlInterval<CqlDateTime> szzk_ = QICoreCommon_2_0_000.Instance.toInterval(context, szzj_);
                CqlDateTime szzl_ = context.Operators.End(szzk_);
                Period szzm_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> szzn_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, szzm_);
                bool? szzo_ = context.Operators.In<CqlDateTime>(szzl_, szzn_, default);
                Code<EventStatus> szzp_ = MedicationsDocumented?.StatusElement;
                EventStatus? szzq_ = szzp_?.Value;
                string szzr_ = context.Operators.Convert<string>(szzq_);
                bool? szzs_ = context.Operators.Equal(szzr_, "completed");
                bool? szzt_ = context.Operators.And(szzo_, szzs_);

                return szzt_;
            };
            IEnumerable<Procedure> szzf_ = context.Operators.Where<Procedure>(szzd_, szze_);
            Encounter szzg_(Procedure MedicationsDocumented) =>
                QualifyingEncounter;
            IEnumerable<Encounter> szzh_ = context.Operators.Select<Procedure, Encounter>(szzf_, szzg_);

            return szzh_;
        };
        IEnumerable<Encounter> szza_ = context.Operators.SelectMany<Encounter, Encounter>(rzzy_, rzzz_);

        return szza_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> szzu_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        IEnumerable<Encounter> szzv_(Encounter QualifyingEncounter)
        {
            CqlCode szzx_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> szzy_ = context.Operators.ToList<CqlCode>(szzx_);
            IEnumerable<Procedure> szzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, szzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
            bool? tzza_(Procedure MedicationsNotDocumented)
            {
                bool? tzze_(Extension @this)
                {
                    string tzzy_ = @this?.Url;
                    FhirString tzzz_ = context.Operators.Convert<FhirString>(tzzy_);
                    string uzza_ = FHIRHelpers_4_3_000.Instance.ToString(context, tzzz_);
                    bool? uzzb_ = context.Operators.Equal(uzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return uzzb_;
                };
                IEnumerable<Extension> tzzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationsNotDocumented is DomainResource
                        ? (MedicationsNotDocumented as DomainResource).Extension
                        : default), tzze_);
                DataType tzzg_(Extension @this)
                {
                    DataType uzzc_ = @this?.Value;

                    return uzzc_;
                };
                IEnumerable<DataType> tzzh_ = context.Operators.Select<Extension, DataType>(tzzf_, tzzg_);
                DataType tzzi_ = context.Operators.SingletonFrom<DataType>(tzzh_);
                CqlDateTime tzzj_ = context.Operators.Convert<CqlDateTime>(tzzi_);
                Period tzzk_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> tzzl_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, tzzk_);
                bool? tzzm_ = context.Operators.In<CqlDateTime>(tzzj_, tzzl_, default);
                Code<EventStatus> tzzn_ = MedicationsNotDocumented?.StatusElement;
                EventStatus? tzzo_ = tzzn_?.Value;
                string tzzp_ = context.Operators.Convert<string>(tzzo_);
                bool? tzzq_ = context.Operators.Equal(tzzp_, "not-done");
                bool? tzzr_ = context.Operators.And(tzzm_, tzzq_);
                List<CodeableConcept> tzzs_ = MedicationsNotDocumented?.ReasonCode;
                CqlConcept tzzt_(CodeableConcept @this)
                {
                    CqlConcept uzzd_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

                    return uzzd_;
                };
                IEnumerable<CqlConcept> tzzu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)tzzs_, tzzt_);
                CqlValueSet tzzv_ = this.Medical_Reason(context);
                bool? tzzw_ = context.Operators.ConceptsInValueSet(tzzu_, tzzv_);
                bool? tzzx_ = context.Operators.And(tzzr_, tzzw_);

                return tzzx_;
            };
            IEnumerable<Procedure> tzzb_ = context.Operators.Where<Procedure>(szzz_, tzza_);
            Encounter tzzc_(Procedure MedicationsNotDocumented) =>
                QualifyingEncounter;
            IEnumerable<Encounter> tzzd_ = context.Operators.Select<Procedure, Encounter>(tzzb_, tzzc_);

            return tzzd_;
        };
        IEnumerable<Encounter> szzw_ = context.Operators.SelectMany<Encounter, Encounter>(szzu_, szzv_);

        return szzw_;
    }


    #endregion Expressions

}

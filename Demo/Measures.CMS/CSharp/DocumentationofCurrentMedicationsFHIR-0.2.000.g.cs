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
        CqlDateTime qzzu_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime qzzv_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> qzzw_ = context.Operators.Interval(qzzu_, qzzv_, true, true);
        object qzzx_ = context.ResolveParameter("DocumentationofCurrentMedicationsFHIR-0.2.000", "Measurement Period", qzzw_);

        return (CqlInterval<CqlDateTime>)qzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzz_ = context.Operators.SingletonFrom<Patient>(qzzy_);

        return qzzz_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return rzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> rzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return rzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return rzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return rzzd_;
    }


    [CqlExpressionDefinition("Qualifying Encounter during day of Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_day_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet rzze_ = this.Encounter_to_Document_Medications(context);
        IEnumerable<Encounter> rzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? rzzg_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> rzzi_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? rzzj_ = rzzi_?.Value;
            Code<Encounter.EncounterStatus> rzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzj_);
            bool? rzzl_ = context.Operators.Equal(rzzk_, "finished");
            CqlInterval<CqlDateTime> rzzm_ = this.Measurement_Period(context);
            Period rzzn_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> rzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzn_);
            bool? rzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzm_, rzzo_, "day");
            bool? rzzq_ = context.Operators.And(rzzl_, rzzp_);

            return rzzq_;
        };
        IEnumerable<Encounter> rzzh_ = context.Operators.Where<Encounter>(rzzf_, rzzg_);

        return rzzh_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> rzzr_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);

        return rzzr_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> rzzs_ = this.Initial_Population(context);

        return rzzs_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> rzzt_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        IEnumerable<Encounter> rzzu_(Encounter QualifyingEncounter)
        {
            CqlCode rzzw_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> rzzx_ = context.Operators.ToList<CqlCode>(rzzw_);
            IEnumerable<Procedure> rzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, rzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? rzzz_(Procedure MedicationsDocumented)
            {
                DataType szzd_ = MedicationsDocumented?.Performed;
                object szze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzd_);
                CqlInterval<CqlDateTime> szzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, szze_);
                CqlDateTime szzg_ = context.Operators.End(szzf_);
                Period szzh_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> szzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzh_);
                bool? szzj_ = context.Operators.In<CqlDateTime>(szzg_, szzi_, default);
                Code<EventStatus> szzk_ = MedicationsDocumented?.StatusElement;
                EventStatus? szzl_ = szzk_?.Value;
                string szzm_ = context.Operators.Convert<string>(szzl_);
                bool? szzn_ = context.Operators.Equal(szzm_, "completed");
                bool? szzo_ = context.Operators.And(szzj_, szzn_);

                return szzo_;
            };
            IEnumerable<Procedure> szza_ = context.Operators.Where<Procedure>(rzzy_, rzzz_);
            Encounter szzb_(Procedure MedicationsDocumented) =>
                QualifyingEncounter;
            IEnumerable<Encounter> szzc_ = context.Operators.Select<Procedure, Encounter>(szza_, szzb_);

            return szzc_;
        };
        IEnumerable<Encounter> rzzv_ = context.Operators.SelectMany<Encounter, Encounter>(rzzt_, rzzu_);

        return rzzv_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> szzp_ = this.Qualifying_Encounter_during_day_of_Measurement_Period(context);
        IEnumerable<Encounter> szzq_(Encounter QualifyingEncounter)
        {
            CqlCode szzs_ = this.Documentation_of_current_medications__procedure_(context);
            IEnumerable<CqlCode> szzt_ = context.Operators.ToList<CqlCode>(szzs_);
            IEnumerable<Procedure> szzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, szzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
            bool? szzv_(Procedure MedicationsNotDocumented)
            {
                bool? szzz_(Extension @this)
                {
                    string tzzt_ = @this?.Url;
                    FhirString tzzu_ = context.Operators.Convert<FhirString>(tzzt_);
                    string tzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzu_);
                    bool? tzzw_ = context.Operators.Equal(tzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return tzzw_;
                };
                IEnumerable<Extension> tzza_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationsNotDocumented is DomainResource
                        ? (MedicationsNotDocumented as DomainResource).Extension
                        : default), szzz_);
                DataType tzzb_(Extension @this)
                {
                    DataType tzzx_ = @this?.Value;

                    return tzzx_;
                };
                IEnumerable<DataType> tzzc_ = context.Operators.Select<Extension, DataType>(tzza_, tzzb_);
                DataType tzzd_ = context.Operators.SingletonFrom<DataType>(tzzc_);
                CqlDateTime tzze_ = context.Operators.Convert<CqlDateTime>(tzzd_);
                Period tzzf_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> tzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzf_);
                bool? tzzh_ = context.Operators.In<CqlDateTime>(tzze_, tzzg_, default);
                Code<EventStatus> tzzi_ = MedicationsNotDocumented?.StatusElement;
                EventStatus? tzzj_ = tzzi_?.Value;
                string tzzk_ = context.Operators.Convert<string>(tzzj_);
                bool? tzzl_ = context.Operators.Equal(tzzk_, "not-done");
                bool? tzzm_ = context.Operators.And(tzzh_, tzzl_);
                List<CodeableConcept> tzzn_ = MedicationsNotDocumented?.ReasonCode;
                CqlConcept tzzo_(CodeableConcept @this)
                {
                    CqlConcept tzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return tzzy_;
                };
                IEnumerable<CqlConcept> tzzp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)tzzn_, tzzo_);
                CqlValueSet tzzq_ = this.Medical_Reason(context);
                bool? tzzr_ = context.Operators.ConceptsInValueSet(tzzp_, tzzq_);
                bool? tzzs_ = context.Operators.And(tzzm_, tzzr_);

                return tzzs_;
            };
            IEnumerable<Procedure> szzw_ = context.Operators.Where<Procedure>(szzu_, szzv_);
            Encounter szzx_(Procedure MedicationsNotDocumented) =>
                QualifyingEncounter;
            IEnumerable<Encounter> szzy_ = context.Operators.Select<Procedure, Encounter>(szzw_, szzx_);

            return szzy_;
        };
        IEnumerable<Encounter> szzr_ = context.Operators.SelectMany<Encounter, Encounter>(szzp_, szzq_);

        return szzr_;
    }


    #endregion Expressions

}

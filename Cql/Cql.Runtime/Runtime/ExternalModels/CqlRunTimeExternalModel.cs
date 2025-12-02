using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Runtime;


#region QDM bASE
// Common types used below — adjust to your Firely types if needed.
public class Identifier
{
    public string? System { get; set; }   // e.g., "http://hl7.org/fhir/sid/us-npi"
    public string? Value { get; set; }    // e.g., NPI, CCN, etc.
}

// ---------------------
// QDM Entity base class
// ---------------------
public abstract class QdmEntity
{
    /// <summary>
    /// QDM 'identifier' (Table 28) – generic identifier. 
    /// </summary>
    public Identifier? Identifier { get; set; }

    /// <summary>
    /// QDM 'id' – instance identifier.
    /// </summary>
    public string? Id { get; set; }
}

// ---------------------
// QDM Entities (Table 28)
// ---------------------

/// <summary>
/// Patient entity – an individual receiving healthcare services.
/// Attributes: identifier, id. :contentReference[oaicite:2]{index=2}
/// </summary>
public sealed class QdmPatientEntity : QdmEntity
{
    // No extra attributes in QDM 5.6 beyond Identifier + Id
}

/// <summary>
/// Care Partner – person related to care, not the direct target of care.
/// Attributes: identifier, id, relationship. :contentReference[oaicite:3]{index=3}
public sealed class QdmCarePartnerEntity : QdmEntity
{
    /// <summary>
    /// relationship (Code) – relationship to the patient (e.g., family member).
    /// </summary>
    public CqlCode? Relationship { get; set; }
}

/// <summary>
/// Practitioner – person with formal responsibility to provide care.
/// Attributes: identifier, id, role, specialty, qualification. :contentReference[oaicite:4]{index=4}
public sealed class QdmPractitionerEntity : QdmEntity
{
    /// <summary>
    /// role (Code) – role this practitioner may perform (e.g. physician, nurse).
    /// </summary>
    public CqlCode? Role { get; set; }

    /// <summary>
    /// specialty (Code) – specific specialty (e.g. anesthesia, cardiology).
    /// </summary>
    public CqlCode? Specialty { get; set; }

    /// <summary>
    /// qualification (Code) – certification / license / training (e.g. MD, CNE). 
    /// </summary>
    public CqlCode? Qualification { get; set; }
}

/// <summary>
/// Organization – grouping of people or orgs with a common purpose.
/// Attributes: identifier, id, organizationType. :contentReference[oaicite:5]{index=5}
public sealed class QdmOrganizationEntity : QdmEntity
{
    /// <summary>
    /// organizationType (Code) – kind of organization (e.g. hospital).
    /// </summary>
    public CqlCode? OrganizationType { get; set; }
}

/// <summary>
/// Location – physical place where services/resources are provided.
/// Attributes: identifier, id, locationType. :contentReference[oaicite:6]{index=6}
public sealed class QdmLocationEntity : QdmEntity
{
    /// <summary>
    /// locationType (Code) – role type based on function (e.g. ED, ICU).
    /// </summary>
    public CqlCode? LocationType { get; set; }
}


#endregion

#region CMS 69 Model
//public abstract class QdmBase
//{
//    public string? Id { get; set; }
//}
//public class PositiveEncounterPerformed
//{
//    // QDM v5.6 attributes:
//    public string? Id { get; set; }
//    public CqlDateTime? RelevantDateTime { get; set; }
//    public CqlInterval<CqlDateTime>? RelevantPeriod { get; set; }
//    public CqlCode? Code { get; set; }
//    public CqlConcept? FacilityLocation { get; set; }
//    // etc. – all QDM attributes you need
//}

#region Encounter
public sealed class PositiveEncounterPerformed : ICoded
{
    // Core identifiers
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }

    // Timing
    public CqlInterval<CqlDateTime>? RelevantPeriod { get; set; }   // admission → discharge
    public CqlDateTime? AuthorDateTime { get; set; }

    // Encounter classification
    public CqlConcept? AdmissionSource { get; set; }
    public CqlConcept? Class { get; set; }                // inpatient, outpatient, telehealth, etc.
    public CqlConcept? DischargeDisposition { get; set; }
    public CqlQuantity? LengthOfStay { get; set; }        // e.g. days

    // Diagnoses (3-component structure per QDM)
    public List<EncounterDiagnosisComponent> Diagnoses { get; set; } = new();

    // Facility locations (0..*)
    public List<FacilityLocationComponent> FacilityLocations { get; set; } = new();

    // Priority
    public CqlConcept? Priority { get; set; }

    // Participant (actor – practitioner/org/location)

    /// <summary>
    /// QDM participant attribute. Cardinality 0..* for Encounter, Performed.
    /// Each entry is one QDM entity (Patient, Care Partner, Practitioner, Organization, or Location). :contentReference[oaicite:7]{index=7}
    /// </summary>
    public List<QdmEntity> Participant { get; set; } = new();

    // Relationships to other QDM elements
    public List<string>? RelatedTo { get; set; }          // ids of related QDM elements

    public IReadOnlyCollection<Coding> ToCodings()
    {
        // No code -> nothing to filter on
        if (Code == null)
            return Array.Empty<Coding>();

        // Map QDM CqlCode → FHIR Coding
        var coding = new Coding(
            system: Code?.system,   // adjust names if your CqlCode differs
            code: Code?.code,
            display: Code?.display)
        {
            Version = Code?.version
        };

        return new[] { coding };
    }
}

public sealed class EncounterDiagnosisComponent
{
    public CqlCode? Diagnosis { get; set; }
    public CqlCode? PresentOnAdmissionIndicator { get; set; }
    public int? Rank { get; set; }                        // principal diagnosis = 1
}

public sealed class FacilityLocationComponent
{
    public CqlConcept? Code { get; set; }                 // ICU, MedSurg, etc.
    public CqlInterval<CqlDateTime>? LocationPeriod { get; set; }
}


#endregion
public class EncounterPerformed //: QdmBase
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
    public CqlInterval<CqlDateTime>? RelevantPeriod { get; set; }
    public IList<FacilityLocation>? FacilityLocations { get; set; }
    public CqlConcept? DischargeDisposition { get; set; }
    // Add more encounter attributes as needed (principal diagnosis, etc.)
}

//public class PositiveEncounterPerformed : EncounterPerformed
//{
//    // Positive = event occurred, no negationRationale
//}

public class FacilityLocation
{
    /// <summary>
    /// Code for the facility location (e.g., ED, ICU, Med/Surg).
    /// </summary>
    public CqlConcept? Code { get; set; }

    /// <summary>
    /// Time interval the patient was in that location.
    /// </summary>
    public CqlInterval<CqlDateTime>? LocationPeriod { get; set; }
}

public class PatientDetails //: QdmBase
{
    public string? Id { get; set; }
    public CqlDateTime? BirthDatetime { get; set; }
    public CqlConcept? Gender { get; set; }
    // Add race/ethnicity/other attributes here if needed, or keep them in separate PatientCharacteristic* types
}

#region Assessment

public class PositiveAssessmentPerformed : ICoded
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
    public CqlInterval<CqlDateTime>? RelevantPeriod { get; set; }
    public CqlQuantity? Result { get; set; }
    public CqlConcept? Interpretation { get; set; }
    public IReadOnlyCollection<Coding> ToCodings()
    {
        // No code -> nothing to filter on
        if (Code == null)
            return Array.Empty<Coding>();

        // Map QDM CqlCode → FHIR Coding
        var coding = new Coding(
            system: Code?.system,   // adjust names if your CqlCode differs
            code: Code?.code,
            display: Code?.display)
        {
            Version = Code?.version
        };

        return new[] { coding };
    }
}

#endregion

#region Diagnosis

public class Diagnosis : ICoded
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
    public CqlInterval<CqlDateTime>? PrevalencePeriod { get; set; }
    public CqlConcept? Rank { get; set; }
    // Add presentOnAdmissionIndicator, etc. if needed

    public IReadOnlyCollection<Coding> ToCodings()
    {
        // No code -> nothing to filter on
        if (Code == null)
            return Array.Empty<Coding>();

        // Map QDM CqlCode → FHIR Coding
        var coding = new Coding(
            system: Code?.system,   // adjust names if your CqlCode differs
            code: Code?.code,
            display: Code?.display)
        {
            Version = Code?.version
        };

        return new[] { coding };
    }
}

#endregion

#region Intervention

public class PositiveInterventionOrder : ICoded
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
    public CqlDateTime? AuthorDatetime { get; set; }
    public CqlConcept? Reason { get; set; }
    public IReadOnlyCollection<Coding> ToCodings()
    {
        // No code -> nothing to filter on
        if (Code == null)
            return Array.Empty<Coding>();

        // Map QDM CqlCode → FHIR Coding
        var coding = new Coding(
            system: Code?.system,   // adjust names if your CqlCode differs
            code: Code?.code,
            display: Code?.display)
        {
            Version = Code?.version
        };

        return new[] { coding };
    }
}

public class PositiveInterventionPerformed : ICoded
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
    public CqlInterval<CqlDateTime>? RelevantPeriod { get; set; }
    public CqlConcept? Reason { get; set; }
    public IReadOnlyCollection<Coding> ToCodings()
    {
        // No code -> nothing to filter on
        if (Code == null)
            return Array.Empty<Coding>();

        // Map QDM CqlCode → FHIR Coding
        var coding = new Coding(
            system: Code?.system,   // adjust names if your CqlCode differs
            code: Code?.code,
            display: Code?.display)
        {
            Version = Code?.version
        };

        return new[] { coding };
    }
}

public class NegativeInterventionOrder : ICoded
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
    public CqlDateTime? AuthorDatetime { get; set; }
    public CqlConcept? NegationRationale { get; set; }
    public IReadOnlyCollection<Coding> ToCodings()
    {
        // No code -> nothing to filter on
        if (Code == null)
            return Array.Empty<Coding>();

        // Map QDM CqlCode → FHIR Coding
        var coding = new Coding(
            system: Code?.system,   // adjust names if your CqlCode differs
            code: Code?.code,
            display: Code?.display)
        {
            Version = Code?.version
        };

        return new[] { coding };
    }
}

public class NegativeInterventionPerformed : ICoded//self
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
    public CqlInterval<CqlDateTime>? RelevantPeriod { get; set; }
    public CqlConcept? NegationRationale { get; set; }
    public IReadOnlyCollection<Coding> ToCodings()
    {
        // No code -> nothing to filter on
        if (Code == null)
            return Array.Empty<Coding>();

        // Map QDM CqlCode → FHIR Coding
        var coding = new Coding(
            system: Code?.system,   // adjust names if your CqlCode differs
            code: Code?.code,
            display: Code?.display)
        {
            Version = Code?.version
        };

        return new[] { coding };
    }
}

#endregion

#region Medication

public class PositiveMedicationOrder : ICoded//self
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }                // Medication code
    public CqlQuantity? Dose { get; set; }
    public CqlInterval<CqlDateTime>? RelevantPeriod { get; set; } // order validity
    public CqlConcept? Reason { get; set; }
    public IReadOnlyCollection<Coding> ToCodings()
    {
        // No code -> nothing to filter on
        if (Code == null)
            return Array.Empty<Coding>();

        // Map QDM CqlCode → FHIR Coding
        var coding = new Coding(
            system: Code?.system,   // adjust names if your CqlCode differs
            code: Code?.code,
            display: Code?.display)
        {
            Version = Code?.version
        };

        return new[] { coding };
    }
}

public class NegativeMedicationOrder : ICoded//self
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
    public CqlQuantity? Dose { get; set; }
    public CqlInterval<CqlDateTime>? RelevantPeriod { get; set; }
    public CqlConcept? NegationRationale { get; set; }
    public IReadOnlyCollection<Coding> ToCodings()
    {
        // No code -> nothing to filter on
        if (Code == null)
            return Array.Empty<Coding>();

        // Map QDM CqlCode → FHIR Coding
        var coding = new Coding(
            system: Code?.system,   // adjust names if your CqlCode differs
            code: Code?.code,
            display: Code?.display)
        {
            Version = Code?.version
        };

        return new[] { coding };
    }
}

#endregion

#region Physical Exam

public class PositivePhysicalExamPerformed : ICoded
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
    public CqlInterval<CqlDateTime>? RelevantPeriod { get; set; }
    public CqlQuantity? Result { get; set; }
    public CqlConcept? Interpretation { get; set; }
    public IReadOnlyCollection<Coding> ToCodings()
    {
        // No code -> nothing to filter on
        if (Code == null)
            return Array.Empty<Coding>();

        // Map QDM CqlCode → FHIR Coding
        var coding = new Coding(
            system: Code?.system,   // adjust names if your CqlCode differs
            code: Code?.code,
            display: Code?.display)
        {
            Version = Code?.version
        };

        return new[] { coding };
    }
}

public class NegativePhysicalExamPerformed : ICoded//self
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
    public CqlInterval<CqlDateTime>? RelevantPeriod { get; set; }
    public CqlConcept? NegationRationale { get; set; }

    public IReadOnlyCollection<Coding> ToCodings()
    {
        // No code -> nothing to filter on
        if (Code == null)
            return Array.Empty<Coding>();

        // Map QDM CqlCode → FHIR Coding
        var coding = new Coding(
            system: Code?.system,   // adjust names if your CqlCode differs
            code: Code?.code,
            display: Code?.display)
        {
            Version = Code?.version
        };

        return new[] { coding };
    }
}

#endregion

#region Procedures

public class PositiveProcedurePerformed : ICoded//self
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
    public CqlInterval<CqlDateTime>? RelevantPeriod { get; set; }
    public CqlConcept? Reason { get; set; }

    public IReadOnlyCollection<Coding> ToCodings()
    {
        // No code -> nothing to filter on
        if (Code == null)
            return Array.Empty<Coding>();

        // Map QDM CqlCode → FHIR Coding
        var coding = new Coding(
            system: Code?.system,   // adjust names if your CqlCode differs
            code: Code?.code,
            display: Code?.display)
        {
            Version = Code?.version
        };

        return new[] { coding };
    }
}

public class NegativeProcedurePerformed : ICoded//self
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
    public CqlInterval<CqlDateTime>? RelevantPeriod { get; set; }
    public CqlConcept? NegationRationale { get; set; }

    public IReadOnlyCollection<Coding> ToCodings()
    {
        // No code -> nothing to filter on
        if (Code == null)
            return Array.Empty<Coding>();

        // Map QDM CqlCode → FHIR Coding
        var coding = new Coding(
            system: Code?.system,   // adjust names if your CqlCode differs
            code: Code?.code,
            display: Code?.display)
        {
            Version = Code?.version
        };

        return new[] { coding };
    }
}

#endregion

#region Patient characteristics

public class PatientCharacteristicEthnicity
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
}

public class PatientCharacteristicRace
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
}

public class PatientCharacteristicSex 
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
}

public class PatientCharacteristicPayer
{
    public string? Id { get; set; }
    public CqlCode? Code { get; set; }
    public CqlInterval<CqlDateTime>? RelevantPeriod { get; set; }
}

#endregion

#endregion

/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Fhir.Model;
using Task = Hl7.Fhir.Model.Task;

namespace Hl7.Cql.Fhir
{
    /// <summary>
    /// Constrains the instances returned by a retrieve based on the profile (template id)
    /// the retrieve was declared against.
    /// </summary>
    /// <remarks>
    /// Profile-informed ELM carries the profile's canonical url in the retrieve's
    /// <c>templateId</c>. Some profiles - notably the QICore negation profiles - fix a
    /// discriminating element (e.g. <c>ServiceRequest.doNotPerform = true</c>), and a
    /// conformant retrieve must only return instances that satisfy it.
    /// </remarks>
    public interface IRetrieveProfileFilter
    {
        /// <summary>
        /// Returns a predicate that an instance must satisfy to be returned by a retrieve
        /// declared against the given profile, or <see langword="null"/> when no
        /// constraints are known for the profile (the retrieve remains unfiltered).
        /// </summary>
        Predicate<Resource>? GetFilter(string templateId);
    }

    /// <summary>
    /// A <see cref="IRetrieveProfileFilter"/> for the QICore negation profiles and their
    /// positive counterparts, based on the discriminating element each profile fixes.
    /// </summary>
    /// <remarks>
    /// <para>
    /// <b>Derived from QICore 6.0.0.</b> The profile canonical urls and the discriminating
    /// elements below are hardcoded from that version of the QICore implementation guide
    /// (<see href="http://hl7.org/fhir/us/qicore/STU6/">QICore STU6</see>). They are <b>not</b> read from the
    /// profile definitions at runtime, so this table must be revisited and kept in sync
    /// whenever the SDK targets a new version of QICore: profiles may be added, renamed, or
    /// change the element (or fixed value) they constrain. See <see cref="FiltersByProfile"/>.
    /// </para>
    /// <para>
    /// Only the data of the instance is inspected; declared profiles (<c>meta.profile</c>)
    /// play no role. An instance whose declared profile contradicts its data (e.g. an
    /// instance declaring <c>servicenotrequested</c> while carrying
    /// <c>doNotPerform = false</c>) is treated according to its data.
    /// </para>
    /// </remarks>
    public class QICoreRetrieveProfileFilter : IRetrieveProfileFilter
    {
        /// <summary>
        /// The default instance.
        /// </summary>
        public static readonly QICoreRetrieveProfileFilter Default = new();

        private const string QICore = "http://hl7.org/fhir/us/qicore/StructureDefinition/";

        // Hardcoded from QICore 6.0.0 (http://hl7.org/fhir/us/qicore/STU6/). Keep this table in
        // sync when the SDK targets a new QICore version - profiles and the elements they
        // constrain can change between releases.
        private static readonly IReadOnlyDictionary<string, Predicate<Resource>> FiltersByProfile =
            new Dictionary<string, Predicate<Resource>>
            {
                // Negation profiles: require the fixed discriminator.
                [QICore + "qicore-servicenotrequested"] = r => r is ServiceRequest { DoNotPerform: true },
                [QICore + "qicore-medicationnotrequested"] = r => r is MedicationRequest { DoNotPerform: true },
                [QICore + "qicore-procedurenotdone"] = r => r is Procedure { Status: EventStatus.NotDone },
                [QICore + "qicore-observationcancelled"] = r => r is Observation { Status: ObservationStatus.Cancelled },
                [QICore + "qicore-medicationadministrationnotdone"] = r => r is MedicationAdministration { Status: MedicationAdministration.MedicationAdministrationStatusCodes.NotDone },
                [QICore + "qicore-communicationnotdone"] = r => r is Communication { Status: EventStatus.NotDone },
                [QICore + "qicore-taskrejected"] = r => r is Task { Status: Task.TaskStatus.Rejected },

                // Positive counterparts: exclude instances in the negated state.
                [QICore + "qicore-servicerequest"] = r => r is not ServiceRequest { DoNotPerform: true },
                [QICore + "qicore-medicationrequest"] = r => r is not MedicationRequest { DoNotPerform: true },
                [QICore + "qicore-procedure"] = r => r is not Procedure { Status: EventStatus.NotDone },
                [QICore + "qicore-observation-screening-assessment"] = r => r is not Observation { Status: ObservationStatus.Cancelled },
                [QICore + "qicore-observation-lab"] = r => r is not Observation { Status: ObservationStatus.Cancelled },
                [QICore + "qicore-observation-clinical-result"] = r => r is not Observation { Status: ObservationStatus.Cancelled },
                [QICore + "qicore-simple-observation"] = r => r is not Observation { Status: ObservationStatus.Cancelled },
                [QICore + "qicore-medicationadministration"] = r => r is not MedicationAdministration { Status: MedicationAdministration.MedicationAdministrationStatusCodes.NotDone },
                [QICore + "qicore-communication"] = r => r is not Communication { Status: EventStatus.NotDone },
                [QICore + "qicore-task"] = r => r is not Task { Status: Task.TaskStatus.Rejected },
            };

        /// <inheritdoc/>
        public Predicate<Resource>? GetFilter(string templateId) =>
            FiltersByProfile.TryGetValue(templateId, out var filter) ? filter : null;
    }
}

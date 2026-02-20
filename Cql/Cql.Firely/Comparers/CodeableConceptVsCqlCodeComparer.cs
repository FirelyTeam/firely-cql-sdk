/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Exceptions;
using Hl7.Cql.Comparers;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir.Comparers;

/// <summary>
/// This comparer enabled comparison between <see cref="CodeableConcept"/> and <see cref="CqlCode"/>,
/// by comparing the latter to the single <see cref="CodeableConcept.Coding"/>.
/// </summary>
/// <remarks>
/// This comparer must be registered against <see cref="CodeableConcept"/>.
/// </remarks>
internal class CodeableConceptVsCqlCodeComparer() : CqlComparerWrapper<object /*CodeableConcept or CqlCode*/, CqlCode>(
    CqlCodeCqlComparer.OrdinalIgnoreCase,
    outer => outer switch
    {
        CodeableConcept { Coding: [{ } coding] } => new CqlCode(coding.Code, coding.System, coding.Version, coding.Display),
        CqlCode c                                => c,
        _                                        => throw new CouldNotConvertInstanceToTargetType(outer, typeof(CqlCode)).ToException(),
    });
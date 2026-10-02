/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Packaging.Toolkit;

/// <summary>
/// Controls how the ELM JSON embedded as the <c>application/elm+json</c> attachment of a packaged
/// FHIR <c>Library</c> is formatted.
/// </summary>
/// <remarks>
/// <para>
/// All three values affect whitespace only. Where the library was read from a file its JSON is reused,
/// reformatted a token at a time where that is needed, so none of them walks the ELM object graph. A
/// library built in memory has no source JSON, and is serialized with the requested indentation.
/// </para>
/// <para>
/// Reused JSON is not identical to what serializing the graph produces: it keeps empty collections such
/// as <c>annotation</c> and <c>signature</c> that serialization omits, and it lacks what serialization
/// adds — <c>accessLevel</c> written out explicitly, and <c>resultTypeSpecifier</c> synthesised from a
/// legacy <c>type</c> discriminator. Readers that parse the attachment through this SDK apply those same
/// corrections on load, so the parsed result is equivalent either way.
/// </para>
/// </remarks>
public enum ElmAttachmentFormatting
{
    /// <summary>
    /// Embed the ELM JSON exactly as it was read, without reformatting it at all. This is the cheapest
    /// option and makes the attachment byte-identical to the source file.
    /// </summary>
    Passthrough,

    /// <summary>
    /// Format the ELM JSON with indentation and line breaks.
    /// </summary>
    Indented,

    /// <summary>
    /// Format the ELM JSON without indentation, producing a smaller attachment.
    /// </summary>
    Compact,
}

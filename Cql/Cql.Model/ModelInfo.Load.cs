/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Model
{
    public partial class ModelInfo
    {
        /// <summary>
        /// Reads a model info from its XML form (namespace <c>urn:hl7-org:elm-modelinfo:r1</c>), as published
        /// with a FHIR implementation guide or by the reference CQL tooling.
        /// </summary>
        /// <param name="stream">The stream holding the model info XML; it is read but not closed.</param>
        /// <returns>The model info, ready to pass to the CQL-to-ELM toolkit configuration.</returns>
        /// <exception cref="InvalidOperationException">The stream does not hold well-formed model info XML.</exception>
        /// <exception cref="ArgumentException">The XML is not a model info.</exception>
        public static ModelInfo LoadFromStream(System.IO.Stream stream)
        {
            if (stream is null)
                throw new ArgumentNullException(nameof(stream));
            return Models.LoadFromStream(stream);
        }

        /// <summary>
        /// Reads a model info from an XML file (namespace <c>urn:hl7-org:elm-modelinfo:r1</c>), as published
        /// with a FHIR implementation guide or by the reference CQL tooling.
        /// </summary>
        /// <param name="path">The path of the model info XML file, relative to the current directory or absolute.</param>
        /// <returns>The model info, ready to pass to the CQL-to-ELM toolkit configuration.</returns>
        /// <exception cref="System.IO.IOException">The file cannot be opened.</exception>
        /// <exception cref="UnauthorizedAccessException">The file cannot be read with the current permissions.</exception>
        /// <exception cref="InvalidOperationException">The file does not hold well-formed model info XML.</exception>
        /// <exception cref="ArgumentException">The XML is not a model info.</exception>
        public static ModelInfo LoadFromFile(string path)
        {
            if (path is null)
                throw new ArgumentNullException(nameof(path));
            using var stream = System.IO.File.OpenRead(path);
            return LoadFromStream(stream);
        }
    }
}

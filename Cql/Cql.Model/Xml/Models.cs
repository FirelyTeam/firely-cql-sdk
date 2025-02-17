#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Hl7.Cql.Model.Xml
{
    internal static class Models
    {
        private static readonly XmlSerializer xmlSerializer = new(typeof(ModelInfo));
        private static readonly Lazy<ModelInfo> _Fhir401 = new(() => LoadEmbeddedResource("Fhir401"), true);
        private static readonly Lazy<ModelInfo> _ElmR1 = new(() => LoadEmbeddedResource("ElmR1"), true);
        private static readonly Lazy<ModelInfo> _QICore411 = new(() => LoadEmbeddedResource("QICore411"), true);

        public static ModelInfo Fhir401 => _Fhir401.Value;
        public static ModelInfo ElmR1 => _ElmR1.Value;
        public static ModelInfo QICore411 => _QICore411.Value;
        public static StreamReader System200 => GetStream("System200");
        /// <summary>
        /// Maps models by their names.  Versions are not considered.
        /// </summary>
        public static IReadOnlyDictionary<string, object> All => new Dictionary<string, object>
        {
            { Fhir401.name, Fhir401 },
            { ElmR1.name, ElmR1 },
            { QICore411.name, QICore411 },
            { "System200", System200  }
        };
        public static ModelInfo LoadFromStream(System.IO.Stream stream)
        {
            return xmlSerializer.Deserialize(stream) as ModelInfo
                ?? throw new ArgumentException($"This resource is not a valid {nameof(ModelInfo)}");
        }

        private static StreamReader GetStream(string resourceName)
        {
            var stream = typeof(Models).Assembly.GetManifestResourceStream(resourceName)
                ?? throw new ArgumentException($"Manifest resource stream {resourceName} is not included in this assembly.");
            return new StreamReader(stream);
        }

        private static ModelInfo LoadEmbeddedResource(string resourceName)
        {
            var stream = typeof(Models).Assembly.GetManifestResourceStream(resourceName)
                ?? throw new ArgumentException($"Manifest resource stream {resourceName} is not included in this assembly.");
            return LoadFromStream(stream);
        }
    }
}

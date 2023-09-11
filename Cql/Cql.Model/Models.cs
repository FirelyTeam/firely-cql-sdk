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
using System.Linq;
using System.Xml.Serialization;

namespace Hl7.Cql.Model
{
    internal static class Models
    {
        private static readonly XmlSerializer xmlSerializer = new(typeof(ModelInfo));
        private static readonly Lazy<ModelInfo> _Fhir401 = new(() => LoadEmbeddedResource("Fhir401"), true);

        public static ModelInfo Fhir401 => _Fhir401.Value;

        public static IDictionary<string, ClassInfo> ClassesById(ModelInfo model)
        {
            var baseUrl = model.url;
            var result = model.typeInfo.OfType<ClassInfo>()
                .ToDictionary(classInfo => $"{{{baseUrl}}}{classInfo.name}");
            return result;
        }

        public static ModelInfo LoadFromStream(System.IO.Stream stream)
        {
            return xmlSerializer.Deserialize(stream) as ModelInfo
                ?? throw new ArgumentException($"This resource is not a valid {nameof(ModelInfo)}");
        }

        private static ModelInfo LoadEmbeddedResource(string resourceName)
        {
            var stream = typeof(Models).Assembly.GetManifestResourceStream(resourceName)
                ?? throw new ArgumentException($"Manifest resource stream {resourceName} is not included in this assembly.");
            return LoadFromStream(stream);
        }
    }
}

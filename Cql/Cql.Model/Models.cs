#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Model
{
    internal static class Models
    {
        private static readonly XmlSerializer xmlSerializer = new(typeof(ModelInfo));
        private static readonly Lazy<ModelInfo> _Fhir401 = new(() => LoadEmbeddedResource("Fhir401"), true);
        private static readonly Lazy<ModelInfo> _ElmR1 = new(() => LoadEmbeddedResource("ElmR1"), true);
        private static readonly Lazy<ModelInfo> _USCore311 = new(() => LoadEmbeddedResource("USCore311"), true);
        private static readonly Lazy<ModelInfo> _QICore411 = new(() => LoadEmbeddedResource("QICore411"), true);
        private static readonly Lazy<ModelInfo> _USCore610 = new(() => LoadEmbeddedResource("USCore610"), true);
        private static readonly Lazy<ModelInfo> _QICore600 = new(() => LoadEmbeddedResource("QICore600"), true);

        public static ModelInfo Fhir401 => _Fhir401.Value;
        public static ModelInfo ElmR1 => _ElmR1.Value;
        public static ModelInfo USCore311 => _USCore311.Value;
        public static ModelInfo QICore411 => _QICore411.Value;
        public static ModelInfo USCore610 => _USCore610.Value;
        public static ModelInfo QICore600 => _QICore600.Value;

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

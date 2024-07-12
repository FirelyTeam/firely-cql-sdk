using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;
using ModelInfo = Hl7.Cql.Model.ModelInfo;

namespace Hl7.Cql.CqlToElm.Builtin
{
    internal class BuiltinModelProvider : IModelProvider
    {
        public BuiltinModelProvider(params ModelInfo[] models)
        {
            foreach (var model in models)
                Add(model);
        }

        private Dictionary<string, Dictionary<string, ModelInfo>> ModelsByUriAndVersion { get; } = new();

        private Dictionary<string, Dictionary<string, string>> ConversionFunctions { get; } = new();

        // TODO: test with multiple versions of the same model; maybe don't support that
        public IEnumerable<TypeInfo> AllTypes => ModelsByUriAndVersion.Values
            .SelectMany(versions => versions.Values
                .SelectMany(model => model.typeInfo));

        public IModelProvider Add(ModelInfo model)
        {
            if (model.requiredModelInfo is not null)
                CheckRequiredModels(model.name, model.requiredModelInfo);

            if (!ModelsByUriAndVersion.TryGetValue(model.url, out var modelsByVersion))
            {
                modelsByVersion = new Dictionary<string, ModelInfo>();
                ModelsByUriAndVersion.Add(model.url, modelsByVersion);
            }
            modelsByVersion!.Add(model.version, model);
            foreach(var conversionInfo in model.conversionInfo ?? Enumerable.Empty<ConversionInfo>())
            {
                var fromTypes = Enumerable.Empty<TypeInfo>();
                if (model.TryGetTypeInfoFor(conversionInfo.fromType, out var fromType)
                    && fromType is ClassInfo fromClass)
                {
                    // FHIR has simple types like Quantity which have derived types like Age.
                    // There is a conversion from FHIR.Quantity to System.Quantity,
                    // but none for Age.  Nevertheless, the conversion should be called.
                    fromTypes = new[] { fromType };
                    var derived = this.FindDerivedTypes(fromClass).ToArray();
                    if (derived.Length > 0)
                    {
                        fromTypes = fromTypes.Concat(derived);
                    }
                }

                foreach (var ft in fromTypes.OfType<ClassInfo>())
                {
                    var qualified = $"{ft.@namespace}.{ft.name}";
                    if (!ConversionFunctions.TryGetValue(qualified, out var toFunctions))
                    {
                        toFunctions = new();
                        ConversionFunctions.Add(qualified, toFunctions);
                    }
                    if (!toFunctions.ContainsKey(conversionInfo.toType))
                    {
                        toFunctions.Add(conversionInfo.toType, conversionInfo.functionName);
                    }
                    else throw new InvalidOperationException($"The conversion from {conversionInfo.fromType} to {conversionInfo.toType} is already defined by {conversionInfo.functionName}");
                }
            }
            return this;
        }

        private void CheckRequiredModels(string name, Model.ModelSpecifier[] requiredModelInfo)
        {
            foreach (var requiredModel in requiredModelInfo)
            {
                if (!TryGetModelFromName(requiredModel.name, out var _, requiredModel.version))
                    throw new ArgumentException($"Model {name} depends on model {requiredModel.name} which has not yet been added to the provider.");
            }
        }

        public bool TryGetModelFromUri(string uri, [NotNullWhen(true)] out ModelInfo? model, string? version = null)
        {
            if (ModelsByUriAndVersion.TryGetValue(uri, out var modelsByVersion))
            {
                if (!string.IsNullOrWhiteSpace(version))
                {
                    return modelsByVersion!.TryGetValue(version, out model);
                }
                else if (modelsByVersion.Count == 1)
                {
                    model = modelsByVersion.Values.Single();
                    return true;
                }
                else
                    throw new ArgumentException($"More than one version of model {uri} is available.  In this case, {nameof(version)} must be specified.", nameof(version));
            }

            model = null;
            return false;
        }

        public bool TryGetModelFromName(string name, [NotNullWhen(true)] out ModelInfo? model, string? version = null)
        {
            var models = ModelsByUriAndVersion.Values.SelectMany(dict => dict.Values);
            var eligibleModels = models
                .Where(m => m.name == name)
                .Where(m => string.IsNullOrEmpty(version) || m.version == version).ToList();

            if (eligibleModels.Count > 1)
            {
                if (string.IsNullOrWhiteSpace(version))
                    throw new ArgumentException($"More than one version of model with name {name} is available.  In this case, {nameof(version)} must be specified.", nameof(version));
                else
                    throw new ArgumentException($"More than one version of model with name {name} is available.", nameof(name));
            }
            else
            {
                model = eligibleModels.SingleOrDefault();
                return model is not null;
            }
        }

        public bool TryGetConversionFunctionName(string fromQualifiedTypeName, string toQualifiedTypeName, [NotNullWhen(true)] out string? conversionFunctionName)
        {
            if (ConversionFunctions.TryGetValue(fromQualifiedTypeName, out var toFunctions)
                && toFunctions.TryGetValue(toQualifiedTypeName, out conversionFunctionName)) {
                return true;
            }
            conversionFunctionName = null;
            return false;
        }

        public bool TryGetConversionFunctions(string fromQualifiedTypeName, [NotNullWhen(true)] out (string To, string Function)[]? conversions)
        {
            if (ConversionFunctions.TryGetValue(fromQualifiedTypeName, out var toFunctions))
            {
                conversions = toFunctions
                    .Select(kvp => (kvp.Key, kvp.Value))
                    .ToArray();
                return true;
            }
            conversions = null;
            return false;

        }
    }
}

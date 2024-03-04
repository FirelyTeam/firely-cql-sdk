using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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

        private Dictionary<string, Dictionary<string, ModelInfo>> ModelsByUriAndVersion { get; }
            = new Dictionary<string, Dictionary<string, ModelInfo>>();

        public IModelProvider Add(ModelInfo model)
        {
            if (model.requiredModelInfo is not null)
                checkRequiredModels(model.name, model.requiredModelInfo);

            if (!ModelsByUriAndVersion.TryGetValue(model.url, out var modelsByVersion))
            {
                modelsByVersion = new Dictionary<string, ModelInfo>();
                ModelsByUriAndVersion.Add(model.url, modelsByVersion);
            }
            modelsByVersion!.Add(model.version, model);
            return this;
        }

        private void checkRequiredModels(string name, Model.ModelSpecifier[] requiredModelInfo)
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using ModelInfo = Hl7.Cql.Model.ModelInfo;

namespace Hl7.Cql.CqlToElm
{
    internal class ModelProvider : IModelProvider
    {
        public ModelProvider(params ModelInfo[] models)
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
                if (ModelFromName(requiredModel.name, requiredModel.version) is null)
                    throw new ArgumentException($"Model {name} depends on model {requiredModel.name} which has not yet been added to the provider.");
            }
        }

        public ModelInfo? ModelFromUri(string uri, string? version = null)
        {
            if (ModelsByUriAndVersion.TryGetValue(uri, out var modelsByVersion))
            {
                if (!string.IsNullOrWhiteSpace(version))
                {
                    if (modelsByVersion!.TryGetValue(version!, out var modelInfo))
                        return modelInfo;
                    else
                        return null;
                }
                else if (modelsByVersion.Count == 1)
                    return modelsByVersion.Values.Single();
                else
                    throw new ArgumentException($"More than one version of model {uri} is available.  In this case, {nameof(version)} must be specified.", nameof(version));
            }
            return null;
        }

        public ModelInfo? ModelFromName(string name, string? version = null)
        {
            var models = ModelsByUriAndVersion.Values.SelectMany(dict => dict.Values);
            var eligibleModels = new LinkedList<ModelInfo>();
            foreach (var model in models)
                if (model.name == name)
                    eligibleModels.AddLast(model);
            if (eligibleModels.Count > 1)
            {
                if (string.IsNullOrWhiteSpace(version))
                    throw new ArgumentException($"More than one version of model with name {name} is available.  In this case, {nameof(version)} must be specified.", nameof(version));
                else
                {
                    var withVersion = eligibleModels.SingleOrDefault(m => m.version == version);
                    return withVersion;
                }
            }
            else return eligibleModels.First();
        }
    }
}

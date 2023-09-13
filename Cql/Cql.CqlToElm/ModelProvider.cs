using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (!ModelsByUriAndVersion.TryGetValue(model.url, out var modelsByVersion))
            {
                modelsByVersion = new Dictionary<string, ModelInfo>();
                ModelsByUriAndVersion.Add(model.url, modelsByVersion);
            }
            modelsByVersion!.Add(model.version, model);
            return this;
        }

        public ModelInfo? ModelFromUri(string uri, string? version = null)
        {
            if (ModelsByUriAndVersion.TryGetValue(uri, out var modelsByVersion))
            {
                if (!string.IsNullOrWhiteSpace(version))
                {
                    if (modelsByVersion!.TryGetValue(version, out var modelInfo))
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

        public TypeInfo? TypeInfoFor(ModelInfo model, string name)
        {
            if (!name.StartsWith($"{model.name}."))
                name = $"{model.name}.{name}";
            var typeInfo = model.typeInfo.FirstOrDefault(ti => ti switch
            {
                SimpleTypeInfo sti => sti.name == name,
                ClassInfo c => c.name == name,
                _ => false
            });
            return typeInfo;
        }

        public string QualifiedTypeName(ModelInfo model, string typeName) =>
              $"{{{model.url}}}{typeName}";

        public ModelInfo GetSystemModel(Library library)
        {
            if (library != null)
            {
                if (library.usings != null)
                {
                    foreach (var ud in library.usings)
                    {
                        if (ud.localIdentifier == "System")
                            return ModelFromUri(ud.uri, ud.version)
                                ?? throw new InvalidOperationException($"Model {ud.uri} version {ud.version} is not available.");
                    }
                }
            }
            throw new ArgumentException("No model in this library has a local identifier of System.", nameof(library));
        }
    }
}

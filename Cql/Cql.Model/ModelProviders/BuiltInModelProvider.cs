using Hl7.Cql.Model;
using Hl7.Cql.Model.Xml;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Model.ModelProviders
{
    internal class BuiltInModelProvider: IModelProvider
    {
        private ModelLoader ModelLoader = new ModelLoader(name => Models.All[name]);

        public bool TryGetModel(string modelName, string? version,
            [NotNullWhen(true)] out ModelDefinition? model,
            [NotNullWhen(false)] out string? error)
        {
            if (!ModelLoader.TryGetModel(modelName, out model))
            {
                if (Models.All.TryGetValue(modelName, out var info))
                {
                    ModelLoader.Load(info);
                    var found = ModelLoader.TryGetModel(modelName, out model);
                    if (!found)
                    {
                        error = $"Model {modelName} failed to load.";
                        model = null;
                    }
                    else
                        error = null;
                    return found;
                }
                else
                {
                    error = $"Model {modelName} was not found.";
                    model = null;
                    return false;
                }
            }
            else
            {
                error = null;
                return true;
            }
        }

        public bool TryGetModel(string modelName, string? version, [NotNullWhen(true)] out ModelDefinition? model)
        {
            throw new NotImplementedException();
        }

        public bool TryGetModelFromUri(string uri, [NotNullWhen(true)] out ModelDefinition? model)
        {
            throw new NotImplementedException();
        }

        public bool TryGetType(string qualfiedName, [NotNullWhen(true)] out TypeDefinition? type)
        {
            throw new NotImplementedException();
        }
    }
}

using Fhir.Metrics;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Model.ModelProviders;
internal class CachingModelProvider(IModelProvider provider): IModelProvider
{
    private object SyncRoot = new();
    private Dictionary<string, Dictionary<string, ModelDefinition>> ByName = new();
    private Dictionary<string, ModelDefinition> ByUri = new();

    public IModelProvider Provider { get; } = provider;

    public bool TryGetModel(string modelName, string? version, [NotNullWhen(true)] out ModelDefinition? model)
    {
        lock (SyncRoot)
        {
            if (version is not null)
            {
                if (!ByName.TryGetValue(modelName, out var versions))
                {
                    if (Provider.TryGetModel(modelName, version, out model))
                    {
                        versions = new() { { version, model } };
                        ByName.Add(modelName, versions);
                        ByUri.Add(model.Uri, model);
                        return true;
                    }
                    else
                    {
                        model = null;
                        return false;
                    }
                }
                else if (!versions.TryGetValue(version, out model))
                {
                    if (Provider.TryGetModel(modelName, version, out model))
                    {
                        versions.Add(version, model);
                        ByUri.Add(model.Uri, model);
                        return true;
                    }
                    else
                    {
                        model = null;
                        return false;
                    }
                }
                else return true;
            }
            else throw new NotSupportedException("Models must be refereced by version.");
        }
    }

    public bool TryGetModelFromUri(string uri, [NotNullWhen(true)] out ModelDefinition? model)
    {
        lock(SyncRoot)
        {
            return ByUri.TryGetValue(uri, out model);
        }
    }
}

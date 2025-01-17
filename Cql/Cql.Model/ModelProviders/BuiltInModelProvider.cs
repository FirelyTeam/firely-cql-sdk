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
    internal class BuiltInModelProvider: ModelLoader
    {
        public BuiltInModelProvider(): base(GetByNameAndVersion, GetByUri)
        {
        }

        private static ModelInfo? GetByNameAndVersion(string name, string? version)
        {
            if (version is null)
            {
                if (Models.All.TryGetValue(name, out var model))
                {
                    if (version is null || model.version == version)
                        return model;
                }
            }
            else
            {
                var matching = Models.All.Where(kvp => kvp.Key == name)
                    .Select(kvp => new KeyValuePair<string, Version>(kvp.Key,
                        Version.Parse(kvp.Value.version ?? "0.0.0.0")))
                    .OrderByDescending(kvp => kvp.Value);
                var highest = matching.FirstOrDefault();
                if (Models.All.TryGetValue(highest.Key, out var mi))
                    return mi;
            }
            return null;
        }

        private static ModelInfo? GetByUri(string uri)
        {
            foreach(var model in Models.All.Values)
                if (model.url == uri)
                    return model;
            return null;
        }
    }
}

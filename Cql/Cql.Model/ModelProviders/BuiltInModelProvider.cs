using Hl7.Cql.Model;
using Hl7.Cql.Model.Cql;
using Hl7.Cql.Model.Xml;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Model.ModelProviders
{
    internal class BuiltInModelProvider : IModelProvider
    {
        internal CqlModelLoader CqlModelLoader { get; }

        public BuiltInModelProvider(CqlModelLoader? modelLoader = null)
        {
            CqlModelLoader = modelLoader ?? new CqlModelLoader(this);
        }

        public bool TryGetModel(string modelName, string? version, [NotNullWhen(true)] out ModelDefinition? model)
        {
            model = (modelName, version) switch
            {
                ("System", "2.0.0") => CqlModelLoader.Load(Models.System200),
                (_, _) => null
            };
            return model is not null;
        }

        public bool TryGetModelFromUri(string uri, [NotNullWhen(true)] out ModelDefinition? model)
        {
            model = uri switch
            {
                "urn:hl7-org:elm-types:r2" => CqlModelLoader.Load(Models.System200),
                _ => null
            };
            return model is not null;
        }
    }
}

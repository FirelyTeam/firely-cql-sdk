using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Model
{
    internal interface IModelProvider
    {
        bool TryGetModel(string modelName, string? version, [NotNullWhen(true)] out ModelDefinition? model);

        bool TryGetModelFromUri(string uri, [NotNullWhen(true)] out ModelDefinition? model);

        bool TryGetType(string qualfiedName, [NotNullWhen(true)] out TypeDefinition? type);
    }
}

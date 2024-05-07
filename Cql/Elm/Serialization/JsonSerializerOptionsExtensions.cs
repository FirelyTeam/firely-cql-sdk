/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.Json;

namespace Hl7.Cql.Elm.Serialization
{
    internal static class JsonSerializerOptionsExtensions
    {
        public static JsonSerializerOptions AddPolymorphicConverters(this JsonSerializerOptions options,
            bool strict)
        {
            options.Converters.Add(new XmlIncludeConverterFactory(strict));
            return options;
        }
    }
}
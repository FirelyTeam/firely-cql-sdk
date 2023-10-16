#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Conversion;
using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.Compiler
{
    internal static class TypeConverterExtensions
    {
        public static TypeConverter AddElmConversions(this TypeConverter converter)
        {
            converter.AddConversion<DateTimePrecision, string?>(dtp => Enum.GetName(typeof(DateTimePrecision), dtp));
            converter.AddConversion<string, DateTimePrecision>(Enum.Parse<DateTimePrecision>);
            return converter;
        }
    }
}

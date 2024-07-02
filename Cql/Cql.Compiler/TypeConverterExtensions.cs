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
using CM = System.ComponentModel;

namespace Hl7.Cql.Compiler
{
    internal static class TypeConverterExtensions
    {
        public static TypeConverter AddElmConversions(this TypeConverter converter)
        {
            converter.AddConversion<DateTimePrecision, string?>(dtp => Enum.GetName(dtp));
            converter.AddConversion<string, DateTimePrecision>(Enum.Parse<DateTimePrecision>);
            return converter;
        }

        public static CM.ListSortDirection ListSortOrder(this SortDirection direction) => direction switch
        {
            SortDirection.asc => CM.ListSortDirection.Ascending,
            SortDirection.ascending => CM.ListSortDirection.Ascending,
            SortDirection.desc => CM.ListSortDirection.Descending,
            SortDirection.descending => CM.ListSortDirection.Descending,
            _ => throw new ArgumentException($"Unrecognized sort direction {Enum.GetName(typeof(SortDirection), direction)}")
        };

    }
}

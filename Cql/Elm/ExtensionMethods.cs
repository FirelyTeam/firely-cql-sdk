#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.ComponentModel;

namespace Hl7.Cql.Elm
{
    public static class ExtensionMethods
    {
        public static ListSortDirection ListSortOrder(this SortDirection direction) => direction switch
        {
            SortDirection.asc => ListSortDirection.Ascending,
            SortDirection.ascending => ListSortDirection.Ascending,
            SortDirection.desc => ListSortDirection.Descending,
            SortDirection.descending => ListSortDirection.Descending,
            _ => throw new ArgumentException($"Unrecognized sort direction {Enum.GetName(typeof(SortDirection), direction)}")
        };
    }
}
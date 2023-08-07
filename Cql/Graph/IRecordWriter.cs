#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System.Threading.Tasks;


namespace Hl7.Cql.Graph
{
    internal interface IRecordWriter<TContext>
        where TContext : ExecutionContext
    {
        void WriteRecord(ExecutedPath<TContext> path, ExecutedPathRecord record);
        Task WriteRecordAsync(ExecutedPath<TContext> path, ExecutedPathRecord record);

    }
}

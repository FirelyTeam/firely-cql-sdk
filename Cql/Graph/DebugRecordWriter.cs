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
    internal class DebugRecordWriter<TExecutionContext> : IRecordWriter<TExecutionContext>
        where TExecutionContext : ExecutionContext
    {
        public static readonly DebugRecordWriter<TExecutionContext> Instance = new DebugRecordWriter<TExecutionContext>();
        private DebugRecordWriter() { }
        public void WriteRecord(ExecutedPath<TExecutionContext> path, ExecutedPathRecord record) => System.Diagnostics.Debug.WriteLine(record);
        public Task WriteRecordAsync(ExecutedPath<TExecutionContext> path, ExecutedPathRecord record) => Task.Run(() => WriteRecord(path, record));
    }
}

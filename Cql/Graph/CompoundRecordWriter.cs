#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Hl7.Cql.Graph
{

    internal class CompoundRecordWriter<TContext> : IRecordWriter<TContext>
        where TContext : ExecutionContext
    {

        public CompoundRecordWriter(params IRecordWriter<TContext>[] writers)
        {
            Writers = writers ?? throw new ArgumentNullException(nameof(writers));
        }

        private readonly IList<IRecordWriter<TContext>> Writers;

        public void WriteRecord(ExecutedPath<TContext> path, ExecutedPathRecord record)
        {
            foreach (var writer in Writers)
                writer.WriteRecord(path, record);
        }

        public Task WriteRecordAsync(ExecutedPath<TContext> path, ExecutedPathRecord record) =>
            Task.WhenAll(Writers.Select(w => w.WriteRecordAsync(path, record)));
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
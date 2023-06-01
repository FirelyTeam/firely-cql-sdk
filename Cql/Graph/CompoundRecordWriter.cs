using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Hl7.Cql.Graph
{
    public class CompoundRecordWriter<TContext> : IRecordWriter<TContext>
        where TContext : ExecutionContext
    {

        public CompoundRecordWriter(params IRecordWriter<TContext>[] writers)
        {
            Writers = writers ?? throw new ArgumentNullException(nameof(writers));
        }

        private IList<IRecordWriter<TContext>> Writers;

        public void WriteRecord(ExecutedPath<TContext> path, ExecutedPathRecord record)
        {
            foreach (var writer in Writers)
                writer.WriteRecord(path, record);
        }

        public Task WriteRecordAsync(ExecutedPath<TContext> path, ExecutedPathRecord record) =>
            Task.WhenAll(Writers.Select(w => w.WriteRecordAsync(path, record)));
    }
}

using System.Threading.Tasks;


namespace Hl7.Cql.Graph
{
    public class DebugRecordWriter<TExecutionContext> : IRecordWriter<TExecutionContext>
        where TExecutionContext: ExecutionContext
    {
        public static readonly DebugRecordWriter<TExecutionContext> Instance = new DebugRecordWriter<TExecutionContext>();
        private DebugRecordWriter() { }
        public void WriteRecord(ExecutedPath<TExecutionContext> path, ExecutedPathRecord record) => System.Diagnostics.Debug.WriteLine(record);
        public Task WriteRecordAsync(ExecutedPath<TExecutionContext> path, ExecutedPathRecord record) => Task.Run(() => WriteRecord(path, record));
    }
}

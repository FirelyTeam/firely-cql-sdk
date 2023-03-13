using System.Threading.Tasks;


namespace Ncqa.Graph
{
    public interface IRecordWriter<TContext>
        where TContext: ExecutionContext
    {
        void WriteRecord(ExecutedPath<TContext> path, ExecutedPathRecord record);
        Task WriteRecordAsync(ExecutedPath<TContext> path, ExecutedPathRecord record);

    }
}

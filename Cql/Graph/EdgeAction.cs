
namespace Ncqa.Graph
{
    public abstract class EdgeAction
    {
    }

    public abstract class EdgeAction<TContext>: EdgeAction
        where TContext: ExecutionContext
    {
        public abstract string Action { get; }

        public abstract void Execute(ExecutedPath<TContext> path);

        public ExecutedPathRecord GetCurrentRecord(ExecutedPath<TContext> path, string recordType)
        {
            if (!path.Records.TryGetValue(recordType, out var collection))
            {
                collection = new ExecutedPathRecordCollection
                {
                    RecordType = recordType
                };
                path.Records[recordType] = collection;
            }
            if (collection.CurrentRecord == null)
            {
                collection.CurrentRecord = new ExecutedPathRecord
                {
                    RecordType = recordType
                };
                collection.Records.Add(collection.CurrentRecord);
            }
            return collection.CurrentRecord;
        }

    }
}

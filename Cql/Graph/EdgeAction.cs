#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Graph
{
    public abstract class EdgeAction
    {
    }

    public abstract class EdgeAction<TContext> : EdgeAction
        where TContext : ExecutionContext
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

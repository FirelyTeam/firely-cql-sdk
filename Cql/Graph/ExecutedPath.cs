/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Hl7.Cql.Graph
{

    public class ExecutedPath<TContext>
        where TContext : ExecutionContext
    {
        public ExecutedPath(TContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public TContext Context { get; }

        public IDictionary<string, ExecutedPathRecordCollection> Records { get; } = new Dictionary<string, ExecutedPathRecordCollection>(StringComparer.OrdinalIgnoreCase);

        public IDictionary<string, object?> Variables { get; } = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);

        public object? GetCurrentValue(string? recordType, string variableName)
        {
            if (string.IsNullOrWhiteSpace(recordType) == false)
            {
                var record = GetCurrentRecord(recordType!);
                if (record.Variables.TryGetValue(variableName, out var result))
                    return result;
            }
            else if (Variables.TryGetValue(variableName, out var result))
                return result;
            return null;
        }

        public ExecutedPathRecord GetCurrentRecord(string recordType)
        {
            if (!Records.TryGetValue(recordType, out var collection))
            {
                collection = new ExecutedPathRecordCollection
                {
                    RecordType = recordType,
                };
                Records[recordType] = collection;
            }
            if (collection.CurrentRecord is null)
                collection.CurrentRecord = new ExecutedPathRecord
                {
                    RecordType = recordType
                };
            return collection.CurrentRecord;
        }

        public ExecutedPathRecord? GetLastRecord(string recordType)
        {
            if (!Records.TryGetValue(recordType, out var collection))
            {
                collection = new ExecutedPathRecordCollection
                {
                    RecordType = recordType,
                };
                Records[recordType] = collection;
            }
            return collection.LastRecord;
        }

    }

    public class ExecutedPathRecordCollection
    {
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the record that the execution engine is currently building.  This record will be written and nullified by the next <c>MakeRecordAction</c> />.
        /// </summary>
        public ExecutedPathRecord? CurrentRecord { get; set; }

        /// <summary>
        /// Gets or sets the record that was last written by <c>MakeRecordAction</c>.  This field will be <see langword="null"/> until the first <c>MakeRecordAction</c> is encountered.
        /// </summary>
        public ExecutedPathRecord? LastRecord { get; set; }

        /// <summary>
        /// The list of all records produced by <c>MakeRecordAction</c>.
        /// </summary>
        public IList<ExecutedPathRecord> Records = new List<ExecutedPathRecord>();

    }

    public class ExecutedPathRecord : ICloneable
    {
        public string RecordType { get; set; } = string.Empty;
        public IDictionary<string, object?> Variables { get; } = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);

        public object Clone()
        {
            var @new = new ExecutedPathRecord
            {
                RecordType = RecordType,
            };
            foreach (var kvp in Variables)
            {
                var value = kvp.Value;
                if (value is ICloneable cloneable)
                    @new.Variables[kvp.Key] = cloneable.Clone();
                else
                    @new.Variables[kvp.Key] = value;
            }
            return @new;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("Record ").AppendLine(RecordType);
            foreach (var kvp in Variables)
            {
                builder.Append('\t').Append(kvp.Key).Append(": ").AppendLine((kvp.Value ?? "(null)").ToString());
            }
            return builder.ToString();
        }

    }
}

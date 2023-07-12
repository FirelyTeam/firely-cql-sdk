/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hl7.Cql.Graph
{
    public abstract class ExecutionLog
    {
        public abstract void Write(string message);
        public abstract void WriteLine(string message);

    }

    public class CompoundExecutionLog : ExecutionLog
    {
        private readonly ExecutionLog[] logs;

        public CompoundExecutionLog(params ExecutionLog[] logs)
        {
            this.logs = logs;
        }

        public override void Write(string message)
        {
            foreach (var log in logs)
                log.Write(message);
        }

        public override void WriteLine(string message)
        {
            foreach (var log in logs)
                log.WriteLine(message);
        }

    }

    public class DebugExecutionLog : ExecutionLog
    {
        public static readonly DebugExecutionLog Instance = new DebugExecutionLog();
        private DebugExecutionLog() { }

        public override void Write(string message) => System.Diagnostics.Debug.Write(message);
        public override void WriteLine(string message) => System.Diagnostics.Debug.WriteLine(message);
    }

    public class MemoryExecutionLog : ExecutionLog
    {
        private readonly StringBuilder currentLine = new StringBuilder();

        public IList<string> Lines { get; } = new List<string>();

        public override void Write(string message) => currentLine.Append(message);
        public override void WriteLine(string message)
        {
            currentLine.Append(message);
            Lines.Add(currentLine.ToString());
            currentLine.Clear();
        }
    }

    public class FlatFileExecutionLog : ExecutionLog
    {
        private static readonly char[] DenormalCharacters = Path.GetInvalidPathChars()
            .Concat(new[] { '/' })
            .ToArray();

        private readonly StringBuilder currentLine = new StringBuilder();
        private readonly StreamWriter writer;

        public DirectoryInfo OutputDirectory { get; }

        public FlatFileExecutionLog(DirectoryInfo outputDirectory)
        {
            OutputDirectory = outputDirectory ?? throw new ArgumentNullException(nameof(outputDirectory));
            if (OutputDirectory.Exists == false)
                OutputDirectory.Create();

            var fileLocation = Path.Combine(outputDirectory.FullName, "execution_log.txt");
            var fileInfo = new FileInfo(fileLocation);
            var fileStream = new FileStream(fileInfo.FullName, FileMode.Create, FileAccess.Write);
            writer = new StreamWriter(fileStream);
        }

        public IList<string> Lines { get; } = new List<string>();

        public override void Write(string message) => currentLine.Append(message);
        public override void WriteLine(string message)
        {
            currentLine.Append(message);
            Lines.Add(currentLine.ToString());
            writer.WriteLine(currentLine);

            writer.Flush();
            currentLine.Clear();
        }

        #region Dispose
        private readonly object SyncRoot = new object();
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(true);
        }
        protected bool IsDisposed { get; private set; }
        ~FlatFileExecutionLog() => Dispose(false);
        protected virtual void Dispose(bool disposing)
        {
            try
            {
                lock (SyncRoot)
                {
                    if (disposing)
                    {
                        IsDisposed = true;
                        writer.Flush();
                        writer.Dispose();
                    }
                }
            }
            finally
            {
                // free all unmanaged resources here.  Note that this is not in an else block.
            }
        }
        protected void ThrowIfDisposed()
        {
            if (IsDisposed)
                throw new ObjectDisposedException("This object is disposed.");
        }
        #endregion
    }

}

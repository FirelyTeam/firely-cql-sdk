#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System;
using System.IO;
using System.Text;

namespace Hl7.Cql.Logging
{
    internal class TextWriterLogger : ICqlLogger
    {
        public TextWriterLogger(Stream output)
        {
            if (!output.CanWrite)
                throw new ArgumentException("CQL is not readable", nameof(output));
            Output = new StreamWriter(output, Encoding.UTF8, 1024, true);
        }
        public TextWriterLogger(TextWriter output)
        {
            Output = output;
        }


        private TextWriter Output { get; }

        public void Write(string value) => Output.Write(value);
        public void WriteLine(string value) => Output.WriteLine(value);
    }
}

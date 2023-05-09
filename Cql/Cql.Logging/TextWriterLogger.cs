using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ncqa.Cql.Runtime.Logging
{
    public class TextWriterLogger : ILogger
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

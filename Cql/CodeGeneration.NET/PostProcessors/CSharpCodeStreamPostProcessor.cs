using System.IO;

namespace Hl7.Cql.CodeGeneration.NET.PostProcessors;

internal abstract class CSharpCodeStreamPostProcessor
{
    public abstract void ProcessStream(string name, Stream stream);
}
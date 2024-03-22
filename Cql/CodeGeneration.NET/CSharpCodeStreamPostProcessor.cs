using System.IO;

namespace Hl7.Cql.Packaging;

internal abstract class CSharpCodeStreamPostProcessor
{
    public abstract void ProcessStream(string name, Stream stream);
}
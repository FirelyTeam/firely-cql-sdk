namespace Hl7.Cql.Logging
{
    public interface ILogger
    {
        void Write(string value);
        void WriteLine(string value);
    }
}
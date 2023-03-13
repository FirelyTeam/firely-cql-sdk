namespace Ncqa.Cql.Runtime.Logging
{
    public interface ILogger
    {
        void Write(string value);
        void WriteLine(string value);
    }
}
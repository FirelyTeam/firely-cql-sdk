
namespace Hl7.Cql.Graph
{
    public class RecordTypeAndField
    {
        public string RecordType { get; set; } = string.Empty;
        public string Field { get; set; } = string.Empty;

        public override string ToString() => string.IsNullOrWhiteSpace(RecordType) ? Field : $"{RecordType}.{Field}";
    }
}

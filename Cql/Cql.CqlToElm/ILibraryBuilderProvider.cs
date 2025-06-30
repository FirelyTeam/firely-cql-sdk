using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm
{
    internal interface ILibraryBuilderProvider
    {
        bool TryResolveCqlToolkitConversionRecordWithLibraryBuilder(
            CqlVersionedLibraryIdentifier libVer,
            [NotNullWhen(true)] out CqlToolkitConversionRecord? cqlToolkitConversionRecord,
            out string? error);
    }
}

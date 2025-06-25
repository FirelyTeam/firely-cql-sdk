using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm
{
    internal interface ILibraryProvider
    {
        bool TryResolveLibraryBuilder(
            CqlVersionedLibraryIdentifier libVer,
            [NotNullWhen(true)] out LibraryBuilder? libraryBuilder,
            out string? error)
        {
            try
            {
                if (TryResolveCqlToolkitConversionRecordWithLibraryBuilder(
                        libVer,
                        out CqlToolkitConversionRecord? cqlToolkitConversionRecord,
                        out error))
                {
                    libraryBuilder = cqlToolkitConversionRecord.Value.LibraryBuilder!;
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = $"Failed to resolve library '{libVer}': {ex.Message}";
            }

            libraryBuilder = null;
            return false;
        }

        bool TryResolveCqlToolkitConversionRecordWithLibraryBuilder(
            CqlVersionedLibraryIdentifier libVer,
            [NotNullWhen(true)] out CqlToolkitConversionRecord? cqlToolkitConversionRecord,
            //[NotNullWhen(true)] out LibraryBuilder? libraryBuilder,
            out string? error);
    }
}

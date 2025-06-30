/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Toolkit.Internal;

/// <summary>
/// Provides the implementation for <seealso cref="ILibraryBuilderProvider"/>
/// which resolves a <seealso cref="LibraryBuilder"/> given a library name and version on a <seealso cref="CqlToolkitConversionDictionary.Builder"/>.
/// </summary>
/// <param name="conversionsBuilder"></param>
internal sealed class LibraryBuilderProvider(
    CqlToolkitConversionDictionary.Builder conversionsBuilder)
    : ILibraryBuilderProvider
{
    public CqlToolkitServices? CqlToElmTranslatorServices { get; set; }

    public CqlToolkitConversionDictionary.Builder ConversionsBuilder { get; set; } = conversionsBuilder;

    public bool TryResolveCqlToolkitConversionRecordWithLibraryBuilder(
        CqlVersionedLibraryIdentifier libVer,
        [NotNullWhen(true)] out CqlToolkitConversionRecord? cqlToolkitConversionRecord,
        out string? error)
    {
        error = null;
        cqlToolkitConversionRecord = null;

        if (!ConversionsBuilder.TryGetValue(libVer, out CqlToolkitConversionRecord record))
            return false;

        if (record.LibraryBuilder is not null)
        {
            cqlToolkitConversionRecord = record;
            return true;
        }

        Debug.Assert(CqlToElmTranslatorServices is not null);
        if (CqlToElmTranslatorServices is not null)
        {
            var logger = CqlToElmTranslatorServices.LoggerFactory.CreateLogger<LibraryBuilderProvider>();
            logger.LogInformation("Parsing CQL for {id}", libVer);
            var libraryBuilder = CqlToElmTranslatorServices.CqlToElmConverter.GetBuilder(CqlToElmTranslatorServices.LibraryVisitor, record.SourceCqlLibrary.Cql);
            var newRecord = record with { LibraryBuilder = libraryBuilder };
            ConversionsBuilder[libVer] = newRecord;
            cqlToolkitConversionRecord = newRecord;
            return true;
        }


        return false;
    }
}

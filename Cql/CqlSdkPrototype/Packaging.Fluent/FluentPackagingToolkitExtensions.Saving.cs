using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Packaging;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Packaging.Fluent;

public static partial class FluentPackagingToolkitExtensions
{
    public static FluentPackagingToolkit SaveFhirResources(
        this FluentPackagingToolkit packagingToolkit,
        DirectoryInfo directory,
        DirectoryPreparationStrategy? directoryPreparationStrategy = null)
    {
        (directoryPreparationStrategy ?? DirectoryPreparationStrategy.Recreate).PrepareDirectory(directory);

        var logger = packagingToolkit.LoggerFactory.CreateLogger(typeof(FluentPackagingToolkitExtensions));

        foreach (var resource in packagingToolkit.FhirResourcePackagings
                                          .SelectWhere(kv => kv.Value.FhirResource switch
                                          {
                                              null             => (false, default!),
                                              { } fhirResource => (true, fhirResource)
                                          }))
        {
            var resourceFileName = resource.GetResourceFileName();
            var fullFilePath = Path.Combine(directory.FullName, resourceFileName.ToString());

        }

        return packagingToolkit;
    }

}
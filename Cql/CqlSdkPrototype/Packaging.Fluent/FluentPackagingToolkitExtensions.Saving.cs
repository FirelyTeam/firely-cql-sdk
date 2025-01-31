using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Packaging.Fluent;

public static partial class FluentPackagingToolkitExtensions
{
    public static FluentPackagingToolkit SaveFhirResources(
        this FluentPackagingToolkit packagingToolkit,
        DirectoryInfo directory,
        DirectoryPreparationStrategy? directoryPreparationStrategy = null)
    {
        (directoryPreparationStrategy ?? DirectoryPreparationStrategy.Recreate).PrepareDirectory(directory);
        return packagingToolkit;
    }

}
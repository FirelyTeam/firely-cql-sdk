using CqlSdkPrototype.Cql.Extensibility;

namespace CqlSdkPrototype.Cql.Extensions;

public static partial class CqlToolkitExtensions
{
    private static ICqlToolkit Return(this ICqlToolkit cqlToolkit, Action<ICqlToolkit> with)
    {
        with(cqlToolkit);
        return cqlToolkit;
    }

    private static ICqlToolkit Return(this ICqlToolkit cqlToolkit, Action<ICqlToolkit, Func<ILogger>> with)
    {
        with(cqlToolkit, () => cqlToolkit.LoggerFactory.CreateLogger(typeof(CqlToolkitExtensions)));
        return cqlToolkit;
    }

    public static ICqlToolkit ReplaceSettings(this ICqlToolkit cqlToolkit, Func<CqlToolkitSettings, CqlToolkitSettings> replace) =>
        cqlToolkit.Return(cqlToolkit =>
        {
            var toolkit = ((CqlToolkit)cqlToolkit);
            var cqlToolkitSettings = replace(toolkit._settings);
            toolkit.SetSettings(cqlToolkitSettings);
        });
}
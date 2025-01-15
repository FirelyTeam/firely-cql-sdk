using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime.Hosting;
using CqlSdkPrototype.Runtime.Extensibility;
using CqlSdkPrototype.Logging.Internal;

namespace CqlSdkPrototype.Runtime;

public class RuntimeApi(RuntimeApiOptions? options = null) : IRuntimeApiExtensible<RuntimeApi>
{
    internal IRuntimeApiExtensible<RuntimeApi> AsExtensible() => this;
    T IRuntimeApiExtensible<RuntimeApi>.UseLogger<T>(Func<RuntimeApi, ILogger<RuntimeApi>, T> action) => action(this, _state.Logger);

    #region State

    private State _state = State.Create(options ?? RuntimeApiOptions.Default);

    RuntimeApiOptions IRuntimeApiExtensible<RuntimeApi>.Options => _state.Options;
    IReadOnlySet<AssemblyData> IRuntimeApiExtensible<RuntimeApi>.Entries => _state.Entries;

    private readonly record struct State(
        ImmutableHashSet<AssemblyData> Entries,
        RuntimeApiOptions Options,
        ILogger<RuntimeApi> Logger)
    {
        public static State Create(RuntimeApiOptions options)
        {
            return new State([], null!, null!)
            {
                // Must be set through the property initializer, to ensure the services are created
                Options = options,
            };
        }

        private readonly RuntimeApiOptions _options = Options;

        public RuntimeApiOptions Options
        {
            get => _options;
            init
            {
                if (ReferenceEquals(_options, value))
                    return;

                _options = value;
                Logger = value.LoggerFactory.CreateLogger<RuntimeApi>();
            }
        }
    }

    #endregion

    #region Construction

    private RuntimeApi WithAssemblyData(
        ImmutableHashSet<AssemblyData>? assemblyData = null)
    {
        _state = _state with
        {
            Entries = assemblyData ?? _state.Entries
        };
        return this;
    }

    public RuntimeApi WithOptions(
        Func<RuntimeApiOptions, RuntimeApiOptions> replaceOptions)
    {
        var newOptions = replaceOptions(_state.Options);
        if (!ReferenceEquals(_state.Options, newOptions))
            _state = _state with { Options = newOptions };
        return this;
    }

    #endregion

    #region Input (AssemblyData's)

    public RuntimeApi AddAssemblies(IEnumerable<AssemblyData> assemblyData)
    {
        var assembliesBuilder = _state.Entries.ToBuilder();
        var oldCount = assembliesBuilder.Count;
        assembliesBuilder.AddRange(assemblyData);
        return oldCount == assembliesBuilder.Count
                   ? this
                   : WithAssemblyData(assemblyData: assembliesBuilder.ToImmutable());
    }

    #endregion

    #region Output (InvocationScope)

    public RuntimeScope CreateRuntimeScope()
    {
        var alc = new AssemblyLoadContext("", true);
        foreach (var (assembly, debugSymbols) in _state.Entries)
            alc.LoadFromBytes(assembly!, debugSymbols);
        return new RuntimeScope(this, alc);
    }

    #endregion
}
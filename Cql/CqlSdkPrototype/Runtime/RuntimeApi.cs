using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime.Hosting;
using CqlSdkPrototype.Logging;
using CqlSdkPrototype.Runtime.Extensibility;

namespace CqlSdkPrototype.Runtime;

public class RuntimeApi(RuntimeApiOptions options) : IRuntimeApiExtensible<RuntimeApi>
{
    internal IRuntimeApiExtensible<RuntimeApi> AsExtensible() => this;
    T IRuntimeApiExtensible<RuntimeApi>.UseServices<T>(Func<(RuntimeApi runtimeApi, ILogger<RuntimeApi> logger), T> action) => action((this, _state.Logger));
    public static RuntimeApi Create(RuntimeApiOptions options) => new(options);

    #region State

    private State _state = CreateState(options);

    RuntimeApiOptions IRuntimeApiExtensible<RuntimeApi>.Options => _state.Options;
    IReadOnlySet<AssemblyData> IRuntimeApiExtensible<RuntimeApi>.Entries => _state.Entries;

    private readonly record struct State(
        RuntimeApiOptions Options,
        ImmutableHashSet<AssemblyData> Entries,
        IServiceProvider ServiceProvider,
        ILogger<RuntimeApi> Logger)
    {
        private readonly RuntimeApiOptions _options = Options;

        public State(
            RuntimeApiOptions Options,
            ImmutableHashSet<AssemblyData>? Entries = null) : this(Options, Entries ?? [], null!, null!)
        {
            this.Options = Options;
        }

        public RuntimeApiOptions Options
        {
            get => _options;
            init
            {
                _options = value;
                var services = new ServiceCollection();
                services.AddLoggingFromOptions(value.LoggingOptions);
                ServiceProvider = services.BuildServiceProvider();
                Logger = ServiceProvider.GetLogger<RuntimeApi>();
            }
        }
    }

    #endregion

    #region Construction

    private static State CreateState(RuntimeApiOptions options)
    {
        ImmutableHashSet<AssemblyData> assemblies = [];
        var state = new State(options, assemblies);
        return state;
    }

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

    public RuntimeInvocationScope CreateInvocationScope()
    {
        var alc = new AssemblyLoadContext("", true);
        foreach (var (assembly, debugSymbols) in _state.Entries)
            alc.LoadFromBytes(assembly!, debugSymbols);
        return new RuntimeInvocationScope(this, alc);
    }

    #endregion
}
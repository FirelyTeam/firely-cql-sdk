using CqlSdkPrototype.Advanced;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Runtime;

public class CqlRunner :
    ILogAccessor<CqlRunner>
{

    private readonly State _state;

    private CqlRunner(State state)
    {
        _state = state;
    }

    #region Nested Types

    private readonly record struct State(
        IServiceProvider ServiceProvider,
        ILogger<CqlRunner> Logger/*,
        ElmCompilationEntriesMap Entries,
        ElmCompilationCreateOptions Options*/);

    internal readonly record struct CqlRunnerEntry();

    #endregion

    ILogger<CqlRunner> ILogAccessor<CqlRunner>.Logger => _state.Logger;
}
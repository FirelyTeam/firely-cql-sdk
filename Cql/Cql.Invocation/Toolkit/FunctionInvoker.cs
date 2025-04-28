using Hl7.Cql.Runtime;
using static Hl7.Cql.Invocation.Toolkit.StringBuilderExtensions;

namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// Abstract base class representing a function invoker.
/// </summary>
/// <param name="libraryInvoker">The library invoker that created this instance.</param>
/// <param name="functionName">The name of the function.</param>
/// <param name="methodInfo">The method information for the definition.</param>
/// <param name="tagValuesByName">The tag values associated with the definition.</param>
/// <param name="valueSetId">The value set identifier, if any.</param>
public abstract class FunctionInvoker(
    LibraryInvoker libraryInvoker,
    string functionName,
    MethodInfo methodInfo,
    IReadOnlyDictionary<string, IReadOnlySet<string>> tagValuesByName,
    string? valueSetId)
{
    /// <summary>
    /// The library invoker that created this instance.
    /// </summary>
    private LibraryInvoker LibraryInvoker { get; } = libraryInvoker;

    /// <summary>
    /// Gets the name of the function.
    /// </summary>
    public string FunctionName { get;  } = functionName;

    protected MethodInfo MethodInfo { get; } = methodInfo;

    /// <summary>
    /// Gets the tag values by tag name that is associated with the definition.
    /// Where there duplicate tags by name, their values will be combined into a set.
    /// </summary>
    public IReadOnlyDictionary<string, IReadOnlySet<string>> TagValuesByName { get; } = tagValuesByName;

    /// <summary>
    /// Gets the return type of the function.
    /// </summary>
    public Type ReturnType => MethodInfo.ReturnType;

    /// <summary>
    /// A convenience property to get the library identifier of the library that contains this definition.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier => LibraryInvoker.LibraryIdentifier;

    /// <summary>
    /// A convenience property to get the library set name.
    /// </summary>
    public string LibrarySetName => LibraryInvoker.LibrarySetName;

    /// <summary>
    /// Gets the value set identifier, if any.
    /// </summary>
    public string? ValueSetId { get; } = valueSetId;

    /// <summary>
    /// Invokes the function with the given CQL context and the given arguments.
    /// </summary>
    /// <param name="cqlContext">The CQL context.</param>
    /// <param name="args">Additional arguments of the function.</param>
    /// <returns>The result of the invocation.</returns>
    public abstract object? Invoke(CqlContext cqlContext, params object[] args);

    /// <inheritdoc />
    public override string ToString() =>
        StartBrace()
            .AppendMemberIf(LibrarySetName, LibrarySetName is { Length: > 0 })
            .AppendMember(LibraryIdentifier)
            .AppendMember(FunctionName)
            .EndBrace();
}
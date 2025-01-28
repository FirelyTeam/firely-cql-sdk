using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Model;

namespace CqlSdkPrototype.Cql;

/// <summary>
/// The settings used to configure the CQL to ELM processor.
/// </summary>
public sealed record CqlToElmTranslatorConfig(
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default,
    ImmutableHashSet<CqlModel>? Models = null,
    ImmutableHashSet<ModelInfo>? ModelInfos = null,
    AmbiguousTypeBehavior AmbiguousTypeBehavior = AmbiguousTypeBehavior.Error,
    bool EnableListDemotion = false,
    bool EnableListPromotion = false,
    bool EnableIntervalPromotion = false,
    bool EnableIntervalDemotion = false,
    bool AllowNullInterval = false)
{
    public static CqlToElmTranslatorConfig Default { get; } = new();

    public ImmutableHashSet<CqlModel> Models { get; init; } = Models ?? [];

    public ImmutableHashSet<ModelInfo> ModelInfos { get; init; } = ModelInfos ?? [];

    /// <summary>
    /// When <see langword="true"/>, Interval(null, null) will be a valid construct.
    /// When <see langword="false"/>, an error will be generated when an interval's low and high values are both null.
    /// Note that this setting will only prevent intervals explicitly declared with the null keyword.
    /// The default value is <see langword="false"/>.
    /// </summary>
    /// <seealso href="https://cql.hl7.org/09-b-cqlreference.html#predecessor" />
    public bool AllowNullIntervals { get; init; } = AllowNullInterval;

    /// <summary>
    /// When <see langword="true"/>, point intervals will automatically be created as necessary from scalar values.
    /// When <see langword="false"/>, an error will occur; authors will be required to create point intervals explicitly.
    /// The default value is <see langword="false"/>.
    /// </summary>
    public bool EnableIntervalPromotion { get; init; } = EnableIntervalPromotion;

    /// <summary>
    /// When <see langword="true"/>, point intervals will be automatically demoted to scalar values as necessary.
    /// When <see langword="false"/>, an error will occur; authors will be required to convert intervals to scalar values explicitly.
    /// The default value is <see langword="false"/>.
    /// </summary>
    /// <remarks>
    /// Note that whether an interval is a point interval cannot be known at compile time.
    /// This type of conversion will issue a warning and could fail at runtime.
    /// </remarks>
    public bool EnableIntervalDemotion { get; init; } = EnableIntervalDemotion;

    /// <summary>
    /// When <see langword="true"/>, lists of size 1 will automatically be created as necessary from scalar values.
    /// When <see langword="false"/>, an error will occur; authors will be required to create lists explicitly.
    /// The default value is <see langword="false"/>.
    /// </summary>
    /// <seealso href="https://build.fhir.org/ig/HL7/cql/06-translationsemantics.html#disable-list-promotion-and-demotion" />
    public bool EnableListPromotion { get; init; } = EnableListPromotion;

    /// <summary>
    /// When <see langword="true"/>, lists of size 1 will automatically be converted to scalar values as necessary.
    /// When <see langword="false"/>, an error will occur; authors will be required to access the single list value explicitly.
    /// The default value is <see langword="false"/>.
    /// </summary>
    /// <remarks>
    /// Note that whether a list has only one element cannot be known at compile time.
    /// This type of conversion will issue a warning and could fail at runtime.
    /// </remarks>
    /// <seealso href="https://build.fhir.org/ig/HL7/cql/06-translationsemantics.html#disable-list-promotion-and-demotion" />
    public bool EnableListDemotion { get; init; } = EnableListDemotion;

    /// <summary>
    /// <para>
    /// Sets the behavior when two models have the same type name.  In this situation, one of three behaviors is possible.
    /// Note that in the event that three or more matching types are available, the behavior will always be to issue an error.
    /// </para>
    /// <para>
    /// The default behavior is <see cref="AmbiguousTypeBehavior.Error"/>.
    /// </para>
    /// </summary>
    public AmbiguousTypeBehavior AmbiguousTypeBehavior { get; init; } = AmbiguousTypeBehavior;

    internal void ApplyToCqlToElmOptions(CqlToElmOptions opt)
    {
        opt.AmbiguousTypeBehavior = AmbiguousTypeBehavior;
        opt.EnableListPromotion = EnableListPromotion;
        opt.EnableListDemotion = EnableListDemotion;
        opt.EnableIntervalPromotion = EnableIntervalPromotion;
        opt.EnableIntervalDemotion = EnableIntervalDemotion;
        opt.AllowNullIntervals = AllowNullIntervals;
    }
}
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CqlToElm;

namespace CqlSdkPrototype.Cql;

public record CqlApiOptions(
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default,
    ImmutableHashSet<CqlModel>? Models = null,
    AmbiguousTypeBehavior AmbiguousTypeBehavior = AmbiguousTypeBehavior.Error,
    bool EnableListPromotion = false)
{
    public static CqlApiOptions Default { get; } = new();

    public ImmutableHashSet<CqlModel> Models { get; init; } = Models ?? [];

    /// <summary>
    /// When <see langword="true"/>, lists of size 1 will automatically be created as necessary from scalar values.
    /// When <see langword="false"/>, an error will occur; authors will be required to create lists explicitly.
    /// The default value is <see langword="false"/>.
    /// </summary>
    /// <seealso href="https://build.fhir.org/ig/HL7/cql/06-translationsemantics.html#disable-list-promotion-and-demotion" />
    public bool EnableListPromotion { get; init; } = EnableListPromotion;

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
}
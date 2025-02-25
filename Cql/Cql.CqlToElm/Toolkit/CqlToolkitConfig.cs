/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Immutable;
using Hl7.Cql.Model;

namespace Hl7.Cql.CqlToElm.Toolkit;

/// <summary>
/// Configuration settings for the <see cref="CqlToolkit"/>.
/// </summary>
/// <param name="Models">The model information to use when translating CQL to ELM.</param>
/// <param name="ModelInfos">The model information to use when translating CQL to ELM.</param>
/// <param name="AmbiguousTypeBehavior">
/// <para>
/// Sets the behavior when two models have the same type name.  In this situation, one of three behaviors is possible.
/// Note that in the event that three or more matching types are available, the behavior will always be to issue an error.
/// </para>
/// <para>
/// The default behavior is <see cref="AmbiguousTypeBehavior.Error"/>.
/// </para>
/// </param>
/// When <see langword="true"/>, lists of size 1 will automatically be converted to scalar values as necessary.
/// When <see langword="false"/>, an error will occur; authors will be required to access the single list value explicitly.
/// The default value is <see langword="false"/>.
/// <param name="EnableListDemotion">
/// When <see langword="true"/>, lists of size 1 will automatically be created as necessary from scalar values.
/// When <see langword="false"/>, an error will occur; authors will be required to create lists explicitly.
/// The default value is <see langword="false"/>.
/// </param>
/// <param name="EnableListPromotion">
/// When <see langword="true"/>, lists of size 1 will automatically be created as necessary from scalar values.
/// When <see langword="false"/>, an error will occur; authors will be required to create lists explicitly.
/// The default value is <see langword="false"/>.
/// </param>
/// <param name="EnableIntervalPromotion">
/// When <see langword="true"/>, point intervals will automatically be created as necessary from scalar values.
/// When <see langword="false"/>, an error will occur; authors will be required to create point intervals explicitly.
/// The default value is <see langword="false"/>.
/// </param>
/// <param name="EnableIntervalDemotion">
/// When <see langword="true"/>, point intervals will be automatically demoted to scalar values as necessary.
/// When <see langword="false"/>, an error will occur; authors will be required to convert intervals to scalar values explicitly.
/// The default value is <see langword="false"/>.
/// </param>
/// <param name="AllowNullIntervals">
/// </param>
public sealed record CqlToolkitConfig(
    ImmutableHashSet<CqlModel>? Models = null,
    ImmutableHashSet<ModelInfo>? ModelInfos = null,
    AmbiguousTypeBehavior AmbiguousTypeBehavior = AmbiguousTypeBehavior.Error,
    bool EnableListDemotion = false,
    bool EnableListPromotion = false,
    bool EnableIntervalPromotion = false,
    bool EnableIntervalDemotion = false,
    bool AllowNullIntervals = false)
{
    /// <summary>
    /// The default configuration for the CQL toolkit.
    /// </summary>
    public static CqlToolkitConfig Default { get; } = new();

    /// <summary>
    /// The model information to use when translating CQL to ELM.
    /// </summary>
    public ImmutableHashSet<CqlModel> Models { get; init; } = Models ?? [];

    /// <summary>
    /// The model information to use when translating CQL to ELM.
    /// </summary>
    public ImmutableHashSet<ModelInfo> ModelInfos { get; init; } = ModelInfos ?? [];

    /// <summary>
    /// When <see langword="true"/>, Interval(null, null) will be a valid construct.
    /// When <see langword="false"/>, an error will be generated when an interval's low and high values are both null.
    /// Note that this setting will only prevent intervals explicitly declared with the null keyword.
    /// The default value is <see langword="false"/>.
    /// </summary>
    /// <seealso href="https://cql.hl7.org/09-b-cqlreference.html#predecessor" />
    public bool AllowNullIntervals { get; init; } = AllowNullIntervals;

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

/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Immutable;
using System.Text.Json.Serialization;
using Hl7.Cql.Model;

namespace Hl7.Cql.CqlToElm.Toolkit;

/// <summary>
/// Configuration settings for the <see cref="CqlToolkit"/>.
/// </summary>
///
/// <param name="Models">
/// The model information to use when translating CQL to ELM.
/// </param>
///
/// <param name="ModelInfos">
/// The model information to use when translating CQL to ELM.
/// </param>
///
/// <param name="AmbiguousTypeBehavior">
/// <para>
/// Sets the behavior when two models have the same type name. In this situation, one of three behaviors is possible.
/// Note that in the event that three or more matching types are available, the behavior will always be to issue an error.
/// </para>
/// <para>
/// The default behavior is <see cref="AmbiguousTypeBehavior.Error"/>.
/// </para>
/// </param>
///
/// <param name="SystemElmModelUri">
/// <para>
/// Sets the default URI of the ELM model that will be automatically included
/// as a <code>using</code> directive, using the local identifier <code>System</code>.
/// </para>
/// <para>
/// If <see langword="null"/>, no ELM model will be automatically included, and the CQL
/// library must manually declare a <code>using System version 'version'</code> statement
/// for ELM types to resolve.
/// </para>
/// <para>
/// The default value of this option is <code>"urn:hl7-org:elm-types:r1"</code>, corresponding to the model
/// located at https://github.com/cqframework/clinical_quality_language/blob/69a7cd8efd6c964014ce820ad1fb08590e2c562e/Src/java/model/src/main/resources/org/hl7/elm/r1/system-modelinfo.xml
/// </para>
/// </param>
///
/// <param name="SystemElmModelVersion">
/// <para>
/// Sets the default version of the ELM model that will be automatically included
/// as a <code>using</code> directive, using the local identifier <code>System</code>.
/// </para>
/// <para>
/// If <see langword="null"/>, no ELM model will be automatically included, and the CQL
/// library must manually declare a <code>using System version 'version'</code> statement
/// for ELM types to resolve.
/// </para>
/// <para>
/// The default value of this option is <code>"1.0.0"</code>, corresponding to the model
/// located at https://github.com/cqframework/clinical_quality_language/blob/69a7cd8efd6c964014ce820ad1fb08590e2c562e/Src/java/model/src/main/resources/org/hl7/elm/r1/system-modelinfo.xml
/// </para>
/// </param>
///
/// <param name="EnableListDemotion">
/// When <see langword="true"/>, lists of size 1 will automatically be converted to scalar values as necessary.
/// When <see langword="false"/>, an error will occur; authors will be required to access the single list value explicitly.
/// The default value is <see langword="false"/>.
/// </param>
///
/// <param name="EnableListPromotion">
/// When <see langword="true"/>, lists of size 1 will automatically be created as necessary from scalar values.
/// When <see langword="false"/>, an error will occur; authors will be required to create lists explicitly.
/// The default value is <see langword="false"/>.
/// </param>
///
/// <param name="EnableIntervalPromotion">
/// When <see langword="true"/>, point intervals will automatically be created as necessary from scalar values.
/// When <see langword="false"/>, an error will occur; authors will be required to create point intervals explicitly.
/// The default value is <see langword="false"/>.
/// </param>
///
/// <param name="EnableIntervalDemotion">
/// When <see langword="true"/>, point intervals will be automatically demoted to scalar values as necessary.
/// When <see langword="false"/>, an error will occur; authors will be required to convert intervals to scalar values explicitly.
/// The default value is <see langword="false"/>.
/// </param>
///
/// <param name="AllowNullIntervals">
/// When <see langword="true"/>, Interval(null, null) will be a valid construct.
/// When <see langword="false"/>, an error will be generated when an interval's low and high values are both null.
/// Note that this setting will only prevent intervals explicitly declared with the null keyword.
/// The default value is <see langword="false"/>.
/// </param>
///
/// <param name="ValidateIntervals">
/// When <see langword="true"/>, intervals' point types will be required to be an ordered type.
/// Ordered types are specifically types for which predecessor, successor, and comparison operators exist.
/// Specifically, this includes Integer, Long, Decimal, Quantity, Date, DateTime, and Type types.
/// The default value is <see langword="true"/>.
/// </param>
///
/// <param name="LongsRequireSuffix">
/// When <see langword="true"/>, literals like 2147483648 without the L suffix required for long values
/// will be allowed. Otherwise, these literals will be treated as errors if <see cref="ValidateLiterals"/> is <see langword="true"/>.
/// The default value is <see langword="true"/>.
/// </param>
///
/// <param name="ValidateLiterals">
/// When <see langword="true"/>, illegal literals that would fall outside the range of their minimum and maximum values will raise errors.
/// The default value is <see langword="true"/>.
/// </param>
public sealed record CqlToolkitConfig(
    ImmutableHashSet<CqlModel>? Models = null,
    ImmutableHashSet<ModelInfo>? ModelInfos = null,
    AmbiguousTypeBehavior AmbiguousTypeBehavior = AmbiguousTypeBehavior.PreferModel,
    string? SystemElmModelUri = "urn:hl7-org:elm-types:r1",
    string? SystemElmModelVersion = "1.0.0",
    // Lists
    bool EnableListDemotion = false,
    bool EnableListPromotion = false,
    // Intervals
    bool EnableIntervalDemotion = false,
    bool EnableIntervalPromotion = false,
    bool AllowNullIntervals = false,
    bool ValidateIntervals = true,
    // Longs
    bool LongsRequireSuffix = true,
    // Literals
    bool ValidateLiterals = true
    )
{
    /// <nodoc />
    public CqlToolkitConfig() : this(Models:null) { } // We need a public parameterless constructor for DI

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
    [JsonIgnore]
    public ImmutableHashSet<ModelInfo> ModelInfos { get; init; } = ModelInfos ?? [];


    /// <summary>
    /// <para>
    /// Sets the default URI of the ELM model that will be automatically included
    /// as a <code>using</code> directive, using the local identifer <code>System</code>.
    /// </para>
    /// <para>
    /// If <see langword="null"/>, no ELM model will be automatically included, and the CQL
    /// library must manually declare a <code>using System version 'version'</code> statement
    /// for ELM types to resolve.
    /// </para>
    /// <para>
    /// The default value of this option is <code>"urn:hl7-org:elm-types:r1"</code>, corresponding to the model
    /// located at https://github.com/cqframework/clinical_quality_language/blob/69a7cd8efd6c964014ce820ad1fb08590e2c562e/Src/java/model/src/main/resources/org/hl7/elm/r1/system-modelinfo.xml
    /// </para>
    /// </summary>
    /// <seealso cref="SystemElmModelVersion"/>
    public string? SystemElmModelUri { get; init; } = SystemElmModelUri;

    /// <summary>
    /// <para>
    /// Sets the default version of the ELM model that will be automatically included
    /// as a <code>using</code> directive, using the local identifer <code>System</code>.
    /// </para>
    /// <para>
    /// If <see langword="null"/>, no ELM model will be automatically included, and the CQL
    /// library must manually declare a <code>using System version 'version'</code> statement
    /// for ELM types to resolve.
    /// </para>
    /// <para>
    /// The default value of this option is <code>"1.0.0"</code>, corresponding to the model
    /// located at https://github.com/cqframework/clinical_quality_language/blob/69a7cd8efd6c964014ce820ad1fb08590e2c562e/Src/java/model/src/main/resources/org/hl7/elm/r1/system-modelinfo.xml
    /// </para>
    /// </summary>
    /// <seealso cref="SystemElmModelUri"/>
    public string? SystemElmModelVersion { get; init; } = SystemElmModelVersion;

    /// <summary>
    /// When <see langword="true"/>, illegal literals that would fall outside the range of their minimum and maximum values will raise errors.
    /// The default value is <see langword="true"/>.
    /// </summary>
    /// <remarks>
    /// If your execution environment has different minimum and maximum values for some types, you should set this value to <see langword="false"/> as necessary.
    /// Note that doing so will run the risk of creating ELM libraries that cannot be used by other execution environments.
    /// </remarks>
    public bool ValidateLiterals { get; init; } = ValidateLiterals;

    /// <summary>
    /// When <see langword="true"/>, literals like 2147483648 without the L suffix required for long values
    /// will be allowed.  Otherwise, these literals will be treated as errors if <see cref="ValidateLiterals"/> is <see langword="true"/>.
    /// The default value is <see langword="true"/>.
    /// </summary>
    public bool LongsRequireSuffix { get; init; } = LongsRequireSuffix;

    /// <summary>
    /// When <see langword="true"/>, intervals' point types will be required to be an ordered type.
    /// Ordered types are specifically types for which predecessor, successor, and comparison operators exist.
    /// Specifically, this includes Integer, Long, Decimal, Quantity, Date, DateTime, and Type types.
    /// The default value is <see langword="true"/>.
    /// </summary>
    /// <seealso href="https://cql.hl7.org/09-b-cqlreference.html#predecessor" />
    [DefaultValue(true)]
    public bool ValidateIntervals { get; init; } = ValidateIntervals;

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
    /// When <see langword="true"/>, lists of size 1 will automatically be created as necessary from scalar values.
    /// When <see langword="false"/>, an error will occur; authors will be required to create lists explicitly.
    /// The default value is <see langword="false"/>.
    /// </summary>
    /// <seealso href="https://build.fhir.org/ig/HL7/cql/06-translationsemantics.html#disable-list-promotion-and-demotion" />
    public bool EnableListPromotion { get; init; } = EnableListPromotion;

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
        opt.LongsRequireSuffix = LongsRequireSuffix;
        opt.SystemElmModelUri = SystemElmModelUri;
        opt.SystemElmModelVersion = SystemElmModelVersion;
        opt.ValidateIntervals = ValidateIntervals;
        opt.ValidateLiterals = ValidateLiterals;
    }
}

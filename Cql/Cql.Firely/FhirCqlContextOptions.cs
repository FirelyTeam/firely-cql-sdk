/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Fhir.Metrics;
using Hl7.Cql.Comparers;
using Hl7.Cql.Conversion;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir
{
    /// <summary>
    /// Defines behavior options to configure the CQL context for FHIR model binding.
    /// </summary>
    public class FhirCqlContextOptions
    {
        /// <summary>
        /// Gets the default CQL options.
        /// </summary>
        public static readonly FhirCqlContextOptions Default = new();

        /// <summary>
        /// When not <see langword="null"/>, all FHIR resource types will be compared only by their <see cref="Resource.Id"/> property
        /// using the value of this property.
        /// When <see langword="null"/>, FHIR resources will compared using Tuple equality behavior as defined in the specification.
        /// </summary>
        public StringComparer? ResourceIdComparer { get; init; } = StringComparer.OrdinalIgnoreCase;

        /// <summary>
        /// Defines the behavior when checking if a code exists in a collection of codes.
        /// </summary>
        public CodeInOperatorSemantics CodeInOperatorType { get; init; } = CodeInOperatorSemantics.Equivalent;

        /// <summary>
        /// Enum to house the options for checking if a <see cref="Code"/> exists in a list of <see cref="Code"/>
        /// </summary>
        public enum CodeInOperatorSemantics
        {
            /// <summary>
            /// Forces the use of the <see cref="CqlCodeCqlComparer"/>
            /// </summary>
            Equals,
            /// <summary>
            /// Forces the use of the <see cref="CqlCodeCqlEquivalentComparer"/>
            /// </summary>
            Equivalent
        }

        /// <summary>
        /// The default <see cref="ModelInspector"/> to use is <see cref="ModelInfo.ModelInspector"/>, unless otherwise overridden here.
        /// </summary>
        /// <remarks>Changing this value, will create a new <see cref="TypeConverter"/>, unless a custom one was provided in <see cref="OverrideTypeConverter"/>.</remarks>
        public ModelInspector? OverrideModelInspector { get; init; }

        /// <summary>
        /// The timezone offset the <see cref="TypeConverter"/> uses when a CQL value without an offset has to be
        /// emitted as a FHIR <c>dateTime</c> carrying a time component, which FHIR requires to have an offset.
        /// When <see langword="null"/>, the offset of the <c>now</c> argument — the timestamp of the evaluation
        /// request — is used; when that is <see langword="null"/> too, UTC is used, which matches the UTC
        /// evaluation timestamp the engine synthesizes when <c>now</c> is omitted. Must be a whole number of
        /// minutes within ±14:00.
        /// </summary>
        /// <remarks>Changing this value, will create a new <see cref="TypeConverter"/>, unless a custom one was provided in <see cref="OverrideTypeConverter"/>.</remarks>
        /// <exception cref="ArgumentOutOfRangeException">The value is not a whole number of minutes within ±14:00.</exception>
        public TimeSpan? OverrideConverterTimezoneOffset
        {
            get => _overrideConverterTimezoneOffset;
            // Validated here rather than where the converter is built, so an unusable offset is reported
            // against this property, at the point the options are constructed.
            init => _overrideConverterTimezoneOffset =
                FhirTypeConverter.ValidateDefaultTimezoneOffset(value, nameof(OverrideConverterTimezoneOffset));
        }

        private readonly TimeSpan? _overrideConverterTimezoneOffset;

        /// <summary>
        /// The default <see cref="TypeConverter"/> to use is <see cref="FhirTypeConverter.Create(ModelInspector,Nullable{TimeSpan})"/>, unless otherwise overridden here.
        /// </summary>
        public TypeConverter? OverrideTypeConverter { get; init; }

        /// <summary>
        /// The <see cref="IMetricService"/> to use for UCUM unit conversions, or <see langword="null"/> to use the default service.
        /// Inject a custom implementation here.
        /// </summary>
        public IMetricService? MetricService { get; init; }

        /// <summary>
        /// The default <see cref="IRetrieveProfileFilter"/> to use is <see cref="QICoreRetrieveProfileFilter.Default"/>,
        /// unless otherwise overridden here. Provide an implementation returning <see langword="null"/> for every
        /// template id to disable profile-based retrieve filtering.
        /// </summary>
        public IRetrieveProfileFilter? OverrideRetrieveProfileFilter { get; init; }

        /// <summary>
        /// When not <see langword="null"/>, the created context memoizes definition/expression results in a cache
        /// created from this profile. When <see langword="null"/>, the context is created without a cache and every
        /// reference to a definition re-evaluates it.
        /// </summary>
        /// <remarks>
        /// A cached context returns the results computed against the data the context was created with, so only
        /// enable this for a context whose data does not change while it is being evaluated. Use
        /// <see cref="EvaluationCacheProfile.Concurrent"/> when several threads evaluate definitions over one
        /// context; that also requires the thread-safety contract documented on <see cref="CqlContext"/>:
        /// definitions and parameters fully populated before the fan-out and not mutated during it, and a data
        /// source and value set implementation that tolerate concurrent reads.
        /// </remarks>
        public EvaluationCacheProfile? EvaluationCache { get; init; }
    }
}

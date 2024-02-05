namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Defines options and their default values used while converting CQL to ELM.
    /// </summary>
    public class CqlToElmOptions
    {
        /// <summary>
        /// The default options.
        /// </summary>
        public static readonly CqlToElmOptions Default = new();

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
        public string? SystemElmModelUri { get; set; } = "urn:hl7-org:elm-types:r1";

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
        public string? SystemElmModelVersion { get; set; } = "1.0.0";

        /// <summary>
        /// When <see langword="true"/>, illegal literals that would fall outside the range of their minimum and maximum values will raise errors.
        /// The defualt value is <see langword="true"/>.
        /// </summary>
        /// <remarks>
        /// If your execution enviornment has different minimum and maximum values for some types, you should set this value to <see langword="false"/> as necessary.
        /// Note that doing so will run the risk of creating ELM libraries that cannot be used by other execution environments.
        /// </remarks>
        public bool? ValidateLiterals { get; set; } = true;

        /// <summary>
        /// When <see langword="true"/>, intervals' point types will be required to be an ordered type.
        /// Ordered types are specifically types for which predecessor, successor, and comparison operators exist.
        /// Specifically, this includes Integer, Long, Decimal, Quantity, Date, DateTime, and Type types.
        /// The defualt value is <see langword="true"/>.
        /// </summary>
        /// <seealso href="https://cql.hl7.org/09-b-cqlreference.html#predecessor" />
        public bool? ValidateIntervals { get; set; } = true;

        /// <summary>
        /// When <see langword="true"/>, Interval(null, null) will be a valid construct.
        /// When <see langword="false"/>, an error will be generated when an interval's low and high values are both null.
        /// Note that this setting will only prevent intervals explicitly declared with the null keyword.
        /// The defualt value is <see langword="false"/>.
        /// </summary>
        /// <seealso href="https://cql.hl7.org/09-b-cqlreference.html#predecessor" />
        public bool? AllowNullIntervals { get; set; } = false;

    }
}

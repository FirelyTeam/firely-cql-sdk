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
        /// The root path where all input libraries will be located.
        /// </para>
        /// <para>
        /// This path may contain CQL files, JSON ELM libraries, and XML ELM libraries.
        /// </para>
        /// </summary>
        public string? Input { get; set; }

        /// <summary>
        /// <para>
        /// When <see langword="true"/>, files in the <see cref="Input"/> path with a .cql extension will be treated as CQL source files
        /// and files with a .json or .xml extension will be treated as ELM libraries.  All other files will be ignored.
        /// When <see langword="false"/>, all files in <see cref="Input"/> will be analyzed to determine which type of artifact it is.
        /// The default value is <see langword="true"/>.
        /// </para>
        /// <para>
        /// Setting this value to <see langword="false"/> can have a significant adverse performance impact for paths with many files.
        /// </para>
        /// </summary>
        public bool? AssumeInputExtensions { get; set; } = true;

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
        /// The default value is <see langword="true"/>.
        /// </summary>
        /// <remarks>
        /// If your execution enviornment has different minimum and maximum values for some types, you should set this value to <see langword="false"/> as necessary.
        /// Note that doing so will run the risk of creating ELM libraries that cannot be used by other execution environments.
        /// </remarks>
        public bool? ValidateLiterals { get; set; } = true;

        /// <summary>
        /// When <see langword="true"/>, literals like 2147483648 without the L suffix required for long values
        /// will be allowed.  Otherwise, these literals will be treated as errors if <see cref="ValidateLiterals"/> is <see langword="true"/>.
        /// The default value is <see langword="true"/>.
        /// </summary>
        public bool? LongsRequireSuffix { get; set; } = true;

        /// <summary>
        /// When <see langword="true"/>, intervals' point types will be required to be an ordered type.
        /// Ordered types are specifically types for which predecessor, successor, and comparison operators exist.
        /// Specifically, this includes Integer, Long, Decimal, Quantity, Date, DateTime, and Type types.
        /// The default value is <see langword="true"/>.
        /// </summary>
        /// <seealso href="https://cql.hl7.org/09-b-cqlreference.html#predecessor" />
        public bool? ValidateIntervals { get; set; } = true;

        /// <summary>
        /// When <see langword="true"/>, Interval(null, null) will be a valid construct.
        /// When <see langword="false"/>, an error will be generated when an interval's low and high values are both null.
        /// Note that this setting will only prevent intervals explicitly declared with the null keyword.
        /// The default value is <see langword="false"/>.
        /// </summary>
        /// <seealso href="https://cql.hl7.org/09-b-cqlreference.html#predecessor" />
        public bool? AllowNullIntervals { get; set; } = false;

        /// <summary>
        /// When <see langword="true"/>, point intervals will automatically be created as necessary from scalar values.
        /// When <see langword="false"/>, an error will occur; authors will be required to create point intervals explicitly.
        /// The default value is <see langword="false"/>.
        /// </summary>
        public bool? EnableIntervalPromotion { get; set; } = false;

        /// <summary>
        /// When <see langword="true"/>, lists of size 1 will automatically be created as necessary from scalar values.
        /// When <see langword="false"/>, an error will occur; authors will be required to create lists explicitly.
        /// The default value is <see langword="false"/>.
        /// </summary>
        /// <seealso href="https://build.fhir.org/ig/HL7/cql/06-translationsemantics.html#disable-list-promotion-and-demotion" />
        public bool? EnableListPromotion { get; set; } = false;

        /// <summary>
        /// When <see langword="true"/>, point intervals will be automatically demoted to scalar values as necessary.
        /// When <see langword="false"/>, an error will occur; authors will be required to convert intervals to scalar values explicitly.
        /// The default value is <see langword="false"/>.
        /// </summary>
        /// <remarks>
        /// Note that whether an interval is a point interval cannot be known at compile time.
        /// This type of conversion will issue a warning and could fail at runtime.
        /// </remarks>
        public bool? EnableIntervalDemotion { get; set; } = false;

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
        public bool? EnableListDemotion { get; set; } = false;

        /// <summary>
        /// <para>
        /// When <see langword="true"/>, redefining a previously defined identifier will be allowed, for example:
        /// <code>
        /// from [Condition] c let x: c.onset, x: c.abatement return x
        /// </code>
        /// </para>
        /// <para>
        /// When <see langword="false"/>, an error will occur.
        /// The default value is <see langword="false"/>.
        /// </para>
        /// </summary>
        public bool? AllowScopeRedefinition { get; set; } = false;

        /// <summary>
        /// <para>
        /// Sets the behavior when two models have the same type name.  In this situation, one of three behaviors is possible.
        /// Note that in the event that three or more matching types are available, the behavior will always be to issue an error.
        /// </para>
        /// <para>
        /// The default behavior is <see cref="AmbiguousTypeBehavior.Error"/>.
        /// </para>
        /// </summary>
        public AmbiguousTypeBehavior? AmbiguousTypeBehavior { get; set; } = CqlToElm.AmbiguousTypeBehavior.PreferModel;

        /// <summary>
        /// Defines the type specifiers used when parsing literals.
        /// By default, these literal types will reference their corresponding types in the System model.
        /// </summary>
        public LiteralTypes LiteralTypes { get; set; } = new();
    }

    /// <summary>
    /// Defines the qualified type names for literals.
    /// </summary>
    /// <remarks>
    /// Normally, 
    /// </remarks>
    /// <param name="Default">The type used when type resolution fails; System.Any by default.</param>
    /// <param name="Integer">The type used when parsing Integer literals. System.Integer by default.</param>
    /// <param name="Long">The type used when parsing Long literals. System.Long by default.</param>
    /// <param name="Decimal">The type used when parsing Decimal literals. System.Decimal by default.</param>
    /// <param name="Boolean">The type used when parsing Boolean literals. System.Boolean by default.</param>
    /// <param name="Date">The type used when parsing Date literals. System.Date by default.</param>
    /// <param name="DateTime">The type used when parsing DateTime literals. System.DateTime by default.</param>
    /// <param name="Time">The type used when parsing Time literals. System.Time by default.</param>
    /// <param name="List">The type used when parsing List literals. System.List by default.</param>
    /// <param name="Interval">The type used when parsing Interval literals. System.Interval by default.</param>
    public record LiteralTypes(string Default = "{urn:hl7-org:elm-types:r1}Any",
        string Integer = "{urn:hl7-org:elm-types:r1}Integer",
        string Long = "{urn:hl7-org:elm-types:r1}Long",
        string Decimal = "{urn:hl7-org:elm-types:r1}Decimal",
        string Boolean = "{urn:hl7-org:elm-types:r1}Boolean",
        string Date = "{urn:hl7-org:elm-types:r1}Date",
        string DateTime = "{urn:hl7-org:elm-types:r1}DateTime",
        string Time = "{urn:hl7-org:elm-types:r1}Time",
        string List = "{urn:hl7-org:elm-types:r1}List",
        string Interval = "{urn:hl7-org:elm-types:r1}Interval");
        

    /// <summary>
    /// Sets the behavior when two models have the same type name. 
    /// </summary>
    public enum AmbiguousTypeBehavior
    {
        /// <summary>
        /// Issues an error when an ambiguous type is encountered.
        /// </summary>
        Error,
        /// <summary>
        /// Chooses the system type, e.g. System.Quantity.
        /// </summary>
        PreferSystem,
        /// <summary>
        /// Chooses the model type, e.g. FHIR.Quantity.
        /// </summary>
        PreferModel
    }
}

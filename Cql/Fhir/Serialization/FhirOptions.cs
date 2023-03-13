namespace Ncqa.Fhir.Serialization
{
    public class FhirOptions
    {
        /// <summary>
        /// <para>
        /// Per the standard, any element with cardinality &gt; 1 must be represented as an array,
        /// even when the array would contain only one element.
        /// </para>
        /// Setting this value to <see langword="true"/> will cause the deserializer to automatically
        /// promote scalar values into arrays of size 1.        
        /// </summary>
        /// <remarks>
        /// <para>
        /// The HL7 standard (https://www.hl7.org/fhir/json.html#repeat) specifically states:
        /// </para>
        /// <list type="bullet">
        /// <item>An item that may repeat is represented as an array even in the case that it doesn't repeat so that the process of parsing the resource is the same either way</item>
        /// </list>
        /// <para>
        /// Systems that are validating FHIR strictly should not enable this option.
        /// </para>
        /// </remarks>
        public bool AllowSingleOrArray { get; set; }
        public bool Minify { get; set; } = false;

    }
}

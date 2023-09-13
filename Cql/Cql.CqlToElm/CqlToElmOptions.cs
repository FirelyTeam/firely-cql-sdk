using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Defines options and their default values used while converting CQL to ELM.
    /// </summary>
    public class CqlToElmOptions
    {
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



    }
}

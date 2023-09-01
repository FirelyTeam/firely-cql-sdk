/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Operators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Hl7.Cql.Runtime
{

    /// <summary>
    /// Contains information required to execute CQL.
    /// </summary>
    public sealed class CqlContext
    {
        /// <summary>
        /// Contains all definitions required during execution.
        /// </summary>
        public DefinitionDictionary<Delegate> Definitions { get; }

        /// <summary>
        /// Gets the implementation of <see cref="ICqlOperators"/> this execution uses.
        /// </summary>
        public ICqlOperators Operators { get; }

        /// <summary>
        /// An external dictionary that contains the runtime state for extensions.
        /// </summary>
        /// <remarks>
        /// Runtime extensions can provide functionality like logging and timing by altering how the translation
        /// between ELM and .NET expressions is done.  For implementations that need to hold state, they can use
        /// keys in this dictionary to store any kind of state they need.
        /// </remarks>
        internal ConcurrentDictionary<string, object> Extensions { get; }

        /// <summary>
        /// Gets the values of library parameters for this execution.
        /// </summary>
        /// <remarks>
        /// To scope a parameter to an individual library, use it's name and version string (e.g., "library-version") followed by <see cref="ParameterDelimiter"/> followed by the parameter name,
        /// e.g. "library-version.parameter name".
        /// To scope a parameter globally, omit the library name and version.  If two libraries define the same parameter name but use different types, runtime errors will occur.
        /// If the value provided for a given parameter name is the incorrect type, a runtime error will occur.
        /// </remarks>
        public IDictionary<string, object> Parameters { get; }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="operators">The <see cref="ICqlOperators"/> implementation to use.</param>
        /// <param name="parameters">The input parameters, or <see langword="null"/>. </param>
        /// <param name="extensionState">A dictionary that will keep state used by extensions.</param>
        /// <param name="delegates">The delegates, or <see langword="null"/>.  If <see langword="null"/>, runtime errors will occur when CQL expressions attempt to reference other definitions.</param>
        internal CqlContext(ICqlOperators operators,
            DefinitionDictionary<Delegate>? delegates = null,
            IDictionary<string, object>? parameters = null,
            ConcurrentDictionary<string, object>? extensionState = null)
        {
            Operators = operators;
            Definitions = delegates ?? new DefinitionDictionary<Delegate>();
            Extensions = extensionState ?? new();
            Parameters = parameters ?? new Dictionary<string, object>();
        }

        /// <summary>
        /// Notifies subscribers when a function is called.
        /// </summary>
        public event EventHandler<FunctionCallEvent>? FunctionCalled;

        /// <summary>
        /// Raise the <see cref="FunctionCalled"/> event.
        /// </summary>
        /// <param name="eventData"></param>
        public CqlContext OnFunctionCalled(FunctionCallEvent eventData)
        {
            FunctionCalled?.Invoke(this, eventData);
            return this;
        }

        /// <summary>
        /// Defines the delimiter separating library names from parameter names.
        /// </summary>
        private const string ParameterDelimiter = ".";

        /// <summary>
        /// Gets the value of the parameter in <see cref="Parameters"/> given the library and parameter name.
        /// </summary>
        /// <param name="libraryNameAndVersion">The library name and version.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        /// <param name="defaultValue">The value to returns when the parameter could not be resolved.</param>
        /// <returns>The value of the parameter or <see langword="null"/> if not defined.</returns>
        public object? ResolveParameter(string libraryNameAndVersion, string parameterName, object? defaultValue)
        {
            var fullyQualified = $"{libraryNameAndVersion}{ParameterDelimiter}{parameterName}";
            if (Parameters.ContainsKey(fullyQualified))
                return Parameters[fullyQualified];

            if (Parameters.ContainsKey(parameterName))
                return Parameters[parameterName];

            return defaultValue;
        }

        /// <summary>
        /// Gets the value of the extension in <see cref="Extensions"/> given key.
        /// </summary>
        /// <param name="key">The extension key.</param>
        /// <param name="defaultValue">The default value to use if the extension isn't found.</param>
        /// <returns>The value of the parameter or <paramref name="defaultValue"/> if not defined.</returns>
        public object? ResolveExtension(string key, object? defaultValue)
        {
            if (!Extensions.TryGetValue(key, out var value))
            {
                Extensions[key] = defaultValue;
                return defaultValue;
            }

            return value;
        }
    }
}

/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Operators;
using System;
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
        /// The <see cref="IDataRetriever"/> used to supply model data to the executed code.
        /// </summary>
        public IDataRetriever DataRetriever => Operators.DataRetriever;

        /// <summary>
        /// Manages state of runtime extensions this execution uses.
        /// </summary>
        /// <remarks>
        /// Runtime extensions can provide functionality like logging and timing by altering how the translation
        /// between ELM and .NET expressions is done.  For implementations that need to hold state, they can use
        /// keys in this dictionary to store any kind of state they need.
        /// </remarks>
        public IDictionary<string, object> Extensions { get; init; } = new Dictionary<string, object>();

        /// <summary>
        /// Stores information about the current execution state of this CqlContext.
        /// </summary>
        public IReadOnlyCollection<CallStackEntry> CallStack { get; init; } = new Stack<CallStackEntry>();

        /// <summary>
        /// Gets the values of library parameters for this execution.
        /// </summary>
        /// <remarks>
        /// To scope a parameter to an individual library, use it's name and version string (e.g., "library-version") followed by <see cref="ParameterDelimiter"/> followed by the parameter name,
        /// e.g. "library-version.parameter name".
        /// To scope a parameter globally, omit the library name and version.  If two libraries define the same parameter name but use different types, runtime errors will occur.
        /// If the value provided for a given parameter name is the incorrect type, a runtime error will occur.
        /// </remarks>
        public IReadOnlyDictionary<string, object> Parameters { get; } = new Dictionary<string, object>();

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="operators">The <see cref="ICqlOperators"/> implementation to use.</param>
        /// <param name="parameters">The input parameters, or <see langword="null"/>. </param>
        /// <param name="delegates">The delegates, or <see langword="null"/>.  If <see langword="null"/>, runtime errors will occur when CQL expressions attempt to reference other definitions.</param>
        public CqlContext(ICqlOperators operators,
            DefinitionDictionary<Delegate>? delegates = null,
            IReadOnlyDictionary<string, object>? parameters = null)
        {
            Operators = operators;
            Definitions = delegates ?? new DefinitionDictionary<Delegate>();
            if (parameters != null)
                Parameters = parameters;
        }

        /// <summary>
        /// Creates a clone of this context with a deeper call stack.
        /// </summary>
        /// <param name="callStack">The new call stack entry to add.</param>
        /// <returns>A clone of this context with a deeper call stack.</returns>
        /// TODO: Make this behavior optional in ExpressionBuilder
        public CqlContext Deeper(CallStackEntry callStack)
        {
            var existingStack = CallStack ?? new Stack<CallStackEntry>();
            var newStack = new Stack<CallStackEntry>(existingStack);
            newStack.Push(callStack);

            return new CqlContext(Operators, Definitions, Parameters) { CallStack = newStack, Extensions = Extensions };
        }


        /// <summary>
        /// Defines the delimiter separating library names from parameter names.
        /// </summary>
        public const string ParameterDelimiter = ".";

        /// <summary>
        /// Gets the value of the parameter in <see cref="Parameters"/> given the library and parameter name.
        /// </summary>
        /// <param name="libraryNameAndVersion">The library name and version.</param>
        /// <param name="parameterName">The name of the parameter.</param>
        /// <param name="defaultValue">The default value to return if the parameter does not exist.</param>
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

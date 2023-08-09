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
        public DefinitionDictionary<Delegate> Definitions { get; private set; }

        /// <summary>
        /// Gets the implementation of <see cref="ICqlOperators"/> this execution uses.
        /// </summary>
        public ICqlOperators Operators { get; private set; }

        /// <summary>
        /// Manages state of runtime extensions this execution uses.
        /// </summary>
        /// <remarks>
        /// Runtime extensions can provide functionality like logging and timing by altering how the translation
        /// between ELM and .NET expressions is done.  For implementations that need to hold state, they can use
        /// keys in this dictionary to store any kind of state they need.
        /// </remarks>
        internal ConcurrentDictionary<string, object> Extensions { get; set; } = new ConcurrentDictionary<string, object>();
        /// <summary>
        /// Stores information about the current execution state of this CqlContext.
        /// </summary>
        internal Stack<CallStackEntry> CallStack { get; private set; }

        /// <summary>
        /// Gets the values of library parameters for this execution.
        /// </summary>
        /// <remarks>
        /// To scope a parameter to an individual library, use it's name and version string (e.g., "library-version") followed by <see cref="ParameterDelimiter"/> followed by the parameter name,
        /// e.g. "library-version.parameter name".
        /// To scope a parameter globally, omit the library name and version.  If two libraries define the same parameter name but use different types, runtime errors will occur.
        /// If the value provided for a given parameter name is the incorrect type, a runtime error will occur.
        /// </remarks>
        public IDictionary<string, object> Parameters { get; private set; } = new Dictionary<string, object>();

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="operators">The <see cref="ICqlOperators"/> implementation to use.</param>
        /// <param name="parameters">The input parameters, or <see langword="null"/>. </param>
        /// <param name="delegates">The delegates, or <see langword="null"/>.  If <see langword="null"/>, runtime errors will occur when CQL expressions attempt to reference other definitions.</param>
        public CqlContext(ICqlOperators operators,
            DefinitionDictionary<Delegate>? delegates = null,
            IDictionary<string, object>? parameters = null) : this()
        {
            Operators = operators;
            Definitions = delegates ?? new DefinitionDictionary<Delegate>();
            if (parameters != null)
                Parameters = parameters;
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        /// <summary>
        /// Construct a new instance of a CqlContext with just the call stack initialized.
        /// </summary>
        internal CqlContext()
        {
            CallStack = new Stack<CallStackEntry>();
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        /// <summary>
        /// Deepclones the CqlContext.
        /// </summary>        
        internal CqlContext Clone()
        {
            var clone = new CqlContext();
            PopulateClone(clone);
            return clone;
        }

        /// <summary>
        /// Copies the operators, extensions and parameters from a source CqlContext to a target CqlContext.
        /// </summary>
        internal void PopulateClone(CqlContext clone)
        {
            clone.Operators = Operators;
            clone.Extensions = Extensions;
            clone.Parameters = Parameters;
        }

        /// <summary>
        /// Creates a clone of this context with a deeper call stack.
        /// </summary>
        /// <param name="callStack">The new call stack entry to add.</param>
        /// <returns>A clone of this context with a deeper call stack.</returns>
        /// TODO: Make this behavior optional in ExpressionBuilder
        internal CqlContext Deeper(CallStackEntry callStack)
        {
            var existingStack = CallStack ?? new Stack<CallStackEntry>();
            var newStack = new Stack<CallStackEntry>(existingStack);
            newStack.Push(callStack);

            var clone = Clone();
            clone.CallStack = newStack;
            return clone;
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

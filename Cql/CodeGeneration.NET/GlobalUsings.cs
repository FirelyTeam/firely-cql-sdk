/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

// Global using directives

global using System;
global using System.Collections.Generic;
global using System.Collections.Immutable;
global using System.ComponentModel;
global using System.Diagnostics.CodeAnalysis;
global using System.Globalization;
global using System.IO;
global using System.Linq;
global using System.Linq.Expressions;
global using System.Reflection;
global using System.Runtime.Serialization;
global using System.Security.Cryptography;
global using System.Text;
global using Microsoft.CodeAnalysis;
global using Microsoft.CodeAnalysis.CSharp;
global using Microsoft.CodeAnalysis.Emit;
global using Microsoft.CodeAnalysis.Text;
global using Microsoft.Extensions.Logging;
global using BinaryExpression = System.Linq.Expressions.BinaryExpression;
global using CqlDefinitionDictionary = Hl7.Cql.Runtime.DefinitionDictionary<Hl7.Cql.Abstractions.CqlDefinition>;
global using Expression = System.Linq.Expressions.Expression;
global using UnaryExpression = System.Linq.Expressions.UnaryExpression;
global using ElmLibrary = Hl7.Cql.Elm.Library;
global using ElmToolkitArtifactsById = System.Collections.Immutable.ImmutableDictionary<Hl7.Cql.Runtime.CqlVersionedLibraryIdentifier, Hl7.Cql.CodeGeneration.NET.Toolkit.ElmToolkitArtifacts>;
global using ReadOnlyElmToolkitArtifactsById = System.Collections.Generic.IReadOnlyDictionary<Hl7.Cql.Runtime.CqlVersionedLibraryIdentifier, Hl7.Cql.CodeGeneration.NET.Toolkit.ElmToolkitArtifacts>;

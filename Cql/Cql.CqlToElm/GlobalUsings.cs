/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

// Global using directives

global using System;
global using System.Collections;
global using System.Collections.Generic;
global using System.ComponentModel;
global using System.Diagnostics;
global using System.Diagnostics.CodeAnalysis;
global using System.Globalization;
global using System.IO;
global using System.Linq;
global using System.Reflection;
global using System.Text;
global using System.Text.RegularExpressions;
global using System.Xml;
global using System.Xml.Serialization;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Options;
global using NotNullAttribute = Antlr4.Runtime.Misc.NotNullAttribute;
global using NotNullWhenAttribute = System.Diagnostics.CodeAnalysis.NotNullWhenAttribute;
global using TypeInfo = Hl7.Cql.Model.TypeInfo;

global using ElmLibrary = Hl7.Cql.Elm.Library;

global using CqlToolkitArtifactsById = System.Collections.Immutable.ImmutableDictionary<Hl7.Cql.Runtime.CqlVersionedLibraryIdentifier, Hl7.Cql.CqlToElm.Toolkit.CqlToolkitArtifacts>;
global using CqlToolkitArtifactsByIdReadOnly = System.Collections.Generic.IReadOnlyDictionary<Hl7.Cql.Runtime.CqlVersionedLibraryIdentifier, Hl7.Cql.CqlToElm.Toolkit.CqlToolkitArtifacts>;

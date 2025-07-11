/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

// Global using directives

global using System;
global using System.CodeDom.Compiler;
global using System.Collections.Concurrent;
global using System.Collections.Frozen;
global using System.Collections.Generic;
global using System.Collections.Immutable;
global using System.Collections.ObjectModel;
global using System.ComponentModel;
global using System.Diagnostics;
global using System.Diagnostics.CodeAnalysis;
global using System.Globalization;
global using System.Linq.Expressions;
global using System.Reflection;
global using System.Runtime.Loader;
global using System.Text.RegularExpressions;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Logging.Abstractions;

global using ElmLibrary = Hl7.Cql.Elm.Library;

global using FhirResource = Hl7.Fhir.Model.Resource;
global using FhirLibrary = Hl7.Fhir.Model.Library;
global using FhirMeasure = Hl7.Fhir.Model.Measure;
global using FhirModelInfo = Hl7.Fhir.Model.ModelInfo;

global using AssemblyBinaryHashSet = System.Collections.Immutable.ImmutableHashSet<Hl7.Cql.CodeGeneration.NET.AssemblyBinary>;
global using AssemblyBinaryReadOnlyHashSet = System.Collections.Generic.IReadOnlySet<Hl7.Cql.CodeGeneration.NET.AssemblyBinary>;


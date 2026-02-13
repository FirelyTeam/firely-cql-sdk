/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

// Global using directives

global using System.ComponentModel;
global using System.Diagnostics;
global using System.Diagnostics.CodeAnalysis;
global using System.Globalization;
global using System.Reflection;
global using System.Runtime.CompilerServices;
global using System.Security.Cryptography;
global using System.Text;
global using System.Text.Json;
global using System.Text.RegularExpressions;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using Microsoft.Extensions.Logging;
global using CqlLibraryString = Hl7.Cql.CqlToElm.CqlLibraryString;
global using CqlVersionedLibraryIdentifier = Hl7.Cql.Runtime.CqlVersionedLibraryIdentifier;
global using ElmAnnotation = Hl7.Cql.Elm.Annotation;
global using ElmLibrary = Hl7.Cql.Elm.Library;
global using ElmLibrarySet = Hl7.Cql.Compiler.LibrarySet;
global using FhirLibrary = Hl7.Fhir.Model.Library;
global using FhirMeasure = Hl7.Fhir.Model.Measure;
global using FhirModelCode = Hl7.Fhir.Model.Code;
global using FhirModelInfo = Hl7.Fhir.Model.ModelInfo;
global using FhirResource = Hl7.Fhir.Model.Resource;
global using Iso8601DateTimePrecision = Hl7.Cql.Iso8601.DateTimePrecision;
global using SysDateTime = System.DateTime;

global using PackagingToolkitArtifactsById = System.Collections.Immutable.ImmutableDictionary<Hl7.Cql.Runtime.CqlVersionedLibraryIdentifier, Hl7.Cql.Packaging.Toolkit.PackagingToolkitArtifacts>;
global using ReadOnlyPackagingToolkitArtifactsById = System.Collections.Generic.IReadOnlyDictionary<Hl7.Cql.Runtime.CqlVersionedLibraryIdentifier, Hl7.Cql.Packaging.Toolkit.PackagingToolkitArtifacts>;

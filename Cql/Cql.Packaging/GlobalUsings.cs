// Global using directives

global using System.Diagnostics;
global using System.Diagnostics.CodeAnalysis;
global using System.Reflection;
global using System.Runtime.CompilerServices;
global using System.Text;
global using System.Text.Json;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using Microsoft.Extensions.Logging;
global using ElmAnnotation = Hl7.Cql.Elm.Annotation;
global using ElmLibrary = Hl7.Cql.Elm.Library;
global using ElmLibrarySet = Hl7.Cql.Compiler.LibrarySet;
global using FhirLibrary = Hl7.Fhir.Model.Library;
global using FhirMeasure = Hl7.Fhir.Model.Measure;
global using FhirModelCode = Hl7.Fhir.Model.Code;
global using FhirResource = Hl7.Fhir.Model.Resource;
global using Iso8601DateTimePrecision = Hl7.Cql.Iso8601.DateTimePrecision;
global using SysDateTime = System.DateTime;

global using ElmToolkitConversionDictionary = System.Collections.Immutable.ImmutableDictionary<Hl7.Cql.Runtime.CqlVersionedLibraryIdentifier, CqlSdkPrototype.Elm.ElmToolkitConversionRecord>;
global using ElmToolkitConversionReadOnlyDictionary = System.Collections.Generic.IReadOnlyDictionary<Hl7.Cql.Runtime.CqlVersionedLibraryIdentifier, CqlSdkPrototype.Elm.ElmToolkitConversionRecord>;


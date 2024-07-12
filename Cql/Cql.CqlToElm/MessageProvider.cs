using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Provides localized error messages.
    /// </summary>
    internal class MessageProvider
    {
        internal MessageProvider(CultureInfo culture)
        {
            Culture = culture;
        }

        public CultureInfo Culture { get; }

        public string CannotResolveCircularReference() =>
             Messages.CannotResolveCircularReference;
        public string CouldNotResolveContextName(string contextName, params string[] modelNames) =>
            string.Format(Culture, Messages.CouldNotResolveContextName, contextName, string.Join(", ", modelNames));
        public string CouldNotResolveFunction(string functionName, params Expression[] arguments) =>
            string.Format(Culture, Messages.CouldNotResolveFunction, functionName, string.Join(", ", arguments.Select(t => t.resultTypeSpecifier.ToString())));
        public string CouldNotResolveFunction(string functionName, params TypeSpecifier[] types) =>
            string.Format(Culture, Messages.CouldNotResolveFunction, functionName, string.Join(", ", types.Select(t => t.ToString())));
        public string CouldNotResolveInLibrary(string identifier, string library) =>
            string.Format(Culture, Messages.CouldNotResolveInLibrary, identifier, library);
        public string CouldNotResolveInCurrent(string identifier) =>
            string.Format(Culture, Messages.CouldNotResolveInCurrent, identifier);
        public string CouldNotResolveLibrary(string name, string? version) =>
             string.Format(Culture, Messages.CouldNotFindLibrary, name, version ?? Messages.Latest);
        public string CouldNotResolveModel(string name) =>
             string.Format(Culture, Messages.CouldNotResolveModel, name);
        public string ExpressionCannotBeLibraryRef(string library) =>
            string.Format(Culture, Messages.ExpressionCannotBeLibraryRef, library);
        public string FoundMultipleLibraries(string name) =>
            string.Format(Culture, Messages.FoundMultipleLibraries, name);        
        public string IdentifierAlreadyInUse(string name) =>
            string.Format(Culture, Messages.IdentifierAlreadyInUse, name);
        public string IdentifierAlreadyInScope(string name) =>
            string.Format(Culture, Messages.IdentifierAlreadyInScope, name);
        public string NamedTypeRequiredInContext() => Messages.NamedTypeRequiredInContext;
        public string TypeCannotBeCast(TypeSpecifier from, TypeSpecifier to) =>
            string.Format(Culture, Messages.TypeCannotBeCast, from, to);
        public string TypeFoundIsNotExpected(TypeSpecifier from, TypeSpecifier to) =>
            string.Format(Culture, Messages.TypeFoundIsNotExpected, from, to);
        public string UnexpectedLibraryReference() =>
            Messages.UnexpectedLibraryReference;
        public string UnableToResolveLibrary(string library, string? version = null) =>
          string.Format(Culture, Messages.UnableToResolveLibrary, library, version ?? "latest");


    }
}

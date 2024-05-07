using Antlr4.Runtime.Misc;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.Elm;
using System.Linq;
using NotNullWhenAttribute = System.Diagnostics.CodeAnalysis.NotNullWhenAttribute;
namespace Hl7.Cql.CqlToElm.Visitors
{
    internal class TypeSpecifierVisitor : Visitor<TypeSpecifier>
    {
        public LibraryBuilder LibraryBuilder { get; }
        public MessageProvider Messaging { get; }

        public TypeSpecifierVisitor(
            LibraryBuilder libraryBuilder,
            LocalIdentifierProvider localIdentifierProvider,
            InvocationBuilder invocationBuilder,
            MessageProvider messaging) : base(localIdentifierProvider, invocationBuilder)
        {
            LibraryBuilder = libraryBuilder;
            Messaging = messaging;
        }

        //     : 'Choice' '<' typeSpecifier (',' typeSpecifier)* '>'
        public override TypeSpecifier VisitChoiceTypeSpecifier([NotNull] cqlParser.ChoiceTypeSpecifierContext context)
        {
            var choice = new ChoiceTypeSpecifier
            {
                choice = context.typeSpecifier().Select(Visit).ToArray(),
            }.WithLocator(context.Locator());

            return choice;
        }

        //    : 'Interval' '<' typeSpecifier '>'
        public override TypeSpecifier VisitIntervalTypeSpecifier([NotNull] cqlParser.IntervalTypeSpecifierContext context)
        {
            var pointType = Visit(context.typeSpecifier());
            var its = new IntervalTypeSpecifier
            {
                pointType = pointType,
            }.WithLocator(context.Locator());

            return its;
        }

        //    : 'List' '<' typeSpecifier '>'
        public override TypeSpecifier VisitListTypeSpecifier([NotNull] cqlParser.ListTypeSpecifierContext context)
        {
            var elementType = Visit(context.typeSpecifier());
            var lts = new ListTypeSpecifier
            {
                elementType = elementType,
            }.WithLocator(context.Locator());

            return lts;
        }

        // : 'Tuple' '{' tupleElementDefinition (',' tupleElementDefinition)* '}'
        public override TypeSpecifier VisitTupleTypeSpecifier([NotNull] cqlParser.TupleTypeSpecifierContext context)
        {
            var tuple = new TupleTypeSpecifier
            {
                element = context.tupleElementDefinition().Select(ted => ted.Parse(this)).ToArray(),
            }.WithLocator(context.Locator());

            return tuple;
        }

        //    : (qualifier '.')* referentialOrTypeNameIdentifier
        public override TypeSpecifier VisitNamedTypeSpecifier([NotNull] cqlParser.NamedTypeSpecifierContext context)
        {
            // Could be FHIR.Patient.Contact, so the first part is the library name, and the last part(s) are the type name.
            var qualifiers = context.qualifier().Select(q => q.identifier().Parse()!).ToArray();

            var libraryName = qualifiers.FirstOrDefault();
            var typeName = string.Join(".", qualifiers.Skip(1).Append(context.referentialOrTypeNameIdentifier().Parse()));

            TryResolveNamedTypeSpecifier(LibraryBuilder.SymbolTable, 
                libraryName, typeName, out var result, out var error);

            //TODO: Might need ErrorTypeSpecifier here
            if (result is null)
                result = SystemTypes.AnyType; //new NamedTypeSpecifier($"urn:cql-unknown-type:{libraryName}", typeName);
            if (error is not null) 
                result!.AddError(error);
            
            return result.WithLocator(context.Locator());
        }

        private bool TryResolveNamedTypeSpecifier(SymbolTable symbolTable,
            string? libraryName,
            string typeName,
            out NamedTypeSpecifier? namedType,
            out string? error)
        {
            var success = TryResolveType(symbolTable, libraryName, typeName, out var result, out error);
            namedType = result?.ToNamedType();
            return success;
        }

        internal ModelType? GetModelType(UsingDefSymbol s, string name) =>
            s.Model.TryGetTypeInfoFor(name, out var typeInfo) 
            ? new ModelType(s.Model, typeInfo!) 
            : null;

        private bool TryResolveType(SymbolTable symbolTable,
            string? libraryName,
            string typeName,
            out ModelType? result,
            out string? error)
        {
            // If the typename is qualified with a library name, only look in the specified model library.
            if (libraryName is not null)
            {
                if (symbolTable.TryResolveSymbol(libraryName, out var model))
                {
                    if (model is UsingDefSymbol usingDef)
                    {
                        if (GetModelType(usingDef, typeName) is { } modelType)
                            (result, error) = (modelType, null);
                        else
                            (result, error) = (null, $"There is no type named '{typeName}' in model library {libraryName}.");
                    }
                    else
                    {
                        (result, error) = (null, $"{libraryName} is not a reference to an model library.");
                    }
                }
                else
                    (result, error) = (null, Messaging.CouldNotResolveModel(libraryName));

                return error is null;
            }

            // Else, go over all used models to find it. This could mean we find an ambiguous match.
            return TryGetMatchingTypes(symbolTable, typeName, out result, out error);
        }

        internal bool TryGetMatchingTypes(SymbolTable symbolTable, string typeName, [NotNullWhen(true)] out ModelType? result, out string? error)
        {
            var usingDefs = symbolTable.Symbols.OfType<UsingDefSymbol>().ToArray();
            var matches = usingDefs.Select(include => (include, modelType: GetModelType(include, typeName)))
                    .Where(r => r.modelType is not null).ToList();
            if (matches.Count == 1)
            {
                result = matches[0].modelType!;
                error = null;
                return true;
            }
            if (matches.Count > 1)
            {
                // Reference behavior when there is a conflict (e.g. FHIR.Quantity, System.Quantity) is to prefer the System type.
                // So, an unqualified Quantity type in a library using FHIR will resolve to System.Quantity.
                var systemMatches = matches.Where(m => m.include.Model.name == "System").ToArray();
                if (systemMatches.Length == 1)
                {
                    result = systemMatches[0].modelType!;
                    error = null;
                    return true;
                }
                else
                {
                    result = null;
                    error = $"Ambiguous type name '{typeName}', found matches in {string.Join(",", matches.Select(m => m.include.localIdentifier))}.";
                    return false;
                }
            }
            else
            {
                result = null;
                error = Messaging.NamedTypeRequiredInContext();
                return false;
            }
        }
    }
}

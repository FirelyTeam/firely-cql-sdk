using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Grammar;
using Hl7.Cql.CqlToElm.Scopes;
using Hl7.Cql.Elm;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using static System.FormattableString;

namespace Hl7.Cql.CqlToElm
{
    internal class LibraryBuilder
    {
        private static readonly VersionedIdentifier schemaIdentifier = new() { id = "urn:hl7-org:elm", version = "r1" };

        /// <summary>
        /// Creates a new instance from an existing library.  Its symbol table will be populated with its existing definitions.
        /// </summary>
        public static LibraryBuilder CreateFromExisting(Library library) => throw new NotImplementedException();

        public LibraryBuilder(VersionedIdentifier identifier, SystemLibrary systemLibrary, LocalIdentifierProvider localIdentifierProvider)
        {
            Identifier = identifier;
            SymbolTable = new SymbolTable(Identifier.ToString()!, systemLibrary);
            CurrentScope = SymbolTable;
            LocalIdentifierProvider = localIdentifierProvider;
        }

        public cqlParser? Parser { get; set; }

        public cqlLexer? Lexer { get; set; }

        public VersionedIdentifier Identifier { get; set; }
        public LocalIdentifierProvider LocalIdentifierProvider { get; }
        internal string NextId() => LocalIdentifierProvider.Next();
        /// <summary>
        /// Builds a library from the current state of the builder.
        /// </summary>
        public Library Build()
        {
            var symbols = SymbolTable;
            var expressionDefs = symbols.OfType<ExpressionDef>()
                .Concat(symbols.OfType<DeferredExpressionDef>().Select(dd => dd.Resolve()));
            var functionDefs = symbols.OfType<FunctionDef>()
                .Concat(symbols.OfType<OverloadedFunctionDef>()
                    .SelectMany(od => od.Functions.Select(f => f switch
                    {
                        FunctionDef fd => fd,
                        DeferredFunctionDef dfd => dfd.Resolve(),
                        _ => throw new NotSupportedException("Unknown function element type")
                    })))
                .Concat(symbols.OfType<DeferredFunctionDef>().Select(dfd => dfd.Resolve()));
            var statements = expressionDefs
                .Concat(functionDefs)
                .ToArray();
            return new Library
            {
                identifier = Identifier,
                schemaIdentifier = schemaIdentifier,
                usings = symbols.OfType<UsingDef>().ToArray(),
                includes = symbols.OfType<IncludeDef>().ToArray(),
                parameters = symbols.OfType<ParameterDef>().ToArray(),
                codeSystems = symbols.OfType<CodeSystemDef>().ToArray(),
                valueSets = symbols.OfType<ValueSetDef>().ToArray(),
                codes = symbols.OfType<CodeDef>().ToArray(),
                concepts = symbols.OfType<ConceptDef>().ToArray(),
                contexts = symbols.OfType<ContextDef>().ToArray(),
                statements = statements,
                annotation = errors.ToArray()
            };
        }

        private readonly List<CqlToElmError> errors = new();

        public SymbolTable SymbolTable { get; }

        public ISymbolScope CurrentScope { get; private set; }

        public void AddError(string message, ErrorType errorType) =>
            errors.Add(new CqlToElmError()
            {
                message = message,
                errorSeverity = ErrorSeverity.error,
                errorType = errorType
            });

        /// <summary>
        /// Enters a scope that is directly descended from this Library's root scope.
        /// This can be used, e.g. while evaluating function definitions to ensure that
        /// building a FunctionDef while in the midst of building another one does not allow
        /// the new FunctionDef to inherit scope values it shouldn't.
        /// </summary>
        /// <returns></returns>
        public ISymbolScope EnterStatementScope(string statement) =>
            new LibraryBuilderSubscope(this, SymbolTable.EnterScope(statement));


        public ISymbolScope EnterScope(string reason) =>
            new LibraryBuilderSubscope(this, CurrentScope.EnterScope(reason));

        [DebuggerDisplay("{Name,nq}")]
        private class LibraryBuilderSubscope : ISymbolScope
        {
            public LibraryBuilderSubscope(LibraryBuilder builder, ISymbolScope newScope)
            {
                ReturnScope = builder.CurrentScope;
                builder.CurrentScope = newScope;
                Builder = builder;
            }

            public LibraryBuilder Builder { get; }

            public ISymbolScope ReturnScope { get; init; }

            public ISymbolScope? Parent => CurrentScope.Parent;

            public IEnumerable<ReferencedLibrary> ReferencedLibraries => CurrentScope.ReferencedLibraries;

            public string Name => CurrentScope.Name;

            private ISymbolScope CurrentScope => Builder.CurrentScope;

            public void Dispose()
            {
                //Debug.WriteLine($"Exiting scope {CurrentScope.Name}");
                Builder.CurrentScope = ReturnScope;
            }

            public ISymbolScope EnterScope(string name) =>
                new LibraryBuilderSubscope(Builder, CurrentScope.EnterScope(name));

            public IEnumerator<IDefinitionElement> GetEnumerator()
            {
                return CurrentScope.GetEnumerator();
            }

            public bool TryAdd(IDefinitionElement symbol)
            {
                return CurrentScope.TryAdd(symbol);
            }

            public bool TryResolveFluentFunction(string identifier, [NotNullWhen(true)] out IFunctionElement? symbol)
            {
                return CurrentScope.TryResolveFluentFunction(identifier, out symbol);
            }

            public bool TryResolveFunction(string identifier, [NotNullWhen(true)] out IFunctionElement? symbol)
            {
                return CurrentScope.TryResolveFunction(identifier, out symbol);
            }

            public bool TryResolveSymbol(string identifier, [NotNullWhen(true)] out IDefinitionElement? symbol)
            {
                return CurrentScope.TryResolveSymbol(identifier, out symbol);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)CurrentScope).GetEnumerator();
            }
        }
    }

    internal class HtmlSyntaxTreeVisitor : cqlBaseVisitor<string>
    {
        public cqlParser? Parser { get; set; }
        public cqlLexer? Lexer { get; set; }

        public bool IncludeTokenTypes { get; set; } = true;
        public bool IncludeSourcePosition { get; set; } = true;
        public int AutoCollapseDepth { get; set; } = 10;

        private static readonly HtmlEncoder Encoder = HtmlEncoder.Create(UnicodeRanges.All);

        public string GenerateHtml(IParseTree tree)
        {
            var builder = new StringBuilder();

            builder.AppendLine("<!DOCTYPE html>");
            builder.AppendLine("<html lang=\"en\">\n<head>");
            builder.AppendLine("<meta charset=\"UTF-8\">\n<title>ANTLR Syntax Tree</title>");
            builder.AppendLine("<style>");
            builder.AppendLine("body { font-family: sans-serif; padding: 2em; background: #f9f9f9; }");
            builder.AppendLine(".syntax-tree { font-family: monospace; font-size: 14px; line-height: 1.4; padding-left: 1em; border-left: 2px solid #ccc; background: #fff; padding: 1em; box-shadow: 0 0 5px rgba(0,0,0,0.1); }");
            builder.AppendLine(".syntax-tree details { margin-left: 0.5em; }");
            builder.AppendLine(".syntax-tree summary { cursor: pointer; color: #0074d9; font-weight: bold; user-select: none; }");
            builder.AppendLine(".syntax-tree div { margin-left: 1em; white-space: pre; }");
            builder.AppendLine(".syntax-tree .error { color: #d32f2f; font-weight: bold; }");
            builder.AppendLine("</style>");
            builder.AppendLine("<script>");
            builder.AppendLine("function toggleAll(open) {");
            builder.AppendLine("  document.querySelectorAll('.syntax-tree details').forEach(d => d.open = open);");
            builder.AppendLine("}");
            builder.AppendLine("function expandOne() {");
            builder.AppendLine("  const closed = document.querySelector('.syntax-tree details:not([open])');");
            builder.AppendLine("  if (closed) closed.open = true;");
            builder.AppendLine("}");
            builder.AppendLine("function collapseOne() {");
            builder.AppendLine("  const open = document.querySelector('.syntax-tree details[open]');");
            builder.AppendLine("  if (open) open.open = false;");
            builder.AppendLine("}");
            builder.AppendLine("</script>");
            builder.AppendLine("</head><body>");
            builder.AppendLine("<h1>ANTLR Syntax Tree</h1>");
            builder.AppendLine("<div class=\"controls\" style=\"margin-bottom: 1em;\">");
            builder.AppendLine("  <button onclick=\"toggleAll(true)\">Expand All</button>");
            builder.AppendLine("  <button onclick=\"toggleAll(false)\">Collapse All</button>");
            builder.AppendLine("  <button onclick=\"expandOne()\">Expand One</button>");
            builder.AppendLine("  <button onclick=\"collapseOne()\">Collapse One</button>");
            builder.AppendLine("</div>");

            builder.Append(("<div class='syntax-tree'>"));
            builder.Append(VisitWithIndent(tree, 0));
            builder.AppendLine(("</div>"));
            builder.AppendLine("</body></html>");

            return builder.ToString();
        }

        private string VisitWithIndent(IParseTree node, int depth) =>
            node switch
            {
                IErrorNode errorNode => VisitErrorNodeWithIndent(errorNode, depth),
                ITerminalNode terminalNode => VisitTerminalWithIndent(terminalNode, depth),
                IRuleNode ruleNode => VisitChildrenWithIndent(ruleNode, depth),
                _ => string.Empty
            };

        private string Indent(int depth) => new string(' ', depth * 4);

        private string VisitChildrenWithIndent(IRuleNode node, int depth)
        {
            var ctx = node as ParserRuleContext;
            var ruleName = Parser != null && ctx != null ? Parser.RuleNames[ctx.RuleIndex] : "rule";

            var builder = new StringBuilder();
            var indent = Indent(depth);
            var open = depth < AutoCollapseDepth ? "open" : string.Empty;
            builder.Append(Invariant($"{indent}<details {open}><summary>rule: {Encoder.Encode(ruleName)}</summary>"));

            for (int i = 0; i < node.ChildCount; i++)
            {
                builder.Append(VisitWithIndent(node.GetChild(i), depth + 1));
            }

            builder.Append(Invariant($"{indent}</details>"));
            return builder.ToString();
        }

        private string VisitTerminalWithIndent(ITerminalNode node, int depth)
        {
            var token = node.Symbol;
            var indent = Indent(depth);
            if (token == null) return Invariant($"{indent}<div>token: &lt;null&gt;</div>");

            var label = new StringBuilder(Invariant($"token: {Encoder.Encode(token.Text ?? string.Empty)}"));

            if (IncludeTokenTypes)
            {
                var typeName = Lexer?.Vocabulary.GetSymbolicName(token.Type) ?? $"T{token.Type}";
                label.Append(Invariant($" ({Encoder.Encode(typeName)})"));
            }

            if (IncludeSourcePosition)
            {
                label.Append(Invariant($" [line {token.Line}, col {token.Column}]"));
            }

            return Invariant($"{indent}<div>{label}</div>");
        }

        private string VisitErrorNodeWithIndent(IErrorNode node, int depth)
        {
            var indent = Indent(depth);
            return Invariant($"{indent}<div class='error'>error: {Encoder.Encode(node.GetText())}</div>");
        }
    }

    internal static class LibraryBuilderExtensions
    {
        public static string ToHtml(
            this LibraryBuilder libraryBuilder,
            IRuleNode? obj)
        {
            if (obj == null)
                return "{}";

            var visitor = new HtmlSyntaxTreeVisitor()
            {
                Parser = libraryBuilder.Parser,
                Lexer = libraryBuilder.Lexer,
                IncludeTokenTypes = false,
                IncludeSourcePosition = false,
            };
            var mermaid = visitor.GenerateHtml(obj);
            return mermaid;
        }
    }
}
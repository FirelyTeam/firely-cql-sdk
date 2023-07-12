/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using elm = Hl7.Cql.Elm.Expressions;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// The ExpressionBuilder translates ELM <see cref="Elm.Expressions.Expression"/>s into <see cref="System.Linq.Expressions.Expression"/>.
    /// </summary>
    public partial class ExpressionBuilder
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="operators">The <see cref="OperatorBinding"/> used to invoke <see cref="CqlOperator"/>.</param>
        /// <param name="typeManager">The <see cref="TypeManager"/> used to resolve and create types referenced in <paramref name="elm"/>.</param>
        /// <param name="elm">The <see cref="ElmPackage"/> this builder will build.</param>
        /// <param name="logger">The <see cref="ILogger{ExpressionBuilder}"/> used to log all messages issued during <see cref="Build"/>.</param>
        /// <exception cref="ArgumentNullException">If any argument is <see langword="null"/></exception>
        /// <exception cref="ArgumentException">If the <paramref name="elm"/> does not have a valid library or identifier.</exception>
        public ExpressionBuilder(OperatorBinding operators,
            TypeManager typeManager,
            ElmPackage elm,
            ILogger<ExpressionBuilder> logger)
        {
            Operators = operators ?? throw new ArgumentNullException(nameof(operators));
            TypeManager = typeManager ?? throw new ArgumentNullException(nameof(typeManager));
            Package = elm ?? throw new ArgumentNullException(nameof(elm));
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            if (Package.library == null)
                throw new ArgumentException("Package is missing a library element", nameof(elm));
            if (Package.library.identifier == null)
                throw new ArgumentException("Package is missing a library identifier", nameof(elm));

        }

        /// <summary>
        /// Gets the settings used during <see cref="Build"/>.
        /// These should be set as desired before <see cref="Build"/> is called.
        /// </summary>
        public ExpressionBuilderSettings Settings { get; } = new ExpressionBuilderSettings();
        /// <summary>
        /// A dictionary which maps qualified definition names in the form of {<see cref="ElmPackage.NameAndVersion"/>}.{<see cref="elm.DefinitionExpression.name"/>}
        /// to a factory which will produce a <see cref="LambdaExpression"/> given the values of <see cref="ParameterExpression"/>.
        /// </summary>
        /// <remarks>
        /// This function can be used to provide .NET native functions in place of ELM functions, and should also be used to implement
        /// functions defined in CQL with the <code>external</code> keyword.
        /// </remarks>
        public IDictionary<string, Func<ParameterExpression[], LambdaExpression>> CustomImplementations { get; }
            = new Dictionary<string, Func<ParameterExpression[], LambdaExpression>>();
        /// <summary>
        /// The <see cref="OperatorBinding"/> used to invoke <see cref="CqlOperator"/>.
        /// </summary>
        public OperatorBinding Operators { get; }
        /// <summary>
        /// The <see cref="TypeManager"/> used to resolve and create types referenced in <paramref name="elm"/>.
        /// </summary>
        public TypeManager TypeManager { get; }
        /// <summary>
        /// The <see cref="ElmPackage"/> this builder will build.
        /// </summary>
        public ElmPackage Package { get; }
        protected internal TypeResolver TypeResolver => TypeManager.Resolver;

        protected internal ILogger<ExpressionBuilder> Logger { get; }

        /// <summary>
        /// The expression visitors that will be executed (in order) on translated expressions.
        /// </summary>
        public IList<IExpressionMutator> ExpressionMutators { get; } = new List<IExpressionMutator>();

        internal string ThisLibraryKey => Package.NameAndVersion;

        /// <summary>
        /// Builds <see cref="LambdaExpression"/>s for each definition in <see cref="Package"/>.
        /// </summary>
        /// <returns>The <see cref="DefinitionDictionary{LambdaExpression}"/> for this <see cref="Package"/>.</returns>
        /// <exception cref="InvalidOperationException">If any fatal translation errors occur.</exception>
        public DefinitionDictionary<LambdaExpression> Build()
        {
            var definitions = new DefinitionDictionary<LambdaExpression>();
            var localLibraryIdentifiers = new Dictionary<string, string>();

            var version = Package.library!.identifier!.version;
            if (string.IsNullOrWhiteSpace(version))
                version = "1.0.0";

            if (!string.IsNullOrWhiteSpace(Package.library!.identifier!.id))
            {
                var nav = ElmPackage.NameAndVersionFor(Package.library.identifier.id, version);
                if (Package?.library?.includes?.def != null)
                {
                    foreach (var def in Package!.library!.includes!.def!)
                    {
                        var alias = !string.IsNullOrWhiteSpace(def.localIdentifier)
                            ? def.localIdentifier!
                            : def.path!;

                        var lib = ElmPackage.NameAndVersionFor(def.path!, def.version);
                        if (lib != null)
                        {
                            localLibraryIdentifiers.Add(alias, lib);
                        }
                        else throw new InvalidOperationException($"Include {def.localId} does not have a well-formed name and version");
                    }
                }

                if (Package?.library?.valueSets?.def != null)
                {
                    foreach (var def in Package!.library!.valueSets!.def!)
                    {
                        var ctor = typeof(CqlValueSet).GetConstructor(new[] { typeof(string), typeof(string) });
                        var @new = Expression.New(ctor, Expression.Constant(def.id, typeof(string)), Expression.Constant(def.version, typeof(string)));
                        var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                        var lambda = Expression.Lambda(@new, contextParameter);
                        definitions.Add(ThisLibraryKey, def.name!, lambda);
                    }
                }

                if (Package?.library?.codeSystems?.def != null && Package?.library?.codes?.def != null)
                {
                    var codeSystemUrls = Package?.library?.codeSystems?.def!
                        .ToDictionary(cs => cs.name, cs => cs.id)
                        ?? new Dictionary<string?, string?>();

                    var codesByCodeSystemName = new Dictionary<string, List<CqlCode>>();
                    var codeCtor = typeof(CqlCode).GetConstructor(new Type[]
                    {
                        typeof(string),
                        typeof(string),
                        typeof(string),
                        typeof(string)
                    });

                    foreach (var code in Package?.library?.codes?.def!)
                    {
                        if (code.codeSystem == null)
                            throw new InvalidOperationException("Code definition has a null codeSystem node.");
                        if (!codesByCodeSystemName.TryGetValue(code.codeSystem!.name!, out var codings))
                        {
                            codings = new List<CqlCode>();
                            codesByCodeSystemName.Add(code.codeSystem!.name!, codings);
                        }
                        if (!codeSystemUrls.TryGetValue(code.codeSystem.name, out var csUrl))
                            throw new InvalidOperationException($"Undefined code system {code.codeSystem.name!}");
                        var existingCode = codings.SingleOrDefault(c => c.code == code.id && c.system == csUrl);
                        if (existingCode != null)
                            throw new InvalidOperationException($"Duplicate code detected: {code.id} from {code.codeSystem.name} ({csUrl})");
                        codings.Add(new CqlCode(code.id, csUrl, null, null));


                        var newCodingExpression = Expression.New(codeCtor,
                            Expression.Constant(code.id),
                            Expression.Constant(csUrl),
                            Expression.Constant(null, typeof(string)),
                            Expression.Constant(null, typeof(string))
                        );

                        var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                        var lambda = Expression.Lambda(newCodingExpression, contextParameter);
                        definitions.Add(ThisLibraryKey, code.name!, lambda);
                    }
                    foreach (var kvp in codesByCodeSystemName)
                    {
                        var initMembers = kvp.Value.Select(coding =>
                            Expression.New(codeCtor,
                                Expression.Constant(coding.code),
                                Expression.Constant(coding.system),
                                Expression.Constant(null, typeof(string)),
                                Expression.Constant(null, typeof(string))
                            )).ToArray();

                        var arrayOfCodesInitializer = Expression.NewArrayInit(typeof(CqlCode), initMembers);
                        var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                        var lambda = Expression.Lambda(arrayOfCodesInitializer, contextParameter);
                        definitions.Add(ThisLibraryKey, kvp.Key, lambda);
                    }
                }

                if (Package?.library?.parameters != null)
                {
                    foreach (var parameter in Package?.library?.parameters?.def ?? Enumerable.Empty<elm.ParameterDeclarationExpression>())
                    {
                        if (definitions.ContainsKey(null, parameter.name!))
                            throw new InvalidOperationException($"There is already a definition named {parameter.name}");

                        var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                        var buildContext = new ExpressionBuilderContext(this,
                            contextParameter,
                            definitions,
                            localLibraryIdentifiers);

                        Expression? defaultValue = null;
                        if (parameter.@default != null)
                            defaultValue = Expression.TypeAs(TranslateExpression(parameter.@default, buildContext), typeof(object));
                        else defaultValue = Expression.Constant(null, typeof(object));

                        var resolveParam = Expression.Call(
                            contextParameter,
                            typeof(CqlContext).GetMethod(nameof(CqlContext.ResolveParameter)),
                            Expression.Constant(Package!.NameAndVersion),
                            Expression.Constant(parameter.name),
                            defaultValue
                        );

                        var parameterType = TypeManager.TypeFor(parameter.parameterTypeSpecifier!, buildContext);
                        var cast = Expression.Convert(resolveParam, parameterType);
                        // e.g. (bundle, context) => context.Parameters["Measurement Period"]
                        var lambda = Expression.Lambda(cast, contextParameter);

                        definitions.Add(ThisLibraryKey, parameter.name!, lambda);
                    }
                }

                foreach (var def in Package?.library?.statements?.def ?? Enumerable.Empty<elm.DefinitionExpression>())
                {
                    if (def.expression != null)
                    {
                        var contextParameter = Expression.Parameter(typeof(CqlContext), "context");
                        var buildContext = new ExpressionBuilderContext(this,
                            contextParameter,
                            definitions,
                            localLibraryIdentifiers);

                        if (string.IsNullOrWhiteSpace(def.name))
                        {
                            var message = $"Definition with local ID {def.localId} does not have a name.  This is not allowed.";
                            buildContext.LogError(message, def);
                            throw new InvalidOperationException(message);
                        }
                        var customKey = $"{nav}.{def.name}";
                        if (!(def.external ?? false) && def.expression == null)
                        {
                            var message = $"The non-external ELM definition at {def.locator} is missing its body.  This is not allowed.";
                            buildContext.LogError(message, def);
                            throw new InvalidOperationException(message);
                        }

                        Type[] functionParameterTypes = Type.EmptyTypes;
                        var parameters = new[] { buildContext.RuntimeContextParameter };
                        if (def.operand != null)
                        {
                            functionParameterTypes = new Type[def.operand!.Length];
                            int i = 0;
                            foreach (var operand in def.operand!)
                            {
                                if (operand.operandTypeSpecifier != null)
                                {
                                    var operandType = TypeManager.TypeFor(operand.operandTypeSpecifier, buildContext, true)!;
                                    var opName = ExpressionBuilderContext.NormalizeIdentifier(operand.name);
                                    var parameter = Expression.Parameter(operandType, opName);
                                    buildContext.Operands.Add(operand.name!, parameter);
                                    functionParameterTypes[i] = parameter.Type;
                                    i += 1;
                                }
                                else throw new InvalidOperationException($"Operand for function {def.name} is missing its {nameof(operand.operandTypeSpecifier)} property");
                            }

                            parameters = parameters
                                .Concat(buildContext.Operands.Values)
                                .ToArray();
                            if (CustomImplementations.TryGetValue(customKey, out var factory) && factory != null)
                            {
                                var customLambda = factory(parameters);
                                definitions.Add(ThisLibraryKey, def.name, functionParameterTypes, customLambda);
                                continue;
                            }
                            else if (def.external ?? false)
                            {
                                var message = $"{customKey} is declared external, but {nameof(CustomImplementations)} does not define this function.";
                                buildContext.LogError(message, def);
                                if (Settings.AllowUnresolvedExternals)
                                {
                                    var returnType = TypeManager.TypeFor(def, buildContext, throwIfNotFound: true)!;
                                    var paramTypes = new[] { typeof(CqlContext) }
                                        .Concat(functionParameterTypes)
                                        .ToArray();
                                    var notImplemented = NotImplemented(customKey, paramTypes, returnType, buildContext);
                                    definitions.Add(ThisLibraryKey, def.name, paramTypes, notImplemented);
                                    continue;
                                }
                                else throw new InvalidOperationException(message);
                            }

                        }
                        buildContext = buildContext.Deeper(def);
                        if (def.name == "DateTimeUnion")
                        {
                        }
                        var bodyExpression = TranslateExpression(def.expression, buildContext);
                        var lambda = Expression.Lambda(bodyExpression, parameters);
                        if (definitions.ContainsKey(ThisLibraryKey, def.name, functionParameterTypes))
                        {
                            var ops = def.operand
                                .Where(op => op.operandTypeSpecifier != null && op.operandTypeSpecifier.resultTypeName != null)
                                .Select(op => $"{op.name} {op.operandTypeSpecifier!.resultTypeName!}");
                            var message = $"Function {def.name}({string.Join(", ", ops)}) skipped; another function matching this signature already exists.";
                            buildContext.LogWarning(message, def);
                        }
                        else
                        {
                            foreach (var annotation in def.annotation ?? Enumerable.Empty<Annotation>())
                            {
                                foreach (var tag in annotation.t ?? Enumerable.Empty<Tag>())
                                {
                                    var name = tag.name;
                                    if (!string.IsNullOrWhiteSpace(name))
                                    {
                                        var value = tag.value ?? string.Empty;
                                        definitions.AddTag(ThisLibraryKey, def.name, functionParameterTypes ?? new Type[0], name, value);

                                    }
                                }
                            }
                            definitions.Add(ThisLibraryKey, def.name, functionParameterTypes, lambda);
                        }
                    }
                    else throw new InvalidOperationException($"Definition {def.name} does not have an expression property");
                }
                return definitions;
            }
            else throw new InvalidOperationException("This package does not have a name and version.");
        }

        /// <summary>
        /// Generates a lambda expression taking a <see cref="CqlContext"/> parameter whose body is
        /// <paramref name="expression"/> translated into a <see cref="System.Linq.Expressions.Expression"/>.
        /// </summary>
        /// <remarks>
        /// This can be compiled to a <see cref="Delegate"/> and executed to resolve a value.
        /// </remarks>
        /// <param name="expression">The ELM expression to convert</param>
        /// <param name="lambdas">Existing lambdas, required if <paramref name="expression"/> contains any references to other ELM definitions</param>
        /// <param name="ctx">If <paramref name="expression"/> requires contextual scope, provide it via an <see cref="ExpressionBuilderContext"/>.</param>
        public LambdaExpression Lambda(elm.Expression expression,
            DefinitionDictionary<LambdaExpression>? lambdas = null,
            ExpressionBuilderContext? ctx = null)
        {
            var parameter = Expression.Parameter(typeof(CqlContext), "rtx");
            lambdas ??= new DefinitionDictionary<LambdaExpression>();
            ctx ??= new ExpressionBuilderContext(this, parameter, lambdas, new Dictionary<string, string>());
            lambdas = new DefinitionDictionary<LambdaExpression>();
            var translated = TranslateExpression(expression, ctx);
            var lambda = Expression.Lambda(translated, parameter);
            return lambda;
        }

        protected Expression TranslateExpression(elm.Expression op, ExpressionBuilderContext ctx)
        {
            ctx = ctx.Deeper(op);
            Expression? expression;
            switch (op)
            {
                case elm.AbsExpression abs:
                    expression = Abs(abs, ctx);
                    break;
                case elm.AddExpression add:
                    expression = Add(add, ctx);
                    break;
                case elm.AfterExpression after:
                    expression = After(after, ctx);
                    break;
                case elm.AliasRefExpression ar:
                    expression = AliasRef(ar, ctx);
                    break;
                case elm.AllTrueExpression alt:
                    expression = AllTrue(alt, ctx);
                    break;
                case elm.AndExpression and:
                    expression = And(and, ctx);
                    break;
                case elm.AsExpression @as:
                    expression = As(@as, ctx);
                    break;
                case elm.AnyTrueExpression ate:
                    expression = AnyTrue(ate, ctx);
                    break;
                case elm.AnyInValueSetExpression avs:
                    expression = AnyInValueSet(avs, ctx);
                    break;
                case elm.AvgExpression avg:
                    expression = Avg(avg, ctx);
                    break;
                case elm.BeforeExpression before:
                    expression = Before(before, ctx);
                    break;
                case elm.CalculateAgeAtExpression caa:
                    expression = CalculateAgeAt(caa, ctx);
                    break;
                case elm.CalculateAgeExpression ca:
                    expression = CalculateAge(ca, ctx);
                    break;
                case elm.CaseExpression ce:
                    expression = Case(ce, ctx);
                    break;
                case elm.CeilingExpression ceil:
                    expression = Ceiling(ceil, ctx);
                    break;
                case elm.CoalesceExpression cle:
                    expression = Coalesce(cle, ctx);
                    break;
                case elm.CodeRefExpression cre:
                    expression = CodeRef(cre, ctx);
                    break;
                case elm.CollapseExpression col:
                    expression = Collapse(col, ctx);
                    break;
                case elm.CombineExpression com:
                    expression = Combine(com, ctx);
                    break;
                case elm.ConcatenateExpression cctn:
                    expression = Concatenate(cctn, ctx);
                    break;
                case elm.ContainsExpression ct:
                    expression = Contains(ct, ctx);
                    break;
                case elm.ConvertQuantityExpression cqe:
                    expression = ConvertQuantity(cqe, ctx);
                    break;
                case elm.ConvertsToBooleanExpression ce:
                    expression = ConvertsToBoolean(ce, ctx);
                    break;
                case elm.ConvertsToDateExpression ce:
                    expression = ConvertsToDate(ce, ctx);
                    break;
                case elm.ConvertsToDateTimeExpression ce:
                    expression = ConvertsToDateTime(ce, ctx);
                    break;
                case elm.ConvertsToDecimalExpression ce:
                    expression = ConvertsToDecimal(ce, ctx);
                    break;
                case elm.ConvertsToLongExpression ce:
                    expression = ConvertsToLong(ce, ctx);
                    break;
                case elm.ConvertsToIntegerExpression ce:
                    expression = ConvertsToInteger(ce, ctx);
                    break;
                case elm.ConvertsToQuantityExpression ce:
                    expression = ConvertsToQuantity(ce, ctx);
                    break;
                case elm.ConvertsToStringExpression ce:
                    expression = ConvertsToString(ce, ctx);
                    break;
                case elm.ConvertsToTimeExpression ce:
                    expression = ConvertsToTime(ce, ctx);
                    break;
                case elm.CountExpression ce:
                    expression = Count(ce, ctx);
                    break;
                case elm.DateFromExpression dfe:
                    expression = DateFrom(dfe, ctx);
                    break;
                case elm.DateTimeExpression dt:
                    expression = DateTime(dt, ctx);
                    break;
                case elm.DateExpression d:
                    expression = Date(d, ctx);
                    break;
                case elm.DateTimeComponentFromExpression dtcf:
                    expression = DateTimeComponentFrom(dtcf, ctx);
                    break;
                case elm.DescendentsExpression desc:
                    expression = Descendents(desc, ctx);
                    break;
                case elm.DifferenceBetweenExpression dbe:
                    expression = DifferenceBetween(dbe, ctx);
                    break;
                case elm.DistinctExpression distinct:
                    expression = Distinct(distinct, ctx);
                    break;
                case elm.DivideExpression divide:
                    expression = Divide(divide, ctx);
                    break;
                case elm.DurationBetweenExpression dbe:
                    expression = DurationBetween(dbe, ctx);
                    break;
                case elm.EndExpression e:
                    expression = End(e, ctx);
                    break;
                case elm.EndsExpression e:
                    expression = Ends(e, ctx);
                    break;
                case elm.EndsWithExpression e:
                    expression = EndsWith(e, ctx);
                    break;
                case elm.EqualExpression eq:
                    expression = Equal(eq, ctx);
                    break;
                case elm.EquivalentExpression eqv:
                    expression = Equivalent(eqv, ctx);
                    break;
                case elm.ExceptExpression ex:
                    expression = Except(ex, ctx);
                    break;
                case elm.ExistsExpression ex:
                    expression = Exists(ex, ctx);
                    break;
                case elm.ExpExpression exe:
                    expression = Exp(exe, ctx);
                    break;
                case elm.ExpandExpression expand:
                    expression = Expand(expand, ctx);
                    break;
                case elm.ExpandValueSetExpression evs:
                    expression = ExpandValueSet(evs, ctx);
                    break;
                case elm.ExpressionRefExpression ere:
                    expression = ExpressionRef(ere, ctx);
                    break;
                case elm.FirstExpression first:
                    expression = First(first, ctx);
                    break;
                case elm.FlattenExpression fl:
                    expression = Flatten(fl, ctx);
                    break;
                case elm.FloorExpression floor:
                    expression = Floor(floor, ctx);
                    break;
                case elm.FunctionRefExpression fre:
                    expression = FunctionRef(fre, ctx);
                    break;
                case elm.GeometricMeanExpression gme:
                    expression = GeometricMean(gme, ctx);
                    break;
                case elm.GreaterExpression gtr:
                    expression = Greater(gtr, ctx);
                    break;
                case elm.GreaterOrEqualExpression gtre:
                    expression = GreaterOrEqual(gtre, ctx);
                    break;
                case elm.HighBoundaryExpression hb:
                    expression = HighBoundary(hb, ctx);
                    break;
                case elm.IdentifierRefExpression ire:
                    expression = IdentifierRef(ire, ctx);
                    break;
                case elm.IfExpression @if:
                    expression = If(@if, ctx);
                    break;
                case elm.IncludesExpression inc:
                    expression = Includes(inc, ctx);
                    break;
                case elm.IncludedInExpression ii:
                    expression = IncludedIn(ii, ctx);
                    break;
                case elm.IndexerExpression idx:
                    expression = Indexer(idx, ctx);
                    break;
                case elm.IndexOfExpression io:
                    expression = IndexOf(io, ctx);
                    break;
                case elm.InstanceExpression ine:
                    expression = Instance(ine, ctx);
                    break;
                case elm.IntersectExpression ise:
                    expression = Intersect(ise, ctx);
                    break;
                case elm.IntervalExpression ie:
                    expression = IntervalExpression(ie, ctx);
                    break;
                case elm.InValueSetExpression inv:
                    expression = InValueSet(inv, ctx);
                    break;
                case elm.InExpression @in:
                    expression = In(@in, ctx);
                    break;
                case elm.IsExpression @is:
                    expression = Is(@is, ctx);
                    break;
                case elm.IsFalseExpression @isn:
                    expression = IsFalse(@isn, ctx);
                    break;
                case elm.IsNullExpression @isn:
                    expression = IsNull(@isn, ctx);
                    break;
                case elm.IsTrueExpression @isn:
                    expression = IsTrue(@isn, ctx);
                    break;
                case elm.LastExpression last:
                    expression = Last(last, ctx);
                    break;
                case elm.LastPositionOfExpression lpo:
                    expression = LastPositionOf(lpo, ctx);
                    break;
                case elm.LengthExpression len:
                    expression = Length(len, ctx);
                    break;
                case elm.LessExpression less:
                    expression = Less(less, ctx);
                    break;
                case elm.LessOrEqualExpression lesse:
                    expression = LessOrEqual(lesse, ctx);
                    break;
                case elm.ListExpression list:
                    expression = List(list, ctx);
                    break;
                case elm.LiteralExpression lit:
                    expression = Literal(lit, ctx);
                    break;
                case elm.LnExpression ln:
                    expression = Ln(ln, ctx);
                    break;
                case elm.LogExpression log:
                    expression = Log(log, ctx);
                    break;
                case elm.LowBoundaryExpression lb:
                    expression = LowBoundary(lb, ctx);
                    break;
                case elm.LowerExpression e:
                    expression = Lower(e, ctx);
                    break;
                case elm.MatchesExpression e:
                    expression = Matches(e, ctx);
                    break;
                case elm.MaxExpression max:
                    expression = Max(max, ctx);
                    break;
                case elm.MaximumExpression max:
                    expression = Maximum(max, ctx);
                    break;
                case elm.MedianExpression med:
                    expression = Median(med, ctx);
                    break;
                case elm.MeetsExpression meets:
                    expression = Meets(meets, ctx);
                    break;
                case elm.MeetsBeforeExpression meets:
                    expression = MeetsBefore(meets, ctx);
                    break;
                case elm.MeetsAfterExpression meets:
                    expression = MeetsAfter(meets, ctx);
                    break;
                case elm.MessageExpression msg:
                    expression = Message(msg, ctx);
                    break;
                case elm.MinExpression min:
                    expression = Min(min, ctx);
                    break;
                case elm.MinimumExpression min:
                    expression = Minimum(min, ctx);
                    break;
                case elm.ModeExpression mode:
                    expression = Mode(mode, ctx);
                    break;
                case elm.ModuloExpression mod:
                    expression = Modulo(mod, ctx);
                    break;
                case elm.MultiplyExpression mul:
                    expression = Multiply(mul, ctx);
                    break;
                case elm.NegateExpression neg:
                    expression = Negate(neg, ctx);
                    break;
                case elm.NotExpression not:
                    expression = Not(not, ctx);
                    break;
                case elm.NowExpression now:
                    expression = Now(now, ctx);
                    break;
                case elm.NullExpression @null:
                    expression = Null(@null, ctx);
                    break;
                case elm.OperandRefExpression ore:
                    expression = OperandRef(ore, ctx);
                    break;
                case elm.OrExpression or:
                    expression = Or(or, ctx);
                    break;
                case elm.OverlapsExpression ole:
                    expression = Overlaps(ole, ctx);
                    break;
                case elm.OverlapsAfterExpression ola:
                    expression = OverlapsAfter(ola, ctx);
                    break;
                case elm.OverlapsBeforeExpression olb:
                    expression = OverlapsBefore(olb, ctx);
                    break;
                case elm.ParameterRefExpression pre:
                    expression = ParameterRef(pre, ctx);
                    break;
                case elm.PointFromExpression pf:
                    expression = PointFrom(pf, ctx);
                    break;
                case elm.PopulationStdDevExpression pstd:
                    expression = PopulationStdDev(pstd, ctx);
                    break;
                case elm.PopulationVarianceExpression pvar:
                    expression = PopulationVariance(pvar, ctx);
                    break;
                case elm.PositionOfExpression po:
                    expression = PositionOf(po, ctx);
                    break;
                case elm.PowerExpression pow:
                    expression = Power(pow, ctx);
                    break;
                case elm.PrecisionExpression pre:
                    expression = Precision(pre, ctx);
                    break;
                case elm.PredecessorExpression prd:
                    expression = Predecessor(prd, ctx);
                    break;
                case elm.ProductExpression prod:
                    expression = Product(prod, ctx);
                    break;
                case elm.ProperContainsExpression pc:
                    expression = ProperContains(pc, ctx);
                    break;
                case elm.ProperInExpression pi:
                    expression = ProperIn(pi, ctx);
                    break;
                case elm.ProperIncludesExpression pi:
                    expression = ProperIncludes(pi, ctx);
                    break;
                case elm.ProperIncludedInExpression pie:
                    expression = ProperIncludedIn(pie, ctx);
                    break;
                case elm.PropertyExpression pe:
                    expression = Property(pe, ctx);
                    break;
                case elm.QuantityExpression qua:
                    expression = Quantity(qua, ctx);
                    break;
                case elm.QueryExpression qe:
                    expression = Query(qe, ctx);
                    break;
                case elm.QueryLetRefExpression qlre:
                    expression = QueryLetRef(qlre, ctx);
                    break;
                case elm.RatioExpression re:
                    expression = Ratio(re, ctx);
                    break;
                case elm.ReplaceMatchesExpression e:
                    expression = ReplaceMatches(e, ctx);
                    break;
                case elm.RetrieveExpression re:
                    expression = Retrieve(re, ctx);
                    break;
                case elm.RoundExpression rnd:
                    expression = Round(rnd, ctx);
                    break;
                case elm.SameAsExpression sa:
                    expression = SameAs(sa, ctx);
                    break;
                case elm.SameOrAfterExpression soa:
                    expression = SameOrAfter(soa, ctx);
                    break;
                case elm.SameOrBeforeExpression sob:
                    expression = SameOrBefore(sob, ctx);
                    break;
                case elm.SingletonFromExpression sf:
                    expression = SingletonFrom(sf, ctx);
                    break;
                case elm.SliceExpression slice:
                    expression = Slice(slice, ctx);
                    break;
                case elm.SplitExpression split:
                    expression = Split(split, ctx);
                    break;
                case elm.SubstringExpression e:
                    expression = Substring(e, ctx);
                    break;
                case elm.SubtractExpression sub:
                    expression = Subtract(sub, ctx);
                    break;
                case elm.SuccessorExpression suc:
                    expression = Successor(suc, ctx);
                    break;
                case elm.SumExpression sum:
                    expression = Sum(sum, ctx);
                    break;
                case elm.StartsExpression starts:
                    expression = Starts(starts, ctx);
                    break;
                case elm.StartExpression start:
                    expression = Start(start, ctx);
                    break;
                case elm.StartsWithExpression e:
                    expression = StartsWith(e, ctx);
                    break;
                case elm.StdDevExpression stddev:
                    expression = StdDev(stddev, ctx);
                    break;
                case elm.TimeExpression time:
                    expression = Time(time, ctx);
                    break;
                case elm.TimeOfDayExpression tod:
                    expression = TimeOfDay(tod, ctx);
                    break;
                case elm.TimezoneOffsetFromExpression tofe:
                    expression = TimezoneOffsetFrom(tofe, ctx);
                    break;
                case elm.ToBooleanExpression e:
                    expression = ToBoolean(e, ctx);
                    break;
                case elm.ToConceptExpression tc:
                    expression = ToConcept(tc, ctx);
                    break;
                case elm.ToDateTimeExpression tdte:
                    expression = ToDateTime(tdte, ctx);
                    break;
                case elm.ToDateExpression tde:
                    expression = ToDate(tde, ctx);
                    break;
                case elm.TodayExpression today:
                    expression = Today(today, ctx);
                    break;
                case elm.ToDecimalExpression tde:
                    expression = ToDecimal(tde, ctx);
                    break;
                case elm.ToIntegerExpression tde:
                    expression = ToInteger(tde, ctx);
                    break;
                case elm.ToListExpression tle:
                    expression = ToList(tle, ctx);
                    break;
                case elm.ToQuantityExpression tq:
                    expression = ToQuantity(tq, ctx);
                    break;
                case elm.ToStringExpression e:
                    expression = ToString(e, ctx);
                    break;
                case elm.ToTimeExpression e:
                    expression = ToTime(e, ctx);
                    break;
                case elm.TruncateExpression trunc:
                    expression = Truncate(trunc, ctx);
                    break;
                case elm.TruncatedDivideExpression div:
                    expression = TruncatedDivide(div, ctx);
                    break;
                case elm.TupleExpression tu:
                    expression = Tuple(tu, ctx);
                    break;
                case elm.UnionExpression ue:
                    expression = Union(ue, ctx);
                    break;
                case elm.ValueSetRefExpression vsre:
                    expression = ValueSetRef(vsre, ctx);
                    break;
                case elm.VarianceExpression variance:
                    expression = Variance(variance, ctx);
                    break;
                case elm.UpperExpression e:
                    expression = Upper(e, ctx);
                    break;
                case elm.WidthExpression width:
                    expression = Width(width, ctx);
                    break;
                case elm.XorExpression xor:
                    expression = Xor(xor, ctx);
                    break;
                default: throw new NotImplementedException($"Expression {op.type} is not implemented.");
            }
            foreach (var visitor in ExpressionMutators)
            {
                if (visitor != null)
                    expression = visitor.Mutate(expression!, op, ctx);
            }
            return expression!;
        }

        protected Expression BinaryOperator(CqlOperator @operator, elm.BinaryExpression be, ExpressionBuilderContext ctx)
        {
            var lhsExpression = TranslateExpression(be.operand![0], ctx);
            var rhsExpression = TranslateExpression(be.operand![1], ctx);
            var call = Operators.Bind(@operator, ctx.RuntimeContextParameter, lhsExpression, rhsExpression);
            return call;
        }
        protected Expression UnaryOperator(CqlOperator @operator, elm.UnaryExpression unary, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(unary.operand!, ctx);
            var resultType = unary.resultTypeSpecifier != null
                ? TypeManager.TypeFor(unary.resultTypeSpecifier, ctx)
                : null;
            var call = Operators.Bind(@operator, ctx.RuntimeContextParameter, operand);
            if (resultType != null && resultType != call.Type)
            {
                var typeAs = ChangeType(call, resultType, ctx);
                return typeAs;
            }
            else
            {
                return call;
            }
        }
        protected Expression AggregateOperator(CqlOperator @operator, elm.AggregateExpression aggregate, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(aggregate.source!, ctx);
            var call = Operators.Bind(@operator, ctx.RuntimeContextParameter, operand);
            return call;
        }

        protected Expression? IdentifierRef(elm.IdentifierRefExpression ire, ExpressionBuilderContext ctx)
        {
            if (string.Equals("$this", ire.name) && ctx.ImpliedAlias != null)
            {
                var scopeExpression = ctx.GetScopeExpression(ctx.ImpliedAlias);
                return scopeExpression;
            }
            var pe = new elm.PropertyExpression
            {
                resultTypeSpecifier = ire.resultTypeSpecifier,
                resultTypeName = ire.resultTypeName,
                dataType = ire.dataType,
                localId = ire.localId,
                locator = ire.locator,
                path = ire.name,
                scope = ctx.ImpliedAlias,
                type = "Property"
            };
            var prop = Property(pe, ctx);
            return prop;
        }

        protected Expression Query(elm.QueryExpression query, ExpressionBuilderContext ctx)
        {
            if (query?.source?.Length == 0)
                throw new NotSupportedException("Queries must define at least 1 source");
            else if (query!.source!.Length == 1)
                return SingleSourceQuery(query, ctx);
            else
                return MultiSourceQuery(query, ctx);

        }

        protected Expression SingleSourceQuery(elm.QueryExpression query, ExpressionBuilderContext ctx)
        {
            var querySource = query.source![0];
            var querySourceAlias = querySource.alias;
            if (string.IsNullOrWhiteSpace(querySource.alias))
                throw new ArgumentException("Only aliased query sources are supported.", nameof(query));
            if (querySource.expression == null)
                throw new ArgumentException("Query sources must have an expression", nameof(query));
            var source = TranslateExpression(querySource.expression!, ctx);

            var isSingle = false;
            // promote single objects into enumerables so where works
            if (!IsOrImplementsIEnumerableOfT(source.Type))
            {
                var arrayInit = Expression.NewArrayInit(source.Type, source);
                source = arrayInit;
                isSingle = true;
            }
            var @return = source;
            Type elementType = TypeResolver.GetListElementType(@return.Type, @throw: true)!;

            // handle with/such-that
            if (query.relationship != null)
            {
                foreach (var relationship in query.relationship ?? Enumerable.Empty<elm.WithExpression>())
                {
                    var selectManyLambda = WithToSelectManyBody(querySourceAlias!, elementType, relationship, ctx);

                    var selectManyCall = Operators.Bind(CqlOperator.SelectMany, ctx.RuntimeContextParameter,
                        @return, selectManyLambda);
                    if (string.Equals(relationship.type, "Without", StringComparison.OrdinalIgnoreCase))
                    {
                        var callExcept = Operators.Bind(CqlOperator.ListExcept, ctx.RuntimeContextParameter,
                            @return, selectManyCall);
                        @return = callExcept;
                    }
                    else
                    {
                        @return = selectManyCall;
                    }
                }
            }
            // The element type may have changed
            elementType = TypeResolver.GetListElementType(@return.Type, @throw: true)!;

            if (query.where != null)
            {
                var parameterName = ExpressionBuilderContext.NormalizeIdentifier(querySourceAlias)
                    ?? TypeNameToIdentifier(elementType, ctx);
                var whereLambdaParameter = Expression.Parameter(elementType, parameterName);
                if (querySourceAlias == "ItemOnLine")
                {
                }
                var scopes = new[] { new KeyValuePair<string, (Expression, elm.Expression)>(querySourceAlias!, (whereLambdaParameter, querySource.expression)) };
                var subContext = ctx.WithScopes(scopes);

                if (query.let != null)
                {
                    var letScopes = new KeyValuePair<string, (Expression, elm.Expression)>[query.let.Length];
                    for (int i = 0; i < query.let.Length; i++)
                    {
                        var let = query.let[i];
                        var expression = TranslateExpression(let.expression!, subContext);
                        letScopes[i] = new KeyValuePair<string, (Expression, elm.Expression)>(let.identifier!, (expression, let.expression!));
                    }
                    subContext = subContext.WithScopes(letScopes);
                }
                var whereBody = TranslateExpression(query.where, subContext);
                var whereLambda = System.Linq.Expressions.Expression.Lambda(whereBody, whereLambdaParameter);
                var callWhere = Operators.Bind(CqlOperator.Where, ctx.RuntimeContextParameter, @return, whereLambda);
                @return = callWhere;
            }

            if (query.@return != null)
            {
                var parameterName = ExpressionBuilderContext.NormalizeIdentifier(querySourceAlias)
                ?? TypeNameToIdentifier(elementType, ctx);


                var selectLambdaParameter = Expression.Parameter(elementType, parameterName);

                var scopes = new[] { new KeyValuePair<string, (Expression, elm.Expression)>(querySourceAlias!, (selectLambdaParameter, query.@return)) };
                var subContext = ctx.WithScopes(scopes);

                if (query.let != null)
                {
                    for (int i = 0; i < query.let.Length; i++)
                    {
                        var let = query.let[i];
                        var expression = TranslateExpression(let.expression!, subContext);
                        subContext = subContext.WithScopes(new KeyValuePair<string, (Expression, elm.Expression)>(let.identifier!, (expression, let.expression!)));
                    }
                }
                var selectBody = TranslateExpression(query.@return.expression!, subContext);
                var selectLambda = Expression.Lambda(selectBody, selectLambdaParameter);
                var callSelect = Operators.Bind(CqlOperator.Select, ctx.RuntimeContextParameter, @return, selectLambda);
                @return = callSelect;
            }

            if (query.aggregate != null)
            {
                var parameterName = ExpressionBuilderContext.NormalizeIdentifier(querySourceAlias)
                ?? TypeNameToIdentifier(elementType, ctx);
                var sourceAliasParameter = Expression.Parameter(elementType, parameterName);
                var resultAlias = query.aggregate.identifier!;
                Type? resultType = null;
                if (query.aggregate.resultTypeSpecifier != null)
                {
                    resultType = TypeManager.TypeFor(query.aggregate.resultTypeSpecifier, ctx, true);
                }
                else if (!string.IsNullOrWhiteSpace(query.aggregate.resultTypeName!))
                {
                    resultType = TypeResolver.ResolveType(query.aggregate.resultTypeName!);
                }
                if (resultType == null)
                {
                    throw new InvalidOperationException($"Could not resolve aggregate query result type for query {query.localId} at {query.locator}");
                }
                var resultParameter = Expression.Parameter(resultType, resultAlias);
                var scopes = new[]
                {
                        new KeyValuePair<string, (Expression, elm.Expression)>(querySourceAlias!, (sourceAliasParameter, query)),
                        new KeyValuePair<string, (Expression, elm.Expression)>(resultAlias!, (resultParameter, query.aggregate))
                    };
                var subContext = ctx.WithScopes(scopes);
                if (query.let != null)
                {
                    for (int i = 0; i < query.let.Length; i++)
                    {
                        var let = query.let[i];
                        var expression = TranslateExpression(let.expression!, subContext);
                        subContext = subContext.WithScopes(new KeyValuePair<string, (Expression, elm.Expression)>(let.identifier!, (expression, let.expression!)));
                    }
                }
                var startingValue = TranslateExpression(query.aggregate.starting!, subContext);

                var lambdaBody = TranslateExpression(query.aggregate.expression!, subContext);
                var lambda = Expression.Lambda(lambdaBody, resultParameter, sourceAliasParameter);
                var aggregateCall = Operators.Bind(CqlOperator.Aggregate, subContext.RuntimeContextParameter, @return, lambda, startingValue);
                @return = aggregateCall;
            }

            if (query.sort != null && query.sort.by != null && query.sort.by.Length > 0)
            {
                foreach (var by in query.sort.by)
                {
                    var order = SortOrder.Ascending;
                    if (by.direction == "desc" || by.direction == "descending")
                        order = SortOrder.Descending;
                    else if (by.direction == "asc" || by.direction == "ascending")
                        order = SortOrder.Ascending;
                    else throw new InvalidOperationException($"Invalid sort order {by.direction}");

                    if (by.expression != null)
                    {
                        var parameterName = "@this";
                        var returnElementType = TypeResolver.GetListElementType(@return.Type);
                        var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                        var subContext = ctx.WithImpliedAlias(parameterName!, sortMemberParameter, by.expression);
                        var sortMemberExpression = TranslateExpression(by.expression, subContext);
                        var lambdaBody = Expression.Convert(sortMemberExpression, typeof(object));
                        var sortLambda = System.Linq.Expressions.Expression.Lambda(lambdaBody, sortMemberParameter);
                        var sort = Operators.Bind(CqlOperator.SortBy, ctx.RuntimeContextParameter,
                            @return, sortLambda, Expression.Constant(order, typeof(SortOrder)));
                        @return = sort;
                    }
                    else if (by.path != null && by.resultTypeName != null)
                    {
                        var parameterName = "@this";
                        var returnElementType = TypeResolver.GetListElementType(@return.Type);
                        var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                        var pathMemberType = TypeResolver.ResolveType(by.resultTypeName);
                        if (pathMemberType == null)
                        {
                            var msg = $"Type specifier {by.resultTypeName} at {by.locator ?? "unknown"} could not be resolved.";
                            ctx.LogError(msg);
                            throw new InvalidOperationException(msg);
                        }
                        var pathExpression = PropertyHelper(sortMemberParameter, by.path, pathMemberType!, ctx);
                        var lambdaBody = Expression.Convert(pathExpression, typeof(object));
                        var sortLambda = System.Linq.Expressions.Expression.Lambda(lambdaBody, sortMemberParameter);
                        var sort = Operators.Bind(CqlOperator.SortBy, ctx.RuntimeContextParameter,
                            @return, sortLambda, Expression.Constant(order, typeof(SortOrder)));
                        @return = sort;
                    }
                    else
                    {
                        var sort = Operators.Bind(CqlOperator.Sort, ctx.RuntimeContextParameter,
                            @return, Expression.Constant(order, typeof(SortOrder)));
                        @return = sort;
                    }
                }
            }

            if (isSingle)
            {
                var callSingle = Operators.Bind(CqlOperator.Single, ctx.RuntimeContextParameter, @return);
                @return = callSingle;
            }

            return @return;
        }
        protected Expression MultiSourceQuery(elm.QueryExpression query, ExpressionBuilderContext ctx)
        {
            // The technique here is to create a cross product of all the query sources.
            // The combinations will be stored in a tuple whose fields are named by source alias.
            // we will then create an expression that creates this cross-product of tuples,
            // and use that as the singular query source for subsequent parts of the query.
            var tupleSpecifier = new elm.TypeSpecifierExpression
            {
                name = "TupleTypeSpecifier",
                element = query.source.Select(source => new elm.TupleElementDefinition
                {
                    name = source.alias ?? throw new InvalidOperationException("Missing alias for multi-source query; this is illegal"),
                    elementType = source.resultTypeSpecifier,

                }).ToArray(),
            };
            var multiSourceTupleType = TypeManager.TupleTypeFor(tupleSpecifier, ctx, (type) =>
                IsOrImplementsIEnumerableOfT(type)
                    ? TypeResolver.GetListElementType(type, true)!
                    : throw new NotSupportedException("Query sources must be lists."));
            var crossJoinedSource = CrossJoin(query.source!, multiSourceTupleType, ctx);
            var source = crossJoinedSource;

            var isSingle = false;
            if (!IsOrImplementsIEnumerableOfT(source.Type))
            {
                var arrayInit = Expression.NewArrayInit(source.Type, source);
                source = arrayInit;
                isSingle = true;
            }

            var @return = source;
            if (query.relationship != null)
            {
                foreach (var relationship in query.relationship ?? Enumerable.Empty<elm.WithExpression>())
                {
                    var selectManyLambda = WithToSelectManyBody(multiSourceTupleType, relationship, ctx);

                    var selectManyCall = Operators.Bind(CqlOperator.SelectMany, ctx.RuntimeContextParameter,
                        @return, selectManyLambda);
                    if (string.Equals(relationship.type, "Without", StringComparison.OrdinalIgnoreCase))
                    {
                        var callExcept = Operators.Bind(CqlOperator.ListExcept, ctx.RuntimeContextParameter,
                            @return, selectManyCall);
                        @return = callExcept;
                    }
                    else
                    {
                        @return = selectManyCall;
                    }
                }
            }

            var elementType = TypeResolver.GetListElementType(@return.Type, true)!;
            if (query.where != null)
            {
                var parameterName = TypeNameToIdentifier(elementType, ctx);

                var whereLambdaParameter = Expression.Parameter(multiSourceTupleType, parameterName);
                var scopes =
                    (
                        from property in multiSourceTupleType!.GetProperties()
                        let propertyAccess = Expression.Property(whereLambdaParameter, property)
                        select new KeyValuePair<string, (Expression, elm.Expression)>(property.Name, (propertyAccess, query.@where))
                    )
                    .ToArray();
                var subContext = ctx.WithScopes(scopes);


                if (query.let != null)
                {
                    var letScopes = new KeyValuePair<string, (Expression, elm.Expression)>[query.let.Length];
                    for (int i = 0; i < query.let.Length; i++)
                    {
                        var let = query.let[i];
                        var expression = TranslateExpression(let.expression!, subContext);
                        letScopes[i] = new KeyValuePair<string, (Expression, elm.Expression)>(let.identifier!, (expression, let.expression!));
                    }
                    subContext = subContext.WithScopes(letScopes);
                }

                var whereBody = TranslateExpression(query.where, subContext);
                var whereLambda = System.Linq.Expressions.Expression.Lambda(whereBody, whereLambdaParameter);
                var callWhere = Operators.Bind(CqlOperator.Where, ctx.RuntimeContextParameter, @return, whereLambda);
                @return = callWhere;
            }



            if (query.@return != null)
            {
                var parameterName = TypeNameToIdentifier(elementType, ctx);
                var selectLambdaParameter = Expression.Parameter(elementType, parameterName);

                var scopes =
                    (
                        from property in multiSourceTupleType!.GetProperties()
                        let propertyAccess = Expression.Property(selectLambdaParameter, property)
                        select new KeyValuePair<string, (Expression, elm.Expression)>(property.Name, (propertyAccess, query.@return))
                    )
                    .ToArray();
                var subContext = ctx.WithScopes(scopes);

                if (query.let != null)
                {
                    var letScopes = new KeyValuePair<string, (Expression, elm.Expression)>[query.let.Length];
                    for (int i = 0; i < query.let.Length; i++)
                    {
                        var let = query.let[i];
                        var expression = TranslateExpression(let.expression!, subContext);
                        subContext = subContext.WithScopes(new KeyValuePair<string, (Expression, elm.Expression)>(let.identifier!, (expression, let.expression!)));
                    }
                }
                var selectBody = TranslateExpression(query.@return.expression!, subContext);
                var selectLambda = Expression.Lambda(selectBody, selectLambdaParameter);
                var callSelect = Operators.Bind(CqlOperator.Select, ctx.RuntimeContextParameter, @return, selectLambda);
                @return = callSelect;
            }

            if (query.aggregate != null)
            {
                if (query.aggregate!.type == "AggregateClause")
                {
                    var parameterName = TypeNameToIdentifier(elementType, ctx);
                    var sourceParameter = Expression.Parameter(multiSourceTupleType, parameterName);
                    var scopes =
                        (
                            from property in multiSourceTupleType!.GetProperties()
                            let propertyAccess = Expression.Property(sourceParameter, property)
                            select new KeyValuePair<string, (Expression, elm.Expression)>(property.Name, (propertyAccess, query))
                        )
                        .ToArray();
                    var subContext = ctx.WithScopes(scopes);

                    var resultAlias = query.aggregate.identifier!;
                    Type? resultType = null;
                    if (query.aggregate.resultTypeSpecifier != null)
                    {
                        resultType = TypeManager.TypeFor(query.aggregate.resultTypeSpecifier, ctx, true);
                    }
                    else if (!string.IsNullOrWhiteSpace(query.aggregate.resultTypeName!))
                    {
                        resultType = TypeResolver.ResolveType(query.aggregate.resultTypeName!);
                    }
                    if (resultType == null)
                    {
                        throw new InvalidOperationException($"Could not resolve aggregate query result type for query {query.localId} at {query.locator}");
                    }
                    var resultParameter = Expression.Parameter(resultType, resultAlias);

                    subContext = subContext.WithScopes(new KeyValuePair<string, (Expression, elm.Expression)>(resultAlias!, (resultParameter, query.aggregate)));

                    if (query.let != null)
                    {
                        var letScopes = new KeyValuePair<string, (Expression, elm.Expression)>[query.let.Length];
                        for (int i = 0; i < query.let.Length; i++)
                        {
                            var let = query.let[i];
                            var expression = TranslateExpression(let.expression!, subContext);
                            letScopes[i] = new KeyValuePair<string, (Expression, elm.Expression)>(let.identifier!, (expression, let.expression!));
                        }
                        subContext = subContext.WithScopes(letScopes);
                    }

                    var startingValue = TranslateExpression(query.aggregate.starting!, subContext);

                    var lambdaBody = TranslateExpression(query.aggregate.expression!, subContext);
                    var lambda = Expression.Lambda(lambdaBody, resultParameter, sourceParameter);
                    var aggregateCall = Operators.Bind(CqlOperator.Aggregate, subContext.RuntimeContextParameter, @return, lambda, startingValue);
                    @return = aggregateCall;
                }
                else
                {
                    throw new NotImplementedException($"Aggregate type {query.aggregate.type} is not yet implemented.");
                }
            }

            if (query.sort != null && query.sort.by != null && query.sort.by.Length > 0)
            {
                foreach (var by in query.sort.by)
                {
                    var order = SortOrder.Ascending;
                    if (by.direction == "desc" || by.direction == "descending")
                        order = SortOrder.Descending;
                    else if (by.direction == "asc" || by.direction == "ascending")
                        order = SortOrder.Ascending;
                    else throw new InvalidOperationException($"Invalid sort order {by.direction}");

                    if (by.expression != null)
                    {
                        var parameterName = "@this";
                        var returnElementType = TypeResolver.GetListElementType(@return.Type);
                        var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                        var subContext = ctx.WithImpliedAlias(parameterName!, sortMemberParameter, by.expression);
                        var sortMemberExpression = TranslateExpression(by.expression, subContext);
                        var lambdaBody = Expression.Convert(sortMemberExpression, typeof(object));
                        var sortLambda = System.Linq.Expressions.Expression.Lambda(lambdaBody, sortMemberParameter);
                        var sort = Operators.Bind(CqlOperator.SortBy, ctx.RuntimeContextParameter,
                            @return, sortLambda, Expression.Constant(order, typeof(SortOrder)));
                        @return = sort;
                    }
                    else if (by.path != null && by.resultTypeName != null)
                    {
                        var parameterName = "@this";
                        var returnElementType = TypeResolver.GetListElementType(@return.Type);
                        var sortMemberParameter = Expression.Parameter(returnElementType, parameterName);
                        var pathMemberType = TypeResolver.ResolveType(by.resultTypeName);
                        if (pathMemberType == null)
                        {
                            var msg = $"Type specifier {by.resultTypeName} at {by.locator ?? "unknown"} could not be resolved.";
                            ctx.LogError(msg);
                            throw new InvalidOperationException(msg);
                        }
                        var pathExpression = PropertyHelper(sortMemberParameter, by.path, pathMemberType!, ctx);
                        var lambdaBody = Expression.Convert(pathExpression, typeof(object));
                        var sortLambda = System.Linq.Expressions.Expression.Lambda(lambdaBody, sortMemberParameter);
                        var sort = Operators.Bind(CqlOperator.SortBy, ctx.RuntimeContextParameter,
                            @return, sortLambda, Expression.Constant(order, typeof(SortOrder)));
                        @return = sort;
                    }
                    else
                    {
                        var sort = Operators.Bind(CqlOperator.Sort, ctx.RuntimeContextParameter,
                            @return, Expression.Constant(order, typeof(SortOrder)));
                        @return = sort;
                    }
                }
            }

            if (isSingle)
            {
                var returnElementType = TypeResolver.GetListElementType(@return.Type);
                var callSingle = Operators.Bind(CqlOperator.Single, ctx.RuntimeContextParameter, @return);
                @return = callSingle;
            }

            return @return;
        }

        protected bool IsOrImplementsIEnumerableOfT(Type type) => TypeResolver.ImplementsGenericInterface(type, typeof(IEnumerable<>));

        protected Expression ValueSetRef(elm.ValueSetRefExpression valueSetRef, ExpressionBuilderContext ctx)
        {
            if (string.IsNullOrWhiteSpace(valueSetRef.name))
                throw new ArgumentException($"The ValueSetRef at {valueSetRef.locator} is missing a name.", nameof(valueSetRef));
            var type = TypeManager.TypeFor(valueSetRef, ctx, throwIfNotFound: true)!;
            var cqlValueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name, valueSetRef.libraryName, typeof(CqlValueSet), ctx);

            if (IsOrImplementsIEnumerableOfT(type))
            {
                var elementType = TypeResolver.GetListElementType(type);
                if (elementType == typeof(CqlCode))
                {
                    var ctor = typeof(ValueSetFacade).GetConstructor(new[] { typeof(CqlValueSet), typeof(CqlContext) });
                    var @new = Expression.New(ctor, cqlValueSet, ctx.RuntimeContextParameter);
                    return @new;
                }
                else
                {
                    var message = $"The expected type for value set {valueSetRef.name} in this context is {TypeManager.PrettyTypeName(type)}";
                    ctx.LogError(message, valueSetRef);
                    throw new InvalidOperationException(message);
                }
            }
            return cqlValueSet;
        }

        protected Expression QueryLetRef(elm.QueryLetRefExpression qlre, ExpressionBuilderContext ctx)
        {
            var name = qlre.name!;
            var expr = ctx.GetScopeExpression(name);
            return expr;
        }

        protected Expression AliasRef(elm.AliasRefExpression ar, ExpressionBuilderContext ctx)
        {
            var expr = ctx.GetScopeExpression(ar.name!);
            return expr;
        }

        protected Expression Tuple(elm.TupleExpression tuple, ExpressionBuilderContext ctx)
        {
            var tupleType = TypeManager.TupleTypeFor(tuple.resultTypeSpecifier!, ctx);
            var @new = Expression.New(tupleType);
            if (tuple.element?.Length > 0)
            {
                var elementBindings = (tuple.element!)
                               .Select(element =>
                               {
                                   var value = TranslateExpression(element.value!, ctx);
                                   var memberInfo = GetProperty(tupleType, ExpressionBuilderContext.NormalizeIdentifier(element.name!)!);
                                   var binding = Binding(value, memberInfo, ctx);
                                   return binding;
                               })
                               .ToArray();
                var init = Expression.MemberInit(@new, elementBindings);
                return init;
            }
            else return @new;
        }

        protected Expression List(elm.ListExpression list, ExpressionBuilderContext ctx)
        {
            if (list.resultTypeSpecifier == null)
                throw new ArgumentException($"List is missing a result type specifier.", nameof(list));
            if (list.resultTypeSpecifier.type != "ListTypeSpecifier" || list.resultTypeSpecifier.elementType == null)
                throw new ArgumentException($"List is the wrong type or missing an elementType property", nameof(list));

            var elementType = TypeManager.TypeFor(list.resultTypeSpecifier.elementType, ctx, true);
            var elements = list.element?
                .Select(ele => TranslateExpression(ele, ctx))
                .ToArray() ?? new Expression[0];
            if (!IsNullable(elementType) && elements.Any(exp => IsNullable(exp.Type)))
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i] = HandleNullable(elements[i], elementType);

                }
            }
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Type != elementType)
                {
                    elements[i] = Expression.TypeAs(elements[i], elementType);
                }
            }
            Expression? array = null;
            if (elements != null)
            {
                array = Expression.NewArrayInit(elementType, elements);
            }
            else
            {
                array = Expression.NewArrayBounds(elementType, Expression.Constant(0));
            }
            var asEnumerable = Expression.TypeAs(array, typeof(IEnumerable<>).MakeGenericType(elementType));
            return asEnumerable;
        }

        protected Expression CodeRef(elm.CodeRefExpression cre, ExpressionBuilderContext ctx)
        {
            if (!string.IsNullOrWhiteSpace(cre.name))
            {
                var type = TypeResolver.ResolveType(cre.resultTypeName!)
                    ?? throw new InvalidOperationException($"Unable to resolve type {cre.resultTypeName}");
                return InvokeDefinitionThroughRuntimeContext(cre.name, cre.libraryName, type!, ctx);
            }
            else throw new InvalidOperationException($"CodeRefExpression {cre.name} is null");
        }

        protected Expression Instance(elm.InstanceExpression ine, ExpressionBuilderContext ctx)
        {
            var instanceType = TypeResolver.ResolveType(ine.classType!);
            if (instanceType!.IsEnum)
            {
                // constructs like:
                // FHIR.RemittanceOutcome {value: 'complete'}
                // FHIR.RemittanceOutcome maps to an enum type
                if (ine.element?.Length == 1 && string.Equals(ine.element![0].name, "value", StringComparison.OrdinalIgnoreCase))
                {
                    var enumValueValue = TranslateExpression(ine.element[0]!.value!, ctx);
                    if (enumValueValue.Type == instanceType)
                        return enumValueValue;
                    else if (enumValueValue.Type == typeof(string))
                    {
                        var parseMethod = typeof(Enum).GetMethods()
                            .Where(m =>
                                m.Name == nameof(Enum.Parse)
                                && m.GetParameters().Length == 3)
                            .Single();
                        var callEnumParse = Expression.Call(parseMethod, Expression.Constant(instanceType), enumValueValue, Expression.Constant(true));
                        return callEnumParse;
                    }
                }
            }
            // Prefer a constructor will all parameters.


            //var valueTypes = values
            //    .Select(v => v.Type)
            //    .ToArray();
            //var allConstructors = instanceType!
            //    .GetConstructors();
            //ConstructorInfo? allParamsCtor = null;
            //foreach(var ctor in allConstructors)
            //{
            //    var ctorParameters = ctor.GetParameters();
            //    if (ctorParameters.Length == valueTypes.Length)
            //    {
            //        if (ctorParameters.All(p => p.T))
            //    }
            //}

            var tuples = ine.element
                .Select(el => (el.name!, TranslateExpression(el.value!, ctx)))
                .ToArray();

            // Handle immutable primitives without public setters on their properties.
            if (instanceType == typeof(CqlRatio))
            {
                Expression? numeratorExpr = null;
                Expression? denominatorExpr = null;

                foreach (var tuple in tuples)
                {
                    if (tuple.Item1 == "numerator")
                        numeratorExpr = tuple.Item2;
                    else if (tuple.Item1 == "denominator")
                        denominatorExpr = tuple.Item2;
                    else throw new InvalidOperationException($"No property called {tuple.Item1} should exist on {nameof(CqlRatio)}");
                }
                var ctor = typeof(CqlRatio).GetConstructor(new[] { typeof(CqlQuantity), typeof(CqlQuantity) });
                var @new = Expression.New(ctor,
                    numeratorExpr ?? Expression.Default(typeof(CqlQuantity)),
                    denominatorExpr ?? Expression.Default(typeof(CqlQuantity)));
                return @new;
            }
            else if (instanceType == typeof(CqlCode))
            {
                Expression? codeExpr = null;
                Expression? systemExpr = null;
                Expression? versionExpr = null;
                Expression? displayExpr = null;


                foreach (var tuple in tuples)
                {
                    if (tuple.Item1 == "code")
                        codeExpr = tuple.Item2;
                    else if (tuple.Item1 == "system")
                        systemExpr = tuple.Item2;
                    else if (tuple.Item1 == "version")
                        versionExpr = tuple.Item2;
                    else if (tuple.Item1 == "display")
                        displayExpr = tuple.Item2;
                    else throw new InvalidOperationException($"No property called {tuple.Item1} should exist on {nameof(CqlCode)}");
                }
                var ctor = typeof(CqlCode).GetConstructor(new[] {
                    typeof(string),
                    typeof(string),
                    typeof(string),
                    typeof(string)
                });
                var @new = Expression.New(ctor,
                    codeExpr ?? Expression.Default(typeof(string)),
                    systemExpr ?? Expression.Default(typeof(string)),
                    versionExpr ?? Expression.Default(typeof(string)),
                    displayExpr ?? Expression.Default(typeof(string)));
                return @new;
            }
            else if (instanceType == typeof(CqlConcept))
            {
                Expression? codesExpr = null;
                Expression? displayExpr = null;

                foreach (var tuple in tuples)
                {
                    if (tuple.Item1 == "codes")
                        codesExpr = tuple.Item2;
                    else if (tuple.Item1 == "display")
                        displayExpr = tuple.Item2;
                    else throw new InvalidOperationException($"No property called {tuple.Item1} should exist on {nameof(CqlConcept)}");
                }
                var ctor = typeof(CqlConcept).GetConstructor(new[] { typeof(IEnumerable<CqlCode>), typeof(string) });
                var @new = Expression.New(ctor,
                    codesExpr ?? Expression.Default(typeof(IEnumerable<CqlCode>)),
                    displayExpr ?? Expression.Default(typeof(string)));
                return @new;
            }
            else
            {
                var elementBindings = new MemberAssignment[tuples.Length];
                for (int i = 0; i < tuples.Length; i++)
                {
                    var tuple = tuples[i];
                    var element = tuple.Item1;
                    var expression = tuple.Item2;
                    var memberInfo = GetProperty(instanceType!, element);
                    if (memberInfo == null)
                        throw new InvalidOperationException($"Could not find member {element} on type {TypeManager.PrettyTypeName(instanceType!)}");
                    var binding = Binding(expression, memberInfo, ctx);
                    elementBindings[i] = binding;
                }
                var ctor = instanceType!.GetConstructor(Type.EmptyTypes);
                var @new = Expression.New(ctor);
                var init = Expression.MemberInit(@new, elementBindings);
                return init;
            }
        }

        protected MemberAssignment Binding(Expression value, MemberInfo memberInfo, ExpressionBuilderContext ctx)
        {
            if (memberInfo is PropertyInfo property)
            {
                if (value.Type == property.PropertyType)
                {
                    return Expression.Bind(memberInfo, value);
                }
                else if (property.PropertyType.IsArray)
                {
                    if (value.Type.IsArray)
                    {
                        if (property.PropertyType.GetElementType() == value.Type.GetElementType())
                        {
                            return Expression.Bind(memberInfo, value);
                        }
                    }
                    else if (value.Type.IsGenericType)
                    {
                        var valueEnumerableElement = TypeResolver.GetListElementType(value.Type);
                        var memberArrayElement = property.PropertyType.GetElementType();
                        if (valueEnumerableElement == memberArrayElement)
                        {
                            var toArrayMethod = typeof(Enumerable)
                                .GetMethod(nameof(Enumerable.ToArray))
                                .MakeGenericMethod(valueEnumerableElement);
                            var callToArray = Expression.Call(toArrayMethod, value);
                            return Expression.Bind(memberInfo, callToArray);
                        }
                        else
                        {
                            var selectParameter = Expression.Parameter(valueEnumerableElement, TypeNameToIdentifier(value.Type, ctx));
                            var body = ChangeType(selectParameter, memberArrayElement, ctx);
                            var selectLambda = Expression.Lambda(body, selectParameter);
                            var callSelectMethod = Operators.Bind(CqlOperator.Select, ctx.RuntimeContextParameter, value, selectLambda);
                            var toArrayMethod = typeof(Enumerable)
                                .GetMethod(nameof(Enumerable.ToArray))
                                .MakeGenericMethod(memberArrayElement);
                            var callToArray = Expression.Call(toArrayMethod, callSelectMethod);
                            return Expression.Bind(memberInfo, callToArray);
                        }
                    }
                }
                else if (TypeResolver.ImplementsGenericInterface(property.PropertyType, typeof(ICollection<>)))
                {
                    if (IsOrImplementsIEnumerableOfT(value.Type))
                    {
                        var elementType = TypeResolver.GetListElementType(property.PropertyType);
                        var listType = typeof(List<>).MakeGenericType(elementType);
                        var ctor = listType.GetConstructor(new[] { typeof(IEnumerable<>).MakeGenericType(elementType) });
                        var newList = Expression.New(ctor, value);
                        return Expression.Bind(memberInfo, newList);
                    }
                }
                var convert = ChangeType(value, property.PropertyType, ctx);
                return Expression.Bind(memberInfo, convert);
            }
            else throw new NotImplementedException();
        }

        protected bool IsConvertible(Type from, Type to)
        {
            if (from == to)
                return true;
            if (to.IsAssignableFrom(from))
                return true;
            if (IsNullable(from) && !IsNullable(to))
                return true;
            if (IsOrImplementsIEnumerableOfT(from) && IsOrImplementsIEnumerableOfT(to))
            {
                var fromElement = TypeResolver.GetListElementType(from, @throw: true)!;
                var toElement = TypeResolver.GetListElementType(to, @throw: true)!;
                return IsConvertible(fromElement, toElement);
            }
            return false;
        }

        protected Expression If(elm.IfExpression @if, ExpressionBuilderContext ctx)
        {
            var rc = TranslateExpression(@if.condition!, ctx);
            var condition = Expression.Coalesce(rc, Expression.Constant(false, typeof(bool)));
            var then = TranslateExpression(@if.then!, ctx);
            if (@if.@else != null)
            {
                var @else = TranslateExpression(@if.@else!, ctx);
                if (then.Type.IsValueType)
                {
                    @else = HandleNullable(@else, then.Type);
                }
                if (then.Type != @else.Type)
                    throw new InvalidOperationException($"The If expression at {@if.locator} produces two branches with different types.");
                var ifThenElse = Expression.Condition(condition, then, @else);
                return ifThenElse;
            }
            else
            {
                var ifThen = Expression.Condition(condition, then, Expression.Convert(Expression.Constant(null), then.Type));
                return ifThen;
            }
        }

        protected Expression Null(elm.NullExpression @null, ExpressionBuilderContext ctx)
        {
            var nullType = TypeManager.TypeFor(@null, ctx, false) ?? typeof(object);
            var constant = Expression.Constant(null, nullType);
            return constant;
        }

        protected Expression Literal(elm.LiteralExpression lit, ExpressionBuilderContext ctx)
        {
            var type = TypeResolver.ResolveType(lit.valueType!)
                ?? throw new InvalidOperationException($"Cannot resolve type for {lit.valueType}");
            var (value, convertedType) = ConvertLiteral(lit, type);

            if (IsNullable(type))
            {
                var changed = Expression.Constant(value, convertedType);
                var asNullable = Expression.Convert(changed, type);
                return asNullable;
            }
            return Expression.Constant(value, convertedType);
        }

        public static (object?, Type) ConvertLiteral(elm.LiteralExpression lit, Type? type)
        {
            if (type == null)
                throw new NotImplementedException();
            else if (IsNullable(type))
            {
                if (string.IsNullOrWhiteSpace(lit.value))
                    return (null, type);
                else
                {
                    var underlyingType = Nullable.GetUnderlyingType(type);
                    if (typeof(IConvertible).IsAssignableFrom(underlyingType))
                    {
                        try
                        {
                            var converted = Convert.ChangeType(lit.value, underlyingType);
                            return (converted, underlyingType);
                        }
                        catch (OverflowException)
                        {
                            return (null, type);
                        }
                    }
                    else throw new NotSupportedException("Only convertible types can be used for literals.");
                }
            }
            else
            {
                if (type == typeof(string))
                    return (lit.value, type);
                if (typeof(IConvertible).IsAssignableFrom(type!))
                {
                    var converted = Convert.ChangeType(lit.value, type);
                    return (converted, type);
                }
                else throw new NotSupportedException("Only convertible types can be used for literals.");
            }
        }

        protected Expression OperandRef(elm.OperandRefExpression ore, ExpressionBuilderContext ctx)
        {
            if (ctx.Operands.TryGetValue(ore.name!, out var expression))
                return expression;
            else throw new ArgumentException($"Operand reference to {ore.name} not found in definition operands.", nameof(ore));
        }

        protected Expression Case(elm.CaseExpression ce, ExpressionBuilderContext ctx)
        {

            //[{ when1, then1 }, { when2, then2}, { when3, then3 }]
            // when1 ? then 1 : (when2 ? then 2 : (when3 ? then 3 : else }
            if (ce.caseItem?.Length > 0 && ce.@else != null)
            {
                if (ce.comparand != null)
                {
                    var comparand = TranslateExpression(ce.comparand, ctx);

                    var elseThen = TranslateExpression(ce.@else!, ctx);
                    var lastItem = ce.caseItem[^1];
                    var lastItemWhen = TranslateExpression(lastItem.when!, ctx);
                    var lastItemWhenEquality = Expression.Coalesce(Equal(comparand, lastItemWhen, ctx), Expression.Constant(false));
                    var lastItemThen = TranslateExpression(lastItem.then!, ctx);

                    if (lastItemThen.Type != elseThen.Type)
                        throw new InvalidOperationException("Both conditional outcomes must have the same type.");

                    elseThen = Expression.Condition(lastItemWhenEquality, lastItemThen, elseThen);

                    for (int i = ce.caseItem.Length - 2; i > -1; i--)
                    {
                        var caseWhen = TranslateExpression(ce.caseItem[i].when!, ctx);
                        var caseWhenEquality = Expression.Coalesce(Equal(comparand, caseWhen, ctx), Expression.Constant(false));
                        var caseThen = TranslateExpression(ce.caseItem[i].then!, ctx);
                        if (elseThen.Type != caseThen.Type)
                            throw new InvalidOperationException("Case return types are not consistent.");
                        elseThen = Expression.Condition(caseWhenEquality, caseThen, elseThen);
                    }
                    return elseThen;
                }
                else
                {
                    var elseThen = TranslateExpression(ce.@else!, ctx);
                    var lastItem = ce.caseItem[^1];
                    var lastItemWhen = TranslateExpression(lastItem.when!, ctx);
                    var lastItemThen = TranslateExpression(lastItem.then!, ctx);

                    if (IsNullable(lastItemWhen.Type))
                    {
                        lastItemWhen = Expression.Coalesce(lastItemWhen, Expression.Constant(false));
                    }

                    elseThen = Expression.Condition(lastItemWhen, lastItemThen, elseThen);

                    for (int i = ce.caseItem.Length - 2; i > -1; i--)
                    {
                        var caseWhen = TranslateExpression(ce.caseItem[i].when!, ctx);
                        var caseThen = TranslateExpression(ce.caseItem[i].then!, ctx);
                        if (elseThen.Type != caseThen.Type)
                            throw new InvalidOperationException("Case return types are not consistent.");
                        if (IsNullable(caseWhen.Type))
                        {
                            caseWhen = Expression.Coalesce(caseWhen, Expression.Constant(false));
                        }
                        elseThen = Expression.Condition(caseWhen, caseThen, elseThen);
                    }
                    return elseThen;
                }
            }

            else throw new ArgumentException("Invalid case expression.  At least 1 case and an else must be present.", nameof(ce));
        }

        protected bool IsInterval(Type t, out Type? elementType)
        {
            if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(CqlInterval<>))
            {
                elementType = t.GetGenericArguments()[0];
                return true;
            }
            elementType = null;
            return false;
        }

        protected LambdaExpression WithToSelectManyBody(string outerScope,
            Type outerElementType,
            elm.WithExpression with,
            ExpressionBuilderContext ctx)
        {
            if (with.expression == null)
                throw new ArgumentException($"With must have a source expression.", nameof(with));
            if (with.suchThat == null)
                throw new ArgumentException($"With must have a suchthat expression.", nameof(with));

            //define "With Such That":
            //[Encounter] E
            //  with[Condition] P
            //   such that P.onset during E.period
            //     and P.abatement after end of E.period

            //Func<Bundle, Context, IEnumerable<Encounter>> x = (bundle, ctx) =>
            //    bundle.Entry.ByResourceType<Encounter>()
            //    .SelectMany(E =>
            //        bundle.Entry.ByResourceType<Condition>() // <-- 
            //            .Where(P => true) // such that goes here
            //            .Select(P => E));
            var selectManyParameter = Expression.Parameter(outerElementType, outerScope);
            var selectManyContext = ctx.WithScopes(new KeyValuePair<string, (Expression, elm.Expression)>(outerScope, (selectManyParameter, with)));
            var source = TranslateExpression(with.expression, selectManyContext);
            if (!IsOrImplementsIEnumerableOfT(source.Type))
            {
                // e.g.:
                // with "Index Prescription Start Date" IPSD
                // where IPSD is a Date
                // Promote to an array for consistency.
                var newArray = Expression.NewArrayInit(source.Type, source);
                source = newArray;
            }
            var sourcElementType = TypeResolver.GetListElementType(source.Type);

            var whereLambdaParameter = Expression.Parameter(sourcElementType, with.alias);
            var whereContext = selectManyContext.WithScopes(new KeyValuePair<string, (Expression, elm.Expression)>(with.alias!, (whereLambdaParameter, with)));
            var suchThatBody = TranslateExpression(with.suchThat, whereContext);

            var whereLambda = Expression.Lambda(suchThatBody, whereLambdaParameter);
            var callWhereOnSource = Operators.Bind(CqlOperator.Where, ctx.RuntimeContextParameter, source, whereLambda);

            var selectLambdaParameter = Expression.Parameter(sourcElementType, with.alias);
            var selectBody = selectManyParameter; // P => E
            var selectLambda = Expression.Lambda(selectBody, selectLambdaParameter);
            var callSelectOnWhere = Operators.Bind(CqlOperator.Select, ctx.RuntimeContextParameter, callWhereOnSource, selectLambda);
            var selectManyLambda = Expression.Lambda(callSelectOnWhere, selectManyParameter);

            return selectManyLambda;
        }

        protected LambdaExpression WithToSelectManyBody(Type tupleType,
            elm.WithExpression with, ExpressionBuilderContext ctx)
        {
            if (with.expression == null)
                throw new ArgumentException($"With must have a source expression.", nameof(with));
            if (with.suchThat == null)
                throw new ArgumentException($"With must have a suchthat expression.", nameof(with));

            //define "With Such That":
            //from [Encounter] enc,
            //  [Observation] obs
            //  with[Condition] P
            //   such that P.onset during E.period
            //     and P.abatement after end of E.period

            // A tuple type is created e.g.:
            // class Tuple1
            // {
            //      Encounter enc { get; set; }
            //      Observation obs { get; set; }
            // }
            //  We then cross join all combinations of encs and observations into an IEnumerable<TupleT>
            //  In the CQL, "enc" and "obs" are valid scopes in the with and such-that clauses.
            //  They need to resolve to property accessors
            //  on the lambda parameter we create for the SelectMany call.
            //  IEnumerable<Tuple1> source = <cross join expression>;
            //
            //  source
            //    .SelectMany(T => 
            //        bundle.Entry.ByResourceType<Condition>() // <-- 
            //            .Where(P => true) // such that goes here, in place of "true"
            //            .Select(P => E));

            var selectManyParameter = Expression.Parameter(tupleType, TypeNameToIdentifier(tupleType, ctx));
            var scopes = (from property in tupleType.GetProperties()
                          let propertyAccess = Expression.Property(selectManyParameter, property)
                          select new KeyValuePair<string, (Expression, elm.Expression)>(property.Name, (propertyAccess, with)))
                         .ToArray();
            var selectManyContext = ctx.WithScopes(scopes);

            var source = TranslateExpression(with.expression, selectManyContext);
            var sourceElementType = TypeResolver.GetListElementType(source.Type);

            var whereLambdaParameter = Expression.Parameter(sourceElementType, with.alias);
            var whereContext = selectManyContext.WithScopes(new KeyValuePair<string, (Expression, elm.Expression)>(with.alias!, (whereLambdaParameter, with)));
            var suchThatBody = TranslateExpression(with.suchThat, whereContext);
            var whereLambda = Expression.Lambda(suchThatBody, whereLambdaParameter);
            var callWhereOnSource = Operators.Bind(CqlOperator.Where, ctx.RuntimeContextParameter, source, whereLambda);

            var selectLambdaParameter = Expression.Parameter(sourceElementType, with.alias);
            var selectBody = selectManyParameter; // P => E
            var selectLambda = Expression.Lambda(selectBody, selectLambdaParameter);
            var callSelectOnWhere = Operators.Bind(CqlOperator.Select, ctx.RuntimeContextParameter, callWhereOnSource, selectLambda);

            var selectManyLambda = Expression.Lambda(callSelectOnWhere, selectManyParameter);
            return selectManyLambda;
        }

        protected Expression Retrieve(elm.RetrieveExpression retrieve, ExpressionBuilderContext ctx)
        {
            Type? sourceElementType;
            // SingletonFrom does not have this specified; in this case use DataType instead
            if (retrieve.resultTypeSpecifier == null)
            {
                if (string.IsNullOrWhiteSpace(retrieve.dataType))
                    throw new ArgumentException("If a Retrieve lacks a ResultTypeSpecifier it must have a DataType", nameof(retrieve));
                var dataType = retrieve.dataType;
                sourceElementType = TypeResolver.ResolveType(dataType);
            }
            else
            {
                if (retrieve.resultTypeSpecifier.type == "ListTypeSpecifier")
                {
                    if (retrieve.resultTypeSpecifier.elementType?.name == null)
                        throw new ArgumentException("Retrieve expression with a ListTypeSpecifier must have an element type", nameof(retrieve));
                    var listTypeName = retrieve.resultTypeSpecifier.elementType.name;
                    sourceElementType = TypeResolver.ResolveType(listTypeName);
                }
                else throw new NotImplementedException($"Sources with type {retrieve.resultTypeSpecifier.type} are not implemented.");
            }

            Expression? codeProperty;
            if (sourceElementType != null && retrieve.codeProperty != null)
            {
                var codePropertyInfo = TypeResolver.GetProperty(sourceElementType!, retrieve.codeProperty);
                codeProperty = Expression.Constant(codePropertyInfo, typeof(PropertyInfo));
            }
            else
            {
                codeProperty = Expression.Constant(null, typeof(PropertyInfo));
            }

            if (retrieve.codes != null)
            {
                if (retrieve.codes is elm.ValueSetRefExpression valueSetRef)
                {
                    if (string.IsNullOrWhiteSpace(valueSetRef.name))
                        throw new ArgumentException($"The ValueSetRef at {valueSetRef.locator} is missing a name.", nameof(retrieve));
                    var valueSet = InvokeDefinitionThroughRuntimeContext(valueSetRef.name!, valueSetRef!.libraryName, typeof(CqlValueSet), ctx);
                    var call = Operators.Bind(CqlOperator.Retrieve, ctx.RuntimeContextParameter,
                        Expression.Constant(sourceElementType, typeof(Type)), valueSet, codeProperty!);
                    return call;
                }
                else
                {
                    // In this construct, instead of querying a value set, we're testing resources
                    // against a list of codes, e.g., as defined by the code from or codesystem construct
                    var codes = TranslateExpression(retrieve.codes, ctx);
                    var call = Operators.Bind(CqlOperator.Retrieve, ctx.RuntimeContextParameter,
                        Expression.Constant(sourceElementType, typeof(Type)), codes, codeProperty!);
                    return call;
                }
            }
            else
            {
                var call = Operators.Bind(CqlOperator.Retrieve, ctx.RuntimeContextParameter,
                    Expression.Constant(sourceElementType, typeof(Type)), Expression.Constant(null, typeof(CqlValueSet)), codeProperty!);
                return call;
            }
        }

        protected Expression Property(elm.PropertyExpression op, ExpressionBuilderContext ctx)
        {
            if (string.IsNullOrWhiteSpace(op.path))
                throw new ArgumentException("path cannot be null or empty", nameof(op));
            //var path = ExpressionBuilderContext.NormalizeIdentifier(op.path);
            var path = op.path;
            if (!string.IsNullOrWhiteSpace(op.scope))
            {
                var scopeExpression = ctx.GetScopeExpression(op.scope!);
                var expectedType = TypeManager.TypeFor(op, ctx, false) ?? typeof(object);
                var pathMemberInfo = TypeResolver.GetProperty(scopeExpression.Type, path!) ??
                    TypeResolver.GetProperty(scopeExpression.Type, op.path);
                if (pathMemberInfo == null)
                {
                    ctx.LogWarning($"Property {op.path} can't be known at design time, and will be late-bound, slowing performance.  Consider casting the source first so that this property can be definitely bound.", op);
                    var call = Operators.Bind(CqlOperator.LateBoundProperty, ctx.RuntimeContextParameter,
                        scopeExpression, Expression.Constant(op.path, typeof(string)), Expression.Constant(expectedType, typeof(Type)));
                    return call;
                }
                var propogate = PropogateNull(scopeExpression, pathMemberInfo, ctx);
                // This is only necessary for Firely b/c it always initializes colleciton members even if they are 
                // not included in the FHIR, and this makes it impossible for CQL to differentiate [] from null
                //
                //if (typeof(Resource).IsAssignableFrom(scopeExpression.Type)
                //    && pathMemberInfo is PropertyInfo prop
                //    && IsOrImplementsIEnumerableOfT(prop.PropertyType))
                //{
                //    var method = typeof(BuiltIns).GetMethod(nameof(BuiltIns.NullIfEmpty))
                //        .MakeGenericMethod(GetElementType(prop.PropertyType));
                //    var call = Expression.Call(method, propogate);
                //    return call;
                //}
                var resultType = TypeManager.TypeFor(op, ctx, false);
                if (resultType != propogate.Type)
                {
                    propogate = ChangeType(propogate, resultType, ctx);
                }
                return propogate;
            }
            else if (op.source != null)
            {
                var source = TranslateExpression(op.source, ctx);
                var parts = path.Split('.');
                if (parts.Length > 1)
                {
                    // support paths like birthDate.value on Patient
                    for (int i = 0; i < parts.Length; i++)
                    {
                        var pathPart = parts[i];
                        var pathMemberInfo = TypeResolver.GetProperty(source.Type, pathPart!);
                        if (pathMemberInfo != null)
                        {
                            var propertyAccess = PropogateNull(source, pathMemberInfo, ctx);
                            source = propertyAccess;
                        }
                    }
                    return source;
                }
                else
                {
                    var expectedType = TypeManager.TypeFor(op, ctx, throwIfNotFound: true)!;
                    var result = PropertyHelper(source, path, expectedType, ctx);
                    return result;
                }
                throw new NotImplementedException();
            }
            else throw new NotImplementedException();
        }

        protected Expression PropertyHelper(Expression source, string? path, Type expectedType, ExpressionBuilderContext ctx)
        {
            var pathMemberInfo = TypeResolver.GetProperty(source.Type, path!);
            if (pathMemberInfo == null)
            {
                ctx.LogWarning($"Property {path} can't be known at design time, and will be late-bound, slowing performance.  Consider casting the source first so that this property can be definitely bound.");
                var call = Operators.Bind(CqlOperator.LateBoundProperty, ctx.RuntimeContextParameter,
                    source, Expression.Constant(path, typeof(string)), Expression.Constant(expectedType, typeof(Type)));
                return call;
            }
            if (pathMemberInfo is PropertyInfo property && pathMemberInfo.DeclaringType != source.Type) // the property is on a derived type, so cast it
            {
                var isCheck = Expression.TypeIs(source, pathMemberInfo.DeclaringType);
                var typeAs = Expression.TypeAs(source, pathMemberInfo.DeclaringType);
                var pathAccess = Expression.MakeMemberAccess(typeAs, pathMemberInfo);
                Expression? ifIs = pathAccess;
                Expression elseNull = Expression.Constant(null, property.PropertyType);
                // some ops, like properties on alias refs, don't have type information on them.
                // can't check against what we don't have.
                if (expectedType != null)
                {
                    if (expectedType != ifIs.Type)
                    {
                        ifIs = ChangeType(ifIs, expectedType!, ctx);
                    }
                    if (expectedType != elseNull.Type)
                        elseNull = ChangeType(elseNull, expectedType, ctx);
                }
                var condition = Expression.Condition(isCheck, ifIs, elseNull);
                return condition;
            }
            var propogateNull = PropogateNull(source, pathMemberInfo, ctx);
            var result = propogateNull;
            if (expectedType != null && expectedType != result.Type)
            {
                if (expectedType == typeof(string))
                {
                    if (result.Type.IsEnum)
                        return result;
                    else if (IsNullable(result.Type) && Nullable.GetUnderlyingType(result.Type).IsEnum)
                        return result;
                }
                result = ChangeType(result, expectedType, ctx);
            }
            return result;
        }

        protected Expression FunctionRef(elm.FunctionRefExpression op, ExpressionBuilderContext ctx)
        {
            var operands = op.operand
                .Select(operand => TranslateExpression(operand, ctx))
                .ToArray();
            var operandTypes = operands
                .Select(op => op.Type);

            var functionType = GetFunctionRefReturnType(op, operandTypes, ctx);

            var funcTypeParameters =
                new[] { typeof(CqlContext) }
                .Concat(operandTypes)
                .Concat(new[] { functionType })
                .ToArray();

            var funcType = GetFuncType(funcTypeParameters);
            var callStackCtor = typeof(CallStackEntry).GetConstructor(new[] { typeof(string), typeof(string), typeof(int?) });
            var newCallStack = Expression.New(callStackCtor,
                Expression.Constant(op.name, typeof(string)),
                Expression.Constant(op.locator, typeof(string)),
                Expression.Constant(op.localId, typeof(int?)));

            var deeper = Expression.Call(ctx.RuntimeContextParameter, typeof(CqlContext).GetMethod(nameof(CqlContext.Deeper)), newCallStack);

            // FHIRHelpers has special handling in CQL-to-ELM and does not translate correctly - specifically,
            // it interprets ToString(value string) oddly.  Normally when string is used in CQL it is resolved to the elm type.
            // In FHIRHelpers, this string gets treated as a FHIR string, which is normally mapped to a StringElement abstraction.
            if (op.libraryName != null && op.libraryName.StartsWith("fhirhelpers", StringComparison.OrdinalIgnoreCase))
            {
                if (op.name!.Equals("tostring", StringComparison.OrdinalIgnoreCase))
                {
                    if (operands[0].Type == typeof(string))
                    {
                        return operands[0];
                    }
                    else
                    {
                        var bind = Operators.Bind(CqlOperator.Convert, deeper,
                            new[] { operands[0], Expression.Constant(typeof(string), typeof(Type)) });
                        return bind;
                    }
                }
            }
            // all functions still take the bundle and context parameters, plus whatver the operands
            // to the actual function are.
            operands = new[]
            {
                    deeper
            }
            .Concat(operands)
            .ToArray();

            var invoke = InvokeDefinedFunctionThroughRuntimeContext(op.name!, op.libraryName!, funcType, operands, ctx);
            return invoke;
        }

        protected Type GetFuncType(Type[] funcTypeParameters)
        {
            Type? funcType;
            switch (funcTypeParameters.Length)
            {
                case 0:
                    throw new NotSupportedException();
                case 1:
                    funcType = typeof(Func<>).MakeGenericType(funcTypeParameters);
                    break;
                case 2:
                    funcType = typeof(Func<,>).MakeGenericType(funcTypeParameters);
                    break;
                case 3:
                    funcType = typeof(Func<,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 4:
                    funcType = typeof(Func<,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 5:
                    funcType = typeof(Func<,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 6:
                    funcType = typeof(Func<,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 7:
                    funcType = typeof(Func<,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 8:
                    funcType = typeof(Func<,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 9:
                    funcType = typeof(Func<,,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 10:
                    funcType = typeof(Func<,,,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 11:
                    funcType = typeof(Func<,,,,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 12:
                    funcType = typeof(Func<,,,,,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 13:
                    funcType = typeof(Func<,,,,,,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 14:
                    funcType = typeof(Func<,,,,,,,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                case 15:
                    funcType = typeof(Func<,,,,,,,,,,,,,,>).MakeGenericType(funcTypeParameters);
                    break;
                default:
                    throw new NotSupportedException("Fucntions with more than 15 parameters are not supported.");
            }
            return funcType;
        }

        protected Type GetFunctionRefReturnType(elm.FunctionRefExpression op, IEnumerable<Type> operandTypes, ExpressionBuilderContext ctx)
        {
            var operands = op.operand
                .Select(operand => TranslateExpression(operand, ctx))
                .Select(op => op.Type)
                .ToArray();
            if (op.libraryName?.StartsWith("FHIRHelpers") ?? false)
            {
                // cql-to-elm does not handle FHIRHelpers conversion function refs appropriately; they are missing resultTypeSpecifiers
                switch (op.name)
                {
                    case "ToDate":
                        return TypeResolver.ResolveType("{urn:hl7-org:elm-types:r1}Date")!;
                    case "ToDateTime":
                        return TypeResolver.ResolveType("{urn:hl7-org:elm-types:r1}DateTime")!;
                    case "ToQuantity":
                        return TypeResolver.ResolveType("{urn:hl7-org:elm-types:r1}Quantity")!;
                    case "ToInteger":
                        return TypeResolver.ResolveType("{urn:hl7-org:elm-types:r1}Integer")!;
                    case "ToInterval":
                        if (op.operand?.Length == 1)
                        {
                            var operand = op.operand![0];
                            var typeName = operand.resultTypeName;
                            if (operand is elm.AsExpression @as)
                            {
                                typeName = @as.asType;
                                if (typeName is null && @as.asTypeSpecifier != null)
                                    typeName = @as.asTypeSpecifier.resultTypeName;
                                if (typeName is null)
                                    typeName = @as.resultTypeName;
                            }
                            if (typeName == "{http://hl7.org/fhir}Period")
                            {
                                var pointType = TypeResolver.ResolveType("{urn:hl7-org:elm-types:r1}DateTime");
                                var intervalType = TypeResolver.IntervalType(pointType!);
                                return intervalType;
                            }
                            else if (typeName == "{http://hl7.org/fhir}Range")
                            {
                                var pointType = TypeResolver.ResolveType("{urn:hl7-org:elm-types:r1}Quantity");
                                var intervalType = TypeResolver.IntervalType(pointType!);
                                return intervalType;
                            }
                        }
                        throw new NotImplementedException();
                    case "ToBoolean":
                        return TypeResolver.ResolveType("{urn:hl7-org:elm-types:r1}Boolean")!;
                    case "ToString":
                        return TypeResolver.ResolveType("{urn:hl7-org:elm-types:r1}String")!;
                    case "ToDecimal":
                        return TypeResolver.ResolveType("{urn:hl7-org:elm-types:r1}Decimal")!;
                    case "ToRatio":
                        return TypeResolver.ResolveType("{urn:hl7-org:elm-types:r1}Ratio")!;
                    case "ToCode":
                        return TypeResolver.ResolveType("{urn:hl7-org:elm-types:r1}Code")!;
                    case "ToConcept":
                        return TypeResolver.ResolveType("{urn:hl7-org:elm-types:r1}Concept")!;
                    default: break;
                }
            }
            if (op.resultTypeSpecifier != null)
            {
                return TypeManager.TypeFor(op.resultTypeSpecifier, ctx);
            }
            else if (!string.IsNullOrWhiteSpace(op.resultTypeName))
            {
                return TypeResolver.ResolveType(op.resultTypeName!)
                    ?? TypeResolver.ResolveType(op.resultTypeName)
                    ?? throw new ArgumentException($"Cannot determine type for function {op.libraryName ?? ""}.{op.name}");
            }
            throw new ArgumentException($"Cannot determine type for function {op.libraryName ?? ""}.{op.name}");
        }

        protected Expression ExpressionRef(elm.ExpressionRefExpression expressionRef, ExpressionBuilderContext ctx)
        {
            Type? expressionType = null;
            if (expressionRef.resultTypeSpecifier != null)
            {
                expressionType = TypeManager.TypeFor(expressionRef.resultTypeSpecifier, ctx);
            }
            else if (!string.IsNullOrWhiteSpace(expressionRef.resultTypeName))
            {
                expressionType = TypeResolver.ResolveType(expressionRef.resultTypeName!);
            }
            else
            {
                var def = Package?.library?.statements?.def?
                    .SingleOrDefault(d => d.name == expressionRef.name);
                if (def != null)
                {
                    expressionType = TypeManager.TypeFor(def, ctx);
                }
                else throw new NotSupportedException("Unable to resolve expression reference type.");
            }
            if (expressionType == null)
                throw new InvalidOperationException($"Unable to determine type for {expressionRef.localId}");
            var invoke = InvokeDefinitionThroughRuntimeContext(expressionRef.name!, expressionRef.libraryName, expressionType, ctx);
            return invoke;
        }

        protected Expression ParameterRef(elm.ParameterRefExpression op, ExpressionBuilderContext ctx)
        {
            if (ctx.Definitions.TryGetValue(ThisLibraryKey, op.name!, out var lambda) && lambda != null)
            {
                var invoke = InvokeDefinitionThroughRuntimeContext(op.name!, null, lambda, ctx);
                return invoke;
            }
            else throw new ArgumentException($"Parameter {op.name} hasn't been defined yet.", nameof(op));

        }

        protected MemberInfo GetProperty(Type type, string name)
        {
            if (type.IsGenericType)
            {
                var gtd = type.GetGenericTypeDefinition();
                if (gtd == typeof(Nullable<>))
                {
                    if (string.Equals(name, "value", StringComparison.OrdinalIgnoreCase))
                    {
                        var valueMember = type.GetProperty("Value");
                        return valueMember;
                    }
                }
            }

            var member = type.GetProperty(name, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
            return member;
        }

        /// <param name="name">The function name</param>
        /// <param name="libraryAlias">If this is an external call, the local alias defined in the using statement</param>
        /// <param name="definitionType">The Func or Action type of this definition</param>
        /// <param name="arguments">The function arguments</param>
        /// <returns></returns>
        protected Expression InvokeDefinedFunctionThroughRuntimeContext(string name, string libraryAlias,
            Type definitionType,
            Expression[] arguments,
            ExpressionBuilderContext ctx)
        {
            var definitionsProperty = Expression.Property(ctx.RuntimeContextParameter, typeof(CqlContext).GetProperty(nameof(CqlContext.Definitions)));
            var itemProperty = typeof(DefinitionDictionary<Delegate>).GetProperty("Item", new[] { typeof(string), typeof(string), typeof(Type[]) });
            var argumentTypes = arguments
                .Skip(1) // skip runtimecontext
                .Select(arg => arg.Type)
                .ToArray();
            string? libraryName = null;
            if (!string.IsNullOrWhiteSpace(libraryAlias))
            {
                if (!ctx.LocalLibraryIdentifiers.TryGetValue(libraryAlias, out libraryName))
                    throw new InvalidOperationException($"Local library {libraryAlias} is not defined; are you missing a using statement?");
            }
            else libraryName = ThisLibraryKey;
            var typeArrayInitializer = Expression.NewArrayInit(typeof(Type),
                argumentTypes
                .Select(type => Expression.Constant(type))
                .ToArray());

            var indices = new Expression[] { Expression.Constant(libraryName, typeof(string)), Expression.Constant(name), typeArrayInitializer };
            var index = Expression.MakeIndex(definitionsProperty, itemProperty, indices);
            var asFunc = Expression.TypeAs(index, definitionType);
            var invoke = Expression.Invoke(asFunc, arguments);
            return invoke;
        }

        protected Expression InvokeDefinitionThroughRuntimeContext(string name, string? libraryAlias,
            LambdaExpression definition,
            ExpressionBuilderContext ctx)
        {
            var type = definition.Type;
            if (type.IsGenericType)
            {
                var typeArgs = type.GetGenericArguments();
                var returnType = typeArgs[^1];
                var invoke = InvokeDefinitionThroughRuntimeContext(name, libraryAlias, returnType, ctx);
                return invoke;
            }
            else throw new ArgumentException("LambdaExpressions should be a variant of Func<>");
        }

        protected Expression InvokeDefinitionThroughRuntimeContext(string name, string? libraryAlias,
        Type definitionReturnType,
        ExpressionBuilderContext ctx)
        {
            var definitionsProperty = Expression.Property(ctx.RuntimeContextParameter, typeof(CqlContext).GetProperty(nameof(CqlContext.Definitions)));
            // gets indexer that takes two strings - lib name and def name
            var itemProperty = typeof(DefinitionDictionary<Delegate>).GetProperty("Item", new[] { typeof(string), typeof(string) });
            Expression[]? indices;
            if (string.IsNullOrWhiteSpace(libraryAlias))
            {
                indices = new[] { Expression.Constant(ThisLibraryKey, typeof(string)), Expression.Constant(name) };
            }
            else
            {
                if (!ctx.LocalLibraryIdentifiers.TryGetValue(libraryAlias, out string libraryName))
                    throw new InvalidOperationException($"Local library {libraryAlias} is not defined; are you missing a using statement?");
                indices = new[] { Expression.Constant(libraryName), Expression.Constant(name) };
            }
            var index = Expression.MakeIndex(definitionsProperty, itemProperty, indices);
            var funcType = typeof(Func<,>).MakeGenericType(typeof(CqlContext), definitionReturnType);
            var asFunc = Expression.TypeAs(index, funcType);
            var invoke = Expression.Invoke(asFunc, new[] { ctx.RuntimeContextParameter });
            return invoke;
        }

        protected Expression CoalesceNullableValueType(Expression nullable)
        {
            if (nullable.Type.IsGenericType && nullable.Type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                var coalesce = Expression.Coalesce(nullable, Expression.Default(Nullable.GetUnderlyingType(nullable.Type)));
                return coalesce;
            }
            else return nullable;
        }

        protected static bool IsNullable(Type type) => type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        protected Expression HandleNullable(Expression expression, Type targetType)
        {
            if (IsNullable(targetType))
            {
                if (!IsNullable(expression.Type))
                    expression = Expression.Convert(expression, targetType);
            }
            else if (IsNullable(expression.Type))
                expression = CoalesceNullableValueType(expression);
            return expression;
        }
        protected Expression CrossJoin(elm.SourceExpression[] sources, Type tupleType, ExpressionBuilderContext ctx)
        {

            //var a = new int[] { 1, 2, 3 };
            //var b = new int[] { 4, 5, 6 };
            //var c = new int[] { 7, 8, 9 };

            //var result = a
            //    .SelectMany(_a =>
            //        b.SelectMany(_b =>
            //            c.Select(_c => new { _a, _b, _c, })))
            //    .ToArray();
            //Assert.AreEqual(27, result.Length);

            //var result2 =
            //    a.SelectMany(_a => b, (__a, _b) => new { __a, _b })
            //        .SelectMany(ab => c, (_ab, _c) => new { _ab.__a, _ab._b, _c })
            //            .ToArray();

            if (sources.Length < 2) throw new ArgumentException($"This method should only be called for 2 or more query sources", nameof(sources));

            // the first pair are special as they are not working off of a partially built tuple,
            // they are working only off of the initial selectmany parameters.
            var first = sources[0];
            var firstExpression = TranslateExpression(first.expression!, ctx);
            var firstElementType = TypeResolver.GetListElementType(firstExpression.Type);
            var second = sources[1];
            var secondExpression = TranslateExpression(second.expression!, ctx);
            var secondElementType = TypeResolver.GetListElementType(secondExpression.Type);

            var firstLambdaParameter = Expression.Parameter(firstElementType, $"_{first.alias}");
            var firstSelectManyParameter = Expression.Lambda(secondExpression, firstLambdaParameter);

            var secondLambdaParameter = Expression.Parameter(secondElementType, $"_{second.alias}");
            var @newTuple = Expression.New(tupleType);
            var memberInit = Expression.MemberInit(newTuple,
                Expression.Bind(tupleType.GetProperty(first.alias), firstLambdaParameter),
                Expression.Bind(tupleType.GetProperty(second.alias), secondLambdaParameter));
            var secondSelectManyParameter = Expression.Lambda(memberInit, firstLambdaParameter, secondLambdaParameter);

            var callSelectMany = Operators.Bind(CqlOperator.SelectManyResults, ctx.RuntimeContextParameter,
                firstExpression,
                firstSelectManyParameter,
                secondSelectManyParameter);

            var enumerableOfTupleType = callSelectMany.Type;

            if (sources.Length > 2)
            {
                for (int i = 2; i < sources.Length; i++)
                {
                    var source = sources[i];

                    var sourceExpression = TranslateExpression(source.expression!, ctx);
                    var sourceElementType = TypeResolver.GetListElementType(sourceExpression.Type);

                    var parameterName = string.Join(string.Empty, sources.Take(i).Select(st => st.alias));
                    var parameter = Expression.Parameter(tupleType, $"_{parameterName}");
                    var p1 = Expression.Lambda(sourceExpression, parameter);

                    // .SelectMany(ab => c, (ab,c) => new Tuple { x = ab.x,  y = ab.y, c = c } )
                    var ab = Expression.Parameter(tupleType, parameterName);
                    var c = Expression.Parameter(sourceElementType, $"_{source.alias}");
                    var bindings = new MemberAssignment[i + 1];
                    for (int j = 0; j < i; j++)
                    {
                        var prop = tupleType.GetProperty(sources[j].alias);
                        bindings[j] = Expression.Bind(prop, Expression.Property(ab, prop));
                    }
                    bindings[i] = Expression.Bind(tupleType.GetProperty(source.alias), c);
                    @newTuple = Expression.New(tupleType);
                    memberInit = Expression.MemberInit(newTuple, bindings);
                    var p2 = Expression.Lambda(memberInit, ab, c);

                    var callAgain = Operators.Bind(CqlOperator.SelectManyResults, ctx.RuntimeContextParameter,
                        callSelectMany,
                        p1,
                        p2);
                    callSelectMany = callAgain;
                }
            }
            return callSelectMany;
        }

        /// <summary>
        /// Implements the null propogation operator (x?.y) into (x == null ? null : x.y);
        /// </summary>
        protected Expression PropogateNull(Expression before, MemberInfo member, ExpressionBuilderContext ctx)
        {
            if (before.Type.IsValueType)
                return before;
            else
            {
                Type? memberType;
                if (member is PropertyInfo property)
                    memberType = property.PropertyType;
                else if (member is FieldInfo field)
                    memberType = field.FieldType;
                else throw new NotImplementedException();
                var parameter = Expression.Parameter(before.Type, TypeNameToIdentifier(before.Type, ctx));
                var body = Expression.MakeMemberAccess(parameter, member);
                var lambda = Expression.Lambda(body, parameter);
                var call = Operators.Bind(CqlOperator.PropertyOrDefault, ctx.RuntimeContextParameter,
                    before, lambda, Expression.Constant(before.Type, typeof(Type)), Expression.Constant(memberType, typeof(Type)));
                return call;
            }
        }

        protected string TypeNameToIdentifier(Type type, ExpressionBuilderContext? ctx)
        {
            var typeName = type.Name.ToLowerInvariant();
            if (type.IsGenericType)
            {
                var genericTypeNames = string.Join("_", type.GetGenericArguments().Select(t => TypeNameToIdentifier(t, null)));
                var tick = typeName.IndexOf('`');
                if (tick > -1)
                    typeName = typeName[..tick];
                var fullName = $"{typeName}_{genericTypeNames}";
                typeName = fullName;
            }

            if (ctx != null)
            {
                int i = 1;
                var uniqueTypeName = typeName;
                while (ctx.HasScope(uniqueTypeName))
                {
                    uniqueTypeName = $"{typeName}{i}";
                    i++;
                }
                typeName = uniqueTypeName;
            }

            return ExpressionBuilderContext.NormalizeIdentifier(typeName!)!;
        }


        protected readonly MethodInfo EnumGetName = typeof(Enum).GetMethod(nameof(Enum.GetName), new[] { typeof(Type), typeof(string) });

        protected readonly Lazy<MethodInfo> MakeGenericLambda = new(() =>
            (from method in
                typeof(Expression).GetMethods(BindingFlags.Public | BindingFlags.Static)
             where method.Name == nameof(Expression.Lambda)
                 && method.IsGenericMethod
             let parameters = method.GetParameters()
             where parameters.Length == 2
             && parameters[0].ParameterType == typeof(Expression)
             && parameters[1].ParameterType == typeof(ParameterExpression[])
             select method).Single());


        protected LambdaExpression NotImplemented(string nav, Type[] functionParameterTypes, Type returnType, ExpressionBuilderContext context)
        {
            var parameters = functionParameterTypes
                .Select((type, index) => Expression.Parameter(type, TypeNameToIdentifier(type, context) + index))
                .ToArray();
            var ctor = typeof(NotImplementedException).GetConstructor(new[] { typeof(string) });
            var @new = Expression.New(ctor, Expression.Constant($"External function {nav} is not implemented."));
            var @throw = Expression.Throw(@new, returnType);
            var lambda = Expression.Lambda(@throw, parameters);
            //var funcTypes = new Type[functionParameterTypes.Length + 1];
            //Array.Copy(functionParameterTypes, funcTypes, functionParameterTypes.Length);
            //funcTypes[funcTypes.Length - 1] = returnType;
            //var funcType = GetFuncType(funcTypes);
            //var makeLambda = MakeGenericLambda.Value.MakeGenericMethod(funcType);
            //var lambda = (LambdaExpression)makeLambda.Invoke(null, new object[] { @throw, parameters });
            return lambda;
        }

    }
}

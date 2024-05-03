using Hl7.Cql.CqlToElm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Hl7.Cql.Elm;
using Hl7.Fhir.Model;
using Hl7.Fhir.Support;
using static Hl7.Fhir.Model.OperationOutcome;
using Hl7.Cql.Compiler;

namespace Hl7.Cql.Api
{
    /// <summary>
    /// 
    /// </summary>
    public class CqlExpressionRunner
    {
        readonly CqlContext _cqlContext;
        readonly InvocationBuilder _invocationBuilder;
        readonly ElmFactory _elmFactory;
        readonly CqlToElmConverter _defaultConverter;
        readonly ExpressionBuilder _expressionBuilder;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceProvider"></param>
        public CqlExpressionRunner(IServiceProvider serviceProvider)
        {
            _cqlContext = FhirCqlContext.ForBundle();
            _invocationBuilder = serviceProvider.GetRequiredService<InvocationBuilder>();
            _elmFactory = serviceProvider.GetRequiredService<ElmFactory>();
            _defaultConverter = serviceProvider.GetRequiredService<CqlToElmConverter>();

            var lib = new Elm.Library
            {
                identifier = new VersionedIdentifier { id = "Lambdas", version = "1.0.0" }
            };
            _expressionBuilder = ExpressionBuilderFor(lib, serviceProvider.GetRequiredService<ILogger<ExpressionBuilder>>());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Resource RunExpression(string cqlExpression) 
        {
            OperationOutcome outcome = new OperationOutcome();
            try
            {               
                var expression = Expression(cqlExpression);
                var expressionErrors = expression.GetErrors();
                if (expressionErrors.Any())
                {
                    var issues = expressionErrors.Select(s => new IssueComponent()
                    {
                        Code = IssueType.Invalid,
                        Severity = IssueSeverity.Error,
                        Details = new CodeableConcept()
                        {

                        }
                    });
                    outcome.Issue.AddRange(issues);
                    return outcome;
                }

                var expressionValue = _expressionBuilder.Lambda(expression).Compile().DynamicInvoke(_cqlContext);

                outcome.Issue.Add(new IssueComponent()
                {
                    Code = IssueType.Success,
                    Severity = IssueSeverity.Success,
                    Details = new CodeableConcept("http://hl7.org/fhir/uv/cql/expression-result", $"{expressionValue}", $"Result for CQL Expression {cqlExpression}")
                });

                return outcome;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                outcome.Issue.Add(new IssueComponent()
                {
                    Code = IssueType.Invalid,
                    Severity = IssueSeverity.Error,
                    Details = new CodeableConcept("http://hl7.org/fhir/uv/cql/syntax-error", message)
                });
                return outcome;
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="memberName"></param>
        /// <returns></returns>
        protected Elm.Expression Expression(string expression, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "func")
        {
            var lib = ConvertLibrary($@"
                library Test version '1.0.0'

                define private ""{memberName}"": {expression}");
            return lib.statements[0].expression;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cql"></param>
        /// <returns></returns>
        protected Elm.Library ConvertLibrary(string cql) =>_defaultConverter.ConvertLibrary(cql);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lib"></param>
        /// <param name="logger"></param>
        /// <returns></returns>
        ExpressionBuilder ExpressionBuilderFor(Elm.Library lib, ILogger<ExpressionBuilder> logger)
        {
            var tr = FhirTypeResolver.Default;
            var tc = FhirTypeConverter.Default;
            var tm = new TypeManager(tr);
            var binding = new CqlOperatorsBinding(tr, tc);
            var expressionBuilder = new ExpressionBuilder(binding, tm, lib, logger);
            return expressionBuilder;
        }
    }
}

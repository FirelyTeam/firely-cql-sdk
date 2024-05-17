using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Hl7.Cql.Api.Controllers
{

    /// <summary>
    /// 
    /// </summary>
    [Route("")]
    [ApiController]    
    public class CqlController : ControllerBase
    {

        private readonly CqlExpressionRunner _runner;
        private JsonSerializerOptions _serializerOptions = new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector).Pretty();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="runner"></param>
        public CqlController(CqlExpressionRunner runner)
        {
            _runner = runner;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("$cql")]
        public Parameters GetCqlAsync([FromQuery] string expression, [FromQuery] string? expectation)
        {
            var outcome = _runner.RunExpression(expression, expectation);
            return outcome;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost("$cql")]
        public Parameters PostCqlAsync([FromBody]Hl7.Fhir.Model.Parameters parameters)
        {
            var expression = parameters.Parameter.FirstOrDefault(p => p.Name == "expression")?.Value.ToString();
            var expectation = parameters.Parameter.FirstOrDefault(p => p.Name == "expectation")?.Value.ToString();
            var result = _runner.RunExpression(expression!, expectation);
            return result;
        }


    }
}

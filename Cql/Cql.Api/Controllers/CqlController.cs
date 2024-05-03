using Hl7.Fhir.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public Resource RunCqlAsync([FromQuery] string expression)
        {
            var outcome = _runner.RunExpression(expression);
            return outcome;
        }


    }
}

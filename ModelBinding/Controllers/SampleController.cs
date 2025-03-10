using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet("custom-object-binding")]
        public IActionResult CustomObjectBinding([FromQuery] string complexData)
        {
            var parts = complexData.Split(',');
            if (parts?.Length == 3)
            {
                var customObject = new CustomObject
                {
                    Name = parts[0],
                    Age = int.Parse(parts[1]),
                    Location = parts[2]
                };
                return Ok(customObject);
            }
            return BadRequest("Invalid custom format");
        }

        [HttpPost("multi-source-binding")]
        public IActionResult MultiSourceBinding([FromHeader(Name = "X-Custom-Header")] string headerValue, [FromQuery] string queryValue, [FromBody] ComplexBodyModel bodyModel)
        {
            var mergedResult = new MergedModel
            {
                Header = headerValue,
                Query = queryValue,
                BodyData = bodyModel?.Data
            };
            return Ok(mergedResult);
        }

        [HttpPost("tuple-binding")]
        public IActionResult TupleBinding([FromQuery] CustomTupleModel model)
        {
            return Ok($"Tuple Data : Item1 = {model.Item1}, Item2 = {model.Item2}");
        }

        [HttpPost("large-data-binding")]
        public IActionResult LargeDataBinding([FromBody] LargeDataModel model)
        {
            return Ok("Data Received Successfully");
        }



    }
}

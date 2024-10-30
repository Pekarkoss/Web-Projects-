using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace Ödev1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IValuesService _valuesService;

        public ValuesController(IValuesService valuesService)
        {
            _valuesService = valuesService;
        }

        [HttpGet("GetAll")]
        public ActionResult<Response<List<Point>>> GetAll()
        {
            var response = _valuesService.GetAll();
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPost("AddPoint")]
        public ActionResult<Response<string>> AddPoint(Point point)
        {
            var response = _valuesService.AddPoint(point);
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpDelete("Delete")]
        public ActionResult<Response<string>> RemovePoint(long id)
        {
            var response = _valuesService.RemovePoint(id);
            if (response.Success)
            {
                return Ok(response);
            }
            return NotFound(response);
        }

        [HttpGet("Getbyid/{id}")]
        public ActionResult<Response<Point>> GetbyId(long id)
        {
            var response = _valuesService.GetbyId(id);
            if (response.Success)
            {
                return Ok(response);
            }
            return NotFound(response);
        }

        [HttpPut("UpdateNameCords")]
        public ActionResult<Response<Point>> Update(long id, string newName, double newPointX, double newPointY)
        {
            var response = _valuesService.Update(id, newName, newPointX, newPointY);
            if (response.Success)
            {
                return Ok(response);
            }
            return NotFound(response);
        }
    }
}
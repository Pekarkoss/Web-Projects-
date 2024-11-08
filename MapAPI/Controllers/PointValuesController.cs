using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;
using MyWebApi.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyWebApi.Controllers
   
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class PointValuesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PointValuesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PointValue>>> GetPointValues()
        {
            var pointValues = await _unitOfWork.PointValueRepository.GetAllAsync();
            return Ok(pointValues);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PointValue>> GetPointValue(long id)
        {
            var pointValue = await _unitOfWork.PointValueRepository.GetByIdAsync(id);
            if (pointValue == null)
            {
                return NotFound();
            }
            return Ok(pointValue);
        }

        [HttpPost]
        public async Task<ActionResult<PointValue>> PostPointValue(PointValue pointValue)
        {

            var createdPointValue = await _unitOfWork.PointValueRepository.CreateAsync(pointValue);
            await _unitOfWork.CompleteAsync();
            return CreatedAtAction(nameof(GetPointValue), new { id = createdPointValue.Id }, createdPointValue);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPointValue(long id, PointValue pointValue)
        {
            if (id != pointValue.Id)
            {
                return BadRequest();
            }

            await _unitOfWork.PointValueRepository.UpdateAsync(pointValue);
            await _unitOfWork.CompleteAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePointValue(long id)
        {
            await _unitOfWork.PointValueRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
            return NoContent();
        }
    }
}

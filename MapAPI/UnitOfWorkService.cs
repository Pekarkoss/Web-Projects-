using MyWebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyWebApi.Services
{
    public class PointValueService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PointValueService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PointValue>> GetAllAsync()
        {
            return await _unitOfWork.PointValueRepository.GetAllAsync();
        }

        public async Task<PointValue> GetByIdAsync(long id)
        {
            return await _unitOfWork.PointValueRepository.GetByIdAsync(id);
        }

        public async Task<PointValue> CreateAsync(PointValue pointValue)
        {

            var createdPointValue = await _unitOfWork.PointValueRepository.CreateAsync(pointValue);
            await _unitOfWork.CompleteAsync();
            return createdPointValue;
        }

        public async Task UpdateAsync(PointValue pointValue)
        {

            await _unitOfWork.PointValueRepository.UpdateAsync(pointValue);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteAsync(long id)
        {
            await _unitOfWork.PointValueRepository.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }
    }
}

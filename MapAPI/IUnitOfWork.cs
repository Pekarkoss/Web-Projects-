using MyWebApi.Models;
using System.Threading.Tasks;

namespace MyWebApi.Services
{
    public interface IUnitOfWork
    {
        IGenericRepository<PointValue> PointValueRepository { get; }
        Task<int> CompleteAsync();
    }
}

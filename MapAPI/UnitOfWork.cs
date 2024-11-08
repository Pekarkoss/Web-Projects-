using MapApi;
using MyWebApi.Models;
using System.Threading.Tasks;

namespace MyWebApi.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private IGenericRepository<PointValue> _pointValueRepository;

        public UnitOfWork(DataContext context){_context = context;}

        public IGenericRepository<PointValue> PointValueRepository
        {
            get {  return _pointValueRepository ??= new GenericRepository<PointValue>(_context); }
        }
        public async Task<int> CompleteAsync(){ return await _context.SaveChangesAsync(); }
    }
}
